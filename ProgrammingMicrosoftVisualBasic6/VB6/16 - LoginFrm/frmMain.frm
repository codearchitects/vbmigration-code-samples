VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Form1"
   ClientHeight    =   1755
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   2985
   LinkTopic       =   "Form1"
   ScaleHeight     =   1755
   ScaleWidth      =   2985
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Log In"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   2055
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
    
Dim WithEvents frmLogin As CLogin
Attribute frmLogin.VB_VarHelpID = -1

Private Sub Command1_Click()
    Set frmLogin = New CLogin
    frmLogin.Show vbModal
    
    MsgBox "User " & frmLogin.UserName & " logged it", vbInformation
End Sub

Private Sub frmLogin_WrongPassword(password As String)
    MsgBox "Wrong Password"
End Sub
