'
'
'
Public Class F_Exchange
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpieza()
        LlenarList_Exchange(L_Exchange)
        VariableDeInicio = False
    End Sub
    Private Sub Limpieza(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        L_Fila.Text = ""
        'EXCHANGE
        T_Nom.Text = ""
        T_Link.Text = ""
        rT_Nota.Text = ""
        '
        T_Nom.Enabled = Habilitar
        T_Link.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        '
        B_Grabar.Enabled = Habilitar
    End Sub
    Private Sub Ver(Nombre As String)
        Limpieza(True)
        Dim F As Integer = BuscarExchange(Nombre)
        If F < 1 Then Exit Sub
        '
        L_Fila.Text = F
        'Matriz_Exchange(F, 0)
        T_Nom.Text = Matriz_Exchange(F, 1)
        T_Link.Text = Matriz_Exchange(F, 2)
        '
        Dim NombreNota As String = "Exc_" & T_Nom.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
        '   0   Codigo Billetera
        '   1   Nombre
        '   2   Link
    End Sub
    Private Sub Grabar()
        Dim F As Integer = L_Fila.Text
        If F = 0 Then Exit Sub
        '
        'Matriz_Exchange(F, 0) = ID
        Matriz_Exchange(F, 1) = T_Nom.Text
        Matriz_Exchange(F, 2) = T_Link.Text
        '
        Guardar_Matrices("Exchange")
        '
        Dim NombreNota As String = "Exc_" & T_Nom.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        Inicializar()

        L_Mensaje.Text = "Exchange guardada correctamente"
        '   0   Codigo Billetera
        '   1   Nombre
        '   2   Link
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



    Private Sub B_GrabarExchange_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
        Grabar()
    End Sub
    Private Sub F_Exchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar
    End Sub
    Private Sub L_Exchange_Click(sender As Object, e As EventArgs) Handles L_Exchange.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_Exchange.Text)
    End Sub
    Private Sub L_Exchange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Exchange.SelectedIndexChanged

    End Sub
    Private Sub B_Nuevo_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpieza(True)
        '
        Dim Nombre As String = InputBox("Ingrese el NOMBRE del Exchange", "Nuevo Exchange")
        For i As Integer = 1 To Matriz_ExchangeTF
            If Matriz_Exchange(i, 0) = Nombre Then
                MsgBox("El NOMBRE del Exchange ya existe.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next i
        '
        Dim Fila = AgrandarMatriz(Matriz_Exchange, Matriz_ExchangeTF, Matriz_ExchangeTC)
        'Matriz_Exchange(Fila, 0) = Codigo
        Matriz_Exchange(Fila, 1) = Nombre.ToUpper
        Matriz_Exchange(Fila, 2) = ""
        Guardar_Matrices("Exchange")
        Inicializar()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_Link.Text) < 3 Then Exit Sub
        '
        Dim URL As String = T_Link.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    '
    '
    '
End Class