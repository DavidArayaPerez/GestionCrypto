'
'
'
Imports System.IO
Imports System.Linq.Expressions
'
'
'
Module xFunciones_Carpeta
    '
    '
    '
    Public Sub CreaDirectorio(RutaCompleta As String)
        Dim Inicio, Largo As Integer
        Dim RutaChica As String
        Largo = InStr(1, RutaCompleta, "\")
        '
        Do While Largo > 0
            RutaChica = Mid(RutaCompleta, 1, Largo)
            If Not Directory.Exists(RutaChica) Then Directory.CreateDirectory(RutaChica)
            Inicio = Largo + 1
            Largo = InStr(Inicio, RutaCompleta, "\")
        Loop
        '
        If Inicio < Len(RutaCompleta) Then
            If Not Directory.Exists(RutaCompleta) Then Directory.CreateDirectory(RutaCompleta)
        End If
    End Sub
    Public Sub AbrirCarpeta(ByVal Ruta As String, Optional CrearCarpeta As Boolean = False, Optional Preguntar As Boolean = False)
        If Ruta = "" Then Exit Sub

        If Directory.Exists(Ruta) Then
            Process.Start("explorer.exe", Ruta)
        Else
            If CrearCarpeta Then
                If Preguntar Then
                    Dim respuesta As MsgBoxResult = MsgBox("No existe la carpeta: " & vbCrLf & UCase(Ruta) & vbCrLf & "¿Desea crearla?", MsgBoxStyle.YesNo, "Carpeta")
                    If respuesta = MsgBoxResult.No Then Exit Sub
                End If
                Try
                    Directory.CreateDirectory(Ruta)
                Catch ex As Exception
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub
    Public Function ExisteCarpeta(Ruta As String) As Boolean
        If Directory.Exists(Ruta) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub CopyDirectory(origen As String, destino As String)
        '
        ' Crear el directorio de DESTINO si no existe
        If Not Directory.Exists(destino) Then
            Directory.CreateDirectory(destino)
        End If
        '
        'Validar si el directorio ORIGEN existe
        If Not Directory.Exists(origen) Then Exit Sub
        '
        ' Copiar archivos
        For Each archivo As String In Directory.GetFiles(origen)
            Dim destFile As String = Path.Combine(destino, Path.GetFileName(archivo))
            File.Copy(archivo, destFile, True) ' El último parámetro indica sobreescribir
            'File.Delete(archivo)
        Next
        ' Copiar subdirectorios recursivamente
        For Each subDir As String In Directory.GetDirectories(origen)
            Dim destSubDir As String = Path.Combine(destino, Path.GetFileName(subDir))
            CopyDirectory(subDir, destSubDir)
            'Directory.Delete(subDir, True)
        Next
    End Sub
    Public Sub BorrarDirectory(Ruta) ' Elimina un directorio y todo su contenido
        If Directory.Exists(Ruta) Then
            Try
                Directory.Delete(Ruta, True) ' El segundo parámetro indica que se eliminará de forma recursiva
            Catch ex As Exception
                Dim Mensaje, Titulo As String
                Mensaje = "Error al eliminar el directorio: " & vbCrLf & ex.Message & vbCrLf & "Valide la carpeta origen y destino"
                Titulo = "Error en Borrado de Carpeta"
                MsgBox(Mensaje, vbInformation, Titulo)
            End Try
        Else
            'Console.WriteLine("El directorio no existe.")
        End If
    End Sub





    Public Sub LlenarListDirectorios(Ruta As String, ByRef ObjetoLista As ListBox)
        Dim TotalFilas, i As Integer
        Dim MatrizCarpetas As List(Of String)
        Dim Arreglo() As String
        ReDim Arreglo(1)
        Arreglo(0) = 0
        ObjetoLista.Items.Clear()
        '
        If Directory.Exists(Ruta) Then
            ' Obtener carpetas (solo primer nivel)
            MatrizCarpetas = Directory.GetDirectories(Ruta, "*", SearchOption.TopDirectoryOnly).ToList()
            If MatrizCarpetas.Count < 1 Then Exit Sub
            '
            TotalFilas = MatrizCarpetas.Count
            ReDim Arreglo(TotalFilas)
            Arreglo(0) = TotalFilas
            For i = 0 To TotalFilas - 1
                Dim RutaLocal As String = MatrizCarpetas(i)
                ' Obtener solo el nombre de la carpeta (no la ruta completa)
                Dim NombreCarpeta As String = Path.GetFileName(RutaLocal.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar))
                If NombreCarpeta = "" Then NombreCarpeta = RutaLocal ' fallback por si es raiz
                If NombreCarpeta = "Informes" Then Continue For
                '
                ObjetoLista.Items.Add(NombreCarpeta)
            Next i
        End If
    End Sub

    '
    '
    '


    '
    '
    '
End Module
'
'
'