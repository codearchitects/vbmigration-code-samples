' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form9

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub Command1_Click() Handles Command1.Click
		Form10.add_state = True
		Form10.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If rs_level.RecordCount < 1 Then  MsgBox6("No level in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If Not ListView1.SelectedItem.Text = "" And Not rs_level.RecordCount < 1 Then  rs_level.AbsolutePosition = ListView1.SelectedItem.Text
		Form10.add_state = False
		Form10.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		On Error GoTo Err 
		With rs_level
			'---------------------------------
			'Check if there is no record
			'---------------------------------
			If .RecordCount < 1 Then  MsgBox6("No level in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
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
				Call delete_rec(cn, "tblLevel", "LevelNo", "", True, Val(ListView1.SelectedItem.ListSubItems(1).Text))
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
		rs_level.Requery()
		load_rec()
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		
		If Not rs_level.RecordCount < 1 Then  rs_level.AbsolutePosition = ListView1.SelectedItem.Text
		Command1.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_level, cn, "Select tblLevel.* From tblLevel Order by LevelNo Asc")
		load_rec()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_level = Nothing
		
		Call save_pos(Me)
	End Sub
	
	Public Sub load_rec()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		Call FillListView(ListView1, rs_level, 3, 1, True, True)
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub
	
	Private Sub ListView1_Click() Handles ListView1.Click
		
		If Not rs_level.RecordCount < 1 Then  rs_level.AbsolutePosition = ListView1.SelectedItem.Text
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		Call search_in_listview(ListView1, Text1.Text)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

End Class
