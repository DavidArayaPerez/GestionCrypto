<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Billetera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.B_Nuevo = New System.Windows.Forms.Button()
        Me.L_Billeteras = New System.Windows.Forms.ListBox()
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
        Me.B_ConsultaSaldo = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.C_FechaHora = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.L_Billeteras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.L_Billeteras.FormattingEnabled = True
        Me.L_Billeteras.ItemHeight = 15
        Me.L_Billeteras.Location = New System.Drawing.Point(15, 59)
        Me.L_Billeteras.Name = "L_Billeteras"
        Me.L_Billeteras.Size = New System.Drawing.Size(348, 559)
        Me.L_Billeteras.Sorted = True
        Me.L_Billeteras.TabIndex = 573
        '
        'B_Grabar
        '
        Me.B_Grabar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Grabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Grabar.Location = New System.Drawing.Point(390, 12)
        Me.B_Grabar.Name = "B_Grabar"
        Me.B_Grabar.Size = New System.Drawing.Size(99, 23)
        Me.B_Grabar.TabIndex = 571
        Me.B_Grabar.Text = "Grabar"
        Me.B_Grabar.UseVisualStyleBackColor = False
        '
        'T_CodigoBilletera
        '
        Me.T_CodigoBilletera.BackColor = System.Drawing.Color.White
        Me.T_CodigoBilletera.Location = New System.Drawing.Point(584, 75)
        Me.T_CodigoBilletera.MaxLength = 0
        Me.T_CodigoBilletera.Multiline = True
        Me.T_CodigoBilletera.Name = "T_CodigoBilletera"
        Me.T_CodigoBilletera.Size = New System.Drawing.Size(145, 45)
        Me.T_CodigoBilletera.TabIndex = 570
        Me.T_CodigoBilletera.Text = "T_CodigoBilletera"
        '
        'T_NombreBilletera
        '
        Me.T_NombreBilletera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_NombreBilletera.Location = New System.Drawing.Point(387, 75)
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
        Me.rT_Nota.Location = New System.Drawing.Point(735, 75)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(174, 117)
        Me.rT_Nota.TabIndex = 566
        Me.rT_Nota.Text = "rT_Nota"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(581, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 13)
        Me.Label17.TabIndex = 569
        Me.Label17.Text = "Codigo"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(387, 59)
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
        Me.Label2.Location = New System.Drawing.Point(387, 128)
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
        Me.L_Fila.Location = New System.Drawing.Point(424, 128)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(170, 13)
        Me.L_Fila.TabIndex = 649
        Me.L_Fila.Text = "L_Fila"
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(384, 595)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(525, 42)
        Me.L_Mensaje.TabIndex = 651
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'B_Copiar
        '
        Me.B_Copiar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Copiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Copiar.Location = New System.Drawing.Point(630, 128)
        Me.B_Copiar.Name = "B_Copiar"
        Me.B_Copiar.Size = New System.Drawing.Size(99, 23)
        Me.B_Copiar.TabIndex = 652
        Me.B_Copiar.Text = "Copiar"
        Me.B_Copiar.UseVisualStyleBackColor = False
        '
        'B_ConsultaSaldo
        '
        Me.B_ConsultaSaldo.BackColor = System.Drawing.SystemColors.Control
        Me.B_ConsultaSaldo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_ConsultaSaldo.Location = New System.Drawing.Point(630, 169)
        Me.B_ConsultaSaldo.Name = "B_ConsultaSaldo"
        Me.B_ConsultaSaldo.Size = New System.Drawing.Size(99, 23)
        Me.B_ConsultaSaldo.TabIndex = 653
        Me.B_ConsultaSaldo.Text = "Consulta Saldo"
        Me.B_ConsultaSaldo.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(387, 198)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(522, 383)
        Me.DGV.TabIndex = 654
        '
        'C_FechaHora
        '
        Me.C_FechaHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.C_FechaHora.FormattingEnabled = True
        Me.C_FechaHora.Location = New System.Drawing.Point(475, 171)
        Me.C_FechaHora.Name = "C_FechaHora"
        Me.C_FechaHora.Size = New System.Drawing.Size(123, 21)
        Me.C_FechaHora.TabIndex = 655
        Me.C_FechaHora.Text = "C_FechaHora"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(390, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 656
        Me.Label14.Text = "Fecha/Hora"
        '
        'F_Billetera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(923, 646)
        Me.Controls.Add(Me.C_FechaHora)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.B_ConsultaSaldo)
        Me.Controls.Add(Me.B_Copiar)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.B_Nuevo)
        Me.Controls.Add(Me.L_Billeteras)
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
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Nuevo As Button
    Friend WithEvents L_Billeteras As ListBox
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
    Friend WithEvents B_ConsultaSaldo As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents C_FechaHora As ComboBox
    Friend WithEvents Label14 As Label
End Class
