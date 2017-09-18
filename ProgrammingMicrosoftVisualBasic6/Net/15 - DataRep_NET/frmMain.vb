' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub cmdOrders_Click() Handles cmdOrders.Click
		DataReport1.ShowDetails = chkShowDetails.Value
		If optOperation(0).Value Then 
			DataReport1.Show
			DataReport1.WindowState = VBRUN.FormWindowStateConstants.vbMaximized
		Else
			DataReport1.ExportReport(GetFormat(), App6.Path & "\Orders", True)
		End If
		DataReport1 = Nothing
	End Sub

	Private Sub cmdCustomers_Click() Handles cmdCustomers.Click
		If optOperation(0).Value Then 
			DataReport2.Show
			DataReport2.WindowState = VBRUN.FormWindowStateConstants.vbMaximized
		Else
			DataReport2.ExportReport(GetFormat(), App6.Path & "\Customers", True)
		End If
		DataReport2 = Nothing
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		optOperation(0).Value = True
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		lblStatus.Move(0, ScaleHeight - lblStatus.Height, ScaleWidth)
	End Sub

	Private Function GetFormat() As String
		If optFormat(0).Value Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rptKeyText'. Consider using the GetDefaultMember6 helper method.
			Return rptKeyText
		Else
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rptKeyHTML'. Consider using the GetDefaultMember6 helper method.
			Return rptKeyHTML
		End If
	End Function

	Private Sub optOperation_Click(ByRef Index As Short)
		optFormat(0).Enabled = (Index = 1)
		optFormat(1).Enabled = (Index = 1)
	End Sub

End Class
