' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form4

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public gen_ave As Short
	Public lv_id As Integer
	
	Private rs_sel_sec As New ADODB.RecordsetClass
	Private rs_cur_stud As New ADODB.RecordsetClass

	Private Sub Command1_Click() Handles Command1.Click
		If ListView1.ListItems.Count < 1 Then  Unload6(Me): Exit Sub
		
		If Val(rs_cur_stud.RecordCount) + 1 > Val(ListView1.SelectedItem.ListSubItems(5).Text) Then 
			MsgBox6("This section already have " & rs_cur_stud.RecordCount & " student in this School Year " & Form1.SY & "." & ControlChars.CrLf & ControlChars.CrLf & "Note: This section allowed only " & ListView1.SelectedItem.ListSubItems(5).Text & " students.", MsgBoxStyle.Exclamation, "CSRS version 1")
		Else
			Form3.sSec_Id = ListView1.SelectedItem.ListSubItems(1).Text
			Form3.Text2.Text = ListView1.SelectedItem.ListSubItems(2).Text
			Unload6(Me)
		End If
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Form5.Show(): Me.Enabled = False
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		reset()
		With ListView1.SelectedItem
			Text1.Text = .ListSubItems(3).Text & " - " & .ListSubItems(4).Text
			Text3.Text = .ListSubItems(5).Text
		End With
		rs_cur_stud.Filter = "Sec = " & ListView1.SelectedItem.ListSubItems(1).Text & " And SchoolYear = '" & Form1.SY & "'"
		Text4.Text = rs_cur_stud.RecordCount
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_sel_sec, cn, "Select qrySections.* From qrySections Order by MinAve Desc")
		Call set_rec_getData(rs_cur_stud, cn, "Select qryStudentAndSection.* From qryStudentAndSection")
		
		Label1.Caption &= gen_ave
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_sel_sec = Nothing
		rs_cur_stud = Nothing
		Form3.Enabled = True
		
		Call save_pos(Me)
	End Sub

	Private Sub ListView1_ItemClick(ByVal Item As VB6ListItem) Handles ListView1.ItemClick
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		reset()
		With ListView1.SelectedItem
			Text1.Text = .ListSubItems(3).Text & " - " & .ListSubItems(4).Text
			Text3.Text = .ListSubItems(5).Text
		End With
		rs_cur_stud.Filter = "((Sec) = " & ListView1.SelectedItem.ListSubItems(1).Text & ") And ((SchoolYear) = '" & Form1.SY & "') And ((Status) <> 'Drop')"
		Text4.Text = rs_cur_stud.RecordCount
	End Sub
	
	Public Sub reset()
		Text1.Text = ""
		Text3.Text = ""
		Text4.Text = ""
	End Sub

	Private Sub Text2_Change() Handles Text2.Change
		If Text2.Text = "" Then  Exit Sub
		
		rs_sel_sec.Filter = "MinAve <= " & gen_ave & " And LevelNo = " & lv_id
		
		load_rec()
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		Command3_Click()
	End Sub
	
	Public Sub load_rec()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		rs_sel_sec.Requery()
		Call FillListView(ListView1, rs_sel_sec, 6, 1, True, True)
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		If ListView1.ListItems.Count < 1 Then 
			Command1.Caption = "&Close"
		Else
			Command1.Caption = "&Select"
		End If
	End Sub

End Class
