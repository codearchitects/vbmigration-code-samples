' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

#Region "Global migration warnings"

' UPGRADE_INFO (#0571): The 'DAO' type library is never used in current project. Consider deleting it from VB6 project references.

#End Region

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' Return the maximum size of each callback field.
	
	' UPGRADE_ISSUE (#18A8): The FormatSize event isn't supported.
	Private Sub DTPicker5_FormatSize(ByVal CallbackField As String, ByRef Size As Short) Handles DTPicker5.FormatSize
		Select Case CallbackField
		Case "XX"
			' The number of weeks since January 1st (max 2 digits)
			Size = 2
		Case "XXX"
			' The name of a holiday, if any
			Size = 12
		End Select
	End Sub

	Private Sub DTPicker5_Format(ByVal CallbackField As String, ByRef FormattedString As String) Handles DTPicker5.FormatEvent6
		Select Case CallbackField
		Case "XX"
			' The number of weeks since January 1st (max 3 digits)
			FormattedString = DateDiff("ww", DateSerial(DTPicker5.Year, 1, 1), DTPicker5.Value) + 1
		Case "XXX"
			' The name of a holiday, if any
			If DTPicker5.Month = 12 And DTPicker5.Day = 25 Then 
				FormattedString = "Christmas"
			Else
				' Deal here with other holidays.
			End If
		End Select
	End Sub

	' Move to the previous/next week when the Up/Down key is pressed.
	
	' UPGRADE_ISSUE (#1888): The CallbackKeyDown event isn't supported.
	Private Sub DTPicker5_CallbackKeyDown(ByVal KeyCode As Short, ByVal Shift As Short, ByVal CallbackField As String, ByRef CallbackDate As Date) Handles DTPicker5.CallbackKeyDown
		If CallbackField = "XX" Then 
			If KeyCode = VBRUN.KeyCodeConstants.vbKeyUp Then 
				CallbackDate = DoubleToDate6(DTPicker5.Value + 7)
			ElseIf KeyCode = VBRUN.KeyCodeConstants.vbKeyDown Then 
				CallbackDate = DoubleToDate6(DTPicker5.Value - 7)
			End If
		Else
			' no keyboard support for the Holiday field
		End If
	End Sub

End Class
