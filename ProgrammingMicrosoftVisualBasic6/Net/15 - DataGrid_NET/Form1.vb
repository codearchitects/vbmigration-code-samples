' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' IMPORTANT: ensure that the following constant points
	' to the NWind database
	Private Const DB_PATH As String = "c:\program files\Microsoft Visual Studio\vb98\nwind.mdb"
	
	' These object serve to format lookup fields on the fly.
	Private WithEvents SupplierFormat As VB6StdDataFormat
	Private WithEvents CategoryFormat As VB6StdDataFormat
	' This variable serves to workaround the BeforeColUpdate bug.
	Private newValue As Object
	
	Private Sub Form_Load() Handles MyBase.Load
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
		Adodc1.Refresh()
		
		' prepare the grid to host the combobox controls.
		DataGrid1.RowHeight = cboSuppliers.Height
		
		' load the two combobox controls with the lookup data.
		Dim rs As New ADODB.RecordsetClass
		' The Suppliers table.
		rs.Open("Suppliers", Adodc1.Recordset.ActiveConnection, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdTable)
		Do Until rs.EOF
			cboSuppliers.AddItem(rs.Fields("CompanyName").Value)
			cboSuppliers.ItemData(cboSuppliers.NewIndex) = rs.Fields("SupplierID").Value
			rs.MoveNext()
		Loop
		rs.Close()
		' The Categories table.
		rs.Open("Categories", Adodc1.Recordset.ActiveConnection, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdTable)
		Do Until rs.EOF
			cboCategories.AddItem(rs.Fields("CategoryName").Value)
			cboCategories.ItemData(cboCategories.NewIndex) = rs.Fields("CategoryID").Value
			rs.MoveNext()
		Loop
		rs.Close()
		
		' Prepare two StdDataFormat objects
		SupplierFormat = New VB6StdDataFormat()
		DataGrid1.Columns("Supplier").DataFormat = ToStdDataFormat6(SupplierFormat)
		
		CategoryFormat = New VB6StdDataFormat()
		DataGrid1.Columns("Category").DataFormat = ToStdDataFormat6(CategoryFormat)
		
		' Put the grid in front of the two combobox controls.
		DataGrid1.ZOrder()
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		lblStatus.Width = ScaleWidth - lblStatus.Left
		DataGrid1.Move(0, DataGrid1.Top, ScaleWidth, ScaleHeight - DataGrid1.Top)
	End Sub

	Private Sub SupplierFormat_Format(ByVal DataValue As VB6StdDataValue) Handles SupplierFormat.FormatEvent6
		' Convert a SupplierID into a Supplier name.
		Dim i As Integer
		For i = 0 To cboSuppliers.ListCount - 1
			If cboSuppliers.ItemData(i) = DataValue.Value Then 
				DataValue.Value = cboSuppliers.List(i)
				Exit For
			End If
		Next
	End Sub

	Private Sub CategoryFormat_Format(ByVal DataValue As VB6StdDataValue) Handles CategoryFormat.FormatEvent6
		' Convert a CategoryID into a category name.
		Dim i As Integer
		For i = 0 To cboCategories.ListCount - 1
			If cboCategories.ItemData(i) = DataValue.Value Then 
				DataValue.Value = cboCategories.List(i)
				Exit For
			End If
		Next
	End Sub

	Private Sub cboSuppliers_Click() Handles cboSuppliers.Click
		' Change the value of the underlying grid cell.
		DataGrid1.Columns("Supplier").Value = cboSuppliers.ItemData(cboSuppliers.ListIndex)
	End Sub

	Private Sub cboCategories_Click() Handles cboCategories.Click
		' Change the value of the underlying grid cell.
		DataGrid1.Columns("Category").Value = cboCategories.ItemData(cboCategories.ListIndex)
	End Sub

	Private Sub MoveCombos()
		' In case of error put the combobox outof sight.
		On Error GoTo Error_Handler 
		
		' Start by hiding both comboboxes
		If DataGrid1.Visible Then 
			DataGrid1.ZOrder()
			DataGrid1.SetFocus()
		End If
		
		' Get a reference to the current column.
		Dim gridCol As CodeArchitects.VB6LibraryOcx.VB6DataGridColumn = DataGrid1.Columns(DataGrid1.Col)
		
		If Not DataGrid1.CurrentCellVisible Then 
			' do nothing if current cell isn't visible
		ElseIf gridCol.Caption = "Supplier" Then 
			' Move the combobox inside the SupplierID column
			cboSuppliers.Move(DataGrid1.Left + gridCol.Left, DataGrid1.Top + DataGrid1.RowTop(DataGrid1.Row), gridCol.Width)
			cboSuppliers.ZOrder()
			cboSuppliers.SetFocus()
			cboSuppliers.Text = gridCol.Text
			Exit Sub
		ElseIf gridCol.Caption = "Category" Then 
			' Move the combobox inside the SupplierID column
			cboCategories.Move(DataGrid1.Left + gridCol.Left, DataGrid1.Top + DataGrid1.RowTop(DataGrid1.Row), gridCol.Width)
			cboCategories.ZOrder()
			cboCategories.SetFocus()
			cboCategories.Text = gridCol.Text
			Exit Sub
		End If
Error_Handler:
		
	End Sub

	Private Sub DataGrid1_RowColChange(ByRef LastRow As Object, ByVal LastCol As Short) Handles DataGrid1.RowColChange
		MoveCombos()
	End Sub

	Private Sub DataGrid1_RowResize(ByRef Cancel As Short) Handles DataGrid1.RowResize
		MoveCombos()
	End Sub

	Private Sub DataGrid1_ColResize(ByVal ColIndex As Short, ByRef Cancel As Short) Handles DataGrid1.ColResize
		MoveCombos()
	End Sub

	Private Sub DataGrid1_Scroll(ByRef Cancel As Short) Handles DataGrid1.Scroll6
		MoveCombos()
	End Sub

	Private Sub DataGrid1_SplitChange() Handles DataGrid1.SplitChange
		MoveCombos()
	End Sub

	Private Sub DataGrid1_BeforeColUpdate(ByVal ColIndex As Short, ByRef OldValue As Object, ByRef Cancel As Short) Handles DataGrid1.BeforeColUpdate
		' ensure that no duplicate product name is entered
		Dim rs As ADODB.Recordset = Nothing
		If DataGrid1.Columns(DataGrid1.Col).DataField = "ProductName" Then 
			' Get a clone recordset
			rs = Adodc1.Recordset.Clone(ADODB.LockTypeEnum.adLockReadOnly)
			rs.MoveFirst()
			' see if this value is already in the recordset.
			' (NewValue is set in Change event)
			rs.Find("ProductName='" & newValue & "'")
			If Not rs.EOF Then 
				MsgBox6("This product is already in the list", MsgBoxStyle.Critical)
				Cancel = CShort(True)
			End If
		End If
		
	End Sub

	Private Sub DataGrid1_Change() Handles DataGrid1.Change
		' remember the last value edited (will be used in BeforeColUpdate)
		newValue = DataGrid1.Text
	End Sub

	Private Sub cmdSplit_Click() Handles cmdSplit.Click
		' create two splits, one with only the Product Name column
		' and one with all the others
		' UPGRADE_INFO (#0501): The 'i' member isn't used anywhere in current application.
		Dim i As Short
		Dim gridCol As CodeArchitects.VB6LibraryOcx.VB6DataGridColumn = Nothing
		
		' Create a new split to the left of the existing split
		With DataGrid1.Splits.Add(0)
			' make its width the same as the ProductName column
			.SizeMode = MSDataGridLib.SplitSizeModeConstants.dbgExact
			.Size = .Columns("ProductName").Width
			' make all columns invisible but ProductName.
			For Each gridCol In .Columns
				gridCol.Visible = (gridCol.Caption = "ProductName")
			Next
			' Hide the vertical scrollbar
			.ScrollBars = MSDataGridLib.ScrollBarsConstants.dbgHorizontal
		End With
		
		With DataGrid1.Splits(1)
			' Delete the Productname column in the rightmost split by making it invisible.
			.Columns("ProductName").Visible = False
			' Hide Record selectors
			.RecordSelectors = False
		End With
		
		' disable this button, so that no more splits can be created.
		cmdSplit.Enabled = False
		
	End Sub

	Private Sub DataGrid1_BeforeDelete(ByRef Cancel As Short) Handles DataGrid1.BeforeDelete
		' Refuse to delete a product if there is one OrderDetail record
		' that points to it
		Dim rs As ADODB.Recordset = Nothing
		Dim rsorderdetail As ADODB.Recordset = Nothing
		Dim sql As String = ""
		' Retrieve all the records in OrderDetails that reference this product.
		rs = Adodc1.Recordset
		sql = "Select * FROM [Order Details] WHERE [Order Details].ProductID = " & rs.Fields("ProductID").Value
		rsorderdetail = rs.ActiveConnection.Execute(sql)
		' if this recordset contains any record, refuse to delete.
		If Not rsorderdetail.EOF Then  Cancel = CShort(True)
	End Sub

	Private Sub DataGrid1_Error(ByVal DataError As Short, ByRef Response As Short) Handles DataGrid1.Error
		' Display a custom error message
		MsgBox6("Error code: " & DataError & ControlChars.Cr & ControlChars.Cr & DataGrid1.ErrorText, MsgBoxStyle.Critical)
		Response = 0
	End Sub

	Private Sub DataGrid1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles DataGrid1.MouseMove6
		' Display a tooltip with the contents of the current cell
		Dim row As Integer
		Dim col As Integer
		' UPGRADE_INFO (#0501): The 'value' member isn't used anywhere in current application.
		Dim value As Object = Nothing
		On Error Resume Next 
		
		' Get the coordinates of the cell under the mouse cursor.
		row = DataGrid1.RowContaining(Y)
		col = DataGrid1.ColContaining(X)
		If row >= 0 And col >= 0 Then 
			' Set the tooltip text if within the grid boundaries.
			DataGrid1.ToolTipText = DataGrid1.Columns(col).CellValue(DataGrid1.RowBookmark(row))
		Else
			' Otherwise, clear the tooltip.
			DataGrid1.ToolTipText = ""
		End If
	End Sub

	Private Sub DataGrid1_SelChange(ByRef Cancel As Short) Handles DataGrid1.SelChange
		Dim rs As ADODB.Recordset = Nothing
		Dim bmark As Object = Nothing
		Dim count As Integer
		Dim unitsInStock As Integer
		Dim unitsOnOrder As Integer
		
		rs = Adodc1.Recordset.Clone(ADODB.LockTypeEnum.adLockReadOnly)
		count = DataGrid1.SelBookmarks.count
		
		If count = 0 Then 
			lblStatus.Caption = "No records selected"
		Else
			For Each bmark In DataGrid1.SelBookmarks
				rs.Bookmark = bmark
				unitsInStock += rs.Fields("unitsInStock").Value
				unitsOnOrder += rs.Fields("unitsOnOrder").Value
			Next
			lblStatus.Caption = count & " product(s) selected     UnitsInStock =" & unitsInStock & "       UnitsOnOrder =" & unitsOnOrder
		End If
	End Sub

	Private Sub DataGrid1_HeadClick(ByVal ColIndex As Short) Handles DataGrid1.HeadClick
		' You can't sort on lookup fields.
		Select Case DataGrid1.Columns(ColIndex).Caption
		Case "Supplier", "Category"
			MsgBox6("Sorry, can't sort on this field", MsgBoxStyle.Exclamation)
			Exit Sub
		End Select
		
		' Sort on the clicked column
		Dim rs As ADODB.Recordset = Adodc1.Recordset
		
		If rs.Sort <> DataGrid1.Columns(ColIndex).DataField & " ASC" Then 
			' Sort in ascending order - this block is executed if the
			' grid isn't sorted, is sorted on a different field
			' or is sorted in descending order
			rs.Sort = DataGrid1.Columns(ColIndex).DataField & " ASC"
		Else
			' Sort in descending order
			rs.Sort = DataGrid1.Columns(ColIndex).DataField & " DESC"
		End If
		' no need refresh the contents of the Datagrid
	End Sub

End Class
