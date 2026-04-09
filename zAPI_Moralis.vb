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
    Public Function ConsultarBilletera_TodasLasRedes(ByVal direccion As String) As String
        ' ============================================================
        '  Consulta TODAS las redes EVM activas para una billetera
        '  Usando Moralis como fuente única de datos
        ' ============================================================
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
    Private Function ConsultarTokens(ByVal chainHex As String, ByVal direccion As String, ByRef log As String) As List(Of TokenBalance)
        ' ------------------------------------------------------------
        '  Consulta saldo nativo + tokens ERC-20 en una sola llamada
        ' ------------------------------------------------------------
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
    Private Function ObtenerPrecioUSD(ByVal simbolo As String, Optional ByVal chainHex As String = "") As Double
        ' 1. Buscar en Matriz_Monedas — si hay chainHex, priorizar la moneda de esa red
        Dim idRedBuscada As String = ""
        If chainHex <> "" Then
            For r As Integer = 1 To Matriz_RedesTF
                If Matriz_Redes(r, 19).ToLower() = chainHex.ToLower() Then
                    idRedBuscada = Matriz_Redes(r, 0)
                    Exit For
                End If
            Next r
        End If
        '
        ' Primera pasada: buscar coincidencia exacta de símbolo + red
        If idRedBuscada <> "" Then
            For i As Integer = 1 To Matriz_MonedasTF
                If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() AndAlso
               Matriz_Monedas(i, 10) = idRedBuscada Then
                    Dim precio As Double = 0
                    Try : precio = Double.Parse(Matriz_Monedas(i, 15), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                    If precio > 0 Then Return precio
                End If
            Next i
        End If
        '
        ' Segunda pasada: cualquier coincidencia de símbolo con precio > 0
        Dim precioEncontrado As Double = 0
        For i As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() Then
                Dim precio As Double = 0
                Try : precio = Double.Parse(Matriz_Monedas(i, 15), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
                If precio > 0 Then Return precio
                If precioEncontrado = 0 Then precioEncontrado = precio
            End If
        Next i
        '
        If precioEncontrado > 0 Then Return precioEncontrado
        '
        ' 2. No encontrada con precio — intentar actualizar las que ya están en la matriz
        Dim filaActualizable As Integer = 0
        '
        ' Buscar primero por red si tenemos chainHex
        If idRedBuscada <> "" Then
            For i As Integer = 1 To Matriz_MonedasTF
                If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() AndAlso
               Matriz_Monedas(i, 10) = idRedBuscada Then
                    filaActualizable = i
                    Exit For
                End If
            Next i
        End If
        '
        ' Si no encontró por red, tomar la primera que esté en la matriz
        If filaActualizable = 0 Then
            For i As Integer = 1 To Matriz_MonedasTF
                If Matriz_Monedas(i, 2).ToUpper() = simbolo.ToUpper() Then
                    filaActualizable = i
                    Exit For
                End If
            Next i
        End If
        '
        ' Si ya está en la matriz, actualizar su precio desde CoinGecko y retornar
        If filaActualizable > 0 Then
            Dim slug As String = Matriz_Monedas(filaActualizable, 4)
            If slug <> "" AndAlso slug <> "0" Then
                API_CoinGecko_ActualizaValor(slug)
                Try
                    Return Double.Parse(Matriz_Monedas(filaActualizable, 15), Globalization.CultureInfo.InvariantCulture)
                Catch
                    Return 0
                End Try
            End If
            Return 0
        End If
        '
        ' 3. No está en la matriz — buscar en CoinGecko por símbolo
        Try
            Dim urlBusqueda As String = $"https://api.coingecko.com/api/v3/search?query={simbolo}&x_cg_demo_api_key={API_COINGEKO}"
            Dim client As New WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            Dim json As String = client.DownloadString(New Uri(urlBusqueda))
            Dim root As JsonNode = JsonNode.Parse(json)
            Dim coins As JsonArray = root("coins").AsArray()
            '
            Dim coincidencias As New List(Of String)
            For Each coin As JsonNode In coins
                Dim sym As String = If(coin("symbol") Is Nothing, "", coin("symbol").ToString().ToUpper())
                If sym = simbolo.ToUpper() Then
                    Dim slug As String = If(coin("id") Is Nothing, "", coin("id").ToString())
                    If slug <> "" Then coincidencias.Add(slug)
                End If
            Next
            '
            If coincidencias.Count = 0 Then Return 0
            '
            Dim slugEncontrado As String = ""
            If coincidencias.Count = 1 Then
                slugEncontrado = coincidencias(0)
            Else
                MsgBox("El símbolo '" & simbolo & "' tiene " & coincidencias.Count & " monedas en CoinGecko:" & vbCrLf &
                   String.Join(vbCrLf, coincidencias) & vbCrLf & vbCrLf &
                   "Agrégala manualmente desde F_Monedas con el slug correcto.", MsgBoxStyle.Information, "Símbolo ambiguo")
                Return 0
            End If
            '
            ' Agregar la moneda nueva
            Dim fila As Integer = API_CoinGecko_NuevaMoneda(slugEncontrado)
            If fila < 1 Then Return 0
            Try
                Return Double.Parse(Matriz_Monedas(fila, 15), Globalization.CultureInfo.InvariantCulture)
            Catch
                Return 0
            End Try
            '
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Class TokenBalance
        ' ------------------------------------------------------------
        '  Clase auxiliar
        ' ------------------------------------------------------------
        Public Property Simbolo As String
        Public Property Nombre As String
        Public Property ContractAddress As String
        Public Property Saldo As Double
        Public Property EsNativo As Boolean
    End Class
    Private Sub ComplementarConEtherscan(ByVal direccion As String, ByVal idRedEthereum As String, ByVal fechaHoraConsulta As String, ByVal simbolosMoralis As List(Of String), ByRef log As String, ByRef registrosGrabados As Integer)
        ' ------------------------------------------------------------
        '  Complemento Etherscan: tokens ERC-20 en Ethereum
        '  que Moralis no devolvió
        ' ------------------------------------------------------------
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
    Public Function ConsultarTransacciones_TodasLasRedes(ByVal direccion As String) As String
        ' ============================================================
        '  Consulta el historial de transacciones on-chain de una
        '  billetera en todas las redes EVM activas con chainHex
        '  y guarda los resultados en TransaccionesOnChain.txt
        ' ============================================================
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
    Private Function ObtenerTransacciones(ByVal chainHex As String, ByVal direccion As String, ByRef log As String) As List(Of TransaccionOnChain)
        ' ------------------------------------------------------------
        '  Llama al endpoint /wallets/{address}/history de Moralis
        '  y parsea cada entrada del array result
        ' ------------------------------------------------------------

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
                    tx.Valor = valorWei / 1.0E+18
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
    Public Class TransaccionOnChain
        ' ------------------------------------------------------------
        '  Clase auxiliar para transacciones on-chain
        ' ------------------------------------------------------------
        Public Property FechaHora As String
        Public Property Hash As String
        Public Property Tipo As String
        Public Property Desde As String
        Public Property Hacia As String
        Public Property Simbolo As String
        Public Property Valor As Double
        Public Property Resumen As String
    End Class
    Public Class PoolDeFiResultado
        ' ============================================================
        '  Clase resultado Pool DeFi
        ' ============================================================
        Public Property Token1_Simbolo As String = ""
        Public Property Token1_Cantidad As Double = 0
        Public Property Token1_USD As Double = 0
        Public Property Token2_Simbolo As String = ""
        Public Property Token2_Cantidad As Double = 0
        Public Property Token2_USD As Double = 0
        Public Property Fees_USD As Double = 0
        Public Property Total_USD As Double = 0
    End Class
    Public Function ConsultarPool_UniswapV3(ByVal direccion As String, ByVal link As String) As PoolDeFiResultado
        ' ============================================================
        '  Consulta posiciones Uniswap V3 via Moralis
        '  Endpoint: /wallets/{address}/defi/uniswap-v3/positions?chain=0x1
        '  Devuelve la primera posicion activa encontrada
        ' ============================================================

        Dim resultado As New PoolDeFiResultado()
        Dim url As String = ""
        Dim json As String = ""
        '
        Try
            ' Extraer tokenId del link
            Dim tokenId As String = ""
            Dim partes() As String = link.TrimEnd("/").Split("/"c)
            For i As Integer = partes.Length - 1 To 0 Step -1
                Dim segmento As String = partes(i).Trim()
                If segmento <> "" AndAlso segmento.All(Function(c) Char.IsDigit(c)) Then
                    tokenId = segmento
                    Exit For
                End If
            Next i
            '
            If tokenId = "" Then Return Nothing
            '
            ' Consultar The Graph - Uniswap V3 Subgraph Ethereum mainnet
            url = "https://gateway.thegraph.com/api/" & API_THEGRAPH & "/subgraphs/id/5zvR82QoaXYFyDEKLZ9t6v9adgnptxYpKpSbxtgVENFV"
            '
            Dim query As String = "{""query"":""{ position(id: " & tokenId & ") { id liquidity token0 { symbol } token1 { symbol } depositedToken0 depositedToken1 withdrawnToken0 withdrawnToken1 collectedFeesToken0 collectedFeesToken1 pool { token0Price token1Price } } }""}"
            '
            Dim client As New System.Net.WebClient()
            client.Encoding = System.Text.Encoding.UTF8
            client.Headers.Add("Content-Type", "application/json")
            client.Headers.Add("accept", "application/json")
            '
            json = client.UploadString(New Uri(url), "POST", query)
            System.IO.File.WriteAllText(RutaLocal & "\log_pool_uniswap.txt", json, System.Text.Encoding.UTF8)
            '
            Dim root As JsonNode = JsonNode.Parse(json)
            '
            ' Verificar que position no sea null
            Dim posNode As JsonNode = Nothing
            Try : posNode = root("data")("position") : Catch : End Try
            If posNode Is Nothing Then Return Nothing
            If posNode.GetValueKind() = System.Text.Json.JsonValueKind.Null Then Return Nothing
            '
            ' Calcular saldo actual = depositado - retirado
            Dim dep0 As Double = 0, dep1 As Double = 0
            Dim wit0 As Double = 0, wit1 As Double = 0
            Try : dep0 = Double.Parse(posNode("depositedToken0").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            Try : dep1 = Double.Parse(posNode("depositedToken1").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            Try : wit0 = Double.Parse(posNode("withdrawnToken0").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            Try : wit1 = Double.Parse(posNode("withdrawnToken1").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            '
            Dim cant0 As Double = dep0 - wit0
            Dim cant1 As Double = dep1 - wit1
            '
            ' Fees acumulados
            Dim fee0 As Double = 0, fee1 As Double = 0
            Try : fee0 = Double.Parse(posNode("collectedFeesToken0").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            Try : fee1 = Double.Parse(posNode("collectedFeesToken1").ToString(), Globalization.CultureInfo.InvariantCulture) : Catch : End Try
            '
            ' Simbolos
            Dim sim0 As String = "?"
            Dim sim1 As String = "?"
            Try : sim0 = posNode("token0")("symbol").ToString() : Catch : End Try
            Try : sim1 = posNode("token1")("symbol").ToString() : Catch : End Try
            '
            ' Precios USD desde Matriz_Monedas
            Dim precioUSD0 As Double = ObtenerPrecioUSD(sim0, "0x1")
            Dim precioUSD1 As Double = ObtenerPrecioUSD(sim1, "0x1")
            '
            resultado.Token1_Simbolo = sim0
            resultado.Token1_Cantidad = cant0
            resultado.Token1_USD = cant0 * precioUSD0
            resultado.Token2_Simbolo = sim1
            resultado.Token2_Cantidad = cant1
            resultado.Token2_USD = cant1 * precioUSD1
            resultado.Fees_USD = (fee0 * precioUSD0) + (fee1 * precioUSD1)
            resultado.Total_USD = resultado.Token1_USD + resultado.Token2_USD
            '
        Catch ex As Exception
            System.IO.File.WriteAllText(RutaLocal & "\log_pool_error.txt",
            "TIPO: " & ex.GetType().Name & vbCrLf &
            "MENSAJE: " & ex.Message & vbCrLf &
            "URL: " & url & vbCrLf &
            "JSON: " & json.Substring(0, Math.Min(500, json.Length)), System.Text.Encoding.UTF8)
            Return Nothing
        End Try
        '
        Return resultado
    End Function
    Public Function ConsultarPool_Beefy(ByVal direccion As String) As PoolDeFiResultado
        ' ============================================================
        '  Consulta posiciones Beefy Finance
        '  Endpoint: https://balance-api.beefy.finance/api/v1/holders/{address}/latest-balances
        '  Suma todos los vaults activos y devuelve el total USD
        ' ============================================================

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





