' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub Form_Load() Handles MyBase.Load
		Label1.Caption = "Move and resize this form at will, then click on the Save Settings button." & "The form will automatically restore these settings when you reload it " & "or when you click on the Restore Setting button."
		' Restore settings at form load.
		LoadFormSettings("DemoRegFunctions", Me)
	End Sub

	Private Sub cmdSaveSettings_Click() Handles cmdSaveSettings.Click
		SaveFormSettings("DemoRegFunctions", Me)
	End Sub

	Private Sub cmdRestoreSettings_Click() Handles cmdRestoreSettings.Click
		LoadFormSettings("DemoRegFunctions", Me)
	End Sub

	Private Sub cmdDeleteSettings_Click() Handles cmdDeleteSettings.Click
		DeleteFormSettings("DemoRegFunctions", Me)
	End Sub

End Class
