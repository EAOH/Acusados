Public Class Frm_Bitacora
    Private Sub TBL_BitacoraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TBL_BitacoraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDAcusadosDataSet)

    End Sub

    Private Sub Frm_Bitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Bitacora' Puede moverla o quitarla según sea necesario.
        Me.TBL_BitacoraTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Bitacora)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Bitacora' Puede moverla o quitarla según sea necesario.
        Me.TBL_BitacoraTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Bitacora)
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Dim Formulario As New Frm_Menu_Administrador
        Formulario.Show()
        Me.Close()
    End Sub
End Class