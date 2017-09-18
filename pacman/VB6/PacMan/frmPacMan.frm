VERSION 5.00
Begin VB.Form frmPacMan 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00000000&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   8295
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6720
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   553
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   448
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer tmrReady 
      Enabled         =   0   'False
      Interval        =   500
      Left            =   7080
      Top             =   7800
   End
   Begin VB.Timer tmrPookie 
      Interval        =   100
      Left            =   6000
      Top             =   7440
   End
   Begin VB.Timer tmrFlash 
      Interval        =   500
      Left            =   10680
      Top             =   7800
   End
   Begin VB.PictureBox pctBack 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00404080&
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      Height          =   2880
      Left            =   10320
      ScaleHeight     =   192
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   32
      TabIndex        =   8
      Top             =   4500
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Timer tmrKeyBoard 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   11220
      Top             =   7800
   End
   Begin VB.PictureBox pctTiles 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      Height          =   5280
      Left            =   7200
      ScaleHeight     =   352
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   256
      TabIndex        =   5
      Top             =   360
      Visible         =   0   'False
      Width           =   3840
   End
   Begin VB.PictureBox pctScreen 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00800080&
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      ForeColor       =   &H0000FF00&
      Height          =   7425
      Left            =   0
      Picture         =   "frmPacMan.frx":0000
      ScaleHeight     =   495
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   448
      TabIndex        =   0
      Top             =   420
      Visible         =   0   'False
      Width           =   6720
      Begin VB.Label lblPlayer 
         Alignment       =   2  'Center
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   2100
         TabIndex        =   15
         Top             =   4680
         Width           =   2535
      End
      Begin VB.Label lblReady 
         Alignment       =   2  'Center
         BackColor       =   &H00000000&
         BackStyle       =   0  'Transparent
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   495
         Left            =   2100
         TabIndex        =   14
         Top             =   3960
         Width           =   2535
      End
   End
   Begin VB.PictureBox pctpicture 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00800000&
      BorderStyle     =   0  'None
      ForeColor       =   &H0000FF00&
      Height          =   7425
      Left            =   6720
      ScaleHeight     =   495
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   448
      TabIndex        =   6
      Top             =   360
      Visible         =   0   'False
      Width           =   6720
   End
   Begin VB.PictureBox pctStats 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00000000&
      BorderStyle     =   0  'None
      Enabled         =   0   'False
      Height          =   480
      Left            =   0
      ScaleHeight     =   32
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   448
      TabIndex        =   7
      Top             =   7800
      Width           =   6720
      Begin VB.Label lblKeys 
         Alignment       =   2  'Center
         BackColor       =   &H00000000&
         Caption         =   "(I) Insert Coin   (1) 1 Play   (2) 2 Play   (E) Enhanced   (S) Speed   (Esc) Exit"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C0C0C0&
         Height          =   195
         Left            =   0
         TabIndex        =   13
         Top             =   240
         Width           =   6615
      End
   End
   Begin VB.Label lblSpeed 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      Caption         =   "NORMAL SPEED"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   435
      Left            =   60
      TabIndex        =   17
      Top             =   2280
      Width           =   6615
   End
   Begin VB.Label lblPlayers 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   435
      Left            =   60
      TabIndex        =   16
      Top             =   4920
      Width           =   6615
   End
   Begin VB.Label lblCoins 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      Caption         =   "0 CREDITS"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   60
      TabIndex        =   12
      Top             =   7020
      Width           =   6615
   End
   Begin VB.Label lblPookie 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      Caption         =   "By Lord Pookie :)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   435
      Left            =   60
      TabIndex        =   11
      Top             =   3720
      Width           =   6615
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      Caption         =   "ENHANCED PACMAN"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   435
      Left            =   60
      TabIndex        =   10
      Top             =   1020
      Width           =   6615
   End
   Begin VB.Label lblInsert 
      Alignment       =   2  'Center
      BackColor       =   &H00000000&
      Caption         =   "INSERT COINS"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   435
      Left            =   60
      TabIndex        =   9
      Top             =   6060
      Width           =   6615
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00000000&
      Caption         =   "SCORE"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   60
      TabIndex        =   4
      Top             =   0
      Width           =   1215
   End
   Begin VB.Label lblHiscore 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00000000&
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   3480
      TabIndex        =   3
      Top             =   0
      Width           =   1455
   End
   Begin VB.Label lblScore 
      BackColor       =   &H00000000&
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   1440
      TabIndex        =   2
      Top             =   0
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BackColor       =   &H00000000&
      Caption         =   "HI SCORE"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   18
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   375
      Left            =   4980
      TabIndex        =   1
      Top             =   0
      Width           =   1695
   End
End
Attribute VB_Name = "frmPacMan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()

  frmPacMan.Show
  DoEvents
  
  ' Memorize the Directions
  YD(0) = -1
  YD(1) = 1
  XD(2) = -1
  XD(3) = 1
  
  ' Memorize the Reverse Direction to the directions
  Rev(0) = 1
  Rev(1) = 0
  Rev(2) = 3
  Rev(3) = 2
  
  ' offset direction
  OffDir(0) = -1
  OffDir(1) = 1
  OffDir(2) = -1
  OffDir(3) = 1
  
  Game.Speed = 1
  Game.Enhanced = True
  Game.Started = False
  
  ' How much bonus points for each ghost eaten from one power pill
  GhostEat(1) = 200
  GhostEat(2) = 400
  GhostEat(3) = 800
  GhostEat(4) = 1600
  
  Game.HiScore = 10000
    
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)

  ' if eacape is pressed, exit
  If KeyCode = vbKeyEscape Then
    shutdown
    End
  End If
  
  ' flip between enhanced pics or original
  If KeyCode = vbKeyE And Game.Started = False Then
    Game.Enhanced = Not Game.Enhanced
    If Game.Enhanced = True Then
      lblTitle.Caption = "ENHANCED PACMAN"
    Else
      lblTitle.Caption = "ORIGINAL PACMAN"
    End If
  End If
  
  ' speed of the game
  ' 1) slow (normal)
  ' 2) Fast (Good)
  ' 4) Insane (Ridiculous)
  ' Only these three numbers can be used, any other number will make
  ' the game not run properly as it all runs on base 2s and 8 is too fast
  ' for the offset to be able to examine the junctions when in eyesonly mode
  If KeyCode = vbKeyS And Game.Started = False Then
    Game.Speed = Game.Speed * 2
    If Game.Speed = 8 Then
      Game.Speed = 1
    End If
    Select Case Game.Speed
      Case 1
        lblSpeed.Caption = "NORMAL SPEED"
      Case 2
        lblSpeed.Caption = "TURBO SPEED!"
      Case 4
       lblSpeed.Caption = "INSANE SPEED!!"
    End Select
  End If
  
  ' put your money in anytime. >:)
  If KeyCode = vbKeyI And Game.Coins < 99 Then
    Game.Coins = Game.Coins + 1
    sndPlay "fruiteat", SoundOps.SND_ASYNC
    ShowCoins
  End If
  
  ' 1 player game
  If KeyCode = vbKey1 And Game.Coins > 0 And Game.Started = False Then
    Game.Coins = Game.Coins - 1
    Game.Players = 1
    ShowCoins
    Initialize
    Game.Started = True
  End If
  
  ' 2 player game
  If KeyCode = vbKey2 And Game.Coins > 1 And Game.Started = False Then
    Game.Coins = Game.Coins - 2
    Game.Players = 2
    Game.CurrentPlay = 0 ' player 1
    PacmanBackUp(1).Lives = 3 ' make sure player 2 has some lives...
    PacmanBackUp(1).FirstGo = True
    ShowCoins
    Initialize
    Game.Started = True
  End If
  
End Sub

Private Sub ShowCoins()

  ' show the amount of coins
  If Game.Coins <> 1 Then
    lblCoins.Caption = CStr(Game.Coins) & " CREDITS"
  Else
    lblCoins.Caption = "1 CREDIT"
  End If
  
  ' tell people how many players allowed
  Select Case Game.Coins
    Case 0
      lblPlayers.Caption = ""
    Case 1
      lblPlayers.Caption = "1 PLAY ONLY"
    Case Else
      lblPlayers.Caption = "1 OR 2 PLAY"
  End Select

End Sub

Private Sub Initialize()

  tmrPookie.Enabled = False
  tmrFlash.Enabled = False
  pctScreen.Visible = True
  pctScreen.Left = 0
  lblKeys.Visible = False
  
  ' Set up Pacman
  Pacman.Lives = 3
  Pacman.Level = 1
  Pacman.Score = 0
  lblHiscore.Caption = Game.HiScore
  lblScore.Caption = Pacman.Score
  lblHiscore.Refresh
  lblScore.Refresh
  Pacman.FirstGo = True
  
  If Game.Enhanced = True Then
    frmPacMan.pctTiles.Picture = LoadPicture(App.Path & "/pacpics.bmp")
  Else
    frmPacMan.pctTiles.Picture = LoadPicture(App.Path & "/pacpicsold.bmp")
  End If
  
  ' Reset the level and fill it full of dots
  ResetLevel
  ' Reset the positions of everthing
  DefaultPositions

  ' Display how many lives and level number
  ShowLives
    
  ' play opening music
  StartMusic
  PlayIntro
  

End Sub


Private Sub tmrFlash_Timer()

  Static flipflop As Boolean
  
  flipflop = Not flipflop
  
  ' this flashes the insert coin label
  If flipflop Then
    lblInsert.ForeColor = vbBlack
  Else
    lblInsert.ForeColor = vbWhite
  End If

End Sub

Private Sub tmrKeyBoard_Timer()

  Dim nLoop As Integer
  Dim Px As Integer
  Dim Py As Integer
  
  ' Test and Move Pacman
  PacmanMovement
  ' Test and Move Ghosts
  AIGhostMonsters
  ' Test for any collisions
  TestCollisions
  
  ' Move all sprites from the screen
  HideSprites
  
  ' Check if fruit has been eaten, if so, remove it from the screen
  If Pacman.TimeCount = 5000 / Game.Speed _
  Or (Pacman.TimeCount >= 4000 / Game.Speed _
  And Pacman.FruitHere = False And Pacman.FruitGone = False) Then
    HideBlit 216, 264, 5
    Pacman.FruitGone = True
  End If
  
  ' Internal time count to know when to display the fruit and to remove it again
  Pacman.TimeCount = Pacman.TimeCount + 1
  
  ' If pacman dies, then exit sub while all the spite have been hidden
  If Pacman.Dead Then PacDied: Exit Sub



  ' if all dots have been eaten, go to next level
  If Pacman.DotsLeft < 1 Then
    Pacman.TimeCount = 0 ' reset internal counter
    Pacman.Level = Pacman.Level + 1
    Pacman.FirstGo = True ' allow for music to play again
    If Pacman.Level > 8 Then Pacman.Level = 8
    AddScore 1000
    ShowLives
    ResetLevel
    DefaultPositions
    StartMusic
    PlayIntro
    Exit Sub
  End If
  
  
  
  ' If dot has been eaten, delete it from the screen
  If Pacman.DotGone Then
    Px = (Sprite(0).OXpos + XD(Pacman.Direction) * 16) + 8
    Py = (Sprite(0).OYpos + YD(Pacman.Direction) * 16) + 8
    BitBlt pctScreen.hDC, Px, Py, 16, 16, pctpicture.hDC, Px, Py, BitbltOps.SRCCOPY
  End If
 
  ' This puts the fruit on the screen
  If Pacman.TimeCount = 4000 / Game.Speed Then
    ShowBlit 216, 264, ((Pacman.Level - 1) Mod 4) * 32, _
             ((Pacman.Level - 1) \ 4) * 32 + 256, 5
    Pacman.FruitHere = True
    Pacman.FruitGone = False
  End If
  
  ' Show all sprites
  ShowSprites
  pctScreen.Refresh
  
    
End Sub


Sub PacDied()

  Dim i As Integer
  Dim j As Integer
  Dim TempVar As Integer
  
  Pacman.Dead = False
  Pacman.Lives = Pacman.Lives - 1
  
  ' copy pacman data into a tempvariable while the other player plays
  PacmanBackUp(Game.CurrentPlay) = Pacman
  
  
  ' if there are 2 players, then memorize the map and swap it with the other player
  If Game.Players = 2 Then ' 2 player game
    ' check if other player stills has some lives left
    If PacmanBackUp(1 - Game.CurrentPlay).Lives > 0 Then
      ' player does so swap the levels around
      For j = 0 To 30
        For i = 0 To 27
          With PacLevel(i, j)
            TempVar = .MemPlay ' swap the level info with the other player
            .MemPlay = .Block
            .Block = TempVar
          End With
        Next
      Next
      RefreshLevel ' redraw the level
      Game.CurrentPlay = 1 - Game.CurrentPlay ' swap players here
      Pacman = PacmanBackUp(Game.CurrentPlay)
      If PacmanBackUp(Game.CurrentPlay).FirstGo Then
        Initialize
        Exit Sub
      End If
    End If
  End If
  
  If Pacman.Lives < 1 Then
    Game.Started = False
    pctScreen.Visible = False
    tmrKeyBoard.Enabled = False
    pctStats.Cls
    lblKeys.Visible = True
    tmrPookie.Enabled = True
    tmrFlash.Enabled = True
    Exit Sub
  End If
  
  ShowLives
  AddScore 0 ' update score
  DefaultPositions
  PlayIntro


End Sub

Private Sub tmrPookie_Timer()

  ' random pretty colours :)
  lblPookie.ForeColor = RGB(Rnd * 255, Rnd * 255, Rnd * 255)

End Sub

Sub PlayIntro()

  tmrKeyBoard.Enabled = False
  lblReady.ForeColor = vbYellow
  tmrReady.Enabled = True

End Sub

Private Sub tmrReady_Timer()

  Static Counter As Long
  Dim waittime As Integer
  
  If Pacman.FirstGo = True Then
    waittime = 9 ' wait for music to stop
  Else
    waittime = 6 ' three flashes of the 'ready'
  End If
  
  Counter = Counter + 1
  If Counter = waittime Then
    lblReady.Caption = ""
    lblPlayer.Caption = ""
    lblReady.Refresh
    Counter = 0
    tmrReady.Enabled = False
    tmrKeyBoard.Enabled = True
  End If
  
  If (Counter And 1) = 1 Then
    lblReady.Caption = "READY!"
    If Game.Players = 2 Then
      lblPlayer.Caption = "PLAYER " & CStr(Game.CurrentPlay + 1)
    End If
  Else
    lblReady.Caption = ""
    lblPlayer.Caption = ""
  End If
  lblReady.Refresh
  
End Sub

Private Sub StartMusic()

  ' select which music to play
  If Game.Enhanced Then
    sndPlay "startMusic", SoundOps.SND_ASYNC
  Else
    sndPlay "startMusicold", SoundOps.SND_ASYNC
  End If
  
End Sub
