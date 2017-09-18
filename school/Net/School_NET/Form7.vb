' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form7

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Private Sub Combo1_KeyPress(ByRef KeyAscii As Short) Handles Combo1.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Combo2_KeyPress(ByRef KeyAscii As Short) Handles Combo2.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Unload6(Me)
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		If Combo1.Text = "" Then  Combo1.SetFocus(): Exit Sub
		If Option2.Value = True And Combo2.Text = "" Then  Combo2.SetFocus(): Exit Sub
		Me.MousePointer = VBRUN.MousePointerConstants.vbHourglass
		On Error GoTo Err 
		If Option1.Value = True Then 
			'----------------------------
			'For quick search
			'----------------------------
			rs_stud.Filter = Combo1.Text & " like *" & Text1.Text & "*"
			MsgBox6("There is/are " & rs_stud.RecordCount & " record found in the search for " & Text1.Text & "." & ControlChars.CrLf & "'Click' reload button in the Student Record form if you want to show all data.", MsgBoxStyle.Information, "CSRS version 1")
		Else
			'----------------------------
			'For custom search
			'----------------------------
			rs_stud.Filter = Combo1.Text & " " & Combo2.Text & " '" & Text1.Text & "'"
			MsgBox6("There is/are " & rs_stud.RecordCount & " record found in the search for " & Text1.Text & "." & ControlChars.CrLf & "'Click' reload button in the Student Record form if you want to show all data.", MsgBoxStyle.Information, "CSRS version 1")
		End If
		'----------------------------
		'Load search result
		'----------------------------
		Form1.fill_rec()
		Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		Unload6(Me)
		Exit Sub
		'----------------------------
		'Prompt if their is an error
		'----------------------------
Err:
		Call prompt_err(Err.Description)
		Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Call use_pos(Me)
		
		Option1.Value = True
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Form1.Enabled = True
		
		Call save_pos(Me)
	End Sub

	Private Sub Option1_Click() Handles Option1.Click
		Label1.Top = 1320
		Combo1.Top = 1560
		Label2.Visible = False
		Label3.Visible = False
		Text1.Visible = False
		Combo2.Visible = False
	End Sub

	Private Sub Option2_Click() Handles Option2.Click
		Label1.Top = 1320
		Combo1.Top = 1560
		Label2.Visible = True
		Label3.Visible = True
		Text1.Visible = True
		Combo2.Visible = True
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

End Class
