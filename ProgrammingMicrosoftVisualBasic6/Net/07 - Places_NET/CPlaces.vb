' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CPlaces
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'-------------------------------
	' The CPlaces collection class
	'-------------------------------

	Private m_Places As New Collection
	
	' Create a new CPlace item and add it to the collection
	
	''' <summary>
	''' Adds a member to a Collection object
	''' </summary>
	Public Function Create(ByVal Name As String, ByVal X As Single, ByVal Y As Single) As CPlace
		Dim newItem As New CPlace
		newItem.Init(Name, X, Y)
		' add to the private collection
		m_Places.Add(newItem, newItem.Name)
		' return the new item to the caller
		Return newItem
	End Function

	' add a new CPlace to the collection (must exist already)
	
	Public Function Add(ByVal place As CPlace) As CPlace
		m_Places.Add(place, place.Name)
		Return place
	End Function

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByVal index As Object)
		m_Places.Remove(GetDefaultMember6(index))
	End Sub

	' Return a CPlace item from the collection, or nothing if not there
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As CPlace
			Get
		On Error Resume Next 
		Return m_Places.Item(GetDefaultMember6(index))
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
		Get
			Return m_Places.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
		m_Places = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_Places.GetEnumerator()
	End Function

	' show this collection on a CMap object
	
	Public Sub Draw(ByVal Map As CMap)
		Dim place As CPlace = Nothing
		For Each place In m_Places
			place.Draw(Map)
		Next
	End Sub

End Class
