Imports System.IO

Public Class Preziario

    Private Sub MonthCalInizio_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalInizio.DateSelected
        Dim dInit As Date
        dInit = MonthCalInizio.SelectionRange.Start
        TxtInizio.Text = dInit.ToString("yyyy,MM,dd")
        MonthCalInizio.Hide()
    End Sub


    Private Sub MonthCalFine_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalFine.DateSelected
        Dim dFin As Date
        dFin = MonthCalFine.SelectionRange.End
        TxtFine.Text = dFin.ToString("yyyy,MM,dd")
        MonthCalFine.Hide()
    End Sub


    Private Sub TxtInizio_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtInizio.MouseClick
        MonthCalInizio.Show()
        MonthCalInizio.BringToFront()
        MonthCalFine.Hide()
    End Sub

    Private Sub TxtFine_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtFine.MouseClick
        MonthCalFine.Show()
        MonthCalFine.BringToFront()
        MonthCalInizio.Hide()
    End Sub

    Private Sub BtnAggiungi_Click(sender As Object, e As EventArgs) Handles BtnAggiungi.Click
        'Aggiungo una nuova riga con i valori da me immessi
        If TxtInizio.TextLength = 0 Or TxtFine.TextLength = 0 Or TxtPrezBilo.TextLength = 0 Or TxtPrezTrilo1.TextLength = 0 Or TxtPrezTrilo2.TextLength = 0 Then
            MsgBox("Impossibile inserire dati! Riprovare!", MsgBoxStyle.OkOnly)
        Else
            DataGridVPrezzi.Rows.Add(TxtInizio.Text, TxtFine.Text, TxtPrezBilo.Text, TxtPrezTrilo1.Text, TxtPrezTrilo2.Text)
            TxtInizio.Text = ""
            TxtFine.Text = ""
            TxtPrezBilo.Text = ""
            TxtPrezTrilo1.Text = ""
            TxtPrezTrilo2.Text = ""
        End If
    End Sub

    Private Sub Preziario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Creo l'intestazione delle mie colonne
        DataGridVPrezzi.ColumnCount = 5
        DataGridVPrezzi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridVPrezzi.Columns(0).HeaderText = "Data Inizio"
        DataGridVPrezzi.Columns(1).HeaderText = "Data Fine"
        DataGridVPrezzi.Columns(2).HeaderText = "Bilo"
        DataGridVPrezzi.Columns(3).HeaderText = "Trilo"
        DataGridVPrezzi.Columns(4).HeaderText = "Trilo2"
    End Sub

    Private Sub BtnLeggi_Click(sender As Object, e As EventArgs) Handles BtnLeggi.Click
        ' Lettura da file del prezziario esistente
        DataGridVPrezzi.Rows.Clear()

        Try
            Dim leggi As New StreamReader("C:\Doriares\prezzi.csv")
            Dim riga As String
            Dim celle() As String
            If leggi.Peek = -1 Then
                MsgBox("File Vuoto!", MsgBoxStyle.OkOnly)
            Else
                While leggi.Peek <> -1
                    riga = leggi.ReadLine
                    celle = Split(riga, ";")
                    DataGridVPrezzi.Rows.Add(celle)
                End While
            End If
            leggi.Close()
        Catch ex As System.IO.FileNotFoundException
            MsgBox("Il file non esiste! Crealo prima!", MsgBoxStyle.OkOnly)
        End Try


    End Sub

    Private Sub BtnScrivi_Click(sender As Object, e As EventArgs) Handles BtnScrivi.Click
        'Scrittura su file del nuovo prezziario
        Dim scrivi As New StreamWriter("C:\Doriares\prezzi.csv")
        Dim i As Integer
        Dim j As Integer
        Dim testoCella As String = ""

        For i = 0 To DataGridVPrezzi.Rows.Count - 2
            For j = 0 To DataGridVPrezzi.Columns.Count - 1
                testoCella = testoCella & DataGridVPrezzi.Rows(i).Cells(j).Value

                If j < DataGridVPrezzi.Columns.Count - 1 Then
                    testoCella = testoCella & ";"
                End If

            Next
            scrivi.WriteLine(testoCella)
            testoCella = ""
        Next

        scrivi.Close()
    End Sub

    Private Sub BtnElimina_Click(sender As Object, e As EventArgs) Handles BtnElimina.Click
        DataGridVPrezzi.Rows.Clear()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.Close()

    End Sub
End Class