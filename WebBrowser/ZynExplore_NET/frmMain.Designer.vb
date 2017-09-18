<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
	Inherits CodeArchitects.VB6Library.VB6Form

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
		Me.nmeAddFav = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(nmeAddFav_000)
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
	Public nmeAddFav As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents ProgressBar1 As CodeArchitects.VB6Library.VB6ProgressBar
	Public WithEvents StatusBar1 As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdGo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents WebBrowser1 As CodeArchitects.VB6Library.VB6WebBrowser
	Public WithEvents Toolbar1 As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents nmeFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeWin As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeSave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents line2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents nmePsetup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmePrint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmePview As CodeArchitects.VB6Library.VB6Menu
	Public Shadows WithEvents line As System.Windows.Forms.ToolStripSeparator
	Public WithEvents nmeProp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeOffline As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeCopy As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeSelAll As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmePaste As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeView As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeTool As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeStan As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeSource As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeFull As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeFav As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeAddFav_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeHelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeHelpT As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents nmeAbout As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ImageList2 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents StatusBar1_Control As System.Windows.Forms.StatusStrip
	Public WithEvents StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents Toolbar1_Control As System.Windows.Forms.ToolStrip
	Public WithEvents Toolbar1_Button1 As System.Windows.Forms.ToolStripDropDownButton
	Public WithEvents Toolbar1_Button1_MenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Toolbar1_Button2 As System.Windows.Forms.ToolStripDropDownButton
	Public WithEvents Toolbar1_Button2_MenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button5 As System.Windows.Forms.ToolStripButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.ProgressBar1 = New CodeArchitects.VB6Library.VB6ProgressBar()
		Me.StatusBar1 = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdGo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.WebBrowser1 = New CodeArchitects.VB6Library.VB6WebBrowser()
		Me.Toolbar1 = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.nmeFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeWin = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeSave = New CodeArchitects.VB6Library.VB6Menu()
		Me.line2 = New System.Windows.Forms.ToolStripSeparator()
		Me.nmePsetup = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmePrint = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmePview = New CodeArchitects.VB6Library.VB6Menu()
		Me.line = New System.Windows.Forms.ToolStripSeparator()
		Me.nmeProp = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeOffline = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeCopy = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeSelAll = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmePaste = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeView = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeTool = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeStan = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeSource = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeFull = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeFav = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeAddFav_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeHelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeHelpT = New CodeArchitects.VB6Library.VB6Menu()
		Me.nmeAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ImageList2 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.StatusBar1_Control = New System.Windows.Forms.StatusStrip()
		Me.StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Toolbar1_Control = New System.Windows.Forms.ToolStrip()
		Me.Toolbar1_Button1 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.Toolbar1_Button1_MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Toolbar1_Button2 = New System.Windows.Forms.ToolStripDropDownButton()
		Me.Toolbar1_Button2_MenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.Frame1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' ProgressBar1
		'
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(81, 17)
		Me.ProgressBar1.Location = New System.Drawing.Point(504, 512)
		Me.ProgressBar1.TabIndex = 6
		Me.ProgressBar1.Scrolling = CodeArchitects.VB6Library.MSComctlLib.ScrollingConstants.ccScrollingSmooth
		'
		' StatusBar1
		'
		Me.StatusBar1.Name = "StatusBar1"
		Me.StatusBar1.Location = New System.Drawing.Point(0, 511)
		Me.StatusBar1.Size = New System.Drawing.Size(2, 2)
		Me.StatusBar1.StatusStrip = Me.StatusBar1_Control
		Me.StatusBar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBar1_Panel1, Me.StatusBar1_Panel2, Me.StatusBar1_Panel3})
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(753, 37)
		Me.Frame1.Location = New System.Drawing.Point(0, 91)
		Me.Frame1.TabIndex = 2
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(617, 23)
		Me.Text1.Location = New System.Drawing.Point(56, 10)
		Me.Text1.TabIndex = 7
		'
		' cmdGo
		'
		Me.cmdGo.Name = "cmdGo"
		Me.cmdGo.Size = New System.Drawing.Size(49, 23)
		Me.cmdGo.Location = New System.Drawing.Point(688, 9)
		Me.cmdGo.Caption = "Go"
		Me.cmdGo.TabIndex = 3
		Me.cmdGo.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.cmdGo
		Me.cmdGo.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 14)
		Me.Label1.Caption = "Address"
		Me.Label1.TabIndex = 4
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' WebBrowser1
		'
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(753, 385)
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 128)
		Me.WebBrowser1.TabIndex = 1
		Me.WebBrowser1.Silent = False
		Me.WebBrowser1.RegisterAsDropTarget = True
		'
		' Toolbar1
		'
		Me.Toolbar1.Name = "Toolbar1"
		Me.Toolbar1.Location = New System.Drawing.Point(0, 24)
		Me.Toolbar1.ButtonWidth = 1376
		Me.Toolbar1.ButtonHeight = 1667
		Me.Toolbar1.ImageList = ImageList1
		Me.Toolbar1.Size = New System.Drawing.Size(2, 2)
		Me.Toolbar1.ToolStrip = Me.Toolbar1_Control
		Me.Toolbar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button1, Me.Toolbar1_Button2, Me.Toolbar1_Button3, Me.Toolbar1_Button4, Me.Toolbar1_Button5})
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' nmeFile
		'
		Me.nmeFile.Name = "nmeFile"
		Me.nmeFile.Caption = "&File"
		'
		' nmeNew
		'
		Me.nmeNew.Name = "nmeNew"
		Me.nmeNew.Caption = "New"
		'
		' nmeWin
		'
		Me.nmeWin.Name = "nmeWin"
		Me.nmeWin.Caption = "Window"
		Me.nmeWin.Shortcut = Keys.Control Or Keys.N
		'
		' nmeOpen
		'
		Me.nmeOpen.Name = "nmeOpen"
		Me.nmeOpen.Caption = "Open"
		Me.nmeOpen.Shortcut = Keys.Control Or Keys.O
		'
		' nmeSave
		'
		Me.nmeSave.Name = "nmeSave"
		Me.nmeSave.Caption = "Save As..."
		'
		' line2
		'
		Me.line2.Name = "line2"
		'
		' nmePsetup
		'
		Me.nmePsetup.Name = "nmePsetup"
		Me.nmePsetup.Caption = "Page Setup"
		'
		' nmePrint
		'
		Me.nmePrint.Name = "nmePrint"
		Me.nmePrint.Caption = "Print"
		'
		' nmePview
		'
		Me.nmePview.Name = "nmePview"
		Me.nmePview.Caption = "Print Preview"
		'
		' line
		'
		Me.line.Name = "line"
		'
		' nmeProp
		'
		Me.nmeProp.Name = "nmeProp"
		Me.nmeProp.Caption = "Properties"
		'
		' nmeOffline
		'
		Me.nmeOffline.Name = "nmeOffline"
		Me.nmeOffline.Caption = "Work Offline"
		'
		' nmeExit
		'
		Me.nmeExit.Name = "nmeExit"
		Me.nmeExit.Caption = "Exit"
		'
		' nmeEdit
		'
		Me.nmeEdit.Name = "nmeEdit"
		Me.nmeEdit.Caption = "&Edit"
		'
		' nmeCopy
		'
		Me.nmeCopy.Name = "nmeCopy"
		Me.nmeCopy.Caption = "Copy"
		'
		' nmeSelAll
		'
		Me.nmeSelAll.Name = "nmeSelAll"
		Me.nmeSelAll.Caption = "Select All"
		'
		' nmePaste
		'
		Me.nmePaste.Name = "nmePaste"
		Me.nmePaste.Caption = "Paste"
		'
		' nmeView
		'
		Me.nmeView.Name = "nmeView"
		Me.nmeView.Caption = "&View"
		'
		' nmeTool
		'
		Me.nmeTool.Name = "nmeTool"
		Me.nmeTool.Caption = "Toolbars"
		'
		' nmeStan
		'
		Me.nmeStan.Name = "nmeStan"
		Me.nmeStan.Caption = "Standard Buttons"
		Me.nmeStan.Checked = True
		'
		' nmeSource
		'
		Me.nmeSource.Name = "nmeSource"
		Me.nmeSource.Caption = "Source"
		'
		' nmeFull
		'
		Me.nmeFull.Name = "nmeFull"
		Me.nmeFull.Caption = "FullScreen"
		'
		' nmeFav
		'
		Me.nmeFav.Name = "nmeFav"
		Me.nmeFav.Caption = "&Favorites"
		'
		' nmeAddFav_000
		'
		Me.nmeAddFav_000.Name = "nmeAddFav_000"
		Me.nmeAddFav_000.Caption = "Add Favorites"
		'
		' nmeHelp
		'
		Me.nmeHelp.Name = "nmeHelp"
		Me.nmeHelp.Caption = "&Help"
		'
		' nmeHelpT
		'
		Me.nmeHelpT.Name = "nmeHelpT"
		Me.nmeHelpT.Caption = "Help Topics"
		'
		' nmeAbout
		'
		Me.nmeAbout.Name = "nmeAbout"
		Me.nmeAbout.Caption = "About ZynExplore"
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.Name6 = "ImageList1"
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(45, 43)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' ImageList2
		'
		Me.ImageList2.Name = "ImageList2"
		Me.ImageList2.ParentForm = Me
		Me.ImageList2.Name6 = "ImageList2"
		Me.ImageList2.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList2.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList2.ImageList.ImageSize = New System.Drawing.Size(45, 43)
		Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		Me.CommonDialog1.Name6 = "CommonDialog1"
		'
		' StatusBar1_Control
		'
		Me.StatusBar1_Control.Name = "StatusBar1_Control"
		Me.StatusBar1_Control.Size = New System.Drawing.Size(758, 21)
		Me.StatusBar1_Control.Location = New System.Drawing.Point(0, 511)
		Me.StatusBar1_Control.TabIndex = 5
		Me.StatusBar1_Control.ShowItemToolTips = True
		Me.StatusBar1_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' StatusBar1_Panel1
		'
		Me.StatusBar1_Panel1.Name = "StatusBar1_Panel1"
		Me.StatusBar1_Panel1.AutoSize = False
		Me.StatusBar1_Panel1.Size = New System.Drawing.Size(496, 14)
		Me.StatusBar1_Panel1.DoubleClickEnabled = True
		Me.StatusBar1_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel2
		'
		Me.StatusBar1_Panel2.Name = "StatusBar1_Panel2"
		Me.StatusBar1_Panel2.AutoSize = False
		Me.StatusBar1_Panel2.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel2.DoubleClickEnabled = True
		Me.StatusBar1_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel3
		'
		Me.StatusBar1_Panel3.Name = "StatusBar1_Panel3"
		Me.StatusBar1_Panel3.Text = "ZynExplore"
		Me.StatusBar1_Panel3.Image = CType(resources.GetObject("StatusBar1_Panel3.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel3.AutoSize = False
		Me.StatusBar1_Panel3.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel3.DoubleClickEnabled = True
		Me.StatusBar1_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' Toolbar1_Control
		'
		Me.Toolbar1_Control.Name = "Toolbar1_Control"
		Me.Toolbar1_Control.Size = New System.Drawing.Size(758, 69)
		Me.Toolbar1_Control.Location = New System.Drawing.Point(0, 24)
		Me.Toolbar1_Control.TabIndex = 0
		Me.Toolbar1_Control.ImageList = ImageList1.ImageList
		Me.Toolbar1_Control.Dock = System.Windows.Forms.DockStyle.Top
		'
		' Toolbar1_Button1
		'
		Me.Toolbar1_Button1.Name = "Toolbar1_Button1"
		Me.Toolbar1_Button1.Tag = "Key=Back;Style=5;Tag=Back;"
		Me.Toolbar1_Button1.ImageIndex = 0
		Me.Toolbar1_Button1.Text = "Back"
		Me.Toolbar1_Button1.Width = 52
		Me.Toolbar1_Button1.Height = 63
		Me.Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button1.AutoSize = False
		Me.Toolbar1_Button1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button1_MenuItem1})
		'
		' Toolbar1_Button1_MenuItem1
		'
		Me.Toolbar1_Button1_MenuItem1.Name = "Toolbar1_Button1_MenuItem1"
		Me.Toolbar1_Button1_MenuItem1.Text = ""
		'
		' Toolbar1_Button2
		'
		Me.Toolbar1_Button2.Name = "Toolbar1_Button2"
		Me.Toolbar1_Button2.Tag = "Key=Forward;Style=5;Tag=Forward;"
		Me.Toolbar1_Button2.ImageIndex = 1
		Me.Toolbar1_Button2.Text = "Forward"
		Me.Toolbar1_Button2.Width = 52
		Me.Toolbar1_Button2.Height = 63
		Me.Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button2.AutoSize = False
		Me.Toolbar1_Button2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button2_MenuItem1})
		'
		' Toolbar1_Button2_MenuItem1
		'
		Me.Toolbar1_Button2_MenuItem1.Name = "Toolbar1_Button2_MenuItem1"
		Me.Toolbar1_Button2_MenuItem1.Text = ""
		'
		' Toolbar1_Button3
		'
		Me.Toolbar1_Button3.Name = "Toolbar1_Button3"
		Me.Toolbar1_Button3.Tag = "Key=Stop;Tag=Stop;"
		Me.Toolbar1_Button3.ImageIndex = 5
		Me.Toolbar1_Button3.Text = "Stop"
		Me.Toolbar1_Button3.Width = 52
		Me.Toolbar1_Button3.Height = 63
		Me.Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button3.AutoSize = False
		'
		' Toolbar1_Button4
		'
		Me.Toolbar1_Button4.Name = "Toolbar1_Button4"
		Me.Toolbar1_Button4.Tag = "Key=Refresh;Tag=Refresh;"
		Me.Toolbar1_Button4.ImageIndex = 4
		Me.Toolbar1_Button4.Text = "Refresh"
		Me.Toolbar1_Button4.Width = 52
		Me.Toolbar1_Button4.Height = 63
		Me.Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button4.AutoSize = False
		'
		' Toolbar1_Button5
		'
		Me.Toolbar1_Button5.Name = "Toolbar1_Button5"
		Me.Toolbar1_Button5.ImageIndex = 3
		Me.Toolbar1_Button5.Text = "Home"
		Me.Toolbar1_Button5.Width = 52
		Me.Toolbar1_Button5.Height = 63
		Me.Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button5.AutoSize = False
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ZynExplore"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 37)
		Me.ClientSize = New System.Drawing.Size(758, 532)

		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(StatusBar1)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(cmdGo)
		Me.Frame1.Controls.Add(Label1)
		Me.Controls.Add(WebBrowser1)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(nmeFile)
		Me.nmeFile.DropDownItems.Add(nmeNew)
		Me.nmeNew.DropDownItems.Add(nmeWin)
		Me.nmeFile.DropDownItems.Add(nmeOpen)
		Me.nmeFile.DropDownItems.Add(nmeSave)
		Me.nmeFile.DropDownItems.Add(line2)
		Me.nmeFile.DropDownItems.Add(nmePsetup)
		Me.nmeFile.DropDownItems.Add(nmePrint)
		Me.nmeFile.DropDownItems.Add(nmePview)
		Me.nmeFile.DropDownItems.Add(line)
		Me.nmeFile.DropDownItems.Add(nmeProp)
		Me.nmeFile.DropDownItems.Add(nmeOffline)
		Me.nmeFile.DropDownItems.Add(nmeExit)
		Me.MenuStrip1.Items.Add(nmeEdit)
		Me.nmeEdit.DropDownItems.Add(nmeCopy)
		Me.nmeEdit.DropDownItems.Add(nmeSelAll)
		Me.nmeEdit.DropDownItems.Add(nmePaste)
		Me.MenuStrip1.Items.Add(nmeView)
		Me.nmeView.DropDownItems.Add(nmeTool)
		Me.nmeTool.DropDownItems.Add(nmeStan)
		Me.nmeView.DropDownItems.Add(nmeSource)
		Me.nmeView.DropDownItems.Add(nmeFull)
		Me.MenuStrip1.Items.Add(nmeFav)
		Me.nmeFav.DropDownItems.Add(nmeAddFav_000)
		Me.MenuStrip1.Items.Add(nmeHelp)
		Me.nmeHelp.DropDownItems.Add(nmeHelpT)
		Me.nmeHelp.DropDownItems.Add(nmeAbout)
		Me.Controls.Add(StatusBar1_Control)
		Me.Controls.Add(Toolbar1_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.Toolbar1, 0)
		Me.Controls.SetChildIndex(Me.Toolbar1_Control, 0)
		Me.Controls.SetChildIndex(Me.StatusBar1, 0)
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
