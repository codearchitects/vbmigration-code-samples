VERSION 5.00
Begin VB.Form frmTimer 
   Caption         =   "Form1"
   ClientHeight    =   870
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   1560
   LinkTopic       =   "Form1"
   ScaleHeight     =   870
   ScaleWidth      =   1560
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Left            =   120
      Top             =   240
   End
End
Attribute VB_Name = "frmTimer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Public Owner As CPrinter

Private Sub Timer1_Timer()
    ' this procedure is executed only once per each invocation
    ' disable the timer
    Timer1.Interval = 0
    Timer1.Enabled = False
    ' yield to the companion CPrinter instance
    Owner.StartIt
End Sub
