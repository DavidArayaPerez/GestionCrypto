'
'
'
Module mMonedas
    '
    '
    '
    Public Matriz_Monedas(,) As String
    Public Matriz_MonedasTF As String
    Public Matriz_MonedasTC As String = 13
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
    '
    '

    'Dim monedas = Await CoinGeckoService.ObtenerMonedasAsync(cantidad:=100)



    '
    '
    '
End Module
