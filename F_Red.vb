'
'
'
Public Class F_Red
    '
    '
    '
    '
    Private Sub LimpiezaRedes(Optional Habilitar As Boolean = False)
        L_Fila_Red.Text = ""
        'REDES
        L_IDRed_Red.Text = ""
        T_ChainID_Red.Text = ""
        T_NomOficial_Red.Text = ""
        T_NomCorto_Red.Text = ""
        T_APIcg_Red.Text = ""
        T_L1padre_Red.Text = ""
        T_TipoRollup_Red.Text = ""
        T_TokenNativo_Red.Text = ""
        T_Decimales_Red.Text = ""
        T_TipoBloque_Red.Text = ""
        T_Color_Red.Text = ""
        T_URLexplorador_Red.Text = ""
        T_URLlogo_Red.Text = ""
        T_URLrpc_Red.Text = ""
        T_TipoCapa_Red.Text = ""
        T_MecanismoConsenso_Red.Text = ""
        rT_Nota.Text = ""
        '
        L_IDRed_Red.Enabled = Habilitar
        T_ChainID_Red.Enabled = Habilitar
        T_NomOficial_Red.Enabled = Habilitar
        T_NomCorto_Red.Enabled = Habilitar
        T_APIcg_Red.Enabled = Habilitar
        T_L1padre_Red.Enabled = Habilitar
        T_TipoRollup_Red.Enabled = Habilitar
        T_TokenNativo_Red.Enabled = Habilitar
        T_Decimales_Red.Enabled = Habilitar
        T_TipoBloque_Red.Enabled = Habilitar
        T_Color_Red.Enabled = Habilitar
        T_URLexplorador_Red.Enabled = Habilitar
        T_URLlogo_Red.Enabled = Habilitar
        T_URLrpc_Red.Enabled = Habilitar
        T_TipoCapa_Red.Enabled = Habilitar
        T_MecanismoConsenso_Red.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar

    End Sub
    Private Sub VerRedes(F As Integer)
        LimpiezaRedes(True)
        If F < 1 Then Exit Sub

        L_IDRed_Red.Text = F
        L_IDRed_Red.Text = Matriz_Redes(F, 0)
        T_ChainID_Red.Text = Matriz_Redes(F, 1)
        T_NomOficial_Red.Text = Matriz_Redes(F, 2)
        T_NomCorto_Red.Text = Matriz_Redes(F, 3)
        T_APIcg_Red.Text = Matriz_Redes(F, 4)
        T_TipoCapa_Red.Text = Matriz_Redes(F, 5)
        T_L1padre_Red.Text = Matriz_Redes(F, 6)
        T_TipoRollup_Red.Text = Matriz_Redes(F, 7)
        '8 EVM
        T_MecanismoConsenso_Red.Text = Matriz_Redes(F, 9)
        T_TokenNativo_Red.Text = Matriz_Redes(F, 10)
        T_Decimales_Red.Text = Matriz_Redes(F, 11)
        T_TipoBloque_Red.Text = Matriz_Redes(F, 12)
        T_Color_Red.Text = Matriz_Redes(F, 13)
        T_URLexplorador_Red.Text = Matriz_Redes(F, 14)
        T_URLlogo_Red.Text = Matriz_Redes(F, 15)
        T_URLrpc_Red.Text = Matriz_Redes(F, 16)
        '17 Activo
        '
        '--------------------------------------------
        Dim T As String
        '
        '8 EVM                  Matriz_Redes(F, 8)
        T = UCase(Matriz_Redes(F, 8))
        If T = "SI" Then
            CB_EVM_Red.Checked = True
        Else
            CB_EVM_Red.Checked = False
        End If
        '
        '17 Activo              Matriz_Redes(F, 17)
        If Matriz_Redes(F, 17) = "SI" Then
            CB_Activo_Red.Checked = True
        Else
            CB_Activo_Red.Checked = False
        End If
        '0      ID_Interno
        '1      Chain_ID               Identificador único para redes EVM
        '2      Nombre_Oficial         Nombre completo
        '3      Nombre_Corto           Para mostrar en pantalla
        '4      Slug_API               Identificador en APIs como CoinGecko
        '5      Tipo_Capa              Arquitectura de la red, L1 / L2 / Sidechain
        '6      L1_Padre               Solo aplica si es L2 — a qué L1 está anclada
        '7      Tipo_Rollup            Solo aplica a L2s
        '8      Compatible_EVM         Define si usa el estándar de Ethereum           Sí / No
        '9      Mecanismo_Consenso     Cómo valida la red                              PoW, PoS, PoH
        '10     Token_Nativo           En ARB el token nativo es ETH, no ARB.
        '                            El token ARB existe, pero es el token de gobernanza del protocolo,
        '                                no el que se usa para pagar el gas.
        '                                Esto aplica también a otras redes como Base y Optimism,
        '                                    que también usan ETH como gas aunque tengan su propio token de gobernanza.
        '11     Decimales              Crítico para cálculos — cada red usa distinto   Pueden ser; 18 decimales, 6 decimales, etc.
        '12     Tiempo_Bloque          Velocidad de confirmación                       12 seg, 0.4 seg
        '13     Color_Marca            Para mostrar en la UI                           #627EEA                     
        '14     URL_Explorador         Para consultar transacciones                    etherscan.io
        '15     URL_Logo               Ícono de la red                                 https://...
        '16     URL_RPC                Para conectarse a la red programáticamente      https://...
        '17     Activa                 Para desactivar redes sin borrarlas             Sí / No
        '
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
    Private Sub F_Red_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim T As String
        LimpiezaRedes()
        OrdenarMatriz(Matriz_Redes, Matriz_RedesTF, Matriz_RedesTC, 2, "DES")
        L_Red.Items.Clear()
        For i As Integer = 1 To Matriz_RedesTF
            T = Matriz_Redes(i, 2) & " (" & i & ")"
            L_Red.Items.Add(T)
        Next i
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub


    Private Sub Label65_Click_1(sender As Object, e As EventArgs) Handles Label65.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLexplorador_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLexplorador_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub L_Red_ControlAdded(sender As Object, e As ControlEventArgs) Handles L_Red.ControlAdded
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Red.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerRedes(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub Label72_Click_1(sender As Object, e As EventArgs) Handles Label72.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLrpc_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLrpc_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub Label73_Click_1(sender As Object, e As EventArgs) Handles Label73.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLlogo_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLlogo_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub L_Red_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Red.SelectedIndexChanged

    End Sub
    Private Sub L_Red_Click(sender As Object, e As EventArgs) Handles L_Red.Click
        If VariableDeInicio Then Exit Sub
        Dim T As String = L_Red.Text
        Dim x As Integer = InStr(T, "(")
        If x = 0 Then Exit Sub
        VerRedes(Mid(T, x + 1, Len(T) - x - 1))
    End Sub

    Private Sub B_NuevoRed_Click(sender As Object, e As EventArgs) Handles B_NuevoRed.Click

    End Sub
    '
    '
    '
End Class