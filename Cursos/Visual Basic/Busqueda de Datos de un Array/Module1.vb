Module Module1

    Sub Main()

        Dim edades = New Integer() {25, 21, 43, 58, 34}

        Dim edad As Integer

        Dim encontrado As Boolean = False

        Dim finded As Integer

        Console.Write("Ingrese el Numero a Buscar: ")
        edad = Console.ReadLine()

        For i = 0 To edades.Length - 1 And encontrado = False Step 1
            If (edad = edades(i)) Then

                Dim indice As Integer = i
                encontrado = True
                finded = edades(i)

                Console.WriteLine("El numero fue encontrado en la posicion: " & indice)
            End If

        Next

    End Sub

End Module
