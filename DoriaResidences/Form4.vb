Imports System.DateTime

Public Class Form4
    Public Pio As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrezziDoria As New List(Of Tariffa)
        Dim Pio As String = ""

        '*************************************************************************
        '                         CREAZIONE PREZZIARIO 2016
        '*************************************************************************
        PrezziDoria.Add(New Tariffa(New Date(2016, 05, 14), New Date(2016, 05, 28), 245, 285, 0, 300))
        PrezziDoria.Add(New Tariffa(New Date(2016, 05, 28), New Date(2016, 06, 18), 300, 340, 0, 355))
        PrezziDoria.Add(New Tariffa(New Date(2016, 06, 18), New Date(2016, 07, 02), 380, 445, 0, 460))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 02), New Date(2016, 07, 16), 450, 530, 0, 545))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 16), New Date(2016, 07, 30), 500, 590, 0, 605))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 30), New Date(2016, 08, 20), 595, 700, 0, 715))
        PrezziDoria.Add(New Tariffa(New Date(2016, 08, 20), New Date(2016, 08, 27), 500, 590, 0, 605))
        PrezziDoria.Add(New Tariffa(New Date(2016, 08, 27), New Date(2016, 09, 03), 450, 530, 0, 545))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 03), New Date(2016, 09, 10), 300, 340, 0, 355))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 10), New Date(2016, 09, 24), 245, 285, 0, 300))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 24), New Date(2016, 10, 01), 225, 255, 0, 270))


        For i As Integer = 0 To PrezziDoria.Count - 1 Step 1

            Pio = Pio & PrezziDoria.Item(i).ToString & vbNewLine

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MonthCalendar1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MonthCalendar2.Show()
    End Sub


    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        TextBox2.Text = MonthCalendar2.SelectionRange.Start
        MonthCalendar2.Hide()
    End Sub



    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        TextBox1.Text = MonthCalendar1.SelectionRange.Start
        MonthCalendar1.Hide()
    End Sub
End Class