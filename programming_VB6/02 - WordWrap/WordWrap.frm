VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Wrap Line Demo"
   ClientHeight    =   4455
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7650
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
   ScaleHeight     =   4455
   ScaleWidth      =   7650
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Paint()
    Dim msg As String, pos As Long, spacePos As Long
    
    msg = "You often use the TextWidth and TextHeight methods to check if a message can fit within a given area. " & vbCrLf & "This is especially necessary when you print to a form, because the Print method doesn't support automatic wrapping for longer lines, and you are to solve the problem through code."
    
    Cls
    Do While pos < Len(msg)
        pos = pos + 1
        If Mid$(msg, pos, 2) = vbCrLf Then
            ' we have found a CR-LF pair, print the message
            ' up to this point and reset variables
            Print Left$(msg, pos - 1)
            msg = LTrim$(Mid$(msg, pos + 2))
            pos = 0
            spacePos = 0
        ElseIf Mid$(msg, pos, 1) = " " Then
            ' if this is a space, remember its position
            spacePos = pos
        End If
        ' check the message width so far
        Dim tw As Single
        tw = TextWidth(Left$(msg, pos))
        
        If tw > ScaleWidth Then
            ' the message is too long, let's split it
            ' if we met a space, split it there
            If spacePos Then pos = spacePos
            ' print the message up to the split point
            Print Left$(msg, pos - 1)
            ' discard characters just printed, reset variables
            msg = LTrim$(Mid$(msg, pos))
            pos = 0
            spacePos = 0
        End If
    Loop
    ' print residual characters, if any
    If Len(msg) Then Print msg

End Sub

Private Sub Form_Resize()
    Refresh
End Sub
