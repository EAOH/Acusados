<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Menu_Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu_Administrador))
        Me.Btn_Peor = New System.Windows.Forms.Button()
        Me.Btn_Bitacora = New System.Windows.Forms.Button()
        Me.Btn_Usuarios = New System.Windows.Forms.Button()
        Me.btnCerrarSecion = New System.Windows.Forms.Button()
        Me.Tip_Fiscal = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Expediente = New System.Windows.Forms.Button()
        Me.Btn_Acusador = New System.Windows.Forms.Button()
        Me.Btn_Taza_criminalidad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Peor
        '
        Me.Btn_Peor.BackColor = System.Drawing.Color.Navy
        Me.Btn_Peor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Peor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Peor.ForeColor = System.Drawing.Color.White
        Me.Btn_Peor.Location = New System.Drawing.Point(287, 12)
        Me.Btn_Peor.Name = "Btn_Peor"
        Me.Btn_Peor.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Peor.TabIndex = 29
        Me.Btn_Peor.Text = "Mostrar reporte del acusado con mas crimenes"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Peor, "Muestra un reporte")
        Me.Btn_Peor.UseVisualStyleBackColor = False
        '
        'Btn_Bitacora
        '
        Me.Btn_Bitacora.BackColor = System.Drawing.Color.Navy
        Me.Btn_Bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Bitacora.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Bitacora.ForeColor = System.Drawing.Color.White
        Me.Btn_Bitacora.Location = New System.Drawing.Point(150, 12)
        Me.Btn_Bitacora.Name = "Btn_Bitacora"
        Me.Btn_Bitacora.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Bitacora.TabIndex = 28
        Me.Btn_Bitacora.Text = "Mostrar bitacora"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Bitacora, "Mostrar bitacora")
        Me.Btn_Bitacora.UseVisualStyleBackColor = False
        '
        'Btn_Usuarios
        '
        Me.Btn_Usuarios.BackColor = System.Drawing.Color.Navy
        Me.Btn_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Usuarios.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Usuarios.ForeColor = System.Drawing.Color.White
        Me.Btn_Usuarios.Location = New System.Drawing.Point(12, 12)
        Me.Btn_Usuarios.Name = "Btn_Usuarios"
        Me.Btn_Usuarios.Size = New System.Drawing.Size(132, 100)
        Me.Btn_Usuarios.TabIndex = 27
        Me.Btn_Usuarios.Text = "Mantenimiento de los Usuarios"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Usuarios, "Enviar al formulario de los usuario")
        Me.Btn_Usuarios.UseVisualStyleBackColor = False
        '
        'btnCerrarSecion
        '
        Me.btnCerrarSecion.BackColor = System.Drawing.Color.Navy
        Me.btnCerrarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarSecion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSecion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSecion.Location = New System.Drawing.Point(448, 141)
        Me.btnCerrarSecion.Name = "btnCerrarSecion"
        Me.btnCerrarSecion.Size = New System.Drawing.Size(83, 54)
        Me.btnCerrarSecion.TabIndex = 26
        Me.btnCerrarSecion.Text = "Cerrar Sesion"
        Me.btnCerrarSecion.UseVisualStyleBackColor = False
        '
        'Tip_Fiscal
        '
        Me.Tip_Fiscal.BackColor = System.Drawing.Color.White
        Me.Tip_Fiscal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip_Fiscal.ToolTipTitle = "Información"
        '
        'Btn_Expediente
        '
        Me.Btn_Expediente.BackColor = System.Drawing.Color.Navy
        Me.Btn_Expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Expediente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Expediente.ForeColor = System.Drawing.Color.White
        Me.Btn_Expediente.Location = New System.Drawing.Point(12, 118)
        Me.Btn_Expediente.Name = "Btn_Expediente"
        Me.Btn_Expediente.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Expediente.TabIndex = 30
        Me.Btn_Expediente.Text = "Mostrar reporte del expediente de un acusado"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Expediente, "Muestra un reporte")
        Me.Btn_Expediente.UseVisualStyleBackColor = False
        '
        'Btn_Acusador
        '
        Me.Btn_Acusador.BackColor = System.Drawing.Color.Navy
        Me.Btn_Acusador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Acusador.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acusador.ForeColor = System.Drawing.Color.White
        Me.Btn_Acusador.Location = New System.Drawing.Point(149, 118)
        Me.Btn_Acusador.Name = "Btn_Acusador"
        Me.Btn_Acusador.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Acusador.TabIndex = 31
        Me.Btn_Acusador.Text = "Mostrar reporte de abogado acusador"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Acusador, "Muestra un reporte")
        Me.Btn_Acusador.UseVisualStyleBackColor = False
        '
        'Btn_Taza_criminalidad
        '
        Me.Btn_Taza_criminalidad.BackColor = System.Drawing.Color.Navy
        Me.Btn_Taza_criminalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Taza_criminalidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Taza_criminalidad.ForeColor = System.Drawing.Color.White
        Me.Btn_Taza_criminalidad.Location = New System.Drawing.Point(424, 12)
        Me.Btn_Taza_criminalidad.Name = "Btn_Taza_criminalidad"
        Me.Btn_Taza_criminalidad.Size = New System.Drawing.Size(131, 100)
        Me.Btn_Taza_criminalidad.TabIndex = 32
        Me.Btn_Taza_criminalidad.Text = "Reporte de cantidad de acusados por crimen"
        Me.Tip_Fiscal.SetToolTip(Me.Btn_Taza_criminalidad, "Muestra un reporte")
        Me.Btn_Taza_criminalidad.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(287, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 100)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Mostrar reporte acusados defendidos"
        Me.Tip_Fiscal.SetToolTip(Me.Button1, "Muestra un reporte")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_Menu_Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(575, 237)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Taza_criminalidad)
        Me.Controls.Add(Me.Btn_Acusador)
        Me.Controls.Add(Me.Btn_Expediente)
        Me.Controls.Add(Me.Btn_Peor)
        Me.Controls.Add(Me.Btn_Bitacora)
        Me.Controls.Add(Me.Btn_Usuarios)
        Me.Controls.Add(Me.btnCerrarSecion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Menu_Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal administrador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Peor As Button
    Friend WithEvents Tip_Fiscal As ToolTip
    Friend WithEvents Btn_Bitacora As Button
    Friend WithEvents Btn_Usuarios As Button
    Friend WithEvents btnCerrarSecion As Button
    Friend WithEvents Btn_Expediente As Button
    Friend WithEvents Btn_Acusador As Button
    Friend WithEvents Btn_Taza_criminalidad As Button
    Friend WithEvents Button1 As Button
End Class
