' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const DATABASE_NAME As String = "c:\program files\microsoft visual studio\VB98\Biblio.mdb"
	
	Private Sub txtFilter_Change() Handles txtFilter.Change
		cmdApply.Enabled = True
	End Sub

	Private Sub cmdApply_Click() Handles cmdApply.Click
		If txtFilter.Text = "" Then 
			MyDataControl1.RecordSource = "Publishers"
		Else
			MyDataControl1.RecordSource = "Select * From Publishers Where Name Like '" & txtFilter.Text & "%'"
		End If
		MyDataControl1.Refresh()
		cmdApply.Enabled = False
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		MyDataControl1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DATABASE_NAME
	End Sub

End Class
