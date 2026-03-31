'
'
'
Module mBilleteras
    '
    '
    '
    Public Matriz_Billeteras(,) As String
    Public Matriz_BilleterasTF As String
    Public Matriz_BilleterasTC As String = 2
    '
    '   0   Codigo Billetera
    '   1   Nombre
    '

    Public Function Crear_Billeteras() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Return Fila
    End Function
    '
    '
    '
End Module
