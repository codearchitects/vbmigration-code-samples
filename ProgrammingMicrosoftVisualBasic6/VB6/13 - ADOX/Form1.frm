VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "ADO DLL Extensions Demo"
   ClientHeight    =   4545
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7755
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
   ScaleHeight     =   4545
   ScaleWidth      =   7755
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Picture1 
      Height          =   4335
      Left            =   4200
      ScaleHeight     =   4275
      ScaleWidth      =   3315
      TabIndex        =   1
      Top             =   120
      Width           =   3375
   End
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   4335
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3975
      _ExtentX        =   7011
      _ExtentY        =   7646
      _Version        =   393217
      Indentation     =   265
      Style           =   7
      Appearance      =   1
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:DisableMessages CodeAnalysis

'##project:UseByVal Yes

' modify this path to match your directory sistem
Const DB_PATH = "C:\Program Files\Microsoft Visual Studio\VB98\biblio.mdb"

Dim objs() As Object
Dim objCount As Long

Private Sub Form_Load()
    Dim conn As String
    conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DB_PATH
    'conn = "provider=sqloledb;data source=(local);initial catalog=pubs;Integrated Security=True"
    ReDim objs(100) As Object
    RefreshTreeView conn
End Sub

Private Sub Form_Resize()
    TreeView1.Move 0, 0, ScaleWidth / 2, ScaleHeight
    Picture1.Move ScaleWidth / 2, 0, ScaleWidth / 2, ScaleWidth
End Sub

Sub RefreshTreeView(conn As String)

    'On Error GoTo Refresh_Error
    On Error Resume Next

    ' Open the connection.
    Dim cn As New ADODB.Connection
    cn.ConnectionString = conn
    cn.Open
    
    ' Create the Catalog, and link it to the Connection.
    Dim cat As New ADOX.Catalog, catNode As Node
    Dim tbl As ADOX.Table, tblsNode As Node, tblNode As Node
    Dim col As ADOX.Column, colsNode As Node
    Dim ndx As ADOX.Index, ndxsNode As Node, ndxNode As Node
    Dim key As ADOX.key, keysNode As Node, keyNode As Node
    Dim view As ADOX.view, viewsNode As Node, viewNode As Node
    Dim proc As ADOX.Procedure, procsNode As Node, procNode As Node
    Dim grp As ADOX.Group, grpsNode As Node, grpNode As Node
    Dim usr As ADOX.User, usrsNode As Node, usrNode As Node
    Dim cmd As ADODB.Command, cmdNode As Node
    Dim param As ADODB.Parameter, paramsNode As Node, paramNode As Node
    
    ' Add the Catalog node.
    Set cat.ActiveConnection = cn
    
    TreeView1.Nodes.Clear
    Set catNode = AddNode(cat, , "CATALOG")
    catNode.Expanded = True
    
    ' Add all tables
    Set tblsNode = AddNode(cat.Tables, catNode, "TABLES")
    If Err Then GoTo TablesNotSupported
    
    For Each tbl In cat.Tables
        ' Add the table to the treeview.
        Set tblNode = AddNode(tbl, tblsNode)
        
        ' Add the Columns collection.
        Set colsNode = AddNode(tbl.Columns, tblNode, "COLUMNS")
        If Err Then GoTo ColumnsNotSupported
        
        For Each col In tbl.Columns
            AddNode col, colsNode
        Next
        
ColumnsNotSupported:
        Err.Clear
        
        ' Add the Indexes collection.
        Set ndxsNode = AddNode(tbl.Indexes, tblNode, "INDEXES")
        If Err Then GoTo IndexesNotSupported
        
        For Each ndx In tbl.Indexes
            Set ndxNode = AddNode(ndx, ndxsNode)
            
            ' Add the Columns collection for this Index object
            Set colsNode = AddNode(ndx.Columns, ndxNode, "COLUMNS")
            For Each col In ndx.Columns
                AddNode col, colsNode
            Next
        Next
        
IndexesNotSupported:
        Err.Clear
    
        ' Add the Keys collection.
        Set keysNode = AddNode(tbl.Keys, tblNode, "KEYS")
        If Err Then GoTo KeysNotSupported
        
        For Each key In tbl.Keys
            Set keyNode = AddNode(key, keysNode)
            
            ' Add the Columns collection for this Key object
            Set colsNode = AddNode(key.Columns, keyNode, "COLUMNS")
            For Each col In key.Columns
                AddNode col, colsNode
            Next
        Next
        
KeysNotSupported:
        Err.Clear
    Next

TablesNotSupported:
    Err.Clear
    
    ' Add the Views collection.
    Set viewsNode = AddNode(cat.Views, catNode, "VIEWS")
    If Err Then GoTo ViewsNotSupported
    
    For Each view In cat.Views
        Set viewNode = AddNode(view, viewsNode)
        Set cmdNode = AddNode(view.Command, viewNode, "COMMAND")
        If view.Command.Parameters.Count Then
            Set paramsNode = AddNode(view.Command.Parameters, cmdNode, "PARAMETERS")
            For Each param In view.Command.Parameters
                AddNode param, paramsNode
            Next
        End If
    Next
    
ViewsNotSupported:
    Err.Clear
    
    ' Add the Procedures collection.
    Set procsNode = AddNode(cat.Procedures, catNode, "PROCEDURES")
    If Err Then GoTo ProceduresNotSupported
    
    For Each proc In cat.Procedures
        Set procNode = AddNode(proc, procsNode)
        Set cmdNode = AddNode(proc.Command, procNode, "COMMAND")
        If proc.Command.Parameters.Count Then
            Set paramsNode = AddNode(proc.Command.Parameters, cmdNode, "PARAMETERS")
            For Each param In proc.Command.Parameters
                AddNode param, paramsNode
            Next
        End If
    Next
    
ProceduresNotSupported:
    Err.Clear
    
    ' Add the Groups collection.
    Set grpsNode = AddNode(cat.Groups, catNode, "GROUPS")
    If Err Then GoTo GroupsNotSupported
    
    For Each grp In cat.Groups
        Set grpNode = AddNode(grp, grpsNode)
        ' Add the users in each group.
        Set usrsNode = AddNode(grpNode, grp.Users, "USERS")
        For Each usr In grp.Users
            AddNode usr, usrsNode
        Next
    Next
    
GroupsNotSupported:
    Err.Clear
    
    ' Add the Users collection.
    Set usrsNode = AddNode(cat.Groups, catNode, "USERS")
    If Err Then GoTo UsersNotSupported
    
    For Each usr In cat.Users
        Set usrNode = AddNode(usr, usrsNode)
        ' Add the groups for each user.
        Set grpsNode = AddNode(usrNode, usr.Groups, "GROUPS")
        For Each grp In usr.Groups
            AddNode grp, grpsNode
        Next
    Next
    
UsersNotSupported:
    Err.Clear
    
'Refresh_Error:
'    MsgBox "Unable to read schema data" & vbCr & vbCr _
'        & "Error " & Err.Number & " - " & Err.Description, vbExclamation
        

End Sub

Function AddNode(item As Variant, Optional parent As Node, Optional Text As String) As Node
    
    ' Save the object in the objs() arrayù
    If IsObject(item) Then
        objCount = objCount + 1
        If objCount > UBound(objs) Then
            ReDim Preserve objs(objCount + 99) As Object
        End If
        Set objs(objCount) = item
        ' Provide a default for the Text label.
        If Text = "" Then Text = item.Name
    Else
        If Text = "" Then Text = item
    End If
    
    ' Create the Node, stored the array index in its Tag property.
    If parent Is Nothing Then
        Set AddNode = TreeView1.Nodes.Add(, , , Text)
    Else
        Set AddNode = TreeView1.Nodes.Add(parent.Index, tvwChild, , Text)
    End If
    If IsObject(item) Then AddNode.Tag = objCount
End Function

Private Sub TreeView1_NodeClick(ByVal Node As MSComctlLib.Node)
    Dim obj As Object
    Set obj = objs(CLng(Node.Tag))
    
    Picture1.Cls
    
    Select Case TypeName(obj)
        Case "Catalog"
            ShowProperties obj, "ActiveConnection"
        Case "Tables", "Columns", "Indexes", "Keys", "Views", "Procedures", "Users", "Groups", "Parameters"
            ShowProperties obj, "Count"
        Case "Table"
            ShowProperties obj, "DateCreated", "DateModified", "Type"
        Case "Column"
            Picture1.Print "Attribute = " & ColumnAttribute(obj)
            ShowProperties obj, "DefinedSize", "Name", "NumericScale", "Precision", "RelatedColumn", "SortOrder"
            Picture1.Print "Type = " & ColumnType(obj)
        Case "Index"
            ShowProperties obj, "Clustered"
            Picture1.Print "IndexNulls = " & IndexNulls(obj)
            ShowProperties obj, "Name", "PrimaryKey", "Unique"
        Case "Key"
            Picture1.Print "DeleteRule = " & RuleEnum(obj.DeleteRule)
            ShowProperties obj, "Name", "RelatedTable"
            Picture1.Print "Type = " & KeyTypeEnum(obj.Type)
            Picture1.Print "UpdateRule = " & RuleEnum(obj.UpdateRule)
        Case "View", "Procedure"
            ShowProperties obj, "DateCreated", "DateModified", "Name"
        Case "Procedure"
            ShowProperties obj, "DateCreated", "DateModified", "Name"
        Case "Group", "User"
            ShowProperties obj, "Name"
        Case "Command"
            ShowProperties obj, "Name", "CommandText", "CommandTimeout", "Prepared", "State"
            Picture1.Print "CommandType = " & CommandTypeEnum(obj.CommandType)
        Case "Parameter"
            ShowProperties obj, "Name", "Type", "Attributes", "Direction", "NumericScale", "Precision", "Size"
    End Select
End Sub

Sub ShowProperties(obj As Object, ParamArray propNames() As Variant)
    Dim i As Long
    
    On Error Resume Next
    
    For i = LBound(propNames) To UBound(propNames)
        Picture1.Print propNames(i) & " = ";
        Picture1.Print CallByName(obj, propNames(i), VbGet)
        If Err Then
            Picture1.Print "<" & Err.Description & ">"
            Err.Clear
        End If
    Next

End Sub

Function ColumnAttribute(col As ADOX.Column) As String
    Dim result As String
    
    On Error GoTo Error_Handler
    
    If col.Attributes And adColFixed Then
        result = " Or adColFixed"
    End If
    If col.Attributes And adColNullable Then
        result = result & " Or adColNullable"
    End If
    ColumnAttribute = Mid$(result, 5)
    Exit Function
    
Error_Handler:
    ColumnAttribute = "<" & Err.Description & ">"
End Function

Function ColumnType(col As ADOX.Column) As String
    On Error GoTo ColumnType_Error
    Select Case col.Type
        Case adBigInt: ColumnType = "adBigInt"
        Case adBinary: ColumnType = "adBinary"
        Case adBoolean: ColumnType = "adBoolean"
        Case adBSTR: ColumnType = "adBSTR"
        Case adChapter: ColumnType = "adChapter"
        Case adChar: ColumnType = "adChar"
        Case adCurrency: ColumnType = "adCurrency"
        Case adDate: ColumnType = "adDate"
        Case adDBDate: ColumnType = "adDBDate"
        '--## ParseMode Remarks, 1   ' Not necessary
        Case adDBFileTime: ColumnType = "adDBFileTime"
        Case adDBTime: ColumnType = "adDBTime"
        Case adDBTimeStamp: ColumnType = "adDBTimeStamp"
        Case adDecimal: ColumnType = "adDecimal"
        Case adDouble: ColumnType = "adDouble"
        Case adEmpty: ColumnType = "adEmpty"
        Case adError: ColumnType = "adError"
        Case adFileTime: ColumnType = "adFileTime"
        Case adGUID: ColumnType = "adGUID"
        Case adIDispatch: ColumnType = "adIDispatch"
        Case adInteger: ColumnType = "adInteger"
        Case adIUnknown: ColumnType = "adIUnknown"
        Case adLongVarBinary: ColumnType = "adLongVarBinary"
        Case adLongVarChar: ColumnType = "adLongVarChar"
        Case adLongVarWChar: ColumnType = "adLongVarWChar"
        Case adNumeric: ColumnType = "adNumeric"
        Case adPropVariant: ColumnType = "adPropVariant"
        Case adSingle: ColumnType = "adSingle"
        Case adSmallInt: ColumnType = "adSmallInt"
        Case adTinyInt: ColumnType = "adTinyInt"
        Case adUnsignedBigInt: ColumnType = "adUnsignedBigInt"
        Case adUnsignedInt: ColumnType = "adUnsignedInt"
        Case adUnsignedSmallInt: ColumnType = "adUnsignedSmallInt"
        Case adUnsignedTinyInt: ColumnType = "adUnsignedTinyInt"
        Case adUserDefined: ColumnType = "adUserDefined"
        Case adVarBinary: ColumnType = "adVarBinary"
        Case adVarChar: ColumnType = "adVarChar"
        Case adVariant: ColumnType = "adVariant"
        Case adVarNumeric: ColumnType = "adVarNumeric"
        Case adVarWChar: ColumnType = "adVarWChar"
        Case adWChar: ColumnType = "adWChar"
        Case Else: ColumnType = "<unknown>"
    End Select
    Exit Function
    
ColumnType_Error:
    ColumnType = "<" & Err.Description & ">"
End Function

Function IndexNulls(ndx As ADOX.Index) As String
    Dim result As String
    
    If ndx.IndexNulls And adIndexNullsDisallow Then
        result = " Or adIndexNullsDisallow"
    End If
    If ndx.IndexNulls And adIndexNullsIgnore Then
        result = result & " Or adIndexNullsIgnore"
    End If
    If ndx.IndexNulls And adIndexNullsIgnoreAny Then
        result = result & " Or adIndexNullsIgnoreAny"
    End If
    If Len(result) Then
        IndexNulls = Mid$(result, 5)
    Else
        IndexNulls = "adIndexNullsAllow"
    End If
End Function

Function RuleEnum(value As Long) As String
    Select Case value
        Case adRINone: RuleEnum = "adRINone"
        Case adRICascade: RuleEnum = "adRICascade"
        Case adRISetNull: RuleEnum = "adRISetNull"
        Case adRISetDefault: RuleEnum = "adRISetDefault"
        Case Else: RuleEnum = "<unknown>"
    End Select
End Function

Function KeyTypeEnum(value As Long) As String
    Select Case value
        Case adKeyPrimary: KeyTypeEnum = "adKeyPrimary"
        Case adKeyForeign: KeyTypeEnum = "adKeyForeign"
        Case adKeyUnique: KeyTypeEnum = "adKeyUnique"
        Case Else: KeyTypeEnum = "<unknown>"
    End Select
End Function

Function CommandTypeEnum(value As Long) As String
    Select Case value
        Case adCmdFile: CommandTypeEnum = "adCmdFile"
        Case adCmdStoredProc: CommandTypeEnum = "adCmdStoredProc"
        Case adCmdTable: CommandTypeEnum = "adCmdTable"
        Case adCmdTableDirect: CommandTypeEnum = "adCmdTableDirect"
        Case adCmdText: CommandTypeEnum = "adCmdText"
        Case adCmdUnknown: CommandTypeEnum = "adCmdUnknown"
        Case Else: CommandTypeEnum = "<unknown>"
    End Select
End Function


