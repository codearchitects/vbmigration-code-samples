' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Module RegistryFunctions

	Public Function SaveFormSettings(ByVal AppName As String, ByVal frm As VB6Form) As Object
	' UPGRADE_INFO (#0561): The 'SaveFormSettings' symbol was defined without an explicit "As" clause.
		SaveSetting(AppName, frm.Name, "Left", frm.Left)
		SaveSetting(AppName, frm.Name, "Top", frm.Top)
		SaveSetting(AppName, frm.Name, "Width", frm.Width)
		SaveSetting(AppName, frm.Name, "Height", frm.Height)
		SaveSetting(AppName, frm.Name, "WindowState", frm.WindowState)
	End Function

	Public Function LoadFormSettings(ByVal AppName As String, ByVal frm As VB6Form) As Object
	' UPGRADE_INFO (#0561): The 'LoadFormSettings' symbol was defined without an explicit "As" clause.
		Dim currWindowState As Short = frm.WindowState
		' If the form is currently maximized or minimized, temporarily
		' revert to normal state, otherwise the Move command fails.
		If currWindowState <> 0 Then  frm.WindowState = 0
		
		' Use a Move method to avoid multiple Resize and Paint events.
		frm.Move(GetSetting(AppName, frm.Name, "Left", frm.Left), GetSetting(AppName, frm.Name, "Top", frm.Top), GetSetting(AppName, frm.Name, "Width", frm.Width), GetSetting(AppName, frm.Name, "Height", frm.Height))
		frm.WindowState = GetSetting(AppName, frm.Name, "WindowState", currWindowState)
	End Function

	' Delete form settings
	
	Public Sub DeleteFormSettings(ByVal AppName As String, ByVal frm As VB6Form)
		DeleteSetting(AppName, frm.Name)
	End Sub

End Module
