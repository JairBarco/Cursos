Public Class Basquetbolista
    Inherits Deportista
    Implements IBasquetbolista

    Public Sub New(nom As String, pos As String, e As Integer, est As Double)
        MyBase.New(nom, pos, e, est)
    End Sub

    Public Function verificarEstatura() As Boolean Implements IBasquetbolista.verificarEstatura

        If EstaturaDeportista >= 190 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
