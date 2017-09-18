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
	Public WithEvents txtTimeout As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdStopTimer As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdStartTimer As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTimer As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtTimeout = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdStopTimer = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdStartTimer = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTimer = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' txtTimeout
		'
		Me.txtTimeout.Name = "txtTimeout"
		Me.txtTimeout.Size = New System.Drawing.Size(49, 25)
		Me.txtTimeout.Location = New System.Drawing.Point(112, 20)
		Me.txtTimeout.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTimeout.TabIndex = 3
		Me.txtTimeout.Text = "500"
		'
		' cmdStopTimer
		'
		Me.cmdStopTimer.Name = "cmdStopTimer"
		Me.cmdStopTimer.Size = New System.Drawing.Size(89, 33)
		Me.cmdStopTimer.Location = New System.Drawing.Point(8, 64)
		Me.cmdStopTimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStopTimer.Caption = "Stop Timer"
		Me.cmdStopTimer.TabIndex = 2
		'
		' cmdStartTimer
		'
		Me.cmdStartTimer.Name = "cmdStartTimer"
		Me.cmdStartTimer.Size = New System.Drawing.Size(89, 33)
		Me.cmdStartTimer.Location = New System.Drawing.Point(8, 16)
		Me.cmdStartTimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStartTimer.Caption = "Start Timer"
		Me.cmdStartTimer.TabIndex = 1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(97, 17)
		Me.Label1.Location = New System.Drawing.Point(168, 24)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Milliseconds"
		Me.Label1.TabIndex = 4
		'
		' lblTimer
		'
		Me.lblTimer.Name = "lblTimer"
		Me.lblTimer.Size = New System.Drawing.Size(177, 33)
		Me.lblTimer.Location = New System.Drawing.Point(112, 64)
		Me.lblTimer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTimer.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblTimer.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "SetTimer Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(311, 121)

		Me.Controls.Add(txtTimeout)
		Me.Controls.Add(cmdStopTimer)
		Me.Controls.Add(cmdStartTimer)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblTimer)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
