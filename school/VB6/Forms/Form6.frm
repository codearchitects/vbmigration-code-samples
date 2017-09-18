VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomct2.ocx"
Begin VB.Form Form6 
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   6360
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10125
   Icon            =   "Form6.frx":0000
   LinkTopic       =   "Form6"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   6360
   ScaleWidth      =   10125
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   3840
      Top             =   5880
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
            Picture         =   "Form6.frx":038A
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Update"
      Default         =   -1  'True
      Height          =   350
      Left            =   6120
      TabIndex        =   18
      Top             =   5880
      Width           =   1335
   End
   Begin VB.CommandButton Command2 
      Caption         =   "C&lear"
      Height          =   350
      Left            =   7560
      TabIndex        =   19
      Top             =   5880
      Width           =   975
   End
   Begin VB.CommandButton Command3 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   8640
      TabIndex        =   20
      Top             =   5880
      Width           =   1335
   End
   Begin VB.Frame Frame2 
      Caption         =   "General Information"
      Height          =   5655
      Left            =   120
      TabIndex        =   21
      Top             =   120
      Width           =   9855
      Begin VB.TextBox Text17 
         Height          =   350
         Left            =   5760
         MaxLength       =   4
         TabIndex        =   6
         Top             =   1440
         Width           =   855
      End
      Begin VB.TextBox Text1 
         Height          =   350
         Left            =   5160
         MaxLength       =   2
         TabIndex        =   5
         Top             =   1440
         Width           =   375
      End
      Begin VB.ComboBox Text5 
         BackColor       =   &H00E6FFFF&
         Height          =   315
         ItemData        =   "Form6.frx":0724
         Left            =   1920
         List            =   "Form6.frx":072E
         TabIndex        =   3
         Text            =   "Male"
         Top             =   1440
         Width           =   1215
      End
      Begin VB.ComboBox Text13 
         Height          =   315
         ItemData        =   "Form6.frx":0740
         Left            =   6120
         List            =   "Form6.frx":0747
         TabIndex        =   13
         Top             =   3480
         Width           =   3255
      End
      Begin VB.ComboBox Text11 
         Height          =   315
         ItemData        =   "Form6.frx":0750
         Left            =   6120
         List            =   "Form6.frx":0757
         TabIndex        =   11
         Top             =   3000
         Width           =   3255
      End
      Begin VB.ComboBox Text16 
         BackColor       =   &H00E6FFFF&
         Height          =   315
         ItemData        =   "Form6.frx":0760
         Left            =   1920
         List            =   "Form6.frx":076A
         TabIndex        =   16
         Text            =   "New"
         Top             =   5040
         Width           =   1215
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   345
         Left            =   6120
         TabIndex        =   17
         Top             =   5040
         Width           =   2295
         _ExtentX        =   4048
         _ExtentY        =   609
         _Version        =   393216
         Format          =   19267585
         CurrentDate     =   38062
      End
      Begin VB.PictureBox Picture1 
         BackColor       =   &H80000010&
         BorderStyle     =   0  'None
         Height          =   30
         Left            =   480
         ScaleHeight     =   30
         ScaleWidth      =   8895
         TabIndex        =   26
         Top             =   1320
         Width           =   8895
         Begin VB.PictureBox Picture2 
            BackColor       =   &H80000014&
            BorderStyle     =   0  'None
            Height          =   10
            Left            =   0
            ScaleHeight     =   15
            ScaleWidth      =   8895
            TabIndex        =   27
            Top             =   10
            Width           =   8895
         End
      End
      Begin VB.TextBox Text2 
         Height          =   350
         Left            =   1920
         TabIndex        =   0
         Top             =   360
         Width           =   2655
      End
      Begin VB.TextBox Text3 
         Height          =   350
         Left            =   5880
         TabIndex        =   1
         Top             =   360
         Width           =   3495
      End
      Begin VB.TextBox Text4 
         Height          =   350
         Left            =   1920
         TabIndex        =   2
         Top             =   840
         Width           =   3495
      End
      Begin VB.TextBox Text6 
         Height          =   350
         Left            =   4560
         MaxLength       =   2
         TabIndex        =   4
         Top             =   1440
         Width           =   375
      End
      Begin VB.TextBox Text7 
         Height          =   350
         Left            =   7680
         MaxLength       =   3
         TabIndex        =   7
         Top             =   1440
         Width           =   1695
      End
      Begin VB.TextBox Text8 
         Height          =   350
         Left            =   1920
         TabIndex        =   8
         Top             =   1920
         Width           =   5535
      End
      Begin VB.PictureBox Picture3 
         BackColor       =   &H80000010&
         BorderStyle     =   0  'None
         Height          =   30
         Left            =   480
         ScaleHeight     =   30
         ScaleWidth      =   8895
         TabIndex        =   24
         Top             =   2400
         Width           =   8895
         Begin VB.PictureBox Picture4 
            BackColor       =   &H80000014&
            BorderStyle     =   0  'None
            Height          =   10
            Left            =   0
            ScaleHeight     =   15
            ScaleWidth      =   8895
            TabIndex        =   25
            Top             =   10
            Width           =   8895
         End
      End
      Begin VB.TextBox Text9 
         Height          =   350
         Left            =   1920
         TabIndex        =   9
         Top             =   2520
         Width           =   5535
      End
      Begin VB.TextBox Text10 
         Height          =   350
         Left            =   1920
         TabIndex        =   10
         Top             =   3000
         Width           =   2775
      End
      Begin VB.TextBox Text12 
         Height          =   350
         Left            =   1920
         TabIndex        =   12
         Top             =   3480
         Width           =   2775
      End
      Begin VB.PictureBox Picture5 
         BackColor       =   &H80000010&
         BorderStyle     =   0  'None
         Height          =   30
         Left            =   480
         ScaleHeight     =   30
         ScaleWidth      =   8895
         TabIndex        =   22
         Top             =   4440
         Width           =   8895
         Begin VB.PictureBox Picture6 
            BackColor       =   &H80000014&
            BorderStyle     =   0  'None
            Height          =   10
            Left            =   0
            ScaleHeight     =   15
            ScaleWidth      =   8895
            TabIndex        =   23
            Top             =   10
            Width           =   8895
         End
      End
      Begin VB.TextBox Text14 
         Height          =   350
         Left            =   1920
         TabIndex        =   14
         Top             =   3960
         Width           =   5535
      End
      Begin VB.TextBox Text15 
         Height          =   350
         Left            =   1920
         TabIndex        =   15
         Top             =   4560
         Width           =   7455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   " /"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   5520
         TabIndex        =   45
         Top             =   1440
         Width           =   255
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   " /"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4920
         TabIndex        =   44
         Top             =   1440
         Width           =   255
      End
      Begin VB.Label Label4 
         Caption         =   "First Name:"
         Height          =   255
         Left            =   480
         TabIndex        =   43
         Top             =   360
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Last Name:"
         Height          =   255
         Left            =   480
         TabIndex        =   42
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Middle Name:"
         Height          =   255
         Left            =   4800
         TabIndex        =   41
         Top             =   360
         Width           =   975
      End
      Begin VB.Label Label3 
         Caption         =   "Sex:"
         Height          =   255
         Left            =   480
         TabIndex        =   40
         Top             =   1440
         Width           =   1095
      End
      Begin VB.Label Label7 
         Caption         =   "Age:"
         Height          =   255
         Left            =   6840
         TabIndex        =   39
         Top             =   1440
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "Date Of Birth:"
         Height          =   255
         Left            =   3480
         TabIndex        =   38
         Top             =   1440
         Width           =   1095
      End
      Begin VB.Label Label9 
         Caption         =   "Place Of Birth:"
         Height          =   255
         Left            =   480
         TabIndex        =   37
         Top             =   1920
         Width           =   1095
      End
      Begin VB.Label Label10 
         Caption         =   "Address:"
         Height          =   255
         Left            =   480
         TabIndex        =   36
         Top             =   2520
         Width           =   1095
      End
      Begin VB.Label Label11 
         Caption         =   "Father's Name:"
         Height          =   255
         Left            =   480
         TabIndex        =   35
         Top             =   3000
         Width           =   1095
      End
      Begin VB.Label Label12 
         Caption         =   "Occupation:"
         Height          =   255
         Left            =   5040
         TabIndex        =   34
         Top             =   3000
         Width           =   975
      End
      Begin VB.Label Label13 
         Caption         =   "Mother's Name:"
         Height          =   255
         Left            =   480
         TabIndex        =   33
         Top             =   3480
         Width           =   1335
      End
      Begin VB.Label Label14 
         Caption         =   "Occupation:"
         Height          =   255
         Left            =   5040
         TabIndex        =   32
         Top             =   3480
         Width           =   975
      End
      Begin VB.Label Label15 
         Caption         =   "Parent Address:"
         Height          =   255
         Left            =   480
         TabIndex        =   31
         Top             =   3960
         Width           =   1335
      End
      Begin VB.Label Label16 
         Caption         =   "School Last Attend:"
         Height          =   255
         Left            =   480
         TabIndex        =   30
         Top             =   4560
         Width           =   1455
      End
      Begin VB.Label Label17 
         Caption         =   "Status:"
         Height          =   255
         Left            =   480
         TabIndex        =   29
         Top             =   5040
         Width           =   1095
      End
      Begin VB.Label Label18 
         Caption         =   "Date Enrolled:"
         Height          =   255
         Left            =   5040
         TabIndex        =   28
         Top             =   5040
         Width           =   1095
      End
   End
End
Attribute VB_Name = "Form6"
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
'------------------------------
'Check the required field
'------------------------------
If is_empty(Text2) = True Then Exit Sub
If is_empty(Text3) = True Then Exit Sub
If is_empty(Text4) = True Then Exit Sub
If is_empty(Text5) = True Then Exit Sub
If is_empty(Text6) = True Then Exit Sub
If is_empty(Text1) = True Then Exit Sub
If is_empty(Text17) = True Then Exit Sub
If is_empty(Text7) = True Then Exit Sub
If is_empty(Text8) = True Then Exit Sub
If is_empty(Text9) = True Then Exit Sub
If is_empty(Text10) = True Then Exit Sub
If is_empty(Text11) = True Then Exit Sub
If is_empty(Text12) = True Then Exit Sub
If is_empty(Text13) = True Then Exit Sub
If is_empty(Text14) = True Then Exit Sub
If is_empty(Text15) = True Then Exit Sub
If is_empty(Text16) = True Then Exit Sub
'------------------------------
'End checking
'------------------------------

'------------------------------
'Updating Database
'------------------------------
Dim c_no As Long
With rs_stud
    If add_state = True Then .AddNew: c_no = get_num("tblStudents", "StudentNo", cn): .Fields(0) = c_no: .Fields(11) = Form1.SY
        .Fields(1) = Text4.Text
        .Fields(2) = Text2.Text
        .Fields(3) = Text3.Text
        .Fields(4) = Text5.Text
        .Fields(5) = Format(Text6.Text & "/" & Text1.Text & "/" & Text17.Text, "mm/dd/yyyy")
        .Fields(6) = Text7.Text
        .Fields(7) = Text9.Text
        .Fields(8) = Text15.Text

        .Fields(12) = Text16.Text
        .Fields(13) = DTPicker1.Value
        .Fields(14) = Text8.Text
        .Fields(15) = Text10.Text
        .Fields(16) = Text11.Text
        .Fields(17) = Text12.Text
        .Fields(18) = Text13.Text
        .Fields(19) = Text14.Text
    .Update
End With
'------------------------------
'End-Updating Database
'------------------------------

'------------------------------
'Inform updates
'------------------------------
If add_state = True Then
    MsgBox "Adding of new enrollee has been successfull.", vbInformation, "CSRS version 1"
    Dim rep As Integer
    rep = MsgBox("Do you want to enroll another student?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbYes Then
        Command2_Click
        Call locate_new_rec(c_no)
    Else
        Call locate_new_rec(c_no)
        Unload Me
    End If
    rep = 0
    c_no = 0
Else
    MsgBox "Changes in record has been successfully saved.", vbInformation, "CSRS version 1"
    Dim pos As Long
    
    pos = rs_stud.AbsolutePosition
    Form1.reload_rec
    rs_stud.AbsolutePosition = pos
    
    Form1.ListView1.ListItems.Item(pos).EnsureVisible
    Form1.ListView1.ListItems.Item(pos).Selected = True
    
    pos = 0
    Unload Me
End If
'------------------------------
'End-Inform updates
'------------------------------
End Sub
Private Sub locate_new_rec(ByVal no As Long)
Form1.reload_rec
rs_stud.Find "StudentNo =" & no & ""
If rs_stud.EOF Then rs_stud.MoveFirst
Form1.ListView1.ListItems.Item(rs_stud.AbsolutePosition).EnsureVisible
Form1.ListView1.ListItems.Item(rs_stud.AbsolutePosition).Selected = True
End Sub
Private Sub Command2_Click()
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
Text4.Text = ""
Text5.Text = "Male"
Text6.Text = ""
Text7.Text = ""
Text8.Text = ""
Text9.Text = ""
Text10.Text = ""
Text11.Text = ""
Text12.Text = ""
Text13.Text = ""
Text14.Text = ""
Text15.Text = ""
Text16.Text = "New"
Text17.Text = ""
DTPicker1.Value = Date
Text2.SetFocus
End Sub

Private Sub Command3_Click()
Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)

If add_state = True Then
    Me.Caption = "Enroll New Student"
    DTPicker1.Value = Date
Else
    Me.Icon = ImageList1.ListImages(1).Picture
    Me.Caption = "Edit Existing Student"
    Command1.Caption = "&Save"
    
    '------------------------------
    'Get records
    '------------------------------
    With rs_stud
            Text4.Text = .Fields(1)
            Text2.Text = .Fields(2)
            Text3.Text = .Fields(3)
            Text5.Text = .Fields(4)
            
            Text6.Text = Format(.Fields(5), "mm")
            Text1.Text = Format(.Fields(5), "dd")
            Text17.Text = Format(.Fields(5), "yyyy")
            
            Text7.Text = .Fields(6)
            Text9.Text = .Fields(7)
            Text15.Text = .Fields(8)

            Text16.Text = .Fields(12)
            DTPicker1.Value = .Fields(13)
            Text8.Text = .Fields(14)
            Text10.Text = .Fields(15)
            Text11.Text = .Fields(16)
            Text12.Text = .Fields(17)
            Text13.Text = .Fields(18)
            Text14.Text = .Fields(19)
    End With
    '------------------------------
    'End-Get records
    '------------------------------
    
End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
Form1.Enabled = True

Call save_pos(Me)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text11_Validate(Cancel As Boolean)
If Not Text11.Text = "" And Len(Text11.Text) > 150 Then MsgBox "Please enter only 150 characters.", vbExclamation, "CSRS version 1": Cancel = True
End Sub

Private Sub Text13_Validate(Cancel As Boolean)
If Not Text13.Text = "" And Len(Text13.Text) > 150 Then MsgBox "Please enter only 150 characters.", vbExclamation, "CSRS version 1": Cancel = True
End Sub

Private Sub Text16_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Text16_Validate(Cancel As Boolean)
If Text16.Text <> "Drop" And Text16.Text <> "New" And Text16.Text <> "Old" Then MsgBox "Please select a valid entry in the list.", vbExclamation, "CSRS version 1": Cancel = True
End Sub

Private Sub Text17_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub
Private Sub Text3_GotFocus()
Call highlight_focus(Text3)
End Sub
Private Sub Text4_GotFocus()
Call highlight_focus(Text4)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text5_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Text6_GotFocus()
Call highlight_focus(Text6)
End Sub

Private Sub Text6_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text7_GotFocus()
Call highlight_focus(Text7)
End Sub
Private Sub Text8_GotFocus()
Call highlight_focus(Text8)
End Sub
Private Sub Text9_GotFocus()
Call highlight_focus(Text9)
End Sub
Private Sub Text10_GotFocus()
Call highlight_focus(Text10)
End Sub
Private Sub Text12_GotFocus()
Call highlight_focus(Text12)
End Sub
Private Sub Text14_GotFocus()
Call highlight_focus(Text14)
End Sub
Private Sub Text15_GotFocus()
Call highlight_focus(Text15)
End Sub

Private Sub Text5_Validate(Cancel As Boolean)
If Text5.Text <> "Male" And Text5.Text <> "Female" Then MsgBox "Please select a valid entry in the list.", vbExclamation, "CSRS version 1": Cancel = True
End Sub
Private Sub Text6_Validate(Cancel As Boolean)
If Text6.Text = "" Then Exit Sub
If Val(Text6.Text) = 0 Or Val(Text6.Text) > 12 Then MsgBox "Please enter a valid mm/dd/yyyy date format.", vbExclamation, "CSRS version 1": Cancel = True: Exit Sub
If Val(Text6.Text) < 10 Then Text6.Text = "0" & Right(Text6.Text, 1)
End Sub
Private Sub Text1_Validate(Cancel As Boolean)
If Text1.Text = "" Then Exit Sub
If Val(Text1.Text) = 0 Or Val(Text1.Text) > 31 Then MsgBox "Please enter a valid mm/dd/yyyy date format.", vbExclamation, "CSRS version 1": Cancel = True: Exit Sub
If Val(Text1.Text) < 10 Then Text1.Text = "0" & Right(Text1.Text, 1)
End Sub
Private Sub Text17_Validate(Cancel As Boolean)
If Text17.Text = "" Then Exit Sub
If Val(Text17.Text) < 1900 Or Val(Text17.Text) > 2100 Then MsgBox "Please enter a valid mm/dd/yyyy date format.", vbExclamation, "CSRS version 1": Cancel = True
End Sub

Private Sub Text7_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text7_Validate(Cancel As Boolean)
If Not Text7.Text = "" And Val(Text7.Text) < 1 Then MsgBox "Please enter the valid age of the student.", vbExclamation, "CSRS version 1": Cancel = True
End Sub
