' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CSegments
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'---------------------------------------
	' The CSegments collection class
	'---------------------------------------

	' The private collection used to hold the real data
	Private m_Segments As New Collection
	
	' Create a new CSegment item and add it to the collection
	
	''' <summary>
	''' Adds a member to a Collection object
	''' </summary>
	Public Function Create(ByVal PlaceA As CPlace, ByVal PlaceB As CPlace, Optional ByVal Distance As Object = VB6Missing) As CSegment
		Dim newItem As New CSegment
		
		newItem.Init(PlaceA, PlaceB, Distance)
		' also add to the Segments collection of each Place
		PlaceA.Segments.Add(newItem)
		PlaceB.Segments.Add(newItem)
		
		' add to the private collection, just once
		On Error Resume Next 
		m_Segments.Add(newItem, newItem.Name)
		
		' return the new item to the caller
		Return newItem
	End Function

	' Add a CSegment item to the collection (must exist already)
	
	Public Function Add(ByVal segment As CSegment) As CSegment
		Dim key As String = ""
		On Error Resume Next 
		' on error avoids adding an item twice
		m_Segments.Add(segment, segment.Name)
		Return segment
	End Function

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByVal index As Object)
		m_Segments.Remove(GetDefaultMember6(index))
	End Sub

	' Return a CSegment item from the collection, or Nothing if not there
	
	''' <summary>
	''' Returns a specific member of a Collection object either by position or key
	''' </summary>
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As CSegment
			Get
		On Error Resume Next 
		Return m_Segments.Item(GetDefaultMember6(index))
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
		Get
			Return m_Segments.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
		m_Segments = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_Segments.GetEnumerator()
	End Function

	' draw this series of segments on a CMap object
	
	Public Sub Draw(ByVal Map As CMap, Optional ByVal Color As Object = VB6Missing)
		Dim segment As CSegment = Nothing
		For Each segment In m_Segments
			segment.Draw(Map, Color)
		Next
	End Sub

	' return the total Distance
	
	Public ReadOnly Property Distance() As Single
		Get
			Dim result As Single
			Dim segment As CSegment = Nothing
			For Each segment In m_Segments
				result += segment.Distance
			Next
			Return result
	 	End Get
	End Property

End Class
