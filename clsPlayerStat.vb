Public Class clsPlayerStat
    Public PlayerLongName As String = ""
    Public PlayerShortName As String = ""
    Public PlayerSortName As String = ""
    Public PlayerID As Integer = -1
    Public PlayerNum As Integer = 0
    Public Stat01 As Integer = 0
    Public Stat02 As Integer = 0
    Public Stat03 As Integer = 0
    Public Stat04 As Integer = 0
    Public Stat05 As Integer = 0
    Public Stat06 As Integer = 0
    Public Stat07 As Integer = 0
    Public Stat08 As Integer = 0
    Public Stat09 As Integer = 0
    Public Stat10 As Integer = 0
    Public Stat11 As Integer = 0
    Public Stat12 As Integer = 0
    Public Stat13 As Integer = 0
    Public Stat14 As Integer = 0
    Public Stat15 As Integer = 0
    Public Stat16 As Integer = 0
    Public Stat17 As Integer = 0
    Public Stat18 As Integer = 0
    Public Stat19 As Integer = 0
    Public Stat20 As Integer = 0
    Public Stat21 As Integer = 0
    Public Stat22 As Integer = 0
    Public Stat23 As Integer = 0
    Public Stat24 As Integer = 0
    Public Stat25 As Integer = 0
    Public Stat26 As Integer = 0
    Public Stat27 As Integer = 0
    Public Stat28 As Integer = 0
    Public Stat29 As Integer = 0
    Public Stat30 As Integer = 0
    Sub AssignStat(ByVal iStatNum As Integer, ByVal iValue As Integer)
        Select Case iStatNum
            Case 1
                Stat01 += iValue
            Case 2
                Stat02 += iValue
            Case 3
                Stat03 += iValue
            Case 4
                Stat04 += iValue
            Case 5
                Stat05 += iValue
            Case 6
                Stat06 += iValue
            Case 7
                Stat07 += iValue
            Case 8
                Stat08 += iValue
            Case 9
                Stat09 += iValue
            Case 10
                Stat10 += iValue
            Case 11
                Stat11 += iValue
            Case 12
                Stat12 += iValue
            Case 13
                Stat13 += iValue
            Case 14
                Stat14 += iValue
            Case 15
                Stat15 += iValue
            Case 16
                Stat16 += iValue
            Case 17
                Stat17 += iValue
            Case 18
                Stat18 += iValue
            Case 19
                Stat19 += iValue
            Case 20
                Stat20 += iValue
            Case 21
                Stat21 += iValue
            Case 22
                Stat22 += iValue
            Case 23
                Stat23 += iValue
            Case 24
                Stat24 += iValue
            Case 25
                Stat25 += iValue
            Case 26
                Stat26 += iValue
            Case 27
                Stat27 += iValue
            Case 28
                Stat28 += iValue
            Case 29
                Stat29 += iValue
            Case 30
                Stat30 += iValue
        End Select
        CheckLimits()
    End Sub
    Sub ZeroStat(ByVal iStatNum As Integer)
        Select Case iStatNum
            Case 1
                Stat01 = 0
            Case 2
                Stat02 = 0
            Case 3
                Stat03 = 0
            Case 4
                Stat04 = 0
            Case 5
                Stat05 = 0
            Case 6
                Stat06 = 0
            Case 7
                Stat07 = 0
            Case 8
                Stat08 = 0
            Case 9
                Stat09 = 0
            Case 10
                Stat10 = 0
            Case 11
                Stat11 = 0
            Case 12
                Stat12 = 0
            Case 13
                Stat13 = 0
            Case 14
                Stat14 = 0
            Case 15
                Stat15 = 0
            Case 16
                Stat16 = 0
            Case 17
                Stat17 = 0
            Case 18
                Stat18 = 0
            Case 19
                Stat19 = 0
            Case 20
                Stat20 = 0
            Case 21
                Stat21 = 0
            Case 22
                Stat22 = 0
            Case 23
                Stat23 = 0
            Case 24
                Stat24 = 0
            Case 25
                Stat25 = 0
            Case 26
                Stat26 = 0
            Case 27
                Stat27 = 0
            Case 28
                Stat28 = 0
            Case 29
                Stat29 = 0
            Case 30
                Stat30 = 0
        End Select
        CheckLimits()
    End Sub
    Sub CheckLimits()
        If Stat01 < 0 Then Stat01 = 0
        If Stat02 < 0 Then Stat02 = 0
        If Stat03 < 0 Then Stat03 = 0
        If Stat04 < 0 Then Stat04 = 0
        If Stat05 < 0 Then Stat05 = 0
        If Stat06 < 0 Then Stat06 = 0
        If Stat07 < 0 Then Stat07 = 0
        If Stat08 < 0 Then Stat08 = 0
        If Stat09 < 0 Then Stat09 = 0
        If Stat10 < 0 Then Stat10 = 0
        If Stat11 < 0 Then Stat11 = 0
        If Stat12 < 0 Then Stat12 = 0
        If Stat13 < 0 Then Stat13 = 0
        If Stat14 < 0 Then Stat14 = 0
        If Stat15 < 0 Then Stat15 = 0
        If Stat16 < 0 Then Stat16 = 0
        If Stat17 < 0 Then Stat17 = 0
        If Stat18 < 0 Then Stat18 = 0
        If Stat19 < 0 Then Stat19 = 0
        If Stat20 < 0 Then Stat20 = 0
        If Stat21 < 0 Then Stat21 = 0
        If Stat22 < 0 Then Stat22 = 0
        If Stat23 < 0 Then Stat23 = 0
        If Stat24 < 0 Then Stat24 = 0
        If Stat25 < 0 Then Stat25 = 0
        If Stat26 < 0 Then Stat26 = 0
        If Stat27 < 0 Then Stat27 = 0
        If Stat28 < 0 Then Stat28 = 0
        If Stat29 < 0 Then Stat29 = 0
        If Stat30 < 0 Then Stat30 = 0

    End Sub
    ReadOnly Property ButtonText() As String
        Get
            If PlayerID = -1 Then
                Return ""
            Else
                Return PlayerNum & vbLf & PlayerLongName
            End If
        End Get
    End Property
End Class
