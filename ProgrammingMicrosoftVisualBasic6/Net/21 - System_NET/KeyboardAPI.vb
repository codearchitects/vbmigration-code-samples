' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module KeyboardAPI

	Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	Private Declare Function GetKeyboardState Lib "user32" (ByRef pbKeyState As Byte) As Integer
	' UPGRADE_INFO (#0511): The 'SetKeyboardState' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Declare Function SetKeyboardState Lib "user32" (ByRef lppbKeyState As Byte) As Integer
	Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
	Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Integer
	Private Const KEYEVENTF_KEYUP As Short = &H2S
	
	' Return True if the Ctrl key is pressed.
	
	Public Function CtrlKey() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyControl) And &H8000)
	End Function

	' Return True if the Shift key is pressed.
	
	Public Function ShiftKey() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyShift) And &H8000)
	End Function

	' Return True if the Alt key is pressed.
	
	Public Function AltKey() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyMenu) And &H8000)
	End Function

	' Return True if a given key is pressed.
	
	Public Function KeysPressed(ByVal KeyCode1 As VBRUN.KeyCodeConstants, Optional ByVal KeyCode2 As VBRUN.KeyCodeConstants = 0, Optional ByVal KeyCode3 As VBRUN.KeyCodeConstants = 0) As Boolean
		If GetAsyncKeyState(KeyCode1) >= 0 Then  Exit Function
		If KeyCode2 = 0 Then  Return True
		If GetAsyncKeyState(KeyCode2) >= 0 Then  Exit Function
		If KeyCode3 = 0 Then  Return True
		If GetAsyncKeyState(KeyCode3) >= 0 Then  Exit Function
		Return True
	End Function

	' Read the state of CapsLock.
	
	Public Function GetCapsLock() As Boolean
		' get current state of all 256 virtual keys
		Dim keystat(255) As Byte
		GetKeyboardState(keystat(0))
		' for toggle keys, bit 0 reflects the current state
		Return (keystat(VBRUN.KeyCodeConstants.vbKeyCapital) And 1)
	End Function

	' Modify the state of CapsLock.
	
	Public Sub SetCapsLock(ByVal newState As Boolean)
		' if the current state must be changed
		If CBool(GetKeyState(VBRUN.KeyCodeConstants.vbKeyCapital)) <> newState Then 
			' programmatically press and release the CapsLock key
			keybd_event(VBRUN.KeyCodeConstants.vbKeyCapital, 0, 0, 0)
			keybd_event(VBRUN.KeyCodeConstants.vbKeyCapital, 0, KEYEVENTF_KEYUP, 0)
		End If
	End Sub

	' Read the state of ScrollLock.
	
	Public Function GetScrollLock() As Boolean
		' get current state of all 256 virtual keys
		Dim keystat(255) As Byte
		GetKeyboardState(keystat(0))
		' for toggle keys, bit 0 reflects the current state
		Return (keystat(VBRUN.KeyCodeConstants.vbKeyScrollLock) And 1)
	End Function

	' Modify the state of ScrollLock.
	
	Public Sub SetScrollLock(ByVal newState As Boolean)
		' if the current state must be changed
		If CBool(GetKeyState(VBRUN.KeyCodeConstants.vbKeyScrollLock)) <> newState Then 
			' programmatically press and release the ScrollLock key
			keybd_event(VBRUN.KeyCodeConstants.vbKeyScrollLock, 0, 0, 0)
			keybd_event(VBRUN.KeyCodeConstants.vbKeyScrollLock, 0, KEYEVENTF_KEYUP, 0)
		End If
	End Sub

	' Read the state of NumLock.
	
	Public Function GetNumLock() As Boolean
		' get current state of all 256 virtual keys
		Dim keystat(255) As Byte
		GetKeyboardState(keystat(0))
		' for toggle keys, bit 0 reflects the current state
		Return (keystat(VBRUN.KeyCodeConstants.vbKeyNumlock) And 1)
	End Function

	' Modify the state of NumLock.
	
	Public Sub SetNumLock(ByVal newState As Boolean)
		' if the current state must be changed
		If CBool(GetKeyState(VBRUN.KeyCodeConstants.vbKeyNumlock)) <> newState Then 
			' programmatically press and release the NumLock key
			keybd_event(VBRUN.KeyCodeConstants.vbKeyNumlock, 0, 0, 0)
			keybd_event(VBRUN.KeyCodeConstants.vbKeyNumlock, 0, KEYEVENTF_KEYUP, 0)
		End If
	End Sub

	' Read the state of Insert Key.
	
	Public Function GetInsertKey() As Boolean
		' get current state of all 256 virtual keys
		Dim keystat(255) As Byte
		GetKeyboardState(keystat(0))
		' for toggle keys, bit 0 reflects the current state
		Return (keystat(VBRUN.KeyCodeConstants.vbKeyInsert) And 1)
	End Function

	' Modify the state of Insert key.
	
	Public Sub SetInsertKey(ByVal newValue As Boolean)
		' get current state of all 256 virtual keys
		Dim keystat(255) As Byte
		GetKeyboardState(keystat(0))
		' modify bit 0 of the relevant item, and store back
		keystat(VBRUN.KeyCodeConstants.vbKeyInsert) = (keystat(VBRUN.KeyCodeConstants.vbKeyInsert) And &HFE) Or (newValue And 1)
		SetKeyboardState(keystat(0))
	End Sub

End Module
