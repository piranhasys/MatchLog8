Public Class clsJSONTeamStat
    Public Property n As String = ""
    Public Property h As String = ""
    Public Property a As String = ""

    Public Sub New()
        _n = ""
        _h = ""
        _a = ""
    End Sub
    Public Sub New(thisStatname As String)
        _n = thisStatname
        _h = ""
        _a = ""
    End Sub
End Class
