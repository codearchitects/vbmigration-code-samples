VERSION 5.00
Begin VB.Form Form24 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Login"
   ClientHeight    =   2550
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4035
   Icon            =   "Form24.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2550
   ScaleWidth      =   4035
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "&Cancel"
      Height          =   350
      Left            =   1800
      TabIndex        =   8
      Top             =   1680
      Width           =   975
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   350
      Left            =   2880
      TabIndex        =   7
      Top             =   1680
      Width           =   975
   End
   Begin VB.TextBox Text2 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   1080
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   1320
      Width           =   2775
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   6.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   285
      Left            =   1080
      TabIndex        =   0
      Top             =   840
      Width           =   2775
   End
   Begin VB.Label Label7 
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   960
      TabIndex        =   6
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label4 
      Caption         =   "Attempt:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   2160
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "Plese enter your username and password in the space provided bellow to login."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   720
      TabIndex        =   4
      Top             =   240
      Width           =   3135
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      Caption         =   "Password:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   0
      TabIndex        =   3
      Top             =   1320
      Width           =   975
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Caption         =   "User Name:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   255
      Left            =   0
      TabIndex        =   2
      Top             =   840
      Width           =   975
   End
   Begin VB.Image Image1 
      Height          =   480
      Left            =   120
      Picture         =   "Form24.frx":08CA
      Top             =   120
      Width           =   480
   End
End
Attribute VB_Name = "Form24"
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

Dim c_attempt As String
Dim rs_user As New ADODB.Recordset
Dim conn_user As New ADODB.Connection

Private Sub Command1_Click()
end_app = True
Unload Me
End Sub

Private Sub Command2_Click()
'-------------------------------------------------
'Verify the fields if empty
'-------------------------------------------------
If Text1.Text = "" Then Text1.SetFocus: Exit Sub
If Text2.Text = "" Then Text2.SetFocus: Exit Sub
'-------------------------------------------------
'Check if the User Name is valid
'-------------------------------------------------
If rec_found(rs_user, "Username", Text1.Text) = False Then
    c_attempt = c_attempt - 1
    If c_attempt < 0 Then
        MsgBox "You already used all attempt." & vbCrLf & "This will terminate the application.", vbCritical, "CSRS version 1"
    Else
        MsgBox "The User Name you entered is not valid." & vbCrLf & "Please try again." & vbCrLf & vbCrLf & "Warning: You only have " & c_attempt & " attempt.", vbCritical, "CSRS version 1"
        Label7.Caption = c_attempt
    End If
    Text1.SetFocus
    Call verify_attempt
    Exit Sub
End If
'-------------------------------------------------
'Check if the Password is valid
'-------------------------------------------------
If Text2.Text <> rs_user.Fields(3) Then
    c_attempt = c_attempt - 1
    Label7.Caption = c_attempt
    If c_attempt < 0 Then
        MsgBox "You already used all attempt." & vbCrLf & "This will terminate the application.", vbCritical, "CSRS version 1"
    Else
        MsgBox "You did NOT enter the Correct Password." & vbCrLf & "Please try again." & vbCrLf & vbCrLf & "Warning: You only have " & c_attempt & " attempt.", vbCritical, "CSRS version 1"
        Label7.Caption = c_attempt
    End If
    Text2.SetFocus
    Call verify_attempt
    Exit Sub
End If
'-------------------------------------------------
'Copy the Username and log-time to variable
'-------------------------------------------------
user_name = Text1.Text
user_login = Now
user_type = rs_user.Fields(2)
'-------------------------------------------------
'This the Username and log-time to variable
'-------------------------------------------------
Call record_login(user_login, user_name)
With MDIForm1.StatusBar1.Panels
    .Item(3).Text = user_name
    .Item(6).Text = user_login
End With
Unload Me
End Sub

Private Sub Form_Activate()
Text1.SetFocus
End Sub

Private Sub Form_Load()
'-------------------------------------------------
'Set the variables to have connection to database
'-------------------------------------------------
Call set_conn_getData(conn_user, App.Path & "\MasterFile.mdb", True, "reg386")
Call set_rec_getData(rs_user, conn_user, "Select * From Users")
'-------------------------------------------------
'Move them form to center
'-------------------------------------------------
Call centerForm(Me, Screen.Height, Screen.Width)
'-------------------------------------------------
'Initialize the number of attempt
'-------------------------------------------------
c_attempt = 3
Label7.Caption = c_attempt
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
'-------------------------------------------------
'If the user click the close button
'-------------------------------------------------
If UnloadMode = 0 Then end_app = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
'-------------------------------------------------
'Clear variable from the computer memory
'-------------------------------------------------
Set rs_user = Nothing
Set conn_user = Nothing
End Sub
Private Sub verify_attempt()
'-------------------------------------------------------
'If all attempt is used then terminate the application
'-------------------------------------------------------
If c_attempt < 0 Then end_app = True: Unload Me
End Sub

Private Sub Text1_GotFocus()
Call highlight_focus(Text1)
End Sub

Private Sub Text2_GotFocus()
Call highlight_focus(Text2)
End Sub
