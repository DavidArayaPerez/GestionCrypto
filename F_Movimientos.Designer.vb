<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Movimientos
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
        Me.L_Movimientos = New System.Windows.Forms.ListBox()
        Me.C_BilleteraMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.T_GasMovimiento = New System.Windows.Forms.TextBox()
        Me.T_ComisionMovimiento = New System.Windows.Forms.TextBox()
        Me.T_ValorDestinoMovimiento = New System.Windows.Forms.TextBox()
        Me.T_ValorOrigenMovimiento = New System.Windows.Forms.TextBox()
        Me.rT_NotaMovimiento = New System.Windows.Forms.RichTextBox()
        Me.T_HoraMovimiento = New System.Windows.Forms.TextBox()
        Me.T_FechaMovimiento = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.B_GrabarMovimiento = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.C_MonedaDestinoMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigenMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.C_ExchangeMovimiento = New System.Windows.Forms.ComboBox()
        Me.CalFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Movimientos
        '
        Me.L_Movimientos.FormattingEnabled = True
        Me.L_Movimientos.Location = New System.Drawing.Point(12, 55)
        Me.L_Movimientos.Name = "L_Movimientos"
        Me.L_Movimientos.Size = New System.Drawing.Size(316, 433)
        Me.L_Movimientos.TabIndex = 566
        '
        'C_BilleteraMovimiento
        '
        Me.C_BilleteraMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraMovimiento.FormattingEnabled = True
        Me.C_BilleteraMovimiento.Location = New System.Drawing.Point(694, 79)
        Me.C_BilleteraMovimiento.Name = "C_BilleteraMovimiento"
        Me.C_BilleteraMovimiento.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraMovimiento.TabIndex = 565
        Me.C_BilleteraMovimiento.Text = "C_BilleteraMovimiento"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Blue
        Me.Label51.Location = New System.Drawing.Point(694, 63)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(126, 13)
        Me.Label51.TabIndex = 564
        Me.Label51.Text = "Billetera"
        '
        'T_GasMovimiento
        '
        Me.T_GasMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_GasMovimiento.Location = New System.Drawing.Point(504, 291)
        Me.T_GasMovimiento.MaxLength = 6
        Me.T_GasMovimiento.Name = "T_GasMovimiento"
        Me.T_GasMovimiento.Size = New System.Drawing.Size(123, 20)
        Me.T_GasMovimiento.TabIndex = 563
        Me.T_GasMovimiento.Text = "T_GasMovimiento"
        '
        'T_ComisionMovimiento
        '
        Me.T_ComisionMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ComisionMovimiento.Location = New System.Drawing.Point(363, 292)
        Me.T_ComisionMovimiento.MaxLength = 6
        Me.T_ComisionMovimiento.Name = "T_ComisionMovimiento"
        Me.T_ComisionMovimiento.Size = New System.Drawing.Size(123, 20)
        Me.T_ComisionMovimiento.TabIndex = 561
        Me.T_ComisionMovimiento.Text = "T_ComisionMovimiento"
        '
        'T_ValorDestinoMovimiento
        '
        Me.T_ValorDestinoMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorDestinoMovimiento.Location = New System.Drawing.Point(504, 239)
        Me.T_ValorDestinoMovimiento.MaxLength = 6
        Me.T_ValorDestinoMovimiento.Name = "T_ValorDestinoMovimiento"
        Me.T_ValorDestinoMovimiento.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorDestinoMovimiento.TabIndex = 558
        Me.T_ValorDestinoMovimiento.Text = "T_ValorDestinoMovimiento"
        '
        'T_ValorOrigenMovimiento
        '
        Me.T_ValorOrigenMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorOrigenMovimiento.Location = New System.Drawing.Point(504, 172)
        Me.T_ValorOrigenMovimiento.MaxLength = 6
        Me.T_ValorOrigenMovimiento.Name = "T_ValorOrigenMovimiento"
        Me.T_ValorOrigenMovimiento.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorOrigenMovimiento.TabIndex = 554
        Me.T_ValorOrigenMovimiento.Text = "T_ValorOrigenMovimiento"
        '
        'rT_NotaMovimiento
        '
        Me.rT_NotaMovimiento.AcceptsTab = True
        Me.rT_NotaMovimiento.AutoWordSelection = True
        Me.rT_NotaMovimiento.BackColor = System.Drawing.Color.White
        Me.rT_NotaMovimiento.Location = New System.Drawing.Point(363, 334)
        Me.rT_NotaMovimiento.Name = "rT_NotaMovimiento"
        Me.rT_NotaMovimiento.ReadOnly = True
        Me.rT_NotaMovimiento.Size = New System.Drawing.Size(457, 154)
        Me.rT_NotaMovimiento.TabIndex = 550
        Me.rT_NotaMovimiento.Text = "rT_NotaMovimiento"
        '
        'T_HoraMovimiento
        '
        Me.T_HoraMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_HoraMovimiento.Location = New System.Drawing.Point(477, 79)
        Me.T_HoraMovimiento.MaxLength = 4
        Me.T_HoraMovimiento.Name = "T_HoraMovimiento"
        Me.T_HoraMovimiento.Size = New System.Drawing.Size(56, 20)
        Me.T_HoraMovimiento.TabIndex = 544
        Me.T_HoraMovimiento.Text = "T_HoraMovimiento"
        Me.T_HoraMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaMovimiento
        '
        Me.T_FechaMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaMovimiento.Location = New System.Drawing.Point(363, 79)
        Me.T_FechaMovimiento.MaxLength = 6
        Me.T_FechaMovimiento.Name = "T_FechaMovimiento"
        Me.T_FechaMovimiento.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaMovimiento.TabIndex = 543
        Me.T_FechaMovimiento.Text = "T_FechaMovimiento"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(504, 275)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(126, 13)
        Me.Label29.TabIndex = 562
        Me.Label29.Text = "Gas"
        '
        'B_GrabarMovimiento
        '
        Me.B_GrabarMovimiento.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarMovimiento.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarMovimiento.Location = New System.Drawing.Point(363, 12)
        Me.B_GrabarMovimiento.Name = "B_GrabarMovimiento"
        Me.B_GrabarMovimiento.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarMovimiento.TabIndex = 560
        Me.B_GrabarMovimiento.Text = "Grabar"
        Me.B_GrabarMovimiento.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Blue
        Me.Label30.Location = New System.Drawing.Point(363, 279)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(126, 13)
        Me.Label30.TabIndex = 559
        Me.Label30.Text = "Comisión"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.Location = New System.Drawing.Point(504, 223)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(126, 13)
        Me.Label31.TabIndex = 557
        Me.Label31.Text = "Valor Moneda Destino"
        '
        'C_MonedaDestinoMovimiento
        '
        Me.C_MonedaDestinoMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestinoMovimiento.FormattingEnabled = True
        Me.C_MonedaDestinoMovimiento.Location = New System.Drawing.Point(363, 239)
        Me.C_MonedaDestinoMovimiento.Name = "C_MonedaDestinoMovimiento"
        Me.C_MonedaDestinoMovimiento.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestinoMovimiento.TabIndex = 556
        Me.C_MonedaDestinoMovimiento.Text = "C_MonedaDestinoMovimiento"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(363, 216)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(126, 13)
        Me.Label32.TabIndex = 555
        Me.Label32.Text = "Moneda Destino"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.Location = New System.Drawing.Point(504, 156)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(126, 13)
        Me.Label33.TabIndex = 553
        Me.Label33.Text = "Valor Moneda Origen"
        '
        'C_MonedaOrigenMovimiento
        '
        Me.C_MonedaOrigenMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigenMovimiento.FormattingEnabled = True
        Me.C_MonedaOrigenMovimiento.Location = New System.Drawing.Point(363, 172)
        Me.C_MonedaOrigenMovimiento.Name = "C_MonedaOrigenMovimiento"
        Me.C_MonedaOrigenMovimiento.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigenMovimiento.TabIndex = 552
        Me.C_MonedaOrigenMovimiento.Text = "C_MonedaOrigenMovimiento"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.Location = New System.Drawing.Point(363, 152)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(126, 13)
        Me.Label34.TabIndex = 551
        Me.Label34.Text = "Moneda Origen"
        '
        'C_ExchangeMovimiento
        '
        Me.C_ExchangeMovimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_ExchangeMovimiento.FormattingEnabled = True
        Me.C_ExchangeMovimiento.Location = New System.Drawing.Point(552, 79)
        Me.C_ExchangeMovimiento.Name = "C_ExchangeMovimiento"
        Me.C_ExchangeMovimiento.Size = New System.Drawing.Size(123, 21)
        Me.C_ExchangeMovimiento.TabIndex = 549
        Me.C_ExchangeMovimiento.Text = "C_ExchangeMovimiento"
        '
        'CalFechaMovimiento
        '
        Me.CalFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CalFechaMovimiento.Location = New System.Drawing.Point(363, 109)
        Me.CalFechaMovimiento.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.CalFechaMovimiento.Name = "CalFechaMovimiento"
        Me.CalFechaMovimiento.Size = New System.Drawing.Size(111, 20)
        Me.CalFechaMovimiento.TabIndex = 548
        Me.CalFechaMovimiento.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.CalFechaMovimiento.Visible = False
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(474, 63)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(59, 13)
        Me.Label35.TabIndex = 547
        Me.Label35.Text = "Hora"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.Location = New System.Drawing.Point(363, 63)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 546
        Me.Label36.Text = "Fecha"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(552, 63)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(126, 13)
        Me.Label37.TabIndex = 545
        Me.Label37.Text = "Plataforma"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(721, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 567
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'B_NuevoBilletera
        '
        Me.B_NuevoBilletera.BackColor = System.Drawing.SystemColors.Control
        Me.B_NuevoBilletera.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_NuevoBilletera.Location = New System.Drawing.Point(468, 12)
        Me.B_NuevoBilletera.Name = "B_NuevoBilletera"
        Me.B_NuevoBilletera.Size = New System.Drawing.Size(99, 23)
        Me.B_NuevoBilletera.TabIndex = 575
        Me.B_NuevoBilletera.Text = "Nuevo"
        Me.B_NuevoBilletera.UseVisualStyleBackColor = False
        '
        'F_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 513)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Movimientos)
        Me.Controls.Add(Me.C_BilleteraMovimiento)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.T_GasMovimiento)
        Me.Controls.Add(Me.T_ComisionMovimiento)
        Me.Controls.Add(Me.T_ValorDestinoMovimiento)
        Me.Controls.Add(Me.T_ValorOrigenMovimiento)
        Me.Controls.Add(Me.rT_NotaMovimiento)
        Me.Controls.Add(Me.T_HoraMovimiento)
        Me.Controls.Add(Me.T_FechaMovimiento)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.B_GrabarMovimiento)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.C_MonedaDestinoMovimiento)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.C_MonedaOrigenMovimiento)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.C_ExchangeMovimiento)
        Me.Controls.Add(Me.CalFechaMovimiento)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Name = "F_Movimientos"
        Me.Text = "F_Movimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Movimientos As ListBox
    Friend WithEvents C_BilleteraMovimiento As ComboBox
    Friend WithEvents Label51 As Label
    Friend WithEvents T_GasMovimiento As TextBox
    Friend WithEvents T_ComisionMovimiento As TextBox
    Friend WithEvents T_ValorDestinoMovimiento As TextBox
    Friend WithEvents T_ValorOrigenMovimiento As TextBox
    Friend WithEvents rT_NotaMovimiento As RichTextBox
    Friend WithEvents T_HoraMovimiento As TextBox
    Friend WithEvents T_FechaMovimiento As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents B_GrabarMovimiento As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents C_MonedaDestinoMovimiento As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents C_MonedaOrigenMovimiento As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents C_ExchangeMovimiento As ComboBox
    Friend WithEvents CalFechaMovimiento As DateTimePicker
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
End Class
