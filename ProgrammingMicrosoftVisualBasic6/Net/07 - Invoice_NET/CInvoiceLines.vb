' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CInvoiceLines
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'------------------------------------
	' The CInvoiceLines collection class
	'------------------------------------

	' The private collection used to hold the real data
	' This wrapper property has been added to preserve As New semantics of m_InvoiceLines variable
	Private Property m_InvoiceLines() As Collection
		Get
			If m_InvoiceLines_InnerField Is Nothing Then m_InvoiceLines_InnerField = New Collection()
			Return m_InvoiceLines_InnerField
		End Get
		Set(value As Collection)
			m_InvoiceLines_InnerField = value
		End Set
	End Property
	
	Private m_InvoiceLines_InnerField As Collection
	
	' Add a new CInvoiceLine item to the collection
	
	Public Sub Add(ByRef newItem As CInvoiceLine, Optional ByRef Key As Object = VB6Missing, Optional ByRef Before As Object = VB6Missing, Optional ByRef After As Object = VB6Missing)
		m_InvoiceLines.Add(newItem, Key)
	End Sub

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByRef index As Object)
		m_InvoiceLines.Remove(index)
	End Sub

	' Return a CInvoiceLine item from the collection
	
	''' <summary>
	''' Returns a specific member of a Collection object either by position or key
	''' </summary>
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As CInvoiceLine
			Get
		Return m_InvoiceLines.Item(index)
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
		Get
			Return m_InvoiceLines.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
		m_InvoiceLines = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_InvoiceLines.GetEnumerator()
	End Function

	'-----------------------------------------------
	' specific custom methods
	'-----------------------------------------------
	
	' create a CInvoiceLine object and add it to the collection
	
	Public Function Create(ByRef Qty As Integer, ByRef Product As String, ByRef UnitPrice As Decimal) As CInvoiceLine
		Dim newItem As CInvoiceLine = Nothing ' auto-instancing is safe here
		AutoNew6(newItem).Init(Qty, Product, UnitPrice)
		m_InvoiceLines.Add(AutoNew6(newItem))
		Return AutoNew6(newItem)
	End Function

	' get the sum of subtotals
	
	Public ReadOnly Property Total() As Decimal
		Get
			Dim result As Decimal
			Dim invline As CInvoiceLine = Nothing
			For Each invline In m_InvoiceLines
				result += invline.Total
			Next
			Return result
	 	End Get
	End Property

	' print individual lines
	
	Public Sub PrintLines(ByRef obj As Object)
		Dim invline As CInvoiceLine = Nothing
		For Each invline In m_InvoiceLines
			obj.PrintLine(invline.Description)
		Next
	End Sub

End Class
