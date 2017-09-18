' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub cmdExit_Click() Handles cmdExit.Click
		Unload6(Me)
	End Sub

	Private Sub cmdHide_Click() Handles cmdHide.Click
		Me.Visible = False
	End Sub

	Private Sub cmdLoadFile_Click() Handles cmdLoadFile.Click
		Dim FName As String = ""
		comDlg.ShowOpen
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'comDlg.FileName'. Consider using the GetDefaultMember6 helper method.
		FName = comDlg.FileName
		If Len6(FName) Then 
			LoadDataFromFile(FName)
		End If
	End Sub

	Private Sub cmdPlay_Click() Handles cmdPlay.Click
		StartPlaying()
	End Sub

	Private Sub cmdRec_Click() Handles cmdRec.Click
		SaveDataToFile()
		StartRecording()
	End Sub

	Private Sub cSetFile_Click() Handles cSetFile.Click
		SaveDataToFile()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Me.Top = Screen6.Height - Me.Height * 1.3
		Me.Left = Screen6.Width - Me.Width * 1.1
		If App6.PrevInstance Then 
			MsgBox6("Mouse Recorder is already runing!" & ControlChars.CrLf & "Press [F12] to show Recorder Window.", MsgBoxStyle.Information, "Error!")
			Unload6(Me)
		End If
		Do While GetAsyncKeyState(&H7B): Loop ' F12 '
		Do While GetAsyncKeyState(&H79): Loop ' F10 '
		Do While GetAsyncKeyState(&H78): Loop ' F9  '
		Do While GetAsyncKeyState(&H13): Loop 'pause'
		tControl.Enabled = True
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		tControl.Enabled = False
		If Len6(Dir6(ApplPath() & "playfrm.shp")) Then  Kill(ApplPath() & "playfrm.shp")
		If Len6(Dir6(ApplPath() & "recfrm.shp")) Then  Kill(ApplPath() & "recfrm.shp")
		DoEvents6()
		Application.Exit(): End
	End Sub

	Private Sub tControl_Timer() Handles tControl.Timer
		Static OldMX As Integer
		Static OldMY As Integer
		Static LastTmr As Double
		Static OldST As String
		Static lSAn As Boolean
		Static lSTmr As Double
		Static PlayMotionID As Integer
		Static OBL As Boolean
		Static OBR As Boolean
		Static OBM As Boolean
		Static OKP As Boolean
		Static OKF12 As Boolean
		Static OKF10 As Boolean
		Static OKF9 As Boolean
		Static NBL As Boolean
		Static NBR As Boolean
		Static NBM As Boolean
		Static NKP As Boolean
		Static NKF12 As Boolean
		Static NKF10 As Boolean
		Static NKF9 As Boolean
		Static BlTmr As Double
		Static BlCntr As Integer
		Static PlayTmr As Double
		Dim Key_F12_Pressed As Boolean
		Dim Key_F10_Pressed As Boolean
		Dim Key_F9_Pressed As Boolean
		Dim Key_Pause_Pressed As Boolean
		Dim Btn_Left_Pressed As Boolean
		Dim Btn_Right_Pressed As Boolean
		Dim Btn_Middle_Pressed As Boolean
		Dim i As Integer
		Dim NewMX As Integer
		Dim NewMY As Integer
		NewMX = MouseX(): NewMY = MouseY()
		
		' F10 - &H79  F9 - &H78  Pause - &H13  F12 - &H7B '
		If GetAsyncKeyState(&H1) Then  NBL = True Else NBL = False
		If GetAsyncKeyState(&H2) Then  NBR = True Else NBR = False
		If GetAsyncKeyState(&H4) Then  NBM = True Else NBM = False
		If GetAsyncKeyState(&H7B) Then  NKF12 = True Else NKF12 = False
		If GetAsyncKeyState(&H79) Then  NKF10 = True Else NKF10 = False
		If GetAsyncKeyState(&H78) Then  NKF9 = True Else NKF9 = False
		If GetAsyncKeyState(&H13) Then  NKP = True Else NKP = False
		
		If Not NBL And OBL Then  Btn_Left_Pressed = True 'L Btn'
		If Not NBR = 0 And OBR Then  Btn_Right_Pressed = True 'R Btn'
		If Not NBM = 0 And OBM Then  Btn_Middle_Pressed = True 'M Btn'
		If Not NKF12 And OKF12 Then  Key_F12_Pressed = True ' F12 '
		If Not NKF10 And OKF10 Then  Key_F10_Pressed = True ' F10 '
		If Not NKF9 And OKF9 Then  Key_F9_Pressed = True ' F9  '
		If Not NKP And OKP Then  Key_Pause_Pressed = True 'Pause'
		
		OBL = NBL
		OBR = NBR
		OBM = NBM
		OKF12 = NKF12
		OKF10 = NKF10
		OKF9 = NKF9
		OKP = NKP

		If BlTmr < Timer6 And BlCntr < 21 Then 
			BlTmr = Timer6 + 0.3
			If lInfo(2).ForeColor.Equals(Color.Black) Then 
				lInfo(2).ForeColor = FromOleColor6(&HC0%)
				lInfo(2).BackColor = Color.White 
			Else
				lInfo(2).ForeColor = Color.Black 
				lInfo(2).BackColor = Me.BackColor
			End If
			BlCntr += 1
		End If
		If Key_F12_Pressed Then  Me.Visible = Not Me.Visible
		If RecorderState = rsIdle Then 
			If Key_F10_Pressed Then  StartRecording()
			If Key_F9_Pressed Then  StartPlaying()
		Else
			If Key_Pause_Pressed Then  RecorderState = rsIdle
		End If
		If OldMX <> NewMX Or OldMY <> NewMY Then 
			' Mouse was moved '
			lMousePos.Caption = Format6(NewMX, "000") & ", " & Format6(NewMY, "000")
		End If
		Select Case RecorderState
			' Recording     '
		Case rsRecording
			If cmdPlay.Enabled Then  cmdPlay.Enabled = False
			If OldST <> rsRecording Then 
				cmdRec.Picture = pStop.Picture
				If cWndAutoHide.Value And Me.Visible = True Then  Me.Visible = False
				If MotionData.Count() Then 
					Do Until MotionData.Count() = 0
						MotionData.Remove(1)
					Loop
				End If
			End If
			If cRecMovement.Value Then 
				If OldMX <> NewMX Or OldMY <> NewMY Then 
					' Mouse was moved '
					If LastTmr Then 
						LastTmr = Math.Round(Timer6 - LastTmr, 3)
						If LastTmr < 0 Then  LastTmr = 0
						AddMotion(NewMX, NewMY, Replace(LastTmr, ",", "."), "move")
					End If
					LastTmr = Timer6
				End If
			End If
			If cRecLeftClick.Value And Btn_Left_Pressed Then 
				' Left Mouse Button was Pressed '
				If LastTmr Then 
					LastTmr = Math.Round(Timer6 - LastTmr, 3) * 1000
					If LastTmr < 0 Then  LastTmr = 0
					AddMotion(NewMX, NewMY, Replace(LastTmr, ",", "."), "Left")
				End If
				LastTmr = Timer6
			End If
			If cRecMiddleClick.Value And Btn_Middle_Pressed Then 
				' Left Mouse Button was Pressed '
				If LastTmr Then 
					LastTmr = Math.Round(Timer6 - LastTmr, 3) * 1000
					If LastTmr < 0 Then  LastTmr = 0
					AddMotion(NewMX, NewMY, Replace(LastTmr, ",", "."), "Middle")
				End If
				LastTmr = Timer6
			End If
			If cRecRightClick.Value And Btn_Right_Pressed Then 
				' Left Mouse Button was Pressed '
				If LastTmr Then 
					LastTmr = Math.Round(Timer6 - LastTmr, 3) * 1000
					If LastTmr < 0 Then  LastTmr = 0
					AddMotion(NewMX, NewMY, Replace(LastTmr, ",", "."), "Right")
				End If
				LastTmr = Timer6
			End If
			' Playing       '
		Case rsPlaying
			If cmdRec.Enabled Then  cmdRec.Enabled = False
			If OldST <> rsPlaying Then 
				cmdPlay.Picture = pStop.Picture
				If cWndAutoHide.Value And Me.Visible = True Then  Me.Visible = False
			End If
			If PlayTmr < Timer6 Then 
				PlayMotionID += 1
				If PlayMotionID > MotionData.Count() Then 
					If MotionData.Count() = 0 Then 
						OldST = rsPlaying
						RecorderState = rsIdle
						MsgBox6("No Data loaded for Playback!", MsgBoxStyle.Information, "Error!")
					End If
					' if loop = false then
					'  OldST = rsPlaying
					'  RecorderState = rsIdle
					' else
					PlayMotionID = 0
					' end if
				Else
					' Play Data here    '
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
					Select Case UCase(Trim(GetToken(MotionData.Item(PlayMotionID), 1, ",")))
					Case "MOVE"
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						MouseRoutines.MouseMove(Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ","))))
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						PlayTmr = Timer6 + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
					Case "LEFT"
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						MouseRoutines.MouseMove(Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ","))))
						MouseLeftClick()
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						PlayTmr = Timer6 + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
					Case "MIDDLE"
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						MouseRoutines.MouseMove(Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ","))))
						MouseMiddleClick()
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						PlayTmr = Timer6 + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
					Case "RIGHT"
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						MouseRoutines.MouseMove(Val(Trim(GetToken(MotionData.Item(PlayMotionID), 2, ","))), Val(Trim(GetToken(MotionData.Item(PlayMotionID), 3, ","))))
						MouseRightClick()
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(PlayMotionID)'. Consider using the GetDefaultMember6 helper method.
						PlayTmr = Timer6 + Val(Trim(GetToken(MotionData.Item(PlayMotionID), 4, ","))) / 1000
					End Select
				End If
			End If
			' Idle          '
		Case Else
			If PlayMotionID Then  PlayMotionID = 0
			If cmdRec.Enabled = False Then  cmdRec.Enabled = True
			If cmdPlay.Enabled = False Then  cmdPlay.Enabled = True
			If LastTmr Then  LastTmr = 0
			If PlayTmr Then  PlayTmr = 0
			If RecorderState <> rsIdle Then  RecorderState = rsIdle
			If OldST <> rsIdle Then 
				If OldST = rsRecording Then 
					cmdRec.Picture = pRec.Picture
				Else
					cmdPlay.Picture = pPlay.Picture
				End If
				If cWndAutoShow.Value And Me.Visible = False Then  Me.Visible = True
			End If
			If OldST = rsRecording And SaveData Then 
				' Save Recorded Data to a file  '
				'SaveDataToFile
			End If
		End Select
		' Blinked Status View       '
		If RecorderState = rsRecording Or RecorderState = rsPlaying Then 
			If OldST <> RecorderState Then 
				lSAn = False
				lState.Caption = "[" & UCase(RecorderState) & "]"
			End If
			If lSTmr < Timer6 Then 
				lSTmr = Timer6 + 0.3
				lSAn = Not lSAn
				lState.Visible = lSAn
				If RecorderState = rsRecording Then 
					If frmRec.Visible = False Then  frmRec.Visible = True
					If lSAn Then 
						frmRec.Top = 0
					Else
						frmRec.Top = -frmRec.Height
					End If
					If Not lState.ForeColor.Equals(Color.Red) Then  lState.ForeColor = Color.Red 
				Else
					If Not lState.ForeColor.Equals(Color.Lime) Then  lState.ForeColor = Color.Lime 
					If frmPlay.Visible = False Then  frmPlay.Visible = True
					If lSAn Then 
						frmPlay.Top = 0
					Else
						frmPlay.Top = -frmPlay.Height
					End If
				End If
			End If
		Else
			If lState.Visible Then 
				lState.Visible = False
				Unload6(frmRec)
				Unload6(frmPlay)
			End If
		End If
		OldMX = NewMX
		OldMY = NewMY
		OldST = RecorderState
	End Sub

End Class
