' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class ControlItems
	Implements System.Collections.IEnumerable

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	' this class raises an event in the parent form
	Public Event Validate(ByRef Item As ControlItem, ByRef Cancel As Boolean)
	
	' The private collection used to hold the real data
	Private m_ControlItems As New Collection
	
	' Add a new ControlItem item to the collection
	
	''' <summary>
	''' Adds a member to a Collection object
	''' </summary>
	Public Function Add(ByRef ctrl As Object) As ControlItem
	' UPGRADE_INFO (#0551): The 'ctrl' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim newItem As New ControlItem
		newItem.Init(ctrl, Me)
		
		' add to the private collection
		m_ControlItems.Add(newItem)
		' return the new item to the caller
		Return newItem
	End Function

	' Remove an item from the collection
	
	''' <summary>
	''' Removes a member from a Collection object
	''' </summary>
	Public Sub Remove(ByRef index As Object)
	' UPGRADE_INFO (#0501): The 'Remove' member isn't used anywhere in current application.
	' UPGRADE_INFO (#0551): The 'index' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		m_ControlItems.Remove(index)
	End Sub

	' Return a ControlItem item from the collection
	
	''' <summary>
	''' Returns a specific member of a Collection object either by position or key
	''' </summary>
	<System.Runtime.InteropServices.DispId(0)> _
	Public Default ReadOnly Property Item(ByVal index As Object) As ControlItem
			Get
	' UPGRADE_INFO (#0501): The 'Item' member isn't used anywhere in current application.
		Return m_ControlItems.Item(index)
		End Get
	End Property

	' Return the number of items in the collection
	
	''' <summary>
	''' Returns the number of members in a collection
	''' </summary>
	Public ReadOnly Property Count() As Integer
	' UPGRADE_INFO (#0501): The 'Count' member isn't used anywhere in current application.
		Get
			Return m_ControlItems.Count()
	 	End Get
	End Property

	' Remove all items from the collection
	
	''' <summary>
	''' Removes all members from a Collection object
	''' </summary>
	Public Sub Clear()
	' UPGRADE_INFO (#0501): The 'Clear' member isn't used anywhere in current application.
		m_ControlItems = New Collection()
	End Sub

	' Implement support for enumeration (For Each)
	
	Public Function NewEnum() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
		' delegate to the private collection
		Return m_ControlItems.GetEnumerator()
	End Function

	'---------------------------------------------
	' Friend Subs called when a ControlItem
	' receives an event from Visual Basic
	'---------------------------------------------
	
	Friend Sub Notify_Validate(ByRef Item As ControlItem, ByRef Cancel As Boolean)
	' UPGRADE_INFO (#0551): The 'Item' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'Cancel' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' raise a Validate event in the parent form
		RaiseEvent Validate(Item, Cancel)
	End Sub

End Class
