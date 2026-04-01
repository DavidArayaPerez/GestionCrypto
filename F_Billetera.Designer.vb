<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Billetera
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
        Me.B_NuevoBilletera = New System.Windows.Forms.Button()
        Me.L_Billeteras = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_GrabarBilletera = New System.Windows.Forms.Button()
        Me.T_CodigoBilletera = New System.Windows.Forms.TextBox()
        Me.T_NombreBilletera = New System.Windows.Forms.TextBox()
        Me.rT_NotaBilletera = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_NuevoBilletera
        '
        Me.B_NuevoBilletera.BackColor = System.Drawing.SystemColors.Control
        Me.B_NuevoBilletera.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_NuevoBilletera.Location = New System.Drawing.Point(117, 12)
        Me.B_NuevoBilletera.Name = "B_NuevoBilletera"
        Me.B_NuevoBilletera.Size = New System.Drawing.Size(99, 23)
        Me.B_NuevoBilletera.TabIndex = 574
        Me.B_NuevoBilletera.Text = "Nuevo"
        Me.B_NuevoBilletera.UseVisualStyleBackColor = False
        '
        'L_Billeteras
        '
        Me.L_Billeteras.FormattingEnabled = True
        Me.L_Billeteras.Location = New System.Drawing.Point(15, 84)
        Me.L_Billeteras.Name = "L_Billeteras"
        Me.L_Billeteras.Size = New System.Drawing.Size(316, 394)
        Me.L_Billeteras.TabIndex = 573
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(363, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 25)
        Me.Label1.TabIndex = 572
        Me.Label1.Text = "No escriba tu CLAVE semilla NO LO HAGAS"
        '
        'B_GrabarBilletera
        '
        Me.B_GrabarBilletera.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarBilletera.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarBilletera.Location = New System.Drawing.Point(12, 12)
        Me.B_GrabarBilletera.Name = "B_GrabarBilletera"
        Me.B_GrabarBilletera.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarBilletera.TabIndex = 571
        Me.B_GrabarBilletera.Text = "Grabar"
        Me.B_GrabarBilletera.UseVisualStyleBackColor = False
        '
        'T_CodigoBilletera
        '
        Me.T_CodigoBilletera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_CodigoBilletera.Location = New System.Drawing.Point(585, 75)
        Me.T_CodigoBilletera.MaxLength = 6
        Me.T_CodigoBilletera.Name = "T_CodigoBilletera"
        Me.T_CodigoBilletera.Size = New System.Drawing.Size(217, 20)
        Me.T_CodigoBilletera.TabIndex = 570
        Me.T_CodigoBilletera.Text = "T_CodigoBilletera"
        '
        'T_NombreBilletera
        '
        Me.T_NombreBilletera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_NombreBilletera.Location = New System.Drawing.Point(363, 75)
        Me.T_NombreBilletera.MaxLength = 6
        Me.T_NombreBilletera.Name = "T_NombreBilletera"
        Me.T_NombreBilletera.Size = New System.Drawing.Size(191, 20)
        Me.T_NombreBilletera.TabIndex = 568
        Me.T_NombreBilletera.Text = "T_NombreBilletera"
        '
        'rT_NotaBilletera
        '
        Me.rT_NotaBilletera.AcceptsTab = True
        Me.rT_NotaBilletera.AutoWordSelection = True
        Me.rT_NotaBilletera.BackColor = System.Drawing.Color.White
        Me.rT_NotaBilletera.Location = New System.Drawing.Point(363, 138)
        Me.rT_NotaBilletera.Name = "rT_NotaBilletera"
        Me.rT_NotaBilletera.ReadOnly = True
        Me.rT_NotaBilletera.Size = New System.Drawing.Size(457, 340)
        Me.rT_NotaBilletera.TabIndex = 566
        Me.rT_NotaBilletera.Text = "rT_NotaBilletera"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(571, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 13)
        Me.Label17.TabIndex = 569
        Me.Label17.Text = "Codigo"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(360, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 13)
        Me.Label19.TabIndex = 567
        Me.Label19.Text = "Nombre"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(721, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 575
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'F_Billetera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 505)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.B_NuevoBilletera)
        Me.Controls.Add(Me.L_Billeteras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_GrabarBilletera)
        Me.Controls.Add(Me.T_CodigoBilletera)
        Me.Controls.Add(Me.T_NombreBilletera)
        Me.Controls.Add(Me.rT_NotaBilletera)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Name = "F_Billetera"
        Me.Text = "F_Billetera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_NuevoBilletera As Button
    Friend WithEvents L_Billeteras As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents B_GrabarBilletera As Button
    Friend WithEvents T_CodigoBilletera As TextBox
    Friend WithEvents T_NombreBilletera As TextBox
    Friend WithEvents rT_NotaBilletera As RichTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents B_Cerrar As Button
End Class
