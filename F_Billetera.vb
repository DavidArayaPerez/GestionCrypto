'
'
'
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class F_Billetera
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpieza()
        '
        L_Billeteras.Items.Clear()
        Dim T As String
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 0) & " " & "(" & i & ")"
            L_Billeteras.Items.Add(T)
        Next i
        VariableDeInicio = False
    End Sub
    Private Sub Limpieza(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        'BILLETERA
        T_NombreBilletera.Text = ""
        T_CodigoBilletera.Text = ""
        L_Fila.Text = ""
        rT_Nota.Text = ""
        '
        T_NombreBilletera.Enabled = Habilitar
        T_CodigoBilletera.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        B_Grabar.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpieza(True)
        If F < 1 Then Exit Sub
        '
        L_Fila.Text = F
        T_CodigoBilletera.Text = Matriz_Billeteras(F, 0)
        T_NombreBilletera.Text = Matriz_Billeteras(F, 1)
        '
        Dim NombreNota As String = "Wall_" & T_NombreBilletera.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
        '   0   Codigo Billetera
        '   1   Nombre
        '
    End Sub
    Private Sub Grabar()
        Dim F As Integer = L_Fila.Text
        If F = 0 Then Exit Sub
        '
        Matriz_Billeteras(F, 0) = T_CodigoBilletera.Text
        Matriz_Billeteras(F, 1) = T_NombreBilletera.Text
        '
        Guardar_Matrices("Billeteras")
        '
        Dim NombreNota As String = "Wall_" & T_CodigoBilletera.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Moneda guardada correctamente"
        '   0   Codigo Billetera
        '   1   Nombre
    End Sub
    Public Sub CopiarAlPortapapeles(ByVal txt As Control)
        If Not String.IsNullOrWhiteSpace(txt.Text) Then
            Clipboard.SetText(txt.Text)
        End If
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    Private Sub F_Billetera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpieza()
        '
        Dim Codigo As String = InputBox("Ingrese el código de la billetera", "Nueva Billetera")
        If Codigo = "" Then Exit Sub
        '
        For i As Integer = 1 To Matriz_BilleterasTF
            If Matriz_Billeteras(i, 0) = Codigo Then
                MsgBox("El código de billetera ya existe. Por favor, ingrese un código diferente.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next i
        '
        Dim Fila = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Matriz_Billeteras(Fila, 0) = Codigo
        Matriz_Billeteras(Fila, 1) = ""
        Guardar_Matrices("Billeteras")
        Inicializar()
    End Sub
    Private Sub L_Billeteras_Click(sender As Object, e As EventArgs) Handles L_Billeteras.Click
        If VariableDeInicio Then Exit Sub
        '
        Dim T As String = L_Billeteras.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        Ver(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub L_Billeteras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Billeteras.SelectedIndexChanged

    End Sub
    Private Sub B_GrabarBilletera_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
        Grabar()
    End Sub

    Private Sub B_Copiar_Click(sender As Object, e As EventArgs) Handles B_Copiar.Click
        CopiarAlPortapapeles(T_CodigoBilletera)
    End Sub





    '
    '
    '
End Class