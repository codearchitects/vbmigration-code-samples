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
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnufile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnunew As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuopt As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnutam As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuexit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnulevel1 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnulevel2 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnulevel3 As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnufile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnunew = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuopt = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnutam = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuexit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnulevel1 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnulevel2 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnulevel3 = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnufile
		'
		Me.mnufile.Name = "mnufile"
		Me.mnufile.Caption = "File"
		'
		' mnunew
		'
		Me.mnunew.Name = "mnunew"
		Me.mnunew.Caption = "&New"
		'
		' mnuopt
		'
		Me.mnuopt.Name = "mnuopt"
		Me.mnuopt.Caption = "&Options"
		'
		' mnutam
		'
		Me.mnutam.Name = "mnutam"
		'
		' mnuexit
		'
		Me.mnuexit.Name = "mnuexit"
		Me.mnuexit.Caption = "E&xit"
		'
		' mnulevel1
		'
		Me.mnulevel1.Name = "mnulevel1"
		Me.mnulevel1.Caption = "Level 1"
		'
		' mnulevel2
		'
		Me.mnulevel2.Name = "mnulevel2"
		Me.mnulevel2.Caption = "Level 2"
		Me.mnulevel2.Enabled = False
		'
		' mnulevel3
		'
		Me.mnulevel3.Name = "mnulevel3"
		Me.mnulevel3.Caption = "Level 3"
		Me.mnulevel3.Enabled = False
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "Caro (Da duoc cai tien tu sach Slide Show)"
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(11, 57)
		Me.ClientSize = New System.Drawing.Size(533, 484)

		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnufile)
		Me.mnufile.DropDownItems.Add(mnunew)
		Me.mnufile.DropDownItems.Add(mnuopt)
		Me.mnufile.DropDownItems.Add(mnutam)
		Me.mnufile.DropDownItems.Add(mnuexit)
		Me.MenuStrip1.Items.Add(mnulevel1)
		Me.MenuStrip1.Items.Add(mnulevel2)
		Me.MenuStrip1.Items.Add(mnulevel3)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
