Imports System.DateTime
Public Class Tariffa
    Private dfrom As DateTime
    Private dto As DateTime
    Private bD1 As Integer
    Private tD1 As Integer
    Private bD2 As Integer
    Private tD2 As Integer

    Public Sub New(ByVal dfrom As Date, ByVal dto As Date, ByVal bD1 As Integer, ByVal tD1 As Integer, ByVal bD2 As Integer, ByValtD2 As Integer)
        dfrom = Me.dfrom
        dto = Me.dto
        bD1 = Me.bD1
        bD2 = Me.bD2
        tD1 = Me.tD1
        tD2 = Me.tD2
    End Sub
    ' Function tariffa(dfrom, dto, bD1, tD1, bD2, tD2)
    '    dfrom = Me.dfrom
    '    dto = Me.dto
    '    bD1 = Me.bD1
    '    bD2 = Me.bD2
    '    bD2 = Me.tD1
    '    tD2 = Me.tD2
    ' End Function
    Function getD_start() As Date
        Return Me.dfrom
    End Function
    Sub setD_start(ByVal d As Date)
        d = Me.dfrom
    End Sub
    Function getD_end() As Date
        Return Me.dto
    End Function
    Sub setD_end(ByVal d As Date)
        d = Me.dto
    End Sub
    Function getbiloD1() As Integer
        Return Me.bD1
    End Function
    Function getbiloD2() As Integer
        Return Me.bD2
    End Function
    Function gettriloD1() As Integer
        Return Me.tD1
    End Function
    Function gettriloD2() As Integer
        Return Me.tD2
    End Function
    Function getWeek(d As Date) As Integer
        Return DatePart(DateInterval.WeekOfYear, d)
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
        End Try

    End Function
End Class
