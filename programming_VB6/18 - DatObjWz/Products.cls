VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 1  'vbDataSource
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "rsclsProducts"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "WizardYN" ,"Yes"
Attribute VB_Ext_KEY = "VBProjectName" ,"Project1"
Attribute VB_Ext_KEY = "DEDesignerName" ,"DataEnvironment1"
Attribute VB_Ext_KEY = "ConnectionName" ,"Connection1"
Attribute VB_Ext_KEY = "CommandName" ,"Products"
Attribute VB_Ext_KEY = "ClassRootName" ,"Products"
Attribute VB_Ext_KEY = "ClassType" ,"Data Class"
Attribute VB_Ext_KEY = "SelectCommandName" ,"Products"
Attribute VB_Ext_KEY = "FieldNullableProductID" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKProductID" ,"Yes"
Attribute VB_Ext_KEY = "FieldNullableProductName" ,"No"
Attribute VB_Ext_KEY = "FieldPKProductName" ,"No"
Attribute VB_Ext_KEY = "FieldNullableSupplierID" ,"No"
Attribute VB_Ext_KEY = "FieldPKSupplierID" ,"No"
Attribute VB_Ext_KEY = "FieldNullableCategoryID" ,"No"
Attribute VB_Ext_KEY = "FieldPKCategoryID" ,"No"
Attribute VB_Ext_KEY = "FieldNullableQuantityPerUnit" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKQuantityPerUnit" ,"No"
Attribute VB_Ext_KEY = "FieldNullableUnitPrice" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKUnitPrice" ,"No"
Attribute VB_Ext_KEY = "FieldNullableUnitsInStock" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKUnitsInStock" ,"No"
Attribute VB_Ext_KEY = "FieldNullableUnitsOnOrder" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKUnitsOnOrder" ,"No"
Attribute VB_Ext_KEY = "FieldNullableReorderLevel" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKReorderLevel" ,"No"
Attribute VB_Ext_KEY = "FieldNullableDiscontinued" ,"Yes"
Attribute VB_Ext_KEY = "FieldPKDiscontinued" ,"No"
Attribute VB_Ext_KEY = "InsertCommandName" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME1" ,"ProductName"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME1" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME1" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE1" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME1" ,"ProductName"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME2" ,"CategoryID"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME2" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME2" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE2" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME2" ,"CategoryID"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME3" ,"SupplierID"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME3" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME3" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE3" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME3" ,"SupplierID"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME4" ,"QuantityPerUnit"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME4" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME4" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE4" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME4" ,"QuantityPerUnit"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME5" ,"UnitPrice"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME5" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME5" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE5" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME5" ,"UnitPrice"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME6" ,"UnitsInStock"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME6" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME6" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE6" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME6" ,"UnitsInStock"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME7" ,"UnitsOnOrder"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME7" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME7" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE7" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME7" ,"UnitsOnOrder"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME8" ,"ReorderLevel"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME8" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME8" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE8" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME8" ,"ReorderLevel"
Attribute VB_Ext_KEY = "InsertCommand_FIELDNAME9" ,"Discontinued"
Attribute VB_Ext_KEY = "InsertCommand_SELECTCOMMANDNAME9" ,"Products"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDNAME9" ,"Products_Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERCOMMANDTYPE9" ,"Insert"
Attribute VB_Ext_KEY = "InsertCommand_PARAMETERNAME9" ,"Discontinued"
Attribute VB_Ext_KEY = "InsertCommand_FIELDPARAMETERCOUNT" ,"9"
Attribute VB_Ext_KEY = "InsertCommand_USEASUPDATE" ,"False"
Attribute VB_Ext_KEY = "UpdateCommandName" ,"Products_Update"
Attribute VB_Ext_KEY = "DeleteCommandName" ,"Products_Delete"
Attribute VB_Ext_KEY = "DeleteCommand_FIELDNAME1" ,"ProductID"
Attribute VB_Ext_KEY = "DeleteCommand_SELECTCOMMANDNAME1" ,"Products"
Attribute VB_Ext_KEY = "DeleteCommand_PARAMETERCOMMANDNAME1" ,"Products_Delete"
Attribute VB_Ext_KEY = "DeleteCommand_PARAMETERCOMMANDTYPE1" ,"Delete"
Attribute VB_Ext_KEY = "DeleteCommand_PARAMETERNAME1" ,"ProductID"
Attribute VB_Ext_KEY = "DeleteCommand_FIELDPARAMETERCOUNT" ,"1"
Attribute VB_Ext_KEY = "FKCommand1" ,"Categories"
Attribute VB_Ext_KEY = "FKCommand1_SELECTFIELDNAME1" ,"categoryid"
Attribute VB_Ext_KEY = "FKCommand1_SELECTCOMMANDNAME1" ,"Products"
Attribute VB_Ext_KEY = "FKCommand1_FKFIELDNAME1" ,"categoryid"
Attribute VB_Ext_KEY = "FKCommand1_FKCOMMANDNAME1" ,"Categories"
Attribute VB_Ext_KEY = "FKCommand1_FKDESCRIPTOR1" ,"CategoryName"
Attribute VB_Ext_KEY = "FKCommand1_FKNULLABLE1" ,"No"
Attribute VB_Ext_KEY = "FKCommand1_FKPKCount" ," 1"
Attribute VB_Ext_KEY = "FKCommand2" ,"Suppliers"
Attribute VB_Ext_KEY = "FKCommand2_SELECTFIELDNAME1" ,"supplierid"
Attribute VB_Ext_KEY = "FKCommand2_SELECTCOMMANDNAME1" ,"Products"
Attribute VB_Ext_KEY = "FKCommand2_FKFIELDNAME1" ,"supplierid"
Attribute VB_Ext_KEY = "FKCommand2_FKCOMMANDNAME1" ,"Suppliers"
Attribute VB_Ext_KEY = "FKCommand2_FKDESCRIPTOR1" ,"CompanyName"
Attribute VB_Ext_KEY = "FKCommand2_FKNULLABLE1" ,"No"
Attribute VB_Ext_KEY = "FKCommand2_FKPKCount" ," 1"
Attribute VB_Ext_KEY = "NumFKCommands" ,"2"
Attribute VB_Ext_KEY = "NumInterfaces" ,"1"
Attribute VB_Ext_KEY = "UseSelectCommand" ,"False"
Option Explicit

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
Private WithEvents rs As Recordset
Attribute rs.VB_VarHelpID = -1

'Variant to store system generated Primary Key values.
Private vPKValues() As Variant

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
Public Event rsUpdateEvent(vFieldName As Variant)
'This event is run for certain class errors.
Public Event ClassError(sProcedureName As String, oErr As ErrObject)

' rsclsProducts Foreign Key RecordSet classes
Public rsSuppliers As ADODB.Recordset
Public rsCategories As ADODB.Recordset

'Foreign Key Parameter properties for the RecordSet classes.

'The external interface Get and Let properties.
Public Property Get ProductID() As Variant
    ProductID = rs("ProductID")
End Property
Public Property Let ProductID(vProductID As Variant)
    If IsNull(vProductID) Then
        rs("ProductID") = Null
    Else
        rs("ProductID") = CLng(vProductID)
    End If
End Property

Public Property Get ProductName() As Variant
    ProductName = rs("ProductName")
End Property
Public Property Let ProductName(vProductName As Variant)
    If IsNull(vProductName) Then
        rs("ProductName") = Null
    Else
        rs("ProductName") = CStr(vProductName)
    End If
End Property

Public Property Get supplierid() As Variant
    supplierid = rs("SupplierID")
End Property
Public Property Let supplierid(vSupplierID As Variant)
    If IsNull(vSupplierID) Then
        rs("SupplierID") = Null
    Else
        rs("SupplierID") = CLng(vSupplierID)
    End If
End Property

Public Property Get categoryid() As Variant
    categoryid = rs("CategoryID")
End Property
Public Property Let categoryid(vCategoryID As Variant)
    If IsNull(vCategoryID) Then
        rs("CategoryID") = Null
    Else
        rs("CategoryID") = CLng(vCategoryID)
    End If
End Property

Public Property Get QuantityPerUnit() As Variant
    QuantityPerUnit = rs("QuantityPerUnit")
End Property
Public Property Let QuantityPerUnit(vQuantityPerUnit As Variant)
    If IsNull(vQuantityPerUnit) Then
        rs("QuantityPerUnit") = Null
    Else
        rs("QuantityPerUnit") = CStr(vQuantityPerUnit)
    End If
End Property

Public Property Get UnitPrice() As Variant
    UnitPrice = rs("UnitPrice")
End Property
Public Property Let UnitPrice(vUnitPrice As Variant)
    If IsNull(vUnitPrice) Then
        rs("UnitPrice") = Null
    Else
        rs("UnitPrice") = CCur(vUnitPrice)
    End If
End Property

Public Property Get UnitsInStock() As Variant
    UnitsInStock = rs("UnitsInStock")
End Property
Public Property Let UnitsInStock(vUnitsInStock As Variant)
    If IsNull(vUnitsInStock) Then
        rs("UnitsInStock") = Null
    Else
        rs("UnitsInStock") = CInt(vUnitsInStock)
    End If
End Property

Public Property Get UnitsOnOrder() As Variant
    UnitsOnOrder = rs("UnitsOnOrder")
End Property
Public Property Let UnitsOnOrder(vUnitsOnOrder As Variant)
    If IsNull(vUnitsOnOrder) Then
        rs("UnitsOnOrder") = Null
    Else
        rs("UnitsOnOrder") = CInt(vUnitsOnOrder)
    End If
End Property

Public Property Get ReorderLevel() As Variant
    ReorderLevel = rs("ReorderLevel")
End Property
Public Property Let ReorderLevel(vReorderLevel As Variant)
    If IsNull(vReorderLevel) Then
        rs("ReorderLevel") = Null
    Else
        rs("ReorderLevel") = CInt(vReorderLevel)
    End If
End Property

Public Property Get Discontinued() As Variant
    Discontinued = rs("Discontinued")
End Property
Public Property Let Discontinued(vDiscontinued As Variant)
    If IsNull(vDiscontinued) Then
        rs("Discontinued") = Null
    Else
        rs("Discontinued") = CBool(vDiscontinued)
    End If
End Property

'The RecordSet Beginnig Of File status.
Public Property Get BOF() As Boolean
    BOF = rs.BOF
End Property

'The RecordSet EndOfFile status.
Public Property Get EOF() As Boolean
    EOF = rs.EOF
End Property

'The RecordSet AbsolutePosition property.
Public Property Let AbsolutePosition(lAbsolutePosition As Long)
    rs.AbsolutePosition = lAbsolutePosition
End Property

Public Property Get AbsolutePosition() As Long
    AbsolutePosition = rs.AbsolutePosition
End Property

'The Foreign Key Descriptor properties.
Public Property Get CategoriesCategoryName() As Variant
    CategoriesCategoryName = rs("CategoriesCategoryName")
End Property
Public Property Let CategoriesCategoryName(vCategoryName As Variant)
    rs("CategoriesCategoryName") = vCategoryName
End Property
Public Property Get SuppliersCompanyName() As Variant
    SuppliersCompanyName = rs("SuppliersCompanyName")
End Property
Public Property Let SuppliersCompanyName(vCompanyName As Variant)
    rs("SuppliersCompanyName") = vCompanyName
End Property

Private Sub Class_GetDataMember(DataMember As String, Data As Object)
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

Dim i As Integer
Dim sLastFieldName As String
Dim sName() As Variant
Dim vValue() As Variant
Dim sNames As Variant
Dim vValues As Variant
Dim oField As Field

On Error GoTo errMSDOG_GDM:

bInitComplete = False

'Choose the RecordSet class based on the DataMember parameter.
Select Case LCase(DataMember)
    Case "products":
        'Skip initialization if RecordSet class already exists.
        If Not mbDataInitialized Then
            de1.rsProducts.DataMember = ""

            If SaveMode = adImmediate Then
                de1.rsProducts.LockType = adLockOptimistic
            Else
                de1.rsProducts.LockType = adLockBatchOptimistic
            End If

            de1.Products
            'Disconnect the RecordSet class to allow (1) stored procedure access
            '  and (2) control over database update timing.
            Set de1.rsProducts.ActiveConnection = Nothing

            'Data object has been initiallized.
            mbDataInitialized = True

            'Execute the Foreign Key command.
            de1.Suppliers
            'If there are no Foreign Keys records, exit with a ClassError event.
            If de1.rsSuppliers.RecordCount < 1 Then
                Err.Clear
                Set Data = Nothing
                RaiseEvent ClassError("GetDataMember-No Suppliers records.", Err)
                Exit Sub
            End If

            'Set the Public property to expose the Foreign Key RecordSet class.
            Set rsSuppliers = de1.rsSuppliers
            'Disconnect the Foreign Key RecordSet class from the DataSource class.
            Set de1.rsSuppliers.ActiveConnection = Nothing

            'Execute the Foreign Key command.
            de1.Categories
            'If there are no Foreign Keys records, exit with a ClassError event.
            If de1.rsCategories.RecordCount < 1 Then
                Err.Clear
                Set Data = Nothing
                RaiseEvent ClassError("GetDataMember-No Categories records.", Err)
                Exit Sub
            End If

            'Set the Public property to expose the Foreign Key RecordSet class.
            Set rsCategories = de1.rsCategories
            'Disconnect the Foreign Key RecordSet class from the DataSource class.
            Set de1.rsCategories.ActiveConnection = Nothing

            'Instantiate the new RecordSet class.
            Set rs = New ADODB.Recordset

            'Set the CursorType property of the RecordSet class.
            rs.CursorType = adOpenStatic
            'Set the LockType property of the RecordSet class.
            If SaveMode = adImmediate Then
                rs.LockType = adLockOptimistic
            Else
                rs.LockType = adLockBatchOptimistic
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
                        i = i + 1
                        ReDim Preserve sName(i)
                        sName(i) = "SuppliersCompanyName"
                        'Add the Foreign Key Descriptor field to the RecordSet class.
                        rs.Fields.Append "SuppliersCompanyName", _
                            de1.rsSuppliers.Fields("CompanyName").Type, _
                            de1.rsSuppliers.Fields("CompanyName").DefinedSize, _
                            de1.rsSuppliers.Fields("CompanyName").Attributes
                    Case "categoryid"
                        i = i + 1
                        ReDim Preserve sName(i)
                        sName(i) = "CategoriesCategoryName"
                        'Add the Foreign Key Descriptor field to the RecordSet class.
                        rs.Fields.Append "CategoriesCategoryName", _
                            de1.rsCategories.Fields("CategoryName").Type, _
                            de1.rsCategories.Fields("CategoryName").DefinedSize, _
                            de1.rsCategories.Fields("CategoryName").Attributes
                End Select

                i = i + 1

                ReDim Preserve sName(i)

                sName(i) = oField.Name

                'Add the Select field to the RecordSet class.
                rs.Fields.Append oField.Name, oField.Type, oField.DefinedSize, oField.Attributes

                'Set the Precision property to the same as in the original RecordSet class.
                rs.Fields(i).Precision = oField.Precision
                'Set the NumericScale property to the same as in the original RecordSet class.
                rs.Fields(i).NumericScale = oField.NumericScale

                sLastFieldName = sName(i)
            Next oField

            'Open the newly created RecordSet class.
            rs.Open

            'Move to the first record in the RecordSet class.
            If de1.rsProducts.RecordCount > 0 Then
                de1.rsProducts.MoveFirst
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
                            i = i + 1
                            ReDim Preserve vValue(i)
                            vValue(i) = Null
                            de1.rsSuppliers.MoveFirst

                            'Loop through the Foreign Key RecordSet class until the Select value is found.
                            Do While Not de1.rsSuppliers.EOF
                            'If the Select Foreign Key values equal the Foreign Key command Primary Key values, update the Foreign Key Descriptor field.
                                If _
                                de1.rsSuppliers("supplierid") = de1.rsProducts("supplierid") Then
                                    'Load the vValue Array element with the Foreign Key Descriptor value.
                                    vValue(i) = de1.rsSuppliers("CompanyName")

                                    Exit Do
                                End If

                                'Move to the next record with a Foreign Key attribute.
                                de1.rsSuppliers.MoveNext
                            Loop

                            'If the value is null, then set the Foreign Key Descriptor Array element value to '(None).
                            If IsNull(vValue(i)) Then
                                vValue(i) = "(None)"
                            End If
                        Case "categoryid"
                            i = i + 1
                            ReDim Preserve vValue(i)
                            vValue(i) = Null
                            de1.rsCategories.MoveFirst

                            'Loop through the Foreign Key RecordSet class until the Select value is found.
                            Do While Not de1.rsCategories.EOF
                            'If the Select Foreign Key values equal the Foreign Key command Primary Key values, update the Foreign Key Descriptor field.
                                If _
                                de1.rsCategories("categoryid") = de1.rsProducts("categoryid") Then
                                    'Load the vValue Array element with the Foreign Key Descriptor value.
                                    vValue(i) = de1.rsCategories("CategoryName")

                                    Exit Do
                                End If

                                'Move to the next record with a Foreign Key attribute.
                                de1.rsCategories.MoveNext
                            Loop

                            'If the value is null, then set the Foreign Key Descriptor Array element value to '(None).
                            If IsNull(vValue(i)) Then
                                vValue(i) = "(None)"
                            End If
                    End Select

                    i = i + 1

                    ReDim Preserve vValue(i)

                    'Set the Array element equal to the value in the Select field.
                    vValue(i) = de1.rsProducts(oField.Name).Value

                    sLastFieldName = oField.Name
                Next oField

                'To add a record to a RecordSet class two arrays of variants are required,
    '(1) an array of field names and (2) an array of corresponding values.
                sNames = sName()
                vValues = vValue()

                'Add the record to the created RecordSet class.
                rs.AddNew sNames, vValues

                'Move to the next record in the Select RecordSet class.
                de1.rsProducts.MoveNext
            Wend

            'Move to the first record in the created RecordSet class.
            If rs.RecordCount > 0 Then
                rs.MoveFirst
            End If
        End If

        'Update all the RecordSet class row status to 'unmodified'.
        rs.UpdateBatch

        'ReDimension the array to hold system generated Primary Key values.
        ReDim vPKValues(2, 0)

        'Set the Data object to return the Select RecordSet class to the calling procedure.
        Set Data = rs

        'Close the Data Environment connection
        de1.Connection1.Close

    Case "suppliers"
        'Set the Data object to return the Foreign Key RecordSet class to the calling procedure.
        Set Data = de1.rsSuppliers
    Case "categories"
        'Set the Data object to return the Foreign Key RecordSet class to the calling procedure.
        Set Data = de1.rsCategories
End Select

bInitComplete = True

Exit Sub
errMSDOG_GDM:
    RaiseEvent ClassError("GetDataMember", Err)
End Sub

Private Sub Class_Initialize()
'=============================================================
'Name: Class_Initialize
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Standard Class object Initialize event.
'
'Comment:
'=============================================================

    'Reset the Initialization variable.
    mbDataInitialized = False
End Sub

Private Sub Class_Terminate()
'=============================================================
'Name: Class_Terminate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Closes Data Environment connections and uninitializes objects
'
'Comment:
'=============================================================

    'Release the Data Environment and RecordSet objects
    Set de1 = Nothing
    Set rs = Nothing
End Sub


Private Sub RS_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, _
        ByVal pError As ADODB.Error, _
        adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
'=============================================================
'Name: RS_MoveComplete
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Standard RecordSet MoveComplete event.
'
'Comment:
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

    RaiseEvent rsMoveComplete

End Sub

Public Sub Move(lRows As Long)
'=============================================================
'Name: Move
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Move the RecordSet n number of Rows.
'
'Comment:
'=============================================================

    On Error GoTo errMove:

    rs.Move lRows

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
'Comment:
'=============================================================

    If (rs.RecordCount > 0) And (Not rs.EOF) Then
        rs.MoveNext
    End If
End Sub

Public Sub MoveFirst()
'=============================================================
'Name: MoveFirst
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Move to first record.
'
'Comment:
'=============================================================

    If rs.RecordCount > 0 Then
        rs.MoveFirst
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
'Comment:
'=============================================================

    If (rs.RecordCount > 0) And (Not rs.BOF) Then
        rs.MovePrevious
    End If
End Sub

Public Sub MoveLast()
'=============================================================
'Name: MoveLast
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Move to last record.
'
'Comment:
'=============================================================

    If rs.RecordCount > 0 Then
        rs.MoveLast
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
'Comment:
'=============================================================

    Dim i As Long

    ValidateData = False

    For i = 0 To rs.Fields.Count - 1
        Select Case LCase(rs.Fields(i).Name)
            Case "productname", "supplierid", "categoryid", "quantityperunit", "unitprice", "unitsinstock", "unitsonorder", "reorderlevel", "discontinued"
                If IsEmpty(rs(i)) And Not rs(i).Type = adBoolean Then
                    MsgBox rs(i).Name & " error."
                    Exit Function
                End If
        End Select
    Next i

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("ProductID")) Then
        If Not IsNumeric(rs("ProductID")) _
            And InStr(rs("ProductID"), ".") = 0 Then
            MsgBox "The field ' ProductID ' does not contain a valid number."
        Exit Function
        End If
    End If

    'Verify the field is not null.
    If IsNull(rs("ProductName")) Then
        MsgBox "The field ' ProductName ' cannot be null."
        Exit Function
    End If

    'Verify the text field contains text.
    If Not IsNull(rs("ProductName")) Then
        If Len(Trim(rs("ProductName"))) = 0 Then
            MsgBox "The field ' ProductName ' does not contain valid text."
            Exit Function
        End If
    End If

    'Verify the field is not null.
    If IsNull(rs("SupplierID")) Then
        MsgBox "The field ' SupplierID ' cannot be null."
        Exit Function
    End If

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("SupplierID")) Then
        If Not IsNumeric(rs("SupplierID")) _
            And InStr(rs("SupplierID"), ".") = 0 Then
            MsgBox "The field ' SupplierID ' does not contain a valid number."
        Exit Function
        End If
    End If

    'Verify the field is not null.
    If IsNull(rs("CategoryID")) Then
        MsgBox "The field ' CategoryID ' cannot be null."
        Exit Function
    End If

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("CategoryID")) Then
        If Not IsNumeric(rs("CategoryID")) _
            And InStr(rs("CategoryID"), ".") = 0 Then
            MsgBox "The field ' CategoryID ' does not contain a valid number."
        Exit Function
        End If
    End If

    'Verify the text field contains text.
    If Not IsNull(rs("QuantityPerUnit")) Then
        If Len(Trim(rs("QuantityPerUnit"))) = 0 Then
            MsgBox "The field ' QuantityPerUnit ' does not contain valid text."
            Exit Function
        End If
    End If

    'Verify the decimal field contains a valid value.
    If Not IsNull(rs("UnitPrice")) Then
        If Not IsNumeric(rs("UnitPrice")) Then
            MsgBox "The field ' UnitPrice ' does not contain a valid numeric value."
            Exit Function
        End If
    End If

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("UnitsInStock")) Then
        If Not IsNumeric(rs("UnitsInStock")) _
            And InStr(rs("UnitsInStock"), ".") = 0 Then
            MsgBox "The field ' UnitsInStock ' does not contain a valid number."
        Exit Function
        End If
    End If

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("UnitsOnOrder")) Then
        If Not IsNumeric(rs("UnitsOnOrder")) _
            And InStr(rs("UnitsOnOrder"), ".") = 0 Then
            MsgBox "The field ' UnitsOnOrder ' does not contain a valid number."
        Exit Function
        End If
    End If

    'Verify the integer field contains a valid value.
    If Not IsNull(rs("ReorderLevel")) Then
        If Not IsNumeric(rs("ReorderLevel")) _
            And InStr(rs("ReorderLevel"), ".") = 0 Then
            MsgBox "The field ' ReorderLevel ' does not contain a valid number."
        Exit Function
        End If
    End If


    ValidateData = True

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
'Comment:
'=============================================================

    Dim oCommand As Command

    On Error GoTo errPutDataInsert

    PutDataInsert = False

    Set oCommand = de1.Commands("Products_Insert")

    'Workaround for Kagera provider
    If LCase(de1.Connection1.Properties("Provider Name")) = "msdasql.dll" Then
        oCommand.Properties.Item("Force SQL Server Firehose Mode cursor").Value = True
    End If

    'Check for valid data.
    If Not ValidateData() Then
        'Raise the ClassError event to detect invalid data.
        RaiseEvent ClassError("Data Validation error.", Err)
        Exit Function
    End If

    'Set the parameter values for the command to be executed.
    oCommand.Parameters("ProductName") = GetPKValue(rs.Bookmark, "ProductName")
    oCommand.Parameters("CategoryID") = GetPKValue(rs.Bookmark, "CategoryID")
    oCommand.Parameters("SupplierID") = GetPKValue(rs.Bookmark, "SupplierID")
    oCommand.Parameters("QuantityPerUnit") = GetPKValue(rs.Bookmark, "QuantityPerUnit")
    oCommand.Parameters("UnitPrice") = GetPKValue(rs.Bookmark, "UnitPrice")
    oCommand.Parameters("UnitsInStock") = GetPKValue(rs.Bookmark, "UnitsInStock")
    oCommand.Parameters("UnitsOnOrder") = GetPKValue(rs.Bookmark, "UnitsOnOrder")
    oCommand.Parameters("ReorderLevel") = GetPKValue(rs.Bookmark, "ReorderLevel")
    oCommand.Parameters("Discontinued") = GetPKValue(rs.Bookmark, "Discontinued")

    'Execute the command.
    oCommand.Execute

    PutDataInsert = True

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
'Comment:
'=============================================================

    Dim oCommand As Command

    On Error GoTo errPutDataUpdate

    PutDataUpdate = False

    Set oCommand = de1.Commands("Products_Update")

    'Workaround for Kagera provider
    If LCase(de1.Connection1.Properties("Provider Name")) = "msdasql.dll" Then
        oCommand.Properties.Item("Force SQL Server Firehose Mode cursor").Value = True
    End If

    'Check for valid data.
    If Not ValidateData() Then
        'Raise the ClassError event to detect invalid data.
        RaiseEvent ClassError("Data Validation error.", Err)
        Exit Function
    End If

    'Set the parameter values for the command to be executed.
    oCommand.Parameters("ProductName") = GetPKValue(rs.Bookmark, "ProductName")
    oCommand.Parameters("CategoryID") = GetPKValue(rs.Bookmark, "CategoryID")
    oCommand.Parameters("SupplierID") = GetPKValue(rs.Bookmark, "SupplierID")
    oCommand.Parameters("QuantityPerUnit") = GetPKValue(rs.Bookmark, "QuantityPerUnit")
    oCommand.Parameters("UnitPrice") = GetPKValue(rs.Bookmark, "UnitPrice")
    oCommand.Parameters("UnitsInStock") = GetPKValue(rs.Bookmark, "UnitsInStock")
    oCommand.Parameters("UnitsOnOrder") = GetPKValue(rs.Bookmark, "UnitsOnOrder")
    oCommand.Parameters("ReorderLevel") = GetPKValue(rs.Bookmark, "ReorderLevel")
    oCommand.Parameters("Discontinued") = GetPKValue(rs.Bookmark, "Discontinued")
    oCommand.Parameters("ProductID") = GetPKValue(rs.Bookmark, "ProductID")

    'Execute the command.
    oCommand.Execute

    PutDataUpdate = True

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
'Comment:
'=============================================================

    Dim oCommand As Command

    On Error GoTo errPutDataDelete

    PutDataDelete = False

    Set oCommand = de1.Commands("Products_Delete")

    'Workaround for Kagera provider
    If LCase(de1.Connection1.Properties("Provider Name")) = "msdasql.dll" Then
        oCommand.Properties.Item("Force SQL Server Firehose Mode cursor").Value = True
    End If

    'Set the parameter values for the command to be executed.
    oCommand.Parameters("ProductID") = GetPKValue(rs.Bookmark, "ProductID")

    'Execute the command.
    oCommand.Execute

    PutDataDelete = True

    Exit Function

errPutDataDelete:
    RaiseEvent ClassError("PutDataDelete", Err)
End Function


Public Sub UpdateBatch()
'=============================================================
'Name: Update Batch
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Saves all modified records.
'
'Comment:
'=============================================================

    On Error GoTo errUpdateBatch:


    rs.UpdateBatch

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
'Comment:
'=============================================================

    On Error GoTo errUpdate:

    rs.UpdateBatch adAffectCurrent

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
        .AddNew
        .Update
    End With

    mbAddingRecord = False

    rs.MoveLast

End Sub

Public Function MoveToPK(ProductID As Variant) As Boolean
'=============================================================
'Name: MoveToPK
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Sets the current RecordSet row with Primary Key values
'
'Comment:
'=============================================================

    MoveToPK = False

    'Move to the first record in the RecordSet class
    rs.MoveFirst

    Do While Not rs.EOF
        If _
            rs("ProductID") = ProductID Then
            MoveToPK = True
            Exit Do
        End If
        rs.MoveNext
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
'Comment:
'=============================================================

    de1.rsCategories.MoveFirst

    rs("CategoriesCategoryName") = "(None)"
    CategoriesCategoryName = "(None)"

    While Not de1.rsCategories.EOF
        If _
            de1.rsCategories("categoryid") = rs("categoryid") Then
                rs("CategoriesCategoryName") = CStr(de1.rsCategories("CategoryName"))
                CategoriesCategoryName = CStr(de1.rsCategories("CategoryName"))
        End If

        de1.rsCategories.MoveNext
    Wend
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
'Comment:
'=============================================================

    de1.rsSuppliers.MoveFirst

    rs("SuppliersCompanyName") = "(None)"
    SuppliersCompanyName = "(None)"

    While Not de1.rsSuppliers.EOF
        If _
            de1.rsSuppliers("supplierid") = rs("supplierid") Then
                rs("SuppliersCompanyName") = CStr(de1.rsSuppliers("CompanyName"))
                SuppliersCompanyName = CStr(de1.rsSuppliers("CompanyName"))
        End If

        de1.rsSuppliers.MoveNext
    Wend
End Sub

Public Sub rsUpdate(vFieldName As Variant)
'=============================================================
'Name: rsUpdate
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Updates Foreign Key Descriptors and raises rsUpdate event
'
'Comment:
'=============================================================

    UpdateCategoriesCategoryName
    UpdateSuppliersCompanyName

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
'Comment:
'=============================================================

    On Error GoTo errDelete

    mbDeleteInProgress = True

    'Update the current record status to 'unmodified'.
    rs.Delete adAffectCurrent

    On Error GoTo 0

    Me.MovePrevious

    mbDeleteInProgress = False

    Exit Sub

errDelete:
    RaiseEvent ClassError("Delete", Err)
End Sub


Private Sub rs_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
'=============================================================
'Name: rs_WillChangeRecord
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Runs stored procedures to save record.
'
'Comment:
'=============================================================

On Error GoTo errWillChangeRecord
    If bInitComplete And (adReason <> adRsnFirstChange) And (adReason <> adRsnUndoAddNew) And Not mbAddingRecord Then
        If IsEmpty(rs(0).OriginalValue) Then
            If Not PutDataInsert Then
                adStatus = adStatusCancel
            End If
        Else
            Select Case adReason
                Case adRsnUpdate
                    If Not mbDeleteInProgress Then
                        If Not PutDataUpdate Then
                            adStatus = adStatusCancel
                        End If
                    End If
                Case adRsnAddNew
                    If Not PutDataInsert Then
                        adStatus = adStatusCancel
                    End If
                Case adRsnDelete
                    If Not PutDataDelete Then
                        adStatus = adStatusCancel
                    End If
                    mbDeleteInProgress = True
            End Select
        End If
    End If

    Exit Sub

errWillChangeRecord:

End Sub


Private Function GetPKValue(vBookMark As Variant, sColName As String) As Variant
'=============================================================
'Name: GetPKValue
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/05/1999 20:25
'
'Description: Looks up newly inserted system gen'd PK values.
'
'Comment:
'=============================================================

    Dim i As Integer

    GetPKValue = rs(sColName)

    For i = 1 To UBound(vPKValues, 2)
        If vPKValues(0, i) = vBookMark And LCase(vPKValues(1, i)) = LCase(sColName) Then
            GetPKValue = vPKValues(2, i)
            Exit Function
        End If
    Next i
End Function



