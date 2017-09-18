VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form Form1 
   Caption         =   "DataGrid control demo"
   ClientHeight    =   3870
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6600
   LinkTopic       =   "Form1"
   ScaleHeight     =   3870
   ScaleWidth      =   6600
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSplit 
      Caption         =   "Split"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   4
      Top             =   0
      Width           =   855
   End
   Begin VB.ComboBox cboCategories 
      Height          =   315
      Left            =   2280
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   3120
      Width           =   1215
   End
   Begin VB.ComboBox cboSuppliers 
      Height          =   315
      Left            =   240
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   3120
      Width           =   1935
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Bindings        =   "Form1.frx":0000
      Height          =   2775
      Left            =   0
      TabIndex        =   0
      Top             =   360
      Width           =   6015
      _ExtentX        =   10610
      _ExtentY        =   4895
      _Version        =   393216
      AllowUpdate     =   -1  'True
      AllowArrows     =   -1  'True
      ColumnHeaders   =   -1  'True
      HeadLines       =   1
      RowHeight       =   13
      TabAction       =   2
      WrapCellPointer =   -1  'True
      FormatLocked    =   -1  'True
      AllowAddNew     =   -1  'True
      AllowDelete     =   -1  'True
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
      ColumnCount     =   10
      BeginProperty Column00 
         DataField       =   "ProductID"
         Caption         =   "ProductID"
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
         DataField       =   "ProductName"
         Caption         =   "ProductName"
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
      BeginProperty Column02 
         DataField       =   "SupplierID"
         Caption         =   "Supplier"
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
      BeginProperty Column03 
         DataField       =   "CategoryID"
         Caption         =   "Category"
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
      BeginProperty Column04 
         DataField       =   "QuantityPerUnit"
         Caption         =   "QuantityPerUnit"
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
      BeginProperty Column05 
         DataField       =   "UnitPrice"
         Caption         =   "UnitPrice"
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
      BeginProperty Column06 
         DataField       =   "UnitsInStock"
         Caption         =   "UnitsInStock"
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
      BeginProperty Column07 
         DataField       =   "UnitsOnOrder"
         Caption         =   "UnitsOnOrder"
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
      BeginProperty Column08 
         DataField       =   "ReorderLevel"
         Caption         =   "ReorderLevel"
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
      BeginProperty Column09 
         DataField       =   "Discontinued"
         Caption         =   "Discontinued"
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
         AllowRowSizing  =   0   'False
         AllowSizing     =   0   'False
         Size            =   91
         BeginProperty Column00 
            ColumnWidth     =   915.024
         EndProperty
         BeginProperty Column01 
            ColumnWidth     =   1739.906
         EndProperty
         BeginProperty Column02 
            ColumnWidth     =   915.024
         EndProperty
         BeginProperty Column03 
            ColumnWidth     =   915.024
         EndProperty
         BeginProperty Column04 
            ColumnWidth     =   1739.906
         EndProperty
         BeginProperty Column05 
            ColumnWidth     =   1739.906
         EndProperty
         BeginProperty Column06 
            ColumnWidth     =   929.764
         EndProperty
         BeginProperty Column07 
            ColumnWidth     =   975.118
         EndProperty
         BeginProperty Column08 
            ColumnWidth     =   975.118
         EndProperty
         BeginProperty Column09 
            ColumnWidth     =   945.071
         EndProperty
      EndProperty
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   4200
      Top             =   3120
      Visible         =   0   'False
      Width           =   2175
      _ExtentX        =   3836
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Products"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Select one or more rows to see here summary data"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   840
      TabIndex        =   3
      Top             =   0
      Width           =   4215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False

' IMPORTANT: ensure that the following constant points
' to the NWind database
Const DB_PATH = "c:\program files\Microsoft Visual Studio\vb98\nwind.mdb"

' These object serve to format lookup fields on the fly.
Dim WithEvents SupplierFormat As StdDataFormat
Attribute SupplierFormat.VB_VarHelpID = -1
Dim WithEvents CategoryFormat As StdDataFormat
Attribute CategoryFormat.VB_VarHelpID = -1

' This variable serves to workaround the BeforeColUpdate bug.
Dim newValue As Variant

Private Sub Form_Load()
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
    Adodc1.Refresh
    
    ' prepare the grid to host the combobox controls.
    DataGrid1.RowHeight = cboSuppliers.Height
    
    ' load the two combobox controls with the lookup data.
    Dim rs As New ADODB.Recordset
    ' The Suppliers table.
    rs.Open "Suppliers", Adodc1.Recordset.ActiveConnection, adOpenStatic, adLockReadOnly, adCmdTable
    Do Until rs.EOF
        cboSuppliers.AddItem rs("CompanyName")
        cboSuppliers.ItemData(cboSuppliers.NewIndex) = rs("SupplierID")
        rs.MoveNext
    Loop
    rs.Close
    ' The Categories table.
    rs.Open "Categories", Adodc1.Recordset.ActiveConnection, adOpenStatic, adLockReadOnly, adCmdTable
    Do Until rs.EOF
        cboCategories.AddItem rs("CategoryName")
        cboCategories.ItemData(cboCategories.NewIndex) = rs("CategoryID")
        rs.MoveNext
    Loop
    rs.Close
    
    ' Prepare two StdDataFormat objects
    Set SupplierFormat = New StdDataFormat
    Set DataGrid1.Columns("Supplier").DataFormat = ToStdDataFormat6(SupplierFormat)
    
    Set CategoryFormat = New StdDataFormat
    Set DataGrid1.Columns("Category").DataFormat = ToStdDataFormat6(CategoryFormat)
    
    ' Put the grid in front of the two combobox controls.
    DataGrid1.ZOrder
    
End Sub

Private Sub Form_Resize()
    lblStatus.Width = ScaleWidth - lblStatus.Left
    DataGrid1.Move 0, DataGrid1.Top, ScaleWidth, ScaleHeight - DataGrid1.Top
End Sub

Private Sub SupplierFormat_Format(ByVal DataValue As StdFormat.StdDataValue)
    ' Convert a SupplierID into a Supplier name.
    Dim i As Long
    For i = 0 To cboSuppliers.ListCount - 1
        If cboSuppliers.ItemData(i) = DataValue Then
            DataValue = cboSuppliers.List(i)
            Exit For
        End If
    Next
End Sub

Private Sub CategoryFormat_Format(ByVal DataValue As StdFormat.StdDataValue)
    ' Convert a CategoryID into a category name.
    Dim i As Long
    For i = 0 To cboCategories.ListCount - 1
        If cboCategories.ItemData(i) = DataValue Then
            DataValue = cboCategories.List(i)
            Exit For
        End If
    Next
End Sub

Private Sub cboSuppliers_Click()
    ' Change the value of the underlying grid cell.
    DataGrid1.Columns("Supplier").value = cboSuppliers.ItemData(cboSuppliers.ListIndex)
End Sub

Private Sub cboCategories_Click()
    ' Change the value of the underlying grid cell.
    DataGrid1.Columns("Category").value = cboCategories.ItemData(cboCategories.ListIndex)
End Sub

Private Sub MoveCombos()
    ' In case of error put the combobox outof sight.
    On Error GoTo Error_Handler
    
    ' Start by hiding both comboboxes
    If DataGrid1.Visible Then
        DataGrid1.ZOrder
        DataGrid1.SetFocus
    End If
    
    ' Get a reference to the current column.
    Dim gridCol As MSDataGridLib.Column
    Set gridCol = DataGrid1.Columns(DataGrid1.col)
    
    If Not DataGrid1.CurrentCellVisible Then
        ' do nothing if current cell isn't visible
    ElseIf gridCol.Caption = "Supplier" Then
        ' Move the combobox inside the SupplierID column
        cboSuppliers.Move DataGrid1.Left + gridCol.Left, DataGrid1.Top + DataGrid1.RowTop(DataGrid1.row), gridCol.Width
        cboSuppliers.ZOrder
        cboSuppliers.SetFocus
        cboSuppliers.Text = gridCol.Text
        Exit Sub
    ElseIf gridCol.Caption = "Category" Then
        ' Move the combobox inside the SupplierID column
        cboCategories.Move DataGrid1.Left + gridCol.Left, DataGrid1.Top + DataGrid1.RowTop(DataGrid1.row), gridCol.Width
        cboCategories.ZOrder
        cboCategories.SetFocus
        cboCategories.Text = gridCol.Text
        Exit Sub
    End If
Error_Handler:

End Sub

Private Sub DataGrid1_RowColChange(LastRow As Variant, ByVal LastCol As Integer)
    MoveCombos
End Sub

Private Sub DataGrid1_RowResize(Cancel As Integer)
    MoveCombos
End Sub

Private Sub DataGrid1_ColResize(ByVal ColIndex As Integer, Cancel As Integer)
    MoveCombos
End Sub

Private Sub DataGrid1_Scroll(Cancel As Integer)
    MoveCombos
End Sub

Private Sub DataGrid1_SplitChange()
    MoveCombos
End Sub

Private Sub DataGrid1_BeforeColUpdate(ByVal ColIndex As Integer, OldValue As Variant, Cancel As Integer)
    ' ensure that no duplicate product name is entered
    If DataGrid1.Columns(DataGrid1.col).DataField = "ProductName" Then
        Dim rs As ADODB.Recordset
        ' Get a clone recordset
        Set rs = Adodc1.Recordset.Clone(adLockReadOnly)
        rs.MoveFirst
        ' see if this value is already in the recordset.
        ' (NewValue is set in Change event)
        rs.Find "ProductName='" & newValue & "'"
        If Not rs.EOF Then
            MsgBox "This product is already in the list", vbCritical
            Cancel = True
        End If
    End If
        
End Sub

Private Sub DataGrid1_Change()
    ' remember the last value edited (will be used in BeforeColUpdate)
    newValue = DataGrid1.Text
End Sub

Private Sub cmdSplit_Click()
    ' create two splits, one with only the Product Name column
    ' and one with all the others
    Dim i As Integer, gridCol As MSDataGridLib.Column
    
    ' Create a new split to the left of the existing split
    With DataGrid1.Splits.Add(0)
        ' make its width the same as the ProductName column
        .SizeMode = dbgExact
        .Size = .Columns("ProductName").Width
        ' make all columns invisible but ProductName.
        For Each gridCol In .Columns
            gridCol.Visible = (gridCol.Caption = "ProductName")
        Next
        ' Hide the vertical scrollbar
        .ScrollBars = dbgHorizontal
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

Private Sub DataGrid1_BeforeDelete(Cancel As Integer)
    ' Refuse to delete a product if there is one OrderDetail record
    ' that points to it
    Dim rs As ADODB.Recordset, rsorderdetail As ADODB.Recordset, sql As String
    ' Retrieve all the records in OrderDetails that reference this product.
    Set rs = Adodc1.Recordset
    sql = "Select * FROM [Order Details] WHERE [Order Details].ProductID = " & rs("ProductID")
    Set rsorderdetail = rs.ActiveConnection.Execute(sql)
    ' if this recordset contains any record, refuse to delete.
    If Not rsorderdetail.EOF Then Cancel = True
End Sub

Private Sub DataGrid1_Error(ByVal DataError As Integer, Response As Integer)
    ' Display a custom error message
    MsgBox "Error code: " & DataError & vbCr & vbCr & DataGrid1.ErrorText, vbCritical
    Response = 0
End Sub

Private Sub DataGrid1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' Display a tooltip with the contents of the current cell
    Dim row As Long, col As Long, value As Variant
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

Private Sub DataGrid1_SelChange(Cancel As Integer)
    Dim rs As ADODB.Recordset, bmark As Variant
    Dim count As Long, unitsInStock As Long, unitsOnOrder As Long
    
    Set rs = Adodc1.Recordset.Clone(adLockReadOnly)
    count = DataGrid1.SelBookmarks.count
    
    If count = 0 Then
        lblStatus = "No records selected"
    Else
        For Each bmark In DataGrid1.SelBookmarks
            rs.Bookmark = bmark
            unitsInStock = unitsInStock + rs("unitsInStock")
            unitsOnOrder = unitsOnOrder + rs("unitsOnOrder")
        Next
        lblStatus = count & " product(s) selected     UnitsInStock =" & unitsInStock & "       UnitsOnOrder =" & unitsOnOrder
    End If
End Sub

Private Sub DataGrid1_HeadClick(ByVal ColIndex As Integer)
    ' You can't sort on lookup fields.
    Select Case DataGrid1.Columns(ColIndex).Caption
        Case "Supplier", "Category"
            MsgBox "Sorry, can't sort on this field", vbExclamation
            Exit Sub
    End Select

    ' Sort on the clicked column
    Dim rs As ADODB.Recordset
    Set rs = Adodc1.Recordset
    
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




