' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMain

	Private Sub cmdBrowser_Click() Handles cmdBrowser.Click
		On Error Resume Next 
		
		With CommonDialog1
			.CancelError = True
			.FileName = txtFilename.Text
			.Filter = "All files|*.*|Text Files (*.txt)|*.txt"
			.FilterIndex = 2
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
			.ShowOpen()
			If Err.Number = 0 Then 
				txtFilename.Text = .FileName
			End If
		End With
	End Sub

	Private Sub cmdShow_Click() Handles cmdShow.Click
		Dim TextBrowser As New frmTextBrowser
		TextBrowser.Filename = txtFilename.Text
		' show the form, making it a child form of this one
		TextBrowser.Show(, Me)
	End Sub

End Class
