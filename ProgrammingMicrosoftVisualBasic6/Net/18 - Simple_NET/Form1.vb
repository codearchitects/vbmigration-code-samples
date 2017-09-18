' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Const DBPATH As String = "c:\Program Files\Microsoft Visual Studio\VB98\nwind.mdb"
	
	Private cn As New ADODB.ConnectionClass
	Private rs As New ADODB.RecordsetClass
	
	Private employee As New CEmployee
	
	Private Sub cmdLoad_Click() Handles cmdLoad.Click
		' Open the recordset
		cn.Open("Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH)
		rs.Open("Employees", cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
		
		employee.DataSource = rs
		
		' Load the records in the ListView control.
		Do Until rs.EOF
			' Note that we're using derived CompleteName and Age properties.
			With ListView1.ListItems.Add(, , employee.CompleteName)
				.ListSubItems.Add(, , employee.Age)
			End With
			rs.MoveNext()
		Loop
		rs.Close()
		cn.Close()
		
	End Sub

End Class
