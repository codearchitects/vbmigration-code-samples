VERSION 5.00
Begin VB.Form frmCommand 
   Caption         =   "Command"
   ClientHeight    =   3915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8475
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
   ScaleHeight     =   3915
   ScaleWidth      =   8475
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDefineConnection 
      Caption         =   "Define Connection"
      Height          =   375
      Left            =   120
      TabIndex        =   22
      Top             =   3000
      Width           =   2055
   End
   Begin VB.CommandButton cmdShowRecordset 
      Caption         =   "Show Recordset"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2520
      TabIndex        =   21
      Top             =   3480
      Width           =   2055
   End
   Begin VB.ComboBox cboCommandType 
      Height          =   360
      Left            =   2040
      TabIndex        =   19
      Top             =   840
      Width           =   2535
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "CreateParameter"
      Height          =   375
      Index           =   2
      Left            =   2520
      TabIndex        =   18
      Top             =   2400
      Width           =   2055
   End
   Begin VB.TextBox txtName 
      Height          =   360
      Left            =   2040
      TabIndex        =   16
      Top             =   1200
      Width           =   2535
   End
   Begin VB.CommandButton cmdShowParameters 
      Caption         =   "Show Parameters"
      Height          =   375
      Left            =   2520
      TabIndex        =   15
      Top             =   3000
      Width           =   2055
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Cancel"
      Height          =   375
      Index           =   1
      Left            =   1320
      TabIndex        =   14
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton cmdMethod 
      Caption         =   "Execute"
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   13
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmdSetProperties 
      Caption         =   "Set &Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   12
      Top             =   120
      Width           =   1815
   End
   Begin VB.ComboBox cboState 
      Height          =   360
      Left            =   2040
      Locked          =   -1  'True
      TabIndex        =   11
      Top             =   1920
      Width           =   2535
   End
   Begin VB.ComboBox cboPrepared 
      Height          =   360
      Left            =   2040
      TabIndex        =   10
      Top             =   1560
      Width           =   2535
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Height          =   375
      Left            =   7440
      TabIndex        =   9
      Top             =   1080
      Width           =   855
   End
   Begin VB.TextBox txtCustomProperty 
      Height          =   375
      Left            =   4800
      TabIndex        =   7
      Top             =   1080
      Width           =   2655
   End
   Begin VB.ListBox lstCustomProperties 
      Height          =   2220
      Left            =   4800
      Sorted          =   -1  'True
      TabIndex        =   6
      Top             =   1560
      Width           =   3495
   End
   Begin VB.TextBox txtCommandTimeout 
      Height          =   360
      Left            =   2040
      TabIndex        =   3
      Top             =   480
      Width           =   2535
   End
   Begin VB.TextBox txtCommandText 
      Height          =   360
      Left            =   2040
      TabIndex        =   1
      Top             =   120
      Width           =   2535
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CommadType"
      Height          =   375
      Index           =   2
      Left            =   120
      TabIndex        =   20
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Name"
      Height          =   375
      Index           =   3
      Left            =   120
      TabIndex        =   17
      Top             =   1200
      Width           =   1935
   End
   Begin VB.Label lblCustomProperty 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Custom Properties"
      Height          =   375
      Left            =   4800
      TabIndex        =   8
      Top             =   720
      Width           =   3495
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "State"
      Height          =   375
      Index           =   9
      Left            =   120
      TabIndex        =   5
      Top             =   1920
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Prepared"
      Height          =   375
      Index           =   7
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CommandTimeout"
      Height          =   375
      Index           =   4
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   1935
   End
   Begin VB.Label lblProperty 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      Caption         =   "CommandText"
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1935
   End
End
Attribute VB_Name = "frmCommand"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public cmd As ADODB.Command
Attribute cmd.VB_VarHelpID = -1

Public cn As ADODB.Connection

Private rs As ADODB.Recordset

Private frmParameters As frmParameters

Private Sub cmdShowParameters_Click()
    On Error Resume Next
    Set frmParameters = New frmParameters
    Set frmParameters.Parameters = cmd.Parameters
    frmParameters.Show
End Sub

Private Sub cmdDefineConnection_Click()
    Dim frmConnection As frmConnection
    Set frmConnection = New frmConnection
    Set frmConnection.cn = cn
    frmConnection.Show vbModal
    Set cn = frmConnection.cn
End Sub

Private Sub cmdShowRecordset_Click()
    Dim frmRecordset As New frmRecordset
    Set frmRecordset.rs = rs
    frmRecordset.Show
End Sub

Private Sub Form_Load()
    Set cmd = New ADODB.Command
    InitFields
    ShowProperties
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Not (frmParameters Is Nothing) Then Unload frmParameters
End Sub

Private Sub lstCustomProperties_Click()
    txtCustomProperty.Text = GetCustomPropertyValue(cmd, lstCustomProperties)
    cmdSet.Enabled = CustomPropertyIsWriteable(cmd, lstCustomProperties)
End Sub

Private Sub cmdSet_Click()
    SetCustomPropertyValue cmd, lstCustomProperties, txtCustomProperty.Text
End Sub

Private Sub cmdSetProperties_Click()
    AssignProperties
    ShowProperties
End Sub

' Initialize fields and combo boxes

Private Sub InitFields()
    AddToCombo cboPrepared, "False", False
    AddToCombo cboPrepared, "True", True
    
    AddToCombo cboCommandType, "adCmdText", adCmdText
    AddToCombo cboCommandType, "adCmdTable", adCmdTable
    AddToCombo cboCommandType, "adCmdStoredProc", adCmdStoredProc
    AddToCombo cboCommandType, "adCmdUnknown", adCmdUnknown
    AddToCombo cboCommandType, "adCmdFile", adCmdFile
    AddToCombo cboCommandType, "adCmdTableDirect", adCmdTableDirect
    
    AddToCombo cboState, "adStateClosed", adStateClosed
    AddToCombo cboState, "adStateOpen", adStateOpen
    AddToCombo cboState, "adStateConnecting", adStateConnecting
    AddToCombo cboState, "adStateExecuting", adStateExecuting
    AddToCombo cboState, "adStateFetching", adStateFetching
End Sub

' Refresh the contents of the property fields.

Sub ShowProperties()
    ShowProperty cmd, txtCommandText
    ShowProperty cmd, txtCommandTimeout
    ShowProperty cmd, cboCommandType
    ShowProperty cmd, txtName
    ShowProperty cmd, cboPrepared
    ShowProperty cmd, cboState
    
    cmdShowRecordset.Enabled = Not (rs Is Nothing)
    
    ' If you query the Properties collection before opening the connection
    ' you might make it impossible to open the connection later.
    ShowCustomProperties cmd, lstCustomProperties
    cmdSet.Enabled = True
End Sub

' Assign current values in fields to properties

Sub AssignProperties()
    AssignProperty cmd, txtCommandText
    AssignProperty cmd, txtCommandTimeout
    AssignProperty cmd, cboCommandType
    AssignProperty cmd, txtName
    AssignProperty cmd, cboPrepared
End Sub

Private Sub cmdMethod_Click(Index As Integer)
    Dim action As String, args(5) As Variant
    Dim returnValue As Variant, retLong As Long
    Dim frmArgs As New frmArguments
    
    On Error GoTo ErrorHandler
    
    AssignProperties
    
    ' prepare the ActiveConnection property
    If Not (cn Is Nothing) Then cmd.ActiveConnection = cn
    
    Select Case Index
        Case 0
            action = "execute the command"
            If frmArgs.GetArgValues("Execute", args(), "@Options") Then
                If IsMissing(args(0)) Then args(0) = -1
                Set rs = cmd.Execute(retLong, , args(0))
                If rs Is Nothing Then returnValue = retLong
            End If
        Case 1
            action = "cancel the command"
            cmd.Cancel
        Case 2
            action = "create a new parameter"
            If frmArgs.GetArgValues("CreateParameter", args(), "Name", "Type", "@Direction", "@Size", "@Value") Then
                Dim param As ADODB.Parameter
                Set param = cmd.CreateParameter()
                If Not IsMissing(args(0)) Then param.Name = args(0)
                If Not IsMissing(args(1)) Then param.Type = args(1)
                If Not IsMissing(args(2)) Then param.Direction = args(2)
                If Not IsMissing(args(3)) Then param.Size = args(3)
                If Not IsMissing(args(4)) Then param.value = args(4)
                cmd.Parameters.Append param
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

