' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmTextBox

	Private Sub Form_Load() Handles MyBase.Load
		Text1.Text = "You can enter any text in this multiline TextBox control " & "and the you can click on any button on the right to see " & "how you can use the SendMessage function to retrieve " & "information that isn't accessible through the regular " & "properties of the control." & ControlChars.CrLf & "Here is another paragraph of text, which is " & "separated from the previous one using a CR-LF " & "character pair." & ControlChars.CrLf & ControlChars.Tab & "A line with one leading tab stop." & ControlChars.CrLf & ControlChars.Tab & ControlChars.Tab & "A line with two leading tab stops." & ControlChars.CrLf & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "A line with three leading tab stops."
		SetTabStopDistance(Text1, 10)
	End Sub

	Private Sub cmdUndo_Click() Handles cmdUndo.Click
		If CanUndo(Text1) Then 
			Undo(Text1)
		Else
			MsgBox6("Nothing to undo!", MsgBoxStyle.Exclamation)
		End If
		Text1.SetFocus()
	End Sub

	Private Sub cmdLineCount_Click() Handles cmdLineCount.Click
		MsgBox6("GetLineCount = " & GetLineCount(Text1), MsgBoxStyle.Information)
		Text1.SetFocus()
	End Sub

	Private Sub cmdFirstLine_Click() Handles cmdFirstLine.Click
		MsgBox6("GetFirstVisibleLine = " & GetFirstVisibleLine(Text1))
		Text1.SetFocus()
	End Sub

	Private Sub cmdCaretPos_Click() Handles cmdCaretPos.Click
		Dim line As Integer
		Dim column As Integer
		GetLineColumn(Text1, -1, line, column)
		MsgBox6("Caret Line = " & line & ", Caret Column = " & column, MsgBoxStyle.Information)
		Text1.SetFocus()
	End Sub

	Private Sub cmdCaretLine_Click() Handles cmdCaretLine.Click
		Dim line As Integer
		' Get the caret line.
		GetLineColumn(Text1, -1, line, 0)
		' Extract the line text.
		MsgBox6("Text of Caret Line = """ & GetLine(Text1, line) & """")
		Text1.SetFocus()
	End Sub

	Private Sub cmdGetAllLines_Click() Handles cmdGetAllLines.Click
		Dim result() As String
		Dim msg As String = ""
		Dim i As Integer
		result = GetAllLines(Text1, True)
		' Build the result
		For i = 0 To UBound6(result)
			msg = msg & result(i) & ControlChars.CrLf
		Next
		MsgBox6(msg, MsgBoxStyle.Information)
		Text1.SetFocus()
	End Sub

	Private Sub cmdShrinkRect_Click() Handles cmdShrinkRect.Click
		Dim Left As Integer
		Dim Top As Integer
		Dim Right As Integer
		Dim Bottom As Integer
		' Get the formatting rectangle.
		GetRect(Text1, Left, Top, Right, Bottom)
		' Shrink it.
		Left += 10
		Top += 10
		Right -= 10
		Bottom -= 10
		' Enforce the new values.
		SetRect(Text1, Left, Top, Right, Bottom)
		Text1.SetFocus()
	End Sub

	Private Sub cmdEnlargeRect_Click() Handles cmdEnlargeRect.Click
		Dim Left As Integer
		Dim Top As Integer
		Dim Right As Integer
		Dim Bottom As Integer
		' Get the formatting rectangle.
		GetRect(Text1, Left, Top, Right, Bottom)
		' Enlarge it.
		Left -= 10
		Top -= 10
		Right += 10
		Bottom += 10
		' Enforce the new values.
		SetRect(Text1, Left, Top, Right, Bottom)
		Text1.SetFocus()
	End Sub

	Private Sub cmdScroll_Click(ByRef Index As Short)
		Select Case Index
		Case 0 ' Up
			LineScroll(Text1, 0, -1)
		Case 1 ' Left
			If Text1.ScrollBars = 2 Then 
				MsgBox6("In this demo program horizonatal scrolling has no effect, because the TextBox's ScrollBars property is set to Vertical", MsgBoxStyle.Information)
			End If
			LineScroll(Text1, -1, 0)
		Case 2 ' Right
			If Text1.ScrollBars = 2 Then 
				MsgBox6("In this demo program horizonatal scrolling has no effect, because the TextBox's ScrollBars property is set to Vertical", MsgBoxStyle.Information)
			End If
			LineScroll(Text1, 1, 0)
		Case 3 ' Down
			LineScroll(Text1, 0, 1)
		End Select
		Text1.SetFocus()
	End Sub

	Private Sub cmdScrollCaret_Click() Handles cmdScrollCaret.Click
		ScrollCaret(Text1)
		Text1.SetFocus()
	End Sub

	Private Sub cmdSetTabStop_Click() Handles cmdSetTabStop.Click
		' UPGRADENOTE: this array had LBound=1, all subsequent references has been fixed
		Dim tabs(2) As Integer
		tabs(0) = 5
		tabs(1) = 15
		tabs(2) = 25
		TextBoxAPI.SetTabStops(Text1, tabs)
		Text1.SetFocus()
	End Sub

End Class
