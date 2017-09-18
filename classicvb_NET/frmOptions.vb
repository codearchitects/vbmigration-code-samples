' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmOptions

	Private Sub cmdApply_Click() Handles cmdApply.Click
		'ToDo: Add 'cmdApply_Click' code.
		MsgBox6("Apply Code goes here to set options w/o closing dialog!")
	End Sub

	Private Sub cmdCancel_Click() Handles cmdCancel.Click
		Unload6(Me)
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		'ToDo: Add 'cmdOK_Click' code.
		MsgBox6("Code goes here to set options and close dialog!")
		Unload6(Me)
	End Sub

	Private Sub Form_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short) Handles MyBase.KeyDown
		Dim i As Short = tbsOptions.SelectedItem.Index
		'handle ctrl+tab to move to the next tab
		If (Shift And 3) = 2 And KeyCode = VBRUN.KeyCodeConstants.vbKeyTab Then 
			If i = tbsOptions.Tabs.Count Then 
				'last tab so we need to wrap to tab 1
				tbsOptions.SelectedItem = tbsOptions.Tabs(1)
			Else
				'increment the tab
				tbsOptions.SelectedItem = tbsOptions.Tabs(i + 1)
			End If
		ElseIf (Shift And 3) = 3 And KeyCode = VBRUN.KeyCodeConstants.vbKeyTab Then 
			If i = 1 Then 
				'last tab so we need to wrap to tab 1
				tbsOptions.SelectedItem = tbsOptions.Tabs(tbsOptions.Tabs.Count)
			Else
				'increment the tab
				tbsOptions.SelectedItem = tbsOptions.Tabs(i - 1)
			End If
		End If
	End Sub

	Private Sub tbsOptions_Click() Handles tbsOptions.Click

		Dim i As Short
		'show and enable the selected tab's controls
		'and hide and disable all others
		For i = 0 To tbsOptions.Tabs.Count - 1
			If i = tbsOptions.SelectedItem.Index - 1 Then 
				picOptions(i).Left = 210
				picOptions(i).Enabled = True
			Else
				picOptions(i).Left = -20000
				picOptions(i).Enabled = False
			End If
		Next

	End Sub

End Class
