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
		Me.lOptCaption = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lOptCaption_002, lOptCaption_001, lOptCaption_000)
		Me.lInfo = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lInfo_002, lInfo_001, lInfo_000)
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
	Public lOptCaption As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public lInfo As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents tControl As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents pFrame As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pMCursor As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lState As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lAppName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fFrame As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdLoadFile As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cRecMiddleClick As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents pStop As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdExit As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdHide As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPlay As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRec As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cWndAutoShow As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cWndAutoHide As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cSetFile As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cRecLeftClick As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cRecRightClick As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cRecMovement As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents pRec As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents pPlay As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lOptCaption_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lOptCaption_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lOptCaption_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lOptions As CodeArchitects.VB6Library.VB6Label
	Public WithEvents comDlg As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents lInfo_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lInfo_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lInfo_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lMousePos As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.tControl = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.pFrame = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pMCursor = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lState = New CodeArchitects.VB6Library.VB6Label()
		Me.lAppName = New CodeArchitects.VB6Library.VB6Label()
		Me.fFrame = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdLoadFile = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cRecMiddleClick = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.pStop = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdExit = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdHide = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPlay = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRec = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cWndAutoShow = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cWndAutoHide = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cSetFile = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cRecLeftClick = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cRecRightClick = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cRecMovement = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.pRec = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.pPlay = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lOptCaption_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lOptCaption_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lOptCaption_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lOptions = New CodeArchitects.VB6Library.VB6Label()
		Me.comDlg = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.lInfo_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lInfo_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lInfo_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lMousePos = New CodeArchitects.VB6Library.VB6Label()
		Me.pFrame.SuspendLayout()
		Me.fFrame.SuspendLayout()
		Me.SuspendLayout()
		'
		' tControl
		'
		Me.tControl.Name = "tControl"
		Me.tControl.ParentForm = Me
		Me.tControl.Name6 = "tControl"
		Me.tControl.Enabled = False
		Me.tControl.Interval = 10
		'
		' pFrame
		'
		Me.pFrame.Name = "pFrame"
		Me.pFrame.Size = New System.Drawing.Size(401, 32)
		Me.pFrame.Location = New System.Drawing.Point(5, 4)
		Me.pFrame.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.pFrame.BackColor = FromOleColor6(CInt(&H80000005))
		Me.pFrame.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.pFrame.TabIndex = 0
		Me.pFrame.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pFrame.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' pMCursor
		'
		Me.pMCursor.Name = "pMCursor"
		Me.pMCursor.Size = New System.Drawing.Size(18, 26)
		Me.pMCursor.Location = New System.Drawing.Point(8, 4)
		Me.pMCursor.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.pMCursor.AutoRedraw = True
		Me.pMCursor.BackColor = FromOleColor6(CInt(&H80000005))
		Me.pMCursor.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.pMCursor.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.pMCursor.Picture = CType(resources.GetObject("pMCursor.Picture"), System.Drawing.Image)
		Me.pMCursor.TabIndex = 1
		Me.pMCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pMCursor.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' lState
		'
		Me.lState.Name = "lState"
		Me.lState.Size = New System.Drawing.Size(94, 22)
		Me.lState.Location = New System.Drawing.Point(267, 3)
		Me.lState.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lState.AutoSize = True
		Me.lState.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lState.Caption = "[PLAYING]"
		Me.lState.ForeColor = FromOleColor6(CInt(&H000000FF))
		Me.lState.TabIndex = 3
		Me.lState.Visible = False
		Me.lState.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lAppName
		'
		Me.lAppName.Name = "lAppName"
		Me.lAppName.Size = New System.Drawing.Size(184, 22)
		Me.lAppName.Location = New System.Drawing.Point(29, 3)
		Me.lAppName.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lAppName.AutoSize = True
		Me.lAppName.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lAppName.Caption = "MOUSE  RECORDER"
		Me.lAppName.ForeColor = FromOleColor6(CInt(&H00C00000))
		Me.lAppName.TabIndex = 2
		Me.lAppName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fFrame
		'
		Me.fFrame.Name = "fFrame"
		Me.fFrame.Size = New System.Drawing.Size(402, 147)
		Me.fFrame.Location = New System.Drawing.Point(5, 35)
		Me.fFrame.TabIndex = 5
		Me.fFrame.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdLoadFile
		'
		Me.cmdLoadFile.Name = "cmdLoadFile"
		Me.cmdLoadFile.Size = New System.Drawing.Size(119, 22)
		Me.cmdLoadFile.Location = New System.Drawing.Point(140, 119)
		Me.cmdLoadFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdLoadFile.Caption = "Load from File ..."
		Me.cmdLoadFile.TabIndex = 27
		Me.cmdLoadFile.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cRecMiddleClick
		'
		Me.cRecMiddleClick.Name = "cRecMiddleClick"
		Me.cRecMiddleClick.Size = New System.Drawing.Size(75, 15)
		Me.cRecMiddleClick.Location = New System.Drawing.Point(12, 99)
		Me.cRecMiddleClick.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cRecMiddleClick.Caption = "Middle Click"
		Me.cRecMiddleClick.TabIndex = 24
		Me.cRecMiddleClick.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.cRecMiddleClick.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' pStop
		'
		Me.pStop.Name = "pStop"
		Me.pStop.Size = New System.Drawing.Size(111, 25)
		Me.pStop.Location = New System.Drawing.Point(334, 35)
		Me.pStop.AutoSize = True
		Me.pStop.Picture = CType(resources.GetObject("pStop.Picture"), System.Drawing.Image)
		Me.pStop.TabIndex = 23
		Me.pStop.Visible = False
		Me.pStop.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pStop.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.pStop.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdExit
		'
		Me.cmdExit.Name = "cmdExit"
		Me.cmdExit.Size = New System.Drawing.Size(105, 25)
		Me.cmdExit.Location = New System.Drawing.Point(278, 111)
		Me.cmdExit.Picture = CType(resources.GetObject("cmdExit.Picture"), System.Drawing.Image)
		Me.cmdExit.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdExit.TabIndex = 22
		Me.cmdExit.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdHide
		'
		Me.cmdHide.Name = "cmdHide"
		Me.cmdHide.Size = New System.Drawing.Size(105, 25)
		Me.cmdHide.Location = New System.Drawing.Point(278, 80)
		Me.cmdHide.Picture = CType(resources.GetObject("cmdHide.Picture"), System.Drawing.Image)
		Me.cmdHide.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdHide.TabIndex = 21
		Me.cmdHide.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdPlay
		'
		Me.cmdPlay.Name = "cmdPlay"
		Me.cmdPlay.Size = New System.Drawing.Size(105, 25)
		Me.cmdPlay.Location = New System.Drawing.Point(278, 49)
		Me.cmdPlay.Picture = CType(resources.GetObject("cmdPlay.Picture"), System.Drawing.Image)
		Me.cmdPlay.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdPlay.TabIndex = 20
		Me.cmdPlay.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdRec
		'
		Me.cmdRec.Name = "cmdRec"
		Me.cmdRec.Size = New System.Drawing.Size(105, 25)
		Me.cmdRec.Location = New System.Drawing.Point(278, 18)
		Me.cmdRec.Picture = CType(resources.GetObject("cmdRec.Picture"), System.Drawing.Image)
		Me.cmdRec.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cmdRec.TabIndex = 19
		Me.cmdRec.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cWndAutoShow
		'
		Me.cWndAutoShow.Name = "cWndAutoShow"
		Me.cWndAutoShow.Size = New System.Drawing.Size(75, 15)
		Me.cWndAutoShow.Location = New System.Drawing.Point(145, 63)
		Me.cWndAutoShow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cWndAutoShow.Caption = "Auto Show"
		Me.cWndAutoShow.TabIndex = 18
		Me.cWndAutoShow.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.cWndAutoShow.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cWndAutoHide
		'
		Me.cWndAutoHide.Name = "cWndAutoHide"
		Me.cWndAutoHide.Size = New System.Drawing.Size(67, 15)
		Me.cWndAutoHide.Location = New System.Drawing.Point(145, 45)
		Me.cWndAutoHide.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cWndAutoHide.Caption = "Auto Hide"
		Me.cWndAutoHide.TabIndex = 17
		Me.cWndAutoHide.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cSetFile
		'
		Me.cSetFile.Name = "cSetFile"
		Me.cSetFile.Size = New System.Drawing.Size(119, 19)
		Me.cSetFile.Location = New System.Drawing.Point(140, 96)
		Me.cSetFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cSetFile.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.cSetFile.Caption = "Save as File ..."
		Me.cSetFile.Style = CodeArchitects.VB6Library.VBRUN.ButtonConstants.vbButtonGraphical
		Me.cSetFile.TabIndex = 15
		'
		' cRecLeftClick
		'
		Me.cRecLeftClick.Name = "cRecLeftClick"
		Me.cRecLeftClick.Size = New System.Drawing.Size(67, 15)
		Me.cRecLeftClick.Location = New System.Drawing.Point(12, 81)
		Me.cRecLeftClick.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cRecLeftClick.Caption = "Left Click"
		Me.cRecLeftClick.TabIndex = 10
		Me.cRecLeftClick.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.cRecLeftClick.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cRecRightClick
		'
		Me.cRecRightClick.Name = "cRecRightClick"
		Me.cRecRightClick.Size = New System.Drawing.Size(75, 15)
		Me.cRecRightClick.Location = New System.Drawing.Point(12, 63)
		Me.cRecRightClick.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cRecRightClick.Caption = "Right Click"
		Me.cRecRightClick.TabIndex = 9
		Me.cRecRightClick.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.cRecRightClick.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cRecMovement
		'
		Me.cRecMovement.Name = "cRecMovement"
		Me.cRecMovement.Size = New System.Drawing.Size(108, 15)
		Me.cRecMovement.Location = New System.Drawing.Point(12, 45)
		Me.cRecMovement.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cRecMovement.Caption = "Mouse Movement"
		Me.cRecMovement.TabIndex = 7
		Me.cRecMovement.Value = CodeArchitects.VB6Library.VBRUN.CheckBoxConstants.vbChecked
		Me.cRecMovement.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' pRec
		'
		Me.pRec.Name = "pRec"
		Me.pRec.Size = New System.Drawing.Size(111, 25)
		Me.pRec.Location = New System.Drawing.Point(263, 15)
		Me.pRec.AutoSize = True
		Me.pRec.Picture = CType(resources.GetObject("pRec.Picture"), System.Drawing.Image)
		Me.pRec.TabIndex = 25
		Me.pRec.Visible = False
		Me.pRec.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pRec.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.pRec.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' pPlay
		'
		Me.pPlay.Name = "pPlay"
		Me.pPlay.Size = New System.Drawing.Size(111, 25)
		Me.pPlay.Location = New System.Drawing.Point(263, 45)
		Me.pPlay.AutoSize = True
		Me.pPlay.Picture = CType(resources.GetObject("pPlay.Picture"), System.Drawing.Image)
		Me.pPlay.TabIndex = 26
		Me.pPlay.Visible = False
		Me.pPlay.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.pPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.pPlay.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.pPlay.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lOptCaption_002
		'
		Me.lOptCaption_002.Name = "lOptCaption_002"
		Me.lOptCaption_002.Size = New System.Drawing.Size(49, 14)
		Me.lOptCaption_002.Location = New System.Drawing.Point(140, 26)
		Me.lOptCaption_002.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lOptCaption_002.AutoSize = True
		Me.lOptCaption_002.Caption = "Window:"
		Me.lOptCaption_002.TabIndex = 16
		Me.lOptCaption_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lOptCaption_001
		'
		Me.lOptCaption_001.Name = "lOptCaption_001"
		Me.lOptCaption_001.Size = New System.Drawing.Size(67, 14)
		Me.lOptCaption_001.Location = New System.Drawing.Point(138, 80)
		Me.lOptCaption_001.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lOptCaption_001.AutoSize = True
		Me.lOptCaption_001.Caption = "Save to File:"
		Me.lOptCaption_001.TabIndex = 13
		Me.lOptCaption_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lOptCaption_000
		'
		Me.lOptCaption_000.Name = "lOptCaption_000"
		Me.lOptCaption_000.Size = New System.Drawing.Size(58, 14)
		Me.lOptCaption_000.Location = New System.Drawing.Point(10, 26)
		Me.lOptCaption_000.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lOptCaption_000.AutoSize = True
		Me.lOptCaption_000.Caption = "Recording:"
		Me.lOptCaption_000.TabIndex = 8
		Me.lOptCaption_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lOptions
		'
		Me.lOptions.Name = "lOptions"
		Me.lOptions.Size = New System.Drawing.Size(143, 15)
		Me.lOptions.Location = New System.Drawing.Point(0, 6)
		Me.lOptions.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lOptions.AutoSize = True
		Me.lOptions.BackColor = FromOleColor6(CInt(&H80000010))
		Me.lOptions.Caption = "   RECORDER Options   "
		Me.lOptions.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lOptions.TabIndex = 6
		'
		' comDlg
		'
		Me.comDlg.Name = "comDlg"
		Me.comDlg.ParentForm = Me
		Me.comDlg.Name6 = "comDlg"
		Me.comDlg.Filter = "Mouse Motion File (*.mot)|*.mot|All files (*.*)|*.*"
		'
		' lInfo_002
		'
		Me.lInfo_002.Name = "lInfo_002"
		Me.lInfo_002.Size = New System.Drawing.Size(341, 13)
		Me.lInfo_002.Location = New System.Drawing.Point(11, 209)
		Me.lInfo_002.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lInfo_002.AutoSize = True
		Me.lInfo_002.Caption = "If you want to Hide this Window or to Show this again press [F12] Key."
		Me.lInfo_002.TabIndex = 14
		Me.lInfo_002.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lInfo_001
		'
		Me.lInfo_001.Name = "lInfo_001"
		Me.lInfo_001.Size = New System.Drawing.Size(331, 13)
		Me.lInfo_001.Location = New System.Drawing.Point(11, 196)
		Me.lInfo_001.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lInfo_001.AutoSize = True
		Me.lInfo_001.Caption = "press [F9] Key and to stop Recording or Playback press [Pause] Key."
		Me.lInfo_001.TabIndex = 12
		Me.lInfo_001.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lInfo_000
		'
		Me.lInfo_000.Name = "lInfo_000"
		Me.lInfo_000.Size = New System.Drawing.Size(338, 13)
		Me.lInfo_000.Location = New System.Drawing.Point(11, 183)
		Me.lInfo_000.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lInfo_000.AutoSize = True
		Me.lInfo_000.Caption = "To start Recording you can press [F10] Key everywhere. For Playback"
		Me.lInfo_000.TabIndex = 11
		Me.lInfo_000.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lMousePos
		'
		Me.lMousePos.Name = "lMousePos"
		Me.lMousePos.Size = New System.Drawing.Size(34, 11)
		Me.lMousePos.Location = New System.Drawing.Point(370, 198)
		Me.lMousePos.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lMousePos.AutoSize = True
		Me.lMousePos.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lMousePos.Caption = "888, 888"
		Me.lMousePos.ForeColor = FromOleColor6(CInt(&H00808080))
		Me.lMousePos.TabIndex = 4
		Me.lMousePos.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbFixedSingle
		Me.Caption = "Mouse Recorder (C)2002 by CodeXP"
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ClientSize = New System.Drawing.Size(411, 223)

		Me.Controls.Add(pFrame)
		Me.pFrame.Controls.Add(pMCursor)
		Me.pFrame.Controls.Add(lState)
		Me.pFrame.Controls.Add(lAppName)
		Me.Controls.Add(fFrame)
		Me.fFrame.Controls.Add(cmdLoadFile)
		Me.fFrame.Controls.Add(cRecMiddleClick)
		Me.fFrame.Controls.Add(pStop)
		Me.fFrame.Controls.Add(cmdExit)
		Me.fFrame.Controls.Add(cmdHide)
		Me.fFrame.Controls.Add(cmdPlay)
		Me.fFrame.Controls.Add(cmdRec)
		Me.fFrame.Controls.Add(cWndAutoShow)
		Me.fFrame.Controls.Add(cWndAutoHide)
		Me.fFrame.Controls.Add(cSetFile)
		Me.fFrame.Controls.Add(cRecLeftClick)
		Me.fFrame.Controls.Add(cRecRightClick)
		Me.fFrame.Controls.Add(cRecMovement)
		Me.fFrame.Controls.Add(pRec)
		Me.fFrame.Controls.Add(pPlay)
		Me.fFrame.Controls.Add(lOptCaption_002)
		Me.fFrame.Controls.Add(lOptCaption_001)
		Me.fFrame.Controls.Add(lOptCaption_000)
		Me.fFrame.Controls.Add(lOptions)
		Me.Controls.Add(lInfo_002)
		Me.Controls.Add(lInfo_001)
		Me.Controls.Add(lInfo_000)
		Me.Controls.Add(lMousePos)
		Me.pFrame.ResumeLayout(False)
		Me.fFrame.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
