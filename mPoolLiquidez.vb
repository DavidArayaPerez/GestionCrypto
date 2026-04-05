'
'
'
Module mPoolLiquidez
    '
    '
    '

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
    '
    '
    '
End Module
