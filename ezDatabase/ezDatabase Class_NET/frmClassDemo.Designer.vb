<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmClassDemo
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
		Me.txtField = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtField_001, txtField_000)
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
	Public txtField As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public WithEvents cmdConnect As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents fraInfo As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdExport As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtTableNum As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdTableName As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCase As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRequest As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPassword As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUsername As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCTNumber As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdCTName As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdConnected As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDatabase As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRecordCount As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdEOF As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboType3 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdBOF As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblInfo As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblCL As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents fraMove As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdLastTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdPrevTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdNextTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFirstTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdAdd As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtField_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtField_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtIP As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtDomain As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cmdUpdate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboType2 As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdMoveLast As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMovePrev As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMoveNext As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdMoveFirst As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lblTableName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblIPAdd As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDomainAdd As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDomainIP As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDomain As CodeArchitects.VB6Library.VB6Label
	Public WithEvents cboType As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents fraFind As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdLast As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdResult As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkAuto As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents cmdClear As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lstResults As CodeArchitects.VB6Library.VB6ListBox
	Public WithEvents cmdFindAll As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFindLast As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFindPrev As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFindNext As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdFindFirst As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkCase As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtQuery As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents cboField As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents lblQuery As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDesc As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmClassDemo))
		Me.cmdConnect = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraInfo = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdExport = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtTableNum = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdTableName = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCase = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRequest = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPassword = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUsername = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCTNumber = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdCTName = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdConnected = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDatabase = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRecordCount = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdEOF = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboType3 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdBOF = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblInfo = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCL = New CodeArchitects.VB6Library.VB6Label()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.fraMove = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdLastTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdPrevTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdNextTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFirstTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdAdd = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtField_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtField_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtIP = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtDomain = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmdUpdate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboType2 = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdMoveLast = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMovePrev = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMoveNext = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdMoveFirst = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lblTableName = New CodeArchitects.VB6Library.VB6Label()
		Me.lblIPAdd = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDomainAdd = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDomainIP = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDomain = New CodeArchitects.VB6Library.VB6Label()
		Me.cboType = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.fraFind = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdLast = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdResult = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkAuto = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.cmdClear = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lstResults = New CodeArchitects.VB6Library.VB6ListBox()
		Me.cmdFindAll = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFindLast = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFindPrev = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFindNext = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdFindFirst = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkCase = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtQuery = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cboField = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.lblQuery = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDesc = New CodeArchitects.VB6Library.VB6Label()
		Me.fraInfo.SuspendLayout()
		Me.fraMove.SuspendLayout()
		Me.fraFind.SuspendLayout()
		Me.SuspendLayout()
		'
		' cmdConnect
		'
		Me.cmdConnect.Name = "cmdConnect"
		Me.cmdConnect.Size = New System.Drawing.Size(145, 25)
		Me.cmdConnect.Location = New System.Drawing.Point(504, 488)
		Me.cmdConnect.Caption = "Connect To Database"
		Me.cmdConnect.TabIndex = 49
		Me.cmdConnect.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraInfo
		'
		Me.fraInfo.Name = "fraInfo"
		Me.fraInfo.Size = New System.Drawing.Size(641, 145)
		Me.fraInfo.Location = New System.Drawing.Point(8, 336)
		Me.fraInfo.Caption = "ezDatabase Information Commands"
		Me.fraInfo.TabIndex = 31
		Me.fraInfo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdExport
		'
		Me.cmdExport.Name = "cmdExport"
		Me.cmdExport.Size = New System.Drawing.Size(201, 25)
		Me.cmdExport.Location = New System.Drawing.Point(8, 112)
		Me.cmdExport.Caption = "Export To HTML"
		Me.cmdExport.TabIndex = 58
		Me.cmdExport.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtTableNum
		'
		Me.txtTableNum.Name = "txtTableNum"
		Me.txtTableNum.Size = New System.Drawing.Size(33, 25)
		Me.txtTableNum.Location = New System.Drawing.Point(584, 16)
		Me.txtTableNum.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtTableNum.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtTableNum.TabIndex = 48
		Me.txtTableNum.Text = "0"
		'
		' cmdTableName
		'
		Me.cmdTableName.Name = "cmdTableName"
		Me.cmdTableName.Size = New System.Drawing.Size(137, 25)
		Me.cmdTableName.Location = New System.Drawing.Point(448, 16)
		Me.cmdTableName.Caption = "Table Name By Number"
		Me.cmdTableName.TabIndex = 47
		Me.cmdTableName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdTable
		'
		Me.cmdTable.Name = "cmdTable"
		Me.cmdTable.Size = New System.Drawing.Size(201, 25)
		Me.cmdTable.Location = New System.Drawing.Point(8, 88)
		Me.cmdTable.Caption = "Table Count"
		Me.cmdTable.TabIndex = 46
		Me.cmdTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCase
		'
		Me.cmdCase.Name = "cmdCase"
		Me.cmdCase.Size = New System.Drawing.Size(105, 25)
		Me.cmdCase.Location = New System.Drawing.Point(328, 88)
		Me.cmdCase.Caption = "Case Sensitive"
		Me.cmdCase.TabIndex = 39
		Me.cmdCase.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdRequest
		'
		Me.cmdRequest.Name = "cmdRequest"
		Me.cmdRequest.Size = New System.Drawing.Size(113, 25)
		Me.cmdRequest.Location = New System.Drawing.Point(216, 88)
		Me.cmdRequest.Caption = "Last Request Type"
		Me.cmdRequest.TabIndex = 45
		Me.cmdRequest.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdPassword
		'
		Me.cmdPassword.Name = "cmdPassword"
		Me.cmdPassword.Size = New System.Drawing.Size(105, 25)
		Me.cmdPassword.Location = New System.Drawing.Point(328, 64)
		Me.cmdPassword.Caption = "Get Password"
		Me.cmdPassword.TabIndex = 44
		Me.cmdPassword.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdUsername
		'
		Me.cmdUsername.Name = "cmdUsername"
		Me.cmdUsername.Size = New System.Drawing.Size(113, 25)
		Me.cmdUsername.Location = New System.Drawing.Point(216, 64)
		Me.cmdUsername.Caption = "Get Username"
		Me.cmdUsername.TabIndex = 43
		Me.cmdUsername.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCTNumber
		'
		Me.cmdCTNumber.Name = "cmdCTNumber"
		Me.cmdCTNumber.Size = New System.Drawing.Size(105, 25)
		Me.cmdCTNumber.Location = New System.Drawing.Point(328, 40)
		Me.cmdCTNumber.Caption = "Current Table Num"
		Me.cmdCTNumber.TabIndex = 42
		Me.cmdCTNumber.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdCTName
		'
		Me.cmdCTName.Name = "cmdCTName"
		Me.cmdCTName.Size = New System.Drawing.Size(113, 25)
		Me.cmdCTName.Location = New System.Drawing.Point(216, 40)
		Me.cmdCTName.Caption = "Current Table Name"
		Me.cmdCTName.TabIndex = 41
		Me.cmdCTName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdConnected
		'
		Me.cmdConnected.Name = "cmdConnected"
		Me.cmdConnected.Size = New System.Drawing.Size(105, 25)
		Me.cmdConnected.Location = New System.Drawing.Point(328, 16)
		Me.cmdConnected.Caption = "Connection State"
		Me.cmdConnected.TabIndex = 40
		Me.cmdConnected.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdDatabase
		'
		Me.cmdDatabase.Name = "cmdDatabase"
		Me.cmdDatabase.Size = New System.Drawing.Size(113, 25)
		Me.cmdDatabase.Location = New System.Drawing.Point(216, 16)
		Me.cmdDatabase.Caption = "Database Location"
		Me.cmdDatabase.TabIndex = 38
		Me.cmdDatabase.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdRecordCount
		'
		Me.cmdRecordCount.Name = "cmdRecordCount"
		Me.cmdRecordCount.Size = New System.Drawing.Size(201, 25)
		Me.cmdRecordCount.Location = New System.Drawing.Point(8, 64)
		Me.cmdRecordCount.Caption = "Record Count"
		Me.cmdRecordCount.TabIndex = 36
		Me.cmdRecordCount.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdEOF
		'
		Me.cmdEOF.Name = "cmdEOF"
		Me.cmdEOF.Size = New System.Drawing.Size(97, 25)
		Me.cmdEOF.Location = New System.Drawing.Point(112, 40)
		Me.cmdEOF.Caption = "End Of File"
		Me.cmdEOF.TabIndex = 35
		Me.cmdEOF.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cboType3
		'
		Me.cboType3.Name = "cboType3"
		Me.cboType3.Size = New System.Drawing.Size(201, 24)
		Me.cboType3.Location = New System.Drawing.Point(8, 16)
		Me.cboType3.TabIndex = 34
		Me.cboType3.Text = "Select Information Type (Optional)"
		Me.cboType3.ItemDataValues = "Current\ Table\r0\rAll\ Tables\r0"
		'
		' cmdBOF
		'
		Me.cmdBOF.Name = "cmdBOF"
		Me.cmdBOF.Size = New System.Drawing.Size(105, 25)
		Me.cmdBOF.Location = New System.Drawing.Point(8, 40)
		Me.cmdBOF.Caption = "Beginning Of File"
		Me.cmdBOF.TabIndex = 33
		Me.cmdBOF.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblInfo
		'
		Me.lblInfo.Name = "lblInfo"
		Me.lblInfo.Size = New System.Drawing.Size(153, 65)
		Me.lblInfo.Location = New System.Drawing.Point(480, 64)
		Me.lblInfo.TabIndex = 57
		Me.lblInfo.AutoSize = False
		Me.lblInfo.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblCL
		'
		Me.lblCL.Name = "lblCL"
		Me.lblCL.Size = New System.Drawing.Size(105, 17)
		Me.lblCL.Location = New System.Drawing.Point(480, 48)
		Me.lblCL.Caption = "Current Location:"
		Me.lblCL.TabIndex = 56
		Me.lblCL.AutoSize = False
		Me.lblCL.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(65, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(576, 248)
		Me.cmdDelete.Caption = "Delete"
		Me.cmdDelete.TabIndex = 21
		Me.cmdDelete.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fraMove
		'
		Me.fraMove.Name = "fraMove"
		Me.fraMove.Size = New System.Drawing.Size(641, 129)
		Me.fraMove.Location = New System.Drawing.Point(8, 200)
		Me.fraMove.Caption = "ezDatabase Move/Update/AddNew/Delete Functions"
		Me.fraMove.TabIndex = 14
		Me.fraMove.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdLastTable
		'
		Me.cmdLastTable.Name = "cmdLastTable"
		Me.cmdLastTable.Size = New System.Drawing.Size(73, 25)
		Me.cmdLastTable.Location = New System.Drawing.Point(96, 72)
		Me.cmdLastTable.Caption = "Last Table"
		Me.cmdLastTable.TabIndex = 53
		Me.cmdLastTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdPrevTable
		'
		Me.cmdPrevTable.Name = "cmdPrevTable"
		Me.cmdPrevTable.Size = New System.Drawing.Size(89, 25)
		Me.cmdPrevTable.Location = New System.Drawing.Point(8, 72)
		Me.cmdPrevTable.Caption = "Previous Table"
		Me.cmdPrevTable.TabIndex = 52
		Me.cmdPrevTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdNextTable
		'
		Me.cmdNextTable.Name = "cmdNextTable"
		Me.cmdNextTable.Size = New System.Drawing.Size(73, 25)
		Me.cmdNextTable.Location = New System.Drawing.Point(96, 48)
		Me.cmdNextTable.Caption = "Next Table"
		Me.cmdNextTable.TabIndex = 51
		Me.cmdNextTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFirstTable
		'
		Me.cmdFirstTable.Name = "cmdFirstTable"
		Me.cmdFirstTable.Size = New System.Drawing.Size(89, 25)
		Me.cmdFirstTable.Location = New System.Drawing.Point(8, 48)
		Me.cmdFirstTable.Caption = "First Table"
		Me.cmdFirstTable.TabIndex = 50
		Me.cmdFirstTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdAdd
		'
		Me.cmdAdd.Name = "cmdAdd"
		Me.cmdAdd.Size = New System.Drawing.Size(89, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(544, 88)
		Me.cmdAdd.Caption = "Add Record"
		Me.cmdAdd.TabIndex = 30
		Me.cmdAdd.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtField_001
		'
		Me.txtField_001.Name = "txtField_001"
		Me.txtField_001.Size = New System.Drawing.Size(105, 24)
		Me.txtField_001.Location = New System.Drawing.Point(432, 88)
		Me.txtField_001.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtField_001.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtField_001.TabIndex = 29
		'
		' txtField_000
		'
		Me.txtField_000.Name = "txtField_000"
		Me.txtField_000.Size = New System.Drawing.Size(105, 24)
		Me.txtField_000.Location = New System.Drawing.Point(248, 88)
		Me.txtField_000.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtField_000.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtField_000.TabIndex = 27
		'
		' txtIP
		'
		Me.txtIP.Name = "txtIP"
		Me.txtIP.Size = New System.Drawing.Size(105, 24)
		Me.txtIP.Location = New System.Drawing.Point(432, 16)
		Me.txtIP.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtIP.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtIP.TabIndex = 25
		'
		' txtDomain
		'
		Me.txtDomain.Name = "txtDomain"
		Me.txtDomain.Size = New System.Drawing.Size(105, 24)
		Me.txtDomain.Location = New System.Drawing.Point(248, 16)
		Me.txtDomain.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtDomain.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtDomain.TabIndex = 23
		'
		' cmdUpdate
		'
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdUpdate.Size = New System.Drawing.Size(65, 25)
		Me.cmdUpdate.Location = New System.Drawing.Point(504, 48)
		Me.cmdUpdate.Caption = "Update"
		Me.cmdUpdate.TabIndex = 20
		Me.cmdUpdate.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cboType2
		'
		Me.cboType2.Name = "cboType2"
		Me.cboType2.Size = New System.Drawing.Size(161, 24)
		Me.cboType2.Location = New System.Drawing.Point(8, 16)
		Me.cboType2.TabIndex = 19
		Me.cboType2.Text = "Select Move Type (Optional)"
		Me.cboType2.ItemDataValues = "Move\ in\ Current\ Table\r0\rMove\ in\ All\ Tables\r0"
		'
		' cmdMoveLast
		'
		Me.cmdMoveLast.Name = "cmdMoveLast"
		Me.cmdMoveLast.Size = New System.Drawing.Size(73, 25)
		Me.cmdMoveLast.Location = New System.Drawing.Point(432, 48)
		Me.cmdMoveLast.Caption = "Move Last"
		Me.cmdMoveLast.TabIndex = 18
		Me.cmdMoveLast.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMovePrev
		'
		Me.cmdMovePrev.Name = "cmdMovePrev"
		Me.cmdMovePrev.Size = New System.Drawing.Size(89, 25)
		Me.cmdMovePrev.Location = New System.Drawing.Point(344, 48)
		Me.cmdMovePrev.Caption = "Move Previous"
		Me.cmdMovePrev.TabIndex = 17
		Me.cmdMovePrev.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMoveNext
		'
		Me.cmdMoveNext.Name = "cmdMoveNext"
		Me.cmdMoveNext.Size = New System.Drawing.Size(81, 25)
		Me.cmdMoveNext.Location = New System.Drawing.Point(264, 48)
		Me.cmdMoveNext.Caption = "Move Next"
		Me.cmdMoveNext.TabIndex = 16
		Me.cmdMoveNext.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdMoveFirst
		'
		Me.cmdMoveFirst.Name = "cmdMoveFirst"
		Me.cmdMoveFirst.Size = New System.Drawing.Size(89, 25)
		Me.cmdMoveFirst.Location = New System.Drawing.Point(176, 48)
		Me.cmdMoveFirst.Caption = "Move First"
		Me.cmdMoveFirst.TabIndex = 15
		Me.cmdMoveFirst.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblTableName
		'
		Me.lblTableName.Name = "lblTableName"
		Me.lblTableName.Size = New System.Drawing.Size(161, 17)
		Me.lblTableName.Location = New System.Drawing.Point(8, 104)
		Me.lblTableName.Caption = "Current Table:"
		Me.lblTableName.TabIndex = 54
		Me.lblTableName.AutoSize = False
		Me.lblTableName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblIPAdd
		'
		Me.lblIPAdd.Name = "lblIPAdd"
		Me.lblIPAdd.Size = New System.Drawing.Size(73, 17)
		Me.lblIPAdd.Location = New System.Drawing.Point(360, 91)
		Me.lblIPAdd.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblIPAdd.Caption = "Domain's IP:"
		Me.lblIPAdd.TabIndex = 28
		Me.lblIPAdd.AutoSize = False
		Me.lblIPAdd.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDomainAdd
		'
		Me.lblDomainAdd.Name = "lblDomainAdd"
		Me.lblDomainAdd.Size = New System.Drawing.Size(73, 17)
		Me.lblDomainAdd.Location = New System.Drawing.Point(176, 91)
		Me.lblDomainAdd.Caption = "Domain Name:"
		Me.lblDomainAdd.TabIndex = 26
		Me.lblDomainAdd.AutoSize = False
		Me.lblDomainAdd.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDomainIP
		'
		Me.lblDomainIP.Name = "lblDomainIP"
		Me.lblDomainIP.Size = New System.Drawing.Size(73, 17)
		Me.lblDomainIP.Location = New System.Drawing.Point(360, 19)
		Me.lblDomainIP.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblDomainIP.Caption = "Domain's IP:"
		Me.lblDomainIP.TabIndex = 24
		Me.lblDomainIP.AutoSize = False
		Me.lblDomainIP.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDomain
		'
		Me.lblDomain.Name = "lblDomain"
		Me.lblDomain.Size = New System.Drawing.Size(73, 17)
		Me.lblDomain.Location = New System.Drawing.Point(176, 19)
		Me.lblDomain.Caption = "Domain Name:"
		Me.lblDomain.TabIndex = 22
		Me.lblDomain.AutoSize = False
		Me.lblDomain.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cboType
		'
		Me.cboType.Name = "cboType"
		Me.cboType.Size = New System.Drawing.Size(193, 24)
		Me.cboType.Location = New System.Drawing.Point(16, 56)
		Me.cboType.TabIndex = 9
		Me.cboType.Text = "---- Select Find Type (Optional) ----"
		Me.cboType.ItemDataValues = "Find\ in\ Current\ Table\r0\rFind\ in\ All\ Tables\r0"
		'
		' fraFind
		'
		Me.fraFind.Name = "fraFind"
		Me.fraFind.Size = New System.Drawing.Size(641, 185)
		Me.fraFind.Location = New System.Drawing.Point(8, 8)
		Me.fraFind.Caption = "ezDatabase Find Functions"
		Me.fraFind.TabIndex = 0
		Me.fraFind.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdLast
		'
		Me.cmdLast.Name = "cmdLast"
		Me.cmdLast.Size = New System.Drawing.Size(81, 25)
		Me.cmdLast.Location = New System.Drawing.Point(16, 128)
		Me.cmdLast.Caption = "Last Query"
		Me.cmdLast.TabIndex = 37
		Me.cmdLast.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdResult
		'
		Me.cmdResult.Name = "cmdResult"
		Me.cmdResult.Size = New System.Drawing.Size(81, 25)
		Me.cmdResult.Location = New System.Drawing.Point(16, 104)
		Me.cmdResult.Caption = "Query Result"
		Me.cmdResult.TabIndex = 32
		Me.cmdResult.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' chkAuto
		'
		Me.chkAuto.Name = "chkAuto"
		Me.chkAuto.Size = New System.Drawing.Size(89, 41)
		Me.chkAuto.Location = New System.Drawing.Point(112, 96)
		Me.chkAuto.Caption = "Auto-clear Results on Query"
		Me.chkAuto.TabIndex = 13
		Me.chkAuto.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdClear
		'
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.Size = New System.Drawing.Size(89, 25)
		Me.cmdClear.Location = New System.Drawing.Point(112, 152)
		Me.cmdClear.Caption = "Clear Results"
		Me.cmdClear.TabIndex = 12
		Me.cmdClear.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lstResults
		'
		Me.lstResults.Name = "lstResults"
		Me.lstResults.Size = New System.Drawing.Size(425, 100)
		Me.lstResults.Location = New System.Drawing.Point(208, 80)
		Me.lstResults.TabIndex = 11
		'
		' cmdFindAll
		'
		Me.cmdFindAll.Name = "cmdFindAll"
		Me.cmdFindAll.Size = New System.Drawing.Size(73, 25)
		Me.cmdFindAll.Location = New System.Drawing.Point(560, 48)
		Me.cmdFindAll.Caption = "Find All"
		Me.cmdFindAll.Enabled = False
		Me.cmdFindAll.TabIndex = 10
		Me.cmdFindAll.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFindLast
		'
		Me.cmdFindLast.Name = "cmdFindLast"
		Me.cmdFindLast.Size = New System.Drawing.Size(89, 25)
		Me.cmdFindLast.Location = New System.Drawing.Point(472, 48)
		Me.cmdFindLast.Caption = "Find Last"
		Me.cmdFindLast.Enabled = False
		Me.cmdFindLast.TabIndex = 8
		Me.cmdFindLast.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFindPrev
		'
		Me.cmdFindPrev.Name = "cmdFindPrev"
		Me.cmdFindPrev.Size = New System.Drawing.Size(97, 25)
		Me.cmdFindPrev.Location = New System.Drawing.Point(376, 48)
		Me.cmdFindPrev.Caption = "Find Previous"
		Me.cmdFindPrev.Enabled = False
		Me.cmdFindPrev.TabIndex = 7
		Me.cmdFindPrev.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFindNext
		'
		Me.cmdFindNext.Name = "cmdFindNext"
		Me.cmdFindNext.Size = New System.Drawing.Size(81, 25)
		Me.cmdFindNext.Location = New System.Drawing.Point(296, 48)
		Me.cmdFindNext.Caption = "Find Next"
		Me.cmdFindNext.Enabled = False
		Me.cmdFindNext.TabIndex = 6
		Me.cmdFindNext.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdFindFirst
		'
		Me.cmdFindFirst.Name = "cmdFindFirst"
		Me.cmdFindFirst.Size = New System.Drawing.Size(89, 25)
		Me.cmdFindFirst.Location = New System.Drawing.Point(208, 48)
		Me.cmdFindFirst.Caption = "Find First"
		Me.cmdFindFirst.Enabled = False
		Me.cmdFindFirst.TabIndex = 5
		Me.cmdFindFirst.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' chkCase
		'
		Me.chkCase.Name = "chkCase"
		Me.chkCase.Size = New System.Drawing.Size(97, 25)
		Me.chkCase.Location = New System.Drawing.Point(528, 16)
		Me.chkCase.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.chkCase.Caption = "Case Sensitive"
		Me.chkCase.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.chkCase.TabIndex = 4
		Me.chkCase.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtQuery
		'
		Me.txtQuery.Name = "txtQuery"
		Me.txtQuery.Size = New System.Drawing.Size(233, 25)
		Me.txtQuery.Location = New System.Drawing.Point(280, 16)
		Me.txtQuery.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.txtQuery.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.txtQuery.TabIndex = 3
		Me.txtQuery.Text = "yahoo.com"
		'
		' cboField
		'
		Me.cboField.Name = "cboField"
		Me.cboField.Size = New System.Drawing.Size(193, 24)
		Me.cboField.Location = New System.Drawing.Point(8, 16)
		Me.cboField.TabIndex = 1
		Me.cboField.Text = "-------- Select Field to Query -------"
		Me.cboField.ItemDataValues = "Domain\r0\rDomainIP\r0"
		'
		' lblQuery
		'
		Me.lblQuery.Name = "lblQuery"
		Me.lblQuery.Size = New System.Drawing.Size(65, 17)
		Me.lblQuery.Location = New System.Drawing.Point(208, 19)
		Me.lblQuery.Caption = "Find Record:"
		Me.lblQuery.TabIndex = 2
		Me.lblQuery.AutoSize = False
		Me.lblQuery.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDesc
		'
		Me.lblDesc.Name = "lblDesc"
		Me.lblDesc.Size = New System.Drawing.Size(489, 73)
		Me.lblDesc.Location = New System.Drawing.Point(8, 488)
		Me.lblDesc.Caption = "Nearly all of the ""ezDatabase"" class functions are used; however, some are left out due to the specific use of this demo. Documentation on all uses of functions and events will soon be written. In the mean time, try connecting to the database and try out the various features. All buttons are fully commented."
		Me.lblDesc.TabIndex = 55
		Me.lblDesc.AutoSize = False
		Me.lblDesc.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' frmClassDemo
		'
		Me.Name = "frmClassDemo"
		Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "ezDatabase Class Application Demo"
		Me.MaxButton = False
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 30)
		Me.ClientSize = New System.Drawing.Size(656, 576)

		Me.Controls.Add(cmdConnect)
		Me.Controls.Add(fraInfo)
		Me.fraInfo.Controls.Add(cmdExport)
		Me.fraInfo.Controls.Add(txtTableNum)
		Me.fraInfo.Controls.Add(cmdTableName)
		Me.fraInfo.Controls.Add(cmdTable)
		Me.fraInfo.Controls.Add(cmdCase)
		Me.fraInfo.Controls.Add(cmdRequest)
		Me.fraInfo.Controls.Add(cmdPassword)
		Me.fraInfo.Controls.Add(cmdUsername)
		Me.fraInfo.Controls.Add(cmdCTNumber)
		Me.fraInfo.Controls.Add(cmdCTName)
		Me.fraInfo.Controls.Add(cmdConnected)
		Me.fraInfo.Controls.Add(cmdDatabase)
		Me.fraInfo.Controls.Add(cmdRecordCount)
		Me.fraInfo.Controls.Add(cmdEOF)
		Me.fraInfo.Controls.Add(cboType3)
		Me.fraInfo.Controls.Add(cmdBOF)
		Me.fraInfo.Controls.Add(lblInfo)
		Me.fraInfo.Controls.Add(lblCL)
		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(fraMove)
		Me.fraMove.Controls.Add(cmdLastTable)
		Me.fraMove.Controls.Add(cmdPrevTable)
		Me.fraMove.Controls.Add(cmdNextTable)
		Me.fraMove.Controls.Add(cmdFirstTable)
		Me.fraMove.Controls.Add(cmdAdd)
		Me.fraMove.Controls.Add(txtField_001)
		Me.fraMove.Controls.Add(txtField_000)
		Me.fraMove.Controls.Add(txtIP)
		Me.fraMove.Controls.Add(txtDomain)
		Me.fraMove.Controls.Add(cmdUpdate)
		Me.fraMove.Controls.Add(cboType2)
		Me.fraMove.Controls.Add(cmdMoveLast)
		Me.fraMove.Controls.Add(cmdMovePrev)
		Me.fraMove.Controls.Add(cmdMoveNext)
		Me.fraMove.Controls.Add(cmdMoveFirst)
		Me.fraMove.Controls.Add(lblTableName)
		Me.fraMove.Controls.Add(lblIPAdd)
		Me.fraMove.Controls.Add(lblDomainAdd)
		Me.fraMove.Controls.Add(lblDomainIP)
		Me.fraMove.Controls.Add(lblDomain)
		Me.Controls.Add(cboType)
		Me.Controls.Add(fraFind)
		Me.fraFind.Controls.Add(cmdLast)
		Me.fraFind.Controls.Add(cmdResult)
		Me.fraFind.Controls.Add(chkAuto)
		Me.fraFind.Controls.Add(cmdClear)
		Me.fraFind.Controls.Add(lstResults)
		Me.fraFind.Controls.Add(cmdFindAll)
		Me.fraFind.Controls.Add(cmdFindLast)
		Me.fraFind.Controls.Add(cmdFindPrev)
		Me.fraFind.Controls.Add(cmdFindNext)
		Me.fraFind.Controls.Add(cmdFindFirst)
		Me.fraFind.Controls.Add(chkCase)
		Me.fraFind.Controls.Add(txtQuery)
		Me.fraFind.Controls.Add(cboField)
		Me.fraFind.Controls.Add(lblQuery)
		Me.Controls.Add(lblDesc)
		Me.fraInfo.ResumeLayout(False)
		Me.fraMove.ResumeLayout(False)
		Me.fraFind.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
