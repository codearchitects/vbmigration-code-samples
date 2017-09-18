' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSecondary
' UPGRADE_INFO (#0501): The 'frmSecondary' member isn't used anywhere in current application.

	Private Sub txtMax_KeyPress(ByRef KeyAscii As Short) Handles txtMax.KeyPress
		If KeyAscii < 48 And KeyAscii > 57 And KeyAscii <> 8 Then  'It's a number or backspace
			'Beep and delete the invalid character
			KeyAscii = 0
		ElseIf KeyAscii = 13 Or KeyAscii = 10 Then  'User pressed Enter
			'Set the Max values
			hscValue.Max = Int(txtMax.Text)
			cpbProgress.Max = Int(txtMax.Text)
		End If
	End Sub

	Private Sub txtMin_KeyPress(ByRef KeyAscii As Short) Handles txtMin.KeyPress
		If KeyAscii < 48 And KeyAscii > 57 And KeyAscii <> 8 Then  'It's a number or backspace
			'Beep and delete the invalid character
			Beep()
			KeyAscii = 0
		ElseIf KeyAscii = 13 Or KeyAscii = 10 Then  'User pressed Enter
			'Set the Max values
			hscValue.Min = Int(txtMin.Text)
			cpbProgress.Min = Int(txtMin.Text)
		End If
	End Sub

	Private Sub hscValue_GotFocus() Handles hscValue.GotFocus
		'This will prevent the scroll bar flashing
		'when it gets focus
		cpbProgress.SetFocus()
	End Sub

	Private Sub hscValue_Change() Handles hscValue.Change
		'Change the value
		cpbProgress.Value = hscValue.Value
	End Sub

	Private Sub hscValue_Scroll() Handles hscValue.Scroll
		'Change the value
		cpbProgress.Value = hscValue.Value
	End Sub

	Private Sub lblColor1_Click() Handles lblColor1.Click
		On Error GoTo UserCanceled 
		
		'Set the dialog's color
		dlgColors.Color = shpColor1.FillColor
		
		'Show the dialog
		dlgColors.ShowColor()
		
		'Set the new color
		shpColor1.FillColor = dlgColors.Color
		cpbProgress.Color1 = dlgColors.Color
		
UserCanceled:
	End Sub

	Private Sub lblColor2_Click() Handles lblColor2.Click
		On Error GoTo UserCanceled 
		
		'Set the dialog's color
		dlgColors.Color = shpColor2.FillColor
		
		'Show the dialog
		dlgColors.ShowColor()
		
		'Set the new color
		shpColor2.FillColor = dlgColors.Color
		cpbProgress.Color2 = dlgColors.Color
		
UserCanceled:
	End Sub

	Private Sub lblX_Click() Handles lblX.Click
		'Hide this form and display the message box
		frmMsgbox.Show()
		Unload6(Me)
		' IGNORED: frmMsgbox.Show
	End Sub

End Class
