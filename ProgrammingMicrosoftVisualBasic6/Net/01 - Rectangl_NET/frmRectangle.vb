' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRectangle

	Private Sub cmdEvaluate_Click() Handles cmdEvaluate.Click
		' declare two floating point variables
		Dim reWidth As Double
		Dim reHeight As Double
		On Error GoTo WrongValues 
		
		' extract values from input textbox controls
		reWidth = CDbl(txtWidth.Text)
		reHeight = CDbl(txtHeight.Text)
		' ensure that they are positive values
		If reWidth <= 0 Or reHeight <= 0 Then  GoTo WrongValues
		' evaluate results and assign to output textboxes
		txtPerimeter.Text = CStr((reWidth + reHeight) * 2)
		txtArea.Text = CStr(reWidth * reHeight)
		Exit Sub
		
WrongValues:
		MsgBox6("Please enter valid Width and Height values", MsgBoxStyle.Exclamation)
		
	End Sub

	Private Sub txtWidth_Change() Handles txtWidth.Change
		' clear results, that are now invalid
		txtPerimeter.Text = ""
		txtArea.Text = ""
	End Sub

	Private Sub txtHeight_Change() Handles txtHeight.Change
		' clear results, that are now invalid
		txtPerimeter.Text = ""
		txtArea.Text = ""
	End Sub

End Class
