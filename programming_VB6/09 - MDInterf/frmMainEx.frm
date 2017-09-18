VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.MDIForm frmMain 
   BackColor       =   &H8000000C&
   Caption         =   "MDIDemo"
   ClientHeight    =   5190
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   8610
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   Begin ComctlLib.Toolbar tbToolBar 
      Align           =   1  'Align Top
      Height          =   420
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   8610
      _ExtentX        =   15187
      _ExtentY        =   741
      ButtonWidth     =   635
      ButtonHeight    =   582
      Appearance      =   1
      ImageList       =   "imlIcons"
      _Version        =   327682
      BeginProperty Buttons {0713E452-850A-101B-AFC0-4210102A8DA7} 
         NumButtons      =   9
         BeginProperty Button1 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "New"
            Object.ToolTipText     =   "New"
            Object.Tag             =   ""
            ImageIndex      =   1
         EndProperty
         BeginProperty Button2 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Open"
            Object.ToolTipText     =   "Open"
            Object.Tag             =   ""
            ImageIndex      =   2
         EndProperty
         BeginProperty Button3 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Save"
            Object.ToolTipText     =   "Save"
            Object.Tag             =   ""
            ImageIndex      =   3
         EndProperty
         BeginProperty Button4 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Object.Tag             =   ""
            Style           =   3
            MixedState      =   -1  'True
         EndProperty
         BeginProperty Button5 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Print"
            Object.ToolTipText     =   "Print"
            Object.Tag             =   ""
            ImageIndex      =   4
         EndProperty
         BeginProperty Button6 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Object.Tag             =   ""
            Style           =   3
            MixedState      =   -1  'True
         EndProperty
         BeginProperty Button7 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Cut"
            Object.ToolTipText     =   "Cut"
            Object.Tag             =   ""
            ImageIndex      =   5
         EndProperty
         BeginProperty Button8 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Copy"
            Object.ToolTipText     =   "Copy"
            Object.Tag             =   ""
            ImageIndex      =   6
         EndProperty
         BeginProperty Button9 {0713F354-850A-101B-AFC0-4210102A8DA7} 
            Key             =   "Paste"
            Object.ToolTipText     =   "Paste"
            Object.Tag             =   ""
            ImageIndex      =   7
         EndProperty
      EndProperty
   End
   Begin ComctlLib.StatusBar sbStatusBar 
      Align           =   2  'Align Bottom
      Height          =   270
      Left            =   0
      TabIndex        =   0
      Top             =   4920
      Width           =   8610
      _ExtentX        =   15187
      _ExtentY        =   476
      SimpleText      =   ""
      _Version        =   327682
      BeginProperty Panels {0713E89E-850A-101B-AFC0-4210102A8DA7} 
         NumPanels       =   3
         BeginProperty Panel1 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            AutoSize        =   1
            Object.Width           =   9551
            Text            =   "Status"
            TextSave        =   "Status"
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel2 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Style           =   6
            AutoSize        =   2
            TextSave        =   "9/15/98"
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel3 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Style           =   5
            AutoSize        =   2
            TextSave        =   "1:16 PM"
            Object.Tag             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComDlg.CommonDialog dlgCommonDialog 
      Left            =   6360
      Top             =   3000
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin ComctlLib.ImageList imlIcons 
      Left            =   4680
      Top             =   2880
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   327682
      BeginProperty Images {0713E8C2-850A-101B-AFC0-4210102A8DA7} 
         NumListImages   =   13
         BeginProperty ListImage1 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0000
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":01A2
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0344
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":04E6
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0688
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":082A
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":09CC
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0B6E
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0D10
            Key             =   ""
         EndProperty
         BeginProperty ListImage10 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":0EB2
            Key             =   ""
         EndProperty
         BeginProperty ListImage11 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":1054
            Key             =   ""
         EndProperty
         BeginProperty ListImage12 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":11F6
            Key             =   ""
         EndProperty
         BeginProperty ListImage13 {0713E8C3-850A-101B-AFC0-4210102A8DA7} 
            Picture         =   "frmMainEx.frx":1398
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileNew 
         Caption         =   "&New"
         Begin VB.Menu mnuFileNewItem 
            Caption         =   "&Text"
            Index           =   0
         End
         Begin VB.Menu mnuFileNewItem 
            Caption         =   "&Image"
            Index           =   1
         End
      End
      Begin VB.Menu mnuFileOpen 
         Caption         =   "&Open"
         Begin VB.Menu mnuFileOpenItem 
            Caption         =   "&Text"
            Index           =   0
         End
         Begin VB.Menu mnuFileOpenItem 
            Caption         =   "&Image"
            Index           =   1
         End
      End
      Begin VB.Menu mnuFileClose 
         Caption         =   "&Close"
      End
      Begin VB.Menu mnuFileBar1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileSave 
         Caption         =   "&Save"
         Shortcut        =   ^S
      End
      Begin VB.Menu mnuFileSaveAs 
         Caption         =   "Save &As..."
      End
      Begin VB.Menu mnuFileBar2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFilePrintSetup 
         Caption         =   "Print Set&up..."
      End
      Begin VB.Menu mnuFilePrint 
         Caption         =   "&Print"
         Shortcut        =   ^P
      End
      Begin VB.Menu mnuFileBar6 
         Caption         =   "-"
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
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
   End
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
      WindowList      =   -1  'True
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
         Caption         =   "&About MDIDemo..."
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

'##project:DefaultMemberSupport False
'##project:DisableMessages CodeAnalysis

Option Explicit

Private Sub mnuFile_Click()
    ' enable/disable individual menu items
    Dim ok As Boolean
    If ChildFormType > 0 Then ok = True
    
    mnuFileClose.Enabled = ok
    mnuFileSave.Enabled = ok
    mnuFileSaveAs.Enabled = ok
    mnuFilePrint.Enabled = ok
    If ok Then
        If ActiveForm.CanSave = False Then mnuFileSave.Enabled = False
        If ActiveForm.CanPrint = False Then mnuFilePrint.Enabled = False
    End If
    
End Sub

Private Sub mnuFileNewItem_Click(Index As Integer)
    Dim frm As Object
    Select Case Index
        Case 0
            Set frm = New frmDocument
        Case 1
            Set frm = New frmDocument2
    End Select
    frm.Show
End Sub

Private Sub mnuFileOpenItem_Click(Index As Integer)
    
    ' we must decide which version of the Open command should
    ' be made available, with or without the submenu
    Dim showSubMenu As Boolean
    If ChildFormType <= 0 Then
        ' there is no current form, delegate to New submenu
        mnuFileNewItem_Click Index
    ElseIf ChildFormType <> (Index + 1) Or Not ActiveForm.IsEmpty Then
        ' ditto if the current document is not empty
        ' or isn't of the right type
        mnuFileNewItem_Click Index
    End If

    ' ask the current form to load a new document
    ActiveForm.LoadFile ActiveForm.AskFilename(False)

End Sub

Private Sub mnuFileClose_Click()
    Unload ActiveForm
End Sub

Private Sub mnuFileSave_Click()
    On Error Resume Next
    If ActiveForm.Filename = "" Then
        Call mnuFileSaveAs_Click
    Else
        ActiveForm.SaveFile ActiveForm.Filename
    End If
End Sub

Private Sub mnuFileSaveAs_Click()
    ' ask the document to show a common dialog
    ' then save the file with the name selected by the user
    On Error Resume Next
    ActiveForm.SaveFile ActiveForm.AskFilename(True)
End Sub

Private Sub mnuFilePrintSetup_Click()
    dlgCommonDialog.ShowPrinter
End Sub

Private Sub mnuFilePrint_Click()
    On Error Resume Next
    ActiveForm.PrintDoc
End Sub

Private Sub mnuFileExit_Click()
    Unload Me
End Sub

Private Sub mnuEdit_Click()
    ' enable/disable individual menu items
    Dim ok As Boolean
    If ChildFormType > 0 Then ok = True
    
    ' ask the current document if it can copy, cut and paste
    mnuEditCopy.Enabled = ok
    mnuEditCut.Enabled = ok
    mnuEditPaste.Enabled = ok
    If ok Then
        If ActiveForm.CanCopy = False Then mnuEditCopy.Enabled = False
        If ActiveForm.CanCut = False Then mnuEditCut.Enabled = False
        If ActiveForm.CanPaste = False Then mnuEditPaste.Enabled = False
    End If
End Sub

Private Sub mnuEditCopy_Click()
    On Error Resume Next
    ActiveForm.Copy
End Sub

Private Sub mnuEditCut_Click()
    On Error Resume Next
    ActiveForm.Cut
End Sub

Private Sub mnuEditPaste_Click()
    On Error Resume Next
    ActiveForm.Paste
End Sub

Private Sub mnuWindowArrangeIcons_Click()
    Me.Arrange vbArrangeIcons
End Sub

Private Sub mnuWindowCascade_Click()
    Me.Arrange vbCascade
End Sub

Private Sub mnuWindowTileHorizontal_Click()
    Me.Arrange vbTileHorizontal
End Sub

Private Sub mnuWindowTileVertical_Click()
    Me.Arrange vbTileVertical
End Sub

Private Sub mnuHelpAbout_Click()
    frmAbout.Show vbModal, Me
End Sub

Private Sub tbToolBar_ButtonClick(ByVal Button As ComctlLib.Button)
    Select Case Button.Key
        Case "New"
            PopupMenu mnuFileNew
        Case "Open"
            PopupMenu mnuFileOpen
        Case "Save"
            mnuFileSave_Click
        Case "Print"
            mnuFilePrint_Click
        Case "Cut"
            mnuEditCut_Click
        Case "Copy"
            mnuEditCopy_Click
        Case "Paste"
            mnuEditPaste_Click
    End Select
End Sub

Function ChildFormType() As Integer
    ' return 0 if there is no current child form
    ' 1 if the current child is of type frmDocument
    ' 2 if the current child is of type frmDocument2
    ' -1 if the current child is of unknown type
    If ActiveForm Is Nothing Then
        ChildFormType = 0
    ElseIf TypeOf ActiveForm Is frmDocument Then
        ChildFormType = 1
    ElseIf TypeOf ActiveForm Is frmDocument2 Then
        ChildFormType = 2
    Else
        ChildFormType = -1
    End If
End Function



