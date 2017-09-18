' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form4

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public sForm As VB6Form
	
	Private Sub Command1_Click() Handles Command1.Click
		Call selectCurList()
	End Sub

	Private Sub Command10_Click() Handles Command10.Click
		On Error GoTo Err 
		With rsGetLang
			'Check if there is no record
			If .RecordCount < 1 Then  MsgBox6("No record to delete.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
			'Confirm deletion of record
			Dim ans As Short = MsgBox6("Are you sure you want to delete the selected langguage?" & ControlChars.CrLf & ControlChars.CrLf & "WARNING:Deleting langguage will delete also all folders and files related on it.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Record Delete")
			Me.MousePointer = VBRUN.MousePointerConstants.vbHourglass
			If ans = MsgBoxResult.Yes Then 
				'Delete the record
				Call delete_rec(connGetLang, "tblLangguages", "Langguage", ListView1.SelectedItem.Text, False, 0)
				If Form1.Text1.Text = ListView1.SelectedItem.Text Then  Form1.Text1.Text = ""
				Call reload_rec()
				MsgBox6("Langguage has been successfully deleted.", MsgBoxStyle.Information, "Confirm")
			End If
			ans = 0
			Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		End With
		Exit Sub
Err:
		Call prompt_err(Err)
		Resume Next 
		
	End Sub

	Private Sub Command11_Click() Handles Command11.Click
		Unload6(Me)
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		If rsGetLang.RecordCount < 1 Then  MsgBox6("No record to edit.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
		With Form5
			.rs_add_lang = rsGetLang
			.conn_add_lang = connGetLang
			.edit_src_lang = ListView1.SelectedItem.Text
			.adding_rec = False
			.sForm = Me
			Me.Enabled = False
			.Show()
		End With
	End Sub

	Private Sub Command8_Click() Handles Command8.Click
		Dim search_str As String = InputBox6("Enter text to search:", "Search Record")
		If Len6(search_str) > 0 Then  Call search_in_listview(ListView1, search_str)
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		With Form5
			.rs_add_lang = rsGetLang
			.conn_add_lang = connGetLang
			.adding_rec = True
			.sForm = Me
			Me.Enabled = False
			.Show()
		End With
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		'Positioning the form
		Call centerObj(Me, Form1)
		'Set the connection
		Call set_conn_getData(connGetLang, App6.Path & "\Storedfile.mdb", True, "codelib!@#")
		'Set the recordset
		Call set_rec_getData(rsGetLang, connGetLang, "Select * From tblLangguages Order by Langguage")
		Call reload_rec()
	End Sub
	
	Public Sub reload_rec()
		rsGetLang.Filter = ""
		rsGetLang.Requery()
		Call FillListView(ListView1, rsGetLang, 1, 1, False, True)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		
		sForm.Enabled = True
		strLang = Nothing
		sForm = Nothing
		
		connGetLang = Nothing
		rsGetLang = Nothing
	End Sub

	Private Sub ListView1_DblClick() Handles ListView1.DblClick
		Call selectCurList()
	End Sub
	
	Private Sub selectCurList()
		On Error Resume Next 
		strLang.Text = ListView1.SelectedItem.Text
		Unload6(Me)
	End Sub

	Private Sub ListView1_KeyPress(ByRef KeyAscii As Short) Handles ListView1.KeyPress
		If KeyAscii = 27 Then  Unload6(Me)
		If KeyAscii = 13 Then  Call selectCurList()
	End Sub

End Class
