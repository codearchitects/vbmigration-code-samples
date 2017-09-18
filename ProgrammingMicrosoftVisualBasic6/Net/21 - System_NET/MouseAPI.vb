' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure POINTAPI

	Public X As Integer
	Public Y As Integer
End Structure

Friend Structure RECT

	Public Left As Integer
	Public Top As Integer
	Public Right As Integer
	Public Bottom As Integer
End Structure

Friend Module MouseAPI

	Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	Private Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Integer) As Integer
	Private Declare Function ShowCursor Lib "user32" (ByVal bShow As Integer) As Integer
	Private Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer
	Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	Private Declare Function ScreenToClient Lib "user32" (ByVal hWnd As Integer, ByRef lpPoint As POINTAPI) As Integer
	Private Declare Function ClientToScreen Lib "user32" (ByVal hWnd As Integer, ByRef lpPoint As POINTAPI) As Integer
	' IGNORED: Private Declare Function ClipCursor Lib "user32" (lpRect As Any) As Long
	Private Declare Function ClipCursor Lib "user32" (ByRef lpRect As RECT) As Integer
	Private Declare Function ClipCursor Lib "user32" (ByVal lpRect As Integer) As Integer
	Private Declare Function GetClientRect Lib "user32" (ByVal hWnd As Integer, ByRef lpRect As RECT) As Integer
	Private Declare Function SetCapture Lib "user32" (ByVal hWnd As Integer) As Integer
	Private Declare Function ReleaseCapture Lib "user32" () As Integer
	Private Declare Function GetCapture Lib "user32" () As Integer
	Private Declare Function WindowFromPoint Lib "user32" (ByVal xPoint As Integer, ByVal yPoint As Integer) As Integer
	
	' Return the state of the Left button.
	
	Public Function LeftButton() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyLButton) And &H8000)
	End Function

	' Return the state of the Right button.
	
	Public Function RightButton() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyRButton) And &H8000)
	End Function

	' Return the state of the Middle button.
	
	Public Function MiddleButton() As Boolean
		Return (GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyMButton) And &H8000)
	End Function

	' Return the state of the mouse buttons as a bit-coded value.
	' (same format as the Button argument of a Mousexxxx event procedure.)
	
	Public Function MouseButton() As Short
		If GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyLButton) < 0 Then 
			MouseButton = 1
		End If
		If GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyRButton) < 0 Then 
			MouseButton = MouseButton Or 2
		End If
		If GetAsyncKeyState(VBRUN.KeyCodeConstants.vbKeyMButton) < 0 Then 
			Return MouseButton Or 4
		End If
	End Function

	' Return the number of mouse buttons.
	
	Public Function MouseButtonsNumber() As Short
		Const SM_CMOUSEBUTTONS As Short = 43
		Return GetSystemMetrics(SM_CMOUSEBUTTONS)
	End Function

	' Show and Hide the mouse cursor.
	' (These calls must be balanced.)
	
	Public Sub MouseHide()
		ShowCursor(CShort(False))
	End Sub

	Public Sub MouseShow()
		ShowCursor(CShort(True))
	End Sub

	' Get mouse X coordinates (screen coordinates).
	' If a window handle is passed, the result are client area coordinates
	' relative to that window.
	
	Public Function MouseX(Optional ByVal hWnd As Integer = 0) As Integer
		Dim lpPoint As POINTAPI
		GetCursorPos(lpPoint)
		If hWnd Then  ScreenToClient(hWnd, lpPoint)
		Return lpPoint.X
	End Function

	Public Function MouseY(Optional ByVal hWnd As Integer = 0) As Integer
		Dim lpPoint As POINTAPI
		GetCursorPos(lpPoint)
		If hWnd Then  ScreenToClient(hWnd, lpPoint)
		Return lpPoint.Y
	End Function

	' Mouse mouse cursor. If a window handle is passed, the coordinates
	' are taken as relative to that window's client area.
	
	Public Sub MoveMouseCursor(ByVal X As Integer, ByVal Y As Integer, Optional ByVal hWnd As Integer = 0)
		Dim lpPoint As POINTAPI
		If hWnd = 0 Then 
			SetCursorPos(X, Y)
		Else
			lpPoint.X = X
			lpPoint.Y = Y
			ClientToScreen(hWnd, lpPoint)
			SetCursorPos(lpPoint.X, lpPoint.Y)
		End If
	End Sub

	' Clip the mouse cursor to a given rectangle.
	
	Public Sub ClipMouse(ByVal Left As Integer, ByVal Top As Integer, ByVal Right As Integer, ByVal Bottom As Integer)
		Dim lpRect As RECT
		lpRect.Left = Left
		lpRect.Top = Top
		lpRect.Right = Right
		lpRect.Bottom = Bottom
		ClipCursor(lpRect)
	End Sub

	' Clip mouse to a given window.
	
	Public Sub ClipMouseToWindow(ByVal hWnd As Integer)
		Dim lpPoint As POINTAPI
		Dim lpRect As RECT
		' Retrieve the coordinates of the upper-left corner of the window.
		ClientToScreen(hWnd, lpPoint)
		' Get the client screen rectangle.
		GetClientRect(hWnd, lpRect)
		' Manually convert the rectangle's elements to screen coordinates.
		lpRect.Left += lpPoint.X
		lpRect.Top += lpPoint.Y
		lpRect.Right += lpPoint.X
		lpRect.Bottom += lpPoint.Y
		' Enforce the clipping.
		ClipCursor(lpRect)
	End Sub

	' Clear the mouse clip area.
	
	Public Sub ClearClipMouse()
		' UPGRADE_ISSUE (#0218): The ByVal keyword was used to pass the '0%' argument. Consider creating an overload of the Declare statement.
		ClipCursor(0%)
	End Sub

	' Set mouse capture.
	
	Public Sub SetMouseCapture(ByVal hWnd As Integer)
		If hWnd Then 
			SetCapture(hWnd)
		Else
			ReleaseCapture()
		End If
	End Sub

	' Get the handle of the window that has the mouse capture.
	
	Public Function GetMouseCapture() As Integer
		Return GetCapture()
	End Function

	' Return the handle of the window under the mouse cursor.
	
	Public Function WindowFromMouse() As Integer
		Dim lpPoint As POINTAPI
		GetCursorPos(lpPoint)
		Return WindowFromPoint(lpPoint.X, lpPoint.Y)
	End Function

End Module
