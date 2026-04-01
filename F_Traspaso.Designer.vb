<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Traspaso
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
        Me.L_Traspasos = New System.Windows.Forms.ListBox()
        Me.C_BilleteraDestinoTraspaso = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.C_BilleteraOrigenTraspaso = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.T_GasTraspaso = New System.Windows.Forms.TextBox()
        Me.T_ComisionTraspaso = New System.Windows.Forms.TextBox()
        Me.T_ValorDestinoTraspaso = New System.Windows.Forms.TextBox()
        Me.T_ValorOrigenTraspaso = New System.Windows.Forms.TextBox()
        Me.rT_NotaTraspaso = New System.Windows.Forms.RichTextBox()
        Me.T_HoraTraspaso = New System.Windows.Forms.TextBox()
        Me.T_FechaTraspaso = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.B_GrabarTraspaso = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.C_MonedaDestinoTraspaso = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigenTraspaso = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.C_ExchangeTraspaso = New System.Windows.Forms.ComboBox()
        Me.Cal_FechaTraspaso = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Traspasos
        '
        Me.L_Traspasos.FormattingEnabled = True
        Me.L_Traspasos.Location = New System.Drawing.Point(12, 68)
        Me.L_Traspasos.Name = "L_Traspasos"
        Me.L_Traspasos.Size = New System.Drawing.Size(316, 433)
        Me.L_Traspasos.TabIndex = 526
        '
        'C_BilleteraDestinoTraspaso
        '
        Me.C_BilleteraDestinoTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraDestinoTraspaso.FormattingEnabled = True
        Me.C_BilleteraDestinoTraspaso.Location = New System.Drawing.Point(360, 243)
        Me.C_BilleteraDestinoTraspaso.Name = "C_BilleteraDestinoTraspaso"
        Me.C_BilleteraDestinoTraspaso.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraDestinoTraspaso.TabIndex = 525
        Me.C_BilleteraDestinoTraspaso.Text = "C_BilleteraDestinoTraspaso"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Blue
        Me.Label44.Location = New System.Drawing.Point(360, 224)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(126, 13)
        Me.Label44.TabIndex = 524
        Me.Label44.Text = "Billetera Destino"
        '
        'C_BilleteraOrigenTraspaso
        '
        Me.C_BilleteraOrigenTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraOrigenTraspaso.FormattingEnabled = True
        Me.C_BilleteraOrigenTraspaso.Location = New System.Drawing.Point(360, 180)
        Me.C_BilleteraOrigenTraspaso.Name = "C_BilleteraOrigenTraspaso"
        Me.C_BilleteraOrigenTraspaso.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraOrigenTraspaso.TabIndex = 523
        Me.C_BilleteraOrigenTraspaso.Text = "C_BilleteraOrigenTraspaso"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Blue
        Me.Label41.Location = New System.Drawing.Point(360, 161)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(126, 13)
        Me.Label41.TabIndex = 522
        Me.Label41.Text = "Billetera Origen"
        '
        'T_GasTraspaso
        '
        Me.T_GasTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_GasTraspaso.Location = New System.Drawing.Point(659, 305)
        Me.T_GasTraspaso.MaxLength = 6
        Me.T_GasTraspaso.Name = "T_GasTraspaso"
        Me.T_GasTraspaso.Size = New System.Drawing.Size(123, 20)
        Me.T_GasTraspaso.TabIndex = 521
        Me.T_GasTraspaso.Text = "T_GasTraspaso"
        '
        'T_ComisionTraspaso
        '
        Me.T_ComisionTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ComisionTraspaso.Location = New System.Drawing.Point(505, 306)
        Me.T_ComisionTraspaso.MaxLength = 6
        Me.T_ComisionTraspaso.Name = "T_ComisionTraspaso"
        Me.T_ComisionTraspaso.Size = New System.Drawing.Size(123, 20)
        Me.T_ComisionTraspaso.TabIndex = 519
        Me.T_ComisionTraspaso.Text = "T_ComisionTraspaso"
        '
        'T_ValorDestinoTraspaso
        '
        Me.T_ValorDestinoTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorDestinoTraspaso.Location = New System.Drawing.Point(659, 244)
        Me.T_ValorDestinoTraspaso.MaxLength = 6
        Me.T_ValorDestinoTraspaso.Name = "T_ValorDestinoTraspaso"
        Me.T_ValorDestinoTraspaso.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorDestinoTraspaso.TabIndex = 516
        Me.T_ValorDestinoTraspaso.Text = "T_ValorDestinoTraspaso"
        '
        'T_ValorOrigenTraspaso
        '
        Me.T_ValorOrigenTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorOrigenTraspaso.Location = New System.Drawing.Point(659, 180)
        Me.T_ValorOrigenTraspaso.MaxLength = 6
        Me.T_ValorOrigenTraspaso.Name = "T_ValorOrigenTraspaso"
        Me.T_ValorOrigenTraspaso.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorOrigenTraspaso.TabIndex = 512
        Me.T_ValorOrigenTraspaso.Text = "T_ValorOrigenTraspaso"
        '
        'rT_NotaTraspaso
        '
        Me.rT_NotaTraspaso.AcceptsTab = True
        Me.rT_NotaTraspaso.AutoWordSelection = True
        Me.rT_NotaTraspaso.BackColor = System.Drawing.Color.White
        Me.rT_NotaTraspaso.Location = New System.Drawing.Point(360, 347)
        Me.rT_NotaTraspaso.Name = "rT_NotaTraspaso"
        Me.rT_NotaTraspaso.ReadOnly = True
        Me.rT_NotaTraspaso.Size = New System.Drawing.Size(457, 154)
        Me.rT_NotaTraspaso.TabIndex = 508
        Me.rT_NotaTraspaso.Text = "rT_NotaTraspaso"
        '
        'T_HoraTraspaso
        '
        Me.T_HoraTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_HoraTraspaso.Location = New System.Drawing.Point(480, 98)
        Me.T_HoraTraspaso.MaxLength = 4
        Me.T_HoraTraspaso.Name = "T_HoraTraspaso"
        Me.T_HoraTraspaso.Size = New System.Drawing.Size(56, 20)
        Me.T_HoraTraspaso.TabIndex = 502
        Me.T_HoraTraspaso.Text = "T_HoraTraspaso"
        Me.T_HoraTraspaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaTraspaso
        '
        Me.T_FechaTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaTraspaso.Location = New System.Drawing.Point(360, 98)
        Me.T_FechaTraspaso.MaxLength = 6
        Me.T_FechaTraspaso.Name = "T_FechaTraspaso"
        Me.T_FechaTraspaso.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaTraspaso.TabIndex = 501
        Me.T_FechaTraspaso.Text = "T_FechaTraspaso"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(659, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 13)
        Me.Label15.TabIndex = 520
        Me.Label15.Text = "Gas"
        '
        'B_GrabarTraspaso
        '
        Me.B_GrabarTraspaso.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarTraspaso.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarTraspaso.Location = New System.Drawing.Point(12, 12)
        Me.B_GrabarTraspaso.Name = "B_GrabarTraspaso"
        Me.B_GrabarTraspaso.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarTraspaso.TabIndex = 518
        Me.B_GrabarTraspaso.Text = "Grabar"
        Me.B_GrabarTraspaso.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(505, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 13)
        Me.Label16.TabIndex = 517
        Me.Label16.Text = "Comisión"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(659, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 13)
        Me.Label18.TabIndex = 515
        Me.Label18.Text = "Valor Moneda Destino"
        '
        'C_MonedaDestinoTraspaso
        '
        Me.C_MonedaDestinoTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestinoTraspaso.FormattingEnabled = True
        Me.C_MonedaDestinoTraspaso.Location = New System.Drawing.Point(505, 243)
        Me.C_MonedaDestinoTraspaso.Name = "C_MonedaDestinoTraspaso"
        Me.C_MonedaDestinoTraspaso.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestinoTraspaso.TabIndex = 514
        Me.C_MonedaDestinoTraspaso.Text = "C_MonedaDestinoTraspaso"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(505, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 13)
        Me.Label22.TabIndex = 513
        Me.Label22.Text = "Moneda Destino"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(659, 161)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 13)
        Me.Label23.TabIndex = 511
        Me.Label23.Text = "Valor Moneda Origen"
        '
        'C_MonedaOrigenTraspaso
        '
        Me.C_MonedaOrigenTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigenTraspaso.FormattingEnabled = True
        Me.C_MonedaOrigenTraspaso.Location = New System.Drawing.Point(505, 179)
        Me.C_MonedaOrigenTraspaso.Name = "C_MonedaOrigenTraspaso"
        Me.C_MonedaOrigenTraspaso.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigenTraspaso.TabIndex = 510
        Me.C_MonedaOrigenTraspaso.Text = "C_MonedaOrigenTraspaso"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(505, 161)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(126, 13)
        Me.Label24.TabIndex = 509
        Me.Label24.Text = "Moneda Origen"
        '
        'C_ExchangeTraspaso
        '
        Me.C_ExchangeTraspaso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_ExchangeTraspaso.FormattingEnabled = True
        Me.C_ExchangeTraspaso.Location = New System.Drawing.Point(558, 98)
        Me.C_ExchangeTraspaso.Name = "C_ExchangeTraspaso"
        Me.C_ExchangeTraspaso.Size = New System.Drawing.Size(123, 21)
        Me.C_ExchangeTraspaso.TabIndex = 507
        Me.C_ExchangeTraspaso.Text = "C_ExchangeTraspaso"
        '
        'Cal_FechaTraspaso
        '
        Me.Cal_FechaTraspaso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cal_FechaTraspaso.Location = New System.Drawing.Point(360, 123)
        Me.Cal_FechaTraspaso.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Cal_FechaTraspaso.Name = "Cal_FechaTraspaso"
        Me.Cal_FechaTraspaso.Size = New System.Drawing.Size(111, 20)
        Me.Cal_FechaTraspaso.TabIndex = 506
        Me.Cal_FechaTraspaso.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.Cal_FechaTraspaso.Visible = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(477, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 13)
        Me.Label25.TabIndex = 505
        Me.Label25.Text = "Hora"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(360, 73)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 13)
        Me.Label26.TabIndex = 504
        Me.Label26.Text = "Fecha"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(558, 74)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(126, 13)
        Me.Label27.TabIndex = 503
        Me.Label27.Text = "Plataforma"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(718, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 527
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'F_Traspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 598)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Traspasos)
        Me.Controls.Add(Me.C_BilleteraDestinoTraspaso)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.C_BilleteraOrigenTraspaso)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.T_GasTraspaso)
        Me.Controls.Add(Me.T_ComisionTraspaso)
        Me.Controls.Add(Me.T_ValorDestinoTraspaso)
        Me.Controls.Add(Me.T_ValorOrigenTraspaso)
        Me.Controls.Add(Me.rT_NotaTraspaso)
        Me.Controls.Add(Me.T_HoraTraspaso)
        Me.Controls.Add(Me.T_FechaTraspaso)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.B_GrabarTraspaso)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.C_MonedaDestinoTraspaso)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.C_MonedaOrigenTraspaso)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.C_ExchangeTraspaso)
        Me.Controls.Add(Me.Cal_FechaTraspaso)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Name = "F_Traspaso"
        Me.Text = "F_Traspaso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Traspasos As ListBox
    Friend WithEvents C_BilleteraDestinoTraspaso As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents C_BilleteraOrigenTraspaso As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents T_GasTraspaso As TextBox
    Friend WithEvents T_ComisionTraspaso As TextBox
    Friend WithEvents T_ValorDestinoTraspaso As TextBox
    Friend WithEvents T_ValorOrigenTraspaso As TextBox
    Friend WithEvents rT_NotaTraspaso As RichTextBox
    Friend WithEvents T_HoraTraspaso As TextBox
    Friend WithEvents T_FechaTraspaso As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents B_GrabarTraspaso As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents C_MonedaDestinoTraspaso As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents C_MonedaOrigenTraspaso As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents C_ExchangeTraspaso As ComboBox
    Friend WithEvents Cal_FechaTraspaso As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents B_Cerrar As Button
End Class
