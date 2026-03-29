'
Imports System.Globalization
Imports System.IO
'
'
'
Module mValorDolar
    '
    '
    '
    Public Matriz_ValorDolar(,) As String
    Public Matriz_ValorDolarTF As String
    Public Matriz_ValorDolarTC As String = 1
    '
    '   0   Fecha
    '   1   Valor (el separador decimal es el punto, no la coma, para evitar problemas al guardar y leer el valor)
    '
    Public Sub Transformar_Fechas_ValorDolar()
        Dim Matriz(,) As String = Matriz_ValorDolar
        Dim TotalFilas As Integer = Matriz_ValorDolarTF
        For i As Integer = 1 To TotalFilas
            Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(Matriz(i, 0))
            If FechaAux > 1 Then Matriz(i, 1) = FechaAux
        Next i
        Matriz_ValorDolar = Matriz
    End Sub
    Public Function Buscar_FechaEnValorDolar(Fecha As String) As Boolean
        'Busca una Fecha en la matriz de ValorDolar, devuelve True si la encuentra, False si no la encuentra
        If BuscarCualquierValorEnCuaquierMatriz(Matriz_ValorDolar, Matriz_ValorDolarTF, 0, Fecha) > 0 Then Return True
        Return False
    End Function
    Public Sub GuardarValorDolar(Año As Integer)
        Dim RutaArchivo As String = RutaLocal & "\ValorDolar.txt"

        ' 1. Leer datos existentes en el archivo (si existe)
        Dim datosExistentes As New Dictionary(Of String, Double)
        If File.Exists(RutaArchivo) Then
            Try
                For Each linea As String In File.ReadAllLines(RutaArchivo)
                    Dim partes() As String = linea.Split(vbTab)
                    If partes.Length = 2 Then
                        Dim valor As Double
                        If Double.TryParse(partes(1), NumberStyles.Any, CultureInfo.InvariantCulture, valor) Then
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
        Dim ValorDolar As List(Of KeyValuePair(Of String, Double)) = APICMF_DOLAR_XML(Año)

        ' 3. Agregar solo los registros que NO existen aún
        Dim agregados As Integer = 0
        For Each par As KeyValuePair(Of String, Double) In ValorDolar
            If Not datosExistentes.ContainsKey(par.Key) Then
                datosExistentes(par.Key) = par.Value
                agregados += 1
            End If
        Next

        If agregados = 0 Then
            'MessageBox.Show($"No hay datos nuevos para agregar del año {Año}.")
            Return
        End If

        ' 4. Guardar todo ordenado por fecha
        Try
            Dim lineasOrdenadas = datosExistentes _
            .OrderBy(Function(kv) kv.Key) _
            .Select(Function(kv) kv.Key & vbTab & kv.Value.ToString("F2", CultureInfo.InvariantCulture))

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
