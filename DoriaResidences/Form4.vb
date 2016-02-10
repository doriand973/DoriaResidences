Imports System.DateTime

Public Class Form4
    'Public Pio As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrezziDoria As New Prezziario

        '*************************************************************************
        '                         CREAZIONE PREZZIARIO 2016
        '*************************************************************************
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 05, 14), New Date(2016, 05, 28), 245, 285, 0, 300))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 05, 28), New Date(2016, 06, 18), 300, 340, 0, 355))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 06, 18), New Date(2016, 07, 02), 380, 445, 0, 460))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 07, 02), New Date(2016, 07, 16), 450, 530, 0, 545))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 07, 16), New Date(2016, 07, 30), 500, 590, 0, 605))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 07, 30), New Date(2016, 08, 20), 595, 700, 0, 715))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 08, 20), New Date(2016, 08, 27), 500, 590, 0, 605))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 08, 27), New Date(2016, 09, 03), 450, 530, 0, 545))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 09, 03), New Date(2016, 09, 10), 300, 340, 0, 355))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 09, 10), New Date(2016, 09, 24), 245, 285, 0, 300))
        PrezziDoria.Addtariffa(New Tariffa(New Date(2016, 09, 24), New Date(2016, 10, 01), 225, 255, 0, 270))

        ' Pio = PrezziDoria.ToString

    End Sub
End Class