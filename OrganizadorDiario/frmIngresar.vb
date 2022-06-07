Public Class IngresarTarea
    Private priori As String
    Private err As Boolean
    Private hora As Integer
    Private minuto As Integer
    Private tiempo As Boolean = False

    Private Sub CboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.SelectedIndex = 3 Then
            txtTipo.Visible = True
            lblTipoPersonalizado.Visible = True
        Else
            txtTipo.Text = ""
            txtTipo.Visible = False
            lblTipoPersonalizado.Visible = False
        End If
    End Sub

    Private Sub Ingresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbNo.Checked = True
        cboPrioridad.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        err = False
        tiempo = False
    End Sub

    Private Sub RdbSi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSi.CheckedChanged
        lblHora.Visible = True
        lblMinuto.Visible = True
        lblPuntos.Visible = True
        txtHora.Visible = True
        txtMinuto.Visible = True
        tiempo = True
    End Sub

    Private Sub RdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
        lblHora.Visible = False
        lblMinuto.Visible = False
        lblPuntos.Visible = False
        txtHora.Text = ""
        txtHora.Visible = False
        txtMinuto.Text = ""
        txtMinuto.Visible = False
        err = False
        tiempo = False
    End Sub

    Private Sub CmdIngresarTarea_Click(sender As Object, e As EventArgs) Handles cmdIngresarTarea.Click
        Dim tipo As String = ""
        Dim descrip As String
        Dim horaLimite As String = ""

        If cboTipo.SelectedIndex = 3 Then
            tipo = txtTipo.Text
        ElseIf cboTipo.SelectedIndex >= 0 And cboTipo.SelectedIndex <= 2 Then
            tipo = cboTipo.Text
        End If
        descrip = txtDescripcion.Text
        If tiempo = True Then
            If txtHora.Text > 23 Or txtHora.Text < 0 Then
                err = True
            Else
                hora = txtHora.Text
                If txtMinuto.Text > 59 Or txtMinuto.Text < 0 Then
                    err = True
                Else
                    minuto = txtMinuto.Text
                    horaLimite = Str(hora) & ":" & Str(minuto)
                End If
            End If
        End If

        If err = True Then
            MessageBox.Show("error al ingresar la hora, formato correto 23:59")
        Else
            Try
                If tiempo = False Then
                    horaLimite = "No tiene"
                End If
                PantallaInicio.listaEvento.agregar(tipo, priori, descrip, horaLimite)
                Dim objEvento As Evento = PantallaInicio.listaEvento.getUltimo()
                MessageBox.Show("Evento creado exitosamente")
                txtTipo.ResetText()
                txtDescripcion.ResetText()
                txtHora.ResetText()
                txtMinuto.ResetText()
                rdbNo.Checked = True
                cboPrioridad.SelectedIndex = 0
                cboTipo.SelectedIndex = 0
                err = False
                tiempo = False
            Catch ex As Exception
                MessageBox.Show("error: " & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub CboPrioridad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrioridad.SelectedIndexChanged
        If cboPrioridad.SelectedIndex = 0 Then
            priori = cboPrioridad.Text
        ElseIf cboPrioridad.SelectedIndex = 1 Then
            priori = cboPrioridad.Text
        ElseIf cboPrioridad.SelectedIndex = 2 Then
            priori = cboPrioridad.Text
        ElseIf cboPrioridad.SelectedIndex = 3 Then
            priori = cboPrioridad.Text
        ElseIf cboPrioridad.SelectedIndex = 4 Then
            priori = cboPrioridad.Text
        ElseIf cboPrioridad.SelectedIndex = 5 Then
            priori = cboPrioridad.Text
        End If
    End Sub
End Class