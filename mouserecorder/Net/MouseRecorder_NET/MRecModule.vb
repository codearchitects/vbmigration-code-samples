' --------------------------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' --------------------------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Imports VB = Microsoft.VisualBasic

Friend Module MRecModule

	Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
	' UPGRADE_INFO (#0531): You can replace calls to the 'ReleaseCapture' unamanged method with the following .NET member(s): System.Windows.Forms.Control.Capture
	Public Declare Function ReleaseCapture Lib "user32" () As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SendMessage' unamanged method with the following .NET member(s): System.Windows.Forms.Control.DefWndProc, System.Windows.Forms.Control.WndProc, System.Windows.Forms.Form.DefWndProc, System.Windows.Forms.Form.WndProc
	' IGNORED: Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, lParam As Any) As Long
	Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer
	' UPGRADE_INFO (#0531): You can replace calls to the 'SetWindowPos' unamanged method with the following .NET member(s): System.Windows.Forms.Form.BringToFront, System.Windows.Forms.Form.Enabled, System.Windows.Forms.Form.SendToBack, System.Windows.Forms.Form.SetBounds, System.Windows.Forms.Form.TopMost, System.Windows.Forms.Form.Visible
	Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
	
	Public Const rsRecording As String = "Recording"
	Public Const rsPlaying As String = "Playing"
	Public Const rsIdle As String = "Idle"
	
	Public RecorderState As String = ""
	Public MotionData As New Collection
	Public SaveData As Boolean
	
	' Form drag function        '
	Public Sub EasyMove(ByRef frm As VB6Form)
		If frm.WindowState <> VBRUN.FormWindowStateConstants.vbMaximized Then 
			ReleaseCapture()
			SendMessage(frm.hWnd, &HA1, 2, 0%)
		End If
	End Sub

	' Set Window in Foreground 4ever    '
	Public Sub SetWindowInFore(ByRef frm As VB6Form, ByVal SetInFore As Boolean)
		If SetInFore Then 
			'Fenster immer im Vordergrund
			Call SetWindowPos(frm.hWnd, -1, 0, 0, 0, 0, 3)
		Else
			'Fenster im Normalzustand
			Call SetWindowPos(frm.hWnd, -2, 0, 0, 0, 0, 3)
		End If
	End Sub

	' Sleep (Pause in Seconds)      '
	Private Sub Sleep(ByVal Seconds As Double)
		Dim Tmr As Double = Timer6 + Seconds
		Do:: DoEvents6()
		Loop While Tmr > Timer6
	End Sub

	' Start Recording         '
	Public Sub StartRecording()
		If RecorderState = rsPlaying Then  Exit Sub
		If RecorderState = rsRecording Then 
			RecorderState = rsIdle
		Else
			RecorderState = rsRecording
		End If
	End Sub

	' Start Playing           '
	Public Sub StartPlaying()
		If RecorderState = rsRecording Then  Exit Sub
		If RecorderState = rsPlaying Then 
			RecorderState = rsIdle
		Else
			RecorderState = rsPlaying
		End If
	End Sub

	' Application path    '
	Public Function ApplPath() As String
		Dim Temp As String = App6.Path
		If VB.Right(Temp, 1) <> "\" Then  Temp = Temp & "\"
		Return Temp
	End Function

	' Add new Motion      '
	Public Sub AddMotion(ByRef x As Integer, ByRef y As Integer, ByRef T As Double, ByRef A As String)
		MotionData.Add(A & "," & x & "," & y & "," & T)
		SaveData = True
	End Sub

	Public Sub SaveDataToFile()
		Dim FName As String = ""
		Dim ff As Integer
		Dim i As Integer
		Dim DNSF As Boolean
		If SaveData And MotionData.Count() Then 
			frmMain.comDlg.FileName = ""
			frmMain.comDlg.ShowSave
			' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'frmMain.comDlg.FileName'. Consider using the GetDefaultMember6 helper method.
			FName = frmMain.comDlg.FileName
			If Len6(Dir6(FName)) Then 
				If MsgBox6("File already exists. Do you want to overwrite old File?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save anyway?") = MsgBoxResult.No Then  DNSF = True
			End If
			If Not DNSF Then 
				On  Error Resume Next 
				ff = FreeFile6()
				FileOpen6(ff, FName, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
				FilePrintLine6(ff, "[MouseMotionFile]")
				For i = 1 To MotionData.Count()
					If Err.Number Then  Exit For
					' UPGRADE_WARNING (#0354): Unable to read default member of symbol 'MotionData.Item(i)'. Consider using the GetDefaultMember6 helper method.
					FilePrintLine6(ff, MotionData.Item(i))
				Next
				If Err.Number Then 
					Err.Clear()
					MsgBox6("MouseRecorder has failed to save Data!" & ControlChars.CrLf & "Error: " & Err.Number & ControlChars.CrLf & "  " & Err.Description, MsgBoxStyle.Critical, "Error!")
				Else
					SaveData = False
				End If
				FileClose6(ff)
			End If
		End If
	End Sub

	Public Sub LoadDataFromFile(ByVal FName As String)
		Dim ff As Integer
		Dim Markl As String = ""
		SaveDataToFile()
		If MotionData.Count() Then 
			Do Until MotionData.Count() = 0
				MotionData.Remove(1)
			Loop
		End If
		On  Error Resume Next 
		ff = FreeFile6()
		FileOpen6(ff, FName, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		Markl = FileLineInput6(ff)
		If Markl = "[MouseMotionFile]" Then 
			Do Until EOF6(ff)
				Markl = FileLineInput6(ff)
				MotionData.Add(Markl)
				DoEvents6()
			Loop
		End If
		FileClose6(ff)
	End Sub

End Module
