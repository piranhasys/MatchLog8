Imports System.Collections.Generic

Public Class clsJSONPlayerStats
    Public Property MatchID As String = ""
    Public playerList As New List(Of clsJSONPlayer)

    Public Sub New()
        _MatchID = ""
        playerList = New List(Of clsJSONPlayer)
    End Sub

End Class
