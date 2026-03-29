'
'
'
Module mPoolLiquidez
    '
    '
    '
    Public Matriz_PoolLiquidez(,) As String
    Public Matriz_PoolLiquidezTF As String
    Public Matriz_PoolLiquidezTC As String = 16
    '
    '   0   ID
    '   1   Fecha
    '   2   Hora
    '   3   Plataforma      MetraMask, Uniswap, etc
    '   4   Billetera
    '   5   Moneda_Uno
    '   6   Valor_Uno
    '   7   Moneda_Dos
    '   8   Valor_Dos
    '   9   Comision
    '   10  Gas
    '   11  Monto_Uno_Resultante
    '   12  Monto_Dos_Resultante
    '   13  Porcentaje_Uno
    '   14  Porcentaje_Dos
    '   15  Minimo
    '   16  Maximo
    '
    Public Function Buscar_PoolLiquidez(Fecha As String, Hora As String, MonedaUno As String, MonedaDos As String) As Integer
        Dim Matriz(,) As String = Matriz_PoolLiquidez
        Dim TotalFilas As Integer = Matriz_PoolLiquidezTF
        For i As Integer = 1 To TotalFilas
            If Fecha = Matriz(i, 1) And Hora = Matriz(i, 2) And MonedaUno = Matriz(i, 5) And MonedaDos = Matriz(i, 7) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_PoolLiquidez() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_PoolLiquidez, Matriz_PoolLiquidezTF, Matriz_PoolLiquidezTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_PoolLiquidez(Fila, 0) = CodigoInterno
        Matriz_PoolLiquidez(Fila, 1) = ""
        Matriz_PoolLiquidez(Fila, 2) = ""
        Matriz_PoolLiquidez(Fila, 3) = ""
        Matriz_PoolLiquidez(Fila, 4) = ""
        Matriz_PoolLiquidez(Fila, 5) = ""
        Matriz_PoolLiquidez(Fila, 6) = ""
        Matriz_PoolLiquidez(Fila, 7) = ""
        Matriz_PoolLiquidez(Fila, 8) = ""
        Matriz_PoolLiquidez(Fila, 9) = ""
        Matriz_PoolLiquidez(Fila, 10) = ""
        Matriz_PoolLiquidez(Fila, 11) = ""
        Matriz_PoolLiquidez(Fila, 12) = ""
        Matriz_PoolLiquidez(Fila, 13) = ""
        Matriz_PoolLiquidez(Fila, 14) = ""
        Matriz_PoolLiquidez(Fila, 15) = ""
        Matriz_PoolLiquidez(Fila, 16) = ""
        Return Fila
    End Function
    '
    '
    '
End Module
