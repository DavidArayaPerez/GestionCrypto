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
    ' ------------------------------------------------------------
    '  Lista general de monedas ordenadas por market cap
    ' ------------------------------------------------------------
    Public Sub ActualizarMonedas()
        'Carga valores actualizados de MONEDAS
        API_CoinGecko_Monedas(250, 1)
        API_CoinGecko_Monedas(250, 2)
        API_CoinGecko_Monedas(250, 3)
        API_CoinGecko_Monedas(250, 4)
        API_CoinGecko_Monedas(250, 5)
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
    '
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
            If Matriz_Monedas(i, 2).ToUpper() = slug Then
                MsgBox("La moneda " & slug & " YA EXISTE en la matriz.")
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
            MsgBox("Error leyendo API CoinGecko (Detalle): " & ex.Message)
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
    Private Function ValorSeguro(node As JsonNode) As String
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
        Matriz_Monedas(Fila, 0) = CrearCodigoInterno()  '0  ID_Moneda
        Matriz_Monedas(Fila, 1) = CrearCodigoInterno()  '1  ID_Despliegue
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

    '
    '
    '
End Module