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
        Me.C_BilleteraDestino = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.C_BilleteraOrigen = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.T_Gas = New System.Windows.Forms.TextBox()
        Me.T_Comision = New System.Windows.Forms.TextBox()
        Me.T_ValorDestino = New System.Windows.Forms.TextBox()
        Me.T_ValorOrigen = New System.Windows.Forms.TextBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.T_Hora = New System.Windows.Forms.TextBox()
        Me.T_Fecha = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.B_GrabarTraspaso = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.C_MonedaDestino = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.C_Exchange = New System.Windows.Forms.ComboBox()
        Me.Cal_FechaTraspaso = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.L_Mensaje = New System.Windows.Forms.Label()
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
        'C_BilleteraDestino
        '
        Me.C_BilleteraDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraDestino.FormattingEnabled = True
        Me.C_BilleteraDestino.Location = New System.Drawing.Point(360, 243)
        Me.C_BilleteraDestino.Name = "C_BilleteraDestino"
        Me.C_BilleteraDestino.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraDestino.TabIndex = 525
        Me.C_BilleteraDestino.Text = "C_BilleteraDestino"
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
        'C_BilleteraOrigen
        '
        Me.C_BilleteraOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraOrigen.FormattingEnabled = True
        Me.C_BilleteraOrigen.Location = New System.Drawing.Point(360, 180)
        Me.C_BilleteraOrigen.Name = "C_BilleteraOrigen"
        Me.C_BilleteraOrigen.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraOrigen.TabIndex = 523
        Me.C_BilleteraOrigen.Text = "C_BilleteraOrigen"
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
        'T_Gas
        '
        Me.T_Gas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Gas.Location = New System.Drawing.Point(659, 305)
        Me.T_Gas.MaxLength = 6
        Me.T_Gas.Name = "T_Gas"
        Me.T_Gas.Size = New System.Drawing.Size(123, 20)
        Me.T_Gas.TabIndex = 521
        Me.T_Gas.Text = "T_Gas"
        '
        'T_Comision
        '
        Me.T_Comision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Comision.Location = New System.Drawing.Point(505, 306)
        Me.T_Comision.MaxLength = 6
        Me.T_Comision.Name = "T_Comision"
        Me.T_Comision.Size = New System.Drawing.Size(123, 20)
        Me.T_Comision.TabIndex = 519
        Me.T_Comision.Text = "T_Comision"
        '
        'T_ValorDestino
        '
        Me.T_ValorDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorDestino.Location = New System.Drawing.Point(659, 244)
        Me.T_ValorDestino.MaxLength = 6
        Me.T_ValorDestino.Name = "T_ValorDestino"
        Me.T_ValorDestino.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorDestino.TabIndex = 516
        Me.T_ValorDestino.Text = "T_ValorDestino"
        '
        'T_ValorOrigen
        '
        Me.T_ValorOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorOrigen.Location = New System.Drawing.Point(659, 180)
        Me.T_ValorOrigen.MaxLength = 6
        Me.T_ValorOrigen.Name = "T_ValorOrigen"
        Me.T_ValorOrigen.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorOrigen.TabIndex = 512
        Me.T_ValorOrigen.Text = "T_ValorOrigen"
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rT_Nota.Location = New System.Drawing.Point(360, 347)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(425, 119)
        Me.rT_Nota.TabIndex = 508
        Me.rT_Nota.Text = "rT_Nota"
        '
        'T_Hora
        '
        Me.T_Hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Hora.Location = New System.Drawing.Point(480, 98)
        Me.T_Hora.MaxLength = 4
        Me.T_Hora.Name = "T_Hora"
        Me.T_Hora.Size = New System.Drawing.Size(56, 20)
        Me.T_Hora.TabIndex = 502
        Me.T_Hora.Text = "T_Hora"
        Me.T_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_Fecha
        '
        Me.T_Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Fecha.Location = New System.Drawing.Point(360, 98)
        Me.T_Fecha.MaxLength = 6
        Me.T_Fecha.Name = "T_Fecha"
        Me.T_Fecha.Size = New System.Drawing.Size(80, 20)
        Me.T_Fecha.TabIndex = 501
        Me.T_Fecha.Text = "T_Fecha"
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
        Me.B_GrabarTraspaso.Location = New System.Drawing.Point(360, 12)
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
        'C_MonedaDestino
        '
        Me.C_MonedaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestino.FormattingEnabled = True
        Me.C_MonedaDestino.Location = New System.Drawing.Point(505, 243)
        Me.C_MonedaDestino.Name = "C_MonedaDestino"
        Me.C_MonedaDestino.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestino.TabIndex = 514
        Me.C_MonedaDestino.Text = "C_MonedaDestino"
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
        'C_MonedaOrigen
        '
        Me.C_MonedaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigen.FormattingEnabled = True
        Me.C_MonedaOrigen.Location = New System.Drawing.Point(505, 179)
        Me.C_MonedaOrigen.Name = "C_MonedaOrigen"
        Me.C_MonedaOrigen.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigen.TabIndex = 510
        Me.C_MonedaOrigen.Text = "C_MonedaOrigen"
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
        'C_Exchange
        '
        Me.C_Exchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Exchange.FormattingEnabled = True
        Me.C_Exchange.Location = New System.Drawing.Point(558, 98)
        Me.C_Exchange.Name = "C_Exchange"
        Me.C_Exchange.Size = New System.Drawing.Size(123, 21)
        Me.C_Exchange.TabIndex = 507
        Me.C_Exchange.Text = "C_Exchange"
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
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 527
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
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(360, 485)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(422, 16)
        Me.L_Mensaje.TabIndex = 652
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'F_Traspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 520)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Traspasos)
        Me.Controls.Add(Me.C_BilleteraDestino)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.C_BilleteraOrigen)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.T_Gas)
        Me.Controls.Add(Me.T_Comision)
        Me.Controls.Add(Me.T_ValorDestino)
        Me.Controls.Add(Me.T_ValorOrigen)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.T_Hora)
        Me.Controls.Add(Me.T_Fecha)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.B_GrabarTraspaso)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.C_MonedaDestino)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.C_MonedaOrigen)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.C_Exchange)
        Me.Controls.Add(Me.Cal_FechaTraspaso)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Traspaso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_Traspaso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Traspasos As ListBox
    Friend WithEvents C_BilleteraDestino As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents C_BilleteraOrigen As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents T_Gas As TextBox
    Friend WithEvents T_Comision As TextBox
    Friend WithEvents T_ValorDestino As TextBox
    Friend WithEvents T_ValorOrigen As TextBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents T_Hora As TextBox
    Friend WithEvents T_Fecha As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents B_GrabarTraspaso As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents C_MonedaDestino As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents C_MonedaOrigen As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents C_Exchange As ComboBox
    Friend WithEvents Cal_FechaTraspaso As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
    Friend WithEvents L_Mensaje As Label
End Class
