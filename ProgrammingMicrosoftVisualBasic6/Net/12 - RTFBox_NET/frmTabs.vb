' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmTabs

	Public CancelPressed As Boolean
	
	Private Sub cmdOK_Click() Handles cmdOK.Click
		CancelPressed = False
		Hide()
	End Sub

	Private Sub cmdcancel_Click() Handles cmdCancel.Click
		CancelPressed = True
		Hide()
	End Sub

	Private Sub txtTab_Change() Handles txtTab.Change
		cmdSet.Enabled = Len6(txtTab.Text)
	End Sub

	Private Sub lstTabs_Click() Handles lstTabs.Click
		txtTab.Text = lstTabs.Text
		cmdDelete.Enabled = True
		cmdDeleteAll.Enabled = True
	End Sub

	Private Sub cmdSet_Click() Handles cmdSet.Click
		If Len6(txtTab.Text) = 0 Then  Exit Sub
		
		Dim i As Short
		For i = 0 To lstTabs.ListCount - 1
			If Int(lstTabs.List(i)) = Int(txtTab.Text) Then 
				' This item is already in the list, nothing else to do.
				txtTab.Text = ""
				Exit Sub
			ElseIf Int(lstTabs.List(i)) > Int(txtTab.Text) Then 
				' We've found the right position for this item.
				lstTabs.AddItem(Int(txtTab.Text), i)
				txtTab.Text = ""
				Exit Sub
			End If
		Next
		' If flow gets here, this item has to be appended to the list.
		lstTabs.AddItem(Int(txtTab.Text))
		txtTab.Text = ""
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		If lstTabs.ListIndex <> -1 Then 
			lstTabs.RemoveItem(lstTabs.ListIndex)
		End If
		txtTab.Text = ""
	End Sub

	Private Sub cmdDeleteAll_Click() Handles cmdDeleteAll.Click
		lstTabs.Clear()
		txtTab.Text = ""
	End Sub

End Class
