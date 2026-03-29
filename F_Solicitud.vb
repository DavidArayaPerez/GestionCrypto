'
'
'
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions
Imports OfficeOpenXml
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
        '
        LlenarList()
        LlenarExchange()
        LlenarMonedas()
        '
        Timer1.Enabled = True
    End Sub
    Private Sub LlenarList()
        Dim T As String = ""
        L_Depositos.Items.Clear()
        For i As Integer = 1 To Matriz_DepositosTF
            T = Matriz_Depositos(i, 1) & ":" & Matriz_Depositos(i, 2) & " " & Matriz_Depositos(i, 3) & "(" & i & ")"
            L_Depositos.Items.Add(T)
        Next i
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Entrada
        '   6   Valor_Entrada
        '
        L_Compras.Items.Clear()
        For i As Integer = 1 To Matriz_ComprasTF
            T = Matriz_Compras(i, 1) & ":" & Matriz_Compras(i, 2) & " " & Matriz_Compras(i, 3) & "(" & i & ")"
            L_Compras.Items.Add(T)
        Next i
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Moneda_Origen
        '   5   Valor_Origen
        '
        L_Traspasos.Items.Clear()
        For i As Integer = 1 To Matriz_TraspasosTF
            T = Matriz_Traspasos(i, 1) & ":" & Matriz_Traspasos(i, 2) & " " & Matriz_Traspasos(i, 3) & "(" & i & ")"
            L_Traspasos.Items.Add(T)
        Next i
        '   3   Plataforma          MetraMask, Uniswap, etc
        '   4   Billetera_Origen
        '   5   Moneda_Origen
        '   6   Valor_Origen
        '
        L_PoolLiquidez.Items.Clear()
        For i As Integer = 1 To Matriz_PoolLiquidezTF
            T = Matriz_PoolLiquidez(i, 1) & ":" & Matriz_PoolLiquidez(i, 2) & " " & Matriz_PoolLiquidez(i, 3) & "(" & i & ")"
            L_PoolLiquidez.Items.Add(T)
        Next i
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Uno
        '
        L_Movimientos.Items.Clear()
        For i As Integer = 1 To Matriz_MovimientosTF
            T = Matriz_Movimientos(i, 1) & ":" & Matriz_Movimientos(i, 2) & " " & Matriz_Movimientos(i, 3) & "(" & i & ")"
            L_Movimientos.Items.Add(T)
        Next i
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Origen
        '
        L_Monedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
            L_Monedas.Items.Add(T)
        Next i
        '   1   Nombre
        '   2   Acronimo
        '   3   Contrato
        '
        L_Billeteras.Items.Clear()
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 1) & " " & "(" & i & ")"
            L_Billeteras.Items.Add(T)
        Next i
        '   0   Codigo Billetera
        '   1   Nombre
        '
        L_Exchange.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 1) & " " & "(" & i & ")"
            L_Exchange.Items.Add(T)
        Next i
        '
    End Sub

    Private Sub LlenarExchange()
        Dim T As String = ""
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
        Dim T As String = ""
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
        Next i
    End Sub
    '
    '
    Private Sub LimpiezaDeposito(Optional Habilitar As Boolean = False)
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
        'MOVIMIENTO
        T_FechaMovimiento.Text = ""
        T_HoraMovimiento.Text = ""
        C_MonedaOrigenMovimiento.Text = ""
        C_MonedaDestinoMovimiento.Text = ""
        T_ValorOrigenMovimiento.Text = ""
        T_ValorDestinoMovimiento.Text = ""
        T_ComisionMovimiento.Text = ""
        T_GasMovimiento.Text = ""
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
        If Not VariableDeInicio Then Exit Sub
        'MONEDA
        T_NomMoneda.Text = ""
        T_AcronimoMoneda.Text = ""
        T_ContratoMoneda.Text = ""
        rT_NotaMoneda.Text = ""
        '
        T_NomMoneda.Enabled = Habilitar
        T_AcronimoMoneda.Enabled = Habilitar
        T_ContratoMoneda.Enabled = Habilitar
        rT_NotaMoneda.Enabled = Habilitar
    End Sub
    Private Sub VerMoneda(F As Integer)
        LimpiezaMoneda(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Nombre
        '   2   Acronimo
        '   3   Contrato
        '
        T_NomMoneda.Text = Matriz_Monedas(F, 1)
        T_AcronimoMoneda.Text = Matriz_Monedas(F, 2)
        T_ContratoMoneda.Text = Matriz_Monedas(F, 3)
        '
        Dim NombreNota As String = "Moneda" & T_AcronimoMoneda.Text & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub
    '
    '
    Private Sub LimpiezaBilletera(Optional Habilitar As Boolean = False)
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
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
        If Not VariableDeInicio Then Exit Sub
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
        T_FechaValorMonedas.Text = Matriz_ValorDolar(F, 0)
        T_ValorValorMonedas.Text = Matriz_ValorDolar(F, 1)
    End Sub



















    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
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
    '
    '
    '
End Class
'
'
'
