Attribute VB_Name = "basSetUp"
Option Explicit

Public Enum BitbltOps   ' For bitblt function
    SRCCOPY = &HCC0020  ' Dest = Source
     SRCAND = &H8800C6  ' Dest = Dest AND Source
  SRCINVERT = &H660046  ' Dest = Dest XOR Source
   SRCPAINT = &HEE0086  ' Dest = Dest OR  Source
   SRCERASE = &H4400328 ' Dest = (XOR Dest) AND Source
  WHITENESS = &HFF0062  ' Dest = vbWhite
  BLACKNESS = &H42      ' Dest = vbBlack
End Enum

Public Enum SoundOps
       SND_SYNC = &H0
      SND_ASYNC = &H1
  SND_NODEFAULT = &H2
       SND_LOOP = &H8
     SND_NOSTOP = &H10
      SND_PURGE = &H40
     SND_NOWAIT = &H2000
End Enum

' pac is a simple enumerated variable to tell what each square is in the level
Public Enum Pac
  Wall = -1
  Blank = 0
  Pill = 1
  PowerPill = 2
End Enum

' paclevel is an array which holds all the data for the level in it
Public Type UDTPacLevel
  Junction    As Boolean ' If a junction is here
  JUp         As Boolean ' if Ghost can move up at this junction
  JDown       As Boolean ' if Ghost can move down at this junction
  Jleft       As Boolean ' if Ghost can move left at this junction
  Jright      As Boolean ' if Ghost can move right at this junction
  Block       As Integer ' block type ( pac enum)
  MemPlay     As Integer
End Type


Public Type UDTGhost
  InGame      As Boolean ' if ghost is in the game (true) or in the box (false)
  Eyesonly    As Boolean ' if ghost is eyes only (true)
  Xpos        As Integer ' x position of the ghost
  Ypos        As Integer ' y position of the ghost
  Direction   As Integer ' direction the ghost is currently moving
  Offset      As Integer ' y offset until the next square to be flush with it
  Xcounter    As Integer ' not used
  Ycounter    As Integer ' counts how many times ghost has bounced up and down in the box
  Speed       As Integer ' speed the ghost moves at
  PPTimer     As Integer ' how long the ghost stays in eaten mode for
  DelayTime   As Integer ' this is to slow the ghost down in eaten mode by half
End Type

Public Type UDTSprites
  OXpos       As Integer ' old x position
  OYpos       As Integer ' old y position
  NXpos       As Integer ' new x position
  NYpos       As Integer ' new y position
  XSprite     As Integer ' with pcttiles, know where it's X position is
  YSprite     As Integer ' with pcttiles, know where it's Y position is
End Type

Public Type UDTPacman
  FruitHere   As Boolean ' if fruit is on the screen or not
  FruitGone   As Boolean ' if fruit has been eaten or not
  Dead        As Boolean ' if pacman is dead or not
  DotGone     As Boolean ' if a dot has been eaten
  FirstGo     As Boolean ' If it's the first go, play the music
  Score       As Long    ' his score
  TimeCount   As Long    ' counter for checking when to put and hide the fruit
  Xpos        As Integer ' x position of pacman
  Ypos        As Integer ' y position of pacman
  Lives       As Integer ' how many lives he has
  Direction   As Integer ' the direction he is going in
  Offset      As Integer '
  Speed       As Integer ' speed pacman is moving at
  Level       As Integer ' level pacman is on
  GhostsEaten As Integer ' count how many ghosts he has eaten with one powerpill
  FlashOkay   As Integer ' ghosts will flash when eaten mode is nearly finished
  DotsLeft    As Integer ' keep track of how many dots left in the game
  Mouth       As Integer ' which mouth sprite to use
  MouthDir    As Integer ' tracks if mouth is now opening or shutting
  MouthSpeed  As Integer ' delay in how long each frame runs for
End Type

Public Type UDTGame
  Enhanced    As Boolean ' If pacman is in enhanced graphics mode or not
  HiScore     As Long    ' the current hiscore
  Coins       As Integer ' how much money can I make. :)
  Players     As Integer ' how many players
  CurrentPlay As Integer ' Which player is now playing the game
  Speed       As Integer ' Speed of the game. >:)
  Started     As Boolean ' if game is in progress or not
  Cheat       As Boolean
End Type

' set up the User Defined Type Variables
Public Pacman           As UDTPacman
Public Ghost(1 To 4)    As UDTGhost
Public Sprite(4)        As UDTSprites
Public PacLevel(27, 33) As UDTPacLevel
Public Game             As UDTGame
Public PacmanBackUp(1)  As UDTPacman

' set up some game arrays
Public Rev(3)           As Integer ' Reverse direction number
Public XD(3)            As Integer ' Holds the X directions
Public YD(3)            As Integer ' Holds the Y directions
Public GhostEat(4)      As Long    ' Holds the bonus points for each ghost eaten
Public OffDir(3)        As Integer

' declare some functions :)
Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal lpszSoundName As String, ByVal uFlags As Long) As Long
Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hSrcDC As Long, ByVal xSrc As Long, ByVal ySrc As Long, ByVal dwRop As Long) As Long



' -----------------------------------------------------------------------------------------


' miscellaneous subroutines

Sub ShowLives()

  Dim nLoop     As Integer ' number loop
  Dim Xo        As Integer ' X offset of fruit
  Dim Yo        As Integer ' Y offset of fruit
  
  With frmPacMan
    
    ' clear the stats picturebox
    .pctStats.Cls
    
    ' display all the pacmen
    For nLoop = 1 To Pacman.Lives - 1
      BitBlt .pctStats.hDC, nLoop * 32 - 32, 0, 32, 32, .pctTiles.hDC, 96, 224, BitbltOps.SRCCOPY
    Next
    
    ' display all the fruit as to which level pacman is up to
    For nLoop = 0 To Pacman.Level - 1
      Xo = Int(nLoop Mod 4) * 32
      Yo = Int(nLoop / 4) * 32 + 256
      BitBlt .pctStats.hDC, 416 - nLoop * 32, 0, 32, 32, .pctTiles.hDC, Xo, Yo, BitbltOps.SRCCOPY
    Next
    frmPacMan.pctStats.Refresh
  
  End With
  
End Sub

Sub ResetLevel()

  Dim i             As Integer ' x loop
  Dim j             As Integer ' y loop
  Dim strData(30)   As String  ' level data strings
  Dim ju            As Integer ' junction binary number for working out directions
  
  ' load the walls pills and powerpills into an array via strings
   strData(0) = "WWWWWWWWWWWWWWWWWWWWWWWWWWWW"
   strData(1) = "W............WW............W"
   strData(2) = "W.WWWW.WWWWW.WW.WWWWW.WWWW.W"
   strData(3) = "WoWWWW.WWWWW.WW.WWWWW.WWWWoW"
   strData(4) = "W.WWWW.WWWWW.WW.WWWWW.WWWW.W"
   strData(5) = "W..........................W"
   strData(6) = "W.WWWW.WW.WWWWWWWW.WW.WWWW.W"
   strData(7) = "W.WWWW.WW.WWWWWWWW.WW.WWWW.W"
   strData(8) = "W......WW....WW....WW......W"
   strData(9) = "WWWWWW.WWWWW WW WWWWW.WWWWWW"
  strData(10) = "     W.WWWWW WW WWWWW.W     "
  strData(11) = "     W.WW          WW.W     "
  strData(12) = "     W.WW WWWWWWWW WW.W     "
  strData(13) = "WWWWWW.WW W      W WW.WWWWWW"
  strData(14) = "      .   W      W   .      "
  strData(15) = "WWWWWW.WW W      W WW.WWWWWW"
  strData(16) = "     W.WW WWWWWWWW WW.W     "
  strData(17) = "     W.WW          WW.W     "
  strData(18) = "     W.WW WWWWWWWW WW.W     "
  strData(19) = "WWWWWW.WW WWWWWWWW WW.WWWWWW"
  strData(20) = "W............WW............W"
  strData(21) = "W.WWWW.WWWWW.WW.WWWWW.WWWW.W"
  strData(22) = "W.WWWW.WWWWW.WW.WWWWW.WWWW.W"
  strData(23) = "Wo..WW.......  .......WW..oW"
  strData(24) = "WWW.WW.WW.WWWWWWWW.WW.WW.WWW"
  strData(25) = "WWW.WW.WW.WWWWWWWW.WW.WW.WWW"
  strData(26) = "W......WW....WW....WW......W"
  strData(27) = "W.WWWWWWWWWW.WW.WWWWWWWWWW.W"
  strData(28) = "W.WWWWWWWWWW.WW.WWWWWWWWWW.W"
  strData(29) = "W..........................W"
  strData(30) = "WWWWWWWWWWWWWWWWWWWWWWWWWWWW"
 
  
  Pacman.DotsLeft = 0 ' set the counter to 0
  
  ' extra the walls, pills and powerpills from the string
  For j = 0 To 30
    For i = 0 To 27
      With PacLevel(i, j)
        Select Case Mid(strData(j), i + 1, 1)
          Case "W"
            .Block = Pac.Wall
          Case "."
            .Block = Pac.Pill
            Pacman.DotsLeft = Pacman.DotsLeft + 1
          Case "o"
            .Block = Pac.PowerPill
            Pacman.DotsLeft = Pacman.DotsLeft + 1
        End Select
      End With
    Next
  Next
   
  ' calc all the junctions in the game in the loop-up table so that
  ' the program doesn't have to keep calculating it
  For j = 1 To 29
    For i = 1 To 26
      ju = 0
      With PacLevel(i, j)
        
        If .Block <> Pac.Wall Then
          If PacLevel(i, j - 1).Block <> Pac.Wall Then ju = ju Or 1: .JUp = True
          If PacLevel(i, j + 1).Block <> Pac.Wall Then ju = ju Or 2: .JDown = True
          If PacLevel(i - 1, j).Block <> Pac.Wall Then ju = ju Or 4: .Jleft = True
          If PacLevel(i + 1, j).Block <> Pac.Wall Then ju = ju Or 8: .Jright = True
          
          If ju < 5 Or ju = 8 Or ju = 12 Then
            .Junction = False ' delete straights & dead ends
          Else
            .Junction = True
          End If
        End If
      End With
    Next
  Next
  
  ' draw all the dots
  RefreshLevel
  
End Sub


Sub ShowBlit(ByVal X As Integer, ByVal Y As Integer, _
               ByVal XP As Integer, ByVal YP As Integer, ByVal pos As Integer)

  Dim maskOffset As Integer
  
  With frmPacMan

    ' copy info behind the sprite into a buffer
    BitBlt .pctBack.hDC, 0, pos * 32, 32, 32, .pctScreen.hDC, X, Y, BitbltOps.SRCCOPY
  
    If pos = 0 Or pos = 5 Then ' pacman or fruit only
      maskOffset = XP + 128
    Else
      If Ghost(pos).Eyesonly = False Then
        maskOffset = 192 ' normal ghost mask
      Else
        maskOffset = 224 ' eyes mask
      End If
    End If
    
    BitBlt .pctScreen.hDC, X, Y, 32, 32, .pctTiles.hDC, maskOffset, YP, BitbltOps.SRCAND
    BitBlt .pctScreen.hDC, X, Y, 32, 32, .pctTiles.hDC, XP, YP, BitbltOps.SRCPAINT
  
  End With

End Sub

Sub HideBlit(X As Integer, Y As Integer, pos As Integer)

  With frmPacMan
    ' restore the background from under the sprite
    BitBlt .pctScreen.hDC, X, Y, 32, 32, .pctBack.hDC, 0, pos * 32, BitbltOps.SRCCOPY

  End With
  
End Sub

Sub DefaultPositions()
  
  With Pacman
    .Xpos = 224
    .Ypos = 376
    .Direction = 3
    .Offset = 8
    .Speed = Game.Speed
    .Mouth = 0
    .MouthDir = 1
    .MouthSpeed = 0
    ShowBlit .Xpos - 16, .Ypos - 16, .Direction * 32, 7 * 32, 0
  End With
  
  With Ghost(1) ' outside the starting box
    .Xpos = 224
    .Ypos = 184
    .Direction = 2 + Rnd
    .Offset = 8
    .Speed = Game.Speed
    .InGame = False
    .Eyesonly = False
    .PPTimer = 0
    ShowBlit .Xpos - 16, .Ypos - 16, 0, .Direction * 32, 1
  End With
  
  With Ghost(2) ' inside starting box on the left
    .Xpos = 192
    .Ypos = 224
    .Direction = 0
    .Offset = 8
    .InGame = False
    .Eyesonly = False
    .Ycounter = 0
    .Speed = Game.Speed
    .PPTimer = 0
    ShowBlit .Xpos - 16, .Ypos - 16, 32, .Direction * 32, 2
  End With
  
  With Ghost(3) ' inside middle
    .Xpos = 224
    .Ypos = 240
    .Direction = 1
    .Offset = 8
    .InGame = False
    .Eyesonly = False
    .Ycounter = 0
    .Speed = Game.Speed
    .PPTimer = 0
    ShowBlit .Xpos - 16, .Ypos - 16, 64, .Direction * 32, 3
  End With
  
  With Ghost(4) ' inside right
    .Xpos = 256
    .Ypos = 224
    .Direction = 0
    .Offset = 0
    .InGame = False
    .Eyesonly = False
    .Ycounter = 0
    .Speed = Game.Speed
    .PPTimer = 0
    ShowBlit .Xpos - 16, .Ypos - 16, 96, .Direction * 32, 4
  End With
  
  frmPacMan.pctScreen.Refresh
  
End Sub

Sub sndPlay(strName As String, sndType As Long)

 ' plays a sound. :O
 sndPlaySound App.Path & "/" & strName & ".wav", sndType

End Sub


Sub HideSprites()
  
  Dim nLoop As Integer
  ' remove all sprites from the screen in reverse order
  For nLoop = 4 To 0 Step -1
    With Sprite(nLoop)
      HideBlit .OXpos, .OYpos, nLoop
    End With
  Next
    
End Sub

Sub ShowSprites()

  Dim nLoop As Integer
  
  ' loop the flash variable to make ghosts flash when about to finish ghost eaten phase
  Pacman.FlashOkay = (Pacman.FlashOkay + 1) Mod 16

  With Sprite(0)
    ShowBlit .NXpos, .NYpos, .XSprite, .YSprite, 0 ' show pacman
  End With
  
  For nLoop = 1 To 4
    With Sprite(nLoop)
      
      If Ghost(nLoop).PPTimer > 0 Then ' if ghost in eaten mode
        ' if pptimer < 200 then ghost will 'flash' to say time is running out
        If (Ghost(nLoop).PPTimer < 200 / Game.Speed _
        And Pacman.FlashOkay > 7) _
        Or Ghost(nLoop).PPTimer >= 200 / Game.Speed Then
          
          .XSprite = 128 ' 128 is the blue ghost pic, only show it when in
          ' eaten mode and when not flashing it's normal colour
        
        End If
      
      End If
      
      ShowBlit .NXpos, .NYpos, .XSprite, .YSprite, nLoop ' draw the ghost
    End With
  Next

End Sub

Sub TestCollisions()

  Dim Px      As Integer
  Dim Py      As Integer
  Dim nLoop   As Integer
  
  Px = Pacman.Xpos
  Py = Pacman.Ypos
  
  For nLoop = 1 To 4
    With Ghost(nLoop)
    If Abs(Px - .Xpos) < 16 And Abs(Py - .Ypos) < 16 Then
      If .PPTimer > 0 Then ' ghost is in being eaten mode
        sndPlay "ghosteat", SoundOps.SND_ASYNC
        Pacman.GhostsEaten = Pacman.GhostsEaten + 1
        AddScore GhostEat(Pacman.GhostsEaten)
        .Eyesonly = True ' ghost turns to eyes
        .PPTimer = 0 ' ghost can't be in eaten mode anymore
        .Speed = .Speed * 2 ' speed ghost up
        ' now make sure the ghosts keep on the tracks :)
        ' as speeding up the ghosts, they need to be correctly aligned with the grid
        ' otherwise they will go though walls! :(
        Select Case Game.Speed
          Case 1
            .Offset = .Offset And 4094
            .Xpos = .Xpos And 4094
            .Ypos = .Ypos And 4094
          Case 2
          .Offset = .Offset And 4092
          .Xpos = .Xpos And 4092
          .Ypos = .Ypos And 4092
          Case 4
            .Offset = .Offset And 4088
            .Xpos = .Xpos And 4088
            .Ypos = .Ypos And 4088
        End Select
      Else
        ' if pac hits ghosts and ghost is normal then pac dies :..O
        If .Eyesonly = False And Pacman.Dead = False Then
          If Game.Cheat = False Then
            Pacman.Dead = True
            sndPlay "killed", SoundOps.SND_SYNC
          End If
        End If
      End If
    End If
    If .Eyesonly Then Sprite(nLoop).XSprite = 160 ' change sprite to eyes only
    End With
  Next
  
  ' see if pacman can eat some fruit in the middle of the map
  If Pacman.FruitHere = True _
  And Pacman.FruitGone = False _
  And Abs(Pacman.Xpos - 232) < 16 _
  And Pacman.Ypos = 280 Then
    
    Pacman.FruitHere = False ' stop pac from eating the fruit again for this level
    AddScore 500 * Pacman.Level
    sndPlay "Fruiteat", SoundOps.SND_ASYNC
  
  End If

End Sub

Sub AddScore(addTo As Long)

  Pacman.Score = Pacman.Score + addTo
  
  If Pacman.Score >= 10000 And Pacman.Score - addTo < 10000 Then
    ExtraLife
  End If
  
  If Pacman.Score >= 50000 And Pacman.Score - addTo < 50000 Then
    ExtraLife
  End If
  
  If Pacman.Score >= 100000 And Pacman.Score - addTo < 100000 Then ' As if. :)
    ExtraLife
  End If
  
  ' update the score and hiscore labels
  With frmPacMan
    .lblScore.Caption = Pacman.Score
    If Pacman.Score > Game.HiScore Then
      Game.HiScore = Pacman.Score
      .lblHiscore.Caption = Pacman.Score
    End If
  End With
  
End Sub

Sub ExtraLife()

  ' yay
  Pacman.Lives = Pacman.Lives + 1
  sndPlay "extralife", SoundOps.SND_ASYNC
  ShowLives
  
End Sub

Sub shutdown()
  
  ' boo
  Unload frmPacMan
  End

End Sub

Sub RefreshLevel()

  Dim i As Integer
  Dim j As Integer

  If Game.Enhanced = True Then
    ' later on, Need to change the number so each level has a new back ground pic
    frmPacMan.pctScreen.Picture = LoadPicture(App.Path & "/level1.bmp")
  Else
    frmPacMan.pctScreen.Picture = LoadPicture(App.Path & "/levelold.bmp")
  End If
  
  frmPacMan.pctpicture.Picture = frmPacMan.pctScreen.Picture ' keep a copy of the picture
  
  ' draw all the dots and powerpills on the screen
  For j = 1 To 29
    For i = 1 To 26
      With PacLevel(i, j)
       
        If .Block = Pac.Pill Then ' draws a pill on the screen
          BitBlt frmPacMan.pctScreen.hDC, i * 16, j * 16, 16, 16, frmPacMan.pctTiles.hDC, 0, 320 + 16, BitbltOps.SRCAND
          BitBlt frmPacMan.pctScreen.hDC, i * 16, j * 16, 16, 16, frmPacMan.pctTiles.hDC, 0, 320, BitbltOps.SRCPAINT
        End If
        
        If .Block = Pac.PowerPill Then        ' draws a powerpill on the screen
          BitBlt frmPacMan.pctScreen.hDC, i * 16, j * 16, 16, 16, frmPacMan.pctTiles.hDC, 16, 320 + 16, BitbltOps.SRCAND
          BitBlt frmPacMan.pctScreen.hDC, i * 16, j * 16, 16, 16, frmPacMan.pctTiles.hDC, 16, 320, BitbltOps.SRCPAINT
        End If
      End With
    Next
  Next

End Sub

