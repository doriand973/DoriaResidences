﻿Public Class Form2
    '********************************************************************
    'Modelli mail Doria Residences
    '********************************************************************
    Dim titolo As String
    Dim testo As String
    Dim destinat As String
    Dim saluto As String
    Dim corpo As String
    Dim firma As String = vbNewLine & "Andrea Doria" & vbNewLine & vbNewLine & FormMail.INTESTAZIONE_MAIL
    Dim oggetto As String
    Public preventivo As String = ""
    Dim finale As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAvvia.Click
        If FormMail.IngleseToolStripMenuItem.Checked Then
            '********************************************************************
            'Modelli mail in inglese
            '********************************************************************
            If RadioBtnGenerale.Checked Then
                saluto = "Good morning from Doria Residences," & vbNewLine
                destinat = ""
                titolo = ""
            Else
                If RadioBtnUomo.Checked Then
                    titolo = "Mr. "
                ElseIf RadioBtnDonna.Checked Then
                    titolo = "Mrs. "
                ElseIf RadioBtnTO.Checked Then
                    titolo = ""
                End If
                destinat = TxtNomeDest.Text
                saluto = "Good morning " & titolo & destinat & "," & vbNewLine
            End If
            If RadioBtnBooking.Checked Then
                '********************************************************************
                'Modello BOOKING FORM in inglese
                '********************************************************************
                oggetto = "Reservation Doria Residences"
                testo = vbNewLine & "we send you in the attached file our BOOKING RESERVE for your reservation in our Residence" & vbNewLine & "Inside the document you will find the bank information to make the deposit for confirmation" &
                vbNewLine & "We are at your disposal for any further information." & vbNewLine & "Thank you in advance " & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioBtnConfPrenot.Checked Then
                '********************************************************************
                'Modello CONFERMA PRENOTAZIONE DIRETTI in inglese
                '********************************************************************
                oggetto = "Confirmation reservation Doria Residences"
                testo = vbNewLine & "We confirm the reservation made by you in our residence." & vbNewLine & "We will send you the receipt for the deposit you have sent us, as soon as we receive notification by our bank of the payment made by you." &
                vbNewLine & "Thank you again " & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioBtnFattura.Checked Then
                '********************************************************************
                'Modello FATTURA DEPOSITO in inglese
                '********************************************************************
                oggetto = "Doria Residences Invoice Deposit"
                testo = vbNewLine & "We send you in the attached file the receipt of the deposit for your reservation." & vbNewLine & "We are looking forward to seeing you this summer in our residence." &
                vbNewLine & "Thank you and best regards" & vbNewLine
            ElseIf RadioBtnInfo.Checked Then
                '********************************************************************
                'Modello INFORMAZIONI in inglese
                '********************************************************************
                oggetto = "Doria Residences prices and description"
                testo = vbNewLine & "As you requested, we send you in the attached file the price list and description of our residences in Porto Garibaldi and Lido degli Estensi." &
                vbNewLine & "We are at your disposal for any further information." & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioBtnConferma.Checked Then
                '********************************************************************
                'Modello CONFERMA PER T.O. in inglese
                '********************************************************************
                oggetto = "Doria Residences reservation confirmed"
                testo = vbNewLine & "Ok, confirmed " & vbNewLine & "Thank you." & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioBtnPreventivo.Checked Then
                '********************************************************************
                'Modello INVIO PREVENTIVO in inglese
                '********************************************************************
                oggetto = "Doria Residences Quotation"
                testo = vbNewLine & "As you requested, we send you a quotation for the period requested by you. " & vbNewLine & preventivo &
                vbNewLine & "We are at your disposal for any further information." & vbNewLine & vbNewLine & "Best regards"
            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        ElseIf FormMail.ItalianoToolStripMenuItem.Checked Then
            '********************************************************************
            'Modelli mail in italiano
            '********************************************************************
            If RadioBtnGenerale.Checked Then
                saluto = "Buongiorno da Doria Residences," & vbNewLine
                destinat = ""
                titolo = ""
            Else
                If RadioBtnUomo.Checked Then
                    titolo = "Sig. "
                ElseIf RadioBtnDonna.Checked Then
                    titolo = "Sig.ra "
                End If
                destinat = TxtNomeDest.Text
                saluto = "Buongiorno " & titolo & destinat & "," & vbNewLine
            End If
            If RadioBtnBooking.Checked Then
                '********************************************************************
                'Modello BOOKING FORM in italiano
                '********************************************************************
                oggetto = "Prenotazione Doria Residences"
                testo = vbNewLine & "vi inviamo nel file allegato il modulo BOOKING RESERVE per la vostra prenotazione." & vbNewLine & "All'interno del documento troverete le coordinate bancarie per effettuare il bonifico per la caparra." &
                vbNewLine & "Siamo a vostra disposizione per ulteriori informazioni." & vbNewLine & "Grazie " & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioBtnConfPrenot.Checked Then
                '********************************************************************
                'Modello CONFERMA PRENOTAZIONE DIRETTI in italiano
                '********************************************************************
                oggetto = "Conferma prenotazione Doria Residences"
                testo = vbNewLine & "siamo qui a confermarLe la prenotazione da lei effettuata nella nostra struttura." & vbNewLine & "Invieremo la ricevuta dell'acconto per la sua prenotazione, appena ricevuta la notifica dalla nostra banca  del versamento da Lei effettuato. " &
                vbNewLine & "Nel ringraziarLa ancora una volta porgiamo i nostri più cordiali saluti." & vbNewLine & "Grazie" & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioBtnFattura.Checked Then
                '********************************************************************
                'Modello FATTURA DEPOSITO in italiano
                '********************************************************************
                oggetto = "Ricevuta Acconto Doria Residences"
                testo = vbNewLine & "Inviamo in allegato la ricevuta dell'acconto per la sua prenotazione. " & vbNewLine & "Nell'attesa di incontrarla questa estate porgiamo i nostri più cordiali saluti." &
                vbNewLine & "Grazie " & vbNewLine
            ElseIf RadioBtnInfo.Checked Then
                '********************************************************************
                'Modello INFORMAZIONI in italiano
                '********************************************************************
                oggetto = "Listino prezzi e descrizione Doria Residences"
                testo = vbNewLine & "come da sua richiesta per ricerca sistemazione nei Lidi Ferraresi, " & vbNewLine & "Le inviamo nei file allegati il nostro listino prezzi e la descrizione dei nostri residence siti a Porto Garibaldi e Lido degli Estensi." &
                vbNewLine & "Rimaniamo a vostra disposizione per ulteriori informazioni." & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioBtnConferma.Checked Then
                '********************************************************************
                'Modello CONFERMA PER T.O. in italiano
                '********************************************************************
                oggetto = "Conferma prenotazone Doria Residences"
                testo = vbNewLine & "Ok, prenotazione confermata " & vbNewLine & "Grazie." & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioBtnPreventivo.Checked Then
                '********************************************************************
                'Modello INVIO PREVENTIVO in italiano
                '********************************************************************
                oggetto = "Preventivo Doria Residences"
                testo = vbNewLine & "come da accordi telefonici inviamo il preventivo per il soggiorno da Lei richiesto. " & vbNewLine & preventivo &
                vbNewLine & "Rimaniamo a vostra disposizione per ulteriori informazioni." & vbNewLine & vbNewLine & "Cordiali saluti "
            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        End If
        corpo = saluto & testo & firma
        FormMail.TxtTesto.Text = corpo
        FormMail.TxtOggetto.Text = oggetto
        Me.Close()
    End Sub

    Private Sub RadioButton12_Click(sender As Object, e As EventArgs) Handles RadioBtnPreventivo.Click
        Form4.Show()
    End Sub

End Class

