Imports System.Collections.Generic

Public Class clsPlayerSync
    Public Property PlayerID As Integer = 0
    Public Property Number As String = ""
    Public Property Name As String = ""
    Public Property ShortName As String = ""
    Public Property StatList As New List(Of Integer)

    Public Sub New()
        _PlayerID = 0
        _Number = ""
        _Name = ""
        _ShortName = ""
        _StatList = New List(Of Integer)
    End Sub
End Class
