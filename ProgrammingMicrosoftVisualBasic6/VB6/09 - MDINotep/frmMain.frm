VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.MDIForm frmMainMDI 
   BackColor       =   &H8000000C&
   Caption         =   "MDI Notepad"
   ClientHeight    =   5355
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   8505
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   3600
      Top             =   480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      NegotiatePosition=   1  'Left
      Begin VB.Menu mnuFileNew 
         Caption         =   "&New"
         Shortcut        =   ^N
      End
      Begin VB.Menu mnuFileOpen 
         Caption         =   "&Open..."
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuFileClose 
         Caption         =   "&Close"
      End
      Begin VB.Menu mnuBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileSave 
         Caption         =   "&Save"
         Shortcut        =   ^S
      End
      Begin VB.Menu mnuFileSaveAs 
         Caption         =   "Save &As"
      End
      Begin VB.Menu mnuFileSaveAll 
         Caption         =   "Save All"
      End
      Begin VB.Menu mnuBar2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFilePrint 
         Caption         =   "&Print..."
      End
      Begin VB.Menu mnuFilePrintSetup 
         Caption         =   "Print Set&up..."
      End
      Begin VB.Menu mnuBar3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
      Begin VB.Menu mnuEditItem 
         Caption         =   "Cu&t"
         Index           =   0
         Shortcut        =   ^X
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Copy"
         Index           =   1
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Paste"
         Index           =   2
         Shortcut        =   ^V
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "De&lete"
         Index           =   3
         Shortcut        =   {DEL}
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "-"
         Index           =   4
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "Select &All"
         Index           =   5
         Shortcut        =   ^A
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "Time/&Date"
         Index           =   6
         Shortcut        =   {F5}
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "-"
         Index           =   7
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "&Word Wrap"
         Checked         =   -1  'True
         Index           =   8
      End
      Begin VB.Menu mnuEditItem 
         Caption         =   "Set &Font..."
         Index           =   9
      End
   End
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
      WindowList      =   -1  'True
      Begin VB.Menu mnuWindowItem 
         Caption         =   "Tile &Horizontally"
         Index           =   0
      End
      Begin VB.Menu mnuWindowItem 
         Caption         =   "Tile &Vertically"
         Index           =   1
      End
      Begin VB.Menu mnuWindowItem 
         Caption         =   "&Cascade"
         Index           =   2
      End
      Begin VB.Menu mnuWindowItem 
         Caption         =   "Arrange Icons"
         Index           =   3
      End
   End
End
Attribute VB_Name = "frmMainMDI"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False
Option Explicit

Private Sub mnuFile_Click()
    ' enable/disable a few items in the File menu
    mnuFileSave.Enabled = Not (ActiveForm Is Nothing)
    mnuFileSaveAs.Enabled = Not (ActiveForm Is Nothing)
    mnuFileSaveAll.Enabled = Not (ActiveForm Is Nothing)
    mnuFilePrint.Enabled = Not (ActiveForm Is Nothing)
End Sub

Private Sub mnuFileNew_Click()
    Dim frmDoc As New frmDocument
    frmDoc.Filename = ""
    frmDoc.Show
End Sub

Private Sub mnuFileOpen_Click()
    Dim UseCurrentForm As Boolean
    On Error Resume Next
    ' UseCurrentForm is True only if the current form is
    ' and empty frmDocument form
    UseCurrentForm = (ActiveForm.txtEditor.Text = "")
    ReadFromFile "", Not UseCurrentForm
End Sub

Private Sub mnuFileClose_Click()
    ' close the active form, if there is one
    If Not (ActiveForm Is Nothing) Then Unload ActiveForm
End Sub

Private Sub mnuFileSave_Click()
    If Not (ActiveForm Is Nothing) Then
        SaveToFile ActiveForm.Filename
    End If
End Sub

Private Sub mnuFileSaveAs_Click()
    If Not (ActiveForm Is Nothing) Then
        SaveToFile ActiveForm.Filename, True
    End If
End Sub

Private Sub mnuFilePrint_Click()
    If Not (ActiveForm Is Nothing) Then
        Printer.Print ActiveForm.txtEditor.Text
        Printer.EndDoc
    End If
End Sub

Private Sub mnuFilePrintSetup_Click()
    With CommonDialog1
        .Flags = cdlPDPrintSetup
        .ShowPrinter
    End With
End Sub

Private Sub mnuFileExit_Click()
    ' unload the main form and all its children
    Unload Me
End Sub

Private Sub mnuEdit_Click()
    ' enable/disable items on the Edit menu
    On Error Resume Next
    mnuEditItem(0).Enabled = (ActiveForm.txtEditor.SelLength > 0)  ' cut
    mnuEditItem(1).Enabled = (ActiveForm.txtEditor.SelLength > 0)  ' copy
    mnuEditItem(2).Enabled = (Clipboard.GetText <> "")             ' paste
    mnuEditItem(3).Enabled = (ActiveForm.txtEditor.SelLength > 0)  ' delete
    mnuEditItem(5).Enabled = (ActiveForm.txtEditor.Text <> "")     ' select all
End Sub

Private Sub mnuEditItem_Click(Index As Integer)
    Dim txtEditor As WLText
    
    ' get a reference to the control on the active form
    Set txtEditor = ActiveForm.txtEditor
    
    Select Case Index
        Case 0    ' Cut
            Clipboard.Clear
            Clipboard.SetText txtEditor.SelText
            txtEditor.SelText = ""
        Case 1    ' Copy
            Clipboard.Clear
            Clipboard.SetText txtEditor.SelText
        Case 2    ' Paste
            txtEditor.SelText = Clipboard.GetText
        Case 3    ' Delete
            txtEditor.SelText = ""
        Case 5    ' Select All
            txtEditor.SelStart = 0
            txtEditor.SelLength = Len(txtEditor.Text)
        Case 6    ' Time/Date
            txtEditor.SelText = Format$(Now, "hh:mm AM/PM m/d/yy")
        Case 8    ' Word Wrap
            mnuEditItem(Index).Checked = Not mnuEditItem(Index).Checked
            txtEditor.ScrollBars = IIf(mnuEditItem(Index).Checked, vbVertical, vbBoth)
        Case 9    ' Set Font
            With CommonDialog1
                On Error Resume Next
                .Flags = cdlCFScreenFonts
                .FontName = txtEditor.Font.Name
                .FontSize = txtEditor.Font.Size
                .FontBold = txtEditor.Font.Bold
                .FontItalic = txtEditor.Font.Italic
                .Color = txtEditor.ForeColor
                .ShowFont
                If Err = 0 Then
                    txtEditor.Font.Name = .FontName
                    txtEditor.Font.Size = .FontSize
                    txtEditor.Font.Bold = .FontBold
                    txtEditor.Font.Italic = .FontItalic
                    txtEditor.ForeColor = .Color
                End If
            End With
    End Select
End Sub

Private Sub mnuWindowItem_Click(Index As Integer)
    Select Case Index
        Case 0        ' tile horizontally
            Arrange vbTileHorizontal
        Case 1        ' tile vertically
            Arrange vbTileVertical
        Case 2        ' cascade
            Arrange vbCascade
        Case 3        ' arrange icons
            Arrange vbArrangeIcons
    End Select
End Sub

' open a file into the current MDI child form
' (optionally create a new form )

Sub ReadFromFile(ByVal Filename As String, Optional createNew As Boolean)
    Dim frmDoc As frmDocument
    
    If Filename = "" Then
        With CommonDialog1
            .Filename = ""
            .Filter = "All Files|*.*|Text Files (*.txt)|*.txt"
            .FilterIndex = 2
            .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
            .ShowOpen
            If .Filename = "" Then Exit Sub
            Filename = .Filename
        End With
    End If
    
    ' create a new form if requested or necessary
    If createNew Then
        Set frmDoc = New frmDocument
        frmDoc.Show
    ElseIf TypeOf ActiveForm Is frmDocument Then
        Set frmDoc = ActiveForm
    Else
        Set frmDoc = New frmDocument
        frmDoc.Show
    End If
        
    On Error Resume Next
    Open Filename For Input As #1
    frmDoc.txtEditor.Text = Input$(LOF(1), 1)
    Close #1
    
    ' if no error, update Filename property (and caption)
    If Err = 0 Then
        frmDoc.Filename = Filename
        frmDoc.IsDirty = False
    End If
End Sub

' save the contents of the current form to file
' if argument is omitted, it is asked to the end user

Sub SaveToFile(ByVal Filename As String, Optional SaveAs As Boolean)
    Dim frmDoc As frmDocument
    
    On Error Resume Next
    
    ' exit if current form isn't a frmDocument
    Set frmDoc = ActiveForm
    If frmDoc Is Nothing Then Exit Sub

    If Filename = "" Or SaveAs Then
        With CommonDialog1
            .CancelError = True
            .Filename = frmDoc.Filename
            .Filter = "All Files|*.*|Text Files (*.txt)|*.txt"
            .FilterIndex = 2
            .Flags = cdlOFNPathMustExist + cdlOFNHideReadOnly + cdlOFNOverwritePrompt
            .ShowSave
            ' exit if any error, or cancel was pressed
            If Err Then Exit Sub
            ' use this routine is a recursive mode
            Filename = .Filename
        End With
    End If
    
    ' load the file
    Open Filename For Output As #1
    Print #1, ActiveForm.txtEditor.Text
    Close #1
    
    ' if no error, update Filename property (and caption)
    If Err = 0 Then
        frmDoc.Filename = Filename
        frmDoc.IsDirty = False
    End If
End Sub


