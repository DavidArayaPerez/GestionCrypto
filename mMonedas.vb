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
    '   0   ID          x
    '   1   Nombre      x
    '   2   Acronimo    x
    '   3   Contrato    x
    '
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
