'
'
'
Module mRedes
    '
    '
    '
    '1. Chainlist / chainid.network ✅ (La mejor opción)
    'Es el estándar de facto para redes EVM. Mantiene una lista pública en GitHub con todas las redes EVM y sus Chain IDs.
    'URL del JSON: https://chainid.network/chains.json
    '


    Public Function BuscarRedes(T As String) As Integer
        If T = Nothing Then Return 0
        If T = "" Then Return 0
        '
        For i As Integer = 1 To Matriz_RedesTF
            If T = Matriz_Redes(i, 2) Then Return i
        Next i
        Return 0
    End Function
    Public Sub LlenarList_Redes(ByRef Lista As ListBox)
        Dim Contador As Integer = 0
        Dim T As String
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_RedesTF
            T = Matriz_Redes(i, 2)
            Lista.Items.Add(T)
        Next i
    End Sub
    '
    '
    '
End Module
