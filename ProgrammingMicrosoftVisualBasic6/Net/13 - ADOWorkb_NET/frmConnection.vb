' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmConnection

	Public WithEvents cn As ADODB.Connection
	Private frmErrors As frmErrors
	
	Private Sub cmdShowErrors_Click() Handles cmdShowErrors.Click
		frmErrors = New frmErrors()
		frmErrors.cn = cn
		frmErrors.Show()
	End Sub

	Private Sub cmdShowRecordset_Click() Handles cmdShowRecordset.Click
		Dim frmRecordset As New frmRecordset
		frmRecordset.rs = New ADODB.Recordset()
		frmRecordset.rs.ActiveConnection = cn
		frmRecordset.Show()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		If cn Is Nothing Then  cn = New ADODB.Connection()
		InitFields()
		ShowProperties()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If Not (frmErrors Is Nothing) Then  Unload6(frmErrors)
	End Sub

	Private Sub lstCustomProperties_Click() Handles lstCustomProperties.Click
		txtCustomProperty.Text = GetCustomPropertyValue(cn, lstCustomProperties)
		cmdSet.Enabled = CustomPropertyIsWriteable(cn, lstCustomProperties)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		SetCustomPropertyValue(cn, lstCustomProperties, txtCustomProperty.Text)
	End Sub

	Private Sub cmdSetProperties_Click() Handles cmdSetProperties.Click
		AssignProperties()
		ShowProperties()
	End Sub

	Private Sub cmdClear_Click() Handles cmdClear.Click
		txtEvents.Text = ""
	End Sub

	' Initialize fields and combo boxes
	
	Private Sub InitFields()
		AddToCombo(cboAttributes, "adXactAbortRetaining", ADODB.XactAttributeEnum.adXactAbortRetaining)
		AddToCombo(cboAttributes, "adXactCommitRetaining", ADODB.XactAttributeEnum.adXactCommitRetaining)
		
		AddToCombo(cboCursorLocation, "adUseServer", ADODB.CursorLocationEnum.adUseServer)
		AddToCombo(cboCursorLocation, "adUseClient", ADODB.CursorLocationEnum.adUseClient)
		
		AddToCombo(cboIsolationLevel, "adXactUnspecified", ADODB.IsolationLevelEnum.adXactUnspecified)
		AddToCombo(cboIsolationLevel, "adXactChaos", ADODB.IsolationLevelEnum.adXactChaos)
		AddToCombo(cboIsolationLevel, "adXactReadUncommitted", ADODB.IsolationLevelEnum.adXactReadUncommitted)
		AddToCombo(cboIsolationLevel, "adXactReadCommitted", ADODB.IsolationLevelEnum.adXactReadCommitted)
		AddToCombo(cboIsolationLevel, "adXactRepeatableRead", ADODB.IsolationLevelEnum.adXactRepeatableRead)
		AddToCombo(cboIsolationLevel, "adXactIsolated", ADODB.IsolationLevelEnum.adXactIsolated)
		
		AddToCombo(cboMode, "adModeUnknown", ADODB.ConnectModeEnum.adModeUnknown)
		AddToCombo(cboMode, "adModeRead", ADODB.ConnectModeEnum.adModeRead)
		AddToCombo(cboMode, "adModeWrite", ADODB.ConnectModeEnum.adModeWrite)
		AddToCombo(cboMode, "adModeReadWrite", ADODB.ConnectModeEnum.adModeWrite)
		AddToCombo(cboMode, "adModeShareDenyRead", ADODB.ConnectModeEnum.adModeShareDenyRead)
		AddToCombo(cboMode, "adModeShareDenyWrite", ADODB.ConnectModeEnum.adModeShareDenyWrite)
		AddToCombo(cboMode, "adModeShareExclusive", ADODB.ConnectModeEnum.adModeShareExclusive)
		AddToCombo(cboMode, "adModeShareDenyNone", ADODB.ConnectModeEnum.adModeShareDenyNone)
		
		AddToCombo(cboState, "adStateClosed", ADODB.ObjectStateEnum.adStateClosed)
		AddToCombo(cboState, "adStateOpen", ADODB.ObjectStateEnum.adStateOpen)
		AddToCombo(cboState, "adStateConnecting", ADODB.ObjectStateEnum.adStateConnecting)
		AddToCombo(cboState, "adStateExecuting", ADODB.ObjectStateEnum.adStateExecuting)
		AddToCombo(cboState, "adStateFetching", ADODB.ObjectStateEnum.adStateFetching)
	End Sub

	' Refresh the contents of the property fields.
	
	Public Sub ShowProperties()
		ShowProperty(cn, cboAttributes)
		ShowProperty(cn, txtCommandTimeout)
		ShowProperty(cn, txtConnectionString)
		ShowProperty(cn, txtConnectionTimeout)
		ShowProperty(cn, cboCursorLocation)
		ShowProperty(cn, txtDefaultDatabase)
		ShowProperty(cn, txtProvider)
		ShowProperty(cn, cboIsolationLevel)
		ShowProperty(cn, cboMode)
		ShowProperty(cn, cboState)
		ShowProperty(cn, txtVersion)
		
		' If you query the Properties collection before opening the connection
		' you might make it impossible to open the connection later.
		If cn.State And ADODB.ObjectStateEnum.adStateOpen Then 
			ShowCustomProperties(cn, lstCustomProperties)
			cmdSet.Enabled = True
		Else
			txtCustomProperty.Text = ""
			lstCustomProperties.Clear()
			cmdSet.Enabled = False
		End If
	End Sub

	' Assign current values in fields to properties
	
	Public Sub AssignProperties()
		AssignProperty(cn, cboAttributes)
		AssignProperty(cn, txtCommandTimeout)
		AssignProperty(cn, txtConnectionString)
		AssignProperty(cn, txtConnectionTimeout)
		AssignProperty(cn, cboCursorLocation)
		AssignProperty(cn, txtDefaultDatabase)
		AssignProperty(cn, txtProvider)
		AssignProperty(cn, cboIsolationLevel)
		AssignProperty(cn, cboMode)
	End Sub

	Private Sub cmdMethod_Click(ByRef index As Short)
		Dim action As String = ""
		Dim args(5) As Object
		Dim returnValue As Object = Nothing
		Dim retLong As Integer
		Dim frmArgs As New frmArguments
		
		On Error GoTo ErrorHandler 
		
		AssignProperties()
		
		Dim rs As ADODB.Recordset = Nothing
		Dim frm As New frmRecordset
		Select Case index
		Case 0
			args(0) = txtConnectionString.Text
			If frmArgs.GetArgValues("Open", args, "ConnectionString", "@UserID", "@Password", "@Options") Then 
				action = "open the connection"
				If IsMissing6(args(1)) Then  args(1) = ""
				If IsMissing6(args(2)) Then  args(2) = ""
				If IsMissing6(args(3)) Then  args(3) = 0
				cn.Open(args(0), args(1), args(2), args(3))
			End If
		Case 1
			action = "close the connection"
			cn.Close()
		Case 2
			action = "begin the transation"
			returnValue = cn.BeginTrans()
		Case 3
			action = "commit the transaction"
			cn.CommitTrans()
		Case 4
			action = "rollback the transaction"
			cn.RollbackTrans()
		Case 5
			args(1) = 0
			If frmArgs.GetArgValues("Execute", args, "CommandText", "Options") Then 
				action = "execute"
				If MsgBox6("Does this method return a recordset?", MsgBoxStyle.YesNo, "Execute method") = MsgBoxResult.No Then 
					cn.Execute(args(0), retLong, args(2))
				Else
					rs = cn.Execute(args(0), retLong, args(1))
					If Not (rs Is Nothing) Then 
						frm.rs = rs
						frm.Show(, Me)
					End If
				End If
				If retLong Then 
					MsgBox6("Records Affected = " & retLong, MsgBoxStyle.Information)
				End If
			End If
		Case 6
			action = "cancel the command"
			cn.Cancel()
		End Select
		
		ShowProperties()
		If Not IsEmpty6(returnValue) Then 
			On Error Resume Next 
			MsgBox6("Return Value = " & returnValue, MsgBoxStyle.Information, cmdMethod(index).Name & " Method")
		End If
		
		Exit Sub
		
ErrorHandler:
		MsgBox6("Unable to " & action & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
		
	End Sub

	'------------------------------------
	' Event procedures
	'------------------------------------
	
	Private Sub cn_BeginTransComplete(ByVal TransactionLevel As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.BeginTransComplete
		ShowEvent(txtEvents, "BeginTransComplete", "TransactionLevel", TransactionLevel)
	End Sub

	Private Sub cn_CommitTransComplete(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.CommitTransComplete
		ShowEvent(txtEvents, "CommitTransComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_ConnectComplete(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.ConnectComplete
		ShowEvent(txtEvents, "ConnectComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_Disconnect(ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.Disconnect
		ShowEvent(txtEvents, "Disconnect", "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_ExecuteComplete(ByVal RecordsAffected As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection) Handles cn.ExecuteComplete
		ShowEvent(txtEvents, "ExecuteComplete", "RecordsAffected", RecordsAffected, "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_InfoMessage(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.InfoMessage
		ShowEvent(txtEvents, "InfoMessage", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_RollbackTransComplete(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.RollbackTransComplete
		ShowEvent(txtEvents, "RollbackTransComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_WillConnect(ByRef ConnectionString As String, ByRef UserID As String, ByRef Password As String, ByRef Options As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles cn.WillConnect
		ShowEvent(txtEvents, "WillConnect", "ConnectionString", ConnectionString, "UserID", UserID, "Password", Password, "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub cn_WillExecute(ByRef Source As String, ByRef CursorType As ADODB.CursorTypeEnum, ByRef LockType As ADODB.LockTypeEnum, ByRef Options As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection) Handles cn.WillExecute
		ShowEvent(txtEvents, "WillExecute", "Source", Source, "CursorType", CursorType, "LockType", LockType, "Options", Options, "adStatus", GetStatus(adStatus)) ', "Recordset", Recordset
	End Sub

End Class
