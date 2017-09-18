' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class CTextBoxNum

	#Region "Constructor"
	
	'A public default constructor
	Public Sub New()
		' Add initialization code here
	End Sub
	
	#End Region
	
	'----------------------------------------------
	' The CTextBoxNum Class module
	'----------------------------------------------

	Public Event ValidateError(ByRef Cancel As Boolean)
	
	Public WithEvents TextBox As VB6TextBox
	Public IsDecimal As Boolean
	Public FormatMask As String = ""
	Public SelectOnEntry As Boolean
	Public Min As Object
	Public Max As Object
	
	Private Sub TextBox_KeyPress(ByRef KeyAscii As Short) Handles TextBox.KeyPress
		Select Case KeyAscii
		Case 0 To 31 ' accept control chars
		Case 48 To 57 ' accept digits
		Case Asc(Format6(0.1, "."))
			If Not IsDecimal Then  KeyAscii = 0
		Case Else
			KeyAscii = 0 ' reject anything else
		End Select
	End Sub

	' filter off all non-numeric characters on entry
	
	Private Sub TextBox_GotFocus() Handles TextBox.GotFocus
		TextBox.Text = FilterNumber(TextBox.Text, True)
		If SelectOnEntry Then 
			TextBox.SelStart = 0: TextBox.SelLength = 9999
		End If
	End Sub

	' format the number when the focus leaves the control
	
	Private Sub TextBox_LostFocus() Handles TextBox.LostFocus
		If Len6(FormatMask) Then 
			TextBox.Text = Format6(TextBox.Text, FormatMask)
		End If
	End Sub

	Private Sub TextBox_Validate(ByRef Cancel As Boolean) Handles TextBox.Validate
		If Not IsEmpty6(Min) Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Min'. Consider using the GetDefaultMember6 helper method.
			If CDbl(TextBox.Text) < Min Then  RaiseEvent ValidateError(Cancel)
		End If
		If Not IsEmpty6(Max) Then 
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'Max'. Consider using the GetDefaultMember6 helper method.
			If CDbl(TextBox.Text) > Max Then  RaiseEvent ValidateError(Cancel)
		End If
	End Sub

	' private functions (from chapter 02)
	
	Private Function FilterString(ByRef Text As String, ByRef ValidChars As String) As String
	' UPGRADE_INFO (#0551): The 'Text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'ValidChars' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim i As Integer
		Dim result As String = ""
		For i = 1 To Len6(Text)
			If InStr(ValidChars, Mid(Text, i, 1)) Then 
				result &= Mid(Text, i, 1)
			End If
		Next
		Return result
	End Function

	Private Function FilterNumber(ByRef Text As String, ByRef TrimZeroes As Boolean) As String
	' UPGRADE_INFO (#0551): The 'Text' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
	' UPGRADE_INFO (#0551): The 'TrimZeroes' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim decSep As String = ""
		Dim i As Integer
		Dim result As String = ""
		' retrieve the decimal separator symbol
		decSep = Format6(0.1, ".")
		' use FilterString for most of the work
		result = FilterString(Text, decSep & "-0123456789")
		' only if there is a decimal part and the
		' user requested to trim non-significant digits
		If TrimZeroes And InStr(Text, decSep) > 0 Then 
			For i = Len6(result) To 1 Step -1
				Select Case Mid(result, i, 1)
				Case decSep
					result = VB.Left(result, i - 1)
					Exit For
				Case "0"
					result = VB.Left(result, i - 1)
				Case Else
					Exit For
				End Select
			Next
		End If
		Return result
	End Function

End Class
