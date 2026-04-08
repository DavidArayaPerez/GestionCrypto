'
'
'
Public Class F_Transacciones
    '
    '
    '
    Private _FilaSeleccionada As Integer = 0  ' fila en Matriz_TransaccionesOnChain de la tx seleccionada
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        LlenarList_Billetera(L_Billeteras)
        ConfigurarDGV()
        DGV.Rows.Clear()
        L_Mensaje.Text = ""
        L_TotalRegistros.Text = ""
        T_Comentario.Text = ""
        T_Comentario.Enabled = False
        B_Actualizar.Enabled = False
        B_Grabar.Enabled = False
        VariableDeInicio = False
    End Sub
    '
    Private Sub ConfigurarDGV()
        DGV.Columns.Clear()
        DGV.AllowUserToAddRows = False
        DGV.ReadOnly = True
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '
        DGV.Columns.Add("FechaHora", "Fecha/Hora")
        DGV.Columns.Add("Red", "Red")
        DGV.Columns.Add("Tipo", "Tipo")
        DGV.Columns.Add("Simbolo", "Token")
        DGV.Columns.Add("Valor", "Valor")
        DGV.Columns.Add("Desde", "Desde")
        DGV.Columns.Add("Hacia", "Hacia")
        DGV.Columns.Add("Resumen", "Resumen")
    End Sub
    '
    ' ------------------------------------------------------------
    '  Muestra transacciones on-chain filtradas por billetera
    ' ------------------------------------------------------------
    Private Sub VerTransacciones(ByVal idBilletera As String)
        DGV.Rows.Clear()
        Dim contador As Integer = 0
        '
        For i As Integer = 1 To Matriz_TransaccionesOnChainTF
            If idBilletera <> "" AndAlso Matriz_TransaccionesOnChain(i, 0) <> idBilletera Then Continue For
            '
            ' Resolver nombre corto de la red por chainHex
            Dim chainHex As String = Matriz_TransaccionesOnChain(i, 1)
            Dim nombreRed As String = chainHex
            For r As Integer = 1 To Matriz_RedesTF
                If Matriz_Redes(r, 19) = chainHex Then
                    nombreRed = Matriz_Redes(r, 3)
                    Exit For
                End If
            Next r
            '
            DGV.Rows.Add(
                Matriz_TransaccionesOnChain(i, 2),
                nombreRed,
                Matriz_TransaccionesOnChain(i, 4),
                Matriz_TransaccionesOnChain(i, 7),
                Matriz_TransaccionesOnChain(i, 8),
                Matriz_TransaccionesOnChain(i, 5),
                Matriz_TransaccionesOnChain(i, 6),
                Matriz_TransaccionesOnChain(i, 9))
            contador += 1
        Next i
        '
        DGV.Sort(DGV.Columns("FechaHora"), System.ComponentModel.ListSortDirection.Descending)
        L_TotalRegistros.Text = $"Registros: {contador}"
        L_Mensaje.Text = ""
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
        '
        B_Actualizar.Enabled = True
        Dim nombreBilletera As String = L_Billeteras.SelectedItem.ToString()
        Dim F As Integer = BuscarBilletera(nombreBilletera)
        If F < 1 Then Exit Sub
        '
        VerTransacciones(Matriz_Billeteras(F, 0))
    End Sub
    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        If L_Billeteras.SelectedIndex < 0 Then
            L_Mensaje.Text = "Seleccione una billetera primero"
            Exit Sub
        End If
        '
        Dim nombreBilletera As String = L_Billeteras.SelectedItem.ToString()
        Dim F As Integer = BuscarBilletera(nombreBilletera)
        If F < 1 Then Exit Sub
        '
        L_Mensaje.Text = "Consultando transacciones on-chain... por favor espere"
        Me.Refresh()
        '
        Dim resumen As String = ConsultarTransacciones_TodasLasRedes(Matriz_Billeteras(F, 0))
        L_Mensaje.Text = resumen
        '
        VerTransacciones(Matriz_Billeteras(F, 0))
    End Sub
    Private Sub DGV_SelectionChanged(sender As Object, e As EventArgs) Handles DGV.SelectionChanged
        If VariableDeInicio Then Exit Sub
        If DGV.SelectedRows.Count = 0 Then Exit Sub
        '
        ' Buscar la fila de la matriz por hash (col FechaHora+Resumen no son únicos, hash sí)
        ' El DGV no almacena el hash directamente — lo buscamos por FechaHora + Simbolo + Valor
        ' que en combinación son suficientemente únicos
        Dim fechaHora As String = DGV.SelectedRows(0).Cells("FechaHora").Value?.ToString()
        Dim simbolo As String = DGV.SelectedRows(0).Cells("Simbolo").Value?.ToString()
        Dim valor As String = DGV.SelectedRows(0).Cells("Valor").Value?.ToString()
        '
        _FilaSeleccionada = 0
        For i As Integer = 1 To Matriz_TransaccionesOnChainTF
            If Matriz_TransaccionesOnChain(i, 2) = fechaHora AndAlso
               Matriz_TransaccionesOnChain(i, 7) = simbolo AndAlso
               Matriz_TransaccionesOnChain(i, 8) = valor Then
                _FilaSeleccionada = i
                Exit For
            End If
        Next i
        '
        If _FilaSeleccionada > 0 Then
            T_Comentario.Text = Matriz_TransaccionesOnChain(_FilaSeleccionada, 10)
            T_Comentario.Enabled = True
            B_Grabar.Enabled = True
        End If
    End Sub
    Private Sub B_Grabar_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
        If _FilaSeleccionada < 1 Then Exit Sub
        '
        Matriz_TransaccionesOnChain(_FilaSeleccionada, 10) = T_Comentario.Text.Trim()
        Guardar_Matrices("TransaccionesOnChain")
        L_Mensaje.Text = "Comentario guardado"
    End Sub
    '
    '
    '
End Class