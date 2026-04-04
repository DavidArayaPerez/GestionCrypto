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
        Me.B_Grabar = New System.Windows.Forms.Button()
        Me.T_Nom = New System.Windows.Forms.TextBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.T_Link = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B_Nuevo = New System.Windows.Forms.Button()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Fila = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'L_Exchange
        '
        Me.L_Exchange.FormattingEnabled = True
        Me.L_Exchange.Location = New System.Drawing.Point(12, 49)
        Me.L_Exchange.Name = "L_Exchange"
        Me.L_Exchange.Size = New System.Drawing.Size(316, 433)
        Me.L_Exchange.TabIndex = 570
        '
        'B_Grabar
        '
        Me.B_Grabar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Grabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Grabar.Location = New System.Drawing.Point(353, 9)
        Me.B_Grabar.Name = "B_Grabar"
        Me.B_Grabar.Size = New System.Drawing.Size(99, 23)
        Me.B_Grabar.TabIndex = 569
        Me.B_Grabar.Text = "Grabar"
        Me.B_Grabar.UseVisualStyleBackColor = False
        '
        'T_Nom
        '
        Me.T_Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Nom.Location = New System.Drawing.Point(353, 70)
        Me.T_Nom.MaxLength = 6
        Me.T_Nom.Name = "T_Nom"
        Me.T_Nom.Size = New System.Drawing.Size(191, 20)
        Me.T_Nom.TabIndex = 568
        Me.T_Nom.Text = "T_Nom"
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.White
        Me.rT_Nota.Location = New System.Drawing.Point(357, 145)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(441, 302)
        Me.rT_Nota.TabIndex = 566
        Me.rT_Nota.Text = "rT_Nota"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Blue
        Me.Label43.Location = New System.Drawing.Point(353, 54)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(126, 13)
        Me.Label43.TabIndex = 567
        Me.Label43.Text = "Nombre Exchange"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 9)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 571
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'T_Link
        '
        Me.T_Link.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Link.Location = New System.Drawing.Point(558, 70)
        Me.T_Link.MaxLength = 60
        Me.T_Link.Multiline = True
        Me.T_Link.Name = "T_Link"
        Me.T_Link.Size = New System.Drawing.Size(236, 49)
        Me.T_Link.TabIndex = 668
        Me.T_Link.Text = "T_Link"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Magenta
        Me.Label3.Location = New System.Drawing.Point(558, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 667
        Me.Label3.Text = "Link Exchange"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'B_Nuevo
        '
        Me.B_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.B_Nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Nuevo.Location = New System.Drawing.Point(229, 9)
        Me.B_Nuevo.Name = "B_Nuevo"
        Me.B_Nuevo.Size = New System.Drawing.Size(99, 23)
        Me.B_Nuevo.TabIndex = 669
        Me.B_Nuevo.Text = "Nuevo"
        Me.B_Nuevo.UseVisualStyleBackColor = False
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(353, 466)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(445, 16)
        Me.L_Mensaje.TabIndex = 670
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(353, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 672
        Me.Label1.Text = "Fila"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_Fila
        '
        Me.L_Fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila.ForeColor = System.Drawing.Color.Black
        Me.L_Fila.Location = New System.Drawing.Point(382, 106)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(162, 13)
        Me.L_Fila.TabIndex = 671
        Me.L_Fila.Text = "L_Fila"
        '
        'F_Exchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 518)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.B_Nuevo)
        Me.Controls.Add(Me.T_Link)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Exchange)
        Me.Controls.Add(Me.B_Grabar)
        Me.Controls.Add(Me.T_Nom)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.Label43)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.Name = "F_Exchange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Exchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_Exchange As ListBox
    Friend WithEvents B_Grabar As Button
    Friend WithEvents T_Nom As TextBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents T_Link As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents B_Nuevo As Button
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_Fila As Label
End Class
