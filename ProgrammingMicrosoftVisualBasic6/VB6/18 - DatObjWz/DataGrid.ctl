VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.UserControl uctProductsDataGrid 
   ClientHeight    =   3600
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4800
   ScaleHeight     =   3600
   ScaleWidth      =   4800
   Begin VB.ComboBox cmbEdit 
      Appearance      =   0  'Flat
      Height          =   315
      Left            =   480
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   1320
      Visible         =   0   'False
      Width           =   1000
   End
   Begin MSDataGridLib.DataGrid grdProducts2 
      Height          =   3400
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4600
      _ExtentX        =   8123
      _ExtentY        =   6006
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "uctProductsDataGrid"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Attribute VB_Ext_KEY = "WizardYN" ,"Yes"
Attribute VB_Ext_KEY = "VBProjectName" ,"Project1"
Attribute VB_Ext_KEY = "DEDesignerName" ,"DataEnvironment1"
Attribute VB_Ext_KEY = "ConnectionName" ,"Connection1"
Attribute VB_Ext_KEY = "CommandName" ,"Products_Fetch"
Attribute VB_Ext_KEY = "ClassType" ,"User Control"
Attribute VB_Ext_KEY = "DataClassName" ,"rsclsProducts2"
Attribute VB_Ext_KEY = "RootName" ,"uctProducts2DataGrid"
Attribute VB_Ext_KEY = "UserControlType" ,"DataGrid"
Option Explicit

'=============================================================
'Name: uctProducts2DataGrid (The DataGrid UserControl object)
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: DataGrid UserControl object using a Data Object Wizard RecordSet class as a DataSource class.
'
'Comment:
'=============================================================

'The current datagrid control column
Private mlCurrentCol As Long

'Prohibits several operations the first time the datagrid control loads.
Private mbFirstTime As Boolean
'Prohibits showing the listbox control as the datagrid control loads for the first time.
Private mbShowCombo As Boolean
'Allows the datagrid control to be editable and displays the listbox control on columns with the Foreign Key attributes.
Public GridEditable As Boolean
'True if an error occurred in the DataSource class.
Private mbClassError As Boolean

'Create the datagrid control column constants
Private Const PRODUCTID_COLUMN As Long = 0
Private Const PRODUCTNAME_COLUMN As Long = 1
Private Const SUPPLIERID_COLUMN As Long = 2
Private Const SUPPLIERSCOMPANYNAME_COLUMN As Long = 3
Private Const CATEGORYID_COLUMN As Long = 4
Private Const CATEGORIESCATEGORYNAME_COLUMN As Long = 5
Private Const QUANTITYPERUNIT_COLUMN As Long = 6
Private Const UNITPRICE_COLUMN As Long = 7
Private Const UNITSINSTOCK_COLUMN As Long = 8
Private Const UNITSONORDER_COLUMN As Long = 9
Private Const REORDERLEVEL_COLUMN As Long = 10
Private Const DISCONTINUED_COLUMN As Long = 11

'Create parameter properties for the Select RecordSet class
Public Products_FetchProductName As Variant

'Create the Foreign Key Parameter properties for the RecordSet classes

'Use the Data Object Wizard RecordSet class as a DataSource class
Private WithEvents oProducts2 As rsclsProducts2
Attribute oProducts2.VB_VarHelpID = -1

'Set the ManualInitialize property to false to automatically initialize or true to manually inititalize the UserControl object
Public ManualInitialize As Boolean

'The RecordSet Move event
Public Event MoveComplete(oDataSource As Object)

'Format the object for the datagrid control Boolean columns
Private oStdDataFormat As StdDataFormat

'Save the adImmediate property when the user moves off the row.
Public SaveMode As EnumSaveMode

Public Function InitProducts2(Optional oProducts20 As Variant) As Object
'=============================================================
'Name: InitProducts2
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Initializes the datagrid control.
'
'Comment:
'=============================================================

    'Set flags to true on load.
    mbFirstTime = True
    mbShowCombo = True

    'Create Format object for the datagrid control Boolean columns
    Set oStdDataFormat = New StdDataFormat
    oStdDataFormat.Type = fmtBoolean
    oStdDataFormat.FalseValue = "False"
    oStdDataFormat.TrueValue = "True"

    On Error GoTo InitProducts2Err

    'Reset the DataSource class.
    Set oProducts2 = Nothing

    'Use the Data Object Wizard RecordSet class as the DataSource class for the datagrid control
    If IsMissing(oProducts20) Then
        'If the DataSource class was not passed as a parameter, create the DataSource class.
        Set oProducts2 = New rsclsProducts2
    Else
        'Use the DataSource class passed as a parameter.
        Set oProducts2 = oProducts20
    End If

    'Set the RecordSet class Select parameter properties to the UserControl object values
    oProducts2.Products_FetchProductName = Me.Products_FetchProductName

    'Set the RecordSet class Foreign Key parameter properties to the UserControl object values

    'Save the adImmediate property when the user moves off the row.
    oProducts2.SaveMode = Me.SaveMode

    'Set the source of data for the datagrid control
    mbClassError = False
    grdProducts2.DataMember = "PRODUCTS_FETCH"
    Set grdProducts2.DataSource = oProducts2

    'If there is an error, exit the function.
    If mbClassError Then
        MsgBox "Cannot initialize grid control."
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
    grdProducts2.ScrollBars = dbgBoth
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
    Set grdProducts2.Columns(DISCONTINUED_COLUMN).DataFormat = ToStdDataFormat6(oStdDataFormat)

    'Save the current column of the datagrid control
    mlCurrentCol = grdProducts2.col

    'Set the Flag to false
    mbFirstTime = False

    'Return the Class object.
    Set InitProducts2 = oProducts2

    'Resize the datagrid control to the UserControl object when we are in the Visual Basic Run Time mode.
    grdProducts2.Top = UserControl.ScaleTop
    grdProducts2.Left = UserControl.ScaleLeft
    grdProducts2.Height = UserControl.ScaleHeight
    grdProducts2.Width = UserControl.ScaleWidth

    Exit Function

InitProducts2Err:
End Function

Private Sub FillCombo(Ctrl As ComboBox, oRS As Recordset, nDescrField As String, bShowNone As Boolean)
'=============================================================
'Name: FillCombo
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Fills the Foreign Key as hidden in the combobox control
'
'Comment:
'=============================================================

    'Clear the floating combobox control
    Ctrl.Clear

    'If Foreign Key Identifier field is nullable then put '(None)' as the first record in listbox control
    If bShowNone Then
        Ctrl.AddItem "(None)"
        Ctrl.ItemData(Ctrl.NewIndex) = -1
    End If

    'Move to the first record of the RecordSet class
    oRS.MoveFirst

    'Load the combobox control from the RecordSet class
    While Not oRS.EOF
        Ctrl.AddItem oRS(nDescrField)
        Ctrl.ItemData(Ctrl.NewIndex) = oRS.AbsolutePosition
        oRS.MoveNext
    Wend

    On Error Resume Next
        Select Case grdProducts2.col
            'Set the listbox control to the Foreign Key value.
            Case CATEGORIESCATEGORYNAME_COLUMN:
                Ctrl.ListIndex = GetSurKeyCategories(oProducts2.categoryid) - 1
            'Set the listbox control to the Foreign Key value.
            Case SUPPLIERSCOMPANYNAME_COLUMN:
                Ctrl.ListIndex = GetSurKeySuppliers(oProducts2.supplierid) - 1
        End Select
    On Error GoTo 0
End Sub

Private Sub ShowFloatingControl(Ctrl As ComboBox, nColNumber As Integer, nRow As Integer)
'=============================================================
'Name: ShowFloatingControl
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Locates and unhides the Foreign Key listbox control.
'
'Comment:
'=============================================================

    Dim oCol As Column

    'Set the listbox control to the clicked datagrid control column
    Set oCol = grdProducts2.Columns(nColNumber)

    'Move and show the listbox control
    With Ctrl
        .Left = grdProducts2.Left + oCol.Left
        .Top = grdProducts2.Top + grdProducts2.RowTop(grdProducts2.Row)
        .Width = oCol.Width + Screen.TwipsPerPixelX
        If nRow = -1 Then
            .ListIndex = 0
        Else
            .ListIndex = nRow
        End If

        .ZOrder 0

        'If the listbox control is outside of the datagrid control, don't show the datagrid control.
        If oCol.Left + oCol.Width <= grdProducts2.Left + grdProducts2.Width Then
            .Visible = True
            .SetFocus
        Else
            grdProducts2.col = 0
        End If

    End With

End Sub

Private Sub grdProducts2_RowColChange(LastRow As Variant, ByVal LastCol As Integer)
'=============================================================
'Name: grdProducts2DataGrid_ButtonClick
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard DataGrid control ButtonClick event code.
'
'Comment:
'=============================================================

    cmbEdit.Visible = False

    'Exit the procudure if the GridEditable property is set to false
    If mbFirstTime Or (Not mbShowCombo) Or (Not GridEditable) Then
        Exit Sub
    End If

    'Save the datagrid controls current cell position
    mlCurrentCol = grdProducts2.col

    'Show the floating listbox control based on the datagrid controls column property
    Select Case mlCurrentCol
        'Fill the listbox control, set the control to the value of the Foreign Key and show it.
        Case CATEGORIESCATEGORYNAME_COLUMN:
            FillCombo cmbEdit, oProducts2.rsCategories, "CategoryName", False
            If grdProducts2.Row = -1 Then
                SendKeys cmbEdit.List(0)
            Else
                ShowFloatingControl cmbEdit, CATEGORIESCATEGORYNAME_COLUMN, GetSurKeyCategories(grdProducts2.Columns(CATEGORYID_COLUMN).Text) - 1
            End If
        'Fill the listbox control, set the control to the value of the Foreign Key and show it.
        Case SUPPLIERSCOMPANYNAME_COLUMN:
            FillCombo cmbEdit, oProducts2.rsSuppliers, "CompanyName", False
            If grdProducts2.Row = -1 Then
                SendKeys cmbEdit.List(0)
            Else
                ShowFloatingControl cmbEdit, SUPPLIERSCOMPANYNAME_COLUMN, GetSurKeySuppliers(grdProducts2.Columns(SUPPLIERID_COLUMN).Text) - 1
            End If
        Case Else
            cmbEdit.Visible = False
    End Select
End Sub

Private Sub grdProducts2_Scroll(Cancel As Integer)
'=============================================================
'Name: grdProducts2_Scroll
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard DataGrid control Scroll event.
'
'Comment:
'=============================================================

    'Hide the listbox control
    cmbEdit.Visible = False

End Sub

Private Function GetSurKeyCategories(categoryid) As Integer
'=============================================================
'Name: GetSurKeyCategories
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
'
'Comment:
'=============================================================

    oProducts2.rsCategories.MoveFirst

    ' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
    While Not oProducts2.rsCategories.EOF
        If oProducts2.rsCategories("categoryid").value = Val(categoryid) Then
            'Return the Surrogate Key value.
            GetSurKeyCategories = oProducts2.rsCategories.AbsolutePosition
            Exit Function
        End If

        oProducts2.rsCategories.MoveNext
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
'Date: 01/06/1999 02:03
'
'Description: Moves the RecordSet class to the AbsolutePosition value of the Foreign Key parameters.
'
'Comment:
'=============================================================

    oProducts2.rsSuppliers.MoveFirst

    ' Loop through each record in the Foreign Key RecordSet class until we find the actual Foreign Key values
    While Not oProducts2.rsSuppliers.EOF
        If oProducts2.rsSuppliers("supplierid").value = Val(supplierid) Then
            'Return the Surrogate Key value.
            GetSurKeySuppliers = oProducts2.rsSuppliers.AbsolutePosition
            Exit Function
        End If

        oProducts2.rsSuppliers.MoveNext
    Wend

    'If the Surrogate Key (AbsolutePosition) value is not found, set the function to the first Recordset item
    GetSurKeySuppliers = 1

End Function

Private Function UpdateFKCategories(nSurrogateKey As Integer)
'=============================================================
'Name: UpdateFKCategories
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
'
'Comment:
'=============================================================

    If nSurrogateKey = -1 Then
        'Set the actual Foreign Key value to null
        oProducts2.categoryid = Null
    Else
        oProducts2.rsCategories.MoveFirst

        'Move the Foreign Key RecordSet class to the Surrogate Key value(the AbsolutePosition property.)
        While Not oProducts2.rsCategories.EOF
            If oProducts2.rsCategories.AbsolutePosition = Val(nSurrogateKey) Then
                'Set the DataSource class property to the value of the Foreign Key RecordSet class field.
                oProducts2.categoryid = oProducts2.rsCategories("categoryid")
                Exit Function
            End If
            oProducts2.rsCategories.MoveNext
        Wend
    End If

End Function

Private Function UpdateFKSuppliers(nSurrogateKey As Integer)
'=============================================================
'Name: UpdateFKSuppliers
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Sets the Foreign Key properties based on the Surrogate Key value in the class.
'
'Comment:
'=============================================================

    If nSurrogateKey = -1 Then
        'Set the actual Foreign Key value to null
        oProducts2.supplierid = Null
    Else
        oProducts2.rsSuppliers.MoveFirst

        'Move the Foreign Key RecordSet class to the Surrogate Key value(the AbsolutePosition property.)
        While Not oProducts2.rsSuppliers.EOF
            If oProducts2.rsSuppliers.AbsolutePosition = Val(nSurrogateKey) Then
                'Set the DataSource class property to the value of the Foreign Key RecordSet class field.
                oProducts2.supplierid = oProducts2.rsSuppliers("supplierid")
                Exit Function
            End If
            oProducts2.rsSuppliers.MoveNext
        Wend
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
'Comment:
'=============================================================

    cmbEdit.Visible = False

    mbShowCombo = False

    oProducts2.UpdateBatch

    mbShowCombo = True

End Sub
Public Sub Update()
'=============================================================
'Name: Update
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: This subroutine runs the Class object Update method.
'
'Comment:
'=============================================================

    cmbEdit.Visible = False

    oProducts2.Update

End Sub
Private Sub cmbEdit_Click()
'=============================================================
'Name: cmbEdit_Click
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard lstEdit control click event.
'
'Comment:
'=============================================================

    If cmbEdit.Visible Then
        Select Case mlCurrentCol
            Case CATEGORIESCATEGORYNAME_COLUMN:
                'Run the UpdateFK method to update the DataSource class Foreign Key Property value(s).
                UpdateFKCategories cmbEdit.ItemData(cmbEdit.ListIndex)
            Case SUPPLIERSCOMPANYNAME_COLUMN:
                'Run the UpdateFK method to update the DataSource class Foreign Key Property value(s).
                UpdateFKSuppliers cmbEdit.ItemData(cmbEdit.ListIndex)
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

Private Sub oProducts2_ClassError(sProcedureName As String, oErr As ErrObject)
'=============================================================
'Name: oProducts2
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
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
'Date: 01/06/1999 02:03
'
'Description: Standard UserControl object ReadProperties Event.
'
'Comment:
'=============================================================

    Dim bErrorFlag As Boolean
    Dim sParamName As String

    bErrorFlag = False

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
        SaveMode = CLng(PropBag.ReadProperty("SaveMode"))

        'If parameter values were read then initialize the DataSource class.
        If Not bErrorFlag And Ambient.UserMode Then
            InitProducts2
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
'Date: 01/06/1999 02:03
'
'Description: Standard UserControl object WriteProperties event.
'
'Comment:
'=============================================================

    On Error Resume Next

    'Set the ManualInitialize property to false to initialize the datagrid control automatically.
    PropBag.WriteProperty "ManualInitialize", ManualInitialize

    'Set the GridEditable property to true to allow editing the datagrid control and activate the Foreign Key listbox controls.
    PropBag.WriteProperty "GridEditable", GridEditable

    If Not ManualInitialize Then
        'Write the Select command parameter value.
        PropBag.WriteProperty "Products_FetchProductName", Products_FetchProductName

        'Write the SaveMove property value.
        PropBag.WriteProperty "SaveMode", SaveMode

    End If

    On Error GoTo 0

End Sub
Private Sub UserControl_Resize()
'=============================================================
'Name: UserControl_Resize
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard UserControl object Resize event.
'
'Comment:
'=============================================================

    'Resize the datagrid control to the UserControl object when we are in Visual Basic Design Time mode.
    grdProducts2.Top = UserControl.ScaleTop
    grdProducts2.Left = UserControl.ScaleLeft
    grdProducts2.Height = UserControl.ScaleHeight
    grdProducts2.Width = UserControl.ScaleWidth

End Sub

Public Sub oProducts2_rsMoveComplete()
'=============================================================
'Name: MoveComplete
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: UserControl object MoveComplete event.
'
'Comment:
'=============================================================

    RaiseEvent MoveComplete(oProducts2)
End Sub

Private Sub grdProducts2_ColResize(ByVal ColIndex As Integer, Cancel As Integer)
'=============================================================
'Name: grdProducts2_ColResize
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard DataGrid control ColResize event.
'
'Comment:
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

Private Sub grdProducts2_KeyPress(KeyAscii As Integer)
'=============================================================
'Name: grdProducts2_KeyPress
'
'Author: Microsoft Data Object Wizard
'
'Date: 01/06/1999 02:03
'
'Description: Standard DataGrid control KeyPress event.
'
'Comment:
'=============================================================

    Select Case grdProducts2.col
        Case Is = CATEGORIESCATEGORYNAME_COLUMN, SUPPLIERSCOMPANYNAME_COLUMN
            KeyAscii = 0
        Case Is = 1, 10
        
        
    End Select
End Sub



