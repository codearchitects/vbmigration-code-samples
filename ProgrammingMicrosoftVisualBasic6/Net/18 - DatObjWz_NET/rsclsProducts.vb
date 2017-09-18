' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class rsclsProducts
	Implements IDisposable
	Implements IVB6DataSourceClass

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		Class_Initialize_VB6()
		' Add initialization code here
	End Sub
	
	#End Region

	'=============================================================
	'Name: rsclsProducts (a RecordSet class)
	'
	'Author: Microsoft Data Object Wizard
	'
	'Date: 01/05/1999 20:25
	'
	'Description: Contains RecordSet class used as a DataSource class
	'for a UserControl object.
	'
	'Comment: A new RecordSet class is created from the main 'Select' RecordSet class.
	'This RecordSet class is not connected to the database to allow for
	'(1) separate stored procedures for updates, inserts and deletes
	'and (2) control of update timing.
	'=============================================================
	
	Public SaveMode As EnumSaveMode 'Specifies either the Immediate or Batch mode Save property for the ResultSet class.
	
	'The Data Environment object contains all the data access commands.
	Private de1 As New DataEnvironment1
	
	'Create a new RecordSet class to hold the Foreign Key attributes,
	'    unless there are no Foreign Key attributes, then the Data Environment RecordSet class will be used.
	Private WithEvents rs As ADODB.Recordset
	'Variant to store system generated Primary Key values.
	Private vPKValues(,) As Object
	
	'Set the flag when record sets have been initialized.
	Private mbDataInitialized As Boolean
	'Flag to prohibit running the WillChangeRecord event.
	Private mbAddingRecord As Boolean
	'Flag to prohibit running the WillChangeRecord event when RecordSet class moves after the Delete method runs.
	Private mbDeleteInProgress As Boolean
	
	Private bInitComplete As Boolean 'Boolean flag is set when GetDataMember event is complete.
	'This event is run when the RecordSet Move method is complete.
	Public Event rsMoveComplete()
	'This event is run when the RecordSet Delete method is complete.
	Public Event DeleteRecordComplete()
	'This event is run when the rsUpdate method is complete.
	Public Event rsUpdateEvent(ByRef vFieldName As Object)
	'This event is run for certain class errors.
	Public Event ClassError(ByRef sProcedureName As String, ByRef oErr As ErrObject)
	
	' rsclsProducts Foreign Key RecordSet classes
	Public rsSuppliers As ADODB.Recordset
	Public rsCategories As ADODB.Recordset
	
	'Foreign Key Parameter properties for the RecordSet classes.
	
	'The external interface Get and Let properties.
	Public Property ProductID() As Object
		Get
			Return rs.Fields("ProductID").Value
	 	End Get
		Set(ByVal vProductID As Object)
			If IsNull6(vProductID) Then 
				rs.Fields("ProductID").Value = VB6Null
			Else
				rs.Fields("ProductID").Value = CInt(vProductID)
			End If
	 	End Set
	End Property

	Public Property ProductName() As Object
		Get
			Return rs.Fields("ProductName").Value
	 	End Get
		Set(ByVal vProductName As Object)
			If IsNull6(vProductName) Then 
				rs.Fields("ProductName").Value = VB6Null
			Else
				rs.Fields("ProductName").Value = CStr(vProductName)
			End If
	 	End Set
	End Property

	Public Property supplierid() As Object
		Get
			Return rs.Fields("SupplierID").Value
	 	End Get
		Set(ByVal vSupplierID As Object)
			If IsNull6(vSupplierID) Then 
				rs.Fields("SupplierID").Value = VB6Null
			Else
				rs.Fields("SupplierID").Value = CInt(vSupplierID)
			End If
	 	End Set
	End Property

	Public Property categoryid() As Object
		Get
			Return rs.Fields("CategoryID").Value
	 	End Get
		Set(ByVal vCategoryID As Object)
			If IsNull6(vCategoryID) Then 
				rs.Fields("CategoryID").Value = VB6Null
			Else
				rs.Fields("CategoryID").Value = CInt(vCategoryID)
			End If
	 	End Set
	End Property

	Public Property QuantityPerUnit() As Object
		Get
			Return rs.Fields("QuantityPerUnit").Value
	 	End Get
		Set(ByVal vQuantityPerUnit As Object)
			If IsNull6(vQuantityPerUnit) Then 
				rs.Fields("QuantityPerUnit").Value = VB6Null
			Else
				rs.Fields("QuantityPerUnit").Value = CStr(vQuantityPerUnit)
			End If
	 	End Set
	End Property

	Public Property UnitPrice() As Object
		Get
			Return rs.Fields("UnitPrice").Value
	 	End Get
		Set(ByVal vUnitPrice As Object)
			If IsNull6(vUnitPrice) Then 
				rs.Fields("UnitPrice").Value = VB6Null
			Else
				rs.Fields("UnitPrice").Value = CDec(vUnitPrice)
			End If
	 	End Set
	End Property

	Public Property UnitsInStock() As Object
		Get
			Return rs.Fields("UnitsInStock").Value
	 	End Get
		Set(ByVal vUnitsInStock As Object)
			If IsNull6(vUnitsInStock) Then 
				rs.Fields("UnitsInStock").Value = VB6Null
			Else
				rs.Fields("UnitsInStock").Value = CShort(vUnitsInStock)
			End If
	 	End Set
	End Property

	Public Property UnitsOnOrder() As Object
		Get
			Return rs.Fields("UnitsOnOrder").Value
	 	End Get
		Set(ByVal vUnitsOnOrder As Object)
			If IsNull6(vUnitsOnOrder) Then 
				rs.Fields("UnitsOnOrder").Value = VB6Null
			Else
				rs.Fields("UnitsOnOrder").Value = CShort(vUnitsOnOrder)
			End If
	 	End Set
	End Property

	Public Property ReorderLevel() As Object
		Get
			Return rs.Fields("ReorderLevel").Value
	 	End Get
		Set(ByVal vReorderLevel As Object)
			If IsNull6(vReorderLevel) Then 
				rs.Fields("ReorderLevel").Value = VB6Null
			Else
				rs.Fields("ReorderLevel").Value = CShort(vReorderLevel)
			End If
	 	End Set
	End Property

	Public Property Discontinued() As Object
		Get
			Return rs.Fields("Discontinued").Value
	 	End Get
		Set(ByVal vDiscontinued As Object)
			If IsNull6(vDiscontinued) Then 
				rs.Fields("Discontinued").Value = VB6Null
			Else
				rs.Fields("Discontinued").Value = CBool(vDiscontinued)
			End If
	 	End Set
	End Property

	'The RecordSet Beginnig Of File status.
	Public ReadOnly Property BOF() As Boolean
		Get
			Return rs.BOF
	 	End Get
	End Property

	'The RecordSet EndOfFile status.
	Public ReadOnly Property EOF() As Boolean
		Get
			Return rs.EOF
	 	End Get
	End Property

	'The RecordSet AbsolutePosition property.
	
	Public Property AbsolutePosition() As Integer
		Get
			Return rs.AbsolutePosition
	 	End Get
		Set(ByVal lAbsolutePosition As Integer)
			rs.AbsolutePosition = lAbsolutePosition
	 	End Set
	End Property

	'The Foreign Key Descriptor properties.
	Public Property CategoriesCategoryName() As Object
		Get
			Return rs.Fields("CategoriesCategoryName").Value
	 	End Get
		Set(ByVal vCategoryName As Object)
			rs.Fields("CategoriesCategoryName").Value = vCategoryName
	 	End Set
	End Property

	Public Property SuppliersCompanyName() As Object
		Get
			Return rs.Fields("SuppliersCompanyName").Value
	 	End Get
		Set(ByVal vCompanyName As Object)
			rs.Fields("SuppliersCompanyName").Value = vCompanyName
	 	End Set
	End Property

	Private Sub Class_GetDataMember(ByRef DataMember As String, ByRef Data As Object)
		'=============================================================
		'Name: Class_GetDataMember
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Creates and allows selection of RecordSet classes.
		'
		'Comment: A new RecordSet is created from the 'Select' RecordSet class.
		'   Foreign Key Descriptor columns are added to this RecordSet class and
		'   updated with the Foreign Key Data Environment commands mapped to the Select Foreign Key values.
		'=============================================================
		
		Dim i As Short
		Dim sLastFieldName As String = ""
		Dim sName() As Object
		Dim vValue() As Object
		Dim sNames As Object = Nothing
		Dim vValues As Object = Nothing
		Dim oField As ADODB.Field = Nothing
		
		On Error GoTo errMSDOG_GDM 
		
		bInitComplete = False
		
		'Choose the RecordSet class based on the DataMember parameter.
		Select Case LCase(DataMember)
		Case "products"
			'Skip initialization if RecordSet class already exists.
			If Not mbDataInitialized Then 
				de1.rsProducts.DataMember = ""
				
				If SaveMode = EnumSaveMode.adImmediate Then 
					de1.rsProducts.LockType = ADODB.LockTypeEnum.adLockOptimistic
				Else
					de1.rsProducts.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
				End If
				
				de1.Products()
				'Disconnect the RecordSet class to allow (1) stored procedure access
				'  and (2) control over database update timing.
				de1.rsProducts.ActiveConnection = Nothing
				
				'Data object has been initiallized.
				mbDataInitialized = True
				
				'Execute the Foreign Key command.
				de1.Suppliers()
				'If there are no Foreign Keys records, exit with a ClassError event.
				If de1.rsSuppliers.RecordCount < 1 Then 
					Err.Clear()
					Data = Nothing
					RaiseEvent ClassError("GetDataMember-No Suppliers records.", Err)
					Exit Sub
				End If
				
				'Set the Public property to expose the Foreign Key RecordSet class.
				rsSuppliers = de1.rsSuppliers
				'Disconnect the Foreign Key RecordSet class from the DataSource class.
				de1.rsSuppliers.ActiveConnection = Nothing
				
				'Execute the Foreign Key command.
				de1.Categories()
				'If there are no Foreign Keys records, exit with a ClassError event.
				If de1.rsCategories.RecordCount < 1 Then 
					Err.Clear()
					Data = Nothing
					RaiseEvent ClassError("GetDataMember-No Categories records.", Err)
					Exit Sub
				End If
				
				'Set the Public property to expose the Foreign Key RecordSet class.
				rsCategories = de1.rsCategories
				'Disconnect the Foreign Key RecordSet class from the DataSource class.
				de1.rsCategories.ActiveConnection = Nothing
				
				'Instantiate the new RecordSet class.
				rs = New ADODB.Recordset()
				
				'Set the CursorType property of the RecordSet class.
				rs.CursorType = ADODB.CursorTypeEnum.adOpenStatic
				'Set the LockType property of the RecordSet class.
				If SaveMode = EnumSaveMode.adImmediate Then 
					rs.LockType = ADODB.LockTypeEnum.adLockOptimistic
				Else
					rs.LockType = ADODB.LockTypeEnum.adLockBatchOptimistic
				End If
				
				i = -1
				sLastFieldName = ""
				
				'Loop through each field in the Select command,
				'adding the field to the created RecordSet class.
				'If the field is the last field in an Foreign Key command,
				'then add the Foreign Key Descriptor field.
				For Each oField In de1.rsProducts.Fields
					'Is the Select field the last one in an Foreign Key command?
					Select Case LCase(sLastFieldName)
					Case "supplierid"
						i += 1
						ReDim Preserve sName(i)
						sName(i) = "SuppliersCompanyName"
						'Add the Foreign Key Descriptor field to the RecordSet class.
						rs.Fields.Append("SuppliersCompanyName", de1.rsSuppliers.Fields("CompanyName").Type, de1.rsSuppliers.Fields("CompanyName").DefinedSize, de1.rsSuppliers.Fields("CompanyName").Attributes)
					Case "categoryid"
						i += 1
						ReDim Preserve sName(i)
						sName(i) = "CategoriesCategoryName"
						'Add the Foreign Key Descriptor field to the RecordSet class.
						rs.Fields.Append("CategoriesCategoryName", de1.rsCategories.Fields("CategoryName").Type, de1.rsCategories.Fields("CategoryName").DefinedSize, de1.rsCategories.Fields("CategoryName").Attributes)
					End Select
					
					i += 1
					
					ReDim Preserve sName(i)
					
					sName(i) = oField.Name
					
					'Add the Select field to the RecordSet class.
					rs.Fields.Append(oField.Name, oField.Type, oField.DefinedSize, oField.Attributes)
					
					'Set the Precision property to the same as in the original RecordSet class.
					rs.Fields(i).Precision = oField.Precision
					'Set the NumericScale property to the same as in the original RecordSet class.
					rs.Fields(i).NumericScale = oField.NumericScale
					
					sLastFieldName = sName(i)
				Next
				
				'Open the newly created RecordSet class.
				rs.Open()
				
				'Move to the first record in the RecordSet class.
				If de1.rsProducts.RecordCount > 0 Then 
					de1.rsProducts.MoveFirst()
				End If
				
				'Loop through each record in the RecordSet class.
				'If the Select field is a Foreign Key Descriptor field, look up it's value
				'in the Foreign Key command Descriptor field, then update the
				'Select Foreign Key Descriptor field with that value.
				While Not de1.rsProducts.EOF
					i = -1
					sLastFieldName = ""
					For Each oField In de1.rsProducts.Fields
						'Is the field a Foreign Key Descriptor field?
						Select Case LCase(sLastFieldName)
						Case "supplierid"
							i += 1
							ReDim Preserve vValue(i)
							vValue(i) = VB6Null
							de1.rsSuppliers.MoveFirst()
							
							'Loop through the Foreign Key RecordSet class until the Select value is found.
							Do While Not de1.rsSuppliers.EOF
								'If the Select Foreign Key values equal the Foreign Key command Primary Key values, update the Foreign Key Descriptor field.
								If de1.rsSuppliers.Fields("supplierid").Value = de1.rsProducts.Fields("supplierid").Value Then 
									'Load the vValue Array element with the Foreign Key Descriptor value.
									vValue(i) = de1.rsSuppliers.Fields("CompanyName").Value
									
									Exit Do
								End If
								
								'Move to the next record with a Foreign Key attribute.
								de1.rsSuppliers.MoveNext()
							Loop
							
							'If the value is null, then set the Foreign Key Descriptor Array element value to '(None).
							If IsNull6(vValue(i)) Then 
								vValue(i) = "(None)"
							End If
						Case "categoryid"
							i += 1
							ReDim Preserve vValue(i)
							vValue(i) = VB6Null
							de1.rsCategories.MoveFirst()
							
							'Loop through the Foreign Key RecordSet class until the Select value is found.
							Do While Not de1.rsCategories.EOF
								'If the Select Foreign Key values equal the Foreign Key command Primary Key values, update the Foreign Key Descriptor field.
								If de1.rsCategories.Fields("categoryid").Value = de1.rsProducts.Fields("categoryid").Value Then 
									'Load the vValue Array element with the Foreign Key Descriptor value.
									vValue(i) = de1.rsCategories.Fields("CategoryName").Value
									
									Exit Do
								End If
								
								'Move to the next record with a Foreign Key attribute.
								de1.rsCategories.MoveNext()
							Loop
							
							'If the value is null, then set the Foreign Key Descriptor Array element value to '(None).
							If IsNull6(vValue(i)) Then 
								vValue(i) = "(None)"
							End If
						End Select
						
						i += 1
						
						ReDim Preserve vValue(i)
						
						'Set the Array element equal to the value in the Select field.
						vValue(i) = de1.rsProducts.Fields(oField.Name).Value
						
						sLastFieldName = oField.Name
					Next
					
					'To add a record to a RecordSet class two arrays of variants are required,
					'(1) an array of field names and (2) an array of corresponding values.
					sNames = sName
					vValues = vValue
					
					'Add the record to the created RecordSet class.
					rs.AddNew(sNames, vValues)
					
					'Move to the next record in the Select RecordSet class.
					de1.rsProducts.MoveNext()
				End While
				
				'Move to the first record in the created RecordSet class.
				If rs.RecordCount > 0 Then 
					rs.MoveFirst()
				End If
			End If
			
			'Update all the RecordSet class row status to 'unmodified'.
			rs.UpdateBatch()
			
			'ReDimension the array to hold system generated Primary Key values.
			ReDim vPKValues(2, 0)
			
			'Set the Data object to return the Select RecordSet class to the calling procedure.
			Data = rs
			
			'Close the Data Environment connection
			de1.Connection1.Close()
			
		Case "suppliers"
			'Set the Data object to return the Foreign Key RecordSet class to the calling procedure.
			Data = de1.rsSuppliers
		Case "categories"
			'Set the Data object to return the Foreign Key RecordSet class to the calling procedure.
			Data = de1.rsCategories
		End Select
		
		bInitComplete = True
		
		Exit Sub
errMSDOG_GDM:
		RaiseEvent ClassError("GetDataMember", Err)
	End Sub

	Private Sub Class_Initialize_VB6()
		'=============================================================
		'Name: Class_Initialize
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Standard Class object Initialize event.
		'
		'Comment
		'=============================================================
		
		'Reset the Initialization variable.
		mbDataInitialized = False
	End Sub

	Private Sub Class_Terminate_VB6()
		'=============================================================
		'Name: Class_Terminate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Closes Data Environment connections and uninitializes objects
		'
		'Comment
		'=============================================================
		
		'Release the Data Environment and RecordSet objects
		de1 = Nothing
		rs = Nothing
	End Sub

	Private Sub RS_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.MoveComplete
		'=============================================================
		'Name: RS_MoveComplete
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Standard RecordSet MoveComplete event.
		'
		'Comment
		'=============================================================
		
		'Exit the subroutine if the BeginningOfFile property is true
		If rs.BOF Then 
			Exit Sub
		End If
		
		'Exit the subroutine if the EndOfFile Property is true
		If rs.EOF Then 
			Exit Sub
		End If
		
		'Raise the rsMoveComplete event
		
		RaiseEvent rsMoveComplete()
		
	End Sub

	Public Sub Move(ByVal lRows As Integer)
		'=============================================================
		'Name: Move
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Move the RecordSet n number of Rows.
		'
		'Comment
		'=============================================================
		
		On Error GoTo errMove 
		
		rs.Move(lRows)
		
		Exit Sub
errMove:
	End Sub

	Public Sub MoveNext()
		'=============================================================
		'Name: MoveNext
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Move to next record.
		'
		'Comment
		'=============================================================
		
		If (rs.RecordCount > 0) And (Not rs.EOF) Then 
			rs.MoveNext()
		End If
	End Sub

	Public Sub MoveFirst()
	' UPGRADE_INFO (#0511): The 'MoveFirst' member is referenced only by members that haven't found to be used in the current project/solution.
		'=============================================================
		'Name: MoveFirst
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Move to first record.
		'
		'Comment
		'=============================================================
		
		If rs.RecordCount > 0 Then 
			rs.MoveFirst()
		End If
	End Sub

	Public Sub MovePrevious()
		'=============================================================
		'Name: MovePrevious
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Move to previous record.
		'
		'Comment
		'=============================================================
		
		If (rs.RecordCount > 0) And (Not rs.BOF) Then 
			rs.MovePrevious()
		End If
	End Sub

	Public Sub MoveLast()
	' UPGRADE_INFO (#0511): The 'MoveLast' member is referenced only by members that haven't found to be used in the current project/solution.
		'=============================================================
		'Name: MoveLast
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Move to last record.
		'
		'Comment
		'=============================================================
		
		If rs.RecordCount > 0 Then 
			rs.MoveLast()
		End If
	End Sub

	Public Function ValidateData() As Boolean
		'=============================================================
		'Name: ValidateData
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: This Function validates the RecordSet class data.
		'
		'Comment
		'=============================================================
		
		Dim i As Integer
		
		ValidateData = False
		
		For i = 0 To rs.Fields.Count - 1
			Select Case LCase(rs.Fields(i).Name)
			Case "productname", "supplierid", "categoryid", "quantityperunit", "unitprice", "unitsinstock", "unitsonorder", "reorderlevel", "discontinued"
				If IsEmpty6(rs.Fields(i)) And Not rs.Fields(i).Type = ADODB.DataTypeEnum.adBoolean Then 
					MsgBox6(rs.Fields(i).Name & " error.")
					Exit Function
				End If
			End Select
		Next
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("ProductID").Value) Then 
			If Not IsNumeric6(rs.Fields("ProductID").Value) And InStr(rs.Fields("ProductID").Value, ".") = 0 Then 
				MsgBox6("The field ' ProductID ' does not contain a valid number.")
				Exit Function
			End If
		End If
		
		'Verify the field is not null.
		If IsNull6(rs.Fields("ProductName").Value) Then 
			MsgBox6("The field ' ProductName ' cannot be null.")
			Exit Function
		End If
		
		'Verify the text field contains text.
		If Not IsNull6(rs.Fields("ProductName").Value) Then 
			If Len6(Trim(rs.Fields("ProductName").Value)) = 0 Then 
				MsgBox6("The field ' ProductName ' does not contain valid text.")
				Exit Function
			End If
		End If
		
		'Verify the field is not null.
		If IsNull6(rs.Fields("SupplierID").Value) Then 
			MsgBox6("The field ' SupplierID ' cannot be null.")
			Exit Function
		End If
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("SupplierID").Value) Then 
			If Not IsNumeric6(rs.Fields("SupplierID").Value) And InStr(rs.Fields("SupplierID").Value, ".") = 0 Then 
				MsgBox6("The field ' SupplierID ' does not contain a valid number.")
				Exit Function
			End If
		End If
		
		'Verify the field is not null.
		If IsNull6(rs.Fields("CategoryID").Value) Then 
			MsgBox6("The field ' CategoryID ' cannot be null.")
			Exit Function
		End If
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("CategoryID").Value) Then 
			If Not IsNumeric6(rs.Fields("CategoryID").Value) And InStr(rs.Fields("CategoryID").Value, ".") = 0 Then 
				MsgBox6("The field ' CategoryID ' does not contain a valid number.")
				Exit Function
			End If
		End If
		
		'Verify the text field contains text.
		If Not IsNull6(rs.Fields("QuantityPerUnit").Value) Then 
			If Len6(Trim(rs.Fields("QuantityPerUnit").Value)) = 0 Then 
				MsgBox6("The field ' QuantityPerUnit ' does not contain valid text.")
				Exit Function
			End If
		End If
		
		'Verify the decimal field contains a valid value.
		If Not IsNull6(rs.Fields("UnitPrice").Value) Then 
			If Not IsNumeric6(rs.Fields("UnitPrice").Value) Then 
				MsgBox6("The field ' UnitPrice ' does not contain a valid numeric value.")
				Exit Function
			End If
		End If
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("UnitsInStock").Value) Then 
			If Not IsNumeric6(rs.Fields("UnitsInStock").Value) And InStr(rs.Fields("UnitsInStock").Value, ".") = 0 Then 
				MsgBox6("The field ' UnitsInStock ' does not contain a valid number.")
				Exit Function
			End If
		End If
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("UnitsOnOrder").Value) Then 
			If Not IsNumeric6(rs.Fields("UnitsOnOrder").Value) And InStr(rs.Fields("UnitsOnOrder").Value, ".") = 0 Then 
				MsgBox6("The field ' UnitsOnOrder ' does not contain a valid number.")
				Exit Function
			End If
		End If
		
		'Verify the integer field contains a valid value.
		If Not IsNull6(rs.Fields("ReorderLevel").Value) Then 
			If Not IsNumeric6(rs.Fields("ReorderLevel").Value) And InStr(rs.Fields("ReorderLevel").Value, ".") = 0 Then 
				MsgBox6("The field ' ReorderLevel ' does not contain a valid number.")
				Exit Function
			End If
		End If

		Return True
		
	End Function

	Private Function PutDataInsert() As Boolean
		'=============================================================
		'Name: PutDataInsert
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Insert current row.
		'
		'Comment
		'=============================================================
		
		Dim oCommand As ADODB.Command = Nothing
		
		On Error GoTo errPutDataInsert 
		
		PutDataInsert = False
		
		oCommand = de1.Commands("Products_Insert")
		
		'Workaround for Kagera provider
		If LCase(de1.Connection1.Properties("Provider Name").Value) = "msdasql.dll" Then 
			oCommand.Properties("Force SQL Server Firehose Mode cursor").Value = True
		End If
		
		'Check for valid data.
		If Not ValidateData() Then 
			'Raise the ClassError event to detect invalid data.
			RaiseEvent ClassError("Data Validation error.", Err)
			Exit Function
		End If
		
		'Set the parameter values for the command to be executed.
		oCommand.Parameters("ProductName").Value = GetPKValue(rs.Bookmark, "ProductName")
		oCommand.Parameters("CategoryID").Value = GetPKValue(rs.Bookmark, "CategoryID")
		oCommand.Parameters("SupplierID").Value = GetPKValue(rs.Bookmark, "SupplierID")
		oCommand.Parameters("QuantityPerUnit").Value = GetPKValue(rs.Bookmark, "QuantityPerUnit")
		oCommand.Parameters("UnitPrice").Value = GetPKValue(rs.Bookmark, "UnitPrice")
		oCommand.Parameters("UnitsInStock").Value = GetPKValue(rs.Bookmark, "UnitsInStock")
		oCommand.Parameters("UnitsOnOrder").Value = GetPKValue(rs.Bookmark, "UnitsOnOrder")
		oCommand.Parameters("ReorderLevel").Value = GetPKValue(rs.Bookmark, "ReorderLevel")
		oCommand.Parameters("Discontinued").Value = GetPKValue(rs.Bookmark, "Discontinued")
		
		'Execute the command.
		oCommand.Execute()
		
		Return True
		
		Exit Function
		
errPutDataInsert:
		RaiseEvent ClassError("PutDataInsert", Err)
	End Function

	Private Function PutDataUpdate() As Boolean
		'=============================================================
		'Name: PutDataUpdate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Update current row.
		'
		'Comment
		'=============================================================
		
		Dim oCommand As ADODB.Command = Nothing
		
		On Error GoTo errPutDataUpdate 
		
		PutDataUpdate = False
		
		oCommand = de1.Commands("Products_Update")
		
		'Workaround for Kagera provider
		If LCase(de1.Connection1.Properties("Provider Name").Value) = "msdasql.dll" Then 
			oCommand.Properties("Force SQL Server Firehose Mode cursor").Value = True
		End If
		
		'Check for valid data.
		If Not ValidateData() Then 
			'Raise the ClassError event to detect invalid data.
			RaiseEvent ClassError("Data Validation error.", Err)
			Exit Function
		End If
		
		'Set the parameter values for the command to be executed.
		oCommand.Parameters("ProductName").Value = GetPKValue(rs.Bookmark, "ProductName")
		oCommand.Parameters("CategoryID").Value = GetPKValue(rs.Bookmark, "CategoryID")
		oCommand.Parameters("SupplierID").Value = GetPKValue(rs.Bookmark, "SupplierID")
		oCommand.Parameters("QuantityPerUnit").Value = GetPKValue(rs.Bookmark, "QuantityPerUnit")
		oCommand.Parameters("UnitPrice").Value = GetPKValue(rs.Bookmark, "UnitPrice")
		oCommand.Parameters("UnitsInStock").Value = GetPKValue(rs.Bookmark, "UnitsInStock")
		oCommand.Parameters("UnitsOnOrder").Value = GetPKValue(rs.Bookmark, "UnitsOnOrder")
		oCommand.Parameters("ReorderLevel").Value = GetPKValue(rs.Bookmark, "ReorderLevel")
		oCommand.Parameters("Discontinued").Value = GetPKValue(rs.Bookmark, "Discontinued")
		oCommand.Parameters("ProductID").Value = GetPKValue(rs.Bookmark, "ProductID")
		
		'Execute the command.
		oCommand.Execute()
		
		Return True
		
		Exit Function
		
errPutDataUpdate:
		RaiseEvent ClassError("PutDataUpdate", Err)
	End Function

	Private Function PutDataDelete() As Boolean
		'=============================================================
		'Name: PutDataDelete
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Delete current row.
		'
		'Comment
		'=============================================================
		
		Dim oCommand As ADODB.Command = Nothing
		
		On Error GoTo errPutDataDelete 
		
		PutDataDelete = False
		
		oCommand = de1.Commands("Products_Delete")
		
		'Workaround for Kagera provider
		If LCase(de1.Connection1.Properties("Provider Name").Value) = "msdasql.dll" Then 
			oCommand.Properties("Force SQL Server Firehose Mode cursor").Value = True
		End If
		
		'Set the parameter values for the command to be executed.
		oCommand.Parameters("ProductID").Value = GetPKValue(rs.Bookmark, "ProductID")
		
		'Execute the command.
		oCommand.Execute()
		
		Return True
		
		Exit Function
		
errPutDataDelete:
		RaiseEvent ClassError("PutDataDelete", Err)
	End Function

	Public Sub UpdateBatch()
	' UPGRADE_INFO (#0511): The 'UpdateBatch' member is referenced only by members that haven't found to be used in the current project/solution.
		'=============================================================
		'Name: Update Batch
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Saves all modified records.
		'
		'Comment
		'=============================================================
		
		On Error GoTo errUpdateBatch 

		rs.UpdateBatch()
		
		Exit Sub
errUpdateBatch:
		RaiseEvent ClassError("UpdateBatch", Err)
	End Sub

	Public Sub Update()
		'=============================================================
		'Name: Update
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Saves a single record of the record set.
		'
		'Comment
		'=============================================================
		
		On Error GoTo errUpdate 
		
		rs.UpdateBatch(ADODB.AffectEnum.adAffectCurrent)
		
		Exit Sub
		
errUpdate:
		RaiseEvent ClassError("Update", Err)
	End Sub

	Public Sub AddRecord()
		'=============================================================
		'Name: AddRecord
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Adds a blank record to the RecordSet class.
		'
		'Comment: .
		'=============================================================
		
		mbAddingRecord = True
		
		With rs
			.AddNew()
			.Update()
		End With
		
		mbAddingRecord = False
		
		rs.MoveLast()
		
	End Sub

	Public Function MoveToPK(ByVal ProductID As Object) As Boolean
	' UPGRADE_INFO (#0511): The 'MoveToPK' member is referenced only by members that haven't found to be used in the current project/solution.
		'=============================================================
		'Name: MoveToPK
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Sets the current RecordSet row with Primary Key values
		'
		'Comment
		'=============================================================
		
		MoveToPK = False
		
		'Move to the first record in the RecordSet class
		rs.MoveFirst()
		
		Do While Not rs.EOF
			If rs.Fields("ProductID").Value = ProductID Then 
				MoveToPK = True
				Exit Do
			End If
			rs.MoveNext()
		Loop
	End Function

	Private Sub UpdateCategoriesCategoryName()
		'=============================================================
		'Name: UpdateCategoriesCategoryName
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Updates Foreign Key Descriptor field.
		'
		'Comment
		'=============================================================
		
		de1.rsCategories.MoveFirst()
		
		rs.Fields("CategoriesCategoryName").Value = "(None)"
		CategoriesCategoryName = "(None)"
		
		While Not de1.rsCategories.EOF
			If de1.rsCategories.Fields("categoryid").Value = rs.Fields("categoryid").Value Then 
				rs.Fields("CategoriesCategoryName").Value = CStr(de1.rsCategories.Fields("CategoryName").Value)
				CategoriesCategoryName = CStr(de1.rsCategories.Fields("CategoryName").Value)
			End If
			
			de1.rsCategories.MoveNext()
		End While
	End Sub

	Private Sub UpdateSuppliersCompanyName()
		'=============================================================
		'Name: UpdateSuppliersCompanyName
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Updates Foreign Key Descriptor field.
		'
		'Comment
		'=============================================================
		
		de1.rsSuppliers.MoveFirst()
		
		rs.Fields("SuppliersCompanyName").Value = "(None)"
		SuppliersCompanyName = "(None)"
		
		While Not de1.rsSuppliers.EOF
			If de1.rsSuppliers.Fields("supplierid").Value = rs.Fields("supplierid").Value Then 
				rs.Fields("SuppliersCompanyName").Value = CStr(de1.rsSuppliers.Fields("CompanyName").Value)
				SuppliersCompanyName = CStr(de1.rsSuppliers.Fields("CompanyName").Value)
			End If
			
			de1.rsSuppliers.MoveNext()
		End While
	End Sub

	Public Sub rsUpdate(ByVal vFieldName As Object)
		'=============================================================
		'Name: rsUpdate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Updates Foreign Key Descriptors and raises rsUpdate event
		'
		'Comment
		'=============================================================
		
		UpdateCategoriesCategoryName()
		UpdateSuppliersCompanyName()
		
		RaiseEvent rsUpdateEvent(vFieldName)
	End Sub

	Public Sub Delete()
		'=============================================================
		'Name: Delete
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: This subroutine deletes a single record.
		'
		'Comment
		'=============================================================
		
		On Error GoTo errDelete 
		
		mbDeleteInProgress = True
		
		'Update the current record status to 'unmodified'.
		rs.Delete(ADODB.AffectEnum.adAffectCurrent)
		
		On Error GoTo 0 
		
		Me.MovePrevious()
		
		mbDeleteInProgress = False
		
		Exit Sub
		
errDelete:
		RaiseEvent ClassError("Delete", Err)
	End Sub

	Private Sub rs_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset) Handles rs.WillChangeRecord
		'=============================================================
		'Name: rs_WillChangeRecord
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Runs stored procedures to save record.
		'
		'Comment
		'=============================================================
		
		On Error GoTo errWillChangeRecord 
		If bInitComplete And (adReason <> ADODB.EventReasonEnum.adRsnFirstChange) And (adReason <> ADODB.EventReasonEnum.adRsnUndoAddNew) And Not mbAddingRecord Then 
			If IsEmpty6(rs.Fields(0).OriginalValue) Then 
				If Not PutDataInsert() Then 
					adStatus = ADODB.EventStatusEnum.adStatusCancel
				End If
			Else
				Select Case adReason
				Case ADODB.EventReasonEnum.adRsnUpdate
					If Not mbDeleteInProgress Then 
						If Not PutDataUpdate() Then 
							adStatus = ADODB.EventStatusEnum.adStatusCancel
						End If
					End If
				Case ADODB.EventReasonEnum.adRsnAddNew
					If Not PutDataInsert() Then 
						adStatus = ADODB.EventStatusEnum.adStatusCancel
					End If
				Case ADODB.EventReasonEnum.adRsnDelete
					If Not PutDataDelete() Then 
						adStatus = ADODB.EventStatusEnum.adStatusCancel
					End If
					mbDeleteInProgress = True
				End Select
			End If
		End If
		
		Exit Sub
		
errWillChangeRecord:
		
	End Sub

	Private Function GetPKValue(ByVal vBookMark As Object, ByVal sColName As String) As Object
		'=============================================================
		'Name: GetPKValue
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:25
		'
		'Description: Looks up newly inserted system gen'd PK values.
		'
		'Comment
		'=============================================================
		
		Dim i As Short
		
		GetPKValue = rs.Fields(sColName).Value
		
		For i = 1 To UBound6(vPKValues, 2)
			If vPKValues(0, i) = vBookMark And LCase(vPKValues(1, i)) = LCase(sColName) Then 
				Return vPKValues(2, i)
			End If
		Next
	End Function

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub
	
	#Region "IVB6DataSourceClass members"
	
	Protected Sub DataSource_GetDataMember(ByRef dataMember As String, ByRef data As Object) Implements IVB6DataSourceClass.GetDataMember
		Class_GetDataMember(dataMember, data)
	End Sub
	
	Protected Sub DataMemberChanged(ByVal dataMember As String) Implements IVB6DataSourceClass.DataMemberChanged
		Class_GetDataMember(Nothing, Nothing)
	End Sub
	
	Private m_DataMembers As New VB6DataMembers
	Protected ReadOnly Property DataMembers() As VB6DataMembers Implements IVB6DataSourceClass.DataMembers
		Get
			Return m_DataMembers
		End Get
	End Property
	
	#End Region

End Class
