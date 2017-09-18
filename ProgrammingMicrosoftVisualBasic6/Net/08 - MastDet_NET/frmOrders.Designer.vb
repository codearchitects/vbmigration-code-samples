<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOrders
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
		Me.txtFields = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)(txtFields_013, txtFields_012, txtFields_011, txtFields_010, txtFields_009, txtFields_008, txtFields_007, txtFields_006, txtFields_005, txtFields_004, txtFields_003, txtFields_002, txtFields_001, txtFields_000)
		Me.lblLabels = New CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)(lblLabels_013, lblLabels_012, lblLabels_011, lblLabels_010, lblLabels_009, lblLabels_008, lblLabels_007, lblLabels_006, lblLabels_005, lblLabels_004, lblLabels_003, lblLabels_002, lblLabels_001, lblLabels_000)
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
	Public txtFields As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6TextBox)
	Public lblLabels As CodeArchitects.VB6Library.VB6ControlArray(Of CodeArchitects.VB6Library.VB6Label)
	Public WithEvents picButtons As CodeArchitects.VB6Library.VB6PictureBox
	Public WithEvents cmdClose As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdRefresh As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUpdate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents txtFields_013 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_012 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_011 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_010 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_009 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_008 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_007 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_006 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_005 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_004 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_003 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_002 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_001 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtFields_000 As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents datPrimaryRS As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents grdDataGrid As CodeArchitects.VB6LibraryOcx.VB6DataGrid
	Public WithEvents lblLabels_013 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_012 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_011 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_010 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_009 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_008 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_007 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_006 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_005 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_004 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_003 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_002 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_001 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblLabels_000 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOrders))
		Me.picButtons = New CodeArchitects.VB6Library.VB6PictureBox()
		Me.cmdClose = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdRefresh = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUpdate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.txtFields_013 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_012 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_011 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_010 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_009 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_008 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_007 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_006 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_005 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_004 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_003 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_002 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_001 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtFields_000 = New CodeArchitects.VB6Library.VB6TextBox()
		Me.datPrimaryRS = New CodeArchitects.VB6Library.VB6Adodc()
		Me.grdDataGrid = New CodeArchitects.VB6LibraryOcx.VB6DataGrid()
		Me.lblLabels_013 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_012 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_011 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_010 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_009 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_008 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_007 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_006 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_005 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_004 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_003 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_002 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_001 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblLabels_000 = New CodeArchitects.VB6Library.VB6Label()
		Me.picButtons.SuspendLayout()
		CType(Me.grdDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' picButtons
		'
		Me.picButtons.Name = "picButtons"
		Me.picButtons.Size = New System.Drawing.Size(383, 20)
		Me.picButtons.Location = New System.Drawing.Point(0, 393)
		Me.picButtons.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.picButtons.Appearance = CodeArchitects.VB6Library.VB6AppearanceConstants.Flat
		Me.picButtons.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.None
		Me.picButtons.ForeColor = FromOleColor6(CInt(&H80000008))
		Me.picButtons.TabIndex = 29
		Me.picButtons.BackColor = FromOleColor6(CInt(-2147483633))
		'
		' cmdClose
		'
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(73, 20)
		Me.cmdClose.Location = New System.Drawing.Point(160, 0)
		Me.cmdClose.Caption = "&Close"
		Me.cmdClose.TabIndex = 32
		'
		' cmdRefresh
		'
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.cmdRefresh.Size = New System.Drawing.Size(73, 20)
		Me.cmdRefresh.Location = New System.Drawing.Point(80, 0)
		Me.cmdRefresh.Caption = "&Refresh"
		Me.cmdRefresh.TabIndex = 31
		'
		' cmdUpdate
		'
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdUpdate.Size = New System.Drawing.Size(73, 20)
		Me.cmdUpdate.Location = New System.Drawing.Point(0, 0)
		Me.cmdUpdate.Caption = "&Update"
		Me.cmdUpdate.TabIndex = 30
		'
		' txtFields_013
		'
		Me.txtFields_013.Name = "txtFields_013"
		Me.txtFields_013.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_013.Location = New System.Drawing.Point(136, 281)
		Me.txtFields_013.DataField = "ShipVia"
		Me.txtFields_013.DataSource = datPrimaryRS
		Me.txtFields_013.TabIndex = 27
		'
		' txtFields_012
		'
		Me.txtFields_012.Name = "txtFields_012"
		Me.txtFields_012.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_012.Location = New System.Drawing.Point(136, 260)
		Me.txtFields_012.DataField = "ShipRegion"
		Me.txtFields_012.DataSource = datPrimaryRS
		Me.txtFields_012.TabIndex = 25
		'
		' txtFields_011
		'
		Me.txtFields_011.Name = "txtFields_011"
		Me.txtFields_011.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_011.Location = New System.Drawing.Point(136, 239)
		Me.txtFields_011.DataField = "ShipPostalCode"
		Me.txtFields_011.DataSource = datPrimaryRS
		Me.txtFields_011.TabIndex = 23
		'
		' txtFields_010
		'
		Me.txtFields_010.Name = "txtFields_010"
		Me.txtFields_010.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_010.Location = New System.Drawing.Point(136, 217)
		Me.txtFields_010.DataField = "ShippedDate"
		Me.txtFields_010.DataSource = datPrimaryRS
		Me.txtFields_010.TabIndex = 21
		'
		' txtFields_009
		'
		Me.txtFields_009.Name = "txtFields_009"
		Me.txtFields_009.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_009.Location = New System.Drawing.Point(136, 196)
		Me.txtFields_009.DataField = "ShipName"
		Me.txtFields_009.DataSource = datPrimaryRS
		Me.txtFields_009.TabIndex = 19
		'
		' txtFields_008
		'
		Me.txtFields_008.Name = "txtFields_008"
		Me.txtFields_008.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_008.Location = New System.Drawing.Point(136, 175)
		Me.txtFields_008.DataField = "ShipCountry"
		Me.txtFields_008.DataSource = datPrimaryRS
		Me.txtFields_008.TabIndex = 17
		'
		' txtFields_007
		'
		Me.txtFields_007.Name = "txtFields_007"
		Me.txtFields_007.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_007.Location = New System.Drawing.Point(136, 153)
		Me.txtFields_007.DataField = "ShipCity"
		Me.txtFields_007.DataSource = datPrimaryRS
		Me.txtFields_007.TabIndex = 15
		'
		' txtFields_006
		'
		Me.txtFields_006.Name = "txtFields_006"
		Me.txtFields_006.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_006.Location = New System.Drawing.Point(136, 132)
		Me.txtFields_006.DataField = "ShipAddress"
		Me.txtFields_006.DataSource = datPrimaryRS
		Me.txtFields_006.TabIndex = 13
		'
		' txtFields_005
		'
		Me.txtFields_005.Name = "txtFields_005"
		Me.txtFields_005.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_005.Location = New System.Drawing.Point(136, 111)
		Me.txtFields_005.DataField = "RequiredDate"
		Me.txtFields_005.DataSource = datPrimaryRS
		Me.txtFields_005.TabIndex = 11
		'
		' txtFields_004
		'
		Me.txtFields_004.Name = "txtFields_004"
		Me.txtFields_004.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_004.Location = New System.Drawing.Point(136, 89)
		Me.txtFields_004.DataField = "OrderID"
		Me.txtFields_004.DataSource = datPrimaryRS
		Me.txtFields_004.TabIndex = 9
		'
		' txtFields_003
		'
		Me.txtFields_003.Name = "txtFields_003"
		Me.txtFields_003.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_003.Location = New System.Drawing.Point(136, 68)
		Me.txtFields_003.DataField = "OrderDate"
		Me.txtFields_003.DataSource = datPrimaryRS
		Me.txtFields_003.TabIndex = 7
		'
		' txtFields_002
		'
		Me.txtFields_002.Name = "txtFields_002"
		Me.txtFields_002.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_002.Location = New System.Drawing.Point(136, 47)
		Me.txtFields_002.DataField = "Freight"
		Me.txtFields_002.DataSource = datPrimaryRS
		Me.txtFields_002.TabIndex = 5
		'
		' txtFields_001
		'
		Me.txtFields_001.Name = "txtFields_001"
		Me.txtFields_001.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_001.Location = New System.Drawing.Point(136, 25)
		Me.txtFields_001.DataField = "EmployeeID"
		Me.txtFields_001.DataSource = datPrimaryRS
		Me.txtFields_001.TabIndex = 3
		'
		' txtFields_000
		'
		Me.txtFields_000.Name = "txtFields_000"
		Me.txtFields_000.Size = New System.Drawing.Size(225, 19)
		Me.txtFields_000.Location = New System.Drawing.Point(136, 4)
		Me.txtFields_000.DataField = "CustomerID"
		Me.txtFields_000.DataSource = datPrimaryRS
		Me.txtFields_000.TabIndex = 1
		'
		' datPrimaryRS
		'
		Me.datPrimaryRS.Name = "datPrimaryRS"
		Me.datPrimaryRS.Size = New System.Drawing.Size(383, 22)
		Me.datPrimaryRS.Location = New System.Drawing.Point(0, 413)
		Me.datPrimaryRS.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.datPrimaryRS.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.datPrimaryRS.ConnectMode = ADODB.ConnectModeEnum.adModeUnknown
		Me.datPrimaryRS.CursorLocation = CodeArchitects.VB6Library.MSAdodcLib.CursorLocationEnum.adUseClient
		Me.datPrimaryRS.ConnectionTimeout = 15
		Me.datPrimaryRS.CommandTimeout = 30
		Me.datPrimaryRS.CursorType = CodeArchitects.VB6Library.MSAdodcLib.CursorTypeEnum.adOpenStatic
		Me.datPrimaryRS.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.datPrimaryRS.CommandType = CodeArchitects.VB6Library.MSAdodcLib.CommandTypeEnum.adCmdUnknown
		Me.datPrimaryRS.CacheSize = 50
		Me.datPrimaryRS.MaxRecords = 0
		Me.datPrimaryRS.BOFAction = CodeArchitects.VB6Library.MSAdodcLib.BOFActionEnum.adDoMoveFirst
		Me.datPrimaryRS.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adDoMoveLast
		Me.datPrimaryRS.BackColor = FromOleColor6(CInt(-2147483643))
		Me.datPrimaryRS.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.datPrimaryRS.Enabled = True
		Me.datPrimaryRS.Connect = "PROVIDER=MSDataShape;Data PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=c:\Program Files\Microsoft Visual Studio\VB98\nwind.mdb"
		Me.datPrimaryRS.UserName = ""
		Me.datPrimaryRS.Password = ""
		Me.datPrimaryRS.RecordSource = "SHAPE {select CustomerID,EmployeeID,Freight,OrderDate,OrderID,RequiredDate,ShipAddress,ShipCity,ShipCountry,ShipName,ShippedDate,ShipPostalCode,ShipRegion,ShipVia from Orders Order by OrderDate} AS ParentCMD APPEND ({select Discount,OrderID,ProductID,Quantity,UnitPrice from [Order Details] } AS ChildCMD RELATE OrderID TO OrderID) AS ChildCMD"
		Me.datPrimaryRS.Caption = " "
		'
		' grdDataGrid
		'
		Me.grdDataGrid.Name = "grdDataGrid"
		Me.grdDataGrid.Size = New System.Drawing.Size(384, 87)
		Me.grdDataGrid.Location = New System.Drawing.Point(0, 303)
		Me.grdDataGrid.TabIndex = 28
		Me.grdDataGrid.OcxState = CType(resources.GetObject("grdDataGrid.OcxState"), System.Windows.Forms.AxHost.State)
		'
		' lblLabels_013
		'
		Me.lblLabels_013.Name = "lblLabels_013"
		Me.lblLabels_013.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_013.Location = New System.Drawing.Point(8, 281)
		Me.lblLabels_013.Caption = "ShipVia:"
		Me.lblLabels_013.TabIndex = 26
		'
		' lblLabels_012
		'
		Me.lblLabels_012.Name = "lblLabels_012"
		Me.lblLabels_012.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_012.Location = New System.Drawing.Point(8, 260)
		Me.lblLabels_012.Caption = "ShipRegion:"
		Me.lblLabels_012.TabIndex = 24
		'
		' lblLabels_011
		'
		Me.lblLabels_011.Name = "lblLabels_011"
		Me.lblLabels_011.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_011.Location = New System.Drawing.Point(8, 239)
		Me.lblLabels_011.Caption = "ShipPostalCode:"
		Me.lblLabels_011.TabIndex = 22
		'
		' lblLabels_010
		'
		Me.lblLabels_010.Name = "lblLabels_010"
		Me.lblLabels_010.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_010.Location = New System.Drawing.Point(8, 217)
		Me.lblLabels_010.Caption = "ShippedDate:"
		Me.lblLabels_010.TabIndex = 20
		'
		' lblLabels_009
		'
		Me.lblLabels_009.Name = "lblLabels_009"
		Me.lblLabels_009.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_009.Location = New System.Drawing.Point(8, 196)
		Me.lblLabels_009.Caption = "ShipName:"
		Me.lblLabels_009.TabIndex = 18
		'
		' lblLabels_008
		'
		Me.lblLabels_008.Name = "lblLabels_008"
		Me.lblLabels_008.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_008.Location = New System.Drawing.Point(8, 175)
		Me.lblLabels_008.Caption = "ShipCountry:"
		Me.lblLabels_008.TabIndex = 16
		'
		' lblLabels_007
		'
		Me.lblLabels_007.Name = "lblLabels_007"
		Me.lblLabels_007.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_007.Location = New System.Drawing.Point(8, 153)
		Me.lblLabels_007.Caption = "ShipCity:"
		Me.lblLabels_007.TabIndex = 14
		'
		' lblLabels_006
		'
		Me.lblLabels_006.Name = "lblLabels_006"
		Me.lblLabels_006.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_006.Location = New System.Drawing.Point(8, 132)
		Me.lblLabels_006.Caption = "ShipAddress:"
		Me.lblLabels_006.TabIndex = 12
		'
		' lblLabels_005
		'
		Me.lblLabels_005.Name = "lblLabels_005"
		Me.lblLabels_005.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_005.Location = New System.Drawing.Point(8, 111)
		Me.lblLabels_005.Caption = "RequiredDate:"
		Me.lblLabels_005.TabIndex = 10
		'
		' lblLabels_004
		'
		Me.lblLabels_004.Name = "lblLabels_004"
		Me.lblLabels_004.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_004.Location = New System.Drawing.Point(8, 89)
		Me.lblLabels_004.Caption = "OrderID:"
		Me.lblLabels_004.TabIndex = 8
		'
		' lblLabels_003
		'
		Me.lblLabels_003.Name = "lblLabels_003"
		Me.lblLabels_003.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_003.Location = New System.Drawing.Point(8, 68)
		Me.lblLabels_003.Caption = "OrderDate:"
		Me.lblLabels_003.TabIndex = 6
		'
		' lblLabels_002
		'
		Me.lblLabels_002.Name = "lblLabels_002"
		Me.lblLabels_002.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_002.Location = New System.Drawing.Point(8, 47)
		Me.lblLabels_002.Caption = "Freight:"
		Me.lblLabels_002.TabIndex = 4
		'
		' lblLabels_001
		'
		Me.lblLabels_001.Name = "lblLabels_001"
		Me.lblLabels_001.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_001.Location = New System.Drawing.Point(8, 25)
		Me.lblLabels_001.Caption = "EmployeeID:"
		Me.lblLabels_001.TabIndex = 2
		'
		' lblLabels_000
		'
		Me.lblLabels_000.Name = "lblLabels_000"
		Me.lblLabels_000.Size = New System.Drawing.Size(121, 17)
		Me.lblLabels_000.Location = New System.Drawing.Point(8, 4)
		Me.lblLabels_000.Caption = "CustomerID:"
		Me.lblLabels_000.TabIndex = 0
		'
		' frmOrders
		'
		Me.Name = "frmOrders"
		Me.Caption = "Orders"
		Me.KeyPreview = True
		Me.Location = New System.Drawing.Point(74, 23)
		Me.ClientSize = New System.Drawing.Size(383, 435)

		Me.Controls.Add(picButtons)
		Me.picButtons.Controls.Add(cmdUpdate)
		Me.picButtons.Controls.Add(cmdRefresh)
		Me.picButtons.Controls.Add(cmdClose)
		Me.Controls.Add(txtFields_013)
		Me.Controls.Add(txtFields_012)
		Me.Controls.Add(txtFields_011)
		Me.Controls.Add(txtFields_010)
		Me.Controls.Add(txtFields_009)
		Me.Controls.Add(txtFields_008)
		Me.Controls.Add(txtFields_007)
		Me.Controls.Add(txtFields_006)
		Me.Controls.Add(txtFields_005)
		Me.Controls.Add(txtFields_004)
		Me.Controls.Add(txtFields_003)
		Me.Controls.Add(txtFields_002)
		Me.Controls.Add(txtFields_001)
		Me.Controls.Add(txtFields_000)
		Me.Controls.Add(datPrimaryRS)
		Me.Controls.Add(grdDataGrid)
		Me.Controls.Add(lblLabels_013)
		Me.Controls.Add(lblLabels_012)
		Me.Controls.Add(lblLabels_011)
		Me.Controls.Add(lblLabels_010)
		Me.Controls.Add(lblLabels_009)
		Me.Controls.Add(lblLabels_008)
		Me.Controls.Add(lblLabels_007)
		Me.Controls.Add(lblLabels_006)
		Me.Controls.Add(lblLabels_005)
		Me.Controls.Add(lblLabels_004)
		Me.Controls.Add(lblLabels_003)
		Me.Controls.Add(lblLabels_002)
		Me.Controls.Add(lblLabels_001)
		Me.Controls.Add(lblLabels_000)
		Me.Controls.SetChildIndex(Me.datPrimaryRS, 0)
		Me.Controls.SetChildIndex(Me.picButtons, 0)
		CType(Me.grdDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picButtons.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
