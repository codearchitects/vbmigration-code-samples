' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form15

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
		If Val(Text2.Text) = 0 Then  MsgBox6("The field must not be zero value.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text2.SetFocus(): Exit Sub
		If Val(Text3.Text) = 0 Then  MsgBox6("The field must not be zero value.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text3.SetFocus(): Exit Sub
		If Val(Text4.Text) = 0 Then  MsgBox6("The field must not be zero value.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text4.SetFocus(): Exit Sub
		
		If Val(Text2.Text) > Val(Text3.Text) Then  MsgBox6("The minimum average must not be greater than to " & Val(Text3.Text) & ".", MsgBoxStyle.Exclamation, "CSRS version 1"): Text3.SetFocus(): Exit Sub
		
		With rs_sec
			If add_state = True Then  .AddNew(): .Fields(0).Value = get_num("tblSections", "SectionNo", cn): .Fields(1).Value = Form14.lv_no
			.Fields(2).Value = Text1.Text
			.Fields(3).Value = Val(Text2.Text)
			.Fields(4).Value = Val(Text3.Text)
			.Fields(5).Value = Val(Text4.Text)
			.Update()
		End With
		'------------------------------
		'Inform updates
		'------------------------------
		Dim rep As Short
		Dim pos As Integer
		If add_state = True Then 
			MsgBox6("Adding of new section has been successfull.", MsgBoxStyle.Information, "CSRS version 1")
			rep = MsgBox6("Do you want to add another section?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.Yes Then 
				Text1.Text = ""
				Text2.Text = "0"
				Text3.Text = "0"
				Text4.Text = "0"
				Text1.SetFocus()
				rs_sec.Requery()
				Form14.load_rec()
			Else
				rs_sec.Requery()
				Form14.load_rec()
				Unload6(Me)
			End If
			rep = 0
		Else
			MsgBox6("Changes in record has been successfully saved.", MsgBoxStyle.Information, "CSRS version 1")
			
			pos = rs_sec.AbsolutePosition
			rs_sec.Requery()
			Form14.load_rec()
			rs_sec.AbsolutePosition = pos
			
			Form14.ListView1.ListItems(pos).EnsureVisible()
			Form14.ListView1.ListItems(pos).Selected = True
			
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
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sec.Fields(2).Value'. Consider using the GetDefaultMember6 helper method.
			Text1.Text = rs_sec.Fields(2).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sec.Fields(3).Value'. Consider using the GetDefaultMember6 helper method.
			Text2.Text = rs_sec.Fields(3).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sec.Fields(4).Value'. Consider using the GetDefaultMember6 helper method.
			Text3.Text = rs_sec.Fields(4).Value
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_sec.Fields(5).Value'. Consider using the GetDefaultMember6 helper method.
			Text4.Text = rs_sec.Fields(5).Value
			Me.Icon = BitmapToIcon6(ImageList1.ListImages(1).Picture)
			Me.Caption = "Edit Existing Section"
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form14.Enabled = True
		
		Call save_pos(Me)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub
	
	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub
	
	Private Sub Text3_GotFocus() Handles Text3.GotFocus
		Call highlight_focus(Text3)
	End Sub

	Private Sub Text3_KeyPress(ByRef KeyAscii As Short) Handles Text3.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text4_GotFocus() Handles Text4.GotFocus
		Call highlight_focus(Text4)
	End Sub

	Private Sub Text4_KeyPress(ByRef KeyAscii As Short) Handles Text4.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

End Class
