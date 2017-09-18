' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub lblTellMe_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lblTellMe.MouseMove
		lblTellMe.ForeColor = Color.Red 
	End Sub

	Private Sub lblTellMe_Click() Handles lblTellMe.Click
		MsgBox6("I am glad you asked")
	End Sub

	Private Sub lblDontCare_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lblDontCare.MouseMove
		lblDontCare.ForeColor = Color.Red 
	End Sub

	Private Sub lblDontCare_Click() Handles lblDontCare.Click
		MsgBox6("Come on, this was just an example!")
	End Sub

	Private Sub lblBackToVB_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lblBackToVB.MouseMove
		lblBackToVB.ForeColor = Color.Red 
	End Sub

	Private Sub lblBackToVB_Click() Handles lblBackToVB.Click
		Unload6(Me)
	End Sub

	Private Sub Form_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles MyBase.MouseMove
		lblTellMe.ForeColor = Color.Blue 
		lblDontCare.ForeColor = Color.Blue 
		lblBackToVB.ForeColor = Color.Blue 
	End Sub

End Class
