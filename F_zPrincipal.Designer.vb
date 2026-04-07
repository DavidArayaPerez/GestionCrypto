<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_zPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Menu_Agregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ServicioMas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_DocumentoMas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_VerFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_VerTodosLosExpedientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_VerTodasLasOrdenesDeCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_VerTodosLosDocumentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_VerVariables = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Procesamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_CargarValoresTributario = New System.Windows.Forms.ToolStripMenuItem()
        Me.g5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_ReCargarTodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReCargarCuotas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReCargarExpediente = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReCargarOrdenCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReCargarDocumentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ProcesarCarpetasArchivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.g6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_ResumenPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Resumen_EnCurso = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.g4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ValidarAcceso = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoLectura = New System.Windows.Forms.ToolStripMenuItem()
        Me.SL00 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL01 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL02 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL03 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL04 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL05 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL06 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL07 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL08 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL09 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SL10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_Monedas = New System.Windows.Forms.Button()
        Me.B_Redes = New System.Windows.Forms.Button()
        Me.B_Dolar = New System.Windows.Forms.Button()
        Me.B_Compras = New System.Windows.Forms.Button()
        Me.B_Billetera = New System.Windows.Forms.Button()
        Me.B_PoolLiquidez = New System.Windows.Forms.Button()
        Me.B_Traspasos = New System.Windows.Forms.Button()
        Me.B_Exchange = New System.Windows.Forms.Button()
        Me.B_Transacciones = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Menu_Agregar
        '
        Me.Menu_Agregar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ServicioMas, Me.Menu_DocumentoMas})
        Me.Menu_Agregar.Name = "Menu_Agregar"
        Me.Menu_Agregar.Size = New System.Drawing.Size(61, 20)
        Me.Menu_Agregar.Text = "Agregar"
        '
        'Menu_ServicioMas
        '
        Me.Menu_ServicioMas.Name = "Menu_ServicioMas"
        Me.Menu_ServicioMas.Size = New System.Drawing.Size(148, 22)
        Me.Menu_ServicioMas.Text = "Solicitud +"
        '
        'Menu_DocumentoMas
        '
        Me.Menu_DocumentoMas.Name = "Menu_DocumentoMas"
        Me.Menu_DocumentoMas.Size = New System.Drawing.Size(148, 22)
        Me.Menu_DocumentoMas.Text = "Documento +"
        '
        'Menu_VerFormularios
        '
        Me.Menu_VerFormularios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_VerTodosLosExpedientes, Me.Menu_VerTodasLasOrdenesDeCompra, Me.Menu_VerTodosLosDocumentos, Me.Menu_VerVariables})
        Me.Menu_VerFormularios.Name = "Menu_VerFormularios"
        Me.Menu_VerFormularios.Size = New System.Drawing.Size(101, 20)
        Me.Menu_VerFormularios.Text = "Ver Formularios"
        '
        'Menu_VerTodosLosExpedientes
        '
        Me.Menu_VerTodosLosExpedientes.Name = "Menu_VerTodosLosExpedientes"
        Me.Menu_VerTodosLosExpedientes.Size = New System.Drawing.Size(248, 22)
        Me.Menu_VerTodosLosExpedientes.Text = "Ver todos los Expedientes"
        '
        'Menu_VerTodasLasOrdenesDeCompra
        '
        Me.Menu_VerTodasLasOrdenesDeCompra.Name = "Menu_VerTodasLasOrdenesDeCompra"
        Me.Menu_VerTodasLasOrdenesDeCompra.Size = New System.Drawing.Size(248, 22)
        Me.Menu_VerTodasLasOrdenesDeCompra.Text = "Ver todas las Ordenes de Compra"
        '
        'Menu_VerTodosLosDocumentos
        '
        Me.Menu_VerTodosLosDocumentos.Name = "Menu_VerTodosLosDocumentos"
        Me.Menu_VerTodosLosDocumentos.Size = New System.Drawing.Size(248, 22)
        Me.Menu_VerTodosLosDocumentos.Text = "Ver todos los Documentos"
        '
        'Menu_VerVariables
        '
        Me.Menu_VerVariables.Name = "Menu_VerVariables"
        Me.Menu_VerVariables.Size = New System.Drawing.Size(248, 22)
        Me.Menu_VerVariables.Text = "Ver Variables"
        '
        'Menu_Procesamiento
        '
        Me.Menu_Procesamiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_CargarValoresTributario, Me.g5, Me.Menu_ReCargarTodo, Me.Menu_ReCargarCuotas, Me.Menu_ReCargarExpediente, Me.Menu_ReCargarOrdenCompra, Me.Menu_ReCargarDocumentos, Me.Menu_ProcesarCarpetasArchivos, Me.g6, Me.Menu_ResumenPagos, Me.Menu_Resumen_EnCurso})
        Me.Menu_Procesamiento.Name = "Menu_Procesamiento"
        Me.Menu_Procesamiento.Size = New System.Drawing.Size(98, 20)
        Me.Menu_Procesamiento.Text = "Procesamiento"
        '
        'Menu_CargarValoresTributario
        '
        Me.Menu_CargarValoresTributario.Name = "Menu_CargarValoresTributario"
        Me.Menu_CargarValoresTributario.Size = New System.Drawing.Size(214, 22)
        Me.Menu_CargarValoresTributario.Text = "Ver Valores UF/UTM/Dolar"
        '
        'g5
        '
        Me.g5.Name = "g5"
        Me.g5.Size = New System.Drawing.Size(211, 6)
        '
        'Menu_ReCargarTodo
        '
        Me.Menu_ReCargarTodo.Name = "Menu_ReCargarTodo"
        Me.Menu_ReCargarTodo.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ReCargarTodo.Text = "ReCargar Todo"
        '
        'Menu_ReCargarCuotas
        '
        Me.Menu_ReCargarCuotas.Name = "Menu_ReCargarCuotas"
        Me.Menu_ReCargarCuotas.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ReCargarCuotas.Text = "ReCargar Cuotas"
        '
        'Menu_ReCargarExpediente
        '
        Me.Menu_ReCargarExpediente.Name = "Menu_ReCargarExpediente"
        Me.Menu_ReCargarExpediente.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ReCargarExpediente.Text = "ReCargar Expedientes"
        '
        'Menu_ReCargarOrdenCompra
        '
        Me.Menu_ReCargarOrdenCompra.Name = "Menu_ReCargarOrdenCompra"
        Me.Menu_ReCargarOrdenCompra.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ReCargarOrdenCompra.Text = "ReCargar OrdenCompra"
        '
        'Menu_ReCargarDocumentos
        '
        Me.Menu_ReCargarDocumentos.Name = "Menu_ReCargarDocumentos"
        Me.Menu_ReCargarDocumentos.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ReCargarDocumentos.Text = "ReCargar Documentos"
        '
        'Menu_ProcesarCarpetasArchivos
        '
        Me.Menu_ProcesarCarpetasArchivos.Name = "Menu_ProcesarCarpetasArchivos"
        Me.Menu_ProcesarCarpetasArchivos.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ProcesarCarpetasArchivos.Text = "ReCargar Lista de Archivos"
        '
        'g6
        '
        Me.g6.Name = "g6"
        Me.g6.Size = New System.Drawing.Size(211, 6)
        '
        'Menu_ResumenPagos
        '
        Me.Menu_ResumenPagos.Name = "Menu_ResumenPagos"
        Me.Menu_ResumenPagos.Size = New System.Drawing.Size(214, 22)
        Me.Menu_ResumenPagos.Text = "Resumen Pagos"
        '
        'Menu_Resumen_EnCurso
        '
        Me.Menu_Resumen_EnCurso.Name = "Menu_Resumen_EnCurso"
        Me.Menu_Resumen_EnCurso.Size = New System.Drawing.Size(214, 22)
        Me.Menu_Resumen_EnCurso.Text = "Resumen En Curso"
        '
        'Menu_AcercaDe
        '
        Me.Menu_AcercaDe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAcercaDe, Me.g4, Me.ValidarAcceso, Me.ModoLectura})
        Me.Menu_AcercaDe.Name = "Menu_AcercaDe"
        Me.Menu_AcercaDe.Size = New System.Drawing.Size(80, 20)
        Me.Menu_AcercaDe.Text = "Acerca de .."
        '
        'VerAcercaDe
        '
        Me.VerAcercaDe.Name = "VerAcercaDe"
        Me.VerAcercaDe.Size = New System.Drawing.Size(154, 22)
        Me.VerAcercaDe.Text = "Ver Acerca de..."
        '
        'g4
        '
        Me.g4.Name = "g4"
        Me.g4.Size = New System.Drawing.Size(151, 6)
        '
        'ValidarAcceso
        '
        Me.ValidarAcceso.Name = "ValidarAcceso"
        Me.ValidarAcceso.Size = New System.Drawing.Size(154, 22)
        Me.ValidarAcceso.Text = "Validar acceso"
        '
        'ModoLectura
        '
        Me.ModoLectura.Name = "ModoLectura"
        Me.ModoLectura.Size = New System.Drawing.Size(154, 22)
        Me.ModoLectura.Text = "Modo Lectura"
        '
        'SL00
        '
        Me.SL00.Name = "SL00"
        Me.SL00.Size = New System.Drawing.Size(31, 17)
        Me.SL00.Text = "SL00"
        '
        'SL01
        '
        Me.SL01.Name = "SL01"
        Me.SL01.Size = New System.Drawing.Size(31, 17)
        Me.SL01.Text = "SL01"
        '
        'SL02
        '
        Me.SL02.Name = "SL02"
        Me.SL02.Size = New System.Drawing.Size(31, 17)
        Me.SL02.Text = "SL02"
        '
        'SL03
        '
        Me.SL03.Name = "SL03"
        Me.SL03.Size = New System.Drawing.Size(31, 17)
        Me.SL03.Text = "SL03"
        '
        'SL04
        '
        Me.SL04.Name = "SL04"
        Me.SL04.Size = New System.Drawing.Size(31, 17)
        Me.SL04.Text = "SL04"
        Me.SL04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SL05
        '
        Me.SL05.Name = "SL05"
        Me.SL05.Size = New System.Drawing.Size(916, 17)
        Me.SL05.Spring = True
        Me.SL05.Text = "SL05"
        '
        'SL06
        '
        Me.SL06.Name = "SL06"
        Me.SL06.Size = New System.Drawing.Size(31, 17)
        Me.SL06.Text = "SL06"
        Me.SL06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SL07
        '
        Me.SL07.Name = "SL07"
        Me.SL07.Size = New System.Drawing.Size(31, 17)
        Me.SL07.Text = "SL07"
        Me.SL07.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SL08
        '
        Me.SL08.Name = "SL08"
        Me.SL08.Size = New System.Drawing.Size(31, 17)
        Me.SL08.Text = "SL08"
        Me.SL08.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SL09
        '
        Me.SL09.Name = "SL09"
        Me.SL09.Size = New System.Drawing.Size(31, 17)
        Me.SL09.Text = "SL09"
        '
        'SL10
        '
        Me.SL10.Name = "SL10"
        Me.SL10.Size = New System.Drawing.Size(31, 17)
        Me.SL10.Text = "SL10"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 366)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 416
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'B_Monedas
        '
        Me.B_Monedas.BackColor = System.Drawing.SystemColors.Control
        Me.B_Monedas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Monedas.Location = New System.Drawing.Point(12, 12)
        Me.B_Monedas.Name = "B_Monedas"
        Me.B_Monedas.Size = New System.Drawing.Size(99, 23)
        Me.B_Monedas.TabIndex = 425
        Me.B_Monedas.Text = "Monedas"
        Me.B_Monedas.UseVisualStyleBackColor = False
        '
        'B_Redes
        '
        Me.B_Redes.BackColor = System.Drawing.SystemColors.Control
        Me.B_Redes.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Redes.Location = New System.Drawing.Point(12, 41)
        Me.B_Redes.Name = "B_Redes"
        Me.B_Redes.Size = New System.Drawing.Size(99, 23)
        Me.B_Redes.TabIndex = 426
        Me.B_Redes.Text = "Redes"
        Me.B_Redes.UseVisualStyleBackColor = False
        '
        'B_Dolar
        '
        Me.B_Dolar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Dolar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Dolar.Location = New System.Drawing.Point(12, 70)
        Me.B_Dolar.Name = "B_Dolar"
        Me.B_Dolar.Size = New System.Drawing.Size(99, 23)
        Me.B_Dolar.TabIndex = 427
        Me.B_Dolar.Text = "Dolar"
        Me.B_Dolar.UseVisualStyleBackColor = False
        '
        'B_Compras
        '
        Me.B_Compras.BackColor = System.Drawing.SystemColors.Control
        Me.B_Compras.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Compras.Location = New System.Drawing.Point(12, 270)
        Me.B_Compras.Name = "B_Compras"
        Me.B_Compras.Size = New System.Drawing.Size(99, 23)
        Me.B_Compras.TabIndex = 429
        Me.B_Compras.Text = "Compras"
        Me.B_Compras.UseVisualStyleBackColor = False
        '
        'B_Billetera
        '
        Me.B_Billetera.BackColor = System.Drawing.SystemColors.Control
        Me.B_Billetera.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Billetera.Location = New System.Drawing.Point(12, 161)
        Me.B_Billetera.Name = "B_Billetera"
        Me.B_Billetera.Size = New System.Drawing.Size(99, 23)
        Me.B_Billetera.TabIndex = 428
        Me.B_Billetera.Text = "Billeteras"
        Me.B_Billetera.UseVisualStyleBackColor = False
        '
        'B_PoolLiquidez
        '
        Me.B_PoolLiquidez.BackColor = System.Drawing.SystemColors.Control
        Me.B_PoolLiquidez.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_PoolLiquidez.Location = New System.Drawing.Point(12, 299)
        Me.B_PoolLiquidez.Name = "B_PoolLiquidez"
        Me.B_PoolLiquidez.Size = New System.Drawing.Size(99, 23)
        Me.B_PoolLiquidez.TabIndex = 432
        Me.B_PoolLiquidez.Text = "Pool Liquidez"
        Me.B_PoolLiquidez.UseVisualStyleBackColor = False
        '
        'B_Traspasos
        '
        Me.B_Traspasos.BackColor = System.Drawing.SystemColors.Control
        Me.B_Traspasos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Traspasos.Location = New System.Drawing.Point(12, 328)
        Me.B_Traspasos.Name = "B_Traspasos"
        Me.B_Traspasos.Size = New System.Drawing.Size(99, 23)
        Me.B_Traspasos.TabIndex = 433
        Me.B_Traspasos.Text = "Traspasos"
        Me.B_Traspasos.UseVisualStyleBackColor = False
        '
        'B_Exchange
        '
        Me.B_Exchange.BackColor = System.Drawing.SystemColors.Control
        Me.B_Exchange.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Exchange.Location = New System.Drawing.Point(12, 98)
        Me.B_Exchange.Name = "B_Exchange"
        Me.B_Exchange.Size = New System.Drawing.Size(99, 23)
        Me.B_Exchange.TabIndex = 434
        Me.B_Exchange.Text = "Exchange"
        Me.B_Exchange.UseVisualStyleBackColor = False
        '
        'B_Transacciones
        '
        Me.B_Transacciones.BackColor = System.Drawing.SystemColors.Control
        Me.B_Transacciones.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Transacciones.Location = New System.Drawing.Point(12, 190)
        Me.B_Transacciones.Name = "B_Transacciones"
        Me.B_Transacciones.Size = New System.Drawing.Size(99, 23)
        Me.B_Transacciones.TabIndex = 435
        Me.B_Transacciones.Text = "Transacciones"
        Me.B_Transacciones.UseVisualStyleBackColor = False
        '
        'F_zPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(137, 413)
        Me.Controls.Add(Me.B_Transacciones)
        Me.Controls.Add(Me.B_Exchange)
        Me.Controls.Add(Me.B_Traspasos)
        Me.Controls.Add(Me.B_PoolLiquidez)
        Me.Controls.Add(Me.B_Compras)
        Me.Controls.Add(Me.B_Billetera)
        Me.Controls.Add(Me.B_Dolar)
        Me.Controls.Add(Me.B_Redes)
        Me.Controls.Add(Me.B_Monedas)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Location = New System.Drawing.Point(50, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_zPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GC"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Menu_Agregar As ToolStripMenuItem
    Friend WithEvents SL00 As ToolStripStatusLabel
    Friend WithEvents SL01 As ToolStripStatusLabel
    Friend WithEvents SL02 As ToolStripStatusLabel
    Friend WithEvents SL03 As ToolStripStatusLabel
    Friend WithEvents SL04 As ToolStripStatusLabel
    Friend WithEvents SL05 As ToolStripStatusLabel
    Friend WithEvents SL06 As ToolStripStatusLabel
    Friend WithEvents SL07 As ToolStripStatusLabel
    Friend WithEvents SL08 As ToolStripStatusLabel
    Friend WithEvents Menu_DocumentoMas As ToolStripMenuItem
    Friend WithEvents Menu_ServicioMas As ToolStripMenuItem
    Friend WithEvents Menu_Procesamiento As ToolStripMenuItem
    Friend WithEvents Menu_ProcesarCarpetasArchivos As ToolStripMenuItem
    Friend WithEvents Menu_CargarValoresTributario As ToolStripMenuItem
    Friend WithEvents g6 As ToolStripSeparator
    Friend WithEvents Menu_ReCargarTodo As ToolStripMenuItem
    Friend WithEvents Menu_AcercaDe As ToolStripMenuItem
    Friend WithEvents VerAcercaDe As ToolStripMenuItem
    Friend WithEvents SL09 As ToolStripStatusLabel
    Friend WithEvents SL10 As ToolStripStatusLabel
    Friend WithEvents ValidarAcceso As ToolStripMenuItem
    Friend WithEvents ModoLectura As ToolStripMenuItem
    Friend WithEvents g4 As ToolStripSeparator
    Friend WithEvents g5 As ToolStripSeparator
    Friend WithEvents Menu_ReCargarCuotas As ToolStripMenuItem
    Friend WithEvents Menu_ReCargarExpediente As ToolStripMenuItem
    Friend WithEvents Menu_ReCargarOrdenCompra As ToolStripMenuItem
    Friend WithEvents Menu_ReCargarDocumentos As ToolStripMenuItem
    Friend WithEvents Menu_VerFormularios As ToolStripMenuItem
    Friend WithEvents Menu_VerTodosLosExpedientes As ToolStripMenuItem
    Friend WithEvents Menu_VerTodasLasOrdenesDeCompra As ToolStripMenuItem
    Friend WithEvents Menu_VerTodosLosDocumentos As ToolStripMenuItem
    Friend WithEvents Menu_VerVariables As ToolStripMenuItem
    Friend WithEvents Menu_Resumen_EnCurso As ToolStripMenuItem
    Friend WithEvents Menu_ResumenPagos As ToolStripMenuItem
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_Monedas As Button
    Friend WithEvents B_Redes As Button
    Friend WithEvents B_Dolar As Button
    Friend WithEvents B_Compras As Button
    Friend WithEvents B_Billetera As Button
    Friend WithEvents B_PoolLiquidez As Button
    Friend WithEvents B_Traspasos As Button
    Friend WithEvents B_Exchange As Button
    Friend WithEvents B_Transacciones As Button
End Class
