VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form frmMain 
   BorderStyle     =   1  'Fest Einfach
   Caption         =   "Mouse Recorder (C)2002 by CodeXP"
   ClientHeight    =   3345
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6165
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3345
   ScaleWidth      =   6165
   StartUpPosition =   3  'Windows-Standard
   Begin VB.Timer tControl 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   5625
      Top             =   90
   End
   Begin VB.PictureBox pFrame 
      Appearance      =   0  '2D
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   480
      Left            =   75
      ScaleHeight     =   450
      ScaleWidth      =   5985
      TabIndex        =   0
      Top             =   60
      Width           =   6015
      Begin VB.PictureBox pMCursor 
         Appearance      =   0  '2D
         AutoRedraw      =   -1  'True
         BackColor       =   &H80000005&
         BorderStyle     =   0  'Kein
         ForeColor       =   &H80000008&
         Height          =   390
         Left            =   120
         Picture         =   "frmMain.frx":0000
         ScaleHeight     =   390
         ScaleWidth      =   270
         TabIndex        =   1
         Top             =   60
         Width           =   270
      End
      Begin VB.Label lState 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "[PLAYING]"
         BeginProperty Font 
            Name            =   "Small Fonts"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   330
         Left            =   4005
         TabIndex        =   3
         Top             =   45
         Visible         =   0   'False
         Width           =   1410
      End
      Begin VB.Label lAppName 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "MOUSE  RECORDER"
         BeginProperty Font 
            Name            =   "Small Fonts"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   330
         Left            =   435
         TabIndex        =   2
         Top             =   45
         Width           =   2760
      End
   End
   Begin VB.Frame fFrame 
      Height          =   2205
      Left            =   75
      TabIndex        =   5
      Top             =   525
      Width           =   6030
      Begin VB.CommandButton cmdLoadFile 
         Caption         =   "Load from File ..."
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   330
         Left            =   2100
         TabIndex        =   27
         Top             =   1785
         Width           =   1785
      End
      Begin VB.CheckBox cRecMiddleClick 
         Caption         =   "Middle Click"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   180
         TabIndex        =   24
         Top             =   1485
         Value           =   1  'Aktiviert
         Width           =   1125
      End
      Begin VB.PictureBox pStop 
         AutoSize        =   -1  'True
         Height          =   375
         Left            =   5010
         Picture         =   "frmMain.frx":0152
         ScaleHeight     =   315
         ScaleWidth      =   1605
         TabIndex        =   23
         Top             =   525
         Visible         =   0   'False
         Width           =   1665
      End
      Begin VB.CommandButton cmdExit 
         Height          =   375
         Left            =   4170
         Picture         =   "frmMain.frx":1C28
         Style           =   1  'Grafisch
         TabIndex        =   22
         Top             =   1665
         Width           =   1575
      End
      Begin VB.CommandButton cmdHide 
         Height          =   375
         Left            =   4170
         Picture         =   "frmMain.frx":36FE
         Style           =   1  'Grafisch
         TabIndex        =   21
         Top             =   1200
         Width           =   1575
      End
      Begin VB.CommandButton cmdPlay 
         Height          =   375
         Left            =   4170
         Picture         =   "frmMain.frx":51D4
         Style           =   1  'Grafisch
         TabIndex        =   20
         Top             =   735
         Width           =   1575
      End
      Begin VB.CommandButton cmdRec 
         Height          =   375
         Left            =   4170
         Picture         =   "frmMain.frx":6CAA
         Style           =   1  'Grafisch
         TabIndex        =   19
         Top             =   270
         Width           =   1575
      End
      Begin VB.CheckBox cWndAutoShow 
         Caption         =   "Auto Show"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   2175
         TabIndex        =   18
         Top             =   945
         Value           =   1  'Aktiviert
         Width           =   1125
      End
      Begin VB.CheckBox cWndAutoHide 
         Caption         =   "Auto Hide"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   2175
         TabIndex        =   17
         Top             =   675
         Width           =   1005
      End
      Begin VB.CommandButton cSetFile 
         BackColor       =   &H00E0E0E0&
         Caption         =   "Save as File ..."
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   2100
         Style           =   1  'Grafisch
         TabIndex        =   15
         Top             =   1440
         Width           =   1785
      End
      Begin VB.CheckBox cRecLeftClick 
         Caption         =   "Left Click"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   180
         TabIndex        =   10
         Top             =   1215
         Value           =   1  'Aktiviert
         Width           =   1005
      End
      Begin VB.CheckBox cRecRightClick 
         Caption         =   "Right Click"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   180
         TabIndex        =   9
         Top             =   945
         Value           =   1  'Aktiviert
         Width           =   1125
      End
      Begin VB.CheckBox cRecMovement 
         Caption         =   "Mouse Movement"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Left            =   180
         TabIndex        =   7
         Top             =   675
         Value           =   1  'Aktiviert
         Width           =   1620
      End
      Begin VB.PictureBox pRec 
         AutoSize        =   -1  'True
         Height          =   375
         Left            =   3945
         Picture         =   "frmMain.frx":8780
         ScaleHeight     =   315
         ScaleWidth      =   1605
         TabIndex        =   25
         Top             =   225
         Visible         =   0   'False
         Width           =   1665
      End
      Begin VB.PictureBox pPlay 
         AutoSize        =   -1  'True
         Height          =   375
         Left            =   3945
         Picture         =   "frmMain.frx":A256
         ScaleHeight     =   315
         ScaleWidth      =   1605
         TabIndex        =   26
         Top             =   675
         Visible         =   0   'False
         Width           =   1665
      End
      Begin VB.Label lOptCaption 
         AutoSize        =   -1  'True
         Caption         =   "Window:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Index           =   2
         Left            =   2100
         TabIndex        =   16
         Top             =   390
         Width           =   735
      End
      Begin VB.Label lOptCaption 
         AutoSize        =   -1  'True
         Caption         =   "Save to File:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Index           =   1
         Left            =   2070
         TabIndex        =   13
         Top             =   1200
         Width           =   1005
      End
      Begin VB.Label lOptCaption 
         AutoSize        =   -1  'True
         Caption         =   "Recording:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   400
            Underline       =   -1  'True
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Index           =   0
         Left            =   150
         TabIndex        =   8
         Top             =   390
         Width           =   870
      End
      Begin VB.Label lOptions 
         AutoSize        =   -1  'True
         BackColor       =   &H80000010&
         Caption         =   "   RECORDER Options   "
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   225
         Left            =   0
         TabIndex        =   6
         Top             =   90
         Width           =   2145
      End
   End
   Begin MSComDlg.CommonDialog comDlg 
      Left            =   5550
      Top             =   2760
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      Filter          =   "Mouse Motion File (*.mot)|*.mot|All files (*.*)|*.*"
   End
   Begin VB.Label lInfo 
      AutoSize        =   -1  'True
      Caption         =   "If you want to Hide this Window or to Show this again press [F12] Key."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   2
      Left            =   165
      TabIndex        =   14
      Top             =   3135
      Width           =   5115
   End
   Begin VB.Label lInfo 
      AutoSize        =   -1  'True
      Caption         =   "press [F9] Key and to stop Recording or Playback press [Pause] Key."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   1
      Left            =   165
      TabIndex        =   12
      Top             =   2940
      Width           =   4965
   End
   Begin VB.Label lInfo 
      AutoSize        =   -1  'True
      Caption         =   "To start Recording you can press [F10] Key everywhere. For Playback"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   0
      Left            =   165
      TabIndex        =   11
      Top             =   2745
      Width           =   5070
   End
   Begin VB.Label lMousePos 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "888, 888"
      BeginProperty Font 
         Name            =   "Small Fonts"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00808080&
      Height          =   165
      Left            =   5550
      TabIndex        =   4
      Top             =   2970
      Width           =   510
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdExit_Click()
  Unload Me
End Sub

Private Sub cmdHide_Click()
  Me.Visible = False
End Sub

Private Sub cmdLoadFile_Click()
  Dim FName As String
  comDlg.ShowOpen
  FName = comDlg.FileName
  If Len(FName) Then
    LoadDataFromFile FName
  End If
End Sub

Private Sub cmdPlay_Click()
  StartPlaying
End Sub

Private Sub cmdRec_Click()
  SaveDataToFile
  StartRecording
End Sub

Private Sub cSetFile_Click()
  SaveDataToFile
End Sub

Private Sub Form_Load()
  Me.Top = Screen.Height - Me.Height * 1.3
  Me.Left = Screen.Width - Me.Width * 1.1
  If App.PrevInstance Then
    MsgBox "Mouse Recorder is already runing!" & vbCrLf & _
           "Press [F12] to show Recorder Window.", vbInformation, "Error!"
    Unload Me
  End If
  Do While GetAsyncKeyState(&H7B): Loop ' F12 '
  Do While GetAsyncKeyState(&H79): Loop ' F10 '
  Do While GetAsyncKeyState(&H78): Loop ' F9  '
  Do While GetAsyncKeyState(&H13): Loop 'pause'
  tControl.Enabled = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
  tControl.Enabled = False
  If Len(Dir(ApplPath & "playfrm.shp")) Then Kill ApplPath & "playfrm.shp"
  If Len(Dir(ApplPath & "recfrm.shp")) Then Kill ApplPath & "recfrm.shp"
  DoEvents
  End
End Sub

Private Sub tControl_Timer()
  Static OldMX As Long, OldMY As Long, LastTmr As Double, OldST As String
  Static lSAn As Boolean, lSTmr As Double, PlayMotionID As Long
  Static OBL As Boolean, OBR As Boolean, OBM As Boolean, OKP As Boolean
  Static OKF12 As Boolean, OKF10 As Boolean, OKF9 As Boolean
  Static NBL As Boolean, NBR As Boolean, NBM As Boolean, NKP As Boolean
  Static NKF12 As Boolean, NKF10 As Boolean, NKF9 As Boolean
  Static BlTmr As Double, BlCntr As Long, PlayTmr As Double
  Dim Key_F12_Pressed As Boolean, Key_F10_Pressed As Boolean
  Dim Key_F9_Pressed As Boolean, Key_Pause_Pressed As Boolean
  Dim Btn_Left_Pressed As Boolean, Btn_Right_Pressed As Boolean
  Dim Btn_Middle_Pressed As Boolean, i As Long
  Dim NewMX As Long, NewMY As Long
  NewMX = MouseX: NewMY = MouseY
  
  ' F10 - &H79  F9 - &H78  Pause - &H13  F12 - &H7B '
  If GetAsyncKeyState(&H1) Then NBL = True Else NBL = False
  If GetAsyncKeyState(&H2) Then NBR = True Else NBR = False
  If GetAsyncKeyState(&H4) Then NBM = True Else NBM = False
  If GetAsyncKeyState(&H7B) Then NKF12 = True Else NKF12 = False
  If GetAsyncKeyState(&H79) Then NKF10 = True Else NKF10 = False
  If GetAsyncKeyState(&H78) Then NKF9 = True Else NKF9 = False
  If GetAsyncKeyState(&H13) Then NKP = True Else NKP = False
  
  If Not NBL And OBL Then Btn_Left_Pressed = True       'L Btn'
  If Not NBR = 0 And OBR Then Btn_Right_Pressed = True  'R Btn'
  If Not NBM = 0 And OBM Then Btn_Middle_Pressed = True 'M Btn'
  If Not NKF12 And OKF12 Then Key_F12_Pressed = True    ' F12 '
  If Not NKF10 And OKF10 Then Key_F10_Pressed = True    ' F10 '
  If Not NKF9 And OKF9 Then Key_F9_Pressed = True       ' F9  '
  If Not NKP And OKP Then Key_Pause_Pressed = True      'Pause'
  
  OBL = NBL
  OBR = NBR
  OBM = NBM
  OKF12 = NKF12
  OKF10 = NKF10
  OKF9 = NKF9
  OKP = NKP
  
  
  If BlTmr < Timer And BlCntr < 21 Then
    BlTmr = Timer + 0.3
    If lInfo(2).ForeColor = vbBlack Then
      lInfo(2).ForeColor = &HC0&
      lInfo(2).BackColor = vbWhite
    Else
      lInfo(2).ForeColor = vbBlack
      lInfo(2).BackColor = Me.BackColor
    End If
    BlCntr = BlCntr + 1
  End If
  If Key_F12_Pressed Then Me.Visible = Not Me.Visible
  If RecorderState = rsIdle Then
    If Key_F10_Pressed Then StartRecording
    If Key_F9_Pressed Then StartPlaying
  Else
    If Key_Pause_Pressed Then RecorderState = rsIdle
  End If
  If OldMX <> NewMX Or OldMY <> NewMY Then
    ' Mouse was moved '
    lMousePos.Caption = Format(NewMX, "000") & ", " & Format(NewMY, "000")
  End If
  Select Case RecorderState
    ' Recording     '
    Case rsRecording
      If cmdPlay.Enabled Then cmdPlay.Enabled = False
      If OldST <> rsRecording Then
        Set cmdRec.Picture = pStop.Picture
        If cWndAutoHide.Value And Me.Visible = True Then Me.Visible = False
        If MotionData.Count Then
          Do Until MotionData.Count = 0
            MotionData.Remove 1
          Loop
        End If
      End If
      If cRecMovement.Value Then
        If OldMX <> NewMX Or OldMY <> NewMY Then
          ' Mouse was moved '
          If LastTmr Then
            LastTmr = Round(Timer - LastTmr, 3)
            If LastTmr < 0 Then LastTmr = 0
            AddMotion NewMX, NewMY, Replace(LastTmr, ",", "."), "move"
          End If
          LastTmr = Timer
        End If
      End If
      If cRecLeftClick.Value And Btn_Left_Pressed Then
        ' Left Mouse Button was Pressed '
        If LastTmr Then
          LastTmr = Round(Timer - LastTmr, 3) * 1000
          If LastTmr < 0 Then LastTmr = 0
          AddMotion NewMX, NewMY, Replace(LastTmr, ",", "."), "Left"
        End If
        LastTmr = Timer
      End If
      If cRecMiddleClick.Value And Btn_Middle_Pressed Then
        ' Left Mouse Button was Pressed '
        If LastTmr Then
          LastTmr = Round(Timer - LastTmr, 3) * 1000
          If LastTmr < 0 Then LastTmr = 0
          AddMotion NewMX, NewMY, Replace(LastTmr, ",", "."), "Middle"
        End If
        LastTmr = Timer
      End If
      If cRecRightClick.Value And Btn_Right_Pressed Then
        ' Left Mouse Button was Pressed '
        If LastTmr Then
          LastTmr = Round(Timer - LastTmr, 3) * 1000
          If LastTmr < 0 Then LastTmr = 0
          AddMotion NewMX, NewMY, Replace(LastTmr, ",", "."), "Right"
        End If
        LastTmr = Timer
      End If
    ' Playing       '
    Case rsPlaying
      If cmdRec.Enabled Then cmdRec.Enabled = False
      If OldST <> rsPlaying Then
        Set cmdPlay.Picture = pStop.Picture
        If cWndAutoHide.Value And Me.Visible = True Then Me.Visible = False
      End If
      If PlayTmr < Timer Then
        PlayMotionID = PlayMotionID + 1
        If PlayMotionID > MotionData.Count Then
          If MotionData.Count = 0 Then
            OldST = rsPlaying
            RecorderState = rsIdle
            MsgBox "No Data loaded for Playback!", vbInformation, "Error!"
          End If
          ' if loop = false then
          '  OldST = rsPlaying
          '  RecorderState = rsIdle
          ' else
             PlayMotionID = 0
          ' end if
        Else
          ' Play Data here    '
          Select Case UCase(Trim(GetToken(MotionData.Item(PlayMotionID), 1, ",")))
            Case "MOVE"
              MouseMove Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), _
                        Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ",")))
              PlayTmr = Timer + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
            Case "LEFT"
              MouseMove Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), _
                        Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ",")))
              MouseLeftClick
              PlayTmr = Timer + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
            Case "MIDDLE"
              MouseMove Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), _
                        Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ",")))
              MouseMiddleClick
              PlayTmr = Timer + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
            Case "RIGHT"
              MouseMove Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), _
                        Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ",")))
              MouseRightClick
              PlayTmr = Timer + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
          End Select
        End If
      End If
    ' Idle          '
    Case Else
      If PlayMotionID Then PlayMotionID = 0
      If cmdRec.Enabled = False Then cmdRec.Enabled = True
      If cmdPlay.Enabled = False Then cmdPlay.Enabled = True
      If LastTmr Then LastTmr = 0
      If PlayTmr Then PlayTmr = 0
      If RecorderState <> rsIdle Then RecorderState = rsIdle
      If OldST <> rsIdle Then
        If OldST = rsRecording Then
          Set cmdRec.Picture = pRec.Picture
        Else
          Set cmdPlay.Picture = pPlay.Picture
        End If
        If cWndAutoShow.Value And Me.Visible = False Then Me.Visible = True
      End If
      If OldST = rsRecording And SaveData Then
        ' Save Recorded Data to a file  '
        'SaveDataToFile
      End If
  End Select
  ' Blinked Status View       '
  If RecorderState = rsRecording Or RecorderState = rsPlaying Then
    If OldST <> RecorderState Then
      lSAn = False
      lState.Caption = "[" & UCase(RecorderState) & "]"
    End If
    If lSTmr < Timer Then
      lSTmr = Timer + 0.3
      lSAn = Not lSAn
      lState.Visible = lSAn
      If RecorderState = rsRecording Then
        If frmRec.Visible = False Then frmRec.Visible = True
        If lSAn Then
          frmRec.Top = 0
        Else
          frmRec.Top = -frmRec.Height
        End If
        If lState.ForeColor <> vbRed Then lState.ForeColor = vbRed
      Else
        If lState.ForeColor <> vbGreen Then lState.ForeColor = vbGreen
        If frmPlay.Visible = False Then frmPlay.Visible = True
        If lSAn Then
          frmPlay.Top = 0
        Else
          frmPlay.Top = -frmPlay.Height
        End If
      End If
    End If
  Else
    If lState.Visible Then
      lState.Visible = False
      Unload frmRec
      Unload frmPlay
    End If
  End If
  OldMX = NewMX
  OldMY = NewMY
  OldST = RecorderState
End Sub
