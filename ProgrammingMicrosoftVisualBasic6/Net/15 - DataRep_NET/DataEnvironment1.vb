' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_ISSUE (#02F8): Designer 'DataReport1' can't be converted (file 'D:\VB6Samples\ProgrammingVB6 Samples\15 - DataRep\DataRep.Dsr')
' UPGRADE_ISSUE (#02F8): Designer 'DataReport2' can't be converted (file 'D:\VB6Samples\ProgrammingVB6 Samples\15 - DataRep\DataRep2.Dsr')
' UPGRADE_INFO (#0571): The 'MSDataReportLib' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class DataEnvironment1
	Inherits VB6DataEnvironment
' UPGRADE_INFO (#0501): The 'DataEnvironment1' member isn't used anywhere in current application.

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
	Public WithEvents rsOrders As ADODB.Recordset
	Public WithEvents rsOrder_Details As ADODB.Recordset
	Public WithEvents rsCustomers As ADODB.Recordset
	
	' Private Command variables
	Private m_Orders As ADODB.Command
	Private m_Order_Details As ADODB.Command
	Private m_Customers As ADODB.Command
	
	Public Sub New()
		' The Connection1 connection
		Connection1 = CreateConnection("Connection1", "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=E:\Microsoft Visual Studio\VB98\Nwind.mdb")
		' The Orders command
		m_Orders = CreateCommand("Orders", "Orders", 2, -1, False)
		rsOrders = CreateRecordset("Orders", m_Orders, 3, -1, -1, -1)
		' The Order_Details command
		m_Order_Details = CreateCommand("Order_Details", "SELECT [Order Details].OrderID, [Order Details].ProductID, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, (([Order Details].UnitPrice*[Order Details].Quantity)*(1-[Order Details].Discount))  AS Total, Products.ProductName FROM [Order Details] INNER JOIN Products ON [Order Details].ProductID = Products.ProductID", 1, -1, False)
		rsOrder_Details = CreateRecordset("Order_Details", m_Order_Details, 3, -1, -1, -1)
		' The Customers command
		m_Customers = CreateCommand("Customers", "Customers", 2, -1, False)
		rsCustomers = CreateRecordset("Customers", m_Customers, 3, -1, -1, -1)
	End Sub

	' public Command methods
	
	Public Sub Orders()
		ExecuteCommand(m_Orders, Connection1, rsOrders)
	End Sub
	
	Public Sub Order_Details()
		ExecuteCommand(m_Order_Details, Connection1, rsOrder_Details)
	End Sub
	
	Public Sub Customers()
		ExecuteCommand(m_Customers, Connection1, rsCustomers)
	End Sub

	#End Region

	' WARNING: Ensure that this constant points to a valid
	' copy of the Biblio.mdb database.
	Private Const DB_PATH As String = "e:\VisStudio\Vb98\NWind.mdb"
	
	Private Sub Connection1_WillConnect(ByRef ConnectionString As String, ByRef UserID As String, ByRef Password As String, ByRef Options As Integer, ByRef adStatus As ADODB.EventStatusEnum, ByVal pConnection As ADODB.Connection) Handles Connection1.WillConnect
		Dim i As Short
		Dim j As Short
		' Search and replace the Data Source argument.
		i = InStr(ConnectionString, "Data Source=")
		If i Then 
			j = InStr(i, ConnectionString & ";", ";")
			ConnectionString = VB.Left(ConnectionString, i + 11) & DB_PATH & Mid(ConnectionString, j)
		End If
	End Sub

End Class

' this class offers support for DataEnvironment used as design-time data sources

Friend Class DataEnvironment1_Instance
	Inherits System.ComponentModel.Component
	Implements IVB6DataEnvironmentInstance

	Public Function GetDataEnvironment() As CodeArchitects.VB6Library.VB6DataEnvironment Implements CodeArchitects.VB6Library.IVB6DataEnvironmentInstance.GetDataEnvironment
		Return DataEnvironment1.DefInstance
	End Function
End Class
