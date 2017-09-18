' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form12

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Public add_state As Boolean
	Private old_sy As String = ""
	
	Private Sub Command1_Click() Handles Command1.Click
		If is_empty(Text1) = True Then  Exit Sub
		If Len6(Text1.Text) < 9 Or Mid(Text1.Text, 5, 1) <> "-" Then  MsgBox6("Enry must be in this format (ex. yyyy-yyyy).", MsgBoxStyle.Exclamation, "CSRS version 1"): Text1.SetFocus(): Exit Sub
		
		If old_sy <> Text1.Text Then 
			If if_exist("tblSchoolYear", "SchoolYear", Text1) = True Then  Exit Sub
		End If
		
		With rs_sy
			If add_state = True Then  .AddNew()
			.Fields(0).Value = Text1.Text
			.Update()
		End With
		
		'------------------------------
		'Inform updates
		'------------------------------
		Dim rep As Short
		Dim pos As Integer
		If add_state = True Then 
			MsgBox6("Adding of new school year has been successfull.", MsgBoxStyle.Information, "CSRS version 1")
			rep = MsgBox6("Do you want to add another school year?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.Yes Then 
				Text1.Text = ""
				Text1.SetFocus()
				rs_sy.Requery()
				Form11.load_rec()
			Else
				rs_sy.Requery()
				Form11.load_rec()
				Unload6(Me)
			End If
			rep = 0
		Else
			MsgBox6("Changes in record has been successfully saved.", MsgBoxStyle.Information, "CSRS version 1")
			
			pos = rs_sy.AbsolutePosition
			rs_sy.Requery()
			Form11.load_rec()
			rs_sy.AbsolutePosition = pos
			
			Form11.ListView1.ListItems(pos).EnsureVisible()
			Form11.ListView1.ListItems(pos).Selected = True
			
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
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sy.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
			Text1.Text = rs_sy.Fields(0).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sy.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
			old_sy = rs_sy.Fields(0).Value
			Me.Icon = BitmapToIcon6(ImageList1.ListImages(1).Picture)
			Me.Caption = "Edit Existing School Year"
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		old_sy = ""
		Form11.Enabled = True
		
		Call save_pos(Me)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8 Or KeyAscii = 45) Then  KeyAscii = 0
	End Sub

End Class
