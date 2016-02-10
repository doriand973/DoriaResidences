Public Class Prezziario

    Private tariffario As List(Of Tariffa)
    Private a = New Date
    Private b = New Date
    Private c As Integer
    Private d As Integer
    Private e As Integer
    Private f As Integer
    Private t = New Tariffa(a, b, c, d, e, f)
    ' Public Sub New()
    ' Me.tariffario
    ' End Sub

    Function getTariffario() As List(Of Tariffa)
        Return Me.tariffario
    End Function

    Sub Addtariffa(t)
        tariffario.Add(t)
    End Sub

End Class
