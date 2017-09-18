<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
	Inherits CodeArchitects.VB6Library.VB6MdiForm

#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
	EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Windows Form Designer generated code "

	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Create all controls and control arrays.
		InitializeComponents()
	End Sub

	' This method wraps the call to InitializeComponent, but can be called from base class.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
		Me.ObjectIsInitializing = True
		InitializeComponent()
		' Initialize control arrays.
		Me.mnuFileMRU = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuFileMRU_001, mnuFileMRU_002, mnuFileMRU_003)
		Me.ObjectIsInitializing = False
	End Sub

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing Then
				If components IsNot Nothing Then components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public mnuFileMRU As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents CoolBar1_Placeholder As CodeArchitects.VB6Library.VB6Placeholder
	Public WithEvents cboSize As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboFonts As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents tbToolBar As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents TransTBWrapper1 As RTFDemo.TransTBWrapper
	Public WithEvents tbToolBar_Control As System.Windows.Forms.ToolStrip
	Public WithEvents sbStatusBar As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents dlgCommonDialog As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents imlIcons As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAs As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFilePrint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileMRU_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileMRU_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileMRU_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditUndo As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditCut As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditCopy As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditPaste As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditBar2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditSelectAll As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditBar3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditFind As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditFindNext As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuView As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewToolbar As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewStatusBar As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuViewProperties As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFormat As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFormatFont As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFormatParagraph As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFormatTabs As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowNewWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuWindowCascade As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileHorizontal As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileVertical As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowArrangeIcons As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelpAbout As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents tbToolBar_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button11 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button13 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button14 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button15 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button16 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button17 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button18 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button19 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button20 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button21 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button22 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button23 As System.Windows.Forms.ToolStripButton
	Public WithEvents sbStatusBar_Control As System.Windows.Forms.StatusStrip
	Public WithEvents sbStatusBar_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents sbStatusBar_Panel3 As System.Windows.Forms.ToolStripStatusLabel

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.CoolBar1_Placeholder = New CodeArchitects.VB6Library.VB6Placeholder()
		Me.cboSize = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboFonts = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.tbToolBar = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.TransTBWrapper1 = New RTFDemo.TransTBWrapper()
		Me.tbToolBar_Control = New System.Windows.Forms.ToolStrip()
		Me.sbStatusBar = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.dlgCommonDialog = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.imlIcons = New CodeArchitects.VB6Library.VB6ImageList()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileSave = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAs = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFilePrint = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileMRU_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileMRU_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileMRU_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditUndo = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditCut = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditCopy = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditPaste = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditBar2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditSelectAll = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditBar3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditFind = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditFindNext = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuView = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewToolbar = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewStatusBar = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewBar1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuViewProperties = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFormat = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFormatFont = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFormatParagraph = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFormatTabs = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowNewWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuWindowCascade = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileHorizontal = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileVertical = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowArrangeIcons = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelpAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.tbToolBar_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button4 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button6 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button7 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button8 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button9 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button10 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button11 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button12 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button13 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button14 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button15 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button16 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button17 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button18 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button19 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button20 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button21 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button22 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button23 = New System.Windows.Forms.ToolStripButton()
		Me.sbStatusBar_Control = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.CoolBar1_Placeholder.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TransTBWrapper1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imlIcons, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' CoolBar1_Placeholder
		'
		Me.CoolBar1_Placeholder.Name = "CoolBar1_Placeholder"
		Me.CoolBar1_Placeholder.Size = New System.Drawing.Size(574, 51)
		Me.CoolBar1_Placeholder.Location = New System.Drawing.Point(0, 24)
		'
		' cboSize
		'
		Me.cboSize.Name = "cboSize"
		Me.cboSize.Size = New System.Drawing.Size(57, 21)
		Me.cboSize.Location = New System.Drawing.Point(264, 32)
		Me.cboSize.TabIndex = 5
		'
		' cboFonts
		'
		Me.cboFonts.Name = "cboFonts"
		Me.cboFonts.Size = New System.Drawing.Size(147, 21)
		Me.cboFonts.Location = New System.Drawing.Point(24, 32)
		Me.cboFonts.Sorted = True
		Me.cboFonts.TabIndex = 4
		'
		' tbToolBar
		'
		Me.tbToolBar.Name = "tbToolBar"
		Me.tbToolBar.Location = New System.Drawing.Point(0, 0)
		Me.tbToolBar.ButtonWidth = 609
		Me.tbToolBar.ButtonHeight = 582
		Me.tbToolBar.ImageList = imlIcons
		Me.tbToolBar.Size = New Size(2, 2)
		Me.tbToolBar.ToolStrip = Me.tbToolBar_Control
		Me.tbToolBar_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbToolBar_Button1, Me.tbToolBar_Button2, Me.tbToolBar_Button3, Me.tbToolBar_Button4, Me.tbToolBar_Button5, Me.tbToolBar_Button6, Me.tbToolBar_Button7, Me.tbToolBar_Button8, Me.tbToolBar_Button9, Me.tbToolBar_Button10, Me.tbToolBar_Button11, Me.tbToolBar_Button12, Me.tbToolBar_Button13, Me.tbToolBar_Button14, Me.tbToolBar_Button15, Me.tbToolBar_Button16, Me.tbToolBar_Button17, Me.tbToolBar_Button18, Me.tbToolBar_Button19, Me.tbToolBar_Button20, Me.tbToolBar_Button21, Me.tbToolBar_Button22, Me.tbToolBar_Button23})
		'
		' TransTBWrapper1
		'
		Me.TransTBWrapper1.Name = "TransTBWrapper1"
		Me.TransTBWrapper1.Size = New System.Drawing.Size(193, 17)
		Me.TransTBWrapper1.Location = New System.Drawing.Point(16, 8)
		Me.TransTBWrapper1.TabIndex = 2
		Me.TransTBWrapper1.Visible = False
		Me.TransTBWrapper1.Transparent = -1
		'
		' tbToolBar_Control
		'
		Me.tbToolBar_Control.Name = "tbToolBar_Control"
		Me.tbToolBar_Control.Size = New System.Drawing.Size(574, 26)
		Me.tbToolBar_Control.Location = New System.Drawing.Point(0, 0)
		Me.tbToolBar_Control.TabIndex = 3
		Me.tbToolBar_Control.Visible = False
		Me.tbToolBar_Control.ImageList = imlIcons.ImageList
		Me.tbToolBar_Control.Dock = System.Windows.Forms.DockStyle.None
		'
		' sbStatusBar
		'
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 319)
		Me.sbStatusBar.Size = New Size(2, 2)
		Me.sbStatusBar.StatusStrip = Me.sbStatusBar_Control
		Me.sbStatusBar_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panel1, Me.sbStatusBar_Panel2, Me.sbStatusBar_Panel3})
		'
		' dlgCommonDialog
		'
		Me.dlgCommonDialog.Name = "dlgCommonDialog"
		Me.dlgCommonDialog.ParentForm = Me
		'
		' imlIcons
		'
		Me.imlIcons.Name = "imlIcons"
		Me.imlIcons.ParentForm = Me
		Me.imlIcons.BackColor = FromOleColor6(CInt(-2147483644))
		Me.imlIcons.MaskColor = FromOleColor6(CInt(12632256))
		Me.imlIcons.Tag = "Key1=New;Key2=Open;Key3=Save;Key4=Print;Key5=Copy;Key6=Cut;Key7=Paste;Key8=Bold;Key9=Italic;Key10=Underline;Key11=Align Left;Key12=Align Right;Key13=Center;Key14=Find;Key15=Undo;Key16=Strike Through;Key17=Word Underline;Key18=Help;"
		Me.imlIcons.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlIcons.ImageStream = CType(resources.GetObject("imlIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.MdiWindowListItem = Me.mnuWindow
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
		'
		' mnuFileNew
		'
		Me.mnuFileNew.Name = "mnuFileNew"
		Me.mnuFileNew.Caption = "&New"
		Me.mnuFileNew.Shortcut = Keys.Control Or Keys.N
		'
		' mnuFileOpen
		'
		Me.mnuFileOpen.Name = "mnuFileOpen"
		Me.mnuFileOpen.Caption = "&Open"
		Me.mnuFileOpen.Shortcut = Keys.Control Or Keys.O
		'
		' mnuFileClose
		'
		Me.mnuFileClose.Name = "mnuFileClose"
		Me.mnuFileClose.Caption = "&Close"
		'
		' mnuFileBar0
		'
		Me.mnuFileBar0.Name = "mnuFileBar0"
		'
		' mnuFileSave
		'
		Me.mnuFileSave.Name = "mnuFileSave"
		Me.mnuFileSave.Caption = "&Save"
		'
		' mnuFileSaveAs
		'
		Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
		Me.mnuFileSaveAs.Caption = "Save &As..."
		'
		' mnuFileBar1
		'
		Me.mnuFileBar1.Name = "mnuFileBar1"
		'
		' mnuFilePrint
		'
		Me.mnuFilePrint.Name = "mnuFilePrint"
		Me.mnuFilePrint.Caption = "&Print..."
		'
		' mnuFileBar2
		'
		Me.mnuFileBar2.Name = "mnuFileBar2"
		'
		' mnuFileMRU_001
		'
		Me.mnuFileMRU_001.Name = "mnuFileMRU_001"
		Me.mnuFileMRU_001.Caption = ""
		Me.mnuFileMRU_001.Visible = False
		'
		' mnuFileMRU_002
		'
		Me.mnuFileMRU_002.Name = "mnuFileMRU_002"
		Me.mnuFileMRU_002.Caption = ""
		Me.mnuFileMRU_002.Visible = False
		'
		' mnuFileMRU_003
		'
		Me.mnuFileMRU_003.Name = "mnuFileMRU_003"
		Me.mnuFileMRU_003.Caption = ""
		Me.mnuFileMRU_003.Visible = False
		'
		' mnuFileBar3
		'
		Me.mnuFileBar3.Name = "mnuFileBar3"
		'
		' mnuFileExit
		'
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.Caption = "E&xit"
		'
		' mnuEdit
		'
		Me.mnuEdit.Name = "mnuEdit"
		Me.mnuEdit.Caption = "&Edit"
		'
		' mnuEditUndo
		'
		Me.mnuEditUndo.Name = "mnuEditUndo"
		Me.mnuEditUndo.Caption = "&Undo"
		'
		' mnuEditBar0
		'
		Me.mnuEditBar0.Name = "mnuEditBar0"
		'
		' mnuEditCut
		'
		Me.mnuEditCut.Name = "mnuEditCut"
		Me.mnuEditCut.Caption = "Cu&t"
		Me.mnuEditCut.Shortcut = Keys.Control Or Keys.X
		'
		' mnuEditCopy
		'
		Me.mnuEditCopy.Name = "mnuEditCopy"
		Me.mnuEditCopy.Caption = "&Copy"
		Me.mnuEditCopy.Shortcut = Keys.Control Or Keys.C
		'
		' mnuEditPaste
		'
		Me.mnuEditPaste.Name = "mnuEditPaste"
		Me.mnuEditPaste.Caption = "&Paste"
		Me.mnuEditPaste.Shortcut = Keys.Control Or Keys.V
		'
		' mnuEditBar2
		'
		Me.mnuEditBar2.Name = "mnuEditBar2"
		'
		' mnuEditSelectAll
		'
		Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
		Me.mnuEditSelectAll.Caption = "&Select All"
		Me.mnuEditSelectAll.Shortcut = Keys.Control Or Keys.A
		'
		' mnuEditBar3
		'
		Me.mnuEditBar3.Name = "mnuEditBar3"
		'
		' mnuEditFind
		'
		Me.mnuEditFind.Name = "mnuEditFind"
		Me.mnuEditFind.Caption = "&Find..."
		Me.mnuEditFind.Shortcut = Keys.Control Or Keys.F
		'
		' mnuEditFindNext
		'
		Me.mnuEditFindNext.Name = "mnuEditFindNext"
		Me.mnuEditFindNext.Caption = "Find &Next"
		Me.mnuEditFindNext.Shortcut = Keys.F3
		'
		' mnuView
		'
		Me.mnuView.Name = "mnuView"
		Me.mnuView.Caption = "&View"
		'
		' mnuViewToolbar
		'
		Me.mnuViewToolbar.Name = "mnuViewToolbar"
		Me.mnuViewToolbar.Caption = "&Toolbar"
		Me.mnuViewToolbar.Checked = True
		'
		' mnuViewStatusBar
		'
		Me.mnuViewStatusBar.Name = "mnuViewStatusBar"
		Me.mnuViewStatusBar.Caption = "&Status Bar"
		Me.mnuViewStatusBar.Checked = True
		'
		' mnuViewBar1
		'
		Me.mnuViewBar1.Name = "mnuViewBar1"
		'
		' mnuViewProperties
		'
		Me.mnuViewProperties.Name = "mnuViewProperties"
		Me.mnuViewProperties.Caption = "&Properties"
		'
		' mnuFormat
		'
		Me.mnuFormat.Name = "mnuFormat"
		Me.mnuFormat.Caption = "&Format"
		'
		' mnuFormatFont
		'
		Me.mnuFormatFont.Name = "mnuFormatFont"
		Me.mnuFormatFont.Caption = "&Font"
		'
		' mnuFormatParagraph
		'
		Me.mnuFormatParagraph.Name = "mnuFormatParagraph"
		Me.mnuFormatParagraph.Caption = "&Paragraph"
		'
		' mnuFormatTabs
		'
		Me.mnuFormatTabs.Name = "mnuFormatTabs"
		Me.mnuFormatTabs.Caption = "&Tabs"
		'
		' mnuWindow
		'
		Me.mnuWindow.Name = "mnuWindow"
		Me.mnuWindow.Caption = "&Window"
		'
		' mnuWindowNewWindow
		'
		Me.mnuWindowNewWindow.Name = "mnuWindowNewWindow"
		Me.mnuWindowNewWindow.Caption = "&New Window"
		'
		' mnuWindowBar0
		'
		Me.mnuWindowBar0.Name = "mnuWindowBar0"
		'
		' mnuWindowCascade
		'
		Me.mnuWindowCascade.Name = "mnuWindowCascade"
		Me.mnuWindowCascade.Caption = "&Cascade"
		'
		' mnuWindowTileHorizontal
		'
		Me.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal"
		Me.mnuWindowTileHorizontal.Caption = "Tile &Horizontal"
		'
		' mnuWindowTileVertical
		'
		Me.mnuWindowTileVertical.Name = "mnuWindowTileVertical"
		Me.mnuWindowTileVertical.Caption = "Tile &Vertical"
		'
		' mnuWindowArrangeIcons
		'
		Me.mnuWindowArrangeIcons.Name = "mnuWindowArrangeIcons"
		Me.mnuWindowArrangeIcons.Caption = "&Arrange Icons"
		'
		' mnuHelp
		'
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Caption = "&Help"
		'
		' mnuHelpAbout
		'
		Me.mnuHelpAbout.Name = "mnuHelpAbout"
		Me.mnuHelpAbout.Caption = "&About "
		'
		' tbToolBar_Button1
		'
		Me.tbToolBar_Button1.Name = "tbToolBar_Button1"
		Me.tbToolBar_Button1.Tag = "Key=New;ImageKey=New;"
		Me.tbToolBar_Button1.ImageIndex = 0
		Me.tbToolBar_Button1.Width = 23
		Me.tbToolBar_Button1.Height = 22
		Me.tbToolBar_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button1.AutoSize = False
		Me.tbToolBar_Button1.ToolTipText = "New"
		'
		' tbToolBar_Button2
		'
		Me.tbToolBar_Button2.Name = "tbToolBar_Button2"
		Me.tbToolBar_Button2.Tag = "Key=Open;ImageKey=Open;"
		Me.tbToolBar_Button2.ImageIndex = 1
		Me.tbToolBar_Button2.Width = 23
		Me.tbToolBar_Button2.Height = 22
		Me.tbToolBar_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button2.AutoSize = False
		Me.tbToolBar_Button2.ToolTipText = "Open"
		'
		' tbToolBar_Button3
		'
		Me.tbToolBar_Button3.Name = "tbToolBar_Button3"
		Me.tbToolBar_Button3.Tag = "Key=Save;ImageKey=Save;"
		Me.tbToolBar_Button3.ImageIndex = 2
		Me.tbToolBar_Button3.Width = 23
		Me.tbToolBar_Button3.Height = 22
		Me.tbToolBar_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button3.AutoSize = False
		Me.tbToolBar_Button3.ToolTipText = "Save"
		'
		' tbToolBar_Button4
		'
		Me.tbToolBar_Button4.Name = "tbToolBar_Button4"
		Me.tbToolBar_Button4.Tag = "Style=3;"
		Me.tbToolBar_Button4.Width = 7
		Me.tbToolBar_Button4.Height = 22
		Me.tbToolBar_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button4.AutoSize = False
		'
		' tbToolBar_Button5
		'
		Me.tbToolBar_Button5.Name = "tbToolBar_Button5"
		Me.tbToolBar_Button5.Tag = "Key=Print;ImageKey=Print;"
		Me.tbToolBar_Button5.ImageIndex = 3
		Me.tbToolBar_Button5.Width = 23
		Me.tbToolBar_Button5.Height = 22
		Me.tbToolBar_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button5.AutoSize = False
		Me.tbToolBar_Button5.ToolTipText = "Print"
		'
		' tbToolBar_Button6
		'
		Me.tbToolBar_Button6.Name = "tbToolBar_Button6"
		Me.tbToolBar_Button6.Tag = "Style=3;"
		Me.tbToolBar_Button6.Width = 7
		Me.tbToolBar_Button6.Height = 22
		Me.tbToolBar_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button6.AutoSize = False
		'
		' tbToolBar_Button7
		'
		Me.tbToolBar_Button7.Name = "tbToolBar_Button7"
		Me.tbToolBar_Button7.Tag = "Key=Undo;ImageKey=Undo;"
		Me.tbToolBar_Button7.ImageIndex = 14
		Me.tbToolBar_Button7.Width = 23
		Me.tbToolBar_Button7.Height = 22
		Me.tbToolBar_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button7.AutoSize = False
		Me.tbToolBar_Button7.ToolTipText = "Undo"
		'
		' tbToolBar_Button8
		'
		Me.tbToolBar_Button8.Name = "tbToolBar_Button8"
		Me.tbToolBar_Button8.Tag = "Key=Copy;ImageKey=Copy;"
		Me.tbToolBar_Button8.ImageIndex = 4
		Me.tbToolBar_Button8.Width = 23
		Me.tbToolBar_Button8.Height = 22
		Me.tbToolBar_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button8.AutoSize = False
		Me.tbToolBar_Button8.ToolTipText = "Copy"
		'
		' tbToolBar_Button9
		'
		Me.tbToolBar_Button9.Name = "tbToolBar_Button9"
		Me.tbToolBar_Button9.Tag = "Key=Cut;ImageKey=Cut;"
		Me.tbToolBar_Button9.ImageIndex = 5
		Me.tbToolBar_Button9.Width = 23
		Me.tbToolBar_Button9.Height = 22
		Me.tbToolBar_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button9.AutoSize = False
		Me.tbToolBar_Button9.ToolTipText = "Cut"
		'
		' tbToolBar_Button10
		'
		Me.tbToolBar_Button10.Name = "tbToolBar_Button10"
		Me.tbToolBar_Button10.Tag = "Key=Paste;ImageKey=Paste;"
		Me.tbToolBar_Button10.ImageIndex = 6
		Me.tbToolBar_Button10.Width = 23
		Me.tbToolBar_Button10.Height = 22
		Me.tbToolBar_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button10.AutoSize = False
		Me.tbToolBar_Button10.ToolTipText = "Paste"
		'
		' tbToolBar_Button11
		'
		Me.tbToolBar_Button11.Name = "tbToolBar_Button11"
		Me.tbToolBar_Button11.Tag = "Style=3;"
		Me.tbToolBar_Button11.Width = 7
		Me.tbToolBar_Button11.Height = 22
		Me.tbToolBar_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button11.AutoSize = False
		'
		' tbToolBar_Button12
		'
		Me.tbToolBar_Button12.Name = "tbToolBar_Button12"
		Me.tbToolBar_Button12.Tag = "Key=Find;ImageKey=Find;"
		Me.tbToolBar_Button12.ImageIndex = 13
		Me.tbToolBar_Button12.Width = 23
		Me.tbToolBar_Button12.Height = 22
		Me.tbToolBar_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button12.AutoSize = False
		Me.tbToolBar_Button12.ToolTipText = "Find"
		'
		' tbToolBar_Button13
		'
		Me.tbToolBar_Button13.Name = "tbToolBar_Button13"
		Me.tbToolBar_Button13.Tag = "Style=3;"
		Me.tbToolBar_Button13.Width = 7
		Me.tbToolBar_Button13.Height = 22
		Me.tbToolBar_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button13.AutoSize = False
		'
		' tbToolBar_Button14
		'
		Me.tbToolBar_Button14.Name = "tbToolBar_Button14"
		Me.tbToolBar_Button14.Tag = "Key=Bold;ImageKey=Bold;"
		Me.tbToolBar_Button14.ImageIndex = 7
		Me.tbToolBar_Button14.Width = 23
		Me.tbToolBar_Button14.Height = 22
		Me.tbToolBar_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button14.AutoSize = False
		Me.tbToolBar_Button14.ToolTipText = "Bold"
		'
		' tbToolBar_Button15
		'
		Me.tbToolBar_Button15.Name = "tbToolBar_Button15"
		Me.tbToolBar_Button15.Tag = "Key=Italic;ImageKey=Italic;"
		Me.tbToolBar_Button15.ImageIndex = 8
		Me.tbToolBar_Button15.Width = 23
		Me.tbToolBar_Button15.Height = 22
		Me.tbToolBar_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button15.AutoSize = False
		Me.tbToolBar_Button15.ToolTipText = "Italic"
		'
		' tbToolBar_Button16
		'
		Me.tbToolBar_Button16.Name = "tbToolBar_Button16"
		Me.tbToolBar_Button16.Tag = "Key=Underline;ImageKey=Underline;"
		Me.tbToolBar_Button16.ImageIndex = 9
		Me.tbToolBar_Button16.Width = 23
		Me.tbToolBar_Button16.Height = 22
		Me.tbToolBar_Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button16.AutoSize = False
		Me.tbToolBar_Button16.ToolTipText = "Underline"
		'
		' tbToolBar_Button17
		'
		Me.tbToolBar_Button17.Name = "tbToolBar_Button17"
		Me.tbToolBar_Button17.Tag = "Key=Strike Through;ImageKey=Strike Through;"
		Me.tbToolBar_Button17.ImageIndex = 15
		Me.tbToolBar_Button17.Width = 23
		Me.tbToolBar_Button17.Height = 22
		Me.tbToolBar_Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button17.AutoSize = False
		Me.tbToolBar_Button17.ToolTipText = "Strike Through"
		'
		' tbToolBar_Button18
		'
		Me.tbToolBar_Button18.Name = "tbToolBar_Button18"
		Me.tbToolBar_Button18.Tag = "Style=3;"
		Me.tbToolBar_Button18.Width = 7
		Me.tbToolBar_Button18.Height = 22
		Me.tbToolBar_Button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button18.AutoSize = False
		'
		' tbToolBar_Button19
		'
		Me.tbToolBar_Button19.Name = "tbToolBar_Button19"
		Me.tbToolBar_Button19.Tag = "Key=Align Left;ImageKey=Align Left;Style=2;"
		Me.tbToolBar_Button19.ImageIndex = 10
		Me.tbToolBar_Button19.Width = 23
		Me.tbToolBar_Button19.Height = 22
		Me.tbToolBar_Button19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button19.AutoSize = False
		Me.tbToolBar_Button19.ToolTipText = "Align Left"
		'
		' tbToolBar_Button20
		'
		Me.tbToolBar_Button20.Name = "tbToolBar_Button20"
		Me.tbToolBar_Button20.Tag = "Key=Align Right;ImageKey=Align Right;Style=2;"
		Me.tbToolBar_Button20.ImageIndex = 11
		Me.tbToolBar_Button20.Width = 23
		Me.tbToolBar_Button20.Height = 22
		Me.tbToolBar_Button20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button20.AutoSize = False
		Me.tbToolBar_Button20.ToolTipText = "Align Right"
		'
		' tbToolBar_Button21
		'
		Me.tbToolBar_Button21.Name = "tbToolBar_Button21"
		Me.tbToolBar_Button21.Tag = "Key=Center;ImageKey=Center;Style=2;"
		Me.tbToolBar_Button21.ImageIndex = 12
		Me.tbToolBar_Button21.Width = 23
		Me.tbToolBar_Button21.Height = 22
		Me.tbToolBar_Button21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button21.AutoSize = False
		Me.tbToolBar_Button21.ToolTipText = "Center"
		'
		' tbToolBar_Button22
		'
		Me.tbToolBar_Button22.Name = "tbToolBar_Button22"
		Me.tbToolBar_Button22.Tag = "Style=3;"
		Me.tbToolBar_Button22.Width = 7
		Me.tbToolBar_Button22.Height = 22
		Me.tbToolBar_Button22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button22.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button22.AutoSize = False
		'
		' tbToolBar_Button23
		'
		Me.tbToolBar_Button23.Name = "tbToolBar_Button23"
		Me.tbToolBar_Button23.Tag = "Key=Help;ImageKey=Help;"
		Me.tbToolBar_Button23.ImageIndex = 17
		Me.tbToolBar_Button23.Width = 23
		Me.tbToolBar_Button23.Height = 22
		Me.tbToolBar_Button23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button23.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button23.AutoSize = False
		Me.tbToolBar_Button23.ToolTipText = "Help"
		'
		' sbStatusBar_Control
		'
		Me.sbStatusBar_Control.Name = "sbStatusBar_Control"
		Me.sbStatusBar_Control.Size = New System.Drawing.Size(574, 18)
		Me.sbStatusBar_Control.Location = New System.Drawing.Point(0, 319)
		Me.sbStatusBar_Control.TabIndex = 0
		Me.sbStatusBar_Control.ShowItemToolTips = True
		Me.sbStatusBar_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' sbStatusBar_Panel1
		'
		Me.sbStatusBar_Panel1.Name = "sbStatusBar_Panel1"
		Me.sbStatusBar_Panel1.Text = "Status"
		Me.sbStatusBar_Panel1.AutoSize = False
		Me.sbStatusBar_Panel1.Size = New System.Drawing.Size(361, 14)
		Me.sbStatusBar_Panel1.DoubleClickEnabled = True
		Me.sbStatusBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' sbStatusBar_Panel2
		'
		Me.sbStatusBar_Panel2.Name = "sbStatusBar_Panel2"
		Me.sbStatusBar_Panel2.Tag = "Style=6;"
		Me.sbStatusBar_Panel2.AutoSize = True
		Me.sbStatusBar_Panel2.Size = New System.Drawing.Size(98, 14)
		Me.sbStatusBar_Panel2.DoubleClickEnabled = True
		Me.sbStatusBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' sbStatusBar_Panel3
		'
		Me.sbStatusBar_Panel3.Name = "sbStatusBar_Panel3"
		Me.sbStatusBar_Panel3.Tag = "Style=5;"
		Me.sbStatusBar_Panel3.AutoSize = True
		Me.sbStatusBar_Panel3.Size = New System.Drawing.Size(98, 14)
		Me.sbStatusBar_Panel3.DoubleClickEnabled = True
		Me.sbStatusBar_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbStatusBar_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbStatusBar_Panel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbStatusBar_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.BackColor = FromOleColor6(CInt(&H8000000C))
		Me.Caption = "RTFDemo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 49)
		Me.ClientSize = New System.Drawing.Size(574, 313)

		Me.Controls.Add(CoolBar1_Placeholder)
		Me.CoolBar1_Placeholder.Controls.Add(cboSize)
		Me.CoolBar1_Placeholder.Controls.Add(cboFonts)
		Me.CoolBar1_Placeholder.Controls.Add(tbToolBar)
		Me.CoolBar1_Placeholder.Controls.Add(TransTBWrapper1)
		Me.CoolBar1_Placeholder.Controls.Add(tbToolBar_Control)
		Me.Controls.Add(sbStatusBar)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileNew)
		Me.mnuFile.DropDownItems.Add(mnuFileOpen)
		Me.mnuFile.DropDownItems.Add(mnuFileClose)
		Me.mnuFile.DropDownItems.Add(mnuFileBar0)
		Me.mnuFile.DropDownItems.Add(mnuFileSave)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAs)
		Me.mnuFile.DropDownItems.Add(mnuFileBar1)
		Me.mnuFile.DropDownItems.Add(mnuFilePrint)
		Me.mnuFile.DropDownItems.Add(mnuFileBar2)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_001)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_002)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_003)
		Me.mnuFile.DropDownItems.Add(mnuFileBar3)
		Me.mnuFile.DropDownItems.Add(mnuFileExit)
		Me.MenuStrip1.Items.Add(mnuEdit)
		Me.mnuEdit.DropDownItems.Add(mnuEditUndo)
		Me.mnuEdit.DropDownItems.Add(mnuEditBar0)
		Me.mnuEdit.DropDownItems.Add(mnuEditCut)
		Me.mnuEdit.DropDownItems.Add(mnuEditCopy)
		Me.mnuEdit.DropDownItems.Add(mnuEditPaste)
		Me.mnuEdit.DropDownItems.Add(mnuEditBar2)
		Me.mnuEdit.DropDownItems.Add(mnuEditSelectAll)
		Me.mnuEdit.DropDownItems.Add(mnuEditBar3)
		Me.mnuEdit.DropDownItems.Add(mnuEditFind)
		Me.mnuEdit.DropDownItems.Add(mnuEditFindNext)
		Me.MenuStrip1.Items.Add(mnuView)
		Me.mnuView.DropDownItems.Add(mnuViewToolbar)
		Me.mnuView.DropDownItems.Add(mnuViewStatusBar)
		Me.mnuView.DropDownItems.Add(mnuViewBar1)
		Me.mnuView.DropDownItems.Add(mnuViewProperties)
		Me.MenuStrip1.Items.Add(mnuFormat)
		Me.mnuFormat.DropDownItems.Add(mnuFormatFont)
		Me.mnuFormat.DropDownItems.Add(mnuFormatParagraph)
		Me.mnuFormat.DropDownItems.Add(mnuFormatTabs)
		Me.MenuStrip1.Items.Add(mnuWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowNewWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowBar0)
		Me.mnuWindow.DropDownItems.Add(mnuWindowCascade)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileHorizontal)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileVertical)
		Me.mnuWindow.DropDownItems.Add(mnuWindowArrangeIcons)
		Me.MenuStrip1.Items.Add(mnuHelp)
		Me.mnuHelp.DropDownItems.Add(mnuHelpAbout)
		Me.Controls.Add(sbStatusBar_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.CoolBar1_Placeholder.Controls.SetChildIndex(Me.tbToolBar, 0)
		Me.CoolBar1_Placeholder.Controls.SetChildIndex(Me.tbToolBar_Control, 0)
		Me.Controls.SetChildIndex(Me.sbStatusBar, 0)
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TransTBWrapper1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imlIcons, System.ComponentModel.ISupportInitialize).EndInit()
		Me.CoolBar1_Placeholder.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
