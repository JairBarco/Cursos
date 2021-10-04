Module Module1

    Sub Main()

        Dim numeros = New Integer() {25, 48, 17, 33, 54, 99, 103}
        Console.WriteLine(buscarArray(15, numeros))

    End Sub

    Function sumar(num1 As Integer, num2 As Integer) As Integer

        Dim resultado As Integer = num1 + num2

        Return resultado

    End Function

    Function buscarArray(num As Integer, vector() As Integer) As Integer

        Dim pos As Integer = -1

        Dim encontrado As Boolean = False

        For i = 0 To vector.Length - 1 And encontrado = False Step 1


            If vector(i) = num Then
                pos = i

                encontrado = True

            End If


        Next

        Return pos
    End Function

End Module