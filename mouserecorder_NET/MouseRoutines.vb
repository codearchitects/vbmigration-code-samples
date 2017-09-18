' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure POINTAPI

	Public x As Integer
	Public y As Integer
End Structure

Friend Module MouseRoutines

	' UPGRADE_INFO (#0531): You can replace calls to the 'GetCursorPos' unamanged method with the following .NET member(s): System.Windows.Forms.Control.MousePosition, System.Windows.Forms.Cursor.Position
	Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetCursorPos' unamanged method with the following .NET member(s): System.Windows.Forms.Cursor.Position
	Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'mouse_event' unamanged method with the following .NET member(s): System.Windows.Forms.MouseEventArgs
	Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
	
	' Get Cursor coordinates (x,y)   '
	Public Function Mouse() As POINTAPI
		Dim result As Integer = GetCursorPos(Mouse)
	End Function

	Public Function MouseX() As Integer
		Return Mouse().x
	End Function

	Public Function MouseY() As Integer
		Return Mouse().y
	End Function

	'Linke Maustaste simulieren
	Public Sub MouseLeftClick()
		mouse_event(&H2, 0, 0, 0, 0)
		mouse_event(&H4, 0, 0, 0, 0)
	End Sub

	'Mittlerer Maustaste simulieren
	Public Sub MouseMiddleClick()
		mouse_event(&H20, 0, 0, 0, 0)
		mouse_event(&H40, 0, 0, 0, 0)
	End Sub

	'Rechte Maustaste simulieren
	Public Sub MouseRightClick()
		mouse_event(&H8, 0, 0, 0, 0)
		mouse_event(&H10, 0, 0, 0, 0)
	End Sub

	'Maus nach x,y bewegen
	Public Sub MouseMove(ByRef x As Integer, ByRef y As Integer)
		SetCursorPos(x, y)
	End Sub

End Module
