'
'
'
Public Class F_Dolar
    '
    '
    '
    Private Sub F_Dolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GuardarValorUSD(2022)  GuardarValorUSD(2023)   GuardarValorUSD(2024)   GuardarValorUSD(2025)
        GuardarValorUSD(2026)
        CargarTXT("ValorUSD", Matriz_ValorUSD)
        '
        Dim T As String
        Dim Vector As New List(Of String)
        For i As Integer = 1 To Matriz_ValorUSDTF
            T = Matriz_ValorUSD(i, 0) & " = " & Matriz_ValorUSD(i, 1) & " (" & i & ")"
            Vector.Add(T)
        Next i
        '
        ' Ordenar descendente (mas reciente primero)
        Vector.Sort()
        Vector.Reverse()
        '
        L_Dolar.Items.Clear()
        For Each v As String In Vector
            L_Dolar.Items.Add(v)
        Next

    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

End Class