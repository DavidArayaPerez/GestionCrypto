'
'
'
Public Class F_Traspaso
    '
    Private _Fila As Integer = 0  ' reemplaza L_Fila — no visible en pantalla
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        '
        Limpiar()
        '
        Llenar_Exchange(C_Exchange)
        Llenar_Billetera(C_BilleteraOrigen)
        Llenar_Billetera(C_BilleteraDestino)
        Llenar_Monedas(C_MonedaOrigen)
        Llenar_Monedas(C_MonedaDestino)
        LlenarList_Traspasos(L_Traspasos)
        '
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        _Fila = 0
        L_Mensaje.Text = ""
        'TRASPASO
        T_Fecha.Text = ""
        T_Hora.Text = ""
        C_Exchange.Text = ""
        C_BilleteraOrigen.Text = ""
        C_MonedaOrigen.Text = ""
        T_ValorOrigen.Text = ""
        C_BilleteraDestino.Text = ""
        C_MonedaDestino.Text = ""
        T_ValorDestino.Text = ""
        T_Comision.Text = ""
        T_Gas.Text = ""
        rT_Nota.Text = ""
        '
        T_Fecha.Enabled = Habilitar
        T_Hora.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        C_BilleteraOrigen.Enabled = Habilitar
        C_MonedaOrigen.Enabled = Habilitar
        T_ValorOrigen.Enabled = Habilitar
        C_BilleteraDestino.Enabled = Habilitar
        C_MonedaDestino.Enabled = Habilitar
        T_ValorDestino.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        Cal_FechaTraspaso.Enabled = Habilitar
    End Sub
    Private Sub Ver(ByVal Clave As String)
        Limpiar(True)
        Dim F As Integer = BuscarTraspasos(Clave)
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
        _Fila = F
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
    Private Function DatosNoValidos() As Boolean
        If ExisteExchange(C_Exchange.Text) = False Then L_Mensaje.Text = "Plataforma no valida" : Return True
        If ExisteMoneda_Simbolo(C_MonedaOrigen.Text) = False Then L_Mensaje.Text = "Moneda Origen no valida" : Return True
        If ExisteMoneda_Simbolo(C_MonedaDestino.Text) = False Then L_Mensaje.Text = "Moneda Destino no valida" : Return True
        If Len(T_Hora.Text) = 4 Then T_Hora.Text = Mid(T_Hora.Text, 1, 2) & ":" & Mid(T_Hora.Text, 3, 2)
        If Len(T_Hora.Text) = 5 And Mid(T_Hora.Text, 3, 1) = ":" Then
            'Valido
        Else
            L_Mensaje.Text = "Hora invalida. Formato HHmm" : Return True
        End If
        If Len(T_Fecha.Text) <> 8 Then
            L_Mensaje.Text = "Fecha invalida. Formato YYYYmmDD" : Return True
        End If
        Return False
    End Function
    Private Function PreGrabar() As Boolean
        '           1 Fecha          2 Hora            3 Plataforma          4 BilleteraOrigen     7 BilleteraDestino
        Dim T As String = T_Fecha.Text & " " & T_Hora.Text & " - " & C_Exchange.Text & " - " & C_BilleteraOrigen.Text & " → " & C_BilleteraDestino.Text
        '
        If _Fila = 0 Then
            Dim F As Integer = BuscarTraspasos(T)
            If F > 0 Then
                MsgBox("El registro ya existe", vbInformation)
                Ver(T)
                Return True
            Else
                F = AgrandarMatriz(Matriz_Traspasos, Matriz_TraspasosTF, Matriz_TraspasosTC)
                _Fila = F
                Matriz_Traspasos(F, 0) = CrearCodigoInterno()
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        If PreGrabar() Then Exit Sub
        '
        Dim F As Integer = _Fila
        Matriz_Traspasos(F, 1) = T_Fecha.Text
        Matriz_Traspasos(F, 2) = T_Hora.Text
        Matriz_Traspasos(F, 3) = C_Exchange.Text
        Matriz_Traspasos(F, 4) = C_BilleteraOrigen.Text
        Matriz_Traspasos(F, 5) = C_MonedaOrigen.Text
        Matriz_Traspasos(F, 6) = T_ValorOrigen.Text
        Matriz_Traspasos(F, 7) = C_BilleteraDestino.Text
        Matriz_Traspasos(F, 8) = C_MonedaDestino.Text
        Matriz_Traspasos(F, 9) = T_ValorDestino.Text
        Matriz_Traspasos(F, 10) = T_Comision.Text
        Matriz_Traspasos(F, 11) = T_Gas.Text
        '
        Guardar_Matrices("Traspasos")
        '
        Dim NombreNota As String = "Tras_" & T_Fecha.Text & " " & T_Hora.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        LlenarList_Traspasos(L_Traspasos)
        L_Mensaje.Text = "Traspaso guardado correctamente"
        'Matriz_Traspasos(F, 0   ID
        'Matriz_Traspasos(F, 1   Fecha
        'Matriz_Traspasos(F, 2   Hora
        'Matriz_Traspasos(F, 3   Plataforma
        'Matriz_Traspasos(F, 4   Billetera_Origen
        'Matriz_Traspasos(F, 5   Moneda_Origen
        'Matriz_Traspasos(F, 6   Valor_Origen
        'Matriz_Traspasos(F, 7   Billetera_Destino
        'Matriz_Traspasos(F, 8   Moneda_Destino
        'Matriz_Traspasos(F, 9   Valor_Destino
        'Matriz_Traspasos(F, 10  Comision
        'Matriz_Traspasos(F, 11  Gas
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
    Private Sub F_Traspaso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click
        Limpiar(True)
        _Fila = 0
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Hora.Text = DateTime.Now.ToString("HHmm")
        C_BilleteraOrigen.Focus()
    End Sub
    Private Sub B_GrabarTraspaso_Click(sender As Object, e As EventArgs) Handles B_GrabarTraspaso.Click
        Grabar()
    End Sub
    Private Sub L_Traspasos_Click(sender As Object, e As EventArgs) Handles L_Traspasos.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_Traspasos.Text)
    End Sub
    Private Sub L_Traspasos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Traspasos.SelectedIndexChanged
        '
    End Sub
    Private Sub Cal_FechaTraspaso_ValueChanged(sender As Object, e As EventArgs) Handles Cal_FechaTraspaso.ValueChanged
        If VariableDeInicio Then Exit Sub
        T_Fecha.Text = DateTime.Parse(Cal_FechaTraspaso.Value).ToString("yyyyMMdd")
    End Sub
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
