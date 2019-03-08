Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class clsUtils
    Private iHomePoss As Integer = 0
    Private iAwayPoss As Integer = 0
    Function PeriodPhrase(ByVal iPeriod As Integer) As String
        Select Case iPeriod
            Case Is > 7
                Return "FINAL SCORE"
            Case 1
                Return "FIRST HALF"
            Case 2
                Return "HALF TIME"
            Case 3
                Return ("SECOND HALF")
            Case 4
                Return "FULL TIME"
            Case 5
                Return "EXTRA TIME 1ST HALF"
            Case 6
                Return "EXTRA TIME HALF TIME"
            Case 7
                Return "EXTRA TIME 2ND HALF"
            Case Else
                Return "PRE MATCH"
        End Select
    End Function
    Sub SerializeMatch(ByVal temp As clsMatch)
        Dim strFileName As String = "Match.xml"
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(clsMatch))
        Dim myWriter As StreamWriter = New StreamWriter(strFileName)
        serializer.Serialize(myWriter, temp)
        myWriter.Close()
    End Sub
    Sub SerializePlayerStatSet(ByVal tempPlayerStat(,) As clsPlayerStat, ByVal iTeam As Integer)
        Dim strFileName As String
        Dim tempArray(25) As clsPlayerStat
        Dim inc As Integer
        For inc = 0 To 25
            tempArray(inc) = tempPlayerStat(iTeam, inc)
        Next
        If iTeam = 1 Then
            strFileName = "PlayersH.xml"
        Else
            strFileName = "PlayersA.xml"
        End If
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(clsPlayerStatSet))
        Dim tempSet As New clsPlayerStatSet(tempArray)
        Dim myWriter As StreamWriter = New StreamWriter(strFileName)
        serializer.Serialize(myWriter, tempSet)
        myWriter.Close()
    End Sub
    Function DeSerializePlayerStatSet(ByVal strFilename As String) As clsPlayerStatSet
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(clsPlayerStatSet))
        Dim tempSet As New clsPlayerStatSet
        Dim myReader As StreamReader = New StreamReader(strFilename)
        tempSet = CType(serializer.Deserialize(myReader), clsPlayerStatSet)
        myReader.Close()
        Return tempSet
    End Function
    Function DeSerializeMatchfile() As clsMatch
        Dim strFileName As String = "Match.xml"
        Dim temp As New clsMatch
        If File.Exists(strFileName) Then
            Try
                Dim serializer As XmlSerializer = New XmlSerializer(GetType(clsMatch))
                Dim myReader As StreamReader = New StreamReader(strFileName)
                temp = CType(serializer.Deserialize(myReader), clsMatch)
                myReader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error reading Match data")
                'will return default pagefile
            End Try
        Else
            MessageBox.Show("Can't find file: " & strFileName, "Error reading Match File")
        End If
        Return temp
    End Function

    Sub CalcTotals(ByVal temp As clsPossession())
        Dim iSecsHome As Integer, iSecsAway As Integer, iTotalSecs As Integer
        Select Case iCurrentPeriod
            Case 0, 1, 2
                iHomePoss = temp(1).HomePercent
                iAwayPoss = 100 - temp(1).HomePercent
            Case Else
                Select Case iCurrentPeriod
                    Case 3, 4
                        iSecsHome = Int(temp(1).Home.TotalSeconds + temp(3).Home.TotalSeconds)
                        iSecsAway = Int(temp(1).Away.TotalSeconds + temp(3).Away.TotalSeconds)
                    Case 5, 6
                        iSecsHome = Int(temp(1).Home.TotalSeconds + temp(3).Home.TotalSeconds + temp(5).Home.TotalSeconds)
                        iSecsAway = Int(temp(1).Away.TotalSeconds + temp(3).Away.TotalSeconds + temp(5).Away.TotalSeconds)
                    Case 7, 8
                        iSecsHome = Int(temp(1).Home.TotalSeconds + temp(3).Home.TotalSeconds + temp(5).Home.TotalSeconds + temp(7).Home.TotalSeconds)
                        iSecsAway = Int(temp(1).Away.TotalSeconds + temp(3).Away.TotalSeconds + temp(5).Away.TotalSeconds + temp(7).Away.TotalSeconds)
                End Select
                iTotalSecs = Int(iSecsHome + iSecsAway)
                If iTotalSecs = 0 Then
                    iHomePoss = 0
                    iAwayPoss = 0
                Else
                    iHomePoss = Int((iSecsHome / iTotalSecs) * 100)
                    iAwayPoss = 100 - iHomePoss
                End If
        End Select

    End Sub

    ReadOnly Property TotalPossessionHomeText() As String
        Get
            If iHomePoss + iAwayPoss = 0 Then
                Return ""
            Else
                Return iHomePoss.ToString & "%"
            End If
        End Get
    End Property
    ReadOnly Property TotalPossessionAwayText() As String
        Get
            If iHomePoss + iAwayPoss = 0 Then
                Return ""
            Else
                Return iAwayPoss.ToString & "%"
            End If
        End Get
    End Property
    Function FindPlayerbyID(ByVal iTeamNum As Integer, ByVal iID As Integer) As Integer
        Dim iReturn As Integer = 0
        Dim inc As Integer
        For inc = 1 To PlayerStat.GetUpperBound(1)
            If PlayerStat(iTeamNum, inc).PlayerID = iID Then
                iReturn = inc
            End If
        Next
        Return iReturn
    End Function
    Function AssignPlayers(ByVal tempString As String) As Integer
        'PlayerList|MatchID|TeamID|NumberOfEntries|ID1^Num1^SortName1^LongName1^ShortName1^ReportName1|ID2^Num2^SortName2^LongName2^ShortName2^ReportName2|...
        Dim iTeamNum As Integer = 0, iPlayerNum As Integer = 0
        Dim strPlayerArray() As String
        Dim dataArray() As String, inc As Integer
        Try
            dataArray = tempString.Split(Chr(124))
            If Val(dataArray(1)) = LiveMatch.MatchID Then
                Select Case Val(dataArray(2))
                    Case LiveMatch.HomeTeamID
                        iTeamNum = 1
                    Case LiveMatch.AwayTeamID
                        iTeamNum = 2
                End Select
                For inc = 0 To 25
                    PlayerStat(iTeamNum, inc) = New clsPlayerStat
                Next
                For iPlayerNum = 1 To Val(dataArray(3))
                    strPlayerArray = dataArray(iPlayerNum + 3).Split("^")
                    PlayerStat(iTeamNum, iPlayerNum).PlayerID = Val(strPlayerArray(0))
                    PlayerStat(iTeamNum, iPlayerNum).PlayerNum = Val(strPlayerArray(1))
                    PlayerStat(iTeamNum, iPlayerNum).PlayerSortName = strPlayerArray(2)
                    PlayerStat(iTeamNum, iPlayerNum).PlayerLongName = strPlayerArray(3)
                    PlayerStat(iTeamNum, iPlayerNum).PlayerShortName = strPlayerArray(4)
                Next
            Else
                'not live
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in AssignPlayers")
        End Try
        Return iTeamNum
    End Function
    Sub AssignPlayerNameString(ByVal tempString As String)
        'MatchData|PlayerEdited|MatchID|TeamID|Entry|ID^Num^SortName^LongName^ShortName^ReportName|
        Dim iMatchID As Integer, iTeamID As Integer
        Dim iTeam As Integer = 0, iPlayer As Integer = 0
        On Error Resume Next

        Dim dataArray() As String
        dataArray = tempString.Split(Chr(124))
        'dtTimeStamp = Now 'override incoming
        iMatchID = Val(dataArray(2))
        If iMatchID = LiveMatch.MatchID Then
            iTeamID = Val(dataArray(3))
            Select Case iTeamID
                Case LiveMatch.HomeTeamID
                    iTeam = 1
                Case LiveMatch.AwayTeamID
                    iTeam = 2
            End Select
            iPlayer = Val(dataArray(4))
            Dim strStatArray() As String = dataArray(5).Split("^")
            PlayerStat(iTeam, iPlayer).PlayerID = Val(strStatArray(0))
            PlayerStat(iTeam, iPlayer).PlayerNum = Val(strStatArray(1))
            PlayerStat(iTeam, iPlayer).PlayerSortName = strStatArray(2)
            PlayerStat(iTeam, iPlayer).PlayerLongName = strStatArray(3)
            PlayerStat(iTeam, iPlayer).PlayerShortName = strStatArray(4)
        End If
    End Sub
    Sub AssignPlayerDataString(ByVal tempString As String)
        'MatchData|PlayerStats|TimeStamp|MatchID|TeamID|PlayerID|Action|Stat1^Stat2^Stat3^...|1|12|14|
        Dim iMatchID As Integer, iTeamID As Integer, iPlayerID As Integer
        Dim iTeam As Integer = 0, iPlayer As Integer = 0
        On Error Resume Next

        Dim dataArray() As String
        dataArray = tempString.Split(Chr(124))
        'dtTimeStamp = Now 'override incoming
        iMatchID = Val(dataArray(3))
        If iMatchID = LiveMatch.MatchID Then
            iTeamID = Val(dataArray(4))
            Select Case iTeamID
                Case LiveMatch.HomeTeamID
                    iTeam = 1
                Case LiveMatch.AwayTeamID
                    iTeam = 2
            End Select
            iPlayerID = Val(dataArray(5))
            iPlayer = FindPlayerbyID(iTeam, iPlayerID)
            If Utils.IsRBPlayerNamesValid Then
                're-assign order based on incoming are in RB order.
                Dim strStatArray() As String = dataArray(7).Split("^")
                For incStat As Integer = 1 To 30
                    Dim statValue As Integer = Val(strStatArray(incStat - 1))   'zero-based
                    Dim localStatIndex As Integer = LookupLocalPlayerStatIndexFromRBIndex(incStat)
                    AssignPlayerStat(iTeam, iPlayer, localStatIndex, statValue)
                Next
                iCurrentPlayer = Val(dataArray(9))
                iCurrentPlayerStat = LookupLocalPlayerStatIndexFromRBIndex(Val(dataArray(10)))
            Else
                Dim strStatArray() As String = dataArray(7).Split("^")
                PlayerStat(iTeam, iPlayer).Stat01 = Val(strStatArray(0))
                PlayerStat(iTeam, iPlayer).Stat02 = Val(strStatArray(1))
                PlayerStat(iTeam, iPlayer).Stat03 = Val(strStatArray(2))
                PlayerStat(iTeam, iPlayer).Stat04 = Val(strStatArray(3))
                PlayerStat(iTeam, iPlayer).Stat05 = Val(strStatArray(4))
                PlayerStat(iTeam, iPlayer).Stat06 = Val(strStatArray(5))
                PlayerStat(iTeam, iPlayer).Stat07 = Val(strStatArray(6))
                PlayerStat(iTeam, iPlayer).Stat08 = Val(strStatArray(7))
                PlayerStat(iTeam, iPlayer).Stat09 = Val(strStatArray(8))
                PlayerStat(iTeam, iPlayer).Stat10 = Val(strStatArray(9))
                PlayerStat(iTeam, iPlayer).Stat11 = Val(strStatArray(10))
                PlayerStat(iTeam, iPlayer).Stat12 = Val(strStatArray(11))
                PlayerStat(iTeam, iPlayer).Stat13 = Val(strStatArray(12))
                PlayerStat(iTeam, iPlayer).Stat14 = Val(strStatArray(13))
                PlayerStat(iTeam, iPlayer).Stat15 = Val(strStatArray(14))
                PlayerStat(iTeam, iPlayer).Stat16 = Val(strStatArray(15))
                PlayerStat(iTeam, iPlayer).Stat17 = Val(strStatArray(16))
                PlayerStat(iTeam, iPlayer).Stat18 = Val(strStatArray(17))
                PlayerStat(iTeam, iPlayer).Stat19 = Val(strStatArray(18))
                PlayerStat(iTeam, iPlayer).Stat20 = Val(strStatArray(19))
                PlayerStat(iTeam, iPlayer).Stat21 = Val(strStatArray(20))
                PlayerStat(iTeam, iPlayer).Stat22 = Val(strStatArray(21))
                PlayerStat(iTeam, iPlayer).Stat23 = Val(strStatArray(22))
                PlayerStat(iTeam, iPlayer).Stat24 = Val(strStatArray(23))
                PlayerStat(iTeam, iPlayer).Stat25 = Val(strStatArray(24))
                PlayerStat(iTeam, iPlayer).Stat26 = Val(strStatArray(25))
                PlayerStat(iTeam, iPlayer).Stat27 = Val(strStatArray(26))
                PlayerStat(iTeam, iPlayer).Stat28 = Val(strStatArray(27))
                PlayerStat(iTeam, iPlayer).Stat29 = Val(strStatArray(28))
                PlayerStat(iTeam, iPlayer).Stat30 = Val(strStatArray(29))
                iCurrentPlayer = Val(dataArray(9))
                iCurrentPlayerStat = Val(dataArray(10))
            End If
        End If
    End Sub
    Sub AssignRemoteDataString(ByVal tempString As String)
        'MatchData|Possession|TimeStamp|MatchID|Period|Direction|MatchTime|Inplay|HomePossession^AwayPossession|Area1^Area2^Area3|HomeSecs^AwaySecs|HomeMatchPoss^AwayMatchPoss| (rebroadcast of incoming)

        On Error Resume Next

        Dim dataArray() As String
        dataArray = tempString.Split(Chr(124))

        RemoteData.CurrentDirection = Val(dataArray(5))
        RemoteData.PeriodTime = dataArray(6)
        RemoteData.PeriodInPlay = dataArray(7)

        Dim strAreaArray() As String = dataArray(9).Split("^")
        RemoteData.Area1 = strAreaArray(0)
        RemoteData.Area2 = strAreaArray(1)
        RemoteData.Area3 = strAreaArray(2)

        Dim strPossessionArray() As String = dataArray(11).Split("^")
        RemoteData.HomePossession = strPossessionArray(0)
        RemoteData.AwayPossession = strPossessionArray(1)

    End Sub
    Function LookupLocalTeamStatIndexFromRBIndex(thisIndex As Integer) As Integer
        Dim refName As String = strRBTeamStatJSONName(thisIndex)
        For incTest As Integer = 1 To strTeamStatJSONName.GetUpperBound(0)
            If strTeamStatJSONName(incTest) = refName Then
                Return incTest
            End If
        Next
        Return 0
    End Function
    Function LookupLocalPlayerStatIndexFromRBIndex(thisIndex As Integer) As Integer
        Dim refName As String = strRBPlayerStatJSONName(thisIndex)
        For incTest As Integer = 1 To strPlayerStatJSONName.GetUpperBound(0)
            If strPlayerStatJSONName(incTest) = refName Then
                Return incTest
            End If
        Next
        Return 0
    End Function
    Sub AssignHomeTeamStat(thisStatIndex As Integer, thisStatValue As Integer)
        Select Case thisStatIndex
            Case 1
                LiveMatch.Stat01H = thisStatValue
            Case 2
                LiveMatch.Stat02H = thisStatValue
            Case 3
                LiveMatch.Stat03H = thisStatValue
            Case 4
                LiveMatch.Stat04H = thisStatValue
            Case 5
                LiveMatch.Stat05H = thisStatValue
            Case 6
                LiveMatch.Stat06H = thisStatValue
            Case 7
                LiveMatch.Stat07H = thisStatValue
            Case 8
                LiveMatch.Stat08H = thisStatValue
            Case 9
                LiveMatch.Stat09H = thisStatValue
            Case 10
                LiveMatch.Stat10H = thisStatValue
            Case 11
                LiveMatch.Stat11H = thisStatValue
            Case 12
                LiveMatch.Stat12H = thisStatValue
            Case 13
                LiveMatch.Stat13H = thisStatValue
            Case 14
                LiveMatch.Stat14H = thisStatValue
            Case 15
                LiveMatch.Stat15H = thisStatValue
            Case 16
                LiveMatch.Stat16H = thisStatValue
            Case 17
                LiveMatch.Stat17H = thisStatValue
            Case 18
                LiveMatch.Stat18H = thisStatValue
            Case 19
                LiveMatch.Stat19H = thisStatValue
            Case 20
                LiveMatch.Stat20H = thisStatValue
            Case 21
                LiveMatch.Stat21H = thisStatValue
            Case 22
                LiveMatch.Stat22H = thisStatValue
            Case 23
                LiveMatch.Stat23H = thisStatValue
            Case 24
                LiveMatch.Stat24H = thisStatValue
            Case 25
                LiveMatch.Stat25H = thisStatValue
            Case 26
                LiveMatch.Stat26H = thisStatValue
            Case 27
                LiveMatch.Stat27H = thisStatValue
            Case 28
                LiveMatch.Stat28H = thisStatValue
            Case 29
                LiveMatch.Stat29H = thisStatValue
            Case 30
                LiveMatch.Stat30H = thisStatValue
            Case Else

        End Select
    End Sub
    Sub AssignAwayTeamStat(thisStatIndex As Integer, thisStatValue As Integer)
        Select Case thisStatIndex
            Case 1
                LiveMatch.Stat01A = thisStatValue
            Case 2
                LiveMatch.Stat02A = thisStatValue
            Case 3
                LiveMatch.Stat03A = thisStatValue
            Case 4
                LiveMatch.Stat04A = thisStatValue
            Case 5
                LiveMatch.Stat05A = thisStatValue
            Case 6
                LiveMatch.Stat06A = thisStatValue
            Case 7
                LiveMatch.Stat07A = thisStatValue
            Case 8
                LiveMatch.Stat08A = thisStatValue
            Case 9
                LiveMatch.Stat09A = thisStatValue
            Case 10
                LiveMatch.Stat10A = thisStatValue
            Case 11
                LiveMatch.Stat11A = thisStatValue
            Case 12
                LiveMatch.Stat12A = thisStatValue
            Case 13
                LiveMatch.Stat13A = thisStatValue
            Case 14
                LiveMatch.Stat14A = thisStatValue
            Case 15
                LiveMatch.Stat15A = thisStatValue
            Case 16
                LiveMatch.Stat16A = thisStatValue
            Case 17
                LiveMatch.Stat17A = thisStatValue
            Case 18
                LiveMatch.Stat18A = thisStatValue
            Case 19
                LiveMatch.Stat19A = thisStatValue
            Case 20
                LiveMatch.Stat20A = thisStatValue
            Case 21
                LiveMatch.Stat21A = thisStatValue
            Case 22
                LiveMatch.Stat22A = thisStatValue
            Case 23
                LiveMatch.Stat23A = thisStatValue
            Case 24
                LiveMatch.Stat24A = thisStatValue
            Case 25
                LiveMatch.Stat25A = thisStatValue
            Case 26
                LiveMatch.Stat26A = thisStatValue
            Case 27
                LiveMatch.Stat27A = thisStatValue
            Case 28
                LiveMatch.Stat28A = thisStatValue
            Case 29
                LiveMatch.Stat29A = thisStatValue
            Case 30
                LiveMatch.Stat30A = thisStatValue
            Case Else

        End Select
    End Sub
    Sub AssignPlayerStat(thisTeamIndex As Integer, thisPlayerIndex As Integer, thisStatIndex As Integer, thisStatValue As Integer)
        Select Case thisStatIndex
            Case 1
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat01 = thisStatValue
            Case 2
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat02 = thisStatValue
            Case 3
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat03 = thisStatValue
            Case 4
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat04 = thisStatValue
            Case 5
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat05 = thisStatValue
            Case 6
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat06 = thisStatValue
            Case 7
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat07 = thisStatValue
            Case 8
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat08 = thisStatValue
            Case 9
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat09 = thisStatValue
            Case 10
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat10 = thisStatValue
            Case 11
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat11 = thisStatValue
            Case 12
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat12 = thisStatValue
            Case 13
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat13 = thisStatValue
            Case 14
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat14 = thisStatValue
            Case 15
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat15 = thisStatValue
            Case 16
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat16 = thisStatValue
            Case 17
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat17 = thisStatValue
            Case 18
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat18 = thisStatValue
            Case 19
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat19 = thisStatValue
            Case 20
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat20 = thisStatValue
            Case 21
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat21 = thisStatValue
            Case 22
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat22 = thisStatValue
            Case 23
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat23 = thisStatValue
            Case 24
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat24 = thisStatValue
            Case 25
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat25 = thisStatValue
            Case 26
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat26 = thisStatValue
            Case 27
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat27 = thisStatValue
            Case 28
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat28 = thisStatValue
            Case 29
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat29 = thisStatValue
            Case 30
                PlayerStat(thisTeamIndex, thisPlayerIndex).Stat30 = thisStatValue
            Case Else

        End Select
    End Sub

    Sub AssignTeamDataString(ByVal tempString As String)
        'MatchData|TeamStats|TimeStamp|MatchID|TeamID|Action|Stat1^Stat2^Stat3^...
        Dim iMatchID As Integer, iTeamID As Integer
        On Error Resume Next

        Dim dataArray() As String
        dataArray = tempString.Split(Chr(124))
        '        dtTimeStamp = Now 'override incoming
        iMatchID = Val(dataArray(3))
        If iMatchID = LiveMatch.MatchID Then
            iTeamID = Val(dataArray(4))
            '       strAction = dataArray(5)
            If Utils.IsRBTeamNamesValid Then
                're-assign order based on incoming are in RB order.
                Dim strStatArray() As String = dataArray(6).Split("^")
                For incStat As Integer = 1 To 30
                    Dim statValue As Integer = Val(strStatArray(incStat - 1))   'zero-based
                    Dim localStatIndex As Integer = LookupLocalTeamStatIndexFromRBIndex(incStat)
                    Select Case iTeamID
                        Case LiveMatch.HomeTeamID
                            AssignHomeTeamStat(localStatIndex, statValue)
                        Case LiveMatch.AwayTeamID
                            AssignAwayTeamStat(localStatIndex, statValue)
                    End Select
                Next
                iCurrentTeam = Val(dataArray(7))
                iCurrentTeamStat = LookupLocalTeamStatIndexFromRBIndex(Val(dataArray(8)))
            Else
                Select Case iTeamID
                    Case LiveMatch.HomeTeamID
                        Dim strStatArray() As String = dataArray(6).Split("^")
                        LiveMatch.Stat01H = Val(strStatArray(0))
                        LiveMatch.Stat02H = Val(strStatArray(1))
                        LiveMatch.Stat03H = Val(strStatArray(2))
                        LiveMatch.Stat04H = Val(strStatArray(3))
                        LiveMatch.Stat05H = Val(strStatArray(4))
                        LiveMatch.Stat06H = Val(strStatArray(5))
                        LiveMatch.Stat07H = Val(strStatArray(6))
                        LiveMatch.Stat08H = Val(strStatArray(7))
                        LiveMatch.Stat09H = Val(strStatArray(8))
                        LiveMatch.Stat10H = Val(strStatArray(9))
                        LiveMatch.Stat11H = Val(strStatArray(10))
                        LiveMatch.Stat12H = Val(strStatArray(11))
                        LiveMatch.Stat13H = Val(strStatArray(12))
                        LiveMatch.Stat14H = Val(strStatArray(13))
                        LiveMatch.Stat15H = Val(strStatArray(14))
                        LiveMatch.Stat16H = Val(strStatArray(15))
                        LiveMatch.Stat17H = Val(strStatArray(16))
                        LiveMatch.Stat18H = Val(strStatArray(17))
                        LiveMatch.Stat19H = Val(strStatArray(18))
                        LiveMatch.Stat20H = Val(strStatArray(19))
                        LiveMatch.Stat21H = Val(strStatArray(20))
                        LiveMatch.Stat22H = Val(strStatArray(21))
                        LiveMatch.Stat23H = Val(strStatArray(22))
                        LiveMatch.Stat24H = Val(strStatArray(23))
                        LiveMatch.Stat25H = Val(strStatArray(24))
                        LiveMatch.Stat26H = Val(strStatArray(25))
                        LiveMatch.Stat27H = Val(strStatArray(26))
                        LiveMatch.Stat28H = Val(strStatArray(27))
                        LiveMatch.Stat29H = Val(strStatArray(28))
                        LiveMatch.Stat30H = Val(strStatArray(29))
                    Case LiveMatch.AwayTeamID
                        Dim strStatArray() As String = dataArray(6).Split("^")
                        LiveMatch.Stat01A = Val(strStatArray(0))
                        LiveMatch.Stat02A = Val(strStatArray(1))
                        LiveMatch.Stat03A = Val(strStatArray(2))
                        LiveMatch.Stat04A = Val(strStatArray(3))
                        LiveMatch.Stat05A = Val(strStatArray(4))
                        LiveMatch.Stat06A = Val(strStatArray(5))
                        LiveMatch.Stat07A = Val(strStatArray(6))
                        LiveMatch.Stat08A = Val(strStatArray(7))
                        LiveMatch.Stat09A = Val(strStatArray(8))
                        LiveMatch.Stat10A = Val(strStatArray(9))
                        LiveMatch.Stat11A = Val(strStatArray(10))
                        LiveMatch.Stat12A = Val(strStatArray(11))
                        LiveMatch.Stat13A = Val(strStatArray(12))
                        LiveMatch.Stat14A = Val(strStatArray(13))
                        LiveMatch.Stat15A = Val(strStatArray(14))
                        LiveMatch.Stat16A = Val(strStatArray(15))
                        LiveMatch.Stat17A = Val(strStatArray(16))
                        LiveMatch.Stat18A = Val(strStatArray(17))
                        LiveMatch.Stat19A = Val(strStatArray(18))
                        LiveMatch.Stat20A = Val(strStatArray(19))
                        LiveMatch.Stat21A = Val(strStatArray(20))
                        LiveMatch.Stat22A = Val(strStatArray(21))
                        LiveMatch.Stat23A = Val(strStatArray(22))
                        LiveMatch.Stat24A = Val(strStatArray(23))
                        LiveMatch.Stat25A = Val(strStatArray(24))
                        LiveMatch.Stat26A = Val(strStatArray(25))
                        LiveMatch.Stat27A = Val(strStatArray(26))
                        LiveMatch.Stat28A = Val(strStatArray(27))
                        LiveMatch.Stat29A = Val(strStatArray(28))
                        LiveMatch.Stat30A = Val(strStatArray(29))
                    Case Else
                End Select
                iCurrentTeam = Val(dataArray(7))
                iCurrentTeamStat = Val(dataArray(8))
            End If
        End If
    End Sub
    Sub AssignAllTeamStatsDataString(ByVal tempString As String)
        Dim iMatchID As Integer, iTeamID As Integer
        On Error Resume Next
        Dim dataArray() As String
        dataArray = tempString.Split(Chr(124))
        iMatchID = Val(dataArray(2))
        If iMatchID = LiveMatch.MatchID Then
            Dim homeStatArray() As String = dataArray(3).Split("^")
            For incStat As Integer = 1 To 30
                Dim statValue As Integer = Val(homeStatArray(incStat))   'one-based
                Dim localStatIndex As Integer = LookupLocalTeamStatIndexFromRBIndex(incStat)
                AssignHomeTeamStat(localStatIndex, statValue)
            Next
            Dim awayStatArray() As String = dataArray(4).Split("^")
            For incStat As Integer = 1 To 30
                Dim statValue As Integer = Val(awayStatArray(incStat))   'one-based
                Dim localStatIndex As Integer = LookupLocalTeamStatIndexFromRBIndex(incStat)
                AssignAwayTeamStat(localStatIndex, statValue)
            Next
        End If
    End Sub
    Function IsTeamJSONValid() As Boolean
        Dim returnValue As Boolean = False
        For Each JSONStat As clsJSONTeamStat In JSONTeamStats.statList
            If JSONStat.n <> "" Then
                returnValue = True
            End If
        Next
        Return returnValue
    End Function
    Function IsRBTeamNamesValid() As Boolean
        Dim returnValue As Boolean = False
        For inc As Integer = 1 To strRBTeamStatJSONName.GetUpperBound(0)
            If strRBTeamStatJSONName(inc) <> "" Then
                returnValue = True
            End If
        Next
        Return returnValue
    End Function
    Function IsRBPlayerNamesValid() As Boolean
        'Return False '##################
        Dim returnValue As Boolean = False
        For inc As Integer = 1 To strRBPlayerStatJSONName.GetUpperBound(0)
            If strRBPlayerStatJSONName(inc) <> "" Then
                returnValue = True
            End If
        Next
        Return returnValue
    End Function
    Function IsPlayerJSONValid() As Boolean
        Dim returnValue As Boolean = False
        Dim inc As Integer = 0
        For Each JSONPlayer As clsJSONPlayer In JSONPlayerStats.playerList
            inc += 1
            For Each JSONStat As clsJSONPlayerStat In JSONPlayer.statList
                If JSONStat.n <> "" Then
                    returnValue = True
                End If
            Next
            If inc > 0 Then
                'only need one player
                Exit For
            End If
        Next
        Return returnValue
    End Function
End Class
