Public Class clsPossession

    Private tsHome As TimeSpan = Now.Subtract(Now)
    Private tsAway As TimeSpan = Now.Subtract(Now)
    Private tsOOP As TimeSpan = Now.Subtract(Now)
    Private iCurrentPossession As Integer = -1
    Private iCurrentArea As Integer = -1
    Private tsLastHome As TimeSpan = Now.Subtract(Now)
    Private tsLastAway As TimeSpan = Now.Subtract(Now)
    Private tsLastOOP As TimeSpan = Now.Subtract(Now)
    Private dtLastPossessionChange As DateTime = Now
    Private dtLastAreaChange As DateTime = Now

    Private tsArea1 As TimeSpan = Now.Subtract(Now)
    Private tsArea2 As TimeSpan = Now.Subtract(Now)
    Private tsArea3 As TimeSpan = Now.Subtract(Now)
    Private tsArea4 As TimeSpan = Now.Subtract(Now)
    Private tsArea0 As TimeSpan = Now.Subtract(Now)
    Private tsLastArea1 As TimeSpan = Now.Subtract(Now)
    Private tsLastArea2 As TimeSpan = Now.Subtract(Now)
    Private tsLastArea3 As TimeSpan = Now.Subtract(Now)
    Private tsLastArea4 As TimeSpan = Now.Subtract(Now)
    Private tsLastArea0 As TimeSpan = Now.Subtract(Now)

    Private colNormal As Color = Color.White
    Private colHighight As Color = Color.Yellow

    Public Property Area0() As TimeSpan
        Get
            Return tsArea0
        End Get
        Set(ByVal value As TimeSpan)
            tsArea0 = value
        End Set
    End Property

    Public Property Area4() As TimeSpan
        Get
            Return tsArea4
        End Get
        Set(ByVal value As TimeSpan)
            tsArea4 = value
        End Set
    End Property

    Public Property Area3() As TimeSpan
        Get
            Return tsArea3
        End Get
        Set(ByVal value As TimeSpan)
            tsArea3 = value
        End Set
    End Property


    Public Property Area2() As TimeSpan
        Get
            Return tsArea2
        End Get
        Set(ByVal value As TimeSpan)
            tsArea2 = value
        End Set
    End Property


    Public Property Area1() As TimeSpan
        Get
            Return tsArea1
        End Get
        Set(ByVal value As TimeSpan)
            tsArea1 = value
        End Set
    End Property


    'Private iHome As Integer = 0
    'Private iAway As Integer = 0
    'Private iOOP As Integer = 0
    'Private iLastHome As Integer = 0
    'Private iLastAway As Integer = 0
    'Private iLastOOP As Integer = 0
    'Public Property Home() As Integer
    '    Get
    '        Return iHome
    '    End Get
    '    Set(ByVal value As Integer)
    '        iHome = value
    '    End Set
    'End Property

    'Public Property Away() As Integer
    '    Get
    '        Return iAway
    '    End Get
    '    Set(ByVal value As Integer)
    '        iAway = value
    '    End Set
    'End Property

    'Public Property OOP() As Integer
    '    Get
    '        Return iOOP
    '    End Get
    '    Set(ByVal value As Integer)
    '        iOOP = value
    '    End Set
    'End Property
    ReadOnly Property HomePercent() As Integer
        Get
            Dim iTotalSecs As Integer = Int(tsHome.TotalSeconds + tsAway.TotalSeconds)
            If iTotalSecs = 0 Then
                Return 0
            Else
                Return Int((Int(tsHome.TotalSeconds) / iTotalSecs) * 100)
            End If
        End Get
    End Property
    ReadOnly Property HomeText() As String
        Get
            If Int(tsHome.TotalSeconds + tsAway.TotalSeconds) = 0 Then
                Return ""
            Else
                Return HomePercent.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property AwayText() As String
        Get
            If Int(tsHome.TotalSeconds + tsAway.TotalSeconds) = 0 Then
                Return ""
            Else
                Return (100 - HomePercent).ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property TotalSecs() As Integer
        Get
            Dim iTotalSecs As Integer
            Select Case Config.NumberOfAreas
                Case 4
                    iTotalSecs = Int(tsArea1.TotalSeconds + tsArea2.TotalSeconds + tsArea3.TotalSeconds + tsArea4.TotalSeconds)
                Case Else
                    iTotalSecs = Int(tsArea1.TotalSeconds + tsArea2.TotalSeconds + tsArea3.TotalSeconds)
            End Select
            Return iTotalSecs
        End Get
    End Property
    ReadOnly Property Area1Text() As String
        Get
            If TotalSecs = 0 Then
                Return ""
            Else
                Return Area1Percent.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property Area2Text() As String
        Get
            If TotalSecs = 0 Then
                Return ""
            Else
                Return Area2Percent.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property Area3Text() As String
        Get
            If TotalSecs = 0 Then
                Return ""
            Else
                Return Area3Percent.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property Area4Text() As String
        Get
            If TotalSecs = 0 Then
                Return ""
            Else
                Return Area4Percent.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property Area1Percent() As Integer
        Get
            If TotalSecs = 0 Then
                Return 0
            Else
                Return Int((Int(tsArea1.TotalSeconds) / TotalSecs) * 100)
            End If
        End Get
    End Property
    ReadOnly Property Area2Percent() As Integer
        Get
            If TotalSecs = 0 Then
                Return 0
            Else
                Return Int((Int(tsArea2.TotalSeconds) / TotalSecs) * 100)
            End If
        End Get
    End Property
    ReadOnly Property Area3Percent() As Integer
        Get
            Select Case Config.NumberOfAreas
                Case 4
                    If TotalSecs = 0 Then
                        Return 0
                    Else
                        Return Int((Int(tsArea3.TotalSeconds) / TotalSecs) * 100)
                    End If
                Case Else
                    Return 100 - (Area1Percent + Area2Percent)
            End Select
        End Get
    End Property
    ReadOnly Property Area4Percent() As Integer
        Get
            Select Case Config.NumberOfAreas
                Case 4
                    If TotalSecs = 0 Then
                        Return 0
                    Else
                        Return 100 - (Area1Percent + Area2Percent + Area3Percent)
                    End If
                Case Else
                    Return 0
            End Select
        End Get
    End Property

    ReadOnly Property InPlayText() As String
        Get
            Dim iSecs As Integer = Int(tsHome.TotalSeconds + tsAway.TotalSeconds)
            Return Format(Int(iSecs / 60), "00") & ":" & Format((iSecs Mod 60), "00")
        End Get
    End Property
    Public Property LastPossessionChange() As DateTime
        Get
            Return dtLastPossessionChange
        End Get
        Set(ByVal value As DateTime)
            dtLastPossessionChange = value
        End Set
    End Property
    Public Property LastAreaChange() As DateTime
        Get
            Return dtLastAreaChange
        End Get
        Set(ByVal value As DateTime)
            dtLastAreaChange = value
        End Set
    End Property

    Sub AllocatePossession()
        Dim tsDuration As TimeSpan = Now.Subtract(dtLastPossessionChange)
        Select Case iCurrentPossession
            Case 1
                tsHome = tsLastHome.Add(tsDuration)
                tsLastHome = tsHome
            Case 2
                tsAway = tsLastAway.Add(tsDuration)
                tsLastAway = tsAway
            Case 0
                tsOOP = tsLastOOP.Add(tsDuration)
                tsLastOOP = tsOOP
        End Select
        dtLastPossessionChange = Now
    End Sub
    Sub CalcPossessions()
        Dim tsDuration As TimeSpan = Now.Subtract(LastPossessionChange)
        Select Case iCurrentPossession
            Case 1
                tsHome = tsLastHome.Add(tsDuration)
            Case 2
                tsAway = tsLastAway.Add(tsDuration)
            Case 0
                tsOOP = tsLastOOP.Add(tsDuration)
        End Select
    End Sub
    Sub AllocateArea()
        Dim tsDuration As TimeSpan = Now.Subtract(dtLastAreaChange)
        Select Case iCurrentArea
            Case 1
                tsArea1 = tsLastArea1.Add(tsDuration)
                tsLastArea1 = tsArea1
            Case 2
                tsArea2 = tsLastArea2.Add(tsDuration)
                tsLastArea2 = tsArea2
            Case 3
                tsArea3 = tsLastArea3.Add(tsDuration)
                tsLastArea3 = tsArea3
            Case 4
                tsArea4 = tsLastArea4.Add(tsDuration)
                tsLastArea4 = tsArea4
            Case 0
                tsArea0 = tsLastArea0.Add(tsDuration)
                tsLastArea0 = tsArea0
        End Select
        dtLastAreaChange = Now
    End Sub
    Sub CalcAreas()
        Dim tsDuration As TimeSpan = Now.Subtract(LastAreaChange)
        Select Case iCurrentArea
            Case 1
                tsArea1 = tsLastArea1.Add(tsDuration)
            Case 2
                tsArea2 = tsLastArea2.Add(tsDuration)
            Case 3
                tsArea3 = tsLastArea3.Add(tsDuration)
            Case 4
                tsArea4 = tsLastArea4.Add(tsDuration)
            Case 0
                tsArea0 = tsLastArea0.Add(tsDuration)
        End Select
    End Sub
    Sub Reset()
        tsHome = Now.Subtract(Now)
        tsAway = Now.Subtract(Now)
        tsOOP = Now.Subtract(Now)
        tsLastHome = Now.Subtract(Now)
        tsLastAway = Now.Subtract(Now)
        tsLastOOP = Now.Subtract(Now)

        tsArea0 = Now.Subtract(Now)
        tsArea1 = Now.Subtract(Now)
        tsArea2 = Now.Subtract(Now)
        tsArea3 = Now.Subtract(Now)
        tsArea4 = Now.Subtract(Now)
        tsLastArea0 = Now.Subtract(Now)
        tsLastArea1 = Now.Subtract(Now)
        tsLastArea2 = Now.Subtract(Now)
        tsLastArea3 = Now.Subtract(Now)
        tsLastArea4 = Now.Subtract(Now)


        iCurrentPossession = 0
        iCurrentArea = 0
        dtLastPossessionChange = Now
        dtLastAreaChange = Now
    End Sub
    Sub Pause()
        AllocateArea()
        AllocatePossession()
        iCurrentPossession = 0
        iCurrentArea = 0
        dtLastPossessionChange = Now
        dtLastAreaChange = Now
    End Sub

    Public Property CurrentPossession() As Integer
        Get
            Return iCurrentPossession
        End Get
        Set(ByVal value As Integer)
            iCurrentPossession = value
        End Set
    End Property
    Public Property CurrentArea() As Integer
        Get
            Return iCurrentArea
        End Get
        Set(ByVal value As Integer)
            iCurrentArea = value
        End Set
    End Property
    Public Property OOP() As TimeSpan
        Get
            Return tsOOP
        End Get
        Set(ByVal value As TimeSpan)
            tsOOP = value
        End Set
    End Property

    Public Property Home() As TimeSpan
        Get
            Return tsHome
        End Get
        Set(ByVal value As TimeSpan)
            tsHome = value
        End Set
    End Property

    Public Property Away() As TimeSpan
        Get
            Return tsAway
        End Get
        Set(ByVal value As TimeSpan)
            tsAway = value
        End Set
    End Property

    ReadOnly Property Area1Colour() As Color
        Get
            If iCurrentArea = 1 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property
    ReadOnly Property Area2Colour() As Color
        Get
            If iCurrentArea = 2 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property
    ReadOnly Property Area3Colour() As Color
        Get
            If iCurrentArea = 3 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property
    ReadOnly Property Area4Colour() As Color
        Get
            If iCurrentArea = 4 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property
    ReadOnly Property PossessionHColour() As Color
        Get
            If iCurrentPossession = 1 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property
    ReadOnly Property PossessionAColour() As Color
        Get
            If iCurrentPossession = 2 Then
                Return colHighight
            Else
                Return colNormal
            End If
        End Get
    End Property

End Class
