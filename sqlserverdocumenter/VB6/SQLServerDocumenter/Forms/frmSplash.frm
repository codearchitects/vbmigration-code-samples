VERSION 5.00
Begin VB.Form frmSplash 
   BackColor       =   &H00FFFFFF&
   BorderStyle     =   0  'None
   Caption         =   "splash form"
   ClientHeight    =   2985
   ClientLeft      =   5010
   ClientTop       =   5865
   ClientWidth     =   5985
   LinkTopic       =   "Form1"
   ScaleHeight     =   2985
   ScaleWidth      =   5985
   ShowInTaskbar   =   0   'False
   Begin VB.Label lblVersion 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "X.X.X"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   720
      TabIndex        =   1
      Top             =   1740
      Width           =   615
   End
   Begin VB.Label lblStatus 
      BackStyle       =   0  'Transparent
      Caption         =   "Please wait"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   2640
      Width           =   5715
   End
   Begin VB.Image Image1 
      Height          =   3000
      Left            =   0
      Picture         =   "frmSplash.frx":0000
      Top             =   0
      Width           =   6000
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

Center Me
lblVersion.Caption = App.Major & "." & App.Minor & "." & App.Revision

End Sub
