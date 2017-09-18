<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFields
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
		Me.lblProperty = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblProperty_009, lblProperty_008, lblProperty_007, lblProperty_006, lblProperty_005, lblProperty_004, lblProperty_003, lblProperty_002, lblProperty_001, lblProperty_000)
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
	Public lblProperty As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents txtUnderlyingValue As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtValue As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtNumericScale As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboAttributes As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdSetProperties As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboName As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboType As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCustomProperty As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lstCustomProperties As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents txtPrecision As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtDefinedSize As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtOriginalValue As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtActualSize As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblCustomProperty As CodeArchitects.VB6Library.VB6Label
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
		Me.txtUnderlyingValue = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtValue = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtNumericScale = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboAttributes = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdSetProperties = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboName = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboType = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCustomProperty = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lstCustomProperties = New CodeArchitects.VB6Library.VB6ListBox()
		Me.txtPrecision = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtDefinedSize = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtOriginalValue = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtActualSize = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblCustomProperty = New CodeArchitects.VB6Library.VB6Label()
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
		' txtUnderlyingValue
		'
		Me.txtUnderlyingValue.Name = "txtUnderlyingValue"
		Me.txtUnderlyingValue.Size = New System.Drawing.Size(169, 24)
		Me.txtUnderlyingValue.Location = New System.Drawing.Point(136, 224)
		Me.txtUnderlyingValue.ReadOnly = True
		Me.txtUnderlyingValue.TabIndex = 24
		'
		' txtValue
		'
		Me.txtValue.Name = "txtValue"
		Me.txtValue.Size = New System.Drawing.Size(169, 24)
		Me.txtValue.Location = New System.Drawing.Point(136, 248)
		Me.txtValue.TabIndex = 23
		'
		' txtNumericScale
		'
		Me.txtNumericScale.Name = "txtNumericScale"
		Me.txtNumericScale.Size = New System.Drawing.Size(169, 24)
		Me.txtNumericScale.Location = New System.Drawing.Point(136, 128)
		Me.txtNumericScale.ReadOnly = True
		Me.txtNumericScale.TabIndex = 22
		'
		' cboAttributes
		'
		Me.cboAttributes.Name = "cboAttributes"
		Me.cboAttributes.Size = New System.Drawing.Size(169, 24)
		Me.cboAttributes.Location = New System.Drawing.Point(136, 80)
		Me.cboAttributes.Locked6 = True
		Me.cboAttributes.TabIndex = 21
		'
		' cmdSetProperties
		'
		Me.cmdSetProperties.Name = "cmdSetProperties"
		Me.cmdSetProperties.Size = New System.Drawing.Size(121, 25)
		Me.cmdSetProperties.Location = New System.Drawing.Point(320, 8)
		Me.cmdSetProperties.Caption = "Set &Properties"
		Me.cmdSetProperties.TabIndex = 20
		'
		' cboName
		'
		Me.cboName.Name = "cboName"
		Me.cboName.Size = New System.Drawing.Size(169, 24)
		Me.cboName.Location = New System.Drawing.Point(136, 8)
		Me.cboName.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboName.TabIndex = 19
		'
		' cboType
		'
		Me.cboType.Name = "cboType"
		Me.cboType.Size = New System.Drawing.Size(169, 24)
		Me.cboType.Location = New System.Drawing.Point(136, 200)
		Me.cboType.Locked6 = True
		Me.cboType.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboType.TabIndex = 18
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(57, 25)
		Me.cmdSet.Location = New System.Drawing.Point(496, 72)
		Me.cmdSet.Caption = "&Set"
		Me.cmdSet.TabIndex = 17
		'
		' txtCustomProperty
		'
		Me.txtCustomProperty.Name = "txtCustomProperty"
		Me.txtCustomProperty.Size = New System.Drawing.Size(177, 25)
		Me.txtCustomProperty.Location = New System.Drawing.Point(320, 72)
		Me.txtCustomProperty.TabIndex = 15
		'
		' lstCustomProperties
		'
		Me.lstCustomProperties.Name = "lstCustomProperties"
		Me.lstCustomProperties.Size = New System.Drawing.Size(233, 164)
		Me.lstCustomProperties.Location = New System.Drawing.Point(320, 104)
		Me.lstCustomProperties.Sorted = True
		Me.lstCustomProperties.TabIndex = 14
		'
		' txtPrecision
		'
		Me.txtPrecision.Name = "txtPrecision"
		Me.txtPrecision.Size = New System.Drawing.Size(169, 24)
		Me.txtPrecision.Location = New System.Drawing.Point(136, 176)
		Me.txtPrecision.ReadOnly = True
		Me.txtPrecision.TabIndex = 9
		'
		' txtDefinedSize
		'
		Me.txtDefinedSize.Name = "txtDefinedSize"
		Me.txtDefinedSize.Size = New System.Drawing.Size(169, 24)
		Me.txtDefinedSize.Location = New System.Drawing.Point(136, 104)
		Me.txtDefinedSize.TabIndex = 7
		'
		' txtOriginalValue
		'
		Me.txtOriginalValue.Name = "txtOriginalValue"
		Me.txtOriginalValue.Size = New System.Drawing.Size(169, 24)
		Me.txtOriginalValue.Location = New System.Drawing.Point(136, 152)
		Me.txtOriginalValue.ReadOnly = True
		Me.txtOriginalValue.TabIndex = 4
		'
		' txtActualSize
		'
		Me.txtActualSize.Name = "txtActualSize"
		Me.txtActualSize.Size = New System.Drawing.Size(169, 24)
		Me.txtActualSize.Location = New System.Drawing.Point(136, 56)
		Me.txtActualSize.ReadOnly = True
		Me.txtActualSize.TabIndex = 2
		'
		' lblCustomProperty
		'
		Me.lblCustomProperty.Name = "lblCustomProperty"
		Me.lblCustomProperty.Size = New System.Drawing.Size(233, 25)
		Me.lblCustomProperty.Location = New System.Drawing.Point(320, 48)
		Me.lblCustomProperty.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblCustomProperty.Caption = "Custom Properties"
		Me.lblCustomProperty.TabIndex = 16
		'
		' lblProperty_009
		'
		Me.lblProperty_009.Name = "lblProperty_009"
		Me.lblProperty_009.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_009.Location = New System.Drawing.Point(8, 248)
		Me.lblProperty_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_009.Caption = "Value"
		Me.lblProperty_009.TabIndex = 13
		'
		' lblProperty_008
		'
		Me.lblProperty_008.Name = "lblProperty_008"
		Me.lblProperty_008.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_008.Location = New System.Drawing.Point(8, 224)
		Me.lblProperty_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_008.Caption = "UnderlyingValue"
		Me.lblProperty_008.TabIndex = 12
		'
		' lblProperty_007
		'
		Me.lblProperty_007.Name = "lblProperty_007"
		Me.lblProperty_007.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_007.Location = New System.Drawing.Point(8, 200)
		Me.lblProperty_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_007.Caption = "Type"
		Me.lblProperty_007.TabIndex = 11
		'
		' lblProperty_006
		'
		Me.lblProperty_006.Name = "lblProperty_006"
		Me.lblProperty_006.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_006.Location = New System.Drawing.Point(8, 128)
		Me.lblProperty_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_006.Caption = "NumericScale"
		Me.lblProperty_006.TabIndex = 10
		'
		' lblProperty_005
		'
		Me.lblProperty_005.Name = "lblProperty_005"
		Me.lblProperty_005.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_005.Location = New System.Drawing.Point(8, 176)
		Me.lblProperty_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_005.Caption = "Precision"
		Me.lblProperty_005.TabIndex = 8
		'
		' lblProperty_004
		'
		Me.lblProperty_004.Name = "lblProperty_004"
		Me.lblProperty_004.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_004.Location = New System.Drawing.Point(8, 104)
		Me.lblProperty_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_004.Caption = "DefinedSize"
		Me.lblProperty_004.TabIndex = 6
		'
		' lblProperty_003
		'
		Me.lblProperty_003.Name = "lblProperty_003"
		Me.lblProperty_003.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_003.Location = New System.Drawing.Point(8, 80)
		Me.lblProperty_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_003.Caption = "Attributes"
		Me.lblProperty_003.TabIndex = 5
		'
		' lblProperty_002
		'
		Me.lblProperty_002.Name = "lblProperty_002"
		Me.lblProperty_002.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_002.Location = New System.Drawing.Point(8, 152)
		Me.lblProperty_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_002.Caption = "OriginalValue"
		Me.lblProperty_002.TabIndex = 3
		'
		' lblProperty_001
		'
		Me.lblProperty_001.Name = "lblProperty_001"
		Me.lblProperty_001.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_001.Location = New System.Drawing.Point(8, 56)
		Me.lblProperty_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_001.Caption = "ActualSize"
		Me.lblProperty_001.TabIndex = 1
		'
		' lblProperty_000
		'
		Me.lblProperty_000.Name = "lblProperty_000"
		Me.lblProperty_000.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_000.Location = New System.Drawing.Point(8, 8)
		Me.lblProperty_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_000.Caption = "Name"
		Me.lblProperty_000.TabIndex = 0
		'
		' frmFields
		'
		Me.Name = "frmFields"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Fields"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(567, 281)

		Me.Controls.Add(txtUnderlyingValue)
		Me.Controls.Add(txtValue)
		Me.Controls.Add(txtNumericScale)
		Me.Controls.Add(cboAttributes)
		Me.Controls.Add(cmdSetProperties)
		Me.Controls.Add(cboName)
		Me.Controls.Add(cboType)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(txtCustomProperty)
		Me.Controls.Add(lstCustomProperties)
		Me.Controls.Add(txtPrecision)
		Me.Controls.Add(txtDefinedSize)
		Me.Controls.Add(txtOriginalValue)
		Me.Controls.Add(txtActualSize)
		Me.Controls.Add(lblCustomProperty)
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
