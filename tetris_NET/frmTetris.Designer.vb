<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTetris
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
		Me.lblRecN = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblRecN_000, lblRecN_001, lblRecN_002)
		Me.lblRecP = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblRecP_000, lblRecP_001, lblRecP_002)
		Me.imgBlock = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(imgBlock_020, imgBlock_000, imgBlock_010, imgBlock_006, imgBlock_002, imgBlock_005, imgBlock_007, imgBlock_004, imgBlock_001, imgBlock_003)
		Me.imgSfondo = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(imgSfondo_009, imgSfondo_015, imgSfondo_011, imgSfondo_013, imgSfondo_012, imgSfondo_014, imgSfondo_010, imgSfondo_008, imgSfondo_007, imgSfondo_006, imgSfondo_005, imgSfondo_004, imgSfondo_003, imgSfondo_002, imgSfondo_001, imgSfondo_000)
		Me.lblMsg = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblMsg_001, lblMsg_000)
		Me.Label1 = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(Label1_002, Label1_001, Label1_000)
		Me.mnuL = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuL_001, mnuL_002, mnuL_003, mnuL_004, mnuL_005, mnuL_006, mnuL_007, mnuL_008, mnuL_009)
		Me.mnuD = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)(mnuD_000, mnuD_001, mnuD_002, mnuD_003, mnuD_004, mnuD_005)
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
	Public lblRecN As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public lblRecP As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public imgBlock As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public imgSfondo As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public lblMsg As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public Label1 As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public mnuL As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public mnuD As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Menu)
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblRecN_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRecP_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRecN_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRecP_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRecN_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblRecP_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents pctGriglia As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents tmrGioco As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents imgBlock_020 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_009 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_015 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_011 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_013 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_012 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_014 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_010 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSfondo_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblMsg_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents imgBlock_000 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_010 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBlock_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblMsg_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents pctPreView As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label1_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLinee As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLivello As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPunti As CodeArchitects.VB6Library.VB6Label
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuParita As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuNuova As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPausa As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuEsci As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuOpzioni As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuLivello As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_004 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_005 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_006 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_007 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_008 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL_009 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuDifficolta As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_000 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_001 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_002 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_003 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_004 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuD_005 As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuPreview As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSfondi As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuAiuto As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTasti As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuPunteggi As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuAbout As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTetris))
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblRecN_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRecP_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRecN_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRecP_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRecN_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblRecP_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.pctGriglia = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.tmrGioco = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.imgBlock_020 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_009 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_015 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_011 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_013 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_012 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_014 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_010 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSfondo_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.lblMsg_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.imgBlock_000 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_010 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBlock_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.lblMsg_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.pctPreView = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label1_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLinee = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLivello = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPunti = New CodeArchitects.VB6Library.VB6Label()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuParita = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuNuova = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPausa = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuEsci = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuOpzioni = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuLivello = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_004 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_005 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_006 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_007 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_008 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL_009 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuDifficolta = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_000 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_001 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_002 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_003 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_004 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuD_005 = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuPreview = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSfondi = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuAiuto = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTasti = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuPunteggi = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.Picture1.SuspendLayout()
		Me.pctGriglia.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.imgBlock_020, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_009, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_015, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_011, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_013, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_012, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_014, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSfondo_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_000, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBlock_003, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(81, 113)
		Me.Picture1.Location = New System.Drawing.Point(188, 216)
		Me.Picture1.TabIndex = 9
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Picture1.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblRecN_000
		'
		Me.lblRecN_000.Name = "lblRecN_000"
		Me.lblRecN_000.Size = New System.Drawing.Size(77, 19)
		Me.lblRecN_000.Location = New System.Drawing.Point(0, 0)
		Me.lblRecN_000.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecN_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecN_000.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecN_000.Caption = "P1"
		Me.lblRecN_000.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblRecN_000.TabIndex = 15
		Me.lblRecN_000.AutoSize = False
		'
		' lblRecP_000
		'
		Me.lblRecP_000.Name = "lblRecP_000"
		Me.lblRecP_000.Size = New System.Drawing.Size(77, 19)
		Me.lblRecP_000.Location = New System.Drawing.Point(0, 18)
		Me.lblRecP_000.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecP_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRecP_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecP_000.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecP_000.Caption = "0"
		Me.lblRecP_000.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblRecP_000.TabIndex = 14
		Me.lblRecP_000.AutoSize = False
		'
		' lblRecN_001
		'
		Me.lblRecN_001.Name = "lblRecN_001"
		Me.lblRecN_001.Size = New System.Drawing.Size(77, 19)
		Me.lblRecN_001.Location = New System.Drawing.Point(0, 36)
		Me.lblRecN_001.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecN_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecN_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecN_001.Caption = "P1"
		Me.lblRecN_001.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblRecN_001.TabIndex = 13
		Me.lblRecN_001.AutoSize = False
		'
		' lblRecP_001
		'
		Me.lblRecP_001.Name = "lblRecP_001"
		Me.lblRecP_001.Size = New System.Drawing.Size(77, 19)
		Me.lblRecP_001.Location = New System.Drawing.Point(0, 54)
		Me.lblRecP_001.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecP_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRecP_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecP_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecP_001.Caption = "0"
		Me.lblRecP_001.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblRecP_001.TabIndex = 12
		Me.lblRecP_001.AutoSize = False
		'
		' lblRecN_002
		'
		Me.lblRecN_002.Name = "lblRecN_002"
		Me.lblRecN_002.Size = New System.Drawing.Size(77, 19)
		Me.lblRecN_002.Location = New System.Drawing.Point(0, 72)
		Me.lblRecN_002.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecN_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecN_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecN_002.Caption = "P1"
		Me.lblRecN_002.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lblRecN_002.TabIndex = 11
		Me.lblRecN_002.AutoSize = False
		'
		' lblRecP_002
		'
		Me.lblRecP_002.Name = "lblRecP_002"
		Me.lblRecP_002.Size = New System.Drawing.Size(77, 19)
		Me.lblRecP_002.Location = New System.Drawing.Point(0, 90)
		Me.lblRecP_002.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecP_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblRecP_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblRecP_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblRecP_002.Caption = "0"
		Me.lblRecP_002.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.lblRecP_002.TabIndex = 10
		Me.lblRecP_002.AutoSize = False
		'
		' pctGriglia
		'
		Me.pctGriglia.Name = "pctGriglia"
		Me.pctGriglia.Size = New System.Drawing.Size(184, 304)
		Me.pctGriglia.Location = New System.Drawing.Point(0, 26)
		Me.pctGriglia.AutoRedraw = True
		Me.pctGriglia.BackColor = FromOleColor6(CInt(&H00808080))
		Me.pctGriglia.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.pctGriglia.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctGriglia.TabIndex = 1
		Me.pctGriglia.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pctGriglia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctGriglia.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' tmrGioco
		'
		Me.tmrGioco.Name = "tmrGioco"
		Me.tmrGioco.ParentForm = Me
		Me.tmrGioco.Name6 = "tmrGioco"
		Me.tmrGioco.Enabled = False
		Me.tmrGioco.Interval = 300
		'
		' imgBlock_020
		'
		Me.imgBlock_020.Name = "imgBlock_020"
		Me.imgBlock_020.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_020.Location = New System.Drawing.Point(0, 180)
		Me.imgBlock_020.Visible = False
		Me.imgBlock_020.Picture = CType(resources.GetObject("imgBlock_020.Picture"), System.Drawing.Image)
		Me.imgBlock_020.Stretch = False
		'
		' imgSfondo_009
		'
		Me.imgSfondo_009.Name = "imgSfondo_009"
		Me.imgSfondo_009.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_009.Location = New System.Drawing.Point(20, 40)
		Me.imgSfondo_009.Visible = False
		Me.imgSfondo_009.Picture = CType(resources.GetObject("imgSfondo_009.Picture"), System.Drawing.Image)
		Me.imgSfondo_009.Stretch = False
		'
		' imgSfondo_015
		'
		Me.imgSfondo_015.Name = "imgSfondo_015"
		Me.imgSfondo_015.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_015.Location = New System.Drawing.Point(20, 160)
		Me.imgSfondo_015.Visible = False
		Me.imgSfondo_015.Picture = CType(resources.GetObject("imgSfondo_015.Picture"), System.Drawing.Image)
		Me.imgSfondo_015.Stretch = False
		'
		' imgSfondo_011
		'
		Me.imgSfondo_011.Name = "imgSfondo_011"
		Me.imgSfondo_011.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_011.Location = New System.Drawing.Point(20, 80)
		Me.imgSfondo_011.Visible = False
		Me.imgSfondo_011.Picture = CType(resources.GetObject("imgSfondo_011.Picture"), System.Drawing.Image)
		Me.imgSfondo_011.Stretch = False
		'
		' imgSfondo_013
		'
		Me.imgSfondo_013.Name = "imgSfondo_013"
		Me.imgSfondo_013.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_013.Location = New System.Drawing.Point(20, 120)
		Me.imgSfondo_013.Visible = False
		Me.imgSfondo_013.Picture = CType(resources.GetObject("imgSfondo_013.Picture"), System.Drawing.Image)
		Me.imgSfondo_013.Stretch = False
		'
		' imgSfondo_012
		'
		Me.imgSfondo_012.Name = "imgSfondo_012"
		Me.imgSfondo_012.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_012.Location = New System.Drawing.Point(20, 100)
		Me.imgSfondo_012.Visible = False
		Me.imgSfondo_012.Picture = CType(resources.GetObject("imgSfondo_012.Picture"), System.Drawing.Image)
		Me.imgSfondo_012.Stretch = False
		'
		' imgSfondo_014
		'
		Me.imgSfondo_014.Name = "imgSfondo_014"
		Me.imgSfondo_014.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_014.Location = New System.Drawing.Point(20, 140)
		Me.imgSfondo_014.Visible = False
		Me.imgSfondo_014.Picture = CType(resources.GetObject("imgSfondo_014.Picture"), System.Drawing.Image)
		Me.imgSfondo_014.Stretch = False
		'
		' imgSfondo_010
		'
		Me.imgSfondo_010.Name = "imgSfondo_010"
		Me.imgSfondo_010.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_010.Location = New System.Drawing.Point(20, 60)
		Me.imgSfondo_010.Visible = False
		Me.imgSfondo_010.Picture = CType(resources.GetObject("imgSfondo_010.Picture"), System.Drawing.Image)
		Me.imgSfondo_010.Stretch = False
		'
		' imgSfondo_008
		'
		Me.imgSfondo_008.Name = "imgSfondo_008"
		Me.imgSfondo_008.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_008.Location = New System.Drawing.Point(20, 20)
		Me.imgSfondo_008.Visible = False
		Me.imgSfondo_008.Picture = CType(resources.GetObject("imgSfondo_008.Picture"), System.Drawing.Image)
		Me.imgSfondo_008.Stretch = False
		'
		' imgSfondo_007
		'
		Me.imgSfondo_007.Name = "imgSfondo_007"
		Me.imgSfondo_007.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_007.Location = New System.Drawing.Point(0, 160)
		Me.imgSfondo_007.Visible = False
		Me.imgSfondo_007.Picture = CType(resources.GetObject("imgSfondo_007.Picture"), System.Drawing.Image)
		Me.imgSfondo_007.Stretch = False
		'
		' imgSfondo_006
		'
		Me.imgSfondo_006.Name = "imgSfondo_006"
		Me.imgSfondo_006.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_006.Location = New System.Drawing.Point(0, 140)
		Me.imgSfondo_006.Visible = False
		Me.imgSfondo_006.Picture = CType(resources.GetObject("imgSfondo_006.Picture"), System.Drawing.Image)
		Me.imgSfondo_006.Stretch = False
		'
		' imgSfondo_005
		'
		Me.imgSfondo_005.Name = "imgSfondo_005"
		Me.imgSfondo_005.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_005.Location = New System.Drawing.Point(0, 120)
		Me.imgSfondo_005.Visible = False
		Me.imgSfondo_005.Picture = CType(resources.GetObject("imgSfondo_005.Picture"), System.Drawing.Image)
		Me.imgSfondo_005.Stretch = False
		'
		' imgSfondo_004
		'
		Me.imgSfondo_004.Name = "imgSfondo_004"
		Me.imgSfondo_004.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_004.Location = New System.Drawing.Point(0, 100)
		Me.imgSfondo_004.Visible = False
		Me.imgSfondo_004.Picture = CType(resources.GetObject("imgSfondo_004.Picture"), System.Drawing.Image)
		Me.imgSfondo_004.Stretch = False
		'
		' imgSfondo_003
		'
		Me.imgSfondo_003.Name = "imgSfondo_003"
		Me.imgSfondo_003.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_003.Location = New System.Drawing.Point(0, 80)
		Me.imgSfondo_003.Visible = False
		Me.imgSfondo_003.Picture = CType(resources.GetObject("imgSfondo_003.Picture"), System.Drawing.Image)
		Me.imgSfondo_003.Stretch = False
		'
		' imgSfondo_002
		'
		Me.imgSfondo_002.Name = "imgSfondo_002"
		Me.imgSfondo_002.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_002.Location = New System.Drawing.Point(0, 60)
		Me.imgSfondo_002.Visible = False
		Me.imgSfondo_002.Picture = CType(resources.GetObject("imgSfondo_002.Picture"), System.Drawing.Image)
		Me.imgSfondo_002.Stretch = False
		'
		' imgSfondo_001
		'
		Me.imgSfondo_001.Name = "imgSfondo_001"
		Me.imgSfondo_001.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_001.Location = New System.Drawing.Point(0, 40)
		Me.imgSfondo_001.Visible = False
		Me.imgSfondo_001.Picture = CType(resources.GetObject("imgSfondo_001.Picture"), System.Drawing.Image)
		Me.imgSfondo_001.Stretch = False
		'
		' imgSfondo_000
		'
		Me.imgSfondo_000.Name = "imgSfondo_000"
		Me.imgSfondo_000.Size = New System.Drawing.Size(20, 20)
		Me.imgSfondo_000.Location = New System.Drawing.Point(0, 20)
		Me.imgSfondo_000.Visible = False
		Me.imgSfondo_000.Picture = CType(resources.GetObject("imgSfondo_000.Picture"), System.Drawing.Image)
		Me.imgSfondo_000.Stretch = False
		'
		' lblMsg_001
		'
		Me.lblMsg_001.Name = "lblMsg_001"
		Me.lblMsg_001.Size = New System.Drawing.Size(70, 25)
		Me.lblMsg_001.Location = New System.Drawing.Point(62, 107)
		Me.lblMsg_001.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMsg_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblMsg_001.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblMsg_001.Caption = "lblMsg"
		Me.lblMsg_001.ForeColor = FromOleColor6(CInt(&H008080FF))
		Me.lblMsg_001.TabIndex = 3
		Me.lblMsg_001.Visible = False
		Me.lblMsg_001.AutoSize = False
		Me.lblMsg_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' imgBlock_000
		'
		Me.imgBlock_000.Name = "imgBlock_000"
		Me.imgBlock_000.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_000.Location = New System.Drawing.Point(0, 0)
		Me.imgBlock_000.Visible = False
		Me.imgBlock_000.Picture = CType(resources.GetObject("imgBlock_000.Picture"), System.Drawing.Image)
		Me.imgBlock_000.Stretch = False
		'
		' imgBlock_010
		'
		Me.imgBlock_010.Name = "imgBlock_010"
		Me.imgBlock_010.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_010.Location = New System.Drawing.Point(160, 0)
		Me.imgBlock_010.Visible = False
		Me.imgBlock_010.Picture = CType(resources.GetObject("imgBlock_010.Picture"), System.Drawing.Image)
		Me.imgBlock_010.Stretch = False
		'
		' imgBlock_006
		'
		Me.imgBlock_006.Name = "imgBlock_006"
		Me.imgBlock_006.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_006.Location = New System.Drawing.Point(120, 0)
		Me.imgBlock_006.Visible = False
		Me.imgBlock_006.Picture = CType(resources.GetObject("imgBlock_006.Picture"), System.Drawing.Image)
		Me.imgBlock_006.Stretch = False
		'
		' imgBlock_002
		'
		Me.imgBlock_002.Name = "imgBlock_002"
		Me.imgBlock_002.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_002.Location = New System.Drawing.Point(40, 0)
		Me.imgBlock_002.Visible = False
		Me.imgBlock_002.Picture = CType(resources.GetObject("imgBlock_002.Picture"), System.Drawing.Image)
		Me.imgBlock_002.Stretch = False
		'
		' imgBlock_005
		'
		Me.imgBlock_005.Name = "imgBlock_005"
		Me.imgBlock_005.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_005.Location = New System.Drawing.Point(100, 0)
		Me.imgBlock_005.Visible = False
		Me.imgBlock_005.Picture = CType(resources.GetObject("imgBlock_005.Picture"), System.Drawing.Image)
		Me.imgBlock_005.Stretch = False
		'
		' imgBlock_007
		'
		Me.imgBlock_007.Name = "imgBlock_007"
		Me.imgBlock_007.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_007.Location = New System.Drawing.Point(140, 0)
		Me.imgBlock_007.Visible = False
		Me.imgBlock_007.Picture = CType(resources.GetObject("imgBlock_007.Picture"), System.Drawing.Image)
		Me.imgBlock_007.Stretch = False
		'
		' imgBlock_004
		'
		Me.imgBlock_004.Name = "imgBlock_004"
		Me.imgBlock_004.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_004.Location = New System.Drawing.Point(80, 0)
		Me.imgBlock_004.Visible = False
		Me.imgBlock_004.Picture = CType(resources.GetObject("imgBlock_004.Picture"), System.Drawing.Image)
		Me.imgBlock_004.Stretch = False
		'
		' imgBlock_001
		'
		Me.imgBlock_001.Name = "imgBlock_001"
		Me.imgBlock_001.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_001.Location = New System.Drawing.Point(20, 0)
		Me.imgBlock_001.Visible = False
		Me.imgBlock_001.Picture = CType(resources.GetObject("imgBlock_001.Picture"), System.Drawing.Image)
		Me.imgBlock_001.Stretch = False
		'
		' imgBlock_003
		'
		Me.imgBlock_003.Name = "imgBlock_003"
		Me.imgBlock_003.Size = New System.Drawing.Size(20, 20)
		Me.imgBlock_003.Location = New System.Drawing.Point(60, 0)
		Me.imgBlock_003.Visible = False
		Me.imgBlock_003.Picture = CType(resources.GetObject("imgBlock_003.Picture"), System.Drawing.Image)
		Me.imgBlock_003.Stretch = False
		'
		' lblMsg_000
		'
		Me.lblMsg_000.Name = "lblMsg_000"
		Me.lblMsg_000.Size = New System.Drawing.Size(70, 25)
		Me.lblMsg_000.Location = New System.Drawing.Point(62, 108)
		Me.lblMsg_000.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMsg_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblMsg_000.BackColor = FromOleColor6(CInt(&H00404080))
		Me.lblMsg_000.Caption = "lblMsg"
		Me.lblMsg_000.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMsg_000.TabIndex = 4
		Me.lblMsg_000.Visible = False
		Me.lblMsg_000.AutoSize = False
		'
		' pctPreView
		'
		Me.pctPreView.Name = "pctPreView"
		Me.pctPreView.Size = New System.Drawing.Size(80, 80)
		Me.pctPreView.Location = New System.Drawing.Point(188, 24)
		Me.pctPreView.AutoRedraw = True
		Me.pctPreView.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.pctPreView.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctPreView.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctPreView.TabIndex = 2
		Me.pctPreView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctPreView.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Label1_002
		'
		Me.Label1_002.Name = "Label1_002"
		Me.Label1_002.Size = New System.Drawing.Size(68, 31)
		Me.Label1_002.Location = New System.Drawing.Point(196, 186)
		Me.Label1_002.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_002.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_002.Caption = "Punteggi migliori"
		Me.Label1_002.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.Label1_002.TabIndex = 16
		Me.Label1_002.AutoSize = False
		Me.Label1_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_001
		'
		Me.Label1_001.Name = "Label1_001"
		Me.Label1_001.Size = New System.Drawing.Size(49, 13)
		Me.Label1_001.Location = New System.Drawing.Point(192, 128)
		Me.Label1_001.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_001.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_001.Caption = "Linee"
		Me.Label1_001.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.Label1_001.TabIndex = 8
		Me.Label1_001.AutoSize = False
		Me.Label1_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLinee
		'
		Me.lblLinee.Name = "lblLinee"
		Me.lblLinee.Size = New System.Drawing.Size(8, 13)
		Me.lblLinee.Location = New System.Drawing.Point(258, 128)
		Me.lblLinee.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLinee.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLinee.AutoSize = True
		Me.lblLinee.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblLinee.Caption = "0"
		Me.lblLinee.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.lblLinee.TabIndex = 7
		Me.lblLinee.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblLivello
		'
		Me.lblLivello.Name = "lblLivello"
		Me.lblLivello.Size = New System.Drawing.Size(10, 13)
		Me.lblLivello.Location = New System.Drawing.Point(248, 110)
		Me.lblLivello.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLivello.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblLivello.AutoSize = True
		Me.lblLivello.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblLivello.Caption = "5"
		Me.lblLivello.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.lblLivello.TabIndex = 6
		Me.lblLivello.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1_000
		'
		Me.Label1_000.Name = "Label1_000"
		Me.Label1_000.Size = New System.Drawing.Size(33, 13)
		Me.Label1_000.Location = New System.Drawing.Point(200, 110)
		Me.Label1_000.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1_000.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1_000.Caption = "LIV."
		Me.Label1_000.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.Label1_000.TabIndex = 5
		Me.Label1_000.AutoSize = False
		Me.Label1_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblPunti
		'
		Me.lblPunti.Name = "lblPunti"
		Me.lblPunti.Size = New System.Drawing.Size(80, 17)
		Me.lblPunti.Location = New System.Drawing.Point(188, 146)
		Me.lblPunti.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPunti.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblPunti.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPunti.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblPunti.Caption = "0"
		Me.lblPunti.TabIndex = 0
		Me.lblPunti.AutoSize = False
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuParita
		'
		Me.mnuParita.Name = "mnuParita"
		Me.mnuParita.Caption = "&Partita"
		'
		' mnuNuova
		'
		Me.mnuNuova.Name = "mnuNuova"
		Me.mnuNuova.Caption = "&Nuova"
		Me.mnuNuova.Shortcut = Keys.F2
		'
		' mnuPausa
		'
		Me.mnuPausa.Name = "mnuPausa"
		Me.mnuPausa.Caption = "Interrompi/&Riprendi"
		Me.mnuPausa.Shortcut = Keys.F3
		'
		' mnuL1
		'
		Me.mnuL1.Name = "mnuL1"
		'
		' mnuEsci
		'
		Me.mnuEsci.Name = "mnuEsci"
		Me.mnuEsci.Caption = "&Esci"
		'
		' mnuOpzioni
		'
		Me.mnuOpzioni.Name = "mnuOpzioni"
		Me.mnuOpzioni.Caption = "&Opzioni"
		'
		' mnuLivello
		'
		Me.mnuLivello.Name = "mnuLivello"
		Me.mnuLivello.Caption = "&Livello"
		'
		' mnuL_001
		'
		Me.mnuL_001.Name = "mnuL_001"
		Me.mnuL_001.Caption = "&1"
		'
		' mnuL_002
		'
		Me.mnuL_002.Name = "mnuL_002"
		Me.mnuL_002.Caption = "&2"
		'
		' mnuL_003
		'
		Me.mnuL_003.Name = "mnuL_003"
		Me.mnuL_003.Caption = "&3"
		'
		' mnuL_004
		'
		Me.mnuL_004.Name = "mnuL_004"
		Me.mnuL_004.Caption = "&4"
		'
		' mnuL_005
		'
		Me.mnuL_005.Name = "mnuL_005"
		Me.mnuL_005.Caption = "&5"
		Me.mnuL_005.Checked = True
		'
		' mnuL_006
		'
		Me.mnuL_006.Name = "mnuL_006"
		Me.mnuL_006.Caption = "&6"
		'
		' mnuL_007
		'
		Me.mnuL_007.Name = "mnuL_007"
		Me.mnuL_007.Caption = "&7"
		'
		' mnuL_008
		'
		Me.mnuL_008.Name = "mnuL_008"
		Me.mnuL_008.Caption = "&8"
		'
		' mnuL_009
		'
		Me.mnuL_009.Name = "mnuL_009"
		Me.mnuL_009.Caption = "&9"
		'
		' mnuDifficolta
		'
		Me.mnuDifficolta.Name = "mnuDifficolta"
		Me.mnuDifficolta.Caption = "&DifficoltÃ "
		'
		' mnuD_000
		'
		Me.mnuD_000.Name = "mnuD_000"
		Me.mnuD_000.Caption = "&0"
		Me.mnuD_000.Checked = True
		'
		' mnuD_001
		'
		Me.mnuD_001.Name = "mnuD_001"
		Me.mnuD_001.Caption = "&1"
		'
		' mnuD_002
		'
		Me.mnuD_002.Name = "mnuD_002"
		Me.mnuD_002.Caption = "&2"
		'
		' mnuD_003
		'
		Me.mnuD_003.Name = "mnuD_003"
		Me.mnuD_003.Caption = "&3"
		'
		' mnuD_004
		'
		Me.mnuD_004.Name = "mnuD_004"
		Me.mnuD_004.Caption = "&4"
		'
		' mnuD_005
		'
		Me.mnuD_005.Name = "mnuD_005"
		Me.mnuD_005.Caption = "&5"
		'
		' mnuL2
		'
		Me.mnuL2.Name = "mnuL2"
		'
		' mnuPreview
		'
		Me.mnuPreview.Name = "mnuPreview"
		Me.mnuPreview.Caption = "&Mostra/Nascondi anteprima"
		Me.mnuPreview.Checked = True
		Me.mnuPreview.Shortcut = Keys.Control Or Keys.P
		'
		' mnuSfondi
		'
		Me.mnuSfondi.Name = "mnuSfondi"
		Me.mnuSfondi.Caption = "&Visualizza sfondi"
		Me.mnuSfondi.Checked = True
		'
		' mnuAiuto
		'
		Me.mnuAiuto.Name = "mnuAiuto"
		Me.mnuAiuto.Caption = "&?"
		'
		' mnuTasti
		'
		Me.mnuTasti.Name = "mnuTasti"
		Me.mnuTasti.Caption = "&Tasti"
		'
		' mnuPunteggi
		'
		Me.mnuPunteggi.Name = "mnuPunteggi"
		Me.mnuPunteggi.Caption = "&Punteggi"
		'
		' mnuL3
		'
		Me.mnuL3.Name = "mnuL3"
		'
		' mnuAbout
		'
		Me.mnuAbout.Name = "mnuAbout"
		Me.mnuAbout.Caption = "&Informazioni su ..."
		'
		' frmTetris
		'
		Me.Name = "frmTetris"
		Me.AutoRedraw = True
		Me.Caption = "Tetris"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaxButton = False
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.MainMenuStrip = Me.MenuStrip1
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Location = New System.Drawing.Point(230, 138)
		Me.ClientSize = New System.Drawing.Size(271, 330)

		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(lblRecN_000)
		Me.Picture1.Controls.Add(lblRecP_000)
		Me.Picture1.Controls.Add(lblRecN_001)
		Me.Picture1.Controls.Add(lblRecP_001)
		Me.Picture1.Controls.Add(lblRecN_002)
		Me.Picture1.Controls.Add(lblRecP_002)
		Me.Controls.Add(pctGriglia)
		Me.pctGriglia.Controls.Add(imgBlock_020)
		Me.pctGriglia.Controls.Add(imgSfondo_009)
		Me.pctGriglia.Controls.Add(imgSfondo_015)
		Me.pctGriglia.Controls.Add(imgSfondo_011)
		Me.pctGriglia.Controls.Add(imgSfondo_013)
		Me.pctGriglia.Controls.Add(imgSfondo_012)
		Me.pctGriglia.Controls.Add(imgSfondo_014)
		Me.pctGriglia.Controls.Add(imgSfondo_010)
		Me.pctGriglia.Controls.Add(imgSfondo_008)
		Me.pctGriglia.Controls.Add(imgSfondo_007)
		Me.pctGriglia.Controls.Add(imgSfondo_006)
		Me.pctGriglia.Controls.Add(imgSfondo_005)
		Me.pctGriglia.Controls.Add(imgSfondo_004)
		Me.pctGriglia.Controls.Add(imgSfondo_003)
		Me.pctGriglia.Controls.Add(imgSfondo_002)
		Me.pctGriglia.Controls.Add(imgSfondo_001)
		Me.pctGriglia.Controls.Add(imgSfondo_000)
		Me.pctGriglia.Controls.Add(lblMsg_001)
		Me.pctGriglia.Controls.Add(imgBlock_000)
		Me.pctGriglia.Controls.Add(imgBlock_010)
		Me.pctGriglia.Controls.Add(imgBlock_006)
		Me.pctGriglia.Controls.Add(imgBlock_002)
		Me.pctGriglia.Controls.Add(imgBlock_005)
		Me.pctGriglia.Controls.Add(imgBlock_007)
		Me.pctGriglia.Controls.Add(imgBlock_004)
		Me.pctGriglia.Controls.Add(imgBlock_001)
		Me.pctGriglia.Controls.Add(imgBlock_003)
		Me.pctGriglia.Controls.Add(lblMsg_000)
		Me.Controls.Add(pctPreView)
		Me.Controls.Add(Label1_002)
		Me.Controls.Add(Label1_001)
		Me.Controls.Add(lblLinee)
		Me.Controls.Add(lblLivello)
		Me.Controls.Add(Label1_000)
		Me.Controls.Add(lblPunti)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuParita)
		Me.mnuParita.DropDownItems.Add(mnuNuova)
		Me.mnuParita.DropDownItems.Add(mnuPausa)
		Me.mnuParita.DropDownItems.Add(mnuL1)
		Me.mnuParita.DropDownItems.Add(mnuEsci)
		Me.MenuStrip1.Items.Add(mnuOpzioni)
		Me.mnuOpzioni.DropDownItems.Add(mnuLivello)
		Me.mnuLivello.DropDownItems.Add(mnuL_001)
		Me.mnuLivello.DropDownItems.Add(mnuL_002)
		Me.mnuLivello.DropDownItems.Add(mnuL_003)
		Me.mnuLivello.DropDownItems.Add(mnuL_004)
		Me.mnuLivello.DropDownItems.Add(mnuL_005)
		Me.mnuLivello.DropDownItems.Add(mnuL_006)
		Me.mnuLivello.DropDownItems.Add(mnuL_007)
		Me.mnuLivello.DropDownItems.Add(mnuL_008)
		Me.mnuLivello.DropDownItems.Add(mnuL_009)
		Me.mnuOpzioni.DropDownItems.Add(mnuDifficolta)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_000)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_001)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_002)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_003)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_004)
		Me.mnuDifficolta.DropDownItems.Add(mnuD_005)
		Me.mnuOpzioni.DropDownItems.Add(mnuL2)
		Me.mnuOpzioni.DropDownItems.Add(mnuPreview)
		Me.mnuOpzioni.DropDownItems.Add(mnuSfondi)
		Me.MenuStrip1.Items.Add(mnuAiuto)
		Me.mnuAiuto.DropDownItems.Add(mnuTasti)
		Me.mnuAiuto.DropDownItems.Add(mnuPunteggi)
		Me.mnuAiuto.DropDownItems.Add(mnuL3)
		Me.mnuAiuto.DropDownItems.Add(mnuAbout)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.imgBlock_020, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_009, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_015, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_011, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_013, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_012, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_014, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSfondo_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_000, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBlock_003, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picture1.ResumeLayout(False)
		Me.pctGriglia.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
