'
'
'
Imports Microsoft.Graph.Admin
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions

Module mExchange
    '
    '
    '
    Public Matriz_Exchange(,) As String
    Public Matriz_ExchangeTF As Integer
    Public Matriz_ExchangeTC As Integer = 3
    '
    '   0   ID
    '   1   Nombre
    '   2   Link
    '
    Public Function BuscarExchange(T As String) As Integer
        If T = Nothing Then Return 0
        If T = "" Then Return 0
        '
        For i As Integer = 1 To Matriz_ExchangeTF
            If T = Matriz_Exchange(i, 2) Then Return i
        Next i
        Return 0
    End Function
    Public Function ExisteExchange(T As String) As String
        For i As Integer = 1 To Matriz_ExchangeTF
            If T = Matriz_Exchange(i, 1) Then Return True 'Si existe
        Next i
        Return False 'No existe
    End Function
    Public Sub Llenar_Exchange(ByRef Combo As ComboBox)
        Dim T As String
        Combo.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 1)
            Combo.Items.Add(T)
        Next i
    End Sub
    Public Sub LlenarList_Exchange(ByRef Lista As ListBox)
        Dim T As String
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 1)
            Lista.Items.Add(T)
        Next i
    End Sub
    '
    '
    '
End Module
