Imports System.Collections.Generic

Public Class clsPlayerSync
    Public Property Number As String = ""
    Public Property Name As String = ""
    Public Property StatList As New List(Of Integer)

    Public Sub New()
        _Number = ""
        _Name = ""
        _StatList = New List(Of Integer)
    End Sub
End Class
