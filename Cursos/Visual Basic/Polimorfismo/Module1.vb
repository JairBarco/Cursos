Module Module1

    Sub Main()

        Dim estudiantes(2) As Estudiante

        estudiantes(0) = New Estudiante("Jon", "CC", "123", 18, "Street", "14515130", True)
        estudiantes(1) = New Universitario("Maria", "CC", "456", 20, "Calle", "5421", True, "Medicina")
        estudiantes(2) = New EstudiantePosgrado("Jair", "CC", "789", 23, "Streest 12", "5555", False, "Desarrollo de Software")

        Array.Sort(estudiantes)

        For Each est As Estudiante In estudiantes

            est.darDescripcion()

        Next

    End Sub

End Module