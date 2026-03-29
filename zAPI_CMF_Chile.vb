'
'
'
Imports System.Net
Imports System.Net.Http
Imports System.Xml
Imports System.Globalization
'
'
'
Module zAPI_CMF_Chile
    'https://api.cmfchile.cl/
    'APIKEY:b51b2c4ee645a68cdd565cd345082d34a227cadc
    'https://api.cmfchile.cl/api-sbifv3/recursos_api/dolar/2026?apikey=b51b2c4ee645a68cdd565cd345082d34a227cadc&formato=xml
    '
    Public RutaAPI_CMF_UF As String = "https://api.cmfchile.cl/api-sbifv3/recursos_api/uf?apikey=b51b2c4ee645a68cdd565cd345082d34a227cadc&formato=json"
    Public RutaAPI_CMF_UTM As String = "https://api.cmfchile.cl/api-sbifv3/recursos_api/utm?apikey=b51b2c4ee645a68cdd565cd345082d34a227cadc&formato=json"
    Public RutaAPI_CMF_DOLAR As String = "https://api.cmfchile.cl/api-sbifv3/recursos_api/dolar?apikey=b51b2c4ee645a68cdd565cd345082d34a227cadc&formato=json"
    '
    Public ValorUTM As Double
    Public ValorDolar As Double
    Public ValorUF As Double
    '
    '
    Public Function ApiIsAlive(apiUrl As String, Optional timeoutMs As Integer = 3000) As Boolean
        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromMilliseconds(timeoutMs)
                'Pedimos sólo encabezados para comprobar disponibilidad rápidamente
                'Con ello evitamos que si el sitio no esta disponible se quede pegado el aplicativo
                Dim response = client.GetAsync(apiUrl, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult()
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            ' Cualquier excepción => API no disponible (timeout, DNS, conexión, TLS, etc.)
            Return False
        End Try
    End Function
    '
    Public Function GetAccountInfoFromApi(accountInformationUrl As String) As String
        Dim webClient As WebClient = New WebClient()
        Try
            Return webClient.DownloadString(New Uri(accountInformationUrl))
        Catch ex As WebException
            If ex.Status = WebExceptionStatus.ProtocolError AndAlso ex.Response IsNot Nothing Then
                Dim resp = DirectCast(ex.Response, HttpWebResponse)
                If resp.StatusCode = HttpStatusCode.NotFound Then
                    Return "" ' "Error 404: Recurso no encontrado"
                End If
            End If
            Return ""
        Catch ex As Exception
            Return ""
        End Try
    End Function
    '
    Public Function P_Datos_UF_HOY() As String
        Dim T As String
        Dim x As Long
        '
        T = GetAccountInfoFromApi(RutaAPI_CMF_UF)
        If T = "" Then
            MsgBox("Existe un error con la API de CMF Chile")
            Return "1"
        End If
        '
        'Quita caracteres para llegar al final del valor de la UF
        T = Replace(T, Chr(10), "")
        T = Replace(T, vbCrLf, "")
        T = Replace(T, Chr(34), "")
        '
        T = Replace(T, "{", "")
        T = Replace(T, "}", "")
        T = Replace(T, "[", "")
        T = Replace(T, "]", "")
        'T = Replace(T, ".", "")
        x = InStr(1, T, "V") + 7      'Valor :
        T = Mid(T, x)
        '
        x = InStr(T, ",") + 2
        T = Trim(Mid(T, 1, x))
        '
        Return T
    End Function
    '
    Public Function P_Datos_UTM_HOY() As String
        Dim T As String
        Dim x As Integer
        '
        T = GetAccountInfoFromApi(RutaAPI_CMF_UTM)
        If T = "" Then
            MsgBox("Existe un error con la API de CMF Chile")
            Return "1"
        End If
        '
        T = Replace(T, Chr(10), "")
        T = Replace(T, vbCrLf, "")
        T = Replace(T, Chr(34), "")
        '
        T = Replace(T, "{", "")
        T = Replace(T, "}", "")
        T = Replace(T, "[", "")
        T = Replace(T, "]", "")
        ' T = Replace(T, ".", "")
        x = InStr(1, T, "V") + 7      'Valor :
        T = Mid(T, x)
        '
        x = InStr(1, T, ",") - 1
        T = Trim(Mid(T, 1, x))
        '
        Return T
    End Function
    '
    Public Function P_Datos_DOLAR_HOY() As String
        Dim T As String
        Dim x As Integer
        '
        T = GetAccountInfoFromApi(RutaAPI_CMF_DOLAR)
        If T = "" Then
            MsgBox("Existe un error con la API de CMF Chile")
            Return "1"
        End If
        '
        T = Replace(T, Chr(10), "")
        T = Replace(T, vbCrLf, "")
        T = Replace(T, Chr(34), "")
        '
        T = Replace(T, "{", "")
        T = Replace(T, "}", "")
        T = Replace(T, "[", "")
        T = Replace(T, "]", "")
        ' T = Replace(T, ".", "")
        x = InStr(1, T, "V") + 7      'Valor :
        T = Mid(T, x)
        '
        x = InStr(T, ",") + 1
        x = InStr(x, T, ",") - 1
        T = Trim(Mid(T, 1, x))
        '
        Return T
    End Function
    '
    ' Nueva función: lee la API de dólares en formato XML y devuelve una lista Fecha/Valor
    Public Function APICMF_DOLAR_XML(Optional ByVal year As Integer = 2026) As List(Of KeyValuePair(Of String, Double))
        Dim result As New List(Of KeyValuePair(Of String, Double))()
        Dim apiKey As String = "b51b2c4ee645a68cdd565cd345082d34a227cadc"
        Dim url As String = $"https://api.cmfchile.cl/api-sbifv3/recursos_api/dolar/{year}?apikey={apiKey}&formato=xml"
        Try
            Dim xml As String = New WebClient().DownloadString(New Uri(url))
            Dim doc As New XmlDocument()
            doc.LoadXml(xml)
            ' El XML del servicio usa un namespace por defecto (http://api.sbif.cl).
            ' Usar XmlNamespaceManager y XPath para localizar los nodos <Dolar> correctamente.
            Dim nsmgr As New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("ns", "http://api.sbif.cl")

            Dim nodes As XmlNodeList = doc.SelectNodes("//ns:Dolar", nsmgr)
            If nodes Is Nothing OrElse nodes.Count = 0 Then
                ' Intento alternativo: buscar bajo Dolares sin prefijo (por si no se aplicó el namespace)
                nodes = doc.SelectNodes("//Dolar")
            End If

            If nodes IsNot Nothing Then
                For Each n As XmlNode In nodes
                    Dim fechaNode As XmlNode = n.SelectSingleNode("ns:Fecha", nsmgr)
                    Dim valorNode As XmlNode = n.SelectSingleNode("ns:Valor", nsmgr)
                    If fechaNode Is Nothing Then fechaNode = n.SelectSingleNode("Fecha")
                    If valorNode Is Nothing Then valorNode = n.SelectSingleNode("Valor")
                    If fechaNode IsNot Nothing AndAlso valorNode IsNot Nothing Then
                        Dim fecha As String = fechaNode.InnerText.Trim()
                        Dim valorText As String = valorNode.InnerText.Trim()
                        ' Normalizar número: quitar separadores de miles y usar punto como separador decimal
                        valorText = valorText.Replace(".", "").Replace(",", ".")
                        Dim valor As Double
                        If Double.TryParse(valorText, NumberStyles.Any, CultureInfo.InvariantCulture, valor) Then
                            result.Add(New KeyValuePair(Of String, Double)(fecha, valor))
                        End If
                    End If
                Next
            End If

            Return result
        Catch ex As Exception
            MsgBox("Error leyendo API DOLAR (XML): " & ex.Message)
            Return result
        End Try
    End Function
    '
End Module
'
'
'