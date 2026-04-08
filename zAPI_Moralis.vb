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
                If chainHex = "0x1" Then
                    Dim simbolosMoralis As New List(Of String)
                    For Each t2 As TokenBalance In tokens
                        simbolosMoralis.Add(t2.Simbolo.ToUpper())
                    Next
                    ComplementarConEtherscan(direccion, idRed, fechaHoraConsulta, simbolosMoralis, log, registrosGrabados)
                End If
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
            Dim url As String = $"https://deep-index.moralis.io/api/v2.2/wallets/{direccion}/tokens?chain={chainHex}&exclude_spam=false"
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





















    ' ------------------------------------------------------------
    '  Complemento Etherscan: tokens ERC-20 en Ethereum
    '  que Moralis no devolvió
    ' ------------------------------------------------------------
    Private Sub ComplementarConEtherscan(ByVal direccion As String, ByVal idRedEthereum As String, ByVal fechaHoraConsulta As String, ByVal simbolosMoralis As List(Of String), ByRef log As String, ByRef registrosGrabados As Integer)
        Try
            Dim urlAPI As String = "https://api.etherscan.io/v2/api?chainid=1&"
            Dim url As String = $"{urlAPI}module=account&action=tokentx&address={direccion}&page=1&offset=200&sort=desc&apikey={API_ETHERSCAN}"
            '
            log &= vbCrLf & "  → Complementando Ethereum con Etherscan V2..." & vbCrLf
            '
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(url))
            Dim item As JsonNode = JsonNode.Parse(json)
            '
            If item("status") Is Nothing OrElse item("status").ToString() <> "1" Then
                log &= "  → Etherscan: sin datos" & vbCrLf
                Return
            End If
            '
            ' Calcular saldo neto por token
            Dim saldos As New Dictionary(Of String, Double)
            Dim infoTokens As New Dictionary(Of String, String) ' contrato → simbolo
            '
            For Each t As JsonNode In item("result").AsArray()
                Dim contrato As String = If(t("contractAddress") Is Nothing, "", t("contractAddress").ToString().ToLower())
                Dim simbolo As String = If(t("tokenSymbol") Is Nothing, "?", t("tokenSymbol").ToString())
                Dim decimales As Integer = 18
                Try : decimales = CInt(t("tokenDecimal").ToString()) : Catch : End Try
                '
                Dim cantidadRaw As Double = 0
                Try : cantidadRaw = Double.Parse(t("value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                '
                Dim cantidad As Double = cantidadRaw / Math.Pow(10, decimales)
                Dim desde As String = If(t("from") Is Nothing, "", t("from").ToString().ToLower())
                Dim hacia As String = If(t("to") Is Nothing, "", t("to").ToString().ToLower())
                Dim dirLower As String = direccion.ToLower()
                '
                If hacia = dirLower Then
                    If Not saldos.ContainsKey(contrato) Then saldos(contrato) = 0
                    saldos(contrato) += cantidad
                End If
                If desde = dirLower Then
                    If Not saldos.ContainsKey(contrato) Then saldos(contrato) = 0
                    saldos(contrato) -= cantidad
                End If
                '
                If Not infoTokens.ContainsKey(contrato) Then
                    infoTokens(contrato) = simbolo
                End If
            Next
            '
            ' Agregar solo tokens con saldo > 0 que Moralis NO devolvió
            For Each kvp As KeyValuePair(Of String, Double) In saldos
                If kvp.Value > 0.000001 AndAlso infoTokens.ContainsKey(kvp.Key) Then
                    Dim simbolo As String = infoTokens(kvp.Key)
                    If Not simbolosMoralis.Contains(simbolo.ToUpper()) Then
                        log &= $"  → Etherscan complementa: {simbolo} {kvp.Value:F8}" & vbCrLf
                        AgregarBilleteraSaldo(direccion, idRedEthereum, fechaHoraConsulta, simbolo, kvp.Value, ObtenerPrecioUSD(simbolo))
                        registrosGrabados += 1
                    End If
                End If
            Next
            '
        Catch ex As Exception
            log &= $"  → Etherscan ERROR: {ex.Message}" & vbCrLf
        End Try
    End Sub
    '
    '
    ' ============================================================
    '  Consulta el historial de transacciones on-chain de una
    '  billetera en todas las redes EVM activas con chainHex
    '  y guarda los resultados en TransaccionesOnChain.txt
    ' ============================================================
    Public Function ConsultarTransacciones_TodasLasRedes(ByVal direccion As String) As String
        Dim redesConsultadas As Integer = 0
        Dim registrosGrabados As Integer = 0
        Dim log As String = $"=== Transacciones {DateTime.Now.ToString("yyyyMMdd HHmm")} ===" & vbCrLf
        log &= $"Dirección: {direccion}" & vbCrLf & vbCrLf
        '
        For r As Integer = 1 To Matriz_RedesTF
            Dim chainHex As String = Matriz_Redes(r, 19)
            Dim esEVM As String = Matriz_Redes(r, 8)
            Dim nombreRed As String = Matriz_Redes(r, 3)
            '
            If esEVM.ToUpper() <> "SI" Then Continue For
            If String.IsNullOrWhiteSpace(chainHex) OrElse chainHex = "0" Then Continue For
            '
            log &= $"Red: {nombreRed} | chain={chainHex}" & vbCrLf
            '
            Try
                Dim txs As List(Of TransaccionOnChain) = ObtenerTransacciones(chainHex, direccion, log)
                '
                For Each tx As TransaccionOnChain In txs
                    ' Evitar duplicados por hash + red
                    Dim esDuplicado As Boolean = False
                    For i As Integer = 1 To Matriz_TransaccionesOnChainTF
                        If Matriz_TransaccionesOnChain(i, 0) = direccion AndAlso
                           Matriz_TransaccionesOnChain(i, 1) = chainHex AndAlso
                           Matriz_TransaccionesOnChain(i, 3) = tx.Hash Then
                            esDuplicado = True
                            Exit For
                        End If
                    Next i
                    If esDuplicado Then Continue For
                    '
                    Dim fila As Integer = AgrandarMatriz(Matriz_TransaccionesOnChain, Matriz_TransaccionesOnChainTF, Matriz_TransaccionesOnChainTC)
                    Matriz_TransaccionesOnChain(fila, 0) = direccion
                    Matriz_TransaccionesOnChain(fila, 1) = chainHex
                    Matriz_TransaccionesOnChain(fila, 2) = tx.FechaHora
                    Matriz_TransaccionesOnChain(fila, 3) = tx.Hash
                    Matriz_TransaccionesOnChain(fila, 4) = tx.Tipo
                    Matriz_TransaccionesOnChain(fila, 5) = tx.Desde
                    Matriz_TransaccionesOnChain(fila, 6) = tx.Hacia
                    Matriz_TransaccionesOnChain(fila, 7) = tx.Simbolo
                    Matriz_TransaccionesOnChain(fila, 8) = tx.Valor.ToString("F8", Globalization.CultureInfo.InvariantCulture)
                    Matriz_TransaccionesOnChain(fila, 9) = tx.Resumen
                    registrosGrabados += 1
                Next
                '
                log &= $"  → {txs.Count} transacciones obtenidas" & vbCrLf
                redesConsultadas += 1
                '
            Catch ex As Exception
                log &= $"  → ERROR: {ex.Message}" & vbCrLf
            End Try
            '
            Threading.Thread.Sleep(300)
        Next r
        '
        If registrosGrabados > 0 Then
            Guardar_Matrices("TransaccionesOnChain")
            log &= $"Guardado OK — {registrosGrabados} registros nuevos" & vbCrLf
        End If
        '
        Dim rutaLog As String = RutaLocal & "\log_transacciones.txt"
        If ModoDebug Then System.IO.File.WriteAllText(rutaLog, log, System.Text.Encoding.UTF8)
        Return $"Redes: {redesConsultadas} | Registros nuevos: {registrosGrabados}"
    End Function
    '
    ' ------------------------------------------------------------
    '  Llama al endpoint /wallets/{address}/history de Moralis
    '  y parsea cada entrada del array result
    ' ------------------------------------------------------------
    Private Function ObtenerTransacciones(ByVal chainHex As String, ByVal direccion As String, ByRef log As String) As List(Of TransaccionOnChain)
        Dim resultado As New List(Of TransaccionOnChain)
        '
        Try
            Dim url As String = $"https://deep-index.moralis.io/api/v2.2/wallets/{direccion}/history?chain={chainHex}&limit=100"
            log &= $"    URL: {url}" & vbCrLf
            '
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            client.Headers.Add("X-API-Key", API_MORALIS)
            client.Headers.Add("accept", "application/json")
            '
            Dim json As String = client.DownloadString(New Uri(url))
            Dim root As JsonNode = JsonNode.Parse(json)
            Dim items As JsonArray = root("result").AsArray()
            '
            For Each item As JsonNode In items
                Dim tx As New TransaccionOnChain()
                '
                ' Fecha desde block_timestamp (ISO 8601 → yyyyMMdd HHmm)
                Dim tsRaw As String = If(item("block_timestamp") Is Nothing, "", item("block_timestamp").ToString())
                Try
                    Dim dtUTC As DateTime = DateTime.Parse(tsRaw, Nothing, Globalization.DateTimeStyles.RoundtripKind)
                    Dim dtChile As DateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dtUTC, "Pacific SA Standard Time")
                    tx.FechaHora = dtChile.ToString("yyyyMMdd HHmm")
                Catch
                    tx.FechaHora = tsRaw
                End Try
                '
                tx.Hash = If(item("hash") Is Nothing, "", item("hash").ToString())
                tx.Tipo = If(item("category") Is Nothing, "other", item("category").ToString())
                tx.Desde = If(item("from_address") Is Nothing, "", item("from_address").ToString())
                tx.Hacia = If(item("to_address") Is Nothing, "", item("to_address").ToString())
                tx.Resumen = If(item("summary") Is Nothing, "", item("summary").ToString())
                '
                ' Intentar leer erc20_transfers primero
                Dim erc20 As JsonArray = Nothing
                Try : erc20 = item("erc20_transfers").AsArray() : Catch : End Try
                '
                If erc20 IsNot Nothing AndAlso erc20.Count > 0 Then
                    ' Una transacción puede tener varios tokens — registrar el primero relevante
                    For Each t As JsonNode In erc20
                        Dim simbolo As String = If(t("token_symbol") Is Nothing, "?", t("token_symbol").ToString())
                        Dim valorFmt As Double = 0
                        Try : valorFmt = Double.Parse(t("value_formatted").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                        '
                        Dim txERC20 As New TransaccionOnChain With {
                            .FechaHora = tx.FechaHora,
                            .Hash = tx.Hash,
                            .Tipo = tx.Tipo,
                            .Desde = If(t("from_address") Is Nothing, tx.Desde, t("from_address").ToString()),
                            .Hacia = If(t("to_address") Is Nothing, tx.Hacia, t("to_address").ToString()),
                            .Simbolo = simbolo,
                            .Valor = valorFmt,
                            .Resumen = tx.Resumen
                        }
                        resultado.Add(txERC20)
                    Next
                Else
                    ' Transacción nativa (ETH, BNB, etc.)
                    Dim valorWei As Double = 0
                    Try : valorWei = Double.Parse(item("value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                    tx.Valor = valorWei / 1e18
                    tx.Simbolo = "NATIVE"
                    resultado.Add(tx)
                End If
            Next
            '
        Catch ex As Exception
            log &= $"    EXCEPCION: {ex.GetType().Name} | {ex.Message}" & vbCrLf
        End Try
        '
        Return resultado
    End Function
    '
    ' ------------------------------------------------------------
    '  Clase auxiliar para transacciones on-chain
    ' ------------------------------------------------------------
    Public Class TransaccionOnChain
        Public Property FechaHora As String
        Public Property Hash As String
        Public Property Tipo As String
        Public Property Desde As String
        Public Property Hacia As String
        Public Property Simbolo As String
        Public Property Valor As Double
        Public Property Resumen As String
    End Class
    '
    '
    '

    ' ============================================================
    '  Clase resultado Pool DeFi
    ' ============================================================
    Public Class PoolDeFiResultado
        Public Property Token1_Simbolo As String = ""
        Public Property Token1_Cantidad As Double = 0
        Public Property Token1_USD As Double = 0
        Public Property Token2_Simbolo As String = ""
        Public Property Token2_Cantidad As Double = 0
        Public Property Token2_USD As Double = 0
        Public Property Fees_USD As Double = 0
        Public Property Total_USD As Double = 0
    End Class
    '
    ' ============================================================
    '  Consulta posiciones Uniswap V3 via Moralis
    '  Endpoint: /wallets/{address}/defi/uniswap-v3/positions?chain=0x1
    '  Devuelve la primera posicion activa encontrada
    ' ============================================================
    Public Function ConsultarPool_UniswapV3(ByVal direccion As String) As PoolDeFiResultado
        Dim resultado As New PoolDeFiResultado()
        Dim log As String = ""
        '
        Try
            Dim url As String = $"https://deep-index.moralis.io/api/v2.2/wallets/{direccion}/defi/uniswap-v3/positions?chain=0x1"
            log &= $"URL: {url}" & vbCrLf
            '
            Dim client As New System.Net.WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            client.Headers.Add("X-API-Key", API_MORALIS)
            client.Headers.Add("accept", "application/json")
            '
            Dim json As String = client.DownloadString(New Uri(url))
            log &= $"RAW: {json.Substring(0, Math.Min(300, json.Length))}..." & vbCrLf
            '
            Dim root As JsonNode = JsonNode.Parse(json)
            Dim positions As JsonArray = root.AsArray()
            '
            If positions Is Nothing OrElse positions.Count = 0 Then
                log &= "Sin posiciones Uniswap V3" & vbCrLf
                Return Nothing
            End If
            '
            ' Tomar la primera posicion activa
            Dim pos As JsonNode = positions(0)
            Dim tokens As JsonArray = pos("position")("tokens").AsArray()
            '
            Dim supplied As New List(Of JsonNode)
            Dim rewards As New List(Of JsonNode)
            For Each t As JsonNode In tokens
                Dim tt As String = If(t("token_type") Is Nothing, "", t("token_type").ToString())
                If tt = "supplied" Then supplied.Add(t)
                If tt = "reward" Then rewards.Add(t)
            Next
            '
            ' Token 1
            If supplied.Count >= 1 Then
                resultado.Token1_Simbolo = If(supplied(0)("symbol") Is Nothing, "?", supplied(0)("symbol").ToString())
                Try : resultado.Token1_Cantidad = Double.Parse(supplied(0)("balance_formatted").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                Try : resultado.Token1_USD = Double.Parse(supplied(0)("usd_value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            End If
            '
            ' Token 2
            If supplied.Count >= 2 Then
                resultado.Token2_Simbolo = If(supplied(1)("symbol") Is Nothing, "?", supplied(1)("symbol").ToString())
                Try : resultado.Token2_Cantidad = Double.Parse(supplied(1)("balance_formatted").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                Try : resultado.Token2_USD = Double.Parse(supplied(1)("usd_value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            End If
            '
            ' Fees (rewards)
            Dim feesTotal As Double = 0
            For Each r As JsonNode In rewards
                Dim feeUSD As Double = 0
                Try : feeUSD = Double.Parse(r("usd_value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                feesTotal += feeUSD
            Next
            resultado.Fees_USD = feesTotal
            '
            ' Total USD
            Try
                resultado.Total_USD = Double.Parse(pos("position")("balance_usd").ToString(), Globalization.CultureInfo.InvariantCulture)
            Catch
                resultado.Total_USD = resultado.Token1_USD + resultado.Token2_USD
            End Try
            '
        Catch ex As Exception
            log &= $"ERROR Uniswap V3: {ex.Message}" & vbCrLf
            If ModoDebug Then System.IO.File.WriteAllText(RutaLocal & "\log_pool_uniswap.txt", log, System.Text.Encoding.UTF8)
            Return Nothing
        End Try
        '
        If ModoDebug Then System.IO.File.WriteAllText(RutaLocal & "\log_pool_uniswap.txt", log, System.Text.Encoding.UTF8)
        Return resultado
    End Function
    '
    ' ============================================================
    '  Consulta posiciones Beefy Finance
    '  Endpoint: https://balance-api.beefy.finance/api/v1/holders/{address}/latest-balances
    '  Suma todos los vaults activos y devuelve el total USD
    ' ============================================================
    Public Function ConsultarPool_Beefy(ByVal direccion As String) As PoolDeFiResultado
        Dim resultado As New PoolDeFiResultado()
        Dim log As String = ""
        '
        Try
            Dim url As String = $"https://balance-api.beefy.finance/api/v1/holders/{direccion}/latest-balances"
            log &= $"URL: {url}" & vbCrLf
            '
            Dim client As New System.Net.WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            client.Headers.Add("accept", "application/json")
            '
            Dim json As String = client.DownloadString(New Uri(url))
            log &= $"RAW: {json.Substring(0, Math.Min(300, json.Length))}..." & vbCrLf
            '
            Dim root As JsonNode = JsonNode.Parse(json)
            Dim vaults As JsonArray = root.AsArray()
            '
            If vaults Is Nothing OrElse vaults.Count = 0 Then
                log &= "Sin posiciones Beefy" & vbCrLf
                Return Nothing
            End If
            '
            ' Sumar todos los vaults activos
            Dim totalUSD As Double = 0
            Dim primerVault As String = ""
            Dim primerBalance As Double = 0
            '
            For Each v As JsonNode In vaults
                Dim usdVal As Double = 0
                Try : usdVal = Double.Parse(v("usd_value").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                If usdVal > 0 Then
                    totalUSD += usdVal
                    If primerVault = "" Then
                        primerVault = If(v("vault_id") Is Nothing, "vault", v("vault_id").ToString())
                        Try : primerBalance = Double.Parse(v("balance").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                    End If
                End If
            Next
            '
            resultado.Token1_Simbolo = primerVault
            resultado.Token1_Cantidad = primerBalance
            resultado.Token1_USD = totalUSD
            resultado.Token2_Simbolo = ""
            resultado.Token2_Cantidad = 0
            resultado.Token2_USD = 0
            resultado.Fees_USD = 0
            resultado.Total_USD = totalUSD
            '
        Catch ex As Exception
            log &= $"ERROR Beefy: {ex.Message}" & vbCrLf
            If ModoDebug Then System.IO.File.WriteAllText(RutaLocal & "\log_pool_beefy.txt", log, System.Text.Encoding.UTF8)
            Return Nothing
        End Try
        '
        If ModoDebug Then System.IO.File.WriteAllText(RutaLocal & "\log_pool_beefy.txt", log, System.Text.Encoding.UTF8)
        Return resultado
    End Function
    '
    '
    '
End Module