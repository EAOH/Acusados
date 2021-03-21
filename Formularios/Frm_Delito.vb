Public Class Frm_Delito
    Public bandera As New Boolean
    Private Sub Frm_Delito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAcusadosDataSet.TBL_Delito' Puede moverla o quitarla según sea necesario.
        Me.TBL_DelitoTableAdapter.Fill(Me.BDAcusadosDataSet.TBL_Delito)
        If (bandera = True) Then
            Btn_Nuevo.Visible = False
            BtnEliminar.Visible = False
            Regresar.Text = "Cargar"
        End If
    End Sub

    Private Sub Limpiar()
        Dim Formulario As New Frm_Delito
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
        Me.Width = 709
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If (Txt_Nombre.Text <> "" And Txt_Nivel.Text <> "" And Txt_PenaM.Text <> "" And Txt_Dia.Text <> "" And txt_Mes.Text <> "" And Txt_Año.Text <> "" And Txt_Fianza.Text <> "") Then
            Try
                Me.TBL_DelitoTableAdapter.Insertar_Delito(Txt_Nombre.Text, Txt_Nivel.Text, Txt_PenaM.Text, Txt_Dia.Text, txt_Mes.Text, Txt_Año.Text, Txt_Fianza.Text)
                M_Procesos.bitacora("Inserto un nuevo delito", Txt_Nombre.Text)
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
        If (Txt_Nombre.Text <> "" And Txt_Nivel.Text <> "" And Txt_PenaM.Text <> "" And Txt_Dia.Text <> "" And txt_Mes.Text <> "" And Txt_Año.Text <> "" And Txt_Fianza.Text <> "") Then
            Try
                Me.TBL_DelitoTableAdapter.Actualizar_Delito(Txt_Nombre.Text, Txt_Nivel.Text, Txt_PenaM.Text, Txt_Dia.Text, txt_Mes.Text, Txt_Año.Text, Txt_Fianza.Text, Txt_Codigo.Text, Txt_Codigo.Text)
                M_Procesos.bitacora("Actualizo un delito", Txt_Nombre.Text)
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
        TrasladoInformacion()
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
        Txt_Codigo.Text = Datalistado.SelectedCells.Item(1).Value
        Txt_Nombre.Text = Datalistado.SelectedCells.Item(2).Value
        Txt_Nivel.Text = Datalistado.SelectedCells.Item(3).Value
        Txt_PenaM.Text = Datalistado.SelectedCells.Item(4).Value
        Txt_Dia.Text = Datalistado.SelectedCells.Item(5).Value
        txt_Mes.Text = Datalistado.SelectedCells.Item(6).Value
        Txt_Año.Text = Datalistado.SelectedCells.Item(7).Value
        Txt_Fianza.Text = Datalistado.SelectedCells.Item(8).Value
    End Sub

    Private Sub DataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datalistado.CellContentClick
        If (e.ColumnIndex = Me.Datalistado.Columns.Item(0).Index) Then
            Dim checkcell As DataGridViewCheckBoxCell = Me.Datalistado.Rows(e.RowIndex).Cells(0)
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
                    Dim llavePrimaria As String = Convert.ToInt32(row.Cells(1).Value)
                    Me.TBL_DelitoTableAdapter.Eliminar_Delito(llavePrimaria)
                    M_Procesos.bitacora("Elimino un delito", llavePrimaria)
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

    Private Sub Txt_Nivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nivel.KeyPress
        e.Handled = M_Procesos.ValidarDouble(e.KeyChar, Txt_Nivel.Text)
    End Sub

    Private Sub Txt_Dia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Dia.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub Txt_Mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Mes.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub Txt_Año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Año.KeyPress
        e.Handled = M_Procesos.ValidarInteger(e.KeyChar)
    End Sub

    Private Sub Txt_Fianza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Fianza.KeyPress
        e.Handled = M_Procesos.ValidarDouble(e.KeyChar, Txt_Fianza.Text)
    End Sub
End Class