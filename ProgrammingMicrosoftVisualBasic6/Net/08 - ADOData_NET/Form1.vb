' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' IMPORTANT: ensure that the DB_PATH constant is pointing to the
	' NWind.mdb database on your system
	Private Const DB_PATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
	
	Private DataHasChanged As Boolean
	Private AddNewMode As Boolean
	Private ValidationError As Boolean
	
	' Form Events
	
	Private Sub Form_Load() Handles MyBase.Load
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
		Adodc1.Refresh()
		
		' Start a transaction
		Adodc1.Recordset.ActiveConnection.BeginTrans
		' disable the Update/CancelUpdate buttons
		ChangedData(False)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If Not DataHasChanged Then 
			' no record was changed, do nothing
		ElseIf MsgBox6("Do you confirm changes to records?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then 
			Adodc1.Recordset.ActiveConnection.CommitTrans
		Else
			Adodc1.Recordset.ActiveConnection.RollbackTrans
			Adodc1.Refresh()
		End If
	End Sub

	' ADO Data control events.
	
	Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles Adodc1.MoveComplete
		' disable the Update/CancelUpdate buttons when user moves on a new record.
		ChangedData(False)
		AddNewMode = False
	End Sub

	Private Sub Adodc1_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles Adodc1.WillChangeRecord
		' Check that all fields are valid.
		If txtProductName.DataChanged And txtProductName.Text = "" Then 
			ValidationError = True
		ElseIf txtUnitPrice.DataChanged And Not IsNumeric6(txtUnitPrice.Text) Then 
			ValidationError = True
		ElseIf txtUnitsOnOrder.DataChanged And Not IsNumeric6(txtUnitsOnOrder.Text) Then 
			ValidationError = True
		End If
		
		If ValidationError Then 
			MsgBox6("Please enter valid field values", MsgBoxStyle.Exclamation)
			adStatus = ADODB.EventStatusEnum.adStatusCancel
		Else
			' Remember that at least one record has changed.
			DataHasChanged = True
		End If
	End Sub

	Private Sub Adodc1_Error(ByVal ErrorNumber As Integer, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef fCancelDisplay As Boolean) Handles Adodc1.Error
		' Don't show validation errors.
		If ValidationError Then 
			fCancelDisplay = True
			ValidationError = False
		End If
	End Sub

	' Button actions.
	
	Private Sub cmdAddNew_Click() Handles cmdAddNew.Click
		On Error Resume Next 
		Adodc1.Recordset.AddNew()
		If Err.Number Then 
			MsgBox6("Error " & Err.Number & ControlChars.Cr & Err.Description, MsgBoxStyle.Critical)
		Else
			txtProductName.SetFocus()
			cmdCancel.Enabled = True
			AddNewMode = True
		End If
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		On Error GoTo Error_Handler 
		With Adodc1.Recordset
			.Delete()
			.MoveNext()
			If .EOF And Not .BOF Then  .MoveLast()
		End With
		Exit Sub
		
Error_Handler:
		MsgBox6("Error " & Err.Number & ControlChars.Cr & Err.Description, MsgBoxStyle.Critical)
		
	End Sub

	Private Sub cmdUpdate_Click() Handles cmdUpdate.Click
		Adodc1.Recordset.Update()
		ChangedData(False)
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		' Cancel edit to current record.
		Adodc1.Recordset.CancelUpdate()
		ChangedData(False)
	End Sub

	Private Sub txtProductName_Change() Handles txtProductName.Change
		If txtProductName.DataChanged Then  ChangedData()
	End Sub

	Private Sub txtUnitPrice_Change() Handles txtUnitPrice.Change
		If txtUnitPrice.DataChanged Then  ChangedData()
	End Sub

	Private Sub txtUnitsInStock_Change() Handles txtUnitsInStock.Change
		If txtUnitsInStock.DataChanged Then  ChangedData()
	End Sub

	Private Sub txtUnitsOnOrder_Change() Handles txtUnitsOnOrder.Change
		If txtUnitsOnOrder.DataChanged Then  ChangedData()
	End Sub

	Private Sub chkDiscontinued_Click() Handles chkDiscontinued.Click
		If chkDiscontinued.DataChanged Then  ChangedData()
	End Sub

	' Update the status of the Update/CancelUpdate
	Public Sub ChangedData(Optional ByRef newStatus As Boolean = True)
	' UPGRADE_INFO (#0551): The 'newStatus' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		cmdUpdate.Enabled = newStatus
		cmdCancel.Enabled = newStatus
	End Sub

End Class
