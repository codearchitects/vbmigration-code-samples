<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCanvas
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
		Me.txtLight = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtLight_000, txtLight_001, txtLight_002)
		Me.optLoc = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optLoc_000, optLoc_001)
		Me.txtTrans = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtTrans_000, txtTrans_001, txtTrans_002)
		Me.txtRot = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtRot_000, txtRot_001, txtRot_002)
		Me.optColor = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)(optColor_000, optColor_001)
		Me.lblRGBA = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblRGBA_002, lblRGBA_001, lblRGBA_000, lblRGBA_003)
		Me.mnuRender = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuRender_000, mnuRender_001, mnuRender_002, mnuRender_003, mnuRender_004, mnuRender_005)
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
	Public txtLight As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public optLoc As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public txtTrans As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public txtRot As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public optColor As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6OptionButton)
	Public lblRGBA As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public mnuRender As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents picCarry As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents fraLight As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents txtLight_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtLight_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtLight_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdApply As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents optLoc_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optLoc_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents lblLX As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLY As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLZ As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label13 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fraPosition As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label16 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label17 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label18 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTz As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTy As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTx As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRz As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRy As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRx As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblS As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFPS As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label15 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fraProperties As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents chkShow As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents scrFaces As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents Label8 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label9 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label10 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblB As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblA As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label11 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label12 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFacesNum As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFacesNumV As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFaces As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblC As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fraAnimation As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents txtTrans_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRot_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtSpeed As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkAnimation As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtTrans_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRot_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtTrans_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRot_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Label28 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label29 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label30 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label31 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label32 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label33 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fraColor As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdRandom As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents scrRed As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents scrGreen As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents scrBlue As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents cmdSelect As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents scrLuminance As CodeArchitects.VB6Library.VB6HScrollBar
	Public WithEvents optColor_000 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optColor_001 As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents lblRGBA_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRGBA_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRGBA_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label26 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label27 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label34 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRGBA_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents picCanvas As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents cdiLoad As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuFile As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuOpen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents tire1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuExit As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuView As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_004 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuRender_005 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents tire As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuShade As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHelp As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuKeyboard As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCanvas))
		Me.picCarry = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.fraLight = New CodeArchitects.VB6Library.VB6Frame()
		Me.txtLight_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtLight_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtLight_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdApply = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.optLoc_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optLoc_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.lblLX = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLY = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLZ = New CodeArchitects.VB6Library.VB6Label()
		Me.Label13 = New CodeArchitects.VB6Library.VB6Label()
		Me.fraPosition = New CodeArchitects.VB6Library.VB6Frame()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label16 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label17 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label18 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTz = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTy = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTx = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRz = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRy = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRx = New CodeArchitects.VB6Library.VB6Label()
		Me.lblS = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFPS = New CodeArchitects.VB6Library.VB6Label()
		Me.Label15 = New CodeArchitects.VB6Library.VB6Label()
		Me.fraProperties = New CodeArchitects.VB6Library.VB6Frame()
		Me.chkShow = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.scrFaces = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.Label8 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label9 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label10 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblB = New CodeArchitects.VB6Library.VB6Label()
		Me.lblA = New CodeArchitects.VB6Library.VB6Label()
		Me.Label11 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label12 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFacesNum = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFacesNumV = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFaces = New CodeArchitects.VB6Library.VB6Label()
		Me.lblC = New CodeArchitects.VB6Library.VB6Label()
		Me.fraAnimation = New CodeArchitects.VB6Library.VB6Frame()
		Me.txtTrans_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRot_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtSpeed = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkAnimation = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtTrans_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRot_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtTrans_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRot_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Label28 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label29 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label30 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label31 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label32 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label33 = New CodeArchitects.VB6Library.VB6Label()
		Me.fraColor = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdRandom = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.scrRed = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.scrGreen = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.scrBlue = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.cmdSelect = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.scrLuminance = New CodeArchitects.VB6Library.VB6HScrollBar()
		Me.optColor_000 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optColor_001 = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.lblRGBA_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRGBA_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRGBA_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label26 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label27 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label34 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRGBA_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.picCanvas = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.cdiLoad = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuFile = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuOpen = New CodeArchitects.VB6Library.VB6Menu()
		Me.tire1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuExit = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuView = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_004 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuRender_005 = New CodeArchitects.VB6Library.VB6Menu()
		Me.tire = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuShade = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHelp = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuKeyboard = New CodeArchitects.VB6Library.VB6Menu()
		Me.picCarry.SuspendLayout()
		Me.fraLight.SuspendLayout()
		Me.fraPosition.SuspendLayout()
		Me.fraProperties.SuspendLayout()
		Me.fraAnimation.SuspendLayout()
		Me.fraColor.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		' picCarry
		'
		Me.picCarry.Name = "picCarry"
		Me.picCarry.Size = New System.Drawing.Size(233, 601)
		Me.picCarry.Location = New System.Drawing.Point(808, 24)
		Me.picCarry.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picCarry.TabIndex = 1
		Me.picCarry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picCarry.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picCarry.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraLight
		'
		Me.fraLight.Name = "fraLight"
		Me.fraLight.Size = New System.Drawing.Size(225, 89)
		Me.fraLight.Location = New System.Drawing.Point(0, 408)
		Me.fraLight.Caption = "Light"
		Me.fraLight.TabIndex = 64
		Me.fraLight.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtLight_000
		'
		Me.txtLight_000.Name = "txtLight_000"
		Me.txtLight_000.Size = New System.Drawing.Size(40, 19)
		Me.txtLight_000.Location = New System.Drawing.Point(8, 32)
		Me.txtLight_000.TabIndex = 70
		Me.txtLight_000.Tag = "Light X"
		Me.txtLight_000.Text = "0"
		'
		' txtLight_001
		'
		Me.txtLight_001.Name = "txtLight_001"
		Me.txtLight_001.Size = New System.Drawing.Size(40, 19)
		Me.txtLight_001.Location = New System.Drawing.Point(48, 32)
		Me.txtLight_001.TabIndex = 69
		Me.txtLight_001.Tag = "Light Y"
		Me.txtLight_001.Text = "300"
		'
		' txtLight_002
		'
		Me.txtLight_002.Name = "txtLight_002"
		Me.txtLight_002.Size = New System.Drawing.Size(40, 19)
		Me.txtLight_002.Location = New System.Drawing.Point(88, 32)
		Me.txtLight_002.TabIndex = 68
		Me.txtLight_002.Tag = "Light Z"
		Me.txtLight_002.Text = "300"
		'
		' cmdApply
		'
		Me.cmdApply.Name = "cmdApply"
		Me.cmdApply.Size = New System.Drawing.Size(73, 25)
		Me.cmdApply.Location = New System.Drawing.Point(136, 24)
		Me.cmdApply.Caption = "Apply"
		Me.cmdApply.TabIndex = 67
		Me.cmdApply.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optLoc_000
		'
		Me.optLoc_000.Name = "optLoc_000"
		Me.optLoc_000.Size = New System.Drawing.Size(49, 17)
		Me.optLoc_000.Location = New System.Drawing.Point(88, 64)
		Me.optLoc_000.Caption = "Place"
		Me.optLoc_000.TabIndex = 66
		Me.optLoc_000.Value = True
		Me.optLoc_000.TabStop = True
		Me.optLoc_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optLoc_001
		'
		Me.optLoc_001.Name = "optLoc_001"
		Me.optLoc_001.Size = New System.Drawing.Size(65, 17)
		Me.optLoc_001.Location = New System.Drawing.Point(144, 64)
		Me.optLoc_001.Caption = "Satellite"
		Me.optLoc_001.TabIndex = 65
		Me.optLoc_001.TabStop = True
		Me.optLoc_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLX
		'
		Me.lblLX.Name = "lblLX"
		Me.lblLX.Size = New System.Drawing.Size(13, 17)
		Me.lblLX.Location = New System.Drawing.Point(20, 16)
		Me.lblLX.Caption = "X"
		Me.lblLX.TabIndex = 74
		Me.lblLX.AutoSize = False
		Me.lblLX.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLY
		'
		Me.lblLY.Name = "lblLY"
		Me.lblLY.Size = New System.Drawing.Size(13, 17)
		Me.lblLY.Location = New System.Drawing.Point(60, 16)
		Me.lblLY.Caption = "Y"
		Me.lblLY.TabIndex = 73
		Me.lblLY.AutoSize = False
		Me.lblLY.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLZ
		'
		Me.lblLZ.Name = "lblLZ"
		Me.lblLZ.Size = New System.Drawing.Size(13, 17)
		Me.lblLZ.Location = New System.Drawing.Point(100, 16)
		Me.lblLZ.Caption = "Z"
		Me.lblLZ.TabIndex = 72
		Me.lblLZ.AutoSize = False
		Me.lblLZ.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label13
		'
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(73, 17)
		Me.Label13.Location = New System.Drawing.Point(8, 64)
		Me.Label13.Caption = "Light Location"
		Me.Label13.TabIndex = 71
		Me.Label13.AutoSize = False
		Me.Label13.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraPosition
		'
		Me.fraPosition.Name = "fraPosition"
		Me.fraPosition.Size = New System.Drawing.Size(225, 105)
		Me.fraPosition.Location = New System.Drawing.Point(0, 0)
		Me.fraPosition.Caption = "Position"
		Me.fraPosition.TabIndex = 48
		Me.fraPosition.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(20, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 32)
		Me.Label5.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label5.Caption = "X"
		Me.Label5.TabIndex = 63
		Me.Label5.AutoSize = False
		Me.Label5.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(20, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 48)
		Me.Label6.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label6.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label6.Caption = "Y"
		Me.Label6.TabIndex = 62
		Me.Label6.AutoSize = False
		Me.Label6.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(20, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 64)
		Me.Label7.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label7.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label7.Caption = "Z"
		Me.Label7.TabIndex = 61
		Me.Label7.AutoSize = False
		Me.Label7.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label16
		'
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(60, 17)
		Me.Label16.Location = New System.Drawing.Point(32, 16)
		Me.Label16.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label16.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label16.Caption = "Translation"
		Me.Label16.TabIndex = 60
		Me.Label16.AutoSize = False
		Me.Label16.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label17
		'
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(60, 17)
		Me.Label17.Location = New System.Drawing.Point(96, 16)
		Me.Label17.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label17.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label17.Caption = "Rotation"
		Me.Label17.TabIndex = 59
		Me.Label17.AutoSize = False
		Me.Label17.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label18
		'
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(60, 17)
		Me.Label18.Location = New System.Drawing.Point(160, 16)
		Me.Label18.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label18.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label18.Caption = "Scale"
		Me.Label18.TabIndex = 58
		Me.Label18.AutoSize = False
		Me.Label18.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTz
		'
		Me.lblTz.Name = "lblTz"
		Me.lblTz.Size = New System.Drawing.Size(60, 17)
		Me.lblTz.Location = New System.Drawing.Point(32, 64)
		Me.lblTz.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblTz.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblTz.Caption = "t"
		Me.lblTz.TabIndex = 57
		Me.lblTz.AutoSize = False
		Me.lblTz.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTy
		'
		Me.lblTy.Name = "lblTy"
		Me.lblTy.Size = New System.Drawing.Size(60, 17)
		Me.lblTy.Location = New System.Drawing.Point(32, 48)
		Me.lblTy.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblTy.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblTy.Caption = "t"
		Me.lblTy.TabIndex = 56
		Me.lblTy.AutoSize = False
		Me.lblTy.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTx
		'
		Me.lblTx.Name = "lblTx"
		Me.lblTx.Size = New System.Drawing.Size(60, 17)
		Me.lblTx.Location = New System.Drawing.Point(32, 32)
		Me.lblTx.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblTx.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblTx.Caption = "t"
		Me.lblTx.TabIndex = 55
		Me.lblTx.AutoSize = False
		Me.lblTx.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRz
		'
		Me.lblRz.Name = "lblRz"
		Me.lblRz.Size = New System.Drawing.Size(60, 17)
		Me.lblRz.Location = New System.Drawing.Point(96, 64)
		Me.lblRz.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRz.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblRz.Caption = "r"
		Me.lblRz.TabIndex = 54
		Me.lblRz.AutoSize = False
		Me.lblRz.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRy
		'
		Me.lblRy.Name = "lblRy"
		Me.lblRy.Size = New System.Drawing.Size(60, 17)
		Me.lblRy.Location = New System.Drawing.Point(96, 48)
		Me.lblRy.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRy.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblRy.Caption = "r"
		Me.lblRy.TabIndex = 53
		Me.lblRy.AutoSize = False
		Me.lblRy.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRx
		'
		Me.lblRx.Name = "lblRx"
		Me.lblRx.Size = New System.Drawing.Size(60, 17)
		Me.lblRx.Location = New System.Drawing.Point(96, 32)
		Me.lblRx.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRx.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblRx.Caption = "r"
		Me.lblRx.TabIndex = 52
		Me.lblRx.AutoSize = False
		Me.lblRx.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblS
		'
		Me.lblS.Name = "lblS"
		Me.lblS.Size = New System.Drawing.Size(60, 17)
		Me.lblS.Location = New System.Drawing.Point(160, 32)
		Me.lblS.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblS.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblS.Caption = "s"
		Me.lblS.TabIndex = 51
		Me.lblS.AutoSize = False
		Me.lblS.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblFPS
		'
		Me.lblFPS.Name = "lblFPS"
		Me.lblFPS.Size = New System.Drawing.Size(60, 17)
		Me.lblFPS.Location = New System.Drawing.Point(160, 64)
		Me.lblFPS.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblFPS.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblFPS.Caption = "fps"
		Me.lblFPS.TabIndex = 50
		Me.lblFPS.AutoSize = False
		Me.lblFPS.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label15
		'
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(60, 17)
		Me.Label15.Location = New System.Drawing.Point(160, 48)
		Me.Label15.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label15.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label15.Caption = "FPS"
		Me.Label15.TabIndex = 49
		Me.Label15.AutoSize = False
		Me.Label15.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraProperties
		'
		Me.fraProperties.Name = "fraProperties"
		Me.fraProperties.Size = New System.Drawing.Size(225, 105)
		Me.fraProperties.Location = New System.Drawing.Point(0, 296)
		Me.fraProperties.Caption = "Face Properties"
		Me.fraProperties.TabIndex = 34
		Me.fraProperties.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' chkShow
		'
		Me.chkShow.Name = "chkShow"
		Me.chkShow.Size = New System.Drawing.Size(57, 17)
		Me.chkShow.Location = New System.Drawing.Point(8, 24)
		Me.chkShow.Caption = "Show"
		Me.chkShow.TabIndex = 36
		Me.chkShow.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' scrFaces
		'
		Me.scrFaces.Name = "scrFaces"
		Me.scrFaces.Size = New System.Drawing.Size(82, 17)
		Me.scrFaces.Location = New System.Drawing.Point(72, 24)
		Me.scrFaces.LargeChange = 10
		Me.scrFaces.Max = 255
		Me.scrFaces.TabIndex = 35
		Me.scrFaces.TabStop = True
		'
		' Label8
		'
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(20, 16)
		Me.Label8.Location = New System.Drawing.Point(8, 48)
		Me.Label8.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label8.Caption = "A:"
		Me.Label8.TabIndex = 47
		Me.Label8.AutoSize = False
		Me.Label8.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label9
		'
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(20, 16)
		Me.Label9.Location = New System.Drawing.Point(8, 64)
		Me.Label9.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label9.Caption = "B:"
		Me.Label9.TabIndex = 46
		Me.Label9.AutoSize = False
		Me.Label9.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label10
		'
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(20, 16)
		Me.Label10.Location = New System.Drawing.Point(8, 80)
		Me.Label10.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label10.Caption = "C:"
		Me.Label10.TabIndex = 45
		Me.Label10.AutoSize = False
		Me.Label10.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblB
		'
		Me.lblB.Name = "lblB"
		Me.lblB.Size = New System.Drawing.Size(50, 16)
		Me.lblB.Location = New System.Drawing.Point(32, 64)
		Me.lblB.Caption = "No"
		Me.lblB.TabIndex = 44
		Me.lblB.AutoSize = False
		Me.lblB.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblA
		'
		Me.lblA.Name = "lblA"
		Me.lblA.Size = New System.Drawing.Size(50, 16)
		Me.lblA.Location = New System.Drawing.Point(32, 48)
		Me.lblA.Caption = "No"
		Me.lblA.TabIndex = 43
		Me.lblA.AutoSize = False
		Me.lblA.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label11
		'
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(65, 17)
		Me.Label11.Location = New System.Drawing.Point(88, 48)
		Me.Label11.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label11.Caption = "Faces Num.:"
		Me.Label11.TabIndex = 42
		Me.Label11.AutoSize = False
		Me.Label11.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label12
		'
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(65, 17)
		Me.Label12.Location = New System.Drawing.Point(88, 64)
		Me.Label12.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label12.Caption = "Visible Faces:"
		Me.Label12.TabIndex = 41
		Me.Label12.AutoSize = False
		Me.Label12.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblFacesNum
		'
		Me.lblFacesNum.Name = "lblFacesNum"
		Me.lblFacesNum.Size = New System.Drawing.Size(53, 17)
		Me.lblFacesNum.Location = New System.Drawing.Point(160, 48)
		Me.lblFacesNum.Caption = "-"
		Me.lblFacesNum.TabIndex = 40
		Me.lblFacesNum.AutoSize = False
		Me.lblFacesNum.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblFacesNumV
		'
		Me.lblFacesNumV.Name = "lblFacesNumV"
		Me.lblFacesNumV.Size = New System.Drawing.Size(53, 17)
		Me.lblFacesNumV.Location = New System.Drawing.Point(160, 64)
		Me.lblFacesNumV.Caption = "-"
		Me.lblFacesNumV.TabIndex = 39
		Me.lblFacesNumV.AutoSize = False
		Me.lblFacesNumV.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblFaces
		'
		Me.lblFaces.Name = "lblFaces"
		Me.lblFaces.Size = New System.Drawing.Size(53, 17)
		Me.lblFaces.Location = New System.Drawing.Point(160, 24)
		Me.lblFaces.Caption = "-"
		Me.lblFaces.TabIndex = 38
		Me.lblFaces.AutoSize = False
		Me.lblFaces.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblC
		'
		Me.lblC.Name = "lblC"
		Me.lblC.Size = New System.Drawing.Size(50, 16)
		Me.lblC.Location = New System.Drawing.Point(32, 80)
		Me.lblC.Caption = "No"
		Me.lblC.TabIndex = 37
		Me.lblC.AutoSize = False
		Me.lblC.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraAnimation
		'
		Me.fraAnimation.Name = "fraAnimation"
		Me.fraAnimation.Size = New System.Drawing.Size(225, 89)
		Me.fraAnimation.Location = New System.Drawing.Point(0, 504)
		Me.fraAnimation.Caption = "Animation"
		Me.fraAnimation.TabIndex = 19
		Me.fraAnimation.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtTrans_000
		'
		Me.txtTrans_000.Name = "txtTrans_000"
		Me.txtTrans_000.Size = New System.Drawing.Size(60, 19)
		Me.txtTrans_000.Location = New System.Drawing.Point(32, 32)
		Me.txtTrans_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtTrans_000.TabIndex = 27
		Me.txtTrans_000.Text = "0"
		'
		' txtRot_000
		'
		Me.txtRot_000.Name = "txtRot_000"
		Me.txtRot_000.Size = New System.Drawing.Size(60, 19)
		Me.txtRot_000.Location = New System.Drawing.Point(96, 32)
		Me.txtRot_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtRot_000.TabIndex = 26
		Me.txtRot_000.Text = "0"
		'
		' txtSpeed
		'
		Me.txtSpeed.Name = "txtSpeed"
		Me.txtSpeed.Size = New System.Drawing.Size(60, 19)
		Me.txtSpeed.Location = New System.Drawing.Point(160, 32)
		Me.txtSpeed.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtSpeed.Enabled = False
		Me.txtSpeed.TabIndex = 25
		Me.txtSpeed.Text = "0"
		'
		' chkAnimation
		'
		Me.chkAnimation.Name = "chkAnimation"
		Me.chkAnimation.Size = New System.Drawing.Size(49, 17)
		Me.chkAnimation.Location = New System.Drawing.Point(168, 64)
		Me.chkAnimation.Caption = "Start"
		Me.chkAnimation.TabIndex = 24
		Me.chkAnimation.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtTrans_001
		'
		Me.txtTrans_001.Name = "txtTrans_001"
		Me.txtTrans_001.Size = New System.Drawing.Size(60, 19)
		Me.txtTrans_001.Location = New System.Drawing.Point(32, 48)
		Me.txtTrans_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtTrans_001.TabIndex = 23
		Me.txtTrans_001.Text = "0"
		'
		' txtRot_001
		'
		Me.txtRot_001.Name = "txtRot_001"
		Me.txtRot_001.Size = New System.Drawing.Size(60, 19)
		Me.txtRot_001.Location = New System.Drawing.Point(96, 48)
		Me.txtRot_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtRot_001.TabIndex = 22
		Me.txtRot_001.Text = "0"
		'
		' txtTrans_002
		'
		Me.txtTrans_002.Name = "txtTrans_002"
		Me.txtTrans_002.Size = New System.Drawing.Size(60, 19)
		Me.txtTrans_002.Location = New System.Drawing.Point(32, 64)
		Me.txtTrans_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtTrans_002.TabIndex = 21
		Me.txtTrans_002.Text = "0"
		'
		' txtRot_002
		'
		Me.txtRot_002.Name = "txtRot_002"
		Me.txtRot_002.Size = New System.Drawing.Size(60, 19)
		Me.txtRot_002.Location = New System.Drawing.Point(96, 64)
		Me.txtRot_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtRot_002.TabIndex = 20
		Me.txtRot_002.Text = "0"
		'
		' Label28
		'
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(60, 17)
		Me.Label28.Location = New System.Drawing.Point(160, 16)
		Me.Label28.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label28.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label28.Caption = "Speed"
		Me.Label28.Enabled = False
		Me.Label28.TabIndex = 33
		Me.Label28.AutoSize = False
		Me.Label28.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label29
		'
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(60, 17)
		Me.Label29.Location = New System.Drawing.Point(96, 16)
		Me.Label29.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label29.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label29.Caption = "Rotation"
		Me.Label29.TabIndex = 32
		Me.Label29.AutoSize = False
		Me.Label29.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label30
		'
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(60, 17)
		Me.Label30.Location = New System.Drawing.Point(32, 16)
		Me.Label30.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label30.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label30.Caption = "Translation"
		Me.Label30.TabIndex = 31
		Me.Label30.AutoSize = False
		Me.Label30.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label31
		'
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(20, 17)
		Me.Label31.Location = New System.Drawing.Point(8, 64)
		Me.Label31.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label31.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label31.Caption = "Z"
		Me.Label31.TabIndex = 30
		Me.Label31.AutoSize = False
		Me.Label31.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label32
		'
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(20, 17)
		Me.Label32.Location = New System.Drawing.Point(8, 48)
		Me.Label32.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label32.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label32.Caption = "Y"
		Me.Label32.TabIndex = 29
		Me.Label32.AutoSize = False
		Me.Label32.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label33
		'
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(20, 17)
		Me.Label33.Location = New System.Drawing.Point(8, 32)
		Me.Label33.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.Label33.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label33.Caption = "X"
		Me.Label33.TabIndex = 28
		Me.Label33.AutoSize = False
		Me.Label33.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraColor
		'
		Me.fraColor.Name = "fraColor"
		Me.fraColor.Size = New System.Drawing.Size(225, 177)
		Me.fraColor.Location = New System.Drawing.Point(0, 112)
		Me.fraColor.Caption = "Color"
		Me.fraColor.TabIndex = 2
		Me.fraColor.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdRandom
		'
		Me.cmdRandom.Name = "cmdRandom"
		Me.cmdRandom.Size = New System.Drawing.Size(73, 25)
		Me.cmdRandom.Location = New System.Drawing.Point(128, 112)
		Me.cmdRandom.Caption = "Random"
		Me.cmdRandom.TabIndex = 10
		Me.cmdRandom.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' scrRed
		'
		Me.scrRed.Name = "scrRed"
		Me.scrRed.Size = New System.Drawing.Size(67, 17)
		Me.scrRed.Location = New System.Drawing.Point(112, 24)
		Me.scrRed.LargeChange = 5
		Me.scrRed.Max = 255
		Me.scrRed.TabIndex = 9
		Me.scrRed.TabStop = True
		'
		' scrGreen
		'
		Me.scrGreen.Name = "scrGreen"
		Me.scrGreen.Size = New System.Drawing.Size(67, 17)
		Me.scrGreen.Location = New System.Drawing.Point(112, 40)
		Me.scrGreen.LargeChange = 5
		Me.scrGreen.Max = 255
		Me.scrGreen.TabIndex = 8
		Me.scrGreen.TabStop = True
		'
		' scrBlue
		'
		Me.scrBlue.Name = "scrBlue"
		Me.scrBlue.Size = New System.Drawing.Size(67, 17)
		Me.scrBlue.Location = New System.Drawing.Point(112, 56)
		Me.scrBlue.LargeChange = 5
		Me.scrBlue.Max = 255
		Me.scrBlue.TabIndex = 7
		Me.scrBlue.TabStop = True
		'
		' cmdSelect
		'
		Me.cmdSelect.Name = "cmdSelect"
		Me.cmdSelect.Size = New System.Drawing.Size(73, 25)
		Me.cmdSelect.Location = New System.Drawing.Point(128, 144)
		Me.cmdSelect.Caption = "Select"
		Me.cmdSelect.TabIndex = 6
		Me.cmdSelect.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' scrLuminance
		'
		Me.scrLuminance.Name = "scrLuminance"
		Me.scrLuminance.Size = New System.Drawing.Size(67, 17)
		Me.scrLuminance.Location = New System.Drawing.Point(112, 80)
		Me.scrLuminance.LargeChange = 2
		Me.scrLuminance.Max = 100
		Me.scrLuminance.TabIndex = 5
		Me.scrLuminance.Value = 50
		Me.scrLuminance.TabStop = True
		'
		' optColor_000
		'
		Me.optColor_000.Name = "optColor_000"
		Me.optColor_000.Size = New System.Drawing.Size(81, 17)
		Me.optColor_000.Location = New System.Drawing.Point(24, 104)
		Me.optColor_000.Caption = "Color"
		Me.optColor_000.TabIndex = 4
		Me.optColor_000.TabStop = True
		Me.optColor_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optColor_001
		'
		Me.optColor_001.Name = "optColor_001"
		Me.optColor_001.Size = New System.Drawing.Size(81, 17)
		Me.optColor_001.Location = New System.Drawing.Point(24, 128)
		Me.optColor_001.Caption = "Gray"
		Me.optColor_001.TabIndex = 3
		Me.optColor_001.TabStop = True
		Me.optColor_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRGBA_002
		'
		Me.lblRGBA_002.Name = "lblRGBA_002"
		Me.lblRGBA_002.Size = New System.Drawing.Size(25, 17)
		Me.lblRGBA_002.Location = New System.Drawing.Point(184, 56)
		Me.lblRGBA_002.Caption = "-"
		Me.lblRGBA_002.TabIndex = 18
		Me.lblRGBA_002.AutoSize = False
		Me.lblRGBA_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRGBA_001
		'
		Me.lblRGBA_001.Name = "lblRGBA_001"
		Me.lblRGBA_001.Size = New System.Drawing.Size(25, 17)
		Me.lblRGBA_001.Location = New System.Drawing.Point(184, 40)
		Me.lblRGBA_001.Caption = "-"
		Me.lblRGBA_001.TabIndex = 17
		Me.lblRGBA_001.AutoSize = False
		Me.lblRGBA_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRGBA_000
		'
		Me.lblRGBA_000.Name = "lblRGBA_000"
		Me.lblRGBA_000.Size = New System.Drawing.Size(25, 17)
		Me.lblRGBA_000.Location = New System.Drawing.Point(184, 24)
		Me.lblRGBA_000.Caption = "-"
		Me.lblRGBA_000.TabIndex = 16
		Me.lblRGBA_000.AutoSize = False
		Me.lblRGBA_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label26
		'
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(33, 17)
		Me.Label26.Location = New System.Drawing.Point(16, 56)
		Me.Label26.Caption = "Blue"
		Me.Label26.TabIndex = 15
		Me.Label26.AutoSize = False
		Me.Label26.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label27
		'
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(33, 17)
		Me.Label27.Location = New System.Drawing.Point(16, 40)
		Me.Label27.Caption = "Green"
		Me.Label27.TabIndex = 14
		Me.Label27.AutoSize = False
		Me.Label27.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label34
		'
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(33, 17)
		Me.Label34.Location = New System.Drawing.Point(16, 24)
		Me.Label34.Caption = "Red"
		Me.Label34.TabIndex = 13
		Me.Label34.AutoSize = False
		Me.Label34.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 80)
		Me.Label1.Caption = "Luminance"
		Me.Label1.TabIndex = 12
		Me.Label1.AutoSize = False
		Me.Label1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRGBA_003
		'
		Me.lblRGBA_003.Name = "lblRGBA_003"
		Me.lblRGBA_003.Size = New System.Drawing.Size(25, 17)
		Me.lblRGBA_003.Location = New System.Drawing.Point(184, 80)
		Me.lblRGBA_003.Caption = "-"
		Me.lblRGBA_003.TabIndex = 11
		Me.lblRGBA_003.AutoSize = False
		Me.lblRGBA_003.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picCanvas
		'
		Me.picCanvas.Name = "picCanvas"
		Me.picCanvas.Size = New System.Drawing.Size(800, 640)
		Me.picCanvas.Location = New System.Drawing.Point(0, 24)
		Me.picCanvas.BackColor = FromOleColor6(CInt(&H00808080))
		Me.picCanvas.ForeColor = FromOleColor6(CInt(&H00808080))
		Me.picCanvas.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.picCanvas.TabIndex = 0
		Me.picCanvas.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picCanvas.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 1000
		'
		' cdiLoad
		'
		Me.cdiLoad.Name = "cdiLoad"
		Me.cdiLoad.ParentForm = Me
		Me.cdiLoad.Name6 = "cdiLoad"
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuFile
		'
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Caption = "&File"
		'
		' mnuOpen
		'
		Me.mnuOpen.Name = "mnuOpen"
		Me.mnuOpen.Caption = "&Open"
		Me.mnuOpen.Shortcut = Keys.Control Or Keys.O
		'
		' tire1
		'
		Me.tire1.Name = "tire1"
		'
		' mnuExit
		'
		Me.mnuExit.Name = "mnuExit"
		Me.mnuExit.Caption = "E&xit"
		'
		' mnuView
		'
		Me.mnuView.Name = "mnuView"
		Me.mnuView.Caption = "&Render"
		'
		' mnuRender_000
		'
		Me.mnuRender_000.Name = "mnuRender_000"
		Me.mnuRender_000.Caption = "Dot"
		'
		' mnuRender_001
		'
		Me.mnuRender_001.Name = "mnuRender_001"
		Me.mnuRender_001.Caption = "Dot(Culled)"
		'
		' mnuRender_002
		'
		Me.mnuRender_002.Name = "mnuRender_002"
		Me.mnuRender_002.Caption = "Wireframe"
		'
		' mnuRender_003
		'
		Me.mnuRender_003.Name = "mnuRender_003"
		Me.mnuRender_003.Caption = "Hidden"
		'
		' mnuRender_004
		'
		Me.mnuRender_004.Name = "mnuRender_004"
		Me.mnuRender_004.Caption = "Solid"
		'
		' mnuRender_005
		'
		Me.mnuRender_005.Name = "mnuRender_005"
		Me.mnuRender_005.Caption = "SolidFrame"
		'
		' tire
		'
		Me.tire.Name = "tire"
		'
		' mnuShade
		'
		Me.mnuShade.Name = "mnuShade"
		Me.mnuShade.Caption = "Shade"
		'
		' mnuHelp
		'
		Me.mnuHelp.Name = "mnuHelp"
		Me.mnuHelp.Caption = "&Help"
		'
		' mnuKeyboard
		'
		Me.mnuKeyboard.Name = "mnuKeyboard"
		Me.mnuKeyboard.Caption = "&Keyboard"
		'
		' frmCanvas
		'
		Me.Name = "frmCanvas"
		Me.AutoRedraw = True
		Me.Caption = "EGL24"
		Me.DrawStyle = CodeArchitects.VB6Library.VBRUN.DrawStyleConstants.vbInsideSolid
		Me.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbDiagonalCross
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(4, 50)
		Me.ClientSize = New System.Drawing.Size(1016, 667)

		Me.Controls.Add(picCarry)
		Me.picCarry.Controls.Add(fraLight)
		Me.fraLight.Controls.Add(txtLight_000)
		Me.fraLight.Controls.Add(txtLight_001)
		Me.fraLight.Controls.Add(txtLight_002)
		Me.fraLight.Controls.Add(cmdApply)
		Me.fraLight.Controls.Add(optLoc_000)
		Me.fraLight.Controls.Add(optLoc_001)
		Me.fraLight.Controls.Add(lblLX)
		Me.fraLight.Controls.Add(lblLY)
		Me.fraLight.Controls.Add(lblLZ)
		Me.fraLight.Controls.Add(Label13)
		Me.picCarry.Controls.Add(fraPosition)
		Me.fraPosition.Controls.Add(Label5)
		Me.fraPosition.Controls.Add(Label6)
		Me.fraPosition.Controls.Add(Label7)
		Me.fraPosition.Controls.Add(Label16)
		Me.fraPosition.Controls.Add(Label17)
		Me.fraPosition.Controls.Add(Label18)
		Me.fraPosition.Controls.Add(lblTz)
		Me.fraPosition.Controls.Add(lblTy)
		Me.fraPosition.Controls.Add(lblTx)
		Me.fraPosition.Controls.Add(lblRz)
		Me.fraPosition.Controls.Add(lblRy)
		Me.fraPosition.Controls.Add(lblRx)
		Me.fraPosition.Controls.Add(lblS)
		Me.fraPosition.Controls.Add(lblFPS)
		Me.fraPosition.Controls.Add(Label15)
		Me.picCarry.Controls.Add(fraProperties)
		Me.fraProperties.Controls.Add(chkShow)
		Me.fraProperties.Controls.Add(scrFaces)
		Me.fraProperties.Controls.Add(Label8)
		Me.fraProperties.Controls.Add(Label9)
		Me.fraProperties.Controls.Add(Label10)
		Me.fraProperties.Controls.Add(lblB)
		Me.fraProperties.Controls.Add(lblA)
		Me.fraProperties.Controls.Add(Label11)
		Me.fraProperties.Controls.Add(Label12)
		Me.fraProperties.Controls.Add(lblFacesNum)
		Me.fraProperties.Controls.Add(lblFacesNumV)
		Me.fraProperties.Controls.Add(lblFaces)
		Me.fraProperties.Controls.Add(lblC)
		Me.picCarry.Controls.Add(fraAnimation)
		Me.fraAnimation.Controls.Add(txtTrans_000)
		Me.fraAnimation.Controls.Add(txtRot_000)
		Me.fraAnimation.Controls.Add(txtSpeed)
		Me.fraAnimation.Controls.Add(chkAnimation)
		Me.fraAnimation.Controls.Add(txtTrans_001)
		Me.fraAnimation.Controls.Add(txtRot_001)
		Me.fraAnimation.Controls.Add(txtTrans_002)
		Me.fraAnimation.Controls.Add(txtRot_002)
		Me.fraAnimation.Controls.Add(Label28)
		Me.fraAnimation.Controls.Add(Label29)
		Me.fraAnimation.Controls.Add(Label30)
		Me.fraAnimation.Controls.Add(Label31)
		Me.fraAnimation.Controls.Add(Label32)
		Me.fraAnimation.Controls.Add(Label33)
		Me.picCarry.Controls.Add(fraColor)
		Me.fraColor.Controls.Add(cmdRandom)
		Me.fraColor.Controls.Add(scrRed)
		Me.fraColor.Controls.Add(scrGreen)
		Me.fraColor.Controls.Add(scrBlue)
		Me.fraColor.Controls.Add(cmdSelect)
		Me.fraColor.Controls.Add(scrLuminance)
		Me.fraColor.Controls.Add(optColor_000)
		Me.fraColor.Controls.Add(optColor_001)
		Me.fraColor.Controls.Add(lblRGBA_002)
		Me.fraColor.Controls.Add(lblRGBA_001)
		Me.fraColor.Controls.Add(lblRGBA_000)
		Me.fraColor.Controls.Add(Label26)
		Me.fraColor.Controls.Add(Label27)
		Me.fraColor.Controls.Add(Label34)
		Me.fraColor.Controls.Add(Label1)
		Me.fraColor.Controls.Add(lblRGBA_003)
		Me.Controls.Add(picCanvas)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuFile)
		Me.mnuFile.DropDownItems.Add(mnuOpen)
		Me.mnuFile.DropDownItems.Add(tire1)
		Me.mnuFile.DropDownItems.Add(mnuExit)
		Me.MenuStrip1.Items.Add(mnuView)
		Me.mnuView.DropDownItems.Add(mnuRender_000)
		Me.mnuView.DropDownItems.Add(mnuRender_001)
		Me.mnuView.DropDownItems.Add(mnuRender_002)
		Me.mnuView.DropDownItems.Add(mnuRender_003)
		Me.mnuView.DropDownItems.Add(mnuRender_004)
		Me.mnuView.DropDownItems.Add(mnuRender_005)
		Me.mnuView.DropDownItems.Add(tire)
		Me.mnuView.DropDownItems.Add(mnuShade)
		Me.MenuStrip1.Items.Add(mnuHelp)
		Me.mnuHelp.DropDownItems.Add(mnuKeyboard)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.picCarry.ResumeLayout(False)
		Me.fraLight.ResumeLayout(False)
		Me.fraPosition.ResumeLayout(False)
		Me.fraProperties.ResumeLayout(False)
		Me.fraAnimation.ResumeLayout(False)
		Me.fraColor.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
