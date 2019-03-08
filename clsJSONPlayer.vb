Imports System.Collections.Generic
Public Class clsJSONPlayer
    Public Property t As String = ""    'team
    Public Property s As String = ""    'shirt
    Public statList As New List(Of clsJSONPlayerStat)

    Public Sub New()
        _t = ""
        _s = ""
        statList = New List(Of clsJSONPlayerStat)
    End Sub
    Public Sub New(thisTeamIndex As Integer, thisShirt As String)
        _t = thisTeamIndex.ToString
        _s = thisShirt
        statList = New List(Of clsJSONPlayerStat)
    End Sub
End Class
