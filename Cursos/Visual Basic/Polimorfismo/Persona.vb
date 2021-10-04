Public MustInherit Class Persona

    Private nombre As String
    Private tipoId As String
    Private numId As String
    Private edad As Integer
    Private direccion As String
    Private telefono As String

    Public Sub New(nom As String, tId As String, nId As String, ed As Integer, dir As String, tel As String)

        nombre = nom
        tipoId = tId
        numId = nId
        edad = ed
        direccion = dir
        telefono = tel

    End Sub

    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property TipoIdentificacion() As String
        Get
            Return tipoId
        End Get
        Set(value As String)
            tipoId = value
        End Set
    End Property

    Public Property NumeroIdentificacion() As String
        Get
            Return numId
        End Get
        Set(value As String)
            numId = value
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

    Public Property DireccionPersona() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoPersona() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public MustOverride Sub darDescripcion()

End Class
