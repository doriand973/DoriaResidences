
Public Class Form3
    Dim scritturaOk = New Boolean() {True, True, True, True}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOkDati.Click

        'Dim PATH As String = “G:\doriares.ini”
        'For i As Integer = 0 To 3
        'Select Case i
        'Case 0
        'If TextBox1.TextLength > 0 Then
        'scritturaOk(i) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “mailmitt”, TextBox1.Text)
        'End If
        'Case 1
        'If TextBox2.TextLength > 0 Then
        'scritturaOk(i) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “psw”, TextBox2.Text)
        'End If
        'Case 2
        'If TextBox3.TextLength > 0 Then
        'scritturaOk(i) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “mailccn”, TextBox3.Text)
        'End If
        'Case 3
        'If TextBox4.TextLength > 0 Then
        'scritturaOk(i) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “smtp”, TextBox4.Text)
        'End If
        'End Select
        '
        'Next
        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “mailmitt”, TxtIdAccount.Text)
        scritturaOk(1) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “psw”, TxtPassword.Text)
        scritturaOk(2) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “mailccn”, TxtSmtp.Text)
        scritturaOk(3) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “smtp”, TxtCcnMail.Text)

        If scritturaOk(0) And scritturaOk(1) And scritturaOk(2) And scritturaOk(3) Then
            MsgBox("Scrittura file Ini avvenuta correttamente")
            Close()
        Else
            MsgBox("Scrittura file Ini non avvenuta")

        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtIdAccount.Text = FormMail.IniRead(FormMail.PATHINI, “MAIL”, “mailmitt”)
        TxtPassword.Text = FormMail.IniRead(FormMail.PATHINI, “MAIL”, “psw”)
        TxtSmtp.Text = FormMail.IniRead(FormMail.PATHINI, “MAIL”, “mailccn”)
        TxtCcnMail.Text = FormMail.IniRead(FormMail.PATHINI, “MAIL”, “smtp”)
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAccount.TextChanged
    '    scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “mailmitt”, TxtIdAccount.Text)
    'End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
    '    scritturaOk(1) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “psw”, TxtPassword.Text)
    'End Sub

    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtSmtp.TextChanged
    '    scritturaOk(2) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “mailccn”, TxtSmtp.Text)
    'End Sub

    'Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtCcnMail.TextChanged
    '   scritturaOk(3) = FormMail.IniWrite(FormMail.PATHINI, “MAIL”, “smtp”, TxtCcnMail.Text)
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAnnulDati.Click
        Close()
    End Sub
End Class