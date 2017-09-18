Attribute VB_Name = "Module1"
Option Explicit

' convert the contents of a TreeView into a string
' if a Node is provided, it only parse a sub tree
' if last argument is False or omitted, all items are parsed

Function TreeViewToString(TV As TreeView, Optional StartNode As Node, Optional OnlyVisible As Boolean) As String
    Dim nd As Node, childND As Node
    Dim res As String, i As Long
    Static Level As Integer
    
    ' exit if there are no nodes
    If TV.Nodes.count = 0 Then Exit Function
    If StartNode Is Nothing Then
        ' if StartNode is omitted, start from the first root node
        Set nd = TV.Nodes(1).Root.FirstSibling
    Else
        Set nd = StartNode
    End If
    ' output the starting node
    res = String$(Level, vbTab) & nd.Text & vbCrLf
    
    ' then call recursively this routine to output all child nodes
    ' if OnlyVisible=Tree, do this only if this node is expanded
    If nd.Children And (nd.Expanded Or OnlyVisible = False) Then
        Level = Level + 1
        Set childND = nd.Child
        For i = 1 To nd.Children
            res = res & TreeViewToString(TV, childND, OnlyVisible)
            Set childND = childND.Next
        Next
        Level = Level - 1
    End If
    
    ' if we are parsing the whole tree, we must account for multiple roots
    If StartNode Is Nothing Then
        Set nd = nd.Next
        Do Until nd Is Nothing
            res = res & TreeViewToString(TV, nd, OnlyVisible)
            Set nd = nd.Next
        Loop
    End If
    
    TreeViewToString = res
End Function
