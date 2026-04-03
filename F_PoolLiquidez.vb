'
'
'
Public Class F_PoolLiquidez
    '
    '
    '
    Private Sub LimpiezaPool(Optional Habilitar As Boolean = False)
        'POOL LIQUIDEZ
        T_FechaPool.Text = ""
        T_HoraPool.Text = ""
        C_Moneda1Pool.Text = ""
        C_Moneda2Pool.Text = ""
        T_ValorMoneda1Pool.Text = ""
        T_ValorMoneda2Pool.Text = ""
        T_ComisionPool.Text = ""
        T_GasPool.Text = ""
        T_MinPool.Text = ""
        T_MaxPool.Text = ""
        C_ExchangePool.Text = ""
        C_BilleteraPool.Text = ""
        T_ValorMoneda1ResultantePool.Text = ""
        T_ValorMoneda2ResultantePool.Text = ""

        rT_NotaPool.Text = ""
        '
        T_FechaPool.Enabled = Habilitar
        T_HoraPool.Enabled = Habilitar
        C_Moneda1Pool.Enabled = Habilitar
        C_Moneda2Pool.Enabled = Habilitar
        T_ValorMoneda1Pool.Enabled = Habilitar
        T_ValorMoneda2Pool.Enabled = Habilitar
        T_ComisionPool.Enabled = Habilitar
        T_GasPool.Enabled = Habilitar
        C_ExchangePool.Enabled = Habilitar
        C_BilleteraPool.Enabled = Habilitar
        T_ValorMoneda1ResultantePool.Enabled = Habilitar
        T_ValorMoneda2ResultantePool.Enabled = Habilitar

        rT_NotaPool.Enabled = Habilitar
    End Sub
    Private Sub VerPool(F As Integer)
        LimpiezaPool(True)
        If F < 1 Then Exit Sub

        T_FechaPool.Text = Matriz_PoolLiquidez(F, 1)
        T_HoraPool.Text = Matriz_PoolLiquidez(F, 2)
        C_ExchangePool.Text = Matriz_PoolLiquidez(F, 3)
        C_BilleteraPool.Text = Matriz_PoolLiquidez(F, 4)
        C_Moneda1Pool.Text = Matriz_PoolLiquidez(F, 5)
        T_ValorMoneda1Pool.Text = Matriz_PoolLiquidez(F, 6)
        C_Moneda2Pool.Text = Matriz_PoolLiquidez(F, 7)
        T_ValorMoneda2Pool.Text = Matriz_PoolLiquidez(F, 8)
        T_ComisionPool.Text = Matriz_PoolLiquidez(F, 9)
        T_GasPool.Text = Matriz_PoolLiquidez(F, 10)
        T_ValorMoneda1ResultantePool.Text = Matriz_PoolLiquidez(F, 11)
        T_ValorMoneda2ResultantePool.Text = Matriz_PoolLiquidez(F, 12)
        '13
        '14
        T_MinPool.Text = Matriz_PoolLiquidez(F, 15)
        T_MaxPool.Text = Matriz_PoolLiquidez(F, 16)
        '
        'Dim NombreNota As String = T_FechaPool.Text & "_" & T_HoraPool.Text & "_" & "Pool" & "_Nota.rtf"
        'CargaRTF(RutaLocal, NombreNota, rT_NotaPool)
        '
        '   0   ID
        '   1   Fecha
        '   2   Hora
        '   3   Plataforma      MetraMask, Uniswap, etc
        '   4   Billetera
        '   5   Moneda_Uno
        '   6   Valor_Uno
        '   7   Moneda_Dos
        '   8   Valor_Dos
        '   9   Comision
        '   10  Gas
        '   11  Monto_Uno_Resultante
        '   12  Monto_Dos_Resultante
        '   13  Porcentaje_Uno
        '   14  Porcentaje_Dos
        '   15  Minimo
        '   16  Maximo
        '
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
        Me.Close()
    End Sub


    '
    '
    '
End Class