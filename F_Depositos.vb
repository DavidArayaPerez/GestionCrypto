'
'
'
Public Class F_Depositos
    '
    '
    '
    Private Sub Inicializar()
        Limpiar()


    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        'DEPOSITO
        T_FechaDeposito.Text = ""
        T_HoraDeposito.Text = ""
        C_MonedaOrigen.Text = ""
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
        C_MonedaOrigen.Enabled = Habilitar
        C_MonedaDestinoDeposito.Enabled = Habilitar
        T_ValorOrigenDeposito.Enabled = Habilitar
        T_ValorDestinoDeposito.Enabled = Habilitar
        C_ExchangeDeposito.Enabled = Habilitar
        C_BilleteraDeposito.Enabled = Habilitar
        L_PrecioMonedaDeposito.Enabled = Habilitar
        rT_NotaDeposito.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpiar(True)
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
        C_MonedaOrigen.Text = Matriz_Depositos(F, 5)
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
        'Dim NombreNota As String = T_FechaDeposito.Text & "_" & T_HoraDeposito.Text & "_" & "Depositos" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaDeposito)
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click

    End Sub
    '
    '
    '
End Class