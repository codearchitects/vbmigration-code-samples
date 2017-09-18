' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	Public Sub CopySubTree(ByRef SourceTV As VB6TreeView, ByRef sourceND As VB6Node, ByRef DestTV As VB6TreeView, ByRef destND As VB6Node)
	' UPGRADE_INFO (#0551): The 'SourceTV' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'sourceND' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'DestTV' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'destND' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' recursive routine that copies or moves all children of a node to another node
		Dim i As Integer
		Dim so As VB6Node = Nothing
		Dim de As VB6Node = Nothing
		
		If sourceND.Children = 0 Then  Exit Sub
		
		so = sourceND.Child
		For i = 1 To sourceND.Children
			' add a node in the dest TreeView
			de = DestTV.Nodes.Add(destND, MSComctlLib.TreeRelationshipConstants.tvwChild, , so.Text, so.Image, so.SelectedImage)
			de.ExpandedImage = so.ExpandedImage
			
			' now add all the children of this node, in a recursive manner
			CopySubTree(SourceTV, so, DestTV, de)
			
			' get a reference to the next sibling
			so = so.[Next]
		Next
		
	End Sub

End Module
