Module Module1

    Sub Main()

        Dim numeros = New Integer() {1, 2, 3, 4}

        ReDim Preserve numeros(10)
        For i = 3 To numeros.Length - 1 Step 1
            Console.Write("Ingrese el numero de la posicion " & (i + 1) & ": ")
            numeros(i) = Console.ReadLine()
        Next

        For Each num As Integer In numeros
            Console.WriteLine(num)
        Next

    End Sub

End Module
