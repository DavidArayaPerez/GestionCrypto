'
'
'
Imports System.Net
Imports System.Text.Json.Nodes

Module zAPI_EtherScan
    '
    '
    'api.etherscan.io
    '
    '
    '
    ' ============================================================
    '  Leer billetera EVM desde cualquier red compatible Etherscan
    '  Parámetros:
    '    direccion  → dirección pública 0x...
    '    ID_Red     → ID_Interno de Matriz_Redes (columna 0)
    ' ============================================================
    Public Sub ConsultarBilletera_EVM(ByVal direccion As String, ByVal ID_Red As String)

        ' --- 1. Buscar la red en Matriz_Redes ---
        Dim filaRed As Integer = 0
        For r As Integer = 1 To Matriz_RedesTF
            If Matriz_Redes(r, 0) = ID_Red Then
                filaRed = r
                Exit For
            End If
        Next r

        If filaRed = 0 Then
            MsgBox("Red no encontrada en Matriz_Redes: " & ID_Red)
            Return
        End If

        Dim nombreRed As String = Matriz_Redes(filaRed, 3)       ' Nombre_Corto
        Dim urlExplorador As String = Matriz_Redes(filaRed, 14)  ' URL_Explorador  ej: "etherscan.io"
        Dim esEVM As String = Matriz_Redes(filaRed, 8)           ' Compatible_EVM

        If esEVM.ToUpper() <> "SI" Then
            MsgBox($"La red '{nombreRed}' no es compatible EVM. Esta función solo aplica a redes EVM.")
            Return
        End If

        If String.IsNullOrWhiteSpace(urlExplorador) OrElse urlExplorador = "0" Then
            MsgBox($"La red '{nombreRed}' no tiene URL_Explorador configurada en Redes.txt.")
            Return
        End If

        ' --- 2. Construir URL base de la API ---
        ' De "etherscan.io"      → "https://api.etherscan.io/api"
        ' De "polygonscan.com"   → "https://api.polygonscan.com/api"
        ' De "arbiscan.io"       → "https://api.arbiscan.io/api"
        Dim urlAPI As String = $"https://api.{urlExplorador}/api"

        ' --- 3. Consultar saldo nativo (ETH, BNB, MATIC, etc.) ---
        Dim saldoNativo As Double = ConsultarSaldoNativo(urlAPI, direccion, API_ETHERSCAN)
        Dim tokenNativo As String = Matriz_Redes(filaRed, 10)    ' Token_Nativo
        Dim decimalesRed As Integer = 18
        Try
            decimalesRed = CInt(Matriz_Redes(filaRed, 11))
        Catch
            decimalesRed = 18
        End Try

        ' Convertir de Wei a unidad legible (dividir por 10^decimales)
        Dim saldoLegible As Double = saldoNativo / Math.Pow(10, decimalesRed)

        ' --- 4. Consultar tokens ERC-20 ---
        Dim tokens As List(Of TokenBalance) = ConsultarTokensERC20(urlAPI, direccion, API_ETHERSCAN)

        ' --- 5. Mostrar resultado ---
        Dim resultado As String = $"Billetera: {direccion}" & vbCrLf &
                                  $"Red: {nombreRed}" & vbCrLf & vbCrLf &
                                  $"── Saldo nativo ──" & vbCrLf &
                                  $"  {tokenNativo}: {saldoLegible:F6}" & vbCrLf & vbCrLf &
                                  $"── Tokens ERC-20 ({tokens.Count}) ──" & vbCrLf

        For Each t As TokenBalance In tokens
            resultado &= $"  {t.Simbolo}: {t.Saldo:F4}" & vbCrLf
        Next


        ' --- Guardar saldos en Matriz_BilleteraSaldo ---
        Dim fechaHoraConsulta As String = DateTime.Now.ToString("yyyyMMdd HHmm")

        ' Saldo nativo (ETH, BNB, MATIC, etc.)
        If saldoLegible > 0 Then
            ' Obtener precio USD desde Matriz_Monedas
            Dim precioNativo As Double = ObtenerPrecioUSD(tokenNativo)
            AgregarBilleteraSaldo(direccion, ID_Red, fechaHoraConsulta,
                          tokenNativo, saldoLegible, precioNativo)
        End If

        ' Tokens ERC-20
        For Each t As TokenBalance In tokens
            If t.Saldo > 0 Then
                Dim precioToken As Double = ObtenerPrecioUSD(t.Simbolo)
                AgregarBilleteraSaldo(direccion, ID_Red, fechaHoraConsulta, t.Simbolo, t.Saldo, precioToken)
            End If
        Next
        Guardar_Matrices("BilleteraSaldo")
        MsgBox(resultado, vbInformation, $"Billetera {nombreRed}")
    End Sub
    Private Function ObtenerPrecioUSD(ByVal simbolo As String) As Double
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() Then
                Try
                    Return Double.Parse(Matriz_Monedas(i, 15),
                                    Globalization.CultureInfo.InvariantCulture)
                Catch
                    Return 0
                End Try
            End If
        Next i
        Return 0
    End Function

    ' ------------------------------------------------------------
    '  Consulta el saldo nativo de la billetera (ETH, BNB, etc.)
    '  Devuelve el valor en Wei (sin convertir)
    ' ------------------------------------------------------------
    Private Function ConsultarSaldoNativo(
            ByVal urlAPI As String,
            ByVal direccion As String,
            ByVal apiKey As String) As Double
        Try
            Dim url As String = $"{urlAPI}?module=account&action=balance" &
                                $"&address={direccion}&tag=latest&apikey={apiKey}"

            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)

            If ValorSeguro(item("status")) = "1" Then
                Return Double.Parse(ValorSeguro(item("result")))
            End If
            Return 0

        Catch ex As Exception
            MsgBox("Error al consultar saldo nativo: " & ex.Message)
            Return 0
        End Try
    End Function

    ' ------------------------------------------------------------
    '  Consulta los tokens ERC-20 con saldo en la billetera
    ' ------------------------------------------------------------
    Private Function ConsultarTokensERC20(
            ByVal urlAPI As String,
            ByVal direccion As String,
            ByVal apiKey As String) As List(Of TokenBalance)

        Dim resultado As New List(Of TokenBalance)

        Try
            Dim url As String = $"{urlAPI}?module=account&action=addresstokenbalance" &
                                $"&address={direccion}&page=1&offset=100&apikey={apiKey}"

            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)

            If ValorSeguro(item("status")) <> "1" Then Return resultado

            Dim lista As JsonArray = item("result").AsArray()

            For Each t As JsonNode In lista
                Dim decimales As Integer = 18
                Try
                    decimales = CInt(ValorSeguro(t("TokenDivisor")))
                Catch
                    decimales = 18
                End Try

                Dim cantidadRaw As Double = 0
                Try
                    cantidadRaw = Double.Parse(ValorSeguro(t("TokenQuantity")),
                                               Globalization.CultureInfo.InvariantCulture)
                Catch
                    cantidadRaw = 0
                End Try

                Dim saldo As Double = cantidadRaw / Math.Pow(10, decimales)

                ' Solo agregar tokens con saldo mayor a 0
                If saldo > 0 Then
                    resultado.Add(New TokenBalance With {
                        .Simbolo = ValorSeguro(t("TokenSymbol")),
                        .Nombre = ValorSeguro(t("TokenName")),
                        .ContractAddress = ValorSeguro(t("TokenAddress")),
                        .Saldo = saldo,
                        .Decimales = decimales
                    })
                End If
            Next

        Catch ex As Exception
            MsgBox("Error al consultar tokens ERC-20: " & ex.Message)
        End Try

        Return resultado
    End Function

    ' ------------------------------------------------------------
    '  Clase auxiliar para representar el saldo de un token
    ' ------------------------------------------------------------
    Public Class TokenBalance
        Public Property Simbolo As String
        Public Property Nombre As String
        Public Property ContractAddress As String
        Public Property Saldo As Double
        Public Property Decimales As Integer
    End Class

    '
    '
    '
End Module
