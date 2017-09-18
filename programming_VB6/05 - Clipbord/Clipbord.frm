VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form Form1 
   Caption         =   "Clipboard Demo"
   ClientHeight    =   4710
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   8880
   LinkTopic       =   "Form1"
   ScaleHeight     =   4710
   ScaleWidth      =   8880
   StartUpPosition =   3  'Windows Default
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   2295
      Left            =   120
      TabIndex        =   2
      Top             =   2280
      Width           =   5295
      _ExtentX        =   9340
      _ExtentY        =   4048
      _Version        =   393217
      Enabled         =   -1  'True
      ScrollBars      =   3
      TextRTF         =   $"Clipbord.frx":0000
   End
   Begin VB.PictureBox Picture1 
      Height          =   4575
      Left            =   5520
      ScaleHeight     =   4515
      ScaleWidth      =   3195
      TabIndex        =   1
      Top             =   0
      Width           =   3255
   End
   Begin VB.TextBox Text1 
      Height          =   2175
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   0
      Top             =   0
      Width           =   5295
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Undo"
         Index           =   0
         Shortcut        =   ^Z
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "-"
         Index           =   1
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "Cu&t"
         Index           =   2
         Shortcut        =   ^X
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Copy"
         Index           =   3
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Paste"
         Index           =   4
         Shortcut        =   ^V
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "-"
         Index           =   5
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "C&lear"
         Index           =   6
         Shortcut        =   {DEL}
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "Select &All"
         Index           =   7
         Shortcut        =   ^A
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DisableMessage 0354

Option Explicit

Const MNU_EDITUNDO = 0
Const MNU_EDITCUT = 2
Const MNU_EDITCOPY = 3
Const MNU_EDITPASTE = 4
Const MNU_EDITCLEAR = 6
Const MNU_EDITSELECTALL = 7

Private Sub Form_Resize()
    Text1.Move 0, 0, ScaleWidth / 2, ScaleHeight / 2
    RichTextBox1.Move 0, ScaleHeight / 2, ScaleWidth / 2, ScaleHeight / 2
    Picture1.Move ScaleWidth / 2, 0, ScaleWidth / 2, ScaleHeight
End Sub

Private Sub mnuFileExit_Click()
    Unload Me
End Sub

' enable/disable items in the Edit menu

Private Sub mnuEdit_Click()
    Dim supSelText As Boolean, supPicture As Boolean
    
    On Error Resume Next
    
    ' disable all menu items here
    mnuEditItem(MNU_EDITUNDO).Enabled = False
    mnuEditItem(MNU_EDITCUT).Enabled = False
    mnuEditItem(MNU_EDITCOPY).Enabled = False
    mnuEditItem(MNU_EDITPASTE).Enabled = False
    mnuEditItem(MNU_EDITCLEAR).Enabled = False
    mnuEditItem(MNU_EDITSELECTALL).Enabled = False
    
    ' check which properties are supported by the active control
    supSelText = Len(ActiveControl.SelText) >= 0
    supPicture = (ActiveControl.Picture Is Nothing) Or True
    ' if no property is supported, exit right now
    If (supSelText Or supPicture) = 0 Then Exit Sub
    
    ' process the Cut menu
    If supSelText Then
        mnuEditItem(MNU_EDITCUT).Enabled = Len(ActiveControl.SelText)
    Else
        mnuEditItem(MNU_EDITCUT).Enabled = Not (ActiveControl.Picture Is Nothing)
    End If
    
    ' the Copy menu command is similar to Cut
    mnuEditItem(MNU_EDITCOPY).Enabled = mnuEditItem(MNU_EDITCUT).Enabled
    
    ' process the Paste menu
    If supSelText Then
        mnuEditItem(MNU_EDITPASTE).Enabled = Clipboard.GetFormat(vbCFText)
    Else
        mnuEditItem(MNU_EDITPASTE).Enabled = Clipboard.GetFormat(vbCFBitmap) Or Clipboard.GetFormat(vbCFMetafile)
    End If
    
    ' process the Clear command
    If supSelText Then
        mnuEditItem(MNU_EDITCLEAR).Enabled = Len(ActiveControl.SelText)
    Else
        mnuEditItem(MNU_EDITCLEAR).Enabled = Not (ActiveControl.Picture Is Nothing)
    End If
    
    ' process the SelectAll command
    If supSelText Then
        mnuEditItem(MNU_EDITSELECTALL).Enabled = Len(ActiveControl.Text)
    End If
End Sub

Private Sub mnuEditItem_Click(Index As Integer)
    Dim supSelText As Boolean, supSelRTF As Boolean, supPicture As Boolean
    
    On Error Resume Next
    
    ' check which properties are supported by the active control
    supSelText = Len(ActiveControl.SelText) >= 0
    supSelRTF = Len(ActiveControl.SelRTF) >= 0
    supPicture = (ActiveControl.Picture Is Nothing) Or True
    ' if no property is supported, exit right now
    If (supSelText Or supSelRTF Or supPicture) = 0 Then Exit Sub
    Err.Clear
    
    Select Case Index
        Case MNU_EDITUNDO
            ' this menu item isn't used in this demo program
        Case MNU_EDITCUT
            If supSelText Then
                Clipboard.Clear
                If supSelRTF Then
                    ' if it also supports SelText, cut it too
                    Clipboard.SetText ActiveControl.SelRTF, vbCFRTF
                End If
                Clipboard.SetText ActiveControl.SelText
                ActiveControl.SelText = ""
            Else
                Clipboard.SetData ActiveControl.Picture
                Set ActiveControl.Picture = Nothing
            End If
        Case MNU_EDITCOPY
            ' similar to Cut, but the current selection isn't deleted
            If supSelText Then
                Clipboard.Clear
                If supSelRTF Then
                    ' if it also supports SelText, cut it too
                    Clipboard.SetText ActiveControl.SelRTF, vbCFRTF
                End If
                Clipboard.SetText ActiveControl.SelText
            Else
                Clipboard.SetData ActiveControl.Picture
            End If
        Case MNU_EDITPASTE
            If supSelRTF And Clipboard.GetFormat(vbCFRTF) Then
                ' paste RTF text if possible
                ActiveControl.SelRTF = Clipboard.GetText(vbCFText)
            ElseIf supSelText Then
                ' else, paste regular text
                ActiveControl.SelText = Clipboard.GetText(vbCFText)
            ElseIf Clipboard.GetFormat(vbCFBitmap) Then
                ' first, try with bitmap data
                Set ActiveControl.Picture = Clipboard.GetData(vbCFBitmap)
            Else
                ' else, try with metafile data
                Set ActiveControl.Picture = Clipboard.GetData(vbCFMetafile)
            End If
        Case MNU_EDITCLEAR
            If supSelText Then
                ActiveControl.SelText = ""
            Else
                Set ActiveControl.Picture = Nothing
            End If
        Case MNU_EDITSELECTALL
            If supSelText Then
                ActiveControl.SelStart = 0
                ActiveControl.SelLength = Len(ActiveControl.Text)
            End If
    End Select
End Sub

Private Sub Picture1_GotFocus()
    Debug.Print "GotFocus"
End Sub

Private Sub Picture1_LostFocus()
    Debug.Print "LostFocus"
End Sub

