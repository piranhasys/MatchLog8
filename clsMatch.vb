Public Class clsMatch


    Private iMatchID As Integer = -1
    Private iHomeTeamID As Integer = -1
    Private iAwayTeamID As Integer = -1

    '    MatchList|Date|Number|Event1^HomeShortName1^AwayShortName1|Event2^HomeShortName2^AwayShortName2|...
    '    MatchDetails|MatchID|SportType|League|Date|Period|StatePhrase|HomeID|AwayID|HomeShortName^AwayShortName^HomeLongName^AwayLongName|HomeScoreLine^AwayScoreLine^HomeGoals^AwayGoals^HomePoints^AwayPoints^HomeTries^AwayTries


    Private bHomeTeamReceived As Boolean = False
    Private bAwayTeamReceived As Boolean = False

    Public Property AwayTeamReceived() As Boolean
        Get
            Return bAwayTeamReceived
        End Get
        Set(ByVal value As Boolean)
            bAwayTeamReceived = value
        End Set
    End Property


    Public Property HomeTeamReceived() As Boolean
        Get
            Return bHomeTeamReceived
        End Get
        Set(ByVal value As Boolean)
            bHomeTeamReceived = value
        End Set
    End Property


    Private bHomeLtoRatKO As Boolean = True
    Public Property HomeLtoRatKO() As Boolean
        Get
            Return bHomeLtoRatKO
        End Get
        Set(ByVal value As Boolean)
            bHomeLtoRatKO = value
        End Set
    End Property


    Private dtMatchDate As Date = Now
    Private strEventName As String = ""
    Private strHomeShortName As String = ""
    Private strAwayShortName As String = ""
    Private strLeagueName As String = ""
    Private strHomeLongName As String = ""
    Private strAwayLongName As String = ""
    Private strHomeGoals As String = "0"  'total score in rugby
    Private strHomeTries As String = "0"
    Private strHomePoints As String = "0"
    Private strAwayGoals As String = "0"  'total score in rugby
    Private strAwayTries As String = "0"
    Private strAwayPoints As String = "0"
    Private strKOTime As String = ""
    Private strStatePhrase As String = ""
    Private iPeriod As Integer = 0
    Private iSportType As Integer = -1
    Private strHomeScoreLine As String = ""
    Private strAwayScoreLine As String = ""
    Private iHomeColour As Integer = 0
    Private iAwayColour As Integer = 0
    Private iHomeColour2 As Integer = 0
    Private iAwayColour2 As Integer = 0
    Public Stat01H As Integer = 0
    Public Stat02H As Integer = 0
    Public Stat03H As Integer = 0
    Public Stat04H As Integer = 0
    Public Stat05H As Integer = 0
    Public Stat06H As Integer = 0
    Public Stat07H As Integer = 0
    Public Stat08H As Integer = 0
    Public Stat09H As Integer = 0
    Public Stat10H As Integer = 0
    Public Stat11H As Integer = 0
    Public Stat12H As Integer = 0
    Public Stat13H As Integer = 0
    Public Stat14H As Integer = 0
    Public Stat15H As Integer = 0
    Public Stat16H As Integer = 0
    Public Stat17H As Integer = 0
    Public Stat18H As Integer = 0
    Public Stat19H As Integer = 0
    Public Stat20H As Integer = 0
    Public Stat21H As Integer = 0
    Public Stat22H As Integer = 0
    Public Stat23H As Integer = 0
    Public Stat24H As Integer = 0
    Public Stat25H As Integer = 0
    Public Stat26H As Integer = 0
    Public Stat27H As Integer = 0
    Public Stat28H As Integer = 0
    Public Stat29H As Integer = 0
    Public Stat30H As Integer = 0
    Public Stat01A As Integer = 0
    Public Stat02A As Integer = 0
    Public Stat03A As Integer = 0
    Public Stat04A As Integer = 0
    Public Stat05A As Integer = 0
    Public Stat06A As Integer = 0
    Public Stat07A As Integer = 0
    Public Stat08A As Integer = 0
    Public Stat09A As Integer = 0
    Public Stat10A As Integer = 0
    Public Stat11A As Integer = 0
    Public Stat12A As Integer = 0
    Public Stat13A As Integer = 0
    Public Stat14A As Integer = 0
    Public Stat15A As Integer = 0
    Public Stat16A As Integer = 0
    Public Stat17A As Integer = 0
    Public Stat18A As Integer = 0
    Public Stat19A As Integer = 0
    Public Stat20A As Integer = 0
    Public Stat21A As Integer = 0
    Public Stat22A As Integer = 0
    Public Stat23A As Integer = 0
    Public Stat24A As Integer = 0
    Public Stat25A As Integer = 0
    Public Stat26A As Integer = 0
    Public Stat27A As Integer = 0
    Public Stat28A As Integer = 0
    Public Stat29A As Integer = 0
    Public Stat30A As Integer = 0



    Private iDisplayDirection As Integer
    Public Property DisplayDirection() As Integer
        'used for clients not actually logging direction - received from MatchData
        Get
            Return iDisplayDirection
        End Get
        Set(ByVal value As Integer)
            iDisplayDirection = value
        End Set
    End Property


    ReadOnly Property CurrentDirection() As Integer
        Get
            '1=Home Left to Right
            Select Case iPeriod
                Case 1, 5
                    If bHomeLtoRatKO = True Then
                        Return 1
                    Else
                        Return 2
                    End If
                Case 3, 7
                    If bHomeLtoRatKO = True Then
                        Return 2
                    Else
                        Return 1
                    End If
                Case Else
                    Return 0
            End Select
        End Get
    End Property
    ReadOnly Property TeamDirection(ByVal teamID As Integer) As KickoutDirection
        Get
            Select Case teamID
                Case iHomeTeamID
                    If HomeLR Then
                        Return KickoutDirection.LeftToRight
                    Else
                        Return KickoutDirection.RightToLeft
                    End If
                Case iAwayTeamID
                    If AwayLR Then
                        Return KickoutDirection.LeftToRight
                    Else
                        Return KickoutDirection.RightToLeft
                    End If
                Case Else
                    Return KickoutDirection.Undefined
            End Select
        End Get
    End Property

    ReadOnly Property TeamNameFromID(ByVal thisID As Integer) As String
        Get
            If thisID = iHomeTeamID Then
                Return strHomeLongName
            ElseIf thisID = iAwayTeamID Then
                Return strAwayLongName
            Else
                Return ""
            End If
        End Get
    End Property

    ReadOnly Property LRTeamName() As String
        Get
            If HomeLR Then
                Return strHomeLongName
            Else
                Return strAwayLongName
            End If
        End Get
    End Property
    ReadOnly Property RLTeamName() As String
        Get
            If AwayLR Then
                Return strHomeLongName
            Else
                Return strAwayLongName
            End If
        End Get
    End Property
    ReadOnly Property LRTeamID() As Integer
        Get
            If HomeLR Then
                Return iHomeTeamID
            Else
                Return iAwayTeamID
            End If
        End Get
    End Property
    ReadOnly Property RLTeamID() As Integer
        Get
            If AwayLR Then
                Return iHomeTeamID
            Else
                Return iAwayTeamID
            End If
        End Get
    End Property

    ReadOnly Property HomeLR() As Boolean
        Get
            Select Case iPeriod
                Case 0, 1, 4, 5
                    Return bHomeLtoRatKO
                Case 2, 3, 6, 7
                    Return Not (bHomeLtoRatKO)
                Case Else
                    Return False
            End Select
        End Get
    End Property
    ReadOnly Property AwayLR() As Boolean
        Get
            Select Case iPeriod
                Case 2, 3, 6, 7
                    Return bHomeLtoRatKO
                Case 0, 1, 4, 5
                    Return Not (bHomeLtoRatKO)
                Case Else
                    Return False
            End Select
        End Get
    End Property
    Public Property AwayColour() As Integer
        Get
            Return iAwayColour
        End Get
        Set(ByVal value As Integer)
            iAwayColour = value
        End Set
    End Property

    Public Property HomeColour() As Integer
        Get
            Return iHomeColour
        End Get
        Set(ByVal value As Integer)
            iHomeColour = value
        End Set
    End Property
    Public Property AwayColour2() As Integer
        Get
            Return iAwayColour2
        End Get
        Set(ByVal value As Integer)
            iAwayColour2 = value
        End Set
    End Property

    Public Property HomeColour2() As Integer
        Get
            Return iHomeColour2
        End Get
        Set(ByVal value As Integer)
            iHomeColour2 = value
        End Set
    End Property

    Public Property AwayScoreLine() As String
        Get
            Return strAwayScoreLine
        End Get
        Set(ByVal value As String)
            strAwayScoreLine = value
        End Set
    End Property


    Public Property HomeScoreLine() As String
        Get
            Return strHomeScoreLine
        End Get
        Set(ByVal value As String)
            strHomeScoreLine = value
        End Set
    End Property



    Public Property SportType() As Integer
        Get
            Return iSportType
        End Get
        Set(ByVal value As Integer)
            iSportType = value
        End Set
    End Property

    Public Property Period() As Integer
        Get
            Return iPeriod
        End Get
        Set(ByVal value As Integer)
            iPeriod = value
        End Set
    End Property

    Public Property StatePhrase() As String
        Get
            Return strStatePhrase
        End Get
        Set(ByVal value As String)
            strStatePhrase = value
        End Set
    End Property

    Public Property AwayLongName() As String
        Get
            Return strAwayLongName
        End Get
        Set(ByVal value As String)
            strAwayLongName = value
        End Set
    End Property

    Public Property HomeLongName() As String
        Get
            Return strHomeLongName
        End Get
        Set(ByVal value As String)
            strHomeLongName = value
        End Set
    End Property

    Property HomeGoals() As String
        Get
            Return strHomeGoals
        End Get
        Set(ByVal Value As String)
            strHomeGoals = Value
        End Set
    End Property
    Property AwayGoals() As String
        Get
            Return strAwayGoals
        End Get
        Set(ByVal Value As String)
            strAwayGoals = Value
        End Set
    End Property
    Property HomePoints() As String
        Get
            Return strHomePoints
        End Get
        Set(ByVal Value As String)
            strHomePoints = Value
        End Set
    End Property
    Property AwayPoints() As String
        Get
            Return strAwayPoints
        End Get
        Set(ByVal Value As String)
            strAwayPoints = Value
        End Set
    End Property
    Property HomeTries() As String
        Get
            Return strHomeTries
        End Get
        Set(ByVal Value As String)
            strHomeTries = Value
        End Set
    End Property
    Property AwayTries() As String
        Get
            Return strAwayTries
        End Get
        Set(ByVal Value As String)
            strAwayTries = Value
        End Set
    End Property

    'ReadOnly Property Scoreline() As String
    '    Get
    '        Return HomeScore & "-" & AwayScore
    '    End Get
    'End Property

    'ReadOnly Property HomeScore() As String
    '    Get
    '        Select Case Config.SportType
    '            Case Module1.SportType.Soccer, Module1.SportType.Undefined, Module1.SportType.Hockey, Module1.SportType.Rugby
    '                Return strHomeGoals
    '            Case Module1.SportType.GAAFootball, Module1.SportType.GAAHurling
    '                Return ((Val(strHomeGoals) * 3) + Val(strHomePoints)).ToString
    '            Case Else
    '                Return ("")
    '        End Select
    '    End Get
    'End Property
    'ReadOnly Property AwayScore() As String
    '    Get
    '        Select Case Config.SportType
    '            Case Module1.SportType.Soccer, Module1.SportType.Undefined, Module1.SportType.Hockey, Module1.SportType.Rugby
    '                Return strAwayGoals
    '            Case Module1.SportType.GAAFootball, Module1.SportType.GAAHurling
    '                Return ((Val(strAwayGoals) * 3) + Val(strAwayPoints)).ToString
    '            Case Else
    '                Return ("")
    '        End Select

    '    End Get
    'End Property



    Public Property LeagueName() As String
        Get
            Return strLeagueName
        End Get
        Set(ByVal value As String)
            strLeagueName = value
        End Set
    End Property


    Public Property AwayShortName() As String
        Get
            Return strAwayShortName
        End Get
        Set(ByVal value As String)
            strAwayShortName = value
        End Set
    End Property


    Public Property HomeShortName() As String
        Get
            Return strHomeShortName
        End Get
        Set(ByVal value As String)
            strHomeShortName = value
        End Set
    End Property


    Public Property EventName() As String
        Get
            Return strEventName
        End Get
        Set(ByVal value As String)
            strEventName = value
        End Set
    End Property


    Public Property MatchDate() As Date
        Get
            Return dtMatchDate
        End Get
        Set(ByVal value As Date)
            dtMatchDate = value
        End Set
    End Property


    Public Property MatchID() As Integer
        Get
            Return iMatchID
        End Get
        Set(ByVal value As Integer)
            iMatchID = value
        End Set
    End Property


    Public Property HomeTeamID() As Integer
        Get
            Return iHomeTeamID
        End Get
        Set(ByVal value As Integer)
            iHomeTeamID = value
        End Set
    End Property

    Public Property AwayTeamID() As Integer
        Get
            Return iAwayTeamID
        End Get
        Set(ByVal value As Integer)
            iAwayTeamID = value
        End Set
    End Property



    Sub AssignStat(ByVal iTeam As Integer, ByVal iStatNum As Integer, ByVal iValue As Integer)
        Select Case iTeam
            Case 1
                Select Case iStatNum
                    Case 1
                        Stat01H += iValue
                    Case 2
                        Stat02H += iValue
                    Case 3
                        Stat03H += iValue
                    Case 4
                        Stat04H += iValue
                    Case 5
                        Stat05H += iValue
                    Case 6
                        Stat06H += iValue
                    Case 7
                        Stat07H += iValue
                    Case 8
                        Stat08H += iValue
                    Case 9
                        Stat09H += iValue
                    Case 10
                        Stat10H += iValue
                    Case 11
                        Stat11H += iValue
                    Case 12
                        Stat12H += iValue
                    Case 13
                        Stat13H += iValue
                    Case 14
                        Stat14H += iValue
                    Case 15
                        Stat15H += iValue
                    Case 16
                        Stat16H += iValue
                    Case 17
                        Stat17H += iValue
                    Case 18
                        Stat18H += iValue
                    Case 19
                        Stat19H += iValue
                    Case 20
                        Stat20H += iValue
                    Case 21
                        Stat21H += iValue
                    Case 22
                        Stat22H += iValue
                    Case 23
                        Stat23H += iValue
                    Case 24
                        Stat24H += iValue
                    Case 25
                        Stat25H += iValue
                    Case 26
                        Stat26H += iValue
                    Case 27
                        Stat27H += iValue
                    Case 28
                        Stat28H += iValue
                    Case 29
                        Stat29H += iValue
                    Case 30
                        Stat30H += iValue
                End Select
            Case 2
                Select Case iStatNum
                    Case 1
                        Stat01A += iValue
                    Case 2
                        Stat02A += iValue
                    Case 3
                        Stat03A += iValue
                    Case 4
                        Stat04A += iValue
                    Case 5
                        Stat05A += iValue
                    Case 6
                        Stat06A += iValue
                    Case 7
                        Stat07A += iValue
                    Case 8
                        Stat08A += iValue
                    Case 9
                        Stat09A += iValue
                    Case 10
                        Stat10A += iValue
                    Case 11
                        Stat11A += iValue
                    Case 12
                        Stat12A += iValue
                    Case 13
                        Stat13A += iValue
                    Case 14
                        Stat14A += iValue
                    Case 15
                        Stat15A += iValue
                    Case 16
                        Stat16A += iValue
                    Case 17
                        Stat17A += iValue
                    Case 18
                        Stat18A += iValue
                    Case 19
                        Stat19A += iValue
                    Case 20
                        Stat20A += iValue
                    Case 21
                        Stat21A += iValue
                    Case 22
                        Stat22A += iValue
                    Case 23
                        Stat23A += iValue
                    Case 24
                        Stat24A += iValue
                    Case 25
                        Stat25A += iValue
                    Case 26
                        Stat26A += iValue
                    Case 27
                        Stat27A += iValue
                    Case 28
                        Stat28A += iValue
                    Case 29
                        Stat29A += iValue
                    Case 30
                        Stat30A += iValue
                End Select
        End Select
        checklimits()
    End Sub
    Sub ZeroStat(ByVal iTeam As Integer, ByVal iStatNum As Integer)
        Select Case iTeam
            Case 1
                Select Case iStatNum
                    Case 1
                        Stat01H = 0
                    Case 2
                        Stat02H = 0
                    Case 3
                        Stat03H = 0
                    Case 4
                        Stat04H = 0
                    Case 5
                        Stat05H = 0
                    Case 6
                        Stat06H = 0
                    Case 7
                        Stat07H = 0
                    Case 8
                        Stat08H = 0
                    Case 9
                        Stat09H = 0
                    Case 10
                        Stat10H = 0
                    Case 11
                        Stat11H = 0
                    Case 12
                        Stat12H = 0
                    Case 13
                        Stat13H = 0
                    Case 14
                        Stat14H = 0
                    Case 15
                        Stat15H = 0
                    Case 16
                        Stat16H = 0
                    Case 17
                        Stat17H = 0
                    Case 18
                        Stat18H = 0
                    Case 19
                        Stat19H = 0
                    Case 20
                        Stat20H = 0
                    Case 21
                        Stat21H = 0
                    Case 22
                        Stat22H = 0
                    Case 23
                        Stat23H = 0
                    Case 24
                        Stat24H = 0
                    Case 25
                        Stat25H = 0
                    Case 26
                        Stat26H = 0
                    Case 27
                        Stat27H = 0
                    Case 28
                        Stat28H = 0
                    Case 29
                        Stat29H = 0
                    Case 30
                        Stat30H = 0
                End Select
            Case 2
                Select Case iStatNum
                    Case 1
                        Stat01A = 0
                    Case 2
                        Stat02A = 0
                    Case 3
                        Stat03A = 0
                    Case 4
                        Stat04A = 0
                    Case 5
                        Stat05A = 0
                    Case 6
                        Stat06A = 0
                    Case 7
                        Stat07A = 0
                    Case 8
                        Stat08A = 0
                    Case 9
                        Stat09A = 0
                    Case 10
                        Stat10A = 0
                    Case 11
                        Stat11A = 0
                    Case 12
                        Stat12A = 0
                    Case 13
                        Stat13A = 0
                    Case 14
                        Stat14A = 0
                    Case 15
                        Stat15A = 0
                    Case 16
                        Stat16A = 0
                    Case 17
                        Stat17A = 0
                    Case 18
                        Stat18A = 0
                    Case 19
                        Stat19A = 0
                    Case 20
                        Stat20A = 0
                    Case 21
                        Stat21A = 0
                    Case 22
                        Stat22A = 0
                    Case 23
                        Stat23A = 0
                    Case 24
                        Stat24A = 0
                    Case 25
                        Stat25A = 0
                    Case 26
                        Stat26A = 0
                    Case 27
                        Stat27A = 0
                    Case 28
                        Stat28A = 0
                    Case 29
                        Stat29A = 0
                    Case 30
                        Stat30A = 0
                End Select
        End Select
        CheckLimits()
    End Sub
    Sub CheckLimits()
        If Stat01H < 0 Then Stat01H = 0
        If Stat02H < 0 Then Stat02H = 0
        If Stat03H < 0 Then Stat03H = 0
        If Stat04H < 0 Then Stat04H = 0
        If Stat05H < 0 Then Stat05H = 0
        If Stat06H < 0 Then Stat06H = 0
        If Stat07H < 0 Then Stat07H = 0
        If Stat08H < 0 Then Stat08H = 0
        If Stat09H < 0 Then Stat09H = 0
        If Stat10H < 0 Then Stat10H = 0
        If Stat11H < 0 Then Stat11H = 0
        If Stat12H < 0 Then Stat12H = 0
        If Stat13H < 0 Then Stat13H = 0
        If Stat14H < 0 Then Stat14H = 0
        If Stat15H < 0 Then Stat15H = 0
        If Stat16H < 0 Then Stat16H = 0
        If Stat17H < 0 Then Stat17H = 0
        If Stat18H < 0 Then Stat18H = 0
        If Stat19H < 0 Then Stat19H = 0
        If Stat20H < 0 Then Stat20H = 0
        If Stat21H < 0 Then Stat21H = 0
        If Stat22H < 0 Then Stat22H = 0
        If Stat23H < 0 Then Stat23H = 0
        If Stat24H < 0 Then Stat24H = 0
        If Stat25H < 0 Then Stat25H = 0
        If Stat26H < 0 Then Stat26H = 0
        If Stat27H < 0 Then Stat27H = 0
        If Stat28H < 0 Then Stat28H = 0
        If Stat29H < 0 Then Stat29H = 0
        If Stat30H < 0 Then Stat30H = 0

        If Stat01A < 0 Then Stat01A = 0
        If Stat02A < 0 Then Stat02A = 0
        If Stat03A < 0 Then Stat03A = 0
        If Stat04A < 0 Then Stat04A = 0
        If Stat05A < 0 Then Stat05A = 0
        If Stat06A < 0 Then Stat06A = 0
        If Stat07A < 0 Then Stat07A = 0
        If Stat08A < 0 Then Stat08A = 0
        If Stat09A < 0 Then Stat09A = 0
        If Stat10A < 0 Then Stat10A = 0
        If Stat11A < 0 Then Stat11A = 0
        If Stat12A < 0 Then Stat12A = 0
        If Stat13A < 0 Then Stat13A = 0
        If Stat14A < 0 Then Stat14A = 0
        If Stat15A < 0 Then Stat15A = 0
        If Stat16A < 0 Then Stat16A = 0
        If Stat17A < 0 Then Stat17A = 0
        If Stat18A < 0 Then Stat18A = 0
        If Stat19A < 0 Then Stat19A = 0
        If Stat20A < 0 Then Stat20A = 0
        If Stat21A < 0 Then Stat21A = 0
        If Stat22A < 0 Then Stat22A = 0
        If Stat23A < 0 Then Stat23A = 0
        If Stat24A < 0 Then Stat24A = 0
        If Stat25A < 0 Then Stat25A = 0
        If Stat26A < 0 Then Stat26A = 0
        If Stat27A < 0 Then Stat27A = 0
        If Stat28A < 0 Then Stat28A = 0
        If Stat29A < 0 Then Stat29A = 0
        If Stat30A < 0 Then Stat30A = 0

    End Sub


End Class
