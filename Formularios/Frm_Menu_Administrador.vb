Public Class Frm_Menu_Administrador
    Private Sub Btn_Bitacora_Click(sender As Object, e As EventArgs) Handles Btn_Bitacora.Click
        Me.Close()
        Dim Formulario As New Frm_Bitacora
        Formulario.Show()
    End Sub

    Private Sub Btn_Usuarios_Click(sender As Object, e As EventArgs) Handles Btn_Usuarios.Click
        Me.Close()
        Dim Formulario As New Frm_Usuario
        Formulario.Show()
    End Sub

    Private Sub Btn_Peor_Click(sender As Object, e As EventArgs) Handles Btn_Peor.Click
        Dim Formulario As New FRM_Reportes
        Dim Reporte As New CR_Peor
        Formulario.CR_Reportes.ReportSource = Reporte
        Formulario.ShowDialog()
    End Sub

    Private Sub Btn_Taza_criminalidad_Click(sender As Object, e As EventArgs) Handles Btn_Taza_criminalidad.Click
        Dim Formulario As New FRM_Reportes
        Dim Reporte As New CR_Cant_Crimen
        Formulario.CR_Reportes.ReportSource = Reporte
        Formulario.ShowDialog()
    End Sub

    Private Sub Btn_Expediente_Click(sender As Object, e As EventArgs) Handles Btn_Expediente.Click
        Dim Formulario As New FRM_Reportes
        Dim Reporte As New CR_Expedientes
        Formulario.CR_Reportes.ReportSource = Reporte
        Formulario.ShowDialog()
    End Sub

    Private Sub Btn_Acusador_Click(sender As Object, e As EventArgs) Handles Btn_Acusador.Click
        Dim Formulario As New FRM_Reportes
        Dim Reporte As New CR_Abogado_A
        Formulario.CR_Reportes.ReportSource = Reporte
        Formulario.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Formulario As New FRM_Reportes
        Dim Reporte As New CR_Defendidos
        Formulario.CR_Reportes.ReportSource = Reporte
        Formulario.ShowDialog()
    End Sub

    Private Sub BtnCerrarSecion_Click(sender As Object, e As EventArgs) Handles btnCerrarSecion.Click
        Frm_Login.Show()
        Me.Close()
    End Sub

End Class