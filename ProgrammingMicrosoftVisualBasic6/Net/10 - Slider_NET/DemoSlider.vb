' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class DemoSlider

	Private StartSelection(1) As Single
	
	Private Sub Form_Load() Handles MyBase.Load
		
		' this is the horizontal slider
		Slider1(0).Min = 0
		Slider1(0).Max = Picture1.ScaleWidth
		Slider1(0).TickFrequency = Slider1(0).Max / 20
		Slider1(0).Value = Slider1(0).Max / 2
		
		' this is the vertical slider
		Slider1(1).Min = 0
		Slider1(1).Max = Picture1.ScaleHeight
		Slider1(1).TickFrequency = Slider1(1).Max / 20
		Slider1(1).Value = Slider1(1).Max / 2
		
		Show()
		RepaintPicture()
		
	End Sub

	Private Sub Slider1_MouseDown(ByRef index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
		' if the shift key is being pressed, enter Select Range mode
		If Shift = VBRUN.ShiftConstants.vbShiftMask Then 
			' UPGRADE_ISSUE (#1748): The SelectRange property isn't supported. It always returns False. Assigning a True value to it throws an exception.
			Slider1(index).SelectRange = True
			' UPGRADE_ISSUE (#1768): The SelLength property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
			Slider1(index).SelLength = 0
			StartSelection(index) = Slider1(index).Value
		Else
			' UPGRADE_ISSUE (#1748): The SelectRange property isn't supported. It always returns False. Assigning a True value to it throws an exception.
			Slider1(index).SelectRange = False
		End If
	End Sub

	Private Sub Slider1_Scroll(ByRef index As Short)
		' show the current value as a tooltip text
		If index = 0 Then 
			' UPGRADE_ISSUE (#18B8): The Text property isn't suported. This replacement property always returns an empty string; assigning a non-empty string to it thows an exception.
			Slider1(index).Text = "X = " & Slider1(index).Value
		Else
			' UPGRADE_ISSUE (#18B8): The Text property isn't suported. This replacement property always returns an empty string; assigning a non-empty string to it thows an exception.
			Slider1(index).Text = "Y = " & Slider1(index).Value
		End If
		
		' UPGRADE_ISSUE (#1748): The SelectRange property isn't supported. It always returns False. Assigning a True value to it throws an exception.
		If Slider1(index).SelectRange Then 
			' if the indicator is being moved in SelectRange mode, you must
			' discern between two cases
			If Slider1(index).Value > StartSelection(index) Then 
				' UPGRADE_ISSUE (#1758): The SelStart property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
				Slider1(index).SelStart = StartSelection(index)
				' UPGRADE_ISSUE (#1768): The SelLength property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
				Slider1(index).SelLength = Slider1(index).Value - StartSelection(index)
			Else
				' UPGRADE_ISSUE (#1758): The SelStart property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
				Slider1(index).SelStart = Slider1(index).Value
				' UPGRADE_ISSUE (#1768): The SelLength property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
				Slider1(index).SelLength = StartSelection(index) - Slider1(index).Value
			End If
		End If
		
		Call RepaintPicture()
		
	End Sub

	Public Sub RepaintPicture()
		Dim startPos(1) As Single
		Dim endPos(1) As Single
		Dim x1 As Single
		Dim y1 As Single
		Dim x2 As Single
		Dim y2 As Single
		Dim index As Short
		
		' because controls belong to an array, we may use a For-Next
		' loop to repeat the same group of statements
		For index = 0 To 1
			startPos(index) = Slider1(index).Value
			endPos(index) = Slider1(index).Value
			' UPGRADE_ISSUE (#1748): The SelectRange property isn't supported. It always returns False. Assigning a True value to it throws an exception.
			If Slider1(index).SelectRange Then 
				' UPGRADE_ISSUE (#1758): The SelStart property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
				If Slider1(index).SelStart < Slider1(index).Value Then 
					' UPGRADE_ISSUE (#1758): The SelStart property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
					startPos(index) = Slider1(index).SelStart
				Else
					' UPGRADE_ISSUE (#1768): The SelLength property isn't supported. It always returns 0. Assigning a non-zero value to it throws an exception.
					endPos(index) = Slider1(index).Value + Slider1(index).SelLength
				End If
			End If
		Next
		
		' we finally have the coordinates of the rectangle
		x1 = startPos(0): x2 = endPos(0)
		y1 = startPos(1): y2 = endPos(1)
		' redraw everything
		Picture1.Cls()
		Picture1.Line(VBRUN.GraphicsOptions.None, 0, 0, x1, y1)
		Picture1.Line(VBRUN.GraphicsOptions.None, Picture1.ScaleWidth, 0, x2, y1)
		Picture1.Line(VBRUN.GraphicsOptions.BoxFilled, x1, y1, x2, y2, QBColor(4))
		Picture1.Line(VBRUN.GraphicsOptions.None, 0, Picture1.ScaleHeight, x1, y2)
		Picture1.Line(VBRUN.GraphicsOptions.None, Picture1.ScaleWidth, Picture1.ScaleHeight, x2, y2)
	End Sub

End Class
