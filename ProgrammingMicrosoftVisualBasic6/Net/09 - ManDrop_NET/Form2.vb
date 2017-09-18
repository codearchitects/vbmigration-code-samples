' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form2

	' remember separator char among drop actions
	Private sepChar As String = ""
	
	Private Sub cmdSeparator_Click() Handles cmdSeparator.Click
		Dim temp As String = InputBox6("Enter a new separator character. Use ^T for tab, ^N for Newline.", "Command Editor", sepChar)
		Select Case UCase(temp)
		Case ""
		Case "^T"
			sepChar = ControlChars.Tab
		Case "^N"
			sepChar = ControlChars.CrLf
		Case Else
			sepChar = temp
		End Select
	End Sub

	Private Sub txtEditor_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single, ByRef State As Short) Handles txtEditor.OLEDragOver
		' this editor can work as as the target of a drag operation
		' if data is text or file names
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFText) Or Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			' supports either copy or move action
			If Effect And VBRUN.OLEDropEffectConstants.vbDropEffectCopy Then 
				Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
			ElseIf Effect And VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
				Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove
			End If
		Else
			Effect = 0
		End If
	End Sub

	Private Sub txtEditor_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single) Handles txtEditor.OLEDragDrop
		' UPGRADE_INFO (#0501): The 'temp' member isn't used anywhere in current application.
		Dim temp As String = ""
		Dim i As Integer
		Dim text As String = ""
		
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFText) Then 
			' if text is being dropped, just insert it in the proper position
			txtEditor.SelText = Data.GetData(VBRUN.ClipBoardConstants.vbCFText)
		ElseIf Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			If optDropMode(1).Value Then 
				' we are dropping file contents
				FileOpen6(1, Data.Files(1), OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
				txtEditor.SelText = FileInputString6(1, LOF6(1))
				FileClose6(1)
			Else
				' we are dropping file names
				For i = 1 To Data.Files.Count
					If i > 1 Then  text &= IIf(sepChar = "", ControlChars.CrLf, sepChar)
					' if Ctrl key is pressed, use complete path
					' otherwise just use the file name
					If Shift And VBRUN.ShiftConstants.vbCtrlMask Then 
						text &= Data.Files(i)
					Else
						text &= GetFileName(Data.Files(i))
					End If
				Next
				' insert text at the caret position
				txtEditor.SelText = text
			End If
		End If
	End Sub

	' return the base filename+ext, given the complete file name
	
	Private Function GetFileName(ByRef filename As String) As String
	' UPGRADE_INFO (#0551): The 'filename' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Return Mid(filename, InStrRev(filename, "\") + 1)
	End Function

End Class
