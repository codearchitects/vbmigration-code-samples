' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class CMap

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------
	' The CMap class
	'----------------------------

	' where items are displayed (form, picture box or printer)
	Public Surface As Object
	' the collection of Places on this map
	Public Places As New CPlaces
	
	' redraw this map
	Public Sub Draw()
		Dim place As CPlace = Nothing
		Dim segment As CSegment = Nothing
		Surface.Cls
		For Each place In Places
			' display the place's name and position
			place.Draw(Me)
			For Each segment In place.Segments
				' displays all the segments from that place
				' don't redraw the same segment twice
				If segment.PlaceA Is place Then 
					segment.Draw(Me)
				End If
			Next
		Next
	End Sub

	' graphic methods
	
	Public Sub DrawText(ByVal X As Single, ByVal Y As Single, ByVal Text As String, Optional ByVal color As Integer = VBRUN.ColorConstants.vbBlack)
		Surface.CurrentX = X
		Surface.CurrentY = Y
		Surface.ForeColor = FromOleColor6(color)
		Surface.Print(Text)
	End Sub

	Public Sub DrawLine(ByVal X As Single, ByVal Y As Single, ByVal X2 As Single, ByVal Y2 As Single, Optional ByVal color As Integer = VBRUN.ColorConstants.vbBlack)
		Surface.Line(VBRUN.GraphicsOptions.None, X, Y, X2, Y2, color)
	End Sub

	Public Sub DrawCircle(ByVal X As Single, ByVal Y As Single, ByVal Radius As Single, Optional ByVal color As Integer = VBRUN.ColorConstants.vbBlack)
		Surface.Circle(VBRUN.GraphicsOptions.None, X, Y, Radius, color)
	End Sub

End Class
