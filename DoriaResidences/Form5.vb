Public Class Form5
    '********************************************************************
    'Modelli mail per Booking.com
    '********************************************************************

    Dim testo As String
    Dim testo_caparra As String
    Dim saluto As String
    Dim corpo As String
    Dim firma As String = vbNewLine & "A. Doria" & vbNewLine & vbNewLine & Form1.INTESTAZIONE_MAIL
    Dim oggetto As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.IngleseToolStripMenuItem.Checked Then
            '********************************************************************
            'Modelli mail in inglese
            '********************************************************************
            saluto = "Good morning from Doria Residences," & vbNewLine

            If RadioButton1.Checked Or RadioButton2.Checked Then
                testo_caparra = ""
                If RadioButton1.Checked Then testo_caparra = "Inside you can find the bank details for the deposit to do within 15 days before the arrival." & vbNewLine
                '********************************************************************
                'Modello contatto Booking.com in inglese
                '********************************************************************
                oggetto = "Booking.com Reservation #" & TextBox1.Text
                testo = vbNewLine & "Thank you for your reservation in our residence" & vbNewLine & "We send you in the attached file a description of our residence and our booking form (BOOKING RESERVE). " &
                vbNewLine & testo_caparra & "For any information please don't hesitate to contact us" & vbNewLine & vbNewLine & "Best regards"

            ElseIf RadioButton5.Checked
                '********************************************************************
                'Modello Cancellazione prenotazione in inglese
                '********************************************************************
                oggetto = "Cancellation Booking.com Reservation #" & TextBox1.Text
                testo = vbNewLine & "Since we had not any feedback regarding the sending of the required deposit for the confirmation of your reservation." &
                vbNewLine & "We regret to inform you that your reservation in our residence is been cancelled." & vbNewLine & vbNewLine & "Best regards"

            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        ElseIf Form1.ItalianoToolStripMenuItem.Checked

            '********************************************************************
            'Modelli mail in italiano
            '********************************************************************
            saluto = "Buongiorno da Doria Residences," & vbNewLine

            If RadioButton1.Checked Or RadioButton2.Checked Then
                testo_caparra = ""
                If RadioButton1.Checked Then testo_caparra = "All’interno potrà trovare le coordinate bancarie per l’acconto da fare entro 15 giorni prima dell’arrivo." & vbNewLine
                '********************************************************************
                'Modello contatto Booking.com in italiano
                '********************************************************************
                oggetto = "Prenotazione Booking.com #" & TextBox1.Text
                testo = vbNewLine & "La ringraziamo per la sua prenotazione nella nostra struttura. " & vbNewLine & "Le inviamo in allegato la descrizione del nostro residence ed il nostro modulo di prenotazione BOOKING RESERVE  " &
                vbNewLine & testo_caparra & "Rimaniamo a disposizione per qualsiasi informazione. " & vbNewLine & vbNewLine & "Cordiali saluti"

            ElseIf RadioButton5.Checked
                '********************************************************************
                'Modello Cancellazione prenotazione in italiano
                '********************************************************************
                oggetto = "Cancellazione Prenotazione Booking.com #" & TextBox1.Text
                testo = vbNewLine & "Non avendo avuto nessun riscontro riguardo all’invio dell’acconto richiesto per la conferma della sua prenotazione. " &
                vbNewLine & "Siamo spiacenti di comunicarle che abbiamo dovuto cancellare la sua prenotazione nella nostra struttura." & vbNewLine & vbNewLine & "Cordiali saluti"

            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        End If
        corpo = saluto & testo & firma
        Form1.TextBox3.Text = corpo
        Form1.TextBox2.Text = oggetto
        Me.Close()
    End Sub
End Class