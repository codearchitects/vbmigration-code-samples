<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Player
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
	Public WithEvents Picvol As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Lblvol As CodeArchitects.VB6Library.VB6Label
	Public WithEvents VOL As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImgPlus As CodeArchitects.VB6Library.VB6Image
	Public WithEvents ImgMin As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Ticker As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents BR As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImgBR As CodeArchitects.VB6Library.VB6Image
	Public WithEvents PL As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImgPL As CodeArchitects.VB6Library.VB6Image
	Public WithEvents PicBRSkin As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents PicPlSkin As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents picPauseSkin As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents picPlaySkin As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Pause As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents ImgPause As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image2 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents play As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents Imgprpus As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Imgpus As CodeArchitects.VB6Library.VB6Image
	Public WithEvents ImgPlay As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Minimize As CodeArchitects.VB6Library.VB6Image
	Public WithEvents LblTime As CodeArchitects.VB6Library.VB6Label
	Public WithEvents slider2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents slider1 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Close_Renamed As CodeArchitects.VB6Library.VB6Image
	Public WithEvents Image1 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents MenuStrip1 As CodeArchitects.VB6Library.VB6MainMenu
	Public WithEvents Mainmenu As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuBR As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuClose As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuSep0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuPlay As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuStop As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuInfo As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Mnusep1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuShowPL As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents MnuOntop As CodeArchitects.VB6Library.VB6Menu
	Public WithEvents Mnusep2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuAbout As CodeArchitects.VB6Library.VB6Menu

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Player))
		Me.Picvol = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Lblvol = New CodeArchitects.VB6Library.VB6Label()
		Me.VOL = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImgPlus = New CodeArchitects.VB6Library.VB6Image()
		Me.ImgMin = New CodeArchitects.VB6Library.VB6Image()
		Me.Ticker = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.BR = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImgBR = New CodeArchitects.VB6Library.VB6Image()
		Me.PL = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImgPL = New CodeArchitects.VB6Library.VB6Image()
		Me.PicBRSkin = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.PicPlSkin = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.picPauseSkin = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.picPlaySkin = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Pause = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.ImgPause = New CodeArchitects.VB6Library.VB6Image()
		Me.Image2 = New CodeArchitects.VB6Library.VB6Image()
		Me.play = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.Imgprpus = New CodeArchitects.VB6Library.VB6Image()
		Me.Imgpus = New CodeArchitects.VB6Library.VB6Image()
		Me.ImgPlay = New CodeArchitects.VB6Library.VB6Image()
		Me.Minimize = New CodeArchitects.VB6Library.VB6Image()
		Me.LblTime = New CodeArchitects.VB6Library.VB6Label()
		Me.slider2 = New CodeArchitects.VB6Library.VB6Label()
		Me.slider1 = New CodeArchitects.VB6Library.VB6Label()
		Me.Close_Renamed = New CodeArchitects.VB6Library.VB6Image()
		Me.Image1 = New CodeArchitects.VB6Library.VB6Image()
		Me.MenuStrip1 = New CodeArchitects.VB6Library.VB6MainMenu()
		Me.Mainmenu = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuBR = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuClose = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuSep0 = New System.Windows.Forms.ToolStripSeparator()
		Me.MnuPlay = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuStop = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuInfo = New CodeArchitects.VB6Library.VB6Menu()
		Me.Mnusep1 = New System.Windows.Forms.ToolStripSeparator()
		Me.MnuShowPL = New CodeArchitects.VB6Library.VB6Menu()
		Me.MnuOntop = New CodeArchitects.VB6Library.VB6Menu()
		Me.Mnusep2 = New System.Windows.Forms.ToolStripSeparator()
		Me.MnuAbout = New CodeArchitects.VB6Library.VB6Menu()
		Me.Picvol.SuspendLayout()
		Me.VOL.SuspendLayout()
		Me.Ticker.SuspendLayout()
		Me.BR.SuspendLayout()
		Me.PL.SuspendLayout()
		Me.Pause.SuspendLayout()
		Me.play.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.ImgPlus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgMin, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgBR, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgPL, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgPause, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Imgprpus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Imgpus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImgPlay, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Minimize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Close_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Picvol
		'
		Me.Picvol.Name = "Picvol"
		Me.Picvol.Size = New System.Drawing.Size(112, 7)
		Me.Picvol.Location = New System.Drawing.Point(108, 155)
		Me.Picvol.BackColor = FromOleColor6(CInt(&H00404040))
		Me.Picvol.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Picvol.TabIndex = 15
		Me.ToolTip1.SetToolTip(Me.Picvol, "Set volume")
		Me.Picvol.Visible = False
		Me.Picvol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Picvol.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' Lblvol
		'
		Me.Lblvol.Name = "Lblvol"
		Me.Lblvol.Size = New System.Drawing.Size(6, 7)
		Me.Lblvol.Location = New System.Drawing.Point(55, 0)
		Me.Lblvol.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.Lblvol.Enabled = False
		Me.Lblvol.TabIndex = 16
		Me.Lblvol.AutoSize = False
		'
		' VOL
		'
		Me.VOL.Name = "VOL"
		Me.VOL.Size = New System.Drawing.Size(17, 16)
		Me.VOL.Location = New System.Drawing.Point(87, 152)
		Me.VOL.AutoSize = True
		Me.VOL.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.VOL.Picture = CType(resources.GetObject("VOL.Picture"), System.Drawing.Image)
		Me.VOL.TabIndex = 14
		Me.ToolTip1.SetToolTip(Me.VOL, "Volume")
		Me.VOL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.VOL.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.VOL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ImgPlus
		'
		Me.ImgPlus.Name = "ImgPlus"
		Me.ImgPlus.Size = New System.Drawing.Size(8, 16)
		Me.ImgPlus.Location = New System.Drawing.Point(0, 0)
		Me.ImgPlus.Enabled = False
		Me.ImgPlus.Visible = False
		Me.ImgPlus.Picture = CType(resources.GetObject("ImgPlus.Picture"), System.Drawing.Image)
		Me.ImgPlus.Stretch = False
		'
		' ImgMin
		'
		Me.ImgMin.Name = "ImgMin"
		Me.ImgMin.Size = New System.Drawing.Size(9, 16)
		Me.ImgMin.Location = New System.Drawing.Point(8, 0)
		Me.ImgMin.Enabled = False
		Me.ImgMin.Visible = False
		Me.ImgMin.Picture = CType(resources.GetObject("ImgMin.Picture"), System.Drawing.Image)
		Me.ImgMin.Stretch = False
		'
		' Ticker
		'
		Me.Ticker.Name = "Ticker"
		Me.Ticker.Size = New System.Drawing.Size(101, 23)
		Me.Ticker.Location = New System.Drawing.Point(35, 101)
		Me.Ticker.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Ticker.Enabled = False
		Me.Ticker.Picture = CType(resources.GetObject("Ticker.Picture"), System.Drawing.Image)
		Me.Ticker.TabIndex = 8
		Me.Ticker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Ticker.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Ticker.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(78, 16)
		Me.Label1.Location = New System.Drawing.Point(2, 7)
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label1.Caption = "No file loaded"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00404040))
		Me.Label1.TabIndex = 10
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(108, 16)
		Me.Label2.Location = New System.Drawing.Point(15, 30)
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label2.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.Label2.Caption = "BBBBBBBBBBBB"
		Me.Label2.ForeColor = FromOleColor6(CInt(&H00404040))
		Me.Label2.TabIndex = 9
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 250
		'
		' BR
		'
		Me.BR.Name = "BR"
		Me.BR.Size = New System.Drawing.Size(28, 29)
		Me.BR.Location = New System.Drawing.Point(193, 167)
		Me.BR.AutoSize = True
		Me.BR.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.BR.Picture = CType(resources.GetObject("BR.Picture"), System.Drawing.Image)
		Me.BR.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.BR, "Open file")
		Me.BR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BR.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BR.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ImgBR
		'
		Me.ImgBR.Name = "ImgBR"
		Me.ImgBR.Size = New System.Drawing.Size(26, 34)
		Me.ImgBR.Location = New System.Drawing.Point(1, -2)
		Me.ImgBR.Enabled = False
		Me.ImgBR.Visible = False
		Me.ImgBR.Picture = CType(resources.GetObject("ImgBR.Picture"), System.Drawing.Image)
		Me.ImgBR.Stretch = False
		'
		' PL
		'
		Me.PL.Name = "PL"
		Me.PL.Size = New System.Drawing.Size(28, 29)
		Me.PL.Location = New System.Drawing.Point(168, 167)
		Me.PL.AutoSize = True
		Me.PL.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.PL.Picture = CType(resources.GetObject("PL.Picture"), System.Drawing.Image)
		Me.PL.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.PL, "Show\Hide Playlist")
		Me.PL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PL.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.PL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ImgPL
		'
		Me.ImgPL.Name = "ImgPL"
		Me.ImgPL.Size = New System.Drawing.Size(26, 32)
		Me.ImgPL.Location = New System.Drawing.Point(1, -1)
		Me.ImgPL.Enabled = False
		Me.ImgPL.Visible = False
		Me.ImgPL.Picture = CType(resources.GetObject("ImgPL.Picture"), System.Drawing.Image)
		Me.ImgPL.Stretch = False
		'
		' PicBRSkin
		'
		Me.PicBRSkin.Name = "PicBRSkin"
		Me.PicBRSkin.Size = New System.Drawing.Size(28, 29)
		Me.PicBRSkin.Location = New System.Drawing.Point(277, 472)
		Me.PicBRSkin.AutoRedraw = True
		Me.PicBRSkin.AutoSize = True
		Me.PicBRSkin.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.PicBRSkin.Picture = CType(resources.GetObject("PicBRSkin.Picture"), System.Drawing.Image)
		Me.PicBRSkin.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.PicBRSkin.TabIndex = 5
		Me.PicBRSkin.Visible = False
		Me.PicBRSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PicBRSkin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.PicBRSkin.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' PicPlSkin
		'
		Me.PicPlSkin.Name = "PicPlSkin"
		Me.PicPlSkin.Size = New System.Drawing.Size(28, 29)
		Me.PicPlSkin.Location = New System.Drawing.Point(242, 470)
		Me.PicPlSkin.AutoRedraw = True
		Me.PicPlSkin.AutoSize = True
		Me.PicPlSkin.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.PicPlSkin.Picture = CType(resources.GetObject("PicPlSkin.Picture"), System.Drawing.Image)
		Me.PicPlSkin.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.PicPlSkin.TabIndex = 4
		Me.PicPlSkin.Visible = False
		Me.PicPlSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PicPlSkin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.PicPlSkin.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picPauseSkin
		'
		Me.picPauseSkin.Name = "picPauseSkin"
		Me.picPauseSkin.Size = New System.Drawing.Size(55, 57)
		Me.picPauseSkin.Location = New System.Drawing.Point(150, 458)
		Me.picPauseSkin.AutoSize = True
		Me.picPauseSkin.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picPauseSkin.Picture = CType(resources.GetObject("picPauseSkin.Picture"), System.Drawing.Image)
		Me.picPauseSkin.TabIndex = 3
		Me.picPauseSkin.Visible = False
		Me.picPauseSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picPauseSkin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picPauseSkin.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picPlaySkin
		'
		Me.picPlaySkin.Name = "picPlaySkin"
		Me.picPlaySkin.Size = New System.Drawing.Size(68, 64)
		Me.picPlaySkin.Location = New System.Drawing.Point(73, 453)
		Me.picPlaySkin.AutoSize = True
		Me.picPlaySkin.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picPlaySkin.Picture = CType(resources.GetObject("picPlaySkin.Picture"), System.Drawing.Image)
		Me.picPlaySkin.TabIndex = 2
		Me.picPlaySkin.Visible = False
		Me.picPlaySkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picPlaySkin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picPlaySkin.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Pause
		'
		Me.Pause.Name = "Pause"
		Me.Pause.Size = New System.Drawing.Size(57, 60)
		Me.Pause.Location = New System.Drawing.Point(306, 101)
		Me.Pause.AutoSize = True
		Me.Pause.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.Pause.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.Pause, "Stop")
		Me.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Pause.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.Pause.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' ImgPause
		'
		Me.ImgPause.Name = "ImgPause"
		Me.ImgPause.Size = New System.Drawing.Size(27, 59)
		Me.ImgPause.Location = New System.Drawing.Point(14, -2)
		Me.ImgPause.Enabled = False
		Me.ImgPause.Visible = False
		Me.ImgPause.Picture = CType(resources.GetObject("ImgPause.Picture"), System.Drawing.Image)
		Me.ImgPause.Stretch = False
		'
		' Image2
		'
		Me.Image2.Name = "Image2"
		Me.Image2.Size = New System.Drawing.Size(62, 63)
		Me.Image2.Location = New System.Drawing.Point(-5, -3)
		Me.Image2.Enabled = False
		Me.Image2.Picture = CType(resources.GetObject("Image2.Picture"), System.Drawing.Image)
		Me.Image2.Stretch = False
		'
		' play
		'
		Me.play.Name = "play"
		Me.play.Size = New System.Drawing.Size(70, 66)
		Me.play.Location = New System.Drawing.Point(244, 99)
		Me.play.AutoSize = True
		Me.play.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.play.Picture = CType(resources.GetObject("play.Picture"), System.Drawing.Image)
		Me.play.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.play, "Play")
		Me.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.play.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.play.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' Imgprpus
		'
		Me.Imgprpus.Name = "Imgprpus"
		Me.Imgprpus.Size = New System.Drawing.Size(36, 65)
		Me.Imgprpus.Location = New System.Drawing.Point(16, 1)
		Me.Imgprpus.Enabled = False
		Me.Imgprpus.Visible = False
		Me.Imgprpus.Picture = CType(resources.GetObject("Imgprpus.Picture"), System.Drawing.Image)
		Me.Imgprpus.Stretch = False
		'
		' Imgpus
		'
		Me.Imgpus.Name = "Imgpus"
		Me.Imgpus.Size = New System.Drawing.Size(32, 67)
		Me.Imgpus.Location = New System.Drawing.Point(18, 0)
		Me.Imgpus.Enabled = False
		Me.Imgpus.Visible = False
		Me.Imgpus.Picture = CType(resources.GetObject("Imgpus.Picture"), System.Drawing.Image)
		Me.Imgpus.Stretch = False
		'
		' ImgPlay
		'
		Me.ImgPlay.Name = "ImgPlay"
		Me.ImgPlay.Size = New System.Drawing.Size(34, 70)
		Me.ImgPlay.Location = New System.Drawing.Point(19, 1)
		Me.ImgPlay.Enabled = False
		Me.ImgPlay.Visible = False
		Me.ImgPlay.Picture = CType(resources.GetObject("ImgPlay.Picture"), System.Drawing.Image)
		Me.ImgPlay.Stretch = False
		'
		' Minimize
		'
		Me.Minimize.Name = "Minimize"
		Me.Minimize.Size = New System.Drawing.Size(8, 7)
		Me.Minimize.Location = New System.Drawing.Point(206, 35)
		Me.ToolTip1.SetToolTip(Me.Minimize, "Minimize")
		Me.Minimize.Picture = CType(resources.GetObject("Minimize.Picture"), System.Drawing.Image)
		Me.Minimize.Stretch = False
		'
		' LblTime
		'
		Me.LblTime.Name = "LblTime"
		Me.LblTime.Size = New System.Drawing.Size(36, 18)
		Me.LblTime.Location = New System.Drawing.Point(36, 107)
		Me.LblTime.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
		Me.LblTime.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.LblTime.BackColor = FromOleColor6(CInt(&H00000000))
		Me.LblTime.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.LblTime.ForeColor = FromOleColor6(CInt(&H00404040))
		Me.LblTime.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.LblTime.TabIndex = 13
		Me.LblTime.AutoSize = False
		'
		' slider2
		'
		Me.slider2.Name = "slider2"
		Me.slider2.Size = New System.Drawing.Size(112, 7)
		Me.slider2.Location = New System.Drawing.Point(108, 155)
		Me.slider2.BackColor = FromOleColor6(CInt(&H00808080))
		Me.slider2.Enabled = False
		Me.slider2.TabIndex = 12
		Me.slider2.Visible = False
		Me.slider2.AutoSize = False
		'
		' slider1
		'
		Me.slider1.Name = "slider1"
		Me.slider1.Size = New System.Drawing.Size(112, 7)
		Me.slider1.Location = New System.Drawing.Point(108, 155)
		Me.slider1.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.slider1.TabIndex = 11
		Me.ToolTip1.SetToolTip(Me.slider1, "Seek the file")
		Me.slider1.Visible = False
		Me.slider1.AutoSize = False
		'
		' Close_Renamed
		'
		Me.Close_Renamed.Name = "Close_Renamed"
		Me.Close_Renamed.Size = New System.Drawing.Size(9, 9)
		Me.Close_Renamed.Location = New System.Drawing.Point(196, 34)
		Me.ToolTip1.SetToolTip(Me.Close_Renamed, "Close")
		Me.Close_Renamed.Stretch = False
		'
		' Image1
		'
		Me.Image1.Name = "Image1"
		Me.Image1.Size = New System.Drawing.Size(385, 197)
		Me.Image1.Location = New System.Drawing.Point(-5, 21)
		Me.Image1.Enabled = False
		Me.Image1.Picture = CType(resources.GetObject("Image1.Picture"), System.Drawing.Image)
		Me.Image1.Stretch = False
		'
		' MenuStrip1
		'
		Me.MenuStrip1.Name = "MenuStrip1"
		'
		' Mainmenu
		'
		Me.Mainmenu.Name = "Mainmenu"
		Me.Mainmenu.Caption = "Main"
		Me.Mainmenu.Visible = False
		'
		' MnuBR
		'
		Me.MnuBR.Name = "MnuBR"
		Me.MnuBR.Caption = "&Open..."
		'
		' MnuClose
		'
		Me.MnuClose.Name = "MnuClose"
		Me.MnuClose.Caption = "C&lose"
		'
		' MnuSep0
		'
		Me.MnuSep0.Name = "MnuSep0"
		'
		' MnuPlay
		'
		Me.MnuPlay.Name = "MnuPlay"
		Me.MnuPlay.Caption = "&Play"
		Me.MnuPlay.Enabled = False
		'
		' MnuStop
		'
		Me.MnuStop.Name = "MnuStop"
		Me.MnuStop.Caption = "&Stop"
		Me.MnuStop.Enabled = False
		'
		' MnuInfo
		'
		Me.MnuInfo.Name = "MnuInfo"
		Me.MnuInfo.Caption = "MP3 &Info..."
		'
		' Mnusep1
		'
		Me.Mnusep1.Name = "Mnusep1"
		'
		' MnuShowPL
		'
		Me.MnuShowPL.Name = "MnuShowPL"
		Me.MnuShowPL.Caption = "Show Playlist"
		'
		' MnuOntop
		'
		Me.MnuOntop.Name = "MnuOntop"
		Me.MnuOntop.Caption = "Player on-top"
		Me.MnuOntop.Checked = True
		'
		' Mnusep2
		'
		Me.Mnusep2.Name = "Mnusep2"
		'
		' MnuAbout
		'
		Me.MnuAbout.Name = "MnuAbout"
		Me.MnuAbout.Caption = "About"
		'
		' Player
		'
		Me.Name = "Player"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00FF8080))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "E-MP3 Player"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.OLEDropMode = CodeArchitects.VB6Library.VBRUN.OLEDropConstants.vbOLEDropManual
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ClientSize = New System.Drawing.Size(380, 539)

		Me.Controls.Add(Picvol)
		Me.Picvol.Controls.Add(Lblvol)
		Me.Controls.Add(VOL)
		Me.VOL.Controls.Add(ImgPlus)
		Me.VOL.Controls.Add(ImgMin)
		Me.Controls.Add(Ticker)
		Me.Ticker.Controls.Add(Label1)
		Me.Ticker.Controls.Add(Label2)
		Me.Controls.Add(BR)
		Me.BR.Controls.Add(ImgBR)
		Me.Controls.Add(PL)
		Me.PL.Controls.Add(ImgPL)
		Me.Controls.Add(PicBRSkin)
		Me.Controls.Add(PicPlSkin)
		Me.Controls.Add(picPauseSkin)
		Me.Controls.Add(picPlaySkin)
		Me.Controls.Add(Pause)
		Me.Pause.Controls.Add(ImgPause)
		Me.Pause.Controls.Add(Image2)
		Me.Controls.Add(play)
		Me.play.Controls.Add(Imgprpus)
		Me.play.Controls.Add(Imgpus)
		Me.play.Controls.Add(ImgPlay)
		Me.Controls.Add(Minimize)
		Me.Controls.Add(LblTime)
		Me.Controls.Add(slider2)
		Me.Controls.Add(slider1)
		Me.Controls.Add(Close_Renamed)
		Me.Controls.Add(Image1)
		Me.Controls.Add(MenuStrip1)
		Me.MenuStrip1.Items.Add(Mainmenu)
		Me.Mainmenu.DropDownItems.Add(MnuBR)
		Me.Mainmenu.DropDownItems.Add(MnuClose)
		Me.Mainmenu.DropDownItems.Add(MnuSep0)
		Me.Mainmenu.DropDownItems.Add(MnuPlay)
		Me.Mainmenu.DropDownItems.Add(MnuStop)
		Me.Mainmenu.DropDownItems.Add(MnuInfo)
		Me.Mainmenu.DropDownItems.Add(Mnusep1)
		Me.Mainmenu.DropDownItems.Add(MnuShowPL)
		Me.Mainmenu.DropDownItems.Add(MnuOntop)
		Me.Mainmenu.DropDownItems.Add(Mnusep2)
		Me.Mainmenu.DropDownItems.Add(MnuAbout)
		Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
		CType(Me.ImgPlus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgMin, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgBR, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgPL, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgPause, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Imgprpus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Imgpus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImgPlay, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Minimize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Close_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Picvol.ResumeLayout(False)
		Me.VOL.ResumeLayout(False)
		Me.Ticker.ResumeLayout(False)
		Me.BR.ResumeLayout(False)
		Me.PL.ResumeLayout(False)
		Me.Pause.ResumeLayout(False)
		Me.play.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
