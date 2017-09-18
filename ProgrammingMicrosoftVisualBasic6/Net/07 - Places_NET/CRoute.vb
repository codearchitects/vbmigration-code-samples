' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CRoute

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'---------------------------------------
	' The CRoute class
	'---------------------------------------

	Public StartPlace As CPlace ' where we start from
	Public EndPlace As CPlace ' where we want to go
	Public Path As New CSegments ' the result path
	
	' finds the best path according and return its length
	' returns Empty if Path is Nothing
	
	Public Function GetBestPath() As Object
		Dim place As CPlace = Nothing
		Dim segment As CSegment = Nothing
		Dim minSegment As CSegment = Nothing
		Dim currCost As Object = Nothing
		Dim minCost As Object = Nothing
		Dim route As CRoute = Nothing
		Dim minPath As CRoute = Nothing
		
		' if the end point is directly connected, we have completed the search
		' NOTE: this algorithm always selects the direct path between
		'       two places, even if there is an indirect but more convenient path
		segment = StartPlace.GetSegment(EndPlace)
		If Not (segment Is Nothing) Then 
			' create the result
			Path = New CSegments()
			Path.Add(segment)
			' return the expected value
			Return Path.Distance
		End If
		
		' the two places aren't connected directly, so we must
		' test each segment recursively
		
		' from now on, ignore StartPlace in searches
		StartPlace.Ignore = True
		
		For Each place In StartPlace.ConnectedPlaces
			' let's create a new CRoute, that excludes the StartPlace
			route = New CRoute()
			route.StartPlace = place
			route.EndPlace = EndPlace
			
			' find the best route possible
			SetDefaultMember6(currCost, GetDefaultMember6(route.GetBestPath()))
			
			If Not IsEmpty6(currCost) Then 
				' we found a valid path
				segment = StartPlace.GetSegment(place)
				SetDefaultMember6(currCost, GetDefaultMember6(currCost) + segment.Distance)
				
				' if is this the best route so far, remember it
				If IsEmpty6(minCost) Or GetDefaultMember6(currCost) < GetDefaultMember6(minCost) Then 
					minPath = route
					minSegment = segment
					SetDefaultMember6(minCost, GetDefaultMember6(currCost))
				End If
			End If
		Next
		
		' restore regular functioning
		StartPlace.Ignore = False
		
		' if we found at least one valid path
		If Not IsEmpty6(minCost) Then 
			' Init Path property - we must build this collection manually
			' this is the first segment
			Path.Add(minSegment)
			' these are the following ones
			For Each segment In minPath.Path
				Path.Add(segment)
			Next
			' return result
			Return GetDefaultMember6(minCost)
		End If
	End Function

End Class
