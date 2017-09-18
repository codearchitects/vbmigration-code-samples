VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmDirBrowser 
   Caption         =   "Publishers Browser"
   ClientHeight    =   4875
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5055
   LinkTopic       =   "Form2"
   ScaleHeight     =   4875
   ScaleWidth      =   5055
   StartUpPosition =   3  'Windows Default
   Begin ComctlLib.TreeView tvwPublishers 
      Height          =   2775
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   4695
      _ExtentX        =   8281
      _ExtentY        =   4895
      _Version        =   327682
      HideSelection   =   0   'False
      Indentation     =   529
      LabelEdit       =   1
      Sorted          =   -1  'True
      Style           =   7
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
End
Attribute VB_Name = "frmDirBrowser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' WARNING: you may need to modify the DB path in the next line
Const MDBPATH = "C:\Program Files\Microsoft Visual Studio\VB98\Biblio.mdb"

Dim cn As New ADODB.Connection
Dim rs As New ADODB.Recordset

Private Sub Form_Load()
    ' Show the database.
    On Error Resume Next
    cn.Open "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & MDBPATH
    If Err Then
        MsgBox "Unable to database " & MDBPATH, vbCritical
        End
    End If
    DatabaseRefresh
End Sub

Private Sub Form_Resize()
    tvwPublishers.Move 0, 9, ScaleWidth, ScaleHeight
End Sub

Private Sub DatabaseRefresh()
    On Error Resume Next
    
    ' Open the Authors recordset.
    rs.Open "Publishers", cn, adOpenForwardOnly, adLockReadOnly
    If Err Then
        MsgBox "Unable to open Publishers table", vbCritical
        End
    End If
    
    ' Build the treeview control.
    Dim rootNode As node, nd As node
    
    ' Add the "Publishers" root (expanded).
    Set rootNode = tvwPublishers.Nodes.Add(, , "\\Publishers", "Publishers")
    rootNode.Expanded = True
    
    ' Add all the publishers, with a plus sign.
    Do Until rs.EOF
        Set nd = tvwPublishers.Nodes.Add(rootNode.Key, tvwChild, , rs.Fields("Name"))
        ' We can't use PubID as the Key, because it is a number.
        nd.Tag = rs.Fields("PubId")
        AddDummyChild nd
        rs.MoveNext
    Loop
    rs.Close
    
End Sub

Sub AddDummyChild(nd As node)
    ' add a dummy child node, if necessary
    If nd.Children = 0 Then
        ' dummy nodes' Text property is "***"
        tvwPublishers.Nodes.Add nd.Index, tvwChild, , "***"
    End If
End Sub

Private Sub tvwPublishers_Expand(ByVal node As ComctlLib.node)
    ' a node if being expanded
    Dim nd As node
    ' exit if the node had been already expanded in the past
    If node.Children = 0 Or node.Children > 1 Then Exit Sub
    ' also exit if it doesn't have a dummy child node
    If node.Child.Text <> "***" Then Exit Sub
    ' remove the dummy child item
    tvwPublishers.Nodes.Remove node.Child.Index
    ' add all the titles for this Node object
    AddTitles node
End Sub

Private Sub AddTitles(ByVal node As ComctlLib.node)
    Dim nd As node

    ' Show all the titles for the expanded publishers.
    rs.Open "Select Title From Titles Where PubId = " & node.Tag, cn, adOpenForwardOnly, adLockReadOnly
    Do Until rs.EOF
        Set nd = tvwPublishers.Nodes.Add(node, tvwChild, , rs.Fields("Title"))
        rs.MoveNext
    Loop
    rs.Close
End Sub

