' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' Modify this to match your directory structure
	Private Const DBPATH As String = "c:\program files\microsoft visual studio\Vb98\nwind.mdb"
	
	Private Sub Form_Load() Handles MyBase.Load
		Adodc1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH
		Adodc1.Refresh()
		' You need to explicitly refresh the DataSource property.
		ProductGrid1.DataSource = Adodc1
	End Sub

End Class
