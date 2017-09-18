VERSION 5.00
Begin VB.Form Form3 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Student Section"
   ClientHeight    =   2175
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3990
   Icon            =   "Form3.frx":0000
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   2175
   ScaleWidth      =   3990
   Begin VB.TextBox Text4 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      Height          =   300
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   840
      Width           =   2415
   End
   Begin VB.CommandButton Command3 
      Height          =   300
      Left            =   3480
      Picture         =   "Form3.frx":038A
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   480
      Visible         =   0   'False
      Width           =   300
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Edit"
      Default         =   -1  'True
      Height          =   350
      Left            =   1320
      TabIndex        =   5
      Top             =   1680
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&OK"
      Height          =   350
      Left            =   2640
      TabIndex        =   6
      Top             =   1680
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   3735
      TabIndex        =   10
      Top             =   1560
      Width           =   3735
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   11
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.TextBox Text3 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      Height          =   300
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   1200
      Width           =   1815
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      Height          =   300
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   480
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      BackColor       =   &H8000000F&
      BorderStyle     =   0  'None
      Height          =   300
      Left            =   1200
      Locked          =   -1  'True
      MaxLength       =   3
      TabIndex        =   0
      Top             =   120
      Width           =   855
   End
   Begin VB.Label Label4 
      Caption         =   "Level:"
      Height          =   255
      Left            =   120
      TabIndex        =   12
      Top             =   840
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "School Year:"
      Height          =   255
      Left            =   120
      TabIndex        =   9
      Top             =   1200
      Width           =   975
   End
   Begin VB.Label Label2 
      Caption         =   "Section:"
      Height          =   255
      Left            =   120
      TabIndex        =   8
      Top             =   480
      Width           =   615
   End
   Begin VB.Label Label1 
      Caption         =   "Gen Ave:"
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   735
   End
End
Attribute VB_Name = "Form3"
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


Public sAssign As Boolean
Dim sEdit As Boolean
Public sSec_Id As Long


Private Sub Command1_Click()
If Command1.Caption = "Cancel" And sEdit = True Then
    disable_text
    Command1.Caption = "&OK"
    Command1.Default = True
    Command2.Caption = "&Edit"
    Command3.Visible = False
    Me.Caption = "Student Section"
Else
    Unload Me
End If
End Sub

Private Sub Command2_Click()
If rs_stud.Fields(12) = "Drop" Then MsgBox "Cannot Assign or Re-assign Section because the selected student was currently dropped in the school." & vbCrLf & vbCrLf & "Note: You can Undrop the Student if you want by selecting 'File' in the menu and then 'Student Record' and select 'Undrop Student'.", vbExclamation, "CSRS version 1": Exit Sub
If Command2.Caption = "&Edit" Then
    sEdit = True
    enable_text
    Text2.Locked = True
    Command1.Caption = "&Cancel"
    Command2.Caption = "&Save"
    Command2.Default = True
    Command3.Visible = True
    Me.Caption = "Re-assign Section"
Else
    If is_empty(Text1) = True Then Exit Sub
    If is_empty(Text2) = True Then Exit Sub
    With rs_stud
        .Fields(9) = Text1.Text
        .Fields(10) = sSec_Id
        .Update
        Dim pos As Long
        pos = .AbsolutePosition
        .Requery
        .AbsolutePosition = pos
        pos = 0
    End With
    MsgBox "Updating of data has been successfull.", vbInformation, "CSRS version 1"
    Unload Me
End If
End Sub

Private Sub Command3_Click()
If Val(Text1.Text) < 1 Then MsgBox "Please put the general average first.", vbExclamation, "CSRS version 1": Text1.SetFocus: Exit Sub
If Text2.BorderStyle = 1 Then Form4.gen_ave = Val(Text1.Text): Form4.Show: Me.Enabled = False
End Sub

Private Sub Form_Load()
Call use_pos(Me)


If sAssign = True Then
    enable_text
    Command1.Caption = "&Cancel"
    Command2.Caption = "&Update"
    Command2.Default = True
    Command3.Visible = True
    Me.Caption = "Assign Section"
Else
    If Not rs_stud.RecordCount < 1 Then
        With rs_stud
            Text1.Text = .Fields(9)
            Text2.Text = .Fields(20)
            Text3.Text = .Fields(11)
            Text4.Text = .Fields(21)
            sSec_Id = .Fields(10)
        End With
    End If
    Command1.Default = True
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
Form1.Enabled = True

Call save_pos(Me)
End Sub

Private Sub Text1_Change()
If Text2.BorderStyle = 1 Then Text2.Text = ""
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
Command3_Click
End Sub

Private Sub Text3_GotFocus()
Call highlight_focus(Text3)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub
Sub disable_text()
    Text1.Locked = True
    Text1.BorderStyle = 0
    Text1.BackColor = &H8000000F
    Text2.BorderStyle = 0
    Text2.BackColor = &HE6FFFF
End Sub
Sub enable_text()
    Text1.Locked = False
    Text1.BorderStyle = 1
    Text1.BackColor = &H80000005
    Text2.BorderStyle = 1
    Text2.BackColor = &HE6FFFF
End Sub

