Public Class Evento
    Private tipo As String
    Private prioridad As String
    Private descripcion As String
    Private horaLimite As String

    Public Function crearEvento(tip As String, priori As String, descrip As String, horaLimit As String) As Evento
        Me.tipo = tip
        Me.prioridad = priori
        Me.descripcion = descrip
        Me.horaLimite = horaLimit
        Return Me
    End Function

    Public Function getTipo() As String
        Return Me.tipo
    End Function

    Public Function getPrioridad() As String
        Return Me.prioridad
    End Function

    Public Function getDescripion() As String
        Return Me.descripcion
    End Function

    Public Function getHoraLimite() As String
        Return Me.horaLimite
    End Function
End Class
