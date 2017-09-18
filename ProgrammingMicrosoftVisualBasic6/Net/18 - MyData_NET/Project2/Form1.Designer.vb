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
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdApply As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFilter As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtCity As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtState As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents MyDataControl1 As Project1.MyDataControl
	Public WithEvents txtAddress As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdApply = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFilter = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtCity = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtState = New CodeArchitects.VB6Library.VB6TextBox()
		Me.MyDataControl1 = New Project1.MyDataControl()
		Me.txtAddress = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		CType(Me.MyDataControl1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(241, 65)
		Me.Frame1.Location = New System.Drawing.Point(8, 160)
		Me.Frame1.Caption = "Filter on Name"
		Me.Frame1.TabIndex = 9
		'
		' cmdApply
		'
		Me.cmdApply.Name = "cmdApply"
		Me.cmdApply.Size = New System.Drawing.Size(49, 25)
		Me.cmdApply.Location = New System.Drawing.Point(176, 24)
		Me.cmdApply.Caption = "Apply"
		Me.cmdApply.TabIndex = 11
		'
		' txtFilter
		'
		Me.txtFilter.Name = "txtFilter"
		Me.txtFilter.Size = New System.Drawing.Size(161, 25)
		Me.txtFilter.Location = New System.Drawing.Point(16, 24)
		Me.txtFilter.TabIndex = 10
		'
		' txtCity
		'
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(97, 25)
		Me.txtCity.Location = New System.Drawing.Point(24, 120)
		Me.txtCity.DataField = "City"
		Me.txtCity.DataSource = MyDataControl1
		Me.txtCity.TabIndex = 7
		'
		' txtState
		'
		Me.txtState.Name = "txtState"
		Me.txtState.Size = New System.Drawing.Size(89, 25)
		Me.txtState.Location = New System.Drawing.Point(152, 120)
		Me.txtState.DataField = "State"
		Me.txtState.DataSource = MyDataControl1
		Me.txtState.TabIndex = 5
		'
		' MyDataControl1
		'
		Me.MyDataControl1.Name = "MyDataControl1"
		Me.MyDataControl1.Size = New System.Drawing.Size(233, 33)
		Me.MyDataControl1.Location = New System.Drawing.Point(24, 240)
		Me.MyDataControl1.TabIndex = 2
		Me.MyDataControl1.RecordSource = "Publishers"
		Me.MyDataControl1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=c:\program files\microsoft visual studio\VB98\Biblio.mdb"
		'
		' txtAddress
		'
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(217, 25)
		Me.txtAddress.Location = New System.Drawing.Point(24, 72)
		Me.txtAddress.DataField = "Address"
		Me.txtAddress.DataSource = MyDataControl1
		Me.txtAddress.TabIndex = 1
		'
		' txtName
		'
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(217, 25)
		Me.txtName.Location = New System.Drawing.Point(24, 24)
		Me.txtName.DataField = "Company Name"
		Me.txtName.DataSource = MyDataControl1
		Me.txtName.TabIndex = 0
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(89, 17)
		Me.Label1_003.Location = New System.Drawing.Point(24, 104)
		Me.Label1_003.Caption = "&City"
		Me.Label1_003.TabIndex = 8
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(169, 17)
		Me.Label1_002.Location = New System.Drawing.Point(152, 104)
		Me.Label1_002.Caption = "&State"
		Me.Label1_002.TabIndex = 6
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(169, 17)
		Me.Label1_001.Location = New System.Drawing.Point(24, 56)
		Me.Label1_001.Caption = "&Address"
		Me.Label1_001.TabIndex = 4
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(169, 17)
		Me.Label1_000.Location = New System.Drawing.Point(24, 8)
		Me.Label1_000.Caption = "Publisher &Name"
		Me.Label1_000.TabIndex = 3
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "MyDataControl Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(271, 295)

		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmdApply)
		Me.Frame1.Controls.Add(txtFilter)
		Me.Controls.Add(txtCity)
		Me.Controls.Add(txtState)
		Me.Controls.Add(MyDataControl1)
		Me.Controls.Add(txtAddress)
		Me.Controls.Add(txtName)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		CType(Me.MyDataControl1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
