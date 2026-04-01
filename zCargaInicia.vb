'
'
'
Imports System.IO
'
'
'
Module zCargaInicia
    '
    '
    '
    Public zCargaInicialTXT As String = Application.StartupPath & "\zCargaInicial.txt"
    Public zParametrosTXT As String = Application.StartupPath & "\zParametros.txt"
    '
    '
    '

    Public Sub Parametros()
        'Dim NombreArchivo As String =
        'Dim CarpetaInicio As String = Application.StartupPath
        'Dim RutaArchivo As String = CarpetaInicio & "\" & NombreArchivo
        Dim Lineas(), ArchivoFinal(), Elementos(), Linea, Texto As String
        Dim Fila, Total, Contador As Integer
        Dim ACTUALIZACION_DOLAR As String = "SI"
        '
        If Not ExisteArchivo(zParametrosTXT) Then
            Texto = "El archivo de configuracion no fue encontrado" & vbCrLf
            Texto &= zParametrosTXT & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        Lineas = File.ReadAllLines(zParametrosTXT)
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
        GuardarParametros(zParametrosTXT, ArchivoFinal)
    End Sub


    '
    '
    '
End Module
