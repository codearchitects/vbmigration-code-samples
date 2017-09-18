VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form Form1 
   Caption         =   "DataCombo Demo"
   ClientHeight    =   4875
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7890
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4875
   ScaleWidth      =   7890
   StartUpPosition =   3  'Windows Default
   Begin MSDataListLib.DataList DataList1 
      DataField       =   "CategoryID"
      DataSource      =   "Adodc1"
      Height          =   780
      Left            =   2400
      TabIndex        =   14
      Top             =   600
      Width           =   3735
      _ExtentX        =   6588
      _ExtentY        =   1376
      _Version        =   393216
      ListField       =   "CategoryName"
      BoundColumn     =   "CategoryID"
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   1680
      TabIndex        =   10
      Top             =   4080
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddNew 
      Caption         =   "&AddNew"
      Height          =   375
      Left            =   240
      TabIndex        =   9
      Top             =   4080
      Width           =   1215
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Discontinued"
      DataField       =   "Discontinued"
      DataSource      =   "Adodc1"
      Height          =   255
      Left            =   4320
      TabIndex        =   8
      Top             =   2640
      Width           =   1575
   End
   Begin VB.TextBox txtUnitsOnOrder 
      DataField       =   "UnitsOnOrder"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   3
      Top             =   3480
      Width           =   1455
   End
   Begin VB.TextBox txtUnitsInStock 
      DataField       =   "UnitsInStock"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   3000
      Width           =   1455
   End
   Begin VB.TextBox txtUnitPrice 
      DataField       =   "UnitPrice"
      BeginProperty DataFormat 
         Type            =   0
         Format          =   "000;(000);zero;null"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   1
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtProductName 
      DataField       =   "ProductName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   0
      Top             =   120
      Width           =   3735
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      Top             =   4500
      Width           =   7890
      _ExtentX        =   13917
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
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
   Begin MSDataListLib.DataCombo DataCombo1 
      DataField       =   "SupplierID"
      DataSource      =   "Adodc1"
      Height          =   360
      Left            =   2400
      TabIndex        =   13
      Top             =   1560
      Width           =   3735
      _ExtentX        =   6588
      _ExtentY        =   635
      _Version        =   393216
      MatchEntry      =   -1  'True
      ListField       =   "CompanyName"
      BoundColumn     =   "SupplierID"
      Text            =   ""
   End
   Begin VB.Label Label7 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Contact Name"
      Height          =   375
      Left            =   240
      TabIndex        =   16
      Top             =   1920
      Width           =   2175
   End
   Begin VB.Label lblSupplierData 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   2400
      TabIndex        =   15
      Top             =   1920
      Width           =   3735
   End
   Begin VB.Label Label6 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Supplier Name"
      Height          =   375
      Left            =   240
      TabIndex        =   12
      Top             =   1560
      Width           =   2175
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Category Name"
      Height          =   375
      Left            =   240
      TabIndex        =   11
      Top             =   600
      Width           =   2175
   End
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Units on Order"
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Top             =   3480
      Width           =   2175
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Units in Stock"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   3000
      Width           =   2175
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Unit Price"
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "000;0;zero;null"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   0
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   2520
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Product Name"
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   120
      Width           =   2175
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False

' IMPORTANT: ensure that the DB_PATH constant is pointing to the
' NWind.mdb database on your system
Const DB_PATH = "C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"

Dim rsCategories As New ADODB.Recordset
Dim rsSuppliers As New ADODB.Recordset

Dim ValidationError As Boolean


Private Sub Form_Load()
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
    Adodc1.Refresh
    
    rsCategories.Open "Categories", Adodc1.Recordset.ActiveConnection, adOpenDynamic, adLockOptimistic
    Set DataList1.RowSource = rsCategories
    rsSuppliers.Open "Suppliers", Adodc1.Recordset.ActiveConnection, adOpenDynamic, adLockOptimistic
    Set DataCombo1.RowSource = rsSuppliers
    ShowSupplierInfo
    
    ' Start a transaction
    Adodc1.Recordset.ActiveConnection.BeginTrans
End Sub

Private Sub Adodc1_Error(ByVal ErrorNumber As Long, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, fCancelDisplay As Boolean)
    ' Don't show validation errors.
    If ValidationError Then
        fCancelDisplay = True
        ValidationError = False
    End If
End Sub

Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ' force the update of the DataCombo control
    On Error Resume Next
    DataCombo1.BoundText = Adodc1.Recordset("SupplierID")
    ShowSupplierInfo
End Sub

Private Sub Adodc1_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ' Check that all fields are valid.
    If txtProductName = "" Or Not IsNumeric(txtUnitPrice) Or Not IsNumeric(txtUnitsInStock) Or Not IsNumeric(txtUnitsOnOrder) Then
        MsgBox "Please enter valid field values", vbExclamation
        ValidationError = True
        adStatus = adStatusCancel
    End If
    
    ' Nothing else to do if data in DataCombo hasn't been modified
    ' or if it matches an item in the list
    If Not DataCombo1.DataChanged Or DataCombo1.MatchedWithList Then Exit Sub
    
    ' Ask if the user wants to add a new supplier, exit if not.
    If MsgBox("Supplier not found." & vbCr _
        & "Do you want to add a new supplier?", vbYesNo + vbExclamation) = vbNo Then
        ValidationError = True
        adStatus = adStatusCancel
    End If
    
    ' Add a new record to the recordset. In a real application you should
    ' display a complete data entry form.
    rsSuppliers.AddNew "CompanyName", DataCombo1.Text
    rsSuppliers.Update
    ' Ensure that the new record is visible in the recordset.
    rsSuppliers.Requery
    rsSuppliers.Find "CompanyName = '" & DataCombo1.Text & "'"
    ' Refill the DataCombo and make the correct item the current one.
    DataCombo1.ReFill
    DataCombo1.BoundText = rsSuppliers("SupplierID")

End Sub

Private Sub DataCombo1_Click(Area As Integer)
    ' Move to the correct record in the lookup table.
    ' NOTE: the ContactName field must be included in the list
    '       of fields returned by the Adodc3 data control.
    ShowSupplierInfo
End Sub

Private Sub cmdAddNew_Click()
    Adodc1.Recordset.AddNew
End Sub

Private Sub cmdDelete_Click()
    Adodc1.Recordset.Delete
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If MsgBox("Do you confirm changes to records?", vbYesNo + vbExclamation) = vbYes Then
        Adodc1.Recordset.ActiveConnection.CommitTrans
    Else
        Adodc1.Recordset.ActiveConnection.RollbackTrans
        Adodc1.Refresh
    End If
End Sub

Private Sub ShowSupplierInfo()
    On Error Resume Next
    rsSuppliers.Bookmark = DataCombo1.SelectedItem
    lblSupplierData = rsSuppliers("ContactName")
    If Err Then lblSupplierData = ""
End Sub

Private Sub DataList1_MouseMove(Button As Integer, Shift As Integer, _
    x As Single, y As Single)
    ' Determine over which item the mouse cursor is.
    Dim item As Long
    item = Int(y / DataList1.Height * DataList1.VisibleCount)
    ' Retrieve the description for the category under the cursor and
    ' prepare a tooltip, in case the user doesn't move the mouse.
    rsCategories.Bookmark = DataList1.VisibleItems(item)
    DataList1.ToolTipText = rsCategories("Description")
End Sub




