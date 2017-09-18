VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Rubber-bound rectangles"
   ClientHeight    =   3915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7575
   LinkTopic       =   "Form1"
   ScaleHeight     =   3915
   ScaleWidth      =   7575
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim X1 As Single, X2 As Single
Dim Y1 As Single, Y2 As Single
' true if we are dragging a rectangle
Dim dragging As Boolean

Private Sub Form_Load()
    ' rubber-banding works particularly well
    ' on a black background
    BackColor = vbBlack
End Sub

Private Sub Form_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Button And 3 Then
        dragging = True
        ' remember starting coordinates
        X1 = X
        Y1 = Y
        X2 = X
        Y2 = Y
        ' select a  random color
        ForeColor = RGB(Rnd * 255, Rnd * 255, Rnd * 255)
        ' select a random width
        DrawWidth = Rnd * 3 + 1
        ' draw the very first rectangle, in Xor mode
        DrawMode = vbXorPen
        Line (X1, Y1)-(X2, Y2), , B
        If Button = 2 Then
            ' filled rectangles
            FillStyle = vbFSSolid
            FillColor = ForeColor
        End If
    End If
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If dragging Then
        ' delete old rectangle
        ' (repeat the same command in Xor mode)
        Line (X1, Y1)-(X2, Y2), , B
        ' redraw to new coordinates
        X2 = X
        Y2 = Y
        Line (X1, Y1)-(X2, Y2), , B
    End If
End Sub

Private Sub Form_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
    If dragging Then
        dragging = False
        ' draw the definitive rectable
        DrawMode = vbCopyPen
        Line (X1, Y1)-(X, Y), , B
        FillStyle = vbFSTransparent
    End If
End Sub
