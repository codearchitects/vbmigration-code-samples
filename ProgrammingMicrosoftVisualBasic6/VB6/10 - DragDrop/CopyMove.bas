Attribute VB_Name = "Module1"
Option Explicit

Sub CopySubTree(SourceTV As TreeView, sourceND As Node, DestTV As TreeView, destND As Node)
    ' recursive routine that copies or moves all children of a node to another node
    Dim i As Long, so As Node, de As Node
    
    If sourceND.Children = 0 Then Exit Sub
    
    Set so = sourceND.Child
    For i = 1 To sourceND.Children
        ' add a node in the dest TreeView
        Set de = DestTV.Nodes.Add(destND, tvwChild, , so.Text, so.Image, so.SelectedImage)
        de.ExpandedImage = so.ExpandedImage
        
        ' now add all the children of this node, in a recursive manner
        CopySubTree SourceTV, so, DestTV, de
        
        ' get a reference to the next sibling
        Set so = so.Next
    Next
    
End Sub

