' ------------------------------------------------------------
' Code generated automatically by Code Architects' VB Migration Partner
' ------------------------------------------------------------

Option Strict Off      ' Code migrated from VB6 has Option Strict disabled by default

Friend Class Form1

	'--------------------------------------------------
	' Client demo form for CFileOp class - definitive version
	'--------------------------------------------------

	Private WithEvents Fop As CFileOp
	' this gathers all the filespec that exclude files
	Private ExcludeItems() As String
	
	Private Sub Form_Load() Handles MyBase.Load
		' withevents objects can't be autoinstancing
		Fop = New CFileOp()
	End Sub

	Private Sub txtExclude_Change() Handles txtExclude.Change
		' reset the internal file list, so that new Parsing events are fired
		Fop.FileSpec = ""
	End Sub

	Private Sub txtFilespec_Change() Handles txtFilespec.Change
		' don't enable buttons unless you can use them
		cmdParse.Enabled = (txtFilespec.Text <> "")
	End Sub

	Private Sub txtDestPath_Change() Handles txtDestPath.Change
		' don't enable buttons unless you can use them
		cmdCopy.Enabled = (txtDestPath.Text <> "")
	End Sub

	Private Sub cmdParse_Click() Handles cmdParse.Click
		' add to the listbox, show how many files match
		Dim File As Object = Nothing
		lstFiles.Clear()
		InitFOP()
		For Each File In Fop.Filenames
			lstFiles.AddItem(File)
		Next
		picStatus.Cls()
		picStatus.Print("Found " & Fop.Filenames.Count() & " files.")
	End Sub

	Private Sub cmdCopy_Click() Handles cmdCopy.Click
		' all errors are treated in the FOP_Error procedure
		On Error Resume Next 
		InitFOP()
		Fop.Copy(txtDestPath.Text)
		picStatus.Cls()
	End Sub

	Private Sub cmdMove_Click() Handles cmdMove.Click
		' all errors are treated in the FOP_Error procedure
		On Error Resume Next 
		InitFOP()
		Fop.Move(txtDestPath.Text)
		picStatus.Cls()
	End Sub

	Private Sub cmdDelete_Click() Handles cmdDelete.Click
		' all errors are treated in the FOP_Error procedure
		On Error Resume Next 
		InitFOP()
		Fop.Delete()
		picStatus.Cls()
	End Sub

	Private Sub InitFOP()
		' a useful routine shared by many procedures in the form
		Fop.FileSpec = txtFilespec.Text
		Fop.Attributes = IIf(chkHidden.Value, FileAttribute.Hidden, 0) + IIf(chkSystem.Value, FileAttribute.System, 0)
		' create the ExcludeItems array here to save time later
		ExcludeItems = Split(txtExclude.Text, ";")
	End Sub

	'-------------------------------------
	' Trapping events from CFileOp class
	'-------------------------------------
	
	Private Sub Fop_Parsing(ByRef File As String, ByRef Cancel As Boolean) Handles Fop.Parsing
		Dim filename As String = ""
		Dim i As Short
		' GetFilename is an handy method exposed by CFileOp
		filename = Fop.GetFileName(File)
		For i = LBound6(ExcludeItems) To UBound6(ExcludeItems)
			If LCase(filename) Like LCase(ExcludeItems(i)) Then 
				Cancel = True
				Exit Sub
			End If
		Next
	End Sub

	Private Sub Fop_FileCopyComplete(ByRef File As String, ByRef DestPath As String) Handles Fop.FileCopyComplete
		picStatus.Cls()
		picStatus.Print("Copied file " & File & " ==> " & DestPath)
	End Sub

	Private Sub Fop_WillCopyFile(ByRef File As String, ByRef DestPath As String, ByRef Action As ActionConstants) Handles Fop.WillCopyFile
		If chkConfirm.Value = VBRUN.CheckBoxConstants.vbUnchecked Then  Exit Sub
		Dim ok As Short = MsgBox6("Copying file " & File & " to " & DestPath & ControlChars.Cr & "Click YES to proceed, NO to skip, CANCEL to abort", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information)
		Select Case ok
		Case MsgBoxResult.Yes: Action = ActionConstants.foContinue
		Case MsgBoxResult.No: Action = ActionConstants.foSkip
		Case MsgBoxResult.Cancel: Action = ActionConstants.foAbort
		End Select
	End Sub

	Private Sub Fop_WillMoveFile(ByRef File As String, ByRef DestPath As String, ByRef Action As ActionConstants) Handles Fop.WillMoveFile
		If chkConfirm.Value = VBRUN.CheckBoxConstants.vbUnchecked Then  Exit Sub
		Dim ok As Short = MsgBox6("Moving file " & File & " to " & DestPath & ControlChars.Cr & "Click YES to proceed, NO to skip, CANCEL to abort", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information)
		Select Case ok
		Case MsgBoxResult.Yes: Action = ActionConstants.foContinue
		Case MsgBoxResult.No: Action = ActionConstants.foSkip
		Case MsgBoxResult.Cancel: Action = ActionConstants.foAbort
		End Select
	End Sub

	Private Sub Fop_WillDeleteFile(ByRef File As String, ByRef Action As ActionConstants) Handles Fop.WillDeleteFile
		If chkConfirm.Value = VBRUN.CheckBoxConstants.vbUnchecked Then  Exit Sub
		Dim ok As Short = MsgBox6("Deleting file " & File & ControlChars.Cr & "Click YES to proceed, NO to skip, CANCEL to abort", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information)
		Select Case ok
		Case MsgBoxResult.Yes: Action = ActionConstants.foContinue
		Case MsgBoxResult.No: Action = ActionConstants.foSkip
		Case MsgBoxResult.Cancel: Action = ActionConstants.foAbort
		End Select
	End Sub

	Private Sub Fop_Error(ByRef OpName As String, ByRef File As String, ByRef File2 As String, ByRef ErrCode As Short, ByRef ErrMessage As String, ByRef Action As ActionConstants) Handles Fop.Error
		If ErrCode = 76 Then 
			MsgBox6(ErrMessage, MsgBoxStyle.Critical)
			Action = ActionConstants.foAbort
		End If
	End Sub

	Private Sub Fop_ProgressPercent(ByRef Percent As Short) Handles Fop.ProgressPercent
		If chkProgress.Value Then  ShowProgress(picStatus, Percent)
	End Sub

	' a reusable routines that prints a progres bar and a percentage
	' onto a PictureBox control
	
	Private Sub ShowProgress(ByRef pic As VB6PictureBox, ByRef Percent As Short, Optional ByRef Color As Integer = VBRUN.ColorConstants.vbBlue)
		pic.Cls()
		pic.Line(VBRUN.GraphicsOptions.BoxFilled, 0, 0, pic.ScaleWidth * Percent / 100, pic.ScaleHeight, Color)
		pic.CurrentX = (pic.ScaleWidth - pic.TextWidth(CStr(Percent) & " %")) / 2
		pic.CurrentY = (pic.ScaleHeight - pic.TextHeight("%")) / 2
		pic.Print(CStr(Percent) & " %")
	End Sub

End Class
