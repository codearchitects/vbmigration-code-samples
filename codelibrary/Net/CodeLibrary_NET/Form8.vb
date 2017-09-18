' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form8

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private rs As New ADODB.RecordsetClass
	Private cn1 As New ADODB.ConnectionClass
	Private Sub Command1_Click() Handles Command1.Click
		Application.Exit(): End
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		If Text1.Text <> rs.Fields(0).Value Then  MsgBox6("Invalid application password!", MsgBoxStyle.Critical, "Code Library version 1.1"): Text1.SetFocus(): Exit Sub
		
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		'Positioning the form
		Call centerObj(Me, Form1)
		
		'Set the connection
		Call set_conn_getData(cn1, App6.Path & "\Storedfile.mdb", True, "codelib!@#")
		Call set_rec_getData(rs, cn1, "Select * From tblPassword")
	End Sub

	Private Sub Form_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		If UnloadMode = 0 Then  Application.Exit(): End
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs = Nothing
		cn1 = Nothing
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If KeyAscii = 27 Then  Application.Exit(): End
		If KeyAscii = 39 Then  KeyAscii = 0
	End Sub

End Class
