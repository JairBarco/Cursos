Module Module1

    Sub Main()

        Dim cliente1 As Cliente = New Cliente("Juan Martinez", "12345", "Mi casa", "3333")
        Dim cuenta1 As CuentaAhorros = New CuentaAhorros(1000, cliente1)

        cuenta1.depositarDinero(1000)
        Console.WriteLine(cuenta1.getSaldo)

        Console.WriteLine(cuenta1.clienteCuenta.nombreCliente)

    End Sub

End Module
