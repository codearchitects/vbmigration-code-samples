' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private RndNum As Byte 'A random number
	
	Private Sub Form_Load() Handles MyBase.Load
		Randomize(Timer6)
		
		'Display a (long!) message box about color depths
		If MsgBox6("Because ''Cool Progress Bar'' creates a gradation effect, it is important" & ControlChars.CrLf & "that your system's colors are not too low." & ControlChars.CrLf & ControlChars.CrLf & "To see the effect with a minimum of quality, you should have a color depth of" & ControlChars.CrLf & "High Color (16 bit) or, for best performance, True Color (24 or 32 bits)." & ControlChars.CrLf & ControlChars.CrLf & "To change the color depth of your system, click ''Definitions -> Control" & ControlChars.CrLf & "Panel'' in your Start Menu, double-click on ''Monitor''. You can now change" & ControlChars.CrLf & "the color depth in the ''Definitions'' tab.''" & ControlChars.CrLf & "Click ''Cancel'' to exit and change the color depth of your system.", MsgBoxStyle.OkCancel Or MsgBoxStyle.Information, "Warning") = MsgBoxResult.Cancel Then 
			'The user clicked "Cancel", so exit
			Application.Exit(): End
		End If
	End Sub

	Private Sub tmrTimer_Timer() Handles tmrTimer.Timer
		'This will not load anything at all; in fact,
		'all it does is increment the progress bar's
		'value randomly (between 0 and 4) every 0.1
		'seconds
		
		'Pick a random number
		RndNum = Rnd() * 4
		
		'Set the percentage label and the progress bar
		'(these calculations are only here because the
		'progress bar's max is 200 and not 100, to get
		'smoother steps each time the value is changed)
		cpbProgress.Value += RndNum
		lblPercentage.Caption = Str6(cpbProgress.Value \ 2) & "%"
		
		'If we've reached the max, unload this and show
		'the secondary form
		If cpbProgress.Value = 200 Then 
			frmSecondary.Show()
			Unload6(Me)
			' IGNORED: frmSecondary.Show
		End If
	End Sub

	Private Sub lblX_Click() Handles lblX.Click
		'Skip "loading"
		frmSecondary.Show()
		Unload6(Me)
		' IGNORED: frmSecondary.Show
	End Sub

End Class
