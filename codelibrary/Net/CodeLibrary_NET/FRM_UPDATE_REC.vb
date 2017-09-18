' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class FRM_UPDATE_REC

	'-----------------------------------------------------------------------------------------------------
	'All codes are copyright by Philip V. Naparan 2004
	'
	'Website: www.naparansoft.cjb.net,www.philipnaparan.cjb.net,www.philipnaparan.com(under construction)
	'E-mail Address: philipnaparan@yahoo.com
	'Contact #: 639186443161
	'----------------------------------------------------------------------------------------------------

	Public seconds As Byte
	Private counter As Short
	Private Sub Form_Load() Handles MyBase.Load
		Timer1.Interval = seconds * 1000
		Timer2.Interval = 1000
		counter = 1
		ProgressBar1.Min = 0
		ProgressBar1.Max = seconds
		Timer1.Enabled = True
		Timer2.Enabled = True
	End Sub
	
	Private Sub Timer1_Timer() Handles Timer1.Timer
		Timer2.Enabled = False
		Unload6(Me)
	End Sub

	Private Sub Timer2_Timer() Handles Timer2.Timer
		On Error Resume Next 
		counter += 1
		ProgressBar1.Value = counter
	End Sub

End Class
