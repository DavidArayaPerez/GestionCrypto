'
'
'
Module mMovimientos
    '
    '
    '
    Public Matriz_Movimientos(,) As String
    Public Matriz_MovimientosTF As Integer
    Public Matriz_MovimientosTC As Integer = 11
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
    Public Sub Transformar_Fechas_Movimientos()
        Dim Matriz(,) As String = Matriz_Movimientos
        Dim TotalFilas As Integer = Matriz_MovimientosTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 1))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_Movimientos = Matriz
    End Sub
    '
    '
    '
End Module
