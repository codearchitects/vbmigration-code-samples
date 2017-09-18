<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Frame1.SuspendLayout()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(309, 169)
		Me.Frame1.Location = New System.Drawing.Point(4, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(299, 156)
		Me.Image1.Location = New System.Drawing.Point(4, 8)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 5000
		'
		' frmSplash
		'
		Me.Name = "frmSplash"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "Form1"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(318, 174)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
