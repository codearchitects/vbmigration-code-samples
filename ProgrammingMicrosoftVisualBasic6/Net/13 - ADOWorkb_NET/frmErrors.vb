' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmErrors

	Public cn As ADODB.Connection
	
	Private Sub cmdRefresh_Click() Handles cmdRefresh.Click
		RefreshErrors()
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		RefreshErrors()
	End Sub

	Public Sub RefreshErrors()
		Dim [error] As ADODB.Error = Nothing
		Dim tmp As String = ""
		
		For Each [error] In cn.Errors
			tmp = tmp & [error].NativeError & " """ & [error].Description & """ (" & [error].Source & ")" & ControlChars.CrLf
		Next
		txtErrors.Text = tmp
		txtErrors.SelStart = 0
	End Sub

End Class
