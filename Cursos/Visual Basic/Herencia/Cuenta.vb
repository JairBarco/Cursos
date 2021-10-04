Public Class Cuenta

    Protected numCuenta As Integer
    Protected saldo As Double
    Protected cliente As Cliente
    Protected Shared Id As Integer = 1

    Public Sub New()

        numCuenta = Id
        cliente = Nothing
        saldo = 0

        Id += 1

    End Sub

    Public Sub New(cl As Cliente, sa As Double)
        numCuenta = Id
    End Sub

    Public Function getNumCuenta() As Integer
        Return numCuenta
    End Function

    Public Property ClienteCuenta() As Cliente
        Get
            Return cliente
        End Get
        Set(value As Cliente)
            If cliente Is Nothing Then

                cliente = value
            Else
                Console.WriteLine("El cliente ya está asignado a una cuenta")
            End If
        End Set
    End Property

    Public Function getSaldo() As Double
        Return saldo
    End Function

    Public Sub depositarDinero(valor As Double)

        saldo = saldo + valor

    End Sub

    Public Sub retirarDinero(valor As Double)

        If saldo >= valor Then
            saldo = saldo - valor
        Else
            Console.WriteLine("Fondos Insuficientes")
        End If


    End Sub

End Class
