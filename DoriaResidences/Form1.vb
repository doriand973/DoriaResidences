Imports System.Net.Mail

Public Class Form1

    Dim Mail As New MailMessage
    Dim Smtp As New SmtpClient("smtp.gmail.com")
    Dim INDIRIZZO As String = "doria.residences@gmail.com"
    Dim INDIRIZZO2 As String = "info@doriares.it"
    Dim PASS As String = "011233564"
    Dim allegato As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creo nuovo messaggio mail

        Mail = New MailMessage
        'Indirizzo di invio mail
        Mail.From = New MailAddress(INDIRIZZO)
        'Controllo per Ccn su mail secondaria
        If CheckBox1.Checked Then
            'Indirizzo di copia conoscenza mail Ccn
            Mail.Bcc.Add(New MailAddress(INDIRIZZO2))
        End If

        Try
            Mail.To.Add(TextBox1.Text)
        Catch ex As Exception
            MsgBox("ATTENZIONE!" & vbNewLine & "Email destinatario non corretto!")
            Exit Sub
        End Try
        Mail.Subject = TextBox2.Text
        Mail.Body = TextBox3.Text
        'Creazioni path per i file da allegare alla mail
        If ListBox1.Items.Count <> 0 Then
            For i = 0 To ListBox1.Items.Count - 1
                allegato = ListBox1.Items.Item(i).ToString
                Mail.Attachments.Add(New Attachment(allegato))
            Next
        End If
        Smtp.EnableSsl = True
        Smtp.Port = 25
        Smtp.Credentials = New Net.NetworkCredential(INDIRIZZO, PASS)
        Smtp.Send(Mail)
        MsgBox("Messaggio Inviato con successo", MsgBoxStyle.Information, "Avviso")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    '********************************************************************
    'Allegato
    '********************************************************************

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ListBox1.Items.Add(OpenFileDialog1.FileName.ToString())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim c As Tariffa
        'Dim t1 As Date = New Date(2016, 1, 21)
        'Dim t2 As Date = New Date(2016, 3, 21)

        c = New Tariffa(New Date(2016, 1, 21), New Date(2016, 3, 21), 300, 340, 55, 355)
        Pio = PrezziDoria.Item(10).getWeek_start.ToString


        ' For i As Integer = 0 To PrezziDoria.Count - 1 Step 1

        'Pio = Pio & PrezziDoria.Item(i).ToString & vbNewLine

        ' Next
        TextBox3.Text = Pio

    End Sub
End Class
