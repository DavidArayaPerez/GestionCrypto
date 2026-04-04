'
'
'
Imports Microsoft.Graph.Admin

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
    Public Function Crear_Exchange() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Exchange, Matriz_ExchangeTF, Matriz_ExchangeTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Exchange(Fila, 0) = CodigoInterno
        Matriz_Exchange(Fila, 1) = ""
        Return Fila
    End Function


    Public Function Buscar_Exchange(T As String) As String
        Dim SW As Boolean = True
        For i As Integer = 1 To Matriz_ExchangeTF
            If T = Matriz_Exchange(i, 1) Then Return "S" 'Si existe
        Next i
        Return "N" 'No existe
    End Function






    '
    '
    '
End Module
