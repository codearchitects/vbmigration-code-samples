' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmInfo

	Private Sub cmdOK_Click() Handles cmdOk.Click
		Me.Hide()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		Me.lblInfo.Caption = "Version 3.6" & ControlChars.CrLf & ControlChars.CrLf & "Program written by D. Rijmenants" & ControlChars.CrLf & ControlChars.CrLf & "© D. Rijmenants 2006" & ControlChars.CrLf & ControlChars.CrLf & "This program is freeware and can be used and distributed under the following restrictions: It is strictly forbidden to use this software, copies or parts of it for commercial purposes, or to sell, to lease or make profit from this program by any means." & ControlChars.CrLf & ControlChars.CrLf & "For more info read the Help File (F1)."
	End Sub

End Class
