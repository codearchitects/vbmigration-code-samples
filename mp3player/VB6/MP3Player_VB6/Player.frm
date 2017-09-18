VERSION 5.00
Begin VB.Form Player 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00FF8080&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "E-MP3 Player"
   ClientHeight    =   7725
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5700
   Icon            =   "Player.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   OLEDropMode     =   1  'Manual
   ScaleHeight     =   7725
   ScaleWidth      =   5700
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picvol 
      BackColor       =   &H00404040&
      BorderStyle     =   0  'None
      Height          =   105
      Left            =   1620
      ScaleHeight     =   105
      ScaleWidth      =   1680
      TabIndex        =   15
      ToolTipText     =   "Set volume"
      Top             =   1965
      Visible         =   0   'False
      Width           =   1680
      Begin VB.Label Lblvol 
         BackColor       =   &H00E0E0E0&
         Enabled         =   0   'False
         Height          =   105
         Left            =   825
         TabIndex        =   16
         Top             =   0
         Width           =   90
      End
   End
   Begin VB.PictureBox VOL 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   240
      Left            =   1305
      Picture         =   "Player.frx":0D2E
      ScaleHeight     =   240
      ScaleWidth      =   255
      TabIndex        =   14
      ToolTipText     =   "Volume"
      Top             =   1920
      Width           =   255
      Begin VB.Image ImgPlus 
         Enabled         =   0   'False
         Height          =   240
         Left            =   0
         Picture         =   "Player.frx":10B0
         Top             =   0
         Visible         =   0   'False
         Width           =   120
      End
      Begin VB.Image ImgMin 
         Enabled         =   0   'False
         Height          =   240
         Left            =   120
         Picture         =   "Player.frx":1272
         Top             =   0
         Visible         =   0   'False
         Width           =   135
      End
   End
   Begin VB.PictureBox Ticker 
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      Height          =   345
      Left            =   525
      Picture         =   "Player.frx":1474
      ScaleHeight     =   345
      ScaleWidth      =   1515
      TabIndex        =   8
      Top             =   1155
      Width           =   1515
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         Caption         =   "No file loaded"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   177
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00404040&
         Height          =   240
         Left            =   30
         TabIndex        =   10
         Top             =   105
         Width           =   1170
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         Caption         =   "BBBBBBBBBBBB"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   177
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00404040&
         Height          =   240
         Left            =   225
         TabIndex        =   9
         Top             =   450
         Width           =   1620
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   250
      Left            =   2955
      Top             =   4425
   End
   Begin VB.PictureBox BR 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   435
      Left            =   2895
      Picture         =   "Player.frx":3A7E
      ScaleHeight     =   435
      ScaleWidth      =   420
      TabIndex        =   7
      ToolTipText     =   "Open file"
      Top             =   2145
      Width           =   420
      Begin VB.Image ImgBR 
         Enabled         =   0   'False
         Height          =   510
         Left            =   15
         Picture         =   "Player.frx":4444
         Top             =   -30
         Visible         =   0   'False
         Width           =   390
      End
   End
   Begin VB.PictureBox PL 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   435
      Left            =   2520
      Picture         =   "Player.frx":4F26
      ScaleHeight     =   435
      ScaleWidth      =   420
      TabIndex        =   6
      ToolTipText     =   "Show\Hide Playlist"
      Top             =   2145
      Width           =   420
      Begin VB.Image ImgPL 
         Enabled         =   0   'False
         Height          =   480
         Left            =   15
         Picture         =   "Player.frx":58EC
         Top             =   -15
         Visible         =   0   'False
         Width           =   390
      End
   End
   Begin VB.PictureBox PicBRSkin 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   435
      Left            =   4155
      Picture         =   "Player.frx":632E
      ScaleHeight     =   29
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   28
      TabIndex        =   5
      Top             =   6720
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.PictureBox PicPlSkin 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   435
      Left            =   3630
      Picture         =   "Player.frx":6CF4
      ScaleHeight     =   29
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   28
      TabIndex        =   4
      Top             =   6690
      Visible         =   0   'False
      Width           =   420
   End
   Begin VB.PictureBox picPauseSkin 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   855
      Left            =   2250
      Picture         =   "Player.frx":76BA
      ScaleHeight     =   855
      ScaleWidth      =   825
      TabIndex        =   3
      Top             =   6510
      Visible         =   0   'False
      Width           =   825
   End
   Begin VB.PictureBox picPlaySkin 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   960
      Left            =   1095
      Picture         =   "Player.frx":9C64
      ScaleHeight     =   960
      ScaleWidth      =   1020
      TabIndex        =   2
      Top             =   6435
      Visible         =   0   'False
      Width           =   1020
   End
   Begin VB.PictureBox Pause 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   900
      Left            =   4590
      ScaleHeight     =   900
      ScaleWidth      =   855
      TabIndex        =   1
      ToolTipText     =   "Stop"
      Top             =   1155
      Width           =   855
      Begin VB.Image ImgPause 
         Enabled         =   0   'False
         Height          =   885
         Left            =   210
         Picture         =   "Player.frx":CFA6
         Top             =   -30
         Visible         =   0   'False
         Width           =   405
      End
      Begin VB.Image Image2 
         Enabled         =   0   'False
         Height          =   945
         Left            =   -75
         Picture         =   "Player.frx":E344
         Top             =   -45
         Width           =   930
      End
   End
   Begin VB.PictureBox play 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   990
      Left            =   3660
      Picture         =   "Player.frx":111CA
      ScaleHeight     =   990
      ScaleWidth      =   1050
      TabIndex        =   0
      ToolTipText     =   "Play"
      Top             =   1125
      Width           =   1050
      Begin VB.Image Imgprpus 
         Enabled         =   0   'False
         Height          =   975
         Left            =   240
         Picture         =   "Player.frx":148B4
         Top             =   15
         Visible         =   0   'False
         Width           =   540
      End
      Begin VB.Image Imgpus 
         Enabled         =   0   'False
         Height          =   1005
         Left            =   270
         Picture         =   "Player.frx":16462
         Top             =   0
         Visible         =   0   'False
         Width           =   480
      End
      Begin VB.Image ImgPlay 
         Enabled         =   0   'False
         Height          =   1050
         Left            =   285
         Picture         =   "Player.frx":17DC4
         Top             =   15
         Visible         =   0   'False
         Width           =   510
      End
   End
   Begin VB.Image Minimize 
      Height          =   105
      Left            =   3090
      Picture         =   "Player.frx":19A76
      ToolTipText     =   "Minimize"
      Top             =   165
      Width           =   120
   End
   Begin VB.Label LblTime 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   177
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00404040&
      Height          =   270
      Left            =   540
      OLEDropMode     =   1  'Manual
      TabIndex        =   13
      Top             =   1245
      Width           =   540
   End
   Begin VB.Label slider2 
      BackColor       =   &H00808080&
      Enabled         =   0   'False
      Height          =   105
      Left            =   1620
      TabIndex        =   12
      Top             =   1965
      Visible         =   0   'False
      Width           =   1680
   End
   Begin VB.Label slider1 
      BackColor       =   &H00FFFFFF&
      Height          =   105
      Left            =   1620
      TabIndex        =   11
      ToolTipText     =   "Seek the file"
      Top             =   1965
      Visible         =   0   'False
      Width           =   1680
   End
   Begin VB.Image Close 
      Height          =   135
      Left            =   2940
      ToolTipText     =   "Close"
      Top             =   150
      Width           =   135
   End
   Begin VB.Image Image1 
      Enabled         =   0   'False
      Height          =   2955
      Left            =   -75
      Picture         =   "Player.frx":19B60
      Top             =   -45
      Width           =   5775
   End
   Begin VB.Menu Mainmenu 
      Caption         =   "Main"
      Visible         =   0   'False
      Begin VB.Menu MnuBR 
         Caption         =   "&Open..."
      End
      Begin VB.Menu MnuClose 
         Caption         =   "C&lose"
      End
      Begin VB.Menu MnuSep0 
         Caption         =   "-"
      End
      Begin VB.Menu MnuPlay 
         Caption         =   "&Play"
         Enabled         =   0   'False
      End
      Begin VB.Menu MnuStop 
         Caption         =   "&Stop"
         Enabled         =   0   'False
      End
      Begin VB.Menu MnuInfo 
         Caption         =   "MP3 &Info..."
      End
      Begin VB.Menu Mnusep1 
         Caption         =   "-"
      End
      Begin VB.Menu MnuShowPL 
         Caption         =   "Show Playlist"
      End
      Begin VB.Menu MnuOntop 
         Caption         =   "Player on-top"
         Checked         =   -1  'True
      End
      Begin VB.Menu Mnusep2 
         Caption         =   "-"
      End
      Begin VB.Menu MnuAbout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "Player"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim tictac As Boolean
Dim pus As Boolean
Public mediafile As String
Public MainRGN As Long
Dim loc As Long
Dim VolTimer As Integer
Dim STT As String
Dim STL As Single
Dim Midi As Boolean
Public PLSong As Integer

Private Sub BR_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Private Sub Close_Click()
    End
End Sub

Private Sub Form_Activate()

    If MnuOntop.Checked Then
        SetWindowPos Me.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE
    Else
        SetWindowPos Me.hWnd, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE
    End If
End Sub

Private Sub Form_DblClick()
'    Image1.Visible = Not Image1.Visible
'    If (PlayList.Visible) Then PlayList.PicMMask.Visible = Image1.Visible
'    Label3.Visible = Not Image1.Visible
End Sub

Private Sub Form_Deactivate()
    If PlayList.Visible And Not PlayList.Docked Then PlayList.Visible = Me.WindowState = vbNormal
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    If KeyCode = 32 Then play_Click
    If slider1.Visible Then
        If KeyCode = 39 Then
            loc = FileLocation + Percent(FileLength, 5)
            If loc > FileLength Then loc = FileLength
            If Imgpus.Visible Then
                Call mciSendString("play myfile from " & loc, 0&, 0, 0)
            Else
                Call mciSendString("seek myfile to " & loc, 0&, 0, 0)
            End If
        End If
        If KeyCode = 37 Then
            loc = FileLocation - Percent(FileLength, 5)
            If loc < 0 Then loc = 0
            If Imgpus.Visible Then
                Call mciSendString("play myfile from " & loc, 0&, 0, 0)
            Else
                Call mciSendString("seek myfile to " & loc, 0&, 0, 0)
            End If
        End If
    End If
    If KeyCode = 38 Then: VolUp: ShowVol
    If KeyCode = 40 Then: VolDown: ShowVol
    DoEvents
    'Debug.Print KeyCode
End Sub

Private Sub Form_Load()
    Dim WindowRegion As Long
    Dim CMD As String
    Dim CheckExt As Boolean
    Dim Files As New Collection
    ' אתחול תיבת התמונה המכילה את התמונה
    'With picMainSkin
    '    .ScaleMode = vbPixels
    '    .AutoRedraw = True
    '    .AutoSize = True
    '    .BorderStyle = vbBSNone
    'End With
    'MainRGN = MakeRegion(picMainSkin)
    'Me.Width = picMainSkin.Width
    'Me.Height = picMainSkin.Height
    
    ' קריאה לפונקציה ליצירת האזור בצורת התמונה
    'WindowRegion = MakeRegion(picMainSkin)
    ' עדכון אזור הטופס לאזור הנוצר
    'SetWindowRgn Me.hWnd, WindowRegion, True
    ' אתחול כללי של הטופס
    'Me.DrawMode = vbCopyPen: Me.Visible = True: Me.Caption = Me.Caption
    Load PlayList
    shapemain Me
    With picPlaySkin
        .ScaleMode = vbPixels
        .AutoRedraw = True
        .AutoSize = True
        .BorderStyle = vbBSNone
    End With
    
    WindowRegion = MakeRegion(picPlaySkin)
    SetWindowRgn play.hWnd, WindowRegion, True
    play.DrawMode = vbCopyPen
    play.Visible = True
    With picPauseSkin
        .ScaleMode = vbPixels
        .AutoRedraw = True
        .AutoSize = True
        .BorderStyle = vbBSNone
    End With
    
    WindowRegion = MakeRegion(picPauseSkin)
    SetWindowRgn Pause.hWnd, WindowRegion, True
    Pause.DrawMode = vbCopyPen
    Pause.Visible = True
    
    WindowRegion = MakeRegion(PicPlSkin)
    SetWindowRgn PL.hWnd, WindowRegion, True
    PL.DrawMode = vbCopyPen
    PL.Visible = True
    
    WindowRegion = MakeRegion(PicBRSkin)
    SetWindowRgn BR.hWnd, WindowRegion, True
    BR.DrawMode = vbCopyPen
    BR.Visible = True
    Call mciSendString("close myfile", 0&, 0, 0) ', , "Clearing memory"
    GetCMDFiles
    'CMD = Command
    'MsgBox CMD
    'If CMD <> "" Then:
'    On Error Resume Next
'    CMD = Command
'    MsgBox CMD
'    If CMD <> "" Then
'        MsgBox LCase(Right(Dir(CMD), 4))
'        CheckExt = LCase(Right(Dir(CMD), 4)) = ".mp3" Or LCase(Right(Dir(CMD), 4)) = ".rmi" Or LCase(Right(Dir(CMD), 4)) = ".mid" Or LCase(Right(Dir(CMD), 4)) = ".wav"
'        If CheckExt = True Then OpenFile Command$, CMD
'    End If
'MsgBox UBound(LstData)
    Show
    If PlayList.lstPL.ListCount > 0 Then
        mediafile = LstData(0)
        OpenFile LstData(0), Dir(LstData(0))
        PLSong = 1
        PlayList.lstPL.ListIndex = 0
        play_Click
    End If
    
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
      ReleaseCapture
      SendMessage Me.hWnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&
End Sub

Private Sub BR_Click()
    Dim sFile  As String
    Dim i As Long
    Dim DirectoryName As String
    Dim FileNames() As String
    Dim sTemp As String
    Dim j As Long
'    PlayList.lstPL.Clear
'    PlayList.lstPL.AddItem ""
'
    sFile = OpenDlg(Me.hWnd, "MP3 Files(*.mp3)|*.mp3|WAVE Files(*.wav)|*.wav|MIDI Files(*.mid; *.rmi)|*.mid;*.rmi", , , True)
    If sFile <> "?" Then
        sFile = UnSpace(sFile)
        PlayList.lstPL.Clear
        ' כעת מהמחרוזת המוחזרת מתיבת הדיאלוג יש להוציא
        ' את שמות הקבצים
        For i = 1 To Len(sFile)
            If Mid(sFile, i, 1) = Chr(0) Or i = Len(sFile) Then  ' A sample by Yaniv Drukman
                If DirectoryName = "" And i <> Len(sFile) Then
                    ' שמירת שם הספריה בה נמצאים הקבצים
                    DirectoryName = sTemp
                    ' בדיקה האם צריך להוסיף לשם הספריה סלאש בסוף
                    If Right(DirectoryName, 1) <> "\" Then DirectoryName = DirectoryName + "\"
                    sTemp = ""
                ' במקרה שהמשתמש בחר רק בקובץ אחד
                ElseIf DirectoryName = "" Then
                    On Error Resume Next
                    mediafile = sFile
                    PlayList.AddPLItem sFile
                    PLSong = 1 'PlayList.lstPL.ListCount
                    OpenFile mediafile, sFile
    
                Else
                    If i = Len(sFile) Then sTemp = sTemp + Mid(sFile, i, 1)
                    j = j + 1
                    ' שמירת שמות הקבצים במערך דינמי
                    ReDim Preserve FileNames(j)
                    FileNames(UBound(FileNames)) = sTemp
                    sTemp = ""
                    ' הוספת שמות הקבצים לתיבת רשימה
                    PlayList.AddPLItem FileNames(UBound(FileNames))
                    ' טעינת התמונה בטופס תצוגה
                    On Error Resume Next
    '                frmPicture.Caption = FileNames(UBound(FileNames))
                End If
            Else
                sTemp = sTemp + Mid(sFile, i, 1)
            End If
        Next i
        If j > 0 Then
            PLSong = 1
            mediafile = FileNames(1)
            OpenFile mediafile, FileNames(1)
        End If
    End If

End Sub

Public Sub Form_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button = 2 Then
        MnuInfo.Enabled = mediafile <> "" And Midi = False
        MnuClose.Enabled = mediafile <> ""
        MnuPlay.Enabled = MnuClose.Enabled
        MnuStop.Enabled = FileLocation > 0 Or FileLocation = 0 And Imgpus.Visible = True
        MnuShowPL.Checked = PlayList.Visible
        PopupMenu Mainmenu
    End If
End Sub

Public Sub Form_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Data.GetFormat(vbCFFiles) Then
        'If LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mp3" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mid" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".rmi" Then
        mediafile = Data.Files.Item(1)
        PlayList.lstPL.Clear
        PlayList.AddPLItem Data.Files.Item(1)
        PLSong = PlayList.lstPL.ListCount - 1
        OpenFile Data.Files.Item(1), Dir(Data.Files.Item(1))
        'Else
        '    MsgBox "Use only mp3 files", vbCritical
        'End If
    End If
End Sub

Private Sub Form_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    Dim CheckExt As Boolean
    If Data.GetFormat(vbCFFiles) Then
    ' בדיקה האם המידע מהקובץ הוא מהסוג הרצוי
        CheckExt = LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mp3" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".rmi" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".mid" Or LCase(Right(Dir(Data.Files.Item(1)), 4)) = ".wav"
        Effect = vbDropEffectCopy And Effect
        If Data.Files.Count = 1 And CheckExt Then Exit Sub
    End If
    ' אם המידע הוא מהסוג הרצוי אז אל תאפשר השלכה
    Effect = vbDropEffectNone
End Sub

Private Sub Form_Unload(Cancel As Integer)
    End
End Sub

Private Sub Minimize_Click()
    Me.WindowState = vbMinimized
End Sub

Private Sub MnuBR_Click()
    BR_Click
End Sub

Public Sub MnuClose_Click()
    Pause_Click
    'Timer1 = False
    Call mciSendString("close myfile", 0&, 0, 0)
    Ticker.Left = 525 + 30
    Label1.Left = 0
    Label1 = "No file loaded"
    Label2 = ""
    STT = "No file loaded"
    STL = 0
    mediafile = ""
    Midi = False
End Sub

Private Sub MnuInfo_Click()
    Dim msg As String
    Dim md As String
    Dim mp32 As MP3Tag
    mp32 = GetMP3Info(mediafile)
    If UnSpace(mp32.Title) <> "" Then msg = msg & "Title: " & UnSpace(mp32.Title) & vbCrLf
    If UnSpace(mp32.Artist) <> "" Then msg = msg & "Artist: " & UnSpace(mp32.Artist) & vbCrLf
    If UnSpace(mp32.Album) <> "" Then msg = msg & "Album: " & UnSpace(mp32.Album) & vbCrLf
    If UnSpace(mp32.Year) <> "" Then msg = msg & "Year: " & UnSpace(mp32.Year) & vbCrLf
    
    md = Getmp3data(mediafile)
    If md <> "" Then msg = msg & md
    
    If UnSpace(mp32.Comments) <> "" Then msg = msg & vbCrLf & "Comment: " & UnSpace(mp32.Comments)
    
    MsgBox msg, vbInformation, "MP3\Time Information"
End Sub

Private Sub MnuOntop_Click()
    MnuOntop.Checked = Not MnuOntop.Checked
    Form_Activate
    If MnuOntop.Checked And PlayList.Visible Then SetWindowPos PlayList.hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE
End Sub

Private Sub MnuShowPL_Click()
    MnuShowPL.Checked = Not MnuShowPL.Checked
    PL_Click
End Sub

Private Sub Pause_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Private Sub Picvol_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Private Sub Picvol_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If X < 0 Then X = 0
    If X > Picvol.Width Then X = Picvol.Width - 8
    If Button = 1 Then
        SetVol Percent(100, X / (slider1.Width / 100)), Midi
        Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
        Label1 = "Volume: " & GetVol(Midi) & "%"
        VolTimer = 1
    End If
End Sub
Private Sub Picvol_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Picvol_MouseDown Button, Shift, X, Y
End Sub

Public Sub PL_Click()
Dim WindowRegion As Long
    Load PlayList
    If PlayList.Visible Then
        PlayList.Hide
    Else
        PlayList.Show , Me
    End If
    'PlayList.Visible = Not PlayList.Visible
    '
    'SetWindowRgn Me.hWnd, MainRGN, True
    If Not PlayList.Visible Then
        'WindowRegion = MakeRegion(picMainSkin)
        'SetWindowRgn Me.hWnd, WindowRegion, True
        shapemain Me
    Else
        If PlayList.Docked Then PlayList.Dock
    End If
    'SetWindowRgn Me.hWnd, MainRGN, True
'    PlayList.Docked = True
'    If PlayList.Docked Then
'        If PlayList.Visible Then
'            SetWindowRgn Me.hWnd, Bigrgn, True
'            SetParent PlayList.hWnd, Player.hWnd
'            PlayList.Dock
'        Else
'            SetWindowRgn Me.hWnd, MainRgn, True
'        End If
'    End If
End Sub

Private Sub LblTime_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Form_MouseDown Button, Shift, X, Y
End Sub

Private Sub LblTime_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Form_MouseUp Button, Shift, X, Y
End Sub

Private Sub LblTime_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    Form_OLEDragDrop Data, Effect, Button, Shift, X, Y
End Sub

Private Sub LblTime_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    Form_OLEDragOver Data, Effect, Button, Shift, X, Y, State
End Sub

Private Sub MnuAbout_Click()
    MsgBox "Program made by avba0 and Darkstorm!" & vbCrLf & "Beta stage, v" & App.Major & "." & App.Minor & "." & App.Revision & vbCrLf & "Copyright © 2005" & vbCrLf & vbCrLf & _
     "Main Programmer: Netanel Gabbay (VB)" & vbCrLf & "Software Design: Moshe Pasker", vbInformation, "VB MP3 Player v0.1.7"
End Sub

Private Sub MnuPlay_Click()
    play_Click
End Sub

Private Sub MnuStop_Click()
    Pause_Click
End Sub

Private Sub Pause_Click()
    If MnuPlay.Enabled = False And mediafile = "" Then Beep
    Call mciSendString("stop myfile", 0&, 0, 0) ', , "mci: stop"
    Call mciSendString("seek myfile to 0", 0&, 0, 0) ', , "mci: move to 0"
    Imgpus.Visible = False
    MnuPlay.Caption = "Play"
    slider1.Visible = False
    slider2.Visible = False
    slider2.Width = 0
    pus = False
    play.ToolTipText = MnuPlay.Caption
    LblTime.ToolTipText = ""
End Sub

Private Sub Pause_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPause.Visible = True
End Sub

Private Sub Pause_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPause.Visible = False
End Sub

Private Sub Imgpus_Click()
    play_Click
End Sub

Private Sub PL_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Public Sub play_Click()
    If MnuPlay.Enabled = False Then Beep
    Dim retval
'    Static NotFirstTime As Boolean
    If Not pus Then
        retval = mciSendString("play myfile from " & FileLocation, 0&, 0, 0)
        If retval = 0 Then MnuPlay.Caption = "Pause"
        LblTime.ToolTipText = TimeString(FileLength / 1000)
        'MsgBox retval, , "mci: play"
    Else
        retval = mciSendString("stop myfile", 0&, 0, 0)
        If retval = 0 Then MnuPlay.Caption = "Play"
        LblTime.ToolTipText = TimeString(FileLength / 1000)
        'MsgBox retval, , "mci: pause"
    End If
    If retval = 0 Then
        slider1.Visible = True
        slider2.Visible = True
        pus = Not pus
    End If
    'If FileLocation <> 0 Or NotFirstTime = False Then
        Imgpus.Visible = pus
    'End If
    'NotFirstTime = False
    play.ToolTipText = MnuPlay.Caption
End Sub

Private Sub play_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Private Sub play_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPlay.Visible = True
    Imgprpus.Visible = pus
End Sub

Private Sub play_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPlay.Visible = False
    Imgprpus.Visible = False
End Sub

Private Sub Slider1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    'MsgBox X
    If X < 0 Then X = 0
    If X > slider1.Width Then X = slider1.Width - 8
    slider2.Width = X + 15 ': Label3 = Percent(FileLength, X / (slider1.Width / 100)) & "/" & FileLength  '"%" & X / (slider1.Width / 100)
    'If MIDI Then: Call mciSendString("stop myfile", 0&, 0, 0)
    If pus Then
        'If MIDI Then
        Call mciSendString("play myfile from " & Percent(FileLength, X / (slider1.Width / 100)), 0&, 0, 0)
        'Else
        '    Call mciSendString("play myfile", 0&, 0, 0)
        'End If
    Else
        Call mciSendString("seek myfile to " & Percent(FileLength, X / (slider1.Width / 100)), 0&, 0, 0) ', , "mci: move to 0"
    End If
End Sub

Private Sub pl_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPL.Visible = True
End Sub

Private Sub pl_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgPL.Visible = False

End Sub

Private Sub BR_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgBR.Visible = True
End Sub

Private Sub BR_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ImgBR.Visible = False
End Sub


Private Sub Timer1_Timer()
    If STT = "" Then STT = Label1
    'If Label1 = "No file loaded" Then STT = Label1
    If VolTimer = 50 Then
        VolTimer = 0
        Picvol.Visible = False
        If STT <> "No file loaded" Then
            Label2.Visible = True
            Ticker.Left = 1125
        Else
            Ticker.Left = 525 + 30
        End If
        Timer1.Interval = 250
        Label1 = STT
        Label1.Left = STL
    End If
    If VolTimer > 0 Then
        If ImgPlus.Visible Then
           'If GetVol(False) < 100 Then SetVol GetVol(False) + 1, False
           'Label1 = "Volume: " & GetVol(False) & "%"
           'Lblvol.Left = Percent(Picvol.Width, GetVol(False)) - (Lblvol.Width \ 2)
           VolUp
           VolTimer = 1
        ElseIf ImgMin.Visible Then
           'If GetVol(False) > 0 Then SetVol GetVol(False) - 1, False
           'Label1 = "Volume: " & GetVol(False) & "%"
           'Lblvol.Left = Percent(Picvol.Width, GetVol(False)) - (Lblvol.Width \ 2)
           VolDown
           VolTimer = 1
        End If
        VolTimer = VolTimer + 1
        Exit Sub
    End If
    STL = Label1.Left
    STT = Label1
    If STT = "No file loaded" Then Exit Sub
    If slider1.Visible Then
        LblTime = TimeString(FileLocation \ 1000)
        On Error Resume Next
        slider2.Width = Percent(slider1.Width, FileLocation \ (FileLength \ 100))
        If Imgpus.Visible = True And FileLocation = FileLength Then
            Debug.Print PlayList.lstPL.ListCount
            If PlayList.lstPL.ListCount > 1 And Not PLSong = PlayList.lstPL.ListCount - 0 Then
                Label1.Visible = False
                Label2.Visible = False
                mediafile = LstData(PLSong)
                OpenFile LstData(PLSong), Dir(LstData(PLSong))
                PLSong = PLSong + 1
                PlayList.lstPL.ListIndex = PLSong - 1
                play_Click
            Else
                Pause_Click
            End If
        End If
    Else
        LblTime = TimeString(FileLength \ 1000)
    End If
    'If tictac = True Then: If Label1.Left > Label2.Left Then tictac = False
    If tictac = False Then
        Label1.Left = Label1.Left - 120
        Label2.Left = Label1.Left + Label1.Width + 0 '15 * 15
        If -Label1.Left >= Label1.Width Then tictac = Not tictac: Label1.Left = Label2.Left + Label1.Width + 15 * 0
 'Label2.Left = Ticker.Width
    Else
        Label2.Left = Label2.Left - 120
        Label1.Left = Label2.Left + Label1.Width + 15 * 0
        If -Label2.Left >= Label2.Width Then tictac = Not tictac: Label2.Left = Label1.Left + Label1.Width ' Label1.Left = Ticker.Width
    End If
End Sub

Public Sub OpenFile(FileName As String, FileTitle As String)
    Dim Title As String
    Dim Artist As String
    Dim Album As String
    Dim Year As String
    Dim mp32 As MP3Tag
    Dim AudioType As String
    mp32 = GetMP3Info(FileName)
    If mediafile = "" Then GoTo err
    Timer1 = False
    MnuInfo.Enabled = mediafile <> ""
    MnuClose.Enabled = mediafile <> ""
    MnuPlay.Enabled = MnuClose.Enabled
    If UnSpace(mp32.Title) <> "" Then Title = " - " & UnSpace(mp32.Title)
    If UnSpace(mp32.Artist) <> "" Then Artist = " \\ Artist: " & UnSpace(mp32.Artist)
    If UnSpace(mp32.Album) <> "" Then Album = " \\ Album: " & UnSpace(mp32.Album)
    If UnSpace(mp32.Year) <> "" Then Year = " \\ Year: " & UnSpace(mp32.Year)
    Ticker.Left = 525 + 30
    Label1.Left = 0
    DoEvents
    LblTime = "" '''False
    Label1.Visible = True
    Label2 = ""
    Label1 = "Opening..."
    If slider1.Visible Then Pause_Click
    Midi = LCase(Right(FileName, 4)) = ".mid" Or LCase(Right(FileName, 4)) = ".rmi"
    Call mciSendString("close myfile", 0&, 0, 0)
    DoEvents
    If Not LCase(Right(FileName, 4)) = ".wav" Then AudioType = " type MpegVideo"
    Call mciSendString("open " & Chr(34) & FileName & Chr(34) & AudioType & " alias myfile", 0&, 0, 0) ', , "Open file:" & mediafile
    LblTime = TimeString(FileLength \ 1000)
    Label1.Left = 15 * 45
    Label1 = "File: " & FileTitle & Title
    Label1 = Label1 & Album
    Label1 = Label1 & Artist
    Label1 = Label1 & Year
    Label1 = Label1 & "    >>>>    "
    Label2 = Label1
    Label2.Top = Label1.Top
    Label2.Left = Label1.Width
    Ticker.Left = 1125
    slider2.Width = 0
    tictac = False
    Label2.Visible = True
    
    Timer1 = True
err:
End Sub

Private Sub VOL_KeyDown(KeyCode As Integer, Shift As Integer)
    Form_KeyDown KeyCode, Shift
End Sub

Private Sub VOL_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
'Beep
    If Button = vbLeftButton And Y <= ImgPlus.Width Then
        If X < ImgMin.Left Then
            VolUp
            ImgPlus.Visible = True
            ImgMin.Visible = False
        Else
            'Ticker.Visible = False
            'Label1.Left = 30
            'Ticker.Left = 525 + 30
            'Picvol.Visible = True
            'Label2.Visible = False
            'VolTimer = 1
           ' Ticker.Visible = True
            'Timer1.Interval = 10
            'Timer1 = True
            VolDown
            ImgPlus.Visible = False
            ImgMin.Visible = True
        End If
        ShowVol
    End If
End Sub
'            SetVol GetVol(False) - 1, False
'            Label1 = "Volume: " & GetVol(False)

Private Sub VOL_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)


'    If Button = vbLeftButton And Y <= ImgPlus.Width Then
'        If X < ImgMin.Left Then

'        Else
'        End If
'    End If
    ImgPlus.Visible = False
    ImgMin.Visible = False

End Sub

Private Sub VolUp()
    If GetVol(Midi) < 100 Then SetVol GetVol(Midi) + 1, Midi
    Label1 = "Volume: " & GetVol(Midi) & "%"
    Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
End Sub

Private Sub VolDown()
    If GetVol(Midi) > 0 Then SetVol GetVol(Midi) - 1, Midi
    Label1 = "Volume: " & GetVol(Midi) & "%"
    Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
End Sub

Private Sub ShowVol()
    Lblvol.Left = Percent(Picvol.Width, GetVol(Midi)) - (Lblvol.Width \ 2)
    Ticker.Visible = False
    Label1.Left = 25
    Ticker.Left = 525 + 30
    Picvol.Visible = True
    Label2.Visible = False
    VolTimer = 1
    Ticker.Visible = True
    Timer1.Interval = 50
    Timer1 = True
End Sub

Private Function GetCMDFiles() ' As Collection
    Dim CMD As String
    Dim Result As String
    Dim i As Integer
    'Dim Files As New Collection
    CMD = Command
    If Right(CMD, 1) = Chr(34) Then CMD = Left(CMD, Len(CMD) - 1)
    If Left(CMD, 1) = Chr(34) Then CMD = Right(CMD, Len(CMD) - 1)
    For i = 1 To Len(CMD)
        i = InStr(i, CMD, ":")
        Result = ""
        If InStr(i + 1, CMD, ":") Then
            Do Until i = InStr(i + 1, CMD, ":") - 1
                Result = Result + Mid(CMD, i - 1, 1)
                i = i + 1
            Loop
            If Right(Result, 1) = Chr(34) Then Result = Left(Result, Len(Result) - 1)
            If Right(Result, 2) = Chr(34) & Chr(32) Then Result = Left(Result, Len(Result) - 2)
            'Files.Add Result
            PlayList.AddPLItem Result
        Else
            Result = Result + Mid(CMD, i - 1, Len(CMD))
            'Files.Add Result
            PlayList.AddPLItem Result
            Exit For
        End If
    Next i
End Function

