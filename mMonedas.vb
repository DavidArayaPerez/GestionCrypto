'
'
'
Module mMonedas
    '
    '
    '
    Public Matriz_Monedas(,) As String
    Public Matriz_MonedasTF As String
    Public Matriz_MonedasTC As String = 23
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
    '   18      Price Change 24h
    '   19      Price Change Percentage 24h
    '   20      Circulating Supply
    '   21      Fecha Actualizacion
    '   22      Actualizacion Automatica (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
    '   23
    '
    'Dim monedas = Await CoinGeckoService.ObtenerMonedasAsync(cantidad:=100)
    '
    '
    '

    Public Sub OrdenarMatriz_Monedas()
        Dim V1, V2 As Integer
        For i As Integer = 1 To Matriz_MonedasTF - 1
            V1 = Val(Matriz_Monedas(i, 13))
            For j As Integer = i + 1 To Matriz_MonedasTF
                V2 = Matriz_Monedas(j, 13)
                If V2 > 0 Then
                    If V1 > V2 Then
                        For k As Integer = 0 To Matriz_MonedasTC - 1
                            Dim Temp As String = Matriz_Monedas(i, k)
                            Matriz_Monedas(i, k) = Matriz_Monedas(j, k)
                            Matriz_Monedas(j, k) = Temp
                        Next k
                    End If
                End If
            Next j
        Next i
        Guardar_Matrices("Monedas")
    End Sub
    '
    '
    '
End Module
