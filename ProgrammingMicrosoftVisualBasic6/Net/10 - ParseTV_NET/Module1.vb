' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' convert the contents of a TreeView into a string
	' if a Node is provided, it only parse a sub tree
	' if last argument is False or omitted, all items are parsed
	
	Public Function TreeViewToString(ByRef TV As VB6TreeView, Optional ByRef StartNode As VB6Node = Nothing, Optional ByRef OnlyVisible As Boolean = False) As String
	' UPGRADE_INFO (#0551): The 'TV' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'StartNode' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'OnlyVisible' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim nd As VB6Node = Nothing
		Dim childND As VB6Node = Nothing
		Dim res As String = ""
		Dim i As Integer
		Static Level As Short
		
		' exit if there are no nodes
		If TV.Nodes.Count = 0 Then  Exit Function
		If StartNode Is Nothing Then 
			' if StartNode is omitted, start from the first root node
			nd = TV.Nodes(1).Root.FirstSibling
		Else
			nd = StartNode
		End If
		' output the starting node
		res = String6(Level, ControlChars.Tab) & nd.Text & ControlChars.CrLf
		
		' then call recursively this routine to output all child nodes
		' if OnlyVisible=Tree, do this only if this node is expanded
		If nd.Children And (nd.Expanded Or OnlyVisible = False) Then 
			Level += 1
			childND = nd.Child
			For i = 1 To nd.Children
				res &= TreeViewToString(TV, childND, OnlyVisible)
				childND = childND.[Next]
			Next
			Level -= 1
		End If
		
		' if we are parsing the whole tree, we must account for multiple roots
		If StartNode Is Nothing Then 
			nd = nd.[Next]
			Do Until nd Is Nothing
				res &= TreeViewToString(TV, nd, OnlyVisible)
				nd = nd.[Next]
			Loop
		End If
		
		Return res
	End Function

End Module
