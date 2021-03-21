<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Fiscalia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Fiscalia))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FisCFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisNombre1AdmiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisNombre2AdmiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisApellido1AdmiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisApellido2AdmiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisDeptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisExtraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_FiscaliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Tap_Informacion = New System.Windows.Forms.TabControl()
        Me.TabP_Personal = New System.Windows.Forms.TabPage()
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
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
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
        Me.TBL_Fiscalia_TelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Fiscalia_TelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_Fiscalia_EmailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_Fiscalia_EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_tel = New System.Windows.Forms.Button()
        Me.BTN_Email = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Txt_Tel = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TBL_FiscaliaTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_FiscaliaTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.TBL_Fiscalia_EmailTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Fiscalia_EmailTableAdapter()
        Me.TBL_Fiscalia_TelTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_Fiscalia_TelTableAdapter()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_FiscaliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tap_Informacion.SuspendLayout()
        Me.TabP_Personal.SuspendLayout()
        Me.TabP_Contacto.SuspendLayout()
        CType(Me.TBL_Fiscalia_TelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Fiscalia_TelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Fiscalia_EmailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_Fiscalia_EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(261, 492)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 42
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(291, 492)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 41
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(156, 492)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 40
        Me.Btn_Guardar.Text = "Guardad"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.Navy
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(15, 492)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 39
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(446, 492)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 43
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Acusados.Controls.Add(Me.datalistado)
        Me.gb_Acusados.Controls.Add(Me.BtnEliminar)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(12, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(334, 474)
        Me.gb_Acusados.TabIndex = 45
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de Fiscalias"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AutoGenerateColumns = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.FisCFDataGridViewTextBoxColumn, Me.FisNombreDataGridViewTextBoxColumn, Me.FisNombre1AdmiDataGridViewTextBoxColumn, Me.FisNombre2AdmiDataGridViewTextBoxColumn, Me.FisApellido1AdmiDataGridViewTextBoxColumn, Me.FisApellido2AdmiDataGridViewTextBoxColumn, Me.FisPaisDataGridViewTextBoxColumn, Me.FisDeptoDataGridViewTextBoxColumn, Me.FisCiudadDataGridViewTextBoxColumn, Me.FisCalleDataGridViewTextBoxColumn, Me.FisExtraDataGridViewTextBoxColumn})
        Me.datalistado.DataSource = Me.TBL_FiscaliaBindingSource
        Me.datalistado.Location = New System.Drawing.Point(15, 28)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(313, 370)
        Me.datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'FisCFDataGridViewTextBoxColumn
        '
        Me.FisCFDataGridViewTextBoxColumn.DataPropertyName = "Fis_CF"
        Me.FisCFDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.FisCFDataGridViewTextBoxColumn.Name = "FisCFDataGridViewTextBoxColumn"
        Me.FisCFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisNombreDataGridViewTextBoxColumn
        '
        Me.FisNombreDataGridViewTextBoxColumn.DataPropertyName = "Fis_Nombre"
        Me.FisNombreDataGridViewTextBoxColumn.HeaderText = "Nombre fiscalia"
        Me.FisNombreDataGridViewTextBoxColumn.Name = "FisNombreDataGridViewTextBoxColumn"
        Me.FisNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisNombre1AdmiDataGridViewTextBoxColumn
        '
        Me.FisNombre1AdmiDataGridViewTextBoxColumn.DataPropertyName = "Fis_Nombre1_Admi"
        Me.FisNombre1AdmiDataGridViewTextBoxColumn.HeaderText = "1ro nombre admi"
        Me.FisNombre1AdmiDataGridViewTextBoxColumn.Name = "FisNombre1AdmiDataGridViewTextBoxColumn"
        Me.FisNombre1AdmiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisNombre2AdmiDataGridViewTextBoxColumn
        '
        Me.FisNombre2AdmiDataGridViewTextBoxColumn.DataPropertyName = "Fis_Nombre2_Admi"
        Me.FisNombre2AdmiDataGridViewTextBoxColumn.HeaderText = "2do nombre admi"
        Me.FisNombre2AdmiDataGridViewTextBoxColumn.Name = "FisNombre2AdmiDataGridViewTextBoxColumn"
        Me.FisNombre2AdmiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisApellido1AdmiDataGridViewTextBoxColumn
        '
        Me.FisApellido1AdmiDataGridViewTextBoxColumn.DataPropertyName = "Fis_Apellido1_Admi"
        Me.FisApellido1AdmiDataGridViewTextBoxColumn.HeaderText = "1ro apellido admi"
        Me.FisApellido1AdmiDataGridViewTextBoxColumn.Name = "FisApellido1AdmiDataGridViewTextBoxColumn"
        Me.FisApellido1AdmiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisApellido2AdmiDataGridViewTextBoxColumn
        '
        Me.FisApellido2AdmiDataGridViewTextBoxColumn.DataPropertyName = "Fis_Apellido2_Admi"
        Me.FisApellido2AdmiDataGridViewTextBoxColumn.HeaderText = "2do apellido admi"
        Me.FisApellido2AdmiDataGridViewTextBoxColumn.Name = "FisApellido2AdmiDataGridViewTextBoxColumn"
        Me.FisApellido2AdmiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisPaisDataGridViewTextBoxColumn
        '
        Me.FisPaisDataGridViewTextBoxColumn.DataPropertyName = "Fis_Pais"
        Me.FisPaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.FisPaisDataGridViewTextBoxColumn.Name = "FisPaisDataGridViewTextBoxColumn"
        Me.FisPaisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisDeptoDataGridViewTextBoxColumn
        '
        Me.FisDeptoDataGridViewTextBoxColumn.DataPropertyName = "Fis_Depto"
        Me.FisDeptoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.FisDeptoDataGridViewTextBoxColumn.Name = "FisDeptoDataGridViewTextBoxColumn"
        Me.FisDeptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisCiudadDataGridViewTextBoxColumn
        '
        Me.FisCiudadDataGridViewTextBoxColumn.DataPropertyName = "Fis_Ciudad"
        Me.FisCiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.FisCiudadDataGridViewTextBoxColumn.Name = "FisCiudadDataGridViewTextBoxColumn"
        Me.FisCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisCalleDataGridViewTextBoxColumn
        '
        Me.FisCalleDataGridViewTextBoxColumn.DataPropertyName = "Fis_Calle"
        Me.FisCalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.FisCalleDataGridViewTextBoxColumn.Name = "FisCalleDataGridViewTextBoxColumn"
        Me.FisCalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FisExtraDataGridViewTextBoxColumn
        '
        Me.FisExtraDataGridViewTextBoxColumn.DataPropertyName = "Fis_Extra"
        Me.FisExtraDataGridViewTextBoxColumn.HeaderText = "Extra"
        Me.FisExtraDataGridViewTextBoxColumn.Name = "FisExtraDataGridViewTextBoxColumn"
        Me.FisExtraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_FiscaliaBindingSource
        '
        Me.TBL_FiscaliaBindingSource.DataMember = "TBL_Fiscalia"
        Me.TBL_FiscaliaBindingSource.DataSource = Me.BDAcusadosDataSet
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
        Me.BtnEliminar.Location = New System.Drawing.Point(133, 404)
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
        Me.Tap_Informacion.Size = New System.Drawing.Size(323, 474)
        Me.Tap_Informacion.TabIndex = 71
        '
        'TabP_Personal
        '
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
        Me.TabP_Personal.Controls.Add(Me.Txt_Nombre)
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
        Me.TabP_Personal.Size = New System.Drawing.Size(315, 442)
        Me.TabP_Personal.TabIndex = 0
        Me.TabP_Personal.Text = "Informacion"
        Me.TabP_Personal.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion personal de un acusado en par" &
    "ticular"
        Me.TabP_Personal.UseVisualStyleBackColor = True
        '
        'Txt_Extra
        '
        Me.Txt_Extra.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Extra.Location = New System.Drawing.Point(17, 362)
        Me.Txt_Extra.MaxLength = 100
        Me.Txt_Extra.Multiline = True
        Me.Txt_Extra.Name = "Txt_Extra"
        Me.Txt_Extra.Size = New System.Drawing.Size(292, 68)
        Me.Txt_Extra.TabIndex = 81
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(27, 332)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 18)
        Me.Label43.TabIndex = 79
        Me.Label43.Text = "Extra:"
        '
        'Txt_Calle
        '
        Me.Txt_Calle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Calle.Location = New System.Drawing.Point(163, 300)
        Me.Txt_Calle.MaxLength = 50
        Me.Txt_Calle.Name = "Txt_Calle"
        Me.Txt_Calle.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Calle.TabIndex = 80
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(48, 303)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(51, 18)
        Me.Label42.TabIndex = 77
        Me.Label42.Text = "Calle:"
        '
        'Txt_depto
        '
        Me.Txt_depto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_depto.Location = New System.Drawing.Point(163, 236)
        Me.Txt_depto.MaxLength = 50
        Me.Txt_depto.Name = "Txt_depto"
        Me.Txt_depto.Size = New System.Drawing.Size(139, 26)
        Me.Txt_depto.TabIndex = 75
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(43, 239)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(120, 18)
        Me.Label40.TabIndex = 73
        Me.Label40.Text = "Departamento:"
        '
        'Txt_ciudad
        '
        Me.Txt_ciudad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ciudad.Location = New System.Drawing.Point(163, 268)
        Me.Txt_ciudad.MaxLength = 50
        Me.Txt_ciudad.Name = "Txt_ciudad"
        Me.Txt_ciudad.Size = New System.Drawing.Size(139, 26)
        Me.Txt_ciudad.TabIndex = 78
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(43, 271)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(66, 18)
        Me.Label41.TabIndex = 76
        Me.Label41.Text = "Ciudad:"
        '
        'Txt_Pais
        '
        Me.Txt_Pais.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pais.Location = New System.Drawing.Point(163, 204)
        Me.Txt_Pais.MaxLength = 50
        Me.Txt_Pais.Name = "Txt_Pais"
        Me.Txt_Pais.Size = New System.Drawing.Size(139, 26)
        Me.Txt_Pais.TabIndex = 74
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(48, 207)
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
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre.Location = New System.Drawing.Point(174, 44)
        Me.Txt_Nombre.MaxLength = 50
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nombre:"
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
        Me.Txt_Apellido2.Location = New System.Drawing.Point(174, 172)
        Me.Txt_Apellido2.MaxLength = 50
        Me.Txt_Apellido2.Name = "Txt_Apellido2"
        Me.Txt_Apellido2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Apellido2.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(27, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Segundo apellido:"
        '
        'txt_Apellido1
        '
        Me.txt_Apellido1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_Apellido1.Location = New System.Drawing.Point(174, 140)
        Me.txt_Apellido1.MaxLength = 50
        Me.txt_Apellido1.Name = "txt_Apellido1"
        Me.txt_Apellido1.Size = New System.Drawing.Size(128, 26)
        Me.txt_Apellido1.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(27, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Primer apellido:"
        '
        'Txt_Nombre2
        '
        Me.Txt_Nombre2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre2.Location = New System.Drawing.Point(174, 108)
        Me.Txt_Nombre2.MaxLength = 50
        Me.Txt_Nombre2.Name = "Txt_Nombre2"
        Me.Txt_Nombre2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre2.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(26, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Segundo nombre:"
        '
        'Txt_Nombre1
        '
        Me.Txt_Nombre1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre1.Location = New System.Drawing.Point(174, 76)
        Me.Txt_Nombre1.MaxLength = 50
        Me.Txt_Nombre1.Name = "Txt_Nombre1"
        Me.Txt_Nombre1.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre1.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(26, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Primer nombre:"
        '
        'TabP_Contacto
        '
        Me.TabP_Contacto.AutoScroll = True
        Me.TabP_Contacto.Controls.Add(Me.TBL_Fiscalia_TelDataGridView)
        Me.TabP_Contacto.Controls.Add(Me.TBL_Fiscalia_EmailDataGridView)
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
        Me.TabP_Contacto.Size = New System.Drawing.Size(315, 442)
        Me.TabP_Contacto.TabIndex = 2
        Me.TabP_Contacto.Text = "Contacto"
        Me.TabP_Contacto.ToolTipText = "Mostrar, modificar, insertar y eliminar informacion sobre el contacto de un acusa" &
    "do en particular"
        Me.TabP_Contacto.UseVisualStyleBackColor = True
        '
        'TBL_Fiscalia_TelDataGridView
        '
        Me.TBL_Fiscalia_TelDataGridView.AllowUserToAddRows = False
        Me.TBL_Fiscalia_TelDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Fiscalia_TelDataGridView.AutoGenerateColumns = False
        Me.TBL_Fiscalia_TelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Fiscalia_TelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TBL_Fiscalia_TelDataGridView.DataSource = Me.TBL_Fiscalia_TelBindingSource
        Me.TBL_Fiscalia_TelDataGridView.Location = New System.Drawing.Point(6, 258)
        Me.TBL_Fiscalia_TelDataGridView.Name = "TBL_Fiscalia_TelDataGridView"
        Me.TBL_Fiscalia_TelDataGridView.ReadOnly = True
        Me.TBL_Fiscalia_TelDataGridView.Size = New System.Drawing.Size(142, 156)
        Me.TBL_Fiscalia_TelDataGridView.TabIndex = 63
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fis_CF"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fis_CF"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fis_Tel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TBL_Fiscalia_TelBindingSource
        '
        Me.TBL_Fiscalia_TelBindingSource.DataMember = "TBL_Fiscalia_Tel"
        Me.TBL_Fiscalia_TelBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'TBL_Fiscalia_EmailDataGridView
        '
        Me.TBL_Fiscalia_EmailDataGridView.AllowUserToAddRows = False
        Me.TBL_Fiscalia_EmailDataGridView.AllowUserToDeleteRows = False
        Me.TBL_Fiscalia_EmailDataGridView.AutoGenerateColumns = False
        Me.TBL_Fiscalia_EmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_Fiscalia_EmailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TBL_Fiscalia_EmailDataGridView.DataSource = Me.TBL_Fiscalia_EmailBindingSource
        Me.TBL_Fiscalia_EmailDataGridView.Location = New System.Drawing.Point(6, 39)
        Me.TBL_Fiscalia_EmailDataGridView.Name = "TBL_Fiscalia_EmailDataGridView"
        Me.TBL_Fiscalia_EmailDataGridView.ReadOnly = True
        Me.TBL_Fiscalia_EmailDataGridView.Size = New System.Drawing.Size(146, 134)
        Me.TBL_Fiscalia_EmailDataGridView.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fis_CF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fis_CF"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fis_Email"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Emails"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TBL_Fiscalia_EmailBindingSource
        '
        Me.TBL_Fiscalia_EmailBindingSource.DataMember = "TBL_Fiscalia_Email"
        Me.TBL_Fiscalia_EmailBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BTN_tel
        '
        Me.BTN_tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_tel.Location = New System.Drawing.Point(188, 311)
        Me.BTN_tel.Name = "BTN_tel"
        Me.BTN_tel.Size = New System.Drawing.Size(57, 23)
        Me.BTN_tel.TabIndex = 63
        Me.BTN_tel.Text = "Add"
        Me.BTN_tel.UseVisualStyleBackColor = True
        '
        'BTN_Email
        '
        Me.BTN_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Email.Location = New System.Drawing.Point(199, 92)
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
        Me.Label44.Location = New System.Drawing.Point(42, 235)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(125, 18)
        Me.Label44.TabIndex = 59
        Me.Label44.Text = "Tel de la fiscalia"
        '
        'Txt_Tel
        '
        Me.Txt_Tel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tel.Location = New System.Drawing.Point(152, 279)
        Me.Txt_Tel.MaxLength = 15
        Me.Txt_Tel.Name = "Txt_Tel"
        Me.Txt_Tel.Size = New System.Drawing.Size(131, 26)
        Me.Txt_Tel.TabIndex = 57
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(176, 258)
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
        Me.Label46.Size = New System.Drawing.Size(165, 18)
        Me.Label46.TabIndex = 55
        Me.Label46.Text = "Correos de la fiscalia"
        '
        'Txt_Email
        '
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(158, 60)
        Me.Txt_Email.MaxLength = 100
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(152, 26)
        Me.Txt_Email.TabIndex = 53
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(196, 39)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 18)
        Me.Label47.TabIndex = 51
        Me.Label47.Text = "Elemento"
        '
        'TBL_FiscaliaTableAdapter
        '
        Me.TBL_FiscaliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_Abogado_EmailTableAdapter = Nothing
        Me.TableAdapterManager.TBL_Abogado_TelTableAdapter = Nothing
        Me.TableAdapterManager.TBL_AbogadoTableAdapter = Nothing
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
        Me.TableAdapterManager.TBL_FiscaliaTableAdapter = Me.TBL_FiscaliaTableAdapter
        Me.TableAdapterManager.TBL_UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_Fiscalia_EmailTableAdapter
        '
        Me.TBL_Fiscalia_EmailTableAdapter.ClearBeforeFill = True
        '
        'TBL_Fiscalia_TelTableAdapter
        '
        Me.TBL_Fiscalia_TelTableAdapter.ClearBeforeFill = True
        '
        'FRM_Fiscalia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(359, 555)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Controls.Add(Me.Tap_Informacion)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Fiscalia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de la fiscalia"
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_FiscaliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tap_Informacion.ResumeLayout(False)
        Me.TabP_Personal.ResumeLayout(False)
        Me.TabP_Personal.PerformLayout()
        Me.TabP_Contacto.ResumeLayout(False)
        Me.TabP_Contacto.PerformLayout()
        CType(Me.TBL_Fiscalia_TelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Fiscalia_TelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Fiscalia_EmailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_Fiscalia_EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Tap_Informacion As TabControl
    Friend WithEvents TabP_Personal As TabPage
    Friend WithEvents TabP_Contacto As TabPage
    Friend WithEvents Label44 As Label
    Friend WithEvents Txt_Tel As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Label47 As Label
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
    Friend WithEvents Txt_Nombre As TextBox
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
    Friend WithEvents BTN_tel As Button
    Friend WithEvents BTN_Email As Button
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_FiscaliaBindingSource As BindingSource
    Friend WithEvents TBL_FiscaliaTableAdapter As BDAcusadosDataSetTableAdapters.TBL_FiscaliaTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_Fiscalia_EmailBindingSource As BindingSource
    Friend WithEvents TBL_Fiscalia_EmailTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Fiscalia_EmailTableAdapter
    Friend WithEvents TBL_Fiscalia_EmailDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TBL_Fiscalia_TelBindingSource As BindingSource
    Friend WithEvents TBL_Fiscalia_TelTableAdapter As BDAcusadosDataSetTableAdapters.TBL_Fiscalia_TelTableAdapter
    Friend WithEvents TBL_Fiscalia_TelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents FisCFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisNombre1AdmiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisNombre2AdmiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisApellido1AdmiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisApellido2AdmiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisPaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisDeptoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisExtraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
