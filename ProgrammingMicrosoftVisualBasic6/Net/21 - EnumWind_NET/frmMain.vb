' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub Form_Load() Handles MyBase.Load
		ShowWindows(TreeView1, 0)
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		TreeView1.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

	Public Sub ShowWindows(ByRef tvw As VB6TreeView, ByVal hWnd As Integer, Optional ByRef ParentNode As VB6Node = Nothing)
	' UPGRADE_INFO (#0551): The 'tvw' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim winHandles() As Integer
		Dim i As Integer
		Dim Node As VB6Node = Nothing
		
		If ParentNode Is Nothing Then 
			' If no Parent node, let's add a "desktop" root node.
			ParentNode = tvw.Nodes.Add(, , , "Desktop")
			ParentNode.Expanded = True
		End If
		
		winHandles = ChildWindows(hWnd)
		For i = 1 To UBound6(winHandles)
			' Add a node for this child window
			Node = tvw.Nodes.Add(ParentNode.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , WindowDescription(winHandles(i)))
			' Recursively call this routine to show this window's children.
			ShowWindows(tvw, winHandles(i), Node)
		Next
	End Sub

End Class
