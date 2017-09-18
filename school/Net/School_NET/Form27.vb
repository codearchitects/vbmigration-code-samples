' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form27

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public add_state As Boolean
	
	Private Sub Command1_Click() Handles Command1.Click
		If is_empty(Text1) = True Then  Exit Sub
		If is_empty(Text3) = True Then  Exit Sub
		
		With rs_log
			If add_state = True Then  .AddNew()
			.Fields(1).Value = Text1.Text
			.Fields(2).Value = Text2.Text
			.Fields(3).Value = Text3.Text
			.Update()
		End With
		'------------------------------
		'Inform updates
		'------------------------------
		Dim rep As Short
		Dim pos As Integer
		If add_state = True Then 
			MsgBox6("Adding of new user has been successfull.", MsgBoxStyle.Information, "CSRS version 1")
			rep = MsgBox6("Do you want to add another user?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.Yes Then 
				Text1.Text = ""
				Text2.Text = "User"
				Text3.Text = ""
				Text1.SetFocus()
				rs_log.Requery()
				Form26.load_rec()
			Else
				rs_log.Requery()
				Form26.load_rec()
				Unload6(Me)
			End If
			rep = 0
		Else
			If LCase(user_name) = LCase(Text1.Text) Then 
				user_name = Text1.Text
				user_type = Text2.Text
				MDIForm1.StatusBar1.Panels(3).Text = user_name
			End If
			MsgBox6("Changes in record has been successfully saved.", MsgBoxStyle.Information, "CSRS version 1")
			
			pos = rs_log.AbsolutePosition
			rs_log.Requery()
			Form26.load_rec()
			rs_log.AbsolutePosition = pos
			
			Form26.ListView1.ListItems(pos).EnsureVisible()
			Form26.ListView1.ListItems(pos).Selected = True
			
			pos = 0
			Unload6(Me)
		End If
		'------------------------------
		'End-Inform updates
		'------------------------------
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		If add_state = False Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_log.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
			Text1.Text = rs_log.Fields(1).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_log.Fields(2).Value'. Consider using the GetDefaultMember6 helper method.
			Text2.Text = rs_log.Fields(2).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_log.Fields(3).Value'. Consider using the GetDefaultMember6 helper method.
			Text3.Text = rs_log.Fields(3).Value
			Me.Icon = BitmapToIcon6(ImageList1.ListImages(1).Picture)
			Me.Caption = "Edit Existing User"
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form26.Enabled = True
		
		Call save_pos(Me)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub
	
	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Text2_Validate(ByRef Cancel As Boolean) Handles Text2.Validate
		If Text2.Text <> "User" And Text2.Text <> "Admin" Then  MsgBox6("Please select a valid entry in the list.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

	Private Sub Text3_GotFocus() Handles Text3.GotFocus
		Call highlight_focus(Text3)
	End Sub

End Class
