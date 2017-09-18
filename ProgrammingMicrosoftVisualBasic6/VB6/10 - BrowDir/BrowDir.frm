VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmDirBrowser 
   Caption         =   "Directory Browser"
   ClientHeight    =   4875
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5055
   LinkTopic       =   "Form2"
   ScaleHeight     =   4875
   ScaleWidth      =   5055
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
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
      Left            =   2520
      TabIndex        =   2
      Top             =   4320
      Width           =   975
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
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
      Left            =   1320
      TabIndex        =   1
      Top             =   4320
      Width           =   975
   End
   Begin ComctlLib.TreeView tvwDir 
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
   End
   Begin VB.Label lblPath 
      Caption         =   "lblPath"
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
      TabIndex        =   3
      Top             =   120
      Width           =   4695
   End
   Begin ComctlLib.ImageList ImageList1 
      Left            =   240
      Top             =   3360
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   327682
      BeginProperty Images {0713E8C2-850A-101B-AFC0-4210102A8DA7} 
         NumListImages   =   4
         BeginProperty ListImage1 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "BrowDir.frx":0000
            Key             =   "Computer"
         EndProperty
         BeginProperty ListImage2 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "BrowDir.frx":031A
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "BrowDir.frx":0634
            Key             =   "Folder"
         EndProperty
         BeginProperty ListImage4 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "BrowDir.frx":094E
            Key             =   "OpenFolder"
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmDirBrowser"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' True if Cancel was pressed to close this form
Public CancelPressed As Boolean

Private m_Path As String

' this is used by many routines in the module
Dim FSO As New Scripting.FileSystemObject

' the Path currently selected
Property Get Path() As String
    Path = m_Path
End Property

Private Sub Form_Load()
    ' build the subdirectory tree
    DirRefresh
End Sub

Private Sub Form_Resize()
    ' the distance among controls
    Const DISTANCE = 100
    Dim tvwTop As Single
    
    ' move the buttons and the label
    lblPath.Move DISTANCE, 0, ScaleWidth, lblPath.Height
    cmdOK.Move ScaleWidth / 2 - DISTANCE - cmdOK.Width, ScaleHeight - DISTANCE - cmdOK.Height
    cmdCancel.Move ScaleWidth / 2 + DISTANCE, cmdOK.Top
    ' resize the treeview control
    ' the Top position depends on the visibility of the lblPath label
    If lblPath.Visible Then
        tvwTop = lblPath.Top + lblPath.Height
    Else
        tvwTop = DISTANCE
    End If
    tvwDir.Move DISTANCE, tvwTop, ScaleWidth - DISTANCE * 2, ScaleHeight - tvwTop - cmdOK.Height - DISTANCE * 2
End Sub

Private Sub DirRefresh()
    ' build the treeview control
    Dim dr As Scripting.Drive
    Dim rootNode As node, nd As node
    
    On Error Resume Next
    
    ' add the "My Computer" root (expanded)
    Set rootNode = tvwDir.Nodes.Add(, , "\\MyComputer", "My Computer", 1)
    rootNode.Expanded = True
    
    ' add all the drives, with a plus sign
    For Each dr In FSO.Drives
        If dr.Path <> "A:" Then
            Err.Clear
            Set nd = tvwDir.Nodes.Add(rootNode.Key, tvwChild, dr.Path & "\", dr.Path & " " & dr.VolumeName, 2)
            If Err = 0 Then AddDummyChild nd
        End If
    Next
    
End Sub

Sub AddDummyChild(nd As node)
    ' add a dummy child node, if necessary
    If nd.Children = 0 Then
        ' dummy nodes' Text property is "***"
        tvwDir.Nodes.Add nd.Index, tvwChild, , "***"
    End If
End Sub

Private Sub tvwDir_Click()
    m_Path = tvwDir.SelectedItem.Key
    lblPath.Caption = tvwDir.SelectedItem.Key
End Sub

Private Sub tvwDir_Expand(ByVal node As ComctlLib.node)
    ' a node if being expanded
    Dim nd As node
    ' exit if the node had been already expanded in the past
    If node.Children = 0 Or node.Children > 1 Then Exit Sub
    ' also exit if it doesn't have a dummy child node
    If node.Child.Text <> "***" Then Exit Sub
    ' remove the dummy child item
    tvwDir.Nodes.Remove node.Child.Index
    ' add all the subdirs of this Node object
    AddSubdirs node
End Sub

Private Sub AddSubdirs(ByVal node As ComctlLib.node)
    ' add all the subdirs under a node
    Dim fld As Scripting.Folder
    Dim nd As node
    
    ' we need this to work around Permission Denied errors
    On Error Resume Next

    ' the path in the node is hold in its key property
    ' cycle on all its subdirectories
    For Each fld In FSO.GetFolder(node.Key).SubFolders
        Set nd = tvwDir.Nodes.Add(node, tvwChild, fld.Path, fld.Name, 3)
        nd.ExpandedImage = 4
        ' if this directory has subfolders, add a "+" sign
        If fld.SubFolders.Count = 0 Then
            ' either no subfolders or permission denied errors
        Else
            AddDummyChild nd
        End If
    Next
End Sub

Private Sub cmdOK_Click()
    Unload Me
End Sub

Private Sub cmdCancel_Click()
    CancelPressed = True
    Unload Me
End Sub


