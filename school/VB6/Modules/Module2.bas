Attribute VB_Name = "Module2"
'-----------------------------------------------------------------------------------------------------
'All codes are copyright by Philip V. Naparan 2004
'
'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
'E-mail Address: philipnaparan@yahoo.com
'Contact #: 639186443161
'----------------------------------------------------------------------------------------------------
Option Explicit

Global school_name              As String
Global school_address           As String

Global user_type                As String
Global user_name                As String
Global user_login               As Date

Global end_app                  As Boolean

Global rs_log                   As New ADODB.Recordset

'---------------------
'General connection
'---------------------
Global cn                       As New ADODB.Connection
'---------------------
'For student
'---------------------
Global frm_stud_show            As Boolean

Global sds, sms, sfs, sns, sos  As Byte

Global rs_stud                  As New ADODB.Recordset
'---------------------
'For level
'---------------------
Global rs_level                 As New ADODB.Recordset
'---------------------
'For School Year
'---------------------
Global rs_sy                    As New ADODB.Recordset
'---------------------
'For Sections
'---------------------
Global rs_sec                   As New ADODB.Recordset

'---------------------
'For printing
'---------------------
Global rpt_header As report_header


Public Sub set_conn_getData(ByRef sConnection As ADODB.Connection, ByVal sDataLocation As String, ByVal sHavePassword As Boolean, ByVal sPassword As String)
If sHavePassword = True Then
    sConnection.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataLocation & ";Persist Security Info=False;Jet OLEDB:Database Password=" & sPassword
Else
    sConnection.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sDataLocation & ";Persist Security Info=False"
End If
End Sub
Public Sub set_rec_getData(ByRef sRecordset As ADODB.Recordset, ByRef sConnection As ADODB.Connection, ByVal sSQL As String)
With sRecordset
    .CursorLocation = adUseClient
    .Open sSQL, sConnection, adOpenKeyset, adLockOptimistic
End With
End Sub


Public Function rec_found(ByRef sRecordset As ADODB.Recordset, ByVal sField As String, ByVal sFindText As String) As Boolean
'--------------------------------------------------
'Move the recordset to the first record
'--------------------------------------------------
sRecordset.Requery '[ Use this instead of movefirst so that new record added can be used immediately ]
'Search the record
sRecordset.Find sField & " = '" & sFindText & "'"
'--------------------------------------------------
'Verify if the search string was found or not
'--------------------------------------------------
If sRecordset.EOF Then
    rec_found = False
Else
    rec_found = True
End If
End Function
Public Sub record_login(ByVal sTimeLogin As Date, ByVal sUserName As String)
On Error Resume Next
'--------------------------------------------------
'Declare variables
'--------------------------------------------------
Dim rs_user_log As New ADODB.Recordset
Dim conn_user_log As New ADODB.Connection
'--------------------------------------------------
'Set the variables to have connection to database
'--------------------------------------------------
Call set_conn_getData(conn_user_log, App.Path & "\MasterFile.mdb", True, "reg386")
Call set_rec_getData(rs_user_log, conn_user_log, "Select * From UsersLog")
With rs_user_log
    .AddNew
        .Fields(0) = sUserName
        .Fields(1) = sTimeLogin
    .Update
End With
'--------------------------------------------------
'Clear variables
'--------------------------------------------------
Set rs_user_log = Nothing
Set conn_user_log = Nothing
End Sub
Public Sub record_logout(ByVal sTimeLogin As Date, ByVal sUserName As String)
On Error Resume Next
'-------------------------------------------------
'Declare variables
'-------------------------------------------------
Dim rs_user_log As New ADODB.Recordset
Dim conn_user_log As New ADODB.Connection
'-------------------------------------------------
'Set the variables to have connection to database
'-------------------------------------------------
Call set_conn_getData(conn_user_log, App.Path & "\MasterFile.mdb", True, "reg386")
Call set_rec_getData(rs_user_log, conn_user_log, "SELECT UsersLog.Username, UsersLog.[Log-in], UsersLog.[Log-out] From UsersLog WHERE (((UsersLog.Username)='" & sUserName & "') AND ((UsersLog.[Log-in])='" & sTimeLogin & "'))")
With rs_user_log
        .Fields(2) = Now
    .Update
End With
MsgBox sUserName & " has been sucessfully log-out.", vbInformation, "Log-out Time: " & sTimeLogin
'-------------------------------------------------
'Clear variables
'-------------------------------------------------
Set rs_user_log = Nothing
Set conn_user_log = Nothing
End Sub

