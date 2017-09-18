<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMainMDI
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
		Me.mnuEditItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuEditItem_000, mnuEditItem_001, mnuEditItem_002, mnuEditItem_003, mnuEditItem_005, mnuEditItem_006, mnuEditItem_008, mnuEditItem_009)
		Me.mnuWindowItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuWindowItem_000, mnuWindowItem_001, mnuWindowItem_002, mnuWindowItem_003)
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
	Public mnuEditItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuWindowItem As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileNew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuBar1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileSave As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAs As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileSaveAll As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuBar2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFilePrint As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFilePrintSetup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuBar3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_004 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditItem_005 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_006 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_007 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditItem_008 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_009 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindow As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowItem_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowItem_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuWindowItem_003 As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileNew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuBar1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileSave = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAs = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileSaveAll = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuBar2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFilePrint = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFilePrintSetup = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuBar3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_004 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditItem_005 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_006 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_007 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditItem_008 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_009 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindow = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowItem_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowItem_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuWindowItem_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
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
		' mnuBar1
		'
		Me.mnuBar1.Name = "mnuBar1"
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
		Me.mnuFileSaveAs.Caption = "Save &As"
		'
		' mnuFileSaveAll
		'
		Me.mnuFileSaveAll.Name = "mnuFileSaveAll"
		Me.mnuFileSaveAll.Caption = "Save All"
		'
		' mnuBar2
		'
		Me.mnuBar2.Name = "mnuBar2"
		'
		' mnuFilePrint
		'
		Me.mnuFilePrint.Name = "mnuFilePrint"
		Me.mnuFilePrint.Caption = "&Print..."
		'
		' mnuFilePrintSetup
		'
		Me.mnuFilePrintSetup.Name = "mnuFilePrintSetup"
		Me.mnuFilePrintSetup.Caption = "Print Set&up..."
		'
		' mnuBar3
		'
		Me.mnuBar3.Name = "mnuBar3"
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
		' mnuEditItem_000
		'
		Me.mnuEditItem_000.Name = "mnuEditItem_000"
		Me.mnuEditItem_000.Caption = "Cu&t"
		Me.mnuEditItem_000.Shortcut = Keys.Control Or Keys.X
		'
		' mnuEditItem_001
		'
		Me.mnuEditItem_001.Name = "mnuEditItem_001"
		Me.mnuEditItem_001.Caption = "&Copy"
		Me.mnuEditItem_001.Shortcut = Keys.Control Or Keys.C
		'
		' mnuEditItem_002
		'
		Me.mnuEditItem_002.Name = "mnuEditItem_002"
		Me.mnuEditItem_002.Caption = "&Paste"
		Me.mnuEditItem_002.Shortcut = Keys.Control Or Keys.V
		'
		' mnuEditItem_003
		'
		Me.mnuEditItem_003.Name = "mnuEditItem_003"
		Me.mnuEditItem_003.Caption = "De&lete"
		Me.mnuEditItem_003.Shortcut = Keys.Delete
		'
		' mnuEditItem_004
		'
		Me.mnuEditItem_004.Name = "mnuEditItem_004"
		'
		' mnuEditItem_005
		'
		Me.mnuEditItem_005.Name = "mnuEditItem_005"
		Me.mnuEditItem_005.Caption = "Select &All"
		Me.mnuEditItem_005.Shortcut = Keys.Control Or Keys.A
		'
		' mnuEditItem_006
		'
		Me.mnuEditItem_006.Name = "mnuEditItem_006"
		Me.mnuEditItem_006.Caption = "Time/&Date"
		Me.mnuEditItem_006.Shortcut = Keys.F5
		'
		' mnuEditItem_007
		'
		Me.mnuEditItem_007.Name = "mnuEditItem_007"
		'
		' mnuEditItem_008
		'
		Me.mnuEditItem_008.Name = "mnuEditItem_008"
		Me.mnuEditItem_008.Caption = "&Word Wrap"
		Me.mnuEditItem_008.Checked = True
		'
		' mnuEditItem_009
		'
		Me.mnuEditItem_009.Name = "mnuEditItem_009"
		Me.mnuEditItem_009.Caption = "Set &Font..."
		'
		' mnuWindow
		'
		Me.mnuWindow.Name = "mnuWindow"
		Me.mnuWindow.Caption = "&Window"
		'
		' mnuWindowItem_000
		'
		Me.mnuWindowItem_000.Name = "mnuWindowItem_000"
		Me.mnuWindowItem_000.Caption = "Tile &Horizontally"
		'
		' mnuWindowItem_001
		'
		Me.mnuWindowItem_001.Name = "mnuWindowItem_001"
		Me.mnuWindowItem_001.Caption = "Tile &Vertically"
		'
		' mnuWindowItem_002
		'
		Me.mnuWindowItem_002.Name = "mnuWindowItem_002"
		Me.mnuWindowItem_002.Caption = "&Cascade"
		'
		' mnuWindowItem_003
		'
		Me.mnuWindowItem_003.Name = "mnuWindowItem_003"
		Me.mnuWindowItem_003.Caption = "Arrange Icons"
		'
		' frmMainMDI
		'
		Me.Name = "frmMainMDI"
		Me.BackColor = FromOleColor6(CInt(&H8000000C))
		Me.Caption = "MDI Notepad"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 49)
		Me.ClientSize = New System.Drawing.Size(567, 357)

		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuFileNew)
		Me.mnuFile.DropDownItems.Add(mnuFileOpen)
		Me.mnuFile.DropDownItems.Add(mnuFileClose)
		Me.mnuFile.DropDownItems.Add(mnuBar1)
		Me.mnuFile.DropDownItems.Add(mnuFileSave)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAs)
		Me.mnuFile.DropDownItems.Add(mnuFileSaveAll)
		Me.mnuFile.DropDownItems.Add(mnuBar2)
		Me.mnuFile.DropDownItems.Add(mnuFilePrint)
		Me.mnuFile.DropDownItems.Add(mnuFilePrintSetup)
		Me.mnuFile.DropDownItems.Add(mnuBar3)
		Me.mnuFile.DropDownItems.Add(mnuFileExit)
		Me.MenuStrip1.Items.Add(mnuEdit)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_000)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_001)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_002)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_003)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_004)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_005)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_006)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_007)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_008)
		Me.mnuEdit.DropDownItems.Add(mnuEditItem_009)
		Me.MenuStrip1.Items.Add(mnuWindow)
		Me.mnuWindow.DropDownItems.Add(mnuWindowItem_000)
		Me.mnuWindow.DropDownItems.Add(mnuWindowItem_001)
		Me.mnuWindow.DropDownItems.Add(mnuWindowItem_002)
		Me.mnuWindow.DropDownItems.Add(mnuWindowItem_003)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
