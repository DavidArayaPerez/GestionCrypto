'
'
'
Module mRedes
    '
    '
    '
    '1. Chainlist / chainid.network ✅ (La mejor opción)
    'Es el estándar de facto para redes EVM. Mantiene una lista pública en GitHub con todas las redes EVM y sus Chain IDs.
    'URL del JSON: https://chainid.network/chains.json
    '

    Public Matriz_Redes(,) As String
    Public Matriz_RedesTF As String
    Public Matriz_RedesTC As String = 17

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
    '                              El token ARB existe, pero es el token de gobernanza del protocolo,
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

    Public Sub CambiarIDRedes()
        Dim i As Integer
        For i = 1 To Matriz_RedesTF
            If Len(Matriz_Redes(i, 0)) < 7 Then
                Matriz_Redes(i, 0) = CrearCodigoInterno()
            End If
        Next i
        Guardar_Matrices("Redes")
    End Sub


    '
    '
    '
End Module
