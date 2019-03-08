Module Module1
    Public Config As New clsConfig
    Public MatchList() As clsMatch
    Public LiveMatch As New clsMatch
    Public MatchClock() As clsClock
    Public MatchPossession() As clsPossession
    Public iCurrentPeriod As Integer = 0
    Public Utils As New clsUtils
    Public formSetup As New frmSetup
    Public strTeamStatName(42) As String    'for compatibility with RB stats file. Also change in InitClasses
    Public strTeamStatJSONName(42) As String    'for compatibility with RB stats file. Also change in InitClasses
    Public strRBTeamStatJSONName(42) As String    'for compatibility with RB stats file. Also change in InitClasses
    Public strPlayerStatName(30) As String
    Public strPlayerStatJSONName(30) As String
    Public strRBPlayerStatJSONName(30) As String
    Public strPenaltyName(30) As String
    Public PlayerStat(2, 25) As clsPlayerStat
    Public iCurrentPlayer As Integer = 1
    Public iCurrentPlayerTeam As Integer = 1
    Public iCurrentPlayerStat As Integer = 1
    Public iCurrentTeam As Integer = 1
    Public iCurrentTeamStat As Integer = 1
    Public iMatchID As Integer = -1
    Public dtSelDate As Date = Now
    Public bFormLocked As Boolean = False
    Public RemoteData As New clsRemoteData
    Public PitchKickouts() As clsPitchLocationLog
    Public PitchFrees() As clsPitchLocationLog
    Public Pitch4565() As clsPitchLocationLog
    Public JSONTeamStats As New clsJSONTeamStats
    Public JSONPlayerStats As New clsJSONPlayerStats

    Enum PitchLogType As Integer
        Kickouts = 1
        Frees = 2
        FortyFive_SixtyFive = 3
    End Enum
    Enum ScoreType As Integer
        SoccerGoal = 0
        RugbyTry = 1
        RugbyConversion = 2
        RugbyDropGoal = 3
        RugbyPenalty = 4
    End Enum
    Enum SportType As Integer
        Undefined = 0
        Soccer = 1
        GAAFootball = 2
        GAAHurling = 3
        GAAInternational = 4
        Rugby = 5
        Hockey = 6
    End Enum
End Module
