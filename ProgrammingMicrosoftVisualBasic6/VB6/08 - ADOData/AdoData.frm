VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form Form1 
   Caption         =   "ADO Data Control Demo"
   ClientHeight    =   3150
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6675
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
   ScaleHeight     =   3150
   ScaleWidth      =   6675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   5160
      TabIndex        =   12
      Top             =   2160
      Width           =   1215
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "&Update"
      Height          =   375
      Left            =   3840
      TabIndex        =   11
      Top             =   2160
      Width           =   1215
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   1560
      TabIndex        =   10
      Top             =   2160
      Width           =   1215
   End
   Begin VB.CommandButton cmdAddNew 
      Caption         =   "&AddNew"
      Height          =   375
      Left            =   240
      TabIndex        =   9
      Top             =   2160
      Width           =   1215
   End
   Begin VB.CheckBox chkDiscontinued 
      Caption         =   "Discontinued"
      DataField       =   "Discontinued"
      DataSource      =   "Adodc1"
      Height          =   255
      Left            =   4320
      TabIndex        =   8
      Top             =   720
      Width           =   1575
   End
   Begin VB.TextBox txtUnitsOnOrder 
      DataField       =   "UnitsOnOrder"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   3
      Top             =   1560
      Width           =   1455
   End
   Begin VB.TextBox txtUnitsInStock 
      DataField       =   "UnitsInStock"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   1080
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
      Top             =   600
      Width           =   1455
   End
   Begin VB.TextBox txtProductName 
      DataField       =   "ProductName"
      DataSource      =   "Adodc1"
      Height          =   375
      Left            =   2400
      TabIndex        =   0
      Top             =   120
      Width           =   3975
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      Top             =   2775
      Width           =   6675
      _ExtentX        =   11774
      _ExtentY        =   661
      ConnectMode     =   3
      CursorLocation  =   2
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   2
      LockType        =   3
      CommandType     =   2
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   1
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
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
   Begin VB.Label Label4 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Units on Order"
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Top             =   1560
      Width           =   2175
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Units in Stock"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   1080
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
      Top             =   600
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

' IMPORTANT: ensure that the DB_PATH constant is pointing to the
' NWind.mdb database on your system
Const DB_PATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"

Dim DataHasChanged As Boolean
Dim AddNewMode As Boolean
Dim ValidationError As Boolean

' Form Events

Private Sub Form_Load()
    Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=" & DB_PATH
    Adodc1.Refresh
    
    ' Start a transaction
    Adodc1.Recordset.ActiveConnection.BeginTrans
    ' disable the Update/CancelUpdate buttons
    ChangedData False
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Not DataHasChanged Then
        ' no record was changed, do nothing
        
        '##NOTE We need a RollbackTrans call because of the BeginTrans in the Form_Load method
        '##InsertStatement Adodc1.Recordset.ActiveConnection.RollbackTrans
        
    ElseIf MsgBox("Do you confirm changes to records?", vbYesNo + vbExclamation) = vbYes Then
        Adodc1.Recordset.ActiveConnection.CommitTrans
    Else
        Adodc1.Recordset.ActiveConnection.RollbackTrans
        Adodc1.Refresh
    End If
End Sub

' ADO Data control events.

Private Sub Adodc1_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ' disable the Update/CancelUpdate buttons when user moves on a new record.
    ChangedData False
    AddNewMode = False
End Sub

Private Sub Adodc1_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ' Check that all fields are valid.
    If txtProductName.DataChanged And txtProductName = "" Then
        ValidationError = True
    ElseIf txtUnitPrice.DataChanged And Not IsNumeric(txtUnitPrice) Then
        ValidationError = True
    ElseIf txtUnitsOnOrder.DataChanged And Not IsNumeric(txtUnitsOnOrder) Then
        ValidationError = True
    End If
    
    If ValidationError Then
        MsgBox "Please enter valid field values", vbExclamation
        adStatus = adStatusCancel
    Else
        ' Remember that at least one record has changed.
        DataHasChanged = True
    End If
End Sub

Private Sub Adodc1_Error(ByVal ErrorNumber As Long, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, fCancelDisplay As Boolean)
    ' Don't show validation errors.
    If ValidationError Then
        fCancelDisplay = True
        ValidationError = False
    End If
End Sub

' Button actions.

Private Sub cmdAddNew_Click()
    On Error Resume Next
    Adodc1.Recordset.AddNew
    If Err Then
        MsgBox "Error " & Err.Number & vbCr & Err.Description, vbCritical
    Else
        txtProductName.SetFocus
        cmdCancel.Enabled = True
        AddNewMode = True
    End If
End Sub

Private Sub cmdDelete_Click()
    On Error GoTo Error_Handler
    With Adodc1.Recordset
        .Delete
        .MoveNext
        If .EOF And Not .BOF Then .MoveLast
    End With
    Exit Sub
    
Error_Handler:
    MsgBox "Error " & Err.Number & vbCr & Err.Description, vbCritical

End Sub

Private Sub cmdUpdate_Click()
    Adodc1.Recordset.Update
    ChangedData False
End Sub

Private Sub cmdCancel_Click()
    ' Cancel edit to current record.
    Adodc1.Recordset.CancelUpdate
    ChangedData False
End Sub

Private Sub txtProductName_Change()
    If txtProductName.DataChanged Then ChangedData
End Sub

Private Sub txtUnitPrice_Change()
    If txtUnitPrice.DataChanged Then ChangedData
End Sub

Private Sub txtUnitsInStock_Change()
    If txtUnitsInStock.DataChanged Then ChangedData
End Sub

Private Sub txtUnitsOnOrder_Change()
    If txtUnitsOnOrder.DataChanged Then ChangedData
End Sub

Private Sub chkDiscontinued_Click()
    If chkDiscontinued.DataChanged Then ChangedData
End Sub

' Update the status of the Update/CancelUpdate
Sub ChangedData(Optional newStatus As Boolean = True)
    cmdUpdate.Enabled = newStatus
    cmdCancel.Enabled = newStatus
End Sub
