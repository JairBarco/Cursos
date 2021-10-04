Module Module1

    Sub Main()

        Dim cadena1 As String = "Jair Martinez Barco"
        Dim cadena2 As String = "jair martinez barco"

        Console.WriteLine(cadena1.ToUpper())
        Console.WriteLine(cadena1.ToLower())
        Console.WriteLine(cadena1.Substring(5, 8))
        Console.WriteLine(cadena2.Length())
        Console.WriteLine((cadena1.ToUpper).Equals(cadena2.ToUpper))

    End Sub

End Module
