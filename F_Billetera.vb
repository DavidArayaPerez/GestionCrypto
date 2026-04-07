'
'
'
Public Class F_Billetera
    '
    '
    '
    Private Sub Inicializar()
        VariableDeInicio = True
        Limpieza()
        LlenarList_Billetera(L_Billeteras)
        ConfigurarDGV()
        VariableDeInicio = False
    End Sub
    Private Sub Limpieza(Optional Habilitar As Boolean = False)
        L_Mensaje.Text = ""
        'BILLETERA
        T_NombreBilletera.Text = ""
        T_CodigoBilletera.Text = ""
        L_Fila.Text = ""
        rT_Nota.Text = ""
        C_FechaHora.Text = ""
        C_FechaHora.Items.Clear()
        DGV.Rows.Clear()
        '
        T_NombreBilletera.Enabled = Habilitar
        T_CodigoBilletera.Enabled = Habilitar
        rT_Nota.Enabled = Habilitar
        C_FechaHora.Enabled = Habilitar
        B_Grabar.Enabled = Habilitar
    End Sub
    Private Sub Ver(Nombre As String)
        Limpieza(True)
        Dim F As Integer = BuscarBilletera(Nombre)
        If F < 1 Then Exit Sub
        '
        L_Fila.Text = F
        T_CodigoBilletera.Text = Matriz_Billeteras(F, 0)
        T_NombreBilletera.Text = Matriz_Billeteras(F, 1)
        '
        CargarComboFechas(T_CodigoBilletera.Text) ' Cargar el combo de fechas (al seleccionar indice 0 se llena el DGV automaticamente)
        '
        Dim NombreNota As String = "Wall_" & T_NombreBilletera.Text & ".rtf"
        CargaRTF(RutaLocal, NombreNota, rT_Nota)
    End Sub
    Private Sub Grabar()
        Dim F As Integer = L_Fila.Text
        If F = 0 Then Exit Sub
        '
        Matriz_Billeteras(F, 0) = T_CodigoBilletera.Text
        Matriz_Billeteras(F, 1) = T_NombreBilletera.Text
        '
        Guardar_Matrices("Billeteras")
        '
        Dim NombreNota As String = "Wall_" & T_NombreBilletera.Text & ".rtf"
        GuardarRTF(RutaLocal, NombreNota, rT_Nota)
        '
        L_Mensaje.Text = "Moneda guardada correctamente"
        '   0   Codigo Billetera
        '   1   Nombre
    End Sub

    ' ------------------------------------------------------------
    '  Carga el ComboBox con las fechas/horas unicas de la billetera
    '  ordenadas de mas reciente a mas antigua
    ' ------------------------------------------------------------
    Private Sub CargarComboFechas(ByVal idBilletera As String)
        Dim fechas As New List(Of String)
        For i As Integer = 1 To Matriz_BilleteraSaldosTF
            If Matriz_BilleteraSaldos(i, 1) <> idBilletera Then Continue For
            Dim fecha As String = Matriz_BilleteraSaldos(i, 3)
            If Not fechas.Contains(fecha) Then
                fechas.Add(fecha)
            End If
        Next i
        '
        ' Ordenar descendente (mas reciente primero)
        fechas.Sort()
        fechas.Reverse()
        C_FechaHora.Items.Clear()
        For Each f As String In fechas
            C_FechaHora.Items.Add(f)
        Next
        '
        ' Seleccionar la mas reciente (indice 0) y mostrar su saldo
        If C_FechaHora.Items.Count > 0 Then C_FechaHora.SelectedIndex = 0
    End Sub
    Private Sub ConfigurarDGV()
        DGV.Columns.Clear()
        DGV.AllowUserToAddRows = False
        DGV.ReadOnly = True
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '
        DGV.Columns.Add("Simbolo", "Moneda")
        DGV.Columns.Add("Cantidad", "Cantidad")
        DGV.Columns.Add("Precio_USD", "Precio Moneda USD")
        DGV.Columns.Add("Valor_USD", "Valor Total USD")
        DGV.Columns.Add("Red", "Red")
    End Sub
    ' ------------------------------------------------------------
    '  Muestra en el DGV los saldos de la billetera para una fecha/hora dada
    ' ------------------------------------------------------------
    Private Sub MostrarSaldosBilletera(ByVal idBilletera As String, ByVal fechaHora As String)
        DGV.Rows.Clear()
        '
        For i As Integer = 1 To Matriz_BilleteraSaldosTF
            If Matriz_BilleteraSaldos(i, 1) <> idBilletera Then Continue For
            If Matriz_BilleteraSaldos(i, 3) <> fechaHora Then Continue For
            '
            ' Ocultar monedas sin precio
            Dim precioUSD As Double = 0
            Try
                precioUSD = Double.Parse(Matriz_BilleteraSaldos(i, 7),
                                         Globalization.CultureInfo.InvariantCulture)
            Catch
            End Try
            '
            '
            If precioUSD = 0 Then Continue For
            '
            ' Resolver nombre corto de la red
            Dim nombreRed As String = Matriz_BilleteraSaldos(i, 2)
            For r As Integer = 1 To Matriz_RedesTF
                If Matriz_Redes(r, 0) = Matriz_BilleteraSaldos(i, 2) Then
                    nombreRed = Matriz_Redes(r, 3)
                    Exit For
                End If
            Next r
            '
            DGV.Rows.Add(
                Matriz_BilleteraSaldos(i, 4),
                Matriz_BilleteraSaldos(i, 6),
                Matriz_BilleteraSaldos(i, 7),
                Matriz_BilleteraSaldos(i, 8),
                nombreRed)
        Next i
        '
        DGV.Sort(DGV.Columns("Simbolo"), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------
    'EVENTOS
    '---------------------------------------------------------------------------------------------------------------------
    '
    '
    Private Sub F_Billetera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub
    Private Sub B_Cerrar_Click(sender As Object, e As EventArgs) Handles B_Cerrar.Click
        Me.Close()
    End Sub
    Private Sub B_NuevoBilletera_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Limpieza()
        '
        Dim Codigo As String = InputBox("Ingrese el codigo de la billetera", "Nueva Billetera")
        If Codigo = "" Then Exit Sub
        '
        For i As Integer = 1 To Matriz_BilleterasTF
            If Matriz_Billeteras(i, 0) = Codigo Then
                MsgBox("El codigo de billetera ya existe. Por favor, ingrese un codigo diferente.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Next i
        '
        Dim Fila = AgrandarMatriz(Matriz_Billeteras, Matriz_BilleterasTF, Matriz_BilleterasTC)
        Matriz_Billeteras(Fila, 0) = Codigo
        Matriz_Billeteras(Fila, 1) = ""
        Guardar_Matrices("Billeteras")
        Inicializar()
    End Sub
    Private Sub L_Billeteras_Click(sender As Object, e As EventArgs) Handles L_Billeteras.Click
        If VariableDeInicio Then Exit Sub
        Ver(L_Billeteras.Text)
    End Sub
    Private Sub L_Billeteras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Billeteras.SelectedIndexChanged

    End Sub
    Private Sub B_GrabarBilletera_Click(sender As Object, e As EventArgs) Handles B_Grabar.Click
        Grabar()
    End Sub
    Private Sub B_Copiar_Click(sender As Object, e As EventArgs) Handles B_Copiar.Click
        CopiarAlPortapapeles(T_CodigoBilletera)
    End Sub
    Private Sub C_FechaHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_FechaHora.SelectedIndexChanged
        If VariableDeInicio Then Exit Sub
        If T_CodigoBilletera.Text = "" Then Exit Sub
        If C_FechaHora.SelectedItem Is Nothing Then Exit Sub
        '
        MostrarSaldosBilletera(T_CodigoBilletera.Text, C_FechaHora.SelectedItem.ToString())
    End Sub
    Private Sub B_ConsultaSaldo_Click(sender As Object, e As EventArgs) Handles B_ConsultaSaldo.Click
        If T_CodigoBilletera.Text = "" Then
            L_Mensaje.Text = "Seleccione una billetera primero"
            Exit Sub
        End If
        '
        L_Mensaje.Text = "Consultando todas las redes EVM... por favor espere"
        Me.Refresh()
        '
        Dim resumen As String = ConsultarBilletera_TodasLasRedes(T_CodigoBilletera.Text)
        '
        ' Recargar el combo y seleccionar automaticamente la fecha mas reciente
        CargarComboFechas(T_CodigoBilletera.Text)
        '
        L_Mensaje.Text = resumen
    End Sub
    '
    '
    '
End Class
