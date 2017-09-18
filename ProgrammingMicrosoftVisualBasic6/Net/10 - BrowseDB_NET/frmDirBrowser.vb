' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmDirBrowser

	' WARNING: you may need to modify the DB path in the next line
	Private Const MDBPATH As String = "C:\Program Files\Microsoft Visual Studio\VB98\Biblio.mdb"
	
	Private cn As New ADODB.ConnectionClass
	Private rs As New ADODB.RecordsetClass
	
	Private Sub Form_Load() Handles MyBase.Load
		' Show the database.
		On Error Resume Next 
		cn.Open("Provider=Microsoft.Jet.OLEDB.3.51;Data Source=" & MDBPATH)
		If Err.Number Then 
			MsgBox6("Unable to database " & MDBPATH, MsgBoxStyle.Critical)
			Application.Exit(): End
		End If
		DatabaseRefresh()
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		tvwPublishers.Move(0, 9, ScaleWidth, ScaleHeight)
	End Sub

	Private Sub DatabaseRefresh()
		On Error Resume Next 
		
		' Open the Authors recordset.
		rs.Open("Publishers", cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If Err.Number Then 
			MsgBox6("Unable to open Publishers table", MsgBoxStyle.Critical)
			Application.Exit(): End
		End If
		
		' Build the treeview control.
		Dim rootNode As VB6Node = Nothing
		Dim nd As VB6Node = Nothing
		
		' Add the "Publishers" root (expanded).
		rootNode = tvwPublishers.Nodes.Add(, , "\\Publishers", "Publishers")
		rootNode.Expanded = True
		
		' Add all the publishers, with a plus sign.
		Do Until rs.EOF
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields("Name").Value'. Consider using the GetDefaultMember6 helper method.
			nd = tvwPublishers.Nodes.Add(rootNode.Key, MSComctlLib.TreeRelationshipConstants.tvwChild, , rs.Fields("Name").Value)
			' We can't use PubID as the Key, because it is a number.
			nd.Tag = rs.Fields("PubId").Value
			AddDummyChild(nd)
			rs.MoveNext()
		Loop
		rs.Close()
		
	End Sub

	Public Sub AddDummyChild(ByRef nd As VB6Node)
	' UPGRADE_INFO (#0551): The 'nd' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		' add a dummy child node, if necessary
		If nd.Children = 0 Then 
			' dummy nodes' Text property is "***"
			tvwPublishers.Nodes.Add(nd.Index, MSComctlLib.TreeRelationshipConstants.tvwChild, , "***")
		End If
	End Sub

	Private Sub tvwPublishers_Expand(ByVal node As VB6Node) Handles tvwPublishers.Expand
		' a node if being expanded
		' UPGRADE_INFO (#0501): The 'nd' member isn't used anywhere in current application.
		Dim nd As VB6Node = Nothing
		' exit if the node had been already expanded in the past
		If node.Children = 0 Or node.Children > 1 Then  Exit Sub
		' also exit if it doesn't have a dummy child node
		If node.Child.Text <> "***" Then  Exit Sub
		' remove the dummy child item
		tvwPublishers.Nodes.Remove(node.Child.Index)
		' add all the titles for this Node object
		AddTitles(node)
	End Sub

	Private Sub AddTitles(ByVal node As VB6Node)
		Dim nd As VB6Node = Nothing
		
		' Show all the titles for the expanded publishers.
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'node.Tag'. Consider using the GetDefaultMember6 helper method.
		rs.Open("Select Title From Titles Where PubId = " & node.Tag, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		Do Until rs.EOF
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'rs.Fields("Title").Value'. Consider using the GetDefaultMember6 helper method.
			nd = tvwPublishers.Nodes.Add(node, MSComctlLib.TreeRelationshipConstants.tvwChild, , rs.Fields("Title").Value)
			rs.MoveNext()
		Loop
		rs.Close()
	End Sub

End Class
