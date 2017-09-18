VERSION 5.00
Object = "*\AScrolPic.vbp"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin ScrolPic.ScrollPictureBox ScrollPictureBox1 
      Height          =   2775
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   4215
      _ExtentX        =   7435
      _ExtentY        =   4895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##AddDataFile SampleImage.bmp

Private Sub Form_Load()
    Set Me.ScrollPictureBox1.Picture = LoadPicture("SampleImage.bmp")
End Sub
