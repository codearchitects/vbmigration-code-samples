VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Poor Man's Tables"
   ClientHeight    =   4650
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   2865
   LinkTopic       =   "Form1"
   ScaleHeight     =   4650
   ScaleWidth      =   2865
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstSquare 
      Height          =   3960
      Left            =   600
      TabIndex        =   1
      Top             =   360
      Width           =   1815
   End
   Begin VB.ListBox lstN 
      Height          =   3960
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   975
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "N ^ 2"
      Height          =   255
      Left            =   600
      TabIndex        =   3
      Top             =   120
      Width           =   1815
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "N"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
    ' load values for numbers 1-100
    Dim n As Long
    For n = 1 To 100
        lstN.AddItem n
        lstSquare.AddItem n * n
    Next
    
    
End Sub

Private Sub lstN_Click()
    ' synchronize listboxes
    lstSquare.TopIndex = lstN.TopIndex
    lstSquare.ListIndex = lstN.ListIndex
End Sub

Private Sub lstSquare_Click()
    ' synchronize listboxes
    lstN.TopIndex = lstSquare.TopIndex
    lstN.ListIndex = lstSquare.ListIndex
End Sub

Private Sub lstN_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Call lstN_Click
End Sub

Private Sub lstN_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Call lstN_Click
End Sub

Private Sub lstSquare_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Call lstSquare_Click
End Sub

Private Sub lstSquare_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    Call lstSquare_Click
End Sub

Private Sub lstN_Scroll()
    lstSquare.TopIndex = lstN.TopIndex
End Sub

Private Sub lstSquare_Scroll()
    lstN.TopIndex = lstSquare.TopIndex
End Sub


