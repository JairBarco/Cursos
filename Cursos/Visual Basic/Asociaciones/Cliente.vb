Public Class Cliente

    Private nombre As String
    Private cedula As String
    Private direccion As String
    Private telefono As String


    Public Sub New()



    End Sub

    Public Sub New(nom As String, ce As String, di As String, te As String)

        nombre = nom
        cedula = ce
        direccion = di
        telefono = te

    End Sub

    Public Property nombreCliente() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property cedulaCliente() As String
        Get
            Return cedula
        End Get
        Set(value As String)
            cedula = value
        End Set
    End Property

    Public Property direccionCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property telefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
