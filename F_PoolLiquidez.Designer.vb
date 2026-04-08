<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_PoolLiquidez
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PoolLiquidez))
        Me.L_PoolLiquidez = New System.Windows.Forms.ListBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.T_Fecha = New System.Windows.Forms.TextBox()
        Me.C_Billetera = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.B_Grabar = New System.Windows.Forms.Button()
        Me.C_Exchange = New System.Windows.Forms.ComboBox()
        Me.CalFechaPool = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_Nuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Fila = New System.Windows.Forms.Label()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.Label_1 = New System.Windows.Forms.Label()
        Me.T_Link = New System.Windows.Forms.TextBox()
        Me.L_Pool = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.B_Actualizar = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'L_PoolLiquidez
        '
        Me.L_PoolLiquidez.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.L_PoolLiquidez.FormattingEnabled = True
        Me.L_PoolLiquidez.ItemHeight = 15
        Me.L_PoolLiquidez.Location = New System.Drawing.Point(12, 78)
        Me.L_PoolLiquidez.Name = "L_PoolLiquidez"
        Me.L_PoolLiquidez.Size = New System.Drawing.Size(316, 424)
        Me.L_PoolLiquidez.Sorted = True
        Me.L_PoolLiquidez.TabIndex = 560
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rT_Nota.Location = New System.Drawing.Point(356, 166)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(599, 56)
        Me.rT_Nota.TabIndex = 536
        Me.rT_Nota.Text = "rT_Nota"
        '
        'T_Fecha
        '
        Me.T_Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Fecha.Location = New System.Drawing.Point(356, 79)
        Me.T_Fecha.MaxLength = 6
        Me.T_Fecha.Name = "T_Fecha"
        Me.T_Fecha.Size = New System.Drawing.Size(111, 20)
        Me.T_Fecha.TabIndex = 529
        Me.T_Fecha.Text = "T_Fecha"
        '
        'C_Billetera
        '
        Me.C_Billetera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Billetera.FormattingEnabled = True
        Me.C_Billetera.Location = New System.Drawing.Point(473, 127)
        Me.C_Billetera.Name = "C_Billetera"
        Me.C_Billetera.Size = New System.Drawing.Size(123, 21)
        Me.C_Billetera.TabIndex = 555
        Me.C_Billetera.Text = "C_Billetera"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Blue
        Me.Label48.Location = New System.Drawing.Point(473, 111)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(126, 13)
        Me.Label48.TabIndex = 554
        Me.Label48.Text = "Billetera"
        '
        'B_Grabar
        '
        Me.B_Grabar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Grabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Grabar.Location = New System.Drawing.Point(356, 12)
        Me.B_Grabar.Name = "B_Grabar"
        Me.B_Grabar.Size = New System.Drawing.Size(99, 23)
        Me.B_Grabar.TabIndex = 546
        Me.B_Grabar.Text = "Grabar"
        Me.B_Grabar.UseVisualStyleBackColor = False
        '
        'C_Exchange
        '
        Me.C_Exchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Exchange.FormattingEnabled = True
        Me.C_Exchange.Location = New System.Drawing.Point(473, 79)
        Me.C_Exchange.Name = "C_Exchange"
        Me.C_Exchange.Size = New System.Drawing.Size(123, 21)
        Me.C_Exchange.TabIndex = 535
        Me.C_Exchange.Text = "C_Exchange"
        '
        'CalFechaPool
        '
        Me.CalFechaPool.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CalFechaPool.Location = New System.Drawing.Point(356, 107)
        Me.CalFechaPool.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.CalFechaPool.Name = "CalFechaPool"
        Me.CalFechaPool.Size = New System.Drawing.Size(111, 20)
        Me.CalFechaPool.TabIndex = 534
        Me.CalFechaPool.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.CalFechaPool.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(356, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 532
        Me.Label9.Text = "Fecha"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(473, 63)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 13)
        Me.Label28.TabIndex = 531
        Me.Label28.Text = "Exchange"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 561
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'B_Nuevo
        '
        Me.B_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.B_Nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Nuevo.Location = New System.Drawing.Point(229, 12)
        Me.B_Nuevo.Name = "B_Nuevo"
        Me.B_Nuevo.Size = New System.Drawing.Size(99, 23)
        Me.B_Nuevo.TabIndex = 575
        Me.B_Nuevo.Text = "Nuevo"
        Me.B_Nuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(474, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 652
        Me.Label1.Text = "Fila"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_Fila
        '
        Me.L_Fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila.ForeColor = System.Drawing.Color.Black
        Me.L_Fila.Location = New System.Drawing.Point(503, 17)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(52, 13)
        Me.L_Fila.TabIndex = 651
        Me.L_Fila.Text = "L_Fila"
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(356, 486)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(357, 16)
        Me.L_Mensaje.TabIndex = 653
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'Label_1
        '
        Me.Label_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_1.ForeColor = System.Drawing.Color.Blue
        Me.Label_1.Location = New System.Drawing.Point(12, 62)
        Me.Label_1.Name = "Label_1"
        Me.Label_1.Size = New System.Drawing.Size(180, 13)
        Me.Label_1.TabIndex = 654
        Me.Label_1.Text = "Pool Liquides"
        '
        'T_Link
        '
        Me.T_Link.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Link.Location = New System.Drawing.Point(608, 78)
        Me.T_Link.MaxLength = 60
        Me.T_Link.Multiline = True
        Me.T_Link.Name = "T_Link"
        Me.T_Link.Size = New System.Drawing.Size(347, 70)
        Me.T_Link.TabIndex = 670
        Me.T_Link.Text = "T_Link"
        '
        'L_Pool
        '
        Me.L_Pool.AutoSize = True
        Me.L_Pool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Pool.ForeColor = System.Drawing.Color.Magenta
        Me.L_Pool.Location = New System.Drawing.Point(608, 62)
        Me.L_Pool.Name = "L_Pool"
        Me.L_Pool.Size = New System.Drawing.Size(51, 13)
        Me.L_Pool.TabIndex = 669
        Me.L_Pool.Text = "Link Pool"
        Me.L_Pool.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(356, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 671
        Me.Label8.Text = "Notas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(359, 280)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(596, 186)
        Me.DGV.TabIndex = 672
        '
        'B_Actualizar
        '
        Me.B_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Actualizar.Location = New System.Drawing.Point(356, 251)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(99, 23)
        Me.B_Actualizar.TabIndex = 673
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = False
        '
        'F_PoolLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(968, 520)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.T_Link)
        Me.Controls.Add(Me.L_Pool)
        Me.Controls.Add(Me.Label_1)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.B_Nuevo)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_PoolLiquidez)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.T_Fecha)
        Me.Controls.Add(Me.C_Billetera)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.B_Grabar)
        Me.Controls.Add(Me.C_Exchange)
        Me.Controls.Add(Me.CalFechaPool)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label28)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PoolLiquidez"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_PoolLiquidez"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_PoolLiquidez As ListBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents T_Fecha As TextBox
    Friend WithEvents C_Billetera As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents B_Grabar As Button
    Friend WithEvents C_Exchange As ComboBox
    Friend WithEvents CalFechaPool As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_Nuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents L_Fila As Label
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents Label_1 As Label
    Friend WithEvents T_Link As TextBox
    Friend WithEvents L_Pool As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents B_Actualizar As Button
End Class
