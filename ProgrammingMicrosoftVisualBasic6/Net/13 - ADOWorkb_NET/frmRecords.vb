' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmRecords

	Public rs As ADODB.Recordset
	
	Private Sub Form_Load() Handles MyBase.Load
		On Error Resume Next 
		DataGrid1.DataSource = rs
		If Err.Number Then 
			MsgBox6("Unable to show records." & ControlChars.Cr & ControlChars.Cr & "Error = " & Err.Number & " - " & Err.Description, MsgBoxStyle.Exclamation, "Warning")
			Unload6(Me)
		End If
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		DataGrid1.Move(0, 0, ScaleWidth, ScaleHeight)
	End Sub

End Class
