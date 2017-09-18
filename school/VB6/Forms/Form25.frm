VERSION 5.00
Begin VB.Form Form25 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Log-in Info"
   ClientHeight    =   3495
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   2565
   Icon            =   "Form25.frx":0000
   LinkTopic       =   "Form25"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   ScaleHeight     =   3495
   ScaleWidth      =   2565
   Begin VB.Frame Frame2 
      Height          =   1575
      Left            =   120
      TabIndex        =   5
      Top             =   1320
      Visible         =   0   'False
      Width           =   2295
      Begin VB.TextBox Text1 
         Height          =   285
         Left            =   120
         MaxLength       =   4
         TabIndex        =   7
         Top             =   1080
         Width           =   1215
      End
      Begin VB.ComboBox Combo1 
         Height          =   315
         ItemData        =   "Form25.frx":038A
         Left            =   120
         List            =   "Form25.frx":038C
         TabIndex        =   6
         Top             =   480
         Width           =   2055
      End
      Begin VB.Label Label2 
         Caption         =   "Enter Year "
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   840
         Width           =   1215
      End
      Begin VB.Label Label1 
         Caption         =   "Select Month "
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   240
         Width           =   1215
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Option"
      Height          =   1095
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   2295
      Begin VB.OptionButton Option2 
         Caption         =   "View/Print log-in details"
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   600
         Width           =   2055
      End
      Begin VB.OptionButton Option1 
         Caption         =   "Clear log-in details"
         Height          =   255
         Left            =   120
         TabIndex        =   0
         Top             =   360
         Width           =   1935
      End
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   350
      Left            =   1440
      TabIndex        =   2
      Top             =   3000
      Width           =   975
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   360
      TabIndex        =   3
      Top             =   3000
      Width           =   975
   End
End
Attribute VB_Name = "Form25"
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


Private Sub Combo1_KeyPress(KeyAscii As Integer)
KeyAscii = 0
End Sub

Private Sub Command1_Click()
Unload Me
End Sub

Private Sub Command2_Click()
If is_empty(Combo1) = True Then Exit Sub
If is_empty(Text1) = True Then Exit Sub

If Len(Text1.Text) <> 4 Then MsgBox "Invalid entry. Please check it.", vbExclamation, "CSRS version 1": Text1.SetFocus: Exit Sub

If Option1.Value = True Then
    Dim rep As Integer
    rep = MsgBox("Are you sure you want to clear all log-in details?", vbCritical + vbYesNo, "CSRS version 1")
    If rep = vbYes Then Screen.MousePointer = vbHourglass: cn.Execute "Delete * From UsersLog": Screen.MousePointer = vbDefault: MsgBox "All log-in details has been successfully cleared.", vbInformation, "CSRS version 1"
Else
    If month_value(Combo1.Text) = 0 Then MsgBox "Invalid selection.", vbExclamation, "CSRS version 1": Combo1.SetFocus: Exit Sub
    Dim rs_log As New ADODB.Recordset
    
    Call set_rec_getData(rs_log, cn, "Select qryUsers.* From qryUsers Where Month =" & month_value(Combo1.Text) & " And Year =" & Val(Text1.Text) & " Order by Sort Asc")
    
    With rpt_header
        .SchoolAddress = school_address
        .SchoolName = school_name
    End With
    
    Set DataReport6.DataSource = rs_log
    DataReport6.Show vbModal
    
    Set rs_log = Nothing
End If
End Sub

Private Sub Option1_Click()
If Option1.Value = True Then
    Frame2.Visible = False
Else
    Frame2.Visible = True
End If
End Sub

Private Sub Option2_Click()
If Option1.Value = True Then
    Frame2.Visible = False
Else
    Frame2.Visible = True
End If
End Sub
Private Sub Form_Load()
Call use_pos(Me)
Option1.Value = True
With Combo1
    .AddItem "January"
    .AddItem "February"
    .AddItem "March"
    .AddItem "April"
    .AddItem "May"
    .AddItem "June"
    .AddItem "July"
    .AddItem "August"
    .AddItem "September"
    .AddItem "October"
    .AddItem "November"
    .AddItem "December"
End With
Text1.Text = Year(Date)
End Sub

Private Sub Form_Unload(Cancel As Integer)
Call save_pos(Me)
End Sub

Function month_value(ByVal Month_Name As String) As Byte
month_value = 0
Month_Name = Left(UCase(Month_Name), 1) & Right(LCase(Month_Name), Len(Month_Name) - 1)
Select Case Month_Name
    Case "January": month_value = 1
    Case "February": month_value = 2
    Case "March": month_value = 3
    Case "April": month_value = 4
    Case "May": month_value = 5
    Case "June": month_value = 6
    Case "July": month_value = 7
    Case "August": month_value = 8
    Case "September": month_value = 9
    Case "October": month_value = 10
    Case "November": month_value = 11
    Case "December": month_value = 12
End Select
End Function

Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If Not ((KeyAscii >= 48 And KeyAscii <= 57) Or KeyAscii = 8) Then KeyAscii = 0
End Sub
