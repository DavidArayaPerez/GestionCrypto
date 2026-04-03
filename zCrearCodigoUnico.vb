'
'
'
Module zCrearCodigoUnico
    '
    '
    '
    Public Function CrearCodigoInterno() As String
        ' Genera un código único de 8 letras mayúsculas usando aleatoriedad criptográfica.
        ' Espacio total: 26^8 = 208.827.064.576 combinaciones
        ' Probabilidad de colisión con 10.000 registros: < 0.024%
        '
        Const Letras As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim resultado As String = ""
        '
        Using rng As New System.Security.Cryptography.RNGCryptoServiceProvider()
            Dim data(7) As Byte           ' 8 bytes, uno por carácter
            rng.GetBytes(data)
            For Each b As Byte In data
                resultado &= Letras(b Mod 26)
            Next
        End Using
        '
        Return resultado
    End Function
    '
    '
    '
End Module
'
'
'