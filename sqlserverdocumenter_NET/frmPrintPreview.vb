' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmPrintPreview

	Private Sub cmdClose_Click() Handles cmdClose.Click
		
		Unload6(Me)
		
	End Sub

	Private Sub cmdPrint_Click() Handles cmdPrint.Click
		
		wbrPrintPreview.ExecWB(SHDocVwCtl.OLECMDID.OLECMDID_PRINT, SHDocVwCtl.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
		
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		
		Center(Me)
		
		wbrPrintPreview.Navigate(App6.Path & "\tmpprt.dat")
		
	End Sub

End Class
