VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form19 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Select Level"
   ClientHeight    =   3720
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3165
   Icon            =   "Form19.frx":0000
   LinkTopic       =   "Form5"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   3720
   ScaleWidth      =   3165
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
            Picture         =   "Form19.frx":038A
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   2895
      TabIndex        =   2
      Top             =   3120
      Width           =   2895
      Begin VB.PictureBox Picture2 
         BackColor       =   &H80000014&
         BorderStyle     =   0  'None
         Height          =   10
         Left            =   0
         ScaleHeight     =   15
         ScaleWidth      =   8895
         TabIndex        =   3
         Top             =   10
         Width           =   8895
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Select"
      Default         =   -1  'True
      Height          =   350
      Left            =   1800
      TabIndex        =   1
      Top             =   3240
      Width           =   1215
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   2730
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   2895
      _ExtentX        =   5106
      _ExtentY        =   4815
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
         Object.Width           =   1058
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "yr_no"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Level"
         Object.Width           =   3899
      EndProperty
   End
   Begin VB.Label Label1 
      Caption         =   "List of level:"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1095
   End
End
Attribute VB_Name = "Form19"
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

Dim rs_sel_lv As New ADODB.Recordset

Private Sub Command1_Click()
If ListView1.ListItems.Count < 1 Then Unload Me: Exit Sub
Form18.lv_id = ListView1.SelectedItem.ListSubItems(1)
Form18.Text2 = ListView1.SelectedItem.ListSubItems(2)
Unload Me
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Call set_rec_getData(rs_sel_lv, cn, "Select tblLevel.* From tblLevel Order by LevelNo Asc")
load_rec
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_sel_lv = Nothing
Form18.Enabled = True

Call save_pos(Me)
End Sub
Sub load_rec()
Screen.MousePointer = vbHourglass

Call FillListView(ListView1, rs_sel_lv, 3, 1, True, True)

Screen.MousePointer = vbDefault
If ListView1.ListItems.Count < 1 Then Command1.Caption = "&Cancel"
End Sub

