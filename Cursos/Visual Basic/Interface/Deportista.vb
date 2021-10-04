Public Class Deportista

    Private nombres As String
    Private posicion As String
    Private edad As Integer
    Private estatura As Double

    Public Sub New()

    End Sub

    Public Sub New(nom As String, pos As String, e As Integer, est As Double)

        nombres = nom
        posicion = pos
        edad = e
        estatura = est

    End Sub

    Public Property NombreDeportista() As String
        Get
            Return nombres
        End Get
        Set(value As String)
            nombres = value
        End Set
    End Property

    Public Property PosicionDeportista() As String
        Get
            Return posicion
        End Get
        Set(value As String)
            posicion = value
        End Set
    End Property

    Public Property EdadDeportista() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property EstaturaDeportista() As Double
        Get
            Return estatura
        End Get
        Set(value As Double)
            estatura = value
        End Set
    End Property

End Class
