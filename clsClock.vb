Imports System.Net.Sockets
Imports System.Text
Public Class clsClock
    Private bRunning As Boolean = False
    Private strStaticClock As String = "00:00"
    Private dtElapsed As TimeSpan
    Private dtStartTime As Date = Now
    Private iLoadMins As Integer = 0
    Private iLoadSecs As Integer = 0
    Private strIPAddress As String = "255.255.255.255"
    Private iPort As Integer = 53100
    Private iPresetMins As Integer = 0
    Private iPresetSecs As Integer = 0
    Private strRemoteTime1 As String = ""
    Private strRemoteTime2 As String = ""
    Private dtDiff As TimeSpan = Now.Subtract(Now)
    Private iPeriodDurationCurrent As Integer = 0

    Public Property PeriodDurationCurrent() As Integer
        Get
            Return iPeriodDurationCurrent
        End Get
        Set(ByVal value As Integer)
            iPeriodDurationCurrent = value
        End Set
    End Property

    Property RemoteTime1() As String
        Get
            Return strRemoteTime1
        End Get
        Set(ByVal Value As String)
            strRemoteTime1 = Value
        End Set
    End Property
    Property RemoteTime2() As String
        Get
            Return strRemoteTime2
        End Get
        Set(ByVal Value As String)
            strRemoteTime2 = Value
        End Set
    End Property


    Property Running() As Boolean
        Get
            Return bRunning
        End Get
        Set(ByVal Value As Boolean)
            bRunning = Value
        End Set
    End Property
    ReadOnly Property MatchClock() As String
        Get
            dtDiff = Now.Subtract(dtStartTime.AddSeconds(-iPresetSecs).AddMinutes(-iPresetMins))
            If bRunning = True Then
                Return Format((dtDiff.Minutes + (dtDiff.Hours * 60)), "00") & ":" & Format(dtDiff.Seconds, "00")
            Else
                Return strStaticClock
            End If
            'Return Right(Now.ToLongTimeString, 5)
        End Get
    End Property
    ReadOnly Property TotalMatchClock() As String
        Get
            Dim periodMins As Integer = Val(MatchClock.Substring(0, 2))
            Dim periodSecs As String = MatchClock.Substring(3, 2)
            Dim totalMins As Integer = periodMins
            Select Case iCurrentPeriod
                Case 1, 2
                    '1st half
                Case 3, 4
                    '2nd half
                    totalMins = periodMins + Config.PeriodDurationNormal
                Case 5, 6
                    'ET 1st Half
                    totalMins = periodMins + (Config.PeriodDurationNormal * 2)
                Case 7, 8
                    'ET 2nd half
                    totalMins = periodMins + (Config.PeriodDurationNormal * 2) + Config.PeriodDurationExtra
            End Select
            Return Format(totalMins, "00") & ":" & periodSecs
        End Get
    End Property

    ReadOnly Property MatchGoalMin() As Integer
        Get
            Dim strSplit() As String
            strSplit = MatchClock.Split(":")
            Return Val(strSplit(0)) + 1
        End Get
    End Property
    Sub ReadData()
        'dtStartTime = Format(GetSetting("ReportBuilder", "Clock", "StartTime", "00:00:00"), "Short Time")

    End Sub
    Sub NudgeUp()
        dtStartTime = dtStartTime.AddSeconds(-1)
    End Sub
    Sub NudgeDown()
        dtStartTime = dtStartTime.AddSeconds(1)
    End Sub
    Property StartTime() As Date
        Get
            Return dtStartTime
        End Get
        Set(ByVal Value As Date)
            dtStartTime = Value
        End Set
    End Property
    Property LoadMins() As Integer
        Get
            Return iLoadMins
        End Get
        Set(ByVal Value As Integer)
            iLoadMins = Value
        End Set
    End Property
    Property LoadSecs() As Integer
        Get
            Return iLoadSecs
        End Get
        Set(ByVal Value As Integer)
            iLoadSecs = Value
        End Set
    End Property

    ReadOnly Property TotalLoadSeconds() As Integer
        Get
            Return ((iLoadMins * 60) + iLoadSecs)
        End Get
    End Property

    ReadOnly Property LoadValueText() As String
        Get
            Return Format(iLoadMins, "00") & ":" & Format(LoadSecs, "00")
        End Get
    End Property
    ReadOnly Property InAddedTime() As Boolean
        Get
            'Relies on MatchClock to calc prior to call
            If dtDiff.TotalSeconds > (iperioddurationCurrent * 60) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    ReadOnly Property Colour() As Color
        Get
            If bRunning = True Then
                'If InAddedTime = True Then
                '    Return Color.DarkOrange
                'Else
                Return Color.Green
                'End If
            Else
                Return Color.Red
            End If
        End Get
    End Property
    Function Reset() As String
        dtStartTime = Now
        dtElapsed = Now.Subtract(Now)
        iPresetMins = iLoadMins
        iPresetSecs = iLoadSecs
        strStaticClock = LoadValueText
        bRunning = False
        'Select Case LiveGraphics.Driver
        '    Case DriverType.Clarity
        '        'Clarity.TriggerAnimationChar(1, "R")
        '    Case DriverType.Aston7
        '        Datapool.SetControl(10, TotalLoadSeconds.ToString)
        '        Datapool.SetAddedTimeLogo(False) 'will get updated by timer
        '    Case DriverType.Red
        '        Ethos.ClockSet(iPresetMins, iPresetSecs)
        '        Datapool.SetAddedTimeLogo(False) 'will get updated by timer
        '    Case Else

        'End Select
        Return ""
        'Return LiveGraphics.FireTrigger(Trigger.ClockReset)
    End Function
    Function Pause() As String
        'Select Case Config.UserName
        '    Case "WEMBLEY", "PITCH"
        '        Clarity.TriggerAnimationChar(1, "S")
        '    Case Else
        '        Datapool.FireTrigger(12)
        'End Select
        'Select Case Config.UserName
        '    Case "WEMBLEY", "PITCH"
        '        'toggle
        '        strStaticClock = MatchClock
        '        bRunning = Not (bRunning)
        '    Case Else
        '        'stop
        strStaticClock = MatchClock
        bRunning = False
        'End Select
        If bRunning = False Then
            dtElapsed = Now.Subtract(dtStartTime.AddSeconds(-iPresetSecs).AddMinutes(-iPresetMins))
        Else
            'assign new start time
            dtStartTime = Now.Subtract(dtElapsed).AddSeconds(iPresetSecs).AddMinutes(iPresetMins)
        End If
        Return ""
        '        Return LiveGraphics.FireTrigger(Trigger.ClockStartStop)
    End Function
    Function Run() As String
        Select Case Config.UserName
            Case "WEMBLEY", "PITCH"
                dtStartTime = Now
                iPresetMins = iLoadMins
                iPresetSecs = iLoadSecs
                bRunning = True
                'strText = LiveGraphics.FireTrigger(Trigger.ClockReset)
                'strText += ", " & LiveGraphics.FireTrigger(Trigger.ClockStartStop)
                'Return strText
                'Clarity.TriggerAnimationChar(1, "R")
                'Clarity.TriggerAnimationChar(1, "S")
            Case Else
                'start from pause or start from start
                '                dtStartTime = Now.Subtract(dtElapsed).AddSeconds(iPresetSecs).AddMinutes(iPresetMins)
                dtStartTime = Now.Subtract(dtElapsed)
                bRunning = True
                'Return LiveGraphics.FireTrigger(Trigger.ClockRunFromStart)
        End Select
        Return ""
    End Function
    Sub SendStart()
        SendData("CLOCK|START|")
    End Sub
    Sub SendStop()
        SendData("CLOCK|STOP|")
    End Sub
    Sub SendSetTime(ByVal iSecs As Integer)
        SendData("CLOCK|SETTIME|" & iSecs.ToString & "|")
    End Sub
    Sub SendResetAndStart(ByVal iSecs As Integer)
        SendData("CLOCK|STARTFROM|" & iSecs.ToString & "|")
    End Sub
    Sub SendStyle(ByVal iStyle As Integer)
        SendData("CLOCK|GRAPHIC|" & iStyle.ToString & "|")
    End Sub

    Private Sub SendData(ByVal strText As String)
        If strIPAddress = "" Then Exit Sub
        Try
            Dim udpClient As New UdpClient(iPort)
            udpClient.Connect(strIPAddress, iPort)
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(strText)
            udpClient.Send(sendBytes, sendBytes.Length)
            udpClient.Close()
        Catch e As Exception
            MessageBox.Show(e.ToString, "Error in Clock.SendData")
        End Try
    End Sub
End Class
