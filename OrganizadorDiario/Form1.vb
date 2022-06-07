Public Class PantallaInicio
    Public Shared listaEvento As New Lista

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim frmIngresar As New IngresarTarea()
        frmIngresar.ShowDialog()
    End Sub

    Private Sub PantallaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaEvento.Init()
    End Sub

    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Dim frmMostrar As New frmMostrar()
        frmMostrar.ShowDialog()
    End Sub
End Class
