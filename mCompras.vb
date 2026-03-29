'
'
'
Module mCompras
    '
    '
    '
    Public Matriz_Compras(,) As String
    Public Matriz_ComprasTF As String
    Public Matriz_ComprasTC As String = 10
    '
    '   0   ID
    '   1   Fecha
    '   2   Hora
    '   3   Plataforma      MetraMask, Uniswap, etc
    '   4   Moneda_Origen
    '   5   Valor_Origen
    '   6   Moneda_Destino
    '   7   Valor_Destino
    '   8   Comision
    '   9   Gas
    '   10  Precio
    '
    Public Function Buscar_Compras(Codigo As String) As Integer
        Codigo = UCase(Codigo.Trim).Trim
        If Codigo = Nothing Then Return -1
        Dim Matriz(,) As String = Matriz_Compras
        Dim TotalFilas As Integer = Matriz_ComprasTF
        For i As Integer = 1 To TotalFilas
            If Codigo = Matriz(i, 0) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_Compras() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Compras, Matriz_ComprasTF, Matriz_ComprasTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Compras(Fila, 0) = CodigoInterno
        Matriz_Compras(Fila, 1) = ""
        Matriz_Compras(Fila, 2) = ""
        Matriz_Compras(Fila, 3) = ""
        Matriz_Compras(Fila, 4) = ""
        Matriz_Compras(Fila, 5) = ""
        Matriz_Compras(Fila, 6) = ""
        Matriz_Compras(Fila, 7) = ""
        Matriz_Compras(Fila, 8) = ""
        Matriz_Compras(Fila, 9) = ""
        Matriz_Compras(Fila, 10) = ""
        Return Fila
    End Function


    '
    '
    '
End Module
