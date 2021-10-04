Public Class Estudiante
    Inherits Persona
    Implements IComparable

    Private codEstudiante As String
    Private carnetEstudiante As Boolean

    Public Sub New(nom As String, tId As String, nId As String, ed As Integer, dir As String, tel As String, car As Boolean)

        MyBase.New(nom, tId, nId, ed, dir, tel)
        Me.codEstudiante = nom.Substring(0, 2) & nId.Substring(0, 2)
        carnetEstudiante = car

    End Sub

    Public Property CodigoEstudiante() As String
        Get
            Return codEstudiante
        End Get
        Set(value As String)
            codEstudiante = value
        End Set
    End Property

    Public Property Carnet_Estudiante() As Boolean
        Get
            Return carnetEstudiante
        End Get
        Set(value As Boolean)
            carnetEstudiante = value
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
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Teléfono: " & TelefonoPersona)

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

        Dim otroEstudiante As Estudiante = TryCast(obj, Estudiante)

        If Me.EdadPersona < otroEstudiante.EdadPersona Then

            Return -1

        ElseIf Me.EdadPersona = otroEstudiante.EdadPersona Then

            Return 0

        Else

            Return 1

        End If

    End Function
End Class
