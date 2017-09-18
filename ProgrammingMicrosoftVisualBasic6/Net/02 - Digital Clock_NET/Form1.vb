' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Resize() Handles MyBase.Resize
		Dim msg As String = ""
		Dim size As Short
		
		msg = TimeString
		For size = 200 To 8 Step -2
			FontChangeSize6(Font, size)
			If TextWidth(msg) <= ScaleWidth And TextHeight(msg) <= ScaleHeight Then 
				' we've found a font size that is OK
				Exit For
			End If
		Next
		' enable timer
		Timer1.Enabled = True
		Timer1.Interval = 1000
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		Cls()
		Me.CurrentX = -120
		PrintLine(TimeString)
	End Sub

End Class
