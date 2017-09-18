' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmGrid

	Private Sub cmdFetch_Click() Handles cmdFetch.Click
		uctProductsDataGrid1.Products_FetchProductName = txtProductName.Text & "%"
		uctProductsDataGrid1.InitProducts2()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		With uctProductsDataGrid1
			.Width = ScaleWidth - .Left * 2
			.Height = ScaleHeight - .Top - 100
		End With
	End Sub

End Class
