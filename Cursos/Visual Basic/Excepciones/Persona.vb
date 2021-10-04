Public Class Persona

    Private nom As String
    Private id As String
    Private edad As Integer

    Public Sub New(nom As String, id As String, edad As Integer)

        nom = nom
        id = id
        edad = edad
    End Sub

    Public Property NombrePersona() As String
        Get
            Return nom
        End Get
        Set(value As String)
            nom = value
        End Set
    End Property

    Public Property IdPersona() As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property EdadPersona() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property
End Class
