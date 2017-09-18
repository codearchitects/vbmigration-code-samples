VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Manual Drag-and-drop Demo"
   ClientHeight    =   1725
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7590
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
   ScaleHeight     =   1725
   ScaleWidth      =   7590
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command4 
      Caption         =   "Custom Format Drag && Drop"
      Height          =   735
      Left            =   5640
      TabIndex        =   4
      Top             =   240
      Width           =   1575
   End
   Begin VB.CommandButton Command3 
      Caption         =   "File names D&&&D Source"
      Height          =   735
      Left            =   3840
      TabIndex        =   2
      Top             =   240
      Width           =   1575
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Batch File  Editor"
      Height          =   735
      Left            =   2040
      TabIndex        =   1
      Top             =   240
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Count Words"
      Height          =   735
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "NOTE: all drag-and-drop operations in this demo are initiated using the right mouse button."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   360
      TabIndex        =   3
      Top             =   1080
      Width           =   7095
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False

Option Explicit

Private Sub Command1_Click()
    Dim frm As New Form1
    frm.Show , Me
End Sub

Private Sub Command2_Click()
    Dim frm As New Form2
    frm.Show , Me
End Sub

Private Sub Command3_Click()
    Dim frm As New Form3
    frm.Show , Me
End Sub

Private Sub Command4_Click()
    Dim frm As New Form4
    frm.Show , Me
End Sub

