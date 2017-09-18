' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports CodeArchitects.VB6Library.Events

<VB6Object("Project1.uctProductsSingleRecord")> _
Friend Class uctProductsSingleRecord

	'=============================================================
	'Name: uctProductsSingle Record (The SingleRecordUserControl object)
	'
	'Author: Microsoft Data Object Wizard
	'
	'Date: 01/05/1999 20:26
	'
	'Description: SingleRecordUserControl object using a Data Object Wizard RecordSet class as a DataSource class.
	'
	'Comment
	'=============================================================
	
	'Set this value to true on initial load.
	Private mbFirstTime As Boolean
	'Set this value to true on initial load.
	Private mbOKToUpdate As Boolean
	'This value is true if error occurred in DataSource class.
	Private mbClassError As Boolean
	'Set this value to true to run the UserControl object Update method
	Private mbUpdateOK As Boolean
	
	'Create parameter properties for the Select RecordSet class
	
	'Create the Foreign Key Parameter properties for the RecordSet classes
	
	'Set the ManualInitialize property to false to automatically initialize or true to manually inititalize the UserControl object
	Public ManualInitialize As Boolean
	
	'Use the BindingCollection class for the text fields
	Private oColBind As VB6BindingCollection
	
	'Use the Data Object Wizard RecordSet class as a DataSource class
	Private WithEvents oProducts As rsclsProducts
	'RecordSet Move event
	Public Event MoveComplete As VB6WebBrowserobjectEventHandler
	
	'Add Format object for CheckBox controls
	Private oStdDataFormat As VB6StdDataFormat
	
	'Save the adImmediate property when the user moves off the row.
	Public SaveMode As EnumSaveMode
	
	'Format object for textbox controls
	Private WithEvents oFmtProductName As VB6StdDataFormat
	Private WithEvents oFmtQuantityPerUnit As VB6StdDataFormat
	Private WithEvents oFmtUnitPrice As VB6StdDataFormat
	Private WithEvents oFmtUnitsInStock As VB6StdDataFormat
	Private WithEvents oFmtUnitsOnOrder As VB6StdDataFormat
	Private WithEvents oFmtReorderLevel As VB6StdDataFormat
	'Format variables for textbox controls
	Private mvFmtProductName As Object
	Private mvFmtQuantityPerUnit As Object
	Private mvFmtUnitPrice As Object
	Private mvFmtUnitsInStock As Object
	Private mvFmtUnitsOnOrder As Object
	Private mvFmtReorderLevel As Object
	
	Public Function InitProducts(Optional ByVal oDataSource0 As Object = VB6Missing) As Object
		'=============================================================
		'Name: InitProducts
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Initializes UserControl object
		'
		'Comment
		'=============================================================
		
		'This value is set to true during intialization.
		mbFirstTime = True
		'This value is set to true during intialization.
		mbOKToUpdate = False
		'This value is set to false to Initialize.
		mbUpdateOK = False
		
		'Reset the DataSource class.
		oProducts = Nothing
		
		'Use the Data Object Wizard RecordSet class as the DataSource class for the datagrid control
		If IsMissing6(oDataSource0) Then 
			'If DataSource class was not passed as a parameter, create a new instance of the DataSource class.
			oProducts = New rsclsProducts()
		Else
			'If DataSource class was passed, use that DataSource class.
			oProducts = oDataSource0
		End If

		'Set the RecordSet class Foreign Key parameter properties to the UserControl object values
		
		'Save the adImmediate property when the user moves off the row.
		oProducts.SaveMode = Me.SaveMode
		
		'Use the BindingCollection class to bind the textbox controls to the DataSource class.
		oColBind = New VB6BindingCollection()
		mbClassError = False
		oColBind.DataMember = "Products"
		oColBind.DataSource = oProducts
		
		'If there is a DataSource error, exit the function.
		If mbClassError Then 
			MsgBox6("Cannot initialize DataSource.")
			Exit Function
		End If
		
		'Create the Format object for the checkbox controls.
		oStdDataFormat = New VB6StdDataFormat()
		oStdDataFormat.Type = StdFormat.FormatType.fmtCheckbox
		oStdDataFormat.FalseValue = 0
		oStdDataFormat.TrueValue = 1
		
		'Create the Format object for the textbox controls.
		oFmtProductName = New VB6StdDataFormat()
		oFmtQuantityPerUnit = New VB6StdDataFormat()
		oFmtUnitPrice = New VB6StdDataFormat()
		oFmtUnitsInStock = New VB6StdDataFormat()
		oFmtUnitsOnOrder = New VB6StdDataFormat()
		oFmtReorderLevel = New VB6StdDataFormat()
		
		'Fill the Foreign Key combobox control.
		Call FillCombo(cmbCategoriesCategoryName, ByVal6(oProducts.rsCategories), "CategoryName", False)
		'Fill the Foreign Key combobox control.
		Call FillCombo(cmbSuppliersCompanyName, ByVal6(oProducts.rsSuppliers), "CompanyName", False)
		
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtProductName, "Text", "ProductName", oFmtProductName)
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtQuantityPerUnit, "Text", "QuantityPerUnit", oFmtQuantityPerUnit)
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtUnitPrice, "Text", "UnitPrice", oFmtUnitPrice)
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtUnitsInStock, "Text", "UnitsInStock", oFmtUnitsInStock)
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtUnitsOnOrder, "Text", "UnitsOnOrder", oFmtUnitsOnOrder)
		'Bind the textbox control to the DataSource class.
		oColBind.Add(txtReorderLevel, "Text", "ReorderLevel", oFmtReorderLevel)
		'Bind the CheckBox control to the DataSource class.
		oColBind.Add(chkDiscontinued, "Value", "Discontinued", oStdDataFormat)
		
		'Reset the flag to false.
		mbFirstTime = False
		
		'Set the combobox controls to the correct Foreign Key values.
		Call SetFKCombos()
		
		'Set the flag to true.
		mbOKToUpdate = True
		
		'Return the DataSource class.
		Return oProducts
	End Function
	
	Public Function MoveToPK(ByVal ProductID As Object) As Boolean
		
		'Run the DataSource class MoveToPK method with the Primary Key values.
		Return oProducts.MoveToPK(ProductID)
		
	End Function
	
	Private Sub oProducts_rsMoveComplete() Handles oProducts.rsMoveComplete
		'=============================================================
		'Name: oProducts_rsMoveComplete()
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Sink the RecordSet class rsMoveComplete event
		'
		'Comment
		'=============================================================
		
		mbOKToUpdate = False
		'Update the Foreign Key combobox control.
		If Not mbFirstTime Then  Call SetFKCombos()
		mbOKToUpdate = True
		
		VB6WebBrowserobjectEventDispatcher.Raise(Me, "MoveComplete", oProducts)
		
	End Sub

	Protected Overrides Sub UserControl_Terminate_VB6()
		'=============================================================
		'Name: UserControl_Terminate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UserControl object Terminate event
		'
		'Comment
		'=============================================================
		
		oProducts = Nothing
		oColBind = Nothing
	End Sub

	Private Sub FillCombo(ByVal cmbComboBox As VB6ComboBox, ByVal oRS As ADODB.Recordset, ByVal sDescrField As String, ByVal bShowNone As Boolean)
		'=============================================================
		'Name: FillCombo
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Fills the Foreign Key combobox controls
		'
		'Comment
		'=============================================================
		
		'Clear the floating combobox control
		cmbComboBox.Clear()
		
		'Move to the first record of the RecordSet class
		oRS.MoveFirst()
		
		'If the foreign key relationship allows nulls, then put '(None)' as
		'the first combobox Item.
		If bShowNone Then 
			cmbComboBox.AddItem("(None)")
			cmbComboBox.ItemData(cmbComboBox.NewIndex) = -1
		End If
		
		'Load the combobox control from the RecordSet class
		While Not oRS.EOF
			cmbComboBox.AddItem(oRS.Fields(sDescrField).Value)
			cmbComboBox.ItemData(cmbComboBox.NewIndex) = oRS.AbsolutePosition
			
			oRS.MoveNext()
		End While
		
		If cmbComboBox.ListCount > 0 Then 
			cmbComboBox.ListIndex = 0
		End If
	End Sub

	Private Function GetSurKeyCategories(ByVal categoryid As Object) As Short
	' UPGRADE_INFO (#0561): The 'categoryid' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: GetSurKeyCategories
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
		'
		'Comment
		'=============================================================
		
		oProducts.rsCategories.MoveFirst()
		
		' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
		While Not oProducts.rsCategories.EOF
			'If the Foreign Key RecordSet field value(s) equal the Select Foreign Key field values, then get the Surrogate Key (AbsolutePosition) value.
			If oProducts.rsCategories.Fields("categoryid").Value = Val(categoryid) Then 
				'Get the Surrogate Key (AbsolutePosition) value.
				Return oProducts.rsCategories.AbsolutePosition
			End If
			oProducts.rsCategories.MoveNext()
		End While
		
		'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
		Return 1
		
	End Function

	Private Function GetSurKeySuppliers(ByVal supplierid As Object) As Short
	' UPGRADE_INFO (#0561): The 'supplierid' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: GetSurKeySuppliers
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
		'
		'Comment
		'=============================================================
		
		oProducts.rsSuppliers.MoveFirst()
		
		' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
		While Not oProducts.rsSuppliers.EOF
			'If the Foreign Key RecordSet field value(s) equal the Select Foreign Key field values, then get the Surrogate Key (AbsolutePosition) value.
			If oProducts.rsSuppliers.Fields("supplierid").Value = Val(supplierid) Then 
				'Get the Surrogate Key (AbsolutePosition) value.
				Return oProducts.rsSuppliers.AbsolutePosition
			End If
			oProducts.rsSuppliers.MoveNext()
		End While
		
		'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
		Return 1
		
	End Function

	Private Sub SetFKCombos()
		'=============================================================
		'Name: SetFKCombos
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: This function sets the ListIndex property of the combobox control to the Surrogate Key value of the Foreign Key attribute.
		'
		'Comment
		'=============================================================
		
		On Error Resume Next 
		
		If Not mbFirstTime Then 
			'Set the combobox control to the correct item for the Foreign Key value.
			cmbCategoriesCategoryName.ListIndex = GetSurKeyCategories(oProducts.categoryid) - 1
			
			'Set the combobox control to the correct item for the Foreign Key value.
			cmbSuppliersCompanyName.ListIndex = GetSurKeySuppliers(oProducts.supplierid) - 1
			
		End If
		
		' IGNORED: On Error GoTo 0 
	End Sub

	Private Sub cmbCategoriesCategoryName_Click() Handles cmbCategoriesCategoryName.Click
		'=============================================================
		'Name: cmbCategoriesCategoryName_Click
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard combobox control Click event.
		'
		'Comment
		'=============================================================
		
		If mbOKToUpdate Then 
			'Update the DataSource class Foreign Key properties.
			If Not mbFirstTime Then  Call UpdateFKCategories(cmbCategoriesCategoryName.ItemData(cmbCategoriesCategoryName.ListIndex))
		End If
	End Sub

	Private Sub cmbSuppliersCompanyName_Click() Handles cmbSuppliersCompanyName.Click
		'=============================================================
		'Name: cmbSuppliersCompanyName_Click
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard combobox control Click event.
		'
		'Comment
		'=============================================================
		
		If mbOKToUpdate Then 
			'Update the DataSource class Foreign Key properties.
			If Not mbFirstTime Then  Call UpdateFKSuppliers(cmbSuppliersCompanyName.ItemData(cmbSuppliersCompanyName.ListIndex))
		End If
	End Sub

	Private Function UpdateFKCategories(ByVal nSurrogateKey As Short) As Object
	' UPGRADE_INFO (#0561): The 'UpdateFKCategories' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: UpdateFKCategories
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
		'
		'Comment
		'=============================================================
		
		If nSurrogateKey = -1 Then 
			'Set the actual Foreign Key value to null
			oProducts.categoryid = VB6Null
			oProducts.rsUpdate("categoryid")
		Else
			oProducts.rsCategories.MoveFirst()
			
			'Loop through the Foreign Key RecordSet class until the correct Surrogate Key value(the AbsolutePosition property) is found.
			While Not oProducts.rsCategories.EOF
				If oProducts.rsCategories.AbsolutePosition = Val(nSurrogateKey) Then 
					'Set the Select Foreign Key field value to the Foreign Key RecordSet field value.
					oProducts.categoryid = oProducts.rsCategories.Fields("categoryid").Value
					oProducts.rsUpdate("categoryid")
					Exit Function
				End If
				oProducts.rsCategories.MoveNext()
			End While
		End If
		
	End Function

	Private Function UpdateFKSuppliers(ByVal nSurrogateKey As Short) As Object
	' UPGRADE_INFO (#0561): The 'UpdateFKSuppliers' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: UpdateFKSuppliers
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
		'
		'Comment
		'=============================================================
		
		If nSurrogateKey = -1 Then 
			'Set the actual Foreign Key value to null
			oProducts.supplierid = VB6Null
			oProducts.rsUpdate("supplierid")
		Else
			oProducts.rsSuppliers.MoveFirst()
			
			'Loop through the Foreign Key RecordSet class until the correct Surrogate Key value(the AbsolutePosition property) is found.
			While Not oProducts.rsSuppliers.EOF
				If oProducts.rsSuppliers.AbsolutePosition = Val(nSurrogateKey) Then 
					'Set the Select Foreign Key field value to the Foreign Key RecordSet field value.
					oProducts.supplierid = oProducts.rsSuppliers.Fields("supplierid").Value
					oProducts.rsUpdate("supplierid")
					Exit Function
				End If
				oProducts.rsSuppliers.MoveNext()
			End While
		End If
		
	End Function

	Public Sub UpdateBatch()
		'=============================================================
		'Name: UpdateBatch
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: This subroutine runs the Class control UpdateBatch method.
		'
		'Comment
		'=============================================================
		
		'Trigger the update if the user does not move off the row.
		oProducts.Move(0)
		
		oProducts.UpdateBatch()
		
	End Sub

	Public Shadows Sub Update()
		'=============================================================
		'Name: Update
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: This subroutine runs the Class object Update method.
		'
		'Comment
		'=============================================================
		
		mbUpdateOK = True
		
		'Trigger the update if the user does not move off the row.
		oProducts.Move(0)
		
		If mbUpdateOK Then 
			oProducts.Update()
		End If
		
		mbUpdateOK = False
		
	End Sub

	Public Sub MoveFirst()
		'=============================================================
		'Name: MoveFirst
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Move the SingleRecord control to the first record of RecordSet class.
		'
		'Comment
		'=============================================================
		
		oProducts.MoveFirst()
	End Sub

	Public Sub MovePrevious()
		'=============================================================
		'Name: MovePrevious
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Move the SingleRecord control to the previous record of RecordSet class.
		'
		'Comment
		'=============================================================
		
		oProducts.MovePrevious()
	End Sub

	Public Sub MoveNext()
		'=============================================================
		'Name: MoveNext
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Move the SingleRecord control to the next record of the RecordSet class.
		'
		'Comment
		'=============================================================
		
		oProducts.MoveNext()
	End Sub

	Public Sub MoveLast()
		'=============================================================
		'Name: MoveLast
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Move the SingleRecord control to the last record of the RecordSet class.
		'
		'Comment
		'=============================================================
		
		oProducts.MoveLast()
	End Sub

	Private Sub oProducts_ClassError(ByRef sProcedureName As String, ByRef oErr As ErrObject) Handles oProducts.ClassError
		'=============================================================
		'Name: oProducts
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: This subroutine performs the Sink action on the ClassError event.
		'
		'Comment
		'=============================================================
		
		Dim sStr As String = sProcedureName

		If oErr.Description <> "" Then 
			sStr &= oErr.Description
		End If
		
		mbClassError = True
		
		MsgBox6(sStr)
		
	End Sub

	Protected Overrides Sub UserControl_ReadProperties(ByRef PropBag As VB6PropertyBag)
		'=============================================================
		'Name: UserControl_ReadProperties
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UserControl object ReadProperties event.
		'
		'Comment
		'=============================================================
		
		Dim bErrorFlag As Boolean = False
		Dim sParamName As String = ""

		On Error GoTo errUserControl_ReadProperties 
		
		'Set the ManualInitial property to the false value to initialize automatically.
		ManualInitialize = PropBag.ReadProperty("ManualInitialize")
		
		If Not ManualInitialize Then 
			'Read the SaveMode property value.
			sParamName = "SaveMode"
			SaveMode = CInt(PropBag.ReadProperty("SaveMode"))
			
			'If no errors during the reading of the parameters and the user is in the Visual Basic run mode state, run the DataSource class initialize method.
			If Not bErrorFlag And Ambient.UserMode Then 
				InitProducts()
			End If
			
		End If
		
		Exit Sub
		
errUserControl_ReadProperties:
		bErrorFlag = True
		Resume Next 
	End Sub

	Protected Overrides Sub UserControl_WriteProperties(ByRef PropBag As VB6PropertyBag)
		'=============================================================
		'Name: UserControl_WriteProperties
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UserControl object WriteProperties event.
		'
		'Comment
		'=============================================================
		
		On Error Resume Next 
		
		'The ManualInitialize property is set to the false value to initialize automatically.
		PropBag.WriteProperty("ManualInitialize", ManualInitialize)
		
		If Not ManualInitialize Then 
			'Write the SaveMove property value.
			PropBag.WriteProperty("SaveMode", SaveMode)
			
		End If
		
		' IGNORED: On Error GoTo 0 
		
	End Sub
	
	Public Sub AddRecord()
		'=============================================================
		'Name: AddRecord
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Adds a new record to the RecordSet class.
		'
		'Comment
		'=============================================================
		
		'Move to trigger RecordSet WillChangeRecord event to save current record.
		oProducts.Move(0)
		
		'Add a blank record to the DataSource RecordSet class.
		oProducts.AddRecord()
		
		'Set all CheckBoxes to True.
		oProducts.Discontinued = True
		
		'Update the Foreign Key combobox control with the correct value.
		UpdateFKCategories((cmbCategoriesCategoryName.ItemData(cmbCategoriesCategoryName.ListIndex)))
		'Update the Foreign Key combobox control with the correct value.
		UpdateFKSuppliers((cmbSuppliersCompanyName.ItemData(cmbSuppliersCompanyName.ListIndex)))
	End Sub

	Public Sub Delete()
		'=============================================================
		'Name: Delete
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Deletes a record from the RecordSet class.
		'
		'Comment
		'=============================================================
		
		'Delete the current DataSource record.
		oProducts.Delete()
	End Sub

	Private Sub oFmtProductName_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtProductName.FormatEvent6
		'=============================================================
		'Name: oFmtProductName_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtProductName) And mvFmtProductName <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("ProductName error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtQuantityPerUnit_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtQuantityPerUnit.FormatEvent6
		'=============================================================
		'Name: oFmtQuantityPerUnit_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtQuantityPerUnit) And mvFmtQuantityPerUnit <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("QuantityPerUnit error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtUnitPrice_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitPrice.FormatEvent6
		'=============================================================
		'Name: oFmtUnitPrice_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtUnitPrice) And mvFmtUnitPrice <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("UnitPrice error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtUnitsInStock_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitsInStock.FormatEvent6
		'=============================================================
		'Name: oFmtUnitsInStock_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtUnitsInStock) And mvFmtUnitsInStock <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("UnitsInStock error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtUnitsOnOrder_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitsOnOrder.FormatEvent6
		'=============================================================
		'Name: oFmtUnitsOnOrder_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtUnitsOnOrder) And mvFmtUnitsOnOrder <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("UnitsOnOrder error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtReorderLevel_Format(ByVal DataValue As VB6StdDataValue) Handles oFmtReorderLevel.FormatEvent6
		'=============================================================
		'Name: oFmtReorderLevel_Format
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Format event.
		'
		'Comment
		'=============================================================
		
		If mbUpdateOK And Not IsEmpty6(mvFmtReorderLevel) And mvFmtReorderLevel <> CStr(DataValue.Value) And Not mbFirstTime Then 
			MsgBox6("ReorderLevel error.")
			
			mbUpdateOK = False
		End If
	End Sub

	Private Sub oFmtProductName_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtProductName.UnFormat
		'=============================================================
		'Name: oFmtProductName_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtProductName = DataValue.Value
	End Sub

	Private Sub oFmtQuantityPerUnit_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtQuantityPerUnit.UnFormat
		'=============================================================
		'Name: oFmtQuantityPerUnit_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtQuantityPerUnit = DataValue.Value
	End Sub

	Private Sub oFmtUnitPrice_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitPrice.UnFormat
		'=============================================================
		'Name: oFmtUnitPrice_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitPrice = DataValue.Value
	End Sub

	Private Sub oFmtUnitsInStock_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitsInStock.UnFormat
		'=============================================================
		'Name: oFmtUnitsInStock_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitsInStock = DataValue.Value
	End Sub

	Private Sub oFmtUnitsOnOrder_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtUnitsOnOrder.UnFormat
		'=============================================================
		'Name: oFmtUnitsOnOrder_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitsOnOrder = DataValue.Value
	End Sub

	Private Sub oFmtReorderLevel_UnFormat(ByVal DataValue As VB6StdDataValue) Handles oFmtReorderLevel.UnFormat
		'=============================================================
		'Name: oFmtReorderLevel_UnFormat
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard UnFormat event.
		'
		'Comment
		'=============================================================
		
		mvFmtReorderLevel = DataValue.Value
	End Sub

	Private Sub txtProductName_Validate(ByRef Cancel As Boolean) Handles txtProductName.Validate
		'=============================================================
		'Name: txtProductName_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtProductName = txtProductName.Text
	End Sub

	Private Sub txtQuantityPerUnit_Validate(ByRef Cancel As Boolean) Handles txtQuantityPerUnit.Validate
		'=============================================================
		'Name: txtQuantityPerUnit_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtQuantityPerUnit = txtQuantityPerUnit.Text
	End Sub

	Private Sub txtUnitPrice_Validate(ByRef Cancel As Boolean) Handles txtUnitPrice.Validate
		'=============================================================
		'Name: txtUnitPrice_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitPrice = txtUnitPrice.Text
	End Sub

	Private Sub txtUnitsInStock_Validate(ByRef Cancel As Boolean) Handles txtUnitsInStock.Validate
		'=============================================================
		'Name: txtUnitsInStock_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitsInStock = txtUnitsInStock.Text
	End Sub

	Private Sub txtUnitsOnOrder_Validate(ByRef Cancel As Boolean) Handles txtUnitsOnOrder.Validate
		'=============================================================
		'Name: txtUnitsOnOrder_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtUnitsOnOrder = txtUnitsOnOrder.Text
	End Sub

	Private Sub txtReorderLevel_Validate(ByRef Cancel As Boolean) Handles txtReorderLevel.Validate
		'=============================================================
		'Name: txtReorderLevel_Validate
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/05/1999 20:26
		'
		'Description: Standard Validate event.
		'
		'Comment
		'=============================================================
		
		mvFmtReorderLevel = txtReorderLevel.Text
	End Sub

End Class
