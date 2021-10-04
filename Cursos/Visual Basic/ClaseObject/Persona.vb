Public Class Persona

    Private nombre As String
    Private edad As Integer

    Public Sub New(nom As String, ed As Integer)
        nombre = nom
        edad = ed
    End Sub

    Public Function getNombres() As String
        Return nombre
    End Function

    Public Function getEdad() As Integer
        Return edad
    End Function

End Class
