Imports System.DateTime
Public Class Tariffa
    Private dfrom As Date
    Private dto As Date
    Private bD1 As Integer
    Private tD1 As Integer
    Private bD2 As Integer
    Private tD2 As Integer

    Public Sub New(ByVal dfrom As Date, ByVal dto As Date, ByVal bD1 As Integer, ByVal tD1 As Integer, ByVal bD2 As Integer, ByVal tD2 As Integer)
        Me.dfrom = dfrom
        Me.dto = dto
        Me.bD1 = bD1
        Me.bD2 = bD2
        Me.tD1 = tD1
        Me.tD2 = tD2
    End Sub

    Function getD_start() As Date
        Return dfrom
    End Function
    Sub setD_start(ByVal d As Date)
        dfrom = d
    End Sub
    Function getD_end() As Date
        Return dto
    End Function
    Sub setD_end(ByVal d As Date)
        dto = d
    End Sub
    Function getbiloD1() As Integer
        Return bD1
    End Function
    Function getbiloD2() As Integer
        Return bD2
    End Function
    Function gettriloD1() As Integer
        Return tD1
    End Function
    Function gettriloD2() As Integer
        Return tD2
    End Function
    ' Funzione che mi restituisce il numero della settimana dell'anno dato il giorno
    Private Function getWeek(d As Date) As Integer
        Return DatePart(DateInterval.WeekOfYear, d) - 1
    End Function
    Function getWeek_start() As Integer
        Return getWeek(dfrom)
    End Function
    Function getWeek_end() As Integer
        Return getWeek(dto)
    End Function
    Function getprezzo(s As String)
        Dim prezzo As Integer
        Try
            If s = "bD1" Then
                prezzo = bD1
            ElseIf s = "bD2" Then
                prezzo = bD2
            ElseIf s = "tD1" Then
                prezzo = tD1
            ElseIf s = "tD2" Then
                prezzo = tD2
            End If
            Return prezzo
        Catch ex As Exception
            MsgBox("Tariffa inesistente, Image valore corretto")
            Return -1
        End Try

    End Function
    Overrides Function ToString() As String
        Dim s As String
        s = Me.dfrom.ToString("d/MM/yyyy") & " , " & Me.dto.ToString("d/MM/yyyy") & " , " & Me.bD1.ToString & " , " & Me.tD1.ToString & " , " & Me.bD2.ToString & " , " & Me.tD2.ToString
        Return s
    End Function
End Class
