'
Imports System.Globalization
'
'
'
Module zFuncionesMatematicas
    '
    '
    '
    'FormatoChileno(Texto , Decimales)
    'ValidaTXT_Numero(Texto)
    'Valida_NumeroConFormato(Texto)
    '
    '
    Public Function FormatoChileno(ByVal Texto As String, Optional ByVal Decimales As Integer = 2) As String
        If String.IsNullOrWhiteSpace(Texto) Then Return "0"
        '
        Dim numero As Double
        If Not Double.TryParse(Texto, System.Globalization.NumberStyles.Any,
                           System.Globalization.CultureInfo.InvariantCulture, numero) Then
            Return Texto
        End If
        '
        Return numero.ToString("N" & Decimales, System.Globalization.CultureInfo.GetCultureInfo("es-CL"))
    End Function


    Public Function ValidaTXT_Numero(Texto As String) As String
        If Not IsNumeric(Texto) Then Return "0"
        Return Texto
    End Function
    Public Function Valida_NumeroConFormato(Texto As String) As String
        Dim NumeroDoble As Double
        Dim T As String
        If Not IsNumeric(Texto) Then Return "0"
        If Val(Texto) = 0 Then Return "0"
        '
        NumeroDoble = CDbl(Texto)
        T = NumeroDoble.ToString("#,###.########", CulturaChilena)
        Return T
    End Function

    Public Function Valida_NumeroConFormatoSinDecimales(Texto As String) As String
        If Not IsNumeric(Texto) Then Return "0"
        If Val(Texto) = 0 Then Return "0"

        Dim NumeroDoble As Double
        NumeroDoble = CDbl(Texto)
        Return NumeroDoble.ToString("N0", CulturaChilena)
    End Function
    Public Function ConvierteNumero_ConDecimalesLimitadosAnchoFijo(NumeroTXT As String, Anchofjo As Integer) As String
        'Si el ancho fijo es 5 y la parte entera es 1.000 (4 caracteres) se le suma un decimal, es decir: 1.000,0
        'Si el ancho fijo es 7 y la parte entera es 1.000 (4 caracteres) se le suma tres decimales, es decir: 1.000,000
        'Si el ancho fijo es 5 y la parte entera es 568.235 (6 caracteres) no se le suma ningun decimal.
        'Si el ancho fijo es 8 y el numero es 568.124,02 (8 caracteres) no se le suma ningun decimal.
        '
        Dim Numero As Double
        If Not IsNumeric(NumeroTXT) Then Return 0
        Numero = CDbl(NumeroTXT)
        '
        Dim ParteEntera As Double = Math.Truncate(Numero)
        Dim ParteDecimal As Double = NumeroTXT - ParteEntera
        Dim FormatoNumeroDecimales As String
        Dim NumeroTXT2 As String
        Dim NumeroDecimales As Integer
        '
        If Len(ParteEntera) + Len(ParteDecimal) > Anchofjo Then
            NumeroDecimales = Len(ParteDecimal)
            FormatoNumeroDecimales = New String("#"c, NumeroDecimales)
            NumeroTXT2 = Numero.ToString("#,###." & FormatoNumeroDecimales, CulturaChilena)
            Return NumeroTXT
        Else
            NumeroDecimales = Anchofjo
            FormatoNumeroDecimales = New String("#"c, NumeroDecimales)
            NumeroTXT2 = Numero.ToString("#,###." & FormatoNumeroDecimales, CulturaChilena)
            Return NumeroTXT
        End If
    End Function
    '
    '
    '
End Module
'
'
'