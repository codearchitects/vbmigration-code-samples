' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module TextBoxAPI

	'---------------------------------------------------
	' Reusable routines for TextBox controls.
	'---------------------------------------------------

	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As RECT) As Integer
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Private Declare Function SendMessageByVal Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	'UPGRADENOTE: scope changed to private, to avoid clashes with similar declarations in other modules
	Friend Structure RECT
	
		Public Left As Integer
		Public Top As Integer
		Public Right As Integer
		Public Bottom As Integer
	End Structure

	Private Const EM_CANUNDO As Short = &HC6S
	Private Const EM_UNDO As Short = &HC7S
	' UPGRADE_INFO (#0511): The 'EM_EMPTYUNDOBUFFER' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const EM_EMPTYUNDOBUFFER As Short = &HCDS
	Private Const EM_GETLINECOUNT As Short = &HBAS
	Private Const EM_GETFIRSTVISIBLELINE As Short = &HCES
	Private Const EM_LINEFROMCHAR As Short = &HC9S
	Private Const EM_LINEINDEX As Short = &HBBS
	Private Const EM_LINELENGTH As Short = &HC1S
	Private Const EM_FMTLINES As Short = &HC8S
	Private Const EM_GETLINE As Short = &HC4S
	Private Const EM_GETRECT As Short = &HB2S
	Private Const EM_SCROLL As Short = &HB5S
	Private Const EM_SCROLLCARET As Short = &HB7S
	Private Const EM_SETRECT As Short = &HB3S
	Private Const EM_SETTABSTOPS As Short = &HCBS
	Private Const EM_LINESCROLL As Short = &HB6S
	
	'-------------------------------------------
	' Undo operations
	'-------------------------------------------
	
	' Return True if the most recent edit operation can be undone.
	Public Function CanUndo(ByVal tb As VB6TextBox) As Boolean
		Return SendMessageByVal(tb.hWnd, EM_CANUNDO, 0, 0)
	End Function

	' Undo the most recent edit operation.
	Public Sub Undo(ByVal tb As VB6TextBox)
		SendMessageByVal(tb.hWnd, EM_UNDO, 0, 0)
	End Sub

	' Empty the undo buffer.
	Public Sub EmptyUndoBuffer(ByVal tb As VB6TextBox)
		SendMessageByVal(tb.hWnd, EM_EMPTYUNDOBUFFER, 0, 0)
	End Sub

	'-------------------------------------------
	' Multi-line controls
	'-------------------------------------------
	
	' Return the number of lines in the control.
	
	Public Function GetLineCount(ByVal tb As VB6TextBox) As Integer
		Return SendMessageByVal(tb.hWnd, EM_GETLINECOUNT, 0, 0)
	End Function

	' Return the index of the first visible line
	' (0 for the first text line in the control).
	' When applied to a single-line control, return the
	' index of the first visible character
	' (0 for the first character in the control).
	
	Public Function GetFirstVisibleLine(ByVal tb As VB6TextBox) As Integer
		Return SendMessageByVal(tb.hWnd, EM_GETFIRSTVISIBLELINE, 0, 0)
	End Function

	' Return the number of the line that contains the specified character.
	' Both line and character numbers are zero-based.
	
	Public Function LineFromChar(ByVal tb As VB6TextBox, ByVal charIndex As Integer) As Integer
		Return SendMessageByVal(tb.hWnd, EM_LINEFROMCHAR, charIndex, 0)
	End Function

	' Return the character offset of the first character of a line.
	
	Public Function LineIndex(ByVal tb As VB6TextBox, ByVal lineNum As Integer) As Integer
		Return SendMessageByVal(tb.hWnd, EM_LINEINDEX, lineNum, 0)
	End Function

	' Return the length of the specified line.
	
	Public Function LineLength(ByVal tb As VB6TextBox, ByVal lineNum As Integer) As Integer
		Dim charOffset As Integer = SendMessageByVal(tb.hWnd, EM_LINEINDEX, lineNum, 0)
		' Retrieve the character offset of the first character of the line.
		' Now it is possible to retrieve the length of the line.
		Return SendMessageByVal(tb.hWnd, EM_LINELENGTH, charOffset, 0)
	End Function

	' Return the specified line.
	
	Public Function GetLine(ByVal tb As VB6TextBox, ByVal lineNum As Integer) As String
		Dim charOffset As Integer
		Dim lineLen As Integer
		' Retrieve the character offset of the first character of the line.
		charOffset = SendMessageByVal(tb.hWnd, EM_LINEINDEX, lineNum, 0)
		' Now it is possible to retrieve the length of the line.
		lineLen = SendMessageByVal(tb.hWnd, EM_LINELENGTH, charOffset, 0)
		' Extract the line text.
		Return Mid(tb.Text, charOffset + 1, lineLen)
	End Function

	' Get the line/column coordinates of a given character (both are zero-based).
	' If charIndex is negative, it returns the coordinates of the caret
	
	Public Sub GetLineColumn(ByVal tb As VB6TextBox, ByVal charIndex As Integer, ByRef line As Integer, ByRef column As Integer)
		If charIndex < 0 Then  charIndex = tb.SelStart
		' Get the line number.
		line = SendMessageByVal(tb.hWnd, EM_LINEFROMCHAR, charIndex, 0)
		' Get the column number by subtracting the line's start
		' index from the caret position
		column = tb.SelStart - SendMessageByVal(tb.hWnd, EM_LINEINDEX, line, 0)
	End Sub

	' Return an array with all the lines in the control.
	' If the second optional argument is True, the trailing CR-LF is preserved.
	
	Public Function GetAllLines(ByVal tb As VB6TextBox, Optional ByVal KeepHardLineBreaks As Boolean = False) As String()
		Dim result() As String
		Dim i As Integer
		' Activate soft line breaks. A soft line break is marked by the
		' CR-Cr-LF sequence.
		SendMessageByVal(tb.hWnd, EM_FMTLINES, CShort(True), 0)
		' Retrieve all the lines in one operation. This operation will leave
		' a trailing CR character for soft line breaks.
		result = Split(tb.Text, ControlChars.CrLf)
		' We need a loop to trim the trailing CR character. If the second
		' argument is true, we need to manually add a CR-LF pair to all
		' the lines that don't contain such trailing CR char.
		For i = 0 To UBound6(result)
			If VB.Right(result(i), 1) = ControlChars.Cr Then 
				result(i) = VB.Left(result(i), Len6(result(i)) - 1)
			ElseIf KeepHardLineBreaks Then 
				result(i) &= ControlChars.CrLf
			End If
		Next
		' Deactivate soft line breaks.
		SendMessageByVal(tb.hWnd, EM_FMTLINES, CShort(False), 0)
		Return result
	End Function

	' Get the formatting rectangle.
	
	Public Sub GetRect(ByVal tb As VB6TextBox, ByRef Left As Integer, ByRef Top As Integer, ByRef Right As Integer, ByRef Bottom As Integer)
		Dim lpRect As RECT
		SendMessage(tb.hWnd, EM_GETRECT, 0, lpRect)
		Left = lpRect.Left
		Top = lpRect.Top
		Right = lpRect.Right
		Bottom = lpRect.Bottom
	End Sub

	' Set the formatting rectangle and refresh the control.
	
	Public Sub SetRect(ByVal tb As VB6TextBox, ByVal Left As Integer, ByVal Top As Integer, ByVal Right As Integer, ByVal Bottom As Integer)
		Dim lpRect As RECT
		lpRect.Left = Left
		lpRect.Top = Top
		lpRect.Right = Right
		lpRect.Bottom = Bottom
		SendMessage(tb.hWnd, EM_SETRECT, 0, lpRect)
	End Sub

	' Scroll the contents of the control.
	' Positive values scroll left and up, negative values
	' scroll right and down.
	
	Public Sub LineScroll(ByVal tb As VB6TextBox, ByVal HorizScroll As Integer, ByVal VertScroll As Integer)
		SendMessageByVal(tb.hWnd, EM_LINESCROLL, HorizScroll, VertScroll)
	End Sub

	' Ensures that the caret is visible.
	
	Public Sub ScrollCaret(ByVal tb As VB6TextBox)
		SendMessageByVal(tb.hWnd, EM_SCROLLCARET, 0, 0)
	End Sub

	' Set tab stops. Each element of the array is expressed in dialog units,
	' where each dialog unit is 1/4 of the average character width.
	
	Public Sub SetTabStops(ByVal tb As VB6TextBox, ByVal tabStops() As Integer)
		Dim numEls As Integer = UBound6(tabStops) - LBound6(tabStops) + 1
		SendMessage(tb.hWnd, EM_SETTABSTOPS, numEls, tabStops(LBound6(tabStops)))
	End Sub

	' Set the tab stop distance, expressed in dialog units.
	
	Public Sub SetTabStopDistance(ByVal tb As VB6TextBox, ByVal distance As Integer)
		SendMessage(tb.hWnd, EM_SETTABSTOPS, 1, distance)
	End Sub

End Module
