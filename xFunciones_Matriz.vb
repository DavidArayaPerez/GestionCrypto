'
'
'
Imports System.Reflection
'
'
'
Module xFunciones_Matriz
    '
    '
    '
    Public Function BuscarCualquierValorEnCuaquierMatriz(MatrizOrigen(,) As String, TotalFilas As Integer, NumeroColumnaBuscada As Integer, ElementoBuscado As String) As Integer
        'Devuelve la FILA
        Dim Matriz(,) As String = MatrizOrigen
        For i As Integer = 1 To TotalFilas
            If ElementoBuscado = Matriz(i, NumeroColumnaBuscada) Then Return i
        Next i
        Return 0
    End Function
    Public Function AgrandarMatriz(ByRef MatrizOrigen(,) As String, ByRef TotalFilas As Integer, ByVal TotalColumnas As Integer) As Integer
        Dim i, j, UltimoRegistro As Integer
        '
        If TotalFilas = 0 Then             'Esto aplica para cuando las Matrices no tienen datos.
            Dim AuxMatriz(,) As String
            ReDim AuxMatriz(1, TotalColumnas)
            For i = 0 To TotalFilas
                For j = 0 To TotalColumnas
                    AuxMatriz(i, j) = MatrizOrigen(i, j)
                Next j
            Next i
            '
            TotalFilas = 1
            MatrizOrigen = AuxMatriz
            Return 1
        End If
        '
        '
        '
        'Saca el ultimo registro libre para grabar.
        For i = TotalFilas To 1 Step -1
            If MatrizOrigen(i, 0) <> Nothing Then
                UltimoRegistro = i + 1
                Exit For
            End If
        Next i
        '
        '
        '
        If TotalFilas > UltimoRegistro Then
            'No es necesario agrandar la matriz
            Return UltimoRegistro
        Else
            Dim AuxMatriz(,) As String
            ReDim AuxMatriz(TotalFilas + 3, TotalColumnas)
            For i = 0 To TotalFilas
                For j = 0 To TotalColumnas
                    AuxMatriz(i, j) = MatrizOrigen(i, j)
                Next j
            Next i
            '
            TotalFilas += 1
            MatrizOrigen = AuxMatriz
            Return UltimoRegistro
        End If
    End Function
    '
    '
    '
End Module
'
'
'