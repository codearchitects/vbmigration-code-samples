' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmClassDemo

	'Information :::::::::::::::::::::::::::::::::::::::::::::::'
	'Before using this application, you must reference one of   '
	'Microsoft's ActiveX Data Object Library DLL's. I used v2.8 '
	'but I'm sure most of the older versions will work as well. '
	'To reference it, click "Project" > "References" and find it'
	'there. Enjoy the free source code, this demo is fully comm-'
	'ented. Also please vote or leave comments on the PSC page. '
	'::::::::::::::::::::::::::::::::::: Thanks for Downloading '

	Private WithEvents dns As ezDatabase 'Bind ezDatabase events to dns
	' UPGRADE_INFO (#0501): The 'Export' member isn't used anywhere in current application.
	Private WithEvents Export As ezExport
	Private bType As Byte
	
	Private Sub cboField_Click() Handles cboField.Click
		'Enable the buttons.
		cmdFindFirst.Enabled = True
		cmdFindNext.Enabled = True
		cmdFindPrev.Enabled = True
		cmdFindLast.Enabled = True
		cmdFindAll.Enabled = True
	End Sub

	Private Sub cboField_KeyPress(ByRef KeyAscii As Short) Handles cboField.KeyPress
		KeyAscii = 0
	End Sub

	Private Sub cmdAdd_Click() Handles cmdAdd.Click
		Dim bCategory As Byte 'Categorize Domain Name so we know which table to add record
		If txtField(0).Text = "" Or txtField(1).Text = "" Then 
			MsgBox6("Fields must contain data.")
			If txtField(0).Text = "" Then  txtField(0).SetFocus() Else txtField(1).SetFocus()
		Else
			
			bCategory = (Asc(LCase(txtField(0).Text)) - 97) \ 4
			If bCategory > 4 Then  bCategory = 4
			
			'tblNumber = Table Number to Add Record
			'objArray = Object Array to retrieve field information from
			'iStart = Starting index of array to retrieve field information from (Optional)
			dns.AddNew(bCategory, txtField) 'Add the record
		End If
	End Sub

	Private Sub cmdBOF_Click() Handles cmdBOF.Click
		'Property Access: Read Only
		SetOptions(3) 'Set Options (Request Type)
		MsgBox6(dns.BOF(bType)) 'Is database BOF?
	End Sub

	Private Sub cmdCase_Click() Handles cmdCase.Click
		'Property Access: Read/Write
		MsgBox6(dns.CaseSensitive) 'Returns True/False Boolean
	End Sub

	Private Sub cmdClear_Click() Handles cmdClear.Click
		lstResults.Clear()
	End Sub

	Private Sub cmdConnect_Click() Handles cmdConnect.Click
		If cmdConnect.Caption = "Connect To Database" Then 
			'Set Database Location
			dns.dbLocation = App6.Path & "\" & "DNSdb.mdb"
			
			'Add tables (recordsets)
			dns.AddTable("AD") 'Each AddTable call creates a Recordset used to
			dns.AddTable("EH") 'query information from the appropriate table.
			dns.AddTable("IL")
			dns.AddTable("MP")
			dns.AddTable("QZ")
			
			'Make Connections
			dns.Expose()
			cmdConnect.Caption = "Disconnect From Database"
		Else
			'Close Connections
			dns.Dispose_VB6()
			cmdConnect.Caption = "Connect To Database"
		End If
	End Sub

	Private Sub cmdConnected_Click() Handles cmdConnected.Click
		'Property Access: Read Only
		MsgBox6(dns.Connected) 'Returns True/False Boolean
	End Sub

	Private Sub cmdCTName_Click() Handles cmdCTName.Click
		'Property Access: Read Only
		MsgBox6(dns.CurrentTable) 'Returns String Value for Current Table Name
	End Sub

	Private Sub cmdCTNumber_Click() Handles cmdCTNumber.Click
		'Property Access: Read Only
		MsgBox6(dns.TableNumber) 'Returns Long Value for Current Table Number
	End Sub

	Private Sub cmdDatabase_Click() Handles cmdDatabase.Click
		'Property Access: Read/Write
		MsgBox6(dns.dbLocation) 'Returns String for location of .mdb file
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		If MsgBox6("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then 
			dns.Delete() 'Delete current record
		Else
			'Do nothing
		End If
		
	End Sub

	Private Sub cmdEOF_Click() Handles cmdEOF.Click
		'Property Access: Read Only
		SetOptions(3) 'Set Options (Request Type)
		MsgBox6(dns.EOF(bType)) 'Is database BOF?
	End Sub

	Private Sub cmdExport_Click() Handles cmdExport.Click
		SetOptions(3)
		'Export Current Table or Export All Tables to HTML
		If bType = 1 Then 
			'The properties of the Export.ToHTML Function are just like those of HTML
			'Set accordingly or leave them as default.
			dns.Export.ToHTML(App6.Path & "\Exported HTML\" & "TableExport.html", 0, , "6D0F0F", "981515", 1, 1, True, "6D0F0F")
		Else
			'Table Number is not required in this case as all tables are being exported to HTML.
			dns.Export.AllToHTML(App6.Path & "\Exported HTML\" & "TableExport_.html", , "6D0F0F", "981515", 1, 1, True, "6D0F0F")
		End If
	End Sub

	Private Sub cmdFindAll_Click() Handles cmdFindAll.Click
		SetOptions(1) 'Set Options (Case Sensitive/Request Type)
		dns.FindAll(cboField.Text, txtQuery.Text, bType)
	End Sub

	Private Sub cmdFindFirst_Click() Handles cmdFindFirst.Click
		SetOptions(1) 'Set Options (Case Sensitive/Request Type)
		'nField = Field to search
		'sQuery = Query to find
		'RequestType = Search either current table or all tables
		dns.Find(cboField.Text, txtQuery.Text, bType) 'Find is equivalent to FindFirst
	End Sub

	Private Sub cmdFindLast_Click() Handles cmdFindLast.Click
		SetOptions(1) 'Set Options (Case Sensitive/Request Type)
		dns.FindLast(cboField.Text, txtQuery.Text, bType)
	End Sub

	Private Sub cmdFindNext_Click() Handles cmdFindNext.Click
		SetOptions(1) 'Set Options (Case Sensitive/Request Type)
		dns.FindNext() 'Find Next - Find First/Last must be used before Find Next will work.
		UpdateInfo()
	End Sub

	Private Sub cmdFindPrev_Click() Handles cmdFindPrev.Click
		SetOptions(1) 'Set Options (Case Sensitive/Request Type)
		dns.FindPrev() 'Find Previous - Find First/Last must be used before Find Next will work.
		UpdateInfo()
	End Sub

	Private Sub cmdFirstTable_Click() Handles cmdFirstTable.Click
		dns.FirstRecordset() 'Move to first table/recordset
	End Sub

	Private Sub cmdLast_Click() Handles cmdLast.Click
		MsgBox6(dns.LastQuery)
	End Sub

	Private Sub cmdLastTable_Click() Handles cmdLastTable.Click
		dns.LastRecordset() 'Move to Last Recordset/Table
	End Sub

	Private Sub cmdMoveFirst_Click() Handles cmdMoveFirst.Click
		SetOptions(2) 'Set options for Move
		dns.MoveFirst(bType) 'MoveFirst in Current or All Tables? All by default
	End Sub

	Private Sub cmdMoveLast_Click() Handles cmdMoveLast.Click
		SetOptions(2) 'Set options for Move
		dns.MoveLast(bType) 'MoveLast in Current or All Tables? All by default
	End Sub

	Private Sub cmdMoveNext_Click() Handles cmdMoveNext.Click
		SetOptions(2) 'Set options for Move
		dns.MoveNext() 'Can only work if MoveFirst/MoveLast is first used.
		UpdateInfo()
	End Sub

	Private Sub cmdMovePrev_Click() Handles cmdMovePrev.Click
		dns.MovePrev() 'Can only work if MoveFirst/MoveLast is first used.
		UpdateInfo()
	End Sub

	Private Sub cmdNextTable_Click() Handles cmdNextTable.Click
		dns.NextRecordset() 'Moves to next table/recordset
	End Sub

	Private Sub cmdPassword_Click() Handles cmdPassword.Click
		'Property Access: Read/Write
		MsgBox6(dns.Password) 'Returns String Value for Password
	End Sub

	Private Sub cmdPrevTable_Click() Handles cmdPrevTable.Click
		dns.PreviousRecordset() 'Move to Previous Recordset/Table
	End Sub

	Private Sub cmdRecordCount_Click() Handles cmdRecordCount.Click
		'Property Access: Read Only
		SetOptions(3) 'Set Options (Request Type)
		
		If bType = 1 Then 
			MsgBox6(dns.RecordCount(RequestType.rtCurrentTable)) 'RecordCount of Current Table
		Else
			MsgBox6(dns.RecordCount(RequestType.rtAllTables)) 'RecordCount of All Tables
		End If
	End Sub

	Private Sub cmdRequest_Click() Handles cmdRequest.Click
		'Property Access: Read Only
		MsgBox6(dns.RequestType) 'Returns Long Value for Last Request Type
	End Sub

	Private Sub cmdResult_Click() Handles cmdResult.Click
		'FindMarker property determines whether the find function was successful in finding
		'a result. Returns a true/false boolean.
		
		MsgBox6(dns.FindMarker)
	End Sub

	Private Sub cmdTable_Click() Handles cmdTable.Click
		'Property Access: Read Only
		MsgBox6(dns.TableCount) 'Returns Long Value expressing recordset/table count
	End Sub

	Private Sub cmdTableName_Click() Handles cmdTableName.Click
		'Property Access: Read Only
		MsgBox6(dns.TableName(txtTableNum.Text)) 'Returns String Value for Table Name
		'by Table Number
	End Sub

	Private Sub cmdUpdate_Click() Handles cmdUpdate.Click
		'rsField = Field to Update
		'rsNewValue = Updated Value for Field
		dns.Update("Domain", txtDomain.Text)
		dns.Update("DomainIP", txtIP.Text)
	End Sub

	Private Sub cmdUsername_Click() Handles cmdUsername.Click
		'Property Access: Read/Write
		MsgBox6(dns.Username) 'Returns String Value for Username
	End Sub

	Private Sub dns_Added() Handles dns.Added
		'Event Triggered When: AddNew function is successfully used.
		MsgBox6("Record Added!")
	End Sub

	Private Sub dns_Connect() Handles dns.Connect
		'Event Triggered When: Connected to Database
		MsgBox6("Successfully Connected to Database")
	End Sub

	Private Sub dns_ConnectionError(ByRef Description As String) Handles dns.ConnectionError
		'Event Triggered When: Could not connect to Database.
		MsgBox6(Description)
	End Sub

	Private Sub dns_Deleted() Handles dns.Deleted
		'Event Triggered When: Record is successfully deleted.
		MsgBox6("Record Deleted!")
	End Sub

	Private Sub dns_Disconnect() Handles dns.Disconnect
		'Event Triggered When: Disconnected from Database.
		MsgBox6("Thanks for testing out my ezDatabase Class!")
	End Sub

	Private Sub dns_Error(ByRef Description As String) Handles dns.Error
		'Event Triggered When: An unspecific/uncommon error has occured.
		MsgBox6(Description)
	End Sub

	Private Sub dns_FieldsChanged(ByRef QueryInfo As String) Handles dns.FieldsChanged
		'Event Triggered When: Find/Move/Add/Delete/Update functions are used.
		If VB.Left(QueryInfo, 4) = "Find" Then  'If Fields Changed by Find Function,
			If cboField.Text = "Domain" Then  'Add to List
				lstResults.AddItem(dns.Field("DomainIP"))
			Else
				lstResults.AddItem(dns.Field("Domain"))
			End If
		ElseIf VB.Left(QueryInfo, 4) = "Move" Then  'If Fields Changed by Move Function,
			txtDomain.Text = dns.Field("Domain") 'Update TextBoxes
			txtIP.Text = dns.Field("DomainIP")
			lblTableName.Caption = "Current Table: " & dns.CurrentTable 'Update Table Name
		End If
		UpdateInfo()
	End Sub

	Private Sub dns_FindNotUsed() Handles dns.FindNotUsed
		'Event Triggered When: Find Next/Find Previous is used but FindFirst/FindLast have
		'not yet been used.
		MsgBox6("Find First/Last Not yet used!")
	End Sub

	Private Sub dns_InvalidParameter(ByRef Description As String) Handles dns.InvalidParameter
		'Event Triggered When: An Invalid Parameter was passed to any of the functions.
		MsgBox6(Description)
	End Sub

	Private Sub dns_QueryNotFound(ByRef Query As String) Handles dns.QueryNotFound
		'Event Triggered When: Find Function was used but no results are returned.
		MsgBox6(Query & " not found.")
	End Sub

	Private Sub dns_Updated() Handles dns.Updated
		'Event Triggered When: A record is updated.
		MsgBox6("Record Updated!")
	End Sub

	Private Sub Export_Error(ByRef Description As String) Handles Export.Error
		'Event Triggered When: There was an error Exporting from the Database.
		MsgBox6(Description)
	End Sub

	Private Sub Export_NotConnected() Handles Export.NotConnected
		'Event Triggered When: ezDatabase Class is not exposed (connected).
		MsgBox6("Database not exposed. Cannot export.")
	End Sub

	Private Sub Export_Successful() Handles Export.Successful
		'Event Triggered When: A successful export occurs.
		MsgBox6("Table was successfully Exported.")
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		dns = New ezDatabase()
	End Sub
	
	Private Sub UpdateInfo()
		'Update the information
		lblInfo.Caption = dns.CurrentTable & " (" & dns.TableNumber & ") - " & "Item: " & dns.Field(0) & ControlChars.NewLine & "BOF: " & dns.BOF(RequestType.rtCurrentTable) & ControlChars.NewLine & "EOF: " & dns.EOF(RequestType.rtCurrentTable)
	End Sub
	
	Private Function SetOptions(ByRef qType As Byte) As Object
	' UPGRADE_INFO (#0561): The 'SetOptions' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'qType' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If qType = 1 Then  'Find
			If chkCase.Value = 1 Then  'Set CaseSensitive to True.
				dns.CaseSensitive = True 'Query to find must be an EXACT match.
			Else
				dns.CaseSensitive = False 'Set CaseSensitive to False
			End If
			
			If VB.Left(cboType.Text, 2) = "--" Then 
				bType = 2 'Set type of search to default (Search all tables)
			Else
				If InStr(cboType.Text, "Current") Then 
					bType = 1 'Search Current Table
				Else
					bType = 2 'Search All Tables
				End If
			End If
			
			If chkAuto.Value = 1 Then  lstResults.Clear() 'Clear results for next query
		ElseIf qType = 2 Then  'Move
			If VB.Left(cboType2.Text, 6) = "Select" Then 
				bType = 2 'Set type of search to default (Search all tables)
			Else
				If InStr(cboType2.Text, "Current") Then 
					bType = 1 'Search Current Table
				Else
					bType = 2 'Search All Tables
				End If
			End If
		Else
			If VB.Left(cboType3.Text, 6) = "Select" Then 
				bType = 2 'Set type of search to default (Search all tables)
			Else
				If InStr(cboType3.Text, "Current") Then 
					bType = 1 'Search Current Table
				Else
					bType = 2 'Search All Tables
				End If
			End If
		End If
	End Function

End Class
