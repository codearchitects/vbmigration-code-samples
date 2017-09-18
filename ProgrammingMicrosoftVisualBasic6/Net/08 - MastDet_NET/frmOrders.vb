' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmOrders

	Private Sub Form_Load() Handles MyBase.Load
		grdDataGrid.DataSource = datPrimaryRS.Recordset.Fields("ChildCMD").UnderlyingValue
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		'This will resize the grid when the form is resized
		grdDataGrid.Width = Me.ScaleWidth
		grdDataGrid.Height = Me.ScaleHeight - grdDataGrid.Top - datPrimaryRS.Height - 30 - picButtons.Height
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
		Screen6.MousePointer = VBRUN.MousePointerConstants.vbDefault
	End Sub

	Private Sub datPrimaryRS_Error(ByVal ErrorNumber As Integer, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef fCancelDisplay As Boolean) Handles datPrimaryRS.Error
		'This is where you would put error handling code
		'If you want to ignore errors, comment out the next line
		'If you want to trap them, add code here to handle them
		MsgBox6("Data error event hit err:" & Description)
	End Sub

	Private Sub datPrimaryRS_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles datPrimaryRS.MoveComplete
		'This will display the current record position for this recordset
		datPrimaryRS.Caption = "Record: " & CStr(datPrimaryRS.Recordset.AbsolutePosition)
	End Sub

	Private Sub datPrimaryRS_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles datPrimaryRS.WillChangeRecord
		'This is where you put validation code
		'This event gets called when the following actions occur
		Dim bCancel As Boolean
		
		Select Case adReason
		Case ADODB.EventReasonEnum.adRsnAddNew
		Case ADODB.EventReasonEnum.adRsnClose
		Case ADODB.EventReasonEnum.adRsnDelete
		Case ADODB.EventReasonEnum.adRsnFirstChange
		Case ADODB.EventReasonEnum.adRsnMove
		Case ADODB.EventReasonEnum.adRsnRequery
		Case ADODB.EventReasonEnum.adRsnResynch
		Case ADODB.EventReasonEnum.adRsnUndoAddNew
		Case ADODB.EventReasonEnum.adRsnUndoDelete
		Case ADODB.EventReasonEnum.adRsnUndoUpdate
		Case ADODB.EventReasonEnum.adRsnUpdate
		End Select
		
		If bCancel Then  adStatus = ADODB.EventStatusEnum.adStatusCancel
	End Sub

	Private Sub cmdRefresh_Click() Handles cmdRefresh.Click
		'This is only needed for multi user apps
		On Error GoTo RefreshErr 
		datPrimaryRS.Refresh()
		grdDataGrid.DataSource = datPrimaryRS.Recordset.Fields("ChildCMD").UnderlyingValue
		
		Exit Sub
RefreshErr:
		MsgBox6(Err.Description)
	End Sub

	Private Sub cmdUpdate_Click() Handles cmdUpdate.Click
		On Error GoTo UpdateErr 
		
		datPrimaryRS.Recordset.UpdateBatch(ADODB.AffectEnum.adAffectAll)
		Exit Sub
UpdateErr:
		MsgBox6(Err.Description)
	End Sub

	Private Sub cmdClose_Click() Handles cmdClose.Click
		Unload6(Me)
	End Sub

End Class
