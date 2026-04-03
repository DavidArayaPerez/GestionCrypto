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
    '
    '
    '

    '
    '
    '
End Module