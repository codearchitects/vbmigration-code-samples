VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form15 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Add New Section"
   ClientHeight    =   2310
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4950
   Icon            =   "Form15.frx":0000
   LinkTopic       =   "Form15"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   2310
   ScaleWidth      =   4950
   Begin VB.CommandButton Command1 
      Caption         =   "&Update"
      Default         =   -1  'True
      Height          =   350
      Left            =   2520
      TabIndex        =   4
      Top             =   1800
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   3840
      TabIndex        =   5
      Top             =   1800
      Width           =   975
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   4695
      TabIndex        =   9
      Top             =   1680
      Width           =   4695
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   10
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.TextBox Text4 
      Height          =   350
      Left            =   2160
      MaxLength       =   4
      TabIndex        =   3
      Text            =   "0"
      Top             =   1200
      Width           =   855
   End
   Begin VB.TextBox Text2 
      Height          =   350
      Left            =   2160
      MaxLength       =   3
      TabIndex        =   1
      Text            =   "0"
      Top             =   720
      Width           =   375
   End
   Begin VB.TextBox Text1 
      Height          =   350
      Left            =   2160
      MaxLength       =   150
      TabIndex        =   0
      Top             =   240
      Width           =   2655
   End
   Begin VB.TextBox Text3 
      Height          =   350
      Left            =   2640
      MaxLength       =   3
      TabIndex        =   2
      Text            =   "0"
      Top             =   720
      Width           =   375
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   720
      Top             =   2040
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
            Picture         =   "Form15.frx":038A
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label1 
      Caption         =   "No. Of Student Allowed:"
      Height          =   255
      Left            =   120
      TabIndex        =   8
      Top             =   1200
      Width           =   1815
   End
   Begin VB.Line Line1 
      X1              =   2520
      X2              =   2640
      Y1              =   840
      Y2              =   840
   End
   Begin VB.Label Label8 
      Caption         =   "Required Average Grade:"
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   720
      Width           =   1815
   End
   Begin VB.Label Label4 
      Caption         =   "First Name:"
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   240
      Width           =   1095
   End
End
Attribute VB_Name = "Form15"
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

Private Sub Command1_Click()
If is_empty(Text1) = True Then Exit Sub
If Val(Text2.Text) = 0 Then MsgBox "The field must not be zero value.", vbExclamation, "CSRS version 1": Text2.SetFocus: Exit Sub
If Val(Text3.Text) = 0 Then MsgBox "The field must not be zero value.", vbExclamation, "CSRS version 1": Text3.SetFocus: Exit Sub
If Val(Text4.Text) = 0 Then MsgBox "The field must not be zero value.", vbExclamation, "CSRS version 1": Text4.SetFocus: Exit Sub

If Val(Text2.Text) > Val(Text3.Text) Then MsgBox "The minimum average must not be greater than to " & Val(Text3.Text) & ".", vbExclamation, "CSRS version 1": Text3.SetFocus: Exit Sub

With rs_sec
    If add_state = True Then .AddNew: .Fields(0) = get_num("tblSections", "SectionNo", cn): .Fields(1) = Form14.lv_no
        .Fields(2) = Text1.Text
        .Fields(3) = Val(Text2.Text)
        .Fields(4) = Val(Text3.Text)
        .Fields(5) = Val(Text4.Text)
    .Update
End With
'------------------------------
'Inform updates
'------------------------------
If add_state = True Then
    MsgBox "Adding of new section has been successfull.", vbInformation, "CSRS version 1"
    Dim rep As Integer
    rep = MsgBox("Do you want to add another section?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbYes Then
        Text1.Text = ""
        Text2.Text = "0"
        Text3.Text = "0"
        Text4.Text = "0"
        Text1.SetFocus
        rs_sec.Requery
        Form14.load_rec
    Else
        rs_sec.Requery
        Form14.load_rec
        Unload Me
    End If
    rep = 0
Else
    MsgBox "Changes in record has been successfully saved.", vbInformation, "CSRS version 1"
    Dim pos As Long
    
    pos = rs_sec.AbsolutePosition
    rs_sec.Requery
    Form14.load_rec
    rs_sec.AbsolutePosition = pos
    
    Form14.ListView1.ListItems.Item(pos).EnsureVisible
    Form14.ListView1.ListItems.Item(pos).Selected = True
    
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
    Text1.Text = rs_sec.Fields(2)
    Text2.Text = rs_sec.Fields(3)
    Text3.Text = rs_sec.Fields(4)
    Text4.Text = rs_sec.Fields(5)
    Me.Icon = ImageList1.ListImages(1).Picture
    Me.Caption = "Edit Existing Section"
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
Form14.Enabled = True

Call save_pos(Me)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub
Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub
Private Sub Text3_GotFocus()
Call highlight_focus(Text3)
End Sub

Private Sub Text3_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text4_GotFocus()
Call highlight_focus(Text4)
End Sub

Private Sub Text4_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub
