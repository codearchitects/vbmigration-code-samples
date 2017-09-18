<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConnection
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
		Me.cmdMethod = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMethod_006, cmdMethod_005, cmdMethod_004, cmdMethod_003, cmdMethod_002, cmdMethod_001, cmdMethod_000)
		Me.lblProperty = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblProperty_010, lblProperty_009, lblProperty_008, lblProperty_007, lblProperty_006, lblProperty_005, lblProperty_004, lblProperty_003, lblProperty_002, lblProperty_001, lblProperty_000)
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
	Public WithEvents cmdShowRecordset As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowErrors As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdClear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtEvents As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdMethod_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetProperties As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboCursorLocation As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboAttributes As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboState As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboIsolationLevel As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboMode As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCustomProperty As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lstCustomProperties As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents txtVersion As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtProvider As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtConnectionTimeout As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtConnectionString As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtDefaultDatabase As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtCommandTimeout As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblCustomProperty As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdShowRecordset = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowErrors = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdClear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtEvents = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdMethod_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetProperties = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboCursorLocation = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboAttributes = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboState = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboIsolationLevel = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboMode = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCustomProperty = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lstCustomProperties = New CodeArchitects.VB6Library.VB6ListBox()
		Me.txtVersion = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtProvider = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtConnectionTimeout = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtConnectionString = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtDefaultDatabase = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtCommandTimeout = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblCustomProperty = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdShowRecordset
		'
		Me.cmdShowRecordset.Name = "cmdShowRecordset"
		Me.cmdShowRecordset.Size = New System.Drawing.Size(121, 25)
		Me.cmdShowRecordset.Location = New System.Drawing.Point(432, 320)
		Me.cmdShowRecordset.Caption = "Show Recordset"
		Me.cmdShowRecordset.TabIndex = 37
		'
		' cmdShowErrors
		'
		Me.cmdShowErrors.Name = "cmdShowErrors"
		Me.cmdShowErrors.Size = New System.Drawing.Size(121, 25)
		Me.cmdShowErrors.Location = New System.Drawing.Point(432, 288)
		Me.cmdShowErrors.Caption = "Show &Errors"
		Me.cmdShowErrors.TabIndex = 36
		'
		' cmdClear
		'
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.Size = New System.Drawing.Size(57, 25)
		Me.cmdClear.Location = New System.Drawing.Point(504, 360)
		Me.cmdClear.Caption = "Clear"
		Me.cmdClear.TabIndex = 35
		'
		' txtEvents
		'
		Me.txtEvents.Name = "txtEvents"
		Me.txtEvents.Size = New System.Drawing.Size(489, 89)
		Me.txtEvents.Location = New System.Drawing.Point(8, 360)
		Me.txtEvents.MultiLine = -1
		Me.txtEvents.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtEvents.TabIndex = 34
		'
		' cmdMethod_006
		'
		Me.cmdMethod_006.Name = "cmdMethod_006"
		Me.cmdMethod_006.Size = New System.Drawing.Size(89, 25)
		Me.cmdMethod_006.Location = New System.Drawing.Point(256, 288)
		Me.cmdMethod_006.Caption = "Cancel"
		Me.cmdMethod_006.TabIndex = 33
		'
		' cmdMethod_005
		'
		Me.cmdMethod_005.Name = "cmdMethod_005"
		Me.cmdMethod_005.Size = New System.Drawing.Size(89, 25)
		Me.cmdMethod_005.Location = New System.Drawing.Point(168, 288)
		Me.cmdMethod_005.Caption = "Execute"
		Me.cmdMethod_005.TabIndex = 32
		'
		' cmdMethod_004
		'
		Me.cmdMethod_004.Name = "cmdMethod_004"
		Me.cmdMethod_004.Size = New System.Drawing.Size(113, 25)
		Me.cmdMethod_004.Location = New System.Drawing.Point(232, 320)
		Me.cmdMethod_004.Caption = "RollbackTrans"
		Me.cmdMethod_004.TabIndex = 31
		'
		' cmdMethod_003
		'
		Me.cmdMethod_003.Name = "cmdMethod_003"
		Me.cmdMethod_003.Size = New System.Drawing.Size(113, 25)
		Me.cmdMethod_003.Location = New System.Drawing.Point(120, 320)
		Me.cmdMethod_003.Caption = "CommitTrans"
		Me.cmdMethod_003.TabIndex = 30
		'
		' cmdMethod_002
		'
		Me.cmdMethod_002.Name = "cmdMethod_002"
		Me.cmdMethod_002.Size = New System.Drawing.Size(113, 25)
		Me.cmdMethod_002.Location = New System.Drawing.Point(8, 320)
		Me.cmdMethod_002.Caption = "BeginTrans"
		Me.cmdMethod_002.TabIndex = 29
		'
		' cmdMethod_001
		'
		Me.cmdMethod_001.Name = "cmdMethod_001"
		Me.cmdMethod_001.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_001.Location = New System.Drawing.Point(80, 288)
		Me.cmdMethod_001.Caption = "Close"
		Me.cmdMethod_001.TabIndex = 28
		'
		' cmdMethod_000
		'
		Me.cmdMethod_000.Name = "cmdMethod_000"
		Me.cmdMethod_000.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_000.Location = New System.Drawing.Point(8, 288)
		Me.cmdMethod_000.Caption = "&Open"
		Me.cmdMethod_000.TabIndex = 27
		'
		' cmdSetProperties
		'
		Me.cmdSetProperties.Name = "cmdSetProperties"
		Me.cmdSetProperties.Size = New System.Drawing.Size(121, 25)
		Me.cmdSetProperties.Location = New System.Drawing.Point(320, 8)
		Me.cmdSetProperties.Caption = "Set &Properties"
		Me.cmdSetProperties.TabIndex = 26
		'
		' cboCursorLocation
		'
		Me.cboCursorLocation.Name = "cboCursorLocation"
		Me.cboCursorLocation.Size = New System.Drawing.Size(169, 24)
		Me.cboCursorLocation.Location = New System.Drawing.Point(136, 104)
		Me.cboCursorLocation.TabIndex = 25
		'
		' cboAttributes
		'
		Me.cboAttributes.Name = "cboAttributes"
		Me.cboAttributes.Size = New System.Drawing.Size(169, 24)
		Me.cboAttributes.Location = New System.Drawing.Point(136, 8)
		Me.cboAttributes.TabIndex = 24
		'
		' cboState
		'
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(169, 24)
		Me.cboState.Location = New System.Drawing.Point(136, 224)
		Me.cboState.Locked6 = True
		Me.cboState.TabIndex = 23
		'
		' cboIsolationLevel
		'
		Me.cboIsolationLevel.Name = "cboIsolationLevel"
		Me.cboIsolationLevel.Size = New System.Drawing.Size(169, 24)
		Me.cboIsolationLevel.Location = New System.Drawing.Point(136, 176)
		Me.cboIsolationLevel.TabIndex = 22
		'
		' cboMode
		'
		Me.cboMode.Name = "cboMode"
		Me.cboMode.Size = New System.Drawing.Size(169, 24)
		Me.cboMode.Location = New System.Drawing.Point(136, 200)
		Me.cboMode.TabIndex = 21
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(57, 25)
		Me.cmdSet.Location = New System.Drawing.Point(496, 72)
		Me.cmdSet.Caption = "&Set"
		Me.cmdSet.TabIndex = 20
		'
		' txtCustomProperty
		'
		Me.txtCustomProperty.Name = "txtCustomProperty"
		Me.txtCustomProperty.Size = New System.Drawing.Size(177, 25)
		Me.txtCustomProperty.Location = New System.Drawing.Point(320, 72)
		Me.txtCustomProperty.TabIndex = 18
		'
		' lstCustomProperties
		'
		Me.lstCustomProperties.Name = "lstCustomProperties"
		Me.lstCustomProperties.Size = New System.Drawing.Size(233, 164)
		Me.lstCustomProperties.Location = New System.Drawing.Point(320, 104)
		Me.lstCustomProperties.Sorted = True
		Me.lstCustomProperties.TabIndex = 17
		'
		' txtVersion
		'
		Me.txtVersion.Name = "txtVersion"
		Me.txtVersion.Size = New System.Drawing.Size(169, 24)
		Me.txtVersion.Location = New System.Drawing.Point(136, 248)
		Me.txtVersion.ReadOnly = True
		Me.txtVersion.TabIndex = 16
		'
		' txtProvider
		'
		Me.txtProvider.Name = "txtProvider"
		Me.txtProvider.Size = New System.Drawing.Size(169, 24)
		Me.txtProvider.Location = New System.Drawing.Point(136, 152)
		Me.txtProvider.TabIndex = 10
		'
		' txtConnectionTimeout
		'
		Me.txtConnectionTimeout.Name = "txtConnectionTimeout"
		Me.txtConnectionTimeout.Size = New System.Drawing.Size(169, 24)
		Me.txtConnectionTimeout.Location = New System.Drawing.Point(136, 80)
		Me.txtConnectionTimeout.TabIndex = 8
		'
		' txtConnectionString
		'
		Me.txtConnectionString.Name = "txtConnectionString"
		Me.txtConnectionString.Size = New System.Drawing.Size(169, 24)
		Me.txtConnectionString.Location = New System.Drawing.Point(136, 56)
		Me.txtConnectionString.TabIndex = 6
		'
		' txtDefaultDatabase
		'
		Me.txtDefaultDatabase.Name = "txtDefaultDatabase"
		Me.txtDefaultDatabase.Size = New System.Drawing.Size(169, 24)
		Me.txtDefaultDatabase.Location = New System.Drawing.Point(136, 128)
		Me.txtDefaultDatabase.TabIndex = 4
		'
		' txtCommandTimeout
		'
		Me.txtCommandTimeout.Name = "txtCommandTimeout"
		Me.txtCommandTimeout.Size = New System.Drawing.Size(169, 24)
		Me.txtCommandTimeout.Location = New System.Drawing.Point(136, 32)
		Me.txtCommandTimeout.TabIndex = 2
		'
		' lblCustomProperty
		'
		Me.lblCustomProperty.Name = "lblCustomProperty"
		Me.lblCustomProperty.Size = New System.Drawing.Size(233, 25)
		Me.lblCustomProperty.Location = New System.Drawing.Point(320, 48)
		Me.lblCustomProperty.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblCustomProperty.Caption = "Custom Properties"
		Me.lblCustomProperty.TabIndex = 19
		'
		' lblProperty_010
		'
		Me.lblProperty_010.Name = "lblProperty_010"
		Me.lblProperty_010.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_010.Location = New System.Drawing.Point(8, 248)
		Me.lblProperty_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_010.Caption = "Version"
		Me.lblProperty_010.TabIndex = 15
		'
		' lblProperty_009
		'
		Me.lblProperty_009.Name = "lblProperty_009"
		Me.lblProperty_009.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_009.Location = New System.Drawing.Point(8, 224)
		Me.lblProperty_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_009.Caption = "State"
		Me.lblProperty_009.TabIndex = 14
		'
		' lblProperty_008
		'
		Me.lblProperty_008.Name = "lblProperty_008"
		Me.lblProperty_008.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_008.Location = New System.Drawing.Point(8, 200)
		Me.lblProperty_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_008.Caption = "Mode"
		Me.lblProperty_008.TabIndex = 13
		'
		' lblProperty_007
		'
		Me.lblProperty_007.Name = "lblProperty_007"
		Me.lblProperty_007.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_007.Location = New System.Drawing.Point(8, 176)
		Me.lblProperty_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_007.Caption = "IsolationLevel"
		Me.lblProperty_007.TabIndex = 12
		'
		' lblProperty_006
		'
		Me.lblProperty_006.Name = "lblProperty_006"
		Me.lblProperty_006.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_006.Location = New System.Drawing.Point(8, 104)
		Me.lblProperty_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_006.Caption = "CursorLocation"
		Me.lblProperty_006.TabIndex = 11
		'
		' lblProperty_005
		'
		Me.lblProperty_005.Name = "lblProperty_005"
		Me.lblProperty_005.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_005.Location = New System.Drawing.Point(8, 152)
		Me.lblProperty_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_005.Caption = "Provider"
		Me.lblProperty_005.TabIndex = 9
		'
		' lblProperty_004
		'
		Me.lblProperty_004.Name = "lblProperty_004"
		Me.lblProperty_004.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_004.Location = New System.Drawing.Point(8, 80)
		Me.lblProperty_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_004.Caption = "ConnectionTimeout"
		Me.lblProperty_004.TabIndex = 7
		'
		' lblProperty_003
		'
		Me.lblProperty_003.Name = "lblProperty_003"
		Me.lblProperty_003.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_003.Location = New System.Drawing.Point(8, 56)
		Me.lblProperty_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_003.Caption = "ConnectionString"
		Me.lblProperty_003.TabIndex = 5
		'
		' lblProperty_002
		'
		Me.lblProperty_002.Name = "lblProperty_002"
		Me.lblProperty_002.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_002.Location = New System.Drawing.Point(8, 128)
		Me.lblProperty_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_002.Caption = "DefaultDatabase"
		Me.lblProperty_002.TabIndex = 3
		'
		' lblProperty_001
		'
		Me.lblProperty_001.Name = "lblProperty_001"
		Me.lblProperty_001.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_001.Location = New System.Drawing.Point(8, 32)
		Me.lblProperty_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_001.Caption = "CommandTimeout"
		Me.lblProperty_001.TabIndex = 1
		'
		' lblProperty_000
		'
		Me.lblProperty_000.Name = "lblProperty_000"
		Me.lblProperty_000.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_000.Location = New System.Drawing.Point(8, 8)
		Me.lblProperty_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_000.Caption = "Attributes"
		Me.lblProperty_000.TabIndex = 0
		'
		' frmConnection
		'
		Me.Name = "frmConnection"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Connection"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(567, 457)

		Me.Controls.Add(cmdShowRecordset)
		Me.Controls.Add(cmdShowErrors)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(txtEvents)
		Me.Controls.Add(cmdMethod_006)
		Me.Controls.Add(cmdMethod_005)
		Me.Controls.Add(cmdMethod_004)
		Me.Controls.Add(cmdMethod_003)
		Me.Controls.Add(cmdMethod_002)
		Me.Controls.Add(cmdMethod_001)
		Me.Controls.Add(cmdMethod_000)
		Me.Controls.Add(cmdSetProperties)
		Me.Controls.Add(cboCursorLocation)
		Me.Controls.Add(cboAttributes)
		Me.Controls.Add(cboState)
		Me.Controls.Add(cboIsolationLevel)
		Me.Controls.Add(cboMode)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(txtCustomProperty)
		Me.Controls.Add(lstCustomProperties)
		Me.Controls.Add(txtVersion)
		Me.Controls.Add(txtProvider)
		Me.Controls.Add(txtConnectionTimeout)
		Me.Controls.Add(txtConnectionString)
		Me.Controls.Add(txtDefaultDatabase)
		Me.Controls.Add(txtCommandTimeout)
		Me.Controls.Add(lblCustomProperty)
		Me.Controls.Add(lblProperty_010)
		Me.Controls.Add(lblProperty_009)
		Me.Controls.Add(lblProperty_008)
		Me.Controls.Add(lblProperty_007)
		Me.Controls.Add(lblProperty_006)
		Me.Controls.Add(lblProperty_005)
		Me.Controls.Add(lblProperty_004)
		Me.Controls.Add(lblProperty_003)
		Me.Controls.Add(lblProperty_002)
		Me.Controls.Add(lblProperty_001)
		Me.Controls.Add(lblProperty_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
