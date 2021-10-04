Public Class CuentaAhorros

    Private numCuentaAhorros As Integer
    Private saldo As Double
    Private cte As Cliente

    Private Shared estableceNumCuenta As Integer = 1

    Public Sub New()

        numCuentaAhorros = estableceNumCuenta
        saldo = 0
        cte = Nothing

        estableceNumCuenta += 1
    End Sub
    Public Sub New(sa As Double, cl As Cliente)

        numCuentaAhorros = estableceNumCuenta
        saldo = sa
        cte = cl

        estableceNumCuenta += 1
    End Sub

    Public Function getCuentaAhorros() As Integer
        Return numCuentaAhorros
    End Function

    Public Function getSaldo() As Double
        Return saldo
    End Function

    Public Property clienteCuenta() As Cliente
        Get
            Return cte
        End Get
        Set(value As Cliente)
            If cte Is Nothing Then

                cte = value
            Else
                Console.WriteLine("El cliente ya está asignado a una cuenta")
            End If
        End Set
    End Property

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
