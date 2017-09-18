' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmMain

	'--------------------------------------------------------------------
	' Ald Win Invaders v.2.0 FreeWare
	'--------------------------------------------------------------------
	' Author: Aldo Prinzi (Milan/Italy) e.mail:aprinzi@tiscalinet.it
	' Date  : July 2001
	'--------------------------------------------------------------------
	' My v.1.0 version of the game (Ald Invaders) was written in 1993 in
	' Ms-Quick Basic to demonstrate the use of sprites in that language,
	' that were freely distribute by microsoft on all the older version
	' of Ms-Windows.
	' That version where already freeware, but the distribution will be
	' poor due to the minimal use of internet in Italy for that year.
	'
	' This version was written to demonstrate other things about the use
	' of a Smart Card with a program written in Visual Basic (WPC 2001).
	' Since the actual version have none to do with Smart Card many
	' friends, who knows the v1.0, ask to get this version.
	' And I will be happy to share it with all who like Space Invaders.
	'
	' This is only a demonstration software freely distributed on an
	' AS-IS basis. I can't know if it will work on any system or version
	' of Visual Basic. It was written on VB 6.0 SP5 wit Windows 2K Sp2.
	'--------------------------------------------------------------------
	' SPACE INVADERS is one of best and ancient videogame on the earth.
	' It was written by Toshihiro Nishikado for TAITO corporation in 1978.
	' This version is not a really clone, but a game who recall the
	' original idea with some differences (that is for trademark purpose)
	' Hope you like it.
	' July 2001,
	' Aldo Prinzi.
	'--------------------------------------------------------------------
	' "Microsoft", "Microsoft Windows" and "Microsoft Visual Basic"
	' are trademark of Microsoft corp. - Redmond- USA
	'
	' "TAITO" and the name "Space Invaders" are trademark of TAITO Corp.
	'--------------------------------------------------------------------

	Private An As Short
	Private AnM As Short
	Private MM As Short
	Private POmx As Short
	Private POmn As Short
	Private TP As Integer
	Private TiIn As Short
	Private finito As Boolean
	
	Friend Structure Pannello
	
		Public Lives As Short
		Public Level As Short
		Public Points As Integer
	End Structure

	Private Pnl As frmMain.Pannello
	
	Private Const MAXBombe As Short = 10
	Private Const MONperRIGA As Short = 11
	
	Private GMC(3) As Collection
	Private TMC As Collection
	
	Private Colpo As Boolean
	
	Private Sub Form_Load() Handles MyBase.Load
		Dim I As Short
		Dim J As Short
		Dim Z As Short
		Dim Y As Short
		
		Colpo = False
		
		Shape1.Left = 60
		Height = Shape1.Height + Shape1.Top + 440
		
		For Y = 0 To 3
			For J = 0 To MONperRIGA
				Z = M.UBound() + 1
				M.Load(Z)
			Next
		Next
		
		For I = 1 To 10
			K.Load(I)
			K(I).Visible = False
			K(I).Picture = MI(0).Picture
		Next
		
		Shape1.ZOrder(1)
		
		'------------------------------------
		' Imposta i limiti (dx e sx)
		'------------------------------------
		POmx = Shape1.Left + Shape1.Width - 400
		POmn = Shape1.Left + 200
		
		SH.Top = Shape1.Top + Shape1.Height - SH.Height
		SH.Left = Shape1.Width / 2 - SH.Width / 2
		
		azzera()
		Resetta()
		
	End Sub

	Private Sub azzera()
		Dim mnTop As Short
		Dim mnLeft As Short
		Dim nrRiga As Short
		Dim nrMonst As Short
		Dim nrImg As Short = 2
		
		mnTop = Shape1.Top + A(0).Height + 300
		For nrRiga = 0 To 3
			mnLeft = Shape1.Left + A(0).Width * 2 + 45
			GMC(nrRiga) = Nothing
			GMC(nrRiga) = New Collection()
			Select Case nrRiga
			Case Is = 0: M(nrImg).Picture = A(0).Picture
			Case Is = 1: M(nrImg).Picture = B(0).Picture
			Case Is = 2: M(nrImg).Picture = C(0).Picture
			Case Is = 3: M(nrImg).Picture = D(0).Picture
			End Select
			For nrMonst = 0 To MONperRIGA
				With M(nrImg)
					.Visible = True
					.Top = mnTop
					.Left = mnLeft
					.Tag = "V"
				End With
				GMC(nrRiga).Add(M(nrImg), "M" & VB.Right("0" & Trim(CStr(nrMonst)), 2))
				mnLeft = mnLeft + A(0).Width + 60
				nrImg += 1
			Next
			mnTop = mnTop + A(0).Height + 15
		Next
		TMC = Nothing
		
		An = 0
		AnM = -1
		MM = 30
		
		TP = Shape1.Top + A(0).Height + 300
		GameGo()
		
	End Sub

	Private Sub Resetta()
		Dim J As Short
		Dim I As Short
		
		Pnl.Points = 0
		Pnl.Level = 1
		Pnl.Lives = 3
		SH.Picture = SE(8).Picture
		For J = 0 To 2
			Lives(J).Visible = True
		Next
		finito = False
		LevelSetting()
		For I = 0 To 3
			For J = 1 To GMC(I).Count()
				With GMC(I).Item(J)
					.Visible = True
					.Tag = "V"
				End With
			Next
		Next
	End Sub

	Private Sub cmdStart_Click() Handles cmdStart.Click
		Text1.SetFocus()
		Resetta()
		azzera()
		tmrMonster.Enabled = True
	End Sub

	Private Sub Text1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles Text1.KeyDown
		getmov(KeyCode)
	End Sub

	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		getmov(KeyCode)
	End Sub

	Private Sub cmdStart_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles cmdStart.KeyDown
		getmov(KeyCode)
	End Sub

	Private Sub getmov(ByVal KeyCode As Short)
		If tmrMonster.Enabled Then 
			Select Case KeyCode
			Case VBRUN.KeyCodeConstants.vbKeyLeft
				SH.Left -= 60
				If SH.Left < Shape1.Left Then 
					SH.Left += 60
				End If
			Case VBRUN.KeyCodeConstants.vbKeyRight
				SH.Left += 60
				If SH.Left + SH.Width > Shape1.Left + Shape1.Width Then 
					SH.Left -= 60
				End If
			Case VBRUN.KeyCodeConstants.vbKeyUp, VBRUN.KeyCodeConstants.vbKeySpace
				' spara
				If Colpo = False Then 
					R(2).Top = SH.Top - R(2).Height
					R(2).Left = SH.Left + (SH.Width / 2 - R(2).Width / 2)
					Colpo = True
				End If
			End Select
		End If
	End Sub

	Private Sub tmrBulletsMove_Timer() Handles tmrBulletsMove.Timer
		Dim I As Short
		Dim Y As Short
		Dim J As Short
		Dim Z As Short
		Dim NM As String = ""
		Dim NM2 As String = ""
		Dim ME1 As Short
		Dim ME2 As Short
		Dim TT As Single
		
		tmrBulletsMove.Enabled = False
		'--------------------------------
		' Rende invisibili le ev. bombe
		'--------------------------------
		For I = 0 To MAXBombe
			If K(I).Visible = True Then 
				K(I).Tag = "V"
				K(I).Visible = False
			End If
		Next
		'--------------------------------
		' GESTISCE IL COLPO
		'--------------------------------
		If Colpo Then 
			R(2).Visible = False
			R(2).Top = R(2).Top - R(2).Height / 2
			If R(2).Top < Shape1.Top + 30 Then 
				Colpo = False
			Else
				R(2).Visible = True
			End If
		End If
		
		'------------------------------------------
		' Controlla se ÃƒÂ¨ stato colpito un M
		'------------------------------------------
		For Y = 0 To 3
			Z = 0
			For I = 0 To MONperRIGA
				NM = "M" & VB.Right("0" & Trim(CStr(I)), 2)
				With GMC(Y).Item(NM)
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Tag'. Consider using the GetDefaultMember6 helper method.
					If .Tag = "V" Then 
						
						If Colpo Then 
							If (R(2).Top + A(0).Height) > TP Then 
								' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Left'. Consider using the GetDefaultMember6 helper method.
								If (R(2).Left + 90) >= .Left And (R(2).Left + R(2).Width - 90) <= (.Left + A(0).Width) Then 
									' ÃƒÂ¨ in range di larghezza
									' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Top'. Consider using the GetDefaultMember6 helper method.
									If (R(2).Top >= .Top) And (R(2).Top <= (.Top + A(0).Height - 30)) Then 
										' colpito!
										' definire le 5 immagini da eliminare...
										ME1 = Z
										Do
											If ME1 / 5 = Int(ME1 / 5) Then  Exit Do
											ME1 -= 1
										Loop
										For ME2 = ME1 To ME1 + 4
											NM2 = "M" & Y & VB.Right("0" & Trim(CStr(ME2)), 2)
											.Tag = "M"
											.Visible = False
										Next
										
										Pnl.Points = Pnl.Points + ((4 - Y) * 15)
										
										Colpo = False
										R(2).Visible = False
									End If
								End If
							End If
						End If
					End If
				End With
				Z += 1
			Next
		Next
		
		'--------------------------------
		' Sposta e visualizza le ev. bombe
		'--------------------------------
		Y = 0
		For I = 0 To MAXBombe
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'K(I).Tag'. Consider using the GetDefaultMember6 helper method.
			If K(I).Tag = "V" Then 
				K(I).Top = K(I).Top + (K(I).Height / 4)
				K(I).Tag = "R"
				If K(I).Top < (Shape1.Top + Shape1.Height) Then 
					K(I).Visible = True
					If (K(I).Left + 80 >= (SH.Left + 90)) And ((K(I).Left + K(I).Width - 80) <= ((SH.Left + SH.Width) - 60)) Then 
						' colpo in range orizz. con l'astronave
						If ((K(I).Top + K(I).Height) - 20) >= SH.Top Then 
							' ASTRONAVE COLPITA!
							Y = I
						End If
					End If
				Else
					K(I).Tag = ""
				End If
			End If
		Next
		
		If Y > 0 And finito = False Then 
			For J = 2 To 0 Step -1
				If Lives(J).Visible Then 
					K(Y).Tag = ""
					K(Y).Visible = False
					Lives(J).Visible = False
					For Z = 0 To 7
						SH.Picture = SE(Z).Picture
						TT = Timer6 + 0.1
						Do
							If Timer6 > TT Then 
								Exit Do
							End If
						Loop
						DoEvents6()
					Next
					TT = Timer6 + 1
					Do
						If Timer6 > TT Then 
							Exit Do
						End If
					Loop
					DoEvents6()
					Exit For
				End If
			Next
			If J = 0 Then 
				' FINITE LE VITE!
				SH.Picture = SE(7).Picture
				finito = True
				tmrMonster.Enabled = False
				MsgBox6("Spiacente, hai toppato.")
			Else
				SH.Picture = SE(8).Picture
			End If
		End If
		tmrBulletsMove.Enabled = True
		
	End Sub

	Private Sub tmrMonster_Timer() Handles tmrMonster.Timer
		Dim B As Short
		
		tmrMonster.Enabled = False
		
		If finito Then  Exit Sub
		
		B = GameGo()
		If B = 1 Then 
			tmrMonster.Enabled = True
		ElseIf B = -1 Then 
			MsgBox6("INVASION!")
		Else
			MsgBox6("GOOD JOB!")
			Text1.Text = ""
			Pnl.Level += 1
			LevelSetting()
			azzera()
			tmrMonster.Enabled = True
		End If
		
	End Sub

	Private Function GameGo() As Short
		Dim L As Short
		Dim I As Short
		Dim J As Short
		Dim NM As String = ""
		
		Dim FH(3) As Short
		Dim LH(3) As Short
		
		Dim T As Short
		Dim Z As Short
		Dim Y As Short
		
		Dim Lc1 As Short
		Dim ME1 As Short
		Dim ME2 As Short
		Dim NM2 As String = ""
		Dim CT As Boolean
		Dim MR As Short = 0
		Dim XMR As Short
		Dim XMM As Short
		Dim MT As Short
		
		Dim RN1 As Short
		Dim RN2 As Short
		
		'--------------------------------
		' Rende invisibili gli M attuali
		'--------------------------------
		XMR = ((MONperRIGA + 1) * 4)
		For Y = 0 To 3
			FH(Y) = -1
			J = 0
			For I = 0 To MONperRIGA
				NM = "M" & VB.Right("0" & Trim(CStr(J)), 2)
				With GMC(Y).Item(NM)
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Tag'. Consider using the GetDefaultMember6 helper method.
					If .Tag = "V" Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Left'. Consider using the GetDefaultMember6 helper method.
						If FH(Y) < 0 Then  FH(Y) = .Left
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Left'. Consider using the GetDefaultMember6 helper method.
						LH(Y) = .Left
						'.Visible = False
						MR += 1
					End If
				End With
				J += 1
			Next
		Next
		XMR = (XMR - MR)
		
		'-----------------------
		' Controlla esistenza M
		'-----------------------
		If MR < 1 Then 
			Return 0
		End If

		'----------------------------------------------
		' controlla se si ÃƒÂ¨ raggiunto il limite minimo
		' o il limite massimo, dipendentemente dalla
		' direzione dei M
		'----------------------------------------------
		J = 0
		XMM = CShort(XMR * 1.5)
		Select Case MM
		Case Is < 0
			XMM = -XMM
			' vanno verso sinistra
			'----------------------
			'trova il piÃƒÂ¹ vicino a sinistra
			L = POmx
			For I = 0 To 3
				If (FH(I) < L) And (FH(I) > 0) Then  L = FH(I)
			Next
			' controlla limite sinistro
			If L + MM < POmn Then 
				J = 1
			End If
		Case Else
			' vanno verso destra
			'----------------------
			'trova il piÃƒÂ¹ vicino a destra
			L = POmn
			For I = 0 To 3
				If (LH(I) > L) And (LH(I) > 0) Then  L = LH(I)
			Next
			' controlla limite destro
			If L + MM > POmx Then 
				J = 1
			End If
		End Select
		
		TiIn = ((11 - Pnl.Level) * 10) + MR
		tmrMonster.Interval = TiIn
		
		If J Then 
			' se si ÃƒÂ¨ raggiunto un limite,
			' cambia la direzione di marcia
			' e incrementa il TOP
			MM = -MM
			
			TP = TP + (A(0).Height / 3)
		End If
		T = TP
		
		'-----------------------------------
		' incrementa contatore animazione M
		'-----------------------------------
		An += AnM
		If (An > 4) Or (An < 0) Then 
			AnM = -AnM
			An = (An + (AnM * 2))
		End If
		
		'------------------------------------------
		' incrementa posizione orizzontale degli M
		' e visualizza nuova immagine per animazione
		'------------------------------------------
		Randomize(Timer6)
		RN1 = Int(Rnd() * (255 - (XMR * 2.5))) + 1
		M(0).Visible = True
		For Y = 0 To 3
			Select Case Y
			Case Is = 0: M(0).Picture = A(An).Picture
			Case Is = 1: M(0).Picture = B(An).Picture
			Case Is = 2: M(0).Picture = C(An).Picture
			Case Is = 3: M(0).Picture = D(An).Picture
			End Select
			For I = 1 To GMC(Y).Count()
				With GMC(Y).Item(I)
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Left'. Consider using the GetDefaultMember6 helper method.
					Lc1 = .Left + (MM + XMM)
					.Left = Lc1
					.Top = T
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Tag'. Consider using the GetDefaultMember6 helper method.
					If .Tag = "V" Then 
						.Picture = M(0).Picture
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Top'. Consider using the GetDefaultMember6 helper method.
						MT = .Top
						
						RN2 = Int(Rnd() * (255 - (XMR * 2.5))) + 1
						If RN2 = RN1 Then 
							For RN1 = 0 To CShort(MAXBombe - (XMR / 8))
								' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'K(RN1).Tag'. Consider using the GetDefaultMember6 helper method.
								If K(RN1).Tag = "" Then 
									K(RN1).Tag = "V"
									' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Top'. Consider using the GetDefaultMember6 helper method.
									' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Height'. Consider using the GetDefaultMember6 helper method.
									K(RN1).Top = .Top + (.Height + 15)
									' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Left'. Consider using the GetDefaultMember6 helper method.
									K(RN1).Left = .Left
									Exit For
								End If
							Next
						End If
					End If
				End With
			Next
			T = T + A(0).Height + 15
		Next
		
		'----------------------------
		' controlla se hanno invaso!
		'----------------------------
		If MT > (SH.Top - A(0).Height) Then 
			Return -1
		Else
			Return 1
		End If
		
	End Function

	Private Sub TmrRk_Timer() Handles TmrRk.Timer
		' anima il rocket sparato dalla ship
		If R(2).Picture Is R(0).Picture Then 
			R(2).Picture = R(1).Picture
		ElseIf R(2).Picture Is R(1).Picture Then 
			R(2).Picture = R(3).Picture
		Else
			R(2).Picture = R(0).Picture
		End If
		Dim I As Short
		
		' anima le bombe lanciate dai M
		For I = 0 To MAXBombe
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'K(I).Tag'. Consider using the GetDefaultMember6 helper method.
			If K(I).Visible Or K(I).Tag = "V" Then 
				If K(I).Picture Is MI(1).Picture Then 
					K(I).Picture = MI(0).Picture
				Else
					K(I).Picture = MI(1).Picture
				End If
			End If
		Next
		
		'----------------------------
		' Aggiorna il pannello
		'----------------------------
		lblPoints.Caption = Pnl.Points
		lblLevel.Caption = Pnl.Level
		
	End Sub

	Public Sub LevelSetting()
		'----------------------------
		' Aggiorna il timer
		'----------------------------
		TiIn = ((11 - Pnl.Level) * 10) + 50
		tmrMonster.Interval = TiIn
	End Sub

End Class
