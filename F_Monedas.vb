'
'
'
Imports Microsoft.Graph.Admin
'
'
'
Public Class F_Monedas
    '
    '
    '
    Private Sub Inicializar()
        Limpiar()
        LlenarList_Monedas(L_Monedas)
        L_TotalMonedas.Text = Matriz_MonedasTF - 1
        T_Busqueda_Monedas.Text = ""
        '
        'For i As Integer = 1 To Matriz_MonedasTF
        '    If Matriz_Monedas(i, 23) = "0" Then
        '        Matriz_Monedas(i, 23) = "CryptoMoneda"
        '        Guardar_Matrices("Monedas")
        '    End If
        'Next i
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        L_Fila.Text = ""
        'MONEDA
        C_TipoMoneda.Text = "CryptoMoneda"
        T_SlugAPI.Text = ""
        T_ContractAddres.Text = ""
        T_Simbolo.Text = ""
        '
        L_NombreOficial.Text = ""
        L_TipoActivo.Text = ""
        L_SubtipoStablecoin.Text = ""
        L_MarketCapRank.Text = ""
        L_IDredNativa.Text = ""
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
        rT_Nota.Text = ""
        '
        L_IDmoneda.Text = ""
        L_IDdespliegue.Text = ""
        '
        C_TipoMoneda.Enabled = False
        T_SlugAPI.Enabled = Habilitar
        T_Simbolo.Enabled = Habilitar
        CB_ActualizacionAutomatica.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        B_Actualiza_Moneda.Enabled = Habilitar
    End Sub
    Private Sub Ver(Simbolo As String)
        Limpiar(True)
        Dim F As Integer = BuscarMoneda_Simbolo(Simbolo)
        If F < 1 Then Exit Sub
        '
        CB_ActualizacionAutomatica.Checked = False
        '
        L_Fila.Text = F
        L_IDmoneda.Text = Matriz_Monedas(F, 0)
        L_IDdespliegue.Text = Matriz_Monedas(F, 1)
        T_Simbolo.Text = Matriz_Monedas(F, 2)
        L_NombreOficial.Text = Matriz_Monedas(F, 3)
        T_SlugAPI.Text = Matriz_Monedas(F, 4)
        L_TipoActivo.Text = Matriz_Monedas(F, 5)
        L_SubtipoStablecoin.Text = Matriz_Monedas(F, 6)
        '   7       Moneda_Paridad
        '   8       Centralizada
        '   9       Activo_Subyacente       solo para wrapped: WBTC → BTC, WETH → ETH
        L_IDredNativa.Text = Matriz_Monedas(F, 10)       'xxxx
        '   11      Supply_Maximo
        T_ContractAddres.Text = Matriz_Monedas(F, 12)
        L_MarketCapRank.Text = Matriz_Monedas(F, 13)
        T_LinkCoinGeko.Text = "https://www.coingecko.com/es/monedas/" & T_Simbolo.Text
        L_CurentPrice.Text = FormatoChileno(Matriz_Monedas(F, 15), 6)
        L_Hight24h.Text = FormatoChileno(Matriz_Monedas(F, 16), 6)
        L_Low24h.Text = FormatoChileno(Matriz_Monedas(F, 17), 6)
        L_PriceChange24h.Text = FormatoChileno(Matriz_Monedas(F, 18))
        L_PriceChangePor24h.Text = FormatoChileno(Matriz_Monedas(F, 19), 0) & " %"
        L_CirculatingSupply.Text = FormatoChileno(Matriz_Monedas(F, 20), 0)
        L_FechaActualizacion.Text = ConvertirFechaUTCaChile(Matriz_Monedas(F, 21))
        If Matriz_Monedas(F, 22) = "S" Then CB_ActualizacionAutomatica.Checked = True
        C_TipoMoneda.Text = Matriz_Monedas(F, 23)
        '
        '
        Dim FilaRed As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_Redes, Matriz_RedesTF, 0, L_IDredNativa.Text)
        If FilaRed > 0 Then L_IDredNativa.Text = Matriz_Redes(FilaRed, 2)
        '
        Dim NombreNota As String = "Curr_" & T_SlugAPI.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
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
        '   18      Price_Change_24h
        '   19      Price_Change_Percentage_24h
        '   20      Circulating_Supply
        '   21      Fecha_Actualizacion
        '   22      Actualizacion_Automatica        (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
        '   23      Tipo_Moneda                     Moneda / CryptoMoneda
    End Sub
    Private Function DatosNoValidos() As Boolean
        C_TipoMoneda.Text = Trim(C_TipoMoneda.Text)
        T_SlugAPI.Text = Trim(T_SlugAPI.Text)
        T_Simbolo.Text = Trim(T_Simbolo.Text.ToUpper)
        If Len(T_Simbolo.Text) < 3 Then L_Mensaje.Text = "El simbolo no puede tener menos de 3 letras" : Return True
        If Len(T_SlugAPI.Text) < 3 Then L_Mensaje.Text = "SlugAPI no puede tener menos de 3 letras" : Return True
        '
        If C_TipoMoneda.Text = "Moneda" Or C_TipoMoneda.Text = "CryptoMoneda" Then
            'Es correcto Return False
        Else
            L_Mensaje.Text = "Tipo Moneda no válida"
            Return True
        End If
        Return False
    End Function
    Private Function PreGrabar() As Boolean
        Dim F1 As Integer = L_Fila.Text
        Dim Cambios As Integer = 0
        '
        If T_Simbolo.Text = Matriz_Monedas(F1, 2) Then Cambios = 1
        If T_SlugAPI.Text = Matriz_Monedas(F1, 4) Then Cambios = 2
        '
        If C_TipoMoneda.Text = "CryptoMoneda" Then
            'Se esta grabando una CryptoMoneda
            If F1 > 0 Then
                'Se esta grabando una CryptoMoneda. MONEDA ANTIGUA.
                If Cambios > 1 Then
                    'Se esta grabando una CryptoMoneda. MONEDA ANTIGUA. Y se estan modificando el TipoMoneda o Slug
                    If Cambios = 1 Then MsgBox("No puede cambiar el simbolo", vbCritical)
                    If Cambios = 2 Then MsgBox("No puede cambiar el tipo Slug", vbCritical)
                    Return True
                Else
                    'Se esta grabando una CryptoMoneda. MONEDA ANTIGUA. Pero NO se esta modificando el TipoMoneda o Slug
                    'Asi que tiene el pase de grabar
                    Return False
                End If
            Else
                'Se esta grabando una CryptoMoneda. NUEVA MONEDA.
                Dim F2 As Integer = BuscarMoneda_Simbolo(T_Simbolo.Text) 'Se busca la moneda para saber si ya existe
                If F2 > 0 Then
                    'Se esta grabando una CryptoMoneda. NUEVA MONEDA. Pero ya existe en la matriz
                    MsgBox("La moneda ya existe", vbCritical)
                    Ver(T_Simbolo.Text)
                    Return True
                Else
                    'Se esta grabando una CryptoMoneda. NUEVA MONEDA. NO existe en la matriz.
                    If API_CoinGecko_NuevaMoneda(T_SlugAPI.Text) Then
                        'Se esta grabando una CryptoMoneda. NUEVA MONEDA. NO existe en la matriz. Pero si se encontro en CoinGeko.
                        'el procedimiento ya lo encontro y grabo los datos
                        Ver(T_Simbolo.Text)
                        'Como ya se grabo no es necesario volverlo a grabar
                        Return True
                    Else
                        'Se esta grabando una CryptoMoneda. NUEVA MONEDA. NO existe en la matriz. NO se encontro en CoinGeko.
                        Return True
                    End If
                End If
                End If
        Else
            'Se esta grabando una MONEDA REAL.
            'Por ende se validan menos datos, una moneda real es CLP (peso chileno), USD (dolar americano)
            'Tambien se setea la actualizacion automatica porque no aplica, esto solo se utiliza para las Crypto
            CB_ActualizacionAutomatica.Checked = False
            If F1 > 0 Then
                'Se esta grabando una MONEDA REAL. MONEDA ANTIGUA.
                If ExisteMoneda_Simbolo(T_Simbolo.Text) Then
                    'Se esta grabando una MONEDA REAL. MONEDA ANTIGUA. Ya existe, asi que se vuelve a cargar
                    Ver(T_Simbolo.Text)
                    Return True
                Else
                    'Se esta grabando una MONEDA REAL. MONEDA ANTIGUA. NO existe
                    L_Fila.Text = AgrandarMatriz(Matriz_Monedas, Matriz_MonedasTF, Matriz_MonedasTC)
                    Return False
                End If
            Else
                'Se esta grabando una MONEDA REAL. NUEVA MONEDA. 
                If ExisteMoneda_Simbolo(T_Simbolo.Text) Then
                    'Se esta grabando una MONEDA REAL. NUEVA MONEDA. Ya existe, asi que se vuelve a cargar
                    Ver(T_Simbolo.Text)
                    Return False
                Else
                    'Se esta grabando una MONEDA REAL. NUEVA MONEDA. NO existe
                    Return False
                End If
            End If
        End If
    End Function


    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        If PreGrabar() Then Exit Sub
        '
        If CB_ActualizacionAutomatica.Checked = True Then
            Matriz_Monedas(L_Fila.Text, 22) = "S"
        Else
            Matriz_Monedas(L_Fila.Text, 22) = "N"
        End If
        Guardar_Matrices("Monedas")
        '
        Dim NombreNota As String = "Curr_" & T_SlugAPI.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        Inicializar()
        L_Mensaje.Text = "Moneda guardada correctamente"
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
        '   18      Price_Change_24h
        '   19      Price_Change_Percentage_24h
        '   20      Circulating_Supply
        '   21      Fecha_Actualizacion
        '   22      Actualizacion_Automatica        (SI/NO) sirve para saber si se actualiza automaticamente o es una moneda personalizada que no se actualiza
        '   23      Tipo_Moneda                     Moneda / CryptoMoneda

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
        Inicializar()
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
        Ver(L_Monedas.Text)
    End Sub
    Private Sub L_Monedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Monedas.SelectedIndexChanged
        '
    End Sub
    Private Sub B_NuevoMoneda_Click_1(sender As Object, e As EventArgs) Handles B_NuevoMoneda.Click
        Limpiar(True)
        C_TipoMoneda.Enabled = True
        L_Fila.Text = "0"
        T_Simbolo.Focus()
    End Sub
    Private Sub B_GrabarMoneda_Click_1(sender As Object, e As EventArgs) Handles B_GrabarMoneda.Click
        Grabar()
    End Sub
    Private Sub B_Actualizar_Monedas_Click_1(sender As Object, e As EventArgs) Handles B_ActualizaTODO_Monedas.Click
        Me.Enabled = False
        ActualizarMonedas()
        Inicializar()
        Me.Enabled = True
    End Sub
    Private Sub B_Actualiza_Moneda_Click(sender As Object, e As EventArgs) Handles B_Actualiza_Moneda.Click
        API_CoinGecko_ActualizaValor(T_Simbolo.Text)
        Ver(L_Fila.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_LinkCoinGeko.Text) < 3 Then Exit Sub
        '
        Dim URL As String = T_LinkCoinGeko.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub B_Copiar_Click(sender As Object, e As EventArgs) Handles B_Copiar.Click
        CopiarAlPortapapeles(T_ContractAddres)
    End Sub
End Class