' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form2

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public sSQL As String = ""
	Public sTitle As String = ""
	
	Private rs As New ADODB.RecordsetClass

	Private Sub Form_Load() Handles MyBase.Load
		Me.Caption = sTitle
		Call set_rec_getData(rs, cn, sSQL)
		If rs.RecordCount < 1 Then  MsgBox6("There is a changes in record since it was last modified.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
		Text1.TextRTF = rs.Fields(1).Value
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		Text1.Width = Me.Width - 130
		Text1.Height = Me.Height - 400
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		rs = Nothing
		sTitle = ""
		sSQL = ""
	End Sub

	Private Sub Text1_DblClick() Handles Text1.DblClick
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If KeyAscii = 27 Then  Unload6(Me)
	End Sub

End Class
