Public Class frmMostrar
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub frmMostrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To PantallaInicio.listaEvento.lenLista() - 1
            Dim objEvento As Evento = PantallaInicio.listaEvento.obtenerContenido(i)
            dgvDatos.Rows.Add(objEvento.getTipo(), objEvento.getDescripion(), objEvento.getPrioridad(), objEvento.getHoraLimite())
            MessageBox.Show("numero de objeto: " & Str(i) & " / " & objEvento.getDescripion())
        Next
    End Sub
End Class