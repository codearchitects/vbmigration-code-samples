VERSION 5.00
Begin VB.Form frmMain 
   Caption         =   "Login Demo"
   ClientHeight    =   1755
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   2985
   LinkTopic       =   "Form1"
   ScaleHeight     =   1755
   ScaleWidth      =   2985
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdShowLogin 
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

Private Sub cmdShowLogin_Click()
    ' uncomment next statement to fix the problem
    ' Dim frmlogin As New frmlogin
    frmlogin.Show vbModal
    ' execution gets here only if password is OK
    MsgBox frmlogin.UserName & " logged in."
End Sub

