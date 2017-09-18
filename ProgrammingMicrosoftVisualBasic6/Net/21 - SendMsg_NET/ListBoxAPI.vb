' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module ListBoxAPI

	'---------------------------------------------------
	' Reusable routines for ListBox and ComboBox controls.
	'---------------------------------------------------

	' IGNORED: Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As RECT) As Integer
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

	Private Const LB_FINDSTRING As Short = &H18FS
	Private Const LB_FINDSTRINGEXACT As Short = &H1A2S
	Private Const LB_GETHORIZONTALEXTENT As Short = &H193S
	Private Const LB_GETITEMHEIGHT As Short = &H1A1S
	Private Const LB_GETITEMRECT As Short = &H198S
	Private Const LB_GETSELCOUNT As Short = &H190S
	Private Const LB_GETSELITEMS As Short = &H191S
	Private Const LB_SELITEMRANGE As Short = &H19BS
	Private Const LB_SETHORIZONTALEXTENT As Short = &H194S
	Private Const LB_SETITEMHEIGHT As Short = &H1A0S
	Private Const LB_SETTABSTOPS As Short = &H192S
	Private Const LB_ITEMFROMPOINT As Short = &H1A9S
	
	Private Const CB_FINDSTRING As Short = &H14CS
	Private Const CB_FINDSTRINGEXACT As Short = &H158S
	' UPGRADE_INFO (#0511): The 'CB_GETDROPPEDCONTROLRECT' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const CB_GETDROPPEDCONTROLRECT As Short = &H152S
	Private Const CB_GETDROPPEDSTATE As Short = &H157S
	Private Const CB_GETITEMHEIGHT As Short = &H154S
	Private Const CB_SETITEMHEIGHT As Short = &H153S
	Private Const CB_SHOWDROPDOWN As Short = &H14FS
	Private Const CB_GETHORIZONTALEXTENT As Short = &H15DS
	Private Const CB_SETHORIZONTALEXTENT As Short = &H15ES
	Private Const CB_GETDROPPEDWIDTH As Short = &H15FS
	Private Const CB_SETDROPPEDWIDTH As Short = &H160S
	' UPGRADE_INFO (#0511): The 'CB_LIMITTEXT' member is referenced only by members that haven't found to be used in the current project/solution.
	Private Const CB_LIMITTEXT As Short = &H141S
	
	' Find a string in the control.
	' The third argument is the index *after* which to start the search (first item if omitted).
	' If the fourth argument is True it searches for an exact match.
	' Returns the index of the match, or -1 if not found.
	
	Public Function FindString(ByVal ctrl As Object, ByVal search As String, Optional ByVal startIndex As Integer = -1, Optional ByVal ExactMatch As Boolean = False) As Integer
		Dim uMsg As Integer
		If TypeOf ctrl Is VB6ListBox Then 
			uMsg = IIf(ExactMatch, LB_FINDSTRINGEXACT, LB_FINDSTRING)
		ElseIf TypeOf ctrl Is VB6ComboBox Then 
			uMsg = IIf(ExactMatch, CB_FINDSTRINGEXACT, CB_FINDSTRING)
		Else
			Exit Function
		End If
		Return SendMessageString(CObj(ctrl).hwnd, uMsg, startIndex, search)
	End Function

	' Return the height of each entry in the control (in pixels).
	
	Public Function GetItemHeight(ByVal ctrl As Object) As Integer
		Dim uMsg As Integer
		If TypeOf ctrl Is VB6ListBox Then 
			uMsg = LB_GETITEMHEIGHT
		ElseIf TypeOf ctrl Is VB6ComboBox Then 
			uMsg = CB_GETITEMHEIGHT
		Else
			Exit Function
		End If
		Return SendMessageByVal(CObj(ctrl).hwnd, uMsg, 0, 0)
	End Function

	' Set the height in pixels of each entry in the control.
	
	Public Sub SetItemHeight(ByVal ctrl As Object, ByVal newHeight As Integer)
		Dim uMsg As Integer
		If TypeOf ctrl Is VB6ListBox Then 
			uMsg = LB_SETITEMHEIGHT
		ElseIf TypeOf ctrl Is VB6ComboBox Then 
			uMsg = CB_SETITEMHEIGHT
		Else
			Exit Sub
		End If
		' (only the low-order word of lParam can be used.)
		SendMessageByVal(CObj(ctrl).hwnd, uMsg, 0, (newHeight And &HFFFF%))
		' It is necessary to manually refresh the control.
		ctrl.Refresh
	End Sub

	'--------------------------------------------------
	' ListBox specific routines
	'--------------------------------------------------
	
	' Return the horizontal extent of the control (in pixel).
	
	Public Function GetHorizontalExtent(ByVal lb As VB6ListBox) As Integer
		Return SendMessageByVal(lb.hWnd, LB_GETHORIZONTALEXTENT, 0, 0)
	End Function

	' Set the horizontal extent of the control (in pixel).
	' If this value is greater than the current control's width
	' a horizontal scrollbar appears.
	
	Public Sub SetHorizontalExtent(ByVal lb As VB6ListBox, ByVal newWidth As Integer)
		SendMessageByVal(lb.hWnd, LB_SETHORIZONTALEXTENT, newWidth, 0)
	End Sub

	' Select or deselect all the items in a range.
	
	Public Sub SelItemRange(ByVal lb As VB6ListBox, ByVal newState As Boolean, Optional ByVal firstItem As Integer = 0, Optional ByRef lastItem As Integer = -1)
		Dim lParam As Integer
		' account for omitted lastItem argument.
		If lastItem < 0 Then  lastItem = lb.ListCount - 1
		' lParam must contain the first item's index in its low-order word
		' and the last item's index in its high-order word.
		' We need this method to avoid overflow.
		
		' IGNORED: CopyMemory lParam, firstItem, 2
		' IGNORED: CopyMemory ByVal VarPtr(lParam) + 2, lastItem, 2
		lParam = firstItem Or (lastItem << 16)
		SendMessageByVal(lb.hWnd, LB_SELITEMRANGE, CShort(newState), lParam)
	End Sub

	' Set tab stops. Each element of the array is expressed in dialog units,
	' where each dialog unit is 1/4 of the average character width.
	
	Public Sub SetTabStops(ByVal lb As VB6ListBox, ByVal tabStops() As Integer)
		Dim numEls As Integer = UBound6(tabStops) - LBound6(tabStops) + 1
		SendMessage(lb.hWnd, LB_SETTABSTOPS, numEls, tabStops(LBound6(tabStops)))
	End Sub

	' Return an array with the indexes of all the selected items.
	
	Public Function GetSelItems(ByVal lb As VB6ListBox) As Integer()
		Dim result() As Integer    ' Implicitly declared array
		Dim selCount As Integer = SendMessageByVal(lb.hWnd, LB_GETSELCOUNT, 0, 0)
		' Retrieve the number of selected items (same as SelCount property)
		' If no item is selected, return an unitialized array
		If selCount = 0 Then  Exit Function
		
		' UPGRADENOTE:  this array had LBound=0, further references were fixed
		ReDim result(selCount)
		SendMessage(lb.hWnd, LB_GETSELITEMS, selCount, result(0))
		Return result
	End Function

	' Return the index of the item at given coordinates.
	
	Public Function ItemFromPoint(ByVal lb As VB6ListBox, ByVal X As Integer, ByVal Y As Integer) As Integer
		Dim lParam As Integer
		' lParam must contain X in its low-order word
		' and Y in its high-order word.
		' We need this method to avoid overflow.
		' IGNORED: CopyMemory lParam, X, 2
		' IGNORED: CopyMemory ByVal VarPtr(lParam) + 2, Y, 2
		lParam = X Or (Y << 16)
		Return SendMessageByVal(lb.hWnd, LB_ITEMFROMPOINT, 0, lParam)
	End Function

	' Return the number of visible items.
	
	Public Function VisibleItems(ByVal lb As VB6ListBox) As Integer
		Dim lpRect As RECT
		Dim itemHeight As Integer
		' Get client rectangle area.
		GetClientRect(lb.hWnd, lpRect)
		' Get height of each item.
		itemHeight = SendMessageByVal(lb.hWnd, LB_GETITEMHEIGHT, 0, 0)
		' Do the division.
		Return (lpRect.Bottom - lpRect.Top) \ itemHeight
	End Function

	'--------------------------------------------------
	' ComboBox specific routines
	'--------------------------------------------------
	
	' Show or hide the drop-down list.
	
	Public Sub ShowDropDown(ByVal cb As VB6ComboBox, Optional ByVal showIt As Boolean = True)
		SendMessageByVal(cb.hWnd, CB_SHOWDROPDOWN, CShort(showIt), 0)
	End Sub

	' Return the dropped state.
	
	Public Function GetDroppedState(ByVal cb As VB6ComboBox) As Boolean
		Return SendMessageByVal(cb.hWnd, CB_GETDROPPEDSTATE, 0, 0)
	End Function

	' Return the dimension of the drop-down list rectangle.
	
	Public Sub GetDroppedControlRect(ByVal cb As VB6ComboBox, ByRef Left As Integer, ByRef Top As Integer, ByRef Right As Integer, ByRef Bottom As Integer)
		Dim lpRect As RECT
		SendMessage(cb.hWnd, CB_GETDROPPEDCONTROLRECT, 0, lpRect)
		Left = lpRect.Left
		Top = lpRect.Top
		Right = lpRect.Right
		Bottom = lpRect.Bottom
	End Sub

	' Return the minimum width of the drop-down list portion.
	
	Public Function GetDroppedWidth(ByVal cb As VB6ComboBox) As Integer
		Return SendMessageByVal(cb.hWnd, CB_GETDROPPEDWIDTH, 0, 0)
	End Function

	' Set the minimum width of the drop-down list portion.
	
	Public Sub SetDroppedWidth(ByVal cb As VB6ComboBox, ByVal newWidth As Integer)
		SendMessageByVal(cb.hWnd, CB_SETDROPPEDWIDTH, newWidth, 0)
	End Sub

	' Set the maximum number of characters in the control.
	' (similar to the MaxLength property)
	
	Public Sub SetMaxLength(ByVal cb As VB6ComboBox, ByVal MaxLength As Integer)
		SendMessageByVal(cb.hWnd, CB_LIMITTEXT, MaxLength, 0)
	End Sub

End Module
