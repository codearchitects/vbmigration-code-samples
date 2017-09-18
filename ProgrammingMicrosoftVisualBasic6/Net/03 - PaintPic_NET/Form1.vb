' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	
	Private flipped As Short ' bit field
	
	Private Sub Form_Load() Handles MyBase.Load
		' we need to make the form visible, first
		Show()
		DoEvents6()
		' then we can show the image (this cause a refresh)
		cboDissolve.ListIndex = 0
	End Sub

	Private Sub cboZoom_Click() Handles cboZoom.Click
		cmdShow.Value = True
	End Sub

	Private Sub chkTile_Click() Handles chkTile.Click
		cmdShow.Value = True
	End Sub

	Private Sub cboDissolve_Click() Handles cboDissolve.Click
		fraZoom.Enabled = (cboDissolve.ListIndex = 0)
		cmdHorizontal.Enabled = (cboDissolve.ListIndex = 0)
		cmdVertical.Enabled = (cboDissolve.ListIndex = 0)
		cmdBoth.Enabled = (cboDissolve.ListIndex = 0)
		cmdShow.Value = True
	End Sub

	Private Sub cmdShow_Click() Handles cmdShow.Click
		If cboDissolve.ListIndex = 0 Then 
			ShowImage()
		Else
			DissolveImage()
		End If
		flipped = 0
	End Sub

	Public Sub ShowImage()
		' show the hidden image
		Dim destWidth As Single
		Dim destHeight As Single
		Dim destX As Single
		Dim destY As Single
		Dim stepX As Single
		Dim stepY As Single
		
		' determine zoom factor
		Select Case cboZoom.ListIndex
		Case cboZoom.ListCount - 4
			' fit width
			destWidth = picDest.ScaleWidth
			destHeight = picSource.ScaleHeight * (destWidth / picSource.ScaleWidth)
		Case cboZoom.ListCount - 3
			' fit height
			destHeight = picDest.ScaleHeight
			destWidth = picSource.ScaleWidth * (destHeight / picSource.ScaleWidth)
		Case cboZoom.ListCount - 2
			' fit page (no distorsion)
			destWidth = picDest.ScaleWidth
			destHeight = picDest.ScaleHeight
			If destWidth / picSource.ScaleWidth < destHeight / picDest.ScaleHeight Then 
				' fit width, adjust height
				destHeight = picSource.ScaleHeight * (destWidth / picSource.ScaleWidth)
			Else
				' fit height, adjust width
				destWidth = picSource.ScaleWidth * (destHeight / picSource.ScaleWidth)
			End If
		Case cboZoom.ListCount - 1
			' fit page (distorsion)
			destWidth = picDest.ScaleWidth
			destHeight = picDest.ScaleHeight
		Case Else
			On Error Resume Next 
			destWidth = picSource.ScaleWidth * Val(cboZoom.Text) / 100
			destHeight = picSource.ScaleHeight * Val(cboZoom.Text) / 100
			If Err.Number Then  Exit Sub
		End Select
		
		picDest.Cls()
		
		If chkTile.Value = VBRUN.CheckBoxConstants.vbChecked Then 
			' tile images
			For destX = 0 To picDest.ScaleWidth Step destWidth
				For destY = 0 To picDest.ScaleHeight Step destHeight
					picDest.PaintPicture(picSource.Picture, destX, destY, destWidth, destHeight)
				Next
			Next
		Else
			' simple copy
			picDest.PaintPicture(picSource.Picture, 0, 0, destWidth, destHeight)
		End If
	End Sub

	Public Sub DissolveImage()
		' show the hidden image
		Dim srcWidth As Single
		Dim srcHeight As Single
		Dim srcX As Single
		Dim srcY As Single
		Dim destWidth As Single
		Dim destHeight As Single
		Dim destX As Single
		Dim destY As Single
		Dim stepX As Single
		Dim stepY As Single
		Dim i As Short
		
		Const DISSOLVE_STEPS As Short = 20
		
		' most routine below use these values
		srcWidth = picSource.ScaleWidth
		srcHeight = picSource.ScaleHeight
		
		stepX = srcWidth / DISSOLVE_STEPS
		stepY = srcHeight / DISSOLVE_STEPS
		
		picDest.Cls()
		
		Dim xy(DISSOLVE_STEPS * DISSOLVE_STEPS, 1) As VBRUN.ShiftConstants
		Dim kx As Short
		Dim ky As Short
		Dim ndx As Short
		Select Case cboDissolve.ListIndex
		Case 1
			' Scroll from Left
			srcX = srcWidth
			For i = 1 To DISSOLVE_STEPS
				srcX -= stepX
				picDest.PaintPicture(picSource.Picture, 0, 0, , , srcX, 0)
				RefreshAndDelay()
			Next
		Case 2
			' Scroll from right
			destX = srcWidth
			For i = 1 To DISSOLVE_STEPS
				destX -= stepX
				picDest.PaintPicture(picSource.Picture, destX, 0, srcWidth - destX, , , , srcWidth - destX)
				RefreshAndDelay()
			Next
		Case 3
			' Scroll from Top
			srcY = srcHeight
			For i = 1 To DISSOLVE_STEPS
				srcY -= stepY
				picDest.PaintPicture(picSource.Picture, 0, 0, , , 0, srcY)
				RefreshAndDelay()
			Next
		Case 4
			' Scroll from bottom
			destY = srcHeight
			For i = 1 To DISSOLVE_STEPS
				destY -= stepY
				picDest.PaintPicture(picSource.Picture, 0, destY, , , , , , srcHeight - destY)
				RefreshAndDelay()
			Next
			
		Case 5
			' Roll from Left
			destWidth = 0
			For i = 1 To DISSOLVE_STEPS
				destWidth += stepX
				picDest.PaintPicture(picSource.Picture, 0, 0, , , 0, 0, destWidth)
				RefreshAndDelay()
			Next
		Case 6
			' Roll from right
			destX = srcWidth
			For i = 1 To DISSOLVE_STEPS
				destX -= stepX
				picDest.PaintPicture(picSource.Picture, destX, 0, , , destX, 0, srcWidth - destX)
				RefreshAndDelay()
			Next
		Case 7
			' Roll from Top
			destHeight = 0
			For i = 1 To DISSOLVE_STEPS
				destHeight += stepY
				picDest.PaintPicture(picSource.Picture, 0, 0, , , 0, 0, , destHeight)
				RefreshAndDelay()
			Next
		Case 8
			' Roll from bottom
			destY = srcHeight
			For i = 1 To DISSOLVE_STEPS
				destY -= stepY
				picDest.PaintPicture(picSource.Picture, 0, destY, , , 0, destY, , srcHeight - destY)
				RefreshAndDelay()
			Next
		Case 9
			' explode
			destX = srcWidth / 2
			destY = srcHeight / 2
			srcWidth = 0
			srcHeight = 0
			For i = 1 To DISSOLVE_STEPS
				destX = destX - stepX / 2
				destY = destY - stepY / 2
				srcWidth += stepX
				srcHeight += stepY
				picDest.PaintPicture(picSource.Picture, destX, destY, , , destX, destY, srcWidth, srcHeight)
				RefreshAndDelay()
			Next
		Case 10
			' mosaic
			' first, prepare the matrix of the (X,Y) coordinates
			' for all the tiles
			destX = 0
			For kx = 1 To DISSOLVE_STEPS
				destY = 0
				For ky = 1 To DISSOLVE_STEPS
					i += 1
					xy(i, 0) = destX
					xy(i, 1) = destY
					destY += stepY
				Next
				destX += stepX
			Next
			' this loop picks up a random tile, draws it and then
			' deletes it from the xy() array so that it can't be
			' selected any more
			For ndx = UBound6(xy) To 1 Step -1
				' draw the tile
				i = Int(Rnd() * ndx + 1)
				destX = xy(i, 0)
				destY = xy(i, 1)
				picDest.PaintPicture(picSource.Picture, destX, destY, , , destX, destY, stepX, stepY)
				' delete it from xy() - actually it just replace it
				' with the last item in the array
				xy(i, 0) = xy(ndx, 0)
				xy(i, 1) = xy(ndx, 1)
			Next
		End Select
		
	End Sub

	Private Sub cmdHorizontal_Click() Handles cmdHorizontal.Click
		' flip the image horizontally
		flipped = flipped Xor 1
		ShowFlippedImage()
	End Sub

	Private Sub cmdVertical_Click() Handles cmdVertical.Click
		' flip the image vertically
		flipped = flipped Xor 2
		ShowFlippedImage()
	End Sub

	Private Sub cmdBoth_Click() Handles cmdBoth.Click
		' flip the image on both axis
		flipped = flipped Xor 3
		ShowFlippedImage()
	End Sub

	Public Sub ShowFlippedImage()
		picDest.Cls()
		Select Case flipped
		Case 0
			picDest.PaintPicture(picSource.Picture, 0, 0)
		Case 1
			' flip the image horizontally
			picDest.PaintPicture(picSource.Picture, picSource.ScaleWidth, 0, -picSource.ScaleWidth)
		Case 2
			' flip the image vertically
			picDest.PaintPicture(picSource.Picture, 0, picSource.ScaleHeight, , -picSource.ScaleHeight)
		Case 3
			' flip the image on both axis
			picDest.PaintPicture(picSource.Picture, picSource.ScaleWidth, picSource.ScaleHeight, -picSource.ScaleWidth, -picSource.ScaleHeight)
		End Select
	End Sub

	Public Sub RefreshAndDelay()
		'Refresh
		System.Threading.Thread.Sleep(50)
	End Sub

End Class
