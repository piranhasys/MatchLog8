Imports System.Collections.Generic
'######## not used####################
Public Class clsJSONPlayerStatGroup
    Public Property n As String = ""    'statname
    Public statList As New List(Of clsJSONPlayerStat)

    Public Sub New()
        _n = ""
        statList = New List(Of clsJSONPlayerStat)
    End Sub
    Public Sub New(thisStatname As String)
        _n = thisStatname
        statList = New List(Of clsJSONPlayerStat)
    End Sub

End Class
