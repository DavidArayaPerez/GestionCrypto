'
'
'
Module mBilleteras
    '
    '
    '
    Public Matriz_Billeteras(,) As String
    Public Matriz_BilleterasTF As Integer
    Public Matriz_BilleterasTC As Integer = 4
    '
    '   0   Codigo Billetera
    '   1   Nombre
    '   2   Link

    Public Function Crear_Billeteras() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Return Fila
    End Function
    Public Sub Llenar_Billetera(ByRef Combo As ComboBox)
        Dim T As String
        Combo.Items.Clear()
        For i As Integer = 1 To Matriz_BilleterasTF
            T = Matriz_Billeteras(i, 1)
            Combo.Items.Add(T)
        Next i
    End Sub
    '
    '
    '
End Module
