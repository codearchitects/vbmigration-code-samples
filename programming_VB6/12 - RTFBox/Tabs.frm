VERSION 5.00
Begin VB.Form frmTabs 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Tabs"
   ClientHeight    =   2895
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4080
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2895
   ScaleWidth      =   4080
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDeleteAll 
      Caption         =   "Delete &All"
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
      Left            =   2640
      TabIndex        =   0
      Top             =   1080
      Width           =   1245
   End
   Begin VB.TextBox txtTab 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   120
      MaxLength       =   10
      TabIndex        =   6
      Top             =   360
      Width           =   2265
   End
   Begin VB.ListBox lstTabs 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1980
      Left            =   120
      TabIndex        =   5
      Top             =   750
      Width           =   2265
   End
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
      Left            =   2640
      TabIndex        =   4
      Top             =   2400
      Width           =   1245
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Enabled         =   0   'False
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
      Left            =   2640
      TabIndex        =   3
      Top             =   720
      Width           =   1245
   End
   Begin VB.CommandButton cmdSet 
      Caption         =   "&Set"
      Enabled         =   0   'False
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
      Left            =   2640
      TabIndex        =   2
      Top             =   360
      Width           =   1245
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
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
      Left            =   2640
      TabIndex        =   1
      Top             =   1920
      Width           =   1245
   End
   Begin VB.Label Label1 
      Caption         =   "Tab Stops"
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
      TabIndex        =   7
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "frmTabs"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public CancelPressed As Boolean

Private Sub cmdOK_Click()
    CancelPressed = False
    Hide
End Sub

Private Sub cmdcancel_Click()
    CancelPressed = True
    Hide
End Sub

Private Sub txtTab_Change()
    cmdSet.Enabled = Len(txtTab)
End Sub

Private Sub lstTabs_Click()
    txtTab.Text = lstTabs.Text
    cmdDelete.Enabled = True
    cmdDeleteAll.Enabled = True
End Sub

Private Sub cmdSet_Click()
    If Len(txtTab) = 0 Then Exit Sub
    
    Dim i As Integer
    For i = 0 To lstTabs.ListCount - 1
        If Int(lstTabs.List(i)) = Int(txtTab) Then
            ' This item is already in the list, nothing else to do.
            txtTab = ""
            Exit Sub
        ElseIf Int(lstTabs.List(i)) > Int(txtTab) Then
            ' We've found the right position for this item.
            lstTabs.AddItem Int(txtTab), i
            txtTab = ""
            Exit Sub
        End If
    Next
    ' If flow gets here, this item has to be appended to the list.
    lstTabs.AddItem Int(txtTab)
    txtTab = ""
End Sub

Private Sub cmdDelete_Click()
    If lstTabs.ListIndex <> -1 Then
        lstTabs.RemoveItem lstTabs.ListIndex
    End If
    txtTab = ""
End Sub

Private Sub cmdDeleteAll_Click()
    lstTabs.Clear
    txtTab = ""
End Sub


