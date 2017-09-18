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
	Public WithEvents cmdStop As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtTimes As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtToFrame As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFromFrame As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdBackColor As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPlay As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdBrowse As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFilename As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents CommonDialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Animation1 As CodeArchitects.VB6Library.VB6Animation
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdStop = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtTimes = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtToFrame = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFromFrame = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdBackColor = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPlay = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdBrowse = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFilename = New CodeArchitects.VB6Library.VB6TextBox()
		Me.CommonDialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Animation1 = New CodeArchitects.VB6Library.VB6Animation()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdStop
		'
		Me.cmdStop.Name = "cmdStop"
		Me.cmdStop.Size = New System.Drawing.Size(81, 25)
		Me.cmdStop.Location = New System.Drawing.Point(528, 48)
		Me.cmdStop.Caption = "&Stop"
		Me.cmdStop.Enabled = False
		Me.cmdStop.TabIndex = 12
		'
		' txtTimes
		'
		Me.txtTimes.Name = "txtTimes"
		Me.txtTimes.Size = New System.Drawing.Size(57, 25)
		Me.txtTimes.Location = New System.Drawing.Point(88, 48)
		Me.txtTimes.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtTimes.TabIndex = 11
		'
		' txtToFrame
		'
		Me.txtToFrame.Name = "txtToFrame"
		Me.txtToFrame.Size = New System.Drawing.Size(57, 25)
		Me.txtToFrame.Location = New System.Drawing.Point(368, 48)
		Me.txtToFrame.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtToFrame.TabIndex = 9
		'
		' txtFromFrame
		'
		Me.txtFromFrame.Name = "txtFromFrame"
		Me.txtFromFrame.Size = New System.Drawing.Size(57, 25)
		Me.txtFromFrame.Location = New System.Drawing.Point(248, 48)
		Me.txtFromFrame.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtFromFrame.TabIndex = 7
		'
		' cmdBackColor
		'
		Me.cmdBackColor.Name = "cmdBackColor"
		Me.cmdBackColor.Size = New System.Drawing.Size(81, 25)
		Me.cmdBackColor.Location = New System.Drawing.Point(432, 48)
		Me.cmdBackColor.Caption = "Back&Color"
		Me.cmdBackColor.TabIndex = 5
		'
		' cmdPlay
		'
		Me.cmdPlay.Name = "cmdPlay"
		Me.cmdPlay.Size = New System.Drawing.Size(81, 25)
		Me.cmdPlay.Location = New System.Drawing.Point(528, 16)
		Me.cmdPlay.Caption = "&Play"
		Me.cmdPlay.Enabled = False
		Me.cmdPlay.TabIndex = 4
		'
		' cmdBrowse
		'
		Me.cmdBrowse.Name = "cmdBrowse"
		Me.cmdBrowse.Size = New System.Drawing.Size(81, 25)
		Me.cmdBrowse.Location = New System.Drawing.Point(432, 16)
		Me.cmdBrowse.Caption = "&Browse"
		Me.cmdBrowse.TabIndex = 3
		'
		' txtFilename
		'
		Me.txtFilename.Name = "txtFilename"
		Me.txtFilename.Size = New System.Drawing.Size(345, 25)
		Me.txtFilename.Location = New System.Drawing.Point(88, 16)
		Me.txtFilename.TabIndex = 2
		'
		' CommonDialog1
		'
		Me.CommonDialog1.Name = "CommonDialog1"
		Me.CommonDialog1.ParentForm = Me
		'
		' Animation1
		'
		Me.Animation1.Name = "Animation1"
		Me.Animation1.Size = New System.Drawing.Size(457, 193)
		Me.Animation1.Location = New System.Drawing.Point(16, 80)
		Me.Animation1.TabIndex = 0
		Me.Animation1.Center = True
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 25)
		Me.Label4.Location = New System.Drawing.Point(8, 48)
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label4.Caption = "Times"
		Me.Label4.TabIndex = 10
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(73, 25)
		Me.Label3.Location = New System.Drawing.Point(296, 48)
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label3.Caption = "ToFrame"
		Me.Label3.TabIndex = 8
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(73, 25)
		Me.Label2.Location = New System.Drawing.Point(168, 48)
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label2.Caption = "FromFrame"
		Me.Label2.TabIndex = 6
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 25)
		Me.Label1.Location = New System.Drawing.Point(16, 16)
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1.Caption = "AVI File:"
		Me.Label1.TabIndex = 1
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Animation Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(637, 294)

		Me.Controls.Add(cmdStop)
		Me.Controls.Add(txtTimes)
		Me.Controls.Add(txtToFrame)
		Me.Controls.Add(txtFromFrame)
		Me.Controls.Add(cmdBackColor)
		Me.Controls.Add(cmdPlay)
		Me.Controls.Add(cmdBrowse)
		Me.Controls.Add(txtFilename)
		Me.Controls.Add(Animation1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
