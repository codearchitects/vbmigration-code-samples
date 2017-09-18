<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_Main
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
	Public WithEvents sbr_PhoneBook As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents lvw_PhoneBook As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents tab_Main As CodeArchitects.VB6Library.VB6TabStrip
	Public WithEvents tab_Main_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage4 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage5 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage6 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage7 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage8 As System.Windows.Forms.TabPage
	Public WithEvents tab_Main_TabPage9 As System.Windows.Forms.TabPage
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents pdm_File As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_ShowPhoneBook As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Separator01 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents pdi_AddNewPerson As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_EditAPerson As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_FindAPerson As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Separator02 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents pdi_SystemTrayIcon As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Separator03 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents pdi_Exit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdm_Tools As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_PrintPreview As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_Print As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdm_Help As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents pdi_About As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sbr_PhoneBook_Control As System.Windows.Forms.StatusStrip
	Public WithEvents sbr_PhoneBook_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents lvw_PhoneBook_Control As System.Windows.Forms.ListView
	Public WithEvents lvw_PhoneBook_Column1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_PhoneBook_Column2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_PhoneBook_Column3 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_PhoneBook_Column4 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvw_PhoneBook_Column5 As System.Windows.Forms.ColumnHeader

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_Main))
		Me.sbr_PhoneBook = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.lvw_PhoneBook = New CodeArchitects.VB6Library.VB6ListView()
		Me.tab_Main = New CodeArchitects.VB6Library.VB6TabStrip()
		Me.tab_Main_TabPage1 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage2 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage3 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage4 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage5 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage6 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage7 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage8 = New System.Windows.Forms.TabPage()
		Me.tab_Main_TabPage9 = New System.Windows.Forms.TabPage()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.pdm_File = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_ShowPhoneBook = New CodeArchitects.VB6Library.VB6Menu()
		Me.Separator01 = New System.Windows.Forms.ToolStripSeparator()
		Me.pdi_AddNewPerson = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_EditAPerson = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_FindAPerson = New CodeArchitects.VB6Library.VB6Menu()
		Me.Separator02 = New System.Windows.Forms.ToolStripSeparator()
		Me.pdi_SystemTrayIcon = New CodeArchitects.VB6Library.VB6Menu()
		Me.Separator03 = New System.Windows.Forms.ToolStripSeparator()
		Me.pdi_Exit = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdm_Tools = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_PrintPreview = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_Print = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdm_Help = New CodeArchitects.VB6Library.VB6Menu()
		Me.pdi_About = New CodeArchitects.VB6Library.VB6Menu()
		Me.sbr_PhoneBook_Control = New System.Windows.Forms.StatusStrip()
		Me.sbr_PhoneBook_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lvw_PhoneBook_Control = New System.Windows.Forms.ListView()
		Me.lvw_PhoneBook_Column1 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_PhoneBook_Column2 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_PhoneBook_Column3 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_PhoneBook_Column4 = New System.Windows.Forms.ColumnHeader()
		Me.lvw_PhoneBook_Column5 = New System.Windows.Forms.ColumnHeader()
		Me.tab_Main.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.sbr_PhoneBook, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lvw_PhoneBook, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tab_Main, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' sbr_PhoneBook
		'
		Me.sbr_PhoneBook.Name = "sbr_PhoneBook"
		Me.sbr_PhoneBook.Location = New System.Drawing.Point(0, 245)
		Me.sbr_PhoneBook.Style = CodeArchitects.VB6Library.MSComctlLib.SbarStyleConstants.sbrSimple
		Me.sbr_PhoneBook.SimpleText = "Welcome to Phone Book Version 2.0"
		Me.sbr_PhoneBook.Size = New System.Drawing.Size(2, 2)
		Me.sbr_PhoneBook.StatusStrip = Me.sbr_PhoneBook_Control
		Me.sbr_PhoneBook_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbr_PhoneBook_Panel1})
		'
		' lvw_PhoneBook
		'
		Me.lvw_PhoneBook.Name = "lvw_PhoneBook"
		Me.lvw_PhoneBook.Location = New System.Drawing.Point(31, 71)
		Me.lvw_PhoneBook.Size = New System.Drawing.Size(2, 2)
		Me.lvw_PhoneBook.ListView = Me.lvw_PhoneBook_Control
		Me.lvw_PhoneBook_Control.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvw_PhoneBook_Column1, Me.lvw_PhoneBook_Column2, Me.lvw_PhoneBook_Column3, Me.lvw_PhoneBook_Column4, Me.lvw_PhoneBook_Column5})
		'
		' tab_Main
		'
		Me.tab_Main.Name = "tab_Main"
		Me.tab_Main.Size = New System.Drawing.Size(393, 185)
		Me.tab_Main.Location = New System.Drawing.Point(24, 41)
		Me.tab_Main.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tab_Main.TabIndex = 0
		Me.tab_Main.MultiLine = True
		Me.tab_Main.MultiLine = False
		'
		' tab_Main_TabPage1
		'
		Me.tab_Main_TabPage1.Name = "tab_Main_TabPage1"
		Me.tab_Main_TabPage1.Text = "A  B  C"
		Me.tab_Main_TabPage1.Width = 54
		'
		' tab_Main_TabPage2
		'
		Me.tab_Main_TabPage2.Name = "tab_Main_TabPage2"
		Me.tab_Main_TabPage2.Text = "D E F"
		Me.tab_Main_TabPage2.Width = 54
		'
		' tab_Main_TabPage3
		'
		Me.tab_Main_TabPage3.Name = "tab_Main_TabPage3"
		Me.tab_Main_TabPage3.Text = "G H I"
		Me.tab_Main_TabPage3.Width = 54
		'
		' tab_Main_TabPage4
		'
		Me.tab_Main_TabPage4.Name = "tab_Main_TabPage4"
		Me.tab_Main_TabPage4.Text = "J K L"
		Me.tab_Main_TabPage4.Width = 54
		'
		' tab_Main_TabPage5
		'
		Me.tab_Main_TabPage5.Name = "tab_Main_TabPage5"
		Me.tab_Main_TabPage5.Text = "M N O"
		Me.tab_Main_TabPage5.Width = 54
		'
		' tab_Main_TabPage6
		'
		Me.tab_Main_TabPage6.Name = "tab_Main_TabPage6"
		Me.tab_Main_TabPage6.Text = "P Q R"
		Me.tab_Main_TabPage6.Width = 54
		'
		' tab_Main_TabPage7
		'
		Me.tab_Main_TabPage7.Name = "tab_Main_TabPage7"
		Me.tab_Main_TabPage7.Text = "S T U"
		Me.tab_Main_TabPage7.Width = 54
		'
		' tab_Main_TabPage8
		'
		Me.tab_Main_TabPage8.Name = "tab_Main_TabPage8"
		Me.tab_Main_TabPage8.Text = "V W X"
		Me.tab_Main_TabPage8.Width = 54
		'
		' tab_Main_TabPage9
		'
		Me.tab_Main_TabPage9.Name = "tab_Main_TabPage9"
		Me.tab_Main_TabPage9.Text = "Y Z"
		Me.tab_Main_TabPage9.Width = 54
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' pdm_File
		'
		Me.pdm_File.Name = "pdm_File"
		Me.pdm_File.Caption = "&File"
		'
		' pdi_ShowPhoneBook
		'
		Me.pdi_ShowPhoneBook.Name = "pdi_ShowPhoneBook"
		Me.pdi_ShowPhoneBook.Caption = "&Show Phone Book"
		Me.pdi_ShowPhoneBook.Shortcut = Keys.Control Or Keys.S
		Me.pdi_ShowPhoneBook.Visible = False
		'
		' Separator01
		'
		Me.Separator01.Name = "Separator01"
		'
		' pdi_AddNewPerson
		'
		Me.pdi_AddNewPerson.Name = "pdi_AddNewPerson"
		Me.pdi_AddNewPerson.Caption = "&Add New Person"
		Me.pdi_AddNewPerson.Shortcut = Keys.Control Or Keys.A
		'
		' pdi_EditAPerson
		'
		Me.pdi_EditAPerson.Name = "pdi_EditAPerson"
		Me.pdi_EditAPerson.Caption = "&Edit A Person"
		Me.pdi_EditAPerson.Shortcut = Keys.Control Or Keys.E
		'
		' pdi_FindAPerson
		'
		Me.pdi_FindAPerson.Name = "pdi_FindAPerson"
		Me.pdi_FindAPerson.Caption = "&Find A Person"
		Me.pdi_FindAPerson.Shortcut = Keys.Control Or Keys.F
		'
		' Separator02
		'
		Me.Separator02.Name = "Separator02"
		'
		' pdi_SystemTrayIcon
		'
		Me.pdi_SystemTrayIcon.Name = "pdi_SystemTrayIcon"
		Me.pdi_SystemTrayIcon.Caption = "System&Tray Icon"
		Me.pdi_SystemTrayIcon.Shortcut = Keys.Control Or Keys.T
		'
		' Separator03
		'
		Me.Separator03.Name = "Separator03"
		'
		' pdi_Exit
		'
		Me.pdi_Exit.Name = "pdi_Exit"
		Me.pdi_Exit.Caption = "E&xit"
		Me.pdi_Exit.Shortcut = Keys.Control Or Keys.X
		'
		' pdm_Tools
		'
		Me.pdm_Tools.Name = "pdm_Tools"
		Me.pdm_Tools.Caption = "&Tools"
		'
		' pdi_PrintPreview
		'
		Me.pdi_PrintPreview.Name = "pdi_PrintPreview"
		Me.pdi_PrintPreview.Caption = "Print Pre&view"
		Me.pdi_PrintPreview.Shortcut = Keys.Control Or Keys.V
		'
		' pdi_Print
		'
		Me.pdi_Print.Name = "pdi_Print"
		Me.pdi_Print.Caption = "&Print..."
		Me.pdi_Print.Shortcut = Keys.Control Or Keys.P
		'
		' pdm_Help
		'
		Me.pdm_Help.Name = "pdm_Help"
		Me.pdm_Help.Caption = "&Help"
		'
		' pdi_About
		'
		Me.pdi_About.Name = "pdi_About"
		Me.pdi_About.Caption = "Abo&ut Phone Book"
		'
		' sbr_PhoneBook_Control
		'
		Me.sbr_PhoneBook_Control.Name = "sbr_PhoneBook_Control"
		Me.sbr_PhoneBook_Control.Size = New System.Drawing.Size(444, 25)
		Me.sbr_PhoneBook_Control.Location = New System.Drawing.Point(0, 245)
		Me.sbr_PhoneBook_Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.sbr_PhoneBook_Control.TabIndex = 2
		Me.sbr_PhoneBook_Control.ShowItemToolTips = True
		Me.sbr_PhoneBook_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' sbr_PhoneBook_Panel1
		'
		Me.sbr_PhoneBook_Panel1.Name = "sbr_PhoneBook_Panel1"
		Me.sbr_PhoneBook_Panel1.AutoSize = False
		Me.sbr_PhoneBook_Panel1.Size = New System.Drawing.Size(98, 14)
		Me.sbr_PhoneBook_Panel1.DoubleClickEnabled = True
		Me.sbr_PhoneBook_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.sbr_PhoneBook_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.sbr_PhoneBook_Panel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sbr_PhoneBook_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' lvw_PhoneBook_Control
		'
		Me.lvw_PhoneBook_Control.Name = "lvw_PhoneBook_Control"
		Me.lvw_PhoneBook_Control.Size = New System.Drawing.Size(377, 145)
		Me.lvw_PhoneBook_Control.Location = New System.Drawing.Point(31, 71)
		Me.lvw_PhoneBook_Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvw_PhoneBook_Control.ShowItemToolTips = True
		Me.lvw_PhoneBook_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.lvw_PhoneBook_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.lvw_PhoneBook_Control.TabIndex = 1
		Me.lvw_PhoneBook_Control.FullRowSelect = True
		Me.lvw_PhoneBook_Control.GridLines = True
		Me.lvw_PhoneBook_Control.HideSelection = True
		Me.lvw_PhoneBook_Control.LabelWrap = True
		Me.lvw_PhoneBook_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.lvw_PhoneBook_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvw_PhoneBook_Control.LabelEdit = False
		Me.lvw_PhoneBook_Control.MultiSelect = False
		Me.lvw_PhoneBook_Control.View = System.Windows.Forms.View.Details
		Me.lvw_PhoneBook_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.lvw_PhoneBook_Control.BackgroundImageTiled = False
		'
		' lvw_PhoneBook_Column1
		'
		Me.lvw_PhoneBook_Column1.Name = "lvw_PhoneBook_Column1"
		Me.lvw_PhoneBook_Column1.Text = "First Name"
		Me.lvw_PhoneBook_Column1.Width = 96
		'
		' lvw_PhoneBook_Column2
		'
		Me.lvw_PhoneBook_Column2.Name = "lvw_PhoneBook_Column2"
		Me.lvw_PhoneBook_Column2.Text = "Last Name"
		Me.lvw_PhoneBook_Column2.Width = 117
		'
		' lvw_PhoneBook_Column3
		'
		Me.lvw_PhoneBook_Column3.Name = "lvw_PhoneBook_Column3"
		Me.lvw_PhoneBook_Column3.Text = "Telephone Number"
		Me.lvw_PhoneBook_Column3.Width = 233
		'
		' lvw_PhoneBook_Column4
		'
		Me.lvw_PhoneBook_Column4.Name = "lvw_PhoneBook_Column4"
		Me.lvw_PhoneBook_Column4.Text = "EMail"
		Me.lvw_PhoneBook_Column4.Width = 133
		'
		' lvw_PhoneBook_Column5
		'
		Me.lvw_PhoneBook_Column5.Name = "lvw_PhoneBook_Column5"
		Me.lvw_PhoneBook_Column5.Text = "Address"
		Me.lvw_PhoneBook_Column5.Width = 167
		'
		' frm_Main
		'
		Me.Name = "frm_Main"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "Phone Book"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(10, 29)
		Me.ClientSize = New System.Drawing.Size(444, 270)

		Me.Controls.Add(sbr_PhoneBook)
		Me.Controls.Add(lvw_PhoneBook)
		Me.Controls.Add(tab_Main)
		Me.tab_Main.Controls.Add(tab_Main_TabPage1)
		Me.tab_Main.Controls.Add(tab_Main_TabPage2)
		Me.tab_Main.Controls.Add(tab_Main_TabPage3)
		Me.tab_Main.Controls.Add(tab_Main_TabPage4)
		Me.tab_Main.Controls.Add(tab_Main_TabPage5)
		Me.tab_Main.Controls.Add(tab_Main_TabPage6)
		Me.tab_Main.Controls.Add(tab_Main_TabPage7)
		Me.tab_Main.Controls.Add(tab_Main_TabPage8)
		Me.tab_Main.Controls.Add(tab_Main_TabPage9)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(pdm_File)
		Me.pdm_File.DropDownItems.Add(pdi_ShowPhoneBook)
		Me.pdm_File.DropDownItems.Add(Separator01)
		Me.pdm_File.DropDownItems.Add(pdi_AddNewPerson)
		Me.pdm_File.DropDownItems.Add(pdi_EditAPerson)
		Me.pdm_File.DropDownItems.Add(pdi_FindAPerson)
		Me.pdm_File.DropDownItems.Add(Separator02)
		Me.pdm_File.DropDownItems.Add(pdi_SystemTrayIcon)
		Me.pdm_File.DropDownItems.Add(Separator03)
		Me.pdm_File.DropDownItems.Add(pdi_Exit)
		Me.MenuStrip1.Items.Add(pdm_Tools)
		Me.pdm_Tools.DropDownItems.Add(pdi_PrintPreview)
		Me.pdm_Tools.DropDownItems.Add(pdi_Print)
		Me.MenuStrip1.Items.Add(pdm_Help)
		Me.pdm_Help.DropDownItems.Add(pdi_About)
		Me.Controls.Add(sbr_PhoneBook_Control)
		Me.Controls.Add(lvw_PhoneBook_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.sbr_PhoneBook, 0)
		Me.Controls.SetChildIndex(Me.lvw_PhoneBook_Control, 0)
		CType(Me.sbr_PhoneBook, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lvw_PhoneBook, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tab_Main, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tab_Main.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
