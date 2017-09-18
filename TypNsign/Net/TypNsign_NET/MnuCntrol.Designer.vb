<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MnuCntrol
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
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents MnuOptions As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSetup As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuOnTop As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuOnTopOn As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuOnTopOff As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuLine1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuBckClr As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuFntClr As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuReset As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuClearTxt As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuLine3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuExit As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MnuCntrol))
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.MnuOptions = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSetup = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuOnTop = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuOnTopOn = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuOnTopOff = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuLine1 = New System.Windows.Forms.ToolStripSeparator()
		Me.MnuBckClr = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuFntClr = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuReset = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuClearTxt = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuLine3 = New System.Windows.Forms.ToolStripSeparator()
		Me.MnuExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		Me.CommonDialog1.Name6 = "CommonDialog1"
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(217, 17)
		Me.Label1.Location = New System.Drawing.Point(80, 48)
		Me.Label1.Caption = "This is for the menus on the main form"
		Me.Label1.TabIndex = 0
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' MnuOptions
		'
		Me.MnuOptions.Name = "MnuOptions"
		Me.MnuOptions.Caption = "options"
		'
		' mnuSetup
		'
		Me.mnuSetup.Name = "mnuSetup"
		Me.mnuSetup.Caption = "Setup"
		'
		' MnuOnTop
		'
		Me.MnuOnTop.Name = "MnuOnTop"
		Me.MnuOnTop.Caption = "Stay On Top"
		'
		' MnuOnTopOn
		'
		Me.MnuOnTopOn.Name = "MnuOnTopOn"
		Me.MnuOnTopOn.Caption = "On"
		'
		' MnuOnTopOff
		'
		Me.MnuOnTopOff.Name = "MnuOnTopOff"
		Me.MnuOnTopOff.Caption = "Off"
		Me.MnuOnTopOff.Checked = True
		'
		' mnuLine1
		'
		Me.mnuLine1.Name = "mnuLine1"
		'
		' MnuBckClr
		'
		Me.MnuBckClr.Name = "MnuBckClr"
		Me.MnuBckClr.Caption = "Background Color"
		'
		' MnuFntClr
		'
		Me.MnuFntClr.Name = "MnuFntClr"
		Me.MnuFntClr.Caption = "Font Color"
		'
		' MnuReset
		'
		Me.MnuReset.Name = "MnuReset"
		Me.MnuReset.Caption = "reset"
		'
		' MnuClearTxt
		'
		Me.MnuClearTxt.Name = "MnuClearTxt"
		Me.MnuClearTxt.Caption = "Clear Text"
		'
		' MnuLine3
		'
		Me.MnuLine3.Name = "MnuLine3"
		'
		' MnuExit
		'
		Me.MnuExit.Name = "MnuExit"
		Me.MnuExit.Caption = "Exit Program"
		'
		' MnuCntrol
		'
		Me.Name = "MnuCntrol"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "Form2"
		Me.Icon = Nothing
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(10, 48)
		Me.ClientSize = New System.Drawing.Size(312, 86)

		Me.Controls.Add(Label1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(MnuOptions)
		Me.MnuOptions.DropDownItems.Add(mnuSetup)
		Me.MnuOptions.DropDownItems.Add(MnuOnTop)
		Me.MnuOnTop.DropDownItems.Add(MnuOnTopOn)
		Me.MnuOnTop.DropDownItems.Add(MnuOnTopOff)
		Me.MnuOptions.DropDownItems.Add(mnuLine1)
		Me.MnuOptions.DropDownItems.Add(MnuBckClr)
		Me.MnuOptions.DropDownItems.Add(MnuFntClr)
		Me.MenuStrip1.Items.Add(MnuReset)
		Me.MnuReset.DropDownItems.Add(MnuClearTxt)
		Me.MnuReset.DropDownItems.Add(MnuLine3)
		Me.MnuReset.DropDownItems.Add(MnuExit)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
