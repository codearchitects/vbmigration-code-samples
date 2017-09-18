' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class DataEnvironment1
	Inherits VB6DataEnvironment

	#Region "DefInstance"
	
		Private Shared m_DefInstance As DataEnvironment1
	
		Public Shared ReadOnly Property DefInstance() As DataEnvironment1
			Get
				If m_DefInstance Is Nothing Then m_DefInstance = New DataEnvironment1()
				Return m_DefInstance
			End Get
		End Property
	
	#End Region
	
	#Region "Public Connection and Recordset variables"
	
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsProducts As ADODB.Recordset
	Public WithEvents rsCategories As ADODB.Recordset
	Public WithEvents rsSuppliers As ADODB.Recordset
	Public WithEvents rsProducts_Fetch As ADODB.Recordset
	
	' Private Command variables
	Private m_Products As ADODB.Command
	Private m_Products_Insert As ADODB.Command
	Private m_Products_Update As ADODB.Command
	Private m_Products_Delete As ADODB.Command
	Private m_Categories As ADODB.Command
	Private m_Suppliers As ADODB.Command
	Private m_Products_Fetch As ADODB.Command
	
	Public Sub New()
		' The Connection1 connection
		Connection1 = CreateConnection("Connection1", "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\Program Files\Microsoft Visual Studio\VB98\NWIND.MDB")
		' The Products command
		m_Products = CreateCommand("Products", "Products", 2, -1, False)
		rsProducts = CreateRecordset("Products", m_Products, 3, -1, -1, -1)
		' The Products_Insert command
		m_Products_Insert = CreateCommand("Products_Insert", "INSERT INTO Products(ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", 1, -1, False)
		CreateParameter(m_Products_Insert, "ProductName", 200, 1, 40, 0, 0)
		CreateParameter(m_Products_Insert, "CategoryID", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "SupplierID", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "QuantityPerUnit", 200, 1, 20, 0, 0)
		CreateParameter(m_Products_Insert, "UnitPrice", 6, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "UnitsInStock", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "UnitsOnOrder", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "ReorderLevel", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Insert, "Discontinued", 11, 1, 0, 0, 0)
		' The Products_Update command
		m_Products_Update = CreateCommand("Products_Update", "UPDATE Products SET ProductName = ?, CategoryID = ?, SupplierID = ?, QuantityPerUnit = ?, UnitPrice = ?, UnitsInStock = ?, UnitsOnOrder = ?, ReorderLevel = ?, Discontinued = ? WHERE (ProductID = ?)", 1, -1, False)
		CreateParameter(m_Products_Update, "ProductName", 200, 1, 30, 0, 0)
		CreateParameter(m_Products_Update, "CategoryID", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "SupplierID", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "QuantityPerUnit", 200, 1, 20, 0, 0)
		CreateParameter(m_Products_Update, "UnitPrice", 6, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "UnitsInStock", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "UnitsOnOrder", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "ReorderLevel", 3, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "Discontinued", 11, 1, 0, 0, 0)
		CreateParameter(m_Products_Update, "ProductID", 3, 1, 0, 0, 0)
		' The Products_Delete command
		m_Products_Delete = CreateCommand("Products_Delete", "DELETE FROM Products WHERE (ProductID = ?)", 1, -1, False)
		CreateParameter(m_Products_Delete, "ProductID", 3, 1, 0, 0, 0)
		' The Categories command
		m_Categories = CreateCommand("Categories", "Categories", 2, -1, False)
		rsCategories = CreateRecordset("Categories", m_Categories, 3, -1, -1, -1)
		' The Suppliers command
		m_Suppliers = CreateCommand("Suppliers", "Suppliers", 2, -1, False)
		rsSuppliers = CreateRecordset("Suppliers", m_Suppliers, 3, -1, -1, -1)
		' The Products_Fetch command
		m_Products_Fetch = CreateCommand("Products_Fetch", "SELECT * FROM Products WHERE ProductName LIKE ?", 1, -1, False)
		CreateParameter(m_Products_Fetch, "ProductName", 200, 1, 20, 0, 0)
		rsProducts_Fetch = CreateRecordset("Products_Fetch", m_Products_Fetch, 3, -1, -1, -1)
	End Sub

	' public Command methods
	
	Public Sub Products()
		ExecuteCommand(m_Products, Connection1, rsProducts)
	End Sub
	
	Public Sub Products_Insert(ByVal ProductName As String, ByVal CategoryID As Integer, ByVal SupplierID As Integer, ByVal QuantityPerUnit As String, ByVal UnitPrice As Decimal, ByVal UnitsInStock As Integer, ByVal UnitsOnOrder As Integer, ByVal ReorderLevel As Integer, ByVal Discontinued As Boolean)
		m_Products_Insert.Parameters("ProductName").Value = ProductName
		m_Products_Insert.Parameters("CategoryID").Value = CategoryID
		m_Products_Insert.Parameters("SupplierID").Value = SupplierID
		m_Products_Insert.Parameters("QuantityPerUnit").Value = QuantityPerUnit
		m_Products_Insert.Parameters("UnitPrice").Value = UnitPrice
		m_Products_Insert.Parameters("UnitsInStock").Value = UnitsInStock
		m_Products_Insert.Parameters("UnitsOnOrder").Value = UnitsOnOrder
		m_Products_Insert.Parameters("ReorderLevel").Value = ReorderLevel
		m_Products_Insert.Parameters("Discontinued").Value = Discontinued
		ExecuteCommand(m_Products_Insert, Connection1)
	End Sub
	
	Public Sub Products_Insert()
		Products_Insert("", 0, 0, "", 0, 0, 0, 0, 0)
	End Sub
	
	Public Sub Products_Update(ByVal ProductName As String, ByVal CategoryID As Integer, ByVal SupplierID As Integer, ByVal QuantityPerUnit As String, ByVal UnitPrice As Decimal, ByVal UnitsInStock As Integer, ByVal UnitsOnOrder As Integer, ByVal ReorderLevel As Integer, ByVal Discontinued As Boolean, ByVal ProductID As Integer)
		m_Products_Update.Parameters("ProductName").Value = ProductName
		m_Products_Update.Parameters("CategoryID").Value = CategoryID
		m_Products_Update.Parameters("SupplierID").Value = SupplierID
		m_Products_Update.Parameters("QuantityPerUnit").Value = QuantityPerUnit
		m_Products_Update.Parameters("UnitPrice").Value = UnitPrice
		m_Products_Update.Parameters("UnitsInStock").Value = UnitsInStock
		m_Products_Update.Parameters("UnitsOnOrder").Value = UnitsOnOrder
		m_Products_Update.Parameters("ReorderLevel").Value = ReorderLevel
		m_Products_Update.Parameters("Discontinued").Value = Discontinued
		m_Products_Update.Parameters("ProductID").Value = ProductID
		ExecuteCommand(m_Products_Update, Connection1)
	End Sub
	
	Public Sub Products_Update()
		Products_Update("", 0, 0, "", 0, 0, 0, 0, 0, 0)
	End Sub
	
	Public Sub Products_Delete(ByVal ProductID As Integer)
		m_Products_Delete.Parameters("ProductID").Value = ProductID
		ExecuteCommand(m_Products_Delete, Connection1)
	End Sub
	
	Public Sub Products_Delete()
		Products_Delete(0)
	End Sub
	
	Public Sub Categories()
		ExecuteCommand(m_Categories, Connection1, rsCategories)
	End Sub
	
	Public Sub Suppliers()
		ExecuteCommand(m_Suppliers, Connection1, rsSuppliers)
	End Sub
	
	Public Sub Products_Fetch(ByVal ProductName As String)
		m_Products_Fetch.Parameters("ProductName").Value = ProductName
		ExecuteCommand(m_Products_Fetch, Connection1, rsProducts_Fetch)
	End Sub
	
	Public Sub Products_Fetch()
		Products_Fetch("")
	End Sub

	#End Region

End Class

' this class offers support for DataEnvironment used as design-time data sources

Friend Class DataEnvironment1_Instance
	Inherits System.ComponentModel.Component
	Implements IVB6DataEnvironmentInstance

	Public Function GetDataEnvironment() As CodeArchitects.VB6Library.VB6DataEnvironment Implements CodeArchitects.VB6Library.IVB6DataEnvironmentInstance.GetDataEnvironment
		Return DataEnvironment1.DefInstance
	End Function
End Class
