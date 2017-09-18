' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CPlace

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------
	' The CPlace class
	'----------------------------

	<System.Runtime.InteropServices.DispId(0)> _
	Public Name As String = "" ' a unique name
	Public X As Single
	Public Y As Single ' X-Y coordinates
	Public Segments As New CSegments ' all the connected segments
	
	Public Ignore As Boolean ' used in the search algorithm
	
	' a simple constructor method
	
	Friend Sub Init(ByVal Name As String, ByVal X As Single, ByVal Y As Single)
		Me.Name = Name
		Me.X = X
		Me.Y = Y
	End Sub

	' get the collection of all the CPlaces in this collection that
	' appear to be connected to the Place passed as argument
	
	Public ReadOnly Property ConnectedPlaces(Optional ByVal IncludeIgnore As Boolean = False) As CPlaces
		Get
			Dim segment As CSegment = Nothing
			Dim place As CPlace = Nothing
			
			ConnectedPlaces = New CPlaces()
			
			' scan all the segments that start from this place
			For Each segment In Segments
				' get the "other" place in the segment
				' add to the result if it meets all requirements
				place = segment.OtherPlace(Me)
				If place.Ignore = False Or IncludeIgnore Then 
					ConnectedPlaces.Add(place)
				End If
			Next
	 	End Get
	End Property

	' get the segment that connects to another CPlace object
	' or nothing if there isn't such a segment
	
	Public Function GetSegment(ByVal OtherPlace As CPlace) As CSegment
		Dim segment As CSegment = Nothing
		For Each segment In Segments
			If segment.OtherPlace(Me) Is OtherPlace Then 
				Return segment
			End If
		Next
	End Function

	' show on a CMap object
	
	Public Sub Draw(ByVal Map As CMap)
		Map.DrawCircle(X, Y, 50)
		Map.DrawText(X, Y + 100, Name)
	End Sub

End Class
