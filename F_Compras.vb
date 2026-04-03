'
'
'
Public Class F_Compras
    '
    '
    '
    Private Sub Inicializar()
        Dim T As String
        VariableDeInicio = True
        '
        Limpiar()
        '
        C_Exchange.Items.Clear()
        For i As Integer = 1 To Matriz_ExchangeTF
            T = Matriz_Exchange(i, 0) & " " & "(" & i & ")"
            C_Exchange.Items.Add(T)
        Next i
        '
        C_MonedaOrigen.Items.Clear()
        C_MonedaDestino.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
            C_MonedaOrigen.Items.Add(T)
            C_MonedaDestino.Items.Add(T)
        Next i
        '
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        L_PrecioMonedaCompra.Text = ""
        'COMPRAS
        T_FechaCompra.Text = ""
        T_HoraCompra.Text = ""
        C_MonedaOrigen.Text = ""
        C_MonedaDestino.Text = ""
        T_ValorOrigenCompra.Text = ""
        T_ValorDestinoCompra.Text = ""
        C_Exchange.Text = ""
        T_ComisionCompra.Text = ""
        T_GasCompra.Text = ""
        rT_NotaCompra.Text = ""
        '
        T_FechaCompra.Enabled = Habilitar
        T_HoraCompra.Enabled = Habilitar
        C_MonedaOrigen.Enabled = Habilitar
        C_MonedaDestino.Enabled = Habilitar
        T_ValorOrigenCompra.Enabled = Habilitar
        T_ValorDestinoCompra.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        T_ComisionCompra.Enabled = Habilitar
        T_GasCompra.Enabled = Habilitar
        rT_NotaCompra.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpiar(True)
        If F < 1 Then Exit Sub
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Moneda_Origen
        '   5   Valor_Origen
        '   6   Moneda_Destino
        '   7   Valor_Destino
        '   8   Comision
        '   9   Gas
        '   10  Precio
        '
        T_FechaCompra.Text = Matriz_Compras(F, 1)
        T_HoraCompra.Text = Matriz_Compras(F, 2)
        C_Exchange.Text = Matriz_Compras(F, 3)
        C_MonedaOrigen.Text = Matriz_Compras(F, 4)
        T_ValorOrigenCompra.Text = Matriz_Compras(F, 5)
        C_MonedaDestino.Text = Matriz_Compras(F, 6)
        T_ValorDestinoCompra.Text = Matriz_Compras(F, 7)
        T_ComisionCompra.Text = Matriz_Compras(F, 8)
        T_GasCompra.Text = Matriz_Compras(F, 9)
        L_PrecioMonedaCompra.Text = Matriz_Compras(F, 10)
        '
        'Dim NombreNota As String = T_FechaCompra.Text & "_" & T_HoraCompra.Text & "_" & "Compras" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaCompra)
    End Sub



























    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub F_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_NuevoBilletera.Click
        Limpiar(True)
    End Sub

    Private Sub B_GrabarCompra_Click(sender As Object, e As EventArgs) Handles B_GrabarCompra.Click
        grabar
    End Sub

    '
    '
    '
End Class