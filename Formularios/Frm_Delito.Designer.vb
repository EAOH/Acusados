<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Delito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Delito))
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DelCIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelNivelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelPenaMaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelDiasPenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelMesesPenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelAñoPenaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelFianzaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_DelitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.gbPersonal = New System.Windows.Forms.GroupBox()
        Me.Txt_Fianza = New System.Windows.Forms.TextBox()
        Me.Txt_Año = New System.Windows.Forms.TextBox()
        Me.txt_Mes = New System.Windows.Forms.TextBox()
        Me.Txt_Dia = New System.Windows.Forms.TextBox()
        Me.Txt_PenaM = New System.Windows.Forms.TextBox()
        Me.Txt_Nivel = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.TBL_DelitoTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_DelitoTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_DelitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPersonal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(261, 315)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 44
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(290, 315)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(97, 54)
        Me.Btn_Actualizar.TabIndex = 43
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        Me.Btn_Actualizar.Visible = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Guardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.White
        Me.Btn_Guardar.Location = New System.Drawing.Point(155, 315)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Guardar.TabIndex = 42
        Me.Btn_Guardar.Text = "Guardad"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.Navy
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(14, 315)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Nuevo.TabIndex = 41
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Acusados.Controls.Add(Me.BtnEliminar)
        Me.gb_Acusados.Controls.Add(Me.Datalistado)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(11, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(339, 297)
        Me.gb_Acusados.TabIndex = 47
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de delitos"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Navy
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(142, 221)
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
        Me.Datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.DelCIDDataGridViewTextBoxColumn, Me.DelNombreDataGridViewTextBoxColumn, Me.DelNivelDataGridViewTextBoxColumn, Me.DelPenaMaxDataGridViewTextBoxColumn, Me.DelDiasPenaDataGridViewTextBoxColumn, Me.DelMesesPenaDataGridViewTextBoxColumn, Me.DelAñoPenaDataGridViewTextBoxColumn, Me.DelFianzaDataGridViewTextBoxColumn})
        Me.Datalistado.DataSource = Me.TBL_DelitoBindingSource
        Me.Datalistado.Location = New System.Drawing.Point(16, 32)
        Me.Datalistado.Name = "Datalistado"
        Me.Datalistado.ReadOnly = True
        Me.Datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datalistado.Size = New System.Drawing.Size(305, 183)
        Me.Datalistado.TabIndex = 52
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'DelCIDDataGridViewTextBoxColumn
        '
        Me.DelCIDDataGridViewTextBoxColumn.DataPropertyName = "Del_CID"
        Me.DelCIDDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.DelCIDDataGridViewTextBoxColumn.Name = "DelCIDDataGridViewTextBoxColumn"
        Me.DelCIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelNombreDataGridViewTextBoxColumn
        '
        Me.DelNombreDataGridViewTextBoxColumn.DataPropertyName = "Del_Nombre"
        Me.DelNombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.DelNombreDataGridViewTextBoxColumn.Name = "DelNombreDataGridViewTextBoxColumn"
        Me.DelNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelNivelDataGridViewTextBoxColumn
        '
        Me.DelNivelDataGridViewTextBoxColumn.DataPropertyName = "Del_Nivel"
        Me.DelNivelDataGridViewTextBoxColumn.HeaderText = "Nivel"
        Me.DelNivelDataGridViewTextBoxColumn.Name = "DelNivelDataGridViewTextBoxColumn"
        Me.DelNivelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelPenaMaxDataGridViewTextBoxColumn
        '
        Me.DelPenaMaxDataGridViewTextBoxColumn.DataPropertyName = "Del_Pena_Max"
        Me.DelPenaMaxDataGridViewTextBoxColumn.HeaderText = "Pena maxima"
        Me.DelPenaMaxDataGridViewTextBoxColumn.Name = "DelPenaMaxDataGridViewTextBoxColumn"
        Me.DelPenaMaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelDiasPenaDataGridViewTextBoxColumn
        '
        Me.DelDiasPenaDataGridViewTextBoxColumn.DataPropertyName = "Del_Dias_Pena"
        Me.DelDiasPenaDataGridViewTextBoxColumn.HeaderText = "Dias duracion"
        Me.DelDiasPenaDataGridViewTextBoxColumn.Name = "DelDiasPenaDataGridViewTextBoxColumn"
        Me.DelDiasPenaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelMesesPenaDataGridViewTextBoxColumn
        '
        Me.DelMesesPenaDataGridViewTextBoxColumn.DataPropertyName = "Del_Meses_Pena"
        Me.DelMesesPenaDataGridViewTextBoxColumn.HeaderText = "Meses duracion"
        Me.DelMesesPenaDataGridViewTextBoxColumn.Name = "DelMesesPenaDataGridViewTextBoxColumn"
        Me.DelMesesPenaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelAñoPenaDataGridViewTextBoxColumn
        '
        Me.DelAñoPenaDataGridViewTextBoxColumn.DataPropertyName = "Del_Año_Pena"
        Me.DelAñoPenaDataGridViewTextBoxColumn.HeaderText = "Año duracion"
        Me.DelAñoPenaDataGridViewTextBoxColumn.Name = "DelAñoPenaDataGridViewTextBoxColumn"
        Me.DelAñoPenaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DelFianzaDataGridViewTextBoxColumn
        '
        Me.DelFianzaDataGridViewTextBoxColumn.DataPropertyName = "Del_Fianza"
        Me.DelFianzaDataGridViewTextBoxColumn.HeaderText = "Fianza"
        Me.DelFianzaDataGridViewTextBoxColumn.Name = "DelFianzaDataGridViewTextBoxColumn"
        Me.DelFianzaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_DelitoBindingSource
        '
        Me.TBL_DelitoBindingSource.DataMember = "TBL_Delito"
        Me.TBL_DelitoBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BDAcusadosDataSet
        '
        Me.BDAcusadosDataSet.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbPersonal
        '
        Me.gbPersonal.Controls.Add(Me.Txt_Fianza)
        Me.gbPersonal.Controls.Add(Me.Txt_Año)
        Me.gbPersonal.Controls.Add(Me.txt_Mes)
        Me.gbPersonal.Controls.Add(Me.Txt_Dia)
        Me.gbPersonal.Controls.Add(Me.Txt_PenaM)
        Me.gbPersonal.Controls.Add(Me.Txt_Nivel)
        Me.gbPersonal.Controls.Add(Me.Txt_Nombre)
        Me.gbPersonal.Controls.Add(Me.Txt_Codigo)
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
        Me.gbPersonal.Size = New System.Drawing.Size(326, 297)
        Me.gbPersonal.TabIndex = 46
        Me.gbPersonal.TabStop = False
        Me.gbPersonal.Text = "Informacion"
        Me.gbPersonal.Visible = False
        '
        'Txt_Fianza
        '
        Me.Txt_Fianza.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Fianza.Location = New System.Drawing.Point(154, 252)
        Me.Txt_Fianza.MaxLength = 50
        Me.Txt_Fianza.Name = "Txt_Fianza"
        Me.Txt_Fianza.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Fianza.TabIndex = 18
        '
        'Txt_Año
        '
        Me.Txt_Año.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Año.Location = New System.Drawing.Point(154, 220)
        Me.Txt_Año.MaxLength = 50
        Me.Txt_Año.Name = "Txt_Año"
        Me.Txt_Año.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Año.TabIndex = 15
        '
        'txt_Mes
        '
        Me.txt_Mes.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_Mes.Location = New System.Drawing.Point(154, 189)
        Me.txt_Mes.MaxLength = 50
        Me.txt_Mes.Name = "txt_Mes"
        Me.txt_Mes.Size = New System.Drawing.Size(128, 26)
        Me.txt_Mes.TabIndex = 14
        '
        'Txt_Dia
        '
        Me.Txt_Dia.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Dia.Location = New System.Drawing.Point(154, 157)
        Me.Txt_Dia.MaxLength = 50
        Me.Txt_Dia.Name = "Txt_Dia"
        Me.Txt_Dia.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Dia.TabIndex = 13
        '
        'Txt_PenaM
        '
        Me.Txt_PenaM.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_PenaM.Location = New System.Drawing.Point(154, 125)
        Me.Txt_PenaM.MaxLength = 50
        Me.Txt_PenaM.Name = "Txt_PenaM"
        Me.Txt_PenaM.Size = New System.Drawing.Size(128, 26)
        Me.Txt_PenaM.TabIndex = 12
        '
        'Txt_Nivel
        '
        Me.Txt_Nivel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nivel.Location = New System.Drawing.Point(154, 93)
        Me.Txt_Nivel.MaxLength = 15
        Me.Txt_Nivel.Name = "Txt_Nivel"
        Me.Txt_Nivel.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nivel.TabIndex = 11
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Nombre.Location = New System.Drawing.Point(154, 61)
        Me.Txt_Nombre.MaxLength = 50
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Nombre.TabIndex = 10
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.Enabled = False
        Me.Txt_Codigo.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Txt_Codigo.Location = New System.Drawing.Point(154, 29)
        Me.Txt_Codigo.MaxLength = 50
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(128, 26)
        Me.Txt_Codigo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(7, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fianza:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(7, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Año duracion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(7, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Meses duraccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dias duracion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pena maxima:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancelar.Location = New System.Drawing.Point(445, 315)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(89, 54)
        Me.Btn_Cancelar.TabIndex = 45
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        Me.Btn_Cancelar.Visible = False
        '
        'TBL_DelitoTableAdapter
        '
        Me.TBL_DelitoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBL_DelitoTableAdapter = Me.TBL_DelitoTableAdapter
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
        'Frm_Delito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(360, 391)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Controls.Add(Me.gbPersonal)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Delito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de los delitos"
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.Datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_DelitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPersonal.ResumeLayout(False)
        Me.gbPersonal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Nuevo As Button
    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Datalistado As DataGridView
    Friend WithEvents gbPersonal As GroupBox
    Friend WithEvents Txt_Año As TextBox
    Friend WithEvents txt_Mes As TextBox
    Friend WithEvents Txt_Dia As TextBox
    Friend WithEvents Txt_PenaM As TextBox
    Friend WithEvents Txt_Nivel As TextBox
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Codigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Txt_Fianza As TextBox
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_DelitoBindingSource As BindingSource
    Friend WithEvents TBL_DelitoTableAdapter As BDAcusadosDataSetTableAdapters.TBL_DelitoTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents DelCIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelNivelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelPenaMaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelDiasPenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelMesesPenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelAñoPenaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DelFianzaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
