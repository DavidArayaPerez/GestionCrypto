'
'
'
Module zFuncionesAutonomas_Texto
    '
    '
    '
    Public Function ReemplazaTexto_AceptaNumeroLetrasCaracteres(ByVal Texto As String) As String
        If Texto = Nothing Then Return "-"
        If Texto = "" Then Return "0"
        Dim T As String = UCase(Texto.Trim)
        Dim i As Integer
        '
        If Texto = "" Then Return "0"
        T = Replace(T, Chr(1), " ")
        T = Replace(T, Chr(2), " ")
        T = Replace(T, Chr(3), " ")
        T = Replace(T, Chr(4), " ")
        T = Replace(T, Chr(5), " ")
        T = Replace(T, Chr(6), " ")
        T = Replace(T, Chr(7), " ")
        T = Replace(T, Chr(8), " ")
        T = Replace(T, Chr(9), " ")
        '10 ENTER
        '11
        '12
        'T = Replace(T, ENTER, Chr(10))    '13 ENTER      -> '10 ENTER
        T = Replace(T, Chr(14), " ")
        T = Replace(T, Chr(15), " ")
        T = Replace(T, Chr(16), " ")
        T = Replace(T, Chr(17), " ")
        T = Replace(T, Chr(18), " ")
        T = Replace(T, Chr(19), " ")
        T = Replace(T, Chr(20), " ")
        T = Replace(T, Chr(21), " ")
        T = Replace(T, Chr(22), " ")
        T = Replace(T, Chr(23), " ")
        T = Replace(T, Chr(24), " ")
        T = Replace(T, Chr(25), " ")
        T = Replace(T, Chr(26), " ")
        T = Replace(T, Chr(27), " ")
        T = Replace(T, Chr(28), " ")
        T = Replace(T, Chr(29), " ")
        T = Replace(T, Chr(30), " ")
        T = Replace(T, Chr(31), " ")
        T = Replace(T, Chr(32), " ")
        T = Replace(T, Chr(33), " ")
        T = Replace(T, Chr(34), " ")    '34     "
        '35     #
        '36     $
        '37     %
        '38     &
        T = Replace(T, Chr(39), " ")    '39     '
        '40     (
        '41     )
        '42     *
        '43     +
        '44     ,
        '45     -
        '46     .
        '47     /
        '48 al 57 NUMEROS
        '58     :
        '59     ;
        '60     <
        '61     =
        '62     >
        '63     ?
        '64     @
        '65 al 90 Mayusculas
        '91     [
        '92     \
        '93     ]
        '94     ^
        '95     _
        '96     `
        '97 al 122 Minusculas
        '123    {
        '124    |
        '125    }
        For x = 126 To 255
            T = Replace(T, Chr(i), " ")
        Next x
        T = Replace(T, Chr(34) & Chr(34), Chr(34))
        T = Replace(T, Chr(10) & Chr(10), Chr(10))
        T = Replace(T, Chr(10) & Chr(10) & Chr(10), Chr(10))
        Return T.Trim
    End Function
    Public Function SacarFilaDeParentesis(ByVal Texto As String) As Integer
        Dim X, Y, Fila As Integer
        Dim T As String
        '
        X = InStr(Texto, "(")
        If X = 0 Then Return 0
        '
        Y = InStr(Texto, ")")
        If Y = 0 Then Return 0
        '
        T = Mid(Texto, X + 1, Y - X - 1)
        Fila = Val(T)
        '
        Return Fila
    End Function
    '
    '
End Module
'
'
