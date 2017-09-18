<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrinter
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
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_016, Label1_015, Label1_014, Label1_013, Label1_012, Label1_011, Label1_010, Label1_009, Label1_008, Label1_007, Label1_006, Label1_005, Label1_004, Label1_003, Label1_002, Label1_000, Label1_001)
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
	Public WithEvents cmdTestPage As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtZoom As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtScaleWidth As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtScaleHeight As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtScaleLeft As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtScaleTop As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboPrintQuality As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboPaperBin As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboDuplex As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtCopies As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboColorMode As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboOrientation As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdMakeCurrent As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboPaperSize As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtHeight As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtWidth As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkTrackDefault As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cboPrinters As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents Label1_016 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDriverName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_015 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_014 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_013 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPort As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdTestPage = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtZoom = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtScaleWidth = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtScaleHeight = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtScaleLeft = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtScaleTop = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboPrintQuality = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboPaperBin = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboDuplex = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtCopies = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboColorMode = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboOrientation = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdMakeCurrent = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboPaperSize = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtHeight = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtWidth = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkTrackDefault = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cboPrinters = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.Label1_016 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDriverName = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_015 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_014 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_013 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPort = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdTestPage
		'
		Me.cmdTestPage.Name = "cmdTestPage"
		Me.cmdTestPage.Size = New System.Drawing.Size(113, 33)
		Me.cmdTestPage.Location = New System.Drawing.Point(448, 336)
		Me.cmdTestPage.Caption = "&Print Test Page"
		Me.cmdTestPage.TabIndex = 37
		'
		' txtZoom
		'
		Me.txtZoom.Name = "txtZoom"
		Me.txtZoom.Size = New System.Drawing.Size(73, 25)
		Me.txtZoom.Location = New System.Drawing.Point(616, 272)
		Me.txtZoom.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtZoom.TabIndex = 35
		'
		' txtScaleWidth
		'
		Me.txtScaleWidth.Name = "txtScaleWidth"
		Me.txtScaleWidth.Size = New System.Drawing.Size(73, 25)
		Me.txtScaleWidth.Location = New System.Drawing.Point(448, 152)
		Me.txtScaleWidth.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtScaleWidth.TabIndex = 32
		'
		' txtScaleHeight
		'
		Me.txtScaleHeight.Name = "txtScaleHeight"
		Me.txtScaleHeight.Size = New System.Drawing.Size(73, 25)
		Me.txtScaleHeight.Location = New System.Drawing.Point(616, 152)
		Me.txtScaleHeight.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtScaleHeight.TabIndex = 31
		'
		' txtScaleLeft
		'
		Me.txtScaleLeft.Name = "txtScaleLeft"
		Me.txtScaleLeft.Size = New System.Drawing.Size(73, 25)
		Me.txtScaleLeft.Location = New System.Drawing.Point(104, 152)
		Me.txtScaleLeft.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtScaleLeft.TabIndex = 28
		'
		' txtScaleTop
		'
		Me.txtScaleTop.Name = "txtScaleTop"
		Me.txtScaleTop.Size = New System.Drawing.Size(73, 25)
		Me.txtScaleTop.Location = New System.Drawing.Point(272, 152)
		Me.txtScaleTop.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtScaleTop.TabIndex = 27
		'
		' cboPrintQuality
		'
		Me.cboPrintQuality.Name = "cboPrintQuality"
		Me.cboPrintQuality.Size = New System.Drawing.Size(169, 24)
		Me.cboPrintQuality.Location = New System.Drawing.Point(448, 232)
		Me.cboPrintQuality.TabIndex = 25
		'
		' cboPaperBin
		'
		Me.cboPaperBin.Name = "cboPaperBin"
		Me.cboPaperBin.Size = New System.Drawing.Size(169, 24)
		Me.cboPaperBin.Location = New System.Drawing.Point(104, 272)
		Me.cboPaperBin.TabIndex = 23
		Me.cboPaperBin.Text = "cboPaperBin"
		'
		' cboDuplex
		'
		Me.cboDuplex.Name = "cboDuplex"
		Me.cboDuplex.Size = New System.Drawing.Size(169, 24)
		Me.cboDuplex.Location = New System.Drawing.Point(448, 192)
		Me.cboDuplex.TabIndex = 21
		'
		' txtCopies
		'
		Me.txtCopies.Name = "txtCopies"
		Me.txtCopies.Size = New System.Drawing.Size(73, 25)
		Me.txtCopies.Location = New System.Drawing.Point(448, 272)
		Me.txtCopies.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtCopies.TabIndex = 19
		'
		' cboColorMode
		'
		Me.cboColorMode.Name = "cboColorMode"
		Me.cboColorMode.Size = New System.Drawing.Size(169, 24)
		Me.cboColorMode.Location = New System.Drawing.Point(104, 232)
		Me.cboColorMode.TabIndex = 17
		'
		' cboOrientation
		'
		Me.cboOrientation.Name = "cboOrientation"
		Me.cboOrientation.Size = New System.Drawing.Size(169, 24)
		Me.cboOrientation.Location = New System.Drawing.Point(104, 192)
		Me.cboOrientation.TabIndex = 15
		'
		' cmdMakeCurrent
		'
		Me.cmdMakeCurrent.Name = "cmdMakeCurrent"
		Me.cmdMakeCurrent.Size = New System.Drawing.Size(113, 33)
		Me.cmdMakeCurrent.Location = New System.Drawing.Point(408, 24)
		Me.cmdMakeCurrent.Caption = "&Make Current"
		Me.cmdMakeCurrent.TabIndex = 13
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(113, 33)
		Me.cmdSet.Location = New System.Drawing.Point(160, 336)
		Me.cmdSet.Caption = "&Set Properties"
		Me.cmdSet.TabIndex = 12
		'
		' cboPaperSize
		'
		Me.cboPaperSize.Name = "cboPaperSize"
		Me.cboPaperSize.Size = New System.Drawing.Size(169, 24)
		Me.cboPaperSize.Location = New System.Drawing.Point(448, 112)
		Me.cboPaperSize.TabIndex = 11
		'
		' txtHeight
		'
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(73, 25)
		Me.txtHeight.Location = New System.Drawing.Point(272, 112)
		Me.txtHeight.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtHeight.TabIndex = 10
		'
		' txtWidth
		'
		Me.txtWidth.Name = "txtWidth"
		Me.txtWidth.Size = New System.Drawing.Size(73, 25)
		Me.txtWidth.Location = New System.Drawing.Point(104, 112)
		Me.txtWidth.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtWidth.TabIndex = 8
		'
		' chkTrackDefault
		'
		Me.chkTrackDefault.Name = "chkTrackDefault"
		Me.chkTrackDefault.Size = New System.Drawing.Size(161, 25)
		Me.chkTrackDefault.Location = New System.Drawing.Point(416, 72)
		Me.chkTrackDefault.Caption = "&Track Default"
		Me.chkTrackDefault.TabIndex = 6
		'
		' cboPrinters
		'
		Me.cboPrinters.Name = "cboPrinters"
		Me.cboPrinters.Size = New System.Drawing.Size(281, 24)
		Me.cboPrinters.Location = New System.Drawing.Point(104, 32)
		Me.cboPrinters.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboPrinters.TabIndex = 0
		'
		' Label1_016
		'
		Me.Label1_016.Name = "Label1_016"
		Me.Label1_016.Size = New System.Drawing.Size(97, 17)
		Me.Label1_016.Location = New System.Drawing.Point(512, 280)
		Me.Label1_016.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_016.Caption = "Zoom"
		Me.Label1_016.TabIndex = 36
		'
		' lblDriverName
		'
		Me.lblDriverName.Name = "lblDriverName"
		Me.lblDriverName.Size = New System.Drawing.Size(121, 25)
		Me.lblDriverName.Location = New System.Drawing.Point(104, 72)
		Me.lblDriverName.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblDriverName.TabIndex = 1
		'
		' Label1_015
		'
		Me.Label1_015.Name = "Label1_015"
		Me.Label1_015.Size = New System.Drawing.Size(97, 17)
		Me.Label1_015.Location = New System.Drawing.Point(344, 160)
		Me.Label1_015.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_015.Caption = "ScaleWidth"
		Me.Label1_015.TabIndex = 34
		'
		' Label1_014
		'
		Me.Label1_014.Name = "Label1_014"
		Me.Label1_014.Size = New System.Drawing.Size(81, 17)
		Me.Label1_014.Location = New System.Drawing.Point(528, 160)
		Me.Label1_014.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_014.Caption = "ScaleHeight"
		Me.Label1_014.TabIndex = 33
		'
		' Label1_013
		'
		Me.Label1_013.Name = "Label1_013"
		Me.Label1_013.Size = New System.Drawing.Size(97, 17)
		Me.Label1_013.Location = New System.Drawing.Point(0, 160)
		Me.Label1_013.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_013.Caption = "ScaleLeft"
		Me.Label1_013.TabIndex = 30
		'
		' Label1_012
		'
		Me.Label1_012.Name = "Label1_012"
		Me.Label1_012.Size = New System.Drawing.Size(65, 17)
		Me.Label1_012.Location = New System.Drawing.Point(200, 160)
		Me.Label1_012.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_012.Caption = "ScaleTop"
		Me.Label1_012.TabIndex = 29
		'
		' Label1_011
		'
		Me.Label1_011.Name = "Label1_011"
		Me.Label1_011.Size = New System.Drawing.Size(97, 17)
		Me.Label1_011.Location = New System.Drawing.Point(344, 240)
		Me.Label1_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_011.Caption = "PrintQuality"
		Me.Label1_011.TabIndex = 26
		'
		' Label1_010
		'
		Me.Label1_010.Name = "Label1_010"
		Me.Label1_010.Size = New System.Drawing.Size(97, 17)
		Me.Label1_010.Location = New System.Drawing.Point(0, 280)
		Me.Label1_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_010.Caption = "PaperBin"
		Me.Label1_010.TabIndex = 24
		'
		' Label1_009
		'
		Me.Label1_009.Name = "Label1_009"
		Me.Label1_009.Size = New System.Drawing.Size(97, 17)
		Me.Label1_009.Location = New System.Drawing.Point(344, 200)
		Me.Label1_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_009.Caption = "Duplex"
		Me.Label1_009.TabIndex = 22
		'
		' Label1_008
		'
		Me.Label1_008.Name = "Label1_008"
		Me.Label1_008.Size = New System.Drawing.Size(97, 17)
		Me.Label1_008.Location = New System.Drawing.Point(344, 280)
		Me.Label1_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_008.Caption = "Copies"
		Me.Label1_008.TabIndex = 20
		'
		' Label1_007
		'
		Me.Label1_007.Name = "Label1_007"
		Me.Label1_007.Size = New System.Drawing.Size(97, 17)
		Me.Label1_007.Location = New System.Drawing.Point(0, 240)
		Me.Label1_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_007.Caption = "ColorMode"
		Me.Label1_007.TabIndex = 18
		'
		' Label1_006
		'
		Me.Label1_006.Name = "Label1_006"
		Me.Label1_006.Size = New System.Drawing.Size(97, 17)
		Me.Label1_006.Location = New System.Drawing.Point(0, 200)
		Me.Label1_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_006.Caption = "Orientation"
		Me.Label1_006.TabIndex = 16
		'
		' Label1_005
		'
		Me.Label1_005.Name = "Label1_005"
		Me.Label1_005.Size = New System.Drawing.Size(97, 17)
		Me.Label1_005.Location = New System.Drawing.Point(344, 120)
		Me.Label1_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_005.Caption = "PaperSize"
		Me.Label1_005.TabIndex = 14
		'
		' Label1_004
		'
		Me.Label1_004.Name = "Label1_004"
		Me.Label1_004.Size = New System.Drawing.Size(49, 17)
		Me.Label1_004.Location = New System.Drawing.Point(216, 120)
		Me.Label1_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_004.Caption = "Height"
		Me.Label1_004.TabIndex = 9
		'
		' Label1_003
		'
		Me.Label1_003.Name = "Label1_003"
		Me.Label1_003.Size = New System.Drawing.Size(97, 17)
		Me.Label1_003.Location = New System.Drawing.Point(0, 120)
		Me.Label1_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_003.Caption = "Width"
		Me.Label1_003.TabIndex = 7
		'
		' lblPort
		'
		Me.lblPort.Name = "lblPort"
		Me.lblPort.Size = New System.Drawing.Size(89, 25)
		Me.lblPort.Location = New System.Drawing.Point(272, 72)
		Me.lblPort.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPort.TabIndex = 5
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(41, 17)
		Me.Label1_002.Location = New System.Drawing.Point(224, 80)
		Me.Label1_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_002.Caption = "Port"
		Me.Label1_002.TabIndex = 4
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(97, 17)
		Me.Label1_000.Location = New System.Drawing.Point(-8, 40)
		Me.Label1_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_000.Caption = "DeviceName"
		Me.Label1_000.TabIndex = 3
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(97, 17)
		Me.Label1_001.Location = New System.Drawing.Point(0, 80)
		Me.Label1_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1_001.Caption = "DriverName"
		Me.Label1_001.TabIndex = 2
		'
		' frmPrinter
		'
		Me.Name = "frmPrinter"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Printer Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(729, 390)

		Me.Controls.Add(cmdTestPage)
		Me.Controls.Add(txtZoom)
		Me.Controls.Add(txtScaleWidth)
		Me.Controls.Add(txtScaleHeight)
		Me.Controls.Add(txtScaleLeft)
		Me.Controls.Add(txtScaleTop)
		Me.Controls.Add(cboPrintQuality)
		Me.Controls.Add(cboPaperBin)
		Me.Controls.Add(cboDuplex)
		Me.Controls.Add(txtCopies)
		Me.Controls.Add(cboColorMode)
		Me.Controls.Add(cboOrientation)
		Me.Controls.Add(cmdMakeCurrent)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(cboPaperSize)
		Me.Controls.Add(txtHeight)
		Me.Controls.Add(txtWidth)
		Me.Controls.Add(chkTrackDefault)
		Me.Controls.Add(cboPrinters)
		Me.Controls.Add(Label1_016)
		Me.Controls.Add(lblDriverName)
		Me.Controls.Add(Label1_015)
		Me.Controls.Add(Label1_014)
		Me.Controls.Add(Label1_013)
		Me.Controls.Add(Label1_012)
		Me.Controls.Add(Label1_011)
		Me.Controls.Add(Label1_010)
		Me.Controls.Add(Label1_009)
		Me.Controls.Add(Label1_008)
		Me.Controls.Add(Label1_007)
		Me.Controls.Add(Label1_006)
		Me.Controls.Add(Label1_005)
		Me.Controls.Add(Label1_004)
		Me.Controls.Add(Label1_003)
		Me.Controls.Add(lblPort)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_000)
		Me.Controls.Add(Label1_001)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
