VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5685
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6705
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
   ScaleHeight     =   5685
   ScaleWidth      =   6705
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCopy 
      Caption         =   "&Copy"
      Height          =   495
      Left            =   5040
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   5160
      Top             =   3600
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
            Picture         =   "ParseTV.frx":0000
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "ParseTV.frx":00FA
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   5295
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4695
      _ExtentX        =   8281
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
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCopy_Click()
    Clipboard.Clear
    Clipboard.SetText TreeViewToString(TreeView1, , True)
End Sub

Private Sub Form_Load()
    ' add a number of random items to the leftmost TreeView control
    Dim i1 As Long, i2 As Long, i3 As Long
    Dim no1 As Node, no2 As Node, no3 As Node
    Dim count As Long
    
    For i1 = 0 To Rnd * 20
        count = count + 1
        Set no1 = TreeView1.Nodes.Add(, , , "Item #" & count, 1)
        For i2 = 0 To Rnd * 15
            count = count + 1
            Set no2 = TreeView1.Nodes.Add(no1.Index, tvwChild, , "Item #" & count, 1)
            For i3 = 0 To Rnd * 10
                count = count + 1
                Set no3 = TreeView1.Nodes.Add(no2.Index, tvwChild, , "Item #" & count, 1)
            Next
        Next
    Next
    ' set properties common to all nodes
    For i1 = 1 To TreeView1.Nodes.count
        TreeView1.Nodes(i1).ExpandedImage = 2
    Next
End Sub


