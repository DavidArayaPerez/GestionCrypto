'
'
'
Public Class F_PoolLiquidez
    '
    Private _Fila As Integer = 0  ' reemplaza L_Fila — no visible en pantalla
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpiar()
        Llenar_Exchange(C_Exchange)
        Llenar_Billetera(C_Billetera)
        Llenar_Monedas(C_Moneda1)
        Llenar_Monedas(C_Moneda2)
        LlenarList_PoolLiquidez(L_PoolLiquidez)
        VariableDeInicio = False
    End Sub
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        _Fila = 0
        L_Mensaje.Text = ""
        'POOL LIQUIDEZ
        T_Fecha.Text = ""
        T_Hora.Text = ""
        C_Exchange.Text = ""
        C_Billetera.Text = ""
        C_Moneda1.Text = ""
        T_ValorMoneda1.Text = ""
        C_Moneda2.Text = ""
        T_ValorMoneda2.Text = ""
        T_Comision.Text = ""
        T_Gas.Text = ""
        T_Min.Text = ""
        T_Max.Text = ""
        T_ValorMoneda1Resultante.Text = ""
        T_ValorMoneda2Resultante.Text = ""
        rT_Nota.Text = ""
        '
        T_Fecha.Enabled = Habilitar
        T_Hora.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        C_Billetera.Enabled = Habilitar
        C_Moneda1.Enabled = Habilitar
        T_ValorMoneda1.Enabled = Habilitar
        C_Moneda2.Enabled = Habilitar
        T_ValorMoneda2.Enabled = Habilitar
        T_Comision.Enabled = Habilitar
        T_Gas.Enabled = Habilitar
        T_Min.Enabled = Habilitar
        T_Max.Enabled = Habilitar
        T_ValorMoneda1Resultante.Enabled = Habilitar
        T_ValorMoneda2Resultante.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        CalFechaPool.Enabled = Habilitar
    End Sub
    Private Sub Ver(ByVal Clave As String)
        Limpiar(True)
        Dim F As Integer = BuscarPoolLiquidez(Clave)
        If F < 1 Then Exit Sub
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
        _Fila = F
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
        '13 Porcentaje_Uno — calculado, no editable
        '14 Porcentaje_Dos — calculado, no editable
        T_Min.Text = Matriz_PoolLiquidez(F, 15)
        T_Max.Text = Matriz_PoolLiquidez(F, 16)
        '
        Dim NombreNota As String = "Pool_" & T_Fecha.Text & " " & C_Moneda1.Text & "-" & C_Moneda2.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
    End Sub
    Private Function DatosNoValidos() As Boolean
        If ExisteExchange(C_Exchange.Text) = False Then L_Mensaje.Text = "Plataforma no valida" : Return True
        If ExisteBilletera(C_Billetera.Text) = False Then L_Mensaje.Text = "Billetera no valida" : Return True
        If ExisteMoneda_Simbolo(C_Moneda1.Text) = False Then L_Mensaje.Text = "Moneda 1 no valida" : Return True
        If ExisteMoneda_Simbolo(C_Moneda2.Text) = False Then L_Mensaje.Text = "Moneda 2 no valida" : Return True
        Return False
    End Function
    Private Function PreGrabar() As Boolean
        '           1 Fecha          2 Hora           3 Plataforma        5 Moneda1       7 Moneda2
        Dim T As String = T_Fecha.Text & " " & T_Hora.Text & " - " & C_Exchange.Text & " - " & C_Moneda1.Text & "/" & C_Moneda2.Text
        '
        If _Fila = 0 Then
            Dim F As Integer = BuscarPoolLiquidez(T)
            If F > 0 Then
                MsgBox("El registro ya existe", vbInformation)
                Ver(T)
                Return True
            Else
                F = AgrandarMatriz(Matriz_PoolLiquidez, Matriz_PoolLiquidezTF, Matriz_PoolLiquidezTC)
                _Fila = F
                Matriz_PoolLiquidez(F, 0) = CrearCodigoInterno()
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        If PreGrabar() Then Exit Sub
        '
        Dim F As Integer = _Fila
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
        '13 Porcentaje_Uno — reservado
        '14 Porcentaje_Dos — reservado
        Matriz_PoolLiquidez(F, 15) = T_Min.Text
        Matriz_PoolLiquidez(F, 16) = T_Max.Text
        '
        Guardar_Matrices("PoolLiquidez")
        '
        Dim NombreNota As String = "Pool_" & T_Fecha.Text & " " & C_Moneda1.Text & "-" & C_Moneda2.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        LlenarList_PoolLiquidez(L_PoolLiquidez)
        L_Mensaje.Text = "Pool guardada correctamente"
        'Matriz_PoolLiquidez(F, 0   ID
        'Matriz_PoolLiquidez(F, 1   Fecha
        'Matriz_PoolLiquidez(F, 2   Hora
        'Matriz_PoolLiquidez(F, 3   Plataforma
        'Matriz_PoolLiquidez(F, 4   Billetera
        'Matriz_PoolLiquidez(F, 5   Moneda_Uno
        'Matriz_PoolLiquidez(F, 6   Valor_Uno
        'Matriz_PoolLiquidez(F, 7   Moneda_Dos
        'Matriz_PoolLiquidez(F, 8   Valor_Dos
        'Matriz_PoolLiquidez(F, 9   Comision
        'Matriz_PoolLiquidez(F, 10  Gas
        'Matriz_PoolLiquidez(F, 11  Monto_Uno_Resultante
        'Matriz_PoolLiquidez(F, 12  Monto_Dos_Resultante
        'Matriz_PoolLiquidez(F, 13  Porcentaje_Uno
        'Matriz_PoolLiquidez(F, 14  Porcentaje_Dos
        'Matriz_PoolLiquidez(F, 15  Minimo
        'Matriz_PoolLiquidez(F, 16  Maximo
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
    Private Sub F_PoolLiquidez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub B_GrabarPool_Click(sender As Object, e As EventArgs) Handles B_GrabarPool.Click
        Grabar()
    End Sub
    Private Sub B_Nuevo_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpiar(True)
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Hora.Text = DateTime.Now.ToString("HHmm")
        C_Exchange.Focus()
    End Sub
    Private Sub L_PoolLiquidez_Click(sender As Object, e As EventArgs) Handles L_PoolLiquidez.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_PoolLiquidez.Text)
    End Sub
    Private Sub L_PoolLiquidez_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_PoolLiquidez.SelectedIndexChanged
        '
    End Sub
    Private Sub CalFechaPool_ValueChanged(sender As Object, e As EventArgs) Handles CalFechaPool.ValueChanged
        If VariableDeInicio Then Exit Sub
        T_Fecha.Text = DateTime.Parse(CalFechaPool.Value).ToString("yyyyMMdd")
    End Sub
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
