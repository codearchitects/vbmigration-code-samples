' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form21

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
		On Error Resume Next 
		
		Dim cn_tmp As New ADODB.ConnectionClass
		Dim rs_tmp As New ADODB.RecordsetClass
		Dim rs_lv As New ADODB.RecordsetClass
		
		Call set_rec_getData(rs_lv, cn, "Select tblLevel.* From tblLevel Order by LevelNo Asc")
		If rs_lv.RecordCount < 1 Then  MsgBox6("There is no level available.", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		
		Kill(Environ("TMP") & "\SupportDB.mdb")
		FileCopy(App6.Path & "\SupportDB.db", Environ("TMP") & "\SupportDB.mdb")
		
		Call set_conn_getData(cn_tmp, Environ("TMP") & "\SupportDB.mdb", True, "reg386")
		Call set_rec_getData(rs_tmp, cn_tmp, "Select tblSummary.* From tblSummary")
		
		rs_prnt_list.Requery()
		Do While Not rs_lv.EOF
			If Check1.Value = 1 Then 
				rs_tmp.AddNew()
				rs_tmp.Fields(0).Value = rs_lv.Fields(1).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value & " And Sex ='Male'"
				rs_tmp.Fields(1).Value = rs_prnt_list.RecordCount
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value & " And Sex ='Female'"
				rs_tmp.Fields(2).Value = rs_prnt_list.RecordCount
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value
				rs_tmp.Fields(3).Value = rs_prnt_list.RecordCount
				rs_tmp.Update()
			Else
				rs_tmp.AddNew()
				rs_tmp.Fields(0).Value = rs_lv.Fields(1).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "Status <>'Drop' And SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value & " And Sex ='Male'"
				rs_tmp.Fields(1).Value = rs_prnt_list.RecordCount
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "Status <>'Drop' And SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value & " And Sex ='Female'"
				rs_tmp.Fields(2).Value = rs_prnt_list.RecordCount
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_lv.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				rs_prnt_list.Filter = "Status <>'Drop' And SchoolYear ='" & DataCombo1.Text & "' And LevelNo =" & rs_lv.Fields(0).Value
				rs_tmp.Fields(3).Value = rs_prnt_list.RecordCount
				rs_tmp.Update()
			End If
			
			rs_lv.MoveNext()
		Loop
		
		With rpt_header
			.SchoolAddress = school_address
			.SchoolName = school_name
			.SY = "S.Y.  " & DataCombo1.Text
		End With
		
	' UNSUPPORTED: 	DataReport5.DataSource = rs_tmp
	' UNSUPPORTED: 	DataReport5.Show(VBRUN.FormShowConstants.vbModal)
		
		rs_lv = Nothing
		rs_tmp = Nothing
		cn_tmp = Nothing
		
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
		
		Call set_rec_getData(rs_prnt_list, cn, "Select qrySummaryReport.* From qrySummaryReport Order by LevelNo Asc")
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_prnt_list = Nothing
		
		Call save_pos(Me)
	End Sub

End Class
