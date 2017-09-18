VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H80000005&
   Caption         =   "Form1"
   ClientHeight    =   4980
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9150
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   4980
   ScaleWidth      =   9150
   StartUpPosition =   3  'Windows Default
   Begin VB.Label lblBackToVB 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Back to VB normal programming"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   300
      Left            =   480
      MouseIcon       =   "Hyperlinks.frx":0000
      MousePointer    =   99  'Custom
      TabIndex        =   4
      Top             =   4080
      Width           =   3435
   End
   Begin VB.Label lblDontCare 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "I couldn't care less"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   300
      Left            =   480
      MouseIcon       =   "Hyperlinks.frx":030A
      MousePointer    =   99  'Custom
      TabIndex        =   3
      Top             =   3480
      Width           =   1965
   End
   Begin VB.Label lblTellMe 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Tell me more, please"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   300
      Left            =   480
      MouseIcon       =   "Hyperlinks.frx":0614
      MousePointer    =   99  'Custom
      TabIndex        =   2
      Top             =   2880
      Width           =   2175
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   $"Hyperlinks.frx":091E
      Height          =   1575
      Left            =   480
      TabIndex        =   1
      Top             =   1080
      Width           =   6615
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "This is *NOT* an HTML page"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   735
      Left            =   480
      TabIndex        =   0
      Top             =   360
      Width           =   5895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub lblTellMe_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    lblTellMe.ForeColor = vbRed
End Sub

Private Sub lblTellMe_Click()
    MsgBox "I am glad you asked"
End Sub

Private Sub lblDontCare_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    lblDontCare.ForeColor = vbRed
End Sub

Private Sub lblDontCare_Click()
    MsgBox "Come on, this was just an example!"
End Sub

Private Sub lblBackToVB_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    lblBackToVB.ForeColor = vbRed
End Sub

Private Sub lblBackToVB_Click()
    Unload Me
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    lblTellMe.ForeColor = vbBlue
    lblDontCare.ForeColor = vbBlue
    lblBackToVB.ForeColor = vbBlue
End Sub


