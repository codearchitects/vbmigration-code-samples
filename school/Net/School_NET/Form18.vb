' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form18

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	' UPGRADE_INFO (#0501): The 'gen_ave' member isn't used anywhere in current application.
	Public gen_ave As Short
	Public lv_id As Integer
	
	Private rs_sel_sec As New ADODB.RecordsetClass
	Private Sub Command1_Click() Handles Command1.Click
		If ListView1.ListItems.Count < 1 Then  Unload6(Me): Exit Sub
		
		Form17.prnt_sec = ListView1.SelectedItem.ListSubItems(1).Text
		Form17.Text2.Text = ListView1.SelectedItem.ListSubItems(2).Text
		Unload6(Me)
		
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Form19.Show(): Me.Enabled = False
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_sel_sec, cn, "Select qrySections.* From qrySections Order by MinAve Desc")
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_sel_sec = Nothing
		Form17.Enabled = True
		
		Call save_pos(Me)
	End Sub

	Private Sub Text2_Change() Handles Text2.Change
		
		rs_sel_sec.Filter = "LevelNo = " & lv_id
		
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
