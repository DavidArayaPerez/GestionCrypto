'
'
Module zVariables_Globales
    Public CulturaEspanola As New System.Globalization.CultureInfo("es-ES")
    'Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ".", .NumberGroupSeparator = ",", .CurrencyDecimalSeparator = ".", .CurrencyGroupSeparator = ","}}
    Public CulturaChilena As New Globalization.CultureInfo("es-CL") With {.NumberFormat = New Globalization.NumberFormatInfo() With {.NumberDecimalSeparator = ",", .NumberGroupSeparator = ".", .CurrencyDecimalSeparator = ",", .CurrencyGroupSeparator = "."}}
    '
    Public RutaLocal As String              'Variable para trabajar en forma local, o forma nativa.
    '
    Public HabilitadoParaGrabar As Boolean = False
    '
    Public VariableDeInicio As Boolean = False
    '

    '
    '
    '
End Module
'
'
'