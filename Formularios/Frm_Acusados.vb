Public Class Frm_Acusados
    Public bandera As New Boolean
    Private Sub Frm_Acusados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado_Tel' Puede moverla o quitarla según sea necesario.
        Me.TBL_Acusado_TelTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado_Tel)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado_Tel' Puede moverla o quitarla según sea necesario.
        Me.TBL_Acusado_TelTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado_Tel)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado_Email' Puede moverla o quitarla según sea necesario.
        Me.TBL_Acusado_EmailTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado_Email)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado_Historial' Puede moverla o quitarla según sea necesario.
        Me.TBL_Acusado_HistorialTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado_Historial)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado_Rasgo' Puede moverla o quitarla según sea necesario.
        Me.TBL_Acusado_RasgoTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado_Rasgo)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Acusado' Puede moverla o quitarla según sea necesario.
        Me.TBL_AcusadoTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Acusado)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub
    Private Sub Ocultar()
        TBL_Acusado_RasgoDataGridView.Columns.Item(0).Visible = False
        TBL_Acusado_EmailDataGridView.Columns.Item(0).Visible = False
        TBL_Acusado_TelDataGridView.Columns.Item(0).Visible = False
    End Sub
    Private Sub Limpiar()
        Dim Formulario As New Frm_Acusados
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Visible = True
        Btn_Nuevo.Visible = False
        BtnEliminar.Visible = False
        Txt_Rasgo.Enabled = False
        BTN_Rasgos.Enabled = False
        Txt_Email.Enabled = False
        BTN_Email.Enabled = False
        Txt_Tel.Enabled = False
        Btn_Tel.Enabled = False
        TBL_Acusado_RasgoDataGridView.Visible = False
        TBL_Acusado_EmailDataGridView.Visible = False
        TBL_Acusado_TelDataGridView.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If (bandera = True) Then
            Btn_Cancelar.Visible = False
        Else
            Btn_Cancelar.Visible = True
        End If
        Tap_Informacion.Visible = True
        Me.Width = 1001
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Id.Text <> "" And Combo_Genero.Text <> "" And Combo_Estado.Text <> "" And Combo_Edu.Text <> "" And Txt_Nacionalidad.Text <> "" And Txt_Pais_O.Text <> "" And Txt_Depto_o.Text <> "" And Txt_Ciudad_O.Text <> "" And Txt_Ocupacion.Text <> "" And Combo_Piel.Text <> "" And Combo_Pelo.Text <> "" And Combo_Ojos.Text <> "" And Combo_Genero.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And Txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Pais.Text <> "" And Text_Depto.Text <> "" And Txt_Ciudad.Text <> "" And Txt_Pais.Text <> "" And Txt_Calle.Text <> "") Then
            Try
                'Me.TBL_FiscaliaTableAdapter.Insertar_Fiscalia(Txt_Nombre.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Pais.Text, Txt_depto.Text, Txt_ciudad.Text, Txt_Calle.Text, Txt_Extra.Text)
                M_Procesos.bitacora("Inserto un nuevo Acusado", Txt_Id.Text)
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
        If (Txt_Id.Text <> "" And Combo_Genero.Text <> "" And Combo_Estado.Text <> "" And Combo_Edu.Text <> "" And Txt_Nacionalidad.Text <> "" And Txt_Pais_O.Text <> "" And Txt_Depto_o.Text <> "" And Txt_Ciudad_O.Text <> "" And Txt_Ocupacion.Text <> "" And Combo_Piel.Text <> "" And Combo_Pelo.Text <> "" And Combo_Ojos.Text <> "" And Combo_Genero.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And Txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Pais.Text <> "" And Text_Depto.Text <> "" And Txt_Ciudad.Text <> "" And Txt_Pais.Text <> "" And Txt_Calle.Text <> "") Then
            Try
                ' Me.TBL_FiscaliaTableAdapter.Actualizar_Fiscalia(Txt_Nombre.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Pais.Text, Txt_depto.Text, Txt_ciudad.Text, Txt_Calle.Text, Txt_Extra.Text, Txt_Codigo.Text, Txt_Codigo.Text)
                M_Procesos.bitacora("Actualizo un acusado", Txt_Id.Text)
                MsgBox("Se realizo el proceso exitosamente", MsgBoxStyle.Information, "Proceso realizado")
                Limpiar()
            Catch evento As SqlClient.SqlException
                MsgBox("No se puedo guardar la informacion intente denuevo", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("Falta informacion para almacenar en la BD", "Actualizar registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        TrasladoInformacion()
        If bandera = True Then
            Tap_Informacion.Enabled = False
            Btn_Actualizar.Visible = False
        Else
            Btn_Actualizar.Visible = True
            Btn_Nuevo.Visible = False
            Btn_Guardar.Visible = False
        End If
        Habilitar()
    End Sub

    Private Sub TrasladoInformacion()
        Txt_Codigo.Text = datalistado.SelectedCells.Item(1).Value
        Txt_Nombre1.Text = datalistado.SelectedCells.Item(2).Value
        Txt_Nombre2.Text = datalistado.SelectedCells.Item(3).Value
        Txt_Apellido1.Text = datalistado.SelectedCells.Item(4).Value
        Txt_Apellido2.Text = datalistado.SelectedCells.Item(5).Value
        Txt_Id.Text = datalistado.SelectedCells.Item(6).Value
        Combo_Genero.Text = datalistado.SelectedCells.Item(7).Value
        Combo_Estado.Text = datalistado.SelectedCells.Item(8).Value
        Txt_Alias.Text = datalistado.SelectedCells.Item(9).Value
        Combo_Edu.Text = datalistado.SelectedCells.Item(10).Value
        Txt_Pais.Text = datalistado.SelectedCells.Item(11).Value
        Text_Depto.Text = datalistado.SelectedCells.Item(12).Value
        Txt_Ciudad.Text = datalistado.SelectedCells.Item(13).Value
        Txt_Calle.Text = datalistado.SelectedCells.Item(14).Value
        Txt_Extra.Text = datalistado.SelectedCells.Item(15).Value
        Date_Fecha.Value = datalistado.SelectedCells.Item(16).Value
        Txt_Nacionalidad.Text = datalistado.SelectedCells.Item(17).Value
        Txt_Pais_O.Text = datalistado.SelectedCells.Item(18).Value
        Txt_Depto_o.Text = datalistado.SelectedCells.Item(19).Value
        Txt_Ciudad_O.Text = datalistado.SelectedCells.Item(20).Value
        Nud_Alto.Value = datalistado.SelectedCells.Item(21).Value
        Nud_Peso.Value = datalistado.SelectedCells.Item(22).Value
        Combo_Piel.Text = datalistado.SelectedCells.Item(23).Value
        Combo_Pelo.Text = datalistado.SelectedCells.Item(24).Value
        Combo_Ojos.Text = datalistado.SelectedCells.Item(25).Value
        Txt_Ocupacion.Text = datalistado.SelectedCells.Item(26).Value
        ' Me.TBL_Abogado_EmailTableAdapter.Conseguir_Email(BDAcusadosDataSet.TBL_Fiscalia_Email, Txt_Codigo.Text)
        ' Me.TBL_Abogado_TelTableAdapter.Conseguir_Tel(BDAcusadosDataSet.TBL_Fiscalia_Tel, Txt_Codigo.Text)
        Ocultar()
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If (e.ColumnIndex = Me.datalistado.Columns.Item(0).Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells(0)
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
            For Each row As DataGridViewRow In datalistado.Rows
                Dim marcada As Boolean = Convert.ToBoolean(row.Cells(0).Value)
                If (marcada) Then
                    Dim llavePrimaria As Integer = Convert.ToInt32(row.Cells(1).Value)
                    M_Procesos.bitacora("Elimino un acusado", llavePrimaria)
                    'Me.TBL_FiscaliaTableAdapter.Eliminar_Fiscalia(llavePrimaria)
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
            Dim Formulario As New Frm_Menu_Detective
            Formulario.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BTN_Email_Click(sender As Object, e As EventArgs) Handles BTN_Email.Click
        If (Txt_Email.Text <> "") Then
            'Me.TBL_Fiscalia_EmailTableAdapter.Insertar_Email(Txt_Codigo.Text, Txt_Email.Text)
            'Me.TBL_Fiscalia_EmailTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Fiscalia_Email)
            Ocultar()
        Else
            MsgBox("No esta insertando nada", MsgBoxStyle.Information, "Ingrese un elemento")
        End If
    End Sub

    Private Sub BTN_tel_Click(sender As Object, e As EventArgs) Handles Btn_Tel.Click
        If (Txt_Tel.Text <> "") Then
            'Me.TBL_Fiscalia_TelTableAdapter.Insertar_Tel(Txt_Codigo.Text, Txt_Tel.Text)
            'Me.TBL_Fiscalia_TelTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Fiscalia_Tel)
            Ocultar()
        Else
            MsgBox("No esta insertando nada", MsgBoxStyle.Information, "Ingrese un elemento")
        End If
    End Sub
    Private Sub Txt_Tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Tel.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub Txt_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Id.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

End Class