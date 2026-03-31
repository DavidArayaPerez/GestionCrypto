<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Dolar
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
        Me.L_Dolar = New System.Windows.Forms.ListBox()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_Dolar
        '
        Me.L_Dolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Dolar.FormattingEnabled = True
        Me.L_Dolar.ItemHeight = 15
        Me.L_Dolar.Location = New System.Drawing.Point(12, 12)
        Me.L_Dolar.Name = "L_Dolar"
        Me.L_Dolar.Size = New System.Drawing.Size(142, 544)
        Me.L_Dolar.TabIndex = 627
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(26, 573)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 662
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'F_Dolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(182, 608)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.L_Dolar)
        Me.MaximizeBox = False
        Me.Name = "F_Dolar"
        Me.Text = "Dolar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L_Dolar As ListBox
    Friend WithEvents B_Cerrar As Button
End Class
