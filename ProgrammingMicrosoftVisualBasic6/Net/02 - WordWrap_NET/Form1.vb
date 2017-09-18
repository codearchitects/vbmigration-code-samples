' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Class Form1

	Private Sub Form_Paint() Handles MyBase.Paint
		Dim msg As String = ""
		Dim pos As Integer
		Dim spacePos As Integer
		
		msg = "You often use the TextWidth and TextHeight methods to check if a message can fit within a given area. " & ControlChars.CrLf & "This is especially necessary when you print to a form, because the Print method doesn't support automatic wrapping for longer lines, and you are to solve the problem through code."
		
		Cls()
		Dim tw As Single
		Do While pos < Len6(msg)
			pos += 1
			If Mid(msg, pos, 2) = ControlChars.CrLf Then 
				' we have found a CR-LF pair, print the message
				' up to this point and reset variables
				PrintLine(VB.Left(msg, pos - 1))
				msg = LTrim(Mid(msg, pos + 2))
				pos = 0
				spacePos = 0
			ElseIf Mid(msg, pos, 1) = " " Then 
				' if this is a space, remember its position
				spacePos = pos
			End If
			' check the message width so far
			tw = TextWidth(VB.Left(msg, pos))
			
			If tw > ScaleWidth Then 
				' the message is too long, let's split it
				' if we met a space, split it there
				If spacePos Then  pos = spacePos
				' print the message up to the split point
				PrintLine(VB.Left(msg, pos - 1))
				' discard characters just printed, reset variables
				msg = LTrim(Mid(msg, pos))
				pos = 0
				spacePos = 0
			End If
		Loop
		' print residual characters, if any
		If Len6(msg) Then  PrintLine(msg)
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		Refresh()
	End Sub

End Class
