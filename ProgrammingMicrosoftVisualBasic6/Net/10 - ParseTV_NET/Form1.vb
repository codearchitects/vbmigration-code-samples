' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdCopy_Click() Handles cmdCopy.Click
		Clipboard6.Clear()
		Clipboard6.SetText(TreeViewToString(TreeView1, , True))
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' add a number of random items to the leftmost TreeView control
		Dim i1 As Integer
		Dim i2 As Integer
		Dim i3 As Integer
		Dim no1 As VB6Node = Nothing
		Dim no2 As VB6Node = Nothing
		Dim no3 As VB6Node = Nothing
		Dim count As Integer
		
		For i1 = 0 To Rnd() * 20
			count += 1
			no1 = TreeView1.Nodes.Add(, , , "Item #" & count, 1)
			For i2 = 0 To Rnd() * 15
				count += 1
				no2 = TreeView1.Nodes.Add(no1.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "Item #" & count, 1)
				For i3 = 0 To Rnd() * 10
					count += 1
					no3 = TreeView1.Nodes.Add(no2.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "Item #" & count, 1)
				Next
			Next
		Next
		' set properties common to all nodes
		For i1 = 1 To TreeView1.Nodes.Count
			TreeView1.Nodes(i1).ExpandedImage = 2
		Next
	End Sub

End Class
