Attribute VB_Name = "basGhostAI"
Option Explicit

Sub AIGhostMonsters()

  Dim HitWall As Boolean
  Dim XD2 As Integer
  Dim YD2 As Integer
  Dim Xs2 As Integer
  Dim Ys2 As Integer
  Dim X As Integer
  Dim Y As Integer
  Dim back As Integer
  Dim nLoop As Integer
  Dim Px As Integer
  Dim Py As Integer
  
  ' loop through the four ghosts
  For nLoop = 1 To 4
  
    ' the whole sub uses the udt ghost(nloop)
    With Ghost(nLoop)
      
      ' Memorize the ghost position
      Sprite(nLoop).OXpos = .Xpos - 16
      Sprite(nLoop).OYpos = .Ypos - 16
           
      HitWall = False
    
      ' first look at the ghost if it's ingame or not
      ' if ingame = false the the ghost is still inside the box and needs
      ' to follow a different routine
      If .InGame = False Then
        
        If .Ypos = 224 Or .Ypos = 240 Then ' if ghost is at the top or bottom of the box
          If .Direction < 2 Then ' test if ghost is moving up/down and not left/right
            .Direction = 1 - .Direction ' reverse the ghost so that doesn't leave the box
            .Eyesonly = False ' turn off eyesonly if ghost had been enten before
          End If
        End If
        
        ' the ghost as to bounce up and down 2 times before allowing to leave the box
        If .Xpos = 224 And .Ypos = 224 Then ' ghost is at the top of the box
          .Ycounter = .Ycounter + 1
          If .Ycounter > 1 Then
            .Direction = 0 ' go up and out of the box instead of back down again
          End If
        End If
        
        If .Xpos = 192 And Ghost(3).InGame Then
          .Direction = 3 ' make left ghost move right towards the middle of the box
        End If
        
        If .Xpos = 256 And Ghost(2).InGame Then
          .Direction = 2 ' make the right ghost move left towards teh middle of the box
        End If
        
        If .Xpos = 224 And .Direction > 1 Then ' is a ghost moving towards the middle of the box?
          .Direction = 0 ' if ghost has reached the middle, make it move up and out of the box
        End If
        
        ' the ghost is now in the game so needs to set up it's coords
        If .Ypos = 184 Then
          .Offset = 8
          .Direction = 2 + Rnd
          .InGame = True
        End If
      End If
      
      ' this routine is for ghosts who are in the game only
      If .InGame = True Then
      
        ' Check if Ghost has returned to the box for renewal after been eaten by Pacman
        If .Xpos = 224 And .Ypos = 184 And .Eyesonly Then
          .Speed = .Speed / 2 ' slow ghost speed back to normal
          .InGame = False  ' ghost is not in the game anymore
          .Direction = 1   ' head down into the box for renewal
        End If
      
        ' test for dirs if ghost is flush on a square
        If .Offset = 0 Then
          X = .Xpos \ 16 ' ghost x pos
          Y = .Ypos \ 16 ' ghost y pos
          Px = Pacman.Xpos \ 16
          Py = Pacman.Ypos \ 16
          If nLoop = 2 Then ' ghost 2: he looks a bit ahead of where pacman is
            If Abs(Px - X) + Abs(Py - Y) > 2 Then
              Px = Px + XD(Pacman.Direction) * 4
              Py = Py + XD(Pacman.Direction) * 4
            End If
          End If
          If nLoop = 3 Then ' ghost 3: looks further ahead to where pacman is going
            If Abs(Px - X) + Abs(Py - Y) > 3 Then
              Px = Px + XD(Pacman.Direction) * 8
              Py = Py + XD(Pacman.Direction) * 8
            End If
          End If
          If nLoop = 4 Then ' ghost 4: looks the furtherest ahead
            If Abs(Px - X) + Abs(Py - Y) > 4 Then
              Px = Px + XD(Pacman.Direction) * 12
              Py = Py + XD(Pacman.Direction) * 12
            End If
          End If
        
          ' if ghost is eyesonly then make it head towards the top of the ghostbox
          ' instead of pacman
          If .Eyesonly Then
            Px = 224 \ 16
            Py = 184 \ 16
          End If
          
          ' if ghost has come across a junction ( T , L or Crossroad intersection)
          If PacLevel(X, Y).Junction Then
            XD2 = Abs(Px - X) ' distance from pac or ghostbox
            YD2 = Abs(Py - Y)
            Xs2 = Sgn(Px - X) ' direction from pac or ghostbox
            Ys2 = Sgn(Py - Y)
            
            ' if ghost is in being eaten mode, then reverse it's dirs so
            ' that it runs away instead of chasing!
            If .PPTimer > 0 Then
              Xs2 = -Xs2
              Ys2 = -Ys2
            End If
            
            ' make ghost hitwall for now, so it needs to look to see if it can move
            ' in another direction first
            HitWall = True
            
            ' back is the opp dir of where the ghost is heading, it's there so that
            ' the ghost doesn't back track on itself
            back = Rev(.Direction)
            
            ' first line of looking, basicly if pac is above move up, etc.
            If Ys2 < 0 And PacLevel(X, Y).JUp And back <> 0 Then .Direction = 0: HitWall = False
            If Ys2 > 0 And PacLevel(X, Y).JDown And back <> 1 Then .Direction = 1: HitWall = False
            If Xs2 < 0 And PacLevel(X, Y).Jleft And back <> 2 Then .Direction = 2: HitWall = False
            If Xs2 > 0 And PacLevel(X, Y).Jright And back <> 3 Then .Direction = 3: HitWall = False
          
            ' if a wall is where ghost wants to go, look to the sides
            If HitWall = True Then
              If Ys2 = 0 Then ' if pac is on the same Y as ghost
                If PacLevel(X, Y).JUp And back <> 0 Then .Direction = 0: HitWall = False
                If PacLevel(X, Y).JDown And back <> 1 Then .Direction = 1: HitWall = False
              End If
              If Xs2 = 0 Then ' if pac is on the same X as ghost
                If PacLevel(X, Y).Jleft And back <> 2 Then .Direction = 2: HitWall = False
                If PacLevel(X, Y).Jright And back <> 3 Then .Direction = 3: HitWall = False
              End If
            End If
            ' if a wall is still in front of where the ghost wishes to go
            ' then look for any other way to go besides back again
            If HitWall = True Then
              If PacLevel(X, Y).JUp And back <> 0 Then .Direction = 0: HitWall = False
              If PacLevel(X, Y).JDown And back <> 1 Then .Direction = 1: HitWall = False
              If PacLevel(X, Y).Jleft And back <> 2 Then .Direction = 2: HitWall = False
              If PacLevel(X, Y).Jright And back <> 3 Then .Direction = 3: HitWall = False
            End If
          End If
        End If
      End If
      
      ' A delay time of 1 is here incase the ghost is in eaten mode and so will
      ' move at half speed
      .DelayTime = 1 - .DelayTime
      If .PPTimer > 0 And .DelayTime = 0 Then
        HitWall = True ' turn off ghost move for this turn
      End If
      
      ' if ghost can move, move it
      If HitWall = False Then
        .Xpos = .Xpos + XD(.Direction) * .Speed
        .Ypos = .Ypos + YD(.Direction) * .Speed
        .Offset = (.Offset + OffDir(.Direction) * .Speed + 16) Mod 16
        If .Xpos > 416 Then .Xpos = .Xpos - 416
        If .Xpos < 16 Then .Xpos = .Xpos + 416
      End If
      
      ' if ghost is in eaten mode, then decease it's timer
      If .PPTimer > 0 Then
        .PPTimer = .PPTimer - 1
      End If
    
    End With
  
    ' set up the ghost sprites
    With Sprite(nLoop)
      .NXpos = Ghost(nLoop).Xpos - 16
      .NYpos = Ghost(nLoop).Ypos - 16
      .XSprite = (nLoop - 1) * 32
      .YSprite = Ghost(nLoop).Direction * 32
    End With
  
  Next nLoop
  

End Sub
