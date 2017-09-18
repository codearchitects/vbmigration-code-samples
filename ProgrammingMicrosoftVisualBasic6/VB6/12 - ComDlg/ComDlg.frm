VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form Form1 
   Caption         =   "CommonDialog Control Demo"
   ClientHeight    =   3570
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7335
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   9.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   3570
   ScaleWidth      =   7335
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOpenMulti 
      Caption         =   "Open &Multi"
      Height          =   375
      Left            =   6000
      TabIndex        =   6
      Top             =   0
      Width           =   1215
   End
   Begin VB.CommandButton cmdOpen 
      Caption         =   "&Open"
      Height          =   375
      Left            =   4800
      TabIndex        =   5
      Top             =   0
      Width           =   1215
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   3600
      TabIndex        =   4
      Top             =   0
      Width           =   1215
   End
   Begin VB.CommandButton cmdPrinter 
      Caption         =   "&Printer"
      Height          =   375
      Left            =   2400
      TabIndex        =   3
      Top             =   0
      Width           =   1215
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   1815
      Left            =   0
      TabIndex        =   2
      Top             =   480
      Width           =   5415
      _ExtentX        =   9551
      _ExtentY        =   3201
      _Version        =   393217
      Enabled         =   -1  'True
      HideSelection   =   0   'False
      ScrollBars      =   2
      DisableNoScroll =   -1  'True
      TextRTF         =   $"ComDlg.frx":0000
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   5760
      Top             =   480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdFont 
      Caption         =   "&Font"
      Height          =   375
      Left            =   1200
      TabIndex        =   1
      Top             =   0
      Width           =   1215
   End
   Begin VB.CommandButton cmdColor 
      Caption         =   "&Color"
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

'##project:DefaultMemberSupport False
'##project:DisableMessage 0501
'##project:DisableMessage 0551

Dim Filename As String

Private Sub cmdPrinter_Click()
    Dim saveSelStart As Long, saveSelLength As Long
    
    On Error Resume Next
    With CommonDialog1
        .CancelError = True
        .Flags = cdlPDHidePrintToFile Or cdlPDNoPageNums Or cdlPDReturnDC
        If RichTextBox1.SelLength = 0 Then
            ' if no text is select, disable the option on the dialog
            .Flags = .Flags Or cdlPDNoSelection
        Else
            ' otherwise make "Selection" the default choice
            .Flags = .Flags Or cdlPDSelection
        End If
        .ShowPrinter
        If Err = 0 Then
            If .Flags And cdlPDSelection Then
                ' User decided to print the current selection,
                RichTextBox1.SelPrint .hDC
            Else
                ' User decided to print the entire contents, so select it
                saveSelStart = RichTextBox1.SelStart
                saveSelLength = RichTextBox1.SelLength
                RichTextBox1.SelStart = 0
                RichTextBox1.SelLength = 999999
                ' Print on the device context returned by the common dialog
                RichTextBox1.SelPrint .hDC
                ' Restore old selection
                RichTextBox1.SelStart = saveSelStart
                RichTextBox1.SelLength = saveSelLength
            End If
        End If
    End With
End Sub

Private Sub Form_Resize()
    ' Some smart resizing.
    RichTextBox1.Move 0, RichTextBox1.Top, ScaleWidth, ScaleHeight - RichTextBox1.Top
End Sub

Private Sub cmdColor_Click()
    On Error Resume Next
    
    With CommonDialog1
        .Flags = cdlCCFullOpen
        If Not IsNull(RichTextBox1.SelColor) Then
            .Flags = .Flags Or cdlCCRGBInit
            .Color = RichTextBox1.SelColor
        End If
        .CancelError = True
        .ShowColor
        If Err = 0 Then
            RichTextBox1.SelColor = .Color
        End If
    End With
End Sub

Private Sub cmdFont_Click()
    ' This undocumented flag excludes vertical fonts.
    Const CF_NOVERTFONTS = &H400000
    
    On Error Resume Next
    
    With CommonDialog1
        .CancelError = True
        .Flags = cdlCFBoth Or cdlCFForceFontExist Or cdlCFEffects Or cdlCFLimitSize
        If IsNull(RichTextBox1.SelFontName) Then
            .Flags = .Flags Or cdlCFNoFaceSel
        Else
            .FontName = RichTextBox1.SelFontName
        End If
        If IsNull(RichTextBox1.SelFontSize) Then
            .Flags = .Flags Or cdlCFNoSizeSel
        Else
            .FontSize = RichTextBox1.SelFontSize
        End If
        If IsNull(RichTextBox1.SelBold) Or IsNull(RichTextBox1.SelItalic) Then
            .Flags = .Flags Or cdlCFNoStyleSel
        Else
            .FontBold = RichTextBox1.SelBold
            .FontItalic = RichTextBox1.SelItalic
        End If
        If Not IsNull(RichTextBox1.SelColor) Then
            .Color = RichTextBox1.SelColor
        End If
        .Min = 8
        .Max = 80
        .ShowFont
        If Err = 0 Then
            RichTextBox1.SelFontName = .FontName
            RichTextBox1.SelBold = .FontBold
            RichTextBox1.SelItalic = .FontItalic
            If (.Flags And cdlCFNoSizeSel) = 0 Then
                RichTextBox1.SelFontSize = .FontSize
            End If
            RichTextBox1.SelUnderline = .FontUnderline
            RichTextBox1.SelStrikeThru = .FontStrikethru
            RichTextBox1.SelColor = .Color
        End If
    End With

End Sub

Private Sub cmdSave_Click()
    If SaveTextControl(RichTextBox1, CommonDialog1, Filename) Then
        MsgBox "Text has been saved to file " & Filename
    End If
End Sub

Private Sub cmdOpen_Click()
    If LoadTextControl(RichTextBox1, CommonDialog1, Filename) Then
        MsgBox "Text has been loaded from file " & Filename
    End If
End Sub

Private Sub cmdOpenMulti_Click()
    Dim Filenames() As String
    If SelectMultipleFiles(CommonDialog1, "", Filenames()) Then
        ' load the array of results into the RTFBox control
        RichTextBox1.Text = Join(Filenames(), vbCrLf)
    End If
End Sub

' A reusable routine that can save the contents of a TextBox or
' a RichTextBox control. On Exit FileName the selected filename.
' Returns False if the command has been canceled, True otherwise.

Function SaveTextControl(TB As Control, CD As CommonDialog, Filename As String) As Boolean
    Dim filenum As Integer
    On Error GoTo ExitNow
    
    CD.Filter = "All files (*.*)|*.*|Text files|*.txt"
    CD.FilterIndex = 2
    CD.DefaultExt = "txt"
    If TypeName(TB) = "RichTextBox" Then
        CD.Filter = CD.Filter & "|RTF files|*.rtf"
        CD.FilterIndex = 3
        CD.DefaultExt = "rtf"
    End If
    CD.Flags = cdlOFNHideReadOnly Or cdlOFNPathMustExist Or _
        cdlOFNOverwritePrompt Or cdlOFNNoReadOnlyReturn
    CD.DialogTitle = "Select the destination file "
    CD.Filename = Filename
    ' Exit if user presses Cancel.
    CD.CancelError = True
    CD.ShowSave
    Filename = CD.Filename
    
    ' Write the control's contents.
    filenum = FreeFile()
    Open Filename For Output As #filenum
    If TypeName(TB) = "RichTextBox" Then
        Print #filenum, TB.TextRTF;
    Else
        Print #filenum, TB.Text;
    End If
    Close #filenum
    ' Signal success.
    SaveTextControl = True
ExitNow:

End Function

' A reusable routine that can load the contents of a TextBox or
' a RichTextBox control. On exit, Filename contains the selected filename.
' Returns False if the command has been canceled, True otherwise.

Function LoadTextControl(TB As Control, CD As CommonDialog, Filename As String) As Boolean
    Dim filenum As Integer
    On Error GoTo ExitNow
    
    CD.Filter = "All files (*.*)|*.*|Text files|*.txt"
    CD.FilterIndex = 2
    CD.DefaultExt = "txt"
    If TypeName(TB) = "RichTextBox" Then
        CD.Filter = CD.Filter & "|RTF files|*.rtf"
        CD.FilterIndex = 3
        CD.DefaultExt = "rtf"
    End If
    CD.Flags = cdlOFNHideReadOnly Or cdlOFNFileMustExist Or _
        cdlOFNNoReadOnlyReturn
    CD.DialogTitle = "Select the source file "
    CD.Filename = Filename
    ' Exit if user presses Cancel.
    CD.CancelError = True
    CD.ShowOpen
    Filename = CD.Filename
    
    ' Read the file's contents into the control.
    filenum = FreeFile()
    Open Filename For Input As #filenum
    If TypeName(TB) = "RichTextBox" Then
        TB.TextRTF = Input$(LOF(filenum), filenum)
    Else
        TB.Text = Input$(LOF(filenum), filenum)
    End If
    Close #filenum
    ' Signal success.
    LoadTextControl = True
ExitNow:

End Function

' Reusable routines that displays a multi-selection FileOpen dialog
' and returns an array of strings with all the selected files.
' Returns False if the command has been canceled, True otherwise.

Function SelectMultipleFiles(CD As CommonDialog, Filter As String, Filenames() As String) As Boolean
    On Error GoTo ExitNow
    
    CD.Filter = "All files (*.*)|*.*|" & Filter
    CD.FilterIndex = 1
    CD.Flags = cdlOFNAllowMultiselect Or cdlOFNFileMustExist Or cdlOFNExplorer
    CD.DialogTitle = "Select one or more files"
    CD.MaxFileSize = 10240
    CD.Filename = ""
    ' Exit if user presses Cancel.
    CD.CancelError = True
    CD.ShowOpen
    ' Parse the result to get filenames.
    Filenames() = Split(CD.Filename, vbNullChar)
    ' Signal success.
    SelectMultipleFiles = True

ExitNow:
End Function



