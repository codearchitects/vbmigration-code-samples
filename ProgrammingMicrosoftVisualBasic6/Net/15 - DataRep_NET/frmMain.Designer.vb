<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
		Me.optOperation = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optOperation_001, optOperation_000)
		Me.optFormat = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optFormat_001, optFormat_000)
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
	Public optOperation As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public optFormat As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public WithEvents chkShowDetails As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents optOperation_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optOperation_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents cmdCustomers As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOrders As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents optFormat_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optFormat_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.chkShowDetails = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.optOperation_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optOperation_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.cmdCustomers = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOrders = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.optFormat_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optFormat_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' chkShowDetails
		'
		Me.chkShowDetails.Name = "chkShowDetails"
		Me.chkShowDetails.Size = New System.Drawing.Size(145, 17)
		Me.chkShowDetails.Location = New System.Drawing.Point(184, 64)
		Me.chkShowDetails.Caption = "&Show Order Details"
		Me.chkShowDetails.TabIndex = 8
		'
		' optOperation_001
		'
		Me.optOperation_001.Name = "optOperation_001"
		Me.optOperation_001.Size = New System.Drawing.Size(65, 25)
		Me.optOperation_001.Location = New System.Drawing.Point(16, 56)
		Me.optOperation_001.Caption = "&Export"
		Me.optOperation_001.TabIndex = 4
		'
		' optOperation_000
		'
		Me.optOperation_000.Name = "optOperation_000"
		Me.optOperation_000.Size = New System.Drawing.Size(121, 25)
		Me.optOperation_000.Location = New System.Drawing.Point(16, 24)
		Me.optOperation_000.Caption = "&Preview"
		Me.optOperation_000.TabIndex = 3
		'
		' cmdCustomers
		'
		Me.cmdCustomers.Name = "cmdCustomers"
		Me.cmdCustomers.Size = New System.Drawing.Size(129, 33)
		Me.cmdCustomers.Location = New System.Drawing.Point(184, 104)
		Me.cmdCustomers.Caption = "Customers"
		Me.cmdCustomers.TabIndex = 1
		'
		' cmdOrders
		'
		Me.cmdOrders.Name = "cmdOrders"
		Me.cmdOrders.Size = New System.Drawing.Size(129, 33)
		Me.cmdOrders.Location = New System.Drawing.Point(184, 24)
		Me.cmdOrders.Caption = "Orders"
		Me.cmdOrders.TabIndex = 0
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(161, 81)
		Me.Frame1.Location = New System.Drawing.Point(8, 56)
		Me.Frame1.Caption = "Frame1"
		Me.Frame1.TabIndex = 5
		'
		' optFormat_001
		'
		Me.optFormat_001.Name = "optFormat_001"
		Me.optFormat_001.Size = New System.Drawing.Size(113, 17)
		Me.optFormat_001.Location = New System.Drawing.Point(32, 56)
		Me.optFormat_001.Caption = "&Html"
		Me.optFormat_001.TabIndex = 7
		'
		' optFormat_000
		'
		Me.optFormat_000.Name = "optFormat_000"
		Me.optFormat_000.Size = New System.Drawing.Size(113, 17)
		Me.optFormat_000.Location = New System.Drawing.Point(32, 32)
		Me.optFormat_000.Caption = "&Text"
		Me.optFormat_000.TabIndex = 6
		Me.optFormat_000.Value = True
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(201, 25)
		Me.lblStatus.Location = New System.Drawing.Point(0, 168)
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.TabIndex = 2
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "DataReport demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(345, 201)

		Me.Controls.Add(chkShowDetails)
		Me.Controls.Add(optOperation_001)
		Me.Controls.Add(optOperation_000)
		Me.Controls.Add(cmdCustomers)
		Me.Controls.Add(cmdOrders)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(optFormat_001)
		Me.Frame1.Controls.Add(optFormat_000)
		Me.Controls.Add(lblStatus)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
