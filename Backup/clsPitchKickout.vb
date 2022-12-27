Public Enum KickoutDirection
    Undefined = 0
    LeftToRight = 1
    RightToLeft = 2
End Enum
Public Class clsPitchLocationLog

    Private iMatchID As Integer = -1
    Private iKickingTeamID As Integer = -1
    Private iWinningTeamID As Integer = -1
    Private iPlayerID As Integer = -1    'future

    Private iXSource As Integer = 0   'future
    Private iYSource As Integer = 0   'future

    Private iXLocation As Integer = 0
    Private iYLocation As Integer = 0

    Private cDirection As KickoutDirection = KickoutDirection.Undefined
    Private XMax As Integer = 840
    Private YMax As Integer = 536

    Private iKickID As Integer = -1

    Public Property KickOutID() As Integer
        Get
            Return iKickID
        End Get
        Set(ByVal value As Integer)
            iKickID = value
        End Set
    End Property


    Sub AssignDataString(ByVal tempString As String)
        'KickingTeam^Player^Direction^WinningTeam^XSource^YSource^XLocation^YLocation^

        On Error Resume Next

        Dim strContentArray() As String = tempString.Split("^")
        iKickingTeamID = Val(strContentArray(0))
        iPlayerID = Val(strContentArray(1))
        Direction = DecodeDirection(strContentArray(2))
        iWinningTeamID = Val(strContentArray(3))
        iXSource = Val(strContentArray(4))
        iYSource = Val(strContentArray(5))
        iXLocation = Val(strContentArray(6))
        iYLocation = Val(strContentArray(7))
    End Sub
    Public Property Direction() As KickoutDirection
        Get
            Return cDirection
        End Get
        Set(ByVal value As KickoutDirection)
            cDirection = value
        End Set
    End Property



    Public Property YLocation() As Integer
        Get
            Return iYLocation
        End Get
        Set(ByVal value As Integer)
            iYLocation = value
        End Set
    End Property


    Public Property XLocation() As Integer
        Get
            Return iXLocation
        End Get
        Set(ByVal value As Integer)
            iXLocation = value
        End Set
    End Property


    Public Property YSource() As Integer
        Get
            Return iYSource
        End Get
        Set(ByVal value As Integer)
            iYSource = value
        End Set
    End Property


    Public Property XSource() As Integer
        Get
            Return iXSource
        End Get
        Set(ByVal value As Integer)
            iXSource = value
        End Set
    End Property


    Public Property PlayerID() As Integer
        Get
            Return iPlayerID
        End Get
        Set(ByVal value As Integer)
            iPlayerID = value
        End Set
    End Property


    Public Property KickingTeamID() As Integer
        Get
            Return iKickingTeamID
        End Get
        Set(ByVal value As Integer)
            iKickingTeamID = value
        End Set
    End Property
    Public Property WinningTeamID() As Integer
        Get
            Return iWinningTeamID
        End Get
        Set(ByVal value As Integer)
            iWinningTeamID = value
        End Set
    End Property

    Public Property MatchID() As Integer
        Get
            Return iMatchID
        End Get
        Set(ByVal value As Integer)
            iMatchID = value
        End Set
    End Property
    ReadOnly Property XDisplay(ByVal currentDirection As KickoutDirection) As Integer
        Get
            If currentDirection = Direction Then
                'as marked
                Return XLocation
            Else
                'reverse
                Return XMax - XLocation
            End If
        End Get
    End Property
    ReadOnly Property YDisplay(ByVal currentDirection As KickoutDirection) As Integer
        Get
            If currentDirection = Direction Then
                'as marked
                Return YLocation
            Else
                'reverse
                Return YMax - YLocation
            End If
        End Get
    End Property
    ReadOnly Property XSourceDisplay(ByVal currentDirection As KickoutDirection) As Integer
        Get
            If currentDirection = Direction Then
                'as marked
                Return XSource
            Else
                'reverse
                Return XMax - XSource
            End If
        End Get
    End Property
    ReadOnly Property YSourceDisplay(ByVal currentDirection As KickoutDirection) As Integer
        Get
            If currentDirection = Direction Then
                'as marked
                Return YSource
            Else
                'reverse
                Return YMax - YSource
            End If
        End Get
    End Property
    ReadOnly Property DirectionCode() As String
        Get
            Select Case Direction
                Case KickoutDirection.LeftToRight
                    Return "L"
                Case KickoutDirection.RightToLeft
                    Return "R"
                Case Else
                    Return "U"
            End Select
        End Get
    End Property
    ReadOnly Property DecodeDirection(ByVal directionCode As String) As KickoutDirection
        Get
            Select Case directionCode
                Case "L"
                    Return KickoutDirection.LeftToRight
                Case "R"
                    Return KickoutDirection.RightToLeft
                Case Else
                    Return KickoutDirection.Undefined
            End Select
        End Get
    End Property
    ReadOnly Property DataString() As String
        Get
            Dim strText As String = ""
            strText += iKickingTeamID.ToString & "^" & iPlayerID.ToString & "^" & DirectionCode & "^" & iWinningTeamID.ToString & "^" & iXSource.ToString & "^" & iYSource.ToString & "^" & iXLocation.ToString & "^" & iYLocation.ToString & "^"
            Return strText
        End Get
    End Property
End Class
