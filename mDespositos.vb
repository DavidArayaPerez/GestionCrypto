'
'
'
Module mDespositos
    '
    '
    '
    Public Matriz_Depositos(,) As String
    Public Matriz_DepositosTF As Integer
    Public Matriz_DepositosTC As Integer = 12
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
    Public Sub Transformar_Fechas_Depositos()
        Dim Matriz(,) As String = Matriz_Depositos
        Dim TotalFilas As Integer = Matriz_DepositosTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 1))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_Depositos = Matriz
    End Sub
    Public Sub Ordenar_Depositos()
        Dim Matriz(,) As String = Matriz_Depositos
        Dim TotalFilas As Integer = Matriz_DepositosTF
        Dim TotalColumnas As Integer = Matriz_DepositosTC
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
