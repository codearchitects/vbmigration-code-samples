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
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkProgress As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkConfirm As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents picStatus As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents txtExclude As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lstFiles As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents txtDestPath As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdCopy As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkSystem As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkHidden As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdParse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFilespec As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkProgress = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkConfirm = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.picStatus = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.txtExclude = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lstFiles = New CodeArchitects.VB6Library.VB6ListBox()
		Me.txtDestPath = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdCopy = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkSystem = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkHidden = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdParse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFilespec = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(89, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(16, 280)
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.TabIndex = 17
		'
		' cmdMove
		'
		Me.cmdMove.Name = "cmdMove"
		Me.cmdMove.Size = New System.Drawing.Size(89, 25)
		Me.cmdMove.Location = New System.Drawing.Point(16, 248)
		Me.cmdMove.Caption = "&Move"
		Me.cmdMove.TabIndex = 16
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(393, 57)
		Me.Frame2.Location = New System.Drawing.Point(264, 136)
		Me.Frame2.Caption = "Options "
		Me.Frame2.TabIndex = 13
		'
		' chkProgress
		'
		Me.chkProgress.Name = "chkProgress"
		Me.chkProgress.Size = New System.Drawing.Size(185, 17)
		Me.chkProgress.Location = New System.Drawing.Point(176, 24)
		Me.chkProgress.Caption = "Show &Progress Bar"
		Me.chkProgress.TabIndex = 15
		Me.chkProgress.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' chkConfirm
		'
		Me.chkConfirm.Name = "chkConfirm"
		Me.chkConfirm.Size = New System.Drawing.Size(137, 17)
		Me.chkConfirm.Location = New System.Drawing.Point(16, 24)
		Me.chkConfirm.Caption = "C&onfirm Each File"
		Me.chkConfirm.TabIndex = 14
		Me.chkConfirm.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' picStatus
		'
		Me.picStatus.Name = "picStatus"
		Me.picStatus.Size = New System.Drawing.Size(677, 25)
		Me.picStatus.Location = New System.Drawing.Point(0, 360)
		Me.picStatus.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.picStatus.AutoRedraw = True
		Me.picStatus.TabIndex = 12
		Me.picStatus.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' txtExclude
		'
		Me.txtExclude.Name = "txtExclude"
		Me.txtExclude.Size = New System.Drawing.Size(233, 25)
		Me.txtExclude.Location = New System.Drawing.Point(16, 96)
		Me.txtExclude.TabIndex = 10
		'
		' lstFiles
		'
		Me.lstFiles.Name = "lstFiles"
		Me.lstFiles.Size = New System.Drawing.Size(281, 100)
		Me.lstFiles.Location = New System.Drawing.Point(376, 32)
		Me.lstFiles.Sorted = True
		Me.lstFiles.TabIndex = 9
		'
		' txtDestPath
		'
		Me.txtDestPath.Name = "txtDestPath"
		Me.txtDestPath.Size = New System.Drawing.Size(241, 25)
		Me.txtDestPath.Location = New System.Drawing.Point(112, 232)
		Me.txtDestPath.TabIndex = 7
		Me.txtDestPath.Text = "c:\Windows\Temp"
		'
		' cmdCopy
		'
		Me.cmdCopy.Name = "cmdCopy"
		Me.cmdCopy.Size = New System.Drawing.Size(89, 25)
		Me.cmdCopy.Location = New System.Drawing.Point(16, 216)
		Me.cmdCopy.Caption = "&Copy"
		Me.cmdCopy.TabIndex = 6
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(233, 57)
		Me.Frame1.Location = New System.Drawing.Point(16, 136)
		Me.Frame1.Caption = "Attributes"
		Me.Frame1.TabIndex = 3
		'
		' chkSystem
		'
		Me.chkSystem.Name = "chkSystem"
		Me.chkSystem.Size = New System.Drawing.Size(105, 17)
		Me.chkSystem.Location = New System.Drawing.Point(104, 24)
		Me.chkSystem.Caption = "&System"
		Me.chkSystem.TabIndex = 5
		'
		' chkHidden
		'
		Me.chkHidden.Name = "chkHidden"
		Me.chkHidden.Size = New System.Drawing.Size(105, 17)
		Me.chkHidden.Location = New System.Drawing.Point(16, 24)
		Me.chkHidden.Caption = "&Hidden"
		Me.chkHidden.TabIndex = 4
		'
		' cmdParse
		'
		Me.cmdParse.Name = "cmdParse"
		Me.cmdParse.Size = New System.Drawing.Size(89, 25)
		Me.cmdParse.Location = New System.Drawing.Point(264, 32)
		Me.cmdParse.Caption = "&Parse"
		Me.cmdParse.TabIndex = 2
		'
		' txtFilespec
		'
		Me.txtFilespec.Name = "txtFilespec"
		Me.txtFilespec.Size = New System.Drawing.Size(233, 25)
		Me.txtFilespec.Location = New System.Drawing.Point(16, 32)
		Me.txtFilespec.TabIndex = 1
		Me.txtFilespec.Text = "e:\Docs\*.*"
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(201, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 80)
		Me.Label3.Caption = "E&xclude File Spec"
		Me.Label3.TabIndex = 11
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(201, 17)
		Me.Label2.Location = New System.Drawing.Point(112, 216)
		Me.Label2.Caption = "&Destination Path"
		Me.Label2.TabIndex = 8
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(201, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.Caption = "&FileSpec (includes path)"
		Me.Label1.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "CFileOp Class Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(677, 385)

		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdMove)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(chkProgress)
		Me.Frame2.Controls.Add(chkConfirm)
		Me.Controls.Add(picStatus)
		Me.Controls.Add(txtExclude)
		Me.Controls.Add(lstFiles)
		Me.Controls.Add(txtDestPath)
		Me.Controls.Add(cmdCopy)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(chkSystem)
		Me.Frame1.Controls.Add(chkHidden)
		Me.Controls.Add(cmdParse)
		Me.Controls.Add(txtFilespec)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.SetChildIndex(Me.picStatus, 0)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
