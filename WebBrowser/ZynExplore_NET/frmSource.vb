' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Explicit Off
Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmSource

	Private Sub Command1_Click() Handles Command1.Click
		Unload6(Me)
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		On Error Resume Next 
		'this will view the source
		Dim objDocument As mshtml.HTMLDocument = frmMain.WebBrowser1.Document
		text1.Text = objDocument.body.innerHTML
	End Sub

End Class
