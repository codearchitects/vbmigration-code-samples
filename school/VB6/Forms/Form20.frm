VERSION 5.00
Object = "{F0D2F211-CCB0-11D0-A316-00AA00688B10}#1.0#0"; "MSDATLST.OCX"
Begin VB.Form Form20 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Print Option for Student List"
   ClientHeight    =   1245
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4110
   Icon            =   "Form20.frx":0000
   LinkTopic       =   "Form20"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   1245
   ScaleWidth      =   4110
   Begin VB.CheckBox Check1 
      Caption         =   "Include Drop"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   720
      Width           =   1335
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   3855
      TabIndex        =   5
      Top             =   600
      Width           =   3855
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   6
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Print"
      Default         =   -1  'True
      Height          =   350
      Left            =   1680
      TabIndex        =   2
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   3000
      TabIndex        =   3
      Top             =   720
      Width           =   975
   End
   Begin MSDataListLib.DataCombo DataCombo1 
      Height          =   315
      Left            =   1440
      TabIndex        =   0
      Top             =   120
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   556
      _Version        =   393216
      BackColor       =   15138815
      Text            =   ""
   End
   Begin VB.Label Label3 
      Caption         =   "School Year: "
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   975
   End
End
Attribute VB_Name = "Form20"
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

Dim rs_prnt_list As New ADODB.Recordset




Private Sub Command1_Click()
If is_empty(DataCombo1) = True Then Exit Sub
If Len(DataCombo1.Text) < 9 Or Mid(DataCombo1.Text, 5, 1) <> "-" Then MsgBox "Enry must be in this format (ex. yyyy-yyyy).", vbExclamation, "CSRS version 1": DataCombo1.SetFocus: Exit Sub

If Check1.Value = 1 Then
    rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "'"
Else
    rs_prnt_list.Filter = "SchoolYear ='" & DataCombo1.Text & "' And Status <>'Drop'"
End If

If rs_prnt_list.RecordCount < 1 Then
    MsgBox "The selected school year does not have student record.", vbExclamation, "CSRS version 1"
    DataCombo1.SetFocus
    Exit Sub
End If

With rpt_header
    .SchoolAddress = school_address
    .SchoolName = school_name
    .SY = "S.Y.  " & rs_prnt_list(11)
End With

Set DataReport4.DataSource = rs_prnt_list
DataReport4.Show vbModal

End Sub

Private Sub Command2_Click()
Unload Me
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

Call set_rec_getData(rs_prnt_list, cn, "Select qryStudents.* From qryStudents Order by Sex Desc,LastName Asc,FirstName Asc")

End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_prnt_list = Nothing

Call save_pos(Me)
End Sub
