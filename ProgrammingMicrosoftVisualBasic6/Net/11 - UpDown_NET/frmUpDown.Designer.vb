<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUpDown
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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_001, Label1_000)
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
	Public WithEvents cmdChangeBuddy As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtValue2 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents updHorizontal As CodeArchitects.VB6Library.VB6UpDown
	Public WithEvents updVertical As CodeArchitects.VB6Library.VB6UpDown
	Public WithEvents updBuddy As CodeArchitects.VB6Library.VB6UpDown
	Public WithEvents txtValue As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdChangeBuddy = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtValue2 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.updHorizontal = New CodeArchitects.VB6Library.VB6UpDown()
		Me.updVertical = New CodeArchitects.VB6Library.VB6UpDown()
		Me.updBuddy = New CodeArchitects.VB6Library.VB6UpDown()
		Me.txtValue = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.updHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.updVertical, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.updBuddy, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdChangeBuddy
		'
		Me.cmdChangeBuddy.Name = "cmdChangeBuddy"
		Me.cmdChangeBuddy.Size = New System.Drawing.Size(153, 25)
		Me.cmdChangeBuddy.Location = New System.Drawing.Point(32, 88)
		Me.cmdChangeBuddy.Caption = "Change Buddy Control"
		Me.cmdChangeBuddy.TabIndex = 7
		'
		' txtValue2
		'
		Me.txtValue2.Name = "txtValue2"
		Me.txtValue2.Size = New System.Drawing.Size(169, 25)
		Me.txtValue2.Location = New System.Drawing.Point(32, 128)
		Me.txtValue2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtValue2.TabIndex = 6
		'
		' updHorizontal
		'
		Me.updHorizontal.Name = "updHorizontal"
		Me.updHorizontal.Size = New System.Drawing.Size(25, 16)
		Me.updHorizontal.Location = New System.Drawing.Point(280, 48)
		Me.updHorizontal.TabIndex = 5
		Me.updHorizontal.Orientation = CodeArchitects.VB6Library.MSComCtl2.OrientationConstants.cc2OrientationHorizontal
		Me.updHorizontal.Enabled = True
		'
		' updVertical
		'
		Me.updVertical.Name = "updVertical"
		Me.updVertical.Size = New System.Drawing.Size(16, 25)
		Me.updVertical.Location = New System.Drawing.Point(304, 64)
		Me.updVertical.TabIndex = 4
		Me.updVertical.Enabled = True
		'
		' updBuddy
		'
		Me.updBuddy.Name = "updBuddy"
		Me.updBuddy.Size = New System.Drawing.Size(16, 25)
		Me.updBuddy.Location = New System.Drawing.Point(184, 48)
		Me.updBuddy.TabIndex = 1
		Me.updBuddy.BuddyControl = "txtValue"
		Me.updBuddy.SyncBuddy = True
		Me.updBuddy.Enabled = True
		Me.updBuddy.BuddyProperty = "Text"
		'
		' txtValue
		'
		Me.txtValue.Name = "txtValue"
		Me.txtValue.Size = New System.Drawing.Size(153, 25)
		Me.txtValue.Location = New System.Drawing.Point(32, 48)
		Me.txtValue.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtValue.TabIndex = 0
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(169, 33)
		Me.Label1_001.Location = New System.Drawing.Point(216, 8)
		Me.Label1_001.Caption = "Moves all controls on this form using these UpDown's"
		Me.Label1_001.TabIndex = 3
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(169, 33)
		Me.Label1_000.Location = New System.Drawing.Point(32, 8)
		Me.Label1_000.Caption = "Type a new value or modify it with the UpDown control"
		Me.Label1_000.TabIndex = 2
		'
		' frmUpDown
		'
		Me.Name = "frmUpDown"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "UpDown Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(387, 169)

		Me.Controls.Add(cmdChangeBuddy)
		Me.Controls.Add(txtValue2)
		Me.Controls.Add(updHorizontal)
		Me.Controls.Add(updVertical)
		Me.Controls.Add(updBuddy)
		Me.Controls.Add(txtValue)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		CType(Me.updHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.updVertical, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.updBuddy, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
