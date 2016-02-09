Public Class Prezziario

    Private tariffario As ArrayList

    Public Sub New(ByVal t As ArrayList)
        t = Me.tariffario
    End Sub

    Function getTariffario() As ArrayList
        Return Me.tariffario
    End Function

    Function Addtariffa(ByVal t As Tariffa())
        Return tariffario.Add(t)
    End Function

End Class
