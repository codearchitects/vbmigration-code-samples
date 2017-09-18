<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRecord
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
		' Open recordsets exposed by DataEnvironment objects bound to controls
		DataEnvironment1_DefInstance.authors()
		InitializeComponent()
		' Initialize control arrays.
		Me.lblFieldLabel = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblFieldLabel_008, lblFieldLabel_007, lblFieldLabel_006, lblFieldLabel_005, lblFieldLabel_004, lblFieldLabel_003, lblFieldLabel_002, lblFieldLabel_001, lblFieldLabel_000)
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
	Public lblFieldLabel As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents cmdShowGrid As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdNext As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrevious As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkcontract As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtzip As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtstate As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtcity As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtaddress As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtphone As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtau_fname As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtau_lname As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtau_id As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblFieldLabel_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblFieldLabel_000 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents DataEnvironment1 As DataEnvironment1_Instance

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdShowGrid = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdNext = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrevious = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkcontract = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtzip = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtstate = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtcity = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtaddress = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtphone = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtau_fname = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtau_lname = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtau_id = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblFieldLabel_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblFieldLabel_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.DataEnvironment1 = New DataEnvironment1_Instance
		Me.SuspendLayout()
		'
		' cmdShowGrid
		'
		Me.cmdShowGrid.Name = "cmdShowGrid"
		Me.cmdShowGrid.Size = New System.Drawing.Size(73, 33)
		Me.cmdShowGrid.Location = New System.Drawing.Point(264, 256)
		Me.cmdShowGrid.Caption = "Show Grid"
		Me.cmdShowGrid.TabIndex = 20
		'
		' cmdNext
		'
		Me.cmdNext.Name = "cmdNext"
		Me.cmdNext.Size = New System.Drawing.Size(73, 33)
		Me.cmdNext.Location = New System.Drawing.Point(120, 256)
		Me.cmdNext.Caption = "Next"
		Me.cmdNext.TabIndex = 19
		'
		' cmdPrevious
		'
		Me.cmdPrevious.Name = "cmdPrevious"
		Me.cmdPrevious.Size = New System.Drawing.Size(73, 33)
		Me.cmdPrevious.Location = New System.Drawing.Point(40, 256)
		Me.cmdPrevious.Caption = "Previous"
		Me.cmdPrevious.TabIndex = 18
		'
		' chkcontract
		'
		Me.chkcontract.Name = "chkcontract"
		Me.chkcontract.Size = New System.Drawing.Size(22, 19)
		Me.chkcontract.Location = New System.Drawing.Point(128, 219)
		Me.chkcontract.DataField = "contract"
		Me.chkcontract.DataMember = "authors"
		Me.chkcontract.DataSource = DataEnvironment1
		Me.chkcontract.TabIndex = 17
		'
		' txtzip
		'
		Me.txtzip.Name = "txtzip"
		Me.txtzip.Size = New System.Drawing.Size(55, 24)
		Me.txtzip.Location = New System.Drawing.Point(123, 193)
		Me.txtzip.DataField = "zip"
		Me.txtzip.DataMember = "authors"
		Me.txtzip.DataSource = DataEnvironment1
		Me.txtzip.TabIndex = 15
		'
		' txtstate
		'
		Me.txtstate.Name = "txtstate"
		Me.txtstate.Size = New System.Drawing.Size(30, 24)
		Me.txtstate.Location = New System.Drawing.Point(123, 168)
		Me.txtstate.DataField = "state"
		Me.txtstate.DataMember = "authors"
		Me.txtstate.DataSource = DataEnvironment1
		Me.txtstate.TabIndex = 13
		'
		' txtcity
		'
		Me.txtcity.Name = "txtcity"
		Me.txtcity.Size = New System.Drawing.Size(220, 24)
		Me.txtcity.Location = New System.Drawing.Point(123, 143)
		Me.txtcity.DataField = "city"
		Me.txtcity.DataMember = "authors"
		Me.txtcity.DataSource = DataEnvironment1
		Me.txtcity.TabIndex = 11
		'
		' txtaddress
		'
		Me.txtaddress.Name = "txtaddress"
		Me.txtaddress.Size = New System.Drawing.Size(225, 24)
		Me.txtaddress.Location = New System.Drawing.Point(123, 117)
		Me.txtaddress.DataField = "address"
		Me.txtaddress.DataMember = "authors"
		Me.txtaddress.DataSource = DataEnvironment1
		Me.txtaddress.TabIndex = 9
		'
		' txtphone
		'
		Me.txtphone.Name = "txtphone"
		Me.txtphone.Size = New System.Drawing.Size(132, 24)
		Me.txtphone.Location = New System.Drawing.Point(123, 92)
		Me.txtphone.DataField = "phone"
		Me.txtphone.DataMember = "authors"
		Me.txtphone.DataSource = DataEnvironment1
		Me.txtphone.TabIndex = 7
		'
		' txtau_fname
		'
		Me.txtau_fname.Name = "txtau_fname"
		Me.txtau_fname.Size = New System.Drawing.Size(220, 24)
		Me.txtau_fname.Location = New System.Drawing.Point(123, 67)
		Me.txtau_fname.DataField = "au_fname"
		Me.txtau_fname.DataMember = "authors"
		Me.txtau_fname.DataSource = DataEnvironment1
		Me.txtau_fname.TabIndex = 5
		'
		' txtau_lname
		'
		Me.txtau_lname.Name = "txtau_lname"
		Me.txtau_lname.Size = New System.Drawing.Size(225, 24)
		Me.txtau_lname.Location = New System.Drawing.Point(123, 41)
		Me.txtau_lname.DataField = "au_lname"
		Me.txtau_lname.DataMember = "authors"
		Me.txtau_lname.DataSource = DataEnvironment1
		Me.txtau_lname.TabIndex = 3
		'
		' txtau_id
		'
		Me.txtau_id.Name = "txtau_id"
		Me.txtau_id.Size = New System.Drawing.Size(121, 24)
		Me.txtau_id.Location = New System.Drawing.Point(123, 16)
		Me.txtau_id.DataField = "au_id"
		Me.txtau_id.DataMember = "authors"
		Me.txtau_id.DataSource = DataEnvironment1
		Me.txtau_id.TabIndex = 1
		'
		' lblFieldLabel_008
		'
		Me.lblFieldLabel_008.Name = "lblFieldLabel_008"
		Me.lblFieldLabel_008.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_008.Location = New System.Drawing.Point(0, 222)
		Me.lblFieldLabel_008.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_008.AutoSize = True
		Me.lblFieldLabel_008.Caption = "contract:"
		Me.lblFieldLabel_008.TabIndex = 16
		'
		' lblFieldLabel_007
		'
		Me.lblFieldLabel_007.Name = "lblFieldLabel_007"
		Me.lblFieldLabel_007.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_007.Location = New System.Drawing.Point(0, 196)
		Me.lblFieldLabel_007.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_007.AutoSize = True
		Me.lblFieldLabel_007.Caption = "zip:"
		Me.lblFieldLabel_007.TabIndex = 14
		'
		' lblFieldLabel_006
		'
		Me.lblFieldLabel_006.Name = "lblFieldLabel_006"
		Me.lblFieldLabel_006.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_006.Location = New System.Drawing.Point(0, 171)
		Me.lblFieldLabel_006.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_006.AutoSize = True
		Me.lblFieldLabel_006.Caption = "state:"
		Me.lblFieldLabel_006.TabIndex = 12
		'
		' lblFieldLabel_005
		'
		Me.lblFieldLabel_005.Name = "lblFieldLabel_005"
		Me.lblFieldLabel_005.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_005.Location = New System.Drawing.Point(0, 146)
		Me.lblFieldLabel_005.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_005.AutoSize = True
		Me.lblFieldLabel_005.Caption = "city:"
		Me.lblFieldLabel_005.TabIndex = 10
		'
		' lblFieldLabel_004
		'
		Me.lblFieldLabel_004.Name = "lblFieldLabel_004"
		Me.lblFieldLabel_004.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_004.Location = New System.Drawing.Point(0, 120)
		Me.lblFieldLabel_004.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_004.AutoSize = True
		Me.lblFieldLabel_004.Caption = "address:"
		Me.lblFieldLabel_004.TabIndex = 8
		'
		' lblFieldLabel_003
		'
		Me.lblFieldLabel_003.Name = "lblFieldLabel_003"
		Me.lblFieldLabel_003.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_003.Location = New System.Drawing.Point(0, 95)
		Me.lblFieldLabel_003.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_003.AutoSize = True
		Me.lblFieldLabel_003.Caption = "phone:"
		Me.lblFieldLabel_003.TabIndex = 6
		'
		' lblFieldLabel_002
		'
		Me.lblFieldLabel_002.Name = "lblFieldLabel_002"
		Me.lblFieldLabel_002.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_002.Location = New System.Drawing.Point(0, 70)
		Me.lblFieldLabel_002.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_002.AutoSize = True
		Me.lblFieldLabel_002.Caption = "au_fname:"
		Me.lblFieldLabel_002.TabIndex = 4
		'
		' lblFieldLabel_001
		'
		Me.lblFieldLabel_001.Name = "lblFieldLabel_001"
		Me.lblFieldLabel_001.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_001.Location = New System.Drawing.Point(0, 44)
		Me.lblFieldLabel_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_001.AutoSize = True
		Me.lblFieldLabel_001.Caption = "au_lname:"
		Me.lblFieldLabel_001.TabIndex = 2
		'
		' lblFieldLabel_000
		'
		Me.lblFieldLabel_000.Name = "lblFieldLabel_000"
		Me.lblFieldLabel_000.Size = New System.Drawing.Size(121, 17)
		Me.lblFieldLabel_000.Location = New System.Drawing.Point(0, 19)
		Me.lblFieldLabel_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.lblFieldLabel_000.AutoSize = True
		Me.lblFieldLabel_000.Caption = "au_id:"
		Me.lblFieldLabel_000.TabIndex = 0
		'
		' frmRecord
		'
		Me.Name = "frmRecord"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "DataEnvironment Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(363, 293)

		Me.Controls.Add(cmdShowGrid)
		Me.Controls.Add(cmdNext)
		Me.Controls.Add(cmdPrevious)
		Me.Controls.Add(chkcontract)
		Me.Controls.Add(txtzip)
		Me.Controls.Add(txtstate)
		Me.Controls.Add(txtcity)
		Me.Controls.Add(txtaddress)
		Me.Controls.Add(txtphone)
		Me.Controls.Add(txtau_fname)
		Me.Controls.Add(txtau_lname)
		Me.Controls.Add(txtau_id)
		Me.Controls.Add(lblFieldLabel_008)
		Me.Controls.Add(lblFieldLabel_007)
		Me.Controls.Add(lblFieldLabel_006)
		Me.Controls.Add(lblFieldLabel_005)
		Me.Controls.Add(lblFieldLabel_004)
		Me.Controls.Add(lblFieldLabel_003)
		Me.Controls.Add(lblFieldLabel_002)
		Me.Controls.Add(lblFieldLabel_001)
		Me.Controls.Add(lblFieldLabel_000)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
