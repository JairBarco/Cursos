Module Module1

    Sub Main()

        Dim nom, id As String
        Dim edad As Integer

        Try

            Console.Write("Ingrese el nombre de la persona: ")
            nom = Console.ReadLine

            Console.Write("Ingrese el numero de identificacion de la persona: ")
            id = Console.ReadLine

            Console.Write("Ingrese la edad de la persona: ")
            edad = Console.ReadLine

            Dim p As New Persona(nom, id, edad)

        Catch ex As InvalidCastException

            Console.WriteLine("Error al ingresar los datos")

        End Try


    End Sub

End Module
