VERSION 5.00
Begin VB.Form Form22 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "School Information"
   ClientHeight    =   1680
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5175
   Icon            =   "Form22.frx":0000
   LinkTopic       =   "Form22"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   1680
   ScaleWidth      =   5175
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   4935
      TabIndex        =   6
      Top             =   1080
      Width           =   4935
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   7
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   4080
      TabIndex        =   3
      Top             =   1200
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Save Changes"
      Default         =   -1  'True
      Height          =   350
      Left            =   2280
      TabIndex        =   2
      Top             =   1200
      Width           =   1695
   End
   Begin VB.TextBox Text2 
      Height          =   350
      Left            =   1320
      TabIndex        =   1
      Top             =   600
      Width           =   3735
   End
   Begin VB.TextBox Text1 
      Height          =   350
      Left            =   1320
      TabIndex        =   0
      Top             =   120
      Width           =   3735
   End
   Begin VB.Label Label1 
      Caption         =   "Address:"
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   600
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "School Name:"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1095
   End
End
Attribute VB_Name = "Form22"
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
Option Explicit


Dim rs_set As New ADODB.Recordset


Private Sub Command1_Click()
If is_empty(Text1) = True Then Exit Sub
If is_empty(Text2) = True Then Exit Sub

With rs_set
    .Fields(0) = Text1.Text
    .Fields(1) = Text2.Text
    .Update
End With

school_name = Text1.Text
school_address = Text2.Text
MDIForm1.Caption = Text1.Text & " - " & "Computerize School Registration Software version 1"

MsgBox "Changes has been successfully saved.", vbInformation, "CSRS version 1"
Unload Me
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Call set_rec_getData(rs_set, cn, "Select SystemInfo.* From SystemInfo")

Text1.Text = rs_set.Fields(0)
Text2.Text = rs_set.Fields(1)
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_set = Nothing

Call save_pos(Me)
End Sub

Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub
