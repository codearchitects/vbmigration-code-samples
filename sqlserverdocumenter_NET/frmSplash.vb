' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSplash

	Private Sub Form_Load() Handles MyBase.Load
		
		Center(Me)
		lblVersion.Caption = App6.Major & "." & App6.Minor & "." & App6.Revision
		
	End Sub

End Class
