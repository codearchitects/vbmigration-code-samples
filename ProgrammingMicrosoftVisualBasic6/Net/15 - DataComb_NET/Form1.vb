' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' IMPORTANT: ensure that the DB_PATH constant is pointing to the
	' NWind.mdb database on your system
	Private Const DB_PATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
	
	Private rsCategories As New ADODB.RecordsetClass
	Private rsSuppliers As New ADODB.RecordsetClass
	
	Private ValidationError As Boolean

	Private Sub Form_Load() Handles MyBase.Load
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
		Adodc1.Refresh()
		
		rsCategories.Open("Categories", Adodc1.Recordset.ActiveConnection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		DataList1.RowSource = rsCategories
		rsSuppliers.Open("Suppliers", Adodc1.Recordset.ActiveConnection, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
		DataCombo1.RowSource = rsSuppliers
		ShowSupplierInfo()
		
		' Start a transaction
		Adodc1.Recordset.ActiveConnection.BeginTrans
	End Sub

	Private Sub Adodc1_Error(ByVal ErrorNumber As Integer, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef fCancelDisplay As Boolean) Handles Adodc1.Error
		' Don't show validation errors.
		If ValidationError Then 
			fCancelDisplay = True
			ValidationError = False
		End If
	End Sub

	Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles Adodc1.MoveComplete
		' force the update of the DataCombo control
		On Error Resume Next 
		DataCombo1.BoundText = Adodc1.Recordset.Fields("SupplierID").Value
		ShowSupplierInfo()
	End Sub

	Private Sub Adodc1_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles Adodc1.WillChangeRecord
		' Check that all fields are valid.
		If txtProductName.Text = "" Or Not IsNumeric6(txtUnitPrice.Text) Or Not IsNumeric6(txtUnitsInStock.Text) Or Not IsNumeric6(txtUnitsOnOrder.Text) Then 
			MsgBox6("Please enter valid field values", MsgBoxStyle.Exclamation)
			ValidationError = True
			adStatus = ADODB.EventStatusEnum.adStatusCancel
		End If
		
		' Nothing else to do if data in DataCombo hasn't been modified
		' or if it matches an item in the list
		If Not DataCombo1.DataChanged Or DataCombo1.MatchedWithList Then  Exit Sub
		
		' Ask if the user wants to add a new supplier, exit if not.
		If MsgBox6("Supplier not found." & ControlChars.Cr & "Do you want to add a new supplier?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.No Then 
			ValidationError = True
			adStatus = ADODB.EventStatusEnum.adStatusCancel
		End If
		
		' Add a new record to the recordset. In a real application you should
		' display a complete data entry form.
		rsSuppliers.AddNew("CompanyName", DataCombo1.Text)
		rsSuppliers.Update()
		' Ensure that the new record is visible in the recordset.
		rsSuppliers.Requery()
		rsSuppliers.Find("CompanyName = '" & DataCombo1.Text & "'")
		' Refill the DataCombo and make the correct item the current one.
		DataCombo1.Refill()
		DataCombo1.BoundText = rsSuppliers.Fields("SupplierID").Value
		
	End Sub

	Private Sub DataCombo1_Click(ByRef Area As Short) Handles DataCombo1.Click
		' Move to the correct record in the lookup table.
		' NOTE: the ContactName field must be included in the list
		'       of fields returned by the Adodc3 data control.
		ShowSupplierInfo()
	End Sub

	Private Sub cmdAddNew_Click() Handles cmdAddNew.Click
		Adodc1.Recordset.AddNew()
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		Adodc1.Recordset.Delete()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		If MsgBox6("Do you confirm changes to records?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then 
			Adodc1.Recordset.ActiveConnection.CommitTrans
		Else
			Adodc1.Recordset.ActiveConnection.RollbackTrans
			Adodc1.Refresh()
		End If
	End Sub

	Private Sub ShowSupplierInfo()
		On Error Resume Next 
		rsSuppliers.Bookmark = DataCombo1.SelectedItem
		lblSupplierData.Caption = rsSuppliers.Fields("ContactName").Value
		If Err.Number Then  lblSupplierData.Caption = ""
	End Sub

	Private Sub DataList1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles DataList1.MouseMove
		' Determine over which item the mouse cursor is.
		Dim item As Integer = Int(y / DataList1.Height * DataList1.VisibleCount)
		' Retrieve the description for the category under the cursor and
		' prepare a tooltip, in case the user doesn't move the mouse.
		rsCategories.Bookmark = DataList1.VisibleItems(item)
		DataList1.ToolTipText = rsCategories.Fields("Description").Value
	End Sub

End Class
