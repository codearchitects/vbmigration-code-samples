' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports CodeArchitects.VB6Library.Events

<VB6Object("Project1.uctProductsDataGrid")> _
Friend Class uctProductsDataGrid

	'=============================================================
	'Name: uctProducts2DataGrid (The DataGrid UserControl object)
	'
	'Author: Microsoft Data Object Wizard
	'
	'Date: 01/06/1999 02:03
	'
	'Description: DataGrid UserControl object using a Data Object Wizard RecordSet class as a DataSource class.
	'
	'Comment
	'=============================================================
	
	'The current datagrid control column
	Private mlCurrentCol As Integer
	
	'Prohibits several operations the first time the datagrid control loads.
	Private mbFirstTime As Boolean
	'Prohibits showing the listbox control as the datagrid control loads for the first time.
	Private mbShowCombo As Boolean
	'Allows the datagrid control to be editable and displays the listbox control on columns with the Foreign Key attributes.
	Public GridEditable As Boolean
	'True if an error occurred in the DataSource class.
	Private mbClassError As Boolean
	
	'Create the datagrid control column constants
	Private Const PRODUCTID_COLUMN As Integer = 0
	Private Const PRODUCTNAME_COLUMN As Integer = 1
	Private Const SUPPLIERID_COLUMN As Integer = 2
	Private Const SUPPLIERSCOMPANYNAME_COLUMN As Integer = 3
	Private Const CATEGORYID_COLUMN As Integer = 4
	Private Const CATEGORIESCATEGORYNAME_COLUMN As Integer = 5
	Private Const QUANTITYPERUNIT_COLUMN As Integer = 6
	Private Const UNITPRICE_COLUMN As Integer = 7
	Private Const UNITSINSTOCK_COLUMN As Integer = 8
	Private Const UNITSONORDER_COLUMN As Integer = 9
	Private Const REORDERLEVEL_COLUMN As Integer = 10
	Private Const DISCONTINUED_COLUMN As Integer = 11
	
	'Create parameter properties for the Select RecordSet class
	Public Products_FetchProductName As Object
	
	'Create the Foreign Key Parameter properties for the RecordSet classes
	
	'Use the Data Object Wizard RecordSet class as a DataSource class
	Private WithEvents oProducts2 As rsclsProducts2
	'Set the ManualInitialize property to false to automatically initialize or true to manually inititalize the UserControl object
	Public ManualInitialize As Boolean
	
	'The RecordSet Move event
	Public Event MoveComplete As VB6WebBrowserobjectEventHandler
	
	'Format the object for the datagrid control Boolean columns
	Private oStdDataFormat As VB6StdDataFormat
	
	'Save the adImmediate property when the user moves off the row.
	Public SaveMode As EnumSaveMode
	
	Public Function InitProducts2(Optional ByVal oProducts20 As Object = VB6Missing) As Object
		'=============================================================
		'Name: InitProducts2
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Initializes the datagrid control.
		'
		'Comment
		'=============================================================
		
		'Set flags to true on load.
		mbFirstTime = True
		mbShowCombo = True
		
		'Create Format object for the datagrid control Boolean columns
		oStdDataFormat = New VB6StdDataFormat()
		oStdDataFormat.Type = StdFormat.FormatType.fmtBoolean
		oStdDataFormat.FalseValue = "False"
		oStdDataFormat.TrueValue = "True"
		
		On Error GoTo InitProducts2Err 
		
		'Reset the DataSource class.
		oProducts2 = Nothing
		
		'Use the Data Object Wizard RecordSet class as the DataSource class for the datagrid control
		If IsMissing6(oProducts20) Then 
			'If the DataSource class was not passed as a parameter, create the DataSource class.
			oProducts2 = New rsclsProducts2()
		Else
			'Use the DataSource class passed as a parameter.
			oProducts2 = oProducts20
		End If
		
		'Set the RecordSet class Select parameter properties to the UserControl object values
		oProducts2.Products_FetchProductName = Me.Products_FetchProductName
		
		'Set the RecordSet class Foreign Key parameter properties to the UserControl object values
		
		'Save the adImmediate property when the user moves off the row.
		oProducts2.SaveMode = Me.SaveMode
		
		'Set the source of data for the datagrid control
		mbClassError = False
		grdProducts2.DataMember = "PRODUCTS_FETCH"
		grdProducts2.DataSource = oProducts2
		
		'If there is an error, exit the function.
		If mbClassError Then 
			MsgBox6("Cannot initialize grid control.")
			Exit Function
		End If
		
		'Allow new records and deletes for the datagrid control
		If GridEditable Then 
			grdProducts2.AllowAddNew = True
			grdProducts2.AllowDelete = True
			grdProducts2.AllowUpdate = True
		Else
			grdProducts2.AllowAddNew = False
			grdProducts2.AllowDelete = False
			grdProducts2.AllowUpdate = False
		End If
		
		'Show both scroll bars for the control.
		grdProducts2.ScrollBars = MSDataGridLib.ScrollBarsConstants.dbgBoth
		'Since the listbox control height cannot resize, force the same for the datagrid control RowHeight property.
		grdProducts2.AllowRowSizing = False
		'Set the RowHeight property to make the listbox controls appear in the row of the datagrid control.
		grdProducts2.RowHeight = 288
		
		'Hide columns not used in control
		grdProducts2.Columns(PRODUCTID_COLUMN).Width = 0
		grdProducts2.Columns(SUPPLIERID_COLUMN).Width = 0
		grdProducts2.Columns(CATEGORYID_COLUMN).Width = 0
		
		'Column Headings for the datagrid control
		grdProducts2.Columns(PRODUCTID_COLUMN).Caption = "ProductID"
		grdProducts2.Columns(PRODUCTNAME_COLUMN).Caption = "ProductName"
		grdProducts2.Columns(SUPPLIERID_COLUMN).Caption = "SupplierID"
		grdProducts2.Columns(SUPPLIERSCOMPANYNAME_COLUMN).Caption = "CompanyName"
		grdProducts2.Columns(CATEGORYID_COLUMN).Caption = "CategoryID"
		grdProducts2.Columns(CATEGORIESCATEGORYNAME_COLUMN).Caption = "CategoryName"
		grdProducts2.Columns(QUANTITYPERUNIT_COLUMN).Caption = "QuantityPerUnit"
		grdProducts2.Columns(UNITPRICE_COLUMN).Caption = "UnitPrice"
		grdProducts2.Columns(UNITSINSTOCK_COLUMN).Caption = "UnitsInStock"
		grdProducts2.Columns(UNITSONORDER_COLUMN).Caption = "UnitsOnOrder"
		grdProducts2.Columns(REORDERLEVEL_COLUMN).Caption = "ReorderLevel"
		grdProducts2.Columns(DISCONTINUED_COLUMN).Caption = "Discontinued"
		
		'Return the Class object.
		grdProducts2.Columns(DISCONTINUED_COLUMN).DataFormat = ToStdDataFormat6(oStdDataFormat)
		
		'Save the current column of the datagrid control
		mlCurrentCol = grdProducts2.Col
		
		'Set the Flag to false
		mbFirstTime = False
		
		'Return the Class object.
		InitProducts2 = oProducts2
		
		'Resize the datagrid control to the UserControl object when we are in the Visual Basic Run Time mode.
		grdProducts2.Top = MyBase.ScaleTop
		grdProducts2.Left = MyBase.ScaleLeft
		grdProducts2.Height = MyBase.ScaleHeight
		grdProducts2.Width = MyBase.ScaleWidth
		
		Exit Function
		
InitProducts2Err:
	End Function

	Private Sub FillCombo(ByVal Ctrl As VB6ComboBox, ByVal oRS As ADODB.Recordset, ByVal nDescrField As String, ByVal bShowNone As Boolean)
		'=============================================================
		'Name: FillCombo
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Fills the Foreign Key as hidden in the combobox control
		'
		'Comment
		'=============================================================
		
		'Clear the floating combobox control
		Ctrl.Clear()
		
		'If Foreign Key Identifier field is nullable then put '(None)' as the first record in listbox control
		If bShowNone Then 
			Ctrl.AddItem("(None)")
			Ctrl.ItemData(Ctrl.NewIndex) = -1
		End If
		
		'Move to the first record of the RecordSet class
		oRS.MoveFirst()
		
		'Load the combobox control from the RecordSet class
		While Not oRS.EOF
			Ctrl.AddItem(oRS.Fields(nDescrField).Value)
			Ctrl.ItemData(Ctrl.NewIndex) = oRS.AbsolutePosition
			oRS.MoveNext()
		End While
		
		On Error Resume Next 
		Select Case grdProducts2.Col
			'Set the listbox control to the Foreign Key value.
		Case CATEGORIESCATEGORYNAME_COLUMN
			Ctrl.ListIndex = GetSurKeyCategories(oProducts2.categoryid) - 1
			'Set the listbox control to the Foreign Key value.
		Case SUPPLIERSCOMPANYNAME_COLUMN
			Ctrl.ListIndex = GetSurKeySuppliers(oProducts2.supplierid) - 1
		End Select
		' IGNORED: On Error GoTo 0 
	End Sub

	Private Sub ShowFloatingControl(ByVal Ctrl As VB6ComboBox, ByVal nColNumber As Short, ByVal nRow As Short)
		'=============================================================
		'Name: ShowFloatingControl
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Locates and unhides the Foreign Key listbox control.
		'
		'Comment
		'=============================================================
		
		Dim oCol As CodeArchitects.VB6LibraryOcx.VB6DataGridColumn = grdProducts2.Columns(nColNumber)
		
		'Set the listbox control to the clicked datagrid control column
		
		'Move and show the listbox control
		With Ctrl
			.Left = grdProducts2.Left + oCol.Left
			.Top = grdProducts2.Top + grdProducts2.RowTop(grdProducts2.Row)
			.Width = oCol.Width + Screen6.TwipsPerPixelX
			If nRow = -1 Then 
				.ListIndex = 0
			Else
				.ListIndex = nRow
			End If
			
			.ZOrder(0)
			
			'If the listbox control is outside of the datagrid control, don't show the datagrid control.
			If oCol.Left + oCol.Width <= grdProducts2.Left + grdProducts2.Width Then 
				.Visible = True
				.SetFocus()
			Else
				grdProducts2.Col = 0
			End If
			
		End With
		
	End Sub

	Private Sub grdProducts2_RowColChange(ByRef LastRow As Object, ByVal LastCol As Short) Handles grdProducts2.RowColChange
		'=============================================================
		'Name: grdProducts2DataGrid_ButtonClick
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard DataGrid control ButtonClick event code.
		'
		'Comment
		'=============================================================
		
		cmbEdit.Visible = False
		
		'Exit the procudure if the GridEditable property is set to false
		If mbFirstTime Or (Not mbShowCombo) Or (Not GridEditable) Then 
			Exit Sub
		End If
		
		'Save the datagrid controls current cell position
		mlCurrentCol = grdProducts2.Col
		
		'Show the floating listbox control based on the datagrid controls column property
		Select Case mlCurrentCol
			'Fill the listbox control, set the control to the value of the Foreign Key and show it.
		Case CATEGORIESCATEGORYNAME_COLUMN
			FillCombo(cmbEdit, ByVal6(oProducts2.rsCategories), "CategoryName", False)
			If grdProducts2.Row = -1 Then 
				My.Computer.Keyboard.SendKeys(cmbEdit.List(0))
			Else
				ShowFloatingControl(cmbEdit, CATEGORIESCATEGORYNAME_COLUMN, GetSurKeyCategories(grdProducts2.Columns(CATEGORYID_COLUMN).Text) - 1)
			End If
			'Fill the listbox control, set the control to the value of the Foreign Key and show it.
		Case SUPPLIERSCOMPANYNAME_COLUMN
			FillCombo(cmbEdit, ByVal6(oProducts2.rsSuppliers), "CompanyName", False)
			If grdProducts2.Row = -1 Then 
				My.Computer.Keyboard.SendKeys(cmbEdit.List(0))
			Else
				ShowFloatingControl(cmbEdit, SUPPLIERSCOMPANYNAME_COLUMN, GetSurKeySuppliers(grdProducts2.Columns(SUPPLIERID_COLUMN).Text) - 1)
			End If
		Case Else
			cmbEdit.Visible = False
		End Select
	End Sub

	Private Sub grdProducts2_Scroll(ByRef Cancel As Short) Handles grdProducts2.Scroll6
		'=============================================================
		'Name: grdProducts2_Scroll
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard DataGrid control Scroll event.
		'
		'Comment
		'=============================================================
		
		'Hide the listbox control
		cmbEdit.Visible = False
		
	End Sub

	Private Function GetSurKeyCategories(ByVal categoryid As Object) As Short
	' UPGRADE_INFO (#0561): The 'categoryid' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: GetSurKeyCategories
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
		'
		'Comment
		'=============================================================
		
		oProducts2.rsCategories.MoveFirst()
		
		' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
		While Not oProducts2.rsCategories.EOF
			If oProducts2.rsCategories.Fields("categoryid").Value = Val(categoryid) Then 
				'Return the Surrogate Key value.
				Return oProducts2.rsCategories.AbsolutePosition
			End If
			
			oProducts2.rsCategories.MoveNext()
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
		'Date: 01/06/1999 02:03
		'
		'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
		'
		'Comment
		'=============================================================
		
		oProducts2.rsSuppliers.MoveFirst()
		
		' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
		While Not oProducts2.rsSuppliers.EOF
			If oProducts2.rsSuppliers.Fields("supplierid").Value = Val(supplierid) Then 
				'Return the Surrogate Key value.
				Return oProducts2.rsSuppliers.AbsolutePosition
			End If
			
			oProducts2.rsSuppliers.MoveNext()
		End While
		
		'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
		Return 1
		
	End Function

	Private Function UpdateFKCategories(ByVal nSurrogateKey As Short) As Object
	' UPGRADE_INFO (#0561): The 'UpdateFKCategories' symbol was defined without an explicit "As" clause.
		'=============================================================
		'Name: UpdateFKCategories
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
		'
		'Comment
		'=============================================================
		
		If nSurrogateKey = -1 Then 
			'Set the actual Foreign Key value to null
			oProducts2.categoryid = VB6Null
		Else
			oProducts2.rsCategories.MoveFirst()
			
			'Move the Foreign Key RecordSet class to the Surrogate Key value(the AbsolutePosition property.)
			While Not oProducts2.rsCategories.EOF
				If oProducts2.rsCategories.AbsolutePosition = Val(nSurrogateKey) Then 
					'Set the DataSource class property to the value of the Foreign Key RecordSet class field.
					oProducts2.categoryid = oProducts2.rsCategories.Fields("categoryid").Value
					Exit Function
				End If
				oProducts2.rsCategories.MoveNext()
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
		'Date: 01/06/1999 02:03
		'
		'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
		'
		'Comment
		'=============================================================
		
		If nSurrogateKey = -1 Then 
			'Set the actual Foreign Key value to null
			oProducts2.supplierid = VB6Null
		Else
			oProducts2.rsSuppliers.MoveFirst()
			
			'Move the Foreign Key RecordSet class to the Surrogate Key value(the AbsolutePosition property.)
			While Not oProducts2.rsSuppliers.EOF
				If oProducts2.rsSuppliers.AbsolutePosition = Val(nSurrogateKey) Then 
					'Set the DataSource class property to the value of the Foreign Key RecordSet class field.
					oProducts2.supplierid = oProducts2.rsSuppliers.Fields("supplierid").Value
					Exit Function
				End If
				oProducts2.rsSuppliers.MoveNext()
			End While
		End If
		
	End Function

	Public Sub UpdateBatch()
		'=============================================================
		'Name: UpdateBatch
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: This subroutine runs the Class control UpdateBatch method.
		'
		'Comment
		'=============================================================
		
		cmbEdit.Visible = False
		
		mbShowCombo = False
		
		oProducts2.UpdateBatch()
		
		mbShowCombo = True
		
	End Sub
	
	Public Shadows Sub Update()
		'=============================================================
		'Name: Update
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: This subroutine runs the Class object Update method.
		'
		'Comment
		'=============================================================
		
		cmbEdit.Visible = False
		
		oProducts2.Update()
		
	End Sub
	
	Private Sub cmbEdit_Click() Handles cmbEdit.Click
		'=============================================================
		'Name: cmbEdit_Click
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard lstEdit control click event.
		'
		'Comment
		'=============================================================
		
		If cmbEdit.Visible Then 
			Select Case mlCurrentCol
			Case CATEGORIESCATEGORYNAME_COLUMN
				'Run the UpdateFK method to update the DataSource class Foreign Key Property value(s).
				UpdateFKCategories(cmbEdit.ItemData(cmbEdit.ListIndex))
			Case SUPPLIERSCOMPANYNAME_COLUMN
				'Run the UpdateFK method to update the DataSource class Foreign Key Property value(s).
				UpdateFKSuppliers(cmbEdit.ItemData(cmbEdit.ListIndex))
			End Select
			
			'Update the datagrid control's cell with the listbox control List value.
			If cmbEdit.List(cmbEdit.ListIndex) = "(None)" Then 
				grdProducts2.Text = "(None)"
			Else
				grdProducts2.Text = cmbEdit.List(cmbEdit.ListIndex)
			End If
		End If
		
		cmbEdit.Visible = False
	End Sub

	Private Sub oProducts2_ClassError(ByRef sProcedureName As String, ByRef oErr As ErrObject) Handles oProducts2.ClassError
		'=============================================================
		'Name: oProducts2
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
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
		'Date: 01/06/1999 02:03
		'
		'Description: Standard UserControl object ReadProperties Event.
		'
		'Comment
		'=============================================================
		
		Dim bErrorFlag As Boolean = False
		Dim sParamName As String = ""

		On Error GoTo errUserControl_ReadProperties 
		
		'Set ManualInitialize property to false to initialize the datagrid control automatically.
		ManualInitialize = PropBag.ReadProperty("ManualInitialize")
		
		'Set GridEditable property to true to allow editing of the datagrid control and activate Foreign Key listbox controls.
		GridEditable = PropBag.ReadProperty("GridEditable")
		
		If Not ManualInitialize Then 
			sParamName = "Products_FetchProductName"
			'Set the Select command parameter property value.
			Products_FetchProductName = (PropBag.ReadProperty("Products_FetchProductName"))
			
			'Read the SaveMode property value.
			sParamName = "SaveMode"
			SaveMode = CInt(PropBag.ReadProperty("SaveMode"))
			
			'If parameter values were read then initialize the DataSource class.
			If Not bErrorFlag And Ambient.UserMode Then 
				InitProducts2()
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
		'Date: 01/06/1999 02:03
		'
		'Description: Standard UserControl object WriteProperties event.
		'
		'Comment
		'=============================================================
		
		On Error Resume Next 
		
		'Set the ManualInitialize property to false to initialize the datagrid control automatically.
		PropBag.WriteProperty("ManualInitialize", ManualInitialize)
		
		'Set the GridEditable property to true to allow editing the datagrid control and activate the Foreign Key listbox controls.
		PropBag.WriteProperty("GridEditable", GridEditable)
		
		If Not ManualInitialize Then 
			'Write the Select command parameter value.
			PropBag.WriteProperty("Products_FetchProductName", Products_FetchProductName)
			
			'Write the SaveMove property value.
			PropBag.WriteProperty("SaveMode", SaveMode)
			
		End If
		
		' IGNORED: On Error GoTo 0 
		
	End Sub
	
	Private Sub UserControl_Resize() Handles MyBase.Resize
		'=============================================================
		'Name: UserControl_Resize
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard UserControl object Resize event.
		'
		'Comment
		'=============================================================
		
		'Resize the datagrid control to the UserControl object when we are in Visual Basic Design Time mode.
		grdProducts2.Top = MyBase.ScaleTop
		grdProducts2.Left = MyBase.ScaleLeft
		grdProducts2.Height = MyBase.ScaleHeight
		grdProducts2.Width = MyBase.ScaleWidth
		
	End Sub

	Public Sub oProducts2_rsMoveComplete() Handles oProducts2.rsMoveComplete
		'=============================================================
		'Name: MoveComplete
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: UserControl object MoveComplete event.
		'
		'Comment
		'=============================================================
		
		VB6WebBrowserobjectEventDispatcher.Raise(Me, "MoveComplete", oProducts2)
	End Sub

	Private Sub grdProducts2_ColResize(ByVal ColIndex As Short, ByRef Cancel As Short) Handles grdProducts2.ColResize
		'=============================================================
		'Name: grdProducts2_ColResize
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard DataGrid control ColResize event.
		'
		'Comment
		'=============================================================
		
		If cmbEdit.Visible Then 
			If grdProducts2.Columns(mlCurrentCol).Left + grdProducts2.Columns(mlCurrentCol).Width <= grdProducts2.Left + grdProducts2.Width Then 
				'If the listbox control does not extend past the datagrid control, then resize the listbox control to the column width of the datagrid control.
				cmbEdit.Left = grdProducts2.Left + grdProducts2.Columns(mlCurrentCol).Left
				cmbEdit.Width = grdProducts2.Columns(mlCurrentCol).Width
			Else
				'If the listbox control extends past the datagrid control, then do not show the listbox control.
				cmbEdit.Visible = False
			End If
		End If
	End Sub

	Private Sub grdProducts2_KeyPress(ByRef KeyAscii As Short) Handles grdProducts2.KeyPress6
		'=============================================================
		'Name: grdProducts2_KeyPress
		'
		'Author: Microsoft Data Object Wizard
		'
		'Date: 01/06/1999 02:03
		'
		'Description: Standard DataGrid control KeyPress event.
		'
		'Comment
		'=============================================================
		
		Select Case grdProducts2.Col
		Case Is = CATEGORIESCATEGORYNAME_COLUMN, SUPPLIERSCOMPANYNAME_COLUMN
			KeyAscii = 0
		Case Is = 1, 10

		End Select
	End Sub

End Class
