'
'
'
Module mTraspasos
    '
    '
    '
    Public Matriz_Traspasos(,) As String
    Public Matriz_TraspasosTF As String
    Public Matriz_TraspasosTC As String = 10
    '
    '   0   ID
    '   1   Fecha
    '   2   Hora
    '   3   Plataforma          MetraMask, Uniswap, etc
    '   4   Billetera_Origen
    '   5   Moneda_Origen
    '   6   Valor_Origen
    '   7   Billetera_Destino
    '   8   Moneda_Destino
    '   9   Valor_Destino
    '   10   Comision
    '   11  Gas
    '
    Public Function Crear_Traspasos() As Integer
        'Devuelve la posicion del ultimo registro nuevo, el cual ya tiene el codigo interno
        Dim Fila As Integer = AgrandarMatriz(Matriz_Traspasos, Matriz_TraspasosTF, Matriz_TraspasosTC)
        Dim CodigoInterno As String = CrearCodigoInterno()
        Matriz_Traspasos(Fila, 0) = CodigoInterno
        Matriz_Traspasos(Fila, 1) = ""
        Matriz_Traspasos(Fila, 2) = ""
        Matriz_Traspasos(Fila, 3) = ""
        Matriz_Traspasos(Fila, 4) = ""
        Matriz_Traspasos(Fila, 5) = ""
        Matriz_Traspasos(Fila, 6) = ""
        Matriz_Traspasos(Fila, 7) = ""
        Matriz_Traspasos(Fila, 8) = ""
        Matriz_Traspasos(Fila, 9) = ""
        Matriz_Traspasos(Fila, 10) = ""
        Return Fila
    End Function
    Public Sub Transformar_Fechas_Traspasos()
        Dim Matriz(,) As String = Matriz_Traspasos
        Dim TotalFilas As Integer = Matriz_TraspasosTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 1))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_Traspasos = Matriz
    End Sub
    Public Sub Ordenar_Traspasos()
        Dim Matriz(,) As String = Matriz_Traspasos
        Dim TotalFilas As Integer = Matriz_TraspasosTF
        Dim TotalColumnas As Integer = Matriz_TraspasosTC
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
