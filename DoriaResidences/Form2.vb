﻿Public Class Form2
    Dim titolo As String
    Dim testo As String
    Dim destinat As String
    Dim saluto As String
    Dim corpo As String
    Dim FIRMA As String = vbNewLine & "Andrea Doria" & vbNewLine & vbNewLine & "Doria Residences" & vbNewLine & "mail: doria.residences@gmail.com" & vbNewLine & "internet: www.doriares.it" & vbNewLine & "mobile: +393358273362"
    Dim oggetto As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            '********************************************************************
            'Modelli mail in inglese
            '********************************************************************
            If RadioButton9.Checked Then
                saluto = "Good morning from Doria Residences," & vbNewLine
                destinat = ""
                titolo = ""
            Else
                If RadioButton6.Checked Then
                    titolo = "Mr. "
                ElseIf RadioButton7.Checked
                    titolo = "Mrs. "
                ElseIf RadioButton11.Checked
                    titolo = ""
                End If
                destinat = TextBox1.Text
                saluto = "Good morning " & titolo & destinat & "," & vbNewLine
            End If
            If RadioButton3.Checked Then
                oggetto = "Reservation Doria Residences"
                testo = vbNewLine & "we send you in the attached file our BOOKING RESERVE for your reservation in our Residence" & vbNewLine & "Inside the document you will find the bank information to make the deposit for confirmation" &
                vbNewLine & "We are at your disposal for any further information." & vbNewLine & "Thank you in advance " & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioButton4.Checked
                oggetto = "Confirmation reservation Doria Residences"
                testo = vbNewLine & "We confirm the reservation made by you in our residence." & vbNewLine & "We will send you the receipt for the deposit you have sent us, as soon as we receive notification by our bank of the payment made by you." &
                vbNewLine & "Thank you again " & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioButton5.Checked
                oggetto = "Doria Residences Invoice Deposit"
                testo = vbNewLine & "We send you in the attached file the receipt of the deposit for your reservation." & vbNewLine & "We are looking forward to seeing you this summer in our residence." &
                vbNewLine & "Thank you and best regards" & vbNewLine
            ElseIf RadioButton8.Checked
                oggetto = "Doria Residences prices and description"
                testo = vbNewLine & "As you requested, we send you in the attached file the price list and description of our residences in Porto Garibaldi and Lido degli Estensi." &
                vbNewLine & "We are at your disposal for any further information." & vbNewLine & vbNewLine & "Best regards"
            ElseIf RadioButton10.Checked
                oggetto = "Doria Residences reservation confirmed"
                testo = vbNewLine & "Ok, confirmed " & vbNewLine & "Thank you." & vbNewLine & vbNewLine & "Best regards"
            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        Else
            '********************************************************************
            'Modelli mail in italiano
            '********************************************************************
            If RadioButton9.Checked Then
                saluto = "Buongiorno da Doria Residences," & vbNewLine
                destinat = ""
                titolo = ""
            Else
                If RadioButton6.Checked Then
                    titolo = "Sig. "
                ElseIf RadioButton7.Checked
                    titolo = "Sig.ra "
                End If
                destinat = TextBox1.Text
                saluto = "Buongiorno " & titolo & destinat & "," & vbNewLine
            End If
            If RadioButton3.Checked Then
                oggetto = "Prenotazione Doria Residences"
                testo = vbNewLine & "vi inviamo nel file allegato il modulo BOOKING RESERVE per la vostra prenotazione." & vbNewLine & "All'interno del documento troverete le coordinate bancarie per effettuare il bonifico per la caparra." &
                vbNewLine & "Siamo a vostra disposizione per ulteriori informazioni." & vbNewLine & "Grazie " & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioButton4.Checked
                oggetto = "Conferma prenotazione Doria Residences"
                testo = vbNewLine & "siamo qui a confermarLe la prenotazione da lei effettuata nella nostra struttura." & vbNewLine & "Invieremo la ricevuta dell'acconto per la sua prenotazione, appena ricevuta la notifica dalla nostra banca  del versamento da Lei effettuato. " &
                vbNewLine & "Nel ringraziarLa ancora una volta porgiamo i nostri più cordiali saluti." & vbNewLine & "Grazie" & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioButton5.Checked
                oggetto = "Ricevuta Acconto Doria Residences"
                testo = vbNewLine & "Inviamo in allegato la ricevuta dell'acconto per la sua prenotazione. " & vbNewLine & "Nell'attesa di incontrarla questa estate porgiamo i nostri più cordiali saluti." &
                vbNewLine & "Grazie " & vbNewLine
            ElseIf RadioButton8.Checked
                oggetto = "Listino prezzi e descrizione Doria Residences"
                testo = vbNewLine & "come da sua richiesta per ricerca sistemazione nei Lidi Ferraresi, " & vbNewLine & "Le inviamo nei file allegati il nostro listino prezzi e la descrizione dei nostri residence siti a Porto Garibaldi e Lido degli Estensi." &
                vbNewLine & "Rimaniamo a vostra disposizione per ulteriori informazioni." & vbNewLine & vbNewLine & "Cordiali saluti "
            ElseIf RadioButton10.Checked
                oggetto = "Conferma prenotazone Doria Residences"
                testo = vbNewLine & "Ok, prenotazione confermata " & vbNewLine & "Grazie." & vbNewLine & vbNewLine & "Cordiali saluti "
            Else
                MsgBox("Errore immissione tipologia mail")
                Exit Sub
            End If
        End If
        corpo = saluto & testo & FIRMA
        Form1.TextBox3.Text = corpo
        Form1.TextBox2.Text = oggetto
        Me.Close()
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

    End Sub
End Class
