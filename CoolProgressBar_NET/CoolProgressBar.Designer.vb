<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class CoolProgressBar
	Inherits CodeArchitects.VB6Library.VB6UserControl

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
	Private WithEvents picBackbuffer As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CoolProgressBar))
		Me.picBackbuffer = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.SuspendLayout()
		'
		' picBackbuffer
		'
		Me.picBackbuffer.Name = "picBackbuffer"
		Me.picBackbuffer.Size = New System.Drawing.Size(256, 17)
		Me.picBackbuffer.Location = New System.Drawing.Point(0, 0)
		Me.picBackbuffer.AutoRedraw = True
		Me.picBackbuffer.BackColor = FromOleColor6(CInt(&H00000000))
		Me.picBackbuffer.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picBackbuffer.TabIndex = 0
		Me.picBackbuffer.Visible = False
		Me.picBackbuffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picBackbuffer.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' CoolProgressBar
		'
		Me.Name = "CoolProgressBar"
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(256, 16)

		Me.Controls.Add(picBackbuffer)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
