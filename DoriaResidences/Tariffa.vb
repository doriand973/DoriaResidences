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

    Public ReadOnly Property DataIn As Date
        Get
            Return dfrom
        End Get
    End Property

    Public ReadOnly Property DataFin As Date
        Get
            Return dto
        End Get
    End Property

    Public ReadOnly Property Bilo1 As Integer
        Get
            Return bD1
        End Get
    End Property

    Public ReadOnly Property Bilo2 As Integer
        Get
            Return bD2
        End Get
    End Property

    Public ReadOnly Property Trilo1 As Integer
        Get
            Return tD1
        End Get
    End Property

    Public ReadOnly Property Trilo2 As Integer
        Get
            Return tD2
        End Get
    End Property

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
    '*************************************************************************
    ' Funzione che mi restituisce il numero della settimana dell'anno dato il giorno
    '*************************************************************************
    Private Function getWeek(d As Date) As Integer
        Return DatePart(DateInterval.WeekOfYear, d) - 1
    End Function

    Function getWeek_start() As Integer
        Return getWeek(dfrom)
    End Function

    Function getWeek_end() As Integer
        Return getWeek(dto)
    End Function
    Function getprezzo(s As Integer)
        Dim prezzo As Integer
        Try
            Select Case s
                Case 0
                    prezzo = bD1
                Case 1
                    prezzo = tD1
                Case 2
                    prezzo = bD2
                Case 3
                    prezzo = tD2
            End Select
            Return prezzo
        Catch ex As Exception
            MsgBox("Tariffa inesistente, Image valore corretto")
            Return -1
        End Try

    End Function
    '*************************************************************************
    ' Costrutto di scrittura in stringa della tariffa
    '*************************************************************************
    Overrides Function ToString() As String
        Dim s As String
        s = Me.dfrom.ToString("d/MM/yyyy") & " , " & Me.dto.ToString("d/MM/yyyy") & " , " & Me.bD1.ToString & " , " & Me.tD1.ToString & " , " & Me.bD2.ToString & " , " & Me.tD2.ToString
        Return s
    End Function
    '*************************************************************************
    ' Controlla se la data di arrivo immessa fa parte della tariffa selezionata
    '*************************************************************************
    Function FindArr(d As Date) As Boolean
        Dim yes As Boolean
        If d >= dfrom And d < dto Then
            yes = True
        Else
            yes = False
        End If
        Return yes
    End Function
    '*************************************************************************
    ' Controlla se la data di partenza immessa fa parte della tariffa selezionata
    '*************************************************************************
    Function FindPart(d As Date) As Boolean
        Dim yes As Boolean
        If d > dfrom And d <= dto Then
            yes = True
        Else
            yes = False
        End If
        Return yes
    End Function
    '*************************************************************************
    ' Controlla se il n° della settimana rientra nel periodo selezionato dalle date inserite
    '*************************************************************************
    Function CheckWeek(n As Integer) As Boolean
        Dim yes As Boolean
        If n > getWeek_start() And n <= getWeek_end() Then
            yes = True
        Else
            yes = False
        End If
        Return yes
    End Function
End Class
