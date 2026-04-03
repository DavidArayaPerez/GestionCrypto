'
'
'
Imports Microsoft.Graph.Drives.Item.Items.Item.Workbook
Imports Microsoft.SharePoint.Client

Public Class F_Monedas
    '
    '
    '
    Private Sub LimpiezaMoneda(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        L_Fila_Moneda.Text = ""
        'MONEDA
        T_Simbolo_Moneda.Text = ""
        T_NombreOficial_Moneda.Text = ""
        T_SlugAPI_Moneda.Text = ""
        T_TipoActivo_Moneda.Text = ""
        T_SubtipoStablecoin_Moneda.Text = ""
        T_MonedaParidad_Moneda.Text = ""
        T_Centralizada_Moneda.Text = ""
        T_ActivoSubyacente_Moneda.Text = ""
        T_MarketCapRank_Moneda.Text = ""
        T_SupplyMaximo_Moneda.Text = ""
        T_ContractAddress_Moneda.Text = ""
        T_IDredNativa_Moneda.Text = ""
        T_LinkCoinGeko.Text = ""
        rT_NotaMoneda.Text = ""
        '
        L_IDmoneda_Moneda.Text = ""
        L_IDdespliegue_Moneda.Text = ""
        '
        T_Simbolo_Moneda.Enabled = Habilitar
        T_NombreOficial_Moneda.Enabled = Habilitar
        T_SlugAPI_Moneda.Enabled = Habilitar
        T_TipoActivo_Moneda.Enabled = Habilitar
        T_SubtipoStablecoin_Moneda.Enabled = Habilitar
        T_MonedaParidad_Moneda.Enabled = Habilitar
        T_Centralizada_Moneda.Enabled = Habilitar
        T_ActivoSubyacente_Moneda.Enabled = Habilitar
        T_MarketCapRank_Moneda.Enabled = Habilitar
        T_SupplyMaximo_Moneda.Enabled = Habilitar
        T_ContractAddress_Moneda.Enabled = Habilitar
        T_IDredNativa_Moneda.Enabled = Habilitar
        T_LinkCoinGeko.Enabled = Habilitar
        rT_NotaMoneda.Enabled = Habilitar
        '
        B_Actualiza_Moneda.Enabled = Habilitar
        '
        L_CurentPrice.Text = ""
        L_Hight24h.Text = ""
        L_Low24h.Text = ""
        L_PriceChange24h.Text = ""
        L_PriceChangePor24h.Text = ""
        L_CirculatingSupply.Text = ""
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
        T_NombreOficial_Moneda.Text = Matriz_Monedas(F, 3)
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
        T_LinkCoinGeko.Text = "https://www.coingecko.com/es/monedas/" & T_SlugAPI_Moneda.Text
        '
        '
        Dim FilaRed As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Redes, Matriz_RedesTF, 0, T_IDredNativa_Moneda.Text)
        If FilaRed = 0 Then
            T_IDredNativa_Moneda.Text = ""
        Else
            T_IDredNativa_Moneda.Text = Matriz_Redes(FilaRed, 2)
        End If
        '
        Dim NombreNota As String = "Moneda" & T_Simbolo_Moneda.Text & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaMoneda)
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
        '   14      Link CoinGecko
        '
        Dim F As Integer = L_Fila_Moneda.Text
        If F = 0 Then Exit Sub

        Matriz_Monedas(F, 0) = L_IDmoneda_Moneda.Text
        Matriz_Monedas(F, 1) = L_IDdespliegue_Moneda.Text
        Matriz_Monedas(F, 2) = T_Simbolo_Moneda.Text
        Matriz_Monedas(F, 3) = T_NombreOficial_Moneda.Text
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
        Matriz_Monedas(F, 14) = T_LinkCoinGeko.Text
        '
        Guardar_Matrices("Monedas")
        '
        Dim NombreNota As String = "Moneda" & T_Simbolo_Moneda.Text & "_Nota.rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_NotaMoneda)
        '
        L_Mensaje.Text = "Moneda guardada correctamente"
    End Sub
    Private Sub ActualizaMoneda(SlugAPI As String, Fila As String)
        Dim current_price As String = ""
        Dim high_24h As String = ""
        Dim low_24h As String = ""
        Dim price_change_24h As String = ""
        Dim price_change_percentage_24h As String = ""
        Dim circulating_supply As String = ""
        '
        API_CoinGecko_ActualizaValor(SlugAPI, current_price, high_24h, low_24h, price_change_24h, price_change_percentage_24h, circulating_supply)
        '
        If Fila > 0 Then
            VerMoneda(Fila)
        Else
            Fila = BuscarCualquierValorEnCuaquierMatriz(Matriz_Monedas, Matriz_MonedasTF, 4, SlugAPI)
            If Fila > 0 Then
                VerMoneda(Fila)
            Else
                LimpiezaMoneda()
                L_Mensaje.Text = "Moneda no encontrada en la Matriz, revise el Slug API ingresado"
                Exit Sub
            End If
        End If
        '
        L_CurentPrice.Text = FormatoChileno(current_price, 6)
        L_Hight24h.Text = FormatoChileno(high_24h, 6)
        L_Low24h.Text = FormatoChileno(low_24h, 6)
        L_PriceChange24h.Text = FormatoChileno(price_change_24h)
        L_PriceChangePor24h.Text = FormatoChileno(price_change_percentage_24h, 0) & " %"
        L_CirculatingSupply.Text = FormatoChileno(circulating_supply, 0)
        '
        L_Mensaje.Text = "Moneda Actualizada y Guardada correctamente"
    End Sub











    '
    '
    '
    Private Sub F_Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReCarga_Monedas()
    End Sub
    Private Sub ReCarga_Monedas()
        LimpiezaMoneda()
        '
        L_TotalMonedas.Text = Matriz_MonedasTF - 1
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
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub L_Monedas_Click(sender As Object, e As EventArgs) Handles L_Monedas.Click
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Monedas.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerMoneda(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub L_Monedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Monedas.SelectedIndexChanged
        '
    End Sub
    Private Sub B_NuevoMoneda_Click_1(sender As Object, e As EventArgs) Handles B_NuevoMoneda.Click
        Dim T As String = "Ingrese el acronimo de la moneda" & vbCrLf & "Ejemplo: USDT, BTC, ETH, USDT, MATIC,  etc"
        Dim Acronimo As String = UCase(InputBox(T, "Nueva Moneda")).ToLower
        '
        LimpiezaMoneda()
        Dim Fila As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Monedas, Matriz_MonedasTF, 2, Acronimo)
        If Fila > 0 Then
            VerMoneda(Fila)
        Else
            ActualizaMoneda(Acronimo, "0")
        End If
    End Sub
    Private Sub B_GrabarMoneda_Click_1(sender As Object, e As EventArgs) Handles B_GrabarMoneda.Click
        GrabarMoneda()
    End Sub
    Private Sub B_Actualizar_Monedas_Click_1(sender As Object, e As EventArgs) Handles B_ActualizaTODO_Monedas.Click
        ActualizarMonedas()
        ReCarga_Monedas()
    End Sub
    Private Sub B_Actualiza_Moneda_Click(sender As Object, e As EventArgs) Handles B_Actualiza_Moneda.Click
        ActualizaMoneda(T_SlugAPI_Moneda.Text, L_Fila_Moneda.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_LinkCoinGeko.Text) < 3 Then Exit Sub
        '
        Dim URL As String = T_LinkCoinGeko.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
End Class