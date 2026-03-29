'
'
'
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text
'
'
'
Module xFunciones_Archivo
    '
    '
    '
    Public Sub AbrirArchivo(ByVal RutaArchivo As String, Optional ConMensaje As Boolean = False)
        If File.Exists(RutaArchivo) Then
            Process.Start("explorer.exe", RutaArchivo)
        Else
            If ConMensaje Then MsgBox("No existe Archivo", MsgBoxStyle.Information, "Archivo")
        End If
    End Sub
    Public Function CopiarArchivo(Origen As String, Destino As String) As Boolean
        If File.Exists(Origen) Then
            Try
                File.Copy(Origen, Destino, True) ' El último parámetro indica sobreescribir si ya existe
                Return True
                '
            Catch ex As Exception
                Return False 'Console.WriteLine("Error al copiar el archivo: " & ex.Message)
            End Try
        Else
            Return False 'Console.WriteLine("El archivo de origen no existe.")
        End If
    End Function
    Public Function ExisteArchivo(Rutacompleta As String, Optional ConMensaje As Boolean = True) As Boolean
        If File.Exists(Rutacompleta) Then
            Return True
        Else
            If ConMensaje Then MsgBox("No se encuentra el archivo" & vbCrLf & Rutacompleta, vbInformation, "No se encuentra Archivo")
            Return False
        End If
    End Function
    Public Sub LlenarListArchivos(Ruta As String, ByRef ObjetoLista As ListBox)
        Dim TotalFilas, i As Integer
        Dim MatrizArchivos As List(Of String)
        Dim Arreglo() As String
        ReDim Arreglo(1)
        Arreglo(0) = 0
        ObjetoLista.Items.Clear()
        '
        If Directory.Exists(Ruta) Then
            MatrizArchivos = Directory.GetFiles(Ruta, "*", SearchOption.TopDirectoryOnly).ToList()
            If MatrizArchivos.Count < 1 Then Exit Sub
            '
            TotalFilas = MatrizArchivos.Count
            ReDim Arreglo(TotalFilas)
            Arreglo(0) = TotalFilas
            For i = 0 To TotalFilas - 1
                Dim RutaLocal As String = MatrizArchivos(i)
                Dim NombreArchivo As String = Mid(RutaLocal, Len(Ruta) + 2)
                If Saltarse_Todos(NombreArchivo) Then Continue For
                '
                'If Saltarse_InformeContrato(NombreArchivo) Then Continue For
                'If Saltarse_ExtencionRTF(NombreArchivo) Then Continue For
                'Arreglo(i) = NombreArchivo
                '
                ObjetoLista.Items.Add(NombreArchivo)
            Next i
        End If
        '                                                           'RUTA = C:\ZCONTRATO\Solicitudes\KIOSCO\Informes\202501
        'NombreArchivo = Path.GetDirectoryName(Ruta)                'C:\ZCONTRATO\Solicitudes\KIOSCO\Informes
        'NombreArchivo = Path.GetFileNameWithoutExtension(Ruta)     '202501
        'NombreArchivo = Path.GetExtension(Ruta)                    '""
        'NombreArchivo = Path.GetFileName(Ruta)                     '202501
        'NombreArchivo = Path.GetPathRoot(Ruta)                     'C:\
    End Sub
    Private Function Saltarse_Todos(Texto As String) As Boolean             'Si lo encuentra es TRUE
        If Saltarse_InformeContrato(Texto) Then Return True
        If Saltarse_ExtencionRTF(Texto) Then Return True
        Return False
    End Function
    Private Function Saltarse_InformeContrato(Texto As String) As Boolean   'Si lo encuentra es TRUE
        Dim x As Integer
        Dim SW As Boolean = True
        x = InStr(Texto, "Informe Contrato")
        If x = 0 Then SW = False
        Return SW
    End Function
    Private Function Saltarse_ExtencionRTF(Texto As String) As Boolean      'Si lo encuentra es TRUE
        Dim x As Integer
        Dim SW As Boolean = True
        x = InStr(Texto, ".rtf")
        If x = 0 Then SW = False
        Return SW
    End Function

    '
    Public Sub CargarTXT(ByVal NombreMatriz As String, ByRef Matriz(,) As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        If NombreMatriz = Nothing Then Exit Sub
        '
        Dim Ruta As String = RutaLocal & "\TxT\" & NombreMatriz & ".txt"
        Dim ColMatriz As Integer
        '
        If Not ExisteArchivo(Ruta) Then End
        Dim Lineas() As String = File.ReadAllLines(Ruta, Encoding.GetEncoding(1252))
        '
        Dim TotalFilas As Integer = Lineas.Length
        If TotalFilas = 0 Then
            MsgBox("El archivo está vacío", vbCritical, NombreProcedimiento)
            End
        End If
        '
        CargaColumnasMatriz(NombreMatriz, ColMatriz)                                            'NUMERO DE COLUMNAS
        ReDim Matriz(TotalFilas + 1, ColMatriz)
        '
        Dim i, j, Contador As Integer
        Contador = -1
        For i = 0 To TotalFilas - 1
            Dim Linea = Lineas(i).Trim
            If Linea = "" Then Continue For 'Si la línea está vacía, continuar con la siguiente iteración
            '
            Dim Elementos() As String = Linea.Split(vbTab)
            If Elementos.Length > ColMatriz Then
                'Si hay mas columnas, se ignoran las columnas extras
            ElseIf Elementos.Length < ColMatriz Then
                'Si hay menos columnas, se rellenan con espacios en blanco
                For j = Elementos.Length To ColMatriz
                    Elementos = Elementos.Concat(New String() {""}).ToArray()
                Next j
            End If
            '
            RellenarElementos(Elementos)
            Contador += 1
            For j = 0 To ColMatriz - 1
                Matriz(Contador, j) = Elementos(j).Trim()
            Next j
        Next i
        '
        CargaFilasMatriz(NombreMatriz, Contador)
    End Sub
    '
    Public Sub AbrirArchivoRTF_TraspasarTexto(ByVal RutaArchivoRTF As String, ByRef T As String)
        If Not File.Exists(RutaArchivoRTF) Then
            T = ""
            Exit Sub
        End If
        '
        Using rtb As New RichTextBox()
            rtb.LoadFile(RutaArchivoRTF, RichTextBoxStreamType.RichText)
            T = rtb.Text
        End Using
    End Sub
    '
    Private Sub CargaColumnasMatriz(ByVal NombreMatriz As String, ByRef ColMatriz As Integer)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Select Case NombreMatriz
            Case "Solicitudes" : ColMatriz = Matriz_SolicitudesTC
            Case "Expedientes" : ColMatriz = Matriz_ExpedientesTC
            Case "Cuotas" : ColMatriz = Matriz_CuotasTC
            Case "Documento_RFI" : ColMatriz = Matriz_RFITC
            Case "Documento_Contraloria" : ColMatriz = Matriz_ContraloriaTC
            Case "Documento_Contrato" : ColMatriz = Matriz_ContratoTC
            Case "Documento_Nota" : ColMatriz = Matriz_NotaTC
            Case "Documento_OrdenCompra" : ColMatriz = Matriz_OrdenCompraTC
            Case "Documento_Resolucion" : ColMatriz = Matriz_ResolucionTC
            Case "Documento_Boleta" : ColMatriz = Matriz_BoletaTC
            Case "Variables" : ColMatriz = Matriz_VariablesTC
            Case "Pares" : ColMatriz = Matriz_ParesTC
            Case "Solicitudes_Detalle" : ColMatriz = Matriz_SolicitudesDetalleTC
            Case "Cuotas_Detalle" : ColMatriz = Matriz_CuotaDetalleTC
            Case Else
                ColMatriz = 0
                MsgBox("Sin Clasificar", vbCritical, NombreProcedimiento)
        End Select
    End Sub
    '
    Public Sub CargaFilasMatriz(ByVal NombreMatriz As String, ByVal Filas As Integer)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Select Case NombreMatriz
            Case "Solicitudes" : Matriz_SolicitudesTF = Filas
            Case "Expedientes" : Matriz_ExpedientesTF = Filas
            Case "Cuotas" : Matriz_CuotasTF = Filas
            Case "Documento_RFI" : Matriz_RFITF = Filas
            Case "Documento_Contraloria" : Matriz_ContraloriaTF = Filas
            Case "Documento_Contrato" : Matriz_ContratoTF = Filas
            Case "Documento_Nota" : Matriz_NotaTF = Filas
            Case "Documento_OrdenCompra" : Matriz_OrdenCompraTF = Filas
            Case "Documento_Resolucion" : Matriz_ResolucionTF = Filas
            Case "Documento_Boleta" : Matriz_BoletaTF = Filas
            Case "Variables" : Matriz_VariablesTF = Filas
            Case "Pares" : Matriz_ParesTF = Filas
            Case "Solicitudes_Detalle" : Matriz_SolicitudesDetalleTF = Filas
            Case "Cuotas_Detalle" : Matriz_CuotaDetalleTF = Filas
            Case Else
                MsgBox("Sin Clasificar", vbCritical, NombreProcedimiento)
        End Select
    End Sub
    '
    Public Sub CompararMatriz_TXT(NombreMatriz As String, Codigo As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        If NombreMatriz = Nothing Then Exit Sub
        '
        '---------------------------------------------------------------------------------------------------------------------
        'Abre el TXT y extrae la FILA del CODIGO del REGISTRO
        Dim Ruta As String = RutaLocal & "\TxT\" & NombreMatriz & ".txt"
        If Not ExisteArchivo(Ruta) Then Exit Sub
        '
        Dim Lineas() As String = File.ReadAllLines(Ruta, Encoding.GetEncoding(1252))
        Dim TotalFilas As Integer, TotalColumnas As Integer
        '
        TotalFilas = Lineas.Length
        If TotalFilas = 0 Then Exit Sub
        '
        Dim Encabezado As String = Lineas(0).Trim                       'Copia Encabezado para luego insertarto en el TXT de Detalle
        '
        Dim i, j As Integer
        Dim T1 As String = ""
        For i = 1 To TotalFilas - 1
            Dim Linea = Lineas(i).Trim
            If Linea = "" Then Continue For                             'Si la línea está vacía, continuar con la siguiente iteración
            Dim Elementos() As String = Linea.Split(vbTab)
            If Codigo = Elementos(0).Trim() Then
                T1 = Linea                                              'Copia la Linea Original
                Exit For
            End If
        Next i
        '
        If T1 = "" Then
            'No se encontro el registro en el TXT, es posible que sea un registro nuevo
            'Por ende no hay diferencia que grabar.
            Exit Sub
        End If
        '
        '
        '
        '---------------------------------------------------------------------------------------------------------------------
        'Genera una Matriz Auxiliar con la Matriz original para buscar el dato que AHORA esta grabado.
        Dim MatrizActual(,) As String
        ReDim MatrizActual(1, 1) 'Para evitar que el Compilador alege
        AsignarMatrizAuxiliar(NombreMatriz, MatrizActual, TotalFilas, TotalColumnas)
        Dim T2 As String = ""
        For i = 1 To TotalFilas
            If Codigo = MatrizActual(i, 0) Then
                T2 = MatrizActual(i, 0)
                For j = 1 To TotalColumnas - 1
                    T2 &= vbTab & MatrizActual(i, j)        'Copia la Linea Actual
                Next j
                Exit For
            End If
        Next i
        '
        '
        '
        If T1 <> T2 Then
            Dim FechaActual As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            Dim ArregloMatrizDiferencia() As String
            ReDim ArregloMatrizDiferencia(3)
            '
            ArregloMatrizDiferencia(0) = "Fecha" & vbTab & "Orignal/Reemplazo" & vbTab & Encabezado
            ArregloMatrizDiferencia(1) = "_______________" & vbTab & "Orignal__________" & vbTab & T1
            ArregloMatrizDiferencia(2) = FechaActual & vbTab & "Reemplazo________" & vbTab & T2
            '
            Dim RutaArchivoCopia As String = Path.Combine(RutaLocal, "TxT\Bak_Diferencia\" & NombreMatriz & ".txt")
            File.AppendAllLines(RutaArchivoCopia, ArregloMatrizDiferencia, Encoding.GetEncoding(1252))
        End If
    End Sub
    '
    Public Sub Guardar_Matrices(ByVal NombreMatriz As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        If NombreMatriz = Nothing Then Exit Sub
        'Hace un respaldo del archivo actual
        BAK_Archivos_TXT(NombreMatriz)
        '
        Dim TotalFilas, TotalColumnas As Integer
        Dim MatrizAuxActual(,) As String
        ReDim MatrizAuxActual(1, 1) 'Para evitar que el Compilador alege
        '
        AsignarMatrizAuxiliar(NombreMatriz, MatrizAuxActual, TotalFilas, TotalColumnas)
        If TotalFilas = 0 Or TotalColumnas = 0 Then Exit Sub
        '
        Dim i, j, Contador As Integer
        Dim ArchivoFinal() As String
        Dim T As String
        ReDim ArchivoFinal(TotalFilas)
        Contador = -1
        For i = 0 To TotalFilas
            If MatrizAuxActual(i, 1) = "" Then
                Continue For
            Else
                T = MatrizAuxActual(i, 0)
                For j = 1 To TotalColumnas - 1
                    MatrizAuxActual(i, j) = If(String.IsNullOrEmpty(MatrizAuxActual(i, j)), "0", MatrizAuxActual(i, j))
                    T &= vbTab & MatrizAuxActual(i, j)
                Next j
                Contador += 1
                ArchivoFinal(Contador) = T
            End If
        Next i
        ReDim Preserve ArchivoFinal(Contador)
        '
        Dim RutaArchivo As String = RutaLocal & "\TxT\" & NombreMatriz & ".txt"
        File.WriteAllLines(RutaArchivo, ArchivoFinal, System.Text.Encoding.UTF8)
    End Sub
    '
    Private Sub AsignarMatrizAuxiliar(ByVal NombreMatriz As String, ByRef MatrizAuxActual(,) As String, ByRef TotalFilas As Integer, ByRef TotalColumnas As Integer)
        TotalFilas = 0
        TotalColumnas = 0
        Select Case NombreMatriz
            Case "Solicitudes"
                MatrizAuxActual = Matriz_Solicitudes
                TotalFilas = Matriz_SolicitudesTF
                TotalColumnas = Matriz_SolicitudesTC

            Case "Expedientes"
                MatrizAuxActual = Matriz_Expedientes
                TotalFilas = Matriz_ExpedientesTF
                TotalColumnas = Matriz_ExpedientesTC

            Case "Cuotas"
                MatrizAuxActual = Matriz_Cuotas
                TotalFilas = Matriz_CuotasTF
                TotalColumnas = Matriz_CuotasTC

            Case "Documento_RFI"
                MatrizAuxActual = Matriz_RFI
                TotalFilas = Matriz_RFITF
                TotalColumnas = Matriz_RFITC

            Case "Documento_Contraloria"
                MatrizAuxActual = Matriz_Contraloria
                TotalFilas = Matriz_ContraloriaTF
                TotalColumnas = Matriz_ContraloriaTC

            Case "Documento_Contrato"
                MatrizAuxActual = Matriz_Contrato
                TotalFilas = Matriz_ContratoTF
                TotalColumnas = Matriz_ContratoTC

            Case "Documento_Nota"
                MatrizAuxActual = Matriz_Nota
                TotalFilas = Matriz_NotaTF
                TotalColumnas = Matriz_NotaTC

            Case "Documento_OrdenCompra"
                MatrizAuxActual = Matriz_OrdenCompra
                TotalFilas = Matriz_OrdenCompraTF
                TotalColumnas = Matriz_OrdenCompraTC

            Case "Documento_Resolucion"
                MatrizAuxActual = Matriz_Resolucion
                TotalFilas = Matriz_ResolucionTF
                TotalColumnas = Matriz_ResolucionTC
            Case "Variables"
                MatrizAuxActual = Matriz_Variables
                TotalFilas = Matriz_VariablesTF
                TotalColumnas = Matriz_VariablesTC

            Case "Pares"
                MatrizAuxActual = Matriz_Pares
                TotalFilas = Matriz_ParesTF
                TotalColumnas = Matriz_ParesTC

            Case "Solicitudes_Detalle"
                MatrizAuxActual = Matriz_SolicitudesDetalle
                TotalFilas = Matriz_SolicitudesDetalleTF
                TotalColumnas = Matriz_SolicitudesDetalleTC

            Case "Cuotas_Detalle"
                MatrizAuxActual = Matriz_CuotaDetalle
                TotalFilas = Matriz_CuotaDetalleTF
                TotalColumnas = Matriz_CuotaDetalleTC

        End Select
    End Sub
    '
    Public Sub BAK_Archivos_TXT(ByVal NombreArchivo As String)
        'Hace un respaldo del archivo actual.
        Dim FechaActual As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim ArchivoOriginal As String = Path.Combine(RutaLocal, "TxT\", NombreArchivo & ".txt")
        Dim ArchivoCopia As String = Path.Combine(RutaLocal, "TxT\Bak_Full\", NombreArchivo & "_" & FechaActual & ".txt")
        If File.Exists(ArchivoCopia) Then Exit Sub
        File.Copy(ArchivoOriginal, ArchivoCopia)
    End Sub
    '
    Public Function CopiarArchivoWord(RutaOrigen As String, RutaDestino As String) As Boolean
        If File.Exists(RutaOrigen) Then
            File.Copy(RutaOrigen, RutaDestino, True)
            Return True
        Else
            MessageBox.Show("Error: No encontro el archivo Origen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
    '
    Public Function GuardarRTF(Directorio As String, NombreArchivo As String, ControlRichText As RichTextBox) As Boolean
        Dim RutaCompleta As String = Directorio & "\" & NombreArchivo
        If Not ExisteCarpeta(Directorio) Then Return False
        '
        If ExisteArchivo(RutaCompleta, False) Then File.Delete(RutaCompleta)
        If ControlRichText.Text.Length = 0 Then Return False
        '
        ControlRichText.SaveFile(RutaCompleta, RichTextBoxStreamType.RichText)
        Return True
    End Function
    '
    Public Function CargaRTF(Directorio As String, NombreArchivo As String, Control As RichTextBox) As Boolean
        Dim RutaCompleta As String = Directorio & "\" & NombreArchivo
        If ExisteArchivo(RutaCompleta, False) Then
            Control.LoadFile(RutaCompleta, RichTextBoxStreamType.RichText)
            Return True
        Else
            Control.Text = ""
            Return False
        End If
    End Function
    '
    Public Sub GuardarMatrizEnArchivoTXT(ByVal RutaArchivo As String, ByVal Arreglo() As String)
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

        'File.WriteAllText(NombreArchivo, Mensaje)
        'No utilizo WriteAllText porque No agrega saltos de línea automáticamente

        'En cambio la instruccion   File.WriteAllLines(
        'Cada elemento del array se escribe como una línea separada en el archivo
        'Agrega saltos de línea automáticamente entre cada elemento
    End Sub

    Public Function AgregarArchivoLocal(ObjetoOpenFileDialog As OpenFileDialog, ByVal RutaDestino As String, ByVal NombreArchivoDestino As String) As Boolean
        Dim RutaInicial As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If Not ExisteCarpeta(RutaInicial) Then RutaInicial = "C:\"
        '
        ObjetoOpenFileDialog.FileName = ""
        ObjetoOpenFileDialog.InitialDirectory = RutaInicial
        ObjetoOpenFileDialog.Filter = "Archivos PDF  (*.pdf)|*.pdf|Archivos Texto (*.txt)|*.txt|Todos los Archivos (*.*)|*.*"
        ObjetoOpenFileDialog.ShowDialog()
        If ObjetoOpenFileDialog.FileName = "" Then Return False
        '
        Try
            Dim RutaOriginal As String = ObjetoOpenFileDialog.FileName
            Dim Extension As String = Path.GetExtension(RutaOriginal)
            Dim Directorio As String = Path.GetDirectoryName(RutaOriginal)
            Dim NuevaRuta As String = Path.Combine(RutaDestino, NombreArchivoDestino & Extension)
            'File.Move(RutaOriginal, NuevaRuta)
            File.Copy(RutaOriginal, NuevaRuta)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al renombrar: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub CargarArchivoLocalDetalle(ObjetoOpenFileDialog As OpenFileDialog, ByRef RutaInical As String, ByRef NombreArchivo As String, ByRef Extension As String)
        If RutaInical = "" Then RutaInical = "C:\"
        '
        ObjetoOpenFileDialog.FileName = ""
        ObjetoOpenFileDialog.InitialDirectory = RutaInical
        ObjetoOpenFileDialog.Filter = "Archivos Texto (*.txt)|*.txt|Todos los Archivos (*.*)|*.*"
        ObjetoOpenFileDialog.ShowDialog()
        '
        RutaInical = ObjetoOpenFileDialog.InitialDirectory
        NombreArchivo = ObjetoOpenFileDialog.SafeFileName
        Dim x As Integer = InStr(NombreArchivo, ".")
        If x > 0 Then
            Extension = Mid(NombreArchivo, x + 1)
            NombreArchivo = Mid(NombreArchivo, 1, x - 1)
        End If
    End Sub

    Public Sub RellenarElementos(ByRef Elementos() As String)
        Dim i As Integer
        For i = 0 To Elementos.Length - 1
            Elementos(i) = If(String.IsNullOrEmpty(Elementos(i)), "0", Elementos(i))
        Next i
    End Sub
    '
    Public Sub CargaConsumoInicial(CodigoSolicitud As String, RutaArchivoTXT As String, NombreArchivoTXT As String, ExtensionNombreArchivoTXT As String)
        Dim NombreProcedimiento As String = MethodBase.GetCurrentMethod().Name
        Dim RutaNombreArchivo As String = RutaArchivoTXT & "\" & NombreArchivoTXT & "." & ExtensionNombreArchivoTXT
        Dim T As String
        '
        If CodigoSolicitud = Nothing Or RutaArchivoTXT = Nothing Or NombreArchivoTXT = Nothing Or ExtensionNombreArchivoTXT = Nothing Then
            T = "No viene algunos de estos datos" & vbCrLf
            T &= "CodigoSolicitud, RutaArchivo, NombreArchivo" & vbCrLf
            T &= "Datos no procesados" & vbCrLf
            MsgBox(T, vbCritical, NombreProcedimiento)
            Exit Sub
        End If
        '
        If Not ExisteArchivo(RutaNombreArchivo) Then
            T = "La ruta del archivo, no existe" & vbCrLf
            T &= "Datos no procesados" & vbCrLf
            MsgBox(T, vbCritical, NombreProcedimiento)
            Exit Sub
        End If
        '
        Dim Lineas() As String = File.ReadAllLines(RutaNombreArchivo, Encoding.GetEncoding(1252))
        '
        If Lineas.Length < 2 Then
            T = "El archivo tiene menos de 1 lineas" & vbCrLf
            T &= "Datos no procesados" & vbCrLf
            MsgBox(T, vbCritical, NombreProcedimiento)
            Exit Sub
        End If
        '
        Dim Linea As String = Lineas(0).Trim
        Dim Elementos() As String = Linea.Split(vbTab)
        If Elementos.Length < 5 Then
            T = "El archivo tiene menos de 5 columnas" & vbCrLf
            T &= "Datos no procesados" & vbCrLf
            MsgBox(T, vbCritical, NombreProcedimiento)
            Exit Sub
        End If
        '
        CargarConsumo(CodigoSolicitud, RutaArchivoTXT, NombreArchivoTXT, ExtensionNombreArchivoTXT, Lineas)
    End Sub
    '

    '
    Public Function CargarUsuario_Validar(NombreUsuario As String) As Boolean
        Dim Lineas() = File.ReadAllLines(RutaRed & "\AccesoUsuario.txt")
        Dim TotalFilas As Integer = Lineas.Length
        Dim i As Integer
        '
        For i = 0 To TotalFilas - 1
            Dim Linea As String = Lineas(i).Trim
            If Linea = "" Then Continue For 'Si la línea está vacía, continuar con la siguiente iteración
            Dim elementos() As String = Linea.Split(vbTab)
            If elementos.Length < 3 Then Continue For
            '
            If NombreUsuario = elementos(1) Then
                If elementos(2) = "FULL" Then HabilitadoParaGrabar = True
                Return True
            End If
        Next i
        Return False
        '
        '0   Nombre Usuario
        '1   Usuario AD
        '2   Acceso
    End Function
    '
    '
    '
End Module
'
'
'