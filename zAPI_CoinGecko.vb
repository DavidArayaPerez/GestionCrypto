'
'
'
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
    Private Const CG_API_KEY As String = "CG-yZ2PmLgi8HqjvmqefkWdbZfk"
    Private Const CG_BASE_URL As String = "https://api.coingecko.com/api/v3/"
    '
    ' ---------------------------------------------------------------
    '  Lista general de monedas ordenadas por market cap
    ' ---------------------------------------------------------------
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
        Dim url As String = CG_BASE_URL & $"coins/markets" & $"?vs_currency=usd" & $"&order=market_cap_desc" & $"&per_page={cantidad}" & $"&page={pagina}" & $"&sparkline=false" & $"&x_cg_demo_api_key={CG_API_KEY}"
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
                Supply_Maximo = 0

                Dim supplyNode As JsonNode = item("max_supply")
                If Not supplyNode Is Nothing OrElse supplyNode.GetValueKind() = JsonValueKind.Null Then Supply_Maximo = CLng(supplyNode.GetValue(Of Double)())
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
                    '
                    Matriz_Monedas(Fila, 0) = CrearCodigoInterno()                             '0  ID_Moneda
                    Matriz_Monedas(Fila, 1) = CrearCodigoInterno()                             '1  ID_Despliegue
                    Matriz_Monedas(Fila, 2) = Simbolo                                          '2  Simbolo
                    Matriz_Monedas(Fila, 3) = LimpiarTexto(ValorSeguro(item("name")))          '3  Nombre_Oficial
                    Matriz_Monedas(Fila, 4) = ValorSeguro(item("id"))                          '4  Slug_API
                    'Matriz_Monedas(Fila, 5) = 0                                               '5  Tipo_Activo
                    'Matriz_Monedas(Fila, 6) = 0                                               '6  Subtipo_Stablecoin
                    'Matriz_Monedas(Fila, 7) = 0                                               '7  Moneda_Paridad
                    'Matriz_Monedas(Fila, 8) = 0                                               '8  Centralizada
                    'Matriz_Monedas(Fila, 9) = 0                                               '9  Activo_Subyacente
                    'Matriz_Monedas(Fila, 10) = 0                                              '10 ID_Red_Nativa
                    Matriz_Monedas(Fila, 11) = Supply_Maximo                                   '11 Supply_Maximo
                    'Matriz_Monedas(NuevaFila, 12) = 0                                         '12 Contract_Address
                End If
                '
                'Si ya existe actualiza los precios de mercado
                Matriz_Monedas(Fila, 13) = ValorSeguro(item("market_cap_rank"))                '13 Market_cap_rank
                Matriz_Monedas(Fila, 14) = LinkCoinGecko                                       '14 Link CoinGecko
                Matriz_Monedas(Fila, 15) = ValorSeguro(item("Current_Price"))                  '15 Current_Price
                Matriz_Monedas(Fila, 16) = ValorSeguro(item("hight_24h"))                      '16 Hight24h
                Matriz_Monedas(Fila, 17) = ValorSeguro(item("low_24h"))                        '17 Low24h
                Matriz_Monedas(Fila, 18) = ValorSeguro(item("price_change_24h"))               '18 Price Change 24h
                Matriz_Monedas(Fila, 19) = ValorSeguro(item("proce_change_percentage_24h"))    '19 Price Change Percentage 24h
                Matriz_Monedas(Fila, 20) = ValorSeguro(item("circulating_supply"))             '20 Circulating Supply
                Matriz_Monedas(Fila, 21) = ValorSeguro(item("last_updated"))                   '21 Fecha Actualizacion
                'Matriz_Monedas(Fila, 22) = "0"                                                '22 Actualizacion Automatica (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
                Guardar_Matrices("Monedas")
            Next
        Catch ex As Exception
            MsgBox("Error leyendo API CoinGecko (Monedas): " & ex.Message)
        End Try
    End Sub

    ' ---------------------------------------------------------------
    '  Detalle de una moneda por slug
    '  Obtiene precios en tiempo real (ByRef) y gestiona la matriz
    ' ---------------------------------------------------------------
    Public Function API_CoinGecko_ActualizaValor(ByVal slug As String) As Boolean
        Dim SW As Boolean = True
        Dim Fila As Integer = 0
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 2).ToUpper() = slug Then
                SW = False
                Fila = i
                Exit For
            End If
        Next
        If SW Then
            MsgBox("La moneda " & slug & " no existe en la matriz. Se intentará agregarla desde la API.")
            Return False
        End If

        Dim url As String = CG_BASE_URL & $"coins/{slug.ToLower()}" & $"?localization=false&tickers=false" & $"&market_data=true&community_data=false&developer_data=false" & $"&x_cg_demo_api_key={CG_API_KEY}"
        '
        Try
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)
            Dim marketData As JsonNode = item("market_data")
            '
            '0  ID_Moneda
            '1  ID_Despliegue
            '2  Simbolo
            '3  Nombre_Oficial
            '4  Slug_API
            '5  Tipo_Activo
            '6  Subtipo_Stablecoin
            '7  Moneda_Paridad
            '8  Centralizada
            '9  Activo_Subyacente
            '10 ID_Red_Nativa
            '11 Supply_Maximo
            '12 Contract_Address
            '13 Market_cap_rank
            '14 Link CoinGecko
            Matriz_Monedas(Fila, 15) = ValorSeguro(marketData?("current_price")?("usd"))            '15 Current_Price
            Matriz_Monedas(Fila, 16) = ValorSeguro(marketData?("high_24h")?("usd"))                 '16 Hight24h
            Matriz_Monedas(Fila, 17) = ValorSeguro(marketData?("low_24h")?("usd"))                  '17 Low24h
            Matriz_Monedas(Fila, 18) = ValorSeguro(marketData?("price_change_24h"))                 '18 Price Change 24h
            Matriz_Monedas(Fila, 19) = ValorSeguro(marketData?("price_change_percentage_24h"))      '19 Price Change Percentage 24h
            Matriz_Monedas(Fila, 20) = ValorSeguro(marketData?("circulating_supply"))               '20 Circulating Supply
            Matriz_Monedas(Fila, 21) = ValorSeguro(marketData?("last_updated"))                     '21 Fecha Actualizacion
            'Matriz_Monedas(Fila, 22) = "0"                                                         '22 Actualizacion Automatica
            Guardar_Matrices("Monedas")
            Return True
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
    '
    ' ── Helpers ────────────────────────────────────────────────────
    '
    Private Function ValorSeguro(node As JsonNode) As String
        Return If(node Is Nothing, "0", node.ToString())
    End Function
    '
    '
    '
End Module