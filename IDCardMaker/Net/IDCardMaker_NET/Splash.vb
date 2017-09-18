' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Splash

	Private Time_Open As Byte
	
	Private Sub Form_Load() Handles MyBase.Load
		Timer1.Interval = 1
		Time_Open = 0
	End Sub

	Private Sub FrmAbout_Click()
	' UPGRADE_INFO (#0501): The 'FrmAbout_Click' member isn't used anywhere in current application.
		Unload6(Me)
	End Sub

	Private Sub Timer1_Timer() Handles Timer1.Timer
		Label1.Caption = Time_Open & "%"
		If Time_Open < 100 Then 
			Time_Open += 1
		ElseIf Time_Open = 100 Then 
			Unload6(Me)
			frmshowfnt.Show()
			Timer1.Interval = 0
			Timer1.Enabled = False
		End If
		Progress.Value = Time_Open
	End Sub

End Class
