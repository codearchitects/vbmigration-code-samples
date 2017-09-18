' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Amount As CTextBoxNum
	Private WithEvents Percentage As CTextBoxNum
	Private Tax As CTextBoxCalc
	Private GrandTotal As CTextBoxCalc
	
	Private Sub Form_Load() Handles MyBase.Load
		Amount = New CTextBoxNum()
		Amount.TextBox = txtAmount
		Percentage = New CTextBoxNum()
		Percentage.TextBox = txtPercent
		Tax = New CTextBoxCalc()
		Tax.TextBox = txtTax
		GrandTotal = New CTextBoxCalc()
		GrandTotal.TextBox = txtGrandTotal
		
		Amount.FormatMask = "#,###,###"
		Amount.SelectOnEntry = True
		Percentage.FormatMask = "0.00"
		Percentage.IsDecimal = True
		Percentage.SelectOnEntry = True
		' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Min'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'Percentage.Min'. Consider using the SetDefaultMember6 helper method.
		Percentage.Min = 0: ' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Max'. Consider using the GetDefaultMember6 helper method.
		' UPGRADE_WARNING (#0364): Unable to assign default member of symbol 'Percentage.Max'. Consider using the SetDefaultMember6 helper method.
		Percentage.Max = 100
		
		Tax.SetExpression(txtAmount, "*", txtPercent, "/", 100)
		Tax.FormatMask = "#,###,###"
		GrandTotal.SetExpression(txtAmount, "+", txtTax)
		GrandTotal.FormatMask = "#,###,###"
	End Sub

	' These statements aren't in the printed edition of the book.
	
	Private Sub Form_Unload(ByRef Cancel As Short) Handles MyBase.Unload
		Amount = Nothing
		Percentage = Nothing
		Tax = Nothing
		GrandTotal = Nothing
	End Sub

	Private Sub Percentage_ValidateError(ByRef Cancel As Boolean) Handles Percentage.ValidateError
		MsgBox6("Invalid Percentage Value", MsgBoxStyle.Exclamation)
		Cancel = True
	End Sub

End Class
