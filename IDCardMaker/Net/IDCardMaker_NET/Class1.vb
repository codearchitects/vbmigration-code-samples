' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Class1

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	Private shadowx As Short
	Private shadowy As Short
	Private i As Short
	Public Sub Text3D(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx - i
			frmshowfnt.Picture2.CurrentY = shadowy + i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D2(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx + i
			frmshowfnt.Picture2.CurrentY = shadowy - i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D3(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
	' UPGRADE_INFO (#0501): The 'Text3D3' member isn't used anywhere in current application.
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx - i
			frmshowfnt.Picture2.CurrentY = shadowy
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D4(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
	' UPGRADE_INFO (#0501): The 'Text3D4' member isn't used anywhere in current application.
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx + i
			frmshowfnt.Picture2.CurrentY = shadowy
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D5(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
	' UPGRADE_INFO (#0501): The 'Text3D5' member isn't used anywhere in current application.
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx
			frmshowfnt.Picture2.CurrentY = shadowy + i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D6(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
	' UPGRADE_INFO (#0501): The 'Text3D6' member isn't used anywhere in current application.
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx
			frmshowfnt.Picture2.CurrentY = shadowy - i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D7(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)

		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx + i
			frmshowfnt.Picture2.CurrentY = shadowy + i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False

	End Sub
	
	Public Sub Text3D8(ByVal strng As String, ByVal fnt As String, ByVal fntsize As Short, ByVal Xval As Short, ByVal Yval As Short, ByVal depth As Short, ByVal Br As Short, ByVal Bg As Short, ByVal Bb As Short, ByVal rood As Short, ByVal groen As Short, ByVal blauw As Short)
		
		frmshowfnt.Picture2.AutoRedraw = True
		frmshowfnt.Picture2.FontSize = fntsize
		
		FontChangeName6(frmshowfnt.Picture2.Font, fnt)
		frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(Br, Bg, Bb))
		shadowx = Xval
		shadowy = Yval
		For i = 0 To depth
			frmshowfnt.Picture2.CurrentX = shadowx - i
			frmshowfnt.Picture2.CurrentY = shadowy - i
			If i = depth Then  frmshowfnt.Picture2.ForeColor = FromOleColor6(RGB(rood, groen, blauw))
			frmshowfnt.Picture2.PrintLine(strng)
		Next
		'frmshowfnt.AutoRedraw = False
		
	End Sub

End Class
