<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FRM_UPDATE_REC
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
	Public WithEvents Timer3 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Timer2 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents ProgressBar1 As CodeArchitects.VB6Library.VB6ProgressBar
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_UPDATE_REC))
		Me.Timer3 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Timer2 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.ProgressBar1 = New CodeArchitects.VB6Library.VB6ProgressBar()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' Timer3
		'
		Me.Timer3.Name = "Timer3"
		Me.Timer3.ParentForm = Me
		Me.Timer3.Name6 = "Timer3"
		Me.Timer3.Interval = 1000
		'
		' Timer2
		'
		Me.Timer2.Name = "Timer2"
		Me.Timer2.ParentForm = Me
		Me.Timer2.Name6 = "Timer2"
		Me.Timer2.Interval = 0
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 0
		'
		' ProgressBar1
		'
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(337, 25)
		Me.ProgressBar1.Location = New System.Drawing.Point(8, 24)
		Me.ProgressBar1.TabIndex = 0
		Me.ProgressBar1.Scrolling = CodeArchitects.VB6Library.MSComctlLib.ScrollingConstants.ccScrollingSmooth
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(201, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "Updating Database. Please wait..."
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' FRM_UPDATE_REC
		'
		Me.Name = "FRM_UPDATE_REC"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedDouble
		Me.ControlBox = False
		Me.Icon = Nothing
		Me.KeyPreview = True
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(17, 94)
		Me.ClientSize = New System.Drawing.Size(352, 58)

		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
