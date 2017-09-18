' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form20

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Private rs_prnt_list As New ADODB.RecordsetClass

	Private Sub Command1_Click() Handles Command1.Click
		If is_empty(DataCombo1) = True Then  Exit Sub
		If Len6(DataCombo1.Text) < 9 Or Mid(DataCombo1.Text, 5, 1) <> "-" Then  MsgBox6("Enry must be in this format (ex. yyyy-yyyy).", MsgBoxStyle.Exclamation, "CSRS version 1"): DataCombo1.SetFocus(): Exit Sub
		
		If Check1.Value = 1 Then 
			rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "'"
		Else
			rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "' And Status <>'Drop'"
		End If
		
		If rs_prnt_list.RecordCount < 1 Then 
			MsgBox6("The selected school year does not have student record.", MsgBoxStyle.Exclamation, "CSRS version 1")
			DataCombo1.SetFocus()
			Exit Sub
		End If
		
		With rpt_header
			.SchoolAddress = school_address
			.SchoolName = school_name
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_prnt_list.Fields(11).Value'. Consider using the GetDefaultMember6 helper method.
			.SY = "S.Y.  " & rs_prnt_list.Fields(11).Value
		End With
		
	' UNSUPPORTED: 	DataReport4.DataSource = rs_prnt_list
	' UNSUPPORTED: 	DataReport4.Show(VBRUN.FormShowConstants.vbModal)
		
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
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
		
		Call set_rec_getData(rs_prnt_list, cn, "Select qryStudents.* From qryStudents Order by Sex Desc,LastName Asc,FirstName Asc")
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_prnt_list = Nothing
		
		Call save_pos(Me)
	End Sub

End Class
