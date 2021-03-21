Public Class Frm_Menu_Fiscal
    Private Sub Btn_Fiscalía_Click(sender As Object, e As EventArgs) Handles Btn_Fiscalía.Click
        Dim Formulario As New FRM_Fiscalia
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrarSecion_Click(sender As Object, e As EventArgs) Handles btnCerrarSecion.Click
        Frm_Login.Show()
        Me.Close()
    End Sub

    Private Sub btn_Delito_Click(sender As Object, e As EventArgs) Handles btn_Delito.Click
        Dim Formulario As New Frm_Delito
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Abogado_Click(sender As Object, e As EventArgs) Handles Btn_Abogado.Click
        Dim Formulario As New Frm_Abogado
        Formulario.Show()
        Me.Close()
    End Sub
End Class