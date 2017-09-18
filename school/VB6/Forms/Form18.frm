VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form18 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Select Section"
   ClientHeight    =   4800
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3990
   Icon            =   "Form18.frx":0000
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   4800
   ScaleWidth      =   3990
   Begin VB.CommandButton Command3 
      Height          =   300
      Left            =   3480
      Picture         =   "Form18.frx":038A
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   300
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   3600
      Top             =   3840
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
            Picture         =   "Form18.frx":0714
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.TextBox Text2 
      BackColor       =   &H00E6FFFF&
      Height          =   300
      Left            =   1200
      Locked          =   -1  'True
      TabIndex        =   0
      Top             =   120
      Width           =   2295
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Close"
      Default         =   -1  'True
      Height          =   350
      Left            =   2640
      TabIndex        =   3
      Top             =   4320
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   30
      Left            =   120
      ScaleHeight     =   30
      ScaleWidth      =   3735
      TabIndex        =   4
      Top             =   4200
      Width           =   3735
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
   Begin MSComctlLib.ListView ListView1 
      Height          =   3570
      Left            =   120
      TabIndex        =   2
      Top             =   600
      Width           =   3735
      _ExtentX        =   6588
      _ExtentY        =   6297
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
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "No."
         Object.Width           =   1411
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "sec_no"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Section"
         Object.Width           =   5028
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "mina"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "maxa"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "allwd"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.Label Label2 
      Caption         =   "Level:"
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   975
   End
End
Attribute VB_Name = "Form18"
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


Public gen_ave As Integer
Public lv_id As Long

Dim rs_sel_sec As New ADODB.Recordset
Private Sub Command1_Click()
If ListView1.ListItems.Count < 1 Then Unload Me: Exit Sub

Form17.prnt_sec = ListView1.SelectedItem.ListSubItems(1)
Form17.Text2 = ListView1.SelectedItem.ListSubItems(2)
Unload Me

End Sub

Private Sub Command3_Click()
Form19.Show: Me.Enabled = False
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Call set_rec_getData(rs_sel_sec, cn, "Select qrySections.* From qrySections Order by MinAve Desc")

End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_sel_sec = Nothing
Form17.Enabled = True

Call save_pos(Me)
End Sub

Private Sub Text2_Change()

rs_sel_sec.Filter = "LevelNo = " & lv_id

load_rec
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
Command3_Click
End Sub
Sub load_rec()
Screen.MousePointer = vbHourglass

rs_sel_sec.Requery
Call FillListView(ListView1, rs_sel_sec, 6, 1, True, True)

Screen.MousePointer = vbDefault
If ListView1.ListItems.Count < 1 Then
    Command1.Caption = "&Close"
Else
    Command1.Caption = "&Select"
End If
End Sub

