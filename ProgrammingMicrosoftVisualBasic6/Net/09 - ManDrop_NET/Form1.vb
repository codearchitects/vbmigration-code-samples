' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Sub cmdBrowse_Click() Handles cmdBrowse.Click
		' load a file into the RTFbox control
		' you can read the same result using drag and drop from
		' an external program (its OLEDropMode is set to automatic)
		With CommonDialog1
			.Filter = "All files|*.*|Text Files (*.txt;*.doc;*.rtf)|*.txt;*.doc;*.rtf"
			.FilterIndex = 2
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
			.DialogTitle = "Select a text file"
			.FileName = ""
			.ShowOpen()
			If .FileName <> "" Then 
				rtfText.LoadFile(.FileName)
			End If
		End With
	End Sub

	Private Sub rtfText_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single, ByRef State As Short) Handles rtfText.OLEDragOver
		' prepare to receive text or a filename
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFText) Or Data.GetFormat(VBRUN.ClipBoardConstants.vbCFRTF) Or Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			If Effect And VBRUN.OLEDropEffectConstants.vbDropEffectCopy Then 
				Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
			ElseIf Effect And VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
				Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove
			End If
		End If
	End Sub

	Private Sub rtfText_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles rtfText.OLEDragDrop
		If Data.GetFormat(VBRUN.ClipBoardConstants.vbCFText) Then 
			rtfText.SelText = Data.GetData(VBRUN.ClipBoardConstants.vbCFText)
		ElseIf Data.GetFormat(VBRUN.ClipBoardConstants.vbCFRTF) Then 
			rtfText.SelRtf = Data.GetData(VBRUN.ClipBoardConstants.vbCFRTF)
		ElseIf Data.GetFormat(VBRUN.ClipBoardConstants.vbCFFiles) Then 
			FileOpen6(1, Data.Files(1), OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
			rtfText.SelText = FileInputString6(1, LOF6(1))
			FileClose6(1)
		End If
	End Sub

	Private Sub rtfText_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles rtfText.MouseDown
		' start a drag operation if right button is pressed
		If Button = 2 Then  rtfText.OLEDrag()
	End Sub

	Private Sub rtfText_OLEStartDrag(ByRef Data As VB6DataObject, ByRef AllowedEffects As Integer) Handles rtfText.OLEStartDrag
		' use selected text, or all text if no text is currently
		If chkLoadOnDemand.Value Then 
			' just inform which format this control supports
			Data.SetData(, VBRUN.ClipBoardConstants.vbCFRTF)
			Data.SetData(, VBRUN.ClipBoardConstants.vbCFText)
		ElseIf rtfText.SelLength Then 
			Data.SetData(rtfText.SelRtf, VBRUN.ClipBoardConstants.vbCFRTF)
			Data.SetData(rtfText.SelText, VBRUN.ClipBoardConstants.vbCFText)
		Else
			Data.SetData(rtfText.TextRTF, VBRUN.ClipBoardConstants.vbCFRTF)
			Data.SetData(rtfText.Text, VBRUN.ClipBoardConstants.vbCFText)
		End If
		AllowedEffects = VBRUN.OLEDropEffectConstants.vbDropEffectMove Or VBRUN.OLEDropEffectConstants.vbDropEffectCopy
	End Sub

	Private Sub lstWords_OLEDragOver(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single, ByRef State As Short) Handles lstWords.OLEDragOver
		' select Copy action if possible, otherwise select Move
		If Not Data.GetFormat(VBRUN.ClipBoardConstants.vbCFText) Then 
			' source control doesn't export Text format
			Effect = 0
		ElseIf Effect And VBRUN.OLEDropEffectConstants.vbDropEffectCopy Then 
			Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
		ElseIf Effect And VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
			Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove
		End If
		' as a demonstation, change the background of this listbox when
		' the mouse is over it
		If State = VBRUN.DragOverConstants.vbLeave Then 
			' restore back color on exit
			lstWords.BackColor = SystemColors.Window 
		ElseIf Effect <> 0 And State = VBRUN.DragOverConstants.vbEnter Then 
			' change back color on entry
			lstWords.BackColor = Color.Yellow 
		End If
	End Sub

	Private Sub lstWords_OLEGiveFeedback(ByRef Effect As Integer, ByRef DefaultCursors As Boolean) Handles lstWords.OLEGiveFeedback
		' if effect is Copy, use a custom cursor
		If Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy Then 
			DefaultCursors = False
			' UPGRADE_ISSUE (#80F8): The Screen6.MousePointer property returns the MousePointer property of the active form, but only if it's a VB6Form. Assignments to it throw an exception.
			Screen6.MousePointer = VBRUN.MousePointerConstants.vbCustom
			' UPGRADE_ISSUE (#8108): The MouseIcon property always returns Nothing. Assignments to it throw an exception.
			Screen6.MouseIcon = imgCopy.Picture
		Else
			DefaultCursors = True
		End If
	End Sub

	Private Sub lstWords_OLEDragDrop(ByRef Data As VB6DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single) Handles lstWords.OLEDragDrop
		' restore the correct background color
		lstWords.BackColor = SystemColors.Window 
		
		' select Copy action if possible, otherwise select Move
		If Effect And VBRUN.OLEDropEffectConstants.vbDropEffectCopy Then 
			Effect = VBRUN.OLEDropEffectConstants.vbDropEffectCopy
		ElseIf Effect And VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
			Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove
		End If
		
		' in either case, ask for the data - only plain text is supported
		Dim text As String = ""
		Dim w As Object = Nothing
		text = Data.GetData(VBRUN.ClipBoardConstants.vbCFText)
		' add a trailing space to ensure that the last word is extracted correctly
		text &= " "
		
		' parse the text and extract individual words
		Dim i As Integer
		Dim start As Integer
		Dim words As New Collection
		On Error Resume Next 
		
		For i = 1 To Len6(text)
			If Mid(text, i, 1) Like "[!A-Za-z0-9]" Then 
				' it is a separator, if we were inside a word we
				' can extract it
				If start Then 
					' add this word to the collection, but ignore duplicates
					w = Mid(text, start, i - start)
					words.Add(w, w)
					start = 0
				End If
			ElseIf start = 0 Then 
				' we have found the start of a new word
				start = i
			End If
		Next
		
		' add all the words to the ListBox control
		lstWords.Clear()
		For Each w In words
			lstWords.AddItem(w)
		Next
		
	End Sub

	Private Sub rtfText_OLESetData(ByRef Data As VB6DataObject, ByRef DataFormat As Short) Handles rtfText.OLESetData
		' this event fires only if chkLoadOnDemand is checked, when
		' the target control invokes the Data's GetData method
		If DataFormat = VBRUN.ClipBoardConstants.vbCFText Then 
			If rtfText.SelLength Then 
				Data.SetData(rtfText.SelText, VBRUN.ClipBoardConstants.vbCFText)
			Else
				Data.SetData(rtfText.Text, VBRUN.ClipBoardConstants.vbCFText)
			End If
		ElseIf DataFormat = VBRUN.ClipBoardConstants.vbCFRTF Then 
			If rtfText.SelLength Then 
				Data.SetData(rtfText.SelRtf, VBRUN.ClipBoardConstants.vbCFRTF)
			Else
				Data.SetData(rtfText.TextRTF, VBRUN.ClipBoardConstants.vbCFRTF)
			End If
		End If
		
	End Sub

	Private Sub rtfText_OLECompleteDrag(ByRef Effect As Integer) Handles rtfText.OLECompleteDrag
		If Effect = VBRUN.OLEDropEffectConstants.vbDropEffectMove Then 
			' if this was a Move operation, delete the highlighted text, if any
			rtfText.SelText = ""
		Else
			' if it was a Copy command, just clear the selection
			rtfText.SelLength = 0
		End If
	End Sub

End Class
