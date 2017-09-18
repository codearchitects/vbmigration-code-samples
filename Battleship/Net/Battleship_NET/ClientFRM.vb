' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class ClientFRM

	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
	'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
	'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'the client frm if HEAVILY and probably OVERLY commented on...
	'the server frm will not be commented as much!!!!!!!!!!!!!!
	
	'server frm tag is 1 and will be used in MENUFRM
	'client frm tag is 2 and will be used in menufrm
	Private daINDEX As Short 'holds the index of the Field picturebox
	Private isGAME As Short 'checks if game is over
	Private playerTURN As Short 'holds player's turn  (0 is server, 1 is client)
	
	Private Sub battleshipLBL_Click() Handles battleshipLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
		whichMNU = "battleship" 'tells menufrm that battleshiplbl was clicked
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 4800
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub CarrierLBL_Click() Handles CarrierLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
		whichMNU = "carrier" 'tells menufrm that carrierlbl was clicked
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 6360
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub CruiserLBL_Click() Handles CruiserLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
		whichMNU = "cruiser" 'tells menufrm that cruiserlbl was clicked
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 3240
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub DestroyerLBL_Click() Handles DestroyerLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
		whichMNU = "destroyer" 'tells menufrm that destroyerlbl was clicked
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 120
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub Field_Click(ByRef Index As Short)
		If ShiPcount < 6 Then  'checks if all ships are selected or not!
			daINDEX = Field(Index).Index 'saves the index of the array of FIELD into daINDEX
			PlayWav("ff7-blip.wav") 'plays a .wav to similiate a click sound
			If WhiCHway = "ns" Then  'for north to south ship placement
				If whichMNU = "carrier" Then  'tells how long to make ship
					If daINDEX + 80 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 60).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 80).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray : Field(daINDEX + 60).BackColor = Color.Gray : Field(daINDEX + 80).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts the .caption of lbl's in
						Winsock.SendData("K" & daINDEX) 'tells remote computer what and where u put your ship
						CarrierLBL.Enabled = False 'disables so you cant select the ship again
						ShiPcount += 1 'tells your computer that u selected another ship
					End If
				End If
				If whichMNU = "battleship" Then  'tells how long to make ship
					If daINDEX + 60 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 60).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray : Field(daINDEX + 60).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts .caption of lbl's in
						Winsock.SendData("B" & daINDEX) 'tells remote computer what and where u put your ship
						battleshipLBL.Enabled = False 'disables so u cant select the ship again
						ShiPcount += 1 'tells your computer that u selected another ship
					End If
				End If
				If whichMNU = "cruiser" Then  'tells how long to make ship
					If daINDEX + 40 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 40).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray : Field(daINDEX + 40).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts .caption of lbl's in
						Winsock.SendData("R" & daINDEX) 'tells remote computer what and where u put your ship
						CruiserLBL.Enabled = False 'disables so u cant select the ship again
						ShiPcount += 1 'tells computer that u selected another ship
					End If
				End If
				If whichMNU = "submarine" Then  'tells how long to make ship
					If daINDEX + 20 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts .caption of lbl's in
						Winsock.SendData("S" & daINDEX) 'tells remote computer what and where u placed ur ship
						SubMarineLBL.Enabled = False 'disables so u cant select ur ship again
						ShiPcount += 1 'tells computer that u selected another ship
					End If
				End If
				If whichMNU = "destroyer" Then  'tells how long to make ship
					If daINDEX + 20 > 240 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 20).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 20).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts .caption of lbl's in
						Winsock.SendData("D" & daINDEX) 'tells remote computer what and where u put your ship
						DestroyerLBL.Enabled = False 'disables so u cant select ur ship again
						ShiPcount += 1 'tells computer that u selected another ship
					End If
				End If
			End If
			'==========================================================
			If WhiCHway = "lr" Then  'for left to right ship placement
				If whichMNU = "carrier" Then  'tells how long to make ship
					If Field(daINDEX).Left > 5760 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 3).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 4).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray : Field(daINDEX + 3).BackColor = Color.Gray : Field(daINDEX + 4).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts .caption of lbls in
						Winsock.SendData("I" & daINDEX) 'tells remote computer what and where u put your ship
						CarrierLBL.Enabled = False 'disables so u cant select ur ship again
						ShiPcount += 1 'tells computer that u selected another ship
					End If
				End If
				If whichMNU = "battleship" Then  'tells how long ship is
					If Field(daINDEX).Left > 6120 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 3).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray : Field(daINDEX + 3).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts caption into lbls
						Winsock.SendData("L" & daINDEX) 'tells remote computer what and where u put your ship
						battleshipLBL.Enabled = False 'disables so u cant select ship again
						ShiPcount += 1 'tells computer that another ship was selected
					End If
				End If
				If whichMNU = "cruiser" Then  'tells how long ship is
					If Field(daINDEX).Left > 6480 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 2).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray : Field(daINDEX + 2).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts caption into lbls
						Winsock.SendData("U" & daINDEX) 'tells remote computer what and where u put your ship
						CruiserLBL.Enabled = False 'disables so u cant select ship again
						ShiPcount += 1 'tells computer another ship was selected
					End If
				End If
				If whichMNU = "submarine" Then  'tells how long the ship is
					If Field(daINDEX).Left > 6840 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts caption into lbls
						Winsock.SendData("E" & daINDEX) 'tells remote computer what and where u put your ship
						SubMarineLBL.Enabled = False 'disables so u cant select the ship again
						ShiPcount += 1 'tells copmuter that another ship was selected
					End If
				End If
				If whichMNU = "destroyer" Then  'tells how long the ship is
					If Field(daINDEX).Left > 6840 Then  Exit Sub 'allows only to place ship where there is room for ship
					If ToOleColor6(Field(daINDEX).BackColor) = &HFFFF% And ToOleColor6(Field(daINDEX + 1).BackColor) = &HFFFF% Then  'checks to see if there is already a ship there
						Field(daINDEX).BackColor = Color.Gray : Field(daINDEX + 1).BackColor = Color.Gray  'puts ship in
						PUTlabelsIN() 'puts caption into right labels
						Winsock.SendData("O" & daINDEX) 'tells remote computer what and where u put your ship
						DestroyerLBL.Enabled = False 'disables so u cant select ship again
						ShiPcount += 1 'tells computer that another ship was selected
					End If
				End If
			End If
		End If
		'determines if game is to be started or not!
		' UPGRADE_INFO (#0561): The 'zZ' symbol was defined without an explicit "As" clause.
		Dim zZ As Object = Nothing 'holds the integer
		If ShiPcount = 5 Then  'tells u that all 5 ships were selected
			ShiPcount = 10 'sets to 10 so it will skip over code above
			startgameTMR.Enabled = True 'starts the timer to tell server that u are ready
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
			For zZ = 1 To 240 'the #'s represent the field's array index
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
				Field(zZ).BackColor = Color.Navy  'changes bg to blue again
			Next 'loops to for till all # are done... then moves on
			GameStatsLBL.Caption = "Waiting For Server To Finish..." 'just a visual note that u are ready
			playerTURN = "0" 'shows who turn it is
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
			For zZ = 1 To 240 'again the #'s representthe field's array index
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'zZ'. Consider using the GetDefaultMember6 helper method.
				Field(zZ).Enabled = False 'disables field so you cant start w/o server
			Next 'again it loops though till all #'s are done then moves on
			Exit Sub 'exits sub to skip the next part of code
		End If
		'=================================
		If playerTURN = "0" Then  Exit Sub 'this is the head on head part of game
		' UPGRADE_INFO (#0561): The 'Yq' symbol was defined without an explicit "As" clause.
		Dim Yq As Object = Nothing 'variable used below
		If ShiPcount = 10 Then  'just to make sure it is game time
			PlayWav("ff7-blip.wav") 'plays sound for clicking in the field
			daINDEX = Field(Index).Index 'saves the field's array index into daINDEX
			If Not Field(daINDEX).BackColor.Equals(Color.Navy) Then  Exit Sub 'checkes if already guessed
			If GetPictureHandle6(Field(daINDEX).Picture) = GetPictureHandle6(hitPIC.Picture) Then  Exit Sub 'exits sub if already guessed
			playerTURN = "0" 'tells the turn is server(rememeber look at the declaration note!!!)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 5 'holds # to represent the array of the txtbox
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If carrierTXT(Yq).Text = daINDEX Then  'checks if a hit
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "C" & Yq) 'tells server that u hit one of their ships!!!!!!!!
					GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays whos turn it is
					Field(daINDEX).Refresh() 'just for the hell of it
					PlayWav("arrow.wav") 'plays a HIT sound
					Exit Sub 'exits sub so it wont show a miss
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 4 'holds # to represent the array of the txtbox
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If battleshipTXT(Yq).Text = daINDEX Then  'checks if a hit
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "B" & Yq) 'tells server u hit a ship
					GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays whos turn it is
					Field(daINDEX).Refresh() 'just incase
					PlayWav("arrow.wav") 'plays a HIT sound
					Exit Sub 'exits sub so it wont show a miss
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 3 'holds # to represent the array of the txtbox
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If cruiserTXT(Yq).Text = daINDEX Then  'checks if a hit
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "R" & Yq) 'tells server u hit a ship
					GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays who turn it is
					Field(daINDEX).Refresh() 'u never know... u might need it
					PlayWav("arrow.wav") 'plays a HIT sound
					Exit Sub 'exits sub so it wont show a miss
				End If
			Next
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
			For Yq = 1 To 2 'holds # to represent the array of the txtbox
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If destroyerTXT(Yq).Text = daINDEX Then  'checks if a hit
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "D" & Yq) 'sends data telling a hit
					GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays turn
					Field(daINDEX).Refresh() 'well this just makes sure the pic shows
					PlayWav("arrow.wav") 'plays a HIT soundup
					Exit Sub 'exits sub so it wont show a miss
				End If
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
				If submarineTXT(Yq).Text = daINDEX Then  'checks if a hit
					Field(daINDEX).Picture = hitPIC.Picture 'shows a hit
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yq'. Consider using the GetDefaultMember6 helper method.
					Winsock.SendData("H" & "S" & Yq) 'send data telling a hit
					GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays turn
					Field(daINDEX).Refresh() 'this just makes sure the pic shows up
					PlayWav("arrow.wav") 'plays a HIT sound
					Exit Sub 'exits sub so it wont show a miss
				End If
			Next
			Winsock.SendData("M" & "Your Turn...") 'sends data telling a miss
			GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'displays turn
			Field(daINDEX).BackColor = Color.Lime  'shows a miss
			PlayWav("you-lose.wav") 'plays a miss sound
		End If
		'=========================================
		
	End Sub

	Public Sub PUTlabelsIN()
		'put the color back to blue
		' UPGRADE_INFO (#0561): The 'Yp' symbol was defined without an explicit "As" clause.
		Dim Yp As Object = Nothing 'hold the integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
		For Yp = 1 To 240 'represents the array #
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
			If ToOleColor6(Field(Yp).BackColor) = &HFFFF% Then  'checks if the field(Yp) BG is yellow
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Yp'. Consider using the GetDefaultMember6 helper method.
				Field(Yp).BackColor = Color.Navy  'turns it blue
			End If
		Next 'loops till all # have been gone though... then moves on
		'puts the ships positions into labels
		If WhiCHway = "ns" Then  'for north to south label input
			If whichMNU = "carrier" Then  'for carrier
				If daINDEX > 0 Then  'row A
					MYcarrierLBL(1).Caption = "A:" & daINDEX: MYcarrierLBL(2).Caption = "B:" & daINDEX: MYcarrierLBL(3).Caption = "C:" & daINDEX: MYcarrierLBL(4).Caption = "D:" & daINDEX: MYcarrierLBL(5).Caption = "E:" & daINDEX 'displays the grid #
				End If
				If daINDEX > 20 Then  'row B
					MYcarrierLBL(1).Caption = "B:" & daINDEX - 20: MYcarrierLBL(2).Caption = "C:" & daINDEX - 20: MYcarrierLBL(3).Caption = "D:" & daINDEX - 20: MYcarrierLBL(4).Caption = "E:" & daINDEX - 20: MYcarrierLBL(5).Caption = "F:" & daINDEX - 20 'displays the grid #
				End If
				If daINDEX > 40 Then  'row C
					MYcarrierLBL(1).Caption = "C:" & daINDEX - 40: MYcarrierLBL(2).Caption = "D:" & daINDEX - 40: MYcarrierLBL(3).Caption = "E:" & daINDEX - 40: MYcarrierLBL(4).Caption = "F:" & daINDEX - 40: MYcarrierLBL(5).Caption = "G:" & daINDEX - 40 'displays the grid #
				End If
				If daINDEX > 60 Then  'row D
					MYcarrierLBL(1).Caption = "D:" & daINDEX - 60: MYcarrierLBL(2).Caption = "E:" & daINDEX - 60: MYcarrierLBL(3).Caption = "F:" & daINDEX - 60: MYcarrierLBL(4).Caption = "G:" & daINDEX - 60: MYcarrierLBL(5).Caption = "H:" & daINDEX - 60 'displays the grid #
				End If
				If daINDEX > 80 Then  'row E
					MYcarrierLBL(1).Caption = "E:" & daINDEX - 80: MYcarrierLBL(2).Caption = "F:" & daINDEX - 80: MYcarrierLBL(3).Caption = "G:" & daINDEX - 80: MYcarrierLBL(4).Caption = "H:" & daINDEX - 80: MYcarrierLBL(5).Caption = "I:" & daINDEX - 80 'displays the grid #
				End If
				If daINDEX > 100 Then  'row F
					MYcarrierLBL(1).Caption = "F:" & daINDEX - 100: MYcarrierLBL(2).Caption = "G:" & daINDEX - 100: MYcarrierLBL(3).Caption = "H:" & daINDEX - 100: MYcarrierLBL(4).Caption = "I:" & daINDEX - 100: MYcarrierLBL(5).Caption = "J:" & daINDEX - 100 'displays the grid #
				End If
				If daINDEX > 120 Then  'row G
					MYcarrierLBL(1).Caption = "G:" & daINDEX - 120: MYcarrierLBL(2).Caption = "H:" & daINDEX - 120: MYcarrierLBL(3).Caption = "I:" & daINDEX - 120: MYcarrierLBL(4).Caption = "J:" & daINDEX - 120: MYcarrierLBL(5).Caption = "K:" & daINDEX - 120 'displays the grid #
				End If
				If daINDEX > 140 Then  'row H
					MYcarrierLBL(1).Caption = "H:" & daINDEX - 140: MYcarrierLBL(2).Caption = "I:" & daINDEX - 140: MYcarrierLBL(3).Caption = "J:" & daINDEX - 140: MYcarrierLBL(4).Caption = "K:" & daINDEX - 140: MYcarrierLBL(5).Caption = "L:" & daINDEX - 140 'displays the grid #
				End If
			End If
			If whichMNU = "battleship" Then  'for battleship
				If daINDEX > 0 Then  'row A
					MYbattleshipLBL(1).Caption = "A:" & daINDEX: MYbattleshipLBL(2).Caption = "B:" & daINDEX: MYbattleshipLBL(3).Caption = "C:" & daINDEX: MYbattleshipLBL(4).Caption = "D:" & daINDEX 'displays the grid #
				End If
				If daINDEX > 20 Then  'row B
					MYbattleshipLBL(1).Caption = "B:" & daINDEX - 20: MYbattleshipLBL(2).Caption = "C:" & daINDEX - 20: MYbattleshipLBL(3).Caption = "D:" & daINDEX - 20: MYbattleshipLBL(4).Caption = "E:" & daINDEX - 20 'displays the grid #
				End If
				If daINDEX > 40 Then  'row C
					MYbattleshipLBL(1).Caption = "C:" & daINDEX - 40: MYbattleshipLBL(2).Caption = "D:" & daINDEX - 40: MYbattleshipLBL(3).Caption = "E:" & daINDEX - 40: MYbattleshipLBL(4).Caption = "F:" & daINDEX - 40 'displays the grid #
				End If
				If daINDEX > 60 Then  'row D
					MYbattleshipLBL(1).Caption = "D:" & daINDEX - 60: MYbattleshipLBL(2).Caption = "E:" & daINDEX - 60: MYbattleshipLBL(3).Caption = "F:" & daINDEX - 60: MYbattleshipLBL(4).Caption = "G:" & daINDEX - 60 'displays the grid #
				End If
				If daINDEX > 80 Then  'row E
					MYbattleshipLBL(1).Caption = "E:" & daINDEX - 80: MYbattleshipLBL(2).Caption = "F:" & daINDEX - 80: MYbattleshipLBL(3).Caption = "G:" & daINDEX - 80: MYbattleshipLBL(4).Caption = "H:" & daINDEX - 80 'displays the grid #
				End If
				If daINDEX > 100 Then  'row F
					MYbattleshipLBL(1).Caption = "F:" & daINDEX - 100: MYbattleshipLBL(2).Caption = "G:" & daINDEX - 100: MYbattleshipLBL(3).Caption = "H:" & daINDEX - 100: MYbattleshipLBL(4).Caption = "I:" & daINDEX - 100 'displays the grid #
				End If
				If daINDEX > 120 Then  'row G
					MYbattleshipLBL(1).Caption = "G:" & daINDEX - 120: MYbattleshipLBL(2).Caption = "H:" & daINDEX - 120: MYbattleshipLBL(3).Caption = "I:" & daINDEX - 120: MYbattleshipLBL(4).Caption = "J:" & daINDEX - 120 'displays the grid #
				End If
				If daINDEX > 140 Then  'row H
					MYbattleshipLBL(1).Caption = "H:" & daINDEX - 140: MYbattleshipLBL(2).Caption = "I:" & daINDEX - 140: MYbattleshipLBL(3).Caption = "J:" & daINDEX - 140: MYbattleshipLBL(4).Caption = "K:" & daINDEX - 140 'displays the grid #
				End If
				If daINDEX > 160 Then  'row I
					MYbattleshipLBL(1).Caption = "I:" & daINDEX - 160: MYbattleshipLBL(2).Caption = "J:" & daINDEX - 160: MYbattleshipLBL(3).Caption = "K:" & daINDEX - 160: MYbattleshipLBL(4).Caption = "L:" & daINDEX - 160 'displays the grid #
				End If
			End If
			If whichMNU = "cruiser" Then  'for cruiser
				If daINDEX > 0 Then  'for A
					MYcruiserLBL(1).Caption = "A:" & daINDEX: MYcruiserLBL(2).Caption = "B:" & daINDEX: MYcruiserLBL(3).Caption = "C:" & daINDEX 'displays the grid #
				End If
				If daINDEX > 20 Then  'for B
					MYcruiserLBL(1).Caption = "B:" & daINDEX - 20: MYcruiserLBL(2).Caption = "C:" & daINDEX - 20: MYcruiserLBL(3).Caption = "D:" & daINDEX - 20 'displays the grid #
				End If
				If daINDEX > 40 Then  'for C
					MYcruiserLBL(1).Caption = "C:" & daINDEX - 40: MYcruiserLBL(2).Caption = "D:" & daINDEX - 40: MYcruiserLBL(3).Caption = "E:" & daINDEX - 40 'displays the grid #
				End If
				If daINDEX > 60 Then  'for D
					MYcruiserLBL(1).Caption = "D:" & daINDEX - 60: MYcruiserLBL(2).Caption = "E:" & daINDEX - 60: MYcruiserLBL(3).Caption = "F:" & daINDEX - 60 'displays the grid #
				End If
				If daINDEX > 80 Then  'for E
					MYcruiserLBL(1).Caption = "E:" & daINDEX - 80: MYcruiserLBL(2).Caption = "F:" & daINDEX - 80: MYcruiserLBL(3).Caption = "G:" & daINDEX - 80 'displays the grid #
				End If
				If daINDEX > 100 Then  'for F
					MYcruiserLBL(1).Caption = "F:" & daINDEX - 100: MYcruiserLBL(2).Caption = "G:" & daINDEX - 100: MYcruiserLBL(3).Caption = "H:" & daINDEX - 100 'displays the grid #
				End If
				If daINDEX > 120 Then  'for G
					MYcruiserLBL(1).Caption = "G:" & daINDEX - 120: MYcruiserLBL(2).Caption = "H:" & daINDEX - 120: MYcruiserLBL(3).Caption = "I:" & daINDEX - 120 'displays the grid #
				End If
				If daINDEX > 140 Then  'for H
					MYcruiserLBL(1).Caption = "H:" & daINDEX - 140: MYcruiserLBL(2).Caption = "I:" & daINDEX - 140: MYcruiserLBL(3).Caption = "J:" & daINDEX - 140 'displays the grid #
				End If
				If daINDEX > 160 Then  'For I
					MYcruiserLBL(1).Caption = "I:" & daINDEX - 160: MYcruiserLBL(2).Caption = "J:" & daINDEX - 160: MYcruiserLBL(3).Caption = "K:" & daINDEX - 160 'displays the grid #
				End If
				If daINDEX > 180 Then  'for J
					MYcruiserLBL(1).Caption = "J:" & daINDEX - 180: MYcruiserLBL(2).Caption = "K:" & daINDEX - 180: MYcruiserLBL(3).Caption = "L:" & daINDEX - 180 'displays the grid #
				End If
			End If
			If whichMNU = "submarine" Then  'for submarine
				If daINDEX > 0 Then  'for A
					MYsubmarineLBL(1).Caption = "A:" & daINDEX: MYsubmarineLBL(2).Caption = "B:" & daINDEX 'displays the grid #
				End If
				If daINDEX > 20 Then  'for B
					MYsubmarineLBL(1).Caption = "B:" & daINDEX - 20: MYsubmarineLBL(2).Caption = "C:" & daINDEX - 20 'displays the grid #
				End If
				If daINDEX > 40 Then  'for C
					MYsubmarineLBL(1).Caption = "C:" & daINDEX - 40: MYsubmarineLBL(2).Caption = "D:" & daINDEX - 40 'displays the grid #
				End If
				If daINDEX > 60 Then  'for D
					MYsubmarineLBL(1).Caption = "D:" & daINDEX - 60: MYsubmarineLBL(2).Caption = "E:" & daINDEX - 60 'displays the grid #
				End If
				If daINDEX > 80 Then  'for E
					MYsubmarineLBL(1).Caption = "E:" & daINDEX - 80: MYsubmarineLBL(2).Caption = "F:" & daINDEX - 80 'displays the grid #
				End If
				If daINDEX > 100 Then  'for F
					MYsubmarineLBL(1).Caption = "F:" & daINDEX - 100: MYsubmarineLBL(2).Caption = "G:" & daINDEX - 100 'displays the grid #
				End If
				If daINDEX > 120 Then  'for G
					MYsubmarineLBL(1).Caption = "G:" & daINDEX - 120: MYsubmarineLBL(2).Caption = "H:" & daINDEX - 120 'displays the grid #
				End If
				If daINDEX > 140 Then  'for H
					MYsubmarineLBL(1).Caption = "H:" & daINDEX - 140: MYsubmarineLBL(2).Caption = "I:" & daINDEX - 140 'displays the grid #
				End If
				If daINDEX > 160 Then  'for I
					MYsubmarineLBL(1).Caption = "I:" & daINDEX - 160: MYsubmarineLBL(2).Caption = "J:" & daINDEX - 160 'displays the grid #
				End If
				If daINDEX > 180 Then  'for J
					MYsubmarineLBL(1).Caption = "J:" & daINDEX - 180: MYsubmarineLBL(2).Caption = "K:" & daINDEX - 180 'displays the grid #
				End If
				If daINDEX > 200 Then  'for K
					MYsubmarineLBL(1).Caption = "K:" & daINDEX - 200: MYsubmarineLBL(2).Caption = "L:" & daINDEX - 200 'displays the grid #
				End If
			End If
			If whichMNU = "destroyer" Then  'for destroyer
				If daINDEX > 0 Then  'for A
					MYdestroyerLBL(1).Caption = "A:" & daINDEX: MYdestroyerLBL(2).Caption = "B:" & daINDEX 'displays the grid #
				End If
				If daINDEX > 20 Then  'for B
					MYdestroyerLBL(1).Caption = "B:" & daINDEX - 20: MYdestroyerLBL(2).Caption = "C:" & daINDEX - 20 'displays the grid #
				End If
				If daINDEX > 40 Then  'for C
					MYdestroyerLBL(1).Caption = "C:" & daINDEX - 40: MYdestroyerLBL(2).Caption = "D:" & daINDEX - 40 'displays the grid #
				End If
				If daINDEX > 60 Then  'for D
					MYdestroyerLBL(1).Caption = "D:" & daINDEX - 60: MYdestroyerLBL(2).Caption = "E:" & daINDEX - 60 'displays the grid #
				End If
				If daINDEX > 80 Then  'for E
					MYdestroyerLBL(1).Caption = "E:" & daINDEX - 80: MYdestroyerLBL(2).Caption = "F:" & daINDEX - 80 'displays the grid #
				End If
				If daINDEX > 100 Then  'for F
					MYdestroyerLBL(1).Caption = "F:" & daINDEX - 100: MYdestroyerLBL(2).Caption = "G:" & daINDEX - 100 'displays the grid #
				End If
				If daINDEX > 120 Then  'for G
					MYdestroyerLBL(1).Caption = "G:" & daINDEX - 120: MYdestroyerLBL(2).Caption = "H:" & daINDEX - 120 'displays the grid #
				End If
				If daINDEX > 140 Then  'for H
					MYdestroyerLBL(1).Caption = "H:" & daINDEX - 140: MYdestroyerLBL(2).Caption = "I:" & daINDEX - 140 'displays the grid #
				End If
				If daINDEX > 160 Then  'For I
					MYdestroyerLBL(1).Caption = "I:" & daINDEX - 160: MYdestroyerLBL(2).Caption = "J:" & daINDEX - 160 'displays the grid #
				End If
				If daINDEX > 180 Then  'for J
					MYdestroyerLBL(1).Caption = "J:" & daINDEX - 180: MYdestroyerLBL(2).Caption = "K:" & daINDEX - 180 'displays the grid #
				End If
				If daINDEX > 200 Then  'for K
					MYdestroyerLBL(1).Caption = "K:" & daINDEX - 200: MYdestroyerLBL(2).Caption = "L:" & daINDEX - 200 'displays the grid #
				End If
			End If
		End If
		If WhiCHway = "lr" Then  'for left to right label input
			'*******same comments as above**********
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
			'********end same comments*****
		End If
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Me.Height = CarrierLBL.Top + 800 'sets form height
		CenterForm(Me) 'centers frm
		startgameTMR.Enabled = False 'keeps disabled till necessary
		
		' UPGRADE_INFO (#0561): The 'z' symbol was defined without an explicit "As" clause.
		Dim z As Object = Nothing 'hold integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
		For z = 1 To 240 '#represents the index of the array's in the field object
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
			Field(z).BackColor = Color.Navy  'changes color to blue
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'z'. Consider using the GetDefaultMember6 helper method.
			Field(z).Picture = nopicturePIC.Picture 'makes all pic box's have NO PIC
		Next 'loops around till all numbers done... then move right along
		ShiPcount = 0 'sets ship count to 0 (will be increased as u select ships)
		playerTURN = "0" 'sets the playerturn(review the declarations for mroe info)
		isGAME = 0 'sets the game over deciding feature to 0(will be increased as u fing the server's ships)
		
		WhiCHway = "" 'clears string
		whichMNU = "" 'clears string
		
	End Sub

	Public Sub startNEWgame()
		Form_Load() 'does all functions in the Form_Load event
		daINDEX = 0 'sets daindex to 0
		' UPGRADE_INFO (#0561): The 'Ng' symbol was defined without an explicit "As" clause.
		Dim Ng As Object = Nothing 'integer used
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 5 'represent array #'s
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcarrierLBL(Ng).Caption = "" 'clears the lbl
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcarrierLBL(Ng).BackColor = Color.Gray  'changes color back to grey
		Next 'loops till ALL NUMBERS ARE DONE!!!!!!!!!!!!!!!  woohoo
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 4 'represents array #'s
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYbattleshipLBL(Ng).Caption = "" 'clears the lbl
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYbattleshipLBL(Ng).BackColor = Color.Gray  'changes BG to grey
		Next 'see last comment on next (u can tell im having fun!!hehe)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 3 'represents array #'s
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcruiserLBL(Ng).Caption = "" 'clears the lbl
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYcruiserLBL(Ng).BackColor = Color.Gray  'changes BG to grey
		Next 'does stuff that u should know by now... hehe (refer above if really necessary)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 2 'represents array #'s
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYsubmarineLBL(Ng).Caption = "" 'clears the lbl
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYdestroyerLBL(Ng).Caption = "" 'clears the lbl
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYsubmarineLBL(Ng).BackColor = Color.Gray  'changes BG to grey
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			MYdestroyerLBL(Ng).BackColor = Color.Gray  'changes BG to grey
		Next 'proceeds to next line of code
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
		For Ng = 1 To 240 'represents array #'s
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Ng'. Consider using the GetDefaultMember6 helper method.
			If GetPictureHandle6(Field(Ng).Picture) = GetPictureHandle6(hitPIC.Picture) Then  Field(Ng).Picture = nopicturePIC.Picture 'changes the picture boxes back so they have no pictures
		Next 'NEXT ALREADY!!
		CarrierLBL.Enabled = True: battleshipLBL.Enabled = True: CruiserLBL.Enabled = True: SubMarineLBL.Enabled = True: DestroyerLBL.Enabled = True 'lets menu's work
		Winsock.SendData("Z" & "Select Your Ships...") 'tells server to start new game
	End Sub

	Private Sub startgameTMR_Timer() Handles startgameTMR.Timer
		Winsock.SendData("A" & "Client is ready...") 'sends data at intervals till client is ready
		
	End Sub

	Private Sub SubMarineLBL_Click() Handles SubMarineLBL.Click
		'used for the MENUFRM
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Me.Tag'. Consider using the GetDefaultMember6 helper method.
		FORMtagg = Me.Tag 'tells menufrm that it was loaded from the clientfrm
		whichMNU = "submarine" 'tells mnufrm that submarine was clicked!!
		'sets position of menuFRM
		MenuFRM.StartPosition = FormStartPosition.Manual
		MenuFRM.Left = Me.Left + 1680
		MenuFRM.Top = Me.Top + 8950
		MenuFRM.Show()
		
	End Sub

	Private Sub sendtextCMD_Click() Handles sendtextCMD.Click
		If sendTXT.Text = "" Then  Exit Sub 'wont let u send NOTEXT!!!  type something PLEASE
		MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelBold = True: MainTXT.SelText = nickCLIENT.Caption & ":": MainTXT.SelBold = False: MainTXT.SelColor = VBRUN.ColorConstants.vbBlack 'makes it look all pretty    hehe
		MainTXT.SelText = "     " & sendTXT.Text & ControlChars.CrLf 'puts what u typed in ur maintxt
		Winsock.SendData("T" & sendTXT.Text) 'sends the data to the server
		sendTXT.Text = "" 'clears the txtbox u typed in
		
	End Sub

	'===========================================================================
	'======================Displays info if disconnected========================
	Private Sub Winsock_Close()
		MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelText = "Disconnected to Server": MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf 'displays u are disconnected
		sendtextCMD.Enabled = False 'this wont let you send text anymore since server is disconnected
	End Sub

	'===========================================================================
	'=======================RETREIVES DATA FROM SERVER==========================
	Private Sub winsock_DataArrival(ByVal bytesTotal As Integer) Handles Winsock.DataArrival
		' UPGRADE_INFO (#0561): The 'strData' symbol was defined without an explicit "As" clause.
		Dim strData As String = ""
		Dim strData2 As String = "" 'where the data sent by the client will be stored
		Call Winsock.GetData(strData, VariantType.String) 'gets the data sent by the client
		
		strData2 = VB.Left(strData, 1) 'saves the first variable's value to strData2
		strData = Mid(strData, 2) 'saves the text the server sent to strData
		
		If strData2 = "C" Then  'tells form to load and do other form stuff
			nickSERVER.Caption = strData 'loads the server's username from data sent
			Me.Show() 'shows Client frm
			Unload6(ConnectFRM) 'unloads the connect frm
			Winsock.SendData("N" & nickCLIENT.Caption) 'sends your username to the server
			' UPGRADE_INFO (#0181): Reference to default form instance 'ClientFRM' was converted to Me keyword.
			Me.Caption = "Battleship Online   [Welcome, " & nickCLIENT.Caption & "!]" 'renames the form approiately
			MainTXT.SelText = "¨'°*·º·*°'¨ ": MainTXT.SelColor = VBRUN.ColorConstants.vbRed: MainTXT.SelText = "Connected to Server": MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf 'displays that connection worked
			GameStatsLBL.Caption = "Select Your Ships..." 'displays stuff telling u to do stuff
			PlayWav("defend.wav") 'plays a .wav that simulates a start game sound
		End If
		
		If strData2 = "T" Then 
			MainTXT.SelColor = VBRUN.ColorConstants.vbBlue: MainTXT.SelBold = True: MainTXT.SelText = nickSERVER.Caption & ":": MainTXT.SelBold = False: MainTXT.SelColor = VBRUN.ColorConstants.vbBlack 'makes it look all nice and pretty
			MainTXT.SelText = "     " & strData & ControlChars.CrLf 'adds data to textbox
		End If
		
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
		Dim fiKi As String = "" 'fiki is used to replace strData
		'this is for North to South ships
		If strData2 = "K" Then  'carrier
			fiKi = strData 'changes over to Fiki
			carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 20: carrierTXT(3).Text = fiKi + 40: carrierTXT(4).Text = fiKi + 60: carrierTXT(5).Text = fiKi + 80 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "B" Then  'battleship
			fiKi = strData 'changes over to fiki
			battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 20: battleshipTXT(3).Text = fiKi + 40: battleshipTXT(4).Text = fiKi + 60 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "R" Then  'cruiser
			fiKi = strData 'changes strings
			cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 20: cruiserTXT(3).Text = fiKi + 40 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "S" Then  'submarine
			fiKi = strData 'changes strings
			submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 20 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "D" Then  'destroyer
			fiKi = strData 'changes strings
			destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 20 'puts the position of the server's ship into hidden txt file
		End If
		'this is for Left to RIGHT ships
		If strData2 = "I" Then  'carrier
			fiKi = strData 'changes strings
			carrierTXT(1).Text = fiKi: carrierTXT(2).Text = fiKi + 1: carrierTXT(3).Text = fiKi + 2: carrierTXT(4).Text = fiKi + 3: carrierTXT(5).Text = fiKi + 4 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "L" Then  'battleship
			fiKi = strData 'changes strings
			battleshipTXT(1).Text = fiKi: battleshipTXT(2).Text = fiKi + 1: battleshipTXT(3).Text = fiKi + 2: battleshipTXT(4).Text = fiKi + 3 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "U" Then  'cruiser
			fiKi = strData 'changes strings
			cruiserTXT(1).Text = fiKi: cruiserTXT(2).Text = fiKi + 1: cruiserTXT(3).Text = fiKi + 2 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "E" Then  'submarine
			fiKi = strData 'changes strings
			submarineTXT(1).Text = fiKi: submarineTXT(2).Text = fiKi + 1 'puts the position of the server's ship into hidden txt file
		End If
		If strData2 = "O" Then  'destroyer
			fiKi = strData 'changes strings
			destroyerTXT(1).Text = fiKi: destroyerTXT(2).Text = fiKi + 1 'puts the position of the server's ship into hidden txt file
		End If
		'==========================================================
		'this starts the game
		' UPGRADE_INFO (#0561): The 'uO' symbol was defined without an explicit "As" clause.
		Dim uO As Object = Nothing 'holds integer
		If strData2 = "A" Then  'server is ready for u
			If ShiPcount = 10 Then  'u are ready too
				Winsock.SendData("Y" & "Your Turn...") 'tell em ur ready
				GameStatsLBL.Caption = nickSERVER.Caption & "'s Turn..." 'display ur ready
				startgameTMR.Enabled = False 'disable tmr cause ur ready already!! hehe
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
				For uO = 1 To 240 'represents array index of field
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
					Field(uO).Enabled = True 'enables field so u can play now!!  yeehaa
				Next 'god another next!
			End If
			If ShiPcount < 5 Then  'sorry not ready yet!!! try again
				GameStatsLBL.Caption = nickSERVER.Caption & " is waiting for you to finish!" 'show em that they are waiting for u to finish
			End If
		End If
		If strData2 = "Y" Then  'YEAHHH!!!!!  I am ready and the server is ready!!!
			GameStatsLBL.Caption = strData 'display how ready i am
			startgameTMR.Enabled = False 'im ready... i dont need this now
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
			For uO = 1 To 240 'represents the array of the index of field
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'uO'. Consider using the GetDefaultMember6 helper method.
				Field(uO).Enabled = True 'enables em so i can play!
			Next 'ughh
		End If
		'============================================================
		'this shows a hit
		If strData2 = "H" Then  'H means HIT
			If strData = "C1" Then  MYcarrierLBL(1).BackColor = Color.Red  'show it RED for BLOOD!
			If strData = "C2" Then  MYcarrierLBL(2).BackColor = Color.Red  'show it red
			If strData = "C3" Then  MYcarrierLBL(3).BackColor = Color.Red  'show it red
			If strData = "C4" Then  MYcarrierLBL(4).BackColor = Color.Red  'show it red
			If strData = "C5" Then  MYcarrierLBL(5).BackColor = Color.Red  'show it red
			
			If strData = "B1" Then  MYbattleshipLBL(1).BackColor = Color.Red  'show it red
			If strData = "B2" Then  MYbattleshipLBL(2).BackColor = Color.Red  'show it red
			If strData = "B3" Then  MYbattleshipLBL(3).BackColor = Color.Red  'show it red
			If strData = "B4" Then  MYbattleshipLBL(4).BackColor = Color.Red  'show it red
			
			If strData = "R1" Then  MYcruiserLBL(1).BackColor = Color.Red  'show it red
			If strData = "R2" Then  MYcruiserLBL(2).BackColor = Color.Red  'show it red
			If strData = "R3" Then  MYcruiserLBL(3).BackColor = Color.Red  'show it red
			
			If strData = "S1" Then  MYsubmarineLBL(1).BackColor = Color.Red  'show it red
			If strData = "S2" Then  MYsubmarineLBL(2).BackColor = Color.Red  'show it red
			
			If strData = "D1" Then  MYdestroyerLBL(1).BackColor = Color.Red  'show it red
			If strData = "D2" Then  MYdestroyerLBL(2).BackColor = Color.Red  'show it red
			
			GameStatsLBL.Caption = "Your Turn..." 'display whos turn it is
			isGAME += 1 'hey thats one part of a ship down...
			playerTURN = "1" 'Clients turn
			PlayWav("drip.wav") 'plays a sound for ur turn
			If isGAME = 16 Then  'game over already?
				Winsock.SendData("P" & " Won!") 'sends data that server WON!
				GameStatsLBL.Caption = nickSERVER.Caption & " Won!" 'shows that he/she/it won
				PlayWav("spacede.wav") 'plays nice loser music
				NewgameFRM.Show(1) 'asks if u wanna go for another round??
			End If
		End If
		
		'this shows a miss
		If strData2 = "M" Then  'M means MISS!!!
			PlayWav("drip.wav") 'play a sound for ur turn
			GameStatsLBL.Caption = strData 'nice little caption
			playerTURN = "1" 'clients turn!
		End If
		
		'this shows a win
		If strData2 = "P" Then  'P means WIN!! yeah!
			PlayWav("clap.wav") 'nice little .wav for a VICTORY OVER THE SERVER!!!
			GameStatsLBL.Caption = nickCLIENT.Caption & strData 'shows u won!  yeah!!!!
			NewgameFRM.Show(1) 'asks if u wanna play again
		End If
		
		'starts a new game
		If strData2 = "Z" Then  'Z means NEWGAME
			If GameStatsLBL.Caption = strData Then  'ready for new game
				startNEWgame() 'start a new game
				Winsock.SendData("F" & strData) 'tells em u wanna play again
				 Else 'what if they arent ready yet!
				Exit Sub
			End If
		End If
		If strData2 = "F" Then  startNEWgame() 'ok their ready now
		
	End Sub

End Class
