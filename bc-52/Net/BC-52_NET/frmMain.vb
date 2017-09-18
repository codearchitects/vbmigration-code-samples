' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmMain

	Private pblnMoveFrom As Boolean
	Private pBlnKeyLock As Boolean
	
	Private Sub Form_Load() Handles MyBase.Load
		lblWindow_001.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_001.BackColor = Color.FromArgb(44, 44, 44)
		lblWindow_002.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_002.BackColor = Color.FromArgb(44, 44, 44)
		lblWindow_003.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_003.BackColor = Color.FromArgb(44, 44, 44)
		lblWindow_004.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_004.BackColor = Color.FromArgb(44, 44, 44)
		lblWindow_005.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_005.BackColor = Color.FromArgb(44, 44, 44)
		lblWindow_006.BackStyle = VB6BackStyleConstants.Opaque
		lblWindow_006.BackColor = Color.FromArgb(44, 44, 44)
	End Sub

	Private Sub imgAbout_Click() Handles imgAbout.Click
		'about
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		frmInfo.Show((VBRUN.FormShowConstants.vbModal))
	End Sub

	Private Sub imgAdvance_Click() Handles imgAdvance.Click
		'advance paper and check for maximum display length
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		Me.lblInput.Caption &= " "
		Me.lblOutput.Caption &= " "
		If Len6(Me.lblInput.Caption) > 34 Then 
			Me.lblInput.Caption = VB.Right(Me.lblInput.Caption, 34)
			Me.lblOutput.Caption = VB.Right(Me.lblOutput.Caption, 34)
		Else
		End If
		PlaySound((2))
	End Sub

	Private Sub imgAdvance_DblClick() Handles imgAdvance.DblClick
		Call imgAdvance_Click()
	End Sub

	Private Sub imgBackground_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles imgBackground.MouseMove
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
	End Sub

	Private Sub imgHandleSwitch_Click() Handles imgHandleSwitch.Click
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		If gblnModeCipher = True Then 
			gblnModeCipher = False
			Me.imgHandle.Picture = Nothing
		Else
			gblnModeCipher = True
			Me.imgHandle.Picture = Me.picHandle.Picture
		End If
		PlaySound((2))
	End Sub

	Private Sub imgHelp_Click() Handles imgHelp.Click
		'show helpfile
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		Call PlaySound(2)
		Me.Dialog1.HelpFile = App6.Path & "\BC-52.hlp"
		Me.Dialog1.HelpCommand = MSComDlg.HelpConstants.cdlHelpContents
		Me.Dialog1.ShowHelp()
	End Sub

	Private Sub imgMenu_Click() Handles imgMenu.Click
		Dim k As Short
		If Me.Timer1.Enabled = True Then 
			Me.lblInfo.Visible = False
			Me.Timer1.Enabled = False
		End If
		If Me.lblOffset.Visible = True Then  Me.lblOffset.Visible = False
		If Me.picMenu.Visible = False Then 
			For k = 0 To 8
				Me.lblMenu(k).BackColor = Color.White 
			Next
			Me.imgMenu.ToolTipText = ""
			Me.picMenu.Visible = True
		Else
			Me.picMenu.Visible = False
			Me.imgMenu.ToolTipText = " Click Here for Menu "
		End If
	End Sub

	Private Sub imgMenu_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles imgMenu.MouseMove
		If Me.picMenu.Visible = False Then  Me.picMenu.Visible = True
	End Sub

	Private Sub imgOffsetDn_Click() Handles imgOffsetDn.Click
		'dial offset -
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		If Me.lblOffset.Visible = False Then 
			Me.lblOffset.Visible = True
			Me.lblOffset.Caption = "A=" & Chr6(gintWheelOffset + 65)
		Else
			gintWheelOffset -= 1: If gintWheelOffset < 0 Then  gintWheelOffset = 25
			Me.lblOffset.Caption = "A=" & Chr6(gintWheelOffset + 65)
		End If
		Call PlaySound(2)
	End Sub

	Private Sub imgOffsetDn_DblClick() Handles imgOffsetDn.DblClick
		Call imgOffsetDn_Click()
	End Sub

	Private Sub imgOffsetUp_Click() Handles imgOffsetUp.Click
		'dial offset +
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		If Me.lblOffset.Visible = False Then 
			Me.lblOffset.Visible = True
			Me.lblOffset.Caption = "A=" & Chr6(gintWheelOffset + 65)
		Else
			gintWheelOffset += 1: If gintWheelOffset > 25 Then  gintWheelOffset = 0
			Me.lblOffset.Caption = "A=" & Chr6(gintWheelOffset + 65)
		End If
		Call PlaySound(2)
	End Sub

	Private Sub imgOffsetUp_DblClick() Handles imgOffsetUp.DblClick
		Call imgOffsetUp_Click()
	End Sub

	Private Sub imgOpen_Click() Handles imgOpen.Click
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		frmKey.Show((VBRUN.FormShowConstants.vbModal))
	End Sub

	Private Sub imgResetCounter_Click() Handles imgResetCounter.Click
		'rest sounter
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		Me.lblCounter.Caption = "000"
		glngGroupCount = 0
		gstrCounter = 0
		PlaySound((2))
	End Sub

	Private Sub imgSound_Click() Handles imgSound.Click
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		If gblnSound = True Then 
			gblnSound = False
			Me.imgSound.ToolTipText = " Sound On "
			Me.imgSound.Picture = Me.picSoundOff.Picture
		Else
			gblnSound = True
			Me.imgSound.ToolTipText = " Sound Off "
			Me.imgSound.Picture = Me.picSoundOn.Picture
		End If
	End Sub

	Private Sub lblInfo_Click() Handles lblInfo.Click
		Me.Timer1.Enabled = False
		Me.lblInfo.Visible = False
		Call imgMenu_Click()
	End Sub

	Private Sub lblInput_Click() Handles lblInput.Click
		'clipboard
		frmClipBoard.Show((VBRUN.FormShowConstants.vbModal))
	End Sub

	Private Sub lblMenu_Click(ByRef Index As Short)
		'menu click
		Me.picMenu.Visible = False
		Select Case Index
		Case 0
			frmClipBoard.Show((VBRUN.FormShowConstants.vbModal))
		Case 1
			frmQuick.Show((VBRUN.FormShowConstants.vbModal))
		Case 2
			frmKeySheet.Show((VBRUN.FormShowConstants.vbModal))
		Case 3
			frmCustom.Show((VBRUN.FormShowConstants.vbModal))
		Case 4
			Call SaveFile()
		Case 5
			Call OpenFile()
		Case 6
			Call EndProgram()
		Case 7
			frmKey.Show((VBRUN.FormShowConstants.vbModal))
		Case 8
			Call imgHelp_Click()
		End Select
		
	End Sub

	Private Sub lblMenu_MouseMove(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Dim k As Short
		For k = 0 To 8
			Me.lblMenu(k).BackColor = Color.White 
		Next
		Me.lblMenu(Index).BackColor = Color.Silver 
	End Sub

	Private Sub lblOutput_Click() Handles lblOutput.Click
		'clipboard
		frmClipBoard.Show((VBRUN.FormShowConstants.vbModal))
	End Sub

	Private Sub WheelDn_Click(ByRef Index As Short)
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		Wpos(Index) -= 1
		PlaySound((2))
		If Wpos(Index) < 0 Then  Wpos(Index) = Wmax(Index)
		SetWheelView((Index))
	End Sub

	Private Sub WheelDn_DblClick(ByRef Index As Short)
		Call WheelDn_Click(Index)
	End Sub

	Private Sub WheelUp_Click(ByRef Index As Short)
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		PlaySound((2))
		Wpos(Index) += 1
		If Wpos(Index) > Wmax(Index) Then  Wpos(Index) = 1
		SetWheelView((Index))
	End Sub

	Private Sub WheelUp_DblClick(ByRef Index As Short)
		Call WheelUp_Click(Index)
	End Sub

	Private Sub imgExit_Click() Handles imgExit.Click
		'exit program
		'Call PlaySound(2)
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		Call EndProgram()
	End Sub

	'--------------------------------------------------------------------
	' form movement
	'--------------------------------------------------------------------
	
	Private Sub picTitleBar_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles picTitleBar.MouseDown
		'get mouse movement
		Dim POINT As POINTAPI
		GetCursorPos(POINT)
		LastPoint.X = POINT.X
		LastPoint.Y = POINT.Y
		pblnMoveFrom = True
	End Sub

	Private Sub picTitleBar_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles picTitleBar.MouseMove
		'if mouse is down, move the form
		Dim iDX As Integer
		Dim iDY As Integer
		Dim POINT As POINTAPI
		If Not pblnMoveFrom Then 
			Exit Sub
		End If
		GetCursorPos(POINT)
		iDX = (POINT.X - LastPoint.X) * iTPPX
		iDY = (POINT.Y - LastPoint.Y) * iTPPY
		LastPoint.X = POINT.X
		LastPoint.Y = POINT.Y
		Me.Move(Me.Left + iDX, Me.Top + iDY)
	End Sub

	Private Sub picTitleBar_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles picTitleBar.MouseUp
		'release form
		pblnMoveFrom = False
	End Sub

	'---keys
	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		If pBlnKeyLock = True Then  Exit Sub
		Dim k As Short
		Dim i As Short
		
		If Me.picMenu.Visible = True Then  Me.picMenu.Visible = False
		If Me.lblOffset.Visible = True Then  Me.lblOffset.Visible = False
		
		Select Case KeyCode
		Case 64 To 90, 32
			'Call PlaySound(2)
			pBlnKeyLock = True
			If KeyCode = 32 And gblnModeCipher = True Then 
				'if cipher mode, replace space by gstrSpaceLetter
				KeyCode = Asc(gstrSpaceLetter)
			ElseIf KeyCode = 32 And gblnModeCipher = False Then 
				KeyCode = 0
				Exit Sub
			End If
			'set dial
			gintAlphaWheel = KeyCode - 64
			Me.imgKey(gintAlphaWheel).Picture = Me.picKey(gintAlphaWheel).Picture
			k = gintLastDialView
			If gblnFastRun = False Then 
				Do While k <> gintAlphaWheel
					Call SetDialView(k)
					PauzeTime((5))
					k += 1
					If k > 26 Then  k -= 26
					PlaySound((2))
				Loop
			End If
			Call SetDialView(gintAlphaWheel)
		Case 46
			'delet ribbon
			glngGroupCount = 0
			gstrInput = ""
			gstrOutput = ""
			' UPGRADE_INFO (#0181): Reference to default form instance 'frmMain' was converted to Me keyword.
			Me.lblInput.Caption = ""
			' UPGRADE_INFO (#0181): Reference to default form instance 'frmMain' was converted to Me keyword.
			Me.lblOutput.Caption = ""
			glngGroupCount = 0
		Case 116
			'clipboard
			frmClipBoard.Show((VBRUN.FormShowConstants.vbModal))
		Case 119
			'key sheet
			frmKeySheet.Show((VBRUN.FormShowConstants.vbModal))
		Case 117
			'autotyping
			frmQuick.Show((VBRUN.FormShowConstants.vbModal))
		Case 45
			'INS, memorize wheel positions
			Call MemorizeWheels()
		Case 36
			'HOME, reset all wheels to memorized pos
			For k = 1 To 6
				i = gintPosMemo(k)
				If i <> 0 And i <= Wmax(k) Then 
					Wpos(k) = i
				Else
					Wpos(k) = 1
				End If
				SetWheelView((k))
			Next
		Case 27
			'ESC, abort autotyping
			gstrAutotype = False
		Case 121
			'customize wheels and machine
			frmCustom.Show((VBRUN.FormShowConstants.vbModal))
		End Select
	End Sub

	Private Sub Form_KeyUp(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyUp
		Select Case KeyCode
		Case 64 To 90, 32
			'encrypt letter
			If KeyCode = 32 And gblnModeCipher = True Then 
				'if cipher mode, replace space by gstrSpaceLetter
				KeyCode = Asc(gstrSpaceLetter)
			ElseIf KeyCode = 32 And gblnModeCipher = False Then 
				KeyCode = 0
				pBlnKeyLock = False
				Exit Sub
			End If
			gintAlphaWheel = KeyCode - 64
			Me.imgKey(gintAlphaWheel).Picture = Nothing
			If gblnFastRun = False Then 
				PlaySound((1))
			Else
				Call PlaySound(2)
			End If
			Call Crypto(gintAlphaWheel)
		End Select
		pBlnKeyLock = False
	End Sub

	Private Sub imgKey_MouseDown(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Call Form_KeyDown(Index + 64, 0)
		If Me.lblOffset.Visible = True Then  Me.lblOffset.Visible = False
	End Sub

	Private Sub imgKey_MouseUp(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Call Form_KeyUp(Index + 64, 0)
		If Me.lblOffset.Visible = True Then  Me.lblOffset.Visible = False
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		' display flashing message at start pointing to readme
		Static flashCount As Short
		flashCount += 1
		Select Case flashCount
		Case 1, 3, 5, 7
			Me.lblInfo.Visible = False
		Case 2, 4, 6, 8
			Me.lblInfo.Visible = True
		Case 24
			Me.Timer1.Enabled = False
			Me.lblInfo.Visible = False
		End Select
	End Sub

End Class
