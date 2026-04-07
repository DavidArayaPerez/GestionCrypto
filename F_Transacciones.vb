'
'
'
Public Class F_Transacciones
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        LlenarList_Billetera(L_Billeteras)
        C_Tipo.Items.Clear()
        C_Tipo.Items.Add("Compras")
        C_Tipo.Items.Add("Traspasos")
        ConfigurarDGV_Compras()
        '
        ' Seleccionar primer tipo por defecto
        C_Tipo.SelectedIndex = 0
        VariableDeInicio = False
    End Sub
    ' ------------------------------------------------------------
    '  Configura el DGV para mostrar Compras
    ' ------------------------------------------------------------
    Private Sub ConfigurarDGV_Compras()
        DGV.Columns.Clear()
        DGV.AllowUserToAddRows = False
        DGV.ReadOnly = True
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '
        DGV.Columns.Add("Fecha", "Fecha")
        DGV.Columns.Add("Hora", "Hora")
        DGV.Columns.Add("Exchange", "Exchange")
        DGV.Columns.Add("MonedaOrigen", "Moneda Origen")
        DGV.Columns.Add("MontoOrigen", "Monto Origen")
        DGV.Columns.Add("MonedaDestino", "Moneda Destino")
        DGV.Columns.Add("Cantidad", "Cantidad")
        DGV.Columns.Add("Comision", "Comision")
        DGV.Columns.Add("Gas", "Gas")
        DGV.Columns.Add("Precio", "Precio USD")
    End Sub
    Private Sub ConfigurarDGV_Traspasos()
        DGV.Columns.Clear()
        DGV.AllowUserToAddRows = False
        DGV.ReadOnly = True
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '
        DGV.Columns.Add("Fecha", "Fecha")
        DGV.Columns.Add("Hora", "Hora")
        DGV.Columns.Add("Exchange", "Exchange")
        DGV.Columns.Add("BilleteraOrigen", "Billetera Origen")
        DGV.Columns.Add("MonedaOrigen", "Moneda Origen")
        DGV.Columns.Add("ValorOrigen", "Valor Origen")
        DGV.Columns.Add("BilleteraDestino", "Billetera Destino")
        DGV.Columns.Add("MonedaDestino", "Moneda Destino")
        DGV.Columns.Add("ValorDestino", "Valor Destino")
        DGV.Columns.Add("Comision", "Comision")
        DGV.Columns.Add("Gas", "Gas")
    End Sub
    ' ------------------------------------------------------------
    '  Muestra Compras filtradas por billetera (col 11)
    '  Si idBilletera = "" muestra todas
    ' ------------------------------------------------------------
    Private Sub MostrarCompras(ByVal idBilletera As String)
        DGV.Rows.Clear()
        Dim contador As Integer = 0
        '
        For i As Integer = 1 To Matriz_ComprasTF
            ' Filtrar por billetera si hay una seleccionada
            If idBilletera <> "" AndAlso Matriz_Compras(i, 11) <> idBilletera Then Continue For
            '
            DGV.Rows.Add(
                Matriz_Compras(i, 1),
                Matriz_Compras(i, 2),
                Matriz_Compras(i, 3),
                Matriz_Compras(i, 4),
                Matriz_Compras(i, 5),
                Matriz_Compras(i, 6),
                Matriz_Compras(i, 7),
                Matriz_Compras(i, 8),
                Matriz_Compras(i, 9),
                Matriz_Compras(i, 10))
            contador += 1
        Next i
        '
        ' Ordenar por Fecha desc, Hora desc
        DGV.Sort(DGV.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)
        L_TotalRegistros.Text = $"Registros: {contador}"
        L_Mensaje.Text = ""
    End Sub
    ' ------------------------------------------------------------
    '  Muestra Traspasos filtrados por billetera (origen O destino)
    '  Si idBilletera = "" muestra todos
    ' ------------------------------------------------------------
    Private Sub MostrarTraspasos(ByVal idBilletera As String)
        DGV.Rows.Clear()
        Dim contador As Integer = 0
        '
        For i As Integer = 1 To Matriz_TraspasosTF
            ' Filtrar: aparece si es billetera origen O destino
            If idBilletera <> "" Then
                Dim esOrigen As Boolean = (Matriz_Traspasos(i, 4) = idBilletera)
                Dim esDestino As Boolean = (Matriz_Traspasos(i, 7) = idBilletera)
                If Not esOrigen AndAlso Not esDestino Then Continue For
            End If
            '
            DGV.Rows.Add(
                Matriz_Traspasos(i, 1),
                Matriz_Traspasos(i, 2),
                Matriz_Traspasos(i, 3),
                Matriz_Traspasos(i, 4),
                Matriz_Traspasos(i, 5),
                Matriz_Traspasos(i, 6),
                Matriz_Traspasos(i, 7),
                Matriz_Traspasos(i, 8),
                Matriz_Traspasos(i, 9),
                Matriz_Traspasos(i, 10),
                Matriz_Traspasos(i, 11))
            contador += 1
        Next i
        '
        DGV.Sort(DGV.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)
        L_TotalRegistros.Text = $"Registros: {contador}"
        L_Mensaje.Text = ""
    End Sub
    ' ------------------------------------------------------------
    '  Despacha la visualizacion segun tipo seleccionado
    ' ------------------------------------------------------------
    Private Sub Mostrar()
        VariableDeInicio = True
        '
        If L_Billeteras.SelectedIndex < 0 Then
            ' Sin billetera seleccionada: mostrar todo
            If C_Tipo.SelectedItem Is Nothing Then Exit Sub
            If C_Tipo.SelectedItem.ToString() = "Compras" Then
                MostrarCompras("")
            Else
                MostrarTraspasos("")
            End If
        Else
            ' Con billetera seleccionada: filtrar por codigo
            Dim nombreBilletera As String = L_Billeteras.SelectedItem.ToString()
            Dim F As Integer = BuscarBilletera(nombreBilletera)
            If F < 1 Then Exit Sub
            Dim idBilletera As String = Matriz_Billeteras(F, 0)
            '
            If C_Tipo.SelectedItem Is Nothing Then Exit Sub
            If C_Tipo.SelectedItem.ToString() = "Compras" Then
                MostrarCompras(idBilletera)
            Else
                MostrarTraspasos(idBilletera)
            End If
        End If
        VariableDeInicio = False
    End Sub

    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    Private Sub F_Transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub L_Billeteras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Billeteras.SelectedIndexChanged
        If VariableDeInicio Then Exit Sub
        Mostrar()
    End Sub

    Private Sub C_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_Tipo.SelectedIndexChanged
        If VariableDeInicio Then Exit Sub
        '
        ' Reconfigurar columnas del DGV segun tipo
        If C_Tipo.SelectedItem Is Nothing Then Exit Sub
        If C_Tipo.SelectedItem.ToString() = "Compras" Then
            ConfigurarDGV_Compras()
        Else
            ConfigurarDGV_Traspasos()
        End If
        '
        Mostrar()
    End Sub


    '
    '
    '
End Class