<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinPersonal
    Inherits SISE.SPE.UI.WinBase

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinPersonal))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtCV = New SISE.SPE.Controls.UITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescUbigeoNac = New SISE.SPE.Controls.UITextBox()
        Me.txtCodUbigeoNac = New SISE.SPE.Controls.UITextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDescNacionalidad = New SISE.SPE.Controls.UITextBox()
        Me.txtCodNacionalidad = New SISE.SPE.Controls.UITextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboTipDocumento = New System.Windows.Forms.ComboBox()
        Me.txtDescOcupacion = New SISE.SPE.Controls.UITextBox()
        Me.txtCodOcupacion = New SISE.SPE.Controls.UITextBox()
        Me.btnOcupacion = New System.Windows.Forms.Button()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtActivoSi = New System.Windows.Forms.RadioButton()
        Me.rbtActivoNo = New System.Windows.Forms.RadioButton()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cboCivil = New System.Windows.Forms.ComboBox()
        Me.txtNumDocumento = New SISE.SPE.Controls.UITextBox()
        Me.txtNombres = New SISE.SPE.Controls.UITextBox()
        Me.txtApellidoMaterno = New SISE.SPE.Controls.UITextBox()
        Me.txtApellidoPaterno = New SISE.SPE.Controls.UITextBox()
        Me.UiTextBox1 = New SISE.SPE.Controls.UITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvReferenciaLaboral = New System.Windows.Forms.DataGridView()
        Me.ColRefAval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRefFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRefFonoCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRefEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRefOcupacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvFonoCorreo = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvReferenciaLaboral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvFonoCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(877, 466)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.txtCV)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtFechaNac)
        Me.TabPage2.Controls.Add(Me.txtDescUbigeoNac)
        Me.TabPage2.Controls.Add(Me.txtCodUbigeoNac)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.txtDescNacionalidad)
        Me.TabPage2.Controls.Add(Me.txtCodNacionalidad)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.cboTipDocumento)
        Me.TabPage2.Controls.Add(Me.txtDescOcupacion)
        Me.TabPage2.Controls.Add(Me.txtCodOcupacion)
        Me.TabPage2.Controls.Add(Me.btnOcupacion)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.btnRestablecer)
        Me.TabPage2.Controls.Add(Me.pbxImagen)
        Me.TabPage2.Controls.Add(Me.btnExaminar)
        Me.TabPage2.Controls.Add(Me.cboSexo)
        Me.TabPage2.Controls.Add(Me.cboCivil)
        Me.TabPage2.Controls.Add(Me.txtNumDocumento)
        Me.TabPage2.Controls.Add(Me.txtNombres)
        Me.TabPage2.Controls.Add(Me.txtApellidoMaterno)
        Me.TabPage2.Controls.Add(Me.txtApellidoPaterno)
        Me.TabPage2.Controls.Add(Me.UiTextBox1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label51)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label73)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(869, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Generales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(468, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 23)
        Me.Button3.TabIndex = 311
        Me.Button3.TabStop = False
        Me.Button3.Tag = "BLQ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtCV
        '
        Me.txtCV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCV.Location = New System.Drawing.Point(127, 260)
        Me.txtCV.Name = "txtCV"
        Me.txtCV.Size = New System.Drawing.Size(339, 20)
        Me.txtCV.TabIndex = 310
        Me.txtCV.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtCV.WaterMarkText = "Ruta física del curriculum vitae"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(8, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 309
        Me.Label4.Text = "Curriculum Vitae"
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(127, 239)
        Me.txtFechaNac.Mask = "00/00/0000"
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(72, 20)
        Me.txtFechaNac.TabIndex = 308
        Me.txtFechaNac.Tag = "BLQ"
        Me.txtFechaNac.ValidatingType = GetType(Date)
        '
        'txtDescUbigeoNac
        '
        Me.txtDescUbigeoNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescUbigeoNac.Location = New System.Drawing.Point(214, 220)
        Me.txtDescUbigeoNac.Name = "txtDescUbigeoNac"
        Me.txtDescUbigeoNac.Size = New System.Drawing.Size(152, 20)
        Me.txtDescUbigeoNac.TabIndex = 307
        Me.txtDescUbigeoNac.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtDescUbigeoNac.WaterMarkText = "Ubigeo"
        '
        'txtCodUbigeoNac
        '
        Me.txtCodUbigeoNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodUbigeoNac.Location = New System.Drawing.Point(127, 220)
        Me.txtCodUbigeoNac.Name = "txtCodUbigeoNac"
        Me.txtCodUbigeoNac.Size = New System.Drawing.Size(56, 20)
        Me.txtCodUbigeoNac.TabIndex = 306
        Me.txtCodUbigeoNac.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtCodUbigeoNac.WaterMarkText = "Código"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(182, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 23)
        Me.Button2.TabIndex = 305
        Me.Button2.TabStop = False
        Me.Button2.Tag = "BLQ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDescNacionalidad
        '
        Me.txtDescNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescNacionalidad.Location = New System.Drawing.Point(214, 198)
        Me.txtDescNacionalidad.Name = "txtDescNacionalidad"
        Me.txtDescNacionalidad.Size = New System.Drawing.Size(152, 20)
        Me.txtDescNacionalidad.TabIndex = 304
        Me.txtDescNacionalidad.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtDescNacionalidad.WaterMarkText = "Nacionalidad"
        '
        'txtCodNacionalidad
        '
        Me.txtCodNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodNacionalidad.Location = New System.Drawing.Point(127, 198)
        Me.txtCodNacionalidad.Name = "txtCodNacionalidad"
        Me.txtCodNacionalidad.Size = New System.Drawing.Size(56, 20)
        Me.txtCodNacionalidad.TabIndex = 303
        Me.txtCodNacionalidad.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtCodNacionalidad.WaterMarkText = "Código"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(182, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 302
        Me.Button1.TabStop = False
        Me.Button1.Tag = "BLQ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboTipDocumento
        '
        Me.cboTipDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipDocumento.FormattingEnabled = True
        Me.cboTipDocumento.Location = New System.Drawing.Point(127, 155)
        Me.cboTipDocumento.Name = "cboTipDocumento"
        Me.cboTipDocumento.Size = New System.Drawing.Size(239, 21)
        Me.cboTipDocumento.TabIndex = 301
        '
        'txtDescOcupacion
        '
        Me.txtDescOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDescOcupacion.Location = New System.Drawing.Point(214, 133)
        Me.txtDescOcupacion.Name = "txtDescOcupacion"
        Me.txtDescOcupacion.Size = New System.Drawing.Size(152, 20)
        Me.txtDescOcupacion.TabIndex = 300
        Me.txtDescOcupacion.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtDescOcupacion.WaterMarkText = "Ocupación"
        '
        'txtCodOcupacion
        '
        Me.txtCodOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCodOcupacion.Location = New System.Drawing.Point(127, 133)
        Me.txtCodOcupacion.Name = "txtCodOcupacion"
        Me.txtCodOcupacion.Size = New System.Drawing.Size(56, 20)
        Me.txtCodOcupacion.TabIndex = 299
        Me.txtCodOcupacion.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtCodOcupacion.WaterMarkText = "Codigo"
        '
        'btnOcupacion
        '
        Me.btnOcupacion.Image = CType(resources.GetObject("btnOcupacion.Image"), System.Drawing.Image)
        Me.btnOcupacion.Location = New System.Drawing.Point(182, 131)
        Me.btnOcupacion.Name = "btnOcupacion"
        Me.btnOcupacion.Size = New System.Drawing.Size(31, 23)
        Me.btnOcupacion.TabIndex = 298
        Me.btnOcupacion.TabStop = False
        Me.btnOcupacion.Tag = "BLQ"
        Me.btnOcupacion.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(568, 157)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(143, 13)
        Me.Label56.TabIndex = 297
        Me.Label56.Tag = "n"
        Me.Label56.Text = "El trabajador esta habilitado?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtActivoSi)
        Me.Panel1.Controls.Add(Me.rbtActivoNo)
        Me.Panel1.Location = New System.Drawing.Point(590, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(90, 20)
        Me.Panel1.TabIndex = 296
        Me.Panel1.Tag = "BLQ"
        '
        'rbtActivoSi
        '
        Me.rbtActivoSi.AutoSize = True
        Me.rbtActivoSi.Checked = True
        Me.rbtActivoSi.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtActivoSi.Location = New System.Drawing.Point(6, 2)
        Me.rbtActivoSi.Name = "rbtActivoSi"
        Me.rbtActivoSi.Size = New System.Drawing.Size(33, 15)
        Me.rbtActivoSi.TabIndex = 0
        Me.rbtActivoSi.TabStop = True
        Me.rbtActivoSi.Text = "SI"
        Me.rbtActivoSi.UseVisualStyleBackColor = True
        '
        'rbtActivoNo
        '
        Me.rbtActivoNo.AutoSize = True
        Me.rbtActivoNo.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtActivoNo.Location = New System.Drawing.Point(43, 2)
        Me.rbtActivoNo.Name = "rbtActivoNo"
        Me.rbtActivoNo.Size = New System.Drawing.Size(38, 15)
        Me.rbtActivoNo.TabIndex = 1
        Me.rbtActivoNo.Text = "NO"
        Me.rbtActivoNo.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.Location = New System.Drawing.Point(704, 52)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(75, 23)
        Me.btnRestablecer.TabIndex = 295
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = True
        Me.btnRestablecer.Visible = False
        '
        'pbxImagen
        '
        Me.pbxImagen.BackColor = System.Drawing.SystemColors.Control
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxImagen.Image = CType(resources.GetObject("pbxImagen.Image"), System.Drawing.Image)
        Me.pbxImagen.Location = New System.Drawing.Point(571, 10)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(131, 144)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagen.TabIndex = 293
        Me.pbxImagen.TabStop = False
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(704, 29)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 294
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        Me.btnExaminar.Visible = False
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(127, 111)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(239, 21)
        Me.cboSexo.TabIndex = 292
        '
        'cboCivil
        '
        Me.cboCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCivil.FormattingEnabled = True
        Me.cboCivil.Location = New System.Drawing.Point(127, 90)
        Me.cboCivil.Name = "cboCivil"
        Me.cboCivil.Size = New System.Drawing.Size(239, 21)
        Me.cboCivil.TabIndex = 291
        '
        'txtNumDocumento
        '
        Me.txtNumDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNumDocumento.Location = New System.Drawing.Point(127, 177)
        Me.txtNumDocumento.Name = "txtNumDocumento"
        Me.txtNumDocumento.Size = New System.Drawing.Size(239, 20)
        Me.txtNumDocumento.TabIndex = 290
        Me.txtNumDocumento.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtNumDocumento.WaterMarkText = "Ingrese el numero de documento"
        '
        'txtNombres
        '
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNombres.Location = New System.Drawing.Point(127, 70)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(239, 20)
        Me.txtNombres.TabIndex = 289
        Me.txtNombres.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtNombres.WaterMarkText = "Ingrese el nombre"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(127, 50)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(239, 20)
        Me.txtApellidoMaterno.TabIndex = 288
        Me.txtApellidoMaterno.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtApellidoMaterno.WaterMarkText = "Ingrese el apellido materno"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(127, 29)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(239, 20)
        Me.txtApellidoPaterno.TabIndex = 287
        Me.txtApellidoPaterno.WaterMarkColor = System.Drawing.Color.Gray
        Me.txtApellidoPaterno.WaterMarkText = "Ingrese el apellido paterno"
        '
        'UiTextBox1
        '
        Me.UiTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UiTextBox1.Location = New System.Drawing.Point(127, 7)
        Me.UiTextBox1.Name = "UiTextBox1"
        Me.UiTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UiTextBox1.TabIndex = 286
        Me.UiTextBox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.UiTextBox1.WaterMarkText = "Autogenerado"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(8, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 277
        Me.Label6.Text = "Ubigeo nacimiento:"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label51.Location = New System.Drawing.Point(8, 6)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(119, 21)
        Me.Label51.TabIndex = 282
        Me.Label51.Text = "Código:"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label39.Location = New System.Drawing.Point(8, 133)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(119, 21)
        Me.Label39.TabIndex = 283
        Me.Label39.Text = "Ocupación:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(8, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 21)
        Me.Label9.TabIndex = 280
        Me.Label9.Text = "Nombres:"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label73.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label73.Location = New System.Drawing.Point(8, 111)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(119, 22)
        Me.Label73.TabIndex = 285
        Me.Label73.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(8, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 279
        Me.Label8.Text = "Nº. documento:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(8, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 21)
        Me.Label10.TabIndex = 281
        Me.Label10.Text = "Nacionalidad:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(8, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "Tipo de documento:"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Location = New System.Drawing.Point(8, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 21)
        Me.Label24.TabIndex = 284
        Me.Label24.Text = "Estado civil:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "Apellido materno:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "Apellido paterno:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(8, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 21)
        Me.Label7.TabIndex = 278
        Me.Label7.Text = "Fecha de nacimiento:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl2.Location = New System.Drawing.Point(3, 281)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(863, 156)
        Me.TabControl2.TabIndex = 312
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvReferenciaLaboral)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(855, 130)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Referencia Laboral"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvReferenciaLaboral
        '
        Me.dgvReferenciaLaboral.BackgroundColor = System.Drawing.Color.White
        Me.dgvReferenciaLaboral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReferenciaLaboral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRefAval, Me.ColRefFijo, Me.ColRefFonoCelular, Me.ColRefEmail, Me.ColRefOcupacion})
        Me.dgvReferenciaLaboral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReferenciaLaboral.Location = New System.Drawing.Point(3, 3)
        Me.dgvReferenciaLaboral.Name = "dgvReferenciaLaboral"
        Me.dgvReferenciaLaboral.Size = New System.Drawing.Size(849, 124)
        Me.dgvReferenciaLaboral.TabIndex = 0
        '
        'ColRefAval
        '
        Me.ColRefAval.HeaderText = "Aval"
        Me.ColRefAval.Name = "ColRefAval"
        '
        'ColRefFijo
        '
        Me.ColRefFijo.HeaderText = "Telefono Fijo"
        Me.ColRefFijo.Name = "ColRefFijo"
        '
        'ColRefFonoCelular
        '
        Me.ColRefFonoCelular.HeaderText = "Celular"
        Me.ColRefFonoCelular.Name = "ColRefFonoCelular"
        '
        'ColRefEmail
        '
        Me.ColRefEmail.HeaderText = "Email"
        Me.ColRefEmail.Name = "ColRefEmail"
        '
        'ColRefOcupacion
        '
        Me.ColRefOcupacion.HeaderText = "Ocupación"
        Me.ColRefOcupacion.Name = "ColRefOcupacion"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvFonoCorreo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(855, 130)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Telefonos y correos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvFonoCorreo
        '
        Me.dgvFonoCorreo.BackgroundColor = System.Drawing.Color.White
        Me.dgvFonoCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFonoCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFonoCorreo.Location = New System.Drawing.Point(3, 3)
        Me.dgvFonoCorreo.Name = "dgvFonoCorreo"
        Me.dgvFonoCorreo.Size = New System.Drawing.Size(849, 124)
        Me.dgvFonoCorreo.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(855, 130)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Domicilio"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(855, 130)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Datos bancarios"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(855, 130)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Formación Academica"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(869, 440)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Datos Laborales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WinPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 537)
        Me.Controls.Add(Me.TabControl1)
        Me.Descripcion = "Realiza el mantenimiento de personal"
        Me.Name = "WinPersonal"
        Me.Text = "WinPersonal"
        Me.Titulo = "PERSONAL"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvReferenciaLaboral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvFonoCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvReferenciaLaboral As System.Windows.Forms.DataGridView
    Friend WithEvents ColRefAval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRefFijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRefFonoCelular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRefEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRefOcupacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvFonoCorreo As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtCV As SISE.SPE.Controls.UITextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDescUbigeoNac As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtCodUbigeoNac As SISE.SPE.Controls.UITextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtDescNacionalidad As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtCodNacionalidad As SISE.SPE.Controls.UITextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboTipDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescOcupacion As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtCodOcupacion As SISE.SPE.Controls.UITextBox
    Friend WithEvents btnOcupacion As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtActivoSi As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivoNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnRestablecer As System.Windows.Forms.Button
    Friend WithEvents pbxImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cboCivil As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumDocumento As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtNombres As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtApellidoMaterno As SISE.SPE.Controls.UITextBox
    Friend WithEvents txtApellidoPaterno As SISE.SPE.Controls.UITextBox
    Friend WithEvents UiTextBox1 As SISE.SPE.Controls.UITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
