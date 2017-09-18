' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' WARNING: modify the DBPATH constant to match your database's path.
	Private Const DBPATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\Nwind.mdb"
	
	Private Sub Form_Load() Handles MyBase.Load
		Dim cn As New ADODB.ConnectionClass
		Dim rs As New ADODB.RecordsetClass
		cn.Open("Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & DBPATH)
		rs.Open("Orders", cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		
		LoadListViewFromRecordset(ListView1, rs)
		ListViewAdjustColumnWidth(ListView1, True)
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		ListView1.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

	Private Sub ListView1_ColumnClick(ByVal ColumnHeader As VB6ColumnHeader) Handles ListView1.ColumnClick
		' sort according to data in this column
		
		' a few special fields
		If ColumnHeader.Text = "Freight" Then 
			ListViewSortOnNonStringField(ListView1, ColumnHeader.Index)
			Exit Sub
		ElseIf ColumnHeader.Text = "OrderDate" Or ColumnHeader.Text = "RequiredDate" Then 
			ListViewSortOnNonStringField(ListView1, ColumnHeader.Index, , True)
			Exit Sub
		End If
		
		If ListView1.Sorted And ColumnHeader.Index - 1 = ListView1.SortKey Then 
			' the ListView is already sorted on this column, just invert the sort order
			ListView1.SortOrder = 1 - ListView1.SortOrder
		Else
			ListView1.SortOrder = MSComctlLib.ListSortOrderConstants.lvwAscending
			ListView1.SortKey = ColumnHeader.Index - 1
		End If
		ListView1.Sorted = True
	End Sub

End Class
