'
'
'
Public Class F_Traspaso
    '
    '
    '
    Private Sub Inicializar()
        Dim T As String
        VariableDeInicio = True
        '
        Limpiar()
        '
        Llenar_Exchange(C_Exchange)
        Llenar_Billetera(C_BilleteraOrigen)
        Llenar_Billetera(C_BilleteraDestino)
        Llenar_Monedas(C_MonedaOrigen)
        Llenar_Monedas(C_MonedaDestino)
        '
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        'TRASPASO
        T_Fecha.Text = ""
        T_Hora.Text = ""
        C_MonedaOrigen.Text = ""
        C_MonedaDestino.Text = ""
        T_ValorOrigen.Text = ""
        T_ValorDestino.Text = ""
        C_Exchange.Text = ""
        T_Comision.Text = ""
        T_Gas.Text = ""
        C_BilleteraOrigen.Text = ""
        C_BilleteraDestino.Text = ""
        rT_Nota.Text = ""
        '
        T_Fecha.Enabled = Habilitar
        T_Hora.Enabled = Habilitar
        C_MonedaOrigen.Enabled = Habilitar
        C_MonedaDestino.Enabled = Habilitar
        T_ValorOrigen.Enabled = Habilitar
        T_ValorDestino.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        C_BilleteraOrigen.Enabled = Habilitar
        C_BilleteraDestino.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpiar(True)
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
        '   10  Comision
        '   11  Gas
        '
        T_Fecha.Text = Matriz_Traspasos(F, 1)
        T_Hora.Text = Matriz_Traspasos(F, 2)
        C_Exchange.Text = Matriz_Traspasos(F, 3)
        C_BilleteraOrigen.Text = Matriz_Traspasos(F, 4)
        C_MonedaOrigen.Text = Matriz_Traspasos(F, 5)
        T_ValorOrigen.Text = Matriz_Traspasos(F, 6)
        C_BilleteraDestino.Text = Matriz_Traspasos(F, 7)
        C_MonedaDestino.Text = Matriz_Traspasos(F, 8)
        T_ValorDestino.Text = Matriz_Traspasos(F, 9)
        T_Comision.Text = Matriz_Traspasos(F, 10)
        T_Gas.Text = Matriz_Traspasos(F, 11)
        '
        Dim NombreNota As String = "Tras_" & T_Fecha.Text & " " & T_Hora.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
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
    Private Sub T_ValorOrigen_TextChanged(sender As Object, e As EventArgs) Handles T_ValorOrigen.TextChanged
        '
    End Sub
    Private Sub T_ValorDestino_TextChanged(sender As Object, e As EventArgs) Handles T_ValorDestino.TextChanged
        '
    End Sub
    Private Sub T_Comision_TextChanged(sender As Object, e As EventArgs) Handles T_Comision.TextChanged
        '
    End Sub
    Private Sub T_Gas_TextChanged(sender As Object, e As EventArgs) Handles T_Gas.TextChanged
        '
    End Sub
    '
    '
    '
    Private Sub T_ValorOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorOrigen.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorOrigen, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_ValorDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorDestino.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorDestino, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Comision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Comision.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Comision, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Gas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Gas.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Gas, sender, e) Then e.Handled = True
    End Sub
    '
    '
    '
End Class