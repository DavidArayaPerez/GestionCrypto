'
'
'
Module mBilleteras
    '
    '
    '
    Public Matriz_Billeteras(,) As String
    Public Matriz_BilleterasTF As String
    Public Matriz_BilleterasTC As String = 1
    '
    '   0   Codigo Billetera
    '   1   Nombre
    '
    Public Function Buscar_Billeteras(Codigo As String) As Integer
        Codigo = UCase(Codigo.Trim).Trim
        If Codigo = Nothing Then Return -1
        Dim Matriz(,) As String = Matriz_Billeteras
        Dim TotalFilas As Integer = Matriz_BilleterasTF
        For i As Integer = 1 To TotalFilas
            If Codigo = Matriz(i, 0) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_Billeteras() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Return Fila
    End Function
    '
    '
    '
End Module
