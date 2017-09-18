<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
	Inherits CodeArchitects.VB6Library.VB6Form

#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
	EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Unsupported properties"

	' UPGRADE_ISSUE (#0238): Unable to read the 'ProductGrid1.font' property. Please run the VB Migration Partner Project Dumper add-in from inside Visual Basic 6

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
	Public WithEvents txtUnitsOnOrder As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitsInStock As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtUnitPrice As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents txtProductName As CodeArchitects.VB6Library.VB6TextBox
	Public WithEvents ProductGrid1 As Project1.ProductGrid
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
 		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
		Me.txtUnitsOnOrder = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitsInStock = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtUnitPrice = New CodeArchitects.VB6Library.VB6TextBox()
		Me.txtProductName = New CodeArchitects.VB6Library.VB6TextBox()
		Me.ProductGrid1 = New Project1.ProductGrid()
		Me.Adodc1 = New CodeArchitects.VB6Library.VB6Adodc()
		Me.Label4 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label3 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label2 = New CodeArchitects.VB6Library.VB6Label()
		Me.Label1 = New CodeArchitects.VB6Library.VB6Label()
		CType(Me.ProductGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		' txtUnitsOnOrder
		'
		Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
		Me.txtUnitsOnOrder.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsOnOrder.Location = New System.Drawing.Point(424, 24)
		Me.txtUnitsOnOrder.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtUnitsOnOrder.DataField = "UnitsOnOrder"
		Me.txtUnitsOnOrder.DataSource = Adodc1
		Me.txtUnitsOnOrder.TabIndex = 7
		'
		' txtUnitsInStock
		'
		Me.txtUnitsInStock.Name = "txtUnitsInStock"
		Me.txtUnitsInStock.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitsInStock.Location = New System.Drawing.Point(320, 24)
		Me.txtUnitsInStock.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtUnitsInStock.DataField = "UnitsInStock"
		Me.txtUnitsInStock.DataSource = Adodc1
		Me.txtUnitsInStock.TabIndex = 5
		'
		' txtUnitPrice
		'
		Me.txtUnitPrice.Name = "txtUnitPrice"
		Me.txtUnitPrice.Size = New System.Drawing.Size(97, 25)
		Me.txtUnitPrice.Location = New System.Drawing.Point(216, 24)
		Me.txtUnitPrice.Alignment = CodeArchitects.VB6Library.VBRUN.AlignmentConstants.vbRightJustify
		Me.txtUnitPrice.DataField = "UnitPrice"
		Me.txtUnitPrice.DataSource = Adodc1
		Me.txtUnitPrice.TabIndex = 3
		'
		' txtProductName
		'
		Me.txtProductName.Name = "txtProductName"
		Me.txtProductName.Size = New System.Drawing.Size(201, 25)
		Me.txtProductName.Location = New System.Drawing.Point(8, 24)
		Me.txtProductName.DataField = "ProductName"
		Me.txtProductName.DataSource = Adodc1
		Me.txtProductName.TabIndex = 1
		'
		' ProductGrid1
		'
		Me.ProductGrid1.Name = "ProductGrid1"
		Me.ProductGrid1.Size = New System.Drawing.Size(529, 169)
		Me.ProductGrid1.Location = New System.Drawing.Point(8, 64)
		Me.ProductGrid1.TabIndex = 0
		Me.ProductGrid1.fullrowselect = -1
		'
		' Adodc1
		'
		Me.Adodc1.Name = "Adodc1"
		Me.Adodc1.Size = New System.Drawing.Size(558, 25)
		Me.Adodc1.Location = New System.Drawing.Point(0, 253)
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Adodc1.EOFAction = CodeArchitects.VB6Library.MSAdodcLib.EOFActionEnum.adStayEOF
		Me.Adodc1.BackColor = FromOleColor6(CInt(-2147483643))
		Me.Adodc1.ForeColor = FromOleColor6(CInt(-2147483640))
		Me.Adodc1.Enabled = True
		Me.Adodc1.Connect = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program files\Microsoft Visual Studio\VB98\Nwind.mdb"
		Me.Adodc1.UserName = ""
		Me.Adodc1.Password = ""
		Me.Adodc1.RecordSource = "Products"
		Me.Adodc1.Caption = "Adodc1"
		'
		' Label4
		'
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 17)
		Me.Label4.Location = New System.Drawing.Point(424, 8)
		Me.Label4.Caption = "Units on &Order"
		Me.Label4.TabIndex = 8
		'
		' Label3
		'
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.Location = New System.Drawing.Point(320, 8)
		Me.Label3.Caption = "Units In &Stock"
		Me.Label3.TabIndex = 6
		'
		' Label2
		'
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(216, 8)
		Me.Label2.Caption = "&Unit Price"
		Me.Label2.TabIndex = 4
		'
		' Label1
		'
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Caption = "&Product Name"
		Me.Label1.TabIndex = 2
		'
		' Form1
		'
		Me.Name = "Form1"
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Caption = "Form1"
		Me.StartUpPosition = CodeArchitects.VB6Library.VBRUN.StartUpPositionConstants.vbStartUpWindowsDefault
		Me.Location = New System.Drawing.Point(4, 23)
		Me.ClientSize = New System.Drawing.Size(558, 278)

		Me.Controls.Add(txtUnitsOnOrder)
		Me.Controls.Add(txtUnitsInStock)
		Me.Controls.Add(txtUnitPrice)
		Me.Controls.Add(txtProductName)
		Me.Controls.Add(ProductGrid1)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.SetChildIndex(Me.Adodc1, 0)
		CType(Me.ProductGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub

#End Region


End Class
