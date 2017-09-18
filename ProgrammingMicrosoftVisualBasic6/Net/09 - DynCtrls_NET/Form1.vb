' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private WithEvents TreeView As VB6TreeView
	Private WithEvents TxtEditor As VB6VBControlExtender
	Private Sub cmdAddTreeView_Click() Handles cmdAddTreeView.Click
		' add a TreeView control (note the ProgID of the control)
		' You'll probably need to modify the ProgID if you use a more
		' recent version of MSComCtlLib library
		TreeView = Controls6.Add("MSComctlLib.TreeCtrl.2", "TreeView")
		
		' move and resize it, then make it visible
		TreeView.Move(0, cmdAddTreeView.Height, cmdAddTreeView.Width, ScaleHeight - cmdAddTreeView.Height)
		TreeView.CheckBoxes = True
		TreeView.Visible = True
		
		' add some nodes, just to prove that it is working
		Dim i As Short
		' UPGRADE_INFO (#0501): The 'j' member isn't used anywhere in current application.
		Dim j As Short
		TreeView.Nodes.Add(, , , "Root")
		For i = 1 To 5
			TreeView.Nodes.Add(1, MSComctlLib.TreeRelationshipConstants.tvwChild, , "Child #" & i)
		Next
		TreeView.Nodes(1).Expanded = True
	End Sub

	Private Sub cmdAddEditor_Click() Handles cmdAddEditor.Click
		Dim licenseKey As String = ""
		
		' read the license key from a file created at design time
		' (see the CreateLicenseKey routine)
		''##ParseMode Remarks, 3
		FileOpen6(1, App6.Path & "\MSWLess.key", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		licenseKey = FileLineInput6(1)
		FileClose6(1)
		' add to the Licenses collection
		Licenses6.Add("MSWLess.WLText", licenseKey)
		
		' now it is possible to create the control
		TxtEditor = Controls6.Add("MSWLess.WLText", "TxtEditor")
		TxtEditor.Move(cmdAddEditor.Left, cmdAddEditor.Height, cmdAddEditor.Width, ScaleHeight - cmdAddEditor.Height)
		TxtEditor.Visible = True
		
		' specific (non-Extender) properties must be
		' accessed using the Object extender property
		TxtEditor.Object.MultiLine = True
		TxtEditor.Object.ScrollBars = VBRUN.ScrollBarConstants.vbBoth
		TxtEditor.Object.Text = "(write your text here)"
		
	End Sub

	' ---------------------------
	'   control's events
	' ---------------------------
	
	Private Sub TreeView_NodeClick(ByVal Node As VB6Node) Handles TreeView.NodeClick
		MsgBox6("You clicked node " & Node.Text)
	End Sub

	Private Sub TxtEditor_ObjectEvent(ByRef Info As VB6EventInfo) Handles TxtEditor.ObjectEvent
		Select Case Info.Name
		Case "KeyPress"
			' the Escape key clears the editor
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Info.EventParameters("KeyAscii").Value'. Consider using the GetDefaultMember6 helper method.
			If Info.EventParameters("KeyAscii").Value = 27 Then 
				TxtEditor.Object.Text = ""
			End If
		Case "DblClick"
			' just to prove that we can trap anything
			MsgBox6("Why have you double-clicked me ?")
		End Select
	End Sub

	' note that extender events must be trapped separatedly
	
	Private Sub TxtEditor_GotFocus() Handles TxtEditor.GotFocus
		' highlight contents on entry
		With TxtEditor.Object
			.SelStart = 0
			.SelLength = 9999
		End With
	End Sub

End Class
