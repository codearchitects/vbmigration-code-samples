VERSION 5.00
Begin VB.Form Form7 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Advanced Search For Student"
   ClientHeight    =   4110
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4350
   Icon            =   "Form7.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   4110
   ScaleWidth      =   4350
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   3240
      TabIndex        =   6
      Top             =   3600
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Select"
      Default         =   -1  'True
      Height          =   350
      Left            =   1920
      TabIndex        =   5
      Top             =   3600
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Search Option"
      Height          =   3375
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   4095
      Begin VB.TextBox Text1 
         BackColor       =   &H00E6FFFF&
         ForeColor       =   &H80000012&
         Height          =   315
         Left            =   240
         Locked          =   -1  'True
         TabIndex        =   4
         Top             =   2760
         Visible         =   0   'False
         Width           =   3615
      End
      Begin VB.ComboBox Combo2 
         BackColor       =   &H00E6FFFF&
         ForeColor       =   &H80000012&
         Height          =   315
         ItemData        =   "Form7.frx":038A
         Left            =   240
         List            =   "Form7.frx":039D
         TabIndex        =   3
         Top             =   2160
         Width           =   1575
      End
      Begin VB.ComboBox Combo1 
         BackColor       =   &H00E6FFFF&
         ForeColor       =   &H80000012&
         Height          =   315
         Left            =   240
         TabIndex        =   2
         Top             =   1560
         Width           =   3615
      End
      Begin VB.OptionButton Option1 
         Caption         =   "Use Quick Search  ( Recommended )"
         Height          =   375
         Left            =   240
         TabIndex        =   0
         Top             =   480
         Width           =   3135
      End
      Begin VB.OptionButton Option2 
         Caption         =   "Use Custom Search"
         Height          =   375
         Left            =   240
         TabIndex        =   1
         Top             =   840
         Width           =   2895
      End
      Begin VB.Image Image1 
         Height          =   480
         Left            =   3360
         Picture         =   "Form7.frx":03B2
         Top             =   360
         Width           =   480
      End
      Begin VB.Label Label3 
         Caption         =   "Search Text"
         Height          =   255
         Left            =   240
         TabIndex        =   10
         Top             =   2520
         Visible         =   0   'False
         Width           =   2295
      End
      Begin VB.Label Label2 
         Caption         =   "Operator"
         Height          =   255
         Left            =   240
         TabIndex        =   9
         Top             =   1920
         Visible         =   0   'False
         Width           =   2295
      End
      Begin VB.Label Label1 
         Caption         =   "Look In"
         Height          =   255
         Left            =   240
         TabIndex        =   8
         Top             =   1320
         Width           =   2295
      End
   End
End
Attribute VB_Name = "Form7"
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

Private Sub Combo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Combo2_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command1_Click()
If Combo1.Text = "" Then Combo1.SetFocus: Exit Sub
If Option2.Value = True And Combo2.Text = "" Then Combo2.SetFocus: Exit Sub
Me.MousePointer = vbHourglass
On Error GoTo Err
If Option1.Value = True Then
'----------------------------
'For quick search
'----------------------------
    rs_stud.Filter = Combo1.Text & " like *" & Text1.Text & "*"
    MsgBox "There is/are " & rs_stud.RecordCount & " record found in the search for " & Text1.Text & "." & vbCrLf & "'Click' reload button in the Student Record form if you want to show all data.", vbInformation, "CSRS version 1"
Else
'----------------------------
'For custom search
'----------------------------
    rs_stud.Filter = Combo1.Text & " " & Combo2.Text & " '" & Text1.Text & "'"
    MsgBox "There is/are " & rs_stud.RecordCount & " record found in the search for " & Text1.Text & "." & vbCrLf & "'Click' reload button in the Student Record form if you want to show all data.", vbInformation, "CSRS version 1"
End If
'----------------------------
'Load search result
'----------------------------
Form1.fill_rec
Me.MousePointer = vbDefault
Unload Me
Exit Sub
'----------------------------
'Prompt if their is an error
'----------------------------
Err:
    Call prompt_err(Err.Description)
    Me.MousePointer = vbDefault
    Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Option1.Value = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
Form1.Enabled = True

Call save_pos(Me)
End Sub

Private Sub Option1_Click()
Label1.Top = 1320
Combo1.Top = 1560
Label2.Visible = False
Label3.Visible = False
Text1.Visible = False
Combo2.Visible = False
End Sub

Private Sub Option2_Click()
Label1.Top = 1320
Combo1.Top = 1560
Label2.Visible = True
Label3.Visible = True
Text1.Visible = True
Combo2.Visible = True
End Sub

Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub
