Public Class Universitario
    Inherits Estudiante

    Private programa As String

    Public Sub New(nom As String, tId As String, nId As String, ed As Integer, dir As String, tel As String, car As Boolean, pr As String)

        MyBase.New(nom, tId, nId, ed, dir, tel, car)
        programa = pr

    End Sub

    Public Property ProgramaEstudiante() As String
        Get
            Return programa
        End Get
        Set(value As String)
            programa = value
        End Set
    End Property

    Public Overrides Sub darDescripcion()

        Console.WriteLine("========================")
        Console.WriteLine("")
        Console.WriteLine("Datos del Estudiante")
        Console.WriteLine("Nombres: " & NombrePersona)
        Console.WriteLine("Tipo de Identificacion: " & TipoIdentificacion)
        Console.WriteLine("Número de Identificación: " & NumeroIdentificacion)
        Console.WriteLine("Código Estudiantil: " & CodigoEstudiante)
        Console.WriteLine("Carnet Estudiantil: " & Carnet_Estudiante)
        Console.WriteLine("Porgrama de Pregrado: " & ProgramaEstudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Teléfono: " & TelefonoPersona)

    End Sub
End Class
