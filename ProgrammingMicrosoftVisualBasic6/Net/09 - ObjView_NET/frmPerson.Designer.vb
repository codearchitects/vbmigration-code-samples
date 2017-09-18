<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPerson
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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_002, Label1_001, Label1_000)
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
	Public WithEvents chkMarried As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCity As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtAddress As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.chkMarried = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCity = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtAddress = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' chkMarried
		'
		Me.chkMarried.Name = "chkMarried"
		Me.chkMarried.Size = New System.Drawing.Size(145, 17)
		Me.chkMarried.Location = New System.Drawing.Point(248, 176)
		Me.chkMarried.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMarried.Caption = "&Married"
		Me.chkMarried.TabIndex = 7
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(81, 33)
		Me.cmdOK.Location = New System.Drawing.Point(416, 40)
		Me.cmdOK.Caption = "OK"
		Me.cmdOK.TabIndex = 6
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' txtCity
		'
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(201, 33)
		Me.txtCity.Location = New System.Drawing.Point(16, 176)
		Me.txtCity.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.TabIndex = 5
		'
		' txtAddress
		'
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(385, 33)
		Me.txtAddress.Location = New System.Drawing.Point(16, 104)
		Me.txtAddress.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.TabIndex = 4
		'
		' txtName
		'
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(385, 33)
		Me.txtName.Location = New System.Drawing.Point(16, 40)
		Me.txtName.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.TabIndex = 3
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(225, 25)
		Me.Label1_002.Location = New System.Drawing.Point(16, 152)
		Me.Label1_002.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_002.Caption = "&City"
		Me.Label1_002.TabIndex = 2
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(225, 25)
		Me.Label1_001.Location = New System.Drawing.Point(16, 80)
		Me.Label1_001.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_001.Caption = "&Address"
		Me.Label1_001.TabIndex = 1
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(225, 25)
		Me.Label1_000.Location = New System.Drawing.Point(16, 16)
		Me.Label1_000.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_000.Caption = "&Name"
		Me.Label1_000.TabIndex = 0
		'
		' frmPerson
		'
		Me.Name = "frmPerson"
		Me.Caption = "Person "
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(508, 230)

		Me.Controls.Add(chkMarried)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(txtCity)
		Me.Controls.Add(txtAddress)
		Me.Controls.Add(txtName)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
