Public Class clsConfig
    Private strUserName As String = "TURF TV"
    Private strServerAddress As String = "LocalHost"
    Private iServerPort As Integer = 10000
    Private strLocalIPAddress As String = "Localhost"
    Private strPCName As String = "RED ONE"
    Private iSportType As Integer = 0
    'Public StatName01 As String = "Stat 01"
    'Public StatName02 As String = "Stat 02"
    'Public StatName03 As String = "Stat 03"
    'Public StatName04 As String = "Stat 04"
    'Public StatName05 As String = "Stat 05"
    'Public StatName06 As String = "Stat 06"
    'Public StatName07 As String = "Stat 07"
    'Public StatName08 As String = "Stat 08"
    'Public StatName09 As String = "Stat 09"
    'Public StatName10 As String = "Stat 10"
    'Public StatName11 As String = "Stat 10"
    'Public StatName12 As String = "Stat 12"
    'Public StatName13 As String = "Stat 13"
    'Public StatName14 As String = "Stat 14"
    'Public StatName15 As String = "Stat 15"
    'Public StatName16 As String = "Stat 16"
    'Public StatName17 As String = "Stat 17"
    'Public StatName18 As String = "Stat 18"
    'Public StatName19 As String = "Stat 19"
    'Public StatName20 As String = "Stat 20"
    'Public StatName21 As String = "Stat 21"
    'Public StatName22 As String = "Stat 22"
    'Public StatName23 As String = "Stat 23"
    'Public StatName24 As String = "Stat 24"
    'Public StatName25 As String = "Stat 25"
    'Public StatName26 As String = "Stat 26"
    'Public StatName27 As String = "Stat 27"
    'Public StatName28 As String = "Stat 28"
    'Public StatName29 As String = "Stat 29"
    'Public StatName30 As String = "Stat 30"

    Private bLogPossession As Boolean = False
    Private strStatnamesFilename As String = "Statnames.txt"
    Private strConfigFilename As String = "Config.ini"
    Private bAllowDeleteData As Boolean = True
    Private bAutoConnectToSportServer As Boolean = True
    Private iNumberOfAreas As Integer = 3


    Private iPeriodDurationNormal As Integer = 40
    Private iPeriodDurationExtra As Integer = 15
    Public Property PeriodDurationExtra() As Integer
        Get
            Return iPeriodDurationExtra
        End Get
        Set(ByVal value As Integer)
            iPeriodDurationExtra = value
        End Set
    End Property


    Public Property PeriodDurationNormal() As Integer
        Get
            Return iPeriodDurationNormal
        End Get
        Set(ByVal value As Integer)
            iPeriodDurationNormal = value
        End Set
    End Property


    Public Property NumberOfAreas() As Integer
        Get
            Return iNumberOfAreas
        End Get
        Set(ByVal value As Integer)
            iNumberOfAreas = value
        End Set
    End Property


    Public Property AutoConectToSportServer() As Boolean
        Get
            Return bAutoConnectToSportServer
        End Get
        Set(ByVal value As Boolean)
            bAutoConnectToSportServer = value
        End Set
    End Property


    Public Property AllowDeleteData() As Boolean
        Get
            Return bAllowDeleteData
        End Get
        Set(ByVal value As Boolean)
            bAllowDeleteData = value
        End Set
    End Property


    Public Property ConfigFilename() As String
        Get
            Return strConfigFilename
        End Get
        Set(ByVal value As String)
            strConfigFilename = value
        End Set
    End Property

    Public Property StatnamesFilename() As String
        Get
            Return strStatnamesFilename
        End Get
        Set(ByVal value As String)
            strStatnamesFilename = value
        End Set
    End Property


    Public Property LogPossession() As Boolean
        Get
            Return bLogPossession
        End Get
        Set(ByVal value As Boolean)
            bLogPossession = value
        End Set
    End Property



    Public Property LocalIPAddress() As String
        Get
            Return strLocalIPAddress
        End Get
        Set(ByVal value As String)
            strLocalIPAddress = value
        End Set
    End Property
    Public Property PCName() As String
        Get
            Return strPCName
        End Get
        Set(ByVal value As String)
            strPCName = value
        End Set
    End Property

    Public Property SportType() As Integer
        Get
            Return iSportType
        End Get
        Set(ByVal value As Integer)
            iSportType = value
        End Set
    End Property

    Property ServerPort() As Integer
        Get
            Return iServerPort
        End Get
        Set(ByVal Value As Integer)
            iServerPort = Value
        End Set
    End Property
    Property UserName() As String
        Get
            Return strUserName
        End Get
        Set(ByVal Value As String)
            strUserName = Value
        End Set
    End Property
    Property ServerAddress() As String
        Get
            Return strServerAddress
        End Get
        Set(ByVal Value As String)
            strServerAddress = Value
        End Set
    End Property

    Sub ReadSetup()
        Dim strTextLine As String, strFilename As String
        Dim inputFile As System.IO.StreamReader
        Dim TempArray() As String
        Try
            strFilename = strConfigFilename
            If Not System.IO.File.Exists(strFilename) Then
                MessageBox.Show("No Config File: " & strConfigFilename & vbLf & "MatchLog cannot continue")
                End
                Exit Sub
            Else
                inputFile = System.IO.File.OpenText(strFilename)
                Do
                    strTextLine = inputFile.ReadLine
                    If strTextLine Is Nothing Then
                        'read empty line, avoid next batch of tests on it
                    Else
                        TempArray = strTextLine.Split("|".ToCharArray)
                        Select Case TempArray(0).ToUpper
                            Case "PCNAME"
                                strPCName = TempArray(1)
                            Case "PCIPADDRESS"
                                strLocalIPAddress = TempArray(1)
                            Case "USERNAME"
                                strUserName = TempArray(1)
                            Case "SERVER"
                                strServerAddress = TempArray(1)
                            Case "SERVERPORT"
                                iServerPort = Convert.ToInt16(TempArray(1))
                            Case "STATNAMESFILENAME"
                                strStatnamesFilename = TempArray(1)
                            Case "LOGPOSSESSION"
                                Select Case TempArray(1).ToUpper
                                    Case "TRUE", "YES"
                                        bLogPossession = True
                                End Select
                            Case "ALLOWDELETEDATA"
                                Select Case TempArray(1).ToUpper
                                    Case "TRUE", "YES"
                                        bAllowDeleteData = True
                                    Case "FALSE", "NO"
                                        bAllowDeleteData = False
                                End Select
                            Case "SPORTSERVERAUTOCONNECT"
                                Select Case UCase(TempArray(1))
                                    Case "TRUE", "YES"
                                        bAutoConnectToSportServer = True
                                    Case "FALSE", "NO"
                                        bAutoConnectToSportServer = False
                                End Select
                            Case "PERIODDURATIONNORMAL"
                                iPeriodDurationNormal = Convert.ToInt16(TempArray(1))
                            Case "PERIODDURATIONEXTRA"
                                iPeriodDurationExtra = Convert.ToInt16(TempArray(1))
                        End Select
                    End If
                Loop Until strTextLine Is Nothing
                inputFile.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Reading Config.ini")
        End Try
    End Sub
    Sub ReadStatnames()
        Dim strTextLine As String, strFilename As String, iStatNum As Integer
        Dim inputFile As System.IO.StreamReader
        Dim TempArray() As String
        JSONTeamStats.statList.Clear()

        Try
            strFilename = strStatnamesFilename
            If Not System.IO.File.Exists(strFilename) Then
                MessageBox.Show("No Statnames File: " & strStatnamesFilename)
                Exit Sub
            Else
                inputFile = System.IO.File.OpenText(strFilename)
                Do
                    strTextLine = inputFile.ReadLine
                    If strTextLine Is Nothing Then
                        'read empty line, avoid next batch of tests on it
                    Else
                        TempArray = strTextLine.Split("|".ToCharArray)
                        If TempArray(0).IndexOf("STATNAME") > 0 Then
                            If TempArray(0).ToUpper.Substring(0, 12) = "TEAMSTATNAME" Then
                                iStatNum = Val(TempArray(0).Substring(12, 2))
                                strTeamStatName(iStatNum) = TempArray(1)
                                If TempArray.GetUpperBound(0) > 2 Then
                                    'skip short code
                                    If TempArray(3).Trim <> "" Then
                                        strTeamStatJSONName(iStatNum) = TempArray(3)
                                        JSONTeamStats.statList.Add(New clsJSONTeamStat(TempArray(3)))
                                    End If
                                End If
                            ElseIf TempArray(0).ToUpper.Substring(0, 14) = "PLAYERSTATNAME" Then
                                iStatNum = Val(TempArray(0).Substring(14, 2))
                                strPlayerStatName(iStatNum) = TempArray(1)
                                If TempArray.GetUpperBound(0) > 2 Then
                                    'skip short code
                                    If TempArray(3).Trim <> "" Then
                                        strPlayerStatJSONName(iStatNum) = TempArray(3)
                                    End If
                                End If
                            Else
                                'Do nothing
                            End If
                        ElseIf TempArray(0).Contains("PENALTYNAME") Then
                            iStatNum = Val(TempArray(0).Substring(11, 2))
                            strPenaltyName(iStatNum) = TempArray(1)
                        Else
                            'ignore
                        End If


                    End If
                Loop Until strTextLine Is Nothing
                inputFile.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Reading StatNames.txt")
        End Try
    End Sub

End Class
