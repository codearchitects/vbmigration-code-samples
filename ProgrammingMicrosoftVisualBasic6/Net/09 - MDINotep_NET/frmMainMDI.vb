' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class frmMainMDI

	Private Sub mnuFile_Click() Handles mnuFile.Click
		' enable/disable a few items in the File menu
		mnuFileSave.Enabled = Not (ActiveForm Is Nothing)
		mnuFileSaveAs.Enabled = Not (ActiveForm Is Nothing)
		mnuFileSaveAll.Enabled = Not (ActiveForm Is Nothing)
		mnuFilePrint.Enabled = Not (ActiveForm Is Nothing)
	End Sub

	Private Sub mnuFileNew_Click() Handles mnuFileNew.Click
		Dim frmDoc As New frmDocument
		frmDoc.Filename = ""
		frmDoc.Show()
	End Sub

	Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
		Dim UseCurrentForm As Boolean
		On Error Resume Next 
		' UseCurrentForm is True only if the current form is
		' and empty frmDocument form
		UseCurrentForm = (ActiveForm.txtEditor.Text = "")
		ReadFromFile("", Not UseCurrentForm)
	End Sub

	Private Sub mnuFileClose_Click() Handles mnuFileClose.Click
		' close the active form, if there is one
		If Not (ActiveForm Is Nothing) Then  Unload6(ActiveForm)
	End Sub

	Private Sub mnuFileSave_Click() Handles mnuFileSave.Click
		If Not (ActiveForm Is Nothing) Then 
			SaveToFile(ActiveForm.Filename)
		End If
	End Sub

	Private Sub mnuFileSaveAs_Click() Handles mnuFileSaveAs.Click
		If Not (ActiveForm Is Nothing) Then 
			SaveToFile(ActiveForm.Filename, True)
		End If
	End Sub

	Private Sub mnuFilePrint_Click() Handles mnuFilePrint.Click
		If Not (ActiveForm Is Nothing) Then 
			Printer6.PrintLine(ActiveForm.txtEditor.Text)
			Printer6.EndDoc()
		End If
	End Sub

	Private Sub mnuFilePrintSetup_Click() Handles mnuFilePrintSetup.Click
		With CommonDialog1
			.Flags = MSComDlg.PrinterConstants.cdlPDPrintSetup
			.ShowPrinter()
		End With
	End Sub

	Private Sub mnuFileExit_Click() Handles mnuFileExit.Click
		' unload the main form and all its children
		Unload6(Me)
	End Sub

	Private Sub mnuEdit_Click() Handles mnuEdit.Click
		' enable/disable items on the Edit menu
		On Error Resume Next 
		mnuEditItem(0).Enabled = (ActiveForm.txtEditor.SelLength > 0) ' cut
		mnuEditItem(1).Enabled = (ActiveForm.txtEditor.SelLength > 0) ' copy
		mnuEditItem(2).Enabled = (Clipboard6.GetText() <> "") ' paste
		mnuEditItem(3).Enabled = (ActiveForm.txtEditor.SelLength > 0) ' delete
		mnuEditItem(5).Enabled = (ActiveForm.txtEditor.Text <> "") ' select all
	End Sub

	Private Sub mnuEditItem_Click(ByRef Index As Short)
		Dim txtEditor As VB6WLText = ActiveForm.txtEditor
		
		' get a reference to the control on the active form
		
		Select Case Index
		Case 0 ' Cut
			Clipboard6.Clear()
			Clipboard6.SetText(txtEditor.SelText)
			txtEditor.SelText = ""
		Case 1 ' Copy
			Clipboard6.Clear()
			Clipboard6.SetText(txtEditor.SelText)
		Case 2 ' Paste
			txtEditor.SelText = Clipboard6.GetText()
		Case 3 ' Delete
			txtEditor.SelText = ""
		Case 5 ' Select All
			txtEditor.SelStart = 0
			txtEditor.SelLength = Len6(txtEditor.Text)
		Case 6 ' Time/Date
			txtEditor.SelText = Format6(Now, "hh:mm AM/PM m/d/yy")
		Case 8 ' Word Wrap
			mnuEditItem(Index).Checked = Not mnuEditItem(Index).Checked
			txtEditor.ScrollBars = IIf(mnuEditItem(Index).Checked, VBRUN.ScrollBarConstants.vbVertical, VBRUN.ScrollBarConstants.vbBoth)
		Case 9 ' Set Font
			With CommonDialog1
				On Error Resume Next 
				.Flags = MSComDlg.FontsConstants.cdlCFScreenFonts
				.FontName = txtEditor.Font.Name
				.FontSize = txtEditor.Font.Size
				.FontBold = txtEditor.Font.Bold
				.FontItalic = txtEditor.Font.Italic
				.Color = txtEditor.ForeColor
				.ShowFont()
				If Err.Number = 0 Then 
					FontChangeName6(txtEditor.Font, .FontName)
					FontChangeSize6(txtEditor.Font, .FontSize)
					FontChangeBold6(txtEditor.Font, .FontBold)
					FontChangeItalic6(txtEditor.Font, .FontItalic)
					txtEditor.ForeColor = .Color
				End If
			End With
		End Select
	End Sub

	Private Sub mnuWindowItem_Click(ByRef Index As Short)
		Select Case Index
		Case 0 ' tile horizontally
			Arrange(VBRUN.FormArrangeConstants.vbTileHorizontal)
		Case 1 ' tile vertically
			Arrange(VBRUN.FormArrangeConstants.vbTileVertical)
		Case 2 ' cascade
			Arrange(VBRUN.FormArrangeConstants.vbCascade)
		Case 3 ' arrange icons
			Arrange(VBRUN.FormArrangeConstants.vbArrangeIcons)
		End Select
	End Sub

	' open a file into the current MDI child form
	' (optionally create a new form )
	
	Public Sub ReadFromFile(ByVal Filename As String, Optional ByRef createNew As Boolean = False)
	' UPGRADE_INFO (#0551): The 'createNew' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim frmDoc As frmDocument = Nothing
		
		If Filename = "" Then 
			With CommonDialog1
				.FileName = ""
				.Filter = "All Files|*.*|Text Files (*.txt)|*.txt"
				.FilterIndex = 2
				.Flags = MSComDlg.FileOpenConstants.cdlOFNFileMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly
				.ShowOpen()
				If .FileName = "" Then  Exit Sub
				Filename = .FileName
			End With
		End If
		
		' create a new form if requested or necessary
		If createNew Then 
			frmDoc = New frmDocument()
			frmDoc.Show()
		ElseIf TypeOf ActiveForm Is frmDocument Then 
			frmDoc = ActiveForm
		Else
			frmDoc = New frmDocument()
			frmDoc.Show()
		End If
		
		On Error Resume Next 
		FileOpen6(1, Filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		frmDoc.txtEditor.Text = FileInputString6(1, LOF6(1))
		FileClose6(1)
		
		' if no error, update Filename property (and caption)
		If Err.Number = 0 Then 
			frmDoc.Filename = Filename
			frmDoc.IsDirty = False
		End If
	End Sub

	' save the contents of the current form to file
	' if argument is omitted, it is asked to the end user
	
	Public Sub SaveToFile(ByVal Filename As String, Optional ByRef SaveAs As Boolean = False)
	' UPGRADE_INFO (#0551): The 'SaveAs' parameter is neither assigned in current method nor is passed to methods that modify it. Consider changing its declaration using the ByVal keyword.
		Dim frmDoc As frmDocument = Nothing
		
		On Error Resume Next 
		
		' exit if current form isn't a frmDocument
		frmDoc = ActiveForm
		If frmDoc Is Nothing Then  Exit Sub
		
		If Filename = "" Or SaveAs Then 
			With CommonDialog1
				.CancelError = True
				.FileName = frmDoc.Filename
				.Filter = "All Files|*.*|Text Files (*.txt)|*.txt"
				.FilterIndex = 2
				.Flags = MSComDlg.FileOpenConstants.cdlOFNPathMustExist + MSComDlg.FileOpenConstants.cdlOFNHideReadOnly + MSComDlg.FileOpenConstants.cdlOFNOverwritePrompt
				.ShowSave()
				' exit if any error, or cancel was pressed
				If Err.Number Then  Exit Sub
				' use this routine is a recursive mode
				Filename = .FileName
			End With
		End If
		
		' load the file
		FileOpen6(1, Filename, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		FilePrintLine6(1, ActiveForm.txtEditor.Text)
		FileClose6(1)
		
		' if no error, update Filename property (and caption)
		If Err.Number = 0 Then 
			frmDoc.Filename = Filename
			frmDoc.IsDirty = False
		End If
	End Sub

End Class
