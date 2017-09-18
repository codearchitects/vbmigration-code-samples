' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRecord

	Private Sub cmdNext_Click() Handles cmdNext.Click
		DataEnvironment1_DefInstance.rsauthors.MoveNext()
	End Sub

	Private Sub cmdPrevious_Click() Handles cmdPrevious.Click
		DataEnvironment1_DefInstance.rsauthors.MovePrevious()
	End Sub

	Private Sub cmdShowGrid_Click() Handles cmdShowGrid.Click
		frmGrid.Show()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		If (DataEnvironment1_DefInstance.Connection1.State And ADODB.ObjectStateEnum.adStateOpen) = 0 Then 
			MsgBox6("Unable to open the connection", MsgBoxStyle.Critical)
		End If
	End Sub

End Class
