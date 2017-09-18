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
		Me.cmdMove = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMove_008, cmdMove_007, cmdMove_006, cmdMove_005, cmdMove_004, cmdMove_003, cmdMove_002, cmdMove_001, cmdMove_000)
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
	Public cmdMove As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents cmdMove_008 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_007 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtID As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtDepartment As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdMove_008 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_007 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtID = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtDepartment = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdMove_008
		'
		Me.cmdMove_008.Name = "cmdMove_008"
		Me.cmdMove_008.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_008.Location = New System.Drawing.Point(264, 240)
		Me.cmdMove_008.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_008.Caption = "Show Data"
		Me.cmdMove_008.TabIndex = 14
		'
		' cmdMove_007
		'
		Me.cmdMove_007.Name = "cmdMove_007"
		Me.cmdMove_007.Size = New System.Drawing.Size(121, 33)
		Me.cmdMove_007.Location = New System.Drawing.Point(136, 240)
		Me.cmdMove_007.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_007.Caption = "Goto Bookmark"
		Me.cmdMove_007.TabIndex = 13
		'
		' cmdMove_006
		'
		Me.cmdMove_006.Name = "cmdMove_006"
		Me.cmdMove_006.Size = New System.Drawing.Size(121, 33)
		Me.cmdMove_006.Location = New System.Drawing.Point(16, 240)
		Me.cmdMove_006.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_006.Caption = "Set Bookmark"
		Me.cmdMove_006.TabIndex = 12
		'
		' cmdMove_005
		'
		Me.cmdMove_005.Name = "cmdMove_005"
		Me.cmdMove_005.Size = New System.Drawing.Size(65, 33)
		Me.cmdMove_005.Location = New System.Drawing.Point(288, 192)
		Me.cmdMove_005.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_005.Caption = "Delete"
		Me.cmdMove_005.TabIndex = 11
		'
		' cmdMove_004
		'
		Me.cmdMove_004.Name = "cmdMove_004"
		Me.cmdMove_004.Size = New System.Drawing.Size(65, 33)
		Me.cmdMove_004.Location = New System.Drawing.Point(224, 192)
		Me.cmdMove_004.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_004.Caption = "Add"
		Me.cmdMove_004.TabIndex = 10
		'
		' cmdMove_003
		'
		Me.cmdMove_003.Name = "cmdMove_003"
		Me.cmdMove_003.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_003.Location = New System.Drawing.Point(160, 192)
		Me.cmdMove_003.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_003.Caption = ">>"
		Me.cmdMove_003.TabIndex = 9
		'
		' cmdMove_002
		'
		Me.cmdMove_002.Name = "cmdMove_002"
		Me.cmdMove_002.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_002.Location = New System.Drawing.Point(112, 192)
		Me.cmdMove_002.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_002.Caption = ">"
		Me.cmdMove_002.TabIndex = 8
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_001.Location = New System.Drawing.Point(64, 192)
		Me.cmdMove_001.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_001.Caption = "<"
		Me.cmdMove_001.TabIndex = 7
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_000.Location = New System.Drawing.Point(16, 192)
		Me.cmdMove_000.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_000.Caption = "<<"
		Me.cmdMove_000.TabIndex = 6
		'
		' txtID
		'
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(81, 25)
		Me.txtID.Location = New System.Drawing.Point(16, 32)
		Me.txtID.TabIndex = 1
		'
		' txtDepartment
		'
		Me.txtDepartment.Name = "txtDepartment"
		Me.txtDepartment.Size = New System.Drawing.Size(337, 25)
		Me.txtDepartment.Location = New System.Drawing.Point(16, 144)
		Me.txtDepartment.TabIndex = 5
		'
		' txtName
		'
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(337, 25)
		Me.txtName.Location = New System.Drawing.Point(16, 88)
		Me.txtName.TabIndex = 3
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(145, 17)
		Me.Label3.Location = New System.Drawing.Point(16, 16)
		Me.Label3.Caption = "&ID"
		Me.Label3.TabIndex = 0
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 128)
		Me.Label2.Caption = "&Department"
		Me.Label2.TabIndex = 4
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 72)
		Me.Label1.Caption = "&Name"
		Me.Label1.TabIndex = 2
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ArrayDataSource demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(364, 290)

		Me.Controls.Add(cmdMove_008)
		Me.Controls.Add(cmdMove_007)
		Me.Controls.Add(cmdMove_006)
		Me.Controls.Add(cmdMove_005)
		Me.Controls.Add(cmdMove_004)
		Me.Controls.Add(cmdMove_003)
		Me.Controls.Add(cmdMove_002)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_000)
		Me.Controls.Add(txtID)
		Me.Controls.Add(txtDepartment)
		Me.Controls.Add(txtName)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
