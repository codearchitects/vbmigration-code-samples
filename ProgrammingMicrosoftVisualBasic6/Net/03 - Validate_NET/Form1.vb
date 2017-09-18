' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdOK_Click() Handles cmdOK.Click
		' this causes validation
		Unload6(Me)
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		' this doesn't cause validation
		Unload6(Me)
	End Sub

	Private Sub cmdHelp_Click() Handles cmdHelp.Click
		MsgBox6("Help pressed (no validation)", MsgBoxStyle.Information)
	End Sub

	Private Sub txtRequired_Validate(ByRef Cancel As Boolean) Handles txtRequired.Validate
		' check that field is not null
		If txtRequired.Text = "" Then 
			MsgBox6("Please enter something here", MsgBoxStyle.Exclamation)
			Cancel = True
		End If
	End Sub

	Private Sub txtNumeric_Validate(ByRef Cancel As Boolean) Handles txtNumeric.Validate
		If Not IsNumeric6(txtNumeric.Text) Then 
			Cancel = True
		ElseIf CDbl(txtNumeric.Text) < 1 Or CDbl(txtNumeric.Text) > 1000 Then 
			Cancel = True
		End If
		If Cancel Then 
			MsgBox6("Please enter a number in range [1-1000]", MsgBoxStyle.Exclamation)
		End If
	End Sub

	Private Sub Form_QueryUnload(ByRef Cancel As Short, ByRef UnloadMode As Short) Handles MyBase.QueryUnload
		' you can't close this form without validating the current field
		Dim ctrl As Object = Nothing
		If UnloadMode = VBRUN.QueryUnloadConstants.vbFormControlMenu Then 
			On Error Resume Next 
			' give the focus to each control on the form
			' then validate it
			For Each ctrl In Controls6
				Err.Clear()
				CObj(ctrl).SetFocus
				If Err.Number = 0 Then 
					' don't check controls that can't receive the focus
					ValidateControls()
					If Err.Number = 380 Then 
						Cancel = CShort(True)
						Exit Sub
					End If
				End If
			Next
		End If
	End Sub

End Class
