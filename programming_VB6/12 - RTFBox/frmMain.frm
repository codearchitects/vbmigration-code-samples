VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{38911DA0-E448-11D0-84A3-00DD01104159}#1.1#0"; "COMCT332.OCX"
Begin VB.MDIForm frmMain 
   BackColor       =   &H8000000C&
   Caption         =   "RTFDemo"
   ClientHeight    =   4695
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   8610
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   Begin ComCtl3.CoolBar CoolBar1 
      Align           =   1  'Align Top
      Height          =   765
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   8610
      _ExtentX        =   15187
      _ExtentY        =   1349
      Picture         =   "frmMain.frx":0000
      EmbossPicture   =   -1  'True
      _CBWidth        =   8610
      _CBHeight       =   765
      _Version        =   "6.0.8169"
      MinHeight1      =   360
      Width1          =   5505
      NewRow1         =   0   'False
      AllowVertical1  =   0   'False
      Caption2        =   "Font"
      MinWidth2       =   2805
      MinHeight2      =   315
      Width2          =   1995
      NewRow2         =   -1  'True
      AllowVertical2  =   0   'False
      Caption3        =   "Size"
      MinWidth3       =   1995
      MinHeight3      =   315
      Width3          =   855
      NewRow3         =   0   'False
      Begin VB.ComboBox cboSize 
         Height          =   315
         Left            =   3960
         TabIndex        =   5
         Top             =   480
         Width           =   855
      End
      Begin VB.ComboBox cboFonts 
         Height          =   315
         Left            =   360
         Sorted          =   -1  'True
         TabIndex        =   4
         Top             =   480
         Width           =   2205
      End
      Begin MSComctlLib.Toolbar tbToolBar 
         Height          =   390
         Left            =   0
         TabIndex        =   3
         Top             =   0
         Visible         =   0   'False
         Width           =   8610
         _ExtentX        =   15187
         _ExtentY        =   688
         ButtonWidth     =   609
         ButtonHeight    =   582
         Appearance      =   1
         ImageList       =   "imlIcons"
         _Version        =   393216
         BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
            NumButtons      =   23
            BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "New"
               Object.ToolTipText     =   "New"
               ImageKey        =   "New"
            EndProperty
            BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Open"
               Object.ToolTipText     =   "Open"
               ImageKey        =   "Open"
            EndProperty
            BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Save"
               Object.ToolTipText     =   "Save"
               ImageKey        =   "Save"
            EndProperty
            BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Print"
               Object.ToolTipText     =   "Print"
               ImageKey        =   "Print"
            EndProperty
            BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Undo"
               Object.ToolTipText     =   "Undo"
               ImageKey        =   "Undo"
            EndProperty
            BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Copy"
               Object.ToolTipText     =   "Copy"
               ImageKey        =   "Copy"
            EndProperty
            BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Cut"
               Object.ToolTipText     =   "Cut"
               ImageKey        =   "Cut"
            EndProperty
            BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Paste"
               Object.ToolTipText     =   "Paste"
               ImageKey        =   "Paste"
            EndProperty
            BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Find"
               Object.ToolTipText     =   "Find"
               ImageKey        =   "Find"
            EndProperty
            BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Bold"
               Object.ToolTipText     =   "Bold"
               ImageKey        =   "Bold"
            EndProperty
            BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Italic"
               Object.ToolTipText     =   "Italic"
               ImageKey        =   "Italic"
            EndProperty
            BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Underline"
               Object.ToolTipText     =   "Underline"
               ImageKey        =   "Underline"
            EndProperty
            BeginProperty Button17 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Strike Through"
               Object.ToolTipText     =   "Strike Through"
               ImageKey        =   "Strike Through"
            EndProperty
            BeginProperty Button18 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button19 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Align Left"
               Object.ToolTipText     =   "Align Left"
               ImageKey        =   "Align Left"
               Style           =   2
            EndProperty
            BeginProperty Button20 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Align Right"
               Object.ToolTipText     =   "Align Right"
               ImageKey        =   "Align Right"
               Style           =   2
            EndProperty
            BeginProperty Button21 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Center"
               Object.ToolTipText     =   "Center"
               ImageKey        =   "Center"
               Style           =   2
            EndProperty
            BeginProperty Button22 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Style           =   3
            EndProperty
            BeginProperty Button23 {66833FEA-8583-11D1-B16A-00C0F0283628} 
               Key             =   "Help"
               Object.ToolTipText     =   "Help"
               ImageKey        =   "Help"
            EndProperty
         EndProperty
      End
      Begin RTFDemo.TransTBWrapper TransTBWrapper1 
         Height          =   255
         Left            =   240
         TabIndex        =   2
         Top             =   120
         Visible         =   0   'False
         Width           =   2895
         _ExtentX        =   5106
         _ExtentY        =   450
         Transparent     =   -1  'True
      End
   End
   Begin MSComctlLib.StatusBar sbStatusBar 
      Align           =   2  'Align Bottom
      Height          =   270
      Left            =   0
      TabIndex        =   0
      Top             =   4425
      Width           =   8610
      _ExtentX        =   15187
      _ExtentY        =   476
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   3
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   9551
            Text            =   "Status"
            TextSave        =   "Status"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   6
            AutoSize        =   2
            TextSave        =   "11/9/98"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            AutoSize        =   2
            TextSave        =   "5:55 PM"
         EndProperty
      EndProperty
   End
   Begin MSComDlg.CommonDialog dlgCommonDialog 
      Left            =   4440
      Top             =   2160
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.ImageList imlIcons 
      Left            =   1740
      Top             =   1350
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483644
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   18
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":13CCE
            Key             =   "New"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":13DE0
            Key             =   "Open"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":13EF2
            Key             =   "Save"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14004
            Key             =   "Print"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14116
            Key             =   "Copy"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14228
            Key             =   "Cut"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1433A
            Key             =   "Paste"
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1444C
            Key             =   "Bold"
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1455E
            Key             =   "Italic"
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14670
            Key             =   "Underline"
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14782
            Key             =   "Align Left"
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14894
            Key             =   "Align Right"
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":149A6
            Key             =   "Center"
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14AB8
            Key             =   "Find"
         EndProperty
         BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14BCA
            Key             =   "Undo"
         EndProperty
         BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14CDC
            Key             =   "Strike Through"
         EndProperty
         BeginProperty ListImage17 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14DEE
            Key             =   "Word Underline"
         EndProperty
         BeginProperty ListImage18 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":14F00
            Key             =   "Help"
         EndProperty
      EndProperty
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileNew 
         Caption         =   "&New"
         Shortcut        =   ^N
      End
      Begin VB.Menu mnuFileOpen 
         Caption         =   "&Open"
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuFileClose 
         Caption         =   "&Close"
      End
      Begin VB.Menu mnuFileBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileSave 
         Caption         =   "&Save"
      End
      Begin VB.Menu mnuFileSaveAs 
         Caption         =   "Save &As..."
      End
      Begin VB.Menu mnuFileBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFilePrint 
         Caption         =   "&Print..."
      End
      Begin VB.Menu mnuFileBar2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileMRU 
         Caption         =   ""
         Index           =   1
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileMRU 
         Caption         =   ""
         Index           =   2
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileMRU 
         Caption         =   ""
         Index           =   3
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileBar3 
         Caption         =   "-"
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
      Begin VB.Menu mnuEditUndo 
         Caption         =   "&Undo"
      End
      Begin VB.Menu mnuEditBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEditCut 
         Caption         =   "Cu&t"
         Shortcut        =   ^X
      End
      Begin VB.Menu mnuEditCopy 
         Caption         =   "&Copy"
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuEditPaste 
         Caption         =   "&Paste"
         Shortcut        =   ^V
      End
      Begin VB.Menu mnuEditBar2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEditSelectAll 
         Caption         =   "&Select All"
         Shortcut        =   ^A
      End
      Begin VB.Menu mnuEditBar3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEditFind 
         Caption         =   "&Find..."
         Shortcut        =   ^F
      End
      Begin VB.Menu mnuEditFindNext 
         Caption         =   "Find &Next"
         Shortcut        =   {F3}
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&View"
      Begin VB.Menu mnuViewToolbar 
         Caption         =   "&Toolbar"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuViewStatusBar 
         Caption         =   "&Status Bar"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuViewBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuViewProperties 
         Caption         =   "&Properties"
      End
   End
   Begin VB.Menu mnuFormat 
      Caption         =   "&Format"
      Begin VB.Menu mnuFormatFont 
         Caption         =   "&Font"
      End
      Begin VB.Menu mnuFormatParagraph 
         Caption         =   "&Paragraph"
      End
      Begin VB.Menu mnuFormatTabs 
         Caption         =   "&Tabs"
      End
   End
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
      WindowList      =   -1  'True
      Begin VB.Menu mnuWindowNewWindow 
         Caption         =   "&New Window"
      End
      Begin VB.Menu mnuWindowBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuWindowCascade 
         Caption         =   "&Cascade"
      End
      Begin VB.Menu mnuWindowTileHorizontal 
         Caption         =   "Tile &Horizontal"
      End
      Begin VB.Menu mnuWindowTileVertical 
         Caption         =   "Tile &Vertical"
      End
      Begin VB.Menu mnuWindowArrangeIcons 
         Caption         =   "&Arrange Icons"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "&About "
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function SendMessage Lib "USER32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long

' List of messages you can send to a RTF Box control
Const WM_USER = &H400
Const EM_CANUNDO = &HC6
Const EM_UNDO = &HC7
Const EM_CANPASTE = (WM_USER + 50)
Const EM_PASTESPECIAL = (WM_USER + 64)
Const WM_CUT = &H300
Const WM_COPY = &H301
Const WM_PASTE = &H302
Const EM_LINEINDEX = &HBB
Const EM_LINEFROMCHAR = &HC9
Const EM_GETLINECOUNT = &HBA
Const EM_REPLACESEL = &HC2
Const EM_GETTHUMB = &HBE
Const EM_SCROLLCARET = &HB7

' These are used for searches
Dim SearchString As String
Dim SearchOptions As Long
Dim SearchStart As Long

Private Sub MDIForm_Load()

    'Put the Toolbar Wrapper controls in the Coolbar band
    Set TransTBWrapper1.Container = CoolBar1
    Set CoolBar1.Bands(1).Child = TransTBWrapper1
    ' put the toolbar into the toolbar wrapper
    Set TransTBWrapper1.Toolbar = tbToolBar
    
    Set cboFonts.Container = CoolBar1
    Set cboSize.Container = CoolBar1
    
    Set CoolBar1.Bands(2).Child = cboFonts
    Set CoolBar1.Bands(3).Child = cboSize
    
    ' fill the combobox with all the font's name
    Dim i As Integer
    For i = 0 To Screen.FontCount - 1
        cboFonts.AddItem Screen.Fonts(i)
    Next
    
    Me.Left = GetSetting(App.Title, "Settings", "MainLeft", 1000)
    Me.Top = GetSetting(App.Title, "Settings", "MainTop", 1000)
    Me.Width = GetSetting(App.Title, "Settings", "MainWidth", 6500)
    Me.Height = GetSetting(App.Title, "Settings", "MainHeight", 6500)
    LoadNewDoc
End Sub

Private Sub cboFonts_Click()
    On Error Resume Next
    ActiveForm.rtfText.SelFontName = cboFonts.Text
End Sub

Private Sub cboFonts_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then cboFonts_Click
End Sub

Private Sub cboSize_Click()
    On Error Resume Next
    ActiveForm.rtfText.SelFontSize = cboSize.Text
End Sub

Private Sub cboSize_KeyPress(KeyAscii As Integer)
    If KeyAscii = 13 Then cboSize_Click
End Sub

Private Sub cboSize_DropDown()
    FillFontSizeCombo
End Sub

' fill the combo box of fonts' sizes

Private Sub FillFontSizeCombo()
    Dim saveName As String, saveSize As Single
    Dim sizes As Variant, i As Integer
    Dim var As Variant
    
    ' save the font properties of the combo itself
    saveName = cboSize.Font.Name
    saveSize = cboSize.Font.Size
    
    ' these are the sizes that we will try
    sizes = Array(6, 8, 7, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72)
    
    ' create a font with given name
    On Error Resume Next
    cboSize.Clear
    cboSize.FontName = cboFonts.Text
    
    ' if there is an error, just add some standard sizes
    If Err Then
        For Each var In Array(8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 30, 36, 42, 48, 60, 72)
            cboSize.AddItem var
        Next
    Else
        ' else, try all sizes in the array
        For i = LBound(sizes) To UBound(sizes)
            ' the only simple way to learn if a given font size is
            ' supported is making the assignment and then check
            ' if it was successful - testing Err doesn't work
            cboSize.FontSize = CInt(sizes(i))
            If cboSize.FontSize = CInt(sizes(i)) Then
                cboSize.AddItem sizes(i)
            End If
        Next
    End If
    
    cboSize.FontName = saveName
    cboSize.FontSize = saveSize
End Sub


Private Sub LoadNewDoc()
    Static lDocumentCount As Long
    Dim frmD As frmDocument
    lDocumentCount = lDocumentCount + 1
    Set frmD = New frmDocument
    frmD.Caption = "Document " & lDocumentCount
    frmD.Show
    frmD.IsDirty = False
End Sub


Private Sub MDIForm_Unload(Cancel As Integer)

    ' try to unload all forms
    Dim f As Form
    gloCancel = False
    For Each f In Forms
        Unload f
        ' don't proceed if a form refused to unload itself
        If gloCancel Then Exit Sub
    Next
    

    ' it is VERY important to set the wrapper's Toolbar property
    ' to Nothing before the form is unloaded
    CoolBar1.Visible = False
    Set TransTBWrapper1.Toolbar = Nothing

    If Me.WindowState <> vbMinimized Then
        SaveSetting App.Title, "Settings", "MainLeft", Me.Left
        SaveSetting App.Title, "Settings", "MainTop", Me.Top
        SaveSetting App.Title, "Settings", "MainWidth", Me.Width
        SaveSetting App.Title, "Settings", "MainHeight", Me.Height
    End If
End Sub

Private Sub mnuEditFindNext_Click()
    If SearchString = "" Then Exit Sub
    
    On Error Resume Next
    SearchStart = ActiveForm.rtfText.Find(SearchString, SearchStart, , SearchOptions)
    If Err Then Exit Sub
    If SearchStart = -1 Then
        MsgBox "String not found", vbExclamation
    End If
    SearchStart = SearchStart + Len(SearchString)
End Sub

Private Sub mnuEditSelectAll_Click()
    On Error Resume Next
    With ActiveForm.rtfText
        .SelStart = 0
        .SelLength = Len(.Text)
    End With
End Sub

Private Sub mnuEditFind_Click()
    
    frmFind.txtFind = SearchString
    frmFind.chkWholeWords = IIf(SearchOptions And rtfWholeWord, vbChecked, vbUnchecked)
    frmFind.chkMatchCase = IIf(SearchOptions And rtfMatchCase, vbChecked, vbUnchecked)
    frmFind.Show vbModal
    
    On Error Resume Next
    
    If Not frmFind.CancelPressed Then
        If Err Then Exit Sub
        SearchString = frmFind.txtFind
        SearchOptions = IIf(frmFind.chkWholeWords, rtfWholeWord, 0) + _
            IIf(frmFind.chkMatchCase, rtfMatchCase, 0)
        
        SearchStart = ActiveForm.rtfText.Find(SearchString, , , SearchOptions)
        If SearchStart = -1 Then
            MsgBox "String not found", vbExclamation
        End If
        SearchStart = SearchStart + Len(SearchString)
    End If
    
    Unload frmFind

End Sub

Private Sub mnuFormatFont_Click()
    Dim RTF As RichTextBox
    
    On Error Resume Next
    Set RTF = ActiveForm.rtfText
    If Err Then Exit Sub
    
    With dlgCommonDialog
        .CancelError = True
        .Flags = cdlCFBoth Or cdlCFEffects
        If IsNull(RTF.SelFontName) Then
            .Flags = .Flags Or cdlCFNoFaceSel
        Else
            .FontName = RTF.SelFontName
        End If
        If IsNull(RTF.SelFontSize) Then
            .Flags = .Flags Or cdlCFNoSizeSel
        Else
            .FontSize = RTF.SelFontSize
        End If
        If IsNull(RTF.SelBold) Or IsNull(RTF.SelItalic) Then
            .Flags = .Flags Or cdlCFNoStyleSel
        Else
            .FontBold = RTF.SelBold
            .FontItalic = RTF.SelItalic
        End If
        ' These assignments are protected by the On Error
        .FontUnderline = RTF.SelUnderline
        .FontStrikethru = RTF.SelStrikeThru
        .Color = RTF.SelColor
        Err.Clear
        
        .ShowFont
        If Err Then Exit Sub
        
        If .FontName <> "" Then
            RTF.SelFontName = .FontName
        End If
        RTF.SelBold = .FontBold
        RTF.SelItalic = .FontItalic
        If (.Flags And cdlCFNoSizeSel) = 0 Then
            RTF.SelFontSize = .FontSize
        End If
        RTF.SelUnderline = .FontUnderline
        RTF.SelStrikeThru = .FontStrikethru
        RTF.SelColor = .Color
        ' update the toolbar
        ActiveForm.RTF_SelChange
    End With
End Sub

Private Sub mnuFormatParagraph_Click()
    Dim rtb As RichTextBox
    
    On Error Resume Next
    Set rtb = ActiveForm.rtfText
    If Err Then Exit Sub
    
    With frmParagraph
        If IsNull(rtb.SelIndent) Then
            .txtLeft = ""
        Else
            .txtLeft = rtb.SelIndent
        End If
        If IsNull(rtb.SelRightIndent) Then
            .txtRight = ""
        Else
            .txtRight = rtb.SelRightIndent
        End If
        If IsNull(rtb.SelHangingIndent) Then
            .txtFirstLine = ""
        Else
            .txtFirstLine = rtb.SelHangingIndent
        End If
        If IsNull(rtb.SelAlignment) Then
            .opAlign(0) = 0
            .opAlign(1) = 0
            .opAlign(2) = 0
        ElseIf rtb.SelAlignment = rtfLeft Then
            .opAlign(0) = True
        ElseIf rtb.SelAlignment = rtfCenter Then
            .opAlign(1) = True
        ElseIf rtb.SelAlignment = rtfRight Then
            .opAlign(2) = True
        End If
        .Show vbModal
        If Not .CancelPressed Then
            If .txtLeft <> "" Then
                rtb.SelIndent = Int(.txtLeft)
            End If
            If .txtRight <> "" Then
                rtb.SelRightIndent = Int(.txtRight)
            End If
            If .txtFirstLine <> "" Then
                rtb.SelHangingIndent = Int(.txtFirstLine)
            End If
            If .opAlign(0) Then
                rtb.SelAlignment = rtfLeft
            ElseIf .opAlign(1) Then
                rtb.SelAlignment = rtfCenter
            ElseIf .opAlign(2) Then
                rtb.SelAlignment = rtfRight
            End If
        End If
    End With
End Sub

Private Sub mnuFormatTabs_Click()
    Dim rtb As RichTextBox, i As Integer
    
    On Error Resume Next
    Set rtb = ActiveForm.rtfText
    If Err Then Exit Sub
    
    With frmTabs
        .lstTabs.Clear
        If Not IsNull(rtb.SelTabCount) Then
            For i = 0 To rtb.SelTabCount - 1
                .lstTabs.AddItem Int(rtb.SelTabs(i))
            Next
        End If
        .Show vbModal
        If Not .CancelPressed Then
            ' First, clear all existing tab stops
            rtb.SelTabCount = 0
            ' Then enforce selected tab stops.
            rtb.SelTabCount = .lstTabs.ListCount
            For i = 0 To .lstTabs.ListCount - 1
                rtb.SelTabs(i) = Int(.lstTabs.List(i))
            Next
        End If
    End With
End Sub

Private Sub mnuViewProperties_Click()
    Dim rtb As RichTextBox, par As Long
    
    On Error Resume Next
    Set rtb = ActiveForm.rtfText
    If Err Then Exit Sub
    
    With frmProperties
        ' A fast way to count paragraphs.
        par = Len(rtb.Text) - Len(Replace(rtb.Text, vbCrLf, vbCr))
        .lblParagraphs = par
        .lblLines = SendMessage(rtb.hWnd, EM_GETLINECOUNT, 0, ByVal 0&)
        ' A fast way to count words.
        .lblWords = UBound(Split(rtb.Text, " ")) + 1 + par
        .lblChars = Len(rtb.Text)
        .Show vbModal
    End With
    Set frmProperties = Nothing
End Sub

Private Sub mnuViewStatusbar_Click()
    mnuViewStatusBar.Checked = Not mnuViewStatusBar.Checked
    sbStatusBar.Visible = mnuViewStatusBar.Checked
End Sub

Private Sub mnuViewToolbar_Click()
    mnuViewToolbar.Checked = Not mnuViewToolbar.Checked
    CoolBar1.Bands(1).Visible = mnuViewToolbar.Checked
End Sub

Private Sub tbToolBar_ButtonClick(ByVal Button As MSComctlLib.Button)
    On Error Resume Next
    Select Case Button.Key
        Case "New"
            LoadNewDoc
        Case "Open"
            mnuFileOpen_Click
        Case "Save"
            mnuFileSave_Click
        Case "Print"
            mnuFilePrint_Click
        Case "Find"
            mnuEditFind_Click
        Case "Undo"
            mnuEditUndo_Click
        Case "Copy"
            mnuEditCopy_Click
        Case "Cut"
            mnuEditCut_Click
        Case "Paste"
            mnuEditPaste_Click
        Case "Bold"
            ActiveForm.rtfText.SelBold = Not ActiveForm.rtfText.SelBold
            Button.Value = IIf(ActiveForm.rtfText.SelBold, tbrPressed, tbrUnpressed)
        Case "Italic"
            ActiveForm.rtfText.SelItalic = Not ActiveForm.rtfText.SelItalic
            Button.Value = IIf(ActiveForm.rtfText.SelItalic, tbrPressed, tbrUnpressed)
        Case "Underline"
            ActiveForm.rtfText.SelUnderline = Not ActiveForm.rtfText.SelUnderline
            Button.Value = IIf(ActiveForm.rtfText.SelUnderline, tbrPressed, tbrUnpressed)
        Case "Strike Through"
            ActiveForm.rtfText.SelStrikeThru = Not ActiveForm.rtfText.SelStrikeThru
            Button.Value = IIf(ActiveForm.rtfText.SelStrikeThru, tbrPressed, tbrUnpressed)
        Case "Align Left"
            ActiveForm.rtfText.SelAlignment = rtfLeft
        Case "Align Right"
            ActiveForm.rtfText.SelAlignment = rtfRight
        Case "Center"
            ActiveForm.rtfText.SelAlignment = rtfCenter
        Case "Help"
            mnuHelpAbout_Click
    End Select
End Sub

Private Sub mnuHelpAbout_Click()
    frmAbout.Show vbModal, Me
End Sub

Private Sub mnuWindowArrangeIcons_Click()
    Me.Arrange vbArrangeIcons
End Sub

Private Sub mnuWindowTileVertical_Click()
    Me.Arrange vbTileVertical
End Sub

Private Sub mnuWindowTileHorizontal_Click()
    Me.Arrange vbTileHorizontal
End Sub

Private Sub mnuWindowCascade_Click()
    Me.Arrange vbCascade
End Sub

Private Sub mnuWindowNewWindow_Click()
    LoadNewDoc
End Sub

Private Sub mnuEditPaste_Click()
    On Error Resume Next
    ActiveForm.rtfText.SelRTF = Clipboard.GetText
End Sub

Private Sub mnuEditCopy_Click()
    On Error Resume Next
    Clipboard.Clear
    Clipboard.SetText ActiveForm.rtfText.SelRTF
End Sub

Private Sub mnuEditCut_Click()
    On Error Resume Next
    Clipboard.SetText ActiveForm.rtfText.SelRTF
    ActiveForm.rtfText.SelText = vbNullString
End Sub

Private Sub mnuEditUndo_Click()
    SendMessage ActiveForm.rtfText.hWnd, EM_UNDO, 0, ByVal 0&
End Sub

Private Sub mnuFileExit_Click()
    'unload the form
    Unload Me
End Sub

Private Sub mnuFilePrint_Click()
    ' Set this Const to True to print using margins.
    Const PRINT_WITH_MARGINS = False
    
    On Error Resume Next
    If ActiveForm Is Nothing Then Exit Sub
    
    

    With dlgCommonDialog
        .CancelError = True
        .Flags = cdlPDReturnDC + cdlPDNoPageNums
        If ActiveForm.rtfText.SelLength = 0 Then
            .Flags = .Flags + cdlPDAllPages
        Else
            .Flags = .Flags + cdlPDSelection
        End If
        .ShowPrinter
        If Err = 0 Then
            If Not PRINT_WITH_MARGINS Then
                ActiveForm.rtfText.SelPrint .hdc
            Else
                PrintRTF ActiveForm.rtfText, 200, 400, 200, 300
            End If
        End If
    End With

End Sub

Private Sub mnuFileSaveAs_Click()
    Dim sFile As String

    If ActiveForm Is Nothing Then Exit Sub

    With dlgCommonDialog
        .DialogTitle = "Save As"
        .CancelError = False
        ' the app wizard doesn't properly set flags, nor file filters
        .Flags = cdlOFNPathMustExist + cdlOFNOverwritePrompt
        .Filter = "All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt"
        .FilterIndex = 2
        .ShowSave
        If Len(.FileName) = 0 Then Exit Sub
        sFile = .FileName
    End With
    ActiveForm.Caption = sFile
    If UCase$(Right$(sFile, 3)) = "RTF" Then
        ActiveForm.rtfText.SaveFile sFile, rtfRTF
    Else
        ActiveForm.rtfText.SaveFile sFile, rtfText
    End If
    ActiveForm.IsDirty = False
End Sub

Private Sub mnuFileSave_Click()
    Dim sFile As String
    If Left$(ActiveForm.Caption, 8) = "Document" Then
        ' delegate the task to the SaveAs command, if no title yet
        mnuFileSaveAs_Click
    Else
        sFile = ActiveForm.Caption
        If UCase$(Right$(sFile, 3)) = "RTF" Then
            ActiveForm.rtfText.SaveFile sFile, rtfRTF
        Else
            ActiveForm.rtfText.SaveFile sFile, rtfText
        End If
        ActiveForm.IsDirty = False
    End If
End Sub

Private Sub mnuFileClose_Click()
    On Error Resume Next
    Unload ActiveForm
End Sub

Private Sub mnuFileOpen_Click()
    Dim sFile As String
    If ActiveForm Is Nothing Then LoadNewDoc

    With dlgCommonDialog
        .DialogTitle = "Open"
        .CancelError = False
        ' the app wizard doesn't properly set flags, nor file filters
        .Flags = cdlOFNFileMustExist + cdlOFNHideReadOnly
        .Filter = "All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt"
        .FilterIndex = 2
        .ShowOpen
        If Len(.FileName) = 0 Then
            Exit Sub
        End If
        sFile = .FileName
    End With
    If UCase$(Right$(sFile, 3)) = "RTF" Then
        ActiveForm.rtfText.LoadFile sFile, rtfRTF
    Else
        ActiveForm.rtfText.LoadFile sFile, rtfText
    End If
    ActiveForm.Caption = sFile
    ActiveForm.IsDirty = False
End Sub

Private Sub mnuFileNew_Click()
    LoadNewDoc
End Sub

