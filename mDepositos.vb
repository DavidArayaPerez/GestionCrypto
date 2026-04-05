'
'
'
Module mDepositos
    '
    '
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

    '
    '
    '
End Module
