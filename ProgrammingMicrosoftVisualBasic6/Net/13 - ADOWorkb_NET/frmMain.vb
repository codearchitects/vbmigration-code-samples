' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub cmdCreateConnection_Click() Handles cmdCreateConnection.Click
		Dim frm As New frmConnection
		frm.cn = New ADODB.Connection()
		frm.Show(, Me)
	End Sub

	Private Sub cmdCreateRecordset_Click() Handles cmdCreateRecordset.Click
		Dim frm As New frmRecordset
		frm.rs = New ADODB.Recordset()
		frm.Show(, Me)
	End Sub

	Private Sub cmdCreateCommand_Click() Handles cmdCreateCommand.Click
		Dim frm As New frmCommand
		frm.cmd = New ADODB.Command()
		frm.Show(, Me)
	End Sub

End Class
