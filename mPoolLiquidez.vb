'
'
'
Module mPoolLiquidez
    '
    '
    '
    Public Sub LlenarList_PoolLiquidez(ByRef Lista As ListBox)
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_PoolLiquidezTF
            '   1 Fecha   3 Exchange   2 ID_Billetera
            Dim T As String = Matriz_PoolLiquidez(i, 1) & " - " & Matriz_PoolLiquidez(i, 3) & " - " & Matriz_PoolLiquidez(i, 2)
            Lista.Items.Add(T)
        Next i
    End Sub
    Public Function BuscarPoolLiquidez(ByVal Clave As String) As Integer
        If Clave = Nothing OrElse Clave = "" Then Return 0
        For i As Integer = 1 To Matriz_PoolLiquidezTF
            Dim T As String = Matriz_PoolLiquidez(i, 1) & " - " & Matriz_PoolLiquidez(i, 3) & " - " & Matriz_PoolLiquidez(i, 2)
            If Clave = T Then Return i
        Next i
        Return 0
    End Function
    '
    '
    '
End Module
