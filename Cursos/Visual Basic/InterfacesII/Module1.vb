Module Module1

    Sub Main()
        Dim numeros = New Integer() {10, 8, 23, 5, 7}

        Array.Sort(numeros)

        For Each num As Integer In numeros
            Console.Write(num & " ")
        Next

    End Sub

End Module
