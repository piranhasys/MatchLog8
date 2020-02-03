Public Class clsPlayerStatSet
    Public PlayerStats() As clsPlayerStat
    Public Sub New()
        Dim tempArray(25) As clsPlayerStat
        For inc As Integer = 0 To 25
            tempArray(inc) = New clsPlayerStat
        Next
        Me.PlayerStats = tempArray
    End Sub
    Public Sub New(ByVal PlayerStats() As clsPlayerStat)
        Me.PlayerStats = PlayerStats
    End Sub
End Class
