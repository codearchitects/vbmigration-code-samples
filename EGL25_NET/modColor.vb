' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Structure ColorRGB

	Public R As Short
	Public G As Short
	Public B As Short
End Structure

Friend Module modColor

	Public Function ColorSet(ByVal R As Short, ByVal G As Short, ByVal B As Short) As ColorRGB
		
		ColorSet.R = R
		ColorSet.G = G
		ColorSet.B = B
		
	End Function

	Public Function ColorAdd(ByRef C1 As ColorRGB, ByRef C2 As ColorRGB) As ColorRGB
	' UPGRADE_INFO (#0501): The 'ColorAdd' member isn't used anywhere in current application.
		
		ColorAdd.R = C1.R + C2.R
		ColorAdd.G = C1.G + C2.G
		ColorAdd.B = C1.B + C2.B
		
	End Function

	Public Function ColorSub(ByRef C1 As ColorRGB, ByRef C2 As ColorRGB) As ColorRGB
	' UPGRADE_INFO (#0501): The 'ColorSub' member isn't used anywhere in current application.
		
		ColorSub.R = C1.R - C2.R
		ColorSub.G = C1.G - C2.G
		ColorSub.B = C1.B - C2.B
		
	End Function

	Public Function ColorScale(ByRef c As ColorRGB, ByVal S As Single) As ColorRGB
		
		ColorScale.R = c.R * S
		ColorScale.G = c.G * S
		ColorScale.B = c.B * S
		
	End Function

	Public Function ColorPlus(ByRef c As ColorRGB, ByVal L As Short) As ColorRGB
		
		ColorPlus.R = c.R + L
		ColorPlus.G = c.G + L
		ColorPlus.B = c.B + L
		
	End Function

	Public Function ColorInvert(ByRef c As ColorRGB) As ColorRGB
		
		ColorInvert.R = 255 - c.R
		ColorInvert.G = 255 - c.G
		ColorInvert.B = 255 - c.B
		
	End Function

	Public Function ColorGray(ByVal R As Short, ByVal G As Short, ByVal B As Short) As ColorRGB
		
		Dim Temp As Short = (R + G + B) / 3
		
		ColorGray.R = Temp
		ColorGray.G = Temp
		ColorGray.B = Temp
		
	End Function

	Public Function ColorRandom() As ColorRGB
		
		Randomize()
		ColorRandom.R = Rnd() * 255
		ColorRandom.G = Rnd() * 255
		ColorRandom.B = Rnd() * 255
		
	End Function

	'------------------------------------------------
	'Function:ColorLongToRGB
	'Long tipindeki renk bilgisini RGB tipine çeviriyor
	'Geriye bu renk deðerini(RGB) döndürüyor.
	'------------------------------------------------
	
	Public Function ColorLongToRGB(ByVal lC As Integer) As ColorRGB
		
		ColorLongToRGB.R = (lC And &HFF%)
		ColorLongToRGB.G = (lC And &HFF00%) / &H100%
		ColorLongToRGB.B = (lC And &HFF0000) / &H10000
		
	End Function

	Public Function ColorRGBToLong(ByRef c As ColorRGB) As Integer
		
		Return RGB(c.R, c.G, c.B)
		
	End Function

	''------------------------------
	''Function: ColorBlend
	''Ýki rengi birbirine ratio oranýnda karýþtýrýyor.
	''Bir gradiend projesinden buldum.Ayný formül iki resmin birbiri üzerine çakýþtýrýlmasýnda da kullanýlmiþ.
	''Renklerin farklarýnýn ratio oranýna bölünmesi ile yeni renk elde ediliyor.
	''Geriye bu renk deðerini(RGB) döndürüyor.
	''------------------------------
	'
	'Public Function ColorBlend(C1 As ColorRGB, C2 As ColorRGB, ByVal Ratio As Integer) As ColorRGB
	'
	'    ColorBlend = ColorSub(C2, C1)
	'    ColorBlend = ColorScale(ColorBlend, 1 / Ratio)
	'    ColorBlend = ColorAdd(C1, ColorBlend)
	''Alternate
	'    ColorBlend.R = C1.R + Alpha * (C2.R - C1.R)
	'    ColorBlend.G = C1.G + Alpha * (C2.G - C1.G)
	'    ColorBlend.B = C1.B + Alpha * (C2.B - C1.B)
	'
	'End Function
	
	'Public Function ColorShade(C As ColorRGB, L As Single) As ColorRGB
	
	'    ColorShade = ColorScale(C, L)
	
	'End Function

End Module
