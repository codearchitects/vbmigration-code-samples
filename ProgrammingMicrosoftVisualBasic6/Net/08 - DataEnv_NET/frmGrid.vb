' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmGrid

	Private Sub cmdFilter_Click() Handles cmdFilter.Click
		' Close the recordset before retrying the query
		If DataEnvironment1_DefInstance.rsAuthorsByState.State And ADODB.ObjectStateEnum.adStateOpen Then 
			DataEnvironment1_DefInstance.rsAuthorsByState.Close()
		End If
		
		' First method to set the binding
		DataEnvironment1_DefInstance.AuthorsByState(txtState.Text)
		DataGrid1.DataSource = DataEnvironment1_DefInstance.rsAuthorsByState
		' Alternate method
		' DataGrid1.DataMember = "AuthorsByState"
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		DataGrid1.Move(0, DataGrid1.Top, ScaleWidth, ScaleHeight - DataGrid1.Top)
	End Sub

End Class
