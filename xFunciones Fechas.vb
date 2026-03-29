'
Imports System.Globalization
Imports System.Security.Cryptography
'
'
'
Module zFuncionesAutonomas_Fechas
    '
    '
    '
    Public Function TransformarFecha_TextoNumero_YYYYmmDD(FechaTexto As String) As Integer
        Dim Largo As Integer = Len(FechaTexto)
        '
        If Largo = 6 Then
            Return FechaLargo6(FechaTexto)
        ElseIf Largo = 8 Then
            Return FechaLargo8(FechaTexto)
        ElseIf Largo = 10 Then
            Return FechaLargo10(FechaTexto)
        Else
            Return FechaLargoVariable(FechaTexto)
        End If
        '
    End Function
    Function FechaLargo6(FechaTexto As String) As Integer
        Dim Dia As String = "0"
        Dim Mes As String = "0"
        Dim Año As String = "0"
        'Formato corto del tipo YYmmDD
        'Aca el problema es si viene al reves DDmmYY
        'Por ende se probaran ambas opciones y si la primera da fecha valida entonce se toma esa, sino la siguiente, sino Return 0
        Dim F1 As String = "20" & Mid(FechaTexto, 1, 2) & "/" & Mid(FechaTexto, 3, 2) & "/" & Mid(FechaTexto, 5, 2) 'YYmmDD
        Dim F2 As String = "20" & Mid(FechaTexto, 5, 2) & "/" & Mid(FechaTexto, 3, 2) & "/" & Mid(FechaTexto, 1, 2) 'DDmmYY
        If IsDate(F1) Then
            Año = "20" & Mid(FechaTexto, 1, 2)
            Mes = Mid(FechaTexto, 3, 2)
            Dia = Mid(FechaTexto, 5, 2)
            Return Año & Mes & Dia
        ElseIf IsDate(F2) Then
            Año = "20" & Mid(FechaTexto, 5, 2)
            Mes = Mid(FechaTexto, 3, 2)
            Dia = Mid(FechaTexto, 1, 2)
            Return Año & Mes & Dia
        End If
        Return 0
    End Function
    Function FechaLargo8(FechaTexto As String) As Integer
        Dim Dia As String = "0"
        Dim Mes As String = "0"
        Dim Año As String = "0"
        'Formato mediano del tipo YYYYmmDD, se procede de la misma forma que en el Largo=6
        Dim F1 As String = Mid(FechaTexto, 1, 4) & "/" & Mid(FechaTexto, 5, 2) & "/" & Mid(FechaTexto, 7, 2)    'YYYY mm DD
        Dim F2 As String = Mid(FechaTexto, 7, 2) & "/" & Mid(FechaTexto, 3, 2) & "/" & Mid(FechaTexto, 5, 4)    'DD mm YYYY 
        If IsDate(F1) Then
            Año = Mid(FechaTexto, 1, 4)
            Mes = Mid(FechaTexto, 5, 2)
            Dia = Mid(FechaTexto, 7, 2)
            Return Año & Mes & Dia
        ElseIf IsDate(F2) Then
            Año = Mid(FechaTexto, 5, 4)
            Mes = Mid(FechaTexto, 3, 2)
            Dia = Mid(FechaTexto, 7, 2)
            Return Año & Mes & Dia
        End If
        Return 0
    End Function
    Function FechaLargo10(FechaTexto As String) As Integer
        Dim Dia As String = "0"
        Dim Mes As String = "0"
        Dim Año As String = "0"
        'El formato largo es el mas comun, pero se pueden presentar varias formas, por ejemplo: dd-MM-yyyy, yyyy-MM-dd, dd/MM/yyyy, yyyy/MM/dd
        Dim F1 As String = Mid(FechaTexto, 1, 4) & "/" & Mid(FechaTexto, 6, 2) & "/" & Mid(FechaTexto, 9, 2)    'YYYY mm DD
        Dim F2 As String = Mid(FechaTexto, 7, 4) & "/" & Mid(FechaTexto, 4, 2) & "/" & Mid(FechaTexto, 1, 2)    'DD mm YYYY 
        If IsDate(F1) Then
            Año = Mid(FechaTexto, 1, 4)
            Mes = Mid(FechaTexto, 6, 2)
            Dia = Mid(FechaTexto, 9, 2)
            Return Año & Mes & Dia
        ElseIf IsDate(F2) Then
            Año = Mid(FechaTexto, 7, 4)
            Mes = Mid(FechaTexto, 4, 2)
            Dia = Mid(FechaTexto, 1, 2)
            Return Año & Mes & Dia
        End If
        Return 0
    End Function
    Function FechaLargoVariable(FechaTexto As String) As Integer
        Dim Dia As String = "0"
        Dim Mes As String = "0"
        Dim Año As String = "0"
        Dim Uno As String = ""
        Dim Dos As String = ""
        Dim Tres As String = ""
        Dim Separador As String = ""
        Dim X, Y, Z As Integer
        '
        'Para casos donde el formato tiene valores diferentes como:
        '   Ejemplo 1: Primero de Enero 2026 =      1/2/2026    ó      26/1/2
        '   Ejemplo 2: Cuando vienen con datos con hora y fecha, por ejemplo: 2026/01/01 12:00:00
        '   Lo primero es encontrar el separador: / ó -
        '
        If InStr(1, FechaTexto, "/") > 0 Then
            Separador = "/"
        ElseIf InStr(1, FechaTexto, "-") > 0 Then
            Separador = "-"
        Else
            Return 0
        End If
        '
        X = InStr(1, FechaTexto, Separador)
        Y = InStr(X + 1, FechaTexto, Separador)
        Z = InStr(Y + 1, FechaTexto, " ")
        If X > 0 And Y > 0 And Z > 0 Then
            Uno = Mid(FechaTexto, 1, X - 1)
            Dos = Mid(FechaTexto, X + 1, Y - 1)
            Tres = Mid(FechaTexto, Y + 1, Z - 1)
        ElseIf X > 0 And Y > 0 And Z = 0 Then
            Uno = Mid(FechaTexto, 1, X - 1)
            Dos = Mid(FechaTexto, X + 1, Y - 1)
            Tres = Mid(FechaTexto, Y + 1, Len(FechaTexto) - Y)
        End If
        If Len(Uno) = 1 Then Uno = "0" & Uno
        If Len(Dos) = 1 Then Dos = "0" & Dos
        If Len(Tres) = 1 Then Tres = "0" & Tres
        '
        Return FechaLargo6(Uno & Dos & Tres)
    End Function





















    Public Function ValidaAño(Año As String) As Integer
        Dim Num As Integer = Val(Año)
        Dim AñoActual As Integer = Now.Year
        If Num >= AñoActual - 100 And Num <= AñoActual + 100 Then
            Return Val(Num)
        Else
            Return 0
        End If
    End Function
    '
    Public Function ValidaFechaTexto(Texto As String) As Boolean
        If Texto = Nothing Then Return False
        If Not IsDate(Texto) Then Return False
        '
        Dim Año As Integer = DateAndTime.Year(Texto)
        If Año < 2000 Or Año > 2050 Then Return False
        '
        Return True
    End Function
    '
    Public Function UltimoDiaMes(ByVal TextoFecha_DD_MM_YYYY As String) As String
        Dim Dia, Mes, Año As Integer
        Dim tDia, tMes As String
        If Len(TextoFecha_DD_MM_YYYY) = 10 Then
            'Dia = Mid(TextoFecha_DD_MM_YYYY, 1, 2)
            Mes = Mid(TextoFecha_DD_MM_YYYY, 4, 2)
            If Mes < 1 And Mes > 12 Then Mes = Now.Month
            '
            Año = Mid(TextoFecha_DD_MM_YYYY, 7, 4)
            Año = ValidaAño(Año)
            If Año = 0 Then Año = Now.Year
        Else
            Mes = Now.Month
            Año = Now.Year
        End If
        Dia = DateTime.DaysInMonth(Año, Mes)
        '
        If Dia < 10 Then
            tDia = "0" & Str(Dia).Trim
        Else
            tDia = Str(Dia).Trim
        End If
        If Mes < 10 Then
            tMes = "0" & Str(Mes).Trim
        Else
            tMes = Str(Mes).Trim
        End If
        Return tDia & "-" & tMes & "-" & Año
    End Function
    '
    Public Function TransformarA_Texto_DD_MM_YYYY(Texto As String, Optional FechaInicio_DD_MM_YYYY As String = "") As String
        ' Formato para el formulario, dd-MM-YYYY
        Dim Dia, Mes, Año As String
        If Texto = Nothing Then Return "01-01-1900"
        If Texto = "" Then Return "01-01-1900"
        '
        If Len(Texto) >= 8 Then
            'Puede tener formato fecha como: ddMMyyyy, yyyyMMdd, dd-MM-yyyy, yyyy-MM-dd, dd/MM/yyyy, yyyy/MM/dd
            If IsDate(Texto) Then
                If DateAndTime.Year(Texto) > 0 And DateAndTime.Month(Texto) > 0 And DateAndTime.Day(Texto) Then
                    Año = Str(DateAndTime.Year(Texto)).Trim
                    Mes = Str(DateAndTime.Month(Texto)).Trim
                    Dia = Str(DateAndTime.Day(Texto)).Trim
                    If Len(Mes) = 1 Then Mes = "0" & Mes
                    If Len(Dia) = 1 Then Dia = "0" & Dia
                    Return Dia & "-" & Mes & "-" & Año
                Else
                    Return "01-01-1900"
                End If
            ElseIf Len(Texto) = 10 Then
                'dd-MM-yyyy
                Dia = Mid(Texto, 1, 2)
                Mes = Mid(Texto, 4, 2)
                Año = Mid(Texto, 7, 4)
                If Dia > 0 And Dia < 32 And Mes > 0 And Mes < 13 And Año > 1900 And Año < 2100 Then Return Dia & "-" & Mes & "-" & Año
            ElseIf Len(Texto) = 8 Then
                'Se debe definir si el formato es   YYYYmmDD
                'o el formato es                    DDmmYYYY
                If Val(Mid(Texto, 1, 2)) = 19 Or Val(Mid(Texto, 1, 2)) = 20 Then 'Es para definir si los dos primeros caracteres corresponden al 19XX o al 20XX
                    Año = Mid(Texto, 1, 4)
                    Mes = Mid(Texto, 5, 2)
                    Dia = Mid(Texto, 7, 2)
                    Return Dia & "-" & Mes & "-" & Año
                Else
                    Año = Mid(Texto, 5, 4)
                    Mes = Mid(Texto, 3, 2)
                    Dia = Mid(Texto, 1, 2)
                    Return Dia & "-" & Mes & "-" & Año
                End If
            End If
        Else
            'No tiene formato fecha o no hay fecha
            If Len(FechaInicio_DD_MM_YYYY) = 10 Then
                'Si existe la fecha de inicio entonces podemos definir la fecha final del mes
                'La fecha debe tener 10 caracteres es decir ya debe tener el formado de dd-MM-yyyy
                Return UltimoDiaMes(FechaInicio_DD_MM_YYYY)
            Else
                Return "01-01-1900"
            End If
        End If
        Return "01-01-1900"
    End Function
    '

    '
    Public Function FechaEnTextoSoloAñoMes(Año As Integer, Mes As Integer) As String
        If Mes < 1 Or Mes > 12 Or Año < 1900 Or Año > 2100 Then Return ""
        '
        Dim Fecha As DateTime
        Fecha = New DateTime(Año, Mes, 1) '2025,8,7
        Dim culturaEspañol As New CultureInfo("es-ES")
        Dim mesNombre As String = culturaEspañol.DateTimeFormat.GetMonthName(Fecha.Month)
        mesNombre = New CultureInfo("es-ES").TextInfo.ToTitleCase(mesNombre) ' "Agosto"
        Dim resultado As String = $"{Fecha.Year} de {mesNombre}"
        'Dim resultado As String = $"{fecha.Day} de {mesNombre} del {fecha.Year}" ' "7 de Agosto del 2025
        Return resultado
    End Function
    '
    Public Function AgregarUnDiaFechaTextoDevuelveTexto(FechaTexto_dd_mm_yyyy As String, DiasAgregar As Integer) As String
        Try
            Dim fecha As DateTime = DateTime.ParseExact(FechaTexto_dd_mm_yyyy, "dd-MM-yyyy", Nothing) ' Convertir el texto a DateTime
            Dim nuevaFecha As DateTime = fecha.AddDays(DiasAgregar) ' Agregar días
            Return nuevaFecha.ToString("dd-MM-yyyy") ' Convertir de vuelta a texto
        Catch ex As Exception
            Return "01-01-1900"
            'Throw New ArgumentException("Formato de fecha inválido. Use el formato dd-MM-yyyy") ' Manejar error si el formato no es válido
        End Try
        Return ""
    End Function
    '
    Public Function DeTextoFecha_A_NumeroEntero(ByVal FechaTexto_DD_MM_YYYY As String) As Integer
        Dim FechaNumero As Integer
        If FechaTexto_DD_MM_YYYY Is Nothing Then Return 0
        Try
            Dim fecha As DateTime = DateTime.ParseExact(FechaTexto_DD_MM_YYYY, "dd-MM-yyyy", Nothing)
            FechaNumero = fecha.Year * 10000 + fecha.Month * 100 + fecha.Day
            Return FechaNumero
        Catch ex As FormatException
            Return 0
        End Try
    End Function
    '
    Public Function VigenciaSolicitud(FechaInicio As String, FechaFinal As String) As String
        '"VIGENTE"          "TERMINADO"             "FUTURO"        
        'Ejemplo si hoy es 2025/02/20, y las fechas de inicio es 2025/03/01, para el programa significa que aun no comienza el contrato.
        'Por el contrario si la fecha de inicio es 2025/01/01, significa que el contrato ya empezo.
        '   Pero si la fecha de inicio es 2025/01/01 y la fecha final es 2025/02/01 significa que el contrato empezo y ya termino....
        'Por ese motivo hace faltan las dos fechas para compararla con la fecha de hoy.
        '
        If Not ValidaFechaTexto(FechaInicio) Then Return ""
        If Not ValidaFechaTexto(FechaFinal) Then Return ""
        '
        Dim Fecha As DateTime = DateTime.Now
        Dim FechaHoy As Integer = Val(Fecha.ToString("yyyyMMdd"))
        Dim Estado As String = "NO VALIDO"
        Dim FInicio As Integer = DeTextoFecha_A_NumeroEntero(FechaInicio)
        Dim FFinal As Integer = DeTextoFecha_A_NumeroEntero(FechaFinal)
        '
        If FechaHoy > FInicio And FechaHoy < FFinal Then
            Return "VIGENTE"
        ElseIf FechaHoy > FInicio And FechaHoy > FFinal Then
            Return "TERMINADO"
        Else
            Return "FUTURO"
        End If
    End Function
    '
    Public Function Texto_FechaHoraActual() As String
        Dim FechaHora As String
        '
        FechaHora = Now.Year
        If Now.Month < 10 Then FechaHora += "0"
        FechaHora += Str(Now.Month).Trim
        '
        If Now.Day < 10 Then FechaHora += "0"
        FechaHora += Str(Now.Day).Trim
        '
        FechaHora += " "
        '
        If Now.Hour < 10 Then FechaHora += "0"
        FechaHora += Str(Now.Hour).Trim
        FechaHora += ":"
        '
        If Now.Minute < 10 Then FechaHora += "0"
        FechaHora += Str(Now.Minute).Trim
        '
        Return FechaHora
    End Function
    '
    Public Function ArmaFecha(Dia As Integer, Mes As Integer, año As Integer) As String
        Dim DiaTexto, MesTexto As String
        '
        If Dia < 10 Then
            DiaTexto = "0" & Str(Dia).Trim & "-"
        Else
            DiaTexto = Str(Dia).Trim & "-"
        End If
        '
        If Mes < 10 Then
            MesTexto = "0" & Str(Mes).Trim & "-"
        Else
            MesTexto = Str(Mes).Trim & "-"
        End If
        '
        Return DiaTexto & MesTexto & Str(año).Trim
    End Function

    '
    '
End Module
'
'
'