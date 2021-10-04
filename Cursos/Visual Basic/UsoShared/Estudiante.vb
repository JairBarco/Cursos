Public Class Estudiante

    Private codigoEstudiante As Integer
    Private nombres As String

    Private Shared codigo As Integer = 1

    Public Sub New(nom As String)

        nombres = nom
        codigoEstudiante = codigo

        codigo += 1
    End Sub

    Public Function getCodigoEstudiante() As Integer

        Return codigoEstudiante

    End Function

    Public Function getNombre() As String

        Return nombres

    End Function

End Class
