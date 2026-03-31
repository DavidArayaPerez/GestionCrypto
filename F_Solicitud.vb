'
'
'
'Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions
'
'
'
Public Class F_Solicitud
    '
    '
    '
    Public Sub Inicializacion()
        VariableDeInicio = True
        '
        'CargArbolDesdeMatrizSolicitudes(Arbol, "Gestion")
        '
        MensajeBarraLimpíar(StatusStrip1)
        MensajeBarra_Valores(StatusStrip1)
        MensajeBarra_TeclasAccesoDirecto_Carpeta(StatusStrip1)
        '
        LimpiezaDeposito()
        LimpiezaCompras()
        LimpiezaTraspaso()
        LimpiezaPool()
        LimpiezaMovimiento()
        LimpiezaMoneda()
        LimpiezaBilletera()
        LimpiezaExchange()
        LimpiezaValorMonedas()
        LimpiezaRedes()
        '
        LlenarList()
        LlenarExchange()
        LlenarMonedas()
        '
        VariableDeInicio = False
        Timer1.Enabled = True
    End Sub
    Private Sub LlenarList()
        Dim T As String '= ""
        '
        '
        '
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        L_Depositos.Items.Clear()
        For i As Integer = 1 To Matriz_DepositosTF
            T = Matriz_Depositos(i, 1) & ":" & Matriz_Depositos(i, 2) & " " & Matriz_Depositos(i, 3) & "(" & i & ")"
            L_Depositos.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        L_Compras.Items.Clear()
        For i As Integer = 1 To Matriz_ComprasTF
            T = Matriz_Compras(i, 1) & ":" & Matriz_Compras(i, 2) & " " & Matriz_Compras(i, 3) & "(" & i & ")"
            L_Compras.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma          MetraMask, Uniswap, etc
        L_Traspasos.Items.Clear()
        For i As Integer = 1 To Matriz_TraspasosTF
            T = Matriz_Traspasos(i, 1) & ":" & Matriz_Traspasos(i, 2) & " " & Matriz_Traspasos(i, 3) & "(" & i & ")"
            L_Traspasos.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        L_PoolLiquidez.Items.Clear()
        For i As Integer = 1 To Matriz_PoolLiquidezTF
            T = Matriz_PoolLiquidez(i, 1) & ":" & Matriz_PoolLiquidez(i, 2) & " " & Matriz_PoolLiquidez(i, 3) & "(" & i & ")"
            L_PoolLiquidez.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        L_Movimientos.Items.Clear()
        For i As Integer = 1 To Matriz_MovimientosTF
            T = Matriz_Movimientos(i, 1) & ":" & Matriz_Movimientos(i, 2) & " " & Matriz_Movimientos(i, 3) & "(" & i & ")"
            L_Movimientos.Items.Add(T)
        Next i
        '
        '
        '
        '   2   Acronimo
        L_Monedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
            L_Monedas.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Nombre
        L_Billeteras.Items.Clear()
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 1) & " " & "(" & i & ")"
            L_Billeteras.Items.Add(T)
        Next i
        '
        '
        '
        '   1   Nombre
        L_Exchange.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 1) & " " & "(" & i & ")"
            L_Exchange.Items.Add(T)
        Next i
        '
        '
        '
        C_MonedasValorMonedas.Text = ""
        C_MonedasValorMonedas.Items.Clear()
        L_Monedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 3) & " (" & i & ")"
            C_MonedasValorMonedas.Items.Add(T)
            L_Monedas.Items.Add(T)
        Next i
        '
        '
        '
        '2      Nombre_Oficial         Nombre completo
        OrdenarMatriz(Matriz_Redes, Matriz_RedesTF, Matriz_RedesTC, 2, "DES")
        L_Red.Items.Clear()
        For i As Integer = 1 To Matriz_RedesTF
            T = Matriz_Redes(i, 2) & " (" & i & ")"
            L_Red.Items.Add(T)
        Next i
        '
        '
    End Sub

    Private Sub LlenarExchange()
        Dim T As String '= ""
        C_ExchangeDeposito.Items.Clear()
        C_ExchangeCompra.Items.Clear()
        C_ExchangeTraspaso.Items.Clear()
        C_ExchangePool.Items.Clear()
        C_ExchangeMovimiento.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 0)
            C_ExchangeDeposito.Items.Add(T)
            C_ExchangeCompra.Items.Add(T)
            C_ExchangeTraspaso.Items.Add(T)
            C_ExchangePool.Items.Add(T)
            C_ExchangeMovimiento.Items.Add(T)
        Next i
    End Sub
    Private Sub LlenarMonedas()
        Dim T As String ' = ""
        C_MonedaOrigenDeposito.Items.Clear()
        C_MonedaDestinoDeposito.Items.Clear()
        C_MonedaOrigenCompra.Items.Clear()
        C_MonedaDestinoCompra.Items.Clear()
        C_MonedaOrigenTraspaso.Items.Clear()
        C_MonedaDestinoTraspaso.Items.Clear()
        C_Moneda1Pool.Items.Clear()
        C_Moneda2Pool.Items.Clear()
        C_MonedaOrigenMovimiento.Items.Clear()
        C_MonedaDestinoMovimiento.Items.Clear()
        C_MonedasValorMonedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 1)
            C_MonedaOrigenDeposito.Items.Add(T)
            C_MonedaDestinoDeposito.Items.Add(T)
            C_MonedaOrigenCompra.Items.Add(T)
            C_MonedaDestinoCompra.Items.Add(T)
            C_MonedaOrigenTraspaso.Items.Add(T)
            C_MonedaDestinoTraspaso.Items.Add(T)
            C_Moneda1Pool.Items.Add(T)
            C_Moneda2Pool.Items.Add(T)
            C_MonedaOrigenMovimiento.Items.Add(T)
            C_MonedaDestinoMovimiento.Items.Add(T)
            C_MonedasValorMonedas.Items.Add(T)
        Next i

    End Sub
    '
    '
    Private Sub LimpiezaDeposito(Optional Habilitar As Boolean = False)
        'DEPOSITO
        T_FechaDeposito.Text = ""
        T_HoraDeposito.Text = ""
        C_MonedaOrigenDeposito.Text = ""
        C_MonedaDestinoDeposito.Text = ""
        T_ValorOrigenDeposito.Text = ""
        T_ValorDestinoDeposito.Text = ""
        C_ExchangeDeposito.Text = ""
        C_BilleteraDeposito.Text = ""
        L_PrecioMonedaDeposito.Text = ""
        rT_NotaDeposito.Text = ""
        '
        T_FechaDeposito.Enabled = Habilitar
        T_HoraDeposito.Enabled = Habilitar
        C_MonedaOrigenDeposito.Enabled = Habilitar
        C_MonedaDestinoDeposito.Enabled = Habilitar
        T_ValorOrigenDeposito.Enabled = Habilitar
        T_ValorDestinoDeposito.Enabled = Habilitar
        C_ExchangeDeposito.Enabled = Habilitar
        C_BilleteraDeposito.Enabled = Habilitar
        L_PrecioMonedaDeposito.Enabled = Habilitar
        rT_NotaDeposito.Enabled = Habilitar
    End Sub
    Private Sub VerDepositos(F As Integer)
        LimpiezaDeposito(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Entrada
        '   6   Valor_Entrada
        '   7   Moneda_Salida
        '   8   Valor_Salida
        '   9   Comision
        '   10  Gas
        '   11  Precio
        '
        T_FechaDeposito.Text = Matriz_Depositos(F, 1)
        T_HoraDeposito.Text = Matriz_Depositos(F, 2)
        C_ExchangeDeposito.Text = Matriz_Depositos(F, 3)
        C_BilleteraDeposito.Text = Matriz_Depositos(F, 4)
        C_MonedaOrigenDeposito.Text = Matriz_Depositos(F, 5)
        T_ValorOrigenDeposito.Text = Matriz_Depositos(F, 6)
        C_MonedaDestinoDeposito.Text = Matriz_Depositos(F, 7)
        T_ValorDestinoDeposito.Text = Matriz_Depositos(F, 8)
        '
        '
        L_PrecioMonedaDeposito.Text = Matriz_Depositos(F, 11)
        '
        ' L_TotalContrato.Text = MontoContrato.ToString("#,###.########", CulturaChilena)
        ' L_MontoSaldoAcumulado.Text = MontoSaldoAcumulado.ToString("#,###.########", CulturaChilena)
        '---------------------------------------------------------------------------------/
        Dim NombreNota As String = T_FechaDeposito.Text & "_" & T_HoraDeposito.Text & "_" & "Depositos" & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaDeposito)
    End Sub
    '
    Private Sub LimpiezaCompras(Optional Habilitar As Boolean = False)
        'COMPRAS
        T_FechaCompra.Text = ""
        T_HoraCompra.Text = ""
        C_MonedaOrigenCompra.Text = ""
        C_MonedaDestinoCompra.Text = ""
        T_ValorOrigenCompra.Text = ""
        T_ValorDestinoCompra.Text = ""
        C_ExchangeCompra.Text = ""
        T_ComisionCompra.Text = ""
        T_GasCompra.Text = ""
        L_PrecioMonedaCompra.Text = ""
        rT_NotaCompra.Text = ""
        '
        T_FechaCompra.Enabled = Habilitar
        T_HoraCompra.Enabled = Habilitar
        C_MonedaOrigenCompra.Enabled = Habilitar
        C_MonedaDestinoCompra.Enabled = Habilitar
        T_ValorOrigenCompra.Enabled = Habilitar
        T_ValorDestinoCompra.Enabled = Habilitar
        C_ExchangeCompra.Enabled = Habilitar
        T_ComisionCompra.Enabled = Habilitar
        T_GasCompra.Enabled = Habilitar
        L_PrecioMonedaCompra.Enabled = Habilitar
        rT_NotaCompra.Enabled = Habilitar
    End Sub
    Private Sub VerCompras(F As Integer)
        LimpiezaCompras(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Moneda_Origen
        '   5   Valor_Origen
        '   6   Moneda_Destino
        '   7   Valor_Destino
        '   8   Comision
        '   9   Gas
        '   10  Precio
        '
        T_FechaCompra.Text = Matriz_Compras(F, 1)
        T_HoraCompra.Text = Matriz_Compras(F, 2)
        C_ExchangeCompra.Text = Matriz_Compras(F, 3)
        C_MonedaOrigenCompra.Text = Matriz_Compras(F, 4)
        T_ValorOrigenCompra.Text = Matriz_Compras(F, 5)
        C_MonedaDestinoCompra.Text = Matriz_Compras(F, 6)
        T_ValorDestinoCompra.Text = Matriz_Compras(F, 7)
        T_ComisionCompra.Text = Matriz_Compras(F, 8)
        T_GasCompra.Text = Matriz_Compras(F, 9)
        L_PrecioMonedaCompra.Text = Matriz_Compras(F, 10)
        '
        Dim NombreNota As String = T_FechaCompra.Text & "_" & T_HoraCompra.Text & "_" & "Compras" & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaCompra)
    End Sub
    '
    '
    Private Sub LimpiezaTraspaso(Optional Habilitar As Boolean = False)
        'TRASPASO
        T_FechaTraspaso.Text = ""
        T_HoraTraspaso.Text = ""
        C_MonedaOrigenTraspaso.Text = ""
        C_MonedaDestinoTraspaso.Text = ""
        T_ValorOrigenTraspaso.Text = ""
        T_ValorDestinoTraspaso.Text = ""
        C_ExchangeTraspaso.Text = ""
        T_ComisionTraspaso.Text = ""
        T_GasTraspaso.Text = ""
        C_BilleteraOrigenTraspaso.Text = ""
        C_BilleteraDestinoTraspaso.Text = ""
        rT_NotaTraspaso.Text = ""
        '
        T_FechaTraspaso.Enabled = Habilitar
        T_HoraTraspaso.Enabled = Habilitar
        C_MonedaOrigenTraspaso.Enabled = Habilitar
        C_MonedaDestinoTraspaso.Enabled = Habilitar
        T_ValorOrigenTraspaso.Enabled = Habilitar
        T_ValorDestinoTraspaso.Enabled = Habilitar
        C_ExchangeTraspaso.Enabled = Habilitar
        T_ComisionTraspaso.Enabled = Habilitar
        T_GasTraspaso.Enabled = Habilitar
        C_BilleteraOrigenTraspaso.Enabled = Habilitar
        C_BilleteraDestinoTraspaso.Enabled = Habilitar
        rT_NotaTraspaso.Enabled = Habilitar
    End Sub
    Private Sub VerTraspasos(F As Integer)
        LimpiezaTraspaso(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma          MetraMask, Uniswap, etc
        '   4   Billetera_Origen
        '   5   Moneda_Origen
        '   6   Valor_Origen
        '   7   Billetera_Destino
        '   8   Moneda_Destino
        '   9   Valor_Destino
        '   10   Comision
        '   11  Gas
        '
        T_FechaTraspaso.Text = Matriz_Traspasos(F, 1)
        T_HoraTraspaso.Text = Matriz_Traspasos(F, 2)
        C_ExchangeTraspaso.Text = Matriz_Traspasos(F, 3)
        C_BilleteraOrigenTraspaso.Text = Matriz_Traspasos(F, 4)
        C_MonedaOrigenTraspaso.Text = Matriz_Traspasos(F, 5)
        T_ValorOrigenTraspaso.Text = Matriz_Traspasos(F, 6)
        C_BilleteraDestinoTraspaso.Text = Matriz_Traspasos(F, 7)
        C_MonedaDestinoTraspaso.Text = Matriz_Traspasos(F, 8)
        T_ValorDestinoTraspaso.Text = Matriz_Traspasos(F, 9)
        T_ComisionTraspaso.Text = Matriz_Traspasos(F, 10)
        T_GasTraspaso.Text = Matriz_Traspasos(F, 11)
        '
        Dim NombreNota As String = T_FechaTraspaso.Text & "_" & T_HoraTraspaso.Text & "_" & "Traspasos" & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaTraspaso)
    End Sub
    '
    '
    Private Sub LimpiezaPool(Optional Habilitar As Boolean = False)
        'POOL LIQUIDEZ
        T_FechaPool.Text = ""
        T_HoraPool.Text = ""
        C_Moneda1Pool.Text = ""
        C_Moneda2Pool.Text = ""
        T_ValorMoneda1Pool.Text = ""
        T_ValorMoneda2Pool.Text = ""
        T_ComisionPool.Text = ""
        T_GasPool.Text = ""
        T_MinPool.Text = ""
        T_MaxPool.Text = ""
        C_ExchangePool.Text = ""
        C_BilleteraPool.Text = ""
        T_ValorMoneda1ResultantePool.Text = ""
        T_ValorMoneda2ResultantePool.Text = ""

        rT_NotaPool.Text = ""
        '
        T_FechaPool.Enabled = Habilitar
        T_HoraPool.Enabled = Habilitar
        C_Moneda1Pool.Enabled = Habilitar
        C_Moneda2Pool.Enabled = Habilitar
        T_ValorMoneda1Pool.Enabled = Habilitar
        T_ValorMoneda2Pool.Enabled = Habilitar
        T_ComisionPool.Enabled = Habilitar
        T_GasPool.Enabled = Habilitar
        C_ExchangePool.Enabled = Habilitar
        C_BilleteraPool.Enabled = Habilitar
        T_ValorMoneda1ResultantePool.Enabled = Habilitar
        T_ValorMoneda2ResultantePool.Enabled = Habilitar

        rT_NotaPool.Enabled = Habilitar
    End Sub
    Private Sub VerPool(F As Integer)
        LimpiezaPool(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Uno
        '   6   Valor_Uno
        '   7   Moneda_Dos
        '   8   Valor_Dos
        '   9   Comision
        '   10  Gas
        '   11  Monto_Uno_Resultante
        '   12  Monto_Dos_Resultante
        '   13  Porcentaje_Uno
        '   14  Porcentaje_Dos
        '   15  Minimo
        '   16  Maximo
        '
        T_FechaPool.Text = Matriz_PoolLiquidez(F, 1)
        T_HoraPool.Text = Matriz_PoolLiquidez(F, 2)
        C_ExchangePool.Text = Matriz_PoolLiquidez(F, 3)
        C_BilleteraPool.Text = Matriz_PoolLiquidez(F, 4)
        C_Moneda1Pool.Text = Matriz_PoolLiquidez(F, 5)
        T_ValorMoneda1Pool.Text = Matriz_PoolLiquidez(F, 6)
        C_Moneda2Pool.Text = Matriz_PoolLiquidez(F, 7)
        T_ValorMoneda2Pool.Text = Matriz_PoolLiquidez(F, 8)
        T_ComisionPool.Text = Matriz_PoolLiquidez(F, 9)
        T_GasPool.Text = Matriz_PoolLiquidez(F, 10)
        T_ValorMoneda1ResultantePool.Text = Matriz_PoolLiquidez(F, 11)
        T_ValorMoneda2ResultantePool.Text = Matriz_PoolLiquidez(F, 12)
        '13
        '14
        T_MinPool.Text = Matriz_PoolLiquidez(F, 15)
        T_MaxPool.Text = Matriz_PoolLiquidez(F, 16)
        '
        Dim NombreNota As String = T_FechaPool.Text & "_" & T_HoraPool.Text & "_" & "Pool" & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub
    '
    '
    Private Sub LimpiezaMovimiento(Optional Habilitar As Boolean = False)
        'MOVIMIENTO
        T_FechaMovimiento.Text = ""
        T_HoraMovimiento.Text = ""
        C_MonedaOrigenMovimiento.Text = ""
        C_MonedaDestinoMovimiento.Text = ""
        T_ValorOrigenMovimiento.Text = ""
        T_ValorDestinoMovimiento.Text = ""
        T_ComisionMovimiento.Text = ""
        T_GasMovimiento.Text = ""
        C_ExchangeMovimiento.Text = ""
        C_BilleteraMovimiento.Text = ""
        rT_NotaMovimiento.Text = ""
        '
        T_FechaMovimiento.Enabled = Habilitar
        T_HoraMovimiento.Enabled = Habilitar
        C_MonedaOrigenMovimiento.Enabled = Habilitar
        C_MonedaDestinoMovimiento.Enabled = Habilitar
        T_ValorOrigenMovimiento.Enabled = Habilitar
        T_ValorDestinoMovimiento.Enabled = Habilitar
        T_ComisionMovimiento.Enabled = Habilitar
        T_GasMovimiento.Enabled = Habilitar
        C_ExchangeMovimiento.Enabled = Habilitar
        C_BilleteraMovimiento.Enabled = Habilitar

        rT_NotaMovimiento.Enabled = Habilitar
    End Sub
    Private Sub VerMovimiento(F As Integer)
        LimpiezaMovimiento(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Origen
        '   6   Valor_Origen
        '   7   Moneda_Destino
        '   8   Valor_Destino
        '   9   Comsion
        '   10  Gas
        '
        T_FechaMovimiento.Text = Matriz_Movimientos(F, 1)
        T_HoraMovimiento.Text = Matriz_Movimientos(F, 2)
        C_ExchangeMovimiento.Text = Matriz_Movimientos(F, 3)
        C_BilleteraMovimiento.Text = Matriz_Movimientos(F, 4)
        C_MonedaOrigenMovimiento.Text = Matriz_Movimientos(F, 5)
        T_ValorOrigenMovimiento.Text = Matriz_Movimientos(F, 6)
        C_MonedaDestinoMovimiento.Text = Matriz_Movimientos(F, 7)
        T_ValorDestinoMovimiento.Text = Matriz_Movimientos(F, 8)
        T_ComisionMovimiento.Text = Matriz_Movimientos(F, 9)
        T_GasMovimiento.Text = Matriz_Movimientos(F, 10)
        '
        Dim NombreNota As String = T_FechaMovimiento.Text & "_" & T_HoraMovimiento.Text & "_" & "Movimiento" & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub
    '
    '
    Private Sub LimpiezaMoneda(Optional Habilitar As Boolean = False)
        'MONEDA
        L_IDmoneda_Moneda.Text = ""
        T_IDdespliegue_Moneda.Text = ""
        T_Simbolo_Moneda.Text = ""
        T_AcronimoMoneda.Text = ""
        T_SlugAPI_Moneda.Text = ""
        T_TipoActivo_Moneda.Text = ""
        T_SubtipoStablecoin_Moneda.Text = ""
        T_MonedaParidad_Moneda.Text = ""
        T_Centralizada_Moneda.Text = ""
        T_ActivoSubyacente_Moneda.Text = ""
        T_IDredNativa_Moneda.Text = ""
        T_SupplyMaximo_Moneda.Text = ""
        T_ContractAddress_Moneda.Text = ""
        T_MarketCapRank_Moneda.Text = ""
        T_Busqueda_Monedas.Text = ""
        rT_NotaMoneda.Text = ""
        '
        L_IDmoneda_Moneda.Enabled = Habilitar
        T_IDdespliegue_Moneda.Enabled = Habilitar
        T_Simbolo_Moneda.Enabled = Habilitar
        T_AcronimoMoneda.Enabled = Habilitar
        T_SlugAPI_Moneda.Enabled = Habilitar
        T_TipoActivo_Moneda.Enabled = Habilitar
        T_SubtipoStablecoin_Moneda.Enabled = Habilitar
        T_MonedaParidad_Moneda.Enabled = Habilitar
        T_Centralizada_Moneda.Enabled = Habilitar
        T_ActivoSubyacente_Moneda.Enabled = Habilitar
        T_IDredNativa_Moneda.Enabled = Habilitar
        T_SupplyMaximo_Moneda.Enabled = Habilitar
        T_ContractAddress_Moneda.Enabled = Habilitar
        T_MarketCapRank_Moneda.Enabled = Habilitar
        'T_Busqueda_Monedas.Enabled = Habilitar
        rT_NotaMoneda.Enabled = Habilitar
    End Sub
    Private Sub VerMoneda(F As Integer)
        LimpiezaMoneda(True)
        If F < 1 Then Exit Sub
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
        '   13     market_cap_rank
        '
        L_IDmoneda_Moneda.Text = Matriz_Monedas(F, 0)
        T_IDdespliegue_Moneda.Text = Matriz_Monedas(F, 1)
        T_Simbolo_Moneda.Text = Matriz_Monedas(F, 2)
        T_AcronimoMoneda.Text = Matriz_Monedas(F, 3)
        T_SlugAPI_Moneda.Text = Matriz_Monedas(F, 4)
        T_TipoActivo_Moneda.Text = Matriz_Monedas(F, 5)
        T_SubtipoStablecoin_Moneda.Text = Matriz_Monedas(F, 6)
        T_MonedaParidad_Moneda.Text = Matriz_Monedas(F, 7)
        T_Centralizada_Moneda.Text = Matriz_Monedas(F, 8)
        T_ActivoSubyacente_Moneda.Text = Matriz_Monedas(F, 9)
        T_IDredNativa_Moneda.Text = Matriz_Monedas(F, 10)
        T_SupplyMaximo_Moneda.Text = Matriz_Monedas(F, 11)
        T_ContractAddress_Moneda.Text = Matriz_Monedas(F, 12)
        T_MarketCapRank_Moneda.Text = Matriz_Monedas(F, 13)
        '
        '
        Dim Fred As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Redes, Matriz_RedesTF, 0, T_IDredNativa_Moneda.Text)
        '   2       Simbolo
        '   10      ID_Red                  Es el ID de la Matriz_Red
        T_IDredNativa_Moneda.Text = Matriz_Redes(Fred, 2)
        '
        '
        '
        'Dim NombreNota As String = "Moneda" & T_AcronimoMoneda.Text & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub
    '
    '
    Private Sub LimpiezaBilletera(Optional Habilitar As Boolean = False)
        'BILLETERA
        T_NombreBilletera.Text = ""
        T_CodigoBilletera.Text = ""
        rT_NotaBilletera.Text = ""
        '
        T_NombreBilletera.Enabled = Habilitar
        T_CodigoBilletera.Enabled = Habilitar
        rT_NotaBilletera.Enabled = Habilitar
    End Sub
    Private Sub VerBilletera(F As Integer)
        LimpiezaBilletera(True)
        If F < 1 Then Exit Sub
        '   0   Codigo Billetera
        '   1   Nombre
        '
        T_NombreBilletera.Text = Matriz_Billeteras(F, 1)
        T_CodigoBilletera.Text = Matriz_Billeteras(F, 2)
        '
        Dim NombreNota As String = "Billetera" & T_CodigoBilletera.Text & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaBilletera)
    End Sub
    '
    '
    Private Sub LimpiezaExchange(Optional Habilitar As Boolean = False)
        'EXCHANGE
        T_NomExchange.Text = ""
        rT_NotaExchange.Text = ""
        '
        T_NomExchange.Enabled = Habilitar
        rT_NotaExchange.Enabled = Habilitar
    End Sub
    Private Sub VerExchange(F As Integer)
        LimpiezaExchange(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Nombre
        '
        T_NomExchange.Text = Matriz_Exchange(F, 1)
        '
        Dim NombreNota As String = "Echange" & T_NomExchange.Text & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaBilletera)
    End Sub
    ' 
    '
    Private Sub LimpiezaValorMonedas(Optional Habilitar As Boolean = False)
        'VALOR MONEDAS
        T_FechaValorMonedas.Text = ""
        T_ValorValorMonedas.Text = ""

        '
        T_FechaValorMonedas.Enabled = Habilitar
        T_ValorValorMonedas.Enabled = Habilitar
    End Sub
    Private Sub VerValorMonedas(F As Integer)
        LimpiezaValorMonedas(True)
        If F < 1 Then Exit Sub
        '   0   Fecha
        '   1   Valor
        '
        T_FechaValorMonedas.Text = Matriz_ValorUSD(F, 0)
        T_ValorValorMonedas.Text = Matriz_ValorUSD(F, 1)
    End Sub
    '
    '
    Private Sub LimpiezaRedes(Optional Habilitar As Boolean = False)
        'REDES
        L_IDRed_Red.Text = ""
        T_ChainID_Red.Text = ""
        T_NomOficial_Red.Text = ""
        T_NomCorto_Red.Text = ""
        T_APIcg_Red.Text = ""
        T_L1padre_Red.Text = ""
        T_TipoRollup_Red.Text = ""
        T_TokenNativo_Red.Text = ""
        T_Decimales_Red.Text = ""
        T_TipoBloque_Red.Text = ""
        T_Color_Red.Text = ""
        T_URLexplorador_Red.Text = ""
        T_URLlogo_Red.Text = ""
        T_URLrpc_Red.Text = ""
        T_TipoCapa_Red.Text = ""
        T_MecanismoConsenso_Red.Text = ""
        rT_NotaRed.Text = ""
        '
        L_IDRed_Red.Enabled = Habilitar
        T_ChainID_Red.Enabled = Habilitar
        T_NomOficial_Red.Enabled = Habilitar
        T_NomCorto_Red.Enabled = Habilitar
        T_APIcg_Red.Enabled = Habilitar
        T_L1padre_Red.Enabled = Habilitar
        T_TipoRollup_Red.Enabled = Habilitar
        T_TokenNativo_Red.Enabled = Habilitar
        T_Decimales_Red.Enabled = Habilitar
        T_TipoBloque_Red.Enabled = Habilitar
        T_Color_Red.Enabled = Habilitar
        T_URLexplorador_Red.Enabled = Habilitar
        T_URLlogo_Red.Enabled = Habilitar
        T_URLrpc_Red.Enabled = Habilitar
        T_TipoCapa_Red.Enabled = Habilitar
        T_MecanismoConsenso_Red.Enabled = Habilitar
        rT_NotaRed.Enabled = Habilitar

    End Sub
    Private Sub VerRedes(F As Integer)
        LimpiezaRedes(True)
        If F < 1 Then Exit Sub
        '0      ID_Interno
        '1      Chain_ID               Identificador único para redes EVM
        '2      Nombre_Oficial         Nombre completo
        '3      Nombre_Corto           Para mostrar en pantalla
        '4      Slug_API               Identificador en APIs como CoinGecko
        '5      Tipo_Capa              Arquitectura de la red, L1 / L2 / Sidechain
        '6      L1_Padre               Solo aplica si es L2 — a qué L1 está anclada
        '7      Tipo_Rollup            Solo aplica a L2s
        '8      Compatible_EVM         Define si usa el estándar de Ethereum           Sí / No
        '9      Mecanismo_Consenso     Cómo valida la red                              PoW, PoS, PoH
        '10     Token_Nativo           En ARB el token nativo es ETH, no ARB.
        '                            El token ARB existe, pero es el token de gobernanza del protocolo,
        '                                no el que se usa para pagar el gas.
        '                                Esto aplica también a otras redes como Base y Optimism,
        '                                    que también usan ETH como gas aunque tengan su propio token de gobernanza.
        '11     Decimales              Crítico para cálculos — cada red usa distinto   Pueden ser; 18 decimales, 6 decimales, etc.
        '12     Tiempo_Bloque          Velocidad de confirmación                       12 seg, 0.4 seg
        '13     Color_Marca            Para mostrar en la UI                           #627EEA                     
        '14     URL_Explorador         Para consultar transacciones                    etherscan.io
        '15     URL_Logo               Ícono de la red                                 https://...
        '16     URL_RPC                Para conectarse a la red programáticamente      https://...
        '17     Activa                 Para desactivar redes sin borrarlas             Sí / No
        '
        L_IDRed_Red.Text = Matriz_Redes(F, 0)
        T_ChainID_Red.Text = Matriz_Redes(F, 1)
        T_NomOficial_Red.Text = Matriz_Redes(F, 2)
        T_NomCorto_Red.Text = Matriz_Redes(F, 3)
        T_APIcg_Red.Text = Matriz_Redes(F, 4)
        T_TipoCapa_Red.Text = Matriz_Redes(F, 5)
        T_L1padre_Red.Text = Matriz_Redes(F, 6)
        T_TipoRollup_Red.Text = Matriz_Redes(F, 7)
        '8 EVM
        T_MecanismoConsenso_Red.Text = Matriz_Redes(F, 9)
        T_TokenNativo_Red.Text = Matriz_Redes(F, 10)
        T_Decimales_Red.Text = Matriz_Redes(F, 11)
        T_TipoBloque_Red.Text = Matriz_Redes(F, 12)
        T_Color_Red.Text = Matriz_Redes(F, 13)
        T_URLexplorador_Red.Text = Matriz_Redes(F, 14)
        T_URLlogo_Red.Text = Matriz_Redes(F, 15)
        T_URLrpc_Red.Text = Matriz_Redes(F, 16)
        '17 Activo
        '
        '--------------------------------------------
        Dim T As String
        '
        '8 EVM                  Matriz_Redes(F, 8)
        T = UCase(Matriz_Redes(F, 8))
        If T = "SI" Then
            CB_EVM_Red.Checked = True
        Else
            CB_EVM_Red.Checked = False
        End If
        '
        '17 Activo              Matriz_Redes(F, 17)
        If Matriz_Redes(F, 17) = "SI" Then
            CB_Activo_Red.Checked = True
        Else
            CB_Activo_Red.Checked = False
        End If
    End Sub
    '
    '
    '
    '
    '












    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    '
    Private Sub F_Solicitud_Load(sender As Object, e As EventArgs) Handles Me.Load
        Inicializacion()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MensajeBarra_Hora(StatusStrip1)
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub B_NuevoMoneda_Click(sender As Object, e As EventArgs) Handles B_NuevoMoneda.Click
        Dim T As String = "Ingrese el acronimo de la moneda" & vbCrLf & "Ejemplo: USDT, BTC, ETH, USDT, MATIC,  etc"
        Dim Acronimo As String = InputBox(T, "Nueva Moneda")
        '
        Dim F As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Monedas, Matriz_MonedasTF, 2, Acronimo)
        If F > 0 Then
            VerMoneda(F)
            Exit Sub
        End If
    End Sub


    Private Sub L_Red_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Red.SelectedIndexChanged
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Red.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerRedes(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub L_Monedas_DoubleClick(sender As Object, e As EventArgs) Handles L_Monedas.DoubleClick
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Monedas.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerMoneda(Mid(T, x + 1, Len(T) - x - 1))
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLexplorador_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLexplorador_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLlogo_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLlogo_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLrpc_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLrpc_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub

    Private Sub B_Actualizar_Monedas_Click(sender As Object, e As EventArgs) Handles B_Actualizar_Monedas.Click
        ActualizarMonedas()
        OrdenarMatriz_Monedas()
        Guardar_Matrices("Monedas")
    End Sub
    Private Sub T_Busqueda_Monedas_KeyUp(sender As Object, e As KeyEventArgs) Handles T_Busqueda_Monedas.KeyUp
        If VariableDeInicio Then Exit Sub
        Dim Filtro As String = T_Busqueda_Monedas.Text.Trim().ToUpper()
        L_Monedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            Dim Simbolo As String = Matriz_Monedas(i, 2).ToString().ToUpper()
            If Filtro = "" OrElse Simbolo.StartsWith(Filtro) Then
                L_Monedas.Items.Add(Matriz_Monedas(i, 2))
            End If
        Next
    End Sub




    '
    '
    '
End Class
'
'
'
