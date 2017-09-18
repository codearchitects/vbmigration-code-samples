VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Digital Clock"
   ClientHeight    =   2565
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5040
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   2565
   ScaleWidth      =   5040
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Left            =   1920
      Top             =   1080
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Resize()
    Dim msg As String, size As Integer
    
    msg = Time$
    For size = 200 To 8 Step -2
        Font.size = size
        If TextWidth(msg) <= ScaleWidth And TextHeight(msg) <= ScaleHeight Then
            ' we've found a font size that is OK
            Exit For
        End If
    Next
    ' enable timer
    Timer1.Enabled = True
    Timer1.Interval = 1000
End Sub

Private Sub Timer1_Timer()
    Cls
    '##InsertStatement Me.CurrentX = -120
    Print Time$
End Sub


