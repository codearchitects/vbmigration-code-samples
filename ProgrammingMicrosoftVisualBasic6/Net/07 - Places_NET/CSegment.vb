' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CSegment

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------
	' The CSegment class
	'----------------------------

	Public PlaceA As CPlace
	Public PlaceB As CPlace
	
	Private m_Distance As Object
	
	' a simple constructor method
	
	Friend Sub Init(ByVal PlaceA As CPlace, ByVal PlaceB As CPlace, Optional ByVal Distance As Object = VB6Missing)
		Me.PlaceA = PlaceA
		Me.PlaceB = PlaceB
		If Not IsMissing6(Distance) Then  Me.Distance = GetDefaultMember6(Distance)
	End Sub

	' Name is a read-only property, mostly used to identify this
	' item in a CSegments collection
	
	Public ReadOnly Property Name() As String
		Get
			If StrComp(PlaceA.Name, PlaceB.Name, CompareMethod.Text) < 0 Then 
				Return PlaceA.Name & " - " & PlaceB.Name
			Else
				Return PlaceB.Name & " - " & PlaceA.Name
			End If
	 	End Get
	End Property

	' The Distance property

	Public Property Distance() As Single
		Get
			If IsEmpty6(m_Distance) Then 
				' if Distance is unknown, use an approximization
				Return Int(Math.Sqrt((PlaceA.X - PlaceB.X) ^ 2 + (PlaceA.Y - PlaceB.Y) ^ 2))
			Else
				' else use exact distance
				Return GetDefaultMember6(m_Distance)
			End If
	 	End Get
		Set(ByVal newValue As Single)
			SetDefaultMember6(m_Distance, newValue)
	 	End Set
	End Property

	' show on a CMap object
	
	Public Sub Draw(ByVal Map As CMap, Optional ByVal Color As Object = VB6Missing)
		If IsMissing6(Color) Then  SetDefaultMember6(Color, VBRUN.ColorConstants.vbBlue)
		Map.DrawLine(ByVal6(PlaceA.X), ByVal6(PlaceA.Y), ByVal6(PlaceB.X), ByVal6(PlaceB.Y), GetDefaultMember6(Color))
	End Sub

	' return the "other" place object in this segment
	' or Nothing if this CPlace object isn't in the segment
	
	Public Function OtherPlace(ByVal place As CPlace) As CPlace
		If PlaceA Is place Then 
			Return PlaceB
		ElseIf PlaceB Is place Then 
			Return PlaceA
		End If
	End Function

End Class
