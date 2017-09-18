' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class ObjGrid3D

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region

	Private xmin As Single ' Min X and Y values.
	Private Zmin As Single
	Private dx As Single ' Spacing between rows of data.
	Private dz As Single
	Private NumX As Short ' Number of X and Y entries.
	Private NumZ As Short
	Private Points(,) As Point3D ' Data values.
	
	' Draw a line between the points. Set the max and min values for the line.
	
	Public Sub DrawAndSetLine(ByVal canvas As Object, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single, ByRef hi() As Short, ByRef lo() As Short)
	' UPGRADE_INFO (#0511): The 'DrawAndSetLine' member is referenced only by members that haven't found to be used in the current project/solution.
		Dim tmp As Single
		Dim ix As Short
		Dim iy As Short
		Dim y As Single
		Dim dy As Single
		
		' Deal only with integers.
		x1 = CShort(x1)
		y1 = CShort(y1)
		x2 = CShort(x2)
		y2 = CShort(y2)
		
		' Make x1 < x2.
		If x2 < x1 Then 
			tmp = x1
			x1 = x2
			x2 = tmp
			tmp = y1
			y1 = y2
			y2 = tmp
		End If
		
		' Draw the line.
		canvas.Line(VBRUN.GraphicsOptions.None, x1, y1, x2, y2)
		
		' Deal with vertical lines separately.
		If x1 = x2 Then 
			If y1 < y2 Then 
				lo(x1) = y1
				hi(x1) = y2
			Else
				lo(x1) = y2
				hi(x1) = y1
			End If
			Exit Sub
		End If
		
		' Deal with non-vertical lines.
		dy = (y2 - y1) / CShort(x2 - x1)
		y = y1
		For ix = x1 To x2
			iy = CShort(y)
			
			lo(ix) = iy
			hi(ix) = iy
			
			y += dy
		Next
	End Sub

	' Draw a line between the points using and updating the max and min arrays.

	Public Sub DrawLine(ByVal canvas As Object, ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single, ByRef hi() As Short, ByRef lo() As Short)
	' UPGRADE_INFO (#0511): The 'DrawLine' member is referenced only by members that haven't found to be used in the current project/solution.
		Dim tmp As Single
		Dim ix As Short
		Dim iy As Short
		Dim y As Single
		Dim dy As Single
		Dim firstx As Short
		Dim firsty As Short
		Dim skipping As Boolean
		Dim above As Boolean
		
		' Deal only with integers.
		x1 = CShort(x1)
		y1 = CShort(y1)
		x2 = CShort(x2)
		y2 = CShort(y2)
		
		' Make x1 < x2.
		If x2 < x1 Then 
			tmp = x1
			x1 = x2
			x2 = tmp
			tmp = y1
			y1 = y2
			y2 = tmp
		End If
		
		' Deal with vertical lines separately.
		If x1 = x2 Then 
			' Make y1 < y2.
			If y2 < y1 Then 
				tmp = y1
				y1 = y2
				y2 = tmp
			End If
			If y1 <= lo(x1) Then 
				If y2 <= lo(x1) Then 
					canvas.Line(VBRUN.GraphicsOptions.None, x1, y1, x2, y2)
				Else
					canvas.Line(VBRUN.GraphicsOptions.None, x1, y1, x2, lo(x2))
				End If
				lo(x1) = y1
			End If
			If y2 >= hi(x2) Then 
				If y1 >= hi(x2) Then 
					canvas.Line(VBRUN.GraphicsOptions.None, x1, y1, x2, y2)
				Else
					canvas.Line(VBRUN.GraphicsOptions.None, x1, hi(x1), x2, y2)
				End If
				hi(x2) = y2
			End If
			Exit Sub
		End If
		
		' Deal with non-vertical lines.
		dy = (y2 - y1) / CShort(x2 - x1)
		y = y1
		
		' Find the first visible point.
		skipping = True
		For ix = x1 To x2
			iy = CShort(y)
			' See if this point is visible.
			If iy <= lo(ix) Then 
				If skipping Then 
					' Start a new line below.
					skipping = False
					above = False
					firstx = ix
					firsty = lo(ix)
				End If
			ElseIf iy >= hi(ix) Then 
				If skipping Then 
					' Start a new line above.
					skipping = False
					above = True
					firstx = ix
					firsty = hi(ix)
				End If
			Else
				' This point is not visible.
				If Not skipping Then 
					' Draw the previous visible line.
					If above Then 
						' The line is coming from
						' above. Connect it to hi(ix).
						canvas.Line(VBRUN.GraphicsOptions.None, firstx, firsty, ix, hi(ix))
					Else
						' The line is coming from
						' below. Connect it to lo(ix).
						canvas.Line(VBRUN.GraphicsOptions.None, firstx, firsty, ix, lo(ix))
					End If
					
					skipping = True
				End If
			End If
			
			If iy < lo(ix) Then  lo(ix) = iy
			If iy > hi(ix) Then  hi(ix) = iy
			
			y += dy
		Next
		
		' Draw to the last point if necessary.
		If Not skipping Then  canvas.Line(VBRUN.GraphicsOptions.None, firstx, firsty, x2, y2)
	End Sub

	' Create the Points array.
	Public Sub SetBounds(ByVal x1 As Single, ByVal deltax As Single, ByVal xnum As Short, ByVal z1 As Single, ByVal deltaz As Single, ByVal znum As Short)
		Dim i As Short
		Dim j As Short
		Dim x As Single
		Dim z As Single
		
		xmin = x1
		Zmin = z1
		dx = deltax
		dz = deltaz
		NumX = xnum
		NumZ = znum
		Redim6(Points, 0, NumX, 0, NumZ)
		
		x = xmin
		For i = 1 To NumX
			z = Zmin
			For j = 1 To NumZ
				Points(i, j).coord(1) = x
				Points(i, j).coord(2) = 0
				Points(i, j).coord(3) = z
				Points(i, j).coord(4) = 1#
				z += dz
			Next
			x += dx
		Next
	End Sub
	
	' Save the indicated data value.
	Public Sub SetValue(ByVal x As Single, ByVal y As Single, ByVal z As Single)
		Dim i As Short
		Dim j As Short
		
		i = (x - xmin) / dx + 1
		j = (z - Zmin) / dz + 1
		Points(i, j).coord(2) = y
	End Sub

	' Return a string indicating the object type.
	Public ReadOnly Property ObjectType() As String
	' UPGRADE_INFO (#0501): The 'ObjectType' member isn't used anywhere in current application.
		Get
			Return "GRID"
	 	End Get
	End Property

	' Apply a transformation matrix which may not
	' contain 0, 0, 0, 1 in the last column to the
	' object.
	Public Sub ApplyFull(ByVal M(,) As Single)
	' UPGRADE_INFO (#0501): The 'ApplyFull' member isn't used anywhere in current application.
		Dim i As Short
		Dim j As Short
		
		For i = 1 To NumX
			For j = 1 To NumZ
				m3ApplyFull(Points(i, j).coord, M, Points(i, j).trans)
			Next
		Next
	End Sub

	' Apply a transformation matrix to the object.
	Public Sub Apply(ByVal M(,) As Single)
	' UPGRADE_INFO (#0501): The 'Apply' member isn't used anywhere in current application.
		Dim i As Short
		Dim j As Short
		
		For i = 1 To NumX
			For j = 1 To NumZ
				m3Apply(Points(i, j).coord, M, Points(i, j).trans)
			Next
		Next
	End Sub

	' Draw the grid without hidden surfaces using the hi-lo algorithm
	
	Public Sub DrawWithoutHidden(ByVal canvas As Object, Optional ByVal r As Object = VB6Missing)
	' UPGRADE_INFO (#0511): The 'DrawWithoutHidden' member is referenced only by members that haven't found to be used in the current project/solution.
		Dim xmin As Short
		Dim xmax As Short
		Dim lo() As Short
		Dim hi() As Short
		Dim ix As Short
		Dim i As Short
		Dim j As Short
		
		' Bound the X values.
		xmin = Points(1, 1).trans(1)
		xmax = xmin
		For i = 1 To NumX
			For j = 1 To NumZ
				ix = CShort(Points(i, j).trans(1))
				If xmin > ix Then  xmin = ix
				If xmax < ix Then  xmax = ix
			Next
		Next
		
		' Create the max and min arrays.
		ReDim lo(xmax)
		ReDim hi(xmax)
		
		' Draw the X and Z front edges.
		For i = 2 To NumX
			' Draw the edge between
			' Points(i - 1, NumZ) and Points(i, NumZ)
			' and set max and min for its values.
			DrawAndSetLine(canvas, Points(i - 1, NumZ).trans(1), Points(i - 1, NumZ).trans(2), Points(i, NumZ).trans(1), Points(i, NumZ).trans(2), hi, lo)
		Next
		For i = 2 To NumZ
			' Draw the edge between
			' Points(NumX, i - 1) and Points(NumX, i)
			' and set max and min for its values.
			DrawAndSetLine(canvas, Points(NumX, i - 1).trans(1), Points(NumX, i - 1).trans(2), Points(NumX, i).trans(1), Points(NumX, i).trans(2), hi, lo)
		Next

		For i = NumX - 1 To 1 Step -1
			For j = NumZ - 1 To 1 Step -1
				
				' This only happens with perspective projection.
				
				If Points(i + 1, j).trans(1) >= Points(i, j).trans(1) Then 
					DrawLine(canvas, Points(i, j).trans(1), Points(i, j).trans(2), Points(i, j + 1).trans(1), Points(i, j + 1).trans(2), hi, lo)
					DrawLine(canvas, Points(i, j).trans(1), Points(i, j).trans(2), Points(i + 1, j).trans(1), Points(i + 1, j).trans(2), hi, lo)
				Else
					DrawLine(canvas, Points(i, j).trans(1), Points(i, j).trans(2), Points(i + 1, j).trans(1), Points(i + 1, j).trans(2), hi, lo)
					DrawLine(canvas, Points(i, j).trans(1), Points(i, j).trans(2), Points(i, j + 1).trans(1), Points(i, j + 1).trans(2), hi, lo)
				End If
			Next
		Next
	End Sub

	' Draw the transformed points on the PictureBox.
	
	Public Sub Draw(ByVal canvas As Object, Optional ByVal r As Object = VB6Missing)
	' UPGRADE_INFO (#0501): The 'Draw' member isn't used anywhere in current application.
		DrawWithoutHidden(canvas, r)
	End Sub

End Class
