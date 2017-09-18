VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmDataEnv 
   Caption         =   "Optimistic Batch Updates Demo"
   ClientHeight    =   4920
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7680
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
   ScaleHeight     =   4920
   ScaleWidth      =   7680
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   500
      Left            =   6840
      Top             =   2520
   End
   Begin VB.CommandButton cmdResync 
      Caption         =   "Resync"
      Height          =   495
      Left            =   5640
      TabIndex        =   12
      Top             =   600
      Width           =   1575
   End
   Begin VB.CheckBox chkFilterMode 
      Caption         =   "Filter Mode"
      Height          =   375
      Left            =   4320
      TabIndex        =   10
      Top             =   2040
      Width           =   1695
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "Update"
      Height          =   495
      Left            =   3720
      TabIndex        =   8
      Top             =   600
      Width           =   1575
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   4320
      Top             =   2520
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
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
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   ""
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.TextBox txtField 
      DataField       =   "UnitsInStock"
      DataSource      =   "Adodc1"
      Height          =   375
      Index           =   2
      Left            =   1920
      TabIndex        =   7
      Top             =   2520
      Width           =   1815
   End
   Begin VB.TextBox txtField 
      DataField       =   "UnitPrice"
      DataSource      =   "Adodc1"
      Height          =   375
      Index           =   1
      Left            =   1920
      TabIndex        =   5
      Top             =   2040
      Width           =   1815
   End
   Begin VB.TextBox txtField 
      DataField       =   "ProductName"
      DataSource      =   "Adodc1"
      Height          =   375
      Index           =   0
      Left            =   1920
      TabIndex        =   3
      Top             =   1560
      Width           =   5415
   End
   Begin VB.CommandButton cmdOpen 
      Caption         =   "Open"
      Height          =   495
      Left            =   1920
      TabIndex        =   1
      Top             =   600
      Width           =   1335
   End
   Begin VB.TextBox txtConnectionString 
      Height          =   375
      Left            =   1920
      TabIndex        =   0
      Top             =   120
      Width           =   5295
   End
   Begin VB.Label lblStatus 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   1920
      TabIndex        =   17
      Top             =   4440
      Width           =   5535
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "Record's Status"
      Height          =   375
      Index           =   3
      Left            =   240
      TabIndex        =   16
      Top             =   4440
      Width           =   1575
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "UnderlyingValue"
      Height          =   375
      Index           =   2
      Left            =   240
      TabIndex        =   15
      Top             =   3960
      Width           =   1575
   End
   Begin VB.Label lblUnderlyingValue 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   1920
      TabIndex        =   14
      Top             =   3960
      Width           =   5535
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "OriginalValue"
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   13
      Top             =   3480
      Width           =   1575
   End
   Begin VB.Label lblOriginalValue 
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Left            =   1920
      TabIndex        =   11
      Top             =   3480
      Width           =   5535
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "ConnectionString"
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   9
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label lblField 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Index           =   2
      Left            =   240
      TabIndex        =   6
      Top             =   2520
      Width           =   1575
   End
   Begin VB.Label lblField 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Index           =   1
      Left            =   240
      TabIndex        =   4
      Top             =   2040
      Width           =   1575
   End
   Begin VB.Label lblField 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Height          =   375
      Index           =   0
      Left            =   240
      TabIndex        =   2
      Top             =   1560
      Width           =   1575
   End
End
Attribute VB_Name = "frmDataEnv"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False

Option Explicit

Dim cn As ADODB.Connection
Dim rs As ADODB.Recordset

Private Sub Form_Load()
    Set cn = New ADODB.Connection
    Set rs = New ADODB.Recordset
    ' This is for Jet databases.
    txtConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\Biblio.mdb"
    ' this is for SQL Server (adjust server name)
    'txtConnectionString = "Provider=sqloledb;data source=p2;user id=sa;initial catalog=pubs"
End Sub

Private Sub cmdOpen_Click()
    On Error Resume Next
    
    ' First, close an open connection.
    If cn.State And adStateOpen Then cn.Close
    
    ' Open the connection using the specified connection string.
    cn.Open txtConnectionString
    If Err Then
        MsgBox "Unable to open the connection." & vbCr & Err.Description, vbCritical
        Exit Sub
    End If
    
    ' Open the recordset on that connection
    rs.CursorLocation = adUseClient
    rs.Open "Titles", cn, adOpenStatic, adLockBatchOptimistic, adCmdTable
'    rs.Open "Titles", cn, adOpenKeyset, adLockOptimistic, adCmdTable

    If Err Then
        MsgBox "Unable to open the recordset." & vbCr & Err.Description, vbCritical
        Exit Sub
    End If
    
    ' Show different fields for different databases.
    If InStr(1, cn.Provider, "sqloledb", 1) Then
        txtField(0).DataField = "Title"
        txtField(1).DataField = "Advance"
        txtField(2).DataField = "royalty"
    ElseIf InStr(1, cn.Provider, "Jet", 1) Then
        txtField(0).DataField = "Title"
        txtField(1).DataField = "Year Published"
        txtField(2).DataField = "ISBN"
    Else
        MsgBox "Unknown provider. Unable to bind fields", vbExclamation
        Exit Sub
    End If
    
    Dim i As Integer
    For i = txtField.LBound To txtField.UBound
        lblField(i).Caption = txtField(i).DataField
    Next
    
    ' Bind to the ADO Data control.
    Set Adodc1.Recordset = rs
    ' Disconnect the recordset from the connection.
    Set rs.ActiveConnection = Nothing
    
End Sub

Private Sub cmdUpdate_Click()
    
    On Error Resume Next
    
    ' Reconnect to the data source and do a batch update
    Set rs.ActiveConnection = cn
    rs.UpdateBatch
    
    If Err = 0 Then
        MsgBox "Successful batch update", vbInformation
    Else
        MsgBox "Error while updating. " & vbCr & Err.Description & vbCr & vbCr _
            & "There might be conflicting records. Tick the FilterMode checkbox to see them", vbExclamation
            chkFilterMode.Enabled = True
    End If
    
End Sub

Private Sub cmdResync_Click()
    Dim answer As Integer
    
    answer = MsgBox("Do you want to retrieve updated values?" & vbCr & vbCr _
        & "Click Yes to overwrite the Value property" & vbCr _
        & "No to just read the UnderlyingValue property", vbYesNo + vbQuestion + vbDefaultButton2)
    If answer = vbYes Then
        rs.Resync adAffectAllChapters, adResyncAllValues
    Else
        rs.Resync adAffectAllChapters, adResyncUnderlyingValues
    End If
    rs.MoveFirst
End Sub

Private Sub chkFilterMode_Click()
    If chkFilterMode = vbChecked Then
        rs.Filter = adFilterConflictingRecords
        ' Check if there are conflicts.
        If rs.RecordCount Then
            lblOriginalValue = rs.RecordCount & " conflicts"
        Else
            ' Error were caused by something else.
            lblOriginalValue.Caption = "No conflicts"
            ' Restore original recordset
            chkFilterMode.Value = vbUnchecked
        End If
        
    Else
        ' You can activate Filter mode only once
        rs.Filter = adFilterNone
        chkFilterMode.Enabled = False
    End If
End Sub

Private Sub txtField_GotFocus(Index As Integer)
    ShowProperties
End Sub

Private Sub Timer1_Timer()
    ShowProperties
End Sub

Private Sub ShowProperties()
    Dim txt As TextBox, fldName As String
    Dim status As Long, statusMsg As String
    
    On Error Resume Next
    
    If cn.State = adStateClosed Then Exit Sub
    
    lblOriginalValue = ""
    lblUnderlyingValue = ""
    lblStatus = ""
    
    ' Which textbox has the focus?
    For Each txt In txtField
        If txt Is ActiveControl Then fldName = txt.DataField
    Next
    ' Show Original and Underlying value.
    If fldName <> "" Then
        lblOriginalValue = rs(fldName).OriginalValue
        lblUnderlyingValue = rs(fldName).UnderlyingValue
    End If
    
    ' Show record status
    status = rs.status
    If status = 0 Then statusMsg = " + adRecOK"
    If status And adRecCanceled Then statusMsg = statusMsg & " + adRecCanceled"
    If status And adRecCantRelease Then statusMsg = statusMsg & " + adRecCantRelease"
    If status And adRecConcurrencyViolation Then statusMsg = statusMsg & " + adRecConcurrencyViolation"
    If status And adRecDBDeleted Then statusMsg = statusMsg & " + adRecDBDeleted"
    If status And adRecDeleted Then statusMsg = statusMsg & " + adRecDeleted"
    If status And adRecIntegrityViolation Then statusMsg = statusMsg & " + adRecIntegrityViolation"
    If status And adRecInvalid Then statusMsg = statusMsg & " + adRecInvalid"
    If status And adRecMaxChangesExceeded Then statusMsg = statusMsg & " + adRecMaxChangesExceeded"
    If status And adRecModified Then statusMsg = statusMsg & " + adRecModified"
    If status And adRecMultipleChanges Then statusMsg = statusMsg & " + adRecMultipleChanges"
    If status And adRecNew Then statusMsg = statusMsg & " + adRecNew"
    If status And adRecObjectOpen Then statusMsg = statusMsg & " + adRecObjectOpen"
    If status And adRecOutOfMemory Then statusMsg = statusMsg & " + adRecOutOfMemory"
    If status And adRecPendingChanges Then statusMsg = statusMsg & " + adRecPendingChanges"
    If status And adRecPermissionDenied Then statusMsg = statusMsg & " + adRecPermissionDenied"
    If status And adRecSchemaViolation Then statusMsg = statusMsg & " + adRecSchemaViolation"
    If status And adRecUnmodified Then statusMsg = statusMsg & " + adRecUnmodified"
    lblStatus = Mid$(statusMsg, 4)
End Sub

