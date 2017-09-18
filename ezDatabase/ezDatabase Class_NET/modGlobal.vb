' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module modGlobal

	'Database connection variables, these must be referenced.
	Public dbCon As New ADODB.ConnectionClass
	Public dbRs() As ADODB.RecordsetClass
	Public Function FolderExists(ByRef Location As String) As Boolean
	' UPGRADE_INFO (#0551): The 'Location' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		On Error GoTo IsFalse_RENAMED 
		If GetAttr(Location) Then  Return True
IsFalse_RENAMED:
	End Function

End Module
