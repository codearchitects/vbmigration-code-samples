' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub cmdShowLogin_Click() Handles cmdShowLogin.Click
		' uncomment next statement to fix the problem
		' Dim frmlogin As New frmlogin
		frmLogin.Show(VBRUN.FormShowConstants.vbModal)
		' execution gets here only if password is OK
		MsgBox6(frmLogin.UserName & " logged in.")
	End Sub

End Class
