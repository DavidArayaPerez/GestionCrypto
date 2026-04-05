'
Imports System.Globalization
Imports System.IO
'
'
'
Module mValorUSD
    '
    '
    '
    Public Matriz_ValorUSD(,) As String
    Public Matriz_ValorUSDTF As Integer
    Public Matriz_ValorUSDTC As Integer = 2
    '
    '   0   Fecha
    '   1   Valor (el separador decimal es el punto, no la coma, para evitar problemas al guardar y leer el valor)
    '
    Public Sub Transformar_Fechas_ValorUSD()
        Dim Matriz(,) As String = Matriz_ValorUSD
        Dim TotalFilas As Integer = Matriz_ValorUSDTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 0))
            If FechaAux > 1 Then Matriz(i, 0) = FechaAux
        Next i
        Matriz_ValorUSD = Matriz
    End Sub
    Public Function Buscar_FechaEnValorUSD(Fecha As String) As Boolean
        'Busca una Fecha en la matriz de ValorUSD, devuelve True si la encuentra, False si no la encuentra
        Dim Fila As Integer = BuscarCualquierValorEnCuaquierMatriz(Matriz_ValorUSD, Matriz_ValorUSDTF, 0, Fecha)
        If Fila > 0 Then Return True
        Return False
    End Function
    Public Sub GuardarValorUSD(Año As Integer)
        'Valida si se guardo la ultima fecha
        If Matriz_ValorUSDTF > 1 Then
            Dim UltimaFecha As String = Matriz_ValorUSD(Matriz_ValorUSDTF, 0)
            If UltimaFecha >= DateTime.Now.ToString("yyyyMMdd") Then Exit Sub
        End If
        '
        '
        Dim RutaArchivo As String = RutaLocal & "\ValorUSD.txt"

        ' 1. Leer datos existentes en el archivo (si existe)
        Dim datosExistentes As New Dictionary(Of String, Double)
        If File.Exists(RutaArchivo) Then
            Try
                For Each linea As String In File.ReadAllLines(RutaArchivo)
                    Dim partes() As String = linea.Split(vbTab)
                    If partes.Length = 2 Then
                        Dim valor As Double
                        ' Normalizar: reemplazar coma por punto para parsear correctamente
                        Dim valorTexto As String = partes(1).Trim().Replace(",", ".")
                        If Double.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, valor) Then
                            datosExistentes(partes(0).Trim()) = valor
                        End If
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error al leer el archivo existente: " & ex.Message)
                Return
            End Try
        End If

        ' 2. Obtener datos desde la API para el año indicado
        Dim ValorUSD As List(Of KeyValuePair(Of String, Double)) = APICMF_DOLAR_XML(Año)

        ' 3. Agregar solo los registros que NO existen aún
        Dim agregados As Integer = 0
        For Each par As KeyValuePair(Of String, Double) In ValorUSD
            If Not datosExistentes.ContainsKey(par.Key) Then
                datosExistentes(par.Key) = par.Value
                agregados += 1
            End If
        Next

        If agregados = 0 Then
            'MessageBox.Show($"No hay datos nuevos para agregar del año {Año}.")
            Return
        End If

        ' 4. Guardar todo ordenado por fecha con coma como separador decimal
        Try
            Dim CultureES As New CultureInfo("es-CL") ' Punto miles, coma decimal
            Dim lineasOrdenadas = datosExistentes _
            .OrderBy(Function(kv) kv.Key) _
            .Select(Function(kv) kv.Key & vbTab & kv.Value.ToString("F2", CultureES))

            File.WriteAllLines(RutaArchivo, lineasOrdenadas)
            MessageBox.Show($"Se agregaron {agregados} registros del año {Año}.")
        Catch ex As Exception
            MessageBox.Show("Error al guardar el valor del dólar: " & ex.Message)
        End Try
    End Sub
    '
    '
    '
End Module
