' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmListBox

	' This variable keeps track of which control is
	' the last one to be selected.
	Private ActControl As Object
	
	' These are used to remember mouse coordinates
	' when the mouse hovers on the List1 control
	Private mouseButton As Short
	Private mouseX As Integer
	Private mouseY As Integer
	
	Public Sub Form_Load() Handles MyBase.Load
		' Fill the listbox and combobox with the month names.
		Dim i As Short
		For i = 1 To 12
			List1.AddItem(MonthName(i) & ControlChars.Tab & "1999")
			Combo1.AddItem(MonthName(i))
		Next
		' Add a very long element
		List1.AddItem("A element that is longer than the current width")
		Combo1.AddItem("A element that is longer than the current width")
		
		' set initial tab stop distance.
		' UPGRADENOTE: this array had LBound=1, all subsequent references has been fixed
		Dim tabs(1) As Integer
		tabs(0) = 40: tabs(1) = 55
		ListBoxAPI.SetTabStops(List1, tabs)
		
		List1.ListIndex = 0
		Combo1.ListIndex = 0
	End Sub

	Public Sub SetButtonState()
		' Remember the active control.
		ActControl = ActiveControl
		' Show a yellow background for the active control
		List1.BackColor = SystemColors.Window 
		Combo1.BackColor = SystemColors.Window 
		ActControl.BackColor = Color.Yellow 
		
		' Enable/disable buttons that apply only to one control.
		cmdGetHorizExt.Enabled = (ActControl Is List1)
		cmdSetHorizExt.Enabled = (ActControl Is List1)
		cmdSelectAll(0).Enabled = (ActControl Is List1)
		cmdSelectAll(1).Enabled = (ActControl Is List1)
		cmdSetTabStops.Enabled = (ActControl Is List1)
		cmdGetSelItems.Enabled = (ActControl Is List1)
		cmdVisibleItems.Enabled = (ActControl Is List1)
		
		cmdShowList.Enabled = (ActControl Is Combo1)
		cmdGetDropWidth.Enabled = (ActControl Is Combo1)
		cmdSetDropWidth.Enabled = (ActControl Is Combo1)
	End Sub

	Private Sub List1_GotFocus() Handles List1.GotFocus
		SetButtonState()
	End Sub

	Private Sub Combo1_GotFocus() Handles Combo1.GotFocus
		SetButtonState()
	End Sub

	Private Sub List1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles List1.MouseDown
		List1_MouseMove(Button, Shift, X, Y)
	End Sub

	Private Sub List1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles List1.MouseMove
		' Remember mouse button state and coordinates.
		mouseButton = Button
		mouseX = ScaleX(X, VBRUN.ScaleModeConstants.vbTwips, VBRUN.ScaleModeConstants.vbPixels)
		mouseY = ScaleY(Y, VBRUN.ScaleModeConstants.vbTwips, VBRUN.ScaleModeConstants.vbPixels)
	End Sub

	Private Sub cmdFind_Click() Handles cmdFind.Click
		Dim search As String = ""
		Dim startIndex As Integer
		Dim found As Integer
		search = InputBox6("Enter the string to search")
		If search = "" Then  Exit Sub
		
		CObj(ActControl).SetFocus
		startIndex = CObj(ActControl).ListIndex
		found = FindString(ActControl, search, startIndex)
		If found = -1 Then 
			MsgBox6("Element not found", MsgBoxStyle.Information)
		Else
			CObj(ActControl).ListIndex = found
			MsgBox6("Element found at position " & found, MsgBoxStyle.Information)
		End If
	End Sub

	Private Sub cmdFindExact_Click() Handles cmdFindExact.Click
		Dim search As String = ""
		Dim startIndex As Integer
		Dim found As Integer
		search = InputBox6("Enter the string to search" & ControlChars.CrLf & "(it's preferable that you use this routine with the ComboBox control)")
		If search = "" Then  Exit Sub
		
		CObj(ActControl).SetFocus
		startIndex = CObj(ActControl).ListIndex
		found = FindString(ActControl, search, startIndex, True)
		If found = -1 Then 
			MsgBox6("Element not found", MsgBoxStyle.Information)
		Else
			CObj(ActControl).ListIndex = found
			MsgBox6("Element found at position " & found, MsgBoxStyle.Information)
		End If
	End Sub

	Private Sub cmdGetHorizExt_Click() Handles cmdGetHorizExt.Click
		MsgBox6("Horizontal Extent = " & GetHorizontalExtent(ActControl) & " pixels.", MsgBoxStyle.Information)
	End Sub

	Private Sub cmdSetHorizExt_Click() Handles cmdSetHorizExt.Click
		Dim newWidth As String = InputBox6("Enter the new horizontal extent value (in pixels)")
		If newWidth = "" Then  Exit Sub
		SetHorizontalExtent(ActControl, CInt(newWidth))
	End Sub

	Private Sub cmdGetItemHeight_Click() Handles cmdGetItemHeight.Click
		MsgBox6("Item Height = " & GetItemHeight(ActControl) & " pixels.", MsgBoxStyle.Information)
	End Sub

	Private Sub cmdSetItemHeight_Click() Handles cmdSetItemHeight.Click
		Dim newHeight As String = InputBox6("Enter new item height in pixels (current height is " & GetItemHeight(ActControl) & ")")
		If newHeight = "" Then  Exit Sub
		SetItemHeight(ActControl, newHeight)
	End Sub

	Private Sub cmdSelectAll_Click(ByRef Index As Short)
		SelItemRange(ActControl, (Index = 0))
	End Sub

	Private Sub cmdSetTabStops_Click() Handles cmdSetTabStops.Click
		' UPGRADENOTE: this array had LBound=1, all subsequent references has been fixed
		Dim tabs(1) As Integer
		tabs(0) = 60: tabs(1) = 100
		ListBoxAPI.SetTabStops(ActControl, tabs)
		CObj(ActControl).SetFocus
	End Sub

	Private Sub cmdGetSelItems_Click() Handles cmdGetSelItems.Click
		Dim result() As Integer
		Dim msg As String = ""
		Dim i As Integer
		
		If CObj(ActControl).selCount = 0 Then 
			MsgBox6("No selected items", MsgBoxStyle.Exclamation)
		Else
			result = GetSelItems(ActControl)
			For i = LBound6(result) To UBound6(result)
				msg = msg & CObj(ActControl).List(result(i)) & ControlChars.CrLf
			Next
			MsgBox6(msg, MsgBoxStyle.Information)
		End If
		
	End Sub

	Private Sub cmdVisibleItems_Click() Handles cmdVisibleItems.Click
		MsgBox6("Visible Items = " & VisibleItems(ActControl))
	End Sub

	Private Sub cmdShowList_Click() Handles cmdShowList.Click
		ShowDropDown(ActControl)
	End Sub

	Private Sub cmdGetDropWidth_Click() Handles cmdGetDropWidth.Click
		MsgBox6("GetDroppedWidth = " & GetDroppedWidth(ActControl) & " pixels", MsgBoxStyle.Information)
	End Sub

	Private Sub cmdSetDropWidth_Click() Handles cmdSetDropWidth.Click
		Dim newWidth As String = InputBox6("Type the minimum width for the drop-down list")
		If newWidth = "" Then  Exit Sub
		SetDroppedWidth(ActControl, newWidth)
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		Dim itemIndex As Integer
		If ActControl Is List1 Then 
			If (mouseButton And 2) = 0 Then 
				lblStatus.Caption = "Right-click a ListBox item"
			Else
				itemIndex = ItemFromPoint(ActControl, mouseX, mouseY)
				If itemIndex >= 0 Then 
					lblStatus.Caption = "ListBox item under mouse cursor = " & itemIndex
				Else
					lblStatus.Caption = "No ListBox item under mouse cursor"
				End If
			End If
		Else
			' display the drop-down state of the combobox.
			lblStatus.Caption = "The drop-down area is " & IIf(GetDroppedState(ActControl), "visible", "invisible")
		End If
	End Sub

End Class
