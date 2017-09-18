' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' module with factory methods

	Public Function New_CLine(ByRef X As Single, ByRef Y As Single, ByRef X2 As Single, ByRef Y2 As Single, Optional ByRef color As Object = VB6Missing) As CLine
		New_CLine = New CLine()
		New_CLine.Init(X, Y, X2, Y2, color)
	End Function

	Public Function New_CRectangle(ByRef Left As Single, ByRef Top As Single, ByRef Width As Single, ByRef Height As Single, Optional ByRef color As Object = VB6Missing, Optional ByRef FillColor As Object = VB6Missing) As CRectangle
		
		#If VBC_VER = 8 Then
		Dim Rect As New CRectangleClass
		Rect.Init(Left, Top, Width, Height, color, FillColor)
		New_CRectangle = Rect
		#Else
		' UPGRADE_WARNING (#0244): Code in current #If ,#ElseIf, or #Else block hasn't been upgraded.
		' original code in "Programming Microsoft Visual Basic 6" book
		Set New_CRectangle = New CRectangle
		New_CRectangle.Init Left, Top, Width, Height, color, FillColor
		#End If

	End Function

	Public Function New_CEllipse(ByRef Left As Single, ByRef Top As Single, ByRef Width As Single, ByRef Height As Single, Optional ByRef color As Object = VB6Missing, Optional ByRef FillColor As Object = VB6Missing) As CEllipse
		New_CEllipse = New CEllipse()
		New_CEllipse.Init(Left, Top, Width, Height, color, FillColor)
	End Function

	Public Function New_CSquare(ByRef Left As Single, ByRef Top As Single, ByRef Width As Single, Optional ByRef color As Object = VB6Missing, Optional ByRef FillColor As Object = VB6Missing) As CSquare
		New_CSquare = New CSquare()
		New_CSquare.Init(Left, Top, Width, color, FillColor)
	End Function

End Module
