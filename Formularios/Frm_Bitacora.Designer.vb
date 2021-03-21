<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Bitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Bitacora))
        Me.gb_Acusados = New System.Windows.Forms.GroupBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Tabla_Acusado = New System.Windows.Forms.DataGridView()
        Me.UsuUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitAfectadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BitFechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBL_BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAcusadosDataSet = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.TBL_BitacoraTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_BitacoraTableAdapter()
        Me.TableAdapterManager = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.gb_Acusados.SuspendLayout()
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_Acusados
        '
        Me.gb_Acusados.Controls.Add(Me.Regresar)
        Me.gb_Acusados.Controls.Add(Me.Tabla_Acusado)
        Me.gb_Acusados.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Acusados.Location = New System.Drawing.Point(12, 12)
        Me.gb_Acusados.Name = "gb_Acusados"
        Me.gb_Acusados.Size = New System.Drawing.Size(572, 426)
        Me.gb_Acusados.TabIndex = 29
        Me.gb_Acusados.TabStop = False
        Me.gb_Acusados.Text = "Lista de bitacora"
        '
        'Regresar
        '
        Me.Regresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regresar.BackColor = System.Drawing.Color.Navy
        Me.Regresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Regresar.ForeColor = System.Drawing.Color.White
        Me.Regresar.Location = New System.Drawing.Point(471, 358)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(89, 54)
        Me.Regresar.TabIndex = 53
        Me.Regresar.Text = "Volver al menu"
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Tabla_Acusado
        '
        Me.Tabla_Acusado.AllowUserToAddRows = False
        Me.Tabla_Acusado.AllowUserToDeleteRows = False
        Me.Tabla_Acusado.AutoGenerateColumns = False
        Me.Tabla_Acusado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla_Acusado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuUsuarioDataGridViewTextBoxColumn, Me.BitActividadDataGridViewTextBoxColumn, Me.BitPCDataGridViewTextBoxColumn, Me.BitAfectadoDataGridViewTextBoxColumn, Me.BitFechaDataGridViewTextBoxColumn})
        Me.Tabla_Acusado.DataSource = Me.TBL_BitacoraBindingSource
        Me.Tabla_Acusado.Location = New System.Drawing.Point(15, 28)
        Me.Tabla_Acusado.Name = "Tabla_Acusado"
        Me.Tabla_Acusado.ReadOnly = True
        Me.Tabla_Acusado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla_Acusado.Size = New System.Drawing.Size(545, 324)
        Me.Tabla_Acusado.TabIndex = 52
        '
        'UsuUsuarioDataGridViewTextBoxColumn
        '
        Me.UsuUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usu_Usuario"
        Me.UsuUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuUsuarioDataGridViewTextBoxColumn.Name = "UsuUsuarioDataGridViewTextBoxColumn"
        Me.UsuUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BitActividadDataGridViewTextBoxColumn
        '
        Me.BitActividadDataGridViewTextBoxColumn.DataPropertyName = "Bit_Actividad"
        Me.BitActividadDataGridViewTextBoxColumn.HeaderText = "Actividad"
        Me.BitActividadDataGridViewTextBoxColumn.Name = "BitActividadDataGridViewTextBoxColumn"
        Me.BitActividadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BitPCDataGridViewTextBoxColumn
        '
        Me.BitPCDataGridViewTextBoxColumn.DataPropertyName = "Bit_PC"
        Me.BitPCDataGridViewTextBoxColumn.HeaderText = "PC"
        Me.BitPCDataGridViewTextBoxColumn.Name = "BitPCDataGridViewTextBoxColumn"
        Me.BitPCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BitAfectadoDataGridViewTextBoxColumn
        '
        Me.BitAfectadoDataGridViewTextBoxColumn.DataPropertyName = "Bit_Afectado"
        Me.BitAfectadoDataGridViewTextBoxColumn.HeaderText = "Afectado"
        Me.BitAfectadoDataGridViewTextBoxColumn.Name = "BitAfectadoDataGridViewTextBoxColumn"
        Me.BitAfectadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BitFechaDataGridViewTextBoxColumn
        '
        Me.BitFechaDataGridViewTextBoxColumn.DataPropertyName = "Bit_Fecha"
        Me.BitFechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.BitFechaDataGridViewTextBoxColumn.Name = "BitFechaDataGridViewTextBoxColumn"
        Me.BitFechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBL_BitacoraBindingSource
        '
        Me.TBL_BitacoraBindingSource.DataMember = "TBL_Bitacora"
        Me.TBL_BitacoraBindingSource.DataSource = Me.BDAcusadosDataSet
        '
        'BDAcusadosDataSet
        '
        Me.BDAcusadosDataSet.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_BitacoraTableAdapter
        '
        Me.TBL_BitacoraTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBL_BitacoraTableAdapter = Me.TBL_BitacoraTableAdapter
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
        'Frm_Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(603, 450)
        Me.Controls.Add(Me.gb_Acusados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Bitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitacora"
        Me.gb_Acusados.ResumeLayout(False)
        CType(Me.Tabla_Acusado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_Acusados As GroupBox
    Friend WithEvents Tabla_Acusado As DataGridView
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_BitacoraBindingSource As BindingSource
    Friend WithEvents TBL_BitacoraTableAdapter As BDAcusadosDataSetTableAdapters.TBL_BitacoraTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitActividadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitAfectadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BitFechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Regresar As Button
End Class
