'
'
'
Module mBilleteraSaldo
    '
    '
    '
    Public Matriz_BilleteraSaldo(,) As String
        Public Matriz_BilleteraSaldosTF As Integer
        Public Matriz_BilleteraSaldosTC As Integer = 9
    '
    '   0   ID_Registro         Código único  ej: SBWX20260405160700001
    '   1   ID_Billetera        Código de Matriz_Billeteras (columna 0) → dirección 0x...
    '   2   ID_Red              ID_Interno de Matriz_Redes
    '   3   Fecha_Hora          yyyyMMdd HHmm  ej: 20260405 1607
    '   4   Simbolo             BTC, ETH, USDT...
    '   5   ID_Moneda           ID_Moneda de Matriz_Monedas (para cruzar datos)
    '   6   Cantidad            Saldo de la moneda en esa billetera
    '   7   Precio_USD          Precio unitario de la moneda en USD al momento de consulta
    '   8   Valor_USD           Cantidad * Precio_USD



    ' ------------------------------------------------------------
    '  Agrega un registro de saldo a la matriz
    ' ------------------------------------------------------------
    Public Function AgregarBilleteraSaldo(ByVal idBilletera As String, ByVal idRed As String, ByVal fechaHora As String, ByVal simbolo As String, ByVal cantidad As Double, ByVal precioUSD As Double) As Integer
        Dim fila As Integer = AgrandarMatriz(Matriz_BilleteraSaldo, Matriz_BilleteraSaldosTF, Matriz_BilleteraSaldosTC)
        Dim valorUSD As Double = cantidad * precioUSD
        '
        ' Buscar ID_Moneda en Matriz_Monedas por símbolo
        Dim idMoneda As String = "0"
        For m As Integer = 1 To Matriz_MonedasTF
            If Matriz_Monedas(m, 2).ToUpper() = simbolo.ToUpper() Then
                idMoneda = Matriz_Monedas(m, 0)
                Exit For
            End If
        Next m
        '
        Matriz_BilleteraSaldo(fila, 0) = CrearCodigoInterno()
        Matriz_BilleteraSaldo(fila, 1) = idBilletera
        Matriz_BilleteraSaldo(fila, 2) = idRed
        Matriz_BilleteraSaldo(fila, 3) = fechaHora
        Matriz_BilleteraSaldo(fila, 4) = simbolo.ToUpper()
        Matriz_BilleteraSaldo(fila, 5) = idMoneda
        Matriz_BilleteraSaldo(fila, 6) = cantidad.ToString("F8", Globalization.CultureInfo.InvariantCulture)
        Matriz_BilleteraSaldo(fila, 7) = precioUSD.ToString("F6", Globalization.CultureInfo.InvariantCulture)
        Matriz_BilleteraSaldo(fila, 8) = valorUSD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        Return fila
    End Function

    ' ------------------------------------------------------------
    '  Buscar todos los registros de una billetera
    '  Devuelve lista de filas que coinciden
    ' ------------------------------------------------------------
    Public Function BuscarSaldosPorBilletera(ByVal idBilletera As String) As List(Of Integer)
            Dim resultado As New List(Of Integer)
            For i As Integer = 1 To Matriz_BilleteraSaldosTF
                If Matriz_BilleteraSaldo(i, 1) = idBilletera Then
                    resultado.Add(i)
                End If
            Next i
            Return resultado
        End Function

        ' ------------------------------------------------------------
        '  Buscar el último saldo registrado de una billetera
        '  (la consulta más reciente por Fecha_Hora)
        ' ------------------------------------------------------------
        Public Function UltimaFechaConsulta(ByVal idBilletera As String) As String
            Dim ultimaFecha As String = ""
            For i As Integer = 1 To Matriz_BilleteraSaldosTF
                If Matriz_BilleteraSaldo(i, 1) = idBilletera Then
                    If Matriz_BilleteraSaldo(i, 3) > ultimaFecha Then
                        ultimaFecha = Matriz_BilleteraSaldo(i, 3)
                    End If
                End If
            Next i
            Return ultimaFecha
        End Function

        ' ------------------------------------------------------------
        '  Total USD de una billetera en su última consulta
        ' ------------------------------------------------------------
        Public Function TotalUSD_UltimaConsulta(ByVal idBilletera As String) As Double
            Dim ultimaFecha As String = UltimaFechaConsulta(idBilletera)
            If ultimaFecha = "" Then Return 0

            Dim total As Double = 0
            For i As Integer = 1 To Matriz_BilleteraSaldosTF
                If Matriz_BilleteraSaldo(i, 1) = idBilletera AndAlso
                   Matriz_BilleteraSaldo(i, 3) = ultimaFecha Then
                    Try
                        total += Double.Parse(Matriz_BilleteraSaldo(i, 8),
                                             Globalization.CultureInfo.InvariantCulture)
                    Catch
                    End Try
                End If
            Next i
            Return total
        End Function
    '
    '
    '
End Module