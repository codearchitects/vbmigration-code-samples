VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Caro (Da duoc cai tien tu sach Slide Show)"
   ClientHeight    =   6900
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   7995
   LinkTopic       =   "Form1"
   ScaleHeight     =   460
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   533
   StartUpPosition =   3  'Windows Default
   Begin VB.Menu mnufile 
      Caption         =   "File"
      Begin VB.Menu mnunew 
         Caption         =   "&New"
      End
      Begin VB.Menu mnuopt 
         Caption         =   "&Options"
      End
      Begin VB.Menu mnutam 
         Caption         =   "-"
      End
      Begin VB.Menu mnuexit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnulevel1 
      Caption         =   "Level 1"
   End
   Begin VB.Menu mnulevel2 
      Caption         =   "Level 2"
      Enabled         =   0   'False
   End
   Begin VB.Menu mnulevel3 
      Caption         =   "Level 3"
      Enabled         =   0   'False
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'## project:ArrayBounds ForceZero
'## project:DisableMessages CodeAnalysis
'## project:DisableMessage 0354

Option Explicit
Const n = 20
Const d = 20
Const ox = 50
Const oy = 50

Const userid = 1
Const comid = 2
Dim com As computer1
Dim bang(1 To n, 1 To n) As Integer


Private Sub veo(i As Integer, j As Integer)
DrawWidth = 3
'X
If bang(i, j) = 1 Then
    Line (ox + (j - 1) * d + 2, oy + (i - 1) * d + 2)-(ox + j * d - 2, oy + i * d - 2), vbRed
    Line (ox + (j - 1) * d + 2, oy + i * d - 2)-(ox + j * d - 2, oy + (i - 1) * d + 2), vbRed
End If
'O
If bang(i, j) = 2 Then
    Circle (ox + (j - 1) * d + d \ 2, oy + (i - 1) * d + d \ 2), d \ 2 - 1, vbBlue
End If
End Sub

Private Sub Form_Load()
Dim i As Integer, j As Integer
Set com = New computer1
com.n = n
For i = 1 To n
    For j = 1 To n
        bang(i, j) = 1
    Next
Next
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Dim i As Integer, j As Integer
Dim nx As Integer, ny As Integer
If com.checkwin Then Exit Sub
'Tinh vi tri
i = (Y - oy) \ d + 1
j = (X - ox) \ d + 1
If (i < 0) Or (i > n) Or (j < 0) Or (j > n) Then Exit Sub
If bang(i, j) <> 0 Then Exit Sub
bang(i, j) = userid
Call com.gan(i, j, bang(i, j))
Call veo(i, j)
If com.checkwin Then MsgBox ("Ban da thang")
'Computer
Call com.timnuocdi(i, j)
bang(i, j) = comid
Call com.gan(i, j, bang(i, j))
Call veo(i, j)
If com.checkwin Then MsgBox ("May da thang")
End Sub

Private Sub veban()
Dim i As Integer, j As Integer
'To
DrawWidth = 1
For i = 1 To n
    For j = 1 To n
        Line (ox + (i - 1) * d, oy + (j - 1) * d)-(ox + i * d, oy + j * d), vbWhite, BF
    Next
Next
'Ke
For i = 0 To n
    Line (ox + i * d, oy)-(ox + i * d, oy + n * d), vbBlack
Next
For i = 0 To n
    Line (ox, oy + i * d)-(ox + n * d, oy + i * d), vbBlack
Next
End Sub

Private Sub mnuexit_Click()
End
End Sub

Private Sub mnunew_Click()
Dim i As Integer, j As Integer
'Khoi tao
Call veban
For i = 1 To n
    For j = 1 To n
        bang(i, j) = 0
        Call com.gan(i, j, 0)
    Next
Next
End Sub


