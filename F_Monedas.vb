'
'
'
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook

Public Class F_Monedas
    '
    '
    '
    Private Sub LimpiezaMoneda(Optional Habilitar As Boolean = False)
        'MONEDA
        L_IDmoneda_Moneda.Text = ""
        L_IDdespliegue_Moneda.Text = ""
        T_Simbolo_Moneda.Text = ""
        T_AcronimoMoneda.Text = ""
        T_SlugAPI_Moneda.Text = ""
        T_TipoActivo_Moneda.Text = ""
        T_SubtipoStablecoin_Moneda.Text = ""
        T_MonedaParidad_Moneda.Text = ""
        T_Centralizada_Moneda.Text = ""
        T_ActivoSubyacente_Moneda.Text = ""
        T_IDredNativa_Moneda.Text = ""
        T_SupplyMaximo_Moneda.Text = ""
        T_ContractAddress_Moneda.Text = ""
        T_MarketCapRank_Moneda.Text = ""
        rT_NotaMoneda.Text = ""
        L_Fila_Moneda.Text = ""
        '
        L_IDmoneda_Moneda.Enabled = Habilitar
        L_IDdespliegue_Moneda.Enabled = Habilitar
        T_Simbolo_Moneda.Enabled = Habilitar
        T_AcronimoMoneda.Enabled = Habilitar
        T_SlugAPI_Moneda.Enabled = Habilitar
        T_TipoActivo_Moneda.Enabled = Habilitar
        T_SubtipoStablecoin_Moneda.Enabled = Habilitar
        T_MonedaParidad_Moneda.Enabled = Habilitar
        T_Centralizada_Moneda.Enabled = Habilitar
        T_ActivoSubyacente_Moneda.Enabled = Habilitar
        T_IDredNativa_Moneda.Enabled = Habilitar
        T_SupplyMaximo_Moneda.Enabled = Habilitar
        T_ContractAddress_Moneda.Enabled = Habilitar
        T_MarketCapRank_Moneda.Enabled = Habilitar
        'T_Busqueda_Monedas.Enabled = Habilitar
        rT_NotaMoneda.Enabled = Habilitar
    End Sub
    Private Sub VerMoneda(F As Integer)
        LimpiezaMoneda(True)
        If F < 1 Then Exit Sub
        '   0       ID_Moneda
        '   1       ID_Despliegue
        '   2       Simbolo
        '   3       Nombre_Oficial
        '   4       Slug_API
        '   5       Tipo_Activo
        '   6       Subtipo_Stablecoin      solo para stablecoins: fiat, crypto, algoritmica (DAI es crypto-backed, USDT es fiat, etc.)
        '   7       Moneda_Paridad
        '   8       Centralizada
        '   9       Activo_Subyacente       solo para wrapped: WBTC → BTC, WETH → ETH
        '   10      ID_Red                  Es el ID de la Matriz_Red
        '   11      Supply_Maximo
        '   12      Contract_Address
        '   13     market_cap_rank
        '
        L_Fila_Moneda.Text = F
        L_IDmoneda_Moneda.Text = Matriz_Monedas(F, 0)
        L_IDdespliegue_Moneda.Text = Matriz_Monedas(F, 1)
        T_Simbolo_Moneda.Text = Matriz_Monedas(F, 2)
        T_AcronimoMoneda.Text = Matriz_Monedas(F, 3)
        T_SlugAPI_Moneda.Text = Matriz_Monedas(F, 4)
        T_TipoActivo_Moneda.Text = Matriz_Monedas(F, 5)
        T_SubtipoStablecoin_Moneda.Text = Matriz_Monedas(F, 6)
        T_MonedaParidad_Moneda.Text = Matriz_Monedas(F, 7)
        T_Centralizada_Moneda.Text = Matriz_Monedas(F, 8)
        T_ActivoSubyacente_Moneda.Text = Matriz_Monedas(F, 9)
        T_IDredNativa_Moneda.Text = Matriz_Monedas(F, 10)       'xxxx
        T_SupplyMaximo_Moneda.Text = Matriz_Monedas(F, 11)
        T_ContractAddress_Moneda.Text = Matriz_Monedas(F, 12)
        T_MarketCapRank_Moneda.Text = Matriz_Monedas(F, 13)
        '
        '
        Dim FilaRed As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Redes, Matriz_RedesTF, 0, T_IDredNativa_Moneda.Text)
        If FilaRed = 0 Then
            T_IDredNativa_Moneda.Text = ""
        Else
            T_IDredNativa_Moneda.Text = Matriz_Redes(FilaRed, 2)
        End If
        '
        'Dim NombreNota As String = "Moneda" & T_AcronimoMoneda.Text & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub
    Private Sub GrabarMoneda()
        '   0       ID_Moneda
        '   1       ID_Despliegue
        '   2       Simbolo
        '   3       Nombre_Oficial
        '   4       Slug_API
        '   5       Tipo_Activo
        '   6       Subtipo_Stablecoin      solo para stablecoins: fiat, crypto, algoritmica (DAI es crypto-backed, USDT es fiat, etc.)
        '   7       Moneda_Paridad
        '   8       Centralizada
        '   9       Activo_Subyacente       solo para wrapped: WBTC → BTC, WETH → ETH
        '   10      ID_Red                  Es el ID de la Matriz_Red
        '   11      Supply_Maximo
        '   12      Contract_Address
        '   13     market_cap_rank
        '
        Dim F As Integer = L_Fila_Moneda.Text
        If F = 0 Then Exit Sub

        Matriz_Monedas(F, 0) = L_IDmoneda_Moneda.Text
        Matriz_Monedas(F, 1) = L_IDdespliegue_Moneda.Text
        Matriz_Monedas(F, 2) = T_Simbolo_Moneda.Text
        Matriz_Monedas(F, 3) = T_AcronimoMoneda.Text
        Matriz_Monedas(F, 4) = T_SlugAPI_Moneda.Text
        Matriz_Monedas(F, 5) = T_TipoActivo_Moneda.Text
        Matriz_Monedas(F, 6) = T_SubtipoStablecoin_Moneda.Text
        Matriz_Monedas(F, 7) = T_MonedaParidad_Moneda.Text
        Matriz_Monedas(F, 8) = T_Centralizada_Moneda.Text
        Matriz_Monedas(F, 9) = T_ActivoSubyacente_Moneda.Text
        Matriz_Monedas(F, 10) = T_IDredNativa_Moneda.Text
        Matriz_Monedas(F, 11) = T_SupplyMaximo_Moneda.Text
        Matriz_Monedas(F, 12) = T_ContractAddress_Moneda.Text
        Matriz_Monedas(F, 13) = T_MarketCapRank_Moneda.Text
        '
        '
        Guardar_Matrices("Monedas")
        MsgBox("Moneda guardada correctamente")
        'Dim NombreNota As String = "Moneda" & T_AcronimoMoneda.Text & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
    End Sub









    Private Sub F_Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LimpiezaMoneda()
        '
        L_Monedas.Items.Clear()
        Dim T As String
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
            L_Monedas.Items.Add(T)
        Next i
        T_Busqueda_Monedas.Text = ""

    End Sub

    Private Sub T_Busqueda_Monedas_KeyUp(sender As Object, e As KeyEventArgs) Handles T_Busqueda_Monedas.KeyUp
        If VariableDeInicio Then Exit Sub
        Dim Filtro As String = T_Busqueda_Monedas.Text.Trim().ToUpper()
        L_Monedas.Items.Clear()
        For i As Integer = 1 To Matriz_MonedasTF
            Dim Simbolo As String = Matriz_Monedas(i, 2).ToString().ToUpper()
            If Filtro = "" OrElse Simbolo.StartsWith(Filtro) Then
                Dim T As String = Matriz_Monedas(i, 3) & " (" & i & ")"
                L_Monedas.Items.Add(T)
            End If
        Next
    End Sub
    Private Sub T_Busqueda_Monedas_TextChanged(sender As Object, e As EventArgs) Handles T_Busqueda_Monedas.TextChanged

    End Sub
    Private Sub B_GrabarMoneda_Click(sender As Object, e As EventArgs)
        GrabarMoneda()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub B_Actualizar_Monedas_Click(sender As Object, e As EventArgs)
        ActualizarMonedas()
        OrdenarMatriz_Monedas()
        Guardar_Matrices("Monedas")
    End Sub
    Private Sub L_Monedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Monedas.SelectedIndexChanged
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Monedas.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerMoneda(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub B_NuevoMoneda_Click_1(sender As Object, e As EventArgs) Handles B_NuevoMoneda.Click
        Dim T As String = "Ingrese el acronimo de la moneda" & vbCrLf & "Ejemplo: USDT, BTC, ETH, USDT, MATIC,  etc"
        Dim Acronimo As String = InputBox(T, "Nueva Moneda")
        '
        Dim Fila As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Monedas, Matriz_MonedasTF, 2, Acronimo)
        If Fila > 0 Then VerMoneda(Fila)
    End Sub


End Class