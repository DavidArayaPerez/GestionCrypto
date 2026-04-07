'
'
'
Module mTraspasos
    '
    '
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
        Matriz_Traspasos(Fila, 11) = ""
        Return Fila
    End Function
    Public Sub LlenarList_Traspasos(ByRef Lista As ListBox)
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_TraspasosTF
            '   1 Fecha   2 Hora   3 Plataforma   4 BilleteraOrigen   7 BilleteraDestino
            Dim T As String = Matriz_Traspasos(i, 1) & " " & Matriz_Traspasos(i, 2) & " - " & Matriz_Traspasos(i, 3) & " - " & Matriz_Traspasos(i, 4) & " → " & Matriz_Traspasos(i, 7)
            Lista.Items.Add(T)
        Next i
    End Sub
    Public Function BuscarTraspasos(ByVal Clave As String) As Integer
        If Clave = Nothing OrElse Clave = "" Then Return 0
        For i As Integer = 1 To Matriz_TraspasosTF
            Dim T As String = Matriz_Traspasos(i, 1) & " " & Matriz_Traspasos(i, 2) & " - " & Matriz_Traspasos(i, 3) & " - " & Matriz_Traspasos(i, 4) & " → " & Matriz_Traspasos(i, 7)
            If Clave = T Then Return i
        Next i
        Return 0
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
    '
    '
    '
End Module
