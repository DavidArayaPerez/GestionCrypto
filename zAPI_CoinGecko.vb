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
            Dim MarketCapRank As String
            Dim SW As Boolean
            Dim i As Integer
            '
            For Each item As JsonNode In monedas
                Simbolo = ValorSeguro(item("symbol")).ToUpper()
                MarketCapRank = ValorSeguro(item("market_cap_rank"))
                SW = True
                For i = 1 To Matriz_MonedasTF
                    If Matriz_Monedas(i, 2).ToUpper() = Simbolo Then
                        SW = False
                        Exit For
                    End If
                Next
                If SW Then
                    ' No existe la moneda — se agrega a la matriz
                    Dim supplyNode As JsonNode = item("max_supply")
                    If supplyNode Is Nothing OrElse supplyNode.GetValueKind() = JsonValueKind.Null Then
                        Supply_Maximo = 0
                    Else
                        Supply_Maximo = CLng(supplyNode.GetValue(Of Double)())
                    End If
                    '
                    Dim NuevaFila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                    Matriz_Monedas(NuevaFila, 0) = CrearCodigoInterno()                     '0  ID_Moneda
                    Matriz_Monedas(NuevaFila, 1) = CrearCodigoInterno()                     '1  ID_Despliegue
                    Matriz_Monedas(NuevaFila, 2) = Simbolo                                  '2  Simbolo
                    Matriz_Monedas(NuevaFila, 3) = LimpiarTexto(ValorSeguro(item("name")))  '3  Nombre_Oficial
                    Matriz_Monedas(NuevaFila, 4) = ValorSeguro(item("id"))                  '4  Slug_API
                    'Matriz_Monedas(NuevaFila, 5) = 0                                       '5  Tipo_Activo
                    'Matriz_Monedas(NuevaFila, 6) = 0                                       '6  Subtipo_Stablecoin
                    'Matriz_Monedas(NuevaFila, 7) = 0                                       '7  Moneda_Paridad
                    'Matriz_Monedas(NuevaFila, 8) = 0                                       '8  Centralizada
                    'Matriz_Monedas(NuevaFila, 9) = 0                                       '9  Activo_Subyacente
                    'Matriz_Monedas(NuevaFila, 10) = 0                                      '10 ID_Red_Nativa
                    Matriz_Monedas(NuevaFila, 11) = Supply_Maximo                           '11 Supply_Maximo
                    'Matriz_Monedas(NuevaFila, 12) = 0                                      '12 Contract_Address
                    Matriz_Monedas(NuevaFila, 13) = MarketCapRank                           '13 Market_cap_rank
                    Matriz_Monedas(NuevaFila, 14) = "0"                                     '14 Link CoinGecko
                    Matriz_Monedas(NuevaFila, 15) = "0"                                     '15 Current_Price
                    Matriz_Monedas(NuevaFila, 16) = "0"                                     '16 Hight24h
                    Matriz_Monedas(NuevaFila, 17) = "0"                                     '17 Low24h
                    Matriz_Monedas(NuevaFila, 18) = "0"                                     '18 Price Change 24h
                    Matriz_Monedas(NuevaFila, 19) = "0"                                     '19 Price Change Percentage 24h
                    Matriz_Monedas(NuevaFila, 20) = "0"                                     '20 Circulating Supply
                    Matriz_Monedas(NuevaFila, 21) = "0"                                     '21 Fecha Actualizacion
                    'Matriz_Monedas(NuevaFila, 22) = "0"                                     '22 Actualizacion Automatica (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
                    Guardar_Matrices("Monedas")
                Else
                    ' Moneda existente — actualizar rank si cambió
                    If Val(Matriz_Monedas(i, 13)) <> Val(MarketCapRank) Then
                        Matriz_Monedas(i, 13) = MarketCapRank
                        Guardar_Matrices("Monedas")
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error leyendo API CoinGecko (Monedas): " & ex.Message)
        End Try
    End Sub

    ' ---------------------------------------------------------------
    '  Detalle de una moneda por slug
    '  Obtiene precios en tiempo real (ByRef) y gestiona la matriz
    ' ---------------------------------------------------------------
    Public Function API_CoinGecko_ActualizaValor(ByVal slug As String, ByRef current_price As String, ByRef high_24h As String, ByRef low_24h As String, ByRef price_change_24h As String, ByRef price_change_percentage_24h As String, ByRef circulating_supply As String) As Boolean
        Dim url As String = CG_BASE_URL & $"coins/{slug.ToLower()}" & $"?localization=false&tickers=false" & $"&market_data=true&community_data=false&developer_data=false" & $"&x_cg_demo_api_key={CG_API_KEY}"
        '
        ' Inicializar ByRef en caso de error
        current_price = "0" : high_24h = "0" : low_24h = "0"
        price_change_24h = "0" : price_change_percentage_24h = "0" : circulating_supply = "0"
        '
        Try
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            '
            '
            '
            Dim item As JsonNode = JsonNode.Parse(json)
            '
            Dim slugAPI As String = ValorSeguro(item("id"))
            Dim Simbolo As String = ValorSeguro(item("symbol")).ToUpper()
            Dim Nombre As String = ValorSeguro(item("name"))
            Dim MarketCapRank As String = ValorSeguro(item("market_cap_rank"))
            '
            ' ── Datos de precio (ByRef) ──
            Dim marketData As JsonNode = item("market_data")
            current_price = ValorSeguro(marketData?("current_price")?("usd"))
            high_24h = ValorSeguro(marketData?("high_24h")?("usd"))
            low_24h = ValorSeguro(marketData?("low_24h")?("usd"))
            price_change_24h = ValorSeguro(marketData?("price_change_24h"))
            price_change_percentage_24h = ValorSeguro(marketData?("price_change_percentage_24h"))
            circulating_supply = ValorSeguro(marketData?("circulating_supply"))
            '
            ' ── Supply máximo ──
            Dim supplyNode As JsonNode = marketData?("max_supply")
            Dim Supply_Maximo As Long = 0
            If supplyNode IsNot Nothing AndAlso supplyNode.GetValueKind() <> JsonValueKind.Null Then
                Supply_Maximo = CLng(supplyNode.GetValue(Of Double)())
            End If
            '
            ' ── Buscar si la moneda ya existe en la matriz ──
            Dim SW As Boolean = True
            Dim i As Integer
            For i = 1 To Matriz_MonedasTF
                If Matriz_Monedas(i, 2).ToUpper() = Simbolo Then
                    SW = False
                    Exit For
                End If
            Next
            '
            Dim platforms As JsonObject = item("platforms")?.AsObject()
            '
            If SW Then
                ' ── MONEDA NUEVA ──
                If platforms IsNot Nothing AndAlso platforms.Count > 0 Then
                    ' ID_Moneda compartido para todas las filas del mismo token
                    Dim ID_Moneda As String = CrearCodigoInterno()
                    For Each plat As KeyValuePair(Of String, JsonNode) In platforms
                        Dim address As String = If(plat.Value IsNot Nothing, plat.Value.ToString(), "0")
                        If String.IsNullOrWhiteSpace(address) Then address = "0"
                        '
                        ' Mapear slug de red (plat.Key) al ID_Interno de Matriz_Redes (col 4 = Slug_API)
                        Dim ID_Red As String = "0"
                        For j As Integer = 1 To Matriz_RedesTF
                            If Matriz_Redes(j, 4).ToLower() = plat.Key.ToLower() Then
                                ID_Red = Matriz_Redes(j, 0)
                                Exit For
                            End If
                        Next
                        '
                        Dim NuevaFila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                        Matriz_Monedas(NuevaFila, 0) = ID_Moneda                                '0  ID_Moneda      (mismo para todas las redes)
                        Matriz_Monedas(NuevaFila, 1) = CrearCodigoInterno()                     '1  ID_Despliegue  (único por fila)
                        Matriz_Monedas(NuevaFila, 2) = Simbolo                                  '2  Simbolo
                        Matriz_Monedas(NuevaFila, 3) = LimpiarTexto(ValorSeguro(item("name")))  '3  Nombre_Oficial
                        Matriz_Monedas(NuevaFila, 4) = slugAPI                                  '4  Slug_API
                        Matriz_Monedas(NuevaFila, 5) = "token_defi"                             '5  Tipo_Activo
                        Matriz_Monedas(NuevaFila, 10) = ID_Red                                  '10 ID_Red_Nativa
                        Matriz_Monedas(NuevaFila, 11) = Supply_Maximo                           '11 Supply_Maximo
                        Matriz_Monedas(NuevaFila, 12) = address                                 '12 Contract_Address
                        Matriz_Monedas(NuevaFila, 13) = MarketCapRank                           '13 Market_cap_rank
                    Next
                Else
                    ' Sin contratos — es coin_nativa
                    Dim NuevaFila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                    Matriz_Monedas(NuevaFila, 0) = CrearCodigoInterno()                         '0  ID_Moneda
                    Matriz_Monedas(NuevaFila, 1) = CrearCodigoInterno()                         '1  ID_Despliegue
                    Matriz_Monedas(NuevaFila, 2) = Simbolo                                      '2  Simbolo
                    Matriz_Monedas(NuevaFila, 3) = LimpiarTexto(ValorSeguro(item("name")))      '3  Nombre_Oficial
                    Matriz_Monedas(NuevaFila, 4) = slugAPI                                      '4  Slug_API
                    Matriz_Monedas(NuevaFila, 5) = "coin_nativa"                                '5  Tipo_Activo
                    Matriz_Monedas(NuevaFila, 11) = Supply_Maximo                               '11 Supply_Maximo
                    Matriz_Monedas(NuevaFila, 12) = "0"                                         '12 Contract_Address
                    Matriz_Monedas(NuevaFila, 13) = MarketCapRank                               '13 Market_cap_rank
                End If
                Guardar_Matrices("Monedas")
            Else
                ' ── MONEDA EXISTENTE: actualizar campos variables ──
                If Val(Matriz_Monedas(i, 13)) <> Val(MarketCapRank) Then
                    Matriz_Monedas(i, 13) = MarketCapRank
                End If
                If Matriz_Monedas(i, 11) = "0" AndAlso Supply_Maximo > 0 Then
                    Matriz_Monedas(i, 11) = Supply_Maximo
                End If
                '
                ' ── Agregar filas faltantes por red ──
                Dim ID_Moneda As String = Matriz_Monedas(i, 0)
                If platforms IsNot Nothing AndAlso platforms.Count > 0 Then
                    For Each plat As KeyValuePair(Of String, JsonNode) In platforms
                        Dim address As String = If(plat.Value IsNot Nothing, plat.Value.ToString(), "0")
                        If String.IsNullOrWhiteSpace(address) Then address = "0"
                        '
                        ' Verificar si ya existe esta combinación Simbolo + Contract_Address (sin distinción de mayúsculas)
                        Dim SWContrato As Boolean = True
                        For k As Integer = 1 To Matriz_MonedasTF
                            If Matriz_Monedas(k, 2).ToUpper() = Simbolo AndAlso
                               Matriz_Monedas(k, 12).ToLower() = address.ToLower() Then
                                SWContrato = False
                                Exit For
                            End If
                        Next
                        '
                        If SWContrato Then
                            ' Mapear slug de red al ID_Interno de Matriz_Redes
                            Dim ID_Red As String = "0"
                            For j As Integer = 1 To Matriz_RedesTF
                                If Matriz_Redes(j, 4).ToLower() = plat.Key.ToLower() Then
                                    ID_Red = Matriz_Redes(j, 0)
                                    Exit For
                                End If
                            Next
                            '
                            Dim NuevaFila = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                            Matriz_Monedas(NuevaFila, 0) = ID_Moneda                                '0  ID_Moneda      (mismo para todas las redes)
                            Matriz_Monedas(NuevaFila, 1) = CrearCodigoInterno()                     '1  ID_Despliegue  (único por fila)
                            Matriz_Monedas(NuevaFila, 2) = Simbolo                                  '2  Simbolo
                            Matriz_Monedas(NuevaFila, 3) = LimpiarTexto(ValorSeguro(item("name")))  '3  Nombre_Oficial
                            Matriz_Monedas(NuevaFila, 4) = slugAPI                                  '4  Slug_API
                            Matriz_Monedas(NuevaFila, 5) = "token_defi"                             '5  Tipo_Activo
                            Matriz_Monedas(NuevaFila, 10) = ID_Red                                  '10 ID_Red_Nativa
                            Matriz_Monedas(NuevaFila, 11) = Supply_Maximo                           '11 Supply_Maximo
                            Matriz_Monedas(NuevaFila, 12) = address                                 '12 Contract_Address
                            Matriz_Monedas(NuevaFila, 13) = MarketCapRank                           '13 Market_cap_rank
                        End If
                    Next
                End If
                Guardar_Matrices("Monedas")
            End If
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