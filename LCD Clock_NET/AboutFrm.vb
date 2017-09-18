' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class AboutFrm

	Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Private Function Link(ByVal URL As String) As Integer
		Return ShellExecute(0%, Nothing, URL, Nothing, Nothing, AppWinStyle.NormalFocus)
	End Function
	
	Private Sub Check1_Click() Handles Check1.Click
		MainFrm.ShowAbout = Check1.Value
		MainFrm.SaveSettings()
	End Sub
	
	Private Sub Command1_Click() Handles Command1.Click
		Me.Hide()
	End Sub
	
	Private Sub Label1_Click() Handles Label1.Click
		Call Link(Label1.Caption)
	End Sub

End Class
