' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Resize() Handles MyBase.Resize
		Dim i As Short
		Dim b As Boolean
		
		i = Abs6(CShort(b))

		lblStatus.Move(0, ScaleHeight - lblStatus.Height, ScaleWidth, lblStatus.Height)
	End Sub

	Private Sub mebDecNumber_KeyPress(ByRef KeyAscii As Short) Handles mebDecNumber.KeyPress
		' Since we don't have a Mask, we must manually filter out invalid characters
		Select Case KeyAscii
		Case 0 To 31, 48 To 57, Asc(","), Asc("-")
		Case Else
			lblStatus.Caption = "'" & Chr6(KeyAscii) & "' is an invalid character"
			Beep()
			KeyAscii = 0
		End Select
	End Sub

	Private Sub mebPhone_ValidationError(ByRef InvalidText As String, ByRef StartPosition As Short) Handles mebPhone.ValidationError
		lblStatus.Caption = "'" & Mid(InvalidText, StartPosition + 1, 1) & "' is an invalid character"
	End Sub

End Class
