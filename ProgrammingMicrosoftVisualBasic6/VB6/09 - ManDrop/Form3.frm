VERSION 5.00
Begin VB.Form Form3 
   Caption         =   "Filename Drag-And-Drop Source"
   ClientHeight    =   2820
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6270
   LinkTopic       =   "Form3"
   ScaleHeight     =   2820
   ScaleWidth      =   6270
   StartUpPosition =   3  'Windows Default
   Begin VB.FileListBox File1 
      Height          =   2430
      Left            =   3000
      MultiSelect     =   2  'Extended
      TabIndex        =   2
      Top             =   120
      Width           =   3015
   End
   Begin VB.DirListBox Dir1 
      Height          =   1890
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   2775
   End
   Begin VB.DriveListBox Drive1 
      Height          =   315
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2775
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Drive1_Change()
    Dir1.path = Drive1.List(Drive1.ListIndex)
End Sub

Private Sub Dir1_Change()
    File1.path = Dir1.List(Dir1.ListIndex)
End Sub

Private Sub File1_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
    If Button = 2 Then File1.OLEDrag
End Sub

Private Sub File1_OLEStartDrag(Data As DataObject, AllowedEffects As Long)
    Dim i As Integer, path As String
    path = File1.path & IIf(Right$(File1.path, 1) <> "\", "\", "")
    
    ' add all selected files
    Data.Files.Clear
    For i = 0 To File1.ListCount - 1
        If File1.Selected(i) Then
            Data.Files.Add path & File1.List(i)
        End If
    Next
    
    If Data.Files.Count Then
        ' only if we actually added files
        Data.SetData , vbCFFiles
        AllowedEffects = vbDropEffectCopy
    End If
End Sub






