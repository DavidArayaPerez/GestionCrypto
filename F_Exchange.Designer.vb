<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Exchange
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
        Me.L_Exchange = New System.Windows.Forms.ListBox()
        Me.B_GrabarExchange = New System.Windows.Forms.Button()
        Me.T_NomExchange = New System.Windows.Forms.TextBox()
        Me.rT_NotaExchange = New System.Windows.Forms.RichTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Exchange
        '
        Me.L_Exchange.FormattingEnabled = True
        Me.L_Exchange.Location = New System.Drawing.Point(27, 70)
        Me.L_Exchange.Name = "L_Exchange"
        Me.L_Exchange.Size = New System.Drawing.Size(316, 433)
        Me.L_Exchange.TabIndex = 570
        '
        'B_GrabarExchange
        '
        Me.B_GrabarExchange.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarExchange.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarExchange.Location = New System.Drawing.Point(375, 12)
        Me.B_GrabarExchange.Name = "B_GrabarExchange"
        Me.B_GrabarExchange.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarExchange.TabIndex = 569
        Me.B_GrabarExchange.Text = "Grabar"
        Me.B_GrabarExchange.UseVisualStyleBackColor = False
        '
        'T_NomExchange
        '
        Me.T_NomExchange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_NomExchange.Location = New System.Drawing.Point(375, 83)
        Me.T_NomExchange.MaxLength = 6
        Me.T_NomExchange.Name = "T_NomExchange"
        Me.T_NomExchange.Size = New System.Drawing.Size(191, 20)
        Me.T_NomExchange.TabIndex = 568
        Me.T_NomExchange.Text = "T_NomExchange"
        '
        'rT_NotaExchange
        '
        Me.rT_NotaExchange.AcceptsTab = True
        Me.rT_NotaExchange.AutoWordSelection = True
        Me.rT_NotaExchange.BackColor = System.Drawing.Color.White
        Me.rT_NotaExchange.Location = New System.Drawing.Point(376, 125)
        Me.rT_NotaExchange.Name = "rT_NotaExchange"
        Me.rT_NotaExchange.ReadOnly = True
        Me.rT_NotaExchange.Size = New System.Drawing.Size(457, 378)
        Me.rT_NotaExchange.TabIndex = 566
        Me.rT_NotaExchange.Text = "rT_NotaExchange"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Blue
        Me.Label43.Location = New System.Drawing.Point(372, 67)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(126, 13)
        Me.Label43.TabIndex = 567
        Me.Label43.Text = "Nombre Exchange"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(733, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 571
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'F_Exchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 518)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Exchange)
        Me.Controls.Add(Me.B_GrabarExchange)
        Me.Controls.Add(Me.T_NomExchange)
        Me.Controls.Add(Me.rT_NotaExchange)
        Me.Controls.Add(Me.Label43)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.Name = "F_Exchange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "F_Exchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Exchange As ListBox
    Friend WithEvents B_GrabarExchange As Button
    Friend WithEvents T_NomExchange As TextBox
    Friend WithEvents rT_NotaExchange As RichTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents B_Cerrar As Button
End Class
