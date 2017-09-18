<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Splash
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
	Public WithEvents Progress As CodeArchitects.VB6Library.VB6ProgressBar
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Splash))
		Me.Progress = New CodeArchitects.VB6Library.VB6ProgressBar()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Progress
		'
		Me.Progress.Name = "Progress"
		Me.Progress.Size = New System.Drawing.Size(369, 17)
		Me.Progress.Location = New System.Drawing.Point(24, 264)
		Me.Progress.TabIndex = 4
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 0
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 13)
		Me.Label5.Location = New System.Drawing.Point(24, 288)
		Me.Label5.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label5.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label5.Caption = "Loading........"
		Me.Label5.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label5.TabIndex = 5
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(108, 13)
		Me.Label4.Location = New System.Drawing.Point(144, 224)
		Me.Label4.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label4.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label4.Caption = "gerbert_p@yahoo.com"
		Me.Label4.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label4.TabIndex = 3
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(3, 13)
		Me.Label3.Location = New System.Drawing.Point(32, 256)
		Me.Label3.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label3.TabIndex = 2
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(172, 13)
		Me.Label2.Location = New System.Drawing.Point(104, 208)
		Me.Label2.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Copyright (g) by: Gerbert S. Pagtama"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label2.TabIndex = 1
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 13)
		Me.Label1.Location = New System.Drawing.Point(88, 288)
		Me.Label1.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Loading........"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.Label1.TabIndex = 0
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(401, 305)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Stretch = True
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		'
		' Splash
		'
		Me.Name = "Splash"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H80000005))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.ControlBox = False
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(1, 1)
		Me.ClientSize = New System.Drawing.Size(400, 303)

		Me.Controls.Add(Progress)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Image1)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
