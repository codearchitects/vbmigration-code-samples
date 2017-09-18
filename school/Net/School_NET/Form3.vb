' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form3

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public sAssign As Boolean
	Private sEdit As Boolean
	Public sSec_Id As Integer

	Private Sub Command1_Click() Handles Command1.Click
		If Command1.Caption = "Cancel" And sEdit = True Then 
			disable_text()
			Command1.Caption = "&OK"
			Command1.Default = True
			Command2.Caption = "&Edit"
			Command3.Visible = False
			Me.Caption = "Student Section"
		Else
			Unload6(Me)
		End If
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_stud.Fields(12).Value'. Consider using the GetDefaultMember6 helper method.
		If rs_stud.Fields(12).Value = "Drop" Then  MsgBox6("Cannot Assign or Re-assign Section because the selected student was currently dropped in the school." & ControlChars.CrLf & ControlChars.CrLf & "Note: You can Undrop the Student if you want by selecting 'File' in the menu and then 'Student Record' and select 'Undrop Student'.", MsgBoxStyle.Exclamation, "CSRS version 1"): Exit Sub
		Dim pos As Integer
		If Command2.Caption = "&Edit" Then 
			sEdit = True
			enable_text()
			Text2.Locked = True
			Command1.Caption = "&Cancel"
			Command2.Caption = "&Save"
			Command2.Default = True
			Command3.Visible = True
			Me.Caption = "Re-assign Section"
		Else
			If is_empty(Text1) = True Then  Exit Sub
			If is_empty(Text2) = True Then  Exit Sub
			With rs_stud
				.Fields(9).Value = Text1.Text
				.Fields(10).Value = sSec_Id
				.Update()
				pos = .AbsolutePosition
				.Requery()
				.AbsolutePosition = pos
				pos = 0
			End With
			MsgBox6("Updating of data has been successfull.", MsgBoxStyle.Information, "CSRS version 1")
			Unload6(Me)
		End If
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		If Val(Text1.Text) < 1 Then  MsgBox6("Please put the general average first.", MsgBoxStyle.Exclamation, "CSRS version 1"): Text1.SetFocus(): Exit Sub
		If Text2.BorderStyle = 1 Then  Form4.gen_ave = Val(Text1.Text): Form4.Show(): Me.Enabled = False
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)

		If sAssign = True Then 
			enable_text()
			Command1.Caption = "&Cancel"
			Command2.Caption = "&Update"
			Command2.Default = True
			Command3.Visible = True
			Me.Caption = "Assign Section"
		Else
			If Not rs_stud.RecordCount < 1 Then 
				With rs_stud
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(9).Value'. Consider using the GetDefaultMember6 helper method.
					Text1.Text = .Fields(9).Value
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(20).Value'. Consider using the GetDefaultMember6 helper method.
					Text2.Text = .Fields(20).Value
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(11).Value'. Consider using the GetDefaultMember6 helper method.
					Text3.Text = .Fields(11).Value
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(21).Value'. Consider using the GetDefaultMember6 helper method.
					Text4.Text = .Fields(21).Value
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(10).Value'. Consider using the GetDefaultMember6 helper method.
					sSec_Id = .Fields(10).Value
				End With
			End If
			Command1.Default = True
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form1.Enabled = True
		
		Call save_pos(Me)
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		If Text2.BorderStyle = 1 Then  Text2.Text = ""
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then  KeyAscii = 0
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		Command3_Click()
	End Sub

	Private Sub Text3_GotFocus() Handles Text3.GotFocus
		Call highlight_focus(Text3)
	End Sub
	
	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub
	
	Public Sub disable_text()
		Text1.Locked = True
		Text1.BorderStyle = 0
		Text1.BackColor = SystemColors.Control 
		Text2.BorderStyle = 0
		Text2.BackColor = FromOleColor6(&HE6FFFF)
	End Sub
	
	Public Sub enable_text()
		Text1.Locked = False
		Text1.BorderStyle = 1
		Text1.BackColor = SystemColors.Window 
		Text2.BorderStyle = 1
		Text2.BackColor = FromOleColor6(&HE6FFFF)
	End Sub

End Class
