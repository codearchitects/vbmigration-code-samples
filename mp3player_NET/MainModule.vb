' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module MainModule

	Public Const RGN_OR As Short = 2
	Public Const WM_NCLBUTTONDOWN As Short = &HA1S
	Public Const HTCAPTION As Short = 2
	Public Const HWND_TOPMOST As Short = -1
	Public Const HWND_NOTOPMOST As Short = -2
	Public Const SWP_NOSIZE As Short = &H1S
	Public Const SWP_NOMOVE As Short = &H2S
	Public Const SWP_NOACTIVATE As Short = &H10S
	Public Const SWP_SHOWWINDOW As Short = &H40S
	Public Const SWP_NOZORDER As Integer = &H4I
	
	Public Declare Sub SetWindowPos Lib "user32" (ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
	Public Declare Function GetPixel Lib "gdi32" (ByVal hDC As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
	Public Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
	Public Declare Function CreateRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Public Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
	' A sample by Yaniv Drukman: www.dr-vb.co.il
	' IGNORED: Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	Public Declare Function ReleaseCapture Lib "user32" () As Integer
	Public Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
	Public Declare Function SetTimer Lib "user32" (ByVal hWnd As Integer, ByVal nIDEvent As Integer, ByVal uElapse As Integer, ByVal lpTimerFunc As Integer) As Integer
	Public Declare Function KillTimer Lib "user32" (ByVal hWnd As Integer, ByVal nIDEvent As Integer) As Integer
	Public Declare Function OffsetRgn Lib "gdi32" (ByVal hRgn As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
	Public Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Public Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
	
	Public Declare Function waveOutSetVolume Lib "Winmm" (ByVal wDeviceID As Short, ByVal dwVolume As Integer) As Short
	Public Declare Function waveOutGetVolume Lib "Winmm" (ByVal wDeviceID As Short, ByRef dwVolume As Integer) As Short
	Public Declare Function midiOutSetVolume Lib "Winmm" (ByVal mDeviceID As Short, ByVal dmVolume As Integer) As Short
	Public Declare Function midiOutGetVolume Lib "Winmm" (ByVal mDeviceID As Short, ByRef dmVolume As Integer) As Short
	Public LstData(1000) As String
	
	Public Sub SetVol(ByRef Volume As Short, Optional ByRef Midi As Boolean = False)
		'v = 15
		Dim X As Integer
		If Volume > 50 Then 
			If Volume = 100 Then 
				If Midi Then 
					Call midiOutSetVolume(0, &HFFFFFFFF)
				Else
					Call waveOutSetVolume(0, &HFFFFFFFF)
				End If
			Else
				X = -((32767 / 50) * (100 - Volume))
				If Midi Then 
					Call midiOutSetVolume(0, X + (X * 65536))
				Else
					Call waveOutSetVolume(0, X + (X * 65536))
				End If
			End If
		Else
			X = Int((32767 / 50) * Volume)
			If Midi Then 
				Call midiOutSetVolume(0, X + (X * 65536))
			Else
				Call waveOutSetVolume(0, X + (X * 65536))
			End If
		End If
	End Sub

	Public Function GetVol(Optional ByRef Midi As Boolean = False) As Short
		Dim v As Integer
		Dim X As Integer
		Dim xh As String = ""
		If Midi Then 
			Call midiOutGetVolume(0, X)
		Else
			Call waveOutGetVolume(0, X)
		End If
		xh = HexDec(VB.Right(Hex(X), 4)) ', 16, 10) ') ', 16, 10))
		v = Math.Round(Val(xh) / 655.36)
		Return v
	End Function

	Public Function MakeRegion(ByRef picSkin As VB6PictureBox) As Integer
		
		Dim X As Integer
		Dim Y As Integer
		Dim StartLineX As Integer
		Dim FullRegion As Integer
		Dim LineRegion As Integer
		Dim TransparentColor As Integer
		Dim InFirstRegion As Boolean = True
		Dim InLine As Boolean = False
		Dim hDC As Integer
		Dim PicWidth As Integer
		Dim PicHeight As Integer
		
		hDC = picSkin.hDC
		PicWidth = picSkin.ScaleWidth
		PicHeight = picSkin.ScaleHeight
		
		X = CShort(Y = StartLineX = 0)
		
		' ôåð÷öéä æå éåöøú àæåø òì ôé úîåðä ðúåðä
		' äôåð÷öéä ñåø÷ú àú äùåøåú áúîåðä, åëì äôé÷ñìéí
		' ùàéðí áöáò ùðáçø ìäéåú ù÷åó îåñôéí ìàæåø
		' äöáò äðáçø ìù÷éôåú äåà úîéã äöáò áôéðä äùîàìéú òìéåðä
		TransparentColor = GetPixel(hDC, 0, 0)
		
		For Y = 0 To PicHeight - 1
			For X = 0 To PicWidth - 1
				
				If GetPixel(hDC, X, Y) = TransparentColor Or X = PicWidth Then 
					' áùåøä æä éùðí ôé÷ñìéí ù÷åôéí
					If InLine Then 
						InLine = False
						LineRegion = CreateRectRgn(StartLineX, Y, X, Y + 1)
						
						If InFirstRegion Then 
							FullRegion = LineRegion
							InFirstRegion = False
						Else
							Call CombineRgn(FullRegion, FullRegion, LineRegion, 2) ' A sample by Yaniv Drukman: www.dr-vb.co.il
							' îçé÷ú äàåáéé÷è ùðåöø ìéöéøú äàæåø
							DeleteObject(LineRegion)
						End If
					End If
				Else
					' äâòðå ìôé÷áì ìà ù÷åó
					If Not InLine Then 
						InLine = True
						StartLineX = X
					End If
				End If
			Next
		Next
		
		picSkin.ReleaseHdc()
		
		Return FullRegion
	End Function

	Public Function Percent(ByRef Val As Integer, ByRef Percnt As Short) As Integer
		Return Val * (Percnt / 100)
	End Function

	'Public Function GetPercent(Num1 As Long, Num2 As Long) As Integer
	'    GetPercent = 100 \ (Num2 / Num1)
	'End Function
	
	Public Function UnSpace(ByRef exp As String) As String
		Dim i As Short
		For i = 1 To Len6(exp)
			If VB.Left(VB.Right(exp, i), 1) <> Chr6(32) Then 
				If VB.Left(VB.Right(exp, i), 1) <> Chr6(0) Then  Exit For
			End If
		Next
		Return VB.Left(exp, Len6(exp) - (i - 1))
	End Function

	Public Function HexDec(ByRef h As String) As Integer
		Dim i As Short
		Dim cnt As Integer
		h = LCase(h)
		For i = 1 To Len6(h)
			Select Case Mid(h, i, 1)
			Case "1": cnt = cnt + 1 * 16 ^ (Len6(h) - i)
			Case "2": cnt = cnt + 2 * 16 ^ (Len6(h) - i)
			Case "3": cnt = cnt + 3 * 16 ^ (Len6(h) - i)
			Case "4": cnt = cnt + 4 * 16 ^ (Len6(h) - i)
			Case "5": cnt = cnt + 5 * 16 ^ (Len6(h) - i)
			Case "6": cnt = cnt + 6 * 16 ^ (Len6(h) - i)
			Case "7": cnt = cnt + 7 * 16 ^ (Len6(h) - i)
			Case "8": cnt = cnt + 8 * 16 ^ (Len6(h) - i)
			Case "9": cnt = cnt + 9 * 16 ^ (Len6(h) - i)
			Case "a": cnt = cnt + 10 * 16 ^ (Len6(h) - i)
			Case "b": cnt = cnt + 11 * 16 ^ (Len6(h) - i)
			Case "c": cnt = cnt + 12 * 16 ^ (Len6(h) - i)
			Case "d": cnt = cnt + 13 * 16 ^ (Len6(h) - i)
			Case "e": cnt = cnt + 14 * 16 ^ (Len6(h) - i)
			Case "f": cnt = cnt + 15 * 16 ^ (Len6(h) - i)
			End Select
			'If Mid(h, i, 1) = "1" Then cnt = cnt + 1 * 16 ^ (Len(h) - i - 0))
			'If Mid(h, i, 1) = "2" Then cnt = cnt + 2 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "3" Then cnt = cnt + 3 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "4" Then cnt = cnt + 4 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "5" Then cnt = cnt + 5 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "6" Then cnt = cnt + 6 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "7" Then cnt = cnt + 7 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "8" Then cnt = cnt + 8 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "9" Then cnt = cnt + 9 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "a" Then cnt = cnt + 10 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "b" Then cnt = cnt + 11 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "c" Then cnt = cnt + 12 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "d" Then cnt = cnt + 13 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "e" Then cnt = cnt + 14 * 16 ^ (Len(h) - (i - 0))
			'If Mid(h, i, 1) = "f" Then cnt = cnt + 15 * 16 ^ (Len(h) - (i - 0))
		Next
		Return cnt
	End Function

End Module
