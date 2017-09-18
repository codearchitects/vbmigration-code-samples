VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form Form11 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "List of School Year"
   ClientHeight    =   5040
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5940
   Icon            =   "Form11.frx":0000
   LinkTopic       =   "Form9"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   5040
   ScaleWidth      =   5940
   Begin VB.CommandButton Command1 
      Caption         =   "&Add"
      Default         =   -1  'True
      Height          =   350
      Left            =   840
      TabIndex        =   2
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton Command2 
      Caption         =   "E&dit"
      Height          =   350
      Left            =   1800
      TabIndex        =   3
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton Command4 
      Caption         =   "De&lete"
      Height          =   350
      Left            =   2760
      TabIndex        =   4
      Top             =   4560
      Width           =   855
   End
   Begin VB.CommandButton Command5 
      Caption         =   "&Reload"
      Height          =   350
      Left            =   3720
      TabIndex        =   5
      Top             =   4560
      Width           =   975
   End
   Begin VB.CommandButton Command6 
      Caption         =   "&Close"
      Height          =   350
      Left            =   4800
      TabIndex        =   6
      Top             =   4560
      Width           =   975
   End
   Begin TabDlg.SSTab SSTab1 
      Height          =   4335
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   7646
      _Version        =   393216
      Style           =   1
      Tabs            =   1
      TabsPerRow      =   1
      TabHeight       =   617
      TabCaption(0)   =   "General "
      TabPicture(0)   =   "Form11.frx":038A
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label21"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "ListView1"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "Frame1"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "Command9"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "Command10"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).ControlCount=   5
      Begin VB.CommandButton Command10 
         Height          =   300
         Left            =   5355
         Picture         =   "Form11.frx":03A6
         Style           =   1  'Graphical
         TabIndex        =   10
         ToolTipText     =   "Re-Open School Year"
         Top             =   0
         Width           =   300
      End
      Begin VB.CommandButton Command9 
         Height          =   300
         Left            =   5040
         Picture         =   "Form11.frx":0730
         Style           =   1  'Graphical
         TabIndex        =   11
         ToolTipText     =   "Close School Year"
         Top             =   0
         Width           =   300
      End
      Begin VB.Frame Frame1 
         Height          =   735
         Left            =   240
         TabIndex        =   8
         Top             =   3360
         Width           =   5175
         Begin VB.TextBox Text1 
            Height          =   300
            Left            =   1680
            TabIndex        =   1
            Top             =   240
            Width           =   3255
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
         Height          =   2730
         Left            =   240
         TabIndex        =   0
         Top             =   600
         Width           =   5175
         _ExtentX        =   9128
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
            Text            =   "School Year"
            Object.Width           =   6527
         EndProperty
         BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
            SubItemIndex    =   2
            Text            =   "Status"
            Object.Width           =   1429
         EndProperty
      End
      Begin VB.Label Label21 
         BackStyle       =   0  'Transparent
         Caption         =   "Option:"
         Height          =   255
         Left            =   4440
         TabIndex        =   12
         Top             =   0
         Width           =   615
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
            Picture         =   "Form11.frx":0ABA
            Key             =   ""
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "Form11"
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


Private Sub Command1_Click()
Form12.add_state = True
Form12.Show
Me.Enabled = False
End Sub

Private Sub Command10_Click()
If rs_sy.RecordCount < 1 Then MsgBox "No school year in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If rs_sy.Fields(1) = "Open" Then
    MsgBox "The school year is not closed.Please select a closed school year to re-open.", vbExclamation, "CSRS version 1"
Else
    Dim rep As Integer
    rep = MsgBox("Are you sure you want to re-open the selected school year?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbNo Then Exit Sub:
    rep = 0
    Dim pos As Long
    With rs_sy
        pos = .AbsolutePosition
        .Fields(1) = "Open"
        .Update
        
        .Requery
        Call load_rec
        .AbsolutePosition = pos
        
        ListView1.ListItems.Item(Val(.AbsolutePosition)).EnsureVisible
        ListView1.ListItems.Item(Val(.AbsolutePosition)).Selected = True

        
        MsgBox "The school year was sucessfully re-opened.", vbInformation, "CSRS version 1"
        pos = 0
    End With
End If
End Sub

Private Sub Command2_Click()
If rs_sy.RecordCount < 1 Then MsgBox "No school year in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If Not ListView1.SelectedItem = "" And Not rs_sy.RecordCount < 1 Then rs_sy.AbsolutePosition = ListView1.SelectedItem
Form12.add_state = False
Form12.Show
Me.Enabled = False
End Sub

Private Sub Command4_Click()
On Error GoTo Err:
With rs_sy
    '---------------------------------
    'Check if there is no record
    '---------------------------------
    If .RecordCount < 1 Then MsgBox "No school year in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
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
        Call delete_rec(cn, "tblSchoolYear", "SchoolYear", ListView1.SelectedItem.ListSubItems(1), False, 0)
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
rs_sy.Requery
load_rec
End Sub

Private Sub Command6_Click()
Unload Me
End Sub

Private Sub Command9_Click()
If rs_sy.RecordCount < 1 Then MsgBox "No school year in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If rs_sy.Fields(1) = "Close" Then
    MsgBox "The school year was already closed.", vbExclamation, "CSRS version 1"
Else
    Dim rep As Integer
    rep = MsgBox("Are you sure you want to close the selected school year?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbNo Then Exit Sub:
    rep = 0
    Dim pos As Long
    With rs_sy
        pos = .AbsolutePosition
        .Fields(1) = "Close"
        .Update
        
        .Requery
        Call load_rec
        .AbsolutePosition = pos
        
        ListView1.ListItems.Item(Val(.AbsolutePosition)).EnsureVisible
        ListView1.ListItems.Item(Val(.AbsolutePosition)).Selected = True

        
        MsgBox "The school year was sucessfully closed.", vbInformation, "CSRS version 1"
        pos = 0
    End With
End If

End Sub

Private Sub Form_Activate()

If Not rs_sy.RecordCount < 1 Then rs_sy.AbsolutePosition = ListView1.SelectedItem
Command1.SetFocus
End Sub

Private Sub Form_Load()
Call use_pos(Me)

Call set_rec_getData(rs_sy, cn, "Select tblSchoolYear.* From tblSchoolYear Order by SchoolYear Asc")
load_rec
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set rs_sy = Nothing

Call save_pos(Me)
End Sub
Sub load_rec()
Screen.MousePointer = vbHourglass

Call FillListView(ListView1, rs_sy, 3, 1, True, True)

Screen.MousePointer = vbDefault
End Sub
Private Sub ListView1_Click()

If Not rs_sy.RecordCount < 1 Then rs_sy.AbsolutePosition = ListView1.SelectedItem
End Sub

Private Sub Text1_Change()
If ListView1.ListItems.Count < 1 Then Exit Sub
Call search_in_listview(ListView1, Text1.Text)
End Sub
Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub
