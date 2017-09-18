' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form5

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public sForm As VB6Form
	
	Public adding_rec As Boolean
	
	Public edit_src_lang As String = ""
	
	Public rs_add_lang As ADODB.Recordset
	Public conn_add_lang As ADODB.Connection

	Private Sub Command1_Click() Handles Command1.Click
		Unload6(Me)
	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		'////////////////////////////
		Dim tmp As String = Text1.Text
		
		Call remove_some_txt(tmp)
		Text1.Text = tmp
		tmp = ""
		'/////////////////////////////
		If is_empty(Text1) = True Then  Exit Sub
		
		If LCase(Text1.Text) <> LCase(edit_src_lang) Then 
			If if_exist("tblLangguages", "Langguage", Text1, conn_add_lang) = True Then  Exit Sub
		Else
			MsgBox6("No changes made.", MsgBoxStyle.Information, "Code Library version 1.1")
			Unload6(Me)
			Exit Sub
		End If
		
		With rs_add_lang
			If adding_rec = True Then  .AddNew()
			.Fields(0).Value = Text1.Text
			.Update()
		End With
		' UPGRADE_INFO (#0501): The 'reply' member isn't used anywhere in current application.
		Dim reply As Short
		If adding_rec = False Then 
			MsgBox6("Changes in langguage has been successfully saved.", MsgBoxStyle.Information, "Code Library version 1.1")
			FRM_UPDATE_REC.seconds = 3
			FRM_UPDATE_REC.Show(VBRUN.FormShowConstants.vbModal)
			Form4.reload_rec()
			Unload6(Me)
		Else
			MsgBox6("New langguage has been successfully added.", MsgBoxStyle.Information, "Code Library version 1.1")
			FRM_UPDATE_REC.seconds = 3
			FRM_UPDATE_REC.Show(VBRUN.FormShowConstants.vbModal)
			Form4.reload_rec()
			Unload6(Me)
		End If
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Text1.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		On Error GoTo Err 
		'Positioning the form
		Call centerObj(Me, Form4)
		If adding_rec = True Then 
			Me.Caption = "Add New Langguage"
		Else
			Me.Caption = "Edit Langguage"
			Me.Icon = BitmapToIcon6(ImageList1.ListImages(1).Picture)
			Command3.Caption = "Save"
			rs_add_lang.Filter = "Langguage ='" & edit_src_lang & "'"
			If rs_add_lang.RecordCount < 1 Then  MsgBox6("There is a changes in record since it was last modified.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs_add_lang.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
			Text1.Text = rs_add_lang.Fields(0).Value
		End If
		Exit Sub
Err:
		If Err.Number = 94 Then  'Error when incountered a null value
			Resume Next 
		Else
			Call prompt_err(Err)
		End If
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		sForm.Enabled = True
		sForm = Nothing
		
		edit_src_lang = ""
		
		rs_add_lang = Nothing
		conn_add_lang = Nothing
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If KeyAscii = 39 Then  KeyAscii = 0
	End Sub

End Class
