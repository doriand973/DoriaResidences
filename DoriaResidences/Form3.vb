
Public Class Form3
    Dim scritturaOk = New Boolean() {True, True, True, True}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
        If scritturaOk(0) And scritturaOk(1) And scritturaOk(2) And scritturaOk(3) Then
            MsgBox("Scrittura file Ini avvenuta correttamente")
            Close()
        Else
            MsgBox("Scrittura file Ini non avvenuta")

        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.IniRead(Form1.PATHINI, “MAIL”, “mailmitt”)
        TextBox2.Text = Form1.IniRead(Form1.PATHINI, “MAIL”, “psw”)
        TextBox3.Text = Form1.IniRead(Form1.PATHINI, “MAIL”, “mailccn”)
        TextBox4.Text = Form1.IniRead(Form1.PATHINI, “MAIL”, “smtp”)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        scritturaOk(0) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “mailmitt”, TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        scritturaOk(1) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “psw”, TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        scritturaOk(2) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “mailccn”, TextBox3.Text)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        scritturaOk(3) = Form1.IniWrite(Form1.PATHINI, “MAIL”, “smtp”, TextBox4.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class