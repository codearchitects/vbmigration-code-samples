' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' IMPORTANT: ensure that the DB_PATH constant is pointing to the
	' NWind.mdb database on your system
	Private Const DB_PATH As String = "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=c:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
	
	' How many euros in one dollar ?
	' In a real program this would be a variable, of course.
	Private Const DOLLARS_TO_EURO As Single = 1.1734
	
	' A StdDataFormat object that raises events.
	Private WithEvents sdfFreight As VB6StdDataFormat
	Private Sub Form_Load() Handles MyBase.Load
		' This is an example of a dynamic StdDataFormat object
		Dim sdfShipped As New VB6StdDataFormat
		sdfShipped.Type = StdFormat.FormatType.fmtCustom
		sdfShipped.Format = "mmm dd, yyyy"
		txtShippedDate.DataFormat = sdfShipped
		
		' This is an example of a StdDataFormat object
		' that relies on events - no need to set properties
		sdfFreight = New VB6StdDataFormat()
		txtFreight.DataFormat = sdfFreight
		
		' You need to refresh the Data control
		' to display the first record correctly.
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=" & DB_PATH
		Adodc1.Refresh()
		
	End Sub

	Private Sub sdfFreight_Format(ByVal DataValue As VB6StdDataValue) Handles sdfFreight.FormatEvent6
		' Show the value in red ink if >30 dollars
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'DataValue.Value'. Consider using the GetDefaultMember6 helper method.
		If DataValue.Value > 30 Then 
			DataValue.TargetObject.ForeColor = Color.Red 
		Else
			DataValue.TargetObject.ForeColor = Color.Black 
		End If
		
		' Convert to Euros if necessary
		If optFreight(1).Value Then 
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'DataValue.Value'. Consider using the SetDefaultMember6 helper method.
			DataValue.Value = Math.Round(DataValue.Value * DOLLARS_TO_EURO, 2)
		End If
	End Sub

	Private Sub sdfFreight_UnFormat(ByVal DataValue As VB6StdDataValue) Handles sdfFreight.UnFormat
		' Convert back to dollars if necessary
		If optFreight(1).Value Then 
			' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'DataValue.Value'. Consider using the SetDefaultMember6 helper method.
			DataValue.Value = Math.Round(DataValue.Value / DOLLARS_TO_EURO, 2)
		End If
	End Sub

	Private Sub optFreight_Click(ByRef Index As Short)
		If Index = 0 Then 
			' Convert from Euros to Dollars.
			txtFreight.Text = Trim(Math.Round(CDbl(txtFreight.Text) / DOLLARS_TO_EURO, 2))
		Else
			' Convert from dollars to Euros.
			txtFreight.Text = Trim(Math.Round(CDbl(txtFreight.Text) * DOLLARS_TO_EURO, 2))
		End If
	End Sub

End Class
