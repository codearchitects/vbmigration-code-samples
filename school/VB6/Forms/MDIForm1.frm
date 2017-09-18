VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H8000000C&
   Caption         =   "Computerize School Registration Software version 1"
   ClientHeight    =   7065
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   7995
   Icon            =   "MDIForm1.frx":0000
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.PictureBox Picture4 
      Align           =   2  'Align Bottom
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   10
      Left            =   0
      ScaleHeight     =   15
      ScaleWidth      =   7995
      TabIndex        =   4
      Top             =   6750
      Width           =   7995
   End
   Begin VB.PictureBox Picture3 
      Align           =   1  'Align Top
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      Height          =   10
      Left            =   0
      ScaleHeight     =   15
      ScaleWidth      =   7995
      TabIndex        =   3
      Top             =   15
      Width           =   7995
   End
   Begin VB.PictureBox Picture2 
      Align           =   2  'Align Bottom
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      Height          =   10
      Left            =   0
      ScaleHeight     =   15
      ScaleWidth      =   7995
      TabIndex        =   2
      Top             =   6765
      Width           =   7995
   End
   Begin VB.PictureBox Picture1 
      Align           =   1  'Align Top
      BackColor       =   &H80000010&
      BorderStyle     =   0  'None
      Height          =   10
      Left            =   0
      ScaleHeight     =   15
      ScaleWidth      =   7995
      TabIndex        =   1
      Top             =   0
      Width           =   7995
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   330
      Left            =   0
      TabIndex        =   0
      Top             =   30
      Width           =   7995
      _ExtentX        =   14102
      _ExtentY        =   582
      ButtonWidth     =   609
      ButtonHeight    =   582
      AllowCustomize  =   0   'False
      Style           =   1
      ImageList       =   "ImageList1"
      HotImageList    =   "ImageList2"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   18
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Modify Student Record"
            ImageIndex      =   1
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Sections"
            ImageIndex      =   2
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Level"
            ImageIndex      =   3
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Modify School Year"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Make Registration Slip"
            ImageIndex      =   5
         EndProperty
         BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Individual Reports"
            ImageIndex      =   6
         EndProperty
         BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Students Per Section"
            ImageIndex      =   7
         EndProperty
         BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Student List"
            ImageIndex      =   8
         EndProperty
         BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Population Report"
            ImageIndex      =   9
         EndProperty
         BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Calculator"
            ImageIndex      =   10
         EndProperty
         BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Notepad"
            ImageIndex      =   11
         EndProperty
         BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "Calendar"
            ImageIndex      =   12
         EndProperty
         BeginProperty Button17 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button18 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Object.ToolTipText     =   "About?"
            ImageIndex      =   14
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList2 
      Left            =   1680
      Top             =   1800
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   14
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":1042
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":13DC
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":1776
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":1B10
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":1EAA
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":2244
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":25DE
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":2978
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":2D12
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":30AC
            Key             =   ""
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":3446
            Key             =   ""
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":37E0
            Key             =   ""
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":3B7A
            Key             =   ""
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":3F14
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   2880
      Top             =   1320
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   14
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":42AE
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":4648
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":49E2
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":4D7C
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":5116
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":54B0
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":584A
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":5BE4
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":5F7E
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":6318
            Key             =   ""
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":68B2
            Key             =   ""
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":6E4C
            Key             =   ""
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":71E6
            Key             =   ""
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MDIForm1.frx":7580
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   285
      Left            =   0
      TabIndex        =   5
      Top             =   6780
      Width           =   7995
      _ExtentX        =   14102
      _ExtentY        =   503
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   9
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   441
            MinWidth        =   441
            Picture         =   "MDIForm1.frx":791A
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   1587
            MinWidth        =   1587
            Text            =   "User Name:"
            TextSave        =   "User Name:"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   4410
            MinWidth        =   4410
         EndProperty
         BeginProperty Panel4 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   441
            MinWidth        =   441
            Picture         =   "MDIForm1.frx":7EB4
         EndProperty
         BeginProperty Panel5 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   1764
            MinWidth        =   1764
            Text            =   "Time Log-in:"
            TextSave        =   "Time Log-in:"
         EndProperty
         BeginProperty Panel6 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   3246
            MinWidth        =   3246
         EndProperty
         BeginProperty Panel7 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   529
            MinWidth        =   529
            Picture         =   "MDIForm1.frx":824E
         EndProperty
         BeginProperty Panel8 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Bevel           =   0
            Object.Width           =   1058
            MinWidth        =   1058
            Text            =   "Date:"
            TextSave        =   "Date:"
         EndProperty
         BeginProperty Panel9 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   6
            TextSave        =   "3/20/2004"
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Menu mnuF 
      Caption         =   "&File"
      Begin VB.Menu mnuMSR 
         Caption         =   "Modify Student Record"
         Shortcut        =   ^N
      End
      Begin VB.Menu mnuS 
         Caption         =   "Sections"
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuL 
         Caption         =   "&Level"
         Shortcut        =   ^L
      End
      Begin VB.Menu mnuMSY 
         Caption         =   "Modify School Year"
         Shortcut        =   ^Y
      End
      Begin VB.Menu sep5 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAO 
         Caption         =   "&Administrator Option"
      End
      Begin VB.Menu sep10 
         Caption         =   "-"
      End
      Begin VB.Menu mnuE 
         Caption         =   "Exit"
         Shortcut        =   ^F
      End
   End
   Begin VB.Menu mnuR 
      Caption         =   "Reports"
      Begin VB.Menu mnuMRS 
         Caption         =   "&Make Registration Slip"
         Shortcut        =   ^M
      End
      Begin VB.Menu mnuIR 
         Caption         =   "Individual Reports"
         Shortcut        =   ^I
      End
      Begin VB.Menu mnuSPS 
         Caption         =   "Student Per Section"
         Shortcut        =   ^S
      End
      Begin VB.Menu sep8 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSL 
         Caption         =   "Student List"
         Shortcut        =   ^T
      End
      Begin VB.Menu sep7 
         Caption         =   "-"
      End
      Begin VB.Menu mnuPR 
         Caption         =   "Population Report"
         Shortcut        =   ^P
      End
   End
   Begin VB.Menu mnuV 
      Caption         =   "&View"
      Begin VB.Menu mnuTAP 
         Caption         =   "Toolbar Align &Top   "
      End
      Begin VB.Menu mnuTAB 
         Caption         =   "Toolbar Align &Buttom"
      End
      Begin VB.Menu mnuTAL 
         Caption         =   "Toolbar Align &Left"
      End
      Begin VB.Menu mnuTAR 
         Caption         =   "Toolbar Align &Right"
      End
      Begin VB.Menu sep4 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHSM 
         Caption         =   "Hide/Show Shortcut Menu"
      End
      Begin VB.Menu mnuHSS 
         Caption         =   "Hide/Show Statusbar"
      End
   End
   Begin VB.Menu mnuT 
      Caption         =   "Tools"
      Begin VB.Menu mnuCalc 
         Caption         =   "C&alculator"
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuNP 
         Caption         =   "&Notepad"
         Shortcut        =   ^D
      End
      Begin VB.Menu sep6 
         Caption         =   "-"
      End
      Begin VB.Menu mnuCalen 
         Caption         =   "&Calendar"
         Shortcut        =   ^E
      End
   End
   Begin VB.Menu mnuW 
      Caption         =   "&Window"
      Begin VB.Menu mnuTH 
         Caption         =   "Tile &Horizontally"
      End
      Begin VB.Menu mnuTV 
         Caption         =   "Tile Vertically"
      End
      Begin VB.Menu mnuC 
         Caption         =   "&Cascade"
      End
      Begin VB.Menu mnuAI 
         Caption         =   "&Arrage Icons"
      End
      Begin VB.Menu sep3 
         Caption         =   "-"
      End
      Begin VB.Menu winlist 
         Caption         =   "Forms >>"
         WindowList      =   -1  'True
      End
   End
   Begin VB.Menu mnuHLP 
      Caption         =   "Help"
      Begin VB.Menu mnuAbt 
         Caption         =   "About?     "
         Shortcut        =   ^A
      End
   End
End
Attribute VB_Name = "MDIForm1"
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

Private Sub MDIForm_Activate()
If end_app = True Then End
End Sub

Private Sub MDIForm_Load()
Call use_control_vis(Toolbar1)
Call use_control_vis(StatusBar1)
Call use_control_pos(Toolbar1)

Call set_conn_getData(cn, App.Path & "\MasterFile.mdb", True, "reg386")

Dim rs As New ADODB.Recordset
Call set_rec_getData(rs, cn, "Select SystemInfo.* From SystemInfo")

school_name = rs.Fields(0)
school_address = rs.Fields(1)

Set rs = Nothing

Me.Caption = school_name & " - " & Me.Caption

Me.Show
frmSplash.Show vbModal

Form24.Show vbModal
End Sub

Private Sub MDIForm_QueryUnload(Cancel As Integer, UnloadMode As Integer)
Dim repp As Integer
repp = MsgBox("This will terminate the application.Do you want to proceed?", vbExclamation + vbYesNo, "CSRS version 1")
If repp = vbNo Then
    Cancel = 1
End If
End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
'---------------------------------------
'Record user's logout time
'---------------------------------------
Call record_logout(user_login, user_name)

Set cn = Nothing

Call save_control_pos(Toolbar1)
Call save_control_vis(Toolbar1)
Call save_control_vis(StatusBar1)

'---------------------------------------
'Terminate the entire application
'---------------------------------------
End
End Sub

Private Sub mnuAbt_Click()
frmAbout.Show vbModal
End Sub

Private Sub mnuAI_Click()
Me.Arrange vbArrangeIcons
End Sub

Private Sub mnuAO_Click()
If user_type <> "Admin" Then MsgBox "This function is for administrator only. Please log-in as administrator to gain access.", vbCritical, "CSRS version 1": Exit Sub


Form23.Show
Form23.SetFocus
Form23.WindowState = 0
End Sub

Private Sub mnuC_Click()
Me.Arrange vbCascade
End Sub

Private Sub mnuCalc_Click()
On Error GoTo Err
Shell "calc.exe", vbNormalFocus
Exit Sub
Err:
    MsgBox "You don't have a Calculator installed in your computer.", vbExclamation, "CSRS version 1"
End Sub

Private Sub mnuCalen_Click()
Form16.Show
Form16.SetFocus
Form16.WindowState = 0
End Sub

Private Sub mnuE_Click()
Unload Me
End Sub

Private Sub mnuHSM_Click()
Toolbar1.Visible = Not Toolbar1.Visible
End Sub

Private Sub mnuHSS_Click()
StatusBar1.Visible = Not StatusBar1.Visible
End Sub

Private Sub mnuIR_Click()
Form17.Show
Form17.SetFocus
Form17.WindowState = 0
Form17.Command2.SetFocus
End Sub

Private Sub mnuL_Click()
Form9.Show
Form9.SetFocus
Form9.WindowState = 0
End Sub

Private Sub mnuMRS_Click()
Form17.Show
Form17.SetFocus
Form17.WindowState = 0
Form17.Command1.SetFocus
End Sub

Private Sub mnuMSR_Click()
If frm_stud_show = True Then Form1.SetFocus: Form1.WindowState = 0: Exit Sub
Form2.Show
End Sub

Private Sub mnuMSY_Click()
Form11.Show
Form11.SetFocus
Form11.WindowState = 0
End Sub

Private Sub mnuPR_Click()
Form21.Show
Form21.SetFocus
Form21.WindowState = 0
End Sub

Private Sub mnuS_Click()
Form13.Show
Form13.SetFocus
Form13.WindowState = 0
End Sub

Private Sub mnuSI_Click()

End Sub

Private Sub mnuSL_Click()
Form20.Show
Form20.SetFocus
Form20.WindowState = 0
End Sub

Private Sub mnuSPS_Click()
Form17.Show
Form17.SetFocus
Form17.WindowState = 0
Form17.Command4.SetFocus
End Sub

Private Sub mnuTAB_Click()
Toolbar1.Align = 2
End Sub

Private Sub mnuTAL_Click()
Toolbar1.Align = 3
End Sub

Private Sub mnuTAP_Click()
Toolbar1.Align = 1
End Sub

Private Sub mnuTAR_Click()
Toolbar1.Align = 4
End Sub

Private Sub mnuTH_Click()
Me.Arrange vbTileHorizontal
End Sub

Private Sub mnuTV_Click()
Me.Arrange vbTileVertical
End Sub

Private Sub mnuNP_Click()
On Error GoTo Err
Shell "notepad.exe", vbNormalFocus
Exit Sub
Err:
    MsgBox "You don't have a NotePad  installed in your computer.", vbExclamation, "CSRS version 1"
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
Select Case Button.Index
    Case 3: mnuMSR_Click
    Case 4: mnuS_Click
    Case 5: mnuL_Click
    Case 6: mnuMSY_Click
    Case 8: mnuMRS_Click
    Case 9: mnuIR_Click
    Case 10: mnuSPS_Click
    Case 11: mnuSL_Click
    Case 12: mnuPR_Click
    Case 14: mnuCalc_Click
    Case 15: mnuNP_Click
    Case 16: mnuCalen_Click
    Case 18: mnuAbt_Click
End Select
End Sub
