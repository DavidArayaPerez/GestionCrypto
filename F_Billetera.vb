'
'
'
Public Class F_Billetera
    '
    '
    '
    Private Sub LimpiezaBilletera(Optional Habilitar As Boolean = False)
        'BILLETERA
        T_NombreBilletera.Text = ""
        T_CodigoBilletera.Text = ""
        rT_NotaBilletera.Text = ""
        '
        T_NombreBilletera.Enabled = Habilitar
        T_CodigoBilletera.Enabled = Habilitar
        rT_NotaBilletera.Enabled = Habilitar
    End Sub
    Private Sub VerBilletera(F As Integer)
        LimpiezaBilletera(True)
        If F < 1 Then Exit Sub

        T_NombreBilletera.Text = Matriz_Billeteras(F, 1)
        T_CodigoBilletera.Text = Matriz_Billeteras(F, 2)
        '
        'Dim NombreNota As String = "Billetera" & T_CodigoBilletera.Text & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaBilletera)
        '   0   Codigo Billetera
        '   1   Nombre
        '
    End Sub







    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click
        LimpiezaBilletera()
        '
        Dim CodigoBilletera As String = InputBox("Ingrese el código de la billetera", "Nueva Billetera")
        For i As Integer = 1 To Matriz_BilleterasTF
            If Matriz_Billeteras(i, 2) = CodigoBilletera Then
                MsgBox("El código de billetera ya existe. Por favor, ingrese un código diferente.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next i
        '
        Dim Fila = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Matriz_Billeteras(Fila, 0) = CodigoBilletera
        Matriz_Billeteras(Fila, 1) = ""

    End Sub

    '
    '
    '
End Class