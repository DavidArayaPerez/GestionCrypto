'
'
'
Module wObjeto_CajaTexto
    '
    '
    '
    Public Function Texto_KeyPress(ByRef Control As TextBox, sender As Object, ByRef e As KeyPressEventArgs) As Boolean
        ' Permitir solo dígitos y teclas de control (como Backspace)
        If Char.IsDigit(e.KeyChar) Then
            Return False
        ElseIf Char.IsControl(e.KeyChar) Then
            Return False
        ElseIf e.KeyChar = "." Then
            Return False
        ElseIf e.KeyChar = "," Then
            Return False
        End If
        Return True
    End Function

    '
    '
    '
End Module
'
'
'
