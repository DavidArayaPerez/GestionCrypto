'
'
'
'Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ".", .NumberGroupSeparator = ",", .CurrencyDecimalSeparator = ".", .CurrencyGroupSeparator = ","}}
'
'
'
Module zVariables_Globales
    Public CulturaEspanola As New System.Globalization.CultureInfo("es-ES")
    Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ",", .NumberGroupSeparator = ".", .CurrencyDecimalSeparator = ",", .CurrencyGroupSeparator = "."}}


    Public HabilitadoParaGrabar As Boolean = False
    Public VariableDeInicio As Boolean = False
    Public ArchivoNota As String
    Public ModoDebug As Boolean = True  'Cambiar a True cuando necesites diagnosticar
    '
    '
    '
    Public Sub CopiarAlPortapapeles(ByVal txt As Control)
        If Not String.IsNullOrWhiteSpace(txt.Text) Then
            Clipboard.SetText(txt.Text)
        End If
    End Sub
    '
    '
    '
End Module