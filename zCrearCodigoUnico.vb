'
'
'
Module zCrearCodigoUnico
    '
    '
    '
    Public Function CrearCodigoInterno() As String
        'Esto solo genera un numero unico
        '
        Dim Letra1, Letra2, Letra3, Letra4 As String
        Dim MatrizLetras() As String
        Dim Contador, x, y As Long
        '------------------------------------------------------------------------
        'Rellena una tabla con codigo ASCII dos veces : AA, AB, AC, AD...
        'Esa tabla se utiliza para generar un codigo unico.
        Contador = 0
        ReDim MatrizLetras(700)
        For y = 65 To 90
            Letra1 = Chr(y)
            For x = 65 To 90
                Letra2 = Chr(x)
                Contador += 1
                MatrizLetras(Contador) = Letra1 & Letra2
            Next x
        Next y
        '------------------------------------------------------------------------
        'Toma la fecha y hora actual
        '   Considera la fecha como un numero, y ese numero lo posiciona en la tabla con letras.
        '   Considera la hora como un numero, y ese numero lo posiciona en la tabla con letras.
        'Agrega dos numero aleatorios, y esos numeros los posiciona en la tabla con letras.
        Dim FechaHora As DateTime = DateTime.Now
        Letra1 = MatrizLetras(FechaHora.Year - 2020 + FechaHora.Month + FechaHora.Day)
        Letra2 = MatrizLetras(FechaHora.Hour + FechaHora.Minute + FechaHora.Second)
        Letra3 = MatrizLetras(GenerateRandomNumber(1, 200))
        Letra4 = MatrizLetras(GenerateRandomNumber(201, 400))
        '------------------------------------------------------------------------
        'Con ello genera un codigo unico
        Return Letra1 & Letra2 & Letra3 & Letra4
    End Function
    Public Function GenerateRandomNumber(min As Integer, max As Integer) As Integer
        Using rng As New System.Security.Cryptography.RNGCryptoServiceProvider()
            Dim data(3) As Byte
            rng.GetBytes(data)
            Dim value As Integer = BitConverter.ToInt32(data, 0)
            value = Math.Abs(value)
            Return min + (value Mod (max - min + 1))
        End Using
    End Function
    '
    '
    '
End Module
'
'
'