' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmLogin

	Public UserName As String = ""
	Public Password As String = ""
	
	Private Sub cmdOK_Click() Handles cmdOK.Click
		' unload this form only if password is OK
		If LCase(txtPassword.Text) = "balena" Then  Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' move property values into form fields
		txtUserName.Text = UserName
		txtPassword.Text = Password
	End Sub

	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		' move field contents back into public properties
		UserName = txtUserName.Text
		Password = txtPassword.Text
	End Sub

	Protected Overrides Sub Form_Initialize_VB6()
		Debug.WriteLine("Initialize event")
	End Sub

	Protected Overrides Sub Form_Terminate_VB6()
		Debug.WriteLine("Terminate event")
	End Sub

End Class
