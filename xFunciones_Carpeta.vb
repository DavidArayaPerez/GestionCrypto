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
    '
    '
    '
End Module
'
'
'