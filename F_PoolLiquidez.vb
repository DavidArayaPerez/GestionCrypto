'
'
'
Public Class F_PoolLiquidez
    '
    Private F As Integer = 0
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpiar()
        Llenar_Billetera(C_Billetera)
        Llenar_Exchange(C_Exchange)
        LlenarList_PoolLiquidez(L_PoolLiquidez)
        ConfigurarDGV()
        VariableDeInicio = False
    End Sub
    '
    Private Sub Limpiar(Optional Habilitar As Boolean = False)
        F = 0
        L_Fila.Text = ""
        L_Mensaje.Text = ""
        T_Fecha.Text = ""
        C_Billetera.Text = ""
        C_Exchange.Text = ""
        T_Link.Text = ""
        rT_Nota.Text = ""
        DGV.Rows.Clear()
        '
        T_Fecha.Enabled = Habilitar
        C_Billetera.Enabled = Habilitar
        C_Exchange.Enabled = Habilitar
        T_Link.Enabled = Habilitar
        rT_Nota.ReadOnly = Not Habilitar
        B_Grabar.Enabled = Habilitar
        B_Actualizar.Enabled = False
        CalFechaPool.Enabled = Habilitar
    End Sub
    '
    Private Sub Ver(ByVal Clave As String)
        Limpiar(True)
        F = BuscarPoolLiquidez(Clave)
        If F < 1 Then Exit Sub
        '
        L_Fila.Text = F
        T_Fecha.Text = Matriz_PoolLiquidez(F, 1)
        C_Billetera.Text = Matriz_PoolLiquidez(F, 2)
        C_Exchange.Text = Matriz_PoolLiquidez(F, 3)
        T_Link.Text = Matriz_PoolLiquidez(F, 4)
        '
        ' Cargar nota RTF
        Dim T As String = Matriz_PoolLiquidez(F, 13)
        If T <> "" Then CargaRTF(RutaLocal, T, rT_Nota)
        '
        ' Mostrar datos en DGV si existen
        MostrarDatosPool(F)
        '
        ' Habilitar Actualizar solo si hay billetera y exchange
        If C_Billetera.Text <> "" AndAlso C_Exchange.Text <> "" Then B_Actualizar.Enabled = True
        '
        '   0   ID
        '   1   Fecha
        '   2   ID_Billetera
        '   3   Exchange
        '   4   Link
        '   5   Token1_Simbolo
        '   6   Token1_Cantidad
        '   7   Token1_USD
        '   8   Token2_Simbolo
        '   9   Token2_Cantidad
        '   10  Token2_USD
        '   11  Fees_USD
        '   12  Total_USD
        '   13  Nombre_RTF
    End Sub
    '
    Private Sub ConfigurarDGV()
        DGV.Columns.Clear()
        DGV.AllowUserToAddRows = False
        DGV.ReadOnly = True
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '
        DGV.Columns.Add("Token1", "Token 1")
        DGV.Columns.Add("Cantidad1", "Cantidad")
        DGV.Columns.Add("USD1", "USD")
        DGV.Columns.Add("Token2", "Token 2")
        DGV.Columns.Add("Cantidad2", "Cantidad")
        DGV.Columns.Add("USD2", "USD")
        DGV.Columns.Add("Fees", "Fees USD")
        DGV.Columns.Add("Total", "Total USD")
    End Sub
    '
    Private Sub MostrarDatosPool(ByVal F As Integer)
        DGV.Rows.Clear()
        If Matriz_PoolLiquidez(F, 5) = "" AndAlso Matriz_PoolLiquidez(F, 8) = "" Then Exit Sub
        '
        DGV.Rows.Add(
            Matriz_PoolLiquidez(F, 5),
            Matriz_PoolLiquidez(F, 6),
            Matriz_PoolLiquidez(F, 7),
            Matriz_PoolLiquidez(F, 8),
            Matriz_PoolLiquidez(F, 9),
            Matriz_PoolLiquidez(F, 10),
            Matriz_PoolLiquidez(F, 11),
            Matriz_PoolLiquidez(F, 12))
    End Sub
    '
    Private Function DatosNoValidos() As Boolean
        If T_Fecha.Text = "" Then L_Mensaje.Text = "Ingrese una fecha" : Return True
        If C_Billetera.Text = "" Then L_Mensaje.Text = "Seleccione una billetera" : Return True
        If C_Exchange.Text = "" Then L_Mensaje.Text = "Seleccione un Exchange" : Return True
        Return False
    End Function
    '
    Private Sub Grabar()
        If DatosNoValidos() Then Exit Sub
        '
        If F = 0 Then
            F = AgrandarMatriz(Matriz_PoolLiquidez, Matriz_PoolLiquidezTF, Matriz_PoolLiquidezTC)
            Matriz_PoolLiquidez(F, 0) = CrearCodigoInterno()
            L_Fila.Text = F
        End If
        '
        Matriz_PoolLiquidez(F, 1) = T_Fecha.Text
        Matriz_PoolLiquidez(F, 2) = C_Billetera.Text
        Matriz_PoolLiquidez(F, 3) = C_Exchange.Text
        Matriz_PoolLiquidez(F, 4) = T_Link.Text
        '
        ' Nombre RTF basado en ID
        Dim nombreRTF As String = "Pool_" & Matriz_PoolLiquidez(F, 0) & ".rtf"
        Matriz_PoolLiquidez(F, 13) = nombreRTF
        If rT_Nota.Text <> "" Then GuardarRTF(RutaLocal, nombreRTF, rT_Nota)
        '
        Guardar_Matrices("PoolLiquidez")
        LlenarList_PoolLiquidez(L_PoolLiquidez)
        L_Mensaje.Text = "Pool guardada correctamente"
        '
        If C_Billetera.Text <> "" AndAlso C_Exchange.Text <> "" Then
            B_Actualizar.Enabled = True
        End If
    End Sub
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
    Private Sub B_Nuevo_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpiar(True)
        T_Fecha.Text = DateTime.Now.ToString("yyyyMMdd")
        T_Fecha.Focus()
    End Sub
    Private Sub B_Grabar_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
        Grabar()
    End Sub
    Private Sub L_PoolLiquidez_Click(sender As Object, e As EventArgs) Handles L_PoolLiquidez.Click
        If VariableDeInicio Then Exit Sub
        If L_PoolLiquidez.SelectedItem Is Nothing Then Exit Sub
        Ver(L_PoolLiquidez.SelectedItem.ToString())
    End Sub
    Private Sub L_PoolLiquidez_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_PoolLiquidez.SelectedIndexChanged
        '
    End Sub
    Private Sub CalFechaPool_ValueChanged(sender As Object, e As EventArgs) Handles CalFechaPool.ValueChanged
        If VariableDeInicio Then Exit Sub
        T_Fecha.Text = DateTime.Parse(CalFechaPool.Value).ToString("yyyyMMdd")
    End Sub
    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        If F < 1 Then
            L_Mensaje.Text = "Guarde el registro primero"
            Exit Sub
        End If
        If C_Billetera.Text = "" OrElse C_Exchange.Text = "" Then
            L_Mensaje.Text = "Seleccione billetera y exchange"
            Exit Sub
        End If
        '
        ' Obtener codigo de billetera desde la matriz
        Dim FilaBilletera As Integer = 0
        For i As Integer = 1 To Matriz_BilleterasTF
            If Matriz_Billeteras(i, 1) = C_Billetera.Text Then
                FilaBilletera = i
                Exit For
            End If
        Next i
        If FilaBilletera < 1 Then L_Mensaje.Text = "Billetera no encontrada" : Exit Sub
        '
        Dim idBilletera As String = Matriz_Billeteras(FilaBilletera, 0)
        Dim exchange As String = C_Exchange.Text.ToLower()
        '
        L_Mensaje.Text = "Consultando " & C_Exchange.Text & "... por favor espere"
        Me.Refresh()
        '
        Dim resultado As PoolDeFiResultado
        If exchange.Contains("uniswap") Then
            resultado = ConsultarPool_UniswapV3(idBilletera, Matriz_PoolLiquidez(F, 4))
        ElseIf exchange.Contains("beefy") Then
            resultado = ConsultarPool_Beefy(idBilletera)
        Else
            L_Mensaje.Text = "Exchange no soportado"
            Exit Sub
        End If
        '
        If resultado Is Nothing Then
            L_Mensaje.Text = "Sin datos de la API"
            Exit Sub
        End If
        '
        ' Guardar en la matriz
        Matriz_PoolLiquidez(F, 5) = resultado.Token1_Simbolo
        Matriz_PoolLiquidez(F, 6) = resultado.Token1_Cantidad.ToString("F8", Globalization.CultureInfo.InvariantCulture)
        Matriz_PoolLiquidez(F, 7) = resultado.Token1_USD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        Matriz_PoolLiquidez(F, 8) = resultado.Token2_Simbolo
        Matriz_PoolLiquidez(F, 9) = resultado.Token2_Cantidad.ToString("F8", Globalization.CultureInfo.InvariantCulture)
        Matriz_PoolLiquidez(F, 10) = resultado.Token2_USD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        Matriz_PoolLiquidez(F, 11) = resultado.Fees_USD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        Matriz_PoolLiquidez(F, 12) = resultado.Total_USD.ToString("F4", Globalization.CultureInfo.InvariantCulture)
        '
        Guardar_Matrices("PoolLiquidez")
        MostrarDatosPool(F)
        L_Mensaje.Text = $"Actualizado: {resultado.Token1_Simbolo}/{resultado.Token2_Simbolo} = USD {resultado.Total_USD:F2}"
    End Sub
    '
    '
    '
End Class



