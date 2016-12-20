Imports System.DateTime
Imports System.IO

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
    Dim speseAnimale As Integer
    Dim speseExtra As Integer
    Dim EXTRA As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “extra”)
    Dim PULIZIA As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “pulizia”)
    Dim ANIMALI As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “animali”)
    Dim SPESEB As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese1”)
    Dim SPESET1 As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese2”)
    Dim SPESET2 As Integer = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese3”)
    Dim totale As Integer
    Dim PrezziDoria As New List(Of Tariffa)
    Public preventivo As String
    Dim finale As String
    Dim speciale As String = ""

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '*************************************************************************
        '  NUOVO SISTEMA DI LETTURA DATI PREZZIARIO DA FILE
        '*************************************************************************
        Dim riga As String
        Dim componenti() As String
        Dim i As Integer
        Dim data1() As String ' componente stringa della data di arrivo letta da file
        Dim data2() As String ' componente stringa della data di partenza letta da file
        Dim dataarr As Integer() = New Integer() {0, 0, 0} 'data di arrivo
        Dim datapart As Integer() = New Integer() {0, 0, 0} 'data di partenza
        Dim bilo As Integer 'prezzo del bilo per ogni componente del tariffario
        Dim trilo As Integer 'prezzo del trilo per ogni componente del tariffario
        Dim trilo2 As Integer 'prezzo del trilo2 per ogni componente del tariffario

        Try
            ' Lettura prezziario da file
            Dim leggi As New StreamReader("C:\Doriares\prezzi.csv")

            If leggi.Peek = -1 Then
                MsgBox("Non Esiste Preziario!", MsgBoxStyle.OkOnly)
            Else
                While leggi.Peek <> -1
                    riga = leggi.ReadLine
                    componenti = Split(riga, ";")
                    data1 = Split(componenti(0), ",")
                    data2 = Split(componenti(1), ",")
                    For i = 0 To 2
                        dataarr(i) = CInt(data1(i))
                    Next
                    For i = 0 To 2
                        datapart(i) = CInt(data2(i))
                    Next
                    bilo = CInt(componenti(2))
                    trilo = CInt(componenti(3))
                    trilo2 = CInt(componenti(4))
                    'Creazione di ogni singola tariffa nei Prezzi Doria
                    PrezziDoria.Add(New Tariffa(New Date(dataarr(0), dataarr(1), dataarr(2)), New Date(datapart(0), datapart(1), datapart(2)), bilo, trilo, trilo2, 0))
                End While
            End If
            leggi.Close()
        Catch ex As System.IO.FileNotFoundException
            MsgBox("Creare il Preziario prima!", MsgBoxStyle.OkOnly)
        End Try


        '***********************************************************************************************
        '            OLD!!!!             CREAZIONE PREZZIARIO 2016
        '***********************************************************************************************
        'PrezziDoria.Add(New Tariffa(New Date(2016, 05, 14), New Date(2016, 05, 28), 245, 285, 300, 0))
        ' PrezziDoria.Add(New Tariffa(New Date(2016, 05, 28), New Date(2016, 06, 18), 300, 340, 355, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 06, 18), New Date(2016, 07, 02), 380, 445, 460, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 07, 02), New Date(2016, 07, 16), 450, 530, 545, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 07, 16), New Date(2016, 07, 30), 500, 590, 605, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 07, 30), New Date(2016, 08, 20), 595, 700, 715, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 08, 20), New Date(2016, 08, 27), 500, 590, 605, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 08, 27), New Date(2016, 09, 03), 450, 530, 545, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 09, 03), New Date(2016, 09, 10), 380, 445, 460, 0))
        'PrezziDoria.Add(New Tariffa(New Date(2016, 09, 10), New Date(2016, 09, 24), 300, 340, 355, 0))
        ' PrezziDoria.Add(New Tariffa(New Date(2016, 09, 24), New Date(2016, 10, 01), 225, 255, 270, 0))
        '************************************************************************************************

        '*************************************************************************
        ' Lista prezziario  
        '*************************************************************************
        For i = 0 To PrezziDoria.Count - 1 Step 1
            lista = lista & PrezziDoria.Item(i).ToString & vbNewLine
        Next
        'TextBox3.Text = lista ' Prova per vedere se la lista è corretta
    End Sub

    Private Sub MonthCalendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalPartenza.DateSelected
        '*************************************************************************
        'Sub di immissione data di partenza
        '*************************************************************************
        dfin = MonthCalPartenza.SelectionRange.Start
        nDfin = DatePart(DateInterval.WeekOfYear, dfin) - 1
        TxtDataPartenza.Text = dfin.ToString("dd-MM-yyyy")
        MonthCalPartenza.Hide()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalArrivo.DateSelected
        '*************************************************************************
        'Sub di immissione data di arrivo
        '*************************************************************************
        din = MonthCalArrivo.SelectionRange.Start
        nDin = DatePart(DateInterval.WeekOfYear, din) - 1
        TxtDataArrivo.Text = din.ToString("dd-MM-yyyy")
        MonthCalArrivo.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCalcola.Click
        '*************************************************************************
        'Funzioni tasto Calcola : Calcolo prezzo soggiorno
        '*************************************************************************
        Dim index As Integer = 0
        Dim soggiorno As Integer = nDfin - nDin
        Dim datacalcolo As Date
        Dim settimane As String = ""
        Dim sPrezzo As String = ""
        Dim sSconto As String = ""
        Dim sSpese As String = ""
        Dim sPul As String = ""
        Dim sAnimal As String = ""
        Dim sExtra As String = ""
        Dim textAnimal As String = ""
        Dim textExtra As String = ""
        Dim textSconto As String = ""
        Dim sTipo As String = ""
        Dim total As String = ""
        Dim sPeriod As String = ""
        tipoApp = ComboBoxAppartamento.SelectedIndex
        Try
            '*************************************************************************
            '             - CALCOLO PREZZO CON PREZZIARIO GIORNALIERO  -
            '*************************************************************************
            datacalcolo = din.Date

            While datacalcolo < dfin

                For i As Integer = 0 To PrezziDoria.Count - 1
                    If PrezziDoria.Item(i).FindArr(datacalcolo) Then
                        index = i
                        Exit For
                    End If
                Next
                prezzo += PrezziDoria.Item(index).getprezzo(tipoApp)
                datacalcolo = datacalcolo.AddDays(1)

            End While

            spese = 0 'le spese sono già calocla te nei prezzi

            '*************************************************************************
            '             -   OLD METODO CON PREZZIARIO SETTIMANALE    -             *
            'Ricerca tariffa di inizio calcolo                                       *              
            '*************************************************************************            
            ' For i As Integer = 0 To PrezziDoria.Count - 1
            'If PrezziDoria.Item(i).FindArr(din) Then
            'index = i
            'Exit For
            'End If
            ' Next
            '*************************************************************************
            'Calcolo prezzo netto senza sconto
            '*************************************************************************
            'For j As Integer = nDin + 1 To nDfin
            'If PrezziDoria.Item(Index).CheckWeek(j) Then
            ' prezzo += PrezziDoria.Item(Index).getprezzo(tipoApp)
            '    Else
            'index += 1
            'prezzo += PrezziDoria.Item(Index).getprezzo(tipoApp)
            'End If
            'Next
            '*************************************************************************
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
            '             -   OLD METODO CON PREZZIARIO SETTIMANALE    -             *
            'calcolo spese                                                           *
            '*************************************************************************
            'Select Case tipoApp
            'Case 0
            'spese = SPESEB
            'Case 1
            'spese = SPESET1
            'Case 2
            'spese = SPESET2
            'Case Else
            'Throw New System.Exception("Controlla di aver Selezionato tutti i campi")
            'End Select
            '*************************************************************************
            'Calcolo spese Animale per soggiorno
            '*************************************************************************
            If CheckBoxAnimali.Checked Then
                speseAnimale = soggiorno * ANIMALI
            Else
                speseAnimale = 0
            End If
            '*************************************************************************
            'Calcolo spese Extra per soggiorno
            '*************************************************************************
            If CheckBoxExtra.Checked Then
                speseExtra = soggiorno * EXTRA
            Else
                speseExtra = 0
            End If
            '*************************************************************************
            'Calcolo totale soggiorno
            '*************************************************************************
            totale = prezzo - sconto + soggiorno * spese + speseAnimale + speseExtra + PULIZIA
            '*************************************************************************
            'Selezione Lingua
            '*************************************************************************
            If FormMail.ItalianoToolStripMenuItem.Checked Then
                sPeriod = "Periodo Soggiorno: "
                settimane = "N° settimane: "
                sPrezzo = "Prezzo: "
                sSconto = "Sconto: "
                sSpese = "Spese: "
                sAnimal = "Spese per animale domestico:"
                sExtra = "Extra: "
                sPul = "Pulizia Finale: "
                sTipo = "Tipo Appartemento : "
                total = "PREZZO TOTALE: "
                speciale = "Sconto speciale per Lei, PREZZO FINALE: "
            ElseIf FormMail.IngleseToolStripMenuItem.Checked Then
                sPeriod = "Termin: "
                settimane = "N° of Weeks stay: "
                sPrezzo = "Price: "
                sSconto = "Discount: "
                sSpese = "Expenses: "
                sAnimal = "Expenses for pet:"
                sExtra = "Extra: "
                sPul = "Final Cleaning: "
                sTipo = "Typ.:"
                total = "TOTAL PRICE: "
                speciale = "Special discount for you, FINAL PRICE: "
            End If
            '*************************************************************************
            'Creazione Stringa Animali
            '*************************************************************************
            If CheckBoxAnimali.Checked Then
                textAnimal = " + " & sAnimal & soggiorno * ANIMALI & " €"

            Else
                textAnimal = ""
            End If
            '*************************************************************************
            'Creazione Stringa Extra
            '*************************************************************************
            If CheckBoxExtra.Checked Then
                textExtra = " + " & sExtra & soggiorno * EXTRA & " €"

            Else
                textExtra = ""
            End If
            '*************************************************************************
            'Creazione Stringa Sconto
            '*************************************************************************
            If sconto = 0 Then
                textSconto = ""

            Else
                textSconto = " - " & sSconto & sconto & " €"
            End If
            '*************************************************************************
            'Creazione Stringa Preventivo
            '*************************************************************************
            'preventivo = TextBox3.Text & vbNewLine & sPeriod & din.ToString("dd-MM") & " - " & dfin.ToString("dd-MM") & vbNewLine & settimane & soggiorno & vbNewLine & sTipo & ComboBoxAppartamento.SelectedItem.ToString & vbNewLine & sPrezzo & prezzo & " €" & textSconto & " + " & sSpese & soggiorno * spese & " €" & textAnimal & textExtra & " + " & sPul & PULIZIA & " €" & vbNewLine & total & totale & " €" & vbNewLine
            preventivo = TextBox3.Text & vbNewLine & sPeriod & din.ToString("dd-MM") & " - " & dfin.ToString("dd-MM") & vbNewLine & sTipo & ComboBoxAppartamento.SelectedItem.ToString & vbNewLine & sPrezzo & prezzo & " €" & textSconto & textAnimal & textExtra & " + " & sPul & PULIZIA & " €" & vbNewLine & total & totale & " €" & vbNewLine
            TextBox3.Text = preventivo
            prezzo = 0
        Catch ex As Exception
            TextBox3.Text = ""
            MsgBox("Controlla di aver Selezionato tutti i campi")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAnnulCalc.Click
        '*************************************************************************
        'funzioni tasto Annulla
        '*************************************************************************
        TxtDataArrivo.Text = ""
        TxtDataPartenza.Text = ""
        TextBox3.Text = ""
        TxtPrezzoFinale.Text = ""
        ComboBoxAppartamento.Text = ""
        CheckBoxAnimali.Checked = False
        CheckBoxExtra.Checked = False
        preventivo = ""
        din = New Date(0)
        dfin = New Date(0)
        ComboBoxAppartamento.SelectedIndex = -1
        nDfin = 0
        nDin = 0
        prezzo = 0
        totale = 0
        speseAnimale = 0
        speseExtra = 0

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnOkPreventivo.Click
        '*************************************************************************
        'funzioni tasto Ok
        '*************************************************************************
        Form2.preventivo = preventivo
        Close()
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtDataArrivo.MouseClick
        MonthCalArrivo.Show()
        MonthCalArrivo.BringToFront()
        MonthCalPartenza.Hide()
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtDataPartenza.MouseClick
        MonthCalPartenza.Show()
        MonthCalPartenza.BringToFront()
        MonthCalArrivo.Hide()
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        '*************************************************************************
        'Tasto ESC per chiudere le finestre calendario e tasto ENTER per immissione prezzo finale preventivo
        '*************************************************************************
        Select Case keyData
            Case Keys.Escape
                MonthCalArrivo.Hide()
                MonthCalPartenza.Hide()
            Case Keys.Enter
                If TxtPrezzoFinale.Text <> "" Then
                    finale = TxtPrezzoFinale.Text
                    preventivo = preventivo & vbNewLine & speciale & finale & " €" & vbNewLine
                    TextBox3.Text = preventivo
                End If
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function


End Class