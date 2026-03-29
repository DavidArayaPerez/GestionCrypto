'
'
'
Module mMonedas
    '
    '
    '
    Public Matriz_Monedas(,) As String
    Public Matriz_MonedasTF As String
    Public Matriz_MonedasTC As String = 3
    '
    '   0   ID
    '   1   Nombre
    '   2   Acronimo
    '   3   Contrato
    '
    Public Function Buscar_Monedas(Fecha As String, Hora As String) As Integer
        Dim Matriz(,) As String = Matriz_Monedas
        Dim TotalFilas As Integer = Matriz_MonedasTF
        For i As Integer = 1 To TotalFilas
            If Fecha = Matriz(i, 1) And Hora = Matriz(i, 2) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_Monedas() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Monedas(Fila, 0) = CodigoInterno
        Matriz_Monedas(Fila, 1) = ""
        Matriz_Monedas(Fila, 2) = ""
        Matriz_Monedas(Fila, 3) = ""
        Return Fila
    End Function
    '
    '
    '
End Module
