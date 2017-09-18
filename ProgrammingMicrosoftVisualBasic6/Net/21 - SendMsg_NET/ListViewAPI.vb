' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module ListViewAPI

	'---------------------------------------------------
	' Reusable routines for ListView controls
	'---------------------------------------------------
	
	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessageByVal Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	Private Declare Function SendMessageString Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
	' IGNORED: Private Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, dest As Any, ByVal numBytes As Long)
	Private Declare Function GetClientRect Lib "user32" (ByVal hwnd As Integer, ByRef lpRect As RECT) As Integer
	
	'UPGRADENOTE: scope changed to private, to avoid clashes with similar declarations in other modules
	Friend Structure RECT
	
		Public Left As Integer
		Public Top As Integer
		Public Right As Integer
		Public Bottom As Integer
	End Structure

	Private Const LVM_FIRST As Short = &H1000S
	Private Const LVM_GETCOUNTPERPAGE As Short = (LVM_FIRST + 40)
	Private Const LVM_SCROLL As Short = (LVM_FIRST + 20)
	
	' Return the number of items that can fit vertically
	' when in List or Report mode (only fully visible items are counted)
	
	Public Function VisibleLines(ByVal lvw As VB6ListView) As Integer
		Return SendMessageByVal(lvw.hWnd, LVM_GETCOUNTPERPAGE, 0, 0)
	End Function

	' Scroll the contents horizontally and vertically.
	' If the ListView control is in List mode, DX is the number of
	' columns to scroll. If it is in Report mode, DY is rounded to the
	' nearest number of pixels that represent a whole line.
	
	' UPGRADENOTE: in the original VB6 code this method is called Scroll, but this method clashes with Scroll event
	Public Function ScrollListView(ByVal lvw As VB6ListView, ByVal dx As Integer, ByVal dy As Integer) As Object
	' UPGRADE_INFO (#0561): The 'ScrollListView' symbol was defined without an explicit "As" clause.
		SendMessageByVal(lvw.hWnd, LVM_SCROLL, dx, dy)
	End Function

End Module
