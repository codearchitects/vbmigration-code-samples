' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_ISSUE (#02F8): Designer 'DataReport1' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport1.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport2' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport2.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport6' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport6.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport3' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport3.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport4' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport4.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport5' can't be converted (file 'C:\Documents and Settings\Admin\Desktop\SAMPLES\VB6 Samples in VB6\School\Reports\DataReport5.Dsr')
' UPGRADE_INFO (#0581): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public SY As String = ""
	Public sy_stat As String = ""
	
	Private Sub Combo1_Click() Handles Combo1.Click
		If Combo1.Text = "Ascending Order" Then 
			ListView1.Sorted = True
			ListView1.SortOrder = MSComctlLib.ListSortOrderConstants.lvwAscending
		ElseIf Combo1.Text = "Descending Order" Then 
			ListView1.Sorted = True
			ListView1.SortOrder = MSComctlLib.ListSortOrderConstants.lvwDescending
		Else
			Combo1.SetFocus()
		End If
	End Sub

	Private Sub Combo1_KeyPress(ByRef KeyAscii As Short) Handles Combo1.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		If sy_stat = "Open" Then 
			Form6.add_state = True
			Form6.Show()
			Me.Enabled = False
		Else
			MsgBox6("You cannot enroll new student because the School Year " & SY & " was already closed." & ControlChars.CrLf & ControlChars.CrLf & "Note: You can re-open the School Year if you want by selecting 'Option' in the menu and select 'Re-open School Year'.", MsgBoxStyle.Exclamation, "CSRS version 1")
		End If
	End Sub

	Private Sub Command10_Click() Handles Command10.Click
		If rs_stud.RecordCount < 1 Then  MsgBox6("No student in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Dim rep As Short
		Dim pos As Integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_stud.Fields(12).Value'. Consider using the GetDefaultMember6 helper method.
		If rs_stud.Fields(12).Value <> "Drop" Then 
			MsgBox6("Please select a student that is currently dropped in the school.", MsgBoxStyle.Exclamation, "CSRS version 1")
		Else
			rep = MsgBox6("Are you sure you want to undrop the selected student?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.No Then  Exit Sub
			rep = 0
			With rs_stud
				pos = .AbsolutePosition
				.Fields(12).Value = "Old"
				.Update()
				
				.Requery()
				Call fill_rec()
				.AbsolutePosition = pos
				
				ListView1.ListItems(Val(.AbsolutePosition)).EnsureVisible()
				ListView1.ListItems(Val(.AbsolutePosition)).Selected = True

				MsgBox6("The student was sucessfully undropped in the school and change it's status to 'Old'.", MsgBoxStyle.Information, "CSRS version 1")
				pos = 0
			End With
		End If
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If rs_stud.RecordCount < 1 Then  MsgBox6("No student in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Form6.add_state = False
		Form6.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		If rs_stud.RecordCount < 1 Then  MsgBox6("No student in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If Not IsNull6(rs_stud.Fields(10).Value) Then
			'------------------
			'Show Section
			'------------------
			Form3.sAssign = False
			Form3.Show(): Me.Enabled = False
		Else
			'------------------
			'Assign Section
			'------------------
			Form3.sAssign = True
			Form3.Show(): Me.Enabled = False
		End If
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		On Error GoTo Err 
		With rs_stud
			'---------------------------------
			'Check if there is no record
			'---------------------------------
			If .RecordCount < 1 Then  MsgBox6("No student in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
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
				Call delete_rec(cn, "tblStudents", "StudentNo", "", True, Val(ListView1.SelectedItem.ListSubItems(1).Text))
				.Requery()
				If .RecordCount > 0 Then 
					.AbsolutePosition = pos
					If .EOF Then  .MoveFirst()
					'---------------------------------
					'Fill listview
					'---------------------------------
					pos = .AbsolutePosition
					' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
					Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
					
					Call FillListView(ListView1, rs_stud, 6, 1, True, True)
					Label20.Caption = "of " & ListView1.ListItems.Count
					ListView1.ListItems(pos).EnsureVisible()
					ListView1.ListItems(pos).Selected = True
					.AbsolutePosition = ListView1.SelectedItem.Text
					
					' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
					Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
					'---------------------------------
					'End-fill listview
					'---------------------------------
				Else
					ListView1.ListItems.Clear()
					Label20.Caption = "of 0"
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
		Call reload_rec()
	End Sub
	
	Public Sub reload_rec()
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		rs_stud.Filter = ADODB.FilterGroupEnum.adFilterNone
		rs_stud.Requery()
		rs_stud.Filter = "Status <>'Drop'"
		Call FillListView(ListView1, rs_stud, 6, 1, True, True)
		If Not rs_stud.RecordCount < 1 Then  rs_stud.MoveFirst()
		Label20.Caption = "of " & ListView1.ListItems.Count
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub
	
	Public Sub fill_rec()
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		Call FillListView(ListView1, rs_stud, 6, 1, True, True)
		If Not rs_stud.RecordCount < 1 Then  rs_stud.MoveFirst()
		Label20.Caption = "of " & ListView1.ListItems.Count

		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		Unload6(Me)
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		If Text1.Text = "" Then  MsgBox6("Please enter some text to search.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text1.SetFocus(): Exit Sub
		Dim c As Byte
		With Form7
			For c = 1 To rs_stud.Fields.Count - 1
				.Combo1.AddItem(rs_stud.Fields(Val(c)).Name)
			Next
			.Text1.Text = Text1.Text
			.Show()
		End With
		Me.Enabled = False
		'----------------
		'Clear Variable
		'----------------
		c = 0
	End Sub

	Private Sub Command8_Click() Handles Command8.Click
		Form8.Show()
		Me.Enabled = False
	End Sub

	Private Sub Command9_Click() Handles Command9.Click
		If rs_stud.RecordCount < 1 Then  MsgBox6("No student in the list.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Dim rep As Short
		Dim pos As Integer
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_stud.Fields(12).Value'. Consider using the GetDefaultMember6 helper method.
		If rs_stud.Fields(12).Value = "Drop" Then 
			MsgBox6("The student was already dropped.", MsgBoxStyle.Exclamation, "CSRS version 1")
		Else
			rep = MsgBox6("Are you sure you want to drop the selected student?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.No Then  Exit Sub
			rep = 0
			
			With rs_stud
				pos = .AbsolutePosition
				.Fields(12).Value = "Drop"
				.Update()
				
				.Requery()
				Call fill_rec()
				If pos > .RecordCount Then 
					If Not .RecordCount < 1 Then  .MoveFirst()
				Else
					.AbsolutePosition = pos
				End If
				
				If Not .RecordCount < 1 Then  ListView1.ListItems(Val(.AbsolutePosition)).EnsureVisible()
				If Not .RecordCount < 1 Then  ListView1.ListItems(Val(.AbsolutePosition)).Selected = True
				
				MsgBox6("The student was sucessfully dropped in the school.", MsgBoxStyle.Information, "CSRS version 1")
				pos = 0
			End With
		End If
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Command1.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		'----------------------------
		'For student view option
		'----------------------------
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sds'. Consider using the SetDefaultMember6 helper method.
		sds = 0
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sms'. Consider using the SetDefaultMember6 helper method.
		sms = 1
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sfs'. Consider using the SetDefaultMember6 helper method.
		sfs = 1
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'sns'. Consider using the SetDefaultMember6 helper method.
		sns = 1
		sos = 1
		'----------------------------
		'End-For student view option
		'----------------------------
		Call set_rec_getData(rs_stud, cn, "Select qryStudents.* From qryStudents Where SchoolYear ='" & SY & "' Order by Sex Desc,LastName Asc,FirstName Asc")
		
		reload_rec()
		bind_controls()
		
		Me.Caption = Me.Caption & " For School Year " & SY
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		unbind_controls()
		
		rs_stud = Nothing
		
		frm_stud_show = False
		SY = ""
		sy_stat = ""
		Call save_pos(Me)
	End Sub

	Private Sub ListView1_ItemClick(ByVal Item As VB6ListItem) Handles ListView1.ItemClick
		If Not rs_stud.RecordCount < 1 Then  rs_stud.AbsolutePosition = ListView1.SelectedItem.Text
	End Sub

	Private Sub SSTab1_Click(ByRef PreviousTab As Short) Handles SSTab1.Click
		Select Case SSTab1.Tab
		Case 0
			ListView1.SetFocus()
		Case 1
			Text2.SetFocus()
		End Select
	End Sub
	
	Private Sub Text1_Change() Handles Text1.Change
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		Call search_in_listview(ListView1, Text1.Text)
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text18_Change() Handles Text18.Change
		If Val(Text18.Text) > ListView1.ListItems.Count Or Val(Text18.Text) < 1 Then  Text18.SetFocus(): Exit Sub
		ListView1.ListItems(Val(Text18.Text)).Selected = True
		rs_stud.AbsolutePosition = ListView1.SelectedItem.Text
	End Sub
	
	Public Sub bind_controls()
		'---------------------------
		'Set the datasource
		'---------------------------
		Text2.DataSource = rs_stud
		Text3.DataSource = rs_stud
		Text4.DataSource = rs_stud
		Text5.DataSource = rs_stud
		Text6.DataSource = rs_stud
		Text7.DataSource = rs_stud
		Text8.DataSource = rs_stud
		Text9.DataSource = rs_stud
		Text10.DataSource = rs_stud
		Text11.DataSource = rs_stud
		Text12.DataSource = rs_stud
		Text13.DataSource = rs_stud
		Text14.DataSource = rs_stud
		Text15.DataSource = rs_stud
		Text16.DataSource = rs_stud
		Text17.DataSource = rs_stud
		'-------------------------------
		'Set the datafield
		'-------------------------------
		Text2.DataField = "FirstName"
		Text3.DataField = "MiddleName"
		Text4.DataField = "LastName"
		Text5.DataField = "Sex"
		Text6.DataField = "DateOfBirth"
		Text7.DataField = "Age"
		Text8.DataField = "PlaceOfBirth"
		Text9.DataField = "Address"
		Text10.DataField = "FatherName"
		Text11.DataField = "Occupation1"
		Text12.DataField = "MotherName"
		Text13.DataField = "Occupation2"
		Text14.DataField = "ParentAddress"
		Text15.DataField = "SchoolLastAttend"
		Text16.DataField = "Status"
		Text17.DataField = "DateEnrolled"
	End Sub
	
	Public Sub unbind_controls()
		'-----------------------------------
		'Set the datasource
		'-----------------------------------
		Text2.DataSource = Nothing
		Text3.DataSource = Nothing
		Text4.DataSource = Nothing
		Text5.DataSource = Nothing
		Text6.DataSource = Nothing
		Text7.DataSource = Nothing
		Text8.DataSource = Nothing
		Text9.DataSource = Nothing
		Text10.DataSource = Nothing
		Text11.DataSource = Nothing
		Text12.DataSource = Nothing
		Text13.DataSource = Nothing
		Text14.DataSource = Nothing
		Text15.DataSource = Nothing
		Text16.DataSource = Nothing
		Text17.DataSource = Nothing
		'------------------------------
		'Set the datafield
		'------------------------------
		Text2.DataField = ""
		Text3.DataField = ""
		Text4.DataField = ""
		Text5.DataField = ""
		Text6.DataField = ""
		Text7.DataField = ""
		Text8.DataField = ""
		Text9.DataField = ""
		Text10.DataField = ""
		Text11.DataField = ""
		Text12.DataField = ""
		Text13.DataField = ""
		Text14.DataField = ""
		Text15.DataField = ""
		Text16.DataField = ""
		Text17.DataField = ""
	End Sub

	Private Sub Text18_GotFocus() Handles Text18.GotFocus
		Call highlight_focus(Text18)
	End Sub

	Private Sub Text18_KeyPress(ByRef KeyAscii As Short) Handles Text18.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text18_LostFocus() Handles Text18.LostFocus
		Text18.Text = Val(Text18.Text)
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub
	
	Private Sub Text3_GotFocus() Handles Text3.GotFocus
		Call highlight_focus(Text3)
	End Sub
	
	Private Sub Text4_GotFocus() Handles Text4.GotFocus
		Call highlight_focus(Text4)
	End Sub
	
	Private Sub Text5_GotFocus() Handles Text5.GotFocus
		Call highlight_focus(Text5)
	End Sub
	
	Private Sub Text6_GotFocus() Handles Text6.GotFocus
		Call highlight_focus(Text6)
	End Sub
	
	Private Sub Text7_GotFocus() Handles Text7.GotFocus
		Call highlight_focus(Text7)
	End Sub
	
	Private Sub Text8_GotFocus() Handles Text8.GotFocus
		Call highlight_focus(Text8)
	End Sub
	
	Private Sub Text9_GotFocus() Handles Text9.GotFocus
		Call highlight_focus(Text9)
	End Sub
	
	Private Sub Text10_GotFocus() Handles Text10.GotFocus
		Call highlight_focus(Text10)
	End Sub
	
	Private Sub Text11_GotFocus() Handles Text11.GotFocus
		Call highlight_focus(Text11)
	End Sub
	
	Private Sub Text12_GotFocus() Handles Text12.GotFocus
		Call highlight_focus(Text12)
	End Sub
	
	Private Sub Text13_GotFocus() Handles Text13.GotFocus
		Call highlight_focus(Text13)
	End Sub
	
	Private Sub Text14_GotFocus() Handles Text14.GotFocus
		Call highlight_focus(Text14)
	End Sub
	
	Private Sub Text15_GotFocus() Handles Text15.GotFocus
		Call highlight_focus(Text15)
	End Sub
	
	Private Sub Text16_GotFocus() Handles Text16.GotFocus
		Call highlight_focus(Text16)
	End Sub
	
	Private Sub Text17_GotFocus() Handles Text17.GotFocus
		Call highlight_focus(Text17)
	End Sub

End Class
