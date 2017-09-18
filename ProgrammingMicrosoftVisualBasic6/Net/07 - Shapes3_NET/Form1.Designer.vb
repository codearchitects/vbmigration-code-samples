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
		Me.cmdZoom = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdZoom_001, cmdZoom_000)
		Me.cmdMove = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMove_003, cmdMove_002, cmdMove_001, cmdMove_000)
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
	Public cmdZoom As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public cmdMove As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdZoom_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdZoom_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRedraw As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents picView As CodeArchitects.VB6Library.VB6PictureBox

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdZoom_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdZoom_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRedraw = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.picView = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.SuspendLayout()
		'
		' cmdZoom_001
		'
		Me.cmdZoom_001.Name = "cmdZoom_001"
		Me.cmdZoom_001.Size = New System.Drawing.Size(73, 33)
		Me.cmdZoom_001.Location = New System.Drawing.Point(488, 264)
		Me.cmdZoom_001.Caption = "Reduce"
		Me.cmdZoom_001.TabIndex = 7
		'
		' cmdZoom_000
		'
		Me.cmdZoom_000.Name = "cmdZoom_000"
		Me.cmdZoom_000.Size = New System.Drawing.Size(73, 33)
		Me.cmdZoom_000.Location = New System.Drawing.Point(488, 232)
		Me.cmdZoom_000.Caption = "Enlarge"
		Me.cmdZoom_000.TabIndex = 6
		'
		' cmdMove_003
		'
		Me.cmdMove_003.Name = "cmdMove_003"
		Me.cmdMove_003.Size = New System.Drawing.Size(25, 25)
		Me.cmdMove_003.Location = New System.Drawing.Point(536, 160)
		Me.cmdMove_003.Picture = CType(resources.GetObject("cmdMove_003.Picture"), System.Drawing.Image)
		Me.cmdMove_003.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdMove_003.TabIndex = 5
		'
		' cmdMove_002
		'
		Me.cmdMove_002.Name = "cmdMove_002"
		Me.cmdMove_002.Size = New System.Drawing.Size(25, 25)
		Me.cmdMove_002.Location = New System.Drawing.Point(488, 160)
		Me.cmdMove_002.Picture = CType(resources.GetObject("cmdMove_002.Picture"), System.Drawing.Image)
		Me.cmdMove_002.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdMove_002.TabIndex = 4
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(25, 25)
		Me.cmdMove_001.Location = New System.Drawing.Point(512, 184)
		Me.cmdMove_001.Picture = CType(resources.GetObject("cmdMove_001.Picture"), System.Drawing.Image)
		Me.cmdMove_001.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdMove_001.TabIndex = 3
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(25, 25)
		Me.cmdMove_000.Location = New System.Drawing.Point(512, 136)
		Me.cmdMove_000.Picture = CType(resources.GetObject("cmdMove_000.Picture"), System.Drawing.Image)
		Me.cmdMove_000.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdMove_000.TabIndex = 2
		'
		' cmdRedraw
		'
		Me.cmdRedraw.Name = "cmdRedraw"
		Me.cmdRedraw.Size = New System.Drawing.Size(81, 33)
		Me.cmdRedraw.Location = New System.Drawing.Point(480, 8)
		Me.cmdRedraw.Caption = "&Redraw"
		Me.cmdRedraw.TabIndex = 1
		Me.AcceptButton = Me.cmdRedraw
		Me.cmdRedraw.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' picView
		'
		Me.picView.Name = "picView"
		Me.picView.Size = New System.Drawing.Size(457, 361)
		Me.picView.Location = New System.Drawing.Point(8, 8)
		Me.picView.TabIndex = 0
		Me.picView.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Polymorphism in Action"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(11, 30)
		Me.ClientSize = New System.Drawing.Size(573, 381)

		Me.Controls.Add(cmdZoom_001)
		Me.Controls.Add(cmdZoom_000)
		Me.Controls.Add(cmdMove_003)
		Me.Controls.Add(cmdMove_002)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_000)
		Me.Controls.Add(cmdRedraw)
		Me.Controls.Add(picView)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
