Public Class Lista
    Private primero As Nodo
    Private ultimo As Nodo
    Public Sub Init()
        Me.primero = Nothing
        Me.ultimo = Nothing
    End Sub

    Public Sub agregar(tip As String, priori As String, descrip As String, horaLimit As String)
        Dim nuevoNodo As New Nodo
        Dim objEvento As New Evento
        objEvento.crearEvento(tip, priori, descrip, horaLimit)
        nuevoNodo.Init(objEvento)
        'Se revisa si existe algun valor en el ultimo de lista, sino se guarda en el primero
        If IsNothing(Me.ultimo) Then
            Me.primero = nuevoNodo
        Else
            Me.ultimo.sig = nuevoNodo
            nuevoNodo.ant = Me.ultimo
        End If
        Me.ultimo = nuevoNodo
    End Sub

    Public Function lenLista() As Integer
        Dim nodoTmp As Nodo = New Nodo()
        Dim cont As Integer = 0
        nodoTmp.Init("")
        nodoTmp = Me.primero
        While Not IsNothing(nodoTmp)
            cont += 1
            nodoTmp = nodoTmp.sig
        End While
        Return cont
    End Function

    Public Function getUltimo() As Object
        Return Me.ultimo.dato
    End Function
    Public Function obtenerContenido(pos As Integer) As Object
        Dim nodoTmp As New Nodo
        Dim cont As Integer
        nodoTmp.Init("")
        nodoTmp = Me.primero
        For cont = 0 To pos - 1
            nodoTmp = nodoTmp.sig
        Next
        Return nodoTmp.dato
    End Function
End Class
