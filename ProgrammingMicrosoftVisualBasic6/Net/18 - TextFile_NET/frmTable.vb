' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmTable

	Public MyData As New TextFileDataSource
	
	Private Sub Form_Load() Handles MyBase.Load
		DataGrid1.DataMember = "Publishers"
		DataGrid1.DataSource = MyData
		
		' adjust the layout.
		With DataGrid1
			.Columns(0).Width = 600
			.Columns(1).Width = 2000
			.Columns(2).Width = 2000
			.Columns(3).Width = 2000
			.Columns(4).Width = 1200
			.Columns(5).Width = 1200
			.Columns(6).Width = 1200
			.Columns(7).Width = 1200
			.Columns(8).Width = 1200
			.Columns(9).Width = 1200
		End With

	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		DataGrid1.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

End Class
