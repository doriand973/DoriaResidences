Imports System.Net.Mail
Imports System.IO
Public Class FormMail
    Public PATHINI As String = “C:\Doriares\doriares.ini” ' path file INI
    Dim smtpString As String = IniRead(PATHINI, “MAIL”, “smtp”)
    Dim INDIRIZZO As String = IniRead(PATHINI, “MAIL”, “mailmitt”)
    Dim INDIRIZZO2 As String = IniRead(PATHINI, “MAIL”, “mailccn”)
    Dim PASS As String = IniRead(PATHINI, “MAIL”, “psw”)
    Public INTESTAZIONE_MAIL As String = "Doria Residences" & vbNewLine & "mail:" & IniRead(PATHINI, “INTESTA”, “mail”) & vbNewLine & "internet: " & IniRead(PATHINI, “INTESTA”, “internet”) & vbNewLine & "mobile: " & IniRead(PATHINI, “INTESTA”, “mobile”)
    Dim allegato1 As String
    Dim allegato2 As String
    Dim allegato As String = ""
    Dim allegati As String = ""

    Dim Mail As New MailMessage
    Dim Smtp As New SmtpClient(smtpString)
    'Dim pathLog As String = "G:\Documenti\000 Doria residences\02 Attività\01 Prenotazioni\2016\Mail" ' path dove salvare i file log delle mail inviate
    '*************************************************************************
    'Dichiarazione File INI
    '*************************************************************************
    Private Declare Auto Function GetPrivateProfileString Lib “kernel32.dll” (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib “kernel32.dll” (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Friend Function IniRead(ByVal Filename As String, ByVal Section As String, ByVal Key As String, Optional ByVal lpDefault As String = “”, Optional ByVal bRaiseError As Boolean = False) As String
        '*************************************************************************
        'Lettura File INI
        '*************************************************************************
        Dim RetVal As String = New String(” “, 255)

        Dim LenResult As Integer

        Dim ErrString As String

        LenResult = GetPrivateProfileString(Section, Key, lpDefault, RetVal, RetVal.Length, Filename)

        If LenResult = 0 AndAlso bRaiseError Then

            If Not (File.Exists(Filename)) Then

                ErrString = “Impossibile aprire il file INI” & Filename

            Else

                ErrString = “La sezione o la chiave sono errate oppure l’accesso al file non è consentito”

            End If

            Throw New Exception(ErrString)

        End If

        Return RetVal.Substring(0, LenResult)

    End Function

    Friend Function IniWrite(ByVal Filename As String, ByVal Section As String, ByVal Key As String, ByVal Value As String, Optional ByVal bRaiseError As Boolean = False) As Boolean
        '*************************************************************************
        'Scrittura File INI
        '*************************************************************************
        Dim LenResult As Integer

        Dim ErrString As String

        LenResult = WritePrivateProfileString(Section, Key, Value, Filename)

        If LenResult = 0 And bRaiseError Then

            If Not (File.Exists(Filename)) Then

                ErrString = “Impossibile aprire il file INI” & Filename

            Else

                ErrString = “Accesso al file non consentito”

            End If

            Throw New Exception(ErrString)

        End If

        Return IIf(LenResult = 0, False, True)

        End

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnInvia.Click
        '*************************************************************************
        'Creo nuovo messaggio mail e INVIO MAIL
        '*************************************************************************
        Mail = New MailMessage
        Mail.From = New MailAddress(INDIRIZZO) 'Indirizzo mittente mail

        '*************************************************************************
        'Controllo per Ccn su mail secondaria
        '*************************************************************************
        If CheckBoxCcn.Checked Then
            Mail.Bcc.Add(New MailAddress(INDIRIZZO2)) 'Indirizzo di copia conoscenza mail Ccn
        End If
        '*************************************************************************
        'Destinatario mail
        '*************************************************************************
        Try
            Mail.To.Add(TxtDestinatario.Text)
        Catch ex As Exception
            MsgBox("ATTENZIONE!" & vbNewLine & "Email destinatario non corretto!")
            Exit Sub
        End Try
        Mail.Subject = TxtOggetto.Text
        '*************************************************************************
        'CONFERMA LETTURA
        '*************************************************************************
        Mail.Headers.Add(“Disposition-Notification-To”, INDIRIZZO)
        '*************************************************************************
        'CONFERMA RECAPITO
        '*************************************************************************
        Mail.Headers.Add(“Return-Receipt-To”, INDIRIZZO)
        Mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure Or DeliveryNotificationOptions.OnSuccess

        Mail.Body = TxtTesto.Text
        '*************************************************************************
        'Creazioni path per i file da allegare alla mail
        '*************************************************************************
        If LstAllega.Items.Count <> 0 Then
            For i = 0 To LstAllega.Items.Count - 1
                allegato = LstAllega.Items.Item(i).ToString
                allegati += allegati & vbNewLine & allegato
                Mail.Attachments.Add(New Attachment(allegato))
            Next
        End If
        Smtp.EnableSsl = True
        Smtp.Port = 25
        Smtp.Credentials = New Net.NetworkCredential(INDIRIZZO, PASS)
        Smtp.Send(Mail)
        MsgBox("Messaggio Inviato con successo", MsgBoxStyle.Information, "Avviso")

        '********************************************************************
        'Scrittura File Log email inviata
        '********************************************************************
        Dim logCont As String = TxtDestinatario.Text & vbNewLine & TxtTesto.Text & vbNewLine & allegati
        Try
            ScriviLogData(logCont)
        Catch ex As Exception
            MsgBox("File log non scritto correttamente")
        End Try
        TxtDestinatario.Clear()
        TxtOggetto.Clear()
        TxtTesto.Clear()
        LstAllega.Items.Clear()
        CheckBoxAllega.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnAllegaFile.Click
        '********************************************************************
        'Apertura file manager per inserimento Allegato
        '********************************************************************
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAnnulla.Click
        '********************************************************************
        ' Tasto Annulla
        '********************************************************************
        TxtDestinatario.Clear()
        TxtOggetto.Clear()
        TxtTesto.Clear()
        LstAllega.Items.Clear()
        CheckBoxAllega.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnRimuoviSel.Click
        '********************************************************************
        ' Elimina allegato selezionato
        '********************************************************************
        LstAllega.Items.Remove(LstAllega.SelectedItem)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        '********************************************************************
        ' Aggiunge PATH del file selezionato da allegare
        '********************************************************************
        LstAllega.Items.Add(OpenFileDialog1.FileName.ToString())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        '********************************************************************
        ' Apre scheda PREVENTIVO
        '********************************************************************
        Form4.Show()
    End Sub

    Private Sub PreventivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreventivoToolStripMenuItem.Click
        '********************************************************************
        ' Apre scheda PREVENTIVO
        '********************************************************************
        Form4.Show()
    End Sub

    Private Sub DettagliMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DettagliMailToolStripMenuItem.Click
        '********************************************************************
        ' Apre scheda TIPO MAIL
        '********************************************************************
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        '********************************************************************
        ' Apre scheda TIPO MAIL
        '********************************************************************
        Form2.Show()
    End Sub

    Private Sub ItalianoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalianoToolStripMenuItem.Click
        '*************************************************************************
        'Scelta Lingua Italiano
        '*************************************************************************
        ItalianoToolStripMenuItem.Checked = 1
        IngleseToolStripMenuItem.Checked = 0

    End Sub

    Private Sub IngleseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngleseToolStripMenuItem.Click
        '*************************************************************************
        'Scelta Lingua Inglese
        '*************************************************************************
        IngleseToolStripMenuItem.Checked = 1
        ItalianoToolStripMenuItem.Checked = 0

    End Sub
    Private Sub ScriviLogData(ByVal Namelog As String)
        '*************************************************************************
        'Sub per creazione di file Log 
        '*************************************************************************
        Dim data As Date = Date.Now()
        Dim oggi As String = data.ToString("dd-MM-yyyy H-mm-ss")
        Dim pathLog As String = IniRead(PATHINI, “PATHLOG”, “path”) ' path dove salvare i file log delle mail inviate
        Dim nomeFile As String = pathLog & "\" & TxtOggetto.Text & "-" & oggi & ".log"
        'Controllo esistenza file Log .log
        If File.Exists(nomeFile) = False Then
            'Creo il file Log se non esiste
            Dim fs As FileStream = File.Create(nomeFile)
            fs.Close() 'chiudo il file log
        End If
        'Apro il file per poi aggiungere i dati alla fine 
        Dim tw As TextWriter = File.AppendText(nomeFile)
        'Scrivi la stringa di Log
        tw.WriteLine(Namelog)
        tw.Close()
    End Sub

    Private Sub PathFileLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PathFileLogToolStripMenuItem.Click
        '********************************************************************
        ' Scrittura file INI per il campo PATHLOG
        '********************************************************************
        Dim scritturaOk As Boolean
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            scritturaOk = IniWrite(PATHINI, “PATHLOG”, “path”, FolderBrowserDialog1.SelectedPath.ToString)
            If scritturaOk Then
                MsgBox("Scrittura file Ini avvenuta correttamente")
            Else
                MsgBox("Scrittura file Ini non avvenuta")

            End If
        End If

        'TextBox4.Text = IniRead(“G:\doriares.ini”, “PATHLOG”, “path”)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox3.Text = pathLog & vbNewLine & smtpString & vbNewLine & INDIRIZZO & vbNewLine & INDIRIZZO2 & vbNewLine & PASS
        'TextBox3.Text = PATHINI.Remove(PATHINI.LastIndexOf("\") + 1, PATHINI.Length - PATHINI.LastIndexOf("\"))
        'TextBox3.Text = PATHINI.Remove(PATHINI.LastIndexOf("\") + 1, PATHINI.Length - PATHINI.LastIndexOf("\") - 1)
    End Sub

    Private Sub DatiMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatiMailToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAllega.CheckedChanged
        If CheckBoxAllega.Checked Then
            If ItalianoToolStripMenuItem.Checked Then
                allegato1 = IniRead(PATHINI, “ALLEGATI”, “allega1”)
                allegato2 = IniRead(PATHINI, “ALLEGATI”, “allega2”)

            Else
                allegato1 = IniRead(PATHINI, “ALLEGATI”, “allega3”)
                allegato2 = IniRead(PATHINI, “ALLEGATI”, “allega4”)

            End If
            LstAllega.Items.Add(allegato1)
            LstAllega.Items.Add(allegato2)
        End If
    End Sub

    Private Sub BookingcomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingcomToolStripMenuItem.Click
        Form5.Show()
    End Sub


    Private Sub ListBox1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles LstAllega.DragEnter
        'Abilitazione al Drag Drop sulla Listbox per allegare file alla mail
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles LstAllega.DragDrop
        'Creazione della string da aggiungere alla listbox degli allegati
        Dim s() As String = e.Data.GetData("FileDrop", False)
        Dim i As Integer
        For i = 0 To s.Length - 1
            LstAllega.Items.Add(s(i))
        Next i
    End Sub

    Private Sub DatiPrezziario_Click(sender As Object, e As EventArgs) Handles DatiPrezziario.Click
        Preziario.Show()
    End Sub

    Private Sub DatiSpeseAccessorieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatiSpeseAccessorieToolStripMenuItem.Click
        FormSpese.Show()
    End Sub

    Private Sub AllegatiStandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllegatiStandardToolStripMenuItem.Click
        FormAllegati.Show()
    End Sub
End Class
