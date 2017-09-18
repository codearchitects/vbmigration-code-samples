' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Friend Structure PALETTEENTRYAPI
	
		Public peRed As Byte
		Public peGreen As Byte
		Public peBlue As Byte
		Public peFlags As Byte
	End Structure

	Private Declare Function GetCurrentObject Lib "gdi32" (ByVal hdc As Integer, ByVal uObjectType As Integer) As Integer
	Private Declare Function GetSystemPaletteEntries Lib "gdi32" (ByVal hdc As Integer, ByVal wStartIndex As Integer, ByVal wNumEntries As Integer, ByRef lpPaletteEntries As PALETTEENTRYAPI) As Integer
	Private Const OBJ_PAL As Short = 5
	
	Private Sub cmdLoadImage_Click() Handles cmdLoadImage.Click
		On Error Resume Next 
		With CommonDialog1
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist
			.Filter = "All files|*.*|Bitmaps (*.bmp;*.dib)|*.bmp;*.dib)"
			.FilterIndex = 2
			.CancelError = True
			.ShowOpen()
			If Err.Number = 0 Then 
				picTestImage.Picture = LoadPicture6(.FileName)
			End If
		End With
	End Sub

	' show the current palette
	
	Public Sub ShowPalette()
		Dim x As Single
		Dim y As Single
		Dim xStep As Single
		Dim yStep As Single
		Dim palIndex As Short
		Dim rgbValue As Integer
		
		Dim curPalette(255) As PALETTEENTRYAPI
		Dim hPalette As Integer = GetCurrentObject(picPalette.hDC, OBJ_PAL)
		GetSystemPaletteEntries(picPalette.hDC, 0, 256, curPalette(0))
		picPalette.ReleaseHdc()
		
		xStep = picPalette.ScaleWidth / 8
		yStep = picPalette.ScaleHeight / 32
		
		For palIndex = 0 To 255
			x = (palIndex \ 32) * xStep
			y = (palIndex Mod 32) * yStep
			' get the RGB value
			With curPalette(palIndex)
				rgbValue = RGB(.peRed, .peGreen, .peBlue)
			End With
			' draw the corresponding block
			picPalette.Line(VBRUN.GraphicsOptions.Step2 Or VBRUN.GraphicsOptions.BoxFilled, x, y, xStep, yStep, rgbValue)
		Next
		
	End Sub

	Private Sub Command1_Click() Handles Command1.Click
		ShowPalette()
	End Sub

End Class
