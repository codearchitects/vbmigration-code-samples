' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	' Modify next constant to match your directory system.
	Private Const DB_PATH As String = "c:\Program Files\Microsoft Visual Studio\vb98\biblio.mdb"
	
	Private cn As New ADODB.ConnectionClass
	Private rs As New ADODB.RecordsetClass
	Private connString As String = ""
	
	Private sql() As String
	Private sqlIndex As Integer
	Private sqlMax As Integer
	
	Private Sub cmdClear_Click() Handles cmdClear.Click
		txtSQL.SetFocus()
		txtSQL.Text = ""
	End Sub

	Public Function Getobject(ByVal s As String) As Object
	' UPGRADE_INFO (#0501): The 'Getobject' member isn't used anywhere in current application.
		' do nothing
	End Function

	Private Sub cmdConnection_Click() Handles cmdConnection.Click
		Dim conn As String = ""
		Dim cn2 As New ADODB.ConnectionClass
		Dim dlink As New MSDASC.DataLinksClass
		
		' Make the dialog modal respect to this form
		dlink.hWnd = Me.hWnd
		' show the Data Link Properties dialog
		On Error Resume Next 
		
		conn = dlink.PromptNew.ConnectionString
		' exit if user clicked the Cancel key
		If Err.Number Then  Exit Sub
		
		'conn = InputBox("Enter new connection string", , connString)
		'If conn = "" Or conn = connString Then Exit Sub
		
		' try to open the new connection
		On Error GoTo Error_Handler 
		cn2.ConnectionString = conn
		cn2.Open()
		' if no error, close the old connection and swap variables
		cn.RollbackTrans()
		cn.Close()
		' use the right connection object
		cn = cn2
		cn.BeginTrans()
		' remember the new connection string.
		connString = conn
		Exit Sub
		
Error_Handler:
		MsgBox6("Error " & Err.Number & ControlChars.Cr & ControlChars.Cr & Err.Description, MsgBoxStyle.Critical, "ERROR")
		
	End Sub

	Private Sub cmdMove_Click(ByRef Index As Short)
		If Index = 0 Then 
			If sqlIndex = 1 Then  Beep(): Exit Sub
			sqlIndex -= 1
		Else
			If sqlIndex = sqlMax Then  Beep(): Exit Sub
			sqlIndex += 1
		End If
		
		txtSQL.Text = sql(sqlIndex)

	End Sub

	Private Sub cmdRun_Click() Handles cmdRun.Click
		On Error GoTo Error_Handler 
		If rs.State And ADODB.ObjectStateEnum.adStateOpen Then  rs.Close()
		
		txtSQL.SetFocus()
		
		If InStr(1, txtSQL.Text, "select", CompareMethod.Text) = 1 Then 
			rs.Open(txtSQL.Text, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			DataGrid1.DataSource = rs
		Else
			cn.Execute(txtSQL.Text)
		End If
		
		sqlMax += 1
		If sqlMax > UBound6(sql) Then 
			ReDim Preserve sql(sqlMax + 999)
		End If
		sql(sqlMax) = txtSQL.Text
		sqlIndex = sqlMax
		
		Exit Sub
		
Error_Handler:
		MsgBox6("Error " & Err.Number & ControlChars.Cr & ControlChars.Cr & Err.Description, MsgBoxStyle.Critical, "ERROR")
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' Initialize the connection string.
		connString = "Provider=Microsoft.Jet.OLEDB.3.51; Data Source=" & DB_PATH
		cn.ConnectionString = connString
		' Open the connection and start a transaction.
		
		cn.Open()
		cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		cn.BeginTrans()
		' 10,000 different queries per session should be enough.
		ReDim sql(10000)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		cmdConnection.Left = ScaleWidth - cmdConnection.Width - 100
		cmdClear.Left = cmdConnection.Left
		cmdRun.Left = cmdClear.Left
		cmdMove(0).Left = cmdClear.Left
		cmdMove(1).Left = cmdClear.Left + cmdClear.Width - cmdMove(1).Width
		txtSQL.Width = cmdClear.Left - 100
		DataGrid1.Move(0, DataGrid1.Top, ScaleWidth - 100, ScaleHeight - DataGrid1.Top)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		cn.RollbackTrans()
	End Sub

End Class
