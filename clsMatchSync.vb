Imports System.Collections.Generic

Public Class clsMatchSync

    Public Property MatchID As Integer = 0
    Public Property HomeTeamID As Integer = 0
    Public Property AwayTeamID As Integer = 0
    Public Property HomeShortName As String = ""
    Public Property HomeLongName As String = ""
    Public Property HomeScore As String = ""
    Public Property HomePossession As String = ""
    Public Property AwayShortName As String = ""
    Public Property AwayLongName As String = ""
    Public Property AwayScore As String = ""
    Public Property AwayPossession As String = ""
    Public Property Period As Integer = 0
    Public Property PossessionTeam As Integer = 0
    Public Property TeamStatNameList As New List(Of String)
    Public Property PlayerStatNameList As New List(Of String)
    Public Property HomeTeamStatList As New List(Of Integer)
    Public Property AwayTeamStatList As New List(Of Integer)
    Public Property HomePlayerList As New List(Of clsPlayerSync)
    Public Property AwayPlayerList As New List(Of clsPlayerSync)


    Public Sub New()
        _MatchID = 0
        _HomeTeamID = 0
        _AwayTeamID = 0
        _HomeShortName = ""
        _HomeLongName = ""
        _HomeScore = ""
        _HomePossession = "0%"
        _AwayShortName = ""
        _AwayLongName = ""
        _AwayScore = ""
        _AwayPossession = "0%"
        _Period = 0
        _PossessionTeam = 0
        _TeamStatNameList = New List(Of String)
        _PlayerStatNameList = New List(Of String)
        _HomeTeamStatList = New List(Of Integer)
        _AwayTeamStatList = New List(Of Integer)
        _HomePlayerList = New List(Of clsPlayerSync)
        _AwayPlayerList = New List(Of clsPlayerSync)
    End Sub

End Class
