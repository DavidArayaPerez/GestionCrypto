'
'
'
Module mMonedas
    '
    '
    '


    Public Function ExisteMoneda_Simbolo(T As String) As String
        For i As Integer = 1 To Matriz_MonedasTF
            If T = Matriz_Monedas(i, 2) Then Return True 'Si existe
        Next i
        Return False 'No existe
    End Function
    Public Function BuscarMoneda_Simbolo(T As String) As Integer
        If T = Nothing Then Return 0
        If T = "" Then Return 0
        '
        For i As Integer = 1 To Matriz_MonedasTF
            If T = Matriz_Monedas(i, 2) Then Return i
        Next i
        Return 0
    End Function

    Public Sub Llenar_Monedas(ByRef Combo As ComboBox)
        Dim T As String
        Combo.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2)
            Combo.Items.Add(T)
        Next i
    End Sub
    Public Sub LlenarList_Monedas(ByRef Lista As ListBox)
        Dim Contador As Integer = 0
        Dim T As String
        Lista.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2)
            Lista.Items.Add(T)
            If Matriz_Monedas(i, 22) = "S" Then
                If Contador < 50 Then
                    API_CoinGecko_ActualizaValor(Matriz_Monedas(i, 4))
                    Contador += 1
                End If
            End If
        Next i
    End Sub
    '
    '
    '
End Module
