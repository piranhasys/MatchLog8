Imports System.Collections.Generic

Public Class clsJSONTeamStats
    Public Property MatchID As String = ""
    Public statList As New List(Of clsJSONTeamStat)

    Public Sub New()
        _MatchID = ""
        statList = New List(Of clsJSONTeamStat)
    End Sub

End Class
