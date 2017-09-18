VERSION 5.00
Begin VB.Form frmAbout 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "ZynExplorer"
   ClientHeight    =   3555
   ClientLeft      =   6660
   ClientTop       =   6330
   ClientWidth     =   5730
   ClipControls    =   0   'False
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2453.724
   ScaleMode       =   0  'User
   ScaleWidth      =   5380.766
   ShowInTaskbar   =   0   'False
   Begin VB.PictureBox picIcon 
      AutoSize        =   -1  'True
      ClipControls    =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1020
      Left            =   240
      Picture         =   "frmAbout.frx":0000
      ScaleHeight     =   674.24
      ScaleMode       =   0  'User
      ScaleWidth      =   674.24
      TabIndex        =   1
      Top             =   240
      Width           =   1020
   End
   Begin VB.CommandButton cmdOK 
      Cancel          =   -1  'True
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   345
      Left            =   4245
      TabIndex        =   0
      Top             =   2625
      Width           =   1260
   End
   Begin VB.CommandButton cmdSysInfo 
      Caption         =   "&Credits"
      Height          =   345
      Left            =   4260
      TabIndex        =   2
      Top             =   3075
      Width           =   1245
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00808080&
      BorderStyle     =   6  'Inside Solid
      Index           =   1
      X1              =   84.515
      X2              =   5309.398
      Y1              =   1687.583
      Y2              =   1687.583
   End
   Begin VB.Label lblDescription 
      Caption         =   "A Webrowser manipulating the Internet Explorer Control on VB6. It includes most of the functions of the Webbrowser1 control. "
      ForeColor       =   &H00000000&
      Height          =   1170
      Left            =   1440
      TabIndex        =   3
      Top             =   1125
      Width           =   3885
   End
   Begin VB.Label lblTitle 
      Caption         =   "Zynder's Explorer"
      ForeColor       =   &H00000000&
      Height          =   480
      Left            =   1440
      TabIndex        =   5
      Top             =   240
      Width           =   3885
   End
   Begin VB.Line Line1 
      BorderColor     =   &H00FFFFFF&
      BorderWidth     =   2
      Index           =   0
      X1              =   98.6
      X2              =   5309.398
      Y1              =   1697.936
      Y2              =   1697.936
   End
   Begin VB.Label lblVersion 
      Caption         =   "Version 1.0.0"
      Height          =   225
      Left            =   1440
      TabIndex        =   6
      Top             =   780
      Width           =   3885
   End
   Begin VB.Label lblDisclaimer 
      Caption         =   "Warning: ... This is a freeware. You can use and distribute this software. Cheers! ^ ^"
      ForeColor       =   &H00000000&
      Height          =   825
      Left            =   255
      TabIndex        =   4
      Top             =   2625
      Width           =   3870
   End
End
Attribute VB_Name = "frmAbout"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdOK_Click()
  Unload Me
End Sub

