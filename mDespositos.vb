'
'
'
Module mDespositos
    '
    '
    '
    Public Matriz_Depositos(,) As String
    Public Matriz_DepositosTF As String
    Public Matriz_DepositosTC As String = 11
    '
    '   0   ID
    '   1   Fecha
    '   2   Hora
    '   3   Plataforma      MetraMask, Uniswap, etc
    '   4   Billetera
    '   5   Moneda_Entrada
    '   6   Valor_Entrada
    '   7   Moneda_Salida
    '   8   Valor_Salida
    '   9   Comision
    '   10  Gas
    '   11  Precio
    '
    Public Function Buscar_Depositos(Fecha As String, Hora As String) As Integer
        Dim Matriz(,) As String = Matriz_Depositos
        Dim TotalFilas As Integer = Matriz_DepositosTF
        For i As Integer = 1 To TotalFilas
            If Fecha = Matriz(i, 1) And Hora = Matriz(i, 2) Then
                Return i
            End If
        Next i
        Return 0
    End Function
    Public Function Crear_Depositos() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Depositos, Matriz_DepositosTF, Matriz_DepositosTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Depositos(Fila, 0) = CodigoInterno
        Matriz_Depositos(Fila, 1) = ""
        Matriz_Depositos(Fila, 2) = ""
        Matriz_Depositos(Fila, 3) = ""
        Matriz_Depositos(Fila, 4) = ""
        Matriz_Depositos(Fila, 5) = ""
        Matriz_Depositos(Fila, 6) = ""
        Matriz_Depositos(Fila, 7) = ""
        Matriz_Depositos(Fila, 8) = ""
        Matriz_Depositos(Fila, 9) = ""
        Matriz_Depositos(Fila, 10) = ""
        Matriz_Depositos(Fila, 11) = ""
        Matriz_Depositos(Fila, 12) = ""
        Return Fila
    End Function
    '
    '
    '
End Module
