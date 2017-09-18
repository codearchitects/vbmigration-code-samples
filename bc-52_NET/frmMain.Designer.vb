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
		Me.lblMenu = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblMenu_008, lblMenu_007, lblMenu_006, lblMenu_005, lblMenu_004, lblMenu_003, lblMenu_002, lblMenu_001, lblMenu_000)
		Me.picKey = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(picKey_026, picKey_025, picKey_024, picKey_023, picKey_022, picKey_021, picKey_020, picKey_019, picKey_018, picKey_017, picKey_016, picKey_015, picKey_014, picKey_013, picKey_012, picKey_011, picKey_010, picKey_009, picKey_008, picKey_007, picKey_006, picKey_005, picKey_004, picKey_003, picKey_002, picKey_001)
		Me.imgKey = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(imgKey_026, imgKey_025, imgKey_024, imgKey_023, imgKey_003, imgKey_021, imgKey_020, imgKey_019, imgKey_018, imgKey_017, imgKey_016, imgKey_015, imgKey_014, imgKey_013, imgKey_012, imgKey_011, imgKey_010, imgKey_009, imgKey_008, imgKey_007, imgKey_006, imgKey_005, imgKey_004, imgKey_022, imgKey_002, imgKey_001)
		Me.WheelUp = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(WheelUp_006, WheelUp_005, WheelUp_004, WheelUp_003, WheelUp_002, WheelUp_001)
		Me.WheelDn = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)(WheelDn_006, WheelDn_005, WheelDn_004, WheelDn_003, WheelDn_002, WheelDn_001)
		Me.lblWindow = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblWindow_006, lblWindow_005, lblWindow_004, lblWindow_003, lblWindow_002, lblWindow_001)
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
	Public lblMenu As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public picKey As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public imgKey As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WheelUp As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public WheelDn As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Image)
	Public lblWindow As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents Dialog2 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents Timer1 As CodeArchitects.VB6Library.VB6Timer
	Public WithEvents picMenu As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents lblMenu_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblMenu_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Dialog1 As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents imgOffsetDn As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgOffsetUp As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblInfo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents imgHandleSwitch As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgMenu As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblOffset As CodeArchitects.VB6Library.VB6Label
	Public WithEvents picHandle As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgHandle As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgAdvance As CodeArchitects.VB6Library.VB6Image
	Public WithEvents shpDot As CodeArchitects.VB6Library.VB6Shape
	Public WithEvents picSoundOn As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picSoundOff As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgResetCounter As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_026 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_025 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_024 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_023 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_022 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_021 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_020 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_019 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_018 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_017 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_016 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_015 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_014 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_013 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_012 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_011 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_010 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_009 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents picKey_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_026 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_025 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_024 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_023 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_021 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_020 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_019 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_018 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_017 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_016 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_015 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_014 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_013 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_012 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_011 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_010 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_009 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_008 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_007 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_022 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgKey_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgHelp As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgSound As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgAbout As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblCounter As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblOutput As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblInput As CodeArchitects.VB6Library.VB6Label
	Public WithEvents picTitleBar As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgExit As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelUp_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_006 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_005 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_004 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_003 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_002 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents WheelDn_001 As CodeArchitects.VB6Library.VB6Image
	Public WithEvents lblWindow_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWindow_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWindow_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWindow_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWindow_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblWindow_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents imgOpen As CodeArchitects.VB6Library.VB6Image
	Public WithEvents imgBackground As CodeArchitects.VB6Library.VB6Image

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.Dialog2 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.Timer1 = New CodeArchitects.VB6Library.VB6Timer(components)
		Me.picMenu = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.lblMenu_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblMenu_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.Dialog1 = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.imgOffsetDn = New CodeArchitects.VB6Library.VB6Image()
		Me.imgOffsetUp = New CodeArchitects.VB6Library.VB6Image()
		Me.lblInfo = New CodeArchitects.VB6Library.VB6Label()
		Me.imgHandleSwitch = New CodeArchitects.VB6Library.VB6Image()
		Me.imgMenu = New CodeArchitects.VB6Library.VB6Image()
		Me.lblOffset = New CodeArchitects.VB6Library.VB6Label()
		Me.picHandle = New CodeArchitects.VB6Library.VB6Image()
		Me.imgHandle = New CodeArchitects.VB6Library.VB6Image()
		Me.imgAdvance = New CodeArchitects.VB6Library.VB6Image()
		Me.shpDot = New CodeArchitects.VB6Library.VB6Shape()
		Me.picSoundOn = New CodeArchitects.VB6Library.VB6Image()
		Me.picSoundOff = New CodeArchitects.VB6Library.VB6Image()
		Me.imgResetCounter = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_026 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_025 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_024 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_023 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_022 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_021 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_020 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_019 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_018 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_017 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_016 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_015 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_014 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_013 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_012 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_011 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_010 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_009 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.picKey_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_026 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_025 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_024 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_023 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_021 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_020 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_019 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_018 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_017 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_016 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_015 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_014 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_013 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_012 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_011 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_010 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_009 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_008 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_007 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_022 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgKey_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.imgHelp = New CodeArchitects.VB6Library.VB6Image()
		Me.imgSound = New CodeArchitects.VB6Library.VB6Image()
		Me.imgAbout = New CodeArchitects.VB6Library.VB6Image()
		Me.lblCounter = New CodeArchitects.VB6Library.VB6Label()
		Me.lblOutput = New CodeArchitects.VB6Library.VB6Label()
		Me.lblInput = New CodeArchitects.VB6Library.VB6Label()
		Me.picTitleBar = New CodeArchitects.VB6Library.VB6Image()
		Me.imgExit = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelUp_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_006 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_005 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_004 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_003 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_002 = New CodeArchitects.VB6Library.VB6Image()
		Me.WheelDn_001 = New CodeArchitects.VB6Library.VB6Image()
		Me.lblWindow_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWindow_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWindow_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWindow_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWindow_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblWindow_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.imgOpen = New CodeArchitects.VB6Library.VB6Image()
		Me.imgBackground = New CodeArchitects.VB6Library.VB6Image()
		Me.picMenu.SuspendLayout()
		CType(Me.imgOffsetDn, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgOffsetUp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgHandleSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picHandle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgHandle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shpDot, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSoundOn, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picSoundOff, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgResetCounter, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_026, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_025, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_024, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_023, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_022, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_021, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_020, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_019, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_018, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_017, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_016, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_015, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_014, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_013, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_012, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_011, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_009, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picKey_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_026, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_025, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_024, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_023, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_021, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_020, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_019, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_018, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_017, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_016, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_015, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_014, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_013, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_012, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_011, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_010, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_009, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_008, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_007, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_022, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgKey_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgSound, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgAbout, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picTitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgExit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelUp_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_006, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_005, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_004, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_003, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_002, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WheelDn_001, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBackground, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' Dialog2
		'
		Me.Dialog2.Name = "Dialog2"
		Me.Dialog2.ParentForm = Me
		Me.Dialog2.Name6 = "Dialog2"
		Me.Dialog2.CancelError = True
		'
		' Timer1
		'
		Me.Timer1.Name = "Timer1"
		Me.Timer1.ParentForm = Me
		Me.Timer1.Name6 = "Timer1"
		Me.Timer1.Interval = 250
		'
		' picMenu
		'
		Me.picMenu.Name = "picMenu"
		Me.picMenu.Size = New System.Drawing.Size(115, 154)
		Me.picMenu.Location = New System.Drawing.Point(48, 104)
		Me.picMenu.BackColor = FromOleColor6(CInt(&H00404000))
		Me.picMenu.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picMenu.FillColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.picMenu.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.picMenu.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.picMenu.TabIndex = 10
		Me.picMenu.Visible = False
		Me.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picMenu.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		'
		' lblMenu_008
		'
		Me.lblMenu_008.Name = "lblMenu_008"
		Me.lblMenu_008.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_008.Location = New System.Drawing.Point(0, 116)
		Me.lblMenu_008.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_008.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_008.Caption = " Help"
		Me.lblMenu_008.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_008.TabIndex = 20
		Me.lblMenu_008.AutoSize = False
		'
		' lblMenu_007
		'
		Me.lblMenu_007.Name = "lblMenu_007"
		Me.lblMenu_007.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_007.Location = New System.Drawing.Point(0, 50)
		Me.lblMenu_007.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_007.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_007.Caption = " Edit Key"
		Me.lblMenu_007.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_007.TabIndex = 18
		Me.lblMenu_007.AutoSize = False
		'
		' lblMenu_006
		'
		Me.lblMenu_006.Name = "lblMenu_006"
		Me.lblMenu_006.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_006.Location = New System.Drawing.Point(0, 135)
		Me.lblMenu_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_006.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_006.Caption = " Exit"
		Me.lblMenu_006.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_006.TabIndex = 17
		Me.lblMenu_006.AutoSize = False
		'
		' lblMenu_005
		'
		Me.lblMenu_005.Name = "lblMenu_005"
		Me.lblMenu_005.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_005.Location = New System.Drawing.Point(0, 66)
		Me.lblMenu_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_005.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_005.Caption = " Load Key"
		Me.lblMenu_005.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_005.TabIndex = 16
		Me.lblMenu_005.AutoSize = False
		'
		' lblMenu_004
		'
		Me.lblMenu_004.Name = "lblMenu_004"
		Me.lblMenu_004.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_004.Location = New System.Drawing.Point(0, 82)
		Me.lblMenu_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_004.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_004.Caption = " Save Key"
		Me.lblMenu_004.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_004.TabIndex = 15
		Me.lblMenu_004.AutoSize = False
		'
		' lblMenu_003
		'
		Me.lblMenu_003.Name = "lblMenu_003"
		Me.lblMenu_003.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_003.Location = New System.Drawing.Point(0, 100)
		Me.lblMenu_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_003.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_003.Caption = " Customize BC-52"
		Me.lblMenu_003.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_003.TabIndex = 14
		Me.lblMenu_003.AutoSize = False
		'
		' lblMenu_002
		'
		Me.lblMenu_002.Name = "lblMenu_002"
		Me.lblMenu_002.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_002.Location = New System.Drawing.Point(0, 34)
		Me.lblMenu_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_002.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_002.Caption = " View Key"
		Me.lblMenu_002.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_002.TabIndex = 13
		Me.lblMenu_002.AutoSize = False
		'
		' lblMenu_001
		'
		Me.lblMenu_001.Name = "lblMenu_001"
		Me.lblMenu_001.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_001.Location = New System.Drawing.Point(0, 16)
		Me.lblMenu_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_001.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_001.Caption = " Auto Typing"
		Me.lblMenu_001.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_001.TabIndex = 12
		Me.lblMenu_001.AutoSize = False
		'
		' lblMenu_000
		'
		Me.lblMenu_000.Name = "lblMenu_000"
		Me.lblMenu_000.Size = New System.Drawing.Size(113, 17)
		Me.lblMenu_000.Location = New System.Drawing.Point(0, 0)
		Me.lblMenu_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblMenu_000.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblMenu_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblMenu_000.Caption = " Clipboard"
		Me.lblMenu_000.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblMenu_000.TabIndex = 11
		Me.lblMenu_000.AutoSize = False
		'
		' Dialog1
		'
		Me.Dialog1.Name = "Dialog1"
		Me.Dialog1.ParentForm = Me
		Me.Dialog1.Name6 = "Dialog1"
		Me.Dialog1.CancelError = True
		'
		' imgOffsetDn
		'
		Me.imgOffsetDn.Name = "imgOffsetDn"
		Me.imgOffsetDn.Size = New System.Drawing.Size(41, 33)
		Me.imgOffsetDn.Location = New System.Drawing.Point(192, 291)
		Me.imgOffsetDn.MouseIcon = CType(resources.GetObject("imgOffsetDn.MouseIcon"), System.Drawing.Bitmap)
		Me.imgOffsetDn.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgOffsetDn.Stretch = True
		'
		' imgOffsetUp
		'
		Me.imgOffsetUp.Name = "imgOffsetUp"
		Me.imgOffsetUp.Size = New System.Drawing.Size(41, 33)
		Me.imgOffsetUp.Location = New System.Drawing.Point(192, 258)
		Me.imgOffsetUp.MouseIcon = CType(resources.GetObject("imgOffsetUp.MouseIcon"), System.Drawing.Bitmap)
		Me.imgOffsetUp.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgOffsetUp.Stretch = True
		'
		' lblInfo
		'
		Me.lblInfo.Name = "lblInfo"
		Me.lblInfo.Size = New System.Drawing.Size(145, 30)
		Me.lblInfo.Location = New System.Drawing.Point(32, 104)
		Me.lblInfo.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblInfo.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblInfo.BackColor = FromOleColor6(CInt(&H00C0FFFF))
		Me.lblInfo.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblInfo.Caption = " Click here for simulator menu  or use F1 for help"
		Me.lblInfo.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblInfo.TabIndex = 19
		Me.lblInfo.Visible = False
		Me.lblInfo.AutoSize = False
		'
		' imgHandleSwitch
		'
		Me.imgHandleSwitch.Name = "imgHandleSwitch"
		Me.imgHandleSwitch.Size = New System.Drawing.Size(33, 41)
		Me.imgHandleSwitch.Location = New System.Drawing.Point(168, 152)
		Me.imgHandleSwitch.MouseIcon = CType(resources.GetObject("imgHandleSwitch.MouseIcon"), System.Drawing.Bitmap)
		Me.imgHandleSwitch.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgHandleSwitch.Stretch = True
		'
		' imgMenu
		'
		Me.imgMenu.Name = "imgMenu"
		Me.imgMenu.Size = New System.Drawing.Size(161, 505)
		Me.imgMenu.Location = New System.Drawing.Point(24, 24)
		Me.imgMenu.Stretch = True
		Me.ToolTip1.SetToolTip(Me.imgMenu, " Click Here for Menu ")
		'
		' lblOffset
		'
		Me.lblOffset.Name = "lblOffset"
		Me.lblOffset.Size = New System.Drawing.Size(41, 17)
		Me.lblOffset.Location = New System.Drawing.Point(152, 256)
		Me.lblOffset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOffset.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblOffset.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblOffset.BackColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblOffset.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblOffset.Caption = "A=A"
		Me.lblOffset.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblOffset.TabIndex = 9
		Me.lblOffset.Visible = False
		Me.lblOffset.AutoSize = False
		'
		' picHandle
		'
		Me.picHandle.Name = "picHandle"
		Me.picHandle.Size = New System.Drawing.Size(5, 68)
		Me.picHandle.Location = New System.Drawing.Point(288, 568)
		Me.picHandle.Picture = CType(resources.GetObject("picHandle.Picture"), System.Drawing.Image)
		Me.picHandle.Stretch = False
		'
		' imgHandle
		'
		Me.imgHandle.Name = "imgHandle"
		Me.imgHandle.Size = New System.Drawing.Size(5, 68)
		Me.imgHandle.Location = New System.Drawing.Point(195, 150)
		Me.imgHandle.Stretch = True
		Me.imgHandle.Picture = CType(resources.GetObject("imgHandle.Picture"), System.Drawing.Image)
		'
		' imgAdvance
		'
		Me.imgAdvance.Name = "imgAdvance"
		Me.imgAdvance.Size = New System.Drawing.Size(25, 25)
		Me.imgAdvance.Location = New System.Drawing.Point(208, 192)
		Me.imgAdvance.MouseIcon = CType(resources.GetObject("imgAdvance.MouseIcon"), System.Drawing.Bitmap)
		Me.imgAdvance.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgAdvance.Stretch = True
		'
		' shpDot
		'
		Me.shpDot.Name = "shpDot"
		Me.shpDot.ParentForm = Me
		Me.shpDot.Name6 = "shpDot"
		Me.shpDot.BackColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.shpDot.BorderColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.shpDot.FillColor = FromOleColor6(CInt(&H00C0C0C0))
		Me.shpDot.FillStyle = CodeArchitects.VB6Library.VBRUN.FillStyleConstants.vbFSSolid
		Me.shpDot.Height = 150
		Me.shpDot.Left = 4560
		Me.shpDot.Shape = CodeArchitects.VB6Library.VBRUN.ShapeConstants.vbShapeCircle
		Me.shpDot.Top = 3840
		Me.shpDot.Width = 150
		'
		' picSoundOn
		'
		Me.picSoundOn.Name = "picSoundOn"
		Me.picSoundOn.Size = New System.Drawing.Size(17, 17)
		Me.picSoundOn.Location = New System.Drawing.Point(32, 576)
		Me.picSoundOn.Stretch = True
		Me.picSoundOn.Visible = False
		Me.picSoundOn.Picture = CType(resources.GetObject("picSoundOn.Picture"), System.Drawing.Image)
		'
		' picSoundOff
		'
		Me.picSoundOff.Name = "picSoundOff"
		Me.picSoundOff.Size = New System.Drawing.Size(17, 17)
		Me.picSoundOff.Location = New System.Drawing.Point(16, 576)
		Me.picSoundOff.Stretch = True
		Me.picSoundOff.Visible = False
		Me.picSoundOff.Picture = CType(resources.GetObject("picSoundOff.Picture"), System.Drawing.Image)
		'
		' imgResetCounter
		'
		Me.imgResetCounter.Name = "imgResetCounter"
		Me.imgResetCounter.Size = New System.Drawing.Size(73, 25)
		Me.imgResetCounter.Location = New System.Drawing.Point(208, 96)
		Me.imgResetCounter.MouseIcon = CType(resources.GetObject("imgResetCounter.MouseIcon"), System.Drawing.Bitmap)
		Me.imgResetCounter.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgResetCounter.Stretch = True
		'
		' picKey_026
		'
		Me.picKey_026.Name = "picKey_026"
		Me.picKey_026.Size = New System.Drawing.Size(13, 13)
		Me.picKey_026.Location = New System.Drawing.Point(256, 584)
		Me.picKey_026.Stretch = True
		Me.picKey_026.Visible = False
		Me.picKey_026.Picture = CType(resources.GetObject("picKey_026.Picture"), System.Drawing.Image)
		'
		' picKey_025
		'
		Me.picKey_025.Name = "picKey_025"
		Me.picKey_025.Size = New System.Drawing.Size(13, 13)
		Me.picKey_025.Location = New System.Drawing.Point(240, 584)
		Me.picKey_025.Stretch = True
		Me.picKey_025.Visible = False
		Me.picKey_025.Picture = CType(resources.GetObject("picKey_025.Picture"), System.Drawing.Image)
		'
		' picKey_024
		'
		Me.picKey_024.Name = "picKey_024"
		Me.picKey_024.Size = New System.Drawing.Size(13, 13)
		Me.picKey_024.Location = New System.Drawing.Point(224, 584)
		Me.picKey_024.Stretch = True
		Me.picKey_024.Visible = False
		Me.picKey_024.Picture = CType(resources.GetObject("picKey_024.Picture"), System.Drawing.Image)
		'
		' picKey_023
		'
		Me.picKey_023.Name = "picKey_023"
		Me.picKey_023.Size = New System.Drawing.Size(13, 13)
		Me.picKey_023.Location = New System.Drawing.Point(208, 584)
		Me.picKey_023.Stretch = True
		Me.picKey_023.Visible = False
		Me.picKey_023.Picture = CType(resources.GetObject("picKey_023.Picture"), System.Drawing.Image)
		'
		' picKey_022
		'
		Me.picKey_022.Name = "picKey_022"
		Me.picKey_022.Size = New System.Drawing.Size(13, 13)
		Me.picKey_022.Location = New System.Drawing.Point(192, 584)
		Me.picKey_022.Stretch = True
		Me.picKey_022.Visible = False
		Me.picKey_022.Picture = CType(resources.GetObject("picKey_022.Picture"), System.Drawing.Image)
		'
		' picKey_021
		'
		Me.picKey_021.Name = "picKey_021"
		Me.picKey_021.Size = New System.Drawing.Size(13, 13)
		Me.picKey_021.Location = New System.Drawing.Point(176, 584)
		Me.picKey_021.Stretch = True
		Me.picKey_021.Visible = False
		Me.picKey_021.Picture = CType(resources.GetObject("picKey_021.Picture"), System.Drawing.Image)
		'
		' picKey_020
		'
		Me.picKey_020.Name = "picKey_020"
		Me.picKey_020.Size = New System.Drawing.Size(13, 13)
		Me.picKey_020.Location = New System.Drawing.Point(160, 584)
		Me.picKey_020.Stretch = True
		Me.picKey_020.Visible = False
		Me.picKey_020.Picture = CType(resources.GetObject("picKey_020.Picture"), System.Drawing.Image)
		'
		' picKey_019
		'
		Me.picKey_019.Name = "picKey_019"
		Me.picKey_019.Size = New System.Drawing.Size(13, 13)
		Me.picKey_019.Location = New System.Drawing.Point(144, 584)
		Me.picKey_019.Stretch = True
		Me.picKey_019.Visible = False
		Me.picKey_019.Picture = CType(resources.GetObject("picKey_019.Picture"), System.Drawing.Image)
		'
		' picKey_018
		'
		Me.picKey_018.Name = "picKey_018"
		Me.picKey_018.Size = New System.Drawing.Size(13, 13)
		Me.picKey_018.Location = New System.Drawing.Point(128, 584)
		Me.picKey_018.Stretch = True
		Me.picKey_018.Visible = False
		Me.picKey_018.Picture = CType(resources.GetObject("picKey_018.Picture"), System.Drawing.Image)
		'
		' picKey_017
		'
		Me.picKey_017.Name = "picKey_017"
		Me.picKey_017.Size = New System.Drawing.Size(13, 13)
		Me.picKey_017.Location = New System.Drawing.Point(112, 584)
		Me.picKey_017.Stretch = True
		Me.picKey_017.Visible = False
		Me.picKey_017.Picture = CType(resources.GetObject("picKey_017.Picture"), System.Drawing.Image)
		'
		' picKey_016
		'
		Me.picKey_016.Name = "picKey_016"
		Me.picKey_016.Size = New System.Drawing.Size(13, 13)
		Me.picKey_016.Location = New System.Drawing.Point(96, 584)
		Me.picKey_016.Stretch = True
		Me.picKey_016.Visible = False
		Me.picKey_016.Picture = CType(resources.GetObject("picKey_016.Picture"), System.Drawing.Image)
		'
		' picKey_015
		'
		Me.picKey_015.Name = "picKey_015"
		Me.picKey_015.Size = New System.Drawing.Size(13, 13)
		Me.picKey_015.Location = New System.Drawing.Point(80, 584)
		Me.picKey_015.Stretch = True
		Me.picKey_015.Visible = False
		Me.picKey_015.Picture = CType(resources.GetObject("picKey_015.Picture"), System.Drawing.Image)
		'
		' picKey_014
		'
		Me.picKey_014.Name = "picKey_014"
		Me.picKey_014.Size = New System.Drawing.Size(13, 13)
		Me.picKey_014.Location = New System.Drawing.Point(64, 584)
		Me.picKey_014.Stretch = True
		Me.picKey_014.Visible = False
		Me.picKey_014.Picture = CType(resources.GetObject("picKey_014.Picture"), System.Drawing.Image)
		'
		' picKey_013
		'
		Me.picKey_013.Name = "picKey_013"
		Me.picKey_013.Size = New System.Drawing.Size(13, 13)
		Me.picKey_013.Location = New System.Drawing.Point(256, 568)
		Me.picKey_013.Stretch = True
		Me.picKey_013.Visible = False
		Me.picKey_013.Picture = CType(resources.GetObject("picKey_013.Picture"), System.Drawing.Image)
		'
		' picKey_012
		'
		Me.picKey_012.Name = "picKey_012"
		Me.picKey_012.Size = New System.Drawing.Size(13, 13)
		Me.picKey_012.Location = New System.Drawing.Point(240, 568)
		Me.picKey_012.Stretch = True
		Me.picKey_012.Visible = False
		Me.picKey_012.Picture = CType(resources.GetObject("picKey_012.Picture"), System.Drawing.Image)
		'
		' picKey_011
		'
		Me.picKey_011.Name = "picKey_011"
		Me.picKey_011.Size = New System.Drawing.Size(13, 13)
		Me.picKey_011.Location = New System.Drawing.Point(224, 568)
		Me.picKey_011.Stretch = True
		Me.picKey_011.Visible = False
		Me.picKey_011.Picture = CType(resources.GetObject("picKey_011.Picture"), System.Drawing.Image)
		'
		' picKey_010
		'
		Me.picKey_010.Name = "picKey_010"
		Me.picKey_010.Size = New System.Drawing.Size(13, 13)
		Me.picKey_010.Location = New System.Drawing.Point(208, 568)
		Me.picKey_010.Stretch = True
		Me.picKey_010.Visible = False
		Me.picKey_010.Picture = CType(resources.GetObject("picKey_010.Picture"), System.Drawing.Image)
		'
		' picKey_009
		'
		Me.picKey_009.Name = "picKey_009"
		Me.picKey_009.Size = New System.Drawing.Size(13, 13)
		Me.picKey_009.Location = New System.Drawing.Point(192, 568)
		Me.picKey_009.Stretch = True
		Me.picKey_009.Visible = False
		Me.picKey_009.Picture = CType(resources.GetObject("picKey_009.Picture"), System.Drawing.Image)
		'
		' picKey_008
		'
		Me.picKey_008.Name = "picKey_008"
		Me.picKey_008.Size = New System.Drawing.Size(13, 13)
		Me.picKey_008.Location = New System.Drawing.Point(176, 568)
		Me.picKey_008.Stretch = True
		Me.picKey_008.Visible = False
		Me.picKey_008.Picture = CType(resources.GetObject("picKey_008.Picture"), System.Drawing.Image)
		'
		' picKey_007
		'
		Me.picKey_007.Name = "picKey_007"
		Me.picKey_007.Size = New System.Drawing.Size(13, 13)
		Me.picKey_007.Location = New System.Drawing.Point(160, 568)
		Me.picKey_007.Stretch = True
		Me.picKey_007.Visible = False
		Me.picKey_007.Picture = CType(resources.GetObject("picKey_007.Picture"), System.Drawing.Image)
		'
		' picKey_006
		'
		Me.picKey_006.Name = "picKey_006"
		Me.picKey_006.Size = New System.Drawing.Size(13, 13)
		Me.picKey_006.Location = New System.Drawing.Point(144, 568)
		Me.picKey_006.Stretch = True
		Me.picKey_006.Visible = False
		Me.picKey_006.Picture = CType(resources.GetObject("picKey_006.Picture"), System.Drawing.Image)
		'
		' picKey_005
		'
		Me.picKey_005.Name = "picKey_005"
		Me.picKey_005.Size = New System.Drawing.Size(13, 13)
		Me.picKey_005.Location = New System.Drawing.Point(128, 568)
		Me.picKey_005.Stretch = True
		Me.picKey_005.Visible = False
		Me.picKey_005.Picture = CType(resources.GetObject("picKey_005.Picture"), System.Drawing.Image)
		'
		' picKey_004
		'
		Me.picKey_004.Name = "picKey_004"
		Me.picKey_004.Size = New System.Drawing.Size(13, 13)
		Me.picKey_004.Location = New System.Drawing.Point(112, 568)
		Me.picKey_004.Stretch = True
		Me.picKey_004.Visible = False
		Me.picKey_004.Picture = CType(resources.GetObject("picKey_004.Picture"), System.Drawing.Image)
		'
		' picKey_003
		'
		Me.picKey_003.Name = "picKey_003"
		Me.picKey_003.Size = New System.Drawing.Size(13, 13)
		Me.picKey_003.Location = New System.Drawing.Point(96, 568)
		Me.picKey_003.Stretch = True
		Me.picKey_003.Visible = False
		Me.picKey_003.Picture = CType(resources.GetObject("picKey_003.Picture"), System.Drawing.Image)
		'
		' picKey_002
		'
		Me.picKey_002.Name = "picKey_002"
		Me.picKey_002.Size = New System.Drawing.Size(13, 13)
		Me.picKey_002.Location = New System.Drawing.Point(80, 568)
		Me.picKey_002.Stretch = True
		Me.picKey_002.Visible = False
		Me.picKey_002.Picture = CType(resources.GetObject("picKey_002.Picture"), System.Drawing.Image)
		'
		' picKey_001
		'
		Me.picKey_001.Name = "picKey_001"
		Me.picKey_001.Size = New System.Drawing.Size(13, 13)
		Me.picKey_001.Location = New System.Drawing.Point(64, 568)
		Me.picKey_001.Stretch = True
		Me.picKey_001.Visible = False
		Me.picKey_001.Picture = CType(resources.GetObject("picKey_001.Picture"), System.Drawing.Image)
		'
		' imgKey_026
		'
		Me.imgKey_026.Name = "imgKey_026"
		Me.imgKey_026.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_026.Location = New System.Drawing.Point(462, 395)
		Me.imgKey_026.MouseIcon = CType(resources.GetObject("imgKey_026.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_026.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_026.Stretch = True
		'
		' imgKey_025
		'
		Me.imgKey_025.Name = "imgKey_025"
		Me.imgKey_025.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_025.Location = New System.Drawing.Point(255, 489)
		Me.imgKey_025.MouseIcon = CType(resources.GetObject("imgKey_025.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_025.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_025.Stretch = True
		'
		' imgKey_024
		'
		Me.imgKey_024.Name = "imgKey_024"
		Me.imgKey_024.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_024.Location = New System.Drawing.Point(302, 489)
		Me.imgKey_024.MouseIcon = CType(resources.GetObject("imgKey_024.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_024.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_024.Stretch = True
		'
		' imgKey_023
		'
		Me.imgKey_023.Name = "imgKey_023"
		Me.imgKey_023.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_023.Location = New System.Drawing.Point(271, 395)
		Me.imgKey_023.MouseIcon = CType(resources.GetObject("imgKey_023.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_023.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_023.Stretch = True
		'
		' imgKey_003
		'
		Me.imgKey_003.Name = "imgKey_003"
		Me.imgKey_003.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_003.Location = New System.Drawing.Point(351, 489)
		Me.imgKey_003.MouseIcon = CType(resources.GetObject("imgKey_003.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_003.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_003.Stretch = True
		'
		' imgKey_021
		'
		Me.imgKey_021.Name = "imgKey_021"
		Me.imgKey_021.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_021.Location = New System.Drawing.Point(510, 395)
		Me.imgKey_021.MouseIcon = CType(resources.GetObject("imgKey_021.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_021.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_021.Stretch = True
		'
		' imgKey_020
		'
		Me.imgKey_020.Name = "imgKey_020"
		Me.imgKey_020.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_020.Location = New System.Drawing.Point(414, 395)
		Me.imgKey_020.MouseIcon = CType(resources.GetObject("imgKey_020.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_020.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_020.Stretch = True
		'
		' imgKey_019
		'
		Me.imgKey_019.Name = "imgKey_019"
		Me.imgKey_019.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_019.Location = New System.Drawing.Point(287, 441)
		Me.imgKey_019.MouseIcon = CType(resources.GetObject("imgKey_019.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_019.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_019.Stretch = True
		'
		' imgKey_018
		'
		Me.imgKey_018.Name = "imgKey_018"
		Me.imgKey_018.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_018.Location = New System.Drawing.Point(367, 395)
		Me.imgKey_018.MouseIcon = CType(resources.GetObject("imgKey_018.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_018.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_018.Stretch = True
		'
		' imgKey_017
		'
		Me.imgKey_017.Name = "imgKey_017"
		Me.imgKey_017.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_017.Location = New System.Drawing.Point(222, 395)
		Me.imgKey_017.MouseIcon = CType(resources.GetObject("imgKey_017.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_017.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_017.Stretch = True
		'
		' imgKey_016
		'
		Me.imgKey_016.Name = "imgKey_016"
		Me.imgKey_016.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_016.Location = New System.Drawing.Point(654, 395)
		Me.imgKey_016.MouseIcon = CType(resources.GetObject("imgKey_016.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_016.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_016.Stretch = True
		'
		' imgKey_015
		'
		Me.imgKey_015.Name = "imgKey_015"
		Me.imgKey_015.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_015.Location = New System.Drawing.Point(607, 395)
		Me.imgKey_015.MouseIcon = CType(resources.GetObject("imgKey_015.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_015.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_015.Stretch = True
		'
		' imgKey_014
		'
		Me.imgKey_014.Name = "imgKey_014"
		Me.imgKey_014.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_014.Location = New System.Drawing.Point(495, 489)
		Me.imgKey_014.MouseIcon = CType(resources.GetObject("imgKey_014.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_014.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_014.Stretch = True
		'
		' imgKey_013
		'
		Me.imgKey_013.Name = "imgKey_013"
		Me.imgKey_013.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_013.Location = New System.Drawing.Point(543, 489)
		Me.imgKey_013.MouseIcon = CType(resources.GetObject("imgKey_013.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_013.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_013.Stretch = True
		'
		' imgKey_012
		'
		Me.imgKey_012.Name = "imgKey_012"
		Me.imgKey_012.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_012.Location = New System.Drawing.Point(622, 441)
		Me.imgKey_012.MouseIcon = CType(resources.GetObject("imgKey_012.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_012.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_012.Stretch = True
		'
		' imgKey_011
		'
		Me.imgKey_011.Name = "imgKey_011"
		Me.imgKey_011.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_011.Location = New System.Drawing.Point(574, 441)
		Me.imgKey_011.MouseIcon = CType(resources.GetObject("imgKey_011.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_011.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_011.Stretch = True
		'
		' imgKey_010
		'
		Me.imgKey_010.Name = "imgKey_010"
		Me.imgKey_010.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_010.Location = New System.Drawing.Point(527, 441)
		Me.imgKey_010.MouseIcon = CType(resources.GetObject("imgKey_010.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_010.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_010.Stretch = True
		'
		' imgKey_009
		'
		Me.imgKey_009.Name = "imgKey_009"
		Me.imgKey_009.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_009.Location = New System.Drawing.Point(558, 395)
		Me.imgKey_009.MouseIcon = CType(resources.GetObject("imgKey_009.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_009.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_009.Stretch = True
		'
		' imgKey_008
		'
		Me.imgKey_008.Name = "imgKey_008"
		Me.imgKey_008.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_008.Location = New System.Drawing.Point(479, 441)
		Me.imgKey_008.MouseIcon = CType(resources.GetObject("imgKey_008.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_008.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_008.Stretch = True
		'
		' imgKey_007
		'
		Me.imgKey_007.Name = "imgKey_007"
		Me.imgKey_007.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_007.Location = New System.Drawing.Point(431, 441)
		Me.imgKey_007.MouseIcon = CType(resources.GetObject("imgKey_007.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_007.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_007.Stretch = True
		'
		' imgKey_006
		'
		Me.imgKey_006.Name = "imgKey_006"
		Me.imgKey_006.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_006.Location = New System.Drawing.Point(382, 441)
		Me.imgKey_006.MouseIcon = CType(resources.GetObject("imgKey_006.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_006.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_006.Stretch = True
		'
		' imgKey_005
		'
		Me.imgKey_005.Name = "imgKey_005"
		Me.imgKey_005.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_005.Location = New System.Drawing.Point(318, 395)
		Me.imgKey_005.MouseIcon = CType(resources.GetObject("imgKey_005.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_005.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_005.Stretch = True
		'
		' imgKey_004
		'
		Me.imgKey_004.Name = "imgKey_004"
		Me.imgKey_004.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_004.Location = New System.Drawing.Point(335, 441)
		Me.imgKey_004.MouseIcon = CType(resources.GetObject("imgKey_004.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_004.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_004.Stretch = True
		'
		' imgKey_022
		'
		Me.imgKey_022.Name = "imgKey_022"
		Me.imgKey_022.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_022.Location = New System.Drawing.Point(399, 489)
		Me.imgKey_022.MouseIcon = CType(resources.GetObject("imgKey_022.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_022.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_022.Stretch = True
		'
		' imgKey_002
		'
		Me.imgKey_002.Name = "imgKey_002"
		Me.imgKey_002.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_002.Location = New System.Drawing.Point(447, 489)
		Me.imgKey_002.MouseIcon = CType(resources.GetObject("imgKey_002.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_002.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_002.Stretch = True
		'
		' imgKey_001
		'
		Me.imgKey_001.Name = "imgKey_001"
		Me.imgKey_001.Size = New System.Drawing.Size(44, 44)
		Me.imgKey_001.Location = New System.Drawing.Point(239, 441)
		Me.imgKey_001.MouseIcon = CType(resources.GetObject("imgKey_001.MouseIcon"), System.Drawing.Bitmap)
		Me.imgKey_001.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgKey_001.Stretch = True
		'
		' imgHelp
		'
		Me.imgHelp.Name = "imgHelp"
		Me.imgHelp.Size = New System.Drawing.Size(20, 20)
		Me.imgHelp.Location = New System.Drawing.Point(658, 3)
		Me.imgHelp.Stretch = True
		Me.ToolTip1.SetToolTip(Me.imgHelp, " Help ")
		'
		' imgSound
		'
		Me.imgSound.Name = "imgSound"
		Me.imgSound.Size = New System.Drawing.Size(20, 20)
		Me.imgSound.Location = New System.Drawing.Point(631, 3)
		Me.imgSound.Stretch = True
		Me.ToolTip1.SetToolTip(Me.imgSound, " Sound Off ")
		Me.imgSound.Picture = CType(resources.GetObject("imgSound.Picture"), System.Drawing.Image)
		'
		' imgAbout
		'
		Me.imgAbout.Name = "imgAbout"
		Me.imgAbout.Size = New System.Drawing.Size(20, 20)
		Me.imgAbout.Location = New System.Drawing.Point(686, 3)
		Me.imgAbout.Stretch = True
		Me.ToolTip1.SetToolTip(Me.imgAbout, " About C-52 ")
		'
		' lblCounter
		'
		Me.lblCounter.Name = "lblCounter"
		Me.lblCounter.Size = New System.Drawing.Size(33, 17)
		Me.lblCounter.Location = New System.Drawing.Point(238, 99)
		Me.lblCounter.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCounter.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblCounter.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblCounter.Caption = "000"
		Me.lblCounter.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblCounter.TabIndex = 8
		Me.lblCounter.AutoSize = False
		Me.lblCounter.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblOutput
		'
		Me.lblOutput.Name = "lblOutput"
		Me.lblOutput.Size = New System.Drawing.Size(313, 17)
		Me.lblOutput.Location = New System.Drawing.Point(344, 83)
		Me.lblOutput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOutput.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblOutput.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblOutput.ForeColor = FromOleColor6(CInt(&H00800080))
		Me.lblOutput.TabIndex = 7
		Me.lblOutput.AutoSize = False
		Me.lblOutput.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblInput
		'
		Me.lblInput.Name = "lblInput"
		Me.lblInput.Size = New System.Drawing.Size(313, 17)
		Me.lblInput.Location = New System.Drawing.Point(344, 57)
		Me.lblInput.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInput.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblInput.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblInput.ForeColor = FromOleColor6(CInt(&H00800080))
		Me.lblInput.TabIndex = 6
		Me.lblInput.AutoSize = False
		Me.lblInput.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' picTitleBar
		'
		Me.picTitleBar.Name = "picTitleBar"
		Me.picTitleBar.Size = New System.Drawing.Size(625, 25)
		Me.picTitleBar.Location = New System.Drawing.Point(0, 0)
		Me.picTitleBar.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbSizeAll
		Me.picTitleBar.Stretch = True
		Me.ToolTip1.SetToolTip(Me.picTitleBar, " Move Window ")
		'
		' imgExit
		'
		Me.imgExit.Name = "imgExit"
		Me.imgExit.Size = New System.Drawing.Size(20, 20)
		Me.imgExit.Location = New System.Drawing.Point(712, 3)
		Me.imgExit.Stretch = True
		Me.ToolTip1.SetToolTip(Me.imgExit, " Exit Program ")
		'
		' WheelUp_006
		'
		Me.WheelUp_006.Name = "WheelUp_006"
		Me.WheelUp_006.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_006.Location = New System.Drawing.Point(610, 300)
		Me.WheelUp_006.MouseIcon = CType(resources.GetObject("WheelUp_006.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_006.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_006.Stretch = True
		'
		' WheelUp_005
		'
		Me.WheelUp_005.Name = "WheelUp_005"
		Me.WheelUp_005.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_005.Location = New System.Drawing.Point(571, 300)
		Me.WheelUp_005.MouseIcon = CType(resources.GetObject("WheelUp_005.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_005.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_005.Stretch = True
		'
		' WheelUp_004
		'
		Me.WheelUp_004.Name = "WheelUp_004"
		Me.WheelUp_004.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_004.Location = New System.Drawing.Point(532, 300)
		Me.WheelUp_004.MouseIcon = CType(resources.GetObject("WheelUp_004.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_004.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_004.Stretch = True
		'
		' WheelUp_003
		'
		Me.WheelUp_003.Name = "WheelUp_003"
		Me.WheelUp_003.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_003.Location = New System.Drawing.Point(493, 300)
		Me.WheelUp_003.MouseIcon = CType(resources.GetObject("WheelUp_003.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_003.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_003.Stretch = True
		'
		' WheelUp_002
		'
		Me.WheelUp_002.Name = "WheelUp_002"
		Me.WheelUp_002.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_002.Location = New System.Drawing.Point(454, 300)
		Me.WheelUp_002.MouseIcon = CType(resources.GetObject("WheelUp_002.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_002.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_002.Stretch = True
		'
		' WheelUp_001
		'
		Me.WheelUp_001.Name = "WheelUp_001"
		Me.WheelUp_001.Size = New System.Drawing.Size(25, 33)
		Me.WheelUp_001.Location = New System.Drawing.Point(415, 300)
		Me.WheelUp_001.MouseIcon = CType(resources.GetObject("WheelUp_001.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelUp_001.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelUp_001.Stretch = True
		'
		' WheelDn_006
		'
		Me.WheelDn_006.Name = "WheelDn_006"
		Me.WheelDn_006.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_006.Location = New System.Drawing.Point(610, 245)
		Me.WheelDn_006.MouseIcon = CType(resources.GetObject("WheelDn_006.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_006.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_006.Stretch = True
		'
		' WheelDn_005
		'
		Me.WheelDn_005.Name = "WheelDn_005"
		Me.WheelDn_005.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_005.Location = New System.Drawing.Point(571, 245)
		Me.WheelDn_005.MouseIcon = CType(resources.GetObject("WheelDn_005.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_005.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_005.Stretch = True
		'
		' WheelDn_004
		'
		Me.WheelDn_004.Name = "WheelDn_004"
		Me.WheelDn_004.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_004.Location = New System.Drawing.Point(532, 245)
		Me.WheelDn_004.MouseIcon = CType(resources.GetObject("WheelDn_004.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_004.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_004.Stretch = True
		'
		' WheelDn_003
		'
		Me.WheelDn_003.Name = "WheelDn_003"
		Me.WheelDn_003.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_003.Location = New System.Drawing.Point(493, 245)
		Me.WheelDn_003.MouseIcon = CType(resources.GetObject("WheelDn_003.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_003.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_003.Stretch = True
		'
		' WheelDn_002
		'
		Me.WheelDn_002.Name = "WheelDn_002"
		Me.WheelDn_002.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_002.Location = New System.Drawing.Point(454, 245)
		Me.WheelDn_002.MouseIcon = CType(resources.GetObject("WheelDn_002.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_002.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_002.Stretch = True
		'
		' WheelDn_001
		'
		Me.WheelDn_001.Name = "WheelDn_001"
		Me.WheelDn_001.Size = New System.Drawing.Size(25, 33)
		Me.WheelDn_001.Location = New System.Drawing.Point(415, 245)
		Me.WheelDn_001.MouseIcon = CType(resources.GetObject("WheelDn_001.MouseIcon"), System.Drawing.Bitmap)
		Me.WheelDn_001.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.WheelDn_001.Stretch = True
		'
		' lblWindow_006
		'
		Me.lblWindow_006.Name = "lblWindow_006"
		Me.lblWindow_006.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_006.Location = New System.Drawing.Point(610, 253)
		Me.lblWindow_006.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_006.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_006.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_006.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_006.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_006.TabIndex = 5
		Me.lblWindow_006.IsBackgroundControl = True
		Me.lblWindow_006.AutoSize = False
		'
		' lblWindow_005
		'
		Me.lblWindow_005.Name = "lblWindow_005"
		Me.lblWindow_005.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_005.Location = New System.Drawing.Point(571, 253)
		Me.lblWindow_005.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_005.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_005.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_005.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_005.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_005.TabIndex = 4
		Me.lblWindow_005.IsBackgroundControl = True
		Me.lblWindow_005.AutoSize = False
		'
		' lblWindow_004
		'
		Me.lblWindow_004.Name = "lblWindow_004"
		Me.lblWindow_004.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_004.Location = New System.Drawing.Point(532, 253)
		Me.lblWindow_004.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_004.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_004.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_004.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_004.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_004.TabIndex = 3
		Me.lblWindow_004.IsBackgroundControl = True
		Me.lblWindow_004.AutoSize = False
		'
		' lblWindow_003
		'
		Me.lblWindow_003.Name = "lblWindow_003"
		Me.lblWindow_003.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_003.Location = New System.Drawing.Point(493, 253)
		Me.lblWindow_003.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_003.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_003.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_003.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_003.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_003.TabIndex = 2
		Me.lblWindow_003.IsBackgroundControl = True
		Me.lblWindow_003.AutoSize = False
		'
		' lblWindow_002
		'
		Me.lblWindow_002.Name = "lblWindow_002"
		Me.lblWindow_002.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_002.Location = New System.Drawing.Point(454, 253)
		Me.lblWindow_002.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_002.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_002.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_002.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_002.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_002.TabIndex = 1
		Me.lblWindow_002.IsBackgroundControl = True
		Me.lblWindow_002.AutoSize = False
		'
		' lblWindow_001
		'
		Me.lblWindow_001.Name = "lblWindow_001"
		Me.lblWindow_001.Size = New System.Drawing.Size(25, 76)
		Me.lblWindow_001.Location = New System.Drawing.Point(415, 253)
		Me.lblWindow_001.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWindow_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblWindow_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.lblWindow_001.BackColor = FromOleColor6(CInt(&H80000005))
		Me.lblWindow_001.BackStyle = CodeArchitects.VB6Library.VB6BackStyleConstants.Transparent
		Me.lblWindow_001.ForeColor = FromOleColor6(CInt(&H00FFFFFF))
		Me.lblWindow_001.TabIndex = 0
		Me.lblWindow_001.IsBackgroundControl = True
		Me.lblWindow_001.AutoSize = False
		'
		' imgOpen
		'
		Me.imgOpen.Name = "imgOpen"
		Me.imgOpen.Size = New System.Drawing.Size(305, 121)
		Me.imgOpen.Location = New System.Drawing.Point(360, 112)
		Me.imgOpen.MouseIcon = CType(resources.GetObject("imgOpen.MouseIcon"), System.Drawing.Bitmap)
		Me.imgOpen.MousePointer = CodeArchitects.VB6Library.VBRUN.MousePointerConstants.vbCustom
		Me.imgOpen.Stretch = True
		'
		' imgBackground
		'
		Me.imgBackground.Name = "imgBackground"
		Me.imgBackground.Size = New System.Drawing.Size(737, 560)
		Me.imgBackground.Location = New System.Drawing.Point(0, 0)
		Me.imgBackground.Stretch = True
		Me.imgBackground.Picture = CType(resources.GetObject("imgBackground.Picture"), System.Drawing.Image)
		Me.imgBackground.IsBackgroundControl = True
		'
		' frmMain
		'
		Me.Name = "frmMain"
		Me.AutoRedraw = True
		Me.BackColor = FromOleColor6(CInt(&H00E0E0E0))
		Me.BorderStyle = CodeArchitects.VB6Library.VBRUN.FormBorderStyleConstants.vbBSNone
		Me.Caption = "C-52 Simulator"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.MinButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpScreen
		Me.Location = New System.Drawing.Point(0, -22)
		Me.ClientSize = New System.Drawing.Size(737, 560)

		Me.Controls.Add(picMenu)
		Me.picMenu.Controls.Add(lblMenu_008)
		Me.picMenu.Controls.Add(lblMenu_007)
		Me.picMenu.Controls.Add(lblMenu_006)
		Me.picMenu.Controls.Add(lblMenu_005)
		Me.picMenu.Controls.Add(lblMenu_004)
		Me.picMenu.Controls.Add(lblMenu_003)
		Me.picMenu.Controls.Add(lblMenu_002)
		Me.picMenu.Controls.Add(lblMenu_001)
		Me.picMenu.Controls.Add(lblMenu_000)
		Me.Controls.Add(imgOffsetDn)
		Me.Controls.Add(imgOffsetUp)
		Me.Controls.Add(lblInfo)
		Me.Controls.Add(imgHandleSwitch)
		Me.Controls.Add(imgMenu)
		Me.Controls.Add(lblOffset)
		Me.Controls.Add(picHandle)
		Me.Controls.Add(imgHandle)
		Me.Controls.Add(imgAdvance)
		Me.Controls.Add(picSoundOn)
		Me.Controls.Add(picSoundOff)
		Me.Controls.Add(imgResetCounter)
		Me.Controls.Add(picKey_026)
		Me.Controls.Add(picKey_025)
		Me.Controls.Add(picKey_024)
		Me.Controls.Add(picKey_023)
		Me.Controls.Add(picKey_022)
		Me.Controls.Add(picKey_021)
		Me.Controls.Add(picKey_020)
		Me.Controls.Add(picKey_019)
		Me.Controls.Add(picKey_018)
		Me.Controls.Add(picKey_017)
		Me.Controls.Add(picKey_016)
		Me.Controls.Add(picKey_015)
		Me.Controls.Add(picKey_014)
		Me.Controls.Add(picKey_013)
		Me.Controls.Add(picKey_012)
		Me.Controls.Add(picKey_011)
		Me.Controls.Add(picKey_010)
		Me.Controls.Add(picKey_009)
		Me.Controls.Add(picKey_008)
		Me.Controls.Add(picKey_007)
		Me.Controls.Add(picKey_006)
		Me.Controls.Add(picKey_005)
		Me.Controls.Add(picKey_004)
		Me.Controls.Add(picKey_003)
		Me.Controls.Add(picKey_002)
		Me.Controls.Add(picKey_001)
		Me.Controls.Add(imgKey_026)
		Me.Controls.Add(imgKey_025)
		Me.Controls.Add(imgKey_024)
		Me.Controls.Add(imgKey_023)
		Me.Controls.Add(imgKey_003)
		Me.Controls.Add(imgKey_021)
		Me.Controls.Add(imgKey_020)
		Me.Controls.Add(imgKey_019)
		Me.Controls.Add(imgKey_018)
		Me.Controls.Add(imgKey_017)
		Me.Controls.Add(imgKey_016)
		Me.Controls.Add(imgKey_015)
		Me.Controls.Add(imgKey_014)
		Me.Controls.Add(imgKey_013)
		Me.Controls.Add(imgKey_012)
		Me.Controls.Add(imgKey_011)
		Me.Controls.Add(imgKey_010)
		Me.Controls.Add(imgKey_009)
		Me.Controls.Add(imgKey_008)
		Me.Controls.Add(imgKey_007)
		Me.Controls.Add(imgKey_006)
		Me.Controls.Add(imgKey_005)
		Me.Controls.Add(imgKey_004)
		Me.Controls.Add(imgKey_022)
		Me.Controls.Add(imgKey_002)
		Me.Controls.Add(imgKey_001)
		Me.Controls.Add(imgHelp)
		Me.Controls.Add(imgSound)
		Me.Controls.Add(imgAbout)
		Me.Controls.Add(lblCounter)
		Me.Controls.Add(lblOutput)
		Me.Controls.Add(lblInput)
		Me.Controls.Add(picTitleBar)
		Me.Controls.Add(imgExit)
		Me.Controls.Add(WheelUp_006)
		Me.Controls.Add(WheelUp_005)
		Me.Controls.Add(WheelUp_004)
		Me.Controls.Add(WheelUp_003)
		Me.Controls.Add(WheelUp_002)
		Me.Controls.Add(WheelUp_001)
		Me.Controls.Add(WheelDn_006)
		Me.Controls.Add(WheelDn_005)
		Me.Controls.Add(WheelDn_004)
		Me.Controls.Add(WheelDn_003)
		Me.Controls.Add(WheelDn_002)
		Me.Controls.Add(WheelDn_001)
		Me.Controls.Add(lblWindow_006)
		Me.Controls.Add(lblWindow_005)
		Me.Controls.Add(lblWindow_004)
		Me.Controls.Add(lblWindow_003)
		Me.Controls.Add(lblWindow_002)
		Me.Controls.Add(lblWindow_001)
		Me.Controls.Add(imgOpen)
		Me.Controls.Add(imgBackground)
		CType(Me.imgOffsetDn, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgOffsetUp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgHandleSwitch, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picHandle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgHandle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgAdvance, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.shpDot, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSoundOn, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picSoundOff, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgResetCounter, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_026, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_025, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_024, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_023, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_022, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_021, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_020, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_019, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_018, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_017, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_016, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_015, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_014, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_013, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_012, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_011, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_009, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picKey_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_026, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_025, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_024, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_023, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_021, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_020, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_019, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_018, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_017, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_016, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_015, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_014, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_013, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_012, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_011, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_010, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_009, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_008, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_007, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_022, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgKey_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgHelp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgSound, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgAbout, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picTitleBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgExit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelUp_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_006, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_005, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_004, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_003, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_002, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WheelDn_001, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBackground, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picMenu.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
