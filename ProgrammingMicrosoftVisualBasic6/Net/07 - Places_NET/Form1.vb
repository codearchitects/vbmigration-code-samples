' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const NUM_OF_PLACES As Short = 20
	' the size of the problem
	Private Const PERC_OF_SEGMENTS As Single = 0.1
	' affects number of place connections
	
	Private Map As CMap ' the top of the hierarchy
	
	Private Sub Form_Load() Handles MyBase.Load
		picMap.ScaleWidth = 4300
		picMap.ScaleHeight = 4300
		
		InitTheData()
		Map.Draw()
		
		Dim place As CPlace = Nothing
		For Each place In Map.Places
			cboFrom.AddItem(place.Name)
			cboTo.AddItem(place.Name)
		Next
		cboFrom.ListIndex = 0
		cboTo.ListIndex = 1
	End Sub

	Private Sub InitTheData()
		' create the Map, and link it to the PictureBox control
		Map = New CMap()
		Map.Surface = picMap
		
		' add a few random places to the map
		Dim i As Short
		Dim j As Short
		For i = 1 To NUM_OF_PLACES
			Map.Places.Create("Place#" & i, Int(Rnd() * 4000) + 100, Int(Rnd() * 4000) + 100)
		Next
		
		' add a few random connection between them
		With Map.Places
			For i = 1 To .Count - 1
				For j = i + 1 To .Count
					' decide if we want a connection or not
					If Rnd() < PERC_OF_SEGMENTS Then 
						' connect the two points
						.Item(i).Segments.Create(.Item(i), .Item(j))
					End If
				Next
			Next
		End With
		
	End Sub

	Private Sub cmdRedraw_Click() Handles cmdRedraw.Click
		Map.Draw()
	End Sub

	Private Sub cmdFind_Click() Handles cmdFind.Click
		If cboFrom.Text = cboTo.Text Then 
			MsgBox6("Select different To/From places", MsgBoxStyle.Exclamation)
			Exit Sub
		End If
		
		Dim BestRoute As New CRoute
		BestRoute.StartPlace = Map.Places(cboFrom)
		BestRoute.EndPlace = Map.Places(cboTo)
		
		BestRoute.GetBestPath()
		
		' highlight the result
		Map.Draw()
		If BestRoute.Path.Distance Then 
			With BestRoute.Path
				.Draw(Map, VBRUN.ColorConstants.vbRed)
				ShowStatus("Total Distance = " & .Distance)
			End With
		Else
			MsgBox6("No valid path exists", MsgBoxStyle.Exclamation)
		End If
	End Sub

	Public Sub ShowStatus(ByVal Msg As String)
		picStatus.Cls()
		picStatus.PrintLine(Msg)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		' some intelligent resizing
		Frame1.Left = ScaleWidth - Frame1.Width - 200
		cmdRedraw.Left = Frame1.Left + (Frame1.Width - cmdRedraw.Width) / 2
		picMap.Move(0, 0, Frame1.Left - 200, ScaleHeight - picStatus.Height - 200)
		
		picMap.ScaleWidth = 4300
		picMap.ScaleHeight = 4300
		
	End Sub

End Class
