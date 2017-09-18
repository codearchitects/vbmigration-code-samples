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
		Me.optWait = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optWait_002, optWait_001, optWait_000)
		Me.optContents = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optContents_001, optContents_000)
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
	Public optWait As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public optContents As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents optWait_002 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optWait_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optWait_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents txtFilename As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdBrowse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents optContents_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optContents_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents chkMaximized As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents cmdNotepad As CodeArchitects.VB6Library.VB6CommandButton

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.optWait_002 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optWait_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optWait_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.txtFilename = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdBrowse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.optContents_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optContents_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.chkMaximized = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.cmdNotepad = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(377, 105)
		Me.Frame2.Location = New System.Drawing.Point(8, 144)
		Me.Frame2.Caption = "Wait for termination "
		Me.Frame2.TabIndex = 7
		'
		' optWait_002
		'
		Me.optWait_002.Name = "optWait_002"
		Me.optWait_002.Size = New System.Drawing.Size(305, 17)
		Me.optWait_002.Location = New System.Drawing.Point(24, 72)
		Me.optWait_002.Caption = "&Wait until Notepad ends"
		Me.optWait_002.TabIndex = 10
		'
		' optWait_001
		'
		Me.optWait_001.Name = "optWait_001"
		Me.optWait_001.Size = New System.Drawing.Size(305, 17)
		Me.optWait_001.Location = New System.Drawing.Point(24, 48)
		Me.optWait_001.Caption = "&Signal when Notepad ends"
		Me.optWait_001.TabIndex = 9
		'
		' optWait_000
		'
		Me.optWait_000.Name = "optWait_000"
		Me.optWait_000.Size = New System.Drawing.Size(305, 17)
		Me.optWait_000.Location = New System.Drawing.Point(24, 24)
		Me.optWait_000.Caption = "&Don't wait"
		Me.optWait_000.TabIndex = 8
		Me.optWait_000.Value = True
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(377, 121)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Caption = "Contents"
		Me.Frame1.TabIndex = 2
		'
		' txtFilename
		'
		Me.txtFilename.Name = "txtFilename"
		Me.txtFilename.Size = New System.Drawing.Size(297, 25)
		Me.txtFilename.Location = New System.Drawing.Point(24, 72)
		Me.txtFilename.TabIndex = 6
		'
		' cmdBrowse
		'
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.cmdBrowse.Size = New System.Drawing.Size(33, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(320, 72)
		Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBrowse.Caption = "..."
		Me.cmdBrowse.TabIndex = 5
		'
		' optContents_001
		'
		Me.optContents_001.Name = "optContents_001"
		Me.optContents_001.Size = New System.Drawing.Size(241, 17)
		Me.optContents_001.Location = New System.Drawing.Point(24, 48)
		Me.optContents_001.Caption = "This &File"
		Me.optContents_001.TabIndex = 4
		'
		' optContents_000
		'
		Me.optContents_000.Name = "optContents_000"
		Me.optContents_000.Size = New System.Drawing.Size(241, 17)
		Me.optContents_000.Location = New System.Drawing.Point(24, 24)
		Me.optContents_000.Caption = "&Clipboard"
		Me.optContents_000.TabIndex = 3
		Me.optContents_000.Value = True
		'
		' chkMaximized
		'
		Me.chkMaximized.Name = "chkMaximized"
		Me.chkMaximized.Size = New System.Drawing.Size(97, 17)
		Me.chkMaximized.Location = New System.Drawing.Point(400, 72)
		Me.chkMaximized.Caption = "&Maximized"
		Me.chkMaximized.TabIndex = 1
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' cmdNotepad
		'
		Me.cmdNotepad.Name = "cmdNotepad"
		Me.cmdNotepad.Size = New System.Drawing.Size(113, 41)
		Me.cmdNotepad.Location = New System.Drawing.Point(400, 16)
		Me.cmdNotepad.Caption = "Run &Notepad"
		Me.cmdNotepad.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Shell Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(529, 269)

		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(optWait_002)
		Me.Frame2.Controls.Add(optWait_001)
		Me.Frame2.Controls.Add(optWait_000)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(txtFilename)
		Me.Frame1.Controls.Add(cmdBrowse)
		Me.Frame1.Controls.Add(optContents_001)
		Me.Frame1.Controls.Add(optContents_000)
		Me.Controls.Add(chkMaximized)
		Me.Controls.Add(cmdNotepad)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
