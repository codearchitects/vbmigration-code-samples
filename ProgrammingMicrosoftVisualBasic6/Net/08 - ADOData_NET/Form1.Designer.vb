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
	Public WithEvents cmdCancel As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdUpdate As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdDelete As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents cmdAddNew As CodeArchitects.VB6Library.VB6CommandButton
	Public WithEvents chkDiscontinued As CodeArchitects.VB6Library.VB6CheckBox
	Public WithEvents txtUnitsOnOrder As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitsInStock As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitPrice As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtProductName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents Adodc1 As CodeArchitects.VB6Library.VB6Adodc
	Public WithEvents Label4 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label3 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label2 As CodeArchitects.VB6Library.VB6Label
	Public WithEvents Label1 As CodeArchitects.VB6Library.VB6Label

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.cmdCancel = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdUpdate = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdDelete = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.cmdAddNew = New CodeArchitects.VB6Library.VB6CommandButton()
		Me.chkDiscontinued = New CodeArchitects.VB6Library.VB6CheckBox()
		Me.txtUnitsOnOrder = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitsInStock = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitPrice = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtProductName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		Me.SuspendLayout()
		'
		' cmdCancel
		'
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(344, 144)
		Me.cmdCancel.Caption = "&Cancel"
		Me.cmdCancel.TabIndex = 12
		'
		' cmdUpdate
		'
		Me.cmdUpdate.Name = "cmdUpdate"
		Me.cmdUpdate.Size = New System.Drawing.Size(81, 25)
		Me.cmdUpdate.Location = New System.Drawing.Point(256, 144)
		Me.cmdUpdate.Caption = "&Update"
		Me.cmdUpdate.TabIndex = 11
		'
		' cmdDelete
		'
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(81, 25)
		Me.cmdDelete.Location = New System.Drawing.Point(104, 144)
		Me.cmdDelete.Caption = "&Delete"
		Me.cmdDelete.TabIndex = 10
		'
		' cmdAddNew
		'
		Me.cmdAddNew.Name = "cmdAddNew"
		Me.cmdAddNew.Size = New System.Drawing.Size(81, 25)
		Me.cmdAddNew.Location = New System.Drawing.Point(16, 144)
		Me.cmdAddNew.Caption = "&AddNew"
		Me.cmdAddNew.TabIndex = 9
		'
		' chkDiscontinued
		'
		Me.chkDiscontinued.Name = "chkDiscontinued"
		Me.chkDiscontinued.Size = New System.Drawing.Size(105, 17)
		Me.chkDiscontinued.Location = New System.Drawing.Point(288, 48)
		Me.chkDiscontinued.Caption = "Discontinued"
		Me.chkDiscontinued.DataField = "Discontinued"
		Me.chkDiscontinued.DataSource = Adodc1
		Me.chkDiscontinued.TabIndex = 8
		'
		' txtUnitsOnOrder
		'
		Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
		Me.txtUnitsOnOrder.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsOnOrder.Location = New System.Drawing.Point(160, 104)
		Me.txtUnitsOnOrder.DataField = "UnitsOnOrder"
		Me.txtUnitsOnOrder.DataSource = Adodc1
		Me.txtUnitsOnOrder.TabIndex = 3
		'
		' txtUnitsInStock
		'
		Me.txtUnitsInStock.Name = "txtUnitsInStock"
		Me.txtUnitsInStock.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsInStock.Location = New System.Drawing.Point(160, 72)
		Me.txtUnitsInStock.DataField = "UnitsInStock"
		Me.txtUnitsInStock.DataSource = Adodc1
		Me.txtUnitsInStock.TabIndex = 2
		'
		' txtUnitPrice
		'
		Me.txtUnitPrice.Name = "txtUnitPrice"
		Me.txtUnitPrice.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitPrice.Location = New System.Drawing.Point(160, 40)
		Me.txtUnitPrice.DataField = "UnitPrice"
		Me.txtUnitPrice.DataSource = Adodc1
		Me.txtUnitPrice.TabIndex = 1
		Me.txtUnitPrice.DataFormatValues = "0°@°000;(000);zero;null°@°True°@°False°@°°@°0°@°0"
		'
		' txtProductName
		'
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.Size = New System.Drawing.Size(265, 25)
		Me.txtProductName.Location = New System.Drawing.Point(160, 8)
		Me.txtProductName.DataField = "ProductName"
		Me.txtProductName.DataSource = Adodc1
		Me.txtProductName.TabIndex = 0
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(445, 25)
		Me.Adodc1.Location = New System.Drawing.Point(0, 185)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.Align = CodeArchitects.VB6Library.VBRUN.AlignConstants.vbAlignBottom
		Me.Adodc1.ConnectMode = ADODB.ConnectModeEnum.adModeReadWrite
		Me.Adodc1.CursorLocation = CodeArchitects.VB6Library.MSAdodcLib.CursorLocationEnum.adUseServer
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = CodeArchitects.VB6Library.MSAdodcLib.CursorTypeEnum.adOpenDynamic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = CodeArchitects.VB6Library.MSAdodcLib.CommandTypeEnum.adCmdTable
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = CodeArchitects.VB6Library.MSAdodcLib.BOFActionEnum.adStayBOF
		Me.Adodc1.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.Adodc1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.Adodc1.Enabled = True
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = "Products"
		Me.Adodc1.Caption = "Adodc1"
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(145, 25)
		Me.Label4.Location = New System.Drawing.Point(16, 104)
		Me.Label4.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label4.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label4.Caption = "Units on Order"
		Me.Label4.TabIndex = 7
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(145, 25)
		Me.Label3.Location = New System.Drawing.Point(16, 72)
		Me.Label3.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.Label3.BorderStyle = CodeArchitects.VB6Library.VB6BorderStyleConstants.FixedSingle
		Me.Label3.Caption = "Units in Stock"
		Me.Label3.TabIndex = 6
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(16, 40)
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
		Me.Caption = "ADO Data Control Demo"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(445, 210)

		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdUpdate)
		Me.Controls.Add(cmdDelete)
		Me.Controls.Add(cmdAddNew)
		Me.Controls.Add(chkDiscontinued)
		Me.Controls.Add(txtUnitsOnOrder)
		Me.Controls.Add(txtUnitsInStock)
		Me.Controls.Add(txtUnitPrice)
		Me.Controls.Add(txtProductName)
		Me.Controls.Add(Adodc1)
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
