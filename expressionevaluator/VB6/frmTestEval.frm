VERSION 5.00
Begin VB.Form frmEval 
   Caption         =   "Expression evaluator - Copyright© 1999 Tretyakov Konstantin"
   ClientHeight    =   1530
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7785
   Icon            =   "frmTestEval.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   1530
   ScaleWidth      =   7785
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text1 
      BackColor       =   &H00404040&
      BeginProperty Font 
         Name            =   "Copperplate Gothic Bold"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000C000&
      Height          =   645
      Left            =   120
      TabIndex        =   1
      Text            =   "1+2+3+4+(1*2*3^(3-1)/18-1/2)"
      Top             =   120
      Width           =   7575
   End
   Begin VB.CommandButton cmdEval 
      Caption         =   "Evaluate"
      Default         =   -1  'True
      Height          =   615
      Left            =   2280
      TabIndex        =   0
      Top             =   840
      Width           =   3255
   End
End
Attribute VB_Name = "frmEval"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Pretty short, Ha ?
Option Explicit

Dim cEval As New Evaluator

Private Sub cmdEval_Click()
    If CanPlayWaves Then PlayWave (App.Path & IIf(Right(App.Path, 1) = "\", "", "\") & "pff.Wav")
    cEval.Evaluate Text1.Text
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
    If CanPlayWaves Then PlayWave (App.Path & IIf(Right(App.Path, 1) = "\", "", "\") & "flip.wav")
End Sub
