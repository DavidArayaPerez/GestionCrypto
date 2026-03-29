'
'
'
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions

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
    Public Sub Transformar_Fechas_Compras()
        Dim Matriz(,) As String = Matriz_Compras
        Dim TotalFilas As Integer = Matriz_ComprasTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 1))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_Compras = Matriz
    End Sub
    Public Sub Ordenar_Compras()
        Dim Matriz(,) As String = Matriz_Compras
        Dim TotalFilas As Integer = Matriz_ComprasTF
        Dim TotalColumnas As Integer = Matriz_ComprasTC
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
