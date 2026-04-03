'
'
'
Public Class F_Exchange
    '
    '
    '
    Private Sub Inicializar()
        Limpieza()
    End Sub
    Private Sub Limpieza(Optional Habilitar As Boolean = False)
        L_Fila.Text = ""
        'EXCHANGE
        T_Nom.Text = ""
        T_Link.Text = ""
        rT_Nota.Text = ""
        '
        T_Nom.Enabled = Habilitar
        T_Link.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpieza(True)
        If F < 1 Then Exit Sub
        '
        T_Nom.Text = Matriz_Exchange(F, 0)
        T_Link.Text = Matriz_Exchange(F, 2)
        '
        Dim NombreNota As String = "Exc_" & T_Nom.Text & "_.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
        '
        '   0   ID
        '   1   Nombre
        '   2   Link
        '
    End Sub
    Private Sub Grabar()
        Dim F As Integer = L_Fila.Text
        If F = 0 Then Exit Sub
        '
        'Matriz_Exchange(F, 0) = ID
        'Matriz_Exchange(F, 1) = T_Nom.Text
        'Matriz_Exchange(F, 2) = T_Link.Text 
        '
        Guardar_Matrices("Exchange")
        '
        Dim NombreNota As String = "Exc_" & T_Nom.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Exchange guardada correctamente"
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
    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click
        Limpieza(True)
        T_Nom.Focus()
    End Sub
    Private Sub B_GrabarExchange_Click(sender As Object, e As EventArgs) Handles B_GrabarExchange.Click
        Grabar()
    End Sub
    Private Sub F_Exchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar
    End Sub
    '
    '
    '
End Class