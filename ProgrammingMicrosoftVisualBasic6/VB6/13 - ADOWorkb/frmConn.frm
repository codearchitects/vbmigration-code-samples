VERSION 5.00
Begin VB.Form frmConnection 
   Caption         =   "Connection"
   ClientHeight    =   6855
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8505
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
   ScaleHeight     =   6855
   ScaleWidth      =   8505
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShowRecordset 
      Caption         =   "Show Recordset"
      Height          =   375
      Left            =   6480
      TabIndex        =   37
      Top             =   4800
      Width           =   1815
   End
   Begin VB.CommandButton cmdShowErrors 
      Caption         =   "Show &Errors"
      Height          =   375
      Left            =   6480
      TabIndex        =   36
      Top             =   4320
      Width           =   1815
   End
   Begin VB.CommandButton cmdClear 
      Caption         =   "Clear"
      Height          =   375
      Left            =   7560
      TabIndex        =   35
      Top             =   5400
      Width           =   855
   End
   Begin VB.TextBox txtEvents 
      Height          =   1335
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   34
      Top             =   5400
      Width           =   7335
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Cancel"
      Height          =   375
      Index           =   6
      Left            =   3840
      TabIndex        =   33
      Top             =   4320
      Width           =   1335
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Execute"
      Height          =   375
      Index           =   5
      Left            =   2520
      TabIndex        =   32
      Top             =   4320
      Width           =   1335
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "RollbackTrans"
      Height          =   375
      Index           =   4
      Left            =   3480
      TabIndex        =   31
      Top             =   4800
      Width           =   1695
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "CommitTrans"
      Height          =   375
      Index           =   3
      Left            =   1800
      TabIndex        =   30
      Top             =   4800
      Width           =   1695
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "BeginTrans"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   29
      Top             =   4800
      Width           =   1695
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Close"
      Height          =   375
      Index           =   1
      Left            =   1200
      TabIndex        =   28
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "&Open"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   27
      Top             =   4320
      Width           =   1095
   End
   Begin VB.CommandButton cmdSetProperties 
      Caption         =   "Set &Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   26
      Top             =   120
      Width           =   1815
   End
   Begin VB.ComboBox cboCursorLocation 
      Height          =   360
      Left            =   2040
      TabIndex        =   25
      Top             =   1560
      Width           =   2535
   End
   Begin VB.ComboBox cboAttributes 
      Height          =   360
      Left            =   2040
      TabIndex        =   24
      Top             =   120
      Width           =   2535
   End
   Begin VB.ComboBox cboState 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   23
      Top             =   3360
      Width           =   2535
   End
   Begin VB.ComboBox cboIsolationLevel 
      Height          =   360
      Left            =   2040
      TabIndex        =   22
      Top             =   2640
      Width           =   2535
   End
   Begin VB.ComboBox cboMode 
      Height          =   360
      Left            =   2040
      TabIndex        =   21
      Top             =   3000
      Width           =   2535
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Height          =   375
      Left            =   7440
      TabIndex        =   20
      Top             =   1080
      Width           =   855
   End
   Begin VB.TextBox txtCustomProperty 
      Height          =   375
      Left            =   4800
      TabIndex        =   18
      Top             =   1080
      Width           =   2655
   End
   Begin VB.ListBox lstCustomProperties 
      Height          =   2460
      Left            =   4800
      Sorted          =   -1  'True
      TabIndex        =   17
      Top             =   1560
      Width           =   3495
   End
   Begin VB.TextBox txtVersion 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   16
      Top             =   3720
      Width           =   2535
   End
   Begin VB.TextBox txtProvider 
      Height          =   360
      Left            =   2040
      TabIndex        =   10
      Top             =   2280
      Width           =   2535
   End
   Begin VB.TextBox txtConnectionTimeout 
      Height          =   360
      Left            =   2040
      TabIndex        =   8
      Top             =   1200
      Width           =   2535
   End
   Begin VB.TextBox txtConnectionString 
      Height          =   360
      Left            =   2040
      TabIndex        =   6
      Top             =   840
      Width           =   2535
   End
   Begin VB.TextBox txtDefaultDatabase 
      Height          =   360
      Left            =   2040
      TabIndex        =   4
      Top             =   1920
      Width           =   2535
   End
   Begin VB.TextBox txtCommandTimeout 
      Height          =   360
      Left            =   2040
      TabIndex        =   2
      Top             =   480
      Width           =   2535
   End
   Begin VB.Label lblCustomProperty 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Custom Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   19
      Top             =   720
      Width           =   3495
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Version"
      Height          =   375
      Index           =   10
      Left            =   120
      TabIndex        =   15
      Top             =   3720
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "State"
      Height          =   375
      Index           =   9
      Left            =   120
      TabIndex        =   14
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Mode"
      Height          =   375
      Index           =   8
      Left            =   120
      TabIndex        =   13
      Top             =   3000
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "IsolationLevel"
      Height          =   375
      Index           =   7
      Left            =   120
      TabIndex        =   12
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CursorLocation"
      Height          =   375
      Index           =   6
      Left            =   120
      TabIndex        =   11
      Top             =   1560
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Provider"
      Height          =   375
      Index           =   5
      Left            =   120
      TabIndex        =   9
      Top             =   2280
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ConnectionTimeout"
      Height          =   375
      Index           =   4
      Left            =   120
      TabIndex        =   7
      Top             =   1200
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "ConnectionString"
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   5
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "DefaultDatabase"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   3
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CommandTimeout"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   1
      Top             =   480
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Attributes"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1935
   End
End
Attribute VB_Name = "frmConnection"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public WithEvents cn As ADODB.Connection
Attribute cn.VB_VarHelpID = -1

Private frmErrors As frmErrors

Private Sub cmdShowErrors_Click()
    Set frmErrors = New frmErrors
    Set frmErrors.cn = cn
    frmErrors.Show
End Sub

Private Sub cmdShowRecordset_Click()
    Dim frmRecordset As New frmRecordset
    Set frmRecordset.rs = New ADODB.Recordset
    Set frmRecordset.rs.ActiveConnection = cn
    frmRecordset.Show
End Sub

Private Sub Form_Load()
    If cn Is Nothing Then Set cn = New ADODB.Connection
    InitFields
    ShowProperties
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Not (frmErrors Is Nothing) Then Unload frmErrors
End Sub

Private Sub lstCustomProperties_Click()
    txtCustomProperty.Text = GetCustomPropertyValue(cn, lstCustomProperties)
    cmdSet.Enabled = CustomPropertyIsWriteable(cn, lstCustomProperties)
End Sub

Private Sub cmdSet_Click()
    SetCustomPropertyValue cn, lstCustomProperties, txtCustomProperty.Text
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
    AddToCombo cboAttributes, "adXactAbortRetaining", adXactAbortRetaining
    AddToCombo cboAttributes, "adXactCommitRetaining", adXactCommitRetaining
    
    AddToCombo cboCursorLocation, "adUseServer", adUseServer
    AddToCombo cboCursorLocation, "adUseClient", adUseClient
        
    AddToCombo cboIsolationLevel, "adXactUnspecified", adXactUnspecified
    AddToCombo cboIsolationLevel, "adXactChaos", adXactChaos
    AddToCombo cboIsolationLevel, "adXactReadUncommitted", adXactReadUncommitted
    AddToCombo cboIsolationLevel, "adXactReadCommitted", adXactReadCommitted
    AddToCombo cboIsolationLevel, "adXactRepeatableRead", adXactRepeatableRead
    AddToCombo cboIsolationLevel, "adXactIsolated", adXactIsolated
       
    AddToCombo cboMode, "adModeUnknown", adModeUnknown
    AddToCombo cboMode, "adModeRead", adModeRead
    AddToCombo cboMode, "adModeWrite", adModeWrite
    AddToCombo cboMode, "adModeReadWrite", adModeWrite
    AddToCombo cboMode, "adModeShareDenyRead", adModeShareDenyRead
    AddToCombo cboMode, "adModeShareDenyWrite", adModeShareDenyWrite
    AddToCombo cboMode, "adModeShareExclusive", adModeShareExclusive
    AddToCombo cboMode, "adModeShareDenyNone", adModeShareDenyNone
    
    AddToCombo cboState, "adStateClosed", adStateClosed
    AddToCombo cboState, "adStateOpen", adStateOpen
    AddToCombo cboState, "adStateConnecting", adStateConnecting
    AddToCombo cboState, "adStateExecuting", adStateExecuting
    AddToCombo cboState, "adStateFetching", adStateFetching
End Sub

' Refresh the contents of the property fields.

Sub ShowProperties()
    ShowProperty cn, cboAttributes
    ShowProperty cn, txtCommandTimeout
    ShowProperty cn, txtConnectionString
    ShowProperty cn, txtConnectionTimeout
    ShowProperty cn, cboCursorLocation
    ShowProperty cn, txtDefaultDatabase
    ShowProperty cn, txtProvider
    ShowProperty cn, cboIsolationLevel
    ShowProperty cn, cboMode
    ShowProperty cn, cboState
    ShowProperty cn, txtVersion
    
    ' If you query the Properties collection before opening the connection
    ' you might make it impossible to open the connection later.
    If cn.State And adStateOpen Then
        ShowCustomProperties cn, lstCustomProperties
        cmdSet.Enabled = True
    Else
        txtCustomProperty = ""
        lstCustomProperties.Clear
        cmdSet.Enabled = False
    End If
End Sub

' Assign current values in fields to properties

Sub AssignProperties()
    AssignProperty cn, cboAttributes
    AssignProperty cn, txtCommandTimeout
    AssignProperty cn, txtConnectionString
    AssignProperty cn, txtConnectionTimeout
    AssignProperty cn, cboCursorLocation
    AssignProperty cn, txtDefaultDatabase
    AssignProperty cn, txtProvider
    AssignProperty cn, cboIsolationLevel
    AssignProperty cn, cboMode
End Sub

Private Sub cmdMethod_Click(index As Integer)
    Dim action As String, args(5) As Variant
    Dim returnValue As Variant, retLong As Long
    Dim frmArgs As New frmArguments
    
    On Error GoTo ErrorHandler
    
    AssignProperties
    
    Select Case index
        Case 0
            args(0) = txtConnectionString
            If frmArgs.GetArgValues("Open", args(), "ConnectionString", "@UserID", "@Password", "@Options") Then
                action = "open the connection"
                If IsMissing(args(1)) Then args(1) = ""
                If IsMissing(args(2)) Then args(2) = ""
                If IsMissing(args(3)) Then args(3) = 0
                cn.Open args(0), args(1), args(2), args(3)
            End If
        Case 1
            action = "close the connection"
            cn.Close
        Case 2
            action = "begin the transation"
            returnValue = cn.BeginTrans
        Case 3
            action = "commit the transaction"
            cn.CommitTrans
        Case 4
            action = "rollback the transaction"
            cn.RollbackTrans
        Case 5
            args(1) = 0
            If frmArgs.GetArgValues("Execute", args(), "CommandText", "Options") Then
                action = "execute"
                If MsgBox("Does this method return a recordset?", vbYesNo, "Execute method") = vbNo Then
                    cn.Execute args(0), retLong, args(2)
                Else
                    Dim rs As ADODB.Recordset
                    Set rs = cn.Execute(args(0), retLong, args(1))
                    If Not (rs Is Nothing) Then
                        Dim frm As New frmRecordset
                        Set frm.rs = rs
                        frm.Show , Me
                    End If
                End If
                If retLong Then
                    MsgBox "Records Affected = " & retLong, vbInformation
                End If
            End If
        Case 6
            action = "cancel the command"
            cn.Cancel
    End Select
    
    ShowProperties
    If Not IsEmpty(returnValue) Then
        On Error Resume Next
        MsgBox "Return Value = " & returnValue, vbInformation, cmdMethod(index).Name & " Method"
    End If
    
    Exit Sub
    
ErrorHandler:
    MsgBox "Unable to " & action & vbCr & vbCr _
        & "Error = " & Err.Number & " - " & Err.Description, _
        vbExclamation, "Warning"

End Sub

'------------------------------------
' Event procedures
'------------------------------------

Private Sub cn_BeginTransComplete(ByVal TransactionLevel As Long, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "BeginTransComplete", "TransactionLevel", TransactionLevel
End Sub

Private Sub cn_CommitTransComplete(ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "CommitTransComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_ConnectComplete(ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "ConnectComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_Disconnect(adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "Disconnect", "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_ExecuteComplete(ByVal RecordsAffected As Long, ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "ExecuteComplete", "RecordsAffected", RecordsAffected, "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_InfoMessage(ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "InfoMessage", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_RollbackTransComplete(ByVal pError As ADODB.error, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "RollbackTransComplete", "pError", GetError(pError), "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_WillConnect(ConnectionString As String, UserID As String, Password As String, Options As Long, adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "WillConnect", "ConnectionString", ConnectionString, "UserID", UserID, "Password", Password, "adStatus", GetStatus(adStatus)
End Sub

Private Sub cn_WillExecute(Source As String, CursorType As ADODB.CursorTypeEnum, LockType As ADODB.LockTypeEnum, Options As Long, adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection)
    ShowEvent txtEvents, "WillExecute", "Source", Source, "CursorType", CursorType, "LockType", LockType, "Options", Options, "adStatus", GetStatus(adStatus) ', "Recordset", Recordset
End Sub

