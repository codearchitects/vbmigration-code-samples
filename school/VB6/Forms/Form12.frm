VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form12 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add New School Year"
   ClientHeight    =   1200
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4110
   Icon            =   "Form12.frx":0000
   LinkTopic       =   "Form10"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   1200
   ScaleWidth      =   4110
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   3000
      TabIndex        =   2
      Top             =   720
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Update"
      Default         =   -1  'True
      Height          =   350
      Left            =   1680
      TabIndex        =   1
      Top             =   720
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   3855
      TabIndex        =   4
      Top             =   600
      Width           =   3855
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   5
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.TextBox Text1 
      Height          =   350
      Left            =   1320
      MaxLength       =   9
      TabIndex        =   0
      Top             =   120
      Width           =   2655
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   120
      Top             =   720
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   1
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form12.frx":038A
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label4 
      Caption         =   "School Year:"
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   1095
   End
End
Attribute VB_Name = "Form12"
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

Public add_state As Boolean
Dim old_sy As String

Private Sub Command1_Click()
If is_empty(Text1) = True Then Exit Sub
If Len(Text1.Text) < 9 Or Mid(Text1.Text, 5, 1) <> "-" Then MsgBox "Enry must be in this format (ex. yyyy-yyyy).", vbExclamation, "CSRS version 1": Text1.SetFocus: Exit Sub

If old_sy <> Text1.Text Then
   If if_exist("tblSchoolYear", "SchoolYear", Text1) = True Then Exit Sub
End If

With rs_sy
    If add_state = True Then .AddNew
        .Fields(0) = Text1.Text
    .Update
End With

'------------------------------
'Inform updates
'------------------------------
If add_state = True Then
    MsgBox "Adding of new school year has been successfull.", vbInformation, "CSRS version 1"
    Dim rep As Integer
    rep = MsgBox("Do you want to add another school year?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbYes Then
        Text1.Text = ""
        Text1.SetFocus
        rs_sy.Requery
        Form11.load_rec
    Else
        rs_sy.Requery
        Form11.load_rec
        Unload Me
    End If
    rep = 0
Else
    MsgBox "Changes in record has been successfully saved.", vbInformation, "CSRS version 1"
    Dim pos As Long
    
    pos = rs_sy.AbsolutePosition
    rs_sy.Requery
    Form11.load_rec
    rs_sy.AbsolutePosition = pos
    
    Form11.ListView1.ListItems.Item(pos).EnsureVisible
    Form11.ListView1.ListItems.Item(pos).Selected = True
    
    pos = 0
    Unload Me
End If
'------------------------------
'End-Inform updates
'------------------------------
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)

If add_state = False Then
    Text1.Text = rs_sy.Fields(0)
    old_sy = rs_sy.Fields(0)
    Me.Icon = ImageList1.ListImages(1).Picture
    Me.Caption = "Edit Existing School Year"
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
old_sy = ""
Form11.Enabled = True

Call save_pos(Me)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8 Or KeyAscii = 45) Then KeyAscii = 0
End Sub
