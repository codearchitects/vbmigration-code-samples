' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub chkSystem_Click() Handles chkSystem.Click
		If TreeView1.Nodes.Count > 1 Then 
			' the control already contains something
			ShowDatabaseStructure(TreeView1.Nodes(1).Text, TreeView1, chkSystem.Value)
		End If
	End Sub

	Private Sub cmdBrowse_Click() Handles cmdBrowse.Click
		On Error Resume Next 
		With CommonDialog1
			.CancelError = True
			.Filter = "All files|*.*|Jet Databases (*.mdb)|*.mdb"
			.FilterIndex = 2
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
			.ShowOpen()
			If Err.Number = 0 Then 
				ShowDatabaseStructure(.FileName, TreeView1, chkSystem.Value)
				If Err.Number Then 
					MsgBox6("Unable to read database structure" & ControlChars.Cr & "Error: " & Err.Description, MsgBoxStyle.Exclamation)
				End If
			End If
		End With
	End Sub

	Public Sub ShowDatabaseStructure(ByRef MdbFile As String, ByRef TV As VB6TreeView, ByVal ShowSystemTables As Boolean)
	' UPGRADE_INFO (#0551): The 'MdbFile' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'TV' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim db As DAO.Database = Nothing
		Dim td As DAO.TableDef = Nothing
		Dim fld As DAO.Field = Nothing
		Dim nd As VB6Node = Nothing
		Dim nd2 As VB6Node = Nothing
		
		' clear the current contents of the TreeView control
		TV.Nodes.Clear()
		' open the database
		db = DAO_DBEngine_DefInstance.OpenDatabase(MdbFile)
		'Set db = DBEngine.OpenDatabase(MdbFile)
		'Set db = OpenDatabase '(MdbFile)
		
		' add the root node, then expand it to show the tables
		nd = TV.Nodes.Add(, , "Root", db.Name, "Database")
		nd.Tag = DatabaseInfo(db)
		nd.Expanded = True
		
		' explore all the tables in the database
		For Each td In db.TableDefs
			' discard system tables, if user isn't interested in them
			If (td.Attributes And DAO.TableDefAttributeEnum.dbSystemObject) = 0 Or ShowSystemTables Then 
				' add the table under the Root object
				nd = TV.Nodes.Add("Root", MSComctlLib.TreeRelationshipConstants.tvwChild, , td.Name, "Table")
				nd.Tag = TableDefInfo(td)
				' now add all the fields
				For Each fld In td.Fields
					nd2 = TV.Nodes.Add(nd.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , fld.Name, "Field")
					nd2.Tag = FieldInfo(fld)
				Next
			End If
		Next
		db.Close()
	End Sub

	Public Function DatabaseInfo(ByRef db As DAO.Database) As String
	' UPGRADE_INFO (#0551): The 'db' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' return textual information about a Database object
		Dim res As String = res & "Name = " & db.Name & ControlChars.CrLf
		res = res & "Version = " & db.Version & ControlChars.CrLf
		res = res & "Updatable = " & db.Updatable & ControlChars.CrLf
		res = res & "Connect = " & db.Connect & ControlChars.CrLf
		Return res
	End Function

	Public Function TableDefInfo(ByRef td As DAO.TableDef) As String
	' UPGRADE_INFO (#0551): The 'td' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' return textual information about a TableDef object
		Dim res As String = res & "Name = " & td.Name & ControlChars.CrLf
		res = res & "DateCreated = " & td.DateCreated & ControlChars.CrLf
		res = res & "LastUpdated = " & td.LastUpdated & ControlChars.CrLf
		res = res & "RecordCount = " & td.RecordCount & ControlChars.CrLf
		res = res & "Updatable = " & td.Updatable & ControlChars.CrLf
		Return res
	End Function

	Public Function FieldInfo(ByRef fld As DAO.Field) As String
	' UPGRADE_INFO (#0551): The 'fld' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' return textual information about a Field object
		Dim res As String = res & "Name = " & fld.Name & ControlChars.CrLf
		res = res & "Type = " & FieldTypeDesc(fld.Type) & ControlChars.CrLf
		res = res & "Size = " & fld.Size & ControlChars.CrLf
		res = res & "Required = " & fld.Required & ControlChars.CrLf
		res = res & "AllowZeroLength = " & fld.AllowZeroLength & ControlChars.CrLf
		res = res & "OrdinalPosition = " & fld.OrdinalPosition & ControlChars.CrLf
		res = res & "AutoIncrField  = " & CBool(fld.Attributes And DAO.FieldAttributeEnum.dbAutoIncrField) & ControlChars.CrLf
		Return res
	End Function

	Public Function FieldTypeDesc(ByVal value As DAO.DataTypeEnum) As String
		Select Case value
		Case DAO.DataTypeEnum.dbBigInt: Return "dbBigInt"
		Case DAO.DataTypeEnum.dbBinary: Return "dbBinary"
		Case DAO.DataTypeEnum.dbBoolean: Return "dbBoolean"
		Case DAO.DataTypeEnum.dbByte: Return "dbByte"
		Case DAO.DataTypeEnum.dbChar: Return "dbChar"
		Case DAO.DataTypeEnum.dbCurrency: Return "dbCurrency"
		Case DAO.DataTypeEnum.dbDate: Return "dbDate"
		Case DAO.DataTypeEnum.dbDecimal: Return "dbDecimal"
		Case DAO.DataTypeEnum.dbDouble: Return "dbDouble"
		Case DAO.DataTypeEnum.dbInteger: Return "dbInteger"
		Case DAO.DataTypeEnum.dbGUID: Return "dbGUID"
		Case DAO.DataTypeEnum.dbLong: Return "dbLong"
		Case DAO.DataTypeEnum.dbLongBinary: Return "dbLongBinary"
		Case DAO.DataTypeEnum.dbMemo: Return "dbMemo"
		Case DAO.DataTypeEnum.dbNumeric: Return "dbNumeric"
		Case DAO.DataTypeEnum.dbSingle: Return "dbSingle"
		Case DAO.DataTypeEnum.dbText: Return "dbText"
		Case DAO.DataTypeEnum.dbTime: Return "dbTime"
		Case DAO.DataTypeEnum.dbTimeStamp: Return "dbTimeStamp"
		Case DAO.DataTypeEnum.dbVarBinary: Return "dbVarBinary"
		Case Else: Return "(unknown)"
		End Select
		
	End Function

	Private Sub TreeView1_NodeClick(ByVal Node As VB6Node) Handles TreeView1.NodeClick
		' info() is an array of strings that hold nodes' data
		lblData.Caption = Node.Tag
	End Sub

End Class
