<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRecord
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
		Me.cmdMove = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMove_008, cmdMove_000, cmdMove_001, cmdMove_002, cmdMove_003, cmdMove_004, cmdMove_005, cmdMove_006, cmdMove_007)
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
	Public WithEvents chkReadOnlyMode As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdMove_008 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFax As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtTelephone As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtState As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtZip As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtCity As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtCompanyName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtAddress As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtID As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdMove_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMove_007 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.chkReadOnlyMode = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdMove_008 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFax = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtTelephone = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtState = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtZip = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtCity = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtCompanyName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtAddress = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtID = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdMove_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMove_007 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' chkReadOnlyMode
		'
		Me.chkReadOnlyMode.Name = "chkReadOnlyMode"
		Me.chkReadOnlyMode.Size = New System.Drawing.Size(121, 17)
		Me.chkReadOnlyMode.Location = New System.Drawing.Point(344, 216)
		Me.chkReadOnlyMode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkReadOnlyMode.Caption = "ReadOnlyMode"
		Me.chkReadOnlyMode.TabIndex = 27
		Me.chkReadOnlyMode.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		'
		' cmdMove_008
		'
		Me.cmdMove_008.Name = "cmdMove_008"
		Me.cmdMove_008.Size = New System.Drawing.Size(89, 33)
		Me.cmdMove_008.Location = New System.Drawing.Point(344, 160)
		Me.cmdMove_008.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_008.Caption = "Flush Data"
		Me.cmdMove_008.TabIndex = 26
		'
		' txtFax
		'
		Me.txtFax.Name = "txtFax"
		Me.txtFax.Size = New System.Drawing.Size(129, 25)
		Me.txtFax.Location = New System.Drawing.Point(336, 112)
		Me.txtFax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFax.DataField = "Fax"
		Me.txtFax.DataMember = "Publishers"
		Me.txtFax.TabIndex = 24
		'
		' txtTelephone
		'
		Me.txtTelephone.Name = "txtTelephone"
		Me.txtTelephone.Size = New System.Drawing.Size(129, 25)
		Me.txtTelephone.Location = New System.Drawing.Point(200, 112)
		Me.txtTelephone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTelephone.DataField = "Telephone"
		Me.txtTelephone.DataMember = "Publishers"
		Me.txtTelephone.TabIndex = 22
		'
		' txtState
		'
		Me.txtState.Name = "txtState"
		Me.txtState.Size = New System.Drawing.Size(129, 25)
		Me.txtState.Location = New System.Drawing.Point(0, 112)
		Me.txtState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtState.DataField = "State"
		Me.txtState.DataMember = "Publishers"
		Me.txtState.TabIndex = 20
		'
		' txtZip
		'
		Me.txtZip.Name = "txtZip"
		Me.txtZip.Size = New System.Drawing.Size(57, 25)
		Me.txtZip.Location = New System.Drawing.Point(136, 112)
		Me.txtZip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtZip.DataField = "Zip"
		Me.txtZip.DataMember = "Publishers"
		Me.txtZip.TabIndex = 18
		'
		' txtCity
		'
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Size = New System.Drawing.Size(129, 25)
		Me.txtCity.Location = New System.Drawing.Point(336, 64)
		Me.txtCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCity.DataField = "City"
		Me.txtCity.DataMember = "Publishers"
		Me.txtCity.TabIndex = 16
		'
		' txtCompanyName
		'
		Me.txtCompanyName.Name = "txtCompanyName"
		Me.txtCompanyName.Size = New System.Drawing.Size(273, 25)
		Me.txtCompanyName.Location = New System.Drawing.Point(192, 16)
		Me.txtCompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCompanyName.DataField = "Company Name"
		Me.txtCompanyName.DataMember = "Publishers"
		Me.txtCompanyName.TabIndex = 14
		'
		' txtName
		'
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(129, 25)
		Me.txtName.Location = New System.Drawing.Point(56, 16)
		Me.txtName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.DataField = "Name"
		Me.txtName.DataMember = "Publishers"
		Me.txtName.TabIndex = 10
		'
		' txtAddress
		'
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(329, 25)
		Me.txtAddress.Location = New System.Drawing.Point(0, 64)
		Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.DataField = "Address"
		Me.txtAddress.DataMember = "Publishers"
		Me.txtAddress.TabIndex = 9
		'
		' txtID
		'
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(49, 25)
		Me.txtID.Location = New System.Drawing.Point(0, 16)
		Me.txtID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtID.DataField = "PubID"
		Me.txtID.DataMember = "Publishers"
		Me.txtID.TabIndex = 8
		'
		' cmdMove_000
		'
		Me.cmdMove_000.Name = "cmdMove_000"
		Me.cmdMove_000.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_000.Location = New System.Drawing.Point(-8, 160)
		Me.cmdMove_000.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_000.Caption = "<<"
		Me.cmdMove_000.TabIndex = 7
		'
		' cmdMove_001
		'
		Me.cmdMove_001.Name = "cmdMove_001"
		Me.cmdMove_001.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_001.Location = New System.Drawing.Point(40, 160)
		Me.cmdMove_001.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_001.Caption = "<"
		Me.cmdMove_001.TabIndex = 6
		'
		' cmdMove_002
		'
		Me.cmdMove_002.Name = "cmdMove_002"
		Me.cmdMove_002.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_002.Location = New System.Drawing.Point(88, 160)
		Me.cmdMove_002.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_002.Caption = ">"
		Me.cmdMove_002.TabIndex = 5
		'
		' cmdMove_003
		'
		Me.cmdMove_003.Name = "cmdMove_003"
		Me.cmdMove_003.Size = New System.Drawing.Size(49, 33)
		Me.cmdMove_003.Location = New System.Drawing.Point(136, 160)
		Me.cmdMove_003.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_003.Caption = ">>"
		Me.cmdMove_003.TabIndex = 4
		'
		' cmdMove_004
		'
		Me.cmdMove_004.Name = "cmdMove_004"
		Me.cmdMove_004.Size = New System.Drawing.Size(65, 33)
		Me.cmdMove_004.Location = New System.Drawing.Point(200, 160)
		Me.cmdMove_004.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_004.Caption = "Add"
		Me.cmdMove_004.TabIndex = 3
		'
		' cmdMove_005
		'
		Me.cmdMove_005.Name = "cmdMove_005"
		Me.cmdMove_005.Size = New System.Drawing.Size(65, 33)
		Me.cmdMove_005.Location = New System.Drawing.Point(264, 160)
		Me.cmdMove_005.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_005.Caption = "Delete"
		Me.cmdMove_005.TabIndex = 2
		'
		' cmdMove_006
		'
		Me.cmdMove_006.Name = "cmdMove_006"
		Me.cmdMove_006.Size = New System.Drawing.Size(121, 33)
		Me.cmdMove_006.Location = New System.Drawing.Point(24, 208)
		Me.cmdMove_006.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_006.Caption = "Set Bookmark"
		Me.cmdMove_006.TabIndex = 1
		'
		' cmdMove_007
		'
		Me.cmdMove_007.Name = "cmdMove_007"
		Me.cmdMove_007.Size = New System.Drawing.Size(121, 33)
		Me.cmdMove_007.Location = New System.Drawing.Point(144, 208)
		Me.cmdMove_007.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMove_007.Caption = "Goto Bookmark"
		Me.cmdMove_007.TabIndex = 0
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(73, 17)
		Me.Label9.Location = New System.Drawing.Point(336, 96)
		Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Caption = "&Fax"
		Me.Label9.TabIndex = 25
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.Location = New System.Drawing.Point(200, 96)
		Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Caption = "&Telephone"
		Me.Label8.TabIndex = 23
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(105, 17)
		Me.Label7.Location = New System.Drawing.Point(0, 96)
		Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Caption = "&State"
		Me.Label7.TabIndex = 21
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(57, 17)
		Me.Label6.Location = New System.Drawing.Point(136, 96)
		Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Caption = "&Zip"
		Me.Label6.TabIndex = 19
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(113, 17)
		Me.Label5.Location = New System.Drawing.Point(336, 48)
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Caption = "Cit&y"
		Me.Label5.TabIndex = 17
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(145, 17)
		Me.Label4.Location = New System.Drawing.Point(192, 0)
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Caption = "&Company Name"
		Me.Label4.TabIndex = 15
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 17)
		Me.Label1.Location = New System.Drawing.Point(56, 0)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Caption = "&Name"
		Me.Label1.TabIndex = 13
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 17)
		Me.Label2.Location = New System.Drawing.Point(0, 48)
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Caption = "&Address"
		Me.Label2.TabIndex = 12
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(89, 17)
		Me.Label3.Location = New System.Drawing.Point(0, 0)
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Caption = "PubID"
		Me.Label3.TabIndex = 11
		'
		' frmRecord
		'
		Me.Name = "frmRecord"
		Me.Caption = "TextFileDataSource Demo - Record View"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(476, 254)

		Me.Controls.Add(chkReadOnlyMode)
		Me.Controls.Add(cmdMove_008)
		Me.Controls.Add(txtFax)
		Me.Controls.Add(txtTelephone)
		Me.Controls.Add(txtState)
		Me.Controls.Add(txtZip)
		Me.Controls.Add(txtCity)
		Me.Controls.Add(txtCompanyName)
		Me.Controls.Add(txtName)
		Me.Controls.Add(txtAddress)
		Me.Controls.Add(txtID)
		Me.Controls.Add(cmdMove_000)
		Me.Controls.Add(cmdMove_001)
		Me.Controls.Add(cmdMove_002)
		Me.Controls.Add(cmdMove_003)
		Me.Controls.Add(cmdMove_004)
		Me.Controls.Add(cmdMove_005)
		Me.Controls.Add(cmdMove_006)
		Me.Controls.Add(cmdMove_007)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label8)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label3)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
