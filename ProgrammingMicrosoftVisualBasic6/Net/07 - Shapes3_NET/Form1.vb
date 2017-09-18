' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' this is a module level variable
	Private Figures As Collection

	Private Sub Form_Load() Handles MyBase.Load
		CreateFigures()
	End Sub

	Private Sub cmdRedraw_Click() Handles cmdRedraw.Click
		RedrawFigures()
	End Sub

	' create a set of figures
	Private Sub CreateFigures()
		Figures = New Collection()
		Figures.Add(New_CRectangle(1000, 500, 1400, 1200, , VBRUN.ColorConstants.vbRed))
		Figures.Add(New_CRectangle(4000, 500, 1400, 1200, , VBRUN.ColorConstants.vbCyan))
		Figures.Add(New_CEllipse(2500, 2000, 1400, 1200, , VBRUN.ColorConstants.vbGreen))
		Figures.Add(New_CEllipse(3500, 3000, 2500, 2000, , VBRUN.ColorConstants.vbYellow))
		Figures.Add(New_CSquare(1000, 3600, 1400, , VBRUN.ColorConstants.vbBlack))
		Figures.Add(New_CSquare(1100, 3700, 1400, , VBRUN.ColorConstants.vbWhite))
		Figures.Add(New_CLine(2400, 1100, 4000, 1100, VBRUN.ColorConstants.vbBlue))
		Figures.Add(New_CLine(1700, 1700, 1700, 4000, VBRUN.ColorConstants.vbBlue))
		Figures.Add(New_CLine(1700, 4000, 3500, 4000, VBRUN.ColorConstants.vbBlue))
	End Sub

	' redraw the contents in Figures
	Public Sub RedrawFigures()
		Dim shape As IShape = Nothing
		picView.Cls()
		For Each shape In Figures
			shape.Draw(picView)
		Next
	End Sub

	Private Sub cmdMove_Click(ByRef Index As Short)
		Dim shape As IShape = Nothing
		For Each shape In Figures
			Select Case Index
			Case 0: shape.Move(0, -100) ' up
			Case 1: shape.Move(0, 100) ' down
			Case 2: shape.Move(-100, 0) ' left
			Case 3: shape.Move(100, 0) ' right
			End Select
		Next
		RedrawFigures()
	End Sub

	Private Sub cmdZoom_Click(ByRef Index As Short)
		Dim shape As IShape = Nothing
		For Each shape In Figures
			If Index = 0 Then 
				shape.Zoom(1.1) ' enlarge
			Else
				shape.Zoom(0.9) ' reduce
			End If
		Next
		RedrawFigures()
	End Sub

End Class
