' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		ShowColor()
	End Sub

	Private Sub vsbRed_Change() Handles vsbRed.Change
		ShowColor()
	End Sub

	Private Sub vsbRed_Scroll() Handles vsbRed.Scroll
		ShowColor()
	End Sub

	Private Sub vsbGreen_Change() Handles vsbGreen.Change
		ShowColor()
	End Sub

	Private Sub vsbGreen_Scroll() Handles vsbGreen.Scroll
		ShowColor()
	End Sub

	Private Sub vsbBlue_Change() Handles vsbBlue.Change
		ShowColor()
	End Sub

	Private Sub vsbBlue_Scroll() Handles vsbBlue.Scroll
		ShowColor()
	End Sub

	Private Sub ShowColor()
		Dim colorValue As Integer = RGB(vsbRed.Value, vsbGreen.Value, vsbBlue.Value)
		
		lblRed.Caption = vsbRed.Value
		lblGreen.Caption = vsbGreen.Value
		lblBlue.Caption = vsbBlue.Value
		
		optDecimal.Caption = "Dec: " & colorValue
		optHex.Caption = "Hex: " & Hex(colorValue)
		optRGB.Caption = "RGB: " & vsbRed.Value & "," & vsbGreen.Value & "," & vsbBlue.Value
		
		picTest.BackColor = FromOleColor6(colorValue)
	End Sub

	Private Sub cmdCopy_Click() Handles cmdCopy.Click
		Dim colorValue As Integer = RGB(vsbRed.Value, vsbGreen.Value, vsbBlue.Value)
		Clipboard6.Clear()
		
		If optDecimal.Value Then 
			Clipboard6.SetText(colorValue)
		ElseIf optHex.Value Then 
			Clipboard6.SetText("&H" & Hex(colorValue))
		ElseIf optRGB.Value Then 
			Clipboard6.SetText("RGB(" & vsbRed.Value & "," & vsbGreen.Value & "," & vsbBlue.Value & ")")
		End If
	End Sub

End Class
