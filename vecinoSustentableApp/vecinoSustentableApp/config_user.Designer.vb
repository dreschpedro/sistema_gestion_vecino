﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class config_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(config_user))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_rol = New System.Windows.Forms.ComboBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_usuario = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpcionImpresora = New System.Windows.Forms.PrintDialog()
        Me.HojaImpresion = New System.Drawing.Printing.PrintDocument()
        Me.VistaPrevia = New System.Windows.Forms.PrintPreviewDialog()
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.btn_imprimir = New FontAwesome.Sharp.IconButton()
        Me.btn_vista = New FontAwesome.Sharp.IconButton()
        Me.btn_limpiar_campos = New FontAwesome.Sharp.IconButton()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_modificar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnBuscarImagen = New FontAwesome.Sharp.IconButton()
        Me.btn_sacar_foto = New FontAwesome.Sharp.IconButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(104, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 29)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Configuración de Usuario:"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.label1.Location = New System.Drawing.Point(412, 465)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 13)
        Me.label1.TabIndex = 114
        Me.label1.Text = "Nombre del Usuario:"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.Red
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.White
        Me.btn_cerrar.Location = New System.Drawing.Point(12, 12)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 113
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(472, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Rol:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(412, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Apellido:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telefono.Location = New System.Drawing.Point(549, 477)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(128, 20)
        Me.txt_telefono.TabIndex = 6
        '
        'txt_ape
        '
        Me.txt_ape.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ape.Location = New System.Drawing.Point(414, 442)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(128, 20)
        Me.txt_ape.TabIndex = 4
        '
        'txt_usuario
        '
        Me.txt_usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_usuario.Location = New System.Drawing.Point(415, 477)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(128, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(548, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Nombre:"
        '
        'cmb_rol
        '
        Me.cmb_rol.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rol.FormattingEnabled = True
        Me.cmb_rol.Location = New System.Drawing.Point(475, 406)
        Me.cmb_rol.Name = "cmb_rol"
        Me.cmb_rol.Size = New System.Drawing.Size(128, 21)
        Me.cmb_rol.TabIndex = 3
        '
        'txt_pass
        '
        Me.txt_pass.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pass.Location = New System.Drawing.Point(415, 513)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(128, 20)
        Me.txt_pass.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(412, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Contraseña:"
        '
        'lb_usuario
        '
        Me.lb_usuario.FormattingEnabled = True
        Me.lb_usuario.Location = New System.Drawing.Point(36, 92)
        Me.lb_usuario.Name = "lb_usuario"
        Me.lb_usuario.Size = New System.Drawing.Size(211, 212)
        Me.lb_usuario.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(547, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Telefono:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.Location = New System.Drawing.Point(549, 441)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(128, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(36, 66)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(211, 20)
        Me.txt_buscar.TabIndex = 140
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(36, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Buscar:"
        '
        'OpcionImpresora
        '
        Me.OpcionImpresora.UseEXDialog = True
        '
        'HojaImpresion
        '
        '
        'VistaPrevia
        '
        Me.VistaPrevia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VistaPrevia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VistaPrevia.ClientSize = New System.Drawing.Size(400, 300)
        Me.VistaPrevia.Enabled = True
        Me.VistaPrevia.Icon = CType(resources.GetObject("VistaPrevia.Icon"), System.Drawing.Icon)
        Me.VistaPrevia.Name = "VistaPrevia"
        Me.VistaPrevia.Visible = False
        '
        'pbPicture
        '
        Me.pbPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbPicture.Image = Global.vecinoSustentableApp.My.Resources.Resources.cj
        Me.pbPicture.Location = New System.Drawing.Point(36, 442)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(160, 146)
        Me.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPicture.TabIndex = 144
        Me.pbPicture.TabStop = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btn_imprimir.IconColor = System.Drawing.Color.Black
        Me.btn_imprimir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_imprimir.IconSize = 20
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(495, 116)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(184, 29)
        Me.btn_imprimir.TabIndex = 143
        Me.btn_imprimir.Text = "Impresión"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_vista
        '
        Me.btn_vista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_vista.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btn_vista.IconColor = System.Drawing.Color.Black
        Me.btn_vista.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_vista.IconSize = 25
        Me.btn_vista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vista.Location = New System.Drawing.Point(494, 151)
        Me.btn_vista.Name = "btn_vista"
        Me.btn_vista.Size = New System.Drawing.Size(184, 29)
        Me.btn_vista.TabIndex = 142
        Me.btn_vista.Text = "Vista Previa"
        Me.btn_vista.UseVisualStyleBackColor = True
        '
        'btn_limpiar_campos
        '
        Me.btn_limpiar_campos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar_campos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_limpiar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar_campos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar_campos.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btn_limpiar_campos.IconColor = System.Drawing.Color.Black
        Me.btn_limpiar_campos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_limpiar_campos.IconSize = 20
        Me.btn_limpiar_campos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_campos.Location = New System.Drawing.Point(549, 507)
        Me.btn_limpiar_campos.Name = "btn_limpiar_campos"
        Me.btn_limpiar_campos.Size = New System.Drawing.Size(131, 29)
        Me.btn_limpiar_campos.TabIndex = 7
        Me.btn_limpiar_campos.Text = "Limpiar"
        Me.btn_limpiar_campos.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btn_eliminar.IconColor = System.Drawing.Color.Black
        Me.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_eliminar.IconSize = 20
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.Location = New System.Drawing.Point(493, 222)
        Me.btn_eliminar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_eliminar.MinimumSize = New System.Drawing.Size(185, 30)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(185, 30)
        Me.btn_eliminar.TabIndex = 11
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.BackColor = System.Drawing.Color.Yellow
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btn_modificar.IconColor = System.Drawing.Color.Black
        Me.btn_modificar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_modificar.IconSize = 20
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_modificar.Location = New System.Drawing.Point(495, 186)
        Me.btn_modificar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btn_modificar.MinimumSize = New System.Drawing.Size(185, 30)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(185, 30)
        Me.btn_modificar.TabIndex = 10
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.Lime
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAgregar.IconColor = System.Drawing.Color.Black
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 20
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(494, 79)
        Me.btnAgregar.MaximumSize = New System.Drawing.Size(194, 35)
        Me.btnAgregar.MinimumSize = New System.Drawing.Size(185, 30)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(185, 30)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarImagen.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.btnBuscarImagen.IconColor = System.Drawing.Color.Black
        Me.btnBuscarImagen.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarImagen.IconSize = 20
        Me.btnBuscarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarImagen.Location = New System.Drawing.Point(551, 559)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(128, 29)
        Me.btnBuscarImagen.TabIndex = 145
        Me.btnBuscarImagen.Text = "Cargar Imagen"
        Me.btnBuscarImagen.UseVisualStyleBackColor = True
        '
        'btn_sacar_foto
        '
        Me.btn_sacar_foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sacar_foto.IconChar = FontAwesome.Sharp.IconChar.Camera
        Me.btn_sacar_foto.IconColor = System.Drawing.Color.Black
        Me.btn_sacar_foto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sacar_foto.IconSize = 20
        Me.btn_sacar_foto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sacar_foto.Location = New System.Drawing.Point(418, 559)
        Me.btn_sacar_foto.Name = "btn_sacar_foto"
        Me.btn_sacar_foto.Size = New System.Drawing.Size(128, 29)
        Me.btn_sacar_foto.TabIndex = 146
        Me.btn_sacar_foto.Text = "Sacar foto"
        Me.btn_sacar_foto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'config_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(691, 611)
        Me.Controls.Add(Me.btn_sacar_foto)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_vista)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_limpiar_campos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lb_usuario)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_rol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_ape)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "config_user"
        Me.Text = "Form5"
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_modificar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_rol As ComboBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents lb_usuario As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_limpiar_campos As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_vista As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_imprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents OpcionImpresora As PrintDialog
    Friend WithEvents HojaImpresion As Printing.PrintDocument
    Friend WithEvents VistaPrevia As PrintPreviewDialog
    Friend WithEvents pbPicture As PictureBox
    Friend WithEvents btnBuscarImagen As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_sacar_foto As FontAwesome.Sharp.IconButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
