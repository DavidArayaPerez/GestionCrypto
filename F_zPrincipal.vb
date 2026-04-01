'
'
Imports System.Diagnostics
Imports System.IO
'
Public Class F_zPrincipal
    '
    '
    '
    Private sw As New Stopwatch()

    Public Sub New()
        sw.Start()
        InitializeComponent()
        sw.Stop()
        File.WriteAllText(zCargaInicialTXT, $"=== CARGA INICIAL {DateTime.Now:dd-MM-yyyy HH:mm:ss} ===" & vbCrLf)
        File.AppendAllText(zCargaInicialTXT, $"00:00:00.000 | InitializeComponent | {sw.ElapsedMilliseconds}ms" & vbCrLf)
        sw.Restart()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogTiempo("Hasta Form_Load")

        'VariableDeInicio = True
        Parametros()
        LogTiempo("Parametros()")

        CargarTXT("Exchange", Matriz_Exchange)
        CargarTXT("Billeteras", Matriz_Billeteras)
        LogTiempo("Exchange+Billeteras")

        CargarTXT("Depositos", Matriz_Depositos)
        Transformar_Fechas_Depositos()
        LogTiempo("Depositos+Transform")

        CargarTXT("Compras", Matriz_Compras)
        Transformar_Fechas_Compras()
        LogTiempo("Compras+Transform")

        CargarTXT("Traspasos", Matriz_Traspasos)
        Transformar_Fechas_Traspasos()
        LogTiempo("Traspasos+Transform")

        CargarTXT("PoolLiquidez", Matriz_PoolLiquidez)
        Transformar_Fechas_PoolLiquidez()
        LogTiempo("Pool+Transform")

        CargarTXT("Movimientos", Matriz_Movimientos)
        Transformar_Fechas_Movimientos()
        LogTiempo("Movimientos+Transform")

        CargarTXT("Redes", Matriz_Redes)
        CargarTXT("Monedas", Matriz_Monedas)
        CargarTXT("ValorUSD", Matriz_ValorUSD)
        LogTiempo("Redes+Monedas+USD")
        '
        'VariableDeInicio = False
        LogTiempo("TOTAL Form_Load completado")
    End Sub



    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '

    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        End
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    Private Sub B_Redes_Click(sender As Object, e As EventArgs) Handles B_Redes.Click
        F_Red.ShowDialog()
    End Sub
    Private Sub B_Monedas_Click(sender As Object, e As EventArgs) Handles B_Monedas.Click
        F_Monedas.ShowDialog()
    End Sub
    Private Sub B_Dolar_Click(sender As Object, e As EventArgs) Handles B_Dolar.Click
        F_Dolar.ShowDialog()
    End Sub

    '
    '
    '
    '
    '
End Class
'
'
'
