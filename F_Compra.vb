'
'
'
Public Class F_Compra
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpiar()
        Llenar_Exchange(C_Exchange)
        Llenar_Monedas(C_MonedaOrigen)
        Llenar_Monedas(C_MonedaDestino)
        Llenar_Billetera(C_Billetera)
        LlenarList_Compras(L_Compras)
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
        C_Billetera.Text = ""
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
        C_Billetera.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        '
        Cal_Fecha.Enabled = Habilitar
    End Sub
    Private Sub Ver(FechaHora_PlataformaMoneda As String)
        Limpiar(True)
        Dim F As Integer = BuscarCompras(FechaHora_PlataformaMoneda)
        If F < 1 Then Exit Sub
        '
        T_Fecha.Text = Matriz_Compras(f, 1)
        T_Hora.Text = Matriz_Compras(f, 2)
        C_Exchange.Text = Matriz_Compras(f, 3)
        C_MonedaOrigen.Text = Matriz_Compras(f, 4)
        T_MontoOrigen.Text = Matriz_Compras(f, 5)
        C_MonedaDestino.Text = Matriz_Compras(f, 6)
        T_CantidadCryptos.Text = Matriz_Compras(f, 7)
        T_Comision.Text = Matriz_Compras(f, 8)
        T_Gas.Text = Matriz_Compras(f, 9)
        L_PrecioMoneda.Text = Matriz_Compras(f, 10)
        '
        Dim NombreNota As String = "Fiat_" & T_Fecha.Text & "_" & T_Hora.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
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
    Private Function DatosNoValidos() As Boolean
        If ExisteExchange(C_Exchange.Text) = False Then L_Mensaje.Text = "Plataforma no válida" : Return True
        If ExisteMoneda_Simbolo(C_MonedaDestino.Text) = False Then L_Mensaje.Text = "Moneda no válida" : Return True
        If C_MonedaOrigen.Text <> "CLP" And C_MonedaOrigen.Text <> "USDT" Then L_Mensaje.Text = "Moneda Local no válida" : Return True
        If Len(T_Hora.Text) = 4 Then T_Hora.Text = Mid(T_Hora.Text, 1, 2) & ":" & Mid(T_Hora.Text, 3, 2)
        If Len(T_Hora.Text) = 5 And Mid(T_Hora.Text, 3, 1) = ":" Then
            'Valido
        Else
            L_Mensaje.Text = "La hora ingresada no es valido" & vbCrLf & "Solo ingrese numeros en el formato HHmm" : Return True
        End If
        If Len(T_Fecha.Text) = 8 Then
            'Valido
        Else
            L_Mensaje.Text = "La Fecha ingresada no es valida" & vbCrLf & "Solo ingrese numeros en el formato YYYYmmDD" : Return True
        End If
        Return False
    End Function
    Private Function PreGrabar() As Boolean
        '                 1   Fecha            2   Hora              3 Plataforma              6 Moneda_Destino
        Dim T As String = T_Fecha.Text & " " & T_Hora.Text & " - " & C_Exchange.Text & " - " & C_MonedaDestino.Text

        '
        If Val(L_Fila.Text) = 0 Then
            'Nuevo registro
            Dim F As Integer = BuscarCompras(T)
            If F > 0 Then
                'Nuevo registro. Pero ya existe en la Matriz
                MsgBox("El registro ya existe", vbInformation)
                Ver(T)
                Return True
            Else
                'Nuevo registro. NO existe en la Matriz
                F = AgrandarMatriz(Matriz_Compras, Matriz_ComprasTF, Matriz_ComprasTC)
                L_Fila.Text = F
                Matriz_Compras(F, 0) = CrearCodigoInterno()
                Return False
            End If
        Else
            'Registro antiguo ya tiene fila.
            Return False
        End If
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        If PreGrabar() Then Exit Sub
        '
        Dim F As Integer = L_Fila.Text
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
    Private Sub B_Nuevo_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpiar(True)
        L_Fila.Text = "0"
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Hora.Text = DateTime.Now.ToString("HHmmss")
        C_MonedaOrigen.Text = "CLP"
        T_MontoOrigen.Focus()
    End Sub
    Private Sub B_Grabar_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
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

    Private Sub L_Compras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Compras.SelectedIndexChanged

    End Sub
    Private Sub L_Compras_Click(sender As Object, e As EventArgs) Handles L_Compras.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_Compras.Text)
    End Sub




    '
    '
    '
End Class