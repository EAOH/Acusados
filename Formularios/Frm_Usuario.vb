Public Class Frm_Usuario
    Public bandera As New Boolean

    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Usuario' Puede moverla o quitarla según sea necesario.
        Me.TBL_UsuarioTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Usuario)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New Frm_Usuario
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Visible = True
        Btn_Nuevo.Visible = False
        BtnEliminar.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If (bandera = True) Then
            Btn_Cancelar.Visible = False
        Else
            Btn_Cancelar.Visible = True
        End If
        gbPersonal.Visible = True
        Me.Width = 716
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "" And Txt_Identidad.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Combo_Usuario.Text <> "") Then
            Try
                Me.TBL_UsuarioTableAdapter.Insertar_Usuario(Txt_Usuario.Text, Txt_Contraseña.Text, Txt_Identidad.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Combo_Usuario.Text, Check_Acceso.CheckState)
                M_Procesos.bitacora("Inserto un Usuario", Txt_Usuario.Text)
                MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
                Limpiar()
            Catch evento As SqlClient.SqlException
                MsgBox("No se puedo guardar la informacion intente con otro usuario", MsgBoxStyle.Information, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        If (Txt_Usuario.Text <> "" And Txt_Contraseña.Text <> "" And Txt_Identidad.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Combo_Usuario.Text <> "") Then
            Try
                Me.TBL_UsuarioTableAdapter.Actualizar_Usuario(Txt_Usuario.Text, Txt_Contraseña.Text, Txt_Identidad.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Combo_Usuario.Text, Check_Acceso.CheckState, Txt_Usuario.Text)
                M_Procesos.bitacora("Actualizo un usuario", Txt_Usuario.Text)
                MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
                Limpiar()
            Catch evento As SqlClient.SqlException
                MsgBox("No se puedo guardar la informacion intente denuevo", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellClick
        Txt_Usuario.Enabled = False
        trasladoInformacion()
        If bandera = True Then
            gbPersonal.Enabled = False
            Btn_Actualizar.Visible = False
        Else
            Btn_Actualizar.Visible = True
            Btn_Nuevo.Visible = False
            Btn_Guardar.Visible = False
        End If
        Habilitar()
    End Sub

    Private Sub TrasladoInformacion()
        Txt_Usuario.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Contraseña.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_Identidad.Text = Datalistado.SelectedCells.Item(3).Value
        Txt_Nombre1.Text = Datalistado.SelectedCells.Item(4).Value
        Txt_Nombre2.Text = Datalistado.SelectedCells.Item(5).Value
        txt_Apellido1.Text = Datalistado.SelectedCells.Item(6).Value
        Txt_Apellido2.Text = Datalistado.SelectedCells.Item(7).Value
        Combo_Usuario.Text = Datalistado.SelectedCells.Item(8).Value
        Check_Acceso.CheckState = (Datalistado.SelectedCells.Item(9).Value) * -1
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If (e.ColumnIndex = Me.Datalistado.Columns.Item("Eliminar").Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells("Eliminar")
            checkcell.Value = Not checkcell.Value
        End If
        Btn_Nuevo.Visible = False
        Btn_Guardar.Visible = False
        If (bandera = True) Then
            Btn_Actualizar.Visible = False
        Else
            Btn_Actualizar.Visible = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            For Each row As DataGridViewRow In Datalistado.Rows
                Dim marcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                If (marcada) Then
                    Dim llavePrimaria As String = row.Cells(1).Value
                    Me.TBL_UsuarioTableAdapter.Eliminar_Usuario(llavePrimaria)
                    M_Procesos.bitacora("Elimino un usuario", llavePrimaria)
                End If
            Next
        Catch evento As Exception
            MsgBox("Ocurrio un error no se pudo eliminar", MsgBoxStyle.Critical, "Error")
        End Try
        Limpiar()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Limpiar()
    End Sub

    Private Sub BtnCerrarSecion_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        If bandera = True Then
            Me.Close()
        Else
            Dim Formulario As New Frm_Menu_Administrador
            Formulario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Txt_Identidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Identidad.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub
End Class