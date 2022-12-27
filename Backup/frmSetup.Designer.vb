<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnFetchMatches = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.listViewData = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.btnFetchMatch = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.lablMatchHeading = New System.Windows.Forms.Label
        Me.btnClearData = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lablLiveHomeTeam = New System.Windows.Forms.Label
        Me.lablLiveAwayTeam = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(816, 500)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFetchMatches
        '
        Me.btnFetchMatches.Location = New System.Drawing.Point(8, 196)
        Me.btnFetchMatches.Name = "btnFetchMatches"
        Me.btnFetchMatches.Size = New System.Drawing.Size(220, 40)
        Me.btnFetchMatches.TabIndex = 1
        Me.btnFetchMatches.Text = "Fetch Matches"
        Me.btnFetchMatches.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 8)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'listViewData
        '
        Me.listViewData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listViewData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewData.FullRowSelect = True
        Me.listViewData.GridLines = True
        Me.listViewData.Location = New System.Drawing.Point(248, 36)
        Me.listViewData.MultiSelect = False
        Me.listViewData.Name = "listViewData"
        Me.listViewData.Size = New System.Drawing.Size(668, 400)
        Me.listViewData.TabIndex = 3
        Me.listViewData.UseCompatibleStateImageBehavior = False
        Me.listViewData.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "League"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Home"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Away"
        Me.ColumnHeader4.Width = 200
        '
        'btnFetchMatch
        '
        Me.btnFetchMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchMatch.Location = New System.Drawing.Point(248, 444)
        Me.btnFetchMatch.Name = "btnFetchMatch"
        Me.btnFetchMatch.Size = New System.Drawing.Size(668, 40)
        Me.btnFetchMatch.TabIndex = 4
        Me.btnFetchMatch.Text = "Fetch Match Details for Spurs v Arsenal"
        Me.btnFetchMatch.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(24, 548)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(76, 28)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh Match List"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'lablMatchHeading
        '
        Me.lablMatchHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablMatchHeading.Location = New System.Drawing.Point(252, 8)
        Me.lablMatchHeading.Name = "lablMatchHeading"
        Me.lablMatchHeading.Size = New System.Drawing.Size(660, 28)
        Me.lablMatchHeading.TabIndex = 6
        Me.lablMatchHeading.Text = "Matches"
        Me.lablMatchHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearData
        '
        Me.btnClearData.Location = New System.Drawing.Point(20, 96)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(180, 40)
        Me.btnClearData.TabIndex = 7
        Me.btnClearData.Text = "Clear Data"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lablLiveAwayTeam)
        Me.GroupBox1.Controls.Add(Me.lablLiveHomeTeam)
        Me.GroupBox1.Controls.Add(Me.btnClearData)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 148)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Match"
        '
        'lablLiveHomeTeam
        '
        Me.lablLiveHomeTeam.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lablLiveHomeTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lablLiveHomeTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablLiveHomeTeam.Location = New System.Drawing.Point(8, 24)
        Me.lablLiveHomeTeam.Name = "lablLiveHomeTeam"
        Me.lablLiveHomeTeam.Size = New System.Drawing.Size(204, 20)
        Me.lablLiveHomeTeam.TabIndex = 9
        Me.lablLiveHomeTeam.Text = "Home Team"
        Me.lablLiveHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablLiveAwayTeam
        '
        Me.lablLiveAwayTeam.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lablLiveAwayTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lablLiveAwayTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablLiveAwayTeam.Location = New System.Drawing.Point(8, 68)
        Me.lablLiveAwayTeam.Name = "lablLiveAwayTeam"
        Me.lablLiveAwayTeam.Size = New System.Drawing.Size(204, 20)
        Me.lablLiveAwayTeam.TabIndex = 10
        Me.lablLiveAwayTeam.Text = "Away Team"
        Me.lablLiveAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "v"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSetup
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(936, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lablMatchHeading)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnFetchMatch)
        Me.Controls.Add(Me.listViewData)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnFetchMatches)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSetup"
        Me.Text = "Setup Match"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnFetchMatches As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents listViewData As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnFetchMatch As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lablMatchHeading As System.Windows.Forms.Label
    Friend WithEvents btnClearData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lablLiveAwayTeam As System.Windows.Forms.Label
    Friend WithEvents lablLiveHomeTeam As System.Windows.Forms.Label
End Class
