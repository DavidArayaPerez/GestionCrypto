<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Red
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
        Me.rT_Nota = New System.Windows.Forms.RichTextBox()
        Me.CB_EVM_Red = New System.Windows.Forms.CheckBox()
        Me.CB_Activo_Red = New System.Windows.Forms.CheckBox()
        Me.T_URLrpc_Red = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.T_URLexplorador_Red = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.L_ID = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.L_Red = New System.Windows.Forms.ListBox()
        Me.B_GrabarRed = New System.Windows.Forms.Button()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.L_Fila = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_ChainID = New System.Windows.Forms.Label()
        Me.L_NomOficial = New System.Windows.Forms.Label()
        Me.L_NomCorto = New System.Windows.Forms.Label()
        Me.L_APIcg = New System.Windows.Forms.Label()
        Me.L_TipoCapa = New System.Windows.Forms.Label()
        Me.L_L1padre = New System.Windows.Forms.Label()
        Me.L_TipoRollup = New System.Windows.Forms.Label()
        Me.L_MecanismoConsenso = New System.Windows.Forms.Label()
        Me.L_TokenNativo = New System.Windows.Forms.Label()
        Me.L_Mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rT_Nota
        '
        Me.rT_Nota.AcceptsTab = True
        Me.rT_Nota.AutoWordSelection = True
        Me.rT_Nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rT_Nota.Location = New System.Drawing.Point(636, 58)
        Me.rT_Nota.Name = "rT_Nota"
        Me.rT_Nota.ReadOnly = True
        Me.rT_Nota.Size = New System.Drawing.Size(231, 236)
        Me.rT_Nota.TabIndex = 660
        Me.rT_Nota.Text = "rT_Nota"
        '
        'CB_EVM_Red
        '
        Me.CB_EVM_Red.AutoSize = True
        Me.CB_EVM_Red.Location = New System.Drawing.Point(460, 364)
        Me.CB_EVM_Red.Name = "CB_EVM_Red"
        Me.CB_EVM_Red.Size = New System.Drawing.Size(125, 17)
        Me.CB_EVM_Red.TabIndex = 657
        Me.CB_EVM_Red.Text = "Compatible con EVM"
        Me.CB_EVM_Red.UseVisualStyleBackColor = True
        '
        'CB_Activo_Red
        '
        Me.CB_Activo_Red.AutoSize = True
        Me.CB_Activo_Red.Location = New System.Drawing.Point(460, 396)
        Me.CB_Activo_Red.Name = "CB_Activo_Red"
        Me.CB_Activo_Red.Size = New System.Drawing.Size(56, 17)
        Me.CB_Activo_Red.TabIndex = 656
        Me.CB_Activo_Red.Text = "Activo"
        Me.CB_Activo_Red.UseVisualStyleBackColor = True
        '
        'T_URLrpc_Red
        '
        Me.T_URLrpc_Red.BackColor = System.Drawing.Color.White
        Me.T_URLrpc_Red.Location = New System.Drawing.Point(460, 329)
        Me.T_URLrpc_Red.MaxLength = 6
        Me.T_URLrpc_Red.Name = "T_URLrpc_Red"
        Me.T_URLrpc_Red.ReadOnly = True
        Me.T_URLrpc_Red.Size = New System.Drawing.Size(324, 20)
        Me.T_URLrpc_Red.TabIndex = 655
        Me.T_URLrpc_Red.Text = "T_URLrpc_Red"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Magenta
        Me.Label72.Location = New System.Drawing.Point(400, 333)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(54, 13)
        Me.Label72.TabIndex = 654
        Me.Label72.Text = "URL RPC"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_URLexplorador_Red
        '
        Me.T_URLexplorador_Red.BackColor = System.Drawing.Color.White
        Me.T_URLexplorador_Red.Location = New System.Drawing.Point(460, 303)
        Me.T_URLexplorador_Red.MaxLength = 6
        Me.T_URLexplorador_Red.Name = "T_URLexplorador_Red"
        Me.T_URLexplorador_Red.ReadOnly = True
        Me.T_URLexplorador_Red.Size = New System.Drawing.Size(324, 20)
        Me.T_URLexplorador_Red.TabIndex = 651
        Me.T_URLexplorador_Red.Text = "T_URLexplorador_Red"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Magenta
        Me.Label65.Location = New System.Drawing.Point(372, 307)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(82, 13)
        Me.Label65.TabIndex = 650
        Me.Label65.Text = "URL Explotador"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Blue
        Me.Label70.Location = New System.Drawing.Point(384, 281)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(70, 13)
        Me.Label70.TabIndex = 642
        Me.Label70.Text = "Token nativo"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Blue
        Me.Label71.Location = New System.Drawing.Point(343, 252)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(111, 13)
        Me.Label71.TabIndex = 641
        Me.Label71.Text = "Mecanismo Consenso"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Blue
        Me.Label62.Location = New System.Drawing.Point(393, 226)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(61, 13)
        Me.Label62.TabIndex = 639
        Me.Label62.Text = "Tipo Rollup"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Blue
        Me.Label63.Location = New System.Drawing.Point(404, 196)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(50, 13)
        Me.Label63.TabIndex = 637
        Me.Label63.Text = "L1 Padre"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Blue
        Me.Label64.Location = New System.Drawing.Point(398, 170)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(56, 13)
        Me.Label64.TabIndex = 636
        Me.Label64.Text = "Tipo Capa"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Blue
        Me.Label58.Location = New System.Drawing.Point(374, 144)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(80, 13)
        Me.Label58.TabIndex = 634
        Me.Label58.Text = "API CoinGecko"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Blue
        Me.Label60.Location = New System.Drawing.Point(382, 118)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(72, 13)
        Me.Label60.TabIndex = 632
        Me.Label60.Text = "Nombre Corto"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Blue
        Me.Label57.Location = New System.Drawing.Point(378, 88)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(76, 13)
        Me.Label57.TabIndex = 630
        Me.Label57.Text = "Nombre Oficial"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_ID
        '
        Me.L_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ID.ForeColor = System.Drawing.Color.Black
        Me.L_ID.Location = New System.Drawing.Point(460, 429)
        Me.L_ID.Name = "L_ID"
        Me.L_ID.Size = New System.Drawing.Size(170, 13)
        Me.L_ID.TabIndex = 629
        Me.L_ID.Text = "L_ID"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(400, 429)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(54, 13)
        Me.Label56.TabIndex = 628
        Me.Label56.Text = "ID Interno"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_Red
        '
        Me.L_Red.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Red.FormattingEnabled = True
        Me.L_Red.ItemHeight = 15
        Me.L_Red.Location = New System.Drawing.Point(12, 58)
        Me.L_Red.Name = "L_Red"
        Me.L_Red.Size = New System.Drawing.Size(316, 544)
        Me.L_Red.Sorted = True
        Me.L_Red.TabIndex = 626
        '
        'B_GrabarRed
        '
        Me.B_GrabarRed.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarRed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarRed.Location = New System.Drawing.Point(346, 12)
        Me.B_GrabarRed.Name = "B_GrabarRed"
        Me.B_GrabarRed.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarRed.TabIndex = 625
        Me.B_GrabarRed.Text = "Grabar"
        Me.B_GrabarRed.UseVisualStyleBackColor = False
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Blue
        Me.Label59.Location = New System.Drawing.Point(403, 62)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(48, 13)
        Me.Label59.TabIndex = 623
        Me.Label59.Text = "Chain ID"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(12, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 661
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'L_Fila
        '
        Me.L_Fila.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila.ForeColor = System.Drawing.Color.Black
        Me.L_Fila.Location = New System.Drawing.Point(460, 457)
        Me.L_Fila.Name = "L_Fila"
        Me.L_Fila.Size = New System.Drawing.Size(170, 13)
        Me.L_Fila.TabIndex = 662
        Me.L_Fila.Text = "L_Fila"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(428, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 663
        Me.Label1.Text = "Fila"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_ChainID
        '
        Me.L_ChainID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ChainID.ForeColor = System.Drawing.Color.Black
        Me.L_ChainID.Location = New System.Drawing.Point(460, 62)
        Me.L_ChainID.Name = "L_ChainID"
        Me.L_ChainID.Size = New System.Drawing.Size(170, 13)
        Me.L_ChainID.TabIndex = 671
        Me.L_ChainID.Text = "L_ChainID"
        '
        'L_NomOficial
        '
        Me.L_NomOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NomOficial.ForeColor = System.Drawing.Color.Black
        Me.L_NomOficial.Location = New System.Drawing.Point(460, 88)
        Me.L_NomOficial.Name = "L_NomOficial"
        Me.L_NomOficial.Size = New System.Drawing.Size(170, 13)
        Me.L_NomOficial.TabIndex = 672
        Me.L_NomOficial.Text = "L_NomOficial"
        '
        'L_NomCorto
        '
        Me.L_NomCorto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NomCorto.ForeColor = System.Drawing.Color.Black
        Me.L_NomCorto.Location = New System.Drawing.Point(460, 118)
        Me.L_NomCorto.Name = "L_NomCorto"
        Me.L_NomCorto.Size = New System.Drawing.Size(170, 13)
        Me.L_NomCorto.TabIndex = 673
        Me.L_NomCorto.Text = "L_NomCorto"
        '
        'L_APIcg
        '
        Me.L_APIcg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_APIcg.ForeColor = System.Drawing.Color.Black
        Me.L_APIcg.Location = New System.Drawing.Point(460, 144)
        Me.L_APIcg.Name = "L_APIcg"
        Me.L_APIcg.Size = New System.Drawing.Size(170, 13)
        Me.L_APIcg.TabIndex = 674
        Me.L_APIcg.Text = "L_APIcg"
        '
        'L_TipoCapa
        '
        Me.L_TipoCapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TipoCapa.ForeColor = System.Drawing.Color.Black
        Me.L_TipoCapa.Location = New System.Drawing.Point(460, 170)
        Me.L_TipoCapa.Name = "L_TipoCapa"
        Me.L_TipoCapa.Size = New System.Drawing.Size(170, 13)
        Me.L_TipoCapa.TabIndex = 675
        Me.L_TipoCapa.Text = "L_TipoCapa"
        '
        'L_L1padre
        '
        Me.L_L1padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_L1padre.ForeColor = System.Drawing.Color.Black
        Me.L_L1padre.Location = New System.Drawing.Point(460, 196)
        Me.L_L1padre.Name = "L_L1padre"
        Me.L_L1padre.Size = New System.Drawing.Size(170, 13)
        Me.L_L1padre.TabIndex = 676
        Me.L_L1padre.Text = "L_L1padre"
        '
        'L_TipoRollup
        '
        Me.L_TipoRollup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TipoRollup.ForeColor = System.Drawing.Color.Black
        Me.L_TipoRollup.Location = New System.Drawing.Point(460, 226)
        Me.L_TipoRollup.Name = "L_TipoRollup"
        Me.L_TipoRollup.Size = New System.Drawing.Size(170, 13)
        Me.L_TipoRollup.TabIndex = 677
        Me.L_TipoRollup.Text = "L_TipoRollup"
        '
        'L_MecanismoConsenso
        '
        Me.L_MecanismoConsenso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MecanismoConsenso.ForeColor = System.Drawing.Color.Black
        Me.L_MecanismoConsenso.Location = New System.Drawing.Point(460, 252)
        Me.L_MecanismoConsenso.Name = "L_MecanismoConsenso"
        Me.L_MecanismoConsenso.Size = New System.Drawing.Size(170, 13)
        Me.L_MecanismoConsenso.TabIndex = 678
        Me.L_MecanismoConsenso.Text = "L_MecanismoConsenso"
        '
        'L_TokenNativo
        '
        Me.L_TokenNativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_TokenNativo.ForeColor = System.Drawing.Color.Black
        Me.L_TokenNativo.Location = New System.Drawing.Point(460, 281)
        Me.L_TokenNativo.Name = "L_TokenNativo"
        Me.L_TokenNativo.Size = New System.Drawing.Size(170, 13)
        Me.L_TokenNativo.TabIndex = 679
        Me.L_TokenNativo.Text = "L_TokenNativo"
        '
        'L_Mensaje
        '
        Me.L_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.L_Mensaje.Location = New System.Drawing.Point(343, 586)
        Me.L_Mensaje.Name = "L_Mensaje"
        Me.L_Mensaje.Size = New System.Drawing.Size(524, 16)
        Me.L_Mensaje.TabIndex = 680
        Me.L_Mensaje.Text = "L_Mensaje"
        '
        'F_Red
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(880, 623)
        Me.Controls.Add(Me.L_Mensaje)
        Me.Controls.Add(Me.L_TokenNativo)
        Me.Controls.Add(Me.L_MecanismoConsenso)
        Me.Controls.Add(Me.L_TipoRollup)
        Me.Controls.Add(Me.L_L1padre)
        Me.Controls.Add(Me.L_TipoCapa)
        Me.Controls.Add(Me.L_APIcg)
        Me.Controls.Add(Me.L_NomCorto)
        Me.Controls.Add(Me.L_NomOficial)
        Me.Controls.Add(Me.L_ChainID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_Fila)
        Me.Controls.Add(Me.B_Cerrar)
        Me.Controls.Add(Me.rT_Nota)
        Me.Controls.Add(Me.CB_EVM_Red)
        Me.Controls.Add(Me.CB_Activo_Red)
        Me.Controls.Add(Me.T_URLrpc_Red)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.T_URLexplorador_Red)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.L_ID)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.L_Red)
        Me.Controls.Add(Me.B_GrabarRed)
        Me.Controls.Add(Me.Label59)
        Me.Location = New System.Drawing.Point(200, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Red"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Red"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rT_Nota As RichTextBox
    Friend WithEvents CB_EVM_Red As CheckBox
    Friend WithEvents CB_Activo_Red As CheckBox
    Friend WithEvents T_URLrpc_Red As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents T_URLexplorador_Red As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents L_ID As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents L_Red As ListBox
    Friend WithEvents B_GrabarRed As Button
    Friend WithEvents Label59 As Label
    Friend WithEvents B_Cerrar As Button
    Friend WithEvents L_Fila As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_ChainID As Label
    Friend WithEvents L_NomOficial As Label
    Friend WithEvents L_NomCorto As Label
    Friend WithEvents L_APIcg As Label
    Friend WithEvents L_TipoCapa As Label
    Friend WithEvents L_L1padre As Label
    Friend WithEvents L_TipoRollup As Label
    Friend WithEvents L_MecanismoConsenso As Label
    Friend WithEvents L_TokenNativo As Label
    Friend WithEvents L_Mensaje As Label
End Class
