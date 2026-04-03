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

        Dim T As String
        For i As Integer = Matriz_ValorUSDTF To 1 Step -1
            T = Matriz_ValorUSD(i, 0) & " = " & Matriz_ValorUSD(i, 1) & " (" & i & ")"
            L_Dolar.Items.Add(T)
        Next i
        '   0   Fecha
        '   1   Valor
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