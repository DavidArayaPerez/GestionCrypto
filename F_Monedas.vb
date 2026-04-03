'
'
'
Public Class F_Monedas
    '
    '
    '
    Private Sub ReCarga_Monedas()
        LimpiezaMoneda()
        '
        L_TotalMonedas.Text = Matriz_MonedasTF - 1
        L_Monedas.Items.Clear()
        Dim T As String
        Dim Contador As Integer = 0
        For i As Integer = 1 To Matriz_MonedasTF
            T = Matriz_Monedas(i, 2) & " " & "(" & i & ")"
            L_Monedas.Items.Add(T)
            If Matriz_Monedas(i, 22) = "S" Then
                If Contador < 50 Then
                    API_CoinGecko_ActualizaValor(Matriz_Monedas(i, 4))
                    Contador += 1
                End If
            End If
        Next i
        T_Busqueda_Monedas.Text = ""
    End Sub
    Private Sub LimpiezaMoneda(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        L_Fila_Moneda.Text = ""
        'MONEDA
        T_ContractAddress_Moneda.Text = ""
        '
        L_Simbolo_Moneda.Text = ""
        L_NombreOficial_Moneda.Text = ""
        L_SlugAPI_Moneda.Text = ""
        L_TipoActivo_Moneda.Text = ""
        L_SubtipoStablecoin_Moneda.Text = ""
        L_MarketCapRank_Moneda.Text = ""
        L_IDredNativa_Moneda.Text = ""
        T_LinkCoinGeko.Text = ""
        L_CurentPrice.Text = ""
        L_Hight24h.Text = ""
        L_Low24h.Text = ""
        L_PriceChange24h.Text = ""
        L_PriceChangePor24h.Text = ""
        L_CirculatingSupply.Text = ""
        L_FechaActualizacion.Text = ""
        '
        CB_ActualizacionAutomatica.Checked = False
        rT_NotaMoneda.Text = ""
        '
        L_IDmoneda_Moneda.Text = ""
        L_IDdespliegue_Moneda.Text = ""
        '
        CB_ActualizacionAutomatica.Enabled = Habilitar
        rT_NotaMoneda.Enabled = Habilitar
        B_Actualiza_Moneda.Enabled = Habilitar
    End Sub
    Private Sub VerMoneda(F As Integer)
        LimpiezaMoneda(True)
        If F < 1 Then Exit Sub
        '
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
        '   13      market_cap_rank
        '   14      Link CoinGecko
        '   15      Current_Price
        '   16      Hight24h
        '   17      Low24h
        '   18      Price Change 24h
        '   19      Price Change Percentage 24h
        '   20      Circulating Supply
        '   21      Fecha Actualizacion
        '   22      Actualizacion Automatica (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
        '
        L_Fila_Moneda.Text = F
        L_IDmoneda_Moneda.Text = Matriz_Monedas(F, 0)
        L_IDdespliegue_Moneda.Text = Matriz_Monedas(F, 1)
        L_Simbolo_Moneda.Text = Matriz_Monedas(F, 2)
        L_NombreOficial_Moneda.Text = Matriz_Monedas(F, 3)
        L_SlugAPI_Moneda.Text = Matriz_Monedas(F, 4)
        L_TipoActivo_Moneda.Text = Matriz_Monedas(F, 5)
        L_SubtipoStablecoin_Moneda.Text = Matriz_Monedas(F, 6)
        '   7       Moneda_Paridad
        '   8       Centralizada
        '   9       Activo_Subyacente       solo para wrapped: WBTC → BTC, WETH → ETH
        L_IDredNativa_Moneda.Text = Matriz_Monedas(F, 10)       'xxxx
        '   11      Supply_Maximo
        T_ContractAddress_Moneda.Text = Matriz_Monedas(F, 12)
        L_MarketCapRank_Moneda.Text = Matriz_Monedas(F, 13)
        T_LinkCoinGeko.Text = "https://www.coingecko.com/es/monedas/" & L_SlugAPI_Moneda.Text
        L_CurentPrice.Text = FormatoChileno(Matriz_Monedas(F, 15), 6)
        L_Hight24h.Text = FormatoChileno(Matriz_Monedas(F, 16), 6)
        L_Low24h.Text = FormatoChileno(Matriz_Monedas(F, 17), 6)
        L_PriceChange24h.Text = FormatoChileno(Matriz_Monedas(F, 18))
        L_PriceChangePor24h.Text = FormatoChileno(Matriz_Monedas(F, 19), 0) & " %"
        L_CirculatingSupply.Text = FormatoChileno(Matriz_Monedas(F, 20), 0)
        L_FechaActualizacion.Text = ConvertirFechaUTCaChile(Matriz_Monedas(F, 21))
        If Matriz_Monedas(F, 22) = "S" Then
            CB_ActualizacionAutomatica.Checked = True
        Else
            CB_ActualizacionAutomatica.Checked = False
        End If
        '
        '
        Dim FilaRed As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Redes, Matriz_RedesTF, 0, L_IDredNativa_Moneda.Text)
        If FilaRed > 0 Then L_IDredNativa_Moneda.Text = Matriz_Redes(FilaRed, 2)
        '
        Dim NombreNota As String = "Moneda" & L_Simbolo_Moneda.Text & "_Nota.rtf"
        CargaRTF(RutaLocal, NombreNota, rT_NotaMoneda)
    End Sub
    Private Sub GrabarMoneda()
        Dim F As Integer = L_Fila_Moneda.Text
        If F = 0 Then Exit Sub

        'Matriz_Monedas(F, 0) = L_IDmoneda_Moneda.Text
        'Matriz_Monedas(F, 1) = L_IDdespliegue_Moneda.Text
        'Matriz_Monedas(F, 2) = T_Simbolo_Moneda.Text
        'Matriz_Monedas(F, 3) = T_NombreOficial_Moneda.Text
        'Matriz_Monedas(F, 4) = T_SlugAPI_Moneda.Text
        'Matriz_Monedas(F, 5) = T_TipoActivo_Moneda.Text
        'Matriz_Monedas(F, 6) = T_SubtipoStablecoin_Moneda.Text
        'Matriz_Monedas(F, 7) = 
        'Matriz_Monedas(F, 8) = 
        'Matriz_Monedas(F, 9) = 
        'Matriz_Monedas(F, 10) = T_IDredNativa_Moneda.Text
        'Matriz_Monedas(F, 11) = 
        'Matriz_Monedas(F, 12) = T_ContractAddress_Moneda.Text
        'Matriz_Monedas(F, 13) = T_MarketCapRank_Moneda.Text
        'Matriz_Monedas(F, 14) = T_LinkCoinGeko.Text
        'Matriz_Monedas(F, 15) = T_TipoActivo_Moneda.Text
        'Matriz_Monedas(F, 16) = T_SubtipoStablecoin_Moneda.Text
        'Matriz_Monedas(F, 17) = 
        'Matriz_Monedas(F, 18) = 
        'Matriz_Monedas(F, 19) = 
        'Matriz_Monedas(F, 20) =
        'Matriz_Monedas(F, 21) = 
        '
        If CB_ActualizacionAutomatica.Checked = True Then
            Matriz_Monedas(F, 22) = "S"
        Else
            Matriz_Monedas(F, 22) = "N"
        End If
        '
        Guardar_Matrices("Monedas")
        '
        Dim NombreNota As String = "Moneda" & L_Simbolo_Moneda.Text & "_Nota.rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_NotaMoneda)
        '
        L_Mensaje.Text = "Moneda guardada correctamente"
    End Sub
    Private Sub CreaNuevaMoneda()
        LimpiezaMoneda()
        '
        Dim T As String = "Ingrese el nombre de la moneda, de acuerdo al estandar de COINGEKO (minusculas)" & vbCrLf & "Ejemplo: bitcoin, tether, ripple, tron"
        Dim Acronimo As String = UCase(InputBox(T, "Nueva Moneda")).ToLower
        Dim Fila As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Monedas, Matriz_MonedasTF, 2, Acronimo)
        If Fila > 0 Then
            MsgBox("La Moneda ya existe en la Matriz, se mostrará la moneda existente", vbInformation)
            VerMoneda(Fila)
            Exit Sub
        End If
        '
        VerMoneda(API_CoinGecko_NuevaMoneda(Acronimo))
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    '
    Private Sub F_Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReCarga_Monedas()
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
        CreaNuevaMoneda()
    End Sub
    Private Sub B_GrabarMoneda_Click_1(sender As Object, e As EventArgs) Handles B_GrabarMoneda.Click
        GrabarMoneda()
    End Sub
    Private Sub B_Actualizar_Monedas_Click_1(sender As Object, e As EventArgs) Handles B_ActualizaTODO_Monedas.Click
        Me.Enabled = False
        ActualizarMonedas()
        ReCarga_Monedas()
        Me.Enabled = True
    End Sub
    Private Sub B_Actualiza_Moneda_Click(sender As Object, e As EventArgs) Handles B_Actualiza_Moneda.Click
        API_CoinGecko_ActualizaValor(L_SlugAPI_Moneda.Text)
        VerMoneda(L_Fila_Moneda.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_LinkCoinGeko.Text) < 3 Then Exit Sub
        '
        Dim URL As String = T_LinkCoinGeko.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
End Class