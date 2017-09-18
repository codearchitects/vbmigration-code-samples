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

	Private old_pwd As String = ""
	
	Private rs As New ADODB.RecordsetClass

	Private Sub Command1_Click() Handles Command1.Click
		Unload6(Me)
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If Text1.Text <> old_pwd Then  MsgBox6("Invalid old password!", MsgBoxStyle.Critical, "Code Library version 1.1"): Text1.SetFocus(): Exit Sub
		'////////////////////////////
		Dim tmp As String = Text2.Text
		
		Call remove_some_txt(tmp)
		Text2.Text = tmp
		tmp = ""
		'/////////////////////////////
		If is_empty(Text2) Then  Exit Sub
		
		rs.Fields(0).Value = Text2.Text: rs.Update()
		MsgBox6("Password has been successfully changed.", MsgBoxStyle.Information, "Code Library version 1.1")
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		'Positioning the form
		Call centerObj(Me, Form1)
		
		Call set_rec_getData(rs, cn, "Select * From tblPassword")
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		old_pwd = rs.Fields(0).Value
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs = Nothing
		old_pwd = ""
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text2_GotFocus() Handles Text2.GotFocus
		Call highlight_focus(Text2)
	End Sub

	Private Sub Text2_KeyPress(ByRef KeyAscii As Short) Handles Text2.KeyPress
		If KeyAscii = 39 Then  KeyAscii = 0
	End Sub

End Class
