<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Abogado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Abogado))
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AboCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboGeneroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboNCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboFechaCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboInicioEjercDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboNombre1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboNombre2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboApellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboApellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboDeptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboExtraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_AbogadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Tap_Informacion = New System.Windows.Forms.TabControl()
        Me.TabP_Personal = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Date_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Date_FechaC = New System.Windows.Forms.DateTimePicker()
        Me.TXT_ColegiacionN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Combo_Genero = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Extra = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Txt_Calle = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Txt_depto = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Txt_ciudad = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Txt_Pais = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Txt_Apellido2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Apellido1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Nombre2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Nombre1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabP_Contacto = New System.Windows.Forms.TabPage()
        Me.TBL_Abogado_TelDataGridView = New System.Windows.Forms.DataGridView()
        Me.AboCIADataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Abogado_TelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_Abogado_EmailDataGridView = New System.Windows.Forms.DataGridView()
        Me.AboCIADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AboEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Abogado_EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_tel = New System.Windows.Forms.Button()
        Me.BTN_Email = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Txt_Tel = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.TBL_AbogadoTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_AbogadoTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.TBL_Abogado_EmailTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Abogado_EmailTableAdapter()
        Me.TBL_Abogado_TelTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Abogado_TelTableAdapter()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_AbogadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tap_Informacion.SuspendLayout()
        Me.TabP_Personal.SuspendLayout()
        Me.TabP_Contacto.SuspendLayout()
        CType(Me.TBL_Abogado_TelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Abogado_TelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Abogado_EmailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Abogado_EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Acusados.Controls.Add(Me.datalistado)
        Me.gb_Acusados.Controls.Add(Me.BtnEliminar)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(11, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(334, 532)
        Me.gb_Acusados.TabIndex = 77
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de Abogado"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoGenerateColumns = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.AboCIADataGridViewTextBoxColumn, Me.AboIDDataGridViewTextBoxColumn, Me.AboGeneroDataGridViewTextBoxColumn, Me.AboNCDataGridViewTextBoxColumn, Me.AboFechaCDataGridViewTextBoxColumn, Me.AboInicioEjercDataGridViewTextBoxColumn, Me.AboNombre1DataGridViewTextBoxColumn, Me.AboNombre2DataGridViewTextBoxColumn, Me.AboApellido1DataGridViewTextBoxColumn, Me.AboApellido2DataGridViewTextBoxColumn, Me.AboPaisDataGridViewTextBoxColumn, Me.AboDeptoDataGridViewTextBoxColumn, Me.AboCiudadDataGridViewTextBoxColumn, Me.AboCalleDataGridViewTextBoxColumn, Me.AboExtraDataGridViewTextBoxColumn})
        Me.datalistado.DataSource = Me.TBL_AbogadoBindingSource
        Me.datalistado.Location = New System.Drawing.Point(15, 28)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(313, 434)
        Me.datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'AboCIADataGridViewTextBoxColumn
        '
        Me.AboCIADataGridViewTextBoxColumn.DataPropertyName = "Abo_CIA"
        Me.AboCIADataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.AboCIADataGridViewTextBoxColumn.Name = "AboCIADataGridViewTextBoxColumn"
        Me.AboCIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboIDDataGridViewTextBoxColumn
        '
        Me.AboIDDataGridViewTextBoxColumn.DataPropertyName = "Abo_ID"
        Me.AboIDDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.AboIDDataGridViewTextBoxColumn.Name = "AboIDDataGridViewTextBoxColumn"
        Me.AboIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboGeneroDataGridViewTextBoxColumn
        '
        Me.AboGeneroDataGridViewTextBoxColumn.DataPropertyName = "Abo_Genero"
        Me.AboGeneroDataGridViewTextBoxColumn.HeaderText = "Genero"
        Me.AboGeneroDataGridViewTextBoxColumn.Name = "AboGeneroDataGridViewTextBoxColumn"
        Me.AboGeneroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboNCDataGridViewTextBoxColumn
        '
        Me.AboNCDataGridViewTextBoxColumn.DataPropertyName = "Abo_NC"
        Me.AboNCDataGridViewTextBoxColumn.HeaderText = "Colegiacion N"
        Me.AboNCDataGridViewTextBoxColumn.Name = "AboNCDataGridViewTextBoxColumn"
        Me.AboNCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboFechaCDataGridViewTextBoxColumn
        '
        Me.AboFechaCDataGridViewTextBoxColumn.DataPropertyName = "Abo_Fecha_C"
        Me.AboFechaCDataGridViewTextBoxColumn.HeaderText = "Fecha Colegiacion"
        Me.AboFechaCDataGridViewTextBoxColumn.Name = "AboFechaCDataGridViewTextBoxColumn"
        Me.AboFechaCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboInicioEjercDataGridViewTextBoxColumn
        '
        Me.AboInicioEjercDataGridViewTextBoxColumn.DataPropertyName = "Abo_Inicio_Ejerc"
        Me.AboInicioEjercDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio"
        Me.AboInicioEjercDataGridViewTextBoxColumn.Name = "AboInicioEjercDataGridViewTextBoxColumn"
        Me.AboInicioEjercDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboNombre1DataGridViewTextBoxColumn
        '
        Me.AboNombre1DataGridViewTextBoxColumn.DataPropertyName = "Abo_Nombre1"
        Me.AboNombre1DataGridViewTextBoxColumn.HeaderText = "1ro Nombre"
        Me.AboNombre1DataGridViewTextBoxColumn.Name = "AboNombre1DataGridViewTextBoxColumn"
        Me.AboNombre1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboNombre2DataGridViewTextBoxColumn
        '
        Me.AboNombre2DataGridViewTextBoxColumn.DataPropertyName = "Abo_Nombre2"
        Me.AboNombre2DataGridViewTextBoxColumn.HeaderText = "2do Nombre"
        Me.AboNombre2DataGridViewTextBoxColumn.Name = "AboNombre2DataGridViewTextBoxColumn"
        Me.AboNombre2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboApellido1DataGridViewTextBoxColumn
        '
        Me.AboApellido1DataGridViewTextBoxColumn.DataPropertyName = "Abo_Apellido1"
        Me.AboApellido1DataGridViewTextBoxColumn.HeaderText = "1ro Apellido"
        Me.AboApellido1DataGridViewTextBoxColumn.Name = "AboApellido1DataGridViewTextBoxColumn"
        Me.AboApellido1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboApellido2DataGridViewTextBoxColumn
        '
        Me.AboApellido2DataGridViewTextBoxColumn.DataPropertyName = "Abo_Apellido2"
        Me.AboApellido2DataGridViewTextBoxColumn.HeaderText = "2do Apellido"
        Me.AboApellido2DataGridViewTextBoxColumn.Name = "AboApellido2DataGridViewTextBoxColumn"
        Me.AboApellido2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboPaisDataGridViewTextBoxColumn
        '
        Me.AboPaisDataGridViewTextBoxColumn.DataPropertyName = "Abo_Pais"
        Me.AboPaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.AboPaisDataGridViewTextBoxColumn.Name = "AboPaisDataGridViewTextBoxColumn"
        Me.AboPaisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboDeptoDataGridViewTextBoxColumn
        '
        Me.AboDeptoDataGridViewTextBoxColumn.DataPropertyName = "Abo_Depto"
        Me.AboDeptoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.AboDeptoDataGridViewTextBoxColumn.Name = "AboDeptoDataGridViewTextBoxColumn"
        Me.AboDeptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboCiudadDataGridViewTextBoxColumn
        '
        Me.AboCiudadDataGridViewTextBoxColumn.DataPropertyName = "Abo_Ciudad"
        Me.AboCiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.AboCiudadDataGridViewTextBoxColumn.Name = "AboCiudadDataGridViewTextBoxColumn"
        Me.AboCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboCalleDataGridViewTextBoxColumn
        '
        Me.AboCalleDataGridViewTextBoxColumn.DataPropertyName = "Abo_Calle"
        Me.AboCalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.AboCalleDataGridViewTextBoxColumn.Name = "AboCalleDataGridViewTextBoxColumn"
        Me.AboCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AboExtraDataGridViewTextBoxColumn
        '
        Me.AboExtraDataGridViewTextBoxColumn.DataPropertyName = "Abo_Extra"
        Me.AboExtraDataGridViewTextBoxColumn.HeaderText = "Extra"
        Me.AboExtraDataGridViewTextBoxColumn.Name = "AboExtraDataGridViewTextBoxColumn"
        Me.AboExtraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_AbogadoBindingSource
        '
        Me.TBL_AbogadoBindingSource.DataMember = "TBL_Abogado"
        Me.TBL_AbogadoBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BDAcusadosDataSet
        '
        Me.BDAcusadosDataSet.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Navy
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(130, 468)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Tap_Informacion
        '
        Me.Tap_Informacion.Controls.Add(Me.TabP_Personal)
        Me.Tap_Informacion.Controls.Add(Me.TabP_Contacto)
        Me.Tap_Informacion.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tap_Informacion.Location = New System.Drawing.Point(12, 12)
        Me.Tap_Informacion.Name = "Tap_Informacion"
        Me.Tap_Informacion.SelectedIndex = 0
        Me.Tap_Informacion.Size = New System.Drawing.Size(323, 532)
        Me.Tap_Informacion.TabIndex = 78
        '
        'TabP_Personal
        '
        Me.TabP_Personal.Controls.Add(Me.Label10)
        Me.TabP_Personal.Controls.Add(Me.Date_Inicio)
        Me.TabP_Personal.Controls.Add(Me.Label9)
        Me.TabP_Personal.Controls.Add(Me.Date_FechaC)
        Me.TabP_Personal.Controls.Add(Me.TXT_ColegiacionN)
        Me.TabP_Personal.Controls.Add(Me.Label8)
        Me.TabP_Personal.Controls.Add(Me.Combo_Genero)
        Me.TabP_Personal.Controls.Add(Me.Label3)
        Me.TabP_Personal.Controls.Add(Me.Txt_Extra)
        Me.TabP_Personal.Controls.Add(Me.Label43)
        Me.TabP_Personal.Controls.Add(Me.Txt_Calle)
        Me.TabP_Personal.Controls.Add(Me.Label42)
        Me.TabP_Personal.Controls.Add(Me.Txt_depto)
        Me.TabP_Personal.Controls.Add(Me.Label40)
        Me.TabP_Personal.Controls.Add(Me.Txt_ciudad)
        Me.TabP_Personal.Controls.Add(Me.Label41)
        Me.TabP_Personal.Controls.Add(Me.Txt_Pais)
        Me.TabP_Personal.Controls.Add(Me.Label36)
        Me.TabP_Personal.Controls.Add(Me.Label1)
        Me.TabP_Personal.Controls.Add(Me.Txt_ID)
        Me.TabP_Personal.Controls.Add(Me.Label2)
        Me.TabP_Personal.Controls.Add(Me.Txt_Codigo)
        Me.TabP_Personal.Controls.Add(Me.Txt_Apellido2)
        Me.TabP_Personal.Controls.Add(Me.Label7)
        Me.TabP_Personal.Controls.Add(Me.txt_Apellido1)
        Me.TabP_Personal.Controls.Add(Me.Label6)
        Me.TabP_Personal.Controls.Add(Me.Txt_Nombre2)
        Me.TabP_Personal.Controls.Add(Me.Label5)
        Me.TabP_Personal.Controls.Add(Me.Txt_Nombre1)
        Me.TabP_Personal.Controls.Add(Me.Label4)
        Me.TabP_Personal.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Personal.Name = "TabP_Personal"
        Me.TabP_Personal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Personal.Size = New System.Drawing.Size(315, 500)
        Me.TabP_Personal.TabIndex = 0
        Me.TabP_Personal.Text = "Informacion"
        Me.TabP_Personal.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion personal de un acusado en par" &
    "ticular"
        Me.TabP_Personal.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(26, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Fecha_ Inicio:"
        '
        'Date_Inicio
        '
        Me.Date_Inicio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Inicio.Location = New System.Drawing.Point(174, 173)
        Me.Date_Inicio.Name = "Date_Inicio"
        Me.Date_Inicio.Size = New System.Drawing.Size(128, 26)
        Me.Date_Inicio.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.Location = New System.Drawing.Point(26, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 18)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Colegiacion F:"
        '
        'Date_FechaC
        '
        Me.Date_FechaC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_FechaC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_FechaC.Location = New System.Drawing.Point(174, 141)
        Me.Date_FechaC.Name = "Date_FechaC"
        Me.Date_FechaC.Size = New System.Drawing.Size(128, 26)
        Me.Date_FechaC.TabIndex = 86
        '
        'TXT_ColegiacionN
        '
        Me.TXT_ColegiacionN.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.TXT_ColegiacionN.Location = New System.Drawing.Point(174, 109)
        Me.TXT_ColegiacionN.MaxLength = 50
        Me.TXT_ColegiacionN.Name = "TXT_ColegiacionN"
        Me.TXT_ColegiacionN.Size = New System.Drawing.Size(128, 26)
        Me.TXT_ColegiacionN.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(26, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Colegiacion N:"
        '
        'Combo_Genero
        '
        Me.Combo_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Genero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Genero.FormattingEnabled = True
        Me.Combo_Genero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.Combo_Genero.Location = New System.Drawing.Point(174, 76)
        Me.Combo_Genero.Name = "Combo_Genero"
        Me.Combo_Genero.Size = New System.Drawing.Size(128, 27)
        Me.Combo_Genero.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(26, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Genero:"
        '
        'Txt_Extra
        '
        Me.Txt_Extra.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Extra.Location = New System.Drawing.Point(86, 461)
        Me.Txt_Extra.MaxLength = 100
        Me.Txt_Extra.Multiline = True
        Me.Txt_Extra.Name = "Txt_Extra"
        Me.Txt_Extra.Size = New System.Drawing.Size(216, 26)
        Me.Txt_Extra.TabIndex = 81
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(27, 461)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 18)
        Me.Label43.TabIndex = 79
        Me.Label43.Text = "Extra:"
        '
        'Txt_Calle
        '
        Me.Txt_Calle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Calle.Location = New System.Drawing.Point(163, 429)
        Me.Txt_Calle.MaxLength = 50
        Me.Txt_Calle.Name = "Txt_Calle"
        Me.Txt_Calle.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Calle.TabIndex = 80
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(48, 432)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 18)
        Me.Label42.TabIndex = 77
        Me.Label42.Text = "Calle:"
        '
        'Txt_depto
        '
        Me.Txt_depto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_depto.Location = New System.Drawing.Point(163, 365)
        Me.Txt_depto.MaxLength = 50
        Me.Txt_depto.Name = "Txt_depto"
        Me.Txt_depto.Size = New System.Drawing.Size(139, 26)
        Me.Txt_depto.TabIndex = 75
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(43, 368)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(120, 18)
        Me.Label40.TabIndex = 73
        Me.Label40.Text = "Departamento:"
        '
        'Txt_ciudad
        '
        Me.Txt_ciudad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ciudad.Location = New System.Drawing.Point(163, 397)
        Me.Txt_ciudad.MaxLength = 50
        Me.Txt_ciudad.Name = "Txt_ciudad"
        Me.Txt_ciudad.Size = New System.Drawing.Size(139, 26)
        Me.Txt_ciudad.TabIndex = 78
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(43, 400)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 18)
        Me.Label41.TabIndex = 76
        Me.Label41.Text = "Ciudad:"
        '
        'Txt_Pais
        '
        Me.Txt_Pais.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pais.Location = New System.Drawing.Point(163, 333)
        Me.Txt_Pais.MaxLength = 50
        Me.Txt_Pais.Name = "Txt_Pais"
        Me.Txt_Pais.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Pais.TabIndex = 74
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(48, 336)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(46, 18)
        Me.Label36.TabIndex = 72
        Me.Label36.Text = "Pais:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Codigo:"
        '
        'Txt_ID
        '
        Me.Txt_ID.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_ID.Location = New System.Drawing.Point(174, 44)
        Me.Txt_ID.MaxLength = 50
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(128, 26)
        Me.Txt_ID.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Identidad:"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Enabled = False
        Me.Txt_Codigo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Codigo.Location = New System.Drawing.Point(174, 12)
        Me.Txt_Codigo.MaxLength = 50
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Codigo.TabIndex = 70
        '
        'Txt_Apellido2
        '
        Me.Txt_Apellido2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Apellido2.Location = New System.Drawing.Point(174, 301)
        Me.Txt_Apellido2.MaxLength = 50
        Me.Txt_Apellido2.Name = "Txt_Apellido2"
        Me.Txt_Apellido2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Apellido2.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(27, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Segundo apellido:"
        '
        'txt_Apellido1
        '
        Me.txt_Apellido1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_Apellido1.Location = New System.Drawing.Point(174, 269)
        Me.txt_Apellido1.MaxLength = 50
        Me.txt_Apellido1.Name = "txt_Apellido1"
        Me.txt_Apellido1.Size = New System.Drawing.Size(128, 26)
        Me.txt_Apellido1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(27, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Primer apellido:"
        '
        'Txt_Nombre2
        '
        Me.Txt_Nombre2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre2.Location = New System.Drawing.Point(174, 237)
        Me.Txt_Nombre2.MaxLength = 50
        Me.Txt_Nombre2.Name = "Txt_Nombre2"
        Me.Txt_Nombre2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre2.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(26, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Segundo nombre:"
        '
        'Txt_Nombre1
        '
        Me.Txt_Nombre1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre1.Location = New System.Drawing.Point(174, 205)
        Me.Txt_Nombre1.MaxLength = 50
        Me.Txt_Nombre1.Name = "Txt_Nombre1"
        Me.Txt_Nombre1.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(26, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Primer nombre:"
        '
        'TabP_Contacto
        '
        Me.TabP_Contacto.AutoScroll = True
        Me.TabP_Contacto.Controls.Add(Me.TBL_Abogado_TelDataGridView)
        Me.TabP_Contacto.Controls.Add(Me.TBL_Abogado_EmailDataGridView)
        Me.TabP_Contacto.Controls.Add(Me.BTN_tel)
        Me.TabP_Contacto.Controls.Add(Me.BTN_Email)
        Me.TabP_Contacto.Controls.Add(Me.Label44)
        Me.TabP_Contacto.Controls.Add(Me.Txt_Tel)
        Me.TabP_Contacto.Controls.Add(Me.Label45)
        Me.TabP_Contacto.Controls.Add(Me.Label46)
        Me.TabP_Contacto.Controls.Add(Me.Txt_Email)
        Me.TabP_Contacto.Controls.Add(Me.Label47)
        Me.TabP_Contacto.Location = New System.Drawing.Point(4, 28)
        Me.TabP_Contacto.Name = "TabP_Contacto"
        Me.TabP_Contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Contacto.Size = New System.Drawing.Size(315, 500)
        Me.TabP_Contacto.TabIndex = 2
        Me.TabP_Contacto.Text = "Contacto"
        Me.TabP_Contacto.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion sobre el contacto de un acusa" &
    "do en particular"
        Me.TabP_Contacto.UseVisualStyleBackColor = True
        '
        'TBL_Abogado_TelDataGridView
        '
        Me.TBL_Abogado_TelDataGridView.AllowUserToAddRows = False
        Me.TBL_Abogado_TelDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Abogado_TelDataGridView.AutoGenerateColumns = False
        Me.TBL_Abogado_TelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Abogado_TelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AboCIADataGridViewTextBoxColumn2, Me.AboTelDataGridViewTextBoxColumn})
        Me.TBL_Abogado_TelDataGridView.DataSource = Me.TBL_Abogado_TelBindingSource
        Me.TBL_Abogado_TelDataGridView.Location = New System.Drawing.Point(17, 258)
        Me.TBL_Abogado_TelDataGridView.Name = "TBL_Abogado_TelDataGridView"
        Me.TBL_Abogado_TelDataGridView.ReadOnly = True
        Me.TBL_Abogado_TelDataGridView.Size = New System.Drawing.Size(142, 156)
        Me.TBL_Abogado_TelDataGridView.TabIndex = 64
        '
        'AboCIADataGridViewTextBoxColumn2
        '
        Me.AboCIADataGridViewTextBoxColumn2.DataPropertyName = "Abo_CIA"
        Me.AboCIADataGridViewTextBoxColumn2.HeaderText = "Abo_CIA"
        Me.AboCIADataGridViewTextBoxColumn2.Name = "AboCIADataGridViewTextBoxColumn2"
        Me.AboCIADataGridViewTextBoxColumn2.ReadOnly = True
        Me.AboCIADataGridViewTextBoxColumn2.Visible = False
        '
        'AboTelDataGridViewTextBoxColumn
        '
        Me.AboTelDataGridViewTextBoxColumn.DataPropertyName = "Abo_Tel"
        Me.AboTelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.AboTelDataGridViewTextBoxColumn.Name = "AboTelDataGridViewTextBoxColumn"
        Me.AboTelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_Abogado_TelBindingSource
        '
        Me.TBL_Abogado_TelBindingSource.DataMember = "TBL_Abogado_Tel"
        Me.TBL_Abogado_TelBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'TBL_Abogado_EmailDataGridView
        '
        Me.TBL_Abogado_EmailDataGridView.AllowUserToAddRows = False
        Me.TBL_Abogado_EmailDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Abogado_EmailDataGridView.AutoGenerateColumns = False
        Me.TBL_Abogado_EmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Abogado_EmailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AboCIADataGridViewTextBoxColumn1, Me.AboEmailDataGridViewTextBoxColumn})
        Me.TBL_Abogado_EmailDataGridView.DataSource = Me.TBL_Abogado_EmailBindingSource
        Me.TBL_Abogado_EmailDataGridView.Location = New System.Drawing.Point(6, 39)
        Me.TBL_Abogado_EmailDataGridView.Name = "TBL_Abogado_EmailDataGridView"
        Me.TBL_Abogado_EmailDataGridView.ReadOnly = True
        Me.TBL_Abogado_EmailDataGridView.Size = New System.Drawing.Size(146, 134)
        Me.TBL_Abogado_EmailDataGridView.TabIndex = 63
        '
        'AboCIADataGridViewTextBoxColumn1
        '
        Me.AboCIADataGridViewTextBoxColumn1.DataPropertyName = "Abo_CIA"
        Me.AboCIADataGridViewTextBoxColumn1.HeaderText = "Abo_CIA"
        Me.AboCIADataGridViewTextBoxColumn1.Name = "AboCIADataGridViewTextBoxColumn1"
        Me.AboCIADataGridViewTextBoxColumn1.ReadOnly = True
        Me.AboCIADataGridViewTextBoxColumn1.Visible = False
        '
        'AboEmailDataGridViewTextBoxColumn
        '
        Me.AboEmailDataGridViewTextBoxColumn.DataPropertyName = "Abo_Email"
        Me.AboEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.AboEmailDataGridViewTextBoxColumn.Name = "AboEmailDataGridViewTextBoxColumn"
        Me.AboEmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_Abogado_EmailBindingSource
        '
        Me.TBL_Abogado_EmailBindingSource.DataMember = "TBL_Abogado_Email"
        Me.TBL_Abogado_EmailBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BTN_tel
        '
        Me.BTN_tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_tel.Location = New System.Drawing.Point(199, 347)
        Me.BTN_tel.Name = "BTN_tel"
        Me.BTN_tel.Size = New System.Drawing.Size(57, 23)
        Me.BTN_tel.TabIndex = 63
        Me.BTN_tel.Text = "Add"
        Me.BTN_tel.UseVisualStyleBackColor = True
        '
        'BTN_Email
        '
        Me.BTN_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Email.Location = New System.Drawing.Point(199, 115)
        Me.BTN_Email.Name = "BTN_Email"
        Me.BTN_Email.Size = New System.Drawing.Size(57, 23)
        Me.BTN_Email.TabIndex = 60
        Me.BTN_Email.Text = "Add"
        Me.BTN_Email.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(18, 237)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(141, 18)
        Me.Label44.TabIndex = 59
        Me.Label44.Text = "Tel de la Abogado"
        '
        'Txt_Tel
        '
        Me.Txt_Tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tel.Location = New System.Drawing.Point(163, 315)
        Me.Txt_Tel.MaxLength = 15
        Me.Txt_Tel.Name = "Txt_Tel"
        Me.Txt_Tel.Size = New System.Drawing.Size(131, 26)
        Me.Txt_Tel.TabIndex = 57
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(187, 294)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 18)
        Me.Label45.TabIndex = 56
        Me.Label45.Text = "Elemento"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(18, 17)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(179, 18)
        Me.Label46.TabIndex = 55
        Me.Label46.Text = "Correos de la abogado"
        '
        'Txt_Email
        '
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(158, 83)
        Me.Txt_Email.MaxLength = 100
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(152, 26)
        Me.Txt_Email.TabIndex = 53
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(196, 62)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 18)
        Me.Label47.TabIndex = 51
        Me.Label47.Text = "Elemento"
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(260, 550)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 75
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(291, 550)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 74
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(156, 550)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 73
        Me.Btn_Guardar.Text = "Guardad"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.Navy
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(15, 550)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 72
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(446, 550)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 76
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'TBL_AbogadoTableAdapter
        '
        Me.TBL_AbogadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_Abogado_EmailTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Abogado_TelTableAdapter = Nothing
        Me.TableAdapterManager.TBL_AbogadoTableAdapter = Me.TBL_AbogadoTableAdapter
        Me.TableAdapterManager.TBL_Acusado_EmailTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_FotoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_HistorialTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_RasgoTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Acusado_TelTableAdapter = Nothing
        Me.TableAdapterManager.TBL_AcusadoTableAdapter = Nothing
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
        'TBL_Abogado_EmailTableAdapter
        '
        Me.TBL_Abogado_EmailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Abogado_TelTableAdapter
        '
        Me.TBL_Abogado_TelTableAdapter.ClearBeforeFill = True
        '
        'Frm_Abogado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(361, 616)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Controls.Add(Me.Tap_Informacion)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Abogado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de abogados"
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_AbogadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tap_Informacion.ResumeLayout(False)
        Me.TabP_Personal.ResumeLayout(False)
        Me.TabP_Personal.PerformLayout()
        Me.TabP_Contacto.ResumeLayout(False)
        Me.TabP_Contacto.PerformLayout()
        CType(Me.TBL_Abogado_TelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Abogado_TelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Abogado_EmailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Abogado_EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Tap_Informacion As TabControl
    Friend WithEvents TabP_Personal As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Extra As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Txt_Calle As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Txt_depto As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Txt_ciudad As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Txt_Pais As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Txt_Apellido2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Apellido1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Nombre2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Nombre1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabP_Contacto As TabPage
    Friend WithEvents TBL_Abogado_EmailDataGridView As DataGridView
    Friend WithEvents BTN_tel As Button
    Friend WithEvents BTN_Email As Button
    Friend WithEvents Label44 As Label
    Friend WithEvents Txt_Tel As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents TXT_ColegiacionN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Combo_Genero As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Date_Inicio As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Date_FechaC As DateTimePicker
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_AbogadoBindingSource As BindingSource
    Friend WithEvents TBL_AbogadoTableAdapter As BDAcusadosDataSetTableAdapters.TBL_AbogadoTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents AboCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboGeneroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboNCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboFechaCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboInicioEjercDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboNombre1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboNombre2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboApellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboApellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboPaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboDeptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AboExtraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TBL_Abogado_EmailBindingSource As BindingSource
    Friend WithEvents TBL_Abogado_EmailTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Abogado_EmailTableAdapter
    Friend WithEvents AboCIADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AboEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TBL_Abogado_TelBindingSource As BindingSource
    Friend WithEvents TBL_Abogado_TelTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Abogado_TelTableAdapter
    Friend WithEvents TBL_Abogado_TelDataGridView As DataGridView
    Friend WithEvents AboCIADataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AboTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
