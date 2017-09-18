VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmSQLServerDocumenter 
   Caption         =   "SQL Server Documenter"
   ClientHeight    =   6795
   ClientLeft      =   3180
   ClientTop       =   2835
   ClientWidth     =   9795
   Icon            =   "frmSQLServerDocumenter.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6795
   ScaleWidth      =   9795
   Begin VB.Frame fmeAbout 
      Caption         =   "About"
      Height          =   675
      Left            =   3480
      TabIndex        =   21
      Top             =   6060
      Width           =   6255
      Begin MSComDlg.CommonDialog dlgExport 
         Left            =   5580
         Top             =   60
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.Label lblAbout 
         Alignment       =   2  'Center
         Caption         =   "Coding by RaiVeN for Da Londo Software"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   315
         Left            =   120
         TabIndex        =   22
         Top             =   240
         Width           =   6015
      End
   End
   Begin VB.Frame fmeExport 
      Caption         =   "Print/Export"
      Height          =   675
      Left            =   60
      TabIndex        =   16
      Top             =   6060
      Width           =   3375
      Begin VB.CommandButton cmdPreviewPrint 
         Caption         =   "Print Preview"
         Height          =   315
         Left            =   120
         TabIndex        =   20
         Top             =   240
         Width           =   1515
      End
      Begin VB.CommandButton cmdExport2XLS 
         Caption         =   "Export To Excel"
         Height          =   315
         Left            =   1740
         TabIndex        =   19
         Top             =   240
         Width           =   1515
      End
   End
   Begin MSComctlLib.ListView lsvTableData 
      Height          =   3975
      Left            =   60
      TabIndex        =   15
      Top             =   2040
      Width           =   9675
      _ExtentX        =   17066
      _ExtentY        =   7011
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   0
   End
   Begin VB.Frame fmeDatabaseTable 
      Caption         =   "Select Database / Table"
      Height          =   1995
      Left            =   4800
      TabIndex        =   1
      Top             =   0
      Width           =   4935
      Begin VB.CommandButton cmdShowIndexes 
         Caption         =   "Show Indexes"
         Height          =   315
         Left            =   3300
         TabIndex        =   24
         Top             =   1560
         Width           =   1515
      End
      Begin VB.CommandButton cmdShowTable 
         Caption         =   "Show Table"
         Height          =   315
         Left            =   1680
         TabIndex        =   14
         Top             =   1560
         Width           =   1515
      End
      Begin VB.ComboBox cboTableName 
         Height          =   315
         Left            =   120
         TabIndex        =   11
         Top             =   1140
         Width           =   4695
      End
      Begin VB.ComboBox cboDatabaseName 
         Height          =   315
         Left            =   120
         TabIndex        =   10
         Top             =   480
         Width           =   4695
      End
      Begin VB.Label lblTable 
         Caption         =   "Table"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   900
         Width           =   2475
      End
      Begin VB.Label lblDatabase 
         Caption         =   "Database"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   1995
      End
   End
   Begin VB.Frame fmeConnection 
      Caption         =   "Connection"
      Height          =   1995
      Left            =   60
      TabIndex        =   0
      Top             =   0
      Width           =   4695
      Begin MSComctlLib.ImageList imlConnectionStatus 
         Left            =   2100
         Top             =   1320
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   16
         ImageHeight     =   16
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   5
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmSQLServerDocumenter.frx":0A02
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmSQLServerDocumenter.frx":0AA1
               Key             =   ""
            EndProperty
            BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmSQLServerDocumenter.frx":0B4D
               Key             =   ""
            EndProperty
            BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmSQLServerDocumenter.frx":0BEC
               Key             =   ""
            EndProperty
            BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "frmSQLServerDocumenter.frx":0C96
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin VB.PictureBox picConnectionStatus 
         Appearance      =   0  'Flat
         BorderStyle     =   0  'None
         ForeColor       =   &H80000008&
         Height          =   315
         Left            =   180
         ScaleHeight     =   315
         ScaleWidth      =   315
         TabIndex        =   23
         Top             =   1620
         Width           =   315
      End
      Begin VB.ComboBox cboSQLServerList 
         Height          =   315
         Left            =   120
         TabIndex        =   17
         Top             =   480
         Width           =   2235
      End
      Begin VB.CommandButton cmdConnect 
         Caption         =   "Connect"
         Height          =   315
         Left            =   3060
         Picture         =   "frmSQLServerDocumenter.frx":0D37
         TabIndex        =   9
         Top             =   1560
         Width           =   1515
      End
      Begin VB.OptionButton optSQLAuth 
         Caption         =   "SQL Authentication"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   1200
         Width           =   2295
      End
      Begin VB.OptionButton optWinAuth 
         Caption         =   "Windows Authentication"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   900
         Value           =   -1  'True
         Width           =   2235
      End
      Begin VB.TextBox txtPassword 
         Height          =   315
         IMEMode         =   3  'DISABLE
         Left            =   2700
         PasswordChar    =   "*"
         TabIndex        =   6
         Top             =   1140
         Width           =   1875
      End
      Begin VB.TextBox txtUserName 
         Height          =   315
         Left            =   2700
         TabIndex        =   3
         Top             =   480
         Width           =   1875
      End
      Begin VB.Label lblStatus 
         Caption         =   "Not Connected"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   480
         TabIndex        =   18
         Top             =   1620
         Width           =   2535
      End
      Begin VB.Label lblPassword 
         Caption         =   "Password"
         Height          =   255
         Left            =   2700
         TabIndex        =   5
         Top             =   900
         Width           =   1875
      End
      Begin VB.Label lblUserName 
         Caption         =   "Username"
         Height          =   255
         Left            =   2700
         TabIndex        =   4
         Top             =   240
         Width           =   1395
      End
      Begin VB.Label lblServerName 
         Caption         =   "Servername"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   240
         Width           =   1635
      End
   End
End
Attribute VB_Name = "frmSQLServerDocumenter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' ##########################################
'
' SQL Server Documenter
'
' Coded by RaiVeN for Da Londo Software
' http://users.dalondo.2y.net/RaiVeN/
'
' This program may be used freely as long as you
' keep a reference to me in it. Thnx! RaiVeN
'
' ##########################################

Option Explicit

Private Declare Function SetCapture Lib "user32" (ByVal hwnd As Long) As Long
Private Declare Function ReleaseCapture Lib "user32" () As Long
Private Declare Function GetCapture Lib "user32" () As Long
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Private Const SW_NORMAL = 1

Private Sub cboDatabaseName_Click()

Dim errhandle       As Label

' Fills the table combo with all user tables in the database

On Error GoTo errhandle

frmSQLServerDocumenter.MousePointer = 11
Fill_cboTableName
frmSQLServerDocumenter.MousePointer = 0
Exit Sub

errhandle:
    frmSQLServerDocumenter.MousePointer = 0
    MsgBox "An error occurred:" & vbCrLf & Err.Description & vbCrLf & Err.Number, vbCritical, "Error"
    
End Sub

Private Sub cmdConnect_Click()

Dim errhandle                   As Label

On Error GoTo errhandle

' Connects to or disconnects from the database server, either using SQL or NT/2000 authentication.
' Also controls the (de)activation of the username and password textboxes

If cboSQLServerList.ListIndex < 1 Then
    MsgBox "Select a server", vbCritical, "Error"
    Exit Sub
End If

Select Case cmdConnect.Caption
    Case "Connect"
        lblStatus.Caption = "Connecting..."
        picConnectionStatus.Picture = imlConnectionStatus.ListImages(2).Picture
        lblStatus.Refresh
        If optSQLAuth.Value = True Then
            Set objSQLServer = New SQLDMO.SQLServer
            objSQLServer.Connect cboSQLServerList.Text, txtUserName.Text, txtPassword.Text
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        ElseIf optWinAuth.Value = True Then
            Set objSQLServer = New SQLDMO.SQLServer
            objSQLServer.LoginSecure = True
            objSQLServer.Connect cboSQLServerList.Text
        End If
        cmdConnect.Caption = "Disconnect"
        blnConnectionState = True
        Fill_cboDatabaseName
        cboSQLServerList.Enabled = False
        optSQLAuth.Enabled = False
        optWinAuth.Enabled = False
        lblStatus.Caption = "Connected"
        picConnectionStatus.Picture = imlConnectionStatus.ListImages(1).Picture
    Case "Disconnect"
        lblStatus.Caption = "Disconnecting..."
        picConnectionStatus.Picture = imlConnectionStatus.ListImages(4).Picture
        lblStatus.Refresh
        objSQLServer.DisConnect
        Set objSQLServer = Nothing
        cmdConnect.Caption = "Connect"
        blnConnectionState = False
        cboSQLServerList.Enabled = True
        If optSQLAuth.Value = True Then
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        End If
        optSQLAuth.Enabled = True
        optWinAuth.Enabled = True
        cboDatabaseName.Clear
        cboTableName.Clear
        lsvTableData.ListItems.Clear
        lblStatus.Caption = "Not Connected"
        picConnectionStatus.Picture = imlConnectionStatus.ListImages(3).Picture
End Select


Exit Sub
errhandle:
    lblStatus.Caption = "Connection Failed"
    picConnectionStatus.Picture = imlConnectionStatus.ListImages(5).Picture
    MsgBox Err.Description & vbCrLf & Err.Number, vbCritical, "Error"

End Sub

Private Sub cmdExport2XLS_Click()

Dim errhandle           As Label

On Error GoTo errhandle

' Opens a dialog box and calls the "Exort2XLS" sub in modMain

If cboTableName.Text = "" Then
    MsgBox "Select a table", vbCritical, "Error"
    Exit Sub
End If

Me.MousePointer = 11
dlgExport.DialogTitle = "Export Excel File"
dlgExport.DefaultExt = ".xls"
dlgExport.Filter = "Excel Workbook|*.xls"
dlgExport.ShowSave

If dlgExport.FileName = "" Then
    Exit Sub
End If

Export2XLS cboTableName.Text, dlgExport.FileName, cboSQLServerList.Text, cboDatabaseName.Text

Me.MousePointer = 0
Exit Sub
errhandle:
    Me.MousePointer = 0
    MsgBox Err.Description & vbCrLf & Err.Number, vbCritical, "Error"

End Sub

Private Sub cmdPreviewPrint_Click()

Dim errhandle           As Label

On Error GoTo errhandle

' Writes the and HTML file to disk in the application path called "TMPPRT.DAT"
' and opens it in the browser control on the frmPrintPreview form

If cboTableName.Text = "" Then
    MsgBox "Select a table", vbCritical, "Error"
    Exit Sub
End If

PrintPreview cboTableName.Text, cboDatabaseName.Text, cboSQLServerList.Text

frmPrintPreview.Show 1

Exit Sub
errhandle:
    MsgBox Err.Description & vbCrLf & Err.Number, vbCritical, "Error"

End Sub

Private Sub cmdShowIndexes_Click()

Dim errhandle           As Label

On Error GoTo errhandle

' Formats the listview for indexes and lists all indexes in the table in the listview

blnShowTable = False

If cboTableName.ListIndex < 1 Then
    MsgBox "Please select a table", vbCritical, "Error"
    Exit Sub
End If

frmSQLServerDocumenter.MousePointer = 11
Format_lsvIndex
Fill_lsvIndex
frmSQLServerDocumenter.MousePointer = 0

Exit Sub
errhandle:
    frmSQLServerDocumenter.MousePointer = 0
    MsgBox Err.Description & vbCrLf & Err.Number, vbCritical, "Error"

End Sub

Private Sub cmdShowTable_Click()

Dim errhandle           As Label

On Error GoTo errhandle

' Formats the listview for fields and lists all fields in the table in the listview

blnShowTable = True

If cboTableName.ListIndex < 1 Then
    MsgBox "Please select a table", vbCritical, "Error"
    Exit Sub
End If

frmSQLServerDocumenter.MousePointer = 11
Format_lsvTable
Fill_lsvTable
frmSQLServerDocumenter.MousePointer = 0

Exit Sub
errhandle:
    frmSQLServerDocumenter.MousePointer = 0
    MsgBox Err.Description & vbCrLf & Err.Number, vbCritical, "Error"

End Sub

Private Sub fmeAbout_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)

' Animates the blue "web link" in the lower right hand side of the form
' Snippet taken (and modified) from http://www.planet-source-code.com

If X > 0 And X < fmeAbout.Width And Y > 0 And Y < fmeAbout.Height Then
    If GetCapture <> fmeAbout.hwnd Then
        lblAbout.ForeColor = vbBlue
        lblAbout.FontUnderline = True
        SetCapture fmeAbout.hwnd
    End If
Else
    lblAbout.ForeColor = vbBlack
    lblAbout.FontUnderline = False
    ReleaseCapture
End If
   
End Sub

Private Sub Form_Load()

' Launches the splash form and sets initial parameters.

frmSplash.Show
DoEvents
Me.Caption = "SQL Server Documenter v" & App.Major & "." & App.Minor & "." & App.Revision
Center Me
frmSplash.lblStatus.Caption = "Initializing environment"
frmSplash.lblStatus.Refresh
InitArray
txtUserName.Enabled = False
txtPassword.Enabled = False
txtUserName.BackColor = &H8000000F
txtPassword.BackColor = &H8000000F
frmSplash.lblStatus.Caption = "Scanning for SQL Servers on network"
frmSplash.lblStatus.Refresh
Fill_cboSQLServerList
blnConnectionState = False
picConnectionStatus.Picture = imlConnectionStatus.ListImages(3).Picture
Unload frmSplash

End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)

' Check if the application is disconnected. If not disconnect before closing

If blnConnectionState = True Then
    cmdConnect_Click
    Set objSQLServer = Nothing
End If

End Sub

Private Sub Form_Resize()

' Keep the form's current measurements when trying to resize

If Me.WindowState <> 1 Then
    Me.Width = 9945
    Me.Height = 7200
End If

End Sub

Private Sub lblAbout_Click()

' Open Da Londo website when clicking the "web link"

ShellExecute Me.hwnd, "open", "http://www.dalondo.2y.net/", vbNullString, vbNullString, SW_NORMAL

End Sub

Private Sub optSQLAuth_Click()

txtUserName.Enabled = True
txtPassword.Enabled = True
txtUserName.BackColor = &H80000005
txtPassword.BackColor = &H80000005
txtUserName.SetFocus

End Sub

Private Sub optWinAuth_Click()

txtUserName.Enabled = False
txtPassword.Enabled = False
txtUserName.BackColor = &H8000000F
txtPassword.BackColor = &H8000000F
txtUserName.Text = ""
txtPassword.Text = ""

End Sub

Sub Fill_cboSQLServerList()

Dim ServerList      As SQLDMO.NameList
Dim SQLApp          As SQLDMO.Application
Dim lngCounter      As Long

' Scan the network for SQL Servers and list them in the combo

Set SQLApp = New SQLDMO.Application
Set ServerList = SQLApp.ListAvailableSQLServers

cboSQLServerList.AddItem ""
cboSQLServerList.ItemData(cboSQLServerList.NewIndex) = 0

For lngCounter = 1 To ServerList.Count
    cboSQLServerList.AddItem ServerList.Item(lngCounter)
    cboSQLServerList.ItemData(cboSQLServerList.NewIndex) = lngCounter
Next

End Sub

Sub Fill_cboDatabaseName()

Dim lngCounter              As Long

' once connected to a server, show all user databases

cboDatabaseName.Clear

cboDatabaseName.AddItem ""
cboDatabaseName.ItemData(cboDatabaseName.NewIndex) = 0

For Each objDatabase In objSQLServer.Databases
    If (Not objDatabase.SystemObject = True) Then
        cboDatabaseName.AddItem objDatabase.Name
        cboDatabaseName.ItemData(cboDatabaseName.NewIndex) = lngCounter
        lngCounter = lngCounter + 1
    End If
Next

End Sub

Sub Fill_cboTableName()

Dim lngCounter              As Long

' When a database has been selected, show all user tables in the database

If cboDatabaseName.ListIndex < 1 Then
    MsgBox "Please select a database", vbCritical, "Error"
    Exit Sub
End If

Set objTable = New SQLDMO.Table
Set objDatabase = objSQLServer.Databases(cboDatabaseName.Text)
cboTableName.Clear

cboTableName.AddItem ""
cboTableName.ItemData(cboTableName.NewIndex) = 0

For Each objTable In objDatabase.Tables
    If Not objTable.SystemObject = True Then
        cboTableName.AddItem objTable.Name
        cboTableName.ItemData(cboTableName.NewIndex) = lngCounter
        lngCounter = lngCounter + 1
    End If
Next

End Sub

Sub Format_lsvTable()

Dim itmX                As ColumnHeader

' Format the listview for showing fields

lsvTableData.ColumnHeaders.Clear

Set itmX = lsvTableData.ColumnHeaders.Add(, , "Column Name", 2500)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Data Type", 2500)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Length", 1000)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Allow NULL", 1500)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Ident", 1000)

lsvTableData.View = lvwReport

End Sub

Sub Format_lsvIndex()

Dim itmX                As ColumnHeader

' Format the listview for showing indexes

lsvTableData.ColumnHeaders.Clear

Set itmX = lsvTableData.ColumnHeaders.Add(, , "Index Name", 2000)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Index Type", 3000)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "Indexed Fields", 3700)
Set itmX = lsvTableData.ColumnHeaders.Add(, , "% Fill", 600, vbCenter)

lsvTableData.View = lvwReport

End Sub

Sub Fill_lsvTable()

Dim lngCounter          As Long
Dim itmY                As ListItem
Dim objIndex            As SQLDMO.Index
Dim objTable            As SQLDMO.Table

' Fill the listview with all fields in the selected database

lsvTableData.ListItems.Clear

Set objColumn = New SQLDMO.Column
Set objTable = objDatabase.Tables(cboTableName.Text)

For Each objColumn In objTable.Columns
    Set itmY = lsvTableData.ListItems.Add(, "U" & lngCounter, objColumn.Name)
        itmY.SubItems(1) = objColumn.Datatype
        itmY.SubItems(2) = objColumn.Length
        itmY.SubItems(3) = objColumn.AllowNulls
        itmY.SubItems(4) = objColumn.Identity
    lngCounter = lngCounter + 1
Next

End Sub

Sub Fill_lsvIndex()

Dim lngCounter          As Long
Dim itmY                As ListItem
Dim objIndex            As SQLDMO.Index
Dim objTable            As SQLDMO.Table
Dim objColumn           As SQLDMO.Column
Dim strIndexedFields    As String
Dim intCount            As Integer

' Fill the listview with all indexes in the selected database

lsvTableData.ListItems.Clear

Set objIndex = New SQLDMO.Index
Set objTable = objDatabase.Tables(cboTableName.Text)

For Each objIndex In objTable.Indexes
    If Left(objIndex.Name, 8) <> "_WA_Sys_" And Left(objIndex.Name, 5) <> "hind_" Then
        Set itmY = lsvTableData.ListItems.Add(, "U" & lngCounter, objIndex.Name)
            itmY.SubItems(1) = DecodeIDXType(objIndex.Type)
            For intCount = 1 To objIndex.ListIndexedColumns.Count
                Set objColumn = objIndex.ListIndexedColumns.Item(intCount)
                strIndexedFields = strIndexedFields & objColumn.Name & ", "
            Next
            itmY.SubItems(2) = Left(strIndexedFields, Len(strIndexedFields) - 2)
            itmY.SubItems(3) = objIndex.FillFactor
        lngCounter = lngCounter + 1
    End If
    strIndexedFields = ""
Next

End Sub
