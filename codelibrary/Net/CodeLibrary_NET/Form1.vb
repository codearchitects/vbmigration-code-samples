' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0581): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Private Sub Command1_Click() Handles Command1.Click
		Dim oldString As String = Text1.Text
		strLang = Text1
		With Form4
			.sForm = Me
			.Show()
			Me.Enabled = False
		End With
	End Sub

	Public Sub reload_files()
		ListView1.ListItems.Clear()
		With rs_files
			If .RecordCount < 1 Then  Command9.Enabled = False: Command5.Enabled = False: Command4.Enabled = False: Exit Sub
			Command9.Enabled = True: Command5.Enabled = True: Command4.Enabled = True
			.MoveFirst()
			Do While Not .EOF
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				ListView1.ListItems.Add(, , .Fields(0).Value, 1, 1)
				.MoveNext()
			Loop
			.MoveFirst()
			ListView1.ListItems(.AbsolutePosition).EnsureVisible()
			ListView1.ListItems(.AbsolutePosition).Selected = True
		End With
	End Sub
	
	Public Sub reload_folder()
		TreeView1.Nodes.Clear()
		ListView1.ListItems.Clear()
		With rs_folder
			If .RecordCount < 1 Then  Command6.Enabled = False: Command3.Enabled = False: Command2.Enabled = False: Command9.Enabled = False: Command5.Enabled = False: Command4.Enabled = False: Exit Sub
			Command6.Enabled = True: Command3.Enabled = True: Command2.Enabled = True
			.MoveFirst()
			Do While Not .EOF
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol '.Fields(1).Value'. Consider using the GetDefaultMember6 helper method.
				TreeView1.Nodes.Add(, , , .Fields(1).Value, 1, 2)
				.MoveNext()
			Loop
			.MoveFirst()
			TreeView1.Nodes(.AbsolutePosition).EnsureVisible()
			TreeView1.Nodes(.AbsolutePosition).Selected = True
		End With
		load_files()
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		If Text1.Text = "" Then  MsgBox6("Please select a langguage first.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Text1.SetFocus(): Exit Sub
		
		On Error GoTo Err 
		With rs_folder
			'Check if there is no record
			If .RecordCount < 1 Then  MsgBox6("No folder to delete.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
			'Confirm deletion of record
			Dim ans As Short = MsgBox6("Are you sure you want to delete the selected folder?" & ControlChars.CrLf & ControlChars.CrLf & "WARNING:Deleting folder will delete also all files related on it.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Record Delete")
			Me.MousePointer = VBRUN.MousePointerConstants.vbHourglass
			If ans = MsgBoxResult.Yes Then 
				'Delete the record
				cn.Execute("Delete * From tblListFolders Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'")
				.Requery()
				reload_folder()
				MsgBox6("Folder has been successfully deleted.", MsgBoxStyle.Information, "Confirm")
			End If
			ans = 0
			Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		End With
		Exit Sub
Err:
		Call prompt_err(Err)
		Resume Next 

	End Sub

	Private Sub Command3_Click() Handles Command3.Click
		If Text1.Text = "" Then  MsgBox6("Please select a langguage first.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Text1.SetFocus(): Exit Sub
		
		If rs_folder.RecordCount < 1 Then  MsgBox6("No folder to edit.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
		
		Dim strFolder As String = ""
		Dim oldFolder As String = TreeView1.SelectedItem.Text
		
		strFolder = InputBox6("Enter the new name of '" & oldFolder & "' folder:", "Edit Existing Forder")
		
		If strFolder = "" Then  Exit Sub
		Call remove_some_txt(strFolder)
		If LCase(oldFolder) <> LCase(strFolder) Then 
			If if_folder_exist("tblListFolders", "Where FolderName ='" & strFolder & "' and Langguage ='" & Text1.Text & "'", cn) = True Then  Exit Sub
		Else
			MsgBox6("No changes made.", MsgBoxStyle.Information, "Code Library version 1.1")
			Exit Sub
		End If
		
		Dim rs_ed_folder As New ADODB.RecordsetClass
		Call set_rec_getData(rs_ed_folder, cn, "Select * From tblListFolders Where FolderName ='" & oldFolder & "' and Langguage ='" & Text1.Text & "'")
		
		With rs_ed_folder
			If .RecordCount < 1 Then  MsgBox6("There is a changes in record since it was last modified.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
			.Fields(1).Value = strFolder
			.Update()
		End With
		
		MsgBox6("Changes in folder has been successfully saved.", MsgBoxStyle.Information, "Code Library version 1.1")
		
		FRM_UPDATE_REC.seconds = 3
		FRM_UPDATE_REC.Show(VBRUN.FormShowConstants.vbModal)
		
		rs_folder.Requery()
		reload_folder()
		strFolder = ""
		strFolder = ""
	End Sub

	Private Sub Command4_Click() Handles Command4.Click
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		If ListView1.SelectedItem.Text = "" Then  Exit Sub
		
		On Error GoTo Err 
		With rs_files
			'Check if there is no record
			If .RecordCount < 1 Then  MsgBox6("No file to delete.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Exit Sub
			'Confirm deletion of record
			Dim ans As Short = MsgBox6("Are you sure you want to delete the selected file?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirm Record Delete")
			Me.MousePointer = VBRUN.MousePointerConstants.vbHourglass
			If ans = MsgBoxResult.Yes Then 
				'Delete the record
				cn.Execute("Delete * From tblFiles Where FolderNo =" & table_id("tblListFolders", "Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'", cn) & " and Title ='" & ListView1.SelectedItem.Text & "'")
				.Requery()
				reload_files()
				MsgBox6("File has been successfully deleted.", MsgBoxStyle.Information, "Confirm")
			End If
			ans = 0
			Me.MousePointer = VBRUN.MousePointerConstants.vbDefault
		End With
		Exit Sub
Err:
		Call prompt_err(Err)
		Resume Next 

	End Sub

	Private Sub Command5_Click() Handles Command5.Click
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		If ListView1.SelectedItem.Text = "" Then  Exit Sub
		Dim xForm As New Form6
		With xForm
			.f_title = ListView1.SelectedItem.Text
			.f_n = table_id("tblListFolders", "Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'", cn)
			.Show()
		End With
		
	End Sub

	Private Sub Command6_Click() Handles Command6.Click
		If TreeView1.Nodes.Count < 1 Then  Exit Sub
		Dim xForm As New Form3
		With xForm
			.f_n = table_id("tblListFolders", "Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'", cn)
			.Show()
		End With
		
	End Sub

	Private Sub Command7_Click() Handles Command7.Click
		If Text1.Text = "" Then  MsgBox6("Please select a langguage first.", MsgBoxStyle.Exclamation, "Code Library version 1.1"): Text1.SetFocus(): Exit Sub
		Dim strFolder As String = InputBox6("Enter the name of folder you want to create:", "Add New Forder")
		If strFolder = "" Then  Exit Sub
		Call remove_some_txt(strFolder)
		If if_folder_exist("tblListFolders", "Where FolderName ='" & strFolder & "' and Langguage ='" & Text1.Text & "'", cn) = True Then  Exit Sub
		With rs_folder
			.AddNew()
			.Fields(0).Value = get_num("tblListFolders", "FolderNo", cn)
			.Fields(1).Value = strFolder
			.Fields(2).Value = Text1.Text
			.Update()
		End With
		MsgBox6("New folder has been successfully added.", MsgBoxStyle.Information, "Code Library version 1.1")
		FRM_UPDATE_REC.seconds = 3
		FRM_UPDATE_REC.Show(VBRUN.FormShowConstants.vbModal)
		rs_folder.Requery()
		reload_folder()
		strFolder = ""
	End Sub

	Private Sub Command9_Click() Handles Command9.Click
		'On Error Resume Next
		If ListView1.ListItems.Count < 1 Then  Exit Sub
		If ListView1.SelectedItem.Text = "" Then  Exit Sub
		Dim xForm As New Form2
		With xForm
			.sSQL = "Select * From qryFiles Where Title ='" & ListView1.SelectedItem.Text & "' and FolderNo =" & table_id("tblListFolders", "Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'", cn)
			.sTitle = ListView1.SelectedItem.Text
			.Show()
		End With
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
		If App6.PrevInstance = True Then  MsgBox6("Code Library is already running.", MsgBoxStyle.Information, "Code Library version 1.1"): Application.Exit(): End
		
		Me.Show()
		
		frmSplash.Show(VBRUN.FormShowConstants.vbModal)
		Form8.Show(VBRUN.FormShowConstants.vbModal)
		
		'Set the connection
		Call set_conn_getData(cn, App6.Path & "\Storedfile.mdb", True, "codelib!@#")
		'Set the recordset
		Call set_rec_getData(rs_folder, cn, "Select * From tblListFolders Order by FolderName")
		Call set_rec_getData(rs_files, cn, "Select * From qryFiles Order by Title")
		
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		On Error Resume Next 
		Application.Exit(): End
	End Sub

	Private Sub ListView1_DblClick() Handles ListView1.DblClick
		Command9_Click()
	End Sub

	Private Sub ListView1_KeyPress(ByRef KeyAscii As Short) Handles ListView1.KeyPress
		If KeyAscii = 13 Then  Command9_Click()
	End Sub

	Private Sub mnuAbout_Click() Handles mnuAbout.Click
		MsgBox6("Programmer: Philip V. Naparan" & ControlChars.CrLf & "E-mail Address: philipnaparan@yahoo.com" & ControlChars.CrLf & "Website: http://www.naparansoft.cjb.net" & ControlChars.CrLf & ControlChars.CrLf & ControlChars.CrLf & "Note: This project is one of my old files.I just change the old layout" & ControlChars.CrLf & "to make it looks nice.The code of this project is coded when I was" & ControlChars.CrLf & "a beginner in Visual Basic and I still use it until now to store" & ControlChars.CrLf & "some articles and codes.Enjoy this program and have fun coding!" & ControlChars.CrLf & ControlChars.CrLf & ControlChars.CrLf & "BE PROUD TO BE PINOY!", MsgBoxStyle.Information, "About Code Library")
	End Sub

	Private Sub mnuClose_Click() Handles mnuClose.Click
		Unload6(Me)
	End Sub

	Private Sub mnuSec_Click() Handles mnuSec.Click
		Form7.Show(VBRUN.FormShowConstants.vbModal)
	End Sub

	Private Sub Text1_Change() Handles Text1.Change
		rs_folder.Filter = "Langguage ='" & Text1.Text & "'"
		Command7.Enabled = True
		reload_folder()
	End Sub

	Private Sub Text1_DblClick() Handles Text1.DblClick
		Command1_Click()
	End Sub

	Private Sub Text1_GotFocus() Handles Text1.GotFocus
		Call highlight_focus(Text1)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		Command1_Click()
	End Sub
	
	Public Sub load_files()
		If rs_folder.RecordCount < 1 Then  Exit Sub
		rs_files.Filter = "FolderNo =" & table_id("tblListFolders", "Where FolderName ='" & TreeView1.SelectedItem.Text & "' and Langguage ='" & Text1.Text & "'", cn)
		reload_files()
	End Sub

	Private Sub TreeView1_NodeClick(ByVal Node As VB6Node) Handles TreeView1.NodeClick
		load_files()
	End Sub

End Class
