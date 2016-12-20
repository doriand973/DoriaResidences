Public Class FormAllegati
    Dim scritturaOk = New Boolean() {True, True, True, True}
    Dim allegato As Integer = 0
    Private Sub FormAllegati_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAllega1.Text = FormMail.IniRead(FormMail.PATHINI, “ALLEGATI”, “allega1”)
        TxtAllega2.Text = FormMail.IniRead(FormMail.PATHINI, “ALLEGATI”, “allega2”)
        TxtAllega3.Text = FormMail.IniRead(FormMail.PATHINI, “ALLEGATI”, “allega3”)
        TxtAllega4.Text = FormMail.IniRead(FormMail.PATHINI, “ALLEGATI”, “allega4”)
    End Sub

    Private Sub BtnAnnulDati_Click(sender As Object, e As EventArgs) Handles BtnAnnulDati.Click
        Close()
    End Sub

    Private Sub TxtAllega1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAllega1.MouseDoubleClick
        allegato = 1
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub TxtAllega2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAllega2.MouseDoubleClick
        allegato = 2
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub TxtAllega3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAllega3.MouseDoubleClick
        allegato = 3
        OpenFileDialog1.ShowDialog()
    End Sub


    Private Sub TxtAllega4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TxtAllega4.MouseDoubleClick
        allegato = 4
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Select Case allegato
            Case 1
                TxtAllega1.Text = OpenFileDialog1.FileName.ToString()
            Case 2
                TxtAllega2.Text = OpenFileDialog1.FileName.ToString()
            Case 3
                TxtAllega3.Text = OpenFileDialog1.FileName.ToString()
            Case 4
                TxtAllega4.Text = OpenFileDialog1.FileName.ToString()
            Case Else
                MsgBox("Nessun Allegato Modificato")

        End Select

    End Sub

    Private Sub BtnOkDati_Click(sender As Object, e As EventArgs) Handles BtnOkDati.Click
        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “ALLEGATI”, “allega1”, TxtAllega1.Text)
        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “ALLEGATI”, “allega2”, TxtAllega2.Text)
        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “ALLEGATI”, “allega3”, TxtAllega3.Text)
        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “ALLEGATI”, “allega4”, TxtAllega4.Text)
        If scritturaOk(0) And scritturaOk(1) And scritturaOk(2) And scritturaOk(3) Then
            MsgBox("Scrittura file Ini avvenuta correttamente")
            Close()
        Else
            MsgBox("Scrittura file Ini non avvenuta")

        End If
    End Sub
End Class