Public Class frmSetup
    Public Event SendData(ByVal strData As String)

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnFetchMatches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetchMatches.Click
        dtSelDate = Me.MonthCalendar1.SelectionStart.ToLongDateString
        RaiseEvent SendData("REQUESTMATCHLIST|" & dtSelDate.ToLongDateString)
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        ShowStatus()
    End Sub
    Sub ShowStatus()
        Me.btnFetchMatches.Text = "Fetch Matches for " & Me.MonthCalendar1.SelectionStart.ToLongDateString

    End Sub

    Private Sub frmSetup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub frmSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowData()
        SetEnables()
    End Sub

    Delegate Sub ShowDataCallback()
    Sub ShowData()
        If lablLiveHomeTeam.InvokeRequired Then
            Dim d As New ShowDataCallback(AddressOf ShowData)
            Me.Invoke(d, New Object() {})
        Else

            Dim inc As Integer
            If (iMatchID > -1) And (Config.AllowDeleteData = True) Then
                Me.lablLiveHomeTeam.Text = LiveMatch.HomeShortName
                Me.lablLiveAwayTeam.Text = LiveMatch.AwayShortName
                Me.GroupBox1.Visible = True
            Else
                Me.GroupBox1.Visible = False
            End If
            Dim tempItem As New ListViewItem
            Me.listViewData.Items.Clear()
            If MatchList(1).MatchID <> -1 Then
                'valid
                Me.lablMatchHeading.Text = "Matches for " & MatchList(1).MatchDate.ToLongDateString
                For inc = 1 To MatchList.GetUpperBound(0)
                    tempItem = New ListViewItem
                    tempItem.Text = MatchList(inc).MatchID
                    tempItem.SubItems.Add(MatchList(inc).LeagueName)
                    tempItem.SubItems.Add(MatchList(inc).HomeShortName)
                    tempItem.SubItems.Add(MatchList(inc).AwayShortName)
                    Me.listViewData.Items.Add(tempItem)
                Next
            Else
                Me.lablMatchHeading.Text = ""
            End If
            SetEnables()
        End If
    End Sub
    Sub SetEnables()
        If Me.listViewData.SelectedItems.Count > 0 Then
            Dim strText As String = Me.listViewData.SelectedItems(0).SubItems(2).Text & " v " & Me.listViewData.SelectedItems(0).SubItems(3).Text
            Me.btnFetchMatch.Enabled = True
            Me.btnFetchMatch.Text = "Fetch Match Details for " & strText
        Else
            Me.btnFetchMatch.Enabled = False
            Me.btnFetchMatch.Text = "Fetch Match Details"
        End If
    End Sub
    Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ShowData()
    End Sub

    Private Sub listViewData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listViewData.SelectedIndexChanged
        SetEnables()
    End Sub

    Private Sub btnFetchMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetchMatch.Click
        If MessageBox.Show("This will clear all existing data in MatchLog." & vbLf & "Are you sure you want to continue?", "Request new match", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            iMatchID = Val(Me.listViewData.SelectedItems(0).Text)  'hold to compare incoming broadcast data
            RaiseEvent SendData("REQUESTMATCHDETAILS|" & iMatchID.ToString)
        End If

    End Sub

    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        Dim strText As String = LiveMatch.HomeShortName & " v " & LiveMatch.AwayShortName
        If MessageBox.Show("Clearing data will permanently delete ALL stats and possession data for this match from the ENTIRE SYSTEM." & vbLf & vbLf & "This is normally used after testing/rehearsal only." & vbLf & vbLf & "Are you sure you want to delete data?", "Clear all data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If MessageBox.Show("This will clear all existing data for " & strText & vbLf & "Are you sure you want to continue?", "Clear all data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                RaiseEvent SendData("MATCHLOG|CLEARALLDATA|" & iMatchID.ToString)
            End If
        End If
    End Sub
End Class