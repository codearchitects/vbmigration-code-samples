<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ScrollPicture
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
	Public WithEvents Command1 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Command1 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Picture1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Command1
		'
		Me.Command1.Name = "Command1"
		Me.Command1.Size = New System.Drawing.Size(49, 17)
		Me.Command1.Location = New System.Drawing.Point(198, 112)
		Me.Command1.Caption = "Close"
		Me.Command1.TabIndex = 2
		Me.Command1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(239, 94)
		Me.Picture1.Location = New System.Drawing.Point(8, 8)
		Me.Picture1.TabIndex = 0
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(220, 73)
		Me.Picture2.Location = New System.Drawing.Point(8, 8)
		Me.Picture2.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Picture2.AutoRedraw = True
		Me.Picture2.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Picture2.TabIndex = 1
		Me.Picture2.Visible = False
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 10
		Me.Timer1.Tag = "1"
		'
		' ScrollPicture
		'
		Me.Name = "ScrollPicture"
		Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.Caption = "About..."
		Me.ControlBox = False
		Me.ForeColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(82, 106)
		Me.ClientSize = New System.Drawing.Size(254, 133)

		Me.Controls.Add(Command1)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Picture2)
		Me.Picture1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
