VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "TreeView Drag-and-Drop demo"
   ClientHeight    =   5850
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7995
   LinkTopic       =   "Form1"
   ScaleHeight     =   5850
   ScaleWidth      =   7995
   StartUpPosition =   3  'Windows Default
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   3960
      Top             =   2520
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   13
      ImageHeight     =   13
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   2
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "DragDrop.frx":0000
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "DragDrop.frx":00FA
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   5295
      Index           =   0
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   3855
      _ExtentX        =   6800
      _ExtentY        =   9340
      _Version        =   393217
      Indentation     =   706
      LineStyle       =   1
      Style           =   7
      ImageList       =   "ImageList1"
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
      OLEDropMode     =   1
   End
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   5295
      Index           =   1
      Left            =   4080
      TabIndex        =   1
      Top             =   480
      Width           =   3855
      _ExtentX        =   6800
      _ExtentY        =   9340
      _Version        =   393217
      Indentation     =   706
      LineStyle       =   1
      Style           =   7
      ImageList       =   "ImageList1"
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
      OLEDropMode     =   1
   End
   Begin VB.Label Label1 
      Caption         =   "Move a subtree using the right-button - Use Ctrl to copy it."
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
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   7815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' the source control
Dim SourceTreeView As TreeView
' the source Node object
Dim SourceNode As Node
' the state of Shift keys during the D&D operation
Dim ShiftState As Integer

Private Sub Form_Load()
    ' add a number of random items to the leftmost TreeView control
    Dim i1 As Long, i2 As Long, i3 As Long
    Dim no1 As Node, no2 As Node, no3 As Node
    Dim count As Long
    
    For i1 = 0 To Rnd * 20
        count = count + 1
        Set no1 = TreeView1(0).Nodes.Add(, , , "Item #" & count, 1)
        For i2 = 0 To Rnd * 15
            count = count + 1
            Set no2 = TreeView1(0).Nodes.Add(no1.Index, tvwChild, , "Item #" & count, 1)
            For i3 = 0 To Rnd * 10
                count = count + 1
                Set no3 = TreeView1(0).Nodes.Add(no2.Index, tvwChild, , "Item #" & count, 1)
            Next
        Next
    Next
    ' set properties common to all nodes
    For i1 = 1 To TreeView1(0).Nodes.count
        TreeView1(0).Nodes(i1).ExpandedImage = 2
    Next
End Sub

Private Sub TreeView1_MouseDown(Index As Integer, Button As Integer, Shift As Integer, x As Single, y As Single)
    ' check if we are starting a drag operation
    If Button <> 2 Then Exit Sub
    ' set the node being dragged, exit if there is none
    Set SourceNode = TreeView1(Index).HitTest(x, y)
    If SourceNode Is Nothing Then Exit Sub
    
    ' save values for later
    Set SourceTreeView = TreeView1(Index)
    ShiftState = Shift
    ' start the drag operation
    TreeView1(Index).OLEDrag
End Sub

Private Sub TreeView1_OLEStartDrag(Index As Integer, Data As MSComctlLib.DataObject, AllowedEffects As Long)
    ' pass the Key property of the Node being dragged
    ' (this value is not used, we can actually pass anything)
    Data.SetData SourceNode.Key
    If ShiftState And vbCtrlMask Then
        AllowedEffects = vbDropEffectCopy
    Else
        AllowedEffects = vbDropEffectMove
    End If
End Sub

Private Sub TreeView1_OLEDragOver(Index As Integer, Data As MSComctlLib.DataObject, Effect As Long, Button As Integer, Shift As Integer, x As Single, y As Single, State As Integer)
    ' highlight the Node the mouse is over
    Set TreeView1(Index).DropHighlight = TreeView1(Index).HitTest(x, y)
End Sub

Private Sub TreeView1_OLEDragDrop(Index As Integer, Data As MSComctlLib.DataObject, Effect As Long, Button As Integer, Shift As Integer, x As Single, y As Single)
    Dim dest As Node, nd As Node
    ' get the target of the operation
    Set dest = TreeView1(Index).DropHighlight
    
    If dest Is Nothing Then
        ' add the node as the root of the target treeview
        Set nd = TreeView1(Index).Nodes.Add(, , , SourceNode.Text, SourceNode.Image)
    Else
    
        ' check that the destination node isn't a descendent of the source node
        If SourceTreeView Is TreeView1(Index) Then
            Set nd = dest
            Do
                If nd Is SourceNode Then
                    MsgBox "Unable to drag nodes here", vbExclamation
                    Exit Sub
                End If
                Set nd = nd.Parent
            Loop Until nd Is Nothing
        End If
        Set nd = TreeView1(Index).Nodes.Add(dest.Index, tvwChild, , SourceNode.Text, SourceNode.Image)
    End If
    nd.ExpandedImage = 2
    nd.Expanded = True
    
    CopySubTree SourceTreeView, SourceNode, TreeView1(Index), nd
    ' if this is a move operation, delete the source subtree
    If Effect = vbDropEffectMove Then
        SourceTreeView.Nodes.Remove SourceNode.Index
    End If
    Set TreeView1(Index).DropHighlight = Nothing
End Sub

