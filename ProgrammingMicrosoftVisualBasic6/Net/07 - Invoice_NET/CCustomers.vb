' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CCustomers
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' The private collection used to hold the real data
	' This wrapper property has been added to preserve As New semantics of m_Customers variable
	Private Property m_Customers() As Collection
		Get
			If m_Customers_InnerField Is Nothing Then m_Customers_InnerField = New Collection()
			Return m_Customers_InnerField
		End Get
		Set(value As Collection)
			m_Customers_InnerField = value
		End Set
	End Property
	
	Private m_Customers_InnerField As Collection
	
	' Add a new CCustomer item to the collection
	
	''' <summary>
	''' Adds a member to a Collection object
	''' </summary>
	Public Function Create(ByRef Name As Object, Optional ByRef Address As CAddress = Nothing) As CCustomer
		Dim newItem As CCustomer = Nothing
		AutoNew6(newItem).Name = Name
		m_Customers.Add(AutoNew6(newItem), AutoNew6(newItem).Name)
		If Not IsMissing6(Address) Then 
			AutoNew6(newItem).Address = Address
		End If
		' return the new item to the caller
		Return AutoNew6(newItem)
	End Function

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByRef index As Object)
		m_Customers.Remove(index)
	End Sub

	' Return a CCustomer item from the collection
	
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As CCustomer
			Get
		Return m_Customers.Item(index)
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
		Get
			Return m_Customers.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
		m_Customers = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_Customers.GetEnumerator()
	End Function

End Class
