VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Forms As Object Viewers"
   ClientHeight    =   2310
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6945
   LinkTopic       =   "Form1"
   ScaleHeight     =   2310
   ScaleWidth      =   6945
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Notification "
      Height          =   1575
      Left            =   4680
      TabIndex        =   2
      Top             =   360
      Width           =   2055
      Begin VB.OptionButton Option1 
         Caption         =   "&3. Key-level"
         Height          =   255
         Index           =   2
         Left            =   120
         TabIndex        =   5
         Top             =   1080
         Width           =   1695
      End
      Begin VB.OptionButton Option1 
         Caption         =   "&2. Field-level"
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   4
         Top             =   720
         Width           =   1695
      End
      Begin VB.OptionButton Option1 
         Caption         =   "&1. Record-level"
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   3
         Top             =   360
         Value           =   -1  'True
         Width           =   1695
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Anne Lipton"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   360
      TabIndex        =   1
      Top             =   1320
      Width           =   4095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "John Smith"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   4095
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim Person1 As New CPerson
Dim Person2 As New CPerson

Private Sub Form_Load()
    With Person1
        .Name = "John Smith"
        .Address = "12345 West Road"
        .City = "San Francisco"
        .Married = True
    End With
    With Person2
        .Name = "Anne Lipton"
        .Address = "345 East Street"
        .City = "Los Angeles"
        .Married = True
    End With
        
End Sub

Private Sub Command1_Click()
    Dim frm As New frmPerson
    Set frm.Person = Person1
    frm.Show , Me
End Sub

Private Sub Command2_Click()
    Dim frm As New frmPerson
    Set frm.Person = Person2
    frm.Show , Me
End Sub

Private Sub Option1_Click(Index As Integer)
    NotifyMode = Index
End Sub
