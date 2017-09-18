' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMsgbox
' UPGRADE_INFO (#0501): The 'frmMsgbox' member isn't used anywhere in current application.

	Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Private Const SW_SHOWNORMAL As Short = 1
	
	Private Sub lblOk_Click() Handles lblOk.Click
		'Close this window
		Unload6(Me)
	End Sub

	Private Sub lblVisitPSC_Click() Handles lblVisitPSC.Click
		'Open PSC's page with the default web browser
		ShellExecute(0%, Nothing, "http://www.planet-source-code.com", Nothing, "C:\", SW_SHOWNORMAL)
	End Sub

	Private Sub lblEmail_Click() Handles lblEmail.Click
		'Send me an e-mail
		ShellExecute(0%, Nothing, "mailto:jotaf98@hotmail.com", Nothing, "C:\", SW_SHOWNORMAL)
	End Sub

End Class
