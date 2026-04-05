'
'
'
Module mMonedas
    '
    '
    '
    Public Matriz_Monedas(,) As String
    Public Matriz_MonedasTF As Integer
    Public Matriz_MonedasTC As Integer = 24
    '
    '   0       ID_Moneda
    '   1       ID_Despliegue
    '   2       Simbolo
    '   3       Nombre_Oficial
    '   4       Slug_API
    '   5       Tipo_Activo
    '   6       Subtipo_Stablecoin      solo para stablecoins: fiat, crypto, algoritmica (DAI es crypto-backed, USDT es fiat, etc.)
    '   7       Moneda_Paridad
    '   8       Centralizada
    '   9       Activo_Subyacente       solo para wrapped: WBTC → BTC, WETH → ETH
    '   10      ID_Red                  Es el ID de la Matriz_Red
    '   11      Supply_Maximo
    '   12      Contract_Address
    '   13      market_cap_rank
    '   14      Link CoinGecko
    '   15      Current_Price
    '   16      Hight24h
    '   17      Low24h
    '   18      Price_Change_24h
    '   19      Price_Change_Percentage_24h
    '   20      Circulating_Supply
    '   21      Fecha_Actualizacion
    '   22      Actualizacion_Automatica        (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
    '   23      Tipo_Moneda                     Moneda / CryptoMoneda
    '   24      
    '

    Public Function ExisteMoneda(T As String) As String
        For i As Integer = 1 To Matriz_MonedasTF
            If T = Matriz_Monedas(i, 2) Then Return "S" 'Si existe
        Next i
        Return "N" 'No existe
    End Function

    Public Function BuscarMoneda(T As String) As Integer
        If T = Nothing Then Return 0
        If T = "" Then Return 0
        '
        For i As Integer = 1 To Matriz_MonedasTF
            If T = Matriz_Monedas(i, 2) Then Return i
        Next i
        Return 0
    End Function

    Public Sub Llenar_Monedas(ByRef Combo As ComboBox)
        Dim T As String
        Combo.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2)
            Combo.Items.Add(T)
        Next i
    End Sub
    Public Sub LlenarList_Monedas(ByRef Lista As ListBox)
        Dim Contador As Integer = 0
        Dim T As String
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2)
            Lista.Items.Add(T)
            If Matriz_Monedas(i, 22) = "S" Then
                If Contador < 50 Then
                    API_CoinGecko_ActualizaValor(Matriz_Monedas(i, 4))
                    Contador += 1
                End If
            End If
        Next i
    End Sub
    '
    '
    '
End Module
