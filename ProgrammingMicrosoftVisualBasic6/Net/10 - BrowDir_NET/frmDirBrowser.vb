' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDirBrowser

	' True if Cancel was pressed to close this form
	Public CancelPressed As Boolean
	
	Private m_Path As String = ""
	
	' this is used by many routines in the module
	Private FSO As New VB6FileSystemObject
	
	' the Path currently selected
	Public ReadOnly Property Path() As String
	' UPGRADE_INFO (#0501): The 'Path' member isn't used anywhere in current application.
		Get
			Return m_Path
	 	End Get
	End Property

	Private Sub Form_Load() Handles MyBase.Load
		' build the subdirectory tree
		DirRefresh()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		' the distance among controls
		Const DISTANCE As Short = 100
		Dim tvwTop As Single
		
		' move the buttons and the label
		lblPath.Move(DISTANCE, 0, ScaleWidth, lblPath.Height)
		cmdOK.Move(ScaleWidth / 2 - DISTANCE - cmdOK.Width, ScaleHeight - DISTANCE - cmdOK.Height)
		cmdCancel.Move(ScaleWidth / 2 + DISTANCE, cmdOK.Top)
		' resize the treeview control
		' the Top position depends on the visibility of the lblPath label
		If lblPath.Visible Then 
			tvwTop = lblPath.Top + lblPath.Height
		Else
			tvwTop = DISTANCE
		End If
		tvwDir.Move(DISTANCE, tvwTop, ScaleWidth - DISTANCE * 2, ScaleHeight - tvwTop - cmdOK.Height - DISTANCE * 2)
	End Sub

	Private Sub DirRefresh()
		' build the treeview control
		Dim dr As VB6Drive = Nothing
		Dim rootNode As VB6Node = Nothing
		Dim nd As VB6Node = Nothing
		
		On Error Resume Next 
		
		' add the "My Computer" root (expanded)
		rootNode = tvwDir.Nodes.Add(, , "\\MyComputer", "My Computer", 1)
		rootNode.Expanded = True
		
		' add all the drives, with a plus sign
		For Each dr In FSO.Drives
			If dr.Path <> "A:" Then 
				Err.Clear()
				nd = tvwDir.Nodes.Add(rootNode.Key, MSComctlLib.TreeRelationshipConstants.tvwChild, dr.Path & "\", dr.Path & " " & dr.VolumeName, 2)
				If Err.Number = 0 Then  AddDummyChild(nd)
			End If
		Next
		
	End Sub

	Public Sub AddDummyChild(ByRef nd As VB6Node)
	' UPGRADE_INFO (#0551): The 'nd' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' add a dummy child node, if necessary
		If nd.Children = 0 Then 
			' dummy nodes' Text property is "***"
			tvwDir.Nodes.Add(nd.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "***")
		End If
	End Sub

	Private Sub tvwDir_Click() Handles tvwDir.Click
		m_Path = tvwDir.SelectedItem.Key
		lblPath.Caption = tvwDir.SelectedItem.Key
	End Sub

	Private Sub tvwDir_Expand(ByVal node As VB6Node) Handles tvwDir.Expand
		' a node if being expanded
		' UPGRADE_INFO (#0501): The 'nd' member isn't used anywhere in current application.
		Dim nd As VB6Node = Nothing
		' exit if the node had been already expanded in the past
		If node.Children = 0 Or node.Children > 1 Then  Exit Sub
		' also exit if it doesn't have a dummy child node
		If node.Child.Text <> "***" Then  Exit Sub
		' remove the dummy child item
		tvwDir.Nodes.Remove(node.Child.Index)
		' add all the subdirs of this Node object
		AddSubdirs(node)
	End Sub

	Private Sub AddSubdirs(ByVal node As VB6Node)
		' add all the subdirs under a node
		Dim fld As VB6Folder = Nothing
		Dim nd As VB6Node = Nothing
		
		' we need this to work around Permission Denied errors
		On Error Resume Next 
		
		' the path in the node is hold in its key property
		' cycle on all its subdirectories
		For Each fld In FSO.GetFolder(node.Key).SubFolders
			nd = tvwDir.Nodes.Add(node, MSComctlLib.TreeRelationshipConstants.tvwChild, fld.Path, fld.Name, 3)
			nd.ExpandedImage = 4
			' if this directory has subfolders, add a "+" sign
			If fld.SubFolders.Count = 0 Then 
				' either no subfolders or permission denied errors
			Else
				AddDummyChild(nd)
			End If
		Next
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		CancelPressed = True
		Unload6(Me)
	End Sub

End Class
