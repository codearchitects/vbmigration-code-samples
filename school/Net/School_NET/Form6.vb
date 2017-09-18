' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form6

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public add_state As Boolean
	
	Private Sub Command1_Click() Handles Command1.Click
		'------------------------------
		'Check the required field
		'------------------------------
		If is_empty(Text2) = True Then  Exit Sub
		If is_empty(Text3) = True Then  Exit Sub
		If is_empty(Text4) = True Then  Exit Sub
		If is_empty(Text5) = True Then  Exit Sub
		If is_empty(Text6) = True Then  Exit Sub
		If is_empty(Text1) = True Then  Exit Sub
		If is_empty(Text17) = True Then  Exit Sub
		If is_empty(Text7) = True Then  Exit Sub
		If is_empty(Text8) = True Then  Exit Sub
		If is_empty(Text9) = True Then  Exit Sub
		If is_empty(Text10) = True Then  Exit Sub
		If is_empty(Text11) = True Then  Exit Sub
		If is_empty(Text12) = True Then  Exit Sub
		If is_empty(Text13) = True Then  Exit Sub
		If is_empty(Text14) = True Then  Exit Sub
		If is_empty(Text15) = True Then  Exit Sub
		If is_empty(Text16) = True Then  Exit Sub
		'------------------------------
		'End checking
		'------------------------------
		
		'------------------------------
		'Updating Database
		'------------------------------
		Dim c_no As Integer
		With rs_stud
			If add_state = True Then  .AddNew(): c_no = get_num("tblStudents", "StudentNo", cn): .Fields(0).Value = c_no: .Fields(11).Value = Form1.SY
			.Fields(1).Value = Text4.Text
			.Fields(2).Value = Text2.Text
			.Fields(3).Value = Text3.Text
			.Fields(4).Value = Text5.Text
			.Fields(5).Value = Format6(Text6.Text & "/" & Text1.Text & "/" & Text17.Text, "mm/dd/yyyy")
			.Fields(6).Value = Text7.Text
			.Fields(7).Value = Text9.Text
			.Fields(8).Value = Text15.Text
			
			.Fields(12).Value = Text16.Text
			.Fields(13).Value = DTPicker1.Value
			.Fields(14).Value = Text8.Text
			.Fields(15).Value = Text10.Text
			.Fields(16).Value = Text11.Text
			.Fields(17).Value = Text12.Text
			.Fields(18).Value = Text13.Text
			.Fields(19).Value = Text14.Text
			.Update()
		End With
		'------------------------------
		'End-Updating Database
		'------------------------------
		
		'------------------------------
		'Inform updates
		'------------------------------
		Dim rep As Short
		Dim pos As Integer
		If add_state = True Then 
			MsgBox6("Adding of new enrollee has been successfull.", MsgBoxStyle.Information, "CSRS version 1")
			rep = MsgBox6("Do you want to enroll another student?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CSRS version 1")
			If rep = MsgBoxResult.Yes Then 
				Command2_Click()
				Call locate_new_rec(c_no)
			Else
				Call locate_new_rec(c_no)
				Unload6(Me)
			End If
			rep = 0
			c_no = 0
		Else
			MsgBox6("Changes in record has been successfully saved.", MsgBoxStyle.Information, "CSRS version 1")
			
			pos = rs_stud.AbsolutePosition
			Form1.reload_rec()
			rs_stud.AbsolutePosition = pos
			
			Form1.ListView1.ListItems(pos).EnsureVisible()
			Form1.ListView1.ListItems(pos).Selected = True
			
			pos = 0
			Unload6(Me)
		End If
		'------------------------------
		'End-Inform updates
		'------------------------------
	End Sub
	
	Private Sub locate_new_rec(ByVal no As Integer)
		Form1.reload_rec()
		rs_stud.Find("StudentNo =" & no & "")
		If rs_stud.EOF Then  rs_stud.MoveFirst()
		Form1.ListView1.ListItems(rs_stud.AbsolutePosition).EnsureVisible()
		Form1.ListView1.ListItems(rs_stud.AbsolutePosition).Selected = True
	End Sub
	
	Private Sub Command2_Click() Handles Command2.Click
		Text1.Text = ""
		Text2.Text = ""
		Text3.Text = ""
		Text4.Text = ""
		Text5.Text = "Male"
		Text6.Text = ""
		Text7.Text = ""
		Text8.Text = ""
		Text9.Text = ""
		Text10.Text = ""
		Text11.Text = ""
		Text12.Text = ""
		Text13.Text = ""
		Text14.Text = ""
		Text15.Text = ""
		Text16.Text = "New"
		Text17.Text = ""
		DTPicker1.Value = Today
		Text2.SetFocus()
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		If add_state = True Then 
			Me.Caption = "Enroll New Student"
			DTPicker1.Value = Today
		Else
			Me.Icon = BitmapToIcon6(ImageList1.ListImages(1).Picture)
			Me.Caption = "Edit Existing Student"
			Command1.Caption = "&Save"
			
			'------------------------------
			'Get records
			'------------------------------
			With rs_stud
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
				Text4.Text = .Fields(1).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(2).Value'. Consider using the GetDefaultMember6 helper method.
				Text2.Text = .Fields(2).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(3).Value'. Consider using the GetDefaultMember6 helper method.
				Text3.Text = .Fields(3).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(4).Value'. Consider using the GetDefaultMember6 helper method.
				Text5.Text = .Fields(4).Value
				
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(5).Value'. Consider using the GetDefaultMember6 helper method.
				Text6.Text = Format6(.Fields(5).Value, "mm")
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(5).Value'. Consider using the GetDefaultMember6 helper method.
				Text1.Text = Format6(.Fields(5).Value, "dd")
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(5).Value'. Consider using the GetDefaultMember6 helper method.
				Text17.Text = Format6(.Fields(5).Value, "yyyy")
				
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(6).Value'. Consider using the GetDefaultMember6 helper method.
				Text7.Text = .Fields(6).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(7).Value'. Consider using the GetDefaultMember6 helper method.
				Text9.Text = .Fields(7).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(8).Value'. Consider using the GetDefaultMember6 helper method.
				Text15.Text = .Fields(8).Value
				
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(12).Value'. Consider using the GetDefaultMember6 helper method.
				Text16.Text = .Fields(12).Value
				DTPicker1.Value = .Fields(13).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(14).Value'. Consider using the GetDefaultMember6 helper method.
				Text8.Text = .Fields(14).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(15).Value'. Consider using the GetDefaultMember6 helper method.
				Text10.Text = .Fields(15).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(16).Value'. Consider using the GetDefaultMember6 helper method.
				Text11.Text = .Fields(16).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(17).Value'. Consider using the GetDefaultMember6 helper method.
				Text12.Text = .Fields(17).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(18).Value'. Consider using the GetDefaultMember6 helper method.
				Text13.Text = .Fields(18).Value
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(19).Value'. Consider using the GetDefaultMember6 helper method.
				Text14.Text = .Fields(19).Value
			End With
			'------------------------------
			'End-Get records
			'------------------------------
			
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form1.Enabled = True
		
		Call save_pos(Me)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text11_Validate(ByRef Cancel As Boolean) Handles Text11.Validate
		If Not Text11.Text = "" And Len6(Text11.Text) > 150 Then  MsgBox6("Please enter only 150 characters.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

	Private Sub Text13_Validate(ByRef Cancel As Boolean) Handles Text13.Validate
		If Not Text13.Text = "" And Len6(Text13.Text) > 150 Then  MsgBox6("Please enter only 150 characters.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

	Private Sub Text16_KeyPress(ByRef KeyAscii As Short) Handles Text16.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Text16_Validate(ByRef Cancel As Boolean) Handles Text16.Validate
		If Text16.Text <> "Drop" And Text16.Text <> "New" And Text16.Text <> "Old" Then  MsgBox6("Please select a valid entry in the list.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

	Private Sub Text17_KeyPress(ByRef KeyAscii As Short) Handles Text17.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub
	
	Private Sub Text3_GotFocus() Handles Text3.GotFocus
		Call highlight_focus(Text3)
	End Sub
	
	Private Sub Text4_GotFocus() Handles Text4.GotFocus
		Call highlight_focus(Text4)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text5_KeyPress(ByRef KeyAscii As Short) Handles Text5.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Text6_GotFocus() Handles Text6.GotFocus
		Call highlight_focus(Text6)
	End Sub

	Private Sub Text6_KeyPress(ByRef KeyAscii As Short) Handles Text6.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text7_GotFocus() Handles Text7.GotFocus
		Call highlight_focus(Text7)
	End Sub
	
	Private Sub Text8_GotFocus() Handles Text8.GotFocus
		Call highlight_focus(Text8)
	End Sub
	
	Private Sub Text9_GotFocus() Handles Text9.GotFocus
		Call highlight_focus(Text9)
	End Sub
	
	Private Sub Text10_GotFocus() Handles Text10.GotFocus
		Call highlight_focus(Text10)
	End Sub
	
	Private Sub Text12_GotFocus() Handles Text12.GotFocus
		Call highlight_focus(Text12)
	End Sub
	
	Private Sub Text14_GotFocus() Handles Text14.GotFocus
		Call highlight_focus(Text14)
	End Sub
	
	Private Sub Text15_GotFocus() Handles Text15.GotFocus
		Call highlight_focus(Text15)
	End Sub

	Private Sub Text5_Validate(ByRef Cancel As Boolean) Handles Text5.Validate
		If Text5.Text <> "Male" And Text5.Text <> "Female" Then  MsgBox6("Please select a valid entry in the list.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub
	
	Private Sub Text6_Validate(ByRef Cancel As Boolean) Handles Text6.Validate
		If Text6.Text = "" Then  Exit Sub
		If Val(Text6.Text) = 0 Or Val(Text6.Text) > 12 Then  MsgBox6("Please enter a valid mm/dd/yyyy date format.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True: Exit Sub
		If Val(Text6.Text) < 10 Then  Text6.Text = "0" & VB.Right(Text6.Text, 1)
	End Sub
	
	Private Sub Text1_Validate(ByRef Cancel As Boolean) Handles Text1.Validate
		If Text1.Text = "" Then  Exit Sub
		If Val(Text1.Text) = 0 Or Val(Text1.Text) > 31 Then  MsgBox6("Please enter a valid mm/dd/yyyy date format.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True: Exit Sub
		If Val(Text1.Text) < 10 Then  Text1.Text = "0" & VB.Right(Text1.Text, 1)
	End Sub
	
	Private Sub Text17_Validate(ByRef Cancel As Boolean) Handles Text17.Validate
		If Text17.Text = "" Then  Exit Sub
		If Val(Text17.Text) < 1900 Or Val(Text17.Text) > 2100 Then  MsgBox6("Please enter a valid mm/dd/yyyy date format.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

	Private Sub Text7_KeyPress(ByRef KeyAscii As Short) Handles Text7.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text7_Validate(ByRef Cancel As Boolean) Handles Text7.Validate
		If Not Text7.Text = "" And Val(Text7.Text) < 1 Then  MsgBox6("Please enter the valid age of the student.", MsgBoxStyle.Exclamation, "CSRS version 1"): Cancel = True
	End Sub

End Class
