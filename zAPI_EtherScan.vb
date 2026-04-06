'
'
'
Imports System.Net
Imports System.Text.Json.Nodes

Module zAPI_EtherScan
    '
    '
    ' ============================================================
    '  Consulta TODAS las redes EVM activas para una billetera
    '  Es el punto de entrada principal desde F_Billetera
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
            'If Matriz_Redes(r, 1) <> "1" Then Continue For 'Para para Debug
            '
            Dim idRed As String = Matriz_Redes(r, 0)
            Dim nombreRed As String = Matriz_Redes(r, 3)
            Dim esEVM As String = Matriz_Redes(r, 8)
            Dim urlExplorador As String = Matriz_Redes(r, 14)
            '
            ' Log de cada red aunque se salte
            log &= $"Red [{r}]: {nombreRed} | EVM={esEVM} | URL={urlExplorador}" & vbCrLf
            '
            If esEVM.ToUpper() <> "SI" Then
                log &= "  → SALTADA (no EVM)" & vbCrLf
                Continue For
            End If
            If urlExplorador = "0" OrElse String.IsNullOrWhiteSpace(urlExplorador) Then
                log &= "  → SALTADA (sin URL)" & vbCrLf
                Continue For
            End If
            '
            Dim chainId As String = Matriz_Redes(r, 1)
            Dim urlAPINativa As String = Matriz_Redes(r, 18)  ' URL_API columna 18

            ' Decidir qué URL usar
            Dim urlAPI As String
            If Not String.IsNullOrWhiteSpace(chainId) AndAlso chainId <> "0" Then
                urlAPI = $"https://api.etherscan.io/v2/api?chainid={chainId}&"  ' Etherscan V2 siempre preferida
            ElseIf Not String.IsNullOrWhiteSpace(urlAPINativa) AndAlso urlAPINativa <> "0" Then
                urlAPI = urlAPINativa & "?"          ' fallback: API nativa solo si no hay chainId
            Else
                log &= "  → SALTADA (sin Chain_ID ni URL_API)" & vbCrLf
                Continue For
            End If


            Dim tokenNativo As String = Matriz_Redes(r, 10)
            Dim decimalesRed As Integer = 18
            Try : decimalesRed = CInt(Matriz_Redes(r, 11)) : Catch : End Try
            '
            log &= $"  → Consultando {urlAPI}" & vbCrLf
            '
            Try
                ' Saldo nativo
                Dim saldoWei As Double = ConsultarSaldoNativo(urlAPI, direccion, API_ETHERSCAN, log)
                Dim saldoLegible As Double = saldoWei / Math.Pow(10, decimalesRed)
                log &= $"  → Saldo nativo ({tokenNativo}): {saldoWei} Wei = {saldoLegible:F8}" & vbCrLf
                '
                If saldoLegible > 0 Then
                    Dim precioNativo As Double = ObtenerPrecioUSD(tokenNativo)
                    AgregarBilleteraSaldo(direccion, idRed, fechaHoraConsulta, tokenNativo, saldoLegible, precioNativo)
                    registrosGrabados += 1
                    log &= $"  → GRABADO: {tokenNativo} {saldoLegible:F8}" & vbCrLf
                End If

                ' Tokens ERC-20
                Dim tokens As List(Of TokenBalance) = ConsultarTokensERC20(urlAPI, direccion, API_ETHERSCAN)
                log &= $"  → Tokens ERC-20 encontrados: {tokens.Count}" & vbCrLf
                For Each t As TokenBalance In tokens
                    log &= $"     • {t.Simbolo}: {t.Saldo:F8}" & vbCrLf
                    If t.Saldo > 0 Then
                        AgregarBilleteraSaldo(direccion, idRed, fechaHoraConsulta, t.Simbolo, t.Saldo, ObtenerPrecioUSD(t.Simbolo))
                        registrosGrabados += 1
                    End If
                Next
                '
                redesConsultadas += 1
                '
                '
            Catch ex As Exception
                log &= $"  → ERROR: {ex.Message}" & vbCrLf
            End Try

            Threading.Thread.Sleep(300)
        Next r

        log &= vbCrLf & $"=== RESUMEN ===" & vbCrLf
        log &= $"Redes consultadas: {redesConsultadas}" & vbCrLf
        log &= $"Registros grabados: {registrosGrabados}" & vbCrLf
        log &= $"Matriz_BilleteraSaldosTF después: {Matriz_BilleteraSaldosTF}" & vbCrLf

        If registrosGrabados > 0 Then
            Guardar_Matrices("BilleteraSaldo")
            log &= "Guardado OK" & vbCrLf
        End If

        ' Guardar log en disco para revisarlo
        Dim rutaLog As String = RutaLocal & "\log_billetera.txt"
        If ModoDebug Then System.IO.File.WriteAllText(rutaLog, log, System.Text.Encoding.UTF8)
        Return $"Redes: {redesConsultadas} | Registros: {registrosGrabados} | Log: {rutaLog}"
    End Function

    ' ============================================================
    '  Consulta una red específica (se mantiene para uso puntual)
    ' ============================================================
    Public Sub ConsultarBilletera_EVM(ByVal direccion As String, ByVal ID_Red As String)
        Dim filaRed As Integer = 0
        For r As Integer = 1 To Matriz_RedesTF
            If Matriz_Redes(r, 0) = ID_Red Then
                filaRed = r
                Exit For
            End If
        Next r
        '
        If filaRed = 0 Then
            MsgBox("Red no encontrada: " & ID_Red)
            Return
        End If
        '
        Dim nombreRed As String = Matriz_Redes(filaRed, 3)
        Dim urlExplorador As String = Matriz_Redes(filaRed, 14)
        Dim esEVM As String = Matriz_Redes(filaRed, 8)
        '
        If esEVM.ToUpper() <> "SI" Then Return
        If String.IsNullOrWhiteSpace(urlExplorador) OrElse urlExplorador = "0" Then Return
        '
        Dim urlAPI As String = $"https://api.{urlExplorador}/api"
        Dim tokenNativo As String = Matriz_Redes(filaRed, 10)
        Dim decimalesRed As Integer = 18
        Try
            decimalesRed = CInt(Matriz_Redes(filaRed, 11))
        Catch
            decimalesRed = 18
        End Try
        '
        Dim fechaHoraConsulta As String = DateTime.Now.ToString("yyyyMMdd HHmm")
        Dim logIgnorado As String = ""
        Dim saldoLegible As Double = ConsultarSaldoNativo(urlAPI, direccion, API_ETHERSCAN, logIgnorado) / Math.Pow(10, decimalesRed)
        '
        If saldoLegible > 0 Then
            AgregarBilleteraSaldo(direccion, ID_Red, fechaHoraConsulta, tokenNativo, saldoLegible, ObtenerPrecioUSD(tokenNativo))
        End If
        '
        Dim tokens As List(Of TokenBalance) = ConsultarTokensERC20(urlAPI, direccion, API_ETHERSCAN)
        For Each t As TokenBalance In tokens
            If t.Saldo > 0 Then
                AgregarBilleteraSaldo(direccion, ID_Red, fechaHoraConsulta, t.Simbolo, t.Saldo, ObtenerPrecioUSD(t.Simbolo))
            End If
        Next
        Guardar_Matrices("BilleteraSaldo")
    End Sub

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
    '  Saldo nativo en Wei
    ' ------------------------------------------------------------
    Private Function ConsultarSaldoNativo(ByVal urlAPI As String, ByVal direccion As String, ByVal apiKey As String, ByRef log As String) As Double   ' ← agregar este parámetro
        Try
            Dim url As String = $"{urlAPI}module=account&action=balance" &
                    $"&address={direccion}&tag=latest&apikey={apiKey}"
            log &= $"    URL: {url}" & vbCrLf   ' ← log al string, no al archivo
            '
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            '
            log &= $"    RAW JSON: {json}" & vbCrLf
            '
            Dim item As JsonNode = JsonNode.Parse(json)
            Dim status As String = If(item("status") Is Nothing, "NULL", item("status").ToString())
            Dim result As String = If(item("result") Is Nothing, "NULL", item("result").ToString())
            '
            log &= $"    status={status} | result={result}" & vbCrLf
            '
            If status = "1" Then
                Dim valor As Double = Double.Parse(result, Globalization.CultureInfo.InvariantCulture)
                log &= $"    Parse OK: {valor}" & vbCrLf
                Return valor
            End If
            Return 0
            '
            '
            '
        Catch ex As Exception
            log &= $"    EXCEPCION: {ex.GetType().Name} | {ex.Message}" & vbCrLf
            Return 0
        End Try
    End Function

    ' ------------------------------------------------------------
    '  Tokens ERC-20 con saldo
    ' ------------------------------------------------------------
    Private Function ConsultarTokensERC20(ByVal urlAPI As String, ByVal direccion As String, ByVal apiKey As String) As List(Of TokenBalance)
        Dim resultado As New List(Of TokenBalance)
        '
        Try
            ' tokentx es gratuito — devuelve historial de transferencias ERC-20
            Dim url As String = $"{urlAPI}module=account&action=tokentx" & $"&address={direccion}&page=1&offset=200" & $"&sort=desc&apikey={apiKey}"
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)
            '
            If item("status") Is Nothing OrElse item("status").ToString() <> "1" Then
                Return resultado
            End If

            ' Calcular saldo neto por token sumando entradas y restando salidas
            Dim saldos As New Dictionary(Of String, Double)        ' contractAddress → saldo neto
            Dim infoTokens As New Dictionary(Of String, TokenBalance) ' contractAddress → info
            '
            For Each t As JsonNode In item("result").AsArray()
                Dim contrato As String = If(t("contractAddress") Is Nothing, "", t("contractAddress").ToString().ToLower())
                Dim decimales As Integer = 18
                Try : decimales = CInt(t("tokenDecimal").ToString()) : Catch : End Try
                '
                Dim cantidadRaw As Double = 0
                Try
                    cantidadRaw = Double.Parse(t("value").ToString(), Globalization.CultureInfo.InvariantCulture)
                Catch
                End Try
                '
                Dim cantidad As Double = cantidadRaw / Math.Pow(10, decimales)
                Dim desde As String = If(t("from") Is Nothing, "", t("from").ToString().ToLower())
                Dim hacia As String = If(t("to") Is Nothing, "", t("to").ToString().ToLower())
                Dim dirLower As String = direccion.ToLower()

                ' Entrada: la dirección recibe tokens
                If hacia = dirLower Then
                    If Not saldos.ContainsKey(contrato) Then saldos(contrato) = 0
                    saldos(contrato) += cantidad
                End If

                ' Salida: la dirección envía tokens
                If desde = dirLower Then
                    If Not saldos.ContainsKey(contrato) Then saldos(contrato) = 0
                    saldos(contrato) -= cantidad
                End If

                ' Guardar info del token la primera vez que aparece
                If Not infoTokens.ContainsKey(contrato) Then
                    infoTokens(contrato) = New TokenBalance With {
                    .Simbolo = If(t("tokenSymbol") Is Nothing, "?", t("tokenSymbol").ToString()),
                    .Nombre = If(t("tokenName") Is Nothing, "?", t("tokenName").ToString()),
                    .ContractAddress = contrato,
                    .Decimales = decimales
                }
                End If
            Next
            '
            ' Convertir dictionary a lista filtrando saldos > 0
            For Each kvp As KeyValuePair(Of String, Double) In saldos
                If kvp.Value > 0.000001 AndAlso infoTokens.ContainsKey(kvp.Key) Then
                    Dim tk As TokenBalance = infoTokens(kvp.Key)
                    tk.Saldo = kvp.Value
                    resultado.Add(tk)
                End If
            Next
            '
            '
            '
        Catch ex As Exception
        End Try
        Return resultado
    End Function

    ' ------------------------------------------------------------
    '  Clase auxiliar
    ' ------------------------------------------------------------
    Public Class TokenBalance
        Public Property Simbolo As String
        Public Property Nombre As String
        Public Property ContractAddress As String
        Public Property Saldo As Double
        Public Property Decimales As Integer
    End Class

End Module
