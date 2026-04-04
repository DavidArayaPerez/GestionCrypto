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
        Me.B_Nuevo = New System.Windows.Forms.Button()
        Me.L_Billeteras = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Grabar = New System.Windows.Forms.Button()
        Me.T_CodigoBilletera = New System.Windows.Forms.TextBox()
        Me.T_NombreBilletera = New System.Windows.Forms.TextBox()
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_Fila = New System.Windows.Forms.Label()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.B_Copiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_Nuevo
        '
        Me.B_Nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.B_Nuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Nuevo.Location = New System.Drawing.Point(232, 12)
        Me.B_Nuevo.Name = "B_Nuevo"
        Me.B_Nuevo.Size = New System.Drawing.Size(99, 23)
        Me.B_Nuevo.TabIndex = 574
        Me.B_Nuevo.Text = "Nuevo"
        Me.B_Nuevo.UseVisualStyleBackColor = False
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
        Me.Label1.Location = New System.Drawing.Point(363, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 25)
        Me.Label1.TabIndex = 572
        Me.Label1.Text = "No escriba tu CLAVE semilla NO LO HAGAS"
        '
        'B_Grabar
        '
        Me.B_Grabar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Grabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Grabar.Location = New System.Drawing.Point(366, 12)
        Me.B_Grabar.Name = "B_Grabar"
        Me.B_Grabar.Size = New System.Drawing.Size(99, 23)
        Me.B_Grabar.TabIndex = 571
        Me.B_Grabar.Text = "Grabar"
        Me.B_Grabar.UseVisualStyleBackColor = False
        '
        'T_CodigoBilletera
        '
        Me.T_CodigoBilletera.BackColor = System.Drawing.Color.White
        Me.T_CodigoBilletera.Location = New System.Drawing.Point(585, 75)
        Me.T_CodigoBilletera.MaxLength = 0
        Me.T_CodigoBilletera.Multiline = True
        Me.T_CodigoBilletera.Name = "T_CodigoBilletera"
        Me.T_CodigoBilletera.Size = New System.Drawing.Size(217, 45)
        Me.T_CodigoBilletera.TabIndex = 570
        Me.T_CodigoBilletera.Text = "T_CodigoBilletera"
        '
        'T_NombreBilletera
        '
        Me.T_NombreBilletera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_NombreBilletera.Location = New System.Drawing.Point(363, 75)
        Me.T_NombreBilletera.MaxLength = 60
        Me.T_NombreBilletera.Multiline = True
        Me.T_NombreBilletera.Name = "T_NombreBilletera"
        Me.T_NombreBilletera.Size = New System.Drawing.Size(191, 45)
        Me.T_NombreBilletera.TabIndex = 568
        Me.T_NombreBilletera.Text = "T_NombreBilletera"
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rT_Nota.Location = New System.Drawing.Point(363, 181)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(457, 267)
        Me.rT_Nota.TabIndex = 566
        Me.rT_Nota.Text = "rT_Nota"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(582, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 13)
        Me.Label17.TabIndex = 569
        Me.Label17.Text = "Codigo"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(363, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 13)
        Me.Label19.TabIndex = 567
        Me.Label19.Text = "Nombre"
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(15, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 575
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(363, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 650
        Me.Label2.Text = "Fila"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_Fila
        '
        Me.L_Fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila.ForeColor = System.Drawing.Color.Black
        Me.L_Fila.Location = New System.Drawing.Point(400, 128)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(170, 13)
        Me.L_Fila.TabIndex = 649
        Me.L_Fila.Text = "L_Fila"
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(363, 462)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(457, 16)
        Me.L_Mensaje.TabIndex = 651
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'B_Copiar
        '
        Me.B_Copiar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Copiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Copiar.Location = New System.Drawing.Point(703, 46)
        Me.B_Copiar.Name = "B_Copiar"
        Me.B_Copiar.Size = New System.Drawing.Size(99, 23)
        Me.B_Copiar.TabIndex = 652
        Me.B_Copiar.Text = "Copiar"
        Me.B_Copiar.UseVisualStyleBackColor = False
        '
        'F_Billetera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 505)
        Me.Controls.Add(Me.B_Copiar)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.B_Nuevo)
        Me.Controls.Add(Me.L_Billeteras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Grabar)
        Me.Controls.Add(Me.T_CodigoBilletera)
        Me.Controls.Add(Me.T_NombreBilletera)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Billetera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Billetera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Nuevo As Button
    Friend WithEvents L_Billeteras As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents B_Grabar As Button
    Friend WithEvents T_CodigoBilletera As TextBox
    Friend WithEvents T_NombreBilletera As TextBox
    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents L_Fila As Label
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents B_Copiar As Button
End Class
