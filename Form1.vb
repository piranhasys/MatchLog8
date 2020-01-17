Imports System.Drawing.Drawing2D
Imports System.Net.Sockets
Imports System.Text
Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports System.Net.DnsPermissionAttribute
Imports System.Security.Permissions
Imports System.Runtime.InteropServices
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Web.Script.Serialization

Public Class Form1
#Region "Stuff"

    Inherits System.Windows.Forms.Form
    Friend WithEvents btnSwapDirection As System.Windows.Forms.Button
    Friend WithEvents btnPeriod0 As System.Windows.Forms.Button
    Friend WithEvents lablTotalPossA As System.Windows.Forms.Label
    Friend WithEvents lablTotalPossH As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnPlayer04H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer03H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer02H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer01H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer05H As System.Windows.Forms.Button
    Friend WithEvents lablPlayerStat16H As System.Windows.Forms.Label
    Friend WithEvents btnPlayer24H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer23H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer22H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer21H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer20H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer19H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer18H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer17H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer16H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer15H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer14H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer13H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer12H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer11H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer10H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer09H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer08H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer07H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer06H As System.Windows.Forms.Button
    Friend WithEvents lablPlayerStatHeading15 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat15H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading14 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat14H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading13 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat13H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading12 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat12H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading11 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat11H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading10 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat10H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading09 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat09H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading08 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat08H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading07 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat07H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading06 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat06H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading05 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat05H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading04 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat04H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading03 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat03H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading02 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat02H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading01 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat01H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading30 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat30H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading29 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat29H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading28 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat28H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading27 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat27H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading26 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat26H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading25 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat25H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading24 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat24H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading23 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat23H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading22 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat22H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading21 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat21H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading20 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat20H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading19 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat19H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading18 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat18H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading17 As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat17H As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading16 As System.Windows.Forms.Label
    Friend WithEvents btnPlayer25H As System.Windows.Forms.Button
    Friend WithEvents btnPlayer25A As System.Windows.Forms.Button
    Friend WithEvents lablPlayerStatHeading15A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat15A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading14A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat14A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading13A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat13A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading12A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat12A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading11A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat11A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading10A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat10A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading09A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat09A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading08A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat08A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading07A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat07A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading06A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat06A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading05A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat05A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading04A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat04A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading03A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat03A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading02A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat02A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading01A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat01A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading30A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat30A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading29A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat29A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading28A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat28A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading27A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat27A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading26A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat26A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading25A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat25A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading24A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat24A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading23A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat23A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading22A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat22A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading21A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat21A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading20A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat20A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading19A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat19A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading18A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat18A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading17A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat17A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStatHeading16A As System.Windows.Forms.Label
    Friend WithEvents lablPlayerStat16A As System.Windows.Forms.Label
    Friend WithEvents btnPlayer24A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer23A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer22A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer21A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer20A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer19A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer18A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer17A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer16A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer15A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer14A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer13A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer12A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer11A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer10A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer09A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer08A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer07A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer06A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer05A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer04A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer03A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer02A As System.Windows.Forms.Button
    Friend WithEvents btnPlayer01A As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents listViewSummaryHome As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents listViewsummaryAway As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader47 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader52 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader53 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader54 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader59 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader60 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader61 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader62 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader63 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader64 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents groupRemotePossession As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteInPlay As System.Windows.Forms.Label
    Friend WithEvents lablRemoteMatchTime As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAwayTeam As System.Windows.Forms.Label
    Friend WithEvents lablRemoteHomeTeam As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaS1 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaS2 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaS3 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAwayPossession As System.Windows.Forms.Label
    Friend WithEvents lablRemoteHomePossession As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClearPlayerHome As System.Windows.Forms.Button
    Friend WithEvents btnResendPlayerHome As System.Windows.Forms.Button
    Friend WithEvents timerCheckConnection As System.Windows.Forms.Timer
    Friend WithEvents btnClearAllTeam As System.Windows.Forms.Button
    Friend WithEvents btnResendTeam As System.Windows.Forms.Button
    Friend WithEvents btnClearPlayerAway As System.Windows.Forms.Button
    Friend WithEvents btnResendPlayerAway As System.Windows.Forms.Button
    Friend WithEvents lablRemoteAreaR4 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaR3 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaR2 As System.Windows.Forms.Label
    Friend WithEvents lablRemoteAreaR1 As System.Windows.Forms.Label
    Friend WithEvents groupActionAreasRugby As System.Windows.Forms.GroupBox
    Friend WithEvents lablAreaR1 As System.Windows.Forms.Label
    Friend WithEvents lablViewR3 As System.Windows.Forms.Label
    Friend WithEvents btnAreaR3 As System.Windows.Forms.Button
    Friend WithEvents lablAreaR2 As System.Windows.Forms.Label
    Friend WithEvents lablAreaR3 As System.Windows.Forms.Label
    Friend WithEvents lablViewR1 As System.Windows.Forms.Label
    Friend WithEvents btnAreaR1 As System.Windows.Forms.Button
    Friend WithEvents lablViewR2 As System.Windows.Forms.Label
    Friend WithEvents btnAreaR2 As System.Windows.Forms.Button
    Friend WithEvents lablAreaR4 As System.Windows.Forms.Label
    Friend WithEvents btnAreaR4 As System.Windows.Forms.Button
    Friend WithEvents lablViewR4 As System.Windows.Forms.Label
    Friend WithEvents tabKickouts As System.Windows.Forms.TabPage
    Friend WithEvents picBoxPitch As System.Windows.Forms.PictureBox
    Friend WithEvents lablPitchLRTeamName As System.Windows.Forms.Label
    Friend WithEvents btnPitchAwayWin As System.Windows.Forms.Button
    Friend WithEvents btnPitchHomeWin As System.Windows.Forms.Button
    Friend WithEvents lablPitchRLArrow As System.Windows.Forms.Label
    Friend WithEvents lablPitchRLTeamName As System.Windows.Forms.Label
    Friend WithEvents lablPitchLRArrow As System.Windows.Forms.Label
    Friend WithEvents lablPitchAway1 As System.Windows.Forms.Label
    Friend WithEvents lablPitchHome1 As System.Windows.Forms.Label
    Friend WithEvents lablPitchAway2 As System.Windows.Forms.Label
    Friend WithEvents lablPitchHome2 As System.Windows.Forms.Label
    Friend WithEvents btnDeleteKickout As System.Windows.Forms.Button
    Friend WithEvents btnStepKickouts As System.Windows.Forms.Button
    Friend WithEvents lablPitchLogHeading2 As System.Windows.Forms.Label
    Friend WithEvents lablPitchLogHeading1 As System.Windows.Forms.Label
    Friend WithEvents lablStepKickoutNum As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioLog4565 As System.Windows.Forms.RadioButton
    Friend WithEvents radioLogFrees As System.Windows.Forms.RadioButton
    Friend WithEvents radioLogKickouts As System.Windows.Forms.RadioButton
    Friend WithEvents btnPitchShotWide As System.Windows.Forms.Button
    Friend WithEvents lablPitchHomeName As System.Windows.Forms.Label
    Friend WithEvents lablPitchAwayName As System.Windows.Forms.Label
    Friend WithEvents tabPenalties As System.Windows.Forms.TabPage
    Friend WithEvents btnPenaltyName01 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName24 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName12 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName23 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName11 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName22 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName10 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName21 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName09 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName20 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName08 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName19 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName07 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName18 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName06 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName17 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName05 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName16 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName04 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName15 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName03 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName14 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName02 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName13 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName30 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName29 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName28 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName27 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName26 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyName25 As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyDisplay As System.Windows.Forms.Button
    Friend WithEvents btnPenaltyClear As System.Windows.Forms.Button
    Friend WithEvents btnAdvantageClear As System.Windows.Forms.Button
    Friend WithEvents btnAdvantageAway As System.Windows.Forms.Button
    Friend WithEvents btnAdvantageHome As System.Windows.Forms.Button
    Friend WithEvents lablPitchLogHeading3 As System.Windows.Forms.Label
    Friend WithEvents lablPitchAway3 As System.Windows.Forms.Label
    Friend WithEvents lablPitchKickoutPrompt As System.Windows.Forms.Label
    Friend WithEvents btnPitchShotGood2 As System.Windows.Forms.Button
    Friend WithEvents btnPitchShotGood3 As System.Windows.Forms.Button
    Friend WithEvents btnPitchShotGood4 As System.Windows.Forms.Button
    Friend WithEvents btnPitchShotWide2 As System.Windows.Forms.Button
    Friend WithEvents btnPitchShotGood As System.Windows.Forms.Button
    Friend WithEvents lablSelectedPenalty As System.Windows.Forms.Label
    Friend WithEvents btnPenaltyDisplay2 As System.Windows.Forms.Button
    Friend WithEvents btnFetchStatNames As System.Windows.Forms.Button
    Friend WithEvents lablMatchID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelSuperLeaguePro14 As Panel
    Friend WithEvents lablRemoteAwayPossessionSL As Label
    Friend WithEvents lablRemoteHomePossessionSL As Label
    Friend WithEvents lablAwayNameSL As Label
    Friend WithEvents lablHomeNameSL As Label
    Friend WithEvents btnPossessionHSL As Button
    Friend WithEvents btnPossessionASL As Button
    Friend WithEvents btnPossessionOOPSL As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picBoxSLLogo As PictureBox
    Friend WithEvents lablPeriodSL As Label
    Friend WithEvents lablMatchClockSL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearSLPossession As Button
    Friend WithEvents lablAwayScoreSL As Label
    Friend WithEvents lablHomeScoreSL As Label
    Friend WithEvents picBoxPro14 As PictureBox
    Friend WithEvents btnFetchRBStats As Button
    Friend WithEvents tabCarries As TabPage
    Friend WithEvents listViewCarriesHome As ListView
    Friend WithEvents ColumnHeader65 As ColumnHeader
    Friend WithEvents ColumnHeader66 As ColumnHeader
    Friend WithEvents lablHomeNameSL2 As Label
    Friend WithEvents lablAwayNameSL2 As Label
    Friend WithEvents listViewCarriesAway As ListView
    Friend WithEvents ColumnHeader67 As ColumnHeader
    Friend WithEvents ColumnHeader68 As ColumnHeader
    Friend WithEvents ColumnHeader70 As ColumnHeader
    Friend WithEvents ColumnHeader69 As ColumnHeader
    Friend WithEvents btnFetchLiveMatch As Button
    Friend WithEvents lablPitchHome3 As System.Windows.Forms.Label
#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "More Stuff"
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lablHeading01 As System.Windows.Forms.Label
    Friend WithEvents lablStat01H As System.Windows.Forms.Label
    Friend WithEvents lablStat01A As System.Windows.Forms.Label
    Friend WithEvents lablStat02A As System.Windows.Forms.Label
    Friend WithEvents lablStat02H As System.Windows.Forms.Label
    Friend WithEvents lablHeading02 As System.Windows.Forms.Label
    Friend WithEvents lablStat03A As System.Windows.Forms.Label
    Friend WithEvents lablStat03H As System.Windows.Forms.Label
    Friend WithEvents lablHeading03 As System.Windows.Forms.Label
    Friend WithEvents lablStat04A As System.Windows.Forms.Label
    Friend WithEvents lablStat04H As System.Windows.Forms.Label
    Friend WithEvents lablHeading04 As System.Windows.Forms.Label
    Friend WithEvents lablStat05A As System.Windows.Forms.Label
    Friend WithEvents lablStat05H As System.Windows.Forms.Label
    Friend WithEvents lablHeading05 As System.Windows.Forms.Label
    Friend WithEvents lablStat10A As System.Windows.Forms.Label
    Friend WithEvents lablStat10H As System.Windows.Forms.Label
    Friend WithEvents lablHeading10 As System.Windows.Forms.Label
    Friend WithEvents lablStat09A As System.Windows.Forms.Label
    Friend WithEvents lablStat09H As System.Windows.Forms.Label
    Friend WithEvents lablHeading09 As System.Windows.Forms.Label
    Friend WithEvents lablStat08A As System.Windows.Forms.Label
    Friend WithEvents lablStat08H As System.Windows.Forms.Label
    Friend WithEvents lablHeading08 As System.Windows.Forms.Label
    Friend WithEvents lablStat07A As System.Windows.Forms.Label
    Friend WithEvents lablStat07H As System.Windows.Forms.Label
    Friend WithEvents lablHeading07 As System.Windows.Forms.Label
    Friend WithEvents lablStat06A As System.Windows.Forms.Label
    Friend WithEvents lablStat06H As System.Windows.Forms.Label
    Friend WithEvents lablHeading06 As System.Windows.Forms.Label
    Friend WithEvents lablStat30A As System.Windows.Forms.Label
    Friend WithEvents lablStat30H As System.Windows.Forms.Label
    Friend WithEvents lablHeading30 As System.Windows.Forms.Label
    Friend WithEvents lablStat29A As System.Windows.Forms.Label
    Friend WithEvents lablStat29H As System.Windows.Forms.Label
    Friend WithEvents lablHeading29 As System.Windows.Forms.Label
    Friend WithEvents lablStat28A As System.Windows.Forms.Label
    Friend WithEvents lablStat28H As System.Windows.Forms.Label
    Friend WithEvents lablHeading28 As System.Windows.Forms.Label
    Friend WithEvents lablStat27A As System.Windows.Forms.Label
    Friend WithEvents lablStat27H As System.Windows.Forms.Label
    Friend WithEvents lablHeading27 As System.Windows.Forms.Label
    Friend WithEvents lablStat26A As System.Windows.Forms.Label
    Friend WithEvents lablStat26H As System.Windows.Forms.Label
    Friend WithEvents lablHeading26 As System.Windows.Forms.Label
    Friend WithEvents lablStat15A As System.Windows.Forms.Label
    Friend WithEvents lablStat15H As System.Windows.Forms.Label
    Friend WithEvents lablHeading15 As System.Windows.Forms.Label
    Friend WithEvents lablStat14A As System.Windows.Forms.Label
    Friend WithEvents lablStat14H As System.Windows.Forms.Label
    Friend WithEvents lablHeading14 As System.Windows.Forms.Label
    Friend WithEvents lablStat13A As System.Windows.Forms.Label
    Friend WithEvents lablStat13H As System.Windows.Forms.Label
    Friend WithEvents lablHeading13 As System.Windows.Forms.Label
    Friend WithEvents lablStat12A As System.Windows.Forms.Label
    Friend WithEvents lablStat12H As System.Windows.Forms.Label
    Friend WithEvents lablHeading12 As System.Windows.Forms.Label
    Friend WithEvents lablStat11A As System.Windows.Forms.Label
    Friend WithEvents lablStat11H As System.Windows.Forms.Label
    Friend WithEvents lablHeading11 As System.Windows.Forms.Label
    Friend WithEvents lablStat25A As System.Windows.Forms.Label
    Friend WithEvents lablStat25H As System.Windows.Forms.Label
    Friend WithEvents lablHeading25 As System.Windows.Forms.Label
    Friend WithEvents lablStat24A As System.Windows.Forms.Label
    Friend WithEvents lablStat24H As System.Windows.Forms.Label
    Friend WithEvents lablHeading24 As System.Windows.Forms.Label
    Friend WithEvents lablStat23A As System.Windows.Forms.Label
    Friend WithEvents lablStat23H As System.Windows.Forms.Label
    Friend WithEvents lablHeading23 As System.Windows.Forms.Label
    Friend WithEvents lablStat22A As System.Windows.Forms.Label
    Friend WithEvents lablStat22H As System.Windows.Forms.Label
    Friend WithEvents lablHeading22 As System.Windows.Forms.Label
    Friend WithEvents lablStat21A As System.Windows.Forms.Label
    Friend WithEvents lablStat21H As System.Windows.Forms.Label
    Friend WithEvents lablHeading21 As System.Windows.Forms.Label
    Friend WithEvents lablStat20A As System.Windows.Forms.Label
    Friend WithEvents lablStat20H As System.Windows.Forms.Label
    Friend WithEvents lablHeading20 As System.Windows.Forms.Label
    Friend WithEvents lablStat19A As System.Windows.Forms.Label
    Friend WithEvents lablStat19H As System.Windows.Forms.Label
    Friend WithEvents lablHeading19 As System.Windows.Forms.Label
    Friend WithEvents lablStat18A As System.Windows.Forms.Label
    Friend WithEvents lablStat18H As System.Windows.Forms.Label
    Friend WithEvents lablHeading18 As System.Windows.Forms.Label
    Friend WithEvents lablStat17A As System.Windows.Forms.Label
    Friend WithEvents lablStat17H As System.Windows.Forms.Label
    Friend WithEvents lablHeading17 As System.Windows.Forms.Label
    Friend WithEvents lablStat16A As System.Windows.Forms.Label
    Friend WithEvents lablStat16H As System.Windows.Forms.Label
    Friend WithEvents lablHeading16 As System.Windows.Forms.Label
    Friend WithEvents lablAwayName As System.Windows.Forms.Label
    Friend WithEvents lablHomeName As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents lablMatchTime2 As System.Windows.Forms.Label
    Friend WithEvents lablInPlay As System.Windows.Forms.Label
    Friend WithEvents lablPossessionA As System.Windows.Forms.Label
    Friend WithEvents lablPossessionH As System.Windows.Forms.Label
    Friend WithEvents lablAreaS1 As System.Windows.Forms.Label
    Friend WithEvents lablAreaS2 As System.Windows.Forms.Label
    Friend WithEvents lablAreaS3 As System.Windows.Forms.Label
    Friend WithEvents groupClock As System.Windows.Forms.GroupBox
    Friend WithEvents btnPeriodEnable As System.Windows.Forms.Button
    Friend WithEvents btnPeriod1 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod2 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod4 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod3 As System.Windows.Forms.Button
    Friend WithEvents btnPossessionH As System.Windows.Forms.Button
    Friend WithEvents btnPossessionA As System.Windows.Forms.Button
    Friend WithEvents btnPossessionOOP As System.Windows.Forms.Button
    Friend WithEvents btnAreaS3 As System.Windows.Forms.Button
    Friend WithEvents btnAreaS2 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod8 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod7 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod6 As System.Windows.Forms.Button
    Friend WithEvents btnPeriod5 As System.Windows.Forms.Button
    Friend WithEvents lablHomeName2 As System.Windows.Forms.Label
    Friend WithEvents lablAwayName2 As System.Windows.Forms.Label
    Friend WithEvents lablAwayName3 As System.Windows.Forms.Label
    Friend WithEvents lablHomeName3 As System.Windows.Forms.Label
    Friend WithEvents lablPeriod As System.Windows.Forms.Label
    Friend WithEvents groupViewTime As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogGoal As System.Windows.Forms.Button
    Friend WithEvents btnLogYC As System.Windows.Forms.Button
    Friend WithEvents btnLogRC As System.Windows.Forms.Button
    Friend WithEvents groupActionAreasSoccer As System.Windows.Forms.GroupBox
    Friend WithEvents groupPossession As System.Windows.Forms.GroupBox
    Friend WithEvents lablArrowHomeLR As System.Windows.Forms.Label
    Friend WithEvents lablArrowHomeRL As System.Windows.Forms.Label
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lablArrowAwayRL As System.Windows.Forms.Label
    Friend WithEvents lablArrowAwayLR As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents LablConnected As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lablRemove As System.Windows.Forms.Label
    Friend WithEvents lablMatchTime As System.Windows.Forms.Label
    Friend WithEvents btnClockNudgeDown As System.Windows.Forms.Button
    Friend WithEvents btnClockNudgeUp As System.Windows.Forms.Button
    Friend WithEvents timerCheckClock As System.Windows.Forms.Timer
    Friend WithEvents lablViewH As System.Windows.Forms.Label
    Friend WithEvents lablViewA As System.Windows.Forms.Label
    Friend WithEvents lablViewOOP As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lablViewS1 As System.Windows.Forms.Label
    Friend WithEvents lablViewS2 As System.Windows.Forms.Label
    Friend WithEvents lablViewS3 As System.Windows.Forms.Label
    Friend WithEvents btnAreaS1 As System.Windows.Forms.Button
#End Region
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lablHeading01 = New System.Windows.Forms.Label()
        Me.lablStat01H = New System.Windows.Forms.Label()
        Me.lablStat01A = New System.Windows.Forms.Label()
        Me.lablStat02A = New System.Windows.Forms.Label()
        Me.lablStat02H = New System.Windows.Forms.Label()
        Me.lablHeading02 = New System.Windows.Forms.Label()
        Me.lablStat03A = New System.Windows.Forms.Label()
        Me.lablStat03H = New System.Windows.Forms.Label()
        Me.lablHeading03 = New System.Windows.Forms.Label()
        Me.lablStat04A = New System.Windows.Forms.Label()
        Me.lablStat04H = New System.Windows.Forms.Label()
        Me.lablHeading04 = New System.Windows.Forms.Label()
        Me.lablStat05A = New System.Windows.Forms.Label()
        Me.lablStat05H = New System.Windows.Forms.Label()
        Me.lablHeading05 = New System.Windows.Forms.Label()
        Me.lablStat10A = New System.Windows.Forms.Label()
        Me.lablStat10H = New System.Windows.Forms.Label()
        Me.lablHeading10 = New System.Windows.Forms.Label()
        Me.lablStat09A = New System.Windows.Forms.Label()
        Me.lablStat09H = New System.Windows.Forms.Label()
        Me.lablHeading09 = New System.Windows.Forms.Label()
        Me.lablStat08A = New System.Windows.Forms.Label()
        Me.lablStat08H = New System.Windows.Forms.Label()
        Me.lablHeading08 = New System.Windows.Forms.Label()
        Me.lablStat07A = New System.Windows.Forms.Label()
        Me.lablStat07H = New System.Windows.Forms.Label()
        Me.lablHeading07 = New System.Windows.Forms.Label()
        Me.lablStat06A = New System.Windows.Forms.Label()
        Me.lablStat06H = New System.Windows.Forms.Label()
        Me.lablHeading06 = New System.Windows.Forms.Label()
        Me.lablStat30A = New System.Windows.Forms.Label()
        Me.lablStat30H = New System.Windows.Forms.Label()
        Me.lablHeading30 = New System.Windows.Forms.Label()
        Me.lablStat29A = New System.Windows.Forms.Label()
        Me.lablStat29H = New System.Windows.Forms.Label()
        Me.lablHeading29 = New System.Windows.Forms.Label()
        Me.lablStat28A = New System.Windows.Forms.Label()
        Me.lablStat28H = New System.Windows.Forms.Label()
        Me.lablHeading28 = New System.Windows.Forms.Label()
        Me.lablStat27A = New System.Windows.Forms.Label()
        Me.lablStat27H = New System.Windows.Forms.Label()
        Me.lablHeading27 = New System.Windows.Forms.Label()
        Me.lablStat26A = New System.Windows.Forms.Label()
        Me.lablStat26H = New System.Windows.Forms.Label()
        Me.lablHeading26 = New System.Windows.Forms.Label()
        Me.lablStat15A = New System.Windows.Forms.Label()
        Me.lablStat15H = New System.Windows.Forms.Label()
        Me.lablHeading15 = New System.Windows.Forms.Label()
        Me.lablStat14A = New System.Windows.Forms.Label()
        Me.lablStat14H = New System.Windows.Forms.Label()
        Me.lablHeading14 = New System.Windows.Forms.Label()
        Me.lablStat13A = New System.Windows.Forms.Label()
        Me.lablStat13H = New System.Windows.Forms.Label()
        Me.lablHeading13 = New System.Windows.Forms.Label()
        Me.lablStat12A = New System.Windows.Forms.Label()
        Me.lablStat12H = New System.Windows.Forms.Label()
        Me.lablHeading12 = New System.Windows.Forms.Label()
        Me.lablStat11A = New System.Windows.Forms.Label()
        Me.lablStat11H = New System.Windows.Forms.Label()
        Me.lablHeading11 = New System.Windows.Forms.Label()
        Me.lablStat25A = New System.Windows.Forms.Label()
        Me.lablStat25H = New System.Windows.Forms.Label()
        Me.lablHeading25 = New System.Windows.Forms.Label()
        Me.lablStat24A = New System.Windows.Forms.Label()
        Me.lablStat24H = New System.Windows.Forms.Label()
        Me.lablHeading24 = New System.Windows.Forms.Label()
        Me.lablStat23A = New System.Windows.Forms.Label()
        Me.lablStat23H = New System.Windows.Forms.Label()
        Me.lablHeading23 = New System.Windows.Forms.Label()
        Me.lablStat22A = New System.Windows.Forms.Label()
        Me.lablStat22H = New System.Windows.Forms.Label()
        Me.lablHeading22 = New System.Windows.Forms.Label()
        Me.lablStat21A = New System.Windows.Forms.Label()
        Me.lablStat21H = New System.Windows.Forms.Label()
        Me.lablHeading21 = New System.Windows.Forms.Label()
        Me.lablStat20A = New System.Windows.Forms.Label()
        Me.lablStat20H = New System.Windows.Forms.Label()
        Me.lablHeading20 = New System.Windows.Forms.Label()
        Me.lablStat19A = New System.Windows.Forms.Label()
        Me.lablStat19H = New System.Windows.Forms.Label()
        Me.lablHeading19 = New System.Windows.Forms.Label()
        Me.lablStat18A = New System.Windows.Forms.Label()
        Me.lablStat18H = New System.Windows.Forms.Label()
        Me.lablHeading18 = New System.Windows.Forms.Label()
        Me.lablStat17A = New System.Windows.Forms.Label()
        Me.lablStat17H = New System.Windows.Forms.Label()
        Me.lablHeading17 = New System.Windows.Forms.Label()
        Me.lablStat16A = New System.Windows.Forms.Label()
        Me.lablStat16H = New System.Windows.Forms.Label()
        Me.lablHeading16 = New System.Windows.Forms.Label()
        Me.lablAwayName = New System.Windows.Forms.Label()
        Me.lablHomeName = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lablMatchTime2 = New System.Windows.Forms.Label()
        Me.lablInPlay = New System.Windows.Forms.Label()
        Me.lablPossessionA = New System.Windows.Forms.Label()
        Me.lablPossessionH = New System.Windows.Forms.Label()
        Me.lablAreaS1 = New System.Windows.Forms.Label()
        Me.lablAreaS2 = New System.Windows.Forms.Label()
        Me.lablAreaS3 = New System.Windows.Forms.Label()
        Me.groupClock = New System.Windows.Forms.GroupBox()
        Me.btnPeriod0 = New System.Windows.Forms.Button()
        Me.btnPeriod8 = New System.Windows.Forms.Button()
        Me.btnPeriod7 = New System.Windows.Forms.Button()
        Me.btnPeriod6 = New System.Windows.Forms.Button()
        Me.btnPeriod5 = New System.Windows.Forms.Button()
        Me.btnPeriod4 = New System.Windows.Forms.Button()
        Me.btnPeriod3 = New System.Windows.Forms.Button()
        Me.btnPeriod2 = New System.Windows.Forms.Button()
        Me.btnPeriod1 = New System.Windows.Forms.Button()
        Me.btnPeriodEnable = New System.Windows.Forms.Button()
        Me.btnPossessionH = New System.Windows.Forms.Button()
        Me.btnPossessionA = New System.Windows.Forms.Button()
        Me.btnPossessionOOP = New System.Windows.Forms.Button()
        Me.btnAreaS3 = New System.Windows.Forms.Button()
        Me.btnAreaS2 = New System.Windows.Forms.Button()
        Me.btnAreaS1 = New System.Windows.Forms.Button()
        Me.lablHomeName2 = New System.Windows.Forms.Label()
        Me.lablAwayName2 = New System.Windows.Forms.Label()
        Me.lablAwayName3 = New System.Windows.Forms.Label()
        Me.lablHomeName3 = New System.Windows.Forms.Label()
        Me.lablPeriod = New System.Windows.Forms.Label()
        Me.groupViewTime = New System.Windows.Forms.GroupBox()
        Me.btnSwapDirection = New System.Windows.Forms.Button()
        Me.lablMatchTime = New System.Windows.Forms.Label()
        Me.btnClockNudgeDown = New System.Windows.Forms.Button()
        Me.btnClockNudgeUp = New System.Windows.Forms.Button()
        Me.lablTotalPossA = New System.Windows.Forms.Label()
        Me.lablTotalPossH = New System.Windows.Forms.Label()
        Me.btnLogGoal = New System.Windows.Forms.Button()
        Me.btnLogYC = New System.Windows.Forms.Button()
        Me.btnLogRC = New System.Windows.Forms.Button()
        Me.groupActionAreasSoccer = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lablViewS3 = New System.Windows.Forms.Label()
        Me.lablViewS1 = New System.Windows.Forms.Label()
        Me.lablViewS2 = New System.Windows.Forms.Label()
        Me.groupPossession = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lablViewOOP = New System.Windows.Forms.Label()
        Me.lablViewA = New System.Windows.Forms.Label()
        Me.lablViewH = New System.Windows.Forms.Label()
        Me.lablArrowHomeLR = New System.Windows.Forms.Label()
        Me.lablArrowHomeRL = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lablArrowAwayRL = New System.Windows.Forms.Label()
        Me.lablArrowAwayLR = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.LablConnected = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lablRemove = New System.Windows.Forms.Label()
        Me.timerCheckClock = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lablMatchID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearAllTeam = New System.Windows.Forms.Button()
        Me.btnResendTeam = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClearPlayerHome = New System.Windows.Forms.Button()
        Me.btnResendPlayerHome = New System.Windows.Forms.Button()
        Me.btnPlayer25H = New System.Windows.Forms.Button()
        Me.lablPlayerStatHeading15 = New System.Windows.Forms.Label()
        Me.lablPlayerStat15H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading14 = New System.Windows.Forms.Label()
        Me.lablPlayerStat14H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading13 = New System.Windows.Forms.Label()
        Me.lablPlayerStat13H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading12 = New System.Windows.Forms.Label()
        Me.lablPlayerStat12H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading11 = New System.Windows.Forms.Label()
        Me.lablPlayerStat11H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading10 = New System.Windows.Forms.Label()
        Me.lablPlayerStat10H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading09 = New System.Windows.Forms.Label()
        Me.lablPlayerStat09H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading08 = New System.Windows.Forms.Label()
        Me.lablPlayerStat08H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading07 = New System.Windows.Forms.Label()
        Me.lablPlayerStat07H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading06 = New System.Windows.Forms.Label()
        Me.lablPlayerStat06H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading05 = New System.Windows.Forms.Label()
        Me.lablPlayerStat05H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading04 = New System.Windows.Forms.Label()
        Me.lablPlayerStat04H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading03 = New System.Windows.Forms.Label()
        Me.lablPlayerStat03H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading02 = New System.Windows.Forms.Label()
        Me.lablPlayerStat02H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading01 = New System.Windows.Forms.Label()
        Me.lablPlayerStat01H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading30 = New System.Windows.Forms.Label()
        Me.lablPlayerStat30H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading29 = New System.Windows.Forms.Label()
        Me.lablPlayerStat29H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading28 = New System.Windows.Forms.Label()
        Me.lablPlayerStat28H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading27 = New System.Windows.Forms.Label()
        Me.lablPlayerStat27H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading26 = New System.Windows.Forms.Label()
        Me.lablPlayerStat26H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading25 = New System.Windows.Forms.Label()
        Me.lablPlayerStat25H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading24 = New System.Windows.Forms.Label()
        Me.lablPlayerStat24H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading23 = New System.Windows.Forms.Label()
        Me.lablPlayerStat23H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading22 = New System.Windows.Forms.Label()
        Me.lablPlayerStat22H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading21 = New System.Windows.Forms.Label()
        Me.lablPlayerStat21H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading20 = New System.Windows.Forms.Label()
        Me.lablPlayerStat20H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading19 = New System.Windows.Forms.Label()
        Me.lablPlayerStat19H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading18 = New System.Windows.Forms.Label()
        Me.lablPlayerStat18H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading17 = New System.Windows.Forms.Label()
        Me.lablPlayerStat17H = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading16 = New System.Windows.Forms.Label()
        Me.lablPlayerStat16H = New System.Windows.Forms.Label()
        Me.btnPlayer24H = New System.Windows.Forms.Button()
        Me.btnPlayer23H = New System.Windows.Forms.Button()
        Me.btnPlayer22H = New System.Windows.Forms.Button()
        Me.btnPlayer21H = New System.Windows.Forms.Button()
        Me.btnPlayer20H = New System.Windows.Forms.Button()
        Me.btnPlayer19H = New System.Windows.Forms.Button()
        Me.btnPlayer18H = New System.Windows.Forms.Button()
        Me.btnPlayer17H = New System.Windows.Forms.Button()
        Me.btnPlayer16H = New System.Windows.Forms.Button()
        Me.btnPlayer15H = New System.Windows.Forms.Button()
        Me.btnPlayer14H = New System.Windows.Forms.Button()
        Me.btnPlayer13H = New System.Windows.Forms.Button()
        Me.btnPlayer12H = New System.Windows.Forms.Button()
        Me.btnPlayer11H = New System.Windows.Forms.Button()
        Me.btnPlayer10H = New System.Windows.Forms.Button()
        Me.btnPlayer09H = New System.Windows.Forms.Button()
        Me.btnPlayer08H = New System.Windows.Forms.Button()
        Me.btnPlayer07H = New System.Windows.Forms.Button()
        Me.btnPlayer06H = New System.Windows.Forms.Button()
        Me.btnPlayer05H = New System.Windows.Forms.Button()
        Me.btnPlayer04H = New System.Windows.Forms.Button()
        Me.btnPlayer03H = New System.Windows.Forms.Button()
        Me.btnPlayer02H = New System.Windows.Forms.Button()
        Me.btnPlayer01H = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnClearPlayerAway = New System.Windows.Forms.Button()
        Me.btnResendPlayerAway = New System.Windows.Forms.Button()
        Me.btnPlayer25A = New System.Windows.Forms.Button()
        Me.lablPlayerStatHeading15A = New System.Windows.Forms.Label()
        Me.lablPlayerStat15A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading14A = New System.Windows.Forms.Label()
        Me.lablPlayerStat14A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading13A = New System.Windows.Forms.Label()
        Me.lablPlayerStat13A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading12A = New System.Windows.Forms.Label()
        Me.lablPlayerStat12A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading11A = New System.Windows.Forms.Label()
        Me.lablPlayerStat11A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading10A = New System.Windows.Forms.Label()
        Me.lablPlayerStat10A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading09A = New System.Windows.Forms.Label()
        Me.lablPlayerStat09A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading08A = New System.Windows.Forms.Label()
        Me.lablPlayerStat08A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading07A = New System.Windows.Forms.Label()
        Me.lablPlayerStat07A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading06A = New System.Windows.Forms.Label()
        Me.lablPlayerStat06A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading05A = New System.Windows.Forms.Label()
        Me.lablPlayerStat05A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading04A = New System.Windows.Forms.Label()
        Me.lablPlayerStat04A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading03A = New System.Windows.Forms.Label()
        Me.lablPlayerStat03A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading02A = New System.Windows.Forms.Label()
        Me.lablPlayerStat02A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading01A = New System.Windows.Forms.Label()
        Me.lablPlayerStat01A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading30A = New System.Windows.Forms.Label()
        Me.lablPlayerStat30A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading29A = New System.Windows.Forms.Label()
        Me.lablPlayerStat29A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading28A = New System.Windows.Forms.Label()
        Me.lablPlayerStat28A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading27A = New System.Windows.Forms.Label()
        Me.lablPlayerStat27A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading26A = New System.Windows.Forms.Label()
        Me.lablPlayerStat26A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading25A = New System.Windows.Forms.Label()
        Me.lablPlayerStat25A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading24A = New System.Windows.Forms.Label()
        Me.lablPlayerStat24A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading23A = New System.Windows.Forms.Label()
        Me.lablPlayerStat23A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading22A = New System.Windows.Forms.Label()
        Me.lablPlayerStat22A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading21A = New System.Windows.Forms.Label()
        Me.lablPlayerStat21A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading20A = New System.Windows.Forms.Label()
        Me.lablPlayerStat20A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading19A = New System.Windows.Forms.Label()
        Me.lablPlayerStat19A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading18A = New System.Windows.Forms.Label()
        Me.lablPlayerStat18A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading17A = New System.Windows.Forms.Label()
        Me.lablPlayerStat17A = New System.Windows.Forms.Label()
        Me.lablPlayerStatHeading16A = New System.Windows.Forms.Label()
        Me.lablPlayerStat16A = New System.Windows.Forms.Label()
        Me.btnPlayer24A = New System.Windows.Forms.Button()
        Me.btnPlayer23A = New System.Windows.Forms.Button()
        Me.btnPlayer22A = New System.Windows.Forms.Button()
        Me.btnPlayer21A = New System.Windows.Forms.Button()
        Me.btnPlayer20A = New System.Windows.Forms.Button()
        Me.btnPlayer19A = New System.Windows.Forms.Button()
        Me.btnPlayer18A = New System.Windows.Forms.Button()
        Me.btnPlayer17A = New System.Windows.Forms.Button()
        Me.btnPlayer16A = New System.Windows.Forms.Button()
        Me.btnPlayer15A = New System.Windows.Forms.Button()
        Me.btnPlayer14A = New System.Windows.Forms.Button()
        Me.btnPlayer13A = New System.Windows.Forms.Button()
        Me.btnPlayer12A = New System.Windows.Forms.Button()
        Me.btnPlayer11A = New System.Windows.Forms.Button()
        Me.btnPlayer10A = New System.Windows.Forms.Button()
        Me.btnPlayer09A = New System.Windows.Forms.Button()
        Me.btnPlayer08A = New System.Windows.Forms.Button()
        Me.btnPlayer07A = New System.Windows.Forms.Button()
        Me.btnPlayer06A = New System.Windows.Forms.Button()
        Me.btnPlayer05A = New System.Windows.Forms.Button()
        Me.btnPlayer04A = New System.Windows.Forms.Button()
        Me.btnPlayer03A = New System.Windows.Forms.Button()
        Me.btnPlayer02A = New System.Windows.Forms.Button()
        Me.btnPlayer01A = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.listViewSummaryHome = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.listViewsummaryAway = New System.Windows.Forms.ListView()
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader52 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader53 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader54 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader59 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader60 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader61 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader62 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader63 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader64 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabKickouts = New System.Windows.Forms.TabPage()
        Me.btnPitchShotGood = New System.Windows.Forms.Button()
        Me.btnPitchShotWide2 = New System.Windows.Forms.Button()
        Me.btnPitchShotGood3 = New System.Windows.Forms.Button()
        Me.btnPitchShotGood4 = New System.Windows.Forms.Button()
        Me.btnPitchShotGood2 = New System.Windows.Forms.Button()
        Me.lablPitchLogHeading3 = New System.Windows.Forms.Label()
        Me.lablPitchAway3 = New System.Windows.Forms.Label()
        Me.lablPitchHome3 = New System.Windows.Forms.Label()
        Me.btnPitchShotWide = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioLog4565 = New System.Windows.Forms.RadioButton()
        Me.radioLogFrees = New System.Windows.Forms.RadioButton()
        Me.radioLogKickouts = New System.Windows.Forms.RadioButton()
        Me.lablStepKickoutNum = New System.Windows.Forms.Label()
        Me.lablPitchLogHeading2 = New System.Windows.Forms.Label()
        Me.lablPitchLogHeading1 = New System.Windows.Forms.Label()
        Me.btnDeleteKickout = New System.Windows.Forms.Button()
        Me.btnStepKickouts = New System.Windows.Forms.Button()
        Me.lablPitchKickoutPrompt = New System.Windows.Forms.Label()
        Me.lablPitchRLArrow = New System.Windows.Forms.Label()
        Me.lablPitchAway1 = New System.Windows.Forms.Label()
        Me.lablPitchRLTeamName = New System.Windows.Forms.Label()
        Me.lablPitchHome1 = New System.Windows.Forms.Label()
        Me.lablPitchLRArrow = New System.Windows.Forms.Label()
        Me.lablPitchAway2 = New System.Windows.Forms.Label()
        Me.lablPitchLRTeamName = New System.Windows.Forms.Label()
        Me.lablPitchHome2 = New System.Windows.Forms.Label()
        Me.picBoxPitch = New System.Windows.Forms.PictureBox()
        Me.btnPitchAwayWin = New System.Windows.Forms.Button()
        Me.btnPitchHomeWin = New System.Windows.Forms.Button()
        Me.lablPitchAwayName = New System.Windows.Forms.Label()
        Me.lablPitchHomeName = New System.Windows.Forms.Label()
        Me.tabPenalties = New System.Windows.Forms.TabPage()
        Me.lablSelectedPenalty = New System.Windows.Forms.Label()
        Me.btnPenaltyDisplay2 = New System.Windows.Forms.Button()
        Me.btnAdvantageClear = New System.Windows.Forms.Button()
        Me.btnAdvantageAway = New System.Windows.Forms.Button()
        Me.btnAdvantageHome = New System.Windows.Forms.Button()
        Me.btnPenaltyClear = New System.Windows.Forms.Button()
        Me.btnPenaltyDisplay = New System.Windows.Forms.Button()
        Me.btnPenaltyName30 = New System.Windows.Forms.Button()
        Me.btnPenaltyName29 = New System.Windows.Forms.Button()
        Me.btnPenaltyName28 = New System.Windows.Forms.Button()
        Me.btnPenaltyName27 = New System.Windows.Forms.Button()
        Me.btnPenaltyName26 = New System.Windows.Forms.Button()
        Me.btnPenaltyName25 = New System.Windows.Forms.Button()
        Me.btnPenaltyName24 = New System.Windows.Forms.Button()
        Me.btnPenaltyName12 = New System.Windows.Forms.Button()
        Me.btnPenaltyName23 = New System.Windows.Forms.Button()
        Me.btnPenaltyName11 = New System.Windows.Forms.Button()
        Me.btnPenaltyName22 = New System.Windows.Forms.Button()
        Me.btnPenaltyName10 = New System.Windows.Forms.Button()
        Me.btnPenaltyName21 = New System.Windows.Forms.Button()
        Me.btnPenaltyName09 = New System.Windows.Forms.Button()
        Me.btnPenaltyName20 = New System.Windows.Forms.Button()
        Me.btnPenaltyName08 = New System.Windows.Forms.Button()
        Me.btnPenaltyName19 = New System.Windows.Forms.Button()
        Me.btnPenaltyName07 = New System.Windows.Forms.Button()
        Me.btnPenaltyName18 = New System.Windows.Forms.Button()
        Me.btnPenaltyName06 = New System.Windows.Forms.Button()
        Me.btnPenaltyName17 = New System.Windows.Forms.Button()
        Me.btnPenaltyName05 = New System.Windows.Forms.Button()
        Me.btnPenaltyName16 = New System.Windows.Forms.Button()
        Me.btnPenaltyName04 = New System.Windows.Forms.Button()
        Me.btnPenaltyName15 = New System.Windows.Forms.Button()
        Me.btnPenaltyName03 = New System.Windows.Forms.Button()
        Me.btnPenaltyName14 = New System.Windows.Forms.Button()
        Me.btnPenaltyName02 = New System.Windows.Forms.Button()
        Me.btnPenaltyName13 = New System.Windows.Forms.Button()
        Me.btnPenaltyName01 = New System.Windows.Forms.Button()
        Me.tabCarries = New System.Windows.Forms.TabPage()
        Me.listViewCarriesAway = New System.Windows.Forms.ListView()
        Me.ColumnHeader67 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader70 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lablAwayNameSL2 = New System.Windows.Forms.Label()
        Me.lablHomeNameSL2 = New System.Windows.Forms.Label()
        Me.listViewCarriesHome = New System.Windows.Forms.ListView()
        Me.ColumnHeader65 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader69 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader66 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.groupRemotePossession = New System.Windows.Forms.GroupBox()
        Me.lablRemoteAreaR3 = New System.Windows.Forms.Label()
        Me.lablRemoteAreaR2 = New System.Windows.Forms.Label()
        Me.lablRemoteAreaR1 = New System.Windows.Forms.Label()
        Me.lablRemoteAreaR4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lablRemoteInPlay = New System.Windows.Forms.Label()
        Me.lablRemoteMatchTime = New System.Windows.Forms.Label()
        Me.lablRemoteAwayTeam = New System.Windows.Forms.Label()
        Me.lablRemoteHomeTeam = New System.Windows.Forms.Label()
        Me.lablRemoteAreaS1 = New System.Windows.Forms.Label()
        Me.lablRemoteAreaS2 = New System.Windows.Forms.Label()
        Me.lablRemoteAreaS3 = New System.Windows.Forms.Label()
        Me.lablRemoteAwayPossession = New System.Windows.Forms.Label()
        Me.lablRemoteHomePossession = New System.Windows.Forms.Label()
        Me.timerCheckConnection = New System.Windows.Forms.Timer(Me.components)
        Me.groupActionAreasRugby = New System.Windows.Forms.GroupBox()
        Me.lablViewR4 = New System.Windows.Forms.Label()
        Me.lablAreaR4 = New System.Windows.Forms.Label()
        Me.btnAreaR4 = New System.Windows.Forms.Button()
        Me.lablAreaR1 = New System.Windows.Forms.Label()
        Me.lablViewR3 = New System.Windows.Forms.Label()
        Me.btnAreaR3 = New System.Windows.Forms.Button()
        Me.lablAreaR2 = New System.Windows.Forms.Label()
        Me.lablAreaR3 = New System.Windows.Forms.Label()
        Me.lablViewR1 = New System.Windows.Forms.Label()
        Me.btnAreaR1 = New System.Windows.Forms.Button()
        Me.lablViewR2 = New System.Windows.Forms.Label()
        Me.btnAreaR2 = New System.Windows.Forms.Button()
        Me.btnFetchStatNames = New System.Windows.Forms.Button()
        Me.panelSuperLeaguePro14 = New System.Windows.Forms.Panel()
        Me.lablAwayScoreSL = New System.Windows.Forms.Label()
        Me.lablHomeScoreSL = New System.Windows.Forms.Label()
        Me.btnClearSLPossession = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picBoxSLLogo = New System.Windows.Forms.PictureBox()
        Me.lablPeriodSL = New System.Windows.Forms.Label()
        Me.lablMatchClockSL = New System.Windows.Forms.Label()
        Me.btnPossessionHSL = New System.Windows.Forms.Button()
        Me.btnPossessionASL = New System.Windows.Forms.Button()
        Me.btnPossessionOOPSL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lablRemoteAwayPossessionSL = New System.Windows.Forms.Label()
        Me.lablRemoteHomePossessionSL = New System.Windows.Forms.Label()
        Me.lablAwayNameSL = New System.Windows.Forms.Label()
        Me.lablHomeNameSL = New System.Windows.Forms.Label()
        Me.picBoxPro14 = New System.Windows.Forms.PictureBox()
        Me.btnFetchRBStats = New System.Windows.Forms.Button()
        Me.btnFetchLiveMatch = New System.Windows.Forms.Button()
        Me.groupClock.SuspendLayout
        Me.groupViewTime.SuspendLayout
        Me.groupActionAreasSoccer.SuspendLayout
        Me.groupPossession.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.TabPage4.SuspendLayout
        Me.TabPage5.SuspendLayout
        Me.tabKickouts.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.picBoxPitch, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPenalties.SuspendLayout
        Me.tabCarries.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.groupRemotePossession.SuspendLayout
        Me.groupActionAreasRugby.SuspendLayout
        Me.panelSuperLeaguePro14.SuspendLayout
        CType(Me.picBoxSLLogo, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picBoxPro14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lablHeading01
        '
        Me.lablHeading01.BackColor = System.Drawing.Color.Black
        Me.lablHeading01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading01.ForeColor = System.Drawing.Color.White
        Me.lablHeading01.Location = New System.Drawing.Point(124, 20)
        Me.lablHeading01.Name = "lablHeading01"
        Me.lablHeading01.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading01.TabIndex = 2
        Me.lablHeading01.Text = "Kick Passes in own 45"
        Me.lablHeading01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat01H
        '
        Me.lablStat01H.BackColor = System.Drawing.Color.Navy
        Me.lablStat01H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat01H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat01H.ForeColor = System.Drawing.Color.White
        Me.lablStat01H.Location = New System.Drawing.Point(48, 20)
        Me.lablStat01H.Name = "lablStat01H"
        Me.lablStat01H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat01H.TabIndex = 3
        Me.lablStat01H.Tag = "H01"
        Me.lablStat01H.Text = "999"
        Me.lablStat01H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat01A
        '
        Me.lablStat01A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat01A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat01A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat01A.ForeColor = System.Drawing.Color.White
        Me.lablStat01A.Location = New System.Drawing.Point(268, 20)
        Me.lablStat01A.Name = "lablStat01A"
        Me.lablStat01A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat01A.TabIndex = 4
        Me.lablStat01A.Tag = "A01"
        Me.lablStat01A.Text = "999"
        Me.lablStat01A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat02A
        '
        Me.lablStat02A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat02A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat02A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat02A.ForeColor = System.Drawing.Color.White
        Me.lablStat02A.Location = New System.Drawing.Point(268, 64)
        Me.lablStat02A.Name = "lablStat02A"
        Me.lablStat02A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat02A.TabIndex = 7
        Me.lablStat02A.Tag = "A02"
        Me.lablStat02A.Text = "999"
        Me.lablStat02A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat02H
        '
        Me.lablStat02H.BackColor = System.Drawing.Color.Navy
        Me.lablStat02H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat02H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat02H.ForeColor = System.Drawing.Color.White
        Me.lablStat02H.Location = New System.Drawing.Point(48, 64)
        Me.lablStat02H.Name = "lablStat02H"
        Me.lablStat02H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat02H.TabIndex = 6
        Me.lablStat02H.Tag = "H02"
        Me.lablStat02H.Text = "999"
        Me.lablStat02H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading02
        '
        Me.lablHeading02.BackColor = System.Drawing.Color.Black
        Me.lablHeading02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading02.ForeColor = System.Drawing.Color.White
        Me.lablHeading02.Location = New System.Drawing.Point(124, 64)
        Me.lablHeading02.Name = "lablHeading02"
        Me.lablHeading02.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading02.TabIndex = 5
        Me.lablHeading02.Text = "Kick Passes in own 45"
        Me.lablHeading02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat03A
        '
        Me.lablStat03A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat03A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat03A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat03A.ForeColor = System.Drawing.Color.White
        Me.lablStat03A.Location = New System.Drawing.Point(268, 108)
        Me.lablStat03A.Name = "lablStat03A"
        Me.lablStat03A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat03A.TabIndex = 10
        Me.lablStat03A.Tag = "A03"
        Me.lablStat03A.Text = "999"
        Me.lablStat03A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat03H
        '
        Me.lablStat03H.BackColor = System.Drawing.Color.Navy
        Me.lablStat03H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat03H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat03H.ForeColor = System.Drawing.Color.White
        Me.lablStat03H.Location = New System.Drawing.Point(48, 108)
        Me.lablStat03H.Name = "lablStat03H"
        Me.lablStat03H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat03H.TabIndex = 9
        Me.lablStat03H.Tag = "H03"
        Me.lablStat03H.Text = "999"
        Me.lablStat03H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading03
        '
        Me.lablHeading03.BackColor = System.Drawing.Color.Black
        Me.lablHeading03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading03.ForeColor = System.Drawing.Color.White
        Me.lablHeading03.Location = New System.Drawing.Point(124, 108)
        Me.lablHeading03.Name = "lablHeading03"
        Me.lablHeading03.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading03.TabIndex = 8
        Me.lablHeading03.Text = "Kick Passes in own 45"
        Me.lablHeading03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat04A
        '
        Me.lablStat04A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat04A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat04A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat04A.ForeColor = System.Drawing.Color.White
        Me.lablStat04A.Location = New System.Drawing.Point(268, 152)
        Me.lablStat04A.Name = "lablStat04A"
        Me.lablStat04A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat04A.TabIndex = 13
        Me.lablStat04A.Tag = "A04"
        Me.lablStat04A.Text = "999"
        Me.lablStat04A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat04H
        '
        Me.lablStat04H.BackColor = System.Drawing.Color.Navy
        Me.lablStat04H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat04H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat04H.ForeColor = System.Drawing.Color.White
        Me.lablStat04H.Location = New System.Drawing.Point(48, 152)
        Me.lablStat04H.Name = "lablStat04H"
        Me.lablStat04H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat04H.TabIndex = 12
        Me.lablStat04H.Tag = "H04"
        Me.lablStat04H.Text = "999"
        Me.lablStat04H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading04
        '
        Me.lablHeading04.BackColor = System.Drawing.Color.Black
        Me.lablHeading04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading04.ForeColor = System.Drawing.Color.White
        Me.lablHeading04.Location = New System.Drawing.Point(124, 152)
        Me.lablHeading04.Name = "lablHeading04"
        Me.lablHeading04.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading04.TabIndex = 11
        Me.lablHeading04.Text = "Kick Passes in own 45"
        Me.lablHeading04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat05A
        '
        Me.lablStat05A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat05A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat05A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat05A.ForeColor = System.Drawing.Color.White
        Me.lablStat05A.Location = New System.Drawing.Point(268, 196)
        Me.lablStat05A.Name = "lablStat05A"
        Me.lablStat05A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat05A.TabIndex = 16
        Me.lablStat05A.Tag = "A05"
        Me.lablStat05A.Text = "999"
        Me.lablStat05A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat05H
        '
        Me.lablStat05H.BackColor = System.Drawing.Color.Navy
        Me.lablStat05H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat05H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat05H.ForeColor = System.Drawing.Color.White
        Me.lablStat05H.Location = New System.Drawing.Point(48, 196)
        Me.lablStat05H.Name = "lablStat05H"
        Me.lablStat05H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat05H.TabIndex = 15
        Me.lablStat05H.Tag = "H05"
        Me.lablStat05H.Text = "999"
        Me.lablStat05H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading05
        '
        Me.lablHeading05.BackColor = System.Drawing.Color.Black
        Me.lablHeading05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading05.ForeColor = System.Drawing.Color.White
        Me.lablHeading05.Location = New System.Drawing.Point(124, 196)
        Me.lablHeading05.Name = "lablHeading05"
        Me.lablHeading05.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading05.TabIndex = 14
        Me.lablHeading05.Text = "Kick Passes in own 45"
        Me.lablHeading05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat10A
        '
        Me.lablStat10A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat10A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat10A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat10A.ForeColor = System.Drawing.Color.White
        Me.lablStat10A.Location = New System.Drawing.Point(268, 416)
        Me.lablStat10A.Name = "lablStat10A"
        Me.lablStat10A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat10A.TabIndex = 31
        Me.lablStat10A.Tag = "A10"
        Me.lablStat10A.Text = "999"
        Me.lablStat10A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat10H
        '
        Me.lablStat10H.BackColor = System.Drawing.Color.Navy
        Me.lablStat10H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat10H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat10H.ForeColor = System.Drawing.Color.White
        Me.lablStat10H.Location = New System.Drawing.Point(48, 416)
        Me.lablStat10H.Name = "lablStat10H"
        Me.lablStat10H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat10H.TabIndex = 30
        Me.lablStat10H.Tag = "H10"
        Me.lablStat10H.Text = "999"
        Me.lablStat10H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading10
        '
        Me.lablHeading10.BackColor = System.Drawing.Color.Black
        Me.lablHeading10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading10.ForeColor = System.Drawing.Color.White
        Me.lablHeading10.Location = New System.Drawing.Point(124, 416)
        Me.lablHeading10.Name = "lablHeading10"
        Me.lablHeading10.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading10.TabIndex = 29
        Me.lablHeading10.Text = "Kick Passes in own 45"
        Me.lablHeading10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat09A
        '
        Me.lablStat09A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat09A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat09A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat09A.ForeColor = System.Drawing.Color.White
        Me.lablStat09A.Location = New System.Drawing.Point(268, 372)
        Me.lablStat09A.Name = "lablStat09A"
        Me.lablStat09A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat09A.TabIndex = 28
        Me.lablStat09A.Tag = "A09"
        Me.lablStat09A.Text = "999"
        Me.lablStat09A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat09H
        '
        Me.lablStat09H.BackColor = System.Drawing.Color.Navy
        Me.lablStat09H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat09H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat09H.ForeColor = System.Drawing.Color.White
        Me.lablStat09H.Location = New System.Drawing.Point(48, 372)
        Me.lablStat09H.Name = "lablStat09H"
        Me.lablStat09H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat09H.TabIndex = 27
        Me.lablStat09H.Tag = "H09"
        Me.lablStat09H.Text = "999"
        Me.lablStat09H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading09
        '
        Me.lablHeading09.BackColor = System.Drawing.Color.Black
        Me.lablHeading09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading09.ForeColor = System.Drawing.Color.White
        Me.lablHeading09.Location = New System.Drawing.Point(124, 372)
        Me.lablHeading09.Name = "lablHeading09"
        Me.lablHeading09.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading09.TabIndex = 26
        Me.lablHeading09.Text = "Kick Passes in own 45"
        Me.lablHeading09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat08A
        '
        Me.lablStat08A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat08A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat08A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat08A.ForeColor = System.Drawing.Color.White
        Me.lablStat08A.Location = New System.Drawing.Point(268, 328)
        Me.lablStat08A.Name = "lablStat08A"
        Me.lablStat08A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat08A.TabIndex = 25
        Me.lablStat08A.Tag = "A08"
        Me.lablStat08A.Text = "999"
        Me.lablStat08A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat08H
        '
        Me.lablStat08H.BackColor = System.Drawing.Color.Navy
        Me.lablStat08H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat08H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat08H.ForeColor = System.Drawing.Color.White
        Me.lablStat08H.Location = New System.Drawing.Point(48, 328)
        Me.lablStat08H.Name = "lablStat08H"
        Me.lablStat08H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat08H.TabIndex = 24
        Me.lablStat08H.Tag = "H08"
        Me.lablStat08H.Text = "999"
        Me.lablStat08H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading08
        '
        Me.lablHeading08.BackColor = System.Drawing.Color.Black
        Me.lablHeading08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading08.ForeColor = System.Drawing.Color.White
        Me.lablHeading08.Location = New System.Drawing.Point(124, 328)
        Me.lablHeading08.Name = "lablHeading08"
        Me.lablHeading08.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading08.TabIndex = 23
        Me.lablHeading08.Text = "Kick Passes in own 45"
        Me.lablHeading08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat07A
        '
        Me.lablStat07A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat07A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat07A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat07A.ForeColor = System.Drawing.Color.White
        Me.lablStat07A.Location = New System.Drawing.Point(268, 284)
        Me.lablStat07A.Name = "lablStat07A"
        Me.lablStat07A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat07A.TabIndex = 22
        Me.lablStat07A.Tag = "A07"
        Me.lablStat07A.Text = "999"
        Me.lablStat07A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat07H
        '
        Me.lablStat07H.BackColor = System.Drawing.Color.Navy
        Me.lablStat07H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat07H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat07H.ForeColor = System.Drawing.Color.White
        Me.lablStat07H.Location = New System.Drawing.Point(48, 284)
        Me.lablStat07H.Name = "lablStat07H"
        Me.lablStat07H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat07H.TabIndex = 21
        Me.lablStat07H.Tag = "H07"
        Me.lablStat07H.Text = "999"
        Me.lablStat07H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading07
        '
        Me.lablHeading07.BackColor = System.Drawing.Color.Black
        Me.lablHeading07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading07.ForeColor = System.Drawing.Color.White
        Me.lablHeading07.Location = New System.Drawing.Point(124, 284)
        Me.lablHeading07.Name = "lablHeading07"
        Me.lablHeading07.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading07.TabIndex = 20
        Me.lablHeading07.Text = "Kick Passes in own 45"
        Me.lablHeading07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat06A
        '
        Me.lablStat06A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat06A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat06A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat06A.ForeColor = System.Drawing.Color.White
        Me.lablStat06A.Location = New System.Drawing.Point(268, 240)
        Me.lablStat06A.Name = "lablStat06A"
        Me.lablStat06A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat06A.TabIndex = 19
        Me.lablStat06A.Tag = "A06"
        Me.lablStat06A.Text = "999"
        Me.lablStat06A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat06H
        '
        Me.lablStat06H.BackColor = System.Drawing.Color.Navy
        Me.lablStat06H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat06H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat06H.ForeColor = System.Drawing.Color.White
        Me.lablStat06H.Location = New System.Drawing.Point(48, 240)
        Me.lablStat06H.Name = "lablStat06H"
        Me.lablStat06H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat06H.TabIndex = 18
        Me.lablStat06H.Tag = "H06"
        Me.lablStat06H.Text = "999"
        Me.lablStat06H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading06
        '
        Me.lablHeading06.BackColor = System.Drawing.Color.Black
        Me.lablHeading06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading06.ForeColor = System.Drawing.Color.White
        Me.lablHeading06.Location = New System.Drawing.Point(124, 240)
        Me.lablHeading06.Name = "lablHeading06"
        Me.lablHeading06.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading06.TabIndex = 17
        Me.lablHeading06.Text = "Kick Passes in own 45"
        Me.lablHeading06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat30A
        '
        Me.lablStat30A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat30A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat30A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat30A.ForeColor = System.Drawing.Color.White
        Me.lablStat30A.Location = New System.Drawing.Point(632, 636)
        Me.lablStat30A.Name = "lablStat30A"
        Me.lablStat30A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat30A.TabIndex = 61
        Me.lablStat30A.Tag = "A30"
        Me.lablStat30A.Text = "999"
        Me.lablStat30A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat30H
        '
        Me.lablStat30H.BackColor = System.Drawing.Color.Navy
        Me.lablStat30H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat30H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat30H.ForeColor = System.Drawing.Color.White
        Me.lablStat30H.Location = New System.Drawing.Point(412, 636)
        Me.lablStat30H.Name = "lablStat30H"
        Me.lablStat30H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat30H.TabIndex = 60
        Me.lablStat30H.Tag = "H30"
        Me.lablStat30H.Text = "999"
        Me.lablStat30H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading30
        '
        Me.lablHeading30.BackColor = System.Drawing.Color.Black
        Me.lablHeading30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading30.ForeColor = System.Drawing.Color.White
        Me.lablHeading30.Location = New System.Drawing.Point(488, 636)
        Me.lablHeading30.Name = "lablHeading30"
        Me.lablHeading30.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading30.TabIndex = 59
        Me.lablHeading30.Text = "Kick Passes in own 45"
        Me.lablHeading30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat29A
        '
        Me.lablStat29A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat29A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat29A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat29A.ForeColor = System.Drawing.Color.White
        Me.lablStat29A.Location = New System.Drawing.Point(632, 592)
        Me.lablStat29A.Name = "lablStat29A"
        Me.lablStat29A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat29A.TabIndex = 58
        Me.lablStat29A.Tag = "A29"
        Me.lablStat29A.Text = "999"
        Me.lablStat29A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat29H
        '
        Me.lablStat29H.BackColor = System.Drawing.Color.Navy
        Me.lablStat29H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat29H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat29H.ForeColor = System.Drawing.Color.White
        Me.lablStat29H.Location = New System.Drawing.Point(412, 592)
        Me.lablStat29H.Name = "lablStat29H"
        Me.lablStat29H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat29H.TabIndex = 57
        Me.lablStat29H.Tag = "H29"
        Me.lablStat29H.Text = "999"
        Me.lablStat29H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading29
        '
        Me.lablHeading29.BackColor = System.Drawing.Color.Black
        Me.lablHeading29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading29.ForeColor = System.Drawing.Color.White
        Me.lablHeading29.Location = New System.Drawing.Point(488, 592)
        Me.lablHeading29.Name = "lablHeading29"
        Me.lablHeading29.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading29.TabIndex = 56
        Me.lablHeading29.Text = "Kick Passes in own 45"
        Me.lablHeading29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat28A
        '
        Me.lablStat28A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat28A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat28A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat28A.ForeColor = System.Drawing.Color.White
        Me.lablStat28A.Location = New System.Drawing.Point(632, 548)
        Me.lablStat28A.Name = "lablStat28A"
        Me.lablStat28A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat28A.TabIndex = 55
        Me.lablStat28A.Tag = "A28"
        Me.lablStat28A.Text = "999"
        Me.lablStat28A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat28H
        '
        Me.lablStat28H.BackColor = System.Drawing.Color.Navy
        Me.lablStat28H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat28H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat28H.ForeColor = System.Drawing.Color.White
        Me.lablStat28H.Location = New System.Drawing.Point(412, 548)
        Me.lablStat28H.Name = "lablStat28H"
        Me.lablStat28H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat28H.TabIndex = 54
        Me.lablStat28H.Tag = "H28"
        Me.lablStat28H.Text = "999"
        Me.lablStat28H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading28
        '
        Me.lablHeading28.BackColor = System.Drawing.Color.Black
        Me.lablHeading28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading28.ForeColor = System.Drawing.Color.White
        Me.lablHeading28.Location = New System.Drawing.Point(488, 548)
        Me.lablHeading28.Name = "lablHeading28"
        Me.lablHeading28.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading28.TabIndex = 53
        Me.lablHeading28.Text = "Kick Passes in own 45"
        Me.lablHeading28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat27A
        '
        Me.lablStat27A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat27A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat27A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat27A.ForeColor = System.Drawing.Color.White
        Me.lablStat27A.Location = New System.Drawing.Point(632, 504)
        Me.lablStat27A.Name = "lablStat27A"
        Me.lablStat27A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat27A.TabIndex = 52
        Me.lablStat27A.Tag = "A27"
        Me.lablStat27A.Text = "999"
        Me.lablStat27A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat27H
        '
        Me.lablStat27H.BackColor = System.Drawing.Color.Navy
        Me.lablStat27H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat27H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat27H.ForeColor = System.Drawing.Color.White
        Me.lablStat27H.Location = New System.Drawing.Point(412, 504)
        Me.lablStat27H.Name = "lablStat27H"
        Me.lablStat27H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat27H.TabIndex = 51
        Me.lablStat27H.Tag = "H27"
        Me.lablStat27H.Text = "999"
        Me.lablStat27H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading27
        '
        Me.lablHeading27.BackColor = System.Drawing.Color.Black
        Me.lablHeading27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading27.ForeColor = System.Drawing.Color.White
        Me.lablHeading27.Location = New System.Drawing.Point(488, 504)
        Me.lablHeading27.Name = "lablHeading27"
        Me.lablHeading27.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading27.TabIndex = 50
        Me.lablHeading27.Text = "Kick Passes in own 45"
        Me.lablHeading27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat26A
        '
        Me.lablStat26A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat26A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat26A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat26A.ForeColor = System.Drawing.Color.White
        Me.lablStat26A.Location = New System.Drawing.Point(632, 460)
        Me.lablStat26A.Name = "lablStat26A"
        Me.lablStat26A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat26A.TabIndex = 49
        Me.lablStat26A.Tag = "A26"
        Me.lablStat26A.Text = "999"
        Me.lablStat26A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat26H
        '
        Me.lablStat26H.BackColor = System.Drawing.Color.Navy
        Me.lablStat26H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat26H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat26H.ForeColor = System.Drawing.Color.White
        Me.lablStat26H.Location = New System.Drawing.Point(412, 460)
        Me.lablStat26H.Name = "lablStat26H"
        Me.lablStat26H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat26H.TabIndex = 48
        Me.lablStat26H.Tag = "H26"
        Me.lablStat26H.Text = "999"
        Me.lablStat26H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading26
        '
        Me.lablHeading26.BackColor = System.Drawing.Color.Black
        Me.lablHeading26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading26.ForeColor = System.Drawing.Color.White
        Me.lablHeading26.Location = New System.Drawing.Point(488, 460)
        Me.lablHeading26.Name = "lablHeading26"
        Me.lablHeading26.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading26.TabIndex = 47
        Me.lablHeading26.Text = "Kick Passes in own 45"
        Me.lablHeading26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat15A
        '
        Me.lablStat15A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat15A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat15A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat15A.ForeColor = System.Drawing.Color.White
        Me.lablStat15A.Location = New System.Drawing.Point(268, 636)
        Me.lablStat15A.Name = "lablStat15A"
        Me.lablStat15A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat15A.TabIndex = 46
        Me.lablStat15A.Tag = "A15"
        Me.lablStat15A.Text = "999"
        Me.lablStat15A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat15H
        '
        Me.lablStat15H.BackColor = System.Drawing.Color.Navy
        Me.lablStat15H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat15H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat15H.ForeColor = System.Drawing.Color.White
        Me.lablStat15H.Location = New System.Drawing.Point(48, 636)
        Me.lablStat15H.Name = "lablStat15H"
        Me.lablStat15H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat15H.TabIndex = 45
        Me.lablStat15H.Tag = "H15"
        Me.lablStat15H.Text = "999"
        Me.lablStat15H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading15
        '
        Me.lablHeading15.BackColor = System.Drawing.Color.Black
        Me.lablHeading15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading15.ForeColor = System.Drawing.Color.White
        Me.lablHeading15.Location = New System.Drawing.Point(124, 636)
        Me.lablHeading15.Name = "lablHeading15"
        Me.lablHeading15.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading15.TabIndex = 44
        Me.lablHeading15.Text = "Kick Passes in own 45"
        Me.lablHeading15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat14A
        '
        Me.lablStat14A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat14A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat14A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat14A.ForeColor = System.Drawing.Color.White
        Me.lablStat14A.Location = New System.Drawing.Point(268, 592)
        Me.lablStat14A.Name = "lablStat14A"
        Me.lablStat14A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat14A.TabIndex = 43
        Me.lablStat14A.Tag = "A14"
        Me.lablStat14A.Text = "999"
        Me.lablStat14A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat14H
        '
        Me.lablStat14H.BackColor = System.Drawing.Color.Navy
        Me.lablStat14H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat14H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat14H.ForeColor = System.Drawing.Color.White
        Me.lablStat14H.Location = New System.Drawing.Point(48, 592)
        Me.lablStat14H.Name = "lablStat14H"
        Me.lablStat14H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat14H.TabIndex = 42
        Me.lablStat14H.Tag = "H14"
        Me.lablStat14H.Text = "999"
        Me.lablStat14H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading14
        '
        Me.lablHeading14.BackColor = System.Drawing.Color.Black
        Me.lablHeading14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading14.ForeColor = System.Drawing.Color.White
        Me.lablHeading14.Location = New System.Drawing.Point(124, 592)
        Me.lablHeading14.Name = "lablHeading14"
        Me.lablHeading14.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading14.TabIndex = 41
        Me.lablHeading14.Text = "Kick Passes in own 45"
        Me.lablHeading14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat13A
        '
        Me.lablStat13A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat13A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat13A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat13A.ForeColor = System.Drawing.Color.White
        Me.lablStat13A.Location = New System.Drawing.Point(268, 548)
        Me.lablStat13A.Name = "lablStat13A"
        Me.lablStat13A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat13A.TabIndex = 40
        Me.lablStat13A.Tag = "A13"
        Me.lablStat13A.Text = "999"
        Me.lablStat13A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat13H
        '
        Me.lablStat13H.BackColor = System.Drawing.Color.Navy
        Me.lablStat13H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat13H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat13H.ForeColor = System.Drawing.Color.White
        Me.lablStat13H.Location = New System.Drawing.Point(48, 548)
        Me.lablStat13H.Name = "lablStat13H"
        Me.lablStat13H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat13H.TabIndex = 39
        Me.lablStat13H.Tag = "H13"
        Me.lablStat13H.Text = "999"
        Me.lablStat13H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading13
        '
        Me.lablHeading13.BackColor = System.Drawing.Color.Black
        Me.lablHeading13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading13.ForeColor = System.Drawing.Color.White
        Me.lablHeading13.Location = New System.Drawing.Point(124, 548)
        Me.lablHeading13.Name = "lablHeading13"
        Me.lablHeading13.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading13.TabIndex = 38
        Me.lablHeading13.Text = "Kick Passes in own 45"
        Me.lablHeading13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat12A
        '
        Me.lablStat12A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat12A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat12A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat12A.ForeColor = System.Drawing.Color.White
        Me.lablStat12A.Location = New System.Drawing.Point(268, 504)
        Me.lablStat12A.Name = "lablStat12A"
        Me.lablStat12A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat12A.TabIndex = 37
        Me.lablStat12A.Tag = "A12"
        Me.lablStat12A.Text = "999"
        Me.lablStat12A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat12H
        '
        Me.lablStat12H.BackColor = System.Drawing.Color.Navy
        Me.lablStat12H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat12H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat12H.ForeColor = System.Drawing.Color.White
        Me.lablStat12H.Location = New System.Drawing.Point(48, 504)
        Me.lablStat12H.Name = "lablStat12H"
        Me.lablStat12H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat12H.TabIndex = 36
        Me.lablStat12H.Tag = "H12"
        Me.lablStat12H.Text = "999"
        Me.lablStat12H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading12
        '
        Me.lablHeading12.BackColor = System.Drawing.Color.Black
        Me.lablHeading12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading12.ForeColor = System.Drawing.Color.White
        Me.lablHeading12.Location = New System.Drawing.Point(124, 504)
        Me.lablHeading12.Name = "lablHeading12"
        Me.lablHeading12.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading12.TabIndex = 35
        Me.lablHeading12.Text = "Kick Passes in own 45"
        Me.lablHeading12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat11A
        '
        Me.lablStat11A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat11A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat11A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat11A.ForeColor = System.Drawing.Color.White
        Me.lablStat11A.Location = New System.Drawing.Point(268, 460)
        Me.lablStat11A.Name = "lablStat11A"
        Me.lablStat11A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat11A.TabIndex = 34
        Me.lablStat11A.Tag = "A11"
        Me.lablStat11A.Text = "999"
        Me.lablStat11A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat11H
        '
        Me.lablStat11H.BackColor = System.Drawing.Color.Navy
        Me.lablStat11H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat11H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat11H.ForeColor = System.Drawing.Color.White
        Me.lablStat11H.Location = New System.Drawing.Point(48, 460)
        Me.lablStat11H.Name = "lablStat11H"
        Me.lablStat11H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat11H.TabIndex = 33
        Me.lablStat11H.Tag = "H11"
        Me.lablStat11H.Text = "999"
        Me.lablStat11H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading11
        '
        Me.lablHeading11.BackColor = System.Drawing.Color.Black
        Me.lablHeading11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading11.ForeColor = System.Drawing.Color.White
        Me.lablHeading11.Location = New System.Drawing.Point(124, 460)
        Me.lablHeading11.Name = "lablHeading11"
        Me.lablHeading11.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading11.TabIndex = 32
        Me.lablHeading11.Text = "Kick Passes in own 45"
        Me.lablHeading11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat25A
        '
        Me.lablStat25A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat25A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat25A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat25A.ForeColor = System.Drawing.Color.White
        Me.lablStat25A.Location = New System.Drawing.Point(632, 416)
        Me.lablStat25A.Name = "lablStat25A"
        Me.lablStat25A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat25A.TabIndex = 91
        Me.lablStat25A.Tag = "A25"
        Me.lablStat25A.Text = "999"
        Me.lablStat25A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat25H
        '
        Me.lablStat25H.BackColor = System.Drawing.Color.Navy
        Me.lablStat25H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat25H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat25H.ForeColor = System.Drawing.Color.White
        Me.lablStat25H.Location = New System.Drawing.Point(412, 416)
        Me.lablStat25H.Name = "lablStat25H"
        Me.lablStat25H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat25H.TabIndex = 90
        Me.lablStat25H.Tag = "H25"
        Me.lablStat25H.Text = "999"
        Me.lablStat25H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading25
        '
        Me.lablHeading25.BackColor = System.Drawing.Color.Black
        Me.lablHeading25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading25.ForeColor = System.Drawing.Color.White
        Me.lablHeading25.Location = New System.Drawing.Point(488, 416)
        Me.lablHeading25.Name = "lablHeading25"
        Me.lablHeading25.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading25.TabIndex = 89
        Me.lablHeading25.Text = "Kick Passes in own 45"
        Me.lablHeading25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat24A
        '
        Me.lablStat24A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat24A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat24A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat24A.ForeColor = System.Drawing.Color.White
        Me.lablStat24A.Location = New System.Drawing.Point(632, 372)
        Me.lablStat24A.Name = "lablStat24A"
        Me.lablStat24A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat24A.TabIndex = 88
        Me.lablStat24A.Tag = "A24"
        Me.lablStat24A.Text = "999"
        Me.lablStat24A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat24H
        '
        Me.lablStat24H.BackColor = System.Drawing.Color.Navy
        Me.lablStat24H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat24H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat24H.ForeColor = System.Drawing.Color.White
        Me.lablStat24H.Location = New System.Drawing.Point(412, 372)
        Me.lablStat24H.Name = "lablStat24H"
        Me.lablStat24H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat24H.TabIndex = 87
        Me.lablStat24H.Tag = "H24"
        Me.lablStat24H.Text = "999"
        Me.lablStat24H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading24
        '
        Me.lablHeading24.BackColor = System.Drawing.Color.Black
        Me.lablHeading24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading24.ForeColor = System.Drawing.Color.White
        Me.lablHeading24.Location = New System.Drawing.Point(488, 372)
        Me.lablHeading24.Name = "lablHeading24"
        Me.lablHeading24.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading24.TabIndex = 86
        Me.lablHeading24.Text = "Kick Passes in own 45"
        Me.lablHeading24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat23A
        '
        Me.lablStat23A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat23A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat23A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat23A.ForeColor = System.Drawing.Color.White
        Me.lablStat23A.Location = New System.Drawing.Point(632, 328)
        Me.lablStat23A.Name = "lablStat23A"
        Me.lablStat23A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat23A.TabIndex = 85
        Me.lablStat23A.Tag = "A23"
        Me.lablStat23A.Text = "999"
        Me.lablStat23A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat23H
        '
        Me.lablStat23H.BackColor = System.Drawing.Color.Navy
        Me.lablStat23H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat23H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat23H.ForeColor = System.Drawing.Color.White
        Me.lablStat23H.Location = New System.Drawing.Point(412, 328)
        Me.lablStat23H.Name = "lablStat23H"
        Me.lablStat23H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat23H.TabIndex = 84
        Me.lablStat23H.Tag = "H23"
        Me.lablStat23H.Text = "999"
        Me.lablStat23H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading23
        '
        Me.lablHeading23.BackColor = System.Drawing.Color.Black
        Me.lablHeading23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading23.ForeColor = System.Drawing.Color.White
        Me.lablHeading23.Location = New System.Drawing.Point(488, 328)
        Me.lablHeading23.Name = "lablHeading23"
        Me.lablHeading23.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading23.TabIndex = 83
        Me.lablHeading23.Text = "Kick Passes in own 45"
        Me.lablHeading23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat22A
        '
        Me.lablStat22A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat22A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat22A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat22A.ForeColor = System.Drawing.Color.White
        Me.lablStat22A.Location = New System.Drawing.Point(632, 284)
        Me.lablStat22A.Name = "lablStat22A"
        Me.lablStat22A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat22A.TabIndex = 82
        Me.lablStat22A.Tag = "A22"
        Me.lablStat22A.Text = "999"
        Me.lablStat22A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat22H
        '
        Me.lablStat22H.BackColor = System.Drawing.Color.Navy
        Me.lablStat22H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat22H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat22H.ForeColor = System.Drawing.Color.White
        Me.lablStat22H.Location = New System.Drawing.Point(412, 284)
        Me.lablStat22H.Name = "lablStat22H"
        Me.lablStat22H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat22H.TabIndex = 81
        Me.lablStat22H.Tag = "H22"
        Me.lablStat22H.Text = "999"
        Me.lablStat22H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading22
        '
        Me.lablHeading22.BackColor = System.Drawing.Color.Black
        Me.lablHeading22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading22.ForeColor = System.Drawing.Color.White
        Me.lablHeading22.Location = New System.Drawing.Point(488, 284)
        Me.lablHeading22.Name = "lablHeading22"
        Me.lablHeading22.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading22.TabIndex = 80
        Me.lablHeading22.Text = "Kick Passes in own 45"
        Me.lablHeading22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat21A
        '
        Me.lablStat21A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat21A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat21A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat21A.ForeColor = System.Drawing.Color.White
        Me.lablStat21A.Location = New System.Drawing.Point(632, 240)
        Me.lablStat21A.Name = "lablStat21A"
        Me.lablStat21A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat21A.TabIndex = 79
        Me.lablStat21A.Tag = "A21"
        Me.lablStat21A.Text = "999"
        Me.lablStat21A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat21H
        '
        Me.lablStat21H.BackColor = System.Drawing.Color.Navy
        Me.lablStat21H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat21H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat21H.ForeColor = System.Drawing.Color.White
        Me.lablStat21H.Location = New System.Drawing.Point(412, 240)
        Me.lablStat21H.Name = "lablStat21H"
        Me.lablStat21H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat21H.TabIndex = 78
        Me.lablStat21H.Tag = "H21"
        Me.lablStat21H.Text = "999"
        Me.lablStat21H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading21
        '
        Me.lablHeading21.BackColor = System.Drawing.Color.Black
        Me.lablHeading21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading21.ForeColor = System.Drawing.Color.White
        Me.lablHeading21.Location = New System.Drawing.Point(488, 240)
        Me.lablHeading21.Name = "lablHeading21"
        Me.lablHeading21.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading21.TabIndex = 77
        Me.lablHeading21.Text = "Kick Passes in own 45"
        Me.lablHeading21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat20A
        '
        Me.lablStat20A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat20A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat20A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat20A.ForeColor = System.Drawing.Color.White
        Me.lablStat20A.Location = New System.Drawing.Point(632, 196)
        Me.lablStat20A.Name = "lablStat20A"
        Me.lablStat20A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat20A.TabIndex = 76
        Me.lablStat20A.Tag = "A20"
        Me.lablStat20A.Text = "999"
        Me.lablStat20A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat20H
        '
        Me.lablStat20H.BackColor = System.Drawing.Color.Navy
        Me.lablStat20H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat20H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat20H.ForeColor = System.Drawing.Color.White
        Me.lablStat20H.Location = New System.Drawing.Point(412, 196)
        Me.lablStat20H.Name = "lablStat20H"
        Me.lablStat20H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat20H.TabIndex = 75
        Me.lablStat20H.Tag = "H20"
        Me.lablStat20H.Text = "999"
        Me.lablStat20H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading20
        '
        Me.lablHeading20.BackColor = System.Drawing.Color.Black
        Me.lablHeading20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading20.ForeColor = System.Drawing.Color.White
        Me.lablHeading20.Location = New System.Drawing.Point(488, 196)
        Me.lablHeading20.Name = "lablHeading20"
        Me.lablHeading20.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading20.TabIndex = 74
        Me.lablHeading20.Text = "Kick Passes in own 45"
        Me.lablHeading20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat19A
        '
        Me.lablStat19A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat19A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat19A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat19A.ForeColor = System.Drawing.Color.White
        Me.lablStat19A.Location = New System.Drawing.Point(632, 152)
        Me.lablStat19A.Name = "lablStat19A"
        Me.lablStat19A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat19A.TabIndex = 73
        Me.lablStat19A.Tag = "A19"
        Me.lablStat19A.Text = "999"
        Me.lablStat19A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat19H
        '
        Me.lablStat19H.BackColor = System.Drawing.Color.Navy
        Me.lablStat19H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat19H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat19H.ForeColor = System.Drawing.Color.White
        Me.lablStat19H.Location = New System.Drawing.Point(412, 152)
        Me.lablStat19H.Name = "lablStat19H"
        Me.lablStat19H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat19H.TabIndex = 72
        Me.lablStat19H.Tag = "H19"
        Me.lablStat19H.Text = "999"
        Me.lablStat19H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading19
        '
        Me.lablHeading19.BackColor = System.Drawing.Color.Black
        Me.lablHeading19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading19.ForeColor = System.Drawing.Color.White
        Me.lablHeading19.Location = New System.Drawing.Point(488, 152)
        Me.lablHeading19.Name = "lablHeading19"
        Me.lablHeading19.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading19.TabIndex = 71
        Me.lablHeading19.Text = "Kick Passes in own 45"
        Me.lablHeading19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat18A
        '
        Me.lablStat18A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat18A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat18A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat18A.ForeColor = System.Drawing.Color.White
        Me.lablStat18A.Location = New System.Drawing.Point(632, 108)
        Me.lablStat18A.Name = "lablStat18A"
        Me.lablStat18A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat18A.TabIndex = 70
        Me.lablStat18A.Tag = "A18"
        Me.lablStat18A.Text = "999"
        Me.lablStat18A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat18H
        '
        Me.lablStat18H.BackColor = System.Drawing.Color.Navy
        Me.lablStat18H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat18H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat18H.ForeColor = System.Drawing.Color.White
        Me.lablStat18H.Location = New System.Drawing.Point(412, 108)
        Me.lablStat18H.Name = "lablStat18H"
        Me.lablStat18H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat18H.TabIndex = 69
        Me.lablStat18H.Tag = "H18"
        Me.lablStat18H.Text = "999"
        Me.lablStat18H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading18
        '
        Me.lablHeading18.BackColor = System.Drawing.Color.Black
        Me.lablHeading18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading18.ForeColor = System.Drawing.Color.White
        Me.lablHeading18.Location = New System.Drawing.Point(488, 108)
        Me.lablHeading18.Name = "lablHeading18"
        Me.lablHeading18.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading18.TabIndex = 68
        Me.lablHeading18.Text = "Kick Passes in own 45"
        Me.lablHeading18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat17A
        '
        Me.lablStat17A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat17A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat17A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat17A.ForeColor = System.Drawing.Color.White
        Me.lablStat17A.Location = New System.Drawing.Point(632, 64)
        Me.lablStat17A.Name = "lablStat17A"
        Me.lablStat17A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat17A.TabIndex = 67
        Me.lablStat17A.Tag = "A17"
        Me.lablStat17A.Text = "999"
        Me.lablStat17A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat17H
        '
        Me.lablStat17H.BackColor = System.Drawing.Color.Navy
        Me.lablStat17H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat17H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat17H.ForeColor = System.Drawing.Color.White
        Me.lablStat17H.Location = New System.Drawing.Point(412, 64)
        Me.lablStat17H.Name = "lablStat17H"
        Me.lablStat17H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat17H.TabIndex = 66
        Me.lablStat17H.Tag = "H17"
        Me.lablStat17H.Text = "999"
        Me.lablStat17H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading17
        '
        Me.lablHeading17.BackColor = System.Drawing.Color.Black
        Me.lablHeading17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading17.ForeColor = System.Drawing.Color.White
        Me.lablHeading17.Location = New System.Drawing.Point(488, 64)
        Me.lablHeading17.Name = "lablHeading17"
        Me.lablHeading17.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading17.TabIndex = 65
        Me.lablHeading17.Text = "Kick Passes in own 45"
        Me.lablHeading17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat16A
        '
        Me.lablStat16A.BackColor = System.Drawing.Color.DarkGreen
        Me.lablStat16A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat16A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat16A.ForeColor = System.Drawing.Color.White
        Me.lablStat16A.Location = New System.Drawing.Point(632, 20)
        Me.lablStat16A.Name = "lablStat16A"
        Me.lablStat16A.Size = New System.Drawing.Size(76, 40)
        Me.lablStat16A.TabIndex = 64
        Me.lablStat16A.Tag = "A16"
        Me.lablStat16A.Text = "999"
        Me.lablStat16A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablStat16H
        '
        Me.lablStat16H.BackColor = System.Drawing.Color.Navy
        Me.lablStat16H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablStat16H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStat16H.ForeColor = System.Drawing.Color.White
        Me.lablStat16H.Location = New System.Drawing.Point(412, 20)
        Me.lablStat16H.Name = "lablStat16H"
        Me.lablStat16H.Size = New System.Drawing.Size(76, 40)
        Me.lablStat16H.TabIndex = 63
        Me.lablStat16H.Tag = "H16"
        Me.lablStat16H.Text = "999"
        Me.lablStat16H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHeading16
        '
        Me.lablHeading16.BackColor = System.Drawing.Color.Black
        Me.lablHeading16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHeading16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHeading16.ForeColor = System.Drawing.Color.White
        Me.lablHeading16.Location = New System.Drawing.Point(488, 20)
        Me.lablHeading16.Name = "lablHeading16"
        Me.lablHeading16.Size = New System.Drawing.Size(144, 40)
        Me.lablHeading16.TabIndex = 62
        Me.lablHeading16.Text = "Kick Passes in own 45"
        Me.lablHeading16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAwayName
        '
        Me.lablAwayName.BackColor = System.Drawing.Color.DarkGreen
        Me.lablAwayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAwayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayName.ForeColor = System.Drawing.Color.White
        Me.lablAwayName.Location = New System.Drawing.Point(1080, 36)
        Me.lablAwayName.Name = "lablAwayName"
        Me.lablAwayName.Size = New System.Drawing.Size(232, 32)
        Me.lablAwayName.TabIndex = 93
        Me.lablAwayName.Text = "WEST BROM"
        Me.lablAwayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHomeName
        '
        Me.lablHomeName.BackColor = System.Drawing.Color.Navy
        Me.lablHomeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHomeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeName.ForeColor = System.Drawing.Color.White
        Me.lablHomeName.Location = New System.Drawing.Point(1080, 4)
        Me.lablHomeName.Name = "lablHomeName"
        Me.lablHomeName.Size = New System.Drawing.Size(232, 32)
        Me.lablHomeName.TabIndex = 92
        Me.lablHomeName.Text = "TOTTENHAM"
        Me.lablHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.Gold
        Me.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.Black
        Me.Label93.Location = New System.Drawing.Point(12, 24)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(96, 20)
        Me.Label93.TabIndex = 94
        Me.Label93.Text = "Period Time"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.Gold
        Me.Label94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(12, 88)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(96, 20)
        Me.Label94.TabIndex = 95
        Me.Label94.Text = "Ball in Play"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablMatchTime2
        '
        Me.lablMatchTime2.BackColor = System.Drawing.Color.White
        Me.lablMatchTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablMatchTime2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablMatchTime2.ForeColor = System.Drawing.Color.Black
        Me.lablMatchTime2.Location = New System.Drawing.Point(12, 44)
        Me.lablMatchTime2.Name = "lablMatchTime2"
        Me.lablMatchTime2.Size = New System.Drawing.Size(96, 40)
        Me.lablMatchTime2.TabIndex = 97
        Me.lablMatchTime2.Text = "33:00"
        Me.lablMatchTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablInPlay
        '
        Me.lablInPlay.BackColor = System.Drawing.Color.White
        Me.lablInPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablInPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablInPlay.ForeColor = System.Drawing.Color.Black
        Me.lablInPlay.Location = New System.Drawing.Point(12, 108)
        Me.lablInPlay.Name = "lablInPlay"
        Me.lablInPlay.Size = New System.Drawing.Size(96, 40)
        Me.lablInPlay.TabIndex = 98
        Me.lablInPlay.Text = "22:00"
        Me.lablInPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPossessionA
        '
        Me.lablPossessionA.BackColor = System.Drawing.Color.White
        Me.lablPossessionA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPossessionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPossessionA.ForeColor = System.Drawing.Color.Black
        Me.lablPossessionA.Location = New System.Drawing.Point(108, 80)
        Me.lablPossessionA.Name = "lablPossessionA"
        Me.lablPossessionA.Size = New System.Drawing.Size(96, 28)
        Me.lablPossessionA.TabIndex = 100
        Me.lablPossessionA.Tag = "2"
        Me.lablPossessionA.Text = "50%"
        Me.lablPossessionA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPossessionH
        '
        Me.lablPossessionH.BackColor = System.Drawing.Color.White
        Me.lablPossessionH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPossessionH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPossessionH.ForeColor = System.Drawing.Color.Black
        Me.lablPossessionH.Location = New System.Drawing.Point(8, 80)
        Me.lablPossessionH.Name = "lablPossessionH"
        Me.lablPossessionH.Size = New System.Drawing.Size(96, 28)
        Me.lablPossessionH.TabIndex = 99
        Me.lablPossessionH.Tag = "1"
        Me.lablPossessionH.Text = "50%"
        Me.lablPossessionH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAreaS1
        '
        Me.lablAreaS1.BackColor = System.Drawing.Color.White
        Me.lablAreaS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaS1.ForeColor = System.Drawing.Color.Black
        Me.lablAreaS1.Location = New System.Drawing.Point(8, 80)
        Me.lablAreaS1.Name = "lablAreaS1"
        Me.lablAreaS1.Size = New System.Drawing.Size(96, 28)
        Me.lablAreaS1.TabIndex = 105
        Me.lablAreaS1.Tag = "1"
        Me.lablAreaS1.Text = "100%"
        Me.lablAreaS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAreaS2
        '
        Me.lablAreaS2.BackColor = System.Drawing.Color.White
        Me.lablAreaS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaS2.ForeColor = System.Drawing.Color.Black
        Me.lablAreaS2.Location = New System.Drawing.Point(108, 80)
        Me.lablAreaS2.Name = "lablAreaS2"
        Me.lablAreaS2.Size = New System.Drawing.Size(96, 28)
        Me.lablAreaS2.TabIndex = 106
        Me.lablAreaS2.Tag = "2"
        Me.lablAreaS2.Text = "100%"
        Me.lablAreaS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAreaS3
        '
        Me.lablAreaS3.BackColor = System.Drawing.Color.White
        Me.lablAreaS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaS3.ForeColor = System.Drawing.Color.Black
        Me.lablAreaS3.Location = New System.Drawing.Point(208, 80)
        Me.lablAreaS3.Name = "lablAreaS3"
        Me.lablAreaS3.Size = New System.Drawing.Size(96, 28)
        Me.lablAreaS3.TabIndex = 107
        Me.lablAreaS3.Tag = "3"
        Me.lablAreaS3.Text = "100%"
        Me.lablAreaS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupClock
        '
        Me.groupClock.Controls.Add(Me.btnPeriod0)
        Me.groupClock.Controls.Add(Me.btnPeriod8)
        Me.groupClock.Controls.Add(Me.btnPeriod7)
        Me.groupClock.Controls.Add(Me.btnPeriod6)
        Me.groupClock.Controls.Add(Me.btnPeriod5)
        Me.groupClock.Controls.Add(Me.btnPeriod4)
        Me.groupClock.Controls.Add(Me.btnPeriod3)
        Me.groupClock.Controls.Add(Me.btnPeriod2)
        Me.groupClock.Controls.Add(Me.btnPeriod1)
        Me.groupClock.Controls.Add(Me.btnPeriodEnable)
        Me.groupClock.ForeColor = System.Drawing.Color.White
        Me.groupClock.Location = New System.Drawing.Point(1168, 108)
        Me.groupClock.Name = "groupClock"
        Me.groupClock.Size = New System.Drawing.Size(184, 308)
        Me.groupClock.TabIndex = 108
        Me.groupClock.TabStop = False
        Me.groupClock.Text = "Clock"
        '
        'btnPeriod0
        '
        Me.btnPeriod0.BackColor = System.Drawing.Color.White
        Me.btnPeriod0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod0.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod0.Location = New System.Drawing.Point(12, 80)
        Me.btnPeriod0.Name = "btnPeriod0"
        Me.btnPeriod0.Size = New System.Drawing.Size(160, 40)
        Me.btnPeriod0.TabIndex = 9
        Me.btnPeriod0.Tag = "0"
        Me.btnPeriod0.Text = "Pre Match"
        Me.btnPeriod0.UseVisualStyleBackColor = False
        '
        'btnPeriod8
        '
        Me.btnPeriod8.BackColor = System.Drawing.Color.Pink
        Me.btnPeriod8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod8.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod8.Location = New System.Drawing.Point(96, 256)
        Me.btnPeriod8.Name = "btnPeriod8"
        Me.btnPeriod8.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod8.TabIndex = 8
        Me.btnPeriod8.Tag = "8"
        Me.btnPeriod8.Text = "End  ET2"
        Me.btnPeriod8.UseVisualStyleBackColor = False
        '
        'btnPeriod7
        '
        Me.btnPeriod7.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPeriod7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod7.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod7.Location = New System.Drawing.Point(96, 212)
        Me.btnPeriod7.Name = "btnPeriod7"
        Me.btnPeriod7.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod7.TabIndex = 7
        Me.btnPeriod7.Tag = "7"
        Me.btnPeriod7.Text = "Start ET2"
        Me.btnPeriod7.UseVisualStyleBackColor = False
        '
        'btnPeriod6
        '
        Me.btnPeriod6.BackColor = System.Drawing.Color.Pink
        Me.btnPeriod6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod6.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod6.Location = New System.Drawing.Point(96, 168)
        Me.btnPeriod6.Name = "btnPeriod6"
        Me.btnPeriod6.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod6.TabIndex = 6
        Me.btnPeriod6.Tag = "6"
        Me.btnPeriod6.Text = "End  ET1"
        Me.btnPeriod6.UseVisualStyleBackColor = False
        '
        'btnPeriod5
        '
        Me.btnPeriod5.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPeriod5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod5.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod5.Location = New System.Drawing.Point(96, 124)
        Me.btnPeriod5.Name = "btnPeriod5"
        Me.btnPeriod5.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod5.TabIndex = 5
        Me.btnPeriod5.Tag = "5"
        Me.btnPeriod5.Text = "Start ET1"
        Me.btnPeriod5.UseVisualStyleBackColor = False
        '
        'btnPeriod4
        '
        Me.btnPeriod4.BackColor = System.Drawing.Color.Pink
        Me.btnPeriod4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod4.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod4.Location = New System.Drawing.Point(12, 256)
        Me.btnPeriod4.Name = "btnPeriod4"
        Me.btnPeriod4.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod4.TabIndex = 4
        Me.btnPeriod4.Tag = "4"
        Me.btnPeriod4.Text = "End 2nd Half"
        Me.btnPeriod4.UseVisualStyleBackColor = False
        '
        'btnPeriod3
        '
        Me.btnPeriod3.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPeriod3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod3.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod3.Location = New System.Drawing.Point(12, 212)
        Me.btnPeriod3.Name = "btnPeriod3"
        Me.btnPeriod3.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod3.TabIndex = 3
        Me.btnPeriod3.Tag = "3"
        Me.btnPeriod3.Text = "Start 2nd Half"
        Me.btnPeriod3.UseVisualStyleBackColor = False
        '
        'btnPeriod2
        '
        Me.btnPeriod2.BackColor = System.Drawing.Color.Pink
        Me.btnPeriod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod2.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod2.Location = New System.Drawing.Point(12, 168)
        Me.btnPeriod2.Name = "btnPeriod2"
        Me.btnPeriod2.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod2.TabIndex = 2
        Me.btnPeriod2.Tag = "2"
        Me.btnPeriod2.Text = "   End    1st Half"
        Me.btnPeriod2.UseVisualStyleBackColor = False
        '
        'btnPeriod1
        '
        Me.btnPeriod1.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPeriod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod1.ForeColor = System.Drawing.Color.Black
        Me.btnPeriod1.Location = New System.Drawing.Point(12, 124)
        Me.btnPeriod1.Name = "btnPeriod1"
        Me.btnPeriod1.Size = New System.Drawing.Size(76, 40)
        Me.btnPeriod1.TabIndex = 1
        Me.btnPeriod1.Tag = "1"
        Me.btnPeriod1.Text = "  Start   1st Half"
        Me.btnPeriod1.UseVisualStyleBackColor = False
        '
        'btnPeriodEnable
        '
        Me.btnPeriodEnable.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPeriodEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriodEnable.ForeColor = System.Drawing.Color.Black
        Me.btnPeriodEnable.Location = New System.Drawing.Point(12, 24)
        Me.btnPeriodEnable.Name = "btnPeriodEnable"
        Me.btnPeriodEnable.Size = New System.Drawing.Size(160, 40)
        Me.btnPeriodEnable.TabIndex = 0
        Me.btnPeriodEnable.Text = "Enable"
        Me.btnPeriodEnable.UseVisualStyleBackColor = False
        '
        'btnPossessionH
        '
        Me.btnPossessionH.BackColor = System.Drawing.Color.Navy
        Me.btnPossessionH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionH.ForeColor = System.Drawing.Color.White
        Me.btnPossessionH.Location = New System.Drawing.Point(8, 20)
        Me.btnPossessionH.Name = "btnPossessionH"
        Me.btnPossessionH.Size = New System.Drawing.Size(96, 60)
        Me.btnPossessionH.TabIndex = 109
        Me.btnPossessionH.Tag = "1"
        Me.btnPossessionH.Text = "Tottenham"
        Me.btnPossessionH.UseVisualStyleBackColor = False
        '
        'btnPossessionA
        '
        Me.btnPossessionA.BackColor = System.Drawing.Color.DarkGreen
        Me.btnPossessionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionA.ForeColor = System.Drawing.Color.White
        Me.btnPossessionA.Location = New System.Drawing.Point(108, 20)
        Me.btnPossessionA.Name = "btnPossessionA"
        Me.btnPossessionA.Size = New System.Drawing.Size(96, 60)
        Me.btnPossessionA.TabIndex = 110
        Me.btnPossessionA.Tag = "2"
        Me.btnPossessionA.Text = "West Brom"
        Me.btnPossessionA.UseVisualStyleBackColor = False
        '
        'btnPossessionOOP
        '
        Me.btnPossessionOOP.BackColor = System.Drawing.Color.White
        Me.btnPossessionOOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionOOP.ForeColor = System.Drawing.Color.Black
        Me.btnPossessionOOP.Location = New System.Drawing.Point(208, 20)
        Me.btnPossessionOOP.Name = "btnPossessionOOP"
        Me.btnPossessionOOP.Size = New System.Drawing.Size(96, 60)
        Me.btnPossessionOOP.TabIndex = 111
        Me.btnPossessionOOP.Tag = "0"
        Me.btnPossessionOOP.Text = "Out of Play"
        Me.btnPossessionOOP.UseVisualStyleBackColor = False
        '
        'btnAreaS3
        '
        Me.btnAreaS3.BackColor = System.Drawing.Color.Black
        Me.btnAreaS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaS3.ForeColor = System.Drawing.Color.White
        Me.btnAreaS3.Location = New System.Drawing.Point(208, 20)
        Me.btnAreaS3.Name = "btnAreaS3"
        Me.btnAreaS3.Size = New System.Drawing.Size(96, 60)
        Me.btnAreaS3.TabIndex = 114
        Me.btnAreaS3.Tag = "3"
        Me.btnAreaS3.Text = "Right"
        Me.btnAreaS3.UseVisualStyleBackColor = False
        '
        'btnAreaS2
        '
        Me.btnAreaS2.BackColor = System.Drawing.Color.Black
        Me.btnAreaS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaS2.ForeColor = System.Drawing.Color.White
        Me.btnAreaS2.Location = New System.Drawing.Point(108, 20)
        Me.btnAreaS2.Name = "btnAreaS2"
        Me.btnAreaS2.Size = New System.Drawing.Size(96, 60)
        Me.btnAreaS2.TabIndex = 113
        Me.btnAreaS2.Tag = "2"
        Me.btnAreaS2.Text = "Centre"
        Me.btnAreaS2.UseVisualStyleBackColor = False
        '
        'btnAreaS1
        '
        Me.btnAreaS1.BackColor = System.Drawing.Color.Black
        Me.btnAreaS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaS1.ForeColor = System.Drawing.Color.White
        Me.btnAreaS1.Location = New System.Drawing.Point(8, 20)
        Me.btnAreaS1.Name = "btnAreaS1"
        Me.btnAreaS1.Size = New System.Drawing.Size(96, 60)
        Me.btnAreaS1.TabIndex = 112
        Me.btnAreaS1.Tag = "1"
        Me.btnAreaS1.Text = "Left"
        Me.btnAreaS1.UseVisualStyleBackColor = False
        '
        'lablHomeName2
        '
        Me.lablHomeName2.BackColor = System.Drawing.Color.Black
        Me.lablHomeName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHomeName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeName2.ForeColor = System.Drawing.Color.White
        Me.lablHomeName2.Location = New System.Drawing.Point(48, 0)
        Me.lablHomeName2.Name = "lablHomeName2"
        Me.lablHomeName2.Size = New System.Drawing.Size(148, 20)
        Me.lablHomeName2.TabIndex = 115
        Me.lablHomeName2.Text = "TOTTENHAM"
        Me.lablHomeName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablAwayName2
        '
        Me.lablAwayName2.BackColor = System.Drawing.Color.Black
        Me.lablAwayName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAwayName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayName2.ForeColor = System.Drawing.Color.White
        Me.lablAwayName2.Location = New System.Drawing.Point(196, 0)
        Me.lablAwayName2.Name = "lablAwayName2"
        Me.lablAwayName2.Size = New System.Drawing.Size(148, 20)
        Me.lablAwayName2.TabIndex = 116
        Me.lablAwayName2.Text = "WEST BROM"
        Me.lablAwayName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lablAwayName3
        '
        Me.lablAwayName3.BackColor = System.Drawing.Color.Black
        Me.lablAwayName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAwayName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayName3.ForeColor = System.Drawing.Color.White
        Me.lablAwayName3.Location = New System.Drawing.Point(560, 0)
        Me.lablAwayName3.Name = "lablAwayName3"
        Me.lablAwayName3.Size = New System.Drawing.Size(148, 20)
        Me.lablAwayName3.TabIndex = 118
        Me.lablAwayName3.Text = "WEST BROM"
        Me.lablAwayName3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lablHomeName3
        '
        Me.lablHomeName3.BackColor = System.Drawing.Color.Black
        Me.lablHomeName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHomeName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeName3.ForeColor = System.Drawing.Color.White
        Me.lablHomeName3.Location = New System.Drawing.Point(412, 0)
        Me.lablHomeName3.Name = "lablHomeName3"
        Me.lablHomeName3.Size = New System.Drawing.Size(148, 20)
        Me.lablHomeName3.TabIndex = 117
        Me.lablHomeName3.Text = "TOTTENHAM"
        Me.lablHomeName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablPeriod
        '
        Me.lablPeriod.BackColor = System.Drawing.Color.White
        Me.lablPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPeriod.ForeColor = System.Drawing.Color.Black
        Me.lablPeriod.Location = New System.Drawing.Point(1080, 68)
        Me.lablPeriod.Name = "lablPeriod"
        Me.lablPeriod.Size = New System.Drawing.Size(232, 28)
        Me.lablPeriod.TabIndex = 119
        Me.lablPeriod.Text = "FIRST HALF"
        Me.lablPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupViewTime
        '
        Me.groupViewTime.Controls.Add(Me.btnSwapDirection)
        Me.groupViewTime.Controls.Add(Me.lablInPlay)
        Me.groupViewTime.Controls.Add(Me.Label93)
        Me.groupViewTime.Controls.Add(Me.lablMatchTime2)
        Me.groupViewTime.Controls.Add(Me.Label94)
        Me.groupViewTime.Controls.Add(Me.lablMatchTime)
        Me.groupViewTime.Controls.Add(Me.btnClockNudgeDown)
        Me.groupViewTime.Controls.Add(Me.btnClockNudgeUp)
        Me.groupViewTime.ForeColor = System.Drawing.Color.White
        Me.groupViewTime.Location = New System.Drawing.Point(1040, 108)
        Me.groupViewTime.Name = "groupViewTime"
        Me.groupViewTime.Size = New System.Drawing.Size(120, 308)
        Me.groupViewTime.TabIndex = 120
        Me.groupViewTime.TabStop = False
        Me.groupViewTime.Text = "Clock"
        '
        'btnSwapDirection
        '
        Me.btnSwapDirection.BackColor = System.Drawing.Color.White
        Me.btnSwapDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwapDirection.ForeColor = System.Drawing.Color.Black
        Me.btnSwapDirection.Location = New System.Drawing.Point(24, 256)
        Me.btnSwapDirection.Name = "btnSwapDirection"
        Me.btnSwapDirection.Size = New System.Drawing.Size(76, 40)
        Me.btnSwapDirection.TabIndex = 202
        Me.btnSwapDirection.Tag = "8"
        Me.btnSwapDirection.Text = "Swap Direction"
        Me.btnSwapDirection.UseVisualStyleBackColor = False
        '
        'lablMatchTime
        '
        Me.lablMatchTime.BackColor = System.Drawing.Color.Black
        Me.lablMatchTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lablMatchTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablMatchTime.ForeColor = System.Drawing.Color.White
        Me.lablMatchTime.Location = New System.Drawing.Point(24, 324)
        Me.lablMatchTime.Name = "lablMatchTime"
        Me.lablMatchTime.Size = New System.Drawing.Size(76, 40)
        Me.lablMatchTime.TabIndex = 137
        Me.lablMatchTime.Text = "00:00"
        Me.lablMatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablMatchTime.Visible = False
        '
        'btnClockNudgeDown
        '
        Me.btnClockNudgeDown.BackColor = System.Drawing.Color.Yellow
        Me.btnClockNudgeDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockNudgeDown.ForeColor = System.Drawing.Color.Black
        Me.btnClockNudgeDown.Image = CType(resources.GetObject("btnClockNudgeDown.Image"), System.Drawing.Image)
        Me.btnClockNudgeDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClockNudgeDown.Location = New System.Drawing.Point(24, 208)
        Me.btnClockNudgeDown.Name = "btnClockNudgeDown"
        Me.btnClockNudgeDown.Size = New System.Drawing.Size(76, 40)
        Me.btnClockNudgeDown.TabIndex = 193
        Me.btnClockNudgeDown.Tag = "7"
        Me.btnClockNudgeDown.Text = "Nudge"
        Me.btnClockNudgeDown.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClockNudgeDown.UseVisualStyleBackColor = False
        '
        'btnClockNudgeUp
        '
        Me.btnClockNudgeUp.BackColor = System.Drawing.Color.Yellow
        Me.btnClockNudgeUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockNudgeUp.ForeColor = System.Drawing.Color.Black
        Me.btnClockNudgeUp.Image = CType(resources.GetObject("btnClockNudgeUp.Image"), System.Drawing.Image)
        Me.btnClockNudgeUp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClockNudgeUp.Location = New System.Drawing.Point(24, 164)
        Me.btnClockNudgeUp.Name = "btnClockNudgeUp"
        Me.btnClockNudgeUp.Size = New System.Drawing.Size(76, 40)
        Me.btnClockNudgeUp.TabIndex = 194
        Me.btnClockNudgeUp.Tag = "6"
        Me.btnClockNudgeUp.Text = "Nudge"
        Me.btnClockNudgeUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClockNudgeUp.UseVisualStyleBackColor = False
        '
        'lablTotalPossA
        '
        Me.lablTotalPossA.BackColor = System.Drawing.Color.White
        Me.lablTotalPossA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablTotalPossA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablTotalPossA.ForeColor = System.Drawing.Color.Black
        Me.lablTotalPossA.Location = New System.Drawing.Point(108, 112)
        Me.lablTotalPossA.Name = "lablTotalPossA"
        Me.lablTotalPossA.Size = New System.Drawing.Size(96, 28)
        Me.lablTotalPossA.TabIndex = 197
        Me.lablTotalPossA.Text = "77%"
        Me.lablTotalPossA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablTotalPossH
        '
        Me.lablTotalPossH.BackColor = System.Drawing.Color.White
        Me.lablTotalPossH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablTotalPossH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablTotalPossH.ForeColor = System.Drawing.Color.Black
        Me.lablTotalPossH.Location = New System.Drawing.Point(8, 112)
        Me.lablTotalPossH.Name = "lablTotalPossH"
        Me.lablTotalPossH.Size = New System.Drawing.Size(96, 28)
        Me.lablTotalPossH.TabIndex = 196
        Me.lablTotalPossH.Text = "88%"
        Me.lablTotalPossH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogGoal
        '
        Me.btnLogGoal.BackColor = System.Drawing.Color.LawnGreen
        Me.btnLogGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogGoal.ForeColor = System.Drawing.Color.Black
        Me.btnLogGoal.Location = New System.Drawing.Point(16, 585)
        Me.btnLogGoal.Name = "btnLogGoal"
        Me.btnLogGoal.Size = New System.Drawing.Size(100, 40)
        Me.btnLogGoal.TabIndex = 121
        Me.btnLogGoal.Text = "Score..."
        Me.btnLogGoal.UseVisualStyleBackColor = False
        Me.btnLogGoal.Visible = False
        '
        'btnLogYC
        '
        Me.btnLogYC.BackColor = System.Drawing.Color.Yellow
        Me.btnLogYC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogYC.ForeColor = System.Drawing.Color.Black
        Me.btnLogYC.Location = New System.Drawing.Point(16, 631)
        Me.btnLogYC.Name = "btnLogYC"
        Me.btnLogYC.Size = New System.Drawing.Size(100, 40)
        Me.btnLogYC.TabIndex = 122
        Me.btnLogYC.Text = "Yellow Card..."
        Me.btnLogYC.UseVisualStyleBackColor = False
        Me.btnLogYC.Visible = False
        '
        'btnLogRC
        '
        Me.btnLogRC.BackColor = System.Drawing.Color.Red
        Me.btnLogRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogRC.ForeColor = System.Drawing.Color.White
        Me.btnLogRC.Location = New System.Drawing.Point(16, 677)
        Me.btnLogRC.Name = "btnLogRC"
        Me.btnLogRC.Size = New System.Drawing.Size(100, 40)
        Me.btnLogRC.TabIndex = 123
        Me.btnLogRC.Text = "Red Card..."
        Me.btnLogRC.UseVisualStyleBackColor = False
        Me.btnLogRC.Visible = False
        '
        'groupActionAreasSoccer
        '
        Me.groupActionAreasSoccer.Controls.Add(Me.Label4)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablAreaS1)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablViewS3)
        Me.groupActionAreasSoccer.Controls.Add(Me.btnAreaS3)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablAreaS2)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablAreaS3)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablViewS1)
        Me.groupActionAreasSoccer.Controls.Add(Me.btnAreaS1)
        Me.groupActionAreasSoccer.Controls.Add(Me.lablViewS2)
        Me.groupActionAreasSoccer.Controls.Add(Me.btnAreaS2)
        Me.groupActionAreasSoccer.ForeColor = System.Drawing.Color.White
        Me.groupActionAreasSoccer.Location = New System.Drawing.Point(1040, 592)
        Me.groupActionAreasSoccer.Name = "groupActionAreasSoccer"
        Me.groupActionAreasSoccer.Size = New System.Drawing.Size(312, 132)
        Me.groupActionAreasSoccer.TabIndex = 125
        Me.groupActionAreasSoccer.TabStop = False
        Me.groupActionAreasSoccer.Text = "Action Areas"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(296, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 20)
        Me.Label4.TabIndex = 200
        Me.Label4.Text = " "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'lablViewS3
        '
        Me.lablViewS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewS3.ForeColor = System.Drawing.Color.White
        Me.lablViewS3.Location = New System.Drawing.Point(208, 108)
        Me.lablViewS3.Name = "lablViewS3"
        Me.lablViewS3.Size = New System.Drawing.Size(96, 20)
        Me.lablViewS3.TabIndex = 201
        Me.lablViewS3.Text = "0"
        Me.lablViewS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewS1
        '
        Me.lablViewS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewS1.ForeColor = System.Drawing.Color.White
        Me.lablViewS1.Location = New System.Drawing.Point(8, 108)
        Me.lablViewS1.Name = "lablViewS1"
        Me.lablViewS1.Size = New System.Drawing.Size(96, 20)
        Me.lablViewS1.TabIndex = 199
        Me.lablViewS1.Text = "0"
        Me.lablViewS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewS2
        '
        Me.lablViewS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewS2.ForeColor = System.Drawing.Color.White
        Me.lablViewS2.Location = New System.Drawing.Point(108, 108)
        Me.lablViewS2.Name = "lablViewS2"
        Me.lablViewS2.Size = New System.Drawing.Size(96, 20)
        Me.lablViewS2.TabIndex = 198
        Me.lablViewS2.Text = "0"
        Me.lablViewS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupPossession
        '
        Me.groupPossession.Controls.Add(Me.Label9)
        Me.groupPossession.Controls.Add(Me.Label8)
        Me.groupPossession.Controls.Add(Me.lablTotalPossA)
        Me.groupPossession.Controls.Add(Me.btnPossessionH)
        Me.groupPossession.Controls.Add(Me.lablViewOOP)
        Me.groupPossession.Controls.Add(Me.lablViewA)
        Me.groupPossession.Controls.Add(Me.lablTotalPossH)
        Me.groupPossession.Controls.Add(Me.lablViewH)
        Me.groupPossession.Controls.Add(Me.btnPossessionA)
        Me.groupPossession.Controls.Add(Me.btnPossessionOOP)
        Me.groupPossession.Controls.Add(Me.lablPossessionH)
        Me.groupPossession.Controls.Add(Me.lablPossessionA)
        Me.groupPossession.ForeColor = System.Drawing.Color.White
        Me.groupPossession.Location = New System.Drawing.Point(1040, 420)
        Me.groupPossession.Name = "groupPossession"
        Me.groupPossession.Size = New System.Drawing.Size(312, 164)
        Me.groupPossession.TabIndex = 126
        Me.groupPossession.TabStop = False
        Me.groupPossession.Text = "Possession"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(204, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "Match"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(204, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "This Period"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablViewOOP
        '
        Me.lablViewOOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewOOP.ForeColor = System.Drawing.Color.White
        Me.lablViewOOP.Location = New System.Drawing.Point(220, 140)
        Me.lablViewOOP.Name = "lablViewOOP"
        Me.lablViewOOP.Size = New System.Drawing.Size(76, 20)
        Me.lablViewOOP.TabIndex = 197
        Me.lablViewOOP.Text = "0"
        Me.lablViewOOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewA
        '
        Me.lablViewA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewA.ForeColor = System.Drawing.Color.White
        Me.lablViewA.Location = New System.Drawing.Point(108, 140)
        Me.lablViewA.Name = "lablViewA"
        Me.lablViewA.Size = New System.Drawing.Size(96, 20)
        Me.lablViewA.TabIndex = 196
        Me.lablViewA.Text = "0"
        Me.lablViewA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewH
        '
        Me.lablViewH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewH.ForeColor = System.Drawing.Color.White
        Me.lablViewH.Location = New System.Drawing.Point(8, 140)
        Me.lablViewH.Name = "lablViewH"
        Me.lablViewH.Size = New System.Drawing.Size(96, 20)
        Me.lablViewH.TabIndex = 195
        Me.lablViewH.Text = "0"
        Me.lablViewH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablArrowHomeLR
        '
        Me.lablArrowHomeLR.BackColor = System.Drawing.Color.White
        Me.lablArrowHomeLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablArrowHomeLR.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablArrowHomeLR.ForeColor = System.Drawing.Color.Black
        Me.lablArrowHomeLR.Location = New System.Drawing.Point(1312, 4)
        Me.lablArrowHomeLR.Name = "lablArrowHomeLR"
        Me.lablArrowHomeLR.Size = New System.Drawing.Size(40, 32)
        Me.lablArrowHomeLR.TabIndex = 127
        Me.lablArrowHomeLR.Text = "è"
        Me.lablArrowHomeLR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lablArrowHomeLR.Visible = False
        '
        'lablArrowHomeRL
        '
        Me.lablArrowHomeRL.BackColor = System.Drawing.Color.White
        Me.lablArrowHomeRL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablArrowHomeRL.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablArrowHomeRL.ForeColor = System.Drawing.Color.Black
        Me.lablArrowHomeRL.Location = New System.Drawing.Point(1040, 4)
        Me.lablArrowHomeRL.Name = "lablArrowHomeRL"
        Me.lablArrowHomeRL.Size = New System.Drawing.Size(40, 32)
        Me.lablArrowHomeRL.TabIndex = 128
        Me.lablArrowHomeRL.Text = "ç"
        Me.lablArrowHomeRL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSetup.Enabled = False
        Me.btnSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.Black
        Me.btnSetup.Location = New System.Drawing.Point(16, 83)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(100, 40)
        Me.btnSetup.TabIndex = 121
        Me.btnSetup.Text = "Setup..."
        Me.btnSetup.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(16, 26)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 129
        Me.btnExit.Text = "Exit..."
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lablArrowAwayRL
        '
        Me.lablArrowAwayRL.BackColor = System.Drawing.Color.White
        Me.lablArrowAwayRL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablArrowAwayRL.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablArrowAwayRL.ForeColor = System.Drawing.Color.Black
        Me.lablArrowAwayRL.Location = New System.Drawing.Point(1040, 36)
        Me.lablArrowAwayRL.Name = "lablArrowAwayRL"
        Me.lablArrowAwayRL.Size = New System.Drawing.Size(40, 32)
        Me.lablArrowAwayRL.TabIndex = 132
        Me.lablArrowAwayRL.Text = "ç"
        Me.lablArrowAwayRL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lablArrowAwayRL.Visible = False
        '
        'lablArrowAwayLR
        '
        Me.lablArrowAwayLR.BackColor = System.Drawing.Color.White
        Me.lablArrowAwayLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablArrowAwayLR.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablArrowAwayLR.ForeColor = System.Drawing.Color.Black
        Me.lablArrowAwayLR.Location = New System.Drawing.Point(1312, 36)
        Me.lablArrowAwayLR.Name = "lablArrowAwayLR"
        Me.lablArrowAwayLR.Size = New System.Drawing.Size(40, 32)
        Me.lablArrowAwayLR.TabIndex = 131
        Me.lablArrowAwayLR.Text = "è"
        Me.lablArrowAwayLR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(16, 152)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(100, 40)
        Me.btnConnect.TabIndex = 133
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'LablConnected
        '
        Me.LablConnected.BackColor = System.Drawing.Color.Lime
        Me.LablConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LablConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LablConnected.ForeColor = System.Drawing.Color.Black
        Me.LablConnected.Location = New System.Drawing.Point(16, 192)
        Me.LablConnected.Name = "LablConnected"
        Me.LablConnected.Size = New System.Drawing.Size(100, 40)
        Me.LablConnected.TabIndex = 134
        Me.LablConnected.Text = "Connected to SportServer"
        Me.LablConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.LightSalmon
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(16, 435)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 40)
        Me.btnRemove.TabIndex = 135
        Me.btnRemove.Text = "Remove..."
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lablRemove
        '
        Me.lablRemove.BackColor = System.Drawing.Color.DarkRed
        Me.lablRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemove.ForeColor = System.Drawing.Color.White
        Me.lablRemove.Location = New System.Drawing.Point(16, 477)
        Me.lablRemove.Name = "lablRemove"
        Me.lablRemove.Size = New System.Drawing.Size(100, 40)
        Me.lablRemove.TabIndex = 136
        Me.lablRemove.Text = "Remove Next Log"
        Me.lablRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lablRemove.Visible = False
        '
        'timerCheckClock
        '
        Me.timerCheckClock.Interval = 1000
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.tabKickouts)
        Me.TabControl1.Controls.Add(Me.tabPenalties)
        Me.TabControl1.Controls.Add(Me.tabCarries)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(131, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(904, 724)
        Me.TabControl1.TabIndex = 137
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage1.Controls.Add(Me.lablMatchID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnClearAllTeam)
        Me.TabPage1.Controls.Add(Me.btnResendTeam)
        Me.TabPage1.Controls.Add(Me.lablStat21H)
        Me.TabPage1.Controls.Add(Me.lablHeading26)
        Me.TabPage1.Controls.Add(Me.lablStat26H)
        Me.TabPage1.Controls.Add(Me.lablStat26A)
        Me.TabPage1.Controls.Add(Me.lablHeading27)
        Me.TabPage1.Controls.Add(Me.lablStat27H)
        Me.TabPage1.Controls.Add(Me.lablStat27A)
        Me.TabPage1.Controls.Add(Me.lablHeading28)
        Me.TabPage1.Controls.Add(Me.lablStat28H)
        Me.TabPage1.Controls.Add(Me.lablStat28A)
        Me.TabPage1.Controls.Add(Me.lablHeading29)
        Me.TabPage1.Controls.Add(Me.lablStat29H)
        Me.TabPage1.Controls.Add(Me.lablStat29A)
        Me.TabPage1.Controls.Add(Me.lablHeading30)
        Me.TabPage1.Controls.Add(Me.lablStat30H)
        Me.TabPage1.Controls.Add(Me.lablStat30A)
        Me.TabPage1.Controls.Add(Me.lablHeading21)
        Me.TabPage1.Controls.Add(Me.lablStat21A)
        Me.TabPage1.Controls.Add(Me.lablHeading22)
        Me.TabPage1.Controls.Add(Me.lablAwayName2)
        Me.TabPage1.Controls.Add(Me.lablAwayName3)
        Me.TabPage1.Controls.Add(Me.lablHomeName2)
        Me.TabPage1.Controls.Add(Me.lablStat22H)
        Me.TabPage1.Controls.Add(Me.lablHomeName3)
        Me.TabPage1.Controls.Add(Me.lablStat22A)
        Me.TabPage1.Controls.Add(Me.lablStat15A)
        Me.TabPage1.Controls.Add(Me.lablHeading23)
        Me.TabPage1.Controls.Add(Me.lablStat15H)
        Me.TabPage1.Controls.Add(Me.lablStat23H)
        Me.TabPage1.Controls.Add(Me.lablHeading15)
        Me.TabPage1.Controls.Add(Me.lablStat23A)
        Me.TabPage1.Controls.Add(Me.lablStat14A)
        Me.TabPage1.Controls.Add(Me.lablHeading24)
        Me.TabPage1.Controls.Add(Me.lablStat14H)
        Me.TabPage1.Controls.Add(Me.lablStat24H)
        Me.TabPage1.Controls.Add(Me.lablHeading14)
        Me.TabPage1.Controls.Add(Me.lablStat20A)
        Me.TabPage1.Controls.Add(Me.lablStat13A)
        Me.TabPage1.Controls.Add(Me.lablStat25A)
        Me.TabPage1.Controls.Add(Me.lablStat13H)
        Me.TabPage1.Controls.Add(Me.lablStat20H)
        Me.TabPage1.Controls.Add(Me.lablHeading13)
        Me.TabPage1.Controls.Add(Me.lablStat24A)
        Me.TabPage1.Controls.Add(Me.lablStat12A)
        Me.TabPage1.Controls.Add(Me.lablHeading20)
        Me.TabPage1.Controls.Add(Me.lablStat12H)
        Me.TabPage1.Controls.Add(Me.lablStat25H)
        Me.TabPage1.Controls.Add(Me.lablHeading12)
        Me.TabPage1.Controls.Add(Me.lablStat19A)
        Me.TabPage1.Controls.Add(Me.lablStat11A)
        Me.TabPage1.Controls.Add(Me.lablHeading25)
        Me.TabPage1.Controls.Add(Me.lablStat11H)
        Me.TabPage1.Controls.Add(Me.lablStat19H)
        Me.TabPage1.Controls.Add(Me.lablHeading11)
        Me.TabPage1.Controls.Add(Me.lablHeading19)
        Me.TabPage1.Controls.Add(Me.lablStat10A)
        Me.TabPage1.Controls.Add(Me.lablHeading16)
        Me.TabPage1.Controls.Add(Me.lablStat10H)
        Me.TabPage1.Controls.Add(Me.lablStat18A)
        Me.TabPage1.Controls.Add(Me.lablHeading10)
        Me.TabPage1.Controls.Add(Me.lablStat16H)
        Me.TabPage1.Controls.Add(Me.lablStat09A)
        Me.TabPage1.Controls.Add(Me.lablStat18H)
        Me.TabPage1.Controls.Add(Me.lablStat09H)
        Me.TabPage1.Controls.Add(Me.lablStat16A)
        Me.TabPage1.Controls.Add(Me.lablHeading09)
        Me.TabPage1.Controls.Add(Me.lablHeading18)
        Me.TabPage1.Controls.Add(Me.lablStat08A)
        Me.TabPage1.Controls.Add(Me.lablHeading17)
        Me.TabPage1.Controls.Add(Me.lablStat08H)
        Me.TabPage1.Controls.Add(Me.lablStat17A)
        Me.TabPage1.Controls.Add(Me.lablHeading08)
        Me.TabPage1.Controls.Add(Me.lablStat17H)
        Me.TabPage1.Controls.Add(Me.lablStat07A)
        Me.TabPage1.Controls.Add(Me.lablHeading01)
        Me.TabPage1.Controls.Add(Me.lablStat07H)
        Me.TabPage1.Controls.Add(Me.lablStat01H)
        Me.TabPage1.Controls.Add(Me.lablHeading07)
        Me.TabPage1.Controls.Add(Me.lablStat01A)
        Me.TabPage1.Controls.Add(Me.lablStat06A)
        Me.TabPage1.Controls.Add(Me.lablHeading02)
        Me.TabPage1.Controls.Add(Me.lablStat06H)
        Me.TabPage1.Controls.Add(Me.lablStat02H)
        Me.TabPage1.Controls.Add(Me.lablHeading06)
        Me.TabPage1.Controls.Add(Me.lablStat02A)
        Me.TabPage1.Controls.Add(Me.lablStat05A)
        Me.TabPage1.Controls.Add(Me.lablHeading03)
        Me.TabPage1.Controls.Add(Me.lablStat05H)
        Me.TabPage1.Controls.Add(Me.lablStat03H)
        Me.TabPage1.Controls.Add(Me.lablHeading05)
        Me.TabPage1.Controls.Add(Me.lablStat03A)
        Me.TabPage1.Controls.Add(Me.lablStat04A)
        Me.TabPage1.Controls.Add(Me.lablHeading04)
        Me.TabPage1.Controls.Add(Me.lablStat04H)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(896, 684)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TEAM "
        '
        'lablMatchID
        '
        Me.lablMatchID.BackColor = System.Drawing.Color.White
        Me.lablMatchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablMatchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablMatchID.ForeColor = System.Drawing.Color.Black
        Me.lablMatchID.Location = New System.Drawing.Point(740, 63)
        Me.lablMatchID.Name = "lablMatchID"
        Me.lablMatchID.Size = New System.Drawing.Size(144, 28)
        Me.lablMatchID.TabIndex = 223
        Me.lablMatchID.Text = "123456"
        Me.lablMatchID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(740, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 224
        Me.Label2.Text = "Match ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClearAllTeam
        '
        Me.btnClearAllTeam.BackColor = System.Drawing.Color.DarkRed
        Me.btnClearAllTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllTeam.ForeColor = System.Drawing.Color.White
        Me.btnClearAllTeam.Location = New System.Drawing.Point(740, 636)
        Me.btnClearAllTeam.Name = "btnClearAllTeam"
        Me.btnClearAllTeam.Size = New System.Drawing.Size(144, 40)
        Me.btnClearAllTeam.TabIndex = 222
        Me.btnClearAllTeam.Tag = "1"
        Me.btnClearAllTeam.Text = "  Clear All Team Data"
        Me.btnClearAllTeam.UseVisualStyleBackColor = False
        '
        'btnResendTeam
        '
        Me.btnResendTeam.BackColor = System.Drawing.Color.DarkGreen
        Me.btnResendTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResendTeam.ForeColor = System.Drawing.Color.White
        Me.btnResendTeam.Location = New System.Drawing.Point(740, 592)
        Me.btnResendTeam.Name = "btnResendTeam"
        Me.btnResendTeam.Size = New System.Drawing.Size(144, 40)
        Me.btnResendTeam.TabIndex = 221
        Me.btnResendTeam.Tag = "0"
        Me.btnResendTeam.Text = "Resend Data"
        Me.btnResendTeam.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage2.Controls.Add(Me.btnClearPlayerHome)
        Me.TabPage2.Controls.Add(Me.btnResendPlayerHome)
        Me.TabPage2.Controls.Add(Me.btnPlayer25H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading15)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat15H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading14)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat14H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading13)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat13H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading12)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat12H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading11)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat11H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading10)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat10H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading09)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat09H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading08)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat08H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading07)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat07H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading06)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat06H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading05)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat05H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading04)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat04H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading03)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat03H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading02)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat02H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading01)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat01H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading30)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat30H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading29)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat29H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading28)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat28H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading27)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat27H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading26)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat26H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading25)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat25H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading24)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat24H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading23)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat23H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading22)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat22H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading21)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat21H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading20)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat20H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading19)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat19H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading18)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat18H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading17)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat17H)
        Me.TabPage2.Controls.Add(Me.lablPlayerStatHeading16)
        Me.TabPage2.Controls.Add(Me.lablPlayerStat16H)
        Me.TabPage2.Controls.Add(Me.btnPlayer24H)
        Me.TabPage2.Controls.Add(Me.btnPlayer23H)
        Me.TabPage2.Controls.Add(Me.btnPlayer22H)
        Me.TabPage2.Controls.Add(Me.btnPlayer21H)
        Me.TabPage2.Controls.Add(Me.btnPlayer20H)
        Me.TabPage2.Controls.Add(Me.btnPlayer19H)
        Me.TabPage2.Controls.Add(Me.btnPlayer18H)
        Me.TabPage2.Controls.Add(Me.btnPlayer17H)
        Me.TabPage2.Controls.Add(Me.btnPlayer16H)
        Me.TabPage2.Controls.Add(Me.btnPlayer15H)
        Me.TabPage2.Controls.Add(Me.btnPlayer14H)
        Me.TabPage2.Controls.Add(Me.btnPlayer13H)
        Me.TabPage2.Controls.Add(Me.btnPlayer12H)
        Me.TabPage2.Controls.Add(Me.btnPlayer11H)
        Me.TabPage2.Controls.Add(Me.btnPlayer10H)
        Me.TabPage2.Controls.Add(Me.btnPlayer09H)
        Me.TabPage2.Controls.Add(Me.btnPlayer08H)
        Me.TabPage2.Controls.Add(Me.btnPlayer07H)
        Me.TabPage2.Controls.Add(Me.btnPlayer06H)
        Me.TabPage2.Controls.Add(Me.btnPlayer05H)
        Me.TabPage2.Controls.Add(Me.btnPlayer04H)
        Me.TabPage2.Controls.Add(Me.btnPlayer03H)
        Me.TabPage2.Controls.Add(Me.btnPlayer02H)
        Me.TabPage2.Controls.Add(Me.btnPlayer01H)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(896, 684)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "HOME PLAYERS"
        '
        'btnClearPlayerHome
        '
        Me.btnClearPlayerHome.BackColor = System.Drawing.Color.DarkRed
        Me.btnClearPlayerHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPlayerHome.ForeColor = System.Drawing.Color.White
        Me.btnClearPlayerHome.Location = New System.Drawing.Point(216, 628)
        Me.btnClearPlayerHome.Name = "btnClearPlayerHome"
        Me.btnClearPlayerHome.Size = New System.Drawing.Size(200, 40)
        Me.btnClearPlayerHome.TabIndex = 220
        Me.btnClearPlayerHome.Tag = "1"
        Me.btnClearPlayerHome.Text = "Clear All Data for Current Player"
        Me.btnClearPlayerHome.UseVisualStyleBackColor = False
        '
        'btnResendPlayerHome
        '
        Me.btnResendPlayerHome.BackColor = System.Drawing.Color.DarkGreen
        Me.btnResendPlayerHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResendPlayerHome.ForeColor = System.Drawing.Color.White
        Me.btnResendPlayerHome.Location = New System.Drawing.Point(216, 584)
        Me.btnResendPlayerHome.Name = "btnResendPlayerHome"
        Me.btnResendPlayerHome.Size = New System.Drawing.Size(200, 40)
        Me.btnResendPlayerHome.TabIndex = 219
        Me.btnResendPlayerHome.Tag = "0"
        Me.btnResendPlayerHome.Text = "Resend Data"
        Me.btnResendPlayerHome.UseVisualStyleBackColor = False
        '
        'btnPlayer25H
        '
        Me.btnPlayer25H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer25H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer25H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer25H.Location = New System.Drawing.Point(212, 408)
        Me.btnPlayer25H.Name = "btnPlayer25H"
        Me.btnPlayer25H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer25H.TabIndex = 218
        Me.btnPlayer25H.Tag = "25"
        Me.btnPlayer25H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer25H.UseVisualStyleBackColor = False
        '
        'lablPlayerStatHeading15
        '
        Me.lablPlayerStatHeading15.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading15.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading15.Location = New System.Drawing.Point(424, 628)
        Me.lablPlayerStatHeading15.Name = "lablPlayerStatHeading15"
        Me.lablPlayerStatHeading15.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading15.TabIndex = 217
        Me.lablPlayerStatHeading15.Text = "Player Stat 01"
        Me.lablPlayerStatHeading15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat15H
        '
        Me.lablPlayerStat15H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat15H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat15H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat15H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat15H.Location = New System.Drawing.Point(576, 628)
        Me.lablPlayerStat15H.Name = "lablPlayerStat15H"
        Me.lablPlayerStat15H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat15H.TabIndex = 216
        Me.lablPlayerStat15H.Tag = "15"
        Me.lablPlayerStat15H.Text = "999"
        Me.lablPlayerStat15H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading14
        '
        Me.lablPlayerStatHeading14.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading14.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading14.Location = New System.Drawing.Point(424, 584)
        Me.lablPlayerStatHeading14.Name = "lablPlayerStatHeading14"
        Me.lablPlayerStatHeading14.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading14.TabIndex = 215
        Me.lablPlayerStatHeading14.Text = "Player Stat 01"
        Me.lablPlayerStatHeading14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat14H
        '
        Me.lablPlayerStat14H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat14H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat14H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat14H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat14H.Location = New System.Drawing.Point(576, 584)
        Me.lablPlayerStat14H.Name = "lablPlayerStat14H"
        Me.lablPlayerStat14H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat14H.TabIndex = 214
        Me.lablPlayerStat14H.Tag = "14"
        Me.lablPlayerStat14H.Text = "999"
        Me.lablPlayerStat14H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading13
        '
        Me.lablPlayerStatHeading13.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading13.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading13.Location = New System.Drawing.Point(424, 540)
        Me.lablPlayerStatHeading13.Name = "lablPlayerStatHeading13"
        Me.lablPlayerStatHeading13.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading13.TabIndex = 213
        Me.lablPlayerStatHeading13.Text = "Player Stat 01"
        Me.lablPlayerStatHeading13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat13H
        '
        Me.lablPlayerStat13H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat13H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat13H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat13H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat13H.Location = New System.Drawing.Point(576, 540)
        Me.lablPlayerStat13H.Name = "lablPlayerStat13H"
        Me.lablPlayerStat13H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat13H.TabIndex = 212
        Me.lablPlayerStat13H.Tag = "13"
        Me.lablPlayerStat13H.Text = "999"
        Me.lablPlayerStat13H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading12
        '
        Me.lablPlayerStatHeading12.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading12.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading12.Location = New System.Drawing.Point(424, 496)
        Me.lablPlayerStatHeading12.Name = "lablPlayerStatHeading12"
        Me.lablPlayerStatHeading12.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading12.TabIndex = 211
        Me.lablPlayerStatHeading12.Text = "Player Stat 01"
        Me.lablPlayerStatHeading12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat12H
        '
        Me.lablPlayerStat12H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat12H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat12H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat12H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat12H.Location = New System.Drawing.Point(576, 496)
        Me.lablPlayerStat12H.Name = "lablPlayerStat12H"
        Me.lablPlayerStat12H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat12H.TabIndex = 210
        Me.lablPlayerStat12H.Tag = "12"
        Me.lablPlayerStat12H.Text = "999"
        Me.lablPlayerStat12H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading11
        '
        Me.lablPlayerStatHeading11.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading11.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading11.Location = New System.Drawing.Point(424, 452)
        Me.lablPlayerStatHeading11.Name = "lablPlayerStatHeading11"
        Me.lablPlayerStatHeading11.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading11.TabIndex = 209
        Me.lablPlayerStatHeading11.Text = "Player Stat 01"
        Me.lablPlayerStatHeading11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat11H
        '
        Me.lablPlayerStat11H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat11H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat11H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat11H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat11H.Location = New System.Drawing.Point(576, 452)
        Me.lablPlayerStat11H.Name = "lablPlayerStat11H"
        Me.lablPlayerStat11H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat11H.TabIndex = 208
        Me.lablPlayerStat11H.Tag = "11"
        Me.lablPlayerStat11H.Text = "999"
        Me.lablPlayerStat11H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading10
        '
        Me.lablPlayerStatHeading10.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading10.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading10.Location = New System.Drawing.Point(424, 408)
        Me.lablPlayerStatHeading10.Name = "lablPlayerStatHeading10"
        Me.lablPlayerStatHeading10.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading10.TabIndex = 207
        Me.lablPlayerStatHeading10.Text = "Player Stat 01"
        Me.lablPlayerStatHeading10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat10H
        '
        Me.lablPlayerStat10H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat10H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat10H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat10H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat10H.Location = New System.Drawing.Point(576, 408)
        Me.lablPlayerStat10H.Name = "lablPlayerStat10H"
        Me.lablPlayerStat10H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat10H.TabIndex = 206
        Me.lablPlayerStat10H.Tag = "10"
        Me.lablPlayerStat10H.Text = "999"
        Me.lablPlayerStat10H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading09
        '
        Me.lablPlayerStatHeading09.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading09.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading09.Location = New System.Drawing.Point(424, 364)
        Me.lablPlayerStatHeading09.Name = "lablPlayerStatHeading09"
        Me.lablPlayerStatHeading09.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading09.TabIndex = 205
        Me.lablPlayerStatHeading09.Text = "Player Stat 01"
        Me.lablPlayerStatHeading09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat09H
        '
        Me.lablPlayerStat09H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat09H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat09H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat09H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat09H.Location = New System.Drawing.Point(576, 364)
        Me.lablPlayerStat09H.Name = "lablPlayerStat09H"
        Me.lablPlayerStat09H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat09H.TabIndex = 204
        Me.lablPlayerStat09H.Tag = "9"
        Me.lablPlayerStat09H.Text = "999"
        Me.lablPlayerStat09H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading08
        '
        Me.lablPlayerStatHeading08.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading08.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading08.Location = New System.Drawing.Point(424, 320)
        Me.lablPlayerStatHeading08.Name = "lablPlayerStatHeading08"
        Me.lablPlayerStatHeading08.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading08.TabIndex = 203
        Me.lablPlayerStatHeading08.Text = "Player Stat 01"
        Me.lablPlayerStatHeading08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat08H
        '
        Me.lablPlayerStat08H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat08H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat08H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat08H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat08H.Location = New System.Drawing.Point(576, 320)
        Me.lablPlayerStat08H.Name = "lablPlayerStat08H"
        Me.lablPlayerStat08H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat08H.TabIndex = 202
        Me.lablPlayerStat08H.Tag = "8"
        Me.lablPlayerStat08H.Text = "999"
        Me.lablPlayerStat08H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading07
        '
        Me.lablPlayerStatHeading07.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading07.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading07.Location = New System.Drawing.Point(424, 276)
        Me.lablPlayerStatHeading07.Name = "lablPlayerStatHeading07"
        Me.lablPlayerStatHeading07.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading07.TabIndex = 201
        Me.lablPlayerStatHeading07.Text = "Player Stat 01"
        Me.lablPlayerStatHeading07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat07H
        '
        Me.lablPlayerStat07H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat07H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat07H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat07H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat07H.Location = New System.Drawing.Point(576, 276)
        Me.lablPlayerStat07H.Name = "lablPlayerStat07H"
        Me.lablPlayerStat07H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat07H.TabIndex = 200
        Me.lablPlayerStat07H.Tag = "7"
        Me.lablPlayerStat07H.Text = "999"
        Me.lablPlayerStat07H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading06
        '
        Me.lablPlayerStatHeading06.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading06.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading06.Location = New System.Drawing.Point(424, 232)
        Me.lablPlayerStatHeading06.Name = "lablPlayerStatHeading06"
        Me.lablPlayerStatHeading06.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading06.TabIndex = 199
        Me.lablPlayerStatHeading06.Text = "Player Stat 01"
        Me.lablPlayerStatHeading06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat06H
        '
        Me.lablPlayerStat06H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat06H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat06H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat06H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat06H.Location = New System.Drawing.Point(576, 232)
        Me.lablPlayerStat06H.Name = "lablPlayerStat06H"
        Me.lablPlayerStat06H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat06H.TabIndex = 198
        Me.lablPlayerStat06H.Tag = "6"
        Me.lablPlayerStat06H.Text = "999"
        Me.lablPlayerStat06H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading05
        '
        Me.lablPlayerStatHeading05.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading05.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading05.Location = New System.Drawing.Point(424, 188)
        Me.lablPlayerStatHeading05.Name = "lablPlayerStatHeading05"
        Me.lablPlayerStatHeading05.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading05.TabIndex = 197
        Me.lablPlayerStatHeading05.Text = "Player Stat 01"
        Me.lablPlayerStatHeading05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat05H
        '
        Me.lablPlayerStat05H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat05H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat05H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat05H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat05H.Location = New System.Drawing.Point(576, 188)
        Me.lablPlayerStat05H.Name = "lablPlayerStat05H"
        Me.lablPlayerStat05H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat05H.TabIndex = 196
        Me.lablPlayerStat05H.Tag = "5"
        Me.lablPlayerStat05H.Text = "999"
        Me.lablPlayerStat05H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading04
        '
        Me.lablPlayerStatHeading04.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading04.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading04.Location = New System.Drawing.Point(424, 144)
        Me.lablPlayerStatHeading04.Name = "lablPlayerStatHeading04"
        Me.lablPlayerStatHeading04.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading04.TabIndex = 195
        Me.lablPlayerStatHeading04.Text = "Player Stat 01"
        Me.lablPlayerStatHeading04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat04H
        '
        Me.lablPlayerStat04H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat04H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat04H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat04H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat04H.Location = New System.Drawing.Point(576, 144)
        Me.lablPlayerStat04H.Name = "lablPlayerStat04H"
        Me.lablPlayerStat04H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat04H.TabIndex = 194
        Me.lablPlayerStat04H.Tag = "4"
        Me.lablPlayerStat04H.Text = "999"
        Me.lablPlayerStat04H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading03
        '
        Me.lablPlayerStatHeading03.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading03.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading03.Location = New System.Drawing.Point(424, 100)
        Me.lablPlayerStatHeading03.Name = "lablPlayerStatHeading03"
        Me.lablPlayerStatHeading03.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading03.TabIndex = 193
        Me.lablPlayerStatHeading03.Text = "Player Stat 01"
        Me.lablPlayerStatHeading03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat03H
        '
        Me.lablPlayerStat03H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat03H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat03H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat03H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat03H.Location = New System.Drawing.Point(576, 100)
        Me.lablPlayerStat03H.Name = "lablPlayerStat03H"
        Me.lablPlayerStat03H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat03H.TabIndex = 192
        Me.lablPlayerStat03H.Tag = "3"
        Me.lablPlayerStat03H.Text = "999"
        Me.lablPlayerStat03H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading02
        '
        Me.lablPlayerStatHeading02.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading02.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading02.Location = New System.Drawing.Point(424, 56)
        Me.lablPlayerStatHeading02.Name = "lablPlayerStatHeading02"
        Me.lablPlayerStatHeading02.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading02.TabIndex = 191
        Me.lablPlayerStatHeading02.Text = "Player Stat 01"
        Me.lablPlayerStatHeading02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat02H
        '
        Me.lablPlayerStat02H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat02H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat02H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat02H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat02H.Location = New System.Drawing.Point(576, 56)
        Me.lablPlayerStat02H.Name = "lablPlayerStat02H"
        Me.lablPlayerStat02H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat02H.TabIndex = 190
        Me.lablPlayerStat02H.Tag = "2"
        Me.lablPlayerStat02H.Text = "999"
        Me.lablPlayerStat02H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading01
        '
        Me.lablPlayerStatHeading01.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading01.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading01.Location = New System.Drawing.Point(424, 12)
        Me.lablPlayerStatHeading01.Name = "lablPlayerStatHeading01"
        Me.lablPlayerStatHeading01.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading01.TabIndex = 189
        Me.lablPlayerStatHeading01.Text = "Player Stat 01"
        Me.lablPlayerStatHeading01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat01H
        '
        Me.lablPlayerStat01H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat01H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat01H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat01H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat01H.Location = New System.Drawing.Point(576, 12)
        Me.lablPlayerStat01H.Name = "lablPlayerStat01H"
        Me.lablPlayerStat01H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat01H.TabIndex = 188
        Me.lablPlayerStat01H.Tag = "1"
        Me.lablPlayerStat01H.Text = "999"
        Me.lablPlayerStat01H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading30
        '
        Me.lablPlayerStatHeading30.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading30.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading30.Location = New System.Drawing.Point(660, 628)
        Me.lablPlayerStatHeading30.Name = "lablPlayerStatHeading30"
        Me.lablPlayerStatHeading30.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading30.TabIndex = 187
        Me.lablPlayerStatHeading30.Text = "Player Stat 01"
        Me.lablPlayerStatHeading30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat30H
        '
        Me.lablPlayerStat30H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat30H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat30H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat30H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat30H.Location = New System.Drawing.Point(812, 628)
        Me.lablPlayerStat30H.Name = "lablPlayerStat30H"
        Me.lablPlayerStat30H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat30H.TabIndex = 186
        Me.lablPlayerStat30H.Tag = "30"
        Me.lablPlayerStat30H.Text = "999"
        Me.lablPlayerStat30H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading29
        '
        Me.lablPlayerStatHeading29.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading29.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading29.Location = New System.Drawing.Point(660, 584)
        Me.lablPlayerStatHeading29.Name = "lablPlayerStatHeading29"
        Me.lablPlayerStatHeading29.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading29.TabIndex = 185
        Me.lablPlayerStatHeading29.Text = "Player Stat 01"
        Me.lablPlayerStatHeading29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat29H
        '
        Me.lablPlayerStat29H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat29H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat29H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat29H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat29H.Location = New System.Drawing.Point(812, 584)
        Me.lablPlayerStat29H.Name = "lablPlayerStat29H"
        Me.lablPlayerStat29H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat29H.TabIndex = 184
        Me.lablPlayerStat29H.Tag = "29"
        Me.lablPlayerStat29H.Text = "999"
        Me.lablPlayerStat29H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading28
        '
        Me.lablPlayerStatHeading28.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading28.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading28.Location = New System.Drawing.Point(660, 540)
        Me.lablPlayerStatHeading28.Name = "lablPlayerStatHeading28"
        Me.lablPlayerStatHeading28.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading28.TabIndex = 183
        Me.lablPlayerStatHeading28.Text = "Player Stat 01"
        Me.lablPlayerStatHeading28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat28H
        '
        Me.lablPlayerStat28H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat28H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat28H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat28H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat28H.Location = New System.Drawing.Point(812, 540)
        Me.lablPlayerStat28H.Name = "lablPlayerStat28H"
        Me.lablPlayerStat28H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat28H.TabIndex = 182
        Me.lablPlayerStat28H.Tag = "28"
        Me.lablPlayerStat28H.Text = "999"
        Me.lablPlayerStat28H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading27
        '
        Me.lablPlayerStatHeading27.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading27.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading27.Location = New System.Drawing.Point(660, 496)
        Me.lablPlayerStatHeading27.Name = "lablPlayerStatHeading27"
        Me.lablPlayerStatHeading27.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading27.TabIndex = 181
        Me.lablPlayerStatHeading27.Text = "Player Stat 01"
        Me.lablPlayerStatHeading27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat27H
        '
        Me.lablPlayerStat27H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat27H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat27H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat27H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat27H.Location = New System.Drawing.Point(812, 496)
        Me.lablPlayerStat27H.Name = "lablPlayerStat27H"
        Me.lablPlayerStat27H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat27H.TabIndex = 180
        Me.lablPlayerStat27H.Tag = "27"
        Me.lablPlayerStat27H.Text = "999"
        Me.lablPlayerStat27H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading26
        '
        Me.lablPlayerStatHeading26.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading26.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading26.Location = New System.Drawing.Point(660, 452)
        Me.lablPlayerStatHeading26.Name = "lablPlayerStatHeading26"
        Me.lablPlayerStatHeading26.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading26.TabIndex = 179
        Me.lablPlayerStatHeading26.Text = "Player Stat 01"
        Me.lablPlayerStatHeading26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat26H
        '
        Me.lablPlayerStat26H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat26H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat26H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat26H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat26H.Location = New System.Drawing.Point(812, 452)
        Me.lablPlayerStat26H.Name = "lablPlayerStat26H"
        Me.lablPlayerStat26H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat26H.TabIndex = 178
        Me.lablPlayerStat26H.Tag = "26"
        Me.lablPlayerStat26H.Text = "999"
        Me.lablPlayerStat26H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading25
        '
        Me.lablPlayerStatHeading25.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading25.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading25.Location = New System.Drawing.Point(660, 408)
        Me.lablPlayerStatHeading25.Name = "lablPlayerStatHeading25"
        Me.lablPlayerStatHeading25.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading25.TabIndex = 177
        Me.lablPlayerStatHeading25.Text = "Player Stat 01"
        Me.lablPlayerStatHeading25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat25H
        '
        Me.lablPlayerStat25H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat25H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat25H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat25H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat25H.Location = New System.Drawing.Point(812, 408)
        Me.lablPlayerStat25H.Name = "lablPlayerStat25H"
        Me.lablPlayerStat25H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat25H.TabIndex = 176
        Me.lablPlayerStat25H.Tag = "25"
        Me.lablPlayerStat25H.Text = "999"
        Me.lablPlayerStat25H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading24
        '
        Me.lablPlayerStatHeading24.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading24.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading24.Location = New System.Drawing.Point(660, 364)
        Me.lablPlayerStatHeading24.Name = "lablPlayerStatHeading24"
        Me.lablPlayerStatHeading24.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading24.TabIndex = 175
        Me.lablPlayerStatHeading24.Text = "Player Stat 01"
        Me.lablPlayerStatHeading24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat24H
        '
        Me.lablPlayerStat24H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat24H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat24H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat24H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat24H.Location = New System.Drawing.Point(812, 364)
        Me.lablPlayerStat24H.Name = "lablPlayerStat24H"
        Me.lablPlayerStat24H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat24H.TabIndex = 174
        Me.lablPlayerStat24H.Tag = "24"
        Me.lablPlayerStat24H.Text = "999"
        Me.lablPlayerStat24H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading23
        '
        Me.lablPlayerStatHeading23.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading23.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading23.Location = New System.Drawing.Point(660, 320)
        Me.lablPlayerStatHeading23.Name = "lablPlayerStatHeading23"
        Me.lablPlayerStatHeading23.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading23.TabIndex = 173
        Me.lablPlayerStatHeading23.Text = "Player Stat 01"
        Me.lablPlayerStatHeading23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat23H
        '
        Me.lablPlayerStat23H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat23H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat23H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat23H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat23H.Location = New System.Drawing.Point(812, 320)
        Me.lablPlayerStat23H.Name = "lablPlayerStat23H"
        Me.lablPlayerStat23H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat23H.TabIndex = 172
        Me.lablPlayerStat23H.Tag = "23"
        Me.lablPlayerStat23H.Text = "999"
        Me.lablPlayerStat23H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading22
        '
        Me.lablPlayerStatHeading22.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading22.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading22.Location = New System.Drawing.Point(660, 276)
        Me.lablPlayerStatHeading22.Name = "lablPlayerStatHeading22"
        Me.lablPlayerStatHeading22.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading22.TabIndex = 171
        Me.lablPlayerStatHeading22.Text = "Player Stat 01"
        Me.lablPlayerStatHeading22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat22H
        '
        Me.lablPlayerStat22H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat22H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat22H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat22H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat22H.Location = New System.Drawing.Point(812, 276)
        Me.lablPlayerStat22H.Name = "lablPlayerStat22H"
        Me.lablPlayerStat22H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat22H.TabIndex = 170
        Me.lablPlayerStat22H.Tag = "22"
        Me.lablPlayerStat22H.Text = "999"
        Me.lablPlayerStat22H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading21
        '
        Me.lablPlayerStatHeading21.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading21.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading21.Location = New System.Drawing.Point(660, 232)
        Me.lablPlayerStatHeading21.Name = "lablPlayerStatHeading21"
        Me.lablPlayerStatHeading21.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading21.TabIndex = 169
        Me.lablPlayerStatHeading21.Text = "Player Stat 01"
        Me.lablPlayerStatHeading21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat21H
        '
        Me.lablPlayerStat21H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat21H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat21H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat21H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat21H.Location = New System.Drawing.Point(812, 232)
        Me.lablPlayerStat21H.Name = "lablPlayerStat21H"
        Me.lablPlayerStat21H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat21H.TabIndex = 168
        Me.lablPlayerStat21H.Tag = "21"
        Me.lablPlayerStat21H.Text = "999"
        Me.lablPlayerStat21H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading20
        '
        Me.lablPlayerStatHeading20.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading20.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading20.Location = New System.Drawing.Point(660, 188)
        Me.lablPlayerStatHeading20.Name = "lablPlayerStatHeading20"
        Me.lablPlayerStatHeading20.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading20.TabIndex = 167
        Me.lablPlayerStatHeading20.Text = "Player Stat 01"
        Me.lablPlayerStatHeading20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat20H
        '
        Me.lablPlayerStat20H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat20H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat20H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat20H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat20H.Location = New System.Drawing.Point(812, 188)
        Me.lablPlayerStat20H.Name = "lablPlayerStat20H"
        Me.lablPlayerStat20H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat20H.TabIndex = 166
        Me.lablPlayerStat20H.Tag = "20"
        Me.lablPlayerStat20H.Text = "999"
        Me.lablPlayerStat20H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading19
        '
        Me.lablPlayerStatHeading19.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading19.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading19.Location = New System.Drawing.Point(660, 144)
        Me.lablPlayerStatHeading19.Name = "lablPlayerStatHeading19"
        Me.lablPlayerStatHeading19.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading19.TabIndex = 165
        Me.lablPlayerStatHeading19.Text = "Player Stat 01"
        Me.lablPlayerStatHeading19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat19H
        '
        Me.lablPlayerStat19H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat19H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat19H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat19H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat19H.Location = New System.Drawing.Point(812, 144)
        Me.lablPlayerStat19H.Name = "lablPlayerStat19H"
        Me.lablPlayerStat19H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat19H.TabIndex = 164
        Me.lablPlayerStat19H.Tag = "19"
        Me.lablPlayerStat19H.Text = "999"
        Me.lablPlayerStat19H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading18
        '
        Me.lablPlayerStatHeading18.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading18.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading18.Location = New System.Drawing.Point(660, 100)
        Me.lablPlayerStatHeading18.Name = "lablPlayerStatHeading18"
        Me.lablPlayerStatHeading18.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading18.TabIndex = 163
        Me.lablPlayerStatHeading18.Text = "Player Stat 01"
        Me.lablPlayerStatHeading18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat18H
        '
        Me.lablPlayerStat18H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat18H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat18H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat18H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat18H.Location = New System.Drawing.Point(812, 100)
        Me.lablPlayerStat18H.Name = "lablPlayerStat18H"
        Me.lablPlayerStat18H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat18H.TabIndex = 162
        Me.lablPlayerStat18H.Tag = "18"
        Me.lablPlayerStat18H.Text = "999"
        Me.lablPlayerStat18H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading17
        '
        Me.lablPlayerStatHeading17.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading17.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading17.Location = New System.Drawing.Point(660, 56)
        Me.lablPlayerStatHeading17.Name = "lablPlayerStatHeading17"
        Me.lablPlayerStatHeading17.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading17.TabIndex = 161
        Me.lablPlayerStatHeading17.Text = "Player Stat 01"
        Me.lablPlayerStatHeading17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat17H
        '
        Me.lablPlayerStat17H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat17H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat17H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat17H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat17H.Location = New System.Drawing.Point(812, 56)
        Me.lablPlayerStat17H.Name = "lablPlayerStat17H"
        Me.lablPlayerStat17H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat17H.TabIndex = 160
        Me.lablPlayerStat17H.Tag = "17"
        Me.lablPlayerStat17H.Text = "999"
        Me.lablPlayerStat17H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading16
        '
        Me.lablPlayerStatHeading16.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading16.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading16.Location = New System.Drawing.Point(660, 12)
        Me.lablPlayerStatHeading16.Name = "lablPlayerStatHeading16"
        Me.lablPlayerStatHeading16.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading16.TabIndex = 159
        Me.lablPlayerStatHeading16.Text = "Player Stat 01"
        Me.lablPlayerStatHeading16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat16H
        '
        Me.lablPlayerStat16H.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat16H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat16H.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat16H.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat16H.Location = New System.Drawing.Point(812, 12)
        Me.lablPlayerStat16H.Name = "lablPlayerStat16H"
        Me.lablPlayerStat16H.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat16H.TabIndex = 158
        Me.lablPlayerStat16H.Tag = "16"
        Me.lablPlayerStat16H.Text = "999"
        Me.lablPlayerStat16H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayer24H
        '
        Me.btnPlayer24H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer24H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer24H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer24H.Location = New System.Drawing.Point(212, 364)
        Me.btnPlayer24H.Name = "btnPlayer24H"
        Me.btnPlayer24H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer24H.TabIndex = 157
        Me.btnPlayer24H.Tag = "24"
        Me.btnPlayer24H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer24H.UseVisualStyleBackColor = False
        '
        'btnPlayer23H
        '
        Me.btnPlayer23H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer23H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer23H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer23H.Location = New System.Drawing.Point(212, 320)
        Me.btnPlayer23H.Name = "btnPlayer23H"
        Me.btnPlayer23H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer23H.TabIndex = 156
        Me.btnPlayer23H.Tag = "23"
        Me.btnPlayer23H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer23H.UseVisualStyleBackColor = False
        '
        'btnPlayer22H
        '
        Me.btnPlayer22H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer22H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer22H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer22H.Location = New System.Drawing.Point(212, 276)
        Me.btnPlayer22H.Name = "btnPlayer22H"
        Me.btnPlayer22H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer22H.TabIndex = 155
        Me.btnPlayer22H.Tag = "22"
        Me.btnPlayer22H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer22H.UseVisualStyleBackColor = False
        '
        'btnPlayer21H
        '
        Me.btnPlayer21H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer21H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer21H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer21H.Location = New System.Drawing.Point(212, 232)
        Me.btnPlayer21H.Name = "btnPlayer21H"
        Me.btnPlayer21H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer21H.TabIndex = 154
        Me.btnPlayer21H.Tag = "21"
        Me.btnPlayer21H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer21H.UseVisualStyleBackColor = False
        '
        'btnPlayer20H
        '
        Me.btnPlayer20H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer20H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer20H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer20H.Location = New System.Drawing.Point(212, 188)
        Me.btnPlayer20H.Name = "btnPlayer20H"
        Me.btnPlayer20H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer20H.TabIndex = 153
        Me.btnPlayer20H.Tag = "20"
        Me.btnPlayer20H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer20H.UseVisualStyleBackColor = False
        '
        'btnPlayer19H
        '
        Me.btnPlayer19H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer19H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer19H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer19H.Location = New System.Drawing.Point(212, 144)
        Me.btnPlayer19H.Name = "btnPlayer19H"
        Me.btnPlayer19H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer19H.TabIndex = 152
        Me.btnPlayer19H.Tag = "19"
        Me.btnPlayer19H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer19H.UseVisualStyleBackColor = False
        '
        'btnPlayer18H
        '
        Me.btnPlayer18H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer18H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer18H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer18H.Location = New System.Drawing.Point(212, 100)
        Me.btnPlayer18H.Name = "btnPlayer18H"
        Me.btnPlayer18H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer18H.TabIndex = 151
        Me.btnPlayer18H.Tag = "18"
        Me.btnPlayer18H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer18H.UseVisualStyleBackColor = False
        '
        'btnPlayer17H
        '
        Me.btnPlayer17H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer17H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer17H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer17H.Location = New System.Drawing.Point(212, 56)
        Me.btnPlayer17H.Name = "btnPlayer17H"
        Me.btnPlayer17H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer17H.TabIndex = 150
        Me.btnPlayer17H.Tag = "17"
        Me.btnPlayer17H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer17H.UseVisualStyleBackColor = False
        '
        'btnPlayer16H
        '
        Me.btnPlayer16H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer16H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer16H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer16H.Location = New System.Drawing.Point(212, 12)
        Me.btnPlayer16H.Name = "btnPlayer16H"
        Me.btnPlayer16H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer16H.TabIndex = 149
        Me.btnPlayer16H.Tag = "16"
        Me.btnPlayer16H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer16H.UseVisualStyleBackColor = False
        '
        'btnPlayer15H
        '
        Me.btnPlayer15H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer15H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer15H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer15H.Location = New System.Drawing.Point(8, 628)
        Me.btnPlayer15H.Name = "btnPlayer15H"
        Me.btnPlayer15H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer15H.TabIndex = 148
        Me.btnPlayer15H.Tag = "15"
        Me.btnPlayer15H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer15H.UseVisualStyleBackColor = False
        '
        'btnPlayer14H
        '
        Me.btnPlayer14H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer14H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer14H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer14H.Location = New System.Drawing.Point(8, 584)
        Me.btnPlayer14H.Name = "btnPlayer14H"
        Me.btnPlayer14H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer14H.TabIndex = 147
        Me.btnPlayer14H.Tag = "14"
        Me.btnPlayer14H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer14H.UseVisualStyleBackColor = False
        '
        'btnPlayer13H
        '
        Me.btnPlayer13H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer13H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer13H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer13H.Location = New System.Drawing.Point(8, 540)
        Me.btnPlayer13H.Name = "btnPlayer13H"
        Me.btnPlayer13H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer13H.TabIndex = 146
        Me.btnPlayer13H.Tag = "13"
        Me.btnPlayer13H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer13H.UseVisualStyleBackColor = False
        '
        'btnPlayer12H
        '
        Me.btnPlayer12H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer12H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer12H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer12H.Location = New System.Drawing.Point(8, 496)
        Me.btnPlayer12H.Name = "btnPlayer12H"
        Me.btnPlayer12H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer12H.TabIndex = 145
        Me.btnPlayer12H.Tag = "12"
        Me.btnPlayer12H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer12H.UseVisualStyleBackColor = False
        '
        'btnPlayer11H
        '
        Me.btnPlayer11H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer11H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer11H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer11H.Location = New System.Drawing.Point(8, 452)
        Me.btnPlayer11H.Name = "btnPlayer11H"
        Me.btnPlayer11H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer11H.TabIndex = 144
        Me.btnPlayer11H.Tag = "11"
        Me.btnPlayer11H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer11H.UseVisualStyleBackColor = False
        '
        'btnPlayer10H
        '
        Me.btnPlayer10H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer10H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer10H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer10H.Location = New System.Drawing.Point(8, 408)
        Me.btnPlayer10H.Name = "btnPlayer10H"
        Me.btnPlayer10H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer10H.TabIndex = 143
        Me.btnPlayer10H.Tag = "10"
        Me.btnPlayer10H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer10H.UseVisualStyleBackColor = False
        '
        'btnPlayer09H
        '
        Me.btnPlayer09H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer09H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer09H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer09H.Location = New System.Drawing.Point(8, 364)
        Me.btnPlayer09H.Name = "btnPlayer09H"
        Me.btnPlayer09H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer09H.TabIndex = 142
        Me.btnPlayer09H.Tag = "9"
        Me.btnPlayer09H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer09H.UseVisualStyleBackColor = False
        '
        'btnPlayer08H
        '
        Me.btnPlayer08H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer08H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer08H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer08H.Location = New System.Drawing.Point(8, 320)
        Me.btnPlayer08H.Name = "btnPlayer08H"
        Me.btnPlayer08H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer08H.TabIndex = 141
        Me.btnPlayer08H.Tag = "8"
        Me.btnPlayer08H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer08H.UseVisualStyleBackColor = False
        '
        'btnPlayer07H
        '
        Me.btnPlayer07H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer07H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer07H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer07H.Location = New System.Drawing.Point(8, 276)
        Me.btnPlayer07H.Name = "btnPlayer07H"
        Me.btnPlayer07H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer07H.TabIndex = 140
        Me.btnPlayer07H.Tag = "7"
        Me.btnPlayer07H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer07H.UseVisualStyleBackColor = False
        '
        'btnPlayer06H
        '
        Me.btnPlayer06H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer06H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer06H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer06H.Location = New System.Drawing.Point(8, 232)
        Me.btnPlayer06H.Name = "btnPlayer06H"
        Me.btnPlayer06H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer06H.TabIndex = 139
        Me.btnPlayer06H.Tag = "6"
        Me.btnPlayer06H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer06H.UseVisualStyleBackColor = False
        '
        'btnPlayer05H
        '
        Me.btnPlayer05H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer05H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer05H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer05H.Location = New System.Drawing.Point(8, 188)
        Me.btnPlayer05H.Name = "btnPlayer05H"
        Me.btnPlayer05H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer05H.TabIndex = 138
        Me.btnPlayer05H.Tag = "5"
        Me.btnPlayer05H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer05H.UseVisualStyleBackColor = False
        '
        'btnPlayer04H
        '
        Me.btnPlayer04H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer04H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer04H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer04H.Location = New System.Drawing.Point(8, 144)
        Me.btnPlayer04H.Name = "btnPlayer04H"
        Me.btnPlayer04H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer04H.TabIndex = 137
        Me.btnPlayer04H.Tag = "4"
        Me.btnPlayer04H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer04H.UseVisualStyleBackColor = False
        '
        'btnPlayer03H
        '
        Me.btnPlayer03H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer03H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer03H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer03H.Location = New System.Drawing.Point(8, 100)
        Me.btnPlayer03H.Name = "btnPlayer03H"
        Me.btnPlayer03H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer03H.TabIndex = 136
        Me.btnPlayer03H.Tag = "3"
        Me.btnPlayer03H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer03H.UseVisualStyleBackColor = False
        '
        'btnPlayer02H
        '
        Me.btnPlayer02H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer02H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer02H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer02H.Location = New System.Drawing.Point(8, 56)
        Me.btnPlayer02H.Name = "btnPlayer02H"
        Me.btnPlayer02H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer02H.TabIndex = 135
        Me.btnPlayer02H.Tag = "2"
        Me.btnPlayer02H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer02H.UseVisualStyleBackColor = False
        '
        'btnPlayer01H
        '
        Me.btnPlayer01H.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer01H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer01H.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer01H.Location = New System.Drawing.Point(8, 12)
        Me.btnPlayer01H.Name = "btnPlayer01H"
        Me.btnPlayer01H.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer01H.TabIndex = 134
        Me.btnPlayer01H.Tag = "1"
        Me.btnPlayer01H.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer01H.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage3.Controls.Add(Me.btnClearPlayerAway)
        Me.TabPage3.Controls.Add(Me.btnResendPlayerAway)
        Me.TabPage3.Controls.Add(Me.btnPlayer25A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading15A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat15A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading14A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat14A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading13A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat13A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading12A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat12A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading11A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat11A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading10A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat10A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading09A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat09A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading08A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat08A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading07A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat07A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading06A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat06A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading05A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat05A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading04A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat04A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading03A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat03A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading02A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat02A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading01A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat01A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading30A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat30A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading29A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat29A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading28A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat28A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading27A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat27A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading26A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat26A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading25A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat25A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading24A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat24A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading23A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat23A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading22A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat22A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading21A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat21A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading20A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat20A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading19A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat19A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading18A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat18A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading17A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat17A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStatHeading16A)
        Me.TabPage3.Controls.Add(Me.lablPlayerStat16A)
        Me.TabPage3.Controls.Add(Me.btnPlayer24A)
        Me.TabPage3.Controls.Add(Me.btnPlayer23A)
        Me.TabPage3.Controls.Add(Me.btnPlayer22A)
        Me.TabPage3.Controls.Add(Me.btnPlayer21A)
        Me.TabPage3.Controls.Add(Me.btnPlayer20A)
        Me.TabPage3.Controls.Add(Me.btnPlayer19A)
        Me.TabPage3.Controls.Add(Me.btnPlayer18A)
        Me.TabPage3.Controls.Add(Me.btnPlayer17A)
        Me.TabPage3.Controls.Add(Me.btnPlayer16A)
        Me.TabPage3.Controls.Add(Me.btnPlayer15A)
        Me.TabPage3.Controls.Add(Me.btnPlayer14A)
        Me.TabPage3.Controls.Add(Me.btnPlayer13A)
        Me.TabPage3.Controls.Add(Me.btnPlayer12A)
        Me.TabPage3.Controls.Add(Me.btnPlayer11A)
        Me.TabPage3.Controls.Add(Me.btnPlayer10A)
        Me.TabPage3.Controls.Add(Me.btnPlayer09A)
        Me.TabPage3.Controls.Add(Me.btnPlayer08A)
        Me.TabPage3.Controls.Add(Me.btnPlayer07A)
        Me.TabPage3.Controls.Add(Me.btnPlayer06A)
        Me.TabPage3.Controls.Add(Me.btnPlayer05A)
        Me.TabPage3.Controls.Add(Me.btnPlayer04A)
        Me.TabPage3.Controls.Add(Me.btnPlayer03A)
        Me.TabPage3.Controls.Add(Me.btnPlayer02A)
        Me.TabPage3.Controls.Add(Me.btnPlayer01A)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(896, 684)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AWAY PLAYERS"
        '
        'btnClearPlayerAway
        '
        Me.btnClearPlayerAway.BackColor = System.Drawing.Color.DarkRed
        Me.btnClearPlayerAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPlayerAway.ForeColor = System.Drawing.Color.White
        Me.btnClearPlayerAway.Location = New System.Drawing.Point(216, 628)
        Me.btnClearPlayerAway.Name = "btnClearPlayerAway"
        Me.btnClearPlayerAway.Size = New System.Drawing.Size(200, 40)
        Me.btnClearPlayerAway.TabIndex = 305
        Me.btnClearPlayerAway.Tag = "1"
        Me.btnClearPlayerAway.Text = "Clear All Data for Current Player"
        Me.btnClearPlayerAway.UseVisualStyleBackColor = False
        '
        'btnResendPlayerAway
        '
        Me.btnResendPlayerAway.BackColor = System.Drawing.Color.DarkGreen
        Me.btnResendPlayerAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResendPlayerAway.ForeColor = System.Drawing.Color.White
        Me.btnResendPlayerAway.Location = New System.Drawing.Point(216, 584)
        Me.btnResendPlayerAway.Name = "btnResendPlayerAway"
        Me.btnResendPlayerAway.Size = New System.Drawing.Size(200, 40)
        Me.btnResendPlayerAway.TabIndex = 304
        Me.btnResendPlayerAway.Tag = "0"
        Me.btnResendPlayerAway.Text = "Resend Data"
        Me.btnResendPlayerAway.UseVisualStyleBackColor = False
        '
        'btnPlayer25A
        '
        Me.btnPlayer25A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer25A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer25A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer25A.Location = New System.Drawing.Point(212, 408)
        Me.btnPlayer25A.Name = "btnPlayer25A"
        Me.btnPlayer25A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer25A.TabIndex = 303
        Me.btnPlayer25A.Tag = "25"
        Me.btnPlayer25A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer25A.UseVisualStyleBackColor = False
        '
        'lablPlayerStatHeading15A
        '
        Me.lablPlayerStatHeading15A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading15A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading15A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading15A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading15A.Location = New System.Drawing.Point(424, 628)
        Me.lablPlayerStatHeading15A.Name = "lablPlayerStatHeading15A"
        Me.lablPlayerStatHeading15A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading15A.TabIndex = 302
        Me.lablPlayerStatHeading15A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading15A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat15A
        '
        Me.lablPlayerStat15A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat15A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat15A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat15A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat15A.Location = New System.Drawing.Point(576, 628)
        Me.lablPlayerStat15A.Name = "lablPlayerStat15A"
        Me.lablPlayerStat15A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat15A.TabIndex = 301
        Me.lablPlayerStat15A.Tag = "15"
        Me.lablPlayerStat15A.Text = "999"
        Me.lablPlayerStat15A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading14A
        '
        Me.lablPlayerStatHeading14A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading14A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading14A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading14A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading14A.Location = New System.Drawing.Point(424, 584)
        Me.lablPlayerStatHeading14A.Name = "lablPlayerStatHeading14A"
        Me.lablPlayerStatHeading14A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading14A.TabIndex = 300
        Me.lablPlayerStatHeading14A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading14A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat14A
        '
        Me.lablPlayerStat14A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat14A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat14A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat14A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat14A.Location = New System.Drawing.Point(576, 584)
        Me.lablPlayerStat14A.Name = "lablPlayerStat14A"
        Me.lablPlayerStat14A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat14A.TabIndex = 299
        Me.lablPlayerStat14A.Tag = "14"
        Me.lablPlayerStat14A.Text = "999"
        Me.lablPlayerStat14A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading13A
        '
        Me.lablPlayerStatHeading13A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading13A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading13A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading13A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading13A.Location = New System.Drawing.Point(424, 540)
        Me.lablPlayerStatHeading13A.Name = "lablPlayerStatHeading13A"
        Me.lablPlayerStatHeading13A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading13A.TabIndex = 298
        Me.lablPlayerStatHeading13A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading13A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat13A
        '
        Me.lablPlayerStat13A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat13A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat13A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat13A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat13A.Location = New System.Drawing.Point(576, 540)
        Me.lablPlayerStat13A.Name = "lablPlayerStat13A"
        Me.lablPlayerStat13A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat13A.TabIndex = 297
        Me.lablPlayerStat13A.Tag = "13"
        Me.lablPlayerStat13A.Text = "999"
        Me.lablPlayerStat13A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading12A
        '
        Me.lablPlayerStatHeading12A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading12A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading12A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading12A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading12A.Location = New System.Drawing.Point(424, 496)
        Me.lablPlayerStatHeading12A.Name = "lablPlayerStatHeading12A"
        Me.lablPlayerStatHeading12A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading12A.TabIndex = 296
        Me.lablPlayerStatHeading12A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading12A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat12A
        '
        Me.lablPlayerStat12A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat12A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat12A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat12A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat12A.Location = New System.Drawing.Point(576, 496)
        Me.lablPlayerStat12A.Name = "lablPlayerStat12A"
        Me.lablPlayerStat12A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat12A.TabIndex = 295
        Me.lablPlayerStat12A.Tag = "12"
        Me.lablPlayerStat12A.Text = "999"
        Me.lablPlayerStat12A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading11A
        '
        Me.lablPlayerStatHeading11A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading11A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading11A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading11A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading11A.Location = New System.Drawing.Point(424, 452)
        Me.lablPlayerStatHeading11A.Name = "lablPlayerStatHeading11A"
        Me.lablPlayerStatHeading11A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading11A.TabIndex = 294
        Me.lablPlayerStatHeading11A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading11A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat11A
        '
        Me.lablPlayerStat11A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat11A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat11A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat11A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat11A.Location = New System.Drawing.Point(576, 452)
        Me.lablPlayerStat11A.Name = "lablPlayerStat11A"
        Me.lablPlayerStat11A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat11A.TabIndex = 293
        Me.lablPlayerStat11A.Tag = "11"
        Me.lablPlayerStat11A.Text = "999"
        Me.lablPlayerStat11A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading10A
        '
        Me.lablPlayerStatHeading10A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading10A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading10A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading10A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading10A.Location = New System.Drawing.Point(424, 408)
        Me.lablPlayerStatHeading10A.Name = "lablPlayerStatHeading10A"
        Me.lablPlayerStatHeading10A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading10A.TabIndex = 292
        Me.lablPlayerStatHeading10A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading10A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat10A
        '
        Me.lablPlayerStat10A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat10A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat10A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat10A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat10A.Location = New System.Drawing.Point(576, 408)
        Me.lablPlayerStat10A.Name = "lablPlayerStat10A"
        Me.lablPlayerStat10A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat10A.TabIndex = 291
        Me.lablPlayerStat10A.Tag = "10"
        Me.lablPlayerStat10A.Text = "999"
        Me.lablPlayerStat10A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading09A
        '
        Me.lablPlayerStatHeading09A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading09A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading09A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading09A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading09A.Location = New System.Drawing.Point(424, 364)
        Me.lablPlayerStatHeading09A.Name = "lablPlayerStatHeading09A"
        Me.lablPlayerStatHeading09A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading09A.TabIndex = 290
        Me.lablPlayerStatHeading09A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading09A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat09A
        '
        Me.lablPlayerStat09A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat09A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat09A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat09A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat09A.Location = New System.Drawing.Point(576, 364)
        Me.lablPlayerStat09A.Name = "lablPlayerStat09A"
        Me.lablPlayerStat09A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat09A.TabIndex = 289
        Me.lablPlayerStat09A.Tag = "9"
        Me.lablPlayerStat09A.Text = "999"
        Me.lablPlayerStat09A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading08A
        '
        Me.lablPlayerStatHeading08A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading08A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading08A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading08A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading08A.Location = New System.Drawing.Point(424, 320)
        Me.lablPlayerStatHeading08A.Name = "lablPlayerStatHeading08A"
        Me.lablPlayerStatHeading08A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading08A.TabIndex = 288
        Me.lablPlayerStatHeading08A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading08A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat08A
        '
        Me.lablPlayerStat08A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat08A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat08A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat08A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat08A.Location = New System.Drawing.Point(576, 320)
        Me.lablPlayerStat08A.Name = "lablPlayerStat08A"
        Me.lablPlayerStat08A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat08A.TabIndex = 287
        Me.lablPlayerStat08A.Tag = "8"
        Me.lablPlayerStat08A.Text = "999"
        Me.lablPlayerStat08A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading07A
        '
        Me.lablPlayerStatHeading07A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading07A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading07A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading07A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading07A.Location = New System.Drawing.Point(424, 276)
        Me.lablPlayerStatHeading07A.Name = "lablPlayerStatHeading07A"
        Me.lablPlayerStatHeading07A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading07A.TabIndex = 286
        Me.lablPlayerStatHeading07A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading07A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat07A
        '
        Me.lablPlayerStat07A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat07A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat07A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat07A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat07A.Location = New System.Drawing.Point(576, 276)
        Me.lablPlayerStat07A.Name = "lablPlayerStat07A"
        Me.lablPlayerStat07A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat07A.TabIndex = 285
        Me.lablPlayerStat07A.Tag = "7"
        Me.lablPlayerStat07A.Text = "999"
        Me.lablPlayerStat07A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading06A
        '
        Me.lablPlayerStatHeading06A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading06A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading06A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading06A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading06A.Location = New System.Drawing.Point(424, 232)
        Me.lablPlayerStatHeading06A.Name = "lablPlayerStatHeading06A"
        Me.lablPlayerStatHeading06A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading06A.TabIndex = 284
        Me.lablPlayerStatHeading06A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading06A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat06A
        '
        Me.lablPlayerStat06A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat06A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat06A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat06A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat06A.Location = New System.Drawing.Point(576, 232)
        Me.lablPlayerStat06A.Name = "lablPlayerStat06A"
        Me.lablPlayerStat06A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat06A.TabIndex = 283
        Me.lablPlayerStat06A.Tag = "6"
        Me.lablPlayerStat06A.Text = "999"
        Me.lablPlayerStat06A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading05A
        '
        Me.lablPlayerStatHeading05A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading05A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading05A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading05A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading05A.Location = New System.Drawing.Point(424, 188)
        Me.lablPlayerStatHeading05A.Name = "lablPlayerStatHeading05A"
        Me.lablPlayerStatHeading05A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading05A.TabIndex = 282
        Me.lablPlayerStatHeading05A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading05A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat05A
        '
        Me.lablPlayerStat05A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat05A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat05A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat05A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat05A.Location = New System.Drawing.Point(576, 188)
        Me.lablPlayerStat05A.Name = "lablPlayerStat05A"
        Me.lablPlayerStat05A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat05A.TabIndex = 281
        Me.lablPlayerStat05A.Tag = "5"
        Me.lablPlayerStat05A.Text = "999"
        Me.lablPlayerStat05A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading04A
        '
        Me.lablPlayerStatHeading04A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading04A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading04A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading04A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading04A.Location = New System.Drawing.Point(424, 144)
        Me.lablPlayerStatHeading04A.Name = "lablPlayerStatHeading04A"
        Me.lablPlayerStatHeading04A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading04A.TabIndex = 280
        Me.lablPlayerStatHeading04A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading04A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat04A
        '
        Me.lablPlayerStat04A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat04A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat04A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat04A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat04A.Location = New System.Drawing.Point(576, 144)
        Me.lablPlayerStat04A.Name = "lablPlayerStat04A"
        Me.lablPlayerStat04A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat04A.TabIndex = 279
        Me.lablPlayerStat04A.Tag = "4"
        Me.lablPlayerStat04A.Text = "999"
        Me.lablPlayerStat04A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading03A
        '
        Me.lablPlayerStatHeading03A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading03A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading03A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading03A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading03A.Location = New System.Drawing.Point(424, 100)
        Me.lablPlayerStatHeading03A.Name = "lablPlayerStatHeading03A"
        Me.lablPlayerStatHeading03A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading03A.TabIndex = 278
        Me.lablPlayerStatHeading03A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading03A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat03A
        '
        Me.lablPlayerStat03A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat03A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat03A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat03A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat03A.Location = New System.Drawing.Point(576, 100)
        Me.lablPlayerStat03A.Name = "lablPlayerStat03A"
        Me.lablPlayerStat03A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat03A.TabIndex = 277
        Me.lablPlayerStat03A.Tag = "3"
        Me.lablPlayerStat03A.Text = "999"
        Me.lablPlayerStat03A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading02A
        '
        Me.lablPlayerStatHeading02A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading02A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading02A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading02A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading02A.Location = New System.Drawing.Point(424, 56)
        Me.lablPlayerStatHeading02A.Name = "lablPlayerStatHeading02A"
        Me.lablPlayerStatHeading02A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading02A.TabIndex = 276
        Me.lablPlayerStatHeading02A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading02A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat02A
        '
        Me.lablPlayerStat02A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat02A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat02A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat02A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat02A.Location = New System.Drawing.Point(576, 56)
        Me.lablPlayerStat02A.Name = "lablPlayerStat02A"
        Me.lablPlayerStat02A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat02A.TabIndex = 275
        Me.lablPlayerStat02A.Tag = "2"
        Me.lablPlayerStat02A.Text = "999"
        Me.lablPlayerStat02A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading01A
        '
        Me.lablPlayerStatHeading01A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading01A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading01A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading01A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading01A.Location = New System.Drawing.Point(424, 12)
        Me.lablPlayerStatHeading01A.Name = "lablPlayerStatHeading01A"
        Me.lablPlayerStatHeading01A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading01A.TabIndex = 274
        Me.lablPlayerStatHeading01A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading01A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat01A
        '
        Me.lablPlayerStat01A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat01A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat01A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat01A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat01A.Location = New System.Drawing.Point(576, 12)
        Me.lablPlayerStat01A.Name = "lablPlayerStat01A"
        Me.lablPlayerStat01A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat01A.TabIndex = 273
        Me.lablPlayerStat01A.Tag = "1"
        Me.lablPlayerStat01A.Text = "999"
        Me.lablPlayerStat01A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading30A
        '
        Me.lablPlayerStatHeading30A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading30A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading30A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading30A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading30A.Location = New System.Drawing.Point(660, 628)
        Me.lablPlayerStatHeading30A.Name = "lablPlayerStatHeading30A"
        Me.lablPlayerStatHeading30A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading30A.TabIndex = 272
        Me.lablPlayerStatHeading30A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading30A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat30A
        '
        Me.lablPlayerStat30A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat30A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat30A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat30A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat30A.Location = New System.Drawing.Point(812, 628)
        Me.lablPlayerStat30A.Name = "lablPlayerStat30A"
        Me.lablPlayerStat30A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat30A.TabIndex = 271
        Me.lablPlayerStat30A.Tag = "30"
        Me.lablPlayerStat30A.Text = "999"
        Me.lablPlayerStat30A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading29A
        '
        Me.lablPlayerStatHeading29A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading29A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading29A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading29A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading29A.Location = New System.Drawing.Point(660, 584)
        Me.lablPlayerStatHeading29A.Name = "lablPlayerStatHeading29A"
        Me.lablPlayerStatHeading29A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading29A.TabIndex = 270
        Me.lablPlayerStatHeading29A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading29A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat29A
        '
        Me.lablPlayerStat29A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat29A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat29A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat29A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat29A.Location = New System.Drawing.Point(812, 584)
        Me.lablPlayerStat29A.Name = "lablPlayerStat29A"
        Me.lablPlayerStat29A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat29A.TabIndex = 269
        Me.lablPlayerStat29A.Tag = "29"
        Me.lablPlayerStat29A.Text = "999"
        Me.lablPlayerStat29A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading28A
        '
        Me.lablPlayerStatHeading28A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading28A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading28A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading28A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading28A.Location = New System.Drawing.Point(660, 540)
        Me.lablPlayerStatHeading28A.Name = "lablPlayerStatHeading28A"
        Me.lablPlayerStatHeading28A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading28A.TabIndex = 268
        Me.lablPlayerStatHeading28A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading28A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat28A
        '
        Me.lablPlayerStat28A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat28A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat28A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat28A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat28A.Location = New System.Drawing.Point(812, 540)
        Me.lablPlayerStat28A.Name = "lablPlayerStat28A"
        Me.lablPlayerStat28A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat28A.TabIndex = 267
        Me.lablPlayerStat28A.Tag = "28"
        Me.lablPlayerStat28A.Text = "999"
        Me.lablPlayerStat28A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading27A
        '
        Me.lablPlayerStatHeading27A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading27A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading27A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading27A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading27A.Location = New System.Drawing.Point(660, 496)
        Me.lablPlayerStatHeading27A.Name = "lablPlayerStatHeading27A"
        Me.lablPlayerStatHeading27A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading27A.TabIndex = 266
        Me.lablPlayerStatHeading27A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading27A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat27A
        '
        Me.lablPlayerStat27A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat27A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat27A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat27A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat27A.Location = New System.Drawing.Point(812, 496)
        Me.lablPlayerStat27A.Name = "lablPlayerStat27A"
        Me.lablPlayerStat27A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat27A.TabIndex = 265
        Me.lablPlayerStat27A.Tag = "27"
        Me.lablPlayerStat27A.Text = "999"
        Me.lablPlayerStat27A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading26A
        '
        Me.lablPlayerStatHeading26A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading26A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading26A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading26A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading26A.Location = New System.Drawing.Point(660, 452)
        Me.lablPlayerStatHeading26A.Name = "lablPlayerStatHeading26A"
        Me.lablPlayerStatHeading26A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading26A.TabIndex = 264
        Me.lablPlayerStatHeading26A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading26A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat26A
        '
        Me.lablPlayerStat26A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat26A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat26A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat26A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat26A.Location = New System.Drawing.Point(812, 452)
        Me.lablPlayerStat26A.Name = "lablPlayerStat26A"
        Me.lablPlayerStat26A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat26A.TabIndex = 263
        Me.lablPlayerStat26A.Tag = "26"
        Me.lablPlayerStat26A.Text = "999"
        Me.lablPlayerStat26A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading25A
        '
        Me.lablPlayerStatHeading25A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading25A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading25A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading25A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading25A.Location = New System.Drawing.Point(660, 408)
        Me.lablPlayerStatHeading25A.Name = "lablPlayerStatHeading25A"
        Me.lablPlayerStatHeading25A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading25A.TabIndex = 262
        Me.lablPlayerStatHeading25A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading25A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat25A
        '
        Me.lablPlayerStat25A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat25A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat25A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat25A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat25A.Location = New System.Drawing.Point(812, 408)
        Me.lablPlayerStat25A.Name = "lablPlayerStat25A"
        Me.lablPlayerStat25A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat25A.TabIndex = 261
        Me.lablPlayerStat25A.Tag = "25"
        Me.lablPlayerStat25A.Text = "999"
        Me.lablPlayerStat25A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading24A
        '
        Me.lablPlayerStatHeading24A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading24A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading24A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading24A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading24A.Location = New System.Drawing.Point(660, 364)
        Me.lablPlayerStatHeading24A.Name = "lablPlayerStatHeading24A"
        Me.lablPlayerStatHeading24A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading24A.TabIndex = 260
        Me.lablPlayerStatHeading24A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading24A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat24A
        '
        Me.lablPlayerStat24A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat24A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat24A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat24A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat24A.Location = New System.Drawing.Point(812, 364)
        Me.lablPlayerStat24A.Name = "lablPlayerStat24A"
        Me.lablPlayerStat24A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat24A.TabIndex = 259
        Me.lablPlayerStat24A.Tag = "24"
        Me.lablPlayerStat24A.Text = "999"
        Me.lablPlayerStat24A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading23A
        '
        Me.lablPlayerStatHeading23A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading23A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading23A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading23A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading23A.Location = New System.Drawing.Point(660, 320)
        Me.lablPlayerStatHeading23A.Name = "lablPlayerStatHeading23A"
        Me.lablPlayerStatHeading23A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading23A.TabIndex = 258
        Me.lablPlayerStatHeading23A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading23A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat23A
        '
        Me.lablPlayerStat23A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat23A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat23A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat23A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat23A.Location = New System.Drawing.Point(812, 320)
        Me.lablPlayerStat23A.Name = "lablPlayerStat23A"
        Me.lablPlayerStat23A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat23A.TabIndex = 257
        Me.lablPlayerStat23A.Tag = "23"
        Me.lablPlayerStat23A.Text = "999"
        Me.lablPlayerStat23A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading22A
        '
        Me.lablPlayerStatHeading22A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading22A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading22A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading22A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading22A.Location = New System.Drawing.Point(660, 276)
        Me.lablPlayerStatHeading22A.Name = "lablPlayerStatHeading22A"
        Me.lablPlayerStatHeading22A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading22A.TabIndex = 256
        Me.lablPlayerStatHeading22A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading22A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat22A
        '
        Me.lablPlayerStat22A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat22A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat22A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat22A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat22A.Location = New System.Drawing.Point(812, 276)
        Me.lablPlayerStat22A.Name = "lablPlayerStat22A"
        Me.lablPlayerStat22A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat22A.TabIndex = 255
        Me.lablPlayerStat22A.Tag = "22"
        Me.lablPlayerStat22A.Text = "999"
        Me.lablPlayerStat22A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading21A
        '
        Me.lablPlayerStatHeading21A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading21A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading21A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading21A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading21A.Location = New System.Drawing.Point(660, 232)
        Me.lablPlayerStatHeading21A.Name = "lablPlayerStatHeading21A"
        Me.lablPlayerStatHeading21A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading21A.TabIndex = 254
        Me.lablPlayerStatHeading21A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading21A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat21A
        '
        Me.lablPlayerStat21A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat21A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat21A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat21A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat21A.Location = New System.Drawing.Point(812, 232)
        Me.lablPlayerStat21A.Name = "lablPlayerStat21A"
        Me.lablPlayerStat21A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat21A.TabIndex = 253
        Me.lablPlayerStat21A.Tag = "21"
        Me.lablPlayerStat21A.Text = "999"
        Me.lablPlayerStat21A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading20A
        '
        Me.lablPlayerStatHeading20A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading20A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading20A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading20A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading20A.Location = New System.Drawing.Point(660, 188)
        Me.lablPlayerStatHeading20A.Name = "lablPlayerStatHeading20A"
        Me.lablPlayerStatHeading20A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading20A.TabIndex = 252
        Me.lablPlayerStatHeading20A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading20A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat20A
        '
        Me.lablPlayerStat20A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat20A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat20A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat20A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat20A.Location = New System.Drawing.Point(812, 188)
        Me.lablPlayerStat20A.Name = "lablPlayerStat20A"
        Me.lablPlayerStat20A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat20A.TabIndex = 251
        Me.lablPlayerStat20A.Tag = "20"
        Me.lablPlayerStat20A.Text = "999"
        Me.lablPlayerStat20A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading19A
        '
        Me.lablPlayerStatHeading19A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading19A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading19A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading19A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading19A.Location = New System.Drawing.Point(660, 144)
        Me.lablPlayerStatHeading19A.Name = "lablPlayerStatHeading19A"
        Me.lablPlayerStatHeading19A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading19A.TabIndex = 250
        Me.lablPlayerStatHeading19A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading19A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat19A
        '
        Me.lablPlayerStat19A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat19A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat19A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat19A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat19A.Location = New System.Drawing.Point(812, 144)
        Me.lablPlayerStat19A.Name = "lablPlayerStat19A"
        Me.lablPlayerStat19A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat19A.TabIndex = 249
        Me.lablPlayerStat19A.Tag = "19"
        Me.lablPlayerStat19A.Text = "999"
        Me.lablPlayerStat19A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading18A
        '
        Me.lablPlayerStatHeading18A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading18A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading18A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading18A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading18A.Location = New System.Drawing.Point(660, 100)
        Me.lablPlayerStatHeading18A.Name = "lablPlayerStatHeading18A"
        Me.lablPlayerStatHeading18A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading18A.TabIndex = 248
        Me.lablPlayerStatHeading18A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading18A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat18A
        '
        Me.lablPlayerStat18A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat18A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat18A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat18A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat18A.Location = New System.Drawing.Point(812, 100)
        Me.lablPlayerStat18A.Name = "lablPlayerStat18A"
        Me.lablPlayerStat18A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat18A.TabIndex = 247
        Me.lablPlayerStat18A.Tag = "18"
        Me.lablPlayerStat18A.Text = "999"
        Me.lablPlayerStat18A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading17A
        '
        Me.lablPlayerStatHeading17A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading17A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading17A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading17A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading17A.Location = New System.Drawing.Point(660, 56)
        Me.lablPlayerStatHeading17A.Name = "lablPlayerStatHeading17A"
        Me.lablPlayerStatHeading17A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading17A.TabIndex = 246
        Me.lablPlayerStatHeading17A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading17A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat17A
        '
        Me.lablPlayerStat17A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat17A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat17A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat17A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat17A.Location = New System.Drawing.Point(812, 56)
        Me.lablPlayerStat17A.Name = "lablPlayerStat17A"
        Me.lablPlayerStat17A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat17A.TabIndex = 245
        Me.lablPlayerStat17A.Tag = "17"
        Me.lablPlayerStat17A.Text = "999"
        Me.lablPlayerStat17A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStatHeading16A
        '
        Me.lablPlayerStatHeading16A.BackColor = System.Drawing.Color.Black
        Me.lablPlayerStatHeading16A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStatHeading16A.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStatHeading16A.ForeColor = System.Drawing.Color.White
        Me.lablPlayerStatHeading16A.Location = New System.Drawing.Point(660, 12)
        Me.lablPlayerStatHeading16A.Name = "lablPlayerStatHeading16A"
        Me.lablPlayerStatHeading16A.Size = New System.Drawing.Size(144, 40)
        Me.lablPlayerStatHeading16A.TabIndex = 244
        Me.lablPlayerStatHeading16A.Text = "Player Stat 01"
        Me.lablPlayerStatHeading16A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPlayerStat16A
        '
        Me.lablPlayerStat16A.BackColor = System.Drawing.Color.LightGray
        Me.lablPlayerStat16A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPlayerStat16A.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPlayerStat16A.ForeColor = System.Drawing.Color.Black
        Me.lablPlayerStat16A.Location = New System.Drawing.Point(812, 12)
        Me.lablPlayerStat16A.Name = "lablPlayerStat16A"
        Me.lablPlayerStat16A.Size = New System.Drawing.Size(76, 40)
        Me.lablPlayerStat16A.TabIndex = 243
        Me.lablPlayerStat16A.Tag = "16"
        Me.lablPlayerStat16A.Text = "999"
        Me.lablPlayerStat16A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayer24A
        '
        Me.btnPlayer24A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer24A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer24A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer24A.Location = New System.Drawing.Point(212, 364)
        Me.btnPlayer24A.Name = "btnPlayer24A"
        Me.btnPlayer24A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer24A.TabIndex = 242
        Me.btnPlayer24A.Tag = "24"
        Me.btnPlayer24A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer24A.UseVisualStyleBackColor = False
        '
        'btnPlayer23A
        '
        Me.btnPlayer23A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer23A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer23A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer23A.Location = New System.Drawing.Point(212, 320)
        Me.btnPlayer23A.Name = "btnPlayer23A"
        Me.btnPlayer23A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer23A.TabIndex = 241
        Me.btnPlayer23A.Tag = "23"
        Me.btnPlayer23A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer23A.UseVisualStyleBackColor = False
        '
        'btnPlayer22A
        '
        Me.btnPlayer22A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer22A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer22A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer22A.Location = New System.Drawing.Point(212, 276)
        Me.btnPlayer22A.Name = "btnPlayer22A"
        Me.btnPlayer22A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer22A.TabIndex = 240
        Me.btnPlayer22A.Tag = "22"
        Me.btnPlayer22A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer22A.UseVisualStyleBackColor = False
        '
        'btnPlayer21A
        '
        Me.btnPlayer21A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer21A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer21A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer21A.Location = New System.Drawing.Point(212, 232)
        Me.btnPlayer21A.Name = "btnPlayer21A"
        Me.btnPlayer21A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer21A.TabIndex = 239
        Me.btnPlayer21A.Tag = "21"
        Me.btnPlayer21A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer21A.UseVisualStyleBackColor = False
        '
        'btnPlayer20A
        '
        Me.btnPlayer20A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer20A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer20A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer20A.Location = New System.Drawing.Point(212, 188)
        Me.btnPlayer20A.Name = "btnPlayer20A"
        Me.btnPlayer20A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer20A.TabIndex = 238
        Me.btnPlayer20A.Tag = "20"
        Me.btnPlayer20A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer20A.UseVisualStyleBackColor = False
        '
        'btnPlayer19A
        '
        Me.btnPlayer19A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer19A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer19A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer19A.Location = New System.Drawing.Point(212, 144)
        Me.btnPlayer19A.Name = "btnPlayer19A"
        Me.btnPlayer19A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer19A.TabIndex = 237
        Me.btnPlayer19A.Tag = "19"
        Me.btnPlayer19A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer19A.UseVisualStyleBackColor = False
        '
        'btnPlayer18A
        '
        Me.btnPlayer18A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer18A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer18A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer18A.Location = New System.Drawing.Point(212, 100)
        Me.btnPlayer18A.Name = "btnPlayer18A"
        Me.btnPlayer18A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer18A.TabIndex = 236
        Me.btnPlayer18A.Tag = "18"
        Me.btnPlayer18A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer18A.UseVisualStyleBackColor = False
        '
        'btnPlayer17A
        '
        Me.btnPlayer17A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer17A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer17A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer17A.Location = New System.Drawing.Point(212, 56)
        Me.btnPlayer17A.Name = "btnPlayer17A"
        Me.btnPlayer17A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer17A.TabIndex = 235
        Me.btnPlayer17A.Tag = "17"
        Me.btnPlayer17A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer17A.UseVisualStyleBackColor = False
        '
        'btnPlayer16A
        '
        Me.btnPlayer16A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer16A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer16A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer16A.Location = New System.Drawing.Point(212, 12)
        Me.btnPlayer16A.Name = "btnPlayer16A"
        Me.btnPlayer16A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer16A.TabIndex = 234
        Me.btnPlayer16A.Tag = "16"
        Me.btnPlayer16A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer16A.UseVisualStyleBackColor = False
        '
        'btnPlayer15A
        '
        Me.btnPlayer15A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer15A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer15A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer15A.Location = New System.Drawing.Point(8, 628)
        Me.btnPlayer15A.Name = "btnPlayer15A"
        Me.btnPlayer15A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer15A.TabIndex = 233
        Me.btnPlayer15A.Tag = "15"
        Me.btnPlayer15A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer15A.UseVisualStyleBackColor = False
        '
        'btnPlayer14A
        '
        Me.btnPlayer14A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer14A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer14A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer14A.Location = New System.Drawing.Point(8, 584)
        Me.btnPlayer14A.Name = "btnPlayer14A"
        Me.btnPlayer14A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer14A.TabIndex = 232
        Me.btnPlayer14A.Tag = "14"
        Me.btnPlayer14A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer14A.UseVisualStyleBackColor = False
        '
        'btnPlayer13A
        '
        Me.btnPlayer13A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer13A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer13A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer13A.Location = New System.Drawing.Point(8, 540)
        Me.btnPlayer13A.Name = "btnPlayer13A"
        Me.btnPlayer13A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer13A.TabIndex = 231
        Me.btnPlayer13A.Tag = "13"
        Me.btnPlayer13A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer13A.UseVisualStyleBackColor = False
        '
        'btnPlayer12A
        '
        Me.btnPlayer12A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer12A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer12A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer12A.Location = New System.Drawing.Point(8, 496)
        Me.btnPlayer12A.Name = "btnPlayer12A"
        Me.btnPlayer12A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer12A.TabIndex = 230
        Me.btnPlayer12A.Tag = "12"
        Me.btnPlayer12A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer12A.UseVisualStyleBackColor = False
        '
        'btnPlayer11A
        '
        Me.btnPlayer11A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer11A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer11A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer11A.Location = New System.Drawing.Point(8, 452)
        Me.btnPlayer11A.Name = "btnPlayer11A"
        Me.btnPlayer11A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer11A.TabIndex = 229
        Me.btnPlayer11A.Tag = "11"
        Me.btnPlayer11A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer11A.UseVisualStyleBackColor = False
        '
        'btnPlayer10A
        '
        Me.btnPlayer10A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer10A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer10A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer10A.Location = New System.Drawing.Point(8, 408)
        Me.btnPlayer10A.Name = "btnPlayer10A"
        Me.btnPlayer10A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer10A.TabIndex = 228
        Me.btnPlayer10A.Tag = "10"
        Me.btnPlayer10A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer10A.UseVisualStyleBackColor = False
        '
        'btnPlayer09A
        '
        Me.btnPlayer09A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer09A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer09A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer09A.Location = New System.Drawing.Point(8, 364)
        Me.btnPlayer09A.Name = "btnPlayer09A"
        Me.btnPlayer09A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer09A.TabIndex = 227
        Me.btnPlayer09A.Tag = "9"
        Me.btnPlayer09A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer09A.UseVisualStyleBackColor = False
        '
        'btnPlayer08A
        '
        Me.btnPlayer08A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer08A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer08A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer08A.Location = New System.Drawing.Point(8, 320)
        Me.btnPlayer08A.Name = "btnPlayer08A"
        Me.btnPlayer08A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer08A.TabIndex = 226
        Me.btnPlayer08A.Tag = "8"
        Me.btnPlayer08A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer08A.UseVisualStyleBackColor = False
        '
        'btnPlayer07A
        '
        Me.btnPlayer07A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer07A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer07A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer07A.Location = New System.Drawing.Point(8, 276)
        Me.btnPlayer07A.Name = "btnPlayer07A"
        Me.btnPlayer07A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer07A.TabIndex = 225
        Me.btnPlayer07A.Tag = "7"
        Me.btnPlayer07A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer07A.UseVisualStyleBackColor = False
        '
        'btnPlayer06A
        '
        Me.btnPlayer06A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer06A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer06A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer06A.Location = New System.Drawing.Point(8, 232)
        Me.btnPlayer06A.Name = "btnPlayer06A"
        Me.btnPlayer06A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer06A.TabIndex = 224
        Me.btnPlayer06A.Tag = "6"
        Me.btnPlayer06A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer06A.UseVisualStyleBackColor = False
        '
        'btnPlayer05A
        '
        Me.btnPlayer05A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer05A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer05A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer05A.Location = New System.Drawing.Point(8, 188)
        Me.btnPlayer05A.Name = "btnPlayer05A"
        Me.btnPlayer05A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer05A.TabIndex = 223
        Me.btnPlayer05A.Tag = "5"
        Me.btnPlayer05A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer05A.UseVisualStyleBackColor = False
        '
        'btnPlayer04A
        '
        Me.btnPlayer04A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer04A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer04A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer04A.Location = New System.Drawing.Point(8, 144)
        Me.btnPlayer04A.Name = "btnPlayer04A"
        Me.btnPlayer04A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer04A.TabIndex = 222
        Me.btnPlayer04A.Tag = "4"
        Me.btnPlayer04A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer04A.UseVisualStyleBackColor = False
        '
        'btnPlayer03A
        '
        Me.btnPlayer03A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer03A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer03A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer03A.Location = New System.Drawing.Point(8, 100)
        Me.btnPlayer03A.Name = "btnPlayer03A"
        Me.btnPlayer03A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer03A.TabIndex = 221
        Me.btnPlayer03A.Tag = "3"
        Me.btnPlayer03A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer03A.UseVisualStyleBackColor = False
        '
        'btnPlayer02A
        '
        Me.btnPlayer02A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer02A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer02A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer02A.Location = New System.Drawing.Point(8, 56)
        Me.btnPlayer02A.Name = "btnPlayer02A"
        Me.btnPlayer02A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer02A.TabIndex = 220
        Me.btnPlayer02A.Tag = "2"
        Me.btnPlayer02A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer02A.UseVisualStyleBackColor = False
        '
        'btnPlayer01A
        '
        Me.btnPlayer01A.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPlayer01A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayer01A.ForeColor = System.Drawing.Color.Black
        Me.btnPlayer01A.Location = New System.Drawing.Point(8, 12)
        Me.btnPlayer01A.Name = "btnPlayer01A"
        Me.btnPlayer01A.Size = New System.Drawing.Size(200, 40)
        Me.btnPlayer01A.TabIndex = 219
        Me.btnPlayer01A.Tag = "1"
        Me.btnPlayer01A.Text = "21- PETER WILKINSON-SMYTHE"
        Me.btnPlayer01A.UseVisualStyleBackColor = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.listViewSummaryHome)
        Me.TabPage4.Location = New System.Drawing.Point(4, 36)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(896, 684)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ALL HOME PLAYERS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'listViewSummaryHome
        '
        Me.listViewSummaryHome.BackColor = System.Drawing.Color.LemonChiffon
        Me.listViewSummaryHome.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32})
        Me.listViewSummaryHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewSummaryHome.FullRowSelect = True
        Me.listViewSummaryHome.GridLines = True
        Me.listViewSummaryHome.HideSelection = False
        Me.listViewSummaryHome.Location = New System.Drawing.Point(0, 0)
        Me.listViewSummaryHome.MultiSelect = False
        Me.listViewSummaryHome.Name = "listViewSummaryHome"
        Me.listViewSummaryHome.Size = New System.Drawing.Size(896, 676)
        Me.listViewSummaryHome.TabIndex = 0
        Me.listViewSummaryHome.UseCompatibleStateImageBehavior = False
        Me.listViewSummaryHome.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Player"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "1"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 26
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "2"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 26
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "3"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 26
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "4"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 26
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "5"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 26
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "6"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 26
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "7"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 26
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "8"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 26
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "9"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 26
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "10"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 26
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "11"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 26
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "12"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 26
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "13"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 26
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "14"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 26
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "15"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader17.Width = 26
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "16"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 26
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "17"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader19.Width = 26
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "18"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader20.Width = 26
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "19"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader21.Width = 26
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "20"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader22.Width = 26
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "21"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader23.Width = 26
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "22"
        Me.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader24.Width = 26
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "23"
        Me.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader25.Width = 26
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "24"
        Me.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader26.Width = 26
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "25"
        Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader27.Width = 26
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "26"
        Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader28.Width = 26
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "27"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader29.Width = 26
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "28"
        Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader30.Width = 26
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "29"
        Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader31.Width = 26
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "30"
        Me.ColumnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader32.Width = 26
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.listViewsummaryAway)
        Me.TabPage5.Location = New System.Drawing.Point(4, 36)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(896, 684)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "ALL AWAY PLAYERS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'listViewsummaryAway
        '
        Me.listViewsummaryAway.BackColor = System.Drawing.Color.LemonChiffon
        Me.listViewsummaryAway.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader47, Me.ColumnHeader48, Me.ColumnHeader49, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52, Me.ColumnHeader53, Me.ColumnHeader54, Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader57, Me.ColumnHeader58, Me.ColumnHeader59, Me.ColumnHeader60, Me.ColumnHeader61, Me.ColumnHeader62, Me.ColumnHeader63, Me.ColumnHeader64})
        Me.listViewsummaryAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewsummaryAway.FullRowSelect = True
        Me.listViewsummaryAway.GridLines = True
        Me.listViewsummaryAway.HideSelection = False
        Me.listViewsummaryAway.Location = New System.Drawing.Point(0, 0)
        Me.listViewsummaryAway.MultiSelect = False
        Me.listViewsummaryAway.Name = "listViewsummaryAway"
        Me.listViewsummaryAway.Size = New System.Drawing.Size(896, 676)
        Me.listViewsummaryAway.TabIndex = 1
        Me.listViewsummaryAway.UseCompatibleStateImageBehavior = False
        Me.listViewsummaryAway.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Width = 0
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Player"
        Me.ColumnHeader34.Width = 110
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "1"
        Me.ColumnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader35.Width = 26
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "2"
        Me.ColumnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader36.Width = 26
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "3"
        Me.ColumnHeader37.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader37.Width = 26
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "4"
        Me.ColumnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader38.Width = 26
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "5"
        Me.ColumnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader39.Width = 26
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "6"
        Me.ColumnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader40.Width = 26
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "7"
        Me.ColumnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader41.Width = 26
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "8"
        Me.ColumnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader42.Width = 26
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "9"
        Me.ColumnHeader43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader43.Width = 26
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "10"
        Me.ColumnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader44.Width = 26
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "11"
        Me.ColumnHeader45.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader45.Width = 26
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.Text = "12"
        Me.ColumnHeader46.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader46.Width = 26
        '
        'ColumnHeader47
        '
        Me.ColumnHeader47.Text = "13"
        Me.ColumnHeader47.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader47.Width = 26
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "14"
        Me.ColumnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader48.Width = 26
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "15"
        Me.ColumnHeader49.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader49.Width = 26
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "16"
        Me.ColumnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader50.Width = 26
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "17"
        Me.ColumnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader51.Width = 26
        '
        'ColumnHeader52
        '
        Me.ColumnHeader52.Text = "18"
        Me.ColumnHeader52.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader52.Width = 26
        '
        'ColumnHeader53
        '
        Me.ColumnHeader53.Text = "19"
        Me.ColumnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader53.Width = 26
        '
        'ColumnHeader54
        '
        Me.ColumnHeader54.Text = "20"
        Me.ColumnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader54.Width = 26
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "21"
        Me.ColumnHeader55.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader55.Width = 26
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "22"
        Me.ColumnHeader56.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader56.Width = 26
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "23"
        Me.ColumnHeader57.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader57.Width = 26
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "24"
        Me.ColumnHeader58.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader58.Width = 26
        '
        'ColumnHeader59
        '
        Me.ColumnHeader59.Text = "25"
        Me.ColumnHeader59.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader59.Width = 26
        '
        'ColumnHeader60
        '
        Me.ColumnHeader60.Text = "26"
        Me.ColumnHeader60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader60.Width = 26
        '
        'ColumnHeader61
        '
        Me.ColumnHeader61.Text = "27"
        Me.ColumnHeader61.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader61.Width = 26
        '
        'ColumnHeader62
        '
        Me.ColumnHeader62.Text = "28"
        Me.ColumnHeader62.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader62.Width = 26
        '
        'ColumnHeader63
        '
        Me.ColumnHeader63.Text = "29"
        Me.ColumnHeader63.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader63.Width = 26
        '
        'ColumnHeader64
        '
        Me.ColumnHeader64.Text = "30"
        Me.ColumnHeader64.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader64.Width = 26
        '
        'tabKickouts
        '
        Me.tabKickouts.Controls.Add(Me.btnPitchShotGood)
        Me.tabKickouts.Controls.Add(Me.btnPitchShotWide2)
        Me.tabKickouts.Controls.Add(Me.btnPitchShotGood3)
        Me.tabKickouts.Controls.Add(Me.btnPitchShotGood4)
        Me.tabKickouts.Controls.Add(Me.btnPitchShotGood2)
        Me.tabKickouts.Controls.Add(Me.lablPitchLogHeading3)
        Me.tabKickouts.Controls.Add(Me.lablPitchAway3)
        Me.tabKickouts.Controls.Add(Me.lablPitchHome3)
        Me.tabKickouts.Controls.Add(Me.btnPitchShotWide)
        Me.tabKickouts.Controls.Add(Me.GroupBox1)
        Me.tabKickouts.Controls.Add(Me.lablStepKickoutNum)
        Me.tabKickouts.Controls.Add(Me.lablPitchLogHeading2)
        Me.tabKickouts.Controls.Add(Me.lablPitchLogHeading1)
        Me.tabKickouts.Controls.Add(Me.btnDeleteKickout)
        Me.tabKickouts.Controls.Add(Me.btnStepKickouts)
        Me.tabKickouts.Controls.Add(Me.lablPitchKickoutPrompt)
        Me.tabKickouts.Controls.Add(Me.lablPitchRLArrow)
        Me.tabKickouts.Controls.Add(Me.lablPitchAway1)
        Me.tabKickouts.Controls.Add(Me.lablPitchRLTeamName)
        Me.tabKickouts.Controls.Add(Me.lablPitchHome1)
        Me.tabKickouts.Controls.Add(Me.lablPitchLRArrow)
        Me.tabKickouts.Controls.Add(Me.lablPitchAway2)
        Me.tabKickouts.Controls.Add(Me.lablPitchLRTeamName)
        Me.tabKickouts.Controls.Add(Me.lablPitchHome2)
        Me.tabKickouts.Controls.Add(Me.picBoxPitch)
        Me.tabKickouts.Controls.Add(Me.btnPitchAwayWin)
        Me.tabKickouts.Controls.Add(Me.btnPitchHomeWin)
        Me.tabKickouts.Controls.Add(Me.lablPitchAwayName)
        Me.tabKickouts.Controls.Add(Me.lablPitchHomeName)
        Me.tabKickouts.Location = New System.Drawing.Point(4, 36)
        Me.tabKickouts.Name = "tabKickouts"
        Me.tabKickouts.Size = New System.Drawing.Size(896, 684)
        Me.tabKickouts.TabIndex = 5
        Me.tabKickouts.Text = "PITCH LOGS"
        '
        'btnPitchShotGood
        '
        Me.btnPitchShotGood.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchShotGood.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotGood.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotGood.Location = New System.Drawing.Point(287, 567)
        Me.btnPitchShotGood.Name = "btnPitchShotGood"
        Me.btnPitchShotGood.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotGood.TabIndex = 166
        Me.btnPitchShotGood.Text = "Log Goal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Free..."
        Me.btnPitchShotGood.UseVisualStyleBackColor = False
        '
        'btnPitchShotWide2
        '
        Me.btnPitchShotWide2.BackColor = System.Drawing.Color.LightPink
        Me.btnPitchShotWide2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotWide2.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotWide2.Location = New System.Drawing.Point(287, 642)
        Me.btnPitchShotWide2.Name = "btnPitchShotWide2"
        Me.btnPitchShotWide2.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotWide2.TabIndex = 165
        Me.btnPitchShotWide2.Text = "Log Wide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Free..."
        Me.btnPitchShotWide2.UseVisualStyleBackColor = False
        '
        'btnPitchShotGood3
        '
        Me.btnPitchShotGood3.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchShotGood3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotGood3.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotGood3.Location = New System.Drawing.Point(287, 604)
        Me.btnPitchShotGood3.Name = "btnPitchShotGood3"
        Me.btnPitchShotGood3.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotGood3.TabIndex = 164
        Me.btnPitchShotGood3.Text = "Log Point" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Free..."
        Me.btnPitchShotGood3.UseVisualStyleBackColor = False
        '
        'btnPitchShotGood4
        '
        Me.btnPitchShotGood4.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchShotGood4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotGood4.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotGood4.Location = New System.Drawing.Point(200, 604)
        Me.btnPitchShotGood4.Name = "btnPitchShotGood4"
        Me.btnPitchShotGood4.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotGood4.TabIndex = 163
        Me.btnPitchShotGood4.Text = "Log Point" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Play..."
        Me.btnPitchShotGood4.UseVisualStyleBackColor = False
        '
        'btnPitchShotGood2
        '
        Me.btnPitchShotGood2.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchShotGood2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotGood2.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotGood2.Location = New System.Drawing.Point(200, 567)
        Me.btnPitchShotGood2.Name = "btnPitchShotGood2"
        Me.btnPitchShotGood2.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotGood2.TabIndex = 155
        Me.btnPitchShotGood2.Text = "Log Goal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Play..."
        Me.btnPitchShotGood2.UseVisualStyleBackColor = False
        '
        'lablPitchLogHeading3
        '
        Me.lablPitchLogHeading3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchLogHeading3.Location = New System.Drawing.Point(693, 576)
        Me.lablPitchLogHeading3.Name = "lablPitchLogHeading3"
        Me.lablPitchLogHeading3.Size = New System.Drawing.Size(68, 20)
        Me.lablPitchLogHeading3.TabIndex = 154
        Me.lablPitchLogHeading3.Text = "Lost"
        Me.lablPitchLogHeading3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchAway3
        '
        Me.lablPitchAway3.BackColor = System.Drawing.Color.White
        Me.lablPitchAway3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchAway3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchAway3.ForeColor = System.Drawing.Color.Black
        Me.lablPitchAway3.Location = New System.Drawing.Point(693, 640)
        Me.lablPitchAway3.Name = "lablPitchAway3"
        Me.lablPitchAway3.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchAway3.TabIndex = 153
        Me.lablPitchAway3.Tag = "1"
        Me.lablPitchAway3.Text = "0"
        Me.lablPitchAway3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchHome3
        '
        Me.lablPitchHome3.BackColor = System.Drawing.Color.White
        Me.lablPitchHome3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchHome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchHome3.ForeColor = System.Drawing.Color.Black
        Me.lablPitchHome3.Location = New System.Drawing.Point(693, 596)
        Me.lablPitchHome3.Name = "lablPitchHome3"
        Me.lablPitchHome3.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchHome3.TabIndex = 152
        Me.lablPitchHome3.Tag = "1"
        Me.lablPitchHome3.Text = "0"
        Me.lablPitchHome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPitchShotWide
        '
        Me.btnPitchShotWide.BackColor = System.Drawing.Color.LightPink
        Me.btnPitchShotWide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchShotWide.ForeColor = System.Drawing.Color.Black
        Me.btnPitchShotWide.Location = New System.Drawing.Point(200, 642)
        Me.btnPitchShotWide.Name = "btnPitchShotWide"
        Me.btnPitchShotWide.Size = New System.Drawing.Size(85, 38)
        Me.btnPitchShotWide.TabIndex = 149
        Me.btnPitchShotWide.Text = "Log Wide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from Play..."
        Me.btnPitchShotWide.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioLog4565)
        Me.GroupBox1.Controls.Add(Me.radioLogFrees)
        Me.GroupBox1.Controls.Add(Me.radioLogKickouts)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(772, 580)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 100)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'radioLog4565
        '
        Me.radioLog4565.AutoSize = True
        Me.radioLog4565.Checked = True
        Me.radioLog4565.Location = New System.Drawing.Point(8, 61)
        Me.radioLog4565.Name = "radioLog4565"
        Me.radioLog4565.Size = New System.Drawing.Size(69, 24)
        Me.radioLog4565.TabIndex = 2
        Me.radioLog4565.TabStop = True
        Me.radioLog4565.Text = "Shots"
        Me.radioLog4565.UseVisualStyleBackColor = True
        '
        'radioLogFrees
        '
        Me.radioLogFrees.AutoSize = True
        Me.radioLogFrees.Location = New System.Drawing.Point(8, 48)
        Me.radioLogFrees.Name = "radioLogFrees"
        Me.radioLogFrees.Size = New System.Drawing.Size(68, 24)
        Me.radioLogFrees.TabIndex = 1
        Me.radioLogFrees.Text = "Frees"
        Me.radioLogFrees.UseVisualStyleBackColor = True
        Me.radioLogFrees.Visible = False
        '
        'radioLogKickouts
        '
        Me.radioLogKickouts.AutoSize = True
        Me.radioLogKickouts.Location = New System.Drawing.Point(8, 31)
        Me.radioLogKickouts.Name = "radioLogKickouts"
        Me.radioLogKickouts.Size = New System.Drawing.Size(87, 24)
        Me.radioLogKickouts.TabIndex = 0
        Me.radioLogKickouts.Text = "Kickouts"
        Me.radioLogKickouts.UseVisualStyleBackColor = True
        '
        'lablStepKickoutNum
        '
        Me.lablStepKickoutNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablStepKickoutNum.Location = New System.Drawing.Point(174, 614)
        Me.lablStepKickoutNum.Name = "lablStepKickoutNum"
        Me.lablStepKickoutNum.Size = New System.Drawing.Size(32, 20)
        Me.lablStepKickoutNum.TabIndex = 146
        Me.lablStepKickoutNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchLogHeading2
        '
        Me.lablPitchLogHeading2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchLogHeading2.Location = New System.Drawing.Point(617, 576)
        Me.lablPitchLogHeading2.Name = "lablPitchLogHeading2"
        Me.lablPitchLogHeading2.Size = New System.Drawing.Size(68, 20)
        Me.lablPitchLogHeading2.TabIndex = 145
        Me.lablPitchLogHeading2.Text = "Lost"
        Me.lablPitchLogHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchLogHeading1
        '
        Me.lablPitchLogHeading1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchLogHeading1.Location = New System.Drawing.Point(541, 576)
        Me.lablPitchLogHeading1.Name = "lablPitchLogHeading1"
        Me.lablPitchLogHeading1.Size = New System.Drawing.Size(68, 20)
        Me.lablPitchLogHeading1.TabIndex = 144
        Me.lablPitchLogHeading1.Text = "Won"
        Me.lablPitchLogHeading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeleteKickout
        '
        Me.btnDeleteKickout.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDeleteKickout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteKickout.Location = New System.Drawing.Point(8, 640)
        Me.btnDeleteKickout.Name = "btnDeleteKickout"
        Me.btnDeleteKickout.Size = New System.Drawing.Size(160, 40)
        Me.btnDeleteKickout.TabIndex = 143
        Me.btnDeleteKickout.Text = "Delete this item"
        Me.btnDeleteKickout.UseVisualStyleBackColor = False
        '
        'btnStepKickouts
        '
        Me.btnStepKickouts.BackColor = System.Drawing.Color.Orange
        Me.btnStepKickouts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStepKickouts.Location = New System.Drawing.Point(8, 602)
        Me.btnStepKickouts.Name = "btnStepKickouts"
        Me.btnStepKickouts.Size = New System.Drawing.Size(160, 40)
        Me.btnStepKickouts.TabIndex = 142
        Me.btnStepKickouts.Text = "Step through KILKENNY "
        Me.btnStepKickouts.UseVisualStyleBackColor = False
        '
        'lablPitchKickoutPrompt
        '
        Me.lablPitchKickoutPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lablPitchKickoutPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchKickoutPrompt.ForeColor = System.Drawing.Color.Black
        Me.lablPitchKickoutPrompt.Location = New System.Drawing.Point(28, 539)
        Me.lablPitchKickoutPrompt.Name = "lablPitchKickoutPrompt"
        Me.lablPitchKickoutPrompt.Size = New System.Drawing.Size(840, 28)
        Me.lablPitchKickoutPrompt.TabIndex = 141
        Me.lablPitchKickoutPrompt.Tag = "1"
        Me.lablPitchKickoutPrompt.Text = " "
        Me.lablPitchKickoutPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchRLArrow
        '
        Me.lablPitchRLArrow.BackColor = System.Drawing.Color.ForestGreen
        Me.lablPitchRLArrow.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablPitchRLArrow.ForeColor = System.Drawing.Color.Black
        Me.lablPitchRLArrow.Location = New System.Drawing.Point(536, 488)
        Me.lablPitchRLArrow.Name = "lablPitchRLArrow"
        Me.lablPitchRLArrow.Size = New System.Drawing.Size(40, 32)
        Me.lablPitchRLArrow.TabIndex = 133
        Me.lablPitchRLArrow.Text = "ç"
        Me.lablPitchRLArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lablPitchAway1
        '
        Me.lablPitchAway1.BackColor = System.Drawing.Color.White
        Me.lablPitchAway1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchAway1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchAway1.ForeColor = System.Drawing.Color.Black
        Me.lablPitchAway1.Location = New System.Drawing.Point(541, 640)
        Me.lablPitchAway1.Name = "lablPitchAway1"
        Me.lablPitchAway1.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchAway1.TabIndex = 137
        Me.lablPitchAway1.Tag = "1"
        Me.lablPitchAway1.Text = "0"
        Me.lablPitchAway1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchRLTeamName
        '
        Me.lablPitchRLTeamName.BackColor = System.Drawing.Color.ForestGreen
        Me.lablPitchRLTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchRLTeamName.ForeColor = System.Drawing.Color.Black
        Me.lablPitchRLTeamName.Location = New System.Drawing.Point(576, 488)
        Me.lablPitchRLTeamName.Name = "lablPitchRLTeamName"
        Me.lablPitchRLTeamName.Size = New System.Drawing.Size(232, 32)
        Me.lablPitchRLTeamName.TabIndex = 129
        Me.lablPitchRLTeamName.Text = "CORK"
        Me.lablPitchRLTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablPitchHome1
        '
        Me.lablPitchHome1.BackColor = System.Drawing.Color.White
        Me.lablPitchHome1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchHome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchHome1.ForeColor = System.Drawing.Color.Black
        Me.lablPitchHome1.Location = New System.Drawing.Point(541, 596)
        Me.lablPitchHome1.Name = "lablPitchHome1"
        Me.lablPitchHome1.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchHome1.TabIndex = 136
        Me.lablPitchHome1.Tag = "1"
        Me.lablPitchHome1.Text = "0"
        Me.lablPitchHome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchLRArrow
        '
        Me.lablPitchLRArrow.BackColor = System.Drawing.Color.ForestGreen
        Me.lablPitchLRArrow.Font = New System.Drawing.Font("Wingdings", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lablPitchLRArrow.ForeColor = System.Drawing.Color.Black
        Me.lablPitchLRArrow.Location = New System.Drawing.Point(316, 488)
        Me.lablPitchLRArrow.Name = "lablPitchLRArrow"
        Me.lablPitchLRArrow.Size = New System.Drawing.Size(40, 32)
        Me.lablPitchLRArrow.TabIndex = 128
        Me.lablPitchLRArrow.Text = "è"
        Me.lablPitchLRArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lablPitchAway2
        '
        Me.lablPitchAway2.BackColor = System.Drawing.Color.White
        Me.lablPitchAway2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchAway2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchAway2.ForeColor = System.Drawing.Color.Black
        Me.lablPitchAway2.Location = New System.Drawing.Point(617, 640)
        Me.lablPitchAway2.Name = "lablPitchAway2"
        Me.lablPitchAway2.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchAway2.TabIndex = 135
        Me.lablPitchAway2.Tag = "1"
        Me.lablPitchAway2.Text = "0"
        Me.lablPitchAway2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablPitchLRTeamName
        '
        Me.lablPitchLRTeamName.BackColor = System.Drawing.Color.ForestGreen
        Me.lablPitchLRTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchLRTeamName.ForeColor = System.Drawing.Color.Black
        Me.lablPitchLRTeamName.Location = New System.Drawing.Point(88, 488)
        Me.lablPitchLRTeamName.Name = "lablPitchLRTeamName"
        Me.lablPitchLRTeamName.Size = New System.Drawing.Size(232, 32)
        Me.lablPitchLRTeamName.TabIndex = 126
        Me.lablPitchLRTeamName.Text = "DUBLIN"
        Me.lablPitchLRTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lablPitchHome2
        '
        Me.lablPitchHome2.BackColor = System.Drawing.Color.White
        Me.lablPitchHome2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPitchHome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchHome2.ForeColor = System.Drawing.Color.Black
        Me.lablPitchHome2.Location = New System.Drawing.Point(617, 596)
        Me.lablPitchHome2.Name = "lablPitchHome2"
        Me.lablPitchHome2.Size = New System.Drawing.Size(68, 40)
        Me.lablPitchHome2.TabIndex = 134
        Me.lablPitchHome2.Tag = "1"
        Me.lablPitchHome2.Text = "0"
        Me.lablPitchHome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBoxPitch
        '
        Me.picBoxPitch.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picBoxPitch.Image = CType(resources.GetObject("picBoxPitch.Image"), System.Drawing.Image)
        Me.picBoxPitch.Location = New System.Drawing.Point(28, 4)
        Me.picBoxPitch.Name = "picBoxPitch"
        Me.picBoxPitch.Size = New System.Drawing.Size(840, 536)
        Me.picBoxPitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxPitch.TabIndex = 0
        Me.picBoxPitch.TabStop = False
        '
        'btnPitchAwayWin
        '
        Me.btnPitchAwayWin.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchAwayWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchAwayWin.ForeColor = System.Drawing.Color.Black
        Me.btnPitchAwayWin.Location = New System.Drawing.Point(246, 640)
        Me.btnPitchAwayWin.Name = "btnPitchAwayWin"
        Me.btnPitchAwayWin.Size = New System.Drawing.Size(285, 40)
        Me.btnPitchAwayWin.TabIndex = 123
        Me.btnPitchAwayWin.Text = "Add Cork Win..."
        Me.btnPitchAwayWin.UseVisualStyleBackColor = False
        '
        'btnPitchHomeWin
        '
        Me.btnPitchHomeWin.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPitchHomeWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPitchHomeWin.ForeColor = System.Drawing.Color.Black
        Me.btnPitchHomeWin.Location = New System.Drawing.Point(246, 596)
        Me.btnPitchHomeWin.Name = "btnPitchHomeWin"
        Me.btnPitchHomeWin.Size = New System.Drawing.Size(285, 40)
        Me.btnPitchHomeWin.TabIndex = 122
        Me.btnPitchHomeWin.Text = "Add Dublin Win..."
        Me.btnPitchHomeWin.UseVisualStyleBackColor = False
        '
        'lablPitchAwayName
        '
        Me.lablPitchAwayName.BackColor = System.Drawing.Color.Transparent
        Me.lablPitchAwayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchAwayName.ForeColor = System.Drawing.Color.Black
        Me.lablPitchAwayName.Location = New System.Drawing.Point(369, 644)
        Me.lablPitchAwayName.Name = "lablPitchAwayName"
        Me.lablPitchAwayName.Size = New System.Drawing.Size(168, 32)
        Me.lablPitchAwayName.TabIndex = 151
        Me.lablPitchAwayName.Text = "DUBLIN"
        Me.lablPitchAwayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lablPitchHomeName
        '
        Me.lablPitchHomeName.BackColor = System.Drawing.Color.Transparent
        Me.lablPitchHomeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPitchHomeName.ForeColor = System.Drawing.Color.Black
        Me.lablPitchHomeName.Location = New System.Drawing.Point(369, 600)
        Me.lablPitchHomeName.Name = "lablPitchHomeName"
        Me.lablPitchHomeName.Size = New System.Drawing.Size(168, 32)
        Me.lablPitchHomeName.TabIndex = 150
        Me.lablPitchHomeName.Text = "DUBLIN"
        Me.lablPitchHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tabPenalties
        '
        Me.tabPenalties.Controls.Add(Me.lablSelectedPenalty)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyDisplay2)
        Me.tabPenalties.Controls.Add(Me.btnAdvantageClear)
        Me.tabPenalties.Controls.Add(Me.btnAdvantageAway)
        Me.tabPenalties.Controls.Add(Me.btnAdvantageHome)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyClear)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyDisplay)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName30)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName29)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName28)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName27)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName26)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName25)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName24)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName12)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName23)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName11)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName22)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName10)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName21)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName09)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName20)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName08)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName19)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName07)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName18)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName06)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName17)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName05)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName16)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName04)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName15)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName03)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName14)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName02)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName13)
        Me.tabPenalties.Controls.Add(Me.btnPenaltyName01)
        Me.tabPenalties.Location = New System.Drawing.Point(4, 36)
        Me.tabPenalties.Name = "tabPenalties"
        Me.tabPenalties.Size = New System.Drawing.Size(896, 684)
        Me.tabPenalties.TabIndex = 8
        Me.tabPenalties.Text = "PENALTIES"
        '
        'lablSelectedPenalty
        '
        Me.lablSelectedPenalty.BackColor = System.Drawing.Color.Black
        Me.lablSelectedPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablSelectedPenalty.ForeColor = System.Drawing.Color.White
        Me.lablSelectedPenalty.Location = New System.Drawing.Point(30, 616)
        Me.lablSelectedPenalty.Name = "lablSelectedPenalty"
        Me.lablSelectedPenalty.Size = New System.Drawing.Size(282, 20)
        Me.lablSelectedPenalty.TabIndex = 211
        Me.lablSelectedPenalty.Text = " "
        Me.lablSelectedPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPenaltyDisplay2
        '
        Me.btnPenaltyDisplay2.BackColor = System.Drawing.Color.DarkGreen
        Me.btnPenaltyDisplay2.Enabled = False
        Me.btnPenaltyDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenaltyDisplay2.ForeColor = System.Drawing.Color.White
        Me.btnPenaltyDisplay2.Location = New System.Drawing.Point(172, 639)
        Me.btnPenaltyDisplay2.Name = "btnPenaltyDisplay2"
        Me.btnPenaltyDisplay2.Size = New System.Drawing.Size(140, 40)
        Me.btnPenaltyDisplay2.TabIndex = 35
        Me.btnPenaltyDisplay2.Tag = "30"
        Me.btnPenaltyDisplay2.Text = " "
        Me.btnPenaltyDisplay2.UseVisualStyleBackColor = False
        '
        'btnAdvantageClear
        '
        Me.btnAdvantageClear.BackColor = System.Drawing.Color.DarkRed
        Me.btnAdvantageClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvantageClear.ForeColor = System.Drawing.Color.White
        Me.btnAdvantageClear.Location = New System.Drawing.Point(764, 639)
        Me.btnAdvantageClear.Name = "btnAdvantageClear"
        Me.btnAdvantageClear.Size = New System.Drawing.Size(100, 40)
        Me.btnAdvantageClear.TabIndex = 34
        Me.btnAdvantageClear.Tag = "30"
        Me.btnAdvantageClear.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advantage"
        Me.btnAdvantageClear.UseVisualStyleBackColor = False
        '
        'btnAdvantageAway
        '
        Me.btnAdvantageAway.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAdvantageAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvantageAway.ForeColor = System.Drawing.Color.White
        Me.btnAdvantageAway.Location = New System.Drawing.Point(608, 639)
        Me.btnAdvantageAway.Name = "btnAdvantageAway"
        Me.btnAdvantageAway.Size = New System.Drawing.Size(140, 40)
        Me.btnAdvantageAway.TabIndex = 33
        Me.btnAdvantageAway.Tag = "30"
        Me.btnAdvantageAway.Text = "Away" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advantage"
        Me.btnAdvantageAway.UseVisualStyleBackColor = False
        '
        'btnAdvantageHome
        '
        Me.btnAdvantageHome.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAdvantageHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvantageHome.ForeColor = System.Drawing.Color.White
        Me.btnAdvantageHome.Location = New System.Drawing.Point(466, 639)
        Me.btnAdvantageHome.Name = "btnAdvantageHome"
        Me.btnAdvantageHome.Size = New System.Drawing.Size(140, 40)
        Me.btnAdvantageHome.TabIndex = 32
        Me.btnAdvantageHome.Tag = "30"
        Me.btnAdvantageHome.Text = "Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Advantage"
        Me.btnAdvantageHome.UseVisualStyleBackColor = False
        '
        'btnPenaltyClear
        '
        Me.btnPenaltyClear.BackColor = System.Drawing.Color.DarkRed
        Me.btnPenaltyClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenaltyClear.ForeColor = System.Drawing.Color.White
        Me.btnPenaltyClear.Location = New System.Drawing.Point(328, 639)
        Me.btnPenaltyClear.Name = "btnPenaltyClear"
        Me.btnPenaltyClear.Size = New System.Drawing.Size(100, 40)
        Me.btnPenaltyClear.TabIndex = 31
        Me.btnPenaltyClear.Tag = "30"
        Me.btnPenaltyClear.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Penalty"
        Me.btnPenaltyClear.UseVisualStyleBackColor = False
        '
        'btnPenaltyDisplay
        '
        Me.btnPenaltyDisplay.BackColor = System.Drawing.Color.DarkGreen
        Me.btnPenaltyDisplay.Enabled = False
        Me.btnPenaltyDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenaltyDisplay.ForeColor = System.Drawing.Color.White
        Me.btnPenaltyDisplay.Location = New System.Drawing.Point(30, 639)
        Me.btnPenaltyDisplay.Name = "btnPenaltyDisplay"
        Me.btnPenaltyDisplay.Size = New System.Drawing.Size(140, 40)
        Me.btnPenaltyDisplay.TabIndex = 30
        Me.btnPenaltyDisplay.Tag = "30"
        Me.btnPenaltyDisplay.Text = " "
        Me.btnPenaltyDisplay.UseVisualStyleBackColor = False
        '
        'btnPenaltyName30
        '
        Me.btnPenaltyName30.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName30.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName30.Location = New System.Drawing.Point(465, 565)
        Me.btnPenaltyName30.Name = "btnPenaltyName30"
        Me.btnPenaltyName30.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName30.TabIndex = 29
        Me.btnPenaltyName30.Tag = "30"
        Me.btnPenaltyName30.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName30.UseVisualStyleBackColor = False
        '
        'btnPenaltyName29
        '
        Me.btnPenaltyName29.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName29.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName29.Location = New System.Drawing.Point(465, 525)
        Me.btnPenaltyName29.Name = "btnPenaltyName29"
        Me.btnPenaltyName29.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName29.TabIndex = 28
        Me.btnPenaltyName29.Tag = "29"
        Me.btnPenaltyName29.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName29.UseVisualStyleBackColor = False
        '
        'btnPenaltyName28
        '
        Me.btnPenaltyName28.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName28.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName28.Location = New System.Drawing.Point(465, 485)
        Me.btnPenaltyName28.Name = "btnPenaltyName28"
        Me.btnPenaltyName28.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName28.TabIndex = 27
        Me.btnPenaltyName28.Tag = "28"
        Me.btnPenaltyName28.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName28.UseVisualStyleBackColor = False
        '
        'btnPenaltyName27
        '
        Me.btnPenaltyName27.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName27.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName27.Location = New System.Drawing.Point(464, 445)
        Me.btnPenaltyName27.Name = "btnPenaltyName27"
        Me.btnPenaltyName27.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName27.TabIndex = 26
        Me.btnPenaltyName27.Tag = "27"
        Me.btnPenaltyName27.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName27.UseVisualStyleBackColor = False
        '
        'btnPenaltyName26
        '
        Me.btnPenaltyName26.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName26.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName26.Location = New System.Drawing.Point(464, 405)
        Me.btnPenaltyName26.Name = "btnPenaltyName26"
        Me.btnPenaltyName26.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName26.TabIndex = 25
        Me.btnPenaltyName26.Tag = "26"
        Me.btnPenaltyName26.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName26.UseVisualStyleBackColor = False
        '
        'btnPenaltyName25
        '
        Me.btnPenaltyName25.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName25.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName25.Location = New System.Drawing.Point(465, 365)
        Me.btnPenaltyName25.Name = "btnPenaltyName25"
        Me.btnPenaltyName25.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName25.TabIndex = 24
        Me.btnPenaltyName25.Tag = "25"
        Me.btnPenaltyName25.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName25.UseVisualStyleBackColor = False
        '
        'btnPenaltyName24
        '
        Me.btnPenaltyName24.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName24.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName24.Location = New System.Drawing.Point(465, 325)
        Me.btnPenaltyName24.Name = "btnPenaltyName24"
        Me.btnPenaltyName24.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName24.TabIndex = 23
        Me.btnPenaltyName24.Tag = "24"
        Me.btnPenaltyName24.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName24.UseVisualStyleBackColor = False
        '
        'btnPenaltyName12
        '
        Me.btnPenaltyName12.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName12.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName12.Location = New System.Drawing.Point(30, 445)
        Me.btnPenaltyName12.Name = "btnPenaltyName12"
        Me.btnPenaltyName12.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName12.TabIndex = 22
        Me.btnPenaltyName12.Tag = "12"
        Me.btnPenaltyName12.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName12.UseVisualStyleBackColor = False
        '
        'btnPenaltyName23
        '
        Me.btnPenaltyName23.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName23.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName23.Location = New System.Drawing.Point(465, 285)
        Me.btnPenaltyName23.Name = "btnPenaltyName23"
        Me.btnPenaltyName23.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName23.TabIndex = 21
        Me.btnPenaltyName23.Tag = "23"
        Me.btnPenaltyName23.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName23.UseVisualStyleBackColor = False
        '
        'btnPenaltyName11
        '
        Me.btnPenaltyName11.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName11.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName11.Location = New System.Drawing.Point(30, 405)
        Me.btnPenaltyName11.Name = "btnPenaltyName11"
        Me.btnPenaltyName11.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName11.TabIndex = 20
        Me.btnPenaltyName11.Tag = "11"
        Me.btnPenaltyName11.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName11.UseVisualStyleBackColor = False
        '
        'btnPenaltyName22
        '
        Me.btnPenaltyName22.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName22.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName22.Location = New System.Drawing.Point(465, 245)
        Me.btnPenaltyName22.Name = "btnPenaltyName22"
        Me.btnPenaltyName22.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName22.TabIndex = 19
        Me.btnPenaltyName22.Tag = "22"
        Me.btnPenaltyName22.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName22.UseVisualStyleBackColor = False
        '
        'btnPenaltyName10
        '
        Me.btnPenaltyName10.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName10.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName10.Location = New System.Drawing.Point(31, 365)
        Me.btnPenaltyName10.Name = "btnPenaltyName10"
        Me.btnPenaltyName10.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName10.TabIndex = 18
        Me.btnPenaltyName10.Tag = "10"
        Me.btnPenaltyName10.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName10.UseVisualStyleBackColor = False
        '
        'btnPenaltyName21
        '
        Me.btnPenaltyName21.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName21.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName21.Location = New System.Drawing.Point(464, 205)
        Me.btnPenaltyName21.Name = "btnPenaltyName21"
        Me.btnPenaltyName21.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName21.TabIndex = 17
        Me.btnPenaltyName21.Tag = "21"
        Me.btnPenaltyName21.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName21.UseVisualStyleBackColor = False
        '
        'btnPenaltyName09
        '
        Me.btnPenaltyName09.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName09.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName09.Location = New System.Drawing.Point(31, 325)
        Me.btnPenaltyName09.Name = "btnPenaltyName09"
        Me.btnPenaltyName09.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName09.TabIndex = 16
        Me.btnPenaltyName09.Tag = "9"
        Me.btnPenaltyName09.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName09.UseVisualStyleBackColor = False
        '
        'btnPenaltyName20
        '
        Me.btnPenaltyName20.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName20.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName20.Location = New System.Drawing.Point(464, 165)
        Me.btnPenaltyName20.Name = "btnPenaltyName20"
        Me.btnPenaltyName20.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName20.TabIndex = 15
        Me.btnPenaltyName20.Tag = "20"
        Me.btnPenaltyName20.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName20.UseVisualStyleBackColor = False
        '
        'btnPenaltyName08
        '
        Me.btnPenaltyName08.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName08.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName08.Location = New System.Drawing.Point(30, 285)
        Me.btnPenaltyName08.Name = "btnPenaltyName08"
        Me.btnPenaltyName08.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName08.TabIndex = 14
        Me.btnPenaltyName08.Tag = "8"
        Me.btnPenaltyName08.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName08.UseVisualStyleBackColor = False
        '
        'btnPenaltyName19
        '
        Me.btnPenaltyName19.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName19.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName19.Location = New System.Drawing.Point(465, 125)
        Me.btnPenaltyName19.Name = "btnPenaltyName19"
        Me.btnPenaltyName19.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName19.TabIndex = 13
        Me.btnPenaltyName19.Tag = "19"
        Me.btnPenaltyName19.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName19.UseVisualStyleBackColor = False
        '
        'btnPenaltyName07
        '
        Me.btnPenaltyName07.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName07.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName07.Location = New System.Drawing.Point(31, 245)
        Me.btnPenaltyName07.Name = "btnPenaltyName07"
        Me.btnPenaltyName07.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName07.TabIndex = 12
        Me.btnPenaltyName07.Tag = "7"
        Me.btnPenaltyName07.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName07.UseVisualStyleBackColor = False
        '
        'btnPenaltyName18
        '
        Me.btnPenaltyName18.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName18.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName18.Location = New System.Drawing.Point(464, 85)
        Me.btnPenaltyName18.Name = "btnPenaltyName18"
        Me.btnPenaltyName18.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName18.TabIndex = 11
        Me.btnPenaltyName18.Tag = "18"
        Me.btnPenaltyName18.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName18.UseVisualStyleBackColor = False
        '
        'btnPenaltyName06
        '
        Me.btnPenaltyName06.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName06.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName06.Location = New System.Drawing.Point(31, 205)
        Me.btnPenaltyName06.Name = "btnPenaltyName06"
        Me.btnPenaltyName06.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName06.TabIndex = 10
        Me.btnPenaltyName06.Tag = "6"
        Me.btnPenaltyName06.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName06.UseVisualStyleBackColor = False
        '
        'btnPenaltyName17
        '
        Me.btnPenaltyName17.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName17.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName17.Location = New System.Drawing.Point(464, 45)
        Me.btnPenaltyName17.Name = "btnPenaltyName17"
        Me.btnPenaltyName17.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName17.TabIndex = 9
        Me.btnPenaltyName17.Tag = "17"
        Me.btnPenaltyName17.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName17.UseVisualStyleBackColor = False
        '
        'btnPenaltyName05
        '
        Me.btnPenaltyName05.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName05.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName05.Location = New System.Drawing.Point(31, 165)
        Me.btnPenaltyName05.Name = "btnPenaltyName05"
        Me.btnPenaltyName05.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName05.TabIndex = 8
        Me.btnPenaltyName05.Tag = "5"
        Me.btnPenaltyName05.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName05.UseVisualStyleBackColor = False
        '
        'btnPenaltyName16
        '
        Me.btnPenaltyName16.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName16.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName16.Location = New System.Drawing.Point(464, 5)
        Me.btnPenaltyName16.Name = "btnPenaltyName16"
        Me.btnPenaltyName16.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName16.TabIndex = 7
        Me.btnPenaltyName16.Tag = "16"
        Me.btnPenaltyName16.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName16.UseVisualStyleBackColor = False
        '
        'btnPenaltyName04
        '
        Me.btnPenaltyName04.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName04.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName04.Location = New System.Drawing.Point(30, 125)
        Me.btnPenaltyName04.Name = "btnPenaltyName04"
        Me.btnPenaltyName04.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName04.TabIndex = 6
        Me.btnPenaltyName04.Tag = "4"
        Me.btnPenaltyName04.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName04.UseVisualStyleBackColor = False
        '
        'btnPenaltyName15
        '
        Me.btnPenaltyName15.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName15.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName15.Location = New System.Drawing.Point(30, 565)
        Me.btnPenaltyName15.Name = "btnPenaltyName15"
        Me.btnPenaltyName15.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName15.TabIndex = 5
        Me.btnPenaltyName15.Tag = "15"
        Me.btnPenaltyName15.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName15.UseVisualStyleBackColor = False
        '
        'btnPenaltyName03
        '
        Me.btnPenaltyName03.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName03.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName03.Location = New System.Drawing.Point(30, 85)
        Me.btnPenaltyName03.Name = "btnPenaltyName03"
        Me.btnPenaltyName03.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName03.TabIndex = 4
        Me.btnPenaltyName03.Tag = "3"
        Me.btnPenaltyName03.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName03.UseVisualStyleBackColor = False
        '
        'btnPenaltyName14
        '
        Me.btnPenaltyName14.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName14.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName14.Location = New System.Drawing.Point(31, 525)
        Me.btnPenaltyName14.Name = "btnPenaltyName14"
        Me.btnPenaltyName14.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName14.TabIndex = 3
        Me.btnPenaltyName14.Tag = "14"
        Me.btnPenaltyName14.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName14.UseVisualStyleBackColor = False
        '
        'btnPenaltyName02
        '
        Me.btnPenaltyName02.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName02.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName02.Location = New System.Drawing.Point(30, 45)
        Me.btnPenaltyName02.Name = "btnPenaltyName02"
        Me.btnPenaltyName02.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName02.TabIndex = 2
        Me.btnPenaltyName02.Tag = "2"
        Me.btnPenaltyName02.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName02.UseVisualStyleBackColor = False
        '
        'btnPenaltyName13
        '
        Me.btnPenaltyName13.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName13.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName13.Location = New System.Drawing.Point(30, 485)
        Me.btnPenaltyName13.Name = "btnPenaltyName13"
        Me.btnPenaltyName13.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName13.TabIndex = 1
        Me.btnPenaltyName13.Tag = "13"
        Me.btnPenaltyName13.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName13.UseVisualStyleBackColor = False
        '
        'btnPenaltyName01
        '
        Me.btnPenaltyName01.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnPenaltyName01.ForeColor = System.Drawing.Color.Black
        Me.btnPenaltyName01.Location = New System.Drawing.Point(30, 5)
        Me.btnPenaltyName01.Name = "btnPenaltyName01"
        Me.btnPenaltyName01.Size = New System.Drawing.Size(400, 40)
        Me.btnPenaltyName01.TabIndex = 0
        Me.btnPenaltyName01.Tag = "1"
        Me.btnPenaltyName01.Text = "NAME OF THE PENALTY"
        Me.btnPenaltyName01.UseVisualStyleBackColor = False
        '
        'tabCarries
        '
        Me.tabCarries.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tabCarries.Controls.Add(Me.listViewCarriesAway)
        Me.tabCarries.Controls.Add(Me.lablAwayNameSL2)
        Me.tabCarries.Controls.Add(Me.lablHomeNameSL2)
        Me.tabCarries.Controls.Add(Me.listViewCarriesHome)
        Me.tabCarries.Location = New System.Drawing.Point(4, 36)
        Me.tabCarries.Name = "tabCarries"
        Me.tabCarries.Size = New System.Drawing.Size(896, 684)
        Me.tabCarries.TabIndex = 9
        Me.tabCarries.Text = "CARRIES"
        '
        'listViewCarriesAway
        '
        Me.listViewCarriesAway.BackColor = System.Drawing.Color.Black
        Me.listViewCarriesAway.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listViewCarriesAway.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader67, Me.ColumnHeader70, Me.ColumnHeader68})
        Me.listViewCarriesAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewCarriesAway.ForeColor = System.Drawing.Color.White
        Me.listViewCarriesAway.FullRowSelect = True
        Me.listViewCarriesAway.GridLines = True
        Me.listViewCarriesAway.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.listViewCarriesAway.HideSelection = False
        Me.listViewCarriesAway.Location = New System.Drawing.Point(485, 34)
        Me.listViewCarriesAway.MultiSelect = False
        Me.listViewCarriesAway.Name = "listViewCarriesAway"
        Me.listViewCarriesAway.Size = New System.Drawing.Size(350, 634)
        Me.listViewCarriesAway.TabIndex = 96
        Me.listViewCarriesAway.UseCompatibleStateImageBehavior = False
        Me.listViewCarriesAway.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader67
        '
        Me.ColumnHeader67.Text = "ID"
        Me.ColumnHeader67.Width = 0
        '
        'ColumnHeader70
        '
        Me.ColumnHeader70.Text = "Num"
        Me.ColumnHeader70.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader70.Width = 50
        '
        'ColumnHeader68
        '
        Me.ColumnHeader68.Text = "Player"
        Me.ColumnHeader68.Width = 300
        '
        'lablAwayNameSL2
        '
        Me.lablAwayNameSL2.BackColor = System.Drawing.Color.Transparent
        Me.lablAwayNameSL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayNameSL2.ForeColor = System.Drawing.Color.White
        Me.lablAwayNameSL2.Location = New System.Drawing.Point(485, 8)
        Me.lablAwayNameSL2.Name = "lablAwayNameSL2"
        Me.lablAwayNameSL2.Size = New System.Drawing.Size(304, 26)
        Me.lablAwayNameSL2.TabIndex = 95
        Me.lablAwayNameSL2.Text = "TOTTENHAM"
        Me.lablAwayNameSL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablHomeNameSL2
        '
        Me.lablHomeNameSL2.BackColor = System.Drawing.Color.Transparent
        Me.lablHomeNameSL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeNameSL2.ForeColor = System.Drawing.Color.White
        Me.lablHomeNameSL2.Location = New System.Drawing.Point(93, 8)
        Me.lablHomeNameSL2.Name = "lablHomeNameSL2"
        Me.lablHomeNameSL2.Size = New System.Drawing.Size(304, 26)
        Me.lablHomeNameSL2.TabIndex = 94
        Me.lablHomeNameSL2.Text = "TOTTENHAM"
        Me.lablHomeNameSL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listViewCarriesHome
        '
        Me.listViewCarriesHome.BackColor = System.Drawing.Color.Black
        Me.listViewCarriesHome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listViewCarriesHome.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader65, Me.ColumnHeader69, Me.ColumnHeader66})
        Me.listViewCarriesHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewCarriesHome.ForeColor = System.Drawing.Color.White
        Me.listViewCarriesHome.FullRowSelect = True
        Me.listViewCarriesHome.GridLines = True
        Me.listViewCarriesHome.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.listViewCarriesHome.HideSelection = False
        Me.listViewCarriesHome.Location = New System.Drawing.Point(93, 34)
        Me.listViewCarriesHome.MultiSelect = False
        Me.listViewCarriesHome.Name = "listViewCarriesHome"
        Me.listViewCarriesHome.Size = New System.Drawing.Size(350, 634)
        Me.listViewCarriesHome.TabIndex = 1
        Me.listViewCarriesHome.UseCompatibleStateImageBehavior = False
        Me.listViewCarriesHome.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader65
        '
        Me.ColumnHeader65.Text = "ID"
        Me.ColumnHeader65.Width = 0
        '
        'ColumnHeader69
        '
        Me.ColumnHeader69.Text = "Num"
        Me.ColumnHeader69.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader69.Width = 50
        '
        'ColumnHeader66
        '
        Me.ColumnHeader66.Text = "Player"
        Me.ColumnHeader66.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.btnLock)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 24)
        Me.Panel1.TabIndex = 138
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.Location = New System.Drawing.Point(0, 0)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(16, 24)
        Me.btnLock.TabIndex = 0
        Me.btnLock.Text = "X"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 396)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1280, 84)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Unlock by clicking button top left"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1280, 84)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "MatchLog control is locked"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupRemotePossession
        '
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaR3)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaR2)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaR1)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaR4)
        Me.groupRemotePossession.Controls.Add(Me.Label13)
        Me.groupRemotePossession.Controls.Add(Me.Label12)
        Me.groupRemotePossession.Controls.Add(Me.Label19)
        Me.groupRemotePossession.Controls.Add(Me.Label20)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteInPlay)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteMatchTime)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAwayTeam)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteHomeTeam)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaS1)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaS2)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAreaS3)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteAwayPossession)
        Me.groupRemotePossession.Controls.Add(Me.lablRemoteHomePossession)
        Me.groupRemotePossession.ForeColor = System.Drawing.Color.White
        Me.groupRemotePossession.Location = New System.Drawing.Point(1040, 100)
        Me.groupRemotePossession.Name = "groupRemotePossession"
        Me.groupRemotePossession.Size = New System.Drawing.Size(312, 208)
        Me.groupRemotePossession.TabIndex = 139
        Me.groupRemotePossession.TabStop = False
        '
        'lablRemoteAreaR3
        '
        Me.lablRemoteAreaR3.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaR3.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaR3.Location = New System.Drawing.Point(160, 168)
        Me.lablRemoteAreaR3.Name = "lablRemoteAreaR3"
        Me.lablRemoteAreaR3.Size = New System.Drawing.Size(68, 28)
        Me.lablRemoteAreaR3.TabIndex = 214
        Me.lablRemoteAreaR3.Tag = "3"
        Me.lablRemoteAreaR3.Text = "100%"
        Me.lablRemoteAreaR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaR2
        '
        Me.lablRemoteAreaR2.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaR2.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaR2.Location = New System.Drawing.Point(84, 168)
        Me.lablRemoteAreaR2.Name = "lablRemoteAreaR2"
        Me.lablRemoteAreaR2.Size = New System.Drawing.Size(68, 28)
        Me.lablRemoteAreaR2.TabIndex = 213
        Me.lablRemoteAreaR2.Tag = "3"
        Me.lablRemoteAreaR2.Text = "100%"
        Me.lablRemoteAreaR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaR1
        '
        Me.lablRemoteAreaR1.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaR1.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaR1.Location = New System.Drawing.Point(8, 168)
        Me.lablRemoteAreaR1.Name = "lablRemoteAreaR1"
        Me.lablRemoteAreaR1.Size = New System.Drawing.Size(68, 28)
        Me.lablRemoteAreaR1.TabIndex = 212
        Me.lablRemoteAreaR1.Tag = "3"
        Me.lablRemoteAreaR1.Text = "100%"
        Me.lablRemoteAreaR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaR4
        '
        Me.lablRemoteAreaR4.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaR4.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaR4.Location = New System.Drawing.Point(236, 168)
        Me.lablRemoteAreaR4.Name = "lablRemoteAreaR4"
        Me.lablRemoteAreaR4.Size = New System.Drawing.Size(68, 28)
        Me.lablRemoteAreaR4.TabIndex = 211
        Me.lablRemoteAreaR4.Tag = "3"
        Me.lablRemoteAreaR4.Text = "100%"
        Me.lablRemoteAreaR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(60, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 20)
        Me.Label13.TabIndex = 210
        Me.Label13.Text = "Action Areas"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(60, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 20)
        Me.Label12.TabIndex = 209
        Me.Label12.Text = "Match Possession"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(160, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 20)
        Me.Label19.TabIndex = 208
        Me.Label19.Text = "In Play"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(60, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 20)
        Me.Label20.TabIndex = 207
        Me.Label20.Text = "Period Time"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteInPlay
        '
        Me.lablRemoteInPlay.BackColor = System.Drawing.Color.White
        Me.lablRemoteInPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteInPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteInPlay.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteInPlay.Location = New System.Drawing.Point(160, 36)
        Me.lablRemoteInPlay.Name = "lablRemoteInPlay"
        Me.lablRemoteInPlay.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteInPlay.TabIndex = 206
        Me.lablRemoteInPlay.Text = "77%"
        Me.lablRemoteInPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteMatchTime
        '
        Me.lablRemoteMatchTime.BackColor = System.Drawing.Color.White
        Me.lablRemoteMatchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteMatchTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteMatchTime.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteMatchTime.Location = New System.Drawing.Point(60, 36)
        Me.lablRemoteMatchTime.Name = "lablRemoteMatchTime"
        Me.lablRemoteMatchTime.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteMatchTime.TabIndex = 205
        Me.lablRemoteMatchTime.Text = "88%"
        Me.lablRemoteMatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAwayTeam
        '
        Me.lablRemoteAwayTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAwayTeam.ForeColor = System.Drawing.Color.White
        Me.lablRemoteAwayTeam.Location = New System.Drawing.Point(160, 92)
        Me.lablRemoteAwayTeam.Name = "lablRemoteAwayTeam"
        Me.lablRemoteAwayTeam.Size = New System.Drawing.Size(96, 20)
        Me.lablRemoteAwayTeam.TabIndex = 204
        Me.lablRemoteAwayTeam.Text = "Away"
        Me.lablRemoteAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteHomeTeam
        '
        Me.lablRemoteHomeTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteHomeTeam.ForeColor = System.Drawing.Color.White
        Me.lablRemoteHomeTeam.Location = New System.Drawing.Point(60, 92)
        Me.lablRemoteHomeTeam.Name = "lablRemoteHomeTeam"
        Me.lablRemoteHomeTeam.Size = New System.Drawing.Size(96, 20)
        Me.lablRemoteHomeTeam.TabIndex = 203
        Me.lablRemoteHomeTeam.Text = "Home"
        Me.lablRemoteHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaS1
        '
        Me.lablRemoteAreaS1.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaS1.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaS1.Location = New System.Drawing.Point(8, 168)
        Me.lablRemoteAreaS1.Name = "lablRemoteAreaS1"
        Me.lablRemoteAreaS1.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteAreaS1.TabIndex = 200
        Me.lablRemoteAreaS1.Tag = "1"
        Me.lablRemoteAreaS1.Text = "100%"
        Me.lablRemoteAreaS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaS2
        '
        Me.lablRemoteAreaS2.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaS2.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaS2.Location = New System.Drawing.Point(108, 168)
        Me.lablRemoteAreaS2.Name = "lablRemoteAreaS2"
        Me.lablRemoteAreaS2.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteAreaS2.TabIndex = 201
        Me.lablRemoteAreaS2.Tag = "2"
        Me.lablRemoteAreaS2.Text = "100%"
        Me.lablRemoteAreaS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAreaS3
        '
        Me.lablRemoteAreaS3.BackColor = System.Drawing.Color.White
        Me.lablRemoteAreaS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAreaS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAreaS3.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAreaS3.Location = New System.Drawing.Point(208, 168)
        Me.lablRemoteAreaS3.Name = "lablRemoteAreaS3"
        Me.lablRemoteAreaS3.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteAreaS3.TabIndex = 202
        Me.lablRemoteAreaS3.Tag = "3"
        Me.lablRemoteAreaS3.Text = "100%"
        Me.lablRemoteAreaS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAwayPossession
        '
        Me.lablRemoteAwayPossession.BackColor = System.Drawing.Color.White
        Me.lablRemoteAwayPossession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAwayPossession.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAwayPossession.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAwayPossession.Location = New System.Drawing.Point(160, 112)
        Me.lablRemoteAwayPossession.Name = "lablRemoteAwayPossession"
        Me.lablRemoteAwayPossession.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteAwayPossession.TabIndex = 197
        Me.lablRemoteAwayPossession.Text = "77%"
        Me.lablRemoteAwayPossession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteHomePossession
        '
        Me.lablRemoteHomePossession.BackColor = System.Drawing.Color.White
        Me.lablRemoteHomePossession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteHomePossession.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteHomePossession.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteHomePossession.Location = New System.Drawing.Point(60, 112)
        Me.lablRemoteHomePossession.Name = "lablRemoteHomePossession"
        Me.lablRemoteHomePossession.Size = New System.Drawing.Size(96, 28)
        Me.lablRemoteHomePossession.TabIndex = 196
        Me.lablRemoteHomePossession.Text = "88%"
        Me.lablRemoteHomePossession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerCheckConnection
        '
        Me.timerCheckConnection.Interval = 20000
        '
        'groupActionAreasRugby
        '
        Me.groupActionAreasRugby.Controls.Add(Me.lablViewR4)
        Me.groupActionAreasRugby.Controls.Add(Me.lablAreaR4)
        Me.groupActionAreasRugby.Controls.Add(Me.btnAreaR4)
        Me.groupActionAreasRugby.Controls.Add(Me.lablAreaR1)
        Me.groupActionAreasRugby.Controls.Add(Me.lablViewR3)
        Me.groupActionAreasRugby.Controls.Add(Me.btnAreaR3)
        Me.groupActionAreasRugby.Controls.Add(Me.lablAreaR2)
        Me.groupActionAreasRugby.Controls.Add(Me.lablAreaR3)
        Me.groupActionAreasRugby.Controls.Add(Me.lablViewR1)
        Me.groupActionAreasRugby.Controls.Add(Me.btnAreaR1)
        Me.groupActionAreasRugby.Controls.Add(Me.lablViewR2)
        Me.groupActionAreasRugby.Controls.Add(Me.btnAreaR2)
        Me.groupActionAreasRugby.ForeColor = System.Drawing.Color.White
        Me.groupActionAreasRugby.Location = New System.Drawing.Point(1040, 592)
        Me.groupActionAreasRugby.Name = "groupActionAreasRugby"
        Me.groupActionAreasRugby.Size = New System.Drawing.Size(312, 132)
        Me.groupActionAreasRugby.TabIndex = 140
        Me.groupActionAreasRugby.TabStop = False
        Me.groupActionAreasRugby.Text = "Action Areas"
        '
        'lablViewR4
        '
        Me.lablViewR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewR4.ForeColor = System.Drawing.Color.White
        Me.lablViewR4.Location = New System.Drawing.Point(236, 108)
        Me.lablViewR4.Name = "lablViewR4"
        Me.lablViewR4.Size = New System.Drawing.Size(68, 20)
        Me.lablViewR4.TabIndex = 204
        Me.lablViewR4.Text = "0"
        Me.lablViewR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAreaR4
        '
        Me.lablAreaR4.BackColor = System.Drawing.Color.White
        Me.lablAreaR4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaR4.ForeColor = System.Drawing.Color.Black
        Me.lablAreaR4.Location = New System.Drawing.Point(236, 80)
        Me.lablAreaR4.Name = "lablAreaR4"
        Me.lablAreaR4.Size = New System.Drawing.Size(68, 28)
        Me.lablAreaR4.TabIndex = 203
        Me.lablAreaR4.Tag = "3"
        Me.lablAreaR4.Text = "100%"
        Me.lablAreaR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAreaR4
        '
        Me.btnAreaR4.BackColor = System.Drawing.Color.Black
        Me.btnAreaR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaR4.ForeColor = System.Drawing.Color.White
        Me.btnAreaR4.Location = New System.Drawing.Point(236, 20)
        Me.btnAreaR4.Name = "btnAreaR4"
        Me.btnAreaR4.Size = New System.Drawing.Size(68, 60)
        Me.btnAreaR4.TabIndex = 202
        Me.btnAreaR4.Tag = "4"
        Me.btnAreaR4.Text = "RIGHT2"
        Me.btnAreaR4.UseVisualStyleBackColor = False
        '
        'lablAreaR1
        '
        Me.lablAreaR1.BackColor = System.Drawing.Color.White
        Me.lablAreaR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaR1.ForeColor = System.Drawing.Color.Black
        Me.lablAreaR1.Location = New System.Drawing.Point(8, 80)
        Me.lablAreaR1.Name = "lablAreaR1"
        Me.lablAreaR1.Size = New System.Drawing.Size(68, 28)
        Me.lablAreaR1.TabIndex = 105
        Me.lablAreaR1.Tag = "1"
        Me.lablAreaR1.Text = "100%"
        Me.lablAreaR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewR3
        '
        Me.lablViewR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewR3.ForeColor = System.Drawing.Color.White
        Me.lablViewR3.Location = New System.Drawing.Point(160, 108)
        Me.lablViewR3.Name = "lablViewR3"
        Me.lablViewR3.Size = New System.Drawing.Size(68, 20)
        Me.lablViewR3.TabIndex = 201
        Me.lablViewR3.Text = "0"
        Me.lablViewR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAreaR3
        '
        Me.btnAreaR3.BackColor = System.Drawing.Color.Black
        Me.btnAreaR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaR3.ForeColor = System.Drawing.Color.White
        Me.btnAreaR3.Location = New System.Drawing.Point(160, 20)
        Me.btnAreaR3.Name = "btnAreaR3"
        Me.btnAreaR3.Size = New System.Drawing.Size(68, 60)
        Me.btnAreaR3.TabIndex = 114
        Me.btnAreaR3.Tag = "3"
        Me.btnAreaR3.Text = "RIGHT1"
        Me.btnAreaR3.UseVisualStyleBackColor = False
        '
        'lablAreaR2
        '
        Me.lablAreaR2.BackColor = System.Drawing.Color.White
        Me.lablAreaR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaR2.ForeColor = System.Drawing.Color.Black
        Me.lablAreaR2.Location = New System.Drawing.Point(84, 80)
        Me.lablAreaR2.Name = "lablAreaR2"
        Me.lablAreaR2.Size = New System.Drawing.Size(68, 28)
        Me.lablAreaR2.TabIndex = 106
        Me.lablAreaR2.Tag = "2"
        Me.lablAreaR2.Text = "100%"
        Me.lablAreaR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAreaR3
        '
        Me.lablAreaR3.BackColor = System.Drawing.Color.White
        Me.lablAreaR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAreaR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAreaR3.ForeColor = System.Drawing.Color.Black
        Me.lablAreaR3.Location = New System.Drawing.Point(160, 80)
        Me.lablAreaR3.Name = "lablAreaR3"
        Me.lablAreaR3.Size = New System.Drawing.Size(68, 28)
        Me.lablAreaR3.TabIndex = 107
        Me.lablAreaR3.Tag = "3"
        Me.lablAreaR3.Text = "100%"
        Me.lablAreaR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablViewR1
        '
        Me.lablViewR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewR1.ForeColor = System.Drawing.Color.White
        Me.lablViewR1.Location = New System.Drawing.Point(8, 108)
        Me.lablViewR1.Name = "lablViewR1"
        Me.lablViewR1.Size = New System.Drawing.Size(68, 20)
        Me.lablViewR1.TabIndex = 199
        Me.lablViewR1.Text = "0"
        Me.lablViewR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAreaR1
        '
        Me.btnAreaR1.BackColor = System.Drawing.Color.Black
        Me.btnAreaR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaR1.ForeColor = System.Drawing.Color.White
        Me.btnAreaR1.Location = New System.Drawing.Point(8, 20)
        Me.btnAreaR1.Name = "btnAreaR1"
        Me.btnAreaR1.Size = New System.Drawing.Size(68, 60)
        Me.btnAreaR1.TabIndex = 112
        Me.btnAreaR1.Tag = "1"
        Me.btnAreaR1.Text = "LEFT1"
        Me.btnAreaR1.UseVisualStyleBackColor = False
        '
        'lablViewR2
        '
        Me.lablViewR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablViewR2.ForeColor = System.Drawing.Color.White
        Me.lablViewR2.Location = New System.Drawing.Point(84, 108)
        Me.lablViewR2.Name = "lablViewR2"
        Me.lablViewR2.Size = New System.Drawing.Size(68, 20)
        Me.lablViewR2.TabIndex = 198
        Me.lablViewR2.Text = "0"
        Me.lablViewR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAreaR2
        '
        Me.btnAreaR2.BackColor = System.Drawing.Color.Black
        Me.btnAreaR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreaR2.ForeColor = System.Drawing.Color.White
        Me.btnAreaR2.Location = New System.Drawing.Point(84, 20)
        Me.btnAreaR2.Name = "btnAreaR2"
        Me.btnAreaR2.Size = New System.Drawing.Size(68, 60)
        Me.btnAreaR2.TabIndex = 113
        Me.btnAreaR2.Tag = "2"
        Me.btnAreaR2.Text = "LEFT2"
        Me.btnAreaR2.UseVisualStyleBackColor = False
        '
        'btnFetchStatNames
        '
        Me.btnFetchStatNames.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFetchStatNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchStatNames.ForeColor = System.Drawing.Color.Black
        Me.btnFetchStatNames.Location = New System.Drawing.Point(16, 315)
        Me.btnFetchStatNames.Name = "btnFetchStatNames"
        Me.btnFetchStatNames.Size = New System.Drawing.Size(100, 40)
        Me.btnFetchStatNames.TabIndex = 141
        Me.btnFetchStatNames.Text = "Fetch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stat Names"
        Me.btnFetchStatNames.UseVisualStyleBackColor = False
        Me.btnFetchStatNames.Visible = False
        '
        'panelSuperLeaguePro14
        '
        Me.panelSuperLeaguePro14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSuperLeaguePro14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablAwayScoreSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablHomeScoreSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.btnClearSLPossession)
        Me.panelSuperLeaguePro14.Controls.Add(Me.Label3)
        Me.panelSuperLeaguePro14.Controls.Add(Me.picBoxSLLogo)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablPeriodSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablMatchClockSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.btnPossessionHSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.btnPossessionASL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.btnPossessionOOPSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.Label1)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablRemoteAwayPossessionSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablRemoteHomePossessionSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablAwayNameSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.lablHomeNameSL)
        Me.panelSuperLeaguePro14.Controls.Add(Me.picBoxPro14)
        Me.panelSuperLeaguePro14.Location = New System.Drawing.Point(1037, 0)
        Me.panelSuperLeaguePro14.Name = "panelSuperLeaguePro14"
        Me.panelSuperLeaguePro14.Size = New System.Drawing.Size(315, 725)
        Me.panelSuperLeaguePro14.TabIndex = 225
        Me.panelSuperLeaguePro14.Visible = False
        '
        'lablAwayScoreSL
        '
        Me.lablAwayScoreSL.BackColor = System.Drawing.Color.White
        Me.lablAwayScoreSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablAwayScoreSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayScoreSL.ForeColor = System.Drawing.Color.Black
        Me.lablAwayScoreSL.Location = New System.Drawing.Point(161, 276)
        Me.lablAwayScoreSL.Name = "lablAwayScoreSL"
        Me.lablAwayScoreSL.Size = New System.Drawing.Size(70, 36)
        Me.lablAwayScoreSL.TabIndex = 225
        Me.lablAwayScoreSL.Text = " "
        Me.lablAwayScoreSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablHomeScoreSL
        '
        Me.lablHomeScoreSL.BackColor = System.Drawing.Color.White
        Me.lablHomeScoreSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablHomeScoreSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeScoreSL.ForeColor = System.Drawing.Color.Black
        Me.lablHomeScoreSL.Location = New System.Drawing.Point(82, 276)
        Me.lablHomeScoreSL.Name = "lablHomeScoreSL"
        Me.lablHomeScoreSL.Size = New System.Drawing.Size(70, 36)
        Me.lablHomeScoreSL.TabIndex = 224
        Me.lablHomeScoreSL.Text = " "
        Me.lablHomeScoreSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClearSLPossession
        '
        Me.btnClearSLPossession.BackColor = System.Drawing.Color.DarkRed
        Me.btnClearSLPossession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSLPossession.ForeColor = System.Drawing.Color.White
        Me.btnClearSLPossession.Location = New System.Drawing.Point(82, 673)
        Me.btnClearSLPossession.Name = "btnClearSLPossession"
        Me.btnClearSLPossession.Size = New System.Drawing.Size(150, 40)
        Me.btnClearSLPossession.TabIndex = 223
        Me.btnClearSLPossession.Tag = "1"
        Me.btnClearSLPossession.Text = "Reset this period's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "possession"
        Me.btnClearSLPossession.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(149, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 44)
        Me.Label3.TabIndex = 217
        Me.Label3.Text = "v"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBoxSLLogo
        '
        Me.picBoxSLLogo.Image = CType(resources.GetObject("picBoxSLLogo.Image"), System.Drawing.Image)
        Me.picBoxSLLogo.Location = New System.Drawing.Point(14, 35)
        Me.picBoxSLLogo.Name = "picBoxSLLogo"
        Me.picBoxSLLogo.Size = New System.Drawing.Size(288, 180)
        Me.picBoxSLLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxSLLogo.TabIndex = 216
        Me.picBoxSLLogo.TabStop = False
        Me.picBoxSLLogo.Visible = False
        '
        'lablPeriodSL
        '
        Me.lablPeriodSL.BackColor = System.Drawing.Color.White
        Me.lablPeriodSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablPeriodSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablPeriodSL.ForeColor = System.Drawing.Color.Black
        Me.lablPeriodSL.Location = New System.Drawing.Point(82, 318)
        Me.lablPeriodSL.Name = "lablPeriodSL"
        Me.lablPeriodSL.Size = New System.Drawing.Size(150, 24)
        Me.lablPeriodSL.TabIndex = 215
        Me.lablPeriodSL.Text = " "
        Me.lablPeriodSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablMatchClockSL
        '
        Me.lablMatchClockSL.BackColor = System.Drawing.Color.White
        Me.lablMatchClockSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablMatchClockSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablMatchClockSL.ForeColor = System.Drawing.Color.Black
        Me.lablMatchClockSL.Location = New System.Drawing.Point(82, 344)
        Me.lablMatchClockSL.Name = "lablMatchClockSL"
        Me.lablMatchClockSL.Size = New System.Drawing.Size(150, 44)
        Me.lablMatchClockSL.TabIndex = 214
        Me.lablMatchClockSL.Text = "00:00"
        Me.lablMatchClockSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPossessionHSL
        '
        Me.btnPossessionHSL.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPossessionHSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionHSL.ForeColor = System.Drawing.Color.Black
        Me.btnPossessionHSL.Location = New System.Drawing.Point(4, 499)
        Me.btnPossessionHSL.Name = "btnPossessionHSL"
        Me.btnPossessionHSL.Size = New System.Drawing.Size(150, 60)
        Me.btnPossessionHSL.TabIndex = 211
        Me.btnPossessionHSL.Tag = "1"
        Me.btnPossessionHSL.Text = "Tottenham"
        Me.btnPossessionHSL.UseVisualStyleBackColor = False
        '
        'btnPossessionASL
        '
        Me.btnPossessionASL.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPossessionASL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionASL.ForeColor = System.Drawing.Color.Black
        Me.btnPossessionASL.Location = New System.Drawing.Point(159, 499)
        Me.btnPossessionASL.Name = "btnPossessionASL"
        Me.btnPossessionASL.Size = New System.Drawing.Size(150, 60)
        Me.btnPossessionASL.TabIndex = 212
        Me.btnPossessionASL.Tag = "2"
        Me.btnPossessionASL.Text = "West Brom"
        Me.btnPossessionASL.UseVisualStyleBackColor = False
        '
        'btnPossessionOOPSL
        '
        Me.btnPossessionOOPSL.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPossessionOOPSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPossessionOOPSL.ForeColor = System.Drawing.Color.Black
        Me.btnPossessionOOPSL.Location = New System.Drawing.Point(82, 565)
        Me.btnPossessionOOPSL.Name = "btnPossessionOOPSL"
        Me.btnPossessionOOPSL.Size = New System.Drawing.Size(150, 60)
        Me.btnPossessionOOPSL.TabIndex = 213
        Me.btnPossessionOOPSL.Tag = "0"
        Me.btnPossessionOOPSL.Text = "Out of Play"
        Me.btnPossessionOOPSL.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 20)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Possession"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteAwayPossessionSL
        '
        Me.lablRemoteAwayPossessionSL.BackColor = System.Drawing.Color.White
        Me.lablRemoteAwayPossessionSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteAwayPossessionSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteAwayPossessionSL.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteAwayPossessionSL.Location = New System.Drawing.Point(159, 451)
        Me.lablRemoteAwayPossessionSL.Name = "lablRemoteAwayPossessionSL"
        Me.lablRemoteAwayPossessionSL.Size = New System.Drawing.Size(150, 36)
        Me.lablRemoteAwayPossessionSL.TabIndex = 199
        Me.lablRemoteAwayPossessionSL.Text = " "
        Me.lablRemoteAwayPossessionSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablRemoteHomePossessionSL
        '
        Me.lablRemoteHomePossessionSL.BackColor = System.Drawing.Color.White
        Me.lablRemoteHomePossessionSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lablRemoteHomePossessionSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablRemoteHomePossessionSL.ForeColor = System.Drawing.Color.Black
        Me.lablRemoteHomePossessionSL.Location = New System.Drawing.Point(4, 451)
        Me.lablRemoteHomePossessionSL.Name = "lablRemoteHomePossessionSL"
        Me.lablRemoteHomePossessionSL.Size = New System.Drawing.Size(150, 36)
        Me.lablRemoteHomePossessionSL.TabIndex = 198
        Me.lablRemoteHomePossessionSL.Text = " "
        Me.lablRemoteHomePossessionSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lablAwayNameSL
        '
        Me.lablAwayNameSL.BackColor = System.Drawing.Color.Transparent
        Me.lablAwayNameSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablAwayNameSL.ForeColor = System.Drawing.Color.White
        Me.lablAwayNameSL.Location = New System.Drawing.Point(171, 220)
        Me.lablAwayNameSL.Name = "lablAwayNameSL"
        Me.lablAwayNameSL.Size = New System.Drawing.Size(140, 44)
        Me.lablAwayNameSL.TabIndex = 94
        Me.lablAwayNameSL.Text = "WEST BROM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TEST LINE 2"
        Me.lablAwayNameSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lablHomeNameSL
        '
        Me.lablHomeNameSL.BackColor = System.Drawing.Color.Transparent
        Me.lablHomeNameSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablHomeNameSL.ForeColor = System.Drawing.Color.White
        Me.lablHomeNameSL.Location = New System.Drawing.Point(0, 220)
        Me.lablHomeNameSL.Name = "lablHomeNameSL"
        Me.lablHomeNameSL.Size = New System.Drawing.Size(140, 44)
        Me.lablHomeNameSL.TabIndex = 93
        Me.lablHomeNameSL.Text = "TOTTENHAM"
        Me.lablHomeNameSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picBoxPro14
        '
        Me.picBoxPro14.Image = CType(resources.GetObject("picBoxPro14.Image"), System.Drawing.Image)
        Me.picBoxPro14.Location = New System.Drawing.Point(14, 35)
        Me.picBoxPro14.Name = "picBoxPro14"
        Me.picBoxPro14.Size = New System.Drawing.Size(288, 180)
        Me.picBoxPro14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxPro14.TabIndex = 226
        Me.picBoxPro14.TabStop = False
        Me.picBoxPro14.Visible = False
        '
        'btnFetchRBStats
        '
        Me.btnFetchRBStats.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFetchRBStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchRBStats.ForeColor = System.Drawing.Color.Black
        Me.btnFetchRBStats.Location = New System.Drawing.Point(16, 359)
        Me.btnFetchRBStats.Name = "btnFetchRBStats"
        Me.btnFetchRBStats.Size = New System.Drawing.Size(100, 40)
        Me.btnFetchRBStats.TabIndex = 226
        Me.btnFetchRBStats.Text = "Fetch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Match Stats"
        Me.btnFetchRBStats.UseVisualStyleBackColor = False
        '
        'btnFetchLiveMatch
        '
        Me.btnFetchLiveMatch.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFetchLiveMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchLiveMatch.ForeColor = System.Drawing.Color.Black
        Me.btnFetchLiveMatch.Location = New System.Drawing.Point(16, 271)
        Me.btnFetchLiveMatch.Name = "btnFetchLiveMatch"
        Me.btnFetchLiveMatch.Size = New System.Drawing.Size(100, 40)
        Me.btnFetchLiveMatch.TabIndex = 227
        Me.btnFetchLiveMatch.Text = "Fetch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Match Details"
        Me.btnFetchLiveMatch.UseVisualStyleBackColor = False
        Me.btnFetchLiveMatch.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnFetchLiveMatch)
        Me.Controls.Add(Me.panelSuperLeaguePro14)
        Me.Controls.Add(Me.btnFetchRBStats)
        Me.Controls.Add(Me.btnFetchStatNames)
        Me.Controls.Add(Me.groupRemotePossession)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lablRemove)
        Me.Controls.Add(Me.btnLogRC)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLogGoal)
        Me.Controls.Add(Me.btnLogYC)
        Me.Controls.Add(Me.LablConnected)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lablArrowAwayLR)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lablArrowAwayRL)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.lablArrowHomeLR)
        Me.Controls.Add(Me.groupPossession)
        Me.Controls.Add(Me.groupActionAreasSoccer)
        Me.Controls.Add(Me.groupViewTime)
        Me.Controls.Add(Me.lablArrowHomeRL)
        Me.Controls.Add(Me.lablPeriod)
        Me.Controls.Add(Me.groupClock)
        Me.Controls.Add(Me.lablAwayName)
        Me.Controls.Add(Me.lablHomeName)
        Me.Controls.Add(Me.groupActionAreasRugby)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamLog 2008 by PIRANHA Systems    07836 202 329"
        Me.groupClock.ResumeLayout(False)
        Me.groupViewTime.ResumeLayout(False)
        Me.groupActionAreasSoccer.ResumeLayout(False)
        Me.groupPossession.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.tabKickouts.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        CType(Me.picBoxPitch, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPenalties.ResumeLayout(False)
        Me.tabCarries.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.groupRemotePossession.ResumeLayout(False)
        Me.groupActionAreasRugby.ResumeLayout(False)
        Me.panelSuperLeaguePro14.ResumeLayout(False)
        CType(Me.picBoxSLLogo, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picBoxPro14, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private bRemove As Boolean = False
    Private bPeriodEnabled As Boolean = False
    Const READ_BUFFER_SIZE As Integer = 8192 * 2
    Dim dtLastPAData As Date = Now
    Private client As TcpClient
    Private readBuffer(READ_BUFFER_SIZE) As Byte
    Private bConnectedToServer As Boolean = False
    'Dim RedPen As New Pen(Color.Red)
    'Dim PenWhite As New Pen(Color.White)
    'Dim PenBlack As New Pen(Color.Black)
    'Dim tempPen As New Pen(Color.Black)
    'Dim myBrush As New SolidBrush(Color.Blue)
    'Dim BrushBlack As New SolidBrush(Color.Black)
    'Dim BrushWhite As New SolidBrush(Color.White)
    'Dim BrushYellow As New SolidBrush(Color.Yellow)
    'Dim BrushGreen As New SolidBrush(Color.DarkGreen)
    'Dim fnt1 As Font
    'Dim tempState As System.Drawing.Drawing2D.GraphicsState
    'Dim currentPitchKickoutTeamName As String = ""
    Dim currentPitchKickoutTeamID As Integer = 0
    Dim winningPitchKickoutTeamID As Integer = 0
    Dim kickoutStepNum As Integer = 0
    Dim currentPitchLogType As PitchLogType
    Dim clickStage As Integer = 1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        ConnectToSportServer()
    End Sub
    Sub ConnectToSportServer()
        Connect()
        SendData("CONNECT|" & Config.PCName & "|" & Config.LocalIPAddress & "|")
    End Sub
    Private Sub DoRead(ByVal ar As IAsyncResult)
        Dim BytesRead As Integer
        Dim strMessage As String
        Dim dataArray() As String, inc As Integer
        Static strTemp As String
        Dim strData() As String

        Try
            ' Finish asynchronous read into readBuffer and return number of bytes read.
            BytesRead = client.GetStream.EndRead(ar)
            If BytesRead < 1 Then
                ' If no bytes were read server has closed.  Disable input window.
                Exit Sub
            End If

            ' Convert the byte array the message was saved into, minus two for the
            ' Chr(13) and Chr(10)
            'strMessage = Encoding.Default.GetString(readBuffer, 0, BytesRead - 2)
            '' possible multiple commands if on fast server
            'If InStr(strMessage, vbCrLf) > 0 Then
            '    'split into sep
            '    dataArray = strMessage.Split(vbCrLf)
            '    'fMainForm.AddToLog("Multiple messages in data: " & dataArray.GetUpperBound(0) + 1.ToString)
            '    For inc = 0 To dataArray.GetUpperBound(0)
            '        ProcessCommands(dataArray(inc).Trim.Replace(vbLf, "").Replace(vbCr, "")) 'tidy, should just be lf left after split)
            '    Next
            'Else
            '    'single
            '    ProcessCommands(strMessage)
            'End If
            '###
            strMessage = Encoding.Default.GetString(readBuffer, 0, BytesRead)
            If Microsoft.VisualBasic.Right(strMessage, 2) = vbCrLf Then
                strTemp += Microsoft.VisualBasic.Left(strMessage, Len(strMessage) - 2)    'remove CRLF
                If InStr(strTemp, vbCrLf) > 0 Then
                    strData = strTemp.Split(vbCrLf)
                    For inc = 0 To UBound(strData)
                        ProcessCommands(strData(inc).Replace(vbLf, "").Replace(vbCr, "")) 'tidy, should just be lf left after split
                    Next
                Else
                    ProcessCommands(strTemp)
                End If
                strTemp = ""    'clear for next time
            Else
                strTemp += strMessage   'add for future
            End If
            '###

            ' Start a new asynchronous read into readBuffer.
            client.GetStream.BeginRead(readBuffer, 0, READ_BUFFER_SIZE, AddressOf DoRead, Nothing)
        Catch e As Exception
        End Try
    End Sub
    Private Sub menuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub Connect()
        Try
            ' The TcpClient is a subclass of Socket, providing higher level 
            ' functionality like streaming.
            client = New TcpClient(Config.ServerAddress, Config.ServerPort)
            client.ReceiveBufferSize = READ_BUFFER_SIZE
            ' Start an asynchronous read invoking DoRead to avoid lagging the user
            ' interface.
            client.GetStream.BeginRead(readBuffer, 0, READ_BUFFER_SIZE, AddressOf DoRead, Nothing)
            bConnectedToServer = True
            ShowConnectionStatus(1)
            Me.btnSetup.Enabled = bConnectedToServer
        Catch Ex As Exception
            bConnectedToServer = False
            ShowConnectionStatus(-1)
            Me.btnSetup.Enabled = bConnectedToServer

        End Try
        'ClearMessage()
    End Sub
    Sub ShowLocalMessage(ByVal strText As String)
        Console.WriteLine(strText)
        'Me.lablStatus.Text = strText

    End Sub
    Private Sub ProcessCommands(ByVal strMessage As String)
        Dim dataArray() As String, iReturn As Integer = 0

        ' Message parts are divided by "|"  Break the string into an array accordingly.
        Try
            dtLastPAData = Now
            dataArray = strMessage.Split(Chr(124))
            ' dataArray(0) is the command.
            ShowLocalMessage("Received from Server: " & strMessage)
            Select Case dataArray(0)
                Case "CONNECTED"
                    If Config.UseRBLiveMatch Then
                        SendData("MATCHPAD|REQUESTLIVEMATCHDETAILS|")
                    End If
                    If Config.UseRBStatNames Then
                        SendData("MATCHLOG|REQUESTLIVESTATNAMES|")
                    End If
                Case "MATCHLIST"
                    If dataArray(1) = dtSelDate Then
                        MatchList = AssignMatchList(strMessage)
                        formSetup.ShowData()
                    End If
                Case "MATCHDETAILS"
                    Dim tempMatch As New clsMatch
                    tempMatch = AssignLiveMatch(strMessage)
                    If tempMatch.MatchID = iMatchID Then
                        LiveMatch = tempMatch
                        ShowDirection()
                        ShowMatch()
                        ShowTeamStats()
                        SaveLiveMatch()
                        If LiveMatch.HomeTeamReceived = False Then
                            SendData("REQUESTPLAYERLIST|" & LiveMatch.MatchID.ToString & "|" & LiveMatch.HomeTeamID.ToString & "|")
                        End If
                    End If
                Case "PLAYERLIST"
                    iReturn = Utils.AssignPlayers(strMessage)
                    Select Case iReturn
                        Case 1
                            'received home team, request away
                            'watch for loop
                            ShowPlayerNames(1)
                            If LiveMatch.AwayTeamReceived = False Then
                                SendData("REQUESTPLAYERLIST|" & LiveMatch.MatchID.ToString & "|" & LiveMatch.AwayTeamID.ToString & "|")
                            End If
                        Case 2
                            'received away team
                            ShowPlayerNames(2)
                            AssignPlayersToJSON()
                            SendData("MATCHLOG|REQUESTLIVESTATNAMES|")
                        Case Else
                            'MessageBox.Show("Not live team")
                    End Select
                    ShowCarryPlayers()    'SL2020
                Case "MATCHDATA"
                    Select Case dataArray(1).ToUpper
                        Case "LIVEMATCHDETAILS"
                            'MATCHDATA|LIVEMATCHDETAILS|49233|Catalans^3^SKY2014 GAA|Castleford^2^Rugby League|1^1^1^ESCARE^MORGAN ESCARE^10775^^^^^|1^2^2^DUPORT^VINCENT DUPORT^10776^^^^^|1^3^3^POMEROY^BEN POMEROY^10777^^^^^|1^4^4^TONGA^WILLIE TONGA^10778^^^^^|1^5^5^OLDFIELD^MICHAEL OLDFIELD^10779^^^^^|1^6^6^CARNEY^TODD CARNEY^10780^^^^^|1^7^7^DUREAU^SCOTT DUREAU^10781^^^^^|1^8^8^ELIMA^OLIVIER ELIMA^10782^^^^^|1^9^9^HENDERSON^IAN HENDERSON^10783^^^^^|1^10^10^CASTY^REMI CASTY^10784^^^^^|1^11^11^TAIA^ZEB TAIA^10785^^^^^|1^12^12^ANDERSON^LOUIS ANDERSON^10786^^^^^|1^13^13^MOUNIS^GREGORY MOUNIS^10787^^^^^|1^14^14^BOSC^THOMAS BOSC^10788^^^^^|1^15^15^LIMA^JEFF LIMA^10789^^^^^|1^16^16^PELISSIER^ELOI PELISSIER^10790^^^^^|1^17^17^WHITEHEAD^ELLIOTT WHITEHEAD^10791^^^^^|1^18^18^GARCIA^BENJAMIN GARCIA^10792^^^^^|1^19^19^PALA^MATHIAS PALA^10793^^^^^|1^20^20^CARDACE^DAMIEN CARDACE^10794^^^^^|1^21^21^BOUSQUET^JULIAN BOUSQUET^10795^^^^^|1^22^^^^-1^^^^^|1^23^^^^-1^^^^^|1^24^^^^-1^^^^^|1^25^^^^-1^^^^^|2^1^1^Dorn^Luke Dorn^11003^^^^^|2^2^2^Clare^James Clare^11004^^^^^|2^3^3^Webster^Jake Webster^11005^^^^^|2^4^4^Shenton^Michael Shenton^11006^^^^^|2^5^5^Carney^Justin Carney^11007^^^^^|2^6^6^Roberts^Ben Roberts^11008^^^^^|2^7^7^Gale^Luke Gale^11009^^^^^|2^8^8^Lynch^Andy Lynch^11010^^^^^|2^9^9^Milner^Adam Milner^11011^^^^^|2^10^10^Millington^Grant Millington^11012^^^^^|2^11^11^Holmes^Oliver Holmes^11013^^^^^|2^12^12^Cook^Matt Cook^11014^^^^^|2^13^13^Massey^Nathan Massey^11015^^^^^|2^14^14^Jewitt^Lee Jewitt^11016^^^^^|2^15^15^Boyle^Ryan Boyle^11017^^^^^|2^16^16^Moors^Junior Moors^11018^^^^^|2^17^17^Moore^Scott Moore^11019^^^^^|2^18^21^FINN^LIAM FINN^11023^^^^^|2^19^22^TANSEY^JORDAN TANSEY^11024^^^^^|2^20^23^CHANNING^MICHAEL CHANNING^11025^^^^^|2^21^25^CROSSLEY^STEVE CROSSLEY^11027^^^^^|2^22^^^^-1^^^^^|2^23^^^^-1^^^^^|2^24^^^^-1^^^^^|2^25^^^^-1^^^^^|
                            'just use to fetch ID, then fetch data from server as normal
                            If Config.UseRBLiveMatch Then
                                iMatchID = Val(dataArray(2))
                                JSONTeamStats.MatchID = iMatchID.ToString
                                SendData("REQUESTMATCHDETAILS|" & iMatchID.ToString)
                                Threading.Thread.Sleep(100)
                                FetchAllLiveStats()
                            End If
                        Case "LIVESTATNAMES"
                            AssignRBOptaStatnames(strMessage)
                        Case "PLAYEREDIT"
                            Utils.AssignPlayerNameString(strMessage)
                            ShowPlayerNames(1)
                            ShowPlayerNames(2)
                        Case "PLAYERSTATS"
                            Utils.AssignPlayerDataString(strMessage)
                            ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
                            ShowPlayerSummaryStats(iCurrentPlayerTeam)
                        Case "ALLPLAYERSTATS"
                            'SL2020
                            Utils.AssignAllPlayerDataString(strMessage)
                            ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
                        Case "TEAMSTATS"
                            Utils.AssignTeamDataString(strMessage)
                            ShowTeamStats()
                        Case "ALLTEAMSTATS"
                            'Index-based only, both teams
                            Utils.AssignAllTeamStatsDataString(strMessage)
                            ShowTeamStats()
                        Case "POSSESSION"
                            Select Case Config.UserName
                                Case "SKYSUPERLEAGUE"
                                    'MATCHDATA|POSSESSION|49233|1|100|0|
                                    If LiveMatch.MatchID = Val(dataArray(2)) Then
                                        LiveMatch.Period = Val(dataArray(3))
                                        Utils.AssignRemoteSLPossessionDataString(strMessage)
                                        ShowRemotePossession()
                                    End If
                                Case "PRO14"
                                    'MATCHDATA|POSSESSION|32488|2|58|42|3^0%^100%^0%^100%^^^0%^0%^99%^^^^^00:00^00:00^00:00^40:00^00:00^|
                                    If LiveMatch.MatchID = Val(dataArray(2)) Then
                                        LiveMatch.Period = Val(dataArray(3))
                                        Utils.AssignRemoteSLPossessionDataString(strMessage)
                                        ShowRemotePossession()
                                    End If
                                Case Else
                                    If LiveMatch.MatchID = Val(dataArray(3)) Then
                                        LiveMatch.Period = Val(dataArray(4))
                                        Utils.AssignRemoteDataString(strMessage)
                                        ShowRemotePossession()
                                        ShowDirection()
                                    End If
                            End Select
                        Case "LOCALMATCHTIME"
                            Select Case Config.UserName
                                Case "PRO14"
                                    'MATCHDATA|LOCALMATCHTIME|32488|1|00:00|0:00|0:00|20|15|RUNNING|
                                    If LiveMatch.MatchID = Val(dataArray(2)) Then
                                        LiveMatch.Period = Val(dataArray(3))
                                        RemoteData.CurrentMatchPeriod = Val(dataArray(3))
                                        RemoteData.MatchClockTime = dataArray(4)
                                        If dataArray.GetUpperBound(0) > 8 Then
                                            'additional data
                                            RemoteData.HomeScore = dataArray(7)
                                            RemoteData.AwayScore = dataArray(8)
                                            RemoteData.MatchClockRunning = (dataArray(9) = "RUNNING")
                                        End If
                                        ShowRemotePossession()
                                    End If
                            End Select
                        Case "CLEARALLDATA"
                            If iMatchID = Val(dataArray(2)) Then
                                ClearAllData()
                            End If
                        Case "SCOREUPDATE"
                            'MATCHDATA|SCOREUPDATE|49233|5|4|0|5^4|
                            Select Case Config.UserName
                                Case "SKYSUPERLEAGUE", "PRO14"
                                    If LiveMatch.MatchID = Val(dataArray(2)) Then
                                        RemoteData.HomeScore = dataArray(3)
                                        RemoteData.AwayScore = dataArray(4)
                                        ShowRemotePossession()
                                    End If
                                Case Else
                            End Select
                        Case Else
                            'MessageBox.Show(strMessage)
                    End Select
                Case "KICKOUTSEDITED"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        If TabControl1.SelectedTab.Name = "tabKickouts" Then
                            'refresh data, otherwise wait until tab is active
                            SendData("REQUESTKICKOUTS|" & LiveMatch.MatchID.ToString & "|")
                        End If
                    End If
                Case "FREESEDITED"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        If TabControl1.SelectedTab.Name = "tabKickouts" Then
                            'refresh data, otherwise wait until tab is active
                            SendData("REQUESTFREES|" & LiveMatch.MatchID.ToString & "|")
                        End If
                    End If
                Case "4565SEDITED"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        If TabControl1.SelectedTab.Name = "tabKickouts" Then
                            'refresh data, otherwise wait until tab is active
                            SendData("REQUEST4565S|" & LiveMatch.MatchID.ToString & "|")
                        End If
                    End If
                Case "KICKOUTLIST"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        'This match - replace any local entries
                        Dim numEntries As Integer = Val(dataArray(2))
                        ReDim PitchKickouts(numEntries)
                        PitchKickouts(0) = New clsPitchLocationLog
                        For incKO As Integer = 1 To numEntries
                            Dim dataString As String = dataArray(2 + incKO)
                            PitchKickouts(incKO) = New clsPitchLocationLog
                            PitchKickouts(incKO).MatchID = iMatchID
                            PitchKickouts(incKO).AssignDataString(dataString)
                        Next
                        DrawAll()
                    End If
                Case "FREESLIST"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        'This match - replace any local entries
                        Dim numEntries As Integer = Val(dataArray(2))
                        ReDim PitchFrees(numEntries)
                        PitchFrees(0) = New clsPitchLocationLog
                        For incKO As Integer = 1 To numEntries
                            Dim dataString As String = dataArray(2 + incKO)
                            PitchFrees(incKO) = New clsPitchLocationLog
                            PitchFrees(incKO).MatchID = iMatchID
                            PitchFrees(incKO).AssignDataString(dataString)
                        Next
                        DrawAll()
                    End If
                Case "4565LIST"
                    Dim iMatchID As Integer = Val(dataArray(1))
                    If iMatchID = LiveMatch.MatchID Then
                        'This match - replace any local entries
                        Dim numEntries As Integer = Val(dataArray(2))
                        ReDim Pitch4565(numEntries)
                        Pitch4565(0) = New clsPitchLocationLog
                        For incKO As Integer = 1 To numEntries
                            Dim dataString As String = dataArray(2 + incKO)
                            Pitch4565(incKO) = New clsPitchLocationLog
                            Pitch4565(incKO).MatchID = iMatchID
                            Pitch4565(incKO).AssignDataString(dataString)
                        Next
                        DrawAll()
                    End If
                Case "SPORTCLOCK"
                    'SPORTCLOCK|MATCHTIME|49233|1|38:01|01:59|RUNNING|
                    Select Case Config.UserName
                        Case "SKYSUPERLEAGUE"
                            Dim iMatchID As Integer = Val(dataArray(2))
                            If iMatchID = LiveMatch.MatchID Then
                                RemoteData.CurrentMatchPeriod = Val(dataArray(3))
                                RemoteData.MatchClockTime = dataArray(5)  'counting up
                                RemoteData.MatchClockRunning = (dataArray(6) = "RUNNING")
                                ShowRemotePossession()
                            End If
                    End Select

                Case "HEARTBEAT"

                Case "DISCONNECTED"
                    Disconnect()
                    ShowConnectionStatus(-1)
                Case Else
            End Select
        Catch ex As Exception
            Console.WriteLine(ex.Message & ": " & strMessage)
        End Try
    End Sub
    Sub Disconnect()
        Try
            client.Close()
            bConnectedToServer = False
            ShowConnectionStatus(-1)
        Catch Ex As Exception
        End Try
    End Sub
    Public Sub SendData(ByVal data As String)
        If bConnectedToServer = True Then
            Try
                'MessageBox.Show(data, "Connected")
                Console.WriteLine("Sent: " + data)
                Dim writer As New IO.StreamWriter(client.GetStream, Encoding.Default)
                writer.Write(data & vbCrLf)
                writer.Flush()
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Error in SendData")
            End Try
        Else
            'MessageBox.Show(data, "Not Connected")
        End If
    End Sub
    Sub ShowPitchLogLabels()
        With LiveMatch
            Dim teamName As String = ""
            If currentPitchKickoutTeamID = lablPitchRLTeamName.Tag Then
                teamName = lablPitchRLTeamName.Text
            Else
                teamName = lablPitchLRTeamName.Text
            End If

            Select Case currentPitchLogType
                Case PitchLogType.Kickouts
                    lablPitchLogHeading1.Text = "Won"
                    lablPitchLogHeading2.Text = "Lost"
                    lablPitchLogHeading3.Visible = False
                    lablPitchHome3.Visible = False
                    lablPitchAway3.Visible = False
                    btnPitchHomeWin.Text = "Add " & .HomeLongName & " Kickout Won..."
                    btnPitchAwayWin.Text = "Add " & .AwayLongName & " Kickout Won..."
                    btnPitchHomeWin.Visible = True
                    btnPitchAwayWin.Visible = True
                    btnPitchShotGood.Visible = False
                    btnPitchShotGood2.Visible = False
                    btnPitchShotGood3.Visible = False
                    btnPitchShotGood4.Visible = False
                    btnPitchShotWide.Visible = False
                    btnPitchShotWide2.Visible = False
                    lablPitchHomeName.Visible = False
                    lablPitchAwayName.Visible = False
                    lablPitchKickoutPrompt.Text = "Viewing " & teamName & " Kickouts"
                    btnStepKickouts.Text = "Step through " & teamName & " Kickouts"
                    btnDeleteKickout.Text = "Delete this Kickout"
                Case PitchLogType.Frees
                    lablPitchLogHeading1.Text = "Scored"
                    lablPitchLogHeading2.Text = "Wide"
                    lablPitchLogHeading3.Visible = False
                    lablPitchHome3.Visible = False
                    lablPitchAway3.Visible = False
                    btnPitchHomeWin.Visible = False
                    btnPitchAwayWin.Visible = False
                    btnPitchShotGood.Visible = True
                    btnPitchShotGood2.Visible = False
                    btnPitchShotGood3.Visible = False
                    btnPitchShotGood4.Visible = False
                    btnPitchShotGood.Text = "Log Score..."
                    btnPitchShotGood.Font = New Font("MS SANS SERIF", 9.75)
                    btnPitchShotWide.Visible = True
                    btnPitchShotWide.Text = "Log Wide..."
                    lablPitchHomeName.Visible = True
                    lablPitchAwayName.Visible = True
                    lablPitchHomeName.Text = .HomeShortName
                    lablPitchAwayName.Text = .AwayShortName
                    lablPitchKickoutPrompt.Text = "Viewing " & teamName & " Frees"
                    btnStepKickouts.Text = "Step through " & teamName & " Frees"
                    btnDeleteKickout.Text = "Delete this free"
                Case PitchLogType.FortyFive_SixtyFive
                    lablPitchLogHeading1.Text = "From Play"
                    lablPitchLogHeading2.Text = "From Free"
                    lablPitchLogHeading3.Text = "Wide"
                    lablPitchLogHeading3.Visible = True
                    lablPitchHome3.Visible = True
                    lablPitchAway3.Visible = True
                    btnPitchHomeWin.Visible = False
                    btnPitchAwayWin.Visible = False
                    btnPitchShotGood.Visible = True
                    'btnPitchShotGood.Text = "Log Goal" & vbLf & "from Free..."
                    'btnPitchShotGood.Width = 72 'half size
                    'btnPitchShotGood.Font = New Font("MS SANS SERIF", 8.25)
                    btnPitchShotGood2.Visible = True
                    btnPitchShotGood3.Visible = True
                    btnPitchShotGood4.Visible = True
                    btnPitchShotWide.Visible = True
                    btnPitchShotWide2.Visible = True
                    lablPitchHomeName.Visible = True
                    lablPitchAwayName.Visible = True
                    lablPitchHomeName.Text = .HomeShortName
                    lablPitchAwayName.Text = .AwayShortName
                    lablPitchKickoutPrompt.Text = "Viewing " & teamName & " Scores"
                    btnStepKickouts.Text = "Step through " & teamName & " Scores"
                    btnDeleteKickout.Text = "Delete this Shot"
            End Select

        End With


    End Sub
    Delegate Sub ShowDataCallback()
    Sub ShowMatch()
        If lablHomeName.InvokeRequired Then
            Dim d As New ShowDataCallback(AddressOf ShowMatch)
            Me.Invoke(d, New Object() {})
        Else

            With LiveMatch
                Me.lablMatchID.Text = .MatchID.ToString
                Me.lablHomeName.Text = .HomeLongName.ToUpper
                Me.lablHomeName2.Text = .HomeLongName.ToUpper
                Me.lablHomeName3.Text = .HomeLongName.ToUpper
                Me.lablHomeNameSL.Text = .HomeShortName.ToUpper
                Me.lablHomeNameSL2.Text = .HomeShortName.ToUpper
                Me.lablAwayName.Text = .AwayLongName.ToUpper
                Me.lablAwayName2.Text = .AwayLongName.ToUpper
                Me.lablAwayName3.Text = .AwayLongName.ToUpper
                Me.lablAwayNameSL.Text = .AwayShortName.ToUpper
                Me.lablAwayNameSL2.Text = .AwayShortName.ToUpper
                Me.btnPossessionH.Text = .HomeShortName.ToUpper & vbLf & "Key ,"
                Me.btnPossessionA.Text = .AwayShortName.ToUpper & vbLf & "Key ."
                Me.btnPossessionOOP.Text = "OUT OF PLAY" & vbLf & "Key /"
                Me.btnPossessionHSL.Text = .HomeShortName.ToUpper & vbLf & "Key ,"
                Me.btnPossessionASL.Text = .AwayShortName.ToUpper & vbLf & "Key ."
                Me.btnPossessionOOPSL.Text = "OUT OF PLAY" & vbLf & "Key /"
                Me.btnAreaS1.Text = "LEFT" & vbLf & "Key z"
                Me.btnAreaS2.Text = "CENTRE" & vbLf & "Key x"
                Me.btnAreaS3.Text = "RIGHT" & vbLf & "Key c"
                Me.btnAreaR1.Text = "LEFT1" & vbLf & "Key z"
                Me.btnAreaR2.Text = "LEFT2" & vbLf & "Key x"
                Me.btnAreaR3.Text = "RIGHT1" & vbLf & "Key c"
                Me.btnAreaR4.Text = "RIGHT2" & vbLf & "Key v"
                Me.lablPeriod.Text = .StatePhrase


                Me.lablHomeName.BackColor = Color.FromArgb(.HomeColour)
                Me.lablAwayName.BackColor = Color.FromArgb(.AwayColour)
                Me.lablHomeName.ForeColor = Color.FromArgb(.HomeColour2)
                Me.lablAwayName.ForeColor = Color.FromArgb(.AwayColour2)

                'Me.lablHomeNameSL.BackColor = Color.FromArgb(.HomeColour)
                'Me.lablAwayNameSL.BackColor = Color.FromArgb(.AwayColour)
                'Me.lablHomeNameSL.ForeColor = Color.FromArgb(.HomeColour2)
                'Me.lablAwayNameSL.ForeColor = Color.FromArgb(.AwayColour2)

                Me.btnPossessionH.BackColor = Color.FromArgb(.HomeColour)
                Me.btnPossessionA.BackColor = Color.FromArgb(.AwayColour)
                Me.btnPossessionH.ForeColor = Color.FromArgb(.HomeColour2)
                Me.btnPossessionA.ForeColor = Color.FromArgb(.AwayColour2)
                Me.btnPossessionHSL.BackColor = Color.FromArgb(.HomeColour)
                Me.btnPossessionASL.BackColor = Color.FromArgb(.AwayColour)
                Me.btnPossessionHSL.ForeColor = Color.FromArgb(.HomeColour2)
                Me.btnPossessionASL.ForeColor = Color.FromArgb(.AwayColour2)


                Dim colTemp As Color
                colTemp = Color.FromArgb(.HomeColour)
                Me.lablStat01H.BackColor = colTemp
                Me.lablStat02H.BackColor = colTemp
                Me.lablStat03H.BackColor = colTemp
                Me.lablStat04H.BackColor = colTemp
                Me.lablStat05H.BackColor = colTemp
                Me.lablStat06H.BackColor = colTemp
                Me.lablStat07H.BackColor = colTemp
                Me.lablStat08H.BackColor = colTemp
                Me.lablStat09H.BackColor = colTemp
                Me.lablStat10H.BackColor = colTemp
                Me.lablStat11H.BackColor = colTemp
                Me.lablStat12H.BackColor = colTemp
                Me.lablStat13H.BackColor = colTemp
                Me.lablStat14H.BackColor = colTemp
                Me.lablStat15H.BackColor = colTemp
                Me.lablStat16H.BackColor = colTemp
                Me.lablStat17H.BackColor = colTemp
                Me.lablStat18H.BackColor = colTemp
                Me.lablStat19H.BackColor = colTemp
                Me.lablStat20H.BackColor = colTemp
                Me.lablStat21H.BackColor = colTemp
                Me.lablStat22H.BackColor = colTemp
                Me.lablStat23H.BackColor = colTemp
                Me.lablStat24H.BackColor = colTemp
                Me.lablStat25H.BackColor = colTemp
                Me.lablStat26H.BackColor = colTemp
                Me.lablStat27H.BackColor = colTemp
                Me.lablStat28H.BackColor = colTemp
                Me.lablStat29H.BackColor = colTemp
                Me.lablStat30H.BackColor = colTemp

                colTemp = Color.FromArgb(.AwayColour)
                Me.lablStat01A.BackColor = colTemp
                Me.lablStat02A.BackColor = colTemp
                Me.lablStat03A.BackColor = colTemp
                Me.lablStat04A.BackColor = colTemp
                Me.lablStat05A.BackColor = colTemp
                Me.lablStat06A.BackColor = colTemp
                Me.lablStat07A.BackColor = colTemp
                Me.lablStat08A.BackColor = colTemp
                Me.lablStat09A.BackColor = colTemp
                Me.lablStat10A.BackColor = colTemp
                Me.lablStat11A.BackColor = colTemp
                Me.lablStat12A.BackColor = colTemp
                Me.lablStat13A.BackColor = colTemp
                Me.lablStat14A.BackColor = colTemp
                Me.lablStat15A.BackColor = colTemp
                Me.lablStat16A.BackColor = colTemp
                Me.lablStat17A.BackColor = colTemp
                Me.lablStat18A.BackColor = colTemp
                Me.lablStat19A.BackColor = colTemp
                Me.lablStat20A.BackColor = colTemp
                Me.lablStat21A.BackColor = colTemp
                Me.lablStat22A.BackColor = colTemp
                Me.lablStat23A.BackColor = colTemp
                Me.lablStat24A.BackColor = colTemp
                Me.lablStat25A.BackColor = colTemp
                Me.lablStat26A.BackColor = colTemp
                Me.lablStat27A.BackColor = colTemp
                Me.lablStat28A.BackColor = colTemp
                Me.lablStat29A.BackColor = colTemp
                Me.lablStat30A.BackColor = colTemp

                colTemp = Color.FromArgb(.HomeColour2)
                Me.lablStat01H.ForeColor = colTemp
                Me.lablStat02H.ForeColor = colTemp
                Me.lablStat03H.ForeColor = colTemp
                Me.lablStat04H.ForeColor = colTemp
                Me.lablStat05H.ForeColor = colTemp
                Me.lablStat06H.ForeColor = colTemp
                Me.lablStat07H.ForeColor = colTemp
                Me.lablStat08H.ForeColor = colTemp
                Me.lablStat09H.ForeColor = colTemp
                Me.lablStat10H.ForeColor = colTemp
                Me.lablStat11H.ForeColor = colTemp
                Me.lablStat12H.ForeColor = colTemp
                Me.lablStat13H.ForeColor = colTemp
                Me.lablStat14H.ForeColor = colTemp
                Me.lablStat15H.ForeColor = colTemp
                Me.lablStat16H.ForeColor = colTemp
                Me.lablStat17H.ForeColor = colTemp
                Me.lablStat18H.ForeColor = colTemp
                Me.lablStat19H.ForeColor = colTemp
                Me.lablStat20H.ForeColor = colTemp
                Me.lablStat21H.ForeColor = colTemp
                Me.lablStat22H.ForeColor = colTemp
                Me.lablStat23H.ForeColor = colTemp
                Me.lablStat24H.ForeColor = colTemp
                Me.lablStat25H.ForeColor = colTemp
                Me.lablStat26H.ForeColor = colTemp
                Me.lablStat27H.ForeColor = colTemp
                Me.lablStat28H.ForeColor = colTemp
                Me.lablStat29H.ForeColor = colTemp
                Me.lablStat30H.ForeColor = colTemp

                colTemp = Color.FromArgb(.AwayColour2)
                Me.lablStat01A.ForeColor = colTemp
                Me.lablStat02A.ForeColor = colTemp
                Me.lablStat03A.ForeColor = colTemp
                Me.lablStat04A.ForeColor = colTemp
                Me.lablStat05A.ForeColor = colTemp
                Me.lablStat06A.ForeColor = colTemp
                Me.lablStat07A.ForeColor = colTemp
                Me.lablStat08A.ForeColor = colTemp
                Me.lablStat09A.ForeColor = colTemp
                Me.lablStat10A.ForeColor = colTemp
                Me.lablStat11A.ForeColor = colTemp
                Me.lablStat12A.ForeColor = colTemp
                Me.lablStat13A.ForeColor = colTemp
                Me.lablStat14A.ForeColor = colTemp
                Me.lablStat15A.ForeColor = colTemp
                Me.lablStat16A.ForeColor = colTemp
                Me.lablStat17A.ForeColor = colTemp
                Me.lablStat18A.ForeColor = colTemp
                Me.lablStat19A.ForeColor = colTemp
                Me.lablStat20A.ForeColor = colTemp
                Me.lablStat21A.ForeColor = colTemp
                Me.lablStat22A.ForeColor = colTemp
                Me.lablStat23A.ForeColor = colTemp
                Me.lablStat24A.ForeColor = colTemp
                Me.lablStat25A.ForeColor = colTemp
                Me.lablStat26A.ForeColor = colTemp
                Me.lablStat27A.ForeColor = colTemp
                Me.lablStat28A.ForeColor = colTemp
                Me.lablStat29A.ForeColor = colTemp
                Me.lablStat30A.ForeColor = colTemp

                ShowPitchLogLabels()

            End With
        End If
    End Sub
    Function AssignLiveMatch(ByVal strFullMessage As String) As clsMatch
        Dim temp As New clsMatch
        Dim dataArray() As String
        'MessageBox.Show(strFullMessage)
        Try
            'MatchDetails|MatchID|SportType|League|Date|Period|StatePhrase|HomeID|AwayID|HomeShortName|AwayShortName|HomeLongName|AwayLongName|HomeScoreLine|AwayScoreLine|HomeGoals|AwayGoals|HomePoints|AwayPoints|HomeTries|AwayTries|HomeCol|AwayCol

            dataArray = strFullMessage.Split(Chr(124))
            With temp
                .MatchID = Val(dataArray(1))
                .SportType = Val(dataArray(2))
                .LeagueName = dataArray(3)
                .MatchDate = dataArray(4)
                .Period = Val(dataArray(5))
                .StatePhrase = dataArray(6)
                .HomeTeamID = Val(dataArray(7))
                .AwayTeamID = Val(dataArray(8))
                .HomeShortName = dataArray(9)
                .AwayShortName = dataArray(10)
                .HomeLongName = dataArray(11)
                .AwayLongName = dataArray(12)
                .HomeScoreLine = dataArray(13)
                .AwayScoreLine = dataArray(14)
                .HomeGoals = dataArray(15)
                .AwayGoals = dataArray(16)
                .HomePoints = dataArray(17)
                .AwayPoints = dataArray(18)
                .HomeTries = dataArray(19)
                .AwayTries = dataArray(20)
                '.HomeColour = Val(dataArray(21))
                '.AwayColour = Val(dataArray(22))
                '.HomeColour2 = Val(dataArray(23))
                '.AwayColour2 = Val(dataArray(24))
                .HomeColour2 = -16777216
                .HomeColour = -1
                .AwayColour2 = -16777216
                .AwayColour = -1
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in AssignLiveMatch")
        End Try
        Return temp
    End Function
    Function AssignMatchList(ByVal strFullMessage As String) As clsMatch()
        '    MatchList|Date|Number|ID1^Event1^HomeShortName1^AwayShortName1|ID2^Event2^HomeShortName2^AwayShortName2|...
        Dim dataArray() As String
        Dim matchArray() As String
        Dim temp(1) As clsMatch
        temp(0) = New clsMatch
        temp(1) = New clsMatch
        Try
            dataArray = strFullMessage.Split(Chr(124))
            Dim iNumMatches As Integer = Val(dataArray(2))
            If iNumMatches > 0 Then
                Dim inc As Integer, iMatch As Integer = 0
                For inc = 1 To iNumMatches
                    matchArray = dataArray(2 + inc).Split("^")
                    ReDim Preserve temp(inc)
                    temp(inc) = New clsMatch
                    temp(inc).MatchDate = dataArray(1)
                    temp(inc).MatchID = Val(matchArray(0))
                    temp(inc).LeagueName = matchArray(1)
                    temp(inc).HomeShortName = matchArray(2)
                    temp(inc).AwayShortName = matchArray(3)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in AssignMatchList")
        End Try
        Return temp

    End Function
    Sub SaveLiveMatch()
        'My.Settings.LiveMatchID = LiveMatch.MatchID
        'My.Settings.LiveMatchHomeShortName = LiveMatch.HomeShortName
        'My.Settings.LiveMatchAwayShortName = LiveMatch.AwayShortName
        'My.Settings.LiveMatchHomeLongName = LiveMatch.HomeLongName
        'My.Settings.LiveMatchAwayLongName = LiveMatch.AwayLongName
        'My.Settings.LiveMatchHomeColour = LiveMatch.HomeColour
        'My.Settings.LiveMatchAwayColour = LiveMatch.AwayColour
        'My.Settings.LiveMatchHomeColour2 = LiveMatch.HomeColour2
        'My.Settings.LiveMatchAwayColour2 = LiveMatch.AwayColour2
        'My.Settings.Save()
        Utils.SerializeMatch(LiveMatch)
    End Sub
    Sub SavePlayerStats()
        Utils.SerializePlayerStatSet(PlayerStat, 1)
        Utils.SerializePlayerStatSet(PlayerStat, 2)

    End Sub
    Sub ReadPlayerStats()
        Try
            Dim tempStat As clsPlayerStat
            Dim tempHArray As clsPlayerStatSet
            Dim tempAArray As clsPlayerStatSet
            tempHArray = Utils.DeSerializePlayerStatSet("PlayersH.xml")
            tempAArray = Utils.DeSerializePlayerStatSet("PlayersA.xml")
            Dim inc As Integer
            inc = 0
            For Each tempStat In tempHArray.PlayerStats
                PlayerStat(1, inc) = tempStat
                inc += 1
            Next
            inc = 0
            For Each tempStat In tempAArray.PlayerStats
                PlayerStat(2, inc) = tempStat
                inc += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error reading Player Stats  ")
        End Try


    End Sub
    Sub ReadLiveMatch()
        'LiveMatch.MatchID = My.Settings.LiveMatchID
        'LiveMatch.HomeShortName = My.Settings.LiveMatchHomeShortName
        'LiveMatch.AwayShortName = My.Settings.LiveMatchAwayShortName
        'LiveMatch.HomeLongName = My.Settings.LiveMatchHomeLongName
        'LiveMatch.AwayLongName = My.Settings.LiveMatchAwayLongName
        'LiveMatch.HomeColour = My.Settings.LiveMatchHomeColour
        'LiveMatch.AwayColour = My.Settings.LiveMatchAwayColour
        'LiveMatch.HomeColour2 = My.Settings.LiveMatchHomeColour2
        'LiveMatch.AwayColour2 = My.Settings.LiveMatchAwayColour2
        LiveMatch = Utils.DeSerializeMatchfile
        iMatchID = LiveMatch.MatchID
        JSONTeamStats.MatchID = iMatchID.ToString
        JSONPlayerStats.MatchID = iMatchID.ToString
        dtSelDate = LiveMatch.MatchDate
        'RemoteData.HomeScore = LiveMatch.HomeGoals
        'RemoteData.AwayScore = LiveMatch.AwayGoals
    End Sub
    Sub AssignPlayersToJSON()
        'clear existing players
        'add player team, shirt to players
        JSONPlayerStats.playerList.Clear()
        For incTeam As Integer = 1 To 2
            For incPlayer As Integer = 1 To PlayerStat.GetUpperBound(1)
                If PlayerStat(incTeam, incPlayer).PlayerNum > 0 Then
                    Dim newPlayer As New clsJSONPlayer(incTeam, PlayerStat(incTeam, incPlayer).PlayerNum.ToString)
                    'now add blank stats:
                    For inc As Integer = 1 To strPlayerStatJSONName.GetUpperBound(0)
                        If strPlayerStatJSONName(inc) <> "" Then
                            newPlayer.statList.Add(New clsJSONPlayerStat(strPlayerStatJSONName(inc)))
                        End If
                    Next
                    JSONPlayerStats.playerList.Add(newPlayer)
                End If
            Next
        Next
        Console.WriteLine(JSONPlayerStats.playerList.Count.ToString)
    End Sub
    Sub LoadDummyKickouts()
        ReDim PitchKickouts(5)
        For inc As Integer = 0 To PitchKickouts.GetUpperBound(0)
            PitchKickouts(inc) = New clsPitchLocationLog
        Next
        Dim testNum As Integer

        testNum = 1
        PitchKickouts(testNum).Direction = KickoutDirection.LeftToRight
        PitchKickouts(testNum).KickingTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).WinningTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).XLocation = 61
        PitchKickouts(testNum).YLocation = 56
        testNum = 2
        PitchKickouts(testNum).Direction = KickoutDirection.LeftToRight
        PitchKickouts(testNum).KickingTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).WinningTeamID = LiveMatch.AwayTeamID
        PitchKickouts(testNum).XLocation = 775
        PitchKickouts(testNum).YLocation = 56
        testNum = 3
        PitchKickouts(testNum).Direction = KickoutDirection.LeftToRight
        PitchKickouts(testNum).KickingTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).WinningTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).XLocation = 61
        PitchKickouts(testNum).YLocation = 479
        testNum = 4
        PitchKickouts(testNum).Direction = KickoutDirection.LeftToRight
        PitchKickouts(testNum).KickingTeamID = LiveMatch.HomeTeamID
        PitchKickouts(testNum).WinningTeamID = LiveMatch.AwayTeamID
        PitchKickouts(testNum).XLocation = 775
        PitchKickouts(testNum).YLocation = 479
        testNum = 5
        PitchKickouts(testNum).Direction = KickoutDirection.LeftToRight
        PitchKickouts(testNum).KickingTeamID = LiveMatch.AwayTeamID
        PitchKickouts(testNum).WinningTeamID = LiveMatch.AwayTeamID
        PitchKickouts(testNum).XLocation = 330
        PitchKickouts(testNum).YLocation = 270

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Confirm you want to Exit MatchLog", "Exit", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Try
                SavePlayerStats()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Saving data")
            End Try
            If bConnectedToServer = True Then
                SendData("DISCONNECT|" & Config.PCName & "|" & Config.LocalIPAddress & "|")
                Threading.Thread.Sleep(1000)    'allow for response
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub ParseCommandLineArgs()
        Dim inputArgument As String = "/input="
        Dim inputName As String = ""

        For Each s As String In My.Application.CommandLineArgs
            Config.ConfigFilename = s
            'If s.ToLower.StartsWith(inputArgument) Then
            '    inputName = s.Remove(0, inputArgument.Length)
            'End If
        Next

        'If inputName = "" Then
        '    MsgBox("No input name")
        'Else
        '    MsgBox("Input name: " & inputName)
        'End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case ",", "<"
                LogPossession(1)
            Case ".", ">"
                LogPossession(2)
            Case "/", "?"
                LogPossession(0)
            Case "z", "Z"
                LogArea(1)
            Case "x", "X"
                LogArea(2)
            Case "c", "C"
                LogArea(3)
            Case "v", "V"
                LogArea(4)

        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ParseCommandLineArgs()
        InitClasses()
        Config.ReadSetup()
        SetUser()
        Config.ReadStatnames()
        ReadLiveMatch()
        LiveMatch.HomeColour = -1
        LiveMatch.HomeColour2 = -16777216
        LiveMatch.AwayColour = -1
        LiveMatch.AwayColour2 = -16777216
        ReDim PitchKickouts(0)
        PitchKickouts(0) = New clsPitchLocationLog
        ReDim Pitch4565(0)
        Pitch4565(0) = New clsPitchLocationLog
        ReDim PitchFrees(0)
        PitchFrees(0) = New clsPitchLocationLog
        currentPitchLogType = PitchLogType.FortyFive_SixtyFive
        ReadPlayerStats()
        AssignPlayersToJSON()
        ShowConnectionStatus(0)
        SetEnables()
        ShowHeadings()
        ShowPlayerNames(1)
        ShowPlayerNames(2)
        ShowMatch()
        ShowTeamStats()
        ShowPlayerStats(1, 1)
        ShowPlayerStats(2, 1)
        ShowPlayerSummaryStats(1)
        ShowPlayerSummaryStats(2)
        ShowDirection()
        Me.Text = "MatchLog by PIRANHA Systems v " & Application.ProductVersion & "       User: " & Config.UserName
        If Config.UseRBStatNames Then
            Me.Text += "       Stat Names: ReportBuilder"
            btnFetchStatNames.Visible = True
        Else
            Me.Text += "       Stat Names file: " + Config.StatnamesFilename
        End If
        btnFetchLiveMatch.Visible = Config.UseRBLiveMatch
        btnSetup.Visible = Not (Config.UseRBLiveMatch)
        If Config.AutoConectToSportServer = True Then
            ConnectToSportServer()
            Me.timerCheckConnection.Enabled = True
        End If
    End Sub
    Sub SetUser()
        Select Case Config.UserName
            Case "SETANTA2009"
                Config.NumberOfAreas = 3
            Case "SETANTA2009 RUGBY", "INPUT TWICKENHAM", "PRO14"
                Config.NumberOfAreas = 4
            Case "TV3", "SKY2014 GAA", "GAA STATS", "SKYSUPERLEAGUE"
                Config.NumberOfAreas = 3
            Case Else
                Config.NumberOfAreas = 3
                'MessageBox.Show("Unrecognised User: " & Config.UserName & vbLf & "Cannot continue", "Error starting")
                'End
        End Select
    End Sub
    Sub SetEnables()
        Me.groupRemotePossession.Visible = Not (Config.LogPossession)
        Select Case Config.NumberOfAreas
            Case 4
                Me.lablRemoteAreaR1.Visible = True
                Me.lablRemoteAreaR2.Visible = True
                Me.lablRemoteAreaR3.Visible = True
                Me.lablRemoteAreaR4.Visible = True
                Me.lablRemoteAreaS1.Visible = False
                Me.lablRemoteAreaS2.Visible = False
                Me.lablRemoteAreaS3.Visible = False
                Me.groupActionAreasRugby.Visible = Config.LogPossession
                Me.groupActionAreasSoccer.Visible = False
            Case Else
                Me.lablRemoteAreaR1.Visible = False
                Me.lablRemoteAreaR2.Visible = False
                Me.lablRemoteAreaR3.Visible = False
                Me.lablRemoteAreaR4.Visible = False
                Me.lablRemoteAreaS1.Visible = True
                Me.lablRemoteAreaS2.Visible = True
                Me.lablRemoteAreaS3.Visible = True
                Me.groupActionAreasRugby.Visible = False
                Me.groupActionAreasSoccer.Visible = Config.LogPossession
        End Select
        Me.groupPossession.Visible = Config.LogPossession
        Me.groupViewTime.Visible = Config.LogPossession
        Me.groupClock.Visible = Config.LogPossession
        Me.timerCheckClock.Enabled = Config.LogPossession
        Me.btnPeriod0.Enabled = bPeriodEnabled
        Me.btnPeriod1.Enabled = bPeriodEnabled
        Me.btnPeriod2.Enabled = bPeriodEnabled
        Me.btnPeriod3.Enabled = bPeriodEnabled
        Me.btnPeriod4.Enabled = bPeriodEnabled
        Me.btnPeriod5.Enabled = bPeriodEnabled
        Me.btnPeriod6.Enabled = bPeriodEnabled
        Me.btnPeriod7.Enabled = bPeriodEnabled
        Me.btnPeriod8.Enabled = bPeriodEnabled
        Select Case Config.UserName
            Case "SKYSUPERLEAGUE"
                panelSuperLeaguePro14.Visible = True
                picBoxSLLogo.Visible = True
                panelSuperLeaguePro14.BringToFront()
                TabControl1.TabPages.RemoveByKey("tabKickouts")
                TabControl1.TabPages.RemoveByKey("tabPenalties")
                TabControl1.TabPages.RemoveByKey("tabCarries")
'                ShowCarryPlayers()
            Case "PRO14"
                'testing
                panelSuperLeaguePro14.Visible = True
                picBoxPro14.Visible = True
                panelSuperLeaguePro14.BringToFront()
                TabControl1.TabPages.RemoveByKey("tabKickouts")
                TabControl1.TabPages.RemoveByKey("tabCarries")
            Case Else
                TabControl1.TabPages.RemoveByKey("tabCarries")
        End Select
    End Sub
    Sub InitClasses()
        Dim inc As Integer, iTeam As Integer
        ReDim MatchList(1)
        MatchList(0) = New clsMatch
        MatchList(1) = New clsMatch

        ReDim MatchClock(8)
        For inc = 0 To MatchClock.GetUpperBound(0)
            MatchClock(inc) = New clsClock
        Next
        ReDim MatchPossession(8)
        For inc = 0 To MatchPossession.GetUpperBound(0)
            MatchPossession(inc) = New clsPossession
        Next
        ReDim strTeamStatName(42)
        For inc = 0 To strTeamStatName.GetUpperBound(0)
            strTeamStatName(inc) = ""
        Next
        ReDim strTeamStatJSONName(42)
        For inc = 0 To strTeamStatJSONName.GetUpperBound(0)
            strTeamStatJSONName(inc) = ""
        Next
        ReDim strRBTeamStatJSONName(42)
        For inc = 0 To strRBTeamStatJSONName.GetUpperBound(0)
            strRBTeamStatJSONName(inc) = ""
        Next
        ReDim strPlayerStatName(30)
        For inc = 0 To strPlayerStatName.GetUpperBound(0)
            strPlayerStatName(inc) = ""
        Next
        ReDim strPlayerStatJSONName(30)
        For inc = 0 To strPlayerStatJSONName.GetUpperBound(0)
            strPlayerStatJSONName(inc) = ""
        Next
        ReDim strRBPlayerStatJSONName(30)
        For inc = 0 To strRBPlayerStatJSONName.GetUpperBound(0)
            strRBPlayerStatJSONName(inc) = ""
        Next
        ReDim strPenaltyName(30)
        For inc = 0 To strPenaltyName.GetUpperBound(0)
            strPenaltyName(inc) = ""
        Next
        ReDim PlayerStat(2, 25)
        For iTeam = 0 To 2
            For inc = 0 To 25
                PlayerStat(iTeam, inc) = New clsPlayerStat
            Next
        Next
    End Sub

    Sub ShowCarryPlayers()
        Dim iTeam As Integer = 1
        Dim tempItem As New ListViewItem

        listViewCarriesHome.Items.Clear()
        listViewCarriesAway.Items.Clear()
        For inc As Integer = 1 To 21    'SL2020 only
            tempItem = New ListViewItem
            tempItem.Text = PlayerStat(iTeam, inc).PlayerID
            tempItem.SubItems.Add(PlayerStat(iTeam, inc).PlayerNum.ToString)
            tempItem.SubItems.Add(PlayerStat(iTeam, inc).PlayerShortName)
            listViewCarriesHome.Items.Add(tempItem)
        Next
        iTeam = 2
        For inc As Integer = 1 To 21    'SL2020 only
            tempItem = New ListViewItem
            tempItem.Text = PlayerStat(iTeam, inc).PlayerID
            tempItem.SubItems.Add(PlayerStat(iTeam, inc).PlayerNum.ToString)
            tempItem.SubItems.Add(PlayerStat(iTeam, inc).PlayerShortName)
            listViewCarriesAway.Items.Add(tempItem)
        Next

    End Sub
    Delegate Sub ShowTeamStatsCallback()
    Sub ShowTeamStats()
        If lablStat01H.InvokeRequired Then
            Dim d As New ShowTeamStatsCallback(AddressOf ShowTeamStats)
            Me.Invoke(d, New Object() {})
        Else

            Dim inc As Integer, tempLabel As Label
            Dim colHighlight As Color = Color.Orange
            Dim colNormal As Color = Color.LightGray
            Dim colTemp As Color
            Me.lablStat01H.Text = LiveMatch.Stat01H.ToString
            Me.lablStat02H.Text = LiveMatch.Stat02H.ToString
            Me.lablStat03H.Text = LiveMatch.Stat03H.ToString
            Me.lablStat04H.Text = LiveMatch.Stat04H.ToString
            Me.lablStat05H.Text = LiveMatch.Stat05H.ToString
            Me.lablStat06H.Text = LiveMatch.Stat06H.ToString
            Me.lablStat07H.Text = LiveMatch.Stat07H.ToString
            Me.lablStat08H.Text = LiveMatch.Stat08H.ToString
            Me.lablStat09H.Text = LiveMatch.Stat09H.ToString
            Me.lablStat10H.Text = LiveMatch.Stat10H.ToString
            Me.lablStat11H.Text = LiveMatch.Stat11H.ToString
            Me.lablStat12H.Text = LiveMatch.Stat12H.ToString
            Me.lablStat13H.Text = LiveMatch.Stat13H.ToString
            Me.lablStat14H.Text = LiveMatch.Stat14H.ToString
            Me.lablStat15H.Text = LiveMatch.Stat15H.ToString
            Me.lablStat16H.Text = LiveMatch.Stat16H.ToString
            Me.lablStat17H.Text = LiveMatch.Stat17H.ToString
            Me.lablStat18H.Text = LiveMatch.Stat18H.ToString
            Me.lablStat19H.Text = LiveMatch.Stat19H.ToString
            Me.lablStat20H.Text = LiveMatch.Stat20H.ToString
            Me.lablStat21H.Text = LiveMatch.Stat21H.ToString
            Me.lablStat22H.Text = LiveMatch.Stat22H.ToString
            Me.lablStat23H.Text = LiveMatch.Stat23H.ToString
            Me.lablStat24H.Text = LiveMatch.Stat24H.ToString
            Me.lablStat25H.Text = LiveMatch.Stat25H.ToString
            Me.lablStat26H.Text = LiveMatch.Stat26H.ToString
            Me.lablStat27H.Text = LiveMatch.Stat27H.ToString
            Me.lablStat28H.Text = LiveMatch.Stat28H.ToString
            Me.lablStat29H.Text = LiveMatch.Stat29H.ToString
            Me.lablStat30H.Text = LiveMatch.Stat30H.ToString

            Me.lablStat01A.Text = LiveMatch.Stat01A.ToString
            Me.lablStat02A.Text = LiveMatch.Stat02A.ToString
            Me.lablStat03A.Text = LiveMatch.Stat03A.ToString
            Me.lablStat04A.Text = LiveMatch.Stat04A.ToString
            Me.lablStat05A.Text = LiveMatch.Stat05A.ToString
            Me.lablStat06A.Text = LiveMatch.Stat06A.ToString
            Me.lablStat07A.Text = LiveMatch.Stat07A.ToString
            Me.lablStat08A.Text = LiveMatch.Stat08A.ToString
            Me.lablStat09A.Text = LiveMatch.Stat09A.ToString
            Me.lablStat10A.Text = LiveMatch.Stat10A.ToString
            Me.lablStat11A.Text = LiveMatch.Stat11A.ToString
            Me.lablStat12A.Text = LiveMatch.Stat12A.ToString
            Me.lablStat13A.Text = LiveMatch.Stat13A.ToString
            Me.lablStat14A.Text = LiveMatch.Stat14A.ToString
            Me.lablStat15A.Text = LiveMatch.Stat15A.ToString
            Me.lablStat16A.Text = LiveMatch.Stat16A.ToString
            Me.lablStat17A.Text = LiveMatch.Stat17A.ToString
            Me.lablStat18A.Text = LiveMatch.Stat18A.ToString
            Me.lablStat19A.Text = LiveMatch.Stat19A.ToString
            Me.lablStat20A.Text = LiveMatch.Stat20A.ToString
            Me.lablStat21A.Text = LiveMatch.Stat21A.ToString
            Me.lablStat22A.Text = LiveMatch.Stat22A.ToString
            Me.lablStat23A.Text = LiveMatch.Stat23A.ToString
            Me.lablStat24A.Text = LiveMatch.Stat24A.ToString
            Me.lablStat25A.Text = LiveMatch.Stat25A.ToString
            Me.lablStat26A.Text = LiveMatch.Stat26A.ToString
            Me.lablStat27A.Text = LiveMatch.Stat27A.ToString
            Me.lablStat28A.Text = LiveMatch.Stat28A.ToString
            Me.lablStat29A.Text = LiveMatch.Stat29A.ToString
            Me.lablStat30A.Text = LiveMatch.Stat30A.ToString

            colTemp = Color.FromArgb(LiveMatch.HomeColour)
            For inc = 1 To 30
                tempLabel = FindTeamStatLabel(1, inc)
                tempLabel.BackColor = colTemp
            Next
            colTemp = Color.FromArgb(LiveMatch.AwayColour)
            For inc = 1 To 30
                tempLabel = FindTeamStatLabel(2, inc)
                tempLabel.BackColor = colTemp
            Next
            tempLabel = FindTeamStatLabel(iCurrentTeam, iCurrentTeamStat)
            tempLabel.BackColor = colHighlight

            Me.lablRemove.Visible = bRemove
        End If
    End Sub
    Function FindTeamStatLabel(ByVal iTeam As Integer, ByVal iNum As Integer) As Label
        Dim testLabel As New Control
        Dim FailLabel As New Label
        Dim iPanels As Integer = Me.TabControl1.TabPages.Count
        Dim incPanel As Integer = 0
        Dim strCode As String
        If iTeam = 2 Then
            strCode = "A"
        Else
            strCode = "H"
        End If
        'check all panels in case they are out of order
        For incPanel = 0 To iPanels - 1
            For Each testLabel In Me.TabControl1.TabPages(incPanel).Controls
                If testLabel.Name = "lablStat" & Format(iNum, "00") & strCode Then
                    Return testLabel
                    Exit Function
                End If
            Next
        Next
        Return FailLabel
    End Function
    Delegate Sub ShowPlayerStatsCallback(ByVal iTeam As Integer, ByVal iPlayerNum As Integer)
    Sub ShowPlayerStats(ByVal iTeam As Integer, ByVal iPlayerNum As Integer)
        If lablPlayerStat01H.InvokeRequired Then
            Dim d As New ShowPlayerStatsCallback(AddressOf ShowPlayerStats)
            Me.Invoke(d, New Object() {iTeam, iPlayerNum})
        Else
            Dim tempButton As Button, tempLabel As Label
            Dim colHighlight As Color = Color.Orange
            Dim colNormal As Color = Color.LightGray
            Dim inc As Integer
            Select Case iTeam
                Case 1
                    Me.lablPlayerStat01H.Text = PlayerStat(iTeam, iPlayerNum).Stat01
                    Me.lablPlayerStat02H.Text = PlayerStat(iTeam, iPlayerNum).Stat02
                    Me.lablPlayerStat03H.Text = PlayerStat(iTeam, iPlayerNum).Stat03
                    Me.lablPlayerStat04H.Text = PlayerStat(iTeam, iPlayerNum).Stat04
                    Me.lablPlayerStat05H.Text = PlayerStat(iTeam, iPlayerNum).Stat05
                    Me.lablPlayerStat06H.Text = PlayerStat(iTeam, iPlayerNum).Stat06
                    Me.lablPlayerStat07H.Text = PlayerStat(iTeam, iPlayerNum).Stat07
                    Me.lablPlayerStat08H.Text = PlayerStat(iTeam, iPlayerNum).Stat08
                    Me.lablPlayerStat09H.Text = PlayerStat(iTeam, iPlayerNum).Stat09
                    Me.lablPlayerStat10H.Text = PlayerStat(iTeam, iPlayerNum).Stat10
                    Me.lablPlayerStat11H.Text = PlayerStat(iTeam, iPlayerNum).Stat11
                    Me.lablPlayerStat12H.Text = PlayerStat(iTeam, iPlayerNum).Stat12
                    Me.lablPlayerStat13H.Text = PlayerStat(iTeam, iPlayerNum).Stat13
                    Me.lablPlayerStat14H.Text = PlayerStat(iTeam, iPlayerNum).Stat14
                    Me.lablPlayerStat15H.Text = PlayerStat(iTeam, iPlayerNum).Stat15
                    Me.lablPlayerStat16H.Text = PlayerStat(iTeam, iPlayerNum).Stat16
                    Me.lablPlayerStat17H.Text = PlayerStat(iTeam, iPlayerNum).Stat17
                    Me.lablPlayerStat18H.Text = PlayerStat(iTeam, iPlayerNum).Stat18
                    Me.lablPlayerStat19H.Text = PlayerStat(iTeam, iPlayerNum).Stat19
                    Me.lablPlayerStat20H.Text = PlayerStat(iTeam, iPlayerNum).Stat20
                    Me.lablPlayerStat21H.Text = PlayerStat(iTeam, iPlayerNum).Stat21
                    Me.lablPlayerStat22H.Text = PlayerStat(iTeam, iPlayerNum).Stat22
                    Me.lablPlayerStat23H.Text = PlayerStat(iTeam, iPlayerNum).Stat23
                    Me.lablPlayerStat24H.Text = PlayerStat(iTeam, iPlayerNum).Stat24
                    Me.lablPlayerStat25H.Text = PlayerStat(iTeam, iPlayerNum).Stat25
                    Me.lablPlayerStat26H.Text = PlayerStat(iTeam, iPlayerNum).Stat26
                    Me.lablPlayerStat27H.Text = PlayerStat(iTeam, iPlayerNum).Stat27
                    Me.lablPlayerStat28H.Text = PlayerStat(iTeam, iPlayerNum).Stat28
                    Me.lablPlayerStat29H.Text = PlayerStat(iTeam, iPlayerNum).Stat29
                    Me.lablPlayerStat30H.Text = PlayerStat(iTeam, iPlayerNum).Stat30

                Case 2
                    Me.lablPlayerStat01A.Text = PlayerStat(iTeam, iPlayerNum).Stat01
                    Me.lablPlayerStat02A.Text = PlayerStat(iTeam, iPlayerNum).Stat02
                    Me.lablPlayerStat03A.Text = PlayerStat(iTeam, iPlayerNum).Stat03
                    Me.lablPlayerStat04A.Text = PlayerStat(iTeam, iPlayerNum).Stat04
                    Me.lablPlayerStat05A.Text = PlayerStat(iTeam, iPlayerNum).Stat05
                    Me.lablPlayerStat06A.Text = PlayerStat(iTeam, iPlayerNum).Stat06
                    Me.lablPlayerStat07A.Text = PlayerStat(iTeam, iPlayerNum).Stat07
                    Me.lablPlayerStat08A.Text = PlayerStat(iTeam, iPlayerNum).Stat08
                    Me.lablPlayerStat09A.Text = PlayerStat(iTeam, iPlayerNum).Stat09
                    Me.lablPlayerStat10A.Text = PlayerStat(iTeam, iPlayerNum).Stat10
                    Me.lablPlayerStat11A.Text = PlayerStat(iTeam, iPlayerNum).Stat11
                    Me.lablPlayerStat12A.Text = PlayerStat(iTeam, iPlayerNum).Stat12
                    Me.lablPlayerStat13A.Text = PlayerStat(iTeam, iPlayerNum).Stat13
                    Me.lablPlayerStat14A.Text = PlayerStat(iTeam, iPlayerNum).Stat14
                    Me.lablPlayerStat15A.Text = PlayerStat(iTeam, iPlayerNum).Stat15
                    Me.lablPlayerStat16A.Text = PlayerStat(iTeam, iPlayerNum).Stat16
                    Me.lablPlayerStat17A.Text = PlayerStat(iTeam, iPlayerNum).Stat17
                    Me.lablPlayerStat18A.Text = PlayerStat(iTeam, iPlayerNum).Stat18
                    Me.lablPlayerStat19A.Text = PlayerStat(iTeam, iPlayerNum).Stat19
                    Me.lablPlayerStat20A.Text = PlayerStat(iTeam, iPlayerNum).Stat20
                    Me.lablPlayerStat21A.Text = PlayerStat(iTeam, iPlayerNum).Stat21
                    Me.lablPlayerStat22A.Text = PlayerStat(iTeam, iPlayerNum).Stat22
                    Me.lablPlayerStat23A.Text = PlayerStat(iTeam, iPlayerNum).Stat23
                    Me.lablPlayerStat24A.Text = PlayerStat(iTeam, iPlayerNum).Stat24
                    Me.lablPlayerStat25A.Text = PlayerStat(iTeam, iPlayerNum).Stat25
                    Me.lablPlayerStat26A.Text = PlayerStat(iTeam, iPlayerNum).Stat26
                    Me.lablPlayerStat27A.Text = PlayerStat(iTeam, iPlayerNum).Stat27
                    Me.lablPlayerStat28A.Text = PlayerStat(iTeam, iPlayerNum).Stat28
                    Me.lablPlayerStat29A.Text = PlayerStat(iTeam, iPlayerNum).Stat29
                    Me.lablPlayerStat30A.Text = PlayerStat(iTeam, iPlayerNum).Stat30
                    'For inc = 1 To 25
                    '    tempButton = FindPlayerButtonByName(iTeam, inc)
                    '    tempButton.BackColor = colNormal
                    'Next
                    'tempButton = FindPlayerButtonByName(iTeam, iPlayerNum)
                    'tempButton.BackColor = colHighlight
                    'For inc = 1 To 30
                    '    tempLabel = FindPlayerStatLabel(iTeam, inc)
                    '    tempLabel.BackColor = colNormal
                    'Next
                    'tempLabel = FindPlayerStatLabel(iTeam, iCurrentPlayerStat)
                    'tempLabel.BackColor = colHighlight
            End Select
            Select Case Config.UserName
                Case "SKYSUPERLEAGUE"
                    'possible v long data for metres
                    'careful if stat moves###################
                    If PlayerStat(1, iPlayerNum).Stat08.ToString.Length > 4 Then
                        lablPlayerStat08H.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                    Else
                        lablPlayerStat08H.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
                    End If
                    If PlayerStat(2, iPlayerNum).Stat08.ToString.Length > 4 Then
                        lablPlayerStat08A.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Bold)
                    Else
                        lablPlayerStat08A.Font = New Font("Microsoft Sans Serif", 20, FontStyle.Bold)
                    End If
            End Select
            For inc = 1 To 25
                tempButton = FindPlayerButtonByName(iTeam, inc)
                tempButton.BackColor = colNormal
            Next
            tempButton = FindPlayerButtonByName(iTeam, iPlayerNum)
            tempButton.BackColor = colHighlight
            For inc = 1 To 30
                tempLabel = FindPlayerStatLabel(iTeam, inc)
                tempLabel.BackColor = colNormal
            Next
            tempLabel = FindPlayerStatLabel(iTeam, iCurrentPlayerStat)
            tempLabel.BackColor = colHighlight
            Me.lablRemove.Visible = bRemove
        End If
    End Sub
    Function FindPlayerButtonByName(ByVal iTeam As Integer, ByVal iNum As Integer) As Button
        Dim testButton As New Control
        Dim FailButton As New Button
        Dim iPanels As Integer = Me.TabControl1.TabPages.Count
        Dim incPanel As Integer = 0
        Dim strCode As String
        If iTeam = 2 Then
            strCode = "A"
        Else
            strCode = "H"
        End If
        'check all panels in case they are out of order
        For incPanel = 0 To iPanels - 1
            For Each testButton In Me.TabControl1.TabPages(incPanel).Controls
                If testButton.Name = "btnPlayer" & Format(iNum, "00") & strCode Then
                    Return testButton
                    Exit Function
                End If
            Next
        Next
        Return FailButton
    End Function
    Function FindPenaltyNameButton(ByVal iNum As Integer) As Button
        Dim testButton As New Control
        Dim FailButton As New Button
        Dim iPanels As Integer = Me.TabControl1.TabPages.Count
        Dim incPanel As Integer = 0
        'check all panels in case they are out of order
        For incPanel = 0 To iPanels - 1
            For Each testButton In Me.TabControl1.TabPages(incPanel).Controls
                If testButton.Name = "btnPenaltyName" & Format(iNum, "00") Then
                    Return testButton
                    Exit Function
                End If
            Next
        Next
        Return FailButton
    End Function
    Function FindPlayerStatLabel(ByVal iTeam As Integer, ByVal iNum As Integer) As Label
        Dim testLabel As New Control
        Dim FailLabel As New Label
        Dim iPanels As Integer = Me.TabControl1.TabPages.Count
        Dim incPanel As Integer = 0
        Dim strCode As String
        If iTeam = 2 Then
            strCode = "A"
        Else
            strCode = "H"
        End If
        'check all panels in case they are out of order
        For incPanel = 0 To iPanels - 1
            For Each testLabel In Me.TabControl1.TabPages(incPanel).Controls
                If testLabel.Name = "lablPlayerStat" & Format(iNum, "00") & strCode Then
                    Return testLabel
                    Exit Function
                End If
            Next
        Next
        Return FailLabel
    End Function

    Delegate Sub ShowHeadingsCallback()
    Sub ShowHeadings()
        If lablHeading01.InvokeRequired Then
            Dim d As New ShowHeadingsCallback(AddressOf ShowHeadings)
            Me.Invoke(d, New Object() {})
        Else
            Dim inc As Integer
            Me.lablHeading01.Text = strTeamStatName(1)
            Me.lablHeading02.Text = strTeamStatName(2)
            Me.lablHeading03.Text = strTeamStatName(3)
            Me.lablHeading04.Text = strTeamStatName(4)
            Me.lablHeading05.Text = strTeamStatName(5)
            Me.lablHeading06.Text = strTeamStatName(6)
            Me.lablHeading07.Text = strTeamStatName(7)
            Me.lablHeading08.Text = strTeamStatName(8)
            Me.lablHeading09.Text = strTeamStatName(9)
            Me.lablHeading10.Text = strTeamStatName(10)
            Me.lablHeading11.Text = strTeamStatName(11)
            Me.lablHeading12.Text = strTeamStatName(12)
            Me.lablHeading13.Text = strTeamStatName(13)
            Me.lablHeading14.Text = strTeamStatName(14)
            Me.lablHeading15.Text = strTeamStatName(15)
            Me.lablHeading16.Text = strTeamStatName(16)
            Me.lablHeading17.Text = strTeamStatName(17)
            Me.lablHeading18.Text = strTeamStatName(18)
            Me.lablHeading19.Text = strTeamStatName(19)
            Me.lablHeading20.Text = strTeamStatName(20)
            Me.lablHeading21.Text = strTeamStatName(21)
            Me.lablHeading22.Text = strTeamStatName(22)
            Me.lablHeading23.Text = strTeamStatName(23)
            Me.lablHeading24.Text = strTeamStatName(24)
            Me.lablHeading25.Text = strTeamStatName(25)
            Me.lablHeading26.Text = strTeamStatName(26)
            Me.lablHeading27.Text = strTeamStatName(27)
            Me.lablHeading28.Text = strTeamStatName(28)
            Me.lablHeading29.Text = strTeamStatName(29)
            Me.lablHeading30.Text = strTeamStatName(30)

            lablHeading01.Visible = (strTeamStatName(1).Trim <> "")
            lablHeading02.Visible = (strTeamStatName(2).Trim <> "")
            lablHeading03.Visible = (strTeamStatName(3).Trim <> "")
            lablHeading04.Visible = (strTeamStatName(4).Trim <> "")
            lablHeading05.Visible = (strTeamStatName(5).Trim <> "")
            lablHeading06.Visible = (strTeamStatName(6).Trim <> "")
            lablHeading07.Visible = (strTeamStatName(7).Trim <> "")
            lablHeading08.Visible = (strTeamStatName(8).Trim <> "")
            lablHeading09.Visible = (strTeamStatName(9).Trim <> "")
            lablHeading10.Visible = (strTeamStatName(10).Trim <> "")
            lablHeading11.Visible = (strTeamStatName(11).Trim <> "")
            lablHeading12.Visible = (strTeamStatName(12).Trim <> "")
            lablHeading13.Visible = (strTeamStatName(13).Trim <> "")
            lablHeading14.Visible = (strTeamStatName(14).Trim <> "")
            lablHeading15.Visible = (strTeamStatName(15).Trim <> "")
            lablHeading16.Visible = (strTeamStatName(16).Trim <> "")
            lablHeading17.Visible = (strTeamStatName(17).Trim <> "")
            lablHeading18.Visible = (strTeamStatName(18).Trim <> "")
            lablHeading19.Visible = (strTeamStatName(19).Trim <> "")
            lablHeading20.Visible = (strTeamStatName(20).Trim <> "")
            lablHeading21.Visible = (strTeamStatName(21).Trim <> "")
            lablHeading22.Visible = (strTeamStatName(22).Trim <> "")
            lablHeading23.Visible = (strTeamStatName(23).Trim <> "")
            lablHeading24.Visible = (strTeamStatName(24).Trim <> "")
            lablHeading25.Visible = (strTeamStatName(25).Trim <> "")
            lablHeading26.Visible = (strTeamStatName(26).Trim <> "")
            lablHeading27.Visible = (strTeamStatName(27).Trim <> "")
            lablHeading28.Visible = (strTeamStatName(28).Trim <> "")
            lablHeading29.Visible = (strTeamStatName(29).Trim <> "")
            lablHeading30.Visible = (strTeamStatName(30).Trim <> "")

            lablStat01H.Visible = (strTeamStatName(1).Trim <> "")
            lablStat02H.Visible = (strTeamStatName(2).Trim <> "")
            lablStat03H.Visible = (strTeamStatName(3).Trim <> "")
            lablStat04H.Visible = (strTeamStatName(4).Trim <> "")
            lablStat05H.Visible = (strTeamStatName(5).Trim <> "")
            lablStat06H.Visible = (strTeamStatName(6).Trim <> "")
            lablStat07H.Visible = (strTeamStatName(7).Trim <> "")
            lablStat08H.Visible = (strTeamStatName(8).Trim <> "")
            lablStat09H.Visible = (strTeamStatName(9).Trim <> "")
            lablStat10H.Visible = (strTeamStatName(10).Trim <> "")
            lablStat11H.Visible = (strTeamStatName(11).Trim <> "")
            lablStat12H.Visible = (strTeamStatName(12).Trim <> "")
            lablStat13H.Visible = (strTeamStatName(13).Trim <> "")
            lablStat14H.Visible = (strTeamStatName(14).Trim <> "")
            lablStat15H.Visible = (strTeamStatName(15).Trim <> "")
            lablStat16H.Visible = (strTeamStatName(16).Trim <> "")
            lablStat17H.Visible = (strTeamStatName(17).Trim <> "")
            lablStat18H.Visible = (strTeamStatName(18).Trim <> "")
            lablStat19H.Visible = (strTeamStatName(19).Trim <> "")
            lablStat20H.Visible = (strTeamStatName(20).Trim <> "")
            lablStat21H.Visible = (strTeamStatName(21).Trim <> "")
            lablStat22H.Visible = (strTeamStatName(22).Trim <> "")
            lablStat23H.Visible = (strTeamStatName(23).Trim <> "")
            lablStat24H.Visible = (strTeamStatName(24).Trim <> "")
            lablStat25H.Visible = (strTeamStatName(25).Trim <> "")
            lablStat26H.Visible = (strTeamStatName(26).Trim <> "")
            lablStat27H.Visible = (strTeamStatName(27).Trim <> "")
            lablStat28H.Visible = (strTeamStatName(28).Trim <> "")
            lablStat29H.Visible = (strTeamStatName(29).Trim <> "")
            lablStat30H.Visible = (strTeamStatName(30).Trim <> "")

            lablStat01A.Visible = (strTeamStatName(1).Trim <> "")
            lablStat02A.Visible = (strTeamStatName(2).Trim <> "")
            lablStat03A.Visible = (strTeamStatName(3).Trim <> "")
            lablStat04A.Visible = (strTeamStatName(4).Trim <> "")
            lablStat05A.Visible = (strTeamStatName(5).Trim <> "")
            lablStat06A.Visible = (strTeamStatName(6).Trim <> "")
            lablStat07A.Visible = (strTeamStatName(7).Trim <> "")
            lablStat08A.Visible = (strTeamStatName(8).Trim <> "")
            lablStat09A.Visible = (strTeamStatName(9).Trim <> "")
            lablStat10A.Visible = (strTeamStatName(10).Trim <> "")
            lablStat11A.Visible = (strTeamStatName(11).Trim <> "")
            lablStat12A.Visible = (strTeamStatName(12).Trim <> "")
            lablStat13A.Visible = (strTeamStatName(13).Trim <> "")
            lablStat14A.Visible = (strTeamStatName(14).Trim <> "")
            lablStat15A.Visible = (strTeamStatName(15).Trim <> "")
            lablStat16A.Visible = (strTeamStatName(16).Trim <> "")
            lablStat17A.Visible = (strTeamStatName(17).Trim <> "")
            lablStat18A.Visible = (strTeamStatName(18).Trim <> "")
            lablStat19A.Visible = (strTeamStatName(19).Trim <> "")
            lablStat20A.Visible = (strTeamStatName(20).Trim <> "")
            lablStat21A.Visible = (strTeamStatName(21).Trim <> "")
            lablStat22A.Visible = (strTeamStatName(22).Trim <> "")
            lablStat23A.Visible = (strTeamStatName(23).Trim <> "")
            lablStat24A.Visible = (strTeamStatName(24).Trim <> "")
            lablStat25A.Visible = (strTeamStatName(25).Trim <> "")
            lablStat26A.Visible = (strTeamStatName(26).Trim <> "")
            lablStat27A.Visible = (strTeamStatName(27).Trim <> "")
            lablStat28A.Visible = (strTeamStatName(28).Trim <> "")
            lablStat29A.Visible = (strTeamStatName(29).Trim <> "")
            lablStat30A.Visible = (strTeamStatName(30).Trim <> "")



            Me.lablPlayerStatHeading01.Text = strPlayerStatName(1)
            Me.lablPlayerStatHeading02.Text = strPlayerStatName(2)
            Me.lablPlayerStatHeading03.Text = strPlayerStatName(3)
            Me.lablPlayerStatHeading04.Text = strPlayerStatName(4)
            Me.lablPlayerStatHeading05.Text = strPlayerStatName(5)
            Me.lablPlayerStatHeading06.Text = strPlayerStatName(6)
            Me.lablPlayerStatHeading07.Text = strPlayerStatName(7)
            Me.lablPlayerStatHeading08.Text = strPlayerStatName(8)
            Me.lablPlayerStatHeading09.Text = strPlayerStatName(9)
            Me.lablPlayerStatHeading10.Text = strPlayerStatName(10)
            Me.lablPlayerStatHeading11.Text = strPlayerStatName(11)
            Me.lablPlayerStatHeading12.Text = strPlayerStatName(12)
            Me.lablPlayerStatHeading13.Text = strPlayerStatName(13)
            Me.lablPlayerStatHeading14.Text = strPlayerStatName(14)
            Me.lablPlayerStatHeading15.Text = strPlayerStatName(15)
            Me.lablPlayerStatHeading16.Text = strPlayerStatName(16)
            Me.lablPlayerStatHeading17.Text = strPlayerStatName(17)
            Me.lablPlayerStatHeading18.Text = strPlayerStatName(18)
            Me.lablPlayerStatHeading19.Text = strPlayerStatName(19)
            Me.lablPlayerStatHeading20.Text = strPlayerStatName(20)
            Me.lablPlayerStatHeading21.Text = strPlayerStatName(21)
            Me.lablPlayerStatHeading22.Text = strPlayerStatName(22)
            Me.lablPlayerStatHeading23.Text = strPlayerStatName(23)
            Me.lablPlayerStatHeading24.Text = strPlayerStatName(24)
            Me.lablPlayerStatHeading25.Text = strPlayerStatName(25)
            Me.lablPlayerStatHeading26.Text = strPlayerStatName(26)
            Me.lablPlayerStatHeading27.Text = strPlayerStatName(27)
            Me.lablPlayerStatHeading28.Text = strPlayerStatName(28)
            Me.lablPlayerStatHeading29.Text = strPlayerStatName(29)
            Me.lablPlayerStatHeading30.Text = strPlayerStatName(30)

            Me.lablPlayerStatHeading01A.Text = strPlayerStatName(1)
            Me.lablPlayerStatHeading02A.Text = strPlayerStatName(2)
            Me.lablPlayerStatHeading03A.Text = strPlayerStatName(3)
            Me.lablPlayerStatHeading04A.Text = strPlayerStatName(4)
            Me.lablPlayerStatHeading05A.Text = strPlayerStatName(5)
            Me.lablPlayerStatHeading06A.Text = strPlayerStatName(6)
            Me.lablPlayerStatHeading07A.Text = strPlayerStatName(7)
            Me.lablPlayerStatHeading08A.Text = strPlayerStatName(8)
            Me.lablPlayerStatHeading09A.Text = strPlayerStatName(9)
            Me.lablPlayerStatHeading10A.Text = strPlayerStatName(10)
            Me.lablPlayerStatHeading11A.Text = strPlayerStatName(11)
            Me.lablPlayerStatHeading12A.Text = strPlayerStatName(12)
            Me.lablPlayerStatHeading13A.Text = strPlayerStatName(13)
            Me.lablPlayerStatHeading14A.Text = strPlayerStatName(14)
            Me.lablPlayerStatHeading15A.Text = strPlayerStatName(15)
            Me.lablPlayerStatHeading16A.Text = strPlayerStatName(16)
            Me.lablPlayerStatHeading17A.Text = strPlayerStatName(17)
            Me.lablPlayerStatHeading18A.Text = strPlayerStatName(18)
            Me.lablPlayerStatHeading19A.Text = strPlayerStatName(19)
            Me.lablPlayerStatHeading20A.Text = strPlayerStatName(20)
            Me.lablPlayerStatHeading21A.Text = strPlayerStatName(21)
            Me.lablPlayerStatHeading22A.Text = strPlayerStatName(22)
            Me.lablPlayerStatHeading23A.Text = strPlayerStatName(23)
            Me.lablPlayerStatHeading24A.Text = strPlayerStatName(24)
            Me.lablPlayerStatHeading25A.Text = strPlayerStatName(25)
            Me.lablPlayerStatHeading26A.Text = strPlayerStatName(26)
            Me.lablPlayerStatHeading27A.Text = strPlayerStatName(27)
            Me.lablPlayerStatHeading28A.Text = strPlayerStatName(28)
            Me.lablPlayerStatHeading29A.Text = strPlayerStatName(29)
            Me.lablPlayerStatHeading30A.Text = strPlayerStatName(30)

            lablPlayerStatHeading01.Visible = (strPlayerStatName(1).Trim <> "")
            lablPlayerStatHeading02.Visible = (strPlayerStatName(2).Trim <> "")
            lablPlayerStatHeading03.Visible = (strPlayerStatName(3).Trim <> "")
            lablPlayerStatHeading04.Visible = (strPlayerStatName(4).Trim <> "")
            lablPlayerStatHeading05.Visible = (strPlayerStatName(5).Trim <> "")
            lablPlayerStatHeading06.Visible = (strPlayerStatName(6).Trim <> "")
            lablPlayerStatHeading07.Visible = (strPlayerStatName(7).Trim <> "")
            lablPlayerStatHeading08.Visible = (strPlayerStatName(8).Trim <> "")
            lablPlayerStatHeading09.Visible = (strPlayerStatName(9).Trim <> "")
            lablPlayerStatHeading10.Visible = (strPlayerStatName(10).Trim <> "")
            lablPlayerStatHeading11.Visible = (strPlayerStatName(11).Trim <> "")
            lablPlayerStatHeading12.Visible = (strPlayerStatName(12).Trim <> "")
            lablPlayerStatHeading13.Visible = (strPlayerStatName(13).Trim <> "")
            lablPlayerStatHeading14.Visible = (strPlayerStatName(14).Trim <> "")
            lablPlayerStatHeading15.Visible = (strPlayerStatName(15).Trim <> "")
            lablPlayerStatHeading16.Visible = (strPlayerStatName(16).Trim <> "")
            lablPlayerStatHeading17.Visible = (strPlayerStatName(17).Trim <> "")
            lablPlayerStatHeading18.Visible = (strPlayerStatName(18).Trim <> "")
            lablPlayerStatHeading19.Visible = (strPlayerStatName(19).Trim <> "")
            lablPlayerStatHeading20.Visible = (strPlayerStatName(20).Trim <> "")
            lablPlayerStatHeading21.Visible = (strPlayerStatName(21).Trim <> "")
            lablPlayerStatHeading22.Visible = (strPlayerStatName(22).Trim <> "")
            lablPlayerStatHeading23.Visible = (strPlayerStatName(23).Trim <> "")
            lablPlayerStatHeading24.Visible = (strPlayerStatName(24).Trim <> "")
            lablPlayerStatHeading25.Visible = (strPlayerStatName(25).Trim <> "")
            lablPlayerStatHeading26.Visible = (strPlayerStatName(26).Trim <> "")
            lablPlayerStatHeading27.Visible = (strPlayerStatName(27).Trim <> "")
            lablPlayerStatHeading28.Visible = (strPlayerStatName(28).Trim <> "")
            lablPlayerStatHeading29.Visible = (strPlayerStatName(29).Trim <> "")
            lablPlayerStatHeading30.Visible = (strPlayerStatName(30).Trim <> "")

            lablPlayerStatHeading01A.Visible = (strPlayerStatName(1).Trim <> "")
            lablPlayerStatHeading02A.Visible = (strPlayerStatName(2).Trim <> "")
            lablPlayerStatHeading03A.Visible = (strPlayerStatName(3).Trim <> "")
            lablPlayerStatHeading04A.Visible = (strPlayerStatName(4).Trim <> "")
            lablPlayerStatHeading05A.Visible = (strPlayerStatName(5).Trim <> "")
            lablPlayerStatHeading06A.Visible = (strPlayerStatName(6).Trim <> "")
            lablPlayerStatHeading07A.Visible = (strPlayerStatName(7).Trim <> "")
            lablPlayerStatHeading08A.Visible = (strPlayerStatName(8).Trim <> "")
            lablPlayerStatHeading09A.Visible = (strPlayerStatName(9).Trim <> "")
            lablPlayerStatHeading10A.Visible = (strPlayerStatName(10).Trim <> "")
            lablPlayerStatHeading11A.Visible = (strPlayerStatName(11).Trim <> "")
            lablPlayerStatHeading12A.Visible = (strPlayerStatName(12).Trim <> "")
            lablPlayerStatHeading13A.Visible = (strPlayerStatName(13).Trim <> "")
            lablPlayerStatHeading14A.Visible = (strPlayerStatName(14).Trim <> "")
            lablPlayerStatHeading15A.Visible = (strPlayerStatName(15).Trim <> "")
            lablPlayerStatHeading16A.Visible = (strPlayerStatName(16).Trim <> "")
            lablPlayerStatHeading17A.Visible = (strPlayerStatName(17).Trim <> "")
            lablPlayerStatHeading18A.Visible = (strPlayerStatName(18).Trim <> "")
            lablPlayerStatHeading19A.Visible = (strPlayerStatName(19).Trim <> "")
            lablPlayerStatHeading20A.Visible = (strPlayerStatName(20).Trim <> "")
            lablPlayerStatHeading21A.Visible = (strPlayerStatName(21).Trim <> "")
            lablPlayerStatHeading22A.Visible = (strPlayerStatName(22).Trim <> "")
            lablPlayerStatHeading23A.Visible = (strPlayerStatName(23).Trim <> "")
            lablPlayerStatHeading24A.Visible = (strPlayerStatName(24).Trim <> "")
            lablPlayerStatHeading25A.Visible = (strPlayerStatName(25).Trim <> "")
            lablPlayerStatHeading26A.Visible = (strPlayerStatName(26).Trim <> "")
            lablPlayerStatHeading27A.Visible = (strPlayerStatName(27).Trim <> "")
            lablPlayerStatHeading28A.Visible = (strPlayerStatName(28).Trim <> "")
            lablPlayerStatHeading29A.Visible = (strPlayerStatName(29).Trim <> "")
            lablPlayerStatHeading30A.Visible = (strPlayerStatName(30).Trim <> "")

            'lablPlayerStat01H
            lablPlayerStat01H.Visible = (strPlayerStatName(1).Trim <> "")
            lablPlayerStat02H.Visible = (strPlayerStatName(2).Trim <> "")
            lablPlayerStat03H.Visible = (strPlayerStatName(3).Trim <> "")
            lablPlayerStat04H.Visible = (strPlayerStatName(4).Trim <> "")
            lablPlayerStat05H.Visible = (strPlayerStatName(5).Trim <> "")
            lablPlayerStat06H.Visible = (strPlayerStatName(6).Trim <> "")
            lablPlayerStat07H.Visible = (strPlayerStatName(7).Trim <> "")
            lablPlayerStat08H.Visible = (strPlayerStatName(8).Trim <> "")
            lablPlayerStat09H.Visible = (strPlayerStatName(9).Trim <> "")
            lablPlayerStat10H.Visible = (strPlayerStatName(10).Trim <> "")
            lablPlayerStat11H.Visible = (strPlayerStatName(11).Trim <> "")
            lablPlayerStat12H.Visible = (strPlayerStatName(12).Trim <> "")
            lablPlayerStat13H.Visible = (strPlayerStatName(13).Trim <> "")
            lablPlayerStat14H.Visible = (strPlayerStatName(14).Trim <> "")
            lablPlayerStat15H.Visible = (strPlayerStatName(15).Trim <> "")
            lablPlayerStat16H.Visible = (strPlayerStatName(16).Trim <> "")
            lablPlayerStat17H.Visible = (strPlayerStatName(17).Trim <> "")
            lablPlayerStat18H.Visible = (strPlayerStatName(18).Trim <> "")
            lablPlayerStat19H.Visible = (strPlayerStatName(19).Trim <> "")
            lablPlayerStat20H.Visible = (strPlayerStatName(20).Trim <> "")
            lablPlayerStat21H.Visible = (strPlayerStatName(21).Trim <> "")
            lablPlayerStat22H.Visible = (strPlayerStatName(22).Trim <> "")
            lablPlayerStat23H.Visible = (strPlayerStatName(23).Trim <> "")
            lablPlayerStat24H.Visible = (strPlayerStatName(24).Trim <> "")
            lablPlayerStat25H.Visible = (strPlayerStatName(25).Trim <> "")
            lablPlayerStat26H.Visible = (strPlayerStatName(26).Trim <> "")
            lablPlayerStat27H.Visible = (strPlayerStatName(27).Trim <> "")
            lablPlayerStat28H.Visible = (strPlayerStatName(28).Trim <> "")
            lablPlayerStat29H.Visible = (strPlayerStatName(29).Trim <> "")
            lablPlayerStat30H.Visible = (strPlayerStatName(30).Trim <> "")

            lablPlayerStat01A.Visible = (strPlayerStatName(1).Trim <> "")
            lablPlayerStat02A.Visible = (strPlayerStatName(2).Trim <> "")
            lablPlayerStat03A.Visible = (strPlayerStatName(3).Trim <> "")
            lablPlayerStat04A.Visible = (strPlayerStatName(4).Trim <> "")
            lablPlayerStat05A.Visible = (strPlayerStatName(5).Trim <> "")
            lablPlayerStat06A.Visible = (strPlayerStatName(6).Trim <> "")
            lablPlayerStat07A.Visible = (strPlayerStatName(7).Trim <> "")
            lablPlayerStat08A.Visible = (strPlayerStatName(8).Trim <> "")
            lablPlayerStat09A.Visible = (strPlayerStatName(9).Trim <> "")
            lablPlayerStat10A.Visible = (strPlayerStatName(10).Trim <> "")
            lablPlayerStat11A.Visible = (strPlayerStatName(11).Trim <> "")
            lablPlayerStat12A.Visible = (strPlayerStatName(12).Trim <> "")
            lablPlayerStat13A.Visible = (strPlayerStatName(13).Trim <> "")
            lablPlayerStat14A.Visible = (strPlayerStatName(14).Trim <> "")
            lablPlayerStat15A.Visible = (strPlayerStatName(15).Trim <> "")
            lablPlayerStat16A.Visible = (strPlayerStatName(16).Trim <> "")
            lablPlayerStat17A.Visible = (strPlayerStatName(17).Trim <> "")
            lablPlayerStat18A.Visible = (strPlayerStatName(18).Trim <> "")
            lablPlayerStat19A.Visible = (strPlayerStatName(19).Trim <> "")
            lablPlayerStat20A.Visible = (strPlayerStatName(20).Trim <> "")
            lablPlayerStat21A.Visible = (strPlayerStatName(21).Trim <> "")
            lablPlayerStat22A.Visible = (strPlayerStatName(22).Trim <> "")
            lablPlayerStat23A.Visible = (strPlayerStatName(23).Trim <> "")
            lablPlayerStat24A.Visible = (strPlayerStatName(24).Trim <> "")
            lablPlayerStat25A.Visible = (strPlayerStatName(25).Trim <> "")
            lablPlayerStat26A.Visible = (strPlayerStatName(26).Trim <> "")
            lablPlayerStat27A.Visible = (strPlayerStatName(27).Trim <> "")
            lablPlayerStat28A.Visible = (strPlayerStatName(28).Trim <> "")
            lablPlayerStat29A.Visible = (strPlayerStatName(29).Trim <> "")
            lablPlayerStat30A.Visible = (strPlayerStatName(30).Trim <> "")



            For inc = 1 To 30
                If strPlayerStatName(inc).Trim <> "" Then
                    Me.listViewSummaryHome.Columns(inc + 1).Text = strPlayerStatName(inc).Substring(0, 2)
                    Me.listViewsummaryAway.Columns(inc + 1).Text = strPlayerStatName(inc).Substring(0, 2)
                Else
                    Me.listViewSummaryHome.Columns(inc + 1).Text = ""
                    Me.listViewsummaryAway.Columns(inc + 1).Text = ""
                End If
                Dim penaltyButton As Button = FindPenaltyNameButton(inc)
                If strPenaltyName(inc) <> "" Then
                    penaltyButton.Text = strPenaltyName(inc)
                    penaltyButton.Visible = True
                Else
                    penaltyButton.Visible = False
                End If
            Next
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriod1.Click, btnPeriod2.Click, btnPeriod3.Click, btnPeriod4.Click, btnPeriod5.Click, btnPeriod6.Click, btnPeriod7.Click, btnPeriod8.Click, btnPeriod0.Click
        Dim iPeriod As Integer = sender.tag
        'send possession before setting period to ensure end of period data is sent correctly
        Select Case iPeriod
            Case 0
                InitClasses() 'clear all possessions
            Case 1
                'start 1st
                MatchClock(1).Reset()
                MatchClock(1).Run()
                MatchPossession(1).Reset()
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession("Start")
            Case 2
                'stop 1st
                MatchClock(1).Pause()
                MatchClock(2) = MatchClock(1)
                MatchPossession(1).Pause()
                SendPossession("Stop")    'end period
                MatchPossession(2) = MatchPossession(1)
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession()
            Case 3
                'start 2nd
                MatchClock(3).Reset()
                MatchClock(3).Run()
                MatchPossession(3).Reset()
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession("Start")
            Case 4
                'stop 2nd
                MatchClock(3).Pause()
                MatchClock(4) = MatchClock(3)
                MatchPossession(3).Pause()
                SendPossession("Stop")    'end period
                MatchPossession(4) = MatchPossession(3)
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession()
            Case 5
                'start ET1
                MatchClock(5).Reset()
                MatchClock(5).Run()
                MatchPossession(5).Reset()
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession("Start")
            Case 6
                'stop ET1
                MatchClock(5).Pause()
                MatchClock(6) = MatchClock(5)
                MatchPossession(5).Pause()
                SendPossession("Stop")    'end period
                MatchPossession(6) = MatchPossession(5)
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession()
            Case 7
                'start ET2
                MatchClock(7).Reset()
                MatchClock(7).Run()
                MatchPossession(7).Reset()
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession("Start")
            Case 8
                'stop ET2
                MatchClock(7).Pause()
                MatchClock(8) = MatchClock(7)
                MatchPossession(7).Pause()
                SendPossession("Stop")    'end period
                MatchPossession(8) = MatchPossession(7)
                LiveMatch.Period = iPeriod
                iCurrentPeriod = iPeriod
                SendPossession()
        End Select
        ShowDirection()
        bPeriodEnabled = False
        SetEnables()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        AddHandler formSetup.SendData, AddressOf Event_SendData
        formSetup.ShowDialog()
        RemoveHandler formSetup.SendData, AddressOf Event_SendData
        ShowMatch()
    End Sub
    Sub Event_SendData(ByVal strData As String)
        SendData(strData)

    End Sub

    Sub SendPossession(Optional ByVal strClockCommand As String = "")
        '        TeamLog|Possession|TimeStamp|MatchID|Period|Direction|MatchTime|Inplay|HomePossession^AwayPossession|Area1^Area2^Area3^Area4
        Try
            Dim strText As String = ""
            strText = "MATCHLOG|POSSESSION|" & Now.ToLongTimeString & "|" & LiveMatch.MatchID.ToString & "|" & LiveMatch.Period.ToString & "|" & LiveMatch.CurrentDirection.ToString & "|"
            strText += MatchClock(iCurrentPeriod).MatchClock & "|" & MatchPossession(iCurrentPeriod).InPlayText & "|"
            strText += MatchPossession(iCurrentPeriod).HomeText & "^" & MatchPossession(iCurrentPeriod).AwayText & "|"
            strText += MatchPossession(iCurrentPeriod).Area1Text & "^" & MatchPossession(iCurrentPeriod).Area2Text & "^" & MatchPossession(iCurrentPeriod).Area3Text & "^" & MatchPossession(iCurrentPeriod).Area4Text & "|"
            strText += MatchPossession(iCurrentPeriod).Home.TotalSeconds.ToString & "^" & MatchPossession(iCurrentPeriod).Away.TotalSeconds.ToString & "|"
            strText += Utils.TotalPossessionHomeText & "^" & Utils.TotalPossessionAwayText & "|" & strClockCommand & "|"
            SendData(strText)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in SendPossession")
        End Try
    End Sub
    Sub SendClock()
        Try
            Dim strText As String = ""
            strText = "MATCHLOG|MATCHTIME|"
            strText += MatchClock(iCurrentPeriod).TotalMatchClock & "|"
            SendData(strText)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in SendPossession")
        End Try
    End Sub
    Sub SendStat(ByVal iTeam As Integer, ByVal iStatNum As Integer, ByVal iValue As Integer)
        Dim strText As String = ""
        strText = "MATCHLOG|TEAMSTATS|" & Now.ToLongTimeString & "|" & LiveMatch.MatchID.ToString & "|"
        Select Case iTeam
            Case 1
                strText += LiveMatch.HomeTeamID.ToString & "|"
            Case 2
                strText += LiveMatch.AwayTeamID.ToString & "|"
        End Select
        Select Case iStatNum
            Case 0
                'resend
                strText += "|"
            Case Else
                strText += strTeamStatName(iStatNum)
                If iValue < 0 Then
                    strText += " removed|"
                Else
                    strText += "|"
                End If
        End Select
        Dim selectedStatNum As Integer = 0  'local or x-ref to RB stat index
        If Utils.IsRBTeamNamesValid Then
            're-order to match RB statnames.
            'ensures MatchPad stat updates + DB save are correct
            For incStat As Integer = 1 To 30
                Select Case iTeam
                    Case 1
                        strText += HomeTeamStatFromRBName(strRBTeamStatJSONName(incStat)) & "^"
                    Case 2
                        strText += AwayTeamStatFromRBName(strRBTeamStatJSONName(incStat)) & "^"
                End Select
            Next
            Dim thisStatName As String = strTeamStatJSONName(iStatNum)
            selectedStatNum = FindRBTeamStatfromJSONName(thisStatName)
        Else
            Select Case iTeam
                Case 1
                    strText += LiveMatch.Stat01H.ToString & "^"
                    strText += LiveMatch.Stat02H.ToString & "^"
                    strText += LiveMatch.Stat03H.ToString & "^"
                    strText += LiveMatch.Stat04H.ToString & "^"
                    strText += LiveMatch.Stat05H.ToString & "^"
                    strText += LiveMatch.Stat06H.ToString & "^"
                    strText += LiveMatch.Stat07H.ToString & "^"
                    strText += LiveMatch.Stat08H.ToString & "^"
                    strText += LiveMatch.Stat09H.ToString & "^"
                    strText += LiveMatch.Stat10H.ToString & "^"
                    strText += LiveMatch.Stat11H.ToString & "^"
                    strText += LiveMatch.Stat12H.ToString & "^"
                    strText += LiveMatch.Stat13H.ToString & "^"
                    strText += LiveMatch.Stat14H.ToString & "^"
                    strText += LiveMatch.Stat15H.ToString & "^"
                    strText += LiveMatch.Stat16H.ToString & "^"
                    strText += LiveMatch.Stat17H.ToString & "^"
                    strText += LiveMatch.Stat18H.ToString & "^"
                    strText += LiveMatch.Stat19H.ToString & "^"
                    strText += LiveMatch.Stat20H.ToString & "^"
                    strText += LiveMatch.Stat21H.ToString & "^"
                    strText += LiveMatch.Stat22H.ToString & "^"
                    strText += LiveMatch.Stat23H.ToString & "^"
                    strText += LiveMatch.Stat24H.ToString & "^"
                    strText += LiveMatch.Stat25H.ToString & "^"
                    strText += LiveMatch.Stat26H.ToString & "^"
                    strText += LiveMatch.Stat27H.ToString & "^"
                    strText += LiveMatch.Stat28H.ToString & "^"
                    strText += LiveMatch.Stat29H.ToString & "^"
                    strText += LiveMatch.Stat30H.ToString & "^"
                Case 2
                    strText += LiveMatch.Stat01A.ToString & "^"
                    strText += LiveMatch.Stat02A.ToString & "^"
                    strText += LiveMatch.Stat03A.ToString & "^"
                    strText += LiveMatch.Stat04A.ToString & "^"
                    strText += LiveMatch.Stat05A.ToString & "^"
                    strText += LiveMatch.Stat06A.ToString & "^"
                    strText += LiveMatch.Stat07A.ToString & "^"
                    strText += LiveMatch.Stat08A.ToString & "^"
                    strText += LiveMatch.Stat09A.ToString & "^"
                    strText += LiveMatch.Stat10A.ToString & "^"
                    strText += LiveMatch.Stat11A.ToString & "^"
                    strText += LiveMatch.Stat12A.ToString & "^"
                    strText += LiveMatch.Stat13A.ToString & "^"
                    strText += LiveMatch.Stat14A.ToString & "^"
                    strText += LiveMatch.Stat15A.ToString & "^"
                    strText += LiveMatch.Stat16A.ToString & "^"
                    strText += LiveMatch.Stat17A.ToString & "^"
                    strText += LiveMatch.Stat18A.ToString & "^"
                    strText += LiveMatch.Stat19A.ToString & "^"
                    strText += LiveMatch.Stat20A.ToString & "^"
                    strText += LiveMatch.Stat21A.ToString & "^"
                    strText += LiveMatch.Stat22A.ToString & "^"
                    strText += LiveMatch.Stat23A.ToString & "^"
                    strText += LiveMatch.Stat24A.ToString & "^"
                    strText += LiveMatch.Stat25A.ToString & "^"
                    strText += LiveMatch.Stat26A.ToString & "^"
                    strText += LiveMatch.Stat27A.ToString & "^"
                    strText += LiveMatch.Stat28A.ToString & "^"
                    strText += LiveMatch.Stat29A.ToString & "^"
                    strText += LiveMatch.Stat30A.ToString & "^"
            End Select
            selectedStatNum = iStatNum
        End If
        strText += "|"
        strText += iTeam.ToString & "|"
        strText += selectedStatNum.ToString & "|"
        'new 2019:
        If Utils.IsTeamJSONValid Then
            'only add if names exist to avoid confusing RB
            strText += JSONTeamStatsString() & "|"
        End If

        SendData(strText)
    End Sub
    Sub SendKickout(ByVal thisPitchKickout As clsPitchLocationLog)
        Dim strText As String = ""
        strText = "MATCHLOG|KICKOUT|" & Now.ToLongTimeString & "|" & iMatchID.ToString & "|" & thisPitchKickout.DataString & "|"
        'encode into 50 char text field
        SendData(strText)
    End Sub
    Sub Send4565(ByVal thisPitch4565 As clsPitchLocationLog)
        Dim strText As String = ""
        strText = "MATCHLOG|4565|" & Now.ToLongTimeString & "|" & iMatchID.ToString & "|" & thisPitch4565.DataString & "|"
        'encode into 50 char text field
        SendData(strText)
    End Sub
    Sub SendFree(ByVal thisPitchFree As clsPitchLocationLog)
        Dim strText As String = ""
        strText = "MATCHLOG|FREE|" & Now.ToLongTimeString & "|" & iMatchID.ToString & "|" & thisPitchFree.DataString & "|"
        'encode into 50 char text field
        SendData(strText)
    End Sub
    Sub SendPlayerStat(ByVal iTeam As Integer, ByVal iPlayer As Integer, ByVal iStatNum As Integer, ByVal iValue As Integer)
        Dim strText As String = ""
        strText = "MATCHLOG|PLAYERSTATS|" & Now.ToLongTimeString & "|" & LiveMatch.MatchID.ToString & "|"
        Select Case iTeam
            Case 1
                strText += LiveMatch.HomeTeamID.ToString & "|"
            Case 2
                strText += LiveMatch.AwayTeamID.ToString & "|"
        End Select
        strText += PlayerStat(iTeam, iPlayer).PlayerID.ToString & "|"
        Select Case iStatNum
            Case 0
                'resend
                strText += "|"
            Case Else
                strText += strPlayerStatName(iStatNum)
                If iValue < 0 Then
                    strText += " removed|"
                Else
                    strText += "|"
                End If
        End Select
        Dim selectedStatNum As Integer = 0  'local or x-ref to RB stat index
        If Utils.IsRBPlayerNamesValid Then
            're-order to match RB statnames.
            'ensures MatchPad stat updates + DB save are correct
            For incStat As Integer = 1 To 30
                strText += PlayerStatFromRBName(strRBPlayerStatJSONName(incStat), iTeam, iPlayer) & "^"
            Next
            strText += "|"
            Dim thisStatName As String = strPlayerStatJSONName(iStatNum)
            selectedStatNum = FindRBPlayerStatfromJSONName(thisStatName)
        Else
            strText += PlayerStat(iTeam, iPlayer).Stat01 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat02 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat03 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat04 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat05 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat06 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat07 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat08 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat09 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat10 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat11 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat12 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat13 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat14 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat15 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat16 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat17 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat18 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat19 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat20 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat21 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat22 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat23 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat24 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat25 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat26 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat27 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat28 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat29 & "^"
            strText += PlayerStat(iTeam, iPlayer).Stat30 & "^"
            strText += "|"
        End If
        strText += iTeam.ToString & "|"
        strText += iPlayer.ToString & "|"
        strText += iStatNum.ToString & "|"
        'new 2019:
        If Utils.IsPlayerJSONValid Then
            'only add if names exist to avoid confusing RB
            strText += JSONPlayerStatsString(iTeam, iPlayer) & "|"
        End If

        SendData(strText)
    End Sub

    Private Sub lablStat01H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablStat01H.Click, lablStat02H.Click, lablStat03H.Click, lablStat04H.Click, lablStat05H.Click, lablStat06H.Click, lablStat07H.Click, lablStat08H.Click, lablStat09H.Click, lablStat10H.Click, lablStat11H.Click, lablStat12H.Click, lablStat13H.Click, lablStat14H.Click, lablStat15H.Click, lablStat16H.Click, lablStat17H.Click, lablStat18H.Click, lablStat19H.Click, lablStat20H.Click, lablStat21H.Click, lablStat22H.Click, lablStat23H.Click, lablStat24H.Click, lablStat25H.Click, lablStat26H.Click, lablStat27H.Click, lablStat28H.Click, lablStat29H.Click, lablStat30H.Click
        Dim iStatNum As Integer = Val(sender.tag.substring(1, 2))
        Dim iValue As Integer
        Dim iTeam As Integer = 1
        iCurrentTeam = iTeam
        iCurrentTeamStat = iStatNum
        If bRemove = True Then
            iValue = -1
            bRemove = False
        Else
            iValue = 1
        End If
        LiveMatch.AssignStat(iTeam, iStatNum, iValue)
        SendStat(iTeam, iStatNum, iValue)
        ShowTeamStats()
        Utils.SerializeMatch(LiveMatch)

    End Sub
    Private Sub lablStat01A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablStat01A.Click, lablStat02A.Click, lablStat03A.Click, lablStat04A.Click, lablStat05A.Click, lablStat06A.Click, lablStat07A.Click, lablStat08A.Click, lablStat09A.Click, lablStat10A.Click, lablStat11A.Click, lablStat12A.Click, lablStat13A.Click, lablStat14A.Click, lablStat15A.Click, lablStat16A.Click, lablStat17A.Click, lablStat18A.Click, lablStat19A.Click, lablStat20A.Click, lablStat21A.Click, lablStat22A.Click, lablStat23A.Click, lablStat24A.Click, lablStat25A.Click, lablStat26A.Click, lablStat27A.Click, lablStat28A.Click, lablStat29A.Click, lablStat30A.Click
        Dim iStatNum As Integer = Val(sender.tag.substring(1, 2))
        Dim iValue As Integer
        Dim iTeam As Integer = 2
        iCurrentTeam = iTeam
        iCurrentTeamStat = iStatNum
        If bRemove = True Then
            iValue = -1
            bRemove = False
        Else
            iValue = 1
        End If
        LiveMatch.AssignStat(iTeam, iStatNum, iValue)
        SendStat(iTeam, iStatNum, iValue)
        ShowTeamStats()
        Utils.SerializeMatch(LiveMatch)
    End Sub
    Sub ShowPossession()
        Me.lablViewH.Text = MatchPossession(iCurrentPeriod).Home.TotalSeconds.ToString
        Me.lablViewA.Text = MatchPossession(iCurrentPeriod).Away.TotalSeconds.ToString
        Me.lablViewOOP.Text = MatchPossession(iCurrentPeriod).OOP.TotalSeconds.ToString

        Me.Label4.Text = MatchPossession(iCurrentPeriod).Area0.TotalSeconds.ToString
        Select Case Config.NumberOfAreas
            Case 4
                Me.lablViewR1.Text = MatchPossession(iCurrentPeriod).Area1.TotalSeconds.ToString
                Me.lablViewR2.Text = MatchPossession(iCurrentPeriod).Area2.TotalSeconds.ToString
                Me.lablViewR3.Text = MatchPossession(iCurrentPeriod).Area3.TotalSeconds.ToString
                Me.lablViewR4.Text = MatchPossession(iCurrentPeriod).Area4.TotalSeconds.ToString
                Me.lablAreaR1.Text = MatchPossession(iCurrentPeriod).Area1Text
                Me.lablAreaR2.Text = MatchPossession(iCurrentPeriod).Area2Text
                Me.lablAreaR3.Text = MatchPossession(iCurrentPeriod).Area3Text
                Me.lablAreaR4.Text = MatchPossession(iCurrentPeriod).Area4Text
                Me.lablAreaR1.BackColor = MatchPossession(iCurrentPeriod).Area1Colour
                Me.lablAreaR2.BackColor = MatchPossession(iCurrentPeriod).Area2Colour
                Me.lablAreaR3.BackColor = MatchPossession(iCurrentPeriod).Area3Colour
                Me.lablAreaR4.BackColor = MatchPossession(iCurrentPeriod).Area4Colour
            Case Else
                Me.lablViewS1.Text = MatchPossession(iCurrentPeriod).Area1.TotalSeconds.ToString
                Me.lablViewS2.Text = MatchPossession(iCurrentPeriod).Area2.TotalSeconds.ToString
                Me.lablViewS3.Text = MatchPossession(iCurrentPeriod).Area3.TotalSeconds.ToString
                Me.lablAreaS1.Text = MatchPossession(iCurrentPeriod).Area1Text
                Me.lablAreaS2.Text = MatchPossession(iCurrentPeriod).Area2Text
                Me.lablAreaS3.Text = MatchPossession(iCurrentPeriod).Area3Text
                Me.lablAreaS1.BackColor = MatchPossession(iCurrentPeriod).Area1Colour
                Me.lablAreaS2.BackColor = MatchPossession(iCurrentPeriod).Area2Colour
                Me.lablAreaS3.BackColor = MatchPossession(iCurrentPeriod).Area3Colour
        End Select


        Me.lablPossessionH.Text = MatchPossession(iCurrentPeriod).HomeText
        Me.lablPossessionA.Text = MatchPossession(iCurrentPeriod).AwayText

        Me.lablTotalPossH.Text = Utils.TotalPossessionHomeText
        Me.lablTotalPossA.Text = Utils.TotalPossessionAwayText


        Me.lablPossessionH.BackColor = MatchPossession(iCurrentPeriod).PossessionHColour
        Me.lablPossessionA.BackColor = MatchPossession(iCurrentPeriod).PossessionAColour

        Me.lablInPlay.Text = MatchPossession(iCurrentPeriod).InPlayText
    End Sub
    Delegate Sub ShowRemotePossessionCallback()
    Sub ShowRemotePossession()
        If lablRemoteMatchTime.InvokeRequired Then
            Dim d As New ShowRemotePossessionCallback(AddressOf ShowRemotePossession)
            Me.Invoke(d, New Object() {})
        Else
            Select Case Config.UserName
                Case "SKYSUPERLEAGUE", "PRO14"
                    lablRemoteHomePossessionSL.Text = RemoteData.HomePossession
                    lablRemoteAwayPossessionSL.Text = RemoteData.AwayPossession
                    Select Case RemoteData.CurrentPossessionTeam
                        Case 1
                            lablRemoteHomePossessionSL.BackColor = Color.LightGreen
                            lablRemoteAwayPossessionSL.BackColor = Color.White
                        Case 2
                            lablRemoteHomePossessionSL.BackColor = Color.White
                            lablRemoteAwayPossessionSL.BackColor = Color.LightGreen
                        Case Else
                            lablRemoteHomePossessionSL.BackColor = Color.White
                            lablRemoteAwayPossessionSL.BackColor = Color.White
                    End Select
                    lablMatchClockSL.Text = RemoteData.MatchClockTime
                    lablMatchClockSL.BackColor = If(RemoteData.MatchClockRunning, Color.LightGreen, Color.LightPink)
                    Select Case RemoteData.CurrentMatchPeriod
                        Case 1
                            lablPeriodSL.Text = "1st HALF"
                        Case 2
                            lablPeriodSL.Text = "2nd HALF"
                        Case 3
                            lablPeriodSL.Text = "ET 1st HALF"
                        Case 4
                            lablPeriodSL.Text = "ET 2nd HALF"
                        Case Else
                            lablPeriodSL.Text = "Pre Match"
                    End Select
                    lablHomeScoreSL.Text = RemoteData.HomeScore
                    lablAwayScoreSL.Text = RemoteData.AwayScore
                Case Else
                    Me.lablRemoteMatchTime.Text = RemoteData.PeriodTime
                    Me.lablRemoteInPlay.Text = RemoteData.PeriodInPlay

                    Me.lablRemoteHomeTeam.Text = LiveMatch.HomeShortName
                    Me.lablRemoteAwayTeam.Text = LiveMatch.AwayShortName

                    Me.lablRemoteHomePossession.Text = RemoteData.HomePossession
                    Me.lablRemoteAwayPossession.Text = RemoteData.AwayPossession

                    Select Case Config.NumberOfAreas
                        Case 4
                            Me.lablRemoteAreaR1.Text = RemoteData.Area1
                            Me.lablRemoteAreaR2.Text = RemoteData.Area2
                            Me.lablRemoteAreaR3.Text = RemoteData.Area3
                            Me.lablRemoteAreaR4.Text = RemoteData.Area4
                        Case Else
                            Me.lablRemoteAreaS1.Text = RemoteData.Area1
                            Me.lablRemoteAreaS2.Text = RemoteData.Area2
                            Me.lablRemoteAreaS3.Text = RemoteData.Area3
                    End Select
            End Select
        End If
    End Sub
    Delegate Sub ShowDirectionCallback()
    Sub ShowDirection()
        'all machines see kickout labels
        If lablArrowHomeLR.InvokeRequired Then
            Dim d As New ShowDirectionCallback(AddressOf ShowDirection)
            Me.Invoke(d, New Object() {})
        Else
            Select Case Config.UserName
                Case "SKYSUPERLEAGUE", "PRO14"
                    'tab removed
                Case Else
                    lablPitchLRTeamName.Text = LiveMatch.LRTeamName
                    lablPitchLRTeamName.Tag = LiveMatch.LRTeamID
                    lablPitchRLTeamName.Text = LiveMatch.RLTeamName
                    lablPitchRLTeamName.Tag = LiveMatch.RLTeamID
                    If Config.LogPossession = True Then
                        Me.lablArrowHomeLR.Visible = LiveMatch.HomeLR
                        Me.lablArrowHomeRL.Visible = LiveMatch.AwayLR
                        Me.lablArrowAwayLR.Visible = LiveMatch.AwayLR
                        Me.lablArrowAwayRL.Visible = LiveMatch.HomeLR
                    Else
                        'MessageBox.Show(LiveMatch.DisplayDirection.ToString)
                        Select Case RemoteData.CurrentDirection
                            Case 1
                                Me.lablArrowHomeLR.Visible = True
                                Me.lablArrowHomeRL.Visible = False
                                Me.lablArrowAwayLR.Visible = False
                                Me.lablArrowAwayRL.Visible = True
                            Case 2
                                Me.lablArrowHomeLR.Visible = False
                                Me.lablArrowHomeRL.Visible = True
                                Me.lablArrowAwayLR.Visible = True
                                Me.lablArrowAwayRL.Visible = False
                            Case Else
                                Me.lablArrowHomeLR.Visible = False
                                Me.lablArrowHomeRL.Visible = False
                                Me.lablArrowAwayLR.Visible = False
                                Me.lablArrowAwayRL.Visible = False
                        End Select
                    End If
            End Select

            Me.lablPeriod.Text = Utils.PeriodPhrase(LiveMatch.Period)
            'currentPitchKickoutTeamID = 0
            DrawAll() 'dependent on LR direction
        End If
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        bRemove = Not (bRemove)
        Me.lablRemove.Visible = bRemove
    End Sub

    Private Sub timerCheckClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCheckClock.Tick
        Me.lablMatchTime.Text = MatchClock(iCurrentPeriod).MatchClock
        Me.lablMatchTime2.Text = MatchClock(iCurrentPeriod).MatchClock
        Me.lablMatchTime.BackColor = MatchClock(iCurrentPeriod).Colour
        MatchPossession(iCurrentPeriod).CalcPossessions()
        MatchPossession(iCurrentPeriod).CalcAreas()
        Utils.CalcTotals(MatchPossession)  'totals
        ShowPossession()
        If MatchClock(iCurrentPeriod).Running = True Then
            Select Case MatchClock(iCurrentPeriod).MatchClock.Substring(3, 2)
                Case "00", "15", "30", "45"
                    SendPossession()
            End Select
            If Config.LogPossession Then
                SendClock()
            End If
        End If


    End Sub

    Private Sub btnClockNudgeUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClockNudgeUp.Click
        MatchClock(iCurrentPeriod).NudgeUp()
    End Sub

    Private Sub btnClockNudgeDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClockNudgeDown.Click
        MatchClock(iCurrentPeriod).NudgeDown()
    End Sub

    Private Sub btnPossessionH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPossessionH.Click, btnPossessionA.Click, btnPossessionOOP.Click, lablPossessionA.Click, lablPossessionH.Click
        Dim iTeam As Integer = sender.tag
        LogPossession(iTeam)
    End Sub
    Sub LogPossession(ByVal iTeam As Integer)
        Select Case Config.UserName
            Case "SKYSUPERLEAGUE"
                Dim lastPossession As Integer = 0
                Dim senderTag As Integer = iTeam
                'Use MatchPad syntax. RB calculates percentages.
                SendData("MATCHPAD|LOGPOSSESSION|" + LiveMatch.MatchID.ToString + "|" + senderTag.ToString + "|")
            Case Else
                Select Case LiveMatch.Period
                    Case 1, 3, 5, 7
                        MatchPossession(iCurrentPeriod).AllocatePossession()
                        MatchPossession(iCurrentPeriod).CurrentPossession = iTeam
                        If iTeam = 0 Then
                            'OOP, pause areas
                            'pause areas
                            MatchPossession(iCurrentPeriod).AllocateArea()
                            MatchPossession(iCurrentPeriod).CurrentArea = 0
                        End If
                        ShowPossession()
                    Case Else

                End Select
        End Select

    End Sub
    Private Sub BtnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAreaS1.Click, btnAreaS2.Click, btnAreaS3.Click, lablAreaS1.Click, lablAreaS2.Click, lablAreaS3.Click, btnAreaR1.Click, btnAreaR2.Click, btnAreaR3.Click, btnAreaR4.Click
        Dim iTeam As Integer = sender.tag
        LogArea(iTeam)
    End Sub
    Sub LogArea(ByVal iTeam As Integer)
        Select Case LiveMatch.Period
            Case 1, 3, 5, 7
                MatchPossession(iCurrentPeriod).AllocateArea()
                MatchPossession(iCurrentPeriod).CurrentArea = iTeam
                ShowPossession()
            Case Else
        End Select

    End Sub
    Private Sub btnPeriodEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodEnable.Click
        bPeriodEnabled = Not (bPeriodEnabled)
        SetEnables()
    End Sub

    Private Sub btnSwapDirection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSwapDirection.Click
        LiveMatch.HomeLtoRatKO = Not (LiveMatch.HomeLtoRatKO)
        ShowDirection()
        SendPossession()
        SaveLiveMatch()
    End Sub

    Private Sub btnPlayer01H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer01H.Click, btnPlayer02H.Click, btnPlayer03H.Click, btnPlayer04H.Click, btnPlayer05H.Click, btnPlayer06H.Click, btnPlayer07H.Click, btnPlayer08H.Click, btnPlayer09H.Click, btnPlayer10H.Click, btnPlayer11H.Click, btnPlayer12H.Click, btnPlayer13H.Click, btnPlayer14H.Click, btnPlayer15H.Click, btnPlayer16H.Click, btnPlayer17H.Click, btnPlayer18H.Click, btnPlayer19H.Click, btnPlayer20H.Click, btnPlayer21H.Click, btnPlayer22H.Click, btnPlayer23H.Click, btnPlayer24H.Click, btnPlayer25H.Click
        Dim iTag As Integer = sender.tag
        iCurrentPlayer = iTag
        iCurrentPlayerTeam = 1
        iCurrentPlayerStat = 0
        ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)

    End Sub
    Private Sub btnPlayer01A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayer01A.Click, btnPlayer02A.Click, btnPlayer03A.Click, btnPlayer04A.Click, btnPlayer05A.Click, btnPlayer06A.Click, btnPlayer07A.Click, btnPlayer08A.Click, btnPlayer09A.Click, btnPlayer10A.Click, btnPlayer11A.Click, btnPlayer12A.Click, btnPlayer13A.Click, btnPlayer14A.Click, btnPlayer15A.Click, btnPlayer16A.Click, btnPlayer17A.Click, btnPlayer18A.Click, btnPlayer19A.Click, btnPlayer20A.Click, btnPlayer21A.Click, btnPlayer22A.Click, btnPlayer23A.Click, btnPlayer24A.Click, btnPlayer25A.Click
        Dim iTag As Integer = sender.tag
        iCurrentPlayer = iTag
        iCurrentPlayerTeam = 2
        iCurrentPlayerStat = 0
        ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)

    End Sub

    Private Sub lablPlayerStat01H_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablPlayerStat01H.Click, lablPlayerStat02H.Click, lablPlayerStat03H.Click, lablPlayerStat04H.Click, lablPlayerStat05H.Click, lablPlayerStat06H.Click, lablPlayerStat07H.Click, lablPlayerStat08H.Click, lablPlayerStat09H.Click, lablPlayerStat10H.Click, lablPlayerStat11H.Click, lablPlayerStat12H.Click, lablPlayerStat13H.Click, lablPlayerStat14H.Click, lablPlayerStat15H.Click, lablPlayerStat16H.Click, lablPlayerStat17H.Click, lablPlayerStat18H.Click, lablPlayerStat19H.Click, lablPlayerStat20H.Click, lablPlayerStat21H.Click, lablPlayerStat22H.Click, lablPlayerStat23H.Click, lablPlayerStat24H.Click, lablPlayerStat25H.Click, lablPlayerStat26H.Click, lablPlayerStat27H.Click, lablPlayerStat28H.Click, lablPlayerStat29H.Click, lablPlayerStat30H.Click
        Dim iTag As Integer = sender.tag
        Dim iValue As Integer = 0, iStatNum As Integer = 0
        Dim iTeam As Integer = 1
        iStatNum = iTag
        iCurrentPlayerTeam = iTeam
        iCurrentPlayerStat = iStatNum
        If bRemove = True Then
            iValue = -1
            bRemove = False
        Else
            iValue = 1
        End If
        PlayerStat(iCurrentPlayerTeam, iCurrentPlayer).AssignStat(iStatNum, iValue)
        SendPlayerStat(iCurrentPlayerTeam, iCurrentPlayer, iStatNum, iValue)
        ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
        ShowPlayerSummaryStats(iCurrentPlayerTeam)
        'save data ##########
    End Sub
    Private Sub lablPlayerStat01A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablPlayerStat01A.Click, lablPlayerStat02A.Click, lablPlayerStat03A.Click, lablPlayerStat04A.Click, lablPlayerStat05A.Click, lablPlayerStat06A.Click, lablPlayerStat07A.Click, lablPlayerStat08A.Click, lablPlayerStat09A.Click, lablPlayerStat10A.Click, lablPlayerStat11A.Click, lablPlayerStat12A.Click, lablPlayerStat13A.Click, lablPlayerStat14A.Click, lablPlayerStat15A.Click, lablPlayerStat16A.Click, lablPlayerStat17A.Click, lablPlayerStat18A.Click, lablPlayerStat19A.Click, lablPlayerStat20A.Click, lablPlayerStat21A.Click, lablPlayerStat22A.Click, lablPlayerStat23A.Click, lablPlayerStat24A.Click, lablPlayerStat25A.Click, lablPlayerStat26A.Click, lablPlayerStat27A.Click, lablPlayerStat28A.Click, lablPlayerStat29A.Click, lablPlayerStat30A.Click
        Dim iTag As Integer = sender.tag
        Dim iValue As Integer = 0, iStatNum As Integer = 0
        Dim iTeam As Integer = 2
        iStatNum = iTag
        iCurrentPlayerTeam = iTeam
        iCurrentPlayerStat = iStatNum
        If bRemove = True Then
            iValue = -1
            bRemove = False
        Else
            iValue = 1
        End If
        PlayerStat(iCurrentPlayerTeam, iCurrentPlayer).AssignStat(iStatNum, iValue)
        SendPlayerStat(iCurrentPlayerTeam, iCurrentPlayer, iStatNum, iValue)
        ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
        ShowPlayerSummaryStats(iCurrentPlayerTeam)
        'save data ##########
    End Sub
    Sub ShowPlayerSummaryStats(ByVal iTeam As Integer)
        Dim inc As Integer
        Dim tempItem As New ListViewItem
        Try
            Select Case iTeam
                Case 1
                    Me.listViewSummaryHome.Items.Clear()
                Case 2
                    Me.listViewsummaryAway.Items.Clear()
            End Select
            For inc = 1 To 25
                tempItem = New ListViewItem
                tempItem.Text = inc.ToString
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).PlayerShortName)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat01.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat02.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat03.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat04.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat05.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat06.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat07.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat08.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat09.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat10.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat11.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat12.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat13.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat14.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat15.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat16.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat17.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat18.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat19.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat20.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat21.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat22.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat23.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat24.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat25.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat26.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat27.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat28.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat29.ToString)
                tempItem.SubItems.Add(PlayerStat(iTeam, inc).Stat30.ToString)
                Select Case iTeam
                    Case 1
                        Me.listViewSummaryHome.Items.Add(tempItem)
                    Case 2
                        Me.listViewsummaryAway.Items.Add(tempItem)
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in ShowPlayerSummaryStats")

        End Try
    End Sub
    Delegate Sub ShowPlayerNamesCallback(iTeam As Integer)
    Sub ShowPlayerNames(ByVal iTeam As Integer)
        If TabPage2.InvokeRequired Then
            Dim d As New ShowPlayerNamesCallback(AddressOf ShowPlayerNames)
            Me.Invoke(d, New Object() {iTeam})
        Else

            Dim inc As Integer, tempButton As Button
            Me.TabPage2.Text = LiveMatch.HomeShortName.ToUpper
            Me.TabPage3.Text = LiveMatch.AwayShortName.ToUpper
            Me.TabPage4.Text = "VIEW ALL " & LiveMatch.HomeShortName.ToUpper
            Me.TabPage5.Text = "VIEW ALL " & LiveMatch.AwayShortName.ToUpper
            For inc = 1 To 25
                tempButton = FindPlayerButtonByName(iTeam, inc)
                tempButton.Text = PlayerStat(iTeam, inc).ButtonText
            Next
        End If
    End Sub

    Private Sub listViewSummaryHome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listViewSummaryHome.SelectedIndexChanged
        If Me.listViewSummaryHome.SelectedIndices.Count = 1 Then
            iCurrentPlayer = Val(Me.listViewSummaryHome.SelectedItems(0).Text)
            iCurrentPlayerTeam = 1
            ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
            Me.TabControl1.SelectedIndex = 1
            Me.listViewSummaryHome.Items(Me.listViewSummaryHome.SelectedIndices(0)).Selected = False 'reset for next click
        End If
    End Sub

    Private Sub listViewsummaryAway_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listViewsummaryAway.SelectedIndexChanged
        If Me.listViewsummaryAway.SelectedIndices.Count = 1 Then
            iCurrentPlayer = Val(Me.listViewsummaryAway.SelectedItems(0).Text)
            iCurrentPlayerTeam = 2
            ShowPlayerStats(iCurrentPlayerTeam, iCurrentPlayer)
            Me.TabControl1.SelectedIndex = 2
            Me.listViewsummaryAway.Items(Me.listViewsummaryAway.SelectedIndices(0)).Selected = False 'reset for next click
        End If

    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        bFormLocked = Not (bFormLocked)
        If bFormLocked = True Then
            Me.Panel1.Top = 0
            Me.Panel1.Left = 0
            Me.Panel1.Height = 768
            Me.Panel1.Width = 1366
            Panel1.BringToFront()
        Else
            Me.Panel1.Top = 0
            Me.Panel1.Left = 0
            Me.Panel1.Height = 24
            Me.Panel1.Width = 16
        End If
    End Sub
    Sub ClearAllData()
        'action on receipt of MATCHDATA|CLEARALLDATA|MatchID message
        'Team
        'Players
        'Possessions
        Dim iTeam As Integer, iPlayer As Integer, inc As Integer
        For iTeam = 1 To 2
            For inc = 1 To 30
                LiveMatch.ZeroStat(iTeam, inc)
            Next
            For iPlayer = 0 To 25
                For inc = 0 To 30
                    PlayerStat(iTeam, iPlayer).ZeroStat(inc)
                Next
            Next
        Next
        For inc = 0 To MatchClock.GetUpperBound(0)
            MatchClock(inc) = New clsClock
        Next
        For inc = 0 To MatchPossession.GetUpperBound(0)
            MatchPossession(inc) = New clsPossession
        Next
        ShowPlayerStats(1, 1) 'refresh tab for each team
        ShowPlayerStats(2, 1)
        ShowPlayerSummaryStats(1)
        ShowPlayerSummaryStats(2)
        ShowTeamStats()

    End Sub


    Private Sub btnResendPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResendPlayerHome.Click, btnClearPlayerHome.Click, btnResendPlayerAway.Click, btnClearPlayerAway.Click
        Dim iTag As Integer = sender.tag
        Dim inc As Integer
        Select Case iTag
            Case 1
                Dim strText As String = PlayerStat(iCurrentPlayerTeam, iCurrentPlayer).PlayerLongName
                If MessageBox.Show("Confirm you want to clear all data for " & strText, "Clear Data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    For inc = 1 To 30
                        PlayerStat(iCurrentPlayerTeam, iCurrentPlayer).ZeroStat(inc)
                    Next
                End If
            Case Else
        End Select
        SendPlayerStat(iCurrentPlayerTeam, iCurrentPlayer, 0, 0)
    End Sub

    Private Sub timerCheckConnection_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCheckConnection.Tick
        If DateDiff(DateInterval.Minute, dtLastPAData, Now) > 0 Then
            If Config.AutoConectToSportServer = True Then
                ShowConnectionStatus(-1)
                ConnectToSportServer()
            Else
                'manual connect
                ShowConnectionStatus(0)
            End If
        End If
    End Sub


    Private Sub btnResendTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResendTeam.Click, btnClearAllTeam.Click
        Dim iTag As Integer = sender.tag
        Dim inc As Integer, iTeam As Integer
        Select Case iTag
            Case 1
                If MessageBox.Show("Confirm you want to clear all team data.", "Clear Data", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    For iTeam = 1 To 2
                        For inc = 1 To 30
                            LiveMatch.ZeroStat(iTeam, inc)
                        Next
                    Next
                End If
            Case Else
        End Select
        SendStat(1, 0, 0)
        SendStat(2, 0, 0)
    End Sub
    Delegate Sub ShowServerStatusCallback(ByVal iConnectionState As Integer)
    Sub ShowConnectionStatus(ByVal iConnectionState As Integer)
        If LablConnected.InvokeRequired Then
            Dim d As New ShowServerStatusCallback(AddressOf ShowConnectionStatus)
            Me.Invoke(d, New Object() {iConnectionState})
        Else
            Select Case iConnectionState
                Case -1
                    'error
                    Me.LablConnected.Text = "ERROR CONNECTING"
                    Me.LablConnected.BackColor = Color.Red
                    Me.LablConnected.ForeColor = Color.White
                    Me.LablConnected.Visible = True
                Case 1
                    'OK
                    Me.LablConnected.Text = "Connected to SportServer"
                    Me.LablConnected.BackColor = Color.Lime
                    Me.LablConnected.ForeColor = Color.Black
                    Me.LablConnected.Visible = True
                Case Else
                    'not used, disconnected
                    Me.LablConnected.Visible = False
            End Select

        End If
    End Sub

    'Sub ShowConnectionStatus(ByVal iConnectionState As Integer)
    '    Select Case iConnectionState
    '        Case -1
    '            'error
    '            Me.lablConnected.Text = "ERROR CONNECTING"
    '            Me.LablConnected.BackColor = Color.Red
    '            Me.LablConnected.ForeColor = Color.White
    '            Me.LablConnected.Visible = True
    '        Case 1
    '            'OK
    '            Me.LablConnected.Text = "Connected to SportServer"
    '            Me.LablConnected.BackColor = Color.Lime
    '            Me.LablConnected.ForeColor = Color.Black
    '            Me.LablConnected.Visible = True
    '        Case Else
    '            'not used, disconnected
    '            Me.LablConnected.Visible = False
    '    End Select

    'End Sub

    Private Sub picBoxPitch_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxPitch.MouseDown
        Console.WriteLine(e.X.ToString & ", " & e.Y.ToString)
        picBoxPitch.Tag = winningPitchKickoutTeamID
        winningPitchKickoutTeamID = 0 'reset so doesn't get used later if this mouse down does not get finished by a mouse up
    End Sub

    Private Sub picBoxPitch_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBoxPitch.MouseUp
        Dim winTeamID As Integer = Val(sender.tag)
        Static startX As Integer = 0
        Static startY As Integer = 0
        Select Case currentPitchLogType
            Case PitchLogType.Kickouts
                If winTeamID <> 0 Then
                    AddPitchKickout(e.X, e.Y, currentPitchKickoutTeamID, winTeamID)
                    DrawAll()
                    lablPitchKickoutPrompt.Text = "Kickout Won logged to " & LiveMatch.TeamNameFromID(winTeamID) & " from a " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Kickout"
                End If
            Case PitchLogType.FortyFive_SixtyFive
                If winTeamID <> 0 Then
                    'winteamid=currentteamid if successful, -1 if wide
                    Select Case clickStage
                        Case 1
                            startX = e.X
                            startY = e.Y
                            clickStage = 2
                            winningPitchKickoutTeamID = winTeamID 're-enable tag setting in Mouse Down

                            Select Case winTeamID
                                Case -3
                                    lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful Goal end point.  Click here to cancel"
                                Case -5
                                    lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful Score end point.  Click here to cancel"
                                Case -2
                                    lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful Score end point.  Click here to cancel"
                                Case -4
                                    lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful Goal end point.  Click here to cancel"
                                Case Else
                                    lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Wide end point.  Click here to cancel"
                            End Select
                        Case 2
                            AddPitch4565(startX, startY, e.X, e.Y, currentPitchKickoutTeamID, winTeamID)
                            DrawAll()
                            Select Case winTeamID
                                Case -3, -5
                                    lablPitchKickoutPrompt.Text = "Score from Play logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                                Case -2, -4
                                    lablPitchKickoutPrompt.Text = "Score from Free logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                                Case Else
                                    lablPitchKickoutPrompt.Text = "Wide logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                            End Select

                            ''winteamid=currentteamid if successful, -1 if wide
                            'AddPitchFree(startX, startY, e.X, e.Y, currentPitchKickoutTeamID, winTeamID)
                            'DrawAll()
                            'If winTeamID > 0 Then
                            '    lablPitchKickoutPrompt.Text = "Successful Free logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                            'Else
                            '    lablPitchKickoutPrompt.Text = "Wide Free logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                            'End If
                    End Select



                End If
            Case PitchLogType.Frees
                If winTeamID <> 0 Then
                    Select Case clickStage
                        Case 1
                            startX = e.X
                            startY = e.Y
                            clickStage = 2
                            winningPitchKickoutTeamID = winTeamID 're-enable tag setting in Mouse Down

                            If winTeamID > 0 Then
                                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful Free end point.  Click here to cancel"
                            Else
                                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Wide end point.  Click here to cancel"
                            End If
                        Case 2
                            'winteamid=currentteamid if successful, -1 if wide
                            AddPitchFree(startX, startY, e.X, e.Y, currentPitchKickoutTeamID, winTeamID)
                            DrawAll()
                            If winTeamID > 0 Then
                                lablPitchKickoutPrompt.Text = "Successful Free logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                            Else
                                lablPitchKickoutPrompt.Text = "Wide Free logged to " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID)
                            End If
                    End Select
                End If
        End Select
        sender.tag = 0   'clear

    End Sub
    Sub AddPitchKickout(ByVal x As Integer, ByVal y As Integer, ByVal kickerTeamID As Integer, ByVal winnerTeamID As Integer)
        Dim newPitchKickout As New clsPitchLocationLog
        Dim newCount As Integer = 0

        newPitchKickout.MatchID = LiveMatch.MatchID
        newPitchKickout.XLocation = x
        newPitchKickout.YLocation = y
        newPitchKickout.KickingTeamID = kickerTeamID
        newPitchKickout.WinningTeamID = winnerTeamID
        newPitchKickout.Direction = LiveMatch.TeamDirection(kickerTeamID)
        Dim currentCount As Integer = PitchKickouts.GetUpperBound(0)
        newCount = currentCount + 1
        ReDim Preserve PitchKickouts(newCount)
        PitchKickouts(newCount) = newPitchKickout
        SendKickout(newPitchKickout)
    End Sub
    Sub AddPitch4565Old(ByVal x As Integer, ByVal y As Integer, ByVal kickerTeamID As Integer, ByVal winnerTeamID As Integer)
        Dim newPitch4565 As New clsPitchLocationLog
        Dim newCount As Integer = 0

        newPitch4565.MatchID = LiveMatch.MatchID
        newPitch4565.XSource = x
        newPitch4565.YSource = y
        newPitch4565.KickingTeamID = kickerTeamID
        newPitch4565.WinningTeamID = winnerTeamID
        newPitch4565.Direction = LiveMatch.TeamDirection(kickerTeamID)
        Dim currentCount As Integer = Pitch4565.GetUpperBound(0)
        newCount = currentCount + 1
        ReDim Preserve Pitch4565(newCount)
        Pitch4565(newCount) = newPitch4565
        Send4565(newPitch4565)
    End Sub
    Sub AddPitchFree(ByVal xOrigin As Integer, ByVal yOrigin As Integer, ByVal x As Integer, ByVal y As Integer, ByVal kickerTeamID As Integer, ByVal winnerTeamID As Integer)
        Dim newPitchFree As New clsPitchLocationLog
        Dim newCount As Integer = 0

        newPitchFree.MatchID = LiveMatch.MatchID
        newPitchFree.XSource = xOrigin
        newPitchFree.YSource = yOrigin
        newPitchFree.XLocation = x
        newPitchFree.YLocation = y
        newPitchFree.KickingTeamID = kickerTeamID
        newPitchFree.WinningTeamID = winnerTeamID
        newPitchFree.Direction = LiveMatch.TeamDirection(kickerTeamID)
        Dim currentCount As Integer = PitchFrees.GetUpperBound(0)
        newCount = currentCount + 1
        ReDim Preserve PitchFrees(newCount)
        PitchFrees(newCount) = newPitchFree
        SendFree(newPitchFree)
    End Sub
    Sub AddPitch4565(ByVal xOrigin As Integer, ByVal yOrigin As Integer, ByVal x As Integer, ByVal y As Integer, ByVal kickerTeamID As Integer, ByVal winnerTeamID As Integer)
        Dim newPitch4565 As New clsPitchLocationLog
        Dim newCount As Integer = 0

        newPitch4565.MatchID = LiveMatch.MatchID
        newPitch4565.XSource = xOrigin
        newPitch4565.YSource = yOrigin
        newPitch4565.XLocation = x
        newPitch4565.YLocation = y
        newPitch4565.KickingTeamID = kickerTeamID
        newPitch4565.WinningTeamID = winnerTeamID
        newPitch4565.Direction = LiveMatch.TeamDirection(kickerTeamID)
        Dim currentCount As Integer = Pitch4565.GetUpperBound(0)
        newCount = currentCount + 1
        ReDim Preserve Pitch4565(newCount)
        Pitch4565(newCount) = newPitch4565
        Send4565(newPitch4565)
    End Sub
    Sub AddPitchFreeOld(ByVal x As Integer, ByVal y As Integer, ByVal kickerTeamID As Integer, ByVal winnerTeamID As Integer)
        Dim newPitchFree As New clsPitchLocationLog
        Dim newCount As Integer = 0

        newPitchFree.MatchID = LiveMatch.MatchID
        newPitchFree.XSource = x
        newPitchFree.YSource = y
        newPitchFree.KickingTeamID = kickerTeamID
        newPitchFree.WinningTeamID = winnerTeamID
        newPitchFree.Direction = LiveMatch.TeamDirection(kickerTeamID)
        Dim currentCount As Integer = PitchFrees.GetUpperBound(0)
        newCount = currentCount + 1
        ReDim Preserve PitchFrees(newCount)
        PitchFrees(newCount) = newPitchFree
        SendFree(newPitchFree)
    End Sub
    Sub DrawShotTo(ByVal g As Graphics, ByVal cKickout As clsPitchLocationLog)
        Try
            Dim thisRect As New RectangleF(cKickout.XDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, cKickout.YDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, 20, 20)
            Dim thisBrush As New SolidBrush(Color.Lime)
            If cKickout.KickingTeamID <> cKickout.WinningTeamID Then
                thisBrush.Color = Color.Red
            End If
            g.FillEllipse(thisBrush, thisRect)
            '            g.DrawLine(tempPen, cKickout.XSource, cKickout.YSource, cKickout.XLocation, cKickout.YLocation)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error in DrawShot")

        End Try
    End Sub
    Sub DrawShotFrom(ByVal g As Graphics, ByVal cKickout As clsPitchLocationLog)
        Try
            Dim thisRectS As New RectangleF(cKickout.XSourceDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, cKickout.YSourceDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, 20, 20)
            Dim thisBrush As New SolidBrush(Color.Lime)
            Dim thisPen As New Pen(Color.Lime, 2)
            Select Case cKickout.WinningTeamID
                Case -3, -5
                    'from play
                Case -2, -4
                    'from free
                    thisBrush.Color = Color.Yellow
                    thisPen.Color = Color.Yellow
                Case Else
                    If cKickout.KickingTeamID <> cKickout.WinningTeamID Then
                        thisBrush.Color = Color.Red
                        thisPen.Color = Color.Red
                    End If
            End Select
            g.FillEllipse(thisBrush, thisRectS)
            Dim xSource As Integer = cKickout.XSourceDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID))
            Dim ySource As Integer = cKickout.YSourceDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID))
            Dim xDest As Integer = cKickout.XDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID))
            Dim yDest As Integer = cKickout.YDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID))
            If (xDest + yDest) > 0 Then
                If (xDest + yDest) < 840 + 536 Then
                    g.DrawLine(thisPen, xSource, ySource, xDest, yDest)
                End If
            End If


            'Dim thisRectD As New RectangleF(cKickout.XDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, cKickout.YDisplay(LiveMatch.TeamDirection(cKickout.KickingTeamID)) - 10, 20, 20)
            'Dim thisBrushD As New SolidBrush(Color.Lime)
            'If cKickout.KickingTeamID <> cKickout.WinningTeamID Then
            '    thisBrushD.Color = Color.Red
            'End If
            'g.FillEllipse(thisBrushD, thisRectD)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DrawAll()
        ' Create a Graphics object for the Control.
        Try
            btnPitchHomeWin.Enabled = True
            btnPitchAwayWin.Enabled = True
            btnPitchShotGood.Enabled = True
            btnPitchShotGood2.Enabled = True
            btnPitchShotGood3.Enabled = True
            btnPitchShotGood4.Enabled = True
            btnPitchShotWide.Enabled = True
            btnPitchShotWide2.Enabled = True
            If currentPitchKickoutTeamID = lablPitchLRTeamName.Tag Then
                lablPitchLRTeamName.BackColor = Color.White
                lablPitchLRArrow.BackColor = Color.White
                lablPitchRLTeamName.BackColor = Color.ForestGreen
                lablPitchRLArrow.BackColor = Color.ForestGreen
            ElseIf currentPitchKickoutTeamID = lablPitchRLTeamName.Tag Then
                lablPitchRLTeamName.BackColor = Color.White
                lablPitchRLArrow.BackColor = Color.White
                lablPitchLRTeamName.BackColor = Color.ForestGreen
                lablPitchLRArrow.BackColor = Color.ForestGreen
            Else
                lablPitchLRTeamName.BackColor = Color.ForestGreen
                lablPitchLRArrow.BackColor = Color.ForestGreen
                lablPitchRLTeamName.BackColor = Color.ForestGreen
                lablPitchRLArrow.BackColor = Color.ForestGreen
                'btnPitchHomeWin.Enabled = False
                'btnPitchAwayWin.Enabled = False
                'btnPitchShotGood.Enabled = False
                'btnPitchShotGood2.Enabled = False
                'btnPitchShotGood3.Enabled = False
                'btnPitchShotGood4.Enabled = False
                'btnPitchShotWide.Enabled = False
                'btnPitchShotWide2.Enabled = False
            End If
            Select Case currentPitchLogType
                Case PitchLogType.Kickouts
                    ShowPitchKickoutTotals()
                Case PitchLogType.Frees
                    ShowPitchFreeTotals()
                Case PitchLogType.FortyFive_SixtyFive
                    ShowPitch4565Totals()
            End Select
            btnDeleteKickout.Visible = False
            Dim g As Graphics = Me.picBoxPitch.CreateGraphics()
            picBoxPitch.Refresh()
            g.SmoothingMode = SmoothingMode.AntiAlias
            RedrawData(g)
            ' Clean up the Graphics object.
            g.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Sub ShowPitchKickoutTotals()
        Dim HomeWon As Integer = 0   'Kick/Win
        Dim HomeLost As Integer = 0
        Dim AwayWon As Integer = 0
        Dim AwayLost As Integer = 0

        For inc As Integer = 1 To PitchKickouts.GetUpperBound(0)
            Select Case PitchKickouts(inc).KickingTeamID
                Case LiveMatch.HomeTeamID
                    Select Case PitchKickouts(inc).WinningTeamID
                        Case LiveMatch.HomeTeamID
                            HomeWon += 1
                            AwayLost += 1
                        Case LiveMatch.AwayTeamID
                            AwayWon += 1
                            HomeLost += 1
                        Case Else
                    End Select
                Case LiveMatch.AwayTeamID
                    Select Case PitchKickouts(inc).WinningTeamID
                        Case LiveMatch.HomeTeamID
                            HomeWon += 1
                            AwayLost += 1
                        Case LiveMatch.AwayTeamID
                            AwayWon += 1
                            HomeLost += 1
                        Case Else
                    End Select
                Case Else
            End Select
        Next
        lablPitchHome2.Text = HomeLost.ToString
        lablPitchHome1.Text = HomeWon.ToString
        lablPitchAway2.Text = AwayLost.ToString
        lablPitchAway1.Text = AwayWon.ToString
    End Sub
    Sub ShowPitchFreeTotals()
        Dim HomeGood As Integer = 0   'Successful
        Dim HomeWide As Integer = 0  'wide
        Dim AwayGood As Integer = 0
        Dim AwayWide As Integer = 0

        For inc As Integer = 1 To PitchFrees.GetUpperBound(0)
            Select Case PitchFrees(inc).KickingTeamID
                Case LiveMatch.HomeTeamID
                    Select Case PitchFrees(inc).WinningTeamID
                        Case LiveMatch.HomeTeamID
                            HomeGood += 1
                        Case Else
                            HomeWide += 1
                    End Select
                Case LiveMatch.AwayTeamID
                    Select Case PitchFrees(inc).WinningTeamID
                        Case LiveMatch.AwayTeamID
                            AwayGood += 1
                        Case Else
                            AwayWide += 1
                    End Select
                Case Else
            End Select
        Next
        lablPitchHome2.Text = HomeWide.ToString
        lablPitchHome1.Text = HomeGood.ToString
        lablPitchAway2.Text = AwayWide.ToString
        lablPitchAway1.Text = AwayGood.ToString
    End Sub
    Sub ShowPitch4565Totals()
        Dim HomeGood As Integer = 0   'Successful
        Dim HomeGood2 As Integer = 0   'Successful
        Dim HomeWide As Integer = 0  'wide
        Dim AwayGood As Integer = 0
        Dim AwayGood2 As Integer = 0
        Dim AwayWide As Integer = 0

        For inc As Integer = 1 To Pitch4565.GetUpperBound(0)
            Select Case Pitch4565(inc).KickingTeamID
                Case LiveMatch.HomeTeamID
                    Select Case Pitch4565(inc).WinningTeamID
                        Case -3, -5
                            HomeGood += 1
                        Case -2, -4
                            HomeGood2 += 1
                        Case Else
                            HomeWide += 1
                    End Select
                Case LiveMatch.AwayTeamID
                    Select Case Pitch4565(inc).WinningTeamID
                        Case -3, -5
                            AwayGood += 1
                        Case -2, -4
                            AwayGood2 += 1
                        Case Else
                            AwayWide += 1
                    End Select
                Case Else
            End Select
        Next
        lablPitchHome1.Text = HomeGood.ToString
        lablPitchHome2.Text = HomeGood2.ToString
        lablPitchHome3.Text = HomeWide.ToString
        lablPitchAway1.Text = AwayGood.ToString
        lablPitchAway2.Text = AwayGood2.ToString
        lablPitchAway3.Text = AwayWide.ToString
    End Sub
    Sub RedrawData(ByVal g As Graphics)
        Try
            'DrawPitch(g)
            Select Case currentPitchLogType
                Case PitchLogType.Kickouts
                    For inc As Integer = 1 To PitchKickouts.GetUpperBound(0)
                        If PitchKickouts(inc).KickingTeamID = currentPitchKickoutTeamID Then
                            DrawShotTo(g, PitchKickouts(inc))
                        End If
                    Next
                Case PitchLogType.Frees
                    For inc As Integer = 1 To PitchFrees.GetUpperBound(0)
                        If PitchFrees(inc).KickingTeamID = currentPitchKickoutTeamID Then
                            DrawShotFrom(g, PitchFrees(inc))
                        End If
                    Next
                Case PitchLogType.FortyFive_SixtyFive
                    For inc As Integer = 1 To Pitch4565.GetUpperBound(0)
                        If Pitch4565(inc).KickingTeamID = currentPitchKickoutTeamID Then
                            DrawShotFrom(g, Pitch4565(inc))
                        End If
                    Next
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPitchHomeWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchHomeWin.Click
        winningPitchKickoutTeamID = LiveMatch.HomeTeamID
        lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.HomeLongName & " Kickout Won from a " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Kickout.  Click here to cancel"

    End Sub
    Private Sub btnPitchAwayWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchAwayWin.Click
        winningPitchKickoutTeamID = LiveMatch.AwayTeamID
        lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.AwayLongName & " Kickout Won from a " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Kickout.  Click here to cancel"
    End Sub
    Private Sub btnPitchShotGood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchShotGood.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                '   action = "45/65"
                'goal from free
                winningPitchKickoutTeamID = -2    'type of action
                action = " Goal From Free"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Goal from Free .  Click here to cancel"
            Case Else
                winningPitchKickoutTeamID = currentPitchKickoutTeamID    'successful flag
                action = "Free"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " successful " & action & ".  Click here to cancel"
        End Select
    End Sub
    Private Sub btnPitchShotGood2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchShotGood2.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                'goal from play
                winningPitchKickoutTeamID = -3    'successful flag
                action = " Goal From Play"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Goal from Play .  Click here to cancel"
            Case Else
        End Select


    End Sub
    Private Sub btnPitchShotGood3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchShotGood3.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                'point from play
                winningPitchKickoutTeamID = -4    'successful flag
                action = " Point From Free"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Point from Free .  Click here to cancel"
            Case Else
        End Select
    End Sub

    Private Sub btnPitchShotGood4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchShotGood4.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                'point from play
                winningPitchKickoutTeamID = -5    'successful flag
                action = " Point From Play"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " Point from Play .  Click here to cancel"
            Case Else
        End Select
    End Sub
    Private Sub btnPitchShotWide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchShotWide.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                '                action = "45/65"
                winningPitchKickoutTeamID = -7
                action = "Wide from Play"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " wide from Play .  Click here to cancel"
            Case Else
                winningPitchKickoutTeamID = -1 'wide flag
                action = "Free"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " wide " & action & ".  Click here to cancel"
        End Select

    End Sub
    Private Sub btnPitchShotWide2_Click(sender As Object, e As EventArgs) Handles btnPitchShotWide2.Click
        Dim action As String = ""
        Select Case currentPitchLogType
            Case PitchLogType.FortyFive_SixtyFive
                '                action = "45/65"
                winningPitchKickoutTeamID = -6
                action = "Wide from Free"
                clickStage = 1
                lablPitchKickoutPrompt.Text = "Click on pitch to mark " & LiveMatch.TeamNameFromID(currentPitchKickoutTeamID) & " wide from Free .  Click here to cancel"
            Case Else
        End Select
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadDummyKickouts()

    End Sub


    Private Sub lablPitchLRTeamName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablPitchLRTeamName.Click, lablPitchLRArrow.Click
        currentPitchKickoutTeamID = lablPitchLRTeamName.Tag
        ShowPitchLogLabels()
        btnStepKickouts.Enabled = True
        kickoutStepNum = 0
        DrawAll()
    End Sub

    Private Sub lablPitchRLTeamName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablPitchRLTeamName.Click, lablPitchRLArrow.Click
        currentPitchKickoutTeamID = lablPitchRLTeamName.Tag
        ShowPitchLogLabels()
        btnStepKickouts.Enabled = True
        kickoutStepNum = 0
        DrawAll()
    End Sub

    Private Sub lablPitchKickoutPrompt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lablPitchKickoutPrompt.Click
        winningPitchKickoutTeamID = 0
        lablPitchKickoutPrompt.Text = "Pitch marking cancelled"

    End Sub

    Private Sub TabControl1_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedTab.Name
            Case "tabKickouts"
                Select Case currentPitchLogType
                    Case PitchLogType.Kickouts
                        SendData("REQUESTKICKOUTS|" & LiveMatch.MatchID.ToString & "|")
                    Case PitchLogType.Frees
                        SendData("REQUESTFREES|" & LiveMatch.MatchID.ToString & "|")
                    Case PitchLogType.FortyFive_SixtyFive
                        SendData("REQUEST4565S|" & LiveMatch.MatchID.ToString & "|")
                End Select
                DrawAll()
        End Select
    End Sub

    Private Sub btnStepKickouts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepKickouts.Click
        'initial test for no entries
        Select Case currentPitchLogType
            Case PitchLogType.Kickouts
                If PitchKickouts.GetUpperBound(0) = 0 Then
                    btnStepKickouts.Enabled = False
                    lablStepKickoutNum.Text = ""
                    Exit Sub
                End If
                Dim foundKO As Boolean = False
                Dim failCount As Integer = 0
                Do
                    kickoutStepNum += 1
                    If kickoutStepNum > PitchKickouts.GetUpperBound(0) Then
                        'reset to start
                        kickoutStepNum = 1
                    End If
                    If PitchKickouts(kickoutStepNum).KickingTeamID = currentPitchKickoutTeamID Then
                        lablStepKickoutNum.Text = kickoutStepNum.ToString
                        Dim g As Graphics = Me.picBoxPitch.CreateGraphics()
                        picBoxPitch.Refresh()
                        g.SmoothingMode = SmoothingMode.AntiAlias
                        DrawShotTo(g, PitchKickouts(kickoutStepNum))
                        ' Clean up the Graphics object.
                        g.Dispose()
                        foundKO = True
                        btnDeleteKickout.Visible = True
                    Else
                        failCount += 1
                        If failCount > 50 Then
                            btnStepKickouts.Enabled = False
                            btnDeleteKickout.Visible = False
                            lablStepKickoutNum.Text = ""
                            Exit Do
                        End If
                    End If
                Loop Until foundKO
            Case PitchLogType.Frees
                If PitchFrees.GetUpperBound(0) = 0 Then
                    btnStepKickouts.Enabled = False
                    lablStepKickoutNum.Text = ""
                    Exit Sub
                End If
                Dim foundKO As Boolean = False
                Dim failCount As Integer = 0
                Do
                    kickoutStepNum += 1
                    If kickoutStepNum > PitchFrees.GetUpperBound(0) Then
                        'reset to start
                        kickoutStepNum = 1
                    End If
                    If PitchFrees(kickoutStepNum).KickingTeamID = currentPitchKickoutTeamID Then
                        lablStepKickoutNum.Text = kickoutStepNum.ToString
                        Dim g As Graphics = Me.picBoxPitch.CreateGraphics()
                        picBoxPitch.Refresh()
                        g.SmoothingMode = SmoothingMode.AntiAlias
                        DrawShotFrom(g, PitchFrees(kickoutStepNum))
                        ' Clean up the Graphics object.
                        g.Dispose()
                        foundKO = True
                        btnDeleteKickout.Visible = True
                    Else
                        failCount += 1
                        If failCount > 50 Then
                            btnStepKickouts.Enabled = False
                            btnDeleteKickout.Visible = False
                            lablStepKickoutNum.Text = ""
                            Exit Do
                        End If
                    End If
                Loop Until foundKO
            Case PitchLogType.FortyFive_SixtyFive
                If Pitch4565.GetUpperBound(0) = 0 Then
                    btnStepKickouts.Enabled = False
                    lablStepKickoutNum.Text = ""
                    Exit Sub
                End If
                Dim foundKO As Boolean = False
                Dim failCount As Integer = 0
                Do
                    kickoutStepNum += 1
                    If kickoutStepNum > Pitch4565.GetUpperBound(0) Then
                        'reset to start
                        kickoutStepNum = 1
                    End If
                    If Pitch4565(kickoutStepNum).KickingTeamID = currentPitchKickoutTeamID Then
                        lablStepKickoutNum.Text = kickoutStepNum.ToString
                        Dim g As Graphics = Me.picBoxPitch.CreateGraphics()
                        picBoxPitch.Refresh()
                        g.SmoothingMode = SmoothingMode.AntiAlias
                        DrawShotFrom(g, Pitch4565(kickoutStepNum))
                        ' Clean up the Graphics object.
                        g.Dispose()
                        foundKO = True
                        btnDeleteKickout.Visible = True
                    Else
                        failCount += 1
                        If failCount > 50 Then
                            btnStepKickouts.Enabled = False
                            btnDeleteKickout.Visible = False
                            lablStepKickoutNum.Text = ""
                            Exit Do
                        End If
                    End If
                Loop Until foundKO
        End Select
    End Sub

    Private Sub btnDeleteKickout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteKickout.Click
        Select Case currentPitchLogType
            Case PitchLogType.Kickouts
                If MessageBox.Show("Confirm you want to delete this Kickout", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    SendData("DELETEKICKOUT|" & LiveMatch.MatchID.ToString & "|" & PitchKickouts(kickoutStepNum).DataString & "|")
                End If
            Case PitchLogType.Frees
                If MessageBox.Show("Confirm you want to delete this Free", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    SendData("DELETEFREE|" & LiveMatch.MatchID.ToString & "|" & PitchFrees(kickoutStepNum).DataString & "|")
                End If
            Case PitchLogType.FortyFive_SixtyFive
                If MessageBox.Show("Confirm you want to delete this Shot Log", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    SendData("DELETE4565|" & LiveMatch.MatchID.ToString & "|" & Pitch4565(kickoutStepNum).DataString & "|")
                End If
        End Select
    End Sub

    Private Sub radioLogKickouts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioLogKickouts.CheckedChanged, radioLog4565.CheckedChanged, radioLogFrees.CheckedChanged
        SetCurrentPitchLogType()
    End Sub
    Sub SetCurrentPitchLogType()
        Dim oldPitchLogType As PitchLogType
        oldPitchLogType = currentPitchLogType

        If radioLog4565.Checked Then
            currentPitchLogType = PitchLogType.FortyFive_SixtyFive  'reused for scoring
        ElseIf radioLogFrees.Checked Then
            currentPitchLogType = PitchLogType.Frees
        Else
            currentPitchLogType = PitchLogType.Kickouts
        End If
        ShowPitchLogLabels()


        If oldPitchLogType <> currentPitchLogType Then
            'avoid double hit
            Select Case currentPitchLogType
                Case PitchLogType.Kickouts
                    SendData("REQUESTKICKOUTS|" & LiveMatch.MatchID.ToString & "|")
                Case PitchLogType.Frees
                    SendData("REQUESTFREES|" & LiveMatch.MatchID.ToString & "|")
                Case PitchLogType.FortyFive_SixtyFive
                    SendData("REQUEST4565S|" & LiveMatch.MatchID.ToString & "|")
            End Select
        End If

    End Sub

    Private Sub btnPenaltyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenaltyName01.Click, btnPenaltyName02.Click, btnPenaltyName03.Click, btnPenaltyName04.Click, btnPenaltyName05.Click, btnPenaltyName06.Click, btnPenaltyName07.Click, btnPenaltyName08.Click, btnPenaltyName09.Click, btnPenaltyName10.Click, btnPenaltyName11.Click, btnPenaltyName12.Click, btnPenaltyName13.Click, btnPenaltyName14.Click, btnPenaltyName15.Click, btnPenaltyName16.Click, btnPenaltyName17.Click, btnPenaltyName18.Click, btnPenaltyName19.Click, btnPenaltyName20.Click, btnPenaltyName21.Click, btnPenaltyName22.Click, btnPenaltyName23.Click, btnPenaltyName24.Click, btnPenaltyName25.Click, btnPenaltyName26.Click, btnPenaltyName27.Click, btnPenaltyName28.Click, btnPenaltyName29.Click, btnPenaltyName30.Click
        lablSelectedPenalty.Text = sender.TEXT
        btnPenaltyDisplay.Text = LiveMatch.HomeShortName + vbLf + "Penalty"
        btnPenaltyDisplay2.Text = LiveMatch.AwayShortName + vbLf + "Penalty"
        btnPenaltyDisplay.Tag = sender.TEXT
        btnPenaltyDisplay.Enabled = True
        btnPenaltyDisplay2.Tag = sender.TEXT
        btnPenaltyDisplay2.Enabled = True
    End Sub

    Private Sub btnPenaltyDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenaltyDisplay.Click
        SendData("MATCHLOG|PENALTYTEXT|" & btnPenaltyDisplay.Tag & "|1|")
    End Sub
    Private Sub btnPenaltyDisplay2_Click(sender As Object, e As EventArgs) Handles btnPenaltyDisplay2.Click
        SendData("MATCHLOG|PENALTYTEXT|" & btnPenaltyDisplay.Tag & "|2|")
    End Sub

    Private Sub btnPenaltyClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenaltyClear.Click
        SendData("MATCHLOG|PENALTYTEXT||")
    End Sub

    Private Sub btnAdvantageHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvantageHome.Click
        SendData("MATCHLOG|TRIGGER|ADVANTAGEHOME|")
    End Sub

    Private Sub btnAdvantageAway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvantageAway.Click
        SendData("MATCHLOG|TRIGGER|ADVANTAGEAWAY|")
    End Sub

    Private Sub btnAdvantageClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvantageClear.Click
        SendData("MATCHLOG|TRIGGER|ADVANTAGECLEAR|")
    End Sub

    Private Sub btnLogGoal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogGoal.Click

    End Sub

    Private Sub btnLogYC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogYC.Click

    End Sub
    Private Function FindPlayerByShirt(teamIndex As Integer, shirt As Integer) As Integer
        For inc As Integer = 1 To PlayerStat.GetUpperBound(1)
            If PlayerStat(teamIndex, inc).PlayerNum = shirt Then
                Return inc
            End If
        Next
        Return 0
    End Function
    Private Function FindJSONPlayer(thisTeamIndex As Integer, thisPlayerIndex As Integer) As clsJSONPlayer
        For Each JSONPlayer As clsJSONPlayer In JSONPlayerStats.playerList
            Dim teamIndex As Integer = Val(JSONPlayer.t)
            Dim shirt As Integer = Val(JSONPlayer.s)
            Dim playerIndex As Integer = FindPlayerByShirt(teamIndex, shirt)
            If ((thisTeamIndex = teamIndex) And (thisPlayerIndex = playerIndex)) Then
                Return JSONPlayer
            End If
        Next
        Return New clsJSONPlayer
    End Function
    Private Sub AssignLocalPlayerStatsToJSON(teamIndex As Integer, playerIndex As Integer)
        Dim thisJSONPlayer As clsJSONPlayer = FindJSONPlayer(teamIndex, playerIndex)
        For Each JSONStat As clsJSONPlayerStat In thisJSONPlayer.statList
            Dim localIndex As Integer = FindPlayerStatfromJSONName(JSONStat.n)
            Select Case localIndex
                Case 1
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat01
                Case 2
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat02
                Case 3
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat03
                Case 4
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat04
                Case 5
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat05
                Case 6
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat06
                Case 7
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat07
                Case 8
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat08
                Case 9
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat09
                Case 10
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat10
                Case 11
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat11
                Case 12
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat12
                Case 13
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat13
                Case 14
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat14
                Case 15
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat15
                Case 16
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat16
                Case 17
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat17
                Case 18
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat18
                Case 19
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat19
                Case 20
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat20
                Case 21
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat21
                Case 22
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat22
                Case 23
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat23
                Case 24
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat24
                Case 25
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat25
                Case 26
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat26
                Case 27
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat27
                Case 28
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat28
                Case 29
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat29
                Case 30
                    JSONStat.v = PlayerStat(teamIndex, playerIndex).Stat30
            End Select
        Next
    End Sub
    Function HomeTeamStatFromRBName(thisStatName As String) As String
        Dim localIndex As Integer = FindTeamStatfromJSONName(thisStatName)
        Select Case localIndex
            Case 1
                Return LiveMatch.Stat01H.ToString
            Case 2
                Return LiveMatch.Stat02H.ToString
            Case 3
                Return LiveMatch.Stat03H.ToString
            Case 4
                Return LiveMatch.Stat04H.ToString
            Case 5
                Return LiveMatch.Stat05H.ToString
            Case 6
                Return LiveMatch.Stat06H.ToString
            Case 7
                Return LiveMatch.Stat07H.ToString
            Case 8
                Return LiveMatch.Stat08H.ToString
            Case 9
                Return LiveMatch.Stat09H.ToString
            Case 10
                Return LiveMatch.Stat10H.ToString
            Case 11
                Return LiveMatch.Stat11H.ToString
            Case 12
                Return LiveMatch.Stat12H.ToString
            Case 13
                Return LiveMatch.Stat13H.ToString
            Case 14
                Return LiveMatch.Stat14H.ToString
            Case 15
                Return LiveMatch.Stat15H.ToString
            Case 16
                Return LiveMatch.Stat16H.ToString
            Case 17
                Return LiveMatch.Stat17H.ToString
            Case 18
                Return LiveMatch.Stat18H.ToString
            Case 19
                Return LiveMatch.Stat19H.ToString
            Case 20
                Return LiveMatch.Stat20H.ToString
            Case 21
                Return LiveMatch.Stat21H.ToString
            Case 22
                Return LiveMatch.Stat22H.ToString
            Case 23
                Return LiveMatch.Stat23H.ToString
            Case 24
                Return LiveMatch.Stat24H.ToString
            Case 25
                Return LiveMatch.Stat25H.ToString
            Case 26
                Return LiveMatch.Stat26H.ToString
            Case 27
                Return LiveMatch.Stat27H.ToString
            Case 28
                Return LiveMatch.Stat28H.ToString
            Case 29
                Return LiveMatch.Stat29H.ToString
            Case 30
                Return LiveMatch.Stat30H.ToString
            Case Else
                'not found
                Return ""
        End Select
    End Function
    Function AwayTeamStatFromRBName(thisStatName As String) As String
        Dim localIndex As Integer = FindTeamStatfromJSONName(thisStatName)
        Select Case localIndex
            Case 1
                Return LiveMatch.Stat01A.ToString
            Case 2
                Return LiveMatch.Stat02A.ToString
            Case 3
                Return LiveMatch.Stat03A.ToString
            Case 4
                Return LiveMatch.Stat04A.ToString
            Case 5
                Return LiveMatch.Stat05A.ToString
            Case 6
                Return LiveMatch.Stat06A.ToString
            Case 7
                Return LiveMatch.Stat07A.ToString
            Case 8
                Return LiveMatch.Stat08A.ToString
            Case 9
                Return LiveMatch.Stat09A.ToString
            Case 10
                Return LiveMatch.Stat10A.ToString
            Case 11
                Return LiveMatch.Stat11A.ToString
            Case 12
                Return LiveMatch.Stat12A.ToString
            Case 13
                Return LiveMatch.Stat13A.ToString
            Case 14
                Return LiveMatch.Stat14A.ToString
            Case 15
                Return LiveMatch.Stat15A.ToString
            Case 16
                Return LiveMatch.Stat16A.ToString
            Case 17
                Return LiveMatch.Stat17A.ToString
            Case 18
                Return LiveMatch.Stat18A.ToString
            Case 19
                Return LiveMatch.Stat19A.ToString
            Case 20
                Return LiveMatch.Stat20A.ToString
            Case 21
                Return LiveMatch.Stat21A.ToString
            Case 22
                Return LiveMatch.Stat22A.ToString
            Case 23
                Return LiveMatch.Stat23A.ToString
            Case 24
                Return LiveMatch.Stat24A.ToString
            Case 25
                Return LiveMatch.Stat25A.ToString
            Case 26
                Return LiveMatch.Stat26A.ToString
            Case 27
                Return LiveMatch.Stat27A.ToString
            Case 28
                Return LiveMatch.Stat28A.ToString
            Case 29
                Return LiveMatch.Stat29A.ToString
            Case 30
                Return LiveMatch.Stat30A.ToString
            Case Else
                'not found
                Return ""
        End Select
    End Function
    Function PlayerStatFromRBName(thisStatName As String, teamIndex As Integer, playerIndex As Integer) As String
        Dim localIndex As Integer = FindPlayerStatfromJSONName(thisStatName)
        Select Case localIndex
            Case 1
                Return PlayerStat(teamIndex, playerIndex).Stat01
            Case 2
                Return PlayerStat(teamIndex, playerIndex).Stat02
            Case 3
                Return PlayerStat(teamIndex, playerIndex).Stat03
            Case 4
                Return PlayerStat(teamIndex, playerIndex).Stat04
            Case 5
                Return PlayerStat(teamIndex, playerIndex).Stat05
            Case 6
                Return PlayerStat(teamIndex, playerIndex).Stat06
            Case 7
                Return PlayerStat(teamIndex, playerIndex).Stat07
            Case 8
                Return PlayerStat(teamIndex, playerIndex).Stat08
            Case 9
                Return PlayerStat(teamIndex, playerIndex).Stat09
            Case 10
                Return PlayerStat(teamIndex, playerIndex).Stat10
            Case 11
                Return PlayerStat(teamIndex, playerIndex).Stat11
            Case 12
                Return PlayerStat(teamIndex, playerIndex).Stat12
            Case 13
                Return PlayerStat(teamIndex, playerIndex).Stat13
            Case 14
                Return PlayerStat(teamIndex, playerIndex).Stat14
            Case 15
                Return PlayerStat(teamIndex, playerIndex).Stat15
            Case 16
                Return PlayerStat(teamIndex, playerIndex).Stat16
            Case 17
                Return PlayerStat(teamIndex, playerIndex).Stat17
            Case 18
                Return PlayerStat(teamIndex, playerIndex).Stat18
            Case 19
                Return PlayerStat(teamIndex, playerIndex).Stat19
            Case 20
                Return PlayerStat(teamIndex, playerIndex).Stat20
            Case 21
                Return PlayerStat(teamIndex, playerIndex).Stat21
            Case 22
                Return PlayerStat(teamIndex, playerIndex).Stat22
            Case 23
                Return PlayerStat(teamIndex, playerIndex).Stat23
            Case 24
                Return PlayerStat(teamIndex, playerIndex).Stat24
            Case 25
                Return PlayerStat(teamIndex, playerIndex).Stat25
            Case 26
                Return PlayerStat(teamIndex, playerIndex).Stat26
            Case 27
                Return PlayerStat(teamIndex, playerIndex).Stat27
            Case 28
                Return PlayerStat(teamIndex, playerIndex).Stat28
            Case 29
                Return PlayerStat(teamIndex, playerIndex).Stat29
            Case 30
                Return PlayerStat(teamIndex, playerIndex).Stat30
            Case Else
                'not found
                Return ""
        End Select
    End Function

    Private Sub AssignLocalTeamStatsToJSON()
        For Each JSONStat As clsJSONTeamStat In JSONTeamStats.statList
            Dim localIndex As Integer = FindTeamStatfromJSONName(JSONStat.n)
            Select Case localIndex
                Case 1
                    JSONStat.h = LiveMatch.Stat01H.ToString
                    JSONStat.a = LiveMatch.Stat01A.ToString
                Case 2
                    JSONStat.h = LiveMatch.Stat02H.ToString
                    JSONStat.a = LiveMatch.Stat02A.ToString
                Case 3
                    JSONStat.h = LiveMatch.Stat03H.ToString
                    JSONStat.a = LiveMatch.Stat03A.ToString
                Case 4
                    JSONStat.h = LiveMatch.Stat04H.ToString
                    JSONStat.a = LiveMatch.Stat04A.ToString
                Case 5
                    JSONStat.h = LiveMatch.Stat05H.ToString
                    JSONStat.a = LiveMatch.Stat05A.ToString
                Case 6
                    JSONStat.h = LiveMatch.Stat06H.ToString
                    JSONStat.a = LiveMatch.Stat06A.ToString
                Case 7
                    JSONStat.h = LiveMatch.Stat07H.ToString
                    JSONStat.a = LiveMatch.Stat07A.ToString
                Case 8
                    JSONStat.h = LiveMatch.Stat08H.ToString
                    JSONStat.a = LiveMatch.Stat08A.ToString
                Case 9
                    JSONStat.h = LiveMatch.Stat09H.ToString
                    JSONStat.a = LiveMatch.Stat09A.ToString
                Case 10
                    JSONStat.h = LiveMatch.Stat10H.ToString
                    JSONStat.a = LiveMatch.Stat10A.ToString
                Case 11
                    JSONStat.h = LiveMatch.Stat11H.ToString
                    JSONStat.a = LiveMatch.Stat11A.ToString
                Case 12
                    JSONStat.h = LiveMatch.Stat12H.ToString
                    JSONStat.a = LiveMatch.Stat12A.ToString
                Case 13
                    JSONStat.h = LiveMatch.Stat13H.ToString
                    JSONStat.a = LiveMatch.Stat13A.ToString
                Case 14
                    JSONStat.h = LiveMatch.Stat14H.ToString
                    JSONStat.a = LiveMatch.Stat14A.ToString
                Case 15
                    JSONStat.h = LiveMatch.Stat15H.ToString
                    JSONStat.a = LiveMatch.Stat15A.ToString
                Case 16
                    JSONStat.h = LiveMatch.Stat16H.ToString
                    JSONStat.a = LiveMatch.Stat16A.ToString
                Case 17
                    JSONStat.h = LiveMatch.Stat17H.ToString
                    JSONStat.a = LiveMatch.Stat17A.ToString
                Case 18
                    JSONStat.h = LiveMatch.Stat18H.ToString
                    JSONStat.a = LiveMatch.Stat18A.ToString
                Case 19
                    JSONStat.h = LiveMatch.Stat19H.ToString
                    JSONStat.a = LiveMatch.Stat19A.ToString
                Case 20
                    JSONStat.h = LiveMatch.Stat20H.ToString
                    JSONStat.a = LiveMatch.Stat20A.ToString
                Case 21
                    JSONStat.h = LiveMatch.Stat21H.ToString
                    JSONStat.a = LiveMatch.Stat21A.ToString
                Case 22
                    JSONStat.h = LiveMatch.Stat22H.ToString
                    JSONStat.a = LiveMatch.Stat22A.ToString
                Case 23
                    JSONStat.h = LiveMatch.Stat23H.ToString
                    JSONStat.a = LiveMatch.Stat23A.ToString
                Case 24
                    JSONStat.h = LiveMatch.Stat24H.ToString
                    JSONStat.a = LiveMatch.Stat24A.ToString
                Case 25
                    JSONStat.h = LiveMatch.Stat25H.ToString
                    JSONStat.a = LiveMatch.Stat25A.ToString
                Case 26
                    JSONStat.h = LiveMatch.Stat26H.ToString
                    JSONStat.a = LiveMatch.Stat26A.ToString
                Case 27
                    JSONStat.h = LiveMatch.Stat27H.ToString
                    JSONStat.a = LiveMatch.Stat27A.ToString
                Case 28
                    JSONStat.h = LiveMatch.Stat28H.ToString
                    JSONStat.a = LiveMatch.Stat28A.ToString
                Case 29
                    JSONStat.h = LiveMatch.Stat29H.ToString
                    JSONStat.a = LiveMatch.Stat29A.ToString
                Case 30
                    JSONStat.h = LiveMatch.Stat30H.ToString
                    JSONStat.a = LiveMatch.Stat30A.ToString
                Case Else
                    'not found
                    JSONStat.h = ""
                    JSONStat.a = ""
            End Select
        Next
    End Sub
    Private Function FindTeamStatfromJSONName(JSONName As String) As Integer
        For inc As Integer = 1 To strTeamStatJSONName.GetUpperBound(0)
            If strTeamStatJSONName(inc).ToLower = JSONName Then
                Return inc
            End If
        Next
        Return 0
    End Function
    Private Function FindPlayerStatfromJSONName(JSONName As String) As Integer
        For inc As Integer = 1 To strPlayerStatJSONName.GetUpperBound(0)
            If strPlayerStatJSONName(inc).ToLower = JSONName Then
                Return inc
            End If
        Next
        Return 0
    End Function
    Private Function FindRBTeamStatfromJSONName(JSONName As String) As Integer
        For inc As Integer = 1 To strRBTeamStatJSONName.GetUpperBound(0)
            If strRBTeamStatJSONName(inc).ToLower = JSONName Then
                Return inc
            End If
        Next
        Return 0
    End Function
    Private Function FindRBPlayerStatfromJSONName(JSONName As String) As Integer
        For inc As Integer = 1 To strRBPlayerStatJSONName.GetUpperBound(0)
            If strRBPlayerStatJSONName(inc).ToLower = JSONName Then
                Return inc
            End If
        Next
        Return 0
    End Function
    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        MessageBox.Show(JSONPlayerStatsString(1, 1))
    End Sub
    Private Function JSONTeamStatsString() As String
        AssignLocalTeamStatsToJSON()
        Dim jsonSerializer As New JavaScriptSerializer
        Return jsonSerializer.Serialize(JSONTeamStats)
    End Function

    Private Function JSONPlayerStatsString(teamIndex As Integer, playerIndex As Integer) As String
        AssignLocalPlayerStatsToJSON(teamIndex, playerIndex)
        Dim tempJSONPlayer As clsJSONPlayer = FindJSONPlayer(teamIndex, playerIndex)
        Dim jsonSerializer As New JavaScriptSerializer
        Return jsonSerializer.Serialize(tempJSONPlayer)
    End Function
    Sub AssignRBOptaStatnames(dataString As String)
        'MATCHDATA|LIVESTATNAMES|PLAYER...|TEAM...|TRIGGERS...|PLAYEROPTA^possessions^turnovers_won^unforced_errors^assists^^shots^goals^points^interceptions^frees_conceded^kick_passes^hand_passes^tackles^kickouts_won^carries_into_contact^^^^marks^^^goals_from_penalties^points_from_penalties^goals_from_frees^points_from_frees^goals_from_45^points_from_45^goals_from_sideline^points_from_sideline^|TEAMOPTA^kickouts^^^marks^^^^inside_45^possessions^shots^scores^goals^wides^yellow_cards^red_cards^black_cards^^^^^^frees_won^frees_conceded^^^blocks^^scores_from_dead_ball^points_from_frees^^turnovers_won^^^^own_kickouts_won^scoring_chances_from_play^scores_from_play^^scoring_chances_from_placed_ball^scores_from_placed_ball^goals^points|
        If dataString.Contains("|") Then
            Dim splitText() As String = dataString.Split("|")
            If splitText.GetUpperBound(0) > 5 Then
                If splitText(5).Contains("^") Then
                    Dim playerSplit() As String = splitText(5).Split("^")
                    For inc As Integer = 1 To playerSplit.GetUpperBound(0)
                        If inc <= strRBPlayerStatJSONName.GetUpperBound(0) Then
                            strRBPlayerStatJSONName(inc) = playerSplit(inc)
                        End If
                    Next
                End If
                If splitText(6).Contains("^") Then
                    Dim teamSplit() As String = splitText(6).Split("^")
                    For inc As Integer = 1 To teamSplit.GetUpperBound(0)
                        If inc <= strRBTeamStatJSONName.GetUpperBound(0) Then
                            strRBTeamStatJSONName(inc) = teamSplit(inc)
                        End If
                    Next
                End If
                If Config.UseRBStatNames Then
                    If splitText(2).Contains("^") Then
                        Dim playerSplit() As String = splitText(2).Split("^")
                        For inc As Integer = 1 To playerSplit.GetUpperBound(0)
                            If inc <= strPlayerStatName.GetUpperBound(0) Then
                                strPlayerStatName(inc) = playerSplit(inc)
                            End If
                        Next
                    End If
                    If splitText(3).Contains("^") Then
                        Dim teamSplit() As String = splitText(3).Split("^")
                        For inc As Integer = 1 To teamSplit.GetUpperBound(0)
                            If inc <= strTeamStatName.GetUpperBound(0) Then
                                strTeamStatName(inc) = teamSplit(inc)
                            End If
                        Next
                    End If
                    ShowHeadings()
                End If
            End If
        End If
    End Sub

    Private Sub btnFetchStatNames_Click(sender As Object, e As EventArgs) Handles btnFetchStatNames.Click
        SendData("MATCHLOG|REQUESTLIVESTATNAMES|")
    End Sub

    Private Sub btnPossessionHSL_Click(sender As Object, e As EventArgs) Handles btnPossessionHSL.Click, btnPossessionASL.Click, btnPossessionOOPSL.Click
        Dim lastPossession As Integer = 0
        Dim senderTag As Integer = Val(sender.tag)
        'Use MatchPad syntax. RB calculates percentages.
        SendData("MATCHPAD|LOGPOSSESSION|" + LiveMatch.MatchID.ToString + "|" + senderTag.ToString + "|")
    End Sub

    Private Sub btnClearSLPossession_Click(sender As Object, e As EventArgs) Handles btnClearSLPossession.Click
        If MessageBox.Show("This will reset calculated Possession data." & vbLf & "Are you sure you want to continue?", "Reset Possession", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            SendData("MATCHPAD|LOGPOSSESSION|" + LiveMatch.MatchID.ToString + "|-1|")
        End If
    End Sub

    Private Sub btnFetchRBStats_Click(sender As Object, e As EventArgs) Handles btnFetchRBStats.Click
        FetchAllLiveStats()
    End Sub
    Sub FetchAllLiveStats()
        SendData("MATCHPAD|REQUESTTEAMSTATS|" + LiveMatch.MatchID.ToString + "|")
        Threading.Thread.Sleep(100)
        SendData("MATCHPAD|REQUESTPLAYERSTATS|" + LiveMatch.MatchID.ToString + "|" + LiveMatch.HomeTeamID.ToString + "|")
        Threading.Thread.Sleep(100)
        SendData("MATCHPAD|REQUESTPLAYERSTATS|" + LiveMatch.MatchID.ToString + "|" + LiveMatch.AwayTeamID.ToString + "|")
    End Sub
    Private Sub listViewCarriesHome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCarriesHome.SelectedIndexChanged
        If listViewCarriesHome.SelectedIndices.Count = 1 Then
            'valid
            Dim matchID As String = LiveMatch.MatchID.ToString
            Dim teamID As String = LiveMatch.HomeTeamID.ToString
            Dim playerID As String = listViewCarriesHome.SelectedItems(0).Text
            Dim playerShirt As String = listViewCarriesHome.SelectedItems(0).SubItems(1).Text
            Dim playerName As String = listViewCarriesHome.SelectedItems(0).SubItems(2).Text
            'MATCHDATA|CURRENTPLAYER|26538|462|6560|Name|number||
            SendData("MATCHPAD|CURRENTPLAYER|" + matchID + "|" + teamID + "|" + playerID + "|" + playerName + "|" + playerShirt + "||")
        End If
    End Sub

    Private Sub listViewCarriesAway_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewCarriesAway.SelectedIndexChanged
        If listViewCarriesAway.SelectedIndices.Count = 1 Then
            'valid
            Dim matchID As String = LiveMatch.MatchID.ToString
            Dim teamID As String = LiveMatch.AwayTeamID.ToString
            Dim playerID As String = listViewCarriesAway.SelectedItems(0).Text
            Dim playerShirt As String = listViewCarriesAway.SelectedItems(0).SubItems(1).Text
            Dim playerName As String = listViewCarriesAway.SelectedItems(0).SubItems(2).Text
            'MATCHDATA|CURRENTPLAYER|26538|462|6560|Name|number||
            SendData("MATCHPAD|CURRENTPLAYER|" + matchID + "|" + teamID + "|" + playerID + "|" + playerName + "|" + playerShirt + "||")
        End If
    End Sub

    Private Sub btnFetchLiveMatch_Click(sender As Object, e As EventArgs) Handles btnFetchLiveMatch.Click
        SendData("MATCHPAD|REQUESTLIVEMATCHDETAILS|")
    End Sub
End Class
