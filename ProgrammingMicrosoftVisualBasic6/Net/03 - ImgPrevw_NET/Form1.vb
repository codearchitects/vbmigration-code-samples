' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		Drive1.Drive = "c:"
		Dir1.Path = "c:\windows"
		File1.Pattern = "*.bmp;*.dib;*.wmf;*.emf;*.gif;*.jpg"
	End Sub

	Private Sub Drive1_Change() Handles Drive1.Change
		' beware: the Drive property also returns the volume label
		Dir1.Path = VB.Left(Drive1.Drive, 1) & ":\"
	End Sub

	Private Sub Dir1_Change() Handles Dir1.Change
		File1.Path = Dir1.Path
	End Sub

	Private Sub File1_Click() Handles File1.Click
		' load the image in the hidden Image control
		LoadImage(File1.Path & IIf(VB.Right(File1.Path, 1) <> "\", "\", "") & File1.FileName)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		On Error Resume Next 
		File1.Height = ScaleHeight - File1.Top
		picPreview.Move(picPreview.Left, picPreview.Top, ScaleWidth - picPreview.Left, ScaleHeight - picPreview.Top)
		ShowImage()
	End Sub

	Private Sub optActual_Click() Handles optActual.Click
		ShowImage()
	End Sub

	Private Sub optStretch_Click() Handles optStretch.Click
		ShowImage()
	End Sub

	Private Sub optTile_Click() Handles optTile.Click
		ShowImage()
	End Sub

	Public Sub LoadImage(ByRef filename As String)
		On Error Resume Next 
		imgHidden.Picture = LoadPicture6(filename)
		If Err.Number Then 
			MsgBox6("Unable to load file " & filename, MsgBoxStyle.Exclamation)
			Exit Sub
		End If
		' show it,and modify the form's caption
		' UPGRADE NOTE: order of ShowImage and Caption assigned has been reversed to avoid undesired refresh for the PictureBox
		Caption = filename & "- Image Preview"
		ShowImage()
	End Sub

	Public Sub ShowImage()
		' show the image
		Dim x As Single
		Dim y As Single
		
		If optActual.Value Then 
			' show in the center
			picPreview.Cls()
			picPreview.PaintPicture(imgHidden.Picture, (picPreview.ScaleWidth - imgHidden.Width) / 2, (picPreview.ScaleHeight - imgHidden.Height) / 2)
		ElseIf optStretch.Value Then 
			' stretch
			picPreview.PaintPicture(imgHidden.Picture, 0, 0, picPreview.ScaleWidth, picPreview.ScaleHeight)
		ElseIf optTile.Value Then 
			' tile
			' this code only works if imgHidden.BorderStyle = 0
			
			x = 0
			Do While x < picPreview.ScaleWidth
				y = 0
				Do While y < picPreview.ScaleHeight
					picPreview.PaintPicture(imgHidden.Picture, x, y)
					y += imgHidden.Height
				Loop
				x += imgHidden.Width
			Loop
		End If
		
	End Sub

End Class
