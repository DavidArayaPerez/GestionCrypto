'
'
'
Public Class F_Compra
    '
    '
    '
    Private Sub Inicializar()
        Dim T As String
        VariableDeInicio = True
        '
        Limpiar()
        '
        C_Exchange.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 1)
            C_Exchange.Items.Add(T)
        Next i
        '
        C_MonedaOrigen.Items.Clear()
        C_MonedaOrigen.Items.Add("CLP")
        C_MonedaOrigen.Items.Add("USDT")
        '
        C_MonedaDestino.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2)
            C_MonedaOrigen.Items.Add(T)
            C_MonedaDestino.Items.Add(T)
        Next i
        '
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        L_Fila.Text = ""
        L_PrecioMoneda.Text = ""
        L_Mensaje.Text = ""
        'COMPRAS
        T_Fecha.Text = ""
        T_Hora.Text = ""
        C_MonedaOrigen.Text = ""
        C_MonedaDestino.Text = ""
        T_MontoOrigen.Text = ""
        T_CantidadCryptos.Text = ""
        C_Exchange.Text = ""
        T_Comision.Text = ""
        T_Gas.Text = ""
        rT_Nota.Text = ""
        '
        T_Fecha.Enabled = Habilitar
        T_Hora.Enabled = Habilitar
        C_MonedaOrigen.Enabled = Habilitar
        C_MonedaDestino.Enabled = Habilitar
        T_MontoOrigen.Enabled = Habilitar
        T_CantidadCryptos.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        '
        Cal_Fecha.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpiar(True)
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
        T_Fecha.Text = Matriz_Compras(F, 1)
        T_Hora.Text = Matriz_Compras(F, 2)
        C_Exchange.Text = Matriz_Compras(F, 3)
        C_MonedaOrigen.Text = Matriz_Compras(F, 4)
        T_MontoOrigen.Text = Matriz_Compras(F, 5)
        C_MonedaDestino.Text = Matriz_Compras(F, 6)
        T_CantidadCryptos.Text = Matriz_Compras(F, 7)
        T_Comision.Text = Matriz_Compras(F, 8)
        T_Gas.Text = Matriz_Compras(F, 9)
        L_PrecioMoneda.Text = Matriz_Compras(F, 10)
        '
        Dim NombreNota As String = "Fiat_" & T_Fecha.Text & "_" & T_Hora.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
    End Sub
    Private Function DatosNoValidos() As Boolean
        '
        If Buscar_Exchange(C_Exchange.Text) = "N" Then L_Mensaje.Text = "Plataforma no válida" : Return True
        '
        If Buscar_Moneda(C_MonedaDestino.Text) = "N" Then L_Mensaje.Text = "Moneda no válida" : Return True
        '
        If C_MonedaOrigen.Text <> "CLP" And C_MonedaOrigen.Text <> "USDT" Then L_Mensaje.Text = "Moneda Local no válida" : Return True
        '
        Return False
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        '
        Dim F As Integer = L_Fila.Text
        If F = 0 Then
            F = AgrandarMatriz(Matriz_Compras, Matriz_ComprasTF, Matriz_ComprasTC)
            Matriz_Compras(F, 0) = CrearCodigoInterno()
        End If
        Matriz_Compras(F, 1) = T_Fecha.Text
        Matriz_Compras(F, 2) = T_Hora.Text
        Matriz_Compras(F, 3) = C_Exchange.Text
        Matriz_Compras(F, 4) = C_MonedaOrigen.Text
        Matriz_Compras(F, 5) = T_MontoOrigen.Text
        Matriz_Compras(F, 6) = C_MonedaDestino.Text
        Matriz_Compras(F, 7) = T_CantidadCryptos.Text
        Matriz_Compras(F, 8) = T_Comision.Text
        Matriz_Compras(F, 9) = T_Gas.Text
        Matriz_Compras(F, 10) = L_PrecioMoneda.Text
        '
        Guardar_Matrices("Compras")
        '
        Dim NombreNota As String = "Fiat_" & T_Fecha.Text & "_" & T_Hora.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Compra guardada correctamente"
        'Matriz_Compras(F,0   ID
        'Matriz_Compras(F,1   Fecha
        'Matriz_Compras(F,2   Hora
        'Matriz_Compras(F,3   Plataforma      MetraMask, Uniswap, etc
        'Matriz_Compras(F,4   Moneda_Origen
        'Matriz_Compras(F,5   Valor_Origen
        'Matriz_Compras(F,6   Moneda_Destino
        'Matriz_Compras(F,7   Valor_Destino
        'Matriz_Compras(F,8   Comision
        'Matriz_Compras(F,9   Gas
        'Matriz_Compras(F,10  Precio
        '
    End Sub
    Private Sub CalculoPrecioFinal()
        Dim CantidadCryptos As Double = ValidaTXT_Numero(T_CantidadCryptos.Text)
        Dim MontoOrigen As Double = ValidaTXT_Numero(T_MontoOrigen.Text)
        Dim Comision As Double = ValidaTXT_Numero(T_Comision.Text)
        Dim Gas As Double = ValidaTXT_Numero(T_Gas.Text)
        L_PrecioMoneda.Text = (MontoOrigen / CantidadCryptos) - Comision - Gas
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
    Private Sub F_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click
        Limpiar(True)
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Hora.Text = DateTime.Now.ToString("HHmmss")
        C_MonedaOrigen.Text = "CLP"
        T_MontoOrigen.Focus()
    End Sub
    Private Sub B_GrabarCompra_Click(sender As Object, e As EventArgs) Handles B_GrabarCompra.Click
        Grabar()
    End Sub

    Private Sub T_CantidadCryptos_TextChanged(sender As Object, e As EventArgs) Handles T_CantidadCryptos.TextChanged
        If VariableDeInicio Then Exit Sub
        CalculoPrecioFinal()
    End Sub

    Private Sub T_Comision_TextChanged(sender As Object, e As EventArgs) Handles T_Comision.TextChanged
        If VariableDeInicio Then Exit Sub
        CalculoPrecioFinal()
    End Sub

    Private Sub T_MontoOrigen_TextChanged(sender As Object, e As EventArgs) Handles T_MontoOrigen.TextChanged
        If VariableDeInicio Then Exit Sub
        CalculoPrecioFinal()
    End Sub
    Private Sub T_Gas_TextChanged(sender As Object, e As EventArgs) Handles T_Gas.TextChanged
        If VariableDeInicio Then Exit Sub
        CalculoPrecioFinal()
    End Sub
    '
    '
    Private Sub T_CantidadCryptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_CantidadCryptos.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_CantidadCryptos, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Comision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Comision.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Comision, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_MontoOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_MontoOrigen.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_MontoOrigen, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Gas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Gas.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Gas, sender, e) Then e.Handled = True
    End Sub
    '
    '
    Private Sub Cal_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Cal_Fecha.ValueChanged
        T_Fecha.Text = DateTime.Parse(Cal_Fecha.Value).ToString("yyyyMMdd")
    End Sub




    '
    '
    '
End Class