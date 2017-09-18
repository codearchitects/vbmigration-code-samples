' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form19

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Private rs_sel_lv As New ADODB.RecordsetClass
	
	Private Sub Command1_Click() Handles Command1.Click
		If ListView1.ListItems.Count < 1 Then  Unload6(Me): Exit Sub
		Form18.lv_id = ListView1.SelectedItem.ListSubItems(1).Text
		Form18.Text2.Text = ListView1.SelectedItem.ListSubItems(2).Text
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_sel_lv, cn, "Select tblLevel.* From tblLevel Order by LevelNo Asc")
		load_rec()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_sel_lv = Nothing
		Form18.Enabled = True
		
		Call save_pos(Me)
	End Sub
	
	Public Sub load_rec()
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		
		Call FillListView(ListView1, rs_sel_lv, 3, 1, True, True)
		
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
		If ListView1.ListItems.Count < 1 Then  Command1.Caption = "&Cancel"
	End Sub

End Class
