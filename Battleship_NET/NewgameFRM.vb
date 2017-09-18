' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class NewgameFRM

	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	'"*•·‡·•*"'     One Computer Software    '"*•·‡·•*"'
	'"*•·‡·•*"'    Battleship Online  v1.o   '"*•·‡·•*"'
	'"*•·‡·•*"'        DeI3oe@aol.com        '"*•·‡·•*"'
	'"*•·‡·•*"''"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'"*•·‡·•*"'
	
	Private Sub Form_Load() Handles MyBase.Load
		CenterForm(Me)
		
	End Sub

	Private Sub noCMD_Click() Handles noCMD.Click
		PlayWav("douhavtogo.wav")
		TimeOUT(3.68) 'lets the sound play
		Application.Exit(): End
		
	End Sub

	Private Sub yesCMD_Click() Handles yesCMD.Click
		If FORMtagg = "1" Then 
			ServerFRM.GameStatsLBL.Caption = "Select Your Ships..."
			ServerFRM.startNEWgame()
			ServerFRM.MainTXT.SelText = "¨'°*·º·*°'¨ ": ServerFRM.MainTXT.SelColor = VBRUN.ColorConstants.vbBlue: ServerFRM.MainTXT.SelText = "New Game": ServerFRM.MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: ServerFRM.MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf
		Else
			ClientFRM.GameStatsLBL.Caption = "Select Your Ships..."
			ClientFRM.startNEWgame()
			ClientFRM.MainTXT.SelText = "¨'°*·º·*°'¨ ": ClientFRM.MainTXT.SelColor = VBRUN.ColorConstants.vbBlue: ClientFRM.MainTXT.SelText = "New Game": ClientFRM.MainTXT.SelColor = VBRUN.ColorConstants.vbBlack: ClientFRM.MainTXT.SelText = " ¨'°*·º·*°'¨" & ControlChars.CrLf
		End If
		Unload6(Me)
		
	End Sub

End Class
