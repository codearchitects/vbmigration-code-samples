<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
	Inherits CodeArchitects.VB6Library.VB6Form

#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
	EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Unsupported properties"

	' UPGRADE_ISSUE (#0238): Unable to read the DTPicker3.Format property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6
	' UPGRADE_ISSUE (#0238): Unable to read the DTPicker2.Format property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6
	' UPGRADE_ISSUE (#0238): Unable to read the DTPicker1.Format property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6
	' UPGRADE_ISSUE (#0238): Unable to read the DTPicker4.Format property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6
	' UPGRADE_ISSUE (#0238): Unable to read the DTPicker5.Format property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6

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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_004, Label1_003, Label1_002, Label1_001, Label1_000)
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
	Public WithEvents DTPicker3 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents DTPicker2 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents DTPicker1 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents DTPicker4 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents DTPicker5 As CodeArchitects.VB6Library.VB6DTPicker
	Public WithEvents Label1_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.DTPicker3 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.DTPicker2 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.DTPicker1 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.DTPicker4 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.DTPicker5 = New CodeArchitects.VB6Library.VB6DTPicker()
		Me.Label1_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' DTPicker3
		'
		Me.DTPicker3.Name = "DTPicker3"
		Me.DTPicker3.Size = New System.Drawing.Size(225, 25)
		Me.DTPicker3.Location = New System.Drawing.Point(24, 112)
		Me.DTPicker3.TabIndex = 2
		Me.DTPicker3.CustomFormat = "MMM - yyyy"
		Me.DTPicker3.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpTime
		'
		' DTPicker2
		'
		Me.DTPicker2.Name = "DTPicker2"
		Me.DTPicker2.Size = New System.Drawing.Size(225, 25)
		Me.DTPicker2.Location = New System.Drawing.Point(272, 40)
		Me.DTPicker2.TabIndex = 1
		Me.DTPicker2.CheckBox = True
		Me.DTPicker2.UpDown = True
		Me.DTPicker2.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpShortDate
		'
		' DTPicker1
		'
		Me.DTPicker1.Name = "DTPicker1"
		Me.DTPicker1.Size = New System.Drawing.Size(225, 25)
		Me.DTPicker1.Location = New System.Drawing.Point(24, 40)
		Me.DTPicker1.TabIndex = 0
		Me.DTPicker1.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpLongDate
		'
		' DTPicker4
		'
		Me.DTPicker4.Name = "DTPicker4"
		Me.DTPicker4.Size = New System.Drawing.Size(225, 25)
		Me.DTPicker4.Location = New System.Drawing.Point(272, 112)
		Me.DTPicker4.TabIndex = 6
		Me.DTPicker4.CustomFormat = "'Date is' dddd MMM d, yyy"
		Me.DTPicker4.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpCustom
		'
		' DTPicker5
		'
		Me.DTPicker5.Name = "DTPicker5"
		Me.DTPicker5.Size = New System.Drawing.Size(473, 25)
		Me.DTPicker5.Location = New System.Drawing.Point(24, 184)
		Me.DTPicker5.TabIndex = 8
		Me.DTPicker5.CustomFormat = "MMM d, yyy '(week 'XX')' XXX"
		Me.DTPicker5.Format = CodeArchitects.VB6Library.MSComCtl2.FormatConstant.dtpCustom
		'
		' Label1_004
		'
		Me.Label1_004.Name = "Label1_004"
		Me.Label1_004.Size = New System.Drawing.Size(265, 17)
		Me.Label1_004.Location = New System.Drawing.Point(24, 160)
		Me.Label1_004.Caption = "DTPicker with a two callback fields"
		Me.Label1_004.TabIndex = 9
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(233, 17)
		Me.Label1_003.Location = New System.Drawing.Point(24, 88)
		Me.Label1_003.Caption = "DTPicker with a time value"
		Me.Label1_003.TabIndex = 7
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(265, 17)
		Me.Label1_002.Location = New System.Drawing.Point(272, 88)
		Me.Label1_002.Caption = "DTPicker with a custom format"
		Me.Label1_002.TabIndex = 5
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(265, 17)
		Me.Label1_001.Location = New System.Drawing.Point(272, 16)
		Me.Label1_001.Caption = "DTPicker with checkbox and spin buttons"
		Me.Label1_001.TabIndex = 4
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(265, 17)
		Me.Label1_000.Location = New System.Drawing.Point(24, 16)
		Me.Label1_000.Caption = "DTPicker with a drop-down calendar"
		Me.Label1_000.TabIndex = 3
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "DateTimePicker Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(521, 234)

		Me.Controls.Add(DTPicker3)
		Me.Controls.Add(DTPicker2)
		Me.Controls.Add(DTPicker1)
		Me.Controls.Add(DTPicker4)
		Me.Controls.Add(DTPicker5)
		Me.Controls.Add(Label1_004)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
