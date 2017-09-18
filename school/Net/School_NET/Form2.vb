' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form2

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Private rs_ssy As New ADODB.RecordsetClass
	
	Private Sub Command1_Click() Handles Command1.Click
		With Form1
			.SY = ListView1.SelectedItem.ListSubItems(1).Text
			.sy_stat = ListView1.SelectedItem.ListSubItems(2).Text
			.Show()
			frm_stud_show = True
		End With
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
	End Sub

	Private Sub DataCombo1_Change()
	' UPGRADE_INFO (#0501): The 'DataCombo1_Change' member isn't used anywhere in current application.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_ssy.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		Me.Caption = rs_ssy.Fields(0).Value
	End Sub
	
	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_ssy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")
		If rs_ssy.RecordCount < 1 Then  Command1.Visible = False: Exit Sub
		'----------------------------------
		'Fill the list view
		'----------------------------------
		Call FillListView(ListView1, rs_ssy, 3, 1, True, True)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_ssy = Nothing
		
		Call save_pos(Me)
	End Sub

End Class
