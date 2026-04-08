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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Transacciones))
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.L_Billeteras = New System.Windows.Forms.ListBox()
        Me.Label_Billetera = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.L_TotalRegistros = New System.Windows.Forms.Label()
        Me.B_Actualizar = New System.Windows.Forms.Button()
        Me.T_Comentario = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.B_Grabar = New System.Windows.Forms.Button()
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
        'L_Billeteras
        '
        Me.L_Billeteras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.L_Billeteras.FormattingEnabled = True
        Me.L_Billeteras.ItemHeight = 15
        Me.L_Billeteras.Location = New System.Drawing.Point(12, 64)
        Me.L_Billeteras.Name = "L_Billeteras"
        Me.L_Billeteras.Size = New System.Drawing.Size(180, 334)
        Me.L_Billeteras.Sorted = True
        Me.L_Billeteras.TabIndex = 2
        '
        'Label_Billetera
        '
        Me.Label_Billetera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Billetera.ForeColor = System.Drawing.Color.Blue
        Me.Label_Billetera.Location = New System.Drawing.Point(12, 48)
        Me.Label_Billetera.Name = "Label_Billetera"
        Me.Label_Billetera.Size = New System.Drawing.Size(180, 13)
        Me.Label_Billetera.TabIndex = 6
        Me.Label_Billetera.Text = "Billetera"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(210, 64)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(958, 334)
        Me.DGV.TabIndex = 4
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(207, 505)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(863, 16)
        Me.L_Mensaje.TabIndex = 1
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'L_TotalRegistros
        '
        Me.L_TotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TotalRegistros.ForeColor = System.Drawing.Color.Gray
        Me.L_TotalRegistros.Location = New System.Drawing.Point(820, 495)
        Me.L_TotalRegistros.Name = "L_TotalRegistros"
        Me.L_TotalRegistros.Size = New System.Drawing.Size(250, 16)
        Me.L_TotalRegistros.TabIndex = 0
        Me.L_TotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'B_Actualizar
        '
        Me.B_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Actualizar.Location = New System.Drawing.Point(210, 12)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(99, 23)
        Me.B_Actualizar.TabIndex = 654
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = False
        '
        'T_Comentario
        '
        Me.T_Comentario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Comentario.Location = New System.Drawing.Point(210, 434)
        Me.T_Comentario.MaxLength = 6
        Me.T_Comentario.Name = "T_Comentario"
        Me.T_Comentario.Size = New System.Drawing.Size(958, 20)
        Me.T_Comentario.TabIndex = 656
        Me.T_Comentario.Text = "T_Comentario"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Blue
        Me.Label43.Location = New System.Drawing.Point(210, 418)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(126, 13)
        Me.Label43.TabIndex = 655
        Me.Label43.Text = "Comentarios"
        '
        'B_Grabar
        '
        Me.B_Grabar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Grabar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Grabar.Location = New System.Drawing.Point(1069, 460)
        Me.B_Grabar.Name = "B_Grabar"
        Me.B_Grabar.Size = New System.Drawing.Size(99, 23)
        Me.B_Grabar.TabIndex = 657
        Me.B_Grabar.Text = "Grabar"
        Me.B_Grabar.UseVisualStyleBackColor = False
        '
        'F_Transacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(1180, 540)
        Me.Controls.Add(Me.B_Grabar)
        Me.Controls.Add(Me.T_Comentario)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Controls.Add(Me.L_TotalRegistros)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.L_Billeteras)
        Me.Controls.Add(Me.Label_Billetera)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Transacciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Transacciones"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Cerrar As Button
    Friend WithEvents L_Billeteras As ListBox
    Friend WithEvents Label_Billetera As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents L_Mensaje As Label
    Friend WithEvents L_TotalRegistros As Label
    Friend WithEvents B_Actualizar As Button
    Friend WithEvents T_Comentario As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents B_Grabar As Button
End Class
