VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Multiple Selection Listbox Controls"
   ClientHeight    =   4530
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7380
   LinkTopic       =   "Form1"
   ScaleHeight     =   4530
   ScaleWidth      =   7380
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdInvertAll 
      Caption         =   "&Invert All"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5760
      TabIndex        =   6
      Top             =   2040
      Width           =   1335
   End
   Begin VB.CommandButton cmdClearAll 
      Caption         =   "&Clear All"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5760
      TabIndex        =   5
      Top             =   1320
      Width           =   1335
   End
   Begin VB.CommandButton cmdSelectAll 
      Caption         =   "&Select All"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5760
      TabIndex        =   4
      Top             =   600
      Width           =   1335
   End
   Begin VB.ListBox List2 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3420
      IntegralHeight  =   0   'False
      Left            =   3000
      Style           =   1  'Checkbox
      TabIndex        =   1
      Top             =   600
      Width           =   2535
   End
   Begin VB.ListBox List1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3420
      Left            =   240
      MultiSelect     =   2  'Extended
      TabIndex        =   0
      Top             =   600
      Width           =   2415
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Try deselect the first item"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   5760
      TabIndex        =   7
      Top             =   3480
      Width           =   1335
   End
   Begin VB.Label Label2 
      Caption         =   "Style = 1-CheckBox"
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
      Left            =   3000
      TabIndex        =   3
      Top             =   240
      Width           =   2415
   End
   Begin VB.Label Label1 
      Caption         =   "Style = 0-Standard"
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
      Left            =   240
      TabIndex        =   2
      Top             =   240
      Width           =   2415
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    Dim i As Long
    For i = 1 To 5000
        List1.AddItem "Item #" & i
        List2.AddItem "Item #" & i
    Next
    ' the first items is always selected
    List2.Selected(0) = True
End Sub

Private Sub cmdSelectAll_Click()
    Dim i As Long, saveIndex As Long, saveTop As Long
    ' save current state
    saveIndex = List2.ListIndex
    saveTop = List2.TopIndex
    ' make the listbox invisible to avoid flickering
    List2.Visible = False
    ' try uncomment the next line to see the "invisible" listbox
    ' Refresh
    ' change the select state for all items
    For i = 1 To List2.ListCount - 1
        List2.Selected(i) = True
    Next
    ' restore original state, make it visible again
    List2.TopIndex = saveTop
    List2.ListIndex = saveIndex
    List2.Visible = True
End Sub

Private Sub cmdClearAll_Click()
    Dim i As Long, saveIndex As Long, saveTop As Long
    ' save current state
    saveIndex = List2.ListIndex
    saveTop = List2.TopIndex
    ' make the listbox invisible to avoid flickering
    List2.Visible = False
    ' change the select state for all items
    For i = 1 To List2.ListCount - 1
        List2.Selected(i) = False
    Next
    ' restore original state, make it visible again
    List2.TopIndex = saveTop
    List2.ListIndex = saveIndex
    List2.Visible = True
End Sub

Private Sub cmdInvertAll_Click()
    Dim i As Long, saveIndex As Long, saveTop As Long
    ' save current state
    saveIndex = List2.ListIndex
    saveTop = List2.TopIndex
    ' make the listbox invisible to avoid flickering
    List2.Visible = False
    ' change the select state for all items
    For i = 1 To List2.ListCount - 1
        List2.Selected(i) = Not List2.Selected(i)
    Next
    ' restore original state, make it visible again
    List2.TopIndex = saveTop
    List2.ListIndex = saveIndex
    List2.Visible = True
End Sub

Private Sub List2_ItemCheck(Item As Integer)
    ' refuse to deselect the first item
    If Item = 0 And List2.Selected(0) = False Then
        List2.Selected(0) = True
        MsgBox "You can't deselect the first item", vbExclamation, "ItemCheck event demo"
    End If
End Sub
