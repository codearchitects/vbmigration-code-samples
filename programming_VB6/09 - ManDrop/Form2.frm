VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Drag-And-Drop Batch File Editor"
   ClientHeight    =   5220
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8400
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form2"
   ScaleHeight     =   5220
   ScaleWidth      =   8400
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton optDropMode 
      Caption         =   "Drop File &Contents (single file only)"
      Height          =   255
      Index           =   1
      Left            =   3480
      TabIndex        =   4
      Top             =   4920
      Width           =   4695
   End
   Begin VB.OptionButton optDropMode 
      Caption         =   "Drop File &Names"
      Height          =   255
      Index           =   0
      Left            =   240
      TabIndex        =   3
      Top             =   4920
      Value           =   -1  'True
      Width           =   3255
   End
   Begin VB.CommandButton cmdSeparator 
      Caption         =   "Change &Separator"
      Height          =   615
      Left            =   120
      TabIndex        =   2
      Top             =   240
      Width           =   1215
   End
   Begin VB.TextBox txtEditor 
      Height          =   3615
      Left            =   0
      MultiLine       =   -1  'True
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   1  'Manual
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Top             =   1200
      Width           =   8175
   End
   Begin VB.Label Label1 
      Caption         =   $"Form2.frx":0000
      Height          =   975
      Left            =   1560
      TabIndex        =   1
      Top             =   120
      Width           =   6855
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' remember separator char among drop actions
Dim sepChar As String

Private Sub cmdSeparator_Click()
    Dim temp As String
    temp = InputBox$("Enter a new separator character. Use ^T for tab, ^N for Newline.", "Command Editor", sepChar)
    Select Case UCase$(temp)
        Case ""
        Case "^T"
            sepChar = vbTab
        Case "^N"
            sepChar = vbCrLf
        Case Else
            sepChar = temp
    End Select
End Sub

Private Sub txtEditor_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, x As Single, y As Single, State As Integer)
    ' this editor can work as as the target of a drag operation
    ' if data is text or file names
    If Data.GetFormat(vbCFText) Or Data.GetFormat(vbCFFiles) Then
        ' supports either copy or move action
        If Effect And vbDropEffectCopy Then
            Effect = vbDropEffectCopy
        ElseIf Effect And vbDropEffectMove Then
            Effect = vbDropEffectMove
        End If
    Else
        Effect = 0
    End If
End Sub

Private Sub txtEditor_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, x As Single, y As Single)
    Dim temp As String, i As Long, text As String
    
    If Data.GetFormat(vbCFText) Then
        ' if text is being dropped, just insert it in the proper position
        txtEditor.SelText = Data.GetData(vbCFText)
    ElseIf Data.GetFormat(vbCFFiles) Then
        If optDropMode(1).Value Then
            ' we are dropping file contents
            Open Data.Files(1) For Input As #1
            txtEditor.SelText = Input$(LOF(1), 1)
            Close #1
        Else
            ' we are dropping file names
            For i = 1 To Data.Files.Count
                If i > 1 Then text = text & IIf(sepChar = "", vbCrLf, sepChar)
                ' if Ctrl key is pressed, use complete path
                ' otherwise just use the file name
                If Shift And vbCtrlMask Then
                    text = text & Data.Files(i)
                Else
                    text = text & GetFileName(Data.Files(i))
                End If
            Next
            ' insert text at the caret position
            txtEditor.SelText = text
        End If
    End If
End Sub

' return the base filename+ext, given the complete file name

Private Function GetFileName(filename As String) As String
    GetFileName = Mid$(filename, InStrRev(filename, "\") + 1)
End Function

