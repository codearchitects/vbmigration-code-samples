' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------
	
	Public Sub use_pos(ByRef sForm As VB6Form)
	' UPGRADE_INFO (#0551): The 'sForm' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		' UPGRADE_INFO (#0561): The 't' symbol was defined without an explicit "As" clause.
		Dim t As Object = Nothing
		Dim l As String = ""
		FileOpen6(1, App6.Path & "\Settings\" & sForm.Name & ".pos", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		FileInput6(1, t)
		FileInput6(1, l)
		FileClose6(1)
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 't'. Consider using the SetDefaultMember6 helper method.
		t = Trim(t)
		l = Trim(l)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 't'. Consider using the GetDefaultMember6 helper method.
		sForm.Top = Val(t)
		sForm.Left = Val(l)
		'-------------------------
		'Clear variables
		'-------------------------
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 't'. Consider using the SetDefaultMember6 helper method.
		t = ""
		l = ""
	End Sub
	
	Public Sub save_pos(ByVal sForm As VB6Form)
		On Error Resume Next 
		Call create_save_setting_dir()
		FileOpen6(1, App6.Path & "\Settings\" & sForm.Name & ".pos", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		FilePrintLine6(1, sForm.Top)
		FilePrintLine6(1, sForm.Left)
		FileClose6(1)
	End Sub
	
	Public Sub use_control_vis(ByRef sControl As Object)
	' UPGRADE_INFO (#0561): The 'sControl' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'sControl' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		Dim t As String = ""
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Name'. Consider using the GetDefaultMember6 helper method.
		FileOpen6(1, App6.Path & "\Settings\" & sControl.Name & ".vis", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		FileInput6(1, t)
		FileClose6(1)
		t = Trim(t)
		sControl.Visible = t
		'-------------------------
		'Clear variables
		'-------------------------
		t = ""
	End Sub
	
	Public Sub save_control_vis(ByVal sControl As Object)
	' UPGRADE_INFO (#0561): The 'sControl' symbol was defined without an explicit "As" clause.
		On Error Resume Next 
		Call create_save_setting_dir()
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Name'. Consider using the GetDefaultMember6 helper method.
		FileOpen6(1, App6.Path & "\Settings\" & sControl.Name & ".vis", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Visible'. Consider using the GetDefaultMember6 helper method.
		FilePrintLine6(1, sControl.Visible)
		FileClose6(1)
	End Sub
	
	Public Sub use_control_pos(ByRef sControl As Object)
	' UPGRADE_INFO (#0561): The 'sControl' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'sControl' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error Resume Next 
		Dim t As String = ""
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Name'. Consider using the GetDefaultMember6 helper method.
		FileOpen6(1, App6.Path & "\Settings\" & sControl.Name & ".pos", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		FileInput6(1, t)
		FileClose6(1)
		t = Trim(t)
		sControl.Align = Val(t)
		'-------------------------
		'Clear variables
		'-------------------------
		t = ""
	End Sub
	
	Public Sub save_control_pos(ByVal sControl As Object)
	' UPGRADE_INFO (#0561): The 'sControl' symbol was defined without an explicit "As" clause.
		On Error Resume Next 
		Call create_save_setting_dir()
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Name'. Consider using the GetDefaultMember6 helper method.
		FileOpen6(1, App6.Path & "\Settings\" & sControl.Name & ".pos", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sControl.Align'. Consider using the GetDefaultMember6 helper method.
		FilePrintLine6(1, sControl.Align)
		FileClose6(1)
	End Sub
	
	Private Sub create_save_setting_dir()
		On Error Resume Next 
		MkDir((App6.Path & "\Settings"))
	End Sub
	
	Public Sub FillListView(ByRef sListView As VB6ListView, ByRef sRecordSource As ADODB.Recordset, ByVal sNumOfFields As Byte, ByVal sNumIco As Byte, ByVal with_num As Boolean, ByVal show_first_rec As Boolean)
	' UPGRADE_INFO (#0551): The 'sListView' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sRecordSource' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim x As Object = Nothing '|Optional to be declare as variant|
		Dim i As Byte
		On Error Resume Next 
		sRecordSource.MoveFirst()
		sListView.ListItems.Clear()
		Do While Not sRecordSource.EOF
			If with_num = True Then 
				x = sListView.ListItems.Add(, , sRecordSource.AbsolutePosition, sNumIco, sNumIco)
			Else
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sRecordSource.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
				x = sListView.ListItems.Add(, , sRecordSource.Fields(0).Value, sNumIco, sNumIco)
			End If
			For i = 1 To sNumOfFields - 1
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sRecordSource.Fields(Val(i)).Value'. Consider using the GetDefaultMember6 helper method.
				If Not sRecordSource.Fields(Val(i)).Value = "" Then 
					If show_first_rec = True Then 
						x.SubItems(i) = sRecordSource.Fields(Val(i) - 1).Value
					Else
						x.SubItems(i) = sRecordSource.Fields(Val(i)).Value
					End If
				End If
			Next
			sRecordSource.MoveNext()
		Loop
		i = 0
		x = Nothing
	End Sub
	
	Public Sub search_in_listview(ByRef sListView As VB6ListView, ByVal sFindText As String)
	' UPGRADE_INFO (#0551): The 'sListView' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim tmp_listtview As VB6ListItem = sListView.FindItem(sFindText, MSComctlLib.ListFindItemWhereConstants.lvwSubItem + MSComctlLib.ListFindItemWhereConstants.lvwText, MSComctlLib.ListFindItemHowConstants.lvwPartial, MSComctlLib.ListFindItemHowConstants.lvwPartial)
		If Not tmp_listtview Is Nothing Then 
			tmp_listtview.EnsureVisible()
			tmp_listtview.Selected = True
		End If
	End Sub
	
	Public Sub highlight_focus(ByRef sText As VB6TextBox)
	' UPGRADE_INFO (#0551): The 'sText' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		With sText
			.SelStart = 0
			.SelLength = Len6(sText.Text)
		End With
	End Sub
	
	Public Sub prompt_err(ByVal sErrorDescription As String)
		MsgBox6(sErrorDescription & ControlChars.CrLf & ControlChars.CrLf & "*Note: Contact the programmer to learn more about this.", MsgBoxStyle.Exclamation, "CSRS version 1")
	End Sub

	Public Sub delete_rec(ByRef sCONN As ADODB.Connection, ByVal sTable As String, ByVal sField As String, ByVal sString As String, ByVal isnumber As Boolean, ByVal snum As Integer)
	' UPGRADE_INFO (#0551): The 'sCONN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If isnumber = True Then 
			sCONN.Execute("Delete * From " & sTable & " Where " & sField & " =" & snum)
		Else
			sCONN.Execute("Delete * From " & sTable & " Where " & sField & " ='" & sString & "'")
		End If
	End Sub
	
	Public Function is_empty(ByRef sText As Object) As Boolean
	' UPGRADE_INFO (#0551): The 'sText' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sText.Text'. Consider using the GetDefaultMember6 helper method.
		If sText.Text = "" Then 
			is_empty = True
			MsgBox6("The field is required.Please check it!", MsgBoxStyle.Exclamation, "CSRS version 1")
			sText.SetFocus
		Else
			Return False
		End If
	End Function
	
	Public Function get_num(ByVal sTable As String, ByVal sField As String, ByRef sCN As ADODB.Connection) As Integer
	' UPGRADE_INFO (#0551): The 'sCN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error GoTo Err 
		Dim rs As New ADODB.RecordsetClass
		rs.Open("SELECT Max(" & sTable & "." & sField & ") AS [Number] From " & sTable & " ORDER BY Max(" & sTable & "." & sField & ") DESC", sCN, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
		get_num = rs.Fields(0).Value + 1
		
		sTable = ""
		sField = ""
		rs = Nothing
		Exit Function
Err:
		'---------------------------------
		'Error when incounter a null value
		'---------------------------------
		If Err.Number = 94 Then  get_num = 1: Resume Next 
	End Function
	
	Public Function if_exist(ByVal sTable As String, ByVal sField As String, ByRef sEntryField As Object) As Boolean
	' UPGRADE_INFO (#0551): The 'sEntryField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim rs As New ADODB.RecordsetClass
		if_exist = False
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sEntryField.Text'. Consider using the GetDefaultMember6 helper method.
		Call set_rec_getData(rs, cn, "Select * From " & sTable & " Where " & sField & " ='" & sEntryField.Text & "'")
		If rs.RecordCount > 0 Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sEntryField.Text'. Consider using the GetDefaultMember6 helper method.
			MsgBox6("The adding of new entry cannot be done because '" & sEntryField.Text & "' is already" & ControlChars.CrLf & "exist in the record.Please check and change it." & ControlChars.CrLf & ControlChars.CrLf & "Note: Duplication of entries is not allowed in this form.", MsgBoxStyle.Exclamation, "CSRS version 1")
			sEntryField.SetFocus
			if_exist = True
		End If
		rs = Nothing
	End Function
	
	Public Sub centerForm(ByRef sForm As VB6Form, ByVal sHeight As Short, ByVal sWidth As Short)
	' UPGRADE_INFO (#0551): The 'sForm' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		sForm.Move((sWidth - sForm.Width) / 2, (sHeight - sForm.Height) / 2)
	End Sub

End Module
