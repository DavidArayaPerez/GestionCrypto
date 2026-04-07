'
'
'
Imports Microsoft.Graph.Admin

Public Class F_Red
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpiar()
        LlenarList_Redes(L_Red)
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        L_Fila.Text = ""
        'REDES
        L_ID.Text = ""
        L_ChainID.Text = ""
        L_NomOficial.Text = ""
        L_NomCorto.Text = ""
        L_APIcg.Text = ""
        L_L1padre.Text = ""
        L_TipoRollup.Text = ""
        L_TokenNativo.Text = ""
        T_URLexplorador_Red.Text = ""
        T_URLrpc_Red.Text = ""
        L_TipoCapa.Text = ""
        L_MecanismoConsenso.Text = ""
        rT_Nota.Text = ""
        '
        L_ID.Enabled = Habilitar
        L_ChainID.Enabled = Habilitar
        L_NomOficial.Enabled = Habilitar
        L_NomCorto.Enabled = Habilitar
        L_APIcg.Enabled = Habilitar
        L_L1padre.Enabled = Habilitar
        L_TipoRollup.Enabled = Habilitar
        L_TokenNativo.Enabled = Habilitar
        T_URLexplorador_Red.Enabled = Habilitar
        T_URLrpc_Red.Enabled = Habilitar
        L_TipoCapa.Enabled = Habilitar
        L_MecanismoConsenso.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
    End Sub
    Private Sub Ver(Slug_API As String)
        Limpiar(True)
        Dim F As Integer = BuscarRedes(Slug_API)
        If F < 1 Then Exit Sub
        '
        L_ID.Text = F
        L_ID.Text = Matriz_Redes(f, 0)
        L_ChainID.Text = Matriz_Redes(f, 1)
        L_NomOficial.Text = Matriz_Redes(f, 2)
        L_NomCorto.Text = Matriz_Redes(f, 3)
        L_APIcg.Text = Matriz_Redes(f, 4)
        L_TipoCapa.Text = Matriz_Redes(f, 5)
        L_L1padre.Text = Matriz_Redes(f, 6)
        L_TipoRollup.Text = Matriz_Redes(f, 7)
        '8 EVM
        L_MecanismoConsenso.Text = Matriz_Redes(f, 9)
        L_TokenNativo.Text = Matriz_Redes(f, 10)
        'T_Decimales_Red.Text = Matriz_Redes(F, 11)
        'T_TipoBloque_Red.Text = Matriz_Redes(F, 12)
        'T_Color_Red.Text = Matriz_Redes(F, 13)
        T_URLexplorador_Red.Text = Matriz_Redes(f, 14)
        'T_URLlogo_Red.Text = Matriz_Redes(F, 15)
        T_URLrpc_Red.Text = Matriz_Redes(f, 16)
        T_URLAPI_Red.Text = Matriz_Redes(f, 18)
        T_ChainHex_Red.Text = Matriz_Redes(f, 19)
        '17 Activo
        '
        '--------------------------------------------
        Dim T As String
        '
        '8 EVM                  Matriz_Redes(F, 8)
        T = UCase(Matriz_Redes(f, 8))
        If T = "SI" Then
            CB_EVM_Red.Checked = True
        Else
            CB_EVM_Red.Checked = False
        End If
        '
        '17 Activo              Matriz_Redes(F, 17)
        If Matriz_Redes(f, 17) = "SI" Then
            CB_Activo_Red.Checked = True
        Else
            CB_Activo_Red.Checked = False
        End If
        '
        Dim NombreNota As String = "Chain_" & Matriz_Redes(f, 4) & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
        '
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
    Private Function DatosNoValidos() As Boolean
        Return False
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        '
        Dim F As Integer = L_Fila.Text
        If F = 0 Then
            L_Mensaje.Text = "No existen datos para guardar"
            Exit Sub
        End If
        '
        If CB_Activo_Red.Checked Then
            Matriz_Redes(F, 17) = "SI"
        Else
            Matriz_Redes(F, 17) = "NO"
        End If
        Matriz_Redes(F, 18) = T_URLAPI_Red.Text
        Matriz_Redes(F, 19) = T_ChainHex_Red.Text
        '
        Guardar_Matrices("Redes")
        '
        Dim NombreNota As String = "Chain_" & Matriz_Redes(F, 4) & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Red guardada correctamente"
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
        '10     Token_Nativo
        '11     Decimales              Crítico para cálculos
        '12     Tiempo_Bloque          Velocidad de confirmación
        '13     Color_Marca            Para mostrar en la UI
        '14     URL_Explorador         Para consultar transacciones
        '15     URL_Logo               Ícono de la red
        '16     URL_RPC                Para conectarse a la red programáticamente
        '17     Activa                 Para desactivar redes sin borrarlas
        '18     URL_API                API nativa de la red (BscScan, BaseScan, etc.)
        '19     Chain_Hex              Identificador hexadecimal para Moralis
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
        Inicializar()
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
        Ver(Mid(T, x + 1, Len(T) - x - 1))
    End Sub
    Private Sub Label72_Click_1(sender As Object, e As EventArgs) Handles Label72.Click
        If VariableDeInicio Then Exit Sub
        If Len(T_URLrpc_Red.Text) < 3 Then Exit Sub
        '
        Dim URL As String = "http://" & T_URLrpc_Red.Text
        Process.Start(New ProcessStartInfo(URL) With {.UseShellExecute = True})
    End Sub
    Private Sub L_Red_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Red.SelectedIndexChanged

    End Sub
    Private Sub L_Red_Click(sender As Object, e As EventArgs) Handles L_Red.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_Red.Text)
    End Sub

    Private Sub B_GrabarRed_Click(sender As Object, e As EventArgs) Handles B_GrabarRed.Click
        Grabar()
    End Sub
    '
    '
    '
End Class