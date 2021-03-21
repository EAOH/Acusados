<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Reportes))
        Me.CR_Reportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CR_Reportes
        '
        Me.CR_Reportes.ActiveViewIndex = -1
        Me.CR_Reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_Reportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_Reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CR_Reportes.Location = New System.Drawing.Point(0, 0)
        Me.CR_Reportes.Name = "CR_Reportes"
        Me.CR_Reportes.Size = New System.Drawing.Size(800, 450)
        Me.CR_Reportes.TabIndex = 0
        Me.CR_Reportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FRM_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CR_Reportes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_Reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CR_Reportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
