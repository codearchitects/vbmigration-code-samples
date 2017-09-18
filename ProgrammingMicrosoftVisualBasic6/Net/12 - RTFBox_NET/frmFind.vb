' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmFind

	Public CancelPressed As Boolean
	
	Private Sub cmdFind_Click() Handles cmdFind.Click
		CancelPressed = False
		Hide()
	End Sub

	Private Sub cmdcancel_Click() Handles cmdCancel.Click
		CancelPressed = True
		Hide()
	End Sub

End Class
