VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Jet Database Explorer"
   ClientHeight    =   5385
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8865
   LinkTopic       =   "Form1"
   ScaleHeight     =   5385
   ScaleWidth      =   8865
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Left            =   6120
      Top             =   0
   End
   Begin VB.CheckBox chkSystem 
      Caption         =   "&Show System Tables"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1560
      TabIndex        =   2
      Top             =   240
      Width           =   2655
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   4920
      Top             =   240
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   4575
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   4215
      _ExtentX        =   7435
      _ExtentY        =   8070
      _Version        =   393217
      Indentation     =   529
      LineStyle       =   1
      Sorted          =   -1  'True
      Style           =   7
      ImageList       =   "ImageList1"
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton cmdBrowse 
      Caption         =   "&Browse"
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
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   7920
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   32896
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   3
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "BrowMdb.frx":0000
            Key             =   "Database"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "BrowMdb.frx":0872
            Key             =   "Table"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "BrowMdb.frx":10E4
            Key             =   "FieldOld"
         EndProperty
      EndProperty
   End
   Begin VB.Label lblData 
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   4575
      Left            =   4560
      TabIndex        =   3
      Top             =   600
      Width           =   4095
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False

Option Explicit

Private Sub chkSystem_Click()
    If TreeView1.Nodes.Count > 1 Then
        ' the control already contains something
        ShowDatabaseStructure TreeView1.Nodes(1).Text, TreeView1, chkSystem
    End If
End Sub

Private Sub cmdBrowse_Click()
    On Error Resume Next
    With CommonDialog1
        .CancelError = True
        .Filter = "All files|*.*|Jet Databases (*.mdb)|*.mdb"
        .FilterIndex = 2
        .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
        .ShowOpen
        If Err = 0 Then
            ShowDatabaseStructure .FileName, TreeView1, chkSystem
            If Err Then
                MsgBox "Unable to read database structure" & vbCr & "Error: " & Err.Description, vbExclamation
            End If
        End If
    End With
End Sub

Sub ShowDatabaseStructure(MdbFile As String, TV As TreeView, ShowSystemTables As Boolean)
'##ShowSystemTables.UseByVal Force
    Dim db As DAO.Database, td As DAO.TableDef, fld As DAO.Field
    Dim nd As Node, nd2 As Node

    ' clear the current contents of the TreeView control
    TV.Nodes.Clear
    ' open the database
    Set db = DAO.DBEngine.OpenDatabase(MdbFile)
    'Set db = DBEngine.OpenDatabase(MdbFile)
    'Set db = OpenDatabase '(MdbFile)
        
    ' add the root node, then expand it to show the tables
    Set nd = TV.Nodes.Add(, , "Root", db.Name, "Database")
    nd.Tag = DatabaseInfo(db)
    nd.Expanded = True
    
    ' explore all the tables in the database
    For Each td In db.TableDefs
        ' discard system tables, if user isn't interested in them
        If (td.Attributes And dbSystemObject) = 0 Or ShowSystemTables Then
            ' add the table under the Root object
            Set nd = TV.Nodes.Add("Root", tvwChild, , td.Name, "Table")
            nd.Tag = TableDefInfo(td)
            ' now add all the fields
            For Each fld In td.Fields
                Set nd2 = TV.Nodes.Add(nd.Index, tvwChild, , fld.Name, "Field")
                nd2.Tag = FieldInfo(fld)
            Next
        End If
    Next
    db.Close
End Sub

Function DatabaseInfo(db As Database) As String
    ' return textual information about a Database object
    Dim res As String
    res = res & "Name = " & db.Name & vbCrLf
    res = res & "Version = " & db.Version & vbCrLf
    res = res & "Updatable = " & db.Updatable & vbCrLf
    res = res & "Connect = " & db.Connect & vbCrLf
    DatabaseInfo = res
End Function

Function TableDefInfo(td As TableDef) As String
    ' return textual information about a TableDef object
    Dim res As String
    res = res & "Name = " & td.Name & vbCrLf
    res = res & "DateCreated = " & td.DateCreated & vbCrLf
    res = res & "LastUpdated = " & td.LastUpdated & vbCrLf
    res = res & "RecordCount = " & td.RecordCount & vbCrLf
    res = res & "Updatable = " & td.Updatable & vbCrLf
    TableDefInfo = res
End Function

Function FieldInfo(fld As Field) As String
    ' return textual information about a Field object
    Dim res As String
    res = res & "Name = " & fld.Name & vbCrLf
    res = res & "Type = " & FieldTypeDesc(fld.Type) & vbCrLf
    res = res & "Size = " & fld.Size & vbCrLf
    res = res & "Required = " & fld.Required & vbCrLf
    res = res & "AllowZeroLength = " & fld.AllowZeroLength & vbCrLf
    res = res & "OrdinalPosition = " & fld.OrdinalPosition & vbCrLf
    res = res & "AutoIncrField  = " & CBool(fld.Attributes And dbAutoIncrField) & vbCrLf
    FieldInfo = res
End Function

Function FieldTypeDesc(ByVal value As DataTypeEnum) As String
    Select Case value
        Case dbBigInt: FieldTypeDesc = "dbBigInt"
        Case dbBinary: FieldTypeDesc = "dbBinary"
        Case dbBoolean: FieldTypeDesc = "dbBoolean"
        Case dbByte: FieldTypeDesc = "dbByte"
        Case dbChar: FieldTypeDesc = "dbChar"
        Case dbCurrency: FieldTypeDesc = "dbCurrency"
        Case dbDate: FieldTypeDesc = "dbDate"
        Case dbDecimal: FieldTypeDesc = "dbDecimal"
        Case dbDouble: FieldTypeDesc = "dbDouble"
        Case dbInteger: FieldTypeDesc = "dbInteger"
        Case dbGUID: FieldTypeDesc = "dbGUID"
        Case dbLong: FieldTypeDesc = "dbLong"
        Case dbLongBinary: FieldTypeDesc = "dbLongBinary"
        Case dbMemo: FieldTypeDesc = "dbMemo"
        Case dbNumeric: FieldTypeDesc = "dbNumeric"
        Case dbSingle: FieldTypeDesc = "dbSingle"
        Case dbText: FieldTypeDesc = "dbText"
        Case dbTime: FieldTypeDesc = "dbTime"
        Case dbTimeStamp: FieldTypeDesc = "dbTimeStamp"
        Case dbVarBinary: FieldTypeDesc = "dbVarBinary"
        Case Else: FieldTypeDesc = "(unknown)"
    End Select
        
End Function

Private Sub TreeView1_NodeClick(ByVal Node As MSComctlLib.Node)
    ' info() is an array of strings that hold nodes' data
    lblData.Caption = Node.Tag
End Sub






