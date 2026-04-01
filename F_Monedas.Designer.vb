<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Monedas
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
        Me.B_Cerrar = New System.Windows.Forms.Button()
        Me.L_IDdespliegue_Moneda = New System.Windows.Forms.Label()
        Me.L_Fila_Moneda = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.T_Busqueda_Monedas = New System.Windows.Forms.TextBox()
        Me.B_Actualizar_Monedas = New System.Windows.Forms.Button()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.T_MarketCapRank_Moneda = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.T_ContractAddress_Moneda = New System.Windows.Forms.TextBox()
        Me.T_SupplyMaximo_Moneda = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.T_IDredNativa_Moneda = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.T_MonedaParidad_Moneda = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.T_ActivoSubyacente_Moneda = New System.Windows.Forms.TextBox()
        Me.T_Centralizada_Moneda = New System.Windows.Forms.TextBox()
        Me.T_SubtipoStablecoin_Moneda = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.T_TipoActivo_Moneda = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.T_Simbolo_Moneda = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.L_IDmoneda_Moneda = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.B_NuevoMoneda = New System.Windows.Forms.Button()
        Me.L_Monedas = New System.Windows.Forms.ListBox()
        Me.T_SlugAPI_Moneda = New System.Windows.Forms.TextBox()
        Me.T_AcronimoMoneda = New System.Windows.Forms.TextBox()
        Me.B_GrabarMoneda = New System.Windows.Forms.Button()
        Me.rT_NotaMoneda = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'B_Cerrar
        '
        Me.B_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.B_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Cerrar.Location = New System.Drawing.Point(867, 12)
        Me.B_Cerrar.Name = "B_Cerrar"
        Me.B_Cerrar.Size = New System.Drawing.Size(99, 23)
        Me.B_Cerrar.TabIndex = 417
        Me.B_Cerrar.Text = "Cerrar"
        Me.B_Cerrar.UseVisualStyleBackColor = False
        '
        'L_IDdespliegue_Moneda
        '
        Me.L_IDdespliegue_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_IDdespliegue_Moneda.ForeColor = System.Drawing.Color.Black
        Me.L_IDdespliegue_Moneda.Location = New System.Drawing.Point(443, 527)
        Me.L_IDdespliegue_Moneda.Name = "L_IDdespliegue_Moneda"
        Me.L_IDdespliegue_Moneda.Size = New System.Drawing.Size(170, 13)
        Me.L_IDdespliegue_Moneda.TabIndex = 647
        Me.L_IDdespliegue_Moneda.Text = "L_IDdespliegue_Moneda"
        '
        'L_Fila_Moneda
        '
        Me.L_Fila_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Fila_Moneda.ForeColor = System.Drawing.Color.Black
        Me.L_Fila_Moneda.Location = New System.Drawing.Point(443, 550)
        Me.L_Fila_Moneda.Name = "L_Fila_Moneda"
        Me.L_Fila_Moneda.Size = New System.Drawing.Size(170, 13)
        Me.L_Fila_Moneda.TabIndex = 646
        Me.L_Fila_Moneda.Text = "L_Fila_Moneda"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Blue
        Me.Label83.Location = New System.Drawing.Point(18, 50)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(58, 13)
        Me.Label83.TabIndex = 645
        Me.Label83.Text = "Busqueda:"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_Busqueda_Monedas
        '
        Me.T_Busqueda_Monedas.BackColor = System.Drawing.Color.White
        Me.T_Busqueda_Monedas.Location = New System.Drawing.Point(21, 70)
        Me.T_Busqueda_Monedas.MaxLength = 6
        Me.T_Busqueda_Monedas.Name = "T_Busqueda_Monedas"
        Me.T_Busqueda_Monedas.Size = New System.Drawing.Size(170, 20)
        Me.T_Busqueda_Monedas.TabIndex = 644
        Me.T_Busqueda_Monedas.Text = "T_Busqueda_Monedas"
        '
        'B_Actualizar_Monedas
        '
        Me.B_Actualizar_Monedas.BackColor = System.Drawing.SystemColors.Control
        Me.B_Actualizar_Monedas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Actualizar_Monedas.Location = New System.Drawing.Point(222, 12)
        Me.B_Actualizar_Monedas.Name = "B_Actualizar_Monedas"
        Me.B_Actualizar_Monedas.Size = New System.Drawing.Size(99, 23)
        Me.B_Actualizar_Monedas.TabIndex = 643
        Me.B_Actualizar_Monedas.Text = "Actualizar"
        Me.B_Actualizar_Monedas.UseVisualStyleBackColor = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Blue
        Me.Label80.Location = New System.Drawing.Point(352, 320)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(91, 13)
        Me.Label80.TabIndex = 642
        Me.Label80.Text = "Market Cap Rank"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_MarketCapRank_Moneda
        '
        Me.T_MarketCapRank_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_MarketCapRank_Moneda.Location = New System.Drawing.Point(446, 317)
        Me.T_MarketCapRank_Moneda.MaxLength = 6
        Me.T_MarketCapRank_Moneda.Name = "T_MarketCapRank_Moneda"
        Me.T_MarketCapRank_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_MarketCapRank_Moneda.TabIndex = 641
        Me.T_MarketCapRank_Moneda.Text = "T_MarketCapRank_Moneda"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Blue
        Me.Label81.Location = New System.Drawing.Point(355, 372)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(88, 13)
        Me.Label81.TabIndex = 640
        Me.Label81.Text = "Contract Address"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Blue
        Me.Label82.Location = New System.Drawing.Point(365, 346)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(78, 13)
        Me.Label82.TabIndex = 639
        Me.Label82.Text = "Supply Maximo"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_ContractAddress_Moneda
        '
        Me.T_ContractAddress_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ContractAddress_Moneda.Location = New System.Drawing.Point(446, 369)
        Me.T_ContractAddress_Moneda.MaxLength = 6
        Me.T_ContractAddress_Moneda.Name = "T_ContractAddress_Moneda"
        Me.T_ContractAddress_Moneda.Size = New System.Drawing.Size(278, 20)
        Me.T_ContractAddress_Moneda.TabIndex = 638
        Me.T_ContractAddress_Moneda.Text = "T_ContractAddress_Moneda"
        '
        'T_SupplyMaximo_Moneda
        '
        Me.T_SupplyMaximo_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_SupplyMaximo_Moneda.Location = New System.Drawing.Point(446, 343)
        Me.T_SupplyMaximo_Moneda.MaxLength = 6
        Me.T_SupplyMaximo_Moneda.Name = "T_SupplyMaximo_Moneda"
        Me.T_SupplyMaximo_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_SupplyMaximo_Moneda.TabIndex = 637
        Me.T_SupplyMaximo_Moneda.Text = "T_SupplyMaximo_Moneda"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Blue
        Me.Label61.Location = New System.Drawing.Point(368, 398)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(75, 13)
        Me.Label61.TabIndex = 636
        Me.Label61.Text = "ID Red Nativa"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_IDredNativa_Moneda
        '
        Me.T_IDredNativa_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_IDredNativa_Moneda.ForeColor = System.Drawing.Color.Red
        Me.T_IDredNativa_Moneda.Location = New System.Drawing.Point(446, 395)
        Me.T_IDredNativa_Moneda.MaxLength = 6
        Me.T_IDredNativa_Moneda.Name = "T_IDredNativa_Moneda"
        Me.T_IDredNativa_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_IDredNativa_Moneda.TabIndex = 635
        Me.T_IDredNativa_Moneda.Text = "T_IDredNativa_Moneda"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Blue
        Me.Label76.Location = New System.Drawing.Point(346, 294)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(97, 13)
        Me.Label76.TabIndex = 634
        Me.Label76.Text = "Activo Subyacente"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Blue
        Me.Label77.Location = New System.Drawing.Point(378, 268)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(65, 13)
        Me.Label77.TabIndex = 633
        Me.Label77.Text = "Centralizada"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Blue
        Me.Label78.Location = New System.Drawing.Point(358, 239)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(85, 13)
        Me.Label78.TabIndex = 632
        Me.Label78.Text = "Moneda Paridad"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_MonedaParidad_Moneda
        '
        Me.T_MonedaParidad_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_MonedaParidad_Moneda.Location = New System.Drawing.Point(446, 239)
        Me.T_MonedaParidad_Moneda.MaxLength = 6
        Me.T_MonedaParidad_Moneda.Name = "T_MonedaParidad_Moneda"
        Me.T_MonedaParidad_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_MonedaParidad_Moneda.TabIndex = 631
        Me.T_MonedaParidad_Moneda.Text = "T_MonedaParidad_Moneda"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Blue
        Me.Label79.Location = New System.Drawing.Point(347, 213)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(96, 13)
        Me.Label79.TabIndex = 630
        Me.Label79.Text = "Subtipo Stablecoin"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_ActivoSubyacente_Moneda
        '
        Me.T_ActivoSubyacente_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_ActivoSubyacente_Moneda.Location = New System.Drawing.Point(446, 291)
        Me.T_ActivoSubyacente_Moneda.MaxLength = 6
        Me.T_ActivoSubyacente_Moneda.Name = "T_ActivoSubyacente_Moneda"
        Me.T_ActivoSubyacente_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_ActivoSubyacente_Moneda.TabIndex = 629
        Me.T_ActivoSubyacente_Moneda.Text = "T_ActivoSubyacente_Moneda"
        '
        'T_Centralizada_Moneda
        '
        Me.T_Centralizada_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Centralizada_Moneda.Location = New System.Drawing.Point(446, 265)
        Me.T_Centralizada_Moneda.MaxLength = 6
        Me.T_Centralizada_Moneda.Name = "T_Centralizada_Moneda"
        Me.T_Centralizada_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_Centralizada_Moneda.TabIndex = 628
        Me.T_Centralizada_Moneda.Text = "T_Centralizada_Moneda"
        '
        'T_SubtipoStablecoin_Moneda
        '
        Me.T_SubtipoStablecoin_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_SubtipoStablecoin_Moneda.Location = New System.Drawing.Point(446, 213)
        Me.T_SubtipoStablecoin_Moneda.MaxLength = 6
        Me.T_SubtipoStablecoin_Moneda.Name = "T_SubtipoStablecoin_Moneda"
        Me.T_SubtipoStablecoin_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_SubtipoStablecoin_Moneda.TabIndex = 627
        Me.T_SubtipoStablecoin_Moneda.Text = "T_SubtipoStablecoin_Moneda"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Blue
        Me.Label55.Location = New System.Drawing.Point(382, 190)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(61, 13)
        Me.Label55.TabIndex = 626
        Me.Label55.Text = "Tipo Activo"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_TipoActivo_Moneda
        '
        Me.T_TipoActivo_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_TipoActivo_Moneda.Location = New System.Drawing.Point(446, 187)
        Me.T_TipoActivo_Moneda.MaxLength = 6
        Me.T_TipoActivo_Moneda.Name = "T_TipoActivo_Moneda"
        Me.T_TipoActivo_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_TipoActivo_Moneda.TabIndex = 625
        Me.T_TipoActivo_Moneda.Text = "T_TipoActivo_Moneda"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(395, 164)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 13)
        Me.Label39.TabIndex = 624
        Me.Label39.Text = "Slug API"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Blue
        Me.Label38.Location = New System.Drawing.Point(367, 138)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(76, 13)
        Me.Label38.TabIndex = 623
        Me.Label38.Text = "Nombre Oficial"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Blue
        Me.Label75.Location = New System.Drawing.Point(399, 109)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(44, 13)
        Me.Label75.TabIndex = 622
        Me.Label75.Text = "Simbolo"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'T_Simbolo_Moneda
        '
        Me.T_Simbolo_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_Simbolo_Moneda.Location = New System.Drawing.Point(446, 109)
        Me.T_Simbolo_Moneda.MaxLength = 6
        Me.T_Simbolo_Moneda.Name = "T_Simbolo_Moneda"
        Me.T_Simbolo_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_Simbolo_Moneda.TabIndex = 621
        Me.T_Simbolo_Moneda.Text = "T_Simbolo_Moneda"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(366, 527)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(74, 13)
        Me.Label42.TabIndex = 620
        Me.Label42.Text = "ID Despliegue"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'L_IDmoneda_Moneda
        '
        Me.L_IDmoneda_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_IDmoneda_Moneda.ForeColor = System.Drawing.Color.Black
        Me.L_IDmoneda_Moneda.Location = New System.Drawing.Point(443, 503)
        Me.L_IDmoneda_Moneda.Name = "L_IDmoneda_Moneda"
        Me.L_IDmoneda_Moneda.Size = New System.Drawing.Size(170, 13)
        Me.L_IDmoneda_Moneda.TabIndex = 619
        Me.L_IDmoneda_Moneda.Text = "L_IDmoneda_Moneda"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(386, 503)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(54, 13)
        Me.Label74.TabIndex = 618
        Me.Label74.Text = "ID Interno"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'B_NuevoMoneda
        '
        Me.B_NuevoMoneda.BackColor = System.Drawing.SystemColors.Control
        Me.B_NuevoMoneda.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_NuevoMoneda.Location = New System.Drawing.Point(117, 12)
        Me.B_NuevoMoneda.Name = "B_NuevoMoneda"
        Me.B_NuevoMoneda.Size = New System.Drawing.Size(99, 23)
        Me.B_NuevoMoneda.TabIndex = 617
        Me.B_NuevoMoneda.Text = "Nuevo"
        Me.B_NuevoMoneda.UseVisualStyleBackColor = False
        '
        'L_Monedas
        '
        Me.L_Monedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Monedas.FormattingEnabled = True
        Me.L_Monedas.ItemHeight = 15
        Me.L_Monedas.Location = New System.Drawing.Point(21, 109)
        Me.L_Monedas.Name = "L_Monedas"
        Me.L_Monedas.Size = New System.Drawing.Size(316, 454)
        Me.L_Monedas.TabIndex = 616
        '
        'T_SlugAPI_Moneda
        '
        Me.T_SlugAPI_Moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_SlugAPI_Moneda.Location = New System.Drawing.Point(446, 161)
        Me.T_SlugAPI_Moneda.MaxLength = 6
        Me.T_SlugAPI_Moneda.Name = "T_SlugAPI_Moneda"
        Me.T_SlugAPI_Moneda.Size = New System.Drawing.Size(170, 20)
        Me.T_SlugAPI_Moneda.TabIndex = 615
        Me.T_SlugAPI_Moneda.Text = "T_SlugAPI_Moneda"
        '
        'T_AcronimoMoneda
        '
        Me.T_AcronimoMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_AcronimoMoneda.Location = New System.Drawing.Point(446, 135)
        Me.T_AcronimoMoneda.MaxLength = 6
        Me.T_AcronimoMoneda.Name = "T_AcronimoMoneda"
        Me.T_AcronimoMoneda.Size = New System.Drawing.Size(170, 20)
        Me.T_AcronimoMoneda.TabIndex = 614
        Me.T_AcronimoMoneda.Text = "T_NombreOficial_Moneda"
        '
        'B_GrabarMoneda
        '
        Me.B_GrabarMoneda.BackColor = System.Drawing.SystemColors.Control
        Me.B_GrabarMoneda.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_GrabarMoneda.Location = New System.Drawing.Point(12, 12)
        Me.B_GrabarMoneda.Name = "B_GrabarMoneda"
        Me.B_GrabarMoneda.Size = New System.Drawing.Size(99, 23)
        Me.B_GrabarMoneda.TabIndex = 613
        Me.B_GrabarMoneda.Text = "Grabar"
        Me.B_GrabarMoneda.UseVisualStyleBackColor = False
        '
        'rT_NotaMoneda
        '
        Me.rT_NotaMoneda.AcceptsTab = True
        Me.rT_NotaMoneda.AutoWordSelection = True
        Me.rT_NotaMoneda.BackColor = System.Drawing.Color.White
        Me.rT_NotaMoneda.Location = New System.Drawing.Point(633, 109)
        Me.rT_NotaMoneda.Name = "rT_NotaMoneda"
        Me.rT_NotaMoneda.ReadOnly = True
        Me.rT_NotaMoneda.Size = New System.Drawing.Size(334, 252)
        Me.rT_NotaMoneda.TabIndex = 612
        Me.rT_NotaMoneda.Text = "rT_NotaMoneda"
        '
        'F_Monedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.B_Cerrar
        Me.ClientSize = New System.Drawing.Size(978, 615)
        Me.Controls.Add(Me.L_IDdespliegue_Moneda)
        Me.Controls.Add(Me.L_Fila_Moneda)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.T_Busqueda_Monedas)
        Me.Controls.Add(Me.B_Actualizar_Monedas)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.T_MarketCapRank_Moneda)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.T_ContractAddress_Moneda)
        Me.Controls.Add(Me.T_SupplyMaximo_Moneda)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.T_IDredNativa_Moneda)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.T_MonedaParidad_Moneda)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.T_ActivoSubyacente_Moneda)
        Me.Controls.Add(Me.T_Centralizada_Moneda)
        Me.Controls.Add(Me.T_SubtipoStablecoin_Moneda)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.T_TipoActivo_Moneda)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.T_Simbolo_Moneda)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.L_IDmoneda_Moneda)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.B_NuevoMoneda)
        Me.Controls.Add(Me.L_Monedas)
        Me.Controls.Add(Me.T_SlugAPI_Moneda)
        Me.Controls.Add(Me.T_AcronimoMoneda)
        Me.Controls.Add(Me.B_GrabarMoneda)
        Me.Controls.Add(Me.rT_NotaMoneda)
        Me.Controls.Add(Me.B_Cerrar)
        Me.MaximizeBox = False
        Me.Name = "F_Monedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monedas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Cerrar As Button
    Friend WithEvents L_IDdespliegue_Moneda As Label
    Friend WithEvents L_Fila_Moneda As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents T_Busqueda_Monedas As TextBox
    Friend WithEvents B_Actualizar_Monedas As Button
    Friend WithEvents Label80 As Label
    Friend WithEvents T_MarketCapRank_Moneda As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents T_ContractAddress_Moneda As TextBox
    Friend WithEvents T_SupplyMaximo_Moneda As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents T_IDredNativa_Moneda As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents T_MonedaParidad_Moneda As TextBox
    Friend WithEvents Label79 As Label
    Friend WithEvents T_ActivoSubyacente_Moneda As TextBox
    Friend WithEvents T_Centralizada_Moneda As TextBox
    Friend WithEvents T_SubtipoStablecoin_Moneda As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents T_TipoActivo_Moneda As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents T_Simbolo_Moneda As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents L_IDmoneda_Moneda As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents B_NuevoMoneda As Button
    Friend WithEvents L_Monedas As ListBox
    Friend WithEvents T_SlugAPI_Moneda As TextBox
    Friend WithEvents T_AcronimoMoneda As TextBox
    Friend WithEvents B_GrabarMoneda As Button
    Friend WithEvents rT_NotaMoneda As RichTextBox
End Class
