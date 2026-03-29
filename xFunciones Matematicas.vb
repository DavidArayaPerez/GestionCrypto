'
Imports System.Globalization
'
'
'
Module zFuncionesMatematicas
    '
    '
    '
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
    Public Function ConvierteNumero_ConDecimalesLimitados(Numero As Double, NumeroDecimales As Integer) As String
        Dim FormatoNumeroDecimales = New String("#"c, NumeroDecimales)
        Dim NumeroTXT = Numero.ToString("#,###." & FormatoNumeroDecimales, CulturaChilena)
        Return NumeroTXT
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
    Public Function NumeroLimitado(ByVal Texto As String, ByVal NumeroInferior As Integer, ByVal NumeroSuperior As Integer) As Integer
        Dim Numero As Integer
        If Not IsNumeric(Texto) Then Return 0
        '
        Numero = CInt(Texto)
        If Numero >= NumeroInferior Or Numero <= NumeroSuperior Then
            Return Numero
        Else
            Return 0
        End If
    End Function
    Public Function ValidaNumeroDoble(Texto As String) As Double
        'El Tipo INT es de 32bit
        '   +-2.147.483.648.-
        'El tipo LONG es de 64bit
        '   Enteros de 64 bits con signo.
        '   Rango +- 9.223.372.036.854.775.808.-
        '   Tiene 19 Caracteres
        '
        If Not IsNumeric(Texto) Then Return 0
        If Len(Texto) > 18 Then Return 0
        Dim NumeroDoble As Double
        NumeroDoble = CDbl(Texto)
        Return NumeroDoble
    End Function
    Public Function ValidarPeriodo(Texto As String) As Integer
        'Valida que el periodo este entre 2000/01 y el 2050/12
        Dim Numero As Integer = Val(Texto)
        If Numero < 200001 Then Return 0  '200001 =   2000/01
        If Numero > 205012 Then Return 0  '205012 =   2050/12
        Return Numero
    End Function
    Public Function ValidaRUTNumerico(ByVal Texto As String) As String
        Texto = Replace(Texto, ".", "")
        Dim x As String = InStr(Texto, "-")
        If x > 0 Then Texto = Mid(Texto, 1, x - 1)
        '
        If Not IsNumeric(Texto) Then Return "0"
        If Len(Texto) > 8 Then Return "0"
        '
        Dim Numero As Long = Texto
        If Numero = 0 Then Return "0"
        If Numero < 1000000 Then Return "0"
        If Numero > 99999999 Then Return "0"
        Return Str(Numero).Trim
    End Function
    Public Function DigitoVerificador(RUTnum As String) As String
        If Not IsNumeric(RUTnum) Then Return "X"
        If Val(RUTnum) = 0 Then Return "X"
        If Val(RUTnum) < 1000 And RUTnum > 99999999 Then Return "X"

        Dim Suma, RUT As Long
        Dim i As Byte
        Dim DV As String

        RUT = ValidaRUTNumerico(RUTnum)
        Suma = 0
        For i = 1 To 8
            Suma += Val(Mid(RUT, i, 1)) * Val(Mid("32765432", i, 1))
        Next i
        DV = 11 - (Suma Mod 11)

        If DV = 10 Then
            DV = "K"
        ElseIf DV = 11 Then
            DV = 0
        Else
            'Sin Cambios
        End If
        Return DV
    End Function
    '
    '
    '
End Module
'
'
'