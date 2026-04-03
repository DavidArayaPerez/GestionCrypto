'
'
'
Public Class F_Movimientos
    '
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
        'Dim NombreNota As String = T_FechaMovimiento.Text & "_" & T_HoraMovimiento.Text & "_" & "Movimiento" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
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
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    '
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    '
    '
    '
End Class