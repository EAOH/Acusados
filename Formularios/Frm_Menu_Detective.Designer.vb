<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu_Detective
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu_Detective))
        Me.Btn_Expediente = New System.Windows.Forms.Button()
        Me.Btn__Acusado = New System.Windows.Forms.Button()
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.Tip_Detective = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Btn_Expediente
        '
        Me.Btn_Expediente.BackColor = System.Drawing.Color.Navy
        Me.Btn_Expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Expediente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Expediente.ForeColor = System.Drawing.Color.White
        Me.Btn_Expediente.Location = New System.Drawing.Point(150, 12)
        Me.Btn_Expediente.Name = "Btn_Expediente"
        Me.Btn_Expediente.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Expediente.TabIndex = 21
        Me.Btn_Expediente.Text = "Mantenimiento del Expediente"
        Me.Tip_Detective.SetToolTip(Me.Btn_Expediente, "Entrar al formulario de expedientes")
        Me.Btn_Expediente.UseVisualStyleBackColor = False
        '
        'Btn__Acusado
        '
        Me.Btn__Acusado.BackColor = System.Drawing.Color.Navy
        Me.Btn__Acusado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn__Acusado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn__Acusado.ForeColor = System.Drawing.Color.White
        Me.Btn__Acusado.Location = New System.Drawing.Point(12, 12)
        Me.Btn__Acusado.Name = "Btn__Acusado"
        Me.Btn__Acusado.Size = New System.Drawing.Size(132, 100)
        Me.Btn__Acusado.TabIndex = 20
        Me.Btn__Acusado.Text = "Mantenimiento del  Acusado"
        Me.Tip_Detective.SetToolTip(Me.Btn__Acusado, "Entrar al formulario de acusados")
        Me.Btn__Acusado.UseVisualStyleBackColor = False
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.Navy
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(106, 118)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(83, 54)
        Me.btnCerrarSecion.TabIndex = 19
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.Tip_Detective.SetToolTip(Me.btnCerrarSecion, "Salir de la Cuenta")
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'Tip_Detective
        '
        Me.Tip_Detective.BackColor = System.Drawing.Color.White
        Me.Tip_Detective.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Detective.ToolTipTitle = "Información"
        '
        'Frm_Menu_Detective
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(301, 191)
        Me.Controls.Add(Me.Btn_Expediente)
        Me.Controls.Add(Me.Btn__Acusado)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu_Detective"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal del detective"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Expediente As Button
    Friend WithEvents Btn__Acusado As Button
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents Tip_Detective As ToolTip
End Class
