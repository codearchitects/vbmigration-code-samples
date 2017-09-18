' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CCompany

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------------
	' the CCompany class
	'-------------------------------------

	Public Name As String = ""
	Public Address As CAddress
	
	' This wrapper property has been added to preserve As New semantics of Customers variable
	Public Property Customers() As CCustomers
		Get
			If Customers_InnerField Is Nothing Then Customers_InnerField = New CCustomers()
			Return Customers_InnerField
		End Get
		Set(value As CCustomers)
			Customers_InnerField = value
		End Set
	End Property
	
	Private Customers_InnerField As CCustomers
	' This wrapper property has been added to preserve As New semantics of Invoices variable
	Public Property Invoices() As CInvoices
		Get
			If Invoices_InnerField Is Nothing Then Invoices_InnerField = New CInvoices()
			Return Invoices_InnerField
		End Get
		Set(value As CInvoices)
			Invoices_InnerField = value
		End Set
	End Property
	
	Private Invoices_InnerField As CInvoices
	'Public Orders As New COrders         ' not implemented in this demo
	'Public Products As New CProduct      ' not implemented in this demo

End Class
