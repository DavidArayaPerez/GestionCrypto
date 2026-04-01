'
'
'
Public Class F_Exchange
    '
    '
    '

    Private Sub LimpiezaExchange(Optional Habilitar As Boolean = False)
        'EXCHANGE
        T_NomExchange.Text = ""
        rT_NotaExchange.Text = ""
        '
        T_NomExchange.Enabled = Habilitar
        rT_NotaExchange.Enabled = Habilitar
    End Sub
    Private Sub VerExchange(F As Integer)
        LimpiezaExchange(True)
        If F < 1 Then Exit Sub

        T_NomExchange.Text = Matriz_Exchange(F, 1)
        '
        'Dim NombreNota As String = "Echange" & T_NomExchange.Text & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaBilletera)
        '   0   ID
        '   1   Nombre
        '
    End Sub
    '
    '
    '
End Class