<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ValorMonedas
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
        Me.T_ValorValorMonedas = New System.Windows.Forms.TextBox()
        Me.T_FechaValorMonedas = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.L_FechaValorMonedas = New System.Windows.Forms.ListBox()
        Me.C_MonedasValorMonedas = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'T_ValorValorMonedas
        '
        Me.T_ValorValorMonedas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ValorValorMonedas.Location = New System.Drawing.Point(491, 126)
        Me.T_ValorValorMonedas.MaxLength = 4
        Me.T_ValorValorMonedas.Name = "T_ValorValorMonedas"
        Me.T_ValorValorMonedas.Size = New System.Drawing.Size(79, 20)
        Me.T_ValorValorMonedas.TabIndex = 575
        Me.T_ValorValorMonedas.Text = "T_ValorValorMonedas"
        Me.T_ValorValorMonedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'T_FechaValorMonedas
        '
        Me.T_FechaValorMonedas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_FechaValorMonedas.Location = New System.Drawing.Point(377, 126)
        Me.T_FechaValorMonedas.MaxLength = 6
        Me.T_FechaValorMonedas.Name = "T_FechaValorMonedas"
        Me.T_FechaValorMonedas.Size = New System.Drawing.Size(80, 20)
        Me.T_FechaValorMonedas.TabIndex = 574
        Me.T_FechaValorMonedas.Text = "T_FechaValorMonedas"
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Blue
        Me.Label53.Location = New System.Drawing.Point(488, 110)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(59, 13)
        Me.Label53.TabIndex = 577
        Me.Label53.Text = "Valor"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Blue
        Me.Label54.Location = New System.Drawing.Point(377, 110)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(80, 13)
        Me.Label54.TabIndex = 576
        Me.Label54.Text = "Fecha"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L_FechaValorMonedas
        '
        Me.L_FechaValorMonedas.FormattingEnabled = True
        Me.L_FechaValorMonedas.Location = New System.Drawing.Point(25, 110)
        Me.L_FechaValorMonedas.Name = "L_FechaValorMonedas"
        Me.L_FechaValorMonedas.Size = New System.Drawing.Size(316, 368)
        Me.L_FechaValorMonedas.TabIndex = 573
        '
        'C_MonedasValorMonedas
        '
        Me.C_MonedasValorMonedas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_MonedasValorMonedas.FormattingEnabled = True
        Me.C_MonedasValorMonedas.Location = New System.Drawing.Point(25, 74)
        Me.C_MonedasValorMonedas.Name = "C_MonedasValorMonedas"
        Me.C_MonedasValorMonedas.Size = New System.Drawing.Size(212, 21)
        Me.C_MonedasValorMonedas.TabIndex = 572
        Me.C_MonedasValorMonedas.Text = "C_MonedasValorMonedas"
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Blue
        Me.Label52.Location = New System.Drawing.Point(25, 58)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(126, 13)
        Me.Label52.TabIndex = 571
        Me.Label52.Text = "Moneda Origen"
        '
        'F_ValorMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 507)
        Me.Controls.Add(Me.T_ValorValorMonedas)
        Me.Controls.Add(Me.T_FechaValorMonedas)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.L_FechaValorMonedas)
        Me.Controls.Add(Me.C_MonedasValorMonedas)
        Me.Controls.Add(Me.Label52)
        Me.Name = "F_ValorMonedas"
        Me.Text = "F_ValorMonedas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents T_ValorValorMonedas As TextBox
    Friend WithEvents T_FechaValorMonedas As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents L_FechaValorMonedas As ListBox
    Friend WithEvents C_MonedasValorMonedas As ComboBox
    Friend WithEvents Label52 As Label
End Class
