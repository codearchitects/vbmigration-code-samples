' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CInvoiceLine

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'--------------------------------------------
	' The CInvoiceLine class
	'--------------------------------------------

	Public Qty As Integer
	Public Product As String = ""
	Public UnitPrice As Decimal
	Public Color As String = ""
	Public Notes As String = ""
	
	' a friendly constructor-like method
	
	Friend Sub Init(ByRef Qty As Integer, ByRef Product As String, ByRef UnitPrice As Decimal)
		Me.Qty = Qty
		Me.Product = Product
		Me.UnitPrice = UnitPrice
	End Sub

	Public ReadOnly Property Total() As Decimal
		Get
			Return Qty * UnitPrice
	 	End Get
	End Property

	Public ReadOnly Property Description() As String
		Get
			Return Format6(Qty, "@@@@@@   ") & Format6(Product, "!" & String6(40, "@")) & Format6(UnitPrice, "###,###.00") & "   " & Format6(Total, "###,###,###.00")
	 	End Get
	End Property

End Class
