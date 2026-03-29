'
'
'
Module wObjeto_Calendario
    '
    '
    '
    Public Function AsignarFecha(ByVal ObjetoCalendario As DateTimePicker, ByVal FechaTexto As String) As Boolean
        FechaTexto = If(FechaTexto, "").Trim()
        Dim fechaParseada As DateTime
        Dim formatos() As String = {"yyyyMMdd", "yyyy-MM-dd", "dd-MM-yyyy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy"}

        Dim parseOk As Boolean = DateTime.TryParseExact(FechaTexto, formatos, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, fechaParseada)
        If Not parseOk Then
            parseOk = DateTime.TryParse(FechaTexto, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, fechaParseada)
        End If

        Debug.Print("AsignarFecha input: [" & FechaTexto & "] parseOk: " & parseOk.ToString())
        If Not parseOk Then Return False

        If fechaParseada < ObjetoCalendario.MinDate Then fechaParseada = ObjetoCalendario.MinDate
        If fechaParseada > ObjetoCalendario.MaxDate Then fechaParseada = ObjetoCalendario.MaxDate

        Try
            If ObjetoCalendario.InvokeRequired Then
                ObjetoCalendario.Invoke(Sub()
                                            ObjetoCalendario.Value = fechaParseada
                                            ObjetoCalendario.Refresh()
                                        End Sub)
            Else
                ObjetoCalendario.Value = fechaParseada
                ObjetoCalendario.Refresh()
            End If
        Catch ex As Exception
            Debug.Print("AsignarFecha excepción: " & ex.Message)
            Try
                If ObjetoCalendario.InvokeRequired Then
                    ObjetoCalendario.Invoke(Sub() ObjetoCalendario.Value = ObjetoCalendario.MinDate)
                Else
                    ObjetoCalendario.Value = ObjetoCalendario.MinDate
                End If
            Catch
            End Try
            Return False
        End Try

        Debug.Print("AsignarFecha asignó: " & ObjetoCalendario.Value.ToString())
        Return True
    End Function


    '
    '
    '
End Module
'
'
'
