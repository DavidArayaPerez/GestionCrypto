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
        'Devuelve la posicion
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
            ReDim AuxMatriz(TotalFilas + 3, TotalColumnas)
            For i = 0 To TotalFilas
                For j = 0 To TotalColumnas
                    AuxMatriz(i, j) = MatrizOrigen(i, j)
                Next j
            Next i
            '
            TotalFilas += 3
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
            TotalFilas += 3
            MatrizOrigen = AuxMatriz
            Return UltimoRegistro
        End If
    End Function
    Public Sub BuscaAgrega_Arreglo(ByRef Arreglo() As String, ByRef LargoArreglo As Integer, ByVal TextoBuscado As String)
        If LargoArreglo = -1 Then
            Arreglo(0) = TextoBuscado
            LargoArreglo += 1
            Exit Sub
        End If
        '
        '
        Dim SW As Boolean = True
        For i As Integer = 0 To LargoArreglo
            If TextoBuscado = Arreglo(i) Then
                SW = False
                Exit For
            End If
        Next i
        '
        If SW Then
            LargoArreglo += 1
            ReDim Preserve Arreglo(LargoArreglo)
            Arreglo(LargoArreglo) = TextoBuscado
        End If
    End Sub
    Public Sub Ordenar_Arreglo(ByRef Arreglo() As String, ByRef LargoArreglo As Integer)
        For i As Integer = 0 To LargoArreglo
            For j As Integer = 0 To LargoArreglo
                If Arreglo(i) < Arreglo(j) Then
                    Dim T As String = Arreglo(i)
                    Arreglo(i) = Arreglo(j)
                    Arreglo(j) = T
                End If
            Next j
        Next i
    End Sub
    '
    '
    '
End Module
'
'
'