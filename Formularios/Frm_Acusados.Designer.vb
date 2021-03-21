<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Acusados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Acusados))
        Me.Txt_Rasgo = New System.Windows.Forms.TextBox()
        Me.Nud_Alto = New System.Windows.Forms.NumericUpDown()
        Me.Nud_Peso = New System.Windows.Forms.NumericUpDown()
        Me.Btn_izquierda_e = New System.Windows.Forms.Button()
        Me.Btn_izquierda_a = New System.Windows.Forms.Button()
        Me.Btn_frente_e = New System.Windows.Forms.Button()
        Me.Btn_frente_a = New System.Windows.Forms.Button()
        Me.Btn_derecho_e = New System.Windows.Forms.Button()
        Me.Btn_derecho_a = New System.Windows.Forms.Button()
        Me.Txt_Extra = New System.Windows.Forms.TextBox()
        Me.Txt_Calle = New System.Windows.Forms.TextBox()
        Me.Txt_Ciudad = New System.Windows.Forms.TextBox()
        Me.Text_Depto = New System.Windows.Forms.TextBox()
        Me.Txt_Pais = New System.Windows.Forms.TextBox()
        Me.Txt_Tel = New System.Windows.Forms.TextBox()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Foto_Izquierda = New System.Windows.Forms.PictureBox()
        Me.Foto_Frente = New System.Windows.Forms.PictureBox()
        Me.Foto_derecha = New System.Windows.Forms.PictureBox()
        Me.Txt_Id = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre1 = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre2 = New System.Windows.Forms.TextBox()
        Me.Txt_Apellido2 = New System.Windows.Forms.TextBox()
        Me.Txt_Apellido1 = New System.Windows.Forms.TextBox()
        Me.Txt_Alias = New System.Windows.Forms.TextBox()
        Me.Txt_Nacionalidad = New System.Windows.Forms.TextBox()
        Me.Combo_Edu = New System.Windows.Forms.ComboBox()
        Me.Combo_Estado = New System.Windows.Forms.ComboBox()
        Me.Txt_Pais_O = New System.Windows.Forms.TextBox()
        Me.Txt_Depto_o = New System.Windows.Forms.TextBox()
        Me.Txt_Ciudad_O = New System.Windows.Forms.TextBox()
        Me.Date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Ocupacion = New System.Windows.Forms.TextBox()
        Me.Tap_Informacion = New System.Windows.Forms.TabControl()
        Me.TabP_Personal = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabP_Apariencia = New System.Windows.Forms.TabPage()
        Me.TBL_Acusado_RasgoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Acusado_RasgoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.BTN_Rasgos = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Combo_Genero = New System.Windows.Forms.ComboBox()
        Me.Combo_Ojos = New System.Windows.Forms.ComboBox()
        Me.Combo_Pelo = New System.Windows.Forms.ComboBox()
        Me.Combo_Piel = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabP_Contacto = New System.Windows.Forms.TabPage()
        Me.TBL_Acusado_TelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Acusado_TelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_Acusado_EmailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Acusado_EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Tel = New System.Windows.Forms.Button()
        Me.BTN_Email = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabP_Historial = New System.Windows.Forms.TabPage()
        Me.Tabla_Historial = New System.Windows.Forms.DataGridView()
        Me.AcuCADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuDelitoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuDescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Acusado_HistorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label29 = New System.Windows.Forms.Label()
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuNombre1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuNombre2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuApellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuApellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuGeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuEstadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuAliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuNivelEduDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuDeptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuExtraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuNacidoelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuNacionalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuPaisNacidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuDeptoNacidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuCiudadNacidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuAlturamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuPesolbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuPielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuPeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuOjosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcuOcupacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_AcusadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_AcusadoTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_AcusadoTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.TBL_Acusado_EmailTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Acusado_EmailTableAdapter()
        Me.TBL_Acusado_HistorialTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Acusado_HistorialTableAdapter()
        Me.TBL_Acusado_RasgoTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Acusado_RasgoTableAdapter()
        Me.TBL_Acusado_TelTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Acusado_TelTableAdapter()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        CType(Me.Nud_Alto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nud_Peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto_Izquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto_Frente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto_derecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tap_Informacion.SuspendLayout()
        Me.TabP_Personal.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabP_Apariencia.SuspendLayout()
        CType(Me.TBL_Acusado_RasgoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Acusado_RasgoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabP_Contacto.SuspendLayout()
        CType(Me.TBL_Acusado_TelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Acusado_TelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Acusado_EmailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Acusado_EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabP_Historial.SuspendLayout()
        CType(Me.Tabla_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Acusado_HistorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_AcusadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Rasgo
        '
        Me.Txt_Rasgo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Rasgo.Location = New System.Drawing.Point(235, 379)
        Me.Txt_Rasgo.MaxLength = 100
        Me.Txt_Rasgo.Name = "Txt_Rasgo"
        Me.Txt_Rasgo.Size = New System.Drawing.Size(181, 26)
        Me.Txt_Rasgo.TabIndex = 63
        '
        'Nud_Alto
        '
        Me.Nud_Alto.DecimalPlaces = 2
        Me.Nud_Alto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_Alto.Location = New System.Drawing.Point(348, 212)
        Me.Nud_Alto.Maximum = New Decimal(New Integer() {999, 0, 0, 131072})
        Me.Nud_Alto.Name = "Nud_Alto"
        Me.Nud_Alto.Size = New System.Drawing.Size(77, 26)
        Me.Nud_Alto.TabIndex = 57
        '
        'Nud_Peso
        '
        Me.Nud_Peso.DecimalPlaces = 2
        Me.Nud_Peso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nud_Peso.Location = New System.Drawing.Point(120, 212)
        Me.Nud_Peso.Maximum = New Decimal(New Integer() {999999, 0, 0, 131072})
        Me.Nud_Peso.Name = "Nud_Peso"
        Me.Nud_Peso.Size = New System.Drawing.Size(89, 26)
        Me.Nud_Peso.TabIndex = 56
        '
        'Btn_izquierda_e
        '
        Me.Btn_izquierda_e.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_izquierda_e.Location = New System.Drawing.Point(418, 160)
        Me.Btn_izquierda_e.Name = "Btn_izquierda_e"
        Me.Btn_izquierda_e.Size = New System.Drawing.Size(27, 23)
        Me.Btn_izquierda_e.TabIndex = 11
        Me.Btn_izquierda_e.Text = "-"
        Me.Btn_izquierda_e.UseVisualStyleBackColor = True
        '
        'Btn_izquierda_a
        '
        Me.Btn_izquierda_a.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_izquierda_a.Location = New System.Drawing.Point(321, 160)
        Me.Btn_izquierda_a.Name = "Btn_izquierda_a"
        Me.Btn_izquierda_a.Size = New System.Drawing.Size(27, 23)
        Me.Btn_izquierda_a.TabIndex = 10
        Me.Btn_izquierda_a.Text = "+"
        Me.Btn_izquierda_a.UseVisualStyleBackColor = True
        '
        'Btn_frente_e
        '
        Me.Btn_frente_e.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_frente_e.Location = New System.Drawing.Point(265, 160)
        Me.Btn_frente_e.Name = "Btn_frente_e"
        Me.Btn_frente_e.Size = New System.Drawing.Size(27, 23)
        Me.Btn_frente_e.TabIndex = 9
        Me.Btn_frente_e.Text = "-"
        Me.Btn_frente_e.UseVisualStyleBackColor = True
        '
        'Btn_frente_a
        '
        Me.Btn_frente_a.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_frente_a.Location = New System.Drawing.Point(168, 160)
        Me.Btn_frente_a.Name = "Btn_frente_a"
        Me.Btn_frente_a.Size = New System.Drawing.Size(27, 23)
        Me.Btn_frente_a.TabIndex = 8
        Me.Btn_frente_a.Text = "+"
        Me.Btn_frente_a.UseVisualStyleBackColor = True
        '
        'Btn_derecho_e
        '
        Me.Btn_derecho_e.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_derecho_e.Location = New System.Drawing.Point(116, 160)
        Me.Btn_derecho_e.Name = "Btn_derecho_e"
        Me.Btn_derecho_e.Size = New System.Drawing.Size(27, 23)
        Me.Btn_derecho_e.TabIndex = 4
        Me.Btn_derecho_e.Text = "-"
        Me.Btn_derecho_e.UseVisualStyleBackColor = True
        '
        'Btn_derecho_a
        '
        Me.Btn_derecho_a.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_derecho_a.Location = New System.Drawing.Point(19, 160)
        Me.Btn_derecho_a.Name = "Btn_derecho_a"
        Me.Btn_derecho_a.Size = New System.Drawing.Size(27, 23)
        Me.Btn_derecho_a.TabIndex = 3
        Me.Btn_derecho_a.Text = "+"
        Me.Btn_derecho_a.UseVisualStyleBackColor = True
        '
        'Txt_Extra
        '
        Me.Txt_Extra.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Extra.Location = New System.Drawing.Point(9, 126)
        Me.Txt_Extra.MaxLength = 100
        Me.Txt_Extra.Multiline = True
        Me.Txt_Extra.Name = "Txt_Extra"
        Me.Txt_Extra.Size = New System.Drawing.Size(433, 68)
        Me.Txt_Extra.TabIndex = 51
        '
        'Txt_Calle
        '
        Me.Txt_Calle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Calle.Location = New System.Drawing.Point(273, 67)
        Me.Txt_Calle.MaxLength = 50
        Me.Txt_Calle.Name = "Txt_Calle"
        Me.Txt_Calle.Size = New System.Drawing.Size(169, 26)
        Me.Txt_Calle.TabIndex = 50
        '
        'Txt_Ciudad
        '
        Me.Txt_Ciudad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ciudad.Location = New System.Drawing.Point(78, 67)
        Me.Txt_Ciudad.MaxLength = 50
        Me.Txt_Ciudad.Name = "Txt_Ciudad"
        Me.Txt_Ciudad.Size = New System.Drawing.Size(131, 26)
        Me.Txt_Ciudad.TabIndex = 49
        '
        'Text_Depto
        '
        Me.Text_Depto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Depto.Location = New System.Drawing.Point(303, 29)
        Me.Text_Depto.MaxLength = 50
        Me.Text_Depto.Name = "Text_Depto"
        Me.Text_Depto.Size = New System.Drawing.Size(139, 26)
        Me.Text_Depto.TabIndex = 48
        '
        'Txt_Pais
        '
        Me.Txt_Pais.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pais.Location = New System.Drawing.Point(58, 29)
        Me.Txt_Pais.MaxLength = 50
        Me.Txt_Pais.Name = "Txt_Pais"
        Me.Txt_Pais.Size = New System.Drawing.Size(113, 26)
        Me.Txt_Pais.TabIndex = 47
        '
        'Txt_Tel
        '
        Me.Txt_Tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tel.Location = New System.Drawing.Point(235, 183)
        Me.Txt_Tel.MaxLength = 15
        Me.Txt_Tel.Name = "Txt_Tel"
        Me.Txt_Tel.Size = New System.Drawing.Size(131, 26)
        Me.Txt_Tel.TabIndex = 57
        '
        'Txt_Email
        '
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(212, 68)
        Me.Txt_Email.MaxLength = 100
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(181, 26)
        Me.Txt_Email.TabIndex = 53
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Enabled = False
        Me.Txt_Codigo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.Location = New System.Drawing.Point(72, 15)
        Me.Txt_Codigo.MaxLength = 50
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Codigo.TabIndex = 58
        '
        'Foto_Izquierda
        '
        Me.Foto_Izquierda.BackgroundImage = Global.Sistema_fiscal_para_acusados.My.Resources.Resources.Perfil_Izquierdo
        Me.Foto_Izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto_Izquierda.Location = New System.Drawing.Point(321, 25)
        Me.Foto_Izquierda.Name = "Foto_Izquierda"
        Me.Foto_Izquierda.Size = New System.Drawing.Size(124, 111)
        Me.Foto_Izquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto_Izquierda.TabIndex = 2
        Me.Foto_Izquierda.TabStop = False
        '
        'Foto_Frente
        '
        Me.Foto_Frente.BackgroundImage = Global.Sistema_fiscal_para_acusados.My.Resources.Resources.Frente
        Me.Foto_Frente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto_Frente.Location = New System.Drawing.Point(168, 25)
        Me.Foto_Frente.Name = "Foto_Frente"
        Me.Foto_Frente.Size = New System.Drawing.Size(124, 111)
        Me.Foto_Frente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto_Frente.TabIndex = 1
        Me.Foto_Frente.TabStop = False
        '
        'Foto_derecha
        '
        Me.Foto_derecha.BackgroundImage = Global.Sistema_fiscal_para_acusados.My.Resources.Resources.Perfil_Derecho
        Me.Foto_derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Foto_derecha.Location = New System.Drawing.Point(19, 25)
        Me.Foto_derecha.Name = "Foto_derecha"
        Me.Foto_derecha.Size = New System.Drawing.Size(124, 111)
        Me.Foto_derecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto_derecha.TabIndex = 0
        Me.Foto_derecha.TabStop = False
        '
        'Txt_Id
        '
        Me.Txt_Id.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Id.Location = New System.Drawing.Point(274, 15)
        Me.Txt_Id.MaxLength = 15
        Me.Txt_Id.Name = "Txt_Id"
        Me.Txt_Id.Size = New System.Drawing.Size(145, 26)
        Me.Txt_Id.TabIndex = 59
        '
        'Txt_Nombre1
        '
        Me.Txt_Nombre1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre1.Location = New System.Drawing.Point(128, 57)
        Me.Txt_Nombre1.MaxLength = 50
        Me.Txt_Nombre1.Name = "Txt_Nombre1"
        Me.Txt_Nombre1.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Nombre1.TabIndex = 60
        '
        'Txt_Nombre2
        '
        Me.Txt_Nombre2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre2.Location = New System.Drawing.Point(146, 99)
        Me.Txt_Nombre2.MaxLength = 50
        Me.Txt_Nombre2.Name = "Txt_Nombre2"
        Me.Txt_Nombre2.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Nombre2.TabIndex = 61
        '
        'Txt_Apellido2
        '
        Me.Txt_Apellido2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Apellido2.Location = New System.Drawing.Point(369, 57)
        Me.Txt_Apellido2.MaxLength = 50
        Me.Txt_Apellido2.Name = "Txt_Apellido2"
        Me.Txt_Apellido2.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Apellido2.TabIndex = 63
        '
        'Txt_Apellido1
        '
        Me.Txt_Apellido1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Apellido1.Location = New System.Drawing.Point(371, 99)
        Me.Txt_Apellido1.MaxLength = 50
        Me.Txt_Apellido1.Name = "Txt_Apellido1"
        Me.Txt_Apellido1.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Apellido1.TabIndex = 62
        '
        'Txt_Alias
        '
        Me.Txt_Alias.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Alias.Location = New System.Drawing.Point(278, 183)
        Me.Txt_Alias.MaxLength = 50
        Me.Txt_Alias.Name = "Txt_Alias"
        Me.Txt_Alias.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Alias.TabIndex = 65
        '
        'Txt_Nacionalidad
        '
        Me.Txt_Nacionalidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nacionalidad.Location = New System.Drawing.Point(114, 183)
        Me.Txt_Nacionalidad.MaxLength = 50
        Me.Txt_Nacionalidad.Name = "Txt_Nacionalidad"
        Me.Txt_Nacionalidad.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Nacionalidad.TabIndex = 64
        '
        'Combo_Edu
        '
        Me.Combo_Edu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Edu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Edu.FormattingEnabled = True
        Me.Combo_Edu.Items.AddRange(New Object() {"Analfabeta", "Preescolar", "Primaria", "Primaria", "Profesionista", "Licenciado", "Maestría", "Doctorado"})
        Me.Combo_Edu.Location = New System.Drawing.Point(315, 141)
        Me.Combo_Edu.Name = "Combo_Edu"
        Me.Combo_Edu.Size = New System.Drawing.Size(121, 27)
        Me.Combo_Edu.TabIndex = 66
        '
        'Combo_Estado
        '
        Me.Combo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Estado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Estado.FormattingEnabled = True
        Me.Combo_Estado.Items.AddRange(New Object() {"Soltero", "Casado"})
        Me.Combo_Estado.Location = New System.Drawing.Point(107, 141)
        Me.Combo_Estado.Name = "Combo_Estado"
        Me.Combo_Estado.Size = New System.Drawing.Size(100, 27)
        Me.Combo_Estado.TabIndex = 67
        '
        'Txt_Pais_O
        '
        Me.Txt_Pais_O.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pais_O.Location = New System.Drawing.Point(64, 28)
        Me.Txt_Pais_O.MaxLength = 50
        Me.Txt_Pais_O.Name = "Txt_Pais_O"
        Me.Txt_Pais_O.Size = New System.Drawing.Size(113, 26)
        Me.Txt_Pais_O.TabIndex = 60
        '
        'Txt_Depto_o
        '
        Me.Txt_Depto_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Depto_o.Location = New System.Drawing.Point(140, 66)
        Me.Txt_Depto_o.MaxLength = 50
        Me.Txt_Depto_o.Name = "Txt_Depto_o"
        Me.Txt_Depto_o.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Depto_o.TabIndex = 61
        '
        'Txt_Ciudad_O
        '
        Me.Txt_Ciudad_O.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ciudad_O.Location = New System.Drawing.Point(280, 28)
        Me.Txt_Ciudad_O.MaxLength = 50
        Me.Txt_Ciudad_O.Name = "Txt_Ciudad_O"
        Me.Txt_Ciudad_O.Size = New System.Drawing.Size(131, 26)
        Me.Txt_Ciudad_O.TabIndex = 62
        '
        'Date_Fecha
        '
        Me.Date_Fecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Fecha.Location = New System.Drawing.Point(165, 340)
        Me.Date_Fecha.Name = "Date_Fecha"
        Me.Date_Fecha.Size = New System.Drawing.Size(265, 26)
        Me.Date_Fecha.TabIndex = 69
        '
        'Txt_Ocupacion
        '
        Me.Txt_Ocupacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ocupacion.Location = New System.Drawing.Point(107, 381)
        Me.Txt_Ocupacion.MaxLength = 50
        Me.Txt_Ocupacion.Name = "Txt_Ocupacion"
        Me.Txt_Ocupacion.Size = New System.Drawing.Size(162, 26)
        Me.Txt_Ocupacion.TabIndex = 70
        '
        'Tap_Informacion
        '
        Me.Tap_Informacion.Controls.Add(Me.TabP_Personal)
        Me.Tap_Informacion.Controls.Add(Me.TabP_Apariencia)
        Me.Tap_Informacion.Controls.Add(Me.TabP_Contacto)
        Me.Tap_Informacion.Controls.Add(Me.TabP_Historial)
        Me.Tap_Informacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tap_Informacion.Location = New System.Drawing.Point(12, 12)
        Me.Tap_Informacion.Name = "Tap_Informacion"
        Me.Tap_Informacion.SelectedIndex = 0
        Me.Tap_Informacion.Size = New System.Drawing.Size(483, 474)
        Me.Tap_Informacion.TabIndex = 27
        '
        'TabP_Personal
        '
        Me.TabP_Personal.Controls.Add(Me.Txt_Ocupacion)
        Me.TabP_Personal.Controls.Add(Me.Date_Fecha)
        Me.TabP_Personal.Controls.Add(Me.GroupBox3)
        Me.TabP_Personal.Controls.Add(Me.Combo_Estado)
        Me.TabP_Personal.Controls.Add(Me.Combo_Edu)
        Me.TabP_Personal.Controls.Add(Me.Txt_Alias)
        Me.TabP_Personal.Controls.Add(Me.Txt_Nacionalidad)
        Me.TabP_Personal.Controls.Add(Me.Txt_Apellido2)
        Me.TabP_Personal.Controls.Add(Me.Txt_Apellido1)
        Me.TabP_Personal.Controls.Add(Me.Txt_Nombre2)
        Me.TabP_Personal.Controls.Add(Me.Txt_Nombre1)
        Me.TabP_Personal.Controls.Add(Me.Txt_Id)
        Me.TabP_Personal.Controls.Add(Me.Txt_Codigo)
        Me.TabP_Personal.Controls.Add(Me.Label26)
        Me.TabP_Personal.Controls.Add(Me.Label17)
        Me.TabP_Personal.Controls.Add(Me.Label16)
        Me.TabP_Personal.Controls.Add(Me.Label10)
        Me.TabP_Personal.Controls.Add(Me.Label9)
        Me.TabP_Personal.Controls.Add(Me.Label8)
        Me.TabP_Personal.Controls.Add(Me.Label6)
        Me.TabP_Personal.Controls.Add(Me.Label5)
        Me.TabP_Personal.Controls.Add(Me.Label4)
        Me.TabP_Personal.Controls.Add(Me.Label3)
        Me.TabP_Personal.Controls.Add(Me.Label2)
        Me.TabP_Personal.Controls.Add(Me.Label1)
        Me.TabP_Personal.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Personal.Name = "TabP_Personal"
        Me.TabP_Personal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Personal.Size = New System.Drawing.Size(475, 442)
        Me.TabP_Personal.TabIndex = 0
        Me.TabP_Personal.Text = "Personal"
        Me.TabP_Personal.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion personal de un acusado en par" &
    "ticular"
        Me.TabP_Personal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txt_Ciudad_O)
        Me.GroupBox3.Controls.Add(Me.Txt_Depto_o)
        Me.GroupBox3.Controls.Add(Me.Txt_Pais_O)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 100)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Origenes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 18)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Departamento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 18)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Pais:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(206, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Ciudad:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(14, 384)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(93, 18)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "Ocupacion:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 18)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Nacionalidad:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 346)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 18)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Fecha nacimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(223, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Educacion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(223, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 18)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Alias:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Estado civil:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Identidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Segundo apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(246, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Primer apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Segundo nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Primer nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Codigo:"
        '
        'TabP_Apariencia
        '
        Me.TabP_Apariencia.AutoScroll = True
        Me.TabP_Apariencia.Controls.Add(Me.TBL_Acusado_RasgoDataGridView)
        Me.TabP_Apariencia.Controls.Add(Me.BTN_Rasgos)
        Me.TabP_Apariencia.Controls.Add(Me.Label28)
        Me.TabP_Apariencia.Controls.Add(Me.Txt_Rasgo)
        Me.TabP_Apariencia.Controls.Add(Me.Label39)
        Me.TabP_Apariencia.Controls.Add(Me.Combo_Genero)
        Me.TabP_Apariencia.Controls.Add(Me.Combo_Ojos)
        Me.TabP_Apariencia.Controls.Add(Me.Combo_Pelo)
        Me.TabP_Apariencia.Controls.Add(Me.Combo_Piel)
        Me.TabP_Apariencia.Controls.Add(Me.Nud_Alto)
        Me.TabP_Apariencia.Controls.Add(Me.Nud_Peso)
        Me.TabP_Apariencia.Controls.Add(Me.GroupBox2)
        Me.TabP_Apariencia.Controls.Add(Me.Label25)
        Me.TabP_Apariencia.Controls.Add(Me.Label24)
        Me.TabP_Apariencia.Controls.Add(Me.Label23)
        Me.TabP_Apariencia.Controls.Add(Me.Label22)
        Me.TabP_Apariencia.Controls.Add(Me.Label21)
        Me.TabP_Apariencia.Controls.Add(Me.Label7)
        Me.TabP_Apariencia.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Apariencia.Name = "TabP_Apariencia"
        Me.TabP_Apariencia.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Apariencia.Size = New System.Drawing.Size(475, 442)
        Me.TabP_Apariencia.TabIndex = 1
        Me.TabP_Apariencia.Text = "Apariencia"
        Me.TabP_Apariencia.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion sobre la apariencia de un acu" &
    "sado en particular"
        Me.TabP_Apariencia.UseVisualStyleBackColor = True
        '
        'TBL_Acusado_RasgoDataGridView
        '
        Me.TBL_Acusado_RasgoDataGridView.AllowUserToAddRows = False
        Me.TBL_Acusado_RasgoDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Acusado_RasgoDataGridView.AutoGenerateColumns = False
        Me.TBL_Acusado_RasgoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Acusado_RasgoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TBL_Acusado_RasgoDataGridView.DataSource = Me.TBL_Acusado_RasgoBindingSource
        Me.TBL_Acusado_RasgoDataGridView.Location = New System.Drawing.Point(36, 345)
        Me.TBL_Acusado_RasgoDataGridView.Name = "TBL_Acusado_RasgoDataGridView"
        Me.TBL_Acusado_RasgoDataGridView.ReadOnly = True
        Me.TBL_Acusado_RasgoDataGridView.Size = New System.Drawing.Size(143, 84)
        Me.TBL_Acusado_RasgoDataGridView.TabIndex = 66
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Acu_CA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Acu_CA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Acu_Rasgo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rasgo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TBL_Acusado_RasgoBindingSource
        '
        Me.TBL_Acusado_RasgoBindingSource.DataMember = "TBL_Acusado_Rasgo"
        Me.TBL_Acusado_RasgoBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BDAcusadosDataSet
        '
        Me.BDAcusadosDataSet.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_Rasgos
        '
        Me.BTN_Rasgos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Rasgos.Location = New System.Drawing.Point(297, 406)
        Me.BTN_Rasgos.Name = "BTN_Rasgos"
        Me.BTN_Rasgos.Size = New System.Drawing.Size(57, 23)
        Me.BTN_Rasgos.TabIndex = 66
        Me.BTN_Rasgos.Text = "Add"
        Me.BTN_Rasgos.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(32, 328)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(165, 18)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "Rasgos del acusado:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(232, 358)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(179, 18)
        Me.Label39.TabIndex = 62
        Me.Label39.Text = "Insertar Nuevo Rasgo:"
        '
        'Combo_Genero
        '
        Me.Combo_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Genero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Genero.FormattingEnabled = True
        Me.Combo_Genero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Combo_Genero.Location = New System.Drawing.Point(308, 298)
        Me.Combo_Genero.Name = "Combo_Genero"
        Me.Combo_Genero.Size = New System.Drawing.Size(114, 27)
        Me.Combo_Genero.TabIndex = 61
        '
        'Combo_Ojos
        '
        Me.Combo_Ojos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Ojos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Ojos.FormattingEnabled = True
        Me.Combo_Ojos.Items.AddRange(New Object() {"Cafés", "Azules", "Verdes", "Grises"})
        Me.Combo_Ojos.Location = New System.Drawing.Point(134, 298)
        Me.Combo_Ojos.Name = "Combo_Ojos"
        Me.Combo_Ojos.Size = New System.Drawing.Size(87, 27)
        Me.Combo_Ojos.TabIndex = 60
        '
        'Combo_Pelo
        '
        Me.Combo_Pelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Pelo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Pelo.FormattingEnabled = True
        Me.Combo_Pelo.Items.AddRange(New Object() {"Negro", "Castaño", "Rubio", "Pelirrojo"})
        Me.Combo_Pelo.Location = New System.Drawing.Point(352, 253)
        Me.Combo_Pelo.Name = "Combo_Pelo"
        Me.Combo_Pelo.Size = New System.Drawing.Size(90, 27)
        Me.Combo_Pelo.TabIndex = 59
        '
        'Combo_Piel
        '
        Me.Combo_Piel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Piel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Piel.FormattingEnabled = True
        Me.Combo_Piel.Items.AddRange(New Object() {"Albino", "Blanco", "Afro", "Trigueño"})
        Me.Combo_Piel.Location = New System.Drawing.Point(127, 253)
        Me.Combo_Piel.Name = "Combo_Piel"
        Me.Combo_Piel.Size = New System.Drawing.Size(100, 27)
        Me.Combo_Piel.TabIndex = 58
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_izquierda_e)
        Me.GroupBox2.Controls.Add(Me.Btn_izquierda_a)
        Me.GroupBox2.Controls.Add(Me.Btn_frente_e)
        Me.GroupBox2.Controls.Add(Me.Btn_frente_a)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Btn_derecho_e)
        Me.GroupBox2.Controls.Add(Me.Btn_derecho_a)
        Me.GroupBox2.Controls.Add(Me.Foto_Izquierda)
        Me.GroupBox2.Controls.Add(Me.Foto_Frente)
        Me.GroupBox2.Controls.Add(Me.Foto_derecha)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 200)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fotos del acusado"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(326, 139)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(119, 18)
        Me.Label38.TabIndex = 7
        Me.Label38.Text = "Perfil izquierdo"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(198, 139)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 18)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "Frente"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(27, 139)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(112, 18)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Perfil derecho"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(14, 301)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 18)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "Color de ojos:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(233, 256)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 18)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Color de pelo:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 256)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 18)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Color de piel:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 214)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 18)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Peso en (lb):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(226, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Altura en (m):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Genero:"
        '
        'TabP_Contacto
        '
        Me.TabP_Contacto.AutoScroll = True
        Me.TabP_Contacto.Controls.Add(Me.TBL_Acusado_TelDataGridView)
        Me.TabP_Contacto.Controls.Add(Me.TBL_Acusado_EmailDataGridView)
        Me.TabP_Contacto.Controls.Add(Me.Btn_Tel)
        Me.TabP_Contacto.Controls.Add(Me.BTN_Email)
        Me.TabP_Contacto.Controls.Add(Me.GroupBox1)
        Me.TabP_Contacto.Controls.Add(Me.Label30)
        Me.TabP_Contacto.Controls.Add(Me.Txt_Tel)
        Me.TabP_Contacto.Controls.Add(Me.Label36)
        Me.TabP_Contacto.Controls.Add(Me.Label35)
        Me.TabP_Contacto.Controls.Add(Me.Txt_Email)
        Me.TabP_Contacto.Controls.Add(Me.Label27)
        Me.TabP_Contacto.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Contacto.Name = "TabP_Contacto"
        Me.TabP_Contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Contacto.Size = New System.Drawing.Size(475, 442)
        Me.TabP_Contacto.TabIndex = 2
        Me.TabP_Contacto.Text = "Contacto"
        Me.TabP_Contacto.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion sobre el contacto de un acusa" &
    "do en particular"
        Me.TabP_Contacto.UseVisualStyleBackColor = True
        '
        'TBL_Acusado_TelDataGridView
        '
        Me.TBL_Acusado_TelDataGridView.AllowUserToAddRows = False
        Me.TBL_Acusado_TelDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Acusado_TelDataGridView.AutoGenerateColumns = False
        Me.TBL_Acusado_TelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Acusado_TelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TBL_Acusado_TelDataGridView.DataSource = Me.TBL_Acusado_TelBindingSource
        Me.TBL_Acusado_TelDataGridView.Location = New System.Drawing.Point(28, 150)
        Me.TBL_Acusado_TelDataGridView.Name = "TBL_Acusado_TelDataGridView"
        Me.TBL_Acusado_TelDataGridView.ReadOnly = True
        Me.TBL_Acusado_TelDataGridView.Size = New System.Drawing.Size(147, 84)
        Me.TBL_Acusado_TelDataGridView.TabIndex = 62
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Acu_CA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Acu_CA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Acu_Tel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tel"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TBL_Acusado_TelBindingSource
        '
        Me.TBL_Acusado_TelBindingSource.DataMember = "TBL_Acusado_Tel"
        Me.TBL_Acusado_TelBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'TBL_Acusado_EmailDataGridView
        '
        Me.TBL_Acusado_EmailDataGridView.AllowUserToAddRows = False
        Me.TBL_Acusado_EmailDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Acusado_EmailDataGridView.AutoGenerateColumns = False
        Me.TBL_Acusado_EmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Acusado_EmailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TBL_Acusado_EmailDataGridView.DataSource = Me.TBL_Acusado_EmailBindingSource
        Me.TBL_Acusado_EmailDataGridView.Location = New System.Drawing.Point(28, 38)
        Me.TBL_Acusado_EmailDataGridView.Name = "TBL_Acusado_EmailDataGridView"
        Me.TBL_Acusado_EmailDataGridView.ReadOnly = True
        Me.TBL_Acusado_EmailDataGridView.Size = New System.Drawing.Size(143, 82)
        Me.TBL_Acusado_EmailDataGridView.TabIndex = 62
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Acu_CA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Acu_CA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Acu_Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TBL_Acusado_EmailBindingSource
        '
        Me.TBL_Acusado_EmailBindingSource.DataMember = "TBL_Acusado_Email"
        Me.TBL_Acusado_EmailBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'Btn_Tel
        '
        Me.Btn_Tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Tel.Location = New System.Drawing.Point(275, 215)
        Me.Btn_Tel.Name = "Btn_Tel"
        Me.Btn_Tel.Size = New System.Drawing.Size(57, 23)
        Me.Btn_Tel.TabIndex = 62
        Me.Btn_Tel.Text = "Add"
        Me.Btn_Tel.UseVisualStyleBackColor = True
        '
        'BTN_Email
        '
        Me.BTN_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Email.Location = New System.Drawing.Point(275, 100)
        Me.BTN_Email.Name = "BTN_Email"
        Me.BTN_Email.Size = New System.Drawing.Size(57, 23)
        Me.BTN_Email.TabIndex = 61
        Me.BTN_Email.Text = "Add"
        Me.BTN_Email.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Extra)
        Me.GroupBox1.Controls.Add(Me.Txt_Calle)
        Me.GroupBox1.Controls.Add(Me.Txt_Ciudad)
        Me.GroupBox1.Controls.Add(Me.Text_Depto)
        Me.GroupBox1.Controls.Add(Me.Txt_Pais)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 200)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direccion del acusado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 18)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Pais:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(177, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 18)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Departamento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Ciudad:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 18)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Calle:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 18)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Extra:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(42, 129)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(129, 18)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "Tel del acusado:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(232, 162)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(152, 18)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Insertar Nuevo Tel:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(18, 17)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(169, 18)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Correos del acusado:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(218, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(172, 18)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "Insertar Nuevo Email:"
        '
        'TabP_Historial
        '
        Me.TabP_Historial.Controls.Add(Me.Tabla_Historial)
        Me.TabP_Historial.Controls.Add(Me.Label29)
        Me.TabP_Historial.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Historial.Name = "TabP_Historial"
        Me.TabP_Historial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Historial.Size = New System.Drawing.Size(475, 442)
        Me.TabP_Historial.TabIndex = 3
        Me.TabP_Historial.Text = "Historial"
        Me.TabP_Historial.ToolTipText = "Mostrar informacion sobre el historial criminal de un acusado en particular"
        Me.TabP_Historial.UseVisualStyleBackColor = True
        '
        'Tabla_Historial
        '
        Me.Tabla_Historial.AllowUserToAddRows = False
        Me.Tabla_Historial.AllowUserToDeleteRows = False
        Me.Tabla_Historial.AutoGenerateColumns = False
        Me.Tabla_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Historial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AcuCADataGridViewTextBoxColumn1, Me.AcuDelitoDataGridViewTextBoxColumn, Me.AcuDescripcionDataGridViewTextBoxColumn})
        Me.Tabla_Historial.DataSource = Me.TBL_Acusado_HistorialBindingSource
        Me.Tabla_Historial.Location = New System.Drawing.Point(6, 25)
        Me.Tabla_Historial.Name = "Tabla_Historial"
        Me.Tabla_Historial.ReadOnly = True
        Me.Tabla_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Historial.Size = New System.Drawing.Size(439, 410)
        Me.Tabla_Historial.TabIndex = 45
        '
        'AcuCADataGridViewTextBoxColumn1
        '
        Me.AcuCADataGridViewTextBoxColumn1.DataPropertyName = "Acu_CA"
        Me.AcuCADataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.AcuCADataGridViewTextBoxColumn1.Name = "AcuCADataGridViewTextBoxColumn1"
        Me.AcuCADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AcuDelitoDataGridViewTextBoxColumn
        '
        Me.AcuDelitoDataGridViewTextBoxColumn.DataPropertyName = "Acu_Delito"
        Me.AcuDelitoDataGridViewTextBoxColumn.HeaderText = "Delito"
        Me.AcuDelitoDataGridViewTextBoxColumn.Name = "AcuDelitoDataGridViewTextBoxColumn"
        Me.AcuDelitoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuDescripcionDataGridViewTextBoxColumn
        '
        Me.AcuDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Acu_Descripcion"
        Me.AcuDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.AcuDescripcionDataGridViewTextBoxColumn.Name = "AcuDescripcionDataGridViewTextBoxColumn"
        Me.AcuDescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_Acusado_HistorialBindingSource
        '
        Me.TBL_Acusado_HistorialBindingSource.DataMember = "TBL_Acusado_Historial"
        Me.TBL_Acusado_HistorialBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 3)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(135, 19)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "Historial criminal:"
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Acusados.Controls.Add(Me.BtnEliminar)
        Me.gb_Acusados.Controls.Add(Me.datalistado)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(12, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(482, 474)
        Me.gb_Acusados.TabIndex = 28
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de acusados"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Navy
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(209, 406)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 77
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoGenerateColumns = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.AcuCADataGridViewTextBoxColumn, Me.AcuNombre1DataGridViewTextBoxColumn, Me.AcuNombre2DataGridViewTextBoxColumn, Me.AcuApellido1DataGridViewTextBoxColumn, Me.AcuApellido2DataGridViewTextBoxColumn, Me.AcuIDDataGridViewTextBoxColumn, Me.AcuGeneroDataGridViewTextBoxColumn, Me.AcuEstadoCivilDataGridViewTextBoxColumn, Me.AcuAliasDataGridViewTextBoxColumn, Me.AcuNivelEduDataGridViewTextBoxColumn, Me.AcuPaisDataGridViewTextBoxColumn, Me.AcuDeptoDataGridViewTextBoxColumn, Me.AcuCiudadDataGridViewTextBoxColumn, Me.AcuCalleDataGridViewTextBoxColumn, Me.AcuExtraDataGridViewTextBoxColumn, Me.AcuNacidoelDataGridViewTextBoxColumn, Me.AcuNacionalidadDataGridViewTextBoxColumn, Me.AcuPaisNacidoDataGridViewTextBoxColumn, Me.AcuDeptoNacidoDataGridViewTextBoxColumn, Me.AcuCiudadNacidoDataGridViewTextBoxColumn, Me.AcuAlturamDataGridViewTextBoxColumn, Me.AcuPesolbDataGridViewTextBoxColumn, Me.AcuPielDataGridViewTextBoxColumn, Me.AcuPeloDataGridViewTextBoxColumn, Me.AcuOjosDataGridViewTextBoxColumn, Me.AcuOcupacionDataGridViewTextBoxColumn})
        Me.datalistado.DataSource = Me.TBL_AcusadoBindingSource
        Me.datalistado.Location = New System.Drawing.Point(15, 28)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(454, 372)
        Me.datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'AcuCADataGridViewTextBoxColumn
        '
        Me.AcuCADataGridViewTextBoxColumn.DataPropertyName = "Acu_CA"
        Me.AcuCADataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.AcuCADataGridViewTextBoxColumn.Name = "AcuCADataGridViewTextBoxColumn"
        Me.AcuCADataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuNombre1DataGridViewTextBoxColumn
        '
        Me.AcuNombre1DataGridViewTextBoxColumn.DataPropertyName = "Acu_Nombre1"
        Me.AcuNombre1DataGridViewTextBoxColumn.HeaderText = "1ro Nombre"
        Me.AcuNombre1DataGridViewTextBoxColumn.Name = "AcuNombre1DataGridViewTextBoxColumn"
        Me.AcuNombre1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuNombre2DataGridViewTextBoxColumn
        '
        Me.AcuNombre2DataGridViewTextBoxColumn.DataPropertyName = "Acu_Nombre2"
        Me.AcuNombre2DataGridViewTextBoxColumn.HeaderText = "2do Nombre"
        Me.AcuNombre2DataGridViewTextBoxColumn.Name = "AcuNombre2DataGridViewTextBoxColumn"
        Me.AcuNombre2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuApellido1DataGridViewTextBoxColumn
        '
        Me.AcuApellido1DataGridViewTextBoxColumn.DataPropertyName = "Acu_Apellido1"
        Me.AcuApellido1DataGridViewTextBoxColumn.HeaderText = "1ro Apellido"
        Me.AcuApellido1DataGridViewTextBoxColumn.Name = "AcuApellido1DataGridViewTextBoxColumn"
        Me.AcuApellido1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuApellido2DataGridViewTextBoxColumn
        '
        Me.AcuApellido2DataGridViewTextBoxColumn.DataPropertyName = "Acu_Apellido2"
        Me.AcuApellido2DataGridViewTextBoxColumn.HeaderText = "2do Apellido"
        Me.AcuApellido2DataGridViewTextBoxColumn.Name = "AcuApellido2DataGridViewTextBoxColumn"
        Me.AcuApellido2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuIDDataGridViewTextBoxColumn
        '
        Me.AcuIDDataGridViewTextBoxColumn.DataPropertyName = "Acu_ID"
        Me.AcuIDDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.AcuIDDataGridViewTextBoxColumn.Name = "AcuIDDataGridViewTextBoxColumn"
        Me.AcuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuGeneroDataGridViewTextBoxColumn
        '
        Me.AcuGeneroDataGridViewTextBoxColumn.DataPropertyName = "Acu_Genero"
        Me.AcuGeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.AcuGeneroDataGridViewTextBoxColumn.Name = "AcuGeneroDataGridViewTextBoxColumn"
        Me.AcuGeneroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuEstadoCivilDataGridViewTextBoxColumn
        '
        Me.AcuEstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "Acu_Estado_Civil"
        Me.AcuEstadoCivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil"
        Me.AcuEstadoCivilDataGridViewTextBoxColumn.Name = "AcuEstadoCivilDataGridViewTextBoxColumn"
        Me.AcuEstadoCivilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuAliasDataGridViewTextBoxColumn
        '
        Me.AcuAliasDataGridViewTextBoxColumn.DataPropertyName = "Acu_Alias"
        Me.AcuAliasDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.AcuAliasDataGridViewTextBoxColumn.Name = "AcuAliasDataGridViewTextBoxColumn"
        Me.AcuAliasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuNivelEduDataGridViewTextBoxColumn
        '
        Me.AcuNivelEduDataGridViewTextBoxColumn.DataPropertyName = "Acu_Nivel_Edu"
        Me.AcuNivelEduDataGridViewTextBoxColumn.HeaderText = "Nivel edu"
        Me.AcuNivelEduDataGridViewTextBoxColumn.Name = "AcuNivelEduDataGridViewTextBoxColumn"
        Me.AcuNivelEduDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuPaisDataGridViewTextBoxColumn
        '
        Me.AcuPaisDataGridViewTextBoxColumn.DataPropertyName = "Acu_Pais"
        Me.AcuPaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.AcuPaisDataGridViewTextBoxColumn.Name = "AcuPaisDataGridViewTextBoxColumn"
        Me.AcuPaisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuDeptoDataGridViewTextBoxColumn
        '
        Me.AcuDeptoDataGridViewTextBoxColumn.DataPropertyName = "Acu_Depto"
        Me.AcuDeptoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.AcuDeptoDataGridViewTextBoxColumn.Name = "AcuDeptoDataGridViewTextBoxColumn"
        Me.AcuDeptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuCiudadDataGridViewTextBoxColumn
        '
        Me.AcuCiudadDataGridViewTextBoxColumn.DataPropertyName = "Acu_Ciudad"
        Me.AcuCiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.AcuCiudadDataGridViewTextBoxColumn.Name = "AcuCiudadDataGridViewTextBoxColumn"
        Me.AcuCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuCalleDataGridViewTextBoxColumn
        '
        Me.AcuCalleDataGridViewTextBoxColumn.DataPropertyName = "Acu_Calle"
        Me.AcuCalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.AcuCalleDataGridViewTextBoxColumn.Name = "AcuCalleDataGridViewTextBoxColumn"
        Me.AcuCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuExtraDataGridViewTextBoxColumn
        '
        Me.AcuExtraDataGridViewTextBoxColumn.DataPropertyName = "Acu_Extra"
        Me.AcuExtraDataGridViewTextBoxColumn.HeaderText = "Extra"
        Me.AcuExtraDataGridViewTextBoxColumn.Name = "AcuExtraDataGridViewTextBoxColumn"
        Me.AcuExtraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuNacidoelDataGridViewTextBoxColumn
        '
        Me.AcuNacidoelDataGridViewTextBoxColumn.DataPropertyName = "Acu_Nacido_el"
        Me.AcuNacidoelDataGridViewTextBoxColumn.HeaderText = "Nacio el"
        Me.AcuNacidoelDataGridViewTextBoxColumn.Name = "AcuNacidoelDataGridViewTextBoxColumn"
        Me.AcuNacidoelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuNacionalidadDataGridViewTextBoxColumn
        '
        Me.AcuNacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Acu_Nacionalidad"
        Me.AcuNacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad"
        Me.AcuNacionalidadDataGridViewTextBoxColumn.Name = "AcuNacionalidadDataGridViewTextBoxColumn"
        Me.AcuNacionalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuPaisNacidoDataGridViewTextBoxColumn
        '
        Me.AcuPaisNacidoDataGridViewTextBoxColumn.DataPropertyName = "Acu_Pais_Nacido"
        Me.AcuPaisNacidoDataGridViewTextBoxColumn.HeaderText = "Pais Nacido"
        Me.AcuPaisNacidoDataGridViewTextBoxColumn.Name = "AcuPaisNacidoDataGridViewTextBoxColumn"
        Me.AcuPaisNacidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuDeptoNacidoDataGridViewTextBoxColumn
        '
        Me.AcuDeptoNacidoDataGridViewTextBoxColumn.DataPropertyName = "Acu_Depto_Nacido"
        Me.AcuDeptoNacidoDataGridViewTextBoxColumn.HeaderText = "Depto Nacido"
        Me.AcuDeptoNacidoDataGridViewTextBoxColumn.Name = "AcuDeptoNacidoDataGridViewTextBoxColumn"
        Me.AcuDeptoNacidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuCiudadNacidoDataGridViewTextBoxColumn
        '
        Me.AcuCiudadNacidoDataGridViewTextBoxColumn.DataPropertyName = "Acu_Ciudad_Nacido"
        Me.AcuCiudadNacidoDataGridViewTextBoxColumn.HeaderText = "Ciudad Nacido"
        Me.AcuCiudadNacidoDataGridViewTextBoxColumn.Name = "AcuCiudadNacidoDataGridViewTextBoxColumn"
        Me.AcuCiudadNacidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuAlturamDataGridViewTextBoxColumn
        '
        Me.AcuAlturamDataGridViewTextBoxColumn.DataPropertyName = "Acu_Altura_m"
        Me.AcuAlturamDataGridViewTextBoxColumn.HeaderText = "Altura (m)"
        Me.AcuAlturamDataGridViewTextBoxColumn.Name = "AcuAlturamDataGridViewTextBoxColumn"
        Me.AcuAlturamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuPesolbDataGridViewTextBoxColumn
        '
        Me.AcuPesolbDataGridViewTextBoxColumn.DataPropertyName = "Acu_Peso_lb"
        Me.AcuPesolbDataGridViewTextBoxColumn.HeaderText = "Peso (lb)"
        Me.AcuPesolbDataGridViewTextBoxColumn.Name = "AcuPesolbDataGridViewTextBoxColumn"
        Me.AcuPesolbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuPielDataGridViewTextBoxColumn
        '
        Me.AcuPielDataGridViewTextBoxColumn.DataPropertyName = "Acu_Piel"
        Me.AcuPielDataGridViewTextBoxColumn.HeaderText = "Piel"
        Me.AcuPielDataGridViewTextBoxColumn.Name = "AcuPielDataGridViewTextBoxColumn"
        Me.AcuPielDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuPeloDataGridViewTextBoxColumn
        '
        Me.AcuPeloDataGridViewTextBoxColumn.DataPropertyName = "Acu_Pelo"
        Me.AcuPeloDataGridViewTextBoxColumn.HeaderText = "Pelo"
        Me.AcuPeloDataGridViewTextBoxColumn.Name = "AcuPeloDataGridViewTextBoxColumn"
        Me.AcuPeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuOjosDataGridViewTextBoxColumn
        '
        Me.AcuOjosDataGridViewTextBoxColumn.DataPropertyName = "Acu_Ojos"
        Me.AcuOjosDataGridViewTextBoxColumn.HeaderText = "Ojos"
        Me.AcuOjosDataGridViewTextBoxColumn.Name = "AcuOjosDataGridViewTextBoxColumn"
        Me.AcuOjosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcuOcupacionDataGridViewTextBoxColumn
        '
        Me.AcuOcupacionDataGridViewTextBoxColumn.DataPropertyName = "Acu_Ocupacion"
        Me.AcuOcupacionDataGridViewTextBoxColumn.HeaderText = "Ocupacion"
        Me.AcuOcupacionDataGridViewTextBoxColumn.Name = "AcuOcupacionDataGridViewTextBoxColumn"
        Me.AcuOcupacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_AcusadoBindingSource
        '
        Me.TBL_AcusadoBindingSource.DataMember = "TBL_Acusado"
        Me.TBL_AcusadoBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'TBL_AcusadoTableAdapter
        '
        Me.TBL_AcusadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_Abogado_EmailTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Abogado_TelTableAdapter = Nothing
        Me.TableAdapterManager.TBL_AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_EmailTableAdapter = Me.TBL_Acusado_EmailTableAdapter
        Me.TableAdapterManager.TBL_Acusado_FotoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_HistorialTableAdapter = Me.TBL_Acusado_HistorialTableAdapter
        Me.TableAdapterManager.TBL_Acusado_RasgoTableAdapter = Me.TBL_Acusado_RasgoTableAdapter
        Me.TableAdapterManager.TBL_Acusado_TelTableAdapter = Me.TBL_Acusado_TelTableAdapter
        Me.TableAdapterManager.TBL_AcusadoTableAdapter = Me.TBL_AcusadoTableAdapter
        Me.TableAdapterManager.TBL_AsociadosTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BitacoraTableAdapter = Nothing
        Me.TableAdapterManager.TBL_CuentanTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DelitoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_EvidenciaTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Expediente_MotivoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Expediente_ObservacionesTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ExpedienteTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Fiscalia_EmailTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Fiscalia_TelTableAdapter = Nothing
        Me.TableAdapterManager.TBL_FiscaliaTableAdapter = Nothing
        Me.TableAdapterManager.TBL_UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_Acusado_EmailTableAdapter
        '
        Me.TBL_Acusado_EmailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Acusado_HistorialTableAdapter
        '
        Me.TBL_Acusado_HistorialTableAdapter.ClearBeforeFill = True
        '
        'TBL_Acusado_RasgoTableAdapter
        '
        Me.TBL_Acusado_RasgoTableAdapter.ClearBeforeFill = True
        '
        'TBL_Acusado_TelTableAdapter
        '
        Me.TBL_Acusado_TelTableAdapter.ClearBeforeFill = True
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(405, 488)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 81
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(460, 492)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 80
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(240, 492)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 79
        Me.Btn_Guardar.Text = "Guardad"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.Navy
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(16, 492)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 78
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(661, 492)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 82
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'Frm_Acusados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(500, 564)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Controls.Add(Me.Tap_Informacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Acusados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de acusados"
        CType(Me.Nud_Alto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nud_Peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto_Izquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto_Frente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto_derecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tap_Informacion.ResumeLayout(False)
        Me.TabP_Personal.ResumeLayout(False)
        Me.TabP_Personal.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabP_Apariencia.ResumeLayout(False)
        Me.TabP_Apariencia.PerformLayout()
        CType(Me.TBL_Acusado_RasgoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Acusado_RasgoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabP_Contacto.ResumeLayout(False)
        Me.TabP_Contacto.PerformLayout()
        CType(Me.TBL_Acusado_TelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Acusado_TelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Acusado_EmailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Acusado_EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabP_Historial.ResumeLayout(False)
        Me.TabP_Historial.PerformLayout()
        CType(Me.Tabla_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Acusado_HistorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_AcusadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txt_Rasgo As TextBox
    Friend WithEvents Nud_Alto As NumericUpDown
    Friend WithEvents Nud_Peso As NumericUpDown
    Friend WithEvents Btn_izquierda_e As Button
    Friend WithEvents Btn_izquierda_a As Button
    Friend WithEvents Btn_frente_e As Button
    Friend WithEvents Btn_frente_a As Button
    Friend WithEvents Btn_derecho_e As Button
    Friend WithEvents Btn_derecho_a As Button
    Friend WithEvents Foto_Izquierda As PictureBox
    Friend WithEvents Foto_Frente As PictureBox
    Friend WithEvents Foto_derecha As PictureBox
    Friend WithEvents Txt_Extra As TextBox
    Friend WithEvents Txt_Calle As TextBox
    Friend WithEvents Txt_Ciudad As TextBox
    Friend WithEvents Text_Depto As TextBox
    Friend WithEvents Txt_Pais As TextBox
    Friend WithEvents Txt_Tel As TextBox
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Tap_Informacion As TabControl
    Friend WithEvents TabP_Personal As TabPage
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabP_Apariencia As TabPage
    Friend WithEvents Label28 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Combo_Genero As ComboBox
    Friend WithEvents Combo_Ojos As ComboBox
    Friend WithEvents Combo_Pelo As ComboBox
    Friend WithEvents Combo_Piel As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabP_Contacto As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TabP_Historial As TabPage
    Friend WithEvents Tabla_Historial As DataGridView
    Friend WithEvents Label29 As Label
    Friend WithEvents Txt_Nombre2 As TextBox
    Friend WithEvents Txt_Nombre1 As TextBox
    Friend WithEvents Txt_Id As TextBox
    Friend WithEvents Txt_Apellido2 As TextBox
    Friend WithEvents Txt_Apellido1 As TextBox
    Friend WithEvents Txt_Ocupacion As TextBox
    Friend WithEvents Date_Fecha As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Txt_Ciudad_O As TextBox
    Friend WithEvents Txt_Depto_o As TextBox
    Friend WithEvents Txt_Pais_O As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Combo_Estado As ComboBox
    Friend WithEvents Combo_Edu As ComboBox
    Friend WithEvents Txt_Alias As TextBox
    Friend WithEvents Txt_Nacionalidad As TextBox
    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_AcusadoBindingSource As BindingSource
    Friend WithEvents TBL_AcusadoTableAdapter As BDAcusadosDataSetTableAdapters.TBL_AcusadoTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
    Friend WithEvents AcuCADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuNombre1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuNombre2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuApellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuApellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuGeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuEstadoCivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuAliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuNivelEduDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuPaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuDeptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuExtraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuNacidoelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuNacionalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuPaisNacidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuDeptoNacidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuCiudadNacidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuAlturamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuPesolbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuPielDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuPeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuOjosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuOcupacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTN_Rasgos As Button
    Friend WithEvents TBL_Acusado_RasgoTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Acusado_RasgoTableAdapter
    Friend WithEvents TBL_Acusado_RasgoBindingSource As BindingSource
    Friend WithEvents TBL_Acusado_RasgoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Tel As Button
    Friend WithEvents BTN_Email As Button
    Friend WithEvents TBL_Acusado_HistorialTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Acusado_HistorialTableAdapter
    Friend WithEvents TBL_Acusado_HistorialBindingSource As BindingSource
    Friend WithEvents AcuCADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AcuDelitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcuDescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TBL_Acusado_EmailTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Acusado_EmailTableAdapter
    Friend WithEvents TBL_Acusado_EmailBindingSource As BindingSource
    Friend WithEvents TBL_Acusado_EmailDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TBL_Acusado_TelTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Acusado_TelTableAdapter
    Friend WithEvents TBL_Acusado_TelBindingSource As BindingSource
    Friend WithEvents TBL_Acusado_TelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Btn_Cancelar As Button
End Class
