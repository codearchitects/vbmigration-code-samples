VERSION 5.00
Begin VB.Form frmSplash 
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   2610
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4770
   Icon            =   "frmSplash.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   2610
   ScaleWidth      =   4770
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Height          =   2535
      Left            =   60
      TabIndex        =   0
      Top             =   0
      Width           =   4635
      Begin VB.Image Image1 
         Height          =   2340
         Left            =   60
         Picture         =   "frmSplash.frx":038A
         Top             =   120
         Width           =   4485
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   5000
      Left            =   2280
      Top             =   2280
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Click()
    Unload Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Timer1.Enabled = False
End Sub

Private Sub Timer1_Timer()
    Unload Me
End Sub
