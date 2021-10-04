Module Module1

    Sub Main()

        Dim numero As Integer = 5

        cambiarNumeroVariable(numero, 15)

        Console.WriteLine(numero)

    End Sub

    Sub cambiarNumeroVariable(ByRef num As Integer, ByVal numNuevo As Integer)

        num = numNuevo

    End Sub

End Module
