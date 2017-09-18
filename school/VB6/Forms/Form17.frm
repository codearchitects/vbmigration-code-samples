VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form17 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Print Option For Student Record"
   ClientHeight    =   5040
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10095
   Icon            =   "Form17.frx":0000
   LinkTopic       =   "Form17"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   5040
   ScaleWidth      =   10095
   Begin MSDataListLib.DataCombo DataCombo1 
      Height          =   315
      Left            =   4680
      TabIndex        =   1
      Top             =   120
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   556
      _Version        =   393216
      BackColor       =   15138815
      Text            =   ""
   End
   Begin VB.ComboBox Text5 
      BackColor       =   &H00E6FFFF&
      Height          =   315
      ItemData        =   "Form17.frx":058A
      Left            =   2040
      List            =   "Form17.frx":0594
      TabIndex        =   0
      Text            =   "No"
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton Command7 
      Caption         =   "&Close"
      Height          =   350
      Left            =   8640
      TabIndex        =   9
      Top             =   4560
      Width           =   1335
   End
   Begin VB.CommandButton Command5 
      Caption         =   "&Load Record"
      Height          =   350
      Left            =   6960
      TabIndex        =   8
      Top             =   4560
      Width           =   1575
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Print All &Student in the List"
      Height          =   350
      Left            =   3960
      TabIndex        =   7
      Top             =   4560
      Width           =   2175
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Print &Individual Record"
      Height          =   350
      Left            =   2040
      TabIndex        =   6
      Top             =   4560
      Width           =   1815
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   9855
      TabIndex        =   12
      Top             =   4440
      Width           =   9855
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   9855
         TabIndex        =   13
         Top             =   10
         Width           =   9855
      End
   End
   Begin VB.CommandButton Command3 
      Height          =   300
      Left            =   9720
      Picture         =   "Form17.frx":05A1
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   120
      Width           =   300
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H00E6FFFF&
      Height          =   300
      Left            =   7440
      Locked          =   -1  'True
      TabIndex        =   2
      Top             =   120
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Print &Registration Slip"
      Default         =   -1  'True
      Height          =   350
      Left            =   120
      TabIndex        =   5
      Top             =   4560
      Width           =   1815
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   3570
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   9855
      _ExtentX        =   17383
      _ExtentY        =   6297
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      _Version        =   393217
      Icons           =   "ImageList1"
      SmallIcons      =   "ImageList1"
      ColHdrIcons     =   "ImageList1"
      ForeColor       =   8388608
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "No."
         Object.Width           =   1411
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "id"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Last Name"
         Object.Width           =   4764
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "First Name"
         Object.Width           =   4764
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Middle Name"
         Object.Width           =   4764
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Sex"
         Object.Width           =   1588
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   6240
      Top             =   4560
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
            Picture         =   "Form17.frx":092B
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Label Label4 
      Caption         =   "Include Dropped Student:"
      Height          =   255
      Left            =   120
      TabIndex        =   15
      Top             =   120
      Width           =   2175
   End
   Begin VB.Label Label3 
      Caption         =   "School Year: "
      Height          =   255
      Left            =   3600
      TabIndex        =   14
      Top             =   120
      Width           =   975
   End
   Begin VB.Label Label2 
      Caption         =   "Section:"
      Height          =   255
      Left            =   6720
      TabIndex        =   11
      Top             =   120
      Width           =   735
   End
   Begin VB.Label Label1 
      Caption         =   "List of Students:"
      Height          =   255
      Left            =   120
      TabIndex        =   10
      Top             =   600
      Width           =   1815
   End
End
Attribute VB_Name = "Form17"
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

Public prnt_sec As Long

Dim rs_prnt_stud As New ADODB.Recordset

Private Sub SSTab1_DblClick()

End Sub

Private Sub Command1_Click()
If ListView1.ListItems.Count < 1 Then MsgBox "No student record to print.", vbExclamation, "CSRS version 1": Exit Sub
If Not rs_prnt_stud.RecordCount < 1 Then rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem


With rpt_header
    .SchoolAddress = school_address
    .SchoolName = school_name
    .SY = "S.Y.  " & rs_prnt_stud.Fields(11)
End With

Dim rpt_rs As New ADODB.Recordset

Call set_rec_getData(rpt_rs, cn, "Select qryStudents.* From qryStudents Where StudentNo =" & rs_prnt_stud.Fields(0) & " Order by Sex Desc,LastName Asc")

Set DataReport1.DataSource = rpt_rs
DataReport1.Show vbModal

Set rpt_rs = Nothing
End Sub

Private Sub Command2_Click()
If ListView1.ListItems.Count < 1 Then MsgBox "No student record to print.", vbExclamation, "CSRS version 1": Exit Sub
If rs_prnt_stud.RecordCount < 1 Then Exit Sub


With rpt_header
    .SchoolAddress = school_address
    .SchoolName = school_name
    .SY = "S.Y.  " & DataCombo1.Text
End With

Set DataReport2.DataSource = rs_prnt_stud
DataReport2.Show vbModal

End Sub

Private Sub Command3_Click()
Form18.Show: Me.Enabled = False
End Sub

Private Sub Command4_Click()
If ListView1.ListItems.Count < 1 Then MsgBox "No student record to print.", vbExclamation, "CSRS version 1": Exit Sub
If Not ListView1.SelectedItem = "" And Not rs_prnt_stud.RecordCount < 1 Then rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem

On Error Resume Next

Kill Environ("TMP") & "\SupportDB.mdb"
FileCopy App.Path & "\SupportDB.db", Environ("TMP") & "\SupportDB.mdb"

Dim cn_tmp As New ADODB.Connection
Dim rs_tmp As New ADODB.Recordset
Dim pos, c As Long

Call set_conn_getData(cn_tmp, Environ("TMP") & "\SupportDB.mdb", True, "reg386")
Call set_rec_getData(rs_tmp, cn_tmp, "Select tblStudent.* From tblStudent")

With rs_prnt_stud
    pos = .AbsolutePosition
    
    .MoveFirst
    For c = 1 To .RecordCount
        rs_tmp.AddNew
            rs_tmp.Fields(0) = c
            rs_tmp.Fields(1) = .Fields(23)
        rs_tmp.Update
        
        .MoveNext
    Next c

    .AbsolutePosition = pos
End With

rs_tmp.Requery

With rpt_header
    .SchoolAddress = school_address
    .SchoolName = school_name
    .SY = "S.Y.  " & rs_prnt_stud.Fields(11)
    .SectionName = rs_prnt_stud.Fields("LevelName") & " - " & Text2.Text
End With

Set DataReport3.DataSource = rs_tmp
DataReport3.Show vbModal

Set rs_tmp = Nothing
Set cn_tmp = Nothing
End Sub

Private Sub Command5_Click()
If is_empty(DataCombo1) = True Then Exit Sub
If is_empty(Text2) = True Then Exit Sub
If Len(DataCombo1.Text) < 9 Or Mid(DataCombo1.Text, 5, 1) <> "-" Then MsgBox "Enry must be in this format (ex. yyyy-yyyy).", vbExclamation, "CSRS version 1": DataCombo1.SetFocus: Exit Sub

rs_prnt_stud.Filter = adFilterNone
rs_prnt_stud.Requery
If Text5.Text = "No" Then
    rs_prnt_stud.Filter = "SchoolYear ='" & DataCombo1.Text & "' And Status <>'Drop' And SN =" & prnt_sec
Else
    rs_prnt_stud.Filter = "SchoolYear ='" & DataCombo1.Text & "' And SN =" & prnt_sec
End If
Call fill_rec
End Sub

Private Sub Command7_Click()
Unload Me
End Sub

Private Sub DataCombo1_Change()
Text2.Text = ""
End Sub

Private Sub DataCombo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Dim rs_sy As New ADODB.Recordset
Call set_rec_getData(rs_sy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")

Set DataCombo1.RowSource = rs_sy
DataCombo1.ListField = "SchoolYear"

Set rs_sy = Nothing

Call set_rec_getData(rs_prnt_stud, cn, "Select qryStudents.* From qryStudents Order by Sex Desc,LastName Asc,FirstName Asc")
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_prnt_stud = Nothing

Call save_pos(Me)
End Sub

Private Sub ListView1_Click()

If Not rs_prnt_stud.RecordCount < 1 Then rs_prnt_stud.AbsolutePosition = ListView1.SelectedItem
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
Command3_Click
End Sub

Private Sub Text5_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Text5_Validate(Cancel As Boolean)
If Text5.Text <> "No" And Text5.Text <> "Yes" Then MsgBox "Please select a valid entry in the list.", vbExclamation, "CSRS version 1": Cancel = True
End Sub
Public Sub fill_rec()

Screen.MousePointer = vbHourglass

Call FillListView(ListView1, rs_prnt_stud, 6, 1, True, True)
If Not rs_prnt_stud.RecordCount < 1 Then rs_prnt_stud.MoveFirst

Screen.MousePointer = vbDefault
End Sub
