VERSION 5.00
Begin VB.UserControl uctProductsSingleRecord 
   ClientHeight    =   4440
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4605
   ScaleHeight     =   4440
   ScaleWidth      =   4605
   Begin VB.CheckBox chkDiscontinued 
      Height          =   315
      Left            =   1920
      TabIndex        =   17
      Top             =   3960
      Width           =   2500
   End
   Begin VB.TextBox txtReorderLevel 
      Height          =   315
      Left            =   1920
      TabIndex        =   15
      Text            =   "txtReorderLevel"
      Top             =   3480
      Width           =   2500
   End
   Begin VB.TextBox txtUnitsOnOrder 
      Height          =   315
      Left            =   1920
      TabIndex        =   13
      Text            =   "txtUnitsOnOrder"
      Top             =   3000
      Width           =   2500
   End
   Begin VB.TextBox txtUnitsInStock 
      Height          =   315
      Left            =   1920
      TabIndex        =   11
      Text            =   "txtUnitsInStock"
      Top             =   2520
      Width           =   2500
   End
   Begin VB.TextBox txtUnitPrice 
      Height          =   315
      Left            =   1920
      TabIndex        =   9
      Text            =   "txtUnitPrice"
      Top             =   2040
      Width           =   2500
   End
   Begin VB.TextBox txtQuantityPerUnit 
      Height          =   315
      Left            =   1920
      TabIndex        =   7
      Text            =   "txtQuantityPerUnit"
      Top             =   1560
      Width           =   2500
   End
   Begin VB.ComboBox cmbCategoriesCategoryName 
      Height          =   315
      Left            =   1920
      Style           =   2  'Dropdown List
      TabIndex        =   5
      Tag             =   "Categories"
      Top             =   1080
      Width           =   2500
   End
   Begin VB.ComboBox cmbSuppliersCompanyName 
      Height          =   315
      Left            =   1920
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Tag             =   "Suppliers"
      Top             =   600
      Width           =   2500
   End
   Begin VB.TextBox txtProductName 
      Height          =   315
      Left            =   1920
      TabIndex        =   1
      Text            =   "txtProductName"
      Top             =   120
      Width           =   2500
   End
   Begin VB.Label lblDiscontinued 
      Caption         =   "Discontinued: "
      Height          =   285
      Left            =   120
      TabIndex        =   16
      Top             =   3960
      Width           =   1800
   End
   Begin VB.Label lblReorderLevel 
      Caption         =   "ReorderLevel: "
      Height          =   285
      Left            =   120
      TabIndex        =   14
      Top             =   3480
      Width           =   1800
   End
   Begin VB.Label lblUnitsOnOrder 
      Caption         =   "UnitsOnOrder: "
      Height          =   285
      Left            =   120
      TabIndex        =   12
      Top             =   3000
      Width           =   1800
   End
   Begin VB.Label lblUnitsInStock 
      Caption         =   "UnitsInStock: "
      Height          =   285
      Left            =   120
      TabIndex        =   10
      Top             =   2520
      Width           =   1800
   End
   Begin VB.Label lblUnitPrice 
      Caption         =   "UnitPrice: "
      Height          =   285
      Left            =   120
      TabIndex        =   8
      Top             =   2040
      Width           =   1800
   End
   Begin VB.Label lblQuantityPerUnit 
      Caption         =   "QuantityPerUnit: "
      Height          =   285
      Left            =   120
      TabIndex        =   6
      Top             =   1560
      Width           =   1800
   End
   Begin VB.Label lblCategoriesCategoryName 
      Caption         =   "CategoryName: "
      Height          =   285
      Left            =   120
      TabIndex        =   4
      Top             =   1080
      Width           =   1800
   End
   Begin VB.Label lblSuppliersCompanyName 
      Caption         =   "CompanyName: "
      Height          =   285
      Left            =   120
      TabIndex        =   2
      Top             =   600
      Width           =   1800
   End
   Begin VB.Label lblProductName 
      Caption         =   "ProductName: "
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1800
   End
End
Attribute VB_Name = "uctProductsSingleRecord"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "WizardYN" ,"Yes"
Attribute VB_Ext_KEY = "VBProjectName" ,"Project1"
Attribute VB_Ext_KEY = "DEDesignerName" ,"DataEnvironment1"
Attribute VB_Ext_KEY = "ConnectionName" ,"Connection1"
Attribute VB_Ext_KEY = "CommandName" ,"Products"
Attribute VB_Ext_KEY = "ClassType" ,"User Control"
Attribute VB_Ext_KEY = "DataClassName" ,"rsclsProducts"
Attribute VB_Ext_KEY = "RootName" ,"uctProductsSingleRecord"
Attribute VB_Ext_KEY = "UserControlType" ,"Single Record"
Option Explicit

'=============================================================
'Name: uctProductsSingle Record (The SingleRecordUserControl object)
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: SingleRecordUserControl object using a Data Object Wizard RecordSet class as a DataSource class.
'
'Comment:
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
Private oColBind As BindingCollection

'Use the Data Object Wizard RecordSet class as a DataSource class
Private WithEvents oProducts As rsclsProducts
Attribute oProducts.VB_VarHelpID = -1

'RecordSet Move event
Public Event MoveComplete(oDataSource As Object)

'Add Format object for CheckBox controls
Private oStdDataFormat As StdDataFormat

'Save the adImmediate property when the user moves off the row.
Public SaveMode As EnumSaveMode

'Format object for textbox controls
Private WithEvents oFmtProductName As StdDataFormat
Attribute oFmtProductName.VB_VarHelpID = -1
Private WithEvents oFmtQuantityPerUnit As StdDataFormat
Attribute oFmtQuantityPerUnit.VB_VarHelpID = -1
Private WithEvents oFmtUnitPrice As StdDataFormat
Attribute oFmtUnitPrice.VB_VarHelpID = -1
Private WithEvents oFmtUnitsInStock As StdDataFormat
Attribute oFmtUnitsInStock.VB_VarHelpID = -1
Private WithEvents oFmtUnitsOnOrder As StdDataFormat
Attribute oFmtUnitsOnOrder.VB_VarHelpID = -1
Private WithEvents oFmtReorderLevel As StdDataFormat
Attribute oFmtReorderLevel.VB_VarHelpID = -1

'Format variables for textbox controls
Private mvFmtProductName As Variant
Private mvFmtQuantityPerUnit As Variant
Private mvFmtUnitPrice As Variant
Private mvFmtUnitsInStock As Variant
Private mvFmtUnitsOnOrder As Variant
Private mvFmtReorderLevel As Variant

Public Function InitProducts(Optional oDataSource0 As Variant) As Object
'=============================================================
'Name: InitProducts
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Initializes UserControl object
'
'Comment:
'=============================================================

    'This value is set to true during intialization.
    mbFirstTime = True
    'This value is set to true during intialization.
    mbOKToUpdate = False
    'This value is set to false to Initialize.
    mbUpdateOK = False

    'Reset the DataSource class.
    Set oProducts = Nothing

    'Use the Data Object Wizard RecordSet class as the DataSource class for the datagrid control
    If IsMissing(oDataSource0) Then
        'If DataSource class was not passed as a parameter, create a new instance of the DataSource class.
        Set oProducts = New rsclsProducts
    Else
        'If DataSource class was passed, use that DataSource class.
        Set oProducts = oDataSource0
    End If


    'Set the RecordSet class Foreign Key parameter properties to the UserControl object values

    'Save the adImmediate property when the user moves off the row.
    oProducts.SaveMode = Me.SaveMode

    'Use the BindingCollection class to bind the textbox controls to the DataSource class.
    Set oColBind = New BindingCollection
    mbClassError = False
    oColBind.DataMember = "Products"
    Set oColBind.DataSource = oProducts

    'If there is a DataSource error, exit the function.
    If mbClassError Then
        MsgBox "Cannot initialize DataSource."
        Exit Function
    End If

    'Create the Format object for the checkbox controls.
    Set oStdDataFormat = New StdDataFormat
    oStdDataFormat.Type = fmtCheckbox
    oStdDataFormat.FalseValue = 0
    oStdDataFormat.TrueValue = 1

    'Create the Format object for the textbox controls.
    Set oFmtProductName = New StdDataFormat
    Set oFmtQuantityPerUnit = New StdDataFormat
    Set oFmtUnitPrice = New StdDataFormat
    Set oFmtUnitsInStock = New StdDataFormat
    Set oFmtUnitsOnOrder = New StdDataFormat
    Set oFmtReorderLevel = New StdDataFormat

    'Fill the Foreign Key combobox control.
    Call FillCombo(cmbCategoriesCategoryName, oProducts.rsCategories, "CategoryName", False)
    'Fill the Foreign Key combobox control.
    Call FillCombo(cmbSuppliersCompanyName, oProducts.rsSuppliers, "CompanyName", False)

    'Bind the textbox control to the DataSource class.
    oColBind.Add txtProductName, "Text", "ProductName", oFmtProductName
    'Bind the textbox control to the DataSource class.
    oColBind.Add txtQuantityPerUnit, "Text", "QuantityPerUnit", oFmtQuantityPerUnit
    'Bind the textbox control to the DataSource class.
    oColBind.Add txtUnitPrice, "Text", "UnitPrice", oFmtUnitPrice
    'Bind the textbox control to the DataSource class.
    oColBind.Add txtUnitsInStock, "Text", "UnitsInStock", oFmtUnitsInStock
    'Bind the textbox control to the DataSource class.
    oColBind.Add txtUnitsOnOrder, "Text", "UnitsOnOrder", oFmtUnitsOnOrder
    'Bind the textbox control to the DataSource class.
    oColBind.Add txtReorderLevel, "Text", "ReorderLevel", oFmtReorderLevel
    'Bind the CheckBox control to the DataSource class.
    oColBind.Add chkDiscontinued, "Value", "Discontinued", oStdDataFormat

    'Reset the flag to false.
    mbFirstTime = False

    'Set the combobox controls to the correct Foreign Key values.
    Call SetFKCombos

    'Set the flag to true.
    mbOKToUpdate = True

    'Return the DataSource class.
    Set InitProducts = oProducts
End Function
Public Function MoveToPK(ProductID As Variant) As Boolean

    'Run the DataSource class MoveToPK method with the Primary Key values.
    MoveToPK = oProducts.MoveToPK(ProductID)

End Function
Private Sub oProducts_rsMoveComplete()
'=============================================================
'Name: oProducts_rsMoveComplete()
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Sink the RecordSet class rsMoveComplete event
'
'Comment:
'=============================================================

    mbOKToUpdate = False
    'Update the Foreign Key combobox control.
    If Not mbFirstTime Then Call SetFKCombos
    mbOKToUpdate = True

    RaiseEvent MoveComplete(oProducts)

End Sub

Private Sub UserControl_Terminate()
'=============================================================
'Name: UserControl_Terminate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UserControl object Terminate event
'
'Comment:
'=============================================================

    Set oProducts = Nothing
    Set oColBind = Nothing
End Sub

Private Sub FillCombo(cmbComboBox As ComboBox, oRS As ADODB.Recordset, sDescrField As String, bShowNone As Boolean)
'=============================================================
'Name: FillCombo
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Fills the Foreign Key combobox controls
'
'Comment:
'=============================================================

    'Clear the floating combobox control
    cmbComboBox.Clear

    'Move to the first record of the RecordSet class
    oRS.MoveFirst

    'If the foreign key relationship allows nulls, then put '(None)' as
     'the first combobox Item.
    If bShowNone Then
        cmbComboBox.AddItem "(None)"
        cmbComboBox.ItemData(cmbComboBox.NewIndex) = -1
    End If

    'Load the combobox control from the RecordSet class
    While Not oRS.EOF
        cmbComboBox.AddItem oRS(sDescrField)
        cmbComboBox.ItemData(cmbComboBox.NewIndex) = oRS.AbsolutePosition

        oRS.MoveNext
    Wend

    If cmbComboBox.ListCount > 0 Then
        cmbComboBox.ListIndex = 0
    End If
End Sub

Private Function GetSurKeyCategories(categoryid) As Integer
'=============================================================
'Name: GetSurKeyCategories
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
'
'Comment:
'=============================================================

    oProducts.rsCategories.MoveFirst

    ' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
    While Not oProducts.rsCategories.EOF
        'If the Foreign Key RecordSet field value(s) equal the Select Foreign Key field values, then get the Surrogate Key (AbsolutePosition) value.
        If _
            oProducts.rsCategories("categoryid").Value = Val(categoryid) Then
            'Get the Surrogate Key (AbsolutePosition) value.
            GetSurKeyCategories = oProducts.rsCategories.AbsolutePosition
            Exit Function
        End If
        oProducts.rsCategories.MoveNext
    Wend

    'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
    GetSurKeyCategories = 1

End Function

Private Function GetSurKeySuppliers(supplierid) As Integer
'=============================================================
'Name: GetSurKeySuppliers
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
'
'Comment:
'=============================================================

    oProducts.rsSuppliers.MoveFirst

    ' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
    While Not oProducts.rsSuppliers.EOF
        'If the Foreign Key RecordSet field value(s) equal the Select Foreign Key field values, then get the Surrogate Key (AbsolutePosition) value.
        If _
            oProducts.rsSuppliers("supplierid").Value = Val(supplierid) Then
            'Get the Surrogate Key (AbsolutePosition) value.
            GetSurKeySuppliers = oProducts.rsSuppliers.AbsolutePosition
            Exit Function
        End If
        oProducts.rsSuppliers.MoveNext
    Wend

    'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
    GetSurKeySuppliers = 1

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
'Comment:
'=============================================================

    On Error Resume Next

    If Not mbFirstTime Then
        'Set the combobox control to the correct item for the Foreign Key value.
        cmbCategoriesCategoryName.ListIndex = GetSurKeyCategories(oProducts.categoryid) - 1

        'Set the combobox control to the correct item for the Foreign Key value.
        cmbSuppliersCompanyName.ListIndex = GetSurKeySuppliers(oProducts.supplierid) - 1

    End If

    On Error GoTo 0
End Sub

Private Sub cmbCategoriesCategoryName_Click()
'=============================================================
'Name: cmbCategoriesCategoryName_Click
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard combobox control Click event.
'
'Comment:
'=============================================================

    If mbOKToUpdate Then
        'Update the DataSource class Foreign Key properties.
        If Not mbFirstTime Then Call UpdateFKCategories(cmbCategoriesCategoryName.ItemData(cmbCategoriesCategoryName.ListIndex))
    End If
End Sub

Private Sub cmbSuppliersCompanyName_Click()
'=============================================================
'Name: cmbSuppliersCompanyName_Click
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard combobox control Click event.
'
'Comment:
'=============================================================

    If mbOKToUpdate Then
        'Update the DataSource class Foreign Key properties.
        If Not mbFirstTime Then Call UpdateFKSuppliers(cmbSuppliersCompanyName.ItemData(cmbSuppliersCompanyName.ListIndex))
    End If
End Sub

Private Function UpdateFKCategories(nSurrogateKey As Integer)
'=============================================================
'Name: UpdateFKCategories
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
'
'Comment:
'=============================================================

    If nSurrogateKey = -1 Then
        'Set the actual Foreign Key value to null
        oProducts.categoryid = Null
        oProducts.rsUpdate "categoryid"
    Else
        oProducts.rsCategories.MoveFirst

        'Loop through the Foreign Key RecordSet class until the correct Surrogate Key value(the AbsolutePosition property) is found.
        While Not oProducts.rsCategories.EOF
            If oProducts.rsCategories.AbsolutePosition = Val(nSurrogateKey) Then
                'Set the Select Foreign Key field value to the Foreign Key RecordSet field value.
                oProducts.categoryid = oProducts.rsCategories("categoryid")
                oProducts.rsUpdate "categoryid"
                Exit Function
            End If
            oProducts.rsCategories.MoveNext
        Wend
    End If

End Function

Private Function UpdateFKSuppliers(nSurrogateKey As Integer)
'=============================================================
'Name: UpdateFKSuppliers
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
'
'Comment:
'=============================================================

    If nSurrogateKey = -1 Then
        'Set the actual Foreign Key value to null
        oProducts.supplierid = Null
        oProducts.rsUpdate "supplierid"
    Else
        oProducts.rsSuppliers.MoveFirst

        'Loop through the Foreign Key RecordSet class until the correct Surrogate Key value(the AbsolutePosition property) is found.
        While Not oProducts.rsSuppliers.EOF
            If oProducts.rsSuppliers.AbsolutePosition = Val(nSurrogateKey) Then
                'Set the Select Foreign Key field value to the Foreign Key RecordSet field value.
                oProducts.supplierid = oProducts.rsSuppliers("supplierid")
                oProducts.rsUpdate "supplierid"
                Exit Function
            End If
            oProducts.rsSuppliers.MoveNext
        Wend
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
'Comment:
'=============================================================

    'Trigger the update if the user does not move off the row.
    oProducts.Move 0

    oProducts.UpdateBatch

End Sub

Public Sub Update()
'=============================================================
'Name: Update
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: This subroutine runs the Class object Update method.
'
'Comment:
'=============================================================

    mbUpdateOK = True

    'Trigger the update if the user does not move off the row.
    oProducts.Move 0

    If mbUpdateOK Then
        oProducts.Update
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
'Comment:
'=============================================================

    oProducts.MoveFirst
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
'Comment:
'=============================================================

    oProducts.MovePrevious
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
'Comment:
'=============================================================

    oProducts.MoveNext
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
'Comment:
'=============================================================

    oProducts.MoveLast
End Sub

Private Sub oProducts_ClassError(sProcedureName As String, oErr As ErrObject)
'=============================================================
'Name: oProducts
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: This subroutine performs the Sink action on the ClassError event.
'
'Comment:
'=============================================================

    Dim sStr As String

    sStr = sProcedureName

    If oErr.Description <> "" Then
        sStr = sStr & oErr.Description
    End If

    mbClassError = True

    MsgBox sStr

End Sub

Private Sub UserControl_ReadProperties(PropBag As PropertyBag)
'=============================================================
'Name: UserControl_ReadProperties
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UserControl object ReadProperties event.
'
'Comment:
'=============================================================

    Dim bErrorFlag As Boolean
    Dim sParamName As String

    bErrorFlag = False

    On Error GoTo errUserControl_ReadProperties

    'Set the ManualInitial property to the false value to initialize automatically.
    ManualInitialize = PropBag.ReadProperty("ManualInitialize")

    If Not ManualInitialize Then
        'Read the SaveMode property value.
        sParamName = "SaveMode"
        SaveMode = CLng(PropBag.ReadProperty("SaveMode"))

        'If no errors during the reading of the parameters and the user is in the Visual Basic run mode state, run the DataSource class initialize method.
        If Not bErrorFlag And Ambient.UserMode Then
            InitProducts
        End If

    End If

Exit Sub

errUserControl_ReadProperties:
    bErrorFlag = True
    Resume Next
End Sub

Private Sub UserControl_WriteProperties(PropBag As PropertyBag)
'=============================================================
'Name: UserControl_WriteProperties
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UserControl object WriteProperties event.
'
'Comment:
'=============================================================

    On Error Resume Next

    'The ManualInitialize property is set to the false value to initialize automatically.
    PropBag.WriteProperty "ManualInitialize", ManualInitialize

    If Not ManualInitialize Then
        'Write the SaveMove property value.
        PropBag.WriteProperty "SaveMode", SaveMode

    End If

    On Error GoTo 0

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
'Comment:
'=============================================================

    'Move to trigger RecordSet WillChangeRecord event to save current record.
    oProducts.Move 0

    'Add a blank record to the DataSource RecordSet class.
    oProducts.AddRecord

    'Set all CheckBoxes to True.
    oProducts.Discontinued = True

    'Update the Foreign Key combobox control with the correct value.
    UpdateFKCategories (cmbCategoriesCategoryName.ItemData(cmbCategoriesCategoryName.ListIndex))
    'Update the Foreign Key combobox control with the correct value.
    UpdateFKSuppliers (cmbSuppliersCompanyName.ItemData(cmbSuppliersCompanyName.ListIndex))
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
'Comment:
'=============================================================

    'Delete the current DataSource record.
    oProducts.Delete
End Sub

Private Sub oFmtProductName_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtProductName_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtProductName) And mvFmtProductName <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "ProductName error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtQuantityPerUnit_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtQuantityPerUnit_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtQuantityPerUnit) And mvFmtQuantityPerUnit <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "QuantityPerUnit error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtUnitPrice_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitPrice_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtUnitPrice) And mvFmtUnitPrice <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "UnitPrice error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtUnitsInStock_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitsInStock_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtUnitsInStock) And mvFmtUnitsInStock <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "UnitsInStock error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtUnitsOnOrder_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitsOnOrder_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtUnitsOnOrder) And mvFmtUnitsOnOrder <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "UnitsOnOrder error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtReorderLevel_Format(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtReorderLevel_Format
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Format event.
'
'Comment:
'=============================================================

    If mbUpdateOK And Not IsEmpty(mvFmtReorderLevel) And mvFmtReorderLevel <> CStr(DataValue) And Not mbFirstTime Then
        MsgBox "ReorderLevel error."

        mbUpdateOK = False
    End If
End Sub

Private Sub oFmtProductName_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtProductName_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtProductName = DataValue
End Sub

Private Sub oFmtQuantityPerUnit_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtQuantityPerUnit_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtQuantityPerUnit = DataValue
End Sub

Private Sub oFmtUnitPrice_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitPrice_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtUnitPrice = DataValue
End Sub

Private Sub oFmtUnitsInStock_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitsInStock_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtUnitsInStock = DataValue
End Sub

Private Sub oFmtUnitsOnOrder_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtUnitsOnOrder_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtUnitsOnOrder = DataValue
End Sub

Private Sub oFmtReorderLevel_UnFormat(ByVal DataValue As StdFormat.StdDataValue)
'=============================================================
'Name: oFmtReorderLevel_UnFormat
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard UnFormat event.
'
'Comment:
'=============================================================

    mvFmtReorderLevel = DataValue
End Sub

Private Sub txtProductName_Validate(Cancel As Boolean)
'=============================================================
'Name: txtProductName_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtProductName = txtProductName.Text
End Sub

Private Sub txtQuantityPerUnit_Validate(Cancel As Boolean)
'=============================================================
'Name: txtQuantityPerUnit_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtQuantityPerUnit = txtQuantityPerUnit.Text
End Sub

Private Sub txtUnitPrice_Validate(Cancel As Boolean)
'=============================================================
'Name: txtUnitPrice_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtUnitPrice = txtUnitPrice.Text
End Sub

Private Sub txtUnitsInStock_Validate(Cancel As Boolean)
'=============================================================
'Name: txtUnitsInStock_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtUnitsInStock = txtUnitsInStock.Text
End Sub

Private Sub txtUnitsOnOrder_Validate(Cancel As Boolean)
'=============================================================
'Name: txtUnitsOnOrder_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtUnitsOnOrder = txtUnitsOnOrder.Text
End Sub

Private Sub txtReorderLevel_Validate(Cancel As Boolean)
'=============================================================
'Name: txtReorderLevel_Validate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:26
'
'Description: Standard Validate event.
'
'Comment:
'=============================================================

    mvFmtReorderLevel = txtReorderLevel.Text
End Sub




