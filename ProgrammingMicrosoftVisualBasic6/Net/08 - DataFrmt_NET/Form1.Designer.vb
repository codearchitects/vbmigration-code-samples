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
		Me.optFreight = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optFreight_001, optFreight_000)
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
	Public optFreight As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents optFreight_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optFreight_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents txtFreight As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtOrderID As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtShippedDate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtOrderDate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Adodc1 As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.optFreight_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optFreight_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.txtFreight = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtOrderID = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtShippedDate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtOrderDate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' optFreight_001
		'
		Me.optFreight_001.Name = "optFreight_001"
		Me.optFreight_001.Size = New System.Drawing.Size(73, 17)
		Me.optFreight_001.Location = New System.Drawing.Point(328, 176)
		Me.optFreight_001.Caption = "Euros"
		Me.optFreight_001.TabIndex = 9
		'
		' optFreight_000
		'
		Me.optFreight_000.Name = "optFreight_000"
		Me.optFreight_000.Size = New System.Drawing.Size(73, 17)
		Me.optFreight_000.Location = New System.Drawing.Point(328, 160)
		Me.optFreight_000.Caption = "Dollars"
		Me.optFreight_000.TabIndex = 8
		Me.optFreight_000.Value = True
		'
		' txtFreight
		'
		Me.txtFreight.Name = "txtFreight"
		Me.txtFreight.Size = New System.Drawing.Size(161, 25)
		Me.txtFreight.Location = New System.Drawing.Point(160, 160)
		Me.txtFreight.DataField = "Freight"
		Me.txtFreight.DataSource = Adodc1
		Me.txtFreight.TabIndex = 4
		'
		' txtOrderID
		'
		Me.txtOrderID.Name = "txtOrderID"
		Me.txtOrderID.Size = New System.Drawing.Size(161, 25)
		Me.txtOrderID.Location = New System.Drawing.Point(160, 16)
		Me.txtOrderID.DataField = "OrderID"
		Me.txtOrderID.DataSource = Adodc1
		Me.txtOrderID.TabIndex = 3
		'
		' txtShippedDate
		'
		Me.txtShippedDate.Name = "txtShippedDate"
		Me.txtShippedDate.Size = New System.Drawing.Size(161, 25)
		Me.txtShippedDate.Location = New System.Drawing.Point(160, 112)
		Me.txtShippedDate.DataField = "ShippedDate"
		Me.txtShippedDate.DataSource = Adodc1
		Me.txtShippedDate.TabIndex = 2
		'
		' txtOrderDate
		'
		Me.txtOrderDate.Name = "txtOrderDate"
		Me.txtOrderDate.Size = New System.Drawing.Size(161, 25)
		Me.txtOrderDate.Location = New System.Drawing.Point(160, 64)
		Me.txtOrderDate.DataField = "OrderDate"
		Me.txtOrderDate.DataSource = Adodc1
		Me.txtOrderDate.TabIndex = 1
		Me.txtOrderDate.DataFormatValues = "1°@°MMMM d, yyyy°@°True°@°False°@°°@°0°@°0"
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(455, 25)
		Me.Adodc1.Location = New System.Drawing.Point(0, 215)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.Adodc1.ConnectMode = ADODB.ConnectModeEnum.adModeUnknown
		Me.Adodc1.CursorLocation = CodeArchitects.VB6Library.MSAdodcLib.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = CodeArchitects.VB6Library.MSAdodcLib.CursorTypeEnum.adOpenStatic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = CodeArchitects.VB6Library.MSAdodcLib.CommandTypeEnum.adCmdTable
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = CodeArchitects.VB6Library.MSAdodcLib.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.Adodc1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.Adodc1.Enabled = True
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = "Orders"
		Me.Adodc1.Caption = "Adodc1"
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(145, 25)
		Me.Label1_003.Location = New System.Drawing.Point(8, 160)
		Me.Label1_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_003.Caption = "Freight"
		Me.Label1_003.TabIndex = 7
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(145, 25)
		Me.Label1_002.Location = New System.Drawing.Point(8, 112)
		Me.Label1_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_002.Caption = "Shipped Date"
		Me.Label1_002.TabIndex = 6
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(145, 25)
		Me.Label1_001.Location = New System.Drawing.Point(8, 64)
		Me.Label1_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_001.Caption = "Order Date"
		Me.Label1_001.TabIndex = 5
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(145, 25)
		Me.Label1_000.Location = New System.Drawing.Point(8, 16)
		Me.Label1_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1_000.Caption = "OrderID"
		Me.Label1_000.TabIndex = 0
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "DataFormat and StdDataFormat objects"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(455, 240)

		Me.Controls.Add(optFreight_001)
		Me.Controls.Add(optFreight_000)
		Me.Controls.Add(txtFreight)
		Me.Controls.Add(txtOrderID)
		Me.Controls.Add(txtShippedDate)
		Me.Controls.Add(txtOrderDate)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		Me.Controls.SetChildIndex(Me.Adodc1, 0)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
