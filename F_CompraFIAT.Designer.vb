<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CompraFIAT
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
        Me.L_PrecioMoneda = New System.Windows.Forms.Label()
        Me.T_Comision = New System.Windows.Forms.TextBox()
        Me.T_CantidadCryptos = New System.Windows.Forms.TextBox()
        Me.T_MontoOrigen = New System.Windows.Forms.TextBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.T_Hora = New System.Windows.Forms.TextBox()
        Me.T_Fecha = New System.Windows.Forms.TextBox()
        Me.B_GrabarCompra = New System.Windows.Forms.Button()
        Me.Label05 = New System.Windows.Forms.Label()
        Me.Label08 = New System.Windows.Forms.Label()
        Me.C_MonedaDestino = New System.Windows.Forms.ComboBox()
        Me.Label09 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.C_MonedaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.C_Exchange = New System.Windows.Forms.ComboBox()
        Me.Cal_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_Fila = New System.Windows.Forms.Label()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.T_Gas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label45.Location = New System.Drawing.Point(528, 280)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 13)
        Me.Label45.TabIndex = 500
        Me.Label45.Text = "Precio Moneda"
        '
        'L_PrecioMoneda
        '
        Me.L_PrecioMoneda.BackColor = System.Drawing.Color.LightGray
        Me.L_PrecioMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_PrecioMoneda.Location = New System.Drawing.Point(528, 298)
        Me.L_PrecioMoneda.Name = "L_PrecioMoneda"
        Me.L_PrecioMoneda.Size = New System.Drawing.Size(120, 20)
        Me.L_PrecioMoneda.TabIndex = 499
        Me.L_PrecioMoneda.Text = "L_PrecioMoneda"
        '
        'T_Comision
        '
        Me.T_Comision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Comision.Location = New System.Drawing.Point(357, 298)
        Me.T_Comision.MaxLength = 12
        Me.T_Comision.Name = "T_Comision"
        Me.T_Comision.Size = New System.Drawing.Size(123, 20)
        Me.T_Comision.TabIndex = 496
        Me.T_Comision.Text = "T_Comision"
        '
        'T_CantidadCryptos
        '
        Me.T_CantidadCryptos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_CantidadCryptos.Location = New System.Drawing.Point(528, 249)
        Me.T_CantidadCryptos.MaxLength = 12
        Me.T_CantidadCryptos.Name = "T_CantidadCryptos"
        Me.T_CantidadCryptos.Size = New System.Drawing.Size(123, 20)
        Me.T_CantidadCryptos.TabIndex = 493
        Me.T_CantidadCryptos.Text = "T_CantidadCryptos"
        '
        'T_MontoOrigen
        '
        Me.T_MontoOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_MontoOrigen.Location = New System.Drawing.Point(528, 188)
        Me.T_MontoOrigen.MaxLength = 12
        Me.T_MontoOrigen.Name = "T_MontoOrigen"
        Me.T_MontoOrigen.Size = New System.Drawing.Size(123, 20)
        Me.T_MontoOrigen.TabIndex = 489
        Me.T_MontoOrigen.Text = "T_MontoOrigen"
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.White
        Me.rT_Nota.Location = New System.Drawing.Point(672, 69)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(303, 385)
        Me.rT_Nota.TabIndex = 485
        Me.rT_Nota.Text = "rT_Nota"
        '
        'T_Hora
        '
        Me.T_Hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Hora.Location = New System.Drawing.Point(450, 91)
        Me.T_Hora.MaxLength = 4
        Me.T_Hora.Name = "T_Hora"
        Me.T_Hora.Size = New System.Drawing.Size(56, 20)
        Me.T_Hora.TabIndex = 479
        Me.T_Hora.Text = "T_Hora"
        Me.T_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_Fecha
        '
        Me.T_Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Fecha.Location = New System.Drawing.Point(357, 91)
        Me.T_Fecha.MaxLength = 6
        Me.T_Fecha.Name = "T_Fecha"
        Me.T_Fecha.Size = New System.Drawing.Size(80, 20)
        Me.T_Fecha.TabIndex = 478
        Me.T_Fecha.Text = "T_Fecha"
        '
        'B_GrabarCompra
        '
        Me.B_GrabarCompra.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarCompra.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarCompra.Location = New System.Drawing.Point(357, 12)
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
        Me.Label05.Location = New System.Drawing.Point(357, 281)
        Me.Label05.Name = "Label05"
        Me.Label05.Size = New System.Drawing.Size(123, 13)
        Me.Label05.TabIndex = 494
        Me.Label05.Text = "Valor Comisión"
        '
        'Label08
        '
        Me.Label08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label08.ForeColor = System.Drawing.Color.Blue
        Me.Label08.Location = New System.Drawing.Point(528, 233)
        Me.Label08.Name = "Label08"
        Me.Label08.Size = New System.Drawing.Size(123, 13)
        Me.Label08.TabIndex = 492
        Me.Label08.Text = "Cantidad Cryptos"
        '
        'C_MonedaDestino
        '
        Me.C_MonedaDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaDestino.FormattingEnabled = True
        Me.C_MonedaDestino.Location = New System.Drawing.Point(357, 248)
        Me.C_MonedaDestino.Name = "C_MonedaDestino"
        Me.C_MonedaDestino.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaDestino.TabIndex = 491
        Me.C_MonedaDestino.Text = "C_MonedaDestino"
        '
        'Label09
        '
        Me.Label09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label09.ForeColor = System.Drawing.Color.Blue
        Me.Label09.Location = New System.Drawing.Point(357, 232)
        Me.Label09.Name = "Label09"
        Me.Label09.Size = New System.Drawing.Size(126, 13)
        Me.Label09.TabIndex = 490
        Me.Label09.Text = "Moneda Destino"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(528, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 488
        Me.Label10.Text = "Monto Origen"
        '
        'C_MonedaOrigen
        '
        Me.C_MonedaOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedaOrigen.FormattingEnabled = True
        Me.C_MonedaOrigen.Location = New System.Drawing.Point(357, 187)
        Me.C_MonedaOrigen.Name = "C_MonedaOrigen"
        Me.C_MonedaOrigen.Size = New System.Drawing.Size(123, 21)
        Me.C_MonedaOrigen.TabIndex = 487
        Me.C_MonedaOrigen.Text = "C_MonedaOrigen"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(357, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 486
        Me.Label11.Text = "Moneda Origen"
        '
        'C_Exchange
        '
        Me.C_Exchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Exchange.FormattingEnabled = True
        Me.C_Exchange.Location = New System.Drawing.Point(528, 91)
        Me.C_Exchange.Name = "C_Exchange"
        Me.C_Exchange.Size = New System.Drawing.Size(123, 21)
        Me.C_Exchange.TabIndex = 484
        Me.C_Exchange.Text = "C_Exchange"
        '
        'Cal_Fecha
        '
        Me.Cal_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cal_Fecha.Location = New System.Drawing.Point(357, 120)
        Me.Cal_Fecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.Cal_Fecha.Name = "Cal_Fecha"
        Me.Cal_Fecha.Size = New System.Drawing.Size(80, 20)
        Me.Cal_Fecha.TabIndex = 483
        Me.Cal_Fecha.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(447, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 28)
        Me.Label12.TabIndex = 482
        Me.Label12.Text = "Hora HHmmSS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(357, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 28)
        Me.Label13.TabIndex = 481
        Me.Label13.Text = "Fecha YYYYmmDD"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(528, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 480
        Me.Label14.Text = "Exchange"
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(357, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 652
        Me.Label2.Text = "Fila"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_Fila
        '
        Me.L_Fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila.ForeColor = System.Drawing.Color.Black
        Me.L_Fila.Location = New System.Drawing.Point(357, 441)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(123, 13)
        Me.L_Fila.TabIndex = 651
        Me.L_Fila.Text = "L_Fila"
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(357, 486)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(294, 16)
        Me.L_Mensaje.TabIndex = 653
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'T_Gas
        '
        Me.T_Gas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Gas.Location = New System.Drawing.Point(357, 356)
        Me.T_Gas.MaxLength = 12
        Me.T_Gas.Name = "T_Gas"
        Me.T_Gas.Size = New System.Drawing.Size(123, 20)
        Me.T_Gas.TabIndex = 655
        Me.T_Gas.Text = "T_Gas"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(357, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 654
        Me.Label1.Text = "Valor Gas"
        '
        'F_CompraFIAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 526)
        Me.Controls.Add(Me.T_Gas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Compras)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.L_PrecioMoneda)
        Me.Controls.Add(Me.T_Comision)
        Me.Controls.Add(Me.T_CantidadCryptos)
        Me.Controls.Add(Me.T_MontoOrigen)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.T_Hora)
        Me.Controls.Add(Me.T_Fecha)
        Me.Controls.Add(Me.B_GrabarCompra)
        Me.Controls.Add(Me.Label05)
        Me.Controls.Add(Me.Label08)
        Me.Controls.Add(Me.C_MonedaDestino)
        Me.Controls.Add(Me.Label09)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.C_MonedaOrigen)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.C_Exchange)
        Me.Controls.Add(Me.Cal_Fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "F_CompraFIAT"
        Me.Text = "Compra FIAT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Compras As ListBox
    Friend WithEvents Label45 As Label
    Friend WithEvents L_PrecioMoneda As Label
    Friend WithEvents T_Comision As TextBox
    Friend WithEvents T_CantidadCryptos As TextBox
    Friend WithEvents T_MontoOrigen As TextBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents T_Hora As TextBox
    Friend WithEvents T_Fecha As TextBox
    Friend WithEvents B_GrabarCompra As Button
    Friend WithEvents Label05 As Label
    Friend WithEvents Label08 As Label
    Friend WithEvents C_MonedaDestino As ComboBox
    Friend WithEvents Label09 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents C_MonedaOrigen As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents C_Exchange As ComboBox
    Friend WithEvents Cal_Fecha As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Fila As Label
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents T_Gas As TextBox
    Friend WithEvents Label1 As Label
End Class
