' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmTextBrowser

	' the Title of the dialog, used for the caption of the form
	' and in all error messages - defaults to "Readme"
	Public DialogTitle As String = ""
	
	' the text that must be loaded into the textbox
	Public Text_Renamed As String = ""
	
	' the name of the text file that must be loaded in the textbox
	' this property is used only if Text = ""
	Private m_Filename As String = ""
	
	' this is used by the Find command
	Private m_SearchText As String = ""

	Public Property Filename() As String
		Get
			Return m_Filename
	 	End Get
		Set(ByVal newValue As String)
			m_Filename = newValue
			DialogTitle = "Readme - " & newValue
	 	End Set
	End Property

	Protected Overrides Sub Form_Initialize_VB6()
		' initialize all properties
		DialogTitle = "Readme"
	End Sub

	Private Sub Form_Load() Handles MyBase.Load
		' load the string of text or the contents of the file
		' into the multiline textbox
		On Error GoTo Load_Error 
		
		' copy the DialogTitle property into the caption
		Me.Caption = DialogTitle
		
		Dim fnum As Short
		If Text_Renamed <> "" Then 
			txtBrowser.Text = Text_Renamed
			
		ElseIf Filename <> "" Then 
			fnum = FreeFile6()
			FileOpen6(fnum, Filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
			txtBrowser.Text = FileInputString6(fnum, LOF6(fnum))
			FileClose6(fnum)
		End If
		
		' disable the Copy, Print & Find buttons if there is no text
		If txtBrowser.Text = "" Then 
			cmdCopy.Enabled = False
			cmdPrint.Enabled = False
			cmdFind.Enabled = False
		End If
		Exit Sub
		
Load_Error:
		If MsgBox6("Unable to load file '" & Filename & "'", MsgBoxStyle.Critical + MsgBoxStyle.RetryCancel, DialogTitle) = MsgBoxResult.Retry Then 
			Resume 
		Else
			Unload6(Me)
			Err.Raise(Err.Number, "frmTextBrowser", Err.Description)
		End If
		
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		' evaluate the new position of all controls
		
		' the minimum size for the form
		Const MIN_WIDTH As Short = 4000
		Const MIN_HEIGHT As Short = 3000
		' the distance among the controls and the border
		Const DISTANCE As Short = 100
		
		Dim buttonLeft As Single
		
		' set a minimum size for the form
		' (these statements may fire additional resize events)
		If Width < MIN_WIDTH Then  Width = MIN_WIDTH
		If Height < MIN_HEIGHT Then  Height = MIN_HEIGHT
		
		' move the buttons
		buttonLeft = ScaleWidth - cmdOK.Width - DISTANCE
		cmdCopy.Move(buttonLeft, DISTANCE)
		cmdPrint.Move(buttonLeft, cmdCopy.Top + cmdCopy.Height + DISTANCE)
		cmdFind.Move(buttonLeft, cmdPrint.Top + cmdPrint.Height + DISTANCE)
		cmdOK.Move(buttonLeft, ScaleHeight - cmdOK.Height - DISTANCE)
		
		' resize the multiline textbox
		txtBrowser.Move(DISTANCE, DISTANCE, buttonLeft - DISTANCE * 2, ScaleHeight - DISTANCE * 2)
		
	End Sub

	Private Sub cmdOK_Click() Handles cmdOK.Click
		Unload6(Me)
	End Sub

	Private Sub cmdCopy_Click() Handles cmdCopy.Click
		Clipboard6.Clear()
		If txtBrowser.SelLength = 0 Then 
			' if not text is selected, copy the entire contents
			Clipboard6.SetText(txtBrowser.Text)
		Else
			' otherwise, copy only the selected text
			Clipboard6.SetText(txtBrowser.SelText)
		End If
	End Sub

	Private Sub cmdPrint_Click() Handles cmdPrint.Click
		' print the contents of the textbox
		Printer6.NewPage()
		Printer6.PrintLine(txtBrowser.Text)
		Printer6.EndDoc()
	End Sub

	Private Sub cmdFind_Click() Handles cmdFind.Click
		' find the next occurrence of a string
		Dim search As String = ""
		Dim index As Integer
		
		' exit if no search string has been specified
		search = InputBox6("Enter the string to search", DialogTitle, m_SearchText)
		If search = "" Then  Exit Sub
		
		' search in the text following the cursor
		m_SearchText = search
		
		index = InStr(txtBrowser.SelStart + 2, txtBrowser.Text, m_SearchText, CompareMethod.Text)
		If index = 0 Then 
			MsgBox6("Text not found", MsgBoxStyle.Exclamation, DialogTitle)
		Else
			txtBrowser.SelStart = index - 1
			txtBrowser.SelLength = Len6(m_SearchText)
		End If
		
	End Sub

End Class
