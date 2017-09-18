' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmQuick

	Private pblnQuickChanged As Boolean
	Private Sub cmdClipBoard_Click() Handles cmdClipBoard.Click
		'copy clipboard to textbox
		Dim rtv As Short
		If pblnQuickChanged = True Then 
			rtv = MsgBox6("Do You want to delete the current text?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, " Get Clipboard")
			If rtv = MsgBoxResult.No Then  Exit Sub
		End If
		On Error Resume Next 
		Me.txtQuick.Text = Clipboard6.GetText()
	End Sub

	Private Sub cmdClose_Click() Handles cmdClose.Click
		Me.Hide()
	End Sub

	Private Sub Form_Activate() Handles MyBase.Activate
		Me.txtQuick.SetFocus()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		'init combo box speeds
		Me.cmbSpeed.AddItem("Slow")
		Me.cmbSpeed.AddItem("Normal")
		Me.cmbSpeed.AddItem("Fast")
		Me.cmbSpeed.ListIndex = 1
	End Sub

	Private Sub txtQuick_Change() Handles txtQuick.Change
		pblnQuickChanged = True
	End Sub

	Private Sub cmdStart_Click() Handles cmdStart.Click
		Me.Hide()
		Me.Refresh()
		Call AutoTyping()
	End Sub

End Class
