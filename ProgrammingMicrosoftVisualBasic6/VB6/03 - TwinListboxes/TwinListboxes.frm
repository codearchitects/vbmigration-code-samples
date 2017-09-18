VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Mutually Exclusive Listbox controls"
   ClientHeight    =   3735
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8445
   LinkTopic       =   "Form1"
   ScaleHeight     =   3735
   ScaleWidth      =   8445
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   495
      Left            =   7080
      TabIndex        =   6
      Top             =   360
      Width           =   1095
   End
   Begin VB.ListBox lstRight 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2940
      Left            =   4200
      MultiSelect     =   2  'Extended
      Sorted          =   -1  'True
      TabIndex        =   5
      Top             =   360
      Width           =   2535
   End
   Begin VB.CommandButton cmdBackAll 
      Caption         =   "<<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   4
      Top             =   2760
      Width           =   615
   End
   Begin VB.CommandButton cmdBack 
      Caption         =   "<"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   3
      Top             =   2160
      Width           =   615
   End
   Begin VB.CommandButton cmdMoveAll 
      Caption         =   ">>"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   2
      Top             =   960
      Width           =   615
   End
   Begin VB.CommandButton cmdMove 
      Caption         =   ">"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3240
      TabIndex        =   1
      Top             =   360
      Width           =   615
   End
   Begin VB.ListBox lstLeft 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2940
      Left            =   360
      MultiSelect     =   2  'Extended
      Sorted          =   -1  'True
      TabIndex        =   0
      Top             =   360
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DisableMessage 0354
Option Explicit

Private Sub Form_Load()
    Dim i As Long
    ' load a list of names
    For i = 1 To 12
        lstLeft.AddItem Choose(i, "Black", "Blue", "Green", _
            "Red", "Orange", "Yellow", "White", "Gray", "Brown", _
            "Cyan", "Magenta", "Pink")
    Next
    SetButtonState
End Sub

Private Sub cmdMove_Click()
    ' move one item from left to right
    ' two different behavior, for regular or multiselect listboxes
    If lstLeft.MultiSelect = False Or lstLeft.SelCount = 0 Then
        ' single selection listbox
        If lstLeft.ListIndex >= 0 Then
            lstRight.AddItem lstLeft.Text
            lstLeft.RemoveItem lstLeft.ListIndex
        End If
    Else
        ' multiple selection listbox
        ' note how we advance the counter
        Dim i As Long
        Do While i < lstLeft.ListCount
            If lstLeft.Selected(i) Then
                lstRight.AddItem lstLeft.List(i)
                lstLeft.RemoveItem i
            Else
                i = i + 1
            End If
        Loop
    End If
    SetButtonState
End Sub

Private Sub cmdMoveAll_Click()
    ' move all items from left to right
    Do While lstLeft.ListCount
        lstRight.AddItem lstLeft.List(0)
        lstLeft.RemoveItem 0
    Loop
    SetButtonState
End Sub

Private Sub cmdBack_Click()
    ' move one item from right to left
    ' two different behavior, for regular or multiselect listboxes
    If lstLeft.MultiSelect = False Or lstRight.SelCount = 0 Then
        ' single selection listbox
        If lstRight.ListIndex >= 0 Then
            ' single selection listbox
            lstLeft.AddItem lstRight.Text
            lstRight.RemoveItem lstRight.ListIndex
        End If
    Else
        ' multiple selection listbox
        ' note how we advance the counter
        Dim i As Long
        Do While i < lstRight.ListCount
            If lstRight.Selected(i) Then
                lstLeft.AddItem lstRight.List(i)
                lstRight.RemoveItem i
            Else
                i = i + 1
            End If
        Loop
    End If
    SetButtonState
End Sub

Private Sub cmdBackAll_Click()
    ' move all items from right to left
    Do While lstRight.ListCount
        lstLeft.AddItem lstRight.List(0)
        lstRight.RemoveItem 0
    Loop
    SetButtonState
End Sub

Private Sub lstLeft_Click()
    SetButtonState
End Sub

Private Sub lstLeft_DblClick()
    ' simulate a click on the button
    cmdMove.Value = True
End Sub

Private Sub lstRight_Click()
    SetButtonState
End Sub

Private Sub lstRight_DblClick()
    ' simulate a click on the button
    cmdBack.Value = True
End Sub

Private Sub cmdOK_Click()
    Unload Me
End Sub

Private Sub SetButtonState()
    ' set enabled state for all buttons
    ' this code accounts for both regular and multiselect listboxes
    cmdMove.Enabled = (lstLeft.ListCount > 0 And lstLeft.ListIndex <> -1 Or lstLeft.SelCount > 0)
    cmdMoveAll.Enabled = (lstLeft.ListCount > 0)
    cmdBack.Enabled = (lstRight.ListCount > 0 And lstRight.ListIndex <> -1 Or lstRight.SelCount > 0)
    cmdBackAll.Enabled = (lstRight.ListCount > 0)
End Sub


