Module Module1
    Sub Main()

        Dim banco As New Banco("XYZ")

        banco.crearCuentaCliente(New Cliente("Jair", "1910873", "Calle Y", "1234"), 1000)
        banco.crearCuentaCliente(New Cliente("Juan", "194480", "Calle X", "12444"), 600)

        banco.depositarDineroCuenta(1, 600)
        banco.depositarDineroCuenta(2, 300)

        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        banco.retirarDineroCuenta(1, 300)
        banco.retirarDineroCuenta(2, 60)

        Console.WriteLine("Despues del retiro")
        Console.WriteLine(banco.getSaldoCuenta(1))
        Console.WriteLine(banco.getSaldoCuenta(2))

        Dim ca As CuentaAhorros = banco.buscarCuentaCliente("1910873")

        Console.WriteLine("No Cuenta" & ca.getNumCuenta)
        Console.WriteLine("Nombre del Cliente" & ca.ClienteCuenta.nombrePersona)
    End Sub

End Module
