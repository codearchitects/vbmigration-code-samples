<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSQLServerDocumenter
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
	Public WithEvents fmeAbout As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents dlgExport As CodeArchitects.VB6Library.VB6CommonDialog
	Public WithEvents lblAbout As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fmeExport As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdPreviewPrint As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdExport2XLS As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents lsvTableData As CodeArchitects.VB6Library.VB6ListView
	Public WithEvents fmeDatabaseTable As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents cmdShowIndexes As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdShowTable As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboTableName As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboDatabaseName As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents lblTable As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblDatabase As CodeArchitects.VB6Library.VB6Label
	Public WithEvents fmeConnection As CodeArchitects.VB6Library.VB6Frame
	Public WithEvents imlConnectionStatus As CodeArchitects.VB6Library.VB6ImageList
	Public WithEvents picConnectionStatus As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cboSQLServerList As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cmdConnect As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents optSQLAuth As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents optWinAuth As CodeArchitects.VB6Library.VB6OptionButton
	Public WithEvents txtPassword As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUserName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblPassword As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblUserName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblServerName As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lsvTableData_Control As System.Windows.Forms.ListView

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSQLServerDocumenter))
		Me.fmeAbout = New CodeArchitects.VB6Library.VB6Frame()
		Me.dlgExport = New CodeArchitects.VB6Library.VB6CommonDialog()
		Me.lblAbout = New CodeArchitects.VB6Library.VB6Label()
		Me.fmeExport = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdPreviewPrint = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdExport2XLS = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.lsvTableData = New CodeArchitects.VB6Library.VB6ListView()
		Me.fmeDatabaseTable = New CodeArchitects.VB6Library.VB6Frame()
		Me.cmdShowIndexes = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdShowTable = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboTableName = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboDatabaseName = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.lblTable = New CodeArchitects.VB6Library.VB6Label()
		Me.lblDatabase = New CodeArchitects.VB6Library.VB6Label()
		Me.fmeConnection = New CodeArchitects.VB6Library.VB6Frame()
		Me.imlConnectionStatus = New CodeArchitects.VB6Library.VB6ImageList()
		Me.picConnectionStatus = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cboSQLServerList = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmdConnect = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.optSQLAuth = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.optWinAuth = New CodeArchitects.VB6Library.VB6OptionButton()
		Me.txtPassword = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUserName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		Me.lblPassword = New CodeArchitects.VB6Library.VB6Label()
		Me.lblUserName = New CodeArchitects.VB6Library.VB6Label()
		Me.lblServerName = New CodeArchitects.VB6Library.VB6Label()
		Me.lsvTableData_Control = New System.Windows.Forms.ListView()
		Me.fmeAbout.SuspendLayout()
		Me.fmeExport.SuspendLayout()
		Me.fmeDatabaseTable.SuspendLayout()
		Me.fmeConnection.SuspendLayout()
		CType(Me.lsvTableData, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imlConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' fmeAbout
		'
		Me.fmeAbout.Name = "fmeAbout"
		Me.fmeAbout.Size = New System.Drawing.Size(417, 45)
		Me.fmeAbout.Location = New System.Drawing.Point(232, 404)
		Me.fmeAbout.Caption = "About"
		Me.fmeAbout.TabIndex = 21
		Me.fmeAbout.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' dlgExport
		'
		Me.dlgExport.Name = "dlgExport"
		Me.dlgExport.ParentForm = Me
		Me.dlgExport.Name6 = "dlgExport"
		'
		' lblAbout
		'
		Me.lblAbout.Name = "lblAbout"
		Me.lblAbout.Size = New System.Drawing.Size(401, 21)
		Me.lblAbout.Location = New System.Drawing.Point(8, 16)
		Me.lblAbout.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAbout.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbCenter
		Me.lblAbout.Caption = "Coding by RaiVeN for Da Londo Software"
		Me.lblAbout.ForeColor = FromOleColor6(CInt(&H00000000))
		Me.lblAbout.TabIndex = 22
		Me.lblAbout.AutoSize = False
		Me.lblAbout.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fmeExport
		'
		Me.fmeExport.Name = "fmeExport"
		Me.fmeExport.Size = New System.Drawing.Size(225, 45)
		Me.fmeExport.Location = New System.Drawing.Point(4, 404)
		Me.fmeExport.Caption = "Print/Export"
		Me.fmeExport.TabIndex = 16
		Me.fmeExport.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdPreviewPrint
		'
		Me.cmdPreviewPrint.Name = "cmdPreviewPrint"
		Me.cmdPreviewPrint.Size = New System.Drawing.Size(101, 21)
		Me.cmdPreviewPrint.Location = New System.Drawing.Point(8, 16)
		Me.cmdPreviewPrint.Caption = "Print Preview"
		Me.cmdPreviewPrint.TabIndex = 20
		Me.cmdPreviewPrint.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdExport2XLS
		'
		Me.cmdExport2XLS.Name = "cmdExport2XLS"
		Me.cmdExport2XLS.Size = New System.Drawing.Size(101, 21)
		Me.cmdExport2XLS.Location = New System.Drawing.Point(116, 16)
		Me.cmdExport2XLS.Caption = "Export To Excel"
		Me.cmdExport2XLS.TabIndex = 19
		Me.cmdExport2XLS.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lsvTableData
		'
		Me.lsvTableData.Name = "lsvTableData"
		Me.lsvTableData.Location = New System.Drawing.Point(4, 136)
		Me.lsvTableData.Size = New System.Drawing.Size(2, 2)
		Me.lsvTableData.ListView = Me.lsvTableData_Control
		'
		' fmeDatabaseTable
		'
		Me.fmeDatabaseTable.Name = "fmeDatabaseTable"
		Me.fmeDatabaseTable.Size = New System.Drawing.Size(329, 133)
		Me.fmeDatabaseTable.Location = New System.Drawing.Point(320, 0)
		Me.fmeDatabaseTable.Caption = "Select Database / Table"
		Me.fmeDatabaseTable.TabIndex = 1
		Me.fmeDatabaseTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdShowIndexes
		'
		Me.cmdShowIndexes.Name = "cmdShowIndexes"
		Me.cmdShowIndexes.Size = New System.Drawing.Size(101, 21)
		Me.cmdShowIndexes.Location = New System.Drawing.Point(220, 104)
		Me.cmdShowIndexes.Caption = "Show Indexes"
		Me.cmdShowIndexes.TabIndex = 24
		Me.cmdShowIndexes.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cmdShowTable
		'
		Me.cmdShowTable.Name = "cmdShowTable"
		Me.cmdShowTable.Size = New System.Drawing.Size(101, 21)
		Me.cmdShowTable.Location = New System.Drawing.Point(112, 104)
		Me.cmdShowTable.Caption = "Show Table"
		Me.cmdShowTable.TabIndex = 14
		Me.cmdShowTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cboTableName
		'
		Me.cboTableName.Name = "cboTableName"
		Me.cboTableName.Size = New System.Drawing.Size(313, 21)
		Me.cboTableName.Location = New System.Drawing.Point(8, 76)
		Me.cboTableName.TabIndex = 11
		'
		' cboDatabaseName
		'
		Me.cboDatabaseName.Name = "cboDatabaseName"
		Me.cboDatabaseName.Size = New System.Drawing.Size(313, 21)
		Me.cboDatabaseName.Location = New System.Drawing.Point(8, 32)
		Me.cboDatabaseName.TabIndex = 10
		'
		' lblTable
		'
		Me.lblTable.Name = "lblTable"
		Me.lblTable.Size = New System.Drawing.Size(165, 17)
		Me.lblTable.Location = New System.Drawing.Point(8, 60)
		Me.lblTable.Caption = "Table"
		Me.lblTable.TabIndex = 13
		Me.lblTable.AutoSize = False
		Me.lblTable.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblDatabase
		'
		Me.lblDatabase.Name = "lblDatabase"
		Me.lblDatabase.Size = New System.Drawing.Size(133, 17)
		Me.lblDatabase.Location = New System.Drawing.Point(8, 16)
		Me.lblDatabase.Caption = "Database"
		Me.lblDatabase.TabIndex = 12
		Me.lblDatabase.AutoSize = False
		Me.lblDatabase.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' fmeConnection
		'
		Me.fmeConnection.Name = "fmeConnection"
		Me.fmeConnection.Size = New System.Drawing.Size(313, 133)
		Me.fmeConnection.Location = New System.Drawing.Point(4, 0)
		Me.fmeConnection.Caption = "Connection"
		Me.fmeConnection.TabIndex = 0
		Me.fmeConnection.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' imlConnectionStatus
		'
		Me.imlConnectionStatus.Name = "imlConnectionStatus"
		Me.imlConnectionStatus.ParentForm = Me
		Me.imlConnectionStatus.Name6 = "imlConnectionStatus"
		Me.imlConnectionStatus.BackColor = FromOleColor6(CInt(-2147483643))
		Me.imlConnectionStatus.MaskColor = FromOleColor6(CInt(12632256))
		Me.imlConnectionStatus.ImageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.imlConnectionStatus.ImageStream = CType(resources.GetObject("imlConnectionStatus.ImageStream"), System.Windows.Forms.ImageListStreamer)
		'
		' picConnectionStatus
		'
		Me.picConnectionStatus.Name = "picConnectionStatus"
		Me.picConnectionStatus.Size = New System.Drawing.Size(21, 21)
		Me.picConnectionStatus.Location = New System.Drawing.Point(12, 108)
		Me.picConnectionStatus.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.picConnectionStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picConnectionStatus.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.picConnectionStatus.TabIndex = 23
		Me.picConnectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picConnectionStatus.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.picConnectionStatus.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' cboSQLServerList
		'
		Me.cboSQLServerList.Name = "cboSQLServerList"
		Me.cboSQLServerList.Size = New System.Drawing.Size(149, 21)
		Me.cboSQLServerList.Location = New System.Drawing.Point(8, 32)
		Me.cboSQLServerList.TabIndex = 17
		'
		' cmdConnect
		'
		Me.cmdConnect.Name = "cmdConnect"
		Me.cmdConnect.Size = New System.Drawing.Size(101, 21)
		Me.cmdConnect.Location = New System.Drawing.Point(204, 104)
		Me.cmdConnect.Caption = "Connect"
		Me.cmdConnect.Picture = CType(resources.GetObject("cmdConnect.Picture"), System.Drawing.Image)
		Me.cmdConnect.TabIndex = 9
		Me.cmdConnect.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optSQLAuth
		'
		Me.optSQLAuth.Name = "optSQLAuth"
		Me.optSQLAuth.Size = New System.Drawing.Size(153, 17)
		Me.optSQLAuth.Location = New System.Drawing.Point(8, 80)
		Me.optSQLAuth.Caption = "SQL Authentication"
		Me.optSQLAuth.TabIndex = 8
		Me.optSQLAuth.TabStop = True
		Me.optSQLAuth.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' optWinAuth
		'
		Me.optWinAuth.Name = "optWinAuth"
		Me.optWinAuth.Size = New System.Drawing.Size(149, 17)
		Me.optWinAuth.Location = New System.Drawing.Point(8, 60)
		Me.optWinAuth.Caption = "Windows Authentication"
		Me.optWinAuth.TabIndex = 7
		Me.optWinAuth.Value = True
		Me.optWinAuth.TabStop = True
		Me.optWinAuth.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' txtPassword
		'
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(125, 21)
		Me.txtPassword.Location = New System.Drawing.Point(180, 76)
		Me.txtPassword.PasswordChar_ = "*"
		Me.txtPassword.TabIndex = 6
		'
		' txtUserName
		'
		Me.txtUserName.Name = "txtUserName"
		Me.txtUserName.Size = New System.Drawing.Size(125, 21)
		Me.txtUserName.Location = New System.Drawing.Point(180, 32)
		Me.txtUserName.TabIndex = 3
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(169, 13)
		Me.lblStatus.Location = New System.Drawing.Point(32, 108)
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.Caption = "Not Connected"
		Me.lblStatus.TabIndex = 18
		Me.lblStatus.AutoSize = False
		Me.lblStatus.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblPassword
		'
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(125, 17)
		Me.lblPassword.Location = New System.Drawing.Point(180, 60)
		Me.lblPassword.Caption = "Password"
		Me.lblPassword.TabIndex = 5
		Me.lblPassword.AutoSize = False
		Me.lblPassword.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblUserName
		'
		Me.lblUserName.Name = "lblUserName"
		Me.lblUserName.Size = New System.Drawing.Size(93, 17)
		Me.lblUserName.Location = New System.Drawing.Point(180, 16)
		Me.lblUserName.Caption = "Username"
		Me.lblUserName.TabIndex = 4
		Me.lblUserName.AutoSize = False
		Me.lblUserName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lblServerName
		'
		Me.lblServerName.Name = "lblServerName"
		Me.lblServerName.Size = New System.Drawing.Size(109, 17)
		Me.lblServerName.Location = New System.Drawing.Point(8, 16)
		Me.lblServerName.Caption = "Servername"
		Me.lblServerName.TabIndex = 2
		Me.lblServerName.AutoSize = False
		Me.lblServerName.BackColor = FromOleColor6(CInt(&H8000000F))
		'
		' lsvTableData_Control
		'
		Me.lsvTableData_Control.Name = "lsvTableData_Control"
		Me.lsvTableData_Control.Size = New System.Drawing.Size(645, 265)
		Me.lsvTableData_Control.Location = New System.Drawing.Point(4, 136)
		Me.lsvTableData_Control.ShowItemToolTips = True
		Me.lsvTableData_Control.BackColor = FromOleColor6(CInt(-2147483643))
		Me.lsvTableData_Control.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.lsvTableData_Control.TabIndex = 15
		Me.lsvTableData_Control.FullRowSelect = True
		Me.lsvTableData_Control.GridLines = True
		Me.lsvTableData_Control.HideSelection = True
		Me.lsvTableData_Control.LabelWrap = True
		Me.lsvTableData_Control.Alignment = System.Windows.Forms.ListViewAlignment.Default
		Me.lsvTableData_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lsvTableData_Control.LabelEdit = False
		Me.lsvTableData_Control.MultiSelect = False
		Me.lsvTableData_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.lsvTableData_Control.BackgroundImageTiled = False
		'
		' frmSQLServerDocumenter
		'
		Me.Name = "frmSQLServerDocumenter"
		Me.Caption = "SQL Server Documenter"
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaxButton = False
		Me.Location = New System.Drawing.Point(212, 189)
		Me.ClientSize = New System.Drawing.Size(653, 453)

		Me.Controls.Add(fmeAbout)
		Me.fmeAbout.Controls.Add(lblAbout)
		Me.Controls.Add(fmeExport)
		Me.fmeExport.Controls.Add(cmdPreviewPrint)
		Me.fmeExport.Controls.Add(cmdExport2XLS)
		Me.Controls.Add(lsvTableData)
		Me.Controls.Add(fmeDatabaseTable)
		Me.fmeDatabaseTable.Controls.Add(cmdShowIndexes)
		Me.fmeDatabaseTable.Controls.Add(cmdShowTable)
		Me.fmeDatabaseTable.Controls.Add(cboTableName)
		Me.fmeDatabaseTable.Controls.Add(cboDatabaseName)
		Me.fmeDatabaseTable.Controls.Add(lblTable)
		Me.fmeDatabaseTable.Controls.Add(lblDatabase)
		Me.Controls.Add(fmeConnection)
		Me.fmeConnection.Controls.Add(picConnectionStatus)
		Me.fmeConnection.Controls.Add(cboSQLServerList)
		Me.fmeConnection.Controls.Add(cmdConnect)
		Me.fmeConnection.Controls.Add(optSQLAuth)
		Me.fmeConnection.Controls.Add(optWinAuth)
		Me.fmeConnection.Controls.Add(txtPassword)
		Me.fmeConnection.Controls.Add(txtUserName)
		Me.fmeConnection.Controls.Add(lblStatus)
		Me.fmeConnection.Controls.Add(lblPassword)
		Me.fmeConnection.Controls.Add(lblUserName)
		Me.fmeConnection.Controls.Add(lblServerName)
		Me.Controls.Add(lsvTableData_Control)
		CType(Me.lsvTableData, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imlConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fmeAbout.ResumeLayout(False)
		Me.fmeExport.ResumeLayout(False)
		Me.fmeDatabaseTable.ResumeLayout(False)
		Me.fmeConnection.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
