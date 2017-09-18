' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmListView

	Private Sub Form_Load() Handles MyBase.Load
		AddListViewLine(ListView1, "1", "John", "Smith")
		AddListViewLine(ListView1, "2", "Robert", "Doe")
		AddListViewLine(ListView1, "3", "Anne", "Lipton")
		AddListViewLine(ListView1, "4", "Christine", "Carter")
		AddListViewLine(ListView1, "5", "Lee", "Cross")
		AddListViewLine(ListView1, "6", "Jean", "Redish")
		AddListViewLine(ListView1, "7", "Patrick", "Coen")
		
	End Sub

	' Support routine for easily adding items to a ListView control.
	
	Public Sub AddListViewLine(ByVal lvw As VB6ListView, ByVal ParamArray items() As Object)
		Dim i As Integer
		With lvw.ListItems
			With .Add(, , items(0)).ListSubItems
				For i = 1 To UBound6(items)
					.Add(, , items(i))
				Next
			End With
		End With
	End Sub

	Private Sub cmdVisibleItems_Click() Handles cmdVisibleItems.Click
		MsgBox6("Visible Lines = " & VisibleLines(ListView1))
	End Sub

	Private Sub cmdScroll_Click(ByRef Index As Short)
		Select Case Index
		Case 0 ' Up
			ScrollListView(ListView1, 0, -16)
		Case 1 ' Left
			ScrollListView(ListView1, -16, 0)
		Case 2 ' Right
			ScrollListView(ListView1, 16, 0)
		Case 3 ' Down
			ScrollListView(ListView1, 0, 16)
		End Select
	End Sub

End Class
