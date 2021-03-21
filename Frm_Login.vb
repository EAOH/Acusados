Public Class Frm_Login
    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Dim C As Integer = 0
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "") Then
            For index = 0 To TBL_UsuarioBindingSource1.Count - 1
                If (Txt_Usuario.Text = Usu_UsuarioLabel1.Text And Txt_Contraseña.Text = Usu_ContraseñaLabel1.Text) Then
                    index = TBL_UsuarioBindingSource1.Count
                ElseIf ((Txt_Usuario.Text <> Usu_UsuarioLabel1.Text Or Txt_Contraseña.Text <> Usu_ContraseñaLabel1.Text) And index = TBL_UsuarioBindingSource1.Count - 1) Then
                    Usu_AccesoCheckBox.Checked = True
                    Usu_TipoLabel1.Text = ""
                Else
                    TBL_UsuarioBindingSource1.MoveNext()
                    C = C + 1
                End If
            Next
            If (Usu_AccesoCheckBox.CheckState = False) Then
                MsgBox("Se a prohibido su acceso al sistema temporalmente", MsgBoxStyle.Exclamation, "prohibido su entrada")
            Else
                Select Case Usu_TipoLabel1.Text
                    Case ""
                        MsgBox("Usuario o Contraseña Invalido.", MsgBoxStyle.Exclamation, "No encontrado")
                    Case "Detective"
                        Me.Hide()
                        Dim Formulario As New Frm_Menu_Detective
                        Formulario.Show()
                        M_Procesos.Usuario = Txt_Usuario.Text
                        M_Procesos.bitacora("Ingresar al menu detective", M_Procesos.Usuario)
                    Case "Fiscal"
                        Me.Hide()
                        Dim Formulario As New Frm_Menu_Fiscal
                        Formulario.Show()
                        M_Procesos.Usuario = Txt_Usuario.Text
                        M_Procesos.bitacora("Ingresar al menu Fiscal", M_Procesos.Usuario)
                    Case "Administrador"
                        Me.Hide()
                        Dim Formulario As New Frm_Menu_Administrador
                        Formulario.Show()
                        M_Procesos.Usuario = Txt_Usuario.Text
                        M_Procesos.bitacora("Ingresar al menu Administrador", M_Procesos.Usuario)
                End Select
            End If
        End If
        Txt_Contraseña.Text = ""
        Txt_Usuario.Text = ""
        Txt_Usuario.Select()
        For index = 0 To C
            TBL_UsuarioBindingSource1.MovePrevious()
        Next
    End Sub

    Private Sub TBL_UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TBL_UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDAcusadosDataSet)

    End Sub

    Private Sub TBL_UsuarioBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TBL_UsuarioBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_UsuarioBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BDAcusadosDataSet1)

    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet1.TBL_Bitacora' Puede moverla o quitarla según sea necesario.
        Me.TBL_BitacoraTableAdapter.Fill(Me.BDAcusadosDataSet1.TBL_Bitacora)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet1.TBL_Bitacora' Puede moverla o quitarla según sea necesario.
        Me.TBL_BitacoraTableAdapter.Fill(Me.BDAcusadosDataSet1.TBL_Bitacora)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet1.TBL_Usuario' Puede moverla o quitarla según sea necesario.
        Me.TBL_UsuarioTableAdapter1.Fill(Me.BDAcusadosDataSet1.TBL_Usuario)

    End Sub
End Class
