'
'
'
Public Class F_Traspaso
    '
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
        'Dim NombreNota As String = T_FechaTraspaso.Text & "_" & T_HoraTraspaso.Text & "_" & "Traspasos" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaTraspaso)
    End Sub

    '
    '
    '
End Class