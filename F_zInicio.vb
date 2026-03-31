'
'
'

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
        'Carga valores actualizados del DOLAR
        'GuardarValorUSD(2022)  GuardarValorUSD(2023)   GuardarValorUSD(2024)   GuardarValorUSD(2025)
        GuardarValorUSD(2026)
        CargarTXT("ValorUSD", Matriz_ValorUSD)
        '
        '
        CargarTXT("Redes", Matriz_Redes)                'CambiarIDRedes()
        '
        '
        CargarTXT("Monedas", Matriz_Monedas)
        OrdenarMatriz_Monedas()
        '
        '
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
        '
        '
        CargaFormulario()
        Me.Close()
        '
        'Como tercer paso se cargan las relaciones que hay entre la Solicitud y los Expedientes, OrdenCompra y Documentos
        'CargarTXT("Pares", Matriz_Pares)
    End Sub
    '
    '
    '
End Class