' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form17

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Public prnt_sec As Integer
	
	Private rs_prnt_stud As New ADODB.RecordsetClass
	
	Private Sub SSTab1_DblClick()
	' UPGRADE_INFO (#0501): The 'SSTab1_DblClick' member isn't used anywhere in current application.
		
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		If ListView1.ListItems.Count < 1 Then  MsgBox6("No student record to print.", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If Not rs_prnt_stud.RecordCount < 1 Then  rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem.Text

		With rpt_header
			.SchoolAddress = school_address
			.SchoolName = school_name
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_prnt_stud.Fields(11).Value'. Consider using the GetDefaultMember6 helper method.
			.SY = "S.Y.  " & rs_prnt_stud.Fields(11).Value
		End With
		
		Dim rpt_rs As New ADODB.RecordsetClass
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_prnt_stud.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		Call set_rec_getData(rpt_rs, cn, "Select qryStudents.* From qryStudents Where StudentNo =" & rs_prnt_stud.Fields(0).Value & " Order by Sex Desc,LastName Asc")
		
	' UNSUPPORTED: 	DataReport1.DataSource = rpt_rs
	' UNSUPPORTED: 	DataReport1.Show(VBRUN.FormShowConstants.vbModal)
		
		rpt_rs = Nothing
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If ListView1.ListItems.Count < 1 Then  MsgBox6("No student record to print.", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If rs_prnt_stud.RecordCount < 1 Then  Exit Sub

		With rpt_header
			.SchoolAddress = school_address
			.SchoolName = school_name
			.SY = "S.Y.  " & DataCombo1.Text
		End With
		
	' UNSUPPORTED: 	DataReport2.DataSource = rs_prnt_stud
	' UNSUPPORTED: 	DataReport2.Show(VBRUN.FormShowConstants.vbModal)
		
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Form18.Show(): Me.Enabled = False
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		If ListView1.ListItems.Count < 1 Then  MsgBox6("No student record to print.", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		If Not ListView1.SelectedItem.Text = "" And Not rs_prnt_stud.RecordCount < 1 Then  rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem.Text
		
		On Error Resume Next 
		
		Kill(Environ("TMP") & "\SupportDB.mdb")
		FileCopy(App6.Path & "\SupportDB.db", Environ("TMP") & "\SupportDB.mdb")
		
		Dim cn_tmp As New ADODB.ConnectionClass
		Dim rs_tmp As New ADODB.RecordsetClass
		' UPGRADE_INFO (#0561): The 'pos' symbol was defined without an explicit "As" clause.
		Dim pos As Object = Nothing
		Dim c As Integer
		
		Call set_conn_getData(cn_tmp, Environ("TMP") & "\SupportDB.mdb", True, "reg386")
		Call set_rec_getData(rs_tmp, cn_tmp, "Select tblStudent.* From tblStudent")
		
		With rs_prnt_stud
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'pos'. Consider using the SetDefaultMember6 helper method.
			pos = .AbsolutePosition
			
			.MoveFirst()
			For c = 1 To .RecordCount
				rs_tmp.AddNew()
				rs_tmp.Fields(0).Value = c
				rs_tmp.Fields(1).Value = .Fields(23).Value
				rs_tmp.Update()
				
				.MoveNext()
			Next
			
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'pos'. Consider using the GetDefaultMember6 helper method.
			.AbsolutePosition = pos
		End With
		
		rs_tmp.Requery()
		
		With rpt_header
			.SchoolAddress = school_address
			.SchoolName = school_name
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_prnt_stud.Fields(11).Value'. Consider using the GetDefaultMember6 helper method.
			.SY = "S.Y.  " & rs_prnt_stud.Fields(11).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_prnt_stud.Fields("LevelName").Value'. Consider using the GetDefaultMember6 helper method.
			.SectionName = rs_prnt_stud.Fields("LevelName").Value & " - " & Text2.Text
		End With
		
	' UNSUPPORTED: 	DataReport3.DataSource = rs_tmp
	' UNSUPPORTED: 	DataReport3.Show(VBRUN.FormShowConstants.vbModal)
		
		rs_tmp = Nothing
		cn_tmp = Nothing
	End Sub

	Private Sub Command5_Click() Handles Command5.Click
		If is_empty(DataCombo1) = True Then  Exit Sub
		If is_empty(Text2) = True Then  Exit Sub
		If Len6(DataCombo1.Text) < 9 Or Mid(DataCombo1.Text, 5, 1) <> "-" Then  MsgBox6("Enry must be in this format (ex. yyyy-yyyy).", MsgBoxStyle.Exclamation, "CSRS version 1"): DataCombo1.SetFocus(): Exit Sub
		
		rs_prnt_stud.Filter = ADODB.FilterGroupEnum.adFilterNone
		rs_prnt_stud.Requery()
		If Text5.Text = "No" Then 
			rs_prnt_stud.Filter = "SchoolYear ='" & DataCombo1.Text & "' And Status <>'Drop' And SN =" & prnt_sec
		Else
			rs_prnt_stud.Filter = "SchoolYear ='" & DataCombo1.Text & "' And SN =" & prnt_sec
		End If
		Call fill_rec()
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		Unload6(Me)
	End Sub

	Private Sub DataCombo1_Change() Handles DataCombo1.Change
		Text2.Text = ""
	End Sub

	Private Sub DataCombo1_KeyPress(ByRef KeyAscii As Short) Handles DataCombo1.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Dim rs_sy As New ADODB.RecordsetClass
		Call set_rec_getData(rs_sy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")
		
		DataCombo1.RowSource = rs_sy
		DataCombo1.ListField = "SchoolYear"
		
		rs_sy = Nothing
		
		Call set_rec_getData(rs_prnt_stud, cn, "Select qryStudents.* From qryStudents Order by Sex Desc,LastName Asc,FirstName Asc")
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_prnt_stud = Nothing
		
		Call save_pos(Me)
	End Sub

	Private Sub ListView1_Click() Handles ListView1.Click
		
		If Not rs_prnt_stud.RecordCount < 1 Then  rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem.Text
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		Command3_Click()
	End Sub

	Private Sub Text5_KeyPress(ByRef KeyAscii As Short) Handles Text5.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Text5_Validate(ByRef Cancel As Boolean) Handles Text5.Validate
		If Text5.Text <> "No" And Text5.Text <> "Yes" Then  MsgBox6("Please select a valid entry in the list.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub
	
	Public Sub fill_rec()
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		Call FillListView(ListView1, rs_prnt_stud, 6, 1, True, True)
		If Not rs_prnt_stud.RecordCount < 1 Then  rs_prnt_stud.MoveFirst()
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub

End Class
