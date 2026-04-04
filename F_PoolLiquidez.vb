'
'
'
Public Class F_PoolLiquidez
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpiar()
        Llenar_Exchange(C_Exchange)
        Llenar_Billetera(C_Billetera)
        Llenar_Monedas(C_Moneda1)
        Llenar_Monedas(C_Moneda2)
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        'POOL LIQUIDEZ
        T_Fecha.Text = ""
        T_Hora.Text = ""
        C_Moneda1.Text = ""
        C_Moneda2.Text = ""
        T_ValorMoneda1.Text = ""
        T_ValorMoneda2.Text = ""
        T_Comision.Text = ""
        T_Gas.Text = ""
        T_Min.Text = ""
        T_Max.Text = ""
        C_Exchange.Text = ""
        C_Billetera.Text = ""
        T_ValorMoneda1Resultante.Text = ""
        T_ValorMoneda2Resultante.Text = ""
        rT_Nota.Text = ""
        '
        T_Fecha.Enabled = Habilitar
        T_Hora.Enabled = Habilitar
        C_Moneda1.Enabled = Habilitar
        C_Moneda2.Enabled = Habilitar
        T_ValorMoneda1.Enabled = Habilitar
        T_ValorMoneda2.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        C_Billetera.Enabled = Habilitar
        T_ValorMoneda1Resultante.Enabled = Habilitar
        T_ValorMoneda2Resultante.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
    End Sub
    Private Sub Ver(F As Integer)
        Limpiar(True)
        If F < 1 Then Exit Sub
        '
        T_Fecha.Text = Matriz_PoolLiquidez(F, 1)
        T_Hora.Text = Matriz_PoolLiquidez(F, 2)
        C_Exchange.Text = Matriz_PoolLiquidez(F, 3)
        C_Billetera.Text = Matriz_PoolLiquidez(F, 4)
        C_Moneda1.Text = Matriz_PoolLiquidez(F, 5)
        T_ValorMoneda1.Text = Matriz_PoolLiquidez(F, 6)
        C_Moneda2.Text = Matriz_PoolLiquidez(F, 7)
        T_ValorMoneda2.Text = Matriz_PoolLiquidez(F, 8)
        T_Comision.Text = Matriz_PoolLiquidez(F, 9)
        T_Gas.Text = Matriz_PoolLiquidez(F, 10)
        T_ValorMoneda1Resultante.Text = Matriz_PoolLiquidez(F, 11)
        T_ValorMoneda2Resultante.Text = Matriz_PoolLiquidez(F, 12)
        '13
        '14
        T_Min.Text = Matriz_PoolLiquidez(F, 15)
        T_Max.Text = Matriz_PoolLiquidez(F, 16)
        '
        Dim NombreNota As String = "Pool_" & T_Fecha.Text & " " & C_Moneda1.Text & "-" & C_Moneda2.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
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
    End Sub
    Private Function DatosNoValidos() As Boolean
        '
        If Buscar_Exchange(C_Exchange.Text) = "N" Then L_Mensaje.Text = "Plataforma no válida" : Return True
        If Buscar_Billetera(C_Billetera.Text) = "N" Then L_Mensaje.Text = "Billetera no válida" : Return True
        If Buscar_Moneda(C_Moneda1.Text) = "N" Then L_Mensaje.Text = "Moneda 1 no válida" : Return True
        If Buscar_Moneda(C_Moneda2.Text) = "N" Then L_Mensaje.Text = "Moneda 2 no válida" : Return True
        '
        Return False
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        '
        Dim F As Integer = L_Fila.Text
        If F = 0 Then
            F = AgrandarMatriz(Matriz_PoolLiquidez, Matriz_PoolLiquidezTF, Matriz_PoolLiquidezTC)
            Matriz_PoolLiquidez(F, 0) = CrearCodigoInterno()
        End If
        Matriz_PoolLiquidez(F, 1) = T_Fecha.Text
        Matriz_PoolLiquidez(F, 2) = T_Hora.Text
        Matriz_PoolLiquidez(F, 3) = C_Exchange.Text
        Matriz_PoolLiquidez(F, 4) = C_Billetera.Text
        Matriz_PoolLiquidez(F, 5) = C_Moneda1.Text
        Matriz_PoolLiquidez(F, 6) = T_ValorMoneda1.Text
        Matriz_PoolLiquidez(F, 7) = C_Moneda2.Text
        Matriz_PoolLiquidez(F, 8) = T_ValorMoneda2.Text
        Matriz_PoolLiquidez(F, 9) = T_Comision.Text
        Matriz_PoolLiquidez(F, 10) = T_Gas.Text
        Matriz_PoolLiquidez(F, 11) = T_ValorMoneda1Resultante.Text
        Matriz_PoolLiquidez(F, 12) = T_ValorMoneda2Resultante.Text
        '13
        '14
        Matriz_PoolLiquidez(F, 15) = T_Min.Text
        Matriz_PoolLiquidez(F, 16) = T_Max.Text
        '
        Guardar_Matrices("PoolLiquidez")
        '
        Dim NombreNota As String = "Pool_" & T_Fecha.Text & " " & C_Moneda1.Text & "-" & C_Moneda2.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Pool guardada correctamente"
        'Matriz_Compras(F,0   ID
        'Matriz_Compras(F,1   Fecha
        'Matriz_Compras(F,2   Hora
        'Matriz_Compras(F,3   Plataforma      MetraMask, Uniswap, etc
        'Matriz_Compras(F,4   Moneda_Origen
        'Matriz_Compras(F,5   Valor_Origen
        'Matriz_Compras(F,6   Moneda_Destino
        'Matriz_Compras(F,7   Valor_Destino
        'Matriz_Compras(F,8   Comision
        'Matriz_Compras(F,9   Gas
        'Matriz_Compras(F,10  Precio
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
    Private Sub B_GrabarPool_Click(sender As Object, e As EventArgs) Handles B_GrabarPool.Click
        Grabar()
    End Sub
    Private Sub B_Nuevo_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpiar(True)
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Hora.Text = DateTime.Now.ToString("HHmmss")
        C_Exchange.Focus()
    End Sub
    '
    '
    '
    Private Sub T_ValorMoneda1_TextChanged(sender As Object, e As EventArgs) Handles T_ValorMoneda1.TextChanged
        '
    End Sub
    Private Sub T_ValorMoneda1Resultante_TextChanged(sender As Object, e As EventArgs) Handles T_ValorMoneda1Resultante.TextChanged
        '
    End Sub
    Private Sub T_ValorMoneda2_TextChanged(sender As Object, e As EventArgs) Handles T_ValorMoneda2.TextChanged
        '
    End Sub
    Private Sub T_ValorMoneda2Resultante_TextChanged(sender As Object, e As EventArgs) Handles T_ValorMoneda2Resultante.TextChanged
        '
    End Sub
    Private Sub T_Min_TextChanged(sender As Object, e As EventArgs) Handles T_Min.TextChanged
        '
    End Sub
    Private Sub T_Max_TextChanged(sender As Object, e As EventArgs) Handles T_Max.TextChanged
        '
    End Sub
    Private Sub T_Comision_TextChanged(sender As Object, e As EventArgs) Handles T_Comision.TextChanged
        '
    End Sub
    Private Sub T_Gas_TextChanged(sender As Object, e As EventArgs) Handles T_Gas.TextChanged
        '
    End Sub
    '
    '
    '
    Private Sub T_ValorMoneda1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorMoneda1.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorMoneda1, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_ValorMoneda1Resultante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorMoneda1Resultante.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorMoneda1Resultante, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_ValorMoneda2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorMoneda2.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorMoneda2, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_ValorMoneda2Resultante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_ValorMoneda2Resultante.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_ValorMoneda2Resultante, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Min_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Min.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Min, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Max_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Max.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Max, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Comision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Comision.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Comision, sender, e) Then e.Handled = True
    End Sub
    Private Sub T_Gas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles T_Gas.KeyPress
        If VariableDeInicio Then Exit Sub
        If SoloNumero_KeyPress(T_Gas, sender, e) Then e.Handled = True
    End Sub




    '
    '
    '
End Class