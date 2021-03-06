Public Class Frm_Abogado
    Public bandera As New Boolean
    Private Sub Frm_Abogado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Abogado_Tel' Puede moverla o quitarla según sea necesario.
        Me.TBL_Abogado_TelTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Abogado_Tel)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Abogado_Email' Puede moverla o quitarla según sea necesario.
        Me.TBL_Abogado_EmailTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Abogado_Email)
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Abogado' Puede moverla o quitarla según sea necesario.
        Me.TBL_AbogadoTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Abogado)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub
    Private Sub Ocultar()
        TBL_Abogado_EmailDataGridView.Columns.Item(0).Visible = False
        TBL_Abogado_TelDataGridView.Columns.Item(0).Visible = False
    End Sub
    Private Sub Limpiar()
        Dim Formulario As New Frm_Abogado
        Formulario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Btn_Guardar.Visible = True
        Btn_Nuevo.Visible = False
        BtnEliminar.Visible = False
        TabP_Contacto.Enabled = False
        TBL_Abogado_EmailDataGridView.Visible = False
        TBL_Abogado_TelDataGridView.Visible = False
        Habilitar()
    End Sub

    Private Sub Habilitar()
        If (bandera = True) Then
            Btn_Cancelar.Visible = False
        Else
            Btn_Cancelar.Visible = True
        End If
        Tap_Informacion.Visible = True
        Me.Width = 703
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2

    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_ID.Text <> "" And Combo_Genero.Text <> "" And TXT_ColegiacionN.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Pais.Text <> "" And Txt_depto.Text <> "" And Txt_ciudad.Text <> "" And Txt_Pais.Text <> "" And Txt_Calle.Text <> "") Then
            Try
                'Me.TBL_FiscaliaTableAdapter.Insertar_Fiscalia(Txt_Nombre.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Pais.Text, Txt_depto.Text, Txt_ciudad.Text, Txt_Calle.Text, Txt_Extra.Text)
                M_Procesos.bitacora("Inserto un nuevo Abogado", Txt_ID.Text)
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
        If (Txt_ID.Text <> "" And Combo_Genero.Text <> "" And TXT_ColegiacionN.Text <> "" And Txt_Nombre1.Text <> "" And Txt_Nombre2.Text <> "" And txt_Apellido1.Text <> "" And Txt_Apellido2.Text <> "" And Txt_Pais.Text <> "" And Txt_depto.Text <> "" And Txt_ciudad.Text <> "" And Txt_Pais.Text <> "" And Txt_Calle.Text <> "") Then
            Try
                ' Me.TBL_FiscaliaTableAdapter.Actualizar_Fiscalia(Txt_Nombre.Text, Txt_Nombre1.Text, Txt_Nombre2.Text, txt_Apellido1.Text, Txt_Apellido2.Text, Txt_Pais.Text, Txt_depto.Text, Txt_ciudad.Text, Txt_Calle.Text, Txt_Extra.Text, Txt_Codigo.Text, Txt_Codigo.Text)
                M_Procesos.bitacora("Actualizo un Abogado", Txt_ID.Text)
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
        Txt_ID.Text = datalistado.SelectedCells.Item(2).Value
        Combo_Genero.Text = datalistado.SelectedCells.Item(3).Value
        TXT_ColegiacionN.Text = datalistado.SelectedCells.Item(4).Value
        Date_FechaC.Value = datalistado.SelectedCells.Item(5).Value
        Date_Inicio.Value = datalistado.SelectedCells.Item(6).Value
        Txt_Nombre1.Text = datalistado.SelectedCells.Item(7).Value
        Txt_Nombre2.Text = datalistado.SelectedCells.Item(8).Value
        txt_Apellido1.Text = datalistado.SelectedCells.Item(9).Value
        Txt_Apellido2.Text = datalistado.SelectedCells.Item(10).Value
        Txt_Pais.Text = datalistado.SelectedCells.Item(11).Value
        Txt_depto.Text = datalistado.SelectedCells.Item(12).Value
        Txt_ciudad.Text = datalistado.SelectedCells.Item(13).Value
        Txt_Calle.Text = datalistado.SelectedCells.Item(14).Value
        Txt_Extra.Text = datalistado.SelectedCells.Item(15).Value
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
                    'Me.TBL_FiscaliaTableAdapter.Eliminar_Fiscalia(llavePrimaria)
                    M_Procesos.bitacora("Elimino un Abogado", llavePrimaria)
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
            Dim Formulario As New Frm_Menu_Fiscal
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

    Private Sub BTN_tel_Click(sender As Object, e As EventArgs) Handles BTN_tel.Click
        If (Txt_Tel.Text <> "") Then
            'Me.TBL_Fiscalia_TelTableAdapter.Insertar_Tel(Txt_Codigo.Text, Txt_Tel.Text)
            'Me.TBL_Fiscalia_TelTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Fiscalia_Tel)
            Ocultar()
        Else
            MsgBox("No esta insertando nada", MsgBoxStyle.Information, "Ingrese un elemento")
        End If
    End Sub
    Private Sub Txt_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ID.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub TXT_ColegiacionN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ColegiacionN.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub Txt_Tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Tel.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub
End Class