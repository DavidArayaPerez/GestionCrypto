'
'
'
Module mExchange
    '
    '
    '
    Public Matriz_Exchange(,) As String
    Public Matriz_ExchangeTF As String
    Public Matriz_ExchangeTC As String = 1
    '
    '   0   ID
    '   1   Nombre
    '
    Public Function Buscar_Exchange(Fecha As String, Hora As String) As Integer
        Dim Matriz(,) As String = Matriz_Exchange
        Dim TotalFilas As Integer = Matriz_ExchangeTF
        For i As Integer = 1 To TotalFilas
            If Fecha = Matriz(i, 1) And Hora = Matriz(i, 2) Then
                Return i
            End If
        Next i
        Return 0
    End Function
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
