<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmArguments
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
		Me.chkMissing = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)(chkMissing_004, chkMissing_003, chkMissing_002, chkMissing_001, chkMissing_000)
		Me.txtArgument = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtArgument_004, txtArgument_003, txtArgument_002, txtArgument_001, txtArgument_000)
		Me.lblArgName = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblArgName_004, lblArgName_003, lblArgName_002, lblArgName_001, lblArgName_000)
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
	Public chkMissing As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6CheckBox)
	Public txtArgument As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public lblArgName As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRun As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkMissing_004 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtArgument_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkMissing_003 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtArgument_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkMissing_002 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtArgument_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkMissing_001 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtArgument_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents chkMissing_000 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtArgument_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblArgName_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblArgName_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblArgName_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblArgName_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblArgName_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRun = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkMissing_004 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtArgument_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkMissing_003 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtArgument_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkMissing_002 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtArgument_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkMissing_001 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtArgument_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.chkMissing_000 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtArgument_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblArgName_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblArgName_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblArgName_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblArgName_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblArgName_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(256, 256)
		Me.cmdCancel.Caption = "Cancel"
		Me.cmdCancel.TabIndex = 16
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' cmdRun
		'
		Me.cmdRun.Name = "cmdRun"
		Me.cmdRun.Size = New System.Drawing.Size(81, 25)
		Me.cmdRun.Location = New System.Drawing.Point(136, 256)
		Me.cmdRun.Caption = "&Run"
		Me.cmdRun.TabIndex = 15
		Me.AcceptButton = Me.cmdRun
		Me.cmdRun.DialogResult = System.Windows.Forms.DialogResult.None
		'
		' chkMissing_004
		'
		Me.chkMissing_004.Name = "chkMissing_004"
		Me.chkMissing_004.Size = New System.Drawing.Size(177, 16)
		Me.chkMissing_004.Location = New System.Drawing.Point(136, 200)
		Me.chkMissing_004.Caption = "Missing"
		Me.chkMissing_004.TabIndex = 14
		'
		' txtArgument_004
		'
		Me.txtArgument_004.Name = "txtArgument_004"
		Me.txtArgument_004.Size = New System.Drawing.Size(289, 25)
		Me.txtArgument_004.Location = New System.Drawing.Point(136, 216)
		Me.txtArgument_004.TabIndex = 13
		'
		' chkMissing_003
		'
		Me.chkMissing_003.Name = "chkMissing_003"
		Me.chkMissing_003.Size = New System.Drawing.Size(177, 16)
		Me.chkMissing_003.Location = New System.Drawing.Point(136, 152)
		Me.chkMissing_003.Caption = "Missing"
		Me.chkMissing_003.TabIndex = 11
		'
		' txtArgument_003
		'
		Me.txtArgument_003.Name = "txtArgument_003"
		Me.txtArgument_003.Size = New System.Drawing.Size(289, 25)
		Me.txtArgument_003.Location = New System.Drawing.Point(136, 168)
		Me.txtArgument_003.TabIndex = 10
		'
		' chkMissing_002
		'
		Me.chkMissing_002.Name = "chkMissing_002"
		Me.chkMissing_002.Size = New System.Drawing.Size(177, 16)
		Me.chkMissing_002.Location = New System.Drawing.Point(136, 104)
		Me.chkMissing_002.Caption = "Missing"
		Me.chkMissing_002.TabIndex = 8
		'
		' txtArgument_002
		'
		Me.txtArgument_002.Name = "txtArgument_002"
		Me.txtArgument_002.Size = New System.Drawing.Size(289, 25)
		Me.txtArgument_002.Location = New System.Drawing.Point(136, 120)
		Me.txtArgument_002.TabIndex = 7
		'
		' chkMissing_001
		'
		Me.chkMissing_001.Name = "chkMissing_001"
		Me.chkMissing_001.Size = New System.Drawing.Size(177, 16)
		Me.chkMissing_001.Location = New System.Drawing.Point(136, 56)
		Me.chkMissing_001.Caption = "Missing"
		Me.chkMissing_001.TabIndex = 5
		'
		' txtArgument_001
		'
		Me.txtArgument_001.Name = "txtArgument_001"
		Me.txtArgument_001.Size = New System.Drawing.Size(289, 25)
		Me.txtArgument_001.Location = New System.Drawing.Point(136, 72)
		Me.txtArgument_001.TabIndex = 4
		'
		' chkMissing_000
		'
		Me.chkMissing_000.Name = "chkMissing_000"
		Me.chkMissing_000.Size = New System.Drawing.Size(177, 16)
		Me.chkMissing_000.Location = New System.Drawing.Point(136, 8)
		Me.chkMissing_000.Caption = "Missing"
		Me.chkMissing_000.TabIndex = 2
		'
		' txtArgument_000
		'
		Me.txtArgument_000.Name = "txtArgument_000"
		Me.txtArgument_000.Size = New System.Drawing.Size(289, 25)
		Me.txtArgument_000.Location = New System.Drawing.Point(136, 24)
		Me.txtArgument_000.TabIndex = 1
		'
		' lblArgName_004
		'
		Me.lblArgName_004.Name = "lblArgName_004"
		Me.lblArgName_004.Size = New System.Drawing.Size(129, 25)
		Me.lblArgName_004.Location = New System.Drawing.Point(8, 216)
		Me.lblArgName_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblArgName_004.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblArgName_004.Caption = "Arg1"
		Me.lblArgName_004.TabIndex = 12
		'
		' lblArgName_003
		'
		Me.lblArgName_003.Name = "lblArgName_003"
		Me.lblArgName_003.Size = New System.Drawing.Size(129, 25)
		Me.lblArgName_003.Location = New System.Drawing.Point(8, 168)
		Me.lblArgName_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblArgName_003.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblArgName_003.Caption = "Arg1"
		Me.lblArgName_003.TabIndex = 9
		'
		' lblArgName_002
		'
		Me.lblArgName_002.Name = "lblArgName_002"
		Me.lblArgName_002.Size = New System.Drawing.Size(129, 25)
		Me.lblArgName_002.Location = New System.Drawing.Point(8, 120)
		Me.lblArgName_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblArgName_002.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblArgName_002.Caption = "Arg1"
		Me.lblArgName_002.TabIndex = 6
		'
		' lblArgName_001
		'
		Me.lblArgName_001.Name = "lblArgName_001"
		Me.lblArgName_001.Size = New System.Drawing.Size(129, 25)
		Me.lblArgName_001.Location = New System.Drawing.Point(8, 72)
		Me.lblArgName_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblArgName_001.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblArgName_001.Caption = "Arg1"
		Me.lblArgName_001.TabIndex = 3
		'
		' lblArgName_000
		'
		Me.lblArgName_000.Name = "lblArgName_000"
		Me.lblArgName_000.Size = New System.Drawing.Size(129, 25)
		Me.lblArgName_000.Location = New System.Drawing.Point(8, 24)
		Me.lblArgName_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblArgName_000.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblArgName_000.Caption = "Arg1"
		Me.lblArgName_000.TabIndex = 0
		'
		' frmArguments
		'
		Me.Name = "frmArguments"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Get Arguments"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(437, 287)

		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdRun)
		Me.Controls.Add(chkMissing_004)
		Me.Controls.Add(txtArgument_004)
		Me.Controls.Add(chkMissing_003)
		Me.Controls.Add(txtArgument_003)
		Me.Controls.Add(chkMissing_002)
		Me.Controls.Add(txtArgument_002)
		Me.Controls.Add(chkMissing_001)
		Me.Controls.Add(txtArgument_001)
		Me.Controls.Add(chkMissing_000)
		Me.Controls.Add(txtArgument_000)
		Me.Controls.Add(lblArgName_004)
		Me.Controls.Add(lblArgName_003)
		Me.Controls.Add(lblArgName_002)
		Me.Controls.Add(lblArgName_001)
		Me.Controls.Add(lblArgName_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
