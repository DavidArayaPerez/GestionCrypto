'
'
'
Module xFunciones_EdicionTexto
    '
    '
    '
    Public Sub CambiarTipoLetra_RichTextBox(ByRef ControlRichTextBox As RichTextBox, TamañoLetra As Integer)
        ControlRichTextBox.SelectAll()
        ControlRichTextBox.SelectionFont = New Font("Arial", TamañoLetra)
        ControlRichTextBox.SelectionLength = 0
    End Sub
    Public Sub TextoCambiaColor(ByRef Control As RichTextBox)
        Using colorDialog As New ColorDialog()
            If colorDialog.ShowDialog() = DialogResult.OK Then Control.SelectionColor = colorDialog.Color
        End Using
    End Sub
    Public Sub TextoSubrayado(ByRef Control As RichTextBox)
        If Control.SelectionFont IsNot Nothing Then
            Dim estiloActual As FontStyle = Control.SelectionFont.Style
            Dim nuevoEstilo As FontStyle
            If (estiloActual And FontStyle.Underline) = FontStyle.Underline Then
                nuevoEstilo = estiloActual And Not FontStyle.Underline
            Else
                nuevoEstilo = estiloActual Or FontStyle.Underline
            End If
            Control.SelectionFont = New Font(Control.SelectionFont, nuevoEstilo)
        End If
    End Sub
    Public Sub TextoNegrilla(ByRef Control As RichTextBox)
        If Control.SelectionFont IsNot Nothing Then
            Dim estiloActual As FontStyle = Control.SelectionFont.Style
            Dim nuevoEstilo As FontStyle
            If (estiloActual And FontStyle.Bold) = FontStyle.Bold Then
                nuevoEstilo = estiloActual And Not FontStyle.Bold
            Else
                nuevoEstilo = estiloActual Or FontStyle.Bold
            End If
            Control.SelectionFont = New Font(Control.SelectionFont, nuevoEstilo)
        End If
    End Sub
    Public Sub TextoCortar(ByRef Control As RichTextBox, ByRef BarraMensaje As StatusStrip)
        Try
            If Control.SelectedText <> "" Then
                Control.Cut()
                '
                'Clipboard.SetText(Control.SelectedText) ' Copiar el texto seleccionado al portapapeles y eliminarlo
                'Control.SelectedText = ""
            Else
                MensajeBarra(BarraMensaje, "Información", "No hay texto seleccionado para cortar")
            End If
        Catch ex As Exception
            MensajeBarra(BarraMensaje, "Error", ex.Message)
        End Try
    End Sub
    Public Sub TextoCopiar(ByRef Control As RichTextBox, ByRef BarraMensaje As StatusStrip)
        Try
            If Control.SelectedText <> "" Then
                Control.Copy()

                'El siguiente texto es solo para que la primera linea del texto enriquesido no tenga espacios al principio del texto
                Dim texto As String = Control.SelectedText
                Dim lineas As String() = texto.Split({Environment.NewLine}, StringSplitOptions.None) 'Dividir el texto en líneas
                If lineas.Length > 0 Then
                    'Eliminar espacios iniciales solo de la primera línea
                    lineas(0) = lineas(0).TrimStart()
                    texto = String.Join(Environment.NewLine, lineas)
                End If
                Clipboard.SetText(texto)
                'Clipboard.SetText(Control.SelectedText)
            Else
                MensajeBarra(BarraMensaje, "Información", "No hay texto seleccionado para copiar") ' Copiar el texto seleccionado al portapapeles
            End If
        Catch ex As Exception
            MensajeBarra(BarraMensaje, "Error", ex.Message)
        End Try
    End Sub
    Public Sub TextoPegar(ByRef Control As RichTextBox, ByRef BarraMensaje As StatusStrip)
        Try
            If Clipboard.ContainsText() Then ' Verificar si hay texto en el portapapeles
                Control.Paste()
            Else
                MensajeBarra(BarraMensaje, "Información", "No hay texto en el portapapeles")
            End If
        Catch ex As Exception
            MensajeBarra(BarraMensaje, "Error", ex.Message)
        End Try
    End Sub
    '
    Public Sub CargarRTF_VariableTexto(Ruta As String, ByRef Texto As String)
        If ExisteArchivo(Ruta, False) Then
            Using ctrl As New RichTextBox()
                ctrl.LoadFile(Ruta, RichTextBoxStreamType.RichText)
                Texto = ctrl.Text
            End Using
        Else
            Texto = ""
        End If
    End Sub
    '
    '
    '
End Module
'
'
'
