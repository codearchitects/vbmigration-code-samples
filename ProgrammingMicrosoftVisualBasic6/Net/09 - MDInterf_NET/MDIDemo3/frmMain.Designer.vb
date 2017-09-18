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
		Me.mnuFileNewItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuFileNewItem_000, mnuFileNewItem_001)
		Me.mnuFileOpenItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuFileOpenItem_000, mnuFileOpenItem_001)
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
	Public mnuFileNewItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuFileOpenItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents tbToolBar As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents sbStatusBar As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents dlgCommonDialog As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents imlIcons As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNewItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNewItem_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpenItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpenItem_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAs As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFilePrintSetup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFilePrint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileBar6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditCut As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditCopy As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditPaste As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowCascade As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileHorizontal As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowTileVertical As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowArrangeIcons As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelp As CodeArchitects.VB6Library.VB6Menu
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
		Me.imlIcons = New CodeArchitects.VB6Library.VB6ImageList()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNewItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNewItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpenItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpenItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileSave = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAs = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFilePrintSetup = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFilePrint = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileBar6 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditCut = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditCopy = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditPaste = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowCascade = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileHorizontal = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowTileVertical = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowArrangeIcons = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelp = New CodeArchitects.VB6Library.VB6Menu()
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
		Me.sbStatusBar_Control = New System.Windows.Forms.StatusStrip()
		Me.sbStatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.sbStatusBar_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imlIcons, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' tbToolBar
		'
		Me.tbToolBar.Name = "tbToolBar"
		Me.tbToolBar.Location = New System.Drawing.Point(0, 24)
		Me.tbToolBar.ButtonWidth = 635
		Me.tbToolBar.ButtonHeight = 582
		Me.tbToolBar.ImageList = imlIcons
		Me.tbToolBar.Size = New Size(2, 2)
		Me.tbToolBar.ToolStrip = Me.tbToolBar_Control
		Me.tbToolBar_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbToolBar_Button1, Me.tbToolBar_Button2, Me.tbToolBar_Button3, Me.tbToolBar_Button4, Me.tbToolBar_Button5, Me.tbToolBar_Button6, Me.tbToolBar_Button7, Me.tbToolBar_Button8, Me.tbToolBar_Button9})
		'
		' sbStatusBar
		'
		Me.sbStatusBar.Name = "sbStatusBar"
		Me.sbStatusBar.Location = New System.Drawing.Point(0, 352)
		Me.sbStatusBar.SimpleText = ""
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
		Me.imlIcons.BackColor = FromOleColor6(CInt(-2147483643))
		Me.imlIcons.MaskColor = FromOleColor6(CInt(12632256))
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
		'
		' mnuFileNewItem_000
		'
		Me.mnuFileNewItem_000.Name = "mnuFileNewItem_000"
		Me.mnuFileNewItem_000.Caption = "&Text"
		'
		' mnuFileNewItem_001
		'
		Me.mnuFileNewItem_001.Name = "mnuFileNewItem_001"
		Me.mnuFileNewItem_001.Caption = "&Image"
		'
		' mnuFileOpen
		'
		Me.mnuFileOpen.Name = "mnuFileOpen"
		Me.mnuFileOpen.Caption = "&Open"
		'
		' mnuFileOpenItem_000
		'
		Me.mnuFileOpenItem_000.Name = "mnuFileOpenItem_000"
		Me.mnuFileOpenItem_000.Caption = "&Text"
		'
		' mnuFileOpenItem_001
		'
		Me.mnuFileOpenItem_001.Name = "mnuFileOpenItem_001"
		Me.mnuFileOpenItem_001.Caption = "&Image"
		'
		' mnuFileClose
		'
		Me.mnuFileClose.Name = "mnuFileClose"
		Me.mnuFileClose.Caption = "&Close"
		'
		' mnuFileBar1
		'
		Me.mnuFileBar1.Name = "mnuFileBar1"
		'
		' mnuFileSave
		'
		Me.mnuFileSave.Name = "mnuFileSave"
		Me.mnuFileSave.Caption = "&Save"
		Me.mnuFileSave.Shortcut = Keys.Control Or Keys.S
		'
		' mnuFileSaveAs
		'
		Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
		Me.mnuFileSaveAs.Caption = "Save &As..."
		'
		' mnuFileBar2
		'
		Me.mnuFileBar2.Name = "mnuFileBar2"
		'
		' mnuFilePrintSetup
		'
		Me.mnuFilePrintSetup.Name = "mnuFilePrintSetup"
		Me.mnuFilePrintSetup.Caption = "Print Set&up..."
		'
		' mnuFilePrint
		'
		Me.mnuFilePrint.Name = "mnuFilePrint"
		Me.mnuFilePrint.Caption = "&Print"
		Me.mnuFilePrint.Shortcut = Keys.Control Or Keys.P
		'
		' mnuFileBar6
		'
		Me.mnuFileBar6.Name = "mnuFileBar6"
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
		' mnuWindow
		'
		Me.mnuWindow.Name = "mnuWindow"
		Me.mnuWindow.Caption = "&Window"
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
		Me.mnuHelpAbout.Caption = "&About MDIDemo..."
		'
		' tbToolBar_Control
		'
		Me.tbToolBar_Control.Name = "tbToolBar_Control"
		Me.tbToolBar_Control.Size = New System.Drawing.Size(574, 28)
		Me.tbToolBar_Control.Location = New System.Drawing.Point(0, 24)
		Me.tbToolBar_Control.TabIndex = 1
		Me.tbToolBar_Control.ImageList = imlIcons.ImageList
		Me.tbToolBar_Control.Dock = System.Windows.Forms.DockStyle.Top
		'
		' tbToolBar_Button1
		'
		Me.tbToolBar_Button1.Name = "tbToolBar_Button1"
		Me.tbToolBar_Button1.Tag = "Key=New;"
		Me.tbToolBar_Button1.ImageIndex = 0
		Me.tbToolBar_Button1.Width = 24
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
		Me.tbToolBar_Button2.Tag = "Key=Open;"
		Me.tbToolBar_Button2.ImageIndex = 1
		Me.tbToolBar_Button2.Width = 24
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
		Me.tbToolBar_Button3.Tag = "Key=Save;"
		Me.tbToolBar_Button3.ImageIndex = 2
		Me.tbToolBar_Button3.Width = 24
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
		Me.tbToolBar_Button5.Tag = "Key=Print;"
		Me.tbToolBar_Button5.ImageIndex = 3
		Me.tbToolBar_Button5.Width = 24
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
		Me.tbToolBar_Button7.Tag = "Key=Cut;"
		Me.tbToolBar_Button7.ImageIndex = 4
		Me.tbToolBar_Button7.Width = 24
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
		Me.tbToolBar_Button8.Tag = "Key=Copy;"
		Me.tbToolBar_Button8.ImageIndex = 5
		Me.tbToolBar_Button8.Width = 24
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
		Me.tbToolBar_Button9.Tag = "Key=Paste;"
		Me.tbToolBar_Button9.ImageIndex = 6
		Me.tbToolBar_Button9.Width = 24
		Me.tbToolBar_Button9.Height = 22
		Me.tbToolBar_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.tbToolBar_Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.tbToolBar_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.tbToolBar_Button9.AutoSize = False
		Me.tbToolBar_Button9.ToolTipText = "Paste"
		'
		' sbStatusBar_Control
		'
		Me.sbStatusBar_Control.Name = "sbStatusBar_Control"
		Me.sbStatusBar_Control.Size = New System.Drawing.Size(574, 18)
		Me.sbStatusBar_Control.Location = New System.Drawing.Point(0, 352)
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
		Me.Caption = "MDIDemo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 49)
		Me.ClientSize = New System.Drawing.Size(574, 346)

		Me.Controls.Add(tbToolBar)
		Me.Controls.Add(sbStatusBar)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileNew)
		Me.mnuFileNew.DropDownItems.Add(mnuFileNewItem_000)
		Me.mnuFileNew.DropDownItems.Add(mnuFileNewItem_001)
		Me.mnuFile.DropDownItems.Add(mnuFileOpen)
		Me.mnuFileOpen.DropDownItems.Add(mnuFileOpenItem_000)
		Me.mnuFileOpen.DropDownItems.Add(mnuFileOpenItem_001)
		Me.mnuFile.DropDownItems.Add(mnuFileClose)
		Me.mnuFile.DropDownItems.Add(mnuFileBar1)
		Me.mnuFile.DropDownItems.Add(mnuFileSave)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAs)
		Me.mnuFile.DropDownItems.Add(mnuFileBar2)
		Me.mnuFile.DropDownItems.Add(mnuFilePrintSetup)
		Me.mnuFile.DropDownItems.Add(mnuFilePrint)
		Me.mnuFile.DropDownItems.Add(mnuFileBar6)
		Me.mnuFile.DropDownItems.Add(mnuFileExit)
		Me.MenuStrip1.Items.Add(mnuEdit)
		Me.mnuEdit.DropDownItems.Add(mnuEditCut)
		Me.mnuEdit.DropDownItems.Add(mnuEditCopy)
		Me.mnuEdit.DropDownItems.Add(mnuEditPaste)
		Me.MenuStrip1.Items.Add(mnuWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowCascade)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileHorizontal)
		Me.mnuWindow.DropDownItems.Add(mnuWindowTileVertical)
		Me.mnuWindow.DropDownItems.Add(mnuWindowArrangeIcons)
		Me.MenuStrip1.Items.Add(mnuHelp)
		Me.mnuHelp.DropDownItems.Add(mnuHelpAbout)
		Me.Controls.Add(tbToolBar_Control)
		Me.Controls.Add(sbStatusBar_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.tbToolBar, 0)
		Me.Controls.SetChildIndex(Me.tbToolBar_Control, 0)
		Me.Controls.SetChildIndex(Me.sbStatusBar, 0)
		CType(Me.tbToolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.sbStatusBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imlIcons, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
