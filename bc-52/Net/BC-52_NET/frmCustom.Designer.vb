<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCustom
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
		Me.cmbLabel = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)(cmbLabel_012, cmbLabel_011, cmbLabel_010, cmbLabel_009, cmbLabel_008, cmbLabel_007, cmbLabel_006, cmbLabel_005, cmbLabel_004, cmbLabel_003, cmbLabel_002, cmbLabel_001)
		Me.Label2 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label2_011, Label2_010, Label2_009, Label2_008, Label2_007, Label2_006, Label2_005, Label2_004, Label2_003, Label2_002, Label2_001, Label2_000)
		Me.cmbStep = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)(cmbStep_002, cmbStep_003, cmbStep_004, cmbStep_005, cmbStep_006)
		Me.cmbBar = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)(cmbBar_006, cmbBar_005, cmbBar_004, cmbBar_003, cmbBar_002)
		Me.Label5 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label5_009, Label5_008, Label5_007, Label5_006, Label5_005, Label5_004, Label5_003, Label5_002, Label5_001, Label5_000)
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
	Public cmbLabel As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)
	Public Label2 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public cmbStep As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)
	Public cmbBar As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6ComboBox)
	Public Label5 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents Frame5 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkSpeed As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Frame4 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents optC52 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optCX52 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents cmdDefault As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame3 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmbSpace As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmbLabel_012 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_011 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_010 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_009 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_008 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_007 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_006 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_005 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_004 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_003 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_002 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbLabel_001 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmbStep_002 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbStep_003 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbStep_004 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbStep_005 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbStep_006 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbBar_006 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbBar_005 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbBar_004 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbBar_003 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmbBar_002 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents chkCipherBars As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents chkHoldPins As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustom))
		Me.Frame5 = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkSpeed = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Frame4 = New CodeArchitects.VB6Library.VB6Frame()
		Me.optC52 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optCX52 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.cmdDefault = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame3 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmbSpace = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmbLabel_012 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_011 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_010 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_009 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_008 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_007 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_006 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_005 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_004 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_003 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_002 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbLabel_001 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmbStep_002 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbStep_003 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbStep_004 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbStep_005 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbStep_006 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbBar_006 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbBar_005 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbBar_004 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbBar_003 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbBar_002 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.chkCipherBars = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.chkHoldPins = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame5.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		'
		' Frame5
		'
		Me.Frame5.Name = "Frame5"
		Me.Frame5.Size = New System.Drawing.Size(321, 57)
		Me.Frame5.Location = New System.Drawing.Point(8, 352)
		Me.Frame5.Caption = "Program Speed"
		Me.Frame5.TabIndex = 62
		Me.Frame5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' chkSpeed
		'
		Me.chkSpeed.Name = "chkSpeed"
		Me.chkSpeed.Size = New System.Drawing.Size(217, 17)
		Me.chkSpeed.Location = New System.Drawing.Point(16, 24)
		Me.chkSpeed.Caption = "Disable graphics delay"
		Me.chkSpeed.TabIndex = 15
		Me.chkSpeed.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame4
		'
		Me.Frame4.Name = "Frame4"
		Me.Frame4.Size = New System.Drawing.Size(321, 89)
		Me.Frame4.Location = New System.Drawing.Point(8, 8)
		Me.Frame4.Caption = "Machine Type"
		Me.Frame4.TabIndex = 55
		Me.Frame4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optC52
		'
		Me.optC52.Name = "optC52"
		Me.optC52.Size = New System.Drawing.Size(289, 17)
		Me.optC52.Location = New System.Drawing.Point(24, 32)
		Me.optC52.Caption = "C-52 (6 different wheels with 25 up to 47 pins)"
		Me.optC52.TabIndex = 1
		Me.optC52.TabStop = True
		Me.optC52.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optCX52
		'
		Me.optCX52.Name = "optCX52"
		Me.optCX52.Size = New System.Drawing.Size(289, 17)
		Me.optCX52.Location = New System.Drawing.Point(24, 56)
		Me.optCX52.Caption = "CX-52 (6 wheels with 47 pins each)"
		Me.optCX52.TabIndex = 2
		Me.optCX52.TabStop = True
		Me.optCX52.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdDefault
		'
		Me.cmdDefault.Name = "cmdDefault"
		Me.cmdDefault.Size = New System.Drawing.Size(105, 25)
		Me.cmdDefault.Location = New System.Drawing.Point(336, 416)
		Me.cmdDefault.Caption = "&Default"
		Me.cmdDefault.TabIndex = 29
		Me.cmdDefault.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame3
		'
		Me.Frame3.Name = "Frame3"
		Me.Frame3.Size = New System.Drawing.Size(265, 113)
		Me.Frame3.Location = New System.Drawing.Point(336, 296)
		Me.Frame3.Caption = "Space Letter"
		Me.Frame3.TabIndex = 47
		Me.Frame3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmbSpace
		'
		Me.cmbSpace.Name = "cmbSpace"
		Me.cmbSpace.Size = New System.Drawing.Size(41, 21)
		Me.cmbSpace.Location = New System.Drawing.Point(16, 80)
		Me.cmbSpace.TabIndex = 28
		Me.cmbSpace.Text = "Combo1"
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(201, 49)
		Me.Label4.Location = New System.Drawing.Point(16, 24)
		Me.Label4.Caption = "Select the letter that will represent a space during ciphering. When deciphering, this letter will be replace by a space."
		Me.Label4.TabIndex = 48
		Me.Label4.AutoSize = False
		Me.Label4.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(321, 241)
		Me.Frame2.Location = New System.Drawing.Point(8, 104)
		Me.Frame2.Caption = "Wheel Labeling Setup"
		Me.Frame2.TabIndex = 32
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmbLabel_012
		'
		Me.cmbLabel_012.Name = "cmbLabel_012"
		Me.cmbLabel_012.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_012.Location = New System.Drawing.Point(256, 192)
		Me.cmbLabel_012.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_012.TabIndex = 14
		'
		' cmbLabel_011
		'
		Me.cmbLabel_011.Name = "cmbLabel_011"
		Me.cmbLabel_011.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_011.Location = New System.Drawing.Point(208, 192)
		Me.cmbLabel_011.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_011.TabIndex = 13
		'
		' cmbLabel_010
		'
		Me.cmbLabel_010.Name = "cmbLabel_010"
		Me.cmbLabel_010.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_010.Location = New System.Drawing.Point(160, 192)
		Me.cmbLabel_010.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_010.TabIndex = 12
		'
		' cmbLabel_009
		'
		Me.cmbLabel_009.Name = "cmbLabel_009"
		Me.cmbLabel_009.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_009.Location = New System.Drawing.Point(112, 192)
		Me.cmbLabel_009.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_009.TabIndex = 11
		'
		' cmbLabel_008
		'
		Me.cmbLabel_008.Name = "cmbLabel_008"
		Me.cmbLabel_008.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_008.Location = New System.Drawing.Point(64, 192)
		Me.cmbLabel_008.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_008.TabIndex = 10
		'
		' cmbLabel_007
		'
		Me.cmbLabel_007.Name = "cmbLabel_007"
		Me.cmbLabel_007.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_007.Location = New System.Drawing.Point(16, 192)
		Me.cmbLabel_007.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_007.TabIndex = 9
		'
		' cmbLabel_006
		'
		Me.cmbLabel_006.Name = "cmbLabel_006"
		Me.cmbLabel_006.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_006.Location = New System.Drawing.Point(256, 144)
		Me.cmbLabel_006.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_006.TabIndex = 8
		'
		' cmbLabel_005
		'
		Me.cmbLabel_005.Name = "cmbLabel_005"
		Me.cmbLabel_005.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_005.Location = New System.Drawing.Point(208, 144)
		Me.cmbLabel_005.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_005.TabIndex = 7
		'
		' cmbLabel_004
		'
		Me.cmbLabel_004.Name = "cmbLabel_004"
		Me.cmbLabel_004.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_004.Location = New System.Drawing.Point(160, 144)
		Me.cmbLabel_004.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_004.TabIndex = 6
		'
		' cmbLabel_003
		'
		Me.cmbLabel_003.Name = "cmbLabel_003"
		Me.cmbLabel_003.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_003.Location = New System.Drawing.Point(112, 144)
		Me.cmbLabel_003.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_003.TabIndex = 5
		'
		' cmbLabel_002
		'
		Me.cmbLabel_002.Name = "cmbLabel_002"
		Me.cmbLabel_002.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_002.Location = New System.Drawing.Point(64, 144)
		Me.cmbLabel_002.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_002.TabIndex = 4
		'
		' cmbLabel_001
		'
		Me.cmbLabel_001.Name = "cmbLabel_001"
		Me.cmbLabel_001.Size = New System.Drawing.Size(41, 21)
		Me.cmbLabel_001.Location = New System.Drawing.Point(16, 144)
		Me.cmbLabel_001.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbLabel_001.TabIndex = 3
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(281, 57)
		Me.Label3.Location = New System.Drawing.Point(16, 24)
		Me.Label3.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label3.Caption = "The pins of each wheel are numbered and the wheel has also an alphanumerical labeling on the exterior, visible through the cover window. The labeling on the wheels, supplied with a machine, can vary."
		Me.Label3.TabIndex = 46
		Me.Label3.AutoSize = False
		Me.Label3.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_011
		'
		Me.Label2_011.Name = "Label2_011"
		Me.Label2_011.Size = New System.Drawing.Size(41, 17)
		Me.Label2_011.Location = New System.Drawing.Point(256, 176)
		Me.Label2_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_011.Caption = "47"
		Me.Label2_011.TabIndex = 45
		Me.Label2_011.AutoSize = False
		Me.Label2_011.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_010
		'
		Me.Label2_010.Name = "Label2_010"
		Me.Label2_010.Size = New System.Drawing.Size(41, 17)
		Me.Label2_010.Location = New System.Drawing.Point(208, 176)
		Me.Label2_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_010.Caption = "46"
		Me.Label2_010.TabIndex = 44
		Me.Label2_010.AutoSize = False
		Me.Label2_010.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_009
		'
		Me.Label2_009.Name = "Label2_009"
		Me.Label2_009.Size = New System.Drawing.Size(41, 17)
		Me.Label2_009.Location = New System.Drawing.Point(160, 176)
		Me.Label2_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_009.Caption = "43"
		Me.Label2_009.TabIndex = 43
		Me.Label2_009.AutoSize = False
		Me.Label2_009.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_008
		'
		Me.Label2_008.Name = "Label2_008"
		Me.Label2_008.Size = New System.Drawing.Size(41, 17)
		Me.Label2_008.Location = New System.Drawing.Point(112, 176)
		Me.Label2_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_008.Caption = "42"
		Me.Label2_008.TabIndex = 42
		Me.Label2_008.AutoSize = False
		Me.Label2_008.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_007
		'
		Me.Label2_007.Name = "Label2_007"
		Me.Label2_007.Size = New System.Drawing.Size(41, 17)
		Me.Label2_007.Location = New System.Drawing.Point(64, 176)
		Me.Label2_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_007.Caption = "41"
		Me.Label2_007.TabIndex = 41
		Me.Label2_007.AutoSize = False
		Me.Label2_007.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_006
		'
		Me.Label2_006.Name = "Label2_006"
		Me.Label2_006.Size = New System.Drawing.Size(41, 17)
		Me.Label2_006.Location = New System.Drawing.Point(16, 176)
		Me.Label2_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_006.Caption = "38"
		Me.Label2_006.TabIndex = 40
		Me.Label2_006.AutoSize = False
		Me.Label2_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_005
		'
		Me.Label2_005.Name = "Label2_005"
		Me.Label2_005.Size = New System.Drawing.Size(41, 17)
		Me.Label2_005.Location = New System.Drawing.Point(256, 128)
		Me.Label2_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_005.Caption = "37"
		Me.Label2_005.TabIndex = 39
		Me.Label2_005.AutoSize = False
		Me.Label2_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_004
		'
		Me.Label2_004.Name = "Label2_004"
		Me.Label2_004.Size = New System.Drawing.Size(41, 17)
		Me.Label2_004.Location = New System.Drawing.Point(208, 128)
		Me.Label2_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_004.Caption = "34"
		Me.Label2_004.TabIndex = 38
		Me.Label2_004.AutoSize = False
		Me.Label2_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_003
		'
		Me.Label2_003.Name = "Label2_003"
		Me.Label2_003.Size = New System.Drawing.Size(41, 17)
		Me.Label2_003.Location = New System.Drawing.Point(160, 128)
		Me.Label2_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_003.Caption = "31"
		Me.Label2_003.TabIndex = 37
		Me.Label2_003.AutoSize = False
		Me.Label2_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_002
		'
		Me.Label2_002.Name = "Label2_002"
		Me.Label2_002.Size = New System.Drawing.Size(41, 17)
		Me.Label2_002.Location = New System.Drawing.Point(112, 128)
		Me.Label2_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_002.Caption = "29"
		Me.Label2_002.TabIndex = 36
		Me.Label2_002.AutoSize = False
		Me.Label2_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_001
		'
		Me.Label2_001.Name = "Label2_001"
		Me.Label2_001.Size = New System.Drawing.Size(41, 17)
		Me.Label2_001.Location = New System.Drawing.Point(64, 128)
		Me.Label2_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_001.Caption = "26"
		Me.Label2_001.TabIndex = 35
		Me.Label2_001.AutoSize = False
		Me.Label2_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2_000
		'
		Me.Label2_000.Name = "Label2_000"
		Me.Label2_000.Size = New System.Drawing.Size(41, 17)
		Me.Label2_000.Location = New System.Drawing.Point(16, 128)
		Me.Label2_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label2_000.Caption = "25"
		Me.Label2_000.TabIndex = 34
		Me.Label2_000.AutoSize = False
		Me.Label2_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(281, 33)
		Me.Label1.Location = New System.Drawing.Point(16, 88)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "Set the label that is visible on the exteriour of the machine when Pin 01 is in front of the Pin Reading Pawl."
		Me.Label1.TabIndex = 33
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(448, 416)
		Me.cmdOK.Caption = "&OK"
		Me.cmdOK.TabIndex = 30
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(528, 416)
		Me.cmdCancel.Caption = "&Cancel"
		Me.cmdCancel.TabIndex = 0
		Me.cmdCancel.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(265, 281)
		Me.Frame1.Location = New System.Drawing.Point(336, 8)
		Me.Frame1.Caption = "Wheel Advancing and Pin Reading Method"
		Me.Frame1.TabIndex = 31
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmbStep_002
		'
		Me.cmbStep_002.Name = "cmbStep_002"
		Me.cmbStep_002.Size = New System.Drawing.Size(41, 21)
		Me.cmbStep_002.Location = New System.Drawing.Point(16, 192)
		Me.cmbStep_002.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbStep_002.TabIndex = 21
		'
		' cmbStep_003
		'
		Me.cmbStep_003.Name = "cmbStep_003"
		Me.cmbStep_003.Size = New System.Drawing.Size(41, 21)
		Me.cmbStep_003.Location = New System.Drawing.Point(64, 192)
		Me.cmbStep_003.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbStep_003.TabIndex = 22
		'
		' cmbStep_004
		'
		Me.cmbStep_004.Name = "cmbStep_004"
		Me.cmbStep_004.Size = New System.Drawing.Size(41, 21)
		Me.cmbStep_004.Location = New System.Drawing.Point(112, 192)
		Me.cmbStep_004.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbStep_004.TabIndex = 23
		'
		' cmbStep_005
		'
		Me.cmbStep_005.Name = "cmbStep_005"
		Me.cmbStep_005.Size = New System.Drawing.Size(41, 21)
		Me.cmbStep_005.Location = New System.Drawing.Point(160, 192)
		Me.cmbStep_005.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbStep_005.TabIndex = 24
		'
		' cmbStep_006
		'
		Me.cmbStep_006.Name = "cmbStep_006"
		Me.cmbStep_006.Size = New System.Drawing.Size(41, 21)
		Me.cmbStep_006.Location = New System.Drawing.Point(208, 192)
		Me.cmbStep_006.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbStep_006.TabIndex = 25
		'
		' cmbBar_006
		'
		Me.cmbBar_006.Name = "cmbBar_006"
		Me.cmbBar_006.Size = New System.Drawing.Size(41, 21)
		Me.cmbBar_006.Location = New System.Drawing.Point(208, 80)
		Me.cmbBar_006.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbBar_006.TabIndex = 20
		'
		' cmbBar_005
		'
		Me.cmbBar_005.Name = "cmbBar_005"
		Me.cmbBar_005.Size = New System.Drawing.Size(41, 21)
		Me.cmbBar_005.Location = New System.Drawing.Point(160, 80)
		Me.cmbBar_005.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbBar_005.TabIndex = 19
		'
		' cmbBar_004
		'
		Me.cmbBar_004.Name = "cmbBar_004"
		Me.cmbBar_004.Size = New System.Drawing.Size(41, 21)
		Me.cmbBar_004.Location = New System.Drawing.Point(112, 80)
		Me.cmbBar_004.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbBar_004.TabIndex = 18
		'
		' cmbBar_003
		'
		Me.cmbBar_003.Name = "cmbBar_003"
		Me.cmbBar_003.Size = New System.Drawing.Size(41, 21)
		Me.cmbBar_003.Location = New System.Drawing.Point(64, 80)
		Me.cmbBar_003.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbBar_003.TabIndex = 17
		'
		' cmbBar_002
		'
		Me.cmbBar_002.Name = "cmbBar_002"
		Me.cmbBar_002.Size = New System.Drawing.Size(41, 21)
		Me.cmbBar_002.Location = New System.Drawing.Point(16, 80)
		Me.cmbBar_002.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbBar_002.TabIndex = 16
		'
		' chkCipherBars
		'
		Me.chkCipherBars.Name = "chkCipherBars"
		Me.chkCipherBars.Size = New System.Drawing.Size(201, 17)
		Me.chkCipherBars.Location = New System.Drawing.Point(16, 232)
		Me.chkCipherBars.Caption = "Use advance bars also for ciphering"
		Me.chkCipherBars.TabIndex = 26
		Me.chkCipherBars.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' chkHoldPins
		'
		Me.chkHoldPins.Name = "chkHoldPins"
		Me.chkHoldPins.Size = New System.Drawing.Size(201, 17)
		Me.chkHoldPins.Location = New System.Drawing.Point(16, 256)
		Me.chkHoldPins.Caption = "Hold pin positions while turning drum"
		Me.chkHoldPins.TabIndex = 27
		Me.chkHoldPins.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(233, 57)
		Me.Label7.Location = New System.Drawing.Point(16, 120)
		Me.Label7.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label7.Caption = "Select for wheels 2 to 6 the type of bar that is used (1 = moves wheel if slided, 2 = moves wheel if not slided, 3 =  always moves wheel, 4 = never moves wheel)"
		Me.Label7.TabIndex = 61
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_009
		'
		Me.Label5_009.Name = "Label5_009"
		Me.Label5_009.Size = New System.Drawing.Size(17, 17)
		Me.Label5_009.Location = New System.Drawing.Point(25, 176)
		Me.Label5_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_009.Caption = "2"
		Me.Label5_009.TabIndex = 60
		Me.Label5_009.AutoSize = False
		Me.Label5_009.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_008
		'
		Me.Label5_008.Name = "Label5_008"
		Me.Label5_008.Size = New System.Drawing.Size(17, 17)
		Me.Label5_008.Location = New System.Drawing.Point(73, 176)
		Me.Label5_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_008.Caption = "3"
		Me.Label5_008.TabIndex = 59
		Me.Label5_008.AutoSize = False
		Me.Label5_008.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_007
		'
		Me.Label5_007.Name = "Label5_007"
		Me.Label5_007.Size = New System.Drawing.Size(17, 17)
		Me.Label5_007.Location = New System.Drawing.Point(122, 176)
		Me.Label5_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_007.Caption = "4"
		Me.Label5_007.TabIndex = 58
		Me.Label5_007.AutoSize = False
		Me.Label5_007.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_006
		'
		Me.Label5_006.Name = "Label5_006"
		Me.Label5_006.Size = New System.Drawing.Size(17, 17)
		Me.Label5_006.Location = New System.Drawing.Point(170, 176)
		Me.Label5_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_006.Caption = "5"
		Me.Label5_006.TabIndex = 57
		Me.Label5_006.AutoSize = False
		Me.Label5_006.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_005
		'
		Me.Label5_005.Name = "Label5_005"
		Me.Label5_005.Size = New System.Drawing.Size(17, 17)
		Me.Label5_005.Location = New System.Drawing.Point(219, 176)
		Me.Label5_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_005.Caption = "6"
		Me.Label5_005.TabIndex = 56
		Me.Label5_005.AutoSize = False
		Me.Label5_005.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(233, 33)
		Me.Label6.Location = New System.Drawing.Point(16, 32)
		Me.Label6.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label6.Caption = "Select for wheels 2 to 6 the bar that will advance that wheel. (wheel 1 always moves)"
		Me.Label6.TabIndex = 54
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_004
		'
		Me.Label5_004.Name = "Label5_004"
		Me.Label5_004.Size = New System.Drawing.Size(17, 17)
		Me.Label5_004.Location = New System.Drawing.Point(219, 64)
		Me.Label5_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_004.Caption = "6"
		Me.Label5_004.TabIndex = 53
		Me.Label5_004.AutoSize = False
		Me.Label5_004.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_003
		'
		Me.Label5_003.Name = "Label5_003"
		Me.Label5_003.Size = New System.Drawing.Size(17, 17)
		Me.Label5_003.Location = New System.Drawing.Point(170, 64)
		Me.Label5_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_003.Caption = "5"
		Me.Label5_003.TabIndex = 52
		Me.Label5_003.AutoSize = False
		Me.Label5_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_002
		'
		Me.Label5_002.Name = "Label5_002"
		Me.Label5_002.Size = New System.Drawing.Size(17, 17)
		Me.Label5_002.Location = New System.Drawing.Point(122, 64)
		Me.Label5_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_002.Caption = "4"
		Me.Label5_002.TabIndex = 51
		Me.Label5_002.AutoSize = False
		Me.Label5_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_001
		'
		Me.Label5_001.Name = "Label5_001"
		Me.Label5_001.Size = New System.Drawing.Size(17, 17)
		Me.Label5_001.Location = New System.Drawing.Point(73, 64)
		Me.Label5_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_001.Caption = "3"
		Me.Label5_001.TabIndex = 50
		Me.Label5_001.AutoSize = False
		Me.Label5_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5_000
		'
		Me.Label5_000.Name = "Label5_000"
		Me.Label5_000.Size = New System.Drawing.Size(17, 17)
		Me.Label5_000.Location = New System.Drawing.Point(25, 64)
		Me.Label5_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5_000.Caption = "2"
		Me.Label5_000.TabIndex = 49
		Me.Label5_000.AutoSize = False
		Me.Label5_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmCustom
		'
		Me.Name = "frmCustom"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = " BC-52 Customizing"
		Me.ControlBox = False
		Me.MaxButton = False
		Me.MinButton = False
		Me.ShowInTaskbar = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(610, 449)

		Me.Controls.Add(Frame5)
		Me.Frame5.Controls.Add(chkSpeed)
		Me.Controls.Add(Frame4)
		Me.Frame4.Controls.Add(optC52)
		Me.Frame4.Controls.Add(optCX52)
		Me.Controls.Add(cmdDefault)
		Me.Controls.Add(Frame3)
		Me.Frame3.Controls.Add(cmbSpace)
		Me.Frame3.Controls.Add(Label4)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(cmbLabel_012)
		Me.Frame2.Controls.Add(cmbLabel_011)
		Me.Frame2.Controls.Add(cmbLabel_010)
		Me.Frame2.Controls.Add(cmbLabel_009)
		Me.Frame2.Controls.Add(cmbLabel_008)
		Me.Frame2.Controls.Add(cmbLabel_007)
		Me.Frame2.Controls.Add(cmbLabel_006)
		Me.Frame2.Controls.Add(cmbLabel_005)
		Me.Frame2.Controls.Add(cmbLabel_004)
		Me.Frame2.Controls.Add(cmbLabel_003)
		Me.Frame2.Controls.Add(cmbLabel_002)
		Me.Frame2.Controls.Add(cmbLabel_001)
		Me.Frame2.Controls.Add(Label3)
		Me.Frame2.Controls.Add(Label2_011)
		Me.Frame2.Controls.Add(Label2_010)
		Me.Frame2.Controls.Add(Label2_009)
		Me.Frame2.Controls.Add(Label2_008)
		Me.Frame2.Controls.Add(Label2_007)
		Me.Frame2.Controls.Add(Label2_006)
		Me.Frame2.Controls.Add(Label2_005)
		Me.Frame2.Controls.Add(Label2_004)
		Me.Frame2.Controls.Add(Label2_003)
		Me.Frame2.Controls.Add(Label2_002)
		Me.Frame2.Controls.Add(Label2_001)
		Me.Frame2.Controls.Add(Label2_000)
		Me.Frame2.Controls.Add(Label1)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(cmbStep_002)
		Me.Frame1.Controls.Add(cmbStep_003)
		Me.Frame1.Controls.Add(cmbStep_004)
		Me.Frame1.Controls.Add(cmbStep_005)
		Me.Frame1.Controls.Add(cmbStep_006)
		Me.Frame1.Controls.Add(cmbBar_006)
		Me.Frame1.Controls.Add(cmbBar_005)
		Me.Frame1.Controls.Add(cmbBar_004)
		Me.Frame1.Controls.Add(cmbBar_003)
		Me.Frame1.Controls.Add(cmbBar_002)
		Me.Frame1.Controls.Add(chkCipherBars)
		Me.Frame1.Controls.Add(chkHoldPins)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label5_009)
		Me.Frame1.Controls.Add(Label5_008)
		Me.Frame1.Controls.Add(Label5_007)
		Me.Frame1.Controls.Add(Label5_006)
		Me.Frame1.Controls.Add(Label5_005)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5_004)
		Me.Frame1.Controls.Add(Label5_003)
		Me.Frame1.Controls.Add(Label5_002)
		Me.Frame1.Controls.Add(Label5_001)
		Me.Frame1.Controls.Add(Label5_000)
		Me.Frame5.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
