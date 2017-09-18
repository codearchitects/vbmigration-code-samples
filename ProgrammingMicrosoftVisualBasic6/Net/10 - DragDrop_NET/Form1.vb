' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' the source control
	Private SourceTreeView As VB6TreeView
	' the source Node object
	Private SourceNode As VB6Node
	' the state of Shift keys during the D&D operation
	Private ShiftState As Short
	
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
			no1 = TreeView1(0).Nodes.Add(, , , "Item #" & count, 1)
			For i2 = 0 To Rnd() * 15
				count += 1
				no2 = TreeView1(0).Nodes.Add(no1.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "Item #" & count, 1)
				For i3 = 0 To Rnd() * 10
					count += 1
					no3 = TreeView1(0).Nodes.Add(no2.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "Item #" & count, 1)
				Next
			Next
		Next
		' set properties common to all nodes
		For i1 = 1 To TreeView1(0).Nodes.Count
			TreeView1(0).Nodes(i1).ExpandedImage = 2
		Next
	End Sub

	Private Sub TreeView1_MouseDown(ByRef Index As Short, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
		' check if we are starting a drag operation
		If Button <> 2 Then  Exit Sub
		' set the node being dragged, exit if there is none
		SourceNode = TreeView1(Index).HitTest(x, y)
		If SourceNode Is Nothing Then  Exit Sub
		
		' save values for later
		SourceTreeView = TreeView1(Index)
		ShiftState = Shift
		' start the drag operation
		TreeView1(Index).OLEDrag()
	End Sub

	Private Sub TreeView1_OLEStartDrag(ByRef Index As Short, ByRef Data As VB6DataObject, ByRef AllowedEffects As Integer)
		' pass the Key property of the Node being dragged
		' (this value is not used, we can actually pass anything)
		Data.SetData(SourceNode.Key)
		If ShiftState And VBRUN.ShiftConstants.vbCtrlMask Then 
			AllowedEffects = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
		Else
			AllowedEffects = VBRUN.OLEDropEffectConstants.vbDropEffectMove
		End If
	End Sub

	Private Sub TreeView1_OLEDragOver(ByRef Index As Short, ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single, ByRef State As Short)
		' highlight the Node the mouse is over
		' UPGRADE_WARNING (#1634): The DropHighlight property retains its value between calls but otherwise has no effect on the user interface
		TreeView1(Index).DropHighlight = TreeView1(Index).HitTest(x, y)
	End Sub

	Private Sub TreeView1_OLEDragDrop(ByRef Index As Short, ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
		Dim dest As VB6Node = Nothing
		Dim nd As VB6Node = Nothing
		' get the target of the operation
		' UPGRADE_WARNING (#1634): The DropHighlight property retains its value between calls but otherwise has no effect on the user interface
		dest = TreeView1(Index).DropHighlight
		
		If dest Is Nothing Then 
			' add the node as the root of the target treeview
			nd = TreeView1(Index).Nodes.Add(, , , SourceNode.Text, SourceNode.Image)
		Else
			
			' check that the destination node isn't a descendent of the source node
			If SourceTreeView Is TreeView1(Index) Then 
				nd = dest
				Do
					If nd Is SourceNode Then 
						MsgBox6("Unable to drag nodes here", MsgBoxStyle.Exclamation)
						Exit Sub
					End If
					nd = nd.Parent
				Loop Until nd Is Nothing
			End If
			nd = TreeView1(Index).Nodes.Add(dest.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , SourceNode.Text, SourceNode.Image)
		End If
		nd.ExpandedImage = 2
		nd.Expanded = True
		
		CopySubTree(SourceTreeView, SourceNode, TreeView1(Index), nd)
		' if this is a move operation, delete the source subtree
		If Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
			SourceTreeView.Nodes.Remove(SourceNode.Index)
		End If
		' UPGRADE_WARNING (#1634): The DropHighlight property retains its value between calls but otherwise has no effect on the user interface
		TreeView1(Index).DropHighlight = Nothing
	End Sub

End Class
