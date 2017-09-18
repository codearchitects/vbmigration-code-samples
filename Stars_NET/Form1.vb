' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	' UPGRADE_INFO (#0531): You can replace calls to the 'BitBlt' unamanged method with the following .NET member(s): System.Drawing.Graphics.DrawImage
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
	Private A As Short
	Private B As Short
	' UPGRADE_INFO (#0501): The 'C' member isn't used anywhere in current application.
	Private C As Short
	' UPGRADE_INFO (#0501): The 'D' member isn't used anywhere in current application.
	Private D As Short
	' UPGRADE_INFO (#0501): The 'E' member isn't used anywhere in current application.
	Private E As Short
	' UPGRADE_INFO (#0501): The 'F' member isn't used anywhere in current application.
	Private F As Short
	Private FF As Short
	Private Cntr As Single
	Private UserX As Double
	' UPGRADE_INFO (#0501): The 'UserY' member isn't used anywhere in current application.
	Private UserY As Double
	Private Colr As Single
	Private DotSize As Single
	Private DotSizeFactor As Single
	Private SunNum As Single
	Private Temp As String = ""
	Private StarData(10000, 24) As String
	Private Coords(10000, 1) As Double
	Private Mag(10000) As Double
	Private TempStore(3000, 3000) As Single
	Private TempStore2(10000, 1) As Single
	Private UCoords(10000, 1) As Double
	Private Const Deg As Double = 0.01745329251994
	Private MidX As Double
	Private MidY As Double
	Private HorizY As Double
	Private Alt As Double
	Private Az As Double
	Private Lat As Double
	Private Lon As Double
	Private TimeHr As Short
	Private HrType As Short
	Private TimeMin As Short
	Private TimeSec As Short
	Private TimeDec As Double
	Private UT As Double
	Private JDay As Double
	Private TimeZone As Double
	Private Yr As Single
	Private MoY As Short
	Private DoM As Double
	Private LST As Double
	Private HA As Double
	Private RA As Double
	Private Dec As Double
	Private DirNames As Object
	Private DrawingArc As Boolean
	Private DrawingMarks As Boolean
	Private ArcStep As Single
	Private ArcDashes As Boolean
	Private ArcColr As Single
	Private MarkLength As Single
	Private ShowExtraInfo As Boolean
	Private Playing As Short
	Private Changing As Boolean
	Private DaysPerMonth(12) As Short
	Private MinSkip As Short
	Private FormLoading As Boolean
	Private StarInfo As Boolean
	
	Private Sub Combo1_Click() Handles Combo1.Click
		
		RefreshScreen()
		
	End Sub

	Private Sub RefreshScreen()
		Dim Tmp As Double
		Dim DecR As Double
		Dim LatR As Double
		Dim HAR As Double
		Dim AltR As Double
		Dim TmpX As Double
		Dim TmpY As Double
		
		If FormLoading Then  Exit Sub
		
		'Get values from text boxes
		Lat = Val(Text2(0).Text)
		Lon = Val(Text2(1).Text)
		TimeZone = Combo1.ListIndex - 12
		Yr = Int(Val(Text4(2).Text))
		MoY = Int(Val(Text4(0).Text))
		DoM = Int(Val(Text4(1).Text))
		TimeHr = Int(Val(Text3(0).Text))
		TimeMin = Int(Val(Text3(1).Text))
		TimeSec = Int(Val(Text3(2).Text))
		'convert 12 hour time (1 - 12 am/pm) to 24 hour (0 - 23)
		If Option1(0).Value = True And TimeHr = 12 Then  TimeHr = 0 'change 12 am to 0
		If Option1(1).Value = True And TimeHr < 12 Then  TimeHr += 12 'for 1-11 pm
		
		'Make all values within valid range
		If TimeSec > 59 Or TimeSec < 0 Then  TimeSec = 0
		If TimeMin > 59 Or TimeMin < 0 Then  TimeMin = 0
		If TimeHr > 23 Or TimeHr < 0 Then  TimeHr = 0
		If MoY > 12 Or MoY < 1 Then  MoY = 1
		If DoM > DaysPerMonth(MoY) Or DoM < 1 Then  DoM = 1
		
		'Format numbers
		Text3(2).Text = IIf(TimeSec < 10, "0" & Trim(Str6(TimeSec)), Trim(Str6(TimeSec)))
		Text3(1).Text = IIf(TimeMin < 10, "0" & Trim(Str6(TimeMin)), Trim(Str6(TimeMin)))
		If Option1(2).Value = False Then 
			Text3(0).Text = Trim(Str6(IIf(TimeHr Mod 12 = 0, 12, TimeHr Mod 12)))
		Else
			Text3(0).Text = Trim(Str6(TimeHr))
		End If
		Text4(0).Text = MoY
		Text4(1).Text = DoM
		Text4(2).Text = Yr
		
		TimeDec = TimeHr + TimeMin / 60 + TimeSec / 3600 'Convert time to decimal
		UT = TimeDec - TimeZone 'Universal Time
		TimeDec = UT - 12 'Julian day starts at noon
		
		'Julian day formula
		JDay = (1461 * (Yr + 4800 + (MoY - 14) \ 12)) \ 4 + (367 * (MoY - 2 - 12 * ((MoY - 14) \ 12))) \ 12 - (3 * ((Yr + 4900 + (MoY - 14) \ 12) \ 100)) \ 4 + DoM - 32075
		
		JDay = JDay + TimeDec / 24 'Add partial day
		JDay -= 2451545 'Convert to days from 1/1/2000
		LST = 100.46 + 0.985647 * JDay + Lon + 15 * UT 'Local Sidereal Time
		
		'Get LST within the 0-360 range
		Do
			If LST < 0 Then  LST += 360
			If LST >= 360 Then  LST -= 360
		Loop Until LST >= 0 And LST < 360
		
		'Refresh Sun coordinates
		AddSun()
		
		For A = 0 To Cntr
			RA = Coords(A, 0)
			Dec = Coords(A, 1)
			HA = LST - RA 'Hour Angle
			If HA < 0 Then  HA += 360
			'Convert variables to radians
			DecR = Dec * Deg
			LatR = Lat * Deg
			HAR = HA * Deg
			'Altitude
			Tmp = Math.Sin(DecR) * Math.Sin(LatR) + Math.Cos(DecR) * Math.Cos(LatR) * Math.Cos(HAR)
			AltR = Math.Atan(Tmp / Math.Sqrt(-Tmp * Tmp + 1))
			Alt = AltR / Deg
			'Azimuth
			Tmp = (Math.Sin(DecR) - Math.Sin(AltR) * Math.Sin(LatR)) / (Math.Cos(AltR) * Math.Cos(LatR))
			'Error check
			If Abs6(Tmp) > 1 Then 
				TmpY = -Math.Cos(DecR) * Math.Cos(LatR) * Math.Sin(HAR)
				TmpX = Math.Sin(DecR) - Math.Sin(LatR) * Math.Sin(AltR)
				Tmp = Math.Atan(TmpY / TmpX) / Deg
			Else
				Tmp = (Math.Atan(-Tmp / Math.Sqrt(-Tmp * Tmp + 1)) + 2 * Math.Atan(1)) / Deg
			End If
			
			If Math.Sin(HAR) < 0 Then 
				Az = 360 - Tmp
			Else
				Az = Tmp
			End If
			'Write Alt and Az to UCoords
			UCoords(A, 0) = Az
			UCoords(A, 1) = Alt
		Next
		
		DrawStars()
		
	End Sub

	'Refresh Button
	Private Sub Command1_Click() Handles Command1.Click
		
		If Playing = 0 Then  RefreshScreen()
		
	End Sub

	Private Sub Command2_Click() Handles Command2.Click
		
		RightNow()
		RefreshScreen()
		
	End Sub

	Private Sub Command3_Click(ByRef Index As Short)
		
		Changing = True
		
		'Get current values from text boxes
		TimeSec = Val(Text3(2).Text)
		TimeMin = Val(Text3(1).Text)
		TimeHr = Val(Text3(0).Text)
		If Option1(2).Value = False Then 
			If TimeHr = 12 Then  TimeHr = 0
			If Option1(1).Value = True Then  TimeHr += 12
		End If
		MoY = Text4(0).Text
		DoM = Text4(1).Text
		Yr = Text4(2).Text
		
		If Combo2.ListIndex = 0 Then  TimeSec = TimeSec + (2 * Index - 1) 'seconds
		If Combo2.ListIndex = 1 Then  TimeMin = TimeMin + (2 * Index - 1) 'minutes
		If Combo2.ListIndex = 2 Then  TimeHr = TimeHr + (2 * Index - 1) 'hours
		If Combo2.ListIndex = 3 Then  DoM = DoM + (2 * Index - 1) 'days
		If Combo2.ListIndex = 4 Then  'months
			MoY = MoY + (2 * Index - 1)
			If MoY > 12 Then 
				MoY = 1
				Yr += 1
			End If
			If MoY < 1 Then 
				MoY = 12
				Yr -= 1
			End If
		End If
		If Combo2.ListIndex = 5 Then  Yr = Yr + (2 * Index - 1) 'years
		
		If TimeSec < 0 Then 
			TimeSec = 59
			TimeMin -= 1
		End If
		If TimeSec > 59 Then 
			TimeSec = 0
			TimeMin += 1
		End If
		If TimeMin < 0 Then 
			TimeMin = 59
			TimeHr -= 1
		End If
		If TimeMin > 59 Then 
			TimeMin = 0
			TimeHr += 1
		End If
		If TimeHr < 0 Then 
			TimeHr = 23
			DoM -= 1
		End If
		If TimeHr > 23 Then 
			TimeHr = 0
			DoM += 1
		End If
		If DoM < 1 Then 
			MoY -= 1
			If MoY < 1 Then 
				MoY = 12
				DoM = 31
				Yr -= 1
			Else
				DoM = DaysPerMonth(MoY)
			End If
		End If
		If DoM > DaysPerMonth(MoY) Then 
			MoY += 1
			If MoY > 12 Then 
				MoY = 1
				DoM = 1
				Yr += 1
			Else
				DoM = 1
			End If
		End If
		If MoY < 1 Then 
			MoY = 12
			Yr -= 1
		End If
		If MoY > 12 Then 
			MoY = 1
			Yr += 1
		End If
		
		'Format numbers
		Text3(2).Text = IIf(TimeSec < 10, "0" & Trim(Str6(TimeSec)), Trim(Str6(TimeSec)))
		Text3(1).Text = IIf(TimeMin < 10, "0" & Trim(Str6(TimeMin)), Trim(Str6(TimeMin)))
		If Option1(2).Value = False Then 
			If TimeHr < 12 Then 
				Option1(0).Value = True
			Else
				Option1(1).Value = True
			End If
			Text3(0).Text = Trim(Str6(IIf(TimeHr Mod 12 = 0, 12, TimeHr Mod 12)))
		Else
			Text3(0).Text = Trim(Str6(TimeHr))
		End If
		Text4(0).Text = MoY
		Text4(1).Text = DoM
		Text4(2).Text = Yr
		
		Changing = False
		RefreshScreen()
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Dim V As Object = Nothing
		Dim LastStar As String = ""
		
		FormLoading = True
		
		'Add time zones
		For A = -12 To 13
			If A < 0 Then 
				Combo1.AddItem(A)
			Else
				Combo1.AddItem("+" & A)
			End If
		Next
		
		'Add increment types
		Combo2.AddItem("Sec.")
		Combo2.AddItem("Min.")
		Combo2.AddItem("Hr.")
		Combo2.AddItem("Day")
		Combo2.AddItem("Mo.")
		Combo2.AddItem("Yr.")
		
		'Lat and Long for Gilbert, AZ
		Text2(0).Text = "33.3702" 'Latitude
		Text2(1).Text = "-111.7919" 'Longitude
		TimeZone = -7 'Time Zone
		Combo1.ListIndex = TimeZone + 12
		Combo2.ListIndex = 1
		
		RightNow()
		
		Cntr = -1
		MidX = Picture1.ScaleWidth / 2
		MidY = Picture1.ScaleHeight / 2
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'DirNames'. Consider using the SetDefaultMember6 helper method.
		DirNames = Split("N,NNE,NE,ENE,E,ESE,SE,SSE,S,SSW,SW,WSW,W,WNW,NW,NNW,N", ",")
		ArcStep = 6
		ArcDashes = True
		ShowExtraInfo = True
		DaysPerMonth(1) = 31
		DaysPerMonth(2) = 28
		DaysPerMonth(3) = 31
		DaysPerMonth(4) = 30
		DaysPerMonth(5) = 31
		DaysPerMonth(6) = 30
		DaysPerMonth(7) = 31
		DaysPerMonth(8) = 31
		DaysPerMonth(9) = 30
		DaysPerMonth(10) = 31
		DaysPerMonth(11) = 30
		DaysPerMonth(12) = 31
		MinSkip = 1
		StarInfo = True
		
		'Get data from stardata.txt
		FF = FreeFile6()
		FileOpen6(FF, App6.Path & "\stardata.txt", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		Do While Not EOF6(FF)
			Temp = FileLineInput6(FF)
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'V'. Consider using the SetDefaultMember6 helper method.
			V = Split(Temp, ControlChars.Tab)
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'V(3)'. Consider using the GetDefaultMember6 helper method.
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'V(0)'. Consider using the GetDefaultMember6 helper method.
			If V(3) <> "" And Val(V(3)) <= 6.5 And V(0) <> LastStar Then  'If magnitude is less than 6.5 (visible to naked eye) and star is not a duplicate of the last star
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'V(0)'. Consider using the GetDefaultMember6 helper method.
				LastStar = V(0) 'Store info to compare with next star and check for duplicate
				'Add data to StarData
				Cntr += 1
				For A = 0 To 24
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'V(A)'. Consider using the GetDefaultMember6 helper method.
					StarData(Cntr, A) = V(A)
				Next
				If StarData(Cntr, 16) = "" Then  StarData(Cntr, 16) = StarData(Cntr, 2)
				StarData(Cntr, 16) = FixCase(StarData(Cntr, 16)) 'Format letters to proper case
				Coords(Cntr, 0) = ConvToDec(StarData(Cntr, 6)) 'Convert Right Ascension to decimal
				Coords(Cntr, 1) = ConvToDec(StarData(Cntr, 7)) 'Convert Declination to decimal
				Mag(Cntr) = Val(StarData(Cntr, 3))
			End If
		Loop
		FileClose6(FF)
		
		'The Sun
		Cntr += 1
		SunNum = Cntr
		StarData(Cntr, 16) = "Sun"
		StarData(Cntr, 3) = "-27.97"
		Mag(Cntr) = Val(StarData(Cntr, 3))

		Temp = Cntr & " stars.  "
		'For A = 0 To Cntr
		'Temp = Temp & StarData(A, 16) & ": " & StarData(A, 3) & vbCrLf
		'Temp = Temp & "  " & Coords(A, 0) & ", " & Coords(A, 1) & vbCrLf
		'Next A
		
		FormLoading = False
		
		RefreshScreen()
		
	End Sub

	Private Function ConvToDec(ByRef Inp As String) As Double
	' UPGRADE_INFO (#0551): The 'Inp' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim Z As Double
		Dim I As Short
		Dim J As Short
		Dim K As Short
		Dim y As String = ""
		Dim Neg As Boolean
		Dim Symb As String = ""
		
		y = VB.Left(Inp, 1)
		If y = "+" Or y = "-" Then 
			Symb = Chr6(186)
			If y = "-" Then  Neg = True
		Else
			Symb = "h"
		End If
		
		I = InStr(1, Inp, Symb)
		If I > 0 Then 
			Z = Z + Abs6(Val(VB.Left(Inp, I - 1))) 'Add degrees/hours
		Else
			I = 1
		End If
		J = InStr(I, Inp, "'")
		If J > 0 Then 
			Z = Z + Val(Mid(Inp, I + 1, J - I - 1)) / 60 'Add arcminutes
		Else
			J = 1
		End If
		K = InStr(J, Inp, "''")
		If K > 0 Then 
			Z = Z + Val(Mid(Inp, J + 1, K - J - 1)) / 3600 'Add arcseconds
		End If
		If Neg Then  Z = -Z
		If Symb = "h" Then  Z *= 15 '1 hr = 15 degrees
		
		Return Z

	End Function

	Private Function FixCase(ByRef Inp As String) As String
	' UPGRADE_INFO (#0551): The 'Inp' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim y As String = ""
		Dim Z As Short
		
		y = UCase(VB.Left(Inp, 1))
		
		If Len6(Inp) > 1 Then 
			For Z = 2 To Len6(Inp)
				If Mid(Inp, Z - 1, 1) = " " Then 
					' UPGRADE_INFO (#0571): String concatenation inside a loop. Consider declaring the 'y' variable as a StringBuilder6 object.
					y &= UCase(Mid(Inp, Z, 1))
				Else
					y &= LCase(Mid(Inp, Z, 1))
				End If
			Next
		End If
		
		Return y
		
	End Function

	Private Sub PlotStar(ByRef W As Double, ByRef L As Double)
	' UPGRADE_INFO (#0551): The 'W' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'L' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim Cx As Double
		Dim Cy As Double
		Dim Cz As Double
		Dim WR As Double
		Dim LR As Double
		Dim x As Double
		Dim y As Double
		' UPGRADE_INFO (#0501): The 'YArc' member isn't used anywhere in current application.
		Dim YArc As Double
		Dim PixelX As Double
		Dim PixelY As Double
		' UPGRADE_INFO (#0501): The 'ArcSkip' member isn't used anywhere in current application.
		Dim ArcSkip As Single
		Dim CompassDir As Double
		Dim CDir As String = ""
		
		'Convert degrees to radians
		WR = W * Deg
		LR = L * Deg
		
		'Cartesian coordinates
		Cx = Math.Cos(LR) * Math.Sin(WR)
		Cy = Math.Sin(LR)
		Cz = Math.Cos(LR) * Math.Cos(WR)
		
		If Cz = -1 Then  Exit Sub
		
		'2D coordinates
		x = -(Cx / (1 + Cz))
		y = -(Cy / (1 + Cz))
		
		If DrawingArc Then  '*** Drawing an arc ***
			If W <> 180 Then 
				If ArcDashes Then  'If drawing dashed line arc
					Picture1.DrawStyle = 2
					If L = 0 Then  'If at horizon
						Picture1.PSet(VBRUN.GraphicsOptions.None, MidX * (x + 1), HorizY * (y + 1), ArcColr) 'Start arc with a dot
						 Else 'If above horizon
						Picture1.Line(VBRUN.GraphicsOptions.None, MidX * (x + 1), HorizY * (y + 1), ArcColr) 'Continue drawing line from last point
					End If
					Picture1.DrawStyle = 0
					 Else 'If drawing solid line arc
					If L = 0 Then  'If at horizon
						Picture1.PSet(VBRUN.GraphicsOptions.None, MidX * (x + 1), HorizY * (y + 1), ArcColr) 'Start arc with a dot
						 Else 'If above horizon
						Picture1.Line(VBRUN.GraphicsOptions.None, MidX * (x + 1), HorizY * (y + 1), ArcColr) 'Continue drawing line from last point
					End If
				End If
			End If
		Else
			If DrawingMarks Then  '*** Drawing compass marks ***
				Picture1.Line(VBRUN.GraphicsOptions.None, MidX * (x + 1), HorizY, MidX * (x + 1), HorizY + MarkLength, VBRUN.ColorConstants.vbYellow)
				CompassDir = W - UserX
				'MsgBox CompassDir
				If CompassDir < 0 Then  CompassDir = 360 + CompassDir
				If CompassDir > 359 Then  CompassDir -= 360
				' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DirNames(16 - CShort(CompassDir / 22.5))'. Consider using the GetDefaultMember6 helper method.
				CDir = DirNames(16 - CShort(CompassDir / 22.5))
				Picture1.FontSize = 8
				Picture1.ForeColor = FromOleColor6(&HC0C0%)
				
				Picture1.CurrentX = MidX * (x + 1) - (Picture1.TextWidth(CDir) \ 2)
				Picture1.CurrentY = Int(HorizY) + 6
				Picture1.PrintLine(CDir)

				 Else '*** Drawing a star ***
				Picture1.FillColor = FromOleColor6(Colr)
				Picture1.FillStyle = 0
				PixelX = MidX * (x + 1)
				PixelY = HorizY * (y + 1)
				If PixelX >= 0 And PixelX <= Picture1.ScaleWidth And PixelY >= 0 And PixelY <= Picture1.ScaleHeight Then 
					TempStore(CShort(PixelX), CShort(PixelY)) = A
					TempStore2(A, 0) = CShort(PixelX)
					TempStore2(A, 1) = CShort(PixelY)
				End If
				
				Picture1.Circle(VBRUN.GraphicsOptions.None, PixelX, PixelY, DotSize, Colr)
			End If
		End If
		
	End Sub

	Private Sub DrawStars()
		Dim UX As Double
		Dim UY As Double
		Dim DirDeg As String = ""
		Dim Compass As String = ""
		Dim T1 As Double
		Dim T2 As Double
		Dim U1 As Double
		Dim U2 As Double
		Picture1.Cls()
		
		'Copy grass from SwapScreen to Picture1
		' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
		BitBlt(Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen2.hDC, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
		Picture1.ReleaseHDc(): SwapScreen2.ReleaseHDc()
		
		For A = 0 To Cntr
			TempStore(TempStore2(A, 0), TempStore2(A, 1)) = 0
		Next
		
		For A = 1 To Cntr
			Colr = MagColr(Mag(A))
			'highlight Orion
			'If StarData(A, 16) = "Rigel" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Betelgeuse" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Bellatrix" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Saiph" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Alnitak" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Alnilam" Then Colr = &HFFFF00
			'If StarData(A, 16) = "Mintaka" Then Colr = &HFFFF00
			'highlight the North Star
			'If StarData(A, 16) = "Polaris" Then Colr = vbYellow
			
			UX = UCoords(A, 0) + UserX
			UY = UCoords(A, 1)
			
			If UY >= 0 Then 
				If A = SunNum Then 
					Colr = VBRUN.ColorConstants.vbYellow
					DotSize = 8
				End If
				PlotStar(UX, UY)
			End If
		Next

		Picture1.ForeColor = FromOleColor6(&H404040)
		Picture1.FontSize = 14
		
		DirDeg = Str6(UserX) & "°"
		Picture1.CurrentX = MidX - (Picture1.TextWidth(DirDeg) \ 2)
		Picture1.CurrentY = Picture1.Height - 50
		Picture1.PrintLine(DirDeg)
		
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DirNames(CShort(UserX / 22.5))'. Consider using the GetDefaultMember6 helper method.
		Compass = DirNames(CShort(UserX / 22.5))
		Picture1.CurrentX = MidX - (Picture1.TextWidth(Compass) \ 2)
		Picture1.CurrentY = Picture1.Height - 75
		Picture1.PrintLine(Compass)
		
		Picture1.Line(VBRUN.GraphicsOptions.None, MidX, HorizY, MidX, HorizY + 5, VBRUN.ColorConstants.vbGreen)
		Picture1.Line(VBRUN.GraphicsOptions.None, MidX, HorizY + 20, MidX, HorizY + 25, VBRUN.ColorConstants.vbGreen)

		'Draw arcs across sky from N to S and from E to W
		DrawingArc = True
		
		'N, S, E and W
		ArcColr = &H331133 '&H404000
		For UX = 0 To 270 Step 90
			For UY = 0 To 90 Step ArcStep
				PlotStar(UserX + UX, UY)
			Next
		Next
		
		'In between directions
		ArcColr = &H1A1A1A
		For UX = 22.5 To 360 Step 22.5
			If CInt(UX) Mod 90 <> 0 Then 
				For UY = 0 To 90 Step ArcStep
					PlotStar(UserX + UX, UY)
				Next
			End If
		Next
		
		DrawingArc = False
		
		DrawingMarks = True
		
		'T1 = ((UserX - 90) \ 22.5) * 22.5
		'T2 = Int((UserX + 90) / 22.5 + 1) * 22.5
		
		T1 = UserX - 180
		T2 = UserX + 180
		U1 = Int(T1 / 22.5) * 22.5
		U2 = (Int(T2 / 22.5) + 1) * 22.5
		
		For UX = U1 To U2 Step 22.5
			If UX >= T1 And UX <= T2 Then 
				MarkLength = 5				PlotStar(UserX + UX, 0)
			End If
		Next
		
		DrawingMarks = False
		
		Picture1.Refresh()
		
		'Copy entire Picture1 to SwapScreen
		' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
		BitBlt(SwapScreen.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, Picture1.hDC, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
		Picture1.ReleaseHDc(): SwapScreen.ReleaseHDc()
		
	End Sub

	Private Function MagColr(ByRef M As Double) As Integer
		Dim Shade As Double
		
		If M < -1 Then  M = -1
		If M > 6.5 Then  M = 6.5
		Shade = 255 - Int((M + 1) * 33)
		MagColr = Shade + 256 * Shade + 65536 * Shade
		DotSize = (7 - M) * DotSizeFactor 'Range = 0.5 to 8 * DotSizeFactor
		
	End Function

	Private Sub Form_Resize() Handles MyBase.Resize
		Dim GreenVal As Single
		Dim GreenLow As Single
		Dim GreenHigh As Single
		Dim NumFadeRows As Short
		Dim FadeStep As Single
		Dim GrassColr As Single
		
		If Me.WindowState = 1 Then  Exit Sub
		
		Picture1.Width = Me.ScaleWidth
		Picture1.Height = Me.ScaleHeight - 56
		SwapScreen.Width = Picture1.Width
		SwapScreen.Height = Picture1.Height
		SwapScreen2.Width = Picture1.Width
		SwapScreen2.Height = Picture1.Height
		MidX = Picture1.ScaleWidth / 2
		MidY = Picture1.ScaleHeight / 2
		HorizY = Picture1.Height * 0.8
		
		'Draw Grass on SwapScreen2
		SwapScreen2.Cls()
		NumFadeRows = 50
		GreenLow = 20
		GreenHigh = 80 '255
		FadeStep = (GreenHigh - GreenLow) / (NumFadeRows + 1)
		B = Int(HorizY)
		
		'Gradient
		For A = B To B + NumFadeRows
			GreenVal = Int((A - B) * FadeStep + GreenLow)
			GrassColr = 65536 * GreenVal + GreenVal \ 3 ' 256 * GreenVal '2228258
			SwapScreen2.Line(VBRUN.GraphicsOptions.None, 0, A, Picture1.ScaleWidth, A, GrassColr) '&H226622
		Next
		'End of gradient to bottom of window
		SwapScreen2.Line(VBRUN.GraphicsOptions.BoxFilled, 0, B + NumFadeRows + 1, SwapScreen2.Width, SwapScreen2.Height, GrassColr)
		SwapScreen2.Refresh()
		
		DotSizeFactor = Math.Sqrt(Picture1.ScaleWidth * Picture1.Height / 200000) / 8 'Max dot size / 8
		DrawStars()
		
	End Sub

	Private Sub HScroll1_Change() Handles HScroll1.Change
		
		Label12.Caption = HScroll1.Value
		MinSkip = HScroll1.Value
		
	End Sub

	Private Sub Label10_Click() Handles Label10.Click
		
		'Label10.Caption = DotSizeFactor * 8
		
		MsgBox6(UCoords(Cntr, 0) & "  " & UCoords(Cntr, 1))
		
	End Sub

	Private Sub Label8_Click() Handles Label8.Click
		
		MsgBox6(Coords(SunNum, 0) & ", " & Coords(SunNum, 1))
		
	End Sub

	Private Sub Option1_Click(ByRef Index As Short)
		
		'If "AM" or "PM" is selected and "24" was previously selected convert to 12hr time
		If Index < 2 And HrType = 2 Then 
			TimeHr = Int(Val(Text3(0).Text))
			TimeHr = TimeHr Mod 12
			If TimeHr = 0 Then  TimeHr = 12
			Text3(0).Text = Trim(Str6(TimeHr))
		End If
		
		'If "24" is selected convert 12hr time to 24hr time
		If Index = 2 Then 
			TimeHr = Int(Val(Text3(0).Text))
			If HrType < 2 Then  'Convert time based on previously selected hr button
				If TimeHr = 12 Then  TimeHr = 0
				If HrType = 1 Then  TimeHr += 12
				Text3(0).Text = Trim(Str6(TimeHr))
			End If
		End If
		
		HrType = Index
		
		If Playing = 0 And Changing = False Then  RefreshScreen()
		
	End Sub

	Private Sub Option2_Click(ByRef Index As Short)
		
		If Option2(0).Value = True Then  Playing = 1 'play forward
		If Option2(1).Value = True Then  Playing = 0 'stop
		If Option2(2).Value = True Then  Playing = -1 'play reverse
		
	End Sub

	Private Sub Picture1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles Picture1.KeyDown
		Dim Inc As Double = 1
		
		If Shift = 4 Then  Inc = 5
		If Shift = 2 Then  Inc = 0.25
		
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyRight Then 
			UserX -= Inc
			If UserX < 0 Then  UserX = 360 + UserX
			DrawStars()
		End If
		If KeyCode = VBRUN.KeyCodeConstants.vbKeyLeft Then 
			UserX += Inc
			If UserX >= 360 Then  UserX -= 360
			DrawStars()
		End If
		
	End Sub

	Private Sub RightNow()
		
		Text4(0).Text = Month(Today)
		Text4(1).Text = VB.Day(Today)
		Text4(2).Text = Year(Today)
		
		Text3(0).Text = Hour(TimeOfDay)
		Text3(1).Text = Minute(TimeOfDay)
		Text3(2).Text = Second(TimeOfDay)
		
		Temp = UCase(VB.Right(TimeOfDay, 2))
		If Temp = "AM" Then  Option1(0).Value = True
		If Temp = "PM" Then  Option1(1).Value = True
		If Temp <> "AM" And Temp <> "PM" Then  Option1(2).Value = True
		
	End Sub

	Private Sub Picture1_KeyPress(ByRef KeyAscii As Short) Handles Picture1.KeyPress
		
		'Display Extra Info Toggle
		If KeyAscii = 105 Or KeyAscii = 73 Then 
			If ShowExtraInfo = True Then 
				ShowExtraInfo = False
			Else
				ShowExtraInfo = True
			End If
		End If
		
	End Sub

	Private Sub Picture1_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles Picture1.MouseDown
		
		If Button = 1 Then 
			If StarInfo Then 
				StarInfo = False
				'Copy entire SwapScreen to Picture1
				' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
				BitBlt(Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen.hDC, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
				Picture1.ReleaseHDc(): SwapScreen.ReleaseHDc()
				Picture1.Refresh()
			Else
				StarInfo = True
			End If
		End If
		
	End Sub

	Private Sub Picture1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles Picture1.MouseMove
		Dim XScan As Double
		Dim YScan As Double
		Dim OverStar As Double
		Dim ClosestStar(3) As Double '0 = Star #, 1 = Distance, 2 = X Coord., 3 = Y Coord.
		Dim TempDist As Double
		Dim StarName As String = ""
		
		Label9.Caption = "X = " & x & "   Y = " & y
		ClosestStar(1) = 100
		
		If StarInfo Then 
			For XScan = x - 8 To x + 8
				For YScan = y - 8 To y + 8
					If XScan >= 0 And YScan >= 0 Then 
						If TempStore(XScan, YScan) > 0 Then 
							OverStar = TempStore(XScan, YScan)
							TempDist = Math.Sqrt((XScan - x) ^ 2 + (YScan - y) ^ 2)
							If TempDist < ClosestStar(1) Then 
								ClosestStar(0) = OverStar
								ClosestStar(1) = TempDist
								ClosestStar(2) = XScan
								ClosestStar(3) = YScan
							End If
						End If
					End If
				Next
			Next
			
			'Copy entire SwapScreen to Picture1
			' UPGRADE_ISSUE (#1478): The hDC property requires that the ReleaseHdc method be invoked when the hDC handle isn't used any longer.
			BitBlt(Picture1.hDC, 0, 0, Picture1.ScaleWidth, Picture1.ScaleHeight, SwapScreen.hDC, 0, 0, VBRUN.RasterOpConstants.vbSrcCopy)
			Picture1.ReleaseHDc(): SwapScreen.ReleaseHDc()
			
			If ClosestStar(0) > 0 Then 
				Picture1.CurrentX = ClosestStar(2) + 20
				Picture1.CurrentY = ClosestStar(3) - 20
				Picture1.FontSize = 8
				Picture1.ForeColor = Color.Cyan 
				Picture1.FontBold = False
				'Display Star Name
				StarName = Trim(StarData(ClosestStar(0), 16))
				If StarName = "" Then  StarName = "Star #" & ClosestStar(0) & " (No Name Supplied)"
				Picture1.PrintLine(StarName)
				If ShowExtraInfo Then 
					'Display Magnitude
					Picture1.ForeColor = FromOleColor6(&HDDDD00)
					Picture1.CurrentX = ClosestStar(2) + 20
					Picture1.CurrentY = ClosestStar(3) - 10
					Picture1.PrintLine("Magnitude: " & StarData(ClosestStar(0), 3))
					'Display Distance
					Picture1.ForeColor = FromOleColor6(&HBBBB00)
					Picture1.CurrentX = ClosestStar(2) + 20
					Picture1.CurrentY = ClosestStar(3)
					Picture1.PrintLine("Distance: " & StarData(ClosestStar(0), 8) & " LY")
					'Azimuth
					Picture1.ForeColor = FromOleColor6(&HAAAA00)
					Picture1.CurrentX = ClosestStar(2) + 20
					Picture1.CurrentY = ClosestStar(3) + 10
					Picture1.PrintLine("Azimuth: " & FormatNumber(360 - (UCoords(ClosestStar(0), 0)), 4) & "°")
					'Altitude
					Picture1.ForeColor = FromOleColor6(&H999900)
					Picture1.CurrentX = ClosestStar(2) + 20
					Picture1.CurrentY = ClosestStar(3) + 20
					Picture1.PrintLine("Altitude: " & FormatNumber((UCoords(ClosestStar(0), 1)), 4) & "°")
				End If
				Picture1.FillStyle = 1
				Picture1.Line(VBRUN.GraphicsOptions.None, ClosestStar(2) + 2, ClosestStar(3) - 2, ClosestStar(2) + 18, ClosestStar(3) - 15, &H555555)
				Picture1.DrawStyle = 2
				Picture1.Circle(VBRUN.GraphicsOptions.None, ClosestStar(2), ClosestStar(3), 4, VBRUN.ColorConstants.vbRed)
				Picture1.DrawStyle = 0
			End If
		End If
		
	End Sub

	Private Sub Text2_KeyPress(ByRef Index As Short, ByRef KeyAscii As Short)
		
		If KeyAscii = VBRUN.KeyCodeConstants.vbKeyReturn Then 
			KeyAscii = 0
			RefreshScreen()
		End If
		
	End Sub

	Private Sub Text3_KeyPress(ByRef Index As Short, ByRef KeyAscii As Short)
		
		If KeyAscii = VBRUN.KeyCodeConstants.vbKeyReturn Then 
			KeyAscii = 0
			RefreshScreen()
		End If
		
	End Sub

	Private Sub Text4_KeyPress(ByRef Index As Short, ByRef KeyAscii As Short)
		
		If KeyAscii = VBRUN.KeyCodeConstants.vbKeyReturn Then 
			KeyAscii = 0
			RefreshScreen()
		End If
		
	End Sub

	Private Sub Timer2_Timer() Handles Timer2.Timer

		If Playing <> 0 Then 
			'Get current values from text boxes
			TimeMin = Val(Text3(1).Text)
			TimeHr = Val(Text3(0).Text)
			TimeMin = TimeMin + (MinSkip * Playing)
			MoY = Text4(0).Text
			DoM = Text4(1).Text
			Yr = Text4(2).Text
			
			'play forward
			If Playing = 1 Then 
				'past 59 min
				If TimeMin > 59 Then 
					TimeMin -= 60
					TimeHr += 1
					If Option1(2).Value = False Then  '12 hour time
						'past 12 hr
						If TimeHr > 12 Then  TimeHr = 1
						'change to 12 am or pm
						If TimeHr = 12 Then 
							'am to pm
							If Option1(0).Value = True Then 
								Option1(1).Value = True
								'pm to am
							Else
								Option1(0).Value = True
								DoM += 1 'go to next day
							End If
						End If
						 Else '24 hour time
						If TimeHr > 23 Then 
							TimeHr = 0
							DoM += 1 'go to next day
						End If
					End If
				End If
				'past last day of month
				If DoM > DaysPerMonth(MoY) Then 
					DoM = 1 'reset to 1st of month
					MoY += 1 'go to next month
					'past end of year
					If MoY > 12 Then 
						MoY = 1 'reset to January
						Yr += 1 'go to next year
					End If
					'update date fields with new values
					Text4(0).Text = MoY
					Text4(1).Text = DoM
					Text4(2).Text = Yr
				End If
				'update time fields with new values
				Text3(1).Text = TimeMin
				Text3(0).Text = TimeHr
				Text4(1).Text = DoM
			End If
			
			'play reverse
			If Playing = -1 Then 
				'under 0 min
				If TimeMin < 0 Then 
					TimeMin += 60
					TimeHr -= 1
					If Option1(2).Value = False Then  '12 hour time
						'under 1 hr
						If TimeHr < 1 Then  TimeHr = 12
						'change to 11 am or pm
						If TimeHr = 11 Then 
							'am to pm
							If Option1(0).Value = True Then 
								Option1(1).Value = True
								DoM -= 1 'go to previous day
								'pm to am
							Else
								Option1(0).Value = True
							End If
						End If
						 Else '24 hour time
						If TimeHr < 0 Then 
							TimeHr = 23
							DoM -= 1 'go to previous day
						End If
					End If
				End If
				'before first day of month
				If DoM < 1 Then 
					MoY -= 1 'go to previous month
					'if it's before beginning of year (Jan. 1)
					If MoY < 1 Then 
						MoY = 12 'go to December
						DoM = 31 'last day of December
						Yr -= 1 'go to previous year
						'go to last day of previous month
					Else
						DoM = DaysPerMonth(MoY) 'last day of previous month
					End If
					'update date fields with new values
					Text4(0).Text = MoY
					Text4(1).Text = DoM
					Text4(2).Text = Yr
				End If
				'update time fields with new values
				Text3(1).Text = TimeMin
				Text3(0).Text = TimeHr
				Text4(1).Text = DoM
			End If
			
			'display sky for new time
			RefreshScreen()
		End If

		Exit Sub
		
		' UPGRADE_INFO (#0521): Unreachable code detected
		RightNow() 'Current time
		RefreshScreen() 'Update display
		Picture1_MouseMove(0, 0, Picture1.CurrentX, Picture1.CurrentY)

	End Sub

	Private Sub AddSun()
		Dim SunNN As Double = 0
		Dim Suni As Double = 0
		Dim Sunw As Double
		Dim Suna As Double = 1
		Dim Sune As Double
		Dim SunMM As Double
		Dim SunEE As Double
		Dim Sunxv As Double
		Dim Sunyv As Double
		Dim Sunv As Double
		Dim Sunr As Double
		Dim LonSun As Double
		Dim Sunxs As Double
		Dim Sunys As Double
		Dim Sunxe As Double
		Dim Sunye As Double
		Dim Sunze As Double
		Dim Sunecl As Double
		Dim SunRA As Double
		Dim SunDec As Double
		Dim Sund As Double
		' UPGRADE_INFO (#0501): The 'syear' member isn't used anywhere in current application.
		Dim syear As Double
		' UPGRADE_INFO (#0501): The 'smonth' member isn't used anywhere in current application.
		Dim smonth As Double
		' UPGRADE_INFO (#0501): The 'sdate' member isn't used anywhere in current application.
		Dim sdate As Double
		
		Sund = JDay
		
		Sunecl = 23.4393 - 0.0000003563 * Sund
		
		'longitude of the ascending node
		'inclination to the ecliptic (plane of the Earth's orbit)
		Sunw = 282.9404 + 0.0000470935 * Sund 'argument of perihelion
		'semi-major axis, or mean distance from Sun
		Sune = 0.016709 - 0.000000001151 * Sund 'eccentricity (0=circle, 0-1=ellipse, 1=parabola)
		SunMM = 356.047 + 0.9856002585 * Sund 'mean anomaly (0 at perihelion; increases uniformly with time)
		
		'get SunMM in the 0-360 range
		Do
			If SunMM < 0 Then  SunMM += 360
			If SunMM >= 360 Then  SunMM -= 360
		Loop Until SunMM >= 0 And SunMM < 360
		
		SunEE = SunMM + Sune * Math.Sin(SunMM * Deg) * (1 + Sune * Math.Cos(SunMM * Deg))
		
		Sunxv = Math.Cos(SunEE * Deg) - Sune
		Sunyv = Math.Sqrt(1 - Sune * Sune) * Math.Sin(SunEE * Deg)
		Sunv = Atan2(Sunyv, Sunxv) / Deg 'Sun's true anomaly
		Sunr = Math.Sqrt(Sunxv * Sunxv + Sunyv * Sunyv) 'Sun's distance
		LonSun = Sunv + Sunw 'Sun's true longitude
		
		Sunxs = Sunr * Math.Cos(LonSun * Deg) 'ecliptic rectangular geocentric coordinates
		Sunys = Sunr * Math.Sin(LonSun * Deg)
		
		Sunxe = Sunxs 'equatorial, rectangular, geocentric coordinates
		Sunye = Sunys * Math.Cos(Sunecl * Deg)
		Sunze = Sunys * Math.Sin(Sunecl * Deg)
		
		SunRA = Atan2(Sunye, Sunxe) / Deg
		SunDec = Atan2(Sunze, Math.Sqrt(Sunxe * Sunxe + Sunye * Sunye)) / Deg
		
		Do
			If SunRA < 0 Then  SunRA += 360
			If SunRA >= 360 Then  SunRA -= 360
		Loop Until SunRA >= 0 And SunRA < 360
		Do
			If SunDec < 0 Then  SunDec += 360
			If SunDec >= 360 Then  SunDec -= 360
		Loop Until SunDec >= 0 And SunDec < 360
		
		Coords(SunNum, 0) = SunRA
		Coords(SunNum, 1) = SunDec
		
	End Sub

	Public Function Atan2(ByVal aay As Double, ByVal aax As Double) As Double
		Dim theta As Double
		
		If (Abs6(aax) < 0.0000001) Then 
			If (Abs6(aay) < 0.0000001) Then 
				theta = 0#
			ElseIf (aay > 0#) Then 
				theta = 1.5707963267949
			Else
				theta = -1.5707963267949
			End If
		Else
			theta = Math.Atan(aay / aax)
			
			If (aax < 0) Then 
				If (aay >= 0#) Then 
					theta = 3.14159265358979 + theta
				Else
					theta -= 3.14159265358979
				End If
			End If
		End If
		
		Return theta
	End Function

End Class
