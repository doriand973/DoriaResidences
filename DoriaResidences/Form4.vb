Imports System.DateTime

Public Class Form4
    Public lista As String = ""
    Dim din As Date  'Data di arrivo
    Dim dfin As Date 'Data di partenza
    Dim nDfin As Integer 'n° settimana del giorno di partenza
    Dim nDin As Integer  'n° settimana del giorno di arrivo
    Dim tipoApp As Integer
    Dim prezzo As Integer
    Dim sconto As Integer
    Dim scontistica As Double
    Dim spese As Integer
    Dim PULIZIA As Integer = 45
    Dim totale As Integer
    Dim PrezziDoria As New List(Of Tariffa)
    Public preventivo As String
    Dim finale As String
    Dim speciale As String = ""

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
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 03), New Date(2016, 09, 10), 380, 445, 460, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 10), New Date(2016, 09, 24), 300, 340, 355, 0))
        PrezziDoria.Add(New Tariffa(New Date(2016, 09, 24), New Date(2016, 10, 01), 225, 255, 270, 0))
        '*************************************************************************
        ' Lista prezziario 
        '*************************************************************************
        For i As Integer = 0 To PrezziDoria.Count - 1 Step 1
            lista = lista & PrezziDoria.Item(i).ToString & vbNewLine
        Next
    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateSelected
        '*************************************************************************
        'Sub di immissione data di partenza
        '*************************************************************************
        dfin = MonthCalendar2.SelectionRange.Start
        nDfin = DatePart(DateInterval.WeekOfYear, dfin) - 1
        TextBox2.Text = dfin.ToString("dd-MM-yyyy")
        MonthCalendar2.Hide()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        '*************************************************************************
        'Sub di immissione data di arrivo
        '*************************************************************************
        din = MonthCalendar1.SelectionRange.Start
        nDin = DatePart(DateInterval.WeekOfYear, din) - 1
        TextBox1.Text = din.ToString("dd-MM-yyyy")
        MonthCalendar1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '*************************************************************************
        'Funzioni tasto Calcola : Calcolo prezzo soggiorno
        '*************************************************************************
        Dim index As Integer = 0
        Dim soggiorno As Integer = nDfin - nDin
        Dim settimane As String = ""
        Dim sPrezzo As String = ""
        Dim sSconto As String = ""
        Dim sSpese As String = ""
        Dim sPul As String = ""
        Dim sTipo As String = ""
        Dim total As String = ""
        Dim sPeriod As String = ""
        tipoApp = ComboBox1.SelectedIndex
        Try
            '*************************************************************************
            'Ricerca tariffa di inizio calcolo
            '*************************************************************************            
            For i As Integer = 0 To PrezziDoria.Count - 1
                If PrezziDoria.Item(i).FindArr(din) Then
                    Index = i
                    Exit For
                End If
            Next
            '*************************************************************************
            'Calcolo prezzo netto senza sconto
            '*************************************************************************
            For j As Integer = nDin + 1 To nDfin
                If PrezziDoria.Item(Index).CheckWeek(j) Then
                    prezzo += PrezziDoria.Item(Index).getprezzo(tipoApp)
                Else
                    Index += 1
                    prezzo += PrezziDoria.Item(Index).getprezzo(tipoApp)
                End If
            Next
            '*************************************************************************
            'Calcolo scontistica per settimane
            '*************************************************************************
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
            '*************************************************************************
            'calcolo spese
            '*************************************************************************
            Select Case tipoApp
                Case 0
                    spese = 45
                Case 1
                Case 2
                    spese = 55
                Case Else
                    Throw New System.Exception("Controlla di aver Selezionato tutti i campi")
            End Select
            '*************************************************************************
            'Calcolo totale soggiorno
            '*************************************************************************
            totale = prezzo - sconto + soggiorno * spese + PULIZIA
            '*************************************************************************
            'Selezione Lingua
            '*************************************************************************
            If Form1.ItalianoToolStripMenuItem.Checked Then
                sPeriod = "Periodo Soggiorno: "
                settimane = "N° settimane: "
                sPrezzo = "Prezzo: "
                sSconto = "Sconto: "
                sSpese = "Spese: "
                sPul = "Pulizia Finale: "
                sTipo = "Tipo Appartemento : "
                total = "PREZZO TOTALE: "
                speciale = "Sconto speciale per Lei, PREZZO FINALE: "
            ElseIf Form1.IngleseToolStripMenuItem.Checked
                sPeriod = "Termin: "
                settimane = "N° of Weeks stay: "
                sPrezzo = "Price: "
                sSconto = "Discount: "
                sSpese = "Expenses: "
                sPul = "Final Cleaning: "
                sTipo = "Typ.:"
                total = "TOTAL PRICE: "
                speciale = "Special discount for you, FINAL PRICE: "
            End If
            '*************************************************************************
            'Creazione Stringa Preventivo
            '*************************************************************************
            preventivo = TextBox3.Text & vbNewLine & sPeriod & din.ToString("dd-MM") & " - " & dfin.ToString("dd-MM") & vbNewLine & settimane & soggiorno & vbNewLine & sTipo & ComboBox1.SelectedItem.ToString & vbNewLine & sPrezzo & prezzo & " €" & " - " & sSconto & sconto & " €" & " + " & sSpese & soggiorno * spese & " €" & " + " & sPul & PULIZIA & " €" & vbNewLine & total & totale & " €" & vbNewLine
            TextBox3.Text = preventivo
            prezzo = 0
        Catch ex As Exception
            TextBox3.Text = ""
            MsgBox("Controlla di aver Selezionato tutti i campi")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '*************************************************************************
        'funzioni tasto Annulla
        '*************************************************************************
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        preventivo = ""
        din = New Date(0)
        dfin = New Date(0)
        ComboBox1.SelectedIndex = -1
        nDfin = 0
        nDin = 0
        prezzo = 0
        totale = 0

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '*************************************************************************
        'funzioni tasto Ok
        '*************************************************************************
        Form2.preventivo = preventivo
        Close()
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        MonthCalendar1.Show()
        MonthCalendar1.BringToFront()
        MonthCalendar2.Hide()
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        MonthCalendar2.Show()
        MonthCalendar2.BringToFront()
        MonthCalendar1.Hide()
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        '*************************************************************************
        'Tasto ESC per chiudere le finestre calendario e tasto ENTER per immissione prezzo finale preventivo
        '*************************************************************************
        Select Case keyData
            Case Keys.Escape
                MonthCalendar1.Hide()
                MonthCalendar2.Hide()
            Case Keys.Enter
                If TextBox4.Text <> "" Then
                    finale = TextBox4.Text
                    preventivo = preventivo & vbNewLine & speciale & finale & " €" & vbNewLine
                    TextBox3.Text = preventivo
                End If
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

End Class