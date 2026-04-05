'
'
'
Module mBilleteras
    '
    '
    '
    Public Function Crear_Billeteras() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Return Fila
    End Function
    Public Function ExisteBilletera(T As String) As String
        For i As Integer = 1 To Matriz_BilleterasTF
            If T = Matriz_Billeteras(i, 1) Then Return True 'Si existe
        Next i
        Return False 'No existe
    End Function
    Public Function BuscarBilletera(Nombre As String) As Integer
        If Nombre = Nothing Then Return 0
        If Nombre = "" Then Return 0
        '
        For i As Integer = 1 To Matriz_BilleterasTF
            If Nombre = Matriz_Billeteras(i, 1) Then Return i
        Next i
        Return 0
    End Function
    Public Sub Llenar_Billetera(ByRef Combo As ComboBox)
        Dim T As String
        Combo.Items.Clear()
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 1)
            Combo.Items.Add(T)
        Next i
    End Sub
    Public Sub LlenarList_Billetera(ByRef Lista As ListBox)
        Dim T As String
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 1)
            Lista.Items.Add(T)
        Next i
    End Sub
    '
    '
    '
End Module
