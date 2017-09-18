VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Drag-And-Drop Word Parser"
   ClientHeight    =   5055
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7965
   LinkTopic       =   "Form1"
   ScaleHeight     =   5055
   ScaleWidth      =   7965
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkLoadOnDemand 
      Caption         =   "&Load data on-demand"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   4680
      Width           =   3975
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   4440
      Top             =   4320
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin RichTextLib.RichTextBox rtfText 
      Height          =   3495
      Left            =   240
      TabIndex        =   3
      Top             =   1200
      Width           =   4095
      _ExtentX        =   7223
      _ExtentY        =   6165
      _Version        =   393217
      ScrollBars      =   2
      OLEDragMode     =   0
      OLEDropMode     =   1
      TextRTF         =   $"Form1.frx":0000
   End
   Begin VB.CommandButton cmdBrowse 
      Caption         =   "&Browse"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   240
      TabIndex        =   2
      Top             =   240
      Width           =   1215
   End
   Begin VB.ListBox lstWords 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3420
      Left            =   4560
      OLEDropMode     =   1  'Manual
      Sorted          =   -1  'True
      TabIndex        =   0
      Top             =   1200
      Width           =   3135
   End
   Begin VB.Image imgCopy 
      Height          =   480
      Left            =   4320
      Picture         =   "Form1.frx":00C9
      Top             =   2280
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Label Label1 
      Caption         =   $"Form1.frx":02DB
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   1800
      TabIndex        =   1
      Top             =   120
      Width           =   5895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdBrowse_Click()
    ' load a file into the RTFbox control
    ' you can read the same result using drag and drop from
    ' an external program (its OLEDropMode is set to automatic)
    With CommonDialog1
        .Filter = "All files|*.*|Text Files (*.txt;*.doc;*.rtf)|*.txt;*.doc;*.rtf"
        .FilterIndex = 2
        .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
        .DialogTitle = "Select a text file"
        .filename = ""
        .ShowOpen
        If .filename <> "" Then
            rtfText.LoadFile .filename
        End If
    End With
End Sub

Private Sub rtfText_OLEDragOver(Data As RichTextLib.DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    ' prepare to receive text or a filename
    If Data.GetFormat(vbCFText) Or Data.GetFormat(vbCFRTF) Or Data.GetFormat(vbCFFiles) Then
        If Effect And vbDropEffectCopy Then
            Effect = vbDropEffectCopy
        ElseIf Effect And vbDropEffectMove Then
            Effect = vbDropEffectMove
        End If
    End If
End Sub

Private Sub rtfText_OLEDragDrop(Data As RichTextLib.DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    If Data.GetFormat(vbCFText) Then
        rtfText.SelText = Data.GetData(vbCFText)
    ElseIf Data.GetFormat(vbCFRTF) Then
        rtfText.SelRTF = Data.GetData(vbCFRTF)
    ElseIf Data.GetFormat(vbCFFiles) Then
        Open Data.Files(1) For Input As #1
        rtfText.SelText = Input$(LOF(1), 1)
        Close #1
    End If
End Sub



Private Sub rtfText_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' start a drag operation if right button is pressed
    If Button = 2 Then rtfText.OLEDrag
End Sub

Private Sub rtfText_OLEStartDrag(Data As RichTextLib.DataObject, AllowedEffects As Long)
    ' use selected text, or all text if no text is currently
    If chkLoadOnDemand Then
        ' just inform which format this control supports
        Data.SetData , vbCFRTF
        Data.SetData , vbCFText
    ElseIf rtfText.SelLength Then
        Data.SetData rtfText.SelRTF, vbCFRTF
        Data.SetData rtfText.SelText, vbCFText
    Else
        Data.SetData rtfText.TextRTF, vbCFRTF
        Data.SetData rtfText.text, vbCFText
    End If
    AllowedEffects = vbDropEffectMove Or vbDropEffectCopy
End Sub

Private Sub lstWords_OLEDragOver(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single, State As Integer)
    ' select Copy action if possible, otherwise select Move
    If Not Data.GetFormat(vbCFText) Then
        ' source control doesn't export Text format
        Effect = 0
    ElseIf Effect And vbDropEffectCopy Then
        Effect = vbDropEffectCopy
    ElseIf Effect And vbDropEffectMove Then
        Effect = vbDropEffectMove
    End If
    ' as a demonstation, change the background of this listbox when
    ' the mouse is over it
    If State = vbLeave Then
        ' restore back color on exit
        lstWords.BackColor = vbWindowBackground
    ElseIf Effect <> 0 And State = vbEnter Then
        ' change back color on entry
        lstWords.BackColor = vbYellow
    End If
End Sub

Private Sub lstWords_OLEGiveFeedback(Effect As Long, DefaultCursors As Boolean)
    ' if effect is Copy, use a custom cursor
    If Effect = vbDropEffectCopy Then
        DefaultCursors = False
        Screen.MousePointer = vbCustom
        Screen.MouseIcon = imgCopy.Picture
    Else
        DefaultCursors = True
    End If
End Sub

Private Sub lstWords_OLEDragDrop(Data As DataObject, Effect As Long, Button As Integer, Shift As Integer, X As Single, Y As Single)
    ' restore the correct background color
    lstWords.BackColor = vbWindowBackground
    
    ' select Copy action if possible, otherwise select Move
    If Effect And vbDropEffectCopy Then
        Effect = vbDropEffectCopy
    ElseIf Effect And vbDropEffectMove Then
        Effect = vbDropEffectMove
    End If
    
    ' in either case, ask for the data - only plain text is supported
    Dim text As String, w As Variant
    text = Data.GetData(vbCFText)
    ' add a trailing space to ensure that the last word is extracted correctly
    text = text & " "
    
    ' parse the text and extract individual words
    Dim i As Long, start As Long, words As New Collection
    On Error Resume Next
    
    For i = 1 To Len(text)
        If Mid$(text, i, 1) Like "[!A-Za-z0-9]" Then
            ' it is a separator, if we were inside a word we
            ' can extract it
            If start Then
                ' add this word to the collection, but ignore duplicates
                w = Mid$(text, start, i - start)
                words.Add w, w
                start = 0
            End If
        ElseIf start = 0 Then
            ' we have found the start of a new word
            start = i
        End If
    Next
    
    ' add all the words to the ListBox control
    lstWords.Clear
    For Each w In words
        lstWords.AddItem w
    Next
    
End Sub

Private Sub rtfText_OLESetData(Data As RichTextLib.DataObject, DataFormat As Integer)
    ' this event fires only if chkLoadOnDemand is checked, when
    ' the target control invokes the Data's GetData method
    If DataFormat = vbCFText Then
        If rtfText.SelLength Then
            Data.SetData rtfText.SelText, vbCFText
        Else
            Data.SetData rtfText.text, vbCFText
        End If
    ElseIf DataFormat = vbCFRTF Then
        If rtfText.SelLength Then
            Data.SetData rtfText.SelRTF, vbCFRTF
        Else
            Data.SetData rtfText.TextRTF, vbCFRTF
        End If
    End If
        
End Sub

Private Sub rtfText_OLECompleteDrag(Effect As Long)
    If Effect = vbDropEffectMove Then
        ' if this was a Move operation, delete the highlighted text, if any
        rtfText.SelText = ""
    Else
        ' if it was a Copy command, just clear the selection
        rtfText.SelLength = 0
    End If
End Sub



