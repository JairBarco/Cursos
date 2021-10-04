Module Module1

    Sub Main()

        Dim matrizOrigen = New Integer(,) {{14, 28}, {56, 70}}
        Dim matrizCopia(2, 2) As Integer

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1
                matrizCopia(i, j) = matrizOrigen(i, j)
                Console.WriteLine(matrizCopia(i, j))
            Next

        Next
    End Sub

End Module
