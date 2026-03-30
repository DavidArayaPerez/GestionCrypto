'
'
'
Imports System.Net.Http
Imports System.Text.Json
Imports System.Text.Json.Nodes
'
'
'
Module mCoinGecko
    '
    '
    '
    '

    ' ============================================================
    '  Modelo — refleja exactamente las columnas del TSV
    ' ============================================================
    Public Class Moneda
        Public Property ID_Moneda As String          ' Identificador único del token (concepto)
        Public Property ID_Despliegue As String      ' Identificador único de esta fila/despliegue
        Public Property Simbolo As String            ' Ej: BTC, ETH, USDT
        Public Property Nombre_Oficial As String     ' Ej: Bitcoin, Ethereum
        Public Property Slug_API As String           ' Ej: bitcoin, ethereum (ID de CoinGecko)
        Public Property Tipo_Activo As String        ' coin_nativa | stablecoin | token_defi | wrapped
        Public Property Subtipo_Stablecoin As String ' fiat | crypto | algoritmica | commodity | 0
        Public Property Moneda_Paridad As String     ' USD | EUR | XAU | 0
        Public Property Centralizada As String       ' Si | No | 0
        Public Property Activo_Subyacente As String  ' BTC, ETH... solo para wrapped | 0
        Public Property ID_Red_Nativa As String      ' Referencia al ID_Interno del TSV de redes
        Public Property Supply_Maximo As Long        ' 0 si no tiene tope
        Public Property Contract_Address As String   ' Dirección del contrato | 0 si coin_nativa
        Public Property Activa As String             ' Si | No
    End Class

    ' ============================================================
    '  Servicio CoinGecko
    ' ============================================================
    Public Class CoinGeckoService

        Private Shared ReadOnly _httpClient As New HttpClient() With {
            .BaseAddress = New Uri("https://api.coingecko.com/api/v3/"),
            .Timeout = TimeSpan.FromSeconds(30)
        }

        ''' <summary>
        ''' Obtiene monedas desde CoinGecko ordenadas por market cap.
        ''' </summary>
        ''' <param name="cantidad">Cuántas monedas traer (máx 250 por llamada).</param>
        ''' <param name="pagina">Número de página (empieza en 1).</param>
        ''' <returns>Lista de objetos Moneda con los campos del TSV.</returns>
        Public Shared Async Function ObtenerMonedasAsync(
                Optional cantidad As Integer = 50,
                Optional pagina As Integer = 1) As Task(Of List(Of Moneda))

            Dim resultado As New List(Of Moneda)

            ' Validar rango permitido por CoinGecko
            cantidad = Math.Min(Math.Max(cantidad, 1), 250)

            Dim url = $"coins/markets?vs_currency=usd" &
                      $"&order=market_cap_desc" &
                      $"&per_page={cantidad}" &
                      $"&page={pagina}" &
                      $"&sparkline=false"

            Dim response = Await _httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()

            Dim json = Await response.Content.ReadAsStringAsync()
            Dim monedas = JsonNode.Parse(json).AsArray()

            For Each item In monedas
                Dim moneda As New Moneda()

                ' Campos que vienen directos de la API
                moneda.Slug_API = ValorSeguro(item("id"))
                moneda.Simbolo = ValorSeguro(item("symbol")).ToUpper()
                moneda.Nombre_Oficial = ValorSeguro(item("name"))

                ' Supply máximo — puede ser null en la API
                Dim supplyNode = item("max_supply")
                moneda.Supply_Maximo = If(supplyNode Is Nothing OrElse supplyNode.GetValueKind() = JsonValueKind.Null,
                                          0,
                                          CLng(supplyNode.GetValue(Of Double)()))

                ' Campos que debes completar manualmente o con lógica propia
                moneda.ID_Moneda = GenerarID()
                moneda.ID_Despliegue = GenerarID()
                moneda.Tipo_Activo = "coin_nativa"    ' Ajustar según clasificación
                moneda.Subtipo_Stablecoin = "0"
                moneda.Moneda_Paridad = "0"
                moneda.Centralizada = "0"
                moneda.Activo_Subyacente = "0"
                moneda.ID_Red_Nativa = "0"            ' Completar con ID del TSV de redes
                moneda.Contract_Address = "0"
                moneda.Activa = "Si"

                resultado.Add(moneda)
            Next

            Return resultado
        End Function

        ''' <summary>
        ''' Obtiene el detalle de una moneda específica por su slug,
        ''' incluyendo sus contract addresses en todas las redes.
        ''' </summary>
        ''' <param name="slug">Ej: "jupiter", "uniswap", "tether"</param>
        Public Shared Async Function ObtenerDetalleMonedaAsync(slug As String) As Task(Of List(Of Moneda))

            Dim resultado As New List(Of Moneda)

            Dim url = $"coins/{slug}?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false"

            Dim response = Await _httpClient.GetAsync(url)
            response.EnsureSuccessStatusCode()

            Dim json = Await response.Content.ReadAsStringAsync()
            Dim item = JsonNode.Parse(json)

            Dim slugAPI = ValorSeguro(item("id"))
            Dim simbolo = ValorSeguro(item("symbol")).ToUpper()
            Dim nombre = ValorSeguro(item("name"))

            Dim supplyNode = item("market_data")?("max_supply")
            Dim supplyMax As Long = If(supplyNode Is Nothing OrElse supplyNode.GetValueKind() = JsonValueKind.Null,
                                       0,
                                       CLng(supplyNode.GetValue(Of Double)()))

            Dim idMoneda = GenerarID()

            ' CoinGecko devuelve los contratos por red en "platforms"
            Dim platforms = item("platforms")?.AsObject()

            If platforms IsNot Nothing AndAlso platforms.Count > 0 Then
                ' Una fila por cada red donde está desplegado el contrato
                For Each plat In platforms
                    Dim address = If(plat.Value IsNot Nothing, plat.Value.ToString(), "0")
                    If String.IsNullOrWhiteSpace(address) Then address = "0"

                    Dim moneda As New Moneda() With {
                        .ID_Moneda = idMoneda,
                        .ID_Despliegue = GenerarID(),
                        .Simbolo = simbolo,
                        .Nombre_Oficial = nombre,
                        .Slug_API = slugAPI,
                        .Tipo_Activo = "token_defi",   ' Ajustar según clasificación
                        .Subtipo_Stablecoin = "0",
                        .Moneda_Paridad = "0",
                        .Centralizada = "0",
                        .Activo_Subyacente = "0",
                        .ID_Red_Nativa = "0",           ' Mapear plat.Key al ID del TSV de redes
                        .Supply_Maximo = supplyMax,
                        .Contract_Address = address,
                        .Activa = "Si"
                    }

                    resultado.Add(moneda)
                Next
            Else
                ' Sin contratos — es coin_nativa
                resultado.Add(New Moneda() With {
                    .ID_Moneda = idMoneda,
                    .ID_Despliegue = GenerarID(),
                    .Simbolo = simbolo,
                    .Nombre_Oficial = nombre,
                    .Slug_API = slugAPI,
                    .Tipo_Activo = "coin_nativa",
                    .Subtipo_Stablecoin = "0",
                    .Moneda_Paridad = "0",
                    .Centralizada = "0",
                    .Activo_Subyacente = "0",
                    .ID_Red_Nativa = "0",
                    .Supply_Maximo = supplyMax,
                    .Contract_Address = "0",
                    .Activa = "Si"
                })
            End If

            Return resultado
        End Function


        ' ── Helpers ────────────────────────────────────────────

        Private Shared Function ValorSeguro(node As JsonNode) As String
            Return If(node Is Nothing, "0", node.ToString())
        End Function

        ''' <summary>Genera un ID alfanumérico de 8 letras mayúsculas, igual al formato del TSV.</summary>
        Private Shared Function GenerarID() As String
            Const chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim rnd As New Random()
            Return New String(Enumerable.Range(0, 8).Select(Function(x) chars(rnd.Next(chars.Length))).ToArray())
        End Function

    End Class

    '
    '
    '
End Module
