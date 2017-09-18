<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmKey
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
		Me.lblLug = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblLug_000, lblLug_006, lblLug_005, lblLug_004, lblLug_003, lblLug_002, lblLug_001)
		Me.lblWheelSet = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblWheelSet_001, lblWheelSet_002, lblWheelSet_003, lblWheelSet_004, lblWheelSet_005, lblWheelSet_006)
		Me.lblWheelInBox = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblWheelInBox_012, lblWheelInBox_011, lblWheelInBox_010, lblWheelInBox_009, lblWheelInBox_008, lblWheelInBox_007, lblWheelInBox_006, lblWheelInBox_005, lblWheelInBox_004, lblWheelInBox_003, lblWheelInBox_002, lblWheelInBox_001)
		Me.lblPin = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblPin_000, lblPin_047, lblPin_046, lblPin_045, lblPin_044, lblPin_043, lblPin_042, lblPin_041, lblPin_040, lblPin_039, lblPin_038, lblPin_037, lblPin_036, lblPin_035, lblPin_034, lblPin_033, lblPin_032, lblPin_031, lblPin_030, lblPin_029, lblPin_028, lblPin_027, lblPin_026, lblPin_025, lblPin_024, lblPin_023, lblPin_022, lblPin_021, lblPin_020, lblPin_019, lblPin_018, lblPin_017, lblPin_016, lblPin_015, lblPin_014, lblPin_013, lblPin_012, lblPin_011, lblPin_010, lblPin_009, lblPin_008, lblPin_007, lblPin_006, lblPin_005, lblPin_004, lblPin_003, lblPin_002, lblPin_001)
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
	Public lblLug As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public lblWheelSet As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public lblWheelInBox As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public lblPin As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdOK As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Frame2 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents VScroll1 As CodeArchitects.VB6Library.VB6VScrollBar
	Public WithEvents lblLugMsg As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lbll As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLug_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Frame1 As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblC52 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelSet_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents picWheelBox As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblBox As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelInBox_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblClear As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblColor As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPrompt As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWheelOut As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_047 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_046 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_045 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_044 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_043 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_042 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_041 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_040 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_039 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_038 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_037 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_036 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_035 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_034 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_033 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_032 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_031 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_030 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_029 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_028 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_027 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_026 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_025 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_024 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_023 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_022 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_021 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_020 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_019 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_018 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_017 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_016 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_015 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_014 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_013 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPin_001 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdOK = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Frame2 = New CodeArchitects.VB6Library.VB6Frame()
		Me.VScroll1 = New CodeArchitects.VB6Library.VB6VScrollBar()
		Me.lblLugMsg = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.lbll = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLug_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame1 = New CodeArchitects.VB6Library.VB6Frame()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblC52 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelSet_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.picWheelBox = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblBox = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelInBox_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblClear = New CodeArchitects.VB6Library.VB6Label()
		Me.lblColor = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPrompt = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWheelOut = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_047 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_046 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_045 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_044 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_043 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_042 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_041 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_040 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_039 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_038 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_037 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_036 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_035 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_034 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_033 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_032 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_031 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_030 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_029 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_028 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_027 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_026 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_025 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_024 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_023 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_022 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_021 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_020 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_019 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_018 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_017 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_016 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_015 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_014 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_013 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPin_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Picture2.SuspendLayout()
		Me.picWheelBox.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(472, 344)
		Me.cmdCancel.Caption = "&Cancel"
		Me.cmdCancel.TabIndex = 1
		Me.cmdCancel.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdOK
		'
		Me.cmdOK.Name = "cmdOK"
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(392, 344)
		Me.cmdOK.Caption = "&OK"
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.BackColor = FromOleColor6(CInt(&H8000000F))
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' Frame2
		'
		Me.Frame2.Name = "Frame2"
		Me.Frame2.Size = New System.Drawing.Size(265, 329)
		Me.Frame2.Location = New System.Drawing.Point(280, 8)
		Me.Frame2.Caption = "Lugs on Drum Bars"
		Me.Frame2.TabIndex = 4
		Me.Frame2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' VScroll1
		'
		Me.VScroll1.Name = "VScroll1"
		Me.VScroll1.Size = New System.Drawing.Size(17, 129)
		Me.VScroll1.Location = New System.Drawing.Point(232, 24)
		Me.VScroll1.Max = 32
		Me.VScroll1.Min = 1
		Me.VScroll1.TabIndex = 2
		Me.VScroll1.Value = 1
		Me.VScroll1.LargeChange = 1
		Me.VScroll1.TabStop = True
		'
		' lblLugMsg
		'
		Me.lblLugMsg.Name = "lblLugMsg"
		Me.lblLugMsg.Size = New System.Drawing.Size(201, 43)
		Me.lblLugMsg.Location = New System.Drawing.Point(16, 48)
		Me.lblLugMsg.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblLugMsg.TabIndex = 89
		Me.lblLugMsg.AutoSize = False
		Me.lblLugMsg.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(201, 33)
		Me.Label2.Location = New System.Drawing.Point(16, 96)
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "Use Scrollbar to select Bar and Click Lugs 1 - 6 to place or remove Lug."
		Me.Label2.TabIndex = 87
		Me.Label2.AutoSize = False
		Me.Label2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 136)
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "= Lug placed"
		Me.Label1.TabIndex = 86
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lbll
		'
		Me.lbll.Name = "lbll"
		Me.lbll.Size = New System.Drawing.Size(17, 15)
		Me.lbll.Location = New System.Drawing.Point(16, 136)
		Me.lbll.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lbll.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lbll.BackColor = FromOleColor6(CInt(&H008080FF))
		Me.lbll.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lbll.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lbll.TabIndex = 85
		Me.lbll.AutoSize = False
		'
		' lblLug_000
		'
		Me.lblLug_000.Name = "lblLug_000"
		Me.lblLug_000.Size = New System.Drawing.Size(57, 15)
		Me.lblLug_000.Location = New System.Drawing.Point(16, 24)
		Me.lblLug_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_000.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_000.Caption = "Bar 1"
		Me.lblLug_000.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_000.TabIndex = 84
		Me.lblLug_000.AutoSize = False
		'
		' lblLug_006
		'
		Me.lblLug_006.Name = "lblLug_006"
		Me.lblLug_006.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_006.Location = New System.Drawing.Point(200, 24)
		Me.lblLug_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_006.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_006.Caption = "6"
		Me.lblLug_006.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_006.TabIndex = 80
		Me.lblLug_006.AutoSize = False
		'
		' lblLug_005
		'
		Me.lblLug_005.Name = "lblLug_005"
		Me.lblLug_005.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_005.Location = New System.Drawing.Point(176, 24)
		Me.lblLug_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_005.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_005.Caption = "5"
		Me.lblLug_005.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_005.TabIndex = 79
		Me.lblLug_005.AutoSize = False
		'
		' lblLug_004
		'
		Me.lblLug_004.Name = "lblLug_004"
		Me.lblLug_004.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_004.Location = New System.Drawing.Point(152, 24)
		Me.lblLug_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_004.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_004.Caption = "4"
		Me.lblLug_004.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_004.TabIndex = 78
		Me.lblLug_004.AutoSize = False
		'
		' lblLug_003
		'
		Me.lblLug_003.Name = "lblLug_003"
		Me.lblLug_003.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_003.Location = New System.Drawing.Point(128, 24)
		Me.lblLug_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_003.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_003.Caption = "3"
		Me.lblLug_003.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_003.TabIndex = 77
		Me.lblLug_003.AutoSize = False
		'
		' lblLug_002
		'
		Me.lblLug_002.Name = "lblLug_002"
		Me.lblLug_002.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_002.Location = New System.Drawing.Point(104, 24)
		Me.lblLug_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_002.Caption = "2"
		Me.lblLug_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_002.TabIndex = 76
		Me.lblLug_002.AutoSize = False
		'
		' lblLug_001
		'
		Me.lblLug_001.Name = "lblLug_001"
		Me.lblLug_001.Size = New System.Drawing.Size(17, 15)
		Me.lblLug_001.Location = New System.Drawing.Point(80, 24)
		Me.lblLug_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblLug_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblLug_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblLug_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLug_001.Caption = "1"
		Me.lblLug_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblLug_001.TabIndex = 75
		Me.lblLug_001.AutoSize = False
		'
		' Frame1
		'
		Me.Frame1.Name = "Frame1"
		Me.Frame1.Size = New System.Drawing.Size(265, 329)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.Caption = "Wheel Configuration"
		Me.Frame1.TabIndex = 3
		Me.Frame1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(233, 49)
		Me.Picture2.Location = New System.Drawing.Point(16, 24)
		Me.Picture2.TabIndex = 67
		Me.Picture2.TabStop = False
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture2.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblC52
		'
		Me.lblC52.Name = "lblC52"
		Me.lblC52.Size = New System.Drawing.Size(233, 17)
		Me.lblC52.Location = New System.Drawing.Point(0, 7)
		Me.lblC52.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblC52.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblC52.Caption = "BC-52"
		Me.lblC52.TabIndex = 74
		Me.lblC52.AutoSize = False
		Me.lblC52.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblWheelSet_001
		'
		Me.lblWheelSet_001.Name = "lblWheelSet_001"
		Me.lblWheelSet_001.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_001.Location = New System.Drawing.Point(40, 24)
		Me.lblWheelSet_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_001.TabIndex = 73
		Me.lblWheelSet_001.AutoSize = False
		'
		' lblWheelSet_002
		'
		Me.lblWheelSet_002.Name = "lblWheelSet_002"
		Me.lblWheelSet_002.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_002.Location = New System.Drawing.Point(64, 24)
		Me.lblWheelSet_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_002.TabIndex = 72
		Me.lblWheelSet_002.AutoSize = False
		'
		' lblWheelSet_003
		'
		Me.lblWheelSet_003.Name = "lblWheelSet_003"
		Me.lblWheelSet_003.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_003.Location = New System.Drawing.Point(88, 24)
		Me.lblWheelSet_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_003.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_003.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_003.TabIndex = 71
		Me.lblWheelSet_003.AutoSize = False
		'
		' lblWheelSet_004
		'
		Me.lblWheelSet_004.Name = "lblWheelSet_004"
		Me.lblWheelSet_004.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_004.Location = New System.Drawing.Point(112, 24)
		Me.lblWheelSet_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_004.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_004.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_004.TabIndex = 70
		Me.lblWheelSet_004.AutoSize = False
		'
		' lblWheelSet_005
		'
		Me.lblWheelSet_005.Name = "lblWheelSet_005"
		Me.lblWheelSet_005.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_005.Location = New System.Drawing.Point(136, 24)
		Me.lblWheelSet_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_005.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_005.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_005.TabIndex = 69
		Me.lblWheelSet_005.AutoSize = False
		'
		' lblWheelSet_006
		'
		Me.lblWheelSet_006.Name = "lblWheelSet_006"
		Me.lblWheelSet_006.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelSet_006.Location = New System.Drawing.Point(160, 24)
		Me.lblWheelSet_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelSet_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelSet_006.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelSet_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelSet_006.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelSet_006.TabIndex = 68
		Me.lblWheelSet_006.AutoSize = False
		'
		' picWheelBox
		'
		Me.picWheelBox.Name = "picWheelBox"
		Me.picWheelBox.Size = New System.Drawing.Size(233, 81)
		Me.picWheelBox.Location = New System.Drawing.Point(16, 224)
		Me.picWheelBox.TabIndex = 53
		Me.picWheelBox.TabStop = False
		Me.picWheelBox.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.picWheelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picWheelBox.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picWheelBox.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblBox
		'
		Me.lblBox.Name = "lblBox"
		Me.lblBox.Size = New System.Drawing.Size(209, 17)
		Me.lblBox.Location = New System.Drawing.Point(8, 5)
		Me.lblBox.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblBox.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblBox.Caption = "Wheel Selection Box"
		Me.lblBox.TabIndex = 66
		Me.lblBox.AutoSize = False
		Me.lblBox.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblWheelInBox_012
		'
		Me.lblWheelInBox_012.Name = "lblWheelInBox_012"
		Me.lblWheelInBox_012.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_012.Location = New System.Drawing.Point(184, 48)
		Me.lblWheelInBox_012.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_012.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_012.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_012.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_012.Caption = "47"
		Me.lblWheelInBox_012.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_012.TabIndex = 65
		Me.lblWheelInBox_012.AutoSize = False
		'
		' lblWheelInBox_011
		'
		Me.lblWheelInBox_011.Name = "lblWheelInBox_011"
		Me.lblWheelInBox_011.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_011.Location = New System.Drawing.Point(151, 48)
		Me.lblWheelInBox_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_011.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_011.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_011.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_011.Caption = "46"
		Me.lblWheelInBox_011.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_011.TabIndex = 64
		Me.lblWheelInBox_011.AutoSize = False
		'
		' lblWheelInBox_010
		'
		Me.lblWheelInBox_010.Name = "lblWheelInBox_010"
		Me.lblWheelInBox_010.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_010.Location = New System.Drawing.Point(118, 48)
		Me.lblWheelInBox_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_010.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_010.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_010.Caption = "43"
		Me.lblWheelInBox_010.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_010.TabIndex = 63
		Me.lblWheelInBox_010.AutoSize = False
		'
		' lblWheelInBox_009
		'
		Me.lblWheelInBox_009.Name = "lblWheelInBox_009"
		Me.lblWheelInBox_009.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_009.Location = New System.Drawing.Point(85, 48)
		Me.lblWheelInBox_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_009.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_009.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_009.Caption = "42"
		Me.lblWheelInBox_009.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_009.TabIndex = 62
		Me.lblWheelInBox_009.AutoSize = False
		'
		' lblWheelInBox_008
		'
		Me.lblWheelInBox_008.Name = "lblWheelInBox_008"
		Me.lblWheelInBox_008.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_008.Location = New System.Drawing.Point(51, 48)
		Me.lblWheelInBox_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_008.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_008.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_008.Caption = "41"
		Me.lblWheelInBox_008.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_008.TabIndex = 61
		Me.lblWheelInBox_008.AutoSize = False
		'
		' lblWheelInBox_007
		'
		Me.lblWheelInBox_007.Name = "lblWheelInBox_007"
		Me.lblWheelInBox_007.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_007.Location = New System.Drawing.Point(18, 48)
		Me.lblWheelInBox_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_007.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_007.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_007.Caption = "38"
		Me.lblWheelInBox_007.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_007.TabIndex = 60
		Me.lblWheelInBox_007.AutoSize = False
		'
		' lblWheelInBox_006
		'
		Me.lblWheelInBox_006.Name = "lblWheelInBox_006"
		Me.lblWheelInBox_006.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_006.Location = New System.Drawing.Point(184, 24)
		Me.lblWheelInBox_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_006.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_006.Caption = "37"
		Me.lblWheelInBox_006.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_006.TabIndex = 59
		Me.lblWheelInBox_006.AutoSize = False
		'
		' lblWheelInBox_005
		'
		Me.lblWheelInBox_005.Name = "lblWheelInBox_005"
		Me.lblWheelInBox_005.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_005.Location = New System.Drawing.Point(151, 24)
		Me.lblWheelInBox_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_005.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_005.Caption = "34"
		Me.lblWheelInBox_005.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_005.TabIndex = 58
		Me.lblWheelInBox_005.AutoSize = False
		'
		' lblWheelInBox_004
		'
		Me.lblWheelInBox_004.Name = "lblWheelInBox_004"
		Me.lblWheelInBox_004.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_004.Location = New System.Drawing.Point(118, 24)
		Me.lblWheelInBox_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_004.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_004.Caption = "31"
		Me.lblWheelInBox_004.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_004.TabIndex = 57
		Me.lblWheelInBox_004.AutoSize = False
		'
		' lblWheelInBox_003
		'
		Me.lblWheelInBox_003.Name = "lblWheelInBox_003"
		Me.lblWheelInBox_003.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_003.Location = New System.Drawing.Point(85, 24)
		Me.lblWheelInBox_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_003.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_003.Caption = "29"
		Me.lblWheelInBox_003.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_003.TabIndex = 56
		Me.lblWheelInBox_003.AutoSize = False
		'
		' lblWheelInBox_002
		'
		Me.lblWheelInBox_002.Name = "lblWheelInBox_002"
		Me.lblWheelInBox_002.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_002.Location = New System.Drawing.Point(51, 24)
		Me.lblWheelInBox_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_002.Caption = "26"
		Me.lblWheelInBox_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_002.TabIndex = 55
		Me.lblWheelInBox_002.AutoSize = False
		'
		' lblWheelInBox_001
		'
		Me.lblWheelInBox_001.Name = "lblWheelInBox_001"
		Me.lblWheelInBox_001.Size = New System.Drawing.Size(25, 17)
		Me.lblWheelInBox_001.Location = New System.Drawing.Point(18, 24)
		Me.lblWheelInBox_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelInBox_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelInBox_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelInBox_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelInBox_001.Caption = "25"
		Me.lblWheelInBox_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelInBox_001.TabIndex = 54
		Me.lblWheelInBox_001.AutoSize = False
		'
		' lblClear
		'
		Me.lblClear.Name = "lblClear"
		Me.lblClear.Size = New System.Drawing.Size(137, 15)
		Me.lblClear.Location = New System.Drawing.Point(16, 200)
		Me.lblClear.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblClear.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblClear.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblClear.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblClear.Caption = "Clear All Pins"
		Me.lblClear.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblClear.TabIndex = 88
		Me.lblClear.Visible = False
		Me.lblClear.AutoSize = False
		'
		' lblColor
		'
		Me.lblColor.Name = "lblColor"
		Me.lblColor.Size = New System.Drawing.Size(65, 17)
		Me.lblColor.Location = New System.Drawing.Point(179, 200)
		Me.lblColor.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblColor.Caption = "= Active Pin"
		Me.lblColor.TabIndex = 83
		Me.lblColor.Visible = False
		Me.lblColor.AutoSize = False
		Me.lblColor.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblPin_000
		'
		Me.lblPin_000.Name = "lblPin_000"
		Me.lblPin_000.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_000.Location = New System.Drawing.Point(160, 200)
		Me.lblPin_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_000.BackColor = FromOleColor6(CInt(&H008080FF))
		Me.lblPin_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_000.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_000.TabIndex = 82
		Me.lblPin_000.Visible = False
		Me.lblPin_000.AutoSize = False
		'
		' lblPrompt
		'
		Me.lblPrompt.Name = "lblPrompt"
		Me.lblPrompt.Size = New System.Drawing.Size(265, 25)
		Me.lblPrompt.Location = New System.Drawing.Point(0, 136)
		Me.lblPrompt.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPrompt.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblPrompt.Caption = "Prompt"
		Me.lblPrompt.TabIndex = 81
		Me.lblPrompt.Visible = False
		Me.lblPrompt.AutoSize = False
		Me.lblPrompt.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblWheelOut
		'
		Me.lblWheelOut.Name = "lblWheelOut"
		Me.lblWheelOut.Size = New System.Drawing.Size(233, 17)
		Me.lblWheelOut.Location = New System.Drawing.Point(16, 88)
		Me.lblWheelOut.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWheelOut.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWheelOut.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWheelOut.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblWheelOut.Caption = "Wheel"
		Me.lblWheelOut.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblWheelOut.TabIndex = 52
		Me.lblWheelOut.Visible = False
		Me.lblWheelOut.AutoSize = False
		'
		' lblPin_047
		'
		Me.lblPin_047.Name = "lblPin_047"
		Me.lblPin_047.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_047.Location = New System.Drawing.Point(232, 128)
		Me.lblPin_047.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_047.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_047.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_047.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_047.Caption = "47"
		Me.lblPin_047.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_047.TabIndex = 51
		Me.lblPin_047.Visible = False
		Me.lblPin_047.AutoSize = False
		'
		' lblPin_046
		'
		Me.lblPin_046.Name = "lblPin_046"
		Me.lblPin_046.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_046.Location = New System.Drawing.Point(232, 112)
		Me.lblPin_046.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_046.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_046.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_046.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_046.Caption = "46"
		Me.lblPin_046.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_046.TabIndex = 50
		Me.lblPin_046.Visible = False
		Me.lblPin_046.AutoSize = False
		'
		' lblPin_045
		'
		Me.lblPin_045.Name = "lblPin_045"
		Me.lblPin_045.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_045.Location = New System.Drawing.Point(208, 176)
		Me.lblPin_045.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_045.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_045.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_045.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_045.Caption = "45"
		Me.lblPin_045.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_045.TabIndex = 49
		Me.lblPin_045.Visible = False
		Me.lblPin_045.AutoSize = False
		'
		' lblPin_044
		'
		Me.lblPin_044.Name = "lblPin_044"
		Me.lblPin_044.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_044.Location = New System.Drawing.Point(208, 160)
		Me.lblPin_044.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_044.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_044.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_044.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_044.Caption = "44"
		Me.lblPin_044.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_044.TabIndex = 48
		Me.lblPin_044.Visible = False
		Me.lblPin_044.AutoSize = False
		'
		' lblPin_043
		'
		Me.lblPin_043.Name = "lblPin_043"
		Me.lblPin_043.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_043.Location = New System.Drawing.Point(208, 144)
		Me.lblPin_043.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_043.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_043.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_043.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_043.Caption = "43"
		Me.lblPin_043.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_043.TabIndex = 47
		Me.lblPin_043.Visible = False
		Me.lblPin_043.AutoSize = False
		'
		' lblPin_042
		'
		Me.lblPin_042.Name = "lblPin_042"
		Me.lblPin_042.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_042.Location = New System.Drawing.Point(208, 128)
		Me.lblPin_042.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_042.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_042.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_042.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_042.Caption = "42"
		Me.lblPin_042.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_042.TabIndex = 46
		Me.lblPin_042.Visible = False
		Me.lblPin_042.AutoSize = False
		'
		' lblPin_041
		'
		Me.lblPin_041.Name = "lblPin_041"
		Me.lblPin_041.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_041.Location = New System.Drawing.Point(208, 112)
		Me.lblPin_041.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_041.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_041.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_041.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_041.Caption = "41"
		Me.lblPin_041.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_041.TabIndex = 45
		Me.lblPin_041.Visible = False
		Me.lblPin_041.AutoSize = False
		'
		' lblPin_040
		'
		Me.lblPin_040.Name = "lblPin_040"
		Me.lblPin_040.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_040.Location = New System.Drawing.Point(184, 176)
		Me.lblPin_040.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_040.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_040.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_040.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_040.Caption = "40"
		Me.lblPin_040.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_040.TabIndex = 44
		Me.lblPin_040.Visible = False
		Me.lblPin_040.AutoSize = False
		'
		' lblPin_039
		'
		Me.lblPin_039.Name = "lblPin_039"
		Me.lblPin_039.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_039.Location = New System.Drawing.Point(184, 160)
		Me.lblPin_039.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_039.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_039.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_039.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_039.Caption = "39"
		Me.lblPin_039.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_039.TabIndex = 43
		Me.lblPin_039.Visible = False
		Me.lblPin_039.AutoSize = False
		'
		' lblPin_038
		'
		Me.lblPin_038.Name = "lblPin_038"
		Me.lblPin_038.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_038.Location = New System.Drawing.Point(184, 144)
		Me.lblPin_038.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_038.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_038.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_038.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_038.Caption = "38"
		Me.lblPin_038.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_038.TabIndex = 42
		Me.lblPin_038.Visible = False
		Me.lblPin_038.AutoSize = False
		'
		' lblPin_037
		'
		Me.lblPin_037.Name = "lblPin_037"
		Me.lblPin_037.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_037.Location = New System.Drawing.Point(184, 128)
		Me.lblPin_037.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_037.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_037.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_037.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_037.Caption = "37"
		Me.lblPin_037.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_037.TabIndex = 41
		Me.lblPin_037.Visible = False
		Me.lblPin_037.AutoSize = False
		'
		' lblPin_036
		'
		Me.lblPin_036.Name = "lblPin_036"
		Me.lblPin_036.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_036.Location = New System.Drawing.Point(184, 112)
		Me.lblPin_036.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_036.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_036.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_036.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_036.Caption = "36"
		Me.lblPin_036.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_036.TabIndex = 40
		Me.lblPin_036.Visible = False
		Me.lblPin_036.AutoSize = False
		'
		' lblPin_035
		'
		Me.lblPin_035.Name = "lblPin_035"
		Me.lblPin_035.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_035.Location = New System.Drawing.Point(160, 176)
		Me.lblPin_035.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_035.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_035.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_035.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_035.Caption = "35"
		Me.lblPin_035.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_035.TabIndex = 39
		Me.lblPin_035.Visible = False
		Me.lblPin_035.AutoSize = False
		'
		' lblPin_034
		'
		Me.lblPin_034.Name = "lblPin_034"
		Me.lblPin_034.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_034.Location = New System.Drawing.Point(160, 160)
		Me.lblPin_034.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_034.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_034.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_034.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_034.Caption = "34"
		Me.lblPin_034.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_034.TabIndex = 38
		Me.lblPin_034.Visible = False
		Me.lblPin_034.AutoSize = False
		'
		' lblPin_033
		'
		Me.lblPin_033.Name = "lblPin_033"
		Me.lblPin_033.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_033.Location = New System.Drawing.Point(160, 144)
		Me.lblPin_033.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_033.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_033.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_033.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_033.Caption = "33"
		Me.lblPin_033.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_033.TabIndex = 37
		Me.lblPin_033.Visible = False
		Me.lblPin_033.AutoSize = False
		'
		' lblPin_032
		'
		Me.lblPin_032.Name = "lblPin_032"
		Me.lblPin_032.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_032.Location = New System.Drawing.Point(160, 128)
		Me.lblPin_032.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_032.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_032.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_032.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_032.Caption = "32"
		Me.lblPin_032.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_032.TabIndex = 36
		Me.lblPin_032.Visible = False
		Me.lblPin_032.AutoSize = False
		'
		' lblPin_031
		'
		Me.lblPin_031.Name = "lblPin_031"
		Me.lblPin_031.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_031.Location = New System.Drawing.Point(160, 112)
		Me.lblPin_031.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_031.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_031.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_031.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_031.Caption = "31"
		Me.lblPin_031.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_031.TabIndex = 35
		Me.lblPin_031.Visible = False
		Me.lblPin_031.AutoSize = False
		'
		' lblPin_030
		'
		Me.lblPin_030.Name = "lblPin_030"
		Me.lblPin_030.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_030.Location = New System.Drawing.Point(136, 176)
		Me.lblPin_030.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_030.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_030.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_030.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_030.Caption = "30"
		Me.lblPin_030.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_030.TabIndex = 34
		Me.lblPin_030.Visible = False
		Me.lblPin_030.AutoSize = False
		'
		' lblPin_029
		'
		Me.lblPin_029.Name = "lblPin_029"
		Me.lblPin_029.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_029.Location = New System.Drawing.Point(136, 160)
		Me.lblPin_029.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_029.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_029.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_029.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_029.Caption = "29"
		Me.lblPin_029.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_029.TabIndex = 33
		Me.lblPin_029.Visible = False
		Me.lblPin_029.AutoSize = False
		'
		' lblPin_028
		'
		Me.lblPin_028.Name = "lblPin_028"
		Me.lblPin_028.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_028.Location = New System.Drawing.Point(136, 144)
		Me.lblPin_028.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_028.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_028.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_028.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_028.Caption = "28"
		Me.lblPin_028.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_028.TabIndex = 32
		Me.lblPin_028.Visible = False
		Me.lblPin_028.AutoSize = False
		'
		' lblPin_027
		'
		Me.lblPin_027.Name = "lblPin_027"
		Me.lblPin_027.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_027.Location = New System.Drawing.Point(136, 128)
		Me.lblPin_027.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_027.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_027.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_027.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_027.Caption = "27"
		Me.lblPin_027.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_027.TabIndex = 31
		Me.lblPin_027.Visible = False
		Me.lblPin_027.AutoSize = False
		'
		' lblPin_026
		'
		Me.lblPin_026.Name = "lblPin_026"
		Me.lblPin_026.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_026.Location = New System.Drawing.Point(136, 112)
		Me.lblPin_026.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_026.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_026.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_026.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_026.Caption = "26"
		Me.lblPin_026.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_026.TabIndex = 30
		Me.lblPin_026.Visible = False
		Me.lblPin_026.AutoSize = False
		'
		' lblPin_025
		'
		Me.lblPin_025.Name = "lblPin_025"
		Me.lblPin_025.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_025.Location = New System.Drawing.Point(112, 176)
		Me.lblPin_025.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_025.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_025.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_025.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_025.Caption = "25"
		Me.lblPin_025.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_025.TabIndex = 29
		Me.lblPin_025.Visible = False
		Me.lblPin_025.AutoSize = False
		'
		' lblPin_024
		'
		Me.lblPin_024.Name = "lblPin_024"
		Me.lblPin_024.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_024.Location = New System.Drawing.Point(112, 160)
		Me.lblPin_024.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_024.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_024.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_024.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_024.Caption = "24"
		Me.lblPin_024.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_024.TabIndex = 28
		Me.lblPin_024.Visible = False
		Me.lblPin_024.AutoSize = False
		'
		' lblPin_023
		'
		Me.lblPin_023.Name = "lblPin_023"
		Me.lblPin_023.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_023.Location = New System.Drawing.Point(112, 144)
		Me.lblPin_023.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_023.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_023.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_023.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_023.Caption = "23"
		Me.lblPin_023.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_023.TabIndex = 27
		Me.lblPin_023.Visible = False
		Me.lblPin_023.AutoSize = False
		'
		' lblPin_022
		'
		Me.lblPin_022.Name = "lblPin_022"
		Me.lblPin_022.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_022.Location = New System.Drawing.Point(112, 128)
		Me.lblPin_022.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_022.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_022.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_022.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_022.Caption = "22"
		Me.lblPin_022.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_022.TabIndex = 26
		Me.lblPin_022.Visible = False
		Me.lblPin_022.AutoSize = False
		'
		' lblPin_021
		'
		Me.lblPin_021.Name = "lblPin_021"
		Me.lblPin_021.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_021.Location = New System.Drawing.Point(112, 112)
		Me.lblPin_021.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_021.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_021.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_021.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_021.Caption = "21"
		Me.lblPin_021.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_021.TabIndex = 25
		Me.lblPin_021.Visible = False
		Me.lblPin_021.AutoSize = False
		'
		' lblPin_020
		'
		Me.lblPin_020.Name = "lblPin_020"
		Me.lblPin_020.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_020.Location = New System.Drawing.Point(88, 176)
		Me.lblPin_020.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_020.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_020.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_020.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_020.Caption = "20"
		Me.lblPin_020.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_020.TabIndex = 24
		Me.lblPin_020.Visible = False
		Me.lblPin_020.AutoSize = False
		'
		' lblPin_019
		'
		Me.lblPin_019.Name = "lblPin_019"
		Me.lblPin_019.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_019.Location = New System.Drawing.Point(88, 160)
		Me.lblPin_019.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_019.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_019.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_019.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_019.Caption = "19"
		Me.lblPin_019.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_019.TabIndex = 23
		Me.lblPin_019.Visible = False
		Me.lblPin_019.AutoSize = False
		'
		' lblPin_018
		'
		Me.lblPin_018.Name = "lblPin_018"
		Me.lblPin_018.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_018.Location = New System.Drawing.Point(88, 144)
		Me.lblPin_018.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_018.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_018.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_018.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_018.Caption = "18"
		Me.lblPin_018.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_018.TabIndex = 22
		Me.lblPin_018.Visible = False
		Me.lblPin_018.AutoSize = False
		'
		' lblPin_017
		'
		Me.lblPin_017.Name = "lblPin_017"
		Me.lblPin_017.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_017.Location = New System.Drawing.Point(88, 128)
		Me.lblPin_017.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_017.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_017.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_017.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_017.Caption = "17"
		Me.lblPin_017.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_017.TabIndex = 21
		Me.lblPin_017.Visible = False
		Me.lblPin_017.AutoSize = False
		'
		' lblPin_016
		'
		Me.lblPin_016.Name = "lblPin_016"
		Me.lblPin_016.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_016.Location = New System.Drawing.Point(88, 112)
		Me.lblPin_016.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_016.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_016.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_016.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_016.Caption = "16"
		Me.lblPin_016.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_016.TabIndex = 20
		Me.lblPin_016.Visible = False
		Me.lblPin_016.AutoSize = False
		'
		' lblPin_015
		'
		Me.lblPin_015.Name = "lblPin_015"
		Me.lblPin_015.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_015.Location = New System.Drawing.Point(64, 176)
		Me.lblPin_015.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_015.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_015.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_015.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_015.Caption = "15"
		Me.lblPin_015.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_015.TabIndex = 19
		Me.lblPin_015.Visible = False
		Me.lblPin_015.AutoSize = False
		'
		' lblPin_014
		'
		Me.lblPin_014.Name = "lblPin_014"
		Me.lblPin_014.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_014.Location = New System.Drawing.Point(64, 160)
		Me.lblPin_014.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_014.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_014.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_014.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_014.Caption = "14"
		Me.lblPin_014.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_014.TabIndex = 18
		Me.lblPin_014.Visible = False
		Me.lblPin_014.AutoSize = False
		'
		' lblPin_013
		'
		Me.lblPin_013.Name = "lblPin_013"
		Me.lblPin_013.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_013.Location = New System.Drawing.Point(64, 144)
		Me.lblPin_013.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_013.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_013.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_013.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_013.Caption = "13"
		Me.lblPin_013.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_013.TabIndex = 17
		Me.lblPin_013.Visible = False
		Me.lblPin_013.AutoSize = False
		'
		' lblPin_012
		'
		Me.lblPin_012.Name = "lblPin_012"
		Me.lblPin_012.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_012.Location = New System.Drawing.Point(64, 128)
		Me.lblPin_012.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_012.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_012.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_012.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_012.Caption = "12"
		Me.lblPin_012.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_012.TabIndex = 16
		Me.lblPin_012.Visible = False
		Me.lblPin_012.AutoSize = False
		'
		' lblPin_011
		'
		Me.lblPin_011.Name = "lblPin_011"
		Me.lblPin_011.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_011.Location = New System.Drawing.Point(64, 112)
		Me.lblPin_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_011.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_011.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_011.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_011.Caption = "11"
		Me.lblPin_011.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_011.TabIndex = 15
		Me.lblPin_011.Visible = False
		Me.lblPin_011.AutoSize = False
		'
		' lblPin_010
		'
		Me.lblPin_010.Name = "lblPin_010"
		Me.lblPin_010.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_010.Location = New System.Drawing.Point(40, 176)
		Me.lblPin_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_010.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_010.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_010.Caption = "10"
		Me.lblPin_010.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_010.TabIndex = 14
		Me.lblPin_010.Visible = False
		Me.lblPin_010.AutoSize = False
		'
		' lblPin_009
		'
		Me.lblPin_009.Name = "lblPin_009"
		Me.lblPin_009.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_009.Location = New System.Drawing.Point(40, 160)
		Me.lblPin_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_009.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_009.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_009.Caption = "09"
		Me.lblPin_009.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_009.TabIndex = 13
		Me.lblPin_009.Visible = False
		Me.lblPin_009.AutoSize = False
		'
		' lblPin_008
		'
		Me.lblPin_008.Name = "lblPin_008"
		Me.lblPin_008.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_008.Location = New System.Drawing.Point(40, 144)
		Me.lblPin_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_008.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_008.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_008.Caption = "08"
		Me.lblPin_008.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_008.TabIndex = 12
		Me.lblPin_008.Visible = False
		Me.lblPin_008.AutoSize = False
		'
		' lblPin_007
		'
		Me.lblPin_007.Name = "lblPin_007"
		Me.lblPin_007.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_007.Location = New System.Drawing.Point(40, 128)
		Me.lblPin_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_007.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_007.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_007.Caption = "07"
		Me.lblPin_007.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_007.TabIndex = 11
		Me.lblPin_007.Visible = False
		Me.lblPin_007.AutoSize = False
		'
		' lblPin_006
		'
		Me.lblPin_006.Name = "lblPin_006"
		Me.lblPin_006.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_006.Location = New System.Drawing.Point(40, 112)
		Me.lblPin_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_006.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_006.Caption = "06"
		Me.lblPin_006.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_006.TabIndex = 10
		Me.lblPin_006.Visible = False
		Me.lblPin_006.AutoSize = False
		'
		' lblPin_005
		'
		Me.lblPin_005.Name = "lblPin_005"
		Me.lblPin_005.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_005.Location = New System.Drawing.Point(16, 176)
		Me.lblPin_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_005.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_005.Caption = "05"
		Me.lblPin_005.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_005.TabIndex = 9
		Me.lblPin_005.Visible = False
		Me.lblPin_005.AutoSize = False
		'
		' lblPin_004
		'
		Me.lblPin_004.Name = "lblPin_004"
		Me.lblPin_004.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_004.Location = New System.Drawing.Point(16, 160)
		Me.lblPin_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_004.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_004.Caption = "04"
		Me.lblPin_004.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_004.TabIndex = 8
		Me.lblPin_004.Visible = False
		Me.lblPin_004.AutoSize = False
		'
		' lblPin_003
		'
		Me.lblPin_003.Name = "lblPin_003"
		Me.lblPin_003.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_003.Location = New System.Drawing.Point(16, 144)
		Me.lblPin_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_003.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_003.Caption = "03"
		Me.lblPin_003.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_003.TabIndex = 7
		Me.lblPin_003.Visible = False
		Me.lblPin_003.AutoSize = False
		'
		' lblPin_002
		'
		Me.lblPin_002.Name = "lblPin_002"
		Me.lblPin_002.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_002.Location = New System.Drawing.Point(16, 128)
		Me.lblPin_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_002.Caption = "02"
		Me.lblPin_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_002.TabIndex = 6
		Me.lblPin_002.Visible = False
		Me.lblPin_002.AutoSize = False
		'
		' lblPin_001
		'
		Me.lblPin_001.Name = "lblPin_001"
		Me.lblPin_001.Size = New System.Drawing.Size(17, 15)
		Me.lblPin_001.Location = New System.Drawing.Point(16, 112)
		Me.lblPin_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPin_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblPin_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPin_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPin_001.Caption = "01"
		Me.lblPin_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblPin_001.TabIndex = 5
		Me.lblPin_001.Visible = False
		Me.lblPin_001.AutoSize = False
		'
		' frmKey
		'
		Me.Name = "frmKey"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = " BC-52 Key Setting"
		Me.ControlBox = False
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpOwner
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(551, 374)

		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(Frame2)
		Me.Frame2.Controls.Add(VScroll1)
		Me.Frame2.Controls.Add(lblLugMsg)
		Me.Frame2.Controls.Add(Label2)
		Me.Frame2.Controls.Add(Label1)
		Me.Frame2.Controls.Add(lbll)
		Me.Frame2.Controls.Add(lblLug_000)
		Me.Frame2.Controls.Add(lblLug_006)
		Me.Frame2.Controls.Add(lblLug_005)
		Me.Frame2.Controls.Add(lblLug_004)
		Me.Frame2.Controls.Add(lblLug_003)
		Me.Frame2.Controls.Add(lblLug_002)
		Me.Frame2.Controls.Add(lblLug_001)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(Picture2)
		Me.Picture2.Controls.Add(lblC52)
		Me.Picture2.Controls.Add(lblWheelSet_001)
		Me.Picture2.Controls.Add(lblWheelSet_002)
		Me.Picture2.Controls.Add(lblWheelSet_003)
		Me.Picture2.Controls.Add(lblWheelSet_004)
		Me.Picture2.Controls.Add(lblWheelSet_005)
		Me.Picture2.Controls.Add(lblWheelSet_006)
		Me.Frame1.Controls.Add(picWheelBox)
		Me.picWheelBox.Controls.Add(lblBox)
		Me.picWheelBox.Controls.Add(lblWheelInBox_012)
		Me.picWheelBox.Controls.Add(lblWheelInBox_011)
		Me.picWheelBox.Controls.Add(lblWheelInBox_010)
		Me.picWheelBox.Controls.Add(lblWheelInBox_009)
		Me.picWheelBox.Controls.Add(lblWheelInBox_008)
		Me.picWheelBox.Controls.Add(lblWheelInBox_007)
		Me.picWheelBox.Controls.Add(lblWheelInBox_006)
		Me.picWheelBox.Controls.Add(lblWheelInBox_005)
		Me.picWheelBox.Controls.Add(lblWheelInBox_004)
		Me.picWheelBox.Controls.Add(lblWheelInBox_003)
		Me.picWheelBox.Controls.Add(lblWheelInBox_002)
		Me.picWheelBox.Controls.Add(lblWheelInBox_001)
		Me.Frame1.Controls.Add(lblClear)
		Me.Frame1.Controls.Add(lblColor)
		Me.Frame1.Controls.Add(lblPin_000)
		Me.Frame1.Controls.Add(lblPrompt)
		Me.Frame1.Controls.Add(lblWheelOut)
		Me.Frame1.Controls.Add(lblPin_047)
		Me.Frame1.Controls.Add(lblPin_046)
		Me.Frame1.Controls.Add(lblPin_045)
		Me.Frame1.Controls.Add(lblPin_044)
		Me.Frame1.Controls.Add(lblPin_043)
		Me.Frame1.Controls.Add(lblPin_042)
		Me.Frame1.Controls.Add(lblPin_041)
		Me.Frame1.Controls.Add(lblPin_040)
		Me.Frame1.Controls.Add(lblPin_039)
		Me.Frame1.Controls.Add(lblPin_038)
		Me.Frame1.Controls.Add(lblPin_037)
		Me.Frame1.Controls.Add(lblPin_036)
		Me.Frame1.Controls.Add(lblPin_035)
		Me.Frame1.Controls.Add(lblPin_034)
		Me.Frame1.Controls.Add(lblPin_033)
		Me.Frame1.Controls.Add(lblPin_032)
		Me.Frame1.Controls.Add(lblPin_031)
		Me.Frame1.Controls.Add(lblPin_030)
		Me.Frame1.Controls.Add(lblPin_029)
		Me.Frame1.Controls.Add(lblPin_028)
		Me.Frame1.Controls.Add(lblPin_027)
		Me.Frame1.Controls.Add(lblPin_026)
		Me.Frame1.Controls.Add(lblPin_025)
		Me.Frame1.Controls.Add(lblPin_024)
		Me.Frame1.Controls.Add(lblPin_023)
		Me.Frame1.Controls.Add(lblPin_022)
		Me.Frame1.Controls.Add(lblPin_021)
		Me.Frame1.Controls.Add(lblPin_020)
		Me.Frame1.Controls.Add(lblPin_019)
		Me.Frame1.Controls.Add(lblPin_018)
		Me.Frame1.Controls.Add(lblPin_017)
		Me.Frame1.Controls.Add(lblPin_016)
		Me.Frame1.Controls.Add(lblPin_015)
		Me.Frame1.Controls.Add(lblPin_014)
		Me.Frame1.Controls.Add(lblPin_013)
		Me.Frame1.Controls.Add(lblPin_012)
		Me.Frame1.Controls.Add(lblPin_011)
		Me.Frame1.Controls.Add(lblPin_010)
		Me.Frame1.Controls.Add(lblPin_009)
		Me.Frame1.Controls.Add(lblPin_008)
		Me.Frame1.Controls.Add(lblPin_007)
		Me.Frame1.Controls.Add(lblPin_006)
		Me.Frame1.Controls.Add(lblPin_005)
		Me.Frame1.Controls.Add(lblPin_004)
		Me.Frame1.Controls.Add(lblPin_003)
		Me.Frame1.Controls.Add(lblPin_002)
		Me.Frame1.Controls.Add(lblPin_001)
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Picture2.ResumeLayout(False)
		Me.picWheelBox.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
