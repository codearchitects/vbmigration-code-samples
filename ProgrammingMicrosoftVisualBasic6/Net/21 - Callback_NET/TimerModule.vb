' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module TimerModule
' List of Private delegates used for callback methods
Private Delegate Sub SetTimer_CBK(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal idEvent As Integer, ByVal SysTime As Integer)

	' UPGRADE_INFO (#0531): You can replace calls to the 'SetTimer' unamanged method with the following .NET member(s): System.Threading.Timer constructor, System.Timers.Timer constructor, System.Windows.Forms.Timer constructor, System.Windows.Forms.Timer.Interval
	Private Declare Function SetTimer Lib "user32" (ByVal hWnd As Integer, ByVal nIDEvent As Integer, ByVal uElapse As Integer, ByVal lpTimerFunc As Integer) As Integer
	Private  Declare Function SetTimer_Private Lib "user32" Alias "SetTimer"  (ByVal hWnd As Integer, ByVal nIDEvent As Integer, ByVal uElapse As Integer, ByVal lpTimerFunc As SetTimer_CBK) As Integer
	
	' This wrapper method ensures that delegate values are kept alive between calls.
	Private Function SetTimer (ByVal hWnd As Integer, ByVal nIDEvent As Integer, ByVal uElapse As Integer, ByVal lpTimerFunc As SetTimer_CBK) As Integer
		KeepAliveObjects6.Add(lpTimerFunc)
		Return SetTimer_Private(hWnd, nIDEvent, uElapse, lpTimerFunc)
	End Function
	
	' UPGRADE_INFO (#0531): You can replace calls to the 'KillTimer' unamanged method with the following .NET member(s): System.Threading.Timer.Dispose, System.Timers.Timer.Dispose, System.Windows.Forms.Timer.Dispose
	Private Declare Function KillTimer Lib "user32" (ByVal hWnd As Integer, ByVal nIDEvent As Integer) As Integer
	
	' This is the ID of the timer created.
	Private timerID As Integer
	
	Public Sub StartTimer(ByVal timeout As Integer)
		' Don't start the timer if it's already running.
		If timerID = 0 Then 
			timerID = SetTimer(0, 0, timeout, AddressOf Timer_CBK)
		End If
	End Sub

	Public Sub StopTimer()
		' Don't stop the timer if it isn't running.
		If timerID Then 
			KillTimer(0, timerID)
			timerID = 0
		End If
	End Sub

	Public Sub Timer_CBK(ByVal hWnd As Integer, ByVal uMsg As Integer, ByVal idEvent As Integer, ByVal SysTime As Integer)
		' Just display the system time in a label control.
		Form1.lblTimer.Caption = SysTime
	End Sub

End Module
