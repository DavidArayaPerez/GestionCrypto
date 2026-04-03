'
'
'
Public Class F_CompraFIAT
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
            T = Matriz_Exchange(i, 0) & " " & "(" & i & ")"
            C_Exchange.Items.Add(T)
        Next i
        '
        C_MonedaOrigen.Items.Clear()
        C_MonedaOrigen.Items.Add("CLP")
        C_MonedaOrigen.Items.Add("USDT")
        '
        C_MonedaDestino.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
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
        rT_Nota.Enabled = Habilitar
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
        'T_GasCompra.Text = Matriz_Compras(F, 9)
        L_PrecioMoneda.Text = Matriz_Compras(F, 10)
        '
        'Dim NombreNota As String = T_FechaCompra.Text & "_" & T_HoraCompra.Text & "_" & "Compras" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaCompra)
    End Sub
    Private Sub Grabar()
        Dim F As Integer = L_Fila.Text
        If F = 0 Then Exit Sub
        '
        'Matriz_Compras(F, 0) = X
        Matriz_Compras(F, 1) = T_Fecha.Text
        Matriz_Compras(F, 2) = T_Hora.Text
        Matriz_Compras(F, 3) = C_Exchange.Text
        Matriz_Compras(F, 4) = C_MonedaOrigen.Text
        Matriz_Compras(F, 5) = T_MontoOrigen.Text
        Matriz_Compras(F, 6) = C_MonedaDestino.Text
        Matriz_Compras(F, 7) = T_CantidadCryptos.Text
        Matriz_Compras(F, 8) = T_Comision.Text
        'Matriz_Compras(F, 9) = T_GasCompra.Text
        Matriz_Compras(F, 10) = L_PrecioMoneda.Text
        '

        L_PrecioMoneda.Text = T_CantidadCryptos.Text

        '
        Guardar_Matrices("Compras")
        '
        Dim NombreNota As String = "M_" & T_Fecha.Text & "_" & T_Hora.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Compra guardada correctamente"
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
    Private Sub F_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim CantidadCryptos As Double = ValidaTXT_Numero(T_CantidadCryptos.Text)
        Dim MontoOrigen As Double = ValidaTXT_Numero(T_MontoOrigen.Text)
        Dim Comision As Double = ValidaTXT_Numero(T_Comision.Text)
        '
        L_PrecioMoneda.Text = (MontoOrigen / CantidadCryptos) - Comision
    End Sub
    Private Sub T_CantidadCryptos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_CantidadCryptos.KeyPress
        If VariableDeInicio Then Exit Sub
        Texto_KeyPress(T_CantidadCryptos, sender, e)
    End Sub
    Private Sub T_Comision_TextChanged(sender As Object, e As EventArgs) Handles T_Comision.TextChanged
        If VariableDeInicio Then Exit Sub
        Dim CantidadCryptos As Double = ValidaTXT_Numero(T_CantidadCryptos.Text)
        Dim MontoOrigen As Double = ValidaTXT_Numero(T_MontoOrigen.Text)
        Dim Comision As Double = ValidaTXT_Numero(T_Comision.Text)
        '
        L_PrecioMoneda.Text = (MontoOrigen / CantidadCryptos) - Comision
    End Sub
    Private Sub T_Comision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Comision.KeyPress
        If VariableDeInicio Then Exit Sub
        Texto_KeyPress(T_CantidadCryptos, sender, e)
    End Sub
    Private Sub T_MontoOrigen_TextChanged(sender As Object, e As EventArgs) Handles T_MontoOrigen.TextChanged
        If VariableDeInicio Then Exit Sub
        Dim CantidadCryptos As Double = ValidaTXT_Numero(T_CantidadCryptos.Text)
        Dim MontoOrigen As Double = ValidaTXT_Numero(T_MontoOrigen.Text)
        Dim Comision As Double = ValidaTXT_Numero(T_Comision.Text)
        '
        L_PrecioMoneda.Text = (MontoOrigen / CantidadCryptos) - Comision
    End Sub
    Private Sub T_MontoOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_MontoOrigen.KeyPress
        If VariableDeInicio Then Exit Sub
        Texto_KeyPress(T_MontoOrigen, sender, e)
    End Sub

    Private Sub Cal_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Cal_Fecha.ValueChanged
        T_Fecha.Text = DateTime.Parse(Cal_Fecha.Value).ToString("yyyyMMdd")
    End Sub
    '
    '
    '
End Class