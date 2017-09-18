<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
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
	Public WithEvents cmdSplit As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cboCategories As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents cboSuppliers As CodeArchitects.VB6Library.VB6ComboBox
	Public WithEvents DataGrid1 As CodeArchitects.VB6LibraryOcx.VB6DataGrid
	Public WithEvents Adodc1 As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents lblStatus As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.cmdSplit = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cboCategories = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cboSuppliers = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.DataGrid1 = New CodeArchitects.VB6LibraryOcx.VB6DataGrid()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.lblStatus = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' cmdSplit
		'
		Me.cmdSplit.Name = "cmdSplit"
		Me.cmdSplit.Size = New System.Drawing.Size(57, 25)
		Me.cmdSplit.Location = New System.Drawing.Point(0, 0)
		Me.cmdSplit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSplit.Caption = "Split"
		Me.cmdSplit.TabIndex = 4
		'
		' cboCategories
		'
		Me.cboCategories.Name = "cboCategories"
		Me.cboCategories.Size = New System.Drawing.Size(81, 21)
		Me.cboCategories.Location = New System.Drawing.Point(152, 208)
		Me.cboCategories.Sorted = True
		Me.cboCategories.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboCategories.TabIndex = 2
		'
		' cboSuppliers
		'
		Me.cboSuppliers.Name = "cboSuppliers"
		Me.cboSuppliers.Size = New System.Drawing.Size(129, 21)
		Me.cboSuppliers.Location = New System.Drawing.Point(16, 208)
		Me.cboSuppliers.Sorted = True
		Me.cboSuppliers.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cboSuppliers.TabIndex = 1
		'
		' DataGrid1
		'
		Me.DataGrid1.Name = "DataGrid1"
		Me.DataGrid1.Size = New System.Drawing.Size(401, 185)
		Me.DataGrid1.Location = New System.Drawing.Point(0, 24)
		Me.DataGrid1.TabIndex = 0
		Me.DataGrid1.Tag = "DataSource=Adodc1;"
		Me.DataGrid1.OcxState = CType(resources.GetObject("DataGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(145, 25)
		Me.Adodc1.Location = New System.Drawing.Point(280, 208)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.Visible = False
		Me.Adodc1.ConnectMode = ADODB.ConnectModeEnum.adModeUnknown
		Me.Adodc1.CursorLocation = CodeArchitects.VB6Library.MSAdodcLib.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = CodeArchitects.VB6Library.MSAdodcLib.CursorTypeEnum.adOpenStatic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = CodeArchitects.VB6Library.MSAdodcLib.CommandTypeEnum.adCmdTable
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = CodeArchitects.VB6Library.MSAdodcLib.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.Adodc1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.Adodc1.Enabled = True
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = "Products"
		Me.Adodc1.Caption = "Adodc1"
		'
		' lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(281, 25)
		Me.lblStatus.Location = New System.Drawing.Point(56, 0)
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblStatus.Caption = "Select one or more rows to see here summary data"
		Me.lblStatus.TabIndex = 3
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Caption = "DataGrid control demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(440, 258)

		Me.Controls.Add(cmdSplit)
		Me.Controls.Add(cboCategories)
		Me.Controls.Add(cboSuppliers)
		Me.Controls.Add(DataGrid1)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(lblStatus)
		CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
