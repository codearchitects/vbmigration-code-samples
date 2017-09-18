' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		Dim i As Integer
		For i = 1 To 5000
			List1.AddItem("Item #" & i)
			List2.AddItem("Item #" & i)
		Next
		' the first items is always selected
		List2.Selected(0) = True
	End Sub

	Private Sub cmdSelectAll_Click() Handles cmdSelectAll.Click
		Dim i As Integer
		Dim saveIndex As Integer
		Dim saveTop As Integer
		' save current state
		saveIndex = List2.ListIndex
		saveTop = List2.TopIndex
		' make the listbox invisible to avoid flickering
		List2.Visible = False
		' try uncomment the next line to see the "invisible" listbox
		' Refresh
		' change the select state for all items
		For i = 1 To List2.ListCount - 1
			List2.Selected(i) = True
		Next
		' restore original state, make it visible again
		List2.TopIndex = saveTop
		List2.ListIndex = saveIndex
		List2.Visible = True
	End Sub

	Private Sub cmdClearAll_Click() Handles cmdClearAll.Click
		Dim i As Integer
		Dim saveIndex As Integer
		Dim saveTop As Integer
		' save current state
		saveIndex = List2.ListIndex
		saveTop = List2.TopIndex
		' make the listbox invisible to avoid flickering
		List2.Visible = False
		' change the select state for all items
		For i = 1 To List2.ListCount - 1
			List2.Selected(i) = False
		Next
		' restore original state, make it visible again
		List2.TopIndex = saveTop
		List2.ListIndex = saveIndex
		List2.Visible = True
	End Sub

	Private Sub cmdInvertAll_Click() Handles cmdInvertAll.Click
		Dim i As Integer
		Dim saveIndex As Integer
		Dim saveTop As Integer
		' save current state
		saveIndex = List2.ListIndex
		saveTop = List2.TopIndex
		' make the listbox invisible to avoid flickering
		List2.Visible = False
		' change the select state for all items
		For i = 1 To List2.ListCount - 1
			List2.Selected(i) = Not List2.Selected(i)
		Next
		' restore original state, make it visible again
		List2.TopIndex = saveTop
		List2.ListIndex = saveIndex
		List2.Visible = True
	End Sub

	Private Sub List2_ItemCheck(ByRef Item As Short) Handles List2.ItemCheck
		' refuse to deselect the first item
		If Item = 0 And List2.Selected(0) = False Then 
			List2.Selected(0) = True
			MsgBox6("You can't deselect the first item", MsgBoxStyle.Exclamation, "ItemCheck event demo")
		End If
	End Sub

End Class
