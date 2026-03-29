'
'
'
Module wObjeto_Botones
    '
    '
    '
    Public Sub Botones_Agregar_Ver_Archivo(ByRef ControlAgregar As Button, ByRef ControlAbrir As Button, Fila As Integer, Ruta As String, NombreArchivo As String, Extension As String)
        If Fila = 0 Or Ruta = Nothing Or NombreArchivo = Nothing Or Extension = Nothing Then
            ControlAgregar.Enabled = False
            ControlAbrir.Enabled = False
            Exit Sub
        End If
        Dim RutaCompleta As String = Ruta & "\" & NombreArchivo & "." & Extension
        If ExisteArchivo(RutaCompleta, False) Then
            ControlAgregar.Enabled = False
            ControlAbrir.Enabled = True
        Else
            ControlAgregar.Enabled = True
            ControlAbrir.Enabled = False
        End If
    End Sub

    Public Function Menu_Habilitar_Ver_Archivo(Fila As Integer, Ruta As String, NombreArchivo As String, Extension As String) As Boolean
        'Esto permite habilitar el menu VER en caso de que el archivo exista, sino se hablita el menu AGREGAR
        If Fila = 0 Or Ruta = Nothing Or NombreArchivo = Nothing Or Extension = Nothing Then Return False
        '
        Dim RutaCompleta As String = Ruta & "\" & NombreArchivo & "." & Extension
        If ExisteArchivo(RutaCompleta, False) Then
            Return True
        Else
            Return False
        End If
    End Function

    '
    '
    '
End Module
'
'
'
