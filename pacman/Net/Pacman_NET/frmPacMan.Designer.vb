<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPacMan
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
	Public WithEvents tmrReady As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents tmrPookie As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents tmrFlash As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents pctBack As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents tmrKeyBoard As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents pctTiles As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pctScreen As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblPlayer As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblReady As CodeArchitects.VB6Library.VB6Label
	Public WithEvents pctpicture As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pctStats As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblKeys As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblSpeed As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPlayers As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCoins As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPookie As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblTitle As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblInsert As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblHiscore As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblScore As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPacMan))
		Me.tmrReady = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.tmrPookie = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.tmrFlash = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.pctBack = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.tmrKeyBoard = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.pctTiles = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pctScreen = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblPlayer = New CodeArchitects.VB6Library.VB6Label()
		Me.lblReady = New CodeArchitects.VB6Library.VB6Label()
		Me.pctpicture = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pctStats = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblKeys = New CodeArchitects.VB6Library.VB6Label()
		Me.lblSpeed = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPlayers = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCoins = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPookie = New CodeArchitects.VB6Library.VB6Label()
		Me.lblTitle = New CodeArchitects.VB6Library.VB6Label()
		Me.lblInsert = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblHiscore = New CodeArchitects.VB6Library.VB6Label()
		Me.lblScore = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.pctScreen.SuspendLayout()
		Me.pctStats.SuspendLayout()
		Me.SuspendLayout()
		'
		' tmrReady
		'
		Me.tmrReady.Name = "tmrReady"
		Me.tmrReady.ParentForm = Me
		Me.tmrReady.Name6 = "tmrReady"
		Me.tmrReady.Enabled = False
		Me.tmrReady.Interval = 500
		'
		' tmrPookie
		'
		Me.tmrPookie.Name = "tmrPookie"
		Me.tmrPookie.ParentForm = Me
		Me.tmrPookie.Name6 = "tmrPookie"
		Me.tmrPookie.Interval = 100
		'
		' tmrFlash
		'
		Me.tmrFlash.Name = "tmrFlash"
		Me.tmrFlash.ParentForm = Me
		Me.tmrFlash.Name6 = "tmrFlash"
		Me.tmrFlash.Interval = 500
		'
		' pctBack
		'
		Me.pctBack.Name = "pctBack"
		Me.pctBack.Size = New System.Drawing.Size(32, 192)
		Me.pctBack.Location = New System.Drawing.Point(688, 300)
		Me.pctBack.AutoRedraw = True
		Me.pctBack.BackColor = FromOleColor6(CInt(&H00404080))
		Me.pctBack.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctBack.Enabled = False
		Me.pctBack.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctBack.TabIndex = 8
		Me.pctBack.Visible = False
		Me.pctBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctBack.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' tmrKeyBoard
		'
		Me.tmrKeyBoard.Name = "tmrKeyBoard"
		Me.tmrKeyBoard.ParentForm = Me
		Me.tmrKeyBoard.Name6 = "tmrKeyBoard"
		Me.tmrKeyBoard.Enabled = False
		Me.tmrKeyBoard.Interval = 10
		'
		' pctTiles
		'
		Me.pctTiles.Name = "pctTiles"
		Me.pctTiles.Size = New System.Drawing.Size(256, 352)
		Me.pctTiles.Location = New System.Drawing.Point(480, 24)
		Me.pctTiles.AutoRedraw = True
		Me.pctTiles.AutoSize = True
		Me.pctTiles.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctTiles.Enabled = False
		Me.pctTiles.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctTiles.TabIndex = 5
		Me.pctTiles.Visible = False
		Me.pctTiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctTiles.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.pctTiles.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' pctScreen
		'
		Me.pctScreen.Name = "pctScreen"
		Me.pctScreen.Size = New System.Drawing.Size(448, 495)
		Me.pctScreen.Location = New System.Drawing.Point(0, 28)
		Me.pctScreen.AutoRedraw = True
		Me.pctScreen.BackColor = FromOleColor6(CInt(&H00800080))
		Me.pctScreen.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctScreen.Enabled = False
		Me.pctScreen.ForeColor = FromOleColor6(CInt(&H0000FF00))
		Me.pctScreen.Picture = CType(resources.GetObject("pctScreen.Picture"), System.Drawing.Image)
		Me.pctScreen.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctScreen.TabIndex = 0
		Me.pctScreen.Visible = False
		Me.pctScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctScreen.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' lblPlayer
		'
		Me.lblPlayer.Name = "lblPlayer"
		Me.lblPlayer.Size = New System.Drawing.Size(169, 33)
		Me.lblPlayer.Location = New System.Drawing.Point(140, 312)
		Me.lblPlayer.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlayer.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPlayer.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblPlayer.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblPlayer.ForeColor = FromOleColor6(CInt(&H0000FFFF))
		Me.lblPlayer.TabIndex = 15
		Me.lblPlayer.AutoSize = False
		'
		' lblReady
		'
		Me.lblReady.Name = "lblReady"
		Me.lblReady.Size = New System.Drawing.Size(169, 33)
		Me.lblReady.Location = New System.Drawing.Point(140, 264)
		Me.lblReady.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblReady.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblReady.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblReady.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblReady.ForeColor = FromOleColor6(CInt(&H0000FFFF))
		Me.lblReady.TabIndex = 14
		Me.lblReady.AutoSize = False
		'
		' pctpicture
		'
		Me.pctpicture.Name = "pctpicture"
		Me.pctpicture.Size = New System.Drawing.Size(448, 495)
		Me.pctpicture.Location = New System.Drawing.Point(448, 24)
		Me.pctpicture.AutoRedraw = True
		Me.pctpicture.BackColor = FromOleColor6(CInt(&H00800000))
		Me.pctpicture.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctpicture.ForeColor = FromOleColor6(CInt(&H0000FF00))
		Me.pctpicture.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctpicture.TabIndex = 6
		Me.pctpicture.Visible = False
		Me.pctpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctpicture.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' pctStats
		'
		Me.pctStats.Name = "pctStats"
		Me.pctStats.Size = New System.Drawing.Size(448, 32)
		Me.pctStats.Location = New System.Drawing.Point(0, 520)
		Me.pctStats.AutoRedraw = True
		Me.pctStats.BackColor = FromOleColor6(CInt(&H00000000))
		Me.pctStats.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pctStats.Enabled = False
		Me.pctStats.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.pctStats.TabIndex = 7
		Me.pctStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pctStats.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' lblKeys
		'
		Me.lblKeys.Name = "lblKeys"
		Me.lblKeys.Size = New System.Drawing.Size(441, 13)
		Me.lblKeys.Location = New System.Drawing.Point(0, 16)
		Me.lblKeys.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblKeys.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblKeys.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblKeys.Caption = "(I) Insert Coin   (1) 1 Play   (2) 2 Play   (E) Enhanced   (S) Speed   (Esc) Exit"
		Me.lblKeys.ForeColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.lblKeys.TabIndex = 13
		Me.lblKeys.AutoSize = False
		'
		' lblSpeed
		'
		Me.lblSpeed.Name = "lblSpeed"
		Me.lblSpeed.Size = New System.Drawing.Size(441, 29)
		Me.lblSpeed.Location = New System.Drawing.Point(4, 152)
		Me.lblSpeed.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSpeed.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblSpeed.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblSpeed.Caption = "NORMAL SPEED"
		Me.lblSpeed.ForeColor = FromOleColor6(CInt(&H00FF0000))
		Me.lblSpeed.TabIndex = 17
		Me.lblSpeed.AutoSize = False
		'
		' lblPlayers
		'
		Me.lblPlayers.Name = "lblPlayers"
		Me.lblPlayers.Size = New System.Drawing.Size(441, 29)
		Me.lblPlayers.Location = New System.Drawing.Point(4, 328)
		Me.lblPlayers.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlayers.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPlayers.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblPlayers.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPlayers.TabIndex = 16
		Me.lblPlayers.AutoSize = False
		'
		' lblCoins
		'
		Me.lblCoins.Name = "lblCoins"
		Me.lblCoins.Size = New System.Drawing.Size(441, 25)
		Me.lblCoins.Location = New System.Drawing.Point(4, 468)
		Me.lblCoins.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCoins.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblCoins.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblCoins.Caption = "0 CREDITS"
		Me.lblCoins.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblCoins.TabIndex = 12
		Me.lblCoins.AutoSize = False
		'
		' lblPookie
		'
		Me.lblPookie.Name = "lblPookie"
		Me.lblPookie.Size = New System.Drawing.Size(441, 29)
		Me.lblPookie.Location = New System.Drawing.Point(4, 248)
		Me.lblPookie.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPookie.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblPookie.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblPookie.Caption = "By Lord Pookie :)"
		Me.lblPookie.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblPookie.TabIndex = 11
		Me.lblPookie.AutoSize = False
		'
		' lblTitle
		'
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(441, 29)
		Me.lblTitle.Location = New System.Drawing.Point(4, 68)
		Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblTitle.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblTitle.Caption = "ENHANCED PACMAN"
		Me.lblTitle.ForeColor = FromOleColor6(CInt(&H0000FFFF))
		Me.lblTitle.TabIndex = 10
		Me.lblTitle.AutoSize = False
		'
		' lblInsert
		'
		Me.lblInsert.Name = "lblInsert"
		Me.lblInsert.Size = New System.Drawing.Size(441, 29)
		Me.lblInsert.Location = New System.Drawing.Point(4, 404)
		Me.lblInsert.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInsert.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblInsert.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblInsert.Caption = "INSERT COINS"
		Me.lblInsert.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblInsert.TabIndex = 9
		Me.lblInsert.AutoSize = False
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(81, 25)
		Me.Label3.Location = New System.Drawing.Point(4, 0)
		Me.Label3.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label3.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label3.Caption = "SCORE"
		Me.Label3.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label3.TabIndex = 4
		Me.Label3.AutoSize = False
		'
		' lblHiscore
		'
		Me.lblHiscore.Name = "lblHiscore"
		Me.lblHiscore.Size = New System.Drawing.Size(97, 25)
		Me.lblHiscore.Location = New System.Drawing.Point(232, 0)
		Me.lblHiscore.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHiscore.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblHiscore.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblHiscore.Caption = "0"
		Me.lblHiscore.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblHiscore.TabIndex = 3
		Me.lblHiscore.AutoSize = False
		'
		' lblScore
		'
		Me.lblScore.Name = "lblScore"
		Me.lblScore.Size = New System.Drawing.Size(97, 25)
		Me.lblScore.Location = New System.Drawing.Point(96, 0)
		Me.lblScore.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScore.BackColor = FromOleColor6(CInt(&H00000000))
		Me.lblScore.Caption = "0"
		Me.lblScore.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblScore.TabIndex = 2
		Me.lblScore.AutoSize = False
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(113, 25)
		Me.Label1.Location = New System.Drawing.Point(332, 0)
		Me.Label1.Font = New System.Drawing.Font("Tahoma", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1.BackColor = FromOleColor6(CInt(&H00000000))
		Me.Label1.Caption = "HI SCORE"
		Me.Label1.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.Label1.TabIndex = 1
		Me.Label1.AutoSize = False
		'
		' frmPacMan
		'
		Me.Name = "frmPacMan"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00000000))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Form1"
		Me.MaxButton = False
		Me.MinButton = False
		Me.ScaleMode = CodeArchitects.VB6Library.VBRUN.ScaleModeConstants.vbPixels
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(457, 553)

		Me.Controls.Add(pctBack)
		Me.Controls.Add(pctTiles)
		Me.Controls.Add(pctScreen)
		Me.pctScreen.Controls.Add(lblPlayer)
		Me.pctScreen.Controls.Add(lblReady)
		Me.Controls.Add(pctpicture)
		Me.Controls.Add(pctStats)
		Me.pctStats.Controls.Add(lblKeys)
		Me.Controls.Add(lblSpeed)
		Me.Controls.Add(lblPlayers)
		Me.Controls.Add(lblCoins)
		Me.Controls.Add(lblPookie)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(lblInsert)
		Me.Controls.Add(Label3)
		Me.Controls.Add(lblHiscore)
		Me.Controls.Add(lblScore)
		Me.Controls.Add(Label1)
		Me.pctScreen.ResumeLayout(False)
		Me.pctStats.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
