Module Module1

    Sub Main()

        Dim miObjeto As Object = New Persona("Juan", 18)

        Dim miPersona As Persona = TryCast(miObjeto, Persona)

        Console.WriteLine(miPersona.getEdad)
    End Sub

End Module
