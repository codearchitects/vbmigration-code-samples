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

Friend Module APIDeclares

	Friend Structure MINMAXINFO
	
		Public ptReserved As POINTAPI
		Public ptMaxSize As POINTAPI
		Public ptMaxPosition As POINTAPI
		Public ptMinTrackSize As POINTAPI
		Public ptMaxTrackSize As POINTAPI
	End Structure

	Public Const WM_MOVE As Short = &H3S
	Public Const WM_ACTIVATEAPP As Short = &H1CS
	Public Const WM_DISPLAYCHANGE As Short = &H7ES
	Public Const WM_TIMECHANGE As Short = &H1ES
	Public Const WM_GETMINMAXINFO As Short = &H24S
	Public Const WM_COMPACTING As Short = &H41S
	Public Const WM_QUERYOPEN As Short = &H13S
	Public Const WM_CONTEXTMENU As Short = &H7BS
	Public Const WM_PAINT As Short = &HFS
	Public Const WM_COMMAND As Short = &H111S
	Public Const WM_MENUSELECT As Short = &H11FS
	
	Public Const EN_VSCROLL As Short = &H602S
	Public Const EN_HSCROLL As Short = &H601S
	
	' IGNORED: Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (dest As Any, source As Any, ByVal numBytes As Long)
	Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef dest As APIDeclares.MINMAXINFO, ByVal source As Integer, ByVal numBytes As Integer)
	Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal dest As Integer, ByRef source As APIDeclares.MINMAXINFO, ByVal numBytes As Integer)
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetUpdateRect' unamanged method with the following .NET member(s): System.Windows.Forms.PaintEventArgs.ClipRectangle
	Declare Function GetUpdateRect Lib "user32" (ByVal hWnd As Integer, ByRef lpRect As RECT, ByVal bErase As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'GetMenuString' unamanged method with the following .NET member(s): System.Windows.Forms.MenuItem.Text
	Declare Function GetMenuString Lib "user32" Alias "GetMenuStringA" (ByVal hMenu As Integer, ByVal wIDItem As Integer, ByVal lpString As String, ByVal nMaxCount As Integer, ByVal wFlag As Integer) As Integer

End Module
