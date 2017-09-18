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
	Public WithEvents tbToolBar As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents sbStatusBar As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents dlgCommonDialog As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents imlToolbarIcons As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAs As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAll As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileProperties As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFilePageSetup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFilePrintPreview As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFilePrint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSend As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileMRU_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileMRU_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileMRU_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditUndo As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditCut As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditCopy As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditPaste As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditPasteSpecial As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuView As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewToolbar As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewStatusBar As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuViewRefresh As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewOptions As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuViewWebBrowser As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTools As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuToolsOptions As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowNewWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuWindowCascade As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileHorizontal As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileVertical As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowArrangeIcons As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelpContents As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelpSearchForHelpOn As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelpBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuHelpAbout As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents tbToolBar_Control As System.Windows.Forms.ToolStrip
	Public WithEvents tbToolBar_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button13 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button14 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents tbToolBar_Button15 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button16 As System.Windows.Forms.ToolStripButton
	Public WithEvents tbToolBar_Button17 As System.Windows.Forms.ToolStripButton
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
		Me.tbToolBar = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.sbStatusBar = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.dlgCommonDialog = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.imlToolbarIcons = New CodeArchitects.VB6Library.VB6ImageList()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileSave = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAs = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAll = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileProperties = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFilePageSetup = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFilePrintPreview = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFilePrint = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileSend = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar4 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileMRU_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileMRU_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileMRU_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar5 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditUndo = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditCut = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditCopy = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditPaste = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditPasteSpecial = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuView = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewToolbar = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewStatusBar = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuViewRefresh = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewOptions = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuViewWebBrowser = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTools = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuToolsOptions = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowNewWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuWindowCascade = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileHorizontal = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileVertical = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowArrangeIcons = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelpContents = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelpSearchForHelpOn = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelpBar0 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuHelpAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.tbToolBar_Control = New System.Windows.Forms.ToolStrip()
		Me.tbToolBar_Button1 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button2 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button4 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button6 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button7 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button8 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button9 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button10 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button11 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button12 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button13 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button14 = New System.Windows.Forms.ToolStripSeparator()
		Me.tbToolBar_Button15 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button16 = New System.Windows.Forms.ToolStripButton()
		Me.tbToolBar_Button17 = New System.Windows.Forms.ToolStripButton()
		Me.sbStatusBar_Control = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imlToolbarIcons, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' tbToolBar
		'
		Me.tbToolBar.Name = "tbToolBar"
		Me.tbToolBar.Location = New System.Drawing.Point(0, 24)
		Me.tbToolBar.ButtonWidth = 609
		Me.tbToolBar.ButtonHeight = 582
		Me.tbToolBar.ImageList = imlToolbarIcons
		Me.tbToolBar.Size = New System.Drawing.Size(2, 2)
		Me.tbToolBar.ToolStrip = Me.tbToolBar_Control
		Me.tbToolBar_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbToolBar_Button1, Me.tbToolBar_Button2, Me.tbToolBar_Button3, Me.tbToolBar_Button4, Me.tbToolBar_Button5, Me.tbToolBar_Button6, Me.tbToolBar_Button7, Me.tbToolBar_Button8, Me.tbToolBar_Button9, Me.tbToolBar_Button10, Me.tbToolBar_Button11, Me.tbToolBar_Button12, Me.tbToolBar_Button13, Me.tbToolBar_Button14, Me.tbToolBar_Button15, Me.tbToolBar_Button16, Me.tbToolBar_Button17})
		'
		' sbStatusBar
		'
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 406)
		Me.sbStatusBar.Size = New System.Drawing.Size(2, 2)
		Me.sbStatusBar.StatusStrip = Me.sbStatusBar_Control
		Me.sbStatusBar_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatusBar_Panel1, Me.sbStatusBar_Panel2, Me.sbStatusBar_Panel3})
		'
		' dlgCommonDialog
		'
		Me.dlgCommonDialog.Name = "dlgCommonDialog"
		Me.dlgCommonDialog.ParentForm = Me
		Me.dlgCommonDialog.Name6 = "dlgCommonDialog"
		'
		' imlToolbarIcons
		'
		Me.imlToolbarIcons.Name = "imlToolbarIcons"
		Me.imlToolbarIcons.ParentForm = Me
		Me.imlToolbarIcons.Name6 = "imlToolbarIcons"
		Me.imlToolbarIcons.BackColor = FromOleColor6(CInt(-2147483643))
		Me.imlToolbarIcons.MaskColor = FromOleColor6(CInt(12632256))
		Me.imlToolbarIcons.Tag = "Key1=New;Key2=Open;Key3=Save;Key4=Print;Key5=Cut;Key6=Copy;Key7=Paste;Key8=Bold;Key9=Italic;Key10=Underline;Key11=Align Left;Key12=Center;Key13=Align Right;"
		Me.imlToolbarIcons.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlToolbarIcons.ImageStream = CType(resources.GetObject("imlToolbarIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
		Me.mnuFileOpen.Caption = "&Open..."
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
		' mnuFileSaveAll
		'
		Me.mnuFileSaveAll.Name = "mnuFileSaveAll"
		Me.mnuFileSaveAll.Caption = "Save A&ll"
		'
		' mnuFileBar1
		'
		Me.mnuFileBar1.Name = "mnuFileBar1"
		'
		' mnuFileProperties
		'
		Me.mnuFileProperties.Name = "mnuFileProperties"
		Me.mnuFileProperties.Caption = "Propert&ies"
		'
		' mnuFileBar2
		'
		Me.mnuFileBar2.Name = "mnuFileBar2"
		'
		' mnuFilePageSetup
		'
		Me.mnuFilePageSetup.Name = "mnuFilePageSetup"
		Me.mnuFilePageSetup.Caption = "Page Set&up..."
		'
		' mnuFilePrintPreview
		'
		Me.mnuFilePrintPreview.Name = "mnuFilePrintPreview"
		Me.mnuFilePrintPreview.Caption = "Print Pre&view"
		'
		' mnuFilePrint
		'
		Me.mnuFilePrint.Name = "mnuFilePrint"
		Me.mnuFilePrint.Caption = "&Print..."
		'
		' mnuFileBar3
		'
		Me.mnuFileBar3.Name = "mnuFileBar3"
		'
		' mnuFileSend
		'
		Me.mnuFileSend.Name = "mnuFileSend"
		Me.mnuFileSend.Caption = "Sen&d..."
		'
		' mnuFileBar4
		'
		Me.mnuFileBar4.Name = "mnuFileBar4"
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
		' mnuFileBar5
		'
		Me.mnuFileBar5.Name = "mnuFileBar5"
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
		' mnuEditPasteSpecial
		'
		Me.mnuEditPasteSpecial.Name = "mnuEditPasteSpecial"
		Me.mnuEditPasteSpecial.Caption = "Paste &Special..."
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
		Me.mnuViewStatusBar.Caption = "Status &Bar"
		Me.mnuViewStatusBar.Checked = True
		'
		' mnuViewBar0
		'
		Me.mnuViewBar0.Name = "mnuViewBar0"
		'
		' mnuViewRefresh
		'
		Me.mnuViewRefresh.Name = "mnuViewRefresh"
		Me.mnuViewRefresh.Caption = "&Refresh"
		'
		' mnuViewOptions
		'
		Me.mnuViewOptions.Name = "mnuViewOptions"
		Me.mnuViewOptions.Caption = "&Options..."
		'
		' mnuViewWebBrowser
		'
		Me.mnuViewWebBrowser.Name = "mnuViewWebBrowser"
		Me.mnuViewWebBrowser.Caption = "&Web Browser"
		'
		' mnuTools
		'
		Me.mnuTools.Name = "mnuTools"
		Me.mnuTools.Caption = "&Tools"
		'
		' mnuToolsOptions
		'
		Me.mnuToolsOptions.Name = "mnuToolsOptions"
		Me.mnuToolsOptions.Caption = "&Options..."
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
		' mnuHelpContents
		'
		Me.mnuHelpContents.Name = "mnuHelpContents"
		Me.mnuHelpContents.Caption = "&Contents"
		'
		' mnuHelpSearchForHelpOn
		'
		Me.mnuHelpSearchForHelpOn.Name = "mnuHelpSearchForHelpOn"
		Me.mnuHelpSearchForHelpOn.Caption = "&Search For Help On..."
		'
		' mnuHelpBar0
		'
		Me.mnuHelpBar0.Name = "mnuHelpBar0"
		'
		' mnuHelpAbout
		'
		Me.mnuHelpAbout.Name = "mnuHelpAbout"
		Me.mnuHelpAbout.Caption = "&About "
		'
		' tbToolBar_Control
		'
		Me.tbToolBar_Control.Name = "tbToolBar_Control"
		Me.tbToolBar_Control.Size = New System.Drawing.Size(679, 28)
		Me.tbToolBar_Control.Location = New System.Drawing.Point(0, 24)
		Me.tbToolBar_Control.TabIndex = 1
		Me.tbToolBar_Control.ImageList = imlToolbarIcons.ImageList
		Me.tbToolBar_Control.Dock = System.Windows.Forms.DockStyle.Top
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
		Me.tbToolBar_Button7.Tag = "Key=Cut;ImageKey=Cut;"
		Me.tbToolBar_Button7.ImageIndex = 4
		Me.tbToolBar_Button7.Width = 23
		Me.tbToolBar_Button7.Height = 22
		Me.tbToolBar_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button7.AutoSize = False
		Me.tbToolBar_Button7.ToolTipText = "Cut"
		'
		' tbToolBar_Button8
		'
		Me.tbToolBar_Button8.Name = "tbToolBar_Button8"
		Me.tbToolBar_Button8.Tag = "Key=Copy;ImageKey=Copy;"
		Me.tbToolBar_Button8.ImageIndex = 5
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
		Me.tbToolBar_Button9.Tag = "Key=Paste;ImageKey=Paste;"
		Me.tbToolBar_Button9.ImageIndex = 6
		Me.tbToolBar_Button9.Width = 23
		Me.tbToolBar_Button9.Height = 22
		Me.tbToolBar_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button9.AutoSize = False
		Me.tbToolBar_Button9.ToolTipText = "Paste"
		'
		' tbToolBar_Button10
		'
		Me.tbToolBar_Button10.Name = "tbToolBar_Button10"
		Me.tbToolBar_Button10.Tag = "Style=3;"
		Me.tbToolBar_Button10.Width = 7
		Me.tbToolBar_Button10.Height = 22
		Me.tbToolBar_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button10.AutoSize = False
		'
		' tbToolBar_Button11
		'
		Me.tbToolBar_Button11.Name = "tbToolBar_Button11"
		Me.tbToolBar_Button11.Tag = "Key=Bold;ImageKey=Bold;"
		Me.tbToolBar_Button11.ImageIndex = 7
		Me.tbToolBar_Button11.Width = 23
		Me.tbToolBar_Button11.Height = 22
		Me.tbToolBar_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button11.AutoSize = False
		Me.tbToolBar_Button11.ToolTipText = "Bold"
		'
		' tbToolBar_Button12
		'
		Me.tbToolBar_Button12.Name = "tbToolBar_Button12"
		Me.tbToolBar_Button12.Tag = "Key=Italic;ImageKey=Italic;"
		Me.tbToolBar_Button12.ImageIndex = 8
		Me.tbToolBar_Button12.Width = 23
		Me.tbToolBar_Button12.Height = 22
		Me.tbToolBar_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button12.AutoSize = False
		Me.tbToolBar_Button12.ToolTipText = "Italic"
		'
		' tbToolBar_Button13
		'
		Me.tbToolBar_Button13.Name = "tbToolBar_Button13"
		Me.tbToolBar_Button13.Tag = "Key=Underline;ImageKey=Underline;"
		Me.tbToolBar_Button13.ImageIndex = 9
		Me.tbToolBar_Button13.Width = 23
		Me.tbToolBar_Button13.Height = 22
		Me.tbToolBar_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button13.AutoSize = False
		Me.tbToolBar_Button13.ToolTipText = "Underline"
		'
		' tbToolBar_Button14
		'
		Me.tbToolBar_Button14.Name = "tbToolBar_Button14"
		Me.tbToolBar_Button14.Tag = "Style=3;"
		Me.tbToolBar_Button14.Width = 7
		Me.tbToolBar_Button14.Height = 22
		Me.tbToolBar_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button14.AutoSize = False
		'
		' tbToolBar_Button15
		'
		Me.tbToolBar_Button15.Name = "tbToolBar_Button15"
		Me.tbToolBar_Button15.Tag = "Key=Align Left;ImageKey=Align Left;Style=2;"
		Me.tbToolBar_Button15.ImageIndex = 10
		Me.tbToolBar_Button15.Width = 23
		Me.tbToolBar_Button15.Height = 22
		Me.tbToolBar_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button15.AutoSize = False
		Me.tbToolBar_Button15.ToolTipText = "Align Left"
		'
		' tbToolBar_Button16
		'
		Me.tbToolBar_Button16.Name = "tbToolBar_Button16"
		Me.tbToolBar_Button16.Tag = "Key=Center;ImageKey=Center;Style=2;"
		Me.tbToolBar_Button16.ImageIndex = 11
		Me.tbToolBar_Button16.Width = 23
		Me.tbToolBar_Button16.Height = 22
		Me.tbToolBar_Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button16.AutoSize = False
		Me.tbToolBar_Button16.ToolTipText = "Center"
		'
		' tbToolBar_Button17
		'
		Me.tbToolBar_Button17.Name = "tbToolBar_Button17"
		Me.tbToolBar_Button17.Tag = "Key=Align Right;ImageKey=Align Right;Style=2;"
		Me.tbToolBar_Button17.ImageIndex = 12
		Me.tbToolBar_Button17.Width = 23
		Me.tbToolBar_Button17.Height = 22
		Me.tbToolBar_Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button17.AutoSize = False
		Me.tbToolBar_Button17.ToolTipText = "Align Right"
		'
		' sbStatusBar_Control
		'
		Me.sbStatusBar_Control.Name = "sbStatusBar_Control"
		Me.sbStatusBar_Control.Size = New System.Drawing.Size(679, 18)
		Me.sbStatusBar_Control.Location = New System.Drawing.Point(0, 406)
		Me.sbStatusBar_Control.TabIndex = 0
		Me.sbStatusBar_Control.ShowItemToolTips = True
		Me.sbStatusBar_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' sbStatusBar_Panel1
		'
		Me.sbStatusBar_Panel1.Name = "sbStatusBar_Panel1"
		Me.sbStatusBar_Panel1.Text = "Status"
		Me.sbStatusBar_Panel1.AutoSize = False
		Me.sbStatusBar_Panel1.Size = New System.Drawing.Size(465, 14)
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
		Me.Caption = "ClassicVB"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.WindowState = CodeArchitects.VB6Library.VBRUN.FormWindowStateConstants.vbMaximized
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 57)
		Me.ClientSize = New System.Drawing.Size(679, 400)

		Me.Controls.Add(tbToolBar)
		Me.Controls.Add(sbStatusBar)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileNew)
		Me.mnuFile.DropDownItems.Add(mnuFileOpen)
		Me.mnuFile.DropDownItems.Add(mnuFileClose)
		Me.mnuFile.DropDownItems.Add(mnuFileBar0)
		Me.mnuFile.DropDownItems.Add(mnuFileSave)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAs)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAll)
		Me.mnuFile.DropDownItems.Add(mnuFileBar1)
		Me.mnuFile.DropDownItems.Add(mnuFileProperties)
		Me.mnuFile.DropDownItems.Add(mnuFileBar2)
		Me.mnuFile.DropDownItems.Add(mnuFilePageSetup)
		Me.mnuFile.DropDownItems.Add(mnuFilePrintPreview)
		Me.mnuFile.DropDownItems.Add(mnuFilePrint)
		Me.mnuFile.DropDownItems.Add(mnuFileBar3)
		Me.mnuFile.DropDownItems.Add(mnuFileSend)
		Me.mnuFile.DropDownItems.Add(mnuFileBar4)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_001)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_002)
		Me.mnuFile.DropDownItems.Add(mnuFileMRU_003)
		Me.mnuFile.DropDownItems.Add(mnuFileBar5)
		Me.mnuFile.DropDownItems.Add(mnuFileExit)
		Me.MenuStrip1.Items.Add(mnuEdit)
		Me.mnuEdit.DropDownItems.Add(mnuEditUndo)
		Me.mnuEdit.DropDownItems.Add(mnuEditBar0)
		Me.mnuEdit.DropDownItems.Add(mnuEditCut)
		Me.mnuEdit.DropDownItems.Add(mnuEditCopy)
		Me.mnuEdit.DropDownItems.Add(mnuEditPaste)
		Me.mnuEdit.DropDownItems.Add(mnuEditPasteSpecial)
		Me.MenuStrip1.Items.Add(mnuView)
		Me.mnuView.DropDownItems.Add(mnuViewToolbar)
		Me.mnuView.DropDownItems.Add(mnuViewStatusBar)
		Me.mnuView.DropDownItems.Add(mnuViewBar0)
		Me.mnuView.DropDownItems.Add(mnuViewRefresh)
		Me.mnuView.DropDownItems.Add(mnuViewOptions)
		Me.mnuView.DropDownItems.Add(mnuViewWebBrowser)
		Me.MenuStrip1.Items.Add(mnuTools)
		Me.mnuTools.DropDownItems.Add(mnuToolsOptions)
		Me.MenuStrip1.Items.Add(mnuWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowNewWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowBar0)
		Me.mnuWindow.DropDownItems.Add(mnuWindowCascade)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileHorizontal)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileVertical)
		Me.mnuWindow.DropDownItems.Add(mnuWindowArrangeIcons)
		Me.MenuStrip1.Items.Add(mnuHelp)
		Me.mnuHelp.DropDownItems.Add(mnuHelpContents)
		Me.mnuHelp.DropDownItems.Add(mnuHelpSearchForHelpOn)
		Me.mnuHelp.DropDownItems.Add(mnuHelpBar0)
		Me.mnuHelp.DropDownItems.Add(mnuHelpAbout)
		Me.Controls.Add(tbToolBar_Control)
		Me.Controls.Add(sbStatusBar_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.tbToolBar, 0)
		Me.Controls.SetChildIndex(Me.tbToolBar_Control, 0)
		Me.Controls.SetChildIndex(Me.sbStatusBar, 0)
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imlToolbarIcons, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
