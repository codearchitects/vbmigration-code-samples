' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form11

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub Command1_Click() Handles Command1.Click
		Form12.add_state = True
		Form12.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command10_Click() Handles Command10.Click
		If rs_sy.RecordCount < 1 Then  MsgBox6("No school year in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Dim rep As Short
		Dim pos As Integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sy.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
		If rs_sy.Fields(1).Value = "Open" Then 
			MsgBox6("The school year is not closed.Please select a closed school year to re-open.", MsgBoxStyle.Exclamation, "CSRS version 1")
		Else
			rep = MsgBox6("Are you sure you want to re-open the selected school year?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.No Then  Exit Sub
			rep = 0
			With rs_sy
				pos = .AbsolutePosition
				.Fields(1).Value = "Open"
				.Update()
				
				.Requery()
				Call load_rec()
				.AbsolutePosition = pos
				
				ListView1.ListItems(Val(.AbsolutePosition)).EnsureVisible()
				ListView1.ListItems(Val(.AbsolutePosition)).Selected = True

				MsgBox6("The school year was sucessfully re-opened.", MsgBoxStyle.Information, "CSRS version 1")
				pos = 0
			End With
		End If
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If rs_sy.RecordCount < 1 Then  MsgBox6("No school year in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If Not ListView1.SelectedItem.Text = "" And Not rs_sy.RecordCount < 1 Then  rs_sy.AbsolutePosition = ListView1.SelectedItem.Text
		Form12.add_state = False
		Form12.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		On Error GoTo Err 
		With rs_sy
			'---------------------------------
			'Check if there is no record
			'---------------------------------
			If .RecordCount < 1 Then  MsgBox6("No school year in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
			'---------------------------------
			'Confirm deletion of record
			'---------------------------------
			Dim ans As Short
			Dim pos As Short
			ans = MsgBox6("Are you sure you want to delete the selected record?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Record Delete")
			Me.MousePointer = VBRUN.MousePointerConstants.vbHourglass
			If ans = MsgBoxResult.Yes Then 
				'-----------------------------
				'Delete the record
				'-----------------------------
				pos = Val(ListView1.SelectedItem.Text)
				Call delete_rec(cn, "tblSchoolYear", "SchoolYear", ListView1.SelectedItem.ListSubItems(1).Text, False, 0)
				.Requery()
				If .RecordCount > 0 Then 
					.AbsolutePosition = pos
					If .EOF Then  .MoveFirst()
					'---------------------------------
					'Fill listview
					'---------------------------------
					pos = .AbsolutePosition
					load_rec()
					ListView1.ListItems(pos).EnsureVisible()
					ListView1.ListItems(pos).Selected = True
					.AbsolutePosition = ListView1.SelectedItem.Text
					'---------------------------------
					'End-fill listview
					'---------------------------------
				Else
					ListView1.ListItems.Clear()
				End If
				MsgBox6("Record has been successfully deleted.", MsgBoxStyle.Information, "Confirm")
			End If
			ans = 0
			pos = 0
			Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		End With
		Exit Sub
Err:
		prompt_err((Err.Description & ControlChars.CrLf & ControlChars.CrLf & "Error Number: " & Err.Number)): Me.MousePointer = VBRUN.MousePointerConstants.vbDefault: Exit Sub
	End Sub

	Private Sub Command5_Click() Handles Command5.Click
		rs_sy.Requery()
		load_rec()
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		Unload6(Me)
	End Sub

	Private Sub Command9_Click() Handles Command9.Click
		If rs_sy.RecordCount < 1 Then  MsgBox6("No school year in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Dim rep As Short
		Dim pos As Integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sy.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
		If rs_sy.Fields(1).Value = "Close" Then 
			MsgBox6("The school year was already closed.", MsgBoxStyle.Exclamation, "CSRS version 1")
		Else
			rep = MsgBox6("Are you sure you want to close the selected school year?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.No Then  Exit Sub
			rep = 0
			With rs_sy
				pos = .AbsolutePosition
				.Fields(1).Value = "Close"
				.Update()
				
				.Requery()
				Call load_rec()
				.AbsolutePosition = pos
				
				ListView1.ListItems(Val(.AbsolutePosition)).EnsureVisible()
				ListView1.ListItems(Val(.AbsolutePosition)).Selected = True

				MsgBox6("The school year was sucessfully closed.", MsgBoxStyle.Information, "CSRS version 1")
				pos = 0
			End With
		End If
		
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		
		If Not rs_sy.RecordCount < 1 Then  rs_sy.AbsolutePosition = ListView1.SelectedItem.Text
		Command1.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_sy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")
		load_rec()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_sy = Nothing
		
		Call save_pos(Me)
	End Sub
	
	Public Sub load_rec()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		Call FillListView(ListView1, rs_sy, 3, 1, True, True)
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub
	
	Private Sub ListView1_Click() Handles ListView1.Click
		
		If Not rs_sy.RecordCount < 1 Then  rs_sy.AbsolutePosition = ListView1.SelectedItem.Text
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		Call search_in_listview(ListView1, Text1.Text)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

End Class
