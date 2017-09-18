VERSION 5.00
Begin VB.Form Form23 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Administrator Option"
   ClientHeight    =   1620
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3390
   Icon            =   "Form23.frx":0000
   LinkTopic       =   "Form23"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   1620
   ScaleWidth      =   3390
   Begin VB.Frame Frame1 
      Height          =   1335
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3135
      Begin VB.CommandButton Command4 
         Height          =   615
         Left            =   2400
         Picture         =   "Form23.frx":038A
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   240
         Width           =   615
      End
      Begin VB.CommandButton Command3 
         Height          =   615
         Left            =   1560
         Picture         =   "Form23.frx":1054
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   240
         Width           =   615
      End
      Begin VB.CommandButton Command2 
         Height          =   615
         Left            =   840
         Picture         =   "Form23.frx":1D1E
         Style           =   1  'Graphical
         TabIndex        =   2
         Top             =   240
         Width           =   615
      End
      Begin VB.CommandButton Command1 
         Height          =   615
         Left            =   120
         Picture         =   "Form23.frx":29E8
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         Caption         =   "Cancel"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   2400
         TabIndex        =   8
         Top             =   840
         Width           =   615
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         Caption         =   "School Info"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1500
         TabIndex        =   7
         Top             =   840
         Width           =   735
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         Caption         =   "Log-in Info"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   720
         TabIndex        =   6
         Top             =   840
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   2  'Center
         Caption         =   "Modify Users"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   840
         Width           =   615
      End
   End
End
Attribute VB_Name = "Form23"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'-----------------------------------------------------------------------------------------------------
'All codes are copyright by Philip V. Naparan 2004
'
'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
'E-mail Address: philipnaparan@yahoo.com
'Contact #: 639186443161
'----------------------------------------------------------------------------------------------------


Private Sub Command1_Click()
Form26.Show
Form26.SetFocus
Form26.WindowState = 0
End Sub

Private Sub Command2_Click()
Form25.Show
Form25.SetFocus
Form25.WindowState = 0
End Sub

Private Sub Command3_Click()
Form22.Show
Form22.SetFocus
Form22.WindowState = 0
End Sub

Private Sub Command4_Click()
Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)
End Sub

Private Sub Form_Unload(Cancel As Integer)
Call save_pos(Me)
End Sub
