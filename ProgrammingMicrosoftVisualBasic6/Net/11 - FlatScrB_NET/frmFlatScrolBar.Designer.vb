<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFlatScrolBar
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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_003, Label1_002, Label1_001, Label1_000)
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
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents FlatScrollBar2 As CodeArchitects.VB6Library.VB6FlatScrollBar
	Public WithEvents FlatScrollBar1 As CodeArchitects.VB6Library.VB6FlatScrollBar
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.FlatScrollBar2 = New CodeArchitects.VB6Library.VB6FlatScrollBar()
		Me.FlatScrollBar1 = New CodeArchitects.VB6Library.VB6FlatScrollBar()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' FlatScrollBar2
		'
		Me.FlatScrollBar2.Name = "FlatScrollBar2"
		Me.FlatScrollBar2.Size = New System.Drawing.Size(25, 201)
		Me.FlatScrollBar2.Location = New System.Drawing.Point(24, 32)
		Me.FlatScrollBar2.TabIndex = 1
		Me.FlatScrollBar2.LargeChange = 16
		Me.FlatScrollBar2.Max = 256
		Me.FlatScrollBar2.Orientation = MSComCtl2.OrientationConstants.cc2OrientationVertical
		'
		' FlatScrollBar1
		'
		Me.FlatScrollBar1.Name = "FlatScrollBar1"
		Me.FlatScrollBar1.Size = New System.Drawing.Size(201, 25)
		Me.FlatScrollBar1.Location = New System.Drawing.Point(96, 48)
		Me.FlatScrollBar1.TabIndex = 0
		Me.FlatScrollBar1.LargeChange = 16
		Me.FlatScrollBar1.Max = 256
		Me.FlatScrollBar1.Orientation = MSComCtl2.OrientationConstants.cc2OrientationHorizontal
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(233, 25)
		Me.Label1_003.Location = New System.Drawing.Point(24, 256)
		Me.Label1_003.Caption = "Orientation = cc2OrientationVertical"
		Me.Label1_003.TabIndex = 5
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(169, 25)
		Me.Label1_002.Location = New System.Drawing.Point(24, 240)
		Me.Label1_002.Caption = "Appearance = fsbTrack3D"
		Me.Label1_002.TabIndex = 4
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(233, 25)
		Me.Label1_001.Location = New System.Drawing.Point(96, 24)
		Me.Label1_001.Caption = "Orientation = cc2OrientationHorizontal"
		Me.Label1_001.TabIndex = 3
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(169, 25)
		Me.Label1_000.Location = New System.Drawing.Point(96, 8)
		Me.Label1_000.Caption = "Appearance = fsb3D"
		Me.Label1_000.TabIndex = 2
		'
		' frmFlatScrolBar
		'
		Me.Name = "frmFlatScrolBar"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "FlatScrollBar Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(353, 281)

		Me.Controls.Add(FlatScrollBar2)
		Me.Controls.Add(FlatScrollBar1)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
