' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSplash

	Private Sub Form_Click() Handles MyBase.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Timer1.Enabled = False
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		Unload6(Me)
	End Sub

End Class
