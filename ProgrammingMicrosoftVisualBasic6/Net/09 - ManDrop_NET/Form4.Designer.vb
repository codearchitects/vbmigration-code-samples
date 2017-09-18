<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form4
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
		Me.txtField = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtField_004, txtField_003, txtField_002, txtField_001, txtField_000)
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_002, Label1_004, Label1_003, Label1_001, Label1_000)
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
	Public txtField As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents txtField_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtField_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtField_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtField_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtField_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents imgDrag As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
		Me.txtField_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtField_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtField_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtField_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtField_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.imgDrag = New CodeArchitects.VB6Library.VB6Image()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.imgDrag, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' txtField_004
		'
		Me.txtField_004.Name = "txtField_004"
		Me.txtField_004.Size = New System.Drawing.Size(169, 25)
		Me.txtField_004.Location = New System.Drawing.Point(304, 136)
		Me.txtField_004.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtField_004.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtField_004.TabIndex = 10
		'
		' txtField_003
		'
		Me.txtField_003.Name = "txtField_003"
		Me.txtField_003.Size = New System.Drawing.Size(137, 25)
		Me.txtField_003.Location = New System.Drawing.Point(152, 136)
		Me.txtField_003.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtField_003.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtField_003.TabIndex = 7
		'
		' txtField_002
		'
		Me.txtField_002.Name = "txtField_002"
		Me.txtField_002.Size = New System.Drawing.Size(129, 25)
		Me.txtField_002.Location = New System.Drawing.Point(8, 136)
		Me.txtField_002.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtField_002.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtField_002.TabIndex = 5
		'
		' txtField_001
		'
		Me.txtField_001.Name = "txtField_001"
		Me.txtField_001.Size = New System.Drawing.Size(465, 25)
		Me.txtField_001.Location = New System.Drawing.Point(8, 80)
		Me.txtField_001.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtField_001.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtField_001.TabIndex = 3
		'
		' txtField_000
		'
		Me.txtField_000.Name = "txtField_000"
		Me.txtField_000.Size = New System.Drawing.Size(465, 25)
		Me.txtField_000.Location = New System.Drawing.Point(8, 24)
		Me.txtField_000.OLEDragMode = CodeArchitects.VB6Library.VBRUN.OLEDragConstants.vbOLEDragAutomatic
		Me.txtField_000.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropAutomatic
		Me.txtField_000.TabIndex = 1
		'
		' imgDrag
		'
		Me.imgDrag.Name = "imgDrag"
		Me.imgDrag.Size = New System.Drawing.Size(60, 52)
		Me.imgDrag.Location = New System.Drawing.Point(400, 184)
		Me.imgDrag.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.imgDrag.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.imgDrag.Stretch = True
		Me.imgDrag.Picture = CType(resources.GetObject("imgDrag.Picture"), System.Drawing.Image)
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(33, 17)
		Me.Label1_002.Location = New System.Drawing.Point(304, 112)
		Me.Label1_002.Caption = "&SSN"
		Me.Label1_002.TabIndex = 9
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(377, 73)
		Me.Label2.Location = New System.Drawing.Point(8, 176)
		Me.Label2.Caption = "Fill this form with data, then start another instance of this form (or another instance of this app), then drag the button on the right onto the button on the target form. Keep the Ctrl key pressed for a Copy operation, or nothing for a Move operation."
		Me.Label2.TabIndex = 8
		'
		' Label1_004
		'
		Me.Label1_004.Name = "Label1_004"
		Me.Label1_004.Size = New System.Drawing.Size(57, 17)
		Me.Label1_004.Location = New System.Drawing.Point(152, 112)
		Me.Label1_004.Caption = "Sa&lary"
		Me.Label1_004.TabIndex = 6
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(65, 17)
		Me.Label1_003.Location = New System.Drawing.Point(8, 112)
		Me.Label1_003.Caption = "&Birth Date "
		Me.Label1_003.TabIndex = 4
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(73, 17)
		Me.Label1_001.Location = New System.Drawing.Point(8, 56)
		Me.Label1_001.Caption = "&Address"
		Me.Label1_001.TabIndex = 2
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(57, 17)
		Me.Label1_000.Location = New System.Drawing.Point(8, 0)
		Me.Label1_000.Caption = "&Name"
		Me.Label1_000.TabIndex = 0
		'
		' Form4
		'
		Me.Name = "Form4"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Custom Format Drag-and-Drop"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(483, 259)

		Me.Controls.Add(txtField_004)
		Me.Controls.Add(txtField_003)
		Me.Controls.Add(txtField_002)
		Me.Controls.Add(txtField_001)
		Me.Controls.Add(txtField_000)
		Me.Controls.Add(imgDrag)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1_004)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		CType(Me.imgDrag, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
