' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CInvoices
	Implements IDisposable
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-----------------------------------------------
	' The CInvoices collection class
	'-----------------------------------------------

	Private m_LastInvoiceNumber As Integer
	' the internal collection of invoices
	' This wrapper property has been added to preserve As New semantics of m_Invoices variable
	Private Property m_Invoices() As Collection
		Get
			If m_Invoices_InnerField Is Nothing Then m_Invoices_InnerField = New Collection()
			Return m_Invoices_InnerField
		End Get
		Set(value As Collection)
			m_Invoices_InnerField = value
		End Set
	End Property
	
	Private m_Invoices_InnerField As Collection
	
	' the number used for the last invoice (read-only)
	
	Public ReadOnly Property LastInvoiceNumber() As Integer
		Get
			Return m_LastInvoiceNumber
	 	End Get
	End Property

	' Create a new CInvoice item and add it to the collection
	
	''' <summary>
	''' Adds a member to a Collection object
	''' </summary>
	Public Function Create(ByRef InvDate As Date, ByRef Customer As CCustomer) As CInvoice
		Dim newItem As CInvoice = Nothing
		
		' don't increment the internal variable yet!
		' pass "Me" to make this collection the parent of the new invoice
		AutoNew6(newItem).Init(m_LastInvoiceNumber + 1, InvDate, Customer)
		AutoNew6(newItem).Collection = Me
		' add to the internal collection, using the number as a key
		m_Invoices.Add(AutoNew6(newItem), CStr(AutoNew6(newItem).Number))
		
		' increment it now, if now error occurred
		m_LastInvoiceNumber += 1
		' return the new item to the caller
		Return AutoNew6(newItem)
	End Function

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByRef index As Object)
		Item(index).Collection = Nothing ' first, remove circular references
		m_Invoices.Remove(index)
	End Sub

	' Return a CInvoice item from the collection
	
	''' <summary>
	''' Returns a specific member of a Collection object either by position or key
	''' </summary>
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As CInvoice
			Get
		Return m_Invoices.Item(index)
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
		Get
			Return m_Invoices.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
		' first, solve all circular references
		Dim inv As CInvoice = Nothing
		For Each inv In m_Invoices
			inv.Collection = Nothing
		Next
		m_Invoices = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_Invoices.GetEnumerator()
	End Function

	Private Sub Class_Terminate_VB6()
		Debug.WriteLine("CInvoices:Class_Terminate")
	End Sub

	Protected Overrides Sub Finalize()
		Dispose(False)
	End Sub
	
	Public Sub Dispose() Implements System.IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
				Class_Terminate_VB6()
	End Sub

End Class
