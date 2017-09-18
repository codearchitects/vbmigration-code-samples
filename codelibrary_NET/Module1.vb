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

	Public strLang As VB6TextBox
	
	Public rs_folder As New ADODB.RecordsetClass
	Public rs_files As New ADODB.RecordsetClass
	
	' This wrapper property has been added to preserve As New semantics of rsGetLang variable
	Public Property rsGetLang() As ADODB.Recordset
		Get
			If rsGetLang_InnerField Is Nothing Then rsGetLang_InnerField = New ADODB.RecordsetClass()
			Return rsGetLang_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rsGetLang_InnerField = value
		End Set
	End Property
	
	Private rsGetLang_InnerField As ADODB.Recordset
	' This wrapper property has been added to preserve As New semantics of connGetLang variable
	Public Property connGetLang() As ADODB.Connection
		Get
			If connGetLang_InnerField Is Nothing Then connGetLang_InnerField = New ADODB.ConnectionClass()
			Return connGetLang_InnerField
		End Get
		Set(value As ADODB.Connection)
			connGetLang_InnerField = value
		End Set
	End Property
	
	Private connGetLang_InnerField As ADODB.Connection
	' This wrapper property has been added to preserve As New semantics of cn variable
	Public Property cn() As ADODB.Connection
		Get
			If cn_InnerField Is Nothing Then cn_InnerField = New ADODB.ConnectionClass()
			Return cn_InnerField
		End Get
		Set(value As ADODB.Connection)
			cn_InnerField = value
		End Set
	End Property
	
	Private cn_InnerField As ADODB.Connection

	Public Sub set_conn_getData(ByRef sConnection As ADODB.Connection, ByVal sDataLocation As String, ByVal sHavePassword As Boolean, ByVal sPassword As String)
	' UPGRADE_INFO (#0551): The 'sConnection' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If sHavePassword = True Then 
			sConnection.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataLocation & ";Persist Security Info=False;Jet OLEDB:Database Password=" & sPassword)
		Else
			sConnection.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataLocation & ";Persist Security Info=False")
		End If
	End Sub
	
	Public Sub set_rec_getData(ByRef sRecordset As ADODB.Recordset, ByRef sConnection As ADODB.Connection, ByVal sSQL As String)
	' UPGRADE_INFO (#0551): The 'sRecordset' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sConnection' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		With sRecordset
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			.Open(sSQL, sConnection, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		End With
	End Sub

	Public Sub delete_rec(ByRef sCONN As ADODB.Connection, ByVal sTable As String, ByVal sField As String, ByVal sString As String, ByVal isnumber As Boolean, ByVal snum As Integer)
	' UPGRADE_INFO (#0551): The 'sCONN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If isnumber = True Then 
			sCONN.Execute("Delete * From " & sTable & " Where " & sField & " =" & snum)
		Else
			sCONN.Execute("Delete * From " & sTable & " Where " & sField & " ='" & sString & "'")
		End If
	End Sub
	
	Public Sub centerObj(ByRef sObj1 As Object, ByVal sObj2 As Object)
	' UPGRADE_INFO (#0551): The 'sObj1' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj2.Width'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj1.Width'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj2.Left'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj2.Height'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj1.Height'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sObj2.Top'. Consider using the GetDefaultMember6 helper method.
		sObj1.Move((sObj2.Width - sObj1.Width) / 2 + sObj2.Left, (sObj2.Height - sObj1.Height) / 2 + sObj2.Top)
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
		Dim tmp_listtview As VB6ListItem = sListView.FindItem(sFindText, MSComctlLib.ListFindItemHowConstants.lvwWhole, MSComctlLib.ListFindItemHowConstants.lvwPartial, MSComctlLib.ListFindItemHowConstants.lvwPartial)
		If Not tmp_listtview Is Nothing Then 
			tmp_listtview.EnsureVisible()
			tmp_listtview.Selected = True
		End If
	End Sub
	
	Public Sub prompt_err(ByVal sError As ErrObject)
		MsgBox6(sError.Description & ControlChars.CrLf & ControlChars.CrLf & "Error Number: " & Err.Number & ControlChars.CrLf & ControlChars.CrLf & "*Note: Contact the programmer to learn more about this.", MsgBoxStyle.Exclamation, "Code Library version 1.1")
	End Sub
	
	Public Function is_empty(ByRef sText As Object) As Boolean
	' UPGRADE_INFO (#0551): The 'sText' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sText.Text'. Consider using the GetDefaultMember6 helper method.
		If sText.Text = "" Then 
			is_empty = True
			MsgBox6("The field is required.Please check it!", MsgBoxStyle.Exclamation, "Code Library version 1.1")
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
	
	Public Function if_folder_exist(ByVal sTable As String, ByVal sCondition As String, ByRef sCN As ADODB.Connection) As Boolean
	' UPGRADE_INFO (#0551): The 'sCN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim rs As New ADODB.RecordsetClass
		if_folder_exist = False
		Call set_rec_getData(rs, sCN, "Select * From " & sTable & "  " & sCondition)
		If rs.RecordCount > 0 Then 
			MsgBox6("The folder was already exist. Please check and change it!" & ControlChars.CrLf & ControlChars.CrLf & "Note: Duplication of folders is not allowed in this application.", MsgBoxStyle.Exclamation, "Code Library version 1.1")
			if_folder_exist = True
		End If
		rs = Nothing
	End Function
	
	Public Function if_file_exist(ByVal sTable As String, ByVal sCondition As String, ByRef sCN As ADODB.Connection) As Boolean
	' UPGRADE_INFO (#0551): The 'sCN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim rs As New ADODB.RecordsetClass
		if_file_exist = False
		Call set_rec_getData(rs, sCN, "Select * From " & sTable & "  " & sCondition)
		If rs.RecordCount > 0 Then 
			MsgBox6("The file was already exist. Please check and change it!" & ControlChars.CrLf & ControlChars.CrLf & "Note: Duplication of files is not allowed in this application.", MsgBoxStyle.Exclamation, "Code Library version 1.1")
			if_file_exist = True
		End If
		rs = Nothing
	End Function
	
	Public Function if_exist(ByVal sTable As String, ByVal sField As String, ByRef sEntryField As Object, ByRef sCN As ADODB.Connection) As Boolean
	' UPGRADE_INFO (#0551): The 'sEntryField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sCN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim rs As New ADODB.RecordsetClass
		if_exist = False
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sEntryField.Text'. Consider using the GetDefaultMember6 helper method.
		Call set_rec_getData(rs, sCN, "Select * From " & sTable & " Where " & sField & " ='" & sEntryField.Text & "'")
		If rs.RecordCount > 0 Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sEntryField.Text'. Consider using the GetDefaultMember6 helper method.
			MsgBox6("The updating of entry cannot be done because '" & sEntryField.Text & "' is already" & ControlChars.CrLf & "exist in the record.Please check and change it." & ControlChars.CrLf & ControlChars.CrLf & "Note: Duplication of langguage is not allowed in this application.", MsgBoxStyle.Exclamation, "Code Library version 1.1")
			sEntryField.SetFocus
			if_exist = True
		End If
		rs = Nothing
	End Function
	
	Public Function table_id(ByVal sTable As String, ByVal sCondition As String, ByRef sCN As ADODB.Connection) As Integer
	' UPGRADE_INFO (#0551): The 'sCN' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim rs As New ADODB.RecordsetClass
		Call set_rec_getData(rs, sCN, "Select * From " & sTable & "  " & sCondition)
		If rs.RecordCount > 0 Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields(0).Value'. Consider using the GetDefaultMember6 helper method.
			table_id = rs.Fields(0).Value
		Else
			MsgBox6("There is a changes in record since it was last modified.", MsgBoxStyle.Exclamation, "Code Library version 1.1")
		End If
		rs = Nothing
	End Function
	
	Public Sub remove_some_txt(ByRef sText As String)
		Dim tmp As String = ""
		Dim c As Short
		Dim str As String = ""
		For c = 1 To Len6(sText)
			tmp = Mid(sText, c, 1)
			' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'str' variable as a StringBuilder6 object.
			If Not tmp = "'" Then  str &= tmp
		Next
		sText = str
		tmp = ""
		str = ""
		c = 0
	End Sub
	
	Public Sub highlight_focus(ByRef sText As Control)
	' UPGRADE_INFO (#0551): The 'sText' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		With sText
			CObj(sText).SelStart = 0
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'sText.Text'. Consider using the GetDefaultMember6 helper method.
			CObj(sText).SelLength = Len6(sText.Text)
		End With
	End Sub

End Module
