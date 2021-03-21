<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tip_Login = New System.Windows.Forms.ToolTip(Me.components)
        Me.BDAcusadosDataSet1 = New Sistema_fiscal_para_acusados.BDAcusadosDataSet()
        Me.TBL_UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_UsuarioTableAdapter1 = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_UsuarioTableAdapter()
        Me.TableAdapterManager1 = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager()
        Me.TBL_UsuarioBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Usu_AccesoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Usu_TipoLabel1 = New System.Windows.Forms.Label()
        Me.Usu_UsuarioLabel1 = New System.Windows.Forms.Label()
        Me.Usu_ContraseñaLabel1 = New System.Windows.Forms.Label()
        Me.TBL_BitacoraTableAdapter = New Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TBL_BitacoraTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAcusadosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_UsuarioBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_UsuarioBindingSource1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackColor = System.Drawing.Color.Navy
        Me.Btn_Ingresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.Btn_Ingresar.Location = New System.Drawing.Point(197, 65)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(83, 35)
        Me.Btn_Ingresar.TabIndex = 11
        Me.Btn_Ingresar.Text = "Ingresar"
        Me.Tip_Login.SetToolTip(Me.Btn_Ingresar, "Presionar cuando hayas ingresado tu usuario y contraseña para ingresar al sistema" &
        "")
        Me.Btn_Ingresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_fiscal_para_acusados.My.Resources.Resources.Imagen_Login
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contraseña.Location = New System.Drawing.Point(253, 33)
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Txt_Contraseña.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Contraseña.TabIndex = 9
        Me.Tip_Login.SetToolTip(Me.Txt_Contraseña, "Introduce tu contraseña")
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.Location = New System.Drawing.Point(133, 33)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(100, 26)
        Me.Txt_Usuario.TabIndex = 8
        Me.Tip_Login.SetToolTip(Me.Txt_Usuario, "Introduce tu usuario")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario:"
        '
        'Tip_Login
        '
        Me.Tip_Login.BackColor = System.Drawing.Color.White
        Me.Tip_Login.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Login.ToolTipTitle = "Informacion"
        '
        'BDAcusadosDataSet1
        '
        Me.BDAcusadosDataSet1.DataSetName = "BDAcusadosDataSet"
        Me.BDAcusadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_UsuarioBindingSource1
        '
        Me.TBL_UsuarioBindingSource1.DataMember = "TBL_Usuario"
        Me.TBL_UsuarioBindingSource1.DataSource = Me.BDAcusadosDataSet1
        '
        'TBL_UsuarioTableAdapter1
        '
        Me.TBL_UsuarioTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TBL_Abogado_EmailTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Abogado_TelTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_AbogadoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Acusado_EmailTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Acusado_FotoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Acusado_HistorialTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Acusado_RasgoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Acusado_TelTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_AcusadoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_AsociadosTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_BitacoraTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_CuentanTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_DelitoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_EvidenciaTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Expediente_MotivoTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Expediente_ObservacionesTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_ExpedienteTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Fiscalia_EmailTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_Fiscalia_TelTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_FiscaliaTableAdapter = Nothing
        Me.TableAdapterManager1.TBL_UsuarioTableAdapter = Me.TBL_UsuarioTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Sistema_fiscal_para_acusados.BDAcusadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_UsuarioBindingSource1BindingNavigator
        '
        Me.TBL_UsuarioBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.TBL_UsuarioBindingSource1BindingNavigator.BindingSource = Me.TBL_UsuarioBindingSource1
        Me.TBL_UsuarioBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.TBL_UsuarioBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.TBL_UsuarioBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem})
        Me.TBL_UsuarioBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_UsuarioBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.TBL_UsuarioBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.TBL_UsuarioBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.TBL_UsuarioBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.TBL_UsuarioBindingSource1BindingNavigator.Name = "TBL_UsuarioBindingSource1BindingNavigator"
        Me.TBL_UsuarioBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.TBL_UsuarioBindingSource1BindingNavigator.Size = New System.Drawing.Size(837, 25)
        Me.TBL_UsuarioBindingSource1BindingNavigator.TabIndex = 12
        Me.TBL_UsuarioBindingSource1BindingNavigator.Text = "BindingNavigator1"
        Me.TBL_UsuarioBindingSource1BindingNavigator.Visible = False
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Agregar nuevo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TBL_UsuarioBindingSource1BindingNavigatorSaveItem
        '
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Name = "TBL_UsuarioBindingSource1BindingNavigatorSaveItem"
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Usu_AccesoCheckBox
        '
        Me.Usu_AccesoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TBL_UsuarioBindingSource1, "Usu_Acceso", True))
        Me.Usu_AccesoCheckBox.Location = New System.Drawing.Point(613, 74)
        Me.Usu_AccesoCheckBox.Name = "Usu_AccesoCheckBox"
        Me.Usu_AccesoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Usu_AccesoCheckBox.TabIndex = 13
        Me.Usu_AccesoCheckBox.Text = "CheckBox1"
        Me.Usu_AccesoCheckBox.UseVisualStyleBackColor = True
        '
        'Usu_TipoLabel1
        '
        Me.Usu_TipoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_UsuarioBindingSource1, "Usu_Tipo", True))
        Me.Usu_TipoLabel1.Location = New System.Drawing.Point(610, 48)
        Me.Usu_TipoLabel1.Name = "Usu_TipoLabel1"
        Me.Usu_TipoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Usu_TipoLabel1.TabIndex = 14
        Me.Usu_TipoLabel1.Text = "Label3"
        '
        'Usu_UsuarioLabel1
        '
        Me.Usu_UsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_UsuarioBindingSource1, "Usu_Usuario", True))
        Me.Usu_UsuarioLabel1.Location = New System.Drawing.Point(610, 2)
        Me.Usu_UsuarioLabel1.Name = "Usu_UsuarioLabel1"
        Me.Usu_UsuarioLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Usu_UsuarioLabel1.TabIndex = 15
        Me.Usu_UsuarioLabel1.Text = "Label3"
        '
        'Usu_ContraseñaLabel1
        '
        Me.Usu_ContraseñaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_UsuarioBindingSource1, "Usu_Contraseña", True))
        Me.Usu_ContraseñaLabel1.Location = New System.Drawing.Point(610, 25)
        Me.Usu_ContraseñaLabel1.Name = "Usu_ContraseñaLabel1"
        Me.Usu_ContraseñaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Usu_ContraseñaLabel1.TabIndex = 16
        Me.Usu_ContraseñaLabel1.Text = "Label3"
        '
        'TBL_BitacoraTableAdapter
        '
        Me.TBL_BitacoraTableAdapter.ClearBeforeFill = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(395, 119)
        Me.Controls.Add(Me.Usu_ContraseñaLabel1)
        Me.Controls.Add(Me.Usu_UsuarioLabel1)
        Me.Controls.Add(Me.Usu_TipoLabel1)
        Me.Controls.Add(Me.Usu_AccesoCheckBox)
        Me.Controls.Add(Me.TBL_UsuarioBindingSource1BindingNavigator)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_Contraseña)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAcusadosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_UsuarioBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_UsuarioBindingSource1BindingNavigator.ResumeLayout(False)
        Me.TBL_UsuarioBindingSource1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Ingresar As Button
    Friend WithEvents Tip_Login As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Contraseña As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BDAcusadosDataSet As BDAcusadosDataSet
    Friend WithEvents TBL_UsuarioBindingSource As BindingSource
    Friend WithEvents TBL_UsuarioTableAdapter As BDAcusadosDataSetTableAdapters.TBL_UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_UsuarioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TBL_UsuarioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BDAcusadosDataSet1 As BDAcusadosDataSet
    Friend WithEvents TBL_UsuarioBindingSource1 As BindingSource
    Friend WithEvents TBL_UsuarioTableAdapter1 As BDAcusadosDataSetTableAdapters.TBL_UsuarioTableAdapter
    Friend WithEvents TableAdapterManager1 As BDAcusadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_UsuarioBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TBL_UsuarioBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Usu_AccesoCheckBox As CheckBox
    Friend WithEvents Usu_TipoLabel1 As Label
    Friend WithEvents Usu_UsuarioLabel1 As Label
    Friend WithEvents Usu_ContraseñaLabel1 As Label
    Friend WithEvents TBL_BitacoraTableAdapter As BDAcusadosDataSetTableAdapters.TBL_BitacoraTableAdapter
End Class
