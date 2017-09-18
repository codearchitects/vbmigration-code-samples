' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	Private Filename As String = ""
	
	Private Sub cmdPrinter_Click() Handles cmdPrinter.Click
		Dim saveSelStart As Integer
		Dim saveSelLength As Integer
		
		On Error Resume Next 
		With CommonDialog1
			.CancelError = True
			.Flags = MSComDlg.PrinterConstants.cdlPDHidePrintToFile Or MSComDlg.PrinterConstants.cdlPDNoPageNums Or MSComDlg.PrinterConstants.cdlPDReturnDC
			If RichTextBox1.SelLength = 0 Then 
				' if no text is select, disable the option on the dialog
				.Flags = .Flags Or MSComDlg.PrinterConstants.cdlPDNoSelection
			Else
				' otherwise make "Selection" the default choice
				.Flags = .Flags Or MSComDlg.PrinterConstants.cdlPDSelection
			End If
			.ShowPrinter()
			If Err.Number = 0 Then 
				If .Flags And MSComDlg.PrinterConstants.cdlPDSelection Then 
					' User decided to print the current selection,
					' UPGRADE_ISSUE (#19C8): The SelPrint method isn't supported. Invoking this method throws an exception.
					RichTextBox1.SelPrint(.hDC)
				Else
					' User decided to print the entire contents, so select it
					saveSelStart = RichTextBox1.SelStart
					saveSelLength = RichTextBox1.SelLength
					RichTextBox1.SelStart = 0
					RichTextBox1.SelLength = 999999
					' Print on the device context returned by the common dialog
					' UPGRADE_ISSUE (#19C8): The SelPrint method isn't supported. Invoking this method throws an exception.
					RichTextBox1.SelPrint(.hDC)
					' Restore old selection
					RichTextBox1.SelStart = saveSelStart
					RichTextBox1.SelLength = saveSelLength
				End If
			End If
		End With
	End Sub

	Private Sub Form_Resize() Handles MyBase.Resize
		' Some smart resizing.
		RichTextBox1.Move(0, RichTextBox1.Top, ScaleWidth, ScaleHeight - RichTextBox1.Top)
	End Sub

	Private Sub cmdColor_Click() Handles cmdColor.Click
		On Error Resume Next 
		
		With CommonDialog1
			.Flags = MSComDlg.ColorConstants.cdlCCFullOpen
			If Not IsNull6(RichTextBox1.SelColor) Then 
				.Flags = .Flags Or MSComDlg.ColorConstants.cdlCCRGBInit
				.Color = FromOleColor6(RichTextBox1.SelColor)
			End If
			.CancelError = True
			.ShowColor()
			If Err.Number = 0 Then 
				RichTextBox1.SelColor = ToOleColor6(.Color)
			End If
		End With
	End Sub

	Private Sub cmdFont_Click() Handles cmdFont.Click
		' This undocumented flag excludes vertical fonts.
		Const CF_NOVERTFONTS As Integer = &H400000I
		
		On Error Resume Next 
		
		With CommonDialog1
			.CancelError = True
			.Flags = MSComDlg.FontsConstants.cdlCFBoth Or MSComDlg.FontsConstants.cdlCFForceFontExist Or MSComDlg.FontsConstants.cdlCFEffects Or MSComDlg.FontsConstants.cdlCFLimitSize
			If IsNull6(RichTextBox1.SelFontName) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoFaceSel
			Else
				.FontName = RichTextBox1.SelFontName
			End If
			If IsNull6(RichTextBox1.SelFontSize) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoSizeSel
			Else
				.FontSize = RichTextBox1.SelFontSize
			End If
			If IsNull6(RichTextBox1.SelBold) Or IsNull6(RichTextBox1.SelItalic) Then 
				.Flags = .Flags Or MSComDlg.FontsConstants.cdlCFNoStyleSel
			Else
				.FontBold = RichTextBox1.SelBold
				.FontItalic = RichTextBox1.SelItalic
			End If
			If Not IsNull6(RichTextBox1.SelColor) Then 
				.Color = FromOleColor6(RichTextBox1.SelColor)
			End If
			.Min = 8
			.Max = 80
			.ShowFont()
			If Err.Number = 0 Then 
				RichTextBox1.SelFontName = .FontName
				RichTextBox1.SelBold = .FontBold
				RichTextBox1.SelItalic = .FontItalic
				If (.Flags And MSComDlg.FontsConstants.cdlCFNoSizeSel) = 0 Then 
					RichTextBox1.SelFontSize = .FontSize
				End If
				RichTextBox1.SelUnderline = .FontUnderline
				RichTextBox1.SelStrikeThru = .FontStrikeThru
				RichTextBox1.SelColor = ToOleColor6(.Color)
			End If
		End With
		
	End Sub

	Private Sub cmdSave_Click() Handles cmdSave.Click
		If SaveTextControl(RichTextBox1, CommonDialog1, Filename) Then 
			MsgBox6("Text has been saved to file " & Filename)
		End If
	End Sub

	Private Sub cmdOpen_Click() Handles cmdOpen.Click
		If LoadTextControl(RichTextBox1, CommonDialog1, Filename) Then 
			MsgBox6("Text has been loaded from file " & Filename)
		End If
	End Sub

	Private Sub cmdOpenMulti_Click() Handles cmdOpenMulti.Click
		Dim Filenames() As String
		If SelectMultipleFiles(CommonDialog1, "", Filenames) Then 
			' load the array of results into the RTFBox control
			RichTextBox1.Text = Join(Filenames, ControlChars.CrLf)
		End If
	End Sub

	' A reusable routine that can save the contents of a TextBox or
	' a RichTextBox control. On Exit FileName the selected filename.
	' Returns False if the command has been canceled, True otherwise.
	
	Public Function SaveTextControl(ByRef TB As Object, ByRef CD As VB6CommonDialog, ByRef Filename As String) As Boolean
		Dim filenum As Short
		On Error GoTo ExitNow 
		
		CD.Filter = "All files (*.*)|*.*|Text files|*.txt"
		CD.FilterIndex = 2
		CD.DefaultExt = "txt"
		If TypeName6(TB) = "RichTextBox" Then 
			CD.Filter = CD.Filter & "|RTF files|*.rtf"
			CD.FilterIndex = 3
			CD.DefaultExt = "rtf"
		End If
		CD.Flags = MSComDlg.FileOpenConstants.cdlOFNHideReadOnly Or MSComDlg.FileOpenConstants.cdlOFNPathMustExist Or MSComDlg.FileOpenConstants.cdlOFNOverwritePrompt Or MSComDlg.FileOpenConstants.cdlOFNNoReadOnlyReturn
		CD.DialogTitle = "Select the destination file "
		CD.FileName = Filename
		' Exit if user presses Cancel.
		CD.CancelError = True
		CD.ShowSave()
		Filename = CD.FileName
		
		' Write the control's contents.
		filenum = FreeFile6()
		FileOpen6(filenum, Filename, OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1)
		If TypeName6(TB) = "RichTextBox" Then 
			FilePrint6(filenum, CObj(TB).TextRTF)
		Else
			FilePrint6(filenum, TB.Text)
		End If
		FileClose6(filenum)
		' Signal success.
		Return True
ExitNow:
		
	End Function

	' A reusable routine that can load the contents of a TextBox or
	' a RichTextBox control. On exit, Filename contains the selected filename.
	' Returns False if the command has been canceled, True otherwise.
	
	Public Function LoadTextControl(ByRef TB As Object, ByRef CD As VB6CommonDialog, ByRef Filename As String) As Boolean
		Dim filenum As Short
		On Error GoTo ExitNow 
		
		CD.Filter = "All files (*.*)|*.*|Text files|*.txt"
		CD.FilterIndex = 2
		CD.DefaultExt = "txt"
		If TypeName6(TB) = "RichTextBox" Then 
			CD.Filter = CD.Filter & "|RTF files|*.rtf"
			CD.FilterIndex = 3
			CD.DefaultExt = "rtf"
		End If
		CD.Flags = MSComDlg.FileOpenConstants.cdlOFNHideReadOnly Or MSComDlg.FileOpenConstants.cdlOFNFileMustExist Or MSComDlg.FileOpenConstants.cdlOFNNoReadOnlyReturn
		CD.DialogTitle = "Select the source file "
		CD.FileName = Filename
		' Exit if user presses Cancel.
		CD.CancelError = True
		CD.ShowOpen()
		Filename = CD.FileName
		
		' Read the file's contents into the control.
		filenum = FreeFile6()
		FileOpen6(filenum, Filename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1)
		If TypeName6(TB) = "RichTextBox" Then 
			CObj(TB).TextRTF = FileInputString6(filenum, LOF6(filenum))
		Else
			TB.Text = FileInputString6(filenum, LOF6(filenum))
		End If
		FileClose6(filenum)
		' Signal success.
		Return True
ExitNow:
		
	End Function

	' Reusable routines that displays a multi-selection FileOpen dialog
	' and returns an array of strings with all the selected files.
	' Returns False if the command has been canceled, True otherwise.
	
	Public Function SelectMultipleFiles(ByRef CD As VB6CommonDialog, ByRef Filter As String, ByRef Filenames() As String) As Boolean
		On Error GoTo ExitNow 
		
		CD.Filter = "All files (*.*)|*.*|" & Filter
		CD.FilterIndex = 1
		CD.Flags = MSComDlg.FileOpenConstants.cdlOFNAllowMultiselect Or MSComDlg.FileOpenConstants.cdlOFNFileMustExist Or MSComDlg.FileOpenConstants.cdlOFNExplorer
		CD.DialogTitle = "Select one or more files"
		CD.MaxFileSize = 10240
		CD.FileName = ""
		' Exit if user presses Cancel.
		CD.CancelError = True
		CD.ShowOpen()
		' Parse the result to get filenames.
		Filenames = Split(CD.FileName, ControlChars.NullChar)
		' Signal success.
		Return True
		
ExitNow:
	End Function

End Class
