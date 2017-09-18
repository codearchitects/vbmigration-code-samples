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
	Public WithEvents cmdClear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstEvents As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdPower As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdWindows As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdScreen As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents SysInfo1 As CodeArchitects.VB6Library.VB6SysInfo
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdClear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstEvents = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdPower = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdWindows = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdScreen = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.SysInfo1 = New CodeArchitects.VB6Library.VB6SysInfo()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdClear
		'
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.Size = New System.Drawing.Size(89, 33)
		Me.cmdClear.Location = New System.Drawing.Point(288, 176)
		Me.cmdClear.Caption = "&Clear"
		Me.cmdClear.TabIndex = 6
		'
		' lstEvents
		'
		Me.lstEvents.Name = "lstEvents"
		Me.lstEvents.Size = New System.Drawing.Size(265, 84)
		Me.lstEvents.Location = New System.Drawing.Point(8, 176)
		Me.lstEvents.TabIndex = 5
		'
		' cmdPower
		'
		Me.cmdPower.Name = "cmdPower"
		Me.cmdPower.Size = New System.Drawing.Size(89, 33)
		Me.cmdPower.Location = New System.Drawing.Point(288, 72)
		Me.cmdPower.Caption = "&Power"
		Me.cmdPower.TabIndex = 3
		'
		' cmdWindows
		'
		Me.cmdWindows.Name = "cmdWindows"
		Me.cmdWindows.Size = New System.Drawing.Size(89, 33)
		Me.cmdWindows.Location = New System.Drawing.Point(288, 40)
		Me.cmdWindows.Caption = "&Windows"
		Me.cmdWindows.TabIndex = 2
		'
		' cmdScreen
		'
		Me.cmdScreen.Name = "cmdScreen"
		Me.cmdScreen.Size = New System.Drawing.Size(89, 33)
		Me.cmdScreen.Location = New System.Drawing.Point(288, 8)
		Me.cmdScreen.Caption = "&Screen"
		Me.cmdScreen.TabIndex = 1
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(265, 129)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.AutoRedraw = True
		Me.Picture1.TabIndex = 0
		Me.Picture1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' SysInfo1
		'
		Me.SysInfo1.Name = "SysInfo1"
		Me.SysInfo1.ParentForm = Me
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(193, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 152)
		Me.Label1.Caption = "Events:"
		Me.Label1.TabIndex = 4
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "SysInfo Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(383, 271)

		Me.Controls.Add(cmdClear)
		Me.Controls.Add(lstEvents)
		Me.Controls.Add(cmdPower)
		Me.Controls.Add(cmdWindows)
		Me.Controls.Add(cmdScreen)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Label1)
		CType(Me.SysInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
