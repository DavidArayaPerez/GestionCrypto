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
    Public Function Buscar_FechaEnValorDolar(Fecha As String) As Boolean
        'Busca una Fecha en la matriz de ValorDolar, devuelve True si la encuentra, False si no la encuentra
        If BuscarCualquierValorEnCuaquierMatriz(Matriz_ValorDolar, Matriz_ValorDolarTF, 0, Fecha) > 0 Then Return True
        Return False
    End Function
    Public Sub GuardarValorDolar(Año As Integer)
        Dim ValorDolar As List(Of KeyValuePair(Of String, Double)) = APICMF_DOLAR_XML(Año)
        Dim RutaArchivo As String = RutaLocal & "\ValorDolar.txt"
        Dim Linea As String
        '
        Try
            Using writer As New StreamWriter(RutaArchivo, False) ' False para sobrescribir el archivo
                For Each par As KeyValuePair(Of String, Double) In ValorDolar
                    Linea = par.Key & vbTab & par.Value.ToString("F2", CultureInfo.InvariantCulture)
                    writer.WriteLine(Linea)
                Next
            End Using
        Catch ex As Exception
            ' Manejar cualquier error de escritura aquí (opcional)
            MessageBox.Show("Error al guardar el valor del dólar: " & ex.Message)
        End Try
    End Sub
    '
    '
    '
End Module
