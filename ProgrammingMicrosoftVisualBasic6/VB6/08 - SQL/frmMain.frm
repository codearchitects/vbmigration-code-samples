VERSION 5.00
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmMain 
   Caption         =   "SQL Training"
   ClientHeight    =   4290
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7590
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
   ScaleHeight     =   4290
   ScaleWidth      =   7590
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdConnection 
      Caption         =   "&New Conn"
      Height          =   375
      Left            =   6360
      TabIndex        =   6
      Top             =   0
      Width           =   1095
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">"
      Height          =   375
      Index           =   1
      Left            =   6960
      TabIndex        =   5
      Top             =   1320
      Width           =   495
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   "<"
      Height          =   375
      Index           =   0
      Left            =   6360
      TabIndex        =   4
      Top             =   1320
      Width           =   495
   End
   Begin VB.CommandButton cmdRun 
      Caption         =   "&Run"
      Default         =   -1  'True
      Height          =   375
      Left            =   6360
      TabIndex        =   3
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton cmdClear 
      Cancel          =   -1  'True
      Caption         =   "&Clear"
      Height          =   375
      Left            =   6360
      TabIndex        =   2
      Top             =   480
      Width           =   1095
   End
   Begin MSDataGridLib.DataGrid DataGrid1 
      Height          =   2295
      Left            =   0
      TabIndex        =   1
      Top             =   1800
      Width           =   7455
      _ExtentX        =   13150
      _ExtentY        =   4048
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
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
   Begin VB.TextBox txtSQL 
      Height          =   1695
      Left            =   0
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Top             =   0
      Width           =   6255
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' Modify next constant to match your directory system.
Const DB_PATH = "c:\Program Files\Microsoft Visual Studio\vb98\biblio.mdb"

Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset
Dim connString As String

Dim sql() As String
Dim sqlIndex As Long
Dim sqlMax As Long

Private Sub cmdClear_Click()
    txtSQL.SetFocus
    txtSQL = ""
End Sub

Function Getobject(ByVal s As String) As Object
    ' do nothing
End Function

Private Sub cmdConnection_Click()
    Dim conn As String, cn2 As New ADODB.Connection
    Dim dlink As New MSDASC.DataLinks
    
    ' Make the dialog modal respect to this form
    dlink.hWnd = Me.hWnd
    ' show the Data Link Properties dialog
    On Error Resume Next
    
    '##ReplaceStatement conn = dlink.PromptNew.ConnectionString
    conn = dlink.PromptNew
    ' exit if user clicked the Cancel key
    If Err Then Exit Sub
    
    'conn = InputBox("Enter new connection string", , connString)
    'If conn = "" Or conn = connString Then Exit Sub
    
    ' try to open the new connection
    On Error GoTo Error_Handler
    cn2.ConnectionString = conn
    cn2.Open
    ' if no error, close the old connection and swap variables
    cn.RollbackTrans
    cn.Close
    ' use the right connection object
    Set cn = cn2
    cn.BeginTrans
    ' remember the new connection string.
    connString = conn
    Exit Sub

Error_Handler:
    MsgBox "Error " & Err.Number & vbCr & vbCr & Err.Description, vbCritical, "ERROR"
    
End Sub

Private Sub cmdMove_Click(Index As Integer)
    If Index = 0 Then
        If sqlIndex = 1 Then Beep: Exit Sub
        sqlIndex = sqlIndex - 1
    Else
        If sqlIndex = sqlMax Then Beep: Exit Sub
        sqlIndex = sqlIndex + 1
    End If
    
    txtSQL.Text = sql(sqlIndex)
    

    
End Sub

Private Sub cmdRun_Click()
    On Error GoTo Error_Handler
    If rs.State And adStateOpen Then rs.Close
    
    txtSQL.SetFocus
    
    If InStr(1, txtSQL, "select", vbTextCompare) = 1 Then
        rs.Open txtSQL.Text, cn, adOpenStatic, adLockReadOnly
        Set DataGrid1.DataSource = rs
    Else
        cn.Execute txtSQL.Text
    End If
    
    sqlMax = sqlMax + 1
    If sqlMax > UBound(sql) Then
        ReDim Preserve sql(sqlMax + 999) As String
    End If
    sql(sqlMax) = txtSQL.Text
    sqlIndex = sqlMax
    
    Exit Sub
    
Error_Handler:
    MsgBox "Error " & Err.Number & vbCr & vbCr & Err.Description, vbCritical, "ERROR"
    
End Sub

Private Sub Form_Load()
    ' Initialize the connection string.
    connString = "Provider=Microsoft.Jet.OLEDB.3.51; Data Source=" & DB_PATH
    cn.ConnectionString = connString
    ' Open the connection and start a transaction.
    
    cn.Open
    cn.CursorLocation = adUseClient
    cn.BeginTrans
    ' 10,000 different queries per session should be enough.
    ReDim sql(10000) As String
End Sub

Private Sub Form_Resize()
    On Error Resume Next
    cmdConnection.Left = ScaleWidth - cmdConnection.Width - 100
    cmdClear.Left = cmdConnection.Left
    cmdRun.Left = cmdClear.Left
    cmdMove(0).Left = cmdClear.Left
    cmdMove(1).Left = cmdClear.Left + cmdClear.Width - cmdMove(1).Width
    txtSQL.Width = cmdClear.Left - 100
    DataGrid1.Move 0, DataGrid1.Top, ScaleWidth - 100, ScaleHeight - DataGrid1.Top
End Sub

Private Sub Form_Unload(Cancel As Integer)
    cn.RollbackTrans
End Sub
