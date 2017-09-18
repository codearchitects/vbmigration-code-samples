' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class ServerFRM

	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
	'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
	'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'sorry the client frm is the one commented heavily commented on
	'didnt have time to comment both in depth
	
	'server frm tag is 1 and will be used in MENUFRM
	'client frm tag is 2 and will be used in menufrm
	Private daINDEX As Short
	Private isGAME As Short
	Private playerTURN As Short
	
	Private Sub battleshipLBL_Click() Handles battleshipLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag
		whichMNU = "battleship"
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 4800
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub CarrierLBL_Click() Handles CarrierLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag
		whichMNU = "carrier"
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 6360
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub CruiserLBL_Click() Handles CruiserLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag
		whichMNU = "cruiser"
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 3240
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub DestroyerLBL_Click() Handles DestroyerLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag
		whichMNU = "destroyer"
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 120
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub Field_Click(ByRef Index As Short)
		If ShiPcount < 6 Then 
			PlayWav("ff7-blip.wav")
			daINDEX = Field(Index).Index
			If WhiCHway = "ns" Then  'for north to south
				If whichMNU = "carrier" Then 
					If daINDEX + 80 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 60).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 80).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray : Field(daINDEX + 60).BackColor = Color.Gray : Field(daINDEX + 80).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("K" & daINDEX)
						CarrierLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "battleship" Then 
					If daINDEX + 60 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 60).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray : Field(daINDEX + 60).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("B" & daINDEX)
						battleshipLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "cruiser" Then 
					If daINDEX + 40 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("R" & daINDEX)
						CruiserLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "submarine" Then 
					If daINDEX + 20 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("S" & daINDEX)
						SubMarineLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "destroyer" Then 
					If daINDEX + 20 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("D" & daINDEX)
						DestroyerLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
			End If
			'==========================================================
			If WhiCHway = "lr" Then  'for left to right ship placement
				If whichMNU = "carrier" Then 
					If Field(daINDEX).Left > 5760 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 3).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 4).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray : Field(daINDEX + 3).BackColor = Color.Gray : Field(daINDEX + 4).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("I" & daINDEX)
						CarrierLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "battleship" Then 
					If Field(daINDEX).Left > 6120 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 3).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray : Field(daINDEX + 3).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("L" & daINDEX)
						battleshipLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "cruiser" Then 
					If Field(daINDEX).Left > 6480 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("U" & daINDEX)
						CruiserLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "submarine" Then 
					If Field(daINDEX).Left > 6840 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("E" & daINDEX)
						SubMarineLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
				If whichMNU = "destroyer" Then 
					If Field(daINDEX).Left > 6840 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN()
						Winsock.SendData("O" & daINDEX)
						DestroyerLBL.Enabled = False
						ShiPcount += 1
					End If
				End If
			End If
		End If
		'determines if game is to be started or not!
		' UPGRADE_INFO (#0561): The 'zZ' symbol was defined without an explicit "As" clause.
		Dim zZ As Object = Nothing
		If ShiPcount = 5 Then 
			ShiPcount = 10 'sets to 10 so it will skip over code above
			startgameTMR.Enabled = True
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
			For zZ = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
				Field(zZ).BackColor = Color.Navy 
			Next
			GameStatsLBL.Caption = "Waiting For Client To Finish..."
			playerTURN = "1" 'used to show whos turn it is
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
			For zZ = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
				Field(zZ).Enabled = False
			Next
			Exit Sub
		End If
		'=================================
		If playerTURN = "0" Then  Exit Sub 'this is the head on head part of game
		' UPGRADE_INFO (#0561): The 'Yq' symbol was defined without an explicit "As" clause.
		Dim Yq As Object = Nothing
		If ShiPcount = 10 Then 
			PlayWav("FF7-BLIP.wav")
			daINDEX = Field(Index).Index
			If Not Field(daINDEX).BackColor.Equals(Color.Navy) Then  Exit Sub 'checkes if already guessed
			If GetPictureHandle6(Field(daINDEX).Picture) = GetPictureHandle6(hitPIC.Picture) Then  Exit Sub
			playerTURN = "0"
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 5
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If carrierTXT(Yq).Text = daINDEX Then 
					Field(daINDEX).Picture = hitPIC.Picture
					Field(daINDEX).Refresh()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "C" & Yq)
					GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
					PlayWav("ARROW.wav")
					Exit Sub
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 4
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If battleshipTXT(Yq).Text = daINDEX Then 
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					Field(daINDEX).Refresh()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "B" & Yq)
					GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
					PlayWav("ARROW.wav")
					Exit Sub
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 3
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If cruiserTXT(Yq).Text = daINDEX Then 
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					Field(daINDEX).Refresh()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "R" & Yq)
					GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
					PlayWav("ARROW.wav")
					Exit Sub
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 2
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If destroyerTXT(Yq).Text = daINDEX Then 
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					Field(daINDEX).Refresh()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "D" & Yq)
					GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
					PlayWav("ARROW.wav")
					Exit Sub
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 2
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If submarineTXT(Yq).Text = daINDEX Then 
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					Field(daINDEX).Refresh()
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "S" & Yq)
					GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
					PlayWav("ARROW.wav")
					Exit Sub
				End If
			Next
			Winsock.SendData("M" & "Your Turn...") 'tells
			GameStatsLBL.Caption = nickCLIENT.Caption & "'s Turn..."
			Field(daINDEX).BackColor = Color.Lime  'miss
			PlayWav("you-lose.wav") 'plays a miss sound
		End If
		'=========================================
		
	End Sub

	Public Sub PUTlabelsIN()
		'put the color back to blue
		' UPGRADE_INFO (#0561): The 'Yp' symbol was defined without an explicit "As" clause.
		Dim Yp As Object = Nothing
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
		For Yp = 1 To 240
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
			If ToOleColor6(Field(Yp).BackColor) = &HFFFF% Then 
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
				Field(Yp).BackColor = Color.Navy 
			End If
		Next
		'puts the ships positions into labels
		If WhiCHway = "ns" Then  'for north to south label input
			If whichMNU = "carrier" Then  'for carrier
				If daINDEX > 0 Then 
					MYcarrierLBL(1).Caption = "A:" & daINDEX: MYcarrierLBL(2).Caption = "B:" & daINDEX: MYcarrierLBL(3).Caption = "C:" & daINDEX: MYcarrierLBL(4).Caption = "D:" & daINDEX: MYcarrierLBL(5).Caption = "E:" & daINDEX
				End If
				If daINDEX > 20 Then 
					MYcarrierLBL(1).Caption = "B:" & daINDEX - 20: MYcarrierLBL(2).Caption = "C:" & daINDEX - 20: MYcarrierLBL(3).Caption = "D:" & daINDEX - 20: MYcarrierLBL(4).Caption = "E:" & daINDEX - 20: MYcarrierLBL(5).Caption = "F:" & daINDEX - 20
				End If
				If daINDEX > 40 Then 
					MYcarrierLBL(1).Caption = "C:" & daINDEX - 40: MYcarrierLBL(2).Caption = "D:" & daINDEX - 40: MYcarrierLBL(3).Caption = "E:" & daINDEX - 40: MYcarrierLBL(4).Caption = "F:" & daINDEX - 40: MYcarrierLBL(5).Caption = "G:" & daINDEX - 40
				End If
				If daINDEX > 60 Then 
					MYcarrierLBL(1).Caption = "D:" & daINDEX - 60: MYcarrierLBL(2).Caption = "E:" & daINDEX - 60: MYcarrierLBL(3).Caption = "F:" & daINDEX - 60: MYcarrierLBL(4).Caption = "G:" & daINDEX - 60: MYcarrierLBL(5).Caption = "H:" & daINDEX - 60
				End If
				If daINDEX > 80 Then 
					MYcarrierLBL(1).Caption = "E:" & daINDEX - 80: MYcarrierLBL(2).Caption = "F:" & daINDEX - 80: MYcarrierLBL(3).Caption = "G:" & daINDEX - 80: MYcarrierLBL(4).Caption = "H:" & daINDEX - 80: MYcarrierLBL(5).Caption = "I:" & daINDEX - 80
				End If
				If daINDEX > 100 Then 
					MYcarrierLBL(1).Caption = "F:" & daINDEX - 100: MYcarrierLBL(2).Caption = "G:" & daINDEX - 100: MYcarrierLBL(3).Caption = "H:" & daINDEX - 100: MYcarrierLBL(4).Caption = "I:" & daINDEX - 100: MYcarrierLBL(5).Caption = "J:" & daINDEX - 100
				End If
				If daINDEX > 120 Then 
					MYcarrierLBL(1).Caption = "G:" & daINDEX - 120: MYcarrierLBL(2).Caption = "H:" & daINDEX - 120: MYcarrierLBL(3).Caption = "I:" & daINDEX - 120: MYcarrierLBL(4).Caption = "J:" & daINDEX - 120: MYcarrierLBL(5).Caption = "K:" & daINDEX - 120
				End If
				If daINDEX > 140 Then 
					MYcarrierLBL(1).Caption = "H:" & daINDEX - 140: MYcarrierLBL(2).Caption = "I:" & daINDEX - 140: MYcarrierLBL(3).Caption = "J:" & daINDEX - 140: MYcarrierLBL(4).Caption = "K:" & daINDEX - 140: MYcarrierLBL(5).Caption = "L:" & daINDEX - 140
				End If
			End If
			If whichMNU = "battleship" Then 
				If daINDEX > 0 Then 
					MYbattleshipLBL(1).Caption = "A:" & daINDEX: MYbattleshipLBL(2).Caption = "B:" & daINDEX: MYbattleshipLBL(3).Caption = "C:" & daINDEX: MYbattleshipLBL(4).Caption = "D:" & daINDEX
				End If
				If daINDEX > 20 Then 
					MYbattleshipLBL(1).Caption = "B:" & daINDEX - 20: MYbattleshipLBL(2).Caption = "C:" & daINDEX - 20: MYbattleshipLBL(3).Caption = "D:" & daINDEX - 20: MYbattleshipLBL(4).Caption = "E:" & daINDEX - 20
				End If
				If daINDEX > 40 Then 
					MYbattleshipLBL(1).Caption = "C:" & daINDEX - 40: MYbattleshipLBL(2).Caption = "D:" & daINDEX - 40: MYbattleshipLBL(3).Caption = "E:" & daINDEX - 40: MYbattleshipLBL(4).Caption = "F:" & daINDEX - 40
				End If
				If daINDEX > 60 Then 
					MYbattleshipLBL(1).Caption = "D:" & daINDEX - 60: MYbattleshipLBL(2).Caption = "E:" & daINDEX - 60: MYbattleshipLBL(3).Caption = "F:" & daINDEX - 60: MYbattleshipLBL(4).Caption = "G:" & daINDEX - 60
				End If
				If daINDEX > 80 Then 
					MYbattleshipLBL(1).Caption = "E:" & daINDEX - 80: MYbattleshipLBL(2).Caption = "F:" & daINDEX - 80: MYbattleshipLBL(3).Caption = "G:" & daINDEX - 80: MYbattleshipLBL(4).Caption = "H:" & daINDEX - 80
				End If
				If daINDEX > 100 Then 
					MYbattleshipLBL(1).Caption = "F:" & daINDEX - 100: MYbattleshipLBL(2).Caption = "G:" & daINDEX - 100: MYbattleshipLBL(3).Caption = "H:" & daINDEX - 100: MYbattleshipLBL(4).Caption = "I:" & daINDEX - 100
				End If
				If daINDEX > 120 Then 
					MYbattleshipLBL(1).Caption = "G:" & daINDEX - 120: MYbattleshipLBL(2).Caption = "H:" & daINDEX - 120: MYbattleshipLBL(3).Caption = "I:" & daINDEX - 120: MYbattleshipLBL(4).Caption = "J:" & daINDEX - 120
				End If
				If daINDEX > 140 Then 
					MYbattleshipLBL(1).Caption = "H:" & daINDEX - 140: MYbattleshipLBL(2).Caption = "I:" & daINDEX - 140: MYbattleshipLBL(3).Caption = "J:" & daINDEX - 140: MYbattleshipLBL(4).Caption = "K:" & daINDEX - 140
				End If
				If daINDEX > 160 Then 
					MYbattleshipLBL(1).Caption = "I:" & daINDEX - 160: MYbattleshipLBL(2).Caption = "J:" & daINDEX - 160: MYbattleshipLBL(3).Caption = "K:" & daINDEX - 160: MYbattleshipLBL(4).Caption = "L:" & daINDEX - 160
				End If
			End If
			If whichMNU = "cruiser" Then 
				If daINDEX > 0 Then 
					MYcruiserLBL(1).Caption = "A:" & daINDEX: MYcruiserLBL(2).Caption = "B:" & daINDEX: MYcruiserLBL(3).Caption = "C:" & daINDEX
				End If
				If daINDEX > 20 Then 
					MYcruiserLBL(1).Caption = "B:" & daINDEX - 20: MYcruiserLBL(2).Caption = "C:" & daINDEX - 20: MYcruiserLBL(3).Caption = "D:" & daINDEX - 20
				End If
				If daINDEX > 40 Then 
					MYcruiserLBL(1).Caption = "C:" & daINDEX - 40: MYcruiserLBL(2).Caption = "D:" & daINDEX - 40: MYcruiserLBL(3).Caption = "E:" & daINDEX - 40
				End If
				If daINDEX > 60 Then 
					MYcruiserLBL(1).Caption = "D:" & daINDEX - 60: MYcruiserLBL(2).Caption = "E:" & daINDEX - 60: MYcruiserLBL(3).Caption = "F:" & daINDEX - 60
				End If
				If daINDEX > 80 Then 
					MYcruiserLBL(1).Caption = "E:" & daINDEX - 80: MYcruiserLBL(2).Caption = "F:" & daINDEX - 80: MYcruiserLBL(3).Caption = "G:" & daINDEX - 80
				End If
				If daINDEX > 100 Then 
					MYcruiserLBL(1).Caption = "F:" & daINDEX - 100: MYcruiserLBL(2).Caption = "G:" & daINDEX - 100: MYcruiserLBL(3).Caption = "H:" & daINDEX - 100
				End If
				If daINDEX > 120 Then 
					MYcruiserLBL(1).Caption = "G:" & daINDEX - 120: MYcruiserLBL(2).Caption = "H:" & daINDEX - 120: MYcruiserLBL(3).Caption = "I:" & daINDEX - 120
				End If
				If daINDEX > 140 Then 
					MYcruiserLBL(1).Caption = "H:" & daINDEX - 140: MYcruiserLBL(2).Caption = "I:" & daINDEX - 140: MYcruiserLBL(3).Caption = "J:" & daINDEX - 140
				End If
				If daINDEX > 160 Then 
					MYcruiserLBL(1).Caption = "I:" & daINDEX - 160: MYcruiserLBL(2).Caption = "J:" & daINDEX - 160: MYcruiserLBL(3).Caption = "K:" & daINDEX - 160
				End If
				If daINDEX > 180 Then 
					MYcruiserLBL(1).Caption = "J:" & daINDEX - 180: MYcruiserLBL(2).Caption = "K:" & daINDEX - 180: MYcruiserLBL(3).Caption = "L:" & daINDEX - 180
				End If
			End If
			If whichMNU = "submarine" Then 
				If daINDEX > 0 Then 
					MYsubmarineLBL(1).Caption = "A:" & daINDEX: MYsubmarineLBL(2).Caption = "B:" & daINDEX
				End If
				If daINDEX > 20 Then 
					MYsubmarineLBL(1).Caption = "B:" & daINDEX - 20: MYsubmarineLBL(2).Caption = "C:" & daINDEX - 20
				End If
				If daINDEX > 40 Then 
					MYsubmarineLBL(1).Caption = "C:" & daINDEX - 40: MYsubmarineLBL(2).Caption = "D:" & daINDEX - 40
				End If
				If daINDEX > 60 Then 
					MYsubmarineLBL(1).Caption = "D:" & daINDEX - 60: MYsubmarineLBL(2).Caption = "E:" & daINDEX - 60
				End If
				If daINDEX > 80 Then 
					MYsubmarineLBL(1).Caption = "E:" & daINDEX - 80: MYsubmarineLBL(2).Caption = "F:" & daINDEX - 80
				End If
				If daINDEX > 100 Then 
					MYsubmarineLBL(1).Caption = "F:" & daINDEX - 100: MYsubmarineLBL(2).Caption = "G:" & daINDEX - 100
				End If
				If daINDEX > 120 Then 
					MYsubmarineLBL(1).Caption = "G:" & daINDEX - 120: MYsubmarineLBL(2).Caption = "H:" & daINDEX - 120
				End If
				If daINDEX > 140 Then 
					MYsubmarineLBL(1).Caption = "H:" & daINDEX - 140: MYsubmarineLBL(2).Caption = "I:" & daINDEX - 140
				End If
				If daINDEX > 160 Then 
					MYsubmarineLBL(1).Caption = "I:" & daINDEX - 160: MYsubmarineLBL(2).Caption = "J:" & daINDEX - 160
				End If
				If daINDEX > 180 Then 
					MYsubmarineLBL(1).Caption = "J:" & daINDEX - 180: MYsubmarineLBL(2).Caption = "K:" & daINDEX - 180
				End If
				If daINDEX > 200 Then 
					MYsubmarineLBL(1).Caption = "K:" & daINDEX - 200: MYsubmarineLBL(2).Caption = "L:" & daINDEX - 200
				End If
			End If
			If whichMNU = "destroyer" Then 
				If daINDEX > 0 Then 
					MYdestroyerLBL(1).Caption = "A:" & daINDEX: MYdestroyerLBL(2).Caption = "B:" & daINDEX
				End If
				If daINDEX > 20 Then 
					MYdestroyerLBL(1).Caption = "B:" & daINDEX - 20: MYdestroyerLBL(2).Caption = "C:" & daINDEX - 20
				End If
				If daINDEX > 40 Then 
					MYdestroyerLBL(1).Caption = "C:" & daINDEX - 40: MYdestroyerLBL(2).Caption = "D:" & daINDEX - 40
				End If
				If daINDEX > 60 Then 
					MYdestroyerLBL(1).Caption = "D:" & daINDEX - 60: MYdestroyerLBL(2).Caption = "E:" & daINDEX - 60
				End If
				If daINDEX > 80 Then 
					MYdestroyerLBL(1).Caption = "E:" & daINDEX - 80: MYdestroyerLBL(2).Caption = "F:" & daINDEX - 80
				End If
				If daINDEX > 100 Then 
					MYdestroyerLBL(1).Caption = "F:" & daINDEX - 100: MYdestroyerLBL(2).Caption = "G:" & daINDEX - 100
				End If
				If daINDEX > 120 Then 
					MYdestroyerLBL(1).Caption = "G:" & daINDEX - 120: MYdestroyerLBL(2).Caption = "H:" & daINDEX - 120
				End If
				If daINDEX > 140 Then 
					MYdestroyerLBL(1).Caption = "H:" & daINDEX - 140: MYdestroyerLBL(2).Caption = "I:" & daINDEX - 140
				End If
				If daINDEX > 160 Then 
					MYdestroyerLBL(1).Caption = "I:" & daINDEX - 160: MYdestroyerLBL(2).Caption = "J:" & daINDEX - 160
				End If
				If daINDEX > 180 Then 
					MYdestroyerLBL(1).Caption = "J:" & daINDEX - 180: MYdestroyerLBL(2).Caption = "K:" & daINDEX - 180
				End If
				If daINDEX > 200 Then 
					MYdestroyerLBL(1).Caption = "K:" & daINDEX - 200: MYdestroyerLBL(2).Caption = "L:" & daINDEX - 200
				End If
			End If
		End If
		If WhiCHway = "lr" Then  'for left to right label input
			If whichMNU = "carrier" Then 
				If daINDEX > 0 Then 
					MYcarrierLBL(1).Caption = "A:" & daINDEX: MYcarrierLBL(2).Caption = "A:" & daINDEX + 1: MYcarrierLBL(3).Caption = "A:" & daINDEX + 2: MYcarrierLBL(4).Caption = "A:" & daINDEX + 3: MYcarrierLBL(5).Caption = "A:" & daINDEX + 4
				End If
				If daINDEX > 20 Then 
					MYcarrierLBL(1).Caption = "B:" & daINDEX - 20: MYcarrierLBL(2).Caption = "B:" & daINDEX - 19: MYcarrierLBL(3).Caption = "B:" & daINDEX - 18: MYcarrierLBL(4).Caption = "B:" & daINDEX - 17: MYcarrierLBL(5).Caption = "B:" & daINDEX - 16
				End If
				If daINDEX > 40 Then 
					MYcarrierLBL(1).Caption = "C:" & daINDEX - 40: MYcarrierLBL(2).Caption = "C:" & daINDEX - 39: MYcarrierLBL(3).Caption = "C:" & daINDEX - 38: MYcarrierLBL(4).Caption = "C:" & daINDEX - 37: MYcarrierLBL(5).Caption = "C:" & daINDEX - 36
				End If
				If daINDEX > 60 Then 
					MYcarrierLBL(1).Caption = "D:" & daINDEX - 60: MYcarrierLBL(2).Caption = "D:" & daINDEX - 59: MYcarrierLBL(3).Caption = "D:" & daINDEX - 58: MYcarrierLBL(4).Caption = "D:" & daINDEX - 57: MYcarrierLBL(5).Caption = "D:" & daINDEX - 56
				End If
				If daINDEX > 80 Then 
					MYcarrierLBL(1).Caption = "E:" & daINDEX - 80: MYcarrierLBL(2).Caption = "E:" & daINDEX - 79: MYcarrierLBL(3).Caption = "E:" & daINDEX - 78: MYcarrierLBL(4).Caption = "E:" & daINDEX - 77: MYcarrierLBL(5).Caption = "E:" & daINDEX - 76
				End If
				If daINDEX > 100 Then 
					MYcarrierLBL(1).Caption = "F:" & daINDEX - 100: MYcarrierLBL(2).Caption = "F:" & daINDEX - 99: MYcarrierLBL(3).Caption = "F:" & daINDEX - 98: MYcarrierLBL(4).Caption = "F:" & daINDEX - 97: MYcarrierLBL(5).Caption = "F:" & daINDEX - 96
				End If
				If daINDEX > 120 Then 
					MYcarrierLBL(1).Caption = "G:" & daINDEX - 120: MYcarrierLBL(2).Caption = "G:" & daINDEX - 119: MYcarrierLBL(3).Caption = "G:" & daINDEX - 118: MYcarrierLBL(4).Caption = "G:" & daINDEX - 117: MYcarrierLBL(5).Caption = "G:" & daINDEX - 116
				End If
				If daINDEX > 140 Then 
					MYcarrierLBL(1).Caption = "H:" & daINDEX - 140: MYcarrierLBL(2).Caption = "H:" & daINDEX - 139: MYcarrierLBL(3).Caption = "H:" & daINDEX - 138: MYcarrierLBL(4).Caption = "H:" & daINDEX - 137: MYcarrierLBL(5).Caption = "H:" & daINDEX - 136
				End If
				If daINDEX > 160 Then 
					MYcarrierLBL(1).Caption = "I:" & daINDEX - 160: MYcarrierLBL(2).Caption = "I:" & daINDEX - 159: MYcarrierLBL(3).Caption = "I:" & daINDEX - 158: MYcarrierLBL(4).Caption = "I:" & daINDEX - 157: MYcarrierLBL(5).Caption = "I:" & daINDEX - 156
				End If
				If daINDEX > 180 Then 
					MYcarrierLBL(1).Caption = "J:" & daINDEX - 180: MYcarrierLBL(2).Caption = "J:" & daINDEX - 179: MYcarrierLBL(3).Caption = "J:" & daINDEX - 178: MYcarrierLBL(4).Caption = "J:" & daINDEX - 177: MYcarrierLBL(5).Caption = "J:" & daINDEX - 176
				End If
				If daINDEX > 200 Then 
					MYcarrierLBL(1).Caption = "K:" & daINDEX - 200: MYcarrierLBL(2).Caption = "K:" & daINDEX - 199: MYcarrierLBL(3).Caption = "K:" & daINDEX - 198: MYcarrierLBL(4).Caption = "K:" & daINDEX - 197: MYcarrierLBL(5).Caption = "K:" & daINDEX - 196
				End If
				If daINDEX > 220 Then 
					MYcarrierLBL(1).Caption = "L:" & daINDEX - 220: MYcarrierLBL(2).Caption = "L:" & daINDEX - 219: MYcarrierLBL(3).Caption = "L:" & daINDEX - 218: MYcarrierLBL(4).Caption = "L:" & daINDEX - 217: MYcarrierLBL(5).Caption = "L:" & daINDEX - 216
				End If
			End If
			If whichMNU = "battleship" Then 
				If daINDEX > 0 Then 
					MYbattleshipLBL(1).Caption = "A:" & daINDEX: MYbattleshipLBL(2).Caption = "A:" & daINDEX + 1: MYbattleshipLBL(3).Caption = "A:" & daINDEX + 2: MYbattleshipLBL(4).Caption = "A:" & daINDEX + 3
				End If
				If daINDEX > 20 Then 
					MYbattleshipLBL(1).Caption = "B:" & daINDEX - 20: MYbattleshipLBL(2).Caption = "B:" & daINDEX - 19: MYbattleshipLBL(3).Caption = "B:" & daINDEX - 18: MYbattleshipLBL(4).Caption = "B:" & daINDEX - 17
				End If
				If daINDEX > 40 Then 
					MYbattleshipLBL(1).Caption = "C:" & daINDEX - 40: MYbattleshipLBL(2).Caption = "C:" & daINDEX - 39: MYbattleshipLBL(3).Caption = "C:" & daINDEX - 38: MYbattleshipLBL(4).Caption = "C:" & daINDEX - 37
				End If
				If daINDEX > 60 Then 
					MYbattleshipLBL(1).Caption = "D:" & daINDEX - 60: MYbattleshipLBL(2).Caption = "D:" & daINDEX - 59: MYbattleshipLBL(3).Caption = "D:" & daINDEX - 58: MYbattleshipLBL(4).Caption = "D:" & daINDEX - 57
				End If
				If daINDEX > 80 Then 
					MYbattleshipLBL(1).Caption = "E:" & daINDEX - 80: MYbattleshipLBL(2).Caption = "E:" & daINDEX - 79: MYbattleshipLBL(3).Caption = "E:" & daINDEX - 78: MYbattleshipLBL(4).Caption = "E:" & daINDEX - 77
				End If
				If daINDEX > 100 Then 
					MYbattleshipLBL(1).Caption = "F:" & daINDEX - 100: MYbattleshipLBL(2).Caption = "F:" & daINDEX - 99: MYbattleshipLBL(3).Caption = "F:" & daINDEX - 98: MYbattleshipLBL(4).Caption = "F:" & daINDEX - 97
				End If
				If daINDEX > 120 Then 
					MYbattleshipLBL(1).Caption = "G:" & daINDEX - 120: MYbattleshipLBL(2).Caption = "G:" & daINDEX - 119: MYbattleshipLBL(3).Caption = "G:" & daINDEX - 118: MYbattleshipLBL(4).Caption = "G:" & daINDEX - 117
				End If
				If daINDEX > 140 Then 
					MYbattleshipLBL(1).Caption = "H:" & daINDEX - 140: MYbattleshipLBL(2).Caption = "H:" & daINDEX - 139: MYbattleshipLBL(3).Caption = "H:" & daINDEX - 138: MYbattleshipLBL(4).Caption = "H:" & daINDEX - 137
				End If
				If daINDEX > 160 Then 
					MYbattleshipLBL(1).Caption = "I:" & daINDEX - 160: MYbattleshipLBL(2).Caption = "I:" & daINDEX - 159: MYbattleshipLBL(3).Caption = "I:" & daINDEX - 158: MYbattleshipLBL(4).Caption = "I:" & daINDEX - 157
				End If
				If daINDEX > 180 Then 
					MYbattleshipLBL(1).Caption = "J:" & daINDEX - 180: MYbattleshipLBL(2).Caption = "J:" & daINDEX - 179: MYbattleshipLBL(3).Caption = "J:" & daINDEX - 178: MYbattleshipLBL(4).Caption = "J:" & daINDEX - 177
				End If
				If daINDEX > 200 Then 
					MYbattleshipLBL(1).Caption = "K:" & daINDEX - 200: MYbattleshipLBL(2).Caption = "K:" & daINDEX - 199: MYbattleshipLBL(3).Caption = "K:" & daINDEX - 198: MYbattleshipLBL(4).Caption = "K:" & daINDEX - 197
				End If
				If daINDEX > 220 Then 
					MYbattleshipLBL(1).Caption = "L:" & daINDEX - 220: MYbattleshipLBL(2).Caption = "L:" & daINDEX - 219: MYbattleshipLBL(3).Caption = "L:" & daINDEX - 218: MYbattleshipLBL(4).Caption = "L:" & daINDEX - 217
				End If
			End If
			If whichMNU = "cruiser" Then 
				If daINDEX > 0 Then 
					MYcruiserLBL(1).Caption = "A:" & daINDEX: MYcruiserLBL(2).Caption = "A:" & daINDEX + 1: MYcruiserLBL(3).Caption = "A:" & daINDEX + 2
				End If
				If daINDEX > 20 Then 
					MYcruiserLBL(1).Caption = "B:" & daINDEX - 20: MYcruiserLBL(2).Caption = "B:" & daINDEX - 19: MYcruiserLBL(3).Caption = "B:" & daINDEX - 18
				End If
				If daINDEX > 40 Then 
					MYcruiserLBL(1).Caption = "C:" & daINDEX - 40: MYcruiserLBL(2).Caption = "C:" & daINDEX - 39: MYcruiserLBL(3).Caption = "C:" & daINDEX - 38
				End If
				If daINDEX > 60 Then 
					MYcruiserLBL(1).Caption = "D:" & daINDEX - 60: MYcruiserLBL(2).Caption = "D:" & daINDEX - 59: MYcruiserLBL(3).Caption = "D:" & daINDEX - 58
				End If
				If daINDEX > 80 Then 
					MYcruiserLBL(1).Caption = "E:" & daINDEX - 80: MYcruiserLBL(2).Caption = "E:" & daINDEX - 79: MYcruiserLBL(3).Caption = "E:" & daINDEX - 78
				End If
				If daINDEX > 100 Then 
					MYcruiserLBL(1).Caption = "F:" & daINDEX - 100: MYcruiserLBL(2).Caption = "F:" & daINDEX - 99: MYcruiserLBL(3).Caption = "F:" & daINDEX - 98
				End If
				If daINDEX > 120 Then 
					MYcruiserLBL(1).Caption = "G:" & daINDEX - 120: MYcruiserLBL(2).Caption = "G:" & daINDEX - 119: MYcruiserLBL(3).Caption = "G:" & daINDEX - 118
				End If
				If daINDEX > 140 Then 
					MYcruiserLBL(1).Caption = "H:" & daINDEX - 140: MYcruiserLBL(2).Caption = "H:" & daINDEX - 139: MYcruiserLBL(3).Caption = "H:" & daINDEX - 138
				End If
				If daINDEX > 160 Then 
					MYcruiserLBL(1).Caption = "I:" & daINDEX - 160: MYcruiserLBL(2).Caption = "I:" & daINDEX - 159: MYcruiserLBL(3).Caption = "I:" & daINDEX - 158
				End If
				If daINDEX > 180 Then 
					MYcruiserLBL(1).Caption = "J:" & daINDEX - 180: MYcruiserLBL(2).Caption = "J:" & daINDEX - 179: MYcruiserLBL(3).Caption = "J:" & daINDEX - 178
				End If
				If daINDEX > 200 Then 
					MYcruiserLBL(1).Caption = "K:" & daINDEX - 200: MYcruiserLBL(2).Caption = "K:" & daINDEX - 199: MYcruiserLBL(3).Caption = "K:" & daINDEX - 198
				End If
				If daINDEX > 220 Then 
					MYcruiserLBL(1).Caption = "L:" & daINDEX - 220: MYcruiserLBL(2).Caption = "L:" & daINDEX - 219: MYcruiserLBL(3).Caption = "L:" & daINDEX - 218
				End If
			End If
			If whichMNU = "submarine" Then 
				If daINDEX > 0 Then 
					MYsubmarineLBL(1).Caption = "A:" & daINDEX: MYsubmarineLBL(2).Caption = "A:" & daINDEX + 1
				End If
				If daINDEX > 20 Then 
					MYsubmarineLBL(1).Caption = "B:" & daINDEX - 20: MYsubmarineLBL(2).Caption = "B:" & daINDEX - 19
				End If
				If daINDEX > 40 Then 
					MYsubmarineLBL(1).Caption = "C:" & daINDEX - 40: MYsubmarineLBL(2).Caption = "C:" & daINDEX - 39
				End If
				If daINDEX > 60 Then 
					MYsubmarineLBL(1).Caption = "D:" & daINDEX - 60: MYsubmarineLBL(2).Caption = "D:" & daINDEX - 59
				End If
				If daINDEX > 80 Then 
					MYsubmarineLBL(1).Caption = "E:" & daINDEX - 80: MYsubmarineLBL(2).Caption = "E:" & daINDEX - 79
				End If
				If daINDEX > 100 Then 
					MYsubmarineLBL(1).Caption = "F:" & daINDEX - 100: MYsubmarineLBL(2).Caption = "F:" & daINDEX - 99
				End If
				If daINDEX > 120 Then 
					MYsubmarineLBL(1).Caption = "G:" & daINDEX - 120: MYsubmarineLBL(2).Caption = "G:" & daINDEX - 119
				End If
				If daINDEX > 140 Then 
					MYsubmarineLBL(1).Caption = "H:" & daINDEX - 140: MYsubmarineLBL(2).Caption = "H:" & daINDEX - 139
				End If
				If daINDEX > 160 Then 
					MYsubmarineLBL(1).Caption = "I:" & daINDEX - 160: MYsubmarineLBL(2).Caption = "I:" & daINDEX - 159
				End If
				If daINDEX > 180 Then 
					MYsubmarineLBL(1).Caption = "J:" & daINDEX - 180: MYsubmarineLBL(2).Caption = "J:" & daINDEX - 179
				End If
				If daINDEX > 200 Then 
					MYsubmarineLBL(1).Caption = "K:" & daINDEX - 200: MYsubmarineLBL(2).Caption = "K:" & daINDEX - 199
				End If
				If daINDEX > 220 Then 
					MYsubmarineLBL(1).Caption = "L:" & daINDEX - 220: MYsubmarineLBL(2).Caption = "L:" & daINDEX - 219
				End If
			End If
			If whichMNU = "destroyer" Then 
				If daINDEX > 0 Then 
					MYdestroyerLBL(1).Caption = "A:" & daINDEX: MYdestroyerLBL(2).Caption = "A:" & daINDEX + 1
				End If
				If daINDEX > 20 Then 
					MYdestroyerLBL(1).Caption = "B:" & daINDEX - 20: MYdestroyerLBL(2).Caption = "B:" & daINDEX - 19
				End If
				If daINDEX > 40 Then 
					MYdestroyerLBL(1).Caption = "C:" & daINDEX - 40: MYdestroyerLBL(2).Caption = "C:" & daINDEX - 39
				End If
				If daINDEX > 60 Then 
					MYdestroyerLBL(1).Caption = "D:" & daINDEX - 60: MYdestroyerLBL(2).Caption = "D:" & daINDEX - 59
				End If
				If daINDEX > 80 Then 
					MYdestroyerLBL(1).Caption = "E:" & daINDEX - 80: MYdestroyerLBL(2).Caption = "E:" & daINDEX - 79
				End If
				If daINDEX > 100 Then 
					MYdestroyerLBL(1).Caption = "F:" & daINDEX - 100: MYdestroyerLBL(2).Caption = "F:" & daINDEX - 99
				End If
				If daINDEX > 120 Then 
					MYdestroyerLBL(1).Caption = "G:" & daINDEX - 120: MYdestroyerLBL(2).Caption = "G:" & daINDEX - 119
				End If
				If daINDEX > 140 Then 
					MYdestroyerLBL(1).Caption = "H:" & daINDEX - 140: MYdestroyerLBL(2).Caption = "H:" & daINDEX - 139
				End If
				If daINDEX > 160 Then 
					MYdestroyerLBL(1).Caption = "I:" & daINDEX - 160: MYdestroyerLBL(2).Caption = "I:" & daINDEX - 159
				End If
				If daINDEX > 180 Then 
					MYdestroyerLBL(1).Caption = "J:" & daINDEX - 180: MYdestroyerLBL(2).Caption = "J:" & daINDEX - 179
				End If
				If daINDEX > 200 Then 
					MYdestroyerLBL(1).Caption = "K:" & daINDEX - 200: MYdestroyerLBL(2).Caption = "K:" & daINDEX - 199
				End If
				If daINDEX > 220 Then 
					MYdestroyerLBL(1).Caption = "L:" & daINDEX - 220: MYdestroyerLBL(2).Caption = "L:" & daINDEX - 219
				End If
			End If
		End If
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Me.Height = CarrierLBL.Top + 800
		CenterForm(Me)
		startgameTMR.Enabled = False
		
		' UPGRADE_INFO (#0561): The 'z' symbol was defined without an explicit "As" clause.
		Dim z As Object = Nothing
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
		For z = 1 To 240
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
			Field(z).BackColor = Color.Navy 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
			Field(z).Picture = nopicturePIC.Picture
		Next
		ShiPcount = 0
		playerTURN = "0"
		isGAME = 0
		
		WhiCHway = ""
		whichMNU = ""
		
	End Sub

	Public Sub startNEWgame()
		Form_Load()
		daINDEX = 0
		' UPGRADE_INFO (#0561): The 'Ng' symbol was defined without an explicit "As" clause.
		Dim Ng As Object = Nothing
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 5
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcarrierLBL(Ng).Caption = ""
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcarrierLBL(Ng).BackColor = Color.Gray 
		Next
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 4
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYbattleshipLBL(Ng).Caption = ""
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYbattleshipLBL(Ng).BackColor = Color.Gray 
		Next
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 3
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcruiserLBL(Ng).Caption = ""
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcruiserLBL(Ng).BackColor = Color.Gray 
		Next
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 2
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYsubmarineLBL(Ng).Caption = ""
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYdestroyerLBL(Ng).Caption = ""
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYsubmarineLBL(Ng).BackColor = Color.Gray 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYdestroyerLBL(Ng).BackColor = Color.Gray 
		Next
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 240
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			If GetPictureHandle6(Field(Ng).Picture) = GetPictureHandle6(hitPIC.Picture) Then  Field(Ng).Picture = nopicturePIC.Picture
		Next
		CarrierLBL.Enabled = True: battleshipLBL.Enabled = True: CruiserLBL.Enabled = True: SubMarineLBL.Enabled = True: DestroyerLBL.Enabled = True 'lets menu's work
		Winsock.SendData("Z" & "Select Your Ships...") 'tells client to start new game
	End Sub

	Private Sub startgameTMR_Timer() Handles startgameTMR.Timer
		Winsock.SendData("A" & "Client is ready...") 'sends data at intervals till client is ready
		
	End Sub

	Private Sub SubMarineLBL_Click() Handles SubMarineLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag
		whichMNU = "submarine"
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 1680
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub sendtextCMD_Click() Handles sendtextCMD.Click
		If sendTXT.Text = "" Then  Exit Sub
		MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelBold = True: MainTXT.SelText = nickSERVER.Caption & ":": MainTXT.SelBold = False: MainTXT.SelColor = VBRUN.ColorConstants.vbBlack
		MainTXT.SelText = "     " & sendTXT.Text & ControlChars.CrLf 'puts what u typed in ur maintxt
		Winsock.SendData("T" & sendTXT.Text) 'sends the data to the server
		sendTXT.Text = "" 'clears the txtbox u typed in
	End Sub
	
	'===========================================================================
	'======================Displays info if disconnected========================
	Private Sub Winsock_Close()
		MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelText = "Disconnected to Client": MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf 'displays that u are disconnected
		sendtextCMD.Enabled = False 'this wont let you send text anymore since client is disconnected
	End Sub
	
	'===========================================================================
	'======================ALLOWS CLIENT TO CONNECT=============================
	Private Sub winsock_ConnectionRequest(ByVal requestID As Integer) Handles Winsock.ConnectionRequest
		If Winsock.State <> MSWinsockLib.StateConstants.sckClosed Then  Winsock.Close() 'closes connection if one is already open
		Winsock.Accept(requestID) 'allows new connection
		Me.Show() 'shows server frm when WINSOCK connects to the client
		Unload6(ConnectFRM) 'unloads connect frm when WINSOCK connects to the client
		Winsock.SendData("C" & nickSERVER.Caption) 'send data to server telling to load serverfrm
		' UPGRADE_INFO (#0181): Reference to default form instance 'ServerFRM' was converted to Me keyword.
		Me.Caption = "Battleship Online   [Welcome, " & nickSERVER.Caption & "!]" 'renames the form approiately
		MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelText = "Connected to Client": MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf 'displays that connection worked
		GameStatsLBL.Caption = "Select Your Ships..."
		PlayWav("defend.wav")
	End Sub
	
	'===========================================================================
	'=======================RETREIVES DATA FROM CLIENT==========================
	Private Sub winsock_DataArrival(ByVal bytesTotal As Integer) Handles Winsock.DataArrival
		' UPGRADE_INFO (#0561): The 'strData' symbol was defined without an explicit "As" clause.
		Dim strData As String = ""
		Dim strData2 As String = "" 'where the data sent by the client will be stored
		Call Winsock.GetData(strData, VariantType.String) 'gets the data sent by the client
		strData2 = VB.Left(strData, 1) 'saves the first variable's value to strData2
		strData = Mid(strData, 2) 'saves the text the server sent to strData
		If strData2 = "T" Then 
			MainTXT.SelColor = VBRUN.ColorConstants.vbBlue: MainTXT.SelBold = True: MainTXT.SelText = nickCLIENT.Caption & ":": MainTXT.SelBold = False: MainTXT.SelColor = VBRUN.ColorConstants.vbBlack
			MainTXT.SelText = "     " & strData & ControlChars.CrLf 'adds data to textbox
		End If
		If strData2 = "N" Then  nickCLIENT.Caption = strData 'loads the client's username from data sent
		
		'////////////////////////////// strings for ships for north to south
		'K = carrier
		'B = battleship
		'R = cruiser
		'S = submarine
		'D = destroyer
		'////////////////////////////// strings for ships for left to right
		'I = carrier
		'L = battleship
		'U = cruiser
		'E = submarine
		'O = destroyer
		
		Dim fiKi As String = ""
		'this is for North to South ships
		If strData2 = "K" Then 
			fiKi = strData
			carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 20: carrierTXT(3).Text = fiKi + 40: carrierTXT(4).Text = fiKi + 60: carrierTXT(5).Text = fiKi + 80
		End If
		If strData2 = "B" Then 
			fiKi = strData
			battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 20: battleshipTXT(3).Text = fiKi + 40: battleshipTXT(4).Text = fiKi + 60
		End If
		If strData2 = "R" Then 
			fiKi = strData
			cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 20: cruiserTXT(3).Text = fiKi + 40
		End If
		If strData2 = "S" Then 
			fiKi = strData
			submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 20
		End If
		If strData2 = "D" Then 
			fiKi = strData
			destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 20
		End If
		'this is for Left to RIGHT ships
		If strData2 = "I" Then 
			fiKi = strData
			carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 1: carrierTXT(3).Text = fiKi + 2: carrierTXT(4).Text = fiKi + 3: carrierTXT(5).Text = fiKi + 4
		End If
		If strData2 = "L" Then 
			fiKi = strData
			battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 1: battleshipTXT(3).Text = fiKi + 2: battleshipTXT(4).Text = fiKi + 3
		End If
		If strData2 = "U" Then 
			fiKi = strData
			cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 1: cruiserTXT(3).Text = fiKi + 2
		End If
		If strData2 = "E" Then 
			fiKi = strData
			submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 1
		End If
		If strData2 = "O" Then 
			fiKi = strData
			destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 1
		End If
		'==========================================================
		'this starts the game
		' UPGRADE_INFO (#0561): The 'uO' symbol was defined without an explicit "As" clause.
		Dim uO As Object = Nothing
		If strData2 = "A" Then 
			If ShiPcount = 10 Then 
				Winsock.SendData("Y" & nickSERVER.Caption & " Turn...")
				GameStatsLBL.Caption = "Your Turn..."
				startgameTMR.Enabled = False
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
				For uO = 1 To 240
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
					Field(uO).Enabled = True
				Next
			End If
			If ShiPcount < 5 Then 
				GameStatsLBL.Caption = nickCLIENT.Caption & " is waiting for you to finish!"
			End If
		End If
		If strData2 = "Y" Then 
			GameStatsLBL.Caption = strData
			startgameTMR.Enabled = False
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
			For uO = 1 To 240
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
				Field(uO).Enabled = True
			Next
		End If
		'============================================================
		'this shows a hit
		If strData2 = "H" Then 
			If strData = "C1" Then  MYcarrierLBL(1).BackColor = Color.Red 
			If strData = "C2" Then  MYcarrierLBL(2).BackColor = Color.Red 
			If strData = "C3" Then  MYcarrierLBL(3).BackColor = Color.Red 
			If strData = "C4" Then  MYcarrierLBL(4).BackColor = Color.Red 
			If strData = "C5" Then  MYcarrierLBL(5).BackColor = Color.Red 
			
			If strData = "B1" Then  MYbattleshipLBL(1).BackColor = Color.Red 
			If strData = "B2" Then  MYbattleshipLBL(2).BackColor = Color.Red 
			If strData = "B3" Then  MYbattleshipLBL(3).BackColor = Color.Red 
			If strData = "B4" Then  MYbattleshipLBL(4).BackColor = Color.Red 
			
			If strData = "R1" Then  MYcruiserLBL(1).BackColor = Color.Red 
			If strData = "R2" Then  MYcruiserLBL(2).BackColor = Color.Red 
			If strData = "R3" Then  MYcruiserLBL(3).BackColor = Color.Red 
			
			If strData = "S1" Then  MYsubmarineLBL(1).BackColor = Color.Red 
			If strData = "S2" Then  MYsubmarineLBL(2).BackColor = Color.Red 
			
			If strData = "D1" Then  MYdestroyerLBL(1).BackColor = Color.Red 
			If strData = "D2" Then  MYdestroyerLBL(2).BackColor = Color.Red 
			
			GameStatsLBL.Caption = "Your Turn..."
			isGAME += 1
			playerTURN = "1"
			PlayWav("drip.wav")
			If isGAME = 16 Then 
				Winsock.SendData("P" & " Won!")
				GameStatsLBL.Caption = nickCLIENT.Caption & " Won!"
				PlayWav("spacede.wav")
				NewgameFRM.Show(1)
			End If
		End If
		
		'this shows a miss
		If strData2 = "M" Then 
			PlayWav("drip.wav") 'play a sound for ur turn
			GameStatsLBL.Caption = strData
			playerTURN = "1"
		End If
		
		'this shows a WIN
		If strData2 = "P" Then 
			PlayWav("clap.wav")
			GameStatsLBL.Caption = nickSERVER.Caption & strData
			NewgameFRM.Show(1)
		End If
		
		'starts a new game
		If strData2 = "Z" Then 
			If GameStatsLBL.Caption = strData Then 
				startNEWgame()
				Winsock.SendData("F" & strData)
			Else
				Exit Sub
			End If
		End If
		If strData2 = "F" Then  startNEWgame()
		
	End Sub

End Class
