' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' This wrapper property has been added to preserve As New semantics of Company variable
	Private Property Company() As CCompany
		Get
			If Company_InnerField Is Nothing Then Company_InnerField = New CCompany()
			Return Company_InnerField
		End Get
		Set(value As CCompany)
			Company_InnerField = value
		End Set
	End Property
	
	Private Company_InnerField As CCompany
	
	Private Sub Command1_Click() Handles Command1.Click
		Dim inv As CInvoice = Nothing
		Dim cust As CCustomer = Nothing
		
		' first, create a customer
		cust = Company.Customers.Create("Tech Eleven, Inc")
		cust.Address.Init("234 East Road", "Chicago", "IL", "12345")
		' now create the invoice
		inv = Company.Invoices.Create("Mar 12, 1998", cust)
		' and its invoice lines
		inv.InvoiceLines.Create(10, "Monitors ZX100", 225.25)
		' this second line requires additional properties
		With inv.InvoiceLines.Create(14, "101-key Keyboards", 19.99)
			.Color = "White"
			.Notes = "Special layout for laboratory"
		End With
		' prints it on the form
		' UPGRADE_INFO (#0181): Reference to default form instance Form1 was converted to Me keyword.
		inv.PrintAll(Me)
		
		' disable this and enable the second button
		Command1.Enabled = False
		Command2.Enabled = True
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		Dim inv As CInvoice = Nothing
		Dim cust As CCustomer = Nothing
		
		' use the same customer as the first invoice
		cust = Company.Customers(1)
		' now create the invoice
		inv = Company.Invoices.Create("Mar 21, 1998", cust)
		' and its invoice lines
		inv.InvoiceLines.Create(14, "Modem TKU", 99.5)
		' this second line requires additional properties
		inv.InvoiceLines.Create(100, "Network adapter", 60)
		inv.InvoiceLines.Create(44, "Serial Cables", 5.25)
		' prints it on the form
		' this will also print a warning for the customer
		' UPGRADE_INFO (#0181): Reference to default form instance Form1 was converted to Me keyword.
		inv.PrintAll(Me)
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
	End Sub

End Class
