<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Compras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.L_Compras = New System.Windows.Forms.ListBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.L_PrecioMonedaCompra = New System.Windows.Forms.Label()
        Me.T_GasCompra = New System.Windows.Forms.TextBox()
        Me.T_ComisionCompra = New System.Windows.Forms.TextBox()
        Me.T_ValorDestinoCompra = New System.Windows.Forms.TextBox()
        Me.T_ValorOrigenCompra = New System.Windows.Forms.TextBox()
        Me.rT_NotaCompra = New System.Windows.Forms.RichTextBox()
        Me.T_HoraCompra = New System.Windows.Forms.TextBox()
        Me.T_FechaCompra = New System.Windows.Forms.TextBox()
        Me.Label07 = New System.Windows.Forms.Label()
        Me.B_GrabarCompra = New System.Windows.Forms.Button()
        Me.Label05 = New System.Windows.Forms.Label()
        Me.Label08 = New System.Windows.Forms.Label()
        Me.C_MonedaDestino = New System.Windows.Forms.ComboBox()
        Me.Label09 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.C_Exchange = New System.Windows.Forms.ComboBox()
        Me.Cal_FechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Compras
        '
        Me.L_Compras.FormattingEnabled = True
        Me.L_Compras.Location = New System.Drawing.Point(12, 69)
        Me.L_Compras.Name = "L_Compras"
        Me.L_Compras.Size = New System.Drawing.Size(316, 433)
        Me.L_Compras.TabIndex = 501
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Blue
        Me.Label45.Location = New System.Drawing.Point(358, 355)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 13)
        Me.Label45.TabIndex = 500
        Me.Label45.Text = "Precio Moneda"
        '
        'L_PrecioMonedaCompra
        '
        Me.L_PrecioMonedaCompra.BackColor = System.Drawing.Color.LightGray
        Me.L_PrecioMonedaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_PrecioMonedaCompra.Location = New System.Drawing.Point(358, 372)
        Me.L_PrecioMonedaCompra.Name = "L_PrecioMonedaCompra"
        Me.L_PrecioMonedaCompra.Size = New System.Drawing.Size(126, 20)
        Me.L_PrecioMonedaCompra.TabIndex = 499
        Me.L_PrecioMonedaCompra.Text = "L_PrecioMonedaCompra"
        '
        'T_GasCompra
        '
        Me.T_GasCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_GasCompra.Location = New System.Drawing.Point(525, 311)
        Me.T_GasCompra.MaxLength = 6
        Me.T_GasCompra.Name = "T_GasCompra"
        Me.T_GasCompra.Size = New System.Drawing.Size(123, 20)
        Me.T_GasCompra.TabIndex = 498
        Me.T_GasCompra.Text = "T_GasCompra"
        '
        'T_ComisionCompra
        '
        Me.T_ComisionCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ComisionCompra.Location = New System.Drawing.Point(358, 311)
        Me.T_ComisionCompra.MaxLength = 6
        Me.T_ComisionCompra.Name = "T_ComisionCompra"
        Me.T_ComisionCompra.Size = New System.Drawing.Size(123, 20)
        Me.T_ComisionCompra.TabIndex = 496
        Me.T_ComisionCompra.Text = "T_ComisionCompra"
        '
        'T_ValorDestinoCompra
        '
        Me.T_ValorDestinoCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorDestinoCompra.Location = New System.Drawing.Point(525, 249)
        Me.T_ValorDestinoCompra.MaxLength = 6
        Me.T_ValorDestinoCompra.Name = "T_ValorDestinoCompra"
        Me.T_ValorDestinoCompra.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorDestinoCompra.TabIndex = 493
        Me.T_ValorDestinoCompra.Text = "T_ValorDestinoCompra"
        '
        'T_ValorOrigenCompra
        '
        Me.T_ValorOrigenCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorOrigenCompra.Location = New System.Drawing.Point(525, 188)
        Me.T_ValorOrigenCompra.MaxLength = 6
        Me.T_ValorOrigenCompra.Name = "T_ValorOrigenCompra"
        Me.T_ValorOrigenCompra.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorOrigenCompra.TabIndex = 489
        Me.T_ValorOrigenCompra.Text = "T_ValorOrigenCompra"
        '
        'rT_NotaCompra
        '
        Me.rT_NotaCompra.AcceptsTab = True
        Me.rT_NotaCompra.AutoWordSelection = True
        Me.rT_NotaCompra.BackColor = System.Drawing.Color.White
        Me.rT_NotaCompra.Location = New System.Drawing.Point(672, 69)
        Me.rT_NotaCompra.Name = "rT_NotaCompra"
        Me.rT_NotaCompra.ReadOnly = True
        Me.rT_NotaCompra.Size = New System.Drawing.Size(303, 433)
        Me.rT_NotaCompra.TabIndex = 485
        Me.rT_NotaCompra.Text = "rT_NotaCompra"
        '
        'T_HoraCompra
        '
        Me.T_HoraCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_HoraCompra.Location = New System.Drawing.Point(450, 91)
        Me.T_HoraCompra.MaxLength = 4
        Me.T_HoraCompra.Name = "T_HoraCompra"
        Me.T_HoraCompra.Size = New System.Drawing.Size(56, 20)
        Me.T_HoraCompra.TabIndex = 479
        Me.T_HoraCompra.Text = "T_HoraCompra"
        Me.T_HoraCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaCompra
        '
        Me.T_FechaCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaCompra.Location = New System.Drawing.Point(358, 91)
        Me.T_FechaCompra.MaxLength = 6
        Me.T_FechaCompra.Name = "T_FechaCompra"
        Me.T_FechaCompra.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaCompra.TabIndex = 478
        Me.T_FechaCompra.Text = "T_FechaCompra"
        '
        'Label07
        '
        Me.Label07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label07.ForeColor = System.Drawing.Color.Blue
        Me.Label07.Location = New System.Drawing.Point(525, 295)
        Me.Label07.Name = "Label07"
        Me.Label07.Size = New System.Drawing.Size(123, 13)
        Me.Label07.TabIndex = 497
        Me.Label07.Text = "Gas"
        '
        'B_GrabarCompra
        '
        Me.B_GrabarCompra.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarCompra.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarCompra.Location = New System.Drawing.Point(358, 12)
        Me.B_GrabarCompra.Name = "B_GrabarCompra"
        Me.B_GrabarCompra.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarCompra.TabIndex = 495
        Me.B_GrabarCompra.Text = "Grabar"
        Me.B_GrabarCompra.UseVisualStyleBackColor = False
        '
        'Label05
        '
        Me.Label05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label05.ForeColor = System.Drawing.Color.Blue
        Me.Label05.Location = New System.Drawing.Point(358, 294)
        Me.Label05.Name = "Label05"
        Me.Label05.Size = New System.Drawing.Size(123, 13)
        Me.Label05.TabIndex = 494
        Me.Label05.Text = "Comisión"
        '
        'Label08
        '
        Me.Label08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label08.ForeColor = System.Drawing.Color.Blue
        Me.Label08.Location = New System.Drawing.Point(525, 233)
        Me.Label08.Name = "Label08"
        Me.Label08.Size = New System.Drawing.Size(123, 13)
        Me.Label08.TabIndex = 492
        Me.Label08.Text = "Valor Moneda Destino"
        '
        'C_MonedaDestino
        '
        Me.C_MonedaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestino.FormattingEnabled = True
        Me.C_MonedaDestino.Location = New System.Drawing.Point(358, 248)
        Me.C_MonedaDestino.Name = "C_MonedaDestino"
        Me.C_MonedaDestino.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestino.TabIndex = 491
        Me.C_MonedaDestino.Text = "C_MonedaDestino"
        '
        'Label09
        '
        Me.Label09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label09.ForeColor = System.Drawing.Color.Blue
        Me.Label09.Location = New System.Drawing.Point(358, 232)
        Me.Label09.Name = "Label09"
        Me.Label09.Size = New System.Drawing.Size(126, 13)
        Me.Label09.TabIndex = 490
        Me.Label09.Text = "Moneda Destino"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(525, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 488
        Me.Label10.Text = "Valor Moneda Origen"
        '
        'C_MonedaOrigen
        '
        Me.C_MonedaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigen.FormattingEnabled = True
        Me.C_MonedaOrigen.Location = New System.Drawing.Point(358, 187)
        Me.C_MonedaOrigen.Name = "C_MonedaOrigen"
        Me.C_MonedaOrigen.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigen.TabIndex = 487
        Me.C_MonedaOrigen.Text = "C_MonedaOrigen"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(358, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 486
        Me.Label11.Text = "Moneda Origen"
        '
        'C_Exchange
        '
        Me.C_Exchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Exchange.FormattingEnabled = True
        Me.C_Exchange.Location = New System.Drawing.Point(525, 91)
        Me.C_Exchange.Name = "C_Exchange"
        Me.C_Exchange.Size = New System.Drawing.Size(123, 21)
        Me.C_Exchange.TabIndex = 484
        Me.C_Exchange.Text = "C_ExchangeCompra"
        '
        'Cal_FechaCompra
        '
        Me.Cal_FechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cal_FechaCompra.Location = New System.Drawing.Point(358, 120)
        Me.Cal_FechaCompra.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Cal_FechaCompra.Name = "Cal_FechaCompra"
        Me.Cal_FechaCompra.Size = New System.Drawing.Size(148, 20)
        Me.Cal_FechaCompra.TabIndex = 483
        Me.Cal_FechaCompra.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.Cal_FechaCompra.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(447, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 482
        Me.Label12.Text = "Hora"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(358, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 481
        Me.Label13.Text = "Fecha"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(525, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 480
        Me.Label14.Text = "Plataforma"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 502
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'B_NuevoBilletera
        '
        Me.B_NuevoBilletera.BackColor = System.Drawing.SystemColors.Control
        Me.B_NuevoBilletera.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_NuevoBilletera.Location = New System.Drawing.Point(229, 12)
        Me.B_NuevoBilletera.Name = "B_NuevoBilletera"
        Me.B_NuevoBilletera.Size = New System.Drawing.Size(99, 23)
        Me.B_NuevoBilletera.TabIndex = 575
        Me.B_NuevoBilletera.Text = "Nuevo"
        Me.B_NuevoBilletera.UseVisualStyleBackColor = False
        '
        'F_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 521)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Compras)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.L_PrecioMonedaCompra)
        Me.Controls.Add(Me.T_GasCompra)
        Me.Controls.Add(Me.T_ComisionCompra)
        Me.Controls.Add(Me.T_ValorDestinoCompra)
        Me.Controls.Add(Me.T_ValorOrigenCompra)
        Me.Controls.Add(Me.rT_NotaCompra)
        Me.Controls.Add(Me.T_HoraCompra)
        Me.Controls.Add(Me.T_FechaCompra)
        Me.Controls.Add(Me.Label07)
        Me.Controls.Add(Me.B_GrabarCompra)
        Me.Controls.Add(Me.Label05)
        Me.Controls.Add(Me.Label08)
        Me.Controls.Add(Me.C_MonedaDestino)
        Me.Controls.Add(Me.Label09)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.C_MonedaOrigen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.C_Exchange)
        Me.Controls.Add(Me.Cal_FechaCompra)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "F_Compras"
        Me.Text = "Compras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Compras As ListBox
    Friend WithEvents Label45 As Label
    Friend WithEvents L_PrecioMonedaCompra As Label
    Friend WithEvents T_GasCompra As TextBox
    Friend WithEvents T_ComisionCompra As TextBox
    Friend WithEvents T_ValorDestinoCompra As TextBox
    Friend WithEvents T_ValorOrigenCompra As TextBox
    Friend WithEvents rT_NotaCompra As RichTextBox
    Friend WithEvents T_HoraCompra As TextBox
    Friend WithEvents T_FechaCompra As TextBox
    Friend WithEvents Label07 As Label
    Friend WithEvents B_GrabarCompra As Button
    Friend WithEvents Label05 As Label
    Friend WithEvents Label08 As Label
    Friend WithEvents C_MonedaDestino As ComboBox
    Friend WithEvents Label09 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents C_MonedaOrigen As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents C_Exchange As ComboBox
    Friend WithEvents Cal_FechaCompra As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
End Class
