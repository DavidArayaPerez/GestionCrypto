'
Imports System.Windows.Forms
Imports Microsoft.Graph.Models
Imports System.IO
Imports System.Text 'Encoding
'
Module zParametros
    '
    Public RutaPrincipal As String = "C:\zContrato"
    'Public Archivo As String = "Contratos.xlsm"
    Public Matriz(,) As String

    '
    '
    Public Sub Parametros()
        Dim FilePath, Linea, Lineas() As String
        Dim x, Fila, TotalFilas As Integer
        '
        FilePath = AppDomain.CurrentDomain.BaseDirectory & "Gestión Contratos.txt"

        Lineas = File.ReadAllLines(FilePath, Encoding.GetEncoding(1252))
        If Lineas.Length = 0 Then
            MessageBox.Show("El archivo está vacío")
            End
        End If
        '
        TotalFilas = Lineas.Length
        Fila = 0
        Do
            Linea = Lineas(Fila).Trim
            If Len(Linea) > 0 Then
                x = InStr(Linea, "Ruta:")
                If x > 0 Then
                    RutaPrincipal = Mid(Linea, 6)
                    Exit Do
                End If
            End If
            Fila += 1
        Loop While Fila <= TotalFilas
    End Sub
    '
End Module
'
'
'
'