VERSION 5.00
Begin VB.Form frmCountDown 
   Caption         =   "CountDown"
   ClientHeight    =   2970
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4845
   LinkTopic       =   "Form1"
   ScaleHeight     =   2970
   ScaleWidth      =   4845
   StartUpPosition =   3  'Windows Default
   Begin VB.Label lblCount 
      Alignment       =   2  'Center
      Height          =   2655
      Left            =   240
      TabIndex        =   0
      Top             =   0
      Width           =   4215
   End
End
Attribute VB_Name = "frmCountDown"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    Caption = "CountDown  -  Thread = " & App.ThreadID
End Sub

Private Sub Form_Resize()
    Dim n As Integer
    lblCount.Move 0, 0, ScaleWidth, ScaleHeight
    
    For n = 200 To 20 Step -5
        Font.Size = n
        If TextWidth("00") < ScaleWidth And TextHeight("00") < ScaleHeight Then
            lblCount.FontSize = n
            Exit For
        End If
    Next
End Sub

