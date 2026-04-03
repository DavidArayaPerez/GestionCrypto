<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Depositos
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
        Me.L_Depositos = New System.Windows.Forms.ListBox()
        Me.C_BilleteraDeposito = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.B_GrabarDeposito = New System.Windows.Forms.Button()
        Me.Label06 = New System.Windows.Forms.Label()
        Me.L_PrecioMonedaDeposito = New System.Windows.Forms.Label()
        Me.T_ValorDestinoDeposito = New System.Windows.Forms.TextBox()
        Me.T_ValorOrigenDeposito = New System.Windows.Forms.TextBox()
        Me.rT_NotaDeposito = New System.Windows.Forms.RichTextBox()
        Me.T_HoraDeposito = New System.Windows.Forms.TextBox()
        Me.T_FechaDeposito = New System.Windows.Forms.TextBox()
        Me.Label03 = New System.Windows.Forms.Label()
        Me.C_MonedaDestinoDeposito = New System.Windows.Forms.ComboBox()
        Me.Label04 = New System.Windows.Forms.Label()
        Me.Label02 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigenDeposito = New System.Windows.Forms.ComboBox()
        Me.Label01 = New System.Windows.Forms.Label()
        Me.C_ExchangeDeposito = New System.Windows.Forms.ComboBox()
        Me.Cal_FechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Depositos
        '
        Me.L_Depositos.FormattingEnabled = True
        Me.L_Depositos.Location = New System.Drawing.Point(12, 61)
        Me.L_Depositos.Name = "L_Depositos"
        Me.L_Depositos.Size = New System.Drawing.Size(316, 420)
        Me.L_Depositos.TabIndex = 475
        '
        'C_BilleteraDeposito
        '
        Me.C_BilleteraDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraDeposito.FormattingEnabled = True
        Me.C_BilleteraDeposito.Location = New System.Drawing.Point(695, 76)
        Me.C_BilleteraDeposito.Name = "C_BilleteraDeposito"
        Me.C_BilleteraDeposito.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraDeposito.TabIndex = 474
        Me.C_BilleteraDeposito.Text = "C_BilleteraDeposito"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Blue
        Me.Label40.Location = New System.Drawing.Point(695, 60)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(123, 13)
        Me.Label40.TabIndex = 473
        Me.Label40.Text = "Billetera"
        '
        'B_GrabarDeposito
        '
        Me.B_GrabarDeposito.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarDeposito.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarDeposito.Location = New System.Drawing.Point(361, 12)
        Me.B_GrabarDeposito.Name = "B_GrabarDeposito"
        Me.B_GrabarDeposito.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarDeposito.TabIndex = 472
        Me.B_GrabarDeposito.Text = "Grabar"
        Me.B_GrabarDeposito.UseVisualStyleBackColor = False
        '
        'Label06
        '
        Me.Label06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label06.ForeColor = System.Drawing.Color.Blue
        Me.Label06.Location = New System.Drawing.Point(649, 192)
        Me.Label06.Name = "Label06"
        Me.Label06.Size = New System.Drawing.Size(126, 13)
        Me.Label06.TabIndex = 471
        Me.Label06.Text = "Precio Moneda"
        '
        'L_PrecioMonedaDeposito
        '
        Me.L_PrecioMonedaDeposito.BackColor = System.Drawing.Color.LightGray
        Me.L_PrecioMonedaDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_PrecioMonedaDeposito.Location = New System.Drawing.Point(649, 209)
        Me.L_PrecioMonedaDeposito.Name = "L_PrecioMonedaDeposito"
        Me.L_PrecioMonedaDeposito.Size = New System.Drawing.Size(126, 20)
        Me.L_PrecioMonedaDeposito.TabIndex = 470
        Me.L_PrecioMonedaDeposito.Text = "L_PrecioMonedaDeposito"
        '
        'T_ValorDestinoDeposito
        '
        Me.T_ValorDestinoDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorDestinoDeposito.Location = New System.Drawing.Point(499, 209)
        Me.T_ValorDestinoDeposito.MaxLength = 6
        Me.T_ValorDestinoDeposito.Name = "T_ValorDestinoDeposito"
        Me.T_ValorDestinoDeposito.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorDestinoDeposito.TabIndex = 469
        Me.T_ValorDestinoDeposito.Text = "T_ValorDestinoDeposito"
        '
        'T_ValorOrigenDeposito
        '
        Me.T_ValorOrigenDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorOrigenDeposito.Location = New System.Drawing.Point(499, 161)
        Me.T_ValorOrigenDeposito.MaxLength = 6
        Me.T_ValorOrigenDeposito.Name = "T_ValorOrigenDeposito"
        Me.T_ValorOrigenDeposito.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorOrigenDeposito.TabIndex = 465
        Me.T_ValorOrigenDeposito.Text = "T_ValorOrigenDeposito"
        '
        'rT_NotaDeposito
        '
        Me.rT_NotaDeposito.AcceptsTab = True
        Me.rT_NotaDeposito.AutoWordSelection = True
        Me.rT_NotaDeposito.BackColor = System.Drawing.Color.White
        Me.rT_NotaDeposito.Location = New System.Drawing.Point(361, 254)
        Me.rT_NotaDeposito.Name = "rT_NotaDeposito"
        Me.rT_NotaDeposito.ReadOnly = True
        Me.rT_NotaDeposito.Size = New System.Drawing.Size(457, 227)
        Me.rT_NotaDeposito.TabIndex = 461
        Me.rT_NotaDeposito.Text = "rT_NotaDeposito"
        '
        'T_HoraDeposito
        '
        Me.T_HoraDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_HoraDeposito.Location = New System.Drawing.Point(478, 76)
        Me.T_HoraDeposito.MaxLength = 4
        Me.T_HoraDeposito.Name = "T_HoraDeposito"
        Me.T_HoraDeposito.Size = New System.Drawing.Size(56, 20)
        Me.T_HoraDeposito.TabIndex = 455
        Me.T_HoraDeposito.Text = "T_HoraDeposito"
        Me.T_HoraDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaDeposito
        '
        Me.T_FechaDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaDeposito.Location = New System.Drawing.Point(361, 76)
        Me.T_FechaDeposito.MaxLength = 6
        Me.T_FechaDeposito.Name = "T_FechaDeposito"
        Me.T_FechaDeposito.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaDeposito.TabIndex = 454
        Me.T_FechaDeposito.Text = "T_FechaDeposito"
        '
        'Label03
        '
        Me.Label03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label03.ForeColor = System.Drawing.Color.Blue
        Me.Label03.Location = New System.Drawing.Point(499, 193)
        Me.Label03.Name = "Label03"
        Me.Label03.Size = New System.Drawing.Size(126, 13)
        Me.Label03.TabIndex = 468
        Me.Label03.Text = "Valor Moneda Destino"
        '
        'C_MonedaDestinoDeposito
        '
        Me.C_MonedaDestinoDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestinoDeposito.FormattingEnabled = True
        Me.C_MonedaDestinoDeposito.Location = New System.Drawing.Point(361, 209)
        Me.C_MonedaDestinoDeposito.Name = "C_MonedaDestinoDeposito"
        Me.C_MonedaDestinoDeposito.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestinoDeposito.TabIndex = 467
        Me.C_MonedaDestinoDeposito.Text = "C_MonedaDestinoDeposito"
        '
        'Label04
        '
        Me.Label04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label04.ForeColor = System.Drawing.Color.Blue
        Me.Label04.Location = New System.Drawing.Point(361, 193)
        Me.Label04.Name = "Label04"
        Me.Label04.Size = New System.Drawing.Size(126, 13)
        Me.Label04.TabIndex = 466
        Me.Label04.Text = "Moneda Destino"
        '
        'Label02
        '
        Me.Label02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label02.ForeColor = System.Drawing.Color.Blue
        Me.Label02.Location = New System.Drawing.Point(499, 145)
        Me.Label02.Name = "Label02"
        Me.Label02.Size = New System.Drawing.Size(126, 13)
        Me.Label02.TabIndex = 464
        Me.Label02.Text = "Valor Moneda Origen"
        '
        'C_MonedaOrigenDeposito
        '
        Me.C_MonedaOrigenDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigenDeposito.FormattingEnabled = True
        Me.C_MonedaOrigenDeposito.Location = New System.Drawing.Point(361, 161)
        Me.C_MonedaOrigenDeposito.Name = "C_MonedaOrigenDeposito"
        Me.C_MonedaOrigenDeposito.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigenDeposito.TabIndex = 463
        Me.C_MonedaOrigenDeposito.Text = "C_MonedaOrigenDeposito"
        '
        'Label01
        '
        Me.Label01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label01.ForeColor = System.Drawing.Color.Blue
        Me.Label01.Location = New System.Drawing.Point(361, 145)
        Me.Label01.Name = "Label01"
        Me.Label01.Size = New System.Drawing.Size(126, 13)
        Me.Label01.TabIndex = 462
        Me.Label01.Text = "Moneda Origen"
        '
        'C_ExchangeDeposito
        '
        Me.C_ExchangeDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_ExchangeDeposito.FormattingEnabled = True
        Me.C_ExchangeDeposito.Location = New System.Drawing.Point(558, 76)
        Me.C_ExchangeDeposito.Name = "C_ExchangeDeposito"
        Me.C_ExchangeDeposito.Size = New System.Drawing.Size(123, 21)
        Me.C_ExchangeDeposito.TabIndex = 460
        Me.C_ExchangeDeposito.Text = "C_ExchangeDeposito"
        '
        'Cal_FechaDeposito
        '
        Me.Cal_FechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cal_FechaDeposito.Location = New System.Drawing.Point(361, 104)
        Me.Cal_FechaDeposito.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Cal_FechaDeposito.Name = "Cal_FechaDeposito"
        Me.Cal_FechaDeposito.Size = New System.Drawing.Size(111, 20)
        Me.Cal_FechaDeposito.TabIndex = 459
        Me.Cal_FechaDeposito.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.Cal_FechaDeposito.Visible = False
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Blue
        Me.Label69.Location = New System.Drawing.Point(475, 60)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(59, 13)
        Me.Label69.TabIndex = 458
        Me.Label69.Text = "Hora"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(361, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 457
        Me.Label21.Text = "Fecha"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(558, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 13)
        Me.Label20.TabIndex = 456
        Me.Label20.Text = "Plataforma"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 476
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
        'F_Depositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 499)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Depositos)
        Me.Controls.Add(Me.C_BilleteraDeposito)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.B_GrabarDeposito)
        Me.Controls.Add(Me.Label06)
        Me.Controls.Add(Me.L_PrecioMonedaDeposito)
        Me.Controls.Add(Me.T_ValorDestinoDeposito)
        Me.Controls.Add(Me.T_ValorOrigenDeposito)
        Me.Controls.Add(Me.rT_NotaDeposito)
        Me.Controls.Add(Me.T_HoraDeposito)
        Me.Controls.Add(Me.T_FechaDeposito)
        Me.Controls.Add(Me.Label03)
        Me.Controls.Add(Me.C_MonedaDestinoDeposito)
        Me.Controls.Add(Me.Label04)
        Me.Controls.Add(Me.Label02)
        Me.Controls.Add(Me.C_MonedaOrigenDeposito)
        Me.Controls.Add(Me.Label01)
        Me.Controls.Add(Me.C_ExchangeDeposito)
        Me.Controls.Add(Me.Cal_FechaDeposito)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Name = "F_Depositos"
        Me.Text = "F_Depositos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Depositos As ListBox
    Friend WithEvents C_BilleteraDeposito As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents B_GrabarDeposito As Button
    Friend WithEvents Label06 As Label
    Friend WithEvents L_PrecioMonedaDeposito As Label
    Friend WithEvents T_ValorDestinoDeposito As TextBox
    Friend WithEvents T_ValorOrigenDeposito As TextBox
    Friend WithEvents rT_NotaDeposito As RichTextBox
    Friend WithEvents T_HoraDeposito As TextBox
    Friend WithEvents T_FechaDeposito As TextBox
    Friend WithEvents Label03 As Label
    Friend WithEvents C_MonedaDestinoDeposito As ComboBox
    Friend WithEvents Label04 As Label
    Friend WithEvents Label02 As Label
    Friend WithEvents C_MonedaOrigenDeposito As ComboBox
    Friend WithEvents Label01 As Label
    Friend WithEvents C_ExchangeDeposito As ComboBox
    Friend WithEvents Cal_FechaDeposito As DateTimePicker
    Friend WithEvents Label69 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
End Class
