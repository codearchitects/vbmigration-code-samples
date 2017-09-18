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
	Public cmdMove As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public WithEvents txtHireDate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtLastName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFirstName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtBirthDate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdMove_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtHireDate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtLastName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFirstName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtBirthDate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdMove_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' txtHireDate
		'
		Me.txtHireDate.Name = "txtHireDate"
		Me.txtHireDate.Size = New System.Drawing.Size(169, 25)
		Me.txtHireDate.Location = New System.Drawing.Point(200, 80)
		Me.txtHireDate.TabIndex = 10
		'
		' txtLastName
		'
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(169, 25)
		Me.txtLastName.Location = New System.Drawing.Point(200, 24)
		Me.txtLastName.TabIndex = 8
		'
		' txtFirstName
		'
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(177, 25)
		Me.txtFirstName.Location = New System.Drawing.Point(16, 24)
		Me.txtFirstName.TabIndex = 6
		'
		' txtBirthDate
		'
		Me.txtBirthDate.Name = "txtBirthDate"
		Me.txtBirthDate.Size = New System.Drawing.Size(177, 25)
		Me.txtBirthDate.Location = New System.Drawing.Point(16, 80)
		Me.txtBirthDate.TabIndex = 4
		'
		' cmdMove_003
		'
		Me.cmdMove_003.Name = "cmdMove_003"
		Me.cmdMove_003.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_003.Location = New System.Drawing.Point(280, 136)
		Me.cmdMove_003.Caption = "Last"
		Me.cmdMove_003.TabIndex = 3
		'
		' cmdMove_002
		'
		Me.cmdMove_002.Name = "cmdMove_002"
		Me.cmdMove_002.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_002.Location = New System.Drawing.Point(192, 136)
		Me.cmdMove_002.Caption = "Next"
		Me.cmdMove_002.TabIndex = 2
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_001.Location = New System.Drawing.Point(104, 136)
		Me.cmdMove_001.Caption = "Previous"
		Me.cmdMove_001.TabIndex = 1
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_000.Location = New System.Drawing.Point(16, 136)
		Me.cmdMove_000.Caption = "First"
		Me.cmdMove_000.TabIndex = 0
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(177, 17)
		Me.Label6.Location = New System.Drawing.Point(200, 64)
		Me.Label6.Caption = "&Hire Date"
		Me.Label6.TabIndex = 11
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(161, 17)
		Me.Label5.Location = New System.Drawing.Point(200, 8)
		Me.Label5.Caption = "&Last Name"
		Me.Label5.TabIndex = 9
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(153, 17)
		Me.Label4.Location = New System.Drawing.Point(16, 8)
		Me.Label4.Caption = "&First Name"
		Me.Label4.TabIndex = 7
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(177, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 64)
		Me.Label1.Caption = "&Birth Date"
		Me.Label1.TabIndex = 5
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "BindingCollection Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(386, 183)

		Me.Controls.Add(txtHireDate)
		Me.Controls.Add(txtLastName)
		Me.Controls.Add(txtFirstName)
		Me.Controls.Add(txtBirthDate)
		Me.Controls.Add(cmdMove_003)
		Me.Controls.Add(cmdMove_002)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_000)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
