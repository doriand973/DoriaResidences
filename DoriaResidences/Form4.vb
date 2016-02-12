Imports System.DateTime

Public Class Form4
    Public lista As String = ""
    Dim dfin As Date 'Data di partenza
    Dim nDfin As Integer
    Dim nDin As Integer
    Dim prezzo As Integer
    Dim din As Date  'Data di arrivo
    Dim PrezziDoria As New List(Of Tariffa)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '*************************************************************************
        '                         CREAZIONE PREZZIARIO 2016
        '*************************************************************************
        PrezziDoria.Add(New Tariffa(New Date(2016, 05, 14), New Date(2016, 05, 28), 245, 285, 300, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 05, 28), New Date(2016, 06, 18), 300, 340, 355, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 06, 18), New Date(2016, 07, 02), 380, 445, 460, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 02), New Date(2016, 07, 16), 450, 530, 545, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 16), New Date(2016, 07, 30), 500, 590, 605, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 07, 30), New Date(2016, 08, 20), 595, 700, 715, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 08, 20), New Date(2016, 08, 27), 500, 590, 605, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 08, 27), New Date(2016, 09, 03), 450, 530, 545, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 03), New Date(2016, 09, 10), 300, 340, 355, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 10), New Date(2016, 09, 24), 245, 285, 300, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 24), New Date(2016, 10, 01), 225, 255, 270, 0))

        ' Lista prezziario 
        For i As Integer = 0 To PrezziDoria.Count - 1 Step 1
            lista = lista & PrezziDoria.Item(i).ToString & vbNewLine
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MonthCalendar1.Show()
        MonthCalendar1.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MonthCalendar2.Show()
        MonthCalendar2.BringToFront()
    End Sub


    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        'Sub di immissione data di partenza
        dfin = MonthCalendar2.SelectionRange.Start
        nDfin = DatePart(DateInterval.WeekOfYear, dfin) - 1
        TextBox2.Text = dfin.ToString("dd-MM-yyyy")
        'TextBox2.Text = MonthCalendar2.SelectionRange.Start
        MonthCalendar2.Hide()
    End Sub



    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        'Sub di immissione data di arrivo
        din = MonthCalendar1.SelectionRange.Start
        nDin = DatePart(DateInterval.WeekOfYear, din) - 1
        TextBox1.Text = din.ToString("dd-MM-yyyy")
        'TextBox1.Text = MonthCalendar1.SelectionRange.Start
        MonthCalendar1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Calcolo prezzo soggiorno
        Try
            Dim tipoApp As Integer = ComboBox1.SelectedIndex
            Dim index As Integer = 0
            Dim soggiorno As Integer = nDfin - nDin
            Dim sconto As Integer
            Dim scontistica As Double
            Dim spese As Integer
            Dim PULIZIA As Integer = 45
            Dim totale As Integer
            'Ricerca tariffa di inizio calcolo 
            For i As Integer = 0 To PrezziDoria.Count - 1
                If PrezziDoria.Item(i).FindArr(din) Then
                    'TextBox3.Text = TextBox3.Text & PrezziDoria.Item(i).ToString & " N° settimana: " & nDin & vbNewLine '& vbNewLine
                    index = i
                    Exit For
                End If
            Next
            'Calcolo prezzo netto senza sconto
            For j As Integer = nDin + 1 To nDfin
                If PrezziDoria.Item(index).CheckWeek(j) Then
                    prezzo += PrezziDoria.Item(index).getprezzo(tipoApp)
                Else
                    index += 1
                    prezzo += PrezziDoria.Item(index).getprezzo(tipoApp)
                End If
            Next
            'Calcolo scontistica per settimane
            Select Case soggiorno
                Case 2
                    scontistica = 7.5 / 100
                Case 3
                    scontistica = 10 / 100
                Case >= 4
                    scontistica = 15 / 100
                Case Else
                    scontistica = 0
            End Select
            sconto = Math.Round(prezzo * scontistica)

            'calcolo spese
            Select Case tipoApp
                Case 0
                    spese = 45
                Case Else
                    spese = 55
            End Select
            'Calcolo totale soggiorno
            totale = prezzo - sconto + spese + PULIZIA
            'TextBox3.Text = TextBox3.Text & PrezziDoria.Item(index).ToString & " N° settimana: " & nDfin & vbNewLine
            TextBox3.Text = TextBox3.Text & "N° settimane soggiorno : " & soggiorno & vbNewLine & "Tipo Appartemento : " & ComboBox1.SelectedItem.ToString & vbNewLine & "Prezzo: " & prezzo & " €" & " - " & "Sconto: " & sconto & " €" & " + " & "Spese: " & soggiorno * spese & " €" & " + " & "Pulizia: " & PULIZIA & " €" & vbNewLine & "TOTALE: " & totale & vbNewLine
            prezzo = 0
        Catch ex As Exception
            TextBox3.Text = ""
            MsgBox("Controlla di aver Selezionato tutti i campi")

        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = ""
    End Sub
End Class