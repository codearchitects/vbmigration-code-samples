' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Factory

	' an external constructor method for CAddress
	
	Public Function New_CAddress(ByRef Street As String, ByRef City As String, ByRef State As String, ByRef Zip As String, Optional ByRef Country As Object = VB6Missing, Optional ByRef Phone As Object = VB6Missing) As CAddress
		New_CAddress = New CAddress()
		New_CAddress.Init(Street, City, State, Zip, Country, Phone)
	End Function

	' an external constructor method for CInvoiceLine
	
	Public Function New_CInvoiceLine(ByRef Qty As Integer, ByRef Product As String, ByRef UnitPrice As Decimal) As CInvoiceLine
		New_CInvoiceLine = New CInvoiceLine()
		New_CInvoiceLine.Init(Qty, Product, UnitPrice)
	End Function

End Module
