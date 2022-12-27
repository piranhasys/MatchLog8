Public Class clsPlayerStatSet
    Public PlayerStats() As clsPlayerStat
    Public Sub New()
    End Sub
    Public Sub New(ByVal PlayerStats() As clsPlayerStat)
        Me.PlayerStats = PlayerStats
    End Sub
End Class
