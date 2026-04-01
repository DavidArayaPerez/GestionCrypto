'
'
'
Public Class F_Compras
    '
    '
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
        'Dim NombreNota As String = T_FechaCompra.Text & "_" & T_HoraCompra.Text & "_" & "Compras" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaCompra)
    End Sub

    '
    '
    '
End Class