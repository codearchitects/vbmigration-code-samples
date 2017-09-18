' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class frmEval

	'Pretty short, Ha ?
	
	Private cEval As New Evaluator
	
	Private Sub cmdEval_Click() Handles cmdEval.Click
		If CanPlayWaves() Then  PlayWave((App6.Path & IIf(VB.Right(App6.Path, 1) = "\", "", "\") & "pff.Wav"))
		cEval.Evaluate(Text1.Text)
	End Sub

	Private Sub Text1_KeyPress(ByRef KeyAscii As Short) Handles Text1.KeyPress
		If CanPlayWaves() Then  PlayWave((App6.Path & IIf(VB.Right(App6.Path, 1) = "\", "", "\") & "flip.wav"))
	End Sub

End Class
