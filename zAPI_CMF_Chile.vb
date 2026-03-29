'
'
'
Imports System.Net
Imports System.Net.Http
Imports System.Xml
Imports System.Globalization
'
'https://api.cmfchile.cl/
'APIKEY:                    b51b2c4ee645a68cdd565cd345082d34a227cadc
'URL XML Dolar 2026         https://api.cmfchile.cl/api-sbifv3/recursos_api/dolar/2026?apikey=b51b2c4ee645a68cdd565cd345082d34a227cadc&formato=xml
'
'
'
Module zAPI_CMF_Chile
    '
    '
    '
    Public ValorDolar As Double
    '
    '
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
            '
            Dim nodes As XmlNodeList = doc.SelectNodes("//ns:Dolar", nsmgr)
            If nodes Is Nothing OrElse nodes.Count = 0 Then
                ' Intento alternativo: buscar bajo Dolares sin prefijo (por si no se aplicó el namespace)
                nodes = doc.SelectNodes("//Dolar")
            End If
            '
            If nodes IsNot Nothing Then
                For Each n As XmlNode In nodes
                    Dim fechaNode As XmlNode = n.SelectSingleNode("ns:Fecha", nsmgr)
                    Dim valorNode As XmlNode = n.SelectSingleNode("ns:Valor", nsmgr)
                    If fechaNode Is Nothing Then fechaNode = n.SelectSingleNode("Fecha")
                    If valorNode Is Nothing Then valorNode = n.SelectSingleNode("Valor")
                    '
                    If fechaNode IsNot Nothing AndAlso valorNode IsNot Nothing Then
                        'Normaliza la fecha en formato yyyyMMdd
                        Dim fecha As String = fechaNode.InnerText.Trim()
                        Dim FechaAux As String = TransformarFecha_TextoNumero_YYYYmmDD(fecha)
                        If FechaAux > 1 Then fecha = FechaAux
                        '
                        'Normalizar número: quitar separadores de miles y usar punto como separador decimal
                        Dim valorText As String = valorNode.InnerText.Trim()
                        valorText = valorText.Replace(".", "").Replace(",", ".")
                        Dim valor As Double
                        If Double.TryParse(valorText, NumberStyles.Any, CultureInfo.InvariantCulture, valor) Then result.Add(New KeyValuePair(Of String, Double)(fecha, valor))
                        '
                    End If
                Next
            End If
            '
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