Public Class EstudiantePosgrado
    Inherits Universitario

    Public Sub New(nom As String, tId As String, nId As String, ed As Integer, dir As String, tel As String, car As Boolean, pr As String)

        MyBase.New(nom, tId, nId, ed, dir, tel, car, pr)

    End Sub

    Public Overrides Sub darDescripcion()

        Console.WriteLine("========================")
        Console.WriteLine("")
        Console.WriteLine("Datos del Estudiante")
        Console.WriteLine("Nombres: " & NombrePersona)
        Console.WriteLine("Tipo de Identificacion: " & TipoIdentificacion)
        Console.WriteLine("Número de Identificación: " & NumeroIdentificacion)
        Console.WriteLine("Código Estudiantil: " & CodigoEstudiante)
        Console.WriteLine("Carnet Estudiantil: " & Carnet_Estudiante)
        Console.WriteLine("Porgrama de Posgrado: " & ProgramaEstudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Teléfono: " & TelefonoPersona)

    End Sub
End Class
