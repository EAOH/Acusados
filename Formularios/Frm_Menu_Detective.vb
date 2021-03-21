Public Class Frm_Menu_Detective
    Private Sub btnCerrarSecion_Click(sender As Object, e As EventArgs) Handles btnCerrarSecion.Click
        Frm_Login.Show()
        Me.Close()
    End Sub

    Private Sub Btn__Acusado_Click(sender As Object, e As EventArgs) Handles Btn__Acusado.Click
        Dim Formulario As New Frm_Acusados
        Formulario.Show()
        Me.Close()
    End Sub
End Class