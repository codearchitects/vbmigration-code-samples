<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRecordset
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
		Me.cmdMethod = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)(cmdMethod_020, cmdMethod_019, cmdMethod_018, cmdMethod_017, cmdMethod_016, cmdMethod_015, cmdMethod_014, cmdMethod_008, cmdMethod_009, cmdMethod_010, cmdMethod_007, cmdMethod_011, cmdMethod_013, cmdMethod_003, cmdMethod_012, cmdMethod_006, cmdMethod_005, cmdMethod_004, cmdMethod_002, cmdMethod_001, cmdMethod_000)
		Me.lblProperty = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblProperty_018, lblProperty_017, lblProperty_012, lblProperty_016, lblProperty_015, lblProperty_011, lblProperty_014, lblProperty_013, lblProperty_003, lblProperty_005, lblProperty_001, lblProperty_007, lblProperty_000, lblProperty_004, lblProperty_006, lblProperty_002, lblProperty_008, lblProperty_009, lblProperty_010)
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
	Public cmdMethod As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CommandButton)
	Public lblProperty As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdMethod_020 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_019 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_018 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_017 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_016 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_015 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_014 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowRecords As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowFields As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_008 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_009 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_010 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_007 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_011 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_013 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_003 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_012 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_006 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_005 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_004 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_002 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstCustomProperties As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents tabRecordset As CodeArchitects.VB6Library.VB6SSTab
	Public WithEvents tabRecordset_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents lblProperty_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_013 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_018 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents txtMaxRecords As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboLockType As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtFilter As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboCursorType As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboCursorLocation As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtCacheSize As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtActiveConnection As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtSort As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtSource As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents tabRecordset_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents lblProperty_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_014 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_015 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_016 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblProperty_017 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cboAbsolutePage As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboEditMode As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboAbsolutePosition As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboEOF As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboBOF As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents txtBookmark As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtPageCount As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtPageSize As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtRecordCount As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboState As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdClear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtEvents As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdMethod_001 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMethod_000 As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSetProperties As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdSet As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtCustomProperty As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblCustomProperty As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRecordset))
		Me.cmdMethod_020 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_019 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_018 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_017 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_016 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_015 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_014 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowRecords = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowFields = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_008 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_009 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_010 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_007 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_011 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_013 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_003 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_012 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_006 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_005 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_004 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_002 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstCustomProperties = New CodeArchitects.VB6Library.VB6ListBox()
		Me.tabRecordset = New CodeArchitects.VB6Library.VB6SSTab()
		Me.tabRecordset_TabPage0 = New System.Windows.Forms.TabPage()
		Me.lblProperty_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_013 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_018 = New CodeArchitects.VB6Library.VB6Label()
		Me.txtMaxRecords = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboLockType = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtFilter = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboCursorType = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboCursorLocation = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtCacheSize = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtActiveConnection = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtSort = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtSource = New CodeArchitects.VB6Library.VB6TextBox()
		Me.tabRecordset_TabPage1 = New System.Windows.Forms.TabPage()
		Me.lblProperty_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_014 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_015 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_016 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProperty_017 = New CodeArchitects.VB6Library.VB6Label()
		Me.cboAbsolutePage = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboEditMode = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboAbsolutePosition = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboEOF = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboBOF = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtBookmark = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtPageCount = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtPageSize = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtRecordCount = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboState = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdClear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtEvents = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdMethod_001 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMethod_000 = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSetProperties = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdSet = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtCustomProperty = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblCustomProperty = New CodeArchitects.VB6Library.VB6Label()
		Me.tabRecordset.SuspendLayout()
		Me.tabRecordset_TabPage0.SuspendLayout()
		Me.tabRecordset_TabPage1.SuspendLayout()
		CType(Me.tabRecordset, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdMethod_020
		'
		Me.cmdMethod_020.Name = "cmdMethod_020"
		Me.cmdMethod_020.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_020.Location = New System.Drawing.Point(440, 312)
		Me.cmdMethod_020.Caption = "Supports"
		Me.cmdMethod_020.TabIndex = 68
		'
		' cmdMethod_019
		'
		Me.cmdMethod_019.Name = "cmdMethod_019"
		Me.cmdMethod_019.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_019.Location = New System.Drawing.Point(440, 288)
		Me.cmdMethod_019.Caption = "Save"
		Me.cmdMethod_019.TabIndex = 67
		'
		' cmdMethod_018
		'
		Me.cmdMethod_018.Name = "cmdMethod_018"
		Me.cmdMethod_018.Size = New System.Drawing.Size(65, 25)
		Me.cmdMethod_018.Location = New System.Drawing.Point(248, 336)
		Me.cmdMethod_018.Caption = "Resync"
		Me.cmdMethod_018.TabIndex = 66
		'
		' cmdMethod_017
		'
		Me.cmdMethod_017.Name = "cmdMethod_017"
		Me.cmdMethod_017.Size = New System.Drawing.Size(65, 25)
		Me.cmdMethod_017.Location = New System.Drawing.Point(184, 336)
		Me.cmdMethod_017.Caption = "Requery"
		Me.cmdMethod_017.TabIndex = 65
		'
		' cmdMethod_016
		'
		Me.cmdMethod_016.Name = "cmdMethod_016"
		Me.cmdMethod_016.Size = New System.Drawing.Size(113, 25)
		Me.cmdMethod_016.Location = New System.Drawing.Point(200, 368)
		Me.cmdMethod_016.Caption = "NextRecordset"
		Me.cmdMethod_016.TabIndex = 64
		'
		' cmdMethod_015
		'
		Me.cmdMethod_015.Name = "cmdMethod_015"
		Me.cmdMethod_015.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_015.Location = New System.Drawing.Point(8, 368)
		Me.cmdMethod_015.Caption = "UpdateBatch"
		Me.cmdMethod_015.TabIndex = 63
		'
		' cmdMethod_014
		'
		Me.cmdMethod_014.Name = "cmdMethod_014"
		Me.cmdMethod_014.Size = New System.Drawing.Size(57, 25)
		Me.cmdMethod_014.Location = New System.Drawing.Point(8, 336)
		Me.cmdMethod_014.Caption = "Update"
		Me.cmdMethod_014.TabIndex = 62
		'
		' cmdShowRecords
		'
		Me.cmdShowRecords.Name = "cmdShowRecords"
		Me.cmdShowRecords.Size = New System.Drawing.Size(105, 25)
		Me.cmdShowRecords.Location = New System.Drawing.Point(432, 368)
		Me.cmdShowRecords.Caption = "Show Records"
		Me.cmdShowRecords.TabIndex = 61
		'
		' cmdShowFields
		'
		Me.cmdShowFields.Name = "cmdShowFields"
		Me.cmdShowFields.Size = New System.Drawing.Size(105, 25)
		Me.cmdShowFields.Location = New System.Drawing.Point(432, 344)
		Me.cmdShowFields.Caption = "Show Fields"
		Me.cmdShowFields.TabIndex = 60
		'
		' cmdMethod_008
		'
		Me.cmdMethod_008.Name = "cmdMethod_008"
		Me.cmdMethod_008.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_008.Location = New System.Drawing.Point(320, 264)
		Me.cmdMethod_008.Caption = "MovePrevious"
		Me.cmdMethod_008.TabIndex = 59
		'
		' cmdMethod_009
		'
		Me.cmdMethod_009.Name = "cmdMethod_009"
		Me.cmdMethod_009.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_009.Location = New System.Drawing.Point(320, 288)
		Me.cmdMethod_009.Caption = "MoveNext"
		Me.cmdMethod_009.TabIndex = 58
		'
		' cmdMethod_010
		'
		Me.cmdMethod_010.Name = "cmdMethod_010"
		Me.cmdMethod_010.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_010.Location = New System.Drawing.Point(320, 312)
		Me.cmdMethod_010.Caption = "MoveLast"
		Me.cmdMethod_010.TabIndex = 57
		'
		' cmdMethod_007
		'
		Me.cmdMethod_007.Name = "cmdMethod_007"
		Me.cmdMethod_007.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_007.Location = New System.Drawing.Point(320, 240)
		Me.cmdMethod_007.Caption = "MoveFirst"
		Me.cmdMethod_007.TabIndex = 56
		'
		' cmdMethod_011
		'
		Me.cmdMethod_011.Name = "cmdMethod_011"
		Me.cmdMethod_011.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_011.Location = New System.Drawing.Point(320, 336)
		Me.cmdMethod_011.Caption = "Move"
		Me.cmdMethod_011.TabIndex = 55
		'
		' cmdMethod_013
		'
		Me.cmdMethod_013.Name = "cmdMethod_013"
		Me.cmdMethod_013.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_013.Location = New System.Drawing.Point(440, 264)
		Me.cmdMethod_013.Caption = "Find"
		Me.cmdMethod_013.TabIndex = 54
		'
		' cmdMethod_003
		'
		Me.cmdMethod_003.Name = "cmdMethod_003"
		Me.cmdMethod_003.Size = New System.Drawing.Size(57, 25)
		Me.cmdMethod_003.Location = New System.Drawing.Point(184, 304)
		Me.cmdMethod_003.Caption = "Delete"
		Me.cmdMethod_003.TabIndex = 53
		'
		' cmdMethod_012
		'
		Me.cmdMethod_012.Name = "cmdMethod_012"
		Me.cmdMethod_012.Size = New System.Drawing.Size(73, 25)
		Me.cmdMethod_012.Location = New System.Drawing.Point(440, 240)
		Me.cmdMethod_012.Caption = "Clone"
		Me.cmdMethod_012.TabIndex = 52
		'
		' cmdMethod_006
		'
		Me.cmdMethod_006.Name = "cmdMethod_006"
		Me.cmdMethod_006.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_006.Location = New System.Drawing.Point(64, 336)
		Me.cmdMethod_006.Caption = "CancelUpdate"
		Me.cmdMethod_006.TabIndex = 51
		'
		' cmdMethod_005
		'
		Me.cmdMethod_005.Name = "cmdMethod_005"
		Me.cmdMethod_005.Size = New System.Drawing.Size(89, 25)
		Me.cmdMethod_005.Location = New System.Drawing.Point(104, 368)
		Me.cmdMethod_005.Caption = "CancelBatch"
		Me.cmdMethod_005.TabIndex = 50
		'
		' cmdMethod_004
		'
		Me.cmdMethod_004.Name = "cmdMethod_004"
		Me.cmdMethod_004.Size = New System.Drawing.Size(97, 25)
		Me.cmdMethod_004.Location = New System.Drawing.Point(320, 368)
		Me.cmdMethod_004.Caption = "Cancel"
		Me.cmdMethod_004.TabIndex = 49
		'
		' cmdMethod_002
		'
		Me.cmdMethod_002.Name = "cmdMethod_002"
		Me.cmdMethod_002.Size = New System.Drawing.Size(65, 25)
		Me.cmdMethod_002.Location = New System.Drawing.Point(120, 304)
		Me.cmdMethod_002.Caption = "AddNew"
		Me.cmdMethod_002.TabIndex = 48
		'
		' lstCustomProperties
		'
		Me.lstCustomProperties.Name = "lstCustomProperties"
		Me.lstCustomProperties.Size = New System.Drawing.Size(233, 132)
		Me.lstCustomProperties.Location = New System.Drawing.Point(320, 104)
		Me.lstCustomProperties.Sorted = True
		Me.lstCustomProperties.TabIndex = 35
		'
		' tabRecordset
		'
		Me.tabRecordset.Name = "tabRecordset"
		Me.tabRecordset.Size = New System.Drawing.Size(305, 289)
		Me.tabRecordset.Location = New System.Drawing.Point(8, 8)
		Me.tabRecordset.TabIndex = 8
		Me.tabRecordset.Tab = 0
		'
		' tabRecordset_TabPage0
		'
		Me.tabRecordset_TabPage0.Name = "tabRecordset_TabPage0"
		Me.tabRecordset_TabPage0.Text = "Closed RS props"
		Me.tabRecordset_TabPage0.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' lblProperty_010
		'
		Me.lblProperty_010.Name = "lblProperty_010"
		Me.lblProperty_010.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_010.Location = New System.Drawing.Point(8, 164)
		Me.lblProperty_010.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_010.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_010.Caption = "MaxRecords"
		Me.lblProperty_010.TabIndex = 15
		'
		' lblProperty_009
		'
		Me.lblProperty_009.Name = "lblProperty_009"
		Me.lblProperty_009.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_009.Location = New System.Drawing.Point(8, 140)
		Me.lblProperty_009.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_009.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_009.Caption = "LockType"
		Me.lblProperty_009.TabIndex = 16
		'
		' lblProperty_008
		'
		Me.lblProperty_008.Name = "lblProperty_008"
		Me.lblProperty_008.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_008.Location = New System.Drawing.Point(8, 116)
		Me.lblProperty_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_008.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_008.Caption = "Filter"
		Me.lblProperty_008.TabIndex = 17
		'
		' lblProperty_002
		'
		Me.lblProperty_002.Name = "lblProperty_002"
		Me.lblProperty_002.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_002.Location = New System.Drawing.Point(8, 92)
		Me.lblProperty_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_002.Caption = "CursorType"
		Me.lblProperty_002.TabIndex = 18
		'
		' lblProperty_006
		'
		Me.lblProperty_006.Name = "lblProperty_006"
		Me.lblProperty_006.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_006.Location = New System.Drawing.Point(8, 68)
		Me.lblProperty_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_006.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_006.Caption = "CursorLocation"
		Me.lblProperty_006.TabIndex = 19
		'
		' lblProperty_004
		'
		Me.lblProperty_004.Name = "lblProperty_004"
		Me.lblProperty_004.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_004.Location = New System.Drawing.Point(8, 44)
		Me.lblProperty_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_004.Caption = "CacheSize"
		Me.lblProperty_004.TabIndex = 20
		'
		' lblProperty_013
		'
		Me.lblProperty_013.Name = "lblProperty_013"
		Me.lblProperty_013.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_013.Location = New System.Drawing.Point(8, 20)
		Me.lblProperty_013.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_013.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_013.Caption = "ActiveConnection"
		Me.lblProperty_013.TabIndex = 32
		'
		' lblProperty_012
		'
		Me.lblProperty_012.Name = "lblProperty_012"
		Me.lblProperty_012.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_012.Location = New System.Drawing.Point(8, 188)
		Me.lblProperty_012.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_012.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_012.Caption = "Sort"
		Me.lblProperty_012.TabIndex = 43
		'
		' lblProperty_018
		'
		Me.lblProperty_018.Name = "lblProperty_018"
		Me.lblProperty_018.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_018.Location = New System.Drawing.Point(8, 212)
		Me.lblProperty_018.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_018.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_018.Caption = "Source"
		Me.lblProperty_018.TabIndex = 47
		'
		' txtMaxRecords
		'
		Me.txtMaxRecords.Name = "txtMaxRecords"
		Me.txtMaxRecords.Size = New System.Drawing.Size(161, 24)
		Me.txtMaxRecords.Location = New System.Drawing.Point(136, 164)
		Me.txtMaxRecords.TabIndex = 9
		'
		' cboLockType
		'
		Me.cboLockType.Name = "cboLockType"
		Me.cboLockType.Size = New System.Drawing.Size(161, 24)
		Me.cboLockType.Location = New System.Drawing.Point(136, 140)
		Me.cboLockType.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboLockType.TabIndex = 10
		'
		' txtFilter
		'
		Me.txtFilter.Name = "txtFilter"
		Me.txtFilter.Size = New System.Drawing.Size(161, 24)
		Me.txtFilter.Location = New System.Drawing.Point(136, 116)
		Me.txtFilter.TabIndex = 11
		'
		' cboCursorType
		'
		Me.cboCursorType.Name = "cboCursorType"
		Me.cboCursorType.Size = New System.Drawing.Size(161, 24)
		Me.cboCursorType.Location = New System.Drawing.Point(136, 92)
		Me.cboCursorType.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboCursorType.TabIndex = 12
		'
		' cboCursorLocation
		'
		Me.cboCursorLocation.Name = "cboCursorLocation"
		Me.cboCursorLocation.Size = New System.Drawing.Size(161, 24)
		Me.cboCursorLocation.Location = New System.Drawing.Point(136, 68)
		Me.cboCursorLocation.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboCursorLocation.TabIndex = 13
		'
		' txtCacheSize
		'
		Me.txtCacheSize.Name = "txtCacheSize"
		Me.txtCacheSize.Size = New System.Drawing.Size(161, 24)
		Me.txtCacheSize.Location = New System.Drawing.Point(136, 44)
		Me.txtCacheSize.TabIndex = 14
		'
		' txtActiveConnection
		'
		Me.txtActiveConnection.Name = "txtActiveConnection"
		Me.txtActiveConnection.Size = New System.Drawing.Size(161, 24)
		Me.txtActiveConnection.Location = New System.Drawing.Point(136, 20)
		Me.txtActiveConnection.TabIndex = 31
		'
		' txtSort
		'
		Me.txtSort.Name = "txtSort"
		Me.txtSort.Size = New System.Drawing.Size(161, 24)
		Me.txtSort.Location = New System.Drawing.Point(136, 188)
		Me.txtSort.TabIndex = 42
		'
		' txtSource
		'
		Me.txtSource.Name = "txtSource"
		Me.txtSource.Size = New System.Drawing.Size(161, 24)
		Me.txtSource.Location = New System.Drawing.Point(136, 212)
		Me.txtSource.TabIndex = 46
		'
		' tabRecordset_TabPage1
		'
		Me.tabRecordset_TabPage1.Name = "tabRecordset_TabPage1"
		Me.tabRecordset_TabPage1.Text = "Open RS props"
		Me.tabRecordset_TabPage1.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' lblProperty_000
		'
		Me.lblProperty_000.Name = "lblProperty_000"
		Me.lblProperty_000.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_000.Location = New System.Drawing.Point(8, 20)
		Me.lblProperty_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_000.Caption = "AbsolutePage"
		Me.lblProperty_000.TabIndex = 22
		'
		' lblProperty_007
		'
		Me.lblProperty_007.Name = "lblProperty_007"
		Me.lblProperty_007.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_007.Location = New System.Drawing.Point(8, 116)
		Me.lblProperty_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_007.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_007.Caption = "EditMode"
		Me.lblProperty_007.TabIndex = 25
		'
		' lblProperty_001
		'
		Me.lblProperty_001.Name = "lblProperty_001"
		Me.lblProperty_001.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_001.Location = New System.Drawing.Point(8, 44)
		Me.lblProperty_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_001.Caption = "AbsolutePosition"
		Me.lblProperty_001.TabIndex = 26
		'
		' lblProperty_005
		'
		Me.lblProperty_005.Name = "lblProperty_005"
		Me.lblProperty_005.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_005.Location = New System.Drawing.Point(8, 140)
		Me.lblProperty_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_005.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_005.Caption = "EOF"
		Me.lblProperty_005.TabIndex = 29
		'
		' lblProperty_003
		'
		Me.lblProperty_003.Name = "lblProperty_003"
		Me.lblProperty_003.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_003.Location = New System.Drawing.Point(8, 68)
		Me.lblProperty_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_003.Caption = "BOF"
		Me.lblProperty_003.TabIndex = 30
		'
		' lblProperty_014
		'
		Me.lblProperty_014.Name = "lblProperty_014"
		Me.lblProperty_014.Size = New System.Drawing.Size(129, 24)
		Me.lblProperty_014.Location = New System.Drawing.Point(8, 92)
		Me.lblProperty_014.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_014.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_014.Caption = "Bookmark"
		Me.lblProperty_014.TabIndex = 33
		'
		' lblProperty_011
		'
		Me.lblProperty_011.Name = "lblProperty_011"
		Me.lblProperty_011.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_011.Location = New System.Drawing.Point(8, 164)
		Me.lblProperty_011.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_011.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_011.Caption = "PageCount"
		Me.lblProperty_011.TabIndex = 36
		'
		' lblProperty_015
		'
		Me.lblProperty_015.Name = "lblProperty_015"
		Me.lblProperty_015.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_015.Location = New System.Drawing.Point(8, 188)
		Me.lblProperty_015.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_015.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_015.Caption = "PageSize"
		Me.lblProperty_015.TabIndex = 38
		'
		' lblProperty_016
		'
		Me.lblProperty_016.Name = "lblProperty_016"
		Me.lblProperty_016.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_016.Location = New System.Drawing.Point(8, 212)
		Me.lblProperty_016.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_016.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_016.Caption = "RecordCount"
		Me.lblProperty_016.TabIndex = 40
		'
		' lblProperty_017
		'
		Me.lblProperty_017.Name = "lblProperty_017"
		Me.lblProperty_017.Size = New System.Drawing.Size(129, 25)
		Me.lblProperty_017.Location = New System.Drawing.Point(8, 236)
		Me.lblProperty_017.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblProperty_017.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblProperty_017.Caption = "State"
		Me.lblProperty_017.TabIndex = 44
		'
		' cboAbsolutePage
		'
		Me.cboAbsolutePage.Name = "cboAbsolutePage"
		Me.cboAbsolutePage.Size = New System.Drawing.Size(161, 24)
		Me.cboAbsolutePage.Location = New System.Drawing.Point(136, 20)
		Me.cboAbsolutePage.TabIndex = 21
		'
		' cboEditMode
		'
		Me.cboEditMode.Name = "cboEditMode"
		Me.cboEditMode.Size = New System.Drawing.Size(161, 24)
		Me.cboEditMode.Location = New System.Drawing.Point(136, 116)
		Me.cboEditMode.Locked6 = True
		Me.cboEditMode.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboEditMode.TabIndex = 23
		'
		' cboAbsolutePosition
		'
		Me.cboAbsolutePosition.Name = "cboAbsolutePosition"
		Me.cboAbsolutePosition.Size = New System.Drawing.Size(161, 24)
		Me.cboAbsolutePosition.Location = New System.Drawing.Point(137, 44)
		Me.cboAbsolutePosition.TabIndex = 24
		'
		' cboEOF
		'
		Me.cboEOF.Name = "cboEOF"
		Me.cboEOF.Size = New System.Drawing.Size(161, 24)
		Me.cboEOF.Location = New System.Drawing.Point(136, 140)
		Me.cboEOF.Locked6 = True
		Me.cboEOF.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboEOF.TabIndex = 27
		'
		' cboBOF
		'
		Me.cboBOF.Name = "cboBOF"
		Me.cboBOF.Size = New System.Drawing.Size(161, 24)
		Me.cboBOF.Location = New System.Drawing.Point(136, 68)
		Me.cboBOF.Locked6 = True
		Me.cboBOF.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboBOF.TabIndex = 28
		'
		' txtBookmark
		'
		Me.txtBookmark.Name = "txtBookmark"
		Me.txtBookmark.Size = New System.Drawing.Size(161, 25)
		Me.txtBookmark.Location = New System.Drawing.Point(136, 92)
		Me.txtBookmark.TabIndex = 34
		'
		' txtPageCount
		'
		Me.txtPageCount.Name = "txtPageCount"
		Me.txtPageCount.Size = New System.Drawing.Size(161, 25)
		Me.txtPageCount.Location = New System.Drawing.Point(136, 164)
		Me.txtPageCount.ReadOnly = True
		Me.txtPageCount.TabIndex = 37
		'
		' txtPageSize
		'
		Me.txtPageSize.Name = "txtPageSize"
		Me.txtPageSize.Size = New System.Drawing.Size(161, 25)
		Me.txtPageSize.Location = New System.Drawing.Point(136, 188)
		Me.txtPageSize.ReadOnly = True
		Me.txtPageSize.TabIndex = 39
		'
		' txtRecordCount
		'
		Me.txtRecordCount.Name = "txtRecordCount"
		Me.txtRecordCount.Size = New System.Drawing.Size(161, 25)
		Me.txtRecordCount.Location = New System.Drawing.Point(136, 212)
		Me.txtRecordCount.ReadOnly = True
		Me.txtRecordCount.TabIndex = 41
		'
		' cboState
		'
		Me.cboState.Name = "cboState"
		Me.cboState.Size = New System.Drawing.Size(161, 24)
		Me.cboState.Location = New System.Drawing.Point(136, 236)
		Me.cboState.Locked6 = True
		Me.cboState.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboState.TabIndex = 45
		'
		' cmdClear
		'
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.Size = New System.Drawing.Size(57, 25)
		Me.cmdClear.Location = New System.Drawing.Point(504, 400)
		Me.cmdClear.Caption = "Clear"
		Me.cmdClear.TabIndex = 7
		'
		' txtEvents
		'
		Me.txtEvents.Name = "txtEvents"
		Me.txtEvents.Size = New System.Drawing.Size(489, 81)
		Me.txtEvents.Location = New System.Drawing.Point(8, 400)
		Me.txtEvents.MultiLine = -1
		Me.txtEvents.ScrollBars = CodeArchitects.VB6Library.VBRUN.ScrollBarConstants.vbBoth
		Me.txtEvents.TabIndex = 6
		'
		' cmdMethod_001
		'
		Me.cmdMethod_001.Name = "cmdMethod_001"
		Me.cmdMethod_001.Size = New System.Drawing.Size(57, 25)
		Me.cmdMethod_001.Location = New System.Drawing.Point(64, 304)
		Me.cmdMethod_001.Caption = "Close"
		Me.cmdMethod_001.TabIndex = 5
		'
		' cmdMethod_000
		'
		Me.cmdMethod_000.Name = "cmdMethod_000"
		Me.cmdMethod_000.Size = New System.Drawing.Size(57, 25)
		Me.cmdMethod_000.Location = New System.Drawing.Point(8, 304)
		Me.cmdMethod_000.Caption = "Open"
		Me.cmdMethod_000.TabIndex = 4
		'
		' cmdSetProperties
		'
		Me.cmdSetProperties.Name = "cmdSetProperties"
		Me.cmdSetProperties.Size = New System.Drawing.Size(121, 25)
		Me.cmdSetProperties.Location = New System.Drawing.Point(320, 8)
		Me.cmdSetProperties.Caption = "Set &Properties"
		Me.cmdSetProperties.TabIndex = 3
		'
		' cmdSet
		'
		Me.cmdSet.Name = "cmdSet"
		Me.cmdSet.Size = New System.Drawing.Size(57, 25)
		Me.cmdSet.Location = New System.Drawing.Point(496, 72)
		Me.cmdSet.Caption = "&Set"
		Me.cmdSet.TabIndex = 2
		'
		' txtCustomProperty
		'
		Me.txtCustomProperty.Name = "txtCustomProperty"
		Me.txtCustomProperty.Size = New System.Drawing.Size(177, 25)
		Me.txtCustomProperty.Location = New System.Drawing.Point(320, 72)
		Me.txtCustomProperty.TabIndex = 0
		'
		' lblCustomProperty
		'
		Me.lblCustomProperty.Name = "lblCustomProperty"
		Me.lblCustomProperty.Size = New System.Drawing.Size(233, 25)
		Me.lblCustomProperty.Location = New System.Drawing.Point(320, 48)
		Me.lblCustomProperty.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblCustomProperty.Caption = "Custom Properties"
		Me.lblCustomProperty.TabIndex = 1
		'
		' frmRecordset
		'
		Me.Name = "frmRecordset"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Recordset"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(564, 481)

		Me.Controls.Add(cmdMethod_020)
		Me.Controls.Add(cmdMethod_019)
		Me.Controls.Add(cmdMethod_018)
		Me.Controls.Add(cmdMethod_017)
		Me.Controls.Add(cmdMethod_016)
		Me.Controls.Add(cmdMethod_015)
		Me.Controls.Add(cmdMethod_014)
		Me.Controls.Add(cmdShowRecords)
		Me.Controls.Add(cmdShowFields)
		Me.Controls.Add(cmdMethod_008)
		Me.Controls.Add(cmdMethod_009)
		Me.Controls.Add(cmdMethod_010)
		Me.Controls.Add(cmdMethod_007)
		Me.Controls.Add(cmdMethod_011)
		Me.Controls.Add(cmdMethod_013)
		Me.Controls.Add(cmdMethod_003)
		Me.Controls.Add(cmdMethod_012)
		Me.Controls.Add(cmdMethod_006)
		Me.Controls.Add(cmdMethod_005)
		Me.Controls.Add(cmdMethod_004)
		Me.Controls.Add(cmdMethod_002)
		Me.Controls.Add(lstCustomProperties)
		Me.Controls.Add(tabRecordset)
		Me.tabRecordset.Controls.Add(tabRecordset_TabPage0)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_010)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_009)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_008)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_002)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_006)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_004)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_013)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_012)
		Me.tabRecordset_TabPage0.Controls.Add(lblProperty_018)
		Me.tabRecordset_TabPage0.Controls.Add(txtMaxRecords)
		Me.tabRecordset_TabPage0.Controls.Add(cboLockType)
		Me.tabRecordset_TabPage0.Controls.Add(txtFilter)
		Me.tabRecordset_TabPage0.Controls.Add(cboCursorType)
		Me.tabRecordset_TabPage0.Controls.Add(cboCursorLocation)
		Me.tabRecordset_TabPage0.Controls.Add(txtCacheSize)
		Me.tabRecordset_TabPage0.Controls.Add(txtActiveConnection)
		Me.tabRecordset_TabPage0.Controls.Add(txtSort)
		Me.tabRecordset_TabPage0.Controls.Add(txtSource)
		Me.tabRecordset.Controls.Add(tabRecordset_TabPage1)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_000)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_007)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_001)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_005)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_003)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_014)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_011)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_015)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_016)
		Me.tabRecordset_TabPage1.Controls.Add(lblProperty_017)
		Me.tabRecordset_TabPage1.Controls.Add(cboAbsolutePage)
		Me.tabRecordset_TabPage1.Controls.Add(cboEditMode)
		Me.tabRecordset_TabPage1.Controls.Add(cboAbsolutePosition)
		Me.tabRecordset_TabPage1.Controls.Add(cboEOF)
		Me.tabRecordset_TabPage1.Controls.Add(cboBOF)
		Me.tabRecordset_TabPage1.Controls.Add(txtBookmark)
		Me.tabRecordset_TabPage1.Controls.Add(txtPageCount)
		Me.tabRecordset_TabPage1.Controls.Add(txtPageSize)
		Me.tabRecordset_TabPage1.Controls.Add(txtRecordCount)
		Me.tabRecordset_TabPage1.Controls.Add(cboState)
		Me.Controls.Add(cmdClear)
		Me.Controls.Add(txtEvents)
		Me.Controls.Add(cmdMethod_001)
		Me.Controls.Add(cmdMethod_000)
		Me.Controls.Add(cmdSetProperties)
		Me.Controls.Add(cmdSet)
		Me.Controls.Add(txtCustomProperty)
		Me.Controls.Add(lblCustomProperty)
		CType(Me.tabRecordset, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabRecordset.ResumeLayout(False)
		Me.tabRecordset_TabPage0.ResumeLayout(False)
		Me.tabRecordset_TabPage1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
