'
'
'
Imports System.Globalization
Imports System.Net
Imports System.Text.Json
Imports System.Text.Json.Nodes
'
'
'
Module zAPI_CoinGecko

    ' ============================================================
    '  Modelo — refleja exactamente las columnas del TSV
    ' ============================================================
    Public Class Moneda
        Public Property ID_Moneda As String
        Public Property ID_Despliegue As String
        Public Property Simbolo As String
        Public Property Nombre_Oficial As String
        Public Property Slug_API As String
        Public Property Tipo_Activo As String
        Public Property Subtipo_Stablecoin As String
        Public Property Moneda_Paridad As String
        Public Property Centralizada As String
        Public Property Activo_Subyacente As String
        Public Property ID_Red_Nativa As String
        Public Property Supply_Maximo As Long
        Public Property Contract_Address As String
        Public Property Activa As String
    End Class
    '
    ' ============================================================
    '  Servicio CoinGecko — estilo WebClient + Sub síncrono
    ' ============================================================
    '
    Private Const CG_BASE_URL As String = "https://api.coingecko.com/api/v3/"
    '
    '
    '
    Public Sub ActualizarMonedas()
        ' ------------------------------------------------------------
        '  Lista general de monedas ordenadas por market cap
        ' ------------------------------------------------------------
        'Carga valores actualizados de MONEDAS
        API_CoinGecko_Monedas(50, 1)
        'API_CoinGecko_Monedas(250, 2)
        'API_CoinGecko_Monedas(250, 3)
        'API_CoinGecko_Monedas(250, 4)
        'API_CoinGecko_Monedas(250, 5)
        MsgBox("Monedas actualizadas correctamente")
    End Sub
    Public Sub API_CoinGecko_Monedas(Optional ByVal cantidad As Integer = 50, Optional ByVal pagina As Integer = 1)
        'Caputura las monedas ordenadas por Market CAP con un limite de 250 por pagina que es el max que permite la API de COINGEKO separado por paginas
        Dim url As String = CG_BASE_URL & $"coins/markets" & $"?vs_currency=usd" & $"&order=market_cap_desc" & $"&per_page={cantidad}" & $"&page={pagina}" & $"&sparkline=false" & $"&x_cg_demo_api_key={API_COINGEKO}"
        If cantidad < 1 Then cantidad = 1
        If cantidad > 250 Then cantidad = 250
        '
        Try
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            '
            '
            Dim monedas As JsonArray = JsonNode.Parse(json).AsArray()
            Dim Simbolo As String
            Dim Supply_Maximo As Long
            Dim LinkCoinGecko As String
            Dim SW As Boolean
            Dim i As Integer
            Dim Fila As Integer
            '
            For Each item As JsonNode In monedas
                Simbolo = ValorSeguro(item("symbol")).ToUpper()
                LinkCoinGecko = "https://www.coingecko.com/es/monedas/" & ValorSeguro(item("id"))
                '
                Dim supplyNode As JsonNode = item("max_supply")
                If supplyNode Is Nothing OrElse supplyNode.GetValueKind() = JsonValueKind.Null Then
                    Supply_Maximo = 0
                Else
                    Supply_Maximo = CLng(supplyNode.GetValue(Of Double)())
                End If
                '
                '
                'Recorre la matriz para saber si ya existe la moneda
                SW = True
                For i = 1 To Matriz_MonedasTF
                    If Matriz_Monedas(i, 2).ToUpper() = Simbolo Then
                        SW = False
                        Fila = i
                        Exit For
                    End If
                Next
                '
                If SW Then
                    ' No existe la moneda — se agrega a la matriz
                    Fila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                    Matriz_Monedas(Fila, 0) = CrearCodigoInterno()  '0  ID_Moneda
                    Matriz_Monedas(Fila, 1) = CrearCodigoInterno()  '1  ID_Despliegue
                    '
                    ActualizarMatrizMoneda_ValoresBasicos(
                        Fila,
                        Simbolo,                                    '2  Simbolo
                        LimpiarTexto(ValorSeguro(item("name"))),    '3  Nombre_Oficial
                        ValorSeguro(item("id")),                    '4  Slug_API
                        Supply_Maximo,                              '11 Supply_Maximo
                        ValorSeguro(item("market_cap_rank")))       '13 Market_cap_rank
                End If
                '
                'Si ya existe actualiza los precios de mercado
                ActualizaMatrizMoneda_ValorMoneda(
                    Fila,
                    ValorSeguro(item("current_price")),
                    ValorSeguro(item("high_24h")),
                    ValorSeguro(item("low_24h")),
                    ValorSeguro(item("price_change_24h")),
                    ValorSeguro(item("price_change_percentage_24h")),
                    ValorSeguro(item("circulating_supply")),
                    ValorSeguro(item("last_updated")))
                '
                Guardar_Matrices("Monedas")
            Next
            '
            '
            '
        Catch ex As Exception
            MsgBox("Error leyendo API CoinGecko (Monedas): " & ex.Message)
        End Try
    End Sub
    Public Function API_CoinGecko_ActualizaValor(ByVal slug As String) As Boolean
        'Actualiza solo el valor de mercado
        Dim SW As Boolean = True
        Dim Fila As Integer = 0
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 4) = slug Then
                SW = False
                Fila = i
                Exit For
            End If
        Next
        If SW Then
            MsgBox("La moneda " & slug & " no existe en la matriz. Se intentará agregarla desde la API.")
            Return False
        End If
        '
        Dim url As String = CG_BASE_URL & $"coins/{slug.ToLower()}" & $"?localization=false&tickers=false" & $"&market_data=true&community_data=false&developer_data=false" & $"&x_cg_demo_api_key={API_COINGEKO}"
        '
        Try
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)
            Dim marketData As JsonNode = item("market_data")
            '
            ActualizaMatrizMoneda_ValorMoneda(
                Fila,
                ValorSeguro(marketData?("current_price")?("usd")),
                ValorSeguro(marketData?("high_24h")?("usd")),
                ValorSeguro(marketData?("low_24h")?("usd")),
                ValorSeguro(marketData?("price_change_24h")),
                ValorSeguro(marketData?("price_change_percentage_24h")),
                ValorSeguro(marketData?("circulating_supply")),
                ValorSeguro(marketData?("last_updated")))
            Guardar_Matrices("Monedas")
            Return True
            '
            '
        Catch ex As Exception
            MsgBox("Error leyendo API CoinGecko (Detalle): " & ex.Message)
            Return False
        End Try
    End Function
    Public Function API_CoinGecko_NuevaMoneda(ByVal slug As String) As Integer
        Dim url As String = CG_BASE_URL & $"coins/{slug.ToLower()}" & $"?localization=false&tickers=false" & $"&market_data=true&community_data=false&developer_data=false" & $"&x_cg_demo_api_key={API_COINGEKO}"
        '
        'Agrega una nueva MONEDA
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 4).ToLower() = slug.ToLower() Then
                MsgBox("La moneda con slug '" & slug & "' YA EXISTE en la matriz.")
                Return 0
            End If
        Next
        '
        Try
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)
            Dim marketData As JsonNode = item("market_data")
            '
            Dim Fila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
            Matriz_Monedas(Fila, 0) = CrearCodigoInterno()                      '0  ID_Moneda
            Matriz_Monedas(Fila, 1) = CrearCodigoInterno()                      '1  ID_Despliegue
            '
            ActualizarMatrizMoneda_ValoresBasicos(
                        Fila,
                        ValorSeguro(item("symbol")).ToUpper(),                  '2  Simbolo
                        LimpiarTexto(ValorSeguro(item("name"))),                '3  Nombre_Oficial
                        ValorSeguro(item("id")),                                '4  Slug_API
                        "0",                                                    '11 Supply_Maximo
                        ValorSeguro(item("market_data")?("market_cap_rank")))   '13 Market_cap_rank
            '
            Guardar_Matrices("Monedas")
            Return Fila
            '
            '
        Catch ex As Exception
            MsgBox("Error al leer datos de " & slug & " en API CoinGecko." & vbCrLf & "Puede que no exista la Moneda." & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
    Private Function LimpiarTexto(ByVal texto As String) As String
        Dim resultado As String = ""
        For Each c As Char In texto
            If Asc(c) <= 127 Then resultado &= c
        Next
        Return resultado
    End Function
    Public Function ValorSeguro(node As JsonNode) As String
        Return If(node Is Nothing, "0", node.ToString())
    End Function
    Public Function ConvertirFechaUTCaChile(ByVal fechaISO As String) As String
        Try
            If fechaISO = "0" OrElse String.IsNullOrWhiteSpace(fechaISO) Then Return ""
            Dim fechaUTC As DateTime = DateTime.Parse(fechaISO, Nothing, DateTimeStyles.RoundtripKind)
            Dim zonaChile As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific SA Standard Time")
            Dim fechaChile As DateTime = TimeZoneInfo.ConvertTime(fechaUTC, zonaChile)
            Return fechaChile.ToString("dd-MM-yyyy HH:mm:ss", New CultureInfo("es-CL"))
        Catch
            Return fechaISO ' si falla, devuelve el valor original sin explotar
        End Try
    End Function
    Private Sub ActualizaMatrizMoneda_ValorMoneda(
            Fila As Integer,
            Current_Price As String,
            Hight24h As String,
            Low24h As String,
            PriceChange24h As String,
            PriceChangePercentage24h As String,
            CirculatingSupply As String,
            FechaActualizacion As String)
        Matriz_Monedas(Fila, 15) = Current_Price
        Matriz_Monedas(Fila, 16) = Hight24h
        Matriz_Monedas(Fila, 17) = Low24h
        Matriz_Monedas(Fila, 18) = PriceChange24h
        Matriz_Monedas(Fila, 19) = PriceChangePercentage24h
        Matriz_Monedas(Fila, 20) = CirculatingSupply
        Matriz_Monedas(Fila, 21) = FechaActualizacion
    End Sub
    Private Sub ActualizarMatrizMoneda_ValoresBasicos(
            Fila As Integer,
            Simbolo As String,          '2
            Nombre As String,           '3
            Slug_API As String,         '4
            Supply_Maximo As String,    '11
            MarketCapRank As String)    '13
        '

        Matriz_Monedas(Fila, 2) = Simbolo               '2  Simbolo
        Matriz_Monedas(Fila, 3) = Nombre                '3  Nombre_Oficial
        Matriz_Monedas(Fila, 4) = Slug_API              '4  Slug_API
        Matriz_Monedas(Fila, 5) = 0                     '5  Tipo_Activo
        Matriz_Monedas(Fila, 6) = 0                     '6  Subtipo_Stablecoin
        Matriz_Monedas(Fila, 7) = 0                     '7  Moneda_Paridad
        Matriz_Monedas(Fila, 8) = 0                     '8  Centralizada
        Matriz_Monedas(Fila, 9) = 0                     '9  Activo_Subyacente
        Matriz_Monedas(Fila, 10) = 0                    '10 ID_Red_Nativa
        Matriz_Monedas(Fila, 11) = Supply_Maximo        '11 Supply_Maximo
        Matriz_Monedas(Fila, 12) = 0                    '12 Contract_Address
        Matriz_Monedas(Fila, 13) = MarketCapRank        '13 Market_cap_rank
        Matriz_Monedas(Fila, 14) = "https://www.coingecko.com/es/monedas/" & Slug_API    '14 Link
        '
        Matriz_Monedas(Fila, 23) = "CryptoMoneda"       '23 Tipo Moneda
    End Sub
    Public Sub AsignarRedNativa_MonedasSinRed()
        ' ============================================================
        '  Asignar Red Nativa a monedas que tienen ID_Red_Nativa = "0"
        '  Consulta CoinGecko por cada moneda sin red asignada,
        '  obtiene asset_platform_id y lo cruza con Matriz_Redes.
        ' ============================================================
        Dim monedasActualizadas As Integer = 0
        Dim monedasSinMatch As Integer = 0
        Dim detalleSinMatch As String = ""
        '
        ' Descargar catálogo de plataformas UNA sola vez al inicio
        ' para no hacer una llamada extra por cada red nueva
        Dim plataformas As Dictionary(Of String, JsonNode) = ObtenerCatalogoPlatformas()
        '
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 10) <> "0" Then Continue For
            If Matriz_Monedas(i, 23) <> "CryptoMoneda" Then Continue For
            '
            Dim slug As String = Matriz_Monedas(i, 4)
            Dim simbolo As String = Matriz_Monedas(i, 2)
            '
            If slug = "0" OrElse String.IsNullOrWhiteSpace(slug) Then Continue For
            '
            Try
                ' --- 1. Obtener platform_id desde CoinGecko ---
                Dim platformId As String = ObtenerPlatformId(slug)
                If String.IsNullOrWhiteSpace(platformId) Then Continue For
                '
                ' --- 2. Buscar en Matriz_Redes ---
                Dim filaRed As Integer = 0
                For r As Integer = 1 To Matriz_RedesTF
                    If Matriz_Redes(r, 4).ToLower() = platformId Then
                        filaRed = r
                        Exit For
                    End If
                Next r
                '
                ' --- 3. Si no existe la red, agregarla ahora ---
                If filaRed = 0 Then
                    filaRed = AgregarRedDesdesCatalogo(platformId, plataformas)
                End If
                '
                ' --- 4. Asignar o registrar fallo ---
                If filaRed > 0 Then
                    Matriz_Monedas(i, 10) = Matriz_Redes(filaRed, 0)
                    monedasActualizadas += 1
                Else
                    monedasSinMatch += 1
                    detalleSinMatch &= $"  • {simbolo} ({slug}) → plataforma: '{platformId}'" & vbCrLf
                End If
                '
                Threading.Thread.Sleep(2500)
                '
            Catch ex As Exception
                detalleSinMatch &= $"  • {simbolo} ({slug}) → ERROR: {ex.Message}" & vbCrLf
                monedasSinMatch += 1
            End Try
        Next i
        '
        ' --- 5. Guardar ambas matrices si hubo cambios ---
        If monedasActualizadas > 0 Then
            Guardar_Matrices("Redes")
            Guardar_Matrices("Monedas")
        End If
        '
        ' --- 6. Informe final ---
        Dim resumen As String = $"Proceso completado." & vbCrLf & vbCrLf & $"✔ Monedas actualizadas: {monedasActualizadas}" & vbCrLf & $"✘ Sin coincidencia: {monedasSinMatch}"
        '
        If detalleSinMatch <> "" Then resumen &= vbCrLf & vbCrLf & "Monedas que no pudieron resolverse:" & vbCrLf & detalleSinMatch
        MsgBox(resumen, vbInformation, "AsignarRedNativa_MonedasSinRed")
    End Sub
    Private Function AgregarRedDesdesCatalogo(ByVal platformId As String, ByVal plataformas As Dictionary(Of String, JsonNode)) As Integer
        ' ------------------------------------------------------------
        '  Agrega una red nueva a Matriz_Redes usando el catálogo
        '  ya descargado. Devuelve la fila creada, o 0 si falla.
        ' ------------------------------------------------------------
        Dim nombreOficial As String = platformId  ' fallback
        Dim chainId As String = "0"
        Dim esEVM As String = "No"
        '
        If plataformas IsNot Nothing AndAlso plataformas.ContainsKey(platformId) Then
            Dim p As JsonNode = plataformas(platformId)
            nombreOficial = ValorSeguro(p("name"))
            Dim chainNode As JsonNode = p("chain_identifier")
            If chainNode IsNot Nothing AndAlso
           chainNode.GetValueKind() <> JsonValueKind.Null Then
                chainId = chainNode.ToString()
                esEVM = "Si"
            End If
        End If
        '
        Try
            Dim filaRed As Integer = AgrandarMatriz(Matriz_Redes, Matriz_RedesTF, Matriz_RedesTC)
            '
            Matriz_Redes(filaRed, 0) = CrearCodigoInterno()
            Matriz_Redes(filaRed, 1) = chainId
            Matriz_Redes(filaRed, 2) = nombreOficial
            Matriz_Redes(filaRed, 3) = nombreOficial
            Matriz_Redes(filaRed, 4) = platformId
            Matriz_Redes(filaRed, 5) = "L1"    ' Por defecto, revisar manualmente si es L2
            Matriz_Redes(filaRed, 6) = "0"
            Matriz_Redes(filaRed, 7) = "0"
            Matriz_Redes(filaRed, 8) = esEVM
            Matriz_Redes(filaRed, 9) = "0"
            Matriz_Redes(filaRed, 10) = "0"
            Matriz_Redes(filaRed, 11) = "0"
            Matriz_Redes(filaRed, 12) = "0"
            Matriz_Redes(filaRed, 13) = "0"
            Matriz_Redes(filaRed, 14) = "0"
            Matriz_Redes(filaRed, 15) = "0"
            Matriz_Redes(filaRed, 16) = "0"
            Matriz_Redes(filaRed, 17) = "S"
            Return filaRed
            '
        Catch ex As Exception
            Return 0
        End Try
        '
    End Function
    Public Sub AgregarRedesFaltantes_DesdeCoinGecko()
        ' ============================================================
        '  Agregar redes faltantes a Matriz_Redes desde CoinGecko
        '  Recibe la lista de slugs de plataforma que no se encontraron
        '  en Redes.txt, consulta la API y agrega cada red nueva.
        '  Luego vuelve a ejecutar AsignarRedNativa_MonedasSinRed()
        '  para completar el cruce con Monedas.
        ' ============================================================
        '
        ' --- 1. Recolectar slugs de plataforma de monedas sin red ---
        Dim slugsPendientes As New List(Of String)
        '
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 10) <> "0" Then Continue For
            If Matriz_Monedas(i, 23) <> "CryptoMoneda" Then Continue For

            Dim slug As String = Matriz_Monedas(i, 4)
            If slug = "0" OrElse String.IsNullOrWhiteSpace(slug) Then Continue For

            ' Determinar el platformId igual que en AsignarRedNativa_MonedasSinRed
            Dim platformId As String = ObtenerPlatformId(slug)
            If String.IsNullOrWhiteSpace(platformId) Then Continue For

            ' Verificar que realmente no esté en Matriz_Redes
            Dim yaExiste As Boolean = False
            For r As Integer = 1 To Matriz_RedesTF
                If Matriz_Redes(r, 4).ToLower() = platformId.ToLower() Then
                    yaExiste = True
                    Exit For
                End If
            Next r

            If Not yaExiste AndAlso Not slugsPendientes.Contains(platformId.ToLower()) Then
                slugsPendientes.Add(platformId.ToLower())
            End If

            Threading.Thread.Sleep(2500) ' respetar límite API demo
        Next i

        If slugsPendientes.Count = 0 Then
            MsgBox("No hay redes nuevas para agregar.", vbInformation)
            Return
        End If

        ' --- 2. Para cada slug pendiente, consultar /coins/asset_platforms ---
        '  CoinGecko tiene el endpoint /asset_platforms que devuelve la lista
        '  completa de plataformas con id, name, chain_identifier (Chain ID EVM).
        Dim plataformas As Dictionary(Of String, JsonNode) = ObtenerCatalogoPlatformas()

        Dim redesAgregadas As Integer = 0
        Dim detalle As String = ""

        For Each platformId As String In slugsPendientes

            Dim nombreOficial As String = platformId  ' fallback
            Dim chainId As String = "0"
            Dim esEVM As String = "No"

            ' Buscar en el catálogo de plataformas
            If plataformas IsNot Nothing AndAlso plataformas.ContainsKey(platformId) Then
                Dim p As JsonNode = plataformas(platformId)
                nombreOficial = ValorSeguro(p("name"))
                Dim chainNode As JsonNode = p("chain_identifier")
                If chainNode IsNot Nothing AndAlso chainNode.GetValueKind() <> JsonValueKind.Null Then
                    chainId = chainNode.ToString()
                    esEVM = "Si"
                End If
            End If

            ' Crear nueva fila en Matriz_Redes
            Dim filaRed As Integer = AgrandarMatriz(Matriz_Redes, Matriz_RedesTF, Matriz_RedesTC)

            Matriz_Redes(filaRed, 0) = CrearCodigoInterno()   '0  ID_Interno
            Matriz_Redes(filaRed, 1) = chainId                '1  Chain_ID
            Matriz_Redes(filaRed, 2) = nombreOficial          '2  Nombre_Oficial
            Matriz_Redes(filaRed, 3) = nombreOficial          '3  Nombre_Corto (igual por ahora)
            Matriz_Redes(filaRed, 4) = platformId             '4  Slug_API
            Matriz_Redes(filaRed, 5) = "L1"                  '5  Tipo_Capa (L1 por defecto, ajustar manual si es L2)
            Matriz_Redes(filaRed, 6) = "0"                   '6  L1_Padre
            Matriz_Redes(filaRed, 7) = "0"                   '7  Tipo_Rollup
            Matriz_Redes(filaRed, 8) = esEVM                 '8  Compatible_EVM
            Matriz_Redes(filaRed, 9) = "0"                   '9  Mecanismo_Consenso
            Matriz_Redes(filaRed, 10) = "0"                  '10 Token_Nativo
            Matriz_Redes(filaRed, 11) = "0"                  '11 Decimales
            Matriz_Redes(filaRed, 12) = "0"                  '12 Tiempo_Bloque
            Matriz_Redes(filaRed, 13) = "0"                  '13 Color_Marca
            Matriz_Redes(filaRed, 14) = "0"                  '14 URL_Explorador
            Matriz_Redes(filaRed, 15) = "0"                  '15 URL_Logo
            Matriz_Redes(filaRed, 16) = "0"                  '16 URL_RPC
            Matriz_Redes(filaRed, 17) = "S"                  '17 Activa

            redesAgregadas += 1
            detalle &= $"  + {nombreOficial} (slug: {platformId}, ChainID: {chainId}, EVM: {esEVM})" & vbCrLf
        Next

        ' --- 3. Guardar Redes.txt ---
        If redesAgregadas > 0 Then
            Guardar_Matrices("Redes")
        End If

        ' --- 4. Informe y oferta de continuar ---
        Dim resumen As String = $"Redes agregadas: {redesAgregadas}" & vbCrLf & vbCrLf & detalle & vbCrLf &
                                "Nota: Tipo_Capa se asignó 'L1' por defecto. " &
                                "Revisa manualmente las que sean L2 en F_Red." & vbCrLf & vbCrLf &
                                "¿Desea ejecutar ahora 'AsignarRedNativa_MonedasSinRed' para completar el cruce?"

        Dim respuesta As MsgBoxResult = MsgBox(resumen, vbYesNo + vbInformation, "AgregarRedesFaltantes")
        If respuesta = MsgBoxResult.Yes Then
            AsignarRedNativa_MonedasSinRed()
        End If

    End Sub
    Private Function ObtenerPlatformId(ByVal slug As String) As String
        ' ------------------------------------------------------------
        '  Auxiliar: obtiene el asset_platform_id de una moneda en CoinGecko
        '  Reutilizable para no duplicar la llamada HTTP
        ' ------------------------------------------------------------
        '
        Try
            Dim url As String = CG_BASE_URL & $"coins/{slug.ToLower()}" &
                                "?localization=false&tickers=false" &
                                "&market_data=false&community_data=false" &
                                $"&developer_data=false&x_cg_demo_api_key={API_COINGEKO}"

            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)

            Dim platformNode As JsonNode = item("asset_platform_id")
            If platformNode IsNot Nothing AndAlso
               platformNode.GetValueKind() <> JsonValueKind.Null Then
                Dim pid As String = platformNode.ToString().Trim()
                If Not String.IsNullOrWhiteSpace(pid) Then Return pid
            End If

            ' Coin nativa → la red tiene el mismo slug que la moneda
            Return slug.ToLower()

        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Function ObtenerCatalogoPlatformas() As Dictionary(Of String, JsonNode)
        ' ------------------------------------------------------------
        '  Auxiliar: descarga el catálogo completo de plataformas de CoinGecko
        '  Endpoint: /asset_platforms  → id, name, chain_identifier
        ' ------------------------------------------------------------
        '
        Dim resultado As New Dictionary(Of String, JsonNode)
        Try
            Dim url As String = CG_BASE_URL & $"asset_platforms?x_cg_demo_api_key={API_COINGEKO}"
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim array As JsonArray = JsonNode.Parse(json).AsArray()

            For Each p As JsonNode In array
                Dim id As String = ValorSeguro(p("id")).ToLower()
                If Not String.IsNullOrWhiteSpace(id) AndAlso id <> "0" Then
                    resultado(id) = p
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al obtener catálogo de plataformas: " & ex.Message)
        End Try
        Return resultado
    End Function
    '
    '
    '
End Module