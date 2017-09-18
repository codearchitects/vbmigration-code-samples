<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class uctProductsSingleRecord
	Inherits CodeArchitects.VB6Library.VB6UserControl

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
			UserControl_Terminate_VB6()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Private WithEvents chkDiscontinued As CodeArchitects.VB6Library.VB6CheckBox
	Private WithEvents txtReorderLevel As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents txtUnitsOnOrder As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents txtUnitsInStock As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents txtUnitPrice As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents txtQuantityPerUnit As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents cmbCategoriesCategoryName As CodeArchitects.VB6Library.VB6ComboBox
	Private WithEvents cmbSuppliersCompanyName As CodeArchitects.VB6Library.VB6ComboBox
	Private WithEvents txtProductName As CodeArchitects.VB6Library.VB6TextBox
	Private WithEvents lblDiscontinued As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblReorderLevel As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblUnitsOnOrder As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblUnitsInStock As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblUnitPrice As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblQuantityPerUnit As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblCategoriesCategoryName As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblSuppliersCompanyName As CodeArchitects.VB6Library.VB6Label
	Private WithEvents lblProductName As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.chkDiscontinued = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtReorderLevel = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitsOnOrder = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitsInStock = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitPrice = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtQuantityPerUnit = New CodeArchitects.VB6Library.VB6TextBox()
		Me.cmbCategoriesCategoryName = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.cmbSuppliersCompanyName = New CodeArchitects.VB6Library.VB6ComboBox()
		Me.txtProductName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.lblDiscontinued = New CodeArchitects.VB6Library.VB6Label()
		Me.lblReorderLevel = New CodeArchitects.VB6Library.VB6Label()
		Me.lblUnitsOnOrder = New CodeArchitects.VB6Library.VB6Label()
		Me.lblUnitsInStock = New CodeArchitects.VB6Library.VB6Label()
		Me.lblUnitPrice = New CodeArchitects.VB6Library.VB6Label()
		Me.lblQuantityPerUnit = New CodeArchitects.VB6Library.VB6Label()
		Me.lblCategoriesCategoryName = New CodeArchitects.VB6Library.VB6Label()
		Me.lblSuppliersCompanyName = New CodeArchitects.VB6Library.VB6Label()
		Me.lblProductName = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' chkDiscontinued
		'
		Me.chkDiscontinued.Name = "chkDiscontinued"
		Me.chkDiscontinued.Size = New System.Drawing.Size(167, 21)
		Me.chkDiscontinued.Location = New System.Drawing.Point(128, 264)
		Me.chkDiscontinued.TabIndex = 17
		'
		' txtReorderLevel
		'
		Me.txtReorderLevel.Name = "txtReorderLevel"
		Me.txtReorderLevel.Size = New System.Drawing.Size(167, 21)
		Me.txtReorderLevel.Location = New System.Drawing.Point(128, 232)
		Me.txtReorderLevel.TabIndex = 15
		Me.txtReorderLevel.Text = "txtReorderLevel"
		'
		' txtUnitsOnOrder
		'
		Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
		Me.txtUnitsOnOrder.Size = New System.Drawing.Size(167, 21)
		Me.txtUnitsOnOrder.Location = New System.Drawing.Point(128, 200)
		Me.txtUnitsOnOrder.TabIndex = 13
		Me.txtUnitsOnOrder.Text = "txtUnitsOnOrder"
		'
		' txtUnitsInStock
		'
		Me.txtUnitsInStock.Name = "txtUnitsInStock"
		Me.txtUnitsInStock.Size = New System.Drawing.Size(167, 21)
		Me.txtUnitsInStock.Location = New System.Drawing.Point(128, 168)
		Me.txtUnitsInStock.TabIndex = 11
		Me.txtUnitsInStock.Text = "txtUnitsInStock"
		'
		' txtUnitPrice
		'
		Me.txtUnitPrice.Name = "txtUnitPrice"
		Me.txtUnitPrice.Size = New System.Drawing.Size(167, 21)
		Me.txtUnitPrice.Location = New System.Drawing.Point(128, 136)
		Me.txtUnitPrice.TabIndex = 9
		Me.txtUnitPrice.Text = "txtUnitPrice"
		'
		' txtQuantityPerUnit
		'
		Me.txtQuantityPerUnit.Name = "txtQuantityPerUnit"
		Me.txtQuantityPerUnit.Size = New System.Drawing.Size(167, 21)
		Me.txtQuantityPerUnit.Location = New System.Drawing.Point(128, 104)
		Me.txtQuantityPerUnit.TabIndex = 7
		Me.txtQuantityPerUnit.Text = "txtQuantityPerUnit"
		'
		' cmbCategoriesCategoryName
		'
		Me.cmbCategoriesCategoryName.Name = "cmbCategoriesCategoryName"
		Me.cmbCategoriesCategoryName.Size = New System.Drawing.Size(167, 21)
		Me.cmbCategoriesCategoryName.Location = New System.Drawing.Point(128, 72)
		Me.cmbCategoriesCategoryName.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbCategoriesCategoryName.TabIndex = 5
		Me.cmbCategoriesCategoryName.Tag = "Categories"
		'
		' cmbSuppliersCompanyName
		'
		Me.cmbSuppliersCompanyName.Name = "cmbSuppliersCompanyName"
		Me.cmbSuppliersCompanyName.Size = New System.Drawing.Size(167, 21)
		Me.cmbSuppliersCompanyName.Location = New System.Drawing.Point(128, 40)
		Me.cmbSuppliersCompanyName.Style = CodeArchitects.VB6Library.VBRUN.ComboBoxConstants.vbComboDropdownList
		Me.cmbSuppliersCompanyName.TabIndex = 3
		Me.cmbSuppliersCompanyName.Tag = "Suppliers"
		'
		' txtProductName
		'
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.Size = New System.Drawing.Size(167, 21)
		Me.txtProductName.Location = New System.Drawing.Point(128, 8)
		Me.txtProductName.TabIndex = 1
		Me.txtProductName.Text = "txtProductName"
		'
		' lblDiscontinued
		'
		Me.lblDiscontinued.Name = "lblDiscontinued"
		Me.lblDiscontinued.Size = New System.Drawing.Size(120, 19)
		Me.lblDiscontinued.Location = New System.Drawing.Point(8, 264)
		Me.lblDiscontinued.Caption = "Discontinued: "
		Me.lblDiscontinued.TabIndex = 16
		'
		' lblReorderLevel
		'
		Me.lblReorderLevel.Name = "lblReorderLevel"
		Me.lblReorderLevel.Size = New System.Drawing.Size(120, 19)
		Me.lblReorderLevel.Location = New System.Drawing.Point(8, 232)
		Me.lblReorderLevel.Caption = "ReorderLevel: "
		Me.lblReorderLevel.TabIndex = 14
		'
		' lblUnitsOnOrder
		'
		Me.lblUnitsOnOrder.Name = "lblUnitsOnOrder"
		Me.lblUnitsOnOrder.Size = New System.Drawing.Size(120, 19)
		Me.lblUnitsOnOrder.Location = New System.Drawing.Point(8, 200)
		Me.lblUnitsOnOrder.Caption = "UnitsOnOrder: "
		Me.lblUnitsOnOrder.TabIndex = 12
		'
		' lblUnitsInStock
		'
		Me.lblUnitsInStock.Name = "lblUnitsInStock"
		Me.lblUnitsInStock.Size = New System.Drawing.Size(120, 19)
		Me.lblUnitsInStock.Location = New System.Drawing.Point(8, 168)
		Me.lblUnitsInStock.Caption = "UnitsInStock: "
		Me.lblUnitsInStock.TabIndex = 10
		'
		' lblUnitPrice
		'
		Me.lblUnitPrice.Name = "lblUnitPrice"
		Me.lblUnitPrice.Size = New System.Drawing.Size(120, 19)
		Me.lblUnitPrice.Location = New System.Drawing.Point(8, 136)
		Me.lblUnitPrice.Caption = "UnitPrice: "
		Me.lblUnitPrice.TabIndex = 8
		'
		' lblQuantityPerUnit
		'
		Me.lblQuantityPerUnit.Name = "lblQuantityPerUnit"
		Me.lblQuantityPerUnit.Size = New System.Drawing.Size(120, 19)
		Me.lblQuantityPerUnit.Location = New System.Drawing.Point(8, 104)
		Me.lblQuantityPerUnit.Caption = "QuantityPerUnit: "
		Me.lblQuantityPerUnit.TabIndex = 6
		'
		' lblCategoriesCategoryName
		'
		Me.lblCategoriesCategoryName.Name = "lblCategoriesCategoryName"
		Me.lblCategoriesCategoryName.Size = New System.Drawing.Size(120, 19)
		Me.lblCategoriesCategoryName.Location = New System.Drawing.Point(8, 72)
		Me.lblCategoriesCategoryName.Caption = "CategoryName: "
		Me.lblCategoriesCategoryName.TabIndex = 4
		'
		' lblSuppliersCompanyName
		'
		Me.lblSuppliersCompanyName.Name = "lblSuppliersCompanyName"
		Me.lblSuppliersCompanyName.Size = New System.Drawing.Size(120, 19)
		Me.lblSuppliersCompanyName.Location = New System.Drawing.Point(8, 40)
		Me.lblSuppliersCompanyName.Caption = "CompanyName: "
		Me.lblSuppliersCompanyName.TabIndex = 2
		'
		' lblProductName
		'
		Me.lblProductName.Name = "lblProductName"
		Me.lblProductName.Size = New System.Drawing.Size(120, 19)
		Me.lblProductName.Location = New System.Drawing.Point(8, 8)
		Me.lblProductName.Caption = "ProductName: "
		Me.lblProductName.TabIndex = 0
		'
		' uctProductsSingleRecord
		'
		Me.Name = "uctProductsSingleRecord"
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ClientSize = New System.Drawing.Size(307, 296)

		Me.Controls.Add(chkDiscontinued)
		Me.Controls.Add(txtReorderLevel)
		Me.Controls.Add(txtUnitsOnOrder)
		Me.Controls.Add(txtUnitsInStock)
		Me.Controls.Add(txtUnitPrice)
		Me.Controls.Add(txtQuantityPerUnit)
		Me.Controls.Add(cmbCategoriesCategoryName)
		Me.Controls.Add(cmbSuppliersCompanyName)
		Me.Controls.Add(txtProductName)
		Me.Controls.Add(lblDiscontinued)
		Me.Controls.Add(lblReorderLevel)
		Me.Controls.Add(lblUnitsOnOrder)
		Me.Controls.Add(lblUnitsInStock)
		Me.Controls.Add(lblUnitPrice)
		Me.Controls.Add(lblQuantityPerUnit)
		Me.Controls.Add(lblCategoriesCategoryName)
		Me.Controls.Add(lblSuppliersCompanyName)
		Me.Controls.Add(lblProductName)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
