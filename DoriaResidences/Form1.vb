Imports System.Net.Mail

Public Class Form1
    Public PATHINI As String = “G:\doriares.ini” ' path file INI
    Dim smtpString As String = IniRead(PATHINI, “MAIL”, “smtp”)
    Dim INDIRIZZO As String = IniRead(PATHINI, “MAIL”, “mailmitt”)
    Dim INDIRIZZO2 As String = IniRead(PATHINI, “MAIL”, “mailccn”)
    Dim PASS As String = IniRead(PATHINI, “MAIL”, “psw”)
    Dim allegato As String = ""
    Dim allegati As String = ""
    Dim pathLog As String = IniRead(PATHINI, “PathLog”, “pathlog”) ' path dove salvare i file log delle mail inviate
    Dim Mail As New MailMessage
    Dim Smtp As New SmtpClient(smtpString)
    'Dim Smtp As New SmtpClient("smtp.gmail.com")
    'Dim INDIRIZZO As String = "doria.residences@gmail.com"
    'Dim INDIRIZZO2 As String = "info@doriares.it"
    'Dim PASS As String = "011233564"
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

            If Not (System.IO.File.Exists(Filename)) Then

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

            If Not (System.IO.File.Exists(Filename)) Then

                ErrString = “Impossibile aprire il file INI” & Filename

            Else

                ErrString = “Accesso al file non consentito”

            End If

            Throw New Exception(ErrString)

        End If

        Return IIf(LenResult = 0, False, True)

        End

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '*************************************************************************
        'Creo nuovo messaggio mail e INVIO MAIL
        '*************************************************************************
        Mail = New MailMessage
        Mail.From = New MailAddress(INDIRIZZO) 'Indirizzo mittente mail

        '*************************************************************************
        'Controllo per Ccn su mail secondaria
        '*************************************************************************
        If CheckBox1.Checked Then
            Mail.Bcc.Add(New MailAddress(INDIRIZZO2)) 'Indirizzo di copia conoscenza mail Ccn
        End If
        '*************************************************************************
        'Destinatario mail
        '*************************************************************************
        Try
            Mail.To.Add(TextBox1.Text)
        Catch ex As Exception
            MsgBox("ATTENZIONE!" & vbNewLine & "Email destinatario non corretto!")
            Exit Sub
        End Try
        Mail.Subject = TextBox2.Text
        '*************************************************************************
        'CONFERMA LETTURA
        '*************************************************************************
        Mail.Headers.Add(“Disposition-Notification-To”, INDIRIZZO)
        '*************************************************************************
        'CONFERMA RECAPITO
        '*************************************************************************
        Mail.Headers.Add(“Return-Receipt-To”, INDIRIZZO)
        Mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure Or DeliveryNotificationOptions.OnSuccess

        Mail.Body = TextBox3.Text
        '*************************************************************************
        'Creazioni path per i file da allegare alla mail
        '*************************************************************************
        If ListBox1.Items.Count <> 0 Then
            For i = 0 To ListBox1.Items.Count - 1
                allegato = ListBox1.Items.Item(i).ToString
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
        ScriviLogData(TextBox1.Text & vbNewLine & TextBox3.Text & vbNewLine & allegati)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '********************************************************************
        'Apertura file manager per inserimento Allegato
        '********************************************************************
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '********************************************************************
        ' Tasto Annulla
        '********************************************************************
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '********************************************************************
        ' Elimina allegato selezionato
        '********************************************************************
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        '********************************************************************
        ' Aggiunge PATH del file selezionato da allegare
        '********************************************************************
        ListBox1.Items.Add(OpenFileDialog1.FileName.ToString())
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        'Controllo esistenza file Log .log
        If IO.File.Exists(pathLog & "\" & TextBox2.Text & " " & oggi & ".log") = False Then
            'Creo il file Log se non esiste
            Dim fs As IO.FileStream = IO.File.Create(pathLog & "\" & TextBox2.Text & " " & oggi & ".log")
            fs.Close() 'chiudo il file log
        End If
        'Apro il file per poi aggiungere i dati alla fine 
        Dim tw As IO.TextWriter = IO.File.AppendText(pathLog & "\" & TextBox2.Text & " " & oggi & ".log")
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


End Class
