VERSION 5.00
Begin VB.Form frmInfo 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   " About ATOMIX"
   ClientHeight    =   3630
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   5625
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3630
   ScaleWidth      =   5625
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame Frame1 
      Height          =   25
      Left            =   120
      TabIndex        =   3
      Top             =   3000
      Width           =   5415
   End
   Begin VB.CommandButton cmdOk 
      Cancel          =   -1  'True
      Caption         =   "&OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   4320
      TabIndex        =   2
      Top             =   3120
      Width           =   1215
   End
   Begin VB.PictureBox Picture1 
      Height          =   2775
      Left            =   120
      ScaleHeight     =   2715
      ScaleWidth      =   1035
      TabIndex        =   0
      Top             =   120
      Width           =   1095
      Begin VB.Image Image1 
         Height          =   480
         Index           =   0
         Left            =   240
         Picture         =   "frmInfo.frx":0000
         Stretch         =   -1  'True
         Top             =   2040
         Width           =   480
      End
   End
   Begin VB.Label lblInfo 
      Caption         =   "Label3"
      Height          =   1095
      Left            =   1320
      TabIndex        =   5
      Top             =   600
      Width           =   3975
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "ATOMIX Virtual  Cipher Machine"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1320
      TabIndex        =   4
      Top             =   120
      Width           =   4335
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   $"frmInfo.frx":030A
      Height          =   855
      Left            =   1320
      TabIndex        =   1
      Top             =   2040
      Width           =   3855
   End
End
Attribute VB_Name = "frmInfo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdOk_Click()
Me.Hide
End Sub

Private Sub Form_Load()
Me.lblInfo.Caption = "Version 2.1" & vbCrLf & vbCrLf & _
"Program written by D. Rijmenants" & vbCrLf & vbCrLf & "© D. Rijmenants 2006"
End Sub
