' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

'Request Type Enumeration: Based on request type, function will only work inside those parameters.
Public Enum RequestType
	rtCurrentTable = 1 'Function works only within current table/recordset to retrieve data
	rtAllTables = 2 'Function works with all tables/recordsets to retrieve data
End Enum

Friend Class ezDatabase
	Implements IDisposable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'Author Comments/Information :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
	'This class was written by Daniel M. Use it freely in your projects as you like.        '
	'It is commented but could be better. Example application shows more. This is my first  '
	'class so please give me comments at seoulxkorean@yahoo.com or at planet-source-code.com'
	'Thanks for downloading!                                                                '
	':::::::::::::::::::::::::::::::::::::::::::::::::: Wow I love these comment boxes =D   '
	
	'Please give credit if you do intend on using this in your projects. Thanks.
	
	'Include Export Options
	Public Export As New ezExport
	
	'Query variables
	Private bFindAll As Boolean 'Is FindAll being used?
	Private bLoop As Boolean 'Still searching for query?
	Private rsIndex As Integer 'Current index being queried.
	Private rsLastField As String = "" 'Last Field searched.
	Private rsLastQuery As String = "" 'Last Query.
	Private typeCriteria As String = "" 'Criteria string.
	
	'Property Variables
	Private bMode As Byte 'Connection Mode
	Private bWritable As Boolean 'Is MDB File Writable?
	Private bBackup As Boolean 'Create Backup?
	Private bCaseSensitive As Boolean 'Is Case Sensitive?
	Private bConnected As Boolean 'Is there a connection?
	Private bFindMarker As Boolean 'Was Query found?
	Private sConnection As String = "" 'Database Location String
	Private sUsername As String = "" 'Username String
	Private sPassword As String = "" 'Password String
	Private rsRequest As Integer 'Request Type
	Private tblCount As Integer 'Table Count

	'Table Connection String Collection
	Private tblString As New Collection

	'Error Message Constants
	Private Const errDatabaseUndefined As String = "Database Connection not Defined."
	Private Const errTableUndefined As String = "No tables have been defined."
	Private Const errNotConnected As String = "Must be Connected to Query Data."
	Private Const errActionWhileConnected As String = "Action cannot be performed while connected."
	Private Const errTableNotConnected As String = "Could not retrieve data from table."
	Private Const errStartEndofFile As String = "Record is either BOF or EOF, Action Canceled."
	
	'Public Events
	Public Event InvalidParameter(ByRef Description As String) 'Specific Error-Type Event
	Public Event ConnectionError(ByRef Description As String) 'Connection Error-Type Event
	Public Event Connect() 'On Connect
	Public Event Disconnect() 'On Disconnect
	Public Event FindNotUsed() 'Specific Error-Type Event
	Public Event FieldsChanged(ByRef QueryInfo As String) 'Backbone Event used to retrieve data
	Public Event [Error](ByRef Description As String) 'All miscellaneous errors go here.
	Public Event QueryNotFound(ByRef Query As String) 'Backbone event for unfound data.
	Public Event Added() 'Successful Event
	Public Event Deleted() 'Successful Event
	Public Event Updated() 'Successful Event
	'========================= Initialize/Connection & Disconnection Subs =========================
	Private Sub Class_Initialize_VB6()
		ConnectMode = ADODB.ConnectModeEnum.adModeReadWrite 'Default Property
	End Sub
	
	Public Sub Expose()
		Dim sSplit() As String
		Dim sPath As String = ""
		Dim i As Integer
		If Connected Then 
			RaiseEvent ConnectionError("Already Connected")
		Else
			If Len6(dbLocation) Then 
				If tblCount > 0 Then 
					dbCon.Mode = Mode
					dbCon.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;" & "data source=" & dbLocation & ";" 'Connection information
					If Backup Then 
						If Dir6(dbLocation) <> "" Then 
							sSplit = Split(dbLocation, "\")
							sPath = VB.Left(dbLocation, Len6(dbLocation) - Len6(sSplit(UBound6(sSplit)))) & "Backup"
							If FolderExists(sPath) = False Then 
								MkDir((sPath)) 'Make Backup folder if non-existant
							End If
							FileCopy(dbLocation, sPath & "\" & sSplit(UBound6(sSplit)))
							'Will overwrite if any previous existing backups.
						End If
					End If
					checkAttrib() 'Check if .mdb is writable
					dbCon.CursorLocation = ADODB.CursorLocationEnum.adUseClient
					dbCon.Open(dbCon.ConnectionString, Username, Password) 'Open the connection
					
					If dbCon.State = 1 Then 
						For i = 0 To tblCount - 1
							If dbRs(i).State = 0 Then  'Hopefully it is at this state
								' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tblString.Item(i + 1)'. Consider using the GetDefaultMember6 helper method.
								dbRs(i).Open("Select * From [" & tblString.Item(i + 1) & "]", dbCon, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
							Else
								dbRs(i).Close() 'If already opened, close it then re-open
								' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tblString.Item(i + 1)'. Consider using the GetDefaultMember6 helper method.
								dbRs(i).Open("Select * From [" & tblString.Item(i + 1) & "]", dbCon, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
							End If
						Next
						RaiseEvent Connect()
						bConnected = True 'Update status
					Else
						RaiseEvent ConnectionError("Could not connect to '" & sConnection & "'")
					End If
				Else
					RaiseEvent ConnectionError(errTableUndefined)
				End If
			Else
				RaiseEvent ConnectionError(errDatabaseUndefined)
			End If
		End If
	End Sub
	
	Public Sub Dispose_VB6()
		Dim i As Integer
		If Connected = True Then 
			RaiseEvent Disconnect()
			bConnected = False
			
			For i = 0 To UBound6(dbRs) 'Prevent errors by checking their states before closing
				If dbRs(i).State = 1 Then  dbRs(i).Close() 'shouldn't happen, but just in case.
				dbRs(i) = Nothing 'Clear from memory
			Next
			
			If dbCon.State = 1 Then  dbCon.Close()
			dbCon = Nothing 'Clear from memory
			tblCount = 0
			Do Until tblString.Count() = 0 'Clear collection
				tblString.Remove(1)
			Loop
		Else
			RaiseEvent [Error]("You are already Disconnected.") 'Can't dispose whats not already there!
		End If
	End Sub
	
	'=========================  Let Property Values  =====================================
	Public WriteOnly Property ConnectMode() As ADODB.ConnectModeEnum
		Set(ByVal Mode As ADODB.ConnectModeEnum)
			bMode = Mode
	 	End Set
	End Property

	'========================  Get Property Values  ======================================
	Public ReadOnly Property Mode() As Byte
		Get
			Return bMode
	 	End Get
	End Property

	Public Property Backup() As Boolean
		Get
			Return bBackup
	 	End Get
		Set(ByVal Backup As Boolean)
			bBackup = Backup
	 	End Set
	End Property

	Public Property CaseSensitive() As Boolean
		Get
			Return bCaseSensitive
	 	End Get
		Set(ByVal CaseSensitive As Boolean)
			bCaseSensitive = CaseSensitive
	 	End Set
	End Property

	Public Property RequestType() As RequestType
		Get
			Return rsRequest
	 	End Get
		Set(ByVal RequestType As RequestType)
			rsRequest = RequestType
	 	End Set
	End Property

	Public ReadOnly Property FindMarker() As Boolean
		Get
			Return bFindMarker
	 	End Get
	End Property

	Public ReadOnly Property RecordCount(Optional ByVal CountType As RequestType = 2) As Integer
		Get
			Dim i As Integer
			If Connected Then 
				If CountType = 1 Then  'Get record count for current table/recordset
					Return dbRs(rsIndex).RecordCount
				Else
					For i = 0 To UBound6(dbRs) 'Get record count for all tables/recordsets
						RecordCount += dbRs(i).RecordCount
					Next
				End If
			Else
				RaiseEvent [Error](errNotConnected)
			End If
	 	End Get
	End Property

	Public Property Username() As String
		Get
			Return sUsername 'Get username specified by user
	 	End Get
		Set(ByVal Username As String)
			sUsername = Username 'Set username for database
	 	End Set
	End Property

	Public Property Password() As String
		Get
			Return sPassword 'Get password specified by user
	 	End Get
		Set(ByVal Password As String)
			sPassword = Password 'Set password for database
	 	End Set
	End Property

	Public ReadOnly Property BOF(Optional ByVal RequestType As RequestType = 2) As Boolean
		Get
			If Connected Then 
				If RequestType <> 1 Then 
					If rsIndex = 0 Then 
						Return dbRs(rsIndex).BOF
					Else
						Return False
					End If
				Else
					Return dbRs(rsIndex).BOF
				End If
			Else
				RaiseEvent [Error](errNotConnected)
			End If
	 	End Get
	End Property

	Public ReadOnly Property EOF(Optional ByVal RequestType As RequestType = 2) As Boolean
		Get
			If Connected Then 
				If RequestType <> 1 Then 
					If rsIndex = tblCount - 1 Then  Return dbRs(rsIndex).EOF Else Return False 'Similar to BOF
				Else
					Return dbRs(rsIndex).EOF
				End If
			Else
				RaiseEvent [Error](errNotConnected)
			End If
	 	End Get
	End Property

	Public ReadOnly Property Field(ByVal NameOrIndex As Object) As String
		Get
			If Connected Then 
				If dbRs(rsIndex).State = 1 Then  'Make sure we're connected
					If dbRs(rsIndex).BOF Or dbRs(rsIndex).EOF Then  'If BOF/EOF then retrieved data is ""
						Return ""
					Else
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'NameOrIndex'. Consider using the GetDefaultMember6 helper method.
						If IsNull6(dbRs(rsIndex).Fields(NameOrIndex)) = True Then  'If field is null, we cannot give null
							Return "" 'data so we must handle this.
						Else
							' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'NameOrIndex'. Consider using the GetDefaultMember6 helper method.
							' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(rsIndex).Fields(NameOrIndex).Value'. Consider using the GetDefaultMember6 helper method.
							Return dbRs(rsIndex).Fields(NameOrIndex).Value
						End If
					End If
				Else
					RaiseEvent ConnectionError(errTableNotConnected)
				End If
			Else
				RaiseEvent [Error](errNotConnected)
			End If
	 	End Get
	End Property

	Public ReadOnly Property Connected() As Boolean
		Get
			Return bConnected 'Get Connected State
	 	End Get
	End Property

	Public ReadOnly Property TableCount() As Integer
		Get
			Return tblCount 'Get table count
	 	End Get
	End Property

	Public Property dbLocation() As String
		Get
			Return sConnection 'Get location to .mdb
	 	End Get
		Set(ByVal mdbLocation As String)
			If Dir6(mdbLocation) <> "" Then  'Method to test if a file exists
				sConnection = mdbLocation 'Set location of .mdb file
			Else
				RaiseEvent InvalidParameter("Database File does not exist.")
			End If
	 	End Set
	End Property

	Public ReadOnly Property CurrentTable() As String
		Get
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tblString.Item(rsIndex + 1)'. Consider using the GetDefaultMember6 helper method.
			If Connected Then  CurrentTable = tblString.Item(rsIndex + 1) Else Return ""
	 	End Get
	End Property

	Public ReadOnly Property TableName(ByVal TableNum As Integer) As String
		Get
			If tblString.Count() Then 
				If ValidInt(TableNum, 0, tblString.Count()) Then 
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'tblString.Item(TableNum + 1)'. Consider using the GetDefaultMember6 helper method.
					Return tblString.Item(TableNum + 1) 'Give tablename of specified tablenum
				Else
					RaiseEvent [Error]("Invalid Table Number.") 'Error handling
				End If
			Else
				RaiseEvent [Error]("No Tables have been added.")
			End If
	 	End Get
	End Property

	Public ReadOnly Property TableNumber() As Integer
		Get
			Return rsIndex 'Get current table number
	 	End Get
	End Property

	Public ReadOnly Property LastQuery() As String
		Get
			Return rsLastQuery 'Get last query
	 	End Get
	End Property

	'=============================     Class Functions / Subs     ===============================
	Public Sub AddTable(ByRef NameOfTable As String)
	' UPGRADE_INFO (#0551): The 'NameOfTable' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Connected Then  'Error handling once again.
			RaiseEvent [Error](errActionWhileConnected)
		Else
			If Len6(NameOfTable) Then 
				If tblCount = 0 Then  'If first table then redim as 0
					Redim6(dbRs, 0, 0)
					 Else 'otherwise increase count
					Redim6(dbRs, 0, UBound6(dbRs) + 1)
				End If
				tblString.Add(NameOfTable) 'add table name
				tblCount += 1 'add table count
			Else
				RaiseEvent InvalidParameter("Table Name must be at least one character length.")
			End If
		End If
		
	End Sub
	
	Public Sub RemoveTable(ByVal TableNum As Integer)
	' UPGRADE_INFO (#0501): The 'RemoveTable' member isn't used anywhere in current application.
		If Connected Then 
			RaiseEvent [Error](errActionWhileConnected)
		Else
			If tblString.Count() = 0 Then 
				RaiseEvent InvalidParameter("Table Number is Invalid")
			Else
				tblString.Remove(TableNum)
				tblCount -= 1
			End If
		End If
	End Sub

	' IGNORED: Public Sub UpdateTable(ByVal TableNum As Long, ByRef NewTableName As String)
	' IGNORED: If Connected Then
	' IGNORED: RaiseEvent Error(errActionWhileConnected$)
	' IGNORED: Else
	' IGNORED: If tblString.Count = 0 Or TableNum > tblString.Count Or TableNum < 1 Or NewTableName = "" Then
	' IGNORED: RaiseEvent InvalidParameter("Table Number/Name is Invalid")
	' IGNORED: Else
	' IGNORED: tblString.Item(TableNum) = NewTableName$ ' IGNORED: 'update table name by tablenum
	' IGNORED: End If
	' IGNORED: End If
	' IGNORED: End Sub
	
	Public Sub Update(ByRef rsField As String, ByRef rsNewValue As String)
	' UPGRADE_INFO (#0551): The 'rsField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'rsNewValue' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Connected Then 
			If bWritable = False Then  RaiseEvent [Error]("Database File is set to Read Only."): Exit Sub
			If dbRs(rsIndex).State = 1 Then 
				If dbRs(rsIndex).BOF Or dbRs(rsIndex).EOF Then 
					RaiseEvent [Error](errStartEndofFile)
				Else
					dbRs(rsIndex).Fields(rsField).Value = rsNewValue
					dbRs(rsIndex).Update()
					RaiseEvent Updated()
					RaiseEvent FieldsChanged("Record Updated")
				End If
			Else
				RaiseEvent [Error](errTableNotConnected)
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
		
	End Sub

	Public Sub Delete()
		If Connected Then 
			If bWritable = False Then  RaiseEvent [Error]("Database File is set to Read Only."): Exit Sub
			If dbRs(rsIndex).BOF Or dbRs(rsIndex).EOF Then 
				RaiseEvent [Error](errStartEndofFile)
			Else
				dbRs(rsIndex).Delete()
				dbRs(rsIndex).MovePrevious()
				RaiseEvent Deleted()
				RaiseEvent FieldsChanged("Record Deleted")
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub

	Public Sub AddNew(ByVal tblNumber As Integer, ByRef objArray As Object, Optional ByVal iStart As Integer = 0)
	' UPGRADE_INFO (#0551): The 'objArray' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		Dim f As Integer
		' UPGRADE_INFO (#0501): The 'iEnd' member isn't used anywhere in current application.
		Dim iEnd As Integer
		If Connected Then 
			If bWritable = False Then  RaiseEvent [Error]("Database File is set to Read Only."): Exit Sub
			If tblNumber > tblCount - 1 Or tblNumber < 0 Then 
				RaiseEvent InvalidParameter("Table Number Invalid")
			Else
				rsIndex = tblNumber 'make current table the given value
				f = 1: i = iStart
				
				If UBound6(objArray) - iStart < dbRs(rsIndex).Fields.Count Then 
					RaiseEvent InvalidParameter("Record could not be updated due to invalid Array.")
				Else
					With dbRs(rsIndex)
						.MoveLast() 'move last
						.AddNew() 'add new
						Do
							' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'objArray(i)'. Consider using the GetDefaultMember6 helper method.
							.Fields((f)).Value = objArray(i)
							f += 1
							i += 1
						Loop Until f = .Fields.Count
						.Update() 'update the fields
					End With
					RaiseEvent Added()
					RaiseEvent FieldsChanged("Record Added")
				End If
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub MoveRecordset(ByVal TableNum As Integer)
	' UPGRADE_INFO (#0501): The 'MoveRecordset' member isn't used anywhere in current application.
		If Connected Then 
			If ValidInt(TableNum, 0, UBound6(dbRs)) = True Then 
				rsIndex = TableNum
				dbRs(rsIndex).MoveFirst()
				RaiseEvent FieldsChanged("MoveRecordset:" & TableNum)
			Else
				RaiseEvent InvalidParameter("Invalid Table Number")
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub FirstRecordset()
		If Connected Then 
			rsIndex = 0
			dbRs(rsIndex).MoveFirst()
			RaiseEvent FieldsChanged("MoveFirstRecordset:" & rsIndex)
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub NextRecordset()
		If Connected Then 
			If rsIndex <> tblCount - 1 Then  rsIndex += 1 Else Exit Sub
			dbRs(rsIndex).MoveFirst()
			RaiseEvent FieldsChanged("MoveNextRecordset:" & rsIndex)
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub PreviousRecordset()
		If Connected Then 
			If rsIndex <> 0 Then  rsIndex -= 1 Else Exit Sub
			dbRs(rsIndex).MoveFirst()
			RaiseEvent FieldsChanged("MovePreviousRecordset:" & rsIndex)
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub LastRecordset()
		If Connected Then 
			rsIndex = tblCount - 1
			dbRs(rsIndex).MoveFirst()
			RaiseEvent FieldsChanged("MoveLastRecordset:" & rsIndex)
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub Move(ByVal NumRecords As Integer, Optional ByVal Start As Integer = 0)
	' UPGRADE_INFO (#0501): The 'Move' member isn't used anywhere in current application.
		If Connected Then 
			If dbRs(rsIndex).EOF Then 
				If rsIndex <> tblCount - 1 Then  rsIndex += 1 Else rsIndex = 0
				dbRs(rsIndex).MoveFirst()
			End If
			
			If Start <> 0 Then 
				dbRs(rsIndex).Move(NumRecords, Start)
				RaiseEvent FieldsChanged("Move:" & NumRecords & "," & Start)
			Else
				dbRs(rsIndex).Move(NumRecords)
				RaiseEvent FieldsChanged("Move:" & NumRecords)
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
		
	End Sub
	
	Public Sub MoveFirst(Optional ByVal RequestType As RequestType = 2)
		If Connected Then 
			If RequestType <> 1 Then  rsIndex = 0 'set recordset index to 0
			dbRs(rsIndex).MoveFirst() 'move first
			RaiseEvent FieldsChanged("MoveFirst:" & RequestType)
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub MoveNext()
		If Connected Then 
			With dbRs(rsIndex)
				If .EOF Then  'end of file
					If rsIndex = tblCount - 1 Then 
						'do nothing
					Else
						rsIndex += 1
						dbRs(rsIndex).MoveFirst()
						RaiseEvent FieldsChanged("MoveNext")
					End If
				Else
					.MoveNext()
					If .EOF Then 
						If rsIndex = tblCount - 1 Then 
							'do nothing
						Else
							rsIndex += 1
							dbRs(rsIndex).MoveFirst()
							RaiseEvent FieldsChanged("MoveNext")
						End If
					Else
						RaiseEvent FieldsChanged("MoveNext")
					End If
				End If
			End With
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub MovePrev()
		If Connected Then 
			With dbRs(rsIndex)
				If .BOF Then 
					If rsIndex = 0 Then 
						'do nothing
					Else
						rsIndex -= 1
						dbRs(rsIndex).MoveLast()
						RaiseEvent FieldsChanged("MovePrev")
					End If
				Else
					.MovePrevious()
					If .BOF Then 
						If rsIndex = 0 Then 
							'do nothing
						Else
							rsIndex -= 1
							dbRs(rsIndex).MoveLast()
							RaiseEvent FieldsChanged("MovePrev")
						End If
					Else
						RaiseEvent FieldsChanged("MovePrev")
					End If
				End If
			End With
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub MoveLast(Optional ByVal RequestType As RequestType = 2)
		If Connected Then 
			If RequestType <> 1 Then  rsIndex = tblCount - 1
			dbRs(rsIndex).MoveLast()
			RaiseEvent FieldsChanged("MoveLast")
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub Find(ByRef nField As String, ByRef sQuery As String, Optional ByVal RequestType As RequestType = 2)
	' UPGRADE_INFO (#0551): The 'nField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sQuery' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		FindFirst(nField, sQuery, RequestType)
	End Sub
	
	Public Sub FindAll(ByRef nField As String, ByRef sQuery As String, Optional ByVal RequestType As RequestType = 2)
	' UPGRADE_INFO (#0551): The 'nField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sQuery' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Connected Then  'FindAll uses findfirst then findnext until end of file on all tables
			
			If setCriteria(nField, sQuery) = False Then  Exit Sub
			bFindMarker = False
			FindFirst(nField, sQuery, RequestType)

			bFindAll = True
			If EOF(2) = False Then 
				Do Until EOF(2) Or bFindAll = False
					FindNext()
				Loop
			End If
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
		
	End Sub
	
	Public Sub FindFirst(ByRef nField As String, ByRef sQuery As String, Optional ByVal RequestType As RequestType = 2)
	' UPGRADE_INFO (#0551): The 'nField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sQuery' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim sResult As String = ""
		If Connected Then 
			If setCriteria(nField, sQuery) = False Then  Exit Sub
			bFindMarker = False
			rsRequest = RequestType
			rsIndex = 0
			
			Do
				dbRs(rsIndex).MoveFirst()
				dbRs(rsIndex).Find(typeCriteria, 0, ADODB.SearchDirection.adSearchForward)
				
				If dbRs(rsIndex).EOF Then 
					If RequestType <> 1 Then 
						If rsIndex <> tblCount - 1 Then 
							rsIndex += 1
						Else
							RaiseEvent QueryNotFound(sQuery) 'Query not found!
							rsLastQuery = Nothing
							bLoop = True
						End If
					Else
						RaiseEvent QueryNotFound(sQuery)
						rsLastQuery = Nothing
						bLoop = True
					End If
				Else
					If CaseSensitive = True Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(rsIndex).Fields(nField).Value'. Consider using the GetDefaultMember6 helper method.
						sResult = dbRs(rsIndex).Fields(nField).Value
						If Trim(sQuery) = Trim(sResult) Then 
							RaiseEvent FieldsChanged("FindFirst:" & nField) 'Query found
							bFindMarker = True
							bLoop = True
						Else
							FindNext()
							Exit Sub
						End If
					Else
						RaiseEvent FieldsChanged("FindFirst:" & nField) 'Query found
						bFindMarker = True
						bLoop = True
					End If
				End If
				
			Loop Until bLoop = True
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub FindNext()
		Dim sResult As String = ""
		If Connected Then 
			If Len6(rsLastQuery) = 0 Then 
				RaiseEvent FindNotUsed()
				Exit Sub
			End If
			bFindMarker = False
			
			Do
				If dbRs(rsIndex).EOF <> True Then  dbRs(rsIndex).MoveNext()
				dbRs(rsIndex).Find(typeCriteria, 0, ADODB.SearchDirection.adSearchForward)
				If dbRs(rsIndex).EOF Then 
					If rsRequest <> 1 Then 
						If rsIndex = tblCount - 1 Then 
							bLoop = True
						Else
							rsIndex += 1
							dbRs(rsIndex).MoveFirst()
							bLoop = False
						End If
					Else
						RaiseEvent QueryNotFound(rsLastQuery)
						bLoop = True
					End If
				Else
					If CaseSensitive = True Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(rsIndex).Fields(rsLastField).Value'. Consider using the GetDefaultMember6 helper method.
						sResult = dbRs(rsIndex).Fields(rsLastField).Value
						If Trim(rsLastQuery) = Trim(sResult) Then 
							RaiseEvent FieldsChanged("FindNext:" & rsLastField)
							bFindMarker = True
							bLoop = True
						End If
					Else
						RaiseEvent FieldsChanged("FindNext:" & rsLastField)
						bFindMarker = True
						bLoop = True
					End If
				End If
				
			Loop Until bLoop = True
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	Public Sub FindPrev()
		Dim sResult As String = ""
		If Connected Then 
			If Len6(rsLastQuery) = 0 Then 
				RaiseEvent FindNotUsed()
				Exit Sub
			End If
			bFindMarker = False
			Do
				If dbRs(rsIndex).BOF <> True Then  dbRs(rsIndex).MovePrevious()
				dbRs(rsIndex).Find(typeCriteria, 0, ADODB.SearchDirection.adSearchBackward)
				If dbRs(rsIndex).BOF Then 
					If rsRequest <> 1 Then 
						If rsIndex = 0 Then 
							bLoop = True
						Else
							rsIndex -= 1
							dbRs(rsIndex).MoveLast()
						End If
					Else
						RaiseEvent QueryNotFound(rsLastQuery)
						bLoop = True
					End If
				Else
					If CaseSensitive = True Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(rsIndex).Fields(rsLastField).Value'. Consider using the GetDefaultMember6 helper method.
						sResult = dbRs(rsIndex).Fields(rsLastField).Value
						If Trim(rsLastQuery) = Trim(sResult) Then 
							RaiseEvent FieldsChanged("FindPrev:" & rsLastField)
							bFindMarker = True
							bLoop = True
						End If
					Else
						RaiseEvent FieldsChanged("FindPrev:" & rsLastField)
						bFindMarker = True
						bLoop = True
					End If
				End If
				
			Loop Until bLoop = True
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
		
	End Sub
	
	Public Sub FindLast(ByRef nField As String, ByRef sQuery As String, Optional ByVal RequestType As RequestType = 2)
	' UPGRADE_INFO (#0551): The 'nField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sQuery' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim sResult As String = ""
		If Connected Then 
			If setCriteria(nField, sQuery) = False Then  Exit Sub
			rsRequest = RequestType
			If RequestType <> 1 Then  rsIndex = tblCount - 1
			bFindMarker = False
			
			Do
				dbRs(rsIndex).MoveLast()
				dbRs(rsIndex).Find(typeCriteria, 0, ADODB.SearchDirection.adSearchBackward)
				
				If dbRs(rsIndex).BOF Then 
					If RequestType <> 1 Then 
						If rsIndex <> 0 Then 
							rsIndex -= 1
						Else
							RaiseEvent QueryNotFound(sQuery)
							rsLastQuery = Nothing
							bLoop = True
						End If
					Else
						RaiseEvent QueryNotFound(sQuery)
						rsLastQuery = Nothing
						bLoop = True
					End If
				Else
					If CaseSensitive = True Then 
						' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'dbRs(rsIndex).Fields(rsLastField).Value'. Consider using the GetDefaultMember6 helper method.
						sResult = dbRs(rsIndex).Fields(rsLastField).Value
						If Trim(sQuery) = Trim(sResult) Then 
							RaiseEvent FieldsChanged("FindLast:" & nField)
							bFindMarker = True
							bLoop = True
						Else
							FindPrev()
							Exit Sub
						End If
					Else
						RaiseEvent FieldsChanged("FindLast:" & nField)
						bFindMarker = True
						bLoop = True
					End If
				End If
				
			Loop Until bLoop = True
		Else
			RaiseEvent ConnectionError(errNotConnected)
		End If
	End Sub
	
	'===========================Class Functions/Subs========================================
	Private Function ValidInt(ByRef qNumber As Integer, ByVal iMin As Short, ByVal iMax As Short) As Boolean
	' UPGRADE_INFO (#0551): The 'qNumber' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If qNumber Like "*[!.,0-9]*" Or qNumber Like "*.*" Then  Exit Function
		If qNumber < iMin Or qNumber > iMax Then  Exit Function
		Return True
	End Function
	
	Private Function RaiseErr(ByVal ErrorNumber As Integer, Optional ByRef Description As String = "") As Object
	' UPGRADE_INFO (#0501): The 'RaiseErr' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0561): The 'RaiseErr' symbol was defined without an explicit "As" clause.
	' UPGRADE_INFO (#0551): The 'Description' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		
		Select Case ErrorNumber
		Case "3265"
			RaiseEvent InvalidParameter("Field Name Unknown")
		Case Else
			RaiseEvent [Error](Description)
		End Select
		
	End Function
	
	Private Function setCriteria(ByRef nField As String, ByRef sQuery As String) As Boolean
	' UPGRADE_INFO (#0551): The 'nField' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sQuery' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		If Len6(sQuery) = 0 Or Len6(nField) = 0 Then 
			RaiseEvent InvalidParameter("Field or Query is Invalid.")
		Else
			rsLastQuery = sQuery 'update last query
			rsLastField = nField 'update last field
			typeCriteria = "[" & nField & "] = '" & sQuery & "'" 'set criteria for search
			setCriteria = True
			bLoop = False
		End If
	End Function
	
	Private Sub checkAttrib()
		On Error GoTo notWritable 
		Dim fFile As Short
		bWritable = True
		fFile = FreeFile6()
		
		FileOpen6(fFile, dbLocation, OpenMode.Append, OpenAccess.Default, OpenShare.Default, -1)
		FileClose6(fFile)
		
		Exit Sub
notWritable:
		bWritable = False
	End Sub
	
	Private Sub Class_Terminate_VB6()
		Dispose_VB6() 'Call Cleanup Code
	End Sub

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub

End Class
