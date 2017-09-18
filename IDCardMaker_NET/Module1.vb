' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module Module1

	' UPGRADE_INFO (#0501): The 'ShellExecute' member isn't used anywhere in current application.
	Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	' UPGRADE_INFO (#0501): The 'SW_NORMAL' member isn't used anywhere in current application.
	Public Const SW_NORMAL As Short = 1
	Public PicX As Integer
	Public PicY As Integer

End Module
