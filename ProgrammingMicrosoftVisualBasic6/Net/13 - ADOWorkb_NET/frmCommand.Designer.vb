<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCommand
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
		Me.cmdMethod = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMethod_002, cmdMethod_001, cmdMethod_000)
		Me.lblProperty = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblProperty_002, lblProperty_003, lblProperty_009, lblProperty_007, lblProperty_004, lblProperty_001)
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
	Public cmdMethod As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public lblProperty As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdDefineConnection As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowRecordset As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboCommandType As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdMethod_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdShowParameters As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetProperties As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboState As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboPrepared As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCustomProperty As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lstCustomProperties As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents txtCommandTimeout As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtCommandText As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblProperty_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCustomProperty As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_001 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdDefineConnection = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowRecordset = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboCommandType = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdMethod_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdShowParameters = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetProperties = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboState = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboPrepared = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCustomProperty = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lstCustomProperties = New CodeArchitects.VB6Library.VB6ListBox()
		Me.txtCommandTimeout = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtCommandText = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblProperty_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCustomProperty = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdDefineConnection
		'
		Me.cmdDefineConnection.Name = "cmdDefineConnection"
		Me.cmdDefineConnection.Size = New System.Drawing.Size(137, 25)
		Me.cmdDefineConnection.Location = New System.Drawing.Point(8, 200)
		Me.cmdDefineConnection.Caption = "Define Connection"
		Me.cmdDefineConnection.TabIndex = 22
		'
		' cmdShowRecordset
		'
		Me.cmdShowRecordset.Name = "cmdShowRecordset"
		Me.cmdShowRecordset.Size = New System.Drawing.Size(137, 25)
		Me.cmdShowRecordset.Location = New System.Drawing.Point(168, 232)
		Me.cmdShowRecordset.Caption = "Show Recordset"
		Me.cmdShowRecordset.Enabled = False
		Me.cmdShowRecordset.TabIndex = 21
		'
		' cboCommandType
		'
		Me.cboCommandType.Name = "cboCommandType"
		Me.cboCommandType.Size = New System.Drawing.Size(169, 24)
		Me.cboCommandType.Location = New System.Drawing.Point(136, 56)
		Me.cboCommandType.TabIndex = 19
		'
		' cmdMethod_002
		'
		Me.cmdMethod_002.Name = "cmdMethod_002"
		Me.cmdMethod_002.Size = New System.Drawing.Size(137, 25)
		Me.cmdMethod_002.Location = New System.Drawing.Point(168, 160)
		Me.cmdMethod_002.Caption = "CreateParameter"
		Me.cmdMethod_002.TabIndex = 18
		'
		' txtName
		'
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(169, 24)
		Me.txtName.Location = New System.Drawing.Point(136, 80)
		Me.txtName.TabIndex = 16
		'
		' cmdShowParameters
		'
		Me.cmdShowParameters.Name = "cmdShowParameters"
		Me.cmdShowParameters.Size = New System.Drawing.Size(137, 25)
		Me.cmdShowParameters.Location = New System.Drawing.Point(168, 200)
		Me.cmdShowParameters.Caption = "Show Parameters"
		Me.cmdShowParameters.TabIndex = 15
		'
		' cmdMethod_001
		'
		Me.cmdMethod_001.Name = "cmdMethod_001"
		Me.cmdMethod_001.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_001.Location = New System.Drawing.Point(88, 160)
		Me.cmdMethod_001.Caption = "Cancel"
		Me.cmdMethod_001.TabIndex = 14
		'
		' cmdMethod_000
		'
		Me.cmdMethod_000.Name = "cmdMethod_000"
		Me.cmdMethod_000.Size = New System.Drawing.Size(81, 25)
		Me.cmdMethod_000.Location = New System.Drawing.Point(8, 160)
		Me.cmdMethod_000.Caption = "Execute"
		Me.cmdMethod_000.TabIndex = 13
		'
		' cmdSetProperties
		'
		Me.cmdSetProperties.Name = "cmdSetProperties"
		Me.cmdSetProperties.Size = New System.Drawing.Size(121, 25)
		Me.cmdSetProperties.Location = New System.Drawing.Point(320, 8)
		Me.cmdSetProperties.Caption = "Set &Properties"
		Me.cmdSetProperties.TabIndex = 12
		'
		' cboState
		'
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(169, 24)
		Me.cboState.Location = New System.Drawing.Point(136, 128)
		Me.cboState.Locked6 = True
		Me.cboState.TabIndex = 11
		'
		' cboPrepared
		'
		Me.cboPrepared.Name = "cboPrepared"
		Me.cboPrepared.Size = New System.Drawing.Size(169, 24)
		Me.cboPrepared.Location = New System.Drawing.Point(136, 104)
		Me.cboPrepared.TabIndex = 10
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(57, 25)
		Me.cmdSet.Location = New System.Drawing.Point(496, 72)
		Me.cmdSet.Caption = "&Set"
		Me.cmdSet.TabIndex = 9
		'
		' txtCustomProperty
		'
		Me.txtCustomProperty.Name = "txtCustomProperty"
		Me.txtCustomProperty.Size = New System.Drawing.Size(177, 25)
		Me.txtCustomProperty.Location = New System.Drawing.Point(320, 72)
		Me.txtCustomProperty.TabIndex = 7
		'
		' lstCustomProperties
		'
		Me.lstCustomProperties.Name = "lstCustomProperties"
		Me.lstCustomProperties.Size = New System.Drawing.Size(233, 148)
		Me.lstCustomProperties.Location = New System.Drawing.Point(320, 104)
		Me.lstCustomProperties.Sorted = True
		Me.lstCustomProperties.TabIndex = 6
		'
		' txtCommandTimeout
		'
		Me.txtCommandTimeout.Name = "txtCommandTimeout"
		Me.txtCommandTimeout.Size = New System.Drawing.Size(169, 24)
		Me.txtCommandTimeout.Location = New System.Drawing.Point(136, 32)
		Me.txtCommandTimeout.TabIndex = 3
		'
		' txtCommandText
		'
		Me.txtCommandText.Name = "txtCommandText"
		Me.txtCommandText.Size = New System.Drawing.Size(169, 24)
		Me.txtCommandText.Location = New System.Drawing.Point(136, 8)
		Me.txtCommandText.TabIndex = 1
		'
		' lblProperty_002
		'
		Me.lblProperty_002.Name = "lblProperty_002"
		Me.lblProperty_002.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_002.Location = New System.Drawing.Point(8, 56)
		Me.lblProperty_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_002.Caption = "CommadType"
		Me.lblProperty_002.TabIndex = 20
		'
		' lblProperty_003
		'
		Me.lblProperty_003.Name = "lblProperty_003"
		Me.lblProperty_003.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_003.Location = New System.Drawing.Point(8, 80)
		Me.lblProperty_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_003.Caption = "Name"
		Me.lblProperty_003.TabIndex = 17
		'
		' lblCustomProperty
		'
		Me.lblCustomProperty.Name = "lblCustomProperty"
		Me.lblCustomProperty.Size = New System.Drawing.Size(233, 25)
		Me.lblCustomProperty.Location = New System.Drawing.Point(320, 48)
		Me.lblCustomProperty.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblCustomProperty.Caption = "Custom Properties"
		Me.lblCustomProperty.TabIndex = 8
		'
		' lblProperty_009
		'
		Me.lblProperty_009.Name = "lblProperty_009"
		Me.lblProperty_009.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_009.Location = New System.Drawing.Point(8, 128)
		Me.lblProperty_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_009.Caption = "State"
		Me.lblProperty_009.TabIndex = 5
		'
		' lblProperty_007
		'
		Me.lblProperty_007.Name = "lblProperty_007"
		Me.lblProperty_007.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_007.Location = New System.Drawing.Point(8, 104)
		Me.lblProperty_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_007.Caption = "Prepared"
		Me.lblProperty_007.TabIndex = 4
		'
		' lblProperty_004
		'
		Me.lblProperty_004.Name = "lblProperty_004"
		Me.lblProperty_004.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_004.Location = New System.Drawing.Point(8, 32)
		Me.lblProperty_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_004.Caption = "CommandTimeout"
		Me.lblProperty_004.TabIndex = 2
		'
		' lblProperty_001
		'
		Me.lblProperty_001.Name = "lblProperty_001"
		Me.lblProperty_001.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_001.Location = New System.Drawing.Point(8, 8)
		Me.lblProperty_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_001.Caption = "CommandText"
		Me.lblProperty_001.TabIndex = 0
		'
		' frmCommand
		'
		Me.Name = "frmCommand"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Command"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(565, 261)

		Me.Controls.Add(cmdDefineConnection)
		Me.Controls.Add(cmdShowRecordset)
		Me.Controls.Add(cboCommandType)
		Me.Controls.Add(cmdMethod_002)
		Me.Controls.Add(txtName)
		Me.Controls.Add(cmdShowParameters)
		Me.Controls.Add(cmdMethod_001)
		Me.Controls.Add(cmdMethod_000)
		Me.Controls.Add(cmdSetProperties)
		Me.Controls.Add(cboState)
		Me.Controls.Add(cboPrepared)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(txtCustomProperty)
		Me.Controls.Add(lstCustomProperties)
		Me.Controls.Add(txtCommandTimeout)
		Me.Controls.Add(txtCommandText)
		Me.Controls.Add(lblProperty_002)
		Me.Controls.Add(lblProperty_003)
		Me.Controls.Add(lblCustomProperty)
		Me.Controls.Add(lblProperty_009)
		Me.Controls.Add(lblProperty_007)
		Me.Controls.Add(lblProperty_004)
		Me.Controls.Add(lblProperty_001)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
