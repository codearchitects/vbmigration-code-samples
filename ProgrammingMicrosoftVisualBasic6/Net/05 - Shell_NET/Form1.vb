' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	' the taskId of the shelled Notepad (a module level variable)
	Private taskId As Integer
	
	' load a file name into the txtFileName textbox control
	Private Sub cmdBrowse_Click() Handles cmdBrowse.Click
		With CommonDialog1
			.DialogTitle = "Select a TXT file"
			.Filter = "All files|*.*|Text Files (*.txt)|*.txt"
			.FilterIndex = 2
			.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist
			.ShowOpen()
			txtFilename.Text = .FileName
			If Len6(txtFilename.Text) Then  optContents(1).Value = True
		End With
	End Sub

	' run Notepad with current settings
	Private Sub cmdNotepad_Click() Handles cmdNotepad.Click
		' run Notepad in regular or maximized window
		If optContents(0).Value Then 
			' run Notepad with no file
			taskId = Shell("notepad", IIf(chkMaximized.Value, AppWinStyle.MaximizedFocus, AppWinStyle.NormalFocus))
			' ensure it has the focus, send a Paste command
			AppActivate6(taskId)
			My.Computer.Keyboard.SendKeys("^V", True)
		Else
			' runt Notepad on the selected file
			taskId = Shell("notepad " & txtFilename.Text, IIf(chkMaximized.Value, AppWinStyle.MaximizedFocus, AppWinStyle.NormalFocus))
		End If
		
		If optWait(1).Value Then 
			' activate the timer that will poll for process termination
			Timer1.Interval = 250
		ElseIf optWait(2).Value Then 
			' wait until the process returns
			DoEvents6()
			Do
				' you can do whatever you want while polling Notepad every second
				Beep()
			Loop While WaitForProcess(taskId, 1000)
			' replacing the above line with this one will block the VB program
			' WaitForProcess taskId
		End If
	End Sub

	' check if the process has terminated every 250 ms.
	
	Private Sub Timer1_Timer() Handles Timer1.Timer
		If taskId = 0 Then  Exit Sub
		
		If WaitForProcess(taskId, 0) = False Then 
			' disable the timer
			Timer1.Interval = 0
			taskId = 0
			' inform the user that something happened
			MsgBox6("Notepad has been closed", MsgBoxStyle.Information)
		End If
	End Sub

End Class
