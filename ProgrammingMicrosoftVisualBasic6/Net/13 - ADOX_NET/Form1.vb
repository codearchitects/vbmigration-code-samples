' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' modify this path to match your directory sistem
	Private Const DB_PATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\biblio.mdb"
	
	Private objs() As Object
	Private objCount As Integer
	
	Private Sub Form_Load() Handles MyBase.Load
		Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_PATH
		'conn = "provider=sqloledb;data source=(local);initial catalog=pubs;Integrated Security=True"
		ReDim objs(100)
		RefreshTreeView(conn)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		TreeView1.Move(0, 0, ScaleWidth / 2, ScaleHeight)
		Picture1.Move(ScaleWidth / 2, 0, ScaleWidth / 2, ScaleWidth)
	End Sub

	Public Sub RefreshTreeView(ByVal conn As String)
		
		'On Error GoTo Refresh_Error
		On Error Resume Next 
		
		' Open the connection.
		Dim cn As New ADODB.ConnectionClass
		cn.ConnectionString = conn
		cn.Open()
		
		' Create the Catalog, and link it to the Connection.
		Dim cat As New ADOX.CatalogClass
		Dim catNode As VB6Node = Nothing
		Dim tbl As ADOX.Table = Nothing
		Dim tblsNode As VB6Node = Nothing
		Dim tblNode As VB6Node = Nothing
		Dim col As ADOX.Column = Nothing
		Dim colsNode As VB6Node = Nothing
		Dim ndx As ADOX.Index = Nothing
		Dim ndxsNode As VB6Node = Nothing
		Dim ndxNode As VB6Node = Nothing
		Dim key As ADOX.Key = Nothing
		Dim keysNode As VB6Node = Nothing
		Dim keyNode As VB6Node = Nothing
		Dim view As ADOX.View = Nothing
		Dim viewsNode As VB6Node = Nothing
		Dim viewNode As VB6Node = Nothing
		Dim proc As ADOX.Procedure = Nothing
		Dim procsNode As VB6Node = Nothing
		Dim procNode As VB6Node = Nothing
		Dim grp As ADOX.Group = Nothing
		Dim grpsNode As VB6Node = Nothing
		Dim grpNode As VB6Node = Nothing
		Dim usr As ADOX.User = Nothing
		Dim usrsNode As VB6Node = Nothing
		Dim usrNode As VB6Node = Nothing
		Dim cmd As ADODB.Command = Nothing
		Dim cmdNode As VB6Node = Nothing
		Dim param As ADODB.Parameter = Nothing
		Dim paramsNode As VB6Node = Nothing
		Dim paramNode As VB6Node = Nothing
		
		' Add the Catalog node.
		cat.ActiveConnection = cn
		
		TreeView1.Nodes.Clear()
		catNode = AddNode(cat, , "CATALOG")
		catNode.Expanded = True
		
		' Add all tables
		tblsNode = AddNode(cat.Tables, catNode, "TABLES")
		If Err.Number Then  GoTo TablesNotSupported
		
		For Each tbl In cat.Tables
			' Add the table to the treeview.
			tblNode = AddNode(tbl, tblsNode)
			
			' Add the Columns collection.
			colsNode = AddNode(tbl.Columns, tblNode, "COLUMNS")
			If Err.Number Then  GoTo ColumnsNotSupported
			
			For Each col In tbl.Columns
				AddNode(col, colsNode)
			Next
			
ColumnsNotSupported:
			Err.Clear()
			
			' Add the Indexes collection.
			ndxsNode = AddNode(tbl.Indexes, tblNode, "INDEXES")
			If Err.Number Then  GoTo IndexesNotSupported
			
			For Each ndx In tbl.Indexes
				ndxNode = AddNode(ndx, ndxsNode)
				
				' Add the Columns collection for this Index object
				colsNode = AddNode(ndx.Columns, ndxNode, "COLUMNS")
				For Each col In ndx.Columns
					AddNode(col, colsNode)
				Next
			Next
			
IndexesNotSupported:
			Err.Clear()
			
			' Add the Keys collection.
			keysNode = AddNode(tbl.Keys, tblNode, "KEYS")
			If Err.Number Then  GoTo KeysNotSupported
			
			For Each key In tbl.Keys
				keyNode = AddNode(key, keysNode)
				
				' Add the Columns collection for this Key object
				colsNode = AddNode(key.Columns, keyNode, "COLUMNS")
				For Each col In key.Columns
					AddNode(col, colsNode)
				Next
			Next
			
KeysNotSupported:
			Err.Clear()
		Next
		
TablesNotSupported:
		Err.Clear()
		
		' Add the Views collection.
		viewsNode = AddNode(cat.Views, catNode, "VIEWS")
		If Err.Number Then  GoTo ViewsNotSupported
		
		For Each view In cat.Views
			viewNode = AddNode(view, viewsNode)
			cmdNode = AddNode(view.Command, viewNode, "COMMAND")
			If view.Command.Parameters.Count Then 
				paramsNode = AddNode(view.Command.Parameters, cmdNode, "PARAMETERS")
				For Each param In view.Command.Parameters
					AddNode(param, paramsNode)
				Next
			End If
		Next
		
ViewsNotSupported:
		Err.Clear()
		
		' Add the Procedures collection.
		procsNode = AddNode(cat.Procedures, catNode, "PROCEDURES")
		If Err.Number Then  GoTo ProceduresNotSupported
		
		For Each proc In cat.Procedures
			procNode = AddNode(proc, procsNode)
			cmdNode = AddNode(proc.Command, procNode, "COMMAND")
			If proc.Command.Parameters.Count Then 
				paramsNode = AddNode(proc.Command.Parameters, cmdNode, "PARAMETERS")
				For Each param In proc.Command.Parameters
					AddNode(param, paramsNode)
				Next
			End If
		Next
		
ProceduresNotSupported:
		Err.Clear()
		
		' Add the Groups collection.
		grpsNode = AddNode(cat.Groups, catNode, "GROUPS")
		If Err.Number Then  GoTo GroupsNotSupported
		
		For Each grp In cat.Groups
			grpNode = AddNode(grp, grpsNode)
			' Add the users in each group.
			usrsNode = AddNode(grpNode, grp.Users, "USERS")
			For Each usr In grp.Users
				AddNode(usr, usrsNode)
			Next
		Next
		
GroupsNotSupported:
		Err.Clear()
		
		' Add the Users collection.
		usrsNode = AddNode(cat.Groups, catNode, "USERS")
		If Err.Number Then  GoTo UsersNotSupported
		
		For Each usr In cat.Users
			usrNode = AddNode(usr, usrsNode)
			' Add the groups for each user.
			grpsNode = AddNode(usrNode, usr.Groups, "GROUPS")
			For Each grp In usr.Groups
				AddNode(grp, grpsNode)
			Next
		Next
		
UsersNotSupported:
		Err.Clear()
		
		'Refresh_Error
		'    MsgBox "Unable to read schema data" & vbCr & vbCr
		' '        & "Error " & Err.Number & " - " & Err.Description, vbExclamation

	End Sub

	Public Function AddNode(ByVal item As Object, Optional ByVal parent As VB6Node = Nothing, Optional ByRef Text As String = "") As VB6Node
		
		' Save the object in the objs() arrayÃ¹
		If IsObject6(item) Then 
			objCount += 1
			If objCount > UBound6(objs) Then 
				ReDim Preserve objs(objCount + 99)
			End If
			objs(objCount) = item
			' Provide a default for the Text label.
			If Text = "" Then  Text = item.Name
		Else
			If Text = "" Then  Text = item
		End If
		
		' Create the Node, stored the array index in its Tag property.
		If parent Is Nothing Then 
			AddNode = TreeView1.Nodes.Add(, , , Text)
		Else
			AddNode = TreeView1.Nodes.Add(parent.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , Text)
		End If
		If IsObject6(item) Then  AddNode.Tag = objCount
	End Function

	Private Sub TreeView1_NodeClick(ByVal Node As VB6Node) Handles TreeView1.NodeClick
		Dim obj As Object = objs(CInt(Node.Tag))
		
		Picture1.Cls()
		
		Select Case TypeName6(obj)
		Case "Catalog"
			ShowProperties(obj, "ActiveConnection")
		Case "Tables", "Columns", "Indexes", "Keys", "Views", "Procedures", "Users", "Groups", "Parameters"
			ShowProperties(obj, "Count")
		Case "Table"
			ShowProperties(obj, "DateCreated", "DateModified", "Type")
		Case "Column"
			Picture1.PrintLine("Attribute = " & ColumnAttribute(obj))
			ShowProperties(obj, "DefinedSize", "Name", "NumericScale", "Precision", "RelatedColumn", "SortOrder")
			Picture1.PrintLine("Type = " & ColumnType(obj))
		Case "Index"
			ShowProperties(obj, "Clustered")
			Picture1.PrintLine("IndexNulls = " & IndexNulls(obj))
			ShowProperties(obj, "Name", "PrimaryKey", "Unique")
		Case "Key"
			Picture1.PrintLine("DeleteRule = " & RuleEnum(obj.DeleteRule))
			ShowProperties(obj, "Name", "RelatedTable")
			Picture1.PrintLine("Type = " & KeyTypeEnum(obj.Type))
			Picture1.PrintLine("UpdateRule = " & RuleEnum(obj.UpdateRule))
		Case "View", "Procedure"
			ShowProperties(obj, "DateCreated", "DateModified", "Name")
		Case "Procedure"
			ShowProperties(obj, "DateCreated", "DateModified", "Name")
		Case "Group", "User"
			ShowProperties(obj, "Name")
		Case "Command"
			ShowProperties(obj, "Name", "CommandText", "CommandTimeout", "Prepared", "State")
			Picture1.PrintLine("CommandType = " & CommandTypeEnum(obj.CommandType))
		Case "Parameter"
			ShowProperties(obj, "Name", "Type", "Attributes", "Direction", "NumericScale", "Precision", "Size")
		End Select
	End Sub

	Public Sub ShowProperties(ByVal obj As Object, ByVal ParamArray propNames() As Object)
		Dim i As Integer
		
		On Error Resume Next 
		
		For i = LBound6(propNames) To UBound6(propNames)
			Picture1.Print(propNames(i) & " = ")
			Picture1.PrintLine(CallByName(obj, propNames(i), CallType.Get))
			If Err.Number Then 
				Picture1.PrintLine("<" & Err.Description & ">")
				Err.Clear()
			End If
		Next
		
	End Sub

	Public Function ColumnAttribute(ByVal col As ADOX.Column) As String
		Dim result As String = ""
		
		On Error GoTo Error_Handler 
		
		If col.Attributes And ADOX.ColumnAttributesEnum.adColFixed Then 
			result = " Or adColFixed"
		End If
		If col.Attributes And ADOX.ColumnAttributesEnum.adColNullable Then 
			result &= " Or adColNullable"
		End If
		Return Mid(result, 5)
		
Error_Handler:
		Return "<" & Err.Description & ">"
	End Function

	Public Function ColumnType(ByVal col As ADOX.Column) As String
		On Error GoTo ColumnType_Error 
		Select Case col.Type
		Case ADODB.DataTypeEnum.adBigInt: Return "adBigInt"
		Case ADODB.DataTypeEnum.adBinary: Return "adBinary"
		Case ADODB.DataTypeEnum.adBoolean: Return "adBoolean"
		Case ADODB.DataTypeEnum.adBSTR: Return "adBSTR"
		Case ADODB.DataTypeEnum.adChapter: Return "adChapter"
		Case ADODB.DataTypeEnum.adChar: Return "adChar"
		Case ADODB.DataTypeEnum.adCurrency: Return "adCurrency"
		Case ADODB.DataTypeEnum.adDate: Return "adDate"
		Case ADODB.DataTypeEnum.adDBDate: Return "adDBDate"
			'--## ParseMode Remarks, 1   ' Not necessary
		Case ADODB_DataTypeEnum_adDBFileTime: Return "adDBFileTime"
		Case ADODB.DataTypeEnum.adDBTime: Return "adDBTime"
		Case ADODB.DataTypeEnum.adDBTimeStamp: Return "adDBTimeStamp"
		Case ADODB.DataTypeEnum.adDecimal: Return "adDecimal"
		Case ADODB.DataTypeEnum.adDouble: Return "adDouble"
		Case ADODB.DataTypeEnum.adEmpty: Return "adEmpty"
		Case ADODB.DataTypeEnum.adError: Return "adError"
		Case ADODB.DataTypeEnum.adFileTime: Return "adFileTime"
		Case ADODB.DataTypeEnum.adGUID: Return "adGUID"
		Case ADODB.DataTypeEnum.adIDispatch: Return "adIDispatch"
		Case ADODB.DataTypeEnum.adInteger: Return "adInteger"
		Case ADODB.DataTypeEnum.adIUnknown: Return "adIUnknown"
		Case ADODB.DataTypeEnum.adLongVarBinary: Return "adLongVarBinary"
		Case ADODB.DataTypeEnum.adLongVarChar: Return "adLongVarChar"
		Case ADODB.DataTypeEnum.adLongVarWChar: Return "adLongVarWChar"
		Case ADODB.DataTypeEnum.adNumeric: Return "adNumeric"
		Case ADODB.DataTypeEnum.adPropVariant: Return "adPropVariant"
		Case ADODB.DataTypeEnum.adSingle: Return "adSingle"
		Case ADODB.DataTypeEnum.adSmallInt: Return "adSmallInt"
		Case ADODB.DataTypeEnum.adTinyInt: Return "adTinyInt"
		Case ADODB.DataTypeEnum.adUnsignedBigInt: Return "adUnsignedBigInt"
		Case ADODB.DataTypeEnum.adUnsignedInt: Return "adUnsignedInt"
		Case ADODB.DataTypeEnum.adUnsignedSmallInt: Return "adUnsignedSmallInt"
		Case ADODB.DataTypeEnum.adUnsignedTinyInt: Return "adUnsignedTinyInt"
		Case ADODB.DataTypeEnum.adUserDefined: Return "adUserDefined"
		Case ADODB.DataTypeEnum.adVarBinary: Return "adVarBinary"
		Case ADODB.DataTypeEnum.adVarChar: Return "adVarChar"
		Case ADODB.DataTypeEnum.adVariant: Return "adVariant"
		Case ADODB.DataTypeEnum.adVarNumeric: Return "adVarNumeric"
		Case ADODB.DataTypeEnum.adVarWChar: Return "adVarWChar"
		Case ADODB.DataTypeEnum.adWChar: Return "adWChar"
		Case Else: Return "<unknown>"
		End Select
		Exit Function
		
ColumnType_Error:
		Return "<" & Err.Description & ">"
	End Function

	Public Function IndexNulls(ByVal ndx As ADOX.Index) As String
		Dim result As String = ""
		
		If ndx.IndexNulls And ADOX.AllowNullsEnum.adIndexNullsDisallow Then 
			result = " Or adIndexNullsDisallow"
		End If
		If ndx.IndexNulls And ADOX.AllowNullsEnum.adIndexNullsIgnore Then 
			result &= " Or adIndexNullsIgnore"
		End If
		If ndx.IndexNulls And ADOX.AllowNullsEnum.adIndexNullsIgnoreAny Then 
			result &= " Or adIndexNullsIgnoreAny"
		End If
		If Len6(result) Then 
			Return Mid(result, 5)
		Else
			Return "adIndexNullsAllow"
		End If
	End Function

	Public Function RuleEnum(ByVal value As Integer) As String
		Select Case value
		Case ADOX.RuleEnum.adRINone: Return "adRINone"
		Case ADOX.RuleEnum.adRICascade: Return "adRICascade"
		Case ADOX.RuleEnum.adRISetNull: Return "adRISetNull"
		Case ADOX.RuleEnum.adRISetDefault: Return "adRISetDefault"
		Case Else: Return "<unknown>"
		End Select
	End Function

	Public Function KeyTypeEnum(ByVal value As Integer) As String
		Select Case value
		Case ADOX.KeyTypeEnum.adKeyPrimary: Return "adKeyPrimary"
		Case ADOX.KeyTypeEnum.adKeyForeign: Return "adKeyForeign"
		Case ADOX.KeyTypeEnum.adKeyUnique: Return "adKeyUnique"
		Case Else: Return "<unknown>"
		End Select
	End Function

	Public Function CommandTypeEnum(ByVal value As Integer) As String
		Select Case value
		Case ADODB.CommandTypeEnum.adCmdFile: Return "adCmdFile"
		Case ADODB.CommandTypeEnum.adCmdStoredProc: Return "adCmdStoredProc"
		Case ADODB.CommandTypeEnum.adCmdTable: Return "adCmdTable"
		Case ADODB.CommandTypeEnum.adCmdTableDirect: Return "adCmdTableDirect"
		Case ADODB.CommandTypeEnum.adCmdText: Return "adCmdText"
		Case ADODB.CommandTypeEnum.adCmdUnknown: Return "adCmdUnknown"
		Case Else: Return "<unknown>"
		End Select
	End Function

End Class
