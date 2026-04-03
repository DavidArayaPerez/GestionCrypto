'
'
'
Module mExchange
    '
    '
    '
    Public Matriz_Exchange(,) As String
    Public Matriz_ExchangeTF As Integer
    Public Matriz_ExchangeTC As Integer = 2
    '
    '   0   ID
    '   1   Nombre
    '
    Public Function Crear_Exchange() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Exchange, Matriz_ExchangeTF, Matriz_ExchangeTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Exchange(Fila, 0) = CodigoInterno
        Matriz_Exchange(Fila, 1) = ""
        Return Fila
    End Function
    '
    '
    '
End Module
