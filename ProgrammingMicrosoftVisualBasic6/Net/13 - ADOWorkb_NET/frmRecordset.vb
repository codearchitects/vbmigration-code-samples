' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRecordset

	Public WithEvents rs As ADODB.Recordset
	Private frmFields As frmFields
	Private frmRecords As frmRecords
	
	Private Sub Form_Load() Handles MyBase.Load
		If rs Is Nothing Then 
			rs = New ADODB.Recordset()
		End If
		'rs.ActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=e:\Microsoft Visual Studio\Vb98\Nwind.mdb"
		'rs.Source = "Employees"
		
		InitFields()
		ShowProperties()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If Not (frmFields Is Nothing) Then  Unload6(frmFields)
		If Not (frmRecords Is Nothing) Then  Unload6(frmRecords)
	End Sub

	Private Sub lstCustomProperties_Click() Handles lstCustomProperties.Click
		txtCustomProperty.Text = GetCustomPropertyValue(rs, lstCustomProperties)
		cmdSet.Enabled = CustomPropertyIsWriteable(rs, lstCustomProperties)
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		SetCustomPropertyValue(rs, lstCustomProperties, txtCustomProperty.Text)
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
		AddToCombo(cboCursorLocation, "adUseServer", ADODB.CursorLocationEnum.adUseServer)
		AddToCombo(cboCursorLocation, "adUseClient", ADODB.CursorLocationEnum.adUseClient)
		
		AddToCombo(cboCursorType, "adOpenForwardOnly", ADODB.CursorTypeEnum.adOpenForwardOnly)
		AddToCombo(cboCursorType, "adOpenKeyset", ADODB.CursorTypeEnum.adOpenKeyset)
		AddToCombo(cboCursorType, "adOpenDynamic", ADODB.CursorTypeEnum.adOpenDynamic)
		AddToCombo(cboCursorType, "adOpenStatic", ADODB.CursorTypeEnum.adOpenStatic)
		
		AddToCombo(cboLockType, "adLockReadOnly", ADODB.LockTypeEnum.adLockReadOnly)
		AddToCombo(cboLockType, "adLockPessimistic", ADODB.LockTypeEnum.adLockPessimistic)
		AddToCombo(cboLockType, "adLockOptimistic", ADODB.LockTypeEnum.adLockOptimistic)
		AddToCombo(cboLockType, "adLockBatchOptimistic", ADODB.LockTypeEnum.adLockBatchOptimistic)
		
		AddToCombo(cboAbsolutePage, "adPosUnknown", ADODB.PositionEnum.adPosUnknown)
		AddToCombo(cboAbsolutePage, "adPosBOF", ADODB.PositionEnum.adPosBOF)
		AddToCombo(cboAbsolutePage, "adPosEOF", ADODB.PositionEnum.adPosEOF)
		
		AddToCombo(cboAbsolutePosition, "adPosUnknown", ADODB.PositionEnum.adPosUnknown)
		AddToCombo(cboAbsolutePosition, "adPosBOF", ADODB.PositionEnum.adPosBOF)
		AddToCombo(cboAbsolutePosition, "adPosEOF", ADODB.PositionEnum.adPosEOF)
		
		AddToCombo(cboBOF, "False", CShort(False))
		AddToCombo(cboBOF, "True", CShort(True))
		
		AddToCombo(cboEditMode, "adEditNone", ADODB.EditModeEnum.adEditNone)
		AddToCombo(cboEditMode, "adEditInProgress", ADODB.EditModeEnum.adEditInProgress)
		AddToCombo(cboEditMode, "adEditAdd", ADODB.EditModeEnum.adEditAdd)
		AddToCombo(cboEditMode, "adEditDelete", ADODB.EditModeEnum.adEditDelete)
		
		AddToCombo(cboEOF, "False", CShort(False))
		AddToCombo(cboEOF, "True", CShort(True))
		
		AddToCombo(cboState, "adStateClosed", ADODB.ObjectStateEnum.adStateClosed)
		AddToCombo(cboState, "adStateOpen", ADODB.ObjectStateEnum.adStateOpen)
		AddToCombo(cboState, "adStateConnecting", ADODB.ObjectStateEnum.adStateConnecting)
		AddToCombo(cboState, "adStateExecuting", ADODB.ObjectStateEnum.adStateExecuting)
		AddToCombo(cboState, "adStateFetching", ADODB.ObjectStateEnum.adStateFetching)
		
	End Sub

	' Refresh the contents of the property fields.
	
	Public Sub ShowProperties()
		ShowProperty(rs, txtActiveConnection)
		ShowProperty(rs, txtCacheSize)
		ShowProperty(rs, cboCursorLocation)
		ShowProperty(rs, cboCursorType)
		ShowProperty(rs, txtFilter)
		ShowProperty(rs, cboLockType)
		ShowProperty(rs, txtMaxRecords)
		ShowProperty(rs, txtSort)
		ShowProperty(rs, txtSource)
		ShowProperty(rs, cboAbsolutePage)
		ShowProperty(rs, cboAbsolutePosition)
		ShowProperty(rs, cboBOF)
		ShowProperty(rs, txtBookmark)
		ShowProperty(rs, cboEditMode)
		ShowProperty(rs, cboEOF)
		ShowProperty(rs, txtPageCount)
		ShowProperty(rs, txtPageSize)
		ShowProperty(rs, txtRecordCount)
		ShowProperty(rs, cboState)
		
		cmdSet.Enabled = True
		ShowCustomProperties(rs, lstCustomProperties)
		
		cmdShowFields.Enabled = (rs.State And ADODB.ObjectStateEnum.adStateOpen)
		cmdShowRecords.Enabled = (rs.State And ADODB.ObjectStateEnum.adStateOpen)
	End Sub

	' Assign current values in fields to properties
	
	Public Sub AssignProperties()
		AssignProperty(rs, txtActiveConnection)
		AssignProperty(rs, txtCacheSize)
		AssignProperty(rs, cboCursorLocation)
		AssignProperty(rs, cboCursorType)
		AssignProperty(rs, txtFilter)
		AssignProperty(rs, cboLockType)
		AssignProperty(rs, txtMaxRecords)
		AssignProperty(rs, txtSort)
		AssignProperty(rs, txtSource)
		AssignProperty(rs, cboAbsolutePage)
		AssignProperty(rs, cboAbsolutePosition)
		AssignProperty(rs, txtBookmark)
	End Sub

	Private Sub cmdMethod_Click(ByRef Index As Short)
		Dim action As String = ""
		Dim args(5) As Object
		Dim returnValue As Object = Nothing
		Dim retLong As Integer
		Dim frmArgs As New frmArguments
		
		On Error GoTo ErrorHandler 
		
		AssignProperties()
		
		Dim frm As New frmRecordset
		Select Case Index
		Case 0
			action = "open the recordset"
			args(0) = txtSource.Text
			args(1) = txtActiveConnection.Text
			If frmArgs.GetArgValues("Open", args, "@Source", "@ActiveConnection", "@CursorType", "@LockType", "@Options") Then 
				If IsMissing6(args(0)) Then  args(0) = txtSource.Text
				If IsMissing6(args(1)) Then  args(1) = txtActiveConnection.Text
				If IsMissing6(args(2)) Then  args(2) = GetComboValue(cboCursorType)
				If IsMissing6(args(3)) Then  args(3) = GetComboValue(cboLockType)
				If IsMissing6(args(4)) Then  args(4) = 0
				rs.Open(args(0), args(1), args(2), args(3), args(4))
			End If
		Case 1
			action = "close the recordset"
			rs.Close()
		Case 2
			action = "add a new record"
			rs.AddNew()
		Case 3
			action = "delete the current record"
			If frmArgs.GetArgValues("Delete", args, "@AffectRecords") Then 
				If IsMissing6(args(0)) Then  args(0) = ADODB.AffectEnum.adAffectCurrent
				rs.Delete(args(0))
			End If
		Case 4
			action = "cancel the current operation"
			rs.Cancel()
		Case 5
			action = "cancel the current batch operation"
			If frmArgs.GetArgValues("Delete", args, "@AffectRecords") Then 
				If IsMissing6(args(0)) Then  args(0) = ADODB.AffectEnum.adAffectCurrent
				rs.CancelBatch(args(0))
			End If
		Case 6
			action = "cancel the current update operation"
			rs.CancelUpdate()
		Case 7
			action = "move to the first record"
			rs.MoveFirst()
		Case 8
			action = "move to the previous record"
			rs.MovePrevious()
		Case 9
			action = "move to the next record"
			rs.MoveNext()
		Case 10
			action = "move to the last record"
			rs.MoveLast()
		Case 11
			action = "move to the specified record"
			If frmArgs.GetArgValues("Move", args, "NumRecords", "@Start") Then 
				If IsMissing6(args(1)) Then  args(1) = ADODB.BookmarkEnum.adBookmarkCurrent
				rs.Move(args(0))
			End If
		Case 12
			action = "clone the recordset"
			If frmArgs.GetArgValues("Clone", args, "@LockType") Then 
				If IsMissing6(args(0)) Then  args(0) = GetComboValue(cboLockType)
				frm.rs = rs.Clone()
				frm.Show()
			End If
		Case 13
			action = "find a value"
			If frmArgs.GetArgValues("Find", args, "Criteria", "@SkipRecords", "@SearchDirection", "@Start") Then 
				If IsMissing6(args(1)) Then  args(1) = 0
				If IsMissing6(args(2)) Then  args(2) = ADODB.SearchDirection.adSearchForward
				If IsMissing6(args(3)) Then  args(3) = ADODB.BookmarkEnum.adBookmarkCurrent
				rs.Find(args(0), args(1), args(2), args(3))
			End If
		Case 14
			action = "update the recordset"
			rs.Update()
		Case 15
			action = "update the recordset in batch mode"
			If frmArgs.GetArgValues("UpdateBatch", args, "@AffectRecords") Then 
				If IsMissing6(args(0)) Then 
					rs.UpdateBatch()
				Else
					rs.UpdateBatch(args(0))
				End If
			End If
		Case 16
			action = "retrieve the next recordset"
			rs.NextRecordset(retLong)
			returnValue = retLong
		Case 17
			action = "requery the data source"
			If frmArgs.GetArgValues("Requery", args, "@Options") Then 
				If IsMissing6(args(0)) Then  args(0) = -1
				rs.Requery(args(0))
			End If
		Case 18
			action = "resync the recordset"
			If frmArgs.GetArgValues("Resync", args, "@AffectRecords", "@ResyncValues") Then 
				If IsMissing6(args(1)) Then  args(1) = ADODB.ResyncEnum.adResyncAllValues
				If IsMissing6(args(0)) Then 
					rs.Resync(, args(1))
				Else
					rs.Resync(args(0), args(1))
				End If
			End If
		Case 19
			action = "save the recordset"
			If frmArgs.GetArgValues("Save", args, "@Filename", "@PersistFormat") Then 
				If IsMissing6(args(1)) Then  args(1) = ADODB.PersistFormatEnum.adPersistADTG
				If IsMissing6(args(0)) Then 
					rs.Save()
				Else
					rs.Save(args(0), args(1))
				End If
			End If
		Case 20
			action = "test supported properties"
			If frmArgs.GetArgValues("Supports", args, "CursorOptions") Then 
				returnValue = rs.Supports(args(0))
			End If
		End Select
		
		ShowProperties()
		If Not IsEmpty6(returnValue) Then 
			On Error Resume Next 
			MsgBox6("Return Value = " & returnValue, MsgBoxStyle.Information, cmdMethod(Index).Name & " Method")
		End If
		
		Exit Sub
		
ErrorHandler:
		MsgBox6("Unable to " & action & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
		
	End Sub

	Private Sub cmdShowFields_Click() Handles cmdShowFields.Click
		On Error Resume Next 
		frmFields = New frmFields()
		frmFields.rs = rs
		frmFields.Show()
	End Sub

	Private Sub cmdShowRecords_Click() Handles cmdShowRecords.Click
		On Error Resume Next 
		frmRecords = New frmRecords()
		frmRecords.rs = rs
		frmRecords.Show()
	End Sub

	'------------------------------------
	' Event procedures
	'------------------------------------
	
	Private Sub rs_EndOfRecordset(ByRef fMoreData As Boolean, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.EndOfRecordset
		ShowEvent(txtEvents, "EndOfRecordset", "fMoreData", fMoreData, "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_FetchComplete(ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.FetchComplete
		ShowEvent(txtEvents, "FetchComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_FetchProgress(ByVal Progress As Integer, ByVal MaxProgress As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.FetchProgress
		ShowEvent(txtEvents, "FetchProgress", "Progress", Progress, "MaxProgress", MaxProgress, "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_FieldChangeComplete(ByVal cFields As Integer, ByVal Fields As Object, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.FieldChangeComplete
		ShowEvent(txtEvents, "FieldChangeComplete", "cFields", cFields, "Fields", "(array)", "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.MoveComplete
		ShowEvent(txtEvents, "MoveComplete", "adReason", GetReason(adReason), "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.RecordChangeComplete
		ShowEvent(txtEvents, "RecordChangeComplete", "adReason", GetReason(adReason), "cRecords", cRecords, "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_RecordsetChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.RecordsetChangeComplete
		ShowEvent(txtEvents, "RecordsetChangeComplete", "adReason", GetReason(adReason), "pError", GetError(pError), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_WillChangeField(ByVal cFields As Integer, ByVal Fields As Object, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.WillChangeField
		ShowEvent(txtEvents, "WillChangeField", "cFields", cFields, "Fields", "(array)", "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.WillChangeRecord
		ShowEvent(txtEvents, "WillChangeRecord", "adReason", GetReason(adReason), "cRecords", cRecords, "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_WillChangeRecordset(ByVal adReason As ADODB.EventReasonEnum, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.WillChangeRecordset
		ShowEvent(txtEvents, "WillChangeRecordset", "adReason", GetReason(adReason), "adStatus", GetStatus(adStatus))
	End Sub

	Private Sub rs_WillMove(ByVal adReason As ADODB.EventReasonEnum, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.WillMove
		ShowEvent(txtEvents, "WillMove", "adReason", GetReason(adReason), "adStatus", GetStatus(adStatus))
	End Sub

	Private Function GetReason(ByRef value As ADODB.EventReasonEnum) As String
		Select Case value
		Case ADODB.EventReasonEnum.adRsnAddNew
			Return "#adRsnAddNew"
		Case ADODB.EventReasonEnum.adRsnDelete
			Return "#adRsnDelete"
		Case ADODB.EventReasonEnum.adRsnUpdate
			Return "#adRsnUpdate"
		Case ADODB.EventReasonEnum.adRsnUndoUpdate
			Return "#adRsnUndoUpdate"
		Case ADODB.EventReasonEnum.adRsnUndoAddNew
			Return "#adRsnUndoAddNew"
		Case ADODB.EventReasonEnum.adRsnUndoDelete
			Return "#adRsnUndoDelete"
		Case ADODB.EventReasonEnum.adRsnRequery
			Return "#adRsnRequery"
		Case ADODB.EventReasonEnum.adRsnResynch
			Return "#adRsnResynch"
		Case ADODB.EventReasonEnum.adRsnClose
			Return "#adRsnClose"
		Case ADODB.EventReasonEnum.adRsnMove
			Return "#adRsnMove"
		Case ADODB.EventReasonEnum.adRsnFirstChange
			Return "#adRsnFirstChange"
		Case ADODB.EventReasonEnum.adRsnMoveFirst
			Return "#adRsnMoveFirst"
		Case ADODB.EventReasonEnum.adRsnMoveNext
			Return "#adRsnMoveNext"
		Case ADODB.EventReasonEnum.adRsnMovePrevious
			Return "#adRsnMovePrevious"
		Case ADODB.EventReasonEnum.adRsnMoveLast
			Return "#adRsnMoveLast"
		End Select
	End Function

End Class
