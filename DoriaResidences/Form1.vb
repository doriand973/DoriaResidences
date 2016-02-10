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

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '   TextBox3.Text = Form4.Pio
    'End Sub
End Class
