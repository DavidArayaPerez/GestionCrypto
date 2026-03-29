'
'
'
Module mMovimientos
    '
    '
    '
    Public Matriz_Movimientos(,) As String
    Public Matriz_MovimientosTF As String
    Public Matriz_MovimientosTC As String = 10
    '
    '   0   ID
    '   1   Fecha
    '   2   Hora
    '   3   Plataforma      MetraMask, Uniswap, etc
    '   4   Billetera
    '   5   Moneda_Origen
    '   6   Valor_Origen
    '   7   Moneda_Destino
    '   8   Valor_Destino
    '   9   Comsion
    '   10  Gas
    '
    Public Function Buscar_Movimiento(Fecha As String, Hora As String) As Integer
        Dim Matriz(,) As String = Matriz_Movimientos
        Dim TotalFilas As Integer = Matriz_MovimientosTF
        For i As Integer = 1 To TotalFilas
            If Fecha = Matriz(i, 1) And Hora = Matriz(i, 2) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_Movimiento() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Movimientos, Matriz_MovimientosTF, Matriz_MovimientosTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Movimientos(Fila, 0) = CodigoInterno
        Matriz_Movimientos(Fila, 1) = ""
        Matriz_Movimientos(Fila, 2) = ""
        Matriz_Movimientos(Fila, 3) = ""
        Matriz_Movimientos(Fila, 4) = ""
        Matriz_Movimientos(Fila, 5) = ""
        Matriz_Movimientos(Fila, 6) = ""
        Matriz_Movimientos(Fila, 7) = ""
        Matriz_Movimientos(Fila, 8) = ""
        Matriz_Movimientos(Fila, 9) = ""
        Matriz_Movimientos(Fila, 10) = ""
        Return Fila
    End Function
    '
    '
    '

End Module
