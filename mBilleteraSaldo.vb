'
'
'
Module mBilleteraSaldo
    '
    '
    '
    ' ------------------------------------------------------------
    '  Agrega un registro de saldo a la matriz
    ' ------------------------------------------------------------
    Public Function AgregarBilleteraSaldo(ByVal idBilletera As String, ByVal idRed As String, ByVal fechaHora As String, ByVal simbolo As String, ByVal cantidad As Double, ByVal precioUSD As Double) As Integer
        Dim fila As Integer = AgrandarMatriz(Matriz_BilleteraSaldos, Matriz_BilleteraSaldosTF, Matriz_BilleteraSaldosTC)
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
        Matriz_BilleteraSaldos(fila, 0) = CrearCodigoInterno()
        Matriz_BilleteraSaldos(fila, 1) = idBilletera
        Matriz_BilleteraSaldos(fila, 2) = idRed
        Matriz_BilleteraSaldos(fila, 3) = fechaHora
        Matriz_BilleteraSaldos(fila, 4) = simbolo.ToUpper()
        Matriz_BilleteraSaldos(fila, 5) = idMoneda
        Matriz_BilleteraSaldos(fila, 6) = cantidad.ToString("F8", Globalization.CultureInfo.InvariantCulture)
        Matriz_BilleteraSaldos(fila, 7) = precioUSD.ToString("F6", Globalization.CultureInfo.InvariantCulture)
        Matriz_BilleteraSaldos(fila, 8) = valorUSD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        Return fila
    End Function
    '
    ' ------------------------------------------------------------
    '  Buscar todos los registros de una billetera
    '  Devuelve lista de filas que coinciden
    ' ------------------------------------------------------------
    Public Function BuscarSaldosPorBilletera(ByVal idBilletera As String) As List(Of Integer)
        Dim resultado As New List(Of Integer)
        For i As Integer = 1 To Matriz_BilleteraSaldosTF
            If Matriz_BilleteraSaldos(i, 1) = idBilletera Then
                resultado.Add(i)
            End If
        Next i
        Return resultado
    End Function
    '
    ' ------------------------------------------------------------
    '  Buscar el último saldo registrado de una billetera
    '  (la consulta más reciente por Fecha_Hora)
    ' ------------------------------------------------------------
    Public Function UltimaFechaConsulta(ByVal idBilletera As String) As String
        Dim ultimaFecha As String = ""
        For i As Integer = 1 To Matriz_BilleteraSaldosTF
            If Matriz_BilleteraSaldos(i, 1) = idBilletera Then
                If Matriz_BilleteraSaldos(i, 3) > ultimaFecha Then
                    ultimaFecha = Matriz_BilleteraSaldos(i, 3)
                End If
            End If
        Next i
        Return ultimaFecha
    End Function
    '
    ' ------------------------------------------------------------
    '  Total USD de una billetera en su última consulta
    ' ------------------------------------------------------------
    Public Function TotalUSD_UltimaConsulta(ByVal idBilletera As String) As Double
        Dim ultimaFecha As String = UltimaFechaConsulta(idBilletera)
        If ultimaFecha = "" Then Return 0

        Dim total As Double = 0
        For i As Integer = 1 To Matriz_BilleteraSaldosTF
            If Matriz_BilleteraSaldos(i, 1) = idBilletera AndAlso
               Matriz_BilleteraSaldos(i, 3) = ultimaFecha Then
                Try
                    total += Double.Parse(Matriz_BilleteraSaldos(i, 8), Globalization.CultureInfo.InvariantCulture)
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