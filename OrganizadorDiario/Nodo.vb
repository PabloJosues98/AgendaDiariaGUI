Public Class Nodo
    Public dato As Object
    Public sig As Nodo
    Public ant As Nodo

    Public Sub Init(d As Object)
        Me.dato = d
        Me.sig = Nothing
        Me.ant = Nothing
    End Sub
End Class
