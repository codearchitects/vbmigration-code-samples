VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form Form26 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "List of Users"
   ClientHeight    =   5805
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8025
   Icon            =   "Form26.frx":0000
   LinkTopic       =   "Form9"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   5805
   ScaleWidth      =   8025
   Begin VB.CommandButton Command1 
      Caption         =   "&Add"
      Default         =   -1  'True
      Height          =   350
      Left            =   1440
      TabIndex        =   2
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "E&dit"
      Height          =   350
      Left            =   2760
      TabIndex        =   3
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton Command4 
      Caption         =   "De&lete"
      Height          =   350
      Left            =   4080
      TabIndex        =   4
      Top             =   5280
      Width           =   1095
   End
   Begin VB.CommandButton Command5 
      Caption         =   "&Reload"
      Height          =   350
      Left            =   5280
      TabIndex        =   5
      Top             =   5280
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "&Close"
      Height          =   350
      Left            =   6600
      TabIndex        =   6
      Top             =   5280
      Width           =   1215
   End
   Begin TabDlg.SSTab SSTab1 
      Height          =   5055
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   7695
      _ExtentX        =   13573
      _ExtentY        =   8916
      _Version        =   393216
      Style           =   1
      Tabs            =   1
      TabsPerRow      =   1
      TabHeight       =   520
      TabCaption(0)   =   "General "
      TabPicture(0)   =   "Form26.frx":038A
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "ListView1"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "Frame1"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).ControlCount=   2
      Begin VB.Frame Frame1 
         Height          =   735
         Left            =   240
         TabIndex        =   8
         Top             =   4080
         Width           =   7215
         Begin VB.TextBox Text1 
            Height          =   300
            Left            =   1680
            TabIndex        =   1
            Top             =   240
            Width           =   5295
         End
         Begin VB.Label Label1 
            Caption         =   "Enter text to search:"
            Height          =   255
            Left            =   120
            TabIndex        =   9
            Top             =   345
            Width           =   1575
         End
      End
      Begin MSComctlLib.ListView ListView1 
         Height          =   3450
         Left            =   240
         TabIndex        =   0
         Top             =   600
         Width           =   7215
         _ExtentX        =   12726
         _ExtentY        =   6085
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
         NumItems        =   4
         BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            Text            =   "No."
            Object.Width           =   1058
         EndProperty
         BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   1
            Text            =   "User Name"
            Object.Width           =   7956
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Type"
            Object.Width           =   5080
         EndProperty
         BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   3
            Text            =   "Password"
            Object.Width           =   3422
         EndProperty
      End
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
            Picture         =   "Form26.frx":03A6
            Key             =   ""
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "Form26"
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


Private Sub Command1_Click()
Form27.add_state = True
Form27.Show
Me.Enabled = False
End Sub

Private Sub Command2_Click()
If rs_log.RecordCount < 1 Then MsgBox "No user in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If Not rs_log.RecordCount < 1 Then rs_log.AbsolutePosition = ListView1.SelectedItem
Form27.add_state = False
Form27.Show
Me.Enabled = False
End Sub

Private Sub Command4_Click()
On Error GoTo Err:
With rs_log
    '---------------------------------
    'Check if there is no record
    '---------------------------------
    If .RecordCount < 1 Then MsgBox "No user in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
    If Not rs_log.RecordCount < 1 Then rs_log.AbsolutePosition = ListView1.SelectedItem
    If LCase(.Fields(1)) = LCase(user_name) Then MsgBox "Cannot delete because user is curently logged.", vbExclamation, "CSRS version 1": Exit Sub
    
    '---------------------------------
    'Confirm deletion of record
    '---------------------------------
    Dim ans As Integer
    Dim pos As Integer
    ans = MsgBox("Are you sure you want to delete the selected record?", vbCritical + vbYesNo, "Confirm Record Delete")
    Me.MousePointer = vbHourglass
    If ans = vbYes Then
        '-----------------------------
        'Delete the record
        '-----------------------------
        pos = Val(ListView1.SelectedItem)
        Call delete_rec(cn, "Users", "Username", ListView1.SelectedItem.ListSubItems(1), False, 0)
        .Requery
        If .RecordCount > 0 Then
            .AbsolutePosition = pos
            If .EOF Then .MoveFirst
            '---------------------------------
            'Fill listview
            '---------------------------------
            pos = .AbsolutePosition
            load_rec
            ListView1.ListItems.Item(pos).EnsureVisible
            ListView1.ListItems.Item(pos).Selected = True
            .AbsolutePosition = ListView1.SelectedItem
            '---------------------------------
            'End-fill listview
            '---------------------------------
        Else
            ListView1.ListItems.Clear
        End If
        MsgBox "Record has been successfully deleted.", vbInformation, "Confirm"
    End If
    ans = 0
    pos = 0
    Me.MousePointer = vbDefault
End With
Exit Sub
Err:
    prompt_err (Err.Description & vbCrLf & vbCrLf & "Error Number: " & Err.Number): Me.MousePointer = vbDefault: Exit Sub
End Sub

Private Sub Command5_Click()
rs_log.Requery
load_rec
End Sub

Private Sub Command6_Click()
Unload Me
End Sub

Private Sub Form_Activate()

If Not rs_log.RecordCount < 1 Then rs_log.AbsolutePosition = ListView1.SelectedItem
Command1.SetFocus
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Me.Caption = Me.Caption
Call set_rec_getData(rs_log, cn, "Select Users.* From Users Order by Username Asc")
load_rec
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_log = Nothing

Call save_pos(Me)
End Sub
Sub load_rec()
Screen.MousePointer = vbHourglass

Call FillListView(ListView1, rs_log, 4, 1, True, False)

Screen.MousePointer = vbDefault
End Sub
Private Sub ListView1_Click()

If Not rs_log.RecordCount < 1 Then rs_log.AbsolutePosition = ListView1.SelectedItem
End Sub

Private Sub Text1_Change()
If ListView1.ListItems.Count < 1 Then Exit Sub
Call search_in_listview(ListView1, Text1.Text)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub
