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
    Public API_CMF, API_COINGEKO, API_ETHERSCAN, API_MORALIS As String
    Public RutaLocal As String              'Variable para trabajar en forma local, o forma nativa.
    '
    '
    '

    Public Sub Parametros()
        Dim Lineas(), ArchivoFinal(), Elementos(), Linea, Texto, Columna1, Columna2 As String
        Dim Fila, Total As Integer
        '
        If Not File.Exists(zParametrosTXT) Then
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
        '
        For Fila = 0 To Total - 1
            Linea = Lineas(Fila)
            If Linea.Trim = "" Then Continue For
            '
            Elementos = Linea.Split(vbTab)
            Columna1 = Elementos(0)
            Columna2 = Elementos(1)
            Select Case Columna1
                Case "RUTA_LOCAL"
                    RutaLocal = Columna2
                    ArchivoFinal(0) = Columna1 & vbTab & Columna2   'Fila 0
                    '
                Case "API_CMF"
                    API_CMF = Columna2
                    ArchivoFinal(1) = Columna1 & vbTab & Columna2   'Fila 1
                    '
                Case "API_COINGEKO"
                    API_COINGEKO = Columna2
                    ArchivoFinal(2) = Columna1 & vbTab & Columna2   'Fila 2
                    '
                Case "API_ETHERSCAN"
                    API_ETHERSCAN = Columna2
                    ArchivoFinal(3) = Columna1 & vbTab & Columna2   'Fila 3
                    '

                Case "API_MORALIS"
                    API_ETHERSCAN = Columna2
                    ArchivoFinal(4) = Columna1 & vbTab & Columna2   'Fila 4
                    '
            End Select
        Next Fila
        '
        If RutaLocal = "" Then
            Texto = "No fue encontrada la variable RUTA local" & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        GuardarParametros(zParametrosTXT, ArchivoFinal)
    End Sub
    Public Sub GuardarParametros(ByVal RutaArchivo As String, ByVal Arreglo() As String)
        Dim ArregloSinEspacios(1) As String
        Dim Contador As Integer = -1
        For i As Integer = 0 To Arreglo.Length - 1
            If Not Arreglo(i) Is Nothing Then
                Contador += 1
                If Contador > 1 Then ReDim Preserve ArregloSinEspacios(Contador)
                ArregloSinEspacios(Contador) = Arreglo(i)
            End If
        Next i
        '
        File.WriteAllLines(RutaArchivo, ArregloSinEspacios, System.Text.Encoding.UTF8)
        '
        'File.WriteAllText(NombreArchivo, Mensaje)
        'No utilizo WriteAllText porque No agrega saltos de línea automáticamente

        'En cambio la instruccion   File.WriteAllLines(
        'Cada elemento del array se escribe como una línea separada en el archivo
        'Agrega saltos de línea automáticamente entre cada elemento
    End Sub

    '
    '
    '
End Module
