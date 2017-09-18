' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub Form_Load() Handles MyBase.Load
		Dim i As Integer
		' load a list of names
		For i = 1 To 12
			lstLeft.AddItem(Choose(i, "Black", "Blue", "Green", "Red", "Orange", "Yellow", "White", "Gray", "Brown", "Cyan", "Magenta", "Pink"))
		Next
		SetButtonState()
	End Sub

	Private Sub cmdMove_Click() Handles cmdMove.Click
		' move one item from left to right
		' two different behavior, for regular or multiselect listboxes
		Dim i As Integer
		If lstLeft.MultiSelect = False Or lstLeft.SelCount = 0 Then 
			' single selection listbox
			If lstLeft.ListIndex >= 0 Then 
				lstRight.AddItem(lstLeft.Text)
				lstLeft.RemoveItem(lstLeft.ListIndex)
			End If
		Else
			' multiple selection listbox
			' note how we advance the counter
			Do While i < lstLeft.ListCount
				If lstLeft.Selected(i) Then 
					lstRight.AddItem(lstLeft.List(i))
					lstLeft.RemoveItem(i)
				Else
					i += 1
				End If
			Loop
		End If
		SetButtonState()
	End Sub

	Private Sub cmdMoveAll_Click() Handles cmdMoveAll.Click
		' move all items from left to right
		Do While lstLeft.ListCount
			lstRight.AddItem(lstLeft.List(0))
			lstLeft.RemoveItem(0)
		Loop
		SetButtonState()
	End Sub

	Private Sub cmdBack_Click() Handles cmdBack.Click
		' move one item from right to left
		' two different behavior, for regular or multiselect listboxes
		Dim i As Integer
		If lstLeft.MultiSelect = False Or lstRight.SelCount = 0 Then 
			' single selection listbox
			If lstRight.ListIndex >= 0 Then 
				' single selection listbox
				lstLeft.AddItem(lstRight.Text)
				lstRight.RemoveItem(lstRight.ListIndex)
			End If
		Else
			' multiple selection listbox
			' note how we advance the counter
			Do While i < lstRight.ListCount
				If lstRight.Selected(i) Then 
					lstLeft.AddItem(lstRight.List(i))
					lstRight.RemoveItem(i)
				Else
					i += 1
				End If
			Loop
		End If
		SetButtonState()
	End Sub

	Private Sub cmdBackAll_Click() Handles cmdBackAll.Click
		' move all items from right to left
		Do While lstRight.ListCount
			lstLeft.AddItem(lstRight.List(0))
			lstRight.RemoveItem(0)
		Loop
		SetButtonState()
	End Sub

	Private Sub lstLeft_Click() Handles lstLeft.Click
		SetButtonState()
	End Sub

	Private Sub lstLeft_DblClick() Handles lstLeft.DblClick
		' simulate a click on the button
		cmdMove.Value = True
	End Sub

	Private Sub lstRight_Click() Handles lstRight.Click
		SetButtonState()
	End Sub

	Private Sub lstRight_DblClick() Handles lstRight.DblClick
		' simulate a click on the button
		cmdBack.Value = True
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Private Sub SetButtonState()
		' set enabled state for all buttons
		' this code accounts for both regular and multiselect listboxes
		cmdMove.Enabled = (lstLeft.ListCount > 0 And lstLeft.ListIndex <> -1 Or lstLeft.SelCount > 0)
		cmdMoveAll.Enabled = (lstLeft.ListCount > 0)
		cmdBack.Enabled = (lstRight.ListCount > 0 And lstRight.ListIndex <> -1 Or lstRight.SelCount > 0)
		cmdBackAll.Enabled = (lstRight.ListCount > 0)
	End Sub

End Class
