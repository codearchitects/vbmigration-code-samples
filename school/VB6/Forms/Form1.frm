VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Student Record"
   ClientHeight    =   6825
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10635
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   6825
   ScaleWidth      =   10635
   Begin VB.CommandButton Command6 
      Caption         =   "&Close"
      Height          =   350
      Left            =   9120
      TabIndex        =   6
      Top             =   6360
      Width           =   1335
   End
   Begin VB.CommandButton Command5 
      Caption         =   "&Reload Record"
      Height          =   350
      Left            =   7440
      TabIndex        =   5
      Top             =   6360
      Width           =   1575
   End
   Begin VB.CommandButton Command4 
      Caption         =   "De&lete"
      Height          =   350
      Left            =   6240
      TabIndex        =   4
      Top             =   6360
      Width           =   1095
   End
   Begin VB.CommandButton Command3 
      Caption         =   "&Show/Assign Section"
      Height          =   350
      Left            =   4200
      TabIndex        =   3
      Top             =   6360
      Width           =   1935
   End
   Begin VB.CommandButton Command2 
      Caption         =   "E&dit"
      Height          =   350
      Left            =   3120
      TabIndex        =   2
      Top             =   6360
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Enroll New"
      Default         =   -1  'True
      Height          =   350
      Left            =   1800
      TabIndex        =   1
      Top             =   6360
      Width           =   1215
   End
   Begin TabDlg.SSTab SSTab1 
      Height          =   6135
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   10335
      _ExtentX        =   18230
      _ExtentY        =   10821
      _Version        =   393216
      Style           =   1
      Tabs            =   2
      TabsPerRow      =   2
      TabHeight       =   617
      ShowFocusRect   =   0   'False
      TabCaption(0)   =   "Student List"
      TabPicture(0)   =   "Form1.frx":038A
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Label21"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "ImageList1"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "ListView1"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "Frame1"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).Control(4)=   "Command9"
      Tab(0).Control(4).Enabled=   0   'False
      Tab(0).Control(5)=   "Command10"
      Tab(0).Control(5).Enabled=   0   'False
      Tab(0).ControlCount=   6
      TabCaption(1)   =   "Student Information"
      TabPicture(1)   =   "Form1.frx":03A6
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame2"
      Tab(1).ControlCount=   1
      Begin VB.CommandButton Command10 
         Height          =   300
         Left            =   10030
         Picture         =   "Form1.frx":03C2
         Style           =   1  'Graphical
         TabIndex        =   58
         ToolTipText     =   "Undrop Student"
         Top             =   0
         Width           =   300
      End
      Begin VB.CommandButton Command9 
         Height          =   300
         Left            =   9720
         Picture         =   "Form1.frx":074C
         Style           =   1  'Graphical
         TabIndex        =   57
         ToolTipText     =   "Drop Student"
         Top             =   0
         Width           =   300
      End
      Begin VB.Frame Frame2 
         Caption         =   "General Information"
         Height          =   5295
         Left            =   -74760
         TabIndex        =   16
         Top             =   600
         Width           =   9855
         Begin VB.TextBox Text17 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   6120
            Locked          =   -1  'True
            TabIndex        =   54
            Top             =   4920
            Width           =   3255
         End
         Begin VB.TextBox Text16 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   53
            Top             =   4920
            Width           =   1455
         End
         Begin VB.TextBox Text15 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   50
            Top             =   4560
            Width           =   7455
         End
         Begin VB.TextBox Text14 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   48
            Top             =   3960
            Width           =   5535
         End
         Begin VB.PictureBox Picture5 
            BackColor       =   &H80000010&
            BorderStyle     =   0  'None
            Height          =   30
            Left            =   480
            ScaleHeight     =   30
            ScaleWidth      =   8895
            TabIndex        =   45
            Top             =   4440
            Width           =   8895
            Begin VB.PictureBox Picture6 
               BackColor       =   &H80000014&
               BorderStyle     =   0  'None
               Height          =   10
               Left            =   0
               ScaleHeight     =   15
               ScaleWidth      =   8895
               TabIndex        =   46
               Top             =   10
               Width           =   8895
            End
         End
         Begin VB.TextBox Text13 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   6000
            Locked          =   -1  'True
            TabIndex        =   44
            Top             =   3480
            Width           =   3375
         End
         Begin VB.TextBox Text12 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   42
            Top             =   3480
            Width           =   2775
         End
         Begin VB.TextBox Text11 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   6000
            Locked          =   -1  'True
            TabIndex        =   40
            Top             =   3000
            Width           =   3375
         End
         Begin VB.TextBox Text10 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   38
            Top             =   3000
            Width           =   2775
         End
         Begin VB.TextBox Text9 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   36
            Top             =   2520
            Width           =   5535
         End
         Begin VB.PictureBox Picture3 
            BackColor       =   &H80000010&
            BorderStyle     =   0  'None
            Height          =   30
            Left            =   480
            ScaleHeight     =   30
            ScaleWidth      =   8895
            TabIndex        =   33
            Top             =   2400
            Width           =   8895
            Begin VB.PictureBox Picture4 
               BackColor       =   &H80000014&
               BorderStyle     =   0  'None
               Height          =   10
               Left            =   0
               ScaleHeight     =   15
               ScaleWidth      =   8895
               TabIndex        =   34
               Top             =   10
               Width           =   8895
            End
         End
         Begin VB.TextBox Text8 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   32
            Top             =   1920
            Width           =   5535
         End
         Begin VB.TextBox Text7 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   7680
            Locked          =   -1  'True
            TabIndex        =   30
            Top             =   1440
            Width           =   1695
         End
         Begin VB.TextBox Text6 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   4560
            Locked          =   -1  'True
            TabIndex        =   29
            Top             =   1440
            Width           =   2175
         End
         Begin VB.TextBox Text5 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   28
            Top             =   1440
            Width           =   1215
         End
         Begin VB.TextBox Text4 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   23
            Top             =   840
            Width           =   3495
         End
         Begin VB.TextBox Text3 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   5880
            Locked          =   -1  'True
            TabIndex        =   22
            Top             =   360
            Width           =   3495
         End
         Begin VB.TextBox Text2 
            BackColor       =   &H8000000F&
            BorderStyle     =   0  'None
            Height          =   350
            Left            =   1920
            Locked          =   -1  'True
            TabIndex        =   21
            Top             =   360
            Width           =   2655
         End
         Begin VB.PictureBox Picture1 
            BackColor       =   &H80000010&
            BorderStyle     =   0  'None
            Height          =   30
            Left            =   480
            ScaleHeight     =   30
            ScaleWidth      =   8895
            TabIndex        =   20
            Top             =   1320
            Width           =   8895
            Begin VB.PictureBox Picture2 
               BackColor       =   &H80000014&
               BorderStyle     =   0  'None
               Height          =   10
               Left            =   0
               ScaleHeight     =   15
               ScaleWidth      =   8895
               TabIndex        =   24
               Top             =   10
               Width           =   8895
            End
         End
         Begin VB.Label Label18 
            Caption         =   "Date Enrolled:"
            Height          =   255
            Left            =   4800
            TabIndex        =   52
            Top             =   4920
            Width           =   1335
         End
         Begin VB.Label Label17 
            Caption         =   "Status:"
            Height          =   255
            Left            =   480
            TabIndex        =   51
            Top             =   4920
            Width           =   1095
         End
         Begin VB.Label Label16 
            Caption         =   "School Last Attend:"
            Height          =   255
            Left            =   480
            TabIndex        =   49
            Top             =   4560
            Width           =   1455
         End
         Begin VB.Label Label15 
            Caption         =   "Parent Address:"
            Height          =   255
            Left            =   480
            TabIndex        =   47
            Top             =   3960
            Width           =   1335
         End
         Begin VB.Label Label14 
            Caption         =   "Occupation:"
            Height          =   255
            Left            =   4800
            TabIndex        =   43
            Top             =   3480
            Width           =   1095
         End
         Begin VB.Label Label13 
            Caption         =   "Mother's Name:"
            Height          =   255
            Left            =   480
            TabIndex        =   41
            Top             =   3480
            Width           =   1335
         End
         Begin VB.Label Label12 
            Caption         =   "Occupation:"
            Height          =   255
            Left            =   4800
            TabIndex        =   39
            Top             =   3000
            Width           =   1095
         End
         Begin VB.Label Label11 
            Caption         =   "Father's Name:"
            Height          =   255
            Left            =   480
            TabIndex        =   37
            Top             =   3000
            Width           =   1095
         End
         Begin VB.Label Label10 
            Caption         =   "Address:"
            Height          =   255
            Left            =   480
            TabIndex        =   35
            Top             =   2520
            Width           =   1095
         End
         Begin VB.Label Label9 
            Caption         =   "Place Of Birth:"
            Height          =   255
            Left            =   480
            TabIndex        =   31
            Top             =   1920
            Width           =   1095
         End
         Begin VB.Label Label8 
            Caption         =   "Date Of Birth:"
            Height          =   255
            Left            =   3240
            TabIndex        =   27
            Top             =   1440
            Width           =   1335
         End
         Begin VB.Label Label7 
            Caption         =   "Age:"
            Height          =   255
            Left            =   6840
            TabIndex        =   26
            Top             =   1440
            Width           =   615
         End
         Begin VB.Label Label3 
            Caption         =   "Sex:"
            Height          =   255
            Left            =   480
            TabIndex        =   25
            Top             =   1440
            Width           =   1095
         End
         Begin VB.Label Label6 
            Caption         =   "Middle Name:"
            Height          =   255
            Left            =   4800
            TabIndex        =   19
            Top             =   360
            Width           =   975
         End
         Begin VB.Label Label5 
            Caption         =   "Last Name:"
            Height          =   255
            Left            =   480
            TabIndex        =   18
            Top             =   840
            Width           =   1095
         End
         Begin VB.Label Label4 
            Caption         =   "First Name:"
            Height          =   255
            Left            =   480
            TabIndex        =   17
            Top             =   360
            Width           =   1095
         End
      End
      Begin VB.Frame Frame1 
         Height          =   1215
         Left            =   240
         TabIndex        =   8
         Top             =   4680
         Width           =   9855
         Begin VB.TextBox Text18 
            Height          =   300
            Left            =   6000
            TabIndex        =   13
            Text            =   "0"
            Top             =   240
            Width           =   735
         End
         Begin VB.CommandButton Command8 
            Caption         =   "&View Option"
            Height          =   350
            Left            =   7920
            TabIndex        =   15
            Top             =   720
            Width           =   1695
         End
         Begin VB.CommandButton Command7 
            Caption         =   "&Advanced Search"
            Height          =   350
            Left            =   7920
            TabIndex        =   14
            Top             =   240
            Width           =   1695
         End
         Begin VB.ComboBox Combo1 
            BackColor       =   &H00E6FFFF&
            Height          =   315
            ItemData        =   "Form1.frx":0AD6
            Left            =   1800
            List            =   "Form1.frx":0AE0
            TabIndex        =   12
            Text            =   "Ascending Order"
            Top             =   720
            Width           =   1815
         End
         Begin VB.TextBox Text1 
            Height          =   300
            Left            =   1800
            TabIndex        =   11
            Top             =   240
            Width           =   3495
         End
         Begin VB.Label Label20 
            Caption         =   "of"
            Height          =   255
            Left            =   6840
            TabIndex        =   56
            Top             =   350
            Width           =   975
         End
         Begin VB.Label Label19 
            Caption         =   "Goto:"
            Height          =   255
            Left            =   5520
            TabIndex        =   55
            Top             =   350
            Width           =   495
         End
         Begin VB.Label Label2 
            Caption         =   "Sort record in:"
            Height          =   255
            Left            =   240
            TabIndex        =   10
            Top             =   720
            Width           =   1455
         End
         Begin VB.Label Label1 
            Caption         =   "Enter text to search:"
            Height          =   255
            Left            =   240
            TabIndex        =   9
            Top             =   350
            Width           =   1575
         End
      End
      Begin MSComctlLib.ListView ListView1 
         Height          =   3930
         Left            =   240
         TabIndex        =   7
         Top             =   720
         Width           =   9855
         _ExtentX        =   17383
         _ExtentY        =   6932
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
         Left            =   120
         Top             =   360
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
               Picture         =   "Form1.frx":0B07
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin VB.Label Label21 
         BackStyle       =   0  'Transparent
         Caption         =   "Option:"
         Height          =   255
         Left            =   9120
         TabIndex        =   59
         Top             =   0
         Width           =   615
      End
   End
End
Attribute VB_Name = "Form1"
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

Public SY As String
Public sy_stat As String

Private Sub Combo1_Click()
If Combo1.Text = "Ascending Order" Then
    ListView1.Sorted = True
    ListView1.SortOrder = lvwAscending
ElseIf Combo1.Text = "Descending Order" Then
    ListView1.Sorted = True
    ListView1.SortOrder = lvwDescending
Else
    Combo1.SetFocus
End If
End Sub

Private Sub Combo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Command1_Click()
If sy_stat = "Open" Then
    Form6.add_state = True
    Form6.Show
    Me.Enabled = False
Else
    MsgBox "You cannot enroll new student because the School Year " & SY & " was already closed." & vbCrLf & vbCrLf & "Note: You can re-open the School Year if you want by selecting 'Option' in the menu and select 'Re-open School Year'.", vbExclamation, "CSRS version 1"
End If
End Sub

Private Sub Command10_Click()
If rs_stud.RecordCount < 1 Then MsgBox "No student in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If rs_stud.Fields(12) <> "Drop" Then
    MsgBox "Please select a student that is currently dropped in the school.", vbExclamation, "CSRS version 1"
Else
    Dim rep As Integer
    rep = MsgBox("Are you sure you want to undrop the selected student?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbNo Then Exit Sub:
    rep = 0
    Dim pos As Long
    With rs_stud
        pos = .AbsolutePosition
        .Fields(12) = "Old"
        .Update
        
        .Requery
        Call fill_rec
        .AbsolutePosition = pos
        
        ListView1.ListItems.Item(Val(.AbsolutePosition)).EnsureVisible
        ListView1.ListItems.Item(Val(.AbsolutePosition)).Selected = True

        
        MsgBox "The student was sucessfully undropped in the school and change it's status to 'Old'.", vbInformation, "CSRS version 1"
        pos = 0
    End With
End If
End Sub

Private Sub Command2_Click()
If rs_stud.RecordCount < 1 Then MsgBox "No student in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
Form6.add_state = False
Form6.Show
Me.Enabled = False
End Sub

Private Sub Command3_Click()
If rs_stud.RecordCount < 1 Then MsgBox "No student in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If Not rs_stud.Fields(10) = "" Then
    '------------------
    'Show Section
    '------------------
    Form3.sAssign = False
    Form3.Show: Me.Enabled = False
Else
    '------------------
    'Assign Section
    '------------------
    Form3.sAssign = True
    Form3.Show: Me.Enabled = False
End If
End Sub

Private Sub Command4_Click()
On Error GoTo Err:
With rs_stud
    '---------------------------------
    'Check if there is no record
    '---------------------------------
    If .RecordCount < 1 Then MsgBox "No student in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
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
        Call delete_rec(cn, "tblStudents", "StudentNo", "", True, Val(ListView1.SelectedItem.ListSubItems(1)))
        .Requery
        If .RecordCount > 0 Then
            .AbsolutePosition = pos
            If .EOF Then .MoveFirst
            '---------------------------------
            'Fill listview
            '---------------------------------
            pos = .AbsolutePosition
            Screen.MousePointer = vbHourglass

            Call FillListView(ListView1, rs_stud, 6, 1, True, True)
            Label20.Caption = "of " & ListView1.ListItems.Count
            ListView1.ListItems.Item(pos).EnsureVisible
            ListView1.ListItems.Item(pos).Selected = True
            .AbsolutePosition = ListView1.SelectedItem
            
            Screen.MousePointer = vbDefault
            '---------------------------------
            'End-fill listview
            '---------------------------------
        Else
            ListView1.ListItems.Clear
            Label20.Caption = "of 0"
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
Call reload_rec
End Sub
Public Sub reload_rec()

Screen.MousePointer = vbHourglass

rs_stud.Filter = adFilterNone
rs_stud.Requery
rs_stud.Filter = "Status <>'Drop'"
Call FillListView(ListView1, rs_stud, 6, 1, True, True)
If Not rs_stud.RecordCount < 1 Then rs_stud.MoveFirst
Label20.Caption = "of " & ListView1.ListItems.Count

Screen.MousePointer = vbDefault
End Sub
Public Sub fill_rec()

Screen.MousePointer = vbHourglass

Call FillListView(ListView1, rs_stud, 6, 1, True, True)
If Not rs_stud.RecordCount < 1 Then rs_stud.MoveFirst
Label20.Caption = "of " & ListView1.ListItems.Count


Screen.MousePointer = vbDefault
End Sub

Private Sub Command6_Click()
Unload Me
End Sub

Private Sub Command7_Click()
If Text1.Text = "" Then MsgBox "Please enter some text to search.", vbExclamation, "CSRS version 1": Text1.SetFocus: Exit Sub
Dim c As Byte
With Form7
    For c = 1 To rs_stud.Fields.Count - 1
        .Combo1.AddItem rs_stud.Fields.Item(Val(c)).Name
    Next c
    .Text1.Text = Text1.Text
    .Show
End With
Me.Enabled = False
'----------------
'Clear Variable
'----------------
c = 0
End Sub

Private Sub Command8_Click()
Form8.Show
Me.Enabled = False
End Sub

Private Sub Command9_Click()
If rs_stud.RecordCount < 1 Then MsgBox "No student in the list.Please check it!", vbExclamation, "CSRS version 1": Exit Sub
If rs_stud.Fields(12) = "Drop" Then
    MsgBox "The student was already dropped.", vbExclamation, "CSRS version 1"
Else
    Dim rep As Integer
    rep = MsgBox("Are you sure you want to drop the selected student?", vbQuestion + vbYesNo, "CSRS version 1")
    If rep = vbNo Then Exit Sub:
    rep = 0

    Dim pos As Long
    With rs_stud
        pos = .AbsolutePosition
        .Fields(12) = "Drop"
        .Update
        
        .Requery
        Call fill_rec
        If pos > .RecordCount Then
            If Not .RecordCount < 1 Then .MoveFirst
        Else
            .AbsolutePosition = pos
        End If
        
        If Not .RecordCount < 1 Then ListView1.ListItems.Item(Val(.AbsolutePosition)).EnsureVisible
        If Not .RecordCount < 1 Then ListView1.ListItems.Item(Val(.AbsolutePosition)).Selected = True
        
        MsgBox "The student was sucessfully dropped in the school.", vbInformation, "CSRS version 1"
        pos = 0
    End With
End If
End Sub

Private Sub Form_Activate()
Command1.SetFocus
End Sub

Private Sub Form_Load()
Call use_pos(Me)

'----------------------------
'For student view option
'----------------------------
sds = 0
sms = 1
sfs = 1
sns = 1
sos = 1
'----------------------------
'End-For student view option
'----------------------------
Call set_rec_getData(rs_stud, cn, "Select qryStudents.* From qryStudents Where SchoolYear ='" & SY & "' Order by Sex Desc,LastName Asc,FirstName Asc")

reload_rec
bind_controls

Me.Caption = Me.Caption & " For School Year " & SY
End Sub

Private Sub Form_Unload(Cancel As Integer)
unbind_controls

Set rs_stud = Nothing

frm_stud_show = False
SY = ""
sy_stat = ""
Call save_pos(Me)
End Sub

Private Sub ListView1_ItemClick(ByVal Item As MSComctlLib.ListItem)
If Not rs_stud.RecordCount < 1 Then rs_stud.AbsolutePosition = ListView1.SelectedItem
End Sub

Private Sub SSTab1_Click(PreviousTab As Integer)
Select Case SSTab1.Tab
    Case 0:
            ListView1.SetFocus
    Case 1:
            Text2.SetFocus
End Select
End Sub
Private Sub Text1_Change()
If ListView1.ListItems.Count < 1 Then Exit Sub
Call search_in_listview(ListView1, Text1.Text)
End Sub

Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text18_Change()
If Val(Text18.Text) > ListView1.ListItems.Count Or Val(Text18.Text) < 1 Then Text18.SetFocus: Exit Sub
ListView1.ListItems.Item(Val(Text18.Text)).Selected = True
rs_stud.AbsolutePosition = ListView1.SelectedItem
End Sub
Sub bind_controls()
'---------------------------
'Set the datasource
'---------------------------
Set Text2.DataSource = rs_stud
Set Text3.DataSource = rs_stud
Set Text4.DataSource = rs_stud
Set Text5.DataSource = rs_stud
Set Text6.DataSource = rs_stud
Set Text7.DataSource = rs_stud
Set Text8.DataSource = rs_stud
Set Text9.DataSource = rs_stud
Set Text10.DataSource = rs_stud
Set Text11.DataSource = rs_stud
Set Text12.DataSource = rs_stud
Set Text13.DataSource = rs_stud
Set Text14.DataSource = rs_stud
Set Text15.DataSource = rs_stud
Set Text16.DataSource = rs_stud
Set Text17.DataSource = rs_stud
'-------------------------------
'Set the datafield
'-------------------------------
Text2.DataField = "FirstName"
Text3.DataField = "MiddleName"
Text4.DataField = "LastName"
Text5.DataField = "Sex"
Text6.DataField = "DateOfBirth"
Text7.DataField = "Age"
Text8.DataField = "PlaceOfBirth"
Text9.DataField = "Address"
Text10.DataField = "FatherName"
Text11.DataField = "Occupation1"
Text12.DataField = "MotherName"
Text13.DataField = "Occupation2"
Text14.DataField = "ParentAddress"
Text15.DataField = "SchoolLastAttend"
Text16.DataField = "Status"
Text17.DataField = "DateEnrolled"
End Sub
Sub unbind_controls()
'-----------------------------------
'Set the datasource
'-----------------------------------
Set Text2.DataSource = Nothing
Set Text3.DataSource = Nothing
Set Text4.DataSource = Nothing
Set Text5.DataSource = Nothing
Set Text6.DataSource = Nothing
Set Text7.DataSource = Nothing
Set Text8.DataSource = Nothing
Set Text9.DataSource = Nothing
Set Text10.DataSource = Nothing
Set Text11.DataSource = Nothing
Set Text12.DataSource = Nothing
Set Text13.DataSource = Nothing
Set Text14.DataSource = Nothing
Set Text15.DataSource = Nothing
Set Text16.DataSource = Nothing
Set Text17.DataSource = Nothing
'------------------------------
'Set the datafield
'------------------------------
Text2.DataField = ""
Text3.DataField = ""
Text4.DataField = ""
Text5.DataField = ""
Text6.DataField = ""
Text7.DataField = ""
Text8.DataField = ""
Text9.DataField = ""
Text10.DataField = ""
Text11.DataField = ""
Text12.DataField = ""
Text13.DataField = ""
Text14.DataField = ""
Text15.DataField = ""
Text16.DataField = ""
Text17.DataField = ""
End Sub

Private Sub Text18_GotFocus()
Call highlight_focus(Text18)
End Sub

Private Sub Text18_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub

Private Sub Text18_LostFocus()
Text18.Text = Val(Text18.Text)
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
Private Sub Text5_GotFocus()
Call highlight_focus(Text5)
End Sub
Private Sub Text6_GotFocus()
Call highlight_focus(Text6)
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
Private Sub Text11_GotFocus()
Call highlight_focus(Text11)
End Sub
Private Sub Text12_GotFocus()
Call highlight_focus(Text12)
End Sub
Private Sub Text13_GotFocus()
Call highlight_focus(Text13)
End Sub
Private Sub Text14_GotFocus()
Call highlight_focus(Text14)
End Sub
Private Sub Text15_GotFocus()
Call highlight_focus(Text15)
End Sub
Private Sub Text16_GotFocus()
Call highlight_focus(Text16)
End Sub
Private Sub Text17_GotFocus()
Call highlight_focus(Text17)
End Sub
