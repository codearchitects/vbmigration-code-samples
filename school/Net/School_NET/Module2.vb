' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module2

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public school_name As String = ""
	Public school_address As String = ""
	
	Public user_type As String = ""
	Public user_name As String = ""
	Public user_login As Date
	
	Public end_app As Boolean
	
	' This wrapper property has been added to preserve As New semantics of rs_log variable
	Public Property rs_log() As ADODB.Recordset
		Get
			If rs_log_InnerField Is Nothing Then rs_log_InnerField = New ADODB.RecordsetClass()
			Return rs_log_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rs_log_InnerField = value
		End Set
	End Property
	
	Private rs_log_InnerField As ADODB.Recordset
	
	'---------------------
	'General connection
	'---------------------
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
	'---------------------
	'For student
	'---------------------
	Public frm_stud_show As Boolean
	
	' UPGRADE_INFO (#0561): The 'sds' symbol was defined without an explicit "As" clause.
	Public sds As Object
	' UPGRADE_INFO (#0561): The 'sms' symbol was defined without an explicit "As" clause.
	Public sms As Object
	' UPGRADE_INFO (#0561): The 'sfs' symbol was defined without an explicit "As" clause.
	Public sfs As Object
	' UPGRADE_INFO (#0561): The 'sns' symbol was defined without an explicit "As" clause.
	Public sns As Object
	Public sos As Byte
	
	' This wrapper property has been added to preserve As New semantics of rs_stud variable
	Public Property rs_stud() As ADODB.Recordset
		Get
			If rs_stud_InnerField Is Nothing Then rs_stud_InnerField = New ADODB.RecordsetClass()
			Return rs_stud_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rs_stud_InnerField = value
		End Set
	End Property
	
	Private rs_stud_InnerField As ADODB.Recordset
	'---------------------
	'For level
	'---------------------
	' This wrapper property has been added to preserve As New semantics of rs_level variable
	Public Property rs_level() As ADODB.Recordset
		Get
			If rs_level_InnerField Is Nothing Then rs_level_InnerField = New ADODB.RecordsetClass()
			Return rs_level_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rs_level_InnerField = value
		End Set
	End Property
	
	Private rs_level_InnerField As ADODB.Recordset
	'---------------------
	'For School Year
	'---------------------
	' This wrapper property has been added to preserve As New semantics of rs_sy variable
	Public Property rs_sy() As ADODB.Recordset
		Get
			If rs_sy_InnerField Is Nothing Then rs_sy_InnerField = New ADODB.RecordsetClass()
			Return rs_sy_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rs_sy_InnerField = value
		End Set
	End Property
	
	Private rs_sy_InnerField As ADODB.Recordset
	'---------------------
	'For Sections
	'---------------------
	' This wrapper property has been added to preserve As New semantics of rs_sec variable
	Public Property rs_sec() As ADODB.Recordset
		Get
			If rs_sec_InnerField Is Nothing Then rs_sec_InnerField = New ADODB.RecordsetClass()
			Return rs_sec_InnerField
		End Get
		Set(value As ADODB.Recordset)
			rs_sec_InnerField = value
		End Set
	End Property
	
	Private rs_sec_InnerField As ADODB.Recordset
	
	'---------------------
	'For printing
	'---------------------
	Public rpt_header As report_header

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

	Public Function rec_found(ByRef sRecordset As ADODB.Recordset, ByVal sField As String, ByVal sFindText As String) As Boolean
	' UPGRADE_INFO (#0551): The 'sRecordset' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		'--------------------------------------------------
		'Move the recordset to the first record
		'--------------------------------------------------
		sRecordset.Requery() '[ Use this instead of movefirst so that new record added can be used immediately ]
		'Search the record
		sRecordset.Find(sField & " = '" & sFindText & "'")
		'--------------------------------------------------
		'Verify if the search string was found or not
		'--------------------------------------------------
		If sRecordset.EOF Then 
			Return False
		Else
			Return True
		End If
	End Function
	
	Public Sub record_login(ByVal sTimeLogin As Date, ByVal sUserName As String)
		On Error Resume Next 
		'--------------------------------------------------
		'Declare variables
		'--------------------------------------------------
		Dim rs_user_log As ADODB.RecordsetClass = Nothing
		Dim conn_user_log As ADODB.ConnectionClass = Nothing
		'--------------------------------------------------
		'Set the variables to have connection to database
		'--------------------------------------------------
		Call set_conn_getData(AutoNew6(conn_user_log), App6.Path & "\MasterFile.mdb", True, "reg386")
		Call set_rec_getData(AutoNew6(rs_user_log), AutoNew6(conn_user_log), "Select * From UsersLog")
		With AutoNew6(rs_user_log)
			.AddNew()
			.Fields(0).Value = sUserName
			.Fields(1).Value = sTimeLogin
			.Update()
		End With
		'--------------------------------------------------
		'Clear variables
		'--------------------------------------------------
		rs_user_log = Nothing
		conn_user_log = Nothing
	End Sub
	
	Public Sub record_logout(ByVal sTimeLogin As Date, ByVal sUserName As String)
		On Error Resume Next 
		'-------------------------------------------------
		'Declare variables
		'-------------------------------------------------
		Dim rs_user_log As ADODB.RecordsetClass = Nothing
		Dim conn_user_log As ADODB.ConnectionClass = Nothing
		'-------------------------------------------------
		'Set the variables to have connection to database
		'-------------------------------------------------
		Call set_conn_getData(AutoNew6(conn_user_log), App6.Path & "\MasterFile.mdb", True, "reg386")
		Call set_rec_getData(AutoNew6(rs_user_log), AutoNew6(conn_user_log), "SELECT UsersLog.Username, UsersLog.[Log-in], UsersLog.[Log-out] From UsersLog WHERE (((UsersLog.Username)='" & sUserName & "') AND ((UsersLog.[Log-in])='" & sTimeLogin & "'))")
		With AutoNew6(rs_user_log)
			.Fields(2).Value = Now
			.Update()
		End With
		MsgBox6(sUserName & " has been sucessfully log-out.", MsgBoxStyle.Information, "Log-out Time: " & sTimeLogin)
		'-------------------------------------------------
		'Clear variables
		'-------------------------------------------------
		rs_user_log = Nothing
		conn_user_log = Nothing
	End Sub

End Module
