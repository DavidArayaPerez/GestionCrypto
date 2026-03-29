'
'
'
Imports System.IO
'
'
'
Public Class F_zInicio
    '
    '
    '
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        Parametros()
        '
        CargarTXT("Monedas", Matriz_Monedas)
        CargarTXT("Exchange", Matriz_Exchange)
        CargarTXT("Billeteras", Matriz_Billeteras)
        '
        CargarTXT("Depositos", Matriz_Depositos)
        Transformar_Fechas_Depositos()
        Ordenar_Depositos()
        '
        CargarTXT("Compras", Matriz_Compras)
        Transformar_Fechas_Compras()
        Ordenar_Compras()
        '
        CargarTXT("Traspasos", Matriz_Traspasos)
        Transformar_Fechas_Traspasos()
        Ordenar_Traspasos()
        '
        CargarTXT("PoolLiquidez", Matriz_PoolLiquidez)
        Transformar_Fechas_PoolLiquidez()
        Ordenar_PoolLiquidez()
        '
        CargarTXT("Movimientos", Matriz_Movimientos)
        Transformar_Fechas_Movimientos()
        Ordenar_Movimientos()
        '
        CargarTXT("Redes", Matriz_Redes)                'CambiarIDRedes()
        '
        GuardarValorUSD(2022)
        GuardarValorUSD(2023)
        GuardarValorUSD(2024)
        GuardarValorUSD(2025)
        GuardarValorUSD(2026)
        CargarTXT("ValorUSD", Matriz_ValorUSD)
        '

        F_Solicitud.Inicializacion()
        F_Solicitud.ShowDialog()
        Me.Close()
        '
        'Como tercer paso se cargan las relaciones que hay entre la Solicitud y los Expedientes, OrdenCompra y Documentos
        'CargarTXT("Pares", Matriz_Pares)
        '
        '
    End Sub
    Public Sub Parametros()
        Dim NombreArchivo As String = "zParametros.txt"
        Dim CarpetaInicio As String = Application.StartupPath
        Dim RutaArchivo As String = CarpetaInicio & "\" & NombreArchivo
        Dim Lineas(), ArchivoFinal(), Elementos(), Linea, Texto As String
        Dim Fila, Total, Contador As Integer
        Dim ACTUALIZACION_UF As String = "SI"
        Dim ACTUALIZACION_UTM As String = "SI"
        Dim ACTUALIZACION_DOLAR As String = "SI"
        '
        If Not ExisteArchivo(RutaArchivo) Then
            Texto = "El archivo de configuracion no fue encontrado" & vbCrLf
            Texto &= "Nombre Archivo: " & NombreArchivo & vbCrLf
            Texto &= "Ruta: " & CarpetaInicio & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        Lineas = File.ReadAllLines(RutaArchivo)
        Total = Lineas.Length
        If Lineas.Length = 0 Then
            Texto = "El archivo de configuracion No tiene datos" & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        ReDim ArchivoFinal(Total)
        Contador = -1
        '
        For Fila = 0 To Total - 1
            Linea = Lineas(Fila)
            If Linea.Trim = "" Then Continue For
            '
            Elementos = Linea.Split(vbTab)
            Select Case Elementos(0)
                Case "RUTA_LOCAL"
                    RutaLocal = Elementos(1)
                    Contador += 1
                    ArchivoFinal(Contador) = Elementos(0) & vbTab & Elementos(1)
                Case "DOLAR"
                    If ValorUSD = 0 Then
                        ValorUSD = CDbl(Elementos(1))
                        ACTUALIZACION_UTM = "NO"
                    End If
                    Contador += 1
                    ArchivoFinal(Contador) = Elementos(0) & vbTab & ValorUSD
            End Select
        Next Fila
        '
        If RutaLocal = "" Then
            Texto = "No fue encontrada la variable RUTA local" & vbCrLf
            MsgBox(Texto, vbCritical, "Error Grave")
            End
        End If
        '
        ReDim Preserve ArchivoFinal(Contador + 4)
        ArchivoFinal(Contador + 1) = "ULTIMO_INGRESO" & vbTab & Texto_FechaHoraActual()
        ArchivoFinal(Contador + 4) = "ACTUALIZACION_DOLAR" & vbTab & ACTUALIZACION_DOLAR
        GuardarParametros(RutaArchivo, ArchivoFinal)
        '
    End Sub
    '
    '
    '
End Class
'
'
'