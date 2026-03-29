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
    Public Sub Transformar_Fechas_PoolLiquidez()
        Dim Matriz(,) As String = Matriz_PoolLiquidez
        Dim TotalFilas As Integer = Matriz_PoolLiquidezTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 1))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_PoolLiquidez = Matriz
    End Sub
    Public Sub Ordenar_PoolLiquidez()
        Dim Matriz(,) As String = Matriz_PoolLiquidez
        Dim TotalFilas As Integer = Matriz_PoolLiquidezTF
        Dim TotalColumnas As Integer = Matriz_PoolLiquidezTC
        For i As Integer = 1 To TotalFilas - 1
            For j As Integer = i + 1 To TotalFilas
                If Matriz(i, 1) & Matriz(i, 2) < Matriz(j, 1) & Matriz(j, 2) Then
                    For k As Integer = 0 To TotalColumnas - 1
                        Dim Temp As String = Matriz(i, k)
                        Matriz(i, k) = Matriz(j, k)
                        Matriz(j, k) = Temp
                    Next k
                End If
            Next j
        Next i
    End Sub
    '
    '
    '
End Module
