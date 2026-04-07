'
'
'
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Transacciones
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.L_Billeteras = New System.Windows.Forms.ListBox()
        Me.Label_Billetera = New System.Windows.Forms.Label()
        Me.C_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label_Tipo = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.L_TotalRegistros = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 1
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'Label_Billetera
        '
        Me.Label_Billetera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Billetera.ForeColor = System.Drawing.Color.Blue
        Me.Label_Billetera.Location = New System.Drawing.Point(12, 48)
        Me.Label_Billetera.Name = "Label_Billetera"
        Me.Label_Billetera.Size = New System.Drawing.Size(180, 13)
        Me.Label_Billetera.Text = "Billetera"
        '
        'L_Billeteras
        '
        Me.L_Billeteras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.L_Billeteras.FormattingEnabled = True
        Me.L_Billeteras.ItemHeight = 15
        Me.L_Billeteras.Location = New System.Drawing.Point(12, 64)
        Me.L_Billeteras.Name = "L_Billeteras"
        Me.L_Billeteras.Size = New System.Drawing.Size(180, 424)
        Me.L_Billeteras.Sorted = True
        Me.L_Billeteras.TabIndex = 2
        '
        'Label_Tipo
        '
        Me.Label_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tipo.ForeColor = System.Drawing.Color.Blue
        Me.Label_Tipo.Location = New System.Drawing.Point(210, 48)
        Me.Label_Tipo.Name = "Label_Tipo"
        Me.Label_Tipo.Size = New System.Drawing.Size(80, 13)
        Me.Label_Tipo.Text = "Tipo"
        '
        'C_Tipo
        '
        Me.C_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_Tipo.FormattingEnabled = True
        Me.C_Tipo.Location = New System.Drawing.Point(210, 64)
        Me.C_Tipo.Name = "C_Tipo"
        Me.C_Tipo.Size = New System.Drawing.Size(150, 21)
        Me.C_Tipo.TabIndex = 3
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(210, 100)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(860, 388)
        Me.DGV.TabIndex = 4
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(210, 495)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(600, 16)
        Me.L_Mensaje.Text = ""
        '
        'L_TotalRegistros
        '
        Me.L_TotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TotalRegistros.ForeColor = System.Drawing.Color.Gray
        Me.L_TotalRegistros.Location = New System.Drawing.Point(820, 495)
        Me.L_TotalRegistros.Name = "L_TotalRegistros"
        Me.L_TotalRegistros.Size = New System.Drawing.Size(250, 16)
        Me.L_TotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.L_TotalRegistros.Text = ""
        '
        'F_Transacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(1090, 520)
        Me.Controls.Add(Me.L_TotalRegistros)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.C_Tipo)
        Me.Controls.Add(Me.Label_Tipo)
        Me.Controls.Add(Me.L_Billeteras)
        Me.Controls.Add(Me.Label_Billetera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Location = New System.Drawing.Point(150, 80)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Transacciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transacciones"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents B_Cerrar As Button
    Friend WithEvents L_Billeteras As ListBox
    Friend WithEvents Label_Billetera As Label
    Friend WithEvents C_Tipo As ComboBox
    Friend WithEvents Label_Tipo As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents L_TotalRegistros As Label
End Class
