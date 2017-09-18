' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRecord

	Private Sub cmdPrevious_Click() Handles cmdPrevious.Click
		uctProductsSingleRecord1.MovePrevious()
	End Sub

	Private Sub cmdNext_Click() Handles cmdNext.Click
		uctProductsSingleRecord1.MoveNext()
	End Sub

	Private Sub cmdAddNew_Click() Handles cmdAddNew.Click
		uctProductsSingleRecord1.AddRecord()
	End Sub

	Private Sub cmdUpdate_Click() Handles cmdUpdate.Click
		uctProductsSingleRecord1.Update()
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		uctProductsSingleRecord1.Delete()
	End Sub

End Class
