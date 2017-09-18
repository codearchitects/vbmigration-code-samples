' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdStartTimer_Click() Handles cmdStartTimer.Click
		StartTimer(CInt(txtTimeout.Text))
	End Sub

	Private Sub cmdStopTimer_Click() Handles cmdStopTimer.Click
		StopTimer()
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		StopTimer()
	End Sub

End Class
