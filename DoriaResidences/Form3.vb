Imports System.IO
Public Class Form3
    Dim indietro As String = "[..]"
    Dim index As Integer = 0
    'Dim paths As List(Of String)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Dim path As String = ListBox1.SelectedItem.ToString
        ' caricamento primo elemento epr andare a ritroso tra le directori
        ListBox3.Items.Add(path)

        Dim dir() As String
        dir = Directory.GetDirectories(path)
        ListBox2.Items.Add(indietro)
        'caircamento delle directories sul drive selezionato
        For i = 0 To dir.Length - 1
            ListBox2.Items.Add(dir(i).ToString)
        Next
        'caricamento files sul drive selezionato
        Dim file() As String
        file = Directory.GetFiles(path)
        For i = 0 To file.Length - 1
            ListBox2.Items.Add(file(i).ToString)
        Next
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'caricamento dei drives dell pc
        Dim drive() As DriveInfo
        drive = IO.DriveInfo.GetDrives
        For i = 0 To drive.Length - 1
            ListBox1.Items.Add(drive(i).ToString)
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

        Dim path As String

        ' storico dei percorsi ricercati

        If ListBox2.SelectedIndex = 0 And index > 0 Then

            ListBox3.Items.RemoveAt(index)
            path = ListBox3.Items.Item(index - 1).ToString
            index -= 1

        ElseIf ListBox2.SelectedIndex = 0 And index = 0 Then

            MsgBox("Non è possibile andare ulteriormente in dietro")
            Exit Sub

        Else

            path = ListBox2.SelectedItem.ToString

            If Directory.Exists(path) = False Then


                If MsgBox("Allegare file selezionato?", MsgBoxStyle.YesNo, "attenzione") = MsgBoxResult.Yes Then

                    Form1.ListBox1.Items.Add(path)

                End If

                Exit Sub
            End If


            ListBox3.Items.Add(path)
            index = ListBox3.Items.Count - 1

        End If

        ListBox2.Items.Clear()
        Dim dir() As String
        dir = Directory.GetDirectories(path)
        'caricamento dell'elemento indietro
        ListBox2.Items.Add(indietro)
        'caricamento delle sottodirectories della directory selezionata
        For i = 0 To dir.Length - 1
            ListBox2.Items.Add(dir(i).ToString)
        Next
        'caricamento dei file delle sottodirectories selezionate
        Dim file() As String
        file = Directory.GetFiles(path)
        For i = 0 To file.Length - 1
            ListBox2.Items.Add(file(i).ToString)
        Next


    End Sub
End Class