<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Usuario))
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.Check_Acceso = New System.Windows.Forms.CheckBox()
        Me.Combo_Usuario = New System.Windows.Forms.ComboBox()
        Me.Txt_Apellido2 = New System.Windows.Forms.TextBox()
        Me.txt_Apellido1 = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre2 = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre1 = New System.Windows.Forms.TextBox()
        Me.Txt_Identidad = New System.Windows.Forms.TextBox()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UsuUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuNombre1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuNombre2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuApellido1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuApellido2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuTipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuAccesoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBL_UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.TBL_UsuarioTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_UsuarioTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.gbPersonal.SuspendLayout()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(443, 377)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 38
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(258, 377)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 37
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(288, 377)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 36
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(153, 377)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 35
        Me.Btn_Guardar.Text = "Guardad"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.Navy
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(12, 377)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 34
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'gbPersonal
        '
        Me.gbPersonal.Controls.Add(Me.Check_Acceso)
        Me.gbPersonal.Controls.Add(Me.Combo_Usuario)
        Me.gbPersonal.Controls.Add(Me.Txt_Apellido2)
        Me.gbPersonal.Controls.Add(Me.txt_Apellido1)
        Me.gbPersonal.Controls.Add(Me.Txt_Nombre2)
        Me.gbPersonal.Controls.Add(Me.Txt_Nombre1)
        Me.gbPersonal.Controls.Add(Me.Txt_Identidad)
        Me.gbPersonal.Controls.Add(Me.Txt_Contraseña)
        Me.gbPersonal.Controls.Add(Me.Txt_Usuario)
        Me.gbPersonal.Controls.Add(Me.Label8)
        Me.gbPersonal.Controls.Add(Me.Label7)
        Me.gbPersonal.Controls.Add(Me.Label6)
        Me.gbPersonal.Controls.Add(Me.Label5)
        Me.gbPersonal.Controls.Add(Me.Label4)
        Me.gbPersonal.Controls.Add(Me.Label3)
        Me.gbPersonal.Controls.Add(Me.Label2)
        Me.gbPersonal.Controls.Add(Me.Label1)
        Me.gbPersonal.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.gbPersonal.Location = New System.Drawing.Point(12, 12)
        Me.gbPersonal.Name = "gbPersonal"
        Me.gbPersonal.Size = New System.Drawing.Size(326, 359)
        Me.gbPersonal.TabIndex = 39
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Informacion"
        Me.gbPersonal.Visible = False
        '
        'Check_Acceso
        '
        Me.Check_Acceso.AutoSize = True
        Me.Check_Acceso.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Check_Acceso.Location = New System.Drawing.Point(85, 305)
        Me.Check_Acceso.Name = "Check_Acceso"
        Me.Check_Acceso.Size = New System.Drawing.Size(121, 23)
        Me.Check_Acceso.TabIndex = 17
        Me.Check_Acceso.Text = "Permitir acceso"
        Me.Check_Acceso.UseVisualStyleBackColor = True
        '
        'Combo_Usuario
        '
        Me.Combo_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Usuario.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Combo_Usuario.FormattingEnabled = True
        Me.Combo_Usuario.Items.AddRange(New Object() {"Detective", "Fiscal", "Administrador"})
        Me.Combo_Usuario.Location = New System.Drawing.Point(154, 252)
        Me.Combo_Usuario.Name = "Combo_Usuario"
        Me.Combo_Usuario.Size = New System.Drawing.Size(128, 27)
        Me.Combo_Usuario.TabIndex = 16
        '
        'Txt_Apellido2
        '
        Me.Txt_Apellido2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Apellido2.Location = New System.Drawing.Point(154, 220)
        Me.Txt_Apellido2.MaxLength = 50
        Me.Txt_Apellido2.Name = "Txt_Apellido2"
        Me.Txt_Apellido2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Apellido2.TabIndex = 15
        '
        'txt_Apellido1
        '
        Me.txt_Apellido1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_Apellido1.Location = New System.Drawing.Point(154, 189)
        Me.txt_Apellido1.MaxLength = 50
        Me.txt_Apellido1.Name = "txt_Apellido1"
        Me.txt_Apellido1.Size = New System.Drawing.Size(128, 26)
        Me.txt_Apellido1.TabIndex = 14
        '
        'Txt_Nombre2
        '
        Me.Txt_Nombre2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre2.Location = New System.Drawing.Point(154, 157)
        Me.Txt_Nombre2.MaxLength = 50
        Me.Txt_Nombre2.Name = "Txt_Nombre2"
        Me.Txt_Nombre2.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre2.TabIndex = 13
        '
        'Txt_Nombre1
        '
        Me.Txt_Nombre1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre1.Location = New System.Drawing.Point(154, 125)
        Me.Txt_Nombre1.MaxLength = 50
        Me.Txt_Nombre1.Name = "Txt_Nombre1"
        Me.Txt_Nombre1.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre1.TabIndex = 12
        '
        'Txt_Identidad
        '
        Me.Txt_Identidad.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Identidad.Location = New System.Drawing.Point(154, 93)
        Me.Txt_Identidad.MaxLength = 15
        Me.Txt_Identidad.Name = "Txt_Identidad"
        Me.Txt_Identidad.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Identidad.TabIndex = 11
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Contraseña.Location = New System.Drawing.Point(154, 61)
        Me.Txt_Contraseña.MaxLength = 50
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_Contraseña.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Contraseña.TabIndex = 10
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Usuario.Location = New System.Drawing.Point(154, 29)
        Me.Txt_Usuario.MaxLength = 50
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Usuario.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(7, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Usuario de:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(7, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "segundo apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(7, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Primer apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Segundo nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Primer nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Identidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Acusados.Controls.Add(Me.BtnEliminar)
        Me.gb_Acusados.Controls.Add(Me.Datalistado)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(10, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(339, 359)
        Me.gb_Acusados.TabIndex = 40
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de usuarios"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Navy
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(139, 299)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 54)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Datalistado
        '
        Me.Datalistado.AllowUserToAddRows = False
        Me.Datalistado.AllowUserToDeleteRows = False
        Me.Datalistado.AutoGenerateColumns = False
        Me.Datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.UsuUsuarioDataGridViewTextBoxColumn, Me.UsuContraseñaDataGridViewTextBoxColumn, Me.UsuIDDataGridViewTextBoxColumn, Me.UsuNombre1DataGridViewTextBoxColumn, Me.UsuNombre2DataGridViewTextBoxColumn, Me.UsuApellido1DataGridViewTextBoxColumn, Me.UsuApellido2DataGridViewTextBoxColumn, Me.UsuTipoDataGridViewTextBoxColumn, Me.UsuAccesoDataGridViewCheckBoxColumn})
        Me.Datalistado.DataSource = Me.TBL_UsuarioBindingSource
        Me.Datalistado.Location = New System.Drawing.Point(16, 32)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(305, 265)
        Me.Datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'UsuUsuarioDataGridViewTextBoxColumn
        '
        Me.UsuUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usu_Usuario"
        Me.UsuUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuUsuarioDataGridViewTextBoxColumn.Name = "UsuUsuarioDataGridViewTextBoxColumn"
        Me.UsuUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuContraseñaDataGridViewTextBoxColumn
        '
        Me.UsuContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Usu_Contraseña"
        Me.UsuContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.UsuContraseñaDataGridViewTextBoxColumn.Name = "UsuContraseñaDataGridViewTextBoxColumn"
        Me.UsuContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuIDDataGridViewTextBoxColumn
        '
        Me.UsuIDDataGridViewTextBoxColumn.DataPropertyName = "Usu_ID"
        Me.UsuIDDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.UsuIDDataGridViewTextBoxColumn.Name = "UsuIDDataGridViewTextBoxColumn"
        Me.UsuIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuNombre1DataGridViewTextBoxColumn
        '
        Me.UsuNombre1DataGridViewTextBoxColumn.DataPropertyName = "Usu_Nombre1"
        Me.UsuNombre1DataGridViewTextBoxColumn.HeaderText = "PNombre"
        Me.UsuNombre1DataGridViewTextBoxColumn.Name = "UsuNombre1DataGridViewTextBoxColumn"
        Me.UsuNombre1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuNombre2DataGridViewTextBoxColumn
        '
        Me.UsuNombre2DataGridViewTextBoxColumn.DataPropertyName = "Usu_Nombre2"
        Me.UsuNombre2DataGridViewTextBoxColumn.HeaderText = "SNombre"
        Me.UsuNombre2DataGridViewTextBoxColumn.Name = "UsuNombre2DataGridViewTextBoxColumn"
        Me.UsuNombre2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuApellido1DataGridViewTextBoxColumn
        '
        Me.UsuApellido1DataGridViewTextBoxColumn.DataPropertyName = "Usu_Apellido1"
        Me.UsuApellido1DataGridViewTextBoxColumn.HeaderText = "PApellido"
        Me.UsuApellido1DataGridViewTextBoxColumn.Name = "UsuApellido1DataGridViewTextBoxColumn"
        Me.UsuApellido1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuApellido2DataGridViewTextBoxColumn
        '
        Me.UsuApellido2DataGridViewTextBoxColumn.DataPropertyName = "Usu_Apellido2"
        Me.UsuApellido2DataGridViewTextBoxColumn.HeaderText = "SApellido"
        Me.UsuApellido2DataGridViewTextBoxColumn.Name = "UsuApellido2DataGridViewTextBoxColumn"
        Me.UsuApellido2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuTipoDataGridViewTextBoxColumn
        '
        Me.UsuTipoDataGridViewTextBoxColumn.DataPropertyName = "Usu_Tipo"
        Me.UsuTipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.UsuTipoDataGridViewTextBoxColumn.Name = "UsuTipoDataGridViewTextBoxColumn"
        Me.UsuTipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuAccesoDataGridViewCheckBoxColumn
        '
        Me.UsuAccesoDataGridViewCheckBoxColumn.DataPropertyName = "Usu_Acceso"
        Me.UsuAccesoDataGridViewCheckBoxColumn.HeaderText = "Acceso"
        Me.UsuAccesoDataGridViewCheckBoxColumn.Name = "UsuAccesoDataGridViewCheckBoxColumn"
        Me.UsuAccesoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TBL_UsuarioBindingSource
        '
        Me.TBL_UsuarioBindingSource.DataMember = "TBL_Usuario"
        Me.TBL_UsuarioBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BDAcusadosDataSet
        '
        Me.BDAcusadosDataSet.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_UsuarioTableAdapter
        '
        Me.TBL_UsuarioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBL_FiscaliaTableAdapter = Nothing
        Me.TableAdapterManager.TBL_UsuarioTableAdapter = Me.TBL_UsuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Frm_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(359, 460)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento del Usuario"
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Apellido2 As TextBox
    Friend WithEvents txt_Apellido1 As TextBox
    Friend WithEvents Txt_Nombre2 As TextBox
    Friend WithEvents Txt_Nombre1 As TextBox
    Friend WithEvents Txt_Identidad As TextBox
    Friend WithEvents Txt_Contraseña As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Combo_Usuario As ComboBox
    Friend WithEvents Check_Acceso As CheckBox
    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_UsuarioBindingSource As BindingSource
    Friend WithEvents TBL_UsuarioTableAdapter As BDAcusadosDataSetTableAdapters.TBL_UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents UsuUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuNombre1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuNombre2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuApellido1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuApellido2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuTipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuAccesoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
