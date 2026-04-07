'
'
'
'https://github.com/DavidArayaPerez/GestionCrypto
'
Imports System.Diagnostics
Imports System.IO
'
Public Class F_zPrincipal
    '
    '
    '
    Private sw As New Stopwatch()
    Private swTotal As New Stopwatch()
    '
    '
    '
    Private Sub LogTiempo(mensaje As String)
        File.AppendAllText(zCargaInicialTXT, $"{DateTime.Now:HH:mm:ss.fff} | {mensaje} | {sw.ElapsedMilliseconds}ms" & vbCrLf)
        sw.Restart()
    End Sub
    '
    '
    Public Sub New()
        swTotal.Start()  ' <-- Inicio del contador principal
        '
        sw.Start()
        InitializeComponent()
        sw.Stop()
        File.AppendAllText(zCargaInicialTXT, $"=== CARGA INICIAL {DateTime.Now:dd-MM-yyyy HH:mm:ss} ===" & vbCrLf)
        File.AppendAllText(zCargaInicialTXT, $"00:00:00.000 | InitializeComponent | {sw.ElapsedMilliseconds}ms" & vbCrLf)
        sw.Restart()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogTiempo("Hasta Form_Load")

        'VariableDeInicio = True
        Parametros()
        LogTiempo("Parametros()")

        '1: Redes / Es el corazon del programa
        CargaRedes() 'OrdenarMatriz(Matriz_Redes, Matriz_RedesTF, Matriz_RedesTC, 2, "DES") 'Guardar_Matrices("Redes")
        LogTiempo("Redes")
        '
        '2.- Billeteras
        CargaBilleteras()
        LogTiempo("Billeteras")
        '
        '3.- Las Monedas
        CargaMonedas()
        LogTiempo("Monedas")
        '
        '4.- Exchange
        CargaExchange()
        LogTiempo("Exchange")
        '
        '
        CargaBilleteraSaldo()
        LogTiempo("BilleteraSaldo")
        '
        '
        CargaValorUSD()
        LogTiempo("ValorUSD")
        '
        '
        CargaCompras() 'Transformar_Fechas_Compras()
        LogTiempo("Compras")
        '
        CargaTraspasos() 'Transformar_Fechas_Traspasos()
        LogTiempo("Traspasos")
        '
        CargaPoolLiquidez() 'Transformar_Fechas_PoolLiquidez()
        LogTiempo("PoolLiquidez")
        '
        '
        '
        'VariableDeInicio = False
        swTotal.Stop()
        File.AppendAllText(zCargaInicialTXT, $">>> TIEMPO TOTAL: {swTotal.ElapsedMilliseconds}ms ({swTotal.Elapsed.TotalSeconds:F2}s)" & vbCrLf)
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    '
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        End
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    Private Sub B_Redes_Click(sender As Object, e As EventArgs) Handles B_Redes.Click
        F_Red.Show()
    End Sub
    Private Sub B_Monedas_Click(sender As Object, e As EventArgs) Handles B_Monedas.Click
        F_Monedas.Show()
    End Sub
    Private Sub B_Dolar_Click(sender As Object, e As EventArgs) Handles B_Dolar.Click
        F_Dolar.Show()
    End Sub
    Private Sub B_Billetera_Click(sender As Object, e As EventArgs) Handles B_Billetera.Click
        F_Billetera.Show()
    End Sub
    Private Sub B_Compras_Click(sender As Object, e As EventArgs) Handles B_Compras.Click
        F_Compra.Show()
    End Sub
    Private Sub B_PoolLiquidez_Click(sender As Object, e As EventArgs) Handles B_PoolLiquidez.Click
        F_PoolLiquidez.Show()
    End Sub
    Private Sub B_Exchange_Click(sender As Object, e As EventArgs) Handles B_Exchange.Click
        F_Exchange.Show()
    End Sub
    Private Sub B_Traspasos_Click(sender As Object, e As EventArgs) Handles B_Traspasos.Click
        F_Traspaso.Show()
    End Sub

    Private Sub B_Transacciones_Click(sender As Object, e As EventArgs) Handles B_Transacciones.Click
        F_Transacciones.Show()
    End Sub
    '
    '
    '
End Class