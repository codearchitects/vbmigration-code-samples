<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class DemoSlider
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
		Me.Slider1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Slider)(Slider1_001, Slider1_000)
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
	Public Slider1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Slider)
	Public WithEvents Slider1_001 As CodeArchitects.VB6Library.VB6Slider
	Public WithEvents Slider1_000 As CodeArchitects.VB6Library.VB6Slider
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Slider1_001 = New CodeArchitects.VB6Library.VB6Slider()
		Me.Slider1_000 = New CodeArchitects.VB6Library.VB6Slider()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.Slider1_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Slider1_000, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Slider1_001
		'
		Me.Slider1_001.Name = "Slider1_001"
		Me.Slider1_001.Location = New System.Drawing.Point(16, 32)
		Me.Slider1_001.TabIndex = 2
		Me.Slider1_001.Orientation = CodeArchitects.VB6Library.MSComctlLib.OrientationConstants.ccOrientationVertical
		Me.Slider1_001.Size = New System.Drawing.Size(25, 313)
		'
		' Slider1_000
		'
		Me.Slider1_000.Name = "Slider1_000"
		Me.Slider1_000.Size = New System.Drawing.Size(385, 25)
		Me.Slider1_000.Location = New System.Drawing.Point(40, 8)
		Me.Slider1_000.TabIndex = 1
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(369, 297)
		Me.Picture1.Location = New System.Drawing.Point(48, 40)
		Me.Picture1.BackColor = FromOleColor6(CInt(&H0080FF80))
		Me.Picture1.TabIndex = 0
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(377, 33)
		Me.Label1.Location = New System.Drawing.Point(48, 344)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Use the sliders to move the intersection point. Press SHIFT to enter SelectRange mode and draw a rectangle."
		Me.Label1.TabIndex = 3
		'
		' DemoSlider
		'
		Me.Name = "DemoSlider"
		Me.Caption = "Slider Control Demo"
		Me.Location = New System.Drawing.Point(134, 128)
		Me.ClientSize = New System.Drawing.Size(444, 384)

		Me.Controls.Add(Slider1_001)
		Me.Controls.Add(Slider1_000)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Label1)
		CType(Me.Slider1_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Slider1_000, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
