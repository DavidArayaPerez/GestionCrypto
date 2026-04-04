<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PoolLiquidez
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
        Me.L_PoolLiquidez = New System.Windows.Forms.ListBox()
        Me.T_Max = New System.Windows.Forms.TextBox()
        Me.T_Min = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda2Resultante = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda1Resultante = New System.Windows.Forms.TextBox()
        Me.T_Gas = New System.Windows.Forms.TextBox()
        Me.T_Comision = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda2 = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda1 = New System.Windows.Forms.TextBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.T_Hora = New System.Windows.Forms.TextBox()
        Me.T_Fecha = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.C_Billetera = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_GrabarPool = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_Moneda2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C_Moneda1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C_Exchange = New System.Windows.Forms.ComboBox()
        Me.CalFechaPool = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_PoolLiquidez
        '
        Me.L_PoolLiquidez.FormattingEnabled = True
        Me.L_PoolLiquidez.Location = New System.Drawing.Point(12, 62)
        Me.L_PoolLiquidez.Name = "L_PoolLiquidez"
        Me.L_PoolLiquidez.Size = New System.Drawing.Size(316, 433)
        Me.L_PoolLiquidez.TabIndex = 560
        '
        'T_Max
        '
        Me.T_Max.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Max.Location = New System.Drawing.Point(500, 304)
        Me.T_Max.MaxLength = 6
        Me.T_Max.Name = "T_Max"
        Me.T_Max.Size = New System.Drawing.Size(123, 20)
        Me.T_Max.TabIndex = 559
        Me.T_Max.Text = "T_Max"
        '
        'T_Min
        '
        Me.T_Min.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Min.Location = New System.Drawing.Point(356, 301)
        Me.T_Min.MaxLength = 6
        Me.T_Min.Name = "T_Min"
        Me.T_Min.Size = New System.Drawing.Size(123, 20)
        Me.T_Min.TabIndex = 557
        Me.T_Min.Text = "T_Min"
        '
        'T_ValorMoneda2Resultante
        '
        Me.T_ValorMoneda2Resultante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda2Resultante.Location = New System.Drawing.Point(639, 234)
        Me.T_ValorMoneda2Resultante.MaxLength = 6
        Me.T_ValorMoneda2Resultante.Name = "T_ValorMoneda2Resultante"
        Me.T_ValorMoneda2Resultante.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda2Resultante.TabIndex = 553
        Me.T_ValorMoneda2Resultante.Text = "T_ValorMoneda2Resultante"
        '
        'T_ValorMoneda1Resultante
        '
        Me.T_ValorMoneda1Resultante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda1Resultante.Location = New System.Drawing.Point(639, 175)
        Me.T_ValorMoneda1Resultante.MaxLength = 6
        Me.T_ValorMoneda1Resultante.Name = "T_ValorMoneda1Resultante"
        Me.T_ValorMoneda1Resultante.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda1Resultante.TabIndex = 551
        Me.T_ValorMoneda1Resultante.Text = "T_ValorMoneda1Resultante"
        '
        'T_Gas
        '
        Me.T_Gas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Gas.Location = New System.Drawing.Point(500, 361)
        Me.T_Gas.MaxLength = 6
        Me.T_Gas.Name = "T_Gas"
        Me.T_Gas.Size = New System.Drawing.Size(123, 20)
        Me.T_Gas.TabIndex = 549
        Me.T_Gas.Text = "T_Gas"
        '
        'T_Comision
        '
        Me.T_Comision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Comision.Location = New System.Drawing.Point(356, 361)
        Me.T_Comision.MaxLength = 6
        Me.T_Comision.Name = "T_Comision"
        Me.T_Comision.Size = New System.Drawing.Size(123, 20)
        Me.T_Comision.TabIndex = 547
        Me.T_Comision.Text = "T_Comision"
        '
        'T_ValorMoneda2
        '
        Me.T_ValorMoneda2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda2.Location = New System.Drawing.Point(500, 234)
        Me.T_ValorMoneda2.MaxLength = 6
        Me.T_ValorMoneda2.Name = "T_ValorMoneda2"
        Me.T_ValorMoneda2.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda2.TabIndex = 544
        Me.T_ValorMoneda2.Text = "T_ValorMoneda2"
        '
        'T_ValorMoneda1
        '
        Me.T_ValorMoneda1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda1.Location = New System.Drawing.Point(500, 175)
        Me.T_ValorMoneda1.MaxLength = 6
        Me.T_ValorMoneda1.Name = "T_ValorMoneda1"
        Me.T_ValorMoneda1.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda1.TabIndex = 540
        Me.T_ValorMoneda1.Text = "T_ValorMoneda1"
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rT_Nota.Location = New System.Drawing.Point(356, 398)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(421, 100)
        Me.rT_Nota.TabIndex = 536
        Me.rT_Nota.Text = "rT_Nota"
        '
        'T_Hora
        '
        Me.T_Hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Hora.Location = New System.Drawing.Point(443, 88)
        Me.T_Hora.MaxLength = 4
        Me.T_Hora.Name = "T_Hora"
        Me.T_Hora.Size = New System.Drawing.Size(56, 20)
        Me.T_Hora.TabIndex = 530
        Me.T_Hora.Text = "T_Hora"
        Me.T_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_Fecha
        '
        Me.T_Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Fecha.Location = New System.Drawing.Point(356, 88)
        Me.T_Fecha.MaxLength = 6
        Me.T_Fecha.Name = "T_Fecha"
        Me.T_Fecha.Size = New System.Drawing.Size(80, 20)
        Me.T_Fecha.TabIndex = 529
        Me.T_Fecha.Text = "T_Fecha"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Blue
        Me.Label49.Location = New System.Drawing.Point(500, 284)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(126, 13)
        Me.Label49.TabIndex = 558
        Me.Label49.Text = "Maximo"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Blue
        Me.Label50.Location = New System.Drawing.Point(356, 284)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(126, 13)
        Me.Label50.TabIndex = 556
        Me.Label50.Text = "Minimo"
        '
        'C_Billetera
        '
        Me.C_Billetera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Billetera.FormattingEnabled = True
        Me.C_Billetera.Location = New System.Drawing.Point(654, 87)
        Me.C_Billetera.Name = "C_Billetera"
        Me.C_Billetera.Size = New System.Drawing.Size(123, 21)
        Me.C_Billetera.TabIndex = 555
        Me.C_Billetera.Text = "C_Billetera"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Blue
        Me.Label48.Location = New System.Drawing.Point(654, 71)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(126, 13)
        Me.Label48.TabIndex = 554
        Me.Label48.Text = "Billetera"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Blue
        Me.Label46.Location = New System.Drawing.Point(639, 218)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(148, 13)
        Me.Label46.TabIndex = 552
        Me.Label46.Text = "Valor Resultante Moneda2"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Blue
        Me.Label47.Location = New System.Drawing.Point(639, 159)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(138, 13)
        Me.Label47.TabIndex = 550
        Me.Label47.Text = "Valor Resultante Moneda1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(500, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 548
        Me.Label2.Text = "Gas"
        '
        'B_GrabarPool
        '
        Me.B_GrabarPool.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarPool.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarPool.Location = New System.Drawing.Point(356, 12)
        Me.B_GrabarPool.Name = "B_GrabarPool"
        Me.B_GrabarPool.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarPool.TabIndex = 546
        Me.B_GrabarPool.Text = "Grabar"
        Me.B_GrabarPool.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(356, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 545
        Me.Label3.Text = "Comisión"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(500, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 543
        Me.Label4.Text = "Valor Moneda2"
        '
        'C_Moneda2
        '
        Me.C_Moneda2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Moneda2.FormattingEnabled = True
        Me.C_Moneda2.Location = New System.Drawing.Point(356, 234)
        Me.C_Moneda2.Name = "C_Moneda2"
        Me.C_Moneda2.Size = New System.Drawing.Size(123, 21)
        Me.C_Moneda2.TabIndex = 542
        Me.C_Moneda2.Text = "C_Moneda2"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(356, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 541
        Me.Label5.Text = "Moneda2"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(500, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 539
        Me.Label6.Text = "Valor Moneda1"
        '
        'C_Moneda1
        '
        Me.C_Moneda1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Moneda1.FormattingEnabled = True
        Me.C_Moneda1.Location = New System.Drawing.Point(356, 175)
        Me.C_Moneda1.Name = "C_Moneda1"
        Me.C_Moneda1.Size = New System.Drawing.Size(123, 21)
        Me.C_Moneda1.TabIndex = 538
        Me.C_Moneda1.Text = "C_Moneda1"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(356, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 537
        Me.Label7.Text = "Moneda1"
        '
        'C_Exchange
        '
        Me.C_Exchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Exchange.FormattingEnabled = True
        Me.C_Exchange.Location = New System.Drawing.Point(510, 87)
        Me.C_Exchange.Name = "C_Exchange"
        Me.C_Exchange.Size = New System.Drawing.Size(123, 21)
        Me.C_Exchange.TabIndex = 535
        Me.C_Exchange.Text = "C_Exchange"
        '
        'CalFechaPool
        '
        Me.CalFechaPool.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CalFechaPool.Location = New System.Drawing.Point(356, 116)
        Me.CalFechaPool.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.CalFechaPool.Name = "CalFechaPool"
        Me.CalFechaPool.Size = New System.Drawing.Size(111, 20)
        Me.CalFechaPool.TabIndex = 534
        Me.CalFechaPool.Value = New Date(2025, 8, 26, 0, 0, 0, 0)
        Me.CalFechaPool.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(443, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 533
        Me.Label8.Text = "Hora"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(356, 71)
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
        Me.Label28.Location = New System.Drawing.Point(510, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 13)
        Me.Label28.TabIndex = 531
        Me.Label28.Text = "Plataforma"
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
        'F_PoolLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 520)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_PoolLiquidez)
        Me.Controls.Add(Me.T_Max)
        Me.Controls.Add(Me.T_Min)
        Me.Controls.Add(Me.T_ValorMoneda2Resultante)
        Me.Controls.Add(Me.T_ValorMoneda1Resultante)
        Me.Controls.Add(Me.T_Gas)
        Me.Controls.Add(Me.T_Comision)
        Me.Controls.Add(Me.T_ValorMoneda2)
        Me.Controls.Add(Me.T_ValorMoneda1)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.T_Hora)
        Me.Controls.Add(Me.T_Fecha)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.C_Billetera)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_GrabarPool)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.C_Moneda2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C_Moneda1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.C_Exchange)
        Me.Controls.Add(Me.CalFechaPool)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label28)
        Me.Name = "F_PoolLiquidez"
        Me.Text = "F_PoolLiquidez"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_PoolLiquidez As ListBox
    Friend WithEvents T_Max As TextBox
    Friend WithEvents T_Min As TextBox
    Friend WithEvents T_ValorMoneda2Resultante As TextBox
    Friend WithEvents T_ValorMoneda1Resultante As TextBox
    Friend WithEvents T_Gas As TextBox
    Friend WithEvents T_Comision As TextBox
    Friend WithEvents T_ValorMoneda2 As TextBox
    Friend WithEvents T_ValorMoneda1 As TextBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents T_Hora As TextBox
    Friend WithEvents T_Fecha As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents C_Billetera As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents B_GrabarPool As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents C_Moneda2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents C_Moneda1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents C_Exchange As ComboBox
    Friend WithEvents CalFechaPool As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents B_NuevoBilletera As Button
End Class
