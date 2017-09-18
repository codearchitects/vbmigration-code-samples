VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmRecordset 
   Caption         =   "Recordset"
   ClientHeight    =   7215
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8460
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
   ScaleHeight     =   7215
   ScaleWidth      =   8460
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Supports"
      Height          =   375
      Index           =   20
      Left            =   6600
      TabIndex        =   68
      Top             =   4680
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Save"
      Height          =   375
      Index           =   19
      Left            =   6600
      TabIndex        =   67
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Resync"
      Height          =   375
      Index           =   18
      Left            =   3720
      TabIndex        =   66
      Top             =   5040
      Width           =   975
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Requery"
      Height          =   375
      Index           =   17
      Left            =   2760
      TabIndex        =   65
      Top             =   5040
      Width           =   975
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "NextRecordset"
      Height          =   375
      Index           =   16
      Left            =   3000
      TabIndex        =   64
      Top             =   5520
      Width           =   1695
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "UpdateBatch"
      Height          =   375
      Index           =   15
      Left            =   120
      TabIndex        =   63
      Top             =   5520
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Update"
      Height          =   375
      Index           =   14
      Left            =   120
      TabIndex        =   62
      Top             =   5040
      Width           =   855
   End
   Begin VB.CommandButton cmdShowRecords 
      Caption         =   "Show Records"
      Height          =   375
      Left            =   6480
      TabIndex        =   61
      Top             =   5520
      Width           =   1575
   End
   Begin VB.CommandButton cmdShowFields 
      Caption         =   "Show Fields"
      Height          =   375
      Left            =   6480
      TabIndex        =   60
      Top             =   5160
      Width           =   1575
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "MovePrevious"
      Height          =   375
      Index           =   8
      Left            =   4800
      TabIndex        =   59
      Top             =   3960
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "MoveNext"
      Height          =   375
      Index           =   9
      Left            =   4800
      TabIndex        =   58
      Top             =   4320
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "MoveLast"
      Height          =   375
      Index           =   10
      Left            =   4800
      TabIndex        =   57
      Top             =   4680
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "MoveFirst"
      Height          =   375
      Index           =   7
      Left            =   4800
      TabIndex        =   56
      Top             =   3600
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Move"
      Height          =   375
      Index           =   11
      Left            =   4800
      TabIndex        =   55
      Top             =   5040
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Find"
      Height          =   375
      Index           =   13
      Left            =   6600
      TabIndex        =   54
      Top             =   3960
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Delete"
      Height          =   375
      Index           =   3
      Left            =   2760
      TabIndex        =   53
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Clone"
      Height          =   375
      Index           =   12
      Left            =   6600
      TabIndex        =   52
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "CancelUpdate"
      Height          =   375
      Index           =   6
      Left            =   960
      TabIndex        =   51
      Top             =   5040
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "CancelBatch"
      Height          =   375
      Index           =   5
      Left            =   1560
      TabIndex        =   50
      Top             =   5520
      Width           =   1335
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Cancel"
      Height          =   375
      Index           =   4
      Left            =   4800
      TabIndex        =   49
      Top             =   5520
      Width           =   1455
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "AddNew"
      Height          =   375
      Index           =   2
      Left            =   1800
      TabIndex        =   48
      Top             =   4560
      Width           =   975
   End
   Begin VB.ListBox lstCustomProperties 
      Height          =   1980
      Left            =   4800
      Sorted          =   -1  'True
      TabIndex        =   35
      Top             =   1560
      Width           =   3495
   End
   Begin TabDlg.SSTab tabRecordset 
      Height          =   4335
      Left            =   120
      TabIndex        =   8
      Top             =   120
      Width           =   4575
      _ExtentX        =   8070
      _ExtentY        =   7646
      _Version        =   393216
      Style           =   1
      Tabs            =   2
      TabHeight       =   529
      TabCaption(0)   =   "Closed RS props"
      TabPicture(0)   =   "frmRec.frx":0000
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "lblProperty(10)"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "lblProperty(9)"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "lblProperty(8)"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "lblProperty(2)"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "lblProperty(6)"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).Control(5)=   "lblProperty(4)"
      Tab(0).Control(5).Enabled=   0   'False
      Tab(0).Control(6)=   "lblProperty(13)"
      Tab(0).Control(6).Enabled=   0   'False
      Tab(0).Control(7)=   "lblProperty(12)"
      Tab(0).Control(7).Enabled=   0   'False
      Tab(0).Control(8)=   "lblProperty(18)"
      Tab(0).Control(8).Enabled=   0   'False
      Tab(0).Control(9)=   "txtMaxRecords"
      Tab(0).Control(9).Enabled=   0   'False
      Tab(0).Control(10)=   "cboLockType"
      Tab(0).Control(10).Enabled=   0   'False
      Tab(0).Control(11)=   "txtFilter"
      Tab(0).Control(11).Enabled=   0   'False
      Tab(0).Control(12)=   "cboCursorType"
      Tab(0).Control(12).Enabled=   0   'False
      Tab(0).Control(13)=   "cboCursorLocation"
      Tab(0).Control(13).Enabled=   0   'False
      Tab(0).Control(14)=   "txtCacheSize"
      Tab(0).Control(14).Enabled=   0   'False
      Tab(0).Control(15)=   "txtActiveConnection"
      Tab(0).Control(15).Enabled=   0   'False
      Tab(0).Control(16)=   "txtSort"
      Tab(0).Control(16).Enabled=   0   'False
      Tab(0).Control(17)=   "txtSource"
      Tab(0).Control(17).Enabled=   0   'False
      Tab(0).ControlCount=   18
      TabCaption(1)   =   "Open RS props"
      TabPicture(1)   =   "frmRec.frx":001C
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "lblProperty(0)"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "lblProperty(7)"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).Control(2)=   "lblProperty(1)"
      Tab(1).Control(2).Enabled=   0   'False
      Tab(1).Control(3)=   "lblProperty(5)"
      Tab(1).Control(3).Enabled=   0   'False
      Tab(1).Control(4)=   "lblProperty(3)"
      Tab(1).Control(4).Enabled=   0   'False
      Tab(1).Control(5)=   "lblProperty(14)"
      Tab(1).Control(5).Enabled=   0   'False
      Tab(1).Control(6)=   "lblProperty(11)"
      Tab(1).Control(6).Enabled=   0   'False
      Tab(1).Control(7)=   "lblProperty(15)"
      Tab(1).Control(7).Enabled=   0   'False
      Tab(1).Control(8)=   "lblProperty(16)"
      Tab(1).Control(8).Enabled=   0   'False
      Tab(1).Control(9)=   "lblProperty(17)"
      Tab(1).Control(9).Enabled=   0   'False
      Tab(1).Control(10)=   "cboAbsolutePage"
      Tab(1).Control(10).Enabled=   0   'False
      Tab(1).Control(11)=   "cboEditMode"
      Tab(1).Control(11).Enabled=   0   'False
      Tab(1).Control(12)=   "cboAbsolutePosition"
      Tab(1).Control(12).Enabled=   0   'False
      Tab(1).Control(13)=   "cboEOF"
      Tab(1).Control(13).Enabled=   0   'False
      Tab(1).Control(14)=   "cboBOF"
      Tab(1).Control(14).Enabled=   0   'False
      Tab(1).Control(15)=   "txtBookmark"
      Tab(1).Control(15).Enabled=   0   'False
      Tab(1).Control(16)=   "txtPageCount"
      Tab(1).Control(16).Enabled=   0   'False
      Tab(1).Control(17)=   "txtPageSize"
      Tab(1).Control(17).Enabled=   0   'False
      Tab(1).Control(18)=   "txtRecordCount"
      Tab(1).Control(18).Enabled=   0   'False
      Tab(1).Control(19)=   "cboState"
      Tab(1).Control(19).Enabled=   0   'False
      Tab(1).ControlCount=   20
      Begin VB.TextBox txtSource 
         Height          =   360
         Left            =   2040
         TabIndex        =   46
         Top             =   3480
         Width           =   2415
      End
      Begin VB.ComboBox cboState 
         Height          =   360
         Left            =   -72960
         Locked          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   45
         Top             =   3840
         Width           =   2415
      End
      Begin VB.TextBox txtSort 
         Height          =   360
         Left            =   2040
         TabIndex        =   42
         Top             =   3120
         Width           =   2415
      End
      Begin VB.TextBox txtRecordCount 
         Height          =   375
         Left            =   -72960
         Locked          =   -1  'True
         TabIndex        =   41
         Top             =   3480
         Width           =   2415
      End
      Begin VB.TextBox txtPageSize 
         Height          =   375
         Left            =   -72960
         Locked          =   -1  'True
         TabIndex        =   39
         Top             =   3120
         Width           =   2415
      End
      Begin VB.TextBox txtPageCount 
         Height          =   375
         Left            =   -72960
         Locked          =   -1  'True
         TabIndex        =   37
         Top             =   2760
         Width           =   2415
      End
      Begin VB.TextBox txtBookmark 
         Height          =   375
         Left            =   -72960
         TabIndex        =   34
         Top             =   1680
         Width           =   2415
      End
      Begin VB.TextBox txtActiveConnection 
         Height          =   360
         Left            =   2040
         TabIndex        =   31
         Top             =   600
         Width           =   2415
      End
      Begin VB.ComboBox cboBOF 
         Height          =   360
         Left            =   -72960
         Locked          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   28
         Top             =   1320
         Width           =   2415
      End
      Begin VB.ComboBox cboEOF 
         Height          =   360
         Left            =   -72960
         Locked          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   27
         Top             =   2400
         Width           =   2415
      End
      Begin VB.ComboBox cboAbsolutePosition 
         Height          =   360
         Left            =   -72945
         TabIndex        =   24
         Top             =   960
         Width           =   2415
      End
      Begin VB.ComboBox cboEditMode 
         Height          =   360
         Left            =   -72960
         Locked          =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   23
         Top             =   2040
         Width           =   2415
      End
      Begin VB.ComboBox cboAbsolutePage 
         Height          =   360
         Left            =   -72960
         TabIndex        =   21
         Top             =   600
         Width           =   2415
      End
      Begin VB.TextBox txtCacheSize 
         Height          =   360
         Left            =   2040
         TabIndex        =   14
         Top             =   960
         Width           =   2415
      End
      Begin VB.ComboBox cboCursorLocation 
         Height          =   360
         Left            =   2040
         Style           =   2  'Dropdown List
         TabIndex        =   13
         Top             =   1320
         Width           =   2415
      End
      Begin VB.ComboBox cboCursorType 
         Height          =   360
         Left            =   2040
         Style           =   2  'Dropdown List
         TabIndex        =   12
         Top             =   1680
         Width           =   2415
      End
      Begin VB.TextBox txtFilter 
         Height          =   360
         Left            =   2040
         TabIndex        =   11
         Top             =   2040
         Width           =   2415
      End
      Begin VB.ComboBox cboLockType 
         Height          =   360
         Left            =   2040
         Style           =   2  'Dropdown List
         TabIndex        =   10
         Top             =   2400
         Width           =   2415
      End
      Begin VB.TextBox txtMaxRecords 
         Height          =   360
         Left            =   2040
         TabIndex        =   9
         Top             =   2760
         Width           =   2415
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Source"
         Height          =   360
         Index           =   18
         Left            =   120
         TabIndex        =   47
         Top             =   3480
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "State"
         Height          =   375
         Index           =   17
         Left            =   -74880
         TabIndex        =   44
         Top             =   3840
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Sort"
         Height          =   360
         Index           =   12
         Left            =   120
         TabIndex        =   43
         Top             =   3120
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "RecordCount"
         Height          =   375
         Index           =   16
         Left            =   -74880
         TabIndex        =   40
         Top             =   3480
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PageSize"
         Height          =   375
         Index           =   15
         Left            =   -74880
         TabIndex        =   38
         Top             =   3120
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "PageCount"
         Height          =   375
         Index           =   11
         Left            =   -74880
         TabIndex        =   36
         Top             =   2760
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Bookmark"
         Height          =   360
         Index           =   14
         Left            =   -74880
         TabIndex        =   33
         Top             =   1680
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "ActiveConnection"
         Height          =   360
         Index           =   13
         Left            =   120
         TabIndex        =   32
         Top             =   600
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "BOF"
         Height          =   360
         Index           =   3
         Left            =   -74880
         TabIndex        =   30
         Top             =   1320
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "EOF"
         Height          =   360
         Index           =   5
         Left            =   -74880
         TabIndex        =   29
         Top             =   2400
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "AbsolutePosition"
         Height          =   360
         Index           =   1
         Left            =   -74880
         TabIndex        =   26
         Top             =   960
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "EditMode"
         Height          =   360
         Index           =   7
         Left            =   -74880
         TabIndex        =   25
         Top             =   2040
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "AbsolutePage"
         Height          =   360
         Index           =   0
         Left            =   -74880
         TabIndex        =   22
         Top             =   600
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "CacheSize"
         Height          =   360
         Index           =   4
         Left            =   120
         TabIndex        =   20
         Top             =   960
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "CursorLocation"
         Height          =   360
         Index           =   6
         Left            =   120
         TabIndex        =   19
         Top             =   1320
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "CursorType"
         Height          =   360
         Index           =   2
         Left            =   120
         TabIndex        =   18
         Top             =   1680
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "Filter"
         Height          =   360
         Index           =   8
         Left            =   120
         TabIndex        =   17
         Top             =   2040
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "LockType"
         Height          =   360
         Index           =   9
         Left            =   120
         TabIndex        =   16
         Top             =   2400
         Width           =   1935
      End
      Begin VB.Label lblProperty 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         Caption         =   "MaxRecords"
         Height          =   360
         Index           =   10
         Left            =   120
         TabIndex        =   15
         Top             =   2760
         Width           =   1935
      End
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      Height          =   375
      Left            =   7560
      TabIndex        =   7
      Top             =   6000
      Width           =   855
   End
   Begin VB.TextBox txtEvents 
      Height          =   1215
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   6
      Top             =   6000
      Width           =   7335
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Close"
      Height          =   375
      Index           =   1
      Left            =   960
      TabIndex        =   5
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Open"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   4
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton cmdSetProperties 
      Caption         =   "Set &Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   3
      Top             =   120
      Width           =   1815
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Height          =   375
      Left            =   7440
      TabIndex        =   2
      Top             =   1080
      Width           =   855
   End
   Begin VB.TextBox txtCustomProperty 
      Height          =   375
      Left            =   4800
      TabIndex        =   0
      Top             =   1080
      Width           =   2655
   End
   Begin VB.Label lblCustomProperty 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Custom Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   1
      Top             =   720
      Width           =   3495
   End
End
Attribute VB_Name = "frmRecordset"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public WithEvents rs As ADODB.Recordset
Attribute rs.VB_VarHelpID = -1

Private frmFields As frmFields
Private frmRecords As frmRecords

Private Sub Form_Load()
    If rs Is Nothing Then
        Set rs = New ADODB.Recordset
    End If
    'rs.ActiveConnection = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=e:\Microsoft Visual Studio\Vb98\Nwind.mdb"
    'rs.Source = "Employees"
    
    InitFields
    ShowProperties
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Not (frmFields Is Nothing) Then Unload frmFields
    If Not (frmRecords Is Nothing) Then Unload frmRecords
End Sub

Private Sub lstCustomProperties_Click()
    txtCustomProperty.Text = GetCustomPropertyValue(rs, lstCustomProperties)
    cmdSet.Enabled = CustomPropertyIsWriteable(rs, lstCustomProperties)
End Sub

Private Sub cmdSet_Click()
    SetCustomPropertyValue rs, lstCustomProperties, txtCustomProperty.Text
End Sub

Private Sub cmdSetProperties_Click()
    AssignProperties
    ShowProperties
End Sub

Private Sub cmdClear_Click()
    txtEvents = ""
End Sub

' Initialize fields and combo boxes

Private Sub InitFields()
    AddToCombo cboCursorLocation, "adUseServer", adUseServer
    AddToCombo cboCursorLocation, "adUseClient", adUseClient
    
    AddToCombo cboCursorType, "adOpenForwardOnly", adOpenForwardOnly
    AddToCombo cboCursorType, "adOpenKeyset", adOpenKeyset
    AddToCombo cboCursorType, "adOpenDynamic", adOpenDynamic
    AddToCombo cboCursorType, "adOpenStatic", adOpenStatic
    
    AddToCombo cboLockType, "adLockReadOnly", adLockReadOnly
    AddToCombo cboLockType, "adLockPessimistic", adLockPessimistic
    AddToCombo cboLockType, "adLockOptimistic", adLockOptimistic
    AddToCombo cboLockType, "adLockBatchOptimistic", adLockBatchOptimistic
    
    AddToCombo cboAbsolutePage, "adPosUnknown", adPosUnknown
    AddToCombo cboAbsolutePage, "adPosBOF", adPosBOF
    AddToCombo cboAbsolutePage, "adPosEOF", adPosEOF
    
    AddToCombo cboAbsolutePosition, "adPosUnknown", adPosUnknown
    AddToCombo cboAbsolutePosition, "adPosBOF", adPosBOF
    AddToCombo cboAbsolutePosition, "adPosEOF", adPosEOF
    
    AddToCombo cboBOF, "False", False
    AddToCombo cboBOF, "True", True
    
    AddToCombo cboEditMode, "adEditNone", adEditNone
    AddToCombo cboEditMode, "adEditInProgress", adEditInProgress
    AddToCombo cboEditMode, "adEditAdd", adEditAdd
    AddToCombo cboEditMode, "adEditDelete", adEditDelete
        
    AddToCombo cboEOF, "False", False
    AddToCombo cboEOF, "True", True
    
    AddToCombo cboState, "adStateClosed", adStateClosed
    AddToCombo cboState, "adStateOpen", adStateOpen
    AddToCombo cboState, "adStateConnecting", adStateConnecting
    AddToCombo cboState, "adStateExecuting", adStateExecuting
    AddToCombo cboState, "adStateFetching", adStateFetching
    
End Sub

' Refresh the contents of the property fields.

Sub ShowProperties()
    ShowProperty rs, txtActiveConnection
    ShowProperty rs, txtCacheSize
    ShowProperty rs, cboCursorLocation
    ShowProperty rs, cboCursorType
    ShowProperty rs, txtFilter
    ShowProperty rs, cboLockType
    ShowProperty rs, txtMaxRecords
    ShowProperty rs, txtSort
    ShowProperty rs, txtSource
    ShowProperty rs, cboAbsolutePage
    ShowProperty rs, cboAbsolutePosition
    ShowProperty rs, cboBOF
    ShowProperty rs, txtBookmark
    ShowProperty rs, cboEditMode
    ShowProperty rs, cboEOF
    ShowProperty rs, txtPageCount
    ShowProperty rs, txtPageSize
    ShowProperty rs, txtRecordCount
    ShowProperty rs, cboState
    
    cmdSet.Enabled = True
    ShowCustomProperties rs, lstCustomProperties
    
    cmdShowFields.Enabled = (rs.State And adStateOpen)
    cmdShowRecords.Enabled = (rs.State And adStateOpen)
End Sub

' Assign current values in fields to properties

Sub AssignProperties()
    AssignProperty rs, txtActiveConnection
    AssignProperty rs, txtCacheSize
    AssignProperty rs, cboCursorLocation
    AssignProperty rs, cboCursorType
    AssignProperty rs, txtFilter
    AssignProperty rs, cboLockType
    AssignProperty rs, txtMaxRecords
    AssignProperty rs, txtSort
    AssignProperty rs, txtSource
    AssignProperty rs, cboAbsolutePage
    AssignProperty rs, cboAbsolutePosition
    AssignProperty rs, txtBookmark
End Sub

Private Sub cmdMethod_Click(Index As Integer)
    Dim action As String, args(5) As Variant
    Dim returnValue As Variant, retLong As Long
    Dim frmArgs As New frmArguments
    
    On Error GoTo ErrorHandler
    
    AssignProperties
    
    Select Case Index
        Case 0
            action = "open the recordset"
            args(0) = txtSource
            args(1) = txtActiveConnection
            If frmArgs.GetArgValues("Open", args(), "@Source", "@ActiveConnection", "@CursorType", "@LockType", "@Options") Then
                If IsMissing(args(0)) Then args(0) = txtSource
                If IsMissing(args(1)) Then args(1) = txtActiveConnection
                If IsMissing(args(2)) Then args(2) = GetComboValue(cboCursorType)
                If IsMissing(args(3)) Then args(3) = GetComboValue(cboLockType)
                If IsMissing(args(4)) Then args(4) = 0
                rs.Open args(0), args(1), args(2), args(3), args(4)
            End If
        Case 1
            action = "close the recordset"
            rs.Close
        Case 2
            action = "add a new record"
            rs.AddNew
        Case 3
            action = "delete the current record"
            If frmArgs.GetArgValues("Delete", args(), "@AffectRecords") Then
                If IsMissing(args(0)) Then args(0) = adAffectCurrent
                rs.Delete args(0)
            End If
        Case 4
            action = "cancel the current operation"
            rs.Cancel
        Case 5
            action = "cancel the current batch operation"
            If frmArgs.GetArgValues("Delete", args(), "@AffectRecords") Then
                If IsMissing(args(0)) Then args(0) = adAffectCurrent
                rs.CancelBatch args(0)
            End If
        Case 6
            action = "cancel the current update operation"
            rs.CancelUpdate
        Case 7
            action = "move to the first record"
            rs.MoveFirst
        Case 8
            action = "move to the previous record"
            rs.MovePrevious
        Case 9
            action = "move to the next record"
            rs.MoveNext
        Case 10
            action = "move to the last record"
            rs.MoveLast
        Case 11
            action = "move to the specified record"
            If frmArgs.GetArgValues("Move", args(), "NumRecords", "@Start") Then
                If IsMissing(args(1)) Then args(1) = adBookmarkCurrent
                rs.Move args(0)
            End If
        Case 12
            action = "clone the recordset"
            If frmArgs.GetArgValues("Clone", args(), "@LockType") Then
                If IsMissing(args(0)) Then args(0) = GetComboValue(cboLockType)
                Dim frm As New frmRecordset
                Set frm.rs = rs.Clone
                frm.Show
            End If
        Case 13
            action = "find a value"
            If frmArgs.GetArgValues("Find", args(), "Criteria", "@SkipRecords", "@SearchDirection", "@Start") Then
                If IsMissing(args(1)) Then args(1) = 0
                If IsMissing(args(2)) Then args(2) = adSearchForward
                If IsMissing(args(3)) Then args(3) = adBookmarkCurrent
                rs.Find args(0), args(1), args(2), args(3)
            End If
        Case 14
            action = "update the recordset"
            rs.Update
        Case 15
            action = "update the recordset in batch mode"
            If frmArgs.GetArgValues("UpdateBatch", args(), "@AffectRecords") Then
                If IsMissing(args(0)) Then
                    rs.UpdateBatch
                Else
                    rs.UpdateBatch args(0)
                End If
            End If
        Case 16
            action = "retrieve the next recordset"
            rs.NextRecordset retLong
            returnValue = retLong
        Case 17
            action = "requery the data source"
            If frmArgs.GetArgValues("Requery", args(), "@Options") Then
                If IsMissing(args(0)) Then args(0) = -1
                rs.Requery args(0)
            End If
        Case 18
            action = "resync the recordset"
            If frmArgs.GetArgValues("Resync", args(), "@AffectRecords", "@ResyncValues") Then
                If IsMissing(args(1)) Then args(1) = adResyncAllValues
                If IsMissing(args(0)) Then
                    rs.Resync , args(1)
                Else
                    rs.Resync args(0), args(1)
                End If
            End If
        Case 19
            action = "save the recordset"
            If frmArgs.GetArgValues("Save", args(), "@Filename", "@PersistFormat") Then
                If IsMissing(args(1)) Then args(1) = adPersistADTG
                If IsMissing(args(0)) Then
                    rs.Save
                Else
                    rs.Save args(0), args(1)
                End If
            End If
        Case 20
            action = "test supported properties"
            If frmArgs.GetArgValues("Supports", args(), "CursorOptions") Then
                returnValue = rs.Supports(args(0))
            End If
    End Select
    
    ShowProperties
    If Not IsEmpty(returnValue) Then
        On Error Resume Next
        MsgBox "Return Value = " & returnValue, vbInformation, cmdMethod(Index).Name & " Method"
    End If
    
    Exit Sub
    
ErrorHandler:
    MsgBox "Unable to " & action & vbCr & vbCr _
        & "Error = " & Err.Number & " - " & Err.Description, _
        vbExclamation, "Warning"

End Sub

Private Sub cmdShowFields_Click()
    On Error Resume Next
    Set frmFields = New frmFields
    Set frmFields.rs = rs
    frmFields.Show
End Sub

Private Sub cmdShowRecords_Click()
    On Error Resume Next
    Set frmRecords = New frmRecords
    Set frmRecords.rs = rs
    frmRecords.Show
End Sub


'------------------------------------
' Event procedures
'------------------------------------

Private Sub rs_EndOfRecordset(fMoreData As Boolean, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "EndOfRecordset", "fMoreData", fMoreData, "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_FetchComplete(ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "FetchComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_FetchProgress(ByVal Progress As Long, ByVal MaxProgress As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "FetchProgress", "Progress", Progress, "MaxProgress", MaxProgress, "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_FieldChangeComplete(ByVal cFields As Long, ByVal Fields As Variant, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "FieldChangeComplete", "cFields", cFields, "Fields", "(array)", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "MoveComplete", "adReason", GetReason(adReason), "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "RecordChangeComplete", "adReason", GetReason(adReason), "cRecords", cRecords, "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_RecordsetChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "RecordsetChangeComplete", "adReason", GetReason(adReason), "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_WillChangeField(ByVal cFields As Long, ByVal Fields As Variant, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "WillChangeField", "cFields", cFields, "Fields", "(array)", "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "WillChangeRecord", "adReason", GetReason(adReason), "cRecords", cRecords, "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_WillChangeRecordset(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "WillChangeRecordset", "adReason", GetReason(adReason), "adStatus", GetStatus(adStatus)
End Sub

Private Sub rs_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    ShowEvent txtEvents, "WillMove", "adReason", GetReason(adReason), "adStatus", GetStatus(adStatus)
End Sub

Private Function GetReason(value As EventReasonEnum) As String
    Select Case value
        Case adRsnAddNew
            GetReason = "#adRsnAddNew"
        Case adRsnDelete
            GetReason = "#adRsnDelete"
        Case adRsnUpdate
            GetReason = "#adRsnUpdate"
        Case adRsnUndoUpdate
            GetReason = "#adRsnUndoUpdate"
        Case adRsnUndoAddNew
            GetReason = "#adRsnUndoAddNew"
        Case adRsnUndoDelete
            GetReason = "#adRsnUndoDelete"
        Case adRsnRequery
            GetReason = "#adRsnRequery"
        Case adRsnResynch
            GetReason = "#adRsnResynch"
        Case adRsnClose
            GetReason = "#adRsnClose"
        Case adRsnMove
            GetReason = "#adRsnMove"
        Case adRsnFirstChange
            GetReason = "#adRsnFirstChange"
        Case adRsnMoveFirst
            GetReason = "#adRsnMoveFirst"
        Case adRsnMoveNext
            GetReason = "#adRsnMoveNext"
        Case adRsnMovePrevious
            GetReason = "#adRsnMovePrevious"
        Case adRsnMoveLast
            GetReason = "#adRsnMoveLast"
    End Select
End Function

