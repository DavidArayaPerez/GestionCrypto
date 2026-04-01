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
        Me.T_MaxPool = New System.Windows.Forms.TextBox()
        Me.T_MinPool = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda2ResultantePool = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda1ResultantePool = New System.Windows.Forms.TextBox()
        Me.T_GasPool = New System.Windows.Forms.TextBox()
        Me.T_ComisionPool = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda2Pool = New System.Windows.Forms.TextBox()
        Me.T_ValorMoneda1Pool = New System.Windows.Forms.TextBox()
        Me.rT_NotaPool = New System.Windows.Forms.RichTextBox()
        Me.T_HoraPool = New System.Windows.Forms.TextBox()
        Me.T_FechaPool = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.C_BilleteraPool = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_GrabarPool = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_Moneda2Pool = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C_Moneda1Pool = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C_ExchangePool = New System.Windows.Forms.ComboBox()
        Me.CalFechaPool = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
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
        'T_MaxPool
        '
        Me.T_MaxPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_MaxPool.Location = New System.Drawing.Point(500, 304)
        Me.T_MaxPool.MaxLength = 6
        Me.T_MaxPool.Name = "T_MaxPool"
        Me.T_MaxPool.Size = New System.Drawing.Size(123, 20)
        Me.T_MaxPool.TabIndex = 559
        Me.T_MaxPool.Text = "T_MaxPool"
        '
        'T_MinPool
        '
        Me.T_MinPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_MinPool.Location = New System.Drawing.Point(356, 301)
        Me.T_MinPool.MaxLength = 6
        Me.T_MinPool.Name = "T_MinPool"
        Me.T_MinPool.Size = New System.Drawing.Size(123, 20)
        Me.T_MinPool.TabIndex = 557
        Me.T_MinPool.Text = "T_MinPool"
        '
        'T_ValorMoneda2ResultantePool
        '
        Me.T_ValorMoneda2ResultantePool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda2ResultantePool.Location = New System.Drawing.Point(639, 234)
        Me.T_ValorMoneda2ResultantePool.MaxLength = 6
        Me.T_ValorMoneda2ResultantePool.Name = "T_ValorMoneda2ResultantePool"
        Me.T_ValorMoneda2ResultantePool.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda2ResultantePool.TabIndex = 553
        Me.T_ValorMoneda2ResultantePool.Text = "T_ValorMoneda2ResultantePool"
        '
        'T_ValorMoneda1ResultantePool
        '
        Me.T_ValorMoneda1ResultantePool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda1ResultantePool.Location = New System.Drawing.Point(639, 175)
        Me.T_ValorMoneda1ResultantePool.MaxLength = 6
        Me.T_ValorMoneda1ResultantePool.Name = "T_ValorMoneda1ResultantePool"
        Me.T_ValorMoneda1ResultantePool.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda1ResultantePool.TabIndex = 551
        Me.T_ValorMoneda1ResultantePool.Text = "T_ValorMoneda1ResultantePool"
        '
        'T_GasPool
        '
        Me.T_GasPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_GasPool.Location = New System.Drawing.Point(500, 361)
        Me.T_GasPool.MaxLength = 6
        Me.T_GasPool.Name = "T_GasPool"
        Me.T_GasPool.Size = New System.Drawing.Size(123, 20)
        Me.T_GasPool.TabIndex = 549
        Me.T_GasPool.Text = "T_GasPool"
        '
        'T_ComisionPool
        '
        Me.T_ComisionPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ComisionPool.Location = New System.Drawing.Point(356, 361)
        Me.T_ComisionPool.MaxLength = 6
        Me.T_ComisionPool.Name = "T_ComisionPool"
        Me.T_ComisionPool.Size = New System.Drawing.Size(123, 20)
        Me.T_ComisionPool.TabIndex = 547
        Me.T_ComisionPool.Text = "T_ComisionPool"
        '
        'T_ValorMoneda2Pool
        '
        Me.T_ValorMoneda2Pool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda2Pool.Location = New System.Drawing.Point(500, 234)
        Me.T_ValorMoneda2Pool.MaxLength = 6
        Me.T_ValorMoneda2Pool.Name = "T_ValorMoneda2Pool"
        Me.T_ValorMoneda2Pool.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda2Pool.TabIndex = 544
        Me.T_ValorMoneda2Pool.Text = "T_ValorMoneda2Pool"
        '
        'T_ValorMoneda1Pool
        '
        Me.T_ValorMoneda1Pool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorMoneda1Pool.Location = New System.Drawing.Point(500, 175)
        Me.T_ValorMoneda1Pool.MaxLength = 6
        Me.T_ValorMoneda1Pool.Name = "T_ValorMoneda1Pool"
        Me.T_ValorMoneda1Pool.Size = New System.Drawing.Size(123, 20)
        Me.T_ValorMoneda1Pool.TabIndex = 540
        Me.T_ValorMoneda1Pool.Text = "T_ValorMoneda1Pool"
        '
        'rT_NotaPool
        '
        Me.rT_NotaPool.AcceptsTab = True
        Me.rT_NotaPool.AutoWordSelection = True
        Me.rT_NotaPool.BackColor = System.Drawing.Color.White
        Me.rT_NotaPool.Location = New System.Drawing.Point(356, 398)
        Me.rT_NotaPool.Name = "rT_NotaPool"
        Me.rT_NotaPool.ReadOnly = True
        Me.rT_NotaPool.Size = New System.Drawing.Size(421, 100)
        Me.rT_NotaPool.TabIndex = 536
        Me.rT_NotaPool.Text = "rT_NotaPool"
        '
        'T_HoraPool
        '
        Me.T_HoraPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_HoraPool.Location = New System.Drawing.Point(443, 88)
        Me.T_HoraPool.MaxLength = 4
        Me.T_HoraPool.Name = "T_HoraPool"
        Me.T_HoraPool.Size = New System.Drawing.Size(56, 20)
        Me.T_HoraPool.TabIndex = 530
        Me.T_HoraPool.Text = "T_HoraPool"
        Me.T_HoraPool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaPool
        '
        Me.T_FechaPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaPool.Location = New System.Drawing.Point(356, 88)
        Me.T_FechaPool.MaxLength = 6
        Me.T_FechaPool.Name = "T_FechaPool"
        Me.T_FechaPool.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaPool.TabIndex = 529
        Me.T_FechaPool.Text = "T_FechaPool"
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
        'C_BilleteraPool
        '
        Me.C_BilleteraPool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_BilleteraPool.FormattingEnabled = True
        Me.C_BilleteraPool.Location = New System.Drawing.Point(654, 87)
        Me.C_BilleteraPool.Name = "C_BilleteraPool"
        Me.C_BilleteraPool.Size = New System.Drawing.Size(123, 21)
        Me.C_BilleteraPool.TabIndex = 555
        Me.C_BilleteraPool.Text = "C_BilleteraPool"
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
        Me.B_GrabarPool.Location = New System.Drawing.Point(12, 12)
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
        'C_Moneda2Pool
        '
        Me.C_Moneda2Pool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Moneda2Pool.FormattingEnabled = True
        Me.C_Moneda2Pool.Location = New System.Drawing.Point(356, 234)
        Me.C_Moneda2Pool.Name = "C_Moneda2Pool"
        Me.C_Moneda2Pool.Size = New System.Drawing.Size(123, 21)
        Me.C_Moneda2Pool.TabIndex = 542
        Me.C_Moneda2Pool.Text = "C_Moneda2Pool"
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
        'C_Moneda1Pool
        '
        Me.C_Moneda1Pool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_Moneda1Pool.FormattingEnabled = True
        Me.C_Moneda1Pool.Location = New System.Drawing.Point(356, 175)
        Me.C_Moneda1Pool.Name = "C_Moneda1Pool"
        Me.C_Moneda1Pool.Size = New System.Drawing.Size(123, 21)
        Me.C_Moneda1Pool.TabIndex = 538
        Me.C_Moneda1Pool.Text = "C_Moneda1Pool"
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
        'C_ExchangePool
        '
        Me.C_ExchangePool.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_ExchangePool.FormattingEnabled = True
        Me.C_ExchangePool.Location = New System.Drawing.Point(510, 87)
        Me.C_ExchangePool.Name = "C_ExchangePool"
        Me.C_ExchangePool.Size = New System.Drawing.Size(123, 21)
        Me.C_ExchangePool.TabIndex = 535
        Me.C_ExchangePool.Text = "C_ExchangePool"
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
        Me.B_Cerrar.Location = New System.Drawing.Point(688, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 561
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'F_PoolLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_PoolLiquidez)
        Me.Controls.Add(Me.T_MaxPool)
        Me.Controls.Add(Me.T_MinPool)
        Me.Controls.Add(Me.T_ValorMoneda2ResultantePool)
        Me.Controls.Add(Me.T_ValorMoneda1ResultantePool)
        Me.Controls.Add(Me.T_GasPool)
        Me.Controls.Add(Me.T_ComisionPool)
        Me.Controls.Add(Me.T_ValorMoneda2Pool)
        Me.Controls.Add(Me.T_ValorMoneda1Pool)
        Me.Controls.Add(Me.rT_NotaPool)
        Me.Controls.Add(Me.T_HoraPool)
        Me.Controls.Add(Me.T_FechaPool)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.C_BilleteraPool)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_GrabarPool)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.C_Moneda2Pool)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C_Moneda1Pool)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.C_ExchangePool)
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
    Friend WithEvents T_MaxPool As TextBox
    Friend WithEvents T_MinPool As TextBox
    Friend WithEvents T_ValorMoneda2ResultantePool As TextBox
    Friend WithEvents T_ValorMoneda1ResultantePool As TextBox
    Friend WithEvents T_GasPool As TextBox
    Friend WithEvents T_ComisionPool As TextBox
    Friend WithEvents T_ValorMoneda2Pool As TextBox
    Friend WithEvents T_ValorMoneda1Pool As TextBox
    Friend WithEvents rT_NotaPool As RichTextBox
    Friend WithEvents T_HoraPool As TextBox
    Friend WithEvents T_FechaPool As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents C_BilleteraPool As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents B_GrabarPool As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents C_Moneda2Pool As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents C_Moneda1Pool As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents C_ExchangePool As ComboBox
    Friend WithEvents CalFechaPool As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents B_Cerrar As Button
End Class
