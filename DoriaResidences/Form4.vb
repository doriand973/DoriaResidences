Imports System.DateTime

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrezziDoria As New Prezziario
        'Dim prima As Tariffa
        'prima.tariffa()
        PrezziDoria.Addtariffa((2016)) ', 05, 14),(2016, 05, 28), 245, 285, 0, 300)

        PrezziDoria.Addtariffa("05/28/2016", "06/18/2016", 300, 340, 0, 355)
        PrezziDoria.Addtariffa("06/18/2016", "07/02/2016", 380, 445, 0, 460)
        PrezziDoria.Addtariffa("07/02/2016", "07/16/2016", 450, 530, 0, 545)
        PrezziDoria.Addtariffa("07/16/2016", "07/30/2016", 500, 590, 0, 605)
        PrezziDoria.Addtariffa("07/30/2016", "08/20/2016", 595, 700, 0, 715)
        PrezziDoria.Addtariffa("08/20/2016", "08/27/2016", 500, 590, 0, 605)
        PrezziDoria.Addtariffa("08/27/2016", "09/03/2016", 450, 530, 0, 545)
        PrezziDoria.Addtariffa("09/03/2016", "09/10/2016", 380, 445, 0, 460)
        PrezziDoria.Addtariffa("09/10/2016", "09/24/2016", 300, 340, 0, 355)
        PrezziDoria.Addtariffa("09/24/2016", "10/01/2016", 225, 255, 0, 270)
    End Sub
End Class