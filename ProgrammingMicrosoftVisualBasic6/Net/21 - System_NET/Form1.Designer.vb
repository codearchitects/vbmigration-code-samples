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
		Me.chkLockKey = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)(chkLockKey_002, chkLockKey_001, chkLockKey_000)
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
	Public chkLockKey As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)
	Public WithEvents cmdMouseHide As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkClipMouse As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdMoveMouse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMouseInfo As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents fraMouse As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents lblMouse As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkLockKey_002 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkLockKey_001 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkLockKey_000 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents lblKeyboard As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cmdWindowsVersion As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdComputerName As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUserName As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdTempDir As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSystemDir As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdWindowsDir As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdMouseHide = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkClipMouse = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdMoveMouse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMouseInfo = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraMouse = New CodeArchitects.VB6Library.VB6Frame()
		Me.lblMouse = New CodeArchitects.VB6Library.VB6Label()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkLockKey_002 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkLockKey_001 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkLockKey_000 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.lblKeyboard = New CodeArchitects.VB6Library.VB6Label()
		Me.cmdWindowsVersion = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdComputerName = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUserName = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdTempDir = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSystemDir = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdWindowsDir = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraMouse.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdMouseHide
		'
		Me.cmdMouseHide.Name = "cmdMouseHide"
		Me.cmdMouseHide.Size = New System.Drawing.Size(105, 25)
		Me.cmdMouseHide.Location = New System.Drawing.Point(408, 8)
		Me.cmdMouseHide.Caption = "Mouse &Hide"
		Me.cmdMouseHide.TabIndex = 16
		'
		' chkClipMouse
		'
		Me.chkClipMouse.Name = "chkClipMouse"
		Me.chkClipMouse.Size = New System.Drawing.Size(105, 41)
		Me.chkClipMouse.Location = New System.Drawing.Point(408, 56)
		Me.chkClipMouse.Caption = "Clip mouse to this button"
		Me.chkClipMouse.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.chkClipMouse.TabIndex = 15
		'
		' cmdMoveMouse
		'
		Me.cmdMoveMouse.Name = "cmdMoveMouse"
		Me.cmdMoveMouse.Size = New System.Drawing.Size(145, 25)
		Me.cmdMoveMouse.Location = New System.Drawing.Point(256, 8)
		Me.cmdMoveMouse.Caption = "Move Mouse to Frame"
		Me.cmdMoveMouse.TabIndex = 14
		'
		' cmdMouseInfo
		'
		Me.cmdMouseInfo.Name = "cmdMouseInfo"
		Me.cmdMouseInfo.Size = New System.Drawing.Size(105, 25)
		Me.cmdMouseInfo.Location = New System.Drawing.Point(144, 8)
		Me.cmdMouseInfo.Caption = "Mouse Info"
		Me.cmdMouseInfo.TabIndex = 13
		'
		' fraMouse
		'
		Me.fraMouse.Name = "fraMouse"
		Me.fraMouse.Size = New System.Drawing.Size(257, 65)
		Me.fraMouse.Location = New System.Drawing.Point(144, 40)
		Me.fraMouse.Caption = "Mouse"
		Me.fraMouse.TabIndex = 11
		'
		' lblMouse
		'
		Me.lblMouse.Name = "lblMouse"
		Me.lblMouse.Size = New System.Drawing.Size(241, 17)
		Me.lblMouse.Location = New System.Drawing.Point(8, 24)
		Me.lblMouse.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblMouse.TabIndex = 12
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Interval = 200
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(369, 73)
		Me.Frame1.Location = New System.Drawing.Point(144, 120)
		Me.Frame1.Caption = "Keyboard "
		Me.Frame1.TabIndex = 6
		'
		' chkLockKey_002
		'
		Me.chkLockKey_002.Name = "chkLockKey_002"
		Me.chkLockKey_002.Size = New System.Drawing.Size(89, 17)
		Me.chkLockKey_002.Location = New System.Drawing.Point(248, 16)
		Me.chkLockKey_002.Caption = "ScrollLock"
		Me.chkLockKey_002.TabIndex = 10
		'
		' chkLockKey_001
		'
		Me.chkLockKey_001.Name = "chkLockKey_001"
		Me.chkLockKey_001.Size = New System.Drawing.Size(89, 17)
		Me.chkLockKey_001.Location = New System.Drawing.Point(136, 16)
		Me.chkLockKey_001.Caption = "NumLock"
		Me.chkLockKey_001.TabIndex = 9
		'
		' chkLockKey_000
		'
		Me.chkLockKey_000.Name = "chkLockKey_000"
		Me.chkLockKey_000.Size = New System.Drawing.Size(89, 17)
		Me.chkLockKey_000.Location = New System.Drawing.Point(16, 16)
		Me.chkLockKey_000.Caption = "CapsLock"
		Me.chkLockKey_000.TabIndex = 8
		'
		' lblKeyboard
		'
		Me.lblKeyboard.Name = "lblKeyboard"
		Me.lblKeyboard.Size = New System.Drawing.Size(321, 17)
		Me.lblKeyboard.Location = New System.Drawing.Point(8, 40)
		Me.lblKeyboard.TabIndex = 7
		'
		' cmdWindowsVersion
		'
		Me.cmdWindowsVersion.Name = "cmdWindowsVersion"
		Me.cmdWindowsVersion.Size = New System.Drawing.Size(121, 25)
		Me.cmdWindowsVersion.Location = New System.Drawing.Point(8, 168)
		Me.cmdWindowsVersion.Caption = "Windows Version"
		Me.cmdWindowsVersion.TabIndex = 5
		'
		' cmdComputerName
		'
		Me.cmdComputerName.Name = "cmdComputerName"
		Me.cmdComputerName.Size = New System.Drawing.Size(121, 25)
		Me.cmdComputerName.Location = New System.Drawing.Point(8, 136)
		Me.cmdComputerName.Caption = "Computer Name"
		Me.cmdComputerName.TabIndex = 4
		'
		' cmdUserName
		'
		Me.cmdUserName.Name = "cmdUserName"
		Me.cmdUserName.Size = New System.Drawing.Size(121, 25)
		Me.cmdUserName.Location = New System.Drawing.Point(8, 104)
		Me.cmdUserName.Caption = "User Name"
		Me.cmdUserName.TabIndex = 3
		'
		' cmdTempDir
		'
		Me.cmdTempDir.Name = "cmdTempDir"
		Me.cmdTempDir.Size = New System.Drawing.Size(121, 25)
		Me.cmdTempDir.Location = New System.Drawing.Point(8, 72)
		Me.cmdTempDir.Caption = "Temporary Dir"
		Me.cmdTempDir.TabIndex = 2
		'
		' cmdSystemDir
		'
		Me.cmdSystemDir.Name = "cmdSystemDir"
		Me.cmdSystemDir.Size = New System.Drawing.Size(121, 25)
		Me.cmdSystemDir.Location = New System.Drawing.Point(8, 40)
		Me.cmdSystemDir.Caption = "System Dir"
		Me.cmdSystemDir.TabIndex = 1
		'
		' cmdWindowsDir
		'
		Me.cmdWindowsDir.Name = "cmdWindowsDir"
		Me.cmdWindowsDir.Size = New System.Drawing.Size(121, 25)
		Me.cmdWindowsDir.Location = New System.Drawing.Point(8, 8)
		Me.cmdWindowsDir.Caption = "Windows Dir"
		Me.cmdWindowsDir.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "System, Keyboard and Mouse Functions"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(535, 204)

		Me.Controls.Add(cmdMouseHide)
		Me.Controls.Add(chkClipMouse)
		Me.Controls.Add(cmdMoveMouse)
		Me.Controls.Add(cmdMouseInfo)
		Me.Controls.Add(fraMouse)
		Me.fraMouse.Controls.Add(lblMouse)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(chkLockKey_002)
		Me.Frame1.Controls.Add(chkLockKey_001)
		Me.Frame1.Controls.Add(chkLockKey_000)
		Me.Frame1.Controls.Add(lblKeyboard)
		Me.Controls.Add(cmdWindowsVersion)
		Me.Controls.Add(cmdComputerName)
		Me.Controls.Add(cmdUserName)
		Me.Controls.Add(cmdTempDir)
		Me.Controls.Add(cmdSystemDir)
		Me.Controls.Add(cmdWindowsDir)
		Me.fraMouse.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
