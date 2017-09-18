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
	Public WithEvents DataList1 As CodeArchitects.VB6Library.VB6DataList
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdAddNew As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents Check1 As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtUnitsOnOrder As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitsInStock As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitPrice As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtProductName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Adodc1 As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents DataCombo1 As CodeArchitects.VB6Library.VB6DataCombo
	Public WithEvents Label7 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents lblSupplierData As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label6 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label5 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.DataList1 = New CodeArchitects.VB6Library.VB6DataList()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdAddNew = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.Check1 = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtUnitsOnOrder = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitsInStock = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitPrice = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtProductName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.DataCombo1 = New CodeArchitects.VB6Library.VB6DataCombo()
		Me.Label7 = New CodeArchitects.VB6Library.VB6Label()
		Me.lblSupplierData = New CodeArchitects.VB6Library.VB6Label()
		Me.Label6 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label5 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' DataList1
		'
		Me.DataList1.Name = "DataList1"
		Me.DataList1.Size = New System.Drawing.Size(249, 52)
		Me.DataList1.Location = New System.Drawing.Point(160, 40)
		Me.DataList1.DataField = "CategoryID"
		Me.DataList1.DataSource = Adodc1
		Me.DataList1.TabIndex = 14
		Me.DataList1.ListField = "CategoryName"
		Me.DataList1.BoundColumn = "CategoryID"
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(81, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(112, 272)
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.TabIndex = 10
		'
		' cmdAddNew
		'
		Me.cmdAddNew.Name = "cmdAddNew"
		Me.cmdAddNew.Size = New System.Drawing.Size(81, 25)
		Me.cmdAddNew.Location = New System.Drawing.Point(16, 272)
		Me.cmdAddNew.Caption = "&AddNew"
		Me.cmdAddNew.TabIndex = 9
		'
		' Check1
		'
		Me.Check1.Name = "Check1"
		Me.Check1.Size = New System.Drawing.Size(105, 17)
		Me.Check1.Location = New System.Drawing.Point(288, 176)
		Me.Check1.Caption = "Discontinued"
		Me.Check1.DataField = "Discontinued"
		Me.Check1.DataSource = Adodc1
		Me.Check1.TabIndex = 8
		'
		' txtUnitsOnOrder
		'
		Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
		Me.txtUnitsOnOrder.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsOnOrder.Location = New System.Drawing.Point(160, 232)
		Me.txtUnitsOnOrder.DataField = "UnitsOnOrder"
		Me.txtUnitsOnOrder.DataSource = Adodc1
		Me.txtUnitsOnOrder.TabIndex = 3
		'
		' txtUnitsInStock
		'
		Me.txtUnitsInStock.Name = "txtUnitsInStock"
		Me.txtUnitsInStock.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsInStock.Location = New System.Drawing.Point(160, 200)
		Me.txtUnitsInStock.DataField = "UnitsInStock"
		Me.txtUnitsInStock.DataSource = Adodc1
		Me.txtUnitsInStock.TabIndex = 2
		'
		' txtUnitPrice
		'
		Me.txtUnitPrice.Name = "txtUnitPrice"
		Me.txtUnitPrice.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitPrice.Location = New System.Drawing.Point(160, 168)
		Me.txtUnitPrice.DataField = "UnitPrice"
		Me.txtUnitPrice.DataSource = Adodc1
		Me.txtUnitPrice.TabIndex = 1
		Me.txtUnitPrice.DataFormatValues = "0°@°000;(000);zero;null°@°True°@°False°@°°@°0°@°0"
		'
		' txtProductName
		'
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.Size = New System.Drawing.Size(249, 25)
		Me.txtProductName.Location = New System.Drawing.Point(160, 8)
		Me.txtProductName.DataField = "ProductName"
		Me.txtProductName.DataSource = Adodc1
		Me.txtProductName.TabIndex = 0
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(526, 25)
		Me.Adodc1.Location = New System.Drawing.Point(0, 300)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
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
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB;Persist Security Info=False"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = "Products"
		Me.Adodc1.Caption = "Adodc1"
		'
		' DataCombo1
		'
		Me.DataCombo1.Name = "DataCombo1"
		Me.DataCombo1.Size = New System.Drawing.Size(249, 24)
		Me.DataCombo1.Location = New System.Drawing.Point(160, 104)
		Me.DataCombo1.DataField = "SupplierID"
		Me.DataCombo1.DataSource = Adodc1
		Me.DataCombo1.TabIndex = 13
		Me.DataCombo1.MatchEntry = CodeArchitects.VB6Library.MSDataListLib.MatchEntryConstants.dblExtendedMatching
		Me.DataCombo1.ListField = "CompanyName"
		Me.DataCombo1.BoundColumn = "SupplierID"
		Me.DataCombo1.Text = ""
		'
		' Label7
		'
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(145, 25)
		Me.Label7.Location = New System.Drawing.Point(16, 128)
		Me.Label7.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label7.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label7.Caption = "Contact Name"
		Me.Label7.TabIndex = 16
		'
		' lblSupplierData
		'
		Me.lblSupplierData.Name = "lblSupplierData"
		Me.lblSupplierData.Size = New System.Drawing.Size(249, 25)
		Me.lblSupplierData.Location = New System.Drawing.Point(160, 128)
		Me.lblSupplierData.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.lblSupplierData.TabIndex = 15
		'
		' Label6
		'
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(145, 25)
		Me.Label6.Location = New System.Drawing.Point(16, 104)
		Me.Label6.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label6.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label6.Caption = "Supplier Name"
		Me.Label6.TabIndex = 12
		'
		' Label5
		'
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(145, 25)
		Me.Label5.Location = New System.Drawing.Point(16, 40)
		Me.Label5.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label5.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label5.Caption = "Category Name"
		Me.Label5.TabIndex = 11
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(145, 25)
		Me.Label4.Location = New System.Drawing.Point(16, 232)
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label4.Caption = "Units on Order"
		Me.Label4.TabIndex = 7
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(145, 25)
		Me.Label3.Location = New System.Drawing.Point(16, 200)
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label3.Caption = "Units in Stock"
		Me.Label3.TabIndex = 6
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(16, 168)
		Me.Label2.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label2.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label2.Caption = "Unit Price"
		Me.Label2.TabIndex = 5
		Me.Label2.DataFormatValues = "1°@°000;0;zero;null°@°True°@°False°@°°@°0°@°0"
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(145, 25)
		Me.Label1.Location = New System.Drawing.Point(16, 8)
		Me.Label1.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label1.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label1.Caption = "Product Name"
		Me.Label1.TabIndex = 4
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "DataCombo Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(526, 325)

		Me.Controls.Add(DataList1)
		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdAddNew)
		Me.Controls.Add(Check1)
		Me.Controls.Add(txtUnitsOnOrder)
		Me.Controls.Add(txtUnitsInStock)
		Me.Controls.Add(txtUnitPrice)
		Me.Controls.Add(txtProductName)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(DataCombo1)
		Me.Controls.Add(Label7)
		Me.Controls.Add(lblSupplierData)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.SetChildIndex(Me.Adodc1, 0)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
