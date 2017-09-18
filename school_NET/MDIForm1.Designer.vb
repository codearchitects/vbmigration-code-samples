<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MDIForm1
	Inherits CodeArchitects.VB6Library.VB6MdiForm

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
	Public WithEvents Picture4 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture3 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture2 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Picture1 As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Toolbar1 As CodeArchitects.VB6Library.VB6Toolbar
	Public WithEvents ImageList2 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents ImageList1 As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents StatusBar1 As CodeArchitects.VB6Library.VB6StatusBar
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents mnuF As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuMSR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuS As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuL As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuMSY As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep5 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuAO As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep10 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuE As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuMRS As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuIR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuSPS As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep8 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuSL As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep7 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuPR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuV As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTAP As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTAB As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTAL As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTAR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep4 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuHSM As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHSS As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuT As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuCalc As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuNP As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep6 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents mnuCalen As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuW As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTH As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuTV As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuC As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuAI As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents sep3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents winlist As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuHLP As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents mnuAbt As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Toolbar1_Control As System.Windows.Forms.ToolStrip
	Public WithEvents Toolbar1_Button1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button7 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button10 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button11 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button12 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button13 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button14 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button15 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button16 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Button17 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Toolbar1_Button18 As System.Windows.Forms.ToolStripButton
	Public WithEvents StatusBar1_Control As System.Windows.Forms.StatusStrip
	Public WithEvents StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel4 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel5 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel6 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel7 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel8 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1_Panel9 As System.Windows.Forms.ToolStripStatusLabel

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIForm1))
		Me.Picture4 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture3 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture2 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Picture1 = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Toolbar1 = New CodeArchitects.VB6Library.VB6Toolbar()
		Me.ImageList2 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.ImageList1 = New CodeArchitects.VB6Library.VB6ImageList()
		Me.StatusBar1 = New CodeArchitects.VB6Library.VB6StatusBar()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.mnuF = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuMSR = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuS = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuL = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuMSY = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep5 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuAO = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep10 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuE = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuR = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuMRS = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuIR = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuSPS = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep8 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuSL = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep7 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuPR = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuV = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTAP = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTAB = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTAL = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTAR = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep4 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuHSM = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHSS = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuT = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuCalc = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuNP = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep6 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuCalen = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuW = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTH = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuTV = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuC = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuAI = New CodeArchitects.VB6Library.VB6Menu()
		Me.sep3 = New System.Windows.Forms.ToolStripSeparator()
		Me.winlist = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuHLP = New CodeArchitects.VB6Library.VB6Menu()
		Me.mnuAbt = New CodeArchitects.VB6Library.VB6Menu()
		Me.Toolbar1_Control = New System.Windows.Forms.ToolStrip()
		Me.Toolbar1_Button1 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button2 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button3 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button7 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button8 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button9 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button10 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button11 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button12 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button13 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button14 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button15 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button16 = New System.Windows.Forms.ToolStripButton()
		Me.Toolbar1_Button17 = New System.Windows.Forms.ToolStripSeparator()
		Me.Toolbar1_Button18 = New System.Windows.Forms.ToolStripButton()
		Me.StatusBar1_Control = New System.Windows.Forms.StatusStrip()
		Me.StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel5 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel6 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel7 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel8 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusBar1_Panel9 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picture4
		'
		Me.Picture4.Name = "Picture4"
		Me.Picture4.Size = New System.Drawing.Size(533, 1)
		Me.Picture4.Location = New System.Drawing.Point(0, 474)
		Me.Picture4.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.Picture4.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture4.TabIndex = 4
		Me.Picture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture3
		'
		Me.Picture3.Name = "Picture3"
		Me.Picture3.Size = New System.Drawing.Size(533, 1)
		Me.Picture3.Location = New System.Drawing.Point(0, 25)
		Me.Picture3.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignTop
		Me.Picture3.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Picture3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture3.TabIndex = 3
		Me.Picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture2
		'
		Me.Picture2.Name = "Picture2"
		Me.Picture2.Size = New System.Drawing.Size(533, 1)
		Me.Picture2.Location = New System.Drawing.Point(0, 475)
		Me.Picture2.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.Picture2.BackColor = FromOleColor6(CInt(&H80000005))
		Me.Picture2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture2.TabIndex = 2
		Me.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Picture1
		'
		Me.Picture1.Name = "Picture1"
		Me.Picture1.Size = New System.Drawing.Size(533, 1)
		Me.Picture1.Location = New System.Drawing.Point(0, 24)
		Me.Picture1.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignTop
		Me.Picture1.BackColor = FromOleColor6(CInt(&H80000010))
		Me.Picture1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picture1.TabIndex = 1
		Me.Picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picture1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Toolbar1
		'
		Me.Toolbar1.Name = "Toolbar1"
		Me.Toolbar1.Location = New System.Drawing.Point(0, 26)
		Me.Toolbar1.ButtonWidth = 609
		Me.Toolbar1.ButtonHeight = 582
		Me.Toolbar1.ImageList = ImageList1
		Me.Toolbar1.Size = New System.Drawing.Size(2, 2)
		Me.Toolbar1.ToolStrip = Me.Toolbar1_Control
		Me.Toolbar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toolbar1_Button1, Me.Toolbar1_Button2, Me.Toolbar1_Button3, Me.Toolbar1_Button4, Me.Toolbar1_Button5, Me.Toolbar1_Button6, Me.Toolbar1_Button7, Me.Toolbar1_Button8, Me.Toolbar1_Button9, Me.Toolbar1_Button10, Me.Toolbar1_Button11, Me.Toolbar1_Button12, Me.Toolbar1_Button13, Me.Toolbar1_Button14, Me.Toolbar1_Button15, Me.Toolbar1_Button16, Me.Toolbar1_Button17, Me.Toolbar1_Button18})
		'
		' ImageList2
		'
		Me.ImageList2.Name = "ImageList2"
		Me.ImageList2.ParentForm = Me
		Me.ImageList2.Name6 = "ImageList2"
		Me.ImageList2.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList2.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList2.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' ImageList1
		'
		Me.ImageList1.Name = "ImageList1"
		Me.ImageList1.ParentForm = Me
		Me.ImageList1.Name6 = "ImageList1"
		Me.ImageList1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.ImageList1.MaskColor = FromOleColor6(CInt(12632256))
		Me.ImageList1.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' StatusBar1
		'
		Me.StatusBar1.Name = "StatusBar1"
		Me.StatusBar1.Location = New System.Drawing.Point(0, 476)
		Me.StatusBar1.Size = New System.Drawing.Size(2, 2)
		Me.StatusBar1.StatusStrip = Me.StatusBar1_Control
		Me.StatusBar1_Control.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBar1_Panel1, Me.StatusBar1_Panel2, Me.StatusBar1_Panel3, Me.StatusBar1_Panel4, Me.StatusBar1_Panel5, Me.StatusBar1_Panel6, Me.StatusBar1_Panel7, Me.StatusBar1_Panel8, Me.StatusBar1_Panel9})
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' mnuF
		'
		Me.mnuF.Name = "mnuF"
		Me.mnuF.Caption = "&File"
		'
		' mnuMSR
		'
		Me.mnuMSR.Name = "mnuMSR"
		Me.mnuMSR.Caption = "Modify Student Record"
		Me.mnuMSR.Shortcut = Keys.Control Or Keys.N
		'
		' mnuS
		'
		Me.mnuS.Name = "mnuS"
		Me.mnuS.Caption = "Sections"
		Me.mnuS.Shortcut = Keys.Control Or Keys.O
		'
		' mnuL
		'
		Me.mnuL.Name = "mnuL"
		Me.mnuL.Caption = "&Level"
		Me.mnuL.Shortcut = Keys.Control Or Keys.L
		'
		' mnuMSY
		'
		Me.mnuMSY.Name = "mnuMSY"
		Me.mnuMSY.Caption = "Modify School Year"
		Me.mnuMSY.Shortcut = Keys.Control Or Keys.Y
		'
		' sep5
		'
		Me.sep5.Name = "sep5"
		'
		' mnuAO
		'
		Me.mnuAO.Name = "mnuAO"
		Me.mnuAO.Caption = "&Administrator Option"
		'
		' sep10
		'
		Me.sep10.Name = "sep10"
		'
		' mnuE
		'
		Me.mnuE.Name = "mnuE"
		Me.mnuE.Caption = "Exit"
		Me.mnuE.Shortcut = Keys.Control Or Keys.F
		'
		' mnuR
		'
		Me.mnuR.Name = "mnuR"
		Me.mnuR.Caption = "Reports"
		'
		' mnuMRS
		'
		Me.mnuMRS.Name = "mnuMRS"
		Me.mnuMRS.Caption = "&Make Registration Slip"
		Me.mnuMRS.Shortcut = Keys.Control Or Keys.M
		'
		' mnuIR
		'
		Me.mnuIR.Name = "mnuIR"
		Me.mnuIR.Caption = "Individual Reports"
		Me.mnuIR.Shortcut = Keys.Control Or Keys.I
		'
		' mnuSPS
		'
		Me.mnuSPS.Name = "mnuSPS"
		Me.mnuSPS.Caption = "Student Per Section"
		Me.mnuSPS.Shortcut = Keys.Control Or Keys.S
		'
		' sep8
		'
		Me.sep8.Name = "sep8"
		'
		' mnuSL
		'
		Me.mnuSL.Name = "mnuSL"
		Me.mnuSL.Caption = "Student List"
		Me.mnuSL.Shortcut = Keys.Control Or Keys.T
		'
		' sep7
		'
		Me.sep7.Name = "sep7"
		'
		' mnuPR
		'
		Me.mnuPR.Name = "mnuPR"
		Me.mnuPR.Caption = "Population Report"
		Me.mnuPR.Shortcut = Keys.Control Or Keys.P
		'
		' mnuV
		'
		Me.mnuV.Name = "mnuV"
		Me.mnuV.Caption = "&View"
		'
		' mnuTAP
		'
		Me.mnuTAP.Name = "mnuTAP"
		Me.mnuTAP.Caption = "Toolbar Align &Top   "
		'
		' mnuTAB
		'
		Me.mnuTAB.Name = "mnuTAB"
		Me.mnuTAB.Caption = "Toolbar Align &Buttom"
		'
		' mnuTAL
		'
		Me.mnuTAL.Name = "mnuTAL"
		Me.mnuTAL.Caption = "Toolbar Align &Left"
		'
		' mnuTAR
		'
		Me.mnuTAR.Name = "mnuTAR"
		Me.mnuTAR.Caption = "Toolbar Align &Right"
		'
		' sep4
		'
		Me.sep4.Name = "sep4"
		'
		' mnuHSM
		'
		Me.mnuHSM.Name = "mnuHSM"
		Me.mnuHSM.Caption = "Hide/Show Shortcut Menu"
		'
		' mnuHSS
		'
		Me.mnuHSS.Name = "mnuHSS"
		Me.mnuHSS.Caption = "Hide/Show Statusbar"
		'
		' mnuT
		'
		Me.mnuT.Name = "mnuT"
		Me.mnuT.Caption = "Tools"
		'
		' mnuCalc
		'
		Me.mnuCalc.Name = "mnuCalc"
		Me.mnuCalc.Caption = "C&alculator"
		Me.mnuCalc.Shortcut = Keys.Control Or Keys.C
		'
		' mnuNP
		'
		Me.mnuNP.Name = "mnuNP"
		Me.mnuNP.Caption = "&Notepad"
		Me.mnuNP.Shortcut = Keys.Control Or Keys.D
		'
		' sep6
		'
		Me.sep6.Name = "sep6"
		'
		' mnuCalen
		'
		Me.mnuCalen.Name = "mnuCalen"
		Me.mnuCalen.Caption = "&Calendar"
		Me.mnuCalen.Shortcut = Keys.Control Or Keys.E
		'
		' mnuW
		'
		Me.mnuW.Name = "mnuW"
		Me.mnuW.Caption = "&Window"
		'
		' mnuTH
		'
		Me.mnuTH.Name = "mnuTH"
		Me.mnuTH.Caption = "Tile &Horizontally"
		'
		' mnuTV
		'
		Me.mnuTV.Name = "mnuTV"
		Me.mnuTV.Caption = "Tile Vertically"
		'
		' mnuC
		'
		Me.mnuC.Name = "mnuC"
		Me.mnuC.Caption = "&Cascade"
		'
		' mnuAI
		'
		Me.mnuAI.Name = "mnuAI"
		Me.mnuAI.Caption = "&Arrage Icons"
		'
		' sep3
		'
		Me.sep3.Name = "sep3"
		'
		' winlist
		'
		Me.winlist.Name = "winlist"
		Me.winlist.Caption = "Forms >>"
		'
		' mnuHLP
		'
		Me.mnuHLP.Name = "mnuHLP"
		Me.mnuHLP.Caption = "Help"
		'
		' mnuAbt
		'
		Me.mnuAbt.Name = "mnuAbt"
		Me.mnuAbt.Caption = "About?     "
		Me.mnuAbt.Shortcut = Keys.Control Or Keys.A
		'
		' Toolbar1_Control
		'
		Me.Toolbar1_Control.Name = "Toolbar1_Control"
		Me.Toolbar1_Control.Size = New System.Drawing.Size(533, 22)
		Me.Toolbar1_Control.Location = New System.Drawing.Point(0, 26)
		Me.Toolbar1_Control.TabIndex = 0
		Me.Toolbar1_Control.AllowItemReorder = False
		Me.Toolbar1_Control.ImageList = ImageList1.ImageList
		Me.Toolbar1_Control.Dock = System.Windows.Forms.DockStyle.Top
		'
		' Toolbar1_Button1
		'
		Me.Toolbar1_Button1.Name = "Toolbar1_Button1"
		Me.Toolbar1_Button1.Tag = "Style=3;"
		Me.Toolbar1_Button1.Width = 7
		Me.Toolbar1_Button1.Height = 22
		Me.Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button1.AutoSize = False
		'
		' Toolbar1_Button2
		'
		Me.Toolbar1_Button2.Name = "Toolbar1_Button2"
		Me.Toolbar1_Button2.Tag = "Style=3;"
		Me.Toolbar1_Button2.Width = 7
		Me.Toolbar1_Button2.Height = 22
		Me.Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button2.AutoSize = False
		'
		' Toolbar1_Button3
		'
		Me.Toolbar1_Button3.Name = "Toolbar1_Button3"
		Me.Toolbar1_Button3.ImageIndex = 0
		Me.Toolbar1_Button3.Width = 23
		Me.Toolbar1_Button3.Height = 22
		Me.Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button3.AutoSize = False
		Me.Toolbar1_Button3.ToolTipText = "Modify Student Record"
		'
		' Toolbar1_Button4
		'
		Me.Toolbar1_Button4.Name = "Toolbar1_Button4"
		Me.Toolbar1_Button4.ImageIndex = 1
		Me.Toolbar1_Button4.Width = 23
		Me.Toolbar1_Button4.Height = 22
		Me.Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button4.AutoSize = False
		Me.Toolbar1_Button4.ToolTipText = "Sections"
		'
		' Toolbar1_Button5
		'
		Me.Toolbar1_Button5.Name = "Toolbar1_Button5"
		Me.Toolbar1_Button5.ImageIndex = 2
		Me.Toolbar1_Button5.Width = 23
		Me.Toolbar1_Button5.Height = 22
		Me.Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button5.AutoSize = False
		Me.Toolbar1_Button5.ToolTipText = "Level"
		'
		' Toolbar1_Button6
		'
		Me.Toolbar1_Button6.Name = "Toolbar1_Button6"
		Me.Toolbar1_Button6.ImageIndex = 3
		Me.Toolbar1_Button6.Width = 23
		Me.Toolbar1_Button6.Height = 22
		Me.Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button6.AutoSize = False
		Me.Toolbar1_Button6.ToolTipText = "Modify School Year"
		'
		' Toolbar1_Button7
		'
		Me.Toolbar1_Button7.Name = "Toolbar1_Button7"
		Me.Toolbar1_Button7.Tag = "Style=3;"
		Me.Toolbar1_Button7.Width = 7
		Me.Toolbar1_Button7.Height = 22
		Me.Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button7.AutoSize = False
		'
		' Toolbar1_Button8
		'
		Me.Toolbar1_Button8.Name = "Toolbar1_Button8"
		Me.Toolbar1_Button8.ImageIndex = 4
		Me.Toolbar1_Button8.Width = 23
		Me.Toolbar1_Button8.Height = 22
		Me.Toolbar1_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button8.AutoSize = False
		Me.Toolbar1_Button8.ToolTipText = "Make Registration Slip"
		'
		' Toolbar1_Button9
		'
		Me.Toolbar1_Button9.Name = "Toolbar1_Button9"
		Me.Toolbar1_Button9.ImageIndex = 5
		Me.Toolbar1_Button9.Width = 23
		Me.Toolbar1_Button9.Height = 22
		Me.Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button9.AutoSize = False
		Me.Toolbar1_Button9.ToolTipText = "Individual Reports"
		'
		' Toolbar1_Button10
		'
		Me.Toolbar1_Button10.Name = "Toolbar1_Button10"
		Me.Toolbar1_Button10.ImageIndex = 6
		Me.Toolbar1_Button10.Width = 23
		Me.Toolbar1_Button10.Height = 22
		Me.Toolbar1_Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button10.AutoSize = False
		Me.Toolbar1_Button10.ToolTipText = "Students Per Section"
		'
		' Toolbar1_Button11
		'
		Me.Toolbar1_Button11.Name = "Toolbar1_Button11"
		Me.Toolbar1_Button11.ImageIndex = 7
		Me.Toolbar1_Button11.Width = 23
		Me.Toolbar1_Button11.Height = 22
		Me.Toolbar1_Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button11.AutoSize = False
		Me.Toolbar1_Button11.ToolTipText = "Student List"
		'
		' Toolbar1_Button12
		'
		Me.Toolbar1_Button12.Name = "Toolbar1_Button12"
		Me.Toolbar1_Button12.ImageIndex = 8
		Me.Toolbar1_Button12.Width = 23
		Me.Toolbar1_Button12.Height = 22
		Me.Toolbar1_Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button12.AutoSize = False
		Me.Toolbar1_Button12.ToolTipText = "Population Report"
		'
		' Toolbar1_Button13
		'
		Me.Toolbar1_Button13.Name = "Toolbar1_Button13"
		Me.Toolbar1_Button13.Tag = "Style=3;"
		Me.Toolbar1_Button13.Width = 7
		Me.Toolbar1_Button13.Height = 22
		Me.Toolbar1_Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button13.AutoSize = False
		'
		' Toolbar1_Button14
		'
		Me.Toolbar1_Button14.Name = "Toolbar1_Button14"
		Me.Toolbar1_Button14.ImageIndex = 9
		Me.Toolbar1_Button14.Width = 23
		Me.Toolbar1_Button14.Height = 22
		Me.Toolbar1_Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button14.AutoSize = False
		Me.Toolbar1_Button14.ToolTipText = "Calculator"
		'
		' Toolbar1_Button15
		'
		Me.Toolbar1_Button15.Name = "Toolbar1_Button15"
		Me.Toolbar1_Button15.ImageIndex = 10
		Me.Toolbar1_Button15.Width = 23
		Me.Toolbar1_Button15.Height = 22
		Me.Toolbar1_Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button15.AutoSize = False
		Me.Toolbar1_Button15.ToolTipText = "Notepad"
		'
		' Toolbar1_Button16
		'
		Me.Toolbar1_Button16.Name = "Toolbar1_Button16"
		Me.Toolbar1_Button16.ImageIndex = 11
		Me.Toolbar1_Button16.Width = 23
		Me.Toolbar1_Button16.Height = 22
		Me.Toolbar1_Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button16.AutoSize = False
		Me.Toolbar1_Button16.ToolTipText = "Calendar"
		'
		' Toolbar1_Button17
		'
		Me.Toolbar1_Button17.Name = "Toolbar1_Button17"
		Me.Toolbar1_Button17.Tag = "Style=3;"
		Me.Toolbar1_Button17.Width = 7
		Me.Toolbar1_Button17.Height = 22
		Me.Toolbar1_Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button17.AutoSize = False
		'
		' Toolbar1_Button18
		'
		Me.Toolbar1_Button18.Name = "Toolbar1_Button18"
		Me.Toolbar1_Button18.ImageIndex = 13
		Me.Toolbar1_Button18.Width = 23
		Me.Toolbar1_Button18.Height = 22
		Me.Toolbar1_Button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.Toolbar1_Button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Toolbar1_Button18.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.Toolbar1_Button18.AutoSize = False
		Me.Toolbar1_Button18.ToolTipText = "About?"
		'
		' StatusBar1_Control
		'
		Me.StatusBar1_Control.Name = "StatusBar1_Control"
		Me.StatusBar1_Control.Size = New System.Drawing.Size(533, 19)
		Me.StatusBar1_Control.Location = New System.Drawing.Point(0, 476)
		Me.StatusBar1_Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusBar1_Control.TabIndex = 5
		Me.StatusBar1_Control.ShowItemToolTips = True
		Me.StatusBar1_Control.Dock = System.Windows.Forms.DockStyle.Bottom
		'
		' StatusBar1_Panel1
		'
		Me.StatusBar1_Panel1.Name = "StatusBar1_Panel1"
		Me.StatusBar1_Panel1.Image = CType(resources.GetObject("StatusBar1_Panel1.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel1.AutoSize = False
		Me.StatusBar1_Panel1.Size = New System.Drawing.Size(17, 14)
		Me.StatusBar1_Panel1.DoubleClickEnabled = True
		Me.StatusBar1_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel2
		'
		Me.StatusBar1_Panel2.Name = "StatusBar1_Panel2"
		Me.StatusBar1_Panel2.Text = "User Name:"
		Me.StatusBar1_Panel2.AutoSize = False
		Me.StatusBar1_Panel2.Size = New System.Drawing.Size(60, 14)
		Me.StatusBar1_Panel2.DoubleClickEnabled = True
		Me.StatusBar1_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel3
		'
		Me.StatusBar1_Panel3.Name = "StatusBar1_Panel3"
		Me.StatusBar1_Panel3.AutoSize = False
		Me.StatusBar1_Panel3.Size = New System.Drawing.Size(167, 14)
		Me.StatusBar1_Panel3.DoubleClickEnabled = True
		Me.StatusBar1_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel4
		'
		Me.StatusBar1_Panel4.Name = "StatusBar1_Panel4"
		Me.StatusBar1_Panel4.Image = CType(resources.GetObject("StatusBar1_Panel4.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel4.AutoSize = False
		Me.StatusBar1_Panel4.Size = New System.Drawing.Size(17, 14)
		Me.StatusBar1_Panel4.DoubleClickEnabled = True
		Me.StatusBar1_Panel4.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel5
		'
		Me.StatusBar1_Panel5.Name = "StatusBar1_Panel5"
		Me.StatusBar1_Panel5.Text = "Time Log-in:"
		Me.StatusBar1_Panel5.AutoSize = False
		Me.StatusBar1_Panel5.Size = New System.Drawing.Size(67, 14)
		Me.StatusBar1_Panel5.DoubleClickEnabled = True
		Me.StatusBar1_Panel5.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel6
		'
		Me.StatusBar1_Panel6.Name = "StatusBar1_Panel6"
		Me.StatusBar1_Panel6.AutoSize = False
		Me.StatusBar1_Panel6.Size = New System.Drawing.Size(123, 14)
		Me.StatusBar1_Panel6.DoubleClickEnabled = True
		Me.StatusBar1_Panel6.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel6.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel7
		'
		Me.StatusBar1_Panel7.Name = "StatusBar1_Panel7"
		Me.StatusBar1_Panel7.Image = CType(resources.GetObject("StatusBar1_Panel7.Image"), System.Drawing.Image)
		Me.StatusBar1_Panel7.AutoSize = False
		Me.StatusBar1_Panel7.Size = New System.Drawing.Size(20, 14)
		Me.StatusBar1_Panel7.DoubleClickEnabled = True
		Me.StatusBar1_Panel7.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel8
		'
		Me.StatusBar1_Panel8.Name = "StatusBar1_Panel8"
		Me.StatusBar1_Panel8.Text = "Date:"
		Me.StatusBar1_Panel8.AutoSize = False
		Me.StatusBar1_Panel8.Size = New System.Drawing.Size(40, 14)
		Me.StatusBar1_Panel8.DoubleClickEnabled = True
		Me.StatusBar1_Panel8.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
		Me.StatusBar1_Panel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' StatusBar1_Panel9
		'
		Me.StatusBar1_Panel9.Name = "StatusBar1_Panel9"
		Me.StatusBar1_Panel9.Tag = "Style=6;"
		Me.StatusBar1_Panel9.AutoSize = False
		Me.StatusBar1_Panel9.Size = New System.Drawing.Size(98, 14)
		Me.StatusBar1_Panel9.DoubleClickEnabled = True
		Me.StatusBar1_Panel9.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me.StatusBar1_Panel9.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.StatusBar1_Panel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.StatusBar1_Panel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		' MDIForm1
		'
		Me.Name = "MDIForm1"
		Me.BackColor = FromOleColor6(CInt(&H8000000C))
		Me.Caption = "Computerize School Registration Software version 1"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.WindowState = CodeArchitects.VB6Library.VBRUN.FormWindowStateConstants.vbMaximized
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(15, 55)
		Me.ClientSize = New System.Drawing.Size(533, 471)

		Me.Controls.Add(Picture4)
		Me.Controls.Add(Picture3)
		Me.Controls.Add(Picture2)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Toolbar1)
		Me.Controls.Add(StatusBar1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(mnuF)
		Me.mnuF.DropDownItems.Add(mnuMSR)
		Me.mnuF.DropDownItems.Add(mnuS)
		Me.mnuF.DropDownItems.Add(mnuL)
		Me.mnuF.DropDownItems.Add(mnuMSY)
		Me.mnuF.DropDownItems.Add(sep5)
		Me.mnuF.DropDownItems.Add(mnuAO)
		Me.mnuF.DropDownItems.Add(sep10)
		Me.mnuF.DropDownItems.Add(mnuE)
		Me.MenuStrip1.Items.Add(mnuR)
		Me.mnuR.DropDownItems.Add(mnuMRS)
		Me.mnuR.DropDownItems.Add(mnuIR)
		Me.mnuR.DropDownItems.Add(mnuSPS)
		Me.mnuR.DropDownItems.Add(sep8)
		Me.mnuR.DropDownItems.Add(mnuSL)
		Me.mnuR.DropDownItems.Add(sep7)
		Me.mnuR.DropDownItems.Add(mnuPR)
		Me.MenuStrip1.Items.Add(mnuV)
		Me.mnuV.DropDownItems.Add(mnuTAP)
		Me.mnuV.DropDownItems.Add(mnuTAB)
		Me.mnuV.DropDownItems.Add(mnuTAL)
		Me.mnuV.DropDownItems.Add(mnuTAR)
		Me.mnuV.DropDownItems.Add(sep4)
		Me.mnuV.DropDownItems.Add(mnuHSM)
		Me.mnuV.DropDownItems.Add(mnuHSS)
		Me.MenuStrip1.Items.Add(mnuT)
		Me.mnuT.DropDownItems.Add(mnuCalc)
		Me.mnuT.DropDownItems.Add(mnuNP)
		Me.mnuT.DropDownItems.Add(sep6)
		Me.mnuT.DropDownItems.Add(mnuCalen)
		Me.MenuStrip1.Items.Add(mnuW)
		Me.mnuW.DropDownItems.Add(mnuTH)
		Me.mnuW.DropDownItems.Add(mnuTV)
		Me.mnuW.DropDownItems.Add(mnuC)
		Me.mnuW.DropDownItems.Add(mnuAI)
		Me.mnuW.DropDownItems.Add(sep3)
		Me.mnuW.DropDownItems.Add(winlist)
		Me.MenuStrip1.Items.Add(mnuHLP)
		Me.mnuHLP.DropDownItems.Add(mnuAbt)
		Me.Controls.Add(Toolbar1_Control)
		Me.Controls.Add(StatusBar1_Control)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		Me.Controls.SetChildIndex(Me.Toolbar1, 0)
		Me.Controls.SetChildIndex(Me.Toolbar1_Control, 0)
		Me.Controls.SetChildIndex(Me.Picture1, 0)
		Me.Controls.SetChildIndex(Me.Picture3, 0)
		Me.Controls.SetChildIndex(Me.StatusBar1, 0)
		Me.Controls.SetChildIndex(Me.Picture2, 0)
		Me.Controls.SetChildIndex(Me.Picture4, 0)
		CType(Me.Toolbar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
