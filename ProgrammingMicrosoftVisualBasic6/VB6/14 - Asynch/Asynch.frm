VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmData 
   AutoRedraw      =   -1  'True
   Caption         =   "Asynchronous Operations"
   ClientHeight    =   5925
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9405
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
   ScaleHeight     =   5925
   ScaleWidth      =   9405
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command9 
      Caption         =   "Command9"
      Height          =   735
      Left            =   3720
      TabIndex        =   9
      Top             =   5160
      Width           =   1575
   End
   Begin VB.CommandButton Command8 
      Caption         =   "Command8"
      Height          =   735
      Left            =   8280
      TabIndex        =   8
      Top             =   4920
      Width           =   975
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   4455
      Left            =   240
      TabIndex        =   7
      Top             =   240
      Width           =   6495
      _ExtentX        =   11456
      _ExtentY        =   7858
      _Version        =   393216
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   495
      Left            =   1200
      Top             =   5160
      Width           =   1695
      _ExtentX        =   2990
      _ExtentY        =   873
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
      Caption         =   "Adodc1"
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
   Begin VB.CommandButton Command7 
      Caption         =   "Command7"
      Height          =   735
      Left            =   6600
      TabIndex        =   6
      Top             =   4920
      Width           =   1455
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Command6"
      Height          =   495
      Left            =   8640
      TabIndex        =   5
      Top             =   4080
      Width           =   615
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Command5"
      Height          =   615
      Left            =   7080
      TabIndex        =   4
      Top             =   3960
      Width           =   1335
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Command4"
      Height          =   615
      Left            =   7080
      TabIndex        =   3
      Top             =   3000
      Width           =   1215
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Command3"
      Height          =   615
      Left            =   7080
      TabIndex        =   2
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Command2"
      Height          =   615
      Left            =   7080
      TabIndex        =   1
      Top             =   1440
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   7080
      TabIndex        =   0
      Top             =   480
      Width           =   1455
   End
End
Attribute VB_Name = "frmData"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DisableMessage 0501
'##project:DefaultMemberSupport False

Dim WithEvents cn As ADODB.Connection
Attribute cn.VB_VarHelpID = -1
Dim WithEvents rs As ADODB.Recordset
Attribute rs.VB_VarHelpID = -1

Const PATH = "c:\Program Files\Microsoft Visual Studio\vb98\biblio.mdb"

Private Sub Command8_Click()
Dim cn As New ADODB.Connection, rs As New ADODB.Recordset, rsTitles As ADODB.Recordset
cn.Open "Provider=MSDataShape.1;Data Provider=Microsoft.Jet.OLEDB.4.0;" _
    & "Data Source=" + PATH
'Set rs.ActiveConnection = cn


'rs.Open "SHAPE {SELECT * FROM Titles} AS Titles " _
'    & "COMPUTE Titles, COUNT(Titles.Title) AS TitlesCount BY PubID", , adOpenDynamic, adLockOptimistic
    
Dim cmd As New ADODB.Command, source As String


source = "SHAPE {SELECT * FROM Publishers} " _
    & "APPEND ({SELECT * FROM Titles WHERE [Year Published] = 1990} " _
    & "RELATE PubID TO PubID) AS Titles"

source = "SHAPE {SELECT * FROM Titles WHERE [Year Published] = 1990} AS Titles " _
    & "COMPUTE Titles, COUNT(Titles.Title) AS TitlesCount BY PubID"

Set cmd.ActiveConnection = cn
cmd.CommandText = source
Set rs = cmd.Execute()


    
rs.StayInSync = True
    Set rsTitles = rs("Titles").Value

Do Until rs.EOF
    If rs("TitlesCount") > 0 Then
        Debug.Print "PubID=" & rs("PubID")
        'Debug.Print "TitlesCount=" & rs("TitlesCount")
        Do Until rsTitles.EOF
            Debug.Print "  " & rsTitles("Title"), rsTitles("Year Published")
            rsTitles.MoveNext
        Loop
    End If
    rs.MoveNext
Loop
    
 
 
 
'Set MSHFlexGrid1.DataSource = rs

End Sub

Private Sub Command7_Click()

Dim cn As New ADODB.Connection, rs As New ADODB.Recordset
cn.Open "Provider=MSDataShape.1;Data Provider=Microsoft.Jet.OLEDB.4.0;" _
    & "Data Source=" + PATH
rs.Open "SHAPE {SELECT * FROM Publishers}  AS Publishers " _
    & "APPEND ({SELECT * FROM Titles} AS Titles1 " _
    & "RELATE 'PubID' TO 'PubID') AS Titles2", cn
    
Set MSHFlexGrid1.DataSource = rs
End Sub

Private Sub Command1_Click()
    Set rs = cn.Execute("Select * From Publishers", , adAsyncExecute + adAsyncFetch)
    Print "cn.State = " & cn.State
End Sub

Private Sub Command2_Click()
    cn.Execute "UPDATE Publishers SET Pub_Name = 'Lucerne Publishing' WHERE Pub_ID = '9999'", , adAsyncExecute
    Print "cn.State = " & cn.State
End Sub

Private Sub Command3_Click()
    Dim cmd As New ADODB.Command
    
    
    Dim cn2 As New ADODB.Connection
    cn2.Open "Provider=sqloledb;Data source=p2;user id=sa;initial catalog=pubs"
    Set cmd.ActiveConnection = cn2
    
'    cmd.Parameters.Append cmd.CreateParameter("X", adChar, adParamInput, 20)
'    cmd.Parameters("X") = "USA"

    cmd.CommandText = "SELECT * FROM Publishers WHERE country = %xx"

    cmd.Parameters.Append cmd.CreateParameter("%xx", adChar, adParamInput, 20)
    cmd.Parameters("%xx") = "USA"
    Set rs = cmd.Execute()
    
    Do Until rs.EOF
        Print rs("Pub_Name"), rs("Country")
        rs.MoveNext
    Loop
        
    
End Sub

Private Sub Command4_Click()
    Dim cmd As New ADODB.Command, fld As ADODB.Field
    Dim rs As ADODB.Recordset, i As Integer
    Dim cn As New ADODB.Connection
    
    cn.Open "Provider=sqloledb;Data source=p2;user id=sa;initial catalog=pubs"
    
    Set rs = New ADODB.Recordset
    rs.Open "reptq1", cn
    
    Do Until rs Is Nothing
        If rs.State = adStateClosed Then
            Debug.Print "---- Closed Recordset"
        Else
            Do Until rs.EOF
                For Each fld In rs.Fields
                    Debug.Print fld.Name & "="; fld & ", ";
                Next
                Debug.Print
                rs.MoveNext
            Loop
            Debug.Print "---- End of Recordset"
        End If
        Set rs = rs.NextRecordset
    Loop

End Sub

Private Sub Command5_Click()
    rs.CursorLocation = adUseClient
    rs.CacheSize = 20
    'rs.Open "Select * from Publishers", cn, adOpenDynamic, adLockOptimistic, adAsyncFetch
    'rs.Open "Select * from Titles", cn, adOpenStatic, adLockReadOnly, adAsyncFetchNonBlocking
    
    Dim cmd As New ADODB.Command
    cmd.CommandText = "select * from titles"
    cn.CursorLocation = adUseClient
    Set cmd.ActiveConnection = cn
    Set rs = cmd.Execute(, , adAsyncFetchNonBlocking)
    
    
    
'    Print "-------- rs Country"
'    rs("Country") = rs("Country")
'    Print "-------- rs PubName"
'    rs("Pub_Name") = rs("Pub_Name")
'    Print "--------- MoveNext"
'    rs.MoveNext
'    Print "--------"
    
    Print rs(1), rs.EOF
    rs.MoveLast
    Print rs(1), rs.EOF
    
End Sub

Private Sub Command6_Click()
    Cls
    rs.MoveNext
End Sub

Private Sub Command9_Click()
    Dim cmd As ADODB.Command, rs As ADODB.Recordset
    
    DataEnvironment1.Connection1.Open ', "sa", "mypwd"
    
    DataEnvironment1.Authors
    'Set rs = DataEnvironment1.rsAuthors
    
    Set MSHFlexGrid1.DataSource = DataEnvironment1.rsAuthors
    
End Sub

Private Sub Form_Load()
    Set cn = New ADODB.Connection
    Set rs = New ADODB.Recordset
    
    Dim connString As String
    
    connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + PATH
    'connString = "Provider=sqloledb;Data source=p2;user id=sa;initial catalog=pubs"
    cn.Open connString
End Sub

'------------------------------------------------------
' Events
'------------------------------------------------------

Private Sub cn_WillExecute(source As String, CursorType As ADODB.CursorTypeEnum, LockType As ADODB.LockTypeEnum, Options As Long, adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection)
    'Print"WillExecute"
End Sub

Private Sub cn_ExecuteComplete(ByVal RecordsAffected As Long, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pCommand As ADODB.Command, ByVal pRecordset As ADODB.Recordset, ByVal pConnection As ADODB.Connection)
    'Print"ExecuteComplete"
End Sub

Private Sub rs_FetchComplete(ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"FetchComplete"
End Sub

Private Sub rs_FetchProgress(ByVal Progress As Long, ByVal MaxProgress As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"FetchProgress ", Progress, MaxProgress
End Sub

Private Sub rs_FieldChangeComplete(ByVal cFields As Long, ByVal Fields As Variant, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"FieldChangeComplete"
End Sub

Private Sub rs_RecordChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"RecordChangeComplete", adReason
    
End Sub

Private Sub rs_RecordsetChangeComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"RecordsetChangeComplete", adReason
End Sub

Private Sub rs_WillChangeField(ByVal cFields As Long, ByVal Fields As Variant, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"WillChangeField"
End Sub

Private Sub rs_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"WillChangeRecord", adReason
    'adStatus = adStatusCancel
End Sub

Private Sub rs_WillChangeRecordset(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"WillChangeRecordset", adReason
End Sub

Private Sub rs_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"WillMove", adReason
End Sub

Private Sub rs_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
    'Print"MoveComplete", adReason
End Sub




