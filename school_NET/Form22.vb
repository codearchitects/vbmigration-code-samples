' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form22

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private rs_set As New ADODB.RecordsetClass

	Private Sub Command1_Click() Handles Command1.Click
		If is_empty(Text1) = True Then  Exit Sub
		If is_empty(Text2) = True Then  Exit Sub
		
		With rs_set
			.Fields(0).Value = Text1.Text
			.Fields(1).Value = Text2.Text
			.Update()
		End With
		
		school_name = Text1.Text
		school_address = Text2.Text
		MDIForm1.Caption = Text1.Text & " - " & "Computerize School Registration Software version 1"
		
		MsgBox6("Changes has been successfully saved.", MsgBoxStyle.Information, "CSRS version 1")
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Call set_rec_getData(rs_set, cn, "Select SystemInfo.* From SystemInfo")
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_set.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		Text1.Text = rs_set.Fields(0).Value
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_set.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
		Text2.Text = rs_set.Fields(1).Value
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs_set = Nothing
		
		Call save_pos(Me)
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

End Class
