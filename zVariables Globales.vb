'
'
'
Imports System.IO
'
'
'
Module zVariables_Globales
    Public CulturaEspanola As New System.Globalization.CultureInfo("es-ES")
    'Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ".", .NumberGroupSeparator = ",", .CurrencyDecimalSeparator = ".", .CurrencyGroupSeparator = ","}}
    Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ",", .NumberGroupSeparator = ".", .CurrencyDecimalSeparator = ",", .CurrencyGroupSeparator = "."}}
    Public RutaLocal As String              'Variable para trabajar en forma local, o forma nativa.
    Public HabilitadoParaGrabar As Boolean = False
    Public VariableDeInicio As Boolean = False
    '
    '
    '
    Public Sub Parametros()
        Dim NombreArchivo As String = "zParametros.txt"
        Dim CarpetaInicio As String = Application.StartupPath
        Dim RutaArchivo As String = CarpetaInicio & "\" & NombreArchivo
        Dim Lineas(), ArchivoFinal(), Elementos(), Linea, Texto As String
        Dim Fila, Total, Contador As Integer
        Dim ACTUALIZACION_DOLAR As String = "SI"
        '
        If Not ExisteArchivo(RutaArchivo) Then
            Texto = "El archivo de configuracion no fue encontrado" & vbCrLf
            Texto &= "Nombre Archivo: " & NombreArchivo & vbCrLf
            Texto &= "Ruta: " & CarpetaInicio & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        Lineas = File.ReadAllLines(RutaArchivo)
        Total = Lineas.Length
        If Lineas.Length = 0 Then
            Texto = "El archivo de configuracion No tiene datos" & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        ReDim ArchivoFinal(Total)
        Contador = -1
        '
        For Fila = 0 To Total - 1
            Linea = Lineas(Fila)
            If Linea.Trim = "" Then Continue For
            '
            Elementos = Linea.Split(vbTab)
            Select Case Elementos(0)
                Case "RUTA_LOCAL"
                    RutaLocal = Elementos(1)
                    Contador += 1
                    ArchivoFinal(Contador) = Elementos(0) & vbTab & Elementos(1)
                Case "DOLAR"
                    If ValorUSD = 0 Then
                        ValorUSD = CDbl(Elementos(1))
                        ACTUALIZACION_DOLAR = "NO"
                    End If
                    Contador += 1
                    ArchivoFinal(Contador) = Elementos(0) & vbTab & ValorUSD
            End Select
        Next Fila
        '
        If RutaLocal = "" Then
            Texto = "No fue encontrada la variable RUTA local" & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        ReDim Preserve ArchivoFinal(Contador + 4)
        ArchivoFinal(Contador + 1) = "ULTIMO_INGRESO" & vbTab & Texto_FechaHoraActual()
        ArchivoFinal(Contador + 4) = "ACTUALIZACION_DOLAR" & vbTab & ACTUALIZACION_DOLAR
        GuardarParametros(RutaArchivo, ArchivoFinal)
    End Sub
    Public Sub CargaFormulario()
        F_zPrincipal.Inicializacion()
        F_zPrincipal.ShowDialog()
    End Sub
    '
    '
    '
End Module