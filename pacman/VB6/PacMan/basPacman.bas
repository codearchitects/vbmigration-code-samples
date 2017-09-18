Attribute VB_Name = "basPacman"
Option Explicit

Sub PacmanMovement()

  Dim HitWall As Boolean
  Dim nLoop As Integer
  Dim XD2 As Integer
  Dim YD2 As Integer
  
  ' make sure dotgone is turned off as pacman hasn't eaten any yet
  Pacman.DotGone = False
  
  ' the whole sub uses udt pacman
  With Pacman
  
    .FirstGo = False ' turn off the first go music
    ' memorize pacman's position
    Sprite(0).OXpos = .Xpos - 16
    Sprite(0).OYpos = .Ypos - 16
       
    ' Up
    If GetAsyncKeyState(vbKeyUp) And .Offset = 0 Then
      If PacLevel((.Xpos - 8) / 16, (.Ypos - 8) / 16 - 1).Block <> Pac.Wall Then
      .Direction = 0
      End If
    End If
    
    ' Down
    If GetAsyncKeyState(vbKeyDown) And .Offset = 0 Then
      If PacLevel((.Xpos - 8) / 16, (.Ypos - 8) / 16 + 1).Block <> Pac.Wall Then
      .Direction = 1
      End If
    End If
    
    ' Left
    If GetAsyncKeyState(vbKeyLeft) And .Offset = 0 Then
      If PacLevel((.Xpos - 8) / 16 - 1, (.Ypos - 8) / 16).Block <> Pac.Wall Then
      .Direction = 2
      End If
    End If
    
    ' Right
    If GetAsyncKeyState(vbKeyRight) And .Offset = 0 Then
      If PacLevel((.Xpos - 8) / 16 + 1, (.Ypos - 8) / 16).Block <> Pac.Wall Then
      .Direction = 3
      End If
    End If
    
    ' if HitWall=true then don't move pacman (ran into a wall)
    HitWall = False
    
    ' Xd2/YD2 holds the position of pacman
    XD2 = (Pacman.Xpos + XD(Pacman.Direction) * 16 - 8) / 16
    YD2 = (Pacman.Ypos + YD(Pacman.Direction) * 16 - 8) / 16
    
    ' If pacman is flush on a square (every 16 pixels)
    If .Offset = 0 Then
      Select Case PacLevel(XD2, YD2).Block
        Case Pac.Wall
          HitWall = True ' he has hit a wall so stop him from moving
        
        Case Pac.Pill
          .DotsLeft = .DotsLeft - 1
          PacLevel(XD2, YD2).Block = 0 ' remove the dot from the buffer
          sndPlay "eatpill", SoundOps.SND_ASYNC
          .DotGone = True ' tell the update to remove this dot later
          AddScore 10
        
        Case Pac.PowerPill
          .GhostsEaten = 0
          .DotsLeft = .DotsLeft - 1
          PacLevel(XD2, YD2).Block = 0 ' remove the powerpill from the buffer
          sndPlay "fruiteat", SoundOps.SND_ASYNC
          .DotGone = True ' tell the update to remove this powerpill later
          AddScore 10
          ' set up available ghosts into edible mode
          ' only ghosts who are ingame (not inside the ghost box) or
          ' not just eyes get turned into edible mode
          For nLoop = 1 To 4
            If Ghost(nLoop).Eyesonly = False And Ghost(nLoop).InGame Then
              Ghost(nLoop).PPTimer = (1000 - 100 * Pacman.Level) / Game.Speed ' shrinks with each level
              Ghost(nLoop).Direction = Rev(Ghost(nLoop).Direction)
            End If
          Next
      End Select
    End If
  
    ' move pacman if no wall in front of him
    If HitWall = False Then
        .Xpos = .Xpos + XD(.Direction) * .Speed
        .Ypos = .Ypos + YD(.Direction) * .Speed
        .Offset = (.Offset + OffDir(.Direction) * .Speed + 16) Mod 16
        If .Xpos > 416 Then .Xpos = .Xpos - 416
        If .Xpos < 16 Then .Xpos = .Xpos + 416
    End If
    
    ' animate his mouth every 5 frames
    .MouthSpeed = .MouthSpeed + 1
    If .MouthSpeed > 4 Then
      .Mouth = .Mouth + .MouthDir
      .MouthSpeed = 0
    End If
    If .Mouth > 2 Or .Mouth < 1 Then
      .MouthDir = -.MouthDir
    End If
  
  End With
  
  ' set up his sprite
  With Sprite(0)
    .NXpos = Pacman.Xpos - 16
    .NYpos = Pacman.Ypos - 16
    .XSprite = Pacman.Direction * 32
    .YSprite = Pacman.Mouth * 32 + 4 * 32
  End With
    
End Sub




