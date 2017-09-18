' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRecord

	Public MyData As TextFileDataSource
	
	Private Bookmark As Object
	
	Private Sub Form_Load() Handles MyBase.Load
		' Bind the text controls
		' (DataMember and DataField properties have been set at design time)
		Dim ctrl As Object = Nothing
		For Each ctrl In Controls6
			If TypeOf ctrl Is VB6TextBox Then 
				CObj(ctrl).DataSource = MyData
			End If
		Next
	End Sub

	Private Sub cmdMove_Click(ByRef Index As Short)
		Select Case Index
		Case 0
			MyData.MoveFirst()
		Case 1
			MyData.MovePrevious()
		Case 2
			MyData.MoveNext()
		Case 3
			MyData.MoveLast()
		Case 4
			MyData.AddNew()
		Case 5
			MyData.Delete()
			MyData.MoveNext()
			If MyData.EOF Then  MyData.MoveLast()
		Case 6
			Bookmark = MyData.Bookmark
		Case 7
			MyData.Bookmark = Bookmark
		Case 8
			MyData.Flush_Renamed()
		End Select
	End Sub

	Private Sub chkReadOnlyMode_Click() Handles chkReadOnlyMode.Click
		MyData.ReadOnlyMode = chkReadOnlyMode.Value
	End Sub

End Class
