' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdWindowsDir_Click() Handles cmdWindowsDir.Click
		MsgBox6("Windows Directory = " & WindowsDirectory(), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdSystemDir_Click() Handles cmdSystemDir.Click
		MsgBox6("System Directory = " & SystemDirectory(), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdTempDir_Click() Handles cmdTempDir.Click
		MsgBox6("Temporary Directory = " & TemporaryDirectory(), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdUserName_Click() Handles cmdUserName.Click
		MsgBox6("User Name = " & UserName(), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdComputerName_Click() Handles cmdComputerName.Click
		MsgBox6("Computer Name = " & ComputerName, MsgBoxStyle.Information)
	End Sub

	Private Sub cmdWindowsVersion_Click() Handles cmdWindowsVersion.Click
		Dim msg As String = IIf(WindowsNT(), "Windows NT", "Windows 95/98") & " version " & WindowsVersion() & ControlChars.CrLf & "Build Number = " & WindowsBuildNumber()
		MsgBox6(msg, MsgBoxStyle.Information)
	End Sub

	Private Sub cmdMouseInfo_Click() Handles cmdMouseInfo.Click
		MsgBox6("Mouse Buttons = " & MouseButtonsNumber(), MsgBoxStyle.Information)
	End Sub

	Private Sub cmdMoveMouse_Click() Handles cmdMoveMouse.Click
		' Move mouse cursor to the center of the mouse frame.
		MoveMouseCursor(ScaleX(fraMouse.Width, VBRUN.ScaleModeConstants.vbTwips, VBRUN.ScaleModeConstants.vbPixels) \ 2, ScaleY(fraMouse.Height, VBRUN.ScaleModeConstants.vbTwips, VBRUN.ScaleModeConstants.vbPixels) \ 2, fraMouse.hWnd)
	End Sub

	Private Sub cmdMouseHide_Click() Handles cmdMouseHide.Click
		Static IsHidden As Boolean
		
		If IsHidden Then 
			MouseShow()
			cmdMouseHide.Caption = "Mouse &Hide"
			IsHidden = False
		Else
			MouseHide()
			cmdMouseHide.Caption = "Mouse S&how"
			IsHidden = True
		End If
	End Sub

	'-------------------------------------
	' Update state information
	'-------------------------------------
	
	Private Sub Timer1_Timer() Handles Timer1.Timer
		Dim msg As String = ""
		' Show shift key state.
		If ShiftKey() Then  msg &= "SHIFT "
		If CtrlKey() Then  msg &= "CTRL "
		If AltKey() Then  msg &= "ALT "
		If msg = "" Then  msg = "Try pressing Ctrl-Alt-A when another app has the focus"
		lblKeyboard.Caption = msg
		
		' Show lock key state.
		If (GetCapsLock() And 1) <> chkLockKey(0).Value Then 
			chkLockKey(0).Value = GetCapsLock() And 1
		End If
		If (GetNumLock() And 1) <> chkLockKey(1).Value Then 
			chkLockKey(1).Value = GetNumLock() And 1
		End If
		If (GetScrollLock() And 1) <> chkLockKey(2).Value Then 
			chkLockKey(2).Value = GetScrollLock() And 1
		End If
		
		' React to Ctrl+Alt+A hotkey.
		If KeysPressed(VBRUN.KeyCodeConstants.vbKeyA, VBRUN.KeyCodeConstants.vbKeyMenu, VBRUN.KeyCodeConstants.vbKeyControl) Then 
			MsgBox6("Ctrl+Alt+A pressed", MsgBoxStyle.Exclamation)
		End If
		
		' Show mouse button state
		msg = "X = " & MouseX() & "   Y = " & MouseY() & "   "
		
		If LeftButton() Then  msg &= "LEFT "
		If MiddleButton() Then  msg &= "MIDDLE "
		If RightButton() Then  msg &= "RIGHT"
		msg = msg & "[ " & ObjectFromMouse() & " ]"
		lblMouse.Caption = msg
		
	End Sub

	' Change the state of a lock key.
	
	Private Sub chkLockKey_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			SetCapsLock(chkLockKey(Index).Value)
		Case 1
			SetNumLock(chkLockKey(Index).Value)
		Case 2
			SetScrollLock(chkLockKey(Index).Value)
		End Select
	End Sub

	Private Sub chkClipMouse_Click() Handles chkClipMouse.Click
		If chkClipMouse.Value Then 
			ClipMouseToWindow(chkClipMouse.hWnd)
		Else
			ClearClipMouse()
		End If
	End Sub

	Private Sub fraMouse_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles fraMouse.MouseMove
		' When the mouse enters the frame, change the backcolor and set the mouse capture.
		If GetMouseCapture() <> fraMouse.hWnd Then 
			SetMouseCapture(fraMouse.hWnd)
			fraMouse.BackColor = Color.Yellow 
		ElseIf X < 0 Or Y < 0 Or X > fraMouse.Width Or Y > fraMouse.Height Then 
			SetMouseCapture(0)
			fraMouse.BackColor = SystemColors.Control 
		End If
	End Sub

	' Return the name of the control under the mouse.
	
	Public Function ObjectFromMouse() As String
		Dim handle As Integer
		Dim ctrl As Object = Nothing
		
		On Error Resume Next 
		
		handle = WindowFromMouse()
		If handle = Me.hWnd Then 
			Return "Form"
		End If
		
		For Each ctrl In Me.Controls6
			If CObj(ctrl).hWnd <> handle Then 
				' Not on this control, or hWnd property not supported.
			Else
				ObjectFromMouse = ctrl.Name
				' In case it is part of a control array.
				Return ctrl.Name & "(" & CObj(ctrl).Index & ")"
			End If
		Next
		
	End Function

End Class
