VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form2 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Select School Year"
   ClientHeight    =   4725
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3915
   Icon            =   "Form2.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   4725
   ScaleWidth      =   3915
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   3615
      TabIndex        =   3
      Top             =   4080
      Width           =   3615
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   4
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Select"
      Default         =   -1  'True
      Height          =   350
      Left            =   1440
      TabIndex        =   1
      Top             =   4200
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   2760
      TabIndex        =   2
      Top             =   4200
      Width           =   975
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   3930
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3615
      _ExtentX        =   6376
      _ExtentY        =   6932
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      FullRowSelect   =   -1  'True
      _Version        =   393217
      Icons           =   "ImageList1"
      SmallIcons      =   "ImageList1"
      ForeColor       =   8388608
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   3
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "No."
         Object.Width           =   1411
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "School Year"
         Object.Width           =   3263
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Status"
         Object.Width           =   1587
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   0
      Top             =   0
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
            Picture         =   "Form2.frx":038A
            Key             =   ""
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "Form2"
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

Dim rs_ssy As New ADODB.Recordset

Private Sub Command1_Click()
With Form1
    .SY = ListView1.SelectedItem.ListSubItems(1)
    .sy_stat = ListView1.SelectedItem.ListSubItems(2)
    .Show
    frm_stud_show = True
End With
Unload Me
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub DataCombo1_Change()
Me.Caption = rs_ssy.Fields(0)
End Sub
Private Sub Form_Load()
Call use_pos(Me)

Call set_rec_getData(rs_ssy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")
If rs_ssy.RecordCount < 1 Then Command1.Visible = False: Exit Sub
'----------------------------------
'Fill the list view
'----------------------------------
Call FillListView(ListView1, rs_ssy, 3, 1, True, True)
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_ssy = Nothing

Call save_pos(Me)
End Sub

