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
		Me.R = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(R_003, R_002, R_001, R_000)
		Me.K = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(K_000)
		Me.MI = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(MI_001, MI_000)
		Me.M = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(M_001, M_000)
		Me.D = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(D_004, D_003, D_002, D_001, D_000)
		Me.C = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(C_004, C_003, C_002, C_001, C_000)
		Me.B = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(B_004, B_003, B_002, B_001, B_000)
		Me.A = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(A_004, A_003, A_002, A_001, A_000)
		Me.SE = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(SE_008, SE_007, SE_006, SE_005, SE_004, SE_003, SE_002, SE_001, SE_000)
		Me.Lives = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(Lives_002, Lives_001, Lives_000)
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_002, Label1_001, Label1_000)
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
	Public R As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public K As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public MI As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public M As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public D As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public C As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public B As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public A As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public SE As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public Lives As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents tmrBulletsMove As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents TmrRk As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents tmrMonster As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents cmdStart As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Text1 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents R_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents K_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents MI_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents MI_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents M_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents R_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents R_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents R_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents M_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents D_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents D_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents D_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents D_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents D_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents C_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents C_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents C_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents C_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents C_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents B_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents B_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents B_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents B_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents B_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents A_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents A_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents A_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents A_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents A_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents SE_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Lives_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Lives_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Lives_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLevel As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPoints As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents SH As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Shape1 As CodeArchitects.VB6Library.VB6Shape

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.tmrBulletsMove = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.TmrRk = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.tmrMonster = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.cmdStart = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Text1 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.R_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.K_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.MI_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.MI_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.M_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.R_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.R_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.R_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.M_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.D_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.D_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.D_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.D_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.D_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.C_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.C_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.C_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.C_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.C_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.B_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.B_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.B_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.B_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.B_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.A_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.A_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.A_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.A_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.A_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.SE_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.Lives_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.Lives_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.Lives_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLevel = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPoints = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SH = New CodeArchitects.VB6Library.VB6Image()
		Me.Shape1 = New CodeArchitects.VB6Library.VB6Shape()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.R_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.K_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MI_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MI_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.M_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.R_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.R_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.R_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.M_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.D_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.D_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.D_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.D_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.D_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.B_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.B_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.B_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.B_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.B_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.A_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.A_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.A_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.A_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.A_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SE_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Lives_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Lives_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Lives_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SH, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' tmrBulletsMove
		'
		Me.tmrBulletsMove.Name = "tmrBulletsMove"
		Me.tmrBulletsMove.ParentForm = Me
		Me.tmrBulletsMove.Name6 = "tmrBulletsMove"
		Me.tmrBulletsMove.Interval = 30
		'
		' TmrRk
		'
		Me.TmrRk.Name = "TmrRk"
		Me.TmrRk.ParentForm = Me
		Me.TmrRk.Name6 = "TmrRk"
		Me.TmrRk.Interval = 50
		'
		' tmrMonster
		'
		Me.tmrMonster.Name = "tmrMonster"
		Me.tmrMonster.ParentForm = Me
		Me.tmrMonster.Name6 = "tmrMonster"
		Me.tmrMonster.Enabled = False
		Me.tmrMonster.Interval = 50
		'
		' cmdStart
		'
		Me.cmdStart.Name = "cmdStart"
		Me.cmdStart.Size = New System.Drawing.Size(49, 17)
		Me.cmdStart.Location = New System.Drawing.Point(16, 48)
		Me.cmdStart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStart.Caption = "Start"
		Me.cmdStart.TabIndex = 0
		Me.cmdStart.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Text1
		'
		Me.Text1.Name = "Text1"
		Me.Text1.Size = New System.Drawing.Size(9, 11)
		Me.Text1.Location = New System.Drawing.Point(40, 48)
		Me.Text1.Font = New System.Drawing.Font("Arial", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.TabIndex = 7
		Me.Text1.Text = "Text1"
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(77, 57)
		Me.Image1.Location = New System.Drawing.Point(4, -4)
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' R_003
		'
		Me.R_003.Name = "R_003"
		Me.R_003.Size = New System.Drawing.Size(16, 16)
		Me.R_003.Location = New System.Drawing.Point(240, 416)
		Me.R_003.Picture = CType(resources.GetObject("R_003.Picture"), System.Drawing.Image)
		Me.R_003.Stretch = False
		'
		' K_000
		'
		Me.K_000.Name = "K_000"
		Me.K_000.Size = New System.Drawing.Size(16, 16)
		Me.K_000.Location = New System.Drawing.Point(264, 408)
		Me.K_000.Picture = CType(resources.GetObject("K_000.Picture"), System.Drawing.Image)
		Me.K_000.Stretch = False
		'
		' MI_001
		'
		Me.MI_001.Name = "MI_001"
		Me.MI_001.Size = New System.Drawing.Size(16, 16)
		Me.MI_001.Location = New System.Drawing.Point(268, 396)
		Me.MI_001.Picture = CType(resources.GetObject("MI_001.Picture"), System.Drawing.Image)
		Me.MI_001.Stretch = False
		'
		' MI_000
		'
		Me.MI_000.Name = "MI_000"
		Me.MI_000.Size = New System.Drawing.Size(16, 16)
		Me.MI_000.Location = New System.Drawing.Point(256, 396)
		Me.MI_000.Picture = CType(resources.GetObject("MI_000.Picture"), System.Drawing.Image)
		Me.MI_000.Stretch = False
		'
		' M_001
		'
		Me.M_001.Name = "M_001"
		Me.M_001.Size = New System.Drawing.Size(16, 16)
		Me.M_001.Location = New System.Drawing.Point(176, 392)
		Me.M_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.M_001.Stretch = False
		'
		' R_002
		'
		Me.R_002.Name = "R_002"
		Me.R_002.Size = New System.Drawing.Size(16, 16)
		Me.R_002.Location = New System.Drawing.Point(244, 408)
		Me.R_002.Picture = CType(resources.GetObject("R_002.Picture"), System.Drawing.Image)
		Me.R_002.Stretch = False
		'
		' R_001
		'
		Me.R_001.Name = "R_001"
		Me.R_001.Size = New System.Drawing.Size(16, 16)
		Me.R_001.Location = New System.Drawing.Point(244, 396)
		Me.R_001.Picture = CType(resources.GetObject("R_001.Picture"), System.Drawing.Image)
		Me.R_001.Stretch = False
		'
		' R_000
		'
		Me.R_000.Name = "R_000"
		Me.R_000.Size = New System.Drawing.Size(16, 16)
		Me.R_000.Location = New System.Drawing.Point(236, 396)
		Me.R_000.Picture = CType(resources.GetObject("R_000.Picture"), System.Drawing.Image)
		Me.R_000.Stretch = False
		'
		' M_000
		'
		Me.M_000.Name = "M_000"
		Me.M_000.Size = New System.Drawing.Size(16, 16)
		Me.M_000.Location = New System.Drawing.Point(176, 408)
		Me.M_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.M_000.Picture = CType(resources.GetObject("M_000.Picture"), System.Drawing.Image)
		Me.M_000.Stretch = False
		'
		' D_004
		'
		Me.D_004.Name = "D_004"
		Me.D_004.Size = New System.Drawing.Size(16, 16)
		Me.D_004.Location = New System.Drawing.Point(160, 412)
		Me.D_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.D_004.Picture = CType(resources.GetObject("D_004.Picture"), System.Drawing.Image)
		Me.D_004.Stretch = False
		'
		' D_003
		'
		Me.D_003.Name = "D_003"
		Me.D_003.Size = New System.Drawing.Size(16, 16)
		Me.D_003.Location = New System.Drawing.Point(144, 412)
		Me.D_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.D_003.Picture = CType(resources.GetObject("D_003.Picture"), System.Drawing.Image)
		Me.D_003.Stretch = False
		'
		' D_002
		'
		Me.D_002.Name = "D_002"
		Me.D_002.Size = New System.Drawing.Size(16, 16)
		Me.D_002.Location = New System.Drawing.Point(128, 412)
		Me.D_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.D_002.Picture = CType(resources.GetObject("D_002.Picture"), System.Drawing.Image)
		Me.D_002.Stretch = False
		'
		' D_001
		'
		Me.D_001.Name = "D_001"
		Me.D_001.Size = New System.Drawing.Size(16, 16)
		Me.D_001.Location = New System.Drawing.Point(112, 412)
		Me.D_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.D_001.Picture = CType(resources.GetObject("D_001.Picture"), System.Drawing.Image)
		Me.D_001.Stretch = False
		'
		' D_000
		'
		Me.D_000.Name = "D_000"
		Me.D_000.Size = New System.Drawing.Size(16, 16)
		Me.D_000.Location = New System.Drawing.Point(96, 412)
		Me.D_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.D_000.Picture = CType(resources.GetObject("D_000.Picture"), System.Drawing.Image)
		Me.D_000.Stretch = False
		'
		' C_004
		'
		Me.C_004.Name = "C_004"
		Me.C_004.Size = New System.Drawing.Size(16, 16)
		Me.C_004.Location = New System.Drawing.Point(76, 412)
		Me.C_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.C_004.Picture = CType(resources.GetObject("C_004.Picture"), System.Drawing.Image)
		Me.C_004.Stretch = False
		'
		' C_003
		'
		Me.C_003.Name = "C_003"
		Me.C_003.Size = New System.Drawing.Size(16, 16)
		Me.C_003.Location = New System.Drawing.Point(60, 412)
		Me.C_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.C_003.Picture = CType(resources.GetObject("C_003.Picture"), System.Drawing.Image)
		Me.C_003.Stretch = False
		'
		' C_002
		'
		Me.C_002.Name = "C_002"
		Me.C_002.Size = New System.Drawing.Size(16, 16)
		Me.C_002.Location = New System.Drawing.Point(44, 412)
		Me.C_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.C_002.Picture = CType(resources.GetObject("C_002.Picture"), System.Drawing.Image)
		Me.C_002.Stretch = False
		'
		' C_001
		'
		Me.C_001.Name = "C_001"
		Me.C_001.Size = New System.Drawing.Size(16, 16)
		Me.C_001.Location = New System.Drawing.Point(28, 412)
		Me.C_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.C_001.Picture = CType(resources.GetObject("C_001.Picture"), System.Drawing.Image)
		Me.C_001.Stretch = False
		'
		' C_000
		'
		Me.C_000.Name = "C_000"
		Me.C_000.Size = New System.Drawing.Size(16, 16)
		Me.C_000.Location = New System.Drawing.Point(12, 412)
		Me.C_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.C_000.Picture = CType(resources.GetObject("C_000.Picture"), System.Drawing.Image)
		Me.C_000.Stretch = False
		'
		' B_004
		'
		Me.B_004.Name = "B_004"
		Me.B_004.Size = New System.Drawing.Size(16, 16)
		Me.B_004.Location = New System.Drawing.Point(160, 396)
		Me.B_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.B_004.Picture = CType(resources.GetObject("B_004.Picture"), System.Drawing.Image)
		Me.B_004.Stretch = False
		'
		' B_003
		'
		Me.B_003.Name = "B_003"
		Me.B_003.Size = New System.Drawing.Size(16, 16)
		Me.B_003.Location = New System.Drawing.Point(144, 396)
		Me.B_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.B_003.Picture = CType(resources.GetObject("B_003.Picture"), System.Drawing.Image)
		Me.B_003.Stretch = False
		'
		' B_002
		'
		Me.B_002.Name = "B_002"
		Me.B_002.Size = New System.Drawing.Size(16, 16)
		Me.B_002.Location = New System.Drawing.Point(128, 396)
		Me.B_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.B_002.Picture = CType(resources.GetObject("B_002.Picture"), System.Drawing.Image)
		Me.B_002.Stretch = False
		'
		' B_001
		'
		Me.B_001.Name = "B_001"
		Me.B_001.Size = New System.Drawing.Size(16, 16)
		Me.B_001.Location = New System.Drawing.Point(112, 396)
		Me.B_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.B_001.Picture = CType(resources.GetObject("B_001.Picture"), System.Drawing.Image)
		Me.B_001.Stretch = False
		'
		' B_000
		'
		Me.B_000.Name = "B_000"
		Me.B_000.Size = New System.Drawing.Size(16, 16)
		Me.B_000.Location = New System.Drawing.Point(96, 396)
		Me.B_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.B_000.Picture = CType(resources.GetObject("B_000.Picture"), System.Drawing.Image)
		Me.B_000.Stretch = False
		'
		' A_004
		'
		Me.A_004.Name = "A_004"
		Me.A_004.Size = New System.Drawing.Size(16, 16)
		Me.A_004.Location = New System.Drawing.Point(76, 396)
		Me.A_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.A_004.Picture = CType(resources.GetObject("A_004.Picture"), System.Drawing.Image)
		Me.A_004.Stretch = False
		'
		' A_003
		'
		Me.A_003.Name = "A_003"
		Me.A_003.Size = New System.Drawing.Size(16, 16)
		Me.A_003.Location = New System.Drawing.Point(60, 396)
		Me.A_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.A_003.Picture = CType(resources.GetObject("A_003.Picture"), System.Drawing.Image)
		Me.A_003.Stretch = False
		'
		' A_002
		'
		Me.A_002.Name = "A_002"
		Me.A_002.Size = New System.Drawing.Size(16, 16)
		Me.A_002.Location = New System.Drawing.Point(44, 396)
		Me.A_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.A_002.Picture = CType(resources.GetObject("A_002.Picture"), System.Drawing.Image)
		Me.A_002.Stretch = False
		'
		' A_001
		'
		Me.A_001.Name = "A_001"
		Me.A_001.Size = New System.Drawing.Size(16, 16)
		Me.A_001.Location = New System.Drawing.Point(28, 396)
		Me.A_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.A_001.Picture = CType(resources.GetObject("A_001.Picture"), System.Drawing.Image)
		Me.A_001.Stretch = False
		'
		' A_000
		'
		Me.A_000.Name = "A_000"
		Me.A_000.Size = New System.Drawing.Size(16, 16)
		Me.A_000.Location = New System.Drawing.Point(12, 396)
		Me.A_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.A_000.Picture = CType(resources.GetObject("A_000.Picture"), System.Drawing.Image)
		Me.A_000.Stretch = False
		'
		' SE_008
		'
		Me.SE_008.Name = "SE_008"
		Me.SE_008.Size = New System.Drawing.Size(32, 32)
		Me.SE_008.Location = New System.Drawing.Point(400, 96)
		Me.SE_008.Picture = CType(resources.GetObject("SE_008.Picture"), System.Drawing.Image)
		Me.SE_008.Stretch = False
		'
		' SE_007
		'
		Me.SE_007.Name = "SE_007"
		Me.SE_007.Size = New System.Drawing.Size(32, 32)
		Me.SE_007.Location = New System.Drawing.Point(404, 400)
		Me.SE_007.Picture = CType(resources.GetObject("SE_007.Picture"), System.Drawing.Image)
		Me.SE_007.Stretch = False
		'
		' SE_006
		'
		Me.SE_006.Name = "SE_006"
		Me.SE_006.Size = New System.Drawing.Size(32, 32)
		Me.SE_006.Location = New System.Drawing.Point(404, 364)
		Me.SE_006.Picture = CType(resources.GetObject("SE_006.Picture"), System.Drawing.Image)
		Me.SE_006.Stretch = False
		'
		' SE_005
		'
		Me.SE_005.Name = "SE_005"
		Me.SE_005.Size = New System.Drawing.Size(32, 32)
		Me.SE_005.Location = New System.Drawing.Point(404, 328)
		Me.SE_005.Picture = CType(resources.GetObject("SE_005.Picture"), System.Drawing.Image)
		Me.SE_005.Stretch = False
		'
		' SE_004
		'
		Me.SE_004.Name = "SE_004"
		Me.SE_004.Size = New System.Drawing.Size(32, 32)
		Me.SE_004.Location = New System.Drawing.Point(404, 292)
		Me.SE_004.Picture = CType(resources.GetObject("SE_004.Picture"), System.Drawing.Image)
		Me.SE_004.Stretch = False
		'
		' SE_003
		'
		Me.SE_003.Name = "SE_003"
		Me.SE_003.Size = New System.Drawing.Size(32, 32)
		Me.SE_003.Location = New System.Drawing.Point(404, 252)
		Me.SE_003.Picture = CType(resources.GetObject("SE_003.Picture"), System.Drawing.Image)
		Me.SE_003.Stretch = False
		'
		' SE_002
		'
		Me.SE_002.Name = "SE_002"
		Me.SE_002.Size = New System.Drawing.Size(32, 32)
		Me.SE_002.Location = New System.Drawing.Point(404, 212)
		Me.SE_002.Picture = CType(resources.GetObject("SE_002.Picture"), System.Drawing.Image)
		Me.SE_002.Stretch = False
		'
		' SE_001
		'
		Me.SE_001.Name = "SE_001"
		Me.SE_001.Size = New System.Drawing.Size(32, 32)
		Me.SE_001.Location = New System.Drawing.Point(404, 172)
		Me.SE_001.Picture = CType(resources.GetObject("SE_001.Picture"), System.Drawing.Image)
		Me.SE_001.Stretch = False
		'
		' SE_000
		'
		Me.SE_000.Name = "SE_000"
		Me.SE_000.Size = New System.Drawing.Size(32, 32)
		Me.SE_000.Location = New System.Drawing.Point(404, 136)
		Me.SE_000.Picture = CType(resources.GetObject("SE_000.Picture"), System.Drawing.Image)
		Me.SE_000.Stretch = False
		'
		' Lives_002
		'
		Me.Lives_002.Name = "Lives_002"
		Me.Lives_002.Size = New System.Drawing.Size(20, 20)
		Me.Lives_002.Location = New System.Drawing.Point(256, 32)
		Me.Lives_002.Stretch = True
		Me.Lives_002.Picture = CType(resources.GetObject("Lives_002.Picture"), System.Drawing.Image)
		'
		' Lives_001
		'
		Me.Lives_001.Name = "Lives_001"
		Me.Lives_001.Size = New System.Drawing.Size(20, 20)
		Me.Lives_001.Location = New System.Drawing.Point(240, 32)
		Me.Lives_001.Stretch = True
		Me.Lives_001.Picture = CType(resources.GetObject("Lives_001.Picture"), System.Drawing.Image)
		'
		' Lives_000
		'
		Me.Lives_000.Name = "Lives_000"
		Me.Lives_000.Size = New System.Drawing.Size(20, 20)
		Me.Lives_000.Location = New System.Drawing.Point(224, 32)
		Me.Lives_000.Stretch = True
		Me.Lives_000.Picture = CType(resources.GetObject("Lives_000.Picture"), System.Drawing.Image)
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 26)
		Me.Label2.Location = New System.Drawing.Point(224, 30)
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label2.BackColor = FromOleColor6(CInt(&H00D0FAD0))
		Me.Label2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00000080))
		Me.Label2.TabIndex = 6
		Me.Label2.AutoSize = False
		'
		' lblLevel
		'
		Me.lblLevel.Name = "lblLevel"
		Me.lblLevel.Size = New System.Drawing.Size(29, 19)
		Me.lblLevel.Location = New System.Drawing.Point(316, 4)
		Me.lblLevel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLevel.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLevel.BackColor = FromOleColor6(CInt(&H00C0E0FF))
		Me.lblLevel.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblLevel.Caption = "000"
		Me.lblLevel.ForeColor = FromOleColor6(CInt(&H00000080))
		Me.lblLevel.TabIndex = 5
		Me.lblLevel.AutoSize = False
		'
		' lblPoints
		'
		Me.lblPoints.Name = "lblPoints"
		Me.lblPoints.Size = New System.Drawing.Size(77, 19)
		Me.lblPoints.Location = New System.Drawing.Point(152, 6)
		Me.lblPoints.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPoints.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblPoints.BackColor = FromOleColor6(CInt(&H00FFFFC0))
		Me.lblPoints.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPoints.Caption = "000.000.000"
		Me.lblPoints.ForeColor = FromOleColor6(CInt(&H00800000))
		Me.lblPoints.TabIndex = 4
		Me.lblPoints.AutoSize = False
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(77, 17)
		Me.Label1_002.Location = New System.Drawing.Point(144, 36)
		Me.Label1_002.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_002.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_002.Caption = "ASTRONAVI"
		Me.Label1_002.TabIndex = 3
		Me.Label1_002.AutoSize = False
		Me.Label1_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(45, 17)
		Me.Label1_001.Location = New System.Drawing.Point(108, 8)
		Me.Label1_001.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_001.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_001.Caption = "PUNTI"
		Me.Label1_001.TabIndex = 2
		Me.Label1_001.AutoSize = False
		Me.Label1_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(57, 17)
		Me.Label1_000.Location = New System.Drawing.Point(256, 8)
		Me.Label1_000.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_000.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_000.Caption = "LIVELLO"
		Me.Label1_000.TabIndex = 1
		Me.Label1_000.AutoSize = False
		Me.Label1_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' SH
		'
		Me.SH.Name = "SH"
		Me.SH.Size = New System.Drawing.Size(32, 32)
		Me.SH.Location = New System.Drawing.Point(176, 356)
		Me.SH.Picture = CType(resources.GetObject("SH.Picture"), System.Drawing.Image)
		Me.SH.Stretch = False
		'
		' Shape1
		'
		Me.Shape1.Name = "Shape1"
		Me.Shape1.ParentForm = Me
		Me.Shape1.Name6 = "Shape1"
		Me.Shape1.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.Shape1.Height = 4875
		Me.Shape1.Left = 60
		Me.Shape1.Top = 960
		Me.Shape1.Width = 5655
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.BackColor = FromOleColor6(CInt(&H00D0D0D0))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "AldInvaders 2.0"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(385, 438)

		Me.Controls.Add(cmdStart)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Image1)
		Me.Controls.Add(R_003)
		Me.Controls.Add(K_000)
		Me.Controls.Add(MI_001)
		Me.Controls.Add(MI_000)
		Me.Controls.Add(M_001)
		Me.Controls.Add(R_002)
		Me.Controls.Add(R_001)
		Me.Controls.Add(R_000)
		Me.Controls.Add(M_000)
		Me.Controls.Add(D_004)
		Me.Controls.Add(D_003)
		Me.Controls.Add(D_002)
		Me.Controls.Add(D_001)
		Me.Controls.Add(D_000)
		Me.Controls.Add(C_004)
		Me.Controls.Add(C_003)
		Me.Controls.Add(C_002)
		Me.Controls.Add(C_001)
		Me.Controls.Add(C_000)
		Me.Controls.Add(B_004)
		Me.Controls.Add(B_003)
		Me.Controls.Add(B_002)
		Me.Controls.Add(B_001)
		Me.Controls.Add(B_000)
		Me.Controls.Add(A_004)
		Me.Controls.Add(A_003)
		Me.Controls.Add(A_002)
		Me.Controls.Add(A_001)
		Me.Controls.Add(A_000)
		Me.Controls.Add(SE_008)
		Me.Controls.Add(SE_007)
		Me.Controls.Add(SE_006)
		Me.Controls.Add(SE_005)
		Me.Controls.Add(SE_004)
		Me.Controls.Add(SE_003)
		Me.Controls.Add(SE_002)
		Me.Controls.Add(SE_001)
		Me.Controls.Add(SE_000)
		Me.Controls.Add(Lives_002)
		Me.Controls.Add(Lives_001)
		Me.Controls.Add(Lives_000)
		Me.Controls.Add(Label2)
		Me.Controls.Add(lblLevel)
		Me.Controls.Add(lblPoints)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(Label1_000)
		Me.Controls.Add(SH)
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.R_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.K_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MI_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MI_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.M_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.R_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.R_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.R_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.M_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.D_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.D_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.D_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.D_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.D_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.B_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.B_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.B_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.B_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.B_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.A_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.A_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.A_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.A_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.A_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SE_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Lives_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Lives_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Lives_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SH, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Shape1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
