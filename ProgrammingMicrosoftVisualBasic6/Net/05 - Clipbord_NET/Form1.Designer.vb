<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
		Me.mnuEditItem = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuEditItem_000, mnuEditItem_002, mnuEditItem_003, mnuEditItem_004, mnuEditItem_006, mnuEditItem_007)
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
	Public WithEvents RichTextBox1 As CodeArchitects.VB6Library.VB6RichTextBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuFileExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEdit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_001 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditItem_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_004 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_005 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEditItem_006 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuEditItem_007 As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.RichTextBox1 = New CodeArchitects.VB6Library.VB6RichTextBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuFileExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEdit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_001 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditItem_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_004 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_005 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEditItem_006 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuEditItem_007 = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' RichTextBox1
		'
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(353, 153)
		Me.RichTextBox1.Location = New System.Drawing.Point(8, 176)
		Me.RichTextBox1.TabIndex = 2
		Me.RichTextBox1.Enabled = True
		Me.RichTextBox1.ScrollBars = CodeArchitects.VB6Library.RichTextLib.ScrollBarsConstants.rtfBoth
		Me.RichTextBox1.TextRTF = "{\rtf1\ansi\ansicpg1252\deff0\deflang1040{\fonttbl{\f0\fswiss MS Sans Serif;}}" & ControlChars.CrLf & "\viewkind4\uc1\pard\f0\fs17 RichTextBox1" & ControlChars.CrLf & "\par }" & ControlChars.CrLf
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(217, 305)
		Me.Picture1.Location = New System.Drawing.Point(368, 24)
		Me.Picture1.TabIndex = 1
		Me.Picture1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(353, 145)
		Me.Text1.Location = New System.Drawing.Point(8, 24)
		Me.Text1.MultiLine = -1
		Me.Text1.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbVertical
		Me.Text1.TabIndex = 0
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
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
		Me.mnuEditItem_000.Caption = "&Undo"
		Me.mnuEditItem_000.Shortcut = Keys.Control Or Keys.Z
		'
		' mnuEditItem_001
		'
		Me.mnuEditItem_001.Name = "mnuEditItem_001"
		'
		' mnuEditItem_002
		'
		Me.mnuEditItem_002.Name = "mnuEditItem_002"
		Me.mnuEditItem_002.Caption = "Cu&t"
		Me.mnuEditItem_002.Shortcut = Keys.Control Or Keys.X
		'
		' mnuEditItem_003
		'
		Me.mnuEditItem_003.Name = "mnuEditItem_003"
		Me.mnuEditItem_003.Caption = "&Copy"
		Me.mnuEditItem_003.Shortcut = Keys.Control Or Keys.C
		'
		' mnuEditItem_004
		'
		Me.mnuEditItem_004.Name = "mnuEditItem_004"
		Me.mnuEditItem_004.Caption = "&Paste"
		Me.mnuEditItem_004.Shortcut = Keys.Control Or Keys.V
		'
		' mnuEditItem_005
		'
		Me.mnuEditItem_005.Name = "mnuEditItem_005"
		'
		' mnuEditItem_006
		'
		Me.mnuEditItem_006.Name = "mnuEditItem_006"
		Me.mnuEditItem_006.Caption = "C&lear"
		Me.mnuEditItem_006.Shortcut = Keys.Delete
		'
		' mnuEditItem_007
		'
		Me.mnuEditItem_007.Name = "mnuEditItem_007"
		Me.mnuEditItem_007.Caption = "Select &All"
		Me.mnuEditItem_007.Shortcut = Keys.Control Or Keys.A
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Clipboard Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 57)
		Me.ClientSize = New System.Drawing.Size(592, 338)

		Me.Controls.Add(RichTextBox1)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
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
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
