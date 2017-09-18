' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSplash

	Private Sub Form_Load() Handles MyBase.Load
		lblVersion.Caption = "Version " & App6.Major & "." & App6.Minor & "." & App6.Revision
		' UPGRADE_ISSUE (#8018): The Title property isn't fully supported. Reading this property returns the value of Me.Info.Title property. Assignments throws an exception. You can change the text displayed in Windows Task Manager by assigning a new value to the main form's Text property
		lblProductName.Caption = App6.Title
	End Sub

End Class
