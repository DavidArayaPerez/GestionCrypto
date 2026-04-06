'https://admin.moralis.com/
'
'
Imports System.Net
Imports System.Text.Json.Nodes
'
'
'
Module zAPI_Moralis
    '
    '
    '
    '
    '
    ' ============================================================
    '  Consulta TODAS las redes EVM activas para una billetera
    '  Usando Moralis como fuente única de datos
    ' ============================================================
    Public Function ConsultarBilletera_TodasLasRedes(ByVal direccion As String) As String
        Dim fechaHoraConsulta As String = DateTime.Now.ToString("yyyyMMdd HHmm")
        Dim redesConsultadas As Integer = 0
        Dim registrosGrabados As Integer = 0
        Dim log As String = $"=== Consulta {fechaHoraConsulta} ===" & vbCrLf
        log &= $"Dirección: {direccion}" & vbCrLf
        log &= $"Total redes en matriz: {Matriz_RedesTF}" & vbCrLf & vbCrLf
        '
        For r As Integer = 1 To Matriz_RedesTF
            '
            Dim idRed As String = Matriz_Redes(r, 0)
            Dim nombreRed As String = Matriz_Redes(r, 3)
            Dim esEVM As String = Matriz_Redes(r, 8)
            Dim urlExplorador As String = Matriz_Redes(r, 14)
            Dim chainHex As String = Matriz_Redes(r, 19) ' columna con el chain hex de Moralis
            '
            log &= $"Red [{r}]: {nombreRed} | EVM={esEVM} | Chain={chainHex}" & vbCrLf
            '
            If esEVM.ToUpper() <> "SI" Then
                log &= "  → SALTADA (no EVM)" & vbCrLf
                Continue For
            End If
            If String.IsNullOrWhiteSpace(chainHex) OrElse chainHex = "0" Then
                log &= "  → SALTADA (sin Chain Hex Moralis)" & vbCrLf
                Continue For
            End If
            '
            Dim tokenNativo As String = Matriz_Redes(r, 10)
            Dim decimalesRed As Integer = 18
            Try : decimalesRed = CInt(Matriz_Redes(r, 11)) : Catch : End Try
            '
            log &= $"  → Consultando Moralis chain={chainHex}" & vbCrLf
            '
            Try
                Dim tokens As List(Of TokenBalance) = ConsultarTokens(chainHex, direccion, log)
                '
                For Each t As TokenBalance In tokens
                    If t.EsNativo Then
                        log &= $"  → Saldo nativo ({tokenNativo}): {t.Saldo:F8}" & vbCrLf
                        If t.Saldo > 0 Then
                            AgregarBilleteraSaldo(direccion, idRed, fechaHoraConsulta, tokenNativo, t.Saldo, ObtenerPrecioUSD(tokenNativo))
                            registrosGrabados += 1
                            log &= $"  → GRABADO: {tokenNativo} {t.Saldo:F8}" & vbCrLf
                        End If
                    Else
                        log &= $"     • {t.Simbolo}: {t.Saldo:F8}" & vbCrLf
                        If t.Saldo > 0.000001 Then
                            AgregarBilleteraSaldo(direccion, idRed, fechaHoraConsulta, t.Simbolo, t.Saldo, ObtenerPrecioUSD(t.Simbolo))
                            registrosGrabados += 1
                        End If
                    End If
                Next
                '
                log &= $"  → Tokens encontrados: {tokens.Count}" & vbCrLf
                redesConsultadas += 1
                '
            Catch ex As Exception
                log &= $"  → ERROR: {ex.Message}" & vbCrLf
            End Try
            '
            Threading.Thread.Sleep(300)
        Next r
        '
        log &= vbCrLf & "=== RESUMEN ===" & vbCrLf
        log &= $"Redes consultadas: {redesConsultadas}" & vbCrLf
        log &= $"Registros grabados: {registrosGrabados}" & vbCrLf
        log &= $"Matriz_BilleteraSaldosTF después: {Matriz_BilleteraSaldosTF}" & vbCrLf
        '
        If registrosGrabados > 0 Then
            Guardar_Matrices("BilleteraSaldo")
            log &= "Guardado OK" & vbCrLf
        End If
        '
        Dim rutaLog As String = RutaLocal & "\log_billetera.txt"
        If ModoDebug Then System.IO.File.WriteAllText(rutaLog, log, System.Text.Encoding.UTF8)
        Return $"Redes: {redesConsultadas} | Registros: {registrosGrabados} | Log: {rutaLog}"
    End Function

    ' ------------------------------------------------------------
    '  Consulta saldo nativo + tokens ERC-20 en una sola llamada
    ' ------------------------------------------------------------
    Private Function ConsultarTokens(ByVal chainHex As String, ByVal direccion As String, ByRef log As String) As List(Of TokenBalance)
        Dim resultado As New List(Of TokenBalance)
        '
        Try
            Dim url As String = $"https://deep-index.moralis.io/api/v2.2/wallets/{direccion}/tokens?chain={chainHex}"
            log &= $"    URL: {url}" & vbCrLf
            '
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            client.Headers.Add("X-API-Key", API_MORALIS)
            client.Headers.Add("accept", "application/json")
            '
            Dim json As String = client.DownloadString(New Uri(url))
            log &= $"    RAW JSON: {json.Substring(0, Math.Min(200, json.Length))}..." & vbCrLf
            '
            Dim root As JsonNode = JsonNode.Parse(json)
            Dim items As JsonArray = root("result").AsArray()
            '
            For Each item As JsonNode In items
                Dim esNativo As Boolean = False
                Try : esNativo = CBool(item("native_token").ToString()) : Catch : End Try
                '
                Dim simbolo As String = If(item("symbol") Is Nothing, "?", item("symbol").ToString())
                Dim nombre As String = If(item("name") Is Nothing, "?", item("name").ToString())
                Dim contrato As String = If(item("token_address") Is Nothing, "", item("token_address").ToString())
                '
                Dim saldo As Double = 0
                Try
                    saldo = Double.Parse(item("balance_formatted").ToString(), Globalization.CultureInfo.InvariantCulture)
                Catch
                End Try
                '
                resultado.Add(New TokenBalance With {
                    .Simbolo = simbolo,
                    .Nombre = nombre,
                    .ContractAddress = contrato,
                    .Saldo = saldo,
                    .EsNativo = esNativo
                })
            Next
            '
        Catch ex As Exception
            log &= $"    EXCEPCION: {ex.GetType().Name} | {ex.Message}" & vbCrLf
        End Try
        '
        Return resultado
    End Function

    ' ------------------------------------------------------------
    '  Precio USD desde Matriz_Monedas
    ' ------------------------------------------------------------
    Private Function ObtenerPrecioUSD(ByVal simbolo As String) As Double
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() Then
                Try
                    Return Double.Parse(Matriz_Monedas(i, 15), Globalization.CultureInfo.InvariantCulture)
                Catch
                    Return 0
                End Try
            End If
        Next i
        Return 0
    End Function

    ' ------------------------------------------------------------
    '  Clase auxiliar
    ' ------------------------------------------------------------
    Public Class TokenBalance
        Public Property Simbolo As String
        Public Property Nombre As String
        Public Property ContractAddress As String
        Public Property Saldo As Double
        Public Property EsNativo As Boolean
    End Class


    '
    '
    '
End Module
