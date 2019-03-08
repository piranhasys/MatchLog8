Imports System.Collections.Generic

Public Class clsJSONPlayerStat
    Public Property n As String = ""    'stat
    Public Property v As String = ""

    Public Sub New()
        _n = ""
        _v = ""
    End Sub
    Public Sub New(thisStatName As String)
        _n = thisStatName
        _v = ""
    End Sub
End Class
