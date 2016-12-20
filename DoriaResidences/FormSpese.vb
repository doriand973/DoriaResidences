Public Class FormSpese
    Dim scritturaOk = New Boolean() {True, True, True, True, True, True}
    Private Sub FormSpese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPulizie.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “pulizia”)
        TxtAnimali.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “animali”)
        TxtExtra.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “extra”)
        TxtSpese1.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese1”)
        TxtSpese2.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese2”)
        TxtSpese3.Text = FormMail.IniRead(FormMail.PATHINI, “COSTI”, “spese3”)
    End Sub

    Private Sub BtnOkSpese_Click(sender As Object, e As EventArgs) Handles BtnOkSpese.Click

        scritturaOk(0) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “pulizia”, TxtPulizie.Text)
        scritturaOk(1) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “extra”, TxtExtra.Text)
        scritturaOk(2) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “animali”, TxtAnimali.Text)
        scritturaOk(3) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “spese1”, TxtSpese1.Text)
        scritturaOk(4) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “spese2”, TxtSpese2.Text)
        scritturaOk(5) = FormMail.IniWrite(FormMail.PATHINI, “COSTI”, “spese3”, TxtSpese3.Text)

        If scritturaOk(0) And scritturaOk(1) And scritturaOk(2) And scritturaOk(3) And scritturaOk(4) And scritturaOk(5) Then
            MsgBox("Scrittura file Ini avvenuta correttamente")
            Close()
        Else
            MsgBox("Scrittura file Ini non avvenuta")

        End If
    End Sub

    Private Sub BtnAnnulSpese_Click(sender As Object, e As EventArgs) Handles BtnAnnulSpese.Click
        Close()
    End Sub

End Class