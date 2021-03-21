<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu_Fiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu_Fiscal))
        Me.Tip_Fiscal = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Delito = New System.Windows.Forms.Button()
        Me.Btn_Fiscalía = New System.Windows.Forms.Button()
        Me.Btn_Abogado = New System.Windows.Forms.Button()
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tip_Fiscal
        '
        Me.Tip_Fiscal.BackColor = System.Drawing.Color.White
        Me.Tip_Fiscal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Fiscal.ToolTipTitle = "Información"
        '
        'btn_Delito
        '
        Me.btn_Delito.BackColor = System.Drawing.Color.Navy
        Me.btn_Delito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Delito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Delito.ForeColor = System.Drawing.Color.White
        Me.btn_Delito.Location = New System.Drawing.Point(150, 12)
        Me.btn_Delito.Name = "btn_Delito"
        Me.btn_Delito.Size = New System.Drawing.Size(131, 100)
        Me.btn_Delito.TabIndex = 24
        Me.btn_Delito.Text = "Mantenimiento de los delitos"
        Me.Tip_Fiscal.SetToolTip(Me.btn_Delito, "Enviar al formulario de los delitos")
        Me.btn_Delito.UseVisualStyleBackColor = False
        '
        'Btn_Fiscalía
        '
        Me.Btn_Fiscalía.BackColor = System.Drawing.Color.Navy
        Me.Btn_Fiscalía.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Fiscalía.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Fiscalía.ForeColor = System.Drawing.Color.White
        Me.Btn_Fiscalía.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Fiscalía.Name = "Btn_Fiscalía"
        Me.Btn_Fiscalía.Size = New System.Drawing.Size(132, 100)
        Me.Btn_Fiscalía.TabIndex = 23
        Me.Btn_Fiscalía.Text = "Mantenimiento de la fiscalía"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Fiscalía, "Enviar al formulario de la fiscalía")
        Me.Btn_Fiscalía.UseVisualStyleBackColor = False
        '
        'Btn_Abogado
        '
        Me.Btn_Abogado.BackColor = System.Drawing.Color.Navy
        Me.Btn_Abogado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Abogado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Abogado.ForeColor = System.Drawing.Color.White
        Me.Btn_Abogado.Location = New System.Drawing.Point(287, 12)
        Me.Btn_Abogado.Name = "Btn_Abogado"
        Me.Btn_Abogado.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Abogado.TabIndex = 25
        Me.Btn_Abogado.Text = "Mantenimiento del abogado"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Abogado, "Enviar al formulario de los abogados")
        Me.Btn_Abogado.UseVisualStyleBackColor = False
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.Navy
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(174, 118)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(83, 54)
        Me.btnCerrarSecion.TabIndex = 22
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'Frm_Menu_Fiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(430, 186)
        Me.Controls.Add(Me.Btn_Abogado)
        Me.Controls.Add(Me.btn_Delito)
        Me.Controls.Add(Me.Btn_Fiscalía)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu_Fiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal del fical"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tip_Fiscal As ToolTip
    Friend WithEvents btn_Delito As Button
    Friend WithEvents Btn_Fiscalía As Button
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents Btn_Abogado As Button
End Class
