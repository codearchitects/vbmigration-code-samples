' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmPacMan

	Private Sub Form_Load() Handles MyBase.Load
		
		' UPGRADE_INFO (#0181): Reference to default form instance 'frmPacMan' was converted to Me keyword.
		Me.Show()
		DoEvents6()
		
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

	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		
		' if eacape is pressed, exit
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyEscape Then 
			shutdown()
			Application.Exit(): End
		End If
		
		' flip between enhanced pics or original
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyE And Game.Started = False Then 
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
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyS And Game.Started = False Then 
			Game.Speed *= 2
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
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyI And Game.Coins < 99 Then 
			Game.Coins += 1
			sndPlay("fruiteat", SoundOps.SND_ASYNC)
			ShowCoins()
		End If
		
		' 1 player game
		If KeyCode = VBRUN.KeyCodeConstants.vbKey1 And Game.Coins > 0 And Game.Started = False Then 
			Game.Coins -= 1
			Game.Players = 1
			ShowCoins()
			Initialize()
			Game.Started = True
		End If
		
		' 2 player game
		If KeyCode = VBRUN.KeyCodeConstants.vbKey2 And Game.Coins > 1 And Game.Started = False Then 
			Game.Coins -= 2
			Game.Players = 2
			Game.CurrentPlay = 0 ' player 1
			PacmanBackUp(1).Lives = 3 ' make sure player 2 has some lives...
			PacmanBackUp(1).FirstGo = True
			ShowCoins()
			Initialize()
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
		lblHiscore.Refresh()
		lblScore.Refresh()
		Pacman.FirstGo = True
		
		If Game.Enhanced = True Then 
			' UPGRADE_INFO (#0181): Reference to default form instance 'frmPacMan' was converted to Me keyword.
			Me.pctTiles.Picture = LoadPicture6(App6.Path & "/pacpics.bmp")
		Else
			' UPGRADE_INFO (#0181): Reference to default form instance 'frmPacMan' was converted to Me keyword.
			Me.pctTiles.Picture = LoadPicture6(App6.Path & "/pacpicsold.bmp")
		End If
		
		' Reset the level and fill it full of dots
		ResetLevel()
		' Reset the positions of everthing
		DefaultPositions()
		
		' Display how many lives and level number
		ShowLives()
		
		' play opening music
		StartMusic()
		PlayIntro()

	End Sub

	Private Sub tmrFlash_Timer() Handles tmrFlash.Timer
		
		Static flipflop As Boolean
		
		flipflop = Not flipflop
		
		' this flashes the insert coin label
		If flipflop Then 
			lblInsert.ForeColor = Color.Black 
		Else
			lblInsert.ForeColor = Color.White 
		End If
		
	End Sub

	Private Sub tmrKeyBoard_Timer() Handles tmrKeyBoard.Timer
		
		Dim nLoop As Short
		Dim Px As Short
		Dim Py As Short
		
		' Test and Move Pacman
		PacmanMovement()
		' Test and Move Ghosts
		AIGhostMonsters()
		' Test for any collisions
		TestCollisions()
		
		' Move all sprites from the screen
		HideSprites()
		
		' Check if fruit has been eaten, if so, remove it from the screen
		If Pacman.TimeCount = 5000 / Game.Speed Or (Pacman.TimeCount >= 4000 / Game.Speed And Pacman.FruitHere = False And Pacman.FruitGone = False) Then 
			HideBlit(216, 264, 5)
			Pacman.FruitGone = True
		End If
		
		' Internal time count to know when to display the fruit and to remove it again
		Pacman.TimeCount += 1
		
		' If pacman dies, then exit sub while all the spite have been hidden
		If Pacman.Dead Then  PacDied(): Exit Sub

		' if all dots have been eaten, go to next level
		If Pacman.DotsLeft < 1 Then 
			Pacman.TimeCount = 0 ' reset internal counter
			Pacman.Level += 1
			Pacman.FirstGo = True ' allow for music to play again
			If Pacman.Level > 8 Then  Pacman.Level = 8
			AddScore(1000)
			ShowLives()
			ResetLevel()
			DefaultPositions()
			StartMusic()
			PlayIntro()
			Exit Sub
		End If

		' If dot has been eaten, delete it from the screen
		If Pacman.DotGone Then 
			Px = (Sprite(0).OXpos + XD(Pacman.Direction) * 16) + 8
			Py = (Sprite(0).OYpos + YD(Pacman.Direction) * 16) + 8
			BitBlt(pctScreen.hDC, Px, Py, 16, 16, pctpicture.hDC, Px, Py, BitbltOps.SRCCOPY)
			pctScreen.ReleaseHdc()
			pctpicture.ReleaseHdc()
		End If
		
		' This puts the fruit on the screen
		If Pacman.TimeCount = 4000 / Game.Speed Then 
			ShowBlit(216, 264, ((Pacman.Level - 1) Mod 4) * 32, ((Pacman.Level - 1) \ 4) * 32 + 256, 5)
			Pacman.FruitHere = True
			Pacman.FruitGone = False
		End If
		
		' Show all sprites
		ShowSprites()
		pctScreen.Refresh()

	End Sub

	Public Sub PacDied()
		
		Dim i As Short
		Dim j As Short
		Dim TempVar As Short
		
		Pacman.Dead = False
		Pacman.Lives -= 1
		
		' copy pacman data into a tempvariable while the other player plays
		PacmanBackUp(Game.CurrentPlay) = Pacman

		' if there are 2 players, then memorize the map and swap it with the other player
		If Game.Players = 2 Then  ' 2 player game
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
				RefreshLevel() ' redraw the level
				Game.CurrentPlay = 1 - Game.CurrentPlay ' swap players here
				Pacman = PacmanBackUp(Game.CurrentPlay)
				If PacmanBackUp(Game.CurrentPlay).FirstGo Then 
					Initialize()
					Exit Sub
				End If
			End If
		End If
		
		If Pacman.Lives < 1 Then 
			Game.Started = False
			pctScreen.Visible = False
			tmrKeyBoard.Enabled = False
			pctStats.Cls()
			lblKeys.Visible = True
			tmrPookie.Enabled = True
			tmrFlash.Enabled = True
			Exit Sub
		End If
		
		ShowLives()
		AddScore(0) ' update score
		DefaultPositions()
		PlayIntro()

	End Sub

	Private Sub tmrPookie_Timer() Handles tmrPookie.Timer
		
		' random pretty colours :)
		lblPookie.ForeColor = FromOleColor6(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
		
	End Sub

	Public Sub PlayIntro()
		
		tmrKeyBoard.Enabled = False
		lblReady.ForeColor = Color.Yellow 
		tmrReady.Enabled = True
		
	End Sub

	Private Sub tmrReady_Timer() Handles tmrReady.Timer
		
		Static Counter As Integer
		Dim waittime As Short
		
		If Pacman.FirstGo = True Then 
			waittime = 9 ' wait for music to stop
		Else
			waittime = 6 ' three flashes of the 'ready'
		End If
		
		Counter += 1
		If Counter = waittime Then 
			lblReady.Caption = ""
			lblPlayer.Caption = ""
			lblReady.Refresh()
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
		lblReady.Refresh()
		
	End Sub

	Private Sub StartMusic()
		
		' select which music to play
		If Game.Enhanced Then 
			sndPlay("startMusic", SoundOps.SND_ASYNC)
		Else
			sndPlay("startMusicold", SoundOps.SND_ASYNC)
		End If
		
	End Sub

End Class
