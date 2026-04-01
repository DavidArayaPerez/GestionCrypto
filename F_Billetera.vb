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

    '
    '
    '
End Class